public class 超级道具数据类
{
	public string 道具名字 = string.Empty;

	public int 已用数量;

	public int 累计领取;

	public AllEnums.数值Type 加成属性;

	public int 加成数值;

	public void 清空()
	{
		已用数量 = 0;
		累计领取 = 0;
		加成属性 = AllEnums.数值Type.无;
		加成数值 = 0;
	}
}
