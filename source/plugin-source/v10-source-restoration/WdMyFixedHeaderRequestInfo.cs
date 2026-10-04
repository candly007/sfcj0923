using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TouchSocket.Core;

public class WdMyFixedHeaderRequestInfo : IFixedHeaderRequestInfo, IRequestInfo
{
	[CompilerGenerated]
	private int K3T6QdcuSZ;

	public byte[] beginBtye;

	public byte[] timeType;

	public byte[] endType;

	public byte[] packType;

	[CompilerGenerated]
	private byte[] RDj6EVvZ1l;

	public int BodyLength
	{
		
		[CompilerGenerated]
		get
		{
			return K3T6QdcuSZ;
		}
		
		[CompilerGenerated]
		private set
		{
			K3T6QdcuSZ = value;
		}
	}

	public byte[] InfoTye
	{
		
		[CompilerGenerated]
		get
		{
			return RDj6EVvZ1l;
		}
		
		[CompilerGenerated]
		set
		{
			RDj6EVvZ1l = value;
		}
	}

	
	public byte[] BuildAsBytes()
	{
		using ByteBlock byteBlock = new ByteBlock();
		Build(byteBlock);
		return byteBlock.ToArray();
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
		if (header.Length == 12)
		{
			Buffer.BlockCopy(header, 0, beginBtye, 0, 4);
			if (Enumerable.SequenceEqual(beginBtye, 全局常量类.协议头))
			{
				Buffer.BlockCopy(header, 4, timeType, 0, 4);
				Buffer.BlockCopy(header, 8, endType, 0, 2);
				short num = BitConverter.ToInt16(new byte[2]
				{
					endType[1],
					endType[0]
				}, 0);
				BodyLength = num - 2;
				Buffer.BlockCopy(header, 10, packType, 0, 2);
				return true;
			}
		}
		return false;
	}

	
	public bool OnParsingHeader(ReadOnlySpan<byte> header)
	{
		if (header.Length == 12)
		{
			Buffer.BlockCopy(header.ToArray(), 0, beginBtye, 0, 4);
			if (Enumerable.SequenceEqual(beginBtye, 全局常量类.协议头))
			{
				Buffer.BlockCopy(header.ToArray(), 4, timeType, 0, 4);
				Buffer.BlockCopy(header.ToArray(), 8, endType, 0, 2);
				short num = BitConverter.ToInt16(new byte[2]
				{
					endType[1],
					endType[0]
				}, 0);
				BodyLength = num - 2;
				Buffer.BlockCopy(header.ToArray(), 10, packType, 0, 2);
				return true;
			}
		}
		return false;
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

	
	public WdMyFixedHeaderRequestInfo()
	{
		beginBtye = new byte[4];
		timeType = new byte[4];
		endType = new byte[2];
		packType = new byte[2];
	}

	static WdMyFixedHeaderRequestInfo()
	{
	}
}
