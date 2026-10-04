using System.Collections.Concurrent;

public class 娃娃配置类
{
	public bool 功能开关;

	public bool 一键喂养 = true;

	public string 亲密道具 = string.Empty;

	public int 增加亲密 = 100000;

	public int 亲密上限 = 100000;

	public int 门派上限 = 5;

	public bool 技能最大等级跟随娃娃等级;

	public bool 随机遗忘;

	public string 遗忘道具 = string.Empty;

	public bool 随机拜师;

	public string 门派道具 = string.Empty;

	public string 五系娃娃速成道具 = string.Empty;

	public ConcurrentDictionary<string, 娃娃技能列表类> 技能列表 = new ConcurrentDictionary<string, 娃娃技能列表类>();
}
