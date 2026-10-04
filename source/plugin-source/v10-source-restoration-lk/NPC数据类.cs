public class NPC数据类
{
	public int npcid;

	public string npc名字 = string.Empty;

	public string npc称号 = string.Empty;

	public 坐标类 坐标 = new 坐标类();

	public short 朝向;

	public int npc形象;

	public string 对话文本 = string.Empty;

	public NPC数据类()
	{
	}

	public NPC数据类(int npcid, string npc名字, string npc称号, 坐标类 坐标, short 朝向, int npc形象)
	{
		this.npcid = npcid;
		this.npc名字 = npc名字;
		this.npc称号 = npc称号;
		this.坐标 = 坐标;
		this.朝向 = 朝向;
		this.npc形象 = npc形象;
	}

	public NPC数据类(int npcid, string npc名字, string npc称号, 坐标类 坐标, short 朝向, int npc形象, string 对话文本)
	{
		this.npcid = npcid;
		this.npc名字 = npc名字;
		this.npc称号 = npc称号;
		this.坐标 = 坐标;
		this.朝向 = 朝向;
		this.npc形象 = npc形象;
		this.对话文本 = 对话文本;
	}
}
