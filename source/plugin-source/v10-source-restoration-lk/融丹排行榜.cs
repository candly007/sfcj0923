using System;

public class 融丹排行榜 : IComparable
{
	public string 名字 = string.Empty;

	public int GID;

	public int 次数;

	public int CompareTo(object? obj)
	{
		if (!(obj is 融丹排行榜 融丹排行榜2))
		{
			throw new ArgumentException("Object is not a Person");
		}
		return 次数.CompareTo(融丹排行榜2.次数);
	}
}
