public class 地图限制列表类
{
	public string 地图名字 = string.Empty;

	public string 关键词 = string.Empty;

	public bool is消耗道具;

	public AllEnums.数值Type 消耗类型 = AllEnums.数值Type.道具;

	public string 消耗道具 = string.Empty;

	public int 消耗数量;

	public bool is限制组队;

	public bool is限制等级;

	public int 最低等级;

	public int 最高等级;

	public bool is限制道行;

	public int 最低道行;

	public int 最高道行;

	public bool is限制活跃;

	public int 最低活跃;

	public int 最高活跃;

	public bool is限制称号;

	public string 限主称号 = string.Empty;

	public string 限副称号 = string.Empty;
}
