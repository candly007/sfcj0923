using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(o => o.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase);
builder.Services.AddSingleton<PrivateNodeStore>();
var app = builder.Build();
var node = app.Services.GetRequiredService<PrivateNodeStore>();

app.MapGet("/", () => Results.Content(PrivateAdminPage.Html, "text/html; charset=utf-8"));
app.MapGet("/health", () => node.Health());
app.MapPost("/api/license/activate", async (ActivateRequest request, HttpContext context) =>
    Results.Json(await node.ActivateAsync(request, RequestIp(context))));
app.MapPost("/api/license/validate", async (ActivateRequest request, HttpContext context) =>
    Results.Json(await node.ActivateAsync(request, RequestIp(context))));
app.MapPost("/api/license/status", (StatusRequest request) => node.ValidateLease(request) ? Results.Ok(new { updated = true }) : Results.StatusCode(403));
app.MapPost("/api/license/tamper", (StatusRequest request) => node.ReportTamper(request) ? Results.Ok(new { accepted = true }) : Results.StatusCode(403));
app.MapPost("/api/private/admin/unbind", (HttpRequest request) =>
{
    var result = node.Unbind(request);
    if (!result.Authorized) return Results.Unauthorized();
    if (!result.Success) return Results.Json(new { error = result.Error, message = "本月插件卡密解绑次数已用完（每月最多 3 次）", used = result.Used, remaining = result.Remaining }, statusCode: 429);
    return Results.Ok(new { unbound = true, used = result.Used, remaining = result.Remaining });
});
app.MapGet("/api/private/admin/status", (HttpRequest request) => node.AdminStatus(request));
app.Run();

static string RequestIp(HttpContext context)
{
#if PRIVATE_LICENSE_TEST_OVERRIDES
    // TestHost-only source-IP simulation; production builds always use the socket peer.
    var simulated = context.Request.Headers["X-Test-Remote-IP"].ToString().Trim();
    if (!string.IsNullOrWhiteSpace(simulated) && simulated.Length <= 64) return simulated;
#endif
    return context.Connection.RemoteIpAddress?.ToString() ?? string.Empty;
}

static class PrivateAdminPage
{
public const string Html = """
<!doctype html>
<html lang="zh-CN">
<head><meta charset="utf-8"><meta name="viewport" content="width=device-width,initial-scale=1"><title>私有授权管理</title>
<style>
:root{color-scheme:dark;--bg:#0b1220;--panel:#111c2f;--panel2:#17263d;--line:#2b405d;--text:#eef5ff;--muted:#92a7c1;--accent:#49d39b;--danger:#f27d88;--warn:#f5bd57}
*{box-sizing:border-box}body{margin:0;min-height:100vh;background:linear-gradient(135deg,#08111f,#12223a);color:var(--text);font:15px/1.5 system-ui,-apple-system,"Segoe UI",sans-serif}.shell{display:grid;grid-template-columns:225px minmax(0,1fr);min-height:100vh}.rail{padding:28px 18px;background:rgba(7,14,25,.78);border-right:1px solid var(--line);display:flex;flex-direction:column}.brand{font-size:20px;font-weight:700}.brand small{display:block;color:var(--muted);font-size:12px;font-weight:400;margin-top:5px}.nav{margin-top:36px}.nav div{padding:11px 13px;border:1px solid var(--line);background:var(--panel2);color:var(--text)}.rail-foot{margin-top:auto;color:var(--muted);font-size:12px}.main{width:min(1040px,100%);padding:38px 42px 52px}.top{display:flex;justify-content:space-between;gap:18px}.eyebrow{color:var(--accent);font-size:12px;font-weight:700;letter-spacing:1.2px}.top h1{margin:7px 0 4px;font-size:30px}.top p{margin:0;color:var(--muted)}.endpoint{color:var(--muted);font:12px ui-monospace,monospace;padding-top:4px;word-break:break-all;text-align:right}.summary{display:grid;grid-template-columns:repeat(4,minmax(0,1fr));gap:12px;margin:30px 0 18px}.metric,.panel{background:rgba(17,28,47,.94);border:1px solid var(--line)}.metric{padding:16px 17px;min-height:88px}.metric label{display:block;color:var(--muted);font-size:12px;margin-bottom:8px}.metric strong{font-size:18px}.ok{color:var(--accent)}.warn{color:var(--warn)}.danger{color:var(--danger)}.panel{padding:21px;margin-top:15px}.panel-head{display:flex;justify-content:space-between;align-items:center;gap:16px;margin-bottom:16px}.panel h2{font-size:17px;margin:0}.panel-head span{color:var(--muted);font-size:12px}.form{display:grid;grid-template-columns:minmax(0,1fr) auto auto;gap:10px;align-items:end}.field label{display:block;color:var(--muted);font-size:12px;margin-bottom:6px}.field input{width:100%;height:42px;padding:0 12px;border:1px solid var(--line);background:#0a1425;color:var(--text);font:14px ui-monospace,monospace}.field input:focus{outline:2px solid rgba(73,211,155,.25);border-color:var(--accent)}button{height:42px;padding:0 16px;border:1px solid var(--line);background:#1c304c;color:var(--text);font:600 14px system-ui;cursor:pointer}button:hover{background:#25405f;border-color:#5a7799}button:disabled{opacity:.55;cursor:wait}.primary{background:var(--accent);border-color:var(--accent);color:#07151a}.primary:hover{background:#74e5b8;border-color:#74e5b8}.outline-danger{background:transparent;border-color:#75424c;color:#ffadb4}.notice{min-height:22px;margin-top:12px;color:var(--muted);font-size:13px}.detail{display:grid;grid-template-columns:repeat(2,minmax(0,1fr));gap:0 30px}.row{display:flex;justify-content:space-between;gap:16px;padding:12px 0;border-bottom:1px solid rgba(43,64,93,.7)}.row label{color:var(--muted)}.row span{text-align:right;word-break:break-all}.mono{font:13px ui-monospace,SFMono-Regular,Consolas,monospace}.empty{color:var(--muted);padding:12px 0}.footer{margin-top:17px;color:var(--muted);font-size:12px}@media(max-width:780px){.shell{display:block}.rail{padding:18px 20px;border-right:0;border-bottom:1px solid var(--line)}.nav{margin-top:15px}.rail-foot{display:none}.main{padding:25px 17px 40px}.top{display:block}.endpoint{text-align:left;margin-top:12px}.summary{grid-template-columns:repeat(2,minmax(0,1fr));margin-top:22px}.form,.detail{grid-template-columns:1fr}}
</style></head>
<body><div class="shell"><aside class="rail"><div class="brand">私有授权<small>节点管理控制台</small></div><nav class="nav"><div>节点状态</div></nav><div class="rail-foot">当前页面仅管理本节点<br>不生成卡密，不执行远程命令</div></aside>
<main class="main"><header class="top"><div><div class="eyebrow">PRIVATE NODE</div><h1>节点状态</h1><p>查看授权连接、绑定信息与本地运行状态</p></div><div class="endpoint" id="endpoint"></div></header>
<section class="summary"><div class="metric"><label>授权状态</label><strong id="status" class="warn">未读取</strong></div><div class="metric"><label>到期时间</label><strong id="expires">-</strong></div><div class="metric"><label>绑定 IP</label><strong id="boundIp" class="mono">-</strong></div><div class="metric"><label>最近同步</label><strong id="lastSync">-</strong></div></section>
<section class="panel"><div class="panel-head"><h2>卡密验证</h2><span>卡密只发送到当前私有节点</span></div><div class="form"><div class="field"><label for="card">当前节点卡密</label><input id="card" type="password" autocomplete="off" placeholder="输入该节点绑定的完整卡密"></div><button id="loadButton" class="primary" onclick="load()">读取状态</button><button id="unbindButton" class="outline-danger" onclick="unbind()">彻底解绑</button></div><div id="notice" class="notice">请输入当前节点对应的卡密</div></section>
<section class="panel"><div class="panel-head"><h2>授权详情</h2><span>读取后每 30 秒自动刷新</span></div><div id="details" class="detail"><div class="empty">验证后显示节点详情</div></div></section><div class="footer">私有授权节点 · <span id="footerAddress"></span></div></main></div>
<script>
const card=document.getElementById('card'),notice=document.getElementById('notice'),details=document.getElementById('details');const statusEl=document.getElementById('status'),expiresEl=document.getElementById('expires'),boundIpEl=document.getElementById('boundIp'),lastSyncEl=document.getElementById('lastSync'),loadButton=document.getElementById('loadButton'),unbindButton=document.getElementById('unbindButton');let loaded=false,busy=false;document.getElementById('endpoint').textContent=location.origin;document.getElementById('footerAddress').textContent=location.host;
function esc(v){return String(v??'-').replace(/[&<>"']/g,c=>({'&':'&amp;','<':'&lt;','>':'&gt;','"':'&quot;',"'":'&#39;'}[c]))}function time(v){if(!v)return '-';const d=new Date(v);return Number.isNaN(d.getTime())?String(v):d.toLocaleString()}function setNotice(t,k=''){notice.textContent=t;notice.className='notice '+k}function row(k,v,m=false){return '<div class="row"><label>'+esc(k)+'</label><span class="'+(m?'mono':'')+'">'+esc(v)+'</span></div>'}
function render(d){loaded=true;const configured=!!d.configured;statusEl.textContent=configured?'已配置':'未登记';statusEl.className=configured?'ok':'warn';expiresEl.textContent=d.expiresAt||'-';boundIpEl.textContent=d.boundIp||'未绑定';lastSyncEl.textContent=time(d.lastSyncAt);details.innerHTML=row('授权标识',d.licenseId||'未登记',true)+row('安装标识',d.installId||'未绑定',true)+row('绑定 IP',d.boundIp||'未绑定',true)+row('授权到期',d.expiresAt||'-')+row('最后同步',time(d.lastSyncAt))+row('本月解绑次数',(d.unbindCount||0)+' / 3（剩余 '+(d.unbindRemaining??3)+' 次）')+row('完整性状态',d.tamperBlocked?'已阻断':'正常')+(d.lastTamperReason?row('最近异常',d.lastTamperReason):'')}
async function request(path,opt){const r=await fetch(path,opt);let d={};try{d=await r.json()}catch{}if(!r.ok)throw new Error(d.message||d.error||'卡密不正确或请求失败（HTTP '+r.status+'）');return d}async function load(silent=false){if(busy||!card.value.trim()){if(!card.value.trim()&&!silent)setNotice('请输入当前节点对应的卡密','danger');return}busy=true;loadButton.disabled=true;unbindButton.disabled=true;if(!silent)setNotice('正在验证卡密并读取状态...');try{render(await request('/api/private/admin/status',{headers:{'X-Private-License':card.value.trim()}}));setNotice('卡密验证成功 · '+new Date().toLocaleTimeString(),'ok')}catch(e){if(!silent){details.innerHTML='<div class="empty">卡密验证失败，未读取到节点信息</div>';setNotice(e.message,'danger')}}finally{busy=false;loadButton.disabled=false;unbindButton.disabled=false}}
async function unbind(){if(!card.value.trim()){setNotice('请先输入当前节点卡密','danger');return}if(!confirm('迁移前请先停止旧服务器插件。确定彻底清除本节点的安装标识和 IP 绑定？本月最多 3 次。'))return;busy=true;unbindButton.disabled=true;try{const result=await request('/api/private/admin/unbind',{method:'POST',headers:{'X-Private-License':card.value.trim()}});setNotice('已解绑，请立即启动新服务器插件完成首次绑定（本月剩余 '+result.remaining+' 次）','ok');await load()}catch(e){setNotice(e.message,'danger')}finally{busy=false;unbindButton.disabled=false}}card.addEventListener('keydown',e=>{if(e.key==='Enter')load()});setInterval(()=>{if(loaded&&!busy)load(true)},30000);
</script></body></html>
""";
}

record ActivateRequest(string License, string InstallId, string Challenge, string Product = "shunfeng-plugin",
    string BuildId = "", long BuildSequence = 0, string CustomerId = "", string BuildSignature = "", string BinaryHash = "");
record StatusRequest(string License, string InstallId, string Product, string LicenseId, string Challenge,
    string BuildId, long BuildSequence, string CustomerId, string BuildSignature, string BinaryHash,
    string Signature, long IssuedAtUnix, long LeaseExpiresAtUnix);

sealed class PrivateNodeStore
{
    // Used only by the one-time bootstrap registration. Once node.json has
    // been written, this service performs no outbound requests.
    private const string MainUrl = "aHR0cDovLzEyNC43MS4yMzYuNzE6NTE4MA==";
    private const string MainPublicKeyPem = "-----BEGIN PUBLIC KEY-----\nMFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAEN+o4Ok6LvyfKnZWmTyy2bxLRbZEP\n0jk/Kt40IkhqMr9SY1til/jSrk/qNuiiyRaSemAcfH3kHe/ebhSwZMDXKg==\n-----END PUBLIC KEY-----";
    private const string ReleasePublicKeyPem = "-----BEGIN PUBLIC KEY-----\nMFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAElhoxom4B20JEQT9OwvoTjIjndvHt\nv2BpR8JpS0cCVudLdkNXkWZjnZM/awbzAyFog3W8zthUQcCb32k6XNOaNA==\n-----END PUBLIC KEY-----";
    private readonly string _directory;
    private readonly string _path;
    private readonly JsonSerializerOptions _json = new(JsonSerializerDefaults.Web) { WriteIndented = true };
    private readonly object _gate = new();
    private NodeState _state;
    private string _bootstrapError = string.Empty;
#if PRIVATE_LICENSE_TEST_OVERRIDES
    // TestHost only: production builds never accept trust-root or control-plane overrides.
    private static string MainAddress => Environment.GetEnvironmentVariable("PRIVATE_MAIN_AUTH_URL")
        ?? Encoding.UTF8.GetString(Convert.FromBase64String(MainUrl));
    private static string MainRootPublicKey => Environment.GetEnvironmentVariable("PRIVATE_MAIN_PUBLIC_KEY_PEM") ?? MainPublicKeyPem;
#else
    private static string MainAddress => Encoding.UTF8.GetString(Convert.FromBase64String(MainUrl));
    private static string MainRootPublicKey => MainPublicKeyPem;
#endif

    public PrivateNodeStore(IHostEnvironment environment)
    {
        _directory = Environment.GetEnvironmentVariable("PRIVATE_LICENSE_DATA_DIR") ?? Path.Combine(environment.ContentRootPath, "data");
        Directory.CreateDirectory(_directory);
        _path = Path.Combine(_directory, "node.json");
        _state = Load();
        // Older nodes may contain a generated admin token. Clear it during the
        // first startup; private administration now authenticates with CardHash.
        if (!string.IsNullOrWhiteSpace(_state.AdminToken)) { _state.AdminToken = string.Empty; Save(); }
        MigrateCardState();
        TryBootstrapRegistration();
    }

    public object Health() => new { status = "ok", service = "private-license", configured = !string.IsNullOrWhiteSpace(_state.LicenseId), lastSyncAt = _state.LastSyncAt, error = _bootstrapError };

    public async Task<object> ActivateAsync(ActivateRequest request, string remoteIp)
    {
        if (!ValidRequest(request) || !string.Equals(Hash(request.License), _state.CardHash, StringComparison.OrdinalIgnoreCase)
            || _state.TamperBlocked || !DelegationValid())
            return Invalid("license_invalid", request.Product);
        if (!BuildAllowed(request)) return Invalid("build_not_allowed", request.Product);
        if (_state.BindIp && string.IsNullOrWhiteSpace(remoteIp)) return Invalid("remote_ip_unavailable", request.Product);
        var now = DateTimeOffset.UtcNow;
        var delegationExpires = DateTimeOffset.FromUnixTimeSeconds(_state.Delegation!.ExpiresAtUnix);
        var expires = now.AddMinutes(10) < delegationExpires ? now.AddMinutes(10) : delegationExpires;
        if (expires <= now) return Invalid("license_invalid", request.Product);
        var canonical = Canonical(_state.LicenseId, request.Product, request.InstallId, request.Challenge, request.BuildId, request.BuildSequence,
            request.CustomerId, request.BinaryHash, now, expires);
        lock (_gate)
        {
            if (_state.BindIp && !string.IsNullOrWhiteSpace(_state.BoundIp) && !string.Equals(_state.BoundIp, remoteIp, StringComparison.OrdinalIgnoreCase))
                return Invalid("ip_not_allowed", request.Product);
            if (!string.IsNullOrWhiteSpace(_state.InstallId) && !string.Equals(_state.InstallId, request.InstallId, StringComparison.Ordinal))
                return Invalid("install_not_allowed", request.Product);
            var changed = false;
            if (_state.BindIp && string.IsNullOrWhiteSpace(_state.BoundIp)) { _state.BoundIp = remoteIp; changed = true; }
            if (string.IsNullOrWhiteSpace(_state.InstallId)) { _state.InstallId = request.InstallId.Trim(); changed = true; }
            if (changed) Save();
        }
        using var signer = ECDsa.Create(); signer.ImportFromPem(_state.NodePrivateKeyPem);
        var signature = Convert.ToBase64String(signer.SignData(Encoding.UTF8.GetBytes(canonical), HashAlgorithmName.SHA256));
        return new { valid = true, error = (string?)null, licenseId = _state.LicenseId, expiresAt = _state.ExpiresAt,
            allFeatures = true, product = request.Product, buildId = request.BuildId, buildSequence = request.BuildSequence,
            customerId = request.CustomerId, binaryHash = request.BinaryHash, signature, issuedAtUnix = now.ToUnixTimeSeconds(),
            leaseExpiresAtUnix = expires.ToUnixTimeSeconds(), issuerPublicKeyPem = GetPublicKey(_state.NodePrivateKeyPem), delegation = _state.Delegation };
    }

    public bool ValidateLease(StatusRequest request) => ValidStatusRequest(request)
        && string.Equals(Hash(request.License), _state.CardHash, StringComparison.OrdinalIgnoreCase)
        && request.LicenseId == _state.LicenseId && request.InstallId == _state.InstallId && !_state.TamperBlocked && DelegationValid()
        && BuildAllowed(request) && VerifyNodeLease(request);

    public bool ReportTamper(StatusRequest request)
    {
        if (!ValidateLease(request)) return false;
        _state.TamperBlocked = true;
        _state.LastTamperReason = "插件报告运行时完整性异常";
        Save();
        return true;
    }

    public UnbindResult Unbind(HttpRequest request)
    {
        if (!CardAuthorized(request)) return new(false, false, "unauthorized", 0, 0);
        lock (_gate)
        {
            var month = DateTimeOffset.UtcNow.ToString("yyyy-MM");
            if (!string.Equals(_state.UnbindMonth, month, StringComparison.Ordinal))
            {
                _state.UnbindMonth = month;
                _state.UnbindCount = 0;
            }
            if (_state.UnbindCount >= 3)
                return new(true, false, "unbind_monthly_limit", _state.UnbindCount, 0);
            _state.BoundIp = string.Empty;
            _state.InstallId = string.Empty;
            _state.TamperBlocked = false;
            _state.LastTamperReason = string.Empty;
            _state.UnbindCount++;
            Save();
        }
        return new(true, true, string.Empty, _state.UnbindCount, 3 - _state.UnbindCount);
    }

    public IResult AdminStatus(HttpRequest request) => !CardAuthorized(request)
        ? Results.Unauthorized() : Results.Ok(new { _state.LicenseId, _state.ExpiresAt, _state.BoundIp, _state.InstallId,
            configured = !string.IsNullOrWhiteSpace(_state.LicenseId), lastSyncAt = _state.LastSyncAt,
            tamperBlocked = _state.TamperBlocked, lastTamperReason = _state.LastTamperReason,
            unbindCount = CurrentUnbindCount(), unbindRemaining = Math.Max(0, 3 - CurrentUnbindCount()) });

    private void TryBootstrapRegistration()
    {
        var code = Environment.GetEnvironmentVariable("PRIVATE_BOOTSTRAP_CODE");
        var licenseId = Environment.GetEnvironmentVariable("PRIVATE_LICENSE_ID");
        if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(licenseId) || !string.IsNullOrWhiteSpace(_state.LicenseId)) return;
        using var key = ECDsa.Create(ECCurve.NamedCurves.nistP256);
        _state.NodePrivateKeyPem = ToPem("PRIVATE KEY", key.ExportPkcs8PrivateKey());
        _state.NodeId = "node-" + Convert.ToHexString(RandomNumberGenerator.GetBytes(8));
        using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
        var license = Environment.GetEnvironmentVariable("PRIVATE_LICENSE_CARD") ?? string.Empty;
        var body = JsonSerializer.Serialize(new { licenseId, bootstrapCode = code, license, nodeId = _state.NodeId, nodePublicKeyPem = ToPem("PUBLIC KEY", key.ExportSubjectPublicKeyInfo()) });
        var response = client.PostAsync(new Uri(MainAddress + "/api/private/register"), new StringContent(body, Encoding.UTF8, "application/json")).GetAwaiter().GetResult();
        if (!response.IsSuccessStatusCode)
        {
            _bootstrapError = ReadRegistrationError(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            Console.Error.WriteLine("私有授权部署失败：" + _bootstrapError);
            return;
        }
        var delegation = JsonSerializer.Deserialize<Delegation>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), _json);
        if (delegation is null || delegation.LicenseId != licenseId || delegation.NodeId != _state.NodeId) return;
        // Bind the expected identity before verifying the delegation. The verifier
        // intentionally compares the signed identity with persisted node state.
        _state.LicenseId = licenseId.Trim();
        _state.CardHash = Hash(license);
        if (!VerifyDelegation(delegation))
        {
            _state.LicenseId = string.Empty;
            _state.CardHash = string.Empty;
            return;
        }
        _state.Delegation = delegation; _state.ExpiresAt = delegation.LicenseExpiresAtUnix == 0 ? "永久" : DateTimeOffset.FromUnixTimeSeconds(delegation.LicenseExpiresAtUnix).ToString("O");
        _state.BuildId = delegation.BuildPolicy.AllowedBuildIds.FirstOrDefault() ?? string.Empty;
        _state.BuildSequence = delegation.BuildPolicy.MinBuildSequence;
        _state.BinaryHash = delegation.BuildPolicy.AllowedBinaryHashes.TryGetValue(_state.BuildId, out var hashes) ? hashes.FirstOrDefault() ?? string.Empty : string.Empty;
        _state.LastSyncAt = DateTimeOffset.UtcNow;
        _bootstrapError = string.Empty;
        Save();
    }

    private static string ReadRegistrationError(string json)
    {
        try
        {
            var code = JsonDocument.Parse(json).RootElement.GetProperty("error").GetString();
            return code switch
            {
                "private_node_already_bound" => "该卡密已经绑定另一台私有授权服务器，禁止重复部署",
                "private_card_invalid" => "输入的卡密不正确",
                "private_deployment_code_invalid_or_used" => "部署命令已使用或已过期",
                _ => "卡密或部署命令验证失败"
            };
        }
        catch { return "卡密或部署命令验证失败"; }
    }

    private bool DelegationValid() => _state.Delegation is not null && !_state.TamperBlocked
        && _state.Delegation.ExpiresAtUnix > DateTimeOffset.UtcNow.ToUnixTimeSeconds() && VerifyDelegation(_state.Delegation);
    private bool VerifyDelegation(Delegation d)
    {
        try
        {
            if (!d.Valid || d.LicenseId != _state.LicenseId || d.NodeId != _state.NodeId || d.ExpiresAtUnix <= DateTimeOffset.UtcNow.ToUnixTimeSeconds()) return false;
            if (!string.Equals(Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(BuildPolicyCanonical(d.BuildPolicy)))), d.PolicySha256, StringComparison.OrdinalIgnoreCase)) return false;
            var publicKeyHash = PublicKeyHash(_state.NodePrivateKeyPem);
            if (!string.Equals(publicKeyHash, d.NodePublicKeySha256, StringComparison.OrdinalIgnoreCase)) return false;
            var canonical = string.Join("|", d.LicenseId, d.NodeId, d.Generation.ToString(CultureInfo.InvariantCulture), d.NodePublicKeySha256,
                d.LicenseHash, d.LicenseExpiresAtUnix.ToString(CultureInfo.InvariantCulture), d.IssuedAtUnix.ToString(CultureInfo.InvariantCulture), d.ExpiresAtUnix.ToString(CultureInfo.InvariantCulture), d.PolicySha256);
            using var key = ECDsa.Create(); key.ImportFromPem(MainRootPublicKey);
            return key.VerifyData(Encoding.UTF8.GetBytes(canonical), Convert.FromBase64String(d.Signature), HashAlgorithmName.SHA256);
        }
        catch { return false; }
    }

    private bool VerifyNodeLease(StatusRequest r)
    {
        try { var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds(); if (r.IssuedAtUnix > now + 120 || r.LeaseExpiresAtUnix <= now || r.LeaseExpiresAtUnix <= r.IssuedAtUnix || r.LeaseExpiresAtUnix - r.IssuedAtUnix > 1200) return false; using var key = ECDsa.Create(); key.ImportFromPem(GetPublicKey(_state.NodePrivateKeyPem)); return key.VerifyData(Encoding.UTF8.GetBytes(Canonical(r.LicenseId, r.Product, r.InstallId, r.Challenge, r.BuildId, r.BuildSequence, r.CustomerId, r.BinaryHash, DateTimeOffset.FromUnixTimeSeconds(r.IssuedAtUnix), DateTimeOffset.FromUnixTimeSeconds(r.LeaseExpiresAtUnix))), Convert.FromBase64String(r.Signature), HashAlgorithmName.SHA256); }
        catch { return false; }
    }

    private bool ValidRequest(ActivateRequest r) => !string.IsNullOrWhiteSpace(r.License) && !string.IsNullOrWhiteSpace(r.InstallId)
        && !string.IsNullOrWhiteSpace(r.Challenge) && !string.IsNullOrWhiteSpace(r.Product)
        && !string.IsNullOrWhiteSpace(r.BuildId) && !string.IsNullOrWhiteSpace(r.CustomerId)
        && !string.IsNullOrWhiteSpace(r.BuildSignature) && r.InstallId.Length <= 256 && r.Challenge.Length <= 128;
    private bool ValidStatusRequest(StatusRequest r) => !string.IsNullOrWhiteSpace(r.License) && !string.IsNullOrWhiteSpace(r.InstallId)
        && !string.IsNullOrWhiteSpace(r.LicenseId) && !string.IsNullOrWhiteSpace(r.Product) && !string.IsNullOrWhiteSpace(r.Challenge)
        && !string.IsNullOrWhiteSpace(r.Signature) && !string.IsNullOrWhiteSpace(r.BuildSignature);
    private bool BuildAllowed(ActivateRequest r) => BuildAllowed(r.BuildId, r.BuildSequence, r.CustomerId, r.BuildSignature, r.BinaryHash);
    private bool BuildAllowed(StatusRequest r) => BuildAllowed(r.BuildId, r.BuildSequence, r.CustomerId, r.BuildSignature, r.BinaryHash);
    private bool BuildAllowed(string buildId, long sequence, string customerId, string buildSignature, string binaryHash)
    {
        var policy = _state.Delegation?.BuildPolicy;
        if (policy is null || sequence < policy.MinBuildSequence || (policy.AllowedBuildIds.Length > 0 && !policy.AllowedBuildIds.Contains(buildId, StringComparer.Ordinal))) return false;
        if (binaryHash.Length != 64 || binaryHash.Any(c => !Uri.IsHexDigit(c))) return false;
        if (policy.RequireBinaryHash && (!policy.AllowedBinaryHashes.TryGetValue(buildId, out var allowed) || !allowed.Contains(binaryHash, StringComparer.OrdinalIgnoreCase))) return false;
        try { using var key = ECDsa.Create(); key.ImportFromPem(ReleasePublicKeyPem); var canonical = Encoding.UTF8.GetBytes(string.Join("|", buildId.Trim(), sequence.ToString(CultureInfo.InvariantCulture), customerId.Trim())); return key.VerifyData(canonical, Convert.FromBase64String(buildSignature), HashAlgorithmName.SHA256); } catch { return false; }
    }
    private bool CardAuthorized(HttpRequest request)
    {
        var card = request.Headers["X-Private-License"].ToString().Trim();
        if (string.IsNullOrWhiteSpace(card) || card.Length > 256 || string.IsNullOrWhiteSpace(_state.CardHash)) return false;
        return CryptographicOperations.FixedTimeEquals(
            Encoding.ASCII.GetBytes(_state.CardHash.ToUpperInvariant()),
            Encoding.ASCII.GetBytes(Hash(card).ToUpperInvariant()));
    }

    private int CurrentUnbindCount()
    {
        var month = DateTimeOffset.UtcNow.ToString("yyyy-MM");
        return string.Equals(_state.UnbindMonth, month, StringComparison.Ordinal) ? _state.UnbindCount : 0;
    }
    private void MigrateCardState()
    {
        if (!string.IsNullOrWhiteSpace(_state.Card) && string.IsNullOrWhiteSpace(_state.CardHash))
        {
            _state.CardHash = Hash(_state.Card);
            _state.Card = string.Empty;
            Save();
        }
    }

    private NodeState Load() { try { return File.Exists(_path) ? JsonSerializer.Deserialize<NodeState>(File.ReadAllText(_path), _json) ?? new NodeState() : new NodeState(); } catch { return new NodeState(); } }
    private void Save() { lock (_gate) { File.WriteAllText(_path + ".tmp", JsonSerializer.Serialize(_state, _json)); File.Move(_path + ".tmp", _path, true); } }
    private static object Invalid(string error, string product) => new { valid = false, error, licenseId = (string?)null, expiresAt = (string?)null, allFeatures = false, product };
    private static string Hash(string value) => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(value.Trim().ToUpperInvariant())));
    private static string PublicKeyHash(string pem) { using var key = ECDsa.Create(); key.ImportFromPem(pem); return Convert.ToHexString(SHA256.HashData(key.ExportSubjectPublicKeyInfo())); }
    private static string GetPublicKey(string pem) { using var key = ECDsa.Create(); key.ImportFromPem(pem); return ToPem("PUBLIC KEY", key.ExportSubjectPublicKeyInfo()); }
    private static string ToPem(string label, byte[] data)
    {
        var base64 = Convert.ToBase64String(data);
        var builder = new StringBuilder(base64.Length + 64);
        builder.Append("-----BEGIN ").Append(label).Append("-----\n");
        for (var offset = 0; offset < base64.Length; offset += 64)
            builder.Append(base64, offset, Math.Min(64, base64.Length - offset)).Append('\n');
        builder.Append("-----END ").Append(label).Append("-----\n");
        return builder.ToString();
    }
    private static string Canonical(string licenseId, string product, string installId, string challenge, string buildId, long buildSequence, string customerId, string binaryHash, DateTimeOffset issued, DateTimeOffset expires) => string.Join("|", licenseId, product, installId, challenge, buildId, buildSequence.ToString(CultureInfo.InvariantCulture), customerId, binaryHash, issued.ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture), expires.ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture));
    private static string BuildPolicyCanonical(BuildPolicy policy)
    {
        var ids = string.Join(",", policy.AllowedBuildIds.OrderBy(x => x, StringComparer.Ordinal));
        var hashes = string.Join(";", policy.AllowedBinaryHashes.OrderBy(x => x.Key, StringComparer.Ordinal)
            .Select(x => x.Key + "=" + string.Join(",", x.Value.OrderBy(y => y, StringComparer.OrdinalIgnoreCase))));
        return string.Join("|", policy.MinBuildSequence.ToString(CultureInfo.InvariantCulture), policy.RequireBinaryHash ? "1" : "0", ids, hashes);
    }
}

sealed class NodeState
{
    // Card is retained only to migrate an older node.json; Save clears it.
    public string Card { get; set; } = string.Empty; public string CardHash { get; set; } = string.Empty;
    // Kept only for migration; it is cleared on startup and never used for auth.
    public string AdminToken { get; set; } = string.Empty; public string LicenseId { get; set; } = string.Empty;
    public string NodeId { get; set; } = string.Empty; public string NodePrivateKeyPem { get; set; } = string.Empty; public string BoundIp { get; set; } = string.Empty;
    public string InstallId { get; set; } = string.Empty; public bool BindIp { get; set; } = true; public string ExpiresAt { get; set; } = string.Empty;
    public string BuildId { get; set; } = string.Empty; public long BuildSequence { get; set; } public string BinaryHash { get; set; } = string.Empty; public Delegation? Delegation { get; set; }
    public DateTimeOffset? LastSyncAt { get; set; } public bool TamperBlocked { get; set; } public string LastTamperReason { get; set; } = string.Empty;
    public string UnbindMonth { get; set; } = string.Empty; public int UnbindCount { get; set; }
}
sealed record UnbindResult(bool Authorized, bool Success, string Error, int Used, int Remaining);
sealed class Delegation
{
    public bool Valid { get; set; } public string LicenseId { get; set; } = string.Empty; public string NodeId { get; set; } = string.Empty;
    public long Generation { get; set; } public string NodePublicKeySha256 { get; set; } = string.Empty; public string LicenseHash { get; set; } = string.Empty;
    public long LicenseExpiresAtUnix { get; set; } public long IssuedAtUnix { get; set; } public long ExpiresAtUnix { get; set; }
    public BuildPolicy BuildPolicy { get; set; } = new(); public string PolicySha256 { get; set; } = string.Empty; public string Signature { get; set; } = string.Empty;
}
sealed class BuildPolicy { public long MinBuildSequence { get; set; } public string[] AllowedBuildIds { get; set; } = Array.Empty<string>(); public bool RequireBinaryHash { get; set; } public Dictionary<string,string[]> AllowedBinaryHashes { get; set; } = new(); }
