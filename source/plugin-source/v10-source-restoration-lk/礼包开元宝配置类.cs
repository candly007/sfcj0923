using System.Collections.Concurrent;

public class 礼包开元宝配置类
{
	public bool 功能开关;

	public ConcurrentDictionary<string, int[]> 礼包列表 = new ConcurrentDictionary<string, int[]>();
}
