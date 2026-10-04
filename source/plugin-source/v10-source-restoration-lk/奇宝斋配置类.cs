using System.Collections.Concurrent;

public class 奇宝斋配置类
{
	public bool 功能开关;

	public bool 玩家上架开关;

	public string 充值网址 = string.Empty;

	public int 卖出手续费;

	public int 上架押金 = 10;

	public int 奇宝点比例 = 100;

	public string 可上架商品 = string.Empty;

	public ConcurrentDictionary<string, 奇宝斋数据类> 物品列表 = new ConcurrentDictionary<string, 奇宝斋数据类>();
}
