using System.Collections.Concurrent;

public class 自选道具配置类
{
	public bool 功能开关;

	public ConcurrentDictionary<string, 自选道具列表类> 自选道具列表 = new ConcurrentDictionary<string, 自选道具列表类>();
}
