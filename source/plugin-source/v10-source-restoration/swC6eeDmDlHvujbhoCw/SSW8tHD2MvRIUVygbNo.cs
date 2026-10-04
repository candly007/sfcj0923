using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft_X.Json;
using Serilog;
using jVVIM9j1PL0VAliGELE;
using vEAdPGPTkDFOYsbi303;

namespace swC6eeDmDlHvujbhoCw;

internal class SSW8tHD2MvRIUVygbNo : Singleton<SSW8tHD2MvRIUVygbNo>
{
	
	internal void tI9DP8J1fx()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("试道大会配置类.json")))
			{
				Singleton<全局变量类>.I.试道大会配置 = JsonConvert.DeserializeObject<试道大会配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("试道大会配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.试道大会配置 = new 试道大会配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("试道大会配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.百炼功能配置, Formatting.Indented));
			}
			if (Singleton<全局变量类>.I.试道大会配置.队伍最高人数 == 0)
			{
				Singleton<全局变量类>.I.试道大会配置.队伍最高人数 = 5;
			}
		}
		catch (Exception ex)
		{
			Log.Error("试道大会配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void gOZDX8GXEE()
	{
		try
		{
			if (Singleton<全局变量类>.I.试道大会配置.队伍最高人数 == 0)
			{
				Singleton<全局变量类>.I.试道大会配置.队伍最高人数 = 5;
			}
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("试道大会配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.试道大会配置, Formatting.Indented));
			Log.Debug("试道大会配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("试道大会配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string ODUDFZHiP3()
	{
		tI9DP8J1fx();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.试道大会配置, Formatting.Indented);
	}

	
	public void Vl9DLiO3M1(string P_0)
	{
		Singleton<全局变量类>.I.试道大会配置 = JsonConvert.DeserializeObject<试道大会配置类>(P_0);
		gOZDX8GXEE();
	}

	
	public void TTdDSExcHm(MyNATSocketClient P_0)
	{
		switch (Singleton<全局变量类>.I.试道大会配置.参与奖励.奖励类型)
		{
		case AllEnums.数值Type.金元宝:
			DB.I.cAJNoOkab6(P_0, Singleton<全局变量类>.I.试道大会配置.参与奖励.获得数量, 0);
			break;
		case AllEnums.数值Type.银元宝:
			DB.I.cAJNoOkab6(P_0, 0, Singleton<全局变量类>.I.试道大会配置.参与奖励.获得数量);
			break;
		case AllEnums.数值Type.金钱:
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, Singleton<全局变量类>.I.试道大会配置.参与奖励.获得数量, false, "[试道]获得");
			break;
		case AllEnums.数值Type.累充点:
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, Singleton<全局变量类>.I.试道大会配置.参与奖励.获得数量, false, "试道发送");
			break;
		case AllEnums.数值Type.南极点:
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, Singleton<全局变量类>.I.试道大会配置.参与奖励.获得数量, false, "[试道]获得");
			break;
		case AllEnums.数值Type.道具:
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.试道大会配置.参与奖励.奖励名字, AllEnums.指令Type.无, Singleton<全局变量类>.I.试道大会配置.参与奖励.获得数量, false, "试道发送");
			break;
		case AllEnums.数值Type.奇宝点:
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, Singleton<全局变量类>.I.试道大会配置.参与奖励.获得数量, false, "[试道]获得");
			break;
		}
		WdAPI i = Singleton<WdAPI>.I;
		string 提示内容 = "#Y由于你积极参与试道大会活动，系统将发放参与试道活动奖励。";
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
		defaultInterpolatedStringHandler.AppendLiteral("由于你积极参与试道大会活动，恭喜系统奖励的#Y");
		defaultInterpolatedStringHandler.AppendFormatted((Singleton<全局变量类>.I.试道大会配置.参与奖励.奖励类型 != AllEnums.数值Type.道具) ? Singleton<全局变量类>.I.试道大会配置.参与奖励.奖励类型.ToString() : Singleton<全局变量类>.I.试道大会配置.参与奖励.奖励名字);
		defaultInterpolatedStringHandler.AppendLiteral("×");
		defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.试道大会配置.参与奖励.获得数量);
		defaultInterpolatedStringHandler.AppendLiteral("#n");
		P_0.C_Send(i.提示_提醒和杂项公告(提示内容, defaultInterpolatedStringHandler.ToStringAndClear()));
	}

	
	public void zjBDcFQnMU(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (!P_0.user.存档数据.Is试道奖励领取)
			{
				试道奖励类 试道奖励类2 = Singleton<全局变量类>.I.试道大会配置.参与奖励;
				if (P_1 == "1")
				{
					试道奖励类2 = Singleton<全局变量类>.I.试道大会配置.第一奖励;
				}
				else if (P_1 == "2")
				{
					试道奖励类2 = Singleton<全局变量类>.I.试道大会配置.第二奖励;
				}
				else if (P_1 == "3")
				{
					试道奖励类2 = Singleton<全局变量类>.I.试道大会配置.第三奖励;
				}
				switch (试道奖励类2.奖励类型)
				{
				case AllEnums.数值Type.金元宝:
					DB.I.cAJNoOkab6(P_0, 试道奖励类2.获得数量, 0);
					break;
				case AllEnums.数值Type.银元宝:
					DB.I.cAJNoOkab6(P_0, 0, 试道奖励类2.获得数量);
					break;
				case AllEnums.数值Type.金钱:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, 试道奖励类2.获得数量, false, "[试道]获得");
					break;
				case AllEnums.数值Type.累充点:
					P_0.user.存档数据.总累充金额数 += 试道奖励类2.获得数量;
					break;
				case AllEnums.数值Type.南极点:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, 试道奖励类2.获得数量, false, "[试道发送]获得");
					break;
				case AllEnums.数值Type.道具:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 试道奖励类2.奖励名字, AllEnums.指令Type.无, 试道奖励类2.获得数量, false, "试道发送");
					break;
				case AllEnums.数值Type.奇宝点:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, 试道奖励类2.获得数量, false, "[试道发送]获得");
					break;
				}
				P_0.user.存档数据.Is试道奖励领取 = true;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 3);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你，获得了试道大会的#R第");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("名#n，获得系统奖励的#Y");
				defaultInterpolatedStringHandler.AppendFormatted((试道奖励类2.奖励类型 != AllEnums.数值Type.道具) ? 试道奖励类2.奖励类型.ToString() : 试道奖励类2.奖励名字);
				defaultInterpolatedStringHandler.AppendLiteral("×");
				defaultInterpolatedStringHandler.AppendFormatted(试道奖励类2.获得数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				string text = defaultInterpolatedStringHandler.ToStringAndClear();
				Singleton<fK6mLrjpv26MU2YIIF9>.I.Ym9jrsy6dl(P_0, text);
			}
		}
		catch (Exception ex)
		{
			Log.Error("试道排名奖励发送-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task k17Dnj17RB(MyNATSocketClient P_0)
	{
		_ = 1;
		try
		{
			foreach (int item in P_0.user.队伍数据.成员列表)
			{
				MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定角色ID玩家MyClient(item);
				if (myNATSocketClient != null)
				{
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
					defaultInterpolatedStringHandler.AppendLiteral("由于队伍人数超出了试道大会要求的#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.试道大会配置.队伍最高人数);
					defaultInterpolatedStringHandler.AppendLiteral("#n人，队伍自动解散，请重新组队。");
					await myNATSocketClient.C_Send异步(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			}
			await P_0.S_Send异步(new byte[13]
			{
				77, 90, 0, 0, 0, 0, 0, 0, 0, 3,
				16, 16, 0
			});
		}
		catch (Exception ex)
		{
			Log.Error("刷新玩家队伍人数-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public SSW8tHD2MvRIUVygbNo()
	{
	}

	static SSW8tHD2MvRIUVygbNo()
	{
	}
}
