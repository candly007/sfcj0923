#!/usr/bin/env bash
set -euo pipefail
umask 077

MAIN_AUTH_URL="http://124.71.236.71:5180"
BASE="${PRIVATE_LICENSE_INSTALL_DIR:-/opt/shunfeng-private-license}"
DATA="${PRIVATE_LICENSE_DATA_DIR:-/var/lib/shunfeng-private}"
LICENSE_ID="${PRIVATE_LICENSE_ID:-}"
BOOTSTRAP_CODE="${PRIVATE_BOOTSTRAP_CODE:-}"
LICENSE_CARD="${PRIVATE_LICENSE_CARD:-}"
REQUESTED_VERSION=""
BIND_ADDRESS="${PRIVATE_LICENSE_BIND_ADDRESS:-0.0.0.0}"

while [[ $# -gt 0 ]]; do
  case "$1" in
    --license-id) LICENSE_ID="${2:-}"; shift 2;;
    --bootstrap-code) BOOTSTRAP_CODE="${2:-}"; shift 2;;
    --card) LICENSE_CARD="${2:-}"; shift 2;;
    --version) REQUESTED_VERSION="${2:-}"; shift 2;;
    --bind-address) BIND_ADDRESS="${2:-}"; shift 2;;
    *) echo "未知参数: $1" >&2; exit 2;;
  esac
done

[[ $EUID -eq 0 ]] || { echo "请使用 root 或 sudo 执行" >&2; exit 1; }
[[ -n "$LICENSE_ID" && -n "$BOOTSTRAP_CODE" ]] || { echo "需要 --license-id 和 --bootstrap-code" >&2; exit 2; }
if [[ -z "$LICENSE_CARD" && -r /dev/tty ]]; then
  read -r -s -p "请输入该卡密: " LICENSE_CARD < /dev/tty
  echo >&2
fi
[[ -n "$LICENSE_CARD" ]] || { echo "缺少卡密，请使用 --card 或交互输入" >&2; exit 2; }

for tool in curl python3 sha256sum openssl install base64; do
  command -v "$tool" >/dev/null 2>&1 || { echo "缺少依赖: $tool" >&2; exit 1; }
done
python3 - "$BIND_ADDRESS" <<'PY'
import ipaddress, sys
try:
    address = ipaddress.ip_address(sys.argv[1])
except ValueError:
    raise SystemExit('绑定地址必须是 IPv4 地址')
if address.version != 4 or address.is_loopback:
    raise SystemExit('绑定地址不能是回环地址')
PY

TMP="$(mktemp -d)"
cleanup() { rm -rf "$TMP"; }
trap cleanup EXIT
MANIFEST="$TMP/manifest.json"
DOWNLOADED="$TMP/PrivateLicenseService"
PAYLOAD="$TMP/signature.payload"
SIGNATURE="$TMP/signature.bin"
PUBLIC_KEY="$TMP/main-public-key.pem"

python3 - "$LICENSE_ID" "$BOOTSTRAP_CODE" "$REQUESTED_VERSION" > "$TMP/request.json" <<'PY'
import json, sys
print(json.dumps({"licenseId": sys.argv[1], "bootstrapCode": sys.argv[2], "version": sys.argv[3]}, separators=(',', ':')))
PY

set +e
HTTP_CODE="$(curl --silent --show-error --retry 2 --connect-timeout 10 --max-time 30 \
  -H 'Content-Type: application/json' --data-binary "@$TMP/request.json" \
  "$MAIN_AUTH_URL/api/private/bootstrap/manifest" -o "$MANIFEST" -w '%{http_code}')"
CURL_STATUS=$?
set -e
if [[ "$CURL_STATUS" -ne 0 ]]; then
  echo "无法连接主授权服务器" >&2
  exit 1
fi
if [[ "$HTTP_CODE" != "200" ]]; then
  BOOTSTRAP_ERROR="$(python3 - "$MANIFEST" <<'PY'
import json, sys
try:
    print(json.load(open(sys.argv[1], encoding='utf-8')).get('error', 'private_bootstrap_invalid'))
except Exception:
    print('private_bootstrap_invalid')
PY
)"
  if [[ "$BOOTSTRAP_ERROR" == "private_node_already_bound" ]]; then
    echo "该卡密已经绑定另一台私有授权服务器，禁止重复部署" >&2
  else
    echo "卡密或一次性部署命令验证失败（HTTP $HTTP_CODE）" >&2
  fi
  exit 1
fi

mapfile -t META < <(python3 - "$MANIFEST" <<'PY'
import json, sys
doc = json.load(open(sys.argv[1], encoding='utf-8'))
required = ('licenseId', 'version', 'sha256', 'expiresAtUnix', 'signaturePayload', 'signature')
if any(k not in doc for k in required): raise SystemExit('主授权返回的部署清单不完整')
for k in required: print(str(doc[k]))
PY
)
[[ "${META[0]}" == "$LICENSE_ID" ]] || { echo "部署清单卡密 ID 不匹配" >&2; exit 1; }
VERSION="${META[1]}"; EXPECTED_SHA256="${META[2]}"; EXPIRES_AT="${META[3]}"; PAYLOAD_TEXT="${META[4]}"; SIGNATURE_B64="${META[5]}"
[[ "$VERSION" =~ ^[A-Za-z0-9._-]{1,128}$ ]] || { echo "部署清单版本无效" >&2; exit 1; }
[[ "$EXPECTED_SHA256" =~ ^[0-9A-Fa-f]{64}$ ]] || { echo "部署清单 SHA-256 无效" >&2; exit 1; }
[[ "$EXPIRES_AT" =~ ^[0-9]+$ ]] || { echo "部署清单有效期无效" >&2; exit 1; }
[[ "$EXPIRES_AT" -gt "$(date +%s)" ]] || { echo "一次性部署码已过期" >&2; exit 1; }
if [[ -n "$REQUESTED_VERSION" && "$REQUESTED_VERSION" != "$VERSION" ]]; then
  echo "请求版本不是当前发布版本" >&2; exit 1
fi
EXPECTED_PAYLOAD="private-binary-v1|$LICENSE_ID|$VERSION|${EXPECTED_SHA256^^}|$EXPIRES_AT"
[[ "$PAYLOAD_TEXT" == "$EXPECTED_PAYLOAD" ]] || { echo "部署清单签名载荷与返回字段不一致" >&2; exit 1; }

printf '%s\n' '-----BEGIN PUBLIC KEY-----' \
  'MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAEN+o4Ok6LvyfKnZWmTyy2bxLRbZEP' \
  '0jk/Kt40IkhqMr9SY1til/jSrk/qNuiiyRaSemAcfH3kHe/ebhSwZMDXKg==' \
  '-----END PUBLIC KEY-----' > "$PUBLIC_KEY"
printf '%s' "$PAYLOAD_TEXT" > "$PAYLOAD"
printf '%s' "$SIGNATURE_B64" | base64 -d > "$SIGNATURE"
# .NET ECDSA uses IEEE P1363 (R || S) by default, while `openssl dgst`
# expects an ASN.1 DER ECDSA signature. This endpoint always emits the
# fixed-width 64-byte P-256 form, so reject anything else before converting.
python3 - "$SIGNATURE" <<'PY'
from pathlib import Path
import sys

path = Path(sys.argv[1])
raw = path.read_bytes()
if len(raw) != 64:
    raise SystemExit('部署清单签名格式无效')

def der_integer(value):
    value = value.lstrip(b'\x00') or b'\x00'
    if value[0] & 0x80:
        value = b'\x00' + value
    return b'\x02' + bytes((len(value),)) + value

body = der_integer(raw[:32]) + der_integer(raw[32:])
path.write_bytes(b'\x30' + bytes((len(body),)) + body)
PY
openssl dgst -sha256 -verify "$PUBLIC_KEY" -signature "$SIGNATURE" "$PAYLOAD" | grep -qx 'Verified OK' || {
  echo "部署清单签名校验失败" >&2; exit 1;
}

curl --fail --silent --show-error --retry 2 --connect-timeout 10 --max-time 180 \
  -H 'Content-Type: application/json' --data-binary "@$TMP/request.json" \
  "$MAIN_AUTH_URL/api/private/bootstrap/download" -o "$DOWNLOADED"
ACTUAL_SHA256="$(sha256sum "$DOWNLOADED" | awk '{print toupper($1)}')"
[[ "$ACTUAL_SHA256" == "${EXPECTED_SHA256^^}" ]] || { echo "下载文件 SHA-256 不匹配" >&2; exit 1; }
[[ -s "$DOWNLOADED" ]] || { echo "下载文件为空" >&2; exit 1; }

mkdir -p "$BASE" "$DATA"
install -m 0750 "$DOWNLOADED" "$BASE/PrivateLicenseService"
id shunfeng-private >/dev/null 2>&1 || useradd --system --home "$DATA" --shell /usr/sbin/nologin shunfeng-private
cat > "$DATA/bootstrap.env" <<EOF
PRIVATE_LICENSE_ID=$LICENSE_ID
PRIVATE_BOOTSTRAP_CODE=$BOOTSTRAP_CODE
PRIVATE_LICENSE_CARD=$LICENSE_CARD
PRIVATE_LICENSE_DATA_DIR=$DATA
EOF
chmod 600 "$DATA/bootstrap.env"
cat > /etc/systemd/system/shunfeng-private-license.service <<EOF
[Unit]
Description=Private License Service
After=network-online.target

[Service]
WorkingDirectory=$BASE
ExecStart=$BASE/PrivateLicenseService --urls http://${BIND_ADDRESS}:5190
EnvironmentFile=$DATA/bootstrap.env
Restart=always
RestartSec=3
User=shunfeng-private
NoNewPrivileges=true
PrivateTmp=true
ProtectSystem=strict
ProtectHome=true
ReadWritePaths=$DATA

[Install]
WantedBy=multi-user.target
EOF
chown -R shunfeng-private:shunfeng-private "$DATA" "$BASE"
systemctl daemon-reload
# A repeated deployment replaces bootstrap.env while the unit may already be
# running.  --now does not reload an active process, so restart explicitly to
# make the new card, deployment code, and node identity take effect.
systemctl enable shunfeng-private-license.service
systemctl restart shunfeng-private-license.service

for _ in $(seq 1 30); do
  if curl --fail --silent --max-time 3 http://127.0.0.1:5190/health | grep -q '"configured":true'; then
    sed -i '/^PRIVATE_LICENSE_CARD=/d;/^PRIVATE_BOOTSTRAP_CODE=/d' "$DATA/bootstrap.env"
    systemctl daemon-reload
    PUBLIC_IP="$(curl -4fsS --max-time 5 https://api.ipify.org 2>/dev/null || true)"
    if [[ ! "$PUBLIC_IP" =~ ^[0-9]+(\.[0-9]+){3}$ ]]; then PUBLIC_IP="$BIND_ADDRESS"; fi
    echo "私有授权后台：http://${PUBLIC_IP}:5190/"
    echo "监听地址：${BIND_ADDRESS}:5190"
    echo "节点状态文件：$DATA/node.json（卡密仅保存为哈希）"
    exit 0
  fi
  sleep 1
done
BOOTSTRAP_ERROR="$(curl -fsS --max-time 3 http://127.0.0.1:5190/health 2>/dev/null | python3 -c 'import json,sys; print(json.load(sys.stdin).get("error", ""))' 2>/dev/null || true)"
if [[ -n "$BOOTSTRAP_ERROR" ]]; then
  echo "私有授权部署失败：$BOOTSTRAP_ERROR" >&2
else
  echo "子节点已启动但尚未完成登记，请查看 journalctl -u shunfeng-private-license.service" >&2
fi
exit 1
