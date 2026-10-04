using System;

public class 百炼列表类 : IComparable
{
	public int 权重值;

	public string 炼化道具 = string.Empty;

	public bool Is叠加道具;

	public int 炼化数量 = 1;

	public int 提交格子数量 = 1;

	public string[] 提交数组 = new string[10];

	public string 对话文本 = "请放入正确的材料";

	public int 炼化几率 = 100;

	public int CompareTo(object? obj)
	{
		if (!(obj is 百炼列表类 百炼列表类2))
		{
			throw new ArgumentException("Object is not a Person");
		}
		return 权重值.CompareTo(百炼列表类2.权重值);
	}
}
