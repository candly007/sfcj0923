using System;

public class 角色汇总类 : IComparable
{
	public int GID;

	public bool 是否在线;

	public string 账号 = string.Empty;

	public string 昵称 = string.Empty;

	public int 等级;

	public byte 性别;

	public byte 五行;

	public string 所在地图名字 = string.Empty;

	public int 金元宝;

	public int 银元宝;

	public int 金钱;

	public int 活跃值;

	public int 南极点;

	public int 累充点;

	public int 奇宝点;

	public bool is指定会员;

	public bool is战斗中;

	public string IP = string.Empty;

	public string Mac = string.Empty;

	public string 历史QQ = string.Empty;

	public string 上线时间 = string.Empty;

	public string 离线时间 = string.Empty;

	public int CompareTo(object? obj)
	{
		if (!(obj is 角色汇总类 角色汇总类2))
		{
			throw new ArgumentException("Object is not a Person");
		}
		return GID.CompareTo(角色汇总类2.GID);
	}
}
