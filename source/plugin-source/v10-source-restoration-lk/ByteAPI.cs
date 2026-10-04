using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

public class ByteAPI : Singleton<ByteAPI>
{
	public static string IsChinaToAsia = "China Standard Time";

	public static void SetChinaToAsia(bool IsWin)
	{
		IsChinaToAsia = (IsWin ? "China Standard Time" : "Asia/Shanghai");
	}

	public string ByteTo十六(byte[] buffer)
	{
		byte[] array = new byte[buffer.Length];
		Buffer.BlockCopy(buffer, 0, array, 0, buffer.Length);
		return BitConverter.ToString(array).Replace("-", "");
	}

	public byte[] 十六ToByte(int value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		return new byte[2]
		{
			bytes[1],
			bytes[0]
		};
	}

	public byte[] HtoC(int value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		return new byte[2]
		{
			bytes[1],
			bytes[0]
		};
	}

	public byte[] HtoC(string value)
	{
		return (from x in Enumerable.Range(0, value.Length / 2)
			select Convert.ToByte(value.Substring(x * 2, 2), 16)).ToArray();
	}

	public short 反转_短整数(byte[] buffer, int 位置, int 取数量)
	{
		byte[] array = new byte[取数量];
		for (int i = 0; i < 取数量; i++)
		{
			array[i] = buffer[位置 + 取数量 - 1 - i];
		}
		return BitConverter.ToInt16(array);
	}

	public short 反转_短整数(byte[] buffer)
	{
		byte[] array = new byte[buffer.Length];
		Buffer.BlockCopy(buffer, 0, array, 0, buffer.Length);
		Array.Reverse(array);
		return BitConverter.ToInt16(array);
	}

	public int 反转_整数(byte[] buffer, int 位置, int 取数量)
	{
		byte[] array = new byte[取数量];
		for (int i = 0; i < 取数量; i++)
		{
			array[i] = buffer[位置 + 取数量 - 1 - i];
		}
		return BitConverter.ToInt32(array);
	}

	public int 反转_整数(byte[] buffer)
	{
		byte[] array = new byte[4];
		for (int i = 0; i < 4; i++)
		{
			array[i] = buffer[3 - i];
		}
		return BitConverter.ToInt32(array);
	}

	public int 取字节集数据(byte[] buffer, int 取出类型 = 3, int 位置 = 0)
	{
		switch (取出类型)
		{
		case 1:
			return buffer[位置];
		case 2:
			return BitConverter.ToInt16(buffer, 位置);
		default:
			_ = 3;
			return BitConverter.ToInt32(buffer, 位置);
		}
	}

	public string 取字节集数据(byte[] buffer, int 位置 = 0)
	{
		try
		{
			return BitConverter.ToString(buffer, 位置);
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public byte[] 反转_字节集(byte[] buffer)
	{
		byte[] array = new byte[buffer.Length];
		Buffer.BlockCopy(buffer, 0, array, 0, buffer.Length);
		Array.Reverse(array);
		return array;
	}

	public byte[] 取字节集中间(byte[] buffer, int 位置, int 数量)
	{
		return buffer.Skip(位置).Take(数量).ToArray();
	}

	public byte[] 取字节集中间(byte[] data, byte[] startData, byte[] endData, bool contain = false)
	{
		int num = IndexOf(data, startData);
		int num2 = IndexOf(data, endData);
		if (num != -1 && num2 != -1)
		{
			int num3 = 0;
			if (contain)
			{
				num3 = num2 + endData.Length - num;
			}
			else
			{
				num += startData.Length;
				num3 = num2 - num;
			}
			return data.Skip(num).Take(num3).ToArray();
		}
		return null;
	}

	public int IndexOf(byte[] data, byte[] find)
	{
		for (int i = 0; i < data.Length - find.Length; i++)
		{
			if (data.Skip(i).Take(find.Length).SequenceEqual(find))
			{
				return i;
			}
		}
		return -1;
	}

	public byte[] 取字节集左边(byte[] buffer, int 数量)
	{
		return buffer.Skip(0).Take(数量).ToArray();
	}

	public byte[] 取字节集右边(byte[] buffer, int 数量)
	{
		return buffer.Skip(buffer.Length - 数量).Take(数量).ToArray();
	}

	public string GetHexGid_(int Gid)
	{
		return $"00000000{Gid:X8}";
	}

	public string 取文本中间(string value, string start, string end)
	{
		int num = value.IndexOf(start) + start.Length;
		int num2 = (string.IsNullOrWhiteSpace(end) ? value.Length : value.IndexOf(end, num));
		if (num < 0 || num2 <= num)
		{
			return "";
		}
		return value.Substring(num, num2 - num);
	}

	public string 文本_取出中间文本(string 总文本, string 文本前缀, string 文本后缀, int beginIndex = 0)
	{
		try
		{
			int num = 总文本.IndexOf(文本前缀, beginIndex) + 文本前缀.Length;
			int num2 = 总文本.IndexOf(文本后缀, num);
			return 总文本.Substring(num, num2 - num);
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public string 文本_取出中间文本(string 总文本, string 文本前缀, string 文本后缀, out int endIndex)
	{
		endIndex = 总文本.Length;
		try
		{
			int num = 总文本.IndexOf(文本前缀, 0) + 文本前缀.Length;
			endIndex = 总文本.IndexOf(文本后缀, num);
			return 总文本.Substring(num, endIndex - num);
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public string 取文本左边(string input, string 查找文本)
	{
		int num = input.IndexOf(查找文本);
		if (num > 0)
		{
			return input.Substring(0, num + 查找文本.Length);
		}
		return input;
	}

	public string 取文本左边(string input, int length)
	{
		if (input.Length < length)
		{
			return input;
		}
		return input.Substring(0, length);
	}

	public string 取文本右边(string input, int length)
	{
		if (string.IsNullOrEmpty(input) || length <= 0)
		{
			return string.Empty;
		}
		if (input.Length <= length)
		{
			return input;
		}
		return input.Substring(input.Length - length);
	}

	public long 取时间戳(bool 是否到秒 = true)
	{
		DateTimeOffset dateTimeOffset = TimeZoneInfo.ConvertTime(DateTimeOffset.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Asia/Shanghai"));
		if (!是否到秒)
		{
			return dateTimeOffset.ToUnixTimeMilliseconds();
		}
		return dateTimeOffset.ToUnixTimeSeconds();
	}

	public long 取时间戳(DateTimeOffset value1, bool 是否到秒 = true, int 分钟 = 0, int 小时 = 0, int 天数 = 0, int 月数 = 0, int 年数 = 0)
	{
		if (value1 != DateTimeOffset.MinValue)
		{
			DateTimeOffset dateTimeOffset = TimeZoneInfo.ConvertTime(value1, TimeZoneInfo.FindSystemTimeZoneById("Asia/Shanghai"));
			if (分钟 != 0)
			{
				dateTimeOffset = dateTimeOffset.AddMinutes(分钟);
			}
			if (小时 != 0)
			{
				dateTimeOffset = dateTimeOffset.AddHours(小时);
			}
			if (天数 != 0)
			{
				dateTimeOffset = dateTimeOffset.AddDays(天数);
			}
			if (月数 != 0)
			{
				dateTimeOffset = dateTimeOffset.AddMonths(月数);
			}
			if (年数 != 0)
			{
				dateTimeOffset = dateTimeOffset.AddYears(年数);
			}
			if (!是否到秒)
			{
				return dateTimeOffset.ToUnixTimeMilliseconds();
			}
			return dateTimeOffset.ToUnixTimeSeconds();
		}
		return 0L;
	}

	public long 取时间戳(string value2, bool 是否到秒 = true, int 分钟 = 0, int 小时 = 0, int 天数 = 0, int 月数 = 0, int 年数 = 0)
	{
		if (!string.IsNullOrWhiteSpace(value2) && DateTimeOffset.TryParse(value2, out var result))
		{
			if (分钟 != 0)
			{
				result = result.AddMinutes(分钟);
			}
			if (小时 != 0)
			{
				result = result.AddHours(小时);
			}
			if (天数 != 0)
			{
				result = result.AddDays(天数);
			}
			if (月数 != 0)
			{
				result = result.AddMonths(月数);
			}
			if (年数 != 0)
			{
				result = result.AddYears(年数);
			}
			if (!是否到秒)
			{
				return result.ToUnixTimeMilliseconds();
			}
			return result.ToUnixTimeSeconds();
		}
		return 0L;
	}

	public long 取时间戳(long 当前时间戳, bool 是否到秒 = true, int 分钟 = 0, int 小时 = 0, int 天数 = 0, int 月数 = 0, int 年数 = 0)
	{
		if (当前时间戳 != 0L)
		{
			DateTimeOffset dateTimeOffset = 取时间(时间戳是否到秒: true, 当前时间戳);
			if (分钟 != 0)
			{
				dateTimeOffset = dateTimeOffset.AddMinutes(分钟);
			}
			if (小时 != 0)
			{
				dateTimeOffset = dateTimeOffset.AddHours(小时);
			}
			if (天数 != 0)
			{
				dateTimeOffset = dateTimeOffset.AddDays(天数);
			}
			if (月数 != 0)
			{
				dateTimeOffset = dateTimeOffset.AddMonths(月数);
			}
			if (年数 != 0)
			{
				dateTimeOffset = dateTimeOffset.AddYears(年数);
			}
			if (!是否到秒)
			{
				return dateTimeOffset.ToUnixTimeMilliseconds();
			}
			return dateTimeOffset.ToUnixTimeSeconds();
		}
		return 0L;
	}

	public DateTimeOffset 取时间(bool 时间戳是否到秒, long 时间戳)
	{
		if (时间戳 != 0L)
		{
			return TimeZoneInfo.ConvertTime(时间戳是否到秒 ? DateTimeOffset.FromUnixTimeSeconds(时间戳) : DateTimeOffset.FromUnixTimeMilliseconds(时间戳), TimeZoneInfo.FindSystemTimeZoneById(IsChinaToAsia));
		}
		return TimeZoneInfo.ConvertTime(DateTimeOffset.UtcNow, TimeZoneInfo.FindSystemTimeZoneById(IsChinaToAsia));
	}

	public DateTimeOffset 取时间(string 时间文本)
	{
		if (!string.IsNullOrWhiteSpace(时间文本) && DateTimeOffset.TryParse(时间文本, out var result))
		{
			return TimeZoneInfo.ConvertTime(result, TimeZoneInfo.FindSystemTimeZoneById(IsChinaToAsia));
		}
		return TimeZoneInfo.ConvertTime(DateTimeOffset.UtcNow, TimeZoneInfo.FindSystemTimeZoneById(IsChinaToAsia));
	}

	public DateTimeOffset 取时间(DateTimeOffset 当前时间, int 分钟 = 0, int 小时 = 0, int 天数 = 0, int 月数 = 0, int 年数 = 0)
	{
		if (分钟 != 0)
		{
			当前时间 = 当前时间.AddMinutes(分钟);
		}
		if (小时 != 0)
		{
			当前时间 = 当前时间.AddHours(小时);
		}
		if (天数 != 0)
		{
			当前时间 = 当前时间.AddDays(天数);
		}
		if (月数 != 0)
		{
			当前时间 = 当前时间.AddMonths(月数);
		}
		if (年数 != 0)
		{
			当前时间 = 当前时间.AddYears(年数);
		}
		return 当前时间;
	}

	public string 取时间文本(bool 是否带秒 = true, bool 有无日期 = true)
	{
		return 取时间(时间戳是否到秒: true, 0L).ToString((!是否带秒) ? (有无日期 ? "yyyy年MM月dd日HH时mm分" : "yyyy-MM-dd HH:mm") : (有无日期 ? "yyyy年MM月dd日HH时mm分ss秒" : "yyyy-MM-dd HH:mm:ss"));
	}

	public string 取时间文本(long 时间戳, bool 是否带秒 = true, bool 有无日期 = true)
	{
		return 取时间(时间戳是否到秒: true, 时间戳).ToString((!是否带秒) ? (有无日期 ? "yyyy年MM月dd日HH时mm分" : "yyyy-MM-dd HH:mm") : (有无日期 ? "yyyy年MM月dd日HH时mm分ss秒" : "yyyy-MM-dd HH:mm:ss"));
	}

	public string 取时间文本(DateTimeOffset 时间, bool 是否带秒 = true, bool 有无日期 = true)
	{
		return 时间.ToString((!是否带秒) ? (有无日期 ? "yyyy年MM月dd日HH时mm分" : "yyyy-MM-dd HH:mm") : (有无日期 ? "yyyy年MM月dd日HH时mm分ss秒" : "yyyy-MM-dd HH:mm:ss"));
	}

	public string 取时间文本(string 时间, bool 是否带秒 = true, bool 有无日期 = true)
	{
		return 取时间(时间).ToString((!是否带秒) ? (有无日期 ? "yyyy年MM月dd日HH时mm分" : "yyyy-MM-dd HH:mm") : (有无日期 ? "yyyy年MM月dd日HH时mm分ss秒" : "yyyy-MM-dd HH:mm:ss"));
	}

	public byte[] 到字节集(string value)
	{
		return Encoding.GetEncoding("GB2312").GetBytes(value);
	}

	public byte[] 到字节集(int value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		return new byte[2]
		{
			bytes[1],
			bytes[0]
		};
	}

	public byte[] 到字节集短整数(short value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		return new byte[2]
		{
			bytes[1],
			bytes[0]
		};
	}

	public byte[] 还原字节集(int value)
	{
		return new byte[1] { (byte)value };
	}

	public byte[] 还原字节集(int value, int 保留位数)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		if (bytes.Length < 保留位数)
		{
			for (int i = bytes.Length; i < 保留位数; i++)
			{
				((IEnumerable<byte>)bytes).Append((byte)0);
			}
		}
		Array.Reverse(bytes);
		return bytes;
	}

	public byte[] 到字节集反转(int value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		Array.Reverse(bytes);
		return bytes;
	}

	public byte[] 到字节集反转(int value, int 保留位数 = 4)
	{
		byte[] array = BitConverter.GetBytes(value);
		Array.Reverse(array);
		switch (保留位数)
		{
		case 4:
			if (array.Length == 2)
			{
				array = AddByte(new byte[2], array);
			}
			else if (array.Length == 3)
			{
				array = AddByte(new byte[1], array);
			}
			break;
		case 2:
			if (array.Length == 4)
			{
				return new byte[2]
				{
					array[2],
					array[3]
				};
			}
			break;
		}
		return array;
	}

	public byte[] 到字节集固定反转(int value)
	{
		byte[] array = BitConverter.GetBytes(value);
		Array.Reverse(array);
		if (array.Length == 2)
		{
			array = AddByte(new byte[2], array);
		}
		else if (array.Length == 3)
		{
			array = AddByte(new byte[1], array);
		}
		return array;
	}

	public string 到文本(byte[] buffer)
	{
		return Encoding.GetEncoding("GB2312").GetString(buffer);
	}

	public string 到文本存储(byte[] buffer)
	{
		return string.Join(",", buffer);
	}

	public int 到整数(byte[] buffer)
	{
		byte[] array = new byte[4];
		for (int i = 0; i < 4; i++)
		{
			array[i] = buffer[3 - i];
		}
		return BitConverter.ToInt32(array);
	}

	public short 到短整数(byte[] buffer)
	{
		return BitConverter.ToInt16(new byte[2]
		{
			buffer[1],
			buffer[0]
		});
	}

	public bool 寻找文本(string buffer, string value)
	{
		return buffer.IndexOf(value) != -1;
	}

	public bool 寻找文本或(string buffer, params string[] value)
	{
		return value.Any((string x) => buffer.Contains(x, StringComparison.CurrentCulture));
	}

	public bool 寻找文本或(string buffer, string value1, string value2)
	{
		if (buffer.IndexOf(value1) == -1)
		{
			return buffer.IndexOf(value2) != -1;
		}
		return true;
	}

	public bool 寻找文本或(string buffer, string value1, string value2, string value3)
	{
		if (buffer.IndexOf(value1) == -1 && buffer.IndexOf(value2) == -1)
		{
			return buffer.IndexOf(value3) != -1;
		}
		return true;
	}

	public bool 寻找文本与(string buffer, params string[] value)
	{
		return value.All((string x) => buffer.Contains(x, StringComparison.CurrentCulture));
	}

	public bool 寻找文本与(string buffer, string value1, string value2)
	{
		if (buffer.IndexOf(value1) != -1)
		{
			return buffer.IndexOf(value2) != -1;
		}
		return false;
	}

	public bool 寻找文本与(string buffer, string value1, string value2, string value3)
	{
		if (buffer.IndexOf(value1) != -1 && buffer.IndexOf(value2) != -1)
		{
			return buffer.IndexOf(value3) != -1;
		}
		return false;
	}

	public bool 寻找文本等(string buffer, params string[] value)
	{
		return value.Any((string x) => buffer == x);
	}

	public byte[] 子字节集指定替换(byte[] buffer, int 位置, int 数量, byte[] 替换值)
	{
		byte[] first = 取字节集左边(buffer, 位置);
		return Enumerable.Concat(second: 取字节集右边(buffer, buffer.Length - (位置 + 替换值.Length)), first: first.Concat(替换值)).ToArray();
	}

	public byte[] 寻找字节集并替换(byte[] buffer, byte[] 查询, byte[] 替换)
	{
		try
		{
			int num = 寻找字节集下标(buffer, 查询);
			if (num > -1)
			{
				buffer = 子字节集指定替换(buffer, num, 查询.Length, 替换);
			}
			return buffer;
		}
		catch (Exception)
		{
			return buffer;
		}
	}

	public int 寻找字节集下标(byte[] buffer, byte[] value)
	{
		for (int i = 0; i < buffer.Length - value.Length + 1; i++)
		{
			bool flag = true;
			for (int j = 0; j < value.Length; j++)
			{
				if (buffer[i + j] != value[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return i;
			}
		}
		return -1;
	}

	public bool 寻找字节集(byte[] buffer, byte[] value)
	{
		return string.Join(",", buffer).IndexOf(string.Join(",", value)) != -1;
	}

	public bool 寻找字节集(byte[] buffer, byte[] value1, byte[] value2)
	{
		if (string.Join(",", buffer).IndexOf(string.Join(",", value1)) != -1)
		{
			return string.Join(",", buffer).IndexOf(string.Join(",", value2)) != -1;
		}
		return false;
	}

	public bool 寻找字节集或(byte[] buffer, byte[] value1, byte[] value2)
	{
		if (string.Join(",", buffer).IndexOf(string.Join(",", value1)) == -1)
		{
			return string.Join(",", buffer).IndexOf(string.Join(",", value2)) != -1;
		}
		return true;
	}

	public bool 寻找字节集或(byte[] buffer, byte[] value1, byte[] value2, byte[] value3)
	{
		if (string.Join(",", buffer).IndexOf(string.Join(",", value1)) == -1 && string.Join(",", buffer).IndexOf(string.Join(",", value2)) == -1)
		{
			return string.Join(",", buffer).IndexOf(string.Join(",", value3)) != -1;
		}
		return true;
	}

	public bool 寻找字节集或(byte[] buffer, byte[] value1, byte[] value2, byte[] value3, byte[] value4)
	{
		if (string.Join(",", buffer).IndexOf(string.Join(",", value1)) == -1 && string.Join(",", buffer).IndexOf(string.Join(",", value2)) == -1 && string.Join(",", buffer).IndexOf(string.Join(",", value3)) == -1)
		{
			return string.Join(",", buffer).IndexOf(string.Join(",", value4)) != -1;
		}
		return true;
	}

	public bool 寻找字节集或(byte[] buffer, byte[] value1, byte[] value2, byte[] value3, byte[] value4, byte[] value5)
	{
		if (string.Join(",", buffer).IndexOf(string.Join(",", value1)) == -1 && string.Join(",", buffer).IndexOf(string.Join(",", value2)) == -1 && string.Join(",", buffer).IndexOf(string.Join(",", value3)) == -1 && string.Join(",", buffer).IndexOf(string.Join(",", value4)) == -1)
		{
			return string.Join(",", buffer).IndexOf(string.Join(",", value5)) != -1;
		}
		return true;
	}

	public bool 寻找字节集(byte[] buffer, string value)
	{
		string text = string.Join(",", Encoding.GetEncoding("GB2312").GetBytes(value));
		return string.Join(",", buffer).IndexOf(string.Join(",", text)) != -1;
	}

	public bool 寻找字节集(byte[] buffer, string value1, string value2)
	{
		string text = string.Join(",", Encoding.GetEncoding("GB2312").GetBytes(value1));
		string text2 = string.Join(",", Encoding.GetEncoding("GB2312").GetBytes(value1));
		if (string.Join(",", buffer).IndexOf(string.Join(",", text)) != -1)
		{
			return string.Join(",", buffer).IndexOf(string.Join(",", text2)) != -1;
		}
		return false;
	}

	public byte[] AddByte(byte[] byte1, byte[] byte2)
	{
		return byte1.Concat(byte2).ToArray();
	}

	public byte[] AddByte(byte[] byte1, byte[] byte2, byte[] byte3)
	{
		return byte1.Concat(byte2).Concat(byte3).ToArray();
	}

	public byte[] AddByte(byte[] byte1, byte[] byte2, byte[] byte3, byte[] byte4)
	{
		return byte1.Concat(byte2).Concat(byte3).Concat(byte4)
			.ToArray();
	}

	public byte[] AddByte(byte[] byte1, byte[] byte2, byte[] byte3, byte[] byte4, byte[] byte5)
	{
		return byte1.Concat(byte2).Concat(byte3).Concat(byte4)
			.Concat(byte5)
			.ToArray();
	}

	public byte[] AddByte(byte[] byte1, byte[] byte2, byte[] byte3, byte[] byte4, byte[] byte5, byte[] byte6)
	{
		return byte1.Concat(byte2).Concat(byte3).Concat(byte4)
			.Concat(byte5)
			.Concat(byte6)
			.ToArray();
	}

	public byte[] AddByte(byte[] byte1, byte[] byte2, byte[] byte3, byte[] byte4, byte[] byte5, byte[] byte6, byte[] byte7)
	{
		return byte1.Concat(byte2).Concat(byte3).Concat(byte4)
			.Concat(byte5)
			.Concat(byte6)
			.Concat(byte7)
			.ToArray();
	}

	public byte[] AddByte(byte[] byte1, byte[] byte2, byte[] byte3, byte[] byte4, byte[] byte5, byte[] byte6, byte[] byte7, byte[] byte8)
	{
		return byte1.Concat(byte2).Concat(byte3).Concat(byte4)
			.Concat(byte5)
			.Concat(byte6)
			.Concat(byte7)
			.Concat(byte8)
			.ToArray();
	}

	public int 取启动时间()
	{
		try
		{
			return (int)Stopwatch.StartNew().Elapsed.TotalMilliseconds;
		}
		catch (Exception)
		{
			return 0;
		}
	}

	public static List<byte[]> 分割字节集(byte[] source, byte[] separator)
	{
		List<byte[]> result = new List<byte[]>();
		int num = 0;
		while (true)
		{
			int num2 = FindSequence(source, separator, num);
			if (num2 == -1)
			{
				break;
			}
			AddSubArray(source, num, num2 - num, result);
			num = num2 + separator.Length;
		}
		AddSubArray(source, num, source.Length - num, result);
		return result;
	}

	private static int FindSequence(byte[] source, byte[] separator, int startIndex)
	{
		for (int i = startIndex; i <= source.Length - separator.Length; i++)
		{
			bool flag = true;
			for (int j = 0; j < separator.Length; j++)
			{
				if (source[i + j] != separator[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return i;
			}
		}
		return -1;
	}

	private static void AddSubArray(byte[] source, int start, int length, List<byte[]> result)
	{
		byte[] array = new byte[length];
		Array.Copy(source, start, array, 0, length);
		result.Add(array);
	}

	public static byte[] IntToBytes(int value)
	{
		byte[] array = new byte[4];
		BinaryPrimitives.WriteInt32BigEndian(array, value);
		return array;
	}

	public static int BytesToInt(byte[] bytes)
	{
		if (bytes == null || bytes.Length < 4)
		{
			throw new ArgumentException("Invalid byte array");
		}
		return BinaryPrimitives.ReadInt32BigEndian(bytes);
	}
}
