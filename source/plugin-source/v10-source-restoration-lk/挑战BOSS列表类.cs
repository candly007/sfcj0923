using System.Collections.Generic;

public class 挑战BOSS列表类
{
	public string BOSS名字 = string.Empty;

	public string BOSS称号 = string.Empty;

	public string BOSS战斗名字 = string.Empty;

	public string 对话关键词 = string.Empty;

	public string 介绍描述 = string.Empty;

	public bool is组队开关;

	public bool is挑战消耗;

	public AllEnums.数值Type 消耗类型 = AllEnums.数值Type.银元宝;

	public string 消耗道具 = string.Empty;

	public int 消耗数量;

	public bool is等级开关;

	public int 最低等级;

	public int 最高等级;

	public bool is道行开关;

	public int 最低道行;

	public int 最高道行;

	public bool is活跃开关;

	public int 最低活跃;

	public int 最高活跃;

	public bool is称号开关;

	public string 指定称号1 = string.Empty;

	public string 指定称号2 = string.Empty;

	public bool is掉落开关;

	public bool 只给队长;

	public bool is击杀开关;

	public int 每日限制击杀;

	public bool is补充开关;

	public AllEnums.数值Type 补充类型 = AllEnums.数值Type.银元宝;

	public int 补充消耗;

	public List<BOSS掉落类> 掉落列表 = new List<BOSS掉落类>();

	public 挑战BOSS列表类()
	{
		掉落列表 = new List<BOSS掉落类>();
	}
}
