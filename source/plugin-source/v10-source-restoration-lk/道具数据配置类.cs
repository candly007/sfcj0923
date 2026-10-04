using System.Collections.Concurrent;

public class 道具数据配置类
{
	public ConcurrentDictionary<string, 道具数据> 道具字典 = new ConcurrentDictionary<string, 道具数据>();
}
