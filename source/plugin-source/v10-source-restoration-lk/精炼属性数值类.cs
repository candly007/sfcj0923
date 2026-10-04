using System.Collections.Generic;
using System.Text;

public class 精炼属性数值类
{
	public AllEnums.属性名字Type 属性名字;

	public int 最小值;

	public int 最大值;

	public List<通用次数类> 数值次数 = new List<通用次数类>();

	public int 浮动率;

	public bool 蓝属性可精炼 = true;

	public bool 粉属性可精炼 = true;

	public bool 黄属性可精炼 = true;

	public bool 绿属性可精炼 = true;

	public bool 封属性可精炼 = true;

	public bool 改属性可精炼 = true;

	public string 转换文本()
	{
		if (数值次数.Count <= 0)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < 数值次数.Count; i++)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(2, 2, stringBuilder2);
			handler.AppendLiteral("/");
			handler.AppendFormatted(数值次数[i].数值);
			handler.AppendLiteral("=");
			handler.AppendFormatted(数值次数[i].次数);
			stringBuilder2.Append(ref handler);
		}
		stringBuilder.Remove(0, 1);
		return stringBuilder.ToString();
	}

	public void 转换实例(string wenben)
	{
		if (string.IsNullOrWhiteSpace(wenben))
		{
			return;
		}
		string[] array = wenben.Split("/");
		if (array.Length == 0)
		{
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrWhiteSpace(array[i]))
			{
				string[] array2 = array[i].Split("=");
				if (array2.Length == 2 && int.TryParse(array2[0], out var result) && int.TryParse(array2[1], out var result2))
				{
					数值次数.Add(new 通用次数类
					{
						数值 = result,
						次数 = result2
					});
				}
			}
		}
	}

	public bool Is符合条件(AllEnums.精炼属性Type 精炼属性)
	{
		switch (精炼属性)
		{
		case AllEnums.精炼属性Type.无:
			return false;
		case AllEnums.精炼属性Type.蓝属性:
			if (蓝属性可精炼)
			{
				return true;
			}
			break;
		}
		if (精炼属性 == AllEnums.精炼属性Type.粉属性 && 粉属性可精炼)
		{
			return true;
		}
		if (精炼属性 == AllEnums.精炼属性Type.黄属性 && 黄属性可精炼)
		{
			return true;
		}
		if (精炼属性 == AllEnums.精炼属性Type.绿属性 && 绿属性可精炼)
		{
			return true;
		}
		if (精炼属性 == AllEnums.精炼属性Type.封印属性 && 封属性可精炼)
		{
			return true;
		}
		if (精炼属性 == AllEnums.精炼属性Type.改造属性 && 改属性可精炼)
		{
			return true;
		}
		return false;
	}

	public bool Is数值校验(int 当前值)
	{
		if (当前值 < 最小值)
		{
			return 当前值 < 最大值;
		}
		return true;
	}
}
