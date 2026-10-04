using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace wcxwepjSDDAt5sUJfS8;

internal class KB0ManjLR9N2YNMntee : Singleton<KB0ManjLR9N2YNMntee>
{
	
	internal void H5fjcI5HaH()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("通天塔突破配置类.json")))
			{
				Singleton<全局变量类>.I.通天塔突破配置 = JsonConvert.DeserializeObject<通天塔突破配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("通天塔突破配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.通天塔突破配置 = new 通天塔突破配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("通天塔突破配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.通天塔突破配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("通天塔突破配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void QYQjni4aPR()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("通天塔突破配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.通天塔突破配置, Formatting.Indented));
			Log.Debug("通天塔突破配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("通天塔突破配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string sMyj5SvIp0()
	{
		H5fjcI5HaH();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.通天塔突破配置, Formatting.Indented);
	}

	
	public void nfijMIY1tS(string P_0)
	{
		Singleton<全局变量类>.I.通天塔突破配置 = JsonConvert.DeserializeObject<通天塔突破配置类>(P_0);
		QYQjni4aPR();
	}

	
	internal void E0ejhchPa1(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_1.Equals("领取通天塔突破奖励"))
			{
				P_1 = string.Empty;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				foreach (KeyValuePair<int, string> item in Singleton<全局变量类>.I.通天塔突破配置.通天塔奖励列表.OrderBy<KeyValuePair<int, string>, int>( (KeyValuePair<int, string> kvp) => kvp.Key).ToDictionary( (KeyValuePair<int, string> kvp) => kvp.Key,  (KeyValuePair<int, string> kvp) => kvp.Value))
				{
					string 通天塔突破领取 = P_0.user.存档数据.通天塔突破领取;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("|");
					defaultInterpolatedStringHandler.AppendFormatted(item.Key);
					defaultInterpolatedStringHandler.AppendLiteral("|");
					if (!通天塔突破领取.Contains(defaultInterpolatedStringHandler.ToStringAndClear(), StringComparison.CurrentCulture))
					{
						string text = P_1;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
						defaultInterpolatedStringHandler.AppendLiteral("[我要领取");
						defaultInterpolatedStringHandler.AppendFormatted(item.Key);
						defaultInterpolatedStringHandler.AppendLiteral("层的首次突破奖励/领取通天塔突破奖励_");
						defaultInterpolatedStringHandler.AppendFormatted(item.Key);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						P_1 = text + defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(148, 1);
				defaultInterpolatedStringHandler.AppendLiteral("#R每一次突破极限便是对自身实力最好的提升，通天塔有尽头，修炼却没有尽头，上古大能造就通天塔并留下一个丰富的宝库，凡是每一次突破自身极限都可以找老朽领取一份丰富的修炼礼包。#r#n#G请整理好背包位置，领取奖励需要准备5个背包空格以上，否则将无法获得奖励。#r当前最高挑战层数为：#n#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.通天塔突破层数);
				defaultInterpolatedStringHandler.AppendLiteral("#n层！");
				P_1 = defaultInterpolatedStringHandler.ToStringAndClear() + P_1;
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.NPC_北斗星使, 6047, "北斗星使", P_1));
			}
			else
			{
				if (!P_1.Contains("领取通天塔突破奖励_", StringComparison.CurrentCulture))
				{
					return;
				}
				int.TryParse(P_1.Replace("领取通天塔突破奖励_", ""), out var result);
				if (result <= 0)
				{
					return;
				}
				if (string.IsNullOrWhiteSpace(P_0.user.存档数据.通天塔突破领取))
				{
					P_0.user.存档数据.通天塔突破领取 = "|";
				}
				string 通天塔突破领取2 = P_0.user.存档数据.通天塔突破领取;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(result);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				string value;
				if (通天塔突破领取2.Contains(defaultInterpolatedStringHandler.ToStringAndClear(), StringComparison.CurrentCulture))
				{
					P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.NPC_北斗星使, 6047, "北斗星使", "小友休得胡闹，你已经领取过该层数的奖励，再来胡闹休怪老夫不客气！"));
				}
				else if (P_0.user.存档数据.通天塔突破层数 < result)
				{
					P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.NPC_北斗星使, 6047, "北斗星使", "小友并未突破新的极限，待你突破新的极限后再来找老夫领取奖励吧！"));
				}
				else if (Singleton<全局变量类>.I.通天塔突破配置.通天塔奖励列表.TryGetValue(result, out value))
				{
					角色存档数据类 存档数据 = P_0.user.存档数据;
					string 通天塔突破领取3 = 存档数据.通天塔突破领取;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
					defaultInterpolatedStringHandler.AppendFormatted(result);
					defaultInterpolatedStringHandler.AppendLiteral("|");
					存档数据.通天塔突破领取 = 通天塔突破领取3 + defaultInterpolatedStringHandler.ToStringAndClear();
					WdAPI i = Singleton<WdAPI>.I;
					string text2 = value;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler.AppendLiteral("通天塔突破");
					defaultInterpolatedStringHandler.AppendFormatted(result);
					defaultInterpolatedStringHandler.AppendLiteral("层奖励");
					i.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, text2, AllEnums.指令Type.无, 1, false, defaultInterpolatedStringHandler.ToStringAndClear());
					Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件 != null)
					{
						WdAPI i2 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
						defaultInterpolatedStringHandler.AppendLiteral("#63震惊！玩家#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n在通天塔内首次突破了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(result);
						defaultInterpolatedStringHandler.AppendLiteral("#n层，获得了");
						client频道事件(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear() + "{" + value + "}", "管理员"));
					}
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("通天塔突破事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public KB0ManjLR9N2YNMntee()
	{
	}

	static KB0ManjLR9N2YNMntee()
	{
	}
}
