using System.Collections.Generic;

public class 装备强化配置类
{
	public bool 功能开关;

	public bool 谣言开关 = true;

	public bool 绑定装备才可精炼;

	public int 装备最低精炼等级 = 1;

	public int 装备最高精炼等级 = 999;

	public List<AllEnums.Equip类型> 可精炼装备类型 = new List<AllEnums.Equip类型>();

	public List<精炼属性条件类> 条件列表 = new List<精炼属性条件类>();

	public List<精炼属性数值类> 属性列表 = new List<精炼属性数值类>();
}
