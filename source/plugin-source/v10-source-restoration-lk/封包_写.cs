using System;
using System.IO;
using System.Text;

public class 封包_写 : MemoryStream
{
	public 封包_写()
	{
	}

	public 封包_写(byte[] bytes)
		: base(bytes)
	{
	}

	public void 写短整数型(short value, bool reverse)
	{
		byte[] buffer = BitConverter.GetBytes(value);
		if (reverse)
		{
			buffer = Singleton<ByteAPI>.I.反转_字节集(buffer);
		}
		Write(buffer, 0, 2);
	}

	public void 写短整数型(ushort value, bool reverse)
	{
		byte[] buffer = BitConverter.GetBytes(value);
		if (reverse)
		{
			buffer = Singleton<ByteAPI>.I.反转_字节集(buffer);
		}
		Write(buffer, 0, 2);
	}

	public void 写整数型(int value, bool reverse)
	{
		byte[] buffer = BitConverter.GetBytes(value);
		if (reverse)
		{
			buffer = Singleton<ByteAPI>.I.反转_字节集(buffer);
		}
		Write(buffer, 0, 4);
	}

	public void 写文本型(string zone, bool hasCount = true, byte type = 0, bool reverse = false)
	{
		byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(zone);
		写入数据(bytes, hasCount, type, reverse);
	}

	public void 写字节型(int value)
	{
		WriteByte((byte)value);
	}

	public void 写字节集(byte[] bytes, bool hasCount = false, byte type = 0, bool reverse = false)
	{
		if (!hasCount)
		{
			Write(bytes, 0, bytes.Length);
			return;
		}
		switch (type)
		{
		case 0:
			WriteByte((byte)bytes.Length);
			break;
		case 1:
			写短整数型((short)bytes.Length, reverse);
			break;
		case 2:
			写整数型(bytes.Length, reverse);
			break;
		}
		Write(bytes, 0, bytes.Length);
	}

	public void 写入数据(byte[] bytes, bool hasCount = false, byte type = 0, bool reverse = false)
	{
		if (!hasCount)
		{
			Write(bytes, 0, bytes.Length);
			return;
		}
		switch (type)
		{
		case 0:
			WriteByte((byte)bytes.Length);
			break;
		case 1:
			写短整数型((short)bytes.Length, reverse);
			break;
		case 2:
			写整数型(bytes.Length, reverse);
			break;
		}
		Write(bytes, 0, bytes.Length);
	}

	public byte[] 取数据()
	{
		return ToArray();
	}

	public void 清数据()
	{
		SetLength(0L);
	}
}
