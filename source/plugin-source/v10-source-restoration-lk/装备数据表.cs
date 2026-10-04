using System.Collections.Generic;

public class 装备数据表
{
	public string 装备名字 = string.Empty;

	public int 装备等级;

	public List<string> 可转换名字 = new List<string>();

	public string 可进化名字 = string.Empty;

	public 装备数据表(string 装备名字, int 装备等级, string 可进化名字, List<string> 可转换名字)
	{
		this.装备名字 = 装备名字;
		this.装备等级 = 装备等级;
		this.可进化名字 = 可进化名字;
		this.可转换名字 = 可转换名字;
	}
}
