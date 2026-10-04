using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace EKROCVD7DRi8Cx5mpUu;

internal class Rfq62uDvr7Ur9Lpyctd : Singleton<Rfq62uDvr7Ur9Lpyctd>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public string Iw05HorsK5;

		
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		
		internal bool AiI5xqXYEg(string x)
		{
			return Iw05HorsK5 == x;
		}

		static _003C_003Ec__DisplayClass5_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public 地图限制列表类 St05etPTl7;

		
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		
		internal bool VFe54dH5sP(超级NPC传送类 x)
		{
			return x.地图名字 == St05etPTl7.地图名字;
		}

		static _003C_003Ec__DisplayClass6_0()
		{
		}
	}

	internal List<string> QunDOPTTn7;

	
	internal void rjSDarumvY()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级地图配置类.json")))
			{
				Singleton<全局变量类>.I.超级地图配置 = JsonConvert.DeserializeObject<超级地图配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级地图配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.超级地图配置 = new 超级地图配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级地图配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级地图配置, Formatting.Indented));
			}
			QunDOPTTn7.Clear();
			foreach (地图限制列表类 value in Singleton<全局变量类>.I.超级地图配置.地图列表.Values)
			{
				if (!string.IsNullOrWhiteSpace(value.关键词))
				{
					QunDOPTTn7.Add(value.关键词);
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("超级地图配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void QEEDT9XrNK()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级地图配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级地图配置, Formatting.Indented));
			Log.Debug("超级地图配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("超级地图配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string whnD92BCek()
	{
		rjSDarumvY();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级地图配置, Formatting.Indented);
	}

	
	public void OepDyBtBRW(string P_0)
	{
		Singleton<全局变量类>.I.超级地图配置 = JsonConvert.DeserializeObject<超级地图配置类>(P_0);
		QEEDT9XrNK();
	}

	
	internal bool mTRDCi5Wu2(string P_0)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals2.Iw05HorsK5 = P_0;
		return QunDOPTTn7.Any( (string x) => CS_0024_003C_003E8__locals2.Iw05HorsK5 == x);
	}

	
	internal bool iV4DVGrwZy(MyNATSocketClient P_0, 地图限制列表类 P_1, 超级NPC列表类 P_2)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals7.St05etPTl7 = P_1;
		try
		{
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return false;
			}
			bool flag = false;
			if (CS_0024_003C_003E8__locals7.St05etPTl7.is限制组队 && P_0.user.队伍数据.成员列表.Count > 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + CS_0024_003C_003E8__locals7.St05etPTl7.地图名字 + "#n地图无法组队进入，请离开队伍后再次尝试！"));
				return false;
			}
			flag = ((P_0.user.队伍数据.成员列表.Count > 1) ? mNsD0xYTS4(P_0, CS_0024_003C_003E8__locals7.St05etPTl7) : Wf7DkJgGWj(P_0, CS_0024_003C_003E8__locals7.St05etPTl7));
			if (flag && P_2 != null)
			{
				超级NPC传送类 超级NPC传送类2 = P_2.地图列表.Find( (超级NPC传送类 x) => x.地图名字 == CS_0024_003C_003E8__locals7.St05etPTl7.地图名字);
				if (超级NPC传送类2 != null && Singleton<全局变量类>.I.所有地图字典.TryGetValue(CS_0024_003C_003E8__locals7.St05etPTl7.地图名字, out var value))
				{
					Singleton<WdAPI>.I.地图传送事件(P_0, value, 超级NPC传送类2.X坐标, 超级NPC传送类2.Y坐标);
				}
				return false;
			}
			return flag;
		}
		catch (Exception ex)
		{
			Log.Error("超级地图对话处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal bool Wf7DkJgGWj(MyNATSocketClient P_0, 地图限制列表类 P_1)
	{
		try
		{
			if (P_1.is限制等级)
			{
				if (P_0.user.属性数据.等级 < P_1.最低等级)
				{
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的等级不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.最低等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (P_0.user.属性数据.等级 > P_1.最高等级)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的等级超过了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.最高等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
			}
			if (P_1.is限制道行)
			{
				if (P_0.user.属性数据.道行 < P_1.最低道行 * 360)
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的道行不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.最低道行);
					defaultInterpolatedStringHandler.AppendLiteral("#n年，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (P_0.user.属性数据.道行 > P_1.最高道行 * 360)
				{
					WdAPI i4 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的道行超过了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.最高道行);
					defaultInterpolatedStringHandler.AppendLiteral("#n年，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
			}
			if (P_1.is限制活跃)
			{
				if (P_0.user.缓存数据.活跃值 < P_1.最低活跃)
				{
					WdAPI i5 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的活跃度不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.最低活跃);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (P_0.user.缓存数据.活跃值 > P_1.最高活跃)
				{
					WdAPI i6 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的活跃度超过了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.最高活跃);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
			}
			if (P_1.is限制称号)
			{
				if (!string.IsNullOrWhiteSpace(P_1.限主称号) && !P_0.user.缓存数据.所有称号文本.ToString().Contains("|" + P_1.限主称号 + "|", StringComparison.CurrentCulture))
				{
					WdAPI i7 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你并未拥有#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.限主称号);
					defaultInterpolatedStringHandler.AppendLiteral("#n称号，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i7.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (!string.IsNullOrWhiteSpace(P_1.限副称号) && !P_0.user.缓存数据.所有称号文本.ToString().Contains("|" + P_1.限副称号 + "|", StringComparison.CurrentCulture))
				{
					WdAPI i8 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你并未拥有#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.限副称号);
					defaultInterpolatedStringHandler.AppendLiteral("#n称号，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i8.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
			}
			if (!P_1.is消耗道具 || P_1.消耗类型 == AllEnums.数值Type.无)
			{
				return true;
			}
			if (string.IsNullOrWhiteSpace(P_1.消耗道具) || P_1.消耗数量 <= 0)
			{
				return true;
			}
			switch (P_1.消耗类型)
			{
			case AllEnums.数值Type.金元宝:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.背包数据.金元宝 < P_1.消耗数量)
				{
					WdAPI i25 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的金元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i25.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (!DB.I.cAJNoOkab6(P_0, -P_1.消耗数量, 0))
				{
					WdAPI i26 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的金元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i26.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				WdAPI i27 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n金元宝，进入了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n！");
				P_0.C_Send(i27.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.银元宝:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.背包数据.银元宝 < P_1.消耗数量)
				{
					WdAPI i18 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的银元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i18.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (!DB.I.cAJNoOkab6(P_0, 0, -P_1.消耗数量))
				{
					WdAPI i19 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的银元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i19.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				WdAPI i20 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n银元宝，进入了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n！");
				P_0.C_Send(i20.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.声望:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.属性数据.声望 < P_1.消耗数量)
				{
					WdAPI i28 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的声望不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i28.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, -P_1.消耗数量, false, "[地图]消耗");
				WdAPI i29 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n点声望，进入了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n！");
				P_0.C_Send(i29.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.战绩:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.属性数据.战绩 < P_1.消耗数量)
				{
					WdAPI i14 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的战绩不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i14.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.total_score, -P_1.消耗数量, false, "[地图]消耗");
				WdAPI i15 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n点战绩，进入了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n！");
				P_0.C_Send(i15.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.金钱:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.背包数据.金钱 < P_1.消耗数量)
				{
					WdAPI i21 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的游戏币不足");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(P_1.消耗数量));
					defaultInterpolatedStringHandler.AppendLiteral("文，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i21.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -P_1.消耗数量, false, "[地图]消耗");
				WdAPI i22 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(P_1.消耗数量));
				defaultInterpolatedStringHandler.AppendLiteral("点金钱，进入了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n！");
				P_0.C_Send(i22.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.累充点:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.存档数据.累计充值金额 < P_1.消耗数量)
				{
					WdAPI i12 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的累充点不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i12.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, -P_1.消耗数量, false, "进入" + P_1.地图名字 + "消耗");
				WdAPI i13 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n累充点，进入了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n！");
				P_0.C_Send(i13.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.南极点:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.存档数据.南极抽奖次数 < P_1.消耗数量)
				{
					WdAPI i23 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的南极点不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i23.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, -P_1.消耗数量, false, "进入" + P_1.地图名字 + "消耗");
				WdAPI i24 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n南极点，进入了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n！");
				P_0.C_Send(i24.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.灵气值:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.存档数据.数值存档.灵气值 < P_1.消耗数量)
				{
					WdAPI i16 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的灵气值不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i16.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -P_1.消耗数量, false, "进入" + P_1.地图名字 + "消耗");
				WdAPI i17 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n灵气值，进入了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n！");
				P_0.C_Send(i17.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.体力:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.属性数据.当前体力 < P_1.消耗数量)
				{
					WdAPI i30 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的体力不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i30.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.stamina, -P_1.消耗数量, false, "[地图]消耗");
				WdAPI i31 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n点体力，进入了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n！");
				P_0.C_Send(i31.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.道具:
			{
				物品信息类 物品信息类2 = Singleton<WdAPI>.I.取背包物品格子实例(P_0, P_1.消耗道具);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (物品信息类2 == null)
				{
					WdAPI i9 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你并未拥有#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n道具，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i9.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (物品信息类2.数量 < P_1.消耗数量)
				{
					WdAPI i10 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
					defaultInterpolatedStringHandler.AppendLiteral("你拥有的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n数量不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n个，无法进入#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i10.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 1)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的背包已满，无法进入#Y" + P_1.地图名字 + "#n！"));
					return false;
				}
				if (!Singleton<WdAPI>.I.dSCoKmGWP9(P_0))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的宠物栏已满，无法进入#Y" + P_1.地图名字 + "#n！"));
					return false;
				}
				Singleton<WdAPI>.I.使用背包批量异步(P_0, 物品信息类2.Index, P_1.消耗数量);
				WdAPI i11 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗道具);
				defaultInterpolatedStringHandler.AppendLiteral("#n，进入了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n！");
				P_0.C_Send(i11.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			}
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("单人进入地图验证-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal bool mNsD0xYTS4(MyNATSocketClient P_0, 地图限制列表类 P_1)
	{
		try
		{
			ConcurrentDictionary<MyNATSocketClient, int> concurrentDictionary = new ConcurrentDictionary<MyNATSocketClient, int>();
			foreach (int item in P_0.user.队伍数据.成员列表)
			{
				MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定角色ID玩家MyClient(item);
				if (myNATSocketClient == null)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("队伍有成员暂未在线，无法进入#Y" + P_1.地图名字 + "#n！"));
					return false;
				}
				if (P_0.user.缓存数据.is使用仙灵卡)
				{
					return false;
				}
				if (P_1.is限制等级)
				{
					if (myNATSocketClient.user.属性数据.等级 < P_1.最低等级)
					{
						WdAPI i = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的等级不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.最低等级);
						defaultInterpolatedStringHandler.AppendLiteral("#n级，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (myNATSocketClient.user.属性数据.等级 > P_1.最高等级)
					{
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的等级超过了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.最高等级);
						defaultInterpolatedStringHandler.AppendLiteral("#n级，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
				}
				if (P_1.is限制道行)
				{
					if (myNATSocketClient.user.属性数据.道行 < P_1.最低道行 * 360)
					{
						WdAPI i3 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的道行不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.最低道行);
						defaultInterpolatedStringHandler.AppendLiteral("#n年，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (myNATSocketClient.user.属性数据.道行 > P_1.最高道行 * 360)
					{
						WdAPI i4 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的道行超过了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.最高道行);
						defaultInterpolatedStringHandler.AppendLiteral("#n年，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
				}
				if (P_1.is限制活跃)
				{
					if (myNATSocketClient.user.缓存数据.活跃值 < P_1.最低活跃)
					{
						WdAPI i5 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的活跃度不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.最低活跃);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (myNATSocketClient.user.缓存数据.活跃值 > P_1.最高活跃)
					{
						WdAPI i6 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的活跃度超过了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.最高活跃);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
				}
				if (P_1.is限制称号)
				{
					if (!string.IsNullOrWhiteSpace(P_1.限主称号) && !myNATSocketClient.user.缓存数据.所有称号文本.ToString().Contains("|" + P_1.限主称号 + "|", StringComparison.CurrentCulture))
					{
						WdAPI i7 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n并未拥有#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.限主称号);
						defaultInterpolatedStringHandler.AppendLiteral("#n称号，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i7.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (!string.IsNullOrWhiteSpace(P_1.限副称号) && !myNATSocketClient.user.缓存数据.所有称号文本.ToString().Contains("|" + P_1.限副称号 + "|", StringComparison.CurrentCulture))
					{
						WdAPI i8 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n并未拥有#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.限副称号);
						defaultInterpolatedStringHandler.AppendLiteral("#n称号，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i8.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
				}
				if (!P_1.is消耗道具 || P_1.消耗类型 == AllEnums.数值Type.无 || P_1.消耗数量 <= 0)
				{
					continue;
				}
				if (P_1.消耗类型 == AllEnums.数值Type.道具)
				{
					物品信息类 物品信息类2 = Singleton<WdAPI>.I.取背包物品格子实例(P_0, P_1.消耗道具);
					if (物品信息类2 == null)
					{
						WdAPI i9 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n并未拥有#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗道具);
						defaultInterpolatedStringHandler.AppendLiteral("#n道具，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i9.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (物品信息类2.数量 < P_1.消耗数量)
					{
						WdAPI i10 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 4);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n拥有的#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗道具);
						defaultInterpolatedStringHandler.AppendLiteral("#n数量不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n个，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i10.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 1)
					{
						WdAPI i11 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的背包已满，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i11.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (!Singleton<WdAPI>.I.dSCoKmGWP9(P_0))
					{
						WdAPI i12 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的宠物栏已满，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i12.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					concurrentDictionary.TryAdd(myNATSocketClient, 物品信息类2.Index);
					continue;
				}
				switch (P_1.消耗类型)
				{
				case AllEnums.数值Type.金元宝:
					if (P_0.user.背包数据.金元宝 < P_1.消耗数量)
					{
						WdAPI i14 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的金元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i14.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.银元宝:
					if (P_0.user.背包数据.银元宝 < P_1.消耗数量)
					{
						WdAPI i18 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的银元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i18.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.声望:
					if (P_0.user.属性数据.声望 < P_1.消耗数量)
					{
						WdAPI i20 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的声望不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i20.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.战绩:
					if (P_0.user.属性数据.战绩 < P_1.消耗数量)
					{
						WdAPI i16 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的战绩不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i16.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.金钱:
					if (P_0.user.背包数据.金钱 < P_1.消耗数量)
					{
						WdAPI i21 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的游戏币不足");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(P_1.消耗数量));
						defaultInterpolatedStringHandler.AppendLiteral("文，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i21.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.累充点:
					if (P_0.user.存档数据.累计充值金额 < P_1.消耗数量)
					{
						WdAPI i19 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的累充点不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i19.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.南极点:
					if (P_0.user.存档数据.南极抽奖次数 < P_1.消耗数量)
					{
						WdAPI i17 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的南极点不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i17.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.灵气值:
					if (P_0.user.存档数据.数值存档.灵气值 < P_1.消耗数量)
					{
						WdAPI i15 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的灵气值不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i15.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.体力:
					if (P_0.user.属性数据.当前体力 < P_1.消耗数量)
					{
						WdAPI i13 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的体力不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i13.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				}
				concurrentDictionary.TryAdd(myNATSocketClient, 0);
			}
			if (!concurrentDictionary.IsEmpty)
			{
				foreach (KeyValuePair<MyNATSocketClient, int> item2 in concurrentDictionary)
				{
					if (P_1.消耗类型 == AllEnums.数值Type.道具)
					{
						Singleton<WdAPI>.I.使用背包批量异步(item2.Key, item2.Value, P_1.消耗数量);
						continue;
					}
					switch (P_1.消耗类型)
					{
					case AllEnums.数值Type.金元宝:
					{
						DB.I.cAJNoOkab6(item2.Key, -P_1.消耗数量, 0);
						MyNATSocketClient key9 = item2.Key;
						WdAPI i30 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n金元宝，进入了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						key9.C_Send(i30.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.银元宝:
					{
						DB.I.cAJNoOkab6(item2.Key, 0, -P_1.消耗数量);
						MyNATSocketClient key8 = item2.Key;
						WdAPI i29 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n银元宝，进入了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						key8.C_Send(i29.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.声望:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, -P_1.消耗数量, false, "[地图]消耗");
						MyNATSocketClient key7 = item2.Key;
						WdAPI i28 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点声望，进入了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						key7.C_Send(i28.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.战绩:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.total_score, -P_1.消耗数量, false, "[地图]消耗");
						MyNATSocketClient key6 = item2.Key;
						WdAPI i27 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点战绩，进入了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						key6.C_Send(i27.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.金钱:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -P_1.消耗数量, false, "[地图]消耗");
						MyNATSocketClient key5 = item2.Key;
						WdAPI i26 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你消耗了");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(P_1.消耗数量));
						defaultInterpolatedStringHandler.AppendLiteral("点金钱，进入了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						key5.C_Send(i26.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.累充点:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, -P_1.消耗数量, false, "进入" + P_1.地图名字 + "消耗");
						MyNATSocketClient key4 = item2.Key;
						WdAPI i25 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n累充点，进入了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						key4.C_Send(i25.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.南极点:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, -P_1.消耗数量, false, "进入" + P_1.地图名字 + "消耗");
						MyNATSocketClient key3 = item2.Key;
						WdAPI i24 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n南极点，进入了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						key3.C_Send(i24.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.灵气值:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -P_1.消耗数量, false, "进入" + P_1.地图名字 + "消耗");
						MyNATSocketClient key2 = item2.Key;
						WdAPI i23 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n灵气值，进入了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						key2.C_Send(i23.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.体力:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.stamina, -P_1.消耗数量, false, "[地图]消耗");
						MyNATSocketClient key = item2.Key;
						WdAPI i22 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点体力，进入了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.地图名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						key.C_Send(i22.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					}
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("组队进入地图验证-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	public Rfq62uDvr7Ur9Lpyctd()
	{
		QunDOPTTn7 = new List<string>();
	}

	static Rfq62uDvr7Ur9Lpyctd()
	{
	}
}
