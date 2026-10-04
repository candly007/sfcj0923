public class 法宝共生配置类
{
	public bool 功能开关;

	public string npc名字 = string.Empty;

	public int 消耗数值;

	public AllEnums.数值Type 消耗数值类型 = AllEnums.数值Type.银元宝;

	public bool 元神合体开关 = true;

	public string 元神合体npc名字 = "仙缘道人";

	public AllEnums.数值Type 元神合体消耗数值类型 = AllEnums.数值Type.银元宝;

	public int 元神合体消耗数值;

	public int 最低等级 = 139;

	public int 最高等级 = 139;
}
