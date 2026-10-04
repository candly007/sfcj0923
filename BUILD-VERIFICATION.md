# 构建验证记录

验证日期：2026-09-17

已从本交付包的独立副本中以默认 `Release` 配置完成下列构建，均为 0 错误：

- `source/plugin-source/v10-source-restoration/ServerCore.csproj`
- `source/admin-source/current/顺风插件管理后台.csproj`
- `source/license-service/LicenseService.csproj`
- `source/private-license-service/PrivateLicenseService.csproj`

构建使用 .NET SDK 10.0.401。现有警告包括 net6.0 生命周期、可空引用注释和
既有程序集版本提示；没有构建错误。

验证构建只在交付目录外的临时副本中进行。本包没有 `bin`、`obj` 或本项目的
最终发布程序。

此外，`scripts/build-release.ps1 -SkipObfuscation` 已在独立副本中执行成功，
并生成 Linux `ServerCore`、Windows 管理后台、主授权服务及私有授权服务四个
最终运行文件。其中 Linux `ServerCore` 已按交付要求纳入
`prebuilt-linux-x64/ServerCore`：

`35545B4AEFA7E85371383007CC67780BE25BC584ADD249AA8BBCA61D41A2264A`

其余验证产物未纳入本源码交付包。
