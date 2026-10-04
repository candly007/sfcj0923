using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace S0XwWmgI18jlYE3IPoe;

internal class VlLcswg81JdPCi5w8lm : Singleton<VlLcswg81JdPCi5w8lm>
{
	
	internal void YXfgo5Qtcc()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("累充配置类.json")))
			{
				Singleton<全局变量类>.I.累充配置 = JsonConvert.DeserializeObject<累充配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("累充配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.累充配置 = new 累充配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("累充配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.累充配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("累充配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void AqsgNkkkLF()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("累充配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.累充配置, Formatting.Indented));
			Log.Debug("累充配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("累充配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string fTSgiE2Qro()
	{
		YXfgo5Qtcc();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.累充配置, Formatting.Indented);
	}

	
	public void SokgBiG3MJ(string P_0)
	{
		Singleton<全局变量类>.I.累充配置 = JsonConvert.DeserializeObject<累充配置类>(P_0);
		AqsgNkkkLF();
	}

	
	internal void cKSgGJIkAf(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(14L, SeekOrigin.Begin);
			if (!int.TryParse(obj.读文本型(是否声明长度: true, 0, 是否反转长度: true), out var result) || result > 4 || result < 0)
			{
				return;
			}
			if (Singleton<全局变量类>.I.累充配置.奖励列表.Count <= 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("服务器繁忙，请稍后再试！"));
				return;
			}
			if (result - P_0.user.存档数据.累计充值_奖励领取情况 != 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请按顺序依次领取奖励！"));
				return;
			}
			if (P_0.user.存档数据.累计充值金额 < Singleton<全局变量类>.I.累充配置.奖励列表[result].阶段)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你还未达到领取要求！"));
				return;
			}
			if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < Singleton<全局变量类>.I.累充配置.奖励列表[result].奖励列表.Count)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的包裹栏空位不足，无法领取累充奖励！"));
				return;
			}
			for (int i = 0; i < Singleton<全局变量类>.I.累充配置.奖励列表[result].奖励列表.Count; i++)
			{
				WdAPI i2 = Singleton<WdAPI>.I;
				string obj2 = Singleton<全局变量类>.I.累充配置.奖励列表[result].奖励列表[i][0];
				int num = int.Parse(Singleton<全局变量类>.I.累充配置.奖励列表[result].奖励列表[i][1]);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 3);
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now);
				defaultInterpolatedStringHandler.AppendLiteral(" 发送累充奖励");
				defaultInterpolatedStringHandler.AppendFormatted(result + 1);
				defaultInterpolatedStringHandler.AppendLiteral(" 领取人[");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				i2.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, obj2, AllEnums.指令Type.无, num, false, defaultInterpolatedStringHandler.ToStringAndClear());
			}
			P_0.user.存档数据.累计充值_奖励领取情况++;
			P_0.C_Send(zl7gfNTsJC(P_0));
		}
		catch (Exception ex)
		{
			Log.Error("累充领取奖励-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public byte[] zl7gfNTsJC(MyNATSocketClient P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("3E11"), hasCount: false, 0);
		封包_写2.写文本型(Singleton<全局变量类>.I.累充配置.开启时间, hasCount: true, 0, reverse: true);
		封包_写2.写文本型(Singleton<全局变量类>.I.累充配置.结束时间, hasCount: true, 0, reverse: true);
		封包_写2.写文本型(Singleton<全局变量类>.I.累充配置.截止时间, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("01"), hasCount: false, 0);
		封包_写2.写整数型(P_0.user.存档数据.累计充值金额, reverse: true);
		封包_写2.写字节型(WSBg61P3ED(P_0.user.存档数据.累计充值_奖励领取情况));
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("003C05"), hasCount: false, 0);
		Singleton<全局变量类>.I.累充配置.奖励列表.ToList().Sort();
		foreach (累充奖励列表类 item in Singleton<全局变量类>.I.累充配置.奖励列表)
		{
			封包_写2.写整数型(item.阶段, reverse: true);
			封包_写2.写字节型(item.奖励列表.Count);
			for (int i = 0; i < item.奖励列表.Count; i++)
			{
				封包_写2.写文本型(item.奖励列表[i][0], hasCount: true, 0, reverse: true);
				封包_写2.写短整数型(short.Parse(item.奖励列表[i][1]), reverse: true);
			}
		}
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	private int WSBg61P3ED(int P_0)
	{
		switch (P_0)
		{
		case 0:
			return 0;
		case 1:
			return 1;
		case 2:
			return 3;
		case 3:
			return 7;
		case 4:
			return 15;
		default:
			_ = 5;
			return 31;
		}
	}

	
	public VlLcswg81JdPCi5w8lm()
	{
	}

	static VlLcswg81JdPCi5w8lm()
	{
	}
}
