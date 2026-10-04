using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

public class 中州论道存档类
{
	public ConcurrentDictionary<AllEnums.属性名字Type, int> 属性列表;

	public ConcurrentDictionary<AllEnums.属性名字Type, int[]> 限时属性列表;

	
	internal void jxpIgn1imh(AllEnums.属性名字Type P_0, int P_1, out string P_2)
	{
		if (属性列表.ContainsKey(P_0))
		{
			属性列表[P_0] += P_1;
			P_2 = $"{属性列表[P_0]}";
		}
		else
		{
			属性列表.TryAdd(P_0, P_1);
			P_2 = $"{P_1}";
		}
	}

	
	internal void T4pIDVRjDx(AllEnums.属性名字Type P_0, int P_1, int P_2)
	{
		if (!限时属性列表.TryGetValue(P_0, out var value))
		{
			value = new int[2]
			{
				P_1,
				(int)Singleton<ByteAPI>.I.取时间戳((int)Singleton<ByteAPI>.I.取时间戳(), 是否到秒: true, P_2)
			};
			限时属性列表.TryAdd(P_0, value);
		}
		else
		{
			value[1] = (int)Singleton<ByteAPI>.I.取时间戳(value[1], 是否到秒: true, P_2);
			限时属性列表[P_0] = value;
		}
	}

	
	public 中州论道存档类()
	{
		属性列表 = new ConcurrentDictionary<AllEnums.属性名字Type, int>();
		限时属性列表 = new ConcurrentDictionary<AllEnums.属性名字Type, int[]>();
	}

	static 中州论道存档类()
	{
	}
}
