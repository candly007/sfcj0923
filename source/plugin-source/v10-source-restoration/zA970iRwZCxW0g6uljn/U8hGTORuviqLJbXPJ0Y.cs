using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace zA970iRwZCxW0g6uljn;

internal class U8hGTORuviqLJbXPJ0Y : Singleton<U8hGTORuviqLJbXPJ0Y>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public int QIkLfBLAPo;

		
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		
		internal bool a3iLGPKrjM(宠物缓存数据类 a)
		{
			if (a.宠物ID != 0)
			{
				return a.PetID == QIkLfBLAPo;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass10_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public int MsJL2xFbDP;

		
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		
		internal bool sTtL6pVItu(宠物缓存数据类 a)
		{
			if (a.宠物ID != 0)
			{
				return a.PetID == MsJL2xFbDP;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass11_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public int r3gLPbYy9G;

		
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		
		internal bool nhuLmNR51t(宠物缓存数据类 a)
		{
			if (a.宠物ID != 0)
			{
				return a.PetID == r3gLPbYy9G;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass12_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public int Q7yLFuJ06f;

		
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		
		internal bool BmBLXtEN6E(宠物缓存数据类 a)
		{
			if (a.宠物ID != 0)
			{
				return a.PetID == Q7yLFuJ06f;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass13_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public int ki5LSWRYrN;

		
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		
		internal bool DI7LLr9P2d(宠物缓存数据类 a)
		{
			if (a.宠物ID != 0)
			{
				return a.PetID == ki5LSWRYrN;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass7_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public int HGALnxmhFQ;

		
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		
		internal bool DxDLcCE52c(宠物缓存数据类 a)
		{
			if (a.宠物ID != 0)
			{
				return a.PetID == HGALnxmhFQ;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass9_0()
		{
		}
	}

	internal static string HvERl5OIw9;

	
	[SpecialName]
	internal static bool n3VRDqR2M4()
	{
		if (!全局变量类.Is调试)
		{
			return Singleton<全局变量类>.I.验证client.授权配置.IsVip;
		}
		return true;
	}

	
	internal void t1ARbFh2RI()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物突破配置类.json")))
			{
				Singleton<全局变量类>.I.宠物突破配置 = JsonConvert.DeserializeObject<宠物突破配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物突破配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.宠物突破配置 = new 宠物突破配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物突破配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物突破配置, Formatting.Indented));
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 10);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.忠诚储备道具);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.武学突破道具);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.飞升突破道具);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.法攻强化道具);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.物攻强化道具);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.血量幻化道具);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.法力幻化道具);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.速度幻化道具);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.物攻幻化道具);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.法攻幻化道具);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			HvERl5OIw9 = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		catch (Exception ex)
		{
			Log.Error("宠物突破配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void S0eRJrPCWP()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物突破配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物突破配置, Formatting.Indented));
			Log.Debug("宠物突破配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("宠物突破配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string E05RKVDNcJ()
	{
		t1ARbFh2RI();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物突破配置, Formatting.Indented);
	}

	
	public void wZXRRYZSAQ(string P_0)
	{
		Singleton<全局变量类>.I.宠物突破配置 = JsonConvert.DeserializeObject<宠物突破配置类>(P_0);
		S0eRJrPCWP();
	}

	
	internal void zVtRdnLs6u(MyNATSocketClient P_0, string P_1, int P_2, int P_3, string P_4)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals3.ki5LSWRYrN = P_2;
		try
		{
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.Find( (宠物缓存数据类 a) => a.宠物ID != 0 && a.PetID == CS_0024_003C_003E8__locals3.ki5LSWRYrN);
			if (宠物缓存数据类2 != null)
			{
				string value = string.Empty;
				if (P_4 == Singleton<全局变量类>.I.宠物转生配置.转生洗髓道具)
				{
					value = "（#R" + P_4 + "#n每次至多自动使用#R100#n次）";
				}
				byte[] first = Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_3].封包缓存, P_3);
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 6);
				defaultInterpolatedStringHandler.AppendLiteral("[@确定/");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals3.ki5LSWRYrN);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要对#R");
				defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n使用#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_4);
				defaultInterpolatedStringHandler.AppendLiteral("#n吗");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("？]");
				P_0.C_Send(first.Concat(i.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
			}
		}
		catch (Exception ex)
		{
			Log.Error("宠物道具询问处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void ujxRskI3P4(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			string[] array = P_1.Split("|");
			if (array.Length == 2 && int.TryParse(array[0], out var result) && int.TryParse(array[1], out var result2) && P_0.user.背包数据.物品列表[result2].物品ID != 0 && P_0.user.背包数据.物品列表[result2].数量 > 0)
			{
				string 名字 = P_0.user.背包数据.物品列表[result2].名字;
				if (Singleton<全局变量类>.I.宠物突破配置.忠诚储备道具 == 名字)
				{
					pWTRUXW0Yj(P_0, result, result2, 名字);
				}
				if (Singleton<全局变量类>.I.宠物突破配置.武学突破道具 == 名字)
				{
					宠物武学突破处理(P_0, result, result2, 名字);
				}
				else if (Singleton<全局变量类>.I.宠物突破配置.飞升突破道具 == 名字)
				{
					宠物飞升突破处理(P_0, result, result2, 名字);
				}
				else if (Singleton<全局变量类>.I.宠物突破配置.法攻强化道具 == 名字 || Singleton<全局变量类>.I.宠物突破配置.物攻强化道具 == 名字)
				{
					b3ZRWw4tvx(P_0, result, result2, 名字);
				}
				else if (Singleton<全局变量类>.I.宠物突破配置.血量幻化道具 == 名字 || Singleton<全局变量类>.I.宠物突破配置.法力幻化道具 == 名字 || Singleton<全局变量类>.I.宠物突破配置.速度幻化道具 == 名字 || Singleton<全局变量类>.I.宠物突破配置.物攻幻化道具 == 名字 || Singleton<全局变量类>.I.宠物突破配置.法攻幻化道具 == 名字)
				{
					F0eRguMa3U(P_0, result, result2, 名字);
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("宠物道具突破处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void 宠物武学突破处理(MyNATSocketClient myclient, int 宠物位置, int 道具格子, string 使用道具名字)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals3.HGALnxmhFQ = 宠物位置;
		try
		{
			宠物缓存数据类 宠物缓存数据类2 = myclient.user.宠物数据.Find( (宠物缓存数据类 a) => a.宠物ID != 0 && a.PetID == CS_0024_003C_003E8__locals3.HGALnxmhFQ);
			if (宠物缓存数据类2 != null)
			{
				if (宠物缓存数据类2.武学 >= Singleton<全局变量类>.I.宠物突破配置.使用武学上限)
				{
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的武学已经达到了#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.使用武学上限);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.武学突破道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					myclient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				else
				{
					myclient.S_Send(Singleton<WdAPI>.I.ruAoIqjP2a(CS_0024_003C_003E8__locals3.HGALnxmhFQ, 道具格子).Concat(Singleton<WdAPI>.I.mgVIYoDksB(myclient.user.人物数据.昵称, 宠物缓存数据类2.宠物ID.ToString(), "martial", $"{宠物缓存数据类2.武学 + Singleton<全局变量类>.I.宠物突破配置.增加武学数值}", "admin_set_attrib")).ToArray(), "宠物武学突破处理");
					myclient.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#Y" + 宠物缓存数据类2.昵称A + "#n获得了#Y10000#n点武学。"));
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("宠物武学突破处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void pWTRUXW0Yj(MyNATSocketClient P_0, int P_1, int P_2, string P_3)
	{
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals3.QIkLfBLAPo = P_1;
		try
		{
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.Find( (宠物缓存数据类 a) => a.宠物ID != 0 && a.PetID == CS_0024_003C_003E8__locals3.QIkLfBLAPo);
			if (宠物缓存数据类2 != null)
			{
				if (宠物缓存数据类2.忠诚度 >= Singleton<全局变量类>.I.宠物突破配置.忠诚储备上限)
				{
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的忠诚存储已经达到了#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.忠诚储备上限);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.忠诚储备道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				else
				{
					P_0.S_Send(Singleton<WdAPI>.I.ruAoIqjP2a(CS_0024_003C_003E8__locals3.QIkLfBLAPo, P_2).Concat(Singleton<WdAPI>.I.mgVIYoDksB(P_0.user.人物数据.昵称, 宠物缓存数据类2.宠物ID.ToString(), "loyalty", $"{((宠物缓存数据类2.忠诚度 + Singleton<全局变量类>.I.宠物突破配置.忠诚储备数量 > Singleton<全局变量类>.I.宠物突破配置.忠诚储备上限) ? Singleton<全局变量类>.I.宠物突破配置.忠诚储备上限 : (宠物缓存数据类2.忠诚度 + Singleton<全局变量类>.I.宠物突破配置.忠诚储备数量))}", "admin_set_attrib")).ToArray(), "宠物武学突破处理");
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#Y");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.忠诚储备数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n点忠诚度存储。");
					P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("宠物忠诚储备处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void 宠物飞升突破处理(MyNATSocketClient myclient, int 宠物位置, int 道具格子, string 使用道具名字)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals3.MsJL2xFbDP = 宠物位置;
		try
		{
			宠物缓存数据类 宠物缓存数据类2 = myclient.user.宠物数据.Find( (宠物缓存数据类 a) => a.宠物ID != 0 && a.PetID == CS_0024_003C_003E8__locals3.MsJL2xFbDP);
			if (宠物缓存数据类2 != null)
			{
				if (宠物缓存数据类2.飞升 == 1)
				{
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n已经飞升，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.飞升突破道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n再次飞升。");
					myclient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				else if (宠物缓存数据类2.等级 < Singleton<全局变量类>.I.宠物突破配置.最低使用等级)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n等级不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.最低使用等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.飞升突破道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n进行飞升。");
					myclient.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				else if (宠物缓存数据类2.等级 > Singleton<全局变量类>.I.宠物突破配置.最高使用等级)
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n等级超过#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.最低使用等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.飞升突破道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n进行飞升。");
					myclient.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				else
				{
					myclient.S_Send(Singleton<WdAPI>.I.ruAoIqjP2a(CS_0024_003C_003E8__locals3.MsJL2xFbDP, 道具格子).Concat(Singleton<WdAPI>.I.mgVIYoDksB(myclient.user.人物数据.昵称, 宠物缓存数据类2.宠物ID.ToString(), "has_upgraded", "1", "admin_set_attrib")).ToArray(), "宠物飞升突破处理");
					myclient.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#R" + 宠物缓存数据类2.昵称A + "#n已经成功飞升，请重新分配属性加点。"));
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("宠物飞升突破处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void b3ZRWw4tvx(MyNATSocketClient P_0, int P_1, int P_2, string P_3)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals6.r3gLPbYy9G = P_1;
		try
		{
			if (Singleton<全局变量类>.I.宠物突破配置.强化进度组.Count <= Singleton<全局变量类>.I.宠物突破配置.强化最高上限)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + P_3 + "#n暂时无法使用。"));
				return;
			}
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.Find( (宠物缓存数据类 a) => a.宠物ID != 0 && a.PetID == CS_0024_003C_003E8__locals6.r3gLPbYy9G);
			if (宠物缓存数据类2 == null)
			{
				return;
			}
			AllEnums.宠物Type 宠物Type = Singleton<AllEnums>.I.Get宠物类型(宠物缓存数据类2.类型);
			if (Singleton<全局变量类>.I.宠物突破配置.Is禁止普通强化 && 宠物Type == AllEnums.宠物Type.普通)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R普通#n宠物暂时无法使用#R" + P_3 + "#n进行强化。"));
				return;
			}
			if (Singleton<全局变量类>.I.宠物突破配置.Is禁止变异强化 && 宠物Type == AllEnums.宠物Type.变异)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R变异#n宠物暂时无法使用#R" + P_3 + "#n进行强化。"));
				return;
			}
			if (Singleton<全局变量类>.I.宠物突破配置.Is禁止神兽强化 && 宠物Type == AllEnums.宠物Type.神兽)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R神兽#n宠物暂时无法使用#R" + P_3 + "#n进行强化。"));
				return;
			}
			if (Singleton<全局变量类>.I.宠物突破配置.Is禁止元灵强化 && 宠物Type == AllEnums.宠物Type.元灵)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R元灵#n宠物暂时无法使用#R" + P_3 + "#n进行强化。"));
				return;
			}
			if (Singleton<全局变量类>.I.宠物突破配置.Is禁止仙元强化 && 宠物Type == AllEnums.宠物Type.仙元)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R仙元#n宠物暂时无法使用#R" + P_3 + "#n进行强化。"));
				return;
			}
			int num = 0;
			bool flag = P_3 == Singleton<全局变量类>.I.宠物突破配置.法攻强化道具;
			if (flag)
			{
				if (宠物缓存数据类2.法攻强化次数 < Singleton<全局变量类>.I.宠物突破配置.强化最低上限)
				{
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的法攻强化次数不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.强化最低上限);
					defaultInterpolatedStringHandler.AppendLiteral("#n次，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_3);
					defaultInterpolatedStringHandler.AppendLiteral("#n进行法攻强化。");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (宠物缓存数据类2.法攻强化次数 >= Singleton<全局变量类>.I.宠物突破配置.强化最高上限)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的法攻强化次数已经达到#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.强化最高上限);
					defaultInterpolatedStringHandler.AppendLiteral("#n次，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_3);
					defaultInterpolatedStringHandler.AppendLiteral("#n进行法攻强化。");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				num = 宠物缓存数据类2.法攻强化次数 + 1;
			}
			else
			{
				if (宠物缓存数据类2.物攻强化次数 < Singleton<全局变量类>.I.宠物突破配置.强化最低上限)
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的物攻强化次数不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.强化最低上限);
					defaultInterpolatedStringHandler.AppendLiteral("#n次，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_3);
					defaultInterpolatedStringHandler.AppendLiteral("#n进行物攻强化。");
					P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (宠物缓存数据类2.物攻强化次数 >= Singleton<全局变量类>.I.宠物突破配置.强化最高上限)
				{
					WdAPI i4 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的物攻强化次数已经达到#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.强化最高上限);
					defaultInterpolatedStringHandler.AppendLiteral("#n次，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_3);
					defaultInterpolatedStringHandler.AppendLiteral("#n进行物攻强化。");
					P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				num = 宠物缓存数据类2.物攻强化次数 + 1;
			}
			int num2 = Singleton<全局变量类>.I.宠物突破配置.强化进度组[num];
			int num3 = 1;
			switch (宠物Type)
			{
			case AllEnums.宠物Type.变异:
				num3 = Singleton<全局变量类>.I.宠物突破配置.变异强化进度倍数;
				break;
			case AllEnums.宠物Type.神兽:
				num3 = Singleton<全局变量类>.I.宠物突破配置.神兽强化进度倍数;
				break;
			case AllEnums.宠物Type.元灵:
				num3 = Singleton<全局变量类>.I.宠物突破配置.元灵强化进度倍数;
				break;
			case AllEnums.宠物Type.仙元:
				num3 = Singleton<全局变量类>.I.宠物突破配置.仙元强化进度倍数;
				break;
			}
			num2 *= num3;
			double num4 = 100.0 / (double)num2;
			int num5 = Singleton<WdAPI>.I.qrjo9TWIdy(9000, 10000);
			bool flag2 = false;
			if (flag)
			{
				int num6 = 宠物缓存数据类2.法攻强化进度 + (int)(num4 * 100.0);
				flag2 = num6 >= 10000;
				if (!flag2 && num6 >= num5)
				{
					num5 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
					if (num5 >= 70)
					{
						flag2 = true;
					}
				}
				if (flag2)
				{
					P_0.S_Send(Singleton<WdAPI>.I.ruAoIqjP2a(CS_0024_003C_003E8__locals6.r3gLPbYy9G, P_2).Concat(Singleton<WdAPI>.I.mgVIYoDksB(P_0.user.人物数据.昵称, 宠物缓存数据类2.宠物ID.ToString(), "mag_rebuild_rate", "0", "admin_set_attrib")).Concat(Singleton<WdAPI>.I.mgVIYoDksB(P_0.user.人物数据.昵称, 宠物缓存数据类2.宠物ID.ToString(), "mag_rebuild_level", $"{num}", "admin_set_attrib"))
						.ToArray(), "宠物强化突破处理1");
					WdAPI i5 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#G恭喜，强化成功！#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的法攻成功强化到了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n次。");
					P_0.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				else
				{
					P_0.S_Send(Singleton<WdAPI>.I.ruAoIqjP2a(CS_0024_003C_003E8__locals6.r3gLPbYy9G, P_2).Concat(Singleton<WdAPI>.I.mgVIYoDksB(P_0.user.人物数据.昵称, 宠物缓存数据类2.宠物ID.ToString(), "mag_rebuild_rate", $"{num6}", "admin_set_attrib")).ToArray(), "宠物强化突破处理2");
					WdAPI i6 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 2);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，没有强化成功。但法攻增加#R");
					defaultInterpolatedStringHandler.AppendFormatted(num4, "F2");
					defaultInterpolatedStringHandler.AppendLiteral("%#n的强化完成度，当前强化完成度为#R");
					defaultInterpolatedStringHandler.AppendFormatted((double)num6 / 100.0, "F2");
					defaultInterpolatedStringHandler.AppendLiteral("%#n，强化完成度达到100%时即为成功。");
					P_0.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				return;
			}
			int num7 = 宠物缓存数据类2.物攻强化进度 + (int)(num4 * 100.0);
			flag2 = num7 >= 10000;
			if (!flag2 && num7 >= num5)
			{
				num5 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				if (num5 >= 70)
				{
					flag2 = true;
				}
			}
			if (flag2)
			{
				P_0.S_Send(Singleton<WdAPI>.I.ruAoIqjP2a(CS_0024_003C_003E8__locals6.r3gLPbYy9G, P_2).Concat(Singleton<WdAPI>.I.mgVIYoDksB(P_0.user.人物数据.昵称, 宠物缓存数据类2.宠物ID.ToString(), "phy_rebuild_rate", "0", "admin_set_attrib")).Concat(Singleton<WdAPI>.I.mgVIYoDksB(P_0.user.人物数据.昵称, 宠物缓存数据类2.宠物ID.ToString(), "phy_rebuild_level", $"{num}", "admin_set_attrib"))
					.ToArray(), "宠物强化突破处理3");
				WdAPI i7 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#G恭喜，强化成功！#R");
				defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n的物攻成功强化到了#R");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n次。");
				P_0.C_Send(i7.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else
			{
				P_0.S_Send(Singleton<WdAPI>.I.ruAoIqjP2a(CS_0024_003C_003E8__locals6.r3gLPbYy9G, P_2).Concat(Singleton<WdAPI>.I.mgVIYoDksB(P_0.user.人物数据.昵称, 宠物缓存数据类2.宠物ID.ToString(), "phy_rebuild_rate", $"{num7}", "admin_set_attrib")).ToArray(), "宠物强化突破处理4");
				WdAPI i8 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 2);
				defaultInterpolatedStringHandler.AppendLiteral("很遗憾，没有强化成功。但物攻增加#R");
				defaultInterpolatedStringHandler.AppendFormatted(num4, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n的强化完成度，当前强化完成度为#R");
				defaultInterpolatedStringHandler.AppendFormatted((double)num7 / 100.0, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n，强化完成度达到100%时即为成功。");
				P_0.C_Send(i8.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("宠物强化突破处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private bool F0eRguMa3U(MyNATSocketClient P_0, int P_1, int P_2, string P_3)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals2.Q7yLFuJ06f = P_1;
		try
		{
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.Find( (宠物缓存数据类 a) => a.宠物ID != 0 && a.PetID == CS_0024_003C_003E8__locals2.Q7yLFuJ06f);
			if (宠物缓存数据类2 == null)
			{
				return false;
			}
			if (P_3 == Singleton<全局变量类>.I.宠物突破配置.血量幻化道具)
			{
				if (宠物缓存数据类2.血量幻化次数 < Singleton<全局变量类>.I.宠物突破配置.幻化最低上限)
				{
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的血量幻化次数不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.幻化最低上限);
					defaultInterpolatedStringHandler.AppendLiteral("#n次，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_3);
					defaultInterpolatedStringHandler.AppendLiteral("#n进行血量幻化。");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (宠物缓存数据类2.血量幻化次数 >= Singleton<全局变量类>.I.宠物突破配置.幻化最高上限)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的血量幻化次数已经达到#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物突破配置.幻化最高上限);
					defaultInterpolatedStringHandler.AppendLiteral("#n次，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_3);
					defaultInterpolatedStringHandler.AppendLiteral("#n进行血量幻化。");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("宠物幻化突破处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return false;
		}
	}

	
	public U8hGTORuviqLJbXPJ0Y()
	{
	}

	
	static U8hGTORuviqLJbXPJ0Y()
	{
		HvERl5OIw9 = string.Empty;
	}
}
