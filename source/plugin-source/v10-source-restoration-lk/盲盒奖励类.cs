using System;

public class 盲盒奖励类 : IComparable
{
	public AllEnums.数值Type 奖励类型;

	public string 奖励名字 = string.Empty;

	public int 获得几率;

	public int 最低数量 = 1;

	public int 最高数量 = 1;

	public int CompareTo(object? obj)
	{
		if (!(obj is 盲盒奖励类 盲盒奖励类2))
		{
			throw new ArgumentException("Object is not a Person");
		}
		return 获得几率.CompareTo(盲盒奖励类2.获得几率);
	}
}
