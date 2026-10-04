using System.Collections.Concurrent;

public class 百炼功能配置类
{
	public bool 功能开关;

	public NPC数据类 NPC数据 = new NPC数据类(107, "百炼天尊", "装备洗炼功能指引", new 坐标类(254, 189), 7, 6001);

	public string 对话介绍 = string.Empty;

	public ConcurrentDictionary<string, 百炼列表类> 百炼列表 = new ConcurrentDictionary<string, 百炼列表类>();
}
