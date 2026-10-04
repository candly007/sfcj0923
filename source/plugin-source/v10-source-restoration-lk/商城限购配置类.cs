using System.Collections.Generic;

public class 商城限购配置类
{
	public bool 功能开关;

	public List<商城数据类> 限购数据列表 = new List<商城数据类>();

	public 商城限购配置类()
	{
		限购数据列表 = new List<商城数据类>();
	}
}
