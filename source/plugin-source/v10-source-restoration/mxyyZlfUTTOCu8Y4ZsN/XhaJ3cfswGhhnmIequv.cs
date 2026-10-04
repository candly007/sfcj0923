using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace mxyyZlfUTTOCu8Y4ZsN;

internal class XhaJ3cfswGhhnmIequv : Singleton<XhaJ3cfswGhhnmIequv>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public 日常存档类 Q7lTvJcKqR;

		public MyNATSocketClient T70T77LeLp;

		
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		
		internal bool xlQThZC9KB(日常奖励类 x)
		{
			if ((x.任务星级 == Q7lTvJcKqR.任务星级 || x.任务星级 == AllEnums.任务星级Type.通用) && x.奖励几率 > 0 && T70T77LeLp.user.属性数据.等级 >= x.奖励最低等级 && T70T77LeLp.user.属性数据.等级 <= x.奖励最高等级 && Q7lTvJcKqR.完成次数 >= x.最低完成次数 && Q7lTvJcKqR.完成次数 % x.最低完成次数 == 0 && x.奖励类型 != AllEnums.数值Type.无 && x.最低奖励数量 > 0)
			{
				return x.最高奖励数量 > 0;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass7_0()
		{
		}
	}

	
	[SpecialName]
	internal static bool vI0fNpyhWg()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is日常功能)
		{
			return Singleton<全局变量类>.I.日常配置.功能开关;
		}
		return false;
	}

	
	internal void FVUfWSHPAF()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("日常配置类.json")))
			{
				Singleton<全局变量类>.I.日常配置 = JsonConvert.DeserializeObject<日常配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("日常配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.日常配置 = new 日常配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("日常配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.日常配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("日常配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void yfQfg5lUpZ()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("日常配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.日常配置, Formatting.Indented));
			Log.Debug("日常配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("日常配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string TptfDBxime()
	{
		FVUfWSHPAF();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.日常配置, Formatting.Indented);
	}

	
	public void G6Kfjamqld(string P_0)
	{
		Singleton<全局变量类>.I.日常配置 = JsonConvert.DeserializeObject<日常配置类>(P_0);
		yfQfg5lUpZ();
	}

	
	internal async Task TR2fluO5Bi(MyNATSocketClient P_0, AllEnums.日常类型Type P_1, string P_2, string P_3)
	{
		try
		{
			if (string.IsNullOrWhiteSpace(P_3))
			{
				return;
			}
			if (!P_0.user.存档数据.日常存档.TryGetValue(P_1, out var value))
			{
				value = new 日常存档类
				{
					日常类型 = P_1,
					完成次数 = 0
				};
				P_0.user.存档数据.日常存档.TryAdd(P_1, value);
			}
			if (Singleton<ByteAPI>.I.寻找文本等(P_2, "降妖任务", "伏魔任务", "仙界通缉", "飞仙渡邪", "悬赏令", "仙人指路", "八阵图"))
			{
				if (!Enum.TryParse<AllEnums.任务星级Type>(Singleton<ByteAPI>.I.取文本中间(P_3, "当前任务模式：#R", "模式#n"), out value.任务星级))
				{
					value.任务星级 = AllEnums.任务星级Type.通用;
				}
			}
			else if (P_2.StartsWith("【昆仑神镜】"))
			{
				if (!Enum.TryParse<AllEnums.任务星级Type>(Singleton<ByteAPI>.I.取文本中间(P_3, "任务模式：", "模式"), out value.任务星级))
				{
					value.任务星级 = AllEnums.任务星级Type.通用;
				}
			}
			else if (Singleton<ByteAPI>.I.寻找文本与(P_3, "当前任务模式：#R", "星#n"))
			{
				value.任务星级 = Enum.Parse<AllEnums.任务星级Type>(Singleton<ByteAPI>.I.取文本中间(P_3, "当前任务模式：#R", "星#n") + "星");
			}
			else
			{
				value.任务星级 = AllEnums.任务星级Type.通用;
			}
			await Task.Delay(1);
		}
		catch (Exception ex)
		{
			Log.Error("日常任务处理事件-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public async Task ULvf8HlQXX(MyNATSocketClient P_0, 日常存档类 P_1, bool P_2 = false)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals49 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals49.Q7lTvJcKqR = P_1;
		CS_0024_003C_003E8__locals49.T70T77LeLp = P_0;
		try
		{
			CS_0024_003C_003E8__locals49.Q7lTvJcKqR.完成次数++;
			if (!vI0fNpyhWg() || !Singleton<全局变量类>.I.日常配置.配置详情.TryGetValue(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型, out 日常配置详情类 当前配置) || !当前配置.功能开关 || 当前配置.奖励列表.Count <= 0 || 当前配置.最多获得奖励数量 <= 0 || (当前配置.五雷无效 && P_2))
			{
				return;
			}
			while (CS_0024_003C_003E8__locals49.T70T77LeLp.user.缓存数据.is战斗中)
			{
				await Task.Delay(100);
				if (!CS_0024_003C_003E8__locals49.T70T77LeLp.user.缓存数据.is战斗中)
				{
					break;
				}
			}
			List<日常奖励类> 筛选列表 = 当前配置.奖励列表.FindAll( (日常奖励类 x) => (x.任务星级 == CS_0024_003C_003E8__locals49.Q7lTvJcKqR.任务星级 || x.任务星级 == AllEnums.任务星级Type.通用) && x.奖励几率 > 0 && CS_0024_003C_003E8__locals49.T70T77LeLp.user.属性数据.等级 >= x.奖励最低等级 && CS_0024_003C_003E8__locals49.T70T77LeLp.user.属性数据.等级 <= x.奖励最高等级 && CS_0024_003C_003E8__locals49.Q7lTvJcKqR.完成次数 >= x.最低完成次数 && CS_0024_003C_003E8__locals49.Q7lTvJcKqR.完成次数 % x.最低完成次数 == 0 && x.奖励类型 != AllEnums.数值Type.无 && x.最低奖励数量 > 0 && x.最高奖励数量 > 0);
			if (筛选列表.Count <= 0)
			{
				return;
			}
			int 已领取奖励 = 0;
			for (int i = 0; i < 筛选列表.Count; i++)
			{
				int num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				if (筛选列表[i].奖励几率 >= num)
				{
					int num2 = Singleton<WdAPI>.I.qrjo9TWIdy(筛选列表[i].最低奖励数量, 筛选列表[i].最高奖励数量);
					已领取奖励++;
					switch (筛选列表[i].奖励类型)
					{
					case AllEnums.数值Type.道行:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals49.T70T77LeLp, AllEnums.发送数据Type.数值, 筛选列表[i].奖励物品, AllEnums.指令Type.tao, num2 * 360, false, "日常奖励");
						MyNATSocketClient myNATSocketClient12 = CS_0024_003C_003E8__locals49.T70T77LeLp;
						WdAPI i13 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你在#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型);
						defaultInterpolatedStringHandler.AppendLiteral("#n活动中获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral("#n年道行。");
						myNATSocketClient12.C_Send(i13.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.经验:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals49.T70T77LeLp, AllEnums.发送数据Type.数值, 筛选列表[i].奖励物品, AllEnums.指令Type.exp, num2, false, "日常奖励");
						MyNATSocketClient myNATSocketClient11 = CS_0024_003C_003E8__locals49.T70T77LeLp;
						WdAPI i12 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你在#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型);
						defaultInterpolatedStringHandler.AppendLiteral("#n活动中获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral("#n点经验。");
						myNATSocketClient11.C_Send(i12.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.声望:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals49.T70T77LeLp, AllEnums.发送数据Type.数值, 筛选列表[i].奖励物品, AllEnums.指令Type.reputation, num2, false, "日常奖励");
						MyNATSocketClient myNATSocketClient10 = CS_0024_003C_003E8__locals49.T70T77LeLp;
						WdAPI i11 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你在#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型);
						defaultInterpolatedStringHandler.AppendLiteral("#n活动中获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral("#n点声望。");
						myNATSocketClient10.C_Send(i11.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.战绩:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals49.T70T77LeLp, AllEnums.发送数据Type.数值, 筛选列表[i].奖励物品, AllEnums.指令Type.total_score, num2, false, "日常奖励");
						MyNATSocketClient myNATSocketClient9 = CS_0024_003C_003E8__locals49.T70T77LeLp;
						WdAPI i10 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你在#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型);
						defaultInterpolatedStringHandler.AppendLiteral("#n活动中获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral("#n点战绩。");
						myNATSocketClient9.C_Send(i10.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.金元宝:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals49.T70T77LeLp, AllEnums.发送数据Type.金元宝, 筛选列表[i].奖励物品, AllEnums.指令Type.无, num2, false, "日常奖励");
						MyNATSocketClient myNATSocketClient8 = CS_0024_003C_003E8__locals49.T70T77LeLp;
						WdAPI i9 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你在#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型);
						defaultInterpolatedStringHandler.AppendLiteral("#n活动中获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral("#n个金元宝。");
						myNATSocketClient8.C_Send(i9.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.银元宝:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals49.T70T77LeLp, AllEnums.发送数据Type.银元宝, 筛选列表[i].奖励物品, AllEnums.指令Type.无, num2, false, "日常奖励");
						MyNATSocketClient myNATSocketClient7 = CS_0024_003C_003E8__locals49.T70T77LeLp;
						WdAPI i8 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你在#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型);
						defaultInterpolatedStringHandler.AppendLiteral("#n活动中获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral("#n个银元宝。");
						myNATSocketClient7.C_Send(i8.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.金钱:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals49.T70T77LeLp, AllEnums.发送数据Type.数值, 筛选列表[i].奖励物品, AllEnums.指令Type.cash, num2, false, "日常奖励");
						MyNATSocketClient myNATSocketClient6 = CS_0024_003C_003E8__locals49.T70T77LeLp;
						WdAPI i7 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你在#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型);
						defaultInterpolatedStringHandler.AppendLiteral("#n活动中获得了");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(num2));
						defaultInterpolatedStringHandler.AppendLiteral("文钱。");
						myNATSocketClient6.C_Send(i7.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.累充点:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals49.T70T77LeLp, AllEnums.发送数据Type.累充点, 筛选列表[i].奖励物品, AllEnums.指令Type.无, num2, false, "日常奖励");
						MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals49.T70T77LeLp;
						WdAPI i6 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你在#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型);
						defaultInterpolatedStringHandler.AppendLiteral("#n活动中获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral("#n累充点。");
						myNATSocketClient5.C_Send(i6.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.道具:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals49.T70T77LeLp, AllEnums.发送数据Type.道具, 筛选列表[i].奖励物品, AllEnums.指令Type.无, num2, false, "日常奖励");
						MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals49.T70T77LeLp;
						WdAPI i5 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 3);
						defaultInterpolatedStringHandler.AppendLiteral("你在#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型);
						defaultInterpolatedStringHandler.AppendLiteral("#n活动中获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
						defaultInterpolatedStringHandler.AppendFormatted(筛选列表[i].奖励物品);
						defaultInterpolatedStringHandler.AppendLiteral("#n。");
						myNATSocketClient4.C_Send(i5.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.南极点:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals49.T70T77LeLp, AllEnums.发送数据Type.南极点, 筛选列表[i].奖励物品, AllEnums.指令Type.无, num2, false, "日常奖励");
						MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals49.T70T77LeLp;
						WdAPI i4 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你在#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型);
						defaultInterpolatedStringHandler.AppendLiteral("#n活动中获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral("#n南极点。");
						myNATSocketClient3.C_Send(i4.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.奇宝点:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals49.T70T77LeLp, AllEnums.发送数据Type.奇宝点, 筛选列表[i].奖励物品, AllEnums.指令Type.无, num2, false, "日常奖励");
						MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals49.T70T77LeLp;
						WdAPI i3 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你在#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型);
						defaultInterpolatedStringHandler.AppendLiteral("#n活动中获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点。");
						myNATSocketClient2.C_Send(i3.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case AllEnums.数值Type.灵气值:
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals49.T70T77LeLp, AllEnums.发送数据Type.灵气值, 筛选列表[i].奖励物品, AllEnums.指令Type.无, num2, false, "日常奖励");
						MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals49.T70T77LeLp;
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你在#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型);
						defaultInterpolatedStringHandler.AppendLiteral("#n活动中获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral("#n灵气值。");
						myNATSocketClient.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					}
					if (筛选列表[i].触发谣言)
					{
						Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
						if (client频道事件 != null)
						{
							WdAPI i14 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 4);
							defaultInterpolatedStringHandler.AppendLiteral("恭喜！#Y");
							defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.T70T77LeLp.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n在#G【");
							defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals49.Q7lTvJcKqR.日常类型);
							defaultInterpolatedStringHandler.AppendLiteral("】#n中获得了#R");
							defaultInterpolatedStringHandler.AppendFormatted((筛选列表[i].奖励类型 == AllEnums.数值Type.道具) ? 筛选列表[i].奖励物品 : 筛选列表[i].奖励类型.ToString());
							defaultInterpolatedStringHandler.AppendLiteral("*");
							defaultInterpolatedStringHandler.AppendFormatted(num2);
							defaultInterpolatedStringHandler.AppendLiteral("#n，真是好运气啊！");
							client频道事件(i14.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
						}
					}
				}
				if (已领取奖励 >= 当前配置.最多获得奖励数量)
				{
					break;
				}
				await Task.Delay(10);
			}
		}
		catch (Exception ex)
		{
			Log.Error("触发日常奖励事件-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void cWVfIV9m1C(MyNATSocketClient P_0, ref string P_1)
	{
		try
		{
			if (Singleton<ByteAPI>.I.寻找文本(P_1, "日常_助人为乐_"))
			{
				if (P_1 == "日常_助人为乐_提交任务")
				{
					P_0.user.缓存数据.Is五雷令 = false;
				}
				if (P_1.StartsWith("日常_助人为乐_五雷令_"))
				{
					P_0.user.缓存数据.Is五雷令 = true;
					P_1 = P_1.Replace("日常_助人为乐_五雷令_", string.Empty);
					return;
				}
				if ((P_1 == "日常_助人为乐_我想领取原有奖励" || P_1 == "日常_助人为乐_确定") && P_0.user.存档数据.日常存档.TryGetValue(AllEnums.日常类型Type.助人为乐, out var value))
				{
					if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 6)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("物品栏空位不足#R6#n个，请整理包裹后再来。"));
						return;
					}
					ULvf8HlQXX(P_0, value);
				}
				P_1 = P_1.Replace("日常_助人为乐_", string.Empty);
			}
			else
			{
				if (!Singleton<ByteAPI>.I.寻找文本等(P_1, "日常_悬赏令_经验奖励", "日常_悬赏令_道行奖励"))
				{
					return;
				}
				if (P_0.user.缓存数据.任务缓存字典.ContainsKey("悬赏令") && P_0.user.存档数据.日常存档.TryGetValue(AllEnums.日常类型Type.悬赏令, out var value2))
				{
					if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 6)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("物品栏空位不足#R6#n个，请整理包裹后再来。"));
						return;
					}
					ULvf8HlQXX(P_0, value2);
				}
				P_1 = P_1.Replace("日常_悬赏令_", string.Empty);
			}
		}
		catch (Exception ex)
		{
			Log.Error("对话点击事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void uhLfomm4gK(MyNATSocketClient P_0, ref string P_1)
	{
		try
		{
			if (Singleton<ByteAPI>.I.寻找文本(P_1, "我是白邦芒"))
			{
				P_0.user.缓存数据.Is五雷令 = false;
			}
			if (!Singleton<全局变量类>.I.日常配置.配置详情.TryGetValue(AllEnums.日常类型Type.助人为乐, out 日常配置详情类 value) || !value.功能开关 || P_0.user.缓存数据.Is五雷令)
			{
				return;
			}
			if (Singleton<ByteAPI>.I.寻找文本与(P_1, "/领取助人为乐(", "[【提交任务】任务我已经完成了/提交任务]"))
			{
				P_1 = P_1.Replace("[【提交任务】任务我已经完成了/提交任务]", "[【提交任务】任务我已经完成了/日常_助人为乐_提交任务]");
			}
			else if (Singleton<ByteAPI>.I.寻找文本与(P_1, "[我想领取经验奖励/经验奖励]", "[我想领取道行奖励/道行奖励]", "[我想领取潜能奖励/潜能奖励]"))
			{
				P_1 = P_1.Replace("[我想领取经验奖励/经验奖励]", "[我想领取经验奖励/日常_助人为乐_经验奖励]");
				P_1 = P_1.Replace("[我想领取道行奖励/道行奖励]", "[我想领取道行奖励/日常_助人为乐_道行奖励]");
				P_1 = P_1.Replace("[我想领取潜能奖励/潜能奖励]", "[我想领取潜能奖励/日常_助人为乐_潜能奖励]");
			}
			else if (Singleton<ByteAPI>.I.寻找文本与(P_1, "[捐助穷人领取额外奖励/提交]", "[我想领取原有奖励/我想领取原有奖励]"))
			{
				P_1 = P_1.Replace("[捐助穷人领取额外奖励/提交]", "[捐助穷人领取额外奖励/日常_助人为乐_提交]");
				P_1 = P_1.Replace("[我想领取原有奖励/我想领取原有奖励]", "[我想领取原有奖励/日常_助人为乐_我想领取原有奖励]");
			}
			else if (Singleton<ByteAPI>.I.寻找文本与(P_1, "prompt:你确定要捐助", "给天墉城的穷人吗"))
			{
				string text = Singleton<ByteAPI>.I.取文本中间(P_1, "prompt:你确定要捐助", "#n文钱");
				string text2 = Singleton<ByteAPI>.I.取文本左边(text, 2);
				if (int.TryParse(Singleton<ByteAPI>.I.取文本右边(text, (text2 == "#c") ? (text.Length - 8) : (text.Length - 2)).Replace(",", ""), out var result) && P_0.user.背包数据.金钱 + P_0.user.背包数据.代金券 >= result)
				{
					P_1 = P_1.Replace("@确定/确定", "@确定/日常_助人为乐_确定");
				}
			}
			else if (Singleton<ByteAPI>.I.寻找文本与(P_1, "点五雷令耐久度直接领取", "#R助人为乐#n的任务奖励"))
			{
				P_1 = P_1.Replace("@确定/确定", "@确定/日常_助人为乐_五雷令_确定");
			}
		}
		catch (Exception ex)
		{
			Log.Error("日常_助人为乐返回对话重组-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public XhaJ3cfswGhhnmIequv()
	{
	}

	static XhaJ3cfswGhhnmIequv()
	{
	}
}
