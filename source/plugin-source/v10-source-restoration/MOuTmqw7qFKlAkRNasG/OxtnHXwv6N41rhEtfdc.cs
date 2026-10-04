using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace MOuTmqw7qFKlAkRNasG;

internal class OxtnHXwv6N41rhEtfdc : Singleton<OxtnHXwv6N41rhEtfdc>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public int v69XvYQDkb;

		
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		
		internal bool fsnXh6kOTG(南极抽奖物品类 a)
		{
			if ((int)a.等级 >= v69XvYQDkb)
			{
				return a.is大额;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass4_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_1
	{
		public int UOVXanlih2;

		
		public _003C_003Ec__DisplayClass4_1()
		{
		}

		
		internal bool L2wX7TQCu4(南极抽奖物品类 a)
		{
			if ((int)a.等级 >= UOVXanlih2)
			{
				return !a.is大额;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass4_1()
		{
		}
	}

	
	internal void PTqwav30x0()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("南极配置类.json")))
			{
				Singleton<全局变量类>.I.南极配置 = JsonConvert.DeserializeObject<南极配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("南极配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.南极配置 = new 南极配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("南极配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.南极配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("南极配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void zntwT68bbV()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("南极配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.南极配置, Formatting.Indented));
			Log.Debug("南极配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("南极配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string eM8w9U81fV()
	{
		PTqwav30x0();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.南极配置, Formatting.Indented);
	}

	
	public void eybwyF7b1e(string P_0)
	{
		Singleton<全局变量类>.I.南极配置 = JsonConvert.DeserializeObject<南极配置类>(P_0);
		zntwT68bbV();
	}

	
	internal void KWVwC5uwbQ(MyNATSocketClient P_0)
	{
		try
		{
			if (P_0.user.缓存数据.is南极大额)
			{
				if (P_0.user.存档数据.南极抽奖次数 < 10)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R抽奖次数不足#n,无法进行抽奖！"));
					return;
				}
				if (Singleton<全局变量类>.I.南极配置.奖池.Count( (南极抽奖物品类 x) => x.is大额) <= 0)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R当前大额奖池空了#n,暂无法进行抽奖！"));
					return;
				}
			}
			if (!P_0.user.缓存数据.is南极大额)
			{
				if (P_0.user.存档数据.南极抽奖次数 < 1)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R抽奖次数不足#n,无法进行抽奖！"));
					return;
				}
				if (Singleton<全局变量类>.I.南极配置.奖池.Count( (南极抽奖物品类 x) => !x.is大额) <= 0)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R当前小额奖池空了#n,暂无法进行抽奖！"));
					return;
				}
			}
			Singleton<全局变量类>.I.全服共享存档数据.南极抽奖总次数 += ((!P_0.user.缓存数据.is南极大额) ? 1 : 10);
			南极抽奖物品类 南极抽奖物品类2 = null;
			if (P_0.user.缓存数据.is南极大额)
			{
				if (Singleton<全局变量类>.I.全服共享存档数据.南极抽奖总次数 >= Singleton<全局变量类>.I.南极配置.总累计出特等)
				{
					List<南极抽奖物品类> list = Singleton<全局变量类>.I.南极配置.奖池.FindAll( (南极抽奖物品类 a) => a.等级 == AllEnums.奖品Type.特等奖 && a.is大额);
					if (list.Count <= 0)
					{
						Singleton<全局变量类>.I.全服共享存档数据.南极抽奖总次数 -= 10;
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R大额抽奖奖池不足#n,无法进行抽奖！"));
						return;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, -10, false, "[南极大额]消耗");
					Singleton<全局变量类>.I.全服共享存档数据.南极抽奖总次数 = 0;
					int index = Singleton<WdAPI>.I.qrjo9TWIdy(0, list.Count - 1);
					南极抽奖物品类2 = list[index];
				}
				else
				{
					_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals26 = new _003C_003Ec__DisplayClass4_0();
					CS_0024_003C_003E8__locals26.v69XvYQDkb = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
					if (CS_0024_003C_003E8__locals26.v69XvYQDkb > 40)
					{
						CS_0024_003C_003E8__locals26.v69XvYQDkb = 4;
					}
					else if (CS_0024_003C_003E8__locals26.v69XvYQDkb > 20 && CS_0024_003C_003E8__locals26.v69XvYQDkb <= 40)
					{
						CS_0024_003C_003E8__locals26.v69XvYQDkb = 3;
					}
					else if (CS_0024_003C_003E8__locals26.v69XvYQDkb > 10 && CS_0024_003C_003E8__locals26.v69XvYQDkb <= 20)
					{
						CS_0024_003C_003E8__locals26.v69XvYQDkb = 2;
					}
					else
					{
						CS_0024_003C_003E8__locals26.v69XvYQDkb = 1;
					}
					List<南极抽奖物品类> list2 = Singleton<全局变量类>.I.南极配置.奖池.FindAll( (南极抽奖物品类 a) => (int)a.等级 >= CS_0024_003C_003E8__locals26.v69XvYQDkb && a.is大额);
					if (list2.Count <= 0)
					{
						Singleton<全局变量类>.I.全服共享存档数据.南极抽奖总次数 -= 10;
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R大额抽奖奖池不足#n,无法进行抽奖！"));
						return;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, -10, false, "[南极大额]消耗");
					CS_0024_003C_003E8__locals26.v69XvYQDkb = Singleton<WdAPI>.I.qrjo9TWIdy(0, list2.Count - 1);
					南极抽奖物品类2 = list2[CS_0024_003C_003E8__locals26.v69XvYQDkb];
				}
			}
			else if (Singleton<全局变量类>.I.全服共享存档数据.南极抽奖总次数 >= Singleton<全局变量类>.I.南极配置.总累计出特等)
			{
				List<南极抽奖物品类> list3 = Singleton<全局变量类>.I.南极配置.奖池.FindAll( (南极抽奖物品类 a) => a.等级 == AllEnums.奖品Type.特等奖 && !a.is大额);
				if (list3.Count <= 0)
				{
					Singleton<全局变量类>.I.全服共享存档数据.南极抽奖总次数--;
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R小额抽奖奖池不足#n,无法进行抽奖！"));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, -1, false, "[南极小额]消耗");
				Singleton<全局变量类>.I.全服共享存档数据.南极抽奖总次数 = 0;
				int index2 = Singleton<WdAPI>.I.qrjo9TWIdy(0, list3.Count - 1);
				南极抽奖物品类2 = list3[index2];
			}
			else
			{
				_003C_003Ec__DisplayClass4_1 CS_0024_003C_003E8__locals27 = new _003C_003Ec__DisplayClass4_1();
				CS_0024_003C_003E8__locals27.UOVXanlih2 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				if (CS_0024_003C_003E8__locals27.UOVXanlih2 > 40)
				{
					CS_0024_003C_003E8__locals27.UOVXanlih2 = 4;
				}
				else if (CS_0024_003C_003E8__locals27.UOVXanlih2 > 20 && CS_0024_003C_003E8__locals27.UOVXanlih2 <= 40)
				{
					CS_0024_003C_003E8__locals27.UOVXanlih2 = 3;
				}
				else if (CS_0024_003C_003E8__locals27.UOVXanlih2 > 10 && CS_0024_003C_003E8__locals27.UOVXanlih2 <= 20)
				{
					CS_0024_003C_003E8__locals27.UOVXanlih2 = 2;
				}
				else
				{
					CS_0024_003C_003E8__locals27.UOVXanlih2 = 1;
				}
				List<南极抽奖物品类> list4 = Singleton<全局变量类>.I.南极配置.奖池.FindAll( (南极抽奖物品类 a) => (int)a.等级 >= CS_0024_003C_003E8__locals27.UOVXanlih2 && !a.is大额);
				if (list4.Count <= 0)
				{
					Singleton<全局变量类>.I.全服共享存档数据.南极抽奖总次数--;
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R小额抽奖奖池不足#n,无法进行抽奖！"));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, -1, false, "[南极小额]消耗");
				CS_0024_003C_003E8__locals27.UOVXanlih2 = Singleton<WdAPI>.I.qrjo9TWIdy(0, list4.Count - 1);
				南极抽奖物品类2 = list4[CS_0024_003C_003E8__locals27.UOVXanlih2];
			}
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 南极抽奖物品类2.名字, AllEnums.指令Type.无, 南极抽奖物品类2.数量, false, P_0.user.缓存数据.is南极大额 ? "南极大额抽奖" : "南极小额抽奖");
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你在#R南极抽奖活动#n中抽取到了#R" + 南极抽奖物品类2.名字 + "#n的奖励。").Concat(Singleton<WdAPI>.I.提示_杂项公告("你获得了#R1#n个#R" + 南极抽奖物品类2.名字 + "#n。")).Concat(REqwktPvth(南极抽奖物品类2))
				.ToArray());
			if (南极抽奖物品类2.等级 == AllEnums.奖品Type.特等奖)
			{
				Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
				if (client频道事件 != null)
				{
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#24恭喜#Y#<");
					defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("#>#n在#R南极抽奖活动#n中获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(南极抽奖物品类2.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n!赶快找南极仙翁进行抽奖吧！");
					byte[] first = i.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员");
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#24恭喜#Y#<");
					defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("#>#n在#R南极抽奖活动#n中获得了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(南极抽奖物品类2.名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n!赶快找南极仙翁进行抽奖吧！");
					client频道事件(first.Concat(i2.PWRouuXjmn(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
				}
			}
			P_0.C_Send(eoBwVUA7AP(P_0));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("南极抽奖_开始抽奖-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private byte[] eoBwVUA7AP(MyNATSocketClient P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("218704"), hasCount: false, 0);
		封包_写2.写整数型(P_0.user.缓存数据.is南极大额 ? (P_0.user.存档数据.南极抽奖次数 / 10) : P_0.user.存档数据.南极抽奖次数, reverse: true);
		封包_写2.写字节集((!P_0.user.缓存数据.is南极大额) ? new byte[2] { 1, 0 } : new byte[2] { 2, 0 }, hasCount: false, 0);
		封包_写2.写文本型(Singleton<全局变量类>.I.南极配置.活动描述, hasCount: true, 1, reverse: true);
		封包_写2.写整数型((int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.南极配置.到期时间), reverse: true);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	private byte[] REqwktPvth(南极抽奖物品类 P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("20B3"), hasCount: false, 0);
		封包_写2.写文本型(P_0.名字, hasCount: true, 0, reverse: true);
		封包_写2.写整数型(P_0.图标, reverse: true);
		封包_写2.写文本型(P_0.名字, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("090400"), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal void L09w0kkdIi(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) <= 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的包裹空位不足，暂无法兑换道具。"));
				return;
			}
			P_0.user.缓存数据.is南极大额 = P_1 == "南极抽取奖励_大额";
			P_0.C_Send(eoBwVUA7AP(P_0));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("请求_南极事件处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public OxtnHXwv6N41rhEtfdc()
	{
	}

	static OxtnHXwv6N41rhEtfdc()
	{
	}
}
