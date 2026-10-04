using System.Collections.Generic;

public class 累充配置类
{
	public bool 功能开关;

	public string 开启时间 = "2024-01-01 00:00:00";

	public string 结束时间 = "2029-01-01 00:00:00";

	public string 截止时间 = "2029-12-01 00:00:00";

	public List<累充奖励列表类> 奖励列表 = new List<累充奖励列表类>();

	public 累充配置类()
	{
		奖励列表 = new List<累充奖励列表类>();
	}
}
