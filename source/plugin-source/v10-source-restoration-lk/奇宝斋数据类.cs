using System;

public class 奇宝斋数据类 : IComparable
{
	public string 物品编号 = string.Empty;

	public int 物品权重 = 10000;

	public string 物品名称 = string.Empty;

	public int 物品价格;

	public int 物品图标;

	public int 出售数量;

	public string 出售账号 = string.Empty;

	public string 到期时间 = string.Empty;

	public int CompareTo(object? obj)
	{
		if (!(obj is 奇宝斋数据类 奇宝斋数据类2))
		{
			throw new ArgumentException("Object is not a Person");
		}
		return 物品权重.CompareTo(奇宝斋数据类2.物品权重);
	}
}
