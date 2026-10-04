using System.Collections.Concurrent;

public class 首饰系统配置类
{
	public bool 首饰强化开关;

	public bool 随机强化开关;

	public bool 谣言开关 = true;

	public int 最低强化等级 = 130;

	public string 强化材料名字 = string.Empty;

	public bool 首饰降级开关;

	public int 最低降级等级 = 130;

	public string 降级材料名字 = string.Empty;

	public ConcurrentDictionary<string, 首饰强化配置类> 属性字典 = new ConcurrentDictionary<string, 首饰强化配置类>();
}
