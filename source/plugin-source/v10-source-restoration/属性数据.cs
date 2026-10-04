using System.Runtime.CompilerServices;

public struct 属性数据
{
	[CompilerGenerated]
	private int x2284ZJPDd;

	[CompilerGenerated]
	private int drJ8ekm0RO;

	[CompilerGenerated]
	private int ASy8q0EiVD;

	public int 属性类别
	{
		
		[CompilerGenerated]
		readonly get
		{
			return x2284ZJPDd;
		}
		
		[CompilerGenerated]
		set
		{
			x2284ZJPDd = value;
		}
	}

	public int 属性标识
	{
		
		[CompilerGenerated]
		readonly get
		{
			return drJ8ekm0RO;
		}
		
		[CompilerGenerated]
		set
		{
			drJ8ekm0RO = value;
		}
	}

	public int 属性数值
	{
		
		[CompilerGenerated]
		readonly get
		{
			return ASy8q0EiVD;
		}
		
		[CompilerGenerated]
		set
		{
			ASy8q0EiVD = value;
		}
	}

	
	public int 精炼属性筛选(AllEnums.精炼属性Type 类型)
	{
		if (类型 == AllEnums.精炼属性Type.改造属性 && 属性标识 == 220)
		{
			return -220;
		}
		if (类型 == AllEnums.精炼属性Type.改造属性 && 属性标识 == 7)
		{
			return -7;
		}
		if (类型 == AllEnums.精炼属性Type.改造属性 && 属性标识 == 8)
		{
			return -8;
		}
		if (类型 == AllEnums.精炼属性Type.改造属性 && 属性标识 == 3)
		{
			return -3;
		}
		if (类型 == AllEnums.精炼属性Type.改造属性 && 属性标识 == 10)
		{
			return -3;
		}
		return 属性标识;
	}

	
	public bool 精炼属性选中(AllEnums.精炼属性Type 类型, AllEnums.属性名字Type 属性名字)
	{
		if (类型 == AllEnums.精炼属性Type.改造属性)
		{
			if (属性名字 == AllEnums.属性名字Type.改造所有属性 && 属性标识 == 220)
			{
				return true;
			}
			if (属性名字 == AllEnums.属性名字Type.改造气血 && 属性标识 == 7)
			{
				return true;
			}
			if (属性名字 == AllEnums.属性名字Type.改造防御 && 属性标识 == 8)
			{
				return true;
			}
			if (属性名字 == AllEnums.属性名字Type.改造伤害 && (属性标识 == 3 || 属性标识 == 10))
			{
				return true;
			}
		}
		return 属性标识 == (int)属性名字;
	}

	
	public bool 鉴定属性筛选()
	{
		if (属性类别 == 2562 && 属性数值 != 0 && 问道数据类.特效类型字典.Contains(属性标识))
		{
			return true;
		}
		return false;
	}

	static 属性数据()
	{
	}
}
