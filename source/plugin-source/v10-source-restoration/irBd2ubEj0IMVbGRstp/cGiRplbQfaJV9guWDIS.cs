using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace irBd2ubEj0IMVbGRstp;

internal class cGiRplbQfaJV9guWDIS : Singleton<cGiRplbQfaJV9guWDIS>
{
	private static readonly object IPkbegS53A;

	
	internal void phAb3DF63f()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("在线抽奖配置类.json")))
			{
				Singleton<全局变量类>.I.在线抽奖配置 = JsonConvert.DeserializeObject<在线抽奖配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("在线抽奖配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.在线抽奖配置 = new 在线抽奖配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("在线抽奖配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.在线抽奖配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("在线抽奖配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void BeGbYe0X55()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("在线抽奖配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.在线抽奖配置, Formatting.Indented));
			Log.Debug("在线抽奖配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("在线抽奖配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string bLKbpAqRyh()
	{
		phAb3DF63f();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.在线抽奖配置, Formatting.Indented);
	}

	
	public void BvOb1h4DtW(string P_0)
	{
		Singleton<全局变量类>.I.在线抽奖配置 = JsonConvert.DeserializeObject<在线抽奖配置类>(P_0);
		BeGbYe0X55();
	}

	
	internal void cqMbxmXGun(MyNATSocketClient P_0)
	{
		try
		{
			if (P_0.user.缓存数据.is战斗中 || P_0.user.缓存数据.is观战中)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R战斗中#n、#R观战中#n等状态下无法进行抽奖操作。"));
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(60, 2);
			defaultInterpolatedStringHandler.AppendLiteral("#Y欢迎使用抽奖系统，当前频道打出#G“抽奖”#Y即可进行抽奖操作。#r触发指令：#n抽奖#r#Y抽奖消耗：#n");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.在线抽奖配置.消耗数值);
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.在线抽奖配置.消耗类型);
			defaultInterpolatedStringHandler.AppendLiteral("/次#r");
			StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
			stringBuilder.Append("#L奖池包含：");
			for (int i = 0; i < Singleton<全局变量类>.I.在线抽奖配置.奖池列表.Count && i < 10; i++)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(0, 2, stringBuilder2);
				handler.AppendFormatted((i != 0) ? "、" : string.Empty);
				handler.AppendFormatted(Singleton<全局变量类>.I.在线抽奖配置.奖池列表[i].奖励名字);
				stringBuilder2.Append(ref handler);
			}
			stringBuilder.Append("等等[抽一次/在线抽奖_1][抽十次/在线抽奖_10][抽五十次/在线抽奖_50]");
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, P_0.user.人物数据.形象ID, P_0.user.人物数据.昵称, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("抽奖喊话事件处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal async Task RptbHtQJgI(MyNATSocketClient P_0, int P_1)
	{
		try
		{
			if (P_1 <= 0)
			{
				return;
			}
			if (!Singleton<全局变量类>.I.config.is乾坤袋 && Singleton<WdAPI>.I.取背包剩余空格数(P_0) < P_1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("背包空位不足，无法进行抽奖操作。"));
				return;
			}
			int num = Singleton<全局变量类>.I.在线抽奖配置.消耗数值 * P_1;
			if (num >= int.MaxValue || num <= 0)
			{
				return;
			}
			switch (Singleton<全局变量类>.I.在线抽奖配置.消耗类型)
			{
			case AllEnums.数值Type.金元宝:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.背包数据.金元宝 < num)
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#R金元宝#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法进行抽奖。");
					P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, -num, 0))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R金元宝#n扣除失败，无法进行抽奖。"));
					return;
				}
				WdAPI i4 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n金元宝进行了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("#n次抽奖。");
				P_0.C_Send(i4.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.银元宝:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.背包数据.银元宝 < num)
				{
					WdAPI i8 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#R银元宝#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法进行抽奖。");
					P_0.C_Send(i8.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, 0, -num))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R银元宝#n扣除失败，无法进行抽奖。"));
					return;
				}
				WdAPI i9 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n银元宝进行了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("#n次抽奖。");
				P_0.C_Send(i9.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.金钱:
			{
				if (P_0.user.背包数据.金钱 < num)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R金钱#n不足" + Singleton<WdAPI>.I.问道标准数值文本(num) + "文，无法进行抽奖。"));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -num, false, "[在线抽奖]消耗");
				WdAPI i5 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(num));
				defaultInterpolatedStringHandler.AppendLiteral("文钱进行了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("#n次抽奖。");
				P_0.C_Send(i5.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.奇宝点:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.存档数据.奇宝斋存档.奇宝斋余额 < num)
				{
					WdAPI i6 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#R奇宝点#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进行抽奖。");
					P_0.C_Send(i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, -num, false, "[在线抽奖]消耗");
				WdAPI i7 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你花费了#R");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点进行了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("#n次抽奖。");
				P_0.C_Send(i7.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.南极点:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.存档数据.南极抽奖次数 < num)
				{
					WdAPI i = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#R南极点#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进行抽奖。");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, -num, false, "[在线抽奖]消耗");
				WdAPI i2 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你花费了#R");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n南极点进行了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("#n次抽奖。");
				P_0.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			}
			bool Is是否更新数量 = false;
			List<在线奖池配置类> 当前列表 = new List<在线奖池配置类>();
			for (int j = 0; j < P_1; j++)
			{
				int num2 = 0;
				在线奖池配置类 在线奖池配置类2 = null;
				当前列表.Clear();
				P_0.user.存档数据.在线抽奖次数++;
				if (Singleton<全局变量类>.I.在线抽奖配置.累计出保底次数 > 0 && P_0.user.存档数据.在线抽奖次数 >= Singleton<全局变量类>.I.在线抽奖配置.累计出保底次数)
				{
					当前列表 = Singleton<全局变量类>.I.在线抽奖配置.奖池列表.FindAll( (在线奖池配置类 x) => x.是否为保底奖励 && ((x.是否限制数量 && x.可抽出数量 > x.已抽出数量) || !x.是否限制数量));
				}
				if (当前列表.Count <= 0)
				{
					当前列表 = Singleton<全局变量类>.I.在线抽奖配置.奖池列表.FindAll( (在线奖池配置类 x) => !x.是否限制数量 || (x.是否限制数量 && x.可抽出数量 > x.已抽出数量));
				}
				if (当前列表.Count <= 0)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("奖池已经空了，无法进行抽奖操作。"));
					return;
				}
				int num3 = 当前列表.Sum( (在线奖池配置类 x) => x.获得几率);
				if (num3 <= 0)
				{
					break;
				}
				int num4 = Singleton<WdAPI>.I.qrjo9TWIdy(1, num3);
				foreach (在线奖池配置类 item in 当前列表)
				{
					num2 += item.获得几率;
					if (num4 <= num2)
					{
						在线奖池配置类2 = item;
						break;
					}
				}
				if (在线奖池配置类2 == null)
				{
					break;
				}
				if (在线奖池配置类2.是否为保底奖励)
				{
					P_0.user.存档数据.在线抽奖次数 = 0;
				}
				dtWb4K6e4h(P_0, 在线奖池配置类2);
				if (在线奖池配置类2.是否限制数量)
				{
					lock (IPkbegS53A)
					{
						在线奖池配置类2.已抽出数量++;
						Is是否更新数量 = true;
					}
				}
				await Task.Delay(20);
			}
			if (Is是否更新数量)
			{
				BeGbYe0X55();
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("抽奖点击事件处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private async Task dtWb4K6e4h(MyNATSocketClient P_0, 在线奖池配置类 P_1)
	{
		await Task.Delay(0);
		if (P_1.是否出谣言)
		{
			Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
			if (client频道事件 != null)
			{
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜#G");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("#n在#Y抽奖活动#n中抽到了#Y【");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.奖励名字);
				defaultInterpolatedStringHandler.AppendLiteral("】#n大奖！");
				client频道事件(i.PWRouuXjmn(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}
		switch (P_1.类型)
		{
		case AllEnums.数值Type.等级:
		{
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.level, P_1.获得数量, false, "[在线抽奖]获得");
			WdAPI i9 = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral("你的等级提升了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_1.获得数量);
			defaultInterpolatedStringHandler.AppendLiteral("#n级。");
			P_0.C_Send(i9.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			break;
		}
		case AllEnums.数值Type.道行:
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, P_1.获得数量, false, "[在线抽奖]获得");
			P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了#Y" + Singleton<WdAPI>.I.道行转文本(P_1.获得数量) + "#n道行。"));
			break;
		case AllEnums.数值Type.经验:
		{
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.exp, P_1.获得数量, false, "[在线抽奖]获得");
			WdAPI i5 = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
			defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_1.获得数量);
			defaultInterpolatedStringHandler.AppendLiteral("#n点经验。");
			P_0.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			break;
		}
		case AllEnums.数值Type.声望:
		{
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, P_1.获得数量, false, "[在线抽奖]获得");
			WdAPI i11 = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
			defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_1.获得数量);
			defaultInterpolatedStringHandler.AppendLiteral("#n点声望。");
			P_0.C_Send(i11.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			break;
		}
		case AllEnums.数值Type.战绩:
		{
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.total_score, P_1.获得数量, false, "[在线抽奖]获得");
			WdAPI i10 = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
			defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_1.获得数量);
			defaultInterpolatedStringHandler.AppendLiteral("#n点战绩。");
			P_0.C_Send(i10.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			break;
		}
		case AllEnums.数值Type.金元宝:
			if (DB.I.cAJNoOkab6(P_0, P_1.获得数量, 0))
			{
				WdAPI i8 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.获得数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n金元宝。");
				P_0.C_Send(i8.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			break;
		case AllEnums.数值Type.银元宝:
			if (DB.I.cAJNoOkab6(P_0, 0, P_1.获得数量))
			{
				WdAPI i7 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.获得数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n银元宝。");
				P_0.C_Send(i7.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			break;
		case AllEnums.数值Type.金钱:
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, P_1.获得数量, false, "[在线抽奖]获得");
			P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了" + Singleton<WdAPI>.I.问道标准数值文本(P_1.获得数量) + "#n文金钱。"));
			break;
		case AllEnums.数值Type.累充点:
		{
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, P_1.获得数量, false, "[在线抽奖]获得");
			WdAPI i6 = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_1.获得数量);
			defaultInterpolatedStringHandler.AppendLiteral("#n点累充点。");
			P_0.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			break;
		}
		case AllEnums.数值Type.道具:
			if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, P_1.奖励名字, AllEnums.指令Type.无, P_1.获得数量, false, "在线抽奖奖励"))
			{
				WdAPI i4 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.奖励名字);
				defaultInterpolatedStringHandler.AppendLiteral("×");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.获得数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				P_0.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			break;
		case AllEnums.数值Type.体力:
		{
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.stamina, P_1.获得数量, false, "[在线抽奖]获得");
			WdAPI i3 = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
			defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_1.获得数量);
			defaultInterpolatedStringHandler.AppendLiteral("#n点体力。");
			P_0.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			break;
		}
		case AllEnums.数值Type.南极点:
		{
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, P_1.获得数量, false, "[在线抽奖]获得");
			WdAPI i2 = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_1.获得数量);
			defaultInterpolatedStringHandler.AppendLiteral("#n点南极点。");
			P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			break;
		}
		case AllEnums.数值Type.代金券:
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.voucher, P_1.获得数量, false, "[在线抽奖]获得");
			P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了" + Singleton<WdAPI>.I.问道标准数值文本(P_1.获得数量) + "#n文代金券。"));
			break;
		case AllEnums.数值Type.宠物:
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.宠物, P_1.奖励名字, AllEnums.指令Type.无, 1, false, "在线抽奖");
			P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了一只#Y" + P_1.奖励名字 + "#n宠物。"));
			break;
		case AllEnums.数值Type.坐骑:
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.坐骑, P_1.奖励名字, AllEnums.指令Type.无, 1, false, "在线抽奖");
			P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了一只#Y" + P_1.奖励名字 + "#n坐骑。"));
			break;
		case AllEnums.数值Type.气血上限:
			break;
		}
	}

	
	public cGiRplbQfaJV9guWDIS()
	{
	}

	
	static cGiRplbQfaJV9guWDIS()
	{
		IPkbegS53A = new object();
	}
}
