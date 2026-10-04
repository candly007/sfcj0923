using System.Collections.Generic;

public class 超级NPC配置类
{
	public bool 功能开关;

	public int 自增id = 1000100;

	public List<超级NPC列表类> NPC列表 = new List<超级NPC列表类>();

	public 超级NPC配置类()
	{
		NPC列表 = new List<超级NPC列表类>();
	}
}
