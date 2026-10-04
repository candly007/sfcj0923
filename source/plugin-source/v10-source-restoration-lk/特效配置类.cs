using System.Collections.Generic;

public class 特效配置类
{
	public bool 功能开关;

	public bool 绑定装备才可鉴定;

	public int[] 使用装备等级 = new int[2] { 0, 999 };

	public string 鉴定特效道具 = string.Empty;

	public int 鉴定花费道具数量;

	public int 鉴定成功几率;

	public int 失败装备爆炸几率;

	public string 爆炸补偿道具 = string.Empty;

	public int 爆炸补偿道具数量;

	public List<特效列表类> 特效列表 = new List<特效列表类>();
}
