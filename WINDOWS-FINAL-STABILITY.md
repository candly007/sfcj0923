# Windows 最终稳定版说明

## 运行环境

- Windows 10 / Windows 11 64 位
- .NET 6 x64 Runtime（源码编译需要 .NET 6 SDK）
- 建议以“管理员身份”运行 ServerCore.exe

## Windows 专项改动

1. Linux `iptables` 防火墙调用在 Windows 下不执行，改为 `netsh advfirewall` 创建持久化 TCP 入站放行规则。
2. 数据库 3306 的后台放行规则使用来源 IPv4 限制。
3. 玩家端口 18101、18160-18163 使用 Windows 防火墙持久化放行。
4. 关闭插件时 Windows 只终止当前 ServerCore 进程，避免误杀其他同名进程。
5. 重启插件时生成临时 `.cmd` 延迟 2 秒启动当前 ServerCore.exe，再退出当前进程，降低端口/文件锁冲突概率。
6. Windows 下不会把 Linux `iptables` 字符串转交给 `cmd.exe`，避免跨平台误执行和命令注入风险。
7. 防 CC 白名单在 Windows 下转换为按来源 IP 的插件端口放行规则；Windows 防火墙本身不直接等价于原 Linux 规则的连接数限制。

## 建议部署方式

将编译后的 `ServerCore.exe` 放到独立目录，例如：

`D:\ShunFeng\ServerCore\`

数据库、配置文件和日志尽量放在同一个数据目录，避免程序目录权限不足导致日志或配置写入失败。

首次启动时右键 `ServerCore.exe` → “以管理员身份运行”。

## 长期挂机

建议再配合 Windows 任务计划程序或 NSSM / WinSW 这类进程守护工具，在 ServerCore 真正退出时自动拉起。

源码中的自动重启用于“后台重启插件”操作；进程级崩溃恢复仍建议交给外部守护程序负责。

## 编译

在 Windows 构建机安装 .NET 6 SDK 后执行：

```powershell
cd source\plugin-source\v10-source-restoration
dotnet restore
dotnet build -c Release
```

最终产物通常位于：

`bin\Release\net6.0\ServerCore.exe`

> 本源码包已完成 Windows 兼容性代码调整，但当前制作环境没有安装 .NET SDK，因此本包没有声称“已在此环境编译通过”。
