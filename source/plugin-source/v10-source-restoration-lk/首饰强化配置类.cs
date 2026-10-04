using System.Collections.Generic;

public class 首饰强化配置类
{
	public bool 是否可用;

	public string 数值几率文本 = string.Empty;

	public List<int[]> 数值几率 = new List<int[]>();

	public void Init()
	{
		数值几率.Clear();
		if (string.IsNullOrWhiteSpace(数值几率文本))
		{
			return;
		}
		string[] array = 数值几率文本.Split("/");
		if (array.Length == 0)
		{
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split("=");
			if (array2.Length == 2 && int.TryParse(array2[0], out var result) && int.TryParse(array2[1], out var result2))
			{
				数值几率.Add(new int[2] { result, result2 });
			}
		}
	}
}
