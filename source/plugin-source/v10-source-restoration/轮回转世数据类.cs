using System.Runtime.CompilerServices;

public class 轮回转世数据类
{
	internal bool qkVIsPyWCW;

	public 六道轮回存档数据类 存档方案1;

	public 六道轮回存档数据类 存档方案2;

	
	public void 清空()
	{
		qkVIsPyWCW = false;
		存档方案1.清空();
		存档方案2.清空();
	}

	
	public 轮回转世数据类()
	{
		存档方案1 = new 六道轮回存档数据类();
		存档方案2 = new 六道轮回存档数据类();
	}

	static 轮回转世数据类()
	{
	}
}
