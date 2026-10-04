using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace o6qwVWbu5whwUP31LfM;

internal class FusVSwwzpuFHNrjHS7T : Singleton<FusVSwwzpuFHNrjHS7T>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public 商城数据类 tuPXHQkrD3;

		
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		
		internal bool nmQXxZSGZM(商城数据类 a)
		{
			if (a.商品条码 == tuPXHQkrD3.商品条码)
			{
				return a.名字 == tuPXHQkrD3.名字;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass5_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public 商城数据类 QZdXeOJjSO;

		
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		
		internal bool RYHX42Jibi(商城数据类 a)
		{
			if (a.商品条码 == QZdXeOJjSO.商品条码)
			{
				return a.名字 == QZdXeOJjSO.名字;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass6_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public string kCAXtQTlWT;

		
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		
		internal bool vPgXqWjqvf(商城数据类 a)
		{
			return a.商品条码 == kCAXtQTlWT;
		}

		
		internal bool aG4Xre9PZo(商城数据类 a)
		{
			return a.商品条码 == kCAXtQTlWT;
		}

		
		internal bool JDaXZdw39T(限购商城数据类 a)
		{
			return a.商品条码 == kCAXtQTlWT;
		}

		static _003C_003Ec__DisplayClass7_0()
		{
		}
	}

	internal static byte[] ICGbUwAM9X;

	
	internal void Gblbwm7rpW()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("商城限购配置类.json")))
			{
				Singleton<全局变量类>.I.商城限购配置 = JsonConvert.DeserializeObject<商城限购配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("商城限购配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.商城限购配置 = new 商城限购配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("商城限购配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.商城限购配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("商城限购配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void IkAbbbPDb2()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("商城限购配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.商城限购配置, Formatting.Indented));
			Log.Debug("商城限购配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("商城限购配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string c75bJttR9s()
	{
		Gblbwm7rpW();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.商城限购配置, Formatting.Indented);
	}

	
	public void jJtbKj1SvX(string P_0)
	{
		Singleton<全局变量类>.I.商城限购配置 = JsonConvert.DeserializeObject<商城限购配置类>(P_0);
		IkAbbbPDb2();
	}

	
	public void OtdbRmruVU(byte[] P_0)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_0, 0, P_0.Length);
			封包_写 封包_写2 = new 封包_写();
			new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			byte[] bytes = 封包_读2.读字节集(2);
			封包_写2.写字节集(bytes, hasCount: false, 0);
			short num = 封包_读2.读短整数型(reverse: true);
			封包_写2.写短整数型(num, reverse: true);
			Singleton<全局变量类>.I.商城数据列表.Clear();
			封包_写 封包_写3 = new 封包_写();
			for (int i = 0; i < num; i++)
			{
				封包_写3.清数据();
				short num2 = 封包_读2.读短整数型(reverse: true);
				封包_写2.写短整数型(num2, reverse: true);
				封包_写3.写短整数型(num2, reverse: true);
				商城数据类 商城数据类2 = new 商城数据类();
				商城数据类2.编号 = i;
				string text;
				int value;
				int value3;
				byte[] bytes2;
				for (int j = 0; j < num2; j++)
				{
					bytes2 = 封包_读2.读字节集(2);
					封包_写2.写字节集(bytes2, hasCount: false, 0);
					封包_写3.写字节集(bytes2, hasCount: false, 0);
					short num3 = 封包_读2.读短整数型(reverse: true);
					封包_写2.写短整数型(num3, reverse: true);
					封包_写3.写短整数型(num3, reverse: true);
					for (int k = 0; k < num3; k++)
					{
						byte[] array = 封包_读2.读字节集(2);
						byte[] array2 = 封包_读2.读字节集(1);
						封包_写2.写字节集(array, hasCount: false, 0);
						封包_写2.写字节集(array2, hasCount: false, 0);
						封包_写3.写字节集(array, hasCount: false, 0);
						封包_写3.写字节集(array2, hasCount: false, 0);
						if (Enumerable.SequenceEqual(array2, new byte[1] { 1 }))
						{
							value = 封包_读2.读字节型();
							封包_写2.写字节型(value);
							封包_写3.写字节型(value);
						}
						else if (Enumerable.SequenceEqual(array2, new byte[1] { 2 }))
						{
							short value2 = 封包_读2.读短整数型(reverse: true);
							封包_写2.写短整数型(value2, reverse: true);
							封包_写3.写短整数型(value2, reverse: true);
						}
						else if (Enumerable.SequenceEqual(array2, new byte[1] { 3 }))
						{
							value3 = 封包_读2.读整数型(reverse: true);
							封包_写2.写整数型(value3, reverse: true);
							封包_写3.写整数型(value3, reverse: true);
						}
						else if (Enumerable.SequenceEqual(array2, new byte[1] { 4 }))
						{
							text = 封包_读2.读文本型(是否声明长度: true, 0);
							封包_写2.写文本型(text, hasCount: true, 0);
							封包_写3.写文本型(text, hasCount: true, 0);
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 1 }))
							{
								商城数据类2.名字 = text;
							}
						}
						else if (Enumerable.SequenceEqual(array2, new byte[1] { 6 }))
						{
							value = 封包_读2.读字节型();
							封包_写2.写字节型(value);
							封包_写3.写字节型(value);
						}
						else if (Enumerable.SequenceEqual(array2, new byte[1] { 7 }))
						{
							short value4 = 封包_读2.读短整数型(reverse: true);
							封包_写2.写短整数型(value4, reverse: true);
							封包_写3.写短整数型(value4, reverse: true);
						}
					}
				}
				text = 封包_读2.读文本型(是否声明长度: true, 0);
				封包_写2.写文本型(text, hasCount: true, 0);
				商城数据类2.商品条码 = text;
				bytes2 = 封包_读2.读字节集(2);
				封包_写2.写字节集(bytes2, hasCount: false, 0);
				short num4 = 封包_读2.读短整数型(reverse: true);
				商城数据类2.所在类别 = (byte)num4;
				封包_写2.写短整数型(num4, reverse: true);
				bytes2 = 封包_读2.读字节集(2);
				封包_写2.写字节集(bytes2, hasCount: false, 0);
				value = 封包_读2.读字节型();
				封包_写2.写字节型(value);
				商城数据类2.花费类型 = (byte)value;
				if (value == 3)
				{
					商城数据类2.is银元宝购买 = true;
				}
				value3 = 封包_读2.读整数型(reverse: true);
				封包_写2.写整数型(value3, reverse: true);
				商城数据类2.价格 = value3;
				bytes2 = 封包_读2.读字节集(2);
				封包_写2.写字节集(bytes2, hasCount: false, 0);
				商城数据类2.物品封包 = 封包_写3.取数据();
				Singleton<全局变量类>.I.商城数据列表.Add(商城数据类2);
			}
			using List<商城数据类>.Enumerator enumerator = Singleton<全局变量类>.I.商城限购配置.限购数据列表.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass5_0();
				CS_0024_003C_003E8__locals5.tuPXHQkrD3 = enumerator.Current;
				if (CS_0024_003C_003E8__locals5.tuPXHQkrD3.限购数量 >= 0)
				{
					商城数据类 商城数据类3 = Singleton<全局变量类>.I.商城数据列表.Find( (商城数据类 a) => a.商品条码 == CS_0024_003C_003E8__locals5.tuPXHQkrD3.商品条码 && a.名字 == CS_0024_003C_003E8__locals5.tuPXHQkrD3.名字);
					if (商城数据类3 != null)
					{
						商城数据类3.限购数量 = CS_0024_003C_003E8__locals5.tuPXHQkrD3.限购数量;
					}
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
			defaultInterpolatedStringHandler.AppendLiteral("组合商城包-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public void kZSbd0MGHY(byte[] P_0)
	{
		try
		{
			Singleton<全局变量类>.I.商城数据列表.Clear();
			封包_读 封包_读2 = new 封包_读(P_0, 0, P_0.Length);
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_读2.读字节集(2);
			short num = 封包_读2.读短整数型(reverse: true);
			for (int i = 0; i < num; i++)
			{
				short num2 = 封包_读2.读短整数型(reverse: true);
				商城数据类 商城数据类2 = new 商城数据类();
				商城数据类2.编号 = i;
				string 名字;
				int num4;
				int num5;
				for (int j = 0; j < num2; j++)
				{
					封包_读2.读字节集(2);
					short num3 = 封包_读2.读短整数型(reverse: true);
					for (int k = 0; k < num3; k++)
					{
						byte[] first = 封包_读2.读字节集(2);
						byte[] first2 = 封包_读2.读字节集(1);
						if (Enumerable.SequenceEqual(first2, new byte[1] { 1 }))
						{
							num4 = 封包_读2.读字节型();
						}
						else if (Enumerable.SequenceEqual(first2, new byte[1] { 2 }))
						{
							封包_读2.读短整数型(reverse: true);
						}
						else if (Enumerable.SequenceEqual(first2, new byte[1] { 3 }))
						{
							num5 = 封包_读2.读整数型(reverse: true);
						}
						else if (Enumerable.SequenceEqual(first2, new byte[1] { 4 }))
						{
							名字 = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
							if (Enumerable.SequenceEqual(first, new byte[2] { 0, 1 }))
							{
								商城数据类2.名字 = 名字;
							}
						}
						else if (Enumerable.SequenceEqual(first2, new byte[1] { 6 }))
						{
							num4 = 封包_读2.读字节型();
						}
						else if (Enumerable.SequenceEqual(first2, new byte[1] { 7 }))
						{
							封包_读2.读短整数型(reverse: true);
						}
					}
				}
				名字 = 封包_读2.读文本型(是否声明长度: true, 0);
				商城数据类2.商品条码 = 名字;
				封包_读2.读字节集(2);
				short num6 = 封包_读2.读短整数型(reverse: true);
				商城数据类2.所在类别 = (byte)num6;
				封包_读2.读字节集(2);
				num4 = 封包_读2.读字节型();
				商城数据类2.花费类型 = (byte)num4;
				if (num4 == 3)
				{
					商城数据类2.is银元宝购买 = true;
				}
				num5 = 封包_读2.读整数型(reverse: true);
				商城数据类2.价格 = num5;
				封包_读2.读字节集(2);
				Singleton<全局变量类>.I.商城数据列表.Add(商城数据类2);
			}
			using List<商城数据类>.Enumerator enumerator = Singleton<全局变量类>.I.商城限购配置.限购数据列表.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass6_0();
				CS_0024_003C_003E8__locals5.QZdXeOJjSO = enumerator.Current;
				if (CS_0024_003C_003E8__locals5.QZdXeOJjSO.限购数量 >= 0)
				{
					商城数据类 商城数据类3 = Singleton<全局变量类>.I.商城数据列表.Find( (商城数据类 a) => a.商品条码 == CS_0024_003C_003E8__locals5.QZdXeOJjSO.商品条码 && a.名字 == CS_0024_003C_003E8__locals5.QZdXeOJjSO.名字);
					if (商城数据类3 != null)
					{
						商城数据类3.限购数量 = CS_0024_003C_003E8__locals5.QZdXeOJjSO.限购数量;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("组合商城包报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal bool yHNbsmUYJd(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass7_0();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(12L, SeekOrigin.Begin);
			CS_0024_003C_003E8__locals9.kCAXtQTlWT = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			short num = 封包_读2.读短整数型(reverse: true);
			if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < num)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的包裹栏不足。").Concat(Singleton<WdAPI>.I.组包包头(Singleton<ByteAPI>.I.HtoC("FD27000109").Concat(Singleton<ByteAPI>.I.到字节集(CS_0024_003C_003E8__locals9.kCAXtQTlWT)).ToArray())).ToArray());
				return false;
			}
			if (Singleton<全局变量类>.I.商城数据列表.Find( (商城数据类 a) => a.商品条码 == CS_0024_003C_003E8__locals9.kCAXtQTlWT) == null)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("商城暂无此道具。").Concat(Singleton<WdAPI>.I.组包包头(Singleton<ByteAPI>.I.HtoC("FD27000109").Concat(Singleton<ByteAPI>.I.到字节集(CS_0024_003C_003E8__locals9.kCAXtQTlWT)).ToArray())).ToArray());
				return false;
			}
			商城数据类 商城数据类2 = Singleton<全局变量类>.I.商城限购配置.限购数据列表.Find( (商城数据类 a) => a.商品条码 == CS_0024_003C_003E8__locals9.kCAXtQTlWT);
			if (商城数据类2 == null)
			{
				return true;
			}
			if (商城数据类2.限购数量 == -1)
			{
				return true;
			}
			if (商城数据类2.限购数量 == 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + 商城数据类2.名字 + "#n暂不允许进行购买！").Concat(Singleton<WdAPI>.I.组包包头(Singleton<ByteAPI>.I.HtoC("FD27000109").Concat(Singleton<ByteAPI>.I.到字节集(CS_0024_003C_003E8__locals9.kCAXtQTlWT)).ToArray())).ToArray());
				return false;
			}
			限购商城数据类 限购商城数据类2 = P_0.user.存档数据.限购商城数据.Find( (限购商城数据类 a) => a.商品条码 == CS_0024_003C_003E8__locals9.kCAXtQTlWT);
			if (限购商城数据类2 == null)
			{
				限购商城数据类2 = new 限购商城数据类
				{
					商品名字 = 商城数据类2.名字,
					商品条码 = CS_0024_003C_003E8__locals9.kCAXtQTlWT,
					已购数量 = 0
				};
				P_0.user.存档数据.限购商城数据.Add(限购商城数据类2);
			}
			if (限购商城数据类2.已购数量 + num > 商城数据类2.限购数量)
			{
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
				defaultInterpolatedStringHandler.AppendLiteral("当前道具每日限购#Y");
				defaultInterpolatedStringHandler.AppendFormatted(限购商城数据类2.已购数量);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(商城数据类2.限购数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n个，当前购买数量有误，请您重新输入购买数量！");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("当前购买数量有误，请您重新输入购买数量！")).Concat(Singleton<WdAPI>.I.组包包头(Singleton<ByteAPI>.I.HtoC("FD27000109").Concat(Singleton<ByteAPI>.I.到字节集(CS_0024_003C_003E8__locals9.kCAXtQTlWT)).ToArray()))
					.ToArray());
				return false;
			}
			限购商城数据类2.已购数量 += num;
			return true;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("商城限购判断-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return false;
		}
	}

	
	public FusVSwwzpuFHNrjHS7T()
	{
	}

	
	static FusVSwwzpuFHNrjHS7T()
	{
		ICGbUwAM9X = Array.Empty<byte>();
	}
}
