using System.Collections.Generic;

public class 超级道具列表配置类
{
	public string 道具唯一名字 = string.Empty;

	public int 最多使用数量 = -1;

	public AllEnums.数值Type 道具消耗类型;

	public string 道具消耗内容 = string.Empty;

	public bool is等级开关;

	public int 最低使用等级;

	public int 最高使用等级;

	public bool is道行开关;

	public int 最低使用道行;

	public int 最高使用道行;

	public bool is称号开关;

	public string 指定称号使用 = string.Empty;

	public bool is奖励开关;

	public AllEnums.数值Type 额外奖励类型;

	public AllEnums.属性名字Type 附加属性类型;

	public int 附加属性限时;

	public int 获得几率;

	public int 最低奖励下限;

	public int 最高奖励上限;

	public bool is累计开关;

	public bool is重置累计;

	public List<超级道具累计奖励类> 累计奖励列表 = new List<超级道具累计奖励类>();

	public 超级道具列表配置类()
	{
		累计奖励列表 = new List<超级道具累计奖励类>();
	}
}
