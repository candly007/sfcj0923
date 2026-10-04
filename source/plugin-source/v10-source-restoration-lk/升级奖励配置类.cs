using System.Collections.Concurrent;

public class 升级奖励配置类
{
	public bool 功能开关;

	public ConcurrentDictionary<int, 升级奖励列表类> 升级列表 = new ConcurrentDictionary<int, 升级奖励列表类>();
}
