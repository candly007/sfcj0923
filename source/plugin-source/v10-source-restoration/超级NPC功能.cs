using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

public class 超级NPC功能 : Singleton<超级NPC功能>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public int kIu51L1HCu;

		
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		
		internal bool u7q5p9ZP9n(超级NPC列表类 x)
		{
			return x.NPC数据.npcid == kIu51L1HCu;
		}

		static _003C_003Ec__DisplayClass6_0()
		{
		}
	}

	public ConcurrentDictionary<string, byte[]> 超级NPC封包;

	
	internal void DJBD5uQVvS()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级NPC配置类.json")))
			{
				Singleton<全局变量类>.I.超级NPC配置 = JsonConvert.DeserializeObject<超级NPC配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级NPC配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.超级NPC配置 = new 超级NPC配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级NPC配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级NPC配置, Formatting.Indented));
			}
			初始化();
		}
		catch (Exception ex)
		{
			Log.Error("超级NPC配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void mndDM8OIAS()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级NPC配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级NPC配置, Formatting.Indented));
			Log.Debug("超级NPC配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("超级NPC配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string TCsDhAwkCx()
	{
		DJBD5uQVvS();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级NPC配置, Formatting.Indented);
	}

	
	public void JsonTo配置(string value)
	{
		Singleton<全局变量类>.I.超级NPC配置 = JsonConvert.DeserializeObject<超级NPC配置类>(value);
		mndDM8OIAS();
	}

	
	public void 初始化()
	{
		超级NPC封包.Clear();
		for (int i = 0; i < Singleton<全局变量类>.I.超级NPC配置.NPC列表.Count; i++)
		{
			if (Singleton<全局变量类>.I.超级NPC配置.NPC列表[i].是否显示)
			{
				NPC数据类 nPC数据 = Singleton<全局变量类>.I.超级NPC配置.NPC列表[i].NPC数据;
				if (超级NPC封包.ContainsKey(Singleton<全局变量类>.I.超级NPC配置.NPC列表[i].所在地图))
				{
					超级NPC封包[Singleton<全局变量类>.I.超级NPC配置.NPC列表[i].所在地图] = 超级NPC封包[Singleton<全局变量类>.I.超级NPC配置.NPC列表[i].所在地图].Concat(Singleton<WdAPI>.I.组包假NPC站街(nPC数据, nPC数据.npcid)).ToArray();
				}
				else
				{
					超级NPC封包.TryAdd(Singleton<全局变量类>.I.超级NPC配置.NPC列表[i].所在地图, Singleton<WdAPI>.I.组包假NPC站街(nPC数据, nPC数据.npcid));
				}
			}
		}
	}

	
	public void 超级NPC点击对话(MyNATSocketClient myclient, int npcid)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals2.kIu51L1HCu = npcid;
		try
		{
			if (myclient.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			超级NPC列表类 超级NPC列表类2 = Singleton<全局变量类>.I.超级NPC配置.NPC列表.Find( (超级NPC列表类 x) => x.NPC数据.npcid == CS_0024_003C_003E8__locals2.kIu51L1HCu);
			if (超级NPC列表类2 != null && 超级NPC列表类2.是否显示)
			{
				StringBuilder stringBuilder = new StringBuilder(超级NPC列表类2.对话介绍);
				for (int num = 0; num < 超级NPC列表类2.地图列表.Count; num++)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 2, stringBuilder2);
					handler.AppendLiteral("[");
					handler.AppendFormatted((!string.IsNullOrWhiteSpace(超级NPC列表类2.地图列表[num].选项文字)) ? 超级NPC列表类2.地图列表[num].选项文字 : ("【传送】" + 超级NPC列表类2.地图列表[num].地图名字));
					handler.AppendLiteral("/前往");
					handler.AppendFormatted(超级NPC列表类2.地图列表[num].地图名字);
					handler.AppendLiteral("]");
					stringBuilder2.Append(ref handler);
				}
				myclient.C_Send(Singleton<WdAPI>.I.对话生成_NPC(超级NPC列表类2.NPC数据.npcid, 超级NPC列表类2.NPC数据.npc形象, 超级NPC列表类2.NPC数据.npc名字, stringBuilder.ToString()));
			}
		}
		catch (Exception ex)
		{
			Log.Error("超级NPC点击对话-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public 超级NPC功能()
	{
		超级NPC封包 = new ConcurrentDictionary<string, byte[]>();
	}

	static 超级NPC功能()
	{
	}
}
