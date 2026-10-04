using System.Collections.Concurrent;
using System.Collections.Generic;

public class 盲盒配置类
{
	public bool 功能开关;

	public ConcurrentDictionary<string, bool> 多奖励列表 = new ConcurrentDictionary<string, bool>();

	public ConcurrentDictionary<string, List<盲盒奖励类>> 盲盒列表 = new ConcurrentDictionary<string, List<盲盒奖励类>>();
}
