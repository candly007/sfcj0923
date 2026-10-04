using System.Collections.Concurrent;

public class 超级地图配置类
{
	public bool 功能开关;

	public ConcurrentDictionary<string, 地图限制列表类> 地图列表 = new ConcurrentDictionary<string, 地图限制列表类>();
}
