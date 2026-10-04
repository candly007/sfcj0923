using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;
using Serilog;
using qP09WjBc7nUNQOcDDy3;
using vEAdPGPTkDFOYsbi303;

namespace CKS3DKsTBrUPphoeWmS;

internal class L4IbybsayJA7RG5d8t7 : Singleton<L4IbybsayJA7RG5d8t7>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public string[] PhdcuxmIMC;

		
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		
		internal bool DeESzUD9vx(染色坐姿数据列表类 a)
		{
			return a.染后坐姿ID == PhdcuxmIMC[1];
		}

		static _003C_003Ec__DisplayClass17_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public int NQUcbJkihA;

		
		public _003C_003Ec__DisplayClass18_0()
		{
		}

		
		internal bool NMGcweO7HS(道行达标奖励配置类 a)
		{
			return a.最低道行 == NQUcbJkihA;
		}

		static _003C_003Ec__DisplayClass18_0()
		{
		}
	}

	internal static byte[] is0sZDaIcf;

	
	internal void fwTs9lslDP()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("指定会员配置类.json")))
			{
				Singleton<全局变量类>.I.指定会员配置 = JsonConvert.DeserializeObject<指定会员配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("指定会员配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.指定会员配置 = new 指定会员配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("指定会员配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.指定会员配置, Formatting.Indented));
			}
			vZ6s1m47eu();
		}
		catch (Exception ex)
		{
			Log.Error("指定会员配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void zuXsybcJpN()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("指定会员配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.指定会员配置, Formatting.Indented));
			Log.Debug("指定会员配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("指定会员配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string N5TsCgqBI4()
	{
		fwTs9lslDP();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.指定会员配置, Formatting.Indented);
	}

	
	public void x5HsVAvg3Z(string P_0)
	{
		Singleton<全局变量类>.I.指定会员配置 = JsonConvert.DeserializeObject<指定会员配置类>(P_0);
		zuXsybcJpN();
	}

	
	internal void gTqsk13OCC()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("道行达标配置类.json")))
			{
				Singleton<全局变量类>.I.道行达标配置 = JsonConvert.DeserializeObject<道行达标配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("道行达标配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.道行达标配置 = new 道行达标配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("道行达标配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.道行达标配置, Formatting.Indented));
			}
			Singleton<全局变量类>.I.道行达标配置.道行达标奖励列表.Sort();
		}
		catch (Exception ex)
		{
			Log.Error("道行达标配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void Ksls0duMVI()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("道行达标配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.道行达标配置, Formatting.Indented));
			Log.Debug("道行达标配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("道行达标配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string PAxsOqS9w0()
	{
		gTqsk13OCC();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.道行达标配置, Formatting.Indented);
	}

	
	public void ApLsQOLl41(string P_0)
	{
		Singleton<全局变量类>.I.道行达标配置 = JsonConvert.DeserializeObject<道行达标配置类>(P_0);
		Ksls0duMVI();
	}

	
	internal void HaWsEY7G5V()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("活跃度配置类.json")))
			{
				Singleton<全局变量类>.I.活跃度配置 = JsonConvert.DeserializeObject<活跃度配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("活跃度配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.活跃度配置 = new 活跃度配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("活跃度配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.活跃度配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("活跃度配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void JJvs3nRZte()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("活跃度配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.活跃度配置, Formatting.Indented));
			Log.Debug("活跃度配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("活跃度配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string XBTsY9u8tI()
	{
		HaWsEY7G5V();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.活跃度配置, Formatting.Indented);
	}

	
	public void PAWspU191w(string P_0)
	{
		Singleton<全局变量类>.I.活跃度配置 = JsonConvert.DeserializeObject<活跃度配置类>(P_0);
		JJvs3nRZte();
	}

	
	public void vZ6s1m47eu()
	{
		is0sZDaIcf = Singleton<WdAPI>.I.组包假NPC站街(Singleton<全局变量类>.I.指定会员配置.NPC数据, 105);
	}

	
	internal void B89sxUWGsQ(MyNATSocketClient P_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("我乃是从仙界下界而来的仙子，前来帮助诸位道友在修仙之路上更快成就修仙大道！#r");
			if (Singleton<全局变量类>.I.指定会员配置.功能开关)
			{
				if (P_0.user.缓存数据.Is指定会员)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(20, 1, stringBuilder2);
					handler.AppendLiteral("#Y欢迎尊贵的#B#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.指定称号);
					handler.AppendLiteral("#n#Y道友：#r");
					stringBuilder3.Append(ref handler);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
					handler.AppendLiteral("#Y专属地图：#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.指定地图);
					handler.AppendLiteral("#n#r");
					stringBuilder4.Append(ref handler);
					if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.指定会员配置.每日领取))
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder5 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
						handler.AppendLiteral("#Y每日福利：#G");
						handler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.每日领取);
						handler.AppendLiteral("(");
						handler.AppendFormatted(P_0.user.存档数据.is指定会员每日奖励 ? "已领取" : "未领取");
						handler.AppendLiteral(")#n#r");
						stringBuilder5.Append(ref handler);
					}
					bool flag = (int)Singleton<ByteAPI>.I.取时间戳() - P_0.user.存档数据.每周分红领取时间 < 604800;
					if (Singleton<全局变量类>.I.指定会员配置.每周最低分红 > 0)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder6 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(20, 2, stringBuilder2);
						handler.AppendLiteral("#Y每周分红：最低#G");
						handler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.每周最低分红);
						handler.AppendLiteral("银元宝#Y(");
						handler.AppendFormatted(flag ? "已领取" : "未领取");
						handler.AppendLiteral(")#r");
						stringBuilder6.Append(ref handler);
					}
					if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.指定会员配置.每日领取) && !P_0.user.存档数据.is指定会员每日奖励)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder7 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(20, 1, stringBuilder2);
						handler.AppendLiteral("[【领取】");
						handler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.每日领取);
						handler.AppendLiteral("/指定会员操作_领取每日奖励]");
						stringBuilder7.Append(ref handler);
					}
					if (!flag)
					{
						stringBuilder.Append("[【领取】每周分红/指定会员操作_领取每周分红]");
					}
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(9, 2, stringBuilder2);
					handler.AppendLiteral("[【传送】");
					handler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.指定地图);
					handler.AppendLiteral("/前往");
					handler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.指定地图);
					handler.AppendLiteral("]");
					stringBuilder8.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder9 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
					handler.AppendLiteral("#R你暂未成为");
					handler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.指定称号);
					handler.AppendLiteral("，无法获得以下权利：#r");
					stringBuilder9.Append(ref handler);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder10 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
					handler.AppendLiteral("#Y专属地图：#D");
					handler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.指定地图);
					handler.AppendLiteral("#n#r");
					stringBuilder10.Append(ref handler);
					if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.指定会员配置.每日领取))
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder11 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
						handler.AppendLiteral("#Y每日福利：#D");
						handler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.每日领取);
						handler.AppendLiteral("#n#r");
						stringBuilder11.Append(ref handler);
					}
					if (Singleton<全局变量类>.I.指定会员配置.每周最低分红 > 0)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder12 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder2);
						handler.AppendLiteral("#Y每周分红：#D");
						handler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.每周最低分红);
						handler.AppendLiteral("银元宝#r");
						stringBuilder12.Append(ref handler);
					}
				}
			}
			if (Singleton<全局变量类>.I.道行达标配置.功能开关 && Singleton<全局变量类>.I.道行达标配置.道行达标奖励列表.Count > 0)
			{
				stringBuilder.Append("[【领取】道行达标奖励/指定会员操作_领取道行奖励]");
			}
			if (Singleton<全局变量类>.I.时装坐姿染色配置.坐姿染色开关)
			{
				stringBuilder.Append("[【染色】坐姿染色功能/指定会员操作_坐姿染色]");
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.指定会员配置.NPC数据.npcid, Singleton<全局变量类>.I.指定会员配置.NPC数据.npc形象, Singleton<全局变量类>.I.指定会员配置.NPC数据.npc名字, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("NPC对话生成-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void IX8sHwNB3t(MyNATSocketClient P_0, int P_1)
	{
		try
		{
			if (!Singleton<全局变量类>.I.活跃度配置.功能开关 || (!Singleton<全局变量类>.I.活跃度配置.is普通玩家可领取 && !P_0.user.缓存数据.Is指定会员) || P_1 < 1 || P_1 > 6 || P_0.user.存档数据.指定活跃奖励领取[P_1 - 1])
			{
				return;
			}
			if (P_0.user.缓存数据.活跃值 < P_1 * 50)
			{
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你当前的活跃度没有达到");
				defaultInterpolatedStringHandler.AppendFormatted(P_1 * 50);
				defaultInterpolatedStringHandler.AppendLiteral("点，无法领取活跃奖励！");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			活跃度奖励配置类 活跃度奖励配置类2 = null;
			if (P_1 * 50 == 50)
			{
				活跃度奖励配置类2 = Singleton<全局变量类>.I.活跃度配置.活跃度50奖励;
			}
			if (P_1 * 50 == 100)
			{
				活跃度奖励配置类2 = Singleton<全局变量类>.I.活跃度配置.活跃度100奖励;
			}
			if (P_1 * 50 == 150)
			{
				活跃度奖励配置类2 = Singleton<全局变量类>.I.活跃度配置.活跃度150奖励;
			}
			if (P_1 * 50 == 200)
			{
				活跃度奖励配置类2 = Singleton<全局变量类>.I.活跃度配置.活跃度200奖励;
			}
			if (P_1 * 50 == 250)
			{
				活跃度奖励配置类2 = Singleton<全局变量类>.I.活跃度配置.活跃度250奖励;
			}
			if (P_1 * 50 == 300)
			{
				活跃度奖励配置类2 = Singleton<全局变量类>.I.活跃度配置.活跃度300奖励;
			}
			if (活跃度奖励配置类2 == null)
			{
				return;
			}
			P_0.user.存档数据.指定活跃奖励领取[P_1 - 1] = true;
			if ((活跃度奖励配置类2.奖金元宝 != 0 || 活跃度奖励配置类2.奖银元宝 != 0) && DB.I.cAJNoOkab6(P_0, 活跃度奖励配置类2.奖金元宝, 活跃度奖励配置类2.奖银元宝))
			{
				string text = "你领取了活跃宝箱的奖励，额外获得了";
				string text2;
				if (活跃度奖励配置类2.奖金元宝 == 0)
				{
					text2 = string.Empty;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#Y");
					defaultInterpolatedStringHandler.AppendFormatted(活跃度奖励配置类2.奖金元宝);
					defaultInterpolatedStringHandler.AppendLiteral("#n金元宝");
					defaultInterpolatedStringHandler.AppendFormatted((活跃度奖励配置类2.奖银元宝 != 0) ? "、" : "。");
					text2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				string text3;
				if (活跃度奖励配置类2.奖银元宝 == 0)
				{
					text3 = string.Empty;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#Y");
					defaultInterpolatedStringHandler.AppendFormatted(活跃度奖励配置类2.奖银元宝);
					defaultInterpolatedStringHandler.AppendLiteral("#n银元宝。");
					text3 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				string 提示内容 = text + text2 + text3;
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(提示内容));
			}
			if (活跃度奖励配置类2.奖累充点 > 0)
			{
				WdAPI i2 = Singleton<WdAPI>.I;
				string empty = string.Empty;
				int 奖累充点 = 活跃度奖励配置类2.奖累充点;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("第");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("阶段活跃奖励领取");
				i2.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, empty, AllEnums.指令Type.无, 奖累充点, false, defaultInterpolatedStringHandler.ToStringAndClear());
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你领取了活跃宝箱的奖励，额外获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(活跃度奖励配置类2.奖累充点);
				defaultInterpolatedStringHandler.AppendLiteral("#n累充点。");
				string 提示内容2 = defaultInterpolatedStringHandler.ToStringAndClear();
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(提示内容2));
			}
			if (活跃度奖励配置类2.奖南极点 > 0)
			{
				WdAPI i3 = Singleton<WdAPI>.I;
				string empty2 = string.Empty;
				int 奖南极点 = 活跃度奖励配置类2.奖南极点;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("第");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("阶段活跃奖励领取");
				i3.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, empty2, AllEnums.指令Type.无, 奖南极点, false, defaultInterpolatedStringHandler.ToStringAndClear());
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你领取了活跃宝箱的奖励，额外获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(活跃度奖励配置类2.奖南极点);
				defaultInterpolatedStringHandler.AppendLiteral("#n南极点。");
				string 提示内容3 = defaultInterpolatedStringHandler.ToStringAndClear();
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(提示内容3));
			}
			if (!string.IsNullOrWhiteSpace(活跃度奖励配置类2.奖励道具))
			{
				WdAPI i4 = Singleton<WdAPI>.I;
				string 奖励道具 = 活跃度奖励配置类2.奖励道具;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("第");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("阶段活跃奖励领取");
				i4.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 奖励道具, AllEnums.指令Type.无, 1, false, defaultInterpolatedStringHandler.ToStringAndClear());
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你领取了活跃宝箱的奖励，额外获得了1个#Y" + 活跃度奖励配置类2.奖励道具 + "#n。"));
			}
		}
		catch (Exception ex)
		{
			Log.Error("领取活跃度奖励-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void fVhs4gkhlN(MyNATSocketClient P_0)
	{
		try
		{
			if (Singleton<全局变量类>.I.指定会员配置.每周最低分红 <= 0)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (Singleton<全局变量类>.I.指定会员配置.分红比例 <= 0)
			{
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[@确定/指定会员操作_确定领取分红");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.每周最低分红);
				defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:本周可领取的福利分红为#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.每周最低分红);
				defaultInterpolatedStringHandler.AppendLiteral("#n银元宝，你确定要现在领取分红吗？）]");
				P_0.C_Send(i.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			int num = 0;
			int num2 = (int)Singleton<ByteAPI>.I.取时间戳();
			foreach (角色存档数据类 value2 in Singleton<全局变量类>.I.角色存档表.Values)
			{
				if (value2.指定会员到期时间戳 >= num2)
				{
					num++;
				}
			}
			int value = Singleton<全局变量类>.I.指定会员配置.每周最低分红 + (int)((double)(Singleton<全局变量类>.I.指定会员配置.分红比例 * (num - 1)) / 100.0 * (double)Singleton<全局变量类>.I.指定会员配置.每周最低分红);
			WdAPI i2 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(85, 4);
			defaultInterpolatedStringHandler.AppendLiteral("[@确定/指定会员操作_确定领取分红");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:当前全服#Y");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.指定称号);
			defaultInterpolatedStringHandler.AppendLiteral("#n人数为：#R");
			defaultInterpolatedStringHandler.AppendFormatted(num);
			defaultInterpolatedStringHandler.AppendLiteral("人#n，#r本周可领取的福利分红为#Y");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("#n银元宝，你确定要现在领取分红吗？）]");
			P_0.C_Send(i2.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
		}
		catch (Exception ex)
		{
			Log.Error("领取特权分红奖励-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void UtXseqbdnV(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (Singleton<全局变量类>.I.指定会员配置.功能开关 && P_0.user.缓存数据.Is指定会员)
			{
				if (P_1 == "指定会员操作_领取每日奖励")
				{
					if (P_0.user.存档数据.is指定会员每日奖励)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你已经领取过今日的#Y" + Singleton<全局变量类>.I.指定会员配置.指定称号 + "#n奖励，请勿重复点击！！！"));
						return;
					}
					P_0.user.存档数据.is指定会员每日奖励 = true;
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.指定会员配置.每日领取, AllEnums.指令Type.无, 1, false, "指定会员每日领取");
					return;
				}
				if (P_1 == "指定会员操作_领取每周分红")
				{
					if ((int)Singleton<ByteAPI>.I.取时间戳() - P_0.user.存档数据.每周分红领取时间 < 604800)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你已经领取过特权分红，请不要重复点击，否则会导致数据异常。"));
					}
					else
					{
						fVhs4gkhlN(P_0);
					}
					return;
				}
				if (P_1.Contains("指定会员操作_确定领取分红", StringComparison.CurrentCulture))
				{
					int result;
					if ((int)Singleton<ByteAPI>.I.取时间戳() - P_0.user.存档数据.每周分红领取时间 < 604800)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你已经领取过特权分红，请不要重复点击，否则会导致数据异常。"));
						Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
					}
					else if (int.TryParse(P_1.Replace("指定会员操作_确定领取分红", ""), out result) && result > 0)
					{
						P_0.user.存档数据.每周分红领取时间 = (int)Singleton<ByteAPI>.I.取时间戳();
						if (DB.I.cAJNoOkab6(P_0, 0, result))
						{
							WdAPI i = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
							defaultInterpolatedStringHandler.AppendLiteral("尊贵的#Y");
							defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.指定称号);
							defaultInterpolatedStringHandler.AppendLiteral("#n道友，恭喜你领取了本周分红的#Y");
							defaultInterpolatedStringHandler.AppendFormatted(result);
							defaultInterpolatedStringHandler.AppendLiteral("#n银元宝福利！");
							P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						}
					}
					return;
				}
			}
			if (P_1.Contains("指定会员操作_领取道行奖励", StringComparison.CurrentCulture))
			{
				wMcsqhYEej(P_0, P_1.Replace("指定会员操作_领取道行奖励", ""));
			}
			else
			{
				if (!Singleton<全局变量类>.I.时装坐姿染色配置.坐姿染色开关)
				{
					return;
				}
				if (P_1 == "指定会员操作_坐姿染色")
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					int npcid = Singleton<全局变量类>.I.指定会员配置.NPC数据.npcid;
					int npc形象 = Singleton<全局变量类>.I.指定会员配置.NPC数据.npc形象;
					string npc名字 = Singleton<全局变量类>.I.指定会员配置.NPC数据.npc名字;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(85, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#G当前拥有凤仙花数量：#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.凤仙花数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n朵#r当前坐姿染色数据：");
					defaultInterpolatedStringHandler.AppendFormatted((!string.IsNullOrWhiteSpace(P_0.user.存档数据.染色数据.染色名称)) ? ("#Y" + P_0.user.存档数据.染色数据.染色名称 + "#n") : "无");
					defaultInterpolatedStringHandler.AppendLiteral("[我要染乘骑时坐姿的颜色/指定会员操作_开始染色][我要清除坐姿染色数据（消耗");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.时装坐姿染色配置.染色消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("朵凤仙花）/指定会员操作_数据清除]");
					P_0.C_Send(i2.对话生成_NPC(npcid, npc形象, npc名字, defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				else if (P_1 == "指定会员操作_开始染色")
				{
					if (P_0.user.缓存数据.当前乘骑坐骑id == 0)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前没有#R乘骑#n坐骑，无法进行坐姿染色操作！"));
						return;
					}
					StringBuilder stringBuilder = new StringBuilder();
					if (string.IsNullOrWhiteSpace(P_0.user.存档数据.染色数据.原坐姿ID))
					{
						stringBuilder.Append("当前并无坐姿染色数据，你可以选择下方的坐姿颜色进行染色，给自己的坐姿换个颜色吧。");
					}
					else
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder3 = stringBuilder2;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(59, 1, stringBuilder2);
						handler.AppendLiteral("当前坐姿染色数据：#Y");
						handler.AppendFormatted(P_0.user.存档数据.染色数据.染色名称);
						handler.AppendLiteral("#n，进行其他颜色的染色操作会更新当前已有的坐姿染色，你确定要继续选择其他的坐姿颜色进行染色吗？");
						stringBuilder3.Append(ref handler);
					}
					if (Singleton<全局变量类>.I.时装坐姿染色配置.染色坐姿列表.TryGetValue(P_0.user.缓存数据.当前原坐姿id, out List<染色坐姿数据列表类> value))
					{
						for (int j = 0; j < value.Count; j++)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder4 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 4, stringBuilder2);
							handler.AppendLiteral("[");
							handler.AppendFormatted(value[j].染色名称);
							handler.AppendLiteral("（消耗");
							handler.AppendFormatted(Singleton<全局变量类>.I.时装坐姿染色配置.染色消耗数量);
							handler.AppendLiteral("朵凤仙花）/指定会员操作_确定染色");
							handler.AppendFormatted(value[j].原坐姿ID);
							handler.AppendLiteral("|");
							handler.AppendFormatted(value[j].染后坐姿ID);
							handler.AppendLiteral("]");
							stringBuilder4.Append(ref handler);
						}
					}
					P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.指定会员配置.NPC数据.npcid, Singleton<全局变量类>.I.指定会员配置.NPC数据.npc形象, Singleton<全局变量类>.I.指定会员配置.NPC数据.npc名字, stringBuilder.ToString()));
				}
				else if (P_1.Contains("指定会员操作_确定染色", StringComparison.CurrentCulture))
				{
					_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass17_0();
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.存档数据.凤仙花数量 < Singleton<全局变量类>.I.时装坐姿染色配置.染色消耗数量)
					{
						WdAPI i3 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你当前拥有的#Y凤仙花#n数量不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.时装坐姿染色配置.染色消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n朵，无法进行坐姿染色操作！");
						P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					CS_0024_003C_003E8__locals4.PhdcuxmIMC = P_1.Replace("指定会员操作_确定染色", "").Split("|");
					if (CS_0024_003C_003E8__locals4.PhdcuxmIMC.Length != 2)
					{
						return;
					}
					if (!Singleton<全局变量类>.I.时装坐姿染色配置.染色坐姿列表.TryGetValue(CS_0024_003C_003E8__locals4.PhdcuxmIMC[0], out List<染色坐姿数据列表类> value2))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前染色数据有误，无法进行坐姿染色操作！"));
						return;
					}
					染色坐姿数据列表类 染色坐姿数据列表类2 = value2.Find( (染色坐姿数据列表类 a) => a.染后坐姿ID == CS_0024_003C_003E8__locals4.PhdcuxmIMC[1]);
					if (染色坐姿数据列表类2 == null)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前选择的染色数据有误，无法进行坐姿染色操作！"));
						return;
					}
					P_0.user.存档数据.凤仙花数量 -= Singleton<全局变量类>.I.时装坐姿染色配置.染色消耗数量;
					P_0.user.存档数据.染色数据.原坐姿ID = 染色坐姿数据列表类2.原坐姿ID;
					P_0.user.存档数据.染色数据.染色名称 = 染色坐姿数据列表类2.染色名称;
					P_0.user.存档数据.染色数据.染后坐姿ID = 染色坐姿数据列表类2.染后坐姿ID;
					WdAPI i4 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你花费了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.时装坐姿染色配置.染色消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n朵#Y凤仙花#n成功进行了一次坐姿染色。");
					P_0.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					P_0.C_Send(Singleton<L1ya6XBSPGoekkP8WeX>.I.lqTBhgvsWt(P_0, P_0.user.缓存数据.自身显示封包备份));
				}
				else if (P_1 == "指定会员操作_数据清除")
				{
					if (P_0.user.存档数据.凤仙花数量 < Singleton<全局变量类>.I.时装坐姿染色配置.染色消耗数量)
					{
						WdAPI i5 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你当前拥有的#Y凤仙花#n数量不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.时装坐姿染色配置.染色消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n朵，无法进行清除坐姿染色操作！");
						P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					else
					{
						P_0.user.存档数据.凤仙花数量 -= Singleton<全局变量类>.I.时装坐姿染色配置.染色消耗数量;
						P_0.user.存档数据.染色数据.原坐姿ID = string.Empty;
						P_0.user.存档数据.染色数据.染色名称 = string.Empty;
						P_0.user.存档数据.染色数据.染后坐姿ID = string.Empty;
						WdAPI i6 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你花费了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.时装坐姿染色配置.染色消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n朵#Y凤仙花#n成功清除了坐姿的染色数据");
						P_0.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						P_0.C_Send(Singleton<L1ya6XBSPGoekkP8WeX>.I.lqTBhgvsWt(P_0, P_0.user.缓存数据.自身显示封包备份));
					}
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("指定会员对话事件处理报错：" + ex.Message);
		}
	}

	
	private void wMcsqhYEej(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass18_0();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 2);
		defaultInterpolatedStringHandler.AppendLiteral("我亲爱的#Y");
		defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
		defaultInterpolatedStringHandler.AppendLiteral("#n的道友，当道行达到一定标准后，可在我这里领取相应的道行奖励！#r#Y当前道行：#G");
		defaultInterpolatedStringHandler.AppendFormatted(P_0.user.属性数据.道行 / 360);
		defaultInterpolatedStringHandler.AppendLiteral("年");
		StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
		if (string.IsNullOrWhiteSpace(P_1))
		{
			foreach (道行达标奖励配置类 item in Singleton<全局变量类>.I.道行达标配置.道行达标奖励列表)
			{
				string 道行奖励领取阶段 = P_0.user.存档数据.道行奖励领取阶段;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(item.最低道行);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				if (!道行奖励领取阶段.Contains(defaultInterpolatedStringHandler.ToStringAndClear(), StringComparison.CurrentCulture))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(27, 3, stringBuilder2);
					handler.AppendLiteral("[【领取】");
					handler.AppendFormatted(item.最低道行);
					handler.AppendLiteral("年道行奖励（");
					handler.AppendFormatted(item.奖励道具);
					handler.AppendLiteral("）/指定会员操作_领取道行奖励");
					handler.AppendFormatted(item.最低道行);
					handler.AppendLiteral("]");
					stringBuilder2.Append(ref handler);
				}
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(105, Singleton<全局变量类>.I.指定会员配置.NPC数据.npc形象, Singleton<全局变量类>.I.指定会员配置.NPC数据.npc名字, stringBuilder.ToString()));
		}
		else
		{
			if (!int.TryParse(P_1, out CS_0024_003C_003E8__locals8.NQUcbJkihA))
			{
				return;
			}
			道行达标奖励配置类 道行达标奖励配置类2 = Singleton<全局变量类>.I.道行达标配置.道行达标奖励列表.Find( (道行达标奖励配置类 a) => a.最低道行 == CS_0024_003C_003E8__locals8.NQUcbJkihA);
			if (道行达标奖励配置类2 == null || string.IsNullOrWhiteSpace(道行达标奖励配置类2.奖励道具))
			{
				return;
			}
			if (P_0.user.属性数据.道行 < CS_0024_003C_003E8__locals8.NQUcbJkihA * 360)
			{
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你当前的道行不足#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals8.NQUcbJkihA);
				defaultInterpolatedStringHandler.AppendLiteral("#n年无法领取奖励！");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			string 道行奖励领取阶段2 = P_0.user.存档数据.道行奖励领取阶段;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals8.NQUcbJkihA);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			if (道行奖励领取阶段2.Contains(defaultInterpolatedStringHandler.ToStringAndClear(), StringComparison.CurrentCulture))
			{
				WdAPI i2 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你已经领取过#Y");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals8.NQUcbJkihA);
				defaultInterpolatedStringHandler.AppendLiteral("#n年道行的奖励，请勿重复领取！！！");
				P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			P_0.user.存档数据.道行奖励领取阶段 = (string.IsNullOrWhiteSpace(P_0.user.存档数据.道行奖励领取阶段) ? "|" : P_0.user.存档数据.道行奖励领取阶段);
			角色存档数据类 存档数据 = P_0.user.存档数据;
			存档数据.道行奖励领取阶段 = 存档数据.道行奖励领取阶段 + CS_0024_003C_003E8__locals8.NQUcbJkihA + "|";
			if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 道行达标奖励配置类2.奖励道具, AllEnums.指令Type.无, 1, false, "领取道行达标奖励"))
			{
				WdAPI i3 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你，成功领取了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals8.NQUcbJkihA);
				defaultInterpolatedStringHandler.AppendLiteral("#n年道行奖励的#Y");
				defaultInterpolatedStringHandler.AppendFormatted(道行达标奖励配置类2.奖励道具);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}
	}

	
	internal void C61srHS1Yx(MyNATSocketClient P_0)
	{
		try
		{
			if (!Singleton<全局变量类>.I.所有地图字典.TryGetValue(Singleton<全局变量类>.I.指定会员配置.指定地图, out var value))
			{
				return;
			}
			if (P_0.user.队伍数据.成员列表.Count > 0)
			{
				foreach (int item in P_0.user.队伍数据.成员列表)
				{
					MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定角色ID玩家MyClient(item);
					if (myNATSocketClient == null)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("队伍有成员暂未在线，无法进入#Y" + Singleton<全局变量类>.I.指定会员配置.指定地图 + "#n！"));
						return;
					}
					if (!myNATSocketClient.user.缓存数据.Is指定会员)
					{
						WdAPI i = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n并未拥有#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.指定称号);
						defaultInterpolatedStringHandler.AppendLiteral("#n称号，无法进入#Y");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.指定地图);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
				}
			}
			else if (!P_0.user.缓存数据.Is指定会员)
			{
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你并未拥有#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.指定称号);
				defaultInterpolatedStringHandler.AppendLiteral("#n称号，无法进入#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.指定地图);
				defaultInterpolatedStringHandler.AppendLiteral("#n！");
				P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			Singleton<WdAPI>.I.地图传送事件(P_0, value);
		}
		catch (Exception ex)
		{
			Log.Error("传送特权地图事件报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public L4IbybsayJA7RG5d8t7()
	{
	}

	
	static L4IbybsayJA7RG5d8t7()
	{
		is0sZDaIcf = Array.Empty<byte>();
	}
}
