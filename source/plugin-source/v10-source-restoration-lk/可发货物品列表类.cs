using System;

public class 可发货物品列表类 : IComparable
{
	public int index;

	public string 物品名字 = string.Empty;

	public short 物品编号;

	public int 物品图标;

	public int 物品价格;

	public byte[] 物品封包 = Array.Empty<byte>();

	public byte[] 南极物品封包 = Array.Empty<byte>();

	public 可发货物品列表类(int index)
	{
		this.index = index;
	}

	public int CompareTo(object? obj)
	{
		if (!(obj is 可发货物品列表类 可发货物品列表类2))
		{
			throw new ArgumentException("Object is not a Person");
		}
		return 物品编号.CompareTo(可发货物品列表类2.物品编号);
	}
}
