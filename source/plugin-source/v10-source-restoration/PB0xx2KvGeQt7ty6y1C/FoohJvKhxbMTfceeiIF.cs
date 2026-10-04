using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Serilog;
using UQuLZEj71kRGhQn6jmQ;
using vEAdPGPTkDFOYsbi303;

namespace PB0xx2KvGeQt7ty6y1C;

internal class FoohJvKhxbMTfceeiIF : Singleton<FoohJvKhxbMTfceeiIF>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public MyNATSocketClient riHFHW3D4K;

		public bool QVhF4PqMxc;

		public int USfFeRn8WL;

		
		public _003C_003Ec__DisplayClass18_0()
		{
		}

		
		internal void g9LFxh2XW8(string v)
		{
			if (!(v == Singleton<全局变量类>.I.宠物召唤配置.变异材料))
			{
				return;
			}
			riHFHW3D4K.销毁回调事件 = null;
			if (QVhF4PqMxc)
			{
				riHFHW3D4K.user.存档数据.召唤数据.变异珠 = 0;
				Singleton<WdAPI>.I.PndoGw5lW7(riHFHW3D4K, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.宠物召唤配置.变异奖励, AllEnums.指令Type.无, 1, false, "宠物召唤变异");
				MyNATSocketClient myNATSocketClient = riHFHW3D4K;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("您提交总数到达#Y");
				defaultInterpolatedStringHandler.AppendFormatted(USfFeRn8WL);
				defaultInterpolatedStringHandler.AppendLiteral("#n次,获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
				if (client频道事件 != null)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 4);
					defaultInterpolatedStringHandler.AppendLiteral("听闻#Y");
					defaultInterpolatedStringHandler.AppendFormatted(riHFHW3D4K.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("#n仅仅用了#R");
					defaultInterpolatedStringHandler.AppendFormatted(USfFeRn8WL);
					defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异材料);
					defaultInterpolatedStringHandler.AppendLiteral("#n就召唤出了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异奖励);
					defaultInterpolatedStringHandler.AppendLiteral("#n，真是羡煞旁人啊！");
					client频道事件(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
				}
			}
			else
			{
				double num = 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.变异最高;
				MyNATSocketClient myNATSocketClient2 = riHFHW3D4K;
				WdAPI i3 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(55, 2);
				defaultInterpolatedStringHandler.AppendLiteral("加油,你离成功召唤变异又近了一步！增加了：#R");
				defaultInterpolatedStringHandler.AppendFormatted(num, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n的概率，目前概率为#R");
				defaultInterpolatedStringHandler.AppendFormatted(num * (double)USfFeRn8WL, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n，每次提交都会有一定几率成功！");
				myNATSocketClient2.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("加油,你离成功召唤变异又近了一步！，每次提交都会有一定几率成功")).ToArray());
			}
		}

		static _003C_003Ec__DisplayClass18_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public MyNATSocketClient pbaFrg49kE;

		public bool aT4FZF1vt4;

		public int QrAFtP28lo;

		
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		
		internal void QhjFqefp7D(string v)
		{
			if (!(v == Singleton<全局变量类>.I.宠物召唤配置.神兽材料))
			{
				return;
			}
			pbaFrg49kE.销毁回调事件 = null;
			if (aT4FZF1vt4)
			{
				pbaFrg49kE.user.存档数据.召唤数据.神兽珠 = 0;
				Singleton<WdAPI>.I.PndoGw5lW7(pbaFrg49kE, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.宠物召唤配置.神兽奖励, AllEnums.指令Type.无, 1, false, "宠物召唤神兽");
				MyNATSocketClient myNATSocketClient = pbaFrg49kE;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("您提交总数到达#Y");
				defaultInterpolatedStringHandler.AppendFormatted(QrAFtP28lo);
				defaultInterpolatedStringHandler.AppendLiteral("#n次,获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
				if (client频道事件 != null)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 4);
					defaultInterpolatedStringHandler.AppendLiteral("听闻#Y");
					defaultInterpolatedStringHandler.AppendFormatted(pbaFrg49kE.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("#n仅仅用了#R");
					defaultInterpolatedStringHandler.AppendFormatted(QrAFtP28lo);
					defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽材料);
					defaultInterpolatedStringHandler.AppendLiteral("#n就召唤出了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽奖励);
					defaultInterpolatedStringHandler.AppendLiteral("#n，真是羡煞旁人啊！");
					client频道事件(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
				}
			}
			else
			{
				double num = 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.神兽最高;
				MyNATSocketClient myNATSocketClient2 = pbaFrg49kE;
				WdAPI i3 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(55, 2);
				defaultInterpolatedStringHandler.AppendLiteral("加油,你离成功召唤神兽又近了一步！增加了：#R");
				defaultInterpolatedStringHandler.AppendFormatted(num, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n的概率，目前概率为#R");
				defaultInterpolatedStringHandler.AppendFormatted(num * (double)QrAFtP28lo, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n，每次提交都会有一定几率成功！");
				myNATSocketClient2.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("加油,你离成功召唤神兽又近了一步！，每次提交都会有一定几率成功")).ToArray());
			}
		}

		static _003C_003Ec__DisplayClass19_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public MyNATSocketClient tCOFzLOS0u;

		public bool duYLuhiK1t;

		public int jKULwoolkv;

		
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		
		internal void qjuFA4AXxY(string v)
		{
			if (!(v == Singleton<全局变量类>.I.宠物召唤配置.元灵材料))
			{
				return;
			}
			tCOFzLOS0u.销毁回调事件 = null;
			if (duYLuhiK1t)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(tCOFzLOS0u, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.宠物召唤配置.元灵奖励, AllEnums.指令Type.无, 1, false, "宠物召唤元灵");
				MyNATSocketClient myNATSocketClient = tCOFzLOS0u;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("您提交总数到达#Y");
				defaultInterpolatedStringHandler.AppendFormatted(jKULwoolkv);
				defaultInterpolatedStringHandler.AppendLiteral("#n次,获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
				if (client频道事件 != null)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 4);
					defaultInterpolatedStringHandler.AppendLiteral("听闻#Y");
					defaultInterpolatedStringHandler.AppendFormatted(tCOFzLOS0u.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("#n仅仅用了#R");
					defaultInterpolatedStringHandler.AppendFormatted(jKULwoolkv);
					defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵材料);
					defaultInterpolatedStringHandler.AppendLiteral("#n就召唤出了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵奖励);
					defaultInterpolatedStringHandler.AppendLiteral("#n，真是羡煞旁人啊！");
					client频道事件(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
				}
				tCOFzLOS0u.user.存档数据.召唤数据.元灵珠 = 0;
			}
			else
			{
				double num = 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.元灵最高;
				MyNATSocketClient myNATSocketClient2 = tCOFzLOS0u;
				WdAPI i3 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(55, 2);
				defaultInterpolatedStringHandler.AppendLiteral("加油,你离成功召唤元灵又近了一步！增加了：#R");
				defaultInterpolatedStringHandler.AppendFormatted(num, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n的概率，目前概率为#R");
				defaultInterpolatedStringHandler.AppendFormatted(num * (double)jKULwoolkv, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n，每次提交都会有一定几率成功！");
				myNATSocketClient2.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("加油,你离成功召唤元灵又近了一步！，每次提交都会有一定几率成功")).ToArray());
			}
		}

		static _003C_003Ec__DisplayClass20_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public MyNATSocketClient BG2LJKbygB;

		public bool FR1LKRYsvu;

		public int DUHLRmrbDf;

		
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		
		internal void wy2LbqGgxR(string v)
		{
			if (!(v == Singleton<全局变量类>.I.宠物召唤配置.仙元材料))
			{
				return;
			}
			BG2LJKbygB.销毁回调事件 = null;
			if (FR1LKRYsvu)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(BG2LJKbygB, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.宠物召唤配置.仙元奖励, AllEnums.指令Type.无, 1, false, "宠物召唤仙元");
				MyNATSocketClient myNATSocketClient = BG2LJKbygB;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("您提交总数到达#Y");
				defaultInterpolatedStringHandler.AppendFormatted(DUHLRmrbDf);
				defaultInterpolatedStringHandler.AppendLiteral("#n次,获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
				if (client频道事件 != null)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 4);
					defaultInterpolatedStringHandler.AppendLiteral("听闻#Y");
					defaultInterpolatedStringHandler.AppendFormatted(BG2LJKbygB.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("#n仅仅用了#R");
					defaultInterpolatedStringHandler.AppendFormatted(DUHLRmrbDf);
					defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元材料);
					defaultInterpolatedStringHandler.AppendLiteral("#n就召唤出了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元奖励);
					defaultInterpolatedStringHandler.AppendLiteral("#n，真是羡煞旁人啊！");
					client频道事件(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
				}
				BG2LJKbygB.user.存档数据.召唤数据.仙元珠 = 0;
			}
			else
			{
				double num = 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.仙元最高;
				MyNATSocketClient myNATSocketClient2 = BG2LJKbygB;
				WdAPI i3 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(55, 2);
				defaultInterpolatedStringHandler.AppendLiteral("加油,你离成功召唤仙元又近了一步！增加了：#R");
				defaultInterpolatedStringHandler.AppendFormatted(num, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n的概率，目前概率为#R");
				defaultInterpolatedStringHandler.AppendFormatted(num * (double)DUHLRmrbDf, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n，每次提交都会有一定几率成功！");
				myNATSocketClient2.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("加油,你离成功召唤仙元又近了一步！，每次提交都会有一定几率成功")).ToArray());
			}
		}

		static _003C_003Ec__DisplayClass21_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public MyNATSocketClient wyHLstEnU7;

		public bool RewLUMjLVp;

		public int G6ILWZF3OJ;

		
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		
		internal void cPCLdwjP3W(string v)
		{
			if (!(v == Singleton<全局变量类>.I.宠物召唤配置.御灵材料))
			{
				return;
			}
			wyHLstEnU7.销毁回调事件 = null;
			if (RewLUMjLVp)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(wyHLstEnU7, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.宠物召唤配置.御灵奖励, AllEnums.指令Type.无, 1, false, "宠物召唤御灵");
				MyNATSocketClient myNATSocketClient = wyHLstEnU7;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("您提交总数到达#Y");
				defaultInterpolatedStringHandler.AppendFormatted(G6ILWZF3OJ);
				defaultInterpolatedStringHandler.AppendLiteral("#n次,获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
				if (client频道事件 != null)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 4);
					defaultInterpolatedStringHandler.AppendLiteral("听闻#Y");
					defaultInterpolatedStringHandler.AppendFormatted(wyHLstEnU7.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("#n仅仅用了#R");
					defaultInterpolatedStringHandler.AppendFormatted(G6ILWZF3OJ);
					defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵材料);
					defaultInterpolatedStringHandler.AppendLiteral("#n就召唤出了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵奖励);
					defaultInterpolatedStringHandler.AppendLiteral("#n，真是羡煞旁人啊！");
					client频道事件(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
				}
				wyHLstEnU7.user.存档数据.召唤数据.御灵珠 = 0;
			}
			else
			{
				double num = 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.御灵最高;
				MyNATSocketClient myNATSocketClient2 = wyHLstEnU7;
				WdAPI i3 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(55, 2);
				defaultInterpolatedStringHandler.AppendLiteral("加油,你离成功召唤御灵又近了一步！增加了：#R");
				defaultInterpolatedStringHandler.AppendFormatted(num, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n的概率，目前概率为#R");
				defaultInterpolatedStringHandler.AppendFormatted(num * (double)G6ILWZF3OJ, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n，每次提交都会有一定几率成功！");
				myNATSocketClient2.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("加油,你离成功召唤御灵又近了一步！，每次提交都会有一定几率成功")).ToArray());
			}
		}

		static _003C_003Ec__DisplayClass22_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public string MgJLDSC35m;

		
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		
		internal bool XbGLghyKJg(宠物缓存数据类 a)
		{
			if (!string.IsNullOrWhiteSpace(MgJLDSC35m))
			{
				return a.IID == MgJLDSC35m;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass23_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_1
	{
		public string VZWLlRRbNp;

		
		public _003C_003Ec__DisplayClass23_1()
		{
		}

		
		internal bool aGiLj8abv8(宠物缓存数据类 a)
		{
			if (!string.IsNullOrWhiteSpace(VZWLlRRbNp))
			{
				return a.IID == VZWLlRRbNp;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass23_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public string Y0cLICTugb;

		
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		
		internal bool OPWL80bteF(宠物缓存数据类 a)
		{
			if (!string.IsNullOrWhiteSpace(Y0cLICTugb))
			{
				return a.IID == Y0cLICTugb;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass24_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public string nTZLNKk07S;

		
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		
		internal bool ljoLoRJPfH(宠物缓存数据类 a)
		{
			if (!string.IsNullOrWhiteSpace(nTZLNKk07S))
			{
				return a.IID == nTZLNKk07S;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass25_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public string YfrLBDtw57;

		
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		
		internal bool PWmLiioZB9(宠物缓存数据类 a)
		{
			if (!string.IsNullOrWhiteSpace(YfrLBDtw57))
			{
				return a.IID == YfrLBDtw57;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass29_0()
		{
		}
	}

	internal byte[] PDlKzCqrLv;

	
	internal void bxGK74CNVM()
	{
		XC5KT5BQAF();
		gedKVH42LK();
		Hg1KQZhSKH();
		tgDKp4CsOI();
	}

	
	internal void XTlKa6nARp()
	{
		fjhK9Sp6m2();
		HnEKkfn3sO();
		vP0KEBeFAb();
	}

	
	internal void XC5KT5BQAF()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物召唤配置类.json")))
			{
				Singleton<全局变量类>.I.宠物召唤配置 = JsonConvert.DeserializeObject<宠物召唤配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物召唤配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.宠物召唤配置 = new 宠物召唤配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物召唤配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物召唤配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("宠物召唤配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void fjhK9Sp6m2()
	{
		try
		{
			tgDKp4CsOI();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物召唤配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物召唤配置, Formatting.Indented));
			Log.Debug("宠物召唤配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("宠物召唤配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string WwXKyq2YXx()
	{
		XC5KT5BQAF();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物召唤配置, Formatting.Indented);
	}

	
	public void LjmKC4Pywu(string P_0)
	{
		Singleton<全局变量类>.I.宠物召唤配置 = JsonConvert.DeserializeObject<宠物召唤配置类>(P_0);
		fjhK9Sp6m2();
	}

	
	internal void gedKVH42LK()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物绑定配置类.json")))
			{
				Singleton<全局变量类>.I.宠物绑定配置 = JsonConvert.DeserializeObject<宠物绑定配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物绑定配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.宠物绑定配置 = new 宠物绑定配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物绑定配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物绑定配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("宠物绑定配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void HnEKkfn3sO()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物绑定配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物绑定配置, Formatting.Indented));
			Log.Debug("宠物绑定配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("宠物绑定配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string bTVK0xQw8v()
	{
		gedKVH42LK();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物绑定配置, Formatting.Indented);
	}

	
	public void MYhKOU8bbt(string P_0)
	{
		Singleton<全局变量类>.I.宠物绑定配置 = JsonConvert.DeserializeObject<宠物绑定配置类>(P_0);
		HnEKkfn3sO();
	}

	
	internal void Hg1KQZhSKH()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物同源配置类.json")))
			{
				Singleton<全局变量类>.I.宠物同源配置 = JsonConvert.DeserializeObject<宠物同源配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物同源配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.宠物同源配置 = new 宠物同源配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物同源配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物同源配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("宠物同源配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void vP0KEBeFAb()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物同源配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物同源配置, Formatting.Indented));
			Log.Debug("宠物同源配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("宠物同源配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string oGwK3CjB6O()
	{
		Hg1KQZhSKH();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物同源配置, Formatting.Indented);
	}

	
	public void tQKKYMOPrl(string P_0)
	{
		Singleton<全局变量类>.I.宠物同源配置 = JsonConvert.DeserializeObject<宠物同源配置类>(P_0);
		vP0KEBeFAb();
	}

	
	public void tgDKp4CsOI()
	{
		PDlKzCqrLv = Singleton<WdAPI>.I.组包假NPC站街(Singleton<全局变量类>.I.宠物召唤配置.NPC数据, 102);
	}

	
	internal void QRkK1vRkbM(MyNATSocketClient P_0)
	{
		try
		{
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(Singleton<全局变量类>.I.宠物召唤配置.NPC数据.对话文本);
			if (Singleton<全局变量类>.I.宠物召唤配置.功能开关)
			{
				if (Singleton<全局变量类>.I.宠物召唤配置.is变异召唤)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
					handler.AppendLiteral("[");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异对话);
					handler.AppendLiteral("/宠物操作_变异珠提交]");
					stringBuilder3.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.宠物召唤配置.is神兽召唤)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
					handler.AppendLiteral("[");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽对话);
					handler.AppendLiteral("/宠物操作_神兽珠提交]");
					stringBuilder4.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.宠物召唤配置.is元灵召唤)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
					handler.AppendLiteral("[");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵对话);
					handler.AppendLiteral("/宠物操作_元灵珠提交]");
					stringBuilder5.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.宠物召唤配置.is仙元召唤)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
					handler.AppendLiteral("[");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元对话);
					handler.AppendLiteral("/宠物操作_仙元珠提交]");
					stringBuilder6.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.宠物召唤配置.is御灵召唤)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
					handler.AppendLiteral("[");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵对话);
					handler.AppendLiteral("/宠物操作_御灵珠提交]");
					stringBuilder7.Append(ref handler);
				}
			}
			if (Singleton<全局变量类>.I.宠物同源配置.功能开关)
			{
				stringBuilder.Append("[【宠物同源】宠物同源/宠物操作_宠物同源]");
			}
			if (Singleton<全局变量类>.I.道具宠物回收配置.is宠物回收)
			{
				stringBuilder.Append("[【宠物回收】宠物回收/宠物操作_宠物回收]");
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npcid, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字, stringBuilder.ToString()));
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

	
	internal void SEGKxwec5N(MyNATSocketClient P_0, string P_1, string P_2)
	{
		try
		{
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			if (P_1 == "宠物操作_变异珠提交")
			{
				WdAPI i = Singleton<WdAPI>.I;
				int npc形象 = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象;
				string npc名字 = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(86, 6);
				defaultInterpolatedStringHandler.AppendLiteral("[@/$*宠物操作_提交变异珠|每提交1个#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异材料);
				defaultInterpolatedStringHandler.AppendLiteral("#n，就有#R");
				defaultInterpolatedStringHandler.AppendFormatted(100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.变异最高, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n的几率获得#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n，累计提交#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异最高);
				defaultInterpolatedStringHandler.AppendLiteral("#n个将百分百获得一个#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n，已累计提交：#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.召唤数据.变异珠);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#n。,1,0]\r\n");
				P_0.C_Send(i.组包提交物品框(102, npc形象, npc名字, defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (P_1 == "宠物操作_神兽珠提交")
			{
				WdAPI i2 = Singleton<WdAPI>.I;
				int npc形象2 = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象;
				string npc名字2 = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(86, 6);
				defaultInterpolatedStringHandler.AppendLiteral("[@/$*宠物操作_提交神兽珠|每提交1个#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽材料);
				defaultInterpolatedStringHandler.AppendLiteral("#n，就有#R");
				defaultInterpolatedStringHandler.AppendFormatted(100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.神兽最高, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n的几率获得#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n，累计提交#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽最高);
				defaultInterpolatedStringHandler.AppendLiteral("#n个将百分百获得一个#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n，已累计提交：#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.召唤数据.神兽珠);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#n。,1,0]\r\n");
				P_0.C_Send(i2.组包提交物品框(102, npc形象2, npc名字2, defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (P_1 == "宠物操作_元灵珠提交")
			{
				WdAPI i3 = Singleton<WdAPI>.I;
				int npc形象3 = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象;
				string npc名字3 = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(86, 6);
				defaultInterpolatedStringHandler.AppendLiteral("[@/$*宠物操作_提交元灵珠|每提交1个#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵材料);
				defaultInterpolatedStringHandler.AppendLiteral("#n，就有#R");
				defaultInterpolatedStringHandler.AppendFormatted(100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.元灵最高, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n的几率获得#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n，累计提交#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵最高);
				defaultInterpolatedStringHandler.AppendLiteral("#n个将百分百获得一个#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n，已累计提交：#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.召唤数据.元灵珠);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#n。,1,0]\r\n");
				P_0.C_Send(i3.组包提交物品框(102, npc形象3, npc名字3, defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (P_1 == "宠物操作_仙元珠提交")
			{
				WdAPI i4 = Singleton<WdAPI>.I;
				int npc形象4 = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象;
				string npc名字4 = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(86, 6);
				defaultInterpolatedStringHandler.AppendLiteral("[@/$*宠物操作_提交仙元珠|每提交1个#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元材料);
				defaultInterpolatedStringHandler.AppendLiteral("#n，就有#R");
				defaultInterpolatedStringHandler.AppendFormatted(100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.仙元最高, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n的几率获得#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n，累计提交#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元最高);
				defaultInterpolatedStringHandler.AppendLiteral("#n个将百分百获得一个#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n，已累计提交：#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.召唤数据.仙元珠);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#n。,1,0]\r\n");
				P_0.C_Send(i4.组包提交物品框(102, npc形象4, npc名字4, defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (P_1 == "宠物操作_御灵珠提交")
			{
				WdAPI i5 = Singleton<WdAPI>.I;
				int npc形象5 = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象;
				string npc名字5 = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(86, 6);
				defaultInterpolatedStringHandler.AppendLiteral("[@/$*宠物操作_提交御灵珠|每提交1个#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵材料);
				defaultInterpolatedStringHandler.AppendLiteral("#n，就有#R");
				defaultInterpolatedStringHandler.AppendFormatted(100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.御灵最高, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n的几率获得#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n，累计提交#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵最高);
				defaultInterpolatedStringHandler.AppendLiteral("#n个将百分百获得一个#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n，已累计提交：#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.召唤数据.御灵珠);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#n。,1,0]\r\n");
				P_0.C_Send(i5.组包提交物品框(102, npc形象5, npc名字5, defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (P_1.Contains("$*宠物操作_", StringComparison.CurrentCulture))
			{
				if (!int.TryParse(new Regex("(?<=\\,)\\d+(?=\\:)").Match(P_2)?.Value, out var result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result))
				{
					return;
				}
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[result].封包缓存, result));
				if (P_1 == "$*宠物操作_提交变异珠")
				{
					if (P_0.user.缓存数据.l9XIwuUeoO.ElapsedMilliseconds >= 1000)
					{
						P_0.user.缓存数据.l9XIwuUeoO.Restart();
						变异召唤处理(P_0, result);
					}
					return;
				}
				if (P_1 == "$*宠物操作_提交神兽珠")
				{
					if (P_0.user.缓存数据.l9XIwuUeoO.ElapsedMilliseconds >= 1000)
					{
						P_0.user.缓存数据.l9XIwuUeoO.Restart();
						神兽召唤处理(P_0, result);
					}
					return;
				}
				if (P_1 == "$*宠物操作_提交元灵珠")
				{
					if (P_0.user.缓存数据.l9XIwuUeoO.ElapsedMilliseconds >= 1000)
					{
						P_0.user.缓存数据.l9XIwuUeoO.Restart();
						元灵召唤处理(P_0, result);
					}
					return;
				}
				if (P_1 == "$*宠物操作_提交仙元珠")
				{
					if (P_0.user.缓存数据.l9XIwuUeoO.ElapsedMilliseconds >= 1000)
					{
						P_0.user.缓存数据.l9XIwuUeoO.Restart();
						PiLKHKM4vW(P_0, result);
					}
					return;
				}
				if (P_1 == "$*宠物操作_提交御灵珠")
				{
					if (P_0.user.缓存数据.l9XIwuUeoO.ElapsedMilliseconds >= 1000)
					{
						P_0.user.缓存数据.l9XIwuUeoO.Restart();
						御灵召唤处理(P_0, result);
					}
					return;
				}
			}
			if (P_1.Contains("宠物操作_宠物同源", StringComparison.CurrentCulture))
			{
				gKhK40vcxv(P_0, P_1);
			}
			else if (P_1.Contains("宠物操作_宠物回收", StringComparison.CurrentCulture))
			{
				Singleton<fFv8GpjvE2cusnNqivq>.I.grdjVchuUV(P_0, P_1);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("宠物尊者事件处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void 变异召唤处理(MyNATSocketClient myclient, int 提交格子)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals34 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals34.riHFHW3D4K = myclient;
		try
		{
			if (CS_0024_003C_003E8__locals34.riHFHW3D4K.user.背包数据.物品列表[提交格子].名字 != Singleton<全局变量类>.I.宠物召唤配置.变异材料)
			{
				CS_0024_003C_003E8__locals34.riHFHW3D4K.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请提交#Y" + Singleton<全局变量类>.I.宠物召唤配置.变异材料 + "#n！！！").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.riHFHW3D4K.user.背包数据.物品列表[提交格子].封包缓存, 提交格子)).ToArray());
				return;
			}
			if (!Singleton<WdAPI>.I.dSCoKmGWP9(CS_0024_003C_003E8__locals34.riHFHW3D4K))
			{
				CS_0024_003C_003E8__locals34.riHFHW3D4K.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的宠物栏空位不足，清整理后再来。").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.riHFHW3D4K.user.背包数据.物品列表[提交格子].封包缓存, 提交格子)).ToArray());
				return;
			}
			if (Singleton<WdAPI>.I.取背包剩余空格数(CS_0024_003C_003E8__locals34.riHFHW3D4K) < 1)
			{
				CS_0024_003C_003E8__locals34.riHFHW3D4K.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的包裹栏空位不足，无法进行宠物召唤操作").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.riHFHW3D4K.user.背包数据.物品列表[提交格子].封包缓存, 提交格子)).ToArray());
				return;
			}
			int 数量 = CS_0024_003C_003E8__locals34.riHFHW3D4K.user.背包数据.物品列表[提交格子].数量;
			CS_0024_003C_003E8__locals34.USfFeRn8WL = CS_0024_003C_003E8__locals34.riHFHW3D4K.user.存档数据.召唤数据.变异珠;
			int num = Singleton<WdAPI>.I.qrjo9TWIdy((int)((double)Singleton<全局变量类>.I.宠物召唤配置.变异最高 * 0.8), Singleton<全局变量类>.I.宠物召唤配置.变异最高);
			int num2 = 0;
			CS_0024_003C_003E8__locals34.QVhF4PqMxc = false;
			for (int i = 0; i < 数量; i++)
			{
				num2++;
				CS_0024_003C_003E8__locals34.USfFeRn8WL++;
				CS_0024_003C_003E8__locals34.QVhF4PqMxc = CS_0024_003C_003E8__locals34.USfFeRn8WL >= num;
				if (CS_0024_003C_003E8__locals34.QVhF4PqMxc)
				{
					break;
				}
			}
			CS_0024_003C_003E8__locals34.riHFHW3D4K.user.存档数据.召唤数据.变异珠 = CS_0024_003C_003E8__locals34.USfFeRn8WL;
			CS_0024_003C_003E8__locals34.riHFHW3D4K.销毁回调事件 =  (string v) =>
			{
				if (v == Singleton<全局变量类>.I.宠物召唤配置.变异材料)
				{
					CS_0024_003C_003E8__locals34.riHFHW3D4K.销毁回调事件 = null;
					if (CS_0024_003C_003E8__locals34.QVhF4PqMxc)
					{
						CS_0024_003C_003E8__locals34.riHFHW3D4K.user.存档数据.召唤数据.变异珠 = 0;
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals34.riHFHW3D4K, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.宠物召唤配置.变异奖励, AllEnums.指令Type.无, 1, false, "宠物召唤变异");
						MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals34.riHFHW3D4K;
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler2.AppendLiteral("您提交总数到达#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals34.USfFeRn8WL);
						defaultInterpolatedStringHandler2.AppendLiteral("#n次,获得了#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异奖励);
						defaultInterpolatedStringHandler2.AppendLiteral("#n");
						myNATSocketClient.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
						if (client频道事件 != null)
						{
							WdAPI i3 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(37, 4);
							defaultInterpolatedStringHandler2.AppendLiteral("听闻#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals34.riHFHW3D4K.user.人物数据.昵称);
							defaultInterpolatedStringHandler2.AppendLiteral("#n仅仅用了#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals34.USfFeRn8WL);
							defaultInterpolatedStringHandler2.AppendLiteral("#n个#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异材料);
							defaultInterpolatedStringHandler2.AppendLiteral("#n就召唤出了#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异奖励);
							defaultInterpolatedStringHandler2.AppendLiteral("#n，真是羡煞旁人啊！");
							client频道事件(i3.组包聊天信息(defaultInterpolatedStringHandler2.ToStringAndClear(), "管理员"));
						}
					}
					else
					{
						double num3 = 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.变异最高;
						MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals34.riHFHW3D4K;
						WdAPI i4 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(55, 2);
						defaultInterpolatedStringHandler2.AppendLiteral("加油,你离成功召唤变异又近了一步！增加了：#R");
						defaultInterpolatedStringHandler2.AppendFormatted(num3, "F2");
						defaultInterpolatedStringHandler2.AppendLiteral("%#n的概率，目前概率为#R");
						defaultInterpolatedStringHandler2.AppendFormatted(num3 * (double)CS_0024_003C_003E8__locals34.USfFeRn8WL, "F2");
						defaultInterpolatedStringHandler2.AppendLiteral("%#n，每次提交都会有一定几率成功！");
						myNATSocketClient2.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler2.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("加油,你离成功召唤变异又近了一步！，每次提交都会有一定几率成功")).ToArray());
					}
				}
			};
			CS_0024_003C_003E8__locals34.riHFHW3D4K.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.riHFHW3D4K.user.背包数据.物品列表[提交格子].封包缓存, 提交格子));
			CS_0024_003C_003E8__locals34.riHFHW3D4K.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(提交格子, num2), "变异召唤处理");
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("变异召唤处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void 神兽召唤处理(MyNATSocketClient myclient, int 提交格子)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals34 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals34.pbaFrg49kE = myclient;
		try
		{
			if (CS_0024_003C_003E8__locals34.pbaFrg49kE.user.背包数据.物品列表[提交格子].名字 != Singleton<全局变量类>.I.宠物召唤配置.神兽材料)
			{
				CS_0024_003C_003E8__locals34.pbaFrg49kE.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请提交#Y" + Singleton<全局变量类>.I.宠物召唤配置.神兽材料 + "#n！！！").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.pbaFrg49kE.user.背包数据.物品列表[提交格子].封包缓存, 提交格子)).ToArray());
				return;
			}
			if (!Singleton<WdAPI>.I.dSCoKmGWP9(CS_0024_003C_003E8__locals34.pbaFrg49kE))
			{
				CS_0024_003C_003E8__locals34.pbaFrg49kE.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的宠物栏空位不足，清整理后再来。").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.pbaFrg49kE.user.背包数据.物品列表[提交格子].封包缓存, 提交格子)).ToArray());
				return;
			}
			if (Singleton<WdAPI>.I.取背包剩余空格数(CS_0024_003C_003E8__locals34.pbaFrg49kE) < 1)
			{
				CS_0024_003C_003E8__locals34.pbaFrg49kE.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的包裹栏空位不足，无法进行宠物召唤操作。").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.pbaFrg49kE.user.背包数据.物品列表[提交格子].封包缓存, 提交格子)).ToArray());
				return;
			}
			int 数量 = CS_0024_003C_003E8__locals34.pbaFrg49kE.user.背包数据.物品列表[提交格子].数量;
			CS_0024_003C_003E8__locals34.QrAFtP28lo = CS_0024_003C_003E8__locals34.pbaFrg49kE.user.存档数据.召唤数据.神兽珠;
			int num = Singleton<WdAPI>.I.qrjo9TWIdy((int)((double)Singleton<全局变量类>.I.宠物召唤配置.神兽最高 * 0.8), Singleton<全局变量类>.I.宠物召唤配置.神兽最高);
			int num2 = 0;
			CS_0024_003C_003E8__locals34.aT4FZF1vt4 = false;
			for (int i = 0; i < 数量; i++)
			{
				num2++;
				CS_0024_003C_003E8__locals34.QrAFtP28lo++;
				CS_0024_003C_003E8__locals34.aT4FZF1vt4 = CS_0024_003C_003E8__locals34.QrAFtP28lo >= num;
				if (CS_0024_003C_003E8__locals34.aT4FZF1vt4)
				{
					break;
				}
			}
			CS_0024_003C_003E8__locals34.pbaFrg49kE.user.存档数据.召唤数据.神兽珠 = CS_0024_003C_003E8__locals34.QrAFtP28lo;
			CS_0024_003C_003E8__locals34.pbaFrg49kE.销毁回调事件 =  (string v) =>
			{
				if (v == Singleton<全局变量类>.I.宠物召唤配置.神兽材料)
				{
					CS_0024_003C_003E8__locals34.pbaFrg49kE.销毁回调事件 = null;
					if (CS_0024_003C_003E8__locals34.aT4FZF1vt4)
					{
						CS_0024_003C_003E8__locals34.pbaFrg49kE.user.存档数据.召唤数据.神兽珠 = 0;
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals34.pbaFrg49kE, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.宠物召唤配置.神兽奖励, AllEnums.指令Type.无, 1, false, "宠物召唤神兽");
						MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals34.pbaFrg49kE;
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler2.AppendLiteral("您提交总数到达#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals34.QrAFtP28lo);
						defaultInterpolatedStringHandler2.AppendLiteral("#n次,获得了#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽奖励);
						defaultInterpolatedStringHandler2.AppendLiteral("#n");
						myNATSocketClient.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
						if (client频道事件 != null)
						{
							WdAPI i3 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(37, 4);
							defaultInterpolatedStringHandler2.AppendLiteral("听闻#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals34.pbaFrg49kE.user.人物数据.昵称);
							defaultInterpolatedStringHandler2.AppendLiteral("#n仅仅用了#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals34.QrAFtP28lo);
							defaultInterpolatedStringHandler2.AppendLiteral("#n个#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽材料);
							defaultInterpolatedStringHandler2.AppendLiteral("#n就召唤出了#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽奖励);
							defaultInterpolatedStringHandler2.AppendLiteral("#n，真是羡煞旁人啊！");
							client频道事件(i3.组包聊天信息(defaultInterpolatedStringHandler2.ToStringAndClear(), "管理员"));
						}
					}
					else
					{
						double num3 = 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.神兽最高;
						MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals34.pbaFrg49kE;
						WdAPI i4 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(55, 2);
						defaultInterpolatedStringHandler2.AppendLiteral("加油,你离成功召唤神兽又近了一步！增加了：#R");
						defaultInterpolatedStringHandler2.AppendFormatted(num3, "F2");
						defaultInterpolatedStringHandler2.AppendLiteral("%#n的概率，目前概率为#R");
						defaultInterpolatedStringHandler2.AppendFormatted(num3 * (double)CS_0024_003C_003E8__locals34.QrAFtP28lo, "F2");
						defaultInterpolatedStringHandler2.AppendLiteral("%#n，每次提交都会有一定几率成功！");
						myNATSocketClient2.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler2.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("加油,你离成功召唤神兽又近了一步！，每次提交都会有一定几率成功")).ToArray());
					}
				}
			};
			CS_0024_003C_003E8__locals34.pbaFrg49kE.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.pbaFrg49kE.user.背包数据.物品列表[提交格子].封包缓存, 提交格子));
			CS_0024_003C_003E8__locals34.pbaFrg49kE.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(提交格子, num2), "神兽召唤处理");
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("神兽召唤处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void 元灵召唤处理(MyNATSocketClient myclient, int 提交格子)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals34 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals34.tCOFzLOS0u = myclient;
		try
		{
			if (CS_0024_003C_003E8__locals34.tCOFzLOS0u.user.背包数据.物品列表[提交格子].名字 != Singleton<全局变量类>.I.宠物召唤配置.元灵材料)
			{
				CS_0024_003C_003E8__locals34.tCOFzLOS0u.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请提交#Y" + Singleton<全局变量类>.I.宠物召唤配置.元灵材料 + "#n！！！").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.tCOFzLOS0u.user.背包数据.物品列表[提交格子].封包缓存, 提交格子)).ToArray());
				return;
			}
			if (!Singleton<WdAPI>.I.dSCoKmGWP9(CS_0024_003C_003E8__locals34.tCOFzLOS0u))
			{
				CS_0024_003C_003E8__locals34.tCOFzLOS0u.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的宠物栏空位不足，清整理后再来。").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.tCOFzLOS0u.user.背包数据.物品列表[提交格子].封包缓存, 提交格子)).ToArray());
				return;
			}
			if (Singleton<WdAPI>.I.取背包剩余空格数(CS_0024_003C_003E8__locals34.tCOFzLOS0u) < 1)
			{
				CS_0024_003C_003E8__locals34.tCOFzLOS0u.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的包裹栏空位不足，无法进行宠物召唤操作！").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.tCOFzLOS0u.user.背包数据.物品列表[提交格子].封包缓存, 提交格子)).ToArray());
				return;
			}
			int 数量 = CS_0024_003C_003E8__locals34.tCOFzLOS0u.user.背包数据.物品列表[提交格子].数量;
			CS_0024_003C_003E8__locals34.jKULwoolkv = CS_0024_003C_003E8__locals34.tCOFzLOS0u.user.存档数据.召唤数据.元灵珠;
			int num = Singleton<WdAPI>.I.qrjo9TWIdy((int)((double)Singleton<全局变量类>.I.宠物召唤配置.元灵最高 * 0.8), Singleton<全局变量类>.I.宠物召唤配置.元灵最高);
			int num2 = 0;
			CS_0024_003C_003E8__locals34.duYLuhiK1t = false;
			for (int i = 0; i < 数量; i++)
			{
				num2++;
				CS_0024_003C_003E8__locals34.jKULwoolkv++;
				CS_0024_003C_003E8__locals34.duYLuhiK1t = CS_0024_003C_003E8__locals34.jKULwoolkv >= num;
				if (CS_0024_003C_003E8__locals34.duYLuhiK1t)
				{
					break;
				}
			}
			CS_0024_003C_003E8__locals34.tCOFzLOS0u.user.存档数据.召唤数据.元灵珠 = CS_0024_003C_003E8__locals34.jKULwoolkv;
			CS_0024_003C_003E8__locals34.tCOFzLOS0u.销毁回调事件 =  (string v) =>
			{
				if (v == Singleton<全局变量类>.I.宠物召唤配置.元灵材料)
				{
					CS_0024_003C_003E8__locals34.tCOFzLOS0u.销毁回调事件 = null;
					if (CS_0024_003C_003E8__locals34.duYLuhiK1t)
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals34.tCOFzLOS0u, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.宠物召唤配置.元灵奖励, AllEnums.指令Type.无, 1, false, "宠物召唤元灵");
						MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals34.tCOFzLOS0u;
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler2.AppendLiteral("您提交总数到达#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals34.jKULwoolkv);
						defaultInterpolatedStringHandler2.AppendLiteral("#n次,获得了#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵奖励);
						defaultInterpolatedStringHandler2.AppendLiteral("#n");
						myNATSocketClient.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
						if (client频道事件 != null)
						{
							WdAPI i3 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(37, 4);
							defaultInterpolatedStringHandler2.AppendLiteral("听闻#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals34.tCOFzLOS0u.user.人物数据.昵称);
							defaultInterpolatedStringHandler2.AppendLiteral("#n仅仅用了#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals34.jKULwoolkv);
							defaultInterpolatedStringHandler2.AppendLiteral("#n个#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵材料);
							defaultInterpolatedStringHandler2.AppendLiteral("#n就召唤出了#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵奖励);
							defaultInterpolatedStringHandler2.AppendLiteral("#n，真是羡煞旁人啊！");
							client频道事件(i3.组包聊天信息(defaultInterpolatedStringHandler2.ToStringAndClear(), "管理员"));
						}
						CS_0024_003C_003E8__locals34.tCOFzLOS0u.user.存档数据.召唤数据.元灵珠 = 0;
					}
					else
					{
						double num3 = 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.元灵最高;
						MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals34.tCOFzLOS0u;
						WdAPI i4 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(55, 2);
						defaultInterpolatedStringHandler2.AppendLiteral("加油,你离成功召唤元灵又近了一步！增加了：#R");
						defaultInterpolatedStringHandler2.AppendFormatted(num3, "F2");
						defaultInterpolatedStringHandler2.AppendLiteral("%#n的概率，目前概率为#R");
						defaultInterpolatedStringHandler2.AppendFormatted(num3 * (double)CS_0024_003C_003E8__locals34.jKULwoolkv, "F2");
						defaultInterpolatedStringHandler2.AppendLiteral("%#n，每次提交都会有一定几率成功！");
						myNATSocketClient2.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler2.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("加油,你离成功召唤元灵又近了一步！，每次提交都会有一定几率成功")).ToArray());
					}
				}
			};
			CS_0024_003C_003E8__locals34.tCOFzLOS0u.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.tCOFzLOS0u.user.背包数据.物品列表[提交格子].封包缓存, 提交格子));
			CS_0024_003C_003E8__locals34.tCOFzLOS0u.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(提交格子, num2), "元灵召唤处理");
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("元灵召唤处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void PiLKHKM4vW(MyNATSocketClient P_0, int P_1)
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals34 = new _003C_003Ec__DisplayClass21_0();
		CS_0024_003C_003E8__locals34.BG2LJKbygB = P_0;
		if (CS_0024_003C_003E8__locals34.BG2LJKbygB.user.背包数据.物品列表[P_1].名字 != Singleton<全局变量类>.I.宠物召唤配置.仙元材料)
		{
			CS_0024_003C_003E8__locals34.BG2LJKbygB.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请提交#Y" + Singleton<全局变量类>.I.宠物召唤配置.仙元材料 + "#n！！！").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.BG2LJKbygB.user.背包数据.物品列表[P_1].封包缓存, P_1)).ToArray());
			return;
		}
		if (!Singleton<WdAPI>.I.dSCoKmGWP9(CS_0024_003C_003E8__locals34.BG2LJKbygB))
		{
			CS_0024_003C_003E8__locals34.BG2LJKbygB.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的宠物栏空位不足，清整理后再来。").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.BG2LJKbygB.user.背包数据.物品列表[P_1].封包缓存, P_1)).ToArray());
			return;
		}
		if (Singleton<WdAPI>.I.取背包剩余空格数(CS_0024_003C_003E8__locals34.BG2LJKbygB) < 1)
		{
			CS_0024_003C_003E8__locals34.BG2LJKbygB.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的包裹栏空位不足，无法进行宠物召唤操作").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.BG2LJKbygB.user.背包数据.物品列表[P_1].封包缓存, P_1)).ToArray());
			return;
		}
		int 数量 = CS_0024_003C_003E8__locals34.BG2LJKbygB.user.背包数据.物品列表[P_1].数量;
		CS_0024_003C_003E8__locals34.DUHLRmrbDf = CS_0024_003C_003E8__locals34.BG2LJKbygB.user.存档数据.召唤数据.仙元珠;
		int num = Singleton<WdAPI>.I.qrjo9TWIdy((int)((double)Singleton<全局变量类>.I.宠物召唤配置.仙元最高 * 0.8), Singleton<全局变量类>.I.宠物召唤配置.仙元最高);
		int num2 = 0;
		CS_0024_003C_003E8__locals34.FR1LKRYsvu = false;
		for (int i = 0; i < 数量; i++)
		{
			num2++;
			CS_0024_003C_003E8__locals34.DUHLRmrbDf++;
			CS_0024_003C_003E8__locals34.FR1LKRYsvu = CS_0024_003C_003E8__locals34.DUHLRmrbDf >= num;
			if (CS_0024_003C_003E8__locals34.FR1LKRYsvu)
			{
				break;
			}
		}
		CS_0024_003C_003E8__locals34.BG2LJKbygB.user.存档数据.召唤数据.仙元珠 = CS_0024_003C_003E8__locals34.DUHLRmrbDf;
		CS_0024_003C_003E8__locals34.BG2LJKbygB.销毁回调事件 =  (string v) =>
		{
			if (v == Singleton<全局变量类>.I.宠物召唤配置.仙元材料)
			{
				CS_0024_003C_003E8__locals34.BG2LJKbygB.销毁回调事件 = null;
				if (CS_0024_003C_003E8__locals34.FR1LKRYsvu)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals34.BG2LJKbygB, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.宠物召唤配置.仙元奖励, AllEnums.指令Type.无, 1, false, "宠物召唤仙元");
					MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals34.BG2LJKbygB;
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
					defaultInterpolatedStringHandler.AppendLiteral("您提交总数到达#Y");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals34.DUHLRmrbDf);
					defaultInterpolatedStringHandler.AppendLiteral("#n次,获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元奖励);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					myNATSocketClient.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件 != null)
					{
						WdAPI i3 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 4);
						defaultInterpolatedStringHandler.AppendLiteral("听闻#Y");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals34.BG2LJKbygB.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n仅仅用了#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals34.DUHLRmrbDf);
						defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元材料);
						defaultInterpolatedStringHandler.AppendLiteral("#n就召唤出了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元奖励);
						defaultInterpolatedStringHandler.AppendLiteral("#n，真是羡煞旁人啊！");
						client频道事件(i3.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
					CS_0024_003C_003E8__locals34.BG2LJKbygB.user.存档数据.召唤数据.仙元珠 = 0;
				}
				else
				{
					double num3 = 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.仙元最高;
					MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals34.BG2LJKbygB;
					WdAPI i4 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(55, 2);
					defaultInterpolatedStringHandler.AppendLiteral("加油,你离成功召唤仙元又近了一步！增加了：#R");
					defaultInterpolatedStringHandler.AppendFormatted(num3, "F2");
					defaultInterpolatedStringHandler.AppendLiteral("%#n的概率，目前概率为#R");
					defaultInterpolatedStringHandler.AppendFormatted(num3 * (double)CS_0024_003C_003E8__locals34.DUHLRmrbDf, "F2");
					defaultInterpolatedStringHandler.AppendLiteral("%#n，每次提交都会有一定几率成功！");
					myNATSocketClient2.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("加油,你离成功召唤仙元又近了一步！，每次提交都会有一定几率成功")).ToArray());
				}
			}
		};
		CS_0024_003C_003E8__locals34.BG2LJKbygB.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.BG2LJKbygB.user.背包数据.物品列表[P_1].封包缓存, P_1));
		CS_0024_003C_003E8__locals34.BG2LJKbygB.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(P_1, num2));
	}

	
	private void 御灵召唤处理(MyNATSocketClient myclient, int 提交格子)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals34 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals34.wyHLstEnU7 = myclient;
		try
		{
			if (CS_0024_003C_003E8__locals34.wyHLstEnU7.user.背包数据.物品列表[提交格子].名字 != Singleton<全局变量类>.I.宠物召唤配置.御灵材料)
			{
				CS_0024_003C_003E8__locals34.wyHLstEnU7.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请提交#Y" + Singleton<全局变量类>.I.宠物召唤配置.御灵材料 + "#n！！！").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.wyHLstEnU7.user.背包数据.物品列表[提交格子].封包缓存, 提交格子)).ToArray());
				return;
			}
			if (!Singleton<WdAPI>.I.dSCoKmGWP9(CS_0024_003C_003E8__locals34.wyHLstEnU7))
			{
				CS_0024_003C_003E8__locals34.wyHLstEnU7.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的宠物栏空位不足，清整理后再来！").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.wyHLstEnU7.user.背包数据.物品列表[提交格子].封包缓存, 提交格子)).ToArray());
				return;
			}
			if (Singleton<WdAPI>.I.取背包剩余空格数(CS_0024_003C_003E8__locals34.wyHLstEnU7) < 1)
			{
				CS_0024_003C_003E8__locals34.wyHLstEnU7.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的包裹栏空位不足，清整理后再来！").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.wyHLstEnU7.user.背包数据.物品列表[提交格子].封包缓存, 提交格子)).ToArray());
				return;
			}
			int 数量 = CS_0024_003C_003E8__locals34.wyHLstEnU7.user.背包数据.物品列表[提交格子].数量;
			CS_0024_003C_003E8__locals34.G6ILWZF3OJ = CS_0024_003C_003E8__locals34.wyHLstEnU7.user.存档数据.召唤数据.御灵珠;
			int num = Singleton<WdAPI>.I.qrjo9TWIdy((int)((double)Singleton<全局变量类>.I.宠物召唤配置.御灵最高 * 0.8), Singleton<全局变量类>.I.宠物召唤配置.御灵最高);
			int num2 = 0;
			CS_0024_003C_003E8__locals34.RewLUMjLVp = false;
			for (int i = 0; i < 数量; i++)
			{
				num2++;
				CS_0024_003C_003E8__locals34.G6ILWZF3OJ++;
				CS_0024_003C_003E8__locals34.RewLUMjLVp = CS_0024_003C_003E8__locals34.G6ILWZF3OJ >= num;
				if (CS_0024_003C_003E8__locals34.RewLUMjLVp)
				{
					break;
				}
			}
			CS_0024_003C_003E8__locals34.wyHLstEnU7.user.存档数据.召唤数据.御灵珠 = CS_0024_003C_003E8__locals34.G6ILWZF3OJ;
			CS_0024_003C_003E8__locals34.wyHLstEnU7.销毁回调事件 =  (string v) =>
			{
				if (v == Singleton<全局变量类>.I.宠物召唤配置.御灵材料)
				{
					CS_0024_003C_003E8__locals34.wyHLstEnU7.销毁回调事件 = null;
					if (CS_0024_003C_003E8__locals34.RewLUMjLVp)
					{
						Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals34.wyHLstEnU7, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.宠物召唤配置.御灵奖励, AllEnums.指令Type.无, 1, false, "宠物召唤御灵");
						MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals34.wyHLstEnU7;
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler2.AppendLiteral("您提交总数到达#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals34.G6ILWZF3OJ);
						defaultInterpolatedStringHandler2.AppendLiteral("#n次,获得了#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵奖励);
						defaultInterpolatedStringHandler2.AppendLiteral("#n");
						myNATSocketClient.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
						if (client频道事件 != null)
						{
							WdAPI i3 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(37, 4);
							defaultInterpolatedStringHandler2.AppendLiteral("听闻#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals34.wyHLstEnU7.user.人物数据.昵称);
							defaultInterpolatedStringHandler2.AppendLiteral("#n仅仅用了#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals34.G6ILWZF3OJ);
							defaultInterpolatedStringHandler2.AppendLiteral("#n个#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵材料);
							defaultInterpolatedStringHandler2.AppendLiteral("#n就召唤出了#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵奖励);
							defaultInterpolatedStringHandler2.AppendLiteral("#n，真是羡煞旁人啊！");
							client频道事件(i3.组包聊天信息(defaultInterpolatedStringHandler2.ToStringAndClear(), "管理员"));
						}
						CS_0024_003C_003E8__locals34.wyHLstEnU7.user.存档数据.召唤数据.御灵珠 = 0;
					}
					else
					{
						double num3 = 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.御灵最高;
						MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals34.wyHLstEnU7;
						WdAPI i4 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(55, 2);
						defaultInterpolatedStringHandler2.AppendLiteral("加油,你离成功召唤御灵又近了一步！增加了：#R");
						defaultInterpolatedStringHandler2.AppendFormatted(num3, "F2");
						defaultInterpolatedStringHandler2.AppendLiteral("%#n的概率，目前概率为#R");
						defaultInterpolatedStringHandler2.AppendFormatted(num3 * (double)CS_0024_003C_003E8__locals34.G6ILWZF3OJ, "F2");
						defaultInterpolatedStringHandler2.AppendLiteral("%#n，每次提交都会有一定几率成功！");
						myNATSocketClient2.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler2.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("加油,你离成功召唤御灵又近了一步！，每次提交都会有一定几率成功")).ToArray());
					}
				}
			};
			CS_0024_003C_003E8__locals34.wyHLstEnU7.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals34.wyHLstEnU7.user.背包数据.物品列表[提交格子].封包缓存, 提交格子));
			CS_0024_003C_003E8__locals34.wyHLstEnU7.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(提交格子, num2), "御灵召唤处理");
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("御灵召唤处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void gKhK40vcxv(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_1 == "宠物操作_宠物同源")
			{
				StringBuilder stringBuilder = new StringBuilder("#Y欢迎参加宠物同源活动，每个宠物只有一次激活同源属性机会，宠物在激活同源属性后各项成长会获得大幅提升！#n#r");
				if (Singleton<全局变量类>.I.宠物同源配置.is普通同源)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(32, 5, stringBuilder2);
					handler.AppendLiteral("普通（同源成长上限+");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.普通同源成长);
					handler.AppendLiteral("）：#n#r    ");
					handler.AppendLiteral("转属");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.普通转属价格);
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.普通转属类型);
					handler.AppendLiteral("/次  激活");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.普通激活价格);
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.普通激活类型);
					handler.AppendLiteral("/次#r");
					stringBuilder3.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.宠物同源配置.is变异同源)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(34, 5, stringBuilder2);
					handler.AppendLiteral("#B变异（同源成长上限+");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.变异同源成长);
					handler.AppendLiteral("）：#n#r    ");
					handler.AppendLiteral("转属");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.变异转属价格);
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.变异转属类型);
					handler.AppendLiteral("/次  激活");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.变异激活价格);
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.变异激活类型);
					handler.AppendLiteral("/次#r");
					stringBuilder4.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.宠物同源配置.is神兽同源)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(35, 5, stringBuilder2);
					handler.AppendLiteral("#O神兽（同源成长上限+");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.神兽同源成长);
					handler.AppendLiteral("）：#n#r    ");
					handler.AppendLiteral("转属 ");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.神兽转属价格);
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.神兽转属类型);
					handler.AppendLiteral("/次  激活");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.神兽激活价格);
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.神兽激活类型);
					handler.AppendLiteral("/次#r");
					stringBuilder5.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.宠物同源配置.is元灵同源)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(35, 5, stringBuilder2);
					handler.AppendLiteral("#Y元灵（同源成长上限+");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.元灵同源成长);
					handler.AppendLiteral("）：#n#r    ");
					handler.AppendLiteral("转属 ");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.元灵转属价格);
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.元灵转属类型);
					handler.AppendLiteral("/次  激活");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.元灵激活价格);
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.元灵激活类型);
					handler.AppendLiteral("/次#r");
					stringBuilder6.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.宠物同源配置.is仙元同源)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(35, 5, stringBuilder2);
					handler.AppendLiteral("#L仙元（同源成长上限+");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.仙元同源成长);
					handler.AppendLiteral("）：#n#r    ");
					handler.AppendLiteral("转属 ");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.仙元转属价格);
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.仙元转属类型);
					handler.AppendLiteral("/次  激活");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.仙元激活价格);
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物同源配置.仙元激活类型);
					handler.AppendLiteral("/次#r");
					stringBuilder7.Append(ref handler);
				}
				stringBuilder.Append("#G下列是没有激活过同源属性的宠物，请选择你想要进行同源的宠物：#n");
				for (int i = 0; i < P_0.user.宠物数据.Length; i++)
				{
					if (P_0.user.宠物数据[i].PetID == 0 || string.IsNullOrWhiteSpace(P_0.user.宠物数据[i].IID) || (!Singleton<全局变量类>.I.宠物同源配置.is普通同源 && Singleton<AllEnums>.I.Get宠物类型(P_0.user.宠物数据[i].类型) == AllEnums.宠物Type.普通) || (!Singleton<全局变量类>.I.宠物同源配置.is变异同源 && Singleton<AllEnums>.I.Get宠物类型(P_0.user.宠物数据[i].类型) == AllEnums.宠物Type.变异) || (!Singleton<全局变量类>.I.宠物同源配置.is神兽同源 && Singleton<AllEnums>.I.Get宠物类型(P_0.user.宠物数据[i].类型) == AllEnums.宠物Type.神兽) || (!Singleton<全局变量类>.I.宠物同源配置.is元灵同源 && Singleton<AllEnums>.I.Get宠物类型(P_0.user.宠物数据[i].类型) == AllEnums.宠物Type.元灵) || (!Singleton<全局变量类>.I.宠物同源配置.is仙元同源 && Singleton<AllEnums>.I.Get宠物类型(P_0.user.宠物数据[i].类型) == AllEnums.宠物Type.仙元))
					{
						continue;
					}
					if (Singleton<全局变量类>.I.宠物存档表.TryGetValue(P_0.user.宠物数据[i].IID, out var value))
					{
						if (!value.is同源激活)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder8 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 4, stringBuilder2);
							handler.AppendLiteral("[");
							handler.AppendFormatted(P_0.user.宠物数据[i].昵称A);
							handler.AppendLiteral("（");
							handler.AppendFormatted(P_0.user.宠物数据[i].昵称B);
							handler.AppendLiteral("）·");
							handler.AppendFormatted(P_0.user.宠物数据[i].等级);
							handler.AppendLiteral("级·已同源·未激活/宠物操作_宠物同源_首次转属");
							handler.AppendFormatted(P_0.user.宠物数据[i].IID);
							handler.AppendLiteral("]");
							stringBuilder8.Append(ref handler);
						}
					}
					else
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder9 = stringBuilder2;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(21, 4, stringBuilder2);
						handler.AppendLiteral("[");
						handler.AppendFormatted(P_0.user.宠物数据[i].昵称A);
						handler.AppendLiteral("（");
						handler.AppendFormatted(P_0.user.宠物数据[i].昵称B);
						handler.AppendLiteral("）·");
						handler.AppendFormatted(P_0.user.宠物数据[i].等级);
						handler.AppendLiteral("级/宠物操作_宠物同源_首次转属");
						handler.AppendFormatted(P_0.user.宠物数据[i].IID);
						handler.AppendLiteral("]");
						stringBuilder9.Append(ref handler);
					}
				}
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(102, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字, stringBuilder.ToString()));
			}
			else if (P_1.Contains("宠物操作_宠物同源_首次转属", StringComparison.CurrentCulture))
			{
				_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass23_0();
				CS_0024_003C_003E8__locals5.MgJLDSC35m = P_1.Replace("宠物操作_宠物同源_首次转属", "");
				宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.Find( (宠物缓存数据类 a) => !string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals5.MgJLDSC35m) && a.IID == CS_0024_003C_003E8__locals5.MgJLDSC35m);
				if (宠物缓存数据类2 != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#G当前选择的宠物为：#Y");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("（");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<AllEnums>.I.Get宠物类型(宠物缓存数据类2.类型));
					defaultInterpolatedStringHandler.AppendLiteral("）#n#r");
					StringBuilder stringBuilder10 = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
					同源类型配置类 同源类型配置类2 = ugvKrDsvWP(宠物缓存数据类2.类型);
					Singleton<全局变量类>.I.宠物存档表.TryGetValue(宠物缓存数据类2.IID, out var value2);
					if (value2 == null)
					{
						value2 = new 宠物存档数据类
						{
							IID = 宠物缓存数据类2.IID,
							is同源激活 = false,
							转属次数 = 0
						};
						Singleton<全局变量类>.I.宠物存档表.TryAdd(宠物缓存数据类2.IID, value2);
						value2.同源属性 = WUHKZDBgLk(P_0.user.人物数据.昵称, 宠物缓存数据类2.类型, value2.转属次数, 同源类型配置类2.转属次数, 同源类型配置类2.同源成长);
						DB.I.irWib79NaP(value2.IID, value2);
					}
					StringBuilder stringBuilder2 = stringBuilder10;
					StringBuilder stringBuilder11 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
					handler.AppendLiteral("#Y");
					handler.AppendFormatted(宠物缓存数据类2.昵称A);
					handler.AppendLiteral("#n当前同源属性：#r");
					stringBuilder11.Append(ref handler);
					for (int num = 0; num < value2.同源属性.Count; num++)
					{
						stringBuilder2 = stringBuilder10;
						StringBuilder stringBuilder12 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(9, 4, stringBuilder2);
						handler.AppendFormatted(全局常量类.同源颜色[(int)value2.同源属性[num].同源成长]);
						handler.AppendFormatted(value2.同源属性[num].同源成长);
						handler.AppendLiteral(" ");
						handler.AppendFormatted(value2.同源属性[num].成长数值);
						handler.AppendLiteral("/");
						handler.AppendFormatted(同源类型配置类2.同源成长);
						handler.AppendLiteral(" 增加#n#r");
						stringBuilder12.Append(ref handler);
					}
					stringBuilder2 = stringBuilder10;
					StringBuilder stringBuilder13 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(27, 3, stringBuilder2);
					handler.AppendLiteral("[【转属】同源转换属性(");
					handler.AppendFormatted(同源类型配置类2.转属价格);
					handler.AppendFormatted(同源类型配置类2.转属类型);
					handler.AppendLiteral(")/宠物操作_宠物同源_转属");
					handler.AppendFormatted(宠物缓存数据类2.IID);
					handler.AppendLiteral("]");
					stringBuilder13.Append(ref handler);
					stringBuilder2 = stringBuilder10;
					StringBuilder stringBuilder14 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(35, 1, stringBuilder2);
					handler.AppendLiteral("[【自动转属】出现3条以上相同属性停止/宠物操作_宠物同源_自动转属");
					handler.AppendFormatted(宠物缓存数据类2.IID);
					handler.AppendLiteral("]");
					stringBuilder14.Append(ref handler);
					stringBuilder2 = stringBuilder10;
					StringBuilder stringBuilder15 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(27, 3, stringBuilder2);
					handler.AppendLiteral("[【激活】同源属性激活(");
					handler.AppendFormatted(同源类型配置类2.激活价格);
					handler.AppendFormatted(同源类型配置类2.激活类型);
					handler.AppendLiteral(")/宠物操作_宠物同源_激活");
					handler.AppendFormatted(宠物缓存数据类2.IID);
					handler.AppendLiteral("]");
					stringBuilder15.Append(ref handler);
					stringBuilder2 = stringBuilder10;
					StringBuilder stringBuilder16 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(24, 1, stringBuilder2);
					handler.AppendLiteral("#r#M激活后额外获得所有成长+");
					handler.AppendFormatted(同源类型配置类2.激活成长);
					handler.AppendLiteral("的成长提升！！！");
					stringBuilder16.Append(ref handler);
					P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(102, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字, stringBuilder10.ToString()));
				}
			}
			else if (P_1.Contains("宠物操作_宠物同源_转属", StringComparison.CurrentCulture))
			{
				_003C_003Ec__DisplayClass23_1 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass23_1();
				CS_0024_003C_003E8__locals7.VZWLlRRbNp = P_1.Replace("宠物操作_宠物同源_转属", "");
				宠物缓存数据类 宠物缓存数据类3 = P_0.user.宠物数据.ToList().Find( (宠物缓存数据类 a) => !string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals7.VZWLlRRbNp) && a.IID == CS_0024_003C_003E8__locals7.VZWLlRRbNp);
				if (宠物缓存数据类3 == null)
				{
					return;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#G当前选择的宠物为：#Y");
				defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类3.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("（");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<AllEnums>.I.Get宠物类型(宠物缓存数据类3.类型));
				defaultInterpolatedStringHandler.AppendLiteral("）#n#r");
				StringBuilder stringBuilder17 = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				同源类型配置类 同源类型配置类3 = ugvKrDsvWP(宠物缓存数据类3.类型);
				Singleton<全局变量类>.I.宠物存档表.TryGetValue(宠物缓存数据类3.IID, out var value3);
				if (value3 == null)
				{
					value3 = new 宠物存档数据类
					{
						IID = 宠物缓存数据类3.IID,
						is同源激活 = false,
						转属次数 = 0
					};
					Singleton<全局变量类>.I.宠物存档表.TryAdd(宠物缓存数据类3.IID, value3);
					DB.I.irWib79NaP(value3.IID, value3);
				}
				else
				{
					if (value3.is同源激活)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("同源#Y已激活#n,#R无法进行属性转换#n！"));
						return;
					}
					if (同源类型配置类3.转属类型 == AllEnums.数值Type.金元宝)
					{
						if (P_0.user.背包数据.金元宝 < 同源类型配置类3.转属价格)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R金元宝不足#n,无法继续操作！"));
							return;
						}
						if (!DB.I.cAJNoOkab6(P_0, -同源类型配置类3.转属价格, 0))
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R金元宝不足#n,无法继续操作！"));
							return;
						}
					}
					else if (同源类型配置类3.转属类型 == AllEnums.数值Type.银元宝)
					{
						if (P_0.user.背包数据.银元宝 < 同源类型配置类3.转属价格)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R银元宝不足#n,无法继续操作！"));
							return;
						}
						if (!DB.I.cAJNoOkab6(P_0, 0, -同源类型配置类3.转属价格))
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R银元宝不足#n,无法继续操作！"));
							return;
						}
					}
					else if (同源类型配置类3.转属类型 == AllEnums.数值Type.灵气值)
					{
						if (P_0.user.存档数据.数值存档.灵气值 < 同源类型配置类3.转属价格)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R灵气值不足#n,无法继续操作！"));
							return;
						}
						Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -同源类型配置类3.转属价格, false, "[同源转换]消耗");
					}
					value3.转属次数++;
				}
				value3.同源属性 = WUHKZDBgLk(P_0.user.人物数据.昵称, 宠物缓存数据类3.类型, value3.转属次数, 同源类型配置类3.转属次数, 同源类型配置类3.同源成长);
				StringBuilder stringBuilder2 = stringBuilder17;
				StringBuilder stringBuilder18 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(宠物缓存数据类3.昵称A);
				handler.AppendLiteral("#n当前同源属性：#r");
				stringBuilder18.Append(ref handler);
				for (int num2 = 0; num2 < value3.同源属性.Count; num2++)
				{
					stringBuilder2 = stringBuilder17;
					StringBuilder stringBuilder19 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(9, 4, stringBuilder2);
					handler.AppendFormatted(全局常量类.同源颜色[(int)value3.同源属性[num2].同源成长]);
					handler.AppendFormatted(value3.同源属性[num2].同源成长);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(value3.同源属性[num2].成长数值);
					handler.AppendLiteral("/");
					handler.AppendFormatted(同源类型配置类3.同源成长);
					handler.AppendLiteral(" 增加#n#r");
					stringBuilder19.Append(ref handler);
				}
				stringBuilder2 = stringBuilder17;
				StringBuilder stringBuilder20 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(27, 3, stringBuilder2);
				handler.AppendLiteral("[【转属】同源转换属性(");
				handler.AppendFormatted(同源类型配置类3.转属价格);
				handler.AppendFormatted(同源类型配置类3.转属类型);
				handler.AppendLiteral(")/宠物操作_宠物同源_转属");
				handler.AppendFormatted(宠物缓存数据类3.IID);
				handler.AppendLiteral("]");
				stringBuilder20.Append(ref handler);
				stringBuilder2 = stringBuilder17;
				StringBuilder stringBuilder21 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(35, 1, stringBuilder2);
				handler.AppendLiteral("[【自动转属】出现3条以上相同属性停止/宠物操作_宠物同源_自动转属");
				handler.AppendFormatted(宠物缓存数据类3.IID);
				handler.AppendLiteral("]");
				stringBuilder21.Append(ref handler);
				stringBuilder2 = stringBuilder17;
				StringBuilder stringBuilder22 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(27, 3, stringBuilder2);
				handler.AppendLiteral("[【激活】同源属性激活(");
				handler.AppendFormatted(同源类型配置类3.激活价格);
				handler.AppendFormatted(同源类型配置类3.激活类型);
				handler.AppendLiteral(")/宠物操作_宠物同源_激活");
				handler.AppendFormatted(宠物缓存数据类3.IID);
				handler.AppendLiteral("]");
				stringBuilder22.Append(ref handler);
				stringBuilder2 = stringBuilder17;
				StringBuilder stringBuilder23 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(24, 1, stringBuilder2);
				handler.AppendLiteral("#r#M激活后额外获得所有成长+");
				handler.AppendFormatted(同源类型配置类3.激活成长);
				handler.AppendLiteral("的成长提升！！！");
				stringBuilder23.Append(ref handler);
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(102, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字, stringBuilder17.ToString()));
			}
			else if (P_1.Contains("宠物操作_宠物同源_自动转属", StringComparison.CurrentCulture))
			{
				bWCKemFDtS(P_0, P_1);
			}
			else if (P_1.Contains("宠物操作_宠物同源_激活", StringComparison.CurrentCulture))
			{
				niTKqaRfRK(P_0, P_1);
			}
			else if (P_1.Contains("宠物操作_宠物同源_停止转属", StringComparison.CurrentCulture))
			{
				P_0.user.缓存数据.is同源自动转属 = false;
			}
			else if (P_1.Contains("宠物操作_宠物同源_同源遗忘", StringComparison.CurrentCulture))
			{
				bXlKA9WPoT(P_0, P_1);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("宠物同源事件处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private async void bWCKemFDtS(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass24_0();
			CS_0024_003C_003E8__locals3.Y0cLICTugb = P_1.Replace("宠物操作_宠物同源_自动转属", "");
			宠物缓存数据类 当前宠物 = P_0.user.宠物数据.ToList().Find( (宠物缓存数据类 a) => !string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals3.Y0cLICTugb) && a.IID == CS_0024_003C_003E8__locals3.Y0cLICTugb);
			if (当前宠物 == null)
			{
				return;
			}
			StringBuilder 对话文本 = new StringBuilder();
			同源类型配置类 同源信息 = ugvKrDsvWP(当前宠物.类型);
			if (!Singleton<全局变量类>.I.宠物存档表.TryGetValue(当前宠物.IID, out var 同源数据))
			{
				return;
			}
			if (同源数据.is同源激活)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("同源#Y已激活#n,#R无法进行属性转换#n！"));
				return;
			}
			P_0.user.缓存数据.is同源自动转属 = true;
			StringBuilder stringBuilder;
			StringBuilder.AppendInterpolatedStringHandler handler;
			while (P_0.user.缓存数据.is同源自动转属)
			{
				对话文本.Clear();
				stringBuilder = 对话文本;
				StringBuilder stringBuilder2 = stringBuilder;
				handler = new StringBuilder.AppendInterpolatedStringHandler(19, 2, stringBuilder);
				handler.AppendLiteral("#G当前选择的宠物为：#Y");
				handler.AppendFormatted(当前宠物.昵称A);
				handler.AppendLiteral("（");
				handler.AppendFormatted(Singleton<AllEnums>.I.Get宠物类型(当前宠物.类型));
				handler.AppendLiteral("）#n#r");
				stringBuilder2.Append(ref handler);
				if (同源信息.转属类型 == AllEnums.数值Type.金元宝)
				{
					if (P_0.user.背包数据.金元宝 < 同源信息.转属价格)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R金元宝不足#n,无法继续操作！"));
						break;
					}
					if (!DB.I.cAJNoOkab6(P_0, -同源信息.转属价格, 0))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R金元宝不足#n,无法继续操作！"));
						break;
					}
				}
				else if (同源信息.转属类型 == AllEnums.数值Type.银元宝)
				{
					if (P_0.user.背包数据.银元宝 < 同源信息.转属价格)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R银元宝不足#n,无法继续操作！"));
						break;
					}
					if (!DB.I.cAJNoOkab6(P_0, 0, -同源信息.转属价格))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R银元宝不足#n,无法继续操作！"));
						break;
					}
				}
				else if (同源信息.转属类型 == AllEnums.数值Type.灵气值)
				{
					if (P_0.user.存档数据.数值存档.灵气值 < 同源信息.转属价格)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R灵气值不足#n,无法继续操作！"));
						break;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -同源信息.转属价格, false, "[门派转换]消耗");
				}
				同源数据.转属次数++;
				同源数据.同源属性 = WUHKZDBgLk(P_0.user.人物数据.昵称, 当前宠物.类型, 同源数据.转属次数, 同源信息.转属次数, 同源信息.同源成长);
				if ((from item in 同源数据.同源属性
					group item by item.同源成长 into @group
					where @group.Count() >= 3
					select new
					{
						同源成长 = @group.Key,
						Count = @group.Count()
					}).ToList().Count > 0)
				{
					break;
				}
				stringBuilder = 对话文本;
				StringBuilder stringBuilder3 = stringBuilder;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(当前宠物.昵称A);
				handler.AppendLiteral("#n当前同源属性：#r");
				stringBuilder3.Append(ref handler);
				for (int num = 0; num < 同源数据.同源属性.Count; num++)
				{
					stringBuilder = 对话文本;
					StringBuilder stringBuilder4 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(9, 4, stringBuilder);
					handler.AppendFormatted(全局常量类.同源颜色[(int)同源数据.同源属性[num].同源成长]);
					handler.AppendFormatted(同源数据.同源属性[num].同源成长);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(同源数据.同源属性[num].成长数值);
					handler.AppendLiteral("/");
					handler.AppendFormatted(同源信息.同源成长);
					handler.AppendLiteral(" 增加#n#r");
					stringBuilder4.Append(ref handler);
				}
				stringBuilder = 对话文本;
				StringBuilder stringBuilder5 = stringBuilder;
				handler = new StringBuilder.AppendInterpolatedStringHandler(24, 1, stringBuilder);
				handler.AppendLiteral("#r#M激活后额外获得所有成长+");
				handler.AppendFormatted(同源信息.激活成长);
				handler.AppendLiteral("的成长提升！！！");
				stringBuilder5.Append(ref handler);
				stringBuilder = 对话文本;
				StringBuilder stringBuilder6 = stringBuilder;
				handler = new StringBuilder.AppendInterpolatedStringHandler(31, 1, stringBuilder);
				handler.AppendLiteral("[【停止转属】取消自动转属操作/宠物操作_宠物同源_停止转属");
				handler.AppendFormatted(当前宠物.IID);
				handler.AppendLiteral("]");
				stringBuilder6.Append(ref handler);
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(102, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字, 对话文本.ToString()));
				await Task.Delay(100);
			}
			对话文本.Clear();
			stringBuilder = 对话文本;
			StringBuilder stringBuilder7 = stringBuilder;
			handler = new StringBuilder.AppendInterpolatedStringHandler(19, 2, stringBuilder);
			handler.AppendLiteral("#G当前选择的宠物为：#Y");
			handler.AppendFormatted(当前宠物.昵称A);
			handler.AppendLiteral("（");
			handler.AppendFormatted(Singleton<AllEnums>.I.Get宠物类型(当前宠物.类型));
			handler.AppendLiteral("）#n#r");
			stringBuilder7.Append(ref handler);
			stringBuilder = 对话文本;
			StringBuilder stringBuilder8 = stringBuilder;
			handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder);
			handler.AppendLiteral("#Y");
			handler.AppendFormatted(当前宠物.昵称A);
			handler.AppendLiteral("#n当前同源属性：#r");
			stringBuilder8.Append(ref handler);
			for (int num2 = 0; num2 < 同源数据.同源属性.Count; num2++)
			{
				stringBuilder = 对话文本;
				StringBuilder stringBuilder9 = stringBuilder;
				handler = new StringBuilder.AppendInterpolatedStringHandler(9, 4, stringBuilder);
				handler.AppendFormatted(全局常量类.同源颜色[(int)同源数据.同源属性[num2].同源成长]);
				handler.AppendFormatted(同源数据.同源属性[num2].同源成长);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(同源数据.同源属性[num2].成长数值);
				handler.AppendLiteral("/");
				handler.AppendFormatted(同源信息.同源成长);
				handler.AppendLiteral(" 增加#n#r");
				stringBuilder9.Append(ref handler);
			}
			stringBuilder = 对话文本;
			StringBuilder stringBuilder10 = stringBuilder;
			handler = new StringBuilder.AppendInterpolatedStringHandler(24, 1, stringBuilder);
			handler.AppendLiteral("#r#M激活后额外获得所有成长+");
			handler.AppendFormatted(同源信息.激活成长);
			handler.AppendLiteral("的成长提升！！！");
			stringBuilder10.Append(ref handler);
			stringBuilder = 对话文本;
			StringBuilder stringBuilder11 = stringBuilder;
			handler = new StringBuilder.AppendInterpolatedStringHandler(27, 3, stringBuilder);
			handler.AppendLiteral("[【转属】同源转换属性(");
			handler.AppendFormatted(同源信息.转属价格);
			handler.AppendFormatted(同源信息.转属类型);
			handler.AppendLiteral(")/宠物操作_宠物同源_转属");
			handler.AppendFormatted(当前宠物.IID);
			handler.AppendLiteral("]");
			stringBuilder11.Append(ref handler);
			stringBuilder = 对话文本;
			StringBuilder stringBuilder12 = stringBuilder;
			handler = new StringBuilder.AppendInterpolatedStringHandler(35, 1, stringBuilder);
			handler.AppendLiteral("[【自动转属】出现3条以上相同属性停止/宠物操作_宠物同源_自动转属");
			handler.AppendFormatted(当前宠物.IID);
			handler.AppendLiteral("]");
			stringBuilder12.Append(ref handler);
			stringBuilder = 对话文本;
			StringBuilder stringBuilder13 = stringBuilder;
			handler = new StringBuilder.AppendInterpolatedStringHandler(27, 3, stringBuilder);
			handler.AppendLiteral("[【激活】同源属性激活(");
			handler.AppendFormatted(同源信息.激活价格);
			handler.AppendFormatted(同源信息.激活类型);
			handler.AppendLiteral(")/宠物操作_宠物同源_激活");
			handler.AppendFormatted(当前宠物.IID);
			handler.AppendLiteral("]");
			stringBuilder13.Append(ref handler);
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(102, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字, 对话文本.ToString()));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("指定宠物自动同源操作-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private async Task niTKqaRfRK(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass25_0();
		if (P_0.user.缓存数据.endNpc点击时间 != DateTime.MinValue && (DateTime.Now - P_0.user.缓存数据.endNpc点击时间).TotalMilliseconds < 3000.0)
		{
			return;
		}
		P_0.user.缓存数据.endNpc点击时间 = DateTime.Now;
		CS_0024_003C_003E8__locals3.nTZLNKk07S = P_1.Replace("宠物操作_宠物同源_激活", "");
		宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.ToList().Find( (宠物缓存数据类 a) => !string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals3.nTZLNKk07S) && a.IID == CS_0024_003C_003E8__locals3.nTZLNKk07S);
		if (宠物缓存数据类2 == null || !Singleton<全局变量类>.I.宠物存档表.TryGetValue(宠物缓存数据类2.IID, out var 同源数据))
		{
			return;
		}
		if (同源数据.is同源激活)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("同源#Y已激活#n,#R无法进行属性转换#n！"));
			return;
		}
		new StringBuilder();
		同源类型配置类 同源信息 = ugvKrDsvWP(宠物缓存数据类2.类型);
		if (同源信息.激活类型 == AllEnums.数值Type.金元宝)
		{
			if (P_0.user.背包数据.金元宝 < 同源信息.激活价格)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R金元宝不足#n，无法激活同源属性！"));
				return;
			}
			if (!DB.I.cAJNoOkab6(P_0, -同源信息.激活价格, 0))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R金元宝不足#n，无法激活同源属性！"));
				return;
			}
		}
		else if (同源信息.激活类型 == AllEnums.数值Type.银元宝)
		{
			if (P_0.user.背包数据.银元宝 < 同源信息.激活价格)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R银元宝不足#n，无法激活同源属性！"));
				return;
			}
			if (!DB.I.cAJNoOkab6(P_0, 0, -同源信息.激活价格))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R银元宝不足#n，无法激活同源属性！"));
				return;
			}
		}
		else if (同源信息.激活类型 == AllEnums.数值Type.灵气值)
		{
			if (P_0.user.存档数据.数值存档.灵气值 < 同源信息.激活价格)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R灵气值不足#n，无法激活同源属性！"));
				return;
			}
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -同源信息.激活价格, false, "[激活同源]消耗");
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
		defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.PetID);
		defaultInterpolatedStringHandler.AppendLiteral(":\"");
		defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称B);
		string 宠物头 = defaultInterpolatedStringHandler.ToStringAndClear();
		int GID = P_0.user.人物数据.GID;
		string 账号 = P_0.user.人物数据.账号;
		WdAPI i = Singleton<WdAPI>.I;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 3);
		defaultInterpolatedStringHandler.AppendLiteral("#G你花费了#Y");
		defaultInterpolatedStringHandler.AppendFormatted(同源信息.激活价格);
		defaultInterpolatedStringHandler.AppendFormatted(同源信息.激活类型);
		defaultInterpolatedStringHandler.AppendLiteral("#G激活了#Y");
		defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
		defaultInterpolatedStringHandler.AppendLiteral("#G的同源属性，正在保存数据，10秒后您需重新登录游戏！");
		P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
		Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
		if (client频道事件 != null)
		{
			WdAPI i2 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(82, 12);
			defaultInterpolatedStringHandler.AppendLiteral("#24#Y恭喜#G");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("#Y为爱宠#R");
			defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
			defaultInterpolatedStringHandler.AppendLiteral("#Y激活了同源属性，获得了#L");
			defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[0].同源成长);
			defaultInterpolatedStringHandler.AppendLiteral("+");
			defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[0].成长数值);
			defaultInterpolatedStringHandler.AppendLiteral("、");
			defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[1].同源成长);
			defaultInterpolatedStringHandler.AppendLiteral("+");
			defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[1].成长数值);
			defaultInterpolatedStringHandler.AppendLiteral("、");
			defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[2].同源成长);
			defaultInterpolatedStringHandler.AppendLiteral("+");
			defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[2].成长数值);
			defaultInterpolatedStringHandler.AppendLiteral("、");
			defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[3].同源成长);
			defaultInterpolatedStringHandler.AppendLiteral("+");
			defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[3].成长数值);
			defaultInterpolatedStringHandler.AppendLiteral("#Y的成长提升，并且额外获得了#L所有成长+");
			defaultInterpolatedStringHandler.AppendFormatted(同源信息.激活成长);
			defaultInterpolatedStringHandler.AppendLiteral("#Y的奖励，快去天墉城找#P");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字);
			defaultInterpolatedStringHandler.AppendLiteral("#P进行同源吧！");
			client频道事件(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
		}
		Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
		if (!DB.I.锁定账号操作(账号, "1"))
		{
			Log.Error("激活宠物同源属性-错误：账号锁定失败");
			return;
		}
		await Task.Delay(5000);
		await DB.I.w5lNMH6DIt(宠物头, GID, 账号, 同源数据, 同源信息.激活成长);
		DB.I.锁定账号操作(账号, "0");
	}

	
	public 同源类型配置类 ugvKrDsvWP(byte P_0)
	{
		同源类型配置类 同源类型配置类2 = new 同源类型配置类();
		if (P_0 < 3)
		{
			同源类型配置类2.同源成长 = Singleton<全局变量类>.I.宠物同源配置.普通同源成长;
			同源类型配置类2.转属价格 = Singleton<全局变量类>.I.宠物同源配置.普通转属价格;
			同源类型配置类2.转属类型 = Singleton<全局变量类>.I.宠物同源配置.普通转属类型;
			同源类型配置类2.激活价格 = Singleton<全局变量类>.I.宠物同源配置.普通激活价格;
			同源类型配置类2.激活类型 = Singleton<全局变量类>.I.宠物同源配置.普通激活类型;
			同源类型配置类2.激活成长 = Singleton<全局变量类>.I.宠物同源配置.普通激活成长;
			同源类型配置类2.转属次数 = Singleton<全局变量类>.I.宠物同源配置.普通转属次数;
		}
		else
		{
			switch (P_0)
			{
			case 3:
				同源类型配置类2.同源成长 = Singleton<全局变量类>.I.宠物同源配置.变异同源成长;
				同源类型配置类2.转属价格 = Singleton<全局变量类>.I.宠物同源配置.变异转属价格;
				同源类型配置类2.转属类型 = Singleton<全局变量类>.I.宠物同源配置.变异转属类型;
				同源类型配置类2.激活价格 = Singleton<全局变量类>.I.宠物同源配置.变异激活价格;
				同源类型配置类2.激活类型 = Singleton<全局变量类>.I.宠物同源配置.变异激活类型;
				同源类型配置类2.激活成长 = Singleton<全局变量类>.I.宠物同源配置.变异激活成长;
				同源类型配置类2.转属次数 = Singleton<全局变量类>.I.宠物同源配置.变异转属次数;
				break;
			case 4:
				同源类型配置类2.同源成长 = Singleton<全局变量类>.I.宠物同源配置.神兽同源成长;
				同源类型配置类2.转属价格 = Singleton<全局变量类>.I.宠物同源配置.神兽转属价格;
				同源类型配置类2.转属类型 = Singleton<全局变量类>.I.宠物同源配置.神兽转属类型;
				同源类型配置类2.激活价格 = Singleton<全局变量类>.I.宠物同源配置.神兽激活价格;
				同源类型配置类2.激活类型 = Singleton<全局变量类>.I.宠物同源配置.神兽激活类型;
				同源类型配置类2.激活成长 = Singleton<全局变量类>.I.宠物同源配置.神兽激活成长;
				同源类型配置类2.转属次数 = Singleton<全局变量类>.I.宠物同源配置.神兽转属次数;
				break;
			case 10:
				同源类型配置类2.同源成长 = Singleton<全局变量类>.I.宠物同源配置.元灵同源成长;
				同源类型配置类2.转属价格 = Singleton<全局变量类>.I.宠物同源配置.元灵转属价格;
				同源类型配置类2.转属类型 = Singleton<全局变量类>.I.宠物同源配置.元灵转属类型;
				同源类型配置类2.激活价格 = Singleton<全局变量类>.I.宠物同源配置.元灵激活价格;
				同源类型配置类2.激活类型 = Singleton<全局变量类>.I.宠物同源配置.元灵激活类型;
				同源类型配置类2.激活成长 = Singleton<全局变量类>.I.宠物同源配置.元灵激活成长;
				同源类型配置类2.转属次数 = Singleton<全局变量类>.I.宠物同源配置.元灵转属次数;
				break;
			case 11:
				同源类型配置类2.同源成长 = Singleton<全局变量类>.I.宠物同源配置.仙元同源成长;
				同源类型配置类2.转属价格 = Singleton<全局变量类>.I.宠物同源配置.仙元转属价格;
				同源类型配置类2.转属类型 = Singleton<全局变量类>.I.宠物同源配置.仙元转属类型;
				同源类型配置类2.激活价格 = Singleton<全局变量类>.I.宠物同源配置.仙元激活价格;
				同源类型配置类2.激活类型 = Singleton<全局变量类>.I.宠物同源配置.仙元激活类型;
				同源类型配置类2.激活成长 = Singleton<全局变量类>.I.宠物同源配置.仙元激活成长;
				同源类型配置类2.转属次数 = Singleton<全局变量类>.I.宠物同源配置.仙元转属次数;
				break;
			default:
				同源类型配置类2.同源成长 = Singleton<全局变量类>.I.宠物同源配置.普通同源成长;
				同源类型配置类2.转属价格 = Singleton<全局变量类>.I.宠物同源配置.普通转属价格;
				同源类型配置类2.转属类型 = Singleton<全局变量类>.I.宠物同源配置.普通转属类型;
				同源类型配置类2.激活价格 = Singleton<全局变量类>.I.宠物同源配置.普通激活价格;
				同源类型配置类2.激活类型 = Singleton<全局变量类>.I.宠物同源配置.普通激活类型;
				同源类型配置类2.激活成长 = Singleton<全局变量类>.I.宠物同源配置.普通激活成长;
				同源类型配置类2.转属次数 = Singleton<全局变量类>.I.宠物同源配置.普通转属次数;
				break;
			}
		}
		return 同源类型配置类2;
	}

	
	private List<宠物同源数据类> WUHKZDBgLk(string P_0, byte P_1, int P_2, int P_3, int P_4)
	{
		List<宠物同源数据类> list = new List<宠物同源数据类>();
		bool flag = ("|" + Singleton<全局变量类>.I.宠物同源配置.托号角色 + "|").Contains("|" + P_0 + "|", StringComparison.CurrentCulture);
		AllEnums.宠物成长Type 宠物成长Type = (AllEnums.宠物成长Type)Singleton<WdAPI>.I.qrjo9TWIdy(1, 5);
		for (int i = 0; i < 4; i++)
		{
			宠物同源数据类 宠物同源数据类2 = new 宠物同源数据类();
			if (flag)
			{
				宠物同源数据类2.同源成长 = (Singleton<全局变量类>.I.宠物同源配置.托号成长类型一致 ? 宠物成长Type : ((AllEnums.宠物成长Type)Singleton<WdAPI>.I.qrjo9TWIdy(1, 5)));
				宠物同源数据类2.成长数值 = ((Singleton<全局变量类>.I.宠物同源配置.托号同源成长百分比 >= 100) ? P_4 : ((int)((float)P_4 / 100f * (float)Singleton<WdAPI>.I.qrjo9TWIdy(Singleton<全局变量类>.I.宠物同源配置.托号同源成长百分比 - 10, Singleton<全局变量类>.I.宠物同源配置.托号同源成长百分比))));
			}
			else
			{
				int num = (1 + P_4) / 2;
				宠物同源数据类2.成长数值 = Singleton<WdAPI>.I.qrjo9TWIdy(1, (P_2 < P_3) ? num : P_4);
				宠物同源数据类2.同源成长 = (AllEnums.宠物成长Type)Singleton<WdAPI>.I.qrjo9TWIdy(1, 5);
			}
			list.Add(宠物同源数据类2);
		}
		return list;
	}

	
	internal void FrdKteqgWr(MyNATSocketClient P_0, int P_1)
	{
		try
		{
			if (!Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, P_1))
			{
				return;
			}
			if (P_0.user.背包数据.物品列表[P_1].名字 != "同源遗忘丹")
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R使用物品有误！"));
				return;
			}
			StringBuilder stringBuilder = new StringBuilder("#G下列是激活过同源属性的宠物，请选择要遗忘同源成长的宠物：#n");
			for (int i = 0; i < P_0.user.宠物数据.Length; i++)
			{
				if (P_0.user.宠物数据[i].PetID != 0 && !string.IsNullOrWhiteSpace(P_0.user.宠物数据[i].IID) && Singleton<全局变量类>.I.宠物存档表.TryGetValue(P_0.user.宠物数据[i].IID, out var value) && value.is同源激活)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(30, 5, stringBuilder2);
					handler.AppendLiteral("[");
					handler.AppendFormatted(P_0.user.宠物数据[i].昵称A);
					handler.AppendLiteral("（");
					handler.AppendFormatted(P_0.user.宠物数据[i].昵称B);
					handler.AppendLiteral("）·");
					handler.AppendFormatted(P_0.user.宠物数据[i].等级);
					handler.AppendLiteral("级·已同源·已激活/宠物操作_宠物同源_同源遗忘");
					handler.AppendFormatted(P_0.user.宠物数据[i].IID);
					handler.AppendLiteral("_");
					handler.AppendFormatted(P_1);
					handler.AppendLiteral("]");
					stringBuilder2.Append(ref handler);
				}
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(102, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象, Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("同源遗忘丹使用处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private async Task bXlKA9WPoT(MyNATSocketClient P_0, string P_1)
	{
		_ = 1;
		try
		{
			_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass29_0();
			if (P_0.user.缓存数据.endNpc点击时间 != DateTime.MinValue && (DateTime.Now - P_0.user.缓存数据.endNpc点击时间).TotalMilliseconds < 3000.0)
			{
				return;
			}
			P_0.user.缓存数据.endNpc点击时间 = DateTime.Now;
			string[] array = P_1.Replace("宠物操作_宠物同源_同源遗忘", "").Split("_");
			if (array.Length != 2 || !int.TryParse(array[1], out var result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result) || P_0.user.背包数据.物品列表[result].名字 != "同源遗忘丹")
			{
				return;
			}
			CS_0024_003C_003E8__locals3.YfrLBDtw57 = array[0];
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.ToList().Find( (宠物缓存数据类 a) => !string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals3.YfrLBDtw57) && a.IID == CS_0024_003C_003E8__locals3.YfrLBDtw57);
			if (宠物缓存数据类2 != null && Singleton<全局变量类>.I.宠物存档表.TryGetValue(宠物缓存数据类2.IID, out var 同源数据) && 同源数据.is同源激活)
			{
				P_0.S_Send(Singleton<WdAPI>.I.naeodnd6MY(result));
				同源类型配置类 同源信息 = ugvKrDsvWP(宠物缓存数据类2.类型);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.PetID);
				defaultInterpolatedStringHandler.AppendLiteral(":\"");
				defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称B);
				string 宠物头 = defaultInterpolatedStringHandler.ToStringAndClear();
				int GID = P_0.user.人物数据.GID;
				string 账号 = P_0.user.人物数据.账号;
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 9);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#G正在遗忘同源属性#L");
				defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[0].同源成长 + 同源信息.激活成长);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[0].成长数值 + 同源信息.激活成长);
				defaultInterpolatedStringHandler.AppendLiteral("、");
				defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[1].同源成长);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[1].成长数值 + 同源信息.激活成长);
				defaultInterpolatedStringHandler.AppendLiteral("、");
				defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[2].同源成长);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[2].成长数值 + 同源信息.激活成长);
				defaultInterpolatedStringHandler.AppendLiteral("、");
				defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[3].同源成长);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted(同源数据.同源属性[3].成长数值 + 同源信息.激活成长);
				defaultInterpolatedStringHandler.AppendLiteral("#n，10秒后您需重新登录游戏！");
				P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
				if (!DB.I.锁定账号操作(账号, "1"))
				{
					Log.Error("指定宠物遗忘同源操作-错误：账号锁定失败");
					return;
				}
				await Task.Delay(5000);
				await DB.I.OvlNheWUZG(宠物头, GID, 账号, 同源数据, 同源信息.激活成长);
				DB.I.锁定账号操作(账号, "0");
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("指定宠物遗忘同源操作-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public FoohJvKhxbMTfceeiIF()
	{
		PDlKzCqrLv = Array.Empty<byte>();
	}

	static FoohJvKhxbMTfceeiIF()
	{
	}
}
