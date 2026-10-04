# 功能修改与新增手册

## 第一步：查索引，不全库重扫

| 修改目标 | 首先查询 | 然后进入 |
| --- | --- | --- |
| 某个方法/API 参数 | `Symbols` | `symbols.csv` 返回的文件和行号 |
| 后台协议号 | `Rpc`、`Constants` | `rpc-catalog.md`、`MyCmd.cs`、`WdServer.cs` |
| 游戏请求包头 | `Enums`、`Dispatch` | `AllEnums.cs`、`请求数据响应处理类.cs` |
| 游戏返回包头 | `Enums`、`Dispatch` | `AllEnums.cs`、`接收数据响应处理类.cs` |
| 配置字段或默认值 | `Config` | 共享模型配置类、插件全局变量、后台窗口 |
| 后台按钮 | `Events` | 对应窗口事件，不先扫主窗体全部代码 |
| 数据库读写 | `Database` | `DB.cs` 或返回的具体业务类 |
| 网络端口/连接 | `Network` | `MainService`、`MyHPServer`、后台连接方法 |

通用命令：

```powershell
powershell -ExecutionPolicy Bypass -File .\scripts\find-source-api.ps1 -Query '<关键词>' -Index All
```

## 常见功能路径

### 新增一个后台可配置玩法

1. 在 `plugin-source/v10-source-restoration-lk` 新增或扩展配置模型。
2. 在 `AllEnums.后台通信类型` 分配唯一配置编号。
3. 在插件 `全局变量类` 持有配置实例并加入初始化/落盘流程。
4. 在 `WdServer` 的 `10017` 分支返回 JSON。
5. 在 `WdServer` 的 `10018` 分支反序列化、替换运行时配置并保存。
6. 在后台创建或扩展窗口，完成加载、绑定、编辑提交和保存。
7. 查询 `rpc-calls.csv` 确认后台发送的编号和参数一致。

### 新增一个游戏封包功能

1. 查询 `enum-members.csv` 确认请求或接收包头编号。
2. 查询 `switch-dispatch.csv` 找到现有分发段和调用方法。
3. 在请求方向决定：阻止、改写、追加封包或原样转发。
4. 在接收方向决定：更新角色缓存、改写响应或追加客户端显示。
5. 使用 `封包_读/封包_写/ByteAPI/WdAPI`，不要手写未经验证的偏移算法。
6. 添加真实封包样本测试和匹配的负向测试。

### 新增奖励或掉落

优先复用：

```csharp
MainService.发送角色属性道具(
    MyNATSocketClient myclient,
    AllEnums.数值Type 发送类型,
    int 发送数量 = 1,
    string 道具名字 = "",
    string 提示文本 = "")
```

`AllEnums.数值Type` 支持等级、道行、经验、声望、战绩、金/银元宝、金钱、累充点、道具、体力、南极点、宠物、坐骑、奇宝点、灵气值、点卡点数、论道点和潜能。

### 新增后台 RPC

必须同时完成：

1. `MyCmd.cs` 增加唯一请求/返回编号。
2. 插件 `WdServer` 增加 `[Rpc(cmd = 2, hash = 编号)]` 方法，首个参数通常为 `Player`。
3. 后台使用 `SendRT(编号, 参数...)`。
4. 需要返回时，在后台窗口增加对应 `[Rpc(hash = 返回编号)]` 方法。
5. 重新生成源码地图，确认 `rpc-catalog.md` 同时显示处理方和调用方。

### 修改数据库功能

1. 查询目标业务词和 `Database` 索引。
2. 核对 `MainConfig` 中 `Mysql账号/Mysql端口/Mysql密码/adb表/ddb表`。
3. 核对实际表字段、是否允许 NULL、默认值和字段顺序。
4. 修改读取和写入两条路径，避免只改 INSERT 不改 SELECT。
5. 在测试库验证连接、读取、写入、重启后重载和旧数据兼容。

## 每次修改后的固定流程

```powershell
# 1. 更新源码索引
powershell -ExecutionPolicy Bypass -File .\scripts\generate-source-map.ps1

# 2. 运行生产源码回归
powershell -ExecutionPolicy Bypass -File .\scripts\verify-v10-source-restoration.ps1

# 3. 生成定向混淆、构建签名和防回滚保护版
powershell -ExecutionPolicy Bypass -File .\scripts\publish-protected.ps1
```

上传服务器仍需单独指令。发布前必须核对本地 SHA-256、单文件数量、启动日志、`43210/1234` 监听和玩家线路行为；分发插件前还必须把授权服务产物中的 `build-policy.template.json` 通过 `/api/admin/build-policy` 激活。

## 禁止回退的做法

- 不直接修改服务器上的 `ServerCore` 二进制。
- 不使用 DLL 注入替代源码实现。
- 不从 `current-v11-timed-dungeon` 或旧反编译目录直接发布。
- 不凭混淆方法名猜功能；必须以调用方、协议号、参数和真实行为交叉确认。
- 不把后台“启动服务”“放开端口”“续费卡密”复用为同一个协议。
