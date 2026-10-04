using System.Collections.Generic;

public class 超级NPC列表类
{
	public bool 是否显示 = true;

	public string 对话介绍 = string.Empty;

	public string 所在地图 = string.Empty;

	public NPC数据类 NPC数据 = new NPC数据类();

	public List<超级NPC传送类> 地图列表 = new List<超级NPC传送类>();

	public 超级NPC列表类()
	{
		地图列表 = new List<超级NPC传送类>();
	}
}
