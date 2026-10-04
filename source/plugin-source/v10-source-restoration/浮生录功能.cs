using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Serilog;
using VcF0pbBvJqp0x0IfwN;
using vEAdPGPTkDFOYsbi303;

public class 浮生录功能 : Singleton<浮生录功能>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public AllEnums.化身分类 gtUc4eGyB1;

		
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		
		internal bool ddvcHIxLmu(浮生化身配置类 x)
		{
			return x.分类 == gtUc4eGyB1;
		}

		static _003C_003Ec__DisplayClass23_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public MyNATSocketClient qHVcq68yBJ;

		public AllEnums.化身分类 z0lcrX7jBP;

		public int OSScZvtIYG;

		public Predicate<浮生化身配置类> aM3ct8698W;

		
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		
		internal bool XpOceU0wrO(浮生化身配置类 x)
		{
			return x.分类 == z0lcrX7jBP;
		}

		static _003C_003Ec__DisplayClass24_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_1
	{
		public int viuczWNo4y;

		public _003C_003Ec__DisplayClass24_0 Q8ynuWyi2A;

		
		public _003C_003Ec__DisplayClass24_1()
		{
		}

		
		internal async void V2ncAV2a6i(string v)
		{
			if (v != Singleton<全局变量类>.I.浮生录配置.道具名字)
			{
				return;
			}
			Q8ynuWyi2A.qHVcq68yBJ.销毁回调事件 = null;
			MyNATSocketClient myNATSocketClient = Q8ynuWyi2A.qHVcq68yBJ;
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
			defaultInterpolatedStringHandler.AppendFormatted(viuczWNo4y);
			defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n。");
			myNATSocketClient.C_Send(i.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			List<浮生化身配置类> list = Singleton<全局变量类>.I.浮生录配置.化身列表.Values.ToList().FindAll( (浮生化身配置类 x) => x.分类 == Q8ynuWyi2A.z0lcrX7jBP);
			List<浮生化身配置类> list2 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.五星);
			List<浮生化身配置类> list3 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.四星);
			List<浮生化身配置类> list4 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.三星);
			List<浮生化身配置类> list5 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.二星);
			List<浮生化身配置类> list6 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.一星);
			_ = string.Empty;
			for (int num = 0; num < Q8ynuWyi2A.OSScZvtIYG; num++)
			{
				int num2 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 1000);
				Q8ynuWyi2A.qHVcq68yBJ.user.存档数据.浮生录数据.抽取次数++;
				if (Q8ynuWyi2A.qHVcq68yBJ.user.存档数据.浮生录数据.抽取次数 >= 100)
				{
					num2 = Singleton<全局变量类>.I.浮生录配置.五星化身抽取几率;
				}
				if (num2 == Singleton<全局变量类>.I.浮生录配置.五星化身抽取几率 && list2.Count > 0)
				{
					Q8ynuWyi2A.qHVcq68yBJ.user.存档数据.浮生录数据.抽取次数 = 0;
					string 化身名字 = list2[Singleton<WdAPI>.I.qrjo9TWIdy(0, list2.Count - 1)].化身名字;
					if (Singleton<WdAPI>.I.PndoGw5lW7(Q8ynuWyi2A.qHVcq68yBJ, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
					{
						Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
					}
					Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件 != null)
					{
						WdAPI i2 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜#Y");
						defaultInterpolatedStringHandler.AppendFormatted(Q8ynuWyi2A.qHVcq68yBJ.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n在浮生录活动中抽取到了#O五星#n的#Y");
						defaultInterpolatedStringHandler.AppendFormatted(化身名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n，真是气运滔天啊！");
						client频道事件(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
				}
				else if (num2 > Singleton<全局变量类>.I.浮生录配置.五星化身抽取几率 && num2 <= Singleton<全局变量类>.I.浮生录配置.四星化身抽取几率 && list3.Count > 0)
				{
					string 化身名字 = list3[Singleton<WdAPI>.I.qrjo9TWIdy(0, list3.Count - 1)].化身名字;
					if (Singleton<WdAPI>.I.PndoGw5lW7(Q8ynuWyi2A.qHVcq68yBJ, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
					{
						Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
					}
					Action<byte[]> client频道事件2 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件2 != null)
					{
						WdAPI i3 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜#Y");
						defaultInterpolatedStringHandler.AppendFormatted(Q8ynuWyi2A.qHVcq68yBJ.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n在浮生录活动中抽取到了#O四星#n的#Y");
						defaultInterpolatedStringHandler.AppendFormatted(化身名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n，真是好运气啊！");
						client频道事件2(i3.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
				}
				else if (num2 > Singleton<全局变量类>.I.浮生录配置.四星化身抽取几率 && num2 <= Singleton<全局变量类>.I.浮生录配置.三星化身抽取几率 && list4.Count > 0)
				{
					string 化身名字 = list4[Singleton<WdAPI>.I.qrjo9TWIdy(0, list4.Count - 1)].化身名字;
					if (Singleton<WdAPI>.I.PndoGw5lW7(Q8ynuWyi2A.qHVcq68yBJ, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
					{
						Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
					}
				}
				else if (num2 > Singleton<全局变量类>.I.浮生录配置.三星化身抽取几率 && num2 <= Singleton<全局变量类>.I.浮生录配置.二星化身抽取几率 && list5.Count > 0)
				{
					string 化身名字 = list5[Singleton<WdAPI>.I.qrjo9TWIdy(0, list5.Count - 1)].化身名字;
					if (Singleton<WdAPI>.I.PndoGw5lW7(Q8ynuWyi2A.qHVcq68yBJ, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
					{
						Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
					}
				}
				else if (list6.Count > 0)
				{
					string 化身名字 = list6[Singleton<WdAPI>.I.qrjo9TWIdy(0, list6.Count - 1)].化身名字;
					if (Singleton<WdAPI>.I.PndoGw5lW7(Q8ynuWyi2A.qHVcq68yBJ, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
					{
						Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
					}
				}
				await Task.Delay(50);
			}
		}

		static _003C_003Ec__DisplayClass24_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public MyNATSocketClient iijnb0jHJ3;

		public 浮生化身配置类 K9VnJQrjlQ;

		public int sTPnKBQqwM;

		
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		
		internal void Pu3nwpUB1C(string v)
		{
			if (!(v != K9VnJQrjlQ.化身名字))
			{
				iijnb0jHJ3.销毁回调事件 = null;
				if (Singleton<WdAPI>.I.PndoGw5lW7(iijnb0jHJ3, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.浮生录配置.道具名字, AllEnums.指令Type.无, sTPnKBQqwM * K9VnJQrjlQ.碎化数量, false, "化身碎化"))
				{
					MyNATSocketClient myNATSocketClient = iijnb0jHJ3;
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 4);
					defaultInterpolatedStringHandler.AppendLiteral("你成功碎化了#R");
					defaultInterpolatedStringHandler.AppendFormatted(sTPnKBQqwM);
					defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
					defaultInterpolatedStringHandler.AppendFormatted(K9VnJQrjlQ.化身名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n，获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
					defaultInterpolatedStringHandler.AppendLiteral("*");
					defaultInterpolatedStringHandler.AppendFormatted(sTPnKBQqwM * K9VnJQrjlQ.碎化数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					byte[] first = i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear());
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
					defaultInterpolatedStringHandler.AppendLiteral("*");
					defaultInterpolatedStringHandler.AppendFormatted(sTPnKBQqwM * K9VnJQrjlQ.碎化数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					myNATSocketClient.C_Send(first.Concat(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
				}
			}
		}

		static _003C_003Ec__DisplayClass25_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public 浮生化身配置类 riCnUD8hO7;

		public MyNATSocketClient PIjnWu6iHE;

		public 浮生录存档类 SsbngqNyUD;

		
		public _003C_003Ec__DisplayClass27_0()
		{
		}

		
		internal bool v1JnRRxBVp(浮生录化身列表类 x)
		{
			if (x.分类 == riCnUD8hO7.分类)
			{
				return x.激活进度 >= 100;
			}
			return false;
		}

		
		internal bool HhTndcfgwm(浮生化身配置类 x)
		{
			return x.分类 == riCnUD8hO7.分类;
		}

		
		internal bool JKGnsbHHtN(浮生录化身列表类 x)
		{
			if (x.分类 == riCnUD8hO7.分类)
			{
				return x.激活进度 >= 100;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass27_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_1
	{
		public 相性池 dxXnjNjqvp;

		public _003C_003Ec__DisplayClass27_0 rSSnldQiDX;

		
		public _003C_003Ec__DisplayClass27_1()
		{
		}

		
		internal void WLxnD5XNM9(string v)
		{
			if (!(v != rSSnldQiDX.riCnUD8hO7.化身名字))
			{
				rSSnldQiDX.PIjnWu6iHE.销毁回调事件 = null;
				if (dxXnjNjqvp.金 > 0)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(rSSnldQiDX.PIjnWu6iHE, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.metal, dxXnjNjqvp.金, false, "[浮生录]属性增加");
				}
				if (dxXnjNjqvp.木 > 0)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(rSSnldQiDX.PIjnWu6iHE, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.wood, dxXnjNjqvp.木, false, "[浮生录]属性增加");
				}
				if (dxXnjNjqvp.水 > 0)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(rSSnldQiDX.PIjnWu6iHE, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.water, dxXnjNjqvp.水, false, "[浮生录]属性增加");
				}
				if (dxXnjNjqvp.火 > 0)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(rSSnldQiDX.PIjnWu6iHE, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.fire, dxXnjNjqvp.火, false, "[浮生录]属性增加");
				}
				if (dxXnjNjqvp.土 > 0)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(rSSnldQiDX.PIjnWu6iHE, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.earth, dxXnjNjqvp.土, false, "[浮生录]属性增加");
				}
				rSSnldQiDX.SsbngqNyUD.浮生属性.金相性 += dxXnjNjqvp.金;
				rSSnldQiDX.SsbngqNyUD.浮生属性.木相性 += dxXnjNjqvp.木;
				rSSnldQiDX.SsbngqNyUD.浮生属性.水相性 += dxXnjNjqvp.水;
				rSSnldQiDX.SsbngqNyUD.浮生属性.火相性 += dxXnjNjqvp.火;
				rSSnldQiDX.SsbngqNyUD.浮生属性.土相性 += dxXnjNjqvp.土;
				switch (rSSnldQiDX.riCnUD8hO7.分类)
				{
				case AllEnums.化身分类.乱世书:
				{
					MyNATSocketClient myNATSocketClient5 = rSSnldQiDX.PIjnWu6iHE;
					WdAPI i5 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#G恭喜你#Y");
					defaultInterpolatedStringHandler.AppendFormatted(rSSnldQiDX.riCnUD8hO7.分类);
					defaultInterpolatedStringHandler.AppendLiteral("#G所有化身激活完成，获得了#G");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乱世书属性);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乱世书数值);
					defaultInterpolatedStringHandler.AppendLiteral(" 增加#n的属性奖励！");
					myNATSocketClient5.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.化身分类.千钧卷:
				{
					MyNATSocketClient myNATSocketClient4 = rSSnldQiDX.PIjnWu6iHE;
					WdAPI i4 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#G恭喜你#Y");
					defaultInterpolatedStringHandler.AppendFormatted(rSSnldQiDX.riCnUD8hO7.分类);
					defaultInterpolatedStringHandler.AppendLiteral("#G所有化身激活完成，获得了#G");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.千钧卷属性);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.千钧卷数值);
					defaultInterpolatedStringHandler.AppendLiteral(" 增加#n的属性奖励！");
					myNATSocketClient4.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.化身分类.灵虚卷:
				{
					MyNATSocketClient myNATSocketClient3 = rSSnldQiDX.PIjnWu6iHE;
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#G恭喜你#Y");
					defaultInterpolatedStringHandler.AppendFormatted(rSSnldQiDX.riCnUD8hO7.分类);
					defaultInterpolatedStringHandler.AppendLiteral("#G所有化身激活完成，获得了#G");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.灵虚卷属性);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.灵虚卷数值);
					defaultInterpolatedStringHandler.AppendLiteral(" 增加#n的属性奖励！");
					myNATSocketClient3.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.化身分类.御元卷:
				{
					MyNATSocketClient myNATSocketClient2 = rSSnldQiDX.PIjnWu6iHE;
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#G恭喜你#Y");
					defaultInterpolatedStringHandler.AppendFormatted(rSSnldQiDX.riCnUD8hO7.分类);
					defaultInterpolatedStringHandler.AppendLiteral("#G所有化身激活完成，获得了#G");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.御元卷属性);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.御元卷数值);
					defaultInterpolatedStringHandler.AppendLiteral(" 增加#n的属性奖励！");
					myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.化身分类.乘风卷:
				{
					MyNATSocketClient myNATSocketClient = rSSnldQiDX.PIjnWu6iHE;
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#G恭喜你#Y");
					defaultInterpolatedStringHandler.AppendFormatted(rSSnldQiDX.riCnUD8hO7.分类);
					defaultInterpolatedStringHandler.AppendLiteral("#G所有化身激活完成，获得了#G");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乘风卷属性);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乘风卷数值);
					defaultInterpolatedStringHandler.AppendLiteral(" 增加#n的属性奖励！");
					myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				}
			}
		}

		static _003C_003Ec__DisplayClass27_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public 浮生化身配置类 dhVnNqpfEY;

		public MyNATSocketClient hBonikvueB;

		public 浮生录存档类 BWwnBFrOpS;

		public Func<浮生录化身列表类, bool> cHhnGR7MD6;

		
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		
		internal bool KPPn81a4mK(浮生录化身列表类 x)
		{
			if (x.分类 == dhVnNqpfEY.分类)
			{
				return x.激活进度 >= 100;
			}
			return false;
		}

		
		internal bool U2QnIjtnm4(浮生化身配置类 x)
		{
			return x.分类 == dhVnNqpfEY.分类;
		}

		
		internal bool Gn0no1ySSg(浮生录化身列表类 x)
		{
			if (x.分类 == dhVnNqpfEY.分类)
			{
				return x.激活进度 >= 100;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass28_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_1
	{
		public int jbGn6JfMA4;

		public int ux7n2ZvaHi;

		public _003C_003Ec__DisplayClass28_0 eu2nmrPAhD;

		
		public _003C_003Ec__DisplayClass28_1()
		{
		}

		
		internal void n1cnfRmI74(string v)
		{
			if (v != eu2nmrPAhD.dhVnNqpfEY.化身名字)
			{
				return;
			}
			eu2nmrPAhD.hBonikvueB.销毁回调事件 = null;
			List<string[]> list = new List<string[]>();
			eu2nmrPAhD.hBonikvueB.user.存档数据.中州论道存档.jxpIgn1imh(eu2nmrPAhD.dhVnNqpfEY.属性名字, eu2nmrPAhD.dhVnNqpfEY.属性数值, out var text);
			string[] array = new string[2];
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler.AppendLiteral("prop/");
			defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)eu2nmrPAhD.dhVnNqpfEY.属性名字);
			array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
			array[1] = text;
			list.Add(array);
			jbGn6JfMA4 = eu2nmrPAhD.BWwnBFrOpS.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == eu2nmrPAhD.dhVnNqpfEY.分类 && x.激活进度 >= 100);
			if (jbGn6JfMA4 >= ux7n2ZvaHi)
			{
				switch (eu2nmrPAhD.dhVnNqpfEY.分类)
				{
				case AllEnums.化身分类.乱世书:
				{
					eu2nmrPAhD.hBonikvueB.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制乱世书属性, Singleton<全局变量类>.I.浮生录配置.乱世书数值, out text);
					string[] array6 = new string[2];
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制乱世书属性);
					array6[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array6[1] = text;
					list.Add(array6);
					MyNATSocketClient myNATSocketClient5 = eu2nmrPAhD.hBonikvueB;
					WdAPI i5 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#G恭喜你#Y");
					defaultInterpolatedStringHandler.AppendFormatted(eu2nmrPAhD.dhVnNqpfEY.分类);
					defaultInterpolatedStringHandler.AppendLiteral("#G所有化身激活完成，获得了#G");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制乱世书属性);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乱世书数值);
					defaultInterpolatedStringHandler.AppendLiteral(" 增加#n的属性奖励！");
					myNATSocketClient5.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.化身分类.千钧卷:
				{
					eu2nmrPAhD.hBonikvueB.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性, Singleton<全局变量类>.I.浮生录配置.千钧卷数值, out text);
					string[] array5 = new string[2];
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性);
					array5[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array5[1] = text;
					list.Add(array5);
					MyNATSocketClient myNATSocketClient4 = eu2nmrPAhD.hBonikvueB;
					WdAPI i4 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#G恭喜你#Y");
					defaultInterpolatedStringHandler.AppendFormatted(eu2nmrPAhD.dhVnNqpfEY.分类);
					defaultInterpolatedStringHandler.AppendLiteral("#G所有化身激活完成，获得了#G");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.千钧卷数值);
					defaultInterpolatedStringHandler.AppendLiteral(" 增加#n的属性奖励！");
					myNATSocketClient4.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.化身分类.灵虚卷:
				{
					eu2nmrPAhD.hBonikvueB.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性, Singleton<全局变量类>.I.浮生录配置.灵虚卷数值, out text);
					string[] array4 = new string[2];
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性);
					array4[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array4[1] = text;
					list.Add(array4);
					MyNATSocketClient myNATSocketClient3 = eu2nmrPAhD.hBonikvueB;
					WdAPI i3 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#G恭喜你#Y");
					defaultInterpolatedStringHandler.AppendFormatted(eu2nmrPAhD.dhVnNqpfEY.分类);
					defaultInterpolatedStringHandler.AppendLiteral("#G所有化身激活完成，获得了#G");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.灵虚卷数值);
					defaultInterpolatedStringHandler.AppendLiteral(" 增加#n的属性奖励！");
					myNATSocketClient3.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.化身分类.御元卷:
				{
					eu2nmrPAhD.hBonikvueB.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制御元卷属性, Singleton<全局变量类>.I.浮生录配置.御元卷数值, out text);
					string[] array3 = new string[2];
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制御元卷属性);
					array3[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array3[1] = text;
					list.Add(array3);
					MyNATSocketClient myNATSocketClient2 = eu2nmrPAhD.hBonikvueB;
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#G恭喜你#Y");
					defaultInterpolatedStringHandler.AppendFormatted(eu2nmrPAhD.dhVnNqpfEY.分类);
					defaultInterpolatedStringHandler.AppendLiteral("#G所有化身激活完成，获得了#G");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制御元卷属性);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.御元卷数值);
					defaultInterpolatedStringHandler.AppendLiteral(" 增加#n的属性奖励！");
					myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.化身分类.乘风卷:
				{
					eu2nmrPAhD.hBonikvueB.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性, Singleton<全局变量类>.I.浮生录配置.乘风卷数值, out text);
					string[] array2 = new string[2];
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性);
					array2[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[1] = text;
					list.Add(array2);
					MyNATSocketClient myNATSocketClient = eu2nmrPAhD.hBonikvueB;
					WdAPI i = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#G恭喜你#Y");
					defaultInterpolatedStringHandler.AppendFormatted(eu2nmrPAhD.dhVnNqpfEY.分类);
					defaultInterpolatedStringHandler.AppendLiteral("#G所有化身激活完成，获得了#G");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乘风卷数值);
					defaultInterpolatedStringHandler.AppendLiteral(" 增加#n的属性奖励！");
					myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				}
				eu2nmrPAhD.BWwnBFrOpS.is全部激活 = eu2nmrPAhD.BWwnBFrOpS.化身列表.Values.Count( (浮生录化身列表类 x) => x.激活进度 >= 100) >= Singleton<全局变量类>.I.浮生录配置.化身列表.Count;
			}
			Singleton<fuMNpgieFTYU3Wah53>.I.mMMfZ3LX2(eu2nmrPAhD.hBonikvueB, list);
		}

		static _003C_003Ec__DisplayClass28_1()
		{
		}
	}

	internal IEnumerable<byte> WC9WKS8VyR;

	internal static ConcurrentDictionary<AllEnums.化身分类, 相性池> XgSWRaXXjY;

	internal List<浮生化身配置类> Ih6WdCmIqb;

	internal List<浮生化身配置类> CsTWsdbKp5;

	internal List<浮生化身配置类> nppWUisDdB;

	internal List<浮生化身配置类> RNoWWSOvFy;

	internal List<浮生化身配置类> LHGWgAIE0Z;

	
	[SpecialName]
	internal static bool J7aWuMQOCf()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is定制浮生)
		{
			return Singleton<全局变量类>.I.浮生录配置.定制功能开关;
		}
		return false;
	}

	
	[SpecialName]
	internal static bool GrAWb1KahR()
	{
		if (!J7aWuMQOCf())
		{
			return Singleton<全局变量类>.I.浮生录配置.功能开关;
		}
		return true;
	}

	
	internal void IPCUV1PLI0()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("浮生录配置类.json")))
			{
				Singleton<全局变量类>.I.浮生录配置 = JsonConvert.DeserializeObject<浮生录配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("浮生录配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.浮生录配置 = new 浮生录配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("浮生录配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.浮生录配置, Formatting.Indented));
			}
			Ih6WdCmIqb.Clear();
			CsTWsdbKp5.Clear();
			nppWUisDdB.Clear();
			RNoWWSOvFy.Clear();
			LHGWgAIE0Z.Clear();
			foreach (浮生化身配置类 value6 in Singleton<全局变量类>.I.浮生录配置.化身列表.Values)
			{
				if (value6.分类 == AllEnums.化身分类.乱世书)
				{
					Ih6WdCmIqb.Add(value6);
				}
				if (value6.分类 == AllEnums.化身分类.千钧卷)
				{
					CsTWsdbKp5.Add(value6);
				}
				if (value6.分类 == AllEnums.化身分类.灵虚卷)
				{
					nppWUisDdB.Add(value6);
				}
				if (value6.分类 == AllEnums.化身分类.御元卷)
				{
					RNoWWSOvFy.Add(value6);
				}
				if (value6.分类 == AllEnums.化身分类.乘风卷)
				{
					LHGWgAIE0Z.Add(value6);
				}
			}
			XgSWRaXXjY.Clear();
			XgSWRaXXjY.TryAdd(AllEnums.化身分类.乱世书, default(相性池));
			XgSWRaXXjY.TryAdd(AllEnums.化身分类.千钧卷, default(相性池));
			XgSWRaXXjY.TryAdd(AllEnums.化身分类.灵虚卷, default(相性池));
			XgSWRaXXjY.TryAdd(AllEnums.化身分类.御元卷, default(相性池));
			XgSWRaXXjY.TryAdd(AllEnums.化身分类.乘风卷, default(相性池));
			if (XgSWRaXXjY.TryGetValue(AllEnums.化身分类.乱世书, out var value))
			{
				switch (Singleton<全局变量类>.I.浮生录配置.乱世书属性)
				{
				case AllEnums.属性Type.金相性:
					value.金 = Singleton<全局变量类>.I.浮生录配置.乱世书数值;
					break;
				case AllEnums.属性Type.木相性:
					value.木 = Singleton<全局变量类>.I.浮生录配置.乱世书数值;
					break;
				case AllEnums.属性Type.水相性:
					value.水 = Singleton<全局变量类>.I.浮生录配置.乱世书数值;
					break;
				case AllEnums.属性Type.火相性:
					value.火 = Singleton<全局变量类>.I.浮生录配置.乱世书数值;
					break;
				case AllEnums.属性Type.土相性:
					value.土 = Singleton<全局变量类>.I.浮生录配置.乱世书数值;
					break;
				case AllEnums.属性Type.所有相性:
					value.金 = Singleton<全局变量类>.I.浮生录配置.乱世书数值;
					value.木 = Singleton<全局变量类>.I.浮生录配置.乱世书数值;
					value.水 = Singleton<全局变量类>.I.浮生录配置.乱世书数值;
					value.火 = Singleton<全局变量类>.I.浮生录配置.乱世书数值;
					value.土 = Singleton<全局变量类>.I.浮生录配置.乱世书数值;
					break;
				}
				XgSWRaXXjY[AllEnums.化身分类.乱世书] = value;
			}
			if (XgSWRaXXjY.TryGetValue(AllEnums.化身分类.千钧卷, out var value2))
			{
				switch (Singleton<全局变量类>.I.浮生录配置.千钧卷属性)
				{
				case AllEnums.属性Type.金相性:
					value2.金 = Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
					break;
				case AllEnums.属性Type.木相性:
					value2.木 = Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
					break;
				case AllEnums.属性Type.水相性:
					value2.水 = Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
					break;
				case AllEnums.属性Type.火相性:
					value2.火 = Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
					break;
				case AllEnums.属性Type.土相性:
					value2.土 = Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
					break;
				case AllEnums.属性Type.所有相性:
					value2.金 = Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
					value2.木 = Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
					value2.水 = Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
					value2.火 = Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
					value2.土 = Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
					break;
				}
				XgSWRaXXjY[AllEnums.化身分类.千钧卷] = value2;
			}
			if (XgSWRaXXjY.TryGetValue(AllEnums.化身分类.灵虚卷, out var value3))
			{
				switch (Singleton<全局变量类>.I.浮生录配置.灵虚卷属性)
				{
				case AllEnums.属性Type.金相性:
					value3.金 = Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
					break;
				case AllEnums.属性Type.木相性:
					value3.木 = Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
					break;
				case AllEnums.属性Type.水相性:
					value3.水 = Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
					break;
				case AllEnums.属性Type.火相性:
					value3.火 = Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
					break;
				case AllEnums.属性Type.土相性:
					value3.土 = Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
					break;
				case AllEnums.属性Type.所有相性:
					value3.金 = Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
					value3.木 = Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
					value3.水 = Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
					value3.火 = Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
					value3.土 = Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
					break;
				}
				XgSWRaXXjY[AllEnums.化身分类.灵虚卷] = value3;
			}
			if (XgSWRaXXjY.TryGetValue(AllEnums.化身分类.御元卷, out var value4))
			{
				switch (Singleton<全局变量类>.I.浮生录配置.御元卷属性)
				{
				case AllEnums.属性Type.金相性:
					value4.金 = Singleton<全局变量类>.I.浮生录配置.御元卷数值;
					break;
				case AllEnums.属性Type.木相性:
					value4.木 = Singleton<全局变量类>.I.浮生录配置.御元卷数值;
					break;
				case AllEnums.属性Type.水相性:
					value4.水 = Singleton<全局变量类>.I.浮生录配置.御元卷数值;
					break;
				case AllEnums.属性Type.火相性:
					value4.火 = Singleton<全局变量类>.I.浮生录配置.御元卷数值;
					break;
				case AllEnums.属性Type.土相性:
					value4.土 = Singleton<全局变量类>.I.浮生录配置.御元卷数值;
					break;
				case AllEnums.属性Type.所有相性:
					value4.金 = Singleton<全局变量类>.I.浮生录配置.御元卷数值;
					value4.木 = Singleton<全局变量类>.I.浮生录配置.御元卷数值;
					value4.水 = Singleton<全局变量类>.I.浮生录配置.御元卷数值;
					value4.火 = Singleton<全局变量类>.I.浮生录配置.御元卷数值;
					value4.土 = Singleton<全局变量类>.I.浮生录配置.御元卷数值;
					break;
				}
				XgSWRaXXjY[AllEnums.化身分类.御元卷] = value4;
			}
			if (XgSWRaXXjY.TryGetValue(AllEnums.化身分类.乘风卷, out var value5))
			{
				switch (Singleton<全局变量类>.I.浮生录配置.乘风卷属性)
				{
				case AllEnums.属性Type.金相性:
					value5.金 = Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
					break;
				case AllEnums.属性Type.木相性:
					value5.木 = Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
					break;
				case AllEnums.属性Type.水相性:
					value5.水 = Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
					break;
				case AllEnums.属性Type.火相性:
					value5.火 = Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
					break;
				case AllEnums.属性Type.土相性:
					value5.土 = Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
					break;
				case AllEnums.属性Type.所有相性:
					value5.金 = Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
					value5.木 = Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
					value5.水 = Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
					value5.火 = Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
					value5.土 = Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
					break;
				}
				XgSWRaXXjY[AllEnums.化身分类.乘风卷] = value5;
			}
			NPC初始化();
		}
		catch (Exception ex)
		{
			Log.Error("浮生录配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void v2hUkDkTda()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("浮生录配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.浮生录配置, Formatting.Indented));
			Log.Debug("浮生录配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("浮生录配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string zu8U03iVFQ()
	{
		IPCUV1PLI0();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.浮生录配置, Formatting.Indented);
	}

	
	public void JsonTo配置(string value)
	{
		Singleton<全局变量类>.I.浮生录配置 = JsonConvert.DeserializeObject<浮生录配置类>(value);
		v2hUkDkTda();
	}

	
	public void NPC初始化()
	{
		WC9WKS8VyR = (GrAWb1KahR() ? ((IEnumerable<byte>)Singleton<WdAPI>.I.组包假NPC站街(Singleton<全局变量类>.I.浮生录配置.NPC数据, 104)) : ((IEnumerable<byte>)Array.Empty<byte>()));
	}

	
	internal void KbNUOy4Ia4(MyNATSocketClient P_0)
	{
		try
		{
			if (!P_0.user.缓存数据.is使用仙灵卡)
			{
				StringBuilder stringBuilder = new StringBuilder("大梦谁先觉，平生不自知！本天尊在线为各位道友服务#r#Y各位道友可在本天尊处提交化身激活属性，每个分卷的所有化身激活度达到100%时即可获得该总卷的加护属性#r#L可提交多余的化身进行碎化，也可进行化身抽取，右键点击背包的化身即可查看详细信息#r");
				if (GrAWb1KahR())
				{
					stringBuilder.Append("[【查询】浮生录化身查询/浮生录_化身查询][【抽取】浮生录化身抽取/浮生录_化身抽取][【碎化】浮生录化身碎化/浮生录_化身碎化][【提交】浮生录化身激活/浮生录_化身提交][【提交】背包化身全部提交/浮生录_化身提交全部][【提交】背包化身全部碎化/浮生录_化身碎化全部]");
				}
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.浮生录配置.NPC数据.npcid, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc形象, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字, stringBuilder.ToString()));
			}
		}
		catch (Exception ex)
		{
			Log.Error("NPC对话生成-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal bool V6GUQkKJV4(MyNATSocketClient P_0)
	{
		try
		{
			if (!GrAWb1KahR())
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("很抱歉，浮生录功能暂未开启，敬请等待"));
				return false;
			}
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#G欢迎使用浮生录系统，阅读系统介绍可以快速了解该项功能使用。"));
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("打开浮生录面板-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal void cw9UEXjGLr(MyNATSocketClient P_0, int P_1)
	{
		try
		{
			if (!GrAWb1KahR())
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("很抱歉，浮生录功能暂未开启，敬请等待"));
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(114, 1, stringBuilder2);
			handler.AppendLiteral("#G【浮生录化身系统】#n抽取到的化身可以提交给#Y");
			handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字);
			handler.AppendLiteral("#n激活化身属性，当激活度达到#R100%#n时即可选择加护该化身的属性，并且无法再次提交。#r#M温馨提示：任务列表中可查看当前激活进度，并且可使用一键提交当前背包内所有化身");
			stringBuilder3.Append(ref handler);
			if (P_1 < 0)
			{
				stringBuilder.Append("[抽取化身（乱世书）/浮生录_化身抽取乱世书][抽取化身（千钧卷）/浮生录_化身抽取千钧卷][抽取化身（灵虚卷）/浮生录_化身抽取灵虚卷][抽取化身（御元卷）/浮生录_化身抽取御元卷][抽取化身（乘风卷）/浮生录_化身抽取乘风卷]");
			}
			else
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
				handler.AppendLiteral("#r#Y当前选择抽取化身分卷：#G");
				handler.AppendFormatted((AllEnums.化身分类)P_1);
				handler.AppendLiteral("#n");
				stringBuilder4.Append(ref handler);
				if (Singleton<全局变量类>.I.浮生录配置.is数值抽取)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(22, 3, stringBuilder2);
					handler.AppendLiteral("[抽一次（消耗");
					handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.数值消耗);
					handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.数值类型);
					handler.AppendLiteral("）/浮生录_化身抽取");
					handler.AppendFormatted((AllEnums.化身分类)P_1);
					handler.AppendLiteral("数值一次]");
					stringBuilder5.Append(ref handler);
					if (Singleton<全局变量类>.I.浮生录配置.is数值连抽)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder6 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(70, 9, stringBuilder2);
						handler.AppendLiteral("[抽十次（消耗");
						handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.数值消耗 * 10);
						handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.数值类型);
						handler.AppendLiteral("）/浮生录_化身抽取");
						handler.AppendFormatted((AllEnums.化身分类)P_1);
						handler.AppendLiteral("数值十次][抽五十次（消耗");
						handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.数值消耗 * 50);
						handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.数值类型);
						handler.AppendLiteral("）/浮生录_化身抽取");
						handler.AppendFormatted((AllEnums.化身分类)P_1);
						handler.AppendLiteral("数值五十次][抽一百次（消耗");
						handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.数值消耗 * 100);
						handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.数值类型);
						handler.AppendLiteral("）/浮生录_化身抽取");
						handler.AppendFormatted((AllEnums.化身分类)P_1);
						handler.AppendLiteral("数值一百次]");
						stringBuilder6.Append(ref handler);
					}
				}
				if (Singleton<全局变量类>.I.浮生录配置.is道具连抽)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(23, 3, stringBuilder2);
					handler.AppendLiteral("[抽一次（消耗");
					handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具消耗);
					handler.AppendLiteral("个");
					handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
					handler.AppendLiteral("）/浮生录_化身抽取");
					handler.AppendFormatted((AllEnums.化身分类)P_1);
					handler.AppendLiteral("道具一次]");
					stringBuilder7.Append(ref handler);
					if (Singleton<全局变量类>.I.浮生录配置.is道具连抽)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder8 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(70, 9, stringBuilder2);
						handler.AppendLiteral("[抽十次（消耗");
						handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具消耗 * 10);
						handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
						handler.AppendLiteral("）/浮生录_化身抽取");
						handler.AppendFormatted((AllEnums.化身分类)P_1);
						handler.AppendLiteral("道具十次][抽五十次（消耗");
						handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具消耗 * 50);
						handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
						handler.AppendLiteral("）/浮生录_化身抽取");
						handler.AppendFormatted((AllEnums.化身分类)P_1);
						handler.AppendLiteral("道具五十次][抽一百次（消耗");
						handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具消耗 * 100);
						handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
						handler.AppendLiteral("）/浮生录_化身抽取");
						handler.AppendFormatted((AllEnums.化身分类)P_1);
						handler.AppendLiteral("道具一百次]");
						stringBuilder8.Append(ref handler);
					}
				}
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.浮生录配置.NPC数据.npcid, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc形象, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("抽取浮生录化身-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string y18U3GO5oJ(MyNATSocketClient P_0, 浮生化身配置类 P_1)
	{
		try
		{
			浮生录存档类 obj = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.浮生录数据.方案1 : P_0.user.存档数据.浮生录数据.方案2);
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(48, 5, stringBuilder2);
			handler.AppendLiteral("#r#Y化身名字：#L");
			handler.AppendFormatted(P_1.化身名字);
			handler.AppendLiteral("#r#Y化身分类：#L");
			handler.AppendFormatted(P_1.分类);
			handler.AppendLiteral("#r#Y化身星级：#L");
			handler.AppendFormatted(P_1.星级);
			handler.AppendLiteral("#r#Y碎化数量：#R");
			handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
			handler.AppendLiteral("*");
			handler.AppendFormatted(P_1.碎化数量);
			handler.AppendLiteral("个#r");
			stringBuilder3.Append(ref handler);
			if (obj.化身列表.TryGetValue(P_1.化身名字, out var value))
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder2);
				handler.AppendLiteral("#Y激活进度：#M");
				handler.AppendFormatted(value.激活进度);
				handler.AppendLiteral("%#r");
				stringBuilder4.Append(ref handler);
			}
			else
			{
				stringBuilder.Append("#Y激活进度：#R0%#r");
			}
			if (J7aWuMQOCf())
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
				handler.AppendLiteral("#L化身属性：");
				handler.AppendFormatted(P_1.属性名字);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_1.属性数值);
				handler.AppendLiteral(" 增加#n");
				stringBuilder5.Append(ref handler);
			}
			return stringBuilder.ToString();
		}
		catch (Exception ex)
		{
			Log.Error("浮生录化身右键查询-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return string.Empty;
		}
	}

	
	internal void h9ZUYpIPHs(MyNATSocketClient P_0, string P_1, string P_2)
	{
		try
		{
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			if (P_1.Contains("浮生录_化身查询", StringComparison.CurrentCulture))
			{
				Jy8Up54her(P_0, P_1.Replace("浮生录_化身查询", ""));
			}
			if (P_1.Contains("浮生录_化身抽取", StringComparison.CurrentCulture))
			{
				string text = P_1.Replace("浮生录_化身抽取", string.Empty);
				int num = -1;
				if (Singleton<ByteAPI>.I.寻找文本(text, "乱世书"))
				{
					text = text.Replace("乱世书", string.Empty);
					num = 0;
				}
				else if (Singleton<ByteAPI>.I.寻找文本(text, "千钧卷"))
				{
					text = text.Replace("千钧卷", string.Empty);
					num = 1;
				}
				else if (Singleton<ByteAPI>.I.寻找文本(text, "灵虚卷"))
				{
					text = text.Replace("灵虚卷", string.Empty);
					num = 2;
				}
				else if (Singleton<ByteAPI>.I.寻找文本(text, "御元卷"))
				{
					text = text.Replace("御元卷", string.Empty);
					num = 3;
				}
				else if (Singleton<ByteAPI>.I.寻找文本(text, "乘风卷"))
				{
					text = text.Replace("乘风卷", string.Empty);
					num = 4;
				}
				if (Singleton<ByteAPI>.I.寻找文本等(P_1, "浮生录_化身抽取", "浮生录_化身抽取乱世书", "浮生录_化身抽取千钧卷", "浮生录_化身抽取灵虚卷", "浮生录_化身抽取御元卷", "浮生录_化身抽取乘风卷"))
				{
					cw9UEXjGLr(P_0, num);
				}
				else if (Singleton<ByteAPI>.I.寻找文本等(text, "数值一次", "数值十次", "数值五十次", "数值一百次"))
				{
					int num2 = 1;
					if (text == "数值十次")
					{
						num2 = 10;
					}
					else if (text == "数值五十次")
					{
						num2 = 50;
					}
					else if (text == "数值一百次")
					{
						num2 = 100;
					}
					XheU1AsINf(P_0, text, (AllEnums.化身分类)num, num2);
				}
				else if (Singleton<ByteAPI>.I.寻找文本等(text, "道具一次", "道具十次", "道具五十次", "道具一百次"))
				{
					int num3 = 1;
					if (text == "道具十次")
					{
						num3 = 10;
					}
					else if (text == "道具五十次")
					{
						num3 = 50;
					}
					else if (text == "道具一百次")
					{
						num3 = 100;
					}
					WdAPI i = Singleton<WdAPI>.I;
					int npc形象 = Singleton<全局变量类>.I.浮生录配置.NPC数据.npc形象;
					string npc名字 = Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 5);
					defaultInterpolatedStringHandler.AppendLiteral("[@/$*浮生录_确定抽取");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.化身分类)num);
					defaultInterpolatedStringHandler.AppendLiteral("道具");
					defaultInterpolatedStringHandler.AppendFormatted(num3);
					defaultInterpolatedStringHandler.AppendLiteral("|请提交#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具消耗 * num3);
					defaultInterpolatedStringHandler.AppendLiteral("个#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n进行#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num3);
					defaultInterpolatedStringHandler.AppendLiteral("#n次浮生化身抽取。,1,0]\r\n");
					P_0.C_Send(i.组包提交物品框(104, npc形象, npc名字, defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			}
			else if (P_1.Contains("浮生录_确定抽取", StringComparison.CurrentCulture))
			{
				string text2 = P_1.Replace("浮生录_确定抽取", string.Empty);
				int num4 = -1;
				if (Singleton<ByteAPI>.I.寻找文本(text2, "乱世书"))
				{
					text2 = text2.Replace("乱世书", string.Empty);
					num4 = 0;
				}
				else if (Singleton<ByteAPI>.I.寻找文本(text2, "千钧卷"))
				{
					text2 = text2.Replace("千钧卷", string.Empty);
					num4 = 1;
				}
				else if (Singleton<ByteAPI>.I.寻找文本(text2, "灵虚卷"))
				{
					text2 = text2.Replace("灵虚卷", string.Empty);
					num4 = 2;
				}
				else if (Singleton<ByteAPI>.I.寻找文本(text2, "御元卷"))
				{
					text2 = text2.Replace("御元卷", string.Empty);
					num4 = 3;
				}
				else if (Singleton<ByteAPI>.I.寻找文本(text2, "乘风卷"))
				{
					text2 = text2.Replace("乘风卷", string.Empty);
					num4 = 4;
				}
				if (Singleton<ByteAPI>.I.寻找文本等(text2, "数值1", "数值10", "数值50", "数值100"))
				{
					int num5 = 1;
					if (text2 == "数值10")
					{
						num5 = 10;
					}
					else if (text2 == "数值50")
					{
						num5 = 50;
					}
					else if (text2 == "数值100")
					{
						num5 = 100;
					}
					rtxUxV60FX(P_0, text2, (AllEnums.化身分类)num4, num5);
				}
				else if (Singleton<ByteAPI>.I.寻找文本等(text2, "$*道具1", "$*道具10", "$*道具50", "$*道具100") && P_0.user.缓存数据.l9XIwuUeoO.ElapsedMilliseconds >= 1000)
				{
					P_0.user.缓存数据.l9XIwuUeoO.Restart();
					int num6 = 1;
					if (text2 == "$*道具10")
					{
						num6 = 10;
					}
					else if (text2 == "$*道具50")
					{
						num6 = 50;
					}
					else if (text2 == "$*道具100")
					{
						num6 = 100;
					}
					SWIUHOO8Qq(P_0, text2, P_2, (AllEnums.化身分类)num4, num6);
				}
			}
			else if (P_1.Contains("浮生录_化身碎化", StringComparison.CurrentCulture))
			{
				if (P_1 == "浮生录_化身碎化")
				{
					P_0.C_Send(Singleton<WdAPI>.I.组包提交物品框(104, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc形象, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字, "[@/$*浮生录_化身碎化提交|请提交给我需要碎化的化身：,1,0]\r\n"));
				}
				else if (P_1 == "$*浮生录_化身碎化提交")
				{
					if (P_0.user.缓存数据.l9XIwuUeoO.ElapsedMilliseconds >= 1000)
					{
						P_0.user.缓存数据.l9XIwuUeoO.Restart();
						ecVU4VM63L(P_0, P_2);
					}
				}
				else if (P_1 == "浮生录_化身碎化全部")
				{
					P_0.C_Send(Singleton<WdAPI>.I.组包确定框(104, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc形象, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字, "[@确定/浮生录_化身碎化全部确定#DLG:1#prompt:你确定要碎化背包中所有的浮生化身吗？]"));
				}
				else if (P_1 == "浮生录_化身碎化全部确定")
				{
					w6qUeRSaR0(P_0);
				}
			}
			else if (P_1.Contains("浮生录_化身提交", StringComparison.CurrentCulture))
			{
				if (P_1 == "浮生录_化身提交")
				{
					P_0.C_Send(Singleton<WdAPI>.I.组包提交物品框(104, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc形象, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字, "[@/$*浮生录_化身提交|请提交给我需要激活的化身：,1,0]\r\n"));
				}
				else if (P_1 == "$*浮生录_化身提交")
				{
					if (P_0.user.缓存数据.l9XIwuUeoO.ElapsedMilliseconds >= 1000)
					{
						P_0.user.缓存数据.l9XIwuUeoO.Restart();
						egPUr6RrR3(P_0, P_2);
					}
				}
				else if (P_1 == "浮生录_化身提交全部")
				{
					P_0.C_Send(Singleton<WdAPI>.I.组包确定框(104, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc形象, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字, "[@确定/浮生录_化身提交全部确定#DLG:1#prompt:你确定要提交背包中所有的浮生化身吗？]"));
				}
				else if (P_1 == "浮生录_化身提交全部确定")
				{
					jcIUZ2EUTV(P_0);
				}
			}
			else if (P_1.Contains("浮生录_使用特效道具", StringComparison.CurrentCulture))
			{
				GeRUtub77Z(P_0, P_1);
			}
		}
		catch (Exception ex)
		{
			Log.Error("浮生录对话处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void Jy8Up54her(MyNATSocketClient P_0, string P_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		浮生录存档类 浮生录存档类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.浮生录数据.方案1 : P_0.user.存档数据.浮生录数据.方案2);
		if (string.IsNullOrWhiteSpace(P_1))
		{
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.浮生录配置.NPC数据.npcid, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc形象, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字, "[【乱世书】浮生录化身查询/浮生录_化身查询乱世书][【千钧卷】浮生录化身查询/浮生录_化身查询千钧卷][【灵虚卷】浮生录化身查询/浮生录_化身查询灵虚卷][【御元卷】浮生录化身查询/浮生录_化身查询御元卷][【乘风卷】浮生录化身查询/浮生录_化身查询乘风卷]"));
			return;
		}
		if (P_1 == "乱世书")
		{
			stringBuilder.Append("#G乱世书总卷化身激活详情：");
			for (int i = 0; i < Ih6WdCmIqb.Count; i++)
			{
				if (浮生录存档类2.化身列表.TryGetValue(Ih6WdCmIqb[i].化身名字, out var value))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 3, stringBuilder2);
					handler.AppendLiteral("#r#G");
					handler.AppendFormatted(Ih6WdCmIqb[i].化身名字);
					handler.AppendLiteral("（");
					handler.AppendFormatted(value.激活进度);
					handler.AppendLiteral("%）");
					string value2;
					if (!J7aWuMQOCf())
					{
						value2 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
						defaultInterpolatedStringHandler.AppendLiteral("：");
						defaultInterpolatedStringHandler.AppendFormatted(Ih6WdCmIqb[i].属性名字);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(Ih6WdCmIqb[i].属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加");
						value2 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value2);
					handler.AppendLiteral("#n");
					stringBuilder3.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 2, stringBuilder2);
					handler.AppendLiteral("#r#D");
					handler.AppendFormatted(Ih6WdCmIqb[i].化身名字);
					handler.AppendLiteral("（0%）");
					string value3;
					if (!J7aWuMQOCf())
					{
						value3 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
						defaultInterpolatedStringHandler.AppendLiteral("：");
						defaultInterpolatedStringHandler.AppendFormatted(Ih6WdCmIqb[i].属性名字);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(Ih6WdCmIqb[i].属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加");
						value3 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value3);
					handler.AppendLiteral("#n");
					stringBuilder4.Append(ref handler);
				}
			}
		}
		else if (P_1 == "千钧卷")
		{
			stringBuilder.Append("#G千钧卷总卷化身激活详情：");
			for (int j = 0; j < CsTWsdbKp5.Count; j++)
			{
				if (浮生录存档类2.化身列表.TryGetValue(CsTWsdbKp5[j].化身名字, out var value4))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 3, stringBuilder2);
					handler.AppendLiteral("#r#G");
					handler.AppendFormatted(CsTWsdbKp5[j].化身名字);
					handler.AppendLiteral("（");
					handler.AppendFormatted(value4.激活进度);
					handler.AppendLiteral("%）");
					string value5;
					if (!J7aWuMQOCf())
					{
						value5 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
						defaultInterpolatedStringHandler.AppendLiteral("：");
						defaultInterpolatedStringHandler.AppendFormatted(CsTWsdbKp5[j].属性名字);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(CsTWsdbKp5[j].属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加");
						value5 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value5);
					handler.AppendLiteral("#n");
					stringBuilder5.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 2, stringBuilder2);
					handler.AppendLiteral("#r#D");
					handler.AppendFormatted(CsTWsdbKp5[j].化身名字);
					handler.AppendLiteral("（0%）");
					string value6;
					if (!J7aWuMQOCf())
					{
						value6 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
						defaultInterpolatedStringHandler.AppendLiteral("：");
						defaultInterpolatedStringHandler.AppendFormatted(CsTWsdbKp5[j].属性名字);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(CsTWsdbKp5[j].属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加");
						value6 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value6);
					handler.AppendLiteral("#n");
					stringBuilder6.Append(ref handler);
				}
			}
		}
		else if (P_1 == "灵虚卷")
		{
			stringBuilder.Append("#G灵虚卷总卷化身激活详情：");
			for (int k = 0; k < nppWUisDdB.Count; k++)
			{
				if (浮生录存档类2.化身列表.TryGetValue(nppWUisDdB[k].化身名字, out var value7))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(11, 3, stringBuilder2);
					handler.AppendLiteral("#r#G");
					handler.AppendFormatted(nppWUisDdB[k].化身名字);
					handler.AppendLiteral("（");
					handler.AppendFormatted(value7.激活进度);
					handler.AppendLiteral("%） ");
					string value8;
					if (!J7aWuMQOCf())
					{
						value8 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
						defaultInterpolatedStringHandler.AppendLiteral("：");
						defaultInterpolatedStringHandler.AppendFormatted(nppWUisDdB[k].属性名字);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(nppWUisDdB[k].属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加");
						value8 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value8);
					handler.AppendLiteral(" #n");
					stringBuilder7.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 2, stringBuilder2);
					handler.AppendLiteral("#r#D");
					handler.AppendFormatted(nppWUisDdB[k].化身名字);
					handler.AppendLiteral("（0%） ");
					string value9;
					if (!J7aWuMQOCf())
					{
						value9 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
						defaultInterpolatedStringHandler.AppendLiteral("：");
						defaultInterpolatedStringHandler.AppendFormatted(nppWUisDdB[k].属性名字);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(nppWUisDdB[k].属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加");
						value9 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value9);
					handler.AppendLiteral(" #n");
					stringBuilder8.Append(ref handler);
				}
			}
		}
		else if (P_1 == "御元卷")
		{
			stringBuilder.Append("#G御元卷总卷化身激活详情：");
			for (int l = 0; l < RNoWWSOvFy.Count; l++)
			{
				if (浮生录存档类2.化身列表.TryGetValue(RNoWWSOvFy[l].化身名字, out var value10))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder9 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(11, 3, stringBuilder2);
					handler.AppendLiteral("#r#G");
					handler.AppendFormatted(RNoWWSOvFy[l].化身名字);
					handler.AppendLiteral("（");
					handler.AppendFormatted(value10.激活进度);
					handler.AppendLiteral("%） ");
					string value11;
					if (!J7aWuMQOCf())
					{
						value11 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
						defaultInterpolatedStringHandler.AppendLiteral("：");
						defaultInterpolatedStringHandler.AppendFormatted(RNoWWSOvFy[l].属性名字);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(RNoWWSOvFy[l].属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加");
						value11 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value11);
					handler.AppendLiteral(" #n");
					stringBuilder9.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder10 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 2, stringBuilder2);
					handler.AppendLiteral("#r#D");
					handler.AppendFormatted(RNoWWSOvFy[l].化身名字);
					handler.AppendLiteral("（0%） ");
					string value12;
					if (!J7aWuMQOCf())
					{
						value12 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
						defaultInterpolatedStringHandler.AppendLiteral("：");
						defaultInterpolatedStringHandler.AppendFormatted(RNoWWSOvFy[l].属性名字);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(RNoWWSOvFy[l].属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加");
						value12 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value12);
					handler.AppendLiteral(" #n");
					stringBuilder10.Append(ref handler);
				}
			}
		}
		else if (P_1 == "乘风卷")
		{
			stringBuilder.Append("#G乘风卷总卷化身激活详情：");
			for (int m = 0; m < LHGWgAIE0Z.Count; m++)
			{
				if (浮生录存档类2.化身列表.TryGetValue(LHGWgAIE0Z[m].化身名字, out var value13))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder11 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(11, 3, stringBuilder2);
					handler.AppendLiteral("#r#G");
					handler.AppendFormatted(LHGWgAIE0Z[m].化身名字);
					handler.AppendLiteral("（");
					handler.AppendFormatted(value13.激活进度);
					handler.AppendLiteral("%） ");
					string value14;
					if (!J7aWuMQOCf())
					{
						value14 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
						defaultInterpolatedStringHandler.AppendLiteral("：");
						defaultInterpolatedStringHandler.AppendFormatted(LHGWgAIE0Z[m].属性名字);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(LHGWgAIE0Z[m].属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加");
						value14 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value14);
					handler.AppendLiteral(" #n");
					stringBuilder11.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder12 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 2, stringBuilder2);
					handler.AppendLiteral("#r#D");
					handler.AppendFormatted(LHGWgAIE0Z[m].化身名字);
					handler.AppendLiteral("（0%） ");
					string value15;
					if (!J7aWuMQOCf())
					{
						value15 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
						defaultInterpolatedStringHandler.AppendLiteral("：");
						defaultInterpolatedStringHandler.AppendFormatted(LHGWgAIE0Z[m].属性名字);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(LHGWgAIE0Z[m].属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加");
						value15 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value15);
					handler.AppendLiteral(" #n");
					stringBuilder12.Append(ref handler);
				}
			}
		}
		P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.浮生录配置.NPC数据.npcid, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc形象, Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字, stringBuilder.ToString()));
	}

	
	internal void XheU1AsINf(MyNATSocketClient P_0, string P_1, AllEnums.化身分类 P_2, int P_3)
	{
		try
		{
			int num = Singleton<全局变量类>.I.浮生录配置.数值消耗 * P_3;
			if (!Singleton<全局变量类>.I.浮生录配置.is数值抽取 || (!Singleton<全局变量类>.I.浮生录配置.is数值连抽 && (P_3 == 10 || P_3 == 50 || P_3 == 100)))
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			switch (Singleton<全局变量类>.I.浮生录配置.数值类型)
			{
			case AllEnums.数值Type.金元宝:
				if (P_0.user.背包数据.金元宝 < num)
				{
					WdAPI i = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的金元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法抽取浮生录化身！");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				break;
			case AllEnums.数值Type.银元宝:
				if (P_0.user.背包数据.银元宝 < num)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的银元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法抽取浮生录化身！");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				break;
			case AllEnums.数值Type.金钱:
				if (P_0.user.背包数据.金钱 < num)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的游戏币不足" + Singleton<WdAPI>.I.问道标准数值文本(num) + "文，无法抽取浮生录化身！"));
					return;
				}
				break;
			}
			WdAPI i3 = Singleton<WdAPI>.I;
			int npc形象 = Singleton<全局变量类>.I.浮生录配置.NPC数据.npc形象;
			string npc名字 = Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 5);
			defaultInterpolatedStringHandler.AppendLiteral("[@确定/浮生录_确定抽取");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("数值");
			defaultInterpolatedStringHandler.AppendFormatted(P_3);
			defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要消耗");
			string value;
			if (Singleton<全局变量类>.I.浮生录配置.数值类型 != AllEnums.数值Type.金钱)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(4, 2);
				defaultInterpolatedStringHandler2.AppendLiteral("#R");
				defaultInterpolatedStringHandler2.AppendFormatted(num);
				defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.数值类型);
				defaultInterpolatedStringHandler2.AppendLiteral("#n");
				value = defaultInterpolatedStringHandler2.ToStringAndClear();
			}
			else
			{
				value = Singleton<WdAPI>.I.问道标准数值文本(num) + "文钱";
			}
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("抽取#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_3);
			defaultInterpolatedStringHandler.AppendLiteral("次");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("化身吗？]");
			P_0.C_Send(i3.组包确定框(104, npc形象, npc名字, defaultInterpolatedStringHandler.ToStringAndClear()));
		}
		catch (Exception ex)
		{
			Log.Error("浮生录数值抽取问询处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task rtxUxV60FX(MyNATSocketClient P_0, string P_1, AllEnums.化身分类 P_2, int P_3)
	{
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass23_0();
		CS_0024_003C_003E8__locals2.gtUc4eGyB1 = P_2;
		try
		{
			if (Singleton<全局变量类>.I.浮生录配置.化身列表.Count <= 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前活动数据暂无，请联系管理员！"));
			}
			if (!Singleton<全局变量类>.I.浮生录配置.is数值连抽 && (P_3 == 10 || P_3 == 50 || P_3 == 100))
			{
				return;
			}
			int num = Singleton<全局变量类>.I.浮生录配置.数值消耗 * P_3;
			if (!Singleton<全局变量类>.I.浮生录配置.is数值抽取)
			{
				return;
			}
			switch (Singleton<全局变量类>.I.浮生录配置.数值类型)
			{
			case AllEnums.数值Type.金元宝:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.背包数据.金元宝 < num)
				{
					WdAPI i5 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的金元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法抽取浮生录化身！");
					P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, -num, 0))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的金元宝扣除失败，无法抽取浮生录化身！"));
					return;
				}
				WdAPI i6 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n金元宝。");
				P_0.C_Send(i6.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.银元宝:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.背包数据.银元宝 < num)
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的银元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法抽取浮生录化身！");
					P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, 0, -num))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的银元宝扣除失败，无法抽取浮生录化身！"));
					return;
				}
				WdAPI i4 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n银元宝。");
				P_0.C_Send(i4.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.金钱:
				if (P_0.user.背包数据.金钱 < num)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的游戏币不足" + Singleton<WdAPI>.I.问道标准数值文本(num) + "文，无法抽取浮生录化身！"));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -num, false, "[浮生录]消耗");
				P_0.C_Send(Singleton<WdAPI>.I.提示_杂项公告("你消耗了" + Singleton<WdAPI>.I.问道标准数值文本(num) + "文金钱。"));
				break;
			case AllEnums.数值Type.灵气值:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.存档数据.数值存档.灵气值 < num)
				{
					WdAPI i = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的灵气值不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法抽取浮生录化身！");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -num, false, "[浮生录]消耗");
				WdAPI i2 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n点灵气值。");
				P_0.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			}
			List<浮生化身配置类> list = Singleton<全局变量类>.I.浮生录配置.化身列表.Values.ToList().FindAll( (浮生化身配置类 x) => x.分类 == CS_0024_003C_003E8__locals2.gtUc4eGyB1);
			List<浮生化身配置类> 五星列表 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.五星);
			List<浮生化身配置类> 四星列表 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.四星);
			List<浮生化身配置类> 三星列表 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.三星);
			List<浮生化身配置类> 二星列表 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.二星);
			List<浮生化身配置类> 一星列表 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.一星);
			_ = string.Empty;
			for (int i7 = 0; i7 < P_3; i7++)
			{
				int num2 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 1000);
				P_0.user.存档数据.浮生录数据.抽取次数++;
				if (P_0.user.存档数据.浮生录数据.抽取次数 >= 100)
				{
					num2 = Singleton<全局变量类>.I.浮生录配置.五星化身抽取几率;
				}
				if (num2 == Singleton<全局变量类>.I.浮生录配置.五星化身抽取几率 && 五星列表.Count > 0)
				{
					P_0.user.存档数据.浮生录数据.抽取次数 = 0;
					string 化身名字 = 五星列表[Singleton<WdAPI>.I.qrjo9TWIdy(0, 五星列表.Count - 1)].化身名字;
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
					}
					Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件 != null)
					{
						WdAPI i8 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n在浮生录活动中抽取到了#O五星#n的#Y");
						defaultInterpolatedStringHandler.AppendFormatted(化身名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n，真是气运滔天啊！");
						client频道事件(i8.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
				}
				else if (num2 > Singleton<全局变量类>.I.浮生录配置.五星化身抽取几率 && num2 <= Singleton<全局变量类>.I.浮生录配置.四星化身抽取几率 && 四星列表.Count > 0)
				{
					string 化身名字 = 四星列表[Singleton<WdAPI>.I.qrjo9TWIdy(0, 四星列表.Count - 1)].化身名字;
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
					}
					Action<byte[]> client频道事件2 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件2 != null)
					{
						WdAPI i9 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n在浮生录活动中抽取到了#O四星#n的#Y");
						defaultInterpolatedStringHandler.AppendFormatted(化身名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n，真是好运气啊！");
						client频道事件2(i9.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
				}
				else if (num2 > Singleton<全局变量类>.I.浮生录配置.四星化身抽取几率 && num2 <= Singleton<全局变量类>.I.浮生录配置.三星化身抽取几率 && 三星列表.Count > 0)
				{
					string 化身名字 = 三星列表[Singleton<WdAPI>.I.qrjo9TWIdy(0, 三星列表.Count - 1)].化身名字;
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
					}
				}
				else if (num2 > Singleton<全局变量类>.I.浮生录配置.三星化身抽取几率 && num2 <= Singleton<全局变量类>.I.浮生录配置.二星化身抽取几率 && 二星列表.Count > 0)
				{
					string 化身名字 = 二星列表[Singleton<WdAPI>.I.qrjo9TWIdy(0, 二星列表.Count - 1)].化身名字;
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
					}
				}
				else if (一星列表.Count > 0)
				{
					string 化身名字 = 一星列表[Singleton<WdAPI>.I.qrjo9TWIdy(0, 一星列表.Count - 1)].化身名字;
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
					}
				}
				await Task.Delay(50);
			}
		}
		catch (Exception ex)
		{
			Log.Error("浮生录确定抽取数值处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void SWIUHOO8Qq(MyNATSocketClient P_0, string P_1, string P_2, AllEnums.化身分类 P_3, int P_4)
	{
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_2 = new _003C_003Ec__DisplayClass24_0();
		_003C_003Ec__DisplayClass24_2.qHVcq68yBJ = P_0;
		_003C_003Ec__DisplayClass24_2.z0lcrX7jBP = P_3;
		_003C_003Ec__DisplayClass24_2.OSScZvtIYG = P_4;
		try
		{
			_003C_003Ec__DisplayClass24_1 CS_0024_003C_003E8__locals44 = new _003C_003Ec__DisplayClass24_1();
			CS_0024_003C_003E8__locals44.Q8ynuWyi2A = _003C_003Ec__DisplayClass24_2;
			if (!int.TryParse(new Regex("(?<=\\,)\\d+(?=\\:)").Match(P_2)?.Value, out var result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ, result))
			{
				return;
			}
			CS_0024_003C_003E8__locals44.viuczWNo4y = Singleton<全局变量类>.I.浮生录配置.道具消耗 * CS_0024_003C_003E8__locals44.Q8ynuWyi2A.OSScZvtIYG;
			if (!Singleton<全局变量类>.I.浮生录配置.is道具抽取 || string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.浮生录配置.道具名字) || (!Singleton<全局变量类>.I.浮生录配置.is道具连抽 && (CS_0024_003C_003E8__locals44.Q8ynuWyi2A.OSScZvtIYG == 10 || CS_0024_003C_003E8__locals44.Q8ynuWyi2A.OSScZvtIYG == 50 || CS_0024_003C_003E8__locals44.Q8ynuWyi2A.OSScZvtIYG == 100)))
			{
				return;
			}
			CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.user.背包数据.物品列表[result].封包缓存, result));
			if (Singleton<WdAPI>.I.取背包剩余空格数(CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ) < 1)
			{
				CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的背包已满，无法抽取浮生录化身。"));
				return;
			}
			if (!Singleton<WdAPI>.I.dSCoKmGWP9(CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ))
			{
				CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的宠物栏已满，无法抽取浮生录化身。"));
				return;
			}
			if (CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.user.背包数据.物品列表[result].名字 != Singleton<全局变量类>.I.浮生录配置.道具名字)
			{
				CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请提交#Y" + Singleton<全局变量类>.I.浮生录配置.道具名字 + "#n。"));
				return;
			}
			if (CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.user.背包数据.物品列表[result].数量 < CS_0024_003C_003E8__locals44.viuczWNo4y)
			{
				MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
				defaultInterpolatedStringHandler.AppendLiteral("请最低提交#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals44.viuczWNo4y);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.user.背包数据.物品列表[result].封包缓存, result)).ToArray());
				return;
			}
			_ = CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.user.背包数据.物品列表[result].数量;
			CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.销毁回调事件 =  async (string v) =>
			{
				if (!(v != Singleton<全局变量类>.I.浮生录配置.道具名字))
				{
					CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.销毁回调事件 = null;
					MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ;
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(14, 2);
					defaultInterpolatedStringHandler2.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals44.viuczWNo4y);
					defaultInterpolatedStringHandler2.AppendLiteral("#n个#Y");
					defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
					defaultInterpolatedStringHandler2.AppendLiteral("#n。");
					myNATSocketClient2.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
					List<浮生化身配置类> list = Singleton<全局变量类>.I.浮生录配置.化身列表.Values.ToList().FindAll( (浮生化身配置类 x) => x.分类 == CS_0024_003C_003E8__locals44.Q8ynuWyi2A.z0lcrX7jBP);
					List<浮生化身配置类> list2 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.五星);
					List<浮生化身配置类> list3 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.四星);
					List<浮生化身配置类> list4 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.三星);
					List<浮生化身配置类> list5 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.二星);
					List<浮生化身配置类> list6 = list.FindAll( (浮生化身配置类 a) => a.星级 == AllEnums.化身星级.一星);
					_ = string.Empty;
					for (int num = 0; num < CS_0024_003C_003E8__locals44.Q8ynuWyi2A.OSScZvtIYG; num++)
					{
						int num2 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 1000);
						CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.user.存档数据.浮生录数据.抽取次数++;
						if (CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.user.存档数据.浮生录数据.抽取次数 >= 100)
						{
							num2 = Singleton<全局变量类>.I.浮生录配置.五星化身抽取几率;
						}
						if (num2 == Singleton<全局变量类>.I.浮生录配置.五星化身抽取几率 && list2.Count > 0)
						{
							CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.user.存档数据.浮生录数据.抽取次数 = 0;
							string 化身名字 = list2[Singleton<WdAPI>.I.qrjo9TWIdy(0, list2.Count - 1)].化身名字;
							if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
							{
								CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
							}
							Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
							if (client频道事件 != null)
							{
								WdAPI i3 = Singleton<WdAPI>.I;
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(37, 2);
								defaultInterpolatedStringHandler2.AppendLiteral("恭喜#Y");
								defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.user.人物数据.昵称);
								defaultInterpolatedStringHandler2.AppendLiteral("#n在浮生录活动中抽取到了#O五星#n的#Y");
								defaultInterpolatedStringHandler2.AppendFormatted(化身名字);
								defaultInterpolatedStringHandler2.AppendLiteral("#n，真是气运滔天啊！");
								client频道事件(i3.组包聊天信息(defaultInterpolatedStringHandler2.ToStringAndClear(), "管理员"));
							}
						}
						else if (num2 > Singleton<全局变量类>.I.浮生录配置.五星化身抽取几率 && num2 <= Singleton<全局变量类>.I.浮生录配置.四星化身抽取几率 && list3.Count > 0)
						{
							string 化身名字 = list3[Singleton<WdAPI>.I.qrjo9TWIdy(0, list3.Count - 1)].化身名字;
							if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
							{
								CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
							}
							Action<byte[]> client频道事件2 = Singleton<全局变量类>.I.Client频道事件;
							if (client频道事件2 != null)
							{
								WdAPI i4 = Singleton<WdAPI>.I;
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(36, 2);
								defaultInterpolatedStringHandler2.AppendLiteral("恭喜#Y");
								defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.user.人物数据.昵称);
								defaultInterpolatedStringHandler2.AppendLiteral("#n在浮生录活动中抽取到了#O四星#n的#Y");
								defaultInterpolatedStringHandler2.AppendFormatted(化身名字);
								defaultInterpolatedStringHandler2.AppendLiteral("#n，真是好运气啊！");
								client频道事件2(i4.组包聊天信息(defaultInterpolatedStringHandler2.ToStringAndClear(), "管理员"));
							}
						}
						else if (num2 > Singleton<全局变量类>.I.浮生录配置.四星化身抽取几率 && num2 <= Singleton<全局变量类>.I.浮生录配置.三星化身抽取几率 && list4.Count > 0)
						{
							string 化身名字 = list4[Singleton<WdAPI>.I.qrjo9TWIdy(0, list4.Count - 1)].化身名字;
							if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
							{
								CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
							}
						}
						else if (num2 > Singleton<全局变量类>.I.浮生录配置.三星化身抽取几率 && num2 <= Singleton<全局变量类>.I.浮生录配置.二星化身抽取几率 && list5.Count > 0)
						{
							string 化身名字 = list5[Singleton<WdAPI>.I.qrjo9TWIdy(0, list5.Count - 1)].化身名字;
							if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
							{
								CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
							}
						}
						else if (list6.Count > 0)
						{
							string 化身名字 = list6[Singleton<WdAPI>.I.qrjo9TWIdy(0, list6.Count - 1)].化身名字;
							if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ, AllEnums.发送数据Type.道具, 化身名字, AllEnums.指令Type.无, 1, false, "浮生录化身抽取"))
							{
								CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你抽取了#Y" + 化身名字 + "#n。").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你抽取了#Y" + 化身名字 + "#n。")).ToArray());
							}
						}
						await Task.Delay(50);
					}
				}
			};
			CS_0024_003C_003E8__locals44.Q8ynuWyi2A.qHVcq68yBJ.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(result, CS_0024_003C_003E8__locals44.viuczWNo4y));
		}
		catch (Exception ex)
		{
			Log.Error("浮生录确定抽取道具处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void ecVU4VM63L(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals31 = new _003C_003Ec__DisplayClass25_0();
		CS_0024_003C_003E8__locals31.iijnb0jHJ3 = P_0;
		try
		{
			if (!int.TryParse(new Regex("(?<=\\,)\\d+(?=\\:)").Match(P_1)?.Value, out var result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals31.iijnb0jHJ3, result))
			{
				return;
			}
			CS_0024_003C_003E8__locals31.iijnb0jHJ3.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals31.iijnb0jHJ3.user.背包数据.物品列表[result].封包缓存, result));
			if (Singleton<WdAPI>.I.取背包剩余空格数(CS_0024_003C_003E8__locals31.iijnb0jHJ3) < 1)
			{
				CS_0024_003C_003E8__locals31.iijnb0jHJ3.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的背包已满，无法进行化身碎化处理。").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals31.iijnb0jHJ3.user.背包数据.物品列表[result].封包缓存, result)).ToArray());
				return;
			}
			if (!Singleton<WdAPI>.I.dSCoKmGWP9(CS_0024_003C_003E8__locals31.iijnb0jHJ3))
			{
				CS_0024_003C_003E8__locals31.iijnb0jHJ3.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的宠物栏已满，无法进行化身碎化处理。").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals31.iijnb0jHJ3.user.背包数据.物品列表[result].封包缓存, result)).ToArray());
				return;
			}
			if (!Singleton<全局变量类>.I.浮生录配置.化身列表.TryGetValue(CS_0024_003C_003E8__locals31.iijnb0jHJ3.user.背包数据.物品列表[result].名字, out CS_0024_003C_003E8__locals31.K9VnJQrjlQ))
			{
				CS_0024_003C_003E8__locals31.iijnb0jHJ3.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你提交的道具有误，无法进行化身碎化处理。").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals31.iijnb0jHJ3.user.背包数据.物品列表[result].封包缓存, result)).ToArray());
				return;
			}
			CS_0024_003C_003E8__locals31.sTPnKBQqwM = CS_0024_003C_003E8__locals31.iijnb0jHJ3.user.背包数据.物品列表[result].数量;
			CS_0024_003C_003E8__locals31.iijnb0jHJ3.销毁回调事件 =  (string v) =>
			{
				if (!(v != CS_0024_003C_003E8__locals31.K9VnJQrjlQ.化身名字))
				{
					CS_0024_003C_003E8__locals31.iijnb0jHJ3.销毁回调事件 = null;
					if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals31.iijnb0jHJ3, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.浮生录配置.道具名字, AllEnums.指令Type.无, CS_0024_003C_003E8__locals31.sTPnKBQqwM * CS_0024_003C_003E8__locals31.K9VnJQrjlQ.碎化数量, false, "化身碎化"))
					{
						MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals31.iijnb0jHJ3;
						WdAPI i = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 4);
						defaultInterpolatedStringHandler.AppendLiteral("你成功碎化了#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals31.sTPnKBQqwM);
						defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals31.K9VnJQrjlQ.化身名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n，获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals31.sTPnKBQqwM * CS_0024_003C_003E8__locals31.K9VnJQrjlQ.碎化数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n。");
						byte[] first = i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear());
						WdAPI i2 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals31.sTPnKBQqwM * CS_0024_003C_003E8__locals31.K9VnJQrjlQ.碎化数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n");
						myNATSocketClient.C_Send(first.Concat(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
					}
				}
			};
			CS_0024_003C_003E8__locals31.iijnb0jHJ3.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(result, CS_0024_003C_003E8__locals31.sTPnKBQqwM));
		}
		catch (Exception ex)
		{
			Log.Error("浮生录化身碎化处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task w6qUeRSaR0(MyNATSocketClient P_0)
	{
		_ = 1;
		try
		{
			P_0.销毁回调事件 = null;
			List<物品信息类> list = P_0.user.背包数据.物品列表.ToList().FindAll( (物品信息类 x) => x.物品ID != 0 && Singleton<全局变量类>.I.浮生录配置.化身列表.ContainsKey(x.名字));
			if (list.Count <= 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R背包中并无可碎化的化身！#n"));
				return;
			}
			浮生化身配置类 value = null;
			int 总碎化数量 = 0;
			List<int> 实际格子组 = new List<int>();
			P_0.C_Send(Singleton<WdAPI>.I.QewoEwLLTD("正在碎化中", 1));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			foreach (物品信息类 item in list)
			{
				if (item.Index < 161 || P_0.user.缓存数据.is坐骑风灵丸)
				{
					if (Singleton<全局变量类>.I.浮生录配置.化身列表.TryGetValue(item.名字, out value))
					{
						总碎化数量 += value.碎化数量 * item.数量;
						实际格子组.Add(item.Index);
						WdAPI i = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 4);
						defaultInterpolatedStringHandler.AppendLiteral("你成功碎化了#R");
						defaultInterpolatedStringHandler.AppendFormatted(item.数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
						defaultInterpolatedStringHandler.AppendFormatted(value.化身名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n，获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(item.数量 * value.碎化数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n。");
						P_0.C_Send(i.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						await Task.Delay(10);
					}
					continue;
				}
				break;
			}
			P_0.S_Send(Singleton<WdAPI>.I.DN4IOFDdr5(P_0, 实际格子组.ToArray()));
			await Task.Delay(200);
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.浮生录配置.道具名字, AllEnums.指令Type.无, 总碎化数量, false, "化身全部碎化");
			WdAPI i2 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
			defaultInterpolatedStringHandler.AppendLiteral("#G执行完毕，背包中的所有化身已全部碎化为#R");
			defaultInterpolatedStringHandler.AppendFormatted(总碎化数量);
			defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.道具名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n。");
			P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
		}
		catch (Exception ex)
		{
			Log.Error("浮生录化身全部碎化处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task zV7Uq7ET8C(MyNATSocketClient P_0, 物品信息类 P_1, 浮生录存档类 P_2, 浮生化身配置类 P_3, 浮生录化身列表类 P_4)
	{
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_2 = new _003C_003Ec__DisplayClass27_0();
		_003C_003Ec__DisplayClass27_2.riCnUD8hO7 = P_3;
		_003C_003Ec__DisplayClass27_2.PIjnWu6iHE = P_0;
		_003C_003Ec__DisplayClass27_2.SsbngqNyUD = P_2;
		try
		{
			_003C_003Ec__DisplayClass27_1 CS_0024_003C_003E8__locals55 = new _003C_003Ec__DisplayClass27_1();
			CS_0024_003C_003E8__locals55.rSSnldQiDX = _003C_003Ec__DisplayClass27_2;
			int num = CS_0024_003C_003E8__locals55.rSSnldQiDX.SsbngqNyUD.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.分类 && x.激活进度 >= 100);
			int num2 = Singleton<全局变量类>.I.浮生录配置.化身列表.Values.Count( (浮生化身配置类 x) => x.分类 == CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.分类);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (num >= num2)
			{
				MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE;
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
				defaultInterpolatedStringHandler.AppendLiteral("#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.分类);
				defaultInterpolatedStringHandler.AppendLiteral("#n中所有的化身均已全部激活，无法再次激活。");
				myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			CS_0024_003C_003E8__locals55.dxXnjNjqvp = XgSWRaXXjY[CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.分类];
			int num3 = 0;
			short 激活进度 = 0;
			short num4 = 0;
			for (int num5 = 0; num5 < P_1.数量; num5++)
			{
				num3++;
				num4 += (short)Singleton<WdAPI>.I.qrjo9TWIdy(1, (int)(6 - CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.星级));
				if (num4 + P_4.激活进度 >= 100)
				{
					激活进度 = 100;
					break;
				}
				激活进度 = (short)(P_4.激活进度 + num4);
			}
			P_4.激活进度 = 激活进度;
			MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE;
			WdAPI i2 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
			defaultInterpolatedStringHandler.AppendLiteral("你提交了#R");
			defaultInterpolatedStringHandler.AppendFormatted(num3);
			defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.化身名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n激活进度提升到了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_4.激活进度);
			defaultInterpolatedStringHandler.AppendLiteral("%#n。");
			myNATSocketClient2.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			if (P_4.激活进度 >= 100 && CS_0024_003C_003E8__locals55.rSSnldQiDX.SsbngqNyUD.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.分类 && x.激活进度 >= 100) >= num2)
			{
				CS_0024_003C_003E8__locals55.rSSnldQiDX.SsbngqNyUD.is全部激活 = CS_0024_003C_003E8__locals55.rSSnldQiDX.SsbngqNyUD.化身列表.Values.Count( (浮生录化身列表类 x) => x.激活进度 >= 100) >= Singleton<全局变量类>.I.浮生录配置.化身列表.Count;
				CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE.销毁回调事件 =  (string v) =>
				{
					if (!(v != CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.化身名字))
					{
						CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE.销毁回调事件 = null;
						if (CS_0024_003C_003E8__locals55.dxXnjNjqvp.金 > 0)
						{
							Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.metal, CS_0024_003C_003E8__locals55.dxXnjNjqvp.金, false, "[浮生录]属性增加");
						}
						if (CS_0024_003C_003E8__locals55.dxXnjNjqvp.木 > 0)
						{
							Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.wood, CS_0024_003C_003E8__locals55.dxXnjNjqvp.木, false, "[浮生录]属性增加");
						}
						if (CS_0024_003C_003E8__locals55.dxXnjNjqvp.水 > 0)
						{
							Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.water, CS_0024_003C_003E8__locals55.dxXnjNjqvp.水, false, "[浮生录]属性增加");
						}
						if (CS_0024_003C_003E8__locals55.dxXnjNjqvp.火 > 0)
						{
							Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.fire, CS_0024_003C_003E8__locals55.dxXnjNjqvp.火, false, "[浮生录]属性增加");
						}
						if (CS_0024_003C_003E8__locals55.dxXnjNjqvp.土 > 0)
						{
							Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.earth, CS_0024_003C_003E8__locals55.dxXnjNjqvp.土, false, "[浮生录]属性增加");
						}
						CS_0024_003C_003E8__locals55.rSSnldQiDX.SsbngqNyUD.浮生属性.金相性 += CS_0024_003C_003E8__locals55.dxXnjNjqvp.金;
						CS_0024_003C_003E8__locals55.rSSnldQiDX.SsbngqNyUD.浮生属性.木相性 += CS_0024_003C_003E8__locals55.dxXnjNjqvp.木;
						CS_0024_003C_003E8__locals55.rSSnldQiDX.SsbngqNyUD.浮生属性.水相性 += CS_0024_003C_003E8__locals55.dxXnjNjqvp.水;
						CS_0024_003C_003E8__locals55.rSSnldQiDX.SsbngqNyUD.浮生属性.火相性 += CS_0024_003C_003E8__locals55.dxXnjNjqvp.火;
						CS_0024_003C_003E8__locals55.rSSnldQiDX.SsbngqNyUD.浮生属性.土相性 += CS_0024_003C_003E8__locals55.dxXnjNjqvp.土;
						switch (CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.分类)
						{
						case AllEnums.化身分类.乱世书:
						{
							MyNATSocketClient myNATSocketClient7 = CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE;
							WdAPI i7 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(35, 3);
							defaultInterpolatedStringHandler2.AppendLiteral("#G恭喜你#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.分类);
							defaultInterpolatedStringHandler2.AppendLiteral("#G所有化身激活完成，获得了#G");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乱世书属性);
							defaultInterpolatedStringHandler2.AppendLiteral(" ");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乱世书数值);
							defaultInterpolatedStringHandler2.AppendLiteral(" 增加#n的属性奖励！");
							myNATSocketClient7.C_Send(i7.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
							break;
						}
						case AllEnums.化身分类.千钧卷:
						{
							MyNATSocketClient myNATSocketClient6 = CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE;
							WdAPI i6 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(35, 3);
							defaultInterpolatedStringHandler2.AppendLiteral("#G恭喜你#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.分类);
							defaultInterpolatedStringHandler2.AppendLiteral("#G所有化身激活完成，获得了#G");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.千钧卷属性);
							defaultInterpolatedStringHandler2.AppendLiteral(" ");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.千钧卷数值);
							defaultInterpolatedStringHandler2.AppendLiteral(" 增加#n的属性奖励！");
							myNATSocketClient6.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
							break;
						}
						case AllEnums.化身分类.灵虚卷:
						{
							MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE;
							WdAPI i5 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(35, 3);
							defaultInterpolatedStringHandler2.AppendLiteral("#G恭喜你#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.分类);
							defaultInterpolatedStringHandler2.AppendLiteral("#G所有化身激活完成，获得了#G");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.灵虚卷属性);
							defaultInterpolatedStringHandler2.AppendLiteral(" ");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.灵虚卷数值);
							defaultInterpolatedStringHandler2.AppendLiteral(" 增加#n的属性奖励！");
							myNATSocketClient5.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
							break;
						}
						case AllEnums.化身分类.御元卷:
						{
							MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE;
							WdAPI i4 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(35, 3);
							defaultInterpolatedStringHandler2.AppendLiteral("#G恭喜你#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.分类);
							defaultInterpolatedStringHandler2.AppendLiteral("#G所有化身激活完成，获得了#G");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.御元卷属性);
							defaultInterpolatedStringHandler2.AppendLiteral(" ");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.御元卷数值);
							defaultInterpolatedStringHandler2.AppendLiteral(" 增加#n的属性奖励！");
							myNATSocketClient4.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
							break;
						}
						case AllEnums.化身分类.乘风卷:
						{
							MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE;
							WdAPI i3 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(35, 3);
							defaultInterpolatedStringHandler2.AppendLiteral("#G恭喜你#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals55.rSSnldQiDX.riCnUD8hO7.分类);
							defaultInterpolatedStringHandler2.AppendLiteral("#G所有化身激活完成，获得了#G");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乘风卷属性);
							defaultInterpolatedStringHandler2.AppendLiteral(" ");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乘风卷数值);
							defaultInterpolatedStringHandler2.AppendLiteral(" 增加#n的属性奖励！");
							myNATSocketClient3.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
							break;
						}
						}
					}
				};
			}
			await CS_0024_003C_003E8__locals55.rSSnldQiDX.PIjnWu6iHE.S_Send异步(Singleton<WdAPI>.I.rxTojoeFsR(P_1.Index, num3), "化身统一提交处理");
		}
		catch (Exception ex)
		{
			Log.Error("化身统一提交处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task 中州_统一化身提交处理(MyNATSocketClient myclient, 物品信息类 当前格子, 浮生录存档类 当前存档, 浮生化身配置类 当前配置, 浮生录化身列表类 当前化身存档)
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_2 = new _003C_003Ec__DisplayClass28_0();
		_003C_003Ec__DisplayClass28_2.dhVnNqpfEY = 当前配置;
		_003C_003Ec__DisplayClass28_2.hBonikvueB = myclient;
		_003C_003Ec__DisplayClass28_2.BWwnBFrOpS = 当前存档;
		try
		{
			_003C_003Ec__DisplayClass28_1 CS_0024_003C_003E8__locals45 = new _003C_003Ec__DisplayClass28_1();
			CS_0024_003C_003E8__locals45.eu2nmrPAhD = _003C_003Ec__DisplayClass28_2;
			CS_0024_003C_003E8__locals45.jbGn6JfMA4 = CS_0024_003C_003E8__locals45.eu2nmrPAhD.BWwnBFrOpS.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.分类 && x.激活进度 >= 100);
			CS_0024_003C_003E8__locals45.ux7n2ZvaHi = Singleton<全局变量类>.I.浮生录配置.化身列表.Values.Count( (浮生化身配置类 x) => x.分类 == CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.分类);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (CS_0024_003C_003E8__locals45.jbGn6JfMA4 >= CS_0024_003C_003E8__locals45.ux7n2ZvaHi)
			{
				MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB;
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
				defaultInterpolatedStringHandler.AppendLiteral("#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.分类);
				defaultInterpolatedStringHandler.AppendLiteral("#n中所有的化身均已全部激活，无法再次激活。");
				myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			int num = 0;
			short 激活进度 = 0;
			short num2 = 0;
			for (int num3 = 0; num3 < 当前格子.数量; num3++)
			{
				num++;
				num2 += (short)Singleton<WdAPI>.I.qrjo9TWIdy(1, (int)(6 - CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.星级));
				if (num2 + 当前化身存档.激活进度 >= 100)
				{
					激活进度 = 100;
					break;
				}
				激活进度 = (short)(当前化身存档.激活进度 + num2);
			}
			当前化身存档.激活进度 = 激活进度;
			MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB;
			WdAPI i2 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
			defaultInterpolatedStringHandler.AppendLiteral("你提交了#R");
			defaultInterpolatedStringHandler.AppendFormatted(num);
			defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.化身名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n激活进度提升到了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(当前化身存档.激活进度);
			defaultInterpolatedStringHandler.AppendLiteral("%#n。");
			myNATSocketClient2.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			if (当前化身存档.激活进度 >= 100)
			{
				CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB.销毁回调事件 =  (string v) =>
				{
					if (!(v != CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.化身名字))
					{
						CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB.销毁回调事件 = null;
						List<string[]> list = new List<string[]>();
						CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB.user.存档数据.中州论道存档.jxpIgn1imh(CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.属性名字, CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.属性数值, out var text);
						string[] array = new string[2];
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
						defaultInterpolatedStringHandler2.AppendLiteral("prop/");
						defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性标识Type)CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.属性名字);
						array[0] = defaultInterpolatedStringHandler2.ToStringAndClear();
						array[1] = text;
						list.Add(array);
						CS_0024_003C_003E8__locals45.jbGn6JfMA4 = CS_0024_003C_003E8__locals45.eu2nmrPAhD.BWwnBFrOpS.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.分类 && x.激活进度 >= 100);
						if (CS_0024_003C_003E8__locals45.jbGn6JfMA4 >= CS_0024_003C_003E8__locals45.ux7n2ZvaHi)
						{
							switch (CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.分类)
							{
							case AllEnums.化身分类.乱世书:
							{
								CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制乱世书属性, Singleton<全局变量类>.I.浮生录配置.乱世书数值, out text);
								string[] array6 = new string[2];
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
								defaultInterpolatedStringHandler2.AppendLiteral("prop/");
								defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制乱世书属性);
								array6[0] = defaultInterpolatedStringHandler2.ToStringAndClear();
								array6[1] = text;
								list.Add(array6);
								MyNATSocketClient myNATSocketClient7 = CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB;
								WdAPI i7 = Singleton<WdAPI>.I;
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(35, 3);
								defaultInterpolatedStringHandler2.AppendLiteral("#G恭喜你#Y");
								defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.分类);
								defaultInterpolatedStringHandler2.AppendLiteral("#G所有化身激活完成，获得了#G");
								defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制乱世书属性);
								defaultInterpolatedStringHandler2.AppendLiteral(" ");
								defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乱世书数值);
								defaultInterpolatedStringHandler2.AppendLiteral(" 增加#n的属性奖励！");
								myNATSocketClient7.C_Send(i7.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
								break;
							}
							case AllEnums.化身分类.千钧卷:
							{
								CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性, Singleton<全局变量类>.I.浮生录配置.千钧卷数值, out text);
								string[] array5 = new string[2];
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
								defaultInterpolatedStringHandler2.AppendLiteral("prop/");
								defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性);
								array5[0] = defaultInterpolatedStringHandler2.ToStringAndClear();
								array5[1] = text;
								list.Add(array5);
								MyNATSocketClient myNATSocketClient6 = CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB;
								WdAPI i6 = Singleton<WdAPI>.I;
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(35, 3);
								defaultInterpolatedStringHandler2.AppendLiteral("#G恭喜你#Y");
								defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.分类);
								defaultInterpolatedStringHandler2.AppendLiteral("#G所有化身激活完成，获得了#G");
								defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性);
								defaultInterpolatedStringHandler2.AppendLiteral(" ");
								defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.千钧卷数值);
								defaultInterpolatedStringHandler2.AppendLiteral(" 增加#n的属性奖励！");
								myNATSocketClient6.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
								break;
							}
							case AllEnums.化身分类.灵虚卷:
							{
								CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性, Singleton<全局变量类>.I.浮生录配置.灵虚卷数值, out text);
								string[] array4 = new string[2];
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
								defaultInterpolatedStringHandler2.AppendLiteral("prop/");
								defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性);
								array4[0] = defaultInterpolatedStringHandler2.ToStringAndClear();
								array4[1] = text;
								list.Add(array4);
								MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB;
								WdAPI i5 = Singleton<WdAPI>.I;
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(35, 3);
								defaultInterpolatedStringHandler2.AppendLiteral("#G恭喜你#Y");
								defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.分类);
								defaultInterpolatedStringHandler2.AppendLiteral("#G所有化身激活完成，获得了#G");
								defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性);
								defaultInterpolatedStringHandler2.AppendLiteral(" ");
								defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.灵虚卷数值);
								defaultInterpolatedStringHandler2.AppendLiteral(" 增加#n的属性奖励！");
								myNATSocketClient5.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
								break;
							}
							case AllEnums.化身分类.御元卷:
							{
								CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制御元卷属性, Singleton<全局变量类>.I.浮生录配置.御元卷数值, out text);
								string[] array3 = new string[2];
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
								defaultInterpolatedStringHandler2.AppendLiteral("prop/");
								defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制御元卷属性);
								array3[0] = defaultInterpolatedStringHandler2.ToStringAndClear();
								array3[1] = text;
								list.Add(array3);
								MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB;
								WdAPI i4 = Singleton<WdAPI>.I;
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(35, 3);
								defaultInterpolatedStringHandler2.AppendLiteral("#G恭喜你#Y");
								defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.分类);
								defaultInterpolatedStringHandler2.AppendLiteral("#G所有化身激活完成，获得了#G");
								defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制御元卷属性);
								defaultInterpolatedStringHandler2.AppendLiteral(" ");
								defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.御元卷数值);
								defaultInterpolatedStringHandler2.AppendLiteral(" 增加#n的属性奖励！");
								myNATSocketClient4.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
								break;
							}
							case AllEnums.化身分类.乘风卷:
							{
								CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性, Singleton<全局变量类>.I.浮生录配置.乘风卷数值, out text);
								string[] array2 = new string[2];
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
								defaultInterpolatedStringHandler2.AppendLiteral("prop/");
								defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性);
								array2[0] = defaultInterpolatedStringHandler2.ToStringAndClear();
								array2[1] = text;
								list.Add(array2);
								MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB;
								WdAPI i3 = Singleton<WdAPI>.I;
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(35, 3);
								defaultInterpolatedStringHandler2.AppendLiteral("#G恭喜你#Y");
								defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals45.eu2nmrPAhD.dhVnNqpfEY.分类);
								defaultInterpolatedStringHandler2.AppendLiteral("#G所有化身激活完成，获得了#G");
								defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性);
								defaultInterpolatedStringHandler2.AppendLiteral(" ");
								defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乘风卷数值);
								defaultInterpolatedStringHandler2.AppendLiteral(" 增加#n的属性奖励！");
								myNATSocketClient3.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
								break;
							}
							}
							CS_0024_003C_003E8__locals45.eu2nmrPAhD.BWwnBFrOpS.is全部激活 = CS_0024_003C_003E8__locals45.eu2nmrPAhD.BWwnBFrOpS.化身列表.Values.Count( (浮生录化身列表类 x) => x.激活进度 >= 100) >= Singleton<全局变量类>.I.浮生录配置.化身列表.Count;
						}
						Singleton<fuMNpgieFTYU3Wah53>.I.mMMfZ3LX2(CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB, list);
					}
				};
			}
			await CS_0024_003C_003E8__locals45.eu2nmrPAhD.hBonikvueB.S_Send异步(Singleton<WdAPI>.I.rxTojoeFsR(当前格子.Index, num), "中州_统一化身提交处理");
		}
		catch (Exception ex)
		{
			Log.Error("中州_统一化身提交处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void egPUr6RrR3(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (!int.TryParse(new Regex("(?<=\\,)\\d+(?=\\:)").Match(P_1)?.Value, out var result))
			{
				return;
			}
			P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[result].封包缓存, result));
			if (!Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result))
			{
				return;
			}
			if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的背包已满，无法进行化身激活处理。"));
				return;
			}
			if (!Singleton<WdAPI>.I.dSCoKmGWP9(P_0))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的宠物栏已满，无法进行化身激活处理。"));
				return;
			}
			if (!Singleton<全局变量类>.I.浮生录配置.化身列表.TryGetValue(P_0.user.背包数据.物品列表[result].名字, out 浮生化身配置类 value))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你提交的道具有误，无法进行化身激活处理。"));
				return;
			}
			浮生录存档类 浮生录存档类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.浮生录数据.方案1 : P_0.user.存档数据.浮生录数据.方案2);
			if (浮生录存档类2.is全部激活)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("所有的化身均已全部激活，无法再次激活。"));
				return;
			}
			if (P_0.user.背包数据.物品列表[result].Index >= 161 && !P_0.user.缓存数据.is坐骑风灵丸)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你提交的道具有误，无法进行化身激活处理。"));
				return;
			}
			if (P_0.user.背包数据.物品列表[result].Index >= 161 && !P_0.user.缓存数据.is坐骑风灵丸)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你提交的道具有误，无法进行化身激活处理。"));
				return;
			}
			浮生录化身列表类 value2 = null;
			if (!浮生录存档类2.化身列表.TryGetValue(value.化身名字, out value2))
			{
				value2 = new 浮生录化身列表类
				{
					分类 = value.分类,
					化身名字 = value.化身名字,
					激活进度 = 0
				};
				浮生录存档类2.化身列表.TryAdd(value.化身名字, value2);
			}
			if (value2.激活进度 >= 100)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + value.化身名字 + "#n已被激活，无法再次激活。"));
			}
			else if (J7aWuMQOCf())
			{
				中州_统一化身提交处理(P_0, P_0.user.背包数据.物品列表[result], 浮生录存档类2, value, value2);
			}
			else
			{
				zV7Uq7ET8C(P_0, P_0.user.背包数据.物品列表[result], 浮生录存档类2, value, value2);
			}
		}
		catch (Exception ex)
		{
			Log.Error("浮生录化身提交处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task jcIUZ2EUTV(MyNATSocketClient P_0)
	{
		_ = 2;
		try
		{
			P_0.销毁回调事件 = null;
			if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的背包已满，无法进行化身激活处理。"));
				return;
			}
			if (!Singleton<WdAPI>.I.dSCoKmGWP9(P_0))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的宠物栏已满，无法进行化身激活处理。"));
				return;
			}
			浮生录存档类 当前方案 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.浮生录数据.方案1 : P_0.user.存档数据.浮生录数据.方案2);
			if (当前方案.is全部激活)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R所有化身全部已激活，无法重复激活！#n"));
				return;
			}
			List<物品信息类> list = P_0.user.背包数据.物品列表.ToList().FindAll( (物品信息类 x) => x.物品ID != 0 && Singleton<全局变量类>.I.浮生录配置.化身列表.ContainsKey(x.名字));
			if (list.Count <= 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R背包中并无可提交的化身！#n"));
				return;
			}
			P_0.C_Send(Singleton<WdAPI>.I.QewoEwLLTD("正在提交中", (short)(list.Count / 2)));
			浮生化身配置类 value = null;
			浮生录化身列表类 value2 = null;
			foreach (物品信息类 item in list)
			{
				if (!当前方案.is全部激活 && (item.Index < 161 || P_0.user.缓存数据.is坐骑风灵丸))
				{
					Singleton<全局变量类>.I.浮生录配置.化身列表.TryGetValue(item.名字, out value);
					if (!当前方案.化身列表.TryGetValue(value.化身名字, out value2))
					{
						value2 = new 浮生录化身列表类
						{
							分类 = value.分类,
							化身名字 = value.化身名字,
							激活进度 = 0
						};
						当前方案.化身列表.TryAdd(value.化身名字, value2);
					}
					else if (value2.激活进度 >= 100)
					{
						continue;
					}
					if (!J7aWuMQOCf())
					{
						await zV7Uq7ET8C(P_0, item, 当前方案, value, value2);
					}
					else
					{
						await 中州_统一化身提交处理(P_0, item, 当前方案, value, value2);
					}
					await Task.Delay(500);
					continue;
				}
				break;
			}
			P_0.C_Send(Singleton<WdAPI>.I.QewoEwLLTD("正在提交中", 0));
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#G执行完毕，背包中所有符合条件的化身已全部提交！#n"));
		}
		catch (Exception ex)
		{
			Log.Error("浮生录化身全部提交处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void GeRUtub77Z(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (J7aWuMQOCf())
			{
				wYBUA0iYep(P_0, P_1);
			}
			else
			{
				if (!int.TryParse(P_1.Replace("浮生录_使用特效道具", ""), out var result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result))
				{
					return;
				}
				if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 1)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的背包已满，无法进行化身激活处理。"));
					return;
				}
				if (!Singleton<WdAPI>.I.dSCoKmGWP9(P_0))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的宠物栏已满，无法进行化身激活处理。"));
					return;
				}
				浮生录存档类 浮生录存档类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.浮生录数据.方案1 : P_0.user.存档数据.浮生录数据.方案2);
				if (浮生录存档类2.is全部激活)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("当前加点方案的所有浮生录化身已经全部激活并加护成功，无法重复激活！"));
					return;
				}
				浮生录存档类2.is全部激活 = true;
				P_0.S_Send(Singleton<WdAPI>.I.naeodnd6MY(result));
				new 浮生属性加护类();
				StringBuilder stringBuilder = new StringBuilder();
				if (!J7aWuMQOCf())
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
					handler.AppendLiteral("#Y加点方案");
					handler.AppendFormatted(P_0.user.缓存数据.is加点方案一 ? "一" : "二");
					handler.AppendLiteral("#n");
					stringBuilder2.Append(ref handler);
				}
				相性池 相性池2 = jZeUzBCr9t();
				相性池2.金 -= 浮生录存档类2.浮生属性.金相性;
				相性池2.木 -= 浮生录存档类2.浮生属性.木相性;
				相性池2.水 -= 浮生录存档类2.浮生属性.水相性;
				相性池2.火 -= 浮生录存档类2.浮生属性.火相性;
				相性池2.土 -= 浮生录存档类2.浮生属性.土相性;
				浮生录存档类2.浮生属性.金相性 = 相性池2.金;
				浮生录存档类2.浮生属性.木相性 = 相性池2.木;
				浮生录存档类2.浮生属性.水相性 = 相性池2.水;
				浮生录存档类2.浮生属性.火相性 = 相性池2.火;
				浮生录存档类2.浮生属性.土相性 = 相性池2.土;
				foreach (浮生化身配置类 value2 in Singleton<全局变量类>.I.浮生录配置.化身列表.Values)
				{
					if (!浮生录存档类2.化身列表.TryGetValue(value2.化身名字, out var value))
					{
						value = new 浮生录化身列表类
						{
							化身名字 = value2.化身名字,
							激活进度 = 100,
							分类 = value2.分类
						};
						浮生录存档类2.化身列表.TryAdd(value2.化身名字, value);
					}
					value.激活进度 = 100;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.metal, 相性池2.金, false, "[浮生录]属性增加");
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.wood, 相性池2.木, false, "[浮生录]属性增加");
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.water, 相性池2.水, false, "[浮生录]属性增加");
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.fire, 相性池2.火, false, "[浮生录]属性增加");
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.earth, 相性池2.土, false, "[浮生录]属性增加");
				stringBuilder.Append("的所有浮生录化身已全部激活至#Y100%#n且化身属性加护成功，请刷新面板查看！");
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(stringBuilder.ToString()));
			}
		}
		catch (Exception ex)
		{
			Log.Error("使用特效道具处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void wYBUA0iYep(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (!int.TryParse(P_1.Replace("浮生录_使用特效道具", ""), out var result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result))
			{
				return;
			}
			if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的背包已满，无法进行化身激活处理。"));
				return;
			}
			if (!Singleton<WdAPI>.I.dSCoKmGWP9(P_0))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的宠物栏已满，无法进行化身激活处理。"));
				return;
			}
			浮生录存档类 浮生录存档类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.浮生录数据.方案1 : P_0.user.存档数据.浮生录数据.方案2);
			if (浮生录存档类2.is全部激活)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("当前加点方案的所有浮生录化身已经全部激活并加护成功，无法重复激活！"));
				return;
			}
			浮生录存档类2.is全部激活 = true;
			P_0.S_Send(Singleton<WdAPI>.I.naeodnd6MY(result));
			ConcurrentDictionary<string, string> concurrentDictionary = new ConcurrentDictionary<string, string>();
			if (Ih6WdCmIqb.Count != 浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.乱世书 && x.激活进度 >= 100))
			{
				P_0.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制乱世书属性, Singleton<全局变量类>.I.浮生录配置.乱世书数值, out var text);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制乱世书属性);
				if (!concurrentDictionary.TryGetValue(defaultInterpolatedStringHandler.ToStringAndClear(), out var value))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制乱世书属性);
					concurrentDictionary.TryAdd(defaultInterpolatedStringHandler.ToStringAndClear(), text);
				}
				else if (int.Parse(value) < int.Parse(text))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制乱世书属性);
					concurrentDictionary[defaultInterpolatedStringHandler.ToStringAndClear()] = text;
				}
			}
			if (CsTWsdbKp5.Count != 浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.千钧卷 && x.激活进度 >= 100))
			{
				P_0.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性, Singleton<全局变量类>.I.浮生录配置.千钧卷数值, out var text2);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性);
				if (!concurrentDictionary.TryGetValue(defaultInterpolatedStringHandler.ToStringAndClear(), out var value2))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性);
					concurrentDictionary.TryAdd(defaultInterpolatedStringHandler.ToStringAndClear(), text2);
				}
				else if (int.Parse(value2) < int.Parse(text2))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性);
					concurrentDictionary[defaultInterpolatedStringHandler.ToStringAndClear()] = text2;
				}
			}
			if (nppWUisDdB.Count != 浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.灵虚卷 && x.激活进度 >= 100))
			{
				P_0.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性, Singleton<全局变量类>.I.浮生录配置.灵虚卷数值, out var text3);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性);
				if (!concurrentDictionary.TryGetValue(defaultInterpolatedStringHandler.ToStringAndClear(), out var value3))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性);
					concurrentDictionary.TryAdd(defaultInterpolatedStringHandler.ToStringAndClear(), text3);
				}
				else if (int.Parse(value3) < int.Parse(text3))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性);
					concurrentDictionary[defaultInterpolatedStringHandler.ToStringAndClear()] = text3;
				}
			}
			if (RNoWWSOvFy.Count != 浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.御元卷 && x.激活进度 >= 100))
			{
				P_0.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制御元卷属性, Singleton<全局变量类>.I.浮生录配置.御元卷数值, out var text4);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制御元卷属性);
				if (!concurrentDictionary.TryGetValue(defaultInterpolatedStringHandler.ToStringAndClear(), out var value4))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制御元卷属性);
					concurrentDictionary.TryAdd(defaultInterpolatedStringHandler.ToStringAndClear(), text4);
				}
				else if (int.Parse(value4) < int.Parse(text4))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制御元卷属性);
					concurrentDictionary[defaultInterpolatedStringHandler.ToStringAndClear()] = text4;
				}
			}
			if (LHGWgAIE0Z.Count != 浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.乘风卷 && x.激活进度 >= 100))
			{
				P_0.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性, Singleton<全局变量类>.I.浮生录配置.乘风卷数值, out var text5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性);
				concurrentDictionary.TryAdd(defaultInterpolatedStringHandler.ToStringAndClear(), text5);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性);
				if (!concurrentDictionary.TryGetValue(defaultInterpolatedStringHandler.ToStringAndClear(), out var value5))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性);
					concurrentDictionary.TryAdd(defaultInterpolatedStringHandler.ToStringAndClear(), text5);
				}
				else if (int.Parse(value5) < int.Parse(text5))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性);
					concurrentDictionary[defaultInterpolatedStringHandler.ToStringAndClear()] = text5;
				}
			}
			StringBuilder stringBuilder = new StringBuilder();
			if (!J7aWuMQOCf())
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
				handler.AppendLiteral("#Y加点方案");
				handler.AppendFormatted(P_0.user.缓存数据.is加点方案一 ? "一" : "二");
				handler.AppendLiteral("#n");
				stringBuilder2.Append(ref handler);
			}
			foreach (浮生化身配置类 value8 in Singleton<全局变量类>.I.浮生录配置.化身列表.Values)
			{
				if (!浮生录存档类2.化身列表.TryGetValue(value8.化身名字, out var value6))
				{
					value6 = new 浮生录化身列表类
					{
						化身名字 = value8.化身名字,
						激活进度 = 100,
						分类 = value8.分类,
						属性名字 = value8.属性名字,
						属性数值 = value8.属性数值
					};
					浮生录存档类2.化身列表.TryAdd(value8.化身名字, value6);
				}
				else if (value6.激活进度 >= 100)
				{
					continue;
				}
				value6.激活进度 = 100;
				P_0.user.存档数据.中州论道存档.jxpIgn1imh(value8.属性名字, value8.属性数值, out var text6);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)value8.属性名字);
				if (!concurrentDictionary.TryGetValue(defaultInterpolatedStringHandler.ToStringAndClear(), out var value7))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)value8.属性名字);
					concurrentDictionary.TryAdd(defaultInterpolatedStringHandler.ToStringAndClear(), text6);
				}
				else if (int.Parse(value7) < int.Parse(text6))
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)value8.属性名字);
					concurrentDictionary[defaultInterpolatedStringHandler.ToStringAndClear()] = text6;
				}
			}
			List<string[]> list = new List<string[]>();
			foreach (KeyValuePair<string, string> item in concurrentDictionary)
			{
				list.Add(new string[2] { item.Key, item.Value });
			}
			Singleton<fuMNpgieFTYU3Wah53>.I.mMMfZ3LX2(P_0, list);
			stringBuilder.Append("的所有浮生录化身已全部激活至#Y100%#n且化身属性加护成功，请刷新面板查看！");
			P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("中州_使用特效道具处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private 相性池 jZeUzBCr9t()
	{
		相性池 result = default(相性池);
		if (Singleton<全局变量类>.I.浮生录配置.乱世书属性 == AllEnums.属性Type.金相性)
		{
			result.金 += Singleton<全局变量类>.I.浮生录配置.乱世书数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.乱世书属性 == AllEnums.属性Type.木相性)
		{
			result.木 += Singleton<全局变量类>.I.浮生录配置.乱世书数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.乱世书属性 == AllEnums.属性Type.水相性)
		{
			result.水 += Singleton<全局变量类>.I.浮生录配置.乱世书数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.乱世书属性 == AllEnums.属性Type.火相性)
		{
			result.火 += Singleton<全局变量类>.I.浮生录配置.乱世书数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.乱世书属性 == AllEnums.属性Type.土相性)
		{
			result.土 += Singleton<全局变量类>.I.浮生录配置.乱世书数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.乱世书属性 == AllEnums.属性Type.所有相性)
		{
			result.金 += Singleton<全局变量类>.I.浮生录配置.乱世书数值;
			result.木 += Singleton<全局变量类>.I.浮生录配置.乱世书数值;
			result.水 += Singleton<全局变量类>.I.浮生录配置.乱世书数值;
			result.火 += Singleton<全局变量类>.I.浮生录配置.乱世书数值;
			result.土 += Singleton<全局变量类>.I.浮生录配置.乱世书数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.千钧卷属性 == AllEnums.属性Type.金相性)
		{
			result.金 += Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.千钧卷属性 == AllEnums.属性Type.木相性)
		{
			result.木 += Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.千钧卷属性 == AllEnums.属性Type.水相性)
		{
			result.水 += Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.千钧卷属性 == AllEnums.属性Type.火相性)
		{
			result.火 += Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.千钧卷属性 == AllEnums.属性Type.土相性)
		{
			result.土 += Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.千钧卷属性 == AllEnums.属性Type.所有相性)
		{
			result.金 += Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
			result.木 += Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
			result.水 += Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
			result.火 += Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
			result.土 += Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.灵虚卷属性 == AllEnums.属性Type.金相性)
		{
			result.金 += Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.灵虚卷属性 == AllEnums.属性Type.木相性)
		{
			result.木 += Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.灵虚卷属性 == AllEnums.属性Type.水相性)
		{
			result.水 += Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.灵虚卷属性 == AllEnums.属性Type.火相性)
		{
			result.火 += Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.灵虚卷属性 == AllEnums.属性Type.土相性)
		{
			result.土 += Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.灵虚卷属性 == AllEnums.属性Type.所有相性)
		{
			result.金 += Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
			result.木 += Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
			result.水 += Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
			result.火 += Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
			result.土 += Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.御元卷属性 == AllEnums.属性Type.金相性)
		{
			result.金 += Singleton<全局变量类>.I.浮生录配置.御元卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.御元卷属性 == AllEnums.属性Type.木相性)
		{
			result.木 += Singleton<全局变量类>.I.浮生录配置.御元卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.御元卷属性 == AllEnums.属性Type.水相性)
		{
			result.水 += Singleton<全局变量类>.I.浮生录配置.御元卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.御元卷属性 == AllEnums.属性Type.火相性)
		{
			result.火 += Singleton<全局变量类>.I.浮生录配置.御元卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.御元卷属性 == AllEnums.属性Type.土相性)
		{
			result.土 += Singleton<全局变量类>.I.浮生录配置.御元卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.御元卷属性 == AllEnums.属性Type.所有相性)
		{
			result.金 += Singleton<全局变量类>.I.浮生录配置.御元卷数值;
			result.木 += Singleton<全局变量类>.I.浮生录配置.御元卷数值;
			result.水 += Singleton<全局变量类>.I.浮生录配置.御元卷数值;
			result.火 += Singleton<全局变量类>.I.浮生录配置.御元卷数值;
			result.土 += Singleton<全局变量类>.I.浮生录配置.御元卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.乘风卷属性 == AllEnums.属性Type.金相性)
		{
			result.金 += Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.乘风卷属性 == AllEnums.属性Type.木相性)
		{
			result.木 += Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.乘风卷属性 == AllEnums.属性Type.水相性)
		{
			result.水 += Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.乘风卷属性 == AllEnums.属性Type.火相性)
		{
			result.火 += Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.乘风卷属性 == AllEnums.属性Type.土相性)
		{
			result.土 += Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
		}
		if (Singleton<全局变量类>.I.浮生录配置.乘风卷属性 == AllEnums.属性Type.所有相性)
		{
			result.金 += Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
			result.木 += Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
			result.水 += Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
			result.火 += Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
			result.土 += Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
		}
		return result;
	}

	
	public 浮生录功能()
	{
		Ih6WdCmIqb = new List<浮生化身配置类>();
		CsTWsdbKp5 = new List<浮生化身配置类>();
		nppWUisDdB = new List<浮生化身配置类>();
		RNoWWSOvFy = new List<浮生化身配置类>();
		LHGWgAIE0Z = new List<浮生化身配置类>();
	}

	
	static 浮生录功能()
	{
		XgSWRaXXjY = new ConcurrentDictionary<AllEnums.化身分类, 相性池>();
	}
}
