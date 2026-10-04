using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AM5rMIgHdrOR1f8tXCQ;
using B6XRmUwQK7iatdTWLwc;
using KEvDjBdeoLOoBKWXFAH;
using P80h4IDRZbpvERvsoap;
using PB0xx2KvGeQt7ty6y1C;
using Serilog;
using SuTsFOBHSZNdBh5bUZB;
using UbblDNG1yFpxk6Q0ui4;
using VcF0pbBvJqp0x0IfwN;
using aSItGBlifY3VT2BvkBH;
using eYLrotRIovAGM9lAtVf;
using ixYEhcwWIdwrtDxOO94;
using sVcPYnW2a67ob5mDj4x;
using uI75fJjR7A2e7wWdq9f;
using xqlPMM2TJRNXpZnNDFn;
using zA970iRwZCxW0g6uljn;

namespace vBIs2Rf2vSSk1OdhoS7;

internal class COyX27f6L3uCF3F6Kp5 : Singleton<COyX27f6L3uCF3F6Kp5>
{
	internal static AllEnums.元神境界 ResolveEquipmentRealmRequirement(物品信息类 item)
	{
		if (item.穿戴要求 != AllEnums.元神境界.凡人境)
		{
			return item.穿戴要求;
		}

		string equipmentText = $"{item.前缀}{item.名字}";
		foreach (AllEnums.元神境界 realm in Enum.GetValues<AllEnums.元神境界>().OrderByDescending(x => (int)x))
		{
			if (realm != AllEnums.元神境界.凡人境 && equipmentText.Contains(realm.ToString(), StringComparison.Ordinal))
			{
				return realm;
			}
		}

		if (item.最大耐久度 > 100000 && item.最大耐久度 <= 200000)
		{
			return (AllEnums.元神境界)((item.最大耐久度 - 100000) / 10000);
		}

		return item.穿戴要求;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public short nlOTZOVjlE;

		public Func<int, bool> t6JTtFOGu4;

		
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		
		internal bool TJiTr6Bm2h(int x)
		{
			return x == nlOTZOVjlE;
		}

		static _003C_003Ec__DisplayClass10_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public short gsqTzXcljJ;

		public Func<int, bool> MGk9unTgsV;

		
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		
		internal bool dm4TAcfXrb(int x)
		{
			return x == gsqTzXcljJ;
		}

		static _003C_003Ec__DisplayClass11_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public short k5N9bI3R5a;

		public Func<int, bool> XXC9JR4d4a;

		
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		
		internal bool sFY9wOCdHO(int x)
		{
			return x == k5N9bI3R5a;
		}

		static _003C_003Ec__DisplayClass13_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public int Voh9RyYpdV;

		
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		
		internal bool Vur9KmD7iV(宠物缓存数据类 a)
		{
			return a.宠物ID == Voh9RyYpdV;
		}

		static _003C_003Ec__DisplayClass15_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public int U7p9sQcpbA;

		
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		
		internal bool aTY9d4sesm(宠物缓存数据类 a)
		{
			return a.宠物ID == U7p9sQcpbA;
		}

		static _003C_003Ec__DisplayClass16_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public string gL79gUD8v7;

		public Func<召唤精怪列表类, bool> Y5u9DFns2N;

		
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		
		internal bool yRR9USOQQ9(List<召唤精怪列表类> x1)
		{
			return x1.Any( (召唤精怪列表类 召唤精怪列表类2) => 召唤精怪列表类2.礼包名字 == gL79gUD8v7);
		}

		
		internal bool Fy49WdcfiN(召唤精怪列表类 x2)
		{
			return x2.礼包名字 == gL79gUD8v7;
		}

		static _003C_003Ec__DisplayClass2_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public short b099lUmkma;

		public Func<int, bool> iWK988f2ew;

		
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		
		internal bool Xu69jRCDJ5(int x)
		{
			return x == b099lUmkma;
		}

		static _003C_003Ec__DisplayClass4_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public short nFr9osCONk;

		public Func<int, bool> IpS9NaAPVD;

		
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		
		internal bool su19ImdKcq(int x)
		{
			return x == nFr9osCONk;
		}

		static _003C_003Ec__DisplayClass5_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public 物品信息类 Ms99GyNg1y;

		public Func<召唤精怪列表类, bool> VYR9fxc06o;

		
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		
		internal bool A4c9iytrT3(List<召唤精怪列表类> x)
		{
			return x.Any( (召唤精怪列表类 y) => y.礼包名字 == Ms99GyNg1y.名字);
		}

		
		internal bool IFr9BCWgEu(召唤精怪列表类 y)
		{
			return y.礼包名字 == Ms99GyNg1y.名字;
		}

		static _003C_003Ec__DisplayClass6_0()
		{
		}
	}

	
	[SpecialName]
	public static bool nZify3Mg0F()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.IsVip)
		{
			return Singleton<全局变量类>.I.config.Is绑定秒解;
		}
		return false;
	}

	
	internal byte[] mb2fmTGBvK(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals38 = new _003C_003Ec__DisplayClass2_0();
			if (P_1.Length != 13 || !P_0.当前client.Online)
			{
				return P_1;
			}
			int num = Singleton<ByteAPI>.I.取字节集数据(P_1, 1, 12);
			if (num > 200 || num < 1)
			{
				return P_1;
			}
			if (P_0.user.背包数据.物品列表[num] == null)
			{
				return null;
			}
			if (string.IsNullOrWhiteSpace(P_0.user.背包数据.物品列表[num].名字))
			{
				return null;
			}
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num).Concat(Singleton<WdAPI>.I.提示_中心提醒("使用仙灵卡期间不能使用道具。")).ToArray());
				return null;
			}
			if (!string.IsNullOrWhiteSpace(P_0.user.缓存数据.自选道具))
			{
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num).Concat(Singleton<WdAPI>.I.提示_中心提醒("使用自选道具期间无法进行其他操作，异常会导致封号处理！")).ToArray());
				return null;
			}
			CS_0024_003C_003E8__locals38.gL79gUD8v7 = P_0.user.背包数据.物品列表[num].名字;
			if (Singleton<全局变量类>.I.超级道具配置.功能开关 && Singleton<ByteAPI>.I.寻找文本("|" + Singleton<全局变量类>.I.超级道具配置.禁止使用道具 + "|", "|" + CS_0024_003C_003E8__locals38.gL79gUD8v7 + "|"))
			{
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num).Concat(Singleton<WdAPI>.I.提示_中心提醒("该物品无法使用。")).ToArray());
				return null;
			}
			if (CS_0024_003C_003E8__locals38.gL79gUD8v7 == "道具套餐卡" || CS_0024_003C_003E8__locals38.gL79gUD8v7 == "会员卡" || CS_0024_003C_003E8__locals38.gL79gUD8v7 == "高级道具套餐卡")
			{
				if (!Singleton<WdAPI>.I.dWOoi046qt(200, ref P_0.user.缓存数据.end道具使用时间))
				{
					P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num));
					return null;
				}
				if (P_0.user.缓存数据.当前会员天数 >= 3900)
				{
					P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num).Concat(Singleton<WdAPI>.I.提示_中心提醒("#R当前位列仙班的天数已经达到上限，无法继续使用。")).ToArray());
					return null;
				}
			}
			if (Singleton<全局变量类>.I.超级道具配置.使用校验道具.Contains("|" + CS_0024_003C_003E8__locals38.gL79gUD8v7 + "|", StringComparison.CurrentCulture) && !Singleton<WdAPI>.I.wfboRXZawH(P_0, num))
			{
				return null;
			}
			if (CS_0024_003C_003E8__locals38.gL79gUD8v7 == "同源遗忘丹")
			{
				if (!Singleton<WdAPI>.I.wfboRXZawH(P_0, num))
				{
					return null;
				}
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num));
				Singleton<FoohJvKhxbMTfceeiIF>.I.FrdKteqgWr(P_0, num);
				return null;
			}
			if (zeYnwTjKgpmAbfSQh5J.OeqjXVCekN())
			{
				if (!Singleton<WdAPI>.I.wfboRXZawH(P_0, num))
				{
					return null;
				}
				if (CS_0024_003C_003E8__locals38.gL79gUD8v7 == "天降石")
				{
					byte[] first = Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num);
					WdAPI i = Singleton<WdAPI>.I;
					int 角色ID = P_0.user.人物数据.角色ID;
					int 形象ID = P_0.user.人物数据.形象ID;
					string 昵称 = P_0.user.人物数据.昵称;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[@/$*天降石提交_");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("|请提交等级要降为#R1#n级的天书,1,0]\r\n");
					P_0.C_Send(first.Concat(i.组包提交物品框(角色ID, 形象ID, 昵称, defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
					return null;
				}
				if (CS_0024_003C_003E8__locals38.gL79gUD8v7 == "法宝亲密互换石")
				{
					byte[] first2 = Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num);
					WdAPI i2 = Singleton<WdAPI>.I;
					int 角色ID2 = P_0.user.人物数据.角色ID;
					int 形象ID2 = P_0.user.人物数据.形象ID;
					string 昵称2 = P_0.user.人物数据.昵称;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[@/$*法宝亲密互换石提交_");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("|请提交要交换亲密的#R2#n个法宝,2,0]\r\n");
					P_0.C_Send(first2.Concat(i2.组包提交物品框(角色ID2, 形象ID2, 昵称2, defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
					return null;
				}
				if (CS_0024_003C_003E8__locals38.gL79gUD8v7 == "装备男女转换玉")
				{
					byte[] first3 = Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num);
					WdAPI i3 = Singleton<WdAPI>.I;
					int 角色ID3 = P_0.user.人物数据.角色ID;
					int 形象ID3 = P_0.user.人物数据.形象ID;
					string 昵称3 = P_0.user.人物数据.昵称;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[@/$*装备男女转换玉提交_");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("|请提交要改变性别的装备,1,0]\r\n");
					P_0.C_Send(first3.Concat(i3.组包提交物品框(角色ID3, 形象ID3, 昵称3, defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
					return null;
				}
				if (CS_0024_003C_003E8__locals38.gL79gUD8v7 == "武学互换丹")
				{
					P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num));
					Singleton<zeYnwTjKgpmAbfSQh5J>.I.PGujG4xR2Z(P_0, num);
					return null;
				}
				if (CS_0024_003C_003E8__locals38.gL79gUD8v7 == "宠物亲密互换丹")
				{
					P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num));
					Singleton<zeYnwTjKgpmAbfSQh5J>.I.w4Kj6Kin0K(P_0, num);
					return null;
				}
			}
			if (Singleton<全局变量类>.I.属性洗炼配置.功能开关 && ((Singleton<全局变量类>.I.属性洗炼配置.时装配置.功能开关 && Singleton<全局变量类>.I.属性洗炼配置.时装配置.洗炼道具名字 == CS_0024_003C_003E8__locals38.gL79gUD8v7) || (Singleton<全局变量类>.I.属性洗炼配置.法宝配置.功能开关 && Singleton<全局变量类>.I.属性洗炼配置.法宝配置.洗炼道具名字 == CS_0024_003C_003E8__locals38.gL79gUD8v7) || (Singleton<全局变量类>.I.属性洗炼配置.梭子配置.功能开关 && Singleton<全局变量类>.I.属性洗炼配置.梭子配置.洗炼道具名字 == CS_0024_003C_003E8__locals38.gL79gUD8v7) || (Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.功能开关 && Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.洗炼道具名字 == CS_0024_003C_003E8__locals38.gL79gUD8v7) || (Singleton<全局变量类>.I.属性洗炼配置.仙器配置.功能开关 && Singleton<全局变量类>.I.属性洗炼配置.仙器配置.洗炼道具名字 == CS_0024_003C_003E8__locals38.gL79gUD8v7) || (Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.功能开关 && Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.洗炼道具名字 == CS_0024_003C_003E8__locals38.gL79gUD8v7)))
			{
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num).Concat(Singleton<WdAPI>.I.提示_中心提醒("该物品无法使用。")).ToArray());
				return null;
			}
			if (Singleton<全局变量类>.I.宠物召唤配置.功能开关)
			{
				if (Singleton<全局变量类>.I.宠物召唤配置.is变异召唤 && CS_0024_003C_003E8__locals38.gL79gUD8v7 == Singleton<全局变量类>.I.宠物召唤配置.变异材料)
				{
					P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num).Concat(Singleton<WdAPI>.I.提示_中心提醒("该物品无法使用,请提交至#Y" + Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字 + "#n。")).ToArray());
					return null;
				}
				if (Singleton<全局变量类>.I.宠物召唤配置.is神兽召唤 && CS_0024_003C_003E8__locals38.gL79gUD8v7 == Singleton<全局变量类>.I.宠物召唤配置.神兽材料)
				{
					P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num).Concat(Singleton<WdAPI>.I.提示_中心提醒("该物品无法使用,请提交至#Y" + Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字 + "#n。")).ToArray());
					return null;
				}
				if (Singleton<全局变量类>.I.宠物召唤配置.is元灵召唤 && CS_0024_003C_003E8__locals38.gL79gUD8v7 == Singleton<全局变量类>.I.宠物召唤配置.元灵材料)
				{
					P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num).Concat(Singleton<WdAPI>.I.提示_中心提醒("该物品无法使用,请提交至#Y" + Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字 + "#n。")).ToArray());
					return null;
				}
				if (Singleton<全局变量类>.I.宠物召唤配置.is仙元召唤 && CS_0024_003C_003E8__locals38.gL79gUD8v7 == Singleton<全局变量类>.I.宠物召唤配置.仙元材料)
				{
					P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num).Concat(Singleton<WdAPI>.I.提示_中心提醒("该物品无法使用,请提交至#Y" + Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字 + "#n。")).ToArray());
					return null;
				}
				if (Singleton<全局变量类>.I.宠物召唤配置.is御灵召唤 && CS_0024_003C_003E8__locals38.gL79gUD8v7 == Singleton<全局变量类>.I.宠物召唤配置.御灵材料)
				{
					P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num).Concat(Singleton<WdAPI>.I.提示_中心提醒("该物品无法使用,请提交至#Y" + Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字 + "#n。")).ToArray());
					return null;
				}
			}
			if (Singleton<全局变量类>.I.宠物绑定配置.功能开关 && Singleton<全局变量类>.I.宠物绑定配置.道具宠物绑定列表.ContainsKey(CS_0024_003C_003E8__locals38.gL79gUD8v7))
			{
				P_0.user.缓存数据.宠物绑定道具 = CS_0024_003C_003E8__locals38.gL79gUD8v7;
				return P_1;
			}
			if (浮生录功能.GrAWb1KahR())
			{
				if (Singleton<全局变量类>.I.浮生录配置.化身列表.ContainsKey(CS_0024_003C_003E8__locals38.gL79gUD8v7) || CS_0024_003C_003E8__locals38.gL79gUD8v7 == Singleton<全局变量类>.I.浮生录配置.道具名字)
				{
					P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num).Concat(Singleton<WdAPI>.I.提示_中心提醒("该物品无法使用。")).ToArray());
					return null;
				}
				if (CS_0024_003C_003E8__locals38.gL79gUD8v7 == Singleton<全局变量类>.I.浮生录配置.特效道具)
				{
					P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num));
					WdAPI i4 = Singleton<WdAPI>.I;
					int npc形象 = Singleton<全局变量类>.I.浮生录配置.NPC数据.npc形象;
					string npc名字 = Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 2);
					defaultInterpolatedStringHandler.AppendLiteral("[@确定/浮生录_使用特效道具");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要使用#Y");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals38.gL79gUD8v7);
					defaultInterpolatedStringHandler.AppendLiteral("#n激活全部的浮生化身吗？]");
					P_0.C_Send(i4.组包确定框(104, npc形象, npc名字, defaultInterpolatedStringHandler.ToStringAndClear()));
					return null;
				}
			}
			if (iRGieud4qtscW6ESmxk.wGmslE7YU3() && CS_0024_003C_003E8__locals38.gL79gUD8v7 == Singleton<全局变量类>.I.异兽录配置.特效道具)
			{
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num));
				WdAPI i5 = Singleton<WdAPI>.I;
				int npc形象2 = Singleton<全局变量类>.I.异兽录配置.NPC数据.npc形象;
				string npc名字2 = Singleton<全局变量类>.I.异兽录配置.NPC数据.npc名字;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(63, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[@确定/异兽录操作_使用特效道具");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要使用#Y");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals38.gL79gUD8v7);
				defaultInterpolatedStringHandler.AppendLiteral("#n自动收录所有剩余未收录的异兽录宠物吗#n？]");
				P_0.C_Send(i5.组包确定框(103, npc形象2, npc名字2, defaultInterpolatedStringHandler.ToStringAndClear()));
				return null;
			}
			if (MbtVicwUkp5LuxTooFW.c5PwXOYtHf() && !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.六道轮回配置.特效道具) && CS_0024_003C_003E8__locals38.gL79gUD8v7 == Singleton<全局变量类>.I.六道轮回配置.特效道具)
			{
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num));
				WdAPI i6 = Singleton<WdAPI>.I;
				int 角色ID4 = P_0.user.人物数据.角色ID;
				int 形象ID4 = P_0.user.人物数据.形象ID;
				string 昵称4 = P_0.user.人物数据.昵称;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(76, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[@确定/轮回操作_使用特效道具");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要使用#Y");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals38.gL79gUD8v7);
				defaultInterpolatedStringHandler.AppendLiteral("#n自动转世剩余的所有的六道轮回并且激活每个轮回的最大所有相性属性吗#n？]");
				P_0.C_Send(i6.组包确定框(角色ID4, 形象ID4, 昵称4, defaultInterpolatedStringHandler.ToStringAndClear()));
				return null;
			}
			if (CS_0024_003C_003E8__locals38.gL79gUD8v7 == "五系娃娃召唤令" && P_0.user.娃娃数据.All( (娃娃缓存数据类 x) => x.娃娃ID != 0))
			{
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num).Concat(Singleton<WdAPI>.I.提示_中心提醒("当前娃娃数量已经满了。")).ToArray());
				return null;
			}
			if (Singleton<全局变量类>.I.超级道具配置.功能开关 && Singleton<全局变量类>.I.超级道具配置.超级道具列表.TryGetValue(CS_0024_003C_003E8__locals38.gL79gUD8v7, out 超级道具列表配置类 value))
			{
				if (!Singleton<WdAPI>.I.dWOoi046qt(200, ref P_0.user.缓存数据.end道具使用时间))
				{
					P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num));
					return null;
				}
				bool flag = false;
				lock (P_0.使用道具锁)
				{
					flag = Singleton<zeYnwTjKgpmAbfSQh5J>.I.GUyjgbITgP(P_0, value);
				}
				if (!flag)
				{
					P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num));
					return null;
				}
				return P_1;
			}
			if (FcVoHRwOVsflDmDUQOP.JhVwZ5yCsf() && Singleton<全局变量类>.I.召唤精怪配置.召唤列表.Values.Any( (List<召唤精怪列表类> x1) => x1.Any( (召唤精怪列表类 召唤精怪列表类2) => 召唤精怪列表类2.礼包名字 == CS_0024_003C_003E8__locals38.gL79gUD8v7)) && !Singleton<WdAPI>.I.dSCoKmGWP9(P_0))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的宠物栏已满，无法使用#R" + CS_0024_003C_003E8__locals38.gL79gUD8v7 + "#n！").Concat(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num)).ToArray());
				return null;
			}
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && Singleton<ByteAPI>.I.寻找文本(Ab7Ypu2aCcHMcLPG8Um.IkymDsp1jm.ToString(), "|" + CS_0024_003C_003E8__locals38.gL79gUD8v7 + "|"))
			{
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num));
				Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.KOq2ZTLen8(P_0, num);
				return null;
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("物品使用请求处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal byte[] zrBfPuUeNu(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			lock (P_0.自选取消锁)
			{
				if (!string.IsNullOrWhiteSpace(P_0.user.缓存数据.自选道具))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R使用自选礼包期间无法进行背包格子移动！"));
					return null;
				}
			}
			if (P_1.Length < 14)
			{
				return P_1;
			}
			byte b = P_1[12];
			byte b2 = P_1[13];
			if (!Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, b) || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, b2))
			{
				return P_1;
			}
			if (P_0.user.背包数据.物品列表[b] == null || P_0.user.背包数据.物品列表[b2] == null)
			{
				return P_1;
			}
			if (string.IsNullOrWhiteSpace(P_0.user.背包数据.物品列表[b].名字) || string.IsNullOrWhiteSpace(P_0.user.背包数据.物品列表[b2].名字))
			{
				return P_1;
			}
			if (Singleton<zeYnwTjKgpmAbfSQh5J>.I.C2fjIBxJ1T(P_0, b, b2))
			{
				return null;
			}
			if (Singleton<zeYnwTjKgpmAbfSQh5J>.I.YJojoSHagW(P_0, b, b2))
			{
				return null;
			}
			if (Singleton<cCs7kYlNIp7pmjCmEml>.I.eXol2FJiY5(P_0, b, b2))
			{
				return null;
			}
			if (Singleton<cCs7kYlNIp7pmjCmEml>.I.blRlXF7Xxl(P_0, b, b2))
			{
				return null;
			}
			if (Singleton<pN4kvFDKqDQRQBnO8BW>.I.b7SDIC3yUQ(P_0, b, b2))
			{
				return null;
			}
			if (Singleton<rZ9xAdgxKYQQZPeE8Rm>.I.QADgAuyiPE(P_0, b, b2))
			{
				return null;
			}
			if (Singleton<TOqsYfW68LIGjCtAgK8>.I.TJ8WLEtvx7(P_0, b, b2))
			{
				return null;
			}
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.tCU2t0Ktbn(P_0, b, b2))
			{
				return null;
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("请求_格子交换-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal async Task LBUfXfFKUF(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass4_0();
			_ = string.Empty;
			CS_0024_003C_003E8__locals6.b099lUmkma = 0;
			Array.Empty<byte>();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
			short num = 封包_读2.读短整数型(reverse: true);
			封包_写2.写短整数型(num, reverse: true);
			short num2 = 0;
			封包_写 封包_写3 = new 封包_写();
			物品信息类 物品信息类2 = null;
			for (int i = 0; i < num; i++)
			{
				int num3 = 封包_读2.读字节型();
				short num4 = 封包_读2.读短整数型(reverse: true);
				if (num3 > 0 && num3 <= 180)
				{
					物品信息类2 = P_0.user.背包数据.物品列表[num3];
				}
				if (物品信息类2 != null)
				{
					物品信息类2.C7n8ZR5IQ0(num3);
				}
				else
				{
					物品信息类2 = new 物品信息类
					{
						Index = num3
					};
				}
				封包_写3.清数据();
				封包_写3.写短整数型(num4, reverse: true);
				for (int j = 0; j < num4; j++)
				{
					CS_0024_003C_003E8__locals6.b099lUmkma = 封包_读2.读短整数型(reverse: true);
					封包_写3.写短整数型(CS_0024_003C_003E8__locals6.b099lUmkma, reverse: true);
					short num5 = 封包_读2.读短整数型(reverse: true);
					封包_写3.写短整数型(num5, reverse: true);
					for (int k = 0; k < num5; k++)
					{
						byte[] array = 封包_读2.读字节集(2);
						short 属性标识 = Singleton<ByteAPI>.I.反转_短整数(array);
						封包_写3.写字节集(array, hasCount: false, 0);
						int num6 = 封包_读2.读字节型();
						封包_写3.写字节型(num6);
						_ = string.Empty;
						int 属性数值 = 0;
						switch (num6)
						{
						case 1:
						{
							int num8 = 封包_读2.读字节型();
							属性数值 = num8;
							if (Enumerable.SequenceEqual(array, new byte[2] { 1, 177 }))
							{
								物品信息类2.装备已进化次数 = num8;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 151 }))
							{
								物品信息类2.是否绑定 = num8 >= 3;
								物品信息类2.绑定状态 = ((num8 != 3 && num8 != 4) ? AllEnums.绑定Type.不绑定 : ((num8 == 4) ? AllEnums.绑定Type.死绑 : AllEnums.绑定Type.红绑));
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 29 }))
							{
								物品信息类2.性别 = num8;
							}
							封包_写3.写字节型(num8);
							break;
						}
						case 2:
						{
							short num7 = 封包_读2.读短整数型(reverse: true);
							属性数值 = num7;
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 203 }))
							{
								物品信息类2.数量 = num7;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 136 }))
							{
								物品信息类2.奇术技能增加 = num7;
							}
							封包_写3.写短整数型(num7, reverse: true);
							break;
						}
						case 3:
						{
							int num9 = 封包_读2.读整数型(reverse: true);
							属性数值 = num9;
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 84 }))
							{
								物品信息类2.物品ID = num9;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 81 }))
							{
								物品信息类2.首饰可转换次数 = num9;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 71 }))
							{
								物品信息类2.首饰已转换次数 = num9;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 6 }) && num9 == 999)
							{
								num9 = 0;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 7 }))
							{
								物品信息类2.绑定气血 = num9;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 10 }))
							{
								物品信息类2.装备天伤 = num9;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 12 }))
							{
								物品信息类2.绑定法力 = num9;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 40 }))
							{
								物品信息类2.图标 = num9;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 42 }))
							{
								物品信息类2.当前耐久度 = num9;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 43 }))
							{
								物品信息类2.最大耐久度 = num9;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 137 }))
							{
								物品信息类2.当前炼魂值 = num9;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 138 }))
							{
								物品信息类2.最大炼魂值 = num9;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 207 }))
							{
								物品信息类2.售出价格 = num9;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 240 }))
							{
								物品信息类2.亲密度 = num9;
							}
							else if (!Enumerable.SequenceEqual(array, new byte[2] { 0, 206 }) && Enumerable.SequenceEqual(array, new byte[2] { 0, 208 }))
							{
								物品信息类2.改造等级 = num9;
							}
							封包_写3.写整数型(num9, reverse: true);
							break;
						}
						case 4:
						{
							string text = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 1 }))
							{
								if (CS_0024_003C_003E8__locals6.b099lUmkma == 1)
								{
									物品信息类2.名字 = text;
									if (版本相关处理.Is巅峰对决)
									{
										物品信息类2.前缀 = ((text.Length > Singleton<全局变量类>.I.config.前缀长度) ? Singleton<ByteAPI>.I.取文本左边(text, Singleton<全局变量类>.I.config.前缀长度) : string.Empty);
									}
									else if (Singleton<全局变量类>.I.元神系统配置.功能开关)
									{
										物品信息类2.前缀 = ((text.Length > 4) ? Singleton<ByteAPI>.I.取文本左边(text, 4) : string.Empty);
										物品信息类2.穿戴要求 = AllEnums.元神境界.凡人境;
										if (物品信息类2.前缀.EndsWith("★"))
										{
											Enum.TryParse<AllEnums.元神境界>(物品信息类2.前缀.Replace("★", string.Empty), out 物品信息类2.穿戴要求);
										}
									}
									else
									{
										物品信息类2.前缀 = string.Empty;
									}
									if (num3 == 31)
									{
										P_0.user.缓存数据.穿戴时装名 = text;
									}
								}
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 55 }))
							{
								物品信息类2.单位 = text;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 8 }))
							{
								物品信息类2.描述 = text;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 89 }))
							{
								物品信息类2.改造人 = text;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 209 }))
							{
								物品信息类2.物品颜色 = text;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 65 }))
							{
								物品信息类2.别名 = text;
							}
							封包_写3.写文本型(text, hasCount: true, 0, reverse: true);
							break;
						}
						case 6:
						{
							int num8 = 封包_读2.读字节型();
							属性数值 = num8;
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 202 }))
							{
								物品信息类2.物品类型 = (byte)num8;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 205 }))
							{
								物品信息类2.等级 = (byte)num8;
							}
							封包_写3.写字节型(num8);
							break;
						}
						case 7:
						{
							short num7 = 封包_读2.读短整数型(reverse: true);
							属性数值 = num7;
							封包_写3.写短整数型(num7, reverse: true);
							break;
						}
						}
						if (全局常量类.属性类别组.Any( (int x) => x == CS_0024_003C_003E8__locals6.b099lUmkma))
						{
							物品信息类2.装备属性列表.Add(new 属性数据
							{
								属性类别 = CS_0024_003C_003E8__locals6.b099lUmkma,
								属性标识 = 属性标识,
								属性数值 = 属性数值
							});
						}
					}
				}
				if (fuMNpgieFTYU3Wah53.BojPVlpN4() && 物品信息类2.物品ID != 0)
				{
					if (num3 == 8)
					{
						P_0.user.缓存数据.Is首次穿戴梭子 = 0;
						num2++;
						封包_写3.清数据();
						continue;
					}
					if (Singleton<ByteAPI>.I.寻找文本等(物品信息类2.名字, "梦荷", "御天梭", "御魂·轩辕神剑", "御魂·九天玄龟", "御魂·霸天玉瑶", "御魂·孔雀翎"))
					{
						if (P_0.user.缓存数据.Is首次穿戴梭子 == 0)
						{
							物品信息类2.物品ID = 0;
							Singleton<WdAPI>.I.iaDIkvl1cj(P_0, num3);
						}
						else if (P_0.user.缓存数据.Is首次穿戴梭子 == 1 && 物品信息类2.名字 == "御天梭")
						{
							P_0.user.缓存数据.Is首次穿戴梭子 = 2;
							Singleton<fuMNpgieFTYU3Wah53>.I.rPGGaUKqN(P_0, num3);
						}
						else if (P_0.user.缓存数据.Is首次穿戴梭子 == 2 && 物品信息类2.名字 == "御天梭")
						{
							P_0.user.缓存数据.Is首次穿戴梭子 = 3;
							P_0.S_Send(Singleton<WdAPI>.I.FUioW2lnt4(num3, 8));
						}
						num2++;
						封包_写3.清数据();
						continue;
					}
				}
				if (pN4kvFDKqDQRQBnO8BW.wATDfrQwrg())
				{
					P_0.拆卸回调事件?.Invoke(num3, 物品信息类2.名字);
				}
				if (Singleton<全局变量类>.I.超级道具配置.功能开关 && !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.超级道具配置.自动绑定道具) && Singleton<ByteAPI>.I.寻找文本(Singleton<全局变量类>.I.超级道具配置.自动绑定道具, "|" + 物品信息类2.名字 + "|") && !物品信息类2.是否绑定)
				{
					Singleton<WdAPI>.I.Mr8ICwW3qX(P_0, num3, "property_bind/attrib", "4");
				}
				物品信息类2.rgh8r0QQvs(P_0);
				if (rCpfLKhKrZ(P_0, 物品信息类2))
				{
					物品信息类2.封包缓存 = 封包_写3.取数据();
					封包_写3.清数据();
					封包_写3.写入数据(KDQfSpe9nM(P_0, 物品信息类2.封包缓存, 物品信息类2), hasCount: false, 0);
				}
				物品信息类2.封包缓存 = 封包_写3.取数据();
				封包_写2.写字节型(num3);
				封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
				P_0.超级进化事件?.Invoke(num3);
			}
			Singleton<版本相关处理>.I.巅峰对决读取穿戴(P_0);
			P_0.user.缓存数据.Is自动使用道具 = P_0.user.背包数据.物品列表.Any( (物品信息类 x) => x.Index != 0 && x.物品ID != 0 && ("|" + Singleton<全局变量类>.I.超级道具配置.自动使用道具 + "|").Contains("|" + x.名字 + "|", StringComparison.CurrentCulture));
			byte[] array2 = Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
			if (num2 > 0)
			{
				byte[] array3 = Singleton<ByteAPI>.I.到字节集反转(num - num2, 2);
				array2[12] = array3[0];
				array2[13] = array3[1];
			}
			await P_0.C_Send异步(array2);
		}
		catch (Exception ex)
		{
			Log.Error("接收_背包响应异步-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			await P_0.C_Send异步(P_1);
		}
	}

	
	internal byte[] tIvfFfsumd(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass5_0();
			int num = 0;
			short num2 = 0;
			int num3 = 0;
			string empty = string.Empty;
			CS_0024_003C_003E8__locals10.nFr9osCONk = 0;
			short num4 = 0;
			byte[] array = Array.Empty<byte>();
			short num5 = 0;
			int num6 = 0;
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
			short num7 = 封包_读2.读短整数型(reverse: true);
			封包_写2.写短整数型(num7, reverse: true);
			short num8 = 0;
			封包_写 封包_写3 = new 封包_写();
			物品信息类 物品信息类2 = null;
			for (int i = 0; i < num7; i++)
			{
				int num9 = 封包_读2.读字节型();
				if (全局变量类.Is调试)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler.AppendLiteral("背包物品：当前格子：[");
					defaultInterpolatedStringHandler.AppendFormatted(num9);
					defaultInterpolatedStringHandler.AppendLiteral("] ");
					Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				short num10 = 封包_读2.读短整数型(reverse: true);
				if (num9 > 0 && num9 <= 180)
				{
					物品信息类2 = P_0.user.背包数据.物品列表[num9];
				}
				if (物品信息类2 != null)
				{
					物品信息类2.C7n8ZR5IQ0(num9);
				}
				else
				{
					物品信息类2 = new 物品信息类
					{
						Index = num9
					};
				}
				封包_写3.清数据();
				封包_写3.写短整数型(num10, reverse: true);
				for (int j = 0; j < num10; j++)
				{
					CS_0024_003C_003E8__locals10.nFr9osCONk = 封包_读2.读短整数型(reverse: true);
					封包_写3.写短整数型(CS_0024_003C_003E8__locals10.nFr9osCONk, reverse: true);
					num4 = 封包_读2.读短整数型(reverse: true);
					封包_写3.写短整数型(num4, reverse: true);
					for (int k = 0; k < num4; k++)
					{
						array = 封包_读2.读字节集(2);
						num5 = Singleton<ByteAPI>.I.反转_短整数(array);
						封包_写3.写字节集(array, hasCount: false, 0);
						num6 = 封包_读2.读字节型();
						封包_写3.写字节型(num6);
						num = 0;
						num2 = 0;
						num3 = 0;
						empty = string.Empty;
						int 属性数值 = 0;
						switch (num6)
						{
						case 1:
							num = 封包_读2.读字节型();
							属性数值 = num;
							if (Enumerable.SequenceEqual(array, new byte[2] { 1, 177 }))
							{
								物品信息类2.装备已进化次数 = num;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 151 }))
							{
								物品信息类2.是否绑定 = num >= 3;
								物品信息类2.绑定状态 = ((num != 3 && num != 4) ? AllEnums.绑定Type.不绑定 : ((num == 4) ? AllEnums.绑定Type.死绑 : AllEnums.绑定Type.红绑));
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 29 }))
							{
								物品信息类2.性别 = num;
							}
							封包_写3.写字节型(num);
							break;
						case 2:
							num2 = 封包_读2.读短整数型(reverse: true);
							属性数值 = num2;
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 203 }))
							{
								物品信息类2.数量 = num2;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 136 }))
							{
								物品信息类2.奇术技能增加 = num2;
							}
							封包_写3.写短整数型(num2, reverse: true);
							break;
						case 3:
							num3 = 封包_读2.读整数型(reverse: true);
							属性数值 = num3;
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 84 }))
							{
								物品信息类2.物品ID = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 81 }))
							{
								物品信息类2.首饰可转换次数 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 71 }))
							{
								物品信息类2.首饰已转换次数 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 6 }) && num3 == 999)
							{
								num3 = 0;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 7 }))
							{
								物品信息类2.绑定气血 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 10 }))
							{
								物品信息类2.装备天伤 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 12 }))
							{
								物品信息类2.绑定法力 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 40 }))
							{
								物品信息类2.图标 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 42 }))
							{
								物品信息类2.当前耐久度 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 43 }))
							{
								物品信息类2.最大耐久度 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 137 }))
							{
								物品信息类2.当前炼魂值 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 138 }))
							{
								物品信息类2.最大炼魂值 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 207 }))
							{
								物品信息类2.售出价格 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 240 }))
							{
								物品信息类2.亲密度 = num3;
							}
							else if (!Enumerable.SequenceEqual(array, new byte[2] { 0, 206 }) && Enumerable.SequenceEqual(array, new byte[2] { 0, 208 }))
							{
								物品信息类2.改造等级 = num3;
							}
							封包_写3.写整数型(num3, reverse: true);
							break;
						case 4:
							empty = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 1 }))
							{
								if (CS_0024_003C_003E8__locals10.nFr9osCONk == 1)
								{
									物品信息类2.名字 = empty;
									if (版本相关处理.Is巅峰对决)
									{
										物品信息类2.前缀 = ((empty.Length > Singleton<全局变量类>.I.config.前缀长度) ? Singleton<ByteAPI>.I.取文本左边(empty, Singleton<全局变量类>.I.config.前缀长度) : string.Empty);
									}
									else if (Singleton<全局变量类>.I.元神系统配置.功能开关)
									{
										物品信息类2.前缀 = ((empty.Length > 4) ? Singleton<ByteAPI>.I.取文本左边(empty, 4) : string.Empty);
										物品信息类2.穿戴要求 = AllEnums.元神境界.凡人境;
										if (物品信息类2.前缀.EndsWith("★"))
										{
											Enum.TryParse<AllEnums.元神境界>(物品信息类2.前缀.Replace("★", string.Empty), out 物品信息类2.穿戴要求);
										}
									}
									else
									{
										物品信息类2.前缀 = string.Empty;
									}
									if (num9 == 31)
									{
										P_0.user.缓存数据.穿戴时装名 = empty;
									}
								}
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 55 }))
							{
								物品信息类2.单位 = empty;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 8 }))
							{
								物品信息类2.描述 = empty;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 89 }))
							{
								物品信息类2.改造人 = empty;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 209 }))
							{
								物品信息类2.物品颜色 = empty;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 65 }))
							{
								物品信息类2.别名 = empty;
							}
							封包_写3.写文本型(empty, hasCount: true, 0, reverse: true);
							break;
						case 6:
							num = 封包_读2.读字节型();
							属性数值 = num;
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 202 }))
							{
								物品信息类2.物品类型 = (byte)num;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 205 }))
							{
								物品信息类2.等级 = (byte)num;
							}
							封包_写3.写字节型(num);
							break;
						case 7:
							num2 = 封包_读2.读短整数型(reverse: true);
							属性数值 = num2;
							封包_写3.写短整数型(num2, reverse: true);
							break;
						}
						if (全局变量类.Is调试)
						{
							if (num6 == 1 || num6 == 6)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 6);
								defaultInterpolatedStringHandler.AppendLiteral("背包物品：当前格子：[");
								defaultInterpolatedStringHandler.AppendFormatted(num9);
								defaultInterpolatedStringHandler.AppendLiteral("] 属性类别：[");
								defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals10.nFr9osCONk);
								defaultInterpolatedStringHandler.AppendLiteral("] 数据类型：[");
								defaultInterpolatedStringHandler.AppendFormatted(num6);
								defaultInterpolatedStringHandler.AppendLiteral("]  属性标识：[");
								defaultInterpolatedStringHandler.AppendFormatted(num5);
								defaultInterpolatedStringHandler.AppendLiteral(" - ");
								defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(array));
								defaultInterpolatedStringHandler.AppendLiteral("]  T_字节型：[");
								defaultInterpolatedStringHandler.AppendFormatted(num);
								defaultInterpolatedStringHandler.AppendLiteral("]");
								Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							if (num6 == 2 || num6 == 7)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 7);
								defaultInterpolatedStringHandler.AppendLiteral("背包物品：当前格子：[");
								defaultInterpolatedStringHandler.AppendFormatted(num9);
								defaultInterpolatedStringHandler.AppendLiteral("] 属性类别：[");
								defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals10.nFr9osCONk);
								defaultInterpolatedStringHandler.AppendLiteral("] 数据类型：[");
								defaultInterpolatedStringHandler.AppendFormatted(num6);
								defaultInterpolatedStringHandler.AppendLiteral("]  属性标识：[");
								defaultInterpolatedStringHandler.AppendFormatted(num5);
								defaultInterpolatedStringHandler.AppendLiteral(" - ");
								defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(array));
								defaultInterpolatedStringHandler.AppendLiteral("]  T_短整数型：[");
								defaultInterpolatedStringHandler.AppendFormatted(num2);
								defaultInterpolatedStringHandler.AppendLiteral(" - ");
								defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(Singleton<ByteAPI>.I.到字节集短整数(num2)));
								defaultInterpolatedStringHandler.AppendLiteral("]");
								Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							if (num6 == 3)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(53, 7);
								defaultInterpolatedStringHandler.AppendLiteral("背包物品：当前格子：[");
								defaultInterpolatedStringHandler.AppendFormatted(num9);
								defaultInterpolatedStringHandler.AppendLiteral("] 属性类别：[");
								defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals10.nFr9osCONk);
								defaultInterpolatedStringHandler.AppendLiteral("] 数据类型：[");
								defaultInterpolatedStringHandler.AppendFormatted(num6);
								defaultInterpolatedStringHandler.AppendLiteral("]  属性标识：[");
								defaultInterpolatedStringHandler.AppendFormatted(num5);
								defaultInterpolatedStringHandler.AppendLiteral(" - ");
								defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(array));
								defaultInterpolatedStringHandler.AppendLiteral("]  T_整数型：[");
								defaultInterpolatedStringHandler.AppendFormatted(num3);
								defaultInterpolatedStringHandler.AppendLiteral(" - ");
								defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(Singleton<ByteAPI>.I.到字节集固定反转(num3)));
								defaultInterpolatedStringHandler.AppendLiteral("]");
								Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							if (num6 == 4)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 6);
								defaultInterpolatedStringHandler.AppendLiteral("背包物品：当前格子：[");
								defaultInterpolatedStringHandler.AppendFormatted(num9);
								defaultInterpolatedStringHandler.AppendLiteral("] 属性类别：[");
								defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals10.nFr9osCONk);
								defaultInterpolatedStringHandler.AppendLiteral("] 数据类型：[");
								defaultInterpolatedStringHandler.AppendFormatted(num6);
								defaultInterpolatedStringHandler.AppendLiteral("]  属性标识：[");
								defaultInterpolatedStringHandler.AppendFormatted(num5);
								defaultInterpolatedStringHandler.AppendLiteral(" - ");
								defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(array));
								defaultInterpolatedStringHandler.AppendLiteral("]  T_文本型：[");
								defaultInterpolatedStringHandler.AppendFormatted(empty);
								defaultInterpolatedStringHandler.AppendLiteral("]");
								Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
							}
						}
						if (全局常量类.属性类别组.Any( (int x) => x == CS_0024_003C_003E8__locals10.nFr9osCONk))
						{
							物品信息类2.装备属性列表.Add(new 属性数据
							{
								属性类别 = CS_0024_003C_003E8__locals10.nFr9osCONk,
								属性标识 = num5,
								属性数值 = 属性数值
							});
						}
					}
				}
				if (fuMNpgieFTYU3Wah53.BojPVlpN4() && 物品信息类2.物品ID != 0)
				{
					if (num9 == 8)
					{
						P_0.user.缓存数据.Is首次穿戴梭子 = 0;
						num8++;
						封包_写3.清数据();
						continue;
					}
					if (Singleton<ByteAPI>.I.寻找文本等(物品信息类2.名字, "梦荷", "御天梭", "御魂·轩辕神剑", "御魂·九天玄龟", "御魂·霸天玉瑶", "御魂·孔雀翎"))
					{
						if (P_0.user.缓存数据.Is首次穿戴梭子 == 0)
						{
							物品信息类2.物品ID = 0;
							Singleton<WdAPI>.I.iaDIkvl1cj(P_0, num9);
						}
						else if (P_0.user.缓存数据.Is首次穿戴梭子 == 1 && 物品信息类2.名字 == "御天梭")
						{
							P_0.user.缓存数据.Is首次穿戴梭子 = 2;
							Singleton<fuMNpgieFTYU3Wah53>.I.rPGGaUKqN(P_0, num9);
						}
						else if (P_0.user.缓存数据.Is首次穿戴梭子 == 2 && 物品信息类2.名字 == "御天梭")
						{
							P_0.user.缓存数据.Is首次穿戴梭子 = 3;
							P_0.S_Send(Singleton<WdAPI>.I.FUioW2lnt4(num9, 8));
						}
						num8++;
						封包_写3.清数据();
						continue;
					}
				}
				if (pN4kvFDKqDQRQBnO8BW.wATDfrQwrg())
				{
					P_0.拆卸回调事件?.Invoke(num9, 物品信息类2.名字);
				}
				if (Singleton<全局变量类>.I.超级道具配置.功能开关 && !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.超级道具配置.自动绑定道具) && Singleton<ByteAPI>.I.寻找文本(Singleton<全局变量类>.I.超级道具配置.自动绑定道具, "|" + 物品信息类2.名字 + "|") && !物品信息类2.是否绑定)
				{
					Singleton<WdAPI>.I.Mr8ICwW3qX(P_0, num9, "property_bind/attrib", "4");
				}
				物品信息类2.rgh8r0QQvs(P_0);
				if (rCpfLKhKrZ(P_0, 物品信息类2))
				{
					物品信息类2.封包缓存 = 封包_写3.取数据();
					封包_写3.清数据();
					封包_写3.写入数据(KDQfSpe9nM(P_0, 物品信息类2.封包缓存, 物品信息类2), hasCount: false, 0);
				}
				物品信息类2.封包缓存 = 封包_写3.取数据();
				封包_写2.写字节型(num9);
				封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
				P_0.超级进化事件?.Invoke(num9);
			}
			Singleton<版本相关处理>.I.巅峰对决读取穿戴(P_0);
			P_0.user.缓存数据.Is自动使用道具 = P_0.user.背包数据.物品列表.Any( (物品信息类 x) => x.Index != 0 && x.物品ID != 0 && ("|" + Singleton<全局变量类>.I.超级道具配置.自动使用道具 + "|").Contains("|" + x.名字 + "|", StringComparison.CurrentCulture));
			byte[] array2 = Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
			if (num8 > 0)
			{
				byte[] array3 = Singleton<ByteAPI>.I.到字节集反转(num7 - num8, 2);
				array2[12] = array3[0];
				array2[13] = array3[1];
			}
			return array2;
		}
		catch (Exception ex)
		{
			Log.Error("接收_背包响应-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal bool rCpfLKhKrZ(MyNATSocketClient P_0, 物品信息类 P_1)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals24 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals24.Ms99GyNg1y = P_1;
		if (string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字))
		{
			return false;
		}
		if (YHfw7nGpg7WfdCBKDH4.qapfK9UWNV() && CS_0024_003C_003E8__locals24.Ms99GyNg1y.摊位价格 > 0)
		{
			return true;
		}
		if (浮生录功能.GrAWb1KahR() && Singleton<全局变量类>.I.浮生录配置.化身列表.ContainsKey(CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.属性洗炼配置.功能开关 && ((Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.功能开关 && Singleton<ByteAPI>.I.寻找文本("、" + Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.装备名字 + "、", "、" + CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字 + "、")) || (Singleton<全局变量类>.I.属性洗炼配置.法宝配置.功能开关 && Singleton<ByteAPI>.I.寻找文本("、" + Singleton<全局变量类>.I.属性洗炼配置.法宝配置.装备名字 + "、", "、" + CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字 + "、")) || (Singleton<全局变量类>.I.属性洗炼配置.梭子配置.功能开关 && Singleton<ByteAPI>.I.寻找文本("、" + Singleton<全局变量类>.I.属性洗炼配置.梭子配置.装备名字 + "、", "、" + CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字 + "、")) || (Singleton<全局变量类>.I.属性洗炼配置.时装配置.功能开关 && Singleton<ByteAPI>.I.寻找文本("、" + Singleton<全局变量类>.I.属性洗炼配置.时装配置.装备名字 + "、", "、" + CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字 + "、")) || (Singleton<全局变量类>.I.属性洗炼配置.仙器配置.功能开关 && Singleton<ByteAPI>.I.寻找文本("、" + Singleton<全局变量类>.I.属性洗炼配置.仙器配置.装备名字 + "、", "、" + CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字 + "、")) || (Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.功能开关 && Singleton<ByteAPI>.I.寻找文本("、" + Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.装备名字 + "、", "、" + CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字 + "、"))))
		{
			return true;
		}
		if (CS_0024_003C_003E8__locals24.Ms99GyNg1y.分解Data != null)
		{
			return true;
		}
		if (U8hGTORuviqLJbXPJ0Y.HvERl5OIw9.Contains("|" + CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字 + "|", StringComparison.CurrentCulture))
		{
			return true;
		}
		if (AZI1HsR8MjRfegmETY5.fZ1RSIDoZn.ToString().Contains("|" + CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字 + "|", StringComparison.CurrentCulture))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.道具宠物回收配置.is道具回收 && Singleton<全局变量类>.I.道具宠物回收配置.回收列表.ContainsKey(CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字))
		{
			return true;
		}
		if (TOqsYfW68LIGjCtAgK8.AlyW5lfYvE() && CS_0024_003C_003E8__locals24.Ms99GyNg1y.装备属性列表.Any( (属性数据 x) => x.属性类别 == 2562 && 问道数据类.特效类型字典.Contains(x.属性标识)))
		{
			return true;
		}
		if (zeYnwTjKgpmAbfSQh5J.ARHjmZgHJU() && Singleton<全局变量类>.I.超级道具配置.超级道具列表.ContainsKey(CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字))
		{
			return true;
		}
		if (mQEQjEBxYW4SsAecBHJ.a4HBZHHjWC(CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字))
		{
			return true;
		}
		if (FcVoHRwOVsflDmDUQOP.JhVwZ5yCsf() && Singleton<全局变量类>.I.召唤精怪配置.召唤列表.Values.Any( (List<召唤精怪列表类> x) => x.Any( (召唤精怪列表类 y) => y.礼包名字 == CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字)))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.元神系统配置.功能开关 &&
			Singleton<全局变量类>.I.元神系统配置.装备升阶数据.功能开关 &&
			CS_0024_003C_003E8__locals24.Ms99GyNg1y.最大耐久度 > 100000 &&
			CS_0024_003C_003E8__locals24.Ms99GyNg1y.最大耐久度 <= 200000)
		{
			return true;
		}
		if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && (CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字 == "本命法宝★人皇幡" || (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.功能开关 && CS_0024_003C_003E8__locals24.Ms99GyNg1y.最大耐久度 > 100000 && CS_0024_003C_003E8__locals24.Ms99GyNg1y.最大耐久度 <= 200000) || (Singleton<全局变量类>.I.元神系统配置.心法升级配置.功能开关 && Singleton<ByteAPI>.I.寻找文本(Ab7Ypu2aCcHMcLPG8Um.sK3m8a9JNp.ToString(), "|" + CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字 + "|")) || (Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.功能开关 && CS_0024_003C_003E8__locals24.Ms99GyNg1y.最大炼魂值 >= 10000 && Singleton<ByteAPI>.I.寻找文本(Ab7Ypu2aCcHMcLPG8Um.sPhmoeHQ4M.ToString(), "|" + CS_0024_003C_003E8__locals24.Ms99GyNg1y.名字 + "|"))))
		{
			return true;
		}
		return false;
	}

	
	internal byte[] KDQfSpe9nM(MyNATSocketClient P_0, byte[] P_1, 物品信息类 P_2)
	{
		try
		{
			if (Singleton<全局变量类>.I.元神系统配置.功能开关 && Singleton<全局变量类>.I.元神系统配置.装备升阶数据.功能开关 && P_2.最大耐久度 > 100000 && P_2.最大耐久度 <= 200000 && Singleton<全局变量类>.I.元神系统配置.装备升阶数据.装备升阶类型.ContainsKey((AllEnums.Equip类型)P_2.物品类型))
			{
				P_2.穿戴要求 = (AllEnums.元神境界)((P_2.最大耐久度 - 100000) / 10000);
			}
			string empty = string.Empty;
			int value = 0;
			int value2 = 0;
			short value3 = 0;
			StringBuilder stringBuilder = new StringBuilder();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写 封包_写3 = new 封包_写();
			封包_写 封包_写4 = new 封包_写();
			StringBuilder stringBuilder2 = new StringBuilder();
			short num = 封包_读2.读短整数型(reverse: true);
			封包_写2.写短整数型(num, reverse: true);
			for (int i = 0; i < num; i++)
			{
				short num2 = 封包_读2.读短整数型(reverse: true);
				short num3 = 封包_读2.读短整数型(reverse: true);
				封包_写3.清数据();
				int num4 = 0;
				for (int j = 0; j < num3; j++)
				{
					byte[] array = 封包_读2.读字节集(2);
					short item = Singleton<ByteAPI>.I.反转_短整数(array);
					int num5 = 封包_读2.读字节型();
					封包_写4.清数据();
					封包_写4.写字节集(array, hasCount: false, 0);
					封包_写4.写字节型(num5);
					switch (num5)
					{
					case 1:
						封包_读2.读字节型(out value);
						封包_写4.写字节型(value);
						break;
					case 2:
						封包_读2.读短整数型(reverse: true, out value3);
						封包_写4.写短整数型(value3, reverse: true);
						break;
					case 3:
						封包_读2.读整数型(reverse: true, out value2);
						if (array[0] == 0 && array[1] == 206)
						{
							if (Singleton<ByteAPI>.I.寻找文本(U8hGTORuviqLJbXPJ0Y.HvERl5OIw9, "|" + P_2.名字 + "|") || Singleton<ByteAPI>.I.寻找文本(AZI1HsR8MjRfegmETY5.fZ1RSIDoZn.ToString(), "|" + P_2.名字 + "|") || (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && Singleton<全局变量类>.I.元神系统配置.心法升级配置.功能开关 && Singleton<ByteAPI>.I.寻找文本(Ab7Ypu2aCcHMcLPG8Um.sK3m8a9JNp.ToString(), "|" + P_2.名字 + "|")))
							{
								value2 = 132;
							}
							else if (mQEQjEBxYW4SsAecBHJ.a4HBZHHjWC(P_2.名字))
							{
								value2 = 268451844;
							}
						}
						封包_写4.写整数型(value2, reverse: true);
						break;
					case 4:
						empty = 封包_读2.读文本型(是否声明长度: true, 0);
						if (array[0] == 0 && array[1] == 1 && num2 == 1)
						{
							if (FcVoHRwOVsflDmDUQOP.JhVwZ5yCsf() && P_2.名字.StartsWith("锁麟囊·"))
							{
								empty = "锁麟囊";
							}
						}
						else if (array[0] == 1 && array[1] == 8)
						{
							stringBuilder.Clear();
							if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND())
							{
								if (P_2.名字 == "本命法宝★人皇幡" && Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryGetValue(P_2.改造等级 + 1, out 本命法宝属性类 value4))
								{
									stringBuilder.Append("#Y强化每加10级会获得一条新的属性#r");
									if (P_2.当前耐久度 != 1)
									{
										StringBuilder stringBuilder3 = stringBuilder;
										StringBuilder stringBuilder4 = stringBuilder3;
										StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(16, 2, stringBuilder3);
										handler.AppendLiteral("#D强化");
										handler.AppendFormatted(P_2.改造等级 + 1);
										handler.AppendLiteral("级进度#R(");
										handler.AppendFormatted((float)P_2.当前耐久度 * 100f / (float)value4.强化进度, "F2");
										handler.AppendLiteral("%)#n#r");
										stringBuilder4.Append(ref handler);
									}
									empty += $"{((empty.EndsWith("#r") || string.IsNullOrWhiteSpace(empty)) ? string.Empty : "#r")}{stringBuilder}";
								}
								else if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.功能开关 && P_2.最大耐久度 > 100000 && P_2.最大耐久度 <= 200000 && Singleton<全局变量类>.I.元神系统配置.装备升阶数据.装备升阶类型.ContainsKey((AllEnums.Equip类型)P_2.物品类型))
								{
									升阶需求类 value5;
									if (P_2.最大耐久度 >= 200000)
									{
										stringBuilder.Append("#Y当前品阶：真仙境#n#r");
									}
									else if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.TryGetValue(P_2.穿戴要求 + 1, out value5))
									{
										StringBuilder stringBuilder3 = stringBuilder;
										StringBuilder stringBuilder5 = stringBuilder3;
										StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(22, 2, stringBuilder3);
										handler.AppendLiteral("#Y当前品阶：");
										handler.AppendFormatted(P_2.穿戴要求);
										handler.AppendLiteral("#r#R(升阶进度");
										handler.AppendFormatted((float)(P_2.最大耐久度 % 10000) * 100f / (float)value5.需求数量, "F2");
										handler.AppendLiteral("%)#n#r");
										stringBuilder5.Append(ref handler);
									}
									empty += $"{((empty.EndsWith("#r") || string.IsNullOrWhiteSpace(empty)) ? string.Empty : "#r")}{stringBuilder}";
								}
								else if (Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.功能开关 && P_2.最大炼魂值 >= 10000 && Singleton<ByteAPI>.I.寻找文本(Ab7Ypu2aCcHMcLPG8Um.sPhmoeHQ4M.ToString(), "|" + P_2.名字 + "|"))
								{
									int value6 = P_2.最大炼魂值 % 10000;
									if (Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryGetValue(P_2.最大炼魂值, out 引灵幡属性列表类 value7))
									{
										StringBuilder stringBuilder3;
										StringBuilder.AppendInterpolatedStringHandler handler;
										for (int k = 0; k < value7.属性列表.Count; k++)
										{
											stringBuilder3 = stringBuilder;
											StringBuilder stringBuilder6 = stringBuilder3;
											handler = new StringBuilder.AppendInterpolatedStringHandler(8, 2, stringBuilder3);
											handler.AppendLiteral("#G");
											handler.AppendFormatted(value7.属性列表[k].属性名字);
											handler.AppendLiteral(" ");
											handler.AppendFormatted(value7.属性列表[k].属性数值);
											handler.AppendLiteral(" 增加#r");
											stringBuilder6.Append(ref handler);
										}
										stringBuilder3 = stringBuilder;
										StringBuilder stringBuilder7 = stringBuilder3;
										handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder3);
										handler.AppendLiteral("#Y当前附灵品阶 ：");
										handler.AppendFormatted(value6);
										handler.AppendLiteral("品#r");
										stringBuilder7.Append(ref handler);
									}
									empty += $"{((empty.EndsWith("#r") || string.IsNullOrWhiteSpace(empty)) ? string.Empty : "#r")}{stringBuilder}";
								}
							}
							if (FcVoHRwOVsflDmDUQOP.JhVwZ5yCsf() && P_2.名字.StartsWith("锁麟囊·"))
							{
								召唤精怪列表类 召唤精怪列表类2 = Singleton<FcVoHRwOVsflDmDUQOP>.I.tMOw1LxwSn(P_2.名字);
								if (召唤精怪列表类2 != null)
								{
									StringBuilder stringBuilder3 = stringBuilder;
									StringBuilder stringBuilder8 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(84, 4, stringBuilder3);
									handler.AppendLiteral("陆压真人施展役使鬼神之术留下的宝物，其中镇压着各种山精鬼魅。使用后可选择获得其中镇压的宠物，或获得大量银元宝。#r#B镇压宠物：三天技");
									handler.AppendFormatted(召唤精怪列表类2.镇压宠物);
									handler.AppendLiteral("#r可获元宝：");
									handler.AppendFormatted(召唤精怪列表类2.最低银元宝);
									handler.AppendLiteral("至");
									handler.AppendFormatted(召唤精怪列表类2.最高银元宝);
									handler.AppendLiteral("#r平均元宝：");
									handler.AppendFormatted(召唤精怪列表类2.平均银元宝);
									handler.AppendLiteral("#n");
									stringBuilder8.Append(ref handler);
									empty += $"{((empty.EndsWith("#r") || string.IsNullOrWhiteSpace(empty)) ? string.Empty : "#r")}{stringBuilder}";
								}
							}
							if (zeYnwTjKgpmAbfSQh5J.ARHjmZgHJU() && Singleton<全局变量类>.I.超级道具配置.超级道具列表.TryGetValue(P_2.名字, out 超级道具列表配置类 value8))
							{
								if (value8.is奖励开关 && value8.附加属性类型 != AllEnums.属性名字Type.无 && value8.最低奖励下限 != 0 && value8.最高奖励上限 > 0 && value8.获得几率 > 0)
								{
									StringBuilder stringBuilder3 = stringBuilder;
									StringBuilder stringBuilder9 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(41, 5, stringBuilder3);
									handler.AppendLiteral("#l#Y提升：#B");
									handler.AppendFormatted(value8.附加属性类型);
									handler.AppendLiteral(" ");
									object value9;
									if (value8.最低奖励下限 != value8.最高奖励上限)
									{
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
										defaultInterpolatedStringHandler.AppendFormatted(value8.最低奖励下限);
										defaultInterpolatedStringHandler.AppendLiteral("-");
										defaultInterpolatedStringHandler.AppendFormatted(value8.最高奖励上限);
										value9 = defaultInterpolatedStringHandler.ToStringAndClear();
									}
									else
									{
										value9 = $"{value8.最低奖励下限}";
									}
									handler.AppendFormatted((string?)value9);
									handler.AppendFormatted(问道数据类.Add属性名字后缀(value8.附加属性类型));
									handler.AppendLiteral(" 增加#r#Y几率：#n使用后有#R");
									handler.AppendFormatted(value8.获得几率);
									handler.AppendLiteral("%#n几率获得属性#r#n");
									string value10;
									if (value8.附加属性限时 != 0)
									{
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
										defaultInterpolatedStringHandler.AppendLiteral("#Y时间：#R");
										defaultInterpolatedStringHandler.AppendFormatted(value8.附加属性限时);
										defaultInterpolatedStringHandler.AppendLiteral("#n分钟内有效(时间可叠加)#r");
										value10 = defaultInterpolatedStringHandler.ToStringAndClear();
									}
									else
									{
										value10 = "#Y时间：#n属性提升#L永久有效#r";
									}
									handler.AppendFormatted(value10);
									stringBuilder9.Append(ref handler);
								}
								if (value8.最多使用数量 != -1)
								{
									StringBuilder stringBuilder3 = stringBuilder;
									StringBuilder stringBuilder10 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(21, 1, stringBuilder3);
									handler.AppendLiteral("#Y数量：#n人物最多可使用#R");
									handler.AppendFormatted(value8.最多使用数量);
									handler.AppendLiteral("#n个#r");
									stringBuilder10.Append(ref handler);
								}
								if (value8.is等级开关 && value8.最高使用等级 != 0)
								{
									StringBuilder stringBuilder3 = stringBuilder;
									StringBuilder stringBuilder11 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(26, 2, stringBuilder3);
									handler.AppendLiteral("#Y等级：#n人物等级#R");
									handler.AppendFormatted(value8.最低使用等级);
									handler.AppendLiteral("#n-#R");
									handler.AppendFormatted(value8.最高使用等级);
									handler.AppendLiteral("#n级可使用#r");
									stringBuilder11.Append(ref handler);
								}
								if (value8.is道行开关 && value8.最高使用道行 != 0)
								{
									StringBuilder stringBuilder3 = stringBuilder;
									StringBuilder stringBuilder12 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(26, 2, stringBuilder3);
									handler.AppendLiteral("#Y道行：#n人物道行#R");
									handler.AppendFormatted(value8.最低使用道行);
									handler.AppendLiteral("#n-#R");
									handler.AppendFormatted(value8.最高使用道行);
									handler.AppendLiteral("#n年可使用#r");
									stringBuilder12.Append(ref handler);
								}
								if (value8.is称号开关 && !string.IsNullOrWhiteSpace(value8.指定称号使用))
								{
									StringBuilder stringBuilder3 = stringBuilder;
									StringBuilder stringBuilder13 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(20, 1, stringBuilder3);
									handler.AppendLiteral("#Y称号：#n拥有#R");
									handler.AppendFormatted(value8.指定称号使用);
									handler.AppendLiteral("#n称号可使用#r");
									stringBuilder13.Append(ref handler);
								}
								if (value8.道具消耗类型 != AllEnums.数值Type.无 && !string.IsNullOrWhiteSpace(value8.道具消耗内容))
								{
									StringBuilder stringBuilder3 = stringBuilder;
									StringBuilder stringBuilder14 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(16, 1, stringBuilder3);
									handler.AppendLiteral("#M注意：使用该物品需要消耗");
									string value11;
									if (value8.道具消耗类型 != AllEnums.数值Type.道具)
									{
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 2);
										defaultInterpolatedStringHandler.AppendLiteral("#R");
										defaultInterpolatedStringHandler.AppendFormatted(value8.道具消耗内容);
										defaultInterpolatedStringHandler.AppendLiteral("#n");
										defaultInterpolatedStringHandler.AppendFormatted(value8.道具消耗类型);
										defaultInterpolatedStringHandler.AppendLiteral("#n");
										value11 = defaultInterpolatedStringHandler.ToStringAndClear();
									}
									else
									{
										value11 = "#R1#n个#R" + value8.道具消耗内容 + "#n";
									}
									handler.AppendFormatted(value11);
									handler.AppendLiteral("#r");
									stringBuilder14.Append(ref handler);
								}
								empty += $"{((empty.EndsWith("#r") || string.IsNullOrWhiteSpace(empty)) ? string.Empty : "#r")}{stringBuilder}";
							}
							if (TOqsYfW68LIGjCtAgK8.AlyW5lfYvE())
							{
								List<属性数据> list = P_2.装备属性列表.FindAll( (属性数据 x) => x.属性类别 == 2562 && x.属性数值 != 0 && 问道数据类.特效类型字典.Contains(x.属性标识));
								if (list.Count > 0)
								{
									string text = empty;
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 4);
									defaultInterpolatedStringHandler.AppendFormatted((empty.EndsWith("#r") || string.IsNullOrWhiteSpace(empty)) ? string.Empty : "#r");
									defaultInterpolatedStringHandler.AppendLiteral("#M特效：");
									defaultInterpolatedStringHandler.AppendFormatted((AllEnums.特效类型Type)list[0].属性标识);
									defaultInterpolatedStringHandler.AppendLiteral("#r#Y(");
									defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性名字Type)list[0].属性标识);
									defaultInterpolatedStringHandler.AppendLiteral(" ");
									defaultInterpolatedStringHandler.AppendFormatted(list[0].属性数值);
									defaultInterpolatedStringHandler.AppendLiteral(" 增加)#n");
									empty = text + defaultInterpolatedStringHandler.ToStringAndClear();
								}
							}
							if (浮生录功能.GrAWb1KahR() && Singleton<全局变量类>.I.浮生录配置.化身列表.TryGetValue(P_2.名字, out 浮生化身配置类 value12))
							{
								empty += Singleton<浮生录功能>.I.y18U3GO5oJ(P_0, value12);
							}
							if (Singleton<全局变量类>.I.属性洗炼配置.功能开关 && Singleton<ByteAPI>.I.寻找文本(empty, "#B洗炼："))
							{
								string[] array2 = empty.Replace("%", "").Replace("#r", "").Split("#B洗炼：");
								for (int num6 = 0; num6 < array2.Length; num6++)
								{
									if (!string.IsNullOrWhiteSpace(array2[num6]))
									{
										string[] array3 = array2[num6].Split(" ");
										洗炼属性缓存列表类 洗炼属性缓存列表类2 = new 洗炼属性缓存列表类();
										if (Enum.TryParse<AllEnums.洗炼属性Type>(array3[0], out 洗炼属性缓存列表类2.属性))
										{
											int.TryParse(array3[1], out 洗炼属性缓存列表类2.数值);
											P_2.洗炼属性列表.Add(洗炼属性缓存列表类2);
										}
									}
								}
								empty = ((!Singleton<ByteAPI>.I.寻找文本("、" + Singleton<全局变量类>.I.属性洗炼配置.时装配置.装备名字 + "、", "、" + P_2.名字 + "、") && !Singleton<ByteAPI>.I.寻找文本("、" + Singleton<全局变量类>.I.属性洗炼配置.仙器配置.装备名字 + "、", "、" + P_2.名字 + "、")) ? empty.Replace("#B洗炼：", "#B") : string.Empty);
							}
							if (P_2.分解Data != null)
							{
								if (P_2.分解Data.分解灵气值区间[0] >= 0 && P_2.分解Data.分解灵气值区间[1] >= 0)
								{
									if (P_2.分解Data.分解灵气值区间[0] == P_2.分解Data.分解灵气值区间[1])
									{
										string text2 = empty;
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
										defaultInterpolatedStringHandler.AppendFormatted((empty.EndsWith("#r") || string.IsNullOrWhiteSpace(empty)) ? string.Empty : "#r");
										defaultInterpolatedStringHandler.AppendLiteral("#Y分解：#n可获得#R");
										defaultInterpolatedStringHandler.AppendFormatted(P_2.分解Data.分解灵气值区间[0]);
										defaultInterpolatedStringHandler.AppendLiteral("#n点#Y灵气值#n");
										empty = text2 + defaultInterpolatedStringHandler.ToStringAndClear();
									}
									else
									{
										string text3 = empty;
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
										defaultInterpolatedStringHandler.AppendFormatted((empty.EndsWith("#r") || string.IsNullOrWhiteSpace(empty)) ? string.Empty : "#r");
										defaultInterpolatedStringHandler.AppendLiteral("#Y分解：#n可获得#R");
										defaultInterpolatedStringHandler.AppendFormatted(P_2.分解Data.分解灵气值区间[0]);
										defaultInterpolatedStringHandler.AppendLiteral("#n-#R");
										defaultInterpolatedStringHandler.AppendFormatted(P_2.分解Data.分解灵气值区间[1]);
										defaultInterpolatedStringHandler.AppendLiteral("#n点#Y灵气值#n");
										empty = text3 + defaultInterpolatedStringHandler.ToStringAndClear();
									}
								}
								if (!string.IsNullOrWhiteSpace(P_2.分解Data.分解道具名字))
								{
									if (P_2.分解Data.分解道具区间[1] == P_2.分解Data.分解道具区间[2])
									{
										string text4 = empty;
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
										defaultInterpolatedStringHandler.AppendLiteral("，大约每分解#R");
										defaultInterpolatedStringHandler.AppendFormatted(P_2.分解Data.分解道具区间[0]);
										defaultInterpolatedStringHandler.AppendLiteral("#n个就有几率爆出#R");
										defaultInterpolatedStringHandler.AppendFormatted(P_2.分解Data.分解道具区间[1]);
										defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
										defaultInterpolatedStringHandler.AppendFormatted(P_2.分解Data.分解道具名字);
										defaultInterpolatedStringHandler.AppendLiteral("#n");
										empty = text4 + defaultInterpolatedStringHandler.ToStringAndClear();
									}
									else
									{
										string text5 = empty;
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 4);
										defaultInterpolatedStringHandler.AppendLiteral("，大约每分解#R");
										defaultInterpolatedStringHandler.AppendFormatted(P_2.分解Data.分解道具区间[0]);
										defaultInterpolatedStringHandler.AppendLiteral("#n个就有几率爆出#R");
										defaultInterpolatedStringHandler.AppendFormatted(P_2.分解Data.分解道具区间[1]);
										defaultInterpolatedStringHandler.AppendLiteral("#n-#R");
										defaultInterpolatedStringHandler.AppendFormatted(P_2.分解Data.分解道具区间[2]);
										defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
										defaultInterpolatedStringHandler.AppendFormatted(P_2.分解Data.分解道具名字);
										defaultInterpolatedStringHandler.AppendLiteral("#n");
										empty = text5 + defaultInterpolatedStringHandler.ToStringAndClear();
									}
								}
							}
							if (Singleton<全局变量类>.I.道具宠物回收配置.is道具回收 && Singleton<全局变量类>.I.道具宠物回收配置.回收列表.TryGetValue(P_2.名字, out 道宠回收数据类 value13))
							{
								stringBuilder2.Clear();
								if (value13.金元宝 > 0)
								{
									StringBuilder stringBuilder3 = stringBuilder2;
									StringBuilder stringBuilder15 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(24, 1, stringBuilder3);
									handler.AppendLiteral("#r#L回收：#n");
									handler.AppendFormatted(value13.金元宝);
									handler.AppendLiteral("#Y金元宝#R(100%)#n");
									stringBuilder15.Append(ref handler);
								}
								if (value13.银元宝 > 0)
								{
									StringBuilder stringBuilder3 = stringBuilder2;
									StringBuilder stringBuilder16 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(24, 1, stringBuilder3);
									handler.AppendLiteral("#r#L回收：#n");
									handler.AppendFormatted(value13.银元宝);
									handler.AppendLiteral("#Y银元宝#R(100%)#n");
									stringBuilder16.Append(ref handler);
								}
								if (value13.累充点 > 0 && value13.累充点几率 > 0)
								{
									StringBuilder stringBuilder3 = stringBuilder2;
									StringBuilder stringBuilder17 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(21, 2, stringBuilder3);
									handler.AppendLiteral("#r#L回收：#n");
									handler.AppendFormatted(value13.累充点);
									handler.AppendLiteral("#Y累充点#R(");
									handler.AppendFormatted(value13.累充点几率);
									handler.AppendLiteral("%)#n");
									stringBuilder17.Append(ref handler);
								}
								if (value13.南极点 > 0 && value13.南极点几率 > 0)
								{
									StringBuilder stringBuilder3 = stringBuilder2;
									StringBuilder stringBuilder18 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(21, 2, stringBuilder3);
									handler.AppendLiteral("#r#L回收：#n");
									handler.AppendFormatted(value13.南极点);
									handler.AppendLiteral("#Y南极点#R(");
									handler.AppendFormatted(value13.南极点几率);
									handler.AppendLiteral("%)#n");
									stringBuilder18.Append(ref handler);
								}
								if (value13.奇宝点 > 0 && value13.奇宝点几率 > 0)
								{
									StringBuilder stringBuilder3 = stringBuilder2;
									StringBuilder stringBuilder19 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(21, 2, stringBuilder3);
									handler.AppendLiteral("#r#L回收：#n");
									handler.AppendFormatted(value13.奇宝点);
									handler.AppendLiteral("#Y奇宝点#R(");
									handler.AppendFormatted(value13.奇宝点几率);
									handler.AppendLiteral("%)#n");
									stringBuilder19.Append(ref handler);
								}
								if (value13.游戏币 > 0 && value13.游戏币几率 > 0)
								{
									StringBuilder stringBuilder3 = stringBuilder2;
									StringBuilder stringBuilder20 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(20, 2, stringBuilder3);
									handler.AppendLiteral("#r#L回收：#n");
									handler.AppendFormatted(value13.游戏币);
									handler.AppendLiteral("#Y金钱#R(");
									handler.AppendFormatted(value13.游戏币几率);
									handler.AppendLiteral("%)#n");
									stringBuilder20.Append(ref handler);
								}
								if (value13.灵气值 > 0 && value13.灵气值几率 > 0)
								{
									StringBuilder stringBuilder3 = stringBuilder2;
									StringBuilder stringBuilder21 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(21, 2, stringBuilder3);
									handler.AppendLiteral("#r#L回收：#n");
									handler.AppendFormatted(value13.灵气值);
									handler.AppendLiteral("#Y灵气值#R(");
									handler.AppendFormatted(value13.灵气值几率);
									handler.AppendLiteral("%)#n");
									stringBuilder21.Append(ref handler);
								}
								if (!string.IsNullOrWhiteSpace(value13.奖励道具) && value13.奖励道具最低数量 > 0 && value13.奖励道具最高数量 >= value13.奖励道具最低数量)
								{
									StringBuilder stringBuilder3 = stringBuilder2;
									StringBuilder stringBuilder22 = stringBuilder3;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(18, 4, stringBuilder3);
									handler.AppendLiteral("#r#L回收：#n");
									handler.AppendFormatted(value13.奖励道具);
									handler.AppendLiteral("×");
									handler.AppendFormatted(value13.奖励道具最低数量);
									handler.AppendLiteral("~");
									handler.AppendFormatted(value13.奖励道具最高数量);
									handler.AppendLiteral("#R(");
									handler.AppendFormatted(value13.奖励道具几率);
									handler.AppendLiteral("%)#n");
									stringBuilder22.Append(ref handler);
								}
								stringBuilder2.Append("#r#G(出售给系统非仙灵卡商店即可)#n");
								empty += stringBuilder2.ToString();
							}
							if (YHfw7nGpg7WfdCBKDH4.qapfK9UWNV() && P_2.摊位价格 > 0)
							{
								string text6 = empty;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
								defaultInterpolatedStringHandler.AppendLiteral("#r#L实际价格：");
								defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(P_2.摊位价格));
								defaultInterpolatedStringHandler.AppendFormatted(YHfw7nGpg7WfdCBKDH4.bsAfdnNsoZ);
								defaultInterpolatedStringHandler.AppendLiteral("#n");
								empty = text6 + defaultInterpolatedStringHandler.ToStringAndClear();
							}
						}
						封包_写4.写文本型(empty, hasCount: true, 0);
						break;
					case 6:
						封包_读2.读字节型(out value);
						封包_写4.写字节型(value);
						break;
					case 7:
						封包_读2.读短整数型(reverse: true, out value3);
						if (array[0] == 0 && array[1] == 74)
						{
							if (Singleton<ByteAPI>.I.寻找文本(U8hGTORuviqLJbXPJ0Y.HvERl5OIw9, "|" + P_2.名字 + "|") || Singleton<ByteAPI>.I.寻找文本(AZI1HsR8MjRfegmETY5.fZ1RSIDoZn.ToString(), "|" + P_2.名字 + "|") || (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && Singleton<全局变量类>.I.元神系统配置.心法升级配置.功能开关 && Singleton<ByteAPI>.I.寻找文本(Ab7Ypu2aCcHMcLPG8Um.sK3m8a9JNp.ToString(), "|" + P_2.名字 + "|")))
							{
								value3 = 5;
							}
							else if (mQEQjEBxYW4SsAecBHJ.a4HBZHHjWC(P_2.名字))
							{
								value3 = 10;
							}
						}
						封包_写4.写短整数型(value3, reverse: true);
						break;
					}
					if (TOqsYfW68LIGjCtAgK8.AlyW5lfYvE() && num2 == 2562 && 问道数据类.特效类型字典.Contains(item))
					{
						num4++;
					}
					else
					{
						封包_写3.写字节集(封包_写4.取数据(), hasCount: false, 0);
					}
				}
				封包_写2.写短整数型(num2, reverse: true);
				封包_写2.写短整数型((short)(num3 - num4), reverse: true);
				封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			}
			return 封包_写2.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("背包指定格子信息重组-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] ED4fcWuaoc(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("请求_仓库存物品-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] NGtfnF0R5b(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("请求_仓库取物品-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] o5pf5rjR8h(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			int num = 0;
			short num2 = 0;
			int num3 = 0;
			string empty = string.Empty;
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写2.写字节集(封包_读2.读字节集(1), hasCount: false, 0);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value4), reverse: true);
			封包_写 封包_写3 = new 封包_写();
			for (int i = 0; i < value4; i++)
			{
				封包_读2.读短整数型(reverse: true, out var value5);
				封包_读2.读短整数型(reverse: true, out var value6);
				if (全局变量类.Is调试)
				{
					Log.Error("仓库物品所在格子=" + value5);
				}
				if (P_0.user.背包数据.仓库列表.TryGetValue(value5, out var value7))
				{
					value7.C7n8ZR5IQ0(value5);
				}
				else
				{
					value7 = new 物品信息类
					{
						Index = value5
					};
					P_0.user.背包数据.仓库列表.TryAdd(value5, value7);
				}
				封包_写3.清数据();
				封包_写3.写短整数型(value6, reverse: true);
				for (int j = 0; j < value6; j++)
				{
					_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass10_0();
					封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out CS_0024_003C_003E8__locals8.nlOTZOVjlE), reverse: true);
					封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value8), reverse: true);
					for (int k = 0; k < value8; k++)
					{
						封包_写3.写字节集(封包_读2.读字节集(2, out byte[] value9), hasCount: false, 0);
						封包_写3.写字节型(封包_读2.读字节型(out var value10));
						short 属性标识 = Singleton<ByteAPI>.I.反转_短整数(value9);
						num = 0;
						num2 = 0;
						num3 = 0;
						empty = string.Empty;
						switch (value10)
						{
						case 1:
							num = 封包_读2.读字节型();
							if (Enumerable.SequenceEqual(value9, Singleton<ByteAPI>.I.HtoC("01B1")))
							{
								value7.装备已进化次数 = num;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 1, 151 }))
							{
								value7.是否绑定 = num >= 3;
								value7.绑定状态 = ((num != 3 && num != 4) ? AllEnums.绑定Type.不绑定 : ((num == 4) ? AllEnums.绑定Type.死绑 : AllEnums.绑定Type.红绑));
							}
							封包_写3.写字节型(num);
							break;
						case 2:
							num2 = 封包_读2.读短整数型(reverse: true);
							if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 203 }))
							{
								value7.数量 = num2;
							}
							封包_写3.写短整数型(num2, reverse: true);
							break;
						case 3:
							num3 = 封包_读2.读整数型(reverse: true);
							if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 84 }))
							{
								value7.物品ID = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 2, 81 }))
							{
								value7.首饰可转换次数 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 2, 71 }))
							{
								value7.首饰已转换次数 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 6 }) && num3 == 999)
							{
								num3 = 0;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 7 }))
							{
								value7.绑定气血 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 10 }))
							{
								value7.装备天伤 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 12 }))
							{
								value7.绑定法力 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 40 }))
							{
								value7.图标 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 42 }))
							{
								value7.当前耐久度 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 43 }))
							{
								value7.最大耐久度 = num3;
							}
							else if (!Enumerable.SequenceEqual(value9, new byte[2] { 0, 206 }) && Enumerable.SequenceEqual(value9, new byte[2] { 0, 208 }))
							{
								value7.改造等级 = num3;
							}
							封包_写3.写整数型(num3, reverse: true);
							break;
						case 4:
							empty = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
							if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 1 }))
							{
								if (CS_0024_003C_003E8__locals8.nlOTZOVjlE == 1)
								{
									value7.名字 = empty;
									value7.前缀 = ((empty.Length > Singleton<全局变量类>.I.config.前缀长度) ? Singleton<ByteAPI>.I.取文本左边(empty, Singleton<全局变量类>.I.config.前缀长度) : string.Empty);
								}
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 1, 55 }))
							{
								value7.单位 = empty;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 1, 8 }))
							{
								value7.描述 = empty;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 89 }))
							{
								value7.改造人 = empty;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 209 }))
							{
								value7.物品颜色 = empty;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 2, 65 }))
							{
								value7.别名 = empty;
							}
							封包_写3.写文本型(empty, hasCount: true, 0, reverse: true);
							break;
						case 6:
							num = 封包_读2.读字节型();
							if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 202 }))
							{
								value7.物品类型 = (byte)num;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 205 }))
							{
								value7.等级 = (byte)num;
							}
							封包_写3.写字节型(num);
							break;
						case 7:
							num2 = 封包_读2.读短整数型(reverse: true);
							封包_写3.写短整数型(num2, reverse: true);
							break;
						}
						if (全局常量类.属性类别组.Any( (int x) => x == CS_0024_003C_003E8__locals8.nlOTZOVjlE))
						{
							switch (value10)
							{
							case 1:
								value7.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.nlOTZOVjlE,
									属性标识 = 属性标识,
									属性数值 = num
								});
								break;
							case 2:
								value7.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.nlOTZOVjlE,
									属性标识 = 属性标识,
									属性数值 = num2
								});
								break;
							case 3:
								value7.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.nlOTZOVjlE,
									属性标识 = 属性标识,
									属性数值 = num3
								});
								break;
							case 6:
								value7.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.nlOTZOVjlE,
									属性标识 = 属性标识,
									属性数值 = num
								});
								break;
							case 7:
								value7.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.nlOTZOVjlE,
									属性标识 = 属性标识,
									属性数值 = num2
								});
								break;
							}
						}
					}
				}
				value7.rgh8r0QQvs(P_0);
				if (rCpfLKhKrZ(P_0, value7))
				{
					value7.封包缓存 = 封包_写3.取数据();
					封包_写3.清数据();
					封包_写3.写入数据(KDQfSpe9nM(P_0, value7.封包缓存, value7), hasCount: false, 0);
				}
				value7.封包缓存 = 封包_写3.取数据();
				封包_写2.写短整数型(value5, reverse: true);
				封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			}
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("接收_仓库响应-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] zw2fMOGq2o(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			int num = 0;
			short num2 = 0;
			int num3 = 0;
			string empty = string.Empty;
			Array.Empty<byte>();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写 封包_写3 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true), reverse: true);
			封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
			封包_写2.写字节型(封包_读2.读字节型(out var value));
			if (全局变量类.Is调试)
			{
				Log.Error("交易物品所在格子=" + value);
			}
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value2), reverse: true);
			物品信息类 物品信息类2 = new 物品信息类
			{
				Index = value,
				摊位价格 = 0
			};
			for (int i = 0; i < value2; i++)
			{
				_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass11_0();
				封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out CS_0024_003C_003E8__locals8.gsqTzXcljJ), reverse: true);
				封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value3), reverse: true);
				for (int j = 0; j < value3; j++)
				{
					封包_写3.写字节集(封包_读2.读字节集(2, out byte[] value4), hasCount: false, 0);
					封包_写3.写字节型(封包_读2.读字节型(out var value5));
					short 属性标识 = Singleton<ByteAPI>.I.反转_短整数(value4);
					num = 0;
					num2 = 0;
					num3 = 0;
					empty = string.Empty;
					switch (value5)
					{
					case 1:
						num = 封包_读2.读字节型();
						if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 177 }))
						{
							物品信息类2.装备已进化次数 = num;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 151 }))
						{
							物品信息类2.是否绑定 = num >= 3;
							物品信息类2.绑定状态 = ((num != 3 && num != 4) ? AllEnums.绑定Type.不绑定 : ((num == 4) ? AllEnums.绑定Type.死绑 : AllEnums.绑定Type.红绑));
						}
						封包_写3.写字节型(num);
						break;
					case 2:
						num2 = 封包_读2.读短整数型(reverse: true);
						if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 203 }))
						{
							物品信息类2.数量 = num2;
						}
						封包_写3.写短整数型(num2, reverse: true);
						break;
					case 3:
						num3 = 封包_读2.读整数型(reverse: true);
						if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 84 }))
						{
							物品信息类2.物品ID = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 2, 81 }))
						{
							物品信息类2.首饰可转换次数 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 2, 71 }))
						{
							物品信息类2.首饰已转换次数 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 6 }) && num3 == 999)
						{
							num3 = 0;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 7 }))
						{
							物品信息类2.绑定气血 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 10 }))
						{
							物品信息类2.装备天伤 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 12 }))
						{
							物品信息类2.绑定法力 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 40 }))
						{
							物品信息类2.图标 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 42 }))
						{
							物品信息类2.当前耐久度 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 43 }))
						{
							物品信息类2.最大耐久度 = num3;
						}
						else if (!Enumerable.SequenceEqual(value4, new byte[2] { 0, 206 }) && Enumerable.SequenceEqual(value4, new byte[2] { 0, 208 }))
						{
							物品信息类2.改造等级 = num3;
						}
						封包_写3.写整数型(num3, reverse: true);
						break;
					case 4:
						empty = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
						if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 1 }))
						{
							if (CS_0024_003C_003E8__locals8.gsqTzXcljJ == 1)
							{
								物品信息类2.名字 = empty;
								物品信息类2.前缀 = ((empty.Length > Singleton<全局变量类>.I.config.前缀长度) ? Singleton<ByteAPI>.I.取文本左边(empty, Singleton<全局变量类>.I.config.前缀长度) : string.Empty);
							}
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 55 }))
						{
							物品信息类2.单位 = empty;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 8 }))
						{
							物品信息类2.描述 = empty;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 89 }))
						{
							物品信息类2.改造人 = empty;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 209 }))
						{
							物品信息类2.物品颜色 = empty;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 2, 65 }))
						{
							物品信息类2.别名 = empty;
						}
						封包_写3.写文本型(empty, hasCount: true, 0, reverse: true);
						break;
					case 6:
						num = 封包_读2.读字节型();
						if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 202 }))
						{
							物品信息类2.物品类型 = (byte)num;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 205 }))
						{
							物品信息类2.等级 = (byte)num;
						}
						封包_写3.写字节型(num);
						break;
					case 7:
						num2 = 封包_读2.读短整数型(reverse: true);
						封包_写3.写短整数型(num2, reverse: true);
						break;
					}
					if (全局常量类.属性类别组.Any( (int x) => x == CS_0024_003C_003E8__locals8.gsqTzXcljJ))
					{
						switch (value5)
						{
						case 1:
							物品信息类2.装备属性列表.Add(new 属性数据
							{
								属性类别 = CS_0024_003C_003E8__locals8.gsqTzXcljJ,
								属性标识 = 属性标识,
								属性数值 = num
							});
							break;
						case 2:
							物品信息类2.装备属性列表.Add(new 属性数据
							{
								属性类别 = CS_0024_003C_003E8__locals8.gsqTzXcljJ,
								属性标识 = 属性标识,
								属性数值 = num2
							});
							break;
						case 3:
							物品信息类2.装备属性列表.Add(new 属性数据
							{
								属性类别 = CS_0024_003C_003E8__locals8.gsqTzXcljJ,
								属性标识 = 属性标识,
								属性数值 = num3
							});
							break;
						case 6:
							物品信息类2.装备属性列表.Add(new 属性数据
							{
								属性类别 = CS_0024_003C_003E8__locals8.gsqTzXcljJ,
								属性标识 = 属性标识,
								属性数值 = num
							});
							break;
						case 7:
							物品信息类2.装备属性列表.Add(new 属性数据
							{
								属性类别 = CS_0024_003C_003E8__locals8.gsqTzXcljJ,
								属性标识 = 属性标识,
								属性数值 = num2
							});
							break;
						}
					}
				}
			}
			物品信息类2.rgh8r0QQvs(P_0);
			if (Singleton<COyX27f6L3uCF3F6Kp5>.I.rCpfLKhKrZ(P_0, 物品信息类2))
			{
				物品信息类2.封包缓存 = 封包_写3.取数据();
				封包_写3.清数据();
				封包_写3.写入数据(Singleton<COyX27f6L3uCF3F6Kp5>.I.KDQfSpe9nM(P_0, 物品信息类2.封包缓存, 物品信息类2), hasCount: false, 0);
			}
			封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("接收_交易背包响应-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] jEffhTTGGK(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			new 封包_写();
			obj.Seek(10L, SeekOrigin.Begin);
			obj.读短整数型(reverse: true);
			obj.读文本型(是否声明长度: true, 0);
			obj.读文本型(是否声明长度: true, 0);
			obj.读字节集(3);
			obj.读整数型(reverse: true, out var value);
			if (value == 0)
			{
				return P_1;
			}
			if (!Singleton<全局变量类>.I.超级道具配置.功能开关 || string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.超级道具配置.禁止商会道具))
			{
				return P_1;
			}
			if (!Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, value))
			{
				return null;
			}
			if (string.IsNullOrWhiteSpace(P_0.user.背包数据.物品列表[value].名字))
			{
				return null;
			}
			if (Singleton<ByteAPI>.I.寻找文本(Singleton<全局变量类>.I.超级道具配置.禁止商会道具, "|" + P_0.user.背包数据.物品列表[value].名字 + "|"))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + P_0.user.背包数据.物品列表[value].名字 + "#n被禁止上架商会！"));
				return null;
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("请求_商会存放-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] EcGfvlEKGn(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			int num = 0;
			short num2 = 0;
			int num3 = 0;
			string empty = string.Empty;
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写字节型(封包_读2.读字节型(out var _));
			封包_写2.写字节型(封包_读2.读字节型(out var _));
			封包_写2.写字节型(封包_读2.读字节型(out var _));
			封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
			封包_写2.写字节型(封包_读2.读字节型(out var _));
			封包_写2.写字节型(封包_读2.读字节型(out var value5));
			封包_写 封包_写3 = new 封包_写();
			物品信息类 物品信息类2 = null;
			for (int i = 0; i < value5; i++)
			{
				封包_写2.写字节型(封包_读2.读字节型(out var value6));
				if (全局变量类.Is调试)
				{
					Log.Error("商会物品所在格子=" + value6);
				}
				封包_写2.写整数型(封包_读2.读整数型(reverse: true), reverse: true);
				封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
				if (物品信息类2 != null)
				{
					物品信息类2.C7n8ZR5IQ0(value6);
				}
				else
				{
					物品信息类2 = new 物品信息类
					{
						Index = value6
					};
				}
				封包_写3.清数据();
				封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value7), reverse: true);
				for (int j = 0; j < value7; j++)
				{
					_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass13_0();
					封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out CS_0024_003C_003E8__locals8.k5N9bI3R5a), reverse: true);
					封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value8), reverse: true);
					for (int k = 0; k < value8; k++)
					{
						封包_写3.写字节集(封包_读2.读字节集(2, out byte[] value9), hasCount: false, 0);
						封包_写3.写字节型(封包_读2.读字节型(out var value10));
						short 属性标识 = Singleton<ByteAPI>.I.反转_短整数(value9);
						num = 0;
						num2 = 0;
						num3 = 0;
						empty = string.Empty;
						switch (value10)
						{
						case 1:
							num = 封包_读2.读字节型();
							if (Enumerable.SequenceEqual(value9, new byte[2] { 1, 177 }))
							{
								物品信息类2.装备已进化次数 = num;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 1, 151 }))
							{
								物品信息类2.是否绑定 = num >= 3;
								物品信息类2.绑定状态 = ((num != 3 && num != 4) ? AllEnums.绑定Type.不绑定 : ((num == 4) ? AllEnums.绑定Type.死绑 : AllEnums.绑定Type.红绑));
							}
							封包_写3.写字节型(num);
							break;
						case 2:
							num2 = 封包_读2.读短整数型(reverse: true);
							if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 203 }))
							{
								物品信息类2.数量 = num2;
							}
							封包_写3.写短整数型(num2, reverse: true);
							break;
						case 3:
							num3 = 封包_读2.读整数型(reverse: true);
							if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 84 }))
							{
								物品信息类2.物品ID = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 2, 81 }))
							{
								物品信息类2.首饰可转换次数 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 2, 71 }))
							{
								物品信息类2.首饰已转换次数 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 6 }) && num3 == 999)
							{
								num3 = 0;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 7 }))
							{
								物品信息类2.绑定气血 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 10 }))
							{
								物品信息类2.装备天伤 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 12 }))
							{
								物品信息类2.绑定法力 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 40 }))
							{
								物品信息类2.图标 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 42 }))
							{
								物品信息类2.当前耐久度 = num3;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 43 }))
							{
								物品信息类2.最大耐久度 = num3;
							}
							else if (!Enumerable.SequenceEqual(value9, new byte[2] { 0, 206 }) && Enumerable.SequenceEqual(value9, new byte[2] { 0, 208 }))
							{
								物品信息类2.改造等级 = num3;
							}
							封包_写3.写整数型(num3, reverse: true);
							break;
						case 4:
							empty = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
							if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 1 }))
							{
								if (CS_0024_003C_003E8__locals8.k5N9bI3R5a == 1)
								{
									物品信息类2.名字 = empty;
									物品信息类2.前缀 = ((empty.Length > Singleton<全局变量类>.I.config.前缀长度) ? Singleton<ByteAPI>.I.取文本左边(empty, Singleton<全局变量类>.I.config.前缀长度) : string.Empty);
								}
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 1, 55 }))
							{
								物品信息类2.单位 = empty;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 1, 8 }))
							{
								物品信息类2.描述 = empty;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 89 }))
							{
								物品信息类2.改造人 = empty;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 209 }))
							{
								物品信息类2.物品颜色 = empty;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 2, 65 }))
							{
								物品信息类2.别名 = empty;
							}
							封包_写3.写文本型(empty, hasCount: true, 0, reverse: true);
							break;
						case 6:
							num = 封包_读2.读字节型();
							if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 202 }))
							{
								物品信息类2.物品类型 = (byte)num;
							}
							else if (Enumerable.SequenceEqual(value9, new byte[2] { 0, 205 }))
							{
								物品信息类2.等级 = (byte)num;
							}
							封包_写3.写字节型(num);
							break;
						case 7:
							num2 = 封包_读2.读短整数型(reverse: true);
							封包_写3.写短整数型(num2, reverse: true);
							break;
						}
						if (全局常量类.属性类别组.Any( (int x) => x == CS_0024_003C_003E8__locals8.k5N9bI3R5a))
						{
							switch (value10)
							{
							case 1:
								物品信息类2.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.k5N9bI3R5a,
									属性标识 = 属性标识,
									属性数值 = num
								});
								break;
							case 2:
								物品信息类2.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.k5N9bI3R5a,
									属性标识 = 属性标识,
									属性数值 = num2
								});
								break;
							case 3:
								物品信息类2.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.k5N9bI3R5a,
									属性标识 = 属性标识,
									属性数值 = num3
								});
								break;
							case 6:
								物品信息类2.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.k5N9bI3R5a,
									属性标识 = 属性标识,
									属性数值 = num
								});
								break;
							case 7:
								物品信息类2.装备属性列表.Add(new 属性数据
								{
									属性类别 = CS_0024_003C_003E8__locals8.k5N9bI3R5a,
									属性标识 = 属性标识,
									属性数值 = num2
								});
								break;
							}
						}
					}
				}
				物品信息类2.rgh8r0QQvs(P_0);
				if (rCpfLKhKrZ(P_0, 物品信息类2))
				{
					物品信息类2.封包缓存 = 封包_写3.取数据();
					封包_写3.清数据();
					封包_写3.写入数据(KDQfSpe9nM(P_0, 物品信息类2.封包缓存, 物品信息类2), hasCount: false, 0);
				}
				封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			}
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("接收_商会背包响应-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] basf7jeST3(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			int num = 封包_读2.读字节型();
			int value = 封包_读2.读字节型();
			if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_0.当前时间字节))
			{
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[num].封包缓存, num));
				return null;
			}
			物品信息类 item = P_0.user.背包数据.物品列表[num];
			AllEnums.元神境界 requirement = ResolveEquipmentRealmRequirement(item);
			item.穿戴要求 = requirement;
			Log.Debug("装备境界校验：角色={Role}，当前境界={CurrentRealm}，装备={Item}，前缀={Prefix}，最大耐久={MaxDurability}，穿戴要求={RequiredRealm}",
				P_0.user.人物数据.昵称, P_0.user.存档数据.元神存档.当前境界, item.名字, item.前缀, item.最大耐久度, requirement);
			if (requirement != AllEnums.元神境界.凡人境 && P_0.user.存档数据.元神存档.当前境界 < requirement)
			{
				byte[] first = Singleton<WdAPI>.I.V8ToFdAZn7(item.封包缓存, num);
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你的境界不足#R");
				defaultInterpolatedStringHandler.AppendFormatted(requirement);
				defaultInterpolatedStringHandler.AppendLiteral("#n，无法穿戴。");
				P_0.C_Send(first.Concat(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
				return null;
			}
			封包_写2.写字节型(num);
			封包_写2.写字节型(value);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("请求_穿戴装备-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] Qjxfao1jQp(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass15_0();
			if (!nZify3Mg0F())
			{
				return P_1;
			}
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_读2.读字节集(2);
			short num = 封包_读2.读短整数型(reverse: true);
			CS_0024_003C_003E8__locals11.Voh9RyYpdV = 封包_读2.读整数型(reverse: true);
			if (封包_读2.读字节型() != 1)
			{
				return P_1;
			}
			switch (num)
			{
			case 1:
			{
				if (!Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, CS_0024_003C_003E8__locals11.Voh9RyYpdV))
				{
					return null;
				}
				if (P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.Voh9RyYpdV] == null || string.IsNullOrWhiteSpace(P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.Voh9RyYpdV].名字))
				{
					return null;
				}
				if (!P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.Voh9RyYpdV].是否绑定 || P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.Voh9RyYpdV].数量 > 1)
				{
					return P_1;
				}
				if (Singleton<全局变量类>.I.config.Is死绑不解 && P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.Voh9RyYpdV].绑定状态 == AllEnums.绑定Type.死绑)
				{
					return P_1;
				}
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 3);
				defaultInterpolatedStringHandler.AppendLiteral("[@确定/道具绑定操作_");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals11.Voh9RyYpdV);
				defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要消耗");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.组装数值类型文本(Singleton<全局变量类>.I.config.解绑类型, Singleton<全局变量类>.I.config.解绑消耗));
				defaultInterpolatedStringHandler.AppendLiteral("立即解除#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.Voh9RyYpdV].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n的绑定吗？]");
				P_0.C_Send(i2.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
				return null;
			}
			case 2:
			{
				宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.ToList().Find( (宠物缓存数据类 a) => a.宠物ID == CS_0024_003C_003E8__locals11.Voh9RyYpdV);
				if (宠物缓存数据类2 == null)
				{
					return null;
				}
				if (宠物缓存数据类2.绑定状态 == AllEnums.绑定Type.不绑定)
				{
					return P_1;
				}
				if (Singleton<全局变量类>.I.config.Is死绑不解 && 宠物缓存数据类2.绑定状态 == AllEnums.绑定Type.死绑)
				{
					return P_1;
				}
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 3);
				defaultInterpolatedStringHandler.AppendLiteral("[@确定/宠物绑定操作_");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals11.Voh9RyYpdV);
				defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要消耗");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.组装数值类型文本(Singleton<全局变量类>.I.config.解绑类型, Singleton<全局变量类>.I.config.解绑消耗));
				defaultInterpolatedStringHandler.AppendLiteral("立即解除#R");
				defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n的绑定吗？]");
				P_0.C_Send(i.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
				return null;
			}
			default:
				return P_1;
			}
		}
		catch (Exception ex)
		{
			Log.Error("组包绑定操作-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal async Task peBfT2qkrC(MyNATSocketClient P_0, bool P_1, int P_2)
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals11.U7p9sQcpbA = P_2;
		try
		{
			if (!nZify3Mg0F())
			{
				return;
			}
			if (P_1)
			{
				if (Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, CS_0024_003C_003E8__locals11.U7p9sQcpbA) && P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.U7p9sQcpbA] != null && !string.IsNullOrWhiteSpace(P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.U7p9sQcpbA].名字) && P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.U7p9sQcpbA].是否绑定 && P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.U7p9sQcpbA].数量 <= 1 && (!Singleton<全局变量类>.I.config.Is死绑不解 || P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.U7p9sQcpbA].绑定状态 != AllEnums.绑定Type.死绑) && await UMrf9Cf13H(P_0, P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.U7p9sQcpbA].名字))
				{
					Singleton<WdAPI>.I.Mr8ICwW3qX(P_0, CS_0024_003C_003E8__locals11.U7p9sQcpbA, "property_bind/attrib", "0");
				}
				return;
			}
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.ToList().Find( (宠物缓存数据类 a) => a.宠物ID == CS_0024_003C_003E8__locals11.U7p9sQcpbA);
			if (宠物缓存数据类2 != null && 宠物缓存数据类2.绑定状态 != AllEnums.绑定Type.不绑定 && (!Singleton<全局变量类>.I.config.Is死绑不解 || 宠物缓存数据类2.绑定状态 != AllEnums.绑定Type.死绑) && await UMrf9Cf13H(P_0, 宠物缓存数据类2.昵称A))
			{
				Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals11.U7p9sQcpbA.ToString(), "property_bind/attrib", "0", "admin_set_attrib");
			}
		}
		catch (Exception ex)
		{
			Log.Error("确定解除绑定操作-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task<bool> UMrf9Cf13H(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (Singleton<全局变量类>.I.config.解绑类型 == AllEnums.数值Type.无 || Singleton<全局变量类>.I.config.解绑消耗 <= 0)
			{
				await Task.Delay(0);
			}
			else
			{
				switch (Singleton<全局变量类>.I.config.解绑类型)
				{
				case AllEnums.数值Type.金元宝:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.背包数据.金元宝 < Singleton<全局变量类>.I.config.解绑消耗)
					{
						WdAPI i3 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的金元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.解绑消耗);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法立即解除#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1);
						defaultInterpolatedStringHandler.AppendLiteral("#n的绑定状态！");
						P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.金元宝, string.Empty, AllEnums.指令Type.无, -Singleton<全局变量类>.I.config.解绑消耗, false, "[解除绑定]消耗");
					WdAPI i4 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.解绑消耗);
					defaultInterpolatedStringHandler.AppendLiteral("#n金元宝解除了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("#n的绑定");
					P_0.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.银元宝:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.背包数据.银元宝 < Singleton<全局变量类>.I.config.解绑消耗)
					{
						WdAPI i11 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的银元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.解绑消耗);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法立即解除#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1);
						defaultInterpolatedStringHandler.AppendLiteral("#n的绑定状态！");
						P_0.C_Send(i11.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.银元宝, string.Empty, AllEnums.指令Type.无, -Singleton<全局变量类>.I.config.解绑消耗, false, "[解除绑定]消耗");
					WdAPI i12 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.解绑消耗);
					defaultInterpolatedStringHandler.AppendLiteral("#n银元宝解除了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("#n的绑定");
					P_0.C_Send(i12.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.金钱:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.背包数据.金钱 < Singleton<全局变量类>.I.config.解绑消耗)
					{
						WdAPI i5 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的金钱不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.config.解绑消耗));
						defaultInterpolatedStringHandler.AppendLiteral("#n文钱，无法立即解除#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1);
						defaultInterpolatedStringHandler.AppendLiteral("#n的绑定状态！");
						P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -Singleton<全局变量类>.I.config.解绑消耗, false, "[解除绑定]消耗");
					WdAPI i6 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.config.解绑消耗));
					defaultInterpolatedStringHandler.AppendLiteral("#n文钱解除了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("#n的绑定");
					P_0.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.声望:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.属性数据.声望 < Singleton<全局变量类>.I.config.解绑消耗)
					{
						WdAPI i9 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的声望不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.解绑消耗);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法立即解除#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1);
						defaultInterpolatedStringHandler.AppendLiteral("#n的绑定状态！");
						P_0.C_Send(i9.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, -Singleton<全局变量类>.I.config.解绑消耗, false, "[解除绑定]消耗");
					WdAPI i10 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.解绑消耗);
					defaultInterpolatedStringHandler.AppendLiteral("#n点声望解除了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("#n的绑定");
					P_0.C_Send(i10.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.累充点:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.存档数据.累计充值金额 < Singleton<全局变量类>.I.config.解绑消耗)
					{
						WdAPI i13 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的累充点不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.解绑消耗);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法立即解除#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1);
						defaultInterpolatedStringHandler.AppendLiteral("#n的绑定状态！");
						P_0.C_Send(i13.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, -Singleton<全局变量类>.I.config.解绑消耗, false, "[解除绑定]消耗");
					WdAPI i14 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.解绑消耗);
					defaultInterpolatedStringHandler.AppendLiteral("#n累充点解除了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("#n的绑定");
					P_0.C_Send(i14.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.南极点:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.存档数据.南极抽奖次数 < Singleton<全局变量类>.I.config.解绑消耗)
					{
						WdAPI i7 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的南极点不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.解绑消耗);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法立即解除#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1);
						defaultInterpolatedStringHandler.AppendLiteral("#n的绑定状态！");
						P_0.C_Send(i7.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, -Singleton<全局变量类>.I.config.解绑消耗, false, "[解除绑定]消耗");
					WdAPI i8 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.解绑消耗);
					defaultInterpolatedStringHandler.AppendLiteral("#n南极点解除了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("#n的绑定");
					P_0.C_Send(i8.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.灵气值:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.存档数据.数值存档.灵气值 < Singleton<全局变量类>.I.config.解绑消耗)
					{
						WdAPI i = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的灵气值不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.解绑消耗);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法立即解除#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1);
						defaultInterpolatedStringHandler.AppendLiteral("#n的绑定状态！");
						P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -Singleton<全局变量类>.I.config.解绑消耗, false, "[解除绑定]消耗");
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.解绑消耗);
					defaultInterpolatedStringHandler.AppendLiteral("#n点灵气解除了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("#n的绑定");
					P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("解除绑定扣除操作-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	public COyX27f6L3uCF3F6Kp5()
	{
	}

	static COyX27f6L3uCF3F6Kp5()
	{
	}
}
