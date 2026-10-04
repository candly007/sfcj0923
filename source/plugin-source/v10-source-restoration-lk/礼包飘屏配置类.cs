using System.Collections.Concurrent;

public class 礼包飘屏配置类
{
	public bool 功能开关;

	public ConcurrentDictionary<string, string> 礼包列表 = new ConcurrentDictionary<string, string>();
}
