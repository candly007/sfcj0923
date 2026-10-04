using System.Collections.Concurrent;
using System.Collections.Generic;

public class 召唤精怪配置类
{
	public bool 功能开关;

	public ConcurrentDictionary<AllEnums.召唤材料Type, List<召唤精怪列表类>> 召唤列表 = new ConcurrentDictionary<AllEnums.召唤材料Type, List<召唤精怪列表类>>();
}
