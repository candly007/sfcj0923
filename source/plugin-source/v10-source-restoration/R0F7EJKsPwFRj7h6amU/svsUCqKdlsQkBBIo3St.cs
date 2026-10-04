using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft_X.Json;
using Serilog;
using XWKUjNiqpjLqc4emuCT;
using jVVIM9j1PL0VAliGELE;
using vEAdPGPTkDFOYsbi303;

namespace R0F7EJKsPwFRj7h6amU;

internal class svsUCqKdlsQkBBIo3St : Singleton<svsUCqKdlsQkBBIo3St>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public MyNATSocketClient i5YFVAukUQ;

		
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		
		internal bool xd1FCRoyZT(奇宝斋数据类 x)
		{
			if (x.出售账号 == i5YFVAukUQ.user.人物数据.账号)
			{
				return x.出售数量 > 0;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass12_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public string drVF031Kqc;

		
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		
		internal bool RXiFkl2qNG(角色存档数据类 x)
		{
			return x.账号 == drVF031Kqc;
		}

		static _003C_003Ec__DisplayClass17_0()
		{
		}
	}

	internal ConcurrentQueue<string> pC3KFDFA6k;

	private static object qMaKLJNnfq;

	public static byte[] YXPKSlXvgm;

	public static bool r9kKchaSXB;

	
	[SpecialName]
	public static bool I5CKPFClWO()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.IsVip || Singleton<全局变量类>.I.验证client.授权配置.Is单奇宝斋)
		{
			return Singleton<全局变量类>.I.奇宝斋配置.功能开关;
		}
		return false;
	}

	
	internal void WfVKUuEhbJ()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("奇宝斋配置类.json")))
			{
				Singleton<全局变量类>.I.奇宝斋配置 = JsonConvert.DeserializeObject<奇宝斋配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("奇宝斋配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.奇宝斋配置 = new 奇宝斋配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("奇宝斋配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.奇宝斋配置, Formatting.Indented));
			}
			if (!File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("奇宝交易记录.txt")))
			{
				File.Create(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("奇宝交易记录.txt"));
			}
		}
		catch (Exception ex)
		{
			Log.Error("奇宝斋配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void OB7KWHwPa4()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("奇宝斋配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.奇宝斋配置, Formatting.Indented));
			Log.Debug("奇宝斋配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("奇宝斋配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string hxTKgNnEGq()
	{
		WfVKUuEhbJ();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.奇宝斋配置, Formatting.Indented);
	}

	
	public void NvDKD01bMw(string P_0)
	{
		Singleton<全局变量类>.I.奇宝斋配置 = JsonConvert.DeserializeObject<奇宝斋配置类>(P_0);
		OB7KWHwPa4();
	}

	
	public static string RKBKjNMtDU()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
		defaultInterpolatedStringHandler.AppendLiteral("YJ");
		defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyyMMddHHmmssfffffff");
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler2.AppendFormatted(Singleton<WdAPI>.I.qrjo9TWIdy(0, 32767), "X8");
		defaultInterpolatedStringHandler.AppendFormatted(defaultInterpolatedStringHandler2.ToStringAndClear());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	
	internal void D6mKl3PdeA(MyNATSocketClient P_0)
	{
		try
		{
			if (YXPKSlXvgm != Array.Empty<byte>() && !r9kKchaSXB)
			{
				P_0.C_Send(YXPKSlXvgm);
				return;
			}
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(new byte[9] { 64, 211, 1, 0, 4, 0, 0, 0, 61 }, hasCount: false, 0);
			封包_写2.写字节型(Singleton<全局变量类>.I.奇宝斋配置.物品列表.Count);
			List<奇宝斋数据类> list = Singleton<全局变量类>.I.奇宝斋配置.物品列表.Values.ToList();
			list.Sort();
			for (int i = 0; i < list.Count; i++)
			{
				封包_写2.写字节集(new byte[17]
				{
					16, 48, 48, 48, 48, 48, 48, 48, 48, 48,
					48, 48, 49, 49, 66, 51, 57
				}, hasCount: false, 0);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 2);
				defaultInterpolatedStringHandler.AppendFormatted(list[i].物品权重);
				defaultInterpolatedStringHandler.AppendLiteral("begin");
				defaultInterpolatedStringHandler.AppendFormatted(list[i].物品编号);
				defaultInterpolatedStringHandler.AppendLiteral("end");
				封包_写2.写文本型(defaultInterpolatedStringHandler.ToStringAndClear(), hasCount: true, 0);
				封包_写2.写字节集(new byte[2] { 0, 1 }, hasCount: false, 0);
				封包_写2.写整数型(list[i].物品图标, reverse: true);
				封包_写2.写整数型(list[i].物品价格, reverse: true);
				封包_写2.写字节集(new byte[4], hasCount: false, 0);
				封包_写2.写整数型(int.Parse(list[i].到期时间), reverse: true);
				封包_写2.写文本型(list[i].物品名称, hasCount: true, 0);
				封包_写2.写字节集(new byte[2], hasCount: false, 0);
			}
			YXPKSlXvgm = new byte[19]
			{
				77, 90, 0, 0, 0, 0, 0, 0, 0, 9,
				64, 211, 1, 0, 4, 0, 0, 0, 61
			}.Concat(Singleton<WdAPI>.I.组包包头(封包_写2.取数据())).ToArray();
			P_0.C_Send(YXPKSlXvgm);
		}
		catch (Exception ex)
		{
			Log.Error("奇宝斋_面板失败：" + ex.Message + "(" + ex.StackTrace + ")");
			YXPKSlXvgm = Array.Empty<byte>();
			r9kKchaSXB = true;
		}
	}

	
	internal void JigK8AQ6lE(MyNATSocketClient P_0)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals5.i5YFVAukUQ = P_0;
		try
		{
			if (!I5CKPFClWO())
			{
				return;
			}
			List<奇宝斋数据类> list = Singleton<全局变量类>.I.奇宝斋配置.物品列表.Values.ToList().FindAll( (奇宝斋数据类 x) => x.出售账号 == CS_0024_003C_003E8__locals5.i5YFVAukUQ.user.人物数据.账号 && x.出售数量 > 0);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
			defaultInterpolatedStringHandler.AppendLiteral("你当前可用的奇宝斋余额为：#Y");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals5.i5YFVAukUQ.user.存档数据.奇宝斋存档.奇宝斋余额);
			defaultInterpolatedStringHandler.AppendLiteral("#n");
			StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
			if (!xH3TPsiexTnpJAMMnJm.clyBlug2Xa())
			{
				if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.奇宝斋配置.充值网址))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(34, 1, stringBuilder2);
					handler.AppendLiteral("#r#Y奇宝斋余额充值：#G#url【点击立即充值】{");
					handler.AppendFormatted(Singleton<全局变量类>.I.奇宝斋配置.充值网址);
					handler.AppendLiteral("}#t#n#u");
					stringBuilder3.Append(ref handler);
				}
			}
			else
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(22, 1, stringBuilder2);
				handler.AppendLiteral("#r#Y奇宝斋余额充值比例：1元=");
				handler.AppendFormatted(Singleton<全局变量类>.I.奇宝斋配置.奇宝点比例);
				handler.AppendLiteral("奇宝点#n");
				stringBuilder4.Append(ref handler);
				stringBuilder.Append("[点击进行奇宝点充值/奇宝斋_奇宝点充值]");
			}
			if (list.Count > 0)
			{
				for (int num = 0; num < list.Count; num++)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(17, 3, stringBuilder2);
					handler.AppendLiteral("[【取回】");
					handler.AppendFormatted(list[num].物品名称);
					handler.AppendLiteral("(");
					handler.AppendFormatted(list[num].物品价格);
					handler.AppendLiteral("元)/奇宝斋_取回_");
					handler.AppendFormatted(list[num].物品编号);
					handler.AppendLiteral("]");
					stringBuilder5.Append(ref handler);
				}
			}
			CS_0024_003C_003E8__locals5.i5YFVAukUQ.C_Send(Singleton<WdAPI>.I.对话生成_自己(CS_0024_003C_003E8__locals5.i5YFVAukUQ, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("奇宝斋_收藏-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void luaKInnxZX(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			short num = Singleton<ByteAPI>.I.反转_短整数(Singleton<ByteAPI>.I.取字节集中间(P_1, 17, 2));
			short num2 = Singleton<ByteAPI>.I.反转_短整数(Singleton<ByteAPI>.I.取字节集中间(P_1, 22, 2));
			if (!Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, num2))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R当前物品无法取出，无法上架奇宝斋！"));
				return;
			}
			string 名字 = P_0.user.背包数据.物品列表[num2].名字;
			if (!Singleton<全局变量类>.I.奇宝斋配置.功能开关 || !Singleton<全局变量类>.I.奇宝斋配置.玩家上架开关 || !Singleton<全局变量类>.I.奇宝斋配置.可上架商品.Contains("|" + 名字 + "|", StringComparison.CurrentCulture))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R当前物品无法上架奇宝斋！"));
				return;
			}
			if (P_0.user.背包数据.物品列表[num2].当前耐久度 != P_0.user.背包数据.物品列表[num2].最大耐久度)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R当前物品耐久度未满，无法上架奇宝斋！"));
				return;
			}
			if (P_0.user.人物数据.飞行器 != 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R飞行状态下无法上架！"));
				return;
			}
			if (P_0.user.人物数据.所在地图名字 == "幽雅小居" || P_0.user.人物数据.所在地图名字 == "豪华居所" || P_0.user.人物数据.所在地图名字 == "花园别墅" || P_0.user.人物数据.所在地图名字 == "翡翠庄园" || P_0.user.人物数据.所在地图名字 == "帮派总坛")
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R当前位置无法上架！"));
				return;
			}
			if (P_0.user.存档数据.奇宝斋存档.奇宝斋余额 < Singleton<全局变量类>.I.奇宝斋配置.上架押金)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R当前奇宝斋可用余额不足，无法上架！"));
				return;
			}
			_ = P_0.user.背包数据.物品列表[num2].封包缓存;
			_ = P_0.user.背包数据.物品列表[num2].物品ID;
			int 图标 = P_0.user.背包数据.物品列表[num2].图标;
			ByteAPI.分割字节集(P_1, new byte[4] { 40, 3, 0, 0 });
			string text = RKBKjNMtDU();
			byte[] buffer = Singleton<ByteAPI>.I.HtoC("4D5A00000000000000101042").Concat(Singleton<ByteAPI>.I.到字节集反转(P_0.user.人物数据.角色ID, 4)).Concat(Singleton<ByteAPI>.I.HtoC("08CFFABBD9B5C0BEDF00"))
				.Concat(Singleton<WdAPI>.I.CxWI0uMCPh(P_0, num2))
				.ToArray();
			P_0.S_Send(buffer);
			tVMKi1CdPF(text, 名字, num, 图标, 1, P_0.user.人物数据.账号);
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, -Singleton<全局变量类>.I.奇宝斋配置.上架押金, false, "[奇宝斋上架]消耗");
			r9kKchaSXB = true;
		}
		catch (Exception ex)
		{
			Log.Error("奇宝斋_玩家上架-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void UFFKo9bN60(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.读字节集(12);
			obj.读文本型(out string value, true, (byte)0, false);
			if (Singleton<全局变量类>.I.奇宝斋配置.物品列表.TryGetValue(value, out 奇宝斋数据类 value2))
			{
				封包_写 封包_写2 = new 封包_写();
				封包_写2.写字节集(new byte[2] { 17, 59 }, hasCount: false, 0);
				封包_写2.写文本型(value2.物品编号, hasCount: true, 0);
				封包_写2.写字节集(new byte[13]
				{
					0, 1, 0, 1, 0, 15, 1, 8, 4, 0,
					0, 1, 4
				}, hasCount: false, 0);
				封包_写2.写文本型(value2.物品名称, hasCount: true, 0);
				封包_写2.写字节集(new byte[67]
				{
					0, 206, 3, 0, 0, 1, 4, 1, 55, 4,
					2, 184, 246, 0, 38, 3, 0, 0, 0, 0,
					0, 74, 7, 0, 10, 0, 84, 3, 0, 1,
					160, 201, 0, 209, 4, 4, 189, 240, 201, 171,
					1, 108, 2, 0, 0, 0, 41, 3, 0, 0,
					0, 8, 0, 203, 2, 0, 1, 1, 150, 3,
					0, 0, 1, 244, 0, 3, 3
				}, hasCount: false, 0);
				封包_写2.写整数型(value2.物品图标, reverse: true);
				封包_写2.写字节集(new byte[11]
				{
					1, 252, 1, 0, 0, 207, 3, 0, 0, 1,
					244
				}, hasCount: false, 0);
				P_0.C_Send(Singleton<WdAPI>.I.组包包头(封包_写2.取数据()));
			}
		}
		catch (Exception ex)
		{
			Log.Error("奇宝斋_物品展示-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void JWCKNnYWQj(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(12L, SeekOrigin.Begin);
			string value = obj.读文本型(是否声明长度: true, 0);
			value = Singleton<ByteAPI>.I.取文本中间(value, "begin", "end");
			if (!Singleton<全局变量类>.I.奇宝斋配置.物品列表.TryGetValue(value, out 奇宝斋数据类 value2))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#14#R很遗憾，当前物品已经被其他玩家购买了！"));
				return;
			}
			if (value2.出售数量 < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#35#R很遗憾，当前物品已经被其他玩家购买了！"));
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("你当前可用的奇宝斋余额为：#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.奇宝斋存档.奇宝斋余额);
			defaultInterpolatedStringHandler.AppendLiteral("#n点#r");
			StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
			StringBuilder stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler;
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.奇宝斋配置.充值网址) && !xH3TPsiexTnpJAMMnJm.clyBlug2Xa())
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(32, 1, stringBuilder2);
				handler.AppendLiteral("#Y奇宝斋余额充值：#G#url【点击立即充值】{");
				handler.AppendFormatted(Singleton<全局变量类>.I.奇宝斋配置.充值网址);
				handler.AppendLiteral("}#t#n#u");
				stringBuilder3.Append(ref handler);
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(21, 1, stringBuilder2);
			handler.AppendLiteral("[【奇宝斋余额支付】/奇宝斋_余额支付_");
			handler.AppendFormatted(value);
			handler.AppendLiteral("]");
			stringBuilder4.Append(ref handler);
			if (xH3TPsiexTnpJAMMnJm.clyBlug2Xa())
			{
				if (Singleton<全局变量类>.I.内充支付配置.支付宝支付)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(26, 2, stringBuilder2);
					handler.AppendLiteral("[【支付宝扫码支付(");
					handler.AppendFormatted(value2.物品价格);
					handler.AppendLiteral("元)】/奇宝斋_alipay_");
					handler.AppendFormatted(value);
					handler.AppendLiteral("]");
					stringBuilder5.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.内充支付配置.微信支付)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(24, 2, stringBuilder2);
					handler.AppendLiteral("[【微信扫码支付(");
					handler.AppendFormatted(value2.物品价格);
					handler.AppendLiteral("元)】/奇宝斋_wxpay_");
					handler.AppendFormatted(value);
					handler.AppendLiteral("]");
					stringBuilder6.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.内充支付配置.QQ钱包支付)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(26, 2, stringBuilder2);
					handler.AppendLiteral("[【QQ钱包扫码支付(");
					handler.AppendFormatted(value2.物品价格);
					handler.AppendLiteral("元)】/奇宝斋_qqpay_");
					handler.AppendFormatted(value);
					handler.AppendLiteral("]");
					stringBuilder7.Append(ref handler);
				}
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_自己(P_0, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("奇宝斋_玩家下单-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public 奇宝斋数据类 tVMKi1CdPF(string P_0, string P_1, int P_2, int P_3, int P_4, string P_5, int P_6 = 0, string P_7 = "")
	{
		奇宝斋数据类 奇宝斋数据类2 = new 奇宝斋数据类
		{
			物品编号 = (string.IsNullOrWhiteSpace(P_0) ? RKBKjNMtDU() : P_0),
			物品名称 = P_1,
			物品价格 = P_2,
			物品图标 = P_3,
			出售数量 = P_4,
			出售账号 = P_5,
			物品权重 = P_6,
			到期时间 = "2072086131"
		};
		bool num = Singleton<全局变量类>.I.奇宝斋配置.物品列表.TryAdd(奇宝斋数据类2.物品编号, 奇宝斋数据类2);
		OB7KWHwPa4();
		r9kKchaSXB = num;
		if (!num)
		{
			return null;
		}
		return 奇宝斋数据类2;
	}

	
	internal void YZZKB0B5B2(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass17_0();
			if (!Singleton<全局变量类>.I.奇宝斋配置.物品列表.TryGetValue(P_1, out 奇宝斋数据类 value))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#14#R很遗憾，当前物品已经被其他玩家购买了！"));
				return;
			}
			if (value.出售数量 < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#35#R很遗憾，当前物品已经被其他玩家购买了！"));
				return;
			}
			if (P_0.user.存档数据.奇宝斋存档.奇宝斋余额 < value.物品价格)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#69#R很遗憾，你的余额不足以支付当前物品购买！"));
				return;
			}
			CS_0024_003C_003E8__locals6.drVF031Kqc = value.出售账号;
			int 物品价格 = value.物品价格;
			string 物品名称 = value.物品名称;
			int num = (int)((float)物品价格 * ((float)Singleton<全局变量类>.I.奇宝斋配置.卖出手续费 / 100f));
			if (num < 1 && Singleton<全局变量类>.I.奇宝斋配置.卖出手续费 != 0)
			{
				num = 1;
			}
			int num2 = 物品价格 - num + Singleton<全局变量类>.I.奇宝斋配置.上架押金;
			lock (qMaKLJNnfq)
			{
				value.出售数量--;
				if (value.出售数量 <= 0)
				{
					Singleton<全局变量类>.I.奇宝斋配置.物品列表.TryRemove(P_1, out 奇宝斋数据类 _);
				}
				OB7KWHwPa4();
				ConcurrentQueue<string> concurrentQueue = pC3KFDFA6k;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 5);
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy MM dd HH:mm:ss");
				defaultInterpolatedStringHandler.AppendLiteral(" [买方：");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral("]花费");
				defaultInterpolatedStringHandler.AppendFormatted(物品价格);
				defaultInterpolatedStringHandler.AppendLiteral("奇宝点购买[卖方：");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals6.drVF031Kqc);
				defaultInterpolatedStringHandler.AppendLiteral("]的[");
				defaultInterpolatedStringHandler.AppendFormatted(物品名称);
				defaultInterpolatedStringHandler.AppendLiteral("*1]");
				concurrentQueue.Enqueue(defaultInterpolatedStringHandler.ToStringAndClear());
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, -物品价格, false, "[奇宝斋]购买消耗");
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 4);
				defaultInterpolatedStringHandler.AppendLiteral("买方[");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral("]花费[");
				defaultInterpolatedStringHandler.AppendFormatted(物品价格);
				defaultInterpolatedStringHandler.AppendLiteral("奇宝点]购买卖方[");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals6.drVF031Kqc);
				defaultInterpolatedStringHandler.AppendLiteral("]的[");
				defaultInterpolatedStringHandler.AppendFormatted(物品名称);
				defaultInterpolatedStringHandler.AppendLiteral("*1]");
				i.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 物品名称, AllEnums.指令Type.无, 1, false, defaultInterpolatedStringHandler.ToStringAndClear());
				byte[] first = Singleton<WdAPI>.I.提示_中心提醒("#Y购买成功，你得到了1个#R" + 物品名称 + "#Y。");
				WdAPI i2 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你花费了#R");
				defaultInterpolatedStringHandler.AppendFormatted(物品价格);
				defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点成功购买了#Y1#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(物品名称);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(first.Concat(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
				DB.I.oMuiwEHr6E(P_0.user.人物数据.GID, P_0.user.存档数据);
				if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals6.drVF031Kqc))
				{
					MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定角色账号玩家MyClient(CS_0024_003C_003E8__locals6.drVF031Kqc);
					StringBuilder stringBuilder = new StringBuilder();
					if (myNATSocketClient != null)
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder3 = stringBuilder2;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(72, 7, stringBuilder2);
						handler.AppendLiteral("恭喜道友在奇宝斋寄售的#Y");
						handler.AppendFormatted(物品名称);
						handler.AppendLiteral("（");
						handler.AppendFormatted(物品价格);
						handler.AppendLiteral("元）#n已经成功售出！#r获得#G");
						handler.AppendFormatted(num2);
						handler.AppendLiteral("#n奇宝点#R(物品价格");
						handler.AppendFormatted(物品价格);
						handler.AppendLiteral("元 - 扣除");
						handler.AppendFormatted(Singleton<全局变量类>.I.奇宝斋配置.卖出手续费);
						handler.AppendLiteral("%的卖出手续费");
						handler.AppendFormatted(num);
						handler.AppendLiteral("元 + 返还");
						handler.AppendFormatted(Singleton<全局变量类>.I.奇宝斋配置.上架押金);
						handler.AppendLiteral("元物品上架押金)#n");
						stringBuilder3.Append(ref handler);
						Singleton<WdAPI>.I.PndoGw5lW7(myNATSocketClient, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, num2, false, "[奇宝斋]卖出增加");
						Singleton<fK6mLrjpv26MU2YIIF9>.I.Ym9jrsy6dl(myNATSocketClient, stringBuilder.ToString());
						DB.I.oMuiwEHr6E(myNATSocketClient.user.人物数据.GID, myNATSocketClient.user.存档数据);
					}
					else
					{
						角色存档数据类 角色存档数据类2 = Singleton<全局变量类>.I.角色存档表.Values.ToList().Find( (角色存档数据类 x) => x.账号 == CS_0024_003C_003E8__locals6.drVF031Kqc);
						if (角色存档数据类2 != null)
						{
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(72, 7);
							defaultInterpolatedStringHandler.AppendLiteral("恭喜道友在奇宝斋寄售的#Y");
							defaultInterpolatedStringHandler.AppendFormatted(物品名称);
							defaultInterpolatedStringHandler.AppendLiteral("（");
							defaultInterpolatedStringHandler.AppendFormatted(物品价格);
							defaultInterpolatedStringHandler.AppendLiteral("元）#n已经成功售出！#r获得#G");
							defaultInterpolatedStringHandler.AppendFormatted(num2);
							defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点#R(物品价格");
							defaultInterpolatedStringHandler.AppendFormatted(物品价格);
							defaultInterpolatedStringHandler.AppendLiteral("元 - 扣除");
							defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.奇宝斋配置.卖出手续费);
							defaultInterpolatedStringHandler.AppendLiteral("%的卖出手续费");
							defaultInterpolatedStringHandler.AppendFormatted(num);
							defaultInterpolatedStringHandler.AppendLiteral("元 + 返还");
							defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.奇宝斋配置.上架押金);
							defaultInterpolatedStringHandler.AppendLiteral("元物品上架押金)#n");
							Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder4 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(72, 7, stringBuilder2);
							handler.AppendLiteral("恭喜道友在奇宝斋寄售的#Y");
							handler.AppendFormatted(物品名称);
							handler.AppendLiteral("（");
							handler.AppendFormatted(物品价格);
							handler.AppendLiteral("元）#n已经成功售出！#r获得#G");
							handler.AppendFormatted(num2);
							handler.AppendLiteral("#n奇宝点#R(物品价格");
							handler.AppendFormatted(物品价格);
							handler.AppendLiteral("元 - 扣除");
							handler.AppendFormatted(Singleton<全局变量类>.I.奇宝斋配置.卖出手续费);
							handler.AppendLiteral("%的卖出手续费");
							handler.AppendFormatted(num);
							handler.AppendLiteral("元 + 返还");
							handler.AppendFormatted(Singleton<全局变量类>.I.奇宝斋配置.上架押金);
							handler.AppendLiteral("元物品上架押金)#n");
							stringBuilder4.Append(ref handler);
							角色存档数据类2.奇宝斋存档.奇宝斋余额 += num2;
							角色存档数据类2.邮箱存档.Enqueue(stringBuilder.ToString());
							DB.I.oMuiwEHr6E(角色存档数据类2.GID, 角色存档数据类2);
						}
					}
				}
			}
			r9kKchaSXB = true;
			D6mKl3PdeA(P_0);
		}
		catch (Exception ex)
		{
			Log.Error("奇宝斋余额支付处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task X5gKGaHAv6(MyNATSocketClient P_0, string P_1, AllEnums.支付类型 P_2)
	{
		try
		{
			if (!Singleton<全局变量类>.I.奇宝斋配置.物品列表.TryGetValue(P_1, out 奇宝斋数据类 value))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#14#R很遗憾，当前物品已经被其他玩家购买了！"));
				return;
			}
			if (value.出售数量 < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#35#R很遗憾，当前物品已经被其他玩家购买了！"));
				return;
			}
			Singleton<xH3TPsiexTnpJAMMnJm>.I.wi1BwcNEdS(P_0, "奇宝斋购买", AllEnums.项目类型.奇宝购买, AllEnums.数值Type.道具, value.物品名称, 1, value.物品价格, P_2, string.Empty, P_1);
			Singleton<xH3TPsiexTnpJAMMnJm>.I.h4WBsGPweS(P_0);
			await Task.Delay(0);
		}
		catch (Exception ex)
		{
			Log.Error("奇宝斋扫码支付处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void Df7Kfoshay(MyNATSocketClient P_0)
	{
		try
		{
			if (!Singleton<全局变量类>.I.奇宝斋配置.物品列表.TryGetValue(P_0.user.缓存数据.支付数据.物品编号, out 奇宝斋数据类 value))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#14#R很遗憾，当前物品已经被其他玩家购买了！"));
				return;
			}
			if (value.出售数量 < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#35#R很遗憾，当前物品已经被其他玩家购买了！"));
				return;
			}
			lock (qMaKLJNnfq)
			{
				value.出售数量--;
				if (value.出售数量 <= 0)
				{
					Singleton<全局变量类>.I.奇宝斋配置.物品列表.TryRemove(P_0.user.缓存数据.支付数据.物品编号, out 奇宝斋数据类 _);
				}
				OB7KWHwPa4();
				ConcurrentQueue<string> concurrentQueue = pC3KFDFA6k;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 5);
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy MM dd HH:mm:ss");
				defaultInterpolatedStringHandler.AppendLiteral(" [买方：");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral("]花费");
				defaultInterpolatedStringHandler.AppendFormatted(value.物品价格);
				defaultInterpolatedStringHandler.AppendLiteral("奇宝点购买[卖方：");
				defaultInterpolatedStringHandler.AppendFormatted(value.出售账号);
				defaultInterpolatedStringHandler.AppendLiteral("]的[");
				defaultInterpolatedStringHandler.AppendFormatted(value.物品名称);
				defaultInterpolatedStringHandler.AppendLiteral("*1]");
				concurrentQueue.Enqueue(defaultInterpolatedStringHandler.ToStringAndClear());
				WdAPI i = Singleton<WdAPI>.I;
				string 购买物品名字 = P_0.user.缓存数据.支付数据.购买物品名字;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 3);
				defaultInterpolatedStringHandler.AppendLiteral("买方[");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral("]花费[");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.缓存数据.支付数据.购买物品总价);
				defaultInterpolatedStringHandler.AppendLiteral("元]购买[");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.缓存数据.支付数据.购买物品名字);
				defaultInterpolatedStringHandler.AppendLiteral("*1]");
				i.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 购买物品名字, AllEnums.指令Type.无, 1, false, defaultInterpolatedStringHandler.ToStringAndClear());
				DB.I.oMuiwEHr6E(P_0.user.人物数据.GID, P_0.user.存档数据);
			}
			r9kKchaSXB = true;
			D6mKl3PdeA(P_0);
		}
		catch (Exception ex)
		{
			Log.Error("奇宝斋扫码支付成功-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void vH4K6MJKYe(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (!Singleton<全局变量类>.I.奇宝斋配置.物品列表.TryGetValue(P_1, out 奇宝斋数据类 value))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#80#R【系统】没有的东西你取回个鸡毛啊！"));
				return;
			}
			if (value.出售数量 < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#53#R【系统】没有的东西你取回个鸡毛啊！"));
				return;
			}
			string 物品名称 = value.物品名称;
			int 出售数量 = value.出售数量;
			Singleton<全局变量类>.I.奇宝斋配置.物品列表.TryRemove(P_1, out 奇宝斋数据类 _);
			OB7KWHwPa4();
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, Singleton<全局变量类>.I.奇宝斋配置.上架押金, false, "[奇宝斋]取回增加");
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 3);
			defaultInterpolatedStringHandler.AppendLiteral("卖方[");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
			defaultInterpolatedStringHandler.AppendLiteral("]取回[");
			defaultInterpolatedStringHandler.AppendFormatted(物品名称);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(")]");
			i.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 物品名称, AllEnums.指令Type.无, 出售数量, false, defaultInterpolatedStringHandler.ToStringAndClear());
			WdAPI i2 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("你成功取回了寄售的");
			defaultInterpolatedStringHandler.AppendFormatted(出售数量);
			defaultInterpolatedStringHandler.AppendLiteral("个#R");
			defaultInterpolatedStringHandler.AppendFormatted(物品名称);
			defaultInterpolatedStringHandler.AppendLiteral("#Y。");
			P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			r9kKchaSXB = true;
		}
		catch (Exception ex)
		{
			Log.Error("奇宝斋物品取回处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public async Task HRTK2EpS3M(MyNATSocketClient P_0, string P_1)
	{
		if (int.TryParse(P_1, out var result) && (result <= 0 || result >= 10000))
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你输入的充值金额有误。"));
			return;
		}
		StringBuilder stringBuilder = new StringBuilder("当前充值类型#Y【奇宝点】#n，充值金额#Y【" + P_1 + "元】#n，请选择一下要支付的方式：#r");
		if (Singleton<全局变量类>.I.内充支付配置.支付宝支付)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(32, 2, stringBuilder2);
			handler.AppendLiteral("[【支付宝扫码支付(");
			handler.AppendFormatted(result);
			handler.AppendLiteral("元)】/奇宝斋_奇宝点充值_alipay_");
			handler.AppendFormatted(result);
			handler.AppendLiteral("]");
			stringBuilder3.Append(ref handler);
		}
		if (Singleton<全局变量类>.I.内充支付配置.微信支付)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(30, 2, stringBuilder2);
			handler.AppendLiteral("[【微信扫码支付(");
			handler.AppendFormatted(result);
			handler.AppendLiteral("元)】/奇宝斋_奇宝点充值_wxpay_");
			handler.AppendFormatted(result);
			handler.AppendLiteral("]");
			stringBuilder4.Append(ref handler);
		}
		if (Singleton<全局变量类>.I.内充支付配置.QQ钱包支付)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder5 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(32, 2, stringBuilder2);
			handler.AppendLiteral("[【QQ钱包扫码支付(");
			handler.AppendFormatted(result);
			handler.AppendLiteral("元)】/奇宝斋_奇宝点充值_qqpay_");
			handler.AppendFormatted(result);
			handler.AppendLiteral("]");
			stringBuilder5.Append(ref handler);
		}
		P_0.C_Send(Singleton<WdAPI>.I.对话生成_自己(P_0, stringBuilder.ToString()));
		await Task.Delay(0);
	}

	
	public async Task QjLKmHRcZw(MyNATSocketClient P_0, string P_1)
	{
		await Task.Delay(0);
		AllEnums.支付类型 支付类型 = AllEnums.支付类型.无;
		string s = string.Empty;
		if (Singleton<ByteAPI>.I.寻找文本(P_1, "奇宝斋_奇宝点充值_alipay_"))
		{
			s = P_1.Replace("奇宝斋_奇宝点充值_alipay_", "");
			支付类型 = AllEnums.支付类型.alipay;
		}
		else if (Singleton<ByteAPI>.I.寻找文本(P_1, "奇宝斋_奇宝点充值_wxpay_"))
		{
			s = P_1.Replace("奇宝斋_奇宝点充值_wxpay_", "");
			支付类型 = AllEnums.支付类型.wxpay;
		}
		else if (Singleton<ByteAPI>.I.寻找文本(P_1, "奇宝斋_奇宝点充值_qqpay_"))
		{
			s = P_1.Replace("奇宝斋_奇宝点充值_qqpay_", "");
			支付类型 = AllEnums.支付类型.qqpay;
		}
		if (int.TryParse(s, out var result) && 支付类型 != AllEnums.支付类型.无)
		{
			if (result <= 0 || result >= 10000)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你输入的充值金额有误。"));
				return;
			}
			Singleton<xH3TPsiexTnpJAMMnJm>.I.wi1BwcNEdS(P_0, "奇宝点充值", AllEnums.项目类型.奇宝充值, AllEnums.数值Type.奇宝点, "奇宝点", result * Singleton<全局变量类>.I.奇宝斋配置.奇宝点比例, result, 支付类型);
			Singleton<xH3TPsiexTnpJAMMnJm>.I.h4WBsGPweS(P_0);
		}
	}

	
	public svsUCqKdlsQkBBIo3St()
	{
		pC3KFDFA6k = new ConcurrentQueue<string>();
	}

	
	static svsUCqKdlsQkBBIo3St()
	{
		qMaKLJNnfq = new object();
		YXPKSlXvgm = Array.Empty<byte>();
		r9kKchaSXB = false;
	}
}
