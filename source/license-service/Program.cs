using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Globalization;
using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<JsonOptions>(options => options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase);
builder.Services.AddSingleton<LicenseStore>();

var app = builder.Build();
var store = app.Services.GetRequiredService<LicenseStore>();
var rateWindows = new ConcurrentDictionary<string, RateWindow>(StringComparer.Ordinal);

app.Use(async (context, next) =>
{
    var key = context.Connection.RemoteIpAddress?.ToString() ?? "unknown";
    var window = rateWindows.GetOrAdd(key, _ => new RateWindow());
    bool allowed;
    lock (window)
    {
        var now = DateTimeOffset.UtcNow;
        if (now - window.Start >= TimeSpan.FromMinutes(1))
        {
            window.Start = now;
            window.Count = 0;
        }
        allowed = ++window.Count <= 120;
    }
    if (!allowed)
    {
        context.Response.StatusCode = StatusCodes.Status429TooManyRequests;
        return;
    }
    await next();
});

// Keep the customer activation API public, but hide the management surface
// itself from sources outside the configured administrator allow-list.
app.Use(async (context, next) =>
{
    if (AdminAuth.IsManagementSurface(context.Request.Path) && !AdminAuth.IsSourceAllowed(context))
    {
        context.Response.StatusCode = StatusCodes.Status403Forbidden;
        await context.Response.WriteAsJsonAsync(new { error = "admin_ip_not_allowed" });
        return;
    }
    await next();
});

app.MapGet("/health", () => Results.Ok(new { status = "ok", service = "license" }));

app.MapGet("/private-install.sh", () =>
{
    var path = Path.Combine(AppContext.BaseDirectory, "private-install.sh");
    return File.Exists(path)
        ? Results.File(path, "text/x-shellscript; charset=utf-8")
        : Results.NotFound(new { error = "installer_unavailable" });
});

app.MapPost("/api/license/activate", async (ActivateRequest request, LicenseStore licenses, HttpContext context) =>
{
    var result = await licenses.ActivateAsync(request, RequestAddress(context));
    return Results.Json(result, statusCode: result.Valid ? StatusCodes.Status200OK : StatusCodes.Status403Forbidden);
});

app.MapGet("/api/admin/build-policy", async (LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    return Results.Ok(await licenses.GetBuildPolicyAsync());
});

app.MapPut("/api/admin/build-policy", async (BuildPolicyRequest request, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    if (request.MinBuildSequence < 0 || request.MinBuildSequence > 9999999999L)
        return Results.BadRequest(new { error = "minBuildSequence is out of range" });
    var ids = (request.AllowedBuildIds ?? Array.Empty<string>()).Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => x.Trim()).Distinct(StringComparer.Ordinal).ToArray();
    if (ids.Length > 256 || ids.Any(x => x.Length > 128)) return Results.BadRequest(new { error = "too many or oversized build ids" });
    var hashes = new Dictionary<string, string[]>(StringComparer.Ordinal);
    foreach (var item in request.AllowedBinaryHashes ?? new Dictionary<string, string[]>())
    {
        if (string.IsNullOrWhiteSpace(item.Key) || item.Key.Length > 128) return Results.BadRequest(new { error = "invalid build hash key" });
        var values = (item.Value ?? Array.Empty<string>()).Select(x => x?.Trim().ToUpperInvariant() ?? string.Empty).Distinct(StringComparer.Ordinal).ToArray();
        if (values.Length > 32 || values.Any(x => x.Length != 64 || x.Any(c => !Uri.IsHexDigit(c))))
            return Results.BadRequest(new { error = "binary hashes must be SHA-256 hex" });
        hashes[item.Key.Trim()] = values;
    }
    await licenses.UpdateBuildPolicyAsync(new BuildPolicy(request.MinBuildSequence, ids, request.RequireBinaryHash, hashes));
    return Results.Ok(await licenses.GetBuildPolicyAsync());
});

app.MapPost("/api/license/validate", async (ActivateRequest request, LicenseStore licenses, HttpContext context) =>
{
    var result = await licenses.ActivateAsync(request, RequestAddress(context));
    return Results.Json(result, statusCode: result.Valid ? StatusCodes.Status200OK : StatusCodes.Status403Forbidden);
});

app.MapPost("/api/license/tamper", async (TamperReportRequest request, LicenseStore licenses, HttpContext context) =>
{
    var result = await licenses.ReportTamperAsync(request, RequestAddress(context));
    return result switch
    {
        TamperReportResult.Revoked => Results.Ok(new { revoked = true }),
        TamperReportResult.Invalid => Results.StatusCode(StatusCodes.Status403Forbidden),
        _ => Results.StatusCode(StatusCodes.Status429TooManyRequests)
    };
});

app.MapPost("/api/license/status", async (StatusReportRequest request, LicenseStore licenses, HttpContext context) =>
{
    var result = await licenses.UpdateRuntimeStatusAsync(request, RequestAddress(context));
    return result switch
    {
        RuntimeStatusResult.Updated => Results.Ok(new { updated = true }),
        RuntimeStatusResult.Invalid => Results.StatusCode(StatusCodes.Status403Forbidden),
        _ => Results.StatusCode(StatusCodes.Status429TooManyRequests)
    };
});

app.MapPost("/api/admin/licenses", async (GenerateRequest request, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    if (request.Count is < 1 or > 1000) return Results.BadRequest(new { error = "count must be between 1 and 1000" });
    if (request.Days is < 0) return Results.BadRequest(new { error = "days must be zero or greater" });
    var allowedIps = Array.Empty<string>();
    if (request.AllowedIps is not null)
    {
        if (!TryNormalizeIps(request.AllowedIps, out allowedIps, out var normalizeError)) return Results.BadRequest(new { error = normalizeError });
    }
    var cards = await licenses.GenerateAsync(request.Count, request.Days, request.MaxActivations, request.BindIp, allowedIps);
    return Results.Ok(new { cards });
});

app.MapGet("/api/admin/licenses", async (LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    return Results.Ok(await licenses.ListAsync());
});

app.MapGet("/api/admin/licenses/{id}/details", async (string id, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    var details = await licenses.GetDetailsAsync(id);
    return details is null ? Results.NotFound() : Results.Ok(details);
});

app.MapGet("/api/admin/anomalies", async (int? limit, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    var take = Math.Clamp(limit ?? 500, 1, 1000);
    return Results.Ok(await licenses.ListAnomaliesAsync(take));
});

app.MapPost("/api/admin/licenses/{id}/revoke", async (string id, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    return await licenses.SetStatusAsync(id, "revoked") ? Results.Ok() : Results.NotFound();
});

// Tombstone deletion prevents new activations without exposing a destructive
// remote file or database control surface.
app.MapDelete("/api/admin/licenses/{id}", async (string id, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    return await licenses.DeleteAsync(id) ? Results.Ok(new { deleted = true }) : Results.NotFound();
});

app.MapPost("/api/admin/licenses/{id}/reset", async (string id, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    return await licenses.ResetActivationsAsync(id) ? Results.Ok() : Results.NotFound();
});

app.MapPost("/api/admin/licenses/{id}/unbind", async (string id, UnbindRequest request, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    return await licenses.UnbindAsync(id, request.ClearAllowedIps) ? Results.Ok() : Results.NotFound();
});

app.MapPost("/api/admin/licenses/{id}/ips", async (string id, IpBindingRequest request, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    if (request.Ips is null) return Results.BadRequest(new { error = "ips are required" });
    if (!TryNormalizeIps(request.Ips, out var ips, out var normalizeError)) return Results.BadRequest(new { error = normalizeError });
    return await licenses.SetAllowedIpsAsync(id, ips, request.BindIp, request.ClearBindings) ? Results.Ok() : Results.NotFound();
});

app.MapPost("/api/admin/licenses/{id}/ips/remove", async (string id, RemoveIpRequest request, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    if (!TryNormalizeIp(request.Ip, out var ip)) return Results.BadRequest(new { error = "invalid ip" });
    return await licenses.RemoveIpAsync(id, ip) ? Results.Ok() : Results.NotFound();
});

app.MapPost("/api/admin/licenses/{id}/settings", async (string id, LicenseSettingsRequest request, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    if (request.MaxActivations is < 1 or > 100) return Results.BadRequest(new { error = "maxActivations must be between 1 and 100" });
    if (request.Days is < 0) return Results.BadRequest(new { error = "days must be zero or greater" });
    return await licenses.UpdateSettingsAsync(id, request) ? Results.Ok() : Results.NotFound();
});

app.MapPost("/api/admin/licenses/{id}/extend", async (string id, ExtendLicenseRequest request, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    if (request.Days is < 1 or > 36500) return Results.BadRequest(new { error = "days must be between 1 and 36500" });
    var result = await licenses.ExtendAsync(id, request.Days);
    return result.Status switch
    {
        ExtendStatus.Extended => Results.Ok(new { expiresAt = result.ExpiresAt }),
        ExtendStatus.NotFound => Results.NotFound(),
        ExtendStatus.Permanent => Results.BadRequest(new { error = "permanent_license_does_not_need_extension" }),
        _ => Results.BadRequest(new { error = "license_cannot_be_extended" })
    };
});

app.MapPost("/api/admin/licenses/{id}/private/enable", async (string id, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    var result = await licenses.EnablePrivateAsync(id);
    return result is null ? Results.NotFound() : Results.Ok(result);
});

app.MapPost("/api/admin/licenses/{id}/private/disable", async (string id, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    return await licenses.DisablePrivateAsync(id) ? Results.Ok(new { disabled = true }) : Results.NotFound();
});

// Explicit migration operation: retire the current private-node identity and
// issue a fresh, short-lived bootstrap code. This does not touch plugin IP
// bindings; the old node must be stopped by the operator before migration.
app.MapPost("/api/admin/licenses/{id}/private/reset", async (string id, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    var result = await licenses.ResetPrivateNodeAsync(id);
    return result is null ? Results.NotFound() : Results.Ok(result);
});

app.MapPost("/api/private/register", async (PrivateRegisterRequest request, LicenseStore licenses, HttpContext context) =>
{
    var result = await licenses.RegisterPrivateNodeAsync(request, RequestAddress(context));
    if (result.Delegation is not null) return Results.Ok(result.Delegation);
    return Results.Json(new { error = result.Error }, statusCode: result.Error == "private_node_already_bound"
        ? StatusCodes.Status409Conflict : StatusCodes.Status403Forbidden);
});

app.MapPost("/api/private/renew", async (PrivateRenewRequest request, LicenseStore licenses, HttpContext context) =>
{
    var result = await licenses.RenewPrivateNodeAsync(request, RequestAddress(context));
    return result is null ? Results.StatusCode(StatusCodes.Status403Forbidden) : Results.Ok(result);
});
app.MapPost("/api/private/recover", async (PrivateRecoverRequest request, LicenseStore licenses, HttpContext context) =>
{
    var result = await licenses.RecoverPrivateNodeAsync(request, RequestAddress(context));
    return result is null ? Results.StatusCode(StatusCodes.Status403Forbidden) : Results.Ok(result);
});

// The installer gets the current private-node release through a short-lived,
// card-bound bootstrap code. The endpoint never returns signing private keys,
// admin credentials, or the build-policy document.
app.MapPost("/api/private/bootstrap/manifest", async (PrivateBootstrapRequest request, LicenseStore licenses) =>
{
    var result = await licenses.GetPrivateBootstrapManifestAsync(request);
    if (result.Manifest is not null) return Results.Ok(result.Manifest);
    return result.Error == "private_node_already_bound"
        ? Results.Json(new { error = result.Error }, statusCode: StatusCodes.Status409Conflict)
        : Results.Json(new { error = result.Error ?? "private_bootstrap_invalid" }, statusCode: StatusCodes.Status403Forbidden);
});

app.MapPost("/api/private/bootstrap/download", async (PrivateBootstrapRequest request, LicenseStore licenses) =>
{
    var result = await licenses.OpenPrivateBootstrapBinaryAsync(request);
    if (result is null) return Results.StatusCode(StatusCodes.Status403Forbidden);
    return Results.File(result.Stream, "application/octet-stream", enableRangeProcessing: false,
        lastModified: result.LastModifiedUtc, entityTag: new Microsoft.Net.Http.Headers.EntityTagHeaderValue($"\"{result.Sha256}\""));
});

app.MapPost("/api/admin/licenses/{id}/restore", async (string id, LicenseStore licenses, HttpRequest http) =>
{
    if (!AdminAuth.IsValid(http)) return Results.Unauthorized();
    return await licenses.SetStatusAsync(id, "active") ? Results.Ok() : Results.NotFound();
});

app.UseDefaultFiles();
app.UseStaticFiles();
app.Run();

static string RequestAddress(HttpContext context)
{
    var address = context.Connection.RemoteIpAddress;
    return address is null ? string.Empty : NormalizeIp(address.ToString());
}

static bool TryNormalizeIp(string raw, out string normalized)
{
    normalized = string.Empty;
    if (!System.Net.IPAddress.TryParse(raw?.Trim(), out var address)) return false;
    normalized = NormalizeIp(address.ToString());
    return normalized.Length > 0;
}

static string NormalizeIp(string value)
{
    if (System.Net.IPAddress.TryParse(value, out var address) && address.IsIPv4MappedToIPv6)
        return address.MapToIPv4().ToString();
    return value.Trim();
}

static bool TryNormalizeIps(IEnumerable<string> rawIps, out string[] ips, out string error)
{
    var values = rawIps.Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => x.Trim()).Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
    if (values.Length > 64) { ips = Array.Empty<string>(); error = "at most 64 IPs are allowed"; return false; }
    var normalized = new List<string>(values.Length);
    foreach (var value in values)
    {
        if (!TryNormalizeIp(value, out var ip)) { ips = Array.Empty<string>(); error = $"invalid ip: {value}"; return false; }
        normalized.Add(ip);
    }
    ips = normalized.Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
    error = string.Empty;
    return true;
}

record ActivateRequest(string License, string InstallId, string Challenge, string Product = "shunfeng-plugin",
    string BuildId = "", long BuildSequence = 0, string CustomerId = "", string BuildSignature = "", string BinaryHash = "");
record BuildPolicyRequest(long MinBuildSequence = 0, string[]? AllowedBuildIds = null, bool RequireBinaryHash = false,
    Dictionary<string, string[]>? AllowedBinaryHashes = null);
record GenerateRequest(int Count = 1, int Days = 30, int MaxActivations = 1, bool BindIp = true, string[]? AllowedIps = null);
record UnbindRequest(bool ClearAllowedIps = true);
record IpBindingRequest(string[]? Ips, bool BindIp = true, bool ClearBindings = true);
record RemoveIpRequest(string Ip);
record LicenseSettingsRequest(int? Days = null, int? MaxActivations = null, bool? BindIp = null);
record ExtendLicenseRequest(int Days = 30);
record PrivateRegisterRequest(string LicenseId, string BootstrapCode, string License, string NodeId, string NodePublicKeyPem);
sealed record PrivateRegistrationResult(object? Delegation, string? Error);
sealed record PrivateBootstrapManifestResult(object? Manifest, string? Error);
record PrivateRenewRequest(string LicenseId, string NodeId, string Challenge, string Signature, long Generation = 0);
record PrivateRecoverRequest(string LicenseId, string NodeId, string NodePublicKeyPem, string Challenge, string Signature, string PreviousDelegationJson);
record PrivateBootstrapRequest(string LicenseId, string BootstrapCode, string Version = "");
record StatusReportRequest(string License, string InstallId, string Product, string LicenseId,
    string Challenge, string BuildId, long BuildSequence, string CustomerId, string BuildSignature,
    string BinaryHash, string Signature, long IssuedAtUnix, long LeaseExpiresAtUnix,
    string OsDescription = "", string HostName = "", int CpuCount = 0, double CpuLoadPercent = 0,
    long TotalMemoryBytes = 0, long ProcessWorkingSetBytes = 0, long GcHeapBytes = 0,
    long UptimeSeconds = 0, bool ConfigExists = false, long ConfigSizeBytes = 0,
    string ConfigSha256 = "", string ConfigLastWriteUtc = "", string? ConfigContent = null);

static class AdminAuth
{
    public static bool IsManagementSurface(PathString path) =>
        path == "/" || path == "/index.html" || path.StartsWithSegments("/api/admin");

    public static bool IsSourceAllowed(HttpContext context)
    {
        var allowList = Environment.GetEnvironmentVariable("LICENSE_ADMIN_IPS");
        if (string.IsNullOrWhiteSpace(allowList)) return true;
        if (!TryNormalizeIp(context.Connection.RemoteIpAddress?.ToString() ?? string.Empty, out var remote)) return false;
        foreach (var raw in allowList.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
        {
            var rule = raw.Trim();
            // A trailing dot or '*' is an explicit IPv4 prefix rule, e.g. 182.113.*.
            if (rule.EndsWith(".*", StringComparison.Ordinal)) rule = rule[..^1];
            if (rule.EndsWith(".", StringComparison.Ordinal) && remote.StartsWith(rule, StringComparison.Ordinal)) return true;
            if (TryNormalizeIp(rule, out var allowed) && string.Equals(remote, allowed, StringComparison.OrdinalIgnoreCase)) return true;
        }
        return false;
    }

    private static bool TryNormalizeIp(string raw, out string normalized)
    {
        normalized = string.Empty;
        if (!System.Net.IPAddress.TryParse(raw?.Trim(), out var address)) return false;
        normalized = address.IsIPv4MappedToIPv6 ? address.MapToIPv4().ToString() : address.ToString();
        return normalized.Length > 0;
    }

    public static bool IsValid(HttpRequest request)
    {
        var expected = Environment.GetEnvironmentVariable("LICENSE_ADMIN_TOKEN");
        if (string.IsNullOrWhiteSpace(expected) || !request.Headers.TryGetValue("X-Admin-Token", out var token)
            || !CryptographicOperations.FixedTimeEquals(Encoding.UTF8.GetBytes(expected), Encoding.UTF8.GetBytes(token.ToString()))) return false;
        return IsSourceAllowed(request.HttpContext);
    }
}

static class BuildTrust
{
    private const string ReleasePublicKeyPem = """
-----BEGIN PUBLIC KEY-----
MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAElhoxom4B20JEQT9OwvoTjIjndvHt
v2BpR8JpS0cCVudLdkNXkWZjnZM/awbzAyFog3W8zthUQcCb32k6XNOaNA==
-----END PUBLIC KEY-----
""";

    public static string? Validate(string buildId, long buildSequence, string customerId, string signature, string binaryHash, BuildPolicy policy)
    {
        if (buildSequence < policy.MinBuildSequence) return "build_too_old";
        if (policy.AllowedBuildIds.Length > 0 && !policy.AllowedBuildIds.Contains(buildId, StringComparer.Ordinal))
            return "build_not_allowed";
        if (binaryHash.Length != 64 || binaryHash.Any(c => !Uri.IsHexDigit(c))) return "binary_hash_invalid";
        if (policy.RequireBinaryHash)
        {
            if (!policy.AllowedBinaryHashes.TryGetValue(buildId, out var allowed)
                || !allowed.Contains(binaryHash, StringComparer.OrdinalIgnoreCase)) return "binary_hash_not_allowed";
        }
        try
        {
            var canonical = Encoding.UTF8.GetBytes(string.Join("|", buildId.Trim(), buildSequence.ToString(CultureInfo.InvariantCulture), customerId.Trim()));
            using var verifier = ECDsa.Create();
            verifier.ImportFromPem(ReleasePublicKeyPem);
            return verifier.VerifyData(canonical, Convert.FromBase64String(signature), HashAlgorithmName.SHA256)
                ? null
                : "build_signature_invalid";
        }
        catch (Exception ex) when (ex is CryptographicException or FormatException)
        {
            return "build_signature_invalid";
        }
    }
}

static class SigningKeyLoader
{
    public static string? Load()
    {
        var inline = Environment.GetEnvironmentVariable("LICENSE_SIGNING_PRIVATE_KEY_PEM");
        if (!string.IsNullOrWhiteSpace(inline)) return inline;
        var path = Environment.GetEnvironmentVariable("LICENSE_SIGNING_PRIVATE_KEY_PEM_FILE");
        if (string.IsNullOrWhiteSpace(path)) return null;
        try
        {
            return File.ReadAllText(path);
        }
        catch (IOException) { return null; }
        catch (UnauthorizedAccessException) { return null; }
    }
}

sealed class LicenseStore
{
    private readonly string _path;
    private readonly string _policyPath;
    private readonly string _anomalyPath;
    private readonly string _privatePath;
    private readonly string _privateBinaryPath;
    private readonly string _privateBinaryVersion;
    private readonly PrivateBinaryInfo? _privateBinaryInfo;
    private readonly CardProtector _cardProtector;
    private readonly SemaphoreSlim _gate = new(1, 1);
    private readonly JsonSerializerOptions _json = new(JsonSerializerDefaults.Web) { WriteIndented = true };
    private List<LicenseRecord>? _records;

    public LicenseStore(IHostEnvironment environment)
    {
        var dataDirectory = Environment.GetEnvironmentVariable("LICENSE_DATA_DIR");
        dataDirectory = string.IsNullOrWhiteSpace(dataDirectory) ? Path.Combine(environment.ContentRootPath, "data") : dataDirectory;
        Directory.CreateDirectory(dataDirectory);
        _path = Path.Combine(dataDirectory, "licenses.json");
        _policyPath = Path.Combine(dataDirectory, "build-policy.json");
        _anomalyPath = Path.Combine(dataDirectory, "anomaly-events.json");
        _privatePath = Path.Combine(dataDirectory, "private-enrollments.json");
        _privateBinaryPath = Environment.GetEnvironmentVariable("LICENSE_PRIVATE_BINARY_PATH") ?? string.Empty;
        _privateBinaryVersion = Environment.GetEnvironmentVariable("LICENSE_PRIVATE_BINARY_VERSION")?.Trim() ?? string.Empty;
        _privateBinaryInfo = LoadPrivateBinaryInfo();
        _cardProtector = new CardProtector();
    }

    public async Task<PrivateBootstrapManifestResult> GetPrivateBootstrapManifestAsync(PrivateBootstrapRequest request)
    {
        var info = _privateBinaryInfo;
        if (info is null || !VersionMatches(request.Version, info.Version)) return new(null, "private_bootstrap_invalid");
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var enrollments = await LoadPrivateAsync();
            var record = records.FirstOrDefault(x => x.Id == request.LicenseId && x.Status == "active" && x.PrivateEnabled);
            if (record is not null && !string.IsNullOrWhiteSpace(record.PrivateNodeId))
                return new(null, "private_node_already_bound");
            var enrollment = FindPrivateEnrollment(records, enrollments, request);
            if (enrollment is null) return new(null, "private_bootstrap_invalid");
            var payload = PrivateBootstrapCanonical(request.LicenseId.Trim(), info.Version, info.Sha256, enrollment.ExpiresAt.ToUnixTimeSeconds());
            var signature = SignPrivateBootstrap(payload);
            if (signature is null) return new(null, "private_bootstrap_invalid");
            return new(new
            {
                licenseId = request.LicenseId.Trim(), version = info.Version, sha256 = info.Sha256,
                expiresAtUnix = enrollment.ExpiresAt.ToUnixTimeSeconds(), signaturePayload = payload, signature,
                downloadPath = "/api/private/bootstrap/download"
            }, null);
        }
        finally { _gate.Release(); }
    }

    public async Task<PrivateBinaryDownload?> OpenPrivateBootstrapBinaryAsync(PrivateBootstrapRequest request)
    {
        var info = _privateBinaryInfo;
        if (info is null || !VersionMatches(request.Version, info.Version)) return null;
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var enrollments = await LoadPrivateAsync();
            if (FindPrivateEnrollment(records, enrollments, request) is null) return null;
        }
        finally { _gate.Release(); }
        try
        {
            var stream = new FileStream(info.Path, FileMode.Open, FileAccess.Read, FileShare.Read,
                bufferSize: 64 * 1024, options: FileOptions.Asynchronous | FileOptions.SequentialScan);
            return new PrivateBinaryDownload(stream, info.Sha256, info.LastWriteUtc);
        }
        catch (IOException) { return null; }
        catch (UnauthorizedAccessException) { return null; }
    }

    private PrivateEnrollment? FindPrivateEnrollment(List<LicenseRecord> records, List<PrivateEnrollment> enrollments, PrivateBootstrapRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.LicenseId) || string.IsNullOrWhiteSpace(request.BootstrapCode)
            || request.LicenseId.Length > 128 || request.BootstrapCode.Length > 256) return null;
        var record = records.FirstOrDefault(x => x.Id == request.LicenseId && x.Status == "active" && x.PrivateEnabled);
        var enrollment = enrollments.FirstOrDefault(x => x.LicenseId == request.LicenseId && !x.Used
            && x.ExpiresAt > DateTimeOffset.UtcNow && x.CodeHash == Hash(request.BootstrapCode));
        return record is null ? null : enrollment;
    }

    private PrivateBinaryInfo? LoadPrivateBinaryInfo()
    {
        if (string.IsNullOrWhiteSpace(_privateBinaryPath) || string.IsNullOrWhiteSpace(_privateBinaryVersion)
            || _privateBinaryVersion.Length > 128 || !File.Exists(_privateBinaryPath)) return null;
        try
        {
            var file = new FileInfo(_privateBinaryPath);
            if (!file.Exists || file.Length <= 0 || file.Length > 512L * 1024 * 1024) return null;
            using var stream = file.OpenRead();
            using var sha256 = SHA256.Create();
            var hash = Convert.ToHexString(sha256.ComputeHash(stream));
            return new PrivateBinaryInfo(file.FullName, _privateBinaryVersion, hash, file.LastWriteTimeUtc);
        }
        catch (IOException) { return null; }
        catch (UnauthorizedAccessException) { return null; }
    }

    private static bool VersionMatches(string requested, string configured) =>
        string.IsNullOrWhiteSpace(requested) || string.Equals(requested.Trim(), configured, StringComparison.Ordinal);

    private static string PrivateBootstrapCanonical(string licenseId, string version, string sha256, long expiresAtUnix) =>
        string.Join("|", "private-binary-v1", licenseId, version, sha256, expiresAtUnix.ToString(CultureInfo.InvariantCulture));

    private static string? SignPrivateBootstrap(string payload)
    {
        var signingKey = SigningKeyLoader.Load();
        if (string.IsNullOrWhiteSpace(signingKey)) return null;
        try
        {
            using var signer = ECDsa.Create();
            signer.ImportFromPem(signingKey);
            return Convert.ToBase64String(signer.SignData(Encoding.UTF8.GetBytes(payload), HashAlgorithmName.SHA256));
        }
        catch (CryptographicException) { return null; }
    }

    public async Task<object?> EnablePrivateAsync(string id)
    {
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var record = records.FirstOrDefault(x => x.Id == id && !string.Equals(x.Status, "deleted", StringComparison.OrdinalIgnoreCase));
            if (record is null) return null;
            var enrollments = await LoadPrivateAsync();
            enrollments.RemoveAll(x => x.LicenseId == id && !x.Used);
            record.PrivateEnabled = true;
            record.PrivateGeneration++;
            string? code = null;
            DateTimeOffset? codeExpiresAt = null;
            if (string.IsNullOrWhiteSpace(record.PrivateNodeId) || string.IsNullOrWhiteSpace(record.PrivateNodePublicKeyPem))
            {
                code = "PV-" + Convert.ToHexString(RandomNumberGenerator.GetBytes(18));
                codeExpiresAt = DateTimeOffset.UtcNow.AddMinutes(10);
                enrollments.Add(new PrivateEnrollment { LicenseId = id, CodeHash = Hash(code), ExpiresAt = codeExpiresAt.Value });
            }
            await SaveAsync(records);
            await SavePrivateAsync(enrollments);
            return new { licenseId = id, bootstrapCode = code, expiresAt = codeExpiresAt, resumed = code is null };
        }
        finally { _gate.Release(); }
    }

    public async Task<bool> DisablePrivateAsync(string id)
    {
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var record = records.FirstOrDefault(x => x.Id == id && !string.Equals(x.Status, "deleted", StringComparison.OrdinalIgnoreCase));
            if (record is null) return false;
            record.PrivateEnabled = false;
            record.PrivateGeneration++;
            await SaveAsync(records);
            var enrollments = await LoadPrivateAsync();
            enrollments.RemoveAll(x => x.LicenseId == id);
            await SavePrivateAsync(enrollments);
            return true;
        }
        finally { _gate.Release(); }
    }

    public async Task<object?> ResetPrivateNodeAsync(string id)
    {
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var record = records.FirstOrDefault(x => x.Id == id
                && x.Status == "active" && x.PrivateEnabled);
            if (record is null) return null;

            // Retire the old node identity. Plugin-side BoundIps/AllowedIps
            // belong to the private node and are intentionally untouched here.
            record.PrivateRetiredGeneration = Math.Max(record.PrivateRetiredGeneration, record.PrivateGeneration);
            record.PrivateNodeId = null;
            record.PrivateNodePublicKeyPem = null;
            record.PrivateNodeIp = null;
            record.PrivateLastSeenAt = null;
            record.PrivateLastRemoteIp = null;
            record.PrivateGeneration++;

            var enrollments = await LoadPrivateAsync();
            enrollments.RemoveAll(x => x.LicenseId == id);
            var code = "PV-" + Convert.ToHexString(RandomNumberGenerator.GetBytes(18));
            var expiresAt = DateTimeOffset.UtcNow.AddMinutes(10);
            enrollments.Add(new PrivateEnrollment
            {
                LicenseId = id,
                CodeHash = Hash(code),
                ExpiresAt = expiresAt
            });
            await SaveAsync(records);
            await SavePrivateAsync(enrollments);
            await AppendAnomalyAsync(new AnomalyEvent
            {
                EventType = "private-node-reset",
                LicenseId = record.Id,
                LicenseHash = record.LicenseHash,
                CardCiphertext = record.CardCiphertext,
                OccurredAt = DateTimeOffset.UtcNow,
                Reason = "管理员解绑旧私有节点并生成新的部署命令"
            });
            return new { licenseId = id, bootstrapCode = code, expiresAt, previousNodeRetired = true };
        }
        finally { _gate.Release(); }
    }

    public async Task<PrivateRegistrationResult> RegisterPrivateNodeAsync(PrivateRegisterRequest request, string remoteIp)
    {
        if (string.IsNullOrWhiteSpace(request.LicenseId) || string.IsNullOrWhiteSpace(request.BootstrapCode)
            || string.IsNullOrWhiteSpace(request.License) || string.IsNullOrWhiteSpace(request.NodeId) || string.IsNullOrWhiteSpace(request.NodePublicKeyPem)
            || request.License.Length > 256 || request.NodeId.Length > 128 || request.NodePublicKeyPem.Length > 4096)
            return new(null, "private_registration_invalid");
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var record = records.FirstOrDefault(x => x.Id == request.LicenseId && x.Status == "active" && x.PrivateEnabled);
            var enrollments = await LoadPrivateAsync();
            var enrollment = enrollments.FirstOrDefault(x => x.LicenseId == request.LicenseId && !x.Used && x.ExpiresAt > DateTimeOffset.UtcNow && x.CodeHash == Hash(request.BootstrapCode));
            if (record is null || !CryptographicOperations.FixedTimeEquals(Convert.FromHexString(record.LicenseHash), Convert.FromHexString(Hash(request.License))))
                return new(null, "private_card_invalid");
            if (!string.IsNullOrWhiteSpace(record.PrivateNodeId))
                return new(null, "private_node_already_bound");
            if (enrollment is null) return new(null, "private_deployment_code_invalid_or_used");
            if (!TryValidatePublicKey(request.NodePublicKeyPem)) return new(null, "private_node_key_invalid");
            record.PrivateNodeId = request.NodeId.Trim();
            record.PrivateNodePublicKeyPem = request.NodePublicKeyPem.Trim();
            record.PrivateNodeIp = remoteIp;
            record.PrivateLastSeenAt = DateTimeOffset.UtcNow;
            record.PrivateLastRemoteIp = remoteIp;
            enrollment.Used = true;
            await SaveAsync(records);
            await SavePrivateAsync(enrollments);
            return new(await CreateDelegationAsync(record), null);
        }
        finally { _gate.Release(); }
    }

    public async Task<object?> RenewPrivateNodeAsync(PrivateRenewRequest request, string remoteIp)
    {
        if (string.IsNullOrWhiteSpace(request.LicenseId) || string.IsNullOrWhiteSpace(request.NodeId)
            || string.IsNullOrWhiteSpace(request.Challenge) || string.IsNullOrWhiteSpace(request.Signature)
            || request.Challenge.Length > 128 || request.Signature.Length > 1024) return null;
        await _gate.WaitAsync();
        try
        {
            var record = (await LoadAsync()).FirstOrDefault(x => x.Id == request.LicenseId && x.Status == "active" && x.PrivateEnabled
                && x.PrivateNodeId == request.NodeId && !string.IsNullOrWhiteSpace(x.PrivateNodePublicKeyPem));
            if (record is null || !VerifyNodeSignature(record, request)) return null;
            record.PrivateLastSeenAt = DateTimeOffset.UtcNow;
            record.PrivateLastRemoteIp = remoteIp;
            await SaveAsync(await LoadAsync());
            return await CreateDelegationAsync(record);
        }
        finally { _gate.Release(); }
    }

    public async Task<object?> RecoverPrivateNodeAsync(PrivateRecoverRequest request, string remoteIp)
    {
        if (string.IsNullOrWhiteSpace(request.LicenseId) || string.IsNullOrWhiteSpace(request.NodeId)
            || string.IsNullOrWhiteSpace(request.NodePublicKeyPem) || string.IsNullOrWhiteSpace(request.Challenge)
            || string.IsNullOrWhiteSpace(request.Signature) || string.IsNullOrWhiteSpace(request.PreviousDelegationJson)
            || request.NodeId.Length > 128 || request.NodePublicKeyPem.Length > 4096 || request.Challenge.Length > 128
            || request.Signature.Length > 1024 || request.PreviousDelegationJson.Length > 32768) return null;
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var record = records.FirstOrDefault(x => x.Id == request.LicenseId && x.Status == "active" && x.PrivateEnabled);
            if (record is null || !TryValidatePublicKey(request.NodePublicKeyPem)
                || !VerifyPrivateRecovery(record, request)) return null;
            if (!string.IsNullOrWhiteSpace(record.PrivateNodeId)
                && (!string.Equals(record.PrivateNodeId, request.NodeId, StringComparison.Ordinal)
                    || !string.Equals(PublicKeyHash(record.PrivateNodePublicKeyPem), PublicKeyHash(request.NodePublicKeyPem), StringComparison.OrdinalIgnoreCase)))
                return null;
            record.PrivateNodeId = request.NodeId.Trim();
            record.PrivateNodePublicKeyPem = request.NodePublicKeyPem.Trim();
            record.PrivateLastSeenAt = DateTimeOffset.UtcNow;
            record.PrivateLastRemoteIp = remoteIp;
            await SaveAsync(records);
            return await CreateDelegationAsync(record);
        }
        finally { _gate.Release(); }
    }

    private static bool TryValidatePublicKey(string pem)
    {
        try { using var key = ECDsa.Create(); key.ImportFromPem(pem); return true; }
        catch { return false; }
    }

    private static bool VerifyNodeSignature(LicenseRecord record, PrivateRenewRequest request)
    {
        try
        {
            using var key = ECDsa.Create();
            key.ImportFromPem(record.PrivateNodePublicKeyPem!);
            var generations = request.Generation > 0
                ? new[] { request.Generation }
                : new[] { record.PrivateGeneration, record.PrivateGeneration - 1 };
            var signature = Convert.FromBase64String(request.Signature);
            return generations.Where(x => x > 0 && x <= record.PrivateGeneration).Any(generation =>
            {
                var canonical = string.Join("|", request.LicenseId, request.NodeId, request.Challenge, generation.ToString(CultureInfo.InvariantCulture));
                return key.VerifyData(Encoding.UTF8.GetBytes(canonical), signature, HashAlgorithmName.SHA256);
            });
        }
        catch { return false; }
    }

    private static bool VerifyPrivateRecovery(LicenseRecord record, PrivateRecoverRequest request)
    {
        try
        {
            using var document = JsonDocument.Parse(request.PreviousDelegationJson);
            var d = document.RootElement;
            if (!d.GetProperty("valid").GetBoolean()
                || d.GetProperty("licenseId").GetString() != request.LicenseId
                || d.GetProperty("nodeId").GetString() != request.NodeId
                || !string.Equals(d.GetProperty("licenseHash").GetString(), record.LicenseHash, StringComparison.OrdinalIgnoreCase)) return false;
            var generation = d.GetProperty("generation").GetInt64();
            if (generation <= record.PrivateRetiredGeneration || generation > record.PrivateGeneration) return false;
            using var nodeKey = ECDsa.Create();
            nodeKey.ImportFromPem(request.NodePublicKeyPem);
            var nodeHash = Convert.ToHexString(SHA256.HashData(nodeKey.ExportSubjectPublicKeyInfo()));
            if (!string.Equals(nodeHash, d.GetProperty("nodePublicKeySha256").GetString(), StringComparison.OrdinalIgnoreCase)) return false;
            var policy = d.GetProperty("buildPolicy");
            var policyHash = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(BuildPolicyCanonical(policy))));
            if (!string.Equals(policyHash, d.GetProperty("policySha256").GetString(), StringComparison.OrdinalIgnoreCase)) return false;
            var canonical = PrivateDelegationCanonical(request.LicenseId, request.NodeId, generation, nodeHash, record.LicenseHash,
                d.GetProperty("licenseExpiresAtUnix").GetInt64(), d.GetProperty("issuedAtUnix").GetInt64(),
                d.GetProperty("expiresAtUnix").GetInt64(), policyHash);
            var signingKey = SigningKeyLoader.Load();
            if (string.IsNullOrWhiteSpace(signingKey)) return false;
            using var rootKey = ECDsa.Create(); rootKey.ImportFromPem(signingKey);
            if (!rootKey.VerifyData(Encoding.UTF8.GetBytes(canonical), Convert.FromBase64String(d.GetProperty("signature").GetString() ?? string.Empty), HashAlgorithmName.SHA256)) return false;
            var proof = string.Join("|", "recover", request.LicenseId, request.NodeId, request.Challenge, generation.ToString(CultureInfo.InvariantCulture));
            return nodeKey.VerifyData(Encoding.UTF8.GetBytes(proof), Convert.FromBase64String(request.Signature), HashAlgorithmName.SHA256);
        }
        catch { return false; }
    }

    private async Task<object> CreateDelegationAsync(LicenseRecord record)
    {
        var now = DateTimeOffset.UtcNow;
        // A private node is autonomous after the one-time bootstrap. The root
        // delegation therefore lives for the card lifetime (or forever), while
        // each plugin activation still receives a short local lease.
        var expires = record.ExpiresAt ?? DateTimeOffset.MaxValue;
        if (expires <= now) return new { valid = false, error = "license_expired" };
        var signingKey = SigningKeyLoader.Load();
        if (string.IsNullOrWhiteSpace(signingKey)) return new { valid = false, error = "license_signing_unavailable" };
        var policy = await LoadBuildPolicyAsync();
        var nodeKeyHash = PublicKeyHash(record.PrivateNodePublicKeyPem);
        var licenseExpiresAtUnix = record.ExpiresAt?.ToUnixTimeSeconds() ?? 0L;
        var policyHash = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(BuildPolicyCanonical(policy))));
        var canonical = PrivateDelegationCanonical(record.Id, record.PrivateNodeId ?? string.Empty, record.PrivateGeneration, nodeKeyHash,
            record.LicenseHash, licenseExpiresAtUnix, now.ToUnixTimeSeconds(), expires.ToUnixTimeSeconds(), policyHash);
        using var signer = ECDsa.Create();
        signer.ImportFromPem(signingKey);
        var signature = Convert.ToBase64String(signer.SignData(Encoding.UTF8.GetBytes(canonical), HashAlgorithmName.SHA256));
        return new { valid = true, licenseId = record.Id, nodeId = record.PrivateNodeId, generation = record.PrivateGeneration,
            nodePublicKeySha256 = nodeKeyHash, licenseHash = record.LicenseHash, licenseExpiresAtUnix,
            issuedAtUnix = now.ToUnixTimeSeconds(), expiresAtUnix = expires.ToUnixTimeSeconds(), buildPolicy = policy, policySha256 = policyHash, signature };
    }

    private static string PrivateDelegationCanonical(string licenseId, string nodeId, long generation, string nodeKeyHash,
        string licenseHash, long licenseExpiresAtUnix, long issuedAtUnix, long expiresAtUnix, string policyHash) =>
        string.Join("|", licenseId, nodeId, generation.ToString(CultureInfo.InvariantCulture), nodeKeyHash, licenseHash,
            licenseExpiresAtUnix.ToString(CultureInfo.InvariantCulture), issuedAtUnix.ToString(CultureInfo.InvariantCulture),
            expiresAtUnix.ToString(CultureInfo.InvariantCulture), policyHash);

    private static string BuildPolicyCanonical(BuildPolicy policy)
    {
        var ids = string.Join(",", policy.AllowedBuildIds.OrderBy(x => x, StringComparer.Ordinal));
        var hashes = string.Join(";", policy.AllowedBinaryHashes.OrderBy(x => x.Key, StringComparer.Ordinal)
            .Select(x => x.Key + "=" + string.Join(",", x.Value.OrderBy(y => y, StringComparer.OrdinalIgnoreCase))));
        return string.Join("|", policy.MinBuildSequence.ToString(CultureInfo.InvariantCulture), policy.RequireBinaryHash ? "1" : "0", ids, hashes);
    }

    private static string BuildPolicyCanonical(JsonElement policy)
    {
        var ids = string.Join(",", policy.GetProperty("allowedBuildIds").EnumerateArray()
            .Select(x => x.GetString() ?? string.Empty).OrderBy(x => x, StringComparer.Ordinal));
        var hashes = string.Join(";", policy.GetProperty("allowedBinaryHashes").EnumerateObject()
            .OrderBy(x => x.Name, StringComparer.Ordinal)
            .Select(x => x.Name + "=" + string.Join(",", x.Value.EnumerateArray()
                .Select(y => y.GetString() ?? string.Empty).OrderBy(y => y, StringComparer.OrdinalIgnoreCase))));
        return string.Join("|", policy.GetProperty("minBuildSequence").GetInt64().ToString(CultureInfo.InvariantCulture),
            policy.GetProperty("requireBinaryHash").GetBoolean() ? "1" : "0", ids, hashes);
    }

    private static string PublicKeyHash(string? pem)
    {
        using var key = ECDsa.Create();
        key.ImportFromPem(pem ?? string.Empty);
        return Convert.ToHexString(SHA256.HashData(key.ExportSubjectPublicKeyInfo()));
    }

    public async Task<LicenseDecision> ActivateAsync(ActivateRequest request, string remoteIp)
    {
        var rawLicense = request.License;
        var installId = request.InstallId;
        var challenge = request.Challenge;
        var product = request.Product;
        if (string.IsNullOrWhiteSpace(rawLicense) || string.IsNullOrWhiteSpace(installId) || string.IsNullOrWhiteSpace(challenge)
            || string.IsNullOrWhiteSpace(request.BuildId) || string.IsNullOrWhiteSpace(request.CustomerId)
            || string.IsNullOrWhiteSpace(request.BuildSignature) || challenge.Length > 128 || installId.Length > 256
            || product.Length > 128 || request.BuildId.Length > 128 || request.CustomerId.Length > 128
            || request.BuildSignature.Length > 256 || request.BinaryHash.Length > 64 || remoteIp.Length > 64)
            return LicenseDecision.Invalid("license, installId and challenge are required", product);

        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var record = records.FirstOrDefault(x => x.LicenseHash == Hash(rawLicense));
            if (record is null || record.Status != "active") return LicenseDecision.Invalid("license_invalid", product);
            if (record.PrivateEnabled) return LicenseDecision.Invalid("private_node_required", product);
            var policy = await LoadBuildPolicyAsync();
            var buildError = BuildTrust.Validate(request.BuildId, request.BuildSequence, request.CustomerId,
                request.BuildSignature, request.BinaryHash, policy);
            if (buildError is not null) return LicenseDecision.Invalid(buildError, product);
            if (record.ExpiresAt is not null && record.ExpiresAt <= DateTimeOffset.UtcNow)
            {
                record.Status = "expired";
                await SaveAsync(records);
                await AppendAnomalyAsync(new AnomalyEvent
                {
                    EventType = "automatic-expiry",
                    LicenseId = record.Id,
                    LicenseHash = record.LicenseHash,
                    CardCiphertext = record.CardCiphertext,
                    OccurredAt = DateTimeOffset.UtcNow,
                    Reason = "卡密到期，激活请求被拒绝",
                    RemoteIp = remoteIp,
                    BuildId = request.BuildId,
                    CustomerId = request.CustomerId
                });
                return LicenseDecision.Invalid("license_expired", product);
            }
            if (record.BindIp && string.IsNullOrWhiteSpace(remoteIp)) return LicenseDecision.Invalid("remote_ip_unavailable", product);
            if (record.BindIp && record.AllowedIps.Count > 0 && !record.AllowedIps.Contains(remoteIp, StringComparer.OrdinalIgnoreCase))
                return LicenseDecision.Invalid("ip_not_allowed", product);
            if (record.BindIp && !record.BoundIps.Contains(remoteIp) && record.BoundIps.Count >= record.MaxActivations)
                return LicenseDecision.Invalid("ip_activation_limit", product);
            if (!record.InstallIds.Contains(installId) && record.InstallIds.Count >= record.MaxActivations)
                return LicenseDecision.Invalid("activation_limit", product);
            var signingKey = SigningKeyLoader.Load();
            if (string.IsNullOrWhiteSpace(signingKey)) return LicenseDecision.Invalid("license_signing_unavailable", product);

            // An empty allow-list means the first successful plugin server becomes the sole allowed source.
            if (record.BindIp && record.AllowedIps.Count == 0) record.AllowedIps.Add(remoteIp);
            record.InstallIds.Add(installId);
            if (!string.IsNullOrWhiteSpace(remoteIp)) record.BoundIps.Add(remoteIp);
            record.LastSeenAt = DateTimeOffset.UtcNow;
            record.LastBuildId = request.BuildId;
            record.LastBuildSequence = request.BuildSequence;
            record.LastCustomerId = request.CustomerId;
            record.LastBinaryHash = request.BinaryHash;
            await SaveAsync(records);
            var issuedAt = DateTimeOffset.UtcNow;
            var leaseExpiresAt = issuedAt.AddMinutes(15);
            var canonical = LicenseDecision.Canonical(record.Id, product, installId, challenge,
                request.BuildId, request.BuildSequence, request.CustomerId, request.BinaryHash, issuedAt, leaseExpiresAt);
            using var signer = ECDsa.Create();
            signer.ImportFromPem(signingKey);
            var signature = Convert.ToBase64String(signer.SignData(Encoding.UTF8.GetBytes(canonical), HashAlgorithmName.SHA256));
            return new LicenseDecision(true, null, record.Id, record.ExpiresAt, true, product,
                request.BuildId, request.BuildSequence, request.CustomerId, request.BinaryHash, signature,
                issuedAt.ToUnixTimeSeconds(), leaseExpiresAt.ToUnixTimeSeconds());
        }
        finally { _gate.Release(); }
    }

    public async Task<TamperReportResult> ReportTamperAsync(TamperReportRequest request, string remoteIp)
    {
        if (string.IsNullOrWhiteSpace(request.License) || string.IsNullOrWhiteSpace(request.InstallId)
            || string.IsNullOrWhiteSpace(request.LicenseId) || string.IsNullOrWhiteSpace(request.Challenge)
            || string.IsNullOrWhiteSpace(request.Signature) || string.IsNullOrWhiteSpace(request.Product)
            || string.IsNullOrWhiteSpace(request.BuildId) || string.IsNullOrWhiteSpace(request.CustomerId)
            || string.IsNullOrWhiteSpace(request.BuildSignature) || string.IsNullOrWhiteSpace(request.BinaryHash)
            || string.IsNullOrWhiteSpace(request.Reason) || request.Reason.Length > 256)
            return TamperReportResult.Invalid;

        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var record = records.FirstOrDefault(x => x.LicenseHash == Hash(request.License));
            if (record is null || record.Status != "active" || record.Id != request.LicenseId
                || !record.InstallIds.Contains(request.InstallId)) return TamperReportResult.Invalid;
            if (record.BindIp && (string.IsNullOrWhiteSpace(remoteIp)
                || (record.AllowedIps.Count > 0 && !record.AllowedIps.Contains(remoteIp, StringComparer.OrdinalIgnoreCase))))
                return TamperReportResult.Invalid;

            var buildPolicy = await LoadBuildPolicyAsync();
            if (BuildTrust.Validate(request.BuildId, request.BuildSequence, request.CustomerId,
                request.BuildSignature, request.BinaryHash, buildPolicy) is not null)
                return TamperReportResult.Invalid;

            var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            if (request.IssuedAtUnix > now + 120 || request.LeaseExpiresAtUnix < now - 60
                || request.LeaseExpiresAtUnix <= request.IssuedAtUnix
                || request.LeaseExpiresAtUnix - request.IssuedAtUnix > (long)TimeSpan.FromMinutes(20).TotalSeconds)
                return TamperReportResult.Invalid;
            var signingKey = SigningKeyLoader.Load();
            if (string.IsNullOrWhiteSpace(signingKey)) return TamperReportResult.Unavailable;
            var canonical = LicenseDecision.Canonical(request.LicenseId, request.Product, request.InstallId,
                request.Challenge, request.BuildId, request.BuildSequence, request.CustomerId, request.BinaryHash,
                DateTimeOffset.FromUnixTimeSeconds(request.IssuedAtUnix),
                DateTimeOffset.FromUnixTimeSeconds(request.LeaseExpiresAtUnix));
            using var verifier = ECDsa.Create();
            verifier.ImportFromPem(signingKey);
            if (!Convert.TryFromBase64String(request.Signature, new byte[256], out var signatureLength)) return TamperReportResult.Invalid;
            var signature = Convert.FromBase64String(request.Signature);
            if (!verifier.VerifyData(Encoding.UTF8.GetBytes(canonical), signature[..signatureLength], HashAlgorithmName.SHA256))
                return TamperReportResult.Invalid;

            record.Status = "revoked";
            record.LastTamperAt = DateTimeOffset.UtcNow;
            record.LastTamperReason = request.Reason.Trim();
            await SaveAsync(records);
            await AppendAnomalyAsync(new AnomalyEvent
            {
                EventType = "automatic-tamper-revoke",
                LicenseId = record.Id,
                LicenseHash = record.LicenseHash,
                CardCiphertext = record.CardCiphertext,
                OccurredAt = record.LastTamperAt.Value,
                Reason = request.Reason.Trim(),
                RemoteIp = remoteIp,
                InstallId = request.InstallId,
                BuildId = request.BuildId,
                BuildSequence = request.BuildSequence,
                CustomerId = request.CustomerId,
                BinaryHash = request.BinaryHash
            });
            return TamperReportResult.Revoked;
        }
        finally { _gate.Release(); }
    }

    public async Task<IReadOnlyList<object>> GenerateAsync(int count, int days, int maxActivations, bool bindIp, IReadOnlyCollection<string> allowedIps)
    {
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var result = new List<object>(count);
            for (var i = 0; i < count; i++)
            {
                string card;
                do { card = CreateCard(); } while (records.Any(x => x.LicenseHash == Hash(card)));
                var record = new LicenseRecord
                {
                    Id = Guid.NewGuid().ToString("N"),
                    LicenseHash = Hash(card),
                    Status = "active",
                    ExpiresAt = days == 0 ? null : DateTimeOffset.UtcNow.AddDays(days),
                    MaxActivations = Math.Clamp(maxActivations, 1, 100),
                    BindIp = bindIp,
                    AllowedIps = new HashSet<string>(allowedIps, StringComparer.OrdinalIgnoreCase),
                    CreatedAt = DateTimeOffset.UtcNow
                };
                record.CardCiphertext = _cardProtector.Encrypt(card, record.Id);
                records.Add(record);
                result.Add(new { card, id = record.Id, expiresAt = record.ExpiresAt, maxActivations = record.MaxActivations, bindIp = record.BindIp, allowedIps = record.AllowedIps });
            }
            await SaveAsync(records);
            return result;
        }
        finally { _gate.Release(); }
    }

    public async Task<IReadOnlyList<object>> ListAsync()
    {
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            // Deleted cards remain as server-side tombstones so an old card
            // cannot be recreated or restored, but they are hidden from the
            // administrator list after deletion.
            return records.Where(x => !string.Equals(x.Status, "deleted", StringComparison.OrdinalIgnoreCase)).Select(x => (object)new
            {
                x.Id,
                card = _cardProtector.TryDecrypt(x.CardCiphertext, x.Id, out var card) ? card : CardDisplayLabel(x.CardCiphertext),
                x.Status,
                x.ExpiresAt,
                x.MaxActivations,
                x.BindIp,
                allowedIps = x.AllowedIps.OrderBy(y => y).ToArray(),
                boundIps = x.BoundIps.OrderBy(y => y).ToArray(),
                activationCount = x.InstallIds.Count,
                x.CreatedAt,
                x.LastSeenAt,
                x.LastBuildId,
                x.LastBuildSequence,
                x.LastCustomerId,
                x.LastBinaryHash,
                runtimeUpdatedAt = x.RuntimeUpdatedAt,
                runtimeOsDescription = x.RuntimeOsDescription,
                runtimeHostName = x.RuntimeHostName,
                runtimeCpuCount = x.RuntimeCpuCount,
                runtimeCpuLoadPercent = x.RuntimeCpuLoadPercent,
                runtimeTotalMemoryBytes = x.RuntimeTotalMemoryBytes,
                runtimeProcessWorkingSetBytes = x.RuntimeProcessWorkingSetBytes,
                runtimeGcHeapBytes = x.RuntimeGcHeapBytes,
                runtimeUptimeSeconds = x.RuntimeUptimeSeconds,
                configExists = x.ConfigExists,
                configSizeBytes = x.ConfigSizeBytes,
                configSha256 = x.ConfigSha256,
                configLastWriteUtc = x.ConfigLastWriteUtc,
                privateEnabled = x.PrivateEnabled,
                privateGeneration = x.PrivateGeneration,
                privateNodeRegistered = !string.IsNullOrWhiteSpace(x.PrivateNodeId),
                privateNodeIp = x.PrivateNodeIp,
                privateLastSeenAt = x.PrivateLastSeenAt,
                x.DeletedAt
            }).ToList();
        }
        finally { _gate.Release(); }
    }

    public async Task<bool> SetStatusAsync(string id, string status)
    {
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var r = records.FirstOrDefault(x => x.Id == id);
            if (r is null || r.PrivateEnabled || (status == "active" && r.Status == "deleted")) return false;
            var previousStatus = r.Status;
            r.Status = status;
            await SaveAsync(records);
            if (!string.Equals(previousStatus, status, StringComparison.OrdinalIgnoreCase))
            {
                await AppendAnomalyAsync(new AnomalyEvent
                {
                    EventType = status == "revoked" ? "manual-revoke" : status == "active" ? "manual-restore" : "status-change",
                    LicenseId = r.Id,
                    LicenseHash = r.LicenseHash,
                    CardCiphertext = r.CardCiphertext,
                    OccurredAt = DateTimeOffset.UtcNow,
                    Reason = $"管理员将状态从 {previousStatus} 修改为 {status}"
                });
            }
            return true;
        }
        finally { _gate.Release(); }
    }

    public async Task<bool> DeleteAsync(string id)
    {
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var index = records.FindIndex(x => x.Id == id);
            if (index < 0 || records[index].PrivateEnabled) return false;
            var removed = records[index];
            // Remove the complete record. The delete operation is irreversible;
            // the deployment backup is the only operational rollback point.
            records.RemoveAt(index);
            await SaveAsync(records);
            await AppendAnomalyAsync(new AnomalyEvent
            {
                EventType = "manual-delete",
                LicenseId = removed.Id,
                LicenseHash = removed.LicenseHash,
                CardCiphertext = removed.CardCiphertext,
                OccurredAt = DateTimeOffset.UtcNow,
                Reason = "管理员彻底删除卡密"
            });
            return true;
        }
        finally { _gate.Release(); }
    }

    public async Task<bool> ResetActivationsAsync(string id)
    {
        await _gate.WaitAsync();
        try { var records = await LoadAsync(); var r = records.FirstOrDefault(x => x.Id == id); if (r is null || r.PrivateEnabled) return false; r.InstallIds.Clear(); r.BoundIps.Clear(); await SaveAsync(records); return true; }
        finally { _gate.Release(); }
    }

    public async Task<bool> UnbindAsync(string id, bool clearAllowedIps)
    {
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var r = records.FirstOrDefault(x => x.Id == id);
            if (r is null || r.PrivateEnabled) return false;
            r.InstallIds.Clear();
            r.BoundIps.Clear();
            if (clearAllowedIps) r.AllowedIps.Clear();
            await SaveAsync(records);
            return true;
        }
        finally { _gate.Release(); }
    }

    public async Task<bool> SetAllowedIpsAsync(string id, IReadOnlyCollection<string> ips, bool bindIp, bool clearBindings)
    {
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var r = records.FirstOrDefault(x => x.Id == id);
            if (r is null || r.PrivateEnabled) return false;
            r.AllowedIps = new HashSet<string>(ips, StringComparer.OrdinalIgnoreCase);
            r.BindIp = bindIp;
            if (clearBindings) { r.InstallIds.Clear(); r.BoundIps.Clear(); }
            await SaveAsync(records);
            return true;
        }
        finally { _gate.Release(); }
    }

    public async Task<bool> RemoveIpAsync(string id, string ip)
    {
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var r = records.FirstOrDefault(x => x.Id == id);
            if (r is null || r.PrivateEnabled) return false;
            r.AllowedIps.Remove(ip);
            r.BoundIps.Remove(ip);
            await SaveAsync(records);
            return true;
        }
        finally { _gate.Release(); }
    }

    public async Task<bool> UpdateSettingsAsync(string id, LicenseSettingsRequest request)
    {
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var r = records.FirstOrDefault(x => x.Id == id);
            if (r is null || r.PrivateEnabled) return false;
            if (request.Days is not null) r.ExpiresAt = request.Days.Value == 0 ? null : DateTimeOffset.UtcNow.AddDays(request.Days.Value);
            if (request.MaxActivations is not null) r.MaxActivations = Math.Clamp(request.MaxActivations.Value, 1, 100);
            if (request.BindIp is not null) r.BindIp = request.BindIp.Value;
            await SaveAsync(records);
            return true;
        }
        finally { _gate.Release(); }
    }

    public async Task<BuildPolicy> GetBuildPolicyAsync()
    {
        await _gate.WaitAsync();
        try { return await LoadBuildPolicyAsync(); }
        finally { _gate.Release(); }
    }

    public async Task<IReadOnlyList<object>> ListAnomaliesAsync(int limit)
    {
        await _gate.WaitAsync();
        try
        {
            var events = await LoadAnomaliesAsync();
            var records = await LoadAsync();
            var byId = records.ToDictionary(x => x.Id, StringComparer.Ordinal);
            return events.OrderByDescending(x => x.OccurredAt).Take(Math.Clamp(limit, 1, 1000)).Select(x => (object)new
            {
                x.Id,
                x.EventType,
                card = byId.TryGetValue(x.LicenseId, out var current) && _cardProtector.TryDecrypt(current.CardCiphertext, current.Id, out var currentCard)
                    ? currentCard
                    : _cardProtector.TryDecrypt(x.CardCiphertext, x.LicenseId, out var historicalCard) ? historicalCard : CardDisplayLabel(x.CardCiphertext),
                x.LicenseId,
                x.OccurredAt,
                x.Reason,
                x.RemoteIp,
                x.InstallId,
                x.BuildId,
                x.BuildSequence,
                x.CustomerId,
                x.BinaryHash
            }).ToList();
        }
        finally { _gate.Release(); }
    }

    public async Task UpdateBuildPolicyAsync(BuildPolicy policy)
    {
        await _gate.WaitAsync();
        try
        {
            var normalized = new BuildPolicy(policy.MinBuildSequence,
                policy.AllowedBuildIds.Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => x.Trim()).Distinct(StringComparer.Ordinal).ToArray(),
                policy.RequireBinaryHash,
                policy.AllowedBinaryHashes.ToDictionary(x => x.Key, x => x.Value.Select(y => y.ToUpperInvariant()).Distinct(StringComparer.Ordinal).ToArray(), StringComparer.Ordinal));
            var temporary = _policyPath + ".tmp";
            await File.WriteAllTextAsync(temporary, JsonSerializer.Serialize(normalized, _json));
            File.Move(temporary, _policyPath, true);
        }
        finally { _gate.Release(); }
    }

    private async Task<BuildPolicy> LoadBuildPolicyAsync()
    {
        if (!File.Exists(_policyPath)) return BuildPolicy.Default;
        try
        {
            await using var stream = File.OpenRead(_policyPath);
            return await JsonSerializer.DeserializeAsync<BuildPolicy>(stream, _json) ?? BuildPolicy.Default;
        }
        catch (JsonException)
        {
            return BuildPolicy.Default;
        }
    }

    public async Task<object?> GetDetailsAsync(string id)
    {
        await _gate.WaitAsync();
        try
        {
            var r = (await LoadAsync()).FirstOrDefault(x => x.Id == id && !string.Equals(x.Status, "deleted", StringComparison.OrdinalIgnoreCase));
            if (r is null) return null;
            return new
            {
                r.Id,
                card = _cardProtector.TryDecrypt(r.CardCiphertext, r.Id, out var card) ? card : CardDisplayLabel(r.CardCiphertext),
                r.Status, r.ExpiresAt, r.MaxActivations, r.BindIp,
                allowedIps = r.AllowedIps.OrderBy(x => x).ToArray(),
                boundIps = r.BoundIps.OrderBy(x => x).ToArray(),
                activationCount = r.InstallIds.Count,
                r.CreatedAt, r.LastSeenAt, r.LastBuildId, r.LastBuildSequence, r.LastCustomerId, r.LastBinaryHash,
                runtimeUpdatedAt = r.RuntimeUpdatedAt, runtimeOsDescription = r.RuntimeOsDescription,
                runtimeHostName = r.RuntimeHostName, runtimeCpuCount = r.RuntimeCpuCount,
                runtimeCpuLoadPercent = r.RuntimeCpuLoadPercent, runtimeTotalMemoryBytes = r.RuntimeTotalMemoryBytes,
                runtimeProcessWorkingSetBytes = r.RuntimeProcessWorkingSetBytes, runtimeGcHeapBytes = r.RuntimeGcHeapBytes,
                runtimeUptimeSeconds = r.RuntimeUptimeSeconds, configExists = r.ConfigExists,
                configSizeBytes = r.ConfigSizeBytes, configSha256 = r.ConfigSha256,
                configLastWriteUtc = r.ConfigLastWriteUtc, configContent = r.ConfigContent,
                privateEnabled = r.PrivateEnabled, privateGeneration = r.PrivateGeneration,
                privateNodeRegistered = !string.IsNullOrWhiteSpace(r.PrivateNodeId),
                privateNodeIp = r.PrivateNodeIp, privateLastSeenAt = r.PrivateLastSeenAt, privateLastRemoteIp = r.PrivateLastRemoteIp
            };
        }
        finally { _gate.Release(); }
    }

    public async Task<RuntimeStatusResult> UpdateRuntimeStatusAsync(StatusReportRequest request, string remoteIp)
    {
        if (string.IsNullOrWhiteSpace(request.License) || string.IsNullOrWhiteSpace(request.InstallId)
            || string.IsNullOrWhiteSpace(request.LicenseId) || string.IsNullOrWhiteSpace(request.Product)
            || string.IsNullOrWhiteSpace(request.Challenge) || string.IsNullOrWhiteSpace(request.Signature)
            || string.IsNullOrWhiteSpace(request.BuildId) || string.IsNullOrWhiteSpace(request.CustomerId)
            || string.IsNullOrWhiteSpace(request.BuildSignature) || string.IsNullOrWhiteSpace(request.BinaryHash)
            || request.ConfigSizeBytes < 0 || request.ConfigSizeBytes > 5 * 1024 * 1024)
            return RuntimeStatusResult.Invalid;
        if (request.ConfigContent is not null && Encoding.UTF8.GetByteCount(request.ConfigContent) > 5 * 1024 * 1024)
            return RuntimeStatusResult.Invalid;
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var record = records.FirstOrDefault(x => x.LicenseHash == Hash(request.License));
            if (record is null || record.Status != "active" || record.Id != request.LicenseId
                || !record.InstallIds.Contains(request.InstallId)) return RuntimeStatusResult.Invalid;
            if (record.BindIp && (string.IsNullOrWhiteSpace(remoteIp)
                || (record.AllowedIps.Count > 0 && !record.AllowedIps.Contains(remoteIp, StringComparer.OrdinalIgnoreCase))))
                return RuntimeStatusResult.Invalid;
            if (BuildTrust.Validate(request.BuildId, request.BuildSequence, request.CustomerId,
                request.BuildSignature, request.BinaryHash, await LoadBuildPolicyAsync()) is not null)
                return RuntimeStatusResult.Invalid;
            var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            if (request.IssuedAtUnix > now + 120 || request.LeaseExpiresAtUnix <= now
                || request.LeaseExpiresAtUnix <= request.IssuedAtUnix
                || request.LeaseExpiresAtUnix - request.IssuedAtUnix > (long)TimeSpan.FromMinutes(20).TotalSeconds)
                return RuntimeStatusResult.Invalid;
            var signingKey = SigningKeyLoader.Load();
            if (!VerifyLeaseSignature(signingKey, request)) return RuntimeStatusResult.Invalid;
            if (request.ConfigContent is not null && request.ConfigSha256.Length == 64
                && !request.ConfigSha256.Any(c => !Uri.IsHexDigit(c))
                && !string.Equals(Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(request.ConfigContent))), request.ConfigSha256, StringComparison.OrdinalIgnoreCase))
                return RuntimeStatusResult.Invalid;
            record.LastSeenAt = DateTimeOffset.UtcNow;
            record.LastBuildId = request.BuildId;
            record.LastBuildSequence = request.BuildSequence;
            record.LastCustomerId = request.CustomerId;
            record.LastBinaryHash = request.BinaryHash;
            record.RuntimeUpdatedAt = record.LastSeenAt;
            record.RuntimeOsDescription = TrimField(request.OsDescription, 256);
            record.RuntimeHostName = TrimField(request.HostName, 256);
            record.RuntimeCpuCount = Math.Clamp(request.CpuCount, 0, 4096);
            record.RuntimeCpuLoadPercent = Math.Clamp(request.CpuLoadPercent, 0, 100);
            record.RuntimeTotalMemoryBytes = Math.Max(0, request.TotalMemoryBytes);
            record.RuntimeProcessWorkingSetBytes = Math.Max(0, request.ProcessWorkingSetBytes);
            record.RuntimeGcHeapBytes = Math.Max(0, request.GcHeapBytes);
            record.RuntimeUptimeSeconds = Math.Max(0, request.UptimeSeconds);
            record.ConfigExists = request.ConfigExists;
            record.ConfigSizeBytes = Math.Max(0, request.ConfigSizeBytes);
            record.ConfigSha256 = request.ConfigSha256?.Trim().ToUpperInvariant();
            record.ConfigLastWriteUtc = DateTimeOffset.TryParse(request.ConfigLastWriteUtc, out var configWrite) ? configWrite : null;
            if (request.ConfigContent is not null) record.ConfigContent = request.ConfigContent;
            await SaveAsync(records);
            return RuntimeStatusResult.Updated;
        }
        finally { _gate.Release(); }
    }

    private static bool VerifyLeaseSignature(string? signingKey, StatusReportRequest request)
    {
        if (string.IsNullOrWhiteSpace(signingKey)) return false;
        try
        {
            var canonical = LicenseDecision.Canonical(request.LicenseId, request.Product, request.InstallId,
                request.Challenge, request.BuildId, request.BuildSequence, request.CustomerId, request.BinaryHash,
                DateTimeOffset.FromUnixTimeSeconds(request.IssuedAtUnix), DateTimeOffset.FromUnixTimeSeconds(request.LeaseExpiresAtUnix));
            using var verifier = ECDsa.Create();
            verifier.ImportFromPem(signingKey);
            return verifier.VerifyData(Encoding.UTF8.GetBytes(canonical), Convert.FromBase64String(request.Signature), HashAlgorithmName.SHA256);
        }
        catch (CryptographicException) { return false; }
        catch (FormatException) { return false; }
        catch (ArgumentOutOfRangeException) { return false; }
    }

    private static string? TrimField(string? value, int max) => string.IsNullOrWhiteSpace(value) ? null : value.Trim()[..Math.Min(value.Trim().Length, max)];

    public async Task<ExtendResult> ExtendAsync(string id, int days)
    {
        await _gate.WaitAsync();
        try
        {
            var records = await LoadAsync();
            var record = records.FirstOrDefault(x => x.Id == id && !string.Equals(x.Status, "deleted", StringComparison.OrdinalIgnoreCase));
            if (record is null || record.PrivateEnabled) return new(ExtendStatus.NotFound, null);
            if (record.ExpiresAt is null) return new(ExtendStatus.Permanent, null);
            var now = DateTimeOffset.UtcNow;
            record.ExpiresAt = (record.ExpiresAt > now ? record.ExpiresAt.Value : now).AddDays(days);
            await SaveAsync(records);
            await AppendAnomalyAsync(new AnomalyEvent { EventType = "manual-extend", LicenseId = record.Id, LicenseHash = record.LicenseHash,
                CardCiphertext = record.CardCiphertext, OccurredAt = now, Reason = $"管理员续期 {days} 天" });
            return new(ExtendStatus.Extended, record.ExpiresAt);
        }
        finally { _gate.Release(); }
    }

    private async Task<List<LicenseRecord>> LoadAsync()
    {
        if (_records is not null) return _records;
        if (!File.Exists(_path)) return _records = new List<LicenseRecord>();
        List<LicenseRecord> records;
        await using (var stream = File.OpenRead(_path))
            records = await JsonSerializer.DeserializeAsync<List<LicenseRecord>>(stream, _json) ?? new List<LicenseRecord>();
        // Records created by the first private-node release stored the source
        // address only as PrivateLastRemoteIp. Backfill the dedicated display
        // field once so existing nodes appear in the admin list without
        // touching plugin AllowedIps/BoundIps.
        var migrated = false;
        foreach (var record in records)
        {
            if (!record.PrivateEnabled || string.IsNullOrWhiteSpace(record.PrivateNodeId)
                || !string.IsNullOrWhiteSpace(record.PrivateNodeIp)
                || !TryNormalizePrivateNodeIp(record.PrivateLastRemoteIp, out var nodeIp)) continue;
            record.PrivateNodeIp = nodeIp;
            migrated = true;
        }
        _records = records;
        if (migrated) await SaveAsync(records);
        return records;
    }

    private static bool TryNormalizePrivateNodeIp(string? raw, out string normalized)
    {
        normalized = string.Empty;
        if (!System.Net.IPAddress.TryParse(raw?.Trim(), out var address)) return false;
        if (address.IsIPv4MappedToIPv6) address = address.MapToIPv4();
        normalized = address.ToString();
        return normalized.Length > 0;
    }

    private async Task<List<PrivateEnrollment>> LoadPrivateAsync()
    {
        if (!File.Exists(_privatePath)) return new List<PrivateEnrollment>();
        await using var stream = File.OpenRead(_privatePath);
        try { return await JsonSerializer.DeserializeAsync<List<PrivateEnrollment>>(stream, _json) ?? new List<PrivateEnrollment>(); }
        catch (JsonException) { return new List<PrivateEnrollment>(); }
    }

    private async Task SavePrivateAsync(List<PrivateEnrollment> records)
    {
        var temporary = _privatePath + ".tmp";
        await using (var stream = File.Create(temporary)) await JsonSerializer.SerializeAsync(stream, records, _json);
        File.Move(temporary, _privatePath, true);
    }

    private async Task SaveAsync(List<LicenseRecord> records)
    {
        _records = records;
        var temporary = _path + ".tmp";
        await using (var stream = File.Create(temporary)) await JsonSerializer.SerializeAsync(stream, records, _json);
        File.Move(temporary, _path, true);
    }

    private async Task<List<AnomalyEvent>> LoadAnomaliesAsync()
    {
        if (!File.Exists(_anomalyPath)) return new List<AnomalyEvent>();
        await using var stream = File.OpenRead(_anomalyPath);
        try { return await JsonSerializer.DeserializeAsync<List<AnomalyEvent>>(stream, _json) ?? new List<AnomalyEvent>(); }
        catch (JsonException) { return new List<AnomalyEvent>(); }
    }

    private async Task AppendAnomalyAsync(AnomalyEvent entry)
    {
        var events = await LoadAnomaliesAsync();
        events.Add(entry);
        // Keep this audit file bounded so a noisy installation cannot grow it without limit.
        if (events.Count > 10000) events = events.OrderByDescending(x => x.OccurredAt).Take(10000).OrderBy(x => x.OccurredAt).ToList();
        var temporary = _anomalyPath + ".tmp";
        await using (var stream = File.Create(temporary)) await JsonSerializer.SerializeAsync(stream, events, _json);
        File.Move(temporary, _anomalyPath, true);
    }

    private static string CreateCard()
    {
        Span<byte> bytes = stackalloc byte[16];
        RandomNumberGenerator.Fill(bytes);
        return "SF-" + Convert.ToHexString(bytes)[..24];
    }

    private static string Hash(string value) => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(value.Trim().ToUpperInvariant())));

    private static string CardDisplayLabel(string? ciphertext) => string.IsNullOrWhiteSpace(ciphertext)
        ? "旧版卡密不可恢复"
        : "卡密无法解密";
}

sealed class LicenseRecord
{
    public string Id { get; set; } = string.Empty;
    public string LicenseHash { get; set; } = string.Empty;
    public string? CardCiphertext { get; set; }
    public string Status { get; set; } = "active";
    public DateTimeOffset? ExpiresAt { get; set; }
    public int MaxActivations { get; set; } = 1;
    public HashSet<string> InstallIds { get; set; } = new(StringComparer.Ordinal);
    public HashSet<string> BoundIps { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public HashSet<string> AllowedIps { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public bool BindIp { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? LastSeenAt { get; set; }
    public string? LastBuildId { get; set; }
    public long LastBuildSequence { get; set; }
    public string? LastCustomerId { get; set; }
    public string? LastBinaryHash { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public DateTimeOffset? LastTamperAt { get; set; }
    public string? LastTamperReason { get; set; }
    public DateTimeOffset? RuntimeUpdatedAt { get; set; }
    public string? RuntimeOsDescription { get; set; }
    public string? RuntimeHostName { get; set; }
    public int RuntimeCpuCount { get; set; }
    public double RuntimeCpuLoadPercent { get; set; }
    public long RuntimeTotalMemoryBytes { get; set; }
    public long RuntimeProcessWorkingSetBytes { get; set; }
    public long RuntimeGcHeapBytes { get; set; }
    public long RuntimeUptimeSeconds { get; set; }
    public bool ConfigExists { get; set; }
    public long ConfigSizeBytes { get; set; }
    public string? ConfigSha256 { get; set; }
    public DateTimeOffset? ConfigLastWriteUtc { get; set; }
    public string? ConfigContent { get; set; }
    public bool PrivateEnabled { get; set; }
    public long PrivateGeneration { get; set; }
    // Delegations at or below this generation belonged to a node explicitly
    // retired by an administrator and may not reclaim the registration.
    public long PrivateRetiredGeneration { get; set; }
    public string? PrivateNodeId { get; set; }
    public string? PrivateNodePublicKeyPem { get; set; }
    // Captured once during node registration. It is separate from plugin
    // AllowedIps and BoundIps, which remain private-node local state.
    public string? PrivateNodeIp { get; set; }
    public DateTimeOffset? PrivateLastSeenAt { get; set; }
    public string? PrivateLastRemoteIp { get; set; }
}

sealed class PrivateEnrollment
{
    public string LicenseId { get; set; } = string.Empty;
    public string CodeHash { get; set; } = string.Empty;
    public DateTimeOffset ExpiresAt { get; set; }
    public bool Used { get; set; }
}

sealed record PrivateBinaryInfo(string Path, string Version, string Sha256, DateTimeOffset LastWriteUtc);
sealed record PrivateBinaryDownload(FileStream Stream, string Sha256, DateTimeOffset LastModifiedUtc);

sealed class RateWindow
{
    public DateTimeOffset Start { get; set; } = DateTimeOffset.UtcNow;
    public int Count { get; set; }
}

sealed class AnomalyEvent
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string EventType { get; set; } = string.Empty;
    public string LicenseId { get; set; } = string.Empty;
    public string LicenseHash { get; set; } = string.Empty;
    public string? CardCiphertext { get; set; }
    public DateTimeOffset OccurredAt { get; set; }
    public string Reason { get; set; } = string.Empty;
    public string? RemoteIp { get; set; }
    public string? InstallId { get; set; }
    public string? BuildId { get; set; }
    public long BuildSequence { get; set; }
    public string? CustomerId { get; set; }
    public string? BinaryHash { get; set; }
}

sealed class CardProtector
{
    private const string KeyEnvironmentName = "LICENSE_CARD_ENCRYPTION_KEY";
    private readonly byte[]? _key;

    public CardProtector()
    {
        var configured = Environment.GetEnvironmentVariable(KeyEnvironmentName);
        if (string.IsNullOrWhiteSpace(configured)) return;
        try
        {
            var key = Convert.FromBase64String(configured);
            if (key.Length != 32) throw new InvalidOperationException();
            _key = key;
        }
        catch (Exception ex) when (ex is FormatException or InvalidOperationException)
        {
            throw new InvalidOperationException($"{KeyEnvironmentName} must be a Base64-encoded 32-byte key.", ex);
        }
    }

    public string Encrypt(string card, string recordId)
    {
        if (_key is null) throw new InvalidOperationException($"{KeyEnvironmentName} must be configured before generating cards.");
        var nonce = RandomNumberGenerator.GetBytes(12);
        var plaintext = Encoding.UTF8.GetBytes(card);
        var ciphertext = new byte[plaintext.Length];
        var tag = new byte[16];
        using var aes = new AesGcm(_key);
        aes.Encrypt(nonce, plaintext, ciphertext, tag, Encoding.UTF8.GetBytes(recordId));
        return $"v1.{Convert.ToBase64String(nonce)}.{Convert.ToBase64String(ciphertext)}.{Convert.ToBase64String(tag)}";
    }

    public bool TryDecrypt(string? protectedCard, string recordId, out string card)
    {
        card = string.Empty;
        if (_key is null || string.IsNullOrWhiteSpace(protectedCard)) return false;
        var parts = protectedCard.Split('.', StringSplitOptions.None);
        if (parts.Length != 4 || parts[0] != "v1") return false;
        try
        {
            var nonce = Convert.FromBase64String(parts[1]);
            var ciphertext = Convert.FromBase64String(parts[2]);
            var tag = Convert.FromBase64String(parts[3]);
            if (nonce.Length != 12 || tag.Length != 16) return false;
            var plaintext = new byte[ciphertext.Length];
            using var aes = new AesGcm(_key);
            aes.Decrypt(nonce, ciphertext, tag, plaintext, Encoding.UTF8.GetBytes(recordId));
            card = Encoding.UTF8.GetString(plaintext);
            return card.Length > 0;
        }
        catch (CryptographicException) { return false; }
        catch (FormatException) { return false; }
    }
}

record BuildPolicy(long MinBuildSequence, string[] AllowedBuildIds, bool RequireBinaryHash,
    Dictionary<string, string[]> AllowedBinaryHashes)
{
    public static BuildPolicy Default { get; } = new(2026082401, Array.Empty<string>(), false,
        new Dictionary<string, string[]>(StringComparer.Ordinal));
}

record LicenseDecision(bool Valid, string? Error, string? LicenseId, DateTimeOffset? ExpiresAt, bool AllFeatures, string Product,
    string BuildId = "", long BuildSequence = 0, string CustomerId = "", string BinaryHash = "", string? Signature = null,
    long IssuedAtUnix = 0, long LeaseExpiresAtUnix = 0)
{
    public static LicenseDecision Invalid(string error, string product) => new(false, error, null, null, false, product);

    public static string Canonical(string licenseId, string product, string installId, string challenge,
        string buildId, long buildSequence, string customerId, string binaryHash, DateTimeOffset issuedAt, DateTimeOffset leaseExpiresAt) =>
        string.Join("|", licenseId, product, installId, challenge, buildId,
            buildSequence.ToString(CultureInfo.InvariantCulture), customerId, binaryHash,
            issuedAt.ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture),
            leaseExpiresAt.ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture));
}

record TamperReportRequest(string License, string InstallId, string Product, string LicenseId, string Challenge,
    string BuildId, long BuildSequence, string CustomerId, string BuildSignature, string BinaryHash,
    string Signature, long IssuedAtUnix, long LeaseExpiresAtUnix, string Reason);

enum TamperReportResult
{
    Revoked,
    Invalid,
    Unavailable
}

enum RuntimeStatusResult
{
    Updated,
    Invalid,
    Unavailable
}

enum ExtendStatus
{
    Extended,
    NotFound,
    Permanent
}

record ExtendResult(ExtendStatus Status, DateTimeOffset? ExpiresAt);
