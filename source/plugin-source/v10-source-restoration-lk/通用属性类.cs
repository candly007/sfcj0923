public class 通用属性类
{
	public AllEnums.属性名字Type 属性名字;

	public int 属性数值;

	public bool Is比例;

	public 通用属性类()
	{
	}

	public 通用属性类(AllEnums.属性名字Type 属性名字, int 属性数值)
	{
		this.属性名字 = 属性名字;
		this.属性数值 = 属性数值;
	}

	public 通用属性类(AllEnums.属性名字Type 属性名字, int 属性数值, bool is比例)
	{
		this.属性名字 = 属性名字;
		this.属性数值 = 属性数值;
		Is比例 = is比例;
	}
}
