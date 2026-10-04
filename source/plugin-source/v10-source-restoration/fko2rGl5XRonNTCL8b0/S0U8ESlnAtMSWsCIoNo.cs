using System;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace fko2rGl5XRonNTCL8b0;

internal class S0U8ESlnAtMSWsCIoNo : Singleton<S0U8ESlnAtMSWsCIoNo>
{
	internal static byte[] V4qlasS9rp;

	
	internal void o7VlM3HnBo()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("鸿运当头配置类.json")))
			{
				Singleton<全局变量类>.I.鸿运当头配置 = JsonConvert.DeserializeObject<鸿运当头配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("鸿运当头配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.鸿运当头配置 = new 鸿运当头配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("鸿运当头配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.鸿运当头配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("鸿运当头配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void Qrplhs2Lov()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("鸿运当头配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.鸿运当头配置, Formatting.Indented));
			Log.Debug("鸿运当头配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("鸿运当头配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string wnxlvpJ53o()
	{
		o7VlM3HnBo();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.鸿运当头配置, Formatting.Indented);
	}

	
	public void Gkfl7TUlqB(string P_0)
	{
		Singleton<全局变量类>.I.鸿运当头配置 = JsonConvert.DeserializeObject<鸿运当头配置类>(P_0);
		Qrplhs2Lov();
	}

	
	public S0U8ESlnAtMSWsCIoNo()
	{
	}

	
	static S0U8ESlnAtMSWsCIoNo()
	{
		V4qlasS9rp = Array.Empty<byte>();
	}
}
