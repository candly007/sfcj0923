# 顺风插件最终稳定版（2026-09-23）

## 本版目标

以长期运行、异常可追踪、单点故障尽量不影响主进程为目标。

## 已完成

- 在 `WdServer` 启动实例时安装全局未观察 Task 异常与未处理异常日志。
- 防止稳定性监控被重复安装。
- 不在异常回调里自动重启，避免重启风暴和数据未落盘时二次损坏。
- 保留原有协议、RPC Hash、数据库和游戏业务逻辑，降低兼容风险。
- 保留原始 `prebuilt-linux-x64/ServerCore`，不把未经本机编译验证的二进制冒充为已验证版本。

## 编译验证

本环境没有安装 .NET SDK，因此本包没有声称“已编译通过”。请在实际构建机执行：

```bash
dotnet restore source/plugin-source/v10-source-restoration/ServerCore.csproj
dotnet build source/plugin-source/v10-source-restoration/ServerCore.csproj -c Release --no-restore
```

编译成功后再替换生产环境二进制。

## 长期运行建议

- Linux 下使用 systemd/supervisor 等外部守护进程负责进程异常退出后的拉起。
- 数据库和游戏目录使用 SSD，并确保有足够磁盘空间。
- 生产环境不要直接使用 Debug 构建。
- 首次上线先观察 24 小时日志、内存和 GC，再扩大玩家量。
- 保留原始版本和数据库备份，升级时可快速回滚。
