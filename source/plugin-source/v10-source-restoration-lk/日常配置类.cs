using System.Collections.Concurrent;

public class 日常配置类
{
	public bool 功能开关;

	public ConcurrentDictionary<AllEnums.日常类型Type, 日常配置详情类> 配置详情 = new ConcurrentDictionary<AllEnums.日常类型Type, 日常配置详情类>();
}
