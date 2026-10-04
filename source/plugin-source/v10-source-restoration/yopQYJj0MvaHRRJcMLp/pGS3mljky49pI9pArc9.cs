using System;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace yopQYJj0MvaHRRJcMLp;

internal class pGS3mljky49pI9pArc9 : Singleton<pGS3mljky49pI9pArc9>
{
	
	internal void OxYjO9uilD()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("道具数据配置类.json")))
			{
				Singleton<全局变量类>.I.道具数据配置 = JsonConvert.DeserializeObject<道具数据配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("道具数据配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.道具数据配置 = new 道具数据配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("道具数据配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.道具数据配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("道具数据配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void zAvjQAlvdI()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("道具数据配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.道具数据配置, Formatting.Indented));
			Log.Debug("道具数据配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("道具数据配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string yhPjEpfa3d()
	{
		OxYjO9uilD();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.道具数据配置, Formatting.Indented);
	}

	
	public void agtj33Mvf1(string P_0)
	{
		Singleton<全局变量类>.I.道具数据配置 = JsonConvert.DeserializeObject<道具数据配置类>(P_0);
		zAvjQAlvdI();
	}

	
	public 道具数据 eyhjY1a75Q(string P_0)
	{
		Singleton<全局变量类>.I.道具数据配置.道具字典.TryGetValue(P_0, out 道具数据 value);
		return value;
	}

	
	public pGS3mljky49pI9pArc9()
	{
	}

	static pGS3mljky49pI9pArc9()
	{
	}
}
