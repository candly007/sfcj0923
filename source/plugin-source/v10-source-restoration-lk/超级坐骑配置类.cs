using System.Collections.Concurrent;

public class 超级坐骑配置类
{
	public bool 功能开关;

	public bool 战斗开关;

	public ConcurrentDictionary<int, 超级坐骑列表类> 超级坐骑编号列表 = new ConcurrentDictionary<int, 超级坐骑列表类>();
}
