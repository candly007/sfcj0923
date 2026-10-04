using System;

public class 融丹奖池类 : IComparable
{
	public string 名字 = string.Empty;

	public AllEnums.数值Type 类型;

	public AllEnums.荣丹Type 等级 = AllEnums.荣丹Type.参与奖;

	public int 概率;

	public int[] 数量区间 = new int[2] { 1, 1 };

	public int 价值;

	public int CompareTo(object? obj)
	{
		if (!(obj is 融丹奖池类 融丹奖池类2))
		{
			throw new ArgumentException("Object is not a Person");
		}
		return 概率.CompareTo(融丹奖池类2.概率);
	}
}
