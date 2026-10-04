using System;

public class 富豪榜排行数据类 : IComparable
{
	public string 名字 = string.Empty;

	public short 等级;

	public int 金额;

	public string 门派 = string.Empty;

	public int CompareTo(object? obj)
	{
		if (!(obj is 富豪榜排行数据类 富豪榜排行数据类2))
		{
			throw new ArgumentException("Object is not a Person");
		}
		return 金额.CompareTo(富豪榜排行数据类2.金额);
	}
}
