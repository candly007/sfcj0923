using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using B6XRmUwQK7iatdTWLwc;
using LpZ3AarVOTSw8FiAAE;
using Newtonsoft.Json;
using Serilog;
using VcF0pbBvJqp0x0IfwN;
using bDlweAW3n8LaSgX06LQ;
using srBApEg0K2LqE1QaSFj;
using vEAdPGPTkDFOYsbi303;

namespace uI75fJjR7A2e7wWdq9f;

internal class zeYnwTjKgpmAbfSQh5J : Singleton<zeYnwTjKgpmAbfSQh5J>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public string nB2MDSuAC2;

		
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		
		internal bool MlCMgvc4RI(超级道具数据类 a)
		{
			return a.道具名字 == nB2MDSuAC2;
		}

		static _003C_003Ec__DisplayClass11_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public MyNATSocketClient oWXMl6xjNq;

		public int y7hM8Ynokn;

		
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		
		internal void v7MMjQw06O(string v)
		{
			if (v != "轮转玉" && v != "超级轮转玉")
			{
				return;
			}
			oWXMl6xjNq.销毁回调事件 = null;
			if (v == "轮转玉")
			{
				int num = oWXMl6xjNq.user.背包数据.物品列表[y7hM8Ynokn].等级 / 10;
				if (num > 16)
				{
					num = 16;
				}
				问道数据类.所有等级首饰转属次数.TryGetValue(num, out List<int> value);
				if (value.Count <= oWXMl6xjNq.user.背包数据.物品列表[y7hM8Ynokn].首饰可转换次数)
				{
					return;
				}
				int value2 = value[oWXMl6xjNq.user.背包数据.物品列表[y7hM8Ynokn].首饰可转换次数 - oWXMl6xjNq.user.背包数据.物品列表[y7hM8Ynokn].首饰已转换次数 + 1];
				Singleton<WdAPI>.I.Mr8ICwW3qX(oWXMl6xjNq, y7hM8Ynokn, "cvt_chance", $"{value2}");
			}
			else if (v == "超级轮转玉")
			{
				Singleton<WdAPI>.I.Mr8ICwW3qX(oWXMl6xjNq, y7hM8Ynokn, "cvt_chance", "0");
			}
			if (Singleton<全局变量类>.I.验证client.授权配置.IsVip || 全局变量类.Is调试)
			{
				oWXMl6xjNq.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y" + oWXMl6xjNq.user.背包数据.物品列表[y7hM8Ynokn].名字 + "#n的转换次数已经恢复。"));
				return;
			}
			MyNATSocketClient myNATSocketClient = oWXMl6xjNq;
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 2);
			defaultInterpolatedStringHandler.AppendLiteral("你使用了#R");
			defaultInterpolatedStringHandler.AppendFormatted(v);
			defaultInterpolatedStringHandler.AppendLiteral("#n恢复了#R");
			defaultInterpolatedStringHandler.AppendFormatted(oWXMl6xjNq.user.背包数据.物品列表[y7hM8Ynokn].名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n的属性转换次数。为了保证数据安全，游戏将掉线10秒后才可恢复。");
			myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			Singleton<WdAPI>.I.WT9IHmFS6c(oWXMl6xjNq, oWXMl6xjNq.user.人物数据.昵称);
		}

		static _003C_003Ec__DisplayClass15_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public int Hd1Mo0Tb6Q;

		
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		
		internal bool xrMMItfscA(宠物缓存数据类 x)
		{
			if (x.宠物ID != 0)
			{
				return x.宠物ID == Hd1Mo0Tb6Q;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass20_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public List<int> E31MBxwYLV;

		
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		
		internal bool DpYMND4XOh(宠物缓存数据类 x)
		{
			if (x.宠物ID != 0)
			{
				return x.宠物ID == E31MBxwYLV[1];
			}
			return false;
		}

		
		internal bool wEhMiHnSK0(宠物缓存数据类 x)
		{
			if (x.宠物ID != 0)
			{
				return x.宠物ID == E31MBxwYLV[2];
			}
			return false;
		}

		static _003C_003Ec__DisplayClass21_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public int LQtMf6ldJS;

		
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		
		internal bool MkNMG8jNhi(宠物缓存数据类 x)
		{
			if (x.宠物ID != 0)
			{
				return x.宠物ID == LQtMf6ldJS;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass22_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public List<int> fhGMmTqyU6;

		
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		
		internal bool mWrM6FP9cI(宠物缓存数据类 x)
		{
			if (x.宠物ID != 0)
			{
				return x.宠物ID == fhGMmTqyU6[1];
			}
			return false;
		}

		
		internal bool zO7M2ercNq(宠物缓存数据类 x)
		{
			if (x.宠物ID != 0)
			{
				return x.宠物ID == fhGMmTqyU6[2];
			}
			return false;
		}

		static _003C_003Ec__DisplayClass23_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public 超级道具列表配置类 mGDMFjDC7B;

		
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		
		internal bool JARMPHalpp(超级道具数据类 x)
		{
			return x.道具名字 == mGDMFjDC7B.道具唯一名字;
		}

		
		internal bool DVSMXD8rNF(超级道具数据类 a)
		{
			return a.道具名字 == mGDMFjDC7B.道具唯一名字;
		}

		static _003C_003Ec__DisplayClass8_0()
		{
		}
	}

	
	[SpecialName]
	internal static bool ARHjmZgHJU()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is定制道具)
		{
			return Singleton<全局变量类>.I.超级道具配置.定制功能开关;
		}
		return false;
	}

	
	[SpecialName]
	internal static bool OeqjXVCekN()
	{
		if (!全局变量类.Is调试)
		{
			return Singleton<全局变量类>.I.验证client.授权配置.IsLGL定制;
		}
		return true;
	}

	
	internal void y6Bjdh9IFK()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级道具配置类.json")))
			{
				Singleton<全局变量类>.I.超级道具配置.超级道具列表.Clear();
				Singleton<全局变量类>.I.超级道具配置 = JsonConvert.DeserializeObject<超级道具配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级道具配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.超级道具配置 = new 超级道具配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级道具配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级道具配置, Formatting.Indented));
			}
		}
		catch (Exception ex)
		{
			Log.Error("超级道具配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void XZ0jspu4UN()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级道具配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级道具配置, Formatting.Indented));
			Log.Debug("超级道具配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("超级道具配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string xVfjUb6CVC()
	{
		y6Bjdh9IFK();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级道具配置, Formatting.Indented);
	}

	
	public void TAdjWknqoD(string P_0)
	{
		Singleton<全局变量类>.I.超级道具配置 = JsonConvert.DeserializeObject<超级道具配置类>(P_0);
		XZ0jspu4UN();
	}

	
	internal bool GUyjgbITgP(MyNATSocketClient P_0, 超级道具列表配置类 P_1)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals93 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals93.mGDMFjDC7B = P_1;
		try
		{
			if (CS_0024_003C_003E8__locals93.mGDMFjDC7B.最多使用数量 == 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字 + "#n当前已禁止使用！"));
				return false;
			}
			超级道具数据类 超级道具数据类2 = P_0.user.存档数据.超级道具数据.Find( (超级道具数据类 x) => x.道具名字 == CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
			if (超级道具数据类2 != null && CS_0024_003C_003E8__locals93.mGDMFjDC7B.最多使用数量 > 0 && 超级道具数据类2.已用数量 >= CS_0024_003C_003E8__locals93.mGDMFjDC7B.最多使用数量)
			{
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你当前使用的#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n数量已达到#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.最多使用数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n上限，无法再次使用！");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return false;
			}
			if (CS_0024_003C_003E8__locals93.mGDMFjDC7B.is等级开关)
			{
				if (P_0.user.属性数据.等级 < CS_0024_003C_003E8__locals93.mGDMFjDC7B.最低使用等级)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前的等级小于#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.最低使用等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (P_0.user.属性数据.等级 > CS_0024_003C_003E8__locals93.mGDMFjDC7B.最高使用等级)
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前的等级高于#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.最高使用等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
			}
			if (CS_0024_003C_003E8__locals93.mGDMFjDC7B.is道行开关)
			{
				if (P_0.user.属性数据.道行 < CS_0024_003C_003E8__locals93.mGDMFjDC7B.最低使用道行 * 360)
				{
					WdAPI i4 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前的道行小于#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.最低使用道行);
					defaultInterpolatedStringHandler.AppendLiteral("#n年，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (P_0.user.属性数据.道行 > CS_0024_003C_003E8__locals93.mGDMFjDC7B.最高使用道行 * 360)
				{
					WdAPI i5 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前的道行高于#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.最高使用道行);
					defaultInterpolatedStringHandler.AppendLiteral("#n年，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
			}
			if (CS_0024_003C_003E8__locals93.mGDMFjDC7B.is称号开关 && !P_0.user.缓存数据.所有称号文本.ToString().Contains("|" + CS_0024_003C_003E8__locals93.mGDMFjDC7B.指定称号使用 + "|", StringComparison.CurrentCulture))
			{
				WdAPI i6 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你当前并未拥有#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.指定称号使用);
				defaultInterpolatedStringHandler.AppendLiteral("#n称号，无法使用#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n！");
				P_0.C_Send(i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return false;
			}
			if (!CS_0024_003C_003E8__locals93.mGDMFjDC7B.is重置累计)
			{
				超级道具数据类 超级道具数据类3 = P_0.user.存档数据.超级道具数据.Find( (超级道具数据类 a) => a.道具名字 == CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
				if (超级道具数据类3 != null)
				{
					List<超级道具累计奖励类> 累计奖励列表 = CS_0024_003C_003E8__locals93.mGDMFjDC7B.累计奖励列表;
					if (累计奖励列表 != null && 累计奖励列表.Count > 0 && 超级道具数据类3.累计领取 >= CS_0024_003C_003E8__locals93.mGDMFjDC7B.累计奖励列表[CS_0024_003C_003E8__locals93.mGDMFjDC7B.累计奖励列表.Count - 1].最低累计)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前领取了#R" + CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字 + "#n的所有累计使用奖励，无法再次使用！"));
						return false;
					}
				}
			}
			if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容) && CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗类型 != AllEnums.数值Type.无)
			{
				switch (CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗类型)
				{
				case AllEnums.数值Type.金元宝:
				{
					if (!int.TryParse(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容, out var result12))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("超级道具配置有误，无法使用！"));
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.背包数据.金元宝 < result12)
					{
						WdAPI i32 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的金元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法使用#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i32.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (!DB.I.cAJNoOkab6(P_0, -result12, 0))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前的金元宝扣除失败，无法使用#R" + CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字 + "#n！"));
						return false;
					}
					WdAPI i33 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(result12);
					defaultInterpolatedStringHandler.AppendLiteral("#n金元宝打开了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					P_0.C_Send(i33.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.银元宝:
				{
					if (!int.TryParse(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容, out var result5))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("超级道具配置有误，无法使用！"));
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.背包数据.银元宝 < result5)
					{
						WdAPI i18 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的银元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法使用#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i18.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (!DB.I.cAJNoOkab6(P_0, 0, -result5))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前的银元宝扣除失败，无法使用#R" + CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字 + "#n！"));
						return false;
					}
					WdAPI i19 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(result5);
					defaultInterpolatedStringHandler.AppendLiteral("#n银元宝打开了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					P_0.C_Send(i19.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.金钱:
				{
					if (!int.TryParse(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容, out var result))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("超级道具配置有误，无法使用！"));
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.背包数据.金钱 < result)
					{
						WdAPI i9 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的金钱不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(result));
						defaultInterpolatedStringHandler.AppendLiteral("#n文钱，无法使用#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i9.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -result, false, "[礼包]消耗");
					WdAPI i10 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(result));
					defaultInterpolatedStringHandler.AppendLiteral("#n文钱打开了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					P_0.C_Send(i10.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.声望:
				{
					if (!int.TryParse(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容, out var result10))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("超级道具配置有误，无法使用！"));
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.属性数据.声望 < result10)
					{
						WdAPI i28 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的声望不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法使用#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i28.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, -result10, false, "[礼包]消耗");
					WdAPI i29 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(result10);
					defaultInterpolatedStringHandler.AppendLiteral("#n点声望打开了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					P_0.C_Send(i29.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.战绩:
				{
					if (!int.TryParse(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容, out var result6))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("超级道具配置有误，无法使用！"));
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.属性数据.战绩 < result6)
					{
						WdAPI i20 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的战绩不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法使用#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i20.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.total_score, -result6, false, "[礼包]消耗");
					WdAPI i21 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(result6);
					defaultInterpolatedStringHandler.AppendLiteral("#n点战绩打开了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					P_0.C_Send(i21.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.经验:
				{
					if (!int.TryParse(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容, out var result7))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("超级道具配置有误，无法使用！"));
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.属性数据.经验 < result7)
					{
						WdAPI i22 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的经验不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法使用#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i22.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.exp, -result7, false, "[礼包]消耗");
					WdAPI i23 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(result7);
					defaultInterpolatedStringHandler.AppendLiteral("#n点经验打开了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					P_0.C_Send(i23.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.等级:
				{
					if (!int.TryParse(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容, out var result11))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("超级道具配置有误，无法使用！"));
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.属性数据.等级 < result11)
					{
						WdAPI i30 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的等级不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n级，无法使用#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i30.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.level, -result11, false, "[礼包]消耗");
					WdAPI i31 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的等级#R-");
					defaultInterpolatedStringHandler.AppendFormatted(result11);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，打开了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					P_0.C_Send(i31.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.道行:
				{
					if (!int.TryParse(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容, out var result3))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("超级道具配置有误，无法使用！"));
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.属性数据.道行 < result3 * 360)
					{
						WdAPI i14 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的道行不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n年，无法使用#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i14.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, -(result3 * 360), false, "[礼包]消耗");
					WdAPI i15 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(result3);
					defaultInterpolatedStringHandler.AppendLiteral("#n年道行打开了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					P_0.C_Send(i15.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.体力:
				{
					if (!int.TryParse(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容, out var result8))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("超级道具配置有误，无法使用！"));
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.属性数据.当前体力 < result8)
					{
						WdAPI i24 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的体力不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法使用#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i24.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.stamina, -result8, false, "[礼包]消耗");
					WdAPI i25 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(result8);
					defaultInterpolatedStringHandler.AppendLiteral("#n点体力打开了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					P_0.C_Send(i25.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.累充点:
				{
					if (!int.TryParse(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容, out var result2))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("超级道具配置有误，无法使用！"));
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.存档数据.累计充值金额 < result2)
					{
						WdAPI i11 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的累充点不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法使用#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i11.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					WdAPI i12 = Singleton<WdAPI>.I;
					string empty = string.Empty;
					int num = -result2;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(result2);
					defaultInterpolatedStringHandler.AppendLiteral("#n点累充点打开了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					i12.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, empty, AllEnums.指令Type.无, num, false, defaultInterpolatedStringHandler.ToStringAndClear());
					WdAPI i13 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(result2);
					defaultInterpolatedStringHandler.AppendLiteral("#n点累充点打开了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					P_0.C_Send(i13.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.南极点:
				{
					if (!int.TryParse(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容, out var result9))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("超级道具配置有误，无法使用！"));
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.存档数据.南极抽奖次数 < result9)
					{
						WdAPI i26 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的南极点不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法使用#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i26.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, -result9, false, "打开[" + CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字 + "]消耗");
					WdAPI i27 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(result9);
					defaultInterpolatedStringHandler.AppendLiteral("#n点南极点打开了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					P_0.C_Send(i27.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.灵气值:
				{
					if (!int.TryParse(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容, out var result4))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("超级道具配置有误，无法使用！"));
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.存档数据.数值存档.灵气值 < result4)
					{
						WdAPI i16 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前的灵气值不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法使用#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i16.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -result4, false, "打开[" + CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字 + "]消耗");
					WdAPI i17 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(result4);
					defaultInterpolatedStringHandler.AppendLiteral("#n点灵气值打开了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					P_0.C_Send(i17.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.道具:
					if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容))
					{
						物品信息类 物品信息类2 = Singleton<WdAPI>.I.取背包物品格子实例(P_0, CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
						if (物品信息类2 == null)
						{
							WdAPI i7 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
							defaultInterpolatedStringHandler.AppendLiteral("你当前的背包中没有#R");
							defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
							defaultInterpolatedStringHandler.AppendLiteral("#n消耗品，无法使用#R");
							defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
							defaultInterpolatedStringHandler.AppendLiteral("#n！");
							P_0.C_Send(i7.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return false;
						}
						Singleton<WdAPI>.I.UH7oscwt9s(P_0, 物品信息类2.Index);
						WdAPI i8 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具消耗内容);
						defaultInterpolatedStringHandler.AppendLiteral("×1#n打开了#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals93.mGDMFjDC7B.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n");
						P_0.C_Send(i8.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					break;
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("超级道具使用前校验-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal void aEOjDQKDSy(MyNATSocketClient P_0, string P_1)
	{
		if (P_0.user.缓存数据.is使用仙灵卡)
		{
			return;
		}
		try
		{
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.在线泡点配置.泡点道具) && P_1 == Singleton<全局变量类>.I.在线泡点配置.泡点道具)
			{
				P_0.user.存档数据.is使用新手大礼包 = true;
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("恭喜你使用了#Y" + Singleton<全局变量类>.I.在线泡点配置.泡点道具 + "#n，在本服#Y一线#n的#Y天上集市#n自动摆摊后享有#Y双倍泡点#n的福利。"));
			}
			if (Singleton<全局变量类>.I.自选道具配置.功能开关 && string.IsNullOrWhiteSpace(P_0.user.缓存数据.自选道具) && Singleton<全局变量类>.I.自选道具配置.自选道具列表.TryGetValue(P_1, out 自选道具列表类 value))
			{
				Singleton<RdU9KHgkxD6vGY8ZRKE>.I.CGqgYXA10I(P_0, value);
			}
			else if (P_1 == "凤仙花")
			{
				P_0.user.存档数据.凤仙花数量++;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(55, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你已经累积获得#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.凤仙花数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n朵#R凤仙花#n！快去找#P妙妙仙子#P#Z天墉城(238,215)#Z进行坐姿染色吧！");
				byte[] first = i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear());
				WdAPI i2 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(55, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你已经累积获得#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.凤仙花数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n朵#R凤仙花#n！快去找#P妙妙仙子#P#Z天墉城(238,215)#Z进行坐姿染色吧！");
				P_0.C_Send(first.Concat(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
			}
			else if (P_1 == "五系娃娃召唤令")
			{
				jVjj8u1vwO(P_0, P_1).Wait();
			}
			else if (FcVoHRwOVsflDmDUQOP.JhVwZ5yCsf() && P_1.StartsWith("锁麟囊·"))
			{
				Singleton<FcVoHRwOVsflDmDUQOP>.I.ClGw4qKbEV(P_0, P_1);
			}
			else if (Singleton<全局变量类>.I.超级道具配置.功能开关 && Singleton<全局变量类>.I.超级道具配置.超级道具列表.ContainsKey(P_1))
			{
				lk1jjtmDp8(P_0, P_1);
			}
			else if (Singleton<全局变量类>.I.盲盒配置.功能开关 && Singleton<全局变量类>.I.盲盒配置.盲盒列表.ContainsKey(P_1))
			{
				Singleton<xKp3aGWENEfI6KIHVKi>.I.jnBWr3icOw(P_0, P_1);
			}
			else if (Singleton<全局变量类>.I.礼包飘屏配置.功能开关 && Singleton<全局变量类>.I.礼包飘屏配置.礼包列表.ContainsKey(P_1))
			{
				Singleton<xKp3aGWENEfI6KIHVKi>.I.c7OWZ5ebsQ(P_0, P_1);
			}
			else if (Singleton<全局变量类>.I.礼包开元宝配置.功能开关 && Singleton<全局变量类>.I.礼包开元宝配置.礼包列表.ContainsKey(P_1))
			{
				Singleton<WI2SZ8qRj7MBmbqI09>.I.J1Twu0eM9a(P_0, P_1);
			}
		}
		catch (Exception ex)
		{
			Log.Error("接收_道具使用事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public void 自动使用道具处理(MyNATSocketClient myclient, string value)
	{
		try
		{
			if (myclient.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			int num = Singleton<WdAPI>.I.取背包物品格子(myclient, value);
			if (myclient.user.背包数据.物品列表[num] != null && Singleton<WdAPI>.I.QSgoJ8DvVe(myclient, num))
			{
				for (int i = 0; i < myclient.user.背包数据.物品列表[num].数量; i++)
				{
					myclient.S_Send(Singleton<WdAPI>.I.naeodnd6MY(num), "自动使用道具处理");
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("自动使用道具处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void lk1jjtmDp8(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals4.nB2MDSuAC2 = P_1;
		try
		{
			if (!Singleton<全局变量类>.I.超级道具配置.超级道具列表.TryGetValue(CS_0024_003C_003E8__locals4.nB2MDSuAC2, out 超级道具列表配置类 value))
			{
				return;
			}
			超级道具数据类 超级道具数据类2 = P_0.user.存档数据.超级道具数据.Find( (超级道具数据类 a) => a.道具名字 == CS_0024_003C_003E8__locals4.nB2MDSuAC2);
			if (超级道具数据类2 == null)
			{
				超级道具数据类2 = new 超级道具数据类
				{
					道具名字 = CS_0024_003C_003E8__locals4.nB2MDSuAC2,
					已用数量 = 1,
					累计领取 = 0,
					加成属性 = value.额外奖励类型,
					附加属性类型 = value.附加属性类型
				};
				P_0.user.存档数据.超级道具数据.Add(超级道具数据类2);
			}
			else
			{
				超级道具数据类2.已用数量++;
			}
			if (value.is奖励开关 && value.最低奖励下限 != 0 && value.最高奖励上限 >= value.最低奖励下限 && value.获得几率 > 0)
			{
				if (ARHjmZgHJU() && value.附加属性类型 != AllEnums.属性名字Type.无)
				{
					int num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
					if (value.获得几率 >= num)
					{
						int num2 = Singleton<WdAPI>.I.qrjo9TWIdy(value.最低奖励下限, value.最高奖励上限);
						if (value.附加属性限时 > 0)
						{
							if (!P_0.user.存档数据.中州论道存档.限时属性列表.ContainsKey(value.附加属性类型))
							{
								P_0.user.存档数据.中州论道存档.jxpIgn1imh(value.附加属性类型, num2, out var text);
								Singleton<fuMNpgieFTYU3Wah53>.I.KIdmWo2NZ(P_0, value.附加属性类型, text.ToString());
								WdAPI i = Singleton<WdAPI>.I;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 5);
								defaultInterpolatedStringHandler.AppendLiteral("你使用了#R");
								defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
								defaultInterpolatedStringHandler.AppendLiteral("#n获得了#Y");
								defaultInterpolatedStringHandler.AppendFormatted(value.附加属性类型);
								defaultInterpolatedStringHandler.AppendLiteral("#n+#Y");
								defaultInterpolatedStringHandler.AppendFormatted(num2);
								defaultInterpolatedStringHandler.AppendFormatted(问道数据类.Add属性名字后缀(value.附加属性类型));
								defaultInterpolatedStringHandler.AppendLiteral("#n的提升，持续#R");
								defaultInterpolatedStringHandler.AppendFormatted(value.附加属性限时);
								defaultInterpolatedStringHandler.AppendLiteral("#n分钟。");
								P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
							}
							else
							{
								WdAPI i2 = Singleton<WdAPI>.I;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 3);
								defaultInterpolatedStringHandler.AppendLiteral("你使用了#R");
								defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
								defaultInterpolatedStringHandler.AppendLiteral("#n，由于你身上已经存在限时的#Y");
								defaultInterpolatedStringHandler.AppendFormatted(value.附加属性类型);
								defaultInterpolatedStringHandler.AppendLiteral("#n提升效果，效果持续时间增加#R");
								defaultInterpolatedStringHandler.AppendFormatted(value.附加属性限时);
								defaultInterpolatedStringHandler.AppendLiteral("#n分钟。");
								P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
							}
							P_0.user.存档数据.中州论道存档.T4pIDVRjDx(value.附加属性类型, num2, value.附加属性限时);
						}
						else
						{
							超级道具数据类2.加成数值 += num2;
							P_0.user.存档数据.中州论道存档.jxpIgn1imh(value.附加属性类型, num2, out var text2);
							Singleton<fuMNpgieFTYU3Wah53>.I.KIdmWo2NZ(P_0, value.附加属性类型, text2.ToString());
							WdAPI i3 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 4);
							defaultInterpolatedStringHandler.AppendLiteral("你使用了#R");
							defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
							defaultInterpolatedStringHandler.AppendLiteral("#n获得了#Y");
							defaultInterpolatedStringHandler.AppendFormatted(value.附加属性类型);
							defaultInterpolatedStringHandler.AppendLiteral("#n+#Y");
							defaultInterpolatedStringHandler.AppendFormatted(num2);
							defaultInterpolatedStringHandler.AppendFormatted(问道数据类.Add属性名字后缀(value.附加属性类型));
							defaultInterpolatedStringHandler.AppendLiteral("#n的提升。");
							P_0.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						}
					}
					else
					{
						超级道具数据类2.已用数量--;
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("很遗憾，你未从#R" + value.道具唯一名字 + "#n中获得属性提升。"));
					}
				}
				if (value.额外奖励类型 != AllEnums.数值Type.无)
				{
					int num3 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
					if (value.获得几率 >= num3)
					{
						int num4 = Singleton<WdAPI>.I.qrjo9TWIdy(value.最低奖励下限, value.最高奖励上限);
						switch (value.额外奖励类型)
						{
						case AllEnums.数值Type.金元宝:
							if (DB.I.cAJNoOkab6(P_0, num4, 0))
							{
								WdAPI i10 = Singleton<WdAPI>.I;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
								defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
								defaultInterpolatedStringHandler.AppendFormatted(num4);
								defaultInterpolatedStringHandler.AppendLiteral("#n金元宝奖励。");
								P_0.C_Send(i10.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
							}
							break;
						case AllEnums.数值Type.银元宝:
							if (DB.I.cAJNoOkab6(P_0, 0, num4))
							{
								WdAPI i9 = Singleton<WdAPI>.I;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
								defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
								defaultInterpolatedStringHandler.AppendFormatted(num4);
								defaultInterpolatedStringHandler.AppendLiteral("#n银元宝奖励。");
								P_0.C_Send(i9.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
							}
							break;
						case AllEnums.数值Type.累充点:
						{
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, num4, false, "打开[" + value.道具唯一名字 + "]获得");
							WdAPI i8 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
							defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
							defaultInterpolatedStringHandler.AppendFormatted(num4);
							defaultInterpolatedStringHandler.AppendLiteral("#n累充点奖励。");
							P_0.C_Send(i8.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
							break;
						}
						case AllEnums.数值Type.南极点:
						{
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, num4, false, "打开[" + value.道具唯一名字 + "]获得");
							WdAPI i7 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
							defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
							defaultInterpolatedStringHandler.AppendFormatted(num4);
							defaultInterpolatedStringHandler.AppendLiteral("#n次南极抽奖次数。");
							P_0.C_Send(i7.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
							break;
						}
						case AllEnums.数值Type.体力:
						{
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.stamina, num4, false, "[礼包]获得");
							WdAPI i6 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
							defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
							defaultInterpolatedStringHandler.AppendFormatted(num4);
							defaultInterpolatedStringHandler.AppendLiteral("#n点体力。");
							P_0.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
							break;
						}
						case AllEnums.数值Type.奇宝点:
						{
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, num4, false, "[" + value.道具唯一名字 + "]打开获得");
							WdAPI i5 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
							defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
							defaultInterpolatedStringHandler.AppendFormatted(num4);
							defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点。");
							P_0.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
							break;
						}
						case AllEnums.数值Type.论道点:
						{
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.论道点, string.Empty, AllEnums.指令Type.无, num4, false, "[" + value.道具唯一名字 + "]打开获得");
							WdAPI i4 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
							defaultInterpolatedStringHandler.AppendLiteral("你获得了#Y");
							defaultInterpolatedStringHandler.AppendFormatted(num4);
							defaultInterpolatedStringHandler.AppendLiteral("#n论道点。");
							P_0.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
							break;
						}
						}
					}
					else
					{
						超级道具数据类2.已用数量--;
					}
				}
			}
			if (!value.is累计开关 || value.累计奖励列表.Count <= 0)
			{
				return;
			}
			if (value.is重置累计)
			{
				int num5 = (value.累计奖励列表[0].最低累计 + value.累计奖励列表[0].最高累计) / 2;
				int num6 = Singleton<WdAPI>.I.qrjo9TWIdy(num5, value.累计奖励列表[0].最高累计);
				if (超级道具数据类2.已用数量 >= num6)
				{
					switch (value.累计奖励列表[0].奖励类型)
					{
					case AllEnums.数值Type.金元宝:
						if (DB.I.cAJNoOkab6(P_0, int.Parse(value.累计奖励列表[0].奖励内容), 0))
						{
							WdAPI i12 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
							defaultInterpolatedStringHandler.AppendLiteral("恭喜你，累计使用了#Y ");
							defaultInterpolatedStringHandler.AppendFormatted(超级道具数据类2.已用数量);
							defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
							defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
							defaultInterpolatedStringHandler.AppendLiteral("#n，获得了#Y");
							defaultInterpolatedStringHandler.AppendFormatted(value.累计奖励列表[0].奖励内容);
							defaultInterpolatedStringHandler.AppendLiteral("#n金元宝奖励。");
							byte[] first = i12.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear());
							WdAPI i13 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
							defaultInterpolatedStringHandler.AppendLiteral("恭喜你，累计使用了#Y ");
							defaultInterpolatedStringHandler.AppendFormatted(超级道具数据类2.已用数量);
							defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
							defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
							defaultInterpolatedStringHandler.AppendLiteral("#n，获得了#Y");
							defaultInterpolatedStringHandler.AppendFormatted(value.累计奖励列表[0].奖励内容);
							defaultInterpolatedStringHandler.AppendLiteral("#n金元宝奖励。");
							P_0.C_Send(first.Concat(i13.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
						}
						break;
					case AllEnums.数值Type.银元宝:
						if (DB.I.cAJNoOkab6(P_0, 0, int.Parse(value.累计奖励列表[0].奖励内容)))
						{
							WdAPI i14 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
							defaultInterpolatedStringHandler.AppendLiteral("恭喜你，累计使用了#Y ");
							defaultInterpolatedStringHandler.AppendFormatted(超级道具数据类2.已用数量);
							defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
							defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
							defaultInterpolatedStringHandler.AppendLiteral("#n，获得了#Y");
							defaultInterpolatedStringHandler.AppendFormatted(value.累计奖励列表[0].奖励内容);
							defaultInterpolatedStringHandler.AppendLiteral("#n银元宝奖励。");
							byte[] first2 = i14.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear());
							WdAPI i15 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
							defaultInterpolatedStringHandler.AppendLiteral("恭喜你，累计使用了#Y ");
							defaultInterpolatedStringHandler.AppendFormatted(超级道具数据类2.已用数量);
							defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
							defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
							defaultInterpolatedStringHandler.AppendLiteral("#n，获得了#Y");
							defaultInterpolatedStringHandler.AppendFormatted(value.累计奖励列表[0].奖励内容);
							defaultInterpolatedStringHandler.AppendLiteral("#n银元宝奖励。");
							P_0.C_Send(first2.Concat(i15.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
						}
						break;
					case AllEnums.数值Type.道具:
						if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, value.累计奖励列表[0].奖励内容, AllEnums.指令Type.无, 1, false, "超级道具累计奖励"))
						{
							WdAPI i11 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 3);
							defaultInterpolatedStringHandler.AppendLiteral("恭喜你，累计使用了#Y ");
							defaultInterpolatedStringHandler.AppendFormatted(超级道具数据类2.已用数量);
							defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
							defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
							defaultInterpolatedStringHandler.AppendLiteral("#n，获得了#Y");
							defaultInterpolatedStringHandler.AppendFormatted(value.累计奖励列表[0].奖励内容);
							defaultInterpolatedStringHandler.AppendLiteral("#n奖励。");
							P_0.C_Send(i11.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						}
						break;
					}
					超级道具数据类2.已用数量 = 0;
					超级道具数据类2.累计领取 = 0;
					超级道具数据类2.道具名字 = string.Empty;
				}
				else
				{
					WdAPI i16 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(60, 6);
					defaultInterpolatedStringHandler.AppendLiteral("加油，你离奖励又近了一步！#r累计使用了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(超级道具数据类2.已用数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
					defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n，累计达到当前阶段#Y ");
					defaultInterpolatedStringHandler.AppendFormatted(value.累计奖励列表[0].最低累计);
					defaultInterpolatedStringHandler.AppendLiteral(" - ");
					defaultInterpolatedStringHandler.AppendFormatted(value.累计奖励列表[0].最高累计);
					defaultInterpolatedStringHandler.AppendLiteral("#n时，有几率获得#Y");
					defaultInterpolatedStringHandler.AppendFormatted(value.累计奖励列表[0].奖励内容);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(value.累计奖励列表[0].奖励类型);
					defaultInterpolatedStringHandler.AppendLiteral("奖励！");
					P_0.C_Send(i16.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("加油,你离奖励又近了一步，累计使用数量越多获取奖励的几率越高！")).ToArray());
				}
				return;
			}
			超级道具累计奖励类 超级道具累计奖励类2 = null;
			if (超级道具数据类2.累计领取 == 0)
			{
				超级道具累计奖励类2 = value.累计奖励列表[0];
			}
			else
			{
				foreach (超级道具累计奖励类 item in value.累计奖励列表)
				{
					if (超级道具数据类2.累计领取 < item.最低累计 && 超级道具数据类2.已用数量 >= item.最低累计 && 超级道具数据类2.已用数量 <= item.最高累计)
					{
						超级道具累计奖励类2 = item;
						break;
					}
				}
			}
			if (超级道具累计奖励类2 == null)
			{
				WdAPI i17 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 2);
				defaultInterpolatedStringHandler.AppendLiteral("加油，你离奖励又近了一步！#r累计使用了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(超级道具数据类2.已用数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
				defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n，累计使用数量越多获取奖励的几率越高！");
				P_0.C_Send(i17.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("加油,你离奖励又近了一步，累计使用数量越多获取奖励的几率越高！")).ToArray());
				return;
			}
			int num7 = (超级道具累计奖励类2.最低累计 + 超级道具累计奖励类2.最高累计) / 2;
			int num8 = Singleton<WdAPI>.I.qrjo9TWIdy(num7, 超级道具累计奖励类2.最高累计);
			if (超级道具数据类2.已用数量 >= num8)
			{
				超级道具数据类2.累计领取 = 超级道具累计奖励类2.最低累计;
				switch (超级道具累计奖励类2.奖励类型)
				{
				case AllEnums.数值Type.金元宝:
					if (DB.I.cAJNoOkab6(P_0, int.Parse(超级道具累计奖励类2.奖励内容), 0))
					{
						WdAPI i19 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你，累计使用了#Y ");
						defaultInterpolatedStringHandler.AppendFormatted(超级道具数据类2.已用数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
						defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n，获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(超级道具累计奖励类2.奖励内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n金元宝奖励。");
						byte[] first3 = i19.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear());
						WdAPI i20 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你，累计使用了#Y ");
						defaultInterpolatedStringHandler.AppendFormatted(超级道具数据类2.已用数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
						defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n，获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(超级道具累计奖励类2.奖励内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n金元宝奖励。");
						P_0.C_Send(first3.Concat(i20.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
					}
					break;
				case AllEnums.数值Type.银元宝:
					if (DB.I.cAJNoOkab6(P_0, 0, int.Parse(超级道具累计奖励类2.奖励内容)))
					{
						WdAPI i21 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你，累计使用了#Y ");
						defaultInterpolatedStringHandler.AppendFormatted(超级道具数据类2.已用数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
						defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n，获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(超级道具累计奖励类2.奖励内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n银元宝奖励。");
						byte[] first4 = i21.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear());
						WdAPI i22 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你，累计使用了#Y ");
						defaultInterpolatedStringHandler.AppendFormatted(超级道具数据类2.已用数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
						defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n，获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(超级道具累计奖励类2.奖励内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n银元宝奖励。");
						P_0.C_Send(first4.Concat(i22.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
					}
					break;
				case AllEnums.数值Type.道具:
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 超级道具累计奖励类2.奖励内容, AllEnums.指令Type.无, 1, false, "超级道具累计奖励"))
					{
						WdAPI i18 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 3);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你，累计使用了#Y ");
						defaultInterpolatedStringHandler.AppendFormatted(超级道具数据类2.已用数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
						defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n，获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(超级道具累计奖励类2.奖励内容);
						defaultInterpolatedStringHandler.AppendLiteral("#n奖励。");
						P_0.C_Send(i18.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					break;
				case AllEnums.数值Type.金钱:
				case AllEnums.数值Type.累充点:
					break;
				}
			}
			else
			{
				WdAPI i23 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(60, 6);
				defaultInterpolatedStringHandler.AppendLiteral("加油，你离奖励又近了一步！#r累计使用了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(超级道具数据类2.已用数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
				defaultInterpolatedStringHandler.AppendFormatted(value.道具唯一名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n，累计达到当前阶段#Y ");
				defaultInterpolatedStringHandler.AppendFormatted(超级道具累计奖励类2.最低累计);
				defaultInterpolatedStringHandler.AppendLiteral(" - ");
				defaultInterpolatedStringHandler.AppendFormatted(超级道具累计奖励类2.最高累计);
				defaultInterpolatedStringHandler.AppendLiteral("#n时，有几率获得#Y");
				defaultInterpolatedStringHandler.AppendFormatted(超级道具累计奖励类2.奖励内容);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				defaultInterpolatedStringHandler.AppendFormatted(超级道具累计奖励类2.奖励类型);
				defaultInterpolatedStringHandler.AppendLiteral("奖励！");
				P_0.C_Send(i23.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_杂项公告("加油,你离奖励又近了一步，累计使用数量越多获取奖励的几率越高！")).ToArray());
			}
		}
		catch (Exception ex)
		{
			Log.Error("打开超级道具处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void unmjl17DQY(MyNATSocketClient P_0)
	{
		try
		{
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder("超级天星石可为你背包中的进化等级#Y≥19级#n的装备进行超级进化#r#Y注意事项：（被超级进化的装备必须低于自身等级，未进化到19级上限的装备使用超级进化将无效）#r#R请注意：#n（如果本次不转换请点击#G我再考虑考虑#n，#R否则超级天星石可能会直接消失#n）[DEFAULT/DEFAULT]");
			for (int i = 1; i <= 200; i++)
			{
				物品信息类 物品信息类2 = P_0.user.背包数据.物品列表[i];
				if (物品信息类2 != null && !string.IsNullOrWhiteSpace(物品信息类2.名字) && 物品信息类2.装备已进化次数 == 19)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(26, 3, stringBuilder2);
					handler.AppendLiteral("[背包位置：【");
					handler.AppendFormatted(i);
					handler.AppendLiteral("】 装备名字：【");
					handler.AppendFormatted(物品信息类2.名字);
					handler.AppendLiteral("】/使用超级天星石_");
					handler.AppendFormatted(i);
					handler.AppendLiteral("]");
					stringBuilder2.Append(ref handler);
				}
			}
			stringBuilder.Append("[我再考虑考虑/使用超级天星石_取消使用]");
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, P_0.user.人物数据.形象ID, P_0.user.人物数据.昵称, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("使用超级天星石弹出对话-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public async Task jVjj8u1vwO(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			int 临时GID = P_0.user.人物数据.GID;
			string 当前角色账号 = P_0.user.人物数据.账号;
			string 当前角色昵称 = P_0.user.人物数据.昵称;
			int 当前角色等级 = P_0.user.属性数据.等级;
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你使用了#R" + P_1 + "#n获得了一个拥有五系技能的强力娃娃。为了保证数据安全，游戏将掉线10秒后才可恢复。"));
			if (!DB.I.锁定账号操作(当前角色账号, "1"))
			{
				Log.Error("发送五系娃娃处理-错误：账号锁定失败");
				return;
			}
			Singleton<WdAPI>.I.WT9IHmFS6c(P_0, 当前角色昵称);
			await Task.Delay(5000);
			DB.I.Mysql_发送五系娃娃处理(临时GID, 当前角色账号, 当前角色昵称, 当前角色等级);
		}
		catch (Exception ex)
		{
			Log.Error("发送五系娃娃处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal bool C2fjIBxJ1T(MyNATSocketClient P_0, byte P_1, byte P_2)
	{
		if (((Singleton<全局变量类>.I.config.is轮转玉 && P_0.user.背包数据.物品列表[P_1].名字 == "轮转玉") || (Singleton<全局变量类>.I.config.is超级轮转玉 && P_0.user.背包数据.物品列表[P_1].名字 == "超级轮转玉")) && P_0.user.背包数据.物品列表[P_2].首饰可转换次数 != 0 && P_0.user.背包数据.物品列表[P_2].首饰已转换次数 != 0 && P_0.user.背包数据.物品列表[P_2].首饰可转换次数 >= P_0.user.背包数据.物品列表[P_2].首饰已转换次数)
		{
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return false;
			}
			int value = ((!(P_0.user.背包数据.物品列表[P_1].名字 == "超级轮转玉")) ? 1 : P_0.user.背包数据.物品列表[P_2].首饰已转换次数);
			P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_1].封包缓存, P_1).Concat(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_2].封包缓存, P_2)).ToArray());
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(57, 5);
			defaultInterpolatedStringHandler.AppendLiteral("[@确定/使用轮转玉_");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要使用#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_1].名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n恢复#R");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("#n次#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n的属性转换次数吗？]");
			P_0.C_Send(i.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
			return true;
		}
		return false;
	}

	
	internal void 请求_轮转玉事件处理(MyNATSocketClient myclient, string value)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals36 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals36.oWXMl6xjNq = myclient;
		try
		{
			CS_0024_003C_003E8__locals36.oWXMl6xjNq.user.缓存数据.自选道具 = string.Empty;
			string[] array = value.Replace("使用轮转玉_", "").Split("|");
			if (!int.TryParse(array[0], out var result) || !int.TryParse(array[1], out CS_0024_003C_003E8__locals36.y7hM8Ynokn) || string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals36.oWXMl6xjNq.user.背包数据.物品列表[result].名字) || string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals36.oWXMl6xjNq.user.背包数据.物品列表[CS_0024_003C_003E8__locals36.y7hM8Ynokn].名字) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals36.oWXMl6xjNq, result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals36.oWXMl6xjNq, CS_0024_003C_003E8__locals36.y7hM8Ynokn) || CS_0024_003C_003E8__locals36.oWXMl6xjNq.user.背包数据.物品列表[CS_0024_003C_003E8__locals36.y7hM8Ynokn].首饰可转换次数 <= 0 || CS_0024_003C_003E8__locals36.oWXMl6xjNq.user.背包数据.物品列表[CS_0024_003C_003E8__locals36.y7hM8Ynokn].首饰已转换次数 <= 0)
			{
				return;
			}
			CS_0024_003C_003E8__locals36.oWXMl6xjNq.销毁回调事件 =  (string v) =>
			{
				if (!(v != "轮转玉") || !(v != "超级轮转玉"))
				{
					CS_0024_003C_003E8__locals36.oWXMl6xjNq.销毁回调事件 = null;
					if (v == "轮转玉")
					{
						int num = CS_0024_003C_003E8__locals36.oWXMl6xjNq.user.背包数据.物品列表[CS_0024_003C_003E8__locals36.y7hM8Ynokn].等级 / 10;
						if (num > 16)
						{
							num = 16;
						}
						问道数据类.所有等级首饰转属次数.TryGetValue(num, out List<int> value2);
						if (value2.Count <= CS_0024_003C_003E8__locals36.oWXMl6xjNq.user.背包数据.物品列表[CS_0024_003C_003E8__locals36.y7hM8Ynokn].首饰可转换次数)
						{
							return;
						}
						int value3 = value2[CS_0024_003C_003E8__locals36.oWXMl6xjNq.user.背包数据.物品列表[CS_0024_003C_003E8__locals36.y7hM8Ynokn].首饰可转换次数 - CS_0024_003C_003E8__locals36.oWXMl6xjNq.user.背包数据.物品列表[CS_0024_003C_003E8__locals36.y7hM8Ynokn].首饰已转换次数 + 1];
						Singleton<WdAPI>.I.Mr8ICwW3qX(CS_0024_003C_003E8__locals36.oWXMl6xjNq, CS_0024_003C_003E8__locals36.y7hM8Ynokn, "cvt_chance", $"{value3}");
					}
					else if (v == "超级轮转玉")
					{
						Singleton<WdAPI>.I.Mr8ICwW3qX(CS_0024_003C_003E8__locals36.oWXMl6xjNq, CS_0024_003C_003E8__locals36.y7hM8Ynokn, "cvt_chance", "0");
					}
					if (Singleton<全局变量类>.I.验证client.授权配置.IsVip || 全局变量类.Is调试)
					{
						CS_0024_003C_003E8__locals36.oWXMl6xjNq.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y" + CS_0024_003C_003E8__locals36.oWXMl6xjNq.user.背包数据.物品列表[CS_0024_003C_003E8__locals36.y7hM8Ynokn].名字 + "#n的转换次数已经恢复。"));
					}
					else
					{
						MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals36.oWXMl6xjNq;
						WdAPI i = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你使用了#R");
						defaultInterpolatedStringHandler.AppendFormatted(v);
						defaultInterpolatedStringHandler.AppendLiteral("#n恢复了#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals36.oWXMl6xjNq.user.背包数据.物品列表[CS_0024_003C_003E8__locals36.y7hM8Ynokn].名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n的属性转换次数。为了保证数据安全，游戏将掉线10秒后才可恢复。");
						myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						Singleton<WdAPI>.I.WT9IHmFS6c(CS_0024_003C_003E8__locals36.oWXMl6xjNq, CS_0024_003C_003E8__locals36.oWXMl6xjNq.user.人物数据.昵称);
					}
				}
			};
			CS_0024_003C_003E8__locals36.oWXMl6xjNq.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(result, 1), "请求_轮转玉事件处理");
		}
		catch (Exception ex)
		{
			Log.Error("请求_轮转玉事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal bool YJojoSHagW(MyNATSocketClient P_0, byte P_1, byte P_2)
	{
		if (Singleton<全局变量类>.I.config.is超级天星石 && P_0.user.背包数据.物品列表[P_1].名字 == "超级天星石" && P_0.user.背包数据.物品列表[P_2].装备已进化次数 == 19 && P_0.user.背包数据.物品列表[P_2].等级 + 1 <= P_0.user.属性数据.等级)
		{
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return false;
			}
			P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_1].封包缓存, P_1).Concat(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_2].封包缓存, P_2)).ToArray());
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[@确定/使用超级天星石_");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要使用#Y超级天星石#n为#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n进行超级进化操作吗？]");
			P_0.C_Send(i.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
			return true;
		}
		return false;
	}

	
	internal void PTOjNchOoX(MyNATSocketClient P_0, string P_1, string P_2)
	{
		try
		{
			if (!OeqjXVCekN() || P_0.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			P_1 = P_1.Replace("$*天降石提交_", "");
			if (!int.TryParse(P_1, out var result))
			{
				return;
			}
			int result2;
			if (P_0.user.背包数据.物品列表[result].名字 != "天降石")
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R使用物品有误！"));
			}
			else if (Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result) && int.TryParse(P_2.Replace("money:0,", "").Split(":")[0], out result2) && Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result2))
			{
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[result2].封包缓存, result2));
				if (!Singleton<ByteAPI>.I.寻找文本("|魔引|狂暴|烈炎|惊雷|青木|碎石|寒冰|怒击|破天|降魔斩|修罗术|反击|云体|仙风|尽忠|", "|" + P_0.user.背包数据.物品列表[result2].名字 + "|"))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R请提交天书！"));
					return;
				}
				P_0.S_Send(Singleton<WdAPI>.I.naeodnd6MY(result));
				Singleton<WdAPI>.I.Mr8ICwW3qX(P_0, result2, "level", "1");
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#Y" + P_0.user.背包数据.物品列表[result2].名字 + "#n的等级被降到了#R1#n级。"));
			}
		}
		catch (Exception ex)
		{
			Log.Error("天降石提交处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task bZHjipKmG4(MyNATSocketClient P_0, string P_1, string P_2)
	{
		_ = 2;
		try
		{
			if (!OeqjXVCekN() || P_0.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			P_1 = P_1.Replace("$*法宝亲密互换石提交_", "");
			if (!int.TryParse(P_1, out var result))
			{
				return;
			}
			if (P_0.user.背包数据.物品列表[result].名字 != "法宝亲密互换石")
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R使用物品有误！"));
			}
			else
			{
				if (!Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result))
				{
					return;
				}
				string[] array = P_2.Replace("money:0,", "").Split(",");
				if (array.Length != 2 || !int.TryParse(array[0].Split(":")[0], out var result2) || !int.TryParse(array[1].Split(":")[0], out var result3) || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result2) || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result3))
				{
					return;
				}
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[result2].封包缓存, result2).Concat(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[result3].封包缓存, result3)).ToArray());
				if (!Singleton<ByteAPI>.I.寻找文本("|定海珠|番天印|混元金斗|阴阳镜|九龙神火罩|金蛟剪|卸甲金葫|十二品莲台|混沌钟|七宝妙树|", "|" + P_0.user.背包数据.物品列表[result2].名字 + "|") || !Singleton<ByteAPI>.I.寻找文本("|定海珠|番天印|混元金斗|阴阳镜|九龙神火罩|金蛟剪|卸甲金葫|十二品莲台|混沌钟|七宝妙树|", "|" + P_0.user.背包数据.物品列表[result3].名字 + "|"))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R请提交法宝！"));
					return;
				}
				P_0.S_Send(Singleton<WdAPI>.I.naeodnd6MY(result));
				int 亲密1 = P_0.user.背包数据.物品列表[result2].亲密度;
				int 亲密2 = P_0.user.背包数据.物品列表[result3].亲密度;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[result2].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n和#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[result3].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n的亲密度已经交换，请下线重上查看。");
				P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				int 临时GID = P_0.user.人物数据.GID;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendFormatted(result2);
				defaultInterpolatedStringHandler.AppendLiteral(":\"");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[result2].名字);
				string 临时名称1 = defaultInterpolatedStringHandler.ToStringAndClear();
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendFormatted(result3);
				defaultInterpolatedStringHandler.AppendLiteral(":\"");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[result3].名字);
				string 临时名称2 = defaultInterpolatedStringHandler.ToStringAndClear();
				string 当前角色账号 = P_0.user.人物数据.账号;
				if (!DB.I.锁定账号操作(当前角色账号, "1"))
				{
					Log.Error("法宝亲密互换石提交处理-错误：账号锁定失败");
					return;
				}
				await Singleton<WdAPI>.I.GM_安全下线(P_0.user.人物数据.昵称);
				await Task.Delay(5000);
				await DB.I.JTbigvkj7R(临时GID, 当前角色账号, 临时名称1, 临时名称2, 亲密1, 亲密2);
				DB.I.锁定账号操作(当前角色账号, "0");
			}
		}
		catch (Exception ex)
		{
			Log.Error("法宝亲密互换石提交处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task rAbjBACuq5(MyNATSocketClient P_0, string P_1, string P_2)
	{
		_ = 2;
		try
		{
			if (!OeqjXVCekN() || P_0.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			P_1 = P_1.Replace("$*装备男女转换玉提交_", "");
			if (!int.TryParse(P_1, out var result))
			{
				return;
			}
			if (P_0.user.背包数据.物品列表[result].名字 != "装备男女转换玉")
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R使用物品有误！"));
			}
			else
			{
				if (!Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result) || !int.TryParse(P_2.Replace("money:0,", "").Split(":")[0], out var result2) || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result2))
				{
					return;
				}
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[result2].封包缓存, result2));
				if (P_0.user.背包数据.物品列表[result2].物品类型 != 1 && P_0.user.背包数据.物品列表[result2].物品类型 != 2 && P_0.user.背包数据.物品列表[result2].物品类型 != 3 && P_0.user.背包数据.物品列表[result2].物品类型 != 10 && P_0.user.背包数据.物品列表[result2].物品类型 != 7)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R请提交正确的装备类型！"));
				}
				else
				{
					if (P_0.user.背包数据.物品列表[result2].性别 == 0)
					{
						return;
					}
					int value = ((P_0.user.背包数据.物品列表[result2].性别 != 1) ? 1 : 2);
					if (!问道数据类.装备性别对应字典.TryGetValue(P_0.user.背包数据.物品列表[result2].名字, out string 要转名字))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R请提交正确的装备！"));
						return;
					}
					P_0.S_Send(Singleton<WdAPI>.I.naeodnd6MY(result));
					Singleton<WdAPI>.I.Mr8ICwW3qX(P_0, result2, "gender", $"{value}");
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#Y" + P_0.user.背包数据.物品列表[result2].名字 + "#n的的性别已经转换了，请下线重上查看。"));
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
					defaultInterpolatedStringHandler.AppendFormatted(result2);
					defaultInterpolatedStringHandler.AppendLiteral(":\"");
					defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[result2].名字);
					string 临时名称 = defaultInterpolatedStringHandler.ToStringAndClear();
					int 临时GID = P_0.user.人物数据.GID;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
					defaultInterpolatedStringHandler.AppendFormatted(result2);
					defaultInterpolatedStringHandler.AppendLiteral(":\"");
					defaultInterpolatedStringHandler.AppendFormatted(要转名字);
					要转名字 = defaultInterpolatedStringHandler.ToStringAndClear();
					string 当前角色账号 = P_0.user.人物数据.账号;
					if (!DB.I.锁定账号操作(当前角色账号, "1"))
					{
						Log.Error("装备男女转换玉提交处理-错误：账号锁定失败");
						return;
					}
					await Singleton<WdAPI>.I.GM_安全下线(P_0.user.人物数据.昵称);
					await Task.Delay(5000);
					await DB.I.DXLiWhENog(临时GID, 当前角色账号, 临时名称, 要转名字);
					DB.I.锁定账号操作(当前角色账号, "0");
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("装备男女转换玉提交处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void PGujG4xR2Z(MyNATSocketClient P_0, int P_1, int P_2 = 0, int P_3 = 0)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals4.Hd1Mo0Tb6Q = P_2;
		try
		{
			if (!OeqjXVCekN() || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, P_1))
			{
				return;
			}
			if (P_0.user.背包数据.物品列表[P_1].名字 != "武学互换丹")
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R使用物品有误！"));
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("#G请选择#R2#n只相同等级的宠物进行武学交换：#r");
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.Find( (宠物缓存数据类 x) => x.宠物ID != 0 && x.宠物ID == CS_0024_003C_003E8__locals4.Hd1Mo0Tb6Q);
			if (宠物缓存数据类2 != null)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(20, 4, stringBuilder2);
				handler.AppendLiteral("#Y选择宠物1：");
				handler.AppendFormatted(宠物缓存数据类2.昵称A);
				handler.AppendLiteral("(");
				handler.AppendFormatted(宠物缓存数据类2.昵称B);
				handler.AppendLiteral(")·");
				handler.AppendFormatted(宠物缓存数据类2.等级);
				handler.AppendLiteral("级  ");
				handler.AppendFormatted(宠物缓存数据类2.武学);
				handler.AppendLiteral("武学#n#r");
				stringBuilder3.Append(ref handler);
			}
			int num = 0;
			for (int num2 = 0; num2 < P_0.user.宠物数据.Length; num2++)
			{
				if (P_0.user.宠物数据[num2].PetID != 0 && !string.IsNullOrWhiteSpace(P_0.user.宠物数据[num2].IID) && (宠物缓存数据类2 == null || (P_0.user.宠物数据[num2].宠物ID != 宠物缓存数据类2.宠物ID && P_0.user.宠物数据[num2].等级 == 宠物缓存数据类2.等级)))
				{
					num++;
					if (CS_0024_003C_003E8__locals4.Hd1Mo0Tb6Q == 0)
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder4 = stringBuilder2;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(28, 6, stringBuilder2);
						handler.AppendLiteral("[【选择】");
						handler.AppendFormatted(P_0.user.宠物数据[num2].昵称A);
						handler.AppendLiteral("(");
						handler.AppendFormatted(P_0.user.宠物数据[num2].昵称B);
						handler.AppendLiteral(")·");
						handler.AppendFormatted(P_0.user.宠物数据[num2].等级);
						handler.AppendLiteral("级  ");
						handler.AppendFormatted(P_0.user.宠物数据[num2].武学);
						handler.AppendLiteral("武学/武学互换丹提交_选择1_");
						handler.AppendFormatted(P_1);
						handler.AppendLiteral("|");
						handler.AppendFormatted(P_0.user.宠物数据[num2].宠物ID);
						handler.AppendLiteral("]");
						stringBuilder4.Append(ref handler);
					}
					else
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder5 = stringBuilder2;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 7, stringBuilder2);
						handler.AppendLiteral("[【选择】");
						handler.AppendFormatted(P_0.user.宠物数据[num2].昵称A);
						handler.AppendLiteral("(");
						handler.AppendFormatted(P_0.user.宠物数据[num2].昵称B);
						handler.AppendLiteral(")·");
						handler.AppendFormatted(P_0.user.宠物数据[num2].等级);
						handler.AppendLiteral("级  ");
						handler.AppendFormatted(P_0.user.宠物数据[num2].武学);
						handler.AppendLiteral("武学/武学互换丹提交_选择2_");
						handler.AppendFormatted(P_1);
						handler.AppendLiteral("|");
						handler.AppendFormatted(CS_0024_003C_003E8__locals4.Hd1Mo0Tb6Q);
						handler.AppendLiteral("|");
						handler.AppendFormatted(P_0.user.宠物数据[num2].宠物ID);
						handler.AppendLiteral("]");
						stringBuilder5.Append(ref handler);
					}
				}
			}
			if (num <= 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你当前并未拥有可以交换武学的宠物。"));
			}
			else
			{
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_自己(P_0, stringBuilder.ToString()));
			}
		}
		catch (Exception ex)
		{
			Log.Error("武学互换丹使用处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void EOPjfQe87D(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass21_0();
			if (!OeqjXVCekN())
			{
				return;
			}
			CS_0024_003C_003E8__locals10.E31MBxwYLV = (Singleton<ByteAPI>.I.寻找文本(P_1, "武学互换丹提交_选择1_") ? P_1.Replace("武学互换丹提交_选择1_", string.Empty).Split("|").Select(int.Parse)
				.ToList() : P_1.Replace("武学互换丹提交_选择2_", string.Empty).Split("|").Select(int.Parse)
				.ToList());
			if (Singleton<ByteAPI>.I.寻找文本(P_1, "武学互换丹提交_选择1_") && CS_0024_003C_003E8__locals10.E31MBxwYLV.Count == 2)
			{
				PGujG4xR2Z(P_0, CS_0024_003C_003E8__locals10.E31MBxwYLV[0], CS_0024_003C_003E8__locals10.E31MBxwYLV[1]);
			}
			else
			{
				if (!Singleton<ByteAPI>.I.寻找文本(P_1, "武学互换丹提交_选择2_") || CS_0024_003C_003E8__locals10.E31MBxwYLV.Count != 3 || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, CS_0024_003C_003E8__locals10.E31MBxwYLV[0]) || P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals10.E31MBxwYLV[0]].名字 != "武学互换丹")
				{
					return;
				}
				宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.Find( (宠物缓存数据类 x) => x.宠物ID != 0 && x.宠物ID == CS_0024_003C_003E8__locals10.E31MBxwYLV[1]);
				宠物缓存数据类 宠物缓存数据类3 = P_0.user.宠物数据.Find( (宠物缓存数据类 x) => x.宠物ID != 0 && x.宠物ID == CS_0024_003C_003E8__locals10.E31MBxwYLV[2]);
				if (宠物缓存数据类2 != null && 宠物缓存数据类3 != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (宠物缓存数据类3.等级 != 宠物缓存数据类2.等级)
					{
						WdAPI i = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
						defaultInterpolatedStringHandler.AppendLiteral("#R");
						defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类3.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n的等级和#R");
						defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n的等级不一致，无法交换。");
						P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					int 武学 = 宠物缓存数据类2.武学;
					int 武学2 = 宠物缓存数据类3.武学;
					P_0.S_Send(Singleton<WdAPI>.I.naeodnd6MY(CS_0024_003C_003E8__locals10.E31MBxwYLV[0]));
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, $"{宠物缓存数据类2.宠物ID}", "martial", $"{武学2}", "admin_set_attrib");
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, $"{宠物缓存数据类3.宠物ID}", "martial", $"{武学}", "admin_set_attrib");
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n和#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类3.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的武学已经互换了。");
					P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("武学互换丹提交处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void w4Kj6Kin0K(MyNATSocketClient P_0, int P_1, int P_2 = 0, int P_3 = 0)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals4.LQtMf6ldJS = P_2;
		try
		{
			if (!OeqjXVCekN() || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, P_1))
			{
				return;
			}
			if (P_0.user.背包数据.物品列表[P_1].名字 != "宠物亲密互换丹")
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R使用物品有误！"));
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("#G请选择#R2#n只相同等级的宠物进行亲密交换：#r");
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.Find( (宠物缓存数据类 x) => x.宠物ID != 0 && x.宠物ID == CS_0024_003C_003E8__locals4.LQtMf6ldJS);
			if (宠物缓存数据类2 != null)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(20, 4, stringBuilder2);
				handler.AppendLiteral("#Y选择宠物1：");
				handler.AppendFormatted(宠物缓存数据类2.昵称A);
				handler.AppendLiteral("(");
				handler.AppendFormatted(宠物缓存数据类2.昵称B);
				handler.AppendLiteral(")·");
				handler.AppendFormatted(宠物缓存数据类2.等级);
				handler.AppendLiteral("级  ");
				handler.AppendFormatted(宠物缓存数据类2.亲密);
				handler.AppendLiteral("亲密#n#r");
				stringBuilder3.Append(ref handler);
			}
			int num = 0;
			for (int num2 = 0; num2 < P_0.user.宠物数据.Length; num2++)
			{
				if (P_0.user.宠物数据[num2].PetID != 0 && !string.IsNullOrWhiteSpace(P_0.user.宠物数据[num2].IID) && (宠物缓存数据类2 == null || (P_0.user.宠物数据[num2].宠物ID != 宠物缓存数据类2.宠物ID && P_0.user.宠物数据[num2].等级 == 宠物缓存数据类2.等级)))
				{
					num++;
					if (CS_0024_003C_003E8__locals4.LQtMf6ldJS == 0)
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder4 = stringBuilder2;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(30, 6, stringBuilder2);
						handler.AppendLiteral("[【选择】");
						handler.AppendFormatted(P_0.user.宠物数据[num2].昵称A);
						handler.AppendLiteral("(");
						handler.AppendFormatted(P_0.user.宠物数据[num2].昵称B);
						handler.AppendLiteral(")·");
						handler.AppendFormatted(P_0.user.宠物数据[num2].等级);
						handler.AppendLiteral("级  ");
						handler.AppendFormatted(P_0.user.宠物数据[num2].亲密);
						handler.AppendLiteral("亲密/宠物亲密互换丹提交_选择1_");
						handler.AppendFormatted(P_1);
						handler.AppendLiteral("|");
						handler.AppendFormatted(P_0.user.宠物数据[num2].宠物ID);
						handler.AppendLiteral("]");
						stringBuilder4.Append(ref handler);
					}
					else
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder5 = stringBuilder2;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(31, 7, stringBuilder2);
						handler.AppendLiteral("[【选择】");
						handler.AppendFormatted(P_0.user.宠物数据[num2].昵称A);
						handler.AppendLiteral("(");
						handler.AppendFormatted(P_0.user.宠物数据[num2].昵称B);
						handler.AppendLiteral(")·");
						handler.AppendFormatted(P_0.user.宠物数据[num2].等级);
						handler.AppendLiteral("级  ");
						handler.AppendFormatted(P_0.user.宠物数据[num2].亲密);
						handler.AppendLiteral("亲密/宠物亲密互换丹提交_选择2_");
						handler.AppendFormatted(P_1);
						handler.AppendLiteral("|");
						handler.AppendFormatted(CS_0024_003C_003E8__locals4.LQtMf6ldJS);
						handler.AppendLiteral("|");
						handler.AppendFormatted(P_0.user.宠物数据[num2].宠物ID);
						handler.AppendLiteral("]");
						stringBuilder5.Append(ref handler);
					}
				}
			}
			if (num <= 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你当前并未拥有可以交换亲密的宠物。"));
			}
			else
			{
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_自己(P_0, stringBuilder.ToString()));
			}
		}
		catch (Exception ex)
		{
			Log.Error("宠物亲密互换丹使用处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void qG9j2skJv4(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass23_0();
			if (!OeqjXVCekN())
			{
				return;
			}
			CS_0024_003C_003E8__locals10.fhGMmTqyU6 = (Singleton<ByteAPI>.I.寻找文本(P_1, "宠物亲密互换丹提交_选择1_") ? P_1.Replace("宠物亲密互换丹提交_选择1_", string.Empty).Split("|").Select(int.Parse)
				.ToList() : P_1.Replace("宠物亲密互换丹提交_选择2_", string.Empty).Split("|").Select(int.Parse)
				.ToList());
			if (Singleton<ByteAPI>.I.寻找文本(P_1, "宠物亲密互换丹提交_选择1_") && CS_0024_003C_003E8__locals10.fhGMmTqyU6.Count == 2)
			{
				w4Kj6Kin0K(P_0, CS_0024_003C_003E8__locals10.fhGMmTqyU6[0], CS_0024_003C_003E8__locals10.fhGMmTqyU6[1]);
			}
			else
			{
				if (!Singleton<ByteAPI>.I.寻找文本(P_1, "宠物亲密互换丹提交_选择2_") || CS_0024_003C_003E8__locals10.fhGMmTqyU6.Count != 3 || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, CS_0024_003C_003E8__locals10.fhGMmTqyU6[0]) || P_0.user.背包数据.物品列表[CS_0024_003C_003E8__locals10.fhGMmTqyU6[0]].名字 != "宠物亲密互换丹")
				{
					return;
				}
				宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.Find( (宠物缓存数据类 x) => x.宠物ID != 0 && x.宠物ID == CS_0024_003C_003E8__locals10.fhGMmTqyU6[1]);
				宠物缓存数据类 宠物缓存数据类3 = P_0.user.宠物数据.Find( (宠物缓存数据类 x) => x.宠物ID != 0 && x.宠物ID == CS_0024_003C_003E8__locals10.fhGMmTqyU6[2]);
				if (宠物缓存数据类2 != null && 宠物缓存数据类3 != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (宠物缓存数据类3.等级 != 宠物缓存数据类2.等级)
					{
						WdAPI i = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
						defaultInterpolatedStringHandler.AppendLiteral("#R");
						defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类3.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n的等级和#R");
						defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n的等级不一致，无法交换。");
						P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					int 亲密 = 宠物缓存数据类2.亲密;
					int 亲密2 = 宠物缓存数据类3.亲密;
					P_0.S_Send(Singleton<WdAPI>.I.naeodnd6MY(CS_0024_003C_003E8__locals10.fhGMmTqyU6[0]));
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, $"{宠物缓存数据类2.宠物ID}", "intimacy", $"{亲密2}", "admin_set_attrib");
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, $"{宠物缓存数据类3.宠物ID}", "intimacy", $"{亲密}", "admin_set_attrib");
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n和#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类3.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的亲密已经互换了。");
					P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("宠物亲密互换丹提交处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public zeYnwTjKgpmAbfSQh5J()
	{
	}

	static zeYnwTjKgpmAbfSQh5J()
	{
	}
}
