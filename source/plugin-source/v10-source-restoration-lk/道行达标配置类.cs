using System.Collections.Generic;

public class 道行达标配置类
{
	public bool 功能开关;

	public List<道行达标奖励配置类> 道行达标奖励列表 = new List<道行达标奖励配置类>();

	public 道行达标配置类()
	{
		道行达标奖励列表 = new List<道行达标奖励配置类>();
	}
}
