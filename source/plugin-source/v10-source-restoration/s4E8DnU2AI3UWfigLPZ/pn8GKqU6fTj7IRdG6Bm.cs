using System;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace s4E8DnU2AI3UWfigLPZ;

internal class pn8GKqU6fTj7IRdG6Bm : Singleton<pn8GKqU6fTj7IRdG6Bm>
{
	
	internal void KVTUmFj736()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("时装坐姿染色配置类.json")))
			{
				Singleton<全局变量类>.I.时装坐姿染色配置 = JsonConvert.DeserializeObject<时装坐姿染色配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("时装坐姿染色配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.时装坐姿染色配置 = new 时装坐姿染色配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("时装坐姿染色配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.时装坐姿染色配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("时装坐姿染色配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void n1fUPdsc2G()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("时装坐姿染色配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.时装坐姿染色配置, Formatting.Indented));
			Log.Debug("时装坐姿染色配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("时装坐姿染色配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string lwmUXS1MmP()
	{
		KVTUmFj736();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.时装坐姿染色配置, Formatting.Indented);
	}

	
	public void RGQUFfsNVt(string P_0)
	{
		Singleton<全局变量类>.I.时装坐姿染色配置 = JsonConvert.DeserializeObject<时装坐姿染色配置类>(P_0);
		n1fUPdsc2G();
	}

	
	internal string S3gUL37bJn(string P_0, string P_1)
	{
		if (Singleton<全局变量类>.I.时装坐姿染色配置.时装坐姿列表.TryGetValue(P_0, out 时装坐姿数据列表类 value) && 问道数据类.所有坐姿对应动作.TryGetValue(P_1, out var value2))
		{
			if (!value2)
			{
				return value.站立ID;
			}
			return value.坐姿ID;
		}
		return string.Empty;
	}

	
	public pn8GKqU6fTj7IRdG6Bm()
	{
	}

	static pn8GKqU6fTj7IRdG6Bm()
	{
	}
}
