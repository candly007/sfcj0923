using System;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace cVS5v9gmXX8TceaB2WW;

internal class GyJyg8g24jqCD31mjD6 : Singleton<GyJyg8g24jqCD31mjD6>
{
	
	internal void mqggP8ij2u()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("网关配置.json")))
			{
				Singleton<全局变量类>.I.网关Config = JsonConvert.DeserializeObject<网关配置>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("网关配置.json")));
			}
			else
			{
				Singleton<全局变量类>.I.网关Config = new 网关配置();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("网关配置.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.网关Config, Formatting.Indented));
			}
			if (Singleton<全局变量类>.I.网关Config.注册id > Singleton<全局变量类>.I.注册id)
			{
				Singleton<全局变量类>.I.注册id = Singleton<全局变量类>.I.网关Config.注册id;
			}
			Singleton<全局变量类>.I.网关Config.共享配置.Is注册大飞 = true;
			Singleton<全局变量类>.I.网关Config.共享配置.Is注册1级大飞 = Singleton<全局变量类>.I.网关Config.Is注册1级大飞;
		}
		catch (Exception ex)
		{
			Log.Error("网关配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void lScgXuebT5()
	{
		try
		{
			Singleton<全局变量类>.I.网关Config.注册id = Singleton<全局变量类>.I.注册id;
			Singleton<全局变量类>.I.网关Config.共享配置.Is注册1级大飞 = Singleton<全局变量类>.I.网关Config.Is注册1级大飞;
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("网关配置.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.网关Config, Formatting.Indented));
			Log.Debug("网关配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("网关配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string NDPgFq96ae()
	{
		mqggP8ij2u();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.网关Config, Formatting.Indented);
	}

	
	public void mrngLtkZfj(string P_0)
	{
		Singleton<全局变量类>.I.网关Config = JsonConvert.DeserializeObject<网关配置>(P_0);
		lScgXuebT5();
	}

	
	public GyJyg8g24jqCD31mjD6()
	{
	}

	static GyJyg8g24jqCD31mjD6()
	{
	}
}
