using System;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace LpZ3AarVOTSw8FiAAE;

internal class WI2SZ8qRj7MBmbqI09 : Singleton<WI2SZ8qRj7MBmbqI09>
{
	
	internal void DaKZv4wqL()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("礼包开元宝配置类.json")))
			{
				Singleton<全局变量类>.I.礼包开元宝配置 = JsonConvert.DeserializeObject<礼包开元宝配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("礼包开元宝配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.礼包开元宝配置 = new 礼包开元宝配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("礼包开元宝配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.礼包开元宝配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("礼包开元宝配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void K7btGQrgN()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("礼包开元宝配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.礼包开元宝配置, Formatting.Indented));
			Log.Debug("礼包开元宝配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("礼包开元宝配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string UMDAfv45b()
	{
		DaKZv4wqL();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.礼包开元宝配置, Formatting.Indented);
	}

	
	public void v6czMOSJa(string P_0)
	{
		Singleton<全局变量类>.I.礼包开元宝配置 = JsonConvert.DeserializeObject<礼包开元宝配置类>(P_0);
		K7btGQrgN();
	}

	
	internal void J1Twu0eM9a(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (!Singleton<全局变量类>.I.礼包开元宝配置.礼包列表.TryGetValue(P_1, out int[] value) || value.Length == 0)
			{
				return;
			}
			if (value.Length >= 2 && (value[0] != 0 || value[1] != 0) && DB.I.cAJNoOkab6(P_0, value[0], value[1]))
			{
				if (value[0] != 0)
				{
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你得到了#R");
					defaultInterpolatedStringHandler.AppendFormatted(value[0]);
					defaultInterpolatedStringHandler.AppendLiteral("#n金元宝。");
					P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				if (value[1] != 0)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你得到了#R");
					defaultInterpolatedStringHandler.AppendFormatted(value[1]);
					defaultInterpolatedStringHandler.AppendLiteral("#n银元宝。");
					P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			}
			if (value.Length >= 3 && value[2] != 0)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, value[2], false, "礼包[" + P_1 + "]开");
				WdAPI i3 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你得到了#R");
				defaultInterpolatedStringHandler.AppendFormatted(value[2]);
				defaultInterpolatedStringHandler.AppendLiteral("#n累充点。");
				P_0.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			if (value.Length >= 4 && value[3] != 0)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, value[3], false, "礼包[" + P_1 + "]获得");
				WdAPI i4 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你得到了#R");
				defaultInterpolatedStringHandler.AppendFormatted(value[3]);
				defaultInterpolatedStringHandler.AppendLiteral("#n南极点。");
				P_0.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			if (value.Length >= 5 && value[4] != 0)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, value[4], false, "[" + P_1 + "]打开增加");
				WdAPI i5 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你得到了#R");
				defaultInterpolatedStringHandler.AppendFormatted(value[4]);
				defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点。");
				P_0.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			if (value.Length >= 6 && value[5] != 0)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, value[5], false, "[" + P_1 + "]打开增加");
				WdAPI i6 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你得到了#R");
				defaultInterpolatedStringHandler.AppendFormatted(value[5]);
				defaultInterpolatedStringHandler.AppendLiteral("#n点灵气值。");
				P_0.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("打开元宝礼包处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public WI2SZ8qRj7MBmbqI09()
	{
	}

	static WI2SZ8qRj7MBmbqI09()
	{
	}
}
