using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

public class 人物背包数据类
{
	public int 金元宝;

	public int 银元宝;

	public int 金钱;

	public int 代金券;

	public 物品信息类[] 物品列表;

	public ConcurrentDictionary<short, 物品信息类> 仓库列表;

	public int 物理加成;

	public int 套装加成;

	
	public 人物背包数据类()
	{
		物品列表 = new 物品信息类[301];
		仓库列表 = new ConcurrentDictionary<short, 物品信息类>();
		for (int i = 0; i < 301; i++)
		{
			物品列表[i] = new 物品信息类();
		}
	}

	static 人物背包数据类()
	{
	}
}
