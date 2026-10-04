# 顺风授权验证网关

这是部署在主授权服务前面的 HTTP 网关源码。网关对外监听 `5180`，
原授权核心仅监听 `127.0.0.1:5181`。它保留核心服务的签名、有效期、
构建准入、吊销和私有节点能力，并增加：

- 按真实来源 IP 执行绑定策略；
- 每月换绑次数限制，`0` 表示不限次数；
- 同一安装标识重复激活不消耗换绑次数；
- 换绑策略原子写入 `rebind-policy.json`；
- 兼容现有顺风授权管理后台 API。

## 文件说明

- `license_gateway.py`：网关主程序，兼容 Python 3.6；
- `index.html`：顺风授权管理后台页面；
- `shunfeng-license-core.service`：授权核心 systemd 服务；
- `shunfeng-license.service`：授权网关 systemd 服务；
- `shunfeng-license.env.example`：环境变量示例，不包含真实令牌。

## 部署前提

本包是本次修改并验证过的网关源码，不包含闭源的 `LicenseService`
核心程序、生产数据库、签名密钥、管理员令牌或 SSH 凭据。部署时应保留
服务器上现有的 `LicenseService`、`/var/lib/shunfeng-license` 数据目录和
`/etc/shunfeng-license.env`。

网关和核心必须使用完全相同的 `LICENSE_ADMIN_TOKEN`。不要把真实令牌
写入源码、压缩包或聊天记录。

## 推荐目录

```text
/opt/shunfeng-license/
  LicenseService
  license_gateway.py
  index.html
/var/lib/shunfeng-license/
  data/
/etc/shunfeng-license.env
```

## 新服务器部署

1. 创建运行账户和目录：

   ```bash
   useradd --system --home /opt/shunfeng-license --shell /sbin/nologin shunfeng
   install -d -o shunfeng -g shunfeng /opt/shunfeng-license /var/lib/shunfeng-license/data
   ```

2. 将 `LicenseService`、`license_gateway.py` 和 `index.html` 放入
   `/opt/shunfeng-license`，并赋予运行账户权限：

   ```bash
   chown -R shunfeng:shunfeng /opt/shunfeng-license /var/lib/shunfeng-license
   chmod 750 /opt/shunfeng-license/LicenseService
   chmod 640 /opt/shunfeng-license/license_gateway.py /opt/shunfeng-license/index.html
   ```

3. 参考 `shunfeng-license.env.example` 创建 `/etc/shunfeng-license.env`，
   将 `LICENSE_ADMIN_TOKEN` 替换为随机长令牌，并限制读取权限：

   ```bash
   chown root:shunfeng /etc/shunfeng-license.env
   chmod 640 /etc/shunfeng-license.env
   ```

4. 安装并启动服务：

   ```bash
   cp shunfeng-license-core.service shunfeng-license.service /etc/systemd/system/
   systemctl daemon-reload
   systemctl enable --now shunfeng-license-core.service shunfeng-license.service
   ```

5. 验证运行状态：

   ```bash
   systemctl --no-pager --full status shunfeng-license-core.service shunfeng-license.service
   curl -fsS http://127.0.0.1:5180/health
   ```

## 升级现有服务器

先备份 `/opt/shunfeng-license`、`/var/lib/shunfeng-license` 和
`/etc/shunfeng-license.env`。升级网关时只覆盖 `license_gateway.py`、
`index.html` 及两个 service 文件，不要覆盖生产数据库、签名密钥和令牌。

```bash
systemctl restart shunfeng-license-core.service shunfeng-license.service
journalctl -u shunfeng-license-core.service -u shunfeng-license.service -n 100 --no-pager
```

管理后台连接地址使用网关端口 `5180`。管理员令牌只保存在当前浏览器
会话存储中，关闭会话后需要重新填写。
