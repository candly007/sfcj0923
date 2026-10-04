using System;

public class 在线奖池配置类 : IComparable
{
	public AllEnums.数值Type 类型;

	public bool 是否为保底奖励;

	public bool 是否出谣言;

	public string 奖励名字 = string.Empty;

	public int 获得几率;

	public int 获得数量 = 1;

	public bool 是否限制数量;

	public int 已抽出数量;

	public int 可抽出数量;

	public int CompareTo(object obj)
	{
		if (!(obj is 在线奖池配置类 在线奖池配置类2))
		{
			throw new ArgumentException("Object is not a Person");
		}
		return 获得几率.CompareTo(在线奖池配置类2.获得几率);
	}
}
