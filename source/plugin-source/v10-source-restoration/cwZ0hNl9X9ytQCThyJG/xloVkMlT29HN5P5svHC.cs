using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace cwZ0hNl9X9ytQCThyJG;

internal class xloVkMlT29HN5P5svHC : Singleton<xloVkMlT29HN5P5svHC>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public MyNATSocketClient BIihgAcYiW;

		
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		
		internal bool gmuhd3CKmb(string x)
		{
			return x == BIihgAcYiW.当前client.IP;
		}

		
		internal bool y1thsO0UF0(string x)
		{
			return x == BIihgAcYiW.Mac;
		}

		
		internal bool OoKhUPBLpc(string x)
		{
			return ("|" + BIihgAcYiW.user.存档数据.账号注册QQ).Contains("|" + x + "|", StringComparison.CurrentCulture);
		}

		
		internal bool MPdhW5ElHm(string x)
		{
			return x == BIihgAcYiW.user.人物数据.账号;
		}

		static _003C_003Ec__DisplayClass4_0()
		{
		}
	}

	
	internal void yIbly8PnUi()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("黑名单记录类.json")))
			{
				Singleton<全局变量类>.I.黑名单记录 = JsonConvert.DeserializeObject<黑名单记录类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("黑名单记录类.json")));
				return;
			}
			Singleton<全局变量类>.I.黑名单记录 = new 黑名单记录类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("黑名单记录类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.黑名单记录, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("黑名单记录读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void PCSlCXfEjx()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("黑名单记录类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.黑名单记录, Formatting.Indented));
			Log.Debug("黑名单记录保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("黑名单记录保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string PcZlVQdEji()
	{
		yIbly8PnUi();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.黑名单记录, Formatting.Indented);
	}

	
	public void DXylkZedx9(string P_0)
	{
		Singleton<全局变量类>.I.黑名单记录 = JsonConvert.DeserializeObject<黑名单记录类>(P_0);
		if (Singleton<全局变量类>.I.黑名单记录.黑名单IP列表 == null)
		{
			Singleton<全局变量类>.I.黑名单记录.黑名单IP列表 = new List<string>();
		}
		if (Singleton<全局变量类>.I.黑名单记录.黑名单MAC列表 == null)
		{
			Singleton<全局变量类>.I.黑名单记录.黑名单MAC列表 = new List<string>();
		}
		if (Singleton<全局变量类>.I.黑名单记录.黑名单QQ列表 == null)
		{
			Singleton<全局变量类>.I.黑名单记录.黑名单QQ列表 = new List<string>();
		}
		PCSlCXfEjx();
	}

	
	public async void uhil00C0Up()
	{
		if (Singleton<全局变量类>.I.黑名单记录.黑名单IP列表.Count <= 0 && Singleton<全局变量类>.I.黑名单记录.黑名单MAC列表.Count <= 0 && Singleton<全局变量类>.I.黑名单记录.黑名单QQ列表.Count <= 0 && Singleton<全局变量类>.I.黑名单记录.黑名单账号列表.Count <= 0)
		{
			return;
		}
		using IEnumerator<MyNATSocketClient> enumerator = Singleton<全局变量类>.I.会话Dict.Values.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass4_0();
			CS_0024_003C_003E8__locals11.BIihgAcYiW = enumerator.Current;
			if (CS_0024_003C_003E8__locals11.BIihgAcYiW.使用中 && CS_0024_003C_003E8__locals11.BIihgAcYiW.当前client.Online && CS_0024_003C_003E8__locals11.BIihgAcYiW.转发client.Online && (Singleton<全局变量类>.I.黑名单记录.黑名单IP列表.Any( (string x) => x == CS_0024_003C_003E8__locals11.BIihgAcYiW.当前client.IP) || Singleton<全局变量类>.I.黑名单记录.黑名单MAC列表.Any( (string x) => x == CS_0024_003C_003E8__locals11.BIihgAcYiW.Mac) || Singleton<全局变量类>.I.黑名单记录.黑名单QQ列表.Any( (string x) => ("|" + CS_0024_003C_003E8__locals11.BIihgAcYiW.user.存档数据.账号注册QQ).Contains("|" + x + "|", StringComparison.CurrentCulture)) || Singleton<全局变量类>.I.黑名单记录.黑名单账号列表.Any( (string x) => x == CS_0024_003C_003E8__locals11.BIihgAcYiW.user.人物数据.账号)))
			{
				DB.I.锁定账号操作(CS_0024_003C_003E8__locals11.BIihgAcYiW.user.人物数据.账号, "1");
				Singleton<WdAPI>.I.WT9IHmFS6c(CS_0024_003C_003E8__locals11.BIihgAcYiW, CS_0024_003C_003E8__locals11.BIihgAcYiW.user.人物数据.昵称);
			}
			await Task.Delay(10);
		}
	}

	
	public xloVkMlT29HN5P5svHC()
	{
	}

	static xloVkMlT29HN5P5svHC()
	{
	}
}
