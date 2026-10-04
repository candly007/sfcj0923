public class 地府商城物品类
{
	public string 物品名字 = string.Empty;

	public int 物品图标;

	public AllEnums.数值Type 物品类型 = AllEnums.数值Type.道具;

	public int 物品数量 = 1;

	public ushort 消耗材料单价;

	public int 消耗数值单价;

	public bool 物品是否叠加;

	public bool 是否限购;

	public int 每日限购;

	public int 累计限购;
}
