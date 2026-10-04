using System;

public class 道行达标奖励配置类 : IComparable
{
	public int 最低道行;

	public string 奖励道具 = string.Empty;

	public int CompareTo(object? obj)
	{
		if (!(obj is 道行达标奖励配置类 道行达标奖励配置类2))
		{
			throw new ArgumentException("Object is not a Person");
		}
		return 最低道行.CompareTo(道行达标奖励配置类2.最低道行);
	}
}
