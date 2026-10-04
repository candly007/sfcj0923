public class 六道轮回配置类
{
	public bool 功能开关;

	public bool 定制功能开关;

	public string 特效道具 = string.Empty;

	public string npc名字 = string.Empty;

	public int npc形象;

	public string 首级对话选项 = string.Empty;

	public int 最低需求等级 = 1;

	public int 刷新价格 = 100000;

	public AllEnums.数值Type 刷新类型 = AllEnums.数值Type.银元宝;

	public 六道轮回列表类[] 六道轮回列表 = new 六道轮回列表类[6];
}
