using System.Collections.Generic;

public class 融丹配置类
{
	public bool 功能开关;

	public bool Is转换元宝;

	public bool Is开通图标;

	public string 开始时间 = "2029-01-01 00:00:00";

	public string 结束时间 = "2029-01-01 00:00:00";

	public string 到期时间 = "2029-01-01 00:00:00";

	public AllEnums.数值Type 消耗类型 = AllEnums.数值Type.银元宝;

	public int 消耗数量;

	public List<荣丹排行奖励类> 奖励列表 = new List<荣丹排行奖励类>();

	public List<融丹奖池类> 奖池 = new List<融丹奖池类>();

	public int[] 各等奖份数组 = new int[6];

	public bool Is按照份数出 = true;

	public int 保底出特等次数;

	public bool Is校验累充点;

	public int 保底出特等累充点;

	public bool Is经验消减;

	public bool Is道行消减;
}
