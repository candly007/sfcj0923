using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace R8lTaqgbEc6MvH2j6n0;

internal class p63Ra5gwg6vJ45gPiim : Singleton<p63Ra5gwg6vJ45gPiim>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public p63Ra5gwg6vJ45gPiim txCntKwwHK;

		public MyNATSocketClient ruNnAvVMHd;

		
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		
		internal void AiMnZjTlIm()
		{
			StringBuilder stringBuilder = new StringBuilder("#G签到成功！#n");
			stringBuilder.Append(txCntKwwHK.VpsgUOZA43(ruNnAvVMHd, Singleton<全局变量类>.I.签到配置.每日签到奖励));
			ruNnAvVMHd.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(stringBuilder.ToString()));
		}

		static _003C_003Ec__DisplayClass4_0()
		{
		}
	}

	
	internal void pJlgJ0YCmt()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("签到配置类.json")))
			{
				Singleton<全局变量类>.I.签到配置 = JsonConvert.DeserializeObject<签到配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("签到配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.签到配置 = new 签到配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("签到配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.百炼功能配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("签到配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void ex1gKmwE9k()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("签到配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.签到配置, Formatting.Indented));
			Log.Debug("签到配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("签到配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string oWYgR5m966()
	{
		pJlgJ0YCmt();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.签到配置, Formatting.Indented);
	}

	
	public void pqkgdPLEt7(string P_0)
	{
		Singleton<全局变量类>.I.签到配置 = JsonConvert.DeserializeObject<签到配置类>(P_0);
		ex1gKmwE9k();
	}

	
	internal void xnmgskXkX0(MyNATSocketClient P_0)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals26 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals26.txCntKwwHK = this;
		CS_0024_003C_003E8__locals26.ruNnAvVMHd = P_0;
		try
		{
			StringBuilder stringBuilder = new StringBuilder("#Y欢迎使用签到系统，当前频道打出#G“签到”#Y即可完成每日签到#r");
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
			handler.AppendLiteral("#Y今日签到状态：#G");
			handler.AppendFormatted(CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.本日是否签到 ? "完成" : "签到成功");
			handler.AppendLiteral("#r");
			stringBuilder3.Append(ref handler);
			if (!CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.本日是否签到)
			{
				CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.本日是否签到 = true;
				CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.累计签到天数++;
				Task.Run( () =>
				{
					StringBuilder stringBuilder72 = new StringBuilder("#G签到成功！#n");
					stringBuilder72.Append(CS_0024_003C_003E8__locals26.txCntKwwHK.VpsgUOZA43(CS_0024_003C_003E8__locals26.ruNnAvVMHd, Singleton<全局变量类>.I.签到配置.每日签到奖励));
					CS_0024_003C_003E8__locals26.ruNnAvVMHd.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(stringBuilder72.ToString()));
				});
			}
			else
			{
				CS_0024_003C_003E8__locals26.ruNnAvVMHd.C_Send(Singleton<WdAPI>.I.提示_中心提醒("本日签到已经完成了，无法进行重复签到！"));
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
			handler.AppendLiteral("#Y累计签到天数：#G");
			handler.AppendFormatted(CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.累计签到天数);
			handler.AppendLiteral("#r");
			stringBuilder4.Append(ref handler);
			StringBuilder stringBuilder5 = new StringBuilder("(");
			if (Singleton<全局变量类>.I.签到配置.累计5天签到奖励.金元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder6 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("金元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计5天签到奖励.金元宝);
				handler.AppendLiteral(" ");
				stringBuilder6.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计5天签到奖励.银元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder7 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("银元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计5天签到奖励.银元宝);
				handler.AppendLiteral(" ");
				stringBuilder7.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计5天签到奖励.南极点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder8 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("南极点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计5天签到奖励.南极点);
				handler.AppendLiteral(" ");
				stringBuilder8.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计5天签到奖励.累充点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder9 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("累充点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计5天签到奖励.累充点);
				handler.AppendLiteral(" ");
				stringBuilder9.Append(ref handler);
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.签到配置.累计5天签到奖励.道具))
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder10 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计5天签到奖励.道具);
				handler.AppendLiteral("×1");
				stringBuilder10.Append(ref handler);
			}
			stringBuilder5.Append(")");
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder11 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
			handler.AppendFormatted((CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.累计领取天数 >= 5) ? "#G领取累计5天签到奖励(已领取)#n#r" : ("[领取累计5天签到奖励" + stringBuilder5.ToString() + "/签到领取_5天]"));
			stringBuilder11.Append(ref handler);
			stringBuilder5.Clear();
			stringBuilder5.Append("(");
			if (Singleton<全局变量类>.I.签到配置.累计10天签到奖励.金元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder12 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("金元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计10天签到奖励.金元宝);
				handler.AppendLiteral(" ");
				stringBuilder12.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计10天签到奖励.银元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder13 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("银元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计10天签到奖励.银元宝);
				handler.AppendLiteral(" ");
				stringBuilder13.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计10天签到奖励.南极点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder14 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("南极点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计10天签到奖励.南极点);
				handler.AppendLiteral(" ");
				stringBuilder14.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计10天签到奖励.累充点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder15 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("累充点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计10天签到奖励.累充点);
				handler.AppendLiteral(" ");
				stringBuilder15.Append(ref handler);
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.签到配置.累计10天签到奖励.道具))
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder16 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计10天签到奖励.道具);
				handler.AppendLiteral("×1");
				stringBuilder16.Append(ref handler);
			}
			stringBuilder5.Append(")");
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder17 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
			handler.AppendFormatted((CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.累计领取天数 >= 10) ? "#G领取累计10天签到奖励(已领取)#n#r" : ("[领取累计10天签到奖励" + stringBuilder5.ToString() + "/签到领取_10天]"));
			stringBuilder17.Append(ref handler);
			stringBuilder5.Clear();
			stringBuilder5.Append("(");
			if (Singleton<全局变量类>.I.签到配置.累计20天签到奖励.金元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder18 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("金元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计20天签到奖励.金元宝);
				handler.AppendLiteral(" ");
				stringBuilder18.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计20天签到奖励.银元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder19 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("银元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计20天签到奖励.银元宝);
				handler.AppendLiteral(" ");
				stringBuilder19.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计20天签到奖励.南极点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder20 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("南极点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计20天签到奖励.南极点);
				handler.AppendLiteral(" ");
				stringBuilder20.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计20天签到奖励.累充点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder21 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("累充点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计20天签到奖励.累充点);
				handler.AppendLiteral(" ");
				stringBuilder21.Append(ref handler);
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.签到配置.累计20天签到奖励.道具))
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder22 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计20天签到奖励.道具);
				handler.AppendLiteral("×1");
				stringBuilder22.Append(ref handler);
			}
			stringBuilder5.Append(")");
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder23 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
			handler.AppendFormatted((CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.累计领取天数 >= 20) ? "#G领取累计20天签到奖励(已领取)#n#r" : ("[领取累计20天签到奖励" + stringBuilder5.ToString() + "/签到领取_20天]"));
			stringBuilder23.Append(ref handler);
			stringBuilder5.Clear();
			stringBuilder5.Append("(");
			if (Singleton<全局变量类>.I.签到配置.累计30天签到奖励.金元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder24 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("金元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计30天签到奖励.金元宝);
				handler.AppendLiteral(" ");
				stringBuilder24.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计30天签到奖励.银元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder25 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("银元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计30天签到奖励.银元宝);
				handler.AppendLiteral(" ");
				stringBuilder25.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计30天签到奖励.南极点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder26 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("南极点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计30天签到奖励.南极点);
				handler.AppendLiteral(" ");
				stringBuilder26.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计30天签到奖励.累充点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder27 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("累充点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计30天签到奖励.累充点);
				handler.AppendLiteral(" ");
				stringBuilder27.Append(ref handler);
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.签到配置.累计30天签到奖励.道具))
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder28 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计30天签到奖励.道具);
				handler.AppendLiteral("×1");
				stringBuilder28.Append(ref handler);
			}
			stringBuilder5.Append(")");
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder29 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
			handler.AppendFormatted((CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.累计领取天数 >= 30) ? "#G领取累计30天签到奖励(已领取)#n#r" : ("[领取累计30天签到奖励" + stringBuilder5.ToString() + "/签到领取_30天]"));
			stringBuilder29.Append(ref handler);
			stringBuilder5.Clear();
			stringBuilder5.Append("(");
			if (Singleton<全局变量类>.I.签到配置.累计40天签到奖励.金元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder30 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("金元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计40天签到奖励.金元宝);
				handler.AppendLiteral(" ");
				stringBuilder30.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计40天签到奖励.银元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder31 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("银元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计40天签到奖励.银元宝);
				handler.AppendLiteral(" ");
				stringBuilder31.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计40天签到奖励.南极点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder32 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("南极点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计40天签到奖励.南极点);
				handler.AppendLiteral(" ");
				stringBuilder32.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计40天签到奖励.累充点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder33 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("累充点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计40天签到奖励.累充点);
				handler.AppendLiteral(" ");
				stringBuilder33.Append(ref handler);
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.签到配置.累计40天签到奖励.道具))
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder34 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计40天签到奖励.道具);
				handler.AppendLiteral("×1");
				stringBuilder34.Append(ref handler);
			}
			stringBuilder5.Append(")");
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder35 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
			handler.AppendFormatted((CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.累计领取天数 >= 40) ? "#G领取累计40天签到奖励(已领取)#n#r" : ("[领取累计40天签到奖励" + stringBuilder5.ToString() + "/签到领取_40天]"));
			stringBuilder35.Append(ref handler);
			stringBuilder5.Clear();
			stringBuilder5.Append("(");
			if (Singleton<全局变量类>.I.签到配置.累计50天签到奖励.金元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder36 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("金元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计50天签到奖励.金元宝);
				handler.AppendLiteral(" ");
				stringBuilder36.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计50天签到奖励.银元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder37 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("银元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计50天签到奖励.银元宝);
				handler.AppendLiteral(" ");
				stringBuilder37.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计50天签到奖励.南极点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder38 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("南极点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计50天签到奖励.南极点);
				handler.AppendLiteral(" ");
				stringBuilder38.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计50天签到奖励.累充点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder39 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("累充点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计50天签到奖励.累充点);
				handler.AppendLiteral(" ");
				stringBuilder39.Append(ref handler);
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.签到配置.累计50天签到奖励.道具))
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder40 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计50天签到奖励.道具);
				handler.AppendLiteral("×1");
				stringBuilder40.Append(ref handler);
			}
			stringBuilder5.Append(")");
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder41 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
			handler.AppendFormatted((CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.累计领取天数 >= 50) ? "#G领取累计50天签到奖励(已领取)#n#r" : ("[领取累计50天签到奖励" + stringBuilder5.ToString() + "/签到领取_50天]"));
			stringBuilder41.Append(ref handler);
			stringBuilder5.Clear();
			stringBuilder5.Append("(");
			if (Singleton<全局变量类>.I.签到配置.累计60天签到奖励.金元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder42 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("金元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计60天签到奖励.金元宝);
				handler.AppendLiteral(" ");
				stringBuilder42.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计60天签到奖励.银元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder43 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("银元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计60天签到奖励.银元宝);
				handler.AppendLiteral(" ");
				stringBuilder43.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计60天签到奖励.南极点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder44 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("南极点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计60天签到奖励.南极点);
				handler.AppendLiteral(" ");
				stringBuilder44.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计60天签到奖励.累充点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder45 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("累充点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计60天签到奖励.累充点);
				handler.AppendLiteral(" ");
				stringBuilder45.Append(ref handler);
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.签到配置.累计60天签到奖励.道具))
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder46 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计60天签到奖励.道具);
				handler.AppendLiteral("×1");
				stringBuilder46.Append(ref handler);
			}
			stringBuilder5.Append(")");
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder47 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
			handler.AppendFormatted((CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.累计领取天数 >= 60) ? "#G领取累计60天签到奖励(已领取)#n#r" : ("[领取累计60天签到奖励" + stringBuilder5.ToString() + "/签到领取_60天]"));
			stringBuilder47.Append(ref handler);
			stringBuilder5.Clear();
			stringBuilder5.Append("(");
			if (Singleton<全局变量类>.I.签到配置.累计70天签到奖励.金元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder48 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("金元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计70天签到奖励.金元宝);
				handler.AppendLiteral(" ");
				stringBuilder48.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计70天签到奖励.银元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder49 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("银元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计70天签到奖励.银元宝);
				handler.AppendLiteral(" ");
				stringBuilder49.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计70天签到奖励.南极点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder50 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("南极点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计70天签到奖励.南极点);
				handler.AppendLiteral(" ");
				stringBuilder50.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计70天签到奖励.累充点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder51 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("累充点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计70天签到奖励.累充点);
				handler.AppendLiteral(" ");
				stringBuilder51.Append(ref handler);
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.签到配置.累计70天签到奖励.道具))
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder52 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计70天签到奖励.道具);
				handler.AppendLiteral("×1");
				stringBuilder52.Append(ref handler);
			}
			stringBuilder5.Append(")");
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder53 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
			handler.AppendFormatted((CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.累计领取天数 >= 70) ? "#G领取累计70天签到奖励(已领取)#n#r" : ("[领取累计70天签到奖励" + stringBuilder5.ToString() + "/签到领取_70天]"));
			stringBuilder53.Append(ref handler);
			stringBuilder5.Clear();
			stringBuilder5.Append("(");
			if (Singleton<全局变量类>.I.签到配置.累计80天签到奖励.金元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder54 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("金元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计80天签到奖励.金元宝);
				handler.AppendLiteral(" ");
				stringBuilder54.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计80天签到奖励.银元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder55 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("银元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计80天签到奖励.银元宝);
				handler.AppendLiteral(" ");
				stringBuilder55.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计80天签到奖励.南极点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder56 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("南极点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计80天签到奖励.南极点);
				handler.AppendLiteral(" ");
				stringBuilder56.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计80天签到奖励.累充点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder57 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("累充点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计80天签到奖励.累充点);
				handler.AppendLiteral(" ");
				stringBuilder57.Append(ref handler);
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.签到配置.累计80天签到奖励.道具))
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder58 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计80天签到奖励.道具);
				handler.AppendLiteral("×1");
				stringBuilder58.Append(ref handler);
			}
			stringBuilder5.Append(")");
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder59 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
			handler.AppendFormatted((CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.累计领取天数 >= 80) ? "#G领取累计80天签到奖励(已领取)#n#r" : ("[领取累计80天签到奖励" + stringBuilder5.ToString() + "/签到领取_80天]"));
			stringBuilder59.Append(ref handler);
			stringBuilder5.Clear();
			stringBuilder5.Append("(");
			if (Singleton<全局变量类>.I.签到配置.累计90天签到奖励.金元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder60 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("金元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计90天签到奖励.金元宝);
				handler.AppendLiteral(" ");
				stringBuilder60.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计90天签到奖励.银元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder61 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("银元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计90天签到奖励.银元宝);
				handler.AppendLiteral(" ");
				stringBuilder61.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计90天签到奖励.南极点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder62 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("南极点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计90天签到奖励.南极点);
				handler.AppendLiteral(" ");
				stringBuilder62.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计90天签到奖励.累充点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder63 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("累充点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计90天签到奖励.累充点);
				handler.AppendLiteral(" ");
				stringBuilder63.Append(ref handler);
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.签到配置.累计90天签到奖励.道具))
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder64 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计90天签到奖励.道具);
				handler.AppendLiteral("×1");
				stringBuilder64.Append(ref handler);
			}
			stringBuilder5.Append(")");
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder65 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
			handler.AppendFormatted((CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.累计领取天数 >= 90) ? "#G领取累计90天签到奖励(已领取)#n#r" : ("[领取累计90天签到奖励" + stringBuilder5.ToString() + "/签到领取_90天]"));
			stringBuilder65.Append(ref handler);
			stringBuilder5.Clear();
			stringBuilder5.Append("(");
			if (Singleton<全局变量类>.I.签到配置.累计100天签到奖励.金元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder66 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("金元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计100天签到奖励.金元宝);
				handler.AppendLiteral(" ");
				stringBuilder66.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计100天签到奖励.银元宝 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder67 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("银元宝×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计100天签到奖励.银元宝);
				handler.AppendLiteral(" ");
				stringBuilder67.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计100天签到奖励.南极点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder68 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("南极点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计100天签到奖励.南极点);
				handler.AppendLiteral(" ");
				stringBuilder68.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.签到配置.累计100天签到奖励.累充点 > 0)
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder69 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
				handler.AppendLiteral("累充点×");
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计100天签到奖励.累充点);
				handler.AppendLiteral(" ");
				stringBuilder69.Append(ref handler);
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.签到配置.累计100天签到奖励.道具))
			{
				stringBuilder2 = stringBuilder5;
				StringBuilder stringBuilder70 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				handler.AppendFormatted(Singleton<全局变量类>.I.签到配置.累计100天签到奖励.道具);
				handler.AppendLiteral("×1");
				stringBuilder70.Append(ref handler);
			}
			stringBuilder5.Append(")");
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder71 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
			handler.AppendFormatted((CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.存档数据.签到数据.累计领取天数 >= 100) ? "#G领取累计100天签到奖励(已领取)#n#r" : ("[领取累计100天签到奖励" + stringBuilder5.ToString() + "/签到领取_100天]"));
			stringBuilder71.Append(ref handler);
			CS_0024_003C_003E8__locals26.ruNnAvVMHd.C_Send(Singleton<WdAPI>.I.对话生成_NPC(CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.人物数据.角色ID, CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.人物数据.形象ID, CS_0024_003C_003E8__locals26.ruNnAvVMHd.user.人物数据.昵称, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("签到喊话事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public string VpsgUOZA43(MyNATSocketClient P_0, 签到奖励类 P_1)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder("获得了");
			if (!string.IsNullOrWhiteSpace(P_1.道具))
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(P_1.道具);
				handler.AppendLiteral("×1#n  ");
				stringBuilder3.Append(ref handler);
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, P_1.道具, AllEnums.指令Type.无, 1, false, "每日签到");
			}
			if ((P_1.金元宝 > 0 || P_1.银元宝 > 0) && DB.I.cAJNoOkab6(P_0, P_1.金元宝, P_1.银元宝))
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
				string value;
				if (P_1.金元宝 <= 0)
				{
					value = string.Empty;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#Y金元宝×");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.金元宝);
					defaultInterpolatedStringHandler.AppendLiteral("#n  ");
					value = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				handler.AppendFormatted(value);
				stringBuilder4.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
				string value2;
				if (P_1.银元宝 <= 0)
				{
					value2 = string.Empty;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#Y银元宝×");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.银元宝);
					defaultInterpolatedStringHandler.AppendLiteral("#n  ");
					value2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				handler.AppendFormatted(value2);
				stringBuilder5.Append(ref handler);
			}
			if (P_1.南极点 > 0)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, P_1.南极点, false, "[签到]获得");
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder6 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder2);
				handler.AppendLiteral("#Y南极点×");
				handler.AppendFormatted(P_1.南极点);
				handler.AppendLiteral("#n  ");
				stringBuilder6.Append(ref handler);
			}
			if (P_1.累充点 > 0)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, P_1.累充点, false, "签到获得");
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder7 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
				handler.AppendLiteral("#Y累充点×");
				handler.AppendFormatted(P_1.累充点);
				handler.AppendLiteral("#n");
				stringBuilder7.Append(ref handler);
			}
			return stringBuilder.ToString();
		}
		catch (Exception ex)
		{
			Log.Error("签到喊话事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return string.Empty;
		}
	}

	
	internal void gxFgWodoAU(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (!Singleton<全局变量类>.I.签到配置.功能开关 || P_1 == null)
			{
				return;
			}
			switch (P_1.Length)
			{
			case 8:
				switch (P_1[5])
				{
				case '1':
					if (P_1 == "签到领取_10天")
					{
						if (P_0.user.存档数据.签到数据.累计签到天数 < 10)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("累计签到不足10天，无法领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 >= 10)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前累计签到奖励已经领取过了，无法重复领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 != 5)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请按照顺序领取累计签到奖励！"));
							break;
						}
						P_0.user.存档数据.签到数据.累计领取天数 = 10;
						P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(VpsgUOZA43(P_0, Singleton<全局变量类>.I.签到配置.累计10天签到奖励)));
					}
					break;
				case '2':
					if (P_1 == "签到领取_20天")
					{
						if (P_0.user.存档数据.签到数据.累计签到天数 < 20)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("累计签到不足20天，无法领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 >= 20)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前累计签到奖励已经领取过了，无法重复领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 != 10)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请按照顺序领取累计签到奖励！"));
							break;
						}
						P_0.user.存档数据.签到数据.累计领取天数 = 20;
						P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(VpsgUOZA43(P_0, Singleton<全局变量类>.I.签到配置.累计20天签到奖励)));
					}
					break;
				case '3':
					if (P_1 == "签到领取_30天")
					{
						if (P_0.user.存档数据.签到数据.累计签到天数 < 30)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("累计签到不足30天，无法领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 >= 30)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前累计签到奖励已经领取过了，无法重复领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 != 20)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请按照顺序领取累计签到奖励！"));
							break;
						}
						P_0.user.存档数据.签到数据.累计领取天数 = 30;
						P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(VpsgUOZA43(P_0, Singleton<全局变量类>.I.签到配置.累计30天签到奖励)));
					}
					break;
				case '4':
					if (P_1 == "签到领取_40天")
					{
						if (P_0.user.存档数据.签到数据.累计签到天数 < 40)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("累计签到不足40天，无法领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 >= 40)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前累计签到奖励已经领取过了，无法重复领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 != 30)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请按照顺序领取累计签到奖励！"));
							break;
						}
						P_0.user.存档数据.签到数据.累计领取天数 = 40;
						P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(VpsgUOZA43(P_0, Singleton<全局变量类>.I.签到配置.累计40天签到奖励)));
					}
					break;
				case '5':
					if (P_1 == "签到领取_50天")
					{
						if (P_0.user.存档数据.签到数据.累计签到天数 < 50)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("累计签到不足50天，无法领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 >= 50)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前累计签到奖励已经领取过了，无法重复领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 != 40)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请按照顺序领取累计签到奖励！"));
							break;
						}
						P_0.user.存档数据.签到数据.累计领取天数 = 50;
						P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(VpsgUOZA43(P_0, Singleton<全局变量类>.I.签到配置.累计50天签到奖励)));
					}
					break;
				case '6':
					if (P_1 == "签到领取_60天")
					{
						if (P_0.user.存档数据.签到数据.累计签到天数 < 60)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("累计签到不足60天，无法领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 >= 60)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前累计签到奖励已经领取过了，无法重复领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 != 50)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请按照顺序领取累计签到奖励！"));
							break;
						}
						P_0.user.存档数据.签到数据.累计领取天数 = 60;
						P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(VpsgUOZA43(P_0, Singleton<全局变量类>.I.签到配置.累计60天签到奖励)));
					}
					break;
				case '7':
					if (P_1 == "签到领取_70天")
					{
						if (P_0.user.存档数据.签到数据.累计签到天数 < 70)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("累计签到不足70天，无法领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 >= 70)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前累计签到奖励已经领取过了，无法重复领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 != 60)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请按照顺序领取累计签到奖励！"));
							break;
						}
						P_0.user.存档数据.签到数据.累计领取天数 = 70;
						P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(VpsgUOZA43(P_0, Singleton<全局变量类>.I.签到配置.累计70天签到奖励)));
					}
					break;
				case '8':
					if (P_1 == "签到领取_80天")
					{
						if (P_0.user.存档数据.签到数据.累计签到天数 < 80)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("累计签到不足80天，无法领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 >= 80)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前累计签到奖励已经领取过了，无法重复领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 != 70)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请按照顺序领取累计签到奖励！"));
							break;
						}
						P_0.user.存档数据.签到数据.累计领取天数 = 80;
						P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(VpsgUOZA43(P_0, Singleton<全局变量类>.I.签到配置.累计80天签到奖励)));
					}
					break;
				case '9':
					if (P_1 == "签到领取_90天")
					{
						if (P_0.user.存档数据.签到数据.累计签到天数 < 90)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("累计签到不足90天，无法领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 >= 90)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前累计签到奖励已经领取过了，无法重复领取奖励！"));
							break;
						}
						if (P_0.user.存档数据.签到数据.累计领取天数 != 80)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请按照顺序领取累计签到奖励！"));
							break;
						}
						P_0.user.存档数据.签到数据.累计领取天数 = 90;
						P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(VpsgUOZA43(P_0, Singleton<全局变量类>.I.签到配置.累计90天签到奖励)));
					}
					break;
				}
				break;
			case 7:
				if (P_1 == "签到领取_5天")
				{
					if (P_0.user.存档数据.签到数据.累计签到天数 < 5)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("累计签到不足5天，无法领取奖励！"));
						break;
					}
					if (P_0.user.存档数据.签到数据.累计领取天数 >= 5)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前累计签到奖励已经领取过了，无法重复领取奖励！"));
						break;
					}
					if (P_0.user.存档数据.签到数据.累计领取天数 != 0)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请按照顺序领取累计签到奖励！"));
						break;
					}
					P_0.user.存档数据.签到数据.累计领取天数 = 5;
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(VpsgUOZA43(P_0, Singleton<全局变量类>.I.签到配置.累计5天签到奖励)));
				}
				break;
			case 9:
				if (P_1 == "签到领取_100天")
				{
					if (P_0.user.存档数据.签到数据.累计签到天数 < 100)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("累计签到不足100天，无法领取奖励！"));
						break;
					}
					if (P_0.user.存档数据.签到数据.累计领取天数 >= 100)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前累计签到奖励已经领取过了，无法重复领取奖励！"));
						break;
					}
					if (P_0.user.存档数据.签到数据.累计领取天数 != 90)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请按照顺序领取累计签到奖励！"));
						break;
					}
					P_0.user.存档数据.签到数据.累计领取天数 = 100;
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(VpsgUOZA43(P_0, Singleton<全局变量类>.I.签到配置.累计100天签到奖励)));
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Log.Error("签到领取事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public p63Ra5gwg6vJ45gPiim()
	{
	}

	static p63Ra5gwg6vJ45gPiim()
	{
	}
}
