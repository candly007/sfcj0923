using System.Collections.Concurrent;

public class 元神系统配置类
{
	public bool 功能开关;

	public bool 禁止灵气存储 = true;

	public string 初始赠送礼包 = string.Empty;

	public string 渡劫地图 = string.Empty;

	public string 地图坐标X = string.Empty;

	public string 地图坐标Y = string.Empty;

	public string 转化道具 = string.Empty;

	public bool 超过BOSS二层境界不获得任何奖励;

	public bool 开启破境BOSS同境界挑战限制 = true;

	public AllEnums.元神境界 当前境界上限 = AllEnums.元神境界.化神境;

	public ConcurrentDictionary<AllEnums.元神境界, 元神境界配置类> 境界列表 = new ConcurrentDictionary<AllEnums.元神境界, 元神境界配置类>();

	public 装备升阶配置类 装备升阶数据 = new 装备升阶配置类();

	public ConcurrentDictionary<int, 本命法宝属性类> 本命法宝属性 = new ConcurrentDictionary<int, 本命法宝属性类>();

	public 心法升级配置类 心法升级配置 = new 心法升级配置类();

	public 灵幡附灵配置类 灵幡附灵配置 = new 灵幡附灵配置类();

	public string 限制使用特技地图 = string.Empty;

	public string 限制使用特技名字 = string.Empty;

	public ConcurrentDictionary<AllEnums.元神境界, int> 战斗背景列表 = new ConcurrentDictionary<AllEnums.元神境界, int>();
}
