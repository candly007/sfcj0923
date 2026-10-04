using System;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

public class 妖族化形功能 : Singleton<妖族化形功能>
{
	public static bool 使用中
	{
		
		get
		{
			if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.IsVip)
			{
				return Singleton<全局变量类>.I.妖族化形配置.化形开关;
			}
			return false;
		}
	}

	
	internal void GmeKnW9UYt()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("妖族化形配置类.json")))
			{
				Singleton<全局变量类>.I.妖族化形配置 = JsonConvert.DeserializeObject<妖族化形配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("妖族化形配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.妖族化形配置 = new 妖族化形配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("妖族化形配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.妖族化形配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("妖族化形配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void xmaK5ovZ2I()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("妖族化形配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.妖族化形配置, Formatting.Indented));
			Log.Debug("妖族化形配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("妖族化形配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string yFBKMD6Llw()
	{
		GmeKnW9UYt();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.妖族化形配置, Formatting.Indented);
	}

	
	public void JsonTo配置(string value)
	{
		Singleton<全局变量类>.I.妖族化形配置 = JsonConvert.DeserializeObject<妖族化形配置类>(value);
		xmaK5ovZ2I();
	}

	
	public 妖族化形功能()
	{
	}

	static 妖族化形功能()
	{
	}
}
