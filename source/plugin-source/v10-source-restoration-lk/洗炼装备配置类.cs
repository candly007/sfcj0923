public class 洗炼装备配置类
{
	public AllEnums.装备Type 装备类型 = AllEnums.装备Type.时装;

	public bool 功能开关;

	public string 装备名字 = string.Empty;

	public bool 锁定开关 = true;

	public AllEnums.数值Type 锁定类型 = AllEnums.数值Type.银元宝;

	public int 锁定消耗 = 1000000;

	public bool is属性重复;

	public int 属性重复次数 = 2;

	public int 最低属性条数 = 1;

	public int 最高属性条数 = 5;

	public int 刷新出最高条数次数 = 100;

	public int 刷新出最高属性次数 = 200;

	public bool is道具洗炼;

	public string 洗炼道具名字 = "洗炼石";

	public int 道具洗炼消耗 = 100;

	public bool is数值洗炼;

	public AllEnums.数值Type 数值洗炼类型 = AllEnums.数值Type.金元宝;

	public int 数值洗炼消耗 = 100;

	public bool is附加描述 = true;

	public string 附加描述 = string.Empty;
}
