using System.Collections.Concurrent;

public class 异兽录配置类
{
	public bool 功能开关;

	public bool 定制功能开关;

	public bool 推荐开关;

	public string 特效道具 = string.Empty;

	public NPC数据类 NPC数据 = new NPC数据类(105, "异兽尊者", "异兽录指引", new 坐标类(237, 217), 5, 20174);

	public ConcurrentDictionary<string, 异兽录图鉴列表类> 图鉴列表 = new ConcurrentDictionary<string, 异兽录图鉴列表类>();

	public AllEnums.属性Type 变异圆满附加属性;

	public AllEnums.属性名字Type 定制变异圆满附加属性;

	public int 变异圆满附加数值;

	public string 变异别称 = "变异";

	public AllEnums.属性Type 神兽圆满附加属性;

	public AllEnums.属性名字Type 定制神兽圆满附加属性;

	public int 神兽圆满附加数值;

	public string 神兽别称 = "神兽";

	public AllEnums.属性Type 元灵圆满附加属性;

	public AllEnums.属性名字Type 定制元灵圆满附加属性;

	public int 元灵圆满附加数值;

	public string 元灵别称 = "元灵";

	public AllEnums.属性Type 仙元圆满附加属性;

	public AllEnums.属性名字Type 定制仙元圆满附加属性;

	public int 仙元圆满附加数值;

	public string 仙元别称 = "仙元";

	public AllEnums.属性Type 御灵圆满附加属性;

	public AllEnums.属性名字Type 定制御灵圆满附加属性;

	public int 御灵圆满附加数值;

	public string 御灵别称 = "坐骑";
}
