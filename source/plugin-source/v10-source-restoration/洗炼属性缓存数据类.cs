using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class 洗炼属性缓存数据类
{
	public int 道具ID;

	public int 洗炼次数;

	public int 出相属次数;

	public AllEnums.装备Type 装备类型;

	public List<洗炼属性缓存列表类> 属性列表;

	
	public 洗炼属性缓存数据类()
	{
		属性列表 = new List<洗炼属性缓存列表类>();
	}

	static 洗炼属性缓存数据类()
	{
	}
}
