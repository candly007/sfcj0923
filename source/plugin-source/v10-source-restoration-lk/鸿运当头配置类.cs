using System.Collections.Concurrent;

public class 鸿运当头配置类
{
	public bool 功能开关;

	public AllEnums.数值Type 随机抽取模式;

	public int 抽取模式消耗;

	public bool 盲盒选购模式开关;

	public AllEnums.数值Type 盲盒选购模式;

	public int 选购模式;

	public ConcurrentDictionary<string, 鸿运物品列表类> 列表 = new ConcurrentDictionary<string, 鸿运物品列表类>();
}
