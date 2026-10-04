public class 宠物召唤配置类
{
	public bool 功能开关;

	public bool is变异召唤;

	public bool is神兽召唤;

	public bool is元灵召唤;

	public bool is仙元召唤;

	public bool is御灵召唤;

	public NPC数据类 NPC数据 = new NPC数据类(102, "宠物尊者", "宠物召唤同源回收点我", new 坐标类(100, 100), 7, 6001);

	public string 变异材料 = string.Empty;

	public int 变异最低;

	public int 变异最高;

	public string 变异奖励 = string.Empty;

	public string 变异对话 = string.Empty;

	public string 神兽材料 = string.Empty;

	public int 神兽最低;

	public int 神兽最高;

	public string 神兽奖励 = string.Empty;

	public string 神兽对话 = string.Empty;

	public string 元灵材料 = string.Empty;

	public int 元灵最低;

	public int 元灵最高;

	public string 元灵奖励 = string.Empty;

	public string 元灵对话 = string.Empty;

	public string 仙元材料 = string.Empty;

	public int 仙元最低;

	public int 仙元最高;

	public string 仙元奖励 = string.Empty;

	public string 仙元对话 = string.Empty;

	public string 御灵材料 = string.Empty;

	public int 御灵最低;

	public int 御灵最高;

	public string 御灵奖励 = string.Empty;

	public string 御灵对话 = string.Empty;
}
