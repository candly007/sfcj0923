using System.Runtime.CompilerServices;

public class 限时属性类
{
	public AllEnums.属性Type 属性类型;

	public int 实际数值;

	public int 到期时间;

	
	public 限时属性类()
	{
		属性类型 = AllEnums.属性Type.等级;
	}

	static 限时属性类()
	{
	}
}
