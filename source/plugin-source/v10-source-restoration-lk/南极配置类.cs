using System.Collections.Generic;

public class 南极配置类
{
	public bool 功能开关;

	public bool is开启大额;

	public string 到期时间 = "2029-01-01 00:00:00";

	public string 活动描述 = string.Empty;

	public int 总累计出特等;

	public List<南极抽奖物品类> 奖池 = new List<南极抽奖物品类>();

	public 南极配置类()
	{
		奖池 = new List<南极抽奖物品类>();
	}
}
