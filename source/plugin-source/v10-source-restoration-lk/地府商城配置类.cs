using System.Collections.Generic;

public class 地府商城配置类
{
	public bool 功能开关;

	public bool 图标开关;

	public string 消耗材料名字 = string.Empty;

	public AllEnums.数值Type 消耗数值类型 = AllEnums.数值Type.灵气值;

	public string 道行下限文本 = string.Empty;

	public List<地府商城物品类> 物品列表 = new List<地府商城物品类>();
}
