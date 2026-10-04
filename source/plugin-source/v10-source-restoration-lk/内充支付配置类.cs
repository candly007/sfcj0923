using System.Collections.Concurrent;
using System.Collections.Generic;

public class 内充支付配置类
{
	public bool 功能开关;

	public bool 支付宝支付;

	public bool 微信支付;

	public bool QQ钱包支付;

	public string Pid = string.Empty;

	public string GatewayUrl = string.Empty;

	public string Md5Key = string.Empty;

	public string SignType = "MD5";

	public bool 开启抽奖模式;

	public int 单价 = 1;

	public List<内充抽奖类> 总奖池 = new List<内充抽奖类>();

	public ConcurrentQueue<内充抽奖类> 剩余奖池 = new ConcurrentQueue<内充抽奖类>();
}
