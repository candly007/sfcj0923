using System.Runtime.CompilerServices;

public class 异兽录数据类
{
	public 异兽录存档数据类 方案1;

	public 异兽录存档数据类 方案2;

	
	public void 清空()
	{
		方案1.清空();
		方案2.清空();
	}

	
	public 异兽录数据类()
	{
		方案1 = new 异兽录存档数据类();
		方案2 = new 异兽录存档数据类();
	}

	static 异兽录数据类()
	{
	}
}
