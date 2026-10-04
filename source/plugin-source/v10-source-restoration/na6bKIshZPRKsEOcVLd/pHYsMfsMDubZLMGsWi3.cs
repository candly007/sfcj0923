using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Serilog;

namespace na6bKIshZPRKsEOcVLd;

internal class pHYsMfsMDubZLMGsWi3 : Singleton<pHYsMfsMDubZLMGsWi3>
{
	
	internal async Task dlXsvFbU82(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 3)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的背包格子不足3个，无法进行悟道转换。"));
				return;
			}
			switch (Singleton<全局变量类>.I.config.悟道转换消耗类型)
			{
			case AllEnums.数值Type.金元宝:
				if (P_0.user.背包数据.金元宝 < Singleton<全局变量类>.I.config.悟道转换消耗)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的金元宝不足，无法进行悟道转换。"));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, -Singleton<全局变量类>.I.config.悟道转换消耗, 0))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的金元宝不足，无法进行悟道转换。"));
					return;
				}
				break;
			case AllEnums.数值Type.银元宝:
				if (P_0.user.背包数据.银元宝 < Singleton<全局变量类>.I.config.悟道转换消耗)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的银元宝不足，无法进行悟道转换。"));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, -Singleton<全局变量类>.I.config.悟道转换消耗, 0))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的金元宝不足，无法进行悟道转换。"));
					return;
				}
				break;
			case AllEnums.数值Type.金钱:
				if (P_0.user.背包数据.金钱 < Singleton<全局变量类>.I.config.悟道转换消耗)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的游戏币不足，无法进行悟道转换。"));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -Singleton<全局变量类>.I.config.悟道转换消耗, false, "[悟道转换]消耗");
				break;
			}
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, "修为丹", AllEnums.指令Type.无, 3, false, "悟道金钱转换");
			await Task.Delay(3000);
			List<int> list = Singleton<WdAPI>.I.取背包物品格子组(P_0, "修为丹");
			if (list.Count >= 3)
			{
				P_0.S_Send(Singleton<WdAPI>.I.组包包头(Singleton<ByteAPI>.I.HtoC("2112")));
				封包_写 封包_写2 = new 封包_写();
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("1042"), hasCount: false, 0);
				封包_写2.写整数型(P_0.user.人物数据.角色ID, reverse: true);
				封包_写2.写文本型("$提交道具", hasCount: true, 0, reverse: true);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
				defaultInterpolatedStringHandler.AppendLiteral("money: 0,");
				defaultInterpolatedStringHandler.AppendFormatted(list[0]);
				defaultInterpolatedStringHandler.AppendLiteral(":1,");
				defaultInterpolatedStringHandler.AppendFormatted(list[1]);
				defaultInterpolatedStringHandler.AppendLiteral(":1,");
				defaultInterpolatedStringHandler.AppendFormatted(list[2]);
				defaultInterpolatedStringHandler.AppendLiteral(":1");
				封包_写2.写文本型(defaultInterpolatedStringHandler.ToStringAndClear(), hasCount: true, 0, reverse: true);
				封包_写2.写整数型(P_0.user.人物数据.角色ID, reverse: true);
				封包_写 封包_写3 = new 封包_写();
				封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
				封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
				P_0.S_Send(封包_写3.取数据());
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你使用了");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.config.悟道转换消耗));
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.悟道转换消耗类型);
				defaultInterpolatedStringHandler.AppendLiteral("增加了一次悟道转换属性次数。");
				byte[] first = i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear());
				WdAPI i2 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你使用了");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.config.悟道转换消耗));
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.悟道转换消耗类型);
				defaultInterpolatedStringHandler.AppendLiteral("增加了一次悟道转换属性次数。");
				P_0.C_Send(first.Concat(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
				P_0.S_Send(Singleton<ByteAPI>.I.HtoC("26020000"));
			}
		}
		catch (Exception ex)
		{
			Log.Error("悟道转换事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal bool leXs7LK1TY(MyNATSocketClient P_0, string P_1)
	{
		string[] array = P_1.Split(",");
		if (array.Length == 3)
		{
			int result = 0;
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i].Split(":")[0], out result) && Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result) && P_0.user.背包数据.物品列表[int.Parse(array[i].Split(":")[0])].名字 == "修为丹")
				{
					num++;
				}
			}
			if (num == 3)
			{
				return true;
			}
		}
		return false;
	}

	
	public pHYsMfsMDubZLMGsWi3()
	{
	}

	static pHYsMfsMDubZLMGsWi3()
	{
	}
}
