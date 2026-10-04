using System;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Serilog;
using YOheREbBnDq6LvvWZEr;
using vEAdPGPTkDFOYsbi303;

namespace Ncq4nMwbH5sPfLR2xwf;

internal class BsbfIlwwf1YnPvbq8GT : Singleton<BsbfIlwwf1YnPvbq8GT>
{
	
	internal void DocwJRxiSX()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("全服共享存档数据类.json")))
			{
				Singleton<全局变量类>.I.全服共享存档数据 = JsonConvert.DeserializeObject<全服共享存档数据类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("全服共享存档数据类.json")));
				return;
			}
			Singleton<全局变量类>.I.全服共享存档数据 = new 全服共享存档数据类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("全服共享存档数据类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.全服共享存档数据, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("全服共享存档数据读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void o2gwKNo6hU()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("全服共享存档数据类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.全服共享存档数据, Formatting.Indented));
			Log.Debug("全服共享存档数据保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("全服共享存档数据保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string LP2wR4cotl()
	{
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.全服共享存档数据, Formatting.Indented);
	}

	
	public void j29wdiwK2i(string P_0)
	{
		Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像 = JsonConvert.DeserializeObject<NPC数据类>(P_0);
		Singleton<BpcEfFbiGBBV3s2B0ai>.I.ahfbmf4uyK();
		o2gwKNo6hU();
	}

	
	public void ukmwscj752(string P_0)
	{
		Singleton<全局变量类>.I.全服共享存档数据 = JsonConvert.DeserializeObject<全服共享存档数据类>(P_0);
		o2gwKNo6hU();
	}

	
	public BsbfIlwwf1YnPvbq8GT()
	{
	}

	static BsbfIlwwf1YnPvbq8GT()
	{
	}
}
