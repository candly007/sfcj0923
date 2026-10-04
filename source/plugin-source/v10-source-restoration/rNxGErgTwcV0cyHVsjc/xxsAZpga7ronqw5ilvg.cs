using System;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace rNxGErgTwcV0cyHVsjc;

internal class xxsAZpga7ronqw5ilvg : Singleton<xxsAZpga7ronqw5ilvg>
{
	
	internal void FPBg995sXp()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("自定义宠物类.json")))
			{
				Singleton<全局变量类>.I.自定义宠物 = JsonConvert.DeserializeObject<自定义宠物类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("自定义宠物类.json")));
				return;
			}
			Singleton<全局变量类>.I.自定义宠物 = new 自定义宠物类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("自定义宠物类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.自定义宠物, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("自定义宠物读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void rLUgyO9QSs()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("自定义宠物类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.自定义宠物, Formatting.Indented));
			Log.Debug("自定义宠物保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("自定义宠物保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string T1vgCLCOYE()
	{
		FPBg995sXp();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.自定义宠物, Formatting.Indented);
	}

	
	public void sDogVLGeQU(string P_0)
	{
		Singleton<全局变量类>.I.自定义宠物 = JsonConvert.DeserializeObject<自定义宠物类>(P_0);
		rLUgyO9QSs();
	}

	
	public xxsAZpga7ronqw5ilvg()
	{
	}

	static xxsAZpga7ronqw5ilvg()
	{
	}
}
