using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Newtonsoft_X.Json;
using Serilog;
using vBIs2Rf2vSSk1OdhoS7;
using vEAdPGPTkDFOYsbi303;

namespace UbblDNG1yFpxk6Q0ui4;

internal class YHfw7nGpg7WfdCBKDH4 : Singleton<YHfw7nGpg7WfdCBKDH4>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public MyNATSocketClient bEDTBZXasT;

		public int epbTG2UM9m;

		public int LeaTf8VbLm;

		public short FgwT6Wmimq;

		
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		
		internal void NhNTipVcZi()
		{
			bEDTBZXasT.user.缓存数据.Is摆摊购买金钱记录 = -1;
			bEDTBZXasT.摆摊购买后调整金钱事件 = null;
			Singleton<WdAPI>.I.PndoGw5lW7(bEDTBZXasT, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, epbTG2UM9m, true, "摆摊购买成功后调整金钱");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(85, 12);
			defaultInterpolatedStringHandler.AppendLiteral("【摊位购买后】[账号：");
			defaultInterpolatedStringHandler.AppendFormatted(bEDTBZXasT.user.人物数据.账号);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[名字：");
			defaultInterpolatedStringHandler.AppendFormatted(bEDTBZXasT.user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[购买物品价格和数量：");
			defaultInterpolatedStringHandler.AppendFormatted(LeaTf8VbLm);
			defaultInterpolatedStringHandler.AppendLiteral("*");
			defaultInterpolatedStringHandler.AppendFormatted(FgwT6Wmimq);
			defaultInterpolatedStringHandler.AppendLiteral("个]");
			defaultInterpolatedStringHandler.AppendLiteral("[购买消耗：");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有金钱：");
			defaultInterpolatedStringHandler.AppendFormatted(bEDTBZXasT.user.背包数据.金钱);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有金元宝：");
			defaultInterpolatedStringHandler.AppendFormatted(bEDTBZXasT.user.背包数据.金元宝);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有银元宝：");
			defaultInterpolatedStringHandler.AppendFormatted(bEDTBZXasT.user.背包数据.银元宝);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有累充点：");
			defaultInterpolatedStringHandler.AppendFormatted(bEDTBZXasT.user.存档数据.累计充值金额);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有南极点：");
			defaultInterpolatedStringHandler.AppendFormatted(bEDTBZXasT.user.存档数据.南极抽奖次数);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有奇宝点：");
			defaultInterpolatedStringHandler.AppendFormatted(bEDTBZXasT.user.存档数据.奇宝斋存档.奇宝斋余额);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			string value;
			if (Singleton<全局变量类>.I.摆摊配置.货币类型 != AllEnums.数值Type.道具)
			{
				value = string.Empty;
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(10, 2);
				defaultInterpolatedStringHandler2.AppendLiteral("[拥有摆摊货币：");
				defaultInterpolatedStringHandler2.AppendFormatted(bEDTBZXasT.user.存档数据.数值存档.摆摊道具货币);
				defaultInterpolatedStringHandler2.AppendLiteral("个");
				defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
				defaultInterpolatedStringHandler2.AppendLiteral("]");
				value = defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			defaultInterpolatedStringHandler.AppendFormatted(value);
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		static _003C_003Ec__DisplayClass14_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public MyNATSocketClient N6iTmQa2bq;

		public int iZqTPSWEDF;

		
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		
		internal void RrNT2inspK()
		{
			N6iTmQa2bq.摆摊购买后调整金钱事件 = null;
			int is摆摊购买金钱记录 = N6iTmQa2bq.user.缓存数据.Is摆摊购买金钱记录;
			N6iTmQa2bq.user.缓存数据.Is摆摊购买金钱记录 = -1;
			Singleton<WdAPI>.I.PndoGw5lW7(N6iTmQa2bq, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, is摆摊购买金钱记录, true, "摆摊取出存储后调整金钱");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			switch (Singleton<全局变量类>.I.摆摊配置.货币类型)
			{
			case AllEnums.数值Type.金元宝:
			{
				WdAPI i6 = Singleton<WdAPI>.I;
				MyNATSocketClient myNATSocketClient6 = N6iTmQa2bq;
				string empty6 = string.Empty;
				int num6 = iZqTPSWEDF;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("摆摊取出存储后的");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
				i6.PndoGw5lW7(myNATSocketClient6, AllEnums.发送数据Type.金元宝, empty6, AllEnums.指令Type.无, num6, false, defaultInterpolatedStringHandler.ToStringAndClear());
				break;
			}
			case AllEnums.数值Type.银元宝:
			{
				WdAPI i5 = Singleton<WdAPI>.I;
				MyNATSocketClient myNATSocketClient5 = N6iTmQa2bq;
				string empty5 = string.Empty;
				int num5 = iZqTPSWEDF;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("摆摊取出存储后的");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
				i5.PndoGw5lW7(myNATSocketClient5, AllEnums.发送数据Type.银元宝, empty5, AllEnums.指令Type.无, num5, false, defaultInterpolatedStringHandler.ToStringAndClear());
				break;
			}
			case AllEnums.数值Type.累充点:
			{
				WdAPI i4 = Singleton<WdAPI>.I;
				MyNATSocketClient myNATSocketClient4 = N6iTmQa2bq;
				string empty4 = string.Empty;
				int num4 = iZqTPSWEDF;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("摆摊取出存储后的");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
				i4.PndoGw5lW7(myNATSocketClient4, AllEnums.发送数据Type.累充点, empty4, AllEnums.指令Type.无, num4, false, defaultInterpolatedStringHandler.ToStringAndClear());
				break;
			}
			case AllEnums.数值Type.南极点:
			{
				WdAPI i3 = Singleton<WdAPI>.I;
				MyNATSocketClient myNATSocketClient3 = N6iTmQa2bq;
				string empty3 = string.Empty;
				int num3 = iZqTPSWEDF;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("摆摊取出存储后的");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
				i3.PndoGw5lW7(myNATSocketClient3, AllEnums.发送数据Type.南极点, empty3, AllEnums.指令Type.无, num3, false, defaultInterpolatedStringHandler.ToStringAndClear());
				break;
			}
			case AllEnums.数值Type.奇宝点:
			{
				WdAPI i2 = Singleton<WdAPI>.I;
				MyNATSocketClient myNATSocketClient2 = N6iTmQa2bq;
				string empty2 = string.Empty;
				int num2 = iZqTPSWEDF;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("摆摊取出存储后的");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
				i2.PndoGw5lW7(myNATSocketClient2, AllEnums.发送数据Type.奇宝点, empty2, AllEnums.指令Type.无, num2, false, defaultInterpolatedStringHandler.ToStringAndClear());
				break;
			}
			case AllEnums.数值Type.灵气值:
			{
				WdAPI i = Singleton<WdAPI>.I;
				MyNATSocketClient myNATSocketClient = N6iTmQa2bq;
				string empty = string.Empty;
				int num = iZqTPSWEDF;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("摆摊取出存储后的");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
				i.PndoGw5lW7(myNATSocketClient, AllEnums.发送数据Type.灵气值, empty, AllEnums.指令Type.无, num, false, defaultInterpolatedStringHandler.ToStringAndClear());
				break;
			}
			case AllEnums.数值Type.道具:
				N6iTmQa2bq.user.存档数据.数值存档.摆摊道具货币 += iZqTPSWEDF;
				break;
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(77, 11);
			defaultInterpolatedStringHandler.AppendLiteral("【取出摆摊账户现金后】[账号：");
			defaultInterpolatedStringHandler.AppendFormatted(N6iTmQa2bq.user.人物数据.账号);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[名字：");
			defaultInterpolatedStringHandler.AppendFormatted(N6iTmQa2bq.user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[要取出现金：");
			defaultInterpolatedStringHandler.AppendFormatted(iZqTPSWEDF);
			defaultInterpolatedStringHandler.AppendLiteral("*");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有金钱：");
			defaultInterpolatedStringHandler.AppendFormatted(N6iTmQa2bq.user.背包数据.金钱);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有金元宝：");
			defaultInterpolatedStringHandler.AppendFormatted(N6iTmQa2bq.user.背包数据.金元宝);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有银元宝：");
			defaultInterpolatedStringHandler.AppendFormatted(N6iTmQa2bq.user.背包数据.银元宝);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有累充点：");
			defaultInterpolatedStringHandler.AppendFormatted(N6iTmQa2bq.user.存档数据.累计充值金额);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有南极点：");
			defaultInterpolatedStringHandler.AppendFormatted(N6iTmQa2bq.user.存档数据.南极抽奖次数);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有奇宝点：");
			defaultInterpolatedStringHandler.AppendFormatted(N6iTmQa2bq.user.存档数据.奇宝斋存档.奇宝斋余额);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			string value;
			if (Singleton<全局变量类>.I.摆摊配置.货币类型 != AllEnums.数值Type.道具)
			{
				value = string.Empty;
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(10, 2);
				defaultInterpolatedStringHandler2.AppendLiteral("[拥有摆摊货币：");
				defaultInterpolatedStringHandler2.AppendFormatted(N6iTmQa2bq.user.存档数据.数值存档.摆摊道具货币);
				defaultInterpolatedStringHandler2.AppendLiteral("个");
				defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
				defaultInterpolatedStringHandler2.AppendLiteral("]");
				value = defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			defaultInterpolatedStringHandler.AppendFormatted(value);
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		static _003C_003Ec__DisplayClass15_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public MyNATSocketClient iKqTFDYGLa;

		public int nedTLUuPRA;

		public List<int> iO8TSl2H0G;

		public int UHATcjxyKM;

		
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		
		internal void UYTTXmqv9Q(string v)
		{
			if (!(v != Singleton<全局变量类>.I.摆摊配置.货币道具))
			{
				nedTLUuPRA++;
				if (nedTLUuPRA >= iO8TSl2H0G.Count)
				{
					iKqTFDYGLa.销毁回调事件 = null;
					iKqTFDYGLa.user.存档数据.数值存档.摆摊道具货币 += UHATcjxyKM;
					MyNATSocketClient myNATSocketClient = iKqTFDYGLa;
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 5);
					defaultInterpolatedStringHandler.AppendLiteral("你往百宝囊中存放了#R");
					defaultInterpolatedStringHandler.AppendFormatted(UHATcjxyKM);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.道具单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n，当前存放数量为#R");
					defaultInterpolatedStringHandler.AppendFormatted(iKqTFDYGLa.user.存档数据.数值存档.摆摊道具货币);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.道具单位);
					defaultInterpolatedStringHandler.AppendLiteral("。");
					myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					DB.I.oMuiwEHr6E(iKqTFDYGLa.user.人物数据.GID, iKqTFDYGLa.user.存档数据);
				}
			}
		}

		static _003C_003Ec__DisplayClass16_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public short DYVT5aJStD;

		public Func<int, bool> RdxTM57ro3;

		
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		
		internal bool xxgTnZil0d(int x)
		{
			return x == DYVT5aJStD;
		}

		static _003C_003Ec__DisplayClass8_0()
		{
		}
	}

	public static StringBuilder bsAfdnNsoZ;

	
	[SpecialName]
	public static bool qapfK9UWNV()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is摆摊系统)
		{
			return Singleton<全局变量类>.I.摆摊配置.功能开关;
		}
		return false;
	}

	
	internal void a7oGx57LZC()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("摆摊配置类.json")))
			{
				Singleton<全局变量类>.I.摆摊配置 = JsonConvert.DeserializeObject<摆摊配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("摆摊配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.摆摊配置 = new 摆摊配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("摆摊配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.摆摊配置, Formatting.Indented));
			}
			bsAfdnNsoZ.Clear();
			if (Singleton<全局变量类>.I.摆摊配置.货币类型 == AllEnums.数值Type.道具 && !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.摆摊配置.货币道具))
			{
				StringBuilder stringBuilder = bsAfdnNsoZ;
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 2, stringBuilder);
				handler.AppendLiteral("#L");
				handler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.道具单位);
				handler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
				handler.AppendLiteral("#n");
				stringBuilder2.Append(ref handler);
			}
			else
			{
				StringBuilder stringBuilder = bsAfdnNsoZ;
				StringBuilder stringBuilder3 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder);
				handler.AppendLiteral("#L");
				handler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
				handler.AppendLiteral("#n");
				stringBuilder3.Append(ref handler);
			}
		}
		catch (Exception ex)
		{
			Log.Error("摆摊配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void BqYGHjwmxs()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("摆摊配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.摆摊配置, Formatting.Indented));
			Log.Debug("摆摊配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("摆摊配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string kQyG43gxlw()
	{
		a7oGx57LZC();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.摆摊配置, Formatting.Indented);
	}

	
	public void UOKGeGO3Co(string P_0)
	{
		Singleton<全局变量类>.I.摆摊配置 = JsonConvert.DeserializeObject<摆摊配置类>(P_0);
		BqYGHjwmxs();
	}

	
	internal bool wEwGqeJbdD(MyNATSocketClient P_0, StringBuilder P_1, int P_2)
	{
		try
		{
			if (Singleton<ByteAPI>.I.寻找文本(P_1.ToString(), "购买失败，你身上的金钱不足"))
			{
				return true;
			}
			bool flag = false;
			if (Singleton<ByteAPI>.I.寻找文本与(P_1.ToString(), "货物总价值", "容纳"))
			{
				P_1.Replace("容纳", "存储");
			}
			if (Singleton<ByteAPI>.I.寻找文本与(P_1.ToString(), "你摊位上出售的货物总价值为", "你的自动摆摊账户还能"))
			{
				P_1.Replace("文钱#n", bsAfdnNsoZ.ToString());
				flag = true;
			}
			else if (Singleton<ByteAPI>.I.寻找文本与(P_1.ToString(), "#R你摊位上出售的货物总价值已高于#n", "超过了你所能拥有的金钱上限"))
			{
				P_1.Replace("#R你摊位上出售的货物总价值已高于#n", "你摊位上出售的货物总价值已高于");
				P_1.Replace("#R文钱#n#R", bsAfdnNsoZ.ToString());
				string oldValue = "超过了你所能拥有的金钱上限";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
				defaultInterpolatedStringHandler.AppendLiteral("超过了你所能存储的");
				defaultInterpolatedStringHandler.AppendFormatted((Singleton<全局变量类>.I.摆摊配置.货币类型 == AllEnums.数值Type.道具) ? (Singleton<全局变量类>.I.摆摊配置.货币道具 ?? "") : ((object)Singleton<全局变量类>.I.摆摊配置.货币类型));
				defaultInterpolatedStringHandler.AppendLiteral("上限");
				P_1.Replace(oldValue, defaultInterpolatedStringHandler.ToStringAndClear());
				P_1.Replace("以免金钱丢失", "以免货币丢失");
				flag = true;
			}
			else if (Singleton<ByteAPI>.I.寻找文本与(P_1.ToString(), "你当前摊位上出售的货物总价值为", "而你自动摆摊账户所能"))
			{
				P_1.Replace("#R你当前摊位上出售的货物总价值为#n", "你当前摊位上出售的货物总价值为");
				P_1.Replace("#R文钱#n#R", bsAfdnNsoZ.ToString());
				string oldValue2 = "而你自动摆摊账户所能存储的金钱上限为";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("而你自动摆摊账户所能存储的");
				defaultInterpolatedStringHandler.AppendFormatted((Singleton<全局变量类>.I.摆摊配置.货币类型 == AllEnums.数值Type.道具) ? (Singleton<全局变量类>.I.摆摊配置.货币道具 ?? "") : ((object)Singleton<全局变量类>.I.摆摊配置.货币类型));
				defaultInterpolatedStringHandler.AppendLiteral("上限为");
				P_1.Replace(oldValue2, defaultInterpolatedStringHandler.ToStringAndClear());
				P_1.Replace("#R文钱#n", bsAfdnNsoZ.ToString());
				flag = true;
			}
			else if (Singleton<ByteAPI>.I.寻找文本与(P_1.ToString(), "你花费了", "文钱", "#n#Z", "(", ",", ")", "中购买了"))
			{
				P_0.摆摊购买后调整金钱事件?.Invoke();
				P_1.Replace("文钱", bsAfdnNsoZ.ToString());
				flag = true;
			}
			else if (Singleton<ByteAPI>.I.寻找文本与(P_1.ToString(), "你自动摆摊摊位的", "#n被买走，你获得了"))
			{
				P_1.Replace("文钱", bsAfdnNsoZ.ToString());
				string oldValue3 = "当前自动摆摊账户的现金";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
				defaultInterpolatedStringHandler.AppendLiteral("当前自动摆摊账户存储的");
				defaultInterpolatedStringHandler.AppendFormatted((Singleton<全局变量类>.I.摆摊配置.货币类型 == AllEnums.数值Type.道具) ? (Singleton<全局变量类>.I.摆摊配置.货币道具 ?? "") : ((object)Singleton<全局变量类>.I.摆摊配置.货币类型));
				P_1.Replace(oldValue3, defaultInterpolatedStringHandler.ToStringAndClear());
				P_1.Replace("请及时取出", "请及时从摊位账户中取出存放到百宝囊");
				flag = true;
			}
			else if (Singleton<ByteAPI>.I.寻找文本与(P_1.ToString(), "你从自动摆摊账户中取出了", "文钱"))
			{
				if (P_2 == 2829)
				{
					P_0.摆摊购买后调整金钱事件?.Invoke();
				}
				P_1.Replace("文钱", bsAfdnNsoZ.ToString());
				P_1.Append("已自动存放进百宝囊中。");
				flag = true;
			}
			if (flag)
			{
				switch (P_2)
				{
				case 8165:
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒(P_1.ToString()));
					break;
				case 2829:
					P_0.C_Send(Singleton<WdAPI>.I.提示_杂项公告(P_1.ToString()));
					break;
				}
			}
			return flag;
		}
		catch (Exception ex)
		{
			Log.Error("更正关于摆摊提示信息-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal byte[] WbyGrSj3WK(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			int num = 0;
			short num2 = 0;
			int num3 = 0;
			int num4 = 0;
			short num5 = 0;
			short num6 = 0;
			string empty = string.Empty;
			Array.Empty<byte>();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写文本型(封包_读2.读文本型(out string _, true, (byte)0, false), hasCount: true, 0);
			封包_写2.写字节集(封包_读2.读字节集(1), hasCount: false, 0);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value2), reverse: true);
			封包_写 封包_写3 = new 封包_写();
			物品信息类 物品信息类2 = null;
			for (int i = 0; i < value2; i++)
			{
				num4 = 封包_读2.读整数型(reverse: true);
				num5 = 封包_读2.读短整数型(reverse: true);
				num6 = 封包_读2.读短整数型(reverse: true);
				封包_写3.清数据();
				封包_写3.写短整数型(num6, reverse: true);
				if (物品信息类2 == null)
				{
					物品信息类2 = new 物品信息类
					{
						Index = num5,
						摊位价格 = num4
					};
				}
				else
				{
					物品信息类2.C7n8ZR5IQ0(num5);
					物品信息类2.摊位价格 = num4;
				}
				for (int j = 0; j < num6; j++)
				{
					_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass8_0();
					封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out CS_0024_003C_003E8__locals8.DYVT5aJStD), reverse: true);
					封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value3), reverse: true);
					for (int k = 0; k < value3; k++)
					{
						封包_写3.写字节集(封包_读2.读字节集(2, out byte[] value4), hasCount: false, 0);
						封包_写3.写字节型(封包_读2.读字节型(out var value5));
						short 属性标识 = Singleton<ByteAPI>.I.反转_短整数(value4);
						num = 0;
						num2 = 0;
						num3 = 0;
						empty = string.Empty;
						switch (value5)
						{
						case 1:
							num = 封包_读2.读字节型();
							if (Enumerable.SequenceEqual(value4, Singleton<ByteAPI>.I.HtoC("01B1")))
							{
								物品信息类2.装备已进化次数 = num;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 151 }))
							{
								物品信息类2.是否绑定 = num >= 3;
								物品信息类2.绑定状态 = ((num != 3 && num != 4) ? AllEnums.绑定Type.不绑定 : ((num == 4) ? AllEnums.绑定Type.死绑 : AllEnums.绑定Type.红绑));
							}
							封包_写3.写字节型(num);
							break;
						case 2:
							num2 = 封包_读2.读短整数型(reverse: true);
							if (Enumerable.SequenceEqual(value4, Singleton<ByteAPI>.I.HtoC("00CB")))
							{
								物品信息类2.数量 = num2;
							}
							封包_写3.写短整数型(num2, reverse: true);
							break;
						case 3:
							num3 = 封包_读2.读整数型(reverse: true);
							if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 84 }))
							{
								物品信息类2.物品ID = num3;
							}
							else if (Enumerable.SequenceEqual(value4, Singleton<ByteAPI>.I.HtoC("0251")))
							{
								物品信息类2.首饰可转换次数 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, Singleton<ByteAPI>.I.HtoC("0247")))
							{
								物品信息类2.首饰已转换次数 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 6 }) && num3 == 999)
							{
								num3 = 0;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 7 }))
							{
								物品信息类2.绑定气血 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 10 }))
							{
								物品信息类2.装备天伤 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 12 }))
							{
								物品信息类2.绑定法力 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 40 }))
							{
								物品信息类2.图标 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 42 }))
							{
								物品信息类2.当前耐久度 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 43 }))
							{
								物品信息类2.最大耐久度 = num3;
							}
							else if (!Enumerable.SequenceEqual(value4, new byte[2] { 0, 206 }) && Enumerable.SequenceEqual(value4, new byte[2] { 0, 208 }))
							{
								物品信息类2.改造等级 = num3;
							}
							封包_写3.写整数型(num3, reverse: true);
							break;
						case 4:
							empty = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
							if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 1 }))
							{
								if (CS_0024_003C_003E8__locals8.DYVT5aJStD == 1)
								{
									物品信息类2.名字 = empty;
									物品信息类2.前缀 = ((empty.Length > Singleton<全局变量类>.I.config.前缀长度) ? Singleton<ByteAPI>.I.取文本左边(empty, Singleton<全局变量类>.I.config.前缀长度) : string.Empty);
								}
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 55 }))
							{
								物品信息类2.单位 = empty;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 8 }))
							{
								物品信息类2.描述 = empty;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 89 }))
							{
								物品信息类2.改造人 = empty;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 209 }))
							{
								物品信息类2.物品颜色 = empty;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 2, 65 }))
							{
								物品信息类2.别名 = empty;
							}
							封包_写3.写文本型(empty, hasCount: true, 0, reverse: true);
							break;
						case 6:
							num = 封包_读2.读字节型();
							if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 202 }))
							{
								物品信息类2.物品类型 = (byte)num;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 205 }))
							{
								物品信息类2.等级 = (byte)num;
							}
							封包_写3.写字节型(num);
							break;
						case 7:
							num2 = 封包_读2.读短整数型(reverse: true);
							封包_写3.写短整数型(num2, reverse: true);
							break;
						}
						if (全局常量类.属性类别组.Any( (int x) => x == CS_0024_003C_003E8__locals8.DYVT5aJStD))
						{
							switch (value5)
							{
							case 1:
								物品信息类2.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.DYVT5aJStD,
									属性标识 = 属性标识,
									属性数值 = num
								});
								break;
							case 2:
								物品信息类2.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.DYVT5aJStD,
									属性标识 = 属性标识,
									属性数值 = num2
								});
								break;
							case 3:
								物品信息类2.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.DYVT5aJStD,
									属性标识 = 属性标识,
									属性数值 = num3
								});
								break;
							case 6:
								物品信息类2.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.DYVT5aJStD,
									属性标识 = 属性标识,
									属性数值 = num
								});
								break;
							case 7:
								物品信息类2.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.DYVT5aJStD,
									属性标识 = 属性标识,
									属性数值 = num2
								});
								break;
							}
						}
					}
				}
				物品信息类2.rgh8r0QQvs(P_0);
				if (Singleton<COyX27f6L3uCF3F6Kp5>.I.rCpfLKhKrZ(P_0, 物品信息类2))
				{
					物品信息类2.封包缓存 = 封包_写3.取数据();
					封包_写3.清数据();
					封包_写3.写入数据(Singleton<COyX27f6L3uCF3F6Kp5>.I.KDQfSpe9nM(P_0, 物品信息类2.封包缓存, 物品信息类2), hasCount: false, 0);
				}
				物品信息类2.封包缓存 = 封包_写3.取数据();
				封包_写2.写整数型(num4, reverse: true);
				封包_写2.写短整数型(num5, reverse: true);
				封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			}
			P_1 = Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("接收_摆摊响应-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] x4jGZGHH44(MyNATSocketClient P_0, byte[] P_1)
	{
		封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
		封包_写 封包_写2 = new 封包_写();
		封包_读2.Seek(10L, SeekOrigin.Begin);
		封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
		封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
		封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
		封包_写2.写文本型(封包_读2.读文本型(out string value, true, (byte)0, false), hasCount: true, 0);
		封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
		封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
		封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
		封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var value5), reverse: true);
		封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var value6), reverse: true);
		封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var value7), reverse: true);
		封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
		bool flag = value == Singleton<ByteAPI>.I.GetHexGid_(P_0.user.人物数据.GID);
		if (flag)
		{
			P_0.user.存档数据.摊位ID = value5;
			P_0.user.存档数据.摊位现金 = value6;
		}
		else
		{
			P_0.user.缓存数据.打开摊位数据.摊位ID = value5;
			P_0.user.缓存数据.打开摊位数据.摊位存金 = value6;
			P_0.user.缓存数据.打开摊位数据.摊位存金上限 = value7;
		}
		if (qapfK9UWNV() && Singleton<全局变量类>.I.摆摊配置.货币类型 != AllEnums.数值Type.无)
		{
			if (flag)
			{
				WdAPI i = Singleton<WdAPI>.I;
				string text = "你当前摊位出售的物品和宠物在卖出时将以";
				string text2;
				if (Singleton<全局变量类>.I.摆摊配置.货币类型 == AllEnums.数值Type.道具)
				{
					text2 = "百宝囊中存储的#Y" + Singleton<全局变量类>.I.摆摊配置.货币道具;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
					text2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				P_0.C_Send(i.提示_中心提醒(text + text2 + "#n代替金钱作为结算。"));
			}
			else
			{
				WdAPI i2 = Singleton<WdAPI>.I;
				string text3 = "你在当前摊位购买物品和宠物时将以";
				string text4;
				if (Singleton<全局变量类>.I.摆摊配置.货币类型 == AllEnums.数值Type.道具)
				{
					text4 = "百宝囊中存储的#Y" + Singleton<全局变量类>.I.摆摊配置.货币道具;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
					text4 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				P_0.C_Send(i2.提示_中心提醒(text3 + text4 + "#n代替金钱作为购买花费。"));
			}
			switch (Singleton<全局变量类>.I.摆摊配置.货币类型)
			{
			case AllEnums.数值Type.累充点:
			{
				WdAPI i8 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你当前的#R累充点#n：#G");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.累计充值金额);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				P_0.C_Send(i8.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.南极点:
			{
				WdAPI i7 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你当前的#R南极点#n：#G");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.南极抽奖次数);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				P_0.C_Send(i7.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.奇宝点:
			{
				WdAPI i6 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你当前的#R奇宝点#n：#G");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.奇宝斋存档.奇宝斋余额);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				P_0.C_Send(i6.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.灵气值:
			{
				WdAPI i5 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你当前的#R灵气值#n：#G");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.数值存档.灵气值);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				P_0.C_Send(i5.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.道具:
			{
				WdAPI i3 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你当前百宝囊中#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
				defaultInterpolatedStringHandler.AppendLiteral("#n存储数量：#G");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.数值存档.摆摊道具货币);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.道具单位);
				byte[] first = i3.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear());
				WdAPI i4 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#G温馨提示：#n请先打开#Y小助手#n或者在#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.存取NPC名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n处存储一定数量的#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
				defaultInterpolatedStringHandler.AppendLiteral("#n存放进百宝囊，以免在购买物品时出现购买失败的情况呦。");
				P_0.C_Send(first.Concat(i4.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
				break;
			}
			}
		}
		return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
	}

	
	internal byte[] gFOGtSxclt(byte[] P_0)
	{
		封包_读 封包_读2 = new 封包_读(P_0, 0, P_0.Length);
		封包_写 封包_写2 = new 封包_写();
		封包_读2.Seek(10L, SeekOrigin.Begin);
		封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
		封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
		封包_写2.写整数型(封包_读2.读整数型(reverse: true), reverse: true);
		封包_写2.写文本型(封包_读2.读文本型(out string value, true, (byte)0, false), hasCount: true, 0);
		封包_读2.读文本型(out string value2, true, (byte)1, true);
		封包_写2.写文本型("#dFFFFFF{\t" + value + "的摊位}", hasCount: true, 1, reverse: true);
		封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
		封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
		封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
		封包_写2.写字节集(new byte[11]
		{
			0, 1, 0, 0, 0, 15, 0, 0, 0, 0,
			1
		}, hasCount: false, 0);
		封包_写2.写文本型(value2.Replace("#dFFFFFF", string.Empty), hasCount: true, 0);
		封包_写2.写字节集(new byte[13]
		{
			0, 0, 0, 160, 0, 1, 0, 1, 0, 0,
			0, 0, 0
		}, hasCount: false, 0);
		return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
	}

	
	internal byte[] hEyGAJ0Jyy(MyNATSocketClient P_0, string P_1)
	{
		string[] array = P_1.Split("/");
		if (array.Length != 3)
		{
			return null;
		}
		if (string.IsNullOrWhiteSpace(array[0]) || string.IsNullOrWhiteSpace(array[1]) || string.IsNullOrWhiteSpace(array[2]))
		{
			return null;
		}
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[12]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 6,
			80, 2
		}, hasCount: false, 0);
		封包_写2.写整数型(int.Parse(array[1]), reverse: true);
		return 封包_写2.取数据();
	}

	
	internal byte[] XFiGz7GUDa(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			if (!qapfK9UWNV())
			{
				return P_1;
			}
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_读2.读文本型(out string value, true, (byte)1, true);
			value = value.Replace("文钱", $"{bsAfdnNsoZ}");
			封包_写2.写文本型(value, hasCount: true, 1, reverse: true);
			封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("接收_摆摊上架确定询问-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] J7ffua6YYd(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			if (!qapfK9UWNV())
			{
				return P_1;
			}
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_读2.读整数型(reverse: true, out var value);
			封包_写2.写整数型(value, reverse: true);
			封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("接收_摆摊上架确定询问-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] QJSfwnhYfW(MyNATSocketClient P_0, byte[] P_1)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals64 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals64.bEDTBZXasT = P_0;
		try
		{
			if (!qapfK9UWNV())
			{
				return P_1;
			}
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 obj = new 封包_写();
			new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			obj.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			obj.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
			obj.写整数型(封包_读2.读整数型(reverse: true), reverse: true);
			obj.写短整数型(封包_读2.读短整数型(reverse: true, out CS_0024_003C_003E8__locals64.FgwT6Wmimq), reverse: true);
			obj.写整数型(封包_读2.读整数型(reverse: true, out CS_0024_003C_003E8__locals64.LeaTf8VbLm), reverse: true);
			obj.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			long num = CS_0024_003C_003E8__locals64.FgwT6Wmimq * CS_0024_003C_003E8__locals64.LeaTf8VbLm;
			CS_0024_003C_003E8__locals64.epbTG2UM9m = CS_0024_003C_003E8__locals64.bEDTBZXasT.user.背包数据.金钱;
			if (num <= 0)
			{
				return null;
			}
			if (num > CS_0024_003C_003E8__locals64.bEDTBZXasT.user.缓存数据.打开摊位数据.摊位存金上限 - CS_0024_003C_003E8__locals64.bEDTBZXasT.user.缓存数据.打开摊位数据.摊位存金)
			{
				CS_0024_003C_003E8__locals64.bEDTBZXasT.C_Send(Singleton<WdAPI>.I.提示_中心提醒("购买失败，卖家摊位账号已经无法容纳更多的#R" + ((Singleton<全局变量类>.I.摆摊配置.货币类型 != AllEnums.数值Type.道具) ? $"{Singleton<全局变量类>.I.摆摊配置.货币类型}" : Singleton<全局变量类>.I.摆摊配置.货币道具) + "#n。"));
				return null;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(85, 12);
			defaultInterpolatedStringHandler.AppendLiteral("【摊位购买前】[账号：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.人物数据.账号);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[名字：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[购买物品价格和数量：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals64.LeaTf8VbLm);
			defaultInterpolatedStringHandler.AppendLiteral("*");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals64.FgwT6Wmimq);
			defaultInterpolatedStringHandler.AppendLiteral("个]");
			defaultInterpolatedStringHandler.AppendLiteral("[购买消耗：");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有金钱：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.背包数据.金钱);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有金元宝：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.背包数据.金元宝);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有银元宝：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.背包数据.银元宝);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有累充点：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.累计充值金额);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有南极点：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.南极抽奖次数);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有奇宝点：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.奇宝斋存档.奇宝斋余额);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			string value;
			if (Singleton<全局变量类>.I.摆摊配置.货币类型 != AllEnums.数值Type.道具)
			{
				value = string.Empty;
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(10, 2);
				defaultInterpolatedStringHandler2.AppendLiteral("[拥有摆摊货币：");
				defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.数值存档.摆摊道具货币);
				defaultInterpolatedStringHandler2.AppendLiteral("个");
				defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
				defaultInterpolatedStringHandler2.AppendLiteral("]");
				value = defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			defaultInterpolatedStringHandler.AppendFormatted(value);
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			switch (Singleton<全局变量类>.I.摆摊配置.货币类型)
			{
			case AllEnums.数值Type.金元宝:
				if (CS_0024_003C_003E8__locals64.bEDTBZXasT.user.背包数据.金元宝 < num)
				{
					CS_0024_003C_003E8__locals64.bEDTBZXasT.C_Send(Singleton<WdAPI>.I.提示_中心提醒("购买失败，你身上的#R金元宝#n不足。"));
					return null;
				}
				if (!Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals64.bEDTBZXasT, AllEnums.发送数据Type.金元宝, string.Empty, AllEnums.指令Type.无, (int)(-num), false, "摊位购买"))
				{
					CS_0024_003C_003E8__locals64.bEDTBZXasT.C_Send(Singleton<WdAPI>.I.提示_中心提醒("购买失败，你身上的#R金元宝#n不足。"));
					return null;
				}
				break;
			case AllEnums.数值Type.银元宝:
				if (CS_0024_003C_003E8__locals64.bEDTBZXasT.user.背包数据.银元宝 < num)
				{
					CS_0024_003C_003E8__locals64.bEDTBZXasT.C_Send(Singleton<WdAPI>.I.提示_中心提醒("购买失败，你身上的#R银元宝#n不足。"));
					return null;
				}
				if (!Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals64.bEDTBZXasT, AllEnums.发送数据Type.银元宝, string.Empty, AllEnums.指令Type.无, (int)(-num), false, "摊位购买"))
				{
					CS_0024_003C_003E8__locals64.bEDTBZXasT.C_Send(Singleton<WdAPI>.I.提示_中心提醒("购买失败，你身上的#R银元宝#n不足。"));
					return null;
				}
				break;
			case AllEnums.数值Type.累充点:
				if (CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.累计充值金额 < num)
				{
					CS_0024_003C_003E8__locals64.bEDTBZXasT.C_Send(Singleton<WdAPI>.I.提示_中心提醒("购买失败，你身上的#R累充点#n不足。"));
					return null;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals64.bEDTBZXasT, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, (int)(-num), false, "摊位购买");
				break;
			case AllEnums.数值Type.南极点:
				if (CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.南极抽奖次数 < num)
				{
					CS_0024_003C_003E8__locals64.bEDTBZXasT.C_Send(Singleton<WdAPI>.I.提示_中心提醒("购买失败，你身上的#R南极点#n不足。"));
					return null;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals64.bEDTBZXasT, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, (int)(-num), false, "摊位购买");
				break;
			case AllEnums.数值Type.奇宝点:
				if (CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.奇宝斋存档.奇宝斋余额 < num)
				{
					CS_0024_003C_003E8__locals64.bEDTBZXasT.C_Send(Singleton<WdAPI>.I.提示_中心提醒("购买失败，你身上的#R奇宝点#n不足。"));
					return null;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals64.bEDTBZXasT, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, (int)(-num), false, "摊位购买");
				break;
			case AllEnums.数值Type.灵气值:
				if (CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.数值存档.灵气值 < num)
				{
					CS_0024_003C_003E8__locals64.bEDTBZXasT.C_Send(Singleton<WdAPI>.I.提示_中心提醒("购买失败，你身上的#R灵气值#n不足。"));
					return null;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals64.bEDTBZXasT, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, (int)(-num), false, "摊位购买");
				break;
			case AllEnums.数值Type.道具:
				if (CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.数值存档.摆摊道具货币 < num)
				{
					CS_0024_003C_003E8__locals64.bEDTBZXasT.C_Send(Singleton<WdAPI>.I.提示_中心提醒("购买失败，你的百宝囊中存储的#R" + Singleton<全局变量类>.I.摆摊配置.货币道具 + "#n不足。"));
					return null;
				}
				CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.数值存档.摆摊道具货币 -= (int)num;
				break;
			}
			CS_0024_003C_003E8__locals64.bEDTBZXasT.user.缓存数据.Is摆摊购买金钱记录 = CS_0024_003C_003E8__locals64.epbTG2UM9m;
			CS_0024_003C_003E8__locals64.bEDTBZXasT.摆摊购买后调整金钱事件 =  () =>
			{
				CS_0024_003C_003E8__locals64.bEDTBZXasT.user.缓存数据.Is摆摊购买金钱记录 = -1;
				CS_0024_003C_003E8__locals64.bEDTBZXasT.摆摊购买后调整金钱事件 = null;
				Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals64.bEDTBZXasT, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, CS_0024_003C_003E8__locals64.epbTG2UM9m, true, "摆摊购买成功后调整金钱");
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(85, 12);
				defaultInterpolatedStringHandler3.AppendLiteral("【摊位购买后】[账号：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.人物数据.账号);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[名字：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.人物数据.昵称);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[购买物品价格和数量：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals64.LeaTf8VbLm);
				defaultInterpolatedStringHandler3.AppendLiteral("*");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals64.FgwT6Wmimq);
				defaultInterpolatedStringHandler3.AppendLiteral("个]");
				defaultInterpolatedStringHandler3.AppendLiteral("[购买消耗：");
				defaultInterpolatedStringHandler3.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[拥有金钱：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.背包数据.金钱);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[拥有金元宝：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.背包数据.金元宝);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[拥有银元宝：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.背包数据.银元宝);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[拥有累充点：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.累计充值金额);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[拥有南极点：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.南极抽奖次数);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[拥有奇宝点：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.奇宝斋存档.奇宝斋余额);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				string value2;
				if (Singleton<全局变量类>.I.摆摊配置.货币类型 != AllEnums.数值Type.道具)
				{
					value2 = string.Empty;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(10, 2);
					defaultInterpolatedStringHandler4.AppendLiteral("[拥有摆摊货币：");
					defaultInterpolatedStringHandler4.AppendFormatted(CS_0024_003C_003E8__locals64.bEDTBZXasT.user.存档数据.数值存档.摆摊道具货币);
					defaultInterpolatedStringHandler4.AppendLiteral("个");
					defaultInterpolatedStringHandler4.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
					defaultInterpolatedStringHandler4.AppendLiteral("]");
					value2 = defaultInterpolatedStringHandler4.ToStringAndClear();
				}
				defaultInterpolatedStringHandler3.AppendFormatted(value2);
				Log.Error(defaultInterpolatedStringHandler3.ToStringAndClear());
			};
			if (CS_0024_003C_003E8__locals64.epbTG2UM9m < num && Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals64.bEDTBZXasT, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, (int)num, true, "摆摊购买首次调整金钱"))
			{
				Thread.Sleep(200);
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("请求_确定购买摆摊-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] UNPfbU5Z1y(MyNATSocketClient P_0, byte[] P_1)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals67 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals67.N6iTmQa2bq = P_0;
		try
		{
			if (!qapfK9UWNV())
			{
				return P_1;
			}
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out CS_0024_003C_003E8__locals67.iZqTPSWEDF), reverse: true);
			封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(77, 11);
			defaultInterpolatedStringHandler.AppendLiteral("【取出摆摊账户现金前】[账号：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.人物数据.账号);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[名字：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[要取出现金：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals67.iZqTPSWEDF);
			defaultInterpolatedStringHandler.AppendLiteral("*");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有金钱：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.背包数据.金钱);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有金元宝：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.背包数据.金元宝);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有银元宝：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.背包数据.银元宝);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有累充点：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.累计充值金额);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有南极点：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.南极抽奖次数);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendLiteral("[拥有奇宝点：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.奇宝斋存档.奇宝斋余额);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			string value;
			if (Singleton<全局变量类>.I.摆摊配置.货币类型 != AllEnums.数值Type.道具)
			{
				value = string.Empty;
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(10, 2);
				defaultInterpolatedStringHandler2.AppendLiteral("[拥有摆摊货币：");
				defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.数值存档.摆摊道具货币);
				defaultInterpolatedStringHandler2.AppendLiteral("个");
				defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
				defaultInterpolatedStringHandler2.AppendLiteral("]");
				value = defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			defaultInterpolatedStringHandler.AppendFormatted(value);
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			if (CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.摊位现金 < CS_0024_003C_003E8__locals67.iZqTPSWEDF)
			{
				MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals67.N6iTmQa2bq;
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
				defaultInterpolatedStringHandler.AppendLiteral("别逗了，你当前摊位账户上根本没有那么多#R");
				defaultInterpolatedStringHandler.AppendFormatted((Singleton<全局变量类>.I.摆摊配置.货币类型 == AllEnums.数值Type.道具) ? (Singleton<全局变量类>.I.摆摊配置.货币道具 ?? "") : ((object)Singleton<全局变量类>.I.摆摊配置.货币类型));
				defaultInterpolatedStringHandler.AppendLiteral("#n可以取出！");
				myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return null;
			}
			if (CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.背包数据.金钱 + CS_0024_003C_003E8__locals67.iZqTPSWEDF > 2000000000)
			{
				CS_0024_003C_003E8__locals67.N6iTmQa2bq.C_Send(Singleton<WdAPI>.I.提示_中心提醒("抱歉，你目前无法携带巨额现金！"));
				return null;
			}
			switch (Singleton<全局变量类>.I.摆摊配置.货币类型)
			{
			case AllEnums.数值Type.金元宝:
				if (CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.背包数据.金元宝 + CS_0024_003C_003E8__locals67.iZqTPSWEDF > 2000000000)
				{
					CS_0024_003C_003E8__locals67.N6iTmQa2bq.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前拥有的#R金元宝#n和摊位账户存储的#R金元宝#n总价值已经超出了#R20#n亿，暂时无法取出。"));
					return null;
				}
				break;
			case AllEnums.数值Type.银元宝:
				if (CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.背包数据.银元宝 + CS_0024_003C_003E8__locals67.iZqTPSWEDF > 2000000000)
				{
					CS_0024_003C_003E8__locals67.N6iTmQa2bq.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前拥有的#R银元宝#n和摊位账户存储的#R银元宝#n总价值已经超出了#R20#n亿，暂时无法取出。"));
					return null;
				}
				break;
			case AllEnums.数值Type.累充点:
				if (CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.累计充值金额 + CS_0024_003C_003E8__locals67.iZqTPSWEDF > 2000000000)
				{
					CS_0024_003C_003E8__locals67.N6iTmQa2bq.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前拥有的#R累充点#n和摊位账户存储的#R累充点#n总价值已经超出了#R20#n亿，暂时无法取出。"));
					return null;
				}
				break;
			case AllEnums.数值Type.南极点:
				if (CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.南极抽奖次数 + CS_0024_003C_003E8__locals67.iZqTPSWEDF > 2000000000)
				{
					CS_0024_003C_003E8__locals67.N6iTmQa2bq.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前拥有的#R南极点#n和摊位账户存储的#R南极点#n总价值已经超出了#R20#n亿，暂时无法取出。"));
					return null;
				}
				break;
			case AllEnums.数值Type.奇宝点:
				if (CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.奇宝斋存档.奇宝斋余额 + CS_0024_003C_003E8__locals67.iZqTPSWEDF > 2000000000)
				{
					CS_0024_003C_003E8__locals67.N6iTmQa2bq.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前拥有的#R奇宝点#n和摊位账户存储的#R奇宝点#n总价值已经超出了#R20#n亿，暂时无法取出。"));
					return null;
				}
				break;
			case AllEnums.数值Type.灵气值:
				if (CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.数值存档.灵气值 + CS_0024_003C_003E8__locals67.iZqTPSWEDF > 2000000000)
				{
					CS_0024_003C_003E8__locals67.N6iTmQa2bq.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前拥有的#R灵气值#n和摊位账户存储的#R灵气值#n总价值已经超出了#R20#n亿，暂时无法取出。"));
					return null;
				}
				break;
			}
			CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.缓存数据.Is摆摊购买金钱记录 = CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.背包数据.金钱;
			CS_0024_003C_003E8__locals67.N6iTmQa2bq.摆摊购买后调整金钱事件 =  () =>
			{
				CS_0024_003C_003E8__locals67.N6iTmQa2bq.摆摊购买后调整金钱事件 = null;
				int is摆摊购买金钱记录 = CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.缓存数据.Is摆摊购买金钱记录;
				CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.缓存数据.Is摆摊购买金钱记录 = -1;
				Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals67.N6iTmQa2bq, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, is摆摊购买金钱记录, true, "摆摊取出存储后调整金钱");
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3;
				switch (Singleton<全局变量类>.I.摆摊配置.货币类型)
				{
				case AllEnums.数值Type.金元宝:
				{
					WdAPI i7 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient7 = CS_0024_003C_003E8__locals67.N6iTmQa2bq;
					string empty6 = string.Empty;
					int num6 = CS_0024_003C_003E8__locals67.iZqTPSWEDF;
					defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler3.AppendLiteral("摆摊取出存储后的");
					defaultInterpolatedStringHandler3.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
					i7.PndoGw5lW7(myNATSocketClient7, AllEnums.发送数据Type.金元宝, empty6, AllEnums.指令Type.无, num6, false, defaultInterpolatedStringHandler3.ToStringAndClear());
					break;
				}
				case AllEnums.数值Type.银元宝:
				{
					WdAPI i6 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient6 = CS_0024_003C_003E8__locals67.N6iTmQa2bq;
					string empty5 = string.Empty;
					int num5 = CS_0024_003C_003E8__locals67.iZqTPSWEDF;
					defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler3.AppendLiteral("摆摊取出存储后的");
					defaultInterpolatedStringHandler3.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
					i6.PndoGw5lW7(myNATSocketClient6, AllEnums.发送数据Type.银元宝, empty5, AllEnums.指令Type.无, num5, false, defaultInterpolatedStringHandler3.ToStringAndClear());
					break;
				}
				case AllEnums.数值Type.累充点:
				{
					WdAPI i5 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals67.N6iTmQa2bq;
					string empty4 = string.Empty;
					int num4 = CS_0024_003C_003E8__locals67.iZqTPSWEDF;
					defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler3.AppendLiteral("摆摊取出存储后的");
					defaultInterpolatedStringHandler3.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
					i5.PndoGw5lW7(myNATSocketClient5, AllEnums.发送数据Type.累充点, empty4, AllEnums.指令Type.无, num4, false, defaultInterpolatedStringHandler3.ToStringAndClear());
					break;
				}
				case AllEnums.数值Type.南极点:
				{
					WdAPI i4 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals67.N6iTmQa2bq;
					string empty3 = string.Empty;
					int num3 = CS_0024_003C_003E8__locals67.iZqTPSWEDF;
					defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler3.AppendLiteral("摆摊取出存储后的");
					defaultInterpolatedStringHandler3.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
					i4.PndoGw5lW7(myNATSocketClient4, AllEnums.发送数据Type.南极点, empty3, AllEnums.指令Type.无, num3, false, defaultInterpolatedStringHandler3.ToStringAndClear());
					break;
				}
				case AllEnums.数值Type.奇宝点:
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals67.N6iTmQa2bq;
					string empty2 = string.Empty;
					int num2 = CS_0024_003C_003E8__locals67.iZqTPSWEDF;
					defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler3.AppendLiteral("摆摊取出存储后的");
					defaultInterpolatedStringHandler3.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
					i3.PndoGw5lW7(myNATSocketClient3, AllEnums.发送数据Type.奇宝点, empty2, AllEnums.指令Type.无, num2, false, defaultInterpolatedStringHandler3.ToStringAndClear());
					break;
				}
				case AllEnums.数值Type.灵气值:
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals67.N6iTmQa2bq;
					string empty = string.Empty;
					int num = CS_0024_003C_003E8__locals67.iZqTPSWEDF;
					defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler3.AppendLiteral("摆摊取出存储后的");
					defaultInterpolatedStringHandler3.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
					i2.PndoGw5lW7(myNATSocketClient2, AllEnums.发送数据Type.灵气值, empty, AllEnums.指令Type.无, num, false, defaultInterpolatedStringHandler3.ToStringAndClear());
					break;
				}
				case AllEnums.数值Type.道具:
					CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.数值存档.摆摊道具货币 += CS_0024_003C_003E8__locals67.iZqTPSWEDF;
					break;
				}
				defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(77, 11);
				defaultInterpolatedStringHandler3.AppendLiteral("【取出摆摊账户现金后】[账号：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.人物数据.账号);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[名字：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.人物数据.昵称);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[要取出现金：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals67.iZqTPSWEDF);
				defaultInterpolatedStringHandler3.AppendLiteral("*");
				defaultInterpolatedStringHandler3.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币类型);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[拥有金钱：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.背包数据.金钱);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[拥有金元宝：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.背包数据.金元宝);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[拥有银元宝：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.背包数据.银元宝);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[拥有累充点：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.累计充值金额);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[拥有南极点：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.南极抽奖次数);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				defaultInterpolatedStringHandler3.AppendLiteral("[拥有奇宝点：");
				defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.奇宝斋存档.奇宝斋余额);
				defaultInterpolatedStringHandler3.AppendLiteral("]");
				string value2;
				if (Singleton<全局变量类>.I.摆摊配置.货币类型 != AllEnums.数值Type.道具)
				{
					value2 = string.Empty;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(10, 2);
					defaultInterpolatedStringHandler4.AppendLiteral("[拥有摆摊货币：");
					defaultInterpolatedStringHandler4.AppendFormatted(CS_0024_003C_003E8__locals67.N6iTmQa2bq.user.存档数据.数值存档.摆摊道具货币);
					defaultInterpolatedStringHandler4.AppendLiteral("个");
					defaultInterpolatedStringHandler4.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
					defaultInterpolatedStringHandler4.AppendLiteral("]");
					value2 = defaultInterpolatedStringHandler4.ToStringAndClear();
				}
				defaultInterpolatedStringHandler3.AppendFormatted(value2);
				Log.Error(defaultInterpolatedStringHandler3.ToStringAndClear());
			};
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("请求_取出摆摊账户现金-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal void kcefJg8xS4(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals47 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals47.iKqTFDYGLa = P_0;
		try
		{
			if (P_1 == "摆摊系统_存")
			{
				MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals47.iKqTFDYGLa;
				WdAPI i = Singleton<WdAPI>.I;
				MyNATSocketClient myclient = CS_0024_003C_003E8__locals47.iKqTFDYGLa;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(78, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[@确定/摆摊系统_1#DLG:1#prompt:你确定要把背包中的#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
				defaultInterpolatedStringHandler.AppendLiteral("#n全部存放进百宝囊吗？#Y（百宝囊中的");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
				defaultInterpolatedStringHandler.AppendLiteral("可直接用于摆摊在天上集市的摊位处购买）#n]");
				myNATSocketClient.C_Send(i.组包确定框(myclient, defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else if (P_1 == "摆摊系统_取")
			{
				CS_0024_003C_003E8__locals47.iKqTFDYGLa.C_Send(Singleton<WdAPI>.I.组包确定框(CS_0024_003C_003E8__locals47.iKqTFDYGLa, "[@确定/摆摊系统_2#DLG:1#prompt:你确定要把百宝囊中存放的#R" + Singleton<全局变量类>.I.摆摊配置.货币道具 + "#n全部取出吗？#Y（取出后直接到背包，请先预留好背包位置）#n]"));
			}
			else if (P_1 == "摆摊系统_1")
			{
				CS_0024_003C_003E8__locals47.iO8TSl2H0G = Singleton<WdAPI>.I.取背包物品格子组(CS_0024_003C_003E8__locals47.iKqTFDYGLa, Singleton<全局变量类>.I.摆摊配置.货币道具, 是否修为丹: false);
				if (CS_0024_003C_003E8__locals47.iO8TSl2H0G.Count <= 0)
				{
					CS_0024_003C_003E8__locals47.iKqTFDYGLa.C_Send(Singleton<WdAPI>.I.提示_中心提醒("别逗了，你背包里面哪有#R" + Singleton<全局变量类>.I.摆摊配置.货币道具 + "#n，毛都没有！"));
					return;
				}
				CS_0024_003C_003E8__locals47.UHATcjxyKM = 0;
				for (int j = 0; j < CS_0024_003C_003E8__locals47.iO8TSl2H0G.Count; j++)
				{
					CS_0024_003C_003E8__locals47.UHATcjxyKM += CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.背包数据.物品列表[CS_0024_003C_003E8__locals47.iO8TSl2H0G[j]].数量;
				}
				CS_0024_003C_003E8__locals47.nedTLUuPRA = 0;
				CS_0024_003C_003E8__locals47.iKqTFDYGLa.销毁回调事件 =  (string v) =>
				{
					if (!(v != Singleton<全局变量类>.I.摆摊配置.货币道具))
					{
						CS_0024_003C_003E8__locals47.nedTLUuPRA++;
						if (CS_0024_003C_003E8__locals47.nedTLUuPRA >= CS_0024_003C_003E8__locals47.iO8TSl2H0G.Count)
						{
							CS_0024_003C_003E8__locals47.iKqTFDYGLa.销毁回调事件 = null;
							CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.存档数据.数值存档.摆摊道具货币 += CS_0024_003C_003E8__locals47.UHATcjxyKM;
							MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals47.iKqTFDYGLa;
							WdAPI i4 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(30, 5);
							defaultInterpolatedStringHandler2.AppendLiteral("你往百宝囊中存放了#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals47.UHATcjxyKM);
							defaultInterpolatedStringHandler2.AppendLiteral("#n");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.道具单位);
							defaultInterpolatedStringHandler2.AppendLiteral("#R");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
							defaultInterpolatedStringHandler2.AppendLiteral("#n，当前存放数量为#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.存档数据.数值存档.摆摊道具货币);
							defaultInterpolatedStringHandler2.AppendLiteral("#n");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.道具单位);
							defaultInterpolatedStringHandler2.AppendLiteral("。");
							myNATSocketClient4.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
							DB.I.oMuiwEHr6E(CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.人物数据.GID, CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.存档数据);
						}
					}
				};
				CS_0024_003C_003E8__locals47.iKqTFDYGLa.S_Send(Singleton<WdAPI>.I.DN4IOFDdr5(CS_0024_003C_003E8__locals47.iKqTFDYGLa, CS_0024_003C_003E8__locals47.iO8TSl2H0G.ToArray()));
			}
			else
			{
				if (!(P_1 == "摆摊系统_2"))
				{
					return;
				}
				if (CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.存档数据.数值存档.摆摊道具货币 <= 0)
				{
					CS_0024_003C_003E8__locals47.iKqTFDYGLa.C_Send(Singleton<WdAPI>.I.提示_中心提醒("别逗了，你的百宝囊中空空如也！"));
					return;
				}
				int num = Singleton<WdAPI>.I.取背包剩余格子数量(CS_0024_003C_003E8__locals47.iKqTFDYGLa, Singleton<全局变量类>.I.摆摊配置.货币道具, 是否绑定: false);
				if (num <= 0)
				{
					CS_0024_003C_003E8__locals47.iKqTFDYGLa.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前背包已经放不下任何物品了，请道友清理背包后再来。"));
				}
				else if (num >= CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.存档数据.数值存档.摆摊道具货币)
				{
					int 摆摊道具货币 = CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.存档数据.数值存档.摆摊道具货币;
					CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.存档数据.数值存档.摆摊道具货币 = 0;
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals47.iKqTFDYGLa, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.摆摊配置.货币道具, AllEnums.指令Type.无, 摆摊道具货币, false, "摆摊取出存储");
					MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals47.iKqTFDYGLa;
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 3);
					defaultInterpolatedStringHandler.AppendLiteral("你取出了全部存储的#R");
					defaultInterpolatedStringHandler.AppendFormatted(摆摊道具货币);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.道具单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					myNATSocketClient2.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					DB.I.oMuiwEHr6E(CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.人物数据.GID, CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.存档数据);
				}
				else
				{
					CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.存档数据.数值存档.摆摊道具货币 -= num;
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals47.iKqTFDYGLa, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.摆摊配置.货币道具, AllEnums.指令Type.无, num, false, "摆摊取出存储");
					MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals47.iKqTFDYGLa;
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 6);
					defaultInterpolatedStringHandler.AppendLiteral("由于你背包的位置不足，只取出了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.道具单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n，百宝囊中还剩余#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.存档数据.数值存档.摆摊道具货币);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.道具单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					myNATSocketClient3.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					DB.I.oMuiwEHr6E(CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.人物数据.GID, CS_0024_003C_003E8__locals47.iKqTFDYGLa.user.存档数据);
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("摆摊系统对话处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public YHfw7nGpg7WfdCBKDH4()
	{
	}

	
	static YHfw7nGpg7WfdCBKDH4()
	{
		bsAfdnNsoZ = new StringBuilder();
	}
}
