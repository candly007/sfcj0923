using System.Collections.Concurrent;
using System.Collections.Generic;

public class 时装坐姿染色配置类
{
	public bool 时装坐姿开关;

	public bool 坐姿染色开关;

	public bool 坐姿染色战斗开关;

	public int 染色消耗数量 = 5;

	public ConcurrentDictionary<string, 时装坐姿数据列表类> 时装坐姿列表 = new ConcurrentDictionary<string, 时装坐姿数据列表类>();

	public ConcurrentDictionary<string, List<染色坐姿数据列表类>> 染色坐姿列表 = new ConcurrentDictionary<string, List<染色坐姿数据列表类>>();
}
