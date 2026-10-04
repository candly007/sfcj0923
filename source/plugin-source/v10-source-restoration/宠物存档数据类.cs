using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class 宠物存档数据类
{
	public string IID;

	public bool is同源激活;

	public int 转属次数;

	public List<宠物同源数据类> 同源属性;

	public 宠物转生数据类 转生数据;

	
	public 宠物存档数据类()
	{
		IID = string.Empty;
		同源属性 = new List<宠物同源数据类>();
		转生数据 = new 宠物转生数据类();
	}

	static 宠物存档数据类()
	{
	}
}
