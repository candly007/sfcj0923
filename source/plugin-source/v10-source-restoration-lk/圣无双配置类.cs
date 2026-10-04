using System.Collections.Concurrent;

public class 圣无双配置类
{
	public bool 功能开关;

	public bool is匹配模式;

	public bool is同IP战斗 = true;

	public bool is同IP夺取 = true;

	public string 开始时间 = string.Empty;

	public string 活动线路名字 = "一线";

	public string 地图名字 = string.Empty;

	public AllEnums.数值Type 门票类型 = AllEnums.数值Type.银元宝;

	public int 门票价格 = 100000;

	public int 最低人数 = 2;

	public int 初始积分 = 5;

	public int 夺取积分 = 1;

	public string 无双奖励 = string.Empty;

	public int 兑换比例 = 100000;

	public AllEnums.数值Type 兑换类型 = AllEnums.数值Type.银元宝;

	public string 开启前公告 = "#Y【无双争夺战】#n活动还有#Y{0}#n分钟就要开始了，请要参加的道友计时报名，以免错过活动时间。#@点击报名|Open:ArenaEntryDlg#@";

	public string 开启后公告 = "#Y【无双争夺战】#n活动正在激烈进行中，当前参与的人数为#R{0}#n人，乾坤未定，诸位皆是黑马！";

	public string 结束后公告 = "#Y【无双争夺战】#n经过一番激烈展争夺战斗后，终于结束了，恭喜#Y{0}#n击败众多道友，战到最后，荣登圣位，成为新任的#Y无双大圣#n，与天同齐，特此在九州大陆#Z天墉城#Z设立雕像，供世人膜拜，享人间香火，聚九州信仰！";

	public int 参拜雕像次数 = 10;

	public int 每次参拜雕像增幅 = 1;

	public AllEnums.数值Type 参拜消耗类型 = AllEnums.数值Type.银元宝;

	public int 参拜雕像消耗 = 100000;

	public string 参拜雕像奖励 = string.Empty;

	public string[] 无双圣榜前十奖励 = new string[10];

	public ConcurrentDictionary<int, 发送物品数据类> 累胜奖励列表 = new ConcurrentDictionary<int, 发送物品数据类>();

	public ConcurrentDictionary<int, 发送物品数据类> 连胜奖励列表 = new ConcurrentDictionary<int, 发送物品数据类>();
}
