using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace HS2GfXB7hJCX6tDXuc0;

internal class mDs6hiBvFvG3CRi3MZk : Singleton<mDs6hiBvFvG3CRi3MZk>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public MyNATSocketClient vvsaNhn13E;

		public string[] GZqaiKhvIx;

		public 地府购买存档类 HenaBSVn8v;

		public int kVDaGeDVAt;

		public int roIafslFlp;

		public 地府商城物品类 KhNa6MuC9e;

		public int ot9a2vLQdI;

		
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		
		internal bool CH4aoKbnKK(地府商城物品类 x)
		{
			return x.物品名字 == GZqaiKhvIx[0];
		}

		static _003C_003Ec__DisplayClass14_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_1
	{
		public int ntSaPeGQbJ;

		public ConcurrentDictionary<int, int> NBbaXJFJuQ;

		public _003C_003Ec__DisplayClass14_0 ThdaFh3YVi;

		
		public _003C_003Ec__DisplayClass14_1()
		{
		}

		
		internal void I4UamGox4k(string v)
		{
			if (v != Singleton<全局变量类>.I.地府商城配置.消耗材料名字)
			{
				return;
			}
			ntSaPeGQbJ++;
			if (ntSaPeGQbJ >= NBbaXJFJuQ.Count)
			{
				ThdaFh3YVi.vvsaNhn13E.销毁回调事件 = null;
				if (ThdaFh3YVi.HenaBSVn8v != null)
				{
					ThdaFh3YVi.HenaBSVn8v.每日购买 += ThdaFh3YVi.kVDaGeDVAt;
					ThdaFh3YVi.HenaBSVn8v.累计购买 += ThdaFh3YVi.kVDaGeDVAt;
				}
				switch (Singleton<全局变量类>.I.地府商城配置.消耗数值类型)
				{
				case AllEnums.数值Type.潜能:
					Singleton<WdAPI>.I.PndoGw5lW7(ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.pot, -ThdaFh3YVi.roIafslFlp, false, "地府商城购买");
					break;
				case AllEnums.数值Type.道行:
					Singleton<WdAPI>.I.PndoGw5lW7(ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, -(ThdaFh3YVi.roIafslFlp * 360), false, "地府商城购买");
					break;
				case AllEnums.数值Type.声望:
					Singleton<WdAPI>.I.PndoGw5lW7(ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, -ThdaFh3YVi.roIafslFlp, false, "地府商城购买");
					break;
				case AllEnums.数值Type.累充点:
					Singleton<WdAPI>.I.PndoGw5lW7(ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.reputation, -ThdaFh3YVi.roIafslFlp, false, "地府商城购买");
					break;
				case AllEnums.数值Type.奇宝点:
					Singleton<WdAPI>.I.PndoGw5lW7(ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.reputation, -ThdaFh3YVi.roIafslFlp, false, "地府商城购买");
					break;
				case AllEnums.数值Type.灵气值:
					Singleton<WdAPI>.I.PndoGw5lW7(ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.reputation, -ThdaFh3YVi.roIafslFlp, false, "地府商城购买");
					break;
				case AllEnums.数值Type.论道点:
					Singleton<WdAPI>.I.PndoGw5lW7(ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.论道点, string.Empty, AllEnums.指令Type.reputation, -ThdaFh3YVi.roIafslFlp, false, "地府商城购买");
					break;
				}
				Singleton<WdAPI>.I.AKEoOlhFAx(ThdaFh3YVi.vvsaNhn13E, ThdaFh3YVi.KhNa6MuC9e.物品类型, ThdaFh3YVi.KhNa6MuC9e.物品名字, ThdaFh3YVi.KhNa6MuC9e.物品数量 * ThdaFh3YVi.kVDaGeDVAt, false, "地府商城购买到货");
				MyNATSocketClient myNATSocketClient = ThdaFh3YVi.vvsaNhn13E;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 6);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(ThdaFh3YVi.ot9a2vLQdI);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.地府商城配置.消耗材料名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n和#R");
				defaultInterpolatedStringHandler.AppendFormatted(ThdaFh3YVi.roIafslFlp);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				string value;
				if (Singleton<全局变量类>.I.地府商城配置.消耗数值类型 != AllEnums.数值Type.道行)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("点#R");
					defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.地府商城配置.消耗数值类型);
					defaultInterpolatedStringHandler2.AppendLiteral("#n");
					value = defaultInterpolatedStringHandler2.ToStringAndClear();
				}
				else
				{
					value = "年#R道行#n";
				}
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("兑换了#R");
				defaultInterpolatedStringHandler.AppendFormatted(ThdaFh3YVi.KhNa6MuC9e.物品数量 * ThdaFh3YVi.kVDaGeDVAt);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(ThdaFh3YVi.KhNa6MuC9e.物品名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}

		static _003C_003Ec__DisplayClass14_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_2
	{
		public int xLFaSsnNTy;

		public ConcurrentDictionary<int, int> zQKac9xEy0;

		public _003C_003Ec__DisplayClass14_0 OYcanj3j0k;

		
		public _003C_003Ec__DisplayClass14_2()
		{
		}

		
		internal void bCoaLhaWsi(string v)
		{
			if (v != Singleton<全局变量类>.I.地府商城配置.消耗材料名字)
			{
				return;
			}
			xLFaSsnNTy++;
			if (xLFaSsnNTy >= zQKac9xEy0.Count)
			{
				OYcanj3j0k.vvsaNhn13E.销毁回调事件 = null;
				if (OYcanj3j0k.HenaBSVn8v != null)
				{
					OYcanj3j0k.HenaBSVn8v.每日购买 += OYcanj3j0k.kVDaGeDVAt;
					OYcanj3j0k.HenaBSVn8v.累计购买 += OYcanj3j0k.kVDaGeDVAt;
				}
				Singleton<WdAPI>.I.AKEoOlhFAx(OYcanj3j0k.vvsaNhn13E, OYcanj3j0k.KhNa6MuC9e.物品类型, OYcanj3j0k.KhNa6MuC9e.物品名字, OYcanj3j0k.KhNa6MuC9e.物品数量 * OYcanj3j0k.kVDaGeDVAt);
				MyNATSocketClient myNATSocketClient = OYcanj3j0k.vvsaNhn13E;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 4);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(OYcanj3j0k.ot9a2vLQdI);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.地府商城配置.消耗材料名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n兑换了#R");
				defaultInterpolatedStringHandler.AppendFormatted(OYcanj3j0k.kVDaGeDVAt);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(OYcanj3j0k.KhNa6MuC9e.物品名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}

		static _003C_003Ec__DisplayClass14_2()
		{
		}
	}

	internal static byte[] lAWB3BUKs3;

	internal static byte[] QvVBYYxOq8;

	internal ConcurrentDictionary<int, int> TrjBpRk3tp;

	private static byte[] IfbB1SM79n;

	
	[SpecialName]
	internal static bool ecqBQD9Cis()
	{
		if (Singleton<全局变量类>.I.验证client.授权配置.Is在线商城 || 全局变量类.Is调试)
		{
			return Singleton<全局变量类>.I.地府商城配置.功能开关;
		}
		return false;
	}

	
	internal void Je0BaBf7ZZ()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("地府商城配置类.json")))
			{
				Singleton<全局变量类>.I.地府商城配置 = JsonConvert.DeserializeObject<地府商城配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("地府商城配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.地府商城配置 = new 地府商城配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("地府商城配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.地府商城配置, Formatting.Indented));
			}
			yx2BVj7XOe();
			TrjBpRk3tp.Clear();
			if (string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.地府商城配置.道行下限文本))
			{
				return;
			}
			string[] array = Singleton<全局变量类>.I.地府商城配置.道行下限文本.Split("/");
			if (array.Length == 0)
			{
				return;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (!string.IsNullOrWhiteSpace(array[i]))
				{
					string[] array2 = array[i].Split("=");
					if (array2.Length == 2)
					{
						TrjBpRk3tp.TryAdd(int.Parse(array2[0]), int.Parse(array2[1]));
					}
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("地府商城配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void mtQBTIfZfi()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("地府商城配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.地府商城配置, Formatting.Indented));
			Log.Debug("地府商城配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("地府商城配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string EOWB9RqD3q()
	{
		Je0BaBf7ZZ();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.地府商城配置, Formatting.Indented);
	}

	
	public void SYqByvsuLR(string P_0)
	{
		Singleton<全局变量类>.I.地府商城配置 = JsonConvert.DeserializeObject<地府商城配置类>(P_0);
		mtQBTIfZfi();
	}

	
	internal void ElmBC999cR(MyNATSocketClient P_0, bool P_1 = true)
	{
		P_0.C_Send((!ecqBQD9Cis() || !P_1 || !Singleton<全局变量类>.I.地府商城配置.图标开关) ? QvVBYYxOq8 : lAWB3BUKs3);
	}

	
	internal static void yx2BVj7XOe()
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 250, 69 }, hasCount: false, 0);
		封包_写2.写字节型(Singleton<全局变量类>.I.地府商城配置.物品列表.Count);
		for (int i = 0; i < Singleton<全局变量类>.I.地府商城配置.物品列表.Count; i++)
		{
			封包_写2.写文本型(Singleton<全局变量类>.I.地府商城配置.物品列表[i].物品名字, hasCount: true, 0);
			封包_写2.写整数型(Singleton<全局变量类>.I.地府商城配置.物品列表[i].物品图标, reverse: true);
			封包_写2.写短整数型(Singleton<全局变量类>.I.地府商城配置.物品列表[i].消耗材料单价, reverse: true);
			封包_写2.写整数型(Singleton<全局变量类>.I.地府商城配置.物品列表[i].消耗数值单价, reverse: true);
		}
		IfbB1SM79n = Array.Empty<byte>();
		IfbB1SM79n = Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
	}

	
	internal byte[] ouWBk4AhMx(MyNATSocketClient P_0, byte[] P_1)
	{
		if (!ecqBQD9Cis())
		{
			return P_1;
		}
		if (IfbB1SM79n != Array.Empty<byte>())
		{
			return IfbB1SM79n;
		}
		yx2BVj7XOe();
		return IfbB1SM79n;
	}

	
	internal byte[] Nc8B0RfNPE(MyNATSocketClient P_0, byte[] P_1, byte[] P_2)
	{
		封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
		obj.Seek(12L, SeekOrigin.Begin);
		obj.读文本型(out string value, true, (byte)0, false);
		obj.读整数型(reverse: true, out var value2);
		if (value2 < 1 || value2 > 1600)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R输入的购买数量有误，无法购买。"));
			return null;
		}
		if (!ecqBQD9Cis())
		{
			return P_1;
		}
		if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
		{
			return null;
		}
		WdAPI i = Singleton<WdAPI>.I;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 4);
		defaultInterpolatedStringHandler.AppendLiteral("[@确定/地府操作_购买确定");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("_");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要购买#R");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("#n吗？]");
		P_0.C_Send(i.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
		return null;
	}

	
	internal async Task 地府商城购买确定(MyNATSocketClient myclient, string 内容)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals154 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals154.vvsaNhn13E = myclient;
		try
		{
			if (!ecqBQD9Cis())
			{
				return;
			}
			CS_0024_003C_003E8__locals154.GZqaiKhvIx = 内容.Split("_");
			if (CS_0024_003C_003E8__locals154.GZqaiKhvIx.Length != 2)
			{
				CS_0024_003C_003E8__locals154.vvsaNhn13E.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R输入的购买数量有误，无法购买。"));
				return;
			}
			CS_0024_003C_003E8__locals154.KhNa6MuC9e = Singleton<全局变量类>.I.地府商城配置.物品列表.Find( (地府商城物品类 x) => x.物品名字 == CS_0024_003C_003E8__locals154.GZqaiKhvIx[0]);
			if (CS_0024_003C_003E8__locals154.KhNa6MuC9e == null)
			{
				CS_0024_003C_003E8__locals154.vvsaNhn13E.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R购买物品不存在，无法购买。"));
				return;
			}
			if (!int.TryParse(CS_0024_003C_003E8__locals154.GZqaiKhvIx[1], out CS_0024_003C_003E8__locals154.kVDaGeDVAt))
			{
				CS_0024_003C_003E8__locals154.vvsaNhn13E.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R输入的购买数量有误，无法购买。"));
				return;
			}
			if (CS_0024_003C_003E8__locals154.kVDaGeDVAt <= 0 || CS_0024_003C_003E8__locals154.kVDaGeDVAt > 1600)
			{
				CS_0024_003C_003E8__locals154.vvsaNhn13E.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R输入的购买数量有误，无法购买。"));
				return;
			}
			if (!CS_0024_003C_003E8__locals154.KhNa6MuC9e.物品是否叠加 && CS_0024_003C_003E8__locals154.kVDaGeDVAt > Singleton<WdAPI>.I.取背包剩余空格数(CS_0024_003C_003E8__locals154.vvsaNhn13E))
			{
				CS_0024_003C_003E8__locals154.vvsaNhn13E.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R背包位置不足，无法购买。"));
				return;
			}
			CS_0024_003C_003E8__locals154.HenaBSVn8v = null;
			if (CS_0024_003C_003E8__locals154.KhNa6MuC9e.是否限购)
			{
				if (CS_0024_003C_003E8__locals154.KhNa6MuC9e.每日限购 <= 0)
				{
					CS_0024_003C_003E8__locals154.vvsaNhn13E.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + CS_0024_003C_003E8__locals154.KhNa6MuC9e.物品名字 + "#n今日可购买数量为#R0#n，暂无法购买。"));
					return;
				}
				if (CS_0024_003C_003E8__locals154.KhNa6MuC9e.累计限购 <= 0)
				{
					CS_0024_003C_003E8__locals154.vvsaNhn13E.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + CS_0024_003C_003E8__locals154.KhNa6MuC9e.物品名字 + "#n今日可购买数量为#R0#n，暂无法购买。"));
					return;
				}
				if (!CS_0024_003C_003E8__locals154.vvsaNhn13E.user.存档数据.地府购买存档.TryGetValue(CS_0024_003C_003E8__locals154.KhNa6MuC9e.物品名字, out CS_0024_003C_003E8__locals154.HenaBSVn8v))
				{
					CS_0024_003C_003E8__locals154.HenaBSVn8v = new 地府购买存档类
					{
						物品名字 = CS_0024_003C_003E8__locals154.KhNa6MuC9e.物品名字
					};
					CS_0024_003C_003E8__locals154.vvsaNhn13E.user.存档数据.地府购买存档.TryAdd(CS_0024_003C_003E8__locals154.KhNa6MuC9e.物品名字, CS_0024_003C_003E8__locals154.HenaBSVn8v);
				}
				if (CS_0024_003C_003E8__locals154.HenaBSVn8v.每日购买 + CS_0024_003C_003E8__locals154.kVDaGeDVAt > CS_0024_003C_003E8__locals154.KhNa6MuC9e.每日限购)
				{
					MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals154.vvsaNhn13E;
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.KhNa6MuC9e.物品名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n今日剩余可购买的数量不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.kVDaGeDVAt);
					defaultInterpolatedStringHandler.AppendLiteral("#n，暂无法购买。");
					myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (CS_0024_003C_003E8__locals154.HenaBSVn8v.每日购买 + CS_0024_003C_003E8__locals154.kVDaGeDVAt > CS_0024_003C_003E8__locals154.KhNa6MuC9e.累计限购)
				{
					MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals154.vvsaNhn13E;
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.KhNa6MuC9e.物品名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n剩余可购买的数量不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.kVDaGeDVAt);
					defaultInterpolatedStringHandler.AppendLiteral("#n，暂无法购买。");
					myNATSocketClient2.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
			}
			if ((long)CS_0024_003C_003E8__locals154.KhNa6MuC9e.消耗数值单价 * (long)CS_0024_003C_003E8__locals154.kVDaGeDVAt > 2000000000)
			{
				CS_0024_003C_003E8__locals154.vvsaNhn13E.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R输入的购买数量有误，无法购买。"));
				return;
			}
			CS_0024_003C_003E8__locals154.roIafslFlp = CS_0024_003C_003E8__locals154.KhNa6MuC9e.消耗数值单价 * CS_0024_003C_003E8__locals154.kVDaGeDVAt;
			bool flag = false;
			CS_0024_003C_003E8__locals154.ot9a2vLQdI = CS_0024_003C_003E8__locals154.KhNa6MuC9e.消耗材料单价 * CS_0024_003C_003E8__locals154.kVDaGeDVAt;
			bool flag2 = false;
			if (Singleton<全局变量类>.I.地府商城配置.消耗数值类型 != AllEnums.数值Type.无)
			{
				switch (Singleton<全局变量类>.I.地府商城配置.消耗数值类型)
				{
				case AllEnums.数值Type.潜能:
					if (CS_0024_003C_003E8__locals154.roIafslFlp > 0 && CS_0024_003C_003E8__locals154.vvsaNhn13E.user.属性数据.潜能 < CS_0024_003C_003E8__locals154.roIafslFlp)
					{
						MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals154.vvsaNhn13E;
						WdAPI i4 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
						defaultInterpolatedStringHandler.AppendLiteral("别逗我了，你的#R潜能#n根本不够#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.roIafslFlp);
						defaultInterpolatedStringHandler.AppendLiteral("#n点！");
						myNATSocketClient4.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					break;
				case AllEnums.数值Type.道行:
				{
					if (CS_0024_003C_003E8__locals154.vvsaNhn13E.user.属性数据.等级 < 60)
					{
						CS_0024_003C_003E8__locals154.vvsaNhn13E.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前等级不足#R60#n级，暂无资格兑换物品！"));
						return;
					}
					if (TrjBpRk3tp.TryGetValue(CS_0024_003C_003E8__locals154.vvsaNhn13E.user.属性数据.等级 / 10 * 10, out var value))
					{
						if (CS_0024_003C_003E8__locals154.vvsaNhn13E.user.属性数据.道行 / 360 < value + CS_0024_003C_003E8__locals154.roIafslFlp)
						{
							MyNATSocketClient myNATSocketClient8 = CS_0024_003C_003E8__locals154.vvsaNhn13E;
							WdAPI i8 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
							defaultInterpolatedStringHandler.AppendLiteral("你当前等级最低拥有#R");
							defaultInterpolatedStringHandler.AppendFormatted(value + CS_0024_003C_003E8__locals154.roIafslFlp);
							defaultInterpolatedStringHandler.AppendLiteral("#n年道行才有资格兑换物品！");
							myNATSocketClient8.C_Send(i8.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return;
						}
					}
					else if (CS_0024_003C_003E8__locals154.vvsaNhn13E.user.属性数据.道行 / 360 < CS_0024_003C_003E8__locals154.roIafslFlp)
					{
						MyNATSocketClient myNATSocketClient9 = CS_0024_003C_003E8__locals154.vvsaNhn13E;
						WdAPI i9 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
						defaultInterpolatedStringHandler.AppendLiteral("别逗我了，你的#R道行#n根本不够#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.roIafslFlp);
						defaultInterpolatedStringHandler.AppendLiteral("#n年！");
						myNATSocketClient9.C_Send(i9.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					break;
				}
				case AllEnums.数值Type.声望:
					if (CS_0024_003C_003E8__locals154.roIafslFlp > 0 && CS_0024_003C_003E8__locals154.vvsaNhn13E.user.属性数据.声望 < CS_0024_003C_003E8__locals154.roIafslFlp)
					{
						MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals154.vvsaNhn13E;
						WdAPI i5 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
						defaultInterpolatedStringHandler.AppendLiteral("别逗我了，你的#R声望#n根本不够#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.roIafslFlp);
						defaultInterpolatedStringHandler.AppendLiteral("#n点！");
						myNATSocketClient5.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					break;
				case AllEnums.数值Type.累充点:
					if (CS_0024_003C_003E8__locals154.roIafslFlp > 0 && CS_0024_003C_003E8__locals154.vvsaNhn13E.user.存档数据.累计充值金额 < CS_0024_003C_003E8__locals154.roIafslFlp)
					{
						MyNATSocketClient myNATSocketClient7 = CS_0024_003C_003E8__locals154.vvsaNhn13E;
						WdAPI i7 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
						defaultInterpolatedStringHandler.AppendLiteral("别逗我了，你的#R累充点#n根本不够#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.roIafslFlp);
						defaultInterpolatedStringHandler.AppendLiteral("#n点！");
						myNATSocketClient7.C_Send(i7.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					break;
				case AllEnums.数值Type.奇宝点:
					if (CS_0024_003C_003E8__locals154.roIafslFlp > 0 && CS_0024_003C_003E8__locals154.vvsaNhn13E.user.存档数据.奇宝斋存档.奇宝斋余额 < CS_0024_003C_003E8__locals154.roIafslFlp)
					{
						MyNATSocketClient myNATSocketClient10 = CS_0024_003C_003E8__locals154.vvsaNhn13E;
						WdAPI i10 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
						defaultInterpolatedStringHandler.AppendLiteral("别逗我了，你的#R奇宝点#n根本不够#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.roIafslFlp);
						defaultInterpolatedStringHandler.AppendLiteral("#n点！");
						myNATSocketClient10.C_Send(i10.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					break;
				case AllEnums.数值Type.灵气值:
					if (CS_0024_003C_003E8__locals154.roIafslFlp > 0 && CS_0024_003C_003E8__locals154.vvsaNhn13E.user.存档数据.数值存档.灵气值 < CS_0024_003C_003E8__locals154.roIafslFlp)
					{
						MyNATSocketClient myNATSocketClient6 = CS_0024_003C_003E8__locals154.vvsaNhn13E;
						WdAPI i6 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
						defaultInterpolatedStringHandler.AppendLiteral("别逗我了，你的#R灵气值#n根本不够#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.roIafslFlp);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						myNATSocketClient6.C_Send(i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					break;
				case AllEnums.数值Type.论道点:
					if (CS_0024_003C_003E8__locals154.roIafslFlp > 0 && CS_0024_003C_003E8__locals154.vvsaNhn13E.user.存档数据.数值存档.论道点 < CS_0024_003C_003E8__locals154.roIafslFlp)
					{
						MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals154.vvsaNhn13E;
						WdAPI i3 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
						defaultInterpolatedStringHandler.AppendLiteral("别逗我了，你的#R论道点#n根本不够#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.roIafslFlp);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						myNATSocketClient3.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					break;
				}
				if (CS_0024_003C_003E8__locals154.roIafslFlp > 0)
				{
					flag = true;
				}
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.地府商城配置.消耗材料名字) && CS_0024_003C_003E8__locals154.ot9a2vLQdI > 0)
			{
				if (Singleton<WdAPI>.I.取背包指定物品数量(CS_0024_003C_003E8__locals154.vvsaNhn13E, Singleton<全局变量类>.I.地府商城配置.消耗材料名字) < CS_0024_003C_003E8__locals154.ot9a2vLQdI)
				{
					MyNATSocketClient myNATSocketClient11 = CS_0024_003C_003E8__locals154.vvsaNhn13E;
					WdAPI i11 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("别逗我了，你的#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.地府商城配置.消耗材料名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n根本不够#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.ot9a2vLQdI);
					defaultInterpolatedStringHandler.AppendLiteral("#n个！");
					myNATSocketClient11.C_Send(i11.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				flag2 = true;
			}
			if (flag && flag2)
			{
				_003C_003Ec__DisplayClass14_1 CS_0024_003C_003E8__locals188 = new _003C_003Ec__DisplayClass14_1();
				CS_0024_003C_003E8__locals188.ThdaFh3YVi = CS_0024_003C_003E8__locals154;
				CS_0024_003C_003E8__locals188.NBbaXJFJuQ = Singleton<WdAPI>.I.取背包物品格子丢弃数(CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E, Singleton<全局变量类>.I.地府商城配置.消耗材料名字, CS_0024_003C_003E8__locals188.ThdaFh3YVi.ot9a2vLQdI);
				CS_0024_003C_003E8__locals188.ntSaPeGQbJ = 0;
				CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E.销毁回调事件 =  (string v) =>
				{
					if (!(v != Singleton<全局变量类>.I.地府商城配置.消耗材料名字))
					{
						CS_0024_003C_003E8__locals188.ntSaPeGQbJ++;
						if (CS_0024_003C_003E8__locals188.ntSaPeGQbJ >= CS_0024_003C_003E8__locals188.NBbaXJFJuQ.Count)
						{
							CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E.销毁回调事件 = null;
							if (CS_0024_003C_003E8__locals188.ThdaFh3YVi.HenaBSVn8v != null)
							{
								CS_0024_003C_003E8__locals188.ThdaFh3YVi.HenaBSVn8v.每日购买 += CS_0024_003C_003E8__locals188.ThdaFh3YVi.kVDaGeDVAt;
								CS_0024_003C_003E8__locals188.ThdaFh3YVi.HenaBSVn8v.累计购买 += CS_0024_003C_003E8__locals188.ThdaFh3YVi.kVDaGeDVAt;
							}
							switch (Singleton<全局变量类>.I.地府商城配置.消耗数值类型)
							{
							case AllEnums.数值Type.潜能:
								Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.pot, -CS_0024_003C_003E8__locals188.ThdaFh3YVi.roIafslFlp, false, "地府商城购买");
								break;
							case AllEnums.数值Type.道行:
								Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, -(CS_0024_003C_003E8__locals188.ThdaFh3YVi.roIafslFlp * 360), false, "地府商城购买");
								break;
							case AllEnums.数值Type.声望:
								Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, -CS_0024_003C_003E8__locals188.ThdaFh3YVi.roIafslFlp, false, "地府商城购买");
								break;
							case AllEnums.数值Type.累充点:
								Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.reputation, -CS_0024_003C_003E8__locals188.ThdaFh3YVi.roIafslFlp, false, "地府商城购买");
								break;
							case AllEnums.数值Type.奇宝点:
								Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.reputation, -CS_0024_003C_003E8__locals188.ThdaFh3YVi.roIafslFlp, false, "地府商城购买");
								break;
							case AllEnums.数值Type.灵气值:
								Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.reputation, -CS_0024_003C_003E8__locals188.ThdaFh3YVi.roIafslFlp, false, "地府商城购买");
								break;
							case AllEnums.数值Type.论道点:
								Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E, AllEnums.发送数据Type.论道点, string.Empty, AllEnums.指令Type.reputation, -CS_0024_003C_003E8__locals188.ThdaFh3YVi.roIafslFlp, false, "地府商城购买");
								break;
							}
							Singleton<WdAPI>.I.AKEoOlhFAx(CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E, CS_0024_003C_003E8__locals188.ThdaFh3YVi.KhNa6MuC9e.物品类型, CS_0024_003C_003E8__locals188.ThdaFh3YVi.KhNa6MuC9e.物品名字, CS_0024_003C_003E8__locals188.ThdaFh3YVi.KhNa6MuC9e.物品数量 * CS_0024_003C_003E8__locals188.ThdaFh3YVi.kVDaGeDVAt, false, "地府商城购买到货");
							MyNATSocketClient myNATSocketClient13 = CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E;
							WdAPI i13 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(31, 6);
							defaultInterpolatedStringHandler3.AppendLiteral("你消耗了#R");
							defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals188.ThdaFh3YVi.ot9a2vLQdI);
							defaultInterpolatedStringHandler3.AppendLiteral("#n个#R");
							defaultInterpolatedStringHandler3.AppendFormatted(Singleton<全局变量类>.I.地府商城配置.消耗材料名字);
							defaultInterpolatedStringHandler3.AppendLiteral("#n和#R");
							defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals188.ThdaFh3YVi.roIafslFlp);
							defaultInterpolatedStringHandler3.AppendLiteral("#n");
							string value3;
							if (Singleton<全局变量类>.I.地府商城配置.消耗数值类型 != AllEnums.数值Type.道行)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(5, 1);
								defaultInterpolatedStringHandler4.AppendLiteral("点#R");
								defaultInterpolatedStringHandler4.AppendFormatted(Singleton<全局变量类>.I.地府商城配置.消耗数值类型);
								defaultInterpolatedStringHandler4.AppendLiteral("#n");
								value3 = defaultInterpolatedStringHandler4.ToStringAndClear();
							}
							else
							{
								value3 = "年#R道行#n";
							}
							defaultInterpolatedStringHandler3.AppendFormatted(value3);
							defaultInterpolatedStringHandler3.AppendLiteral("兑换了#R");
							defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals188.ThdaFh3YVi.KhNa6MuC9e.物品数量 * CS_0024_003C_003E8__locals188.ThdaFh3YVi.kVDaGeDVAt);
							defaultInterpolatedStringHandler3.AppendLiteral("#n个#R");
							defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals188.ThdaFh3YVi.KhNa6MuC9e.物品名字);
							defaultInterpolatedStringHandler3.AppendLiteral("#n。");
							myNATSocketClient13.C_Send(i13.提示_提醒和杂项公告(defaultInterpolatedStringHandler3.ToStringAndClear()));
						}
					}
				};
				foreach (KeyValuePair<int, int> item in CS_0024_003C_003E8__locals188.NBbaXJFJuQ)
				{
					if (CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E.user.背包数据.物品列表[item.Key].数量 == item.Value)
					{
						await CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E.S_Send异步(Singleton<WdAPI>.I.CxWI0uMCPh(CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E, item.Key), "地府商城购买确定");
						await Task.Delay(500);
					}
					else
					{
						await CS_0024_003C_003E8__locals188.ThdaFh3YVi.vvsaNhn13E.S_Send异步(Singleton<WdAPI>.I.rxTojoeFsR(item.Key, item.Value), "地府商城购买确定");
						await Task.Delay(100);
					}
				}
			}
			else if (flag)
			{
				if (CS_0024_003C_003E8__locals154.HenaBSVn8v != null)
				{
					CS_0024_003C_003E8__locals154.HenaBSVn8v.每日购买 += CS_0024_003C_003E8__locals154.kVDaGeDVAt;
					CS_0024_003C_003E8__locals154.HenaBSVn8v.累计购买 += CS_0024_003C_003E8__locals154.kVDaGeDVAt;
				}
				switch (Singleton<全局变量类>.I.地府商城配置.消耗数值类型)
				{
				case AllEnums.数值Type.潜能:
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals154.vvsaNhn13E, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.pot, -CS_0024_003C_003E8__locals154.roIafslFlp, false, "地府商城购买");
					break;
				case AllEnums.数值Type.道行:
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals154.vvsaNhn13E, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, -(CS_0024_003C_003E8__locals154.roIafslFlp * 360), false, "地府商城购买");
					break;
				case AllEnums.数值Type.声望:
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals154.vvsaNhn13E, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, -CS_0024_003C_003E8__locals154.roIafslFlp, false, "地府商城购买");
					break;
				case AllEnums.数值Type.累充点:
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals154.vvsaNhn13E, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.reputation, -CS_0024_003C_003E8__locals154.roIafslFlp, false, "地府商城购买");
					break;
				case AllEnums.数值Type.奇宝点:
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals154.vvsaNhn13E, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.reputation, -CS_0024_003C_003E8__locals154.roIafslFlp, false, "地府商城购买");
					break;
				case AllEnums.数值Type.灵气值:
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals154.vvsaNhn13E, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.reputation, -CS_0024_003C_003E8__locals154.roIafslFlp, false, "地府商城购买");
					break;
				}
				Singleton<WdAPI>.I.AKEoOlhFAx(CS_0024_003C_003E8__locals154.vvsaNhn13E, CS_0024_003C_003E8__locals154.KhNa6MuC9e.物品类型, CS_0024_003C_003E8__locals154.KhNa6MuC9e.物品名字, CS_0024_003C_003E8__locals154.KhNa6MuC9e.物品数量 * CS_0024_003C_003E8__locals154.kVDaGeDVAt, false, "地府商城购买到货");
				MyNATSocketClient myNATSocketClient12 = CS_0024_003C_003E8__locals154.vvsaNhn13E;
				WdAPI i12 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 4);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.roIafslFlp);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				string value2;
				if (Singleton<全局变量类>.I.地府商城配置.消耗数值类型 != AllEnums.数值Type.道行)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("点#R");
					defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.地府商城配置.消耗数值类型);
					defaultInterpolatedStringHandler2.AppendLiteral("#n");
					value2 = defaultInterpolatedStringHandler2.ToStringAndClear();
				}
				else
				{
					value2 = "年#R道行#n";
				}
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				defaultInterpolatedStringHandler.AppendLiteral("购买了#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.kVDaGeDVAt);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.KhNa6MuC9e.物品名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				myNATSocketClient12.C_Send(i12.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else
			{
				if (!flag2)
				{
					return;
				}
				_003C_003Ec__DisplayClass14_2 CS_0024_003C_003E8__locals206 = new _003C_003Ec__DisplayClass14_2();
				CS_0024_003C_003E8__locals206.OYcanj3j0k = CS_0024_003C_003E8__locals154;
				CS_0024_003C_003E8__locals206.zQKac9xEy0 = Singleton<WdAPI>.I.取背包物品格子丢弃数(CS_0024_003C_003E8__locals206.OYcanj3j0k.vvsaNhn13E, Singleton<全局变量类>.I.地府商城配置.消耗材料名字, CS_0024_003C_003E8__locals206.OYcanj3j0k.ot9a2vLQdI);
				CS_0024_003C_003E8__locals206.xLFaSsnNTy = 0;
				CS_0024_003C_003E8__locals206.OYcanj3j0k.vvsaNhn13E.销毁回调事件 =  (string v) =>
				{
					if (!(v != Singleton<全局变量类>.I.地府商城配置.消耗材料名字))
					{
						CS_0024_003C_003E8__locals206.xLFaSsnNTy++;
						if (CS_0024_003C_003E8__locals206.xLFaSsnNTy >= CS_0024_003C_003E8__locals206.zQKac9xEy0.Count)
						{
							CS_0024_003C_003E8__locals206.OYcanj3j0k.vvsaNhn13E.销毁回调事件 = null;
							if (CS_0024_003C_003E8__locals206.OYcanj3j0k.HenaBSVn8v != null)
							{
								CS_0024_003C_003E8__locals206.OYcanj3j0k.HenaBSVn8v.每日购买 += CS_0024_003C_003E8__locals206.OYcanj3j0k.kVDaGeDVAt;
								CS_0024_003C_003E8__locals206.OYcanj3j0k.HenaBSVn8v.累计购买 += CS_0024_003C_003E8__locals206.OYcanj3j0k.kVDaGeDVAt;
							}
							Singleton<WdAPI>.I.AKEoOlhFAx(CS_0024_003C_003E8__locals206.OYcanj3j0k.vvsaNhn13E, CS_0024_003C_003E8__locals206.OYcanj3j0k.KhNa6MuC9e.物品类型, CS_0024_003C_003E8__locals206.OYcanj3j0k.KhNa6MuC9e.物品名字, CS_0024_003C_003E8__locals206.OYcanj3j0k.KhNa6MuC9e.物品数量 * CS_0024_003C_003E8__locals206.OYcanj3j0k.kVDaGeDVAt);
							MyNATSocketClient myNATSocketClient13 = CS_0024_003C_003E8__locals206.OYcanj3j0k.vvsaNhn13E;
							WdAPI i13 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(26, 4);
							defaultInterpolatedStringHandler3.AppendLiteral("你消耗了#R");
							defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals206.OYcanj3j0k.ot9a2vLQdI);
							defaultInterpolatedStringHandler3.AppendLiteral("#n个#R");
							defaultInterpolatedStringHandler3.AppendFormatted(Singleton<全局变量类>.I.地府商城配置.消耗材料名字);
							defaultInterpolatedStringHandler3.AppendLiteral("#n兑换了#R");
							defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals206.OYcanj3j0k.kVDaGeDVAt);
							defaultInterpolatedStringHandler3.AppendLiteral("#n个#R");
							defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals206.OYcanj3j0k.KhNa6MuC9e.物品名字);
							defaultInterpolatedStringHandler3.AppendLiteral("#n。");
							myNATSocketClient13.C_Send(i13.提示_提醒和杂项公告(defaultInterpolatedStringHandler3.ToStringAndClear()));
						}
					}
				};
				foreach (KeyValuePair<int, int> item2 in CS_0024_003C_003E8__locals206.zQKac9xEy0)
				{
					if (CS_0024_003C_003E8__locals206.OYcanj3j0k.vvsaNhn13E.user.背包数据.物品列表[item2.Key].数量 == item2.Value)
					{
						await CS_0024_003C_003E8__locals206.OYcanj3j0k.vvsaNhn13E.S_Send异步(Singleton<WdAPI>.I.CxWI0uMCPh(CS_0024_003C_003E8__locals206.OYcanj3j0k.vvsaNhn13E, item2.Key), "地府商城购买确定");
						await Task.Delay(500);
					}
					else
					{
						await CS_0024_003C_003E8__locals206.OYcanj3j0k.vvsaNhn13E.S_Send异步(Singleton<WdAPI>.I.rxTojoeFsR(item2.Key, item2.Value), "地府商城购买确定");
						await Task.Delay(100);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("地府商城购买确定-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void n6qBOuNONA(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_1.Contains("地府操作_购买确定", StringComparison.CurrentCulture))
			{
				地府商城购买确定(P_0, P_1.Replace("地府操作_购买确定", string.Empty));
			}
		}
		catch (Exception ex)
		{
			Log.Error("NPC相关事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public mDs6hiBvFvG3CRi3MZk()
	{
		TrjBpRk3tp = new ConcurrentDictionary<int, int>();
	}

	
	static mDs6hiBvFvG3CRi3MZk()
	{
		lAWB3BUKs3 = new byte[16]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 6,
			61, 243, 0, 79, 1, 49
		};
		QvVBYYxOq8 = new byte[16]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 6,
			61, 243, 0, 79, 1, 0
		};
		IfbB1SM79n = Array.Empty<byte>();
	}
}
