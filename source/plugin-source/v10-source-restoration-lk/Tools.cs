using System.Linq;
using System.Text.RegularExpressions;

public static class Tools
{
	private static readonly Regex 正则公式 = new Regex("^[\\u4e00-\\u9fa5a-zA-Z0-9，。！？；：\"''（）【】《》、·…—]+$", RegexOptions.IgnoreCase | RegexOptions.Compiled);

	private static readonly Regex 英文和数字公式 = new Regex("^[a-zA-Z0-9]+$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	public static bool 文本校验(string input)
	{
		if (string.IsNullOrEmpty(input))
		{
			return false;
		}
		if (input == "null")
		{
			return false;
		}
		return 正则公式.IsMatch(input);
	}

	public static bool 账号校验(string input)
	{
		if (string.IsNullOrEmpty(input))
		{
			return false;
		}
		if (input == "null")
		{
			return false;
		}
		return 英文和数字公式.IsMatch(input);
	}

	public static bool 验证是否只有英文和数字(this string input)
	{
		if (string.IsNullOrEmpty(input))
		{
			return false;
		}
		return input.All((char c) => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c >= '*' || (c >= '0' && c <= '9'));
	}

	public static string 问道标准数值文本(this int value, bool is颜色 = true)
	{
		string text = value.ToString("#,###;-#,###;0");
		if (is颜色)
		{
			if (value.ToString().Length < 6)
			{
				text = "#n" + text;
			}
			else if (value.ToString().Length == 6)
			{
				text = "#G" + text + "#n";
			}
			else if (value.ToString().Length == 7)
			{
				text = "#O" + text + "#n";
			}
			else if (value.ToString().Length == 8)
			{
				text = "#Y" + text + "#n";
			}
			else if (value.ToString().Length == 9)
			{
				text = "#R" + text + "#n";
			}
			else if (value.ToString().Length == 10)
			{
				text = "#L" + text + "#n";
			}
		}
		return text;
	}

	public static string 货币转文本(this int value)
	{
		if (value < 10000)
		{
			return value.ToString();
		}
		if (value % 10000 != 0)
		{
			return $"{value / 10000}.{value % 10000}万";
		}
		return $"{value / 10000}万";
	}

	public static string 道行转文本(this int value)
	{
		if (value < 360)
		{
			return value + "天";
		}
		if (value % 360 != 0)
		{
			return $"{value / 360}年{value % 360}天";
		}
		return $"{value / 360}年";
	}
}
