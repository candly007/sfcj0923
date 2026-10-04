using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace gEdioZfkTLM2TXU6jgd;

internal class uh2edhfVGtogUy49Lpv : Singleton<uh2edhfVGtogUy49Lpv>
{
	internal static byte[] JWNf4Ww0U7;

	internal static int GAOfeRpe5Q;

	
	[SpecialName]
	public static bool pdEfxlnyv1()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is鸿运当头)
		{
			return Singleton<全局变量类>.I.自助商店配置.功能开关;
		}
		return false;
	}

	
	internal void JJif0HwPdK()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("自助商店配置类.json")))
			{
				Singleton<全局变量类>.I.自助商店配置 = JsonConvert.DeserializeObject<自助商店配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("自助商店配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.自助商店配置 = new 自助商店配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("自助商店配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.自助商店配置, Formatting.Indented));
			}
			JWNf4Ww0U7 = EjUfYPb73C(Singleton<全局变量类>.I.自助商店配置.点数列表, 7);
		}
		catch (Exception ex)
		{
			Log.Error("自助商店配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void Mj7fOtZJP0()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("自助商店配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.自助商店配置, Formatting.Indented));
			Log.Debug("自助商店配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("自助商店配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string AHrfQdHMKD()
	{
		JJif0HwPdK();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.自助商店配置, Formatting.Indented);
	}

	
	public void zwSfEKJQBQ(string P_0)
	{
		Singleton<全局变量类>.I.自助商店配置 = JsonConvert.DeserializeObject<自助商店配置类>(P_0);
		Mj7fOtZJP0();
	}

	
	internal void YQCf3wWxLI(MyNATSocketClient P_0)
	{
		P_0.C_Send(JWNf4Ww0U7);
	}

	
	private byte[] EjUfYPb73C(List<自助商店列表类> P_0, int P_1)
	{
		try
		{
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写短整数型(87, reverse: true);
			封包_写2.写字节型(P_1);
			封包_写2.写整数型(8, reverse: true);
			封包_写2.写短整数型((short)P_0.Count, reverse: true);
			for (int i = 0; i < P_0.Count; i++)
			{
				封包_写2.写字节集(P_0[i].物品封包, hasCount: false, 0);
			}
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("更新自助商店列表-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal void ALHfp3Nlra(MyNATSocketClient P_0, 自助商店列表类 P_1, string P_2)
	{
		try
		{
			int num = 0;
			int num2 = 0;
			switch (P_1.出售类型)
			{
			case AllEnums.数值Type.道行:
				num = P_0.user.属性数据.道行 / (P_1.出售价格 * 360);
				break;
			case AllEnums.数值Type.声望:
				num = P_0.user.属性数据.声望 / P_1.出售价格;
				break;
			case AllEnums.数值Type.战绩:
				num = P_0.user.属性数据.战绩 / P_1.出售价格;
				break;
			case AllEnums.数值Type.金元宝:
				num = P_0.user.背包数据.金元宝 / P_1.出售价格;
				break;
			case AllEnums.数值Type.银元宝:
				num = P_0.user.背包数据.银元宝 / P_1.出售价格;
				break;
			case AllEnums.数值Type.金钱:
				num = P_0.user.背包数据.金钱 / P_1.出售价格;
				break;
			case AllEnums.数值Type.累充点:
				num = P_0.user.存档数据.累计充值金额 / P_1.出售价格;
				break;
			case AllEnums.数值Type.南极点:
				num = P_0.user.存档数据.南极抽奖次数 / P_1.出售价格;
				break;
			case AllEnums.数值Type.代金券:
				num = P_0.user.背包数据.代金券 / P_1.出售价格;
				break;
			case AllEnums.数值Type.奇宝点:
				num = P_0.user.存档数据.奇宝斋存档.奇宝斋余额 / P_1.出售价格;
				break;
			case AllEnums.数值Type.灵气值:
				num = P_0.user.存档数据.数值存档.灵气值 / P_1.出售价格;
				break;
			case AllEnums.数值Type.潜能:
				num = P_0.user.属性数据.潜能 / P_1.出售价格;
				break;
			}
			if (num <= 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("抱歉，你连一个#R" + P_1.名字 + "#n都买不起！"));
				return;
			}
			num2 = 1;
			if ((long)(num * P_1.出售价格) > 2000000000L)
			{
				num = 2000000000 / P_1.出售价格;
			}
			if (num > 100)
			{
				num = 100;
			}
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
			defaultInterpolatedStringHandler.AppendLiteral("请输入你要购买的#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n的数量：#r#O（单价：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1.单价展示);
			defaultInterpolatedStringHandler.AppendLiteral("#O）");
			P_0.C_Send(i.组包输入数字框(P_0, P_2, defaultInterpolatedStringHandler.ToStringAndClear(), num, num2));
		}
		catch (Exception ex)
		{
			Log.Error("下单货栈物品处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void yf6f1XgX3g(MyNATSocketClient P_0, 自助商店列表类 P_1, int P_2)
	{
		try
		{
			long num = P_1.出售价格 * P_2;
			if (num > 2000000000)
			{
				Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
				return;
			}
			int num2 = (P_1.是否叠加 ? 1 : P_2);
			if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < num2)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("背包位置不足，请整理背包后重新购买。"));
				return;
			}
			string text = string.Empty;
			switch (P_1.出售类型)
			{
			case AllEnums.数值Type.道行:
				if (num * 360 > 2000000000 || num * 360 > P_0.user.属性数据.道行)
				{
					WdAPI i8 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的道行不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n年，无法购买。");
					P_0.C_Send(i8.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, (int)(-num * 360), false, "自助货栈购买扣除"))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 4);
					defaultInterpolatedStringHandler.AppendLiteral("你花费了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n年道行购买了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				break;
			case AllEnums.数值Type.声望:
				if (num > P_0.user.属性数据.声望)
				{
					WdAPI i9 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的声望不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法购买。");
					P_0.C_Send(i9.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, (int)(-num), false, "自助货栈购买扣除"))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 4);
					defaultInterpolatedStringHandler.AppendLiteral("你花费了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n点声望购买了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				break;
			case AllEnums.数值Type.战绩:
				if (num > P_0.user.属性数据.战绩)
				{
					WdAPI i5 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的战绩不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法购买。");
					P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.total_score, (int)(-num), false, "自助货栈购买扣除"))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 4);
					defaultInterpolatedStringHandler.AppendLiteral("你花费了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n点战绩购买了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				break;
			case AllEnums.数值Type.潜能:
				if (num > P_0.user.属性数据.潜能)
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的潜能不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法购买。");
					P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.pot, (int)(-num), false, "自助货栈购买扣除"))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 4);
					defaultInterpolatedStringHandler.AppendLiteral("你花费了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n点潜能购买了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				break;
			case AllEnums.数值Type.金钱:
				if (num > P_0.user.背包数据.金钱)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的金钱不足" + Singleton<WdAPI>.I.问道标准数值文本((int)num) + "文，无法购买。"));
					return;
				}
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, (int)(-num), false, "自助货栈购买扣除"))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 4);
					defaultInterpolatedStringHandler.AppendLiteral("你花费了");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本((int)num));
					defaultInterpolatedStringHandler.AppendLiteral("文钱购买了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				break;
			case AllEnums.数值Type.代金券:
				if (num > P_0.user.背包数据.代金券)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的代金券不足" + Singleton<WdAPI>.I.问道标准数值文本((int)num) + "文，无法购买。"));
					return;
				}
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.voucher, (int)(-num), false, "自助货栈购买扣除"))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 4);
					defaultInterpolatedStringHandler.AppendLiteral("你花费了");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本((int)num));
					defaultInterpolatedStringHandler.AppendLiteral("代金券购买了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				break;
			case AllEnums.数值Type.金元宝:
				if (num > P_0.user.背包数据.金元宝)
				{
					WdAPI i10 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的金元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n个，无法购买。");
					P_0.C_Send(i10.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.金元宝, string.Empty, AllEnums.指令Type.无, (int)(-num), false, "自助货栈购买扣除"))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 4);
					defaultInterpolatedStringHandler.AppendLiteral("你花费了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n个金元宝购买了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				break;
			case AllEnums.数值Type.银元宝:
				if (num > P_0.user.背包数据.银元宝)
				{
					WdAPI i6 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的银元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n个，无法购买。");
					P_0.C_Send(i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.银元宝, string.Empty, AllEnums.指令Type.无, (int)(-num), false, "自助货栈购买扣除"))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 4);
					defaultInterpolatedStringHandler.AppendLiteral("你花费了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n个银元宝购买了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				break;
			case AllEnums.数值Type.累充点:
				if (num > P_0.user.存档数据.累计充值金额)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的累充点不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法购买。");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, (int)(-num), false, "自助货栈购买扣除"))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 4);
					defaultInterpolatedStringHandler.AppendLiteral("你花费了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n个累充点购买了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				break;
			case AllEnums.数值Type.南极点:
				if (num > P_0.user.存档数据.南极抽奖次数)
				{
					WdAPI i7 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的南极点不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法购买。");
					P_0.C_Send(i7.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, (int)(-num), false, "自助货栈购买扣除"))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 4);
					defaultInterpolatedStringHandler.AppendLiteral("你花费了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n个南极点购买了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				break;
			case AllEnums.数值Type.奇宝点:
				if (num > P_0.user.存档数据.奇宝斋存档.奇宝斋余额)
				{
					WdAPI i4 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的奇宝点不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法购买。");
					P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, (int)(-num), false, "自助货栈购买扣除"))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 4);
					defaultInterpolatedStringHandler.AppendLiteral("你花费了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n个奇宝点购买了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				break;
			case AllEnums.数值Type.灵气值:
				if (num > P_0.user.存档数据.数值存档.灵气值)
				{
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的灵气值不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法购买。");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, (int)(-num), false, "自助货栈购买扣除"))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 4);
					defaultInterpolatedStringHandler.AppendLiteral("你花费了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n点灵气值购买了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				break;
			}
			if (string.IsNullOrWhiteSpace(text))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("购买过程中扣费失败，本次购买取消。"));
			}
			else if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, P_1.名字, AllEnums.指令Type.无, P_2, false, "自助货栈购买奖励"))
			{
				WdAPI i11 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 3);
				defaultInterpolatedStringHandler.AppendLiteral("#Y购买成功，你的到了");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendFormatted(P_1.单位);
				defaultInterpolatedStringHandler.AppendLiteral("#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
				defaultInterpolatedStringHandler.AppendLiteral("。");
				P_0.C_Send(i11.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear(), text));
			}
		}
		catch (Exception ex)
		{
			Log.Error("购买货栈物品处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public uh2edhfVGtogUy49Lpv()
	{
	}

	
	static uh2edhfVGtogUy49Lpv()
	{
		JWNf4Ww0U7 = Array.Empty<byte>();
		GAOfeRpe5Q = 0;
	}
}
