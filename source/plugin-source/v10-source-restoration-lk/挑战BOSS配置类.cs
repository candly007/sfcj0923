using System.Collections.Concurrent;

public class 挑战BOSS配置类
{
	public bool 功能开关;

	public bool is指定会员双倍;

	public ConcurrentDictionary<string, 挑战BOSS列表类> 挑战boss列表 = new ConcurrentDictionary<string, 挑战BOSS列表类>();
}
