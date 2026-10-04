using System.Collections.Generic;

public class 宠物存档数据类
{
	public string IID = string.Empty;

	public bool is同源激活;

	public int 转属次数;

	public List<宠物同源数据类> 同源属性 = new List<宠物同源数据类>();
}
