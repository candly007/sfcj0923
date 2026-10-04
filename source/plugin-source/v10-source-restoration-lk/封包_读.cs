using System;
using System.IO;
using System.Text;

public class 封包_读 : MemoryStream
{
	public 封包_读(byte[] buffer)
		: base(buffer)
	{
	}

	public 封包_读(byte[] buffer, int offset, int count)
		: base(buffer, offset, count)
	{
	}

	public int 读字节型()
	{
		return ReadByte();
	}

	public int 读字节型(out int value)
	{
		value = ReadByte();
		return value;
	}

	public string 读文本型(bool 是否声明长度 = true, byte 长度字节类型 = 0, bool 是否反转长度 = false)
	{
		if (是否声明长度)
		{
			int num;
			switch (长度字节类型)
			{
			case 0:
				num = ReadByte();
				break;
			case 1:
				num = 读短整数型(是否反转长度);
				break;
			case 2:
				num = 读整数型(是否反转长度);
				break;
			default:
				return "";
			}
			byte[] array = new byte[num];
			Read(array, 0, num);
			return Encoding.GetEncoding("GB2312").GetString(array);
		}
		return "";
	}

	public string 读文本型(out byte[] 原字节, bool headCount = true, byte type = 0, bool reverse = false)
	{
		原字节 = Array.Empty<byte>();
		if (headCount)
		{
			int num;
			switch (type)
			{
			case 0:
				num = ReadByte();
				break;
			case 1:
				num = 读短整数型(reverse);
				break;
			case 2:
				num = 读整数型(reverse);
				break;
			default:
				return "";
			}
			byte[] array = new byte[num];
			Read(array, 0, num);
			原字节 = array;
			return Encoding.GetEncoding("GB2312").GetString(array);
		}
		return "";
	}

	public string 读文本型(out string value, bool headCount = true, byte type = 0, bool reverse = false)
	{
		value = "";
		if (headCount)
		{
			int num;
			switch (type)
			{
			case 0:
				num = ReadByte();
				break;
			case 1:
				num = 读短整数型(reverse);
				break;
			case 2:
				num = 读整数型(reverse);
				break;
			default:
				return value;
			}
			byte[] array = new byte[num];
			Read(array, 0, num);
			value = Encoding.GetEncoding("GB2312").GetString(array);
			return value;
		}
		return value;
	}

	public short 读短整数型(bool reverse)
	{
		byte[] array = new byte[2];
		Read(array, 0, 2);
		if (reverse)
		{
			array = Singleton<ByteAPI>.I.反转_字节集(array);
		}
		return BitConverter.ToInt16(array);
	}

	public short 读短整数型(bool reverse, out short value)
	{
		byte[] array = new byte[2];
		Read(array, 0, 2);
		if (reverse)
		{
			array = Singleton<ByteAPI>.I.反转_字节集(array);
		}
		value = BitConverter.ToInt16(array);
		return value;
	}

	public int 读整数型(bool reverse)
	{
		byte[] array = new byte[4];
		Read(array, 0, 4);
		if (reverse)
		{
			array = Singleton<ByteAPI>.I.反转_字节集(array);
		}
		return BitConverter.ToInt32(array);
	}

	public int 读整数型(bool reverse, out int value)
	{
		byte[] array = new byte[4];
		Read(array, 0, 4);
		if (reverse)
		{
			array = Singleton<ByteAPI>.I.反转_字节集(array);
		}
		value = BitConverter.ToInt32(array);
		return value;
	}

	public byte[] 读字节集(int count)
	{
		byte[] array = new byte[count];
		Read(array, 0, count);
		return array;
	}

	public byte[] 读字节集(int count, out byte[] value)
	{
		byte[] array = new byte[count];
		Read(array, 0, count);
		value = array;
		return array;
	}

	public byte[] 剩余数据()
	{
		byte[] array = new byte[(int)(Length - Position)];
		Read(array);
		return array;
	}
}
