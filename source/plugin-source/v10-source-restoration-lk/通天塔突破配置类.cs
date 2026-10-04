using System.Collections.Concurrent;

public class 通天塔突破配置类
{
	public bool 功能开关;

	public ConcurrentDictionary<int, string> 通天塔奖励列表 = new ConcurrentDictionary<int, string>();
}
