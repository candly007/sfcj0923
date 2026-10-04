using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

public class 人物技能数据类
{
	public int 额外附加等级;

	public ConcurrentDictionary<string, short> 技能列表;

	
	public 人物技能数据类()
	{
		技能列表 = new ConcurrentDictionary<string, short>();
	}

	static 人物技能数据类()
	{
	}
}
