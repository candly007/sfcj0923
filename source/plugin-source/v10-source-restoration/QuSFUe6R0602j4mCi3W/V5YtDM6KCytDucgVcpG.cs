using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Serilog;
using hUWm54DrC1dskj6PIsS;
using r6H7Ets2Rns31EhC17Y;

namespace QuSFUe6R0602j4mCi3W;

internal class V5YtDM6KCytDucgVcpG : Singleton<V5YtDM6KCytDucgVcpG>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public MyNATSocketClient jRJ9LTiO5r;

		public int QBB9SiffHY;

		public int N0A9cggnSj;

		
		public _003C_003Ec__DisplayClass1_0()
		{
		}

		
		internal bool gVx9FfivJf(string x)
		{
			if (!(x == jRJ9LTiO5r.user.背包数据.物品列表[QBB9SiffHY].名字))
			{
				return x == jRJ9LTiO5r.user.背包数据.物品列表[N0A9cggnSj].名字;
			}
			return true;
		}

		static _003C_003Ec__DisplayClass1_0()
		{
		}
	}

	
	internal byte[] vFd6dErhDH(MyNATSocketClient P_0, byte[] P_1)
	{
		short num = Singleton<ByteAPI>.I.反转_短整数(Singleton<ByteAPI>.I.取字节集中间(P_1, 16, 2));
		if (全局变量类.Is调试)
		{
			Log.Error("鬼斧神工请求类型：" + num);
		}
		switch (num)
		{
		case 87:
			return Goc6sZFhHS(P_0, P_1);
		case 81:
			return S0L6gdWjIE(P_1);
		case 73:
			return Xyb6Wdykta(P_1);
		case 95:
			return iJp6DjCFdb(P_1);
		case 96:
			return H7a6jhC5DP(P_1);
		case 82:
			return DBF6lQpbgi(P_1);
		case 118:
			return W9a68pDhWf(P_1);
		case 57:
			return h5S6IPAjYq(P_1);
		case 111:
			return Lqj6oQHceB(P_1);
		case 98:
			return PA86NMJElG(P_1);
		case 49:
			return wZV6iw1MD5(P_1);
		case 51:
			return Wf86BS4a3s(P_1);
		case 102:
			return WFv6GxVgnU(P_1);
		case 64:
			return NfA6frx9Hk(P_1);
		case 114:
			return Ifi66qONDK(P_1);
		case 116:
			return pZG62LSxUN(P_1);
		case 117:
			return K7x6Pwt0jJ(P_1);
		case 109:
			if (Singleton<全局变量类>.I.宠物同源配置.功能开关)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R禁止转化宠物！"));
				return null;
			}
			break;
		case 71:
			return aIr6Ude4pb(P_0, P_1);
		}
		return P_1;
	}

	
	private byte[] Goc6sZFhHS(MyNATSocketClient P_0, byte[] P_1)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals11.jRJ9LTiO5r = P_0;
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(12L, SeekOrigin.Begin);
			封包_读2.读整数型(reverse: true, out var _);
			封包_读2.读短整数型(reverse: true, out var _);
			封包_读2.读字节型(out var _);
			封包_读2.Seek(3L, SeekOrigin.Current);
			CS_0024_003C_003E8__locals11.QBB9SiffHY = 封包_读2.读字节型();
			封包_读2.Seek(3L, SeekOrigin.Current);
			CS_0024_003C_003E8__locals11.N0A9cggnSj = 封包_读2.读字节型();
			if (CS_0024_003C_003E8__locals11.QBB9SiffHY < 0 || CS_0024_003C_003E8__locals11.QBB9SiffHY > 300)
			{
				return null;
			}
			if (CS_0024_003C_003E8__locals11.N0A9cggnSj < 0 || CS_0024_003C_003E8__locals11.N0A9cggnSj > 300)
			{
				return null;
			}
			if (全局常量类.全_首饰.Any( (string x) => x == CS_0024_003C_003E8__locals11.jRJ9LTiO5r.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.QBB9SiffHY].名字 || x == CS_0024_003C_003E8__locals11.jRJ9LTiO5r.user.背包数据.物品列表[CS_0024_003C_003E8__locals11.N0A9cggnSj].名字))
			{
				return null;
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_首饰强化请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private byte[] aIr6Ude4pb(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(4L, SeekOrigin.Begin);
			封包_读2.读字节集(4, out byte[] value);
			if (QxBx5YDqZUOBMg9A6NN.WFbjwFZLly() && !Singleton<WdAPI>.I.bJboBw7BEu(P_0, value))
			{
				return null;
			}
			封包_读2.读字节集(4);
			封包_读2.读整数型(reverse: true, out var _);
			封包_读2.读短整数型(reverse: true, out var _);
			封包_读2.读字节型(out var _);
			封包_读2.读整数型(reverse: true, out P_0.user.缓存数据.超级进化格子);
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_装备进化请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] Xyb6Wdykta(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_粉材炼化)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_粉材炼化请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] S0L6gdWjIE(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_批量鉴定)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_批量鉴定请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] iJp6DjCFdb(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_装备封印)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_装备封印请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] H7a6jhC5DP(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_装备封印)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_装备解封请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] DBF6lQpbgi(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_装备共鸣)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_单次共鸣请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] W9a68pDhWf(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_装备共鸣)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_一键共鸣请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] h5S6IPAjYq(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_装备镶嵌)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_宝石镶嵌请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] Lqj6oQHceB(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_宝石拆分)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_宝石拆分请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] PA86NMJElG(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_骑宠融合)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_骑宠融合请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] wZV6iw1MD5(byte[] P_0)
	{
		try
		{
			if ((Singleton<全局变量类>.I.验证client.授权配置.Is一四怀旧 || 全局变量类.Is调试) && Singleton<全局变量类>.I.怀旧专区配置.功能开关 && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_猎取魂兽)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_猎取魂兽请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] Wf86BS4a3s(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_升级魂兽)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_升级魂兽请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] WFv6GxVgnU(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_宠物顿悟)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_宠物顿悟请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] NfA6frx9Hk(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_宠物心法)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_宠物心法请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] Ifi66qONDK(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_天书强化)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_天书强化请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] pZG62LSxUN(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_天书转属)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_天书转属请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] yj26miBhHl(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_法宝转换)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_法宝转换请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	private static byte[] K7x6Pwt0jJ(byte[] P_0)
	{
		try
		{
			if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_天书继承)
			{
				P_0[22] = 0;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("鬼斧_天书继承请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	public V5YtDM6KCytDucgVcpG()
	{
	}

	static V5YtDM6KCytDucgVcpG()
	{
	}
}
