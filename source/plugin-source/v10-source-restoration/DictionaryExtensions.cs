using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static class DictionaryExtensions
{
	
	public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
	{
		if (!dictionary.TryGetValue(key, out var value))
		{
			return defaultValue;
		}
		return value;
	}

	static DictionaryExtensions()
	{
	}
}
