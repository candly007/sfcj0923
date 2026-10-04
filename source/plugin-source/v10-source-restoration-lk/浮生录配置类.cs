using System.Collections.Concurrent;

public class 浮生录配置类
{
	public bool 功能开关;

	public bool 定制功能开关;

	public string 特效道具 = "浮生金丹";

	public NPC数据类 NPC数据 = new NPC数据类(102, "浮生天尊", "浮生录功能指引", new 坐标类(100, 100), 7, 6001);

	public bool is道具抽取;

	public bool is道具连抽;

	public string 道具名字 = "浮生之羽";

	public int 道具消耗 = 10;

	public bool is数值抽取;

	public bool is数值连抽;

	public AllEnums.数值Type 数值类型 = AllEnums.数值Type.银元宝;

	public int 数值消耗;

	public ConcurrentDictionary<string, 浮生化身配置类> 化身列表 = new ConcurrentDictionary<string, 浮生化身配置类>();

	public int 一星化身抽取几率 = 100;

	public int 二星化身抽取几率 = 80;

	public int 三星化身抽取几率 = 60;

	public int 四星化身抽取几率 = 20;

	public int 五星化身抽取几率 = 1;

	public AllEnums.属性Type 乱世书属性 = AllEnums.属性Type.木相性;

	public AllEnums.属性名字Type 定制乱世书属性;

	public int 乱世书数值 = 50;

	public AllEnums.属性Type 千钧卷属性 = AllEnums.属性Type.土相性;

	public AllEnums.属性名字Type 定制千钧卷属性;

	public int 千钧卷数值 = 50;

	public AllEnums.属性Type 灵虚卷属性 = AllEnums.属性Type.金相性;

	public AllEnums.属性名字Type 定制灵虚卷属性;

	public int 灵虚卷数值 = 50;

	public AllEnums.属性Type 御元卷属性 = AllEnums.属性Type.水相性;

	public AllEnums.属性名字Type 定制御元卷属性;

	public int 御元卷数值 = 50;

	public AllEnums.属性Type 乘风卷属性 = AllEnums.属性Type.火相性;

	public AllEnums.属性名字Type 定制乘风卷属性;

	public int 乘风卷数值 = 50;
}
