# 顺风授权服务

这是一个不区分功能套餐的独立授权 API。授权成功返回 `allFeatures=true`，插件随后启用全部功能。新生成卡密的校验值使用 SHA-256 落盘，卡密本身使用服务端专用 AES-GCM 密钥加密落盘，因此管理员列表可以回显卡密而不把明文写入数据文件。

## 本机运行

首次部署时在授权服务器本机生成一次 P-256 密钥对；私钥只保留在授权服务器，公钥需要重新编译进插件：

```powershell
$e = [System.Security.Cryptography.ECDsa]::Create()
$e.GenerateKey([System.Security.Cryptography.ECCurve]::CreateFromFriendlyName('nistP256'))
$e.ExportPkcs8PrivateKeyPem() | Set-Content C:\ProgramData\ShunfengLicense\signing-private-key.pem -NoNewline
$e.ExportSubjectPublicKeyInfoPem() | Set-Content C:\ProgramData\ShunfengLicense\signing-public-key.pem -NoNewline
```

```powershell
# 固定令牌由部署环境注入；不要写入插件、后台、网页默认值或 Git
$env:LICENSE_ADMIN_TOKEN = "<固定管理员令牌>"
$env:LICENSE_DATA_DIR = "C:\ProgramData\ShunfengLicense"
$env:LICENSE_SIGNING_PRIVATE_KEY_PEM_FILE = "C:\ProgramData\ShunfengLicense\signing-private-key.pem"
# 生成一次后持久保存。它用于管理员列表回显新生成的卡密，不得写入插件或后台。
$env:LICENSE_CARD_ENCRYPTION_KEY = [Convert]::ToBase64String([Security.Cryptography.RandomNumberGenerator]::GetBytes(32))
# 可选：限制管理接口来源，多个地址用逗号分隔
$env:LICENSE_ADMIN_IPS = "203.0.113.10"
# 也支持明确的 IPv4 前缀规则，例如 182.113.*（等价于 182.113.0.0/16）
dotnet run -c Release --project .\LicenseService.csproj -- --urls http://0.0.0.0:5180
```

不需要域名。普通插件配置中的“授权服务器地址”可以留空，使用内置主授权地址；私有化插件只填写“私有授权地址”，该地址优先使用。私有节点首次部署时通过一次性部署码从主授权取得签名委托和发布策略，并将其写入本地 `node.json`；登记成功后，激活、验证、心跳和解绑全部在私有节点本地完成，不再请求主授权，因此主授权暂时不可用不会影响客户运行。私有节点的委托有效期与卡密有效期一致（永久卡密为永久），每次插件激活仍签发 10 分钟本地短租约。主授权关闭、删除或吊销卡密不会主动触达已经完成登记的私有节点；需要停止私有节点时应在节点后台停止服务或清理本地授权状态。`LICENSE_SIGNING_PRIVATE_KEY_PEM` 与 `LICENSE_CARD_ENCRYPTION_KEY` 都只能保存在授权服务器，不能放进插件或后台；插件内只包含签名公钥。管理接口还带有每个来源地址每分钟 120 次的限速。签名密钥轮换时先让旧公钥和新公钥同时受支持，再发布新插件，避免在线玩家同时失效。

主授权后台的“解绑并重新部署”是迁移专用操作：它在管理员确认后退役旧私有节点身份和私有节点显示 IP，作废旧部署码并生成新的十分钟一次性部署码；不会清除插件服务器的 `AllowedIps`、`BoundIps` 或卡密本身。执行前必须先停止旧私有节点服务，因为旧节点在主授权不可达时仍可依据已有委托离线运行；该操作会阻止旧节点重新恢复登记，但不会远程执行停止、删文件或删数据库。

插件只把高置信度的托管调试信号（真实 .NET 调试器附加或 `Debugger.IsLogging()`）作为篡改事件。检测到后会先停止游戏线路，再使用刚刚验证过的租约签名调用 `/api/license/tamper`；服务端只有在卡密、安装标识、绑定 IP、挑战值、租约时间和服务端签名全部匹配时才将卡密吊销。该接口不接受管理员令牌，也不提供删除客户服务器文件或数据库的能力。伪造签名、过期租约、错误 IP 和重复上报都会被拒绝。该机制不能可靠证明“二进制已经被修改但篡改代码也被一并移除”的情况；拥有客户主机管理员/root 权限的人可以替换整个程序，这属于主机控制边界，必须结合文件权限、最小权限运行和服务器审计处理。

保护版发布使用 `scripts/publish-protected.ps1`。脚本对授权核心做定向混淆，生成带签名的单调构建序号，并在授权服务产物目录生成 `build-policy.template.json`。发布插件前必须通过管理 API 激活该模板；它要求当前构建 ID、最低构建序号和最终 Linux 单文件的准确 SHA-256，旧版本、伪造构建身份和非白名单二进制都不会获得租约。发布签名私钥位于仓库外的受限目录，不能复制到源码、插件、授权服务产物或混淆映射中。

同一发布脚本还会生成 `artifacts/private-license-service-current/PrivateLicenseService`。主授权生产环境通过 `LICENSE_PRIVATE_BINARY_PATH` 指向该固定单文件，并用 `LICENSE_PRIVATE_BINARY_VERSION` 指定发布版本。`/private-install.sh` 提供一条命令安装器；`/api/private/bootstrap/manifest` 和 `/api/private/bootstrap/download` 只接受对应卡密 ID 的未使用、未过期部署码。清单由主授权签名，安装器会重建签名载荷、检查有效期并校验下载文件 SHA-256，节点登记成功后部署码立即失效。

## 管理接口

所有管理接口都需要请求头 `X-Admin-Token`。本项目支持使用固定令牌（部署时将 `LICENSE_ADMIN_TOKEN` 设置为指定值），但固定令牌一旦泄露就等价于完整管理权限；生产环境应同时设置 `LICENSE_ADMIN_IPS`，并通过 HTTPS 或内网反向代理访问。

```powershell
$h = @{ 'X-Admin-Token' = $env:LICENSE_ADMIN_TOKEN }
# 生成永久卡（Days=0），不区分功能
Invoke-RestMethod http://服务器IP:5180/api/admin/licenses -Method Post -Headers $h `
  -ContentType 'application/json' -Body '{"count":1,"days":0,"maxActivations":1}'
# 查询、吊销、恢复、重置激活绑定
Invoke-RestMethod http://服务器IP:5180/api/admin/licenses -Headers $h
Invoke-RestMethod http://服务器IP:5180/api/admin/licenses/<id>/revoke -Method Post -Headers $h
# 删除卡密（从 licenses.json 物理移除；在线插件下一次租约检查会自动停线，不能恢复）
Invoke-RestMethod http://服务器IP:5180/api/admin/licenses/<id> -Method Delete -Headers $h
Invoke-RestMethod http://服务器IP:5180/api/admin/licenses/<id>/restore -Method Post -Headers $h
Invoke-RestMethod http://服务器IP:5180/api/admin/licenses/<id>/reset -Method Post -Headers $h
# 彻底解绑并恢复初始状态：清除安装标识、已绑定 IP 和允许列表
Invoke-RestMethod http://服务器IP:5180/api/admin/licenses/<id>/unbind -Method Post -Headers $h `
  -ContentType 'application/json' -Body '{"clearAllowedIps":true}'
# 设置允许 IP、绑定开关；clearBindings=true 会清除现有安装/IP绑定
Invoke-RestMethod http://服务器IP:5180/api/admin/licenses/<id>/ips -Method Post -Headers $h `
  -ContentType 'application/json' -Body '{"ips":["203.0.113.10"],"bindIp":true,"clearBindings":true}'
# 删除单个允许/已绑定 IP
Invoke-RestMethod http://服务器IP:5180/api/admin/licenses/<id>/ips/remove -Method Post -Headers $h `
  -ContentType 'application/json' -Body '{"ip":"203.0.113.10"}'
# 修改有效期（0=永久）、最大激活数和绑定开关
Invoke-RestMethod http://服务器IP:5180/api/admin/licenses/<id>/settings -Method Post -Headers $h `
  -ContentType 'application/json' -Body '{"days":0,"maxActivations":2,"bindIp":true}'
# 解绑当前私有节点并生成新的十分钟一次性部署码（先停止旧私有节点）
Invoke-RestMethod http://服务器IP:5180/api/admin/licenses/<id>/private/reset -Method Post -Headers $h
# 激活本次保护版发布生成的构建准入策略；分发插件前必须完成
$policy = Get-Content ..\artifacts\license-service-protected-current\build-policy.template.json -Raw
Invoke-RestMethod http://服务器IP:5180/api/admin/build-policy -Method Put -Headers $h `
  -ContentType 'application/json' -Body $policy
# 查询当前已生效策略
Invoke-RestMethod http://服务器IP:5180/api/admin/build-policy -Headers $h
```

### 详情、续期与运行状态

管理后台使用以下接口：

```powershell
# 查看卡密完整详情（包含最后心跳、CPU/内存/系统信息和插件主配置类.json 原文）
Invoke-RestMethod http://服务器IP:5180/api/admin/licenses/<id>/details -Headers $h
# 在原到期时间基础上续期；永久卡不需要续期
Invoke-RestMethod http://服务器IP:5180/api/admin/licenses/<id>/extend -Method Post -Headers $h `
  -ContentType 'application/json' -Body '{"days":30}'
```

插件通过 `/api/license/status` 上报运行状态。配置正文最大 5 MB；正文只在首次上报或 SHA-256 变化时发送，未变化时仅发送元数据。心跳由独立后台任务每 5 分钟执行一次，状态上报失败不会中断玩家封包或游戏线路。

构建准入的 `allowedBinaryHashes` 是“构建 ID到 SHA-256 数组”的映射，因此可以同时允许多个构建和同一构建的多个发布文件。网页编辑格式为每行一个规则：

```text
build-a=SHA256_A,SHA256_B
build-b=SHA256_C
```

每个构建最多 32 个 64 位十六进制 SHA-256；服务端会在保存时规范化为大写并去重。

`maxActivations` 控制安装标识数量，不是功能数量。插件只发送卡密、随机安装 ID 和产品名，不发送 QQ、游戏 IP、数据库配置、玩家信息或日志。授权服务不可用时，插件允许已成功验证的本地缓存宽限 **10 分钟**；后台每个非握手按钮 RPC 在分发前都会检查同一租约，租约失效会拒绝操作并关闭插件。吊销、删除或到期后，下一次在线验证会拒绝启动。删除会从 `licenses.json` 物理移除整条卡密记录，服务端不保留可恢复墓碑。

新卡密默认 `bindIp=true`。服务端按 TCP 请求来源地址处理 IP 绑定：预设 `allowedIps` 非空时只接受列表内地址；留空时，首次成功启动插件的来源 IP 会写入允许列表，之后任何其他服务器 IP 都会被拒绝。该限制独立于 `maxActivations`，即使将最大激活数调大，也不会允许第二个 IP 启动。反向代理部署必须正确传递并校验真实来源地址，否则会把代理地址当成绑定地址。`unbind` 是彻底解绑操作，会清除安装标识、绑定集合和允许 IP，恢复到从未激活的初始状态；下一次成功激活会自动把来源 IP 写入允许列表。`reset` 仅重置安装标识和绑定集合，不清除预设允许 IP；`ips` 可选择是否清除绑定后再换允许列表。

历史记录在本次改造前只保存了 SHA-256 卡密校验值，原卡密不具备可逆性，列表会显示“旧版卡密不可恢复”。不要更换或丢失 `LICENSE_CARD_ENCRYPTION_KEY`：否则新卡密仍可正常校验和使用，但管理员列表不能回显旧密文。密钥需要与数据目录一起做受控备份；需要轮换时，应先在维护窗口解密并用新密钥重新加密所有记录。

## 管理网页与异常日志

管理网页现在使用左侧分类导航，包含“卡密管理”“构建准入”和“异常日志”三个视图，原有卡密生成、IP、吊销、恢复、删除和构建策略接口保持不变。异常日志由服务端独立写入 `LICENSE_DATA_DIR/anomaly-events.json`，最多保留最近 10,000 条事件，不与 `licenses.json` 混写。

只读接口为 `GET /api/admin/anomalies?limit=1000`，仍要求 `X-Admin-Token` 和管理来源 IP。事件包括：`automatic-tamper-revoke`（有效租约验证通过后的篡改自动封禁）、`automatic-expiry`（到期后首次激活请求触发）、`manual-revoke`、`manual-restore`、`manual-delete` 和其他管理员状态变更。每条记录包含卡密、UTC 时间、原因、来源 IP、安装标识和构建信息；删除卡密后，历史事件仍可在日志中查询，但不会保留可恢复卡密记录。

## 生产加固边界

- 管理接口不要直接暴露公网；至少使用 `LICENSE_ADMIN_IPS`、云安全组和 HTTPS。
- 签名私钥只放授权服务器，权限设为仅服务用户可读；插件只内置公钥。
- 卡密加密密钥与签名私钥分离保存，权限同样仅服务用户可读，并与 `licenses.json` 一起备份。
- 授权服务数据目录和日志禁止 `777`，并纳入备份与审计。
- 固定管理员令牌便于运维但不提供轮换能力；泄露后应立即更换环境变量并重启授权服务。
- 客户端授权仍可被拥有客户端主机管理员权限的人修改或调试，服务端签名、短租约和限速只能提高绕过成本，不能承诺绝对不可破解。

## 构建产物

```powershell
dotnet publish .\LicenseService.csproj -c Release -r win-x64 --self-contained true `
  -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true `
  -o ..\artifacts\license-service-win-x64
# Linux 服务器使用对应 RID；先在独立目录启动 smoke test
dotnet publish .\LicenseService.csproj -c Release -r linux-x64 --self-contained true `
  -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true `
  -o ..\artifacts\license-service-linux-x64
```

上线前先在独立目录启动并调用 `/health`、生成/激活/吊销接口；本次工作未上传、未替换线上插件或停止线上服务。
