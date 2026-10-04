using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Serilog;
using xqlPMM2TJRNXpZnNDFn;

public class 版本相关处理 : Singleton<版本相关处理>
{
	public ConcurrentDictionary<string, int> 巅峰对决套装字典;

	public ConcurrentDictionary<string, int> 巅峰对决加成字典;

	public static bool Is巅峰对决
	{
		
		get
		{
			return Singleton<全局变量类>.I.验证client.授权配置.Is巅峰对决 && Singleton<全局变量类>.I.config.Is巅峰对决;
		}
	}

	public static bool Is力魄处理
	{
		
		get
		{
			if (Singleton<全局变量类>.I.验证client.授权配置.Is完美力魄)
			{
				return Singleton<全局变量类>.I.config.Is完美力魄;
			}
			return false;
		}
	}

	
	public void 启动巅峰对决读取()
	{
		if (Is巅峰对决)
		{
			巅峰对决套装字典.Clear();
			巅峰对决套装字典.TryAdd("巅峰一境·", 170);
			巅峰对决套装字典.TryAdd("巅峰二境·", 180);
			巅峰对决套装字典.TryAdd("巅峰三境·", 190);
			巅峰对决套装字典.TryAdd("巅峰四境·", 200);
			巅峰对决套装字典.TryAdd("巅峰五境·", 210);
			巅峰对决套装字典.TryAdd("巅峰六境·", 220);
			巅峰对决套装字典.TryAdd("巅峰七境·", 230);
			巅峰对决套装字典.TryAdd("巅峰八境·", 240);
			巅峰对决套装字典.TryAdd("巅峰九境·", 250);
			巅峰对决套装字典.TryAdd("巅峰极境·", 255);
			巅峰对决加成字典.Clear();
			巅峰对决加成字典.TryAdd("巅峰一境·", 1);
			巅峰对决加成字典.TryAdd("巅峰二境·", 1);
			巅峰对决加成字典.TryAdd("巅峰三境·", 1);
			巅峰对决加成字典.TryAdd("巅峰四境·", 3);
			巅峰对决加成字典.TryAdd("巅峰五境·", 3);
			巅峰对决加成字典.TryAdd("巅峰六境·", 3);
			巅峰对决加成字典.TryAdd("巅峰七境·", 5);
			巅峰对决加成字典.TryAdd("巅峰八境·", 5);
			巅峰对决加成字典.TryAdd("巅峰九境·", 5);
			巅峰对决加成字典.TryAdd("巅峰极境·", 10);
		}
	}

	
	public string 取当前已激活套装(MyNATSocketClient myclient)
	{
		if (myclient.user.属性数据.等级 == 170)
		{
			return "巅峰一境套装";
		}
		if (myclient.user.属性数据.等级 == 180)
		{
			return "巅峰二境套装";
		}
		if (myclient.user.属性数据.等级 == 190)
		{
			return "巅峰三境套装";
		}
		if (myclient.user.属性数据.等级 == 200)
		{
			return "巅峰四境套装";
		}
		if (myclient.user.属性数据.等级 == 210)
		{
			return "巅峰五境套装";
		}
		if (myclient.user.属性数据.等级 == 220)
		{
			return "巅峰六境套装";
		}
		if (myclient.user.属性数据.等级 == 230)
		{
			return "巅峰七境套装";
		}
		if (myclient.user.属性数据.等级 == 240)
		{
			return "巅峰八境套装";
		}
		if (myclient.user.属性数据.等级 == 250)
		{
			return "巅峰九境套装";
		}
		if (myclient.user.属性数据.等级 == 255)
		{
			return "巅峰极境套装";
		}
		return "无";
	}

	
	public int 取下个激活后升级等级(string qz)
	{
		if (!巅峰对决套装字典.ContainsKey(qz))
		{
			return 0;
		}
		return 巅峰对决套装字典[qz];
	}

	
	public string 取下个需激活套装前缀(MyNATSocketClient myclient)
	{
		if (myclient.user.属性数据.等级 < 170)
		{
			return "巅峰一境·";
		}
		if (myclient.user.属性数据.等级 == 170)
		{
			return "巅峰二境·";
		}
		if (myclient.user.属性数据.等级 == 180)
		{
			return "巅峰三境·";
		}
		if (myclient.user.属性数据.等级 == 190)
		{
			return "巅峰四境·";
		}
		if (myclient.user.属性数据.等级 == 200)
		{
			return "巅峰五境·";
		}
		if (myclient.user.属性数据.等级 == 210)
		{
			return "巅峰六境·";
		}
		if (myclient.user.属性数据.等级 == 220)
		{
			return "巅峰七境·";
		}
		if (myclient.user.属性数据.等级 == 230)
		{
			return "巅峰八境·";
		}
		if (myclient.user.属性数据.等级 == 240)
		{
			return "巅峰九境·";
		}
		if (myclient.user.属性数据.等级 == 250)
		{
			return "巅峰极境·";
		}
		return "无";
	}

	
	public void 巅峰对决读取穿戴(MyNATSocketClient myclient)
	{
		try
		{
			if (!Is巅峰对决 || myclient.user.背包数据.物品列表[1].物品ID == 0)
			{
				return;
			}
			string 前缀 = myclient.user.背包数据.物品列表[1].前缀;
			string text = 取下个需激活套装前缀(myclient);
			if (前缀 != text || !巅峰对决套装字典.TryGetValue(前缀, out var value) || myclient.user.背包数据.物品列表[1].前缀 != text || myclient.user.背包数据.物品列表[2].前缀 != text || myclient.user.背包数据.物品列表[3].前缀 != text || myclient.user.背包数据.物品列表[4].前缀 != text || myclient.user.背包数据.物品列表[5].前缀 != text || myclient.user.背包数据.物品列表[6].前缀 != text || myclient.user.背包数据.物品列表[7].前缀 != text || myclient.user.背包数据.物品列表[8].前缀 != text || myclient.user.背包数据.物品列表[9].前缀 != text || myclient.user.背包数据.物品列表[10].前缀 != text || myclient.user.背包数据.物品列表[31].前缀 != text || myclient.user.背包数据.物品列表[32].前缀 != text || myclient.user.背包数据.物品列表[33].前缀 != text || myclient.user.背包数据.物品列表[41].前缀 != text || myclient.user.背包数据.物品列表[42].前缀 != text || myclient.user.背包数据.物品列表[43].前缀 != text || myclient.user.背包数据.物品列表[44].前缀 != text || myclient.user.背包数据.物品列表[51].前缀 != text)
			{
				return;
			}
			lock (myclient.巅峰套装锁)
			{
				if (myclient.user.属性数据.等级 >= value)
				{
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.level, value, true, "巅峰套装激活提升等级");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 1, "property_bind/attrib", "4");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 2, "property_bind/attrib", "4");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 3, "property_bind/attrib", "4");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 4, "property_bind/attrib", "4");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 5, "property_bind/attrib", "4");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 6, "property_bind/attrib", "4");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 7, "property_bind/attrib", "4");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 8, "property_bind/attrib", "4");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 9, "property_bind/attrib", "4");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 10, "property_bind/attrib", "4");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 31, "property_bind/attrib", "4");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 32, "property_bind/attrib", "4");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 33, "property_bind/attrib", "4");
				Singleton<WdAPI>.I.Mr8ICwW3qX(myclient, 51, "property_bind/attrib", "4");
			}
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
			defaultInterpolatedStringHandler.AppendLiteral("#G恭喜你，首次激活#O");
			defaultInterpolatedStringHandler.AppendFormatted(前缀.Replace("·", string.Empty));
			defaultInterpolatedStringHandler.AppendLiteral("套装#n，等级提升至#Y");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("#n级。");
			myclient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
			if (client频道事件 != null)
			{
				WdAPI i2 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 3);
				defaultInterpolatedStringHandler.AppendLiteral("#G恭喜#Y");
				defaultInterpolatedStringHandler.AppendFormatted(myclient.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("#G道友，首次激活#O");
				defaultInterpolatedStringHandler.AppendFormatted(前缀.Replace("·", string.Empty));
				defaultInterpolatedStringHandler.AppendLiteral("套装#G，等级提升至#Y");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("#G级，在巅峰之路上遥遥领先！");
				client频道事件(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
			}
		}
		catch (Exception ex)
		{
			Log.Error("巅峰对决读取穿戴-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public string 组装任务提示(MyNATSocketClient myclient)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder("#G当前已激活套装：" + 取当前已激活套装(myclient));
			string text = 取下个需激活套装前缀(myclient);
			bool flag = text == "无";
			stringBuilder.Append("#r#Y当前装备穿戴情况：#n#r");
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴    武器部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[1].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder3.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴    帽子部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[2].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder4.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder5 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴    衣服部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[3].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder5.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder6 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴    鞋子部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[10].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder6.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder7 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴    腰带部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[51].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder7.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder8 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴    项链部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[4].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder8.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder9 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴    玉佩部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[5].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder9.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder10 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴  左手镯部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[6].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder10.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder11 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴  右手镯部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[7].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder11.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder12 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴    时装部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[31].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder12.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder13 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴    法宝部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[9].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder13.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder14 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴    仙器部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[32].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder14.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder15 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴  御天梭部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[8].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder15.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder16 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴    铭牌部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[33].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder16.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder17 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴孔雀妖器部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[41].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder17.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder18 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴玉兔妖器部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[42].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder18.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder19 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴竹熊妖器部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[43].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder19.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder20 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
			handler.AppendLiteral("#Y当前穿戴灵蛇妖器部位：#n");
			handler.AppendFormatted(myclient.user.背包数据.物品列表[44].前缀.Replace("·", string.Empty));
			handler.AppendLiteral("#r");
			stringBuilder20.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder21 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
			handler.AppendFormatted(flag ? "#r#Y道友已经臻至巅峰极境，进无可进，天下无敌！" : "，下一阶段套装激活进度如下#r");
			stringBuilder21.Append(ref handler);
			if (!flag)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder22 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("    武器部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[1].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder22.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder23 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("    帽子部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[2].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder23.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder24 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("    衣服部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[3].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder24.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder25 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("    鞋子部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[10].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder25.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder26 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("    腰带部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[51].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder26.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder27 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("    项链部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[4].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder27.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder28 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("    玉佩部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[5].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder28.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder29 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(14, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("  左手镯部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[6].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder29.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder30 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(14, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("  右手镯部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[7].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder30.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder31 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("    时装部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[31].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder31.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder32 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("    法宝部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[9].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder32.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder33 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("    仙器部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[32].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder33.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder34 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(14, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("  御天梭部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[8].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder34.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder35 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("    铭牌部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[33].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder35.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder36 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("孔雀妖器部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[41].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder36.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder37 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("玉兔妖器部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[42].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder37.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder38 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("竹熊妖器部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[43].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder38.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder39 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(text);
				handler.AppendLiteral("灵蛇妖器部位：#n");
				handler.AppendFormatted((myclient.user.背包数据.物品列表[44].前缀 == text) ? "#Y1/1" : "0/1");
				handler.AppendLiteral("#r");
				stringBuilder39.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder40 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(28, 2, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(text.Replace("·", string.Empty));
				handler.AppendLiteral("部位首次穿戴齐全后角色等级将自动提升至#Y");
				handler.AppendFormatted(取下个激活后升级等级(text));
				handler.AppendLiteral("#G级#r");
				stringBuilder40.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder41 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(27, 1, stringBuilder2);
				handler.AppendLiteral("#Y提示：穿戴整套#O");
				handler.AppendFormatted(text.Replace("·", string.Empty));
				handler.AppendLiteral("#Y套装在战斗时伤害会更高呦#r");
				stringBuilder41.Append(ref handler);
			}
			return stringBuilder.ToString();
		}
		catch (Exception ex)
		{
			Log.Error("组装任务提示-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return string.Empty;
		}
	}

	
	public void 战斗释放技能刷新属性(MyNATSocketClient myclient, int ID, int 指令id, int 指令id2)
	{
		try
		{
			int num = 0;
			if (全局变量类.Is调试)
			{
				Singleton<全局变量类>.I.验证client.授权配置.Is完美力魄 = Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND();
			}
			if (!Is力魄处理)
			{
				return;
			}
			if (ID == myclient.user.人物数据.角色ID)
			{
				num = -98 - myclient.user.背包数据.物理加成 + myclient.user.背包数据.套装加成;
				if (myclient.user.属性数据.强物理 != num)
				{
					WdAPI i = Singleton<WdAPI>.I;
					string empty = string.Empty;
					int num2 = ((指令id == 3 && 指令id2 == 501) ? num : 0);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler.AppendLiteral("武力属性属性刷新");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					i.PndoGw5lW7(myclient, AllEnums.发送数据Type.数值, empty, AllEnums.指令Type.enhanced_phy, num2, true, defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			else
			{
				myclient.S_Send(Singleton<WdAPI>.I.mgVIYoDksB(myclient.user.人物数据.昵称, ID.ToString(), "enhanced_phy", (指令id == 3 && 指令id2 == 501) ? "-98" : "0", "admin_set_attrib"));
			}
		}
		catch (Exception ex)
		{
			Log.Error("战斗释放技能刷新属性-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void Nk6fB0M6gJ(MyNATSocketClient P_0)
	{
		try
		{
			P_0.user.背包数据.套装加成 = 0;
			if (Is巅峰对决 && P_0.user.背包数据.物品列表[1].物品ID != 0)
			{
				string 前缀 = P_0.user.背包数据.物品列表[1].前缀;
				if (巅峰对决加成字典.TryGetValue(前缀, out var value) && !(P_0.user.背包数据.物品列表[1].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[2].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[3].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[4].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[5].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[6].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[7].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[8].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[9].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[10].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[31].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[32].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[33].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[41].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[42].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[43].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[44].前缀 != 前缀) && !(P_0.user.背包数据.物品列表[51].前缀 != 前缀))
				{
					P_0.user.背包数据.套装加成 = value;
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("取穿戴套装加成-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void MuPfGABrDe(MyNATSocketClient P_0)
	{
		try
		{
			List<物品信息类> list = P_0.user.背包数据.物品列表.ToList().FindAll( (物品信息类 x) => x.物品ID != 0 && x.装备属性列表.Any( (属性数据 y) => y.属性标识 == 405) && ((x.Index >= 1 && x.Index <= 10) || (x.Index >= 31 && x.Index <= 33) || (x.Index >= 41 && x.Index <= 44) || x.Index == 51));
			int num = 0;
			foreach (物品信息类 item in list)
			{
				foreach (属性数据 item2 in item.装备属性列表)
				{
					if (item2.属性标识 == 405)
					{
						num += item2.属性数值;
					}
				}
			}
			P_0.user.背包数据.物理加成 = num;
		}
		catch (Exception ex)
		{
			Log.Error("取穿戴强物理加成-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void ScyffSSCxe(MyNATSocketClient P_0)
	{
		try
		{
			if (!Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND())
			{
				return;
			}
			int num = 0;
			foreach (物品信息类 item in P_0.user.背包数据.物品列表.ToList().FindAll( (物品信息类 x) => x.物品ID != 0 && x.装备属性列表.Any( (属性数据 y) => y.属性标识 == 405) && (x.Index == 1 || x.Index == 2 || x.Index == 3 || x.Index == 4 || x.Index == 5 || x.Index == 6 || x.Index == 7 || x.Index == 8 || x.Index == 9 || x.Index == 10 || x.Index == 31 || x.Index == 32 || x.Index == 33 || x.Index == 41 || x.Index == 42 || x.Index == 43 || x.Index == 44 || x.Index == 51)))
			{
				foreach (属性数据 item2 in item.装备属性列表)
				{
					if (item2.属性标识 == 405)
					{
						num += item2.属性数值;
					}
				}
			}
			P_0.user.背包数据.物理加成 = num;
		}
		catch (Exception ex)
		{
			Log.Error("道友_取穿戴强物理加成-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public 版本相关处理()
	{
		巅峰对决套装字典 = new ConcurrentDictionary<string, int>();
		巅峰对决加成字典 = new ConcurrentDictionary<string, int>();
	}

	static 版本相关处理()
	{
	}
}
