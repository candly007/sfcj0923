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

namespace H0Y8GEJQx5wfb6t3alR;

internal class MtacAPJOeul0knZiQar : Singleton<MtacAPJOeul0knZiQar>
{
	internal static byte[] zluKuW4t6d;

	internal byte[] WSoKwwAvtK;

	internal static bool nqRKb7eDQi;

	private static int[] cvIKJC3egL;

	private static object QMPKKmSZCa;

	private static bool uc9KRUpXD0;

	
	[SpecialName]
	public static bool N8mJACclNW()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is天机神算)
		{
			return Singleton<全局变量类>.I.天机神算配置.功能开关;
		}
		return false;
	}

	
	internal void Ca9JEJT7Co()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("天机神算配置类.json")))
			{
				Singleton<全局变量类>.I.天机神算配置 = JsonConvert.DeserializeObject<天机神算配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("天机神算配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.天机神算配置 = new 天机神算配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("天机神算配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.天机神算配置, Formatting.Indented));
			}
			if (TimeOnly.TryParse(Singleton<全局变量类>.I.天机神算配置.每日刷新时间, out var result))
			{
				Singleton<全局变量类>.I.天机神算配置.每日刷新时间 = result.ToString("HH:mm");
			}
			uc9KRUpXD0 = Singleton<全局变量类>.I.天机神算配置.列表.All( (神算物品列表类 x) => x.价值 == 0);
			TEgJ17wrKY();
			bool flag = S4iJ4GpyDD();
			MdJJHCUvHp(Singleton<全局变量类>.I.天机神算配置.自动刷新开关 && flag, true);
		}
		catch (Exception ex)
		{
			Log.Error("天机神算配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void an7J3A5UES()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("天机神算配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.天机神算配置, Formatting.Indented));
			Log.Debug("天机神算配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("天机神算配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string dRGJYYbTKu()
	{
		Ca9JEJT7Co();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.天机神算配置, Formatting.Indented);
	}

	
	public void taLJpPUKc5(string P_0)
	{
		Singleton<全局变量类>.I.天机神算配置 = JsonConvert.DeserializeObject<天机神算配置类>(P_0);
		an7J3A5UES();
	}

	
	public void TEgJ17wrKY()
	{
		WSoKwwAvtK = (Singleton<全局变量类>.I.天机神算配置.功能开关 ? Singleton<WdAPI>.I.组包假NPC站街(Singleton<全局变量类>.I.天机神算配置.NPC数据, 111) : Array.Empty<byte>());
	}

	
	public void FGlJxK9Onf()
	{
		for (int i = 0; i < Singleton<全局变量类>.I.天机神算配置.列表.Count; i++)
		{
			Singleton<全局变量类>.I.天机神算配置.列表[i].已出份数 = 0;
		}
		an7J3A5UES();
		Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息("#G【天机神算活动】#n正在进行中，#b#Y奖池已经刷新#n，欢迎各位大佬前来推演天机，证道混元！", "管理员", AllEnums.频道Type.系统));
	}

	
	public async Task MdJJHCUvHp(bool P_0 = false, bool P_1 = false)
	{
		try
		{
			if (P_0)
			{
				FGlJxK9Onf();
			}
			if (zluKuW4t6d == Array.Empty<byte>() || P_1)
			{
				cvIKJC3egL[0] = 0;
				cvIKJC3egL[1] = 0;
				封包_写 封包_写2 = new 封包_写();
				封包_写2.写短整数型(87, reverse: true);
				封包_写2.写字节型(7);
				封包_写2.写整数型(111, reverse: true);
				封包_写2.写短整数型((short)Singleton<全局变量类>.I.天机神算配置.列表.Count, reverse: true);
				for (int i = 0; i < Singleton<全局变量类>.I.天机神算配置.列表.Count; i++)
				{
					cvIKJC3egL[0] += Singleton<全局变量类>.I.天机神算配置.列表[i].已出份数;
					cvIKJC3egL[1] += Singleton<全局变量类>.I.天机神算配置.列表[i].物品份数;
					封包_写2.写字节集(Singleton<全局变量类>.I.天机神算配置.列表[i].内部组包(), hasCount: false, 0);
				}
				zluKuW4t6d = Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
			}
			await Task.Delay(1);
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("刷新天机神算封包-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private bool S4iJ4GpyDD()
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < Singleton<全局变量类>.I.天机神算配置.列表.Count; i++)
		{
			num += Singleton<全局变量类>.I.天机神算配置.列表[i].已出份数;
			num2 += Singleton<全局变量类>.I.天机神算配置.列表[i].物品份数;
		}
		cvIKJC3egL[0] = num;
		cvIKJC3egL[1] = num2;
		if (num == num2)
		{
			return num2 != 0;
		}
		return false;
	}

	
	internal async Task QJuJeZX6Kr(MyNATSocketClient P_0)
	{
		try
		{
			if (N8mJACclNW())
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 4);
				defaultInterpolatedStringHandler.AppendLiteral("奖池已出数量#R");
				defaultInterpolatedStringHandler.AppendFormatted(cvIKJC3egL[0]);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(cvIKJC3egL[1]);
				defaultInterpolatedStringHandler.AppendLiteral("#n份，#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n点#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗类型);
				defaultInterpolatedStringHandler.AppendLiteral("#n可抽一次。");
				StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(22, 1, stringBuilder2);
				handler.AppendLiteral("#r");
				handler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.NPC数据.对话文本);
				handler.AppendLiteral("[查看当前奖池内容/天机神算_打开奖池]");
				stringBuilder3.Append(ref handler);
				if (Singleton<全局变量类>.I.天机神算配置.抽1次开关)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(25, 2, stringBuilder2);
					handler.AppendLiteral("[开始推演 1 次天机(");
					handler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
					handler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗类型);
					handler.AppendLiteral(")/天机神算_开始推演1]");
					stringBuilder4.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.天机神算配置.抽10次开关)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(26, 2, stringBuilder2);
					handler.AppendLiteral("[开始推演10 次天机(");
					handler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量 * 10);
					handler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗类型);
					handler.AppendLiteral(")/天机神算_开始推演10]");
					stringBuilder5.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.天机神算配置.抽20次开关)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(26, 2, stringBuilder2);
					handler.AppendLiteral("[开始推演20 次天机(");
					handler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量 * 20);
					handler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗类型);
					handler.AppendLiteral(")/天机神算_开始推演20]");
					stringBuilder6.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.天机神算配置.抽50次开关)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(26, 2, stringBuilder2);
					handler.AppendLiteral("[开始推演50 次天机(");
					handler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量 * 50);
					handler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗类型);
					handler.AppendLiteral(")/天机神算_开始推演50]");
					stringBuilder7.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.天机神算配置.抽100次开关)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(27, 2, stringBuilder2);
					handler.AppendLiteral("[开始推演100次天机(");
					handler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量 * 100);
					handler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗类型);
					handler.AppendLiteral(")/天机神算_开始推演100]");
					stringBuilder8.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.天机神算配置.抽200次开关)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder9 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(27, 2, stringBuilder2);
					handler.AppendLiteral("[开始推演200次天机(");
					handler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量 * 200);
					handler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗类型);
					handler.AppendLiteral(")/天机神算_开始推演200]");
					stringBuilder9.Append(ref handler);
				}
				await P_0.C_Send异步(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.天机神算配置.NPC数据.npcid, Singleton<全局变量类>.I.天机神算配置.NPC数据.npc形象, Singleton<全局变量类>.I.天机神算配置.NPC数据.npc名字, stringBuilder.ToString()));
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("NPC对话生成-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal async Task MuyJqGvCba(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_1 == "天机神算_打开奖池")
			{
				await MdJJHCUvHp(false, true);
				P_0.C_Send(zluKuW4t6d);
			}
			else if (P_1.StartsWith("天机神算_开始推演"))
			{
				int result;
				if (nqRKb7eDQi)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R天机神算奖池正在更新，暂无法推演！"));
				}
				else if (Singleton<全局变量类>.I.天机神算配置.列表.Count <= 0)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R天机神算奖池已被清空，暂无法推演，请刷新后再来吧。"));
				}
				else if (!int.TryParse(P_1.Replace("天机神算_开始推演", string.Empty), out result))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("选择有误。"));
				}
				else if (uc9KRUpXD0)
				{
					XHGJrW4b7y(P_0, result);
				}
				else
				{
					BZMJZ5Quvv(P_0, result);
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("对话点击处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private async Task XHGJrW4b7y(MyNATSocketClient P_0, int P_1)
	{
		if (P_1 <= 0)
		{
			return;
		}
		try
		{
			new List<神算物品列表类>();
			神算物品列表类 神算物品列表类2 = null;
			int i = 0;
			while (i < P_1 && await HwtJtSuiHH(P_0, i + 1, P_1))
			{
				lock (QMPKKmSZCa)
				{
					List<神算物品列表类> list = Singleton<全局变量类>.I.天机神算配置.列表.Where( (神算物品列表类 x) => x.已出份数 < x.物品份数).ToList();
					if (list.Count <= 0)
					{
						break;
					}
					神算物品列表类2 = list[Singleton<WdAPI>.I.qrjo9TWIdy(0, list.Count - 1)];
					神算物品列表类2.已出份数++;
					cvIKJC3egL[0] = cvIKJC3egL[0] + 1;
					goto IL_0174;
				}
				IL_0174:
				if (神算物品列表类2 != null)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 神算物品列表类2.名字, AllEnums.指令Type.无, 神算物品列表类2.物品数量, false, "天机神算抽中");
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 3);
					defaultInterpolatedStringHandler.AppendLiteral("恭喜你通过推演天机获得了#R");
					defaultInterpolatedStringHandler.AppendFormatted(神算物品列表类2.物品数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(神算物品列表类2.单位);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(神算物品列表类2.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					if (神算物品列表类2.开启谣言)
					{
						Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
						if (client频道事件 != null)
						{
							WdAPI i3 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
							defaultInterpolatedStringHandler.AppendLiteral("#G【天机神算】#Y");
							defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n在推演中竟然算出了#Y");
							defaultInterpolatedStringHandler.AppendFormatted(神算物品列表类2.名字);
							defaultInterpolatedStringHandler.AppendLiteral("#n，真是牛逼啊！");
							client频道事件(i3.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
						}
					}
				}
				i++;
			}
			lock (QMPKKmSZCa)
			{
				if (Singleton<全局变量类>.I.天机神算配置.自动刷新开关 && cvIKJC3egL[0] == cvIKJC3egL[1] && cvIKJC3egL[1] != 0)
				{
					MdJJHCUvHp(true, true);
				}
			}
			an7J3A5UES();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("开始推演处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private async Task BZMJZ5Quvv(MyNATSocketClient P_0, int P_1)
	{
		if (P_1 <= 0)
		{
			return;
		}
		try
		{
			List<神算物品列表类> 有效列表 = new List<神算物品列表类>();
			for (int i = 0; i < P_1; i++)
			{
				有效列表.Clear();
				if (!(await HwtJtSuiHH(P_0, i + 1, P_1)))
				{
					break;
				}
				lock (QMPKKmSZCa)
				{
					有效列表 = Singleton<全局变量类>.I.天机神算配置.列表.Where( (神算物品列表类 x) => x.已出份数 < x.物品份数).ToList();
					if (有效列表.Count <= 0)
					{
						break;
					}
					int num = 有效列表.Sum( (神算物品列表类 x) => x.价值 * (x.物品份数 - x.已出份数));
					if (num <= 0)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R奖池数据异常，暂无法推演！"));
						break;
					}
					int num2 = Singleton<WdAPI>.I.qrjo9TWIdy(1, num);
					int num3 = 0;
					神算物品列表类 神算物品列表类2 = null;
					foreach (神算物品列表类 item in 有效列表)
					{
						int num4 = item.价值 * (item.物品份数 - item.已出份数);
						if (num4 <= 0)
						{
							continue;
						}
						num3 += num4;
						if (num3 < num2)
						{
							continue;
						}
						神算物品列表类2 = item;
						神算物品列表类2.已出份数++;
						cvIKJC3egL[0] = cvIKJC3egL[0] + 1;
						Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 神算物品列表类2.名字, AllEnums.指令Type.无, 神算物品列表类2.物品数量, false, "天机神算抽中");
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 3);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你通过推演天机获得了#R");
						defaultInterpolatedStringHandler.AppendFormatted(神算物品列表类2.物品数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n");
						defaultInterpolatedStringHandler.AppendFormatted(神算物品列表类2.单位);
						defaultInterpolatedStringHandler.AppendLiteral("#R");
						defaultInterpolatedStringHandler.AppendFormatted(神算物品列表类2.名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n。");
						P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						if (神算物品列表类2.开启谣言)
						{
							Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
							if (client频道事件 != null)
							{
								WdAPI i3 = Singleton<WdAPI>.I;
								defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
								defaultInterpolatedStringHandler.AppendLiteral("#G【天机神算】#Y");
								defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
								defaultInterpolatedStringHandler.AppendLiteral("#n在推演中竟然算出了#Y");
								defaultInterpolatedStringHandler.AppendFormatted(神算物品列表类2.名字);
								defaultInterpolatedStringHandler.AppendLiteral("#n，真是牛逼啊！");
								client频道事件(i3.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
							}
						}
						break;
					}
					if (神算物品列表类2 == null)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R天机神算奖池已被清空，暂无法推演，请刷新后再来"));
						break;
					}
					goto IL_051b;
				}
				IL_051b:
				await Task.Delay(20);
			}
			lock (QMPKKmSZCa)
			{
				if (Singleton<全局变量类>.I.天机神算配置.自动刷新开关 && cvIKJC3egL[0] == cvIKJC3egL[1] && cvIKJC3egL[1] != 0)
				{
					MdJJHCUvHp(true, true);
				}
			}
			an7J3A5UES();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("开始指定推演处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private async Task<bool> HwtJtSuiHH(MyNATSocketClient P_0, int P_1, int P_2)
	{
		try
		{
			if (cvIKJC3egL[0] >= cvIKJC3egL[1])
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R天机神算奖池已被清空，暂无法推演，请刷新后再来。"));
				return false;
			}
			if (cvIKJC3egL[1] - cvIKJC3egL[0] < 1)
			{
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
				defaultInterpolatedStringHandler.AppendLiteral("天机神算奖池仅剩#R");
				defaultInterpolatedStringHandler.AppendFormatted(cvIKJC3egL[1] - cvIKJC3egL[0]);
				defaultInterpolatedStringHandler.AppendLiteral("#n份，无法进行第#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("#n次推演。");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return false;
			}
			switch (Singleton<全局变量类>.I.天机神算配置.抽取消耗类型)
			{
			case AllEnums.数值Type.金元宝:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.背包数据.金元宝 < Singleton<全局变量类>.I.天机神算配置.抽取消耗数量)
				{
					WdAPI i4 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
					defaultInterpolatedStringHandler.AppendLiteral("你的金元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法进行第#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n次推演。");
					P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (!DB.I.cAJNoOkab6(P_0, -Singleton<全局变量类>.I.天机神算配置.抽取消耗数量, 0))
				{
					WdAPI i5 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的金元宝扣除失败，无法进行第#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n次推演。");
					P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				WdAPI i6 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n金元宝进行了第#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("#n次推演天机。");
				P_0.C_Send(i6.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				return true;
			}
			case AllEnums.数值Type.银元宝:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.背包数据.银元宝 < Singleton<全局变量类>.I.天机神算配置.抽取消耗数量)
				{
					WdAPI i13 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
					defaultInterpolatedStringHandler.AppendLiteral("你的银元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法进行第#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n次推演。");
					P_0.C_Send(i13.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (!DB.I.cAJNoOkab6(P_0, 0, -Singleton<全局变量类>.I.天机神算配置.抽取消耗数量))
				{
					WdAPI i14 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的银元宝扣除失败，无法进行第#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n次推演。");
					P_0.C_Send(i14.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				WdAPI i15 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n银元宝进行了第#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("#n次推演天机。");
				P_0.C_Send(i15.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				return true;
			}
			case AllEnums.数值Type.金钱:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.背包数据.金钱 < Singleton<全局变量类>.I.天机神算配置.抽取消耗数量)
				{
					WdAPI i7 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 3);
					defaultInterpolatedStringHandler.AppendLiteral("你的金钱不足");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量));
					defaultInterpolatedStringHandler.AppendLiteral("，无法进行第#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n次推演。");
					P_0.C_Send(i7.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -Singleton<全局变量类>.I.天机神算配置.抽取消耗数量, false, "天机抽奖消耗");
				WdAPI i8 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量));
				defaultInterpolatedStringHandler.AppendLiteral("文钱进行了第#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("#n次推演天机。");
				P_0.C_Send(i8.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				return true;
			}
			case AllEnums.数值Type.累充点:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.存档数据.累计充值金额 < Singleton<全局变量类>.I.天机神算配置.抽取消耗数量)
				{
					WdAPI i11 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
					defaultInterpolatedStringHandler.AppendLiteral("你的累充点不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法进行第#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n次推演。");
					P_0.C_Send(i11.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, -Singleton<全局变量类>.I.天机神算配置.抽取消耗数量, false, "天机抽奖消耗");
				WdAPI i12 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n累充点进行了第#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("#n次推演天机。");
				P_0.C_Send(i12.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				return true;
			}
			case AllEnums.数值Type.南极点:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.存档数据.南极抽奖次数 < Singleton<全局变量类>.I.天机神算配置.抽取消耗数量)
				{
					WdAPI i16 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
					defaultInterpolatedStringHandler.AppendLiteral("你的南极点不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法进行第#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n次推演。");
					P_0.C_Send(i16.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, -Singleton<全局变量类>.I.天机神算配置.抽取消耗数量, false, "天机抽奖消耗");
				WdAPI i17 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n南极点进行了第#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("#n次推演天机。");
				P_0.C_Send(i17.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				return true;
			}
			case AllEnums.数值Type.奇宝点:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.存档数据.奇宝斋存档.奇宝斋余额 < Singleton<全局变量类>.I.天机神算配置.抽取消耗数量)
				{
					WdAPI i9 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
					defaultInterpolatedStringHandler.AppendLiteral("你的奇宝点不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法进行第#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n次推演。");
					P_0.C_Send(i9.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, -Singleton<全局变量类>.I.天机神算配置.抽取消耗数量, false, "天机抽奖消耗");
				WdAPI i10 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点进行了第#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("#n次推演天机。");
				P_0.C_Send(i10.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				return true;
			}
			case AllEnums.数值Type.灵气值:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.存档数据.数值存档.灵气值 < Singleton<全局变量类>.I.天机神算配置.抽取消耗数量)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
					defaultInterpolatedStringHandler.AppendLiteral("你的灵气值不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法进行第#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n次推演。");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -Singleton<全局变量类>.I.天机神算配置.抽取消耗数量, false, "天机抽奖消耗");
				WdAPI i3 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.天机神算配置.抽取消耗数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n灵气值进行了第#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("#n次推演天机。");
				P_0.C_Send(i3.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				return true;
			}
			default:
				await Task.Delay(1);
				return false;
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("消耗余额检测-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return false;
		}
	}

	
	public MtacAPJOeul0knZiQar()
	{
		WSoKwwAvtK = Array.Empty<byte>();
	}

	
	static MtacAPJOeul0knZiQar()
	{
		zluKuW4t6d = Array.Empty<byte>();
		nqRKb7eDQi = false;
		cvIKJC3egL = new int[2];
		QMPKKmSZCa = new object();
		uc9KRUpXD0 = false;
	}
}
