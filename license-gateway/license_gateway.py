#!/usr/bin/env python3
"""HTTP gateway for the Shunfeng license service.

The closed-source .NET service remains the authority for signatures, expiry,
build admission, revocation, and private-node workflows.  This gateway adds
the source-IP aware binding policy that cannot be preserved through a normal
loopback reverse proxy, plus the monthly rebind counter.

The code stays compatible with the Python 3.6 runtime used by the existing
CentOS deployment.
"""

from __future__ import print_function

import hashlib
import ipaddress
import json
import os
import re
import tempfile
import threading
import time
from http.server import BaseHTTPRequestHandler, HTTPServer
from socketserver import ThreadingMixIn
from urllib.error import HTTPError, URLError
from urllib.request import Request, urlopen


CORE_URL = os.environ.get("LICENSE_CORE_URL", "http://127.0.0.1:5181").rstrip("/")
LISTEN_HOST = os.environ.get("LICENSE_GATEWAY_HOST", "0.0.0.0")
LISTEN_PORT = int(os.environ.get("LICENSE_GATEWAY_PORT", "5180"))
DATA_DIR = os.environ.get("LICENSE_DATA_DIR", "/var/lib/shunfeng-license/data")
POLICY_FILE = os.environ.get("LICENSE_REBIND_POLICY_FILE", os.path.join(DATA_DIR, "rebind-policy.json"))
ADMIN_TOKEN = os.environ.get("LICENSE_ADMIN_TOKEN", "")
MAX_BODY = 8 * 1024 * 1024
TIMEOUT = float(os.environ.get("LICENSE_GATEWAY_TIMEOUT", "15"))

POLICY_LOCK = threading.RLock()
CARD_LOCKS = {}
CARD_LOCKS_LOCK = threading.Lock()


class ThreadingHTTPServer(ThreadingMixIn, HTTPServer):
    daemon_threads = True


def now_month():
    return time.strftime("%Y-%m", time.gmtime())


def now_iso():
    return time.strftime("%Y-%m-%dT%H:%M:%SZ", time.gmtime())


def normalize_card(value):
    return str(value or "").strip().upper()


def card_hash(value):
    return hashlib.sha256(normalize_card(value).encode("utf-8")).hexdigest().upper()


def client_ip(handler):
    value = handler.client_address[0] if handler.client_address else ""
    try:
        address = ipaddress.ip_address(value)
        if getattr(address, "ipv4_mapped", None):
            return str(address.ipv4_mapped)
        return str(address)
    except ValueError:
        return value or "unknown"


def json_bytes(value):
    return json.dumps(value, ensure_ascii=False, separators=(",", ":")).encode("utf-8")


def json_load(raw):
    if not raw:
        return None
    try:
        return json.loads(raw.decode("utf-8"))
    except (ValueError, UnicodeDecodeError):
        return None


def read_policy():
    try:
        with open(POLICY_FILE, "r", encoding="utf-8") as stream:
            value = json.load(stream)
        if isinstance(value, dict) and isinstance(value.get("licenses"), dict):
            return value
    except (IOError, ValueError, TypeError):
        pass
    return {"version": 1, "licenses": {}, "cardHashes": {}}


POLICIES = read_policy()
if not isinstance(POLICIES.get("licenses"), dict):
    POLICIES["licenses"] = {}
if not isinstance(POLICIES.get("cardHashes"), dict):
    POLICIES["cardHashes"] = {}


def save_policy():
    directory = os.path.dirname(POLICY_FILE) or "."
    if not os.path.isdir(directory):
        os.makedirs(directory)
    fd, temporary = tempfile.mkstemp(prefix=".rebind-policy.", dir=directory)
    try:
        with os.fdopen(fd, "w", encoding="utf-8") as stream:
            json.dump(POLICIES, stream, ensure_ascii=False, indent=2, sort_keys=True)
            stream.write("\n")
        os.replace(temporary, POLICY_FILE)
    finally:
        try:
            if os.path.exists(temporary):
                os.unlink(temporary)
        except OSError:
            pass


def policy_for(license_id, details=None):
    with POLICY_LOCK:
        item = POLICIES["licenses"].get(license_id)
        if not isinstance(item, dict):
            item = {}
            if isinstance(details, dict):
                item.update({
                    "bindIp": bool(details.get("bindIp", True)),
                    "allowedIps": list(details.get("allowedIps") or []),
                    "explicitAllowedIps": False,
                    "currentIps": list(details.get("boundIps") or []),
                    "currentInstallIds": list(details.get("installIds") or []),
                })
            else:
                item.update({"bindIp": True, "allowedIps": [], "explicitAllowedIps": False,
                             "currentIps": [], "currentInstallIds": []})
            item.update({"monthlyLimit": 0, "month": now_month(), "used": 0,
                         "updatedAt": now_iso()})
            POLICIES["licenses"][license_id] = item
            save_policy()
        return item


def reset_month(item):
    month = now_month()
    if item.get("month") != month:
        item["month"] = month
        item["used"] = 0
        return True
    return False


def get_card_lock(license_id):
    with CARD_LOCKS_LOCK:
        lock = CARD_LOCKS.get(license_id)
        if lock is None:
            lock = threading.RLock()
            CARD_LOCKS[license_id] = lock
        return lock


def admin_headers():
    return {"X-Admin-Token": ADMIN_TOKEN}


def core_request(path, method="GET", body=None, headers=None):
    if body is None:
        data = None
    elif isinstance(body, bytes):
        data = body
    else:
        data = json_bytes(body)
    request_headers = {"Accept": "application/json"}
    if headers:
        request_headers.update(headers)
    if data is not None:
        request_headers["Content-Type"] = "application/json"
    request = Request(CORE_URL + path, data=data, headers=request_headers, method=method)
    try:
        with urlopen(request, timeout=TIMEOUT) as response:
            return response.getcode(), response.headers, response.read()
    except HTTPError as error:
        return error.code, error.headers, error.read()
    except URLError as error:
        payload = {"valid": False, "error": "license_core_unavailable", "detail": str(error.reason)}
        return 503, {}, json_bytes(payload)
    except Exception as error:
        payload = {"valid": False, "error": "license_core_unavailable", "detail": str(error)}
        return 503, {}, json_bytes(payload)


def core_json(path, method="GET", body=None):
    status, headers, raw = core_request(path, method, body, admin_headers())
    return status, json_load(raw), headers


def valid_admin(handler):
    return bool(ADMIN_TOKEN) and handler.headers.get("X-Admin-Token", "") == ADMIN_TOKEN


def copy_response_headers(source):
    result = {}
    for name in ("Content-Type", "Cache-Control", "ETag", "Last-Modified"):
        value = source.get(name) if source else None
        if value:
            result[name] = value
    return result


def license_failure(error, license_id=None, body=None):
    result = {
        "valid": False,
        "error": error,
        "licenseId": license_id,
        "expiresAt": None,
        "allFeatures": False,
        "product": (body or {}).get("product", "shunfeng-plugin"),
        "buildId": (body or {}).get("buildId", ""),
        "buildSequence": (body or {}).get("buildSequence", 0),
        "customerId": (body or {}).get("customerId", ""),
        "binaryHash": (body or {}).get("binaryHash", ""),
        "signature": None,
        "issuedAtUnix": 0,
        "leaseExpiresAtUnix": 0,
    }
    return 403, {}, json_bytes(result)


def find_license_id(card):
    digest = card_hash(card)
    with POLICY_LOCK:
        known = POLICIES["cardHashes"].get(digest)
        if known:
            return known
    status, value, _ = core_json("/api/admin/licenses")
    if status != 200 or not isinstance(value, list):
        return None
    with POLICY_LOCK:
        for item in value:
            if not isinstance(item, dict):
                continue
            current = item.get("card")
            license_id = item.get("id")
            if current and license_id:
                POLICIES["cardHashes"][card_hash(current)] = license_id
        result = POLICIES["cardHashes"].get(digest)
        save_policy()
        return result


def ensure_core_binding_disabled(license_id):
    # The gateway owns the real source-IP policy. The core only sees loopback.
    status, _, _ = core_json("/api/admin/licenses/%s/settings" % license_id, "POST", {"bindIp": False})
    return 200 <= status < 300


def update_binding_after_success(item, install_id, source_ip, rebind):
    current_ids = list(item.get("currentInstallIds") or [])
    current_ips = list(item.get("currentIps") or [])
    if rebind:
        current_ids = []
        current_ips = []
    if install_id and install_id not in current_ids:
        current_ids.append(install_id)
    if source_ip and source_ip not in current_ips:
        current_ips.append(source_ip)
    item["currentInstallIds"] = current_ids[-64:]
    item["currentIps"] = current_ips[-64:]
    item["updatedAt"] = now_iso()


class GatewayHandler(BaseHTTPRequestHandler):
    protocol_version = "HTTP/1.1"

    def log_message(self, format_string, *args):
        print("[%s] %s" % (time.strftime("%Y-%m-%d %H:%M:%S"), format_string % args), flush=True)

    def read_body(self):
        length = int(self.headers.get("Content-Length", "0") or 0)
        if length < 0 or length > MAX_BODY:
            raise ValueError("request body too large")
        return self.rfile.read(length) if length else b""

    def write_response(self, status, headers, body):
        body = body or b""
        self.send_response(status)
        for name, value in (headers or {}).items():
            if name.lower() not in ("content-length", "connection", "transfer-encoding"):
                self.send_header(name, value)
        self.send_header("Content-Length", str(len(body)))
        self.send_header("Connection", "close")
        self.end_headers()
        if body:
            self.wfile.write(body)
        self.close_connection = True

    def do_GET(self):
        self.handle_request("GET")

    def do_HEAD(self):
        self.handle_request("HEAD")

    def do_POST(self):
        self.handle_request("POST")

    def do_PUT(self):
        self.handle_request("PUT")

    def do_DELETE(self):
        self.handle_request("DELETE")

    def handle_request(self, method):
        try:
            raw = self.read_body()
            path = self.path.split("?", 1)[0]
            if path == "/api/license/activate" and method == "POST":
                status, headers, body = self.handle_activate(raw)
            elif path == "/api/admin/licenses" and method == "GET":
                status, headers, body = self.handle_admin_list()
            elif path == "/api/admin/licenses" and method == "POST":
                status, headers, body = self.handle_admin_create(raw)
            elif re.match(r"^/api/admin/licenses/[^/]+/details$", path) and method == "GET":
                status, headers, body = self.handle_details(path)
            elif re.match(r"^/api/admin/licenses/[^/]+/settings$", path) and method == "POST":
                status, headers, body = self.handle_settings(path, raw)
            elif re.match(r"^/api/admin/licenses/[^/]+/(unbind|ips)$", path) and method == "POST":
                status, headers, body = self.handle_binding_admin(path, raw)
            elif re.match(r"^/api/admin/licenses/[^/]+$", path) and method == "DELETE":
                status, headers, body = self.handle_delete(path, raw)
            else:
                status, headers, body = self.forward(method, path, raw)
            self.write_response(status, headers, body)
        except ValueError as error:
            self.write_response(400, {"Content-Type": "application/json; charset=utf-8"}, json_bytes({"error": str(error)}))
        except Exception as error:
            self.log_message("gateway error: %s", error)
            self.write_response(500, {"Content-Type": "application/json; charset=utf-8"}, json_bytes({"error": "gateway_error"}))

    def forward(self, method, path, raw, extra_headers=None):
        headers = {}
        for name in ("Accept", "Content-Type", "User-Agent", "X-Admin-Token"):
            value = self.headers.get(name)
            if value:
                headers[name] = value
        if extra_headers:
            headers.update(extra_headers)
        status, upstream_headers, body = core_request(path, method, raw if raw else None, headers)
        return status, copy_response_headers(upstream_headers), body

    def handle_activate(self, raw):
        body = json_load(raw)
        if not isinstance(body, dict):
            return license_failure("invalid_json", body=body if isinstance(body, dict) else {})
        license_value = normalize_card(body.get("license"))
        install_id = str(body.get("installId") or "").strip()
        challenge = str(body.get("challenge") or "").strip()
        if not license_value or not install_id or not challenge:
            return self.forward("POST", "/api/license/activate", raw)

        license_id = find_license_id(license_value)
        if not license_id:
            return self.forward("POST", "/api/license/activate", raw)

        lock = get_card_lock(license_id)
        with lock:
            detail_status, details, _ = core_json("/api/admin/licenses/%s/details" % license_id)
            if detail_status != 200 or not isinstance(details, dict):
                return self.forward("POST", "/api/license/activate", raw)
            if details.get("privateEnabled"):
                return self.forward("POST", "/api/license/activate", raw)

            item = policy_for(license_id, details)
            reset_month(item)
            source = client_ip(self)
            current_ids = list(item.get("currentInstallIds") or details.get("installIds") or [])
            current_ips = list(item.get("currentIps") or details.get("boundIps") or [])
            item["currentInstallIds"] = current_ids
            item["currentIps"] = current_ips
            bind_ip = bool(item.get("bindIp", details.get("bindIp", True)))
            explicit_ips = bool(item.get("explicitAllowedIps", False))
            allowed_ips = list(item.get("allowedIps") or details.get("allowedIps") or [])
            max_activations = int(details.get("maxActivations") or 1)
            existing = bool(current_ids or current_ips)
            same_install = install_id in current_ids
            same_ip = source in current_ips

            if bind_ip and explicit_ips and allowed_ips and source not in allowed_ips:
                return license_failure("ip_not_allowed", license_id, body)

            rebind = bind_ip and existing and (not same_install or not same_ip)
            capacity_available = len(current_ids) < max_activations
            if rebind and not same_install and capacity_available and same_ip:
                rebind = False
            if rebind:
                limit = max(0, int(item.get("monthlyLimit") or 0))
                used = max(0, int(item.get("used") or 0))
                if limit > 0 and used >= limit:
                    with POLICY_LOCK:
                        item["updatedAt"] = now_iso()
                        save_policy()
                    return license_failure("monthly_rebind_limit", license_id, body)
                if not ensure_core_binding_disabled(license_id):
                    return license_failure("license_core_unavailable", license_id, body)
                unbind_status, _, _ = core_json("/api/admin/licenses/%s/unbind" % license_id, "POST", {"clearAllowedIps": False})
                if not (200 <= unbind_status < 300):
                    return license_failure("license_rebind_failed", license_id, body)
            elif bind_ip:
                if not ensure_core_binding_disabled(license_id):
                    return license_failure("license_core_unavailable", license_id, body)

            status, headers, response = self.forward("POST", "/api/license/activate", raw)
            result = json_load(response)
            if 200 <= status < 300 and isinstance(result, dict) and result.get("valid"):
                with POLICY_LOCK:
                    if rebind:
                        item["used"] = max(0, int(item.get("used") or 0)) + 1
                    if bind_ip and source not in allowed_ips and not explicit_ips:
                        allowed_ips.append(source)
                        item["allowedIps"] = allowed_ips[-64:]
                    update_binding_after_success(item, install_id, source, rebind)
                    save_policy()
            return status, headers, response

    def handle_admin_list(self):
        status, headers, body = self.forward("GET", "/api/admin/licenses", b"")
        value = json_load(body)
        if status != 200 or not isinstance(value, list):
            return status, headers, body
        with POLICY_LOCK:
            for record in value:
                if not isinstance(record, dict):
                    continue
                license_id = record.get("id")
                card = record.get("card")
                if not license_id:
                    continue
                if card:
                    POLICIES["cardHashes"][card_hash(card)] = license_id
                item = policy_for(license_id, record)
                record["bindIp"] = bool(item.get("bindIp", record.get("bindIp", True)))
                record["monthlyRebindLimit"] = int(item.get("monthlyLimit") or 0)
                record["monthlyRebindUsed"] = int(item.get("used") or 0) if item.get("month") == now_month() else 0
                record["monthlyRebindMonth"] = item.get("month", now_month())
            save_policy()
        return status, headers, json_bytes(value)

    def handle_admin_create(self, raw):
        body = json_load(raw)
        if not isinstance(body, dict):
            return self.forward("POST", "/api/admin/licenses", raw)
        requested_bind = bool(body.get("bindIp", True))
        monthly = max(0, min(10000, int(body.get("monthlyRebindLimit", 0) or 0)))
        upstream = dict(body)
        upstream["bindIp"] = False
        upstream.pop("monthlyRebindLimit", None)
        status, headers, response = self.forward("POST", "/api/admin/licenses", json_bytes(upstream))
        result = json_load(response)
        if status == 200 and valid_admin(self) and isinstance(result, dict):
            with POLICY_LOCK:
                for card in result.get("cards") or []:
                    license_id = card.get("id")
                    if not license_id:
                        continue
                    POLICIES["cardHashes"][card_hash(card.get("card"))] = license_id
                    POLICIES["licenses"][license_id] = {
                        "bindIp": requested_bind, "allowedIps": list(body.get("allowedIps") or []),
                        "explicitAllowedIps": bool(body.get("allowedIps")), "currentIps": [],
                        "currentInstallIds": [], "monthlyLimit": monthly, "month": now_month(),
                        "used": 0, "updatedAt": now_iso()
                    }
                save_policy()
        return status, headers, response

    def handle_details(self, path):
        status, headers, body = self.forward("GET", path, b"")
        value = json_load(body)
        license_id = path.split("/")[4] if len(path.split("/")) > 4 else ""
        if status == 200 and isinstance(value, dict) and license_id:
            with POLICY_LOCK:
                item = policy_for(license_id, value)
                value["bindIp"] = bool(item.get("bindIp", value.get("bindIp", True)))
                value["monthlyRebindLimit"] = int(item.get("monthlyLimit") or 0)
                value["monthlyRebindUsed"] = int(item.get("used") or 0) if item.get("month") == now_month() else 0
                value["monthlyRebindMonth"] = item.get("month", now_month())
                value["rebindPolicy"] = "gateway"
                body = json_bytes(value)
        return status, headers, body

    def handle_settings(self, path, raw):
        body = json_load(raw)
        authorized = valid_admin(self)
        upstream = dict(body) if isinstance(body, dict) else body
        monthly_present = isinstance(body, dict) and any(k in body for k in ("monthlyRebindLimit", "monthlyLimit", "rebindLimit"))
        monthly = None
        if isinstance(body, dict):
            for key in ("monthlyRebindLimit", "monthlyLimit", "rebindLimit"):
                if key in body:
                    monthly = max(0, min(10000, int(body.get(key) or 0)))
                    break
            upstream = dict(body)
            for key in ("monthlyRebindLimit", "monthlyLimit", "rebindLimit"):
                upstream.pop(key, None)
            if "bindIp" in upstream:
                upstream["bindIp"] = False
        status, headers, response = self.forward("POST", path, json_bytes(upstream) if isinstance(upstream, dict) else raw)
        if 200 <= status < 300 and authorized and isinstance(body, dict):
            license_id = path.split("/")[4]
            with POLICY_LOCK:
                item = policy_for(license_id)
                if "bindIp" in body:
                    item["bindIp"] = bool(body.get("bindIp"))
                if monthly_present and monthly is not None:
                    item["monthlyLimit"] = monthly
                item["updatedAt"] = now_iso()
                save_policy()
        return status, headers, response

    def handle_binding_admin(self, path, raw):
        body = json_load(raw)
        upstream = dict(body) if isinstance(body, dict) else body
        if isinstance(upstream, dict) and path.endswith("/ips"):
            upstream["bindIp"] = False
        status, headers, response = self.forward("POST", path, json_bytes(upstream) if isinstance(upstream, dict) else raw)
        if 200 <= status < 300 and valid_admin(self):
            license_id = path.split("/")[4]
            with POLICY_LOCK:
                item = policy_for(license_id)
                if path.endswith("/ips") and isinstance(body, dict):
                    item["bindIp"] = bool(body.get("bindIp", True))
                    item["allowedIps"] = list(body.get("ips") or [])
                    item["explicitAllowedIps"] = True
                    if body.get("clearBindings"):
                        item["currentIps"] = []
                        item["currentInstallIds"] = []
                elif isinstance(body, dict) and body.get("clearAllowedIps"):
                    item["allowedIps"] = []
                    item["explicitAllowedIps"] = False
                    item["currentIps"] = []
                    item["currentInstallIds"] = []
                else:
                    item["currentIps"] = []
                    item["currentInstallIds"] = []
                item["updatedAt"] = now_iso()
                save_policy()
        return status, headers, response

    def handle_delete(self, path, raw):
        status, headers, response = self.forward("DELETE", path, raw)
        if 200 <= status < 300 and valid_admin(self):
            license_id = path.split("/")[4]
            with POLICY_LOCK:
                POLICIES["licenses"].pop(license_id, None)
                for digest, value in list(POLICIES["cardHashes"].items()):
                    if value == license_id:
                        POLICIES["cardHashes"].pop(digest, None)
                save_policy()
        return status, headers, response


def main():
    if not ADMIN_TOKEN:
        raise SystemExit("LICENSE_ADMIN_TOKEN is required")
    server = ThreadingHTTPServer((LISTEN_HOST, LISTEN_PORT), GatewayHandler)
    print("license gateway listening on %s:%s -> %s" % (LISTEN_HOST, LISTEN_PORT, CORE_URL), flush=True)
    server.serve_forever()


if __name__ == "__main__":
    main()
