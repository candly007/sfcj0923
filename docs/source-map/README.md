# 顺风源码地图

本目录是当前生产源码的长期检索入口。以后修改功能时先查这里，不需要重新通读全部源码。

机器可读的唯一生产基线记录在 `baseline.json`。后续维护先读取该文件，再查询 `generated` 下的索引。

## 扫描范围

| 项目 | 路径 | 文件 | 代码行 | 用途 |
| --- | --- | ---: | ---: | --- |
| 插件核心 | `plugin-source/v10-source-restoration` | 186 | 115,246 | 服务启动、TCP 代理、封包处理、数据库、玩法实现、后台 RPC |
| 共享模型 | `plugin-source/v10-source-restoration-lk` | 178 | 12,243 | 枚举、协议号、配置模型、存档模型、封包读写工具 |
| 管理后台 | `admin-source/current` | 90 | 66,786 | WinForms 管理界面、配置编辑、玩家管理、RPC 客户端 |

扫描排除了 `bin`、`obj`、`publish*`、`td-admin-bin`、Designer 生成文件和历史分支。

## 快速查询

```powershell
# 查方法定义、参数、文件和行号
powershell -ExecutionPolicy Bypass -File .\scripts\find-source-api.ps1 -Query '发送角色属性道具' -Index Symbols

# 查后台 RPC 协议
powershell -ExecutionPolicy Bypass -File .\scripts\find-source-api.ps1 -Query '10023' -Index Rpc

# 查游戏封包及分发入口
powershell -ExecutionPolicy Bypass -File .\scripts\find-source-api.ps1 -Query '请求_穿戴装备' -Index All

# 查配置字段
powershell -ExecutionPolicy Bypass -File .\scripts\find-source-api.ps1 -Query '元神系统配置' -Index Config

# 查数据库调用位置
powershell -ExecutionPolicy Bypass -File .\scripts\find-source-api.ps1 -Query 'ExecuteNonQuery' -Index Database

# 只查后台工程
powershell -ExecutionPolicy Bypass -File .\scripts\find-source-api.ps1 -Query '保存按钮' -Project admin
```

修改源码后重新生成：

```powershell
powershell -ExecutionPolicy Bypass -File .\scripts\generate-source-map.ps1
```

## 索引说明

| 文件 | 内容 |
| --- | --- |
| `generated/summary.json` | 扫描时间、项目文件数、代码行和索引计数 |
| `generated/files.csv` | 每个源码文件的行数、字节数和 SHA-256 |
| `generated/types.csv` | 类、结构体、接口、枚举、基类和定义位置 |
| `generated/symbols.csv` | 方法、构造器、字段、属性、事件、完整参数和定义位置 |
| `generated/enum-members.csv` | 枚举成员、源码表达式和可计算的实际数值 |
| `generated/constants.csv` | 常量名称、类型和值，包含 `MyCmd` 协议号 |
| `generated/rpc-catalog.md` | 后台 RPC 编号、名称、处理方法和调用方总表 |
| `generated/rpc-methods.csv` | 带 `[Rpc]` 特性的服务端/客户端回调及参数 |
| `generated/rpc-calls.csv` | 所有 `SendRT/SendRTAsync` 调用、参数和调用位置 |
| `generated/config-protocol.md` | 配置类型编号、后台读取按钮和保存按钮目录 |
| `generated/switch-dispatch.csv` | `switch/case` 标签到调用方法的分发表，主要用于游戏封包定位 |
| `generated/config-fields.csv` | 所有配置类字段、属性、类型和默认值 |
| `generated/admin-forms.md` | 后台窗口和事件数量目录 |
| `generated/event-handlers.csv` | 后台按钮、表格、选择框、定时器等事件方法 |
| `generated/database-calls.csv` | MySQL 对象创建及 Open/Execute/Fill 等数据库调用 |
| `generated/sql-literals.csv` | 未混淆的 SQL 字面量；当前主工程 SQL 多为运行时解码 |
| `generated/network-endpoints.csv` | 监听、连接、URL/IP 字面量和网络启动调用 |

## 重要边界

- 当前工程已能从 C# 源码修改、验证和编译，不需要二进制补丁或 DLL 注入。
- `ServerCoreLK` 已恢复为源码工程引用；`GameDesignerCore`、`TouchSocket`、`UnityEngine`、`MySql.Data` 等属于第三方/游戏基础库依赖。
- 部分类型和方法仍保留混淆名称。查不到语义名时，先查协议号、枚举名、配置类型或调用方，再沿文件行号进入目标方法。
- SQL 文本大量经过 `judJYnV3FMAuThkWmES.Mj5kBE08P4(...)` 运行时解码；因此数据库修改应先查 `database-calls.csv` 和 `DB.cs`，不能只依赖 SQL 字面量搜索。

## 架构文档

- [插件架构](plugin-architecture.md)
- [后台架构](admin-architecture.md)
- [功能修改手册](change-playbook.md)
- [RPC 协议目录](generated/rpc-catalog.md)
- [配置协议目录](generated/config-protocol.md)
- [后台窗口目录](generated/admin-forms.md)
