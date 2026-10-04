using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Serilog;

namespace Ldau4kRn6nFHhj6A594;

internal class S09daDRcFbnf5np5xrV : Singleton<S09daDRcFbnf5np5xrV>
{
	
	internal byte[] IOCR54YOlC(byte[] P_0)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_0, 0, P_0.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写字节型(封包_读2.读字节型());
			封包_写2.写整数型(封包_读2.读整数型(reverse: true), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value), reverse: true);
			封包_写 封包_写3 = new 封包_写();
			short value2 = 0;
			short value3 = 0;
			int value4 = 0;
			short value5 = 0;
			int value6 = 0;
			string value7 = string.Empty;
			for (int i = 0; i < value; i++)
			{
				封包_写3.清数据();
				封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
				封包_写3.写字节集(封包_读2.读字节集(1), hasCount: false, 0);
				封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
				封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out value2), reverse: true);
				for (int j = 0; j < value2; j++)
				{
					封包_写3.写字节集(封包_读2.读字节集(2, out byte[] value10), hasCount: false, 0);
					封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out value3), reverse: true);
					for (int k = 0; k < value3; k++)
					{
						封包_写3.写字节集(封包_读2.读字节集(2, out byte[] value11), hasCount: false, 0);
						封包_写3.写字节型(封包_读2.读字节型(out var value12));
						switch (value12)
						{
						case 1:
							封包_写3.写字节型(封包_读2.读字节型(out value4));
							break;
						case 2:
							封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out value5), reverse: true);
							break;
						case 3:
							封包_写3.写整数型(封包_读2.读整数型(reverse: true, out value6), reverse: true);
							break;
						case 4:
							封包_写3.写文本型(封包_读2.读文本型(out value7, true, (byte)0, false), hasCount: true, 0);
							if (Enumerable.SequenceEqual(value11, new byte[2] { 0, 1 }) && !Enumerable.SequenceEqual(value10, new byte[2] { 0, 1 }))
							{
							}
							break;
						case 6:
							封包_写3.写字节型(封包_读2.读字节型(out value4));
							break;
						case 7:
							封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out value5), reverse: true);
							break;
						}
					}
				}
				封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			}
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return obj.取数据();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("王中王数据取出-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_0;
		}
	}

	
	public S09daDRcFbnf5np5xrV()
	{
	}

	static S09daDRcFbnf5np5xrV()
	{
	}
}
