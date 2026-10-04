using System.Collections.Concurrent;

public class 浮生录存档类
{
	public bool is全部激活;

	public ConcurrentDictionary<string, 浮生录化身列表类> 化身列表 = new ConcurrentDictionary<string, 浮生录化身列表类>();

	public 浮生属性加护类 浮生属性 = new 浮生属性加护类();
}
