using System.Collections.Concurrent;

public class 灵幡附灵配置类
{
	public bool 功能开关;

	public string 一阶灵幡名字 = "一阶引灵幡";

	public string 二阶灵幡名字 = "二阶引灵幡";

	public string 三阶灵幡名字 = "三阶引灵幡";

	public string 四阶灵幡名字 = "四阶引灵幡";

	public ConcurrentDictionary<int, 引灵幡属性列表类> 附灵字典 = new ConcurrentDictionary<int, 引灵幡属性列表类>();
}
