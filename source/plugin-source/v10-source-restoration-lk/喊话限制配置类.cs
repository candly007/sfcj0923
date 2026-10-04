using System.Collections.Generic;

public class 喊话限制配置类
{
	public bool 功能开关;

	public int 喇叭喊话最低等级;

	public List<string> 敏感词 = new List<string>();

	public bool is触发掉线;

	public string 开始时间 = "2025-01-01 00:00:00";

	public string 结束时间 = "2029-01-01 00:00:00";

	public int 间隔时间;

	public AllEnums.频道Type 喊话频道 = AllEnums.频道Type.世界;

	public string 喊话内容 = string.Empty;

	public bool Is开启;
}
