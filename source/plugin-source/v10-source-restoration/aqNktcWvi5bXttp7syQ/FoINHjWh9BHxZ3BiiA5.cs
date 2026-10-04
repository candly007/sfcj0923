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

namespace aqNktcWvi5bXttp7syQ;

internal class FoINHjWh9BHxZ3BiiA5 : Singleton<FoINHjWh9BHxZ3BiiA5>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public MyNATSocketClient NsBnQ2Muqs;

		public List<string> cl6nEwvPpH;

		public 百炼列表类 dRFn3RwfPd;

		public int UtRnYdsvvp;

		
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		
		internal void SEKnOU1uLQ(string v)
		{
			_003C_003Ec__DisplayClass11_2 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass11_2();
			CS_0024_003C_003E8__locals2.LyMn4EJorM = v;
			int num = cl6nEwvPpH.FindIndex( (string x) => x == CS_0024_003C_003E8__locals2.LyMn4EJorM);
			if (num < 0)
			{
				return;
			}
			cl6nEwvPpH.RemoveAt(num);
			if (cl6nEwvPpH.Count > 0)
			{
				return;
			}
			NsBnQ2Muqs.销毁回调事件 = null;
			int num2 = 0;
			int num3 = 0;
			for (int num4 = 0; num4 < UtRnYdsvvp; num4++)
			{
				num2 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				if (dRFn3RwfPd.炼化几率 >= num2)
				{
					num3++;
				}
			}
			if (num3 < UtRnYdsvvp)
			{
				MyNATSocketClient myNATSocketClient = NsBnQ2Muqs;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#R很遗憾，炼化#R");
				defaultInterpolatedStringHandler.AppendFormatted(dRFn3RwfPd.炼化道具);
				defaultInterpolatedStringHandler.AppendLiteral("#n失败了#R");
				defaultInterpolatedStringHandler.AppendFormatted(UtRnYdsvvp - num3);
				defaultInterpolatedStringHandler.AppendLiteral("#n次。");
				myNATSocketClient.C_Send(i.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			if (num3 > 0 && Singleton<WdAPI>.I.PndoGw5lW7(NsBnQ2Muqs, AllEnums.发送数据Type.道具, dRFn3RwfPd.炼化道具, AllEnums.指令Type.无, dRFn3RwfPd.炼化数量 * num3, false, "百炼道具炼化"))
			{
				MyNATSocketClient myNATSocketClient2 = NsBnQ2Muqs;
				WdAPI i2 = Singleton<WdAPI>.I;
				string 提示内容 = "#G恭喜你，炼化成功！#n";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你成功炼化了#R");
				defaultInterpolatedStringHandler.AppendFormatted(num3);
				defaultInterpolatedStringHandler.AppendLiteral("#n次，获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(dRFn3RwfPd.炼化数量 * num3);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(dRFn3RwfPd.炼化道具);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(提示内容, defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}

		static _003C_003Ec__DisplayClass11_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_1
	{
		public string[] bUwn1TYyCe;

		public _003C_003Ec__DisplayClass11_0 Dk8nxalHv6;

		
		public _003C_003Ec__DisplayClass11_1()
		{
		}

		
		internal bool WyknpP2lXg(百炼提交校验类 x)
		{
			if (!x.是否校验 && Dk8nxalHv6.NsBnQ2Muqs.user.背包数据.物品列表[x.提交格子].名字 == bUwn1TYyCe[0])
			{
				return x.提交数量 >= int.Parse(bUwn1TYyCe[1]);
			}
			return false;
		}

		static _003C_003Ec__DisplayClass11_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_2
	{
		public string LyMn4EJorM;

		
		public _003C_003Ec__DisplayClass11_2()
		{
		}

		
		internal bool XxgnHDV3eg(string x)
		{
			return x == LyMn4EJorM;
		}

		static _003C_003Ec__DisplayClass11_2()
		{
		}
	}

	internal byte[] XXuW0WG0gJ;

	internal List<百炼列表类> WwBWOajb8Z;

	private static int vDLWQAhmyq;

	
	internal void F5PW7WmX3U()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("百炼功能配置类.json")))
			{
				Singleton<全局变量类>.I.百炼功能配置 = JsonConvert.DeserializeObject<百炼功能配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("百炼功能配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.百炼功能配置 = new 百炼功能配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("百炼功能配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.百炼功能配置, Formatting.Indented));
			}
			WwBWOajb8Z = Singleton<全局变量类>.I.百炼功能配置.百炼列表.Values.ToList();
			WwBWOajb8Z.Sort();
			WwBWOajb8Z.Reverse();
			MOWWypPsmH();
		}
		catch (Exception ex)
		{
			Log.Error("百炼功能配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void MGnWayWEmi()
	{
		try
		{
			MOWWypPsmH();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("百炼功能配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.百炼功能配置, Formatting.Indented));
			Log.Debug("百炼功能配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("百炼功能配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string m9MWTREQxX()
	{
		F5PW7WmX3U();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.百炼功能配置, Formatting.Indented);
	}

	
	public void vPqW9FUgE9(string P_0)
	{
		Singleton<全局变量类>.I.百炼功能配置 = JsonConvert.DeserializeObject<百炼功能配置类>(P_0);
		MGnWayWEmi();
	}

	
	public void MOWWypPsmH()
	{
		XXuW0WG0gJ = (Singleton<全局变量类>.I.百炼功能配置.功能开关 ? Singleton<WdAPI>.I.组包假NPC站街(Singleton<全局变量类>.I.百炼功能配置.NPC数据, 107) : Array.Empty<byte>());
	}

	
	internal void tZtWC1Sb6L(MyNATSocketClient P_0, int P_1 = 0)
	{
		try
		{
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(Singleton<全局变量类>.I.百炼功能配置.对话介绍);
			if (Singleton<全局变量类>.I.百炼功能配置.功能开关)
			{
				int num = 0;
				for (int i = P_1; i < WwBWOajb8Z.Count; i++)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
					handler.AppendLiteral("[【炼化】");
					handler.AppendFormatted(WwBWOajb8Z[i].炼化道具);
					handler.AppendLiteral("/百炼功能_百炼选项_");
					handler.AppendFormatted(WwBWOajb8Z[i].炼化道具);
					handler.AppendLiteral("]");
					stringBuilder3.Append(ref handler);
					num++;
					if (num >= vDLWQAhmyq)
					{
						break;
					}
				}
				if (P_1 >= vDLWQAhmyq)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(16, 1, stringBuilder2);
					handler.AppendLiteral("[上一页/百炼功能_翻页选项_");
					handler.AppendFormatted(P_1 - vDLWQAhmyq);
					handler.AppendLiteral("]");
					stringBuilder4.Append(ref handler);
				}
				if (WwBWOajb8Z.Count > P_1 + vDLWQAhmyq)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(16, 1, stringBuilder2);
					handler.AppendLiteral("[下一页/百炼功能_翻页选项_");
					handler.AppendFormatted(P_1 + vDLWQAhmyq);
					handler.AppendLiteral("]");
					stringBuilder5.Append(ref handler);
				}
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.百炼功能配置.NPC数据.npcid, Singleton<全局变量类>.I.百炼功能配置.NPC数据.npc形象, Singleton<全局变量类>.I.百炼功能配置.NPC数据.npc名字, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("NPC对话生成-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void f6LWVyVBWX(MyNATSocketClient P_0, string P_1, string P_2)
	{
		try
		{
			if (!P_0.user.缓存数据.is使用仙灵卡)
			{
				if (P_1.Contains("百炼功能_翻页选项_", StringComparison.CurrentCulture))
				{
					tZtWC1Sb6L(P_0, int.Parse(P_1.Replace("百炼功能_翻页选项_", string.Empty)));
				}
				else if (P_1.Contains("百炼功能_百炼选项_", StringComparison.CurrentCulture))
				{
					OaqWkTq88Y(P_0, P_1, P_2);
				}
				else if (P_1.Contains("$*百炼功能_百炼提交_", StringComparison.CurrentCulture) && P_0.user.缓存数据.l9XIwuUeoO.ElapsedMilliseconds >= 1000)
				{
					P_0.user.缓存数据.l9XIwuUeoO.Restart();
					百炼选项提交处理(P_0, P_1, P_2);
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("百炼对话处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void OaqWkTq88Y(MyNATSocketClient P_0, string P_1, string P_2)
	{
		try
		{
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			int num = Singleton<WdAPI>.I.取背包剩余空格数(P_0);
			if (num < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的背包已满。"));
				return;
			}
			P_1 = P_1.Replace("百炼功能_百炼选项_", "");
			if (!Singleton<全局变量类>.I.百炼功能配置.百炼列表.TryGetValue(P_1, out 百炼列表类 value))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R配方选择有误！"));
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (!value.Is叠加道具 && value.炼化数量 > num)
			{
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你的背包格子不足#R");
				defaultInterpolatedStringHandler.AppendFormatted(value.炼化数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n格，请整理背包后再来。");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			WdAPI i2 = Singleton<WdAPI>.I;
			int npc形象 = Singleton<全局变量类>.I.百炼功能配置.NPC数据.npc形象;
			string npc名字 = Singleton<全局变量类>.I.百炼功能配置.NPC数据.npc名字;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[@/$*百炼功能_百炼提交_");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(value.对话文本);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted(value.提交格子数量);
			defaultInterpolatedStringHandler.AppendLiteral(",0]\r\n");
			P_0.C_Send(i2.组包提交物品框(107, npc形象, npc名字, defaultInterpolatedStringHandler.ToStringAndClear()));
		}
		catch (Exception ex)
		{
			Log.Error("百炼选项点击处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task 百炼选项提交处理(MyNATSocketClient myclient, string 内容, string 填写内容)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals61 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals61.NsBnQ2Muqs = myclient;
		try
		{
			if (CS_0024_003C_003E8__locals61.NsBnQ2Muqs.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			if (Singleton<WdAPI>.I.取背包剩余空格数(CS_0024_003C_003E8__locals61.NsBnQ2Muqs) < 1)
			{
				CS_0024_003C_003E8__locals61.NsBnQ2Muqs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的背包已满。"));
				return;
			}
			内容 = 内容.Replace("$*百炼功能_百炼提交_", "");
			if (!Singleton<全局变量类>.I.百炼功能配置.百炼列表.TryGetValue(内容, out CS_0024_003C_003E8__locals61.dRFn3RwfPd))
			{
				CS_0024_003C_003E8__locals61.NsBnQ2Muqs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R配方选择有误！"));
				return;
			}
			string[] array = 填写内容.Replace("money:0,", "").Split(",");
			if (array.Length != CS_0024_003C_003E8__locals61.dRFn3RwfPd.提交格子数量)
			{
				return;
			}
			List<百炼提交校验类> list = new List<百炼提交校验类>();
			for (int i = 0; i < array.Length; i++)
			{
				if (!int.TryParse(array[i].Split(":")[0], out var result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals61.NsBnQ2Muqs, result))
				{
					return;
				}
				if (CS_0024_003C_003E8__locals61.NsBnQ2Muqs.user.背包数据.物品列表[result].当前耐久度 < CS_0024_003C_003E8__locals61.NsBnQ2Muqs.user.背包数据.物品列表[result].最大耐久度)
				{
					CS_0024_003C_003E8__locals61.NsBnQ2Muqs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R提交的物品耐久度有消耗，无法进行合成！"));
					return;
				}
				list.Add(new 百炼提交校验类
				{
					是否符合 = false,
					提交格子 = result,
					提交数量 = CS_0024_003C_003E8__locals61.NsBnQ2Muqs.user.背包数据.物品列表[result].数量
				});
				CS_0024_003C_003E8__locals61.NsBnQ2Muqs.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals61.NsBnQ2Muqs.user.背包数据.物品列表[result].封包缓存, result));
			}
			for (int j = 0; j < CS_0024_003C_003E8__locals61.dRFn3RwfPd.提交格子数量; j++)
			{
				_003C_003Ec__DisplayClass11_1 CS_0024_003C_003E8__locals43 = new _003C_003Ec__DisplayClass11_1();
				CS_0024_003C_003E8__locals43.Dk8nxalHv6 = CS_0024_003C_003E8__locals61;
				if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals43.Dk8nxalHv6.dRFn3RwfPd.提交数组[j]))
				{
					CS_0024_003C_003E8__locals43.bUwn1TYyCe = CS_0024_003C_003E8__locals43.Dk8nxalHv6.dRFn3RwfPd.提交数组[j].Split("-");
					百炼提交校验类 百炼提交校验类2 = list.Find( (百炼提交校验类 x) => !x.是否校验 && CS_0024_003C_003E8__locals43.Dk8nxalHv6.NsBnQ2Muqs.user.背包数据.物品列表[x.提交格子].名字 == CS_0024_003C_003E8__locals43.bUwn1TYyCe[0] && x.提交数量 >= int.Parse(CS_0024_003C_003E8__locals43.bUwn1TYyCe[1]));
					if (百炼提交校验类2 == null)
					{
						MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals43.Dk8nxalHv6.NsBnQ2Muqs;
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你提交的物品中不存在#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals43.bUwn1TYyCe[0]);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals43.bUwn1TYyCe[1]);
						defaultInterpolatedStringHandler.AppendLiteral("#n。");
						myNATSocketClient.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					百炼提交校验类2.是否校验 = true;
					百炼提交校验类2.是否符合 = true;
					百炼提交校验类2.需求数量 = int.Parse(CS_0024_003C_003E8__locals43.bUwn1TYyCe[1]);
					百炼提交校验类2.可炼份数 = 百炼提交校验类2.提交数量 / 百炼提交校验类2.需求数量;
				}
			}
			if (!list.All( (百炼提交校验类 x) => x.是否符合))
			{
				CS_0024_003C_003E8__locals61.NsBnQ2Muqs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R配方选择有误！"));
				return;
			}
			CS_0024_003C_003E8__locals61.UtRnYdsvvp = list.MinBy( (百炼提交校验类 x) => x.可炼份数).可炼份数;
			int num = Singleton<WdAPI>.I.取背包剩余空格数(CS_0024_003C_003E8__locals61.NsBnQ2Muqs);
			CS_0024_003C_003E8__locals61.UtRnYdsvvp = (CS_0024_003C_003E8__locals61.dRFn3RwfPd.Is叠加道具 ? Math.Min(CS_0024_003C_003E8__locals61.UtRnYdsvvp, num * 99) : Math.Min(CS_0024_003C_003E8__locals61.UtRnYdsvvp, num));
			CS_0024_003C_003E8__locals61.cl6nEwvPpH = new List<string>();
			foreach (百炼提交校验类 item in list)
			{
				CS_0024_003C_003E8__locals61.cl6nEwvPpH.Add(CS_0024_003C_003E8__locals61.NsBnQ2Muqs.user.背包数据.物品列表[item.提交格子].名字);
			}
			CS_0024_003C_003E8__locals61.NsBnQ2Muqs.销毁回调事件 =  (string v) =>
			{
				_003C_003Ec__DisplayClass11_2 CS_0024_003C_003E8__locals62 = new _003C_003Ec__DisplayClass11_2();
				CS_0024_003C_003E8__locals62.LyMn4EJorM = v;
				int num2 = CS_0024_003C_003E8__locals61.cl6nEwvPpH.FindIndex( (string x) => x == CS_0024_003C_003E8__locals62.LyMn4EJorM);
				if (num2 >= 0)
				{
					CS_0024_003C_003E8__locals61.cl6nEwvPpH.RemoveAt(num2);
					if (CS_0024_003C_003E8__locals61.cl6nEwvPpH.Count <= 0)
					{
						CS_0024_003C_003E8__locals61.NsBnQ2Muqs.销毁回调事件 = null;
						int num3 = 0;
						int num4 = 0;
						for (int num5 = 0; num5 < CS_0024_003C_003E8__locals61.UtRnYdsvvp; num5++)
						{
							num3 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
							if (CS_0024_003C_003E8__locals61.dRFn3RwfPd.炼化几率 >= num3)
							{
								num4++;
							}
						}
						if (num4 < CS_0024_003C_003E8__locals61.UtRnYdsvvp)
						{
							MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals61.NsBnQ2Muqs;
							WdAPI i3 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(21, 2);
							defaultInterpolatedStringHandler2.AppendLiteral("#R很遗憾，炼化#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals61.dRFn3RwfPd.炼化道具);
							defaultInterpolatedStringHandler2.AppendLiteral("#n失败了#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals61.UtRnYdsvvp - num4);
							defaultInterpolatedStringHandler2.AppendLiteral("#n次。");
							myNATSocketClient2.C_Send(i3.提示_杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						}
						if (num4 > 0 && Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals61.NsBnQ2Muqs, AllEnums.发送数据Type.道具, CS_0024_003C_003E8__locals61.dRFn3RwfPd.炼化道具, AllEnums.指令Type.无, CS_0024_003C_003E8__locals61.dRFn3RwfPd.炼化数量 * num4, false, "百炼道具炼化"))
						{
							MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals61.NsBnQ2Muqs;
							WdAPI i4 = Singleton<WdAPI>.I;
							string 提示内容 = "#G恭喜你，炼化成功！#n";
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(25, 3);
							defaultInterpolatedStringHandler2.AppendLiteral("你成功炼化了#R");
							defaultInterpolatedStringHandler2.AppendFormatted(num4);
							defaultInterpolatedStringHandler2.AppendLiteral("#n次，获得了#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals61.dRFn3RwfPd.炼化数量 * num4);
							defaultInterpolatedStringHandler2.AppendLiteral("#n个#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals61.dRFn3RwfPd.炼化道具);
							defaultInterpolatedStringHandler2.AppendLiteral("#n。");
							myNATSocketClient3.C_Send(i4.提示_提醒和杂项公告(提示内容, defaultInterpolatedStringHandler2.ToStringAndClear()));
						}
					}
				}
			};
			Array.Empty<byte>();
			foreach (百炼提交校验类 item2 in list)
			{
				CS_0024_003C_003E8__locals61.NsBnQ2Muqs.S_Send((item2.需求数量 * CS_0024_003C_003E8__locals61.UtRnYdsvvp != item2.提交数量) ? Singleton<WdAPI>.I.rxTojoeFsR(item2.提交格子, item2.需求数量 * CS_0024_003C_003E8__locals61.UtRnYdsvvp) : Singleton<WdAPI>.I.CxWI0uMCPh(CS_0024_003C_003E8__locals61.NsBnQ2Muqs, item2.提交格子), "百炼选项提交处理");
				await Task.Delay(500);
			}
		}
		catch (Exception ex)
		{
			Log.Error("百炼选项提交处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public FoINHjWh9BHxZ3BiiA5()
	{
		XXuW0WG0gJ = Array.Empty<byte>();
		WwBWOajb8Z = new List<百炼列表类>();
	}

	
	static FoINHjWh9BHxZ3BiiA5()
	{
		vDLWQAhmyq = 8;
	}
}
