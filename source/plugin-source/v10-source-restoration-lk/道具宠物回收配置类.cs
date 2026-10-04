using System.Collections.Concurrent;

public class 道具宠物回收配置类
{
	public bool is道具回收;

	public bool is宠物回收;

	public bool is禁止绑定宠物回收 = true;

	public bool is禁止绑定宠物道具找回 = true;

	public ConcurrentDictionary<string, 道宠回收数据类> 回收列表 = new ConcurrentDictionary<string, 道宠回收数据类>();
}
