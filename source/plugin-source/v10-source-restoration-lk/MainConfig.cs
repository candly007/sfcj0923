public class MainConfig
{
	// The endpoint is product-owned. Legacy serialized fields remain for
	// compatibility, but callers must use this accessor.
	private const string 内置授权服务器地址编码 = "aHR0cDovLzEyNC43MS4yMzYuNzE6NTE4MA==";

	public static string 取内置授权服务器地址()
	{
		return System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(内置授权服务器地址编码));
	}

	public string 取当前授权服务器地址()
	{
		// A configured private node is self-contained after bootstrap. Do not
		// require the legacy 私有化授权 flag or expose the main endpoint.
		if (!string.IsNullOrWhiteSpace(私有授权地址)) return 私有授权地址.Trim();
		return 取内置授权服务器地址();
	}

	// Optional private-node base URL, for example http://192.0.2.10:5190.
	// Leave empty for the built-in standard authorization service.
	public string 私有授权地址 = string.Empty;

	public string 卡密 = string.Empty;

	public string 管理员账号 = "admin";

	public string 管理员密码 = "123456";

	public ushort 后台管理端口 = 43210;

	public string 插件IP = string.Empty;

	public string 游戏IP = string.Empty;

	public string 游戏密码 = string.Empty;

	public string Mysql账号 = "root";

	public int Mysql端口 = 3306;

	public string Mysql密码 = string.Empty;

	public string adb表 = "dl_adb_all";

	public string ddb表 = "dl_ddb_1";

	public string 游戏端口 = "8101,8160,8161,8162";

	public string 插件端口 = "18101,18160,18161,18162";

	public int 点卡充值南极金额 = 10;

	public AllEnums.数值Type 点卡充值类型 = AllEnums.数值Type.银元宝;

	public int 点卡充值比例 = 100000;

	public int 奇宝充值比例 = 1;

	public string 挂载GM账号 = string.Empty;

	public string 禁止登录线路 = string.Empty;

	public bool is上线牌面 = true;

	public AllEnums.上线牌面Type 上线牌面 = AllEnums.上线牌面Type.流动广播;

	public int 上线牌面时间间隔 = 10;

	public int 累充金额;

	public string 上线牌面内容 = "#L欢迎大哥：#n#Y{0}#n#L进入游戏!#n";

	public bool is首登赠送 = true;

	public string 首登赠送1 = string.Empty;

	public string 首登赠送2 = string.Empty;

	public string 首登赠送3 = string.Empty;

	public string 首登赠送4 = string.Empty;

	public bool is日首冲赠送;

	public int 日首冲金额 = 10;

	public string 日首冲赠送 = string.Empty;

	public bool is悟道转换;

	public int 悟道转换消耗 = 10000000;

	public AllEnums.数值Type 悟道转换消耗类型 = AllEnums.数值Type.金钱;

	public bool isNpc点击管控;

	public int 管控频率 = 200;

	public bool is道具管控;

	public int 道具频率 = 100;

	public bool is丢弃管控;

	public int 丢弃频率 = 100;

	public bool is通天塔管控;

	public int 通天塔次数 = 1;

	public bool is退出战斗;

	public string 退出战斗指令 = "退出战斗";

	public bool is内置辅助;

	public string 打开辅助指令 = "辅助";

	public bool is找回属性指令;

	public string 找回属性指令 = "找回属性";

	public bool is相性加点;

	public int 加点最低等级 = 139;

	public int 单相最高上限 = 42;

	public bool is禁止登陆;

	public bool is屏蔽垃圾;

	public bool is指定辅助;

	public bool is连击加速;

	public bool is随身货栈;

	public bool is防刷摆摊 = true;

	public bool is富豪榜;

	public bool is红毯雪景;

	public bool is道具cdk;

	public bool is点卡cdk;

	public bool is轮转玉;

	public bool is超级轮转玉;

	public bool is超级天星石;

	public bool is本月试道;

	public bool is乾坤袋;

	public bool is乾坤袋附加活动大使;

	public bool 自动修复1009 = true;

	public bool 异常封包日志开关;

	public bool 数据库防护开关 = true;

	public bool 防CC开关;

	public bool CDK不加累充点开关;

	public bool CDK不加南极点开关;

	public bool Is允许修法 = true;

	public bool Is完美力魄;

	public bool Is巅峰对决 = true;

	public bool Is道友挖宝 = true;

	public int 前缀长度 = 5;

	public int 背包叠加上限 = 99;

	public string CDK网址 = string.Empty;

	public string 购卡网址 = string.Empty;

	public string 记录账号列表 = string.Empty;

	public string 扩展BOSS名字 = string.Empty;

	public 点卡配置类 点卡配置 = new 点卡配置类();

	public bool Is绑定秒解;

	public bool Is死绑不解 = true;

	public AllEnums.数值Type 解绑类型;

	public int 解绑消耗;
}
