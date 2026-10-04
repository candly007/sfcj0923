using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Ncq4nMwbH5sPfLR2xwf;
using Newtonsoft.Json;
using Serilog;
using WUi9QivDmyMdpkvOap;
using vEAdPGPTkDFOYsbi303;

namespace PJ8VymWjWDfaUUlTW62;

internal class lrYK0bWD4sTSDkaJic1 : Singleton<lrYK0bWD4sTSDkaJic1>
{
	private static List<string> ie5Wf8Vwhu;

	
	internal void nwcWlNDATc()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("燃眉配置类.json")))
			{
				Singleton<全局变量类>.I.燃眉配置 = JsonConvert.DeserializeObject<燃眉配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("燃眉配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.燃眉配置 = new 燃眉配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("燃眉配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.燃眉配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("燃眉配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void GQHW8ce28r()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("燃眉配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.燃眉配置, Formatting.Indented));
			Log.Debug("燃眉配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("燃眉配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string KjUWISAYCu()
	{
		nwcWlNDATc();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.燃眉配置, Formatting.Indented);
	}

	
	public void T02WoMyoAm(string P_0)
	{
		Singleton<全局变量类>.I.燃眉配置 = JsonConvert.DeserializeObject<燃眉配置类>(P_0);
		GQHW8ce28r();
	}

	
	public async Task drqWNtYw8O(MyNATSocketClient P_0, bool P_1)
	{
		try
		{
			await Task.Delay(2000);
			if (string.IsNullOrWhiteSpace(P_0.user.存档数据.燃眉之急任务.当前NPC))
			{
				return;
			}
			string text = 全局常量类.燃眉奖品组[P_0.user.存档数据.燃眉之急任务.任务类型][(("|" + Singleton<全局变量类>.I.燃眉配置.托号角色 + "|").IndexOf("|" + P_0.user.人物数据.昵称 + "|") != -1) ? Singleton<WdAPI>.I.qrjo9TWIdy(3, 5) : P_0.user.存档数据.燃眉之急任务.任务星级];
			int num = 1;
			if (text == "紫帝晶" && Singleton<全局变量类>.I.全服共享存档数据.当日紫帝晶数量 >= Singleton<全局变量类>.I.燃眉配置.每日紫帝晶数量)
			{
				text = 全局常量类.燃眉奖品组[P_0.user.存档数据.燃眉之急任务.任务类型][P_0.user.存档数据.燃眉之急任务.任务星级 - 1];
			}
			if (P_1)
			{
				num = ((Singleton<WdAPI>.I.qrjo9TWIdy(1, 100) == 1) ? 3 : 2);
				P_0.user.存档数据.燃眉之急任务.当前NPC = string.Empty;
				P_0.user.存档数据.燃眉之急任务.当前NPCID = 0;
				P_0.user.存档数据.燃眉之急任务.当前NPC形象ID = 0;
				P_0.user.存档数据.燃眉之急任务.任务类型 = 0;
				P_0.user.存档数据.燃眉之急任务.任务星级 = 0;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (text == "金凤樽")
				{
					Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件 != null)
					{
						WdAPI i = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 3);
						defaultInterpolatedStringHandler.AppendLiteral("#Y#<");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#>#n在完成燃眉之急任务时获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(num);
						defaultInterpolatedStringHandler.AppendLiteral("个#n#Y");
						defaultInterpolatedStringHandler.AppendFormatted(text);
						defaultInterpolatedStringHandler.AppendLiteral("#n，真是羡煞旁人啊！");
						client频道事件(i.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
				}
				else if (text == "紫帝晶")
				{
					Singleton<全局变量类>.I.全服共享存档数据.当日紫帝晶数量++;
					Action<byte[]> client频道事件2 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件2 != null)
					{
						WdAPI i2 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(72, 5);
						defaultInterpolatedStringHandler.AppendLiteral("#Y#<");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#>#n在完成燃眉之急任务时获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(num);
						defaultInterpolatedStringHandler.AppendLiteral("个#n#Y");
						defaultInterpolatedStringHandler.AppendFormatted(text);
						defaultInterpolatedStringHandler.AppendLiteral("#n，真是羡煞旁人啊！#G#b今日#Y紫帝晶#G产出数量为#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.全服共享存档数据.当日紫帝晶数量);
						defaultInterpolatedStringHandler.AppendLiteral("/");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.燃眉配置.每日紫帝晶数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n，手快有，手慢无啊！");
						client频道事件2(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
				}
				IEnumerable<byte> first = Singleton<ByteAPI>.I.HtoC("4D5A00000000000000242603000108CCD6D5AED6AEC2B70000000000000000000000000000000000000000000000").Concat(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, P_0.user.人物数据.形象ID, P_0.user.人物数据.昵称, "#B你运起灵力,打开了葫芦,一阵宝光透出#n[DEFAULT/DEFAULT]"));
				WdAPI i3 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你从#R葫芦#n中获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				P_0.C_Send(first.Concat(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
			}
			else
			{
				Array.Empty<byte>();
				IEnumerable<byte> first2 = Singleton<ByteAPI>.I.HtoC("4D5A00000000000000242603000108CCD6D5AED6AEC2B70000000000000000000000000000000000000000000000").Concat(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.存档数据.燃眉之急任务.当前NPCID, P_0.user.存档数据.燃眉之急任务.当前NPC形象ID, P_0.user.存档数据.燃眉之急任务.当前NPC, "多谢道长相助。[DEFAULT/DEFAULT]"));
				WdAPI i4 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你从#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.燃眉之急任务.当前NPC);
				defaultInterpolatedStringHandler.AppendLiteral("#n中获得了#R1#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				byte[] buffer = first2.Concat(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray();
				if (text == "金凤樽")
				{
					Action<byte[]> client频道事件3 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件3 != null)
					{
						WdAPI i5 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 2);
						defaultInterpolatedStringHandler.AppendLiteral("#Y#<");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#>#n在完成燃眉之急任务时获得了#R1个#n#Y");
						defaultInterpolatedStringHandler.AppendFormatted(text);
						defaultInterpolatedStringHandler.AppendLiteral("#n，真是羡煞旁人呐！");
						client频道事件3(i5.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
				}
				else if (text == "紫帝晶")
				{
					Singleton<全局变量类>.I.全服共享存档数据.当日紫帝晶数量++;
					Action<byte[]> client频道事件4 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件4 != null)
					{
						WdAPI i6 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 4);
						defaultInterpolatedStringHandler.AppendLiteral("#Y#<");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#>#n在完成燃眉之急任务时获得了#R1个#n#Y");
						defaultInterpolatedStringHandler.AppendFormatted(text);
						defaultInterpolatedStringHandler.AppendLiteral("#n，真是羡煞旁人呐！#G#b今日#Y紫帝晶#G产出数量为#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.全服共享存档数据.当日紫帝晶数量);
						defaultInterpolatedStringHandler.AppendLiteral("/");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.燃眉配置.每日紫帝晶数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n，手快有，手慢无啊！");
						client频道事件4(i6.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
				}
				P_0.user.存档数据.燃眉之急任务.当前NPC = string.Empty;
				P_0.user.存档数据.燃眉之急任务.当前NPCID = 0;
				P_0.user.存档数据.燃眉之急任务.当前NPC形象ID = 0;
				P_0.user.存档数据.燃眉之急任务.任务类型 = 0;
				P_0.user.存档数据.燃眉之急任务.任务星级 = 0;
				P_0.C_Send(buffer);
			}
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, text, AllEnums.指令Type.无, num, false, "燃眉奖励");
			Singleton<BsbfIlwwf1YnPvbq8GT>.I.o2gwKNo6hU();
			Singleton<WdAPI>.I.NPC传送事件(P_0, "五行竞猜使");
		}
		catch (Exception ex)
		{
			Log.Error("燃眉之急_完成任务-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void E90WiBs8DV(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
			defaultInterpolatedStringHandler.AppendLiteral("#G今日全服产出紫帝晶数量：#L");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.全服共享存档数据.当日紫帝晶数量);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.燃眉配置.每日紫帝晶数量);
			defaultInterpolatedStringHandler.AppendLiteral("#r");
			StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
			if (P_1 == "燃眉操作_领取讨债任务")
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 2, stringBuilder2);
				handler.AppendLiteral("#Y今日任务领取情况：#Y");
				handler.AppendFormatted(P_0.user.存档数据.燃眉之急任务.任务次数);
				handler.AppendLiteral("/");
				handler.AppendFormatted(Singleton<全局变量类>.I.燃眉配置.每日次数);
				handler.AppendLiteral("次#r#r");
				stringBuilder3.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(16, 1, stringBuilder2);
				handler.AppendLiteral("#Y常规追讨：#n消耗");
				handler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.燃眉配置.常规价格));
				handler.AppendLiteral("保证金#r");
				stringBuilder4.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(16, 1, stringBuilder2);
				handler.AppendLiteral("#Y高级追讨：#n消耗");
				handler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.燃眉配置.高级价格));
				handler.AppendLiteral("保证金#r");
				stringBuilder5.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder6 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(16, 1, stringBuilder2);
				handler.AppendLiteral("#Y超级追讨：#n消耗");
				handler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.燃眉配置.超级价格));
				handler.AppendLiteral("保证金#r");
				stringBuilder6.Append(ref handler);
				stringBuilder.Append("[【常规追讨】领取任务/燃眉操作_领取低级燃眉任务][【高级追讨】领取任务/燃眉操作_领取中级燃眉任务][【超级追讨】领取任务/燃眉操作_领取高级燃眉任务]");
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.NPC_五行竞猜使, 6059, "五行竞猜使", stringBuilder.ToString()));
				return;
			}
			if (P_1 == "燃眉操作_领取低级燃眉任务")
			{
				SOCWBZW2Aa(P_0, 1);
				return;
			}
			if (P_1 == "燃眉操作_领取中级燃眉任务")
			{
				SOCWBZW2Aa(P_0, 2);
				return;
			}
			if (P_1 == "燃眉操作_领取高级燃眉任务")
			{
				SOCWBZW2Aa(P_0, 3);
				return;
			}
			if (P_1.Contains("燃眉操作_传送", StringComparison.CurrentCulture))
			{
				Singleton<WdAPI>.I.NPC传送事件(P_0, P_0.user.存档数据.燃眉之急任务.当前NPC);
				return;
			}
			if (P_1 == "燃眉操作_完成讨债任务")
			{
				P_0.user.缓存数据.燃煤计数器 = 1;
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, P_0.user.人物数据.形象ID, P_0.user.人物数据.昵称, "阁下近日油光满面，看来日子过得挺滋润的嘛！真是人靠衣装马靠鞍，阁下这身行头值不少钱吧？[DEFAULT/DEFAULT]"));
				return;
			}
			if (P_1 == "DEFAULT" && P_0.user.缓存数据.燃煤计数器 > 0 && !string.IsNullOrWhiteSpace(P_0.user.存档数据.燃眉之急任务.当前NPC))
			{
				if (P_0.user.缓存数据.燃煤计数器 == 1)
				{
					P_0.user.缓存数据.燃煤计数器 = 2;
					P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.存档数据.燃眉之急任务.当前NPCID, P_0.user.存档数据.燃眉之急任务.当前NPC形象ID, P_0.user.存档数据.燃眉之急任务.当前NPC, "勉强讨生，道长见笑啦！[DEFAULT/DEFAULT]"));
					return;
				}
				if (P_0.user.缓存数据.燃煤计数器 == 2)
				{
					P_0.user.缓存数据.燃煤计数器 = 3;
					P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, P_0.user.人物数据.形象ID, P_0.user.人物数据.昵称, "老实说，这等俗务贫道还真不愿揽下……只是五行竞猜使近日遇上难关，我也就只好觍着脸过来讨取债务，你看……[DEFAULT/DEFAULT]"));
					return;
				}
				if (P_0.user.缓存数据.燃煤计数器 == 3)
				{
					P_0.user.缓存数据.燃煤计数器 = 4;
					P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.存档数据.燃眉之急任务.当前NPCID, P_0.user.存档数据.燃眉之急任务.当前NPC形象ID, P_0.user.存档数据.燃眉之急任务.当前NPC, "道长的难处我非常理解，只是……我这身行头不过是撑撑门面，实则负债累累……家里就剩下这点珍玩……以及这个说不清名堂的葫芦，还望道长再多宽限几日！[DEFAULT/DEFAULT]"));
					return;
				}
				if (P_0.user.缓存数据.燃煤计数器 == 4)
				{
					P_0.user.缓存数据.燃煤计数器 = 0;
					P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, P_0.user.人物数据.形象ID, P_0.user.人物数据.昵称, "#B此人也算是情有可原，我要不要先收下一样东西让他安心……#n[收下葫芦/燃眉操作_暴力讨债][收下珍玩/燃眉操作_收下钱粮]"));
					return;
				}
			}
			if (P_1 == "燃眉操作_暴力讨债")
			{
				if (Singleton<WdAPI>.I.qrjo9TWIdy(1, 100) < Singleton<全局变量类>.I.燃眉配置.葫芦概率)
				{
					P_0.user.缓存数据.Is燃煤葫芦 = true;
					Singleton<WdAPI>.I.qAOo5w4shp(P_0);
					return;
				}
				P_0.user.存档数据.燃眉之急任务.当前NPC = string.Empty;
				P_0.user.存档数据.燃眉之急任务.当前NPCID = 0;
				P_0.user.存档数据.燃眉之急任务.当前NPC形象ID = 0;
				P_0.user.存档数据.燃眉之急任务.任务类型 = 0;
				P_0.user.存档数据.燃眉之急任务.任务星级 = 0;
				P_0.C_Send(Singleton<ByteAPI>.I.HtoC("4D5A00000000000000242603000108CCD6D5AED6AEC2B70000000000000000000000000000000000000000000000").Concat(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, P_0.user.人物数据.形象ID, P_0.user.人物数据.昵称, "#B你运起灵力，打开了葫芦，一缕晦气飘出了葫芦...#n[DEFAULT/DEFAULT]")).Concat(Singleton<WdAPI>.I.提示_中心提醒("你打开了葫芦，什么也没得到。"))
					.ToArray());
				Singleton<WdAPI>.I.NPC传送事件(P_0, "五行竞猜使");
			}
			else if (P_1 == "燃眉操作_收下钱粮")
			{
				drqWNtYw8O(P_0, false);
			}
		}
		catch (Exception ex)
		{
			Log.Error("燃眉对话事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void SOCWBZW2Aa(MyNATSocketClient P_0, int P_1)
	{
		try
		{
			if (!Singleton<全局变量类>.I.燃眉配置.功能开关)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前没有燃眉之急任务可以领取！"));
				return;
			}
			if (!string.IsNullOrWhiteSpace(P_0.user.存档数据.燃眉之急任务.当前NPC))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("您已有进行中的燃眉之急任务,无法继续领取。#r#R燃眉之急任务离线后自动放弃#n"));
				return;
			}
			if (P_0.user.存档数据.燃眉之急任务.任务次数 >= Singleton<全局变量类>.I.燃眉配置.每日次数)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("今天到此为止吧,请道友明日再来！"));
				return;
			}
			if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的包裹栏不足，无法领取燃眉之急任务！"));
				return;
			}
			int num = Singleton<全局变量类>.I.燃眉配置.超级价格;
			switch (P_1)
			{
			case 1:
				num = Singleton<全局变量类>.I.燃眉配置.常规价格;
				break;
			case 2:
				num = Singleton<全局变量类>.I.燃眉配置.高级价格;
				break;
			case 3:
				num = Singleton<全局变量类>.I.燃眉配置.超级价格;
				break;
			}
			if (P_0.user.背包数据.金钱 < num)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你无力提供保证金！"));
				return;
			}
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -num, false, "[燃眉]消耗");
			P_0.user.存档数据.燃眉之急任务.任务次数++;
			P_0.user.存档数据.燃眉之急任务.任务类型 = P_1;
			int num2 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
			P_0.user.存档数据.燃眉之急任务.当前NPC = ie5Wf8Vwhu[Singleton<WdAPI>.I.qrjo9TWIdy(0, ie5Wf8Vwhu.Count - 1)];
			if (num2 <= Singleton<全局变量类>.I.燃眉配置.五星概率)
			{
				P_0.user.存档数据.燃眉之急任务.任务星级 = 5;
			}
			else if (num2 <= Singleton<全局变量类>.I.燃眉配置.四星概率)
			{
				P_0.user.存档数据.燃眉之急任务.任务星级 = 4;
			}
			else if (num2 <= Singleton<全局变量类>.I.燃眉配置.三星概率)
			{
				P_0.user.存档数据.燃眉之急任务.任务星级 = 3;
			}
			else if (num2 <= Singleton<全局变量类>.I.燃眉配置.二星概率)
			{
				P_0.user.存档数据.燃眉之急任务.任务星级 = 2;
			}
			else
			{
				P_0.user.存档数据.燃眉之急任务.任务星级 = 2;
			}
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
			defaultInterpolatedStringHandler.AppendLiteral("你花费了");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(num));
			defaultInterpolatedStringHandler.AppendLiteral("#n文钱领取了#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.燃眉之急任务.任务星级);
			defaultInterpolatedStringHandler.AppendLiteral("星#n追讨任务，祝你顺利。");
			P_0.C_Send(i.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			OHvWGm4AAH(P_0);
			Singleton<UuQEWHhexEnQTYynfh>.I.mfC0jVvZE(P_0);
		}
		catch (Exception ex)
		{
			Log.Error("燃眉领取任务处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void OHvWGm4AAH(MyNATSocketClient P_0)
	{
		try
		{
			if (!string.IsNullOrWhiteSpace(P_0.user.存档数据.燃眉之急任务.当前NPC))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#Y今日任务领取次数：#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.燃眉之急任务.任务次数);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.燃眉配置.每日次数);
				defaultInterpolatedStringHandler.AppendLiteral("次#n#r");
				StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(20, 1, stringBuilder2);
				handler.AppendLiteral("恭喜你获得星级：#Y");
				handler.AppendFormatted(全局常量类.燃眉星级[P_0.user.存档数据.燃眉之急任务.任务星级]);
				handler.AppendLiteral(" #n的追讨任务#r");
				stringBuilder3.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
				handler.AppendLiteral("当前任务类型：#Y");
				handler.AppendFormatted((AllEnums.燃眉任务级别)P_0.user.存档数据.燃眉之急任务.任务类型);
				handler.AppendLiteral("#n#r");
				stringBuilder4.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
				handler.AppendLiteral("当前追讨目标：#Y");
				handler.AppendFormatted(P_0.user.存档数据.燃眉之急任务.当前NPC);
				handler.AppendLiteral("#n#r");
				stringBuilder5.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder6 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(22, 2, stringBuilder2);
				handler.AppendLiteral("[【传送】至");
				handler.AppendFormatted(P_0.user.存档数据.燃眉之急任务.当前NPC);
				handler.AppendLiteral("/燃眉操作_传送");
				handler.AppendFormatted(P_0.user.存档数据.燃眉之急任务.当前NPC);
				handler.AppendLiteral("][离开/离开]");
				stringBuilder6.Append(ref handler);
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.NPC_五行竞猜使, 6059, "五行竞猜使", stringBuilder.ToString()));
			}
		}
		catch (Exception ex)
		{
			Log.Error("组包燃眉之急领取完成面板-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public lrYK0bWD4sTSDkaJic1()
	{
	}

	
	static lrYK0bWD4sTSDkaJic1()
	{
		ie5Wf8Vwhu = new List<string>
		{
			"门派使者",
			"文曲星",
			"洞府传送使",
			"守护天神",
			"帮派使者",
			"普华天尊",
			"缤纷大使",
			"李总兵",
			"神算子",
			"集市传送人",
			"百晓通",
			"商会会长"
		};
	}
}
