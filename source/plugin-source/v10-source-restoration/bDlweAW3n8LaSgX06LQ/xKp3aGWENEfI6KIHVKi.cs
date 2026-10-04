using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace bDlweAW3n8LaSgX06LQ;

internal class xKp3aGWENEfI6KIHVKi : Singleton<xKp3aGWENEfI6KIHVKi>
{
	private static ConcurrentDictionary<string, int> IPUWtIPvEa;

	
	internal void SU8WYDbyeM()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("盲盒配置类.json")))
			{
				Singleton<全局变量类>.I.盲盒配置 = JsonConvert.DeserializeObject<盲盒配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("盲盒配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.盲盒配置 = new 盲盒配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("盲盒配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.百炼功能配置, Formatting.Indented));
			}
			IPUWtIPvEa.Clear();
			foreach (KeyValuePair<string, List<盲盒奖励类>> item in Singleton<全局变量类>.I.盲盒配置.盲盒列表)
			{
				IPUWtIPvEa.TryAdd(item.Key, item.Value.Sum( (盲盒奖励类 x) => x.获得几率));
			}
		}
		catch (Exception ex)
		{
			Log.Error("盲盒配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void pPVWpfGEyM()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("盲盒配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.盲盒配置, Formatting.Indented));
			Log.Debug("盲盒配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("盲盒配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string iVwW1qtOUK()
	{
		SU8WYDbyeM();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.盲盒配置, Formatting.Indented);
	}

	
	public void Tl5WxvS9Wp(string P_0)
	{
		Singleton<全局变量类>.I.盲盒配置 = JsonConvert.DeserializeObject<盲盒配置类>(P_0);
		pPVWpfGEyM();
	}

	
	internal void uTYWH1wtjI()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("礼包飘屏配置类.json")))
			{
				Singleton<全局变量类>.I.礼包飘屏配置 = JsonConvert.DeserializeObject<礼包飘屏配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("礼包飘屏配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.礼包飘屏配置 = new 礼包飘屏配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("礼包飘屏配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.礼包飘屏配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("礼包飘屏配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void veWW4OJKbS()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("礼包飘屏配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.礼包飘屏配置, Formatting.Indented));
			Log.Debug("礼包飘屏配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("礼包飘屏配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string GBbWeFLi6m()
	{
		uTYWH1wtjI();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.礼包飘屏配置, Formatting.Indented);
	}

	
	public void xs7WqBkdu8(string P_0)
	{
		Singleton<全局变量类>.I.礼包飘屏配置 = JsonConvert.DeserializeObject<礼包飘屏配置类>(P_0);
		veWW4OJKbS();
	}

	
	internal void jnBWr3icOw(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (!Singleton<全局变量类>.I.盲盒配置.盲盒列表.TryGetValue(P_1, out List<盲盒奖励类> value) || !IPUWtIPvEa.TryGetValue(P_1, out var value2) || value == null || value.Count <= 0 || value2 <= 0)
			{
				return;
			}
			if (!Singleton<全局变量类>.I.盲盒配置.多奖励列表.TryGetValue(P_1, out var value3))
			{
				value3 = false;
			}
			if (!value3)
			{
				int num = Singleton<WdAPI>.I.qrjo9TWIdy(1, value2);
				int num2 = 0;
				盲盒奖励类 盲盒奖励类2 = null;
				foreach (盲盒奖励类 item in value)
				{
					num2 += item.获得几率;
					if (num <= num2)
					{
						盲盒奖励类2 = item;
						break;
					}
				}
				if (盲盒奖励类2 == null)
				{
					return;
				}
				int num3 = Singleton<WdAPI>.I.qrjo9TWIdy(盲盒奖励类2.最低数量, 盲盒奖励类2.最高数量);
				if (string.IsNullOrWhiteSpace(盲盒奖励类2.奖励名字) || num3 <= 0)
				{
					return;
				}
				switch (盲盒奖励类2.奖励类型)
				{
				case AllEnums.数值Type.等级:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.level, num3, false, "[盲盒]获得");
					WdAPI i8 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的等级提升了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num3);
					defaultInterpolatedStringHandler.AppendLiteral("#n级！");
					P_0.C_Send(i8.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.道行:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, num3, false, "[盲盒]获得");
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了#Y" + Singleton<WdAPI>.I.道行转文本(num3) + "#n道行！"));
					break;
				case AllEnums.数值Type.经验:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.exp, num3, false, "[盲盒]获得");
					WdAPI i4 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num3);
					defaultInterpolatedStringHandler.AppendLiteral("#n点经验！");
					P_0.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.声望:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, num3, false, "[盲盒]获得");
					WdAPI i10 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num3);
					defaultInterpolatedStringHandler.AppendLiteral("#n点声望！");
					P_0.C_Send(i10.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.战绩:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.total_score, num3, false, "[盲盒]获得");
					WdAPI i9 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num3);
					defaultInterpolatedStringHandler.AppendLiteral("#n点战绩！");
					P_0.C_Send(i9.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.金元宝:
					if (DB.I.cAJNoOkab6(P_0, num3, 0))
					{
						WdAPI i7 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(num3);
						defaultInterpolatedStringHandler.AppendLiteral("#n金元宝！");
						P_0.C_Send(i7.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					break;
				case AllEnums.数值Type.银元宝:
					if (DB.I.cAJNoOkab6(P_0, 0, num3))
					{
						WdAPI i6 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(num3);
						defaultInterpolatedStringHandler.AppendLiteral("#n银元宝！");
						P_0.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					break;
				case AllEnums.数值Type.金钱:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, num3, false, "[盲盒]获得");
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了" + Singleton<WdAPI>.I.问道标准数值文本(num3) + "#n文金钱！"));
					break;
				case AllEnums.数值Type.累充点:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, num3, false, "打开" + P_1 + "盲盒获得");
					WdAPI i5 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num3);
					defaultInterpolatedStringHandler.AppendLiteral("#n点累充点！");
					P_0.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.道具:
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 盲盒奖励类2.奖励名字, AllEnums.指令Type.无, num3, false, "盲盒奖励"))
					{
						WdAPI i3 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(盲盒奖励类2.奖励名字);
						defaultInterpolatedStringHandler.AppendLiteral("×");
						defaultInterpolatedStringHandler.AppendFormatted(num3);
						defaultInterpolatedStringHandler.AppendLiteral("#n");
						P_0.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					break;
				case AllEnums.数值Type.体力:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.stamina, num3, false, "[盲盒]获得");
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num3);
					defaultInterpolatedStringHandler.AppendLiteral("#n点体力！");
					P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.南极点:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, num3, false, "[" + P_1 + "]盲盒获得");
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num3);
					defaultInterpolatedStringHandler.AppendLiteral("#n点南极点！");
					P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.代金券:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.voucher, num3, false, "[盲盒]获得");
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了" + Singleton<WdAPI>.I.问道标准数值文本(num3) + "#n文代金券！"));
					break;
				case AllEnums.数值Type.宠物:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.宠物, 盲盒奖励类2.奖励名字, AllEnums.指令Type.无, 1, false, "盲盒抽奖");
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了宠物#R" + 盲盒奖励类2.奖励名字 + "#n。"));
					break;
				case AllEnums.数值Type.坐骑:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.坐骑, 盲盒奖励类2.奖励名字, AllEnums.指令Type.无, 1, false, "盲盒抽奖");
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了坐骑#R" + 盲盒奖励类2.奖励名字 + "#n。"));
					break;
				case AllEnums.数值Type.气血上限:
					break;
				}
				return;
			}
			foreach (盲盒奖励类 item2 in value)
			{
				if (Singleton<WdAPI>.I.qrjo9TWIdy(1, 10000) > item2.获得几率)
				{
					continue;
				}
				int num4 = Singleton<WdAPI>.I.qrjo9TWIdy(item2.最低数量, item2.最高数量);
				if (string.IsNullOrWhiteSpace(item2.奖励名字) || num4 <= 0)
				{
					continue;
				}
				switch (item2.奖励类型)
				{
				case AllEnums.数值Type.等级:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.level, num4, false, "[盲盒]获得");
					WdAPI i18 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的等级提升了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num4);
					defaultInterpolatedStringHandler.AppendLiteral("#n级！");
					P_0.C_Send(i18.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				case AllEnums.数值Type.道行:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, num4, false, "[盲盒]获得");
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了#Y" + Singleton<WdAPI>.I.道行转文本(num4) + "#n道行！"));
					return;
				case AllEnums.数值Type.经验:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.exp, num4, false, "[盲盒]获得");
					WdAPI i14 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num4);
					defaultInterpolatedStringHandler.AppendLiteral("#n点经验！");
					P_0.C_Send(i14.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				case AllEnums.数值Type.声望:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, num4, false, "[盲盒]获得");
					WdAPI i20 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num4);
					defaultInterpolatedStringHandler.AppendLiteral("#n点声望！");
					P_0.C_Send(i20.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				case AllEnums.数值Type.战绩:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.total_score, num4, false, "[盲盒]获得");
					WdAPI i19 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num4);
					defaultInterpolatedStringHandler.AppendLiteral("#n点战绩！");
					P_0.C_Send(i19.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				case AllEnums.数值Type.金元宝:
					if (DB.I.cAJNoOkab6(P_0, num4, 0))
					{
						WdAPI i17 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(num4);
						defaultInterpolatedStringHandler.AppendLiteral("#n金元宝！");
						P_0.C_Send(i17.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					break;
				case AllEnums.数值Type.银元宝:
					if (DB.I.cAJNoOkab6(P_0, 0, num4))
					{
						WdAPI i16 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(num4);
						defaultInterpolatedStringHandler.AppendLiteral("#n银元宝！");
						P_0.C_Send(i16.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					break;
				case AllEnums.数值Type.金钱:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, num4, false, "[盲盒]获得");
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了" + Singleton<WdAPI>.I.问道标准数值文本(num4) + "#n文金钱！"));
					return;
				case AllEnums.数值Type.累充点:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, num4, false, "打开" + P_1 + "盲盒获得");
					WdAPI i15 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num4);
					defaultInterpolatedStringHandler.AppendLiteral("#n点累充点！");
					P_0.C_Send(i15.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				case AllEnums.数值Type.道具:
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, item2.奖励名字, AllEnums.指令Type.无, num4, false, "盲盒奖励"))
					{
						WdAPI i13 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(item2.奖励名字);
						defaultInterpolatedStringHandler.AppendLiteral("×");
						defaultInterpolatedStringHandler.AppendFormatted(num4);
						defaultInterpolatedStringHandler.AppendLiteral("#n");
						P_0.C_Send(i13.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					break;
				case AllEnums.数值Type.体力:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.stamina, num4, false, "[盲盒]获得");
					WdAPI i12 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num4);
					defaultInterpolatedStringHandler.AppendLiteral("#n点体力！");
					P_0.C_Send(i12.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				case AllEnums.数值Type.南极点:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, num4, false, "[" + P_1 + "]盲盒获得");
					WdAPI i11 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num4);
					defaultInterpolatedStringHandler.AppendLiteral("#n点南极点！");
					P_0.C_Send(i11.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				case AllEnums.数值Type.代金券:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.voucher, num4, false, "[盲盒]获得");
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了" + Singleton<WdAPI>.I.问道标准数值文本(num4) + "#n文代金券！"));
					return;
				case AllEnums.数值Type.宠物:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.宠物, item2.奖励名字, AllEnums.指令Type.无, 1, false, "盲盒抽奖");
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了宠物#R" + item2.奖励名字 + "#n。"));
					break;
				case AllEnums.数值Type.坐骑:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.坐骑, item2.奖励名字, AllEnums.指令Type.无, 1, false, "盲盒抽奖");
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你获得了坐骑#R" + item2.奖励名字 + "#n。"));
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("使用盲盒道具事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void c7OWZ5ebsQ(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if ((全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.IsVip) && Singleton<全局变量类>.I.礼包飘屏配置.礼包列表.TryGetValue(P_1, out string value) && !string.IsNullOrWhiteSpace(value))
			{
				value = value.Replace("%user%", P_0.user.人物数据.昵称);
				value = value.Replace("%item%", P_1);
				Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.PWRouuXjmn(value));
			}
		}
		catch (Exception ex)
		{
			Log.Error("飘屏礼包使用事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public xKp3aGWENEfI6KIHVKi()
	{
	}

	
	static xKp3aGWENEfI6KIHVKi()
	{
		IPUWtIPvEa = new ConcurrentDictionary<string, int>();
	}
}
