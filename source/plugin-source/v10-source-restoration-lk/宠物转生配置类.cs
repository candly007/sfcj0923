using System.Collections.Generic;

public class 宠物转生配置类
{
	public bool 功能开关;

	public NPC数据类 NPC数据 = new NPC数据类(110, "转生天尊", "宠物、人物转生点我", new 坐标类(241, 197), 7, 6001, "天上白玉京，十二楼五城。仙人抚我顶，结发授长生。误逐世间乐，颇穷理乱情。九十六圣君，浮云挂空名。");

	public int 宠物最大转生次数 = 9;

	public string 转生洗髓道具 = "转生洗髓丹";

	public int 转生洗髓几率 = 1;

	public List<宠物转生列表类> 转生阶段 = new List<宠物转生列表类>();
}
