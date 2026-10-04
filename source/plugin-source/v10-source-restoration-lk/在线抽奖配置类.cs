using System.Collections.Generic;

public class 在线抽奖配置类
{
	public bool 功能开关;

	public string 触发指令 = "抽奖";

	public AllEnums.数值Type 消耗类型;

	public int 消耗数值;

	public int 累计出保底次数;

	public List<在线奖池配置类> 奖池列表 = new List<在线奖池配置类>();
}
