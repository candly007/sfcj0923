public class 人物背包数据类
{
	public int 金元宝;

	public int 银元宝;

	public int 金钱;

	public int 代金券;

	public 物品信息类[] 物品列表 = new 物品信息类[301];

	public int 物理加成;

	public 人物背包数据类()
	{
		for (int i = 0; i < 301; i++)
		{
			物品列表[i] = new 物品信息类();
		}
	}
}
