using System.Runtime.CompilerServices;

public class 妖族化形数据类
{
	public ushort 化形值;

	public ushort 已化形回合数;

	public bool Is已化形;

	
	public void Close()
	{
		化形值 = 0;
		已化形回合数 = 0;
		Is已化形 = false;
	}

	
	public 妖族化形数据类()
	{
	}

	static 妖族化形数据类()
	{
	}
}
