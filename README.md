# 顺风插件可编译源码

这是面向客户交付的可编译源码包。它包含源码、项目文件、适配资源、第三方
编译引用、配置模板、部署脚本和接口文档，但不包含本项目已经生成的运行程序。

## 已包含

- `source/plugin-source`：Linux `ServerCore` 插件及共用模型源码；
- `source/admin-source`：Windows 管理后台源码，以及项目本身引用的资源和 DLL；
- `source/license-service`、`source/private-license-service`：主授权和私有授权源码；
- `license-gateway`：每月换绑策略网关源码；
- `third-party`：项目 `HintPath` 所需的第三方编译引用；
- `prebuilt-linux-x64/ServerCore`：由本包源码发布验证生成的 Linux x64 运行文件；
- `docs`、`scripts`：接口资料、配置模板、构建和部署脚本。

管理后台的 `NetClientFrom.Resources.*.o` 为项目明确引用的适配资源，必须保留。
它们不是管理后台的最终编译输出。`prebuilt-linux-x64/ServerCore` 是附带的
运行示例，而非编译依赖；删除它不影响从 `ServerCore.csproj` 重新构建。

## 已排除

- Windows 管理后台、授权服务可执行文件和 `release` 目录；
- `bin`、`obj`、运行日志、数据库、缓存和历史构建结果；
- 卡密、管理员令牌、生产数据库、私钥、服务器密码和生产运行配置。

## 构建

需要 .NET SDK 6.0 或更新版本。已在 .NET SDK 10.0.401 上验证过 `Release`
构建。可直接在本目录执行：

```powershell
dotnet build .\source\plugin-source\v10-source-restoration\ServerCore.csproj -c Release
dotnet build .\source\admin-source\current\顺风插件管理后台.csproj -c Release
dotnet build .\source\license-service\LicenseService.csproj -c Release
dotnet build .\source\private-license-service\PrivateLicenseService.csproj -c Release
```

需要生成单文件发布物时，执行：

```powershell
powershell -ExecutionPolicy Bypass -File .\scripts\build-release.ps1 -SkipObfuscation
```

`build-release.ps1` 默认会使用 Obfuscar 进行发布前混淆；需要混淆发布时，先在
构建机安装 `obfuscar.console.exe`，然后省略 `-SkipObfuscation`。

## Windows 运行

本版本已加入 Windows 专项稳定性处理，详见 `WINDOWS-FINAL-STABILITY.md`。使用 Windows 长期挂机时，建议管理员运行 `ServerCore.exe`，并配置进程级自动拉起。
