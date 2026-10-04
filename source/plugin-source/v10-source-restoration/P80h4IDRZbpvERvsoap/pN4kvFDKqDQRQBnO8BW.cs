using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace P80h4IDRZbpvERvsoap;

internal class pN4kvFDKqDQRQBnO8BW : Singleton<pN4kvFDKqDQRQBnO8BW>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public MyNATSocketClient v7t5cCWY2t;

		public int AWy5nPDyjr;

		public string Rnh55QWxjE;

		public int aeQ5M9kq5Z;

		public int veP5h1yRhh;

		public Action<int, string> R915vXUwF4;

		
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		
		internal void fPa5LVRsjW(string v)
		{
			if (v != Singleton<全局变量类>.I.装备系统配置.拆卸道具名字)
			{
				return;
			}
			v7t5cCWY2t.销毁回调事件 = null;
			v7t5cCWY2t.拆卸回调事件 =  (int 格子, string 名字) =>
			{
				if (格子 == AWy5nPDyjr && !(名字 != Rnh55QWxjE))
				{
					v7t5cCWY2t.拆卸回调事件 = null;
					Singleton<WdAPI>.I.Mr8ICwW3qX(v7t5cCWY2t, AWy5nPDyjr, "rebuild_level", aeQ5M9kq5Z.ToString());
					if (Singleton<全局变量类>.I.装备系统配置.拆后改造令绑定状态 != AllEnums.绑定Type.不绑定)
					{
						Singleton<WdAPI>.I.Mr8ICwW3qX(v7t5cCWY2t, AWy5nPDyjr, "property_bind/attrib", (Singleton<全局变量类>.I.装备系统配置.拆后改造令绑定状态 == AllEnums.绑定Type.红绑) ? "3" : "4");
					}
					v7t5cCWY2t.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你成功的将#R" + v7t5cCWY2t.user.背包数据.物品列表[veP5h1yRhh].名字 + "#n的改造等级拆卸了出来。"));
				}
			};
			Singleton<WdAPI>.I.NNfIVUuyWv(v7t5cCWY2t, veP5h1yRhh, new List<string[]>
			{
				new string[2]
				{
					"level",
					"0"
				},
				new string[2]
				{
					"rebuild_cumulate_rate",
					"0"
				}
			});
			Singleton<WdAPI>.I.PndoGw5lW7(v7t5cCWY2t, AllEnums.发送数据Type.道具, Rnh55QWxjE, AllEnums.指令Type.无, 1, false, "改造拆卸");
		}

		
		internal void abG5STulA5(int 格子, string 名字)
		{
			if (格子 == AWy5nPDyjr && !(名字 != Rnh55QWxjE))
			{
				v7t5cCWY2t.拆卸回调事件 = null;
				Singleton<WdAPI>.I.Mr8ICwW3qX(v7t5cCWY2t, AWy5nPDyjr, "rebuild_level", aeQ5M9kq5Z.ToString());
				if (Singleton<全局变量类>.I.装备系统配置.拆后改造令绑定状态 != AllEnums.绑定Type.不绑定)
				{
					Singleton<WdAPI>.I.Mr8ICwW3qX(v7t5cCWY2t, AWy5nPDyjr, "property_bind/attrib", (Singleton<全局变量类>.I.装备系统配置.拆后改造令绑定状态 == AllEnums.绑定Type.红绑) ? "3" : "4");
				}
				v7t5cCWY2t.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你成功的将#R" + v7t5cCWY2t.user.背包数据.物品列表[veP5h1yRhh].名字 + "#n的改造等级拆卸了出来。"));
			}
		}

		static _003C_003Ec__DisplayClass14_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public int TIB5ax8g8m;

		
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		
		internal bool AiP57rtNdb(物品信息类 x)
		{
			if (x.分解Data != null)
			{
				return x.Index <= TIB5ax8g8m;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass15_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public int UGa5yDHLOL;

		public int SkH5CGLJLb;

		public int eOC5VOhpNM;

		public MyNATSocketClient y4H5kFpSj8;

		public int ScQ50Xm3rF;

		public Dictionary<string, int> vRk5OhsQNo;

		public List<string> UBf5QbapOP;

		public List<string> e915EKhV1e;

		
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		
		internal bool BCw5TuO9jp(物品信息类 x)
		{
			if (x.分解Data != null)
			{
				return x.Index <= UGa5yDHLOL;
			}
			return false;
		}

		
		internal void Isx59MLhin(string v)
		{
			_003C_003Ec__DisplayClass16_1 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass16_1();
			CS_0024_003C_003E8__locals2.RNr5YXgtYe = v;
			if (!Singleton<全局变量类>.I.装备分解配置.分解列表.Any( (分解详情配置类 x) => CS_0024_003C_003E8__locals2.RNr5YXgtYe.StartsWith(x.校验文字)))
			{
				return;
			}
			SkH5CGLJLb++;
			if (SkH5CGLJLb < eOC5VOhpNM)
			{
				return;
			}
			y4H5kFpSj8.销毁回调事件 = null;
			Singleton<WdAPI>.I.PndoGw5lW7(y4H5kFpSj8, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, ScQ50Xm3rF, false, "[个人突破-" + y4H5kFpSj8.user.人物数据.昵称 + "-分解增加]");
			if (vRk5OhsQNo.Any())
			{
				foreach (KeyValuePair<string, int> item in vRk5OhsQNo)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(y4H5kFpSj8, AllEnums.发送数据Type.道具, item.Key, AllEnums.指令Type.无, item.Value, false, "装备分解");
				}
			}
			for (int num = 0; num < UBf5QbapOP.Count; num++)
			{
				y4H5kFpSj8.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(UBf5QbapOP[num]));
			}
			MyNATSocketClient myNATSocketClient = y4H5kFpSj8;
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(60, 2);
			defaultInterpolatedStringHandler.AppendLiteral("#G全部分解完成#n。获得#Y");
			defaultInterpolatedStringHandler.AppendFormatted(ScQ50Xm3rF);
			defaultInterpolatedStringHandler.AppendLiteral("#n点灵气，当前拥有#Y");
			defaultInterpolatedStringHandler.AppendFormatted(y4H5kFpSj8.user.存档数据.数值存档.灵气值);
			defaultInterpolatedStringHandler.AppendLiteral("#n点灵气#R（可在小助手的人物详情中查看当前拥有灵气点数）#n。");
			myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			for (int num2 = 0; num2 < e915EKhV1e.Count; num2++)
			{
				Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(e915EKhV1e[num2], "管理员"));
			}
		}

		static _003C_003Ec__DisplayClass16_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_1
	{
		public string RNr5YXgtYe;

		
		public _003C_003Ec__DisplayClass16_1()
		{
		}

		
		internal bool Tt853rTFtI(分解详情配置类 x)
		{
			return RNr5YXgtYe.StartsWith(x.校验文字);
		}

		static _003C_003Ec__DisplayClass16_1()
		{
		}
	}

	
	internal void NW6Dd34OfT()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("装备系统配置类.json")))
			{
				Singleton<全局变量类>.I.装备系统配置 = JsonConvert.DeserializeObject<装备系统配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("装备系统配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.装备系统配置 = new 装备系统配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("装备系统配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.装备系统配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("装备系统配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void lLmDswr1ER()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("装备系统配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.装备系统配置, Formatting.Indented));
			Log.Debug("装备系统配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("装备系统配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string AD9DUWCLuf()
	{
		NW6Dd34OfT();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.装备系统配置, Formatting.Indented);
	}

	
	public void GHvDWoMo85(string P_0)
	{
		Singleton<全局变量类>.I.装备系统配置 = JsonConvert.DeserializeObject<装备系统配置类>(P_0);
		lLmDswr1ER();
	}

	
	[SpecialName]
	internal static bool XynDBwYvGf()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is装备分解)
		{
			return Singleton<全局变量类>.I.装备分解配置.功能开关;
		}
		return false;
	}

	
	[SpecialName]
	internal static bool wATDfrQwrg()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.IsVip)
		{
			return Singleton<全局变量类>.I.装备系统配置.改造拆卸开关;
		}
		return false;
	}

	
	internal void T3eDg89ZBH()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("装备分解配置类.json")))
			{
				Singleton<全局变量类>.I.装备分解配置 = JsonConvert.DeserializeObject<装备分解配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("装备分解配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.装备分解配置 = new 装备分解配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("装备分解配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.装备分解配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("装备分解配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void gwYDDJaCTN()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("装备分解配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.装备分解配置, Formatting.Indented));
			Log.Debug("装备分解配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("装备分解配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string CMCDjg0Hj2()
	{
		T3eDg89ZBH();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.装备分解配置, Formatting.Indented);
	}

	
	public void qWbDly07yg(string P_0)
	{
		Singleton<全局变量类>.I.装备分解配置 = JsonConvert.DeserializeObject<装备分解配置类>(P_0);
		gwYDDJaCTN();
	}

	
	internal void CfiD8OL64b(MyNATSocketClient P_0, string P_1, string P_2)
	{
		if (wATDfrQwrg() && P_1.Contains("装备系统_改造拆卸_", StringComparison.CurrentCulture))
		{
			jtZDoOHcd7(P_0, P_1.Replace("装备系统_改造拆卸_", string.Empty));
		}
		else if (XynDBwYvGf() && P_1 == "装备系统_分解确定")
		{
			HKqDi0eeYJ(P_0);
		}
	}

	
	internal bool b7SDIC3yUQ(MyNATSocketClient P_0, byte P_1, byte P_2)
	{
		if (!全局变量类.Is调试 && !Singleton<全局变量类>.I.验证client.授权配置.IsVip)
		{
			return false;
		}
		if (!Singleton<全局变量类>.I.装备系统配置.改造拆卸开关)
		{
			return false;
		}
		if (Singleton<全局变量类>.I.装备系统配置.可拆改造等级区间.Length != 2 || Singleton<全局变量类>.I.装备系统配置.可拆装备等级区间.Length != 2)
		{
			return false;
		}
		if (P_0.user.背包数据.物品列表[P_1].名字 != Singleton<全局变量类>.I.装备系统配置.拆卸道具名字)
		{
			return false;
		}
		if (!Singleton<全局变量类>.I.装备系统配置.可拆绑定开关 && P_0.user.背包数据.物品列表[P_2].是否绑定)
		{
			return false;
		}
		if (P_0.user.背包数据.物品列表[P_2].物品类型 != 1 && P_0.user.背包数据.物品列表[P_2].物品类型 != 2 && P_0.user.背包数据.物品列表[P_2].物品类型 != 3 && P_0.user.背包数据.物品列表[P_2].物品类型 != 10 && P_0.user.背包数据.物品列表[P_2].物品类型 != 7)
		{
			return false;
		}
		if (P_0.user.背包数据.物品列表[P_2].改造等级 < Singleton<全局变量类>.I.装备系统配置.可拆改造等级区间[0] || P_0.user.背包数据.物品列表[P_2].改造等级 > Singleton<全局变量类>.I.装备系统配置.可拆改造等级区间[1])
		{
			return false;
		}
		if (P_0.user.背包数据.物品列表[P_2].等级 < Singleton<全局变量类>.I.装备系统配置.可拆装备等级区间[0] || P_0.user.背包数据.物品列表[P_2].等级 > Singleton<全局变量类>.I.装备系统配置.可拆装备等级区间[1])
		{
			return false;
		}
		if (P_0.user.缓存数据.is使用仙灵卡)
		{
			return false;
		}
		P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_1].封包缓存, P_1).Concat(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_2].封包缓存, P_2)).ToArray());
		WdAPI i = Singleton<WdAPI>.I;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(57, 5);
		defaultInterpolatedStringHandler.AppendLiteral("[@确定/装备系统_改造拆卸_");
		defaultInterpolatedStringHandler.AppendFormatted(P_1);
		defaultInterpolatedStringHandler.AppendLiteral("|");
		defaultInterpolatedStringHandler.AppendFormatted(P_2);
		defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要使用#R");
		defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.装备系统配置.拆卸道具名字);
		defaultInterpolatedStringHandler.AppendLiteral("#n将#R");
		defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].名字);
		defaultInterpolatedStringHandler.AppendLiteral("#n的改造等级拆卸出来吗？");
		string value;
		if (Singleton<全局变量类>.I.装备系统配置.拆后改造令绑定状态 != AllEnums.绑定Type.不绑定)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(22, 1);
			defaultInterpolatedStringHandler2.AppendLiteral("#R（注意：拆卸出来的");
			defaultInterpolatedStringHandler2.AppendFormatted(P_0.user.背包数据.物品列表[P_2].改造等级);
			defaultInterpolatedStringHandler2.AppendLiteral("级装备改造令是绑定的）");
			value = defaultInterpolatedStringHandler2.ToStringAndClear();
		}
		else
		{
			value = string.Empty;
		}
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("]");
		P_0.C_Send(i.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
		return true;
	}

	
	private void jtZDoOHcd7(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals66 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals66.v7t5cCWY2t = P_0;
		if (Singleton<全局变量类>.I.装备系统配置.可拆改造等级区间.Length != 2 || Singleton<全局变量类>.I.装备系统配置.可拆装备等级区间.Length != 2 || string.IsNullOrWhiteSpace(P_1))
		{
			return;
		}
		string[] array = P_1.Split("|");
		if (array.Length != 2 || !int.TryParse(array[0], out var result) || !int.TryParse(array[1], out CS_0024_003C_003E8__locals66.veP5h1yRhh) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals66.v7t5cCWY2t, result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals66.v7t5cCWY2t, CS_0024_003C_003E8__locals66.veP5h1yRhh))
		{
			return;
		}
		if (CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[result].名字 != Singleton<全局变量类>.I.装备系统配置.拆卸道具名字)
		{
			CS_0024_003C_003E8__locals66.v7t5cCWY2t.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[result].名字 + "#n无法拆卸装备的改造等级。"));
			return;
		}
		if (!Singleton<全局变量类>.I.装备系统配置.可拆绑定开关 && CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[CS_0024_003C_003E8__locals66.veP5h1yRhh].是否绑定)
		{
			CS_0024_003C_003E8__locals66.v7t5cCWY2t.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[result].名字 + "#n处于绑定状态，无法进行改造等级的拆卸。"));
			return;
		}
		if (CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[CS_0024_003C_003E8__locals66.veP5h1yRhh].物品类型 != 1 && CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[CS_0024_003C_003E8__locals66.veP5h1yRhh].物品类型 != 2 && CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[CS_0024_003C_003E8__locals66.veP5h1yRhh].物品类型 != 3 && CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[CS_0024_003C_003E8__locals66.veP5h1yRhh].物品类型 != 10 && CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[CS_0024_003C_003E8__locals66.veP5h1yRhh].物品类型 != 7)
		{
			CS_0024_003C_003E8__locals66.v7t5cCWY2t.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[result].名字 + "#n无法进行改造等级的拆卸。"));
			return;
		}
		if (CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[CS_0024_003C_003E8__locals66.veP5h1yRhh].改造等级 < Singleton<全局变量类>.I.装备系统配置.可拆改造等级区间[0] || CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[CS_0024_003C_003E8__locals66.veP5h1yRhh].改造等级 > Singleton<全局变量类>.I.装备系统配置.可拆改造等级区间[1])
		{
			MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals66.v7t5cCWY2t;
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 3);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[result].名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n的改造等级不在#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.装备系统配置.可拆改造等级区间[0]);
			defaultInterpolatedStringHandler.AppendLiteral(" ~ ");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.装备系统配置.可拆改造等级区间[1]);
			defaultInterpolatedStringHandler.AppendLiteral("#n区间内，无法进行改造等级的拆卸。");
			myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			return;
		}
		if (CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[CS_0024_003C_003E8__locals66.veP5h1yRhh].等级 < Singleton<全局变量类>.I.装备系统配置.可拆装备等级区间[0] || CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[CS_0024_003C_003E8__locals66.veP5h1yRhh].等级 > Singleton<全局变量类>.I.装备系统配置.可拆装备等级区间[1])
		{
			MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals66.v7t5cCWY2t;
			WdAPI i2 = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[result].名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n的等级不在#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.装备系统配置.可拆装备等级区间[0]);
			defaultInterpolatedStringHandler.AppendLiteral(" ~ ");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.装备系统配置.可拆装备等级区间[1]);
			defaultInterpolatedStringHandler.AppendLiteral("#n区间内，无法进行改造等级的拆卸。");
			myNATSocketClient2.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			return;
		}
		bool flag = CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[CS_0024_003C_003E8__locals66.veP5h1yRhh].物品类型 == 1;
		CS_0024_003C_003E8__locals66.AWy5nPDyjr = Singleton<WdAPI>.I.取背包可用格子(CS_0024_003C_003E8__locals66.v7t5cCWY2t);
		CS_0024_003C_003E8__locals66.aeQ5M9kq5Z = CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[CS_0024_003C_003E8__locals66.veP5h1yRhh].改造等级;
		CS_0024_003C_003E8__locals66.Rnh55QWxjE = (flag ? "武器改造令" : "防具改造令");
		if (CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[result].数量 <= 1 && result < CS_0024_003C_003E8__locals66.AWy5nPDyjr)
		{
			CS_0024_003C_003E8__locals66.AWy5nPDyjr = result;
		}
		CS_0024_003C_003E8__locals66.v7t5cCWY2t.销毁回调事件 =  (string v) =>
		{
			if (!(v != Singleton<全局变量类>.I.装备系统配置.拆卸道具名字))
			{
				CS_0024_003C_003E8__locals66.v7t5cCWY2t.销毁回调事件 = null;
				CS_0024_003C_003E8__locals66.v7t5cCWY2t.拆卸回调事件 =  (int 格子, string 名字) =>
				{
					if (格子 == CS_0024_003C_003E8__locals66.AWy5nPDyjr && !(名字 != CS_0024_003C_003E8__locals66.Rnh55QWxjE))
					{
						CS_0024_003C_003E8__locals66.v7t5cCWY2t.拆卸回调事件 = null;
						Singleton<WdAPI>.I.Mr8ICwW3qX(CS_0024_003C_003E8__locals66.v7t5cCWY2t, CS_0024_003C_003E8__locals66.AWy5nPDyjr, "rebuild_level", CS_0024_003C_003E8__locals66.aeQ5M9kq5Z.ToString());
						if (Singleton<全局变量类>.I.装备系统配置.拆后改造令绑定状态 != AllEnums.绑定Type.不绑定)
						{
							Singleton<WdAPI>.I.Mr8ICwW3qX(CS_0024_003C_003E8__locals66.v7t5cCWY2t, CS_0024_003C_003E8__locals66.AWy5nPDyjr, "property_bind/attrib", (Singleton<全局变量类>.I.装备系统配置.拆后改造令绑定状态 == AllEnums.绑定Type.红绑) ? "3" : "4");
						}
						CS_0024_003C_003E8__locals66.v7t5cCWY2t.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你成功的将#R" + CS_0024_003C_003E8__locals66.v7t5cCWY2t.user.背包数据.物品列表[CS_0024_003C_003E8__locals66.veP5h1yRhh].名字 + "#n的改造等级拆卸了出来。"));
					}
				};
				Singleton<WdAPI>.I.NNfIVUuyWv(CS_0024_003C_003E8__locals66.v7t5cCWY2t, CS_0024_003C_003E8__locals66.veP5h1yRhh, new List<string[]>
				{
					new string[2]
					{
						"level",
						"0"
					},
					new string[2]
					{
						"rebuild_cumulate_rate",
						"0"
					}
				});
				Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals66.v7t5cCWY2t, AllEnums.发送数据Type.道具, CS_0024_003C_003E8__locals66.Rnh55QWxjE, AllEnums.指令Type.无, 1, false, "改造拆卸");
			}
		};
		CS_0024_003C_003E8__locals66.v7t5cCWY2t.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(result, 1));
	}

	
	internal void eC4DNMRbED(MyNATSocketClient P_0)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals2.TIB5ax8g8m = Singleton<WdAPI>.I.取背包最大格子(P_0);
		if (P_0.user.背包数据.物品列表.Any( (物品信息类 x) => x.分解Data != null && x.Index <= CS_0024_003C_003E8__locals2.TIB5ax8g8m))
		{
			P_0.C_Send(Singleton<WdAPI>.I.组包确定框(P_0, "[@确定/装备系统_分解确定#DLG:1#prompt:你确定要分解背包中全部可分解的物品吗？" + (Singleton<全局变量类>.I.装备分解配置.绑定开关 ? "#R（绑定、限时等装备无法被分解）" : string.Empty) + "]"));
		}
		else
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前背包中并无可分解的物品。"));
		}
	}

	
	internal void HKqDi0eeYJ(MyNATSocketClient P_0)
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals47 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals47.y4H5kFpSj8 = P_0;
		CS_0024_003C_003E8__locals47.UGa5yDHLOL = Singleton<WdAPI>.I.取背包最大格子(CS_0024_003C_003E8__locals47.y4H5kFpSj8);
		List<物品信息类> list = CS_0024_003C_003E8__locals47.y4H5kFpSj8.user.背包数据.物品列表.ToList().FindAll( (物品信息类 x) => x.分解Data != null && x.Index <= CS_0024_003C_003E8__locals47.UGa5yDHLOL);
		CS_0024_003C_003E8__locals47.eOC5VOhpNM = list.Count;
		if (list.Count <= 0)
		{
			CS_0024_003C_003E8__locals47.y4H5kFpSj8.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前背包中并无可分解的物品。"));
			return;
		}
		int value = 0;
		int num = 0;
		CS_0024_003C_003E8__locals47.ScQ50Xm3rF = 0;
		int num2 = 0;
		CS_0024_003C_003E8__locals47.vRk5OhsQNo = new Dictionary<string, int>();
		CS_0024_003C_003E8__locals47.UBf5QbapOP = new List<string>();
		CS_0024_003C_003E8__locals47.e915EKhV1e = new List<string>();
		foreach (物品信息类 item in list)
		{
			num2 = 0;
			if (!CS_0024_003C_003E8__locals47.y4H5kFpSj8.user.存档数据.精炼存档.分解计数字典.TryGetValue(item.分解Data.校验文字, out value))
			{
				value = 0;
				CS_0024_003C_003E8__locals47.y4H5kFpSj8.user.存档数据.精炼存档.分解计数字典.Add(item.分解Data.校验文字, 0);
			}
			if (item.分解Data.分解灵气值区间[1] >= item.分解Data.分解灵气值区间[0])
			{
				num = item.数量 * Singleton<WdAPI>.I.qrjo9TWIdy((item.分解Data.分解灵气值区间[0] > item.分解Data.分解灵气值区间[1]) ? item.分解Data.分解灵气值区间[1] : item.分解Data.分解灵气值区间[0], item.分解Data.分解灵气值区间[1]);
			}
			if (!string.IsNullOrWhiteSpace(item.分解Data.分解道具名字) && item.分解Data.分解道具区间.Length == 3 && item.分解Data.分解道具区间[0] > 0 && item.分解Data.分解道具区间[2] >= item.分解Data.分解道具区间[1])
			{
				if (value + item.数量 < item.分解Data.分解道具区间[0])
				{
					CS_0024_003C_003E8__locals47.y4H5kFpSj8.user.存档数据.精炼存档.分解计数字典[item.分解Data.校验文字] = value + item.数量;
				}
				else
				{
					int num3 = item.数量 - (item.分解Data.分解道具区间[0] - value);
					int num4 = num3 / item.分解Data.分解道具区间[0] + 1;
					CS_0024_003C_003E8__locals47.y4H5kFpSj8.user.存档数据.精炼存档.分解计数字典[item.分解Data.校验文字] = num3 % item.分解Data.分解道具区间[0];
					for (int num5 = 0; num5 < num4; num5++)
					{
						num2 = ((item.分解Data.分解道具区间[1] != item.分解Data.分解道具区间[2]) ? (num2 + Singleton<WdAPI>.I.qrjo9TWIdy(item.分解Data.分解道具区间[1], item.分解Data.分解道具区间[2])) : (num2 + item.分解Data.分解道具区间[1]));
					}
				}
			}
			CS_0024_003C_003E8__locals47.ScQ50Xm3rF += num;
			if (num2 > 0)
			{
				if (CS_0024_003C_003E8__locals47.vRk5OhsQNo.ContainsKey(item.分解Data.分解道具名字))
				{
					CS_0024_003C_003E8__locals47.vRk5OhsQNo[item.分解Data.分解道具名字] += num2;
				}
				else
				{
					CS_0024_003C_003E8__locals47.vRk5OhsQNo.TryAdd(item.分解Data.分解道具名字, num2);
				}
				if (item.分解Data.Is道具谣言)
				{
					List<string> list2 = CS_0024_003C_003E8__locals47.e915EKhV1e;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#82#Y");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals47.y4H5kFpSj8.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("#n在分解物品的过程中意外的获得了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num2);
					defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
					defaultInterpolatedStringHandler.AppendFormatted(item.分解Data.分解道具名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n，真是鸿运当头啊！");
					list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			if (num > 0 || num2 > 0)
			{
				List<string> list3 = CS_0024_003C_003E8__locals47.UBf5QbapOP;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 4);
				defaultInterpolatedStringHandler.AppendLiteral("你分解了#R");
				defaultInterpolatedStringHandler.AppendFormatted(item.数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(item.名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n点灵气#n");
				string value2;
				if (num2 <= 0)
				{
					value2 = string.Empty;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(11, 2);
					defaultInterpolatedStringHandler2.AppendLiteral("和#Y");
					defaultInterpolatedStringHandler2.AppendFormatted(num2);
					defaultInterpolatedStringHandler2.AppendLiteral("#n个#Y");
					defaultInterpolatedStringHandler2.AppendFormatted(item.分解Data.分解道具名字);
					defaultInterpolatedStringHandler2.AppendLiteral("#n。");
					value2 = defaultInterpolatedStringHandler2.ToStringAndClear();
				}
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				list3.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}
		CS_0024_003C_003E8__locals47.SkH5CGLJLb = 0;
		CS_0024_003C_003E8__locals47.y4H5kFpSj8.销毁回调事件 =  (string v) =>
		{
			_003C_003Ec__DisplayClass16_1 CS_0024_003C_003E8__locals48 = new _003C_003Ec__DisplayClass16_1();
			CS_0024_003C_003E8__locals48.RNr5YXgtYe = v;
			if (Singleton<全局变量类>.I.装备分解配置.分解列表.Any( (分解详情配置类 x) => CS_0024_003C_003E8__locals48.RNr5YXgtYe.StartsWith(x.校验文字)))
			{
				CS_0024_003C_003E8__locals47.SkH5CGLJLb++;
				if (CS_0024_003C_003E8__locals47.SkH5CGLJLb >= CS_0024_003C_003E8__locals47.eOC5VOhpNM)
				{
					CS_0024_003C_003E8__locals47.y4H5kFpSj8.销毁回调事件 = null;
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals47.y4H5kFpSj8, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, CS_0024_003C_003E8__locals47.ScQ50Xm3rF, false, "[个人突破-" + CS_0024_003C_003E8__locals47.y4H5kFpSj8.user.人物数据.昵称 + "-分解增加]");
					if (CS_0024_003C_003E8__locals47.vRk5OhsQNo.Any())
					{
						foreach (KeyValuePair<string, int> item2 in CS_0024_003C_003E8__locals47.vRk5OhsQNo)
						{
							Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals47.y4H5kFpSj8, AllEnums.发送数据Type.道具, item2.Key, AllEnums.指令Type.无, item2.Value, false, "装备分解");
						}
					}
					for (int num6 = 0; num6 < CS_0024_003C_003E8__locals47.UBf5QbapOP.Count; num6++)
					{
						CS_0024_003C_003E8__locals47.y4H5kFpSj8.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(CS_0024_003C_003E8__locals47.UBf5QbapOP[num6]));
					}
					MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals47.y4H5kFpSj8;
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(60, 2);
					defaultInterpolatedStringHandler3.AppendLiteral("#G全部分解完成#n。获得#Y");
					defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals47.ScQ50Xm3rF);
					defaultInterpolatedStringHandler3.AppendLiteral("#n点灵气，当前拥有#Y");
					defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals47.y4H5kFpSj8.user.存档数据.数值存档.灵气值);
					defaultInterpolatedStringHandler3.AppendLiteral("#n点灵气#R（可在小助手的人物详情中查看当前拥有灵气点数）#n。");
					myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler3.ToStringAndClear()));
					for (int num7 = 0; num7 < CS_0024_003C_003E8__locals47.e915EKhV1e.Count; num7++)
					{
						Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(CS_0024_003C_003E8__locals47.e915EKhV1e[num7], "管理员"));
					}
				}
			}
		};
		int[] array = list.Select( (物品信息类 x) => x.Index).ToArray();
		CS_0024_003C_003E8__locals47.y4H5kFpSj8.S_Send(Singleton<WdAPI>.I.DN4IOFDdr5(CS_0024_003C_003E8__locals47.y4H5kFpSj8, array));
		CS_0024_003C_003E8__locals47.y4H5kFpSj8.C_Send(Singleton<WdAPI>.I.QewoEwLLTD("正在分解中", 2));
	}

	
	public pN4kvFDKqDQRQBnO8BW()
	{
	}

	static pN4kvFDKqDQRQBnO8BW()
	{
	}
}
