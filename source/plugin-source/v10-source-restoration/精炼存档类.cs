using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class 精炼存档类
{
	public Dictionary<AllEnums.精炼属性Type, int> 精炼计数字典;

	public int 首饰强化次数;

	public Dictionary<string, int> 分解计数字典;

	public int 已鉴定次数;

	public int 总鉴定次数;

	
	public 精炼存档类()
	{
		精炼计数字典 = new Dictionary<AllEnums.精炼属性Type, int>();
		分解计数字典 = new Dictionary<string, int>();
	}

	static 精炼存档类()
	{
	}
}
