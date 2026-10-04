using System;
using System.Collections.Generic;

public class 累充奖励列表类 : IComparable
{
	public int 阶段;

	public int 金额;

	public List<string[]> 奖励列表 = new List<string[]>();

	public int CompareTo(object? obj)
	{
		if (!(obj is 累充奖励列表类 累充奖励列表类2))
		{
			throw new ArgumentException("Object is not a Person");
		}
		return 阶段.CompareTo(累充奖励列表类2.阶段);
	}
}
