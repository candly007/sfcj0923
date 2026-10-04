using System;
using System.Collections.Concurrent;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace B2uVXfUco7vjsxVN2Bc;

internal class yuKf6DUSQGygKeLSQdj : Singleton<yuKf6DUSQGygKeLSQdj>
{
	public ConcurrentDictionary<int, ConcurrentDictionary<int, int>> Eu4UC51HfM;

	
	[SpecialName]
	public static bool uf8U9RfBer()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is智能BOSS)
		{
			return Singleton<全局变量类>.I.智能怪物配置.功能开关;
		}
		return false;
	}

	
	internal void pnNUngJoks()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("智能怪物配置类.json")))
			{
				Singleton<全局变量类>.I.智能怪物配置 = JsonConvert.DeserializeObject<智能怪物配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("智能怪物配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.智能怪物配置 = new 智能怪物配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("智能怪物配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.智能怪物配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("智能怪物配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void BnpU5fAAkt()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("智能怪物配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.智能怪物配置, Formatting.Indented));
			Log.Debug("智能怪物配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("智能怪物配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string GtIUMUM1g7()
	{
		pnNUngJoks();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.智能怪物配置, Formatting.Indented);
	}

	
	public void P6FUhRK84D(string P_0)
	{
		Singleton<全局变量类>.I.智能怪物配置 = JsonConvert.DeserializeObject<智能怪物配置类>(P_0);
		BnpU5fAAkt();
	}

	
	public void rpxUvjkqND(MyNATSocketClient P_0, int P_1, int P_2)
	{
		if (P_1 != 0 && Eu4UC51HfM.TryGetValue(P_0.插件端口, out var value))
		{
			if (value.ContainsKey(P_1))
			{
				value[P_1] = P_2;
			}
			else if (P_2 != 0)
			{
				value.TryAdd(P_1, P_2);
			}
		}
	}

	
	public int vMqU7xfUTS(MyNATSocketClient P_0, int P_1)
	{
		if (!Eu4UC51HfM.TryGetValue(P_0.插件端口, out var value))
		{
			return 0;
		}
		if (!value.TryGetValue(P_1, out var value2))
		{
			return 0;
		}
		return value2;
	}

	
	private int[] tsKUampgrf(int P_0, int P_1, ref bool P_2)
	{
		int num = P_0 - P_1;
		if (num >= Singleton<全局变量类>.I.智能怪物配置.怪物最低高于玩家等级)
		{
			P_2 = true;
			if (num >= 100)
			{
				return Singleton<全局变量类>.I.智能怪物配置.怪物高于玩家100级增幅;
			}
			if (num >= 90)
			{
				return Singleton<全局变量类>.I.智能怪物配置.怪物高于玩家90级增幅;
			}
			if (num >= 80)
			{
				return Singleton<全局变量类>.I.智能怪物配置.怪物高于玩家80级增幅;
			}
			if (num >= 70)
			{
				return Singleton<全局变量类>.I.智能怪物配置.怪物高于玩家70级增幅;
			}
			if (num >= 60)
			{
				return Singleton<全局变量类>.I.智能怪物配置.怪物高于玩家60级增幅;
			}
			if (num >= 50)
			{
				return Singleton<全局变量类>.I.智能怪物配置.怪物高于玩家50级增幅;
			}
			if (num >= 40)
			{
				return Singleton<全局变量类>.I.智能怪物配置.怪物高于玩家40级增幅;
			}
			if (num >= 30)
			{
				return Singleton<全局变量类>.I.智能怪物配置.怪物高于玩家30级增幅;
			}
			if (num >= 20)
			{
				return Singleton<全局变量类>.I.智能怪物配置.怪物高于玩家20级增幅;
			}
			if (num >= 10)
			{
				return Singleton<全局变量类>.I.智能怪物配置.怪物高于玩家10级增幅;
			}
		}
		num = P_1 - P_0;
		if (num >= Singleton<全局变量类>.I.智能怪物配置.玩家最低高于怪物等级)
		{
			P_2 = false;
			if (num >= 100)
			{
				return Singleton<全局变量类>.I.智能怪物配置.玩家高于怪物100级消减;
			}
			if (num >= 90)
			{
				return Singleton<全局变量类>.I.智能怪物配置.玩家高于怪物90级消减;
			}
			if (num >= 80)
			{
				return Singleton<全局变量类>.I.智能怪物配置.玩家高于怪物80级消减;
			}
			if (num >= 70)
			{
				return Singleton<全局变量类>.I.智能怪物配置.玩家高于怪物70级消减;
			}
			if (num >= 60)
			{
				return Singleton<全局变量类>.I.智能怪物配置.玩家高于怪物60级消减;
			}
			if (num >= 50)
			{
				return Singleton<全局变量类>.I.智能怪物配置.玩家高于怪物50级消减;
			}
			if (num >= 40)
			{
				return Singleton<全局变量类>.I.智能怪物配置.玩家高于怪物40级消减;
			}
			if (num >= 30)
			{
				return Singleton<全局变量类>.I.智能怪物配置.玩家高于怪物30级消减;
			}
			if (num >= 20)
			{
				return Singleton<全局变量类>.I.智能怪物配置.玩家高于怪物20级消减;
			}
			if (num >= 10)
			{
				return Singleton<全局变量类>.I.智能怪物配置.玩家高于怪物10级消减;
			}
		}
		P_2 = false;
		return null;
	}

	
	public void BNoUTIgmnO(MyNATSocketClient P_0, int P_1, bool P_2)
	{
		if (!P_2)
		{
			P_0.智能怪物事件 = null;
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.attack_effect, 0, true);
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.phy_absorb, 0, true);
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.mag_absorb, 0, true);
			return;
		}
		int num = vMqU7xfUTS(P_0, P_1);
		if (num == 0)
		{
			return;
		}
		bool flag = false;
		int[] array = tsKUampgrf(num, P_0.user.属性数据.等级, ref flag);
		if (array != null)
		{
			if (flag)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.attack_effect, array[0], true);
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.phy_absorb, -array[1], true);
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.mag_absorb, -array[1], true);
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(61, 3);
				defaultInterpolatedStringHandler.AppendLiteral("由于怪物等级超过了你#R");
				defaultInterpolatedStringHandler.AppendFormatted(num - P_0.user.属性数据.等级);
				defaultInterpolatedStringHandler.AppendLiteral("#n级，触发怪物智能调控系统，本场战斗将临时提升你#R");
				defaultInterpolatedStringHandler.AppendFormatted(array[0]);
				defaultInterpolatedStringHandler.AppendLiteral("%#n的攻击伤害和减免#R");
				defaultInterpolatedStringHandler.AppendFormatted(array[1]);
				defaultInterpolatedStringHandler.AppendLiteral("%#n受到的伤害。");
				P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.attack_effect, -array[0], true);
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.phy_absorb, array[1], true);
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.mag_absorb, array[1], true);
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(62, 3);
				defaultInterpolatedStringHandler.AppendLiteral("由于你的等级超过了怪物#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.属性数据.等级 - num);
				defaultInterpolatedStringHandler.AppendLiteral("#n级，触发怪物智能调控系统，本场战斗将临时消减你#R");
				defaultInterpolatedStringHandler.AppendFormatted(array[0]);
				defaultInterpolatedStringHandler.AppendLiteral("%#n的攻击伤害和提升#R");
				defaultInterpolatedStringHandler.AppendFormatted(array[1]);
				defaultInterpolatedStringHandler.AppendLiteral("%#n受到的伤害。");
				P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}
	}

	
	public yuKf6DUSQGygKeLSQdj()
	{
		Eu4UC51HfM = new ConcurrentDictionary<int, ConcurrentDictionary<int, int>>();
	}

	static yuKf6DUSQGygKeLSQdj()
	{
	}
}
