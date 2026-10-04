using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace jVVIM9j1PL0VAliGELE;

internal class fK6mLrjpv26MU2YIIF9 : Singleton<fK6mLrjpv26MU2YIIF9>
{
	
	internal void SGSjxNg9Xs()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("邮箱配置类.json")))
			{
				Singleton<全局变量类>.I.邮箱配置 = JsonConvert.DeserializeObject<邮箱配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("邮箱配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.邮箱配置 = new 邮箱配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("邮箱配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.邮箱配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("邮箱配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void I3QjH17Swx()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("邮箱配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.邮箱配置, Formatting.Indented));
			Log.Debug("邮箱配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("邮箱配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string ABkj4vsRRs()
	{
		SGSjxNg9Xs();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.邮箱配置, Formatting.Indented);
	}

	
	public void AG2jeS2fXT(string P_0)
	{
		Singleton<全局变量类>.I.邮箱配置 = JsonConvert.DeserializeObject<邮箱配置类>(P_0);
		I3QjH17Swx();
	}

	
	internal void EJ0jquAYHE(MyNATSocketClient P_0, 乾坤袋数据类 P_1)
	{
		StringBuilder stringBuilder = new StringBuilder("#G欢迎使用乾坤袋功能，乾坤袋会替您暂时存放未及时接收的物品，请及时领取：#n");
		StringBuilder stringBuilder2 = stringBuilder;
		StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
		handler.AppendLiteral("#r当前未领取道具：#n#r");
		handler.AppendFormatted(P_1.道具名字);
		handler.AppendLiteral("*");
		handler.AppendFormatted(P_1.道具数量);
		handler.AppendLiteral("#r");
		stringBuilder2.Append(ref handler);
		P_0.C_Send(Singleton<WdAPI>.I.jyLIAFgHTA(P_0, stringBuilder.ToString()));
	}

	
	internal void Ym9jrsy6dl(MyNATSocketClient P_0, string P_1)
	{
		P_0.C_Send(Singleton<WdAPI>.I.jyLIAFgHTA(P_0, P_1).Concat(Singleton<WdAPI>.I.提示_中心提醒("#Y收到一封邮件，请点击邮箱查看。")).ToArray());
	}

	
	public fK6mLrjpv26MU2YIIF9()
	{
	}

	static fK6mLrjpv26MU2YIIF9()
	{
	}
}
