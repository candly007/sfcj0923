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

namespace aSItGBlifY3VT2BvkBH;

internal class cCs7kYlNIp7pmjCmEml : Singleton<cCs7kYlNIp7pmjCmEml>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public MyNATSocketClient tYrMHp7UIS;

		public int AGOM4PPcEg;

		public int DXfMeaxQk3;

		public 属性数据 QNmMqWVnTD;

		public int CtUMruWhKU;

		public int[] DeCMZ3piFB;

		public int r10Mt9SR1D;

		
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		
		internal bool PyaMpnVg5V(属性数据 x)
		{
			if (x.属性类别 == AGOM4PPcEg)
			{
				return x.属性标识 == DXfMeaxQk3;
			}
			return false;
		}

		
		internal bool xnbM1v8QIS(int[] x)
		{
			return x[0] > Math.Abs(QNmMqWVnTD.属性数值);
		}

		
		internal async void GTvMxAmFn6(string v)
		{
			if (!(v != Singleton<全局变量类>.I.首饰系统配置.强化材料名字))
			{
				tYrMHp7UIS.销毁回调事件 = null;
				tYrMHp7UIS.user.存档数据.精炼存档.首饰强化次数 = 0;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 5);
				defaultInterpolatedStringHandler.AppendLiteral("#26天呐，#Y");
				defaultInterpolatedStringHandler.AppendFormatted(tYrMHp7UIS.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("#n的#Y");
				defaultInterpolatedStringHandler.AppendFormatted(tYrMHp7UIS.user.背包数据.物品列表[CtUMruWhKU].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n成功强化！#G");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性名字Type)QNmMqWVnTD.属性标识);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted(QNmMqWVnTD.属性数值);
				defaultInterpolatedStringHandler.AppendLiteral(" #Y→#G");
				defaultInterpolatedStringHandler.AppendFormatted(DeCMZ3piFB[0]);
				defaultInterpolatedStringHandler.AppendLiteral("#Y↑#G。");
				StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				WdAPI i = Singleton<WdAPI>.I;
				MyNATSocketClient myNATSocketClient = tYrMHp7UIS;
				int num = CtUMruWhKU;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性类别)QNmMqWVnTD.属性类别);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)QNmMqWVnTD.属性标识);
				i.Mr8ICwW3qX(myNATSocketClient, num, defaultInterpolatedStringHandler.ToStringAndClear(), DeCMZ3piFB[0].ToString());
				tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.QewoEwLLTD("首饰强化中", 1));
				await Task.Delay(1000);
				MyNATSocketClient myNATSocketClient2 = tYrMHp7UIS;
				WdAPI i2 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#Y强化成功！#n你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(r10Mt9SR1D);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.首饰系统配置.强化材料名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				myNATSocketClient2.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_中心提醒("#G首饰强化成功！")).ToArray());
				if (Singleton<全局变量类>.I.首饰系统配置.谣言开关)
				{
					Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(stringBuilder.ToString(), "管理员"));
				}
			}
		}

		static _003C_003Ec__DisplayClass10_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_1
	{
		public 属性数据 k7iMzijyAj;

		
		public _003C_003Ec__DisplayClass10_1()
		{
		}

		
		internal bool bR6MAIfj1q(KeyValuePair<string, 首饰强化配置类> x2)
		{
			if (x2.Key == $"{(AllEnums.属性名字Type)k7iMzijyAj.属性标识}" && x2.Value.是否可用 && x2.Value.数值几率.Count > 0)
			{
				List<int[]> 数值几率 = x2.Value.数值几率;
				return 数值几率[数值几率.Count - 1][0] > k7iMzijyAj.属性数值;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass10_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public MyNATSocketClient SCHhwoXTub;

		public int L4ohbJbqIw;

		public int lJHhJsm9lf;

		
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		
		internal void giXhuWIUes(string v)
		{
			if (!(v != Singleton<全局变量类>.I.首饰系统配置.降级材料名字))
			{
				SCHhwoXTub.销毁回调事件 = null;
				Singleton<WdAPI>.I.NNfIVUuyWv(SCHhwoXTub, L4ohbJbqIw, new List<string[]> { new string[2]
				{
					"req_level",
					lJHhJsm9lf.ToString()
				} });
				MyNATSocketClient myNATSocketClient = SCHhwoXTub;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你使用了#R");
				defaultInterpolatedStringHandler.AppendFormatted(v);
				defaultInterpolatedStringHandler.AppendLiteral("#n成功的将#R");
				defaultInterpolatedStringHandler.AppendFormatted(SCHhwoXTub.user.背包数据.物品列表[L4ohbJbqIw].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n的等级降低至#R");
				defaultInterpolatedStringHandler.AppendFormatted(lJHhJsm9lf);
				defaultInterpolatedStringHandler.AppendLiteral("#n级。");
				myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}

		static _003C_003Ec__DisplayClass11_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public 属性数据 sSQhRe0NUB;

		
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		
		internal bool VLuhKTGt84(int[] x)
		{
			return x[0] > sSQhRe0NUB.属性数值;
		}

		static _003C_003Ec__DisplayClass9_0()
		{
		}
	}

	
	internal void jHglB2LkXK()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("首饰系统配置类.json")))
			{
				Singleton<全局变量类>.I.首饰系统配置 = JsonConvert.DeserializeObject<首饰系统配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("首饰系统配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.首饰系统配置 = new 首饰系统配置类();
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("准确", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "2=90/3=70/4=50/5=30/6=10/7=5/8=3/9=2/10=1"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("所有相性", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "2=900/3=700/4=500/5=300/6=100/7=50/8=10/9=5/10=1"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("体质", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "15=900/17=700/19=500/21=300/23=100/25=50/27=30/29=10/31=5/32=1"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("力量", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "15=900/17=700/19=500/21=300/23=100/25=50/27=30/29=10/31=5/32=1"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("灵力", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "15=900/17=700/19=500/21=300/23=100/25=50/27=30/29=10/31=5/32=1"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("敏捷", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "15=900/17=700/19=500/21=300/23=100/25=50/27=30/29=10/31=5/32=1"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("金抗性", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("木抗性", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("水抗性", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("火抗性", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("土抗性", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("抗中毒", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/8=700/10=500/12=300/14=100/16=50/18=30/20=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("抗冰冻", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/8=700/10=500/12=300/14=100/16=50/18=30/20=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("抗昏睡", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/8=700/10=500/12=300/14=100/16=50/18=30/20=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("抗遗忘", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/8=700/10=500/12=300/14=100/16=50/18=30/20=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("抗混乱", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/8=700/10=500/12=300/14=100/16=50/18=30/20=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("抗所有异常", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("所有抗性", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("所有属性", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "8=900/10=700/12=500/14=300/16=100/18=50/20=30/22=10/24=5/26=1"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("所有技能上升", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "2=900/3=700/4=500/5=300/6=100/7=50/8=10/9=5/10=1"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗金", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗木", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗水", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗火", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗土", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗遗忘", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗中毒", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗冰冻", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗昏睡", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗混乱", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("躲避攻击", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "12=90/14=70/16=50/18=30/20=10/22=5/24=3/26=2/28=1/30=1"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("师门攻击技能消耗降低", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "-2=900/-3=700/-4=500/-5=300/-6=100/-7=50/-8=30/-9=20/-10=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("师门障碍技能消耗降低", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "-2=900/-3=700/-4=500/-5=300/-6=100/-7=50/-8=30/-9=20/-10=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("师门辅助技能消耗降低", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "-2=900/-3=700/-4=500/-5=300/-6=100/-7=50/-8=30/-9=20/-10=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("强力中毒", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("强力昏睡", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("强力冰冻", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("强力遗忘", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("强力混乱", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视所有抗性", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/8=700/10=500/12=300/14=100/16=50/18=30/20=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视所有抗异常", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/8=700/10=500/12=300/14=100/16=50/18=30/20=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("解除遗忘状态", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("解除中毒状态", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("解除冰冻状态", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("解除昏睡状态", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("解除混乱状态", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视躲避攻击", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("闪避", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "2=90/3=70/4=50/5=30/6=10/7=5/8=3/9=2/10=1"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("抗镇魂", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/8=700/10=500/12=300/14=100/16=50/18=30/20=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("抗化功", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/8=700/10=500/12=300/14=100/16=50/18=30/20=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("抗水牢", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/8=700/10=500/12=300/14=100/16=50/18=30/20=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("抗锁灵", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/8=700/10=500/12=300/14=100/16=50/18=30/20=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("抗迷心", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/8=700/10=500/12=300/14=100/16=50/18=30/20=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗镇魂", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗化功", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗水牢", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗锁灵", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("忽视目标抗迷心", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("解除镇魂状态", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("解除化功状态", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("解除水牢状态", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("解除锁灵状态", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("解除迷心状态", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "6=900/7=700/8=50/9=300/10=100/11=50/12=30/13=20/15=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("强力镇魂", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("强力化功", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("强力水牢", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("强力锁灵", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryAdd("强力迷心", new 首饰强化配置类
				{
					是否可用 = true,
					数值几率文本 = "9=900/12=700/15=500/18=300/21=100/24=50/27=30/30=10"
				});
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("首饰系统配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.首饰系统配置, Formatting.Indented));
			}
			foreach (首饰强化配置类 value in Singleton<全局变量类>.I.首饰系统配置.属性字典.Values)
			{
				value.Init();
			}
		}
		catch (Exception ex)
		{
			Log.Error("首饰系统配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void CaplGKRwQg()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("首饰系统配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.首饰系统配置, Formatting.Indented));
			Log.Debug("首饰系统配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("首饰系统配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string CfZlfyC6Ah()
	{
		jHglB2LkXK();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.首饰系统配置, Formatting.Indented);
	}

	
	public void fDhl67iWfM(string P_0)
	{
		Singleton<全局变量类>.I.首饰系统配置 = JsonConvert.DeserializeObject<首饰系统配置类>(P_0);
		CaplGKRwQg();
	}

	
	internal bool eXol2FJiY5(MyNATSocketClient P_0, byte P_1, byte P_2)
	{
		if ((全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.IsVip) && Singleton<全局变量类>.I.首饰系统配置.首饰降级开关 && P_0.user.背包数据.物品列表[P_1].名字 == Singleton<全局变量类>.I.首饰系统配置.降级材料名字 && (P_0.user.背包数据.物品列表[P_2].物品类型 == 4 || P_0.user.背包数据.物品列表[P_2].物品类型 == 5 || P_0.user.背包数据.物品列表[P_2].物品类型 == 6) && P_0.user.背包数据.物品列表[P_2].等级 >= Singleton<全局变量类>.I.首饰系统配置.最低降级等级 && P_0.user.背包数据.物品列表[P_2].等级 % 10 != 0)
		{
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return false;
			}
			P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_1].封包缓存, P_1).Concat(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_2].封包缓存, P_2)).ToArray());
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(61, 7);
			defaultInterpolatedStringHandler.AppendLiteral("[@确定/首饰系统_降级操作_");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_1].物品ID);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].物品ID);
			defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要使用#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.首饰系统配置.降级材料名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n将#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n的等级降低至#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].等级 / 10 * 10);
			defaultInterpolatedStringHandler.AppendLiteral("#n级吗？]");
			P_0.C_Send(i.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
			return true;
		}
		return false;
	}

	
	private bool k75lmj6oKh(MyNATSocketClient P_0, byte P_1, byte P_2)
	{
		try
		{
			if (!全局变量类.Is调试 && !Singleton<全局变量类>.I.验证client.授权配置.IsVip)
			{
				return false;
			}
			if (!Singleton<全局变量类>.I.首饰系统配置.首饰强化开关)
			{
				return false;
			}
			if (P_0.user.背包数据.物品列表[P_1].名字 != Singleton<全局变量类>.I.首饰系统配置.强化材料名字)
			{
				return false;
			}
			if (P_0.user.背包数据.物品列表[P_1].数量 < 1)
			{
				return false;
			}
			if (P_0.user.背包数据.物品列表[P_2].物品类型 < 4 || P_0.user.背包数据.物品列表[P_2].物品类型 > 6)
			{
				return false;
			}
			if (P_0.user.背包数据.物品列表[P_2].等级 < Singleton<全局变量类>.I.首饰系统配置.最低强化等级)
			{
				return false;
			}
			if (P_0.user.背包数据.物品列表[P_2].装备属性列表.Count <= 0)
			{
				return false;
			}
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("检测强化条件成立-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return false;
		}
	}

	
	private void zhrlP9SgWo(MyNATSocketClient P_0, byte P_1, byte P_2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < P_0.user.背包数据.物品列表[P_2].装备属性列表.Count; i++)
		{
			属性数据 属性数据2 = P_0.user.背包数据.物品列表[P_2].装备属性列表[i];
			int 属性类别 = 属性数据2.属性类别;
			bool flag = ((属性类别 == 514 || 属性类别 == 770 || 属性类别 == 3074) ? true : false);
			if (flag && 问道数据类.特效类型字典.Contains(属性数据2.属性标识) && Singleton<全局变量类>.I.首饰系统配置.属性字典.TryGetValue($"{(AllEnums.属性名字Type)属性数据2.属性标识}", out 首饰强化配置类 value) && value.是否可用 && value.数值几率.Count > 0)
			{
				int 属性数值 = 属性数据2.属性数值;
				List<int[]> 数值几率 = value.数值几率;
				if (属性数值 < 数值几率[数值几率.Count - 1][0])
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(26, 6, stringBuilder2);
					handler.AppendLiteral("[【点击强化】");
					handler.AppendFormatted((AllEnums.属性名字Type)属性数据2.属性标识);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(属性数据2.属性数值);
					handler.AppendLiteral(" 增加/首饰系统_强化操作_");
					handler.AppendFormatted(P_1);
					handler.AppendLiteral("|");
					handler.AppendFormatted(P_2);
					handler.AppendLiteral("|");
					handler.AppendFormatted(属性数据2.属性类别);
					handler.AppendLiteral("|");
					handler.AppendFormatted(属性数据2.属性标识);
					handler.AppendLiteral("]");
					stringBuilder2.Append(ref handler);
				}
			}
		}
		if (stringBuilder.Length > 0)
		{
			stringBuilder.Insert(0, "请选择你要强化的属性：#r");
			stringBuilder.Append("[我只是看看/离开]");
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, 0, "精精儿", stringBuilder.ToString()));
		}
	}

	
	internal bool blRlXF7Xxl(MyNATSocketClient P_0, byte P_1, byte P_2)
	{
		if (!k75lmj6oKh(P_0, P_1, P_2))
		{
			return false;
		}
		P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_1].封包缓存, P_1).Concat(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_2].封包缓存, P_2)).ToArray());
		if (Singleton<全局变量类>.I.首饰系统配置.随机强化开关)
		{
			F2MlFBfSQs(P_0, P_1, P_2);
		}
		else
		{
			zhrlP9SgWo(P_0, P_1, P_2);
		}
		return true;
	}

	
	private void F2MlFBfSQs(MyNATSocketClient P_0, byte P_1, byte P_2)
	{
		if (Singleton<全局变量类>.I.首饰系统配置.随机强化开关)
		{
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(86, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[@确定/首饰系统_强化操作_");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要对#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n进行属性强化操作吗？#R（点击确定会自动选择一条未满的属性进行强化直至成功或者材料不足）#n]");
			P_0.C_Send(i.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
		}
	}

	
	internal bool AeElLatN1Q(MyNATSocketClient P_0, int P_1, int P_2)
	{
		try
		{
			int num = 0;
			_ = string.Empty;
			if (Singleton<全局变量类>.I.首饰系统配置.随机强化开关)
			{
				_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass9_0();
				List<属性数据> list = P_0.user.背包数据.物品列表[P_2].装备属性列表.FindAll( (属性数据 x) =>
				{
					if (问道数据类.属性名字字典.Contains(x.属性标识) && Singleton<全局变量类>.I.首饰系统配置.属性字典.ContainsKey($"{(AllEnums.属性名字Type)x.属性标识}") && Singleton<全局变量类>.I.首饰系统配置.属性字典[$"{(AllEnums.属性名字Type)x.属性标识}"].是否可用 && Singleton<全局变量类>.I.首饰系统配置.属性字典[$"{(AllEnums.属性名字Type)x.属性标识}"].数值几率.Count > 0 && (x.属性类别 == 514 || x.属性类别 == 770 || x.属性类别 == 3074))
					{
						int 属性数值 = x.属性数值;
						List<int[]> 数值几率2 = Singleton<全局变量类>.I.首饰系统配置.属性字典[$"{(AllEnums.属性名字Type)x.属性标识}"].数值几率;
						return 属性数值 < 数值几率2[数值几率2.Count - 1][0];
					}
					return false;
				});
				if (list.Count <= 0)
				{
					return false;
				}
				CS_0024_003C_003E8__locals6.sSQhRe0NUB = list[Singleton<WdAPI>.I.qrjo9TWIdy(0, list.Count - 1)];
				List<int[]> list2 = Singleton<全局变量类>.I.首饰系统配置.属性字典[$"{(AllEnums.属性名字Type)CS_0024_003C_003E8__locals6.sSQhRe0NUB.属性标识}"].数值几率.FindAll( (int[] x) => x[0] > CS_0024_003C_003E8__locals6.sSQhRe0NUB.属性数值);
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(86, 11);
				defaultInterpolatedStringHandler.AppendLiteral("[@确定/首饰系统_强化操作_");
				defaultInterpolatedStringHandler.AppendFormatted(list2[0][0]);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_1].物品ID);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].物品ID);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals6.sSQhRe0NUB.属性类别);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals6.sSQhRe0NUB.属性标识);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals6.sSQhRe0NUB.属性数值);
				defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:使用#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.首饰系统配置.强化材料名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n后#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n将立即进行#R1#n次随机属性强化，本次强化的成功率为#R");
				defaultInterpolatedStringHandler.AppendFormatted((double)list2[0][1] / 10.0);
				defaultInterpolatedStringHandler.AppendLiteral("%#n，是否继续？]");
				P_0.C_Send(i.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
				return true;
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int num2 = 0; num2 < P_0.user.背包数据.物品列表[P_2].装备属性列表.Count; num2++)
			{
				属性数据 属性数据2 = P_0.user.背包数据.物品列表[P_2].装备属性列表[num2];
				if ((属性数据2.属性类别 == 514 || 属性数据2.属性类别 == 770 || 属性数据2.属性类别 == 3074) && 问道数据类.属性名字字典.Contains(属性数据2.属性标识) && Singleton<全局变量类>.I.首饰系统配置.属性字典.TryGetValue($"{(AllEnums.属性名字Type)属性数据2.属性标识}", out 首饰强化配置类 value) && value.是否可用 && value.数值几率.Count > 0)
				{
					List<int[]> 数值几率 = value.数值几率;
					num = 数值几率[数值几率.Count - 1][0];
					if (属性数据2.属性数值 < num)
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(32, 10, stringBuilder2);
						handler.AppendLiteral("[【点击强化】");
						handler.AppendFormatted((AllEnums.属性名字Type)属性数据2.属性标识);
						handler.AppendLiteral(" ");
						handler.AppendFormatted(属性数据2.属性数值);
						handler.AppendLiteral("≤");
						handler.AppendFormatted(num);
						handler.AppendLiteral(" 增加/首饰系统_强化操作_0|");
						handler.AppendFormatted(P_1);
						handler.AppendLiteral("|");
						handler.AppendFormatted(P_2);
						handler.AppendLiteral("|");
						handler.AppendFormatted(P_0.user.背包数据.物品列表[P_1].物品ID);
						handler.AppendLiteral("|");
						handler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].物品ID);
						handler.AppendLiteral("|");
						handler.AppendFormatted(属性数据2.属性类别);
						handler.AppendLiteral("|");
						handler.AppendFormatted(属性数据2.属性标识);
						handler.AppendLiteral("|");
						handler.AppendFormatted(属性数据2.属性数值);
						handler.AppendLiteral("]");
						stringBuilder2.Append(ref handler);
					}
				}
			}
			if (stringBuilder.Length <= 0)
			{
				return false;
			}
			stringBuilder.Insert(0, "请选择你要强化的属性：#r");
			stringBuilder.Append("[我只是看看/离开]");
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, 0, "精精儿", stringBuilder.ToString()));
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("检测首饰是否可强化-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal async Task xQulSxS09g(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals91 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals91.tYrMHp7UIS = P_0;
		try
		{
			if (string.IsNullOrWhiteSpace(P_1))
			{
				CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("Error-01，首饰强化失误！"));
				return;
			}
			string[] array = P_1.Split('|');
			int result = 0;
			CS_0024_003C_003E8__locals91.CtUMruWhKU = 0;
			CS_0024_003C_003E8__locals91.AGOM4PPcEg = 0;
			CS_0024_003C_003E8__locals91.DXfMeaxQk3 = 0;
			首饰强化配置类 value = null;
			CS_0024_003C_003E8__locals91.QNmMqWVnTD = default(属性数据);
			if (Singleton<全局变量类>.I.首饰系统配置.随机强化开关)
			{
				if (array.Length != 2)
				{
					CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("Error-02，首饰强化失误！"));
					return;
				}
				if (!int.TryParse(array[0], out result) || !int.TryParse(array[1], out CS_0024_003C_003E8__locals91.CtUMruWhKU))
				{
					CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("Error-03，首饰强化失误！"));
					return;
				}
			}
			else
			{
				if (array.Length != 4)
				{
					CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("Error-04，首饰强化失误！"));
					return;
				}
				if (!int.TryParse(array[0], out result) || !int.TryParse(array[1], out CS_0024_003C_003E8__locals91.CtUMruWhKU) || !int.TryParse(array[2], out CS_0024_003C_003E8__locals91.AGOM4PPcEg) || !int.TryParse(array[3], out CS_0024_003C_003E8__locals91.DXfMeaxQk3))
				{
					CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("Error-05，首饰强化失误！"));
					return;
				}
				if (!问道数据类.属性名字字典.Contains(CS_0024_003C_003E8__locals91.DXfMeaxQk3))
				{
					CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("Error-06，首饰强化失误！"));
					return;
				}
				if (!Singleton<全局变量类>.I.首饰系统配置.属性字典.TryGetValue($"{(AllEnums.属性名字Type)CS_0024_003C_003E8__locals91.DXfMeaxQk3}", out value))
				{
					CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("Error-07，首饰强化失误！"));
					return;
				}
				CS_0024_003C_003E8__locals91.QNmMqWVnTD = CS_0024_003C_003E8__locals91.tYrMHp7UIS.user.背包数据.物品列表[CS_0024_003C_003E8__locals91.CtUMruWhKU].装备属性列表.Find( (属性数据 x) => x.属性类别 == CS_0024_003C_003E8__locals91.AGOM4PPcEg && x.属性标识 == CS_0024_003C_003E8__locals91.DXfMeaxQk3);
				if (CS_0024_003C_003E8__locals91.QNmMqWVnTD.属性类别 == 0)
				{
					CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("Error-08，首饰强化失误！"));
					return;
				}
			}
			if (!Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals91.tYrMHp7UIS, result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals91.tYrMHp7UIS, CS_0024_003C_003E8__locals91.CtUMruWhKU))
			{
				CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("Error-09，首饰强化失误！"));
				return;
			}
			if (CS_0024_003C_003E8__locals91.tYrMHp7UIS.user.背包数据.物品列表[result].物品ID == 0 || CS_0024_003C_003E8__locals91.tYrMHp7UIS.user.背包数据.物品列表[CS_0024_003C_003E8__locals91.CtUMruWhKU].物品ID == 0)
			{
				CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("Error-10，首饰强化失误！"));
				return;
			}
			if (!k75lmj6oKh(CS_0024_003C_003E8__locals91.tYrMHp7UIS, (byte)result, (byte)CS_0024_003C_003E8__locals91.CtUMruWhKU))
			{
				CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("Error-11，首饰强化失误！"));
				return;
			}
			if (value == null)
			{
				if (!Singleton<全局变量类>.I.首饰系统配置.随机强化开关)
				{
					CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("Error-12，首饰强化失误！"));
					return;
				}
				List<属性数据> list = CS_0024_003C_003E8__locals91.tYrMHp7UIS.user.背包数据.物品列表[CS_0024_003C_003E8__locals91.CtUMruWhKU].装备属性列表.FindAll( (属性数据 x) =>
				{
					_003C_003Ec__DisplayClass10_1 CS_0024_003C_003E8__locals93 = new _003C_003Ec__DisplayClass10_1();
					CS_0024_003C_003E8__locals93.k7iMzijyAj = x;
					return (CS_0024_003C_003E8__locals93.k7iMzijyAj.属性类别 == 514 || CS_0024_003C_003E8__locals93.k7iMzijyAj.属性类别 == 770 || CS_0024_003C_003E8__locals93.k7iMzijyAj.属性类别 == 3074) && Singleton<全局变量类>.I.首饰系统配置.属性字典.Any<KeyValuePair<string, 首饰强化配置类>>( (KeyValuePair<string, 首饰强化配置类> keyValuePair) =>
					{
						if (keyValuePair.Key == $"{(AllEnums.属性名字Type)CS_0024_003C_003E8__locals93.k7iMzijyAj.属性标识}" && keyValuePair.Value.是否可用 && keyValuePair.Value.数值几率.Count > 0)
						{
							List<int[]> 数值几率 = keyValuePair.Value.数值几率;
							return 数值几率[数值几率.Count - 1][0] > CS_0024_003C_003E8__locals93.k7iMzijyAj.属性数值;
						}
						return false;
					});
				});
				if (list.Count <= 0)
				{
					CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R首饰中没有可强化的属性。"));
					return;
				}
				CS_0024_003C_003E8__locals91.QNmMqWVnTD = list[Singleton<WdAPI>.I.qrjo9TWIdy(0, list.Count - 1)];
				Singleton<全局变量类>.I.首饰系统配置.属性字典.TryGetValue($"{(AllEnums.属性名字Type)CS_0024_003C_003E8__locals91.QNmMqWVnTD.属性标识}", out value);
				if (value == null || CS_0024_003C_003E8__locals91.QNmMqWVnTD.属性类别 == 0 || CS_0024_003C_003E8__locals91.QNmMqWVnTD.属性标识 == 0 || CS_0024_003C_003E8__locals91.QNmMqWVnTD.属性数值 == 0)
				{
					CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("Error-13，首饰强化失误！"));
					return;
				}
			}
			CS_0024_003C_003E8__locals91.DeCMZ3piFB = value.数值几率.Find( (int[] x) => x[0] > Math.Abs(CS_0024_003C_003E8__locals91.QNmMqWVnTD.属性数值));
			if (CS_0024_003C_003E8__locals91.DeCMZ3piFB == null)
			{
				CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R首饰中没有可强化的属性了。"));
				return;
			}
			int num = Singleton<WdAPI>.I.qrjo9TWIdy(CS_0024_003C_003E8__locals91.DeCMZ3piFB[1], (int)((float)CS_0024_003C_003E8__locals91.DeCMZ3piFB[1] * 1.5f));
			CS_0024_003C_003E8__locals91.r10Mt9SR1D = num - CS_0024_003C_003E8__locals91.tYrMHp7UIS.user.存档数据.精炼存档.首饰强化次数;
			if (CS_0024_003C_003E8__locals91.r10Mt9SR1D == 0)
			{
				CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前首饰已无可强化的属性了！"));
				return;
			}
			if (CS_0024_003C_003E8__locals91.r10Mt9SR1D < 0)
			{
				CS_0024_003C_003E8__locals91.r10Mt9SR1D = 1;
			}
			int 要使用次数 = ((CS_0024_003C_003E8__locals91.r10Mt9SR1D > CS_0024_003C_003E8__locals91.tYrMHp7UIS.user.背包数据.物品列表[result].数量) ? CS_0024_003C_003E8__locals91.tYrMHp7UIS.user.背包数据.物品列表[result].数量 : CS_0024_003C_003E8__locals91.r10Mt9SR1D);
			if (要使用次数 < CS_0024_003C_003E8__locals91.r10Mt9SR1D)
			{
				CS_0024_003C_003E8__locals91.tYrMHp7UIS.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(result, 要使用次数));
				CS_0024_003C_003E8__locals91.tYrMHp7UIS.user.存档数据.精炼存档.首饰强化次数 += 要使用次数;
				CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.QewoEwLLTD("首饰强化中", 1));
				await Task.Delay(1000);
				MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals91.tYrMHp7UIS;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
				defaultInterpolatedStringHandler.AppendLiteral("#R强化了");
				defaultInterpolatedStringHandler.AppendFormatted(要使用次数);
				defaultInterpolatedStringHandler.AppendLiteral("次失败！#n你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(要使用次数);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.首饰系统配置.强化材料名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				myNATSocketClient.C_Send(i.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_中心提醒("#R很遗憾，强化失败了！但是请不要沮丧，每一次的失败都是为了以后成功，加油！#21")).ToArray());
				return;
			}
			CS_0024_003C_003E8__locals91.tYrMHp7UIS.销毁回调事件 =  async (string v) =>
			{
				if (!(v != Singleton<全局变量类>.I.首饰系统配置.强化材料名字))
				{
					CS_0024_003C_003E8__locals91.tYrMHp7UIS.销毁回调事件 = null;
					CS_0024_003C_003E8__locals91.tYrMHp7UIS.user.存档数据.精炼存档.首饰强化次数 = 0;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(35, 5);
					defaultInterpolatedStringHandler2.AppendLiteral("#26天呐，#Y");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals91.tYrMHp7UIS.user.人物数据.昵称);
					defaultInterpolatedStringHandler2.AppendLiteral("#n的#Y");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals91.tYrMHp7UIS.user.背包数据.物品列表[CS_0024_003C_003E8__locals91.CtUMruWhKU].名字);
					defaultInterpolatedStringHandler2.AppendLiteral("#n成功强化！#G");
					defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性名字Type)CS_0024_003C_003E8__locals91.QNmMqWVnTD.属性标识);
					defaultInterpolatedStringHandler2.AppendLiteral(" ");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals91.QNmMqWVnTD.属性数值);
					defaultInterpolatedStringHandler2.AppendLiteral(" #Y→#G");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals91.DeCMZ3piFB[0]);
					defaultInterpolatedStringHandler2.AppendLiteral("#Y↑#G。");
					StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler2.ToStringAndClear());
					WdAPI i2 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals91.tYrMHp7UIS;
					int num2 = CS_0024_003C_003E8__locals91.CtUMruWhKU;
					defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性类别)CS_0024_003C_003E8__locals91.QNmMqWVnTD.属性类别);
					defaultInterpolatedStringHandler2.AppendLiteral("/");
					defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性标识Type)CS_0024_003C_003E8__locals91.QNmMqWVnTD.属性标识);
					i2.Mr8ICwW3qX(myNATSocketClient2, num2, defaultInterpolatedStringHandler2.ToStringAndClear(), CS_0024_003C_003E8__locals91.DeCMZ3piFB[0].ToString());
					CS_0024_003C_003E8__locals91.tYrMHp7UIS.C_Send(Singleton<WdAPI>.I.QewoEwLLTD("首饰强化中", 1));
					await Task.Delay(1000);
					MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals91.tYrMHp7UIS;
					WdAPI i3 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(23, 2);
					defaultInterpolatedStringHandler2.AppendLiteral("#Y强化成功！#n你消耗了#R");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals91.r10Mt9SR1D);
					defaultInterpolatedStringHandler2.AppendLiteral("#n个#R");
					defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.首饰系统配置.强化材料名字);
					defaultInterpolatedStringHandler2.AppendLiteral("#n。");
					myNATSocketClient3.C_Send(i3.提示_杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_中心提醒("#G首饰强化成功！")).ToArray());
					if (Singleton<全局变量类>.I.首饰系统配置.谣言开关)
					{
						Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(stringBuilder.ToString(), "管理员"));
					}
				}
			};
			CS_0024_003C_003E8__locals91.tYrMHp7UIS.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(result, CS_0024_003C_003E8__locals91.r10Mt9SR1D));
		}
		catch (Exception ex)
		{
			Log.Error("首饰强化事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void A6JlcWaPrH(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals26 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals26.SCHhwoXTub = P_0;
		try
		{
			if (string.IsNullOrWhiteSpace(P_1))
			{
				return;
			}
			string[] array = P_1.Split("|");
			if (array.Length != 4 || !int.TryParse(array[0], out var result) || !int.TryParse(array[1], out CS_0024_003C_003E8__locals26.L4ohbJbqIw) || !int.TryParse(array[2], out var result2) || !int.TryParse(array[3], out var result3) || result2 == 0 || result3 == 0 || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals26.SCHhwoXTub, result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals26.SCHhwoXTub, CS_0024_003C_003E8__locals26.L4ohbJbqIw) || !Singleton<全局变量类>.I.首饰系统配置.首饰降级开关 || CS_0024_003C_003E8__locals26.SCHhwoXTub.user.背包数据.物品列表[result].物品ID != result2 || CS_0024_003C_003E8__locals26.SCHhwoXTub.user.背包数据.物品列表[result].数量 < 1 || CS_0024_003C_003E8__locals26.SCHhwoXTub.user.背包数据.物品列表[CS_0024_003C_003E8__locals26.L4ohbJbqIw].物品ID != result3 || CS_0024_003C_003E8__locals26.SCHhwoXTub.user.背包数据.物品列表[CS_0024_003C_003E8__locals26.L4ohbJbqIw].数量 < 1)
			{
				return;
			}
			CS_0024_003C_003E8__locals26.lJHhJsm9lf = CS_0024_003C_003E8__locals26.SCHhwoXTub.user.背包数据.物品列表[CS_0024_003C_003E8__locals26.L4ohbJbqIw].等级 / 10 * 10;
			if (CS_0024_003C_003E8__locals26.lJHhJsm9lf < Singleton<全局变量类>.I.首饰系统配置.最低降级等级)
			{
				CS_0024_003C_003E8__locals26.lJHhJsm9lf = Singleton<全局变量类>.I.首饰系统配置.最低降级等级;
			}
			CS_0024_003C_003E8__locals26.SCHhwoXTub.销毁回调事件 =  (string v) =>
			{
				if (!(v != Singleton<全局变量类>.I.首饰系统配置.降级材料名字))
				{
					CS_0024_003C_003E8__locals26.SCHhwoXTub.销毁回调事件 = null;
					Singleton<WdAPI>.I.NNfIVUuyWv(CS_0024_003C_003E8__locals26.SCHhwoXTub, CS_0024_003C_003E8__locals26.L4ohbJbqIw, new List<string[]> { new string[2]
					{
						"req_level",
						CS_0024_003C_003E8__locals26.lJHhJsm9lf.ToString()
					} });
					MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals26.SCHhwoXTub;
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
					defaultInterpolatedStringHandler.AppendLiteral("你使用了#R");
					defaultInterpolatedStringHandler.AppendFormatted(v);
					defaultInterpolatedStringHandler.AppendLiteral("#n成功的将#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals26.SCHhwoXTub.user.背包数据.物品列表[CS_0024_003C_003E8__locals26.L4ohbJbqIw].名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n的等级降低至#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals26.lJHhJsm9lf);
					defaultInterpolatedStringHandler.AppendLiteral("#n级。");
					myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			};
			CS_0024_003C_003E8__locals26.SCHhwoXTub.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(result, 1));
		}
		catch (Exception ex)
		{
			Log.Error("首饰降级事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public cCs7kYlNIp7pmjCmEml()
	{
	}

	static cCs7kYlNIp7pmjCmEml()
	{
	}
}
