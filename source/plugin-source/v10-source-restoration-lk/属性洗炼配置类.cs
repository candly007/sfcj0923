using System.Collections.Generic;

public class 属性洗炼配置类
{
	public bool 功能开关;

	public bool 背包开关;

	public int 自动停止比例 = 80;

	public NPC数据类 NPC数据 = new NPC数据类(106, "洗炼大师", "装备洗炼功能指引", new 坐标类(254, 189), 7, 6001);

	public 洗炼装备配置类 时装配置 = new 洗炼装备配置类();

	public 洗炼装备配置类 法宝配置 = new 洗炼装备配置类();

	public 洗炼装备配置类 梭子配置 = new 洗炼装备配置类();

	public 洗炼装备配置类 铭牌配置 = new 洗炼装备配置类();

	public 洗炼装备配置类 仙器配置 = new 洗炼装备配置类();

	public 洗炼装备配置类 灵幡配置 = new 洗炼装备配置类();

	public List<洗炼属性数据类> 洗炼属性列表 = new List<洗炼属性数据类>();

	public 属性洗炼配置类()
	{
		洗炼属性列表 = new List<洗炼属性数据类>();
	}
}
