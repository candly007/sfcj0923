public class 浮生录数据类
{
	public 浮生录存档类 方案1 = new 浮生录存档类();

	public 浮生录存档类 方案2 = new 浮生录存档类();

	public int 抽取次数;

	public void 清空()
	{
		抽取次数 = 0;
		方案1.is全部激活 = false;
		方案1.化身列表.Clear();
		方案1.浮生属性.Clear();
		方案2.is全部激活 = false;
		方案2.化身列表.Clear();
		方案2.浮生属性.Clear();
	}
}
