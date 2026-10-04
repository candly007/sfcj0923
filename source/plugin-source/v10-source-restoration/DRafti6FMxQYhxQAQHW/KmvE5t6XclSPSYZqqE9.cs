using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace DRafti6FMxQYhxQAQHW;

internal class KmvE5t6XclSPSYZqqE9 : Singleton<KmvE5t6XclSPSYZqqE9>
{
	public static readonly string MbH6TCNZt9;

	private static readonly string kXo69pUgPU;

	private static readonly string Phl6yuGEuR;

	private static readonly string JO36CijtXg;

	private static readonly string gJm6Vi5FWB;

	
	[SpecialName]
	public static bool bmW67axrUA()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is神级掉落)
		{
			return Singleton<全局变量类>.I.龙血BOSS配置.功能开关;
		}
		return false;
	}

	
	internal void equ6LlOIcw()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("龙血BOSS配置类.json")))
			{
				Singleton<全局变量类>.I.龙血BOSS配置 = JsonConvert.DeserializeObject<龙血BOSS配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("龙血BOSS配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.龙血BOSS配置 = new 龙血BOSS配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("龙血BOSS配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.龙血BOSS配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("龙血BOSS配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void qyP6Sct5GV()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("龙血BOSS配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.龙血BOSS配置, Formatting.Indented));
			Log.Debug("龙血BOSS配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("龙血BOSS配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string eRy6cDlFsl()
	{
		equ6LlOIcw();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.龙血BOSS配置, Formatting.Indented);
	}

	
	public void CdC6nM7ONR(string P_0)
	{
		Singleton<全局变量类>.I.龙血BOSS配置 = JsonConvert.DeserializeObject<龙血BOSS配置类>(P_0);
		qyP6Sct5GV();
	}

	
	internal bool aWX65nZjut(string P_0)
	{
		if (!Singleton<ByteAPI>.I.寻找文本或(P_0, "惊天魔魂", "已被仁人义士", "噬地挑战", "首次战胜了传说中的"))
		{
			return false;
		}
		return true;
	}

	
	internal bool Lk76MVhTOJ(MyNATSocketClient P_0, string P_1, bool P_2)
	{
		if (!bmW67axrUA() || !P_2)
		{
			return false;
		}
		if (P_1 == "吞天")
		{
			if (!Singleton<全局变量类>.I.龙血BOSS配置.吞天掉落 || Singleton<全局变量类>.I.龙血BOSS配置.吞天掉落列表.Count <= 0)
			{
				return false;
			}
			FEd6hEYBPM(P_0, P_1, Singleton<全局变量类>.I.龙血BOSS配置.吞天掉落列表, P_2);
			return true;
		}
		if (P_1 == "噬地")
		{
			if (!Singleton<全局变量类>.I.龙血BOSS配置.噬地掉落 || Singleton<全局变量类>.I.龙血BOSS配置.噬地掉落列表.Count <= 0)
			{
				return false;
			}
			FEd6hEYBPM(P_0, P_1, Singleton<全局变量类>.I.龙血BOSS配置.噬地掉落列表, P_2);
			return true;
		}
		if (P_1 == "傀儡王")
		{
			if (!Singleton<全局变量类>.I.龙血BOSS配置.傀儡王掉落 || Singleton<全局变量类>.I.龙血BOSS配置.傀儡王掉落列表.Count <= 0)
			{
				return false;
			}
			FEd6hEYBPM(P_0, P_1, Singleton<全局变量类>.I.龙血BOSS配置.傀儡王掉落列表, P_2);
			return true;
		}
		if (Singleton<ByteAPI>.I.寻找文本("|黑熊妖皇|天煞狂狮|灭天血刺|血炼魔猪|", "|" + P_1 + "|") || Singleton<ByteAPI>.I.寻找文本("|妖皇元神|狂狮元神|血刺元神|魔猪元神|", "|" + P_1 + "|"))
		{
			if (!Singleton<全局变量类>.I.龙血BOSS配置.世界BOSS掉落 || Singleton<全局变量类>.I.龙血BOSS配置.世界掉落列表.Count <= 0)
			{
				return false;
			}
			ohx6vOKC1h(P_0, P_1, Singleton<全局变量类>.I.龙血BOSS配置.世界掉落列表, P_2);
			return true;
		}
		return false;
	}

	
	private void FEd6hEYBPM(MyNATSocketClient P_0, string P_1, List<神级BOSS掉落类> P_2, bool P_3)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < P_2.Count; i++)
		{
			num2 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 10000);
			if (P_2[i].掉落几率 < num2)
			{
				continue;
			}
			num = Singleton<WdAPI>.I.qrjo9TWIdy(P_2[i].掉落最低数量, P_2[i].掉落最高数量);
			if (num <= 0)
			{
				continue;
			}
			switch (P_2[i].掉落类型)
			{
			case AllEnums.数值Type.金元宝:
				if (DB.I.cAJNoOkab6(P_0, num, 0))
				{
					WdAPI i7 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n金元宝");
					P_0.C_Send(i7.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
					handler.AppendLiteral("、");
					handler.AppendFormatted(num);
					handler.AppendLiteral("金元宝");
					stringBuilder8.Append(ref handler);
				}
				break;
			case AllEnums.数值Type.银元宝:
				if (DB.I.cAJNoOkab6(P_0, 0, num))
				{
					WdAPI i10 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n银元宝");
					P_0.C_Send(i10.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder11 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
					handler.AppendLiteral("、");
					handler.AppendFormatted(num);
					handler.AppendLiteral("银元宝");
					stringBuilder11.Append(ref handler);
				}
				break;
			case AllEnums.数值Type.金钱:
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.金钱, string.Empty, num, false, "[" + P_1 + "]掉落");
				P_0.C_Send(Singleton<WdAPI>.I.提示_杂项公告("你获得了" + Singleton<WdAPI>.I.问道标准数值文本(num) + "文钱。"));
				stringBuilder.Append("、大量金钱");
				break;
			case AllEnums.数值Type.代金券:
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.代金券, string.Empty, num, false, "[" + P_1 + "]掉落");
				P_0.C_Send(Singleton<WdAPI>.I.提示_杂项公告("你获得了" + Singleton<WdAPI>.I.问道标准数值文本(num) + "代金券。"));
				stringBuilder.Append("、大量代金券");
				break;
			case AllEnums.数值Type.道行:
			{
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.道行, string.Empty, num * 360, false, "[" + P_1 + "]掉落");
				WdAPI i9 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n年道行。");
				P_0.C_Send(i9.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder10 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
				handler.AppendLiteral("、");
				handler.AppendFormatted(num);
				handler.AppendLiteral("年道行");
				stringBuilder10.Append(ref handler);
				break;
			}
			case AllEnums.数值Type.声望:
			{
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.声望, string.Empty, num, false, "[" + P_1 + "]掉落");
				WdAPI i8 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n声望。");
				P_0.C_Send(i8.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder9 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(3, 1, stringBuilder2);
				handler.AppendLiteral("、");
				handler.AppendFormatted(num);
				handler.AppendLiteral("声望");
				stringBuilder9.Append(ref handler);
				break;
			}
			case AllEnums.数值Type.道具:
				if (!string.IsNullOrWhiteSpace(P_2[i].掉落道具))
				{
					Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.道具, P_2[i].掉落道具, num, false, "[" + P_1 + "]掉落");
					WdAPI i6 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2[i].掉落道具);
					defaultInterpolatedStringHandler.AppendLiteral("×");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					P_0.C_Send(i6.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(2, 2, stringBuilder2);
					handler.AppendLiteral("、");
					handler.AppendFormatted(P_2[i].掉落道具);
					handler.AppendLiteral("×");
					handler.AppendFormatted(num);
					stringBuilder7.Append(ref handler);
				}
				break;
			case AllEnums.数值Type.累充点:
			{
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.累充点, string.Empty, num, false, "[" + P_1 + "]掉落");
				WdAPI i5 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y累充点×");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(i5.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder6 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
				handler.AppendLiteral("、");
				handler.AppendFormatted(num);
				handler.AppendLiteral("累充点");
				stringBuilder6.Append(ref handler);
				break;
			}
			case AllEnums.数值Type.南极点:
			{
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.南极点, string.Empty, num, false, "[" + P_1 + "]掉落");
				WdAPI i4 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y南极点×");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(i4.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
				handler.AppendLiteral("、");
				handler.AppendFormatted(num);
				handler.AppendLiteral("南极点");
				stringBuilder5.Append(ref handler);
				break;
			}
			case AllEnums.数值Type.奇宝点:
			{
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.奇宝点, string.Empty, num, false, "[" + P_1 + "]掉落");
				WdAPI i3 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y奇宝点×");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(i3.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
				handler.AppendLiteral("、");
				handler.AppendFormatted(num);
				handler.AppendLiteral("奇宝点");
				stringBuilder4.Append(ref handler);
				break;
			}
			case AllEnums.数值Type.灵气值:
			{
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.灵气值, string.Empty, num, false, "[" + P_1 + "]掉落");
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y灵气值×");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("、");
				handler.AppendFormatted(num);
				handler.AppendLiteral("点灵气值");
				stringBuilder3.Append(ref handler);
				break;
			}
			}
		}
		stringBuilder.Remove(0, 1);
		Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(string.Format(Phl6yuGEuR, P_0.user.人物数据.昵称, stringBuilder.ToString()), "管理员"));
	}

	
	private void ohx6vOKC1h(MyNATSocketClient P_0, string P_1, List<神级BOSS掉落类> P_2, bool P_3)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < P_2.Count; i++)
		{
			num2 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 10000);
			if (P_2[i].掉落几率 < num2)
			{
				continue;
			}
			num = Singleton<WdAPI>.I.qrjo9TWIdy(P_2[i].掉落最低数量, P_2[i].掉落最高数量);
			if (num <= 0)
			{
				continue;
			}
			switch (P_2[i].掉落类型)
			{
			case AllEnums.数值Type.金元宝:
				if (DB.I.cAJNoOkab6(P_0, num, 0))
				{
					WdAPI i7 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n金元宝");
					P_0.C_Send(i7.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
					handler.AppendLiteral("、");
					handler.AppendFormatted(num);
					handler.AppendLiteral("金元宝");
					stringBuilder8.Append(ref handler);
				}
				break;
			case AllEnums.数值Type.银元宝:
				if (DB.I.cAJNoOkab6(P_0, 0, num))
				{
					WdAPI i10 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n银元宝");
					P_0.C_Send(i10.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder11 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
					handler.AppendLiteral("、");
					handler.AppendFormatted(num);
					handler.AppendLiteral("银元宝");
					stringBuilder11.Append(ref handler);
				}
				break;
			case AllEnums.数值Type.金钱:
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.金钱, string.Empty, num, false, "[" + P_1 + "]掉落");
				P_0.C_Send(Singleton<WdAPI>.I.提示_杂项公告("你获得了" + Singleton<WdAPI>.I.问道标准数值文本(num) + "文钱。"));
				stringBuilder.Append("、大量金钱");
				break;
			case AllEnums.数值Type.代金券:
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.代金券, string.Empty, num, false, "[" + P_1 + "]掉落");
				P_0.C_Send(Singleton<WdAPI>.I.提示_杂项公告("你获得了" + Singleton<WdAPI>.I.问道标准数值文本(num) + "代金券。"));
				stringBuilder.Append("、大量代金券");
				break;
			case AllEnums.数值Type.道行:
			{
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.道行, string.Empty, num * 360, false, "[" + P_1 + "]掉落");
				WdAPI i9 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n年道行。");
				P_0.C_Send(i9.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder10 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
				handler.AppendLiteral("、");
				handler.AppendFormatted(num);
				handler.AppendLiteral("年道行");
				stringBuilder10.Append(ref handler);
				break;
			}
			case AllEnums.数值Type.声望:
			{
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.声望, string.Empty, num, false, "[" + P_1 + "]掉落");
				WdAPI i8 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n声望。");
				P_0.C_Send(i8.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder9 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(3, 1, stringBuilder2);
				handler.AppendLiteral("、");
				handler.AppendFormatted(num);
				handler.AppendLiteral("声望");
				stringBuilder9.Append(ref handler);
				break;
			}
			case AllEnums.数值Type.道具:
				if (!string.IsNullOrWhiteSpace(P_2[i].掉落道具))
				{
					Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.道具, P_2[i].掉落道具, num, false, "[" + P_1 + "]掉落");
					WdAPI i6 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2[i].掉落道具);
					defaultInterpolatedStringHandler.AppendLiteral("×");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					P_0.C_Send(i6.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(2, 2, stringBuilder2);
					handler.AppendLiteral("、");
					handler.AppendFormatted(P_2[i].掉落道具);
					handler.AppendLiteral("×");
					handler.AppendFormatted(num);
					stringBuilder7.Append(ref handler);
				}
				break;
			case AllEnums.数值Type.累充点:
			{
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.累充点, string.Empty, num, false, "[" + P_1 + "]掉落");
				WdAPI i5 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y累充点×");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(i5.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder6 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
				handler.AppendLiteral("、");
				handler.AppendFormatted(num);
				handler.AppendLiteral("累充点");
				stringBuilder6.Append(ref handler);
				break;
			}
			case AllEnums.数值Type.南极点:
			{
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.南极点, string.Empty, num, false, "[" + P_1 + "]掉落");
				WdAPI i4 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y南极点×");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(i4.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
				handler.AppendLiteral("、");
				handler.AppendFormatted(num);
				handler.AppendLiteral("南极点");
				stringBuilder5.Append(ref handler);
				break;
			}
			case AllEnums.数值Type.奇宝点:
			{
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.奇宝点, string.Empty, num, false, "[" + P_1 + "]掉落");
				WdAPI i3 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y奇宝点×");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(i3.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
				handler.AppendLiteral("、");
				handler.AppendFormatted(num);
				handler.AppendLiteral("奇宝点");
				stringBuilder4.Append(ref handler);
				break;
			}
			case AllEnums.数值Type.灵气值:
			{
				Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.灵气值, string.Empty, num, false, "[" + P_1 + "]掉落");
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y灵气值×");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("、");
				handler.AppendFormatted(num);
				handler.AppendLiteral("点灵气值");
				stringBuilder3.Append(ref handler);
				break;
			}
			}
		}
		stringBuilder.Remove(0, 1);
		Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(string.Format(Phl6yuGEuR, P_1, P_0.user.人物数据.昵称, stringBuilder.ToString()), "管理员"));
	}

	
	public KmvE5t6XclSPSYZqqE9()
	{
	}

	
	static KmvE5t6XclSPSYZqqE9()
	{
		MbH6TCNZt9 = "|吞天|噬地|傀儡王|上古妖王|黑熊妖皇|天煞狂狮|灭天血刺|血炼魔猪|天魁星|天魔星|天机星|天闲星|天勇星|天雄星|天猛星|天威星|天英星|天贵星|天富星|天满星|天孤星|天伤星|天立星|天捷星|天暗星|天祐星|天空星|天速星|天异星|天杀星|天微星|天究星|天退星|天寿星|天剑星|天平星|天罪星|天损星|天败星|天牢星|天慧星|天暴星|天哭星|天巧星|地魁星|地煞星|地勇星|地杰星|地雄星|地威星|地英星|地奇星|地猛星|地文星|地正星|地辟星|地阖星|地强星|地暗星|地轴星|地会星|地佐星|地佑星|地灵星|地兽星|地微星|地慧星|地暴星|地默星|地猖星|地狂星|地飞星|地走星|地巧星|地明星|地进星|地退星|地满星|地遂星|地周星|地隐星|地异星|地理星|地俊星|地乐星|地捷星|地速星|地镇星|地稽星|地魔星|地妖星|地幽星|地伏星|地僻星|地空星|地孤星|地全星|地短星|地角星|地囚星|地藏星|地平星|地损星|地奴星|地察星|地恶星|地丑星|地数星|地阴星|地刑星|地壮星|地劣星|地健星|地耗星|地贼星|地狗星|";
		kXo69pUgPU = "惊天魔魂#P{0}#P已被仁人义士#Y#<{1}#>#n制服，意外的从其身上获得了#Y{2}#n的奖励，真是不可思议啊！";
		Phl6yuGEuR = "本区组首次战胜了传说中的#Y{0}#n，#Y{1}#n额外获得了#R{2}#n，为中洲大陆的修道者争了一口气！";
		JO36CijtXg = "恭喜你，你们队伍是本区组第一队战胜";
		gJm6Vi5FWB = "传说中的#Y{0}#n竟然被#Y{1}#n打败了，同时还获得了#Y{2}#n的奖励，真是实力非凡啊！";
	}
}
