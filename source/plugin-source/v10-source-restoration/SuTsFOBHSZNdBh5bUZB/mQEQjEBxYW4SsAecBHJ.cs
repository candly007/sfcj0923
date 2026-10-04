using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace SuTsFOBHSZNdBh5bUZB;

internal class mQEQjEBxYW4SsAecBHJ : Singleton<mQEQjEBxYW4SsAecBHJ>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public int NgEa7GpjTG;

		
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		
		internal bool CVMave65bU(娃娃缓存数据类 x)
		{
			return x.娃娃ID == NgEa7GpjTG;
		}

		static _003C_003Ec__DisplayClass11_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public int iGoaTl4TbN;

		
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		
		internal bool jvBaawaS8O(娃娃缓存数据类 x)
		{
			return x.娃娃ID == iGoaTl4TbN;
		}

		static _003C_003Ec__DisplayClass13_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public MyNATSocketClient pThak61KGj;

		public int zC0a079I31;

		public int m7faO3tCOL;

		public 娃娃缓存数据类 P4NaQkR6Yv;

		public List<娃娃技能列表类> JcKaEIt70O;

		
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		
		internal bool Y16a9FGlqB(娃娃缓存数据类 x)
		{
			if (x.娃娃index != 0)
			{
				return x.娃娃ID == zC0a079I31;
			}
			return false;
		}

		
		internal bool ISVay7dt7c(娃娃技能列表类 x)
		{
			if (x.门派 == (AllEnums.五行Type)m7faO3tCOL)
			{
				return x.技能id != 0;
			}
			return false;
		}

		
		internal void rWOaCeNglU(string v)
		{
			if (!(v != Singleton<全局变量类>.I.娃娃配置.门派道具))
			{
				pThak61KGj.销毁回调事件 = null;
				MyNATSocketClient myNATSocketClient = pThak61KGj;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你的#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P4NaQkR6Yv.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n成功拜入了#R");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.五行Type)m7faO3tCOL);
				defaultInterpolatedStringHandler.AppendLiteral("系#n副门派。");
				myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				for (int j = 0; j < JcKaEIt70O.Count; j++)
				{
					Singleton<WdAPI>.I.W9lI1TZlUs(pThak61KGj, pThak61KGj.user.人物数据.昵称, P4NaQkR6Yv.娃娃ID.ToString(), JcKaEIt70O[j].技能id.ToString(), "1");
					MyNATSocketClient myNATSocketClient2 = pThak61KGj;
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P4NaQkR6Yv.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n成功学习了#R");
					defaultInterpolatedStringHandler.AppendFormatted(JcKaEIt70O[j].技能名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n技能。");
					myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			}
		}

		
		internal void mURaVZFS9H(string v)
		{
			if (!(v != Singleton<全局变量类>.I.娃娃配置.遗忘道具))
			{
				pThak61KGj.销毁回调事件 = null;
				MyNATSocketClient myNATSocketClient = pThak61KGj;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你的#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P4NaQkR6Yv.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n成功退出了#R");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.五行Type)m7faO3tCOL);
				defaultInterpolatedStringHandler.AppendLiteral("系#n副门派。");
				myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				for (int j = 0; j < JcKaEIt70O.Count; j++)
				{
					Singleton<WdAPI>.I.W9lI1TZlUs(pThak61KGj, pThak61KGj.user.人物数据.昵称, P4NaQkR6Yv.娃娃ID.ToString(), JcKaEIt70O[j].技能id.ToString(), "0");
					MyNATSocketClient myNATSocketClient2 = pThak61KGj;
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P4NaQkR6Yv.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n失去了#R");
					defaultInterpolatedStringHandler.AppendFormatted(JcKaEIt70O[j].技能名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n技能。");
					myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			}
		}

		static _003C_003Ec__DisplayClass14_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public int dg6aYlPinV;

		
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		
		internal bool G4Da3agHxB(娃娃缓存数据类 x)
		{
			if (x.娃娃index != 0)
			{
				return x.娃娃ID == dg6aYlPinV;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass15_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public MyNATSocketClient otqa1ROak5;

		public mQEQjEBxYW4SsAecBHJ vGPaxjg0t1;

		public 娃娃缓存数据类 VlJaHyTRCG;

		
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		
		internal void xtUapaIev9(string v)
		{
			if (!(v != Singleton<全局变量类>.I.娃娃配置.五系娃娃速成道具))
			{
				otqa1ROak5.销毁回调事件 = null;
				Singleton<WdAPI>.I.W9lI1TZlUs(otqa1ROak5, otqa1ROak5.user.人物数据.昵称, VlJaHyTRCG.娃娃ID.ToString(), "451", $"{VlJaHyTRCG.等级}");
				Singleton<WdAPI>.I.W9lI1TZlUs(otqa1ROak5, otqa1ROak5.user.人物数据.昵称, VlJaHyTRCG.娃娃ID.ToString(), "452", $"{VlJaHyTRCG.等级}");
				Singleton<WdAPI>.I.W9lI1TZlUs(otqa1ROak5, otqa1ROak5.user.人物数据.昵称, VlJaHyTRCG.娃娃ID.ToString(), "453", $"{VlJaHyTRCG.等级}");
				Singleton<WdAPI>.I.W9lI1TZlUs(otqa1ROak5, otqa1ROak5.user.人物数据.昵称, VlJaHyTRCG.娃娃ID.ToString(), "454", $"{VlJaHyTRCG.等级}");
				Singleton<WdAPI>.I.W9lI1TZlUs(otqa1ROak5, otqa1ROak5.user.人物数据.昵称, VlJaHyTRCG.娃娃ID.ToString(), "455", $"{VlJaHyTRCG.等级}");
				Singleton<WdAPI>.I.W9lI1TZlUs(otqa1ROak5, otqa1ROak5.user.人物数据.昵称, VlJaHyTRCG.娃娃ID.ToString(), "456", $"{VlJaHyTRCG.等级}");
				Singleton<WdAPI>.I.W9lI1TZlUs(otqa1ROak5, otqa1ROak5.user.人物数据.昵称, VlJaHyTRCG.娃娃ID.ToString(), "457", $"{VlJaHyTRCG.等级}");
				Singleton<WdAPI>.I.W9lI1TZlUs(otqa1ROak5, otqa1ROak5.user.人物数据.昵称, VlJaHyTRCG.娃娃ID.ToString(), "458", $"{VlJaHyTRCG.等级}");
				Singleton<WdAPI>.I.W9lI1TZlUs(otqa1ROak5, otqa1ROak5.user.人物数据.昵称, VlJaHyTRCG.娃娃ID.ToString(), "459", $"{VlJaHyTRCG.等级}");
				Singleton<WdAPI>.I.W9lI1TZlUs(otqa1ROak5, otqa1ROak5.user.人物数据.昵称, VlJaHyTRCG.娃娃ID.ToString(), "460", $"{VlJaHyTRCG.等级}");
				Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
				if (client频道事件 != null)
				{
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 2);
					defaultInterpolatedStringHandler.AppendLiteral("恭喜#Y");
					defaultInterpolatedStringHandler.AppendFormatted(otqa1ROak5.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("#n的娃娃使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.娃娃配置.五系娃娃速成道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n，自动学习了五系门派的所有技能，可喜可贺啊！");
					client频道事件(i.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
				}
			}
		}

		static _003C_003Ec__DisplayClass8_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public 娃娃技能列表类 lNga4RGRl2;

		public _003C_003Ec__DisplayClass8_0 X8jaeG5v1J;

		
		public _003C_003Ec__DisplayClass8_1()
		{
		}

		static _003C_003Ec__DisplayClass8_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_2
	{
		public int ImaarZPu7x;

		public int dfFaZCV09t;

		public _003C_003Ec__DisplayClass8_1 b0qatxhQJe;

		
		public _003C_003Ec__DisplayClass8_2()
		{
		}

		
		internal void kP0aq2pJM8(string v)
		{
			if (!(v != Singleton<全局变量类>.I.娃娃配置.亲密道具))
			{
				b0qatxhQJe.X8jaeG5v1J.otqa1ROak5.销毁回调事件 = null;
				b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.亲密 += ImaarZPu7x;
				Singleton<WdAPI>.I.lvuI30yCQE(b0qatxhQJe.X8jaeG5v1J.otqa1ROak5, b0qatxhQJe.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), "intimacy", $"{b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.亲密}", "admin_set_attrib");
				MyNATSocketClient myNATSocketClient = b0qatxhQJe.X8jaeG5v1J.otqa1ROak5;
				byte[] first = b0qatxhQJe.X8jaeG5v1J.vGPaxjg0t1.pKRGw0dMQ2(b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.娃娃ID, b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.亲密);
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 4);
				defaultInterpolatedStringHandler.AppendLiteral("你对#Y");
				defaultInterpolatedStringHandler.AppendFormatted(b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n使用了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(dfFaZCV09t);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.娃娃配置.亲密道具);
				defaultInterpolatedStringHandler.AppendLiteral("#n，你与娃娃的亲密度提升了#R");
				defaultInterpolatedStringHandler.AppendFormatted(ImaarZPu7x);
				defaultInterpolatedStringHandler.AppendLiteral("#n点。");
				myNATSocketClient.C_Send(first.Concat(i.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
			}
		}

		static _003C_003Ec__DisplayClass8_2()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_3
	{
		public int pSMazmH2cw;

		public int KeLTumiHyN;

		public _003C_003Ec__DisplayClass8_1 NX1TwMwZe4;

		
		public _003C_003Ec__DisplayClass8_3()
		{
		}

		
		internal void iUMaAiRBu1(string v)
		{
			if (!(v != NX1TwMwZe4.lNga4RGRl2.升级道具))
			{
				NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5.销毁回调事件 = null;
				Singleton<WdAPI>.I.W9lI1TZlUs(NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5, NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, NX1TwMwZe4.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), NX1TwMwZe4.lNga4RGRl2.技能id.ToString(), $"{pSMazmH2cw + KeLTumiHyN}");
				MyNATSocketClient myNATSocketClient = NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 6);
				defaultInterpolatedStringHandler.AppendLiteral("你给#Y");
				defaultInterpolatedStringHandler.AppendFormatted(NX1TwMwZe4.X8jaeG5v1J.VlJaHyTRCG.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n使用了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(KeLTumiHyN);
				defaultInterpolatedStringHandler.AppendLiteral("#n本#R");
				defaultInterpolatedStringHandler.AppendFormatted(NX1TwMwZe4.lNga4RGRl2.升级道具);
				defaultInterpolatedStringHandler.AppendLiteral("#n使#R");
				defaultInterpolatedStringHandler.AppendFormatted(NX1TwMwZe4.lNga4RGRl2.技能名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n技能从#R");
				defaultInterpolatedStringHandler.AppendFormatted(pSMazmH2cw);
				defaultInterpolatedStringHandler.AppendLiteral("#n级提升到了#R");
				defaultInterpolatedStringHandler.AppendFormatted(pSMazmH2cw + KeLTumiHyN);
				defaultInterpolatedStringHandler.AppendLiteral("#n级。");
				myNATSocketClient.C_Send(i.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}

		static _003C_003Ec__DisplayClass8_3()
		{
		}
	}

	internal static StringBuilder ai7Gs687BS;

	
	[SpecialName]
	internal static bool IOQGR6WRUK()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is娃娃系统)
		{
			return Singleton<全局变量类>.I.娃娃配置.功能开关;
		}
		return false;
	}

	
	internal void WOBB4mX1tE()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("娃娃配置类.json")))
			{
				Singleton<全局变量类>.I.娃娃配置 = JsonConvert.DeserializeObject<娃娃配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("娃娃配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.娃娃配置.功能开关 = true;
				Singleton<全局变量类>.I.娃娃配置.亲密道具 = "以父之名鞭";
				Singleton<全局变量类>.I.娃娃配置.增加亲密 = 10000;
				Singleton<全局变量类>.I.娃娃配置.亲密上限 = 10000000;
				Singleton<全局变量类>.I.娃娃配置.门派上限 = 2;
				Singleton<全局变量类>.I.娃娃配置.门派道具 = "门派介绍信";
				Singleton<全局变量类>.I.娃娃配置.遗忘道具 = "门派遗忘水";
				Singleton<全局变量类>.I.娃娃配置.技能列表.TryAdd("力拔山河技能卷轴", new 娃娃技能列表类
				{
					升级道具 = "力拔山河技能卷轴",
					技能名字 = "力拔山河",
					技能id = 456,
					门派 = AllEnums.五行Type.金,
					等级上限 = 330
				});
				Singleton<全局变量类>.I.娃娃配置.技能列表.TryAdd("五雷照顶技能卷轴", new 娃娃技能列表类
				{
					升级道具 = "五雷照顶技能卷轴",
					技能名字 = "五雷照顶",
					技能id = 451,
					门派 = AllEnums.五行Type.金,
					等级上限 = 330
				});
				Singleton<全局变量类>.I.娃娃配置.技能列表.TryAdd("枯木逢春技能卷轴", new 娃娃技能列表类
				{
					升级道具 = "枯木逢春技能卷轴",
					技能名字 = "枯木逢春",
					技能id = 452,
					门派 = AllEnums.五行Type.木,
					等级上限 = 330
				});
				Singleton<全局变量类>.I.娃娃配置.技能列表.TryAdd("玉露还阳技能卷轴", new 娃娃技能列表类
				{
					升级道具 = "玉露还阳技能卷轴",
					技能名字 = "玉露还阳",
					技能id = 457,
					门派 = AllEnums.五行Type.木,
					等级上限 = 330
				});
				Singleton<全局变量类>.I.娃娃配置.技能列表.TryAdd("川流不息技能卷轴", new 娃娃技能列表类
				{
					升级道具 = "川流不息技能卷轴",
					技能名字 = "川流不息",
					技能id = 453,
					门派 = AllEnums.五行Type.水,
					等级上限 = 330
				});
				Singleton<全局变量类>.I.娃娃配置.技能列表.TryAdd("行云流水技能卷轴", new 娃娃技能列表类
				{
					升级道具 = "行云流水技能卷轴",
					技能名字 = "行云流水",
					技能id = 458,
					门派 = AllEnums.五行Type.水,
					等级上限 = 330
				});
				Singleton<全局变量类>.I.娃娃配置.技能列表.TryAdd("道亦有道技能卷轴", new 娃娃技能列表类
				{
					升级道具 = "道亦有道技能卷轴",
					技能名字 = "道亦有道",
					技能id = 454,
					门派 = AllEnums.五行Type.火,
					等级上限 = 330
				});
				Singleton<全局变量类>.I.娃娃配置.技能列表.TryAdd("大道无为技能卷轴", new 娃娃技能列表类
				{
					升级道具 = "大道无为技能卷轴",
					技能名字 = "大道无为",
					技能id = 459,
					门派 = AllEnums.五行Type.火,
					等级上限 = 330
				});
				Singleton<全局变量类>.I.娃娃配置.技能列表.TryAdd("天道自然技能卷轴", new 娃娃技能列表类
				{
					升级道具 = "天道自然技能卷轴",
					技能名字 = "天道自然",
					技能id = 460,
					门派 = AllEnums.五行Type.土,
					等级上限 = 330
				});
				Singleton<全局变量类>.I.娃娃配置.技能列表.TryAdd("捕风捉影技能卷轴", new 娃娃技能列表类
				{
					升级道具 = "捕风捉影技能卷轴",
					技能名字 = "捕风捉影",
					技能id = 455,
					门派 = AllEnums.五行Type.土,
					等级上限 = 330
				});
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("娃娃配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.娃娃配置, Formatting.Indented));
			}
			ai7Gs687BS.Clear();
			StringBuilder stringBuilder = ai7Gs687BS;
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 4, stringBuilder);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.娃娃配置.五系娃娃速成道具);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.娃娃配置.亲密道具);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.娃娃配置.门派道具);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.娃娃配置.遗忘道具);
			handler.AppendLiteral("|");
			stringBuilder2.Append(ref handler);
			foreach (string key in Singleton<全局变量类>.I.娃娃配置.技能列表.Keys)
			{
				stringBuilder = ai7Gs687BS;
				StringBuilder stringBuilder3 = stringBuilder;
				handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder);
				handler.AppendFormatted(key);
				handler.AppendLiteral("|");
				stringBuilder3.Append(ref handler);
			}
		}
		catch (Exception ex)
		{
			Log.Error("娃娃配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void ojLBeONuxV()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("娃娃配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.娃娃配置, Formatting.Indented));
			Log.Debug("娃娃配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("娃娃配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string IvkBquR2HE()
	{
		WOBB4mX1tE();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.娃娃配置, Formatting.Indented);
	}

	
	public void tvYBru4LWD(string P_0)
	{
		Singleton<全局变量类>.I.娃娃配置 = JsonConvert.DeserializeObject<娃娃配置类>(P_0);
		ojLBeONuxV();
	}

	
	public static bool a4HBZHHjWC(string P_0)
	{
		if (IOQGR6WRUK())
		{
			return Singleton<ByteAPI>.I.寻找文本(ai7Gs687BS.ToString(), "|" + P_0 + "|");
		}
		return false;
	}

	
	internal byte[] TkXBtCEc5i(MyNATSocketClient P_0, byte[] P_1)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_4 = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_4.otqa1ROak5 = P_0;
		_003C_003Ec__DisplayClass8_4.vGPaxjg0t1 = this;
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(12L, SeekOrigin.Begin);
			封包_读2.读字节型(out var value);
			if (value < 1 || value > 5)
			{
				return null;
			}
			封包_读2.读字节型(out var value2);
			if (!Singleton<WdAPI>.I.wfboRXZawH(_003C_003Ec__DisplayClass8_4.otqa1ROak5, value2, true))
			{
				return null;
			}
			if (_003C_003Ec__DisplayClass8_4.otqa1ROak5.user.背包数据.物品列表[value2].数量 < 1)
			{
				return null;
			}
			if (IOQGR6WRUK() && Singleton<ByteAPI>.I.寻找文本(ai7Gs687BS.ToString(), "|" + _003C_003Ec__DisplayClass8_4.otqa1ROak5.user.背包数据.物品列表[value2].名字 + "|"))
			{
				_003C_003Ec__DisplayClass8_4.otqa1ROak5.C_Send(Singleton<WdAPI>.I.TMjoSFpjbL(_003C_003Ec__DisplayClass8_4.otqa1ROak5.user.背包数据.物品列表[value2]));
				_003C_003Ec__DisplayClass8_4.VlJaHyTRCG = _003C_003Ec__DisplayClass8_4.otqa1ROak5.user.娃娃数据[value];
				if (_003C_003Ec__DisplayClass8_4.VlJaHyTRCG.娃娃ID == 0)
				{
					return null;
				}
				lock (_003C_003Ec__DisplayClass8_4.otqa1ROak5.喂养频率锁)
				{
					_003C_003Ec__DisplayClass8_1 _003C_003Ec__DisplayClass8_5 = new _003C_003Ec__DisplayClass8_1();
					_003C_003Ec__DisplayClass8_5.X8jaeG5v1J = _003C_003Ec__DisplayClass8_4;
					if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.背包数据.物品列表[value2].名字 == Singleton<全局变量类>.I.娃娃配置.五系娃娃速成道具)
					{
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.Count >= 10)
						{
							_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y" + _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.昵称A + "#n已经学习过所有门派的技能了。"));
							return null;
						}
						_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.销毁回调事件 =  (string v) =>
						{
							if (!(v != Singleton<全局变量类>.I.娃娃配置.五系娃娃速成道具))
							{
								_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.销毁回调事件 = null;
								Singleton<WdAPI>.I.W9lI1TZlUs(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), "451", $"{_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.等级}");
								Singleton<WdAPI>.I.W9lI1TZlUs(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), "452", $"{_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.等级}");
								Singleton<WdAPI>.I.W9lI1TZlUs(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), "453", $"{_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.等级}");
								Singleton<WdAPI>.I.W9lI1TZlUs(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), "454", $"{_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.等级}");
								Singleton<WdAPI>.I.W9lI1TZlUs(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), "455", $"{_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.等级}");
								Singleton<WdAPI>.I.W9lI1TZlUs(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), "456", $"{_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.等级}");
								Singleton<WdAPI>.I.W9lI1TZlUs(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), "457", $"{_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.等级}");
								Singleton<WdAPI>.I.W9lI1TZlUs(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), "458", $"{_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.等级}");
								Singleton<WdAPI>.I.W9lI1TZlUs(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), "459", $"{_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.等级}");
								Singleton<WdAPI>.I.W9lI1TZlUs(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), "460", $"{_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.等级}");
								Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
								if (client频道事件 != null)
								{
									WdAPI i5 = Singleton<WdAPI>.I;
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(37, 2);
									defaultInterpolatedStringHandler2.AppendLiteral("恭喜#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称);
									defaultInterpolatedStringHandler2.AppendLiteral("#n的娃娃使用#R");
									defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.娃娃配置.五系娃娃速成道具);
									defaultInterpolatedStringHandler2.AppendLiteral("#n，自动学习了五系门派的所有技能，可喜可贺啊！");
									client频道事件(i5.组包聊天信息(defaultInterpolatedStringHandler2.ToStringAndClear(), "管理员"));
								}
							}
						};
						_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(value2, 1));
						return null;
					}
					if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.背包数据.物品列表[value2].名字 == Singleton<全局变量类>.I.娃娃配置.亲密道具)
					{
						_003C_003Ec__DisplayClass8_2 CS_0024_003C_003E8__locals55 = new _003C_003Ec__DisplayClass8_2();
						CS_0024_003C_003E8__locals55.b0qatxhQJe = _003C_003Ec__DisplayClass8_5;
						if (CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.亲密 >= Singleton<全局变量类>.I.娃娃配置.亲密上限)
						{
							MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.otqa1ROak5;
							WdAPI i = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 3);
							defaultInterpolatedStringHandler.AppendLiteral("#Y");
							defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.昵称A);
							defaultInterpolatedStringHandler.AppendLiteral("#n与你的亲密度已经达到了#R");
							defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.娃娃配置.亲密上限);
							defaultInterpolatedStringHandler.AppendLiteral("#n点，无法使用#R");
							defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.娃娃配置.亲密道具);
							defaultInterpolatedStringHandler.AppendLiteral("#n提升亲密度了。");
							myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return null;
						}
						CS_0024_003C_003E8__locals55.dfFaZCV09t = 1;
						CS_0024_003C_003E8__locals55.ImaarZPu7x = ((Singleton<全局变量类>.I.娃娃配置.亲密上限 - CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.亲密 < Singleton<全局变量类>.I.娃娃配置.增加亲密) ? (Singleton<全局变量类>.I.娃娃配置.亲密上限 - CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.亲密) : Singleton<全局变量类>.I.娃娃配置.增加亲密);
						if (Singleton<全局变量类>.I.娃娃配置.一键喂养)
						{
							CS_0024_003C_003E8__locals55.ImaarZPu7x = ((Singleton<全局变量类>.I.娃娃配置.亲密上限 - CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.亲密 < Singleton<全局变量类>.I.娃娃配置.增加亲密 * CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.otqa1ROak5.user.背包数据.物品列表[value2].数量) ? (Singleton<全局变量类>.I.娃娃配置.亲密上限 - CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.亲密) : (Singleton<全局变量类>.I.娃娃配置.增加亲密 * CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.otqa1ROak5.user.背包数据.物品列表[value2].数量));
							CS_0024_003C_003E8__locals55.dfFaZCV09t = (int)Math.Ceiling((double)CS_0024_003C_003E8__locals55.ImaarZPu7x / (double)Singleton<全局变量类>.I.娃娃配置.增加亲密);
						}
						CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.otqa1ROak5.销毁回调事件 =  (string v) =>
						{
							if (!(v != Singleton<全局变量类>.I.娃娃配置.亲密道具))
							{
								CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.otqa1ROak5.销毁回调事件 = null;
								CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.亲密 += CS_0024_003C_003E8__locals55.ImaarZPu7x;
								Singleton<WdAPI>.I.lvuI30yCQE(CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.otqa1ROak5, CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), "intimacy", $"{CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.亲密}", "admin_set_attrib");
								MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.otqa1ROak5;
								byte[] first = CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.vGPaxjg0t1.pKRGw0dMQ2(CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.娃娃ID, CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.亲密);
								WdAPI i5 = Singleton<WdAPI>.I;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(36, 4);
								defaultInterpolatedStringHandler2.AppendLiteral("你对#Y");
								defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.VlJaHyTRCG.昵称A);
								defaultInterpolatedStringHandler2.AppendLiteral("#n使用了#Y");
								defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals55.dfFaZCV09t);
								defaultInterpolatedStringHandler2.AppendLiteral("#n个#R");
								defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.娃娃配置.亲密道具);
								defaultInterpolatedStringHandler2.AppendLiteral("#n，你与娃娃的亲密度提升了#R");
								defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals55.ImaarZPu7x);
								defaultInterpolatedStringHandler2.AppendLiteral("#n点。");
								myNATSocketClient5.C_Send(first.Concat(i5.提示_杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear())).ToArray());
							}
						};
						CS_0024_003C_003E8__locals55.b0qatxhQJe.X8jaeG5v1J.otqa1ROak5.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(value2, CS_0024_003C_003E8__locals55.dfFaZCV09t));
						return null;
					}
					if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.背包数据.物品列表[value2].名字 == Singleton<全局变量类>.I.娃娃配置.门派道具)
					{
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 == 0)
						{
							_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y" + _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.昵称A + "#n尚未拥有主门派，无法学习副门派技能。"));
							return null;
						}
						ConcurrentDictionary<int, bool> concurrentDictionary = new ConcurrentDictionary<int, bool>();
						foreach (KeyValuePair<string, int> item in _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表)
						{
							if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 1 && item.Value > 0 && Singleton<ByteAPI>.I.寻找文本等(item.Key, "力拔山河", "五雷照顶"))
							{
								concurrentDictionary.TryAdd(1, value: true);
							}
							else if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 2 && item.Value > 0 && Singleton<ByteAPI>.I.寻找文本等(item.Key, "枯木逢春", "玉露还阳"))
							{
								concurrentDictionary.TryAdd(2, value: true);
							}
							else if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 3 && item.Value > 0 && Singleton<ByteAPI>.I.寻找文本等(item.Key, "川流不息", "行云流水"))
							{
								concurrentDictionary.TryAdd(3, value: true);
							}
							else if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 4 && item.Value > 0 && Singleton<ByteAPI>.I.寻找文本等(item.Key, "道亦有道", "大道无为"))
							{
								concurrentDictionary.TryAdd(4, value: true);
							}
							else if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 5 && item.Value > 0 && Singleton<ByteAPI>.I.寻找文本等(item.Key, "天道自然", "捕风捉影"))
							{
								concurrentDictionary.TryAdd(5, value: true);
							}
						}
						if (concurrentDictionary.Count + 1 >= Singleton<全局变量类>.I.娃娃配置.门派上限)
						{
							MyNATSocketClient myNATSocketClient2 = _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5;
							WdAPI i2 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 2);
							defaultInterpolatedStringHandler.AppendLiteral("#Y");
							defaultInterpolatedStringHandler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.昵称A);
							defaultInterpolatedStringHandler.AppendLiteral("#n已经拥有了#R");
							defaultInterpolatedStringHandler.AppendFormatted(concurrentDictionary.Count + 1);
							defaultInterpolatedStringHandler.AppendLiteral("#n个门派的技能了，再无法学习新的副门派技能。");
							myNATSocketClient2.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return null;
						}
						List<string> list = new List<string>();
						StringBuilder stringBuilder = new StringBuilder("请选择你要给#Y" + _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.昵称A + "#n学习的新副门派：");
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 1 && !_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("力拔山河") && !_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("五雷照顶"))
						{
							if (Singleton<全局变量类>.I.娃娃配置.随机拜师)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
								defaultInterpolatedStringHandler.AppendLiteral("娃娃系统_拜师1|");
								defaultInterpolatedStringHandler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								defaultInterpolatedStringHandler.AppendLiteral("|");
								defaultInterpolatedStringHandler.AppendFormatted(value2);
								list.Add(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							else
							{
								StringBuilder stringBuilder2 = stringBuilder;
								StringBuilder stringBuilder3 = stringBuilder2;
								StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 2, stringBuilder2);
								handler.AppendLiteral("[拜入金系门下/娃娃系统_拜师1|");
								handler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								handler.AppendLiteral("|");
								handler.AppendFormatted(value2);
								handler.AppendLiteral("]");
								stringBuilder3.Append(ref handler);
							}
						}
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 2 && !_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("枯木逢春") && !_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("玉露还阳"))
						{
							if (Singleton<全局变量类>.I.娃娃配置.随机拜师)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
								defaultInterpolatedStringHandler.AppendLiteral("娃娃系统_拜师2|");
								defaultInterpolatedStringHandler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								defaultInterpolatedStringHandler.AppendLiteral("|");
								defaultInterpolatedStringHandler.AppendFormatted(value2);
								list.Add(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							else
							{
								StringBuilder stringBuilder2 = stringBuilder;
								StringBuilder stringBuilder4 = stringBuilder2;
								StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 2, stringBuilder2);
								handler.AppendLiteral("[拜入木系门下/娃娃系统_拜师2|");
								handler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								handler.AppendLiteral("|");
								handler.AppendFormatted(value2);
								handler.AppendLiteral("]");
								stringBuilder4.Append(ref handler);
							}
						}
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 3 && !_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("川流不息") && !_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("行云流水"))
						{
							if (Singleton<全局变量类>.I.娃娃配置.随机拜师)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
								defaultInterpolatedStringHandler.AppendLiteral("娃娃系统_拜师3|");
								defaultInterpolatedStringHandler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								defaultInterpolatedStringHandler.AppendLiteral("|");
								defaultInterpolatedStringHandler.AppendFormatted(value2);
								list.Add(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							else
							{
								StringBuilder stringBuilder2 = stringBuilder;
								StringBuilder stringBuilder5 = stringBuilder2;
								StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 2, stringBuilder2);
								handler.AppendLiteral("[拜入水系门下/娃娃系统_拜师3|");
								handler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								handler.AppendLiteral("|");
								handler.AppendFormatted(value2);
								handler.AppendLiteral("]");
								stringBuilder5.Append(ref handler);
							}
						}
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 4 && !_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("道亦有道") && !_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("大道无为"))
						{
							if (Singleton<全局变量类>.I.娃娃配置.随机拜师)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
								defaultInterpolatedStringHandler.AppendLiteral("娃娃系统_拜师4|");
								defaultInterpolatedStringHandler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								defaultInterpolatedStringHandler.AppendLiteral("|");
								defaultInterpolatedStringHandler.AppendFormatted(value2);
								list.Add(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							else
							{
								StringBuilder stringBuilder2 = stringBuilder;
								StringBuilder stringBuilder6 = stringBuilder2;
								StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 2, stringBuilder2);
								handler.AppendLiteral("[拜入火系门下/娃娃系统_拜师4|");
								handler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								handler.AppendLiteral("|");
								handler.AppendFormatted(value2);
								handler.AppendLiteral("]");
								stringBuilder6.Append(ref handler);
							}
						}
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 5 && !_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("天道自然") && !_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("捕风捉影"))
						{
							if (Singleton<全局变量类>.I.娃娃配置.随机拜师)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
								defaultInterpolatedStringHandler.AppendLiteral("娃娃系统_拜师5|");
								defaultInterpolatedStringHandler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								defaultInterpolatedStringHandler.AppendLiteral("|");
								defaultInterpolatedStringHandler.AppendFormatted(value2);
								list.Add(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							else
							{
								StringBuilder stringBuilder2 = stringBuilder;
								StringBuilder stringBuilder7 = stringBuilder2;
								StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 2, stringBuilder2);
								handler.AppendLiteral("[拜入土系门下/娃娃系统_拜师5|");
								handler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								handler.AppendLiteral("|");
								handler.AppendFormatted(value2);
								handler.AppendLiteral("]");
								stringBuilder7.Append(ref handler);
							}
						}
						if (Singleton<全局变量类>.I.娃娃配置.随机拜师)
						{
							fQRGJmw5kf(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, list[Singleton<WdAPI>.I.qrjo9TWIdy(0, list.Count - 1)]);
						}
						else
						{
							_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.C_Send(Singleton<WdAPI>.I.对话生成_自己(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, stringBuilder.ToString()));
						}
						return null;
					}
					if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.背包数据.物品列表[value2].名字 == Singleton<全局变量类>.I.娃娃配置.遗忘道具)
					{
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 == 0)
						{
							_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y" + _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.昵称A + "#n尚未拥有主门派。"));
							return null;
						}
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.IsEmpty)
						{
							_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y" + _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.昵称A + "#n还没有拜入任何门派学习技能哦。"));
							return null;
						}
						StringBuilder stringBuilder8 = new StringBuilder();
						List<string> list2 = new List<string>();
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 1 && (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("力拔山河") || _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("五雷照顶")))
						{
							if (Singleton<全局变量类>.I.娃娃配置.随机遗忘)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
								defaultInterpolatedStringHandler.AppendLiteral("娃娃系统_遗忘1|");
								defaultInterpolatedStringHandler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								defaultInterpolatedStringHandler.AppendLiteral("|");
								defaultInterpolatedStringHandler.AppendFormatted(value2);
								list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							else
							{
								StringBuilder stringBuilder2 = stringBuilder8;
								StringBuilder stringBuilder9 = stringBuilder2;
								StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 2, stringBuilder2);
								handler.AppendLiteral("[遗忘金系门派/娃娃系统_遗忘1|");
								handler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								handler.AppendLiteral("|");
								handler.AppendFormatted(value2);
								handler.AppendLiteral("]");
								stringBuilder9.Append(ref handler);
							}
						}
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 2 && (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("枯木逢春") || _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("玉露还阳")))
						{
							if (Singleton<全局变量类>.I.娃娃配置.随机遗忘)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
								defaultInterpolatedStringHandler.AppendLiteral("娃娃系统_遗忘2|");
								defaultInterpolatedStringHandler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								defaultInterpolatedStringHandler.AppendLiteral("|");
								defaultInterpolatedStringHandler.AppendFormatted(value2);
								list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							else
							{
								StringBuilder stringBuilder2 = stringBuilder8;
								StringBuilder stringBuilder10 = stringBuilder2;
								StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 2, stringBuilder2);
								handler.AppendLiteral("[遗忘木系门派/娃娃系统_遗忘2|");
								handler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								handler.AppendLiteral("|");
								handler.AppendFormatted(value2);
								handler.AppendLiteral("]");
								stringBuilder10.Append(ref handler);
							}
						}
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 3 && (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("川流不息") || _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("行云流水")))
						{
							if (Singleton<全局变量类>.I.娃娃配置.随机遗忘)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
								defaultInterpolatedStringHandler.AppendLiteral("娃娃系统_遗忘3|");
								defaultInterpolatedStringHandler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								defaultInterpolatedStringHandler.AppendLiteral("|");
								defaultInterpolatedStringHandler.AppendFormatted(value2);
								list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							else
							{
								StringBuilder stringBuilder2 = stringBuilder8;
								StringBuilder stringBuilder11 = stringBuilder2;
								StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 2, stringBuilder2);
								handler.AppendLiteral("[遗忘水系门派/娃娃系统_遗忘3|");
								handler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								handler.AppendLiteral("|");
								handler.AppendFormatted(value2);
								handler.AppendLiteral("]");
								stringBuilder11.Append(ref handler);
							}
						}
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 4 && (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("道亦有道") || _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("大道无为")))
						{
							if (Singleton<全局变量类>.I.娃娃配置.随机遗忘)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
								defaultInterpolatedStringHandler.AppendLiteral("娃娃系统_遗忘4|");
								defaultInterpolatedStringHandler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								defaultInterpolatedStringHandler.AppendLiteral("|");
								defaultInterpolatedStringHandler.AppendFormatted(value2);
								list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							else
							{
								StringBuilder stringBuilder2 = stringBuilder8;
								StringBuilder stringBuilder12 = stringBuilder2;
								StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 2, stringBuilder2);
								handler.AppendLiteral("[遗忘火系门派/娃娃系统_遗忘4|");
								handler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								handler.AppendLiteral("|");
								handler.AppendFormatted(value2);
								handler.AppendLiteral("]");
								stringBuilder12.Append(ref handler);
							}
						}
						if (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.相性 != 5 && (_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("天道自然") || _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.技能列表.ContainsKey("捕风捉影")))
						{
							if (Singleton<全局变量类>.I.娃娃配置.随机遗忘)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
								defaultInterpolatedStringHandler.AppendLiteral("娃娃系统_遗忘5|");
								defaultInterpolatedStringHandler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								defaultInterpolatedStringHandler.AppendLiteral("|");
								defaultInterpolatedStringHandler.AppendFormatted(value2);
								list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							else
							{
								StringBuilder stringBuilder2 = stringBuilder8;
								StringBuilder stringBuilder13 = stringBuilder2;
								StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 2, stringBuilder2);
								handler.AppendLiteral("[遗忘土系门派/娃娃系统_遗忘5|");
								handler.AppendFormatted(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.娃娃ID);
								handler.AppendLiteral("|");
								handler.AppendFormatted(value2);
								handler.AppendLiteral("]");
								stringBuilder13.Append(ref handler);
							}
						}
						if (Singleton<全局变量类>.I.娃娃配置.随机遗忘)
						{
							if (list2.Count <= 0)
							{
								_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y" + _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.昵称A + "#n还没有拜入任何副门派学习技能哦。"));
								return null;
							}
							fQRGJmw5kf(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, list2[Singleton<WdAPI>.I.qrjo9TWIdy(0, list2.Count - 1)]);
						}
						else
						{
							if (string.IsNullOrWhiteSpace(stringBuilder8.ToString()))
							{
								_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y" + _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.昵称A + "#n还没有拜入任何副门派学习技能哦。"));
								return null;
							}
							stringBuilder8.Insert(0, "请选择#Y" + _003C_003Ec__DisplayClass8_5.X8jaeG5v1J.VlJaHyTRCG.昵称A + "#n要遗忘的副门派#R（遗忘后的副门派技能会消失，并且无法遗忘娃娃的主门派）#n：");
							_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.C_Send(Singleton<WdAPI>.I.对话生成_自己(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5, stringBuilder8.ToString()));
						}
						return null;
					}
					if (Singleton<全局变量类>.I.娃娃配置.技能列表.TryGetValue(_003C_003Ec__DisplayClass8_5.X8jaeG5v1J.otqa1ROak5.user.背包数据.物品列表[value2].名字, out _003C_003Ec__DisplayClass8_5.lNga4RGRl2))
					{
						_003C_003Ec__DisplayClass8_3 CS_0024_003C_003E8__locals71 = new _003C_003Ec__DisplayClass8_3();
						CS_0024_003C_003E8__locals71.NX1TwMwZe4 = _003C_003Ec__DisplayClass8_5;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
						if (CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.VlJaHyTRCG.技能列表.TryGetValue(CS_0024_003C_003E8__locals71.NX1TwMwZe4.lNga4RGRl2.技能名字, out CS_0024_003C_003E8__locals71.pSMazmH2cw))
						{
							int num = (Singleton<全局变量类>.I.娃娃配置.技能最大等级跟随娃娃等级 ? CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.VlJaHyTRCG.等级 : CS_0024_003C_003E8__locals71.NX1TwMwZe4.lNga4RGRl2.等级上限);
							if (CS_0024_003C_003E8__locals71.pSMazmH2cw >= num)
							{
								MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5;
								WdAPI i3 = Singleton<WdAPI>.I;
								defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
								defaultInterpolatedStringHandler.AppendLiteral("#Y");
								defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.VlJaHyTRCG.昵称A);
								defaultInterpolatedStringHandler.AppendLiteral("#n的#R");
								defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals71.NX1TwMwZe4.lNga4RGRl2.技能名字);
								defaultInterpolatedStringHandler.AppendLiteral("#n技能已经达到#R");
								defaultInterpolatedStringHandler.AppendFormatted(num);
								defaultInterpolatedStringHandler.AppendLiteral("#n级，无法继续学习。");
								myNATSocketClient3.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
								return null;
							}
							CS_0024_003C_003E8__locals71.KeLTumiHyN = 1;
							if (Singleton<全局变量类>.I.娃娃配置.一键喂养)
							{
								CS_0024_003C_003E8__locals71.KeLTumiHyN = ((CS_0024_003C_003E8__locals71.pSMazmH2cw + CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5.user.背包数据.物品列表[value2].数量 <= num) ? CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5.user.背包数据.物品列表[value2].数量 : (num - CS_0024_003C_003E8__locals71.pSMazmH2cw));
							}
							CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5.销毁回调事件 =  (string v) =>
							{
								if (!(v != CS_0024_003C_003E8__locals71.NX1TwMwZe4.lNga4RGRl2.升级道具))
								{
									CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5.销毁回调事件 = null;
									Singleton<WdAPI>.I.W9lI1TZlUs(CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5, CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5.user.人物数据.昵称, CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.VlJaHyTRCG.娃娃ID.ToString(), CS_0024_003C_003E8__locals71.NX1TwMwZe4.lNga4RGRl2.技能id.ToString(), $"{CS_0024_003C_003E8__locals71.pSMazmH2cw + CS_0024_003C_003E8__locals71.KeLTumiHyN}");
									MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5;
									WdAPI i5 = Singleton<WdAPI>.I;
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(41, 6);
									defaultInterpolatedStringHandler2.AppendLiteral("你给#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.VlJaHyTRCG.昵称A);
									defaultInterpolatedStringHandler2.AppendLiteral("#n使用了#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals71.KeLTumiHyN);
									defaultInterpolatedStringHandler2.AppendLiteral("#n本#R");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals71.NX1TwMwZe4.lNga4RGRl2.升级道具);
									defaultInterpolatedStringHandler2.AppendLiteral("#n使#R");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals71.NX1TwMwZe4.lNga4RGRl2.技能名字);
									defaultInterpolatedStringHandler2.AppendLiteral("#n技能从#R");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals71.pSMazmH2cw);
									defaultInterpolatedStringHandler2.AppendLiteral("#n级提升到了#R");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals71.pSMazmH2cw + CS_0024_003C_003E8__locals71.KeLTumiHyN);
									defaultInterpolatedStringHandler2.AppendLiteral("#n级。");
									myNATSocketClient5.C_Send(i5.提示_杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
								}
							};
							CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(value2, CS_0024_003C_003E8__locals71.KeLTumiHyN));
							return null;
						}
						MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.otqa1ROak5;
						WdAPI i4 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
						defaultInterpolatedStringHandler.AppendLiteral("#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals71.NX1TwMwZe4.X8jaeG5v1J.VlJaHyTRCG.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n还没有学习#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals71.NX1TwMwZe4.lNga4RGRl2.技能名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n技能哦。");
						myNATSocketClient4.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return null;
					}
				}
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("请求_宠物使用道具处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	public void FiSBAZIO6W(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			int num = 0;
			short num2 = 0;
			int num3 = 0;
			string empty = string.Empty;
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			_ = string.Empty;
			封包_读2.Seek(12L, SeekOrigin.Begin);
			封包_读2.读字节集(2);
			int num4 = 封包_读2.读字节型();
			int num5 = 封包_读2.读整数型(reverse: true);
			if (num4 < 1 || num4 > 5 || num5 == 0)
			{
				return;
			}
			娃娃缓存数据类 娃娃缓存数据类2 = P_0.user.娃娃数据[num4];
			娃娃缓存数据类2.初始化(num5, num4);
			封包_读2.读短整数型(reverse: true, out var value);
			for (int i = 0; i < value; i++)
			{
				封包_读2.读字节集(2);
				封包_读2.读短整数型(reverse: true, out var value2);
				for (int j = 0; j < value2; j++)
				{
					num = 0;
					num2 = 0;
					num3 = 0;
					empty = string.Empty;
					byte[] first = 封包_读2.读字节集(2);
					switch (封包_读2.读字节型())
					{
					case 1:
						封包_读2.读字节型(out num);
						break;
					case 2:
						封包_读2.读短整数型(reverse: true, out num2);
						if (Enumerable.SequenceEqual(first, new byte[2] { 0, 44 }))
						{
							娃娃缓存数据类2.相性 = num2;
						}
						if (Enumerable.SequenceEqual(first, new byte[2] { 0, 31 }))
						{
							娃娃缓存数据类2.等级 = num2;
						}
						else if (Enumerable.SequenceEqual(first, new byte[2] { 0, 18 }))
						{
							娃娃缓存数据类2.当前体力 = num2;
						}
						else if (Enumerable.SequenceEqual(first, new byte[2] { 0, 19 }))
						{
							娃娃缓存数据类2.最大体力 = num2;
						}
						break;
					case 3:
						封包_读2.读整数型(reverse: true, out num3);
						if (Enumerable.SequenceEqual(first, new byte[2] { 0, 63 }))
						{
							娃娃缓存数据类2.亲密 = num3;
						}
						else if (Enumerable.SequenceEqual(first, new byte[2] { 0, 40 }))
						{
							娃娃缓存数据类2.头像 = num3;
						}
						else if (Enumerable.SequenceEqual(first, new byte[2] { 1, 116 }))
						{
							娃娃缓存数据类2.xwjIJZ7mNY = num3;
						}
						else if (Enumerable.SequenceEqual(first, new byte[2] { 1, 118 }))
						{
							娃娃缓存数据类2.L9UIKY6HXU = num3;
						}
						else if (Enumerable.SequenceEqual(first, new byte[2] { 0, 25 }))
						{
							娃娃缓存数据类2.经验 = num3;
						}
						break;
					case 4:
						封包_读2.读文本型(out empty, true, (byte)0, false);
						if (Enumerable.SequenceEqual(first, new byte[2] { 0, 1 }))
						{
							娃娃缓存数据类2.昵称A = empty;
						}
						else if (Enumerable.SequenceEqual(first, new byte[2] { 1, 11 }))
						{
							娃娃缓存数据类2.昵称B = empty;
						}
						break;
					case 6:
						封包_读2.读字节型(out num);
						break;
					case 7:
						封包_读2.读短整数型(reverse: true, out num2);
						break;
					}
				}
			}
			if (!Singleton<全局变量类>.I.等级道行检测.is检测等级)
			{
				return;
			}
			if (娃娃缓存数据类2.等级 > P_0.user.属性数据.等级)
			{
				Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, num5.ToString(), "level", $"{P_0.user.属性数据.等级}", "admin_set_attrib");
				if (娃娃缓存数据类2.经验 != 0)
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, num5.ToString(), "exp", "0", "admin_set_attrib");
				}
			}
			else if (娃娃缓存数据类2.等级 == P_0.user.属性数据.等级 && 娃娃缓存数据类2.经验 != 0)
			{
				Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, num5.ToString(), "exp", "0", "admin_set_attrib");
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_娃娃面板属性处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public void y3qBzkOvuB(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(12L, SeekOrigin.Begin);
			obj.读整数型(reverse: true);
			obj.读整数型(reverse: true);
			obj.读字节型();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_娃娃面板刷新处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public void d4tGunb9sP(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass11_0();
			int num = 0;
			short num2 = 0;
			int num3 = 0;
			string empty = string.Empty;
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			_ = string.Empty;
			封包_读2.Seek(12L, SeekOrigin.Begin);
			CS_0024_003C_003E8__locals5.NgEa7GpjTG = 封包_读2.读整数型(reverse: true);
			娃娃缓存数据类 娃娃缓存数据类2 = P_0.user.娃娃数据.Find( (娃娃缓存数据类 x) => x.娃娃ID == CS_0024_003C_003E8__locals5.NgEa7GpjTG);
			if (娃娃缓存数据类2 == null)
			{
				return;
			}
			封包_读2.读短整数型(reverse: true, out var value);
			for (int num4 = 0; num4 < value; num4++)
			{
				num = 0;
				num2 = 0;
				num3 = 0;
				empty = string.Empty;
				byte[] first = 封包_读2.读字节集(2);
				switch (封包_读2.读字节型())
				{
				case 1:
					封包_读2.读字节型(out num);
					break;
				case 2:
					封包_读2.读短整数型(reverse: true, out num2);
					if (Enumerable.SequenceEqual(first, new byte[2] { 0, 44 }))
					{
						娃娃缓存数据类2.相性 = num2;
					}
					if (Enumerable.SequenceEqual(first, new byte[2] { 0, 31 }))
					{
						娃娃缓存数据类2.等级 = num2;
					}
					else if (Enumerable.SequenceEqual(first, new byte[2] { 0, 18 }))
					{
						娃娃缓存数据类2.当前体力 = num2;
					}
					else if (Enumerable.SequenceEqual(first, new byte[2] { 0, 19 }))
					{
						娃娃缓存数据类2.最大体力 = num2;
					}
					break;
				case 3:
					封包_读2.读整数型(reverse: true, out num3);
					if (Enumerable.SequenceEqual(first, new byte[2] { 0, 63 }))
					{
						娃娃缓存数据类2.亲密 = num3;
					}
					else if (Enumerable.SequenceEqual(first, new byte[2] { 0, 40 }))
					{
						娃娃缓存数据类2.头像 = num3;
					}
					else if (Enumerable.SequenceEqual(first, new byte[2] { 1, 116 }))
					{
						娃娃缓存数据类2.xwjIJZ7mNY = num3;
					}
					else if (Enumerable.SequenceEqual(first, new byte[2] { 1, 118 }))
					{
						娃娃缓存数据类2.L9UIKY6HXU = num3;
					}
					else if (Enumerable.SequenceEqual(first, new byte[2] { 0, 25 }))
					{
						娃娃缓存数据类2.经验 = num3;
					}
					break;
				case 4:
					封包_读2.读文本型(out empty, true, (byte)0, false);
					if (Enumerable.SequenceEqual(first, new byte[2] { 0, 1 }))
					{
						娃娃缓存数据类2.昵称A = empty;
					}
					else if (Enumerable.SequenceEqual(first, new byte[2] { 1, 11 }))
					{
						娃娃缓存数据类2.昵称B = empty;
					}
					break;
				case 6:
					封包_读2.读字节型(out num);
					break;
				case 7:
					封包_读2.读短整数型(reverse: true, out num2);
					break;
				}
			}
			if (!Singleton<全局变量类>.I.等级道行检测.is检测等级)
			{
				return;
			}
			if (娃娃缓存数据类2.等级 > Singleton<全局变量类>.I.等级道行检测.最高等级)
			{
				Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals5.NgEa7GpjTG.ToString(), "level", $"{Singleton<全局变量类>.I.等级道行检测.最高等级}", "admin_set_attrib");
				if (娃娃缓存数据类2.经验 != 0)
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals5.NgEa7GpjTG.ToString(), "exp", "0", "admin_set_attrib");
				}
			}
			else if (娃娃缓存数据类2.等级 == Singleton<全局变量类>.I.等级道行检测.最高等级 && 娃娃缓存数据类2.经验 != 0)
			{
				Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals5.NgEa7GpjTG.ToString(), "exp", "0", "admin_set_attrib");
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_娃娃属性刷新处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public byte[] pKRGw0dMQ2(int P_0, int P_1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[12]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 15,
			19, 101
		}, hasCount: false, 0);
		封包_写2.写整数型(P_0, reverse: true);
		封包_写2.写字节集(new byte[5] { 0, 1, 0, 63, 3 }, hasCount: false, 0);
		封包_写2.写整数型(P_1, reverse: true);
		return 封包_写2.取数据();
	}

	
	internal byte[] uiGGbOUvrG(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass13_0();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(12L, SeekOrigin.Begin);
			封包_读2.读整数型(reverse: true, out CS_0024_003C_003E8__locals2.iGoaTl4TbN);
			娃娃缓存数据类 娃娃缓存数据类2 = P_0.user.娃娃数据.Find( (娃娃缓存数据类 x) => x.娃娃ID == CS_0024_003C_003E8__locals2.iGoaTl4TbN);
			if (娃娃缓存数据类2 == null)
			{
				return P_1;
			}
			封包_读2.读短整数型(reverse: true, out var value);
			string empty = string.Empty;
			short value2 = 0;
			for (int num = 0; num < value; num++)
			{
				封包_读2.读字节集(6);
				empty = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
				封包_读2.读字节集(2);
				封包_读2.读短整数型(reverse: true, out value2);
				封包_读2.读短整数型(reverse: true);
				封包_读2.读字节集(39);
				if (娃娃缓存数据类2.技能列表.ContainsKey(empty))
				{
					if (value2 > 0)
					{
						娃娃缓存数据类2.技能列表[empty] = value2;
					}
					else
					{
						娃娃缓存数据类2.技能列表.TryRemove(empty, out var _);
					}
				}
				else if (value2 > 0)
				{
					娃娃缓存数据类2.技能列表.TryAdd(empty, value2);
				}
				封包_读2.读短整数型(reverse: true, out var value4);
				for (int num2 = 0; num2 < value4; num2++)
				{
					封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
					封包_读2.读字节集(4);
				}
				封包_读2.读字节集(5);
			}
			return P_1;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_娃娃技能处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	internal void fQRGJmw5kf(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals50 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals50.pThak61KGj = P_0;
		try
		{
			if (string.IsNullOrWhiteSpace(P_1))
			{
				CS_0024_003C_003E8__locals50.pThak61KGj.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的物品数据有误，原因：1！"));
				return;
			}
			string[] array = P_1.Split("|");
			if (array.Length != 3)
			{
				return;
			}
			CS_0024_003C_003E8__locals50.m7faO3tCOL = 0;
			bool flag = false;
			bool flag2 = false;
			if (array[0].StartsWith("娃娃系统_拜师"))
			{
				flag = true;
				if (!int.TryParse(array[0].Replace("娃娃系统_拜师", string.Empty), out CS_0024_003C_003E8__locals50.m7faO3tCOL))
				{
					return;
				}
			}
			else if (array[0].StartsWith("娃娃系统_遗忘"))
			{
				flag2 = true;
				if (!int.TryParse(array[0].Replace("娃娃系统_遗忘", string.Empty), out CS_0024_003C_003E8__locals50.m7faO3tCOL))
				{
					return;
				}
			}
			if (!int.TryParse(array[1], out CS_0024_003C_003E8__locals50.zC0a079I31) || !int.TryParse(array[2], out var result) || CS_0024_003C_003E8__locals50.m7faO3tCOL <= 0 || CS_0024_003C_003E8__locals50.m7faO3tCOL > 5 || CS_0024_003C_003E8__locals50.zC0a079I31 == 0 || result == 0 || (!flag && !flag2) || !Singleton<WdAPI>.I.wfboRXZawH(CS_0024_003C_003E8__locals50.pThak61KGj, result, true) || CS_0024_003C_003E8__locals50.pThak61KGj.user.背包数据.物品列表[result].数量 < 1)
			{
				return;
			}
			CS_0024_003C_003E8__locals50.P4NaQkR6Yv = CS_0024_003C_003E8__locals50.pThak61KGj.user.娃娃数据.Find( (娃娃缓存数据类 x) => x.娃娃index != 0 && x.娃娃ID == CS_0024_003C_003E8__locals50.zC0a079I31);
			if (CS_0024_003C_003E8__locals50.P4NaQkR6Yv == null)
			{
				return;
			}
			new StringBuilder();
			CS_0024_003C_003E8__locals50.JcKaEIt70O = Singleton<全局变量类>.I.娃娃配置.技能列表.Values.ToList().FindAll( (娃娃技能列表类 x) => x.门派 == (AllEnums.五行Type)CS_0024_003C_003E8__locals50.m7faO3tCOL && x.技能id != 0);
			if (CS_0024_003C_003E8__locals50.JcKaEIt70O.Count <= 0)
			{
				return;
			}
			if (flag && CS_0024_003C_003E8__locals50.pThak61KGj.user.背包数据.物品列表[result].名字 == Singleton<全局变量类>.I.娃娃配置.门派道具)
			{
				if (CS_0024_003C_003E8__locals50.P4NaQkR6Yv.技能列表.Count( (KeyValuePair<string, int> x) => x.Value > 0) / 2 >= Singleton<全局变量类>.I.娃娃配置.门派上限)
				{
					return;
				}
				CS_0024_003C_003E8__locals50.pThak61KGj.销毁回调事件 =  (string v) =>
				{
					if (!(v != Singleton<全局变量类>.I.娃娃配置.门派道具))
					{
						CS_0024_003C_003E8__locals50.pThak61KGj.销毁回调事件 = null;
						MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals50.pThak61KGj;
						WdAPI i = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler2.AppendLiteral("你的#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals50.P4NaQkR6Yv.昵称A);
						defaultInterpolatedStringHandler2.AppendLiteral("#n成功拜入了#R");
						defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.五行Type)CS_0024_003C_003E8__locals50.m7faO3tCOL);
						defaultInterpolatedStringHandler2.AppendLiteral("系#n副门派。");
						myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						for (int j = 0; j < CS_0024_003C_003E8__locals50.JcKaEIt70O.Count; j++)
						{
							Singleton<WdAPI>.I.W9lI1TZlUs(CS_0024_003C_003E8__locals50.pThak61KGj, CS_0024_003C_003E8__locals50.pThak61KGj.user.人物数据.昵称, CS_0024_003C_003E8__locals50.P4NaQkR6Yv.娃娃ID.ToString(), CS_0024_003C_003E8__locals50.JcKaEIt70O[j].技能id.ToString(), "1");
							MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals50.pThak61KGj;
							WdAPI i2 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(18, 2);
							defaultInterpolatedStringHandler2.AppendLiteral("你的#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals50.P4NaQkR6Yv.昵称A);
							defaultInterpolatedStringHandler2.AppendLiteral("#n成功学习了#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals50.JcKaEIt70O[j].技能名字);
							defaultInterpolatedStringHandler2.AppendLiteral("#n技能。");
							myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						}
					}
				};
				CS_0024_003C_003E8__locals50.pThak61KGj.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(result, 1));
			}
			else
			{
				if (!flag2 || !(CS_0024_003C_003E8__locals50.pThak61KGj.user.背包数据.物品列表[result].名字 == Singleton<全局变量类>.I.娃娃配置.遗忘道具) || CS_0024_003C_003E8__locals50.P4NaQkR6Yv.技能列表.IsEmpty)
				{
					return;
				}
				CS_0024_003C_003E8__locals50.pThak61KGj.销毁回调事件 =  (string v) =>
				{
					if (!(v != Singleton<全局变量类>.I.娃娃配置.遗忘道具))
					{
						CS_0024_003C_003E8__locals50.pThak61KGj.销毁回调事件 = null;
						MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals50.pThak61KGj;
						WdAPI i = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler2.AppendLiteral("你的#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals50.P4NaQkR6Yv.昵称A);
						defaultInterpolatedStringHandler2.AppendLiteral("#n成功退出了#R");
						defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.五行Type)CS_0024_003C_003E8__locals50.m7faO3tCOL);
						defaultInterpolatedStringHandler2.AppendLiteral("系#n副门派。");
						myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						for (int j = 0; j < CS_0024_003C_003E8__locals50.JcKaEIt70O.Count; j++)
						{
							Singleton<WdAPI>.I.W9lI1TZlUs(CS_0024_003C_003E8__locals50.pThak61KGj, CS_0024_003C_003E8__locals50.pThak61KGj.user.人物数据.昵称, CS_0024_003C_003E8__locals50.P4NaQkR6Yv.娃娃ID.ToString(), CS_0024_003C_003E8__locals50.JcKaEIt70O[j].技能id.ToString(), "0");
							MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals50.pThak61KGj;
							WdAPI i2 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(16, 2);
							defaultInterpolatedStringHandler2.AppendLiteral("你的#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals50.P4NaQkR6Yv.昵称A);
							defaultInterpolatedStringHandler2.AppendLiteral("#n失去了#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals50.JcKaEIt70O[j].技能名字);
							defaultInterpolatedStringHandler2.AppendLiteral("#n技能。");
							myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						}
					}
				};
				CS_0024_003C_003E8__locals50.pThak61KGj.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(result, 1));
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("娃娃系统对话处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal byte[] P0GGK9s4W0(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass15_0();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(12L, SeekOrigin.Begin);
			CS_0024_003C_003E8__locals3.dg6aYlPinV = 封包_读2.读整数型(reverse: true);
			封包_读2.读整数型(reverse: true);
			封包_读2.读字节型();
			娃娃缓存数据类 娃娃缓存数据类2 = P_0.user.娃娃数据.Find( (娃娃缓存数据类 x) => x.娃娃index != 0 && x.娃娃ID == CS_0024_003C_003E8__locals3.dg6aYlPinV);
			if (娃娃缓存数据类2 == null)
			{
				return P_1;
			}
			if (娃娃缓存数据类2.技能列表.Count <= 2)
			{
				return P_1;
			}
			封包_写 封包_写2 = new 封包_写();
			foreach (string key in 娃娃缓存数据类2.技能列表.Keys)
			{
				if (问道数据类.所有技能ID.TryGetValue(key, out var value))
				{
					封包_写2.写字节集(Singleton<WdAPI>.I.KvfoAUfbgY(CS_0024_003C_003E8__locals3.dg6aYlPinV, value), hasCount: false, 0);
				}
			}
			return 封包_写2.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("请求_组包娃娃技能勾选-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	public mQEQjEBxYW4SsAecBHJ()
	{
	}

	
	static mQEQjEBxYW4SsAecBHJ()
	{
		ai7Gs687BS = new StringBuilder();
	}
}
