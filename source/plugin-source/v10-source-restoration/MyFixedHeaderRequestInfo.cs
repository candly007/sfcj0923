using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TouchSocket.Core;

public class MyFixedHeaderRequestInfo : IFixedHeaderRequestInfo, IRequestInfo
{
	private const int HeaderSize = 12;

	[CompilerGenerated]
	private int sQv6Y8xbNT;

	public byte[] beginBtye;

	public byte[] timeType;

	public byte[] endType;

	public ushort len;

	public byte[] packType;

	[CompilerGenerated]
	private byte[] WBr6pRkWjQ;

	public int BodyLength
	{
		
		[CompilerGenerated]
		get
		{
			return sQv6Y8xbNT;
		}
		
		[CompilerGenerated]
		private set
		{
			sQv6Y8xbNT = value;
		}
	}

	public byte[] InfoTye
	{
		
		[CompilerGenerated]
		get
		{
			return WBr6pRkWjQ;
		}
		
		[CompilerGenerated]
		set
		{
			WBr6pRkWjQ = value;
		}
	}

	
	public byte[] BuildAsBytes()
	{
		using ByteBlock byteBlock = new ByteBlock();
		Build(byteBlock);
		return byteBlock.ToArray();
	}

	public static bool IsValidFrame(ReadOnlySpan<byte> frame)
	{
		if (frame.Length < HeaderSize || !TryGetBodyLength(frame.Slice(0, HeaderSize), out int bodyLength))
		{
			return false;
		}
		return frame.Length == HeaderSize + bodyLength;
	}

	private static bool TryGetBodyLength(ReadOnlySpan<byte> header, out int bodyLength)
	{
		bodyLength = 0;
		if (header.Length != HeaderSize || header[0] != 77 || header[1] != 90)
		{
			return false;
		}
		int declaredLength = (header[8] << 8) | header[9];
		if (declaredLength < 2)
		{
			return false;
		}
		bodyLength = declaredLength - 2;
		return true;
	}

	
	public void Build(ByteBlock bb)
	{
		bb.Write(beginBtye);
		bb.Write(timeType);
		bb.Write(endType);
		bb.Write(packType);
		if (InfoTye != null)
		{
			bb.Write(InfoTye);
		}
	}

	
	public bool OnParsingBody(byte[] body)
	{
		if (body.Length == BodyLength)
		{
			InfoTye = body;
			return true;
		}
		return false;
	}

	
	public bool OnParsingHeader(byte[] header)
	{
		if (!TryGetBodyLength(header, out int bodyLength))
		{
			return false;
		}
		Buffer.BlockCopy(header.ToArray(), 0, beginBtye, 0, 4);
		Buffer.BlockCopy(header.ToArray(), 4, timeType, 0, 4);
		Buffer.BlockCopy(header.ToArray(), 8, endType, 0, 2);
		len = (ushort)((header[8] << 8) | header[9]);
		BodyLength = bodyLength;
		Buffer.BlockCopy(header.ToArray(), 10, packType, 0, 2);
		return true;
	}

	
	public bool OnParsingHeader(ReadOnlySpan<byte> header)
	{
		if (!TryGetBodyLength(header, out int bodyLength))
		{
			return false;
		}
		Buffer.BlockCopy(header.ToArray(), 0, beginBtye, 0, 4);
		Buffer.BlockCopy(header.ToArray(), 4, timeType, 0, 4);
		Buffer.BlockCopy(header.ToArray(), 8, endType, 0, 2);
		len = (ushort)((header[8] << 8) | header[9]);
		BodyLength = bodyLength;
		Buffer.BlockCopy(header.ToArray(), 10, packType, 0, 2);
		return true;
	}

	
	public bool OnParsingBody(ReadOnlySpan<byte> body)
	{
		if (body.Length == BodyLength)
		{
			InfoTye = body.ToArray();
			return true;
		}
		return false;
	}

	
	public MyFixedHeaderRequestInfo()
	{
		beginBtye = new byte[4];
		timeType = new byte[4];
		endType = new byte[2];
		packType = new byte[2];
	}

	static MyFixedHeaderRequestInfo()
	{
	}
}
