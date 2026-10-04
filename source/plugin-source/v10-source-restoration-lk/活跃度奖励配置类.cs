using System;

public class 活跃度奖励配置类 : IComparable
{
	public int 活跃度;

	public int 奖累充点;

	public int 奖南极点;

	public int 奖金元宝;

	public int 奖银元宝;

	public string 奖励道具 = string.Empty;

	public int CompareTo(object? obj)
	{
		if (!(obj is 活跃度奖励配置类 活跃度奖励配置类2))
		{
			throw new ArgumentException("Object is not a Person");
		}
		return 活跃度.CompareTo(活跃度奖励配置类2.活跃度);
	}
}
