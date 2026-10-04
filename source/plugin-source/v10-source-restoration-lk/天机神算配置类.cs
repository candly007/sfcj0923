using System.Collections.Generic;

public class 天机神算配置类
{
	public bool 功能开关;

	public bool 自动刷新开关;

	public bool 支付开关;

	public bool 抽1次开关 = true;

	public bool 抽10次开关 = true;

	public bool 抽20次开关 = true;

	public bool 抽50次开关 = true;

	public bool 抽100次开关 = true;

	public bool 抽200次开关 = true;

	public NPC数据类 NPC数据 = new NPC数据类(111, "天机神算子", "", new 坐标类(241, 197), 7, 6001, "暂未写");

	public AllEnums.数值Type 抽取消耗类型;

	public int 抽取消耗数量;

	public int 支付价格;

	public string 每日刷新时间 = "00:00";

	public List<神算物品列表类> 列表 = new List<神算物品列表类>();
}
