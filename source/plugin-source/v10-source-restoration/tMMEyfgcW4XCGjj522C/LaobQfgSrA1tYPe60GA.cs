using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace tMMEyfgcW4XCGjj522C;

internal class LaobQfgSrA1tYPe60GA : Singleton<LaobQfgSrA1tYPe60GA>
{
	
	internal void jq3gnvy3Lu()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("守护配置类.json")))
			{
				Singleton<全局变量类>.I.守护配置 = JsonConvert.DeserializeObject<守护配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("守护配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.守护配置 = new 守护配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("守护配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.守护配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("守护配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void nnpg5Jjtqx()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("守护配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.守护配置, Formatting.Indented));
			Log.Debug("守护配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("守护配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string uvXgM9EuOq()
	{
		jq3gnvy3Lu();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.守护配置, Formatting.Indented);
	}

	
	public void omjghl8xgf(string P_0)
	{
		Singleton<全局变量类>.I.守护配置 = JsonConvert.DeserializeObject<守护配置类>(P_0);
		nnpg5Jjtqx();
	}

	
	internal async Task aoHgvy8aML(MyNATSocketClient P_0)
	{
		_ = 1;
		try
		{
			string GID = Singleton<ByteAPI>.I.GetHexGid_(P_0.user.人物数据.GID);
			string 账号 = P_0.user.人物数据.账号;
			string 昵称 = P_0.user.人物数据.昵称;
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#G守护领取成功，为了保证数据安全，游戏将掉线10秒后才可恢复。"));
			Singleton<WdAPI>.I.WT9IHmFS6c(P_0, 昵称);
			await Task.Delay(5000);
			if (DB.I.锁定账号操作(账号, "1"))
			{
				string 守护数据 = "\"guards\":([守护数据]),\"friends\"".Replace("守护数据", fMFg7Ctprh());
				await DB.I.更新强力守护操作(账号, GID, 守护数据);
				DB.I.锁定账号操作(账号, "0");
			}
		}
		catch (Exception ex)
		{
			Log.Error("守护召唤事件处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private string fMFg7Ctprh()
	{
		string newValue = "39:\\\"" + Singleton<全局变量类>.I.守护配置.守护名称 + "\\\",";
		string text = string.Empty;
		for (int i = 0; i < Singleton<全局变量类>.I.守护配置.领取数量; i++)
		{
			string text2 = "位置:\"0:([\\\"attrib\\\":([106:2,107:当前元气,108:91954,104:门派,76:0,72:5004,68:1302716,67:亲密,66:6171,64:0,75:0,71:20,69:6096,53:0,52:身法,51:34277,49:495,48:195415,63:165,62:相性,61:5004,60:0,58:0,57:0,56:0,55:2,47:0,44:165,名称37:34277,36:2171,35:5,33::守护iid:,22:37024,21:24682,16:13026,31:仙术,5:武力,3:防护,2:195415,]),])\",".Replace("位置", $"{i + 1}");
			text2 = text2.Replace("当前元气", Singleton<全局变量类>.I.守护配置.守护元气值.ToString());
			text2 = text2.Replace("门派", Singleton<全局变量类>.I.守护配置.Is旧门派 ? "1" : "2");
			text2 = text2.Replace("亲密", Singleton<全局变量类>.I.守护配置.守护亲密度.ToString());
			text2 = text2.Replace("身法", Singleton<全局变量类>.I.守护配置.身法成长.ToString());
			text2 = text2.Replace("相性", (Singleton<全局变量类>.I.守护配置.相性 == 0) ? $"{Singleton<WdAPI>.I.qrjo9TWIdy(1, 5)}" : Singleton<全局变量类>.I.守护配置.相性.ToString());
			text2 = text2.Replace("名称", newValue);
			string text3 = text2;
			string oldValue = "守护iid";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 3);
			defaultInterpolatedStringHandler.AppendLiteral("3F000GHN");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.qrjo9TWIdy(10000, 49999), "X8");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.qrjo9TWIdy(10000, 49999), "X8");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.qrjo9TWIdy(10000, 49999), "X8");
			text2 = text3.Replace(oldValue, defaultInterpolatedStringHandler.ToStringAndClear());
			text2 = text2.Replace("仙术", Singleton<全局变量类>.I.守护配置.仙术成长.ToString());
			text2 = text2.Replace("武力", Singleton<全局变量类>.I.守护配置.武力成长.ToString());
			text2 = text2.Replace("防护", Singleton<全局变量类>.I.守护配置.防护成长.ToString());
			text += text2;
		}
		return text;
	}

	
	public LaobQfgSrA1tYPe60GA()
	{
	}

	static LaobQfgSrA1tYPe60GA()
	{
	}
}
