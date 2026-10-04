using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace UQuLZEj71kRGhQn6jmQ;

internal class fFv8GpjvE2cusnNqivq : Singleton<fFv8GpjvE2cusnNqivq>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public int w2PM7bviMP;

		
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		
		internal bool GdGMvogleB(宠物缓存数据类 a)
		{
			return a.宠物ID == w2PM7bviMP;
		}

		static _003C_003Ec__DisplayClass5_0()
		{
		}
	}

	
	internal void hssjaBeD11()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("道具宠物回收配置类.json")))
			{
				Singleton<全局变量类>.I.道具宠物回收配置 = JsonConvert.DeserializeObject<道具宠物回收配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("道具宠物回收配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.道具宠物回收配置 = new 道具宠物回收配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("道具宠物回收配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.道具宠物回收配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("道具宠物回收配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void HPmjTQ6Mjj()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("道具宠物回收配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.道具宠物回收配置, Formatting.Indented));
			Log.Debug("道具宠物回收配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("道具宠物回收配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string VZ2j9tqxiw()
	{
		hssjaBeD11();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.道具宠物回收配置, Formatting.Indented);
	}

	
	public void mPdjyWF3yY(string P_0)
	{
		Singleton<全局变量类>.I.道具宠物回收配置 = JsonConvert.DeserializeObject<道具宠物回收配置类>(P_0);
		HPmjTQ6Mjj();
	}

	
	internal void nZJjCGoMSO(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			string text = Singleton<ByteAPI>.I.到文本(P_1);
			int result = 0;
			string text2 = string.Empty;
			if (Singleton<ByteAPI>.I.寻找文本与(text, "你卖出了", "#n，得到"))
			{
				text = Singleton<ByteAPI>.I.文本_取出中间文本(text, "你卖出了", "#n，得到");
				string[] array = text.Split("#R");
				if (array.Length != 2)
				{
					return;
				}
				text = array[0].Substring(0, array[0].Length - 1);
				if (!int.TryParse(text, out result))
				{
					return;
				}
				text2 = array[1];
			}
			else if (Singleton<ByteAPI>.I.寻找文本与(text, "你捐赠了", "#R", "#n。"))
			{
				text = Singleton<ByteAPI>.I.文本_取出中间文本(text, "你捐赠了", "#n。");
				string[] array2 = text.Split("#R");
				if (array2.Length != 2)
				{
					return;
				}
				string text3 = array2[0];
				text = text3.Substring(0, text3.Length - 1);
				if (!int.TryParse(text, out result))
				{
					return;
				}
				text2 = array2[1];
			}
			if (result == 0 || string.IsNullOrWhiteSpace(text2) || !Singleton<全局变量类>.I.道具宠物回收配置.回收列表.TryGetValue(text2, out 道宠回收数据类 value) || !value.Is道具)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
			defaultInterpolatedStringHandler.AppendLiteral("你回收了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(result);
			defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
			defaultInterpolatedStringHandler.AppendFormatted(text2);
			defaultInterpolatedStringHandler.AppendLiteral("#n，获得以下奖励：");
			StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
			if ((value.金元宝 > 0 || value.银元宝 > 0) && DB.I.cAJNoOkab6(P_0, value.金元宝 * result, value.银元宝 * result))
			{
				if (value.金元宝 > 0)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder2);
					handler.AppendLiteral("#Y金元宝×");
					handler.AppendFormatted(value.金元宝 * result);
					handler.AppendLiteral("#n  ");
					stringBuilder3.Append(ref handler);
				}
				if (value.银元宝 > 0)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder2);
					handler.AppendLiteral("#Y银元宝×");
					handler.AppendFormatted(value.银元宝 * result);
					handler.AppendLiteral("#n  ");
					stringBuilder4.Append(ref handler);
				}
			}
			int num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
			if (value.累充点 > 0 && value.累充点几率 >= num)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, value.累充点 * result, false, "回收" + text2 + "获得");
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
				handler.AppendLiteral("#Y累充点×");
				handler.AppendFormatted(value.累充点 * result);
				handler.AppendLiteral("#n ");
				stringBuilder5.Append(ref handler);
			}
			num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
			if (value.南极点 > 0 && value.南极点几率 >= num)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, value.南极点 * result, false, "回收" + text2 + "获得");
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder6 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
				handler.AppendLiteral("#Y南极点×");
				handler.AppendFormatted(value.南极点 * result);
				handler.AppendLiteral("#n");
				stringBuilder6.Append(ref handler);
			}
			num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
			if (value.奇宝点 > 0 && value.奇宝点几率 >= num)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, value.奇宝点 * result, false, "[回收" + text2 + "]获得");
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder7 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
				handler.AppendLiteral("#Y奇宝点×");
				handler.AppendFormatted(value.奇宝点 * result);
				handler.AppendLiteral("#n");
				stringBuilder7.Append(ref handler);
			}
			num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
			if (value.游戏币 > 0 && value.游戏币几率 >= num)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, value.游戏币 * result, false, "[回收" + text2 + "]获得");
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder8 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(7, 1, stringBuilder2);
				handler.AppendLiteral("#Y金钱×");
				handler.AppendFormatted(value.游戏币 * result);
				handler.AppendLiteral("#n");
				stringBuilder8.Append(ref handler);
			}
			num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
			if (value.灵气值 > 0 && value.灵气值几率 >= num)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, value.灵气值 * result, false, "[回收" + text2 + "]获得");
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder9 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
				handler.AppendLiteral("#Y灵气值×");
				handler.AppendFormatted(value.灵气值 * result);
				handler.AppendLiteral("#n");
				stringBuilder9.Append(ref handler);
			}
			num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
			if (!string.IsNullOrWhiteSpace(value.奖励道具) && value.奖励道具最低数量 > 0 && value.奖励道具最高数量 >= value.奖励道具最低数量 && value.奖励道具几率 >= num)
			{
				num = Singleton<WdAPI>.I.qrjo9TWIdy(value.奖励道具最低数量 * result, value.奖励道具最高数量 * result);
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, value.奖励道具, AllEnums.指令Type.无, num, false, "[回收" + text2 + "]获得");
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder10 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(value.奖励道具);
				handler.AppendLiteral("×");
				handler.AppendFormatted(num);
				handler.AppendLiteral("#n");
				stringBuilder10.Append(ref handler);
			}
			P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("道具回收校验-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void grdjVchuUV(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass5_0();
			if (!Singleton<全局变量类>.I.道具宠物回收配置.is宠物回收)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			string text = P_1.Replace("宠物操作_宠物回收", "");
			if (string.IsNullOrWhiteSpace(text))
			{
				bool flag = true;
				stringBuilder.Append("#Y下列是可以回收的宠物，请选择你想要回收的宠物：#n");
				for (int i = 0; i < P_0.user.宠物数据.Length; i++)
				{
					if (P_0.user.宠物数据[i].PetID == 0 || !Singleton<全局变量类>.I.道具宠物回收配置.回收列表.TryGetValue(P_0.user.宠物数据[i].昵称B, out 道宠回收数据类 value))
					{
						continue;
					}
					if (value.Is道具)
					{
						return;
					}
					if ((P_0.user.宠物数据[i].绑定状态 == AllEnums.绑定Type.不绑定 || !Singleton<全局变量类>.I.道具宠物回收配置.is禁止绑定宠物回收) && !(P_0.user.宠物数据[i].昵称A != P_0.user.宠物数据[i].昵称B) && P_0.user.缓存数据.当前乘骑坐骑id != P_0.user.宠物数据[i].宠物ID && P_0.user.缓存数据.当前参战宠物id != P_0.user.宠物数据[i].宠物ID && P_0.user.缓存数据.当前掠阵宠物id != P_0.user.宠物数据[i].宠物ID && (value.金元宝 > 0 || value.银元宝 > 0 || value.累充点 > 0 || value.累充点几率 > 0 || value.南极点 > 0 || value.南极点几率 > 0 || value.奇宝点 > 0 || value.奇宝点几率 > 0 || value.游戏币 > 0 || value.游戏币几率 > 0 || value.灵气值 > 0 || value.灵气值几率 > 0 || (!string.IsNullOrWhiteSpace(value.奖励道具) && value.奖励道具几率 > 0)))
					{
						flag = false;
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder3 = stringBuilder2;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(18, 11, stringBuilder2);
						handler.AppendLiteral("[");
						handler.AppendFormatted(P_0.user.宠物数据[i].昵称A);
						handler.AppendLiteral("·");
						handler.AppendFormatted(P_0.user.宠物数据[i].等级);
						handler.AppendLiteral("级(回收");
						handler.AppendFormatted((value.金元宝 > 0) ? ("金元宝×" + value.金元宝) : string.Empty);
						handler.AppendFormatted((value.银元宝 > 0) ? ("银元宝×" + value.银元宝) : string.Empty);
						string value2;
						if (value.累充点 <= 0)
						{
							value2 = string.Empty;
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
							defaultInterpolatedStringHandler.AppendLiteral("累充点×");
							defaultInterpolatedStringHandler.AppendFormatted(value.累充点);
							defaultInterpolatedStringHandler.AppendLiteral("(");
							defaultInterpolatedStringHandler.AppendFormatted(value.累充点几率);
							defaultInterpolatedStringHandler.AppendLiteral("%)");
							value2 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						handler.AppendFormatted(value2);
						string value3;
						if (value.南极点 <= 0)
						{
							value3 = string.Empty;
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
							defaultInterpolatedStringHandler.AppendLiteral("南极点×");
							defaultInterpolatedStringHandler.AppendFormatted(value.南极点);
							defaultInterpolatedStringHandler.AppendLiteral("(");
							defaultInterpolatedStringHandler.AppendFormatted(value.南极点几率);
							defaultInterpolatedStringHandler.AppendLiteral("%)");
							value3 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						handler.AppendFormatted(value3);
						string value4;
						if (value.奇宝点 <= 0)
						{
							value4 = string.Empty;
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
							defaultInterpolatedStringHandler.AppendLiteral("奇宝点×");
							defaultInterpolatedStringHandler.AppendFormatted(value.奇宝点);
							defaultInterpolatedStringHandler.AppendLiteral("(");
							defaultInterpolatedStringHandler.AppendFormatted(value.奇宝点几率);
							defaultInterpolatedStringHandler.AppendLiteral("%)");
							value4 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						handler.AppendFormatted(value4);
						string value5;
						if (value.游戏币 <= 0)
						{
							value5 = string.Empty;
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
							defaultInterpolatedStringHandler.AppendLiteral("游戏币×");
							defaultInterpolatedStringHandler.AppendFormatted(value.游戏币);
							defaultInterpolatedStringHandler.AppendLiteral("(");
							defaultInterpolatedStringHandler.AppendFormatted(value.游戏币几率);
							defaultInterpolatedStringHandler.AppendLiteral("%)");
							value5 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						handler.AppendFormatted(value5);
						string value6;
						if (value.灵气值 <= 0)
						{
							value6 = string.Empty;
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
							defaultInterpolatedStringHandler.AppendLiteral("灵气值×");
							defaultInterpolatedStringHandler.AppendFormatted(value.灵气值);
							defaultInterpolatedStringHandler.AppendLiteral("(");
							defaultInterpolatedStringHandler.AppendFormatted(value.灵气值几率);
							defaultInterpolatedStringHandler.AppendLiteral("%)");
							value6 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						handler.AppendFormatted(value6);
						string value7;
						if (string.IsNullOrWhiteSpace(value.奖励道具) || value.奖励道具几率 <= 0)
						{
							value7 = string.Empty;
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 4);
							defaultInterpolatedStringHandler.AppendFormatted(value.奖励道具);
							defaultInterpolatedStringHandler.AppendLiteral("×");
							defaultInterpolatedStringHandler.AppendFormatted(value.奖励道具最低数量);
							defaultInterpolatedStringHandler.AppendLiteral("-");
							defaultInterpolatedStringHandler.AppendFormatted(value.奖励道具最高数量);
							defaultInterpolatedStringHandler.AppendLiteral("(");
							defaultInterpolatedStringHandler.AppendFormatted(value.奖励道具几率);
							defaultInterpolatedStringHandler.AppendLiteral("%)");
							value7 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						handler.AppendFormatted(value7);
						handler.AppendLiteral(")/宠物操作_宠物回收");
						handler.AppendFormatted(P_0.user.宠物数据[i].宠物ID);
						handler.AppendLiteral("]");
						stringBuilder3.Append(ref handler);
					}
				}
				if (flag)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前并无可回收的宠物！"));
				}
				else
				{
					P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(102, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字, stringBuilder.ToString()));
				}
			}
			else
			{
				if (!int.TryParse(text, out CS_0024_003C_003E8__locals6.w2PM7bviMP))
				{
					return;
				}
				宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.ToList().Find( (宠物缓存数据类 a) => a.宠物ID == CS_0024_003C_003E8__locals6.w2PM7bviMP);
				if (宠物缓存数据类2 == null || 宠物缓存数据类2.昵称A != 宠物缓存数据类2.昵称B || !Singleton<全局变量类>.I.道具宠物回收配置.回收列表.TryGetValue(宠物缓存数据类2.昵称B, out 道宠回收数据类 value8) || value8.Is道具 || P_0.user.缓存数据.当前乘骑坐骑id == CS_0024_003C_003E8__locals6.w2PM7bviMP || P_0.user.缓存数据.当前参战宠物id == CS_0024_003C_003E8__locals6.w2PM7bviMP || P_0.user.缓存数据.当前掠阵宠物id == CS_0024_003C_003E8__locals6.w2PM7bviMP || (宠物缓存数据类2.绑定状态 != AllEnums.绑定Type.不绑定 && Singleton<全局变量类>.I.道具宠物回收配置.is禁止绑定宠物回收))
				{
					return;
				}
				P_0.S_Send(全局常量类.丢弃宠物包.Concat(Singleton<ByteAPI>.I.到字节集固定反转(CS_0024_003C_003E8__locals6.w2PM7bviMP)).ToArray());
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
				handler.AppendLiteral("回收#Y");
				handler.AppendFormatted(value8.名字);
				handler.AppendLiteral("#n宠物获得了");
				stringBuilder4.Append(ref handler);
				if ((value8.金元宝 > 0 || value8.银元宝 > 0) && DB.I.cAJNoOkab6(P_0, value8.金元宝, value8.银元宝))
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(0, 2, stringBuilder2);
					string value9;
					if (value8.金元宝 <= 0)
					{
						value9 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
						defaultInterpolatedStringHandler.AppendLiteral("#Y金元宝×");
						defaultInterpolatedStringHandler.AppendFormatted(value8.金元宝);
						defaultInterpolatedStringHandler.AppendLiteral("#n  ");
						value9 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value9);
					string value10;
					if (value8.银元宝 <= 0)
					{
						value10 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
						defaultInterpolatedStringHandler.AppendLiteral("#Y银元宝×");
						defaultInterpolatedStringHandler.AppendFormatted(value8.银元宝);
						defaultInterpolatedStringHandler.AppendLiteral("#n  ");
						value10 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value10);
					stringBuilder5.Append(ref handler);
				}
				int num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				if (value8.累充点 > 0 && value8.累充点几率 >= num)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, value8.累充点, false, "回收" + value8.名字 + "获得");
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
					handler.AppendLiteral("#Y累充点×");
					handler.AppendFormatted(value8.累充点);
					handler.AppendLiteral("#n ");
					stringBuilder6.Append(ref handler);
				}
				num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				if (value8.南极点 > 0 && value8.南极点几率 >= num)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, value8.南极点, false, "回收" + value8.名字 + "获得");
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
					handler.AppendLiteral("#Y南极点×");
					handler.AppendFormatted(value8.南极点);
					handler.AppendLiteral("#n");
					stringBuilder7.Append(ref handler);
				}
				num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				if (value8.奇宝点 > 0 && value8.奇宝点几率 >= num)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, value8.奇宝点, false, "[回收" + value8.名字 + "]获得");
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
					handler.AppendLiteral("#Y奇宝点×");
					handler.AppendFormatted(value8.奇宝点);
					handler.AppendLiteral("#n");
					stringBuilder8.Append(ref handler);
					Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件 != null)
					{
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 3);
						defaultInterpolatedStringHandler.AppendLiteral("玩家：#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n回收了#R1#n只#Y");
						defaultInterpolatedStringHandler.AppendFormatted(value8.名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(value8.奇宝点);
						defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点的奖励！");
						client频道事件(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
				}
				num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				if (value8.游戏币 > 0 && value8.游戏币几率 >= num)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, value8.游戏币, false, "[回收" + value8.名字 + "]获得");
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder9 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(7, 1, stringBuilder2);
					handler.AppendLiteral("#Y金钱×");
					handler.AppendFormatted(value8.游戏币);
					handler.AppendLiteral("#n");
					stringBuilder9.Append(ref handler);
					Action<byte[]> client频道事件2 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件2 != null)
					{
						WdAPI i3 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
						defaultInterpolatedStringHandler.AppendLiteral("玩家：#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n回收了#R1#n只#Y");
						defaultInterpolatedStringHandler.AppendFormatted(value8.名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(value8.游戏币);
						defaultInterpolatedStringHandler.AppendLiteral("#n金钱奖励！");
						client频道事件2(i3.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
				}
				num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				if (value8.灵气值 > 0 && value8.灵气值几率 >= num)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, value8.灵气值, false, "[回收" + value8.名字 + "]获得");
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder10 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
					handler.AppendLiteral("#Y灵气值×");
					handler.AppendFormatted(value8.灵气值);
					handler.AppendLiteral("#n");
					stringBuilder10.Append(ref handler);
					Action<byte[]> client频道事件3 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件3 != null)
					{
						WdAPI i4 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
						defaultInterpolatedStringHandler.AppendLiteral("玩家：#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n回收了#R1#n只#Y");
						defaultInterpolatedStringHandler.AppendFormatted(value8.名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(value8.灵气值);
						defaultInterpolatedStringHandler.AppendLiteral("#n灵气值奖励！");
						client频道事件3(i4.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
				}
				num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				if (!string.IsNullOrWhiteSpace(value8.奖励道具) && value8.奖励道具最低数量 > 0 && value8.奖励道具最高数量 >= value8.奖励道具最低数量 && value8.奖励道具几率 >= num)
				{
					num = Singleton<WdAPI>.I.qrjo9TWIdy(value8.奖励道具最低数量, value8.奖励道具最高数量);
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, value8.奖励道具, AllEnums.指令Type.无, num, false, "[回收" + value8.名字 + "]获得");
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder11 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(5, 2, stringBuilder2);
					handler.AppendLiteral("#Y");
					handler.AppendFormatted(value8.奖励道具);
					handler.AppendLiteral("×");
					handler.AppendFormatted(num);
					handler.AppendLiteral("#n");
					stringBuilder11.Append(ref handler);
				}
				P_0?.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(stringBuilder.ToString()));
			}
		}
		catch (Exception ex)
		{
			Log.Error("宠物回收事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public fFv8GpjvE2cusnNqivq()
	{
	}

	static fFv8GpjvE2cusnNqivq()
	{
	}
}
