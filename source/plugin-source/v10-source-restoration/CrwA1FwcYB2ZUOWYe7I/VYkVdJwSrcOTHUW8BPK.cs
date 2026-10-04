using System;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace CrwA1FwcYB2ZUOWYe7I;

internal class VYkVdJwSrcOTHUW8BPK : Singleton<VYkVdJwSrcOTHUW8BPK>
{
	
	internal void bhFwnsHfKm()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("升级奖励配置类.json")))
			{
				Singleton<全局变量类>.I.升级奖励配置 = JsonConvert.DeserializeObject<升级奖励配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("升级奖励配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.升级奖励配置 = new 升级奖励配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("升级奖励配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.升级奖励配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("升级奖励配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void Xe7w5yNJfw()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("升级奖励配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.升级奖励配置, Formatting.Indented));
			Log.Debug("升级奖励配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("升级奖励配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string KofwMCNErY()
	{
		bhFwnsHfKm();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.升级奖励配置, Formatting.Indented);
	}

	
	internal void Y1GwhVTIty(MyNATSocketClient P_0, int P_1)
	{
		if (Singleton<全局变量类>.I.升级奖励配置.升级列表.TryGetValue(P_1, out 升级奖励列表类 value) && (value.奖金元宝 != 0 || value.奖银元宝 != 0) && DB.I.cAJNoOkab6(P_0, value.奖金元宝, value.奖银元宝))
		{
			string text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (value.奖金元宝 == 0)
			{
				text = string.Empty;
			}
			else
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(value.奖金元宝);
				defaultInterpolatedStringHandler.AppendLiteral("#n金元宝");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string value2 = text;
			string text2;
			if (value.奖银元宝 == 0)
			{
				text2 = "。";
			}
			else
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 2);
				defaultInterpolatedStringHandler.AppendFormatted((!string.IsNullOrWhiteSpace(value2)) ? "、" : string.Empty);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(value.奖银元宝);
				defaultInterpolatedStringHandler.AppendLiteral("#n银元宝。");
				text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string value3 = text2;
			WdAPI i = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 3);
			defaultInterpolatedStringHandler.AppendLiteral("恭喜你，等级提升到了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("#n级，获得系统奖励的");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendFormatted(value3);
			P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
		}
	}

	
	public VYkVdJwSrcOTHUW8BPK()
	{
	}

	static VYkVdJwSrcOTHUW8BPK()
	{
	}
}
