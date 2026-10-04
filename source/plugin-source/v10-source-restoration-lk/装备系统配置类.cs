using System.Collections.Generic;

public class 装备系统配置类
{
	public bool 改造拆卸开关;

	public bool 可拆绑定开关;

	public string 拆卸道具名字 = "改造拆卸令";

	public int[] 可拆改造等级区间 = new int[2] { 1, 12 };

	public int[] 可拆装备等级区间 = new int[2] { 1, 180 };

	public AllEnums.绑定Type 拆后改造令绑定状态 = AllEnums.绑定Type.死绑;

	public bool 进化开关;

	public bool 绑定装备才可进化;

	public int 装备最低进化等级 = 80;

	public List<装备进化数值类> 进化列表 = new List<装备进化数值类>();
}
