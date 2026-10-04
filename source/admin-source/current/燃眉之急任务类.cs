public class 燃眉之急任务类
{
	public string 当前NPC = string.Empty;

	public int 当前NPCID;

	public int 当前NPC形象ID;

	public int 对话计数器;

	public int 任务类型;

	public int 任务星级;

	public int 任务次数;

	public void 下线清空()
	{
		当前NPC = string.Empty;
		当前NPCID = 0;
		当前NPC形象ID = 0;
		对话计数器 = 0;
		任务类型 = 0;
		任务星级 = 0;
	}
}
