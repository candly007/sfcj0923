using System.Collections.Concurrent;

public class 宠物绑定配置类
{
	public bool 功能开关;

	public bool is死绑开关;

	public ConcurrentDictionary<string, string> 道具宠物绑定列表 = new ConcurrentDictionary<string, string>();

	public string 宠物自动绑定列表 = string.Empty;
}
