using System.Collections.Concurrent;

public class 全服共享存档数据类
{
	public string 日期记录 = string.Empty;

	public int 南极抽奖总次数;

	public int 当日紫帝晶数量;

	public int[] 已融丹次数 = new int[6];

	public 无双圣榜存档类 无双排行数据 = new 无双圣榜存档类();

	public ConcurrentDictionary<AllEnums.元神境界, string> 全服境界突破第一人组 = new ConcurrentDictionary<AllEnums.元神境界, string>();
}
