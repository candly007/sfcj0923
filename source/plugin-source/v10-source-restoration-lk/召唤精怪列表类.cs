using System;

public class 召唤精怪列表类 : IComparable
{
	public AllEnums.召唤材料Type 召唤材料;

	public string 礼包名字 = string.Empty;

	public int 获得几率;

	public string 镇压宠物 = string.Empty;

	public int 最低银元宝;

	public int 最高银元宝;

	public int 平均银元宝;

	public int 奇宝点数;

	public bool 谣言广播 = true;

	public int CompareTo(object obj)
	{
		if (!(obj is 召唤精怪列表类 召唤精怪列表类2))
		{
			throw new ArgumentException("Object is not a Person");
		}
		return 获得几率.CompareTo(召唤精怪列表类2.获得几率);
	}
}
