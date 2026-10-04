using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using B2uVXfUco7vjsxVN2Bc;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;
using xqlPMM2TJRNXpZnNDFn;

namespace MAZG7tsAp4qxkk1uF8R;

internal class FBGRmlstyRWQdqi0pHa : Singleton<FBGRmlstyRWQdqi0pHa>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public MyNATSocketClient u5ecWi476U;

		
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		
		internal bool gYocUS1bj7(挑战BOSS列表类 x)
		{
			return x.BOSS战斗名字 == u5ecWi476U.user.缓存数据.当前战斗BOSS名字;
		}

		static _003C_003Ec__DisplayClass9_0()
		{
		}
	}

	
	internal void YGtsz7JSCc()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("挑战BOSS配置类.json")))
			{
				Singleton<全局变量类>.I.挑战BOSS配置 = JsonConvert.DeserializeObject<挑战BOSS配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("挑战BOSS配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.挑战BOSS配置 = new 挑战BOSS配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("挑战BOSS配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.挑战BOSS配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("挑战BOSS配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void kSnUuq4dcR()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("挑战BOSS配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.挑战BOSS配置, Formatting.Indented));
			Log.Debug("挑战BOSS配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("挑战BOSS配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string bLVUww08og()
	{
		YGtsz7JSCc();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.挑战BOSS配置, Formatting.Indented);
	}

	
	public void xqeUb7KnBy(string P_0)
	{
		Singleton<全局变量类>.I.挑战BOSS配置 = JsonConvert.DeserializeObject<挑战BOSS配置类>(P_0);
		kSnUuq4dcR();
	}

	
	public string qaqUJO1GZF(MyNATSocketClient P_0, string P_1, string P_2, 挑战BOSS列表类 P_3)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (!string.IsNullOrWhiteSpace(P_3.介绍描述))
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				handler.AppendLiteral("#r");
				handler.AppendFormatted(P_3.介绍描述);
				stringBuilder3.Append(ref handler);
			}
			if (P_3.is组队开关)
			{
				stringBuilder.Append("#r#O当前BOSS禁止组队挑战#n");
			}
			P_0.user.存档数据.挑战BOSS数据.TryGetValue(P_1, out var value);
			int num = ((Singleton<全局变量类>.I.挑战BOSS配置.is指定会员双倍 && P_0.user.缓存数据.Is指定会员) ? (P_3.每日限制击杀 * 2) : P_3.每日限制击杀);
			if (P_3.is击杀开关)
			{
				if (value != null)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(32, 3, stringBuilder2);
					handler.AppendLiteral("#r#G每日击杀记录：#Y");
					handler.AppendFormatted(value.已挑战次数);
					handler.AppendLiteral("(已击杀) ");
					handler.AppendFormatted(value.新增挑战次数);
					handler.AppendLiteral("(已补充) ");
					handler.AppendFormatted(num);
					handler.AppendLiteral("(可击杀)#n");
					stringBuilder4.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(34, 1, stringBuilder2);
					handler.AppendLiteral("#r#G每日击杀记录：#Y0(已击杀) 0(已补充) ");
					handler.AppendFormatted(num);
					handler.AppendLiteral("(可击杀)#n");
					stringBuilder5.Append(ref handler);
				}
			}
			if (P_3.is挑战消耗 && P_3.消耗类型 != AllEnums.数值Type.无 && P_3.消耗数量 > 0)
			{
				switch (P_3.消耗类型)
				{
				case AllEnums.数值Type.道行:
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
					handler.AppendLiteral("#r#G挑战消耗道行：#R(");
					handler.AppendFormatted(P_3.消耗数量);
					handler.AppendLiteral("年)#n");
					stringBuilder8.Append(ref handler);
					break;
				}
				case AllEnums.数值Type.声望:
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder15 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
					handler.AppendLiteral("#r#G挑战消耗声望：#R(");
					handler.AppendFormatted(P_3.消耗数量);
					handler.AppendLiteral("点)#n");
					stringBuilder15.Append(ref handler);
					break;
				}
				case AllEnums.数值Type.战绩:
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder14 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
					handler.AppendLiteral("#r#G挑战消耗战绩：#R(");
					handler.AppendFormatted(P_3.消耗数量);
					handler.AppendLiteral("点)#n");
					stringBuilder14.Append(ref handler);
					break;
				}
				case AllEnums.数值Type.金元宝:
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder13 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
					handler.AppendLiteral("#r#G挑战消耗金元宝：#R(");
					handler.AppendFormatted(P_3.消耗数量);
					handler.AppendLiteral(")#n");
					stringBuilder13.Append(ref handler);
					break;
				}
				case AllEnums.数值Type.银元宝:
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder12 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
					handler.AppendLiteral("#r#G挑战消耗银元宝：#R(");
					handler.AppendFormatted(P_3.消耗数量);
					handler.AppendLiteral(")#n");
					stringBuilder12.Append(ref handler);
					break;
				}
				case AllEnums.数值Type.金钱:
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder11 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(20, 1, stringBuilder2);
					handler.AppendLiteral("#r#G挑战消耗游戏币：#R(");
					handler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(P_3.消耗数量));
					handler.AppendLiteral("文钱)#n");
					stringBuilder11.Append(ref handler);
					break;
				}
				case AllEnums.数值Type.累充点:
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder10 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
					handler.AppendLiteral("#r#G挑战消耗累充点：#R(");
					handler.AppendFormatted(P_3.消耗数量);
					handler.AppendLiteral("点)#n");
					stringBuilder10.Append(ref handler);
					break;
				}
				case AllEnums.数值Type.南极点:
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder9 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(19, 1, stringBuilder2);
					handler.AppendLiteral("#r#G挑战消耗南极点：#R(");
					handler.AppendFormatted(P_3.消耗数量);
					handler.AppendLiteral("点)#n");
					stringBuilder9.Append(ref handler);
					break;
				}
				case AllEnums.数值Type.道具:
					if (!string.IsNullOrWhiteSpace(P_3.消耗道具))
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder7 = stringBuilder2;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(18, 2, stringBuilder2);
						handler.AppendLiteral("#r#G挑战消耗道具：#R(");
						handler.AppendFormatted(P_3.消耗道具);
						handler.AppendLiteral("*");
						handler.AppendFormatted(P_3.消耗数量);
						handler.AppendLiteral(")#n");
						stringBuilder7.Append(ref handler);
					}
					break;
				case AllEnums.数值Type.体力:
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
					handler.AppendLiteral("#r#G挑战消耗体力：#R(");
					handler.AppendFormatted(P_3.消耗数量);
					handler.AppendLiteral("点)#n");
					stringBuilder6.Append(ref handler);
					break;
				}
				}
			}
			if (P_3.is等级开关)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder16 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(26, 2, stringBuilder2);
				handler.AppendLiteral("#r#G挑战等级区间：#Y(");
				handler.AppendFormatted(P_3.最低等级);
				handler.AppendLiteral("级#n - #Y");
				handler.AppendFormatted(P_3.最高等级);
				handler.AppendLiteral("级)#n");
				stringBuilder16.Append(ref handler);
			}
			if (P_3.is道行开关)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder17 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(26, 2, stringBuilder2);
				handler.AppendLiteral("#r#G挑战道行区间：#Y(");
				handler.AppendFormatted(P_3.最低道行);
				handler.AppendLiteral("年#n - #Y");
				handler.AppendFormatted(P_3.最高道行);
				handler.AppendLiteral("年)#n");
				stringBuilder17.Append(ref handler);
			}
			if (P_3.is活跃开关)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder18 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(26, 2, stringBuilder2);
				handler.AppendLiteral("#r#G挑战活跃区间：#Y(");
				handler.AppendFormatted(P_3.最低活跃);
				handler.AppendLiteral("度#n - #Y");
				handler.AppendFormatted(P_3.最高活跃);
				handler.AppendLiteral("度)#n");
				stringBuilder18.Append(ref handler);
			}
			if (P_3.is称号开关)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder19 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
				handler.AppendLiteral("#r#G挑战称号要求：#Y(");
				handler.AppendFormatted((!string.IsNullOrWhiteSpace(P_3.指定称号1)) ? (P_3.指定称号1 + "、") : string.Empty);
				handler.AppendFormatted(P_3.指定称号2);
				handler.AppendLiteral(")#n");
				stringBuilder19.Append(ref handler);
			}
			if (P_3.is掉落开关 && P_3.掉落列表 != null)
			{
				int count = P_3.掉落列表.Count;
				if (count > 0)
				{
					stringBuilder.Append("#r#G击杀掉落列表：#Y");
					for (int i = 0; i < count; i++)
					{
						if (P_3.掉落列表[i].掉落类型 != AllEnums.数值Type.无)
						{
							string value2 = ((P_3.掉落列表[i].掉落类型 == AllEnums.数值Type.道具) ? P_3.掉落列表[i].掉落道具 : P_3.掉落列表[i].掉落类型.ToString());
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder20 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(0, 2, stringBuilder2);
							handler.AppendFormatted((i == 0) ? string.Empty : "、");
							handler.AppendFormatted(value2);
							stringBuilder20.Append(ref handler);
							if (i > 3)
							{
								stringBuilder.Append("等");
								break;
							}
						}
					}
					stringBuilder.Append("#n");
				}
			}
			if (P_3.is击杀开关)
			{
				stringBuilder.Append("#r#G挑战注意事项：#R需携带宠物方可挑战#n");
				if (P_3.is补充开关 && value != null && P_3.补充类型 != AllEnums.数值Type.无 && P_3.补充消耗 > 0 && P_3.每日限制击杀 > 0 && value.已挑战次数 >= num)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder21 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(32, 2, stringBuilder2);
					handler.AppendLiteral("[补充当前BOSS可击杀次数（");
					handler.AppendFormatted(P_3.补充消耗);
					handler.AppendFormatted(P_3.补充类型);
					handler.AppendLiteral("次）/超级BOSS操作_补充次数]");
					stringBuilder21.Append(ref handler);
				}
			}
			return stringBuilder.ToString();
		}
		catch (Exception ex)
		{
			Log.Error("当前NPC是否在挑战列表-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return string.Empty;
		}
	}

	
	internal bool XOfUKXehUo(MyNATSocketClient P_0, 挑战BOSS列表类 P_1, int P_2)
	{
		try
		{
			if (P_1.is组队开关 && P_0.user.队伍数据.成员列表.Count > 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + P_1.BOSS名字 + "#n无法组队挑战，请离开队伍后重试！"));
				return false;
			}
			if (P_0.user.队伍数据.成员列表.Count <= 1)
			{
				return O1TURPfqnQ(P_0, P_1, P_2);
			}
			return YyeUdj6WSo(P_0, P_1, P_2);
		}
		catch (Exception ex)
		{
			Log.Error("BOSS点击对话处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	private bool O1TURPfqnQ(MyNATSocketClient P_0, 挑战BOSS列表类 P_1, int P_2)
	{
		try
		{
			if (P_1.is等级开关)
			{
				if (P_0.user.属性数据.等级 < P_1.最低等级)
				{
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的等级不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.最低等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法挑战#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
					defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (P_0.user.属性数据.等级 > P_1.最高等级)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的等级超过了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.最高等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法挑战#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
					defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
			}
			if (P_1.BOSS名字 == "上古妖王")
			{
				int num = Singleton<yuKf6DUSQGygKeLSQdj>.I.vMqU7xfUTS(P_0, P_2);
				if (num != 0 && P_0.user.属性数据.等级 > num + 29)
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的等级超过了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.最高等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法挑战#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
					defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
					P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
			}
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && Singleton<ByteAPI>.I.寻找文本(Ab7Ypu2aCcHMcLPG8Um.xh4mILM5j1.ToString(), P_1.BOSS名字 ?? ""))
			{
				元神境界配置类 元神境界配置类2 = Ab7Ypu2aCcHMcLPG8Um.wIn2YFWhMH(P_0.user.存档数据.元神存档.当前境界);
				if (元神境界配置类2 != null && 元神境界配置类2.突破特殊需求.Is额外条件 && 元神境界配置类2.突破特殊需求.Is击杀BOSS要求 && Singleton<全局变量类>.I.元神系统配置.开启破境BOSS同境界挑战限制)
				{
					if (元神境界配置类2.突破特殊需求.击杀BOSS要求 != P_1.BOSS名字)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + P_1.BOSS名字 + "#n并非道友当前突破境界的击杀达成BOSS，无法挑战！"));
						return false;
					}
					if (P_0.user.存档数据.数值存档.灵气值 < 元神境界配置类2.突破灵气值)
					{
						WdAPI i4 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你当前并未达到#R");
						defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("#n的#R圆满#n状态，无法挑战！");
						P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
				}
			}
			if (P_1.is道行开关)
			{
				if (P_0.user.属性数据.道行 < P_1.最低道行 * 360)
				{
					WdAPI i5 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的道行不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.最低道行);
					defaultInterpolatedStringHandler.AppendLiteral("#n年，无法挑战#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
					defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
					P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (P_0.user.属性数据.道行 > P_1.最高道行 * 360)
				{
					WdAPI i6 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的道行超过了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.最高道行);
					defaultInterpolatedStringHandler.AppendLiteral("#n年，无法挑战#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
					defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
					P_0.C_Send(i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
			}
			if (P_1.is活跃开关)
			{
				if (P_0.user.缓存数据.活跃值 < P_1.最低活跃)
				{
					WdAPI i7 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的活跃度不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.最低活跃);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
					defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
					P_0.C_Send(i7.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (P_0.user.缓存数据.活跃值 > P_1.最高活跃)
				{
					WdAPI i8 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的活跃度超过了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.最高活跃);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
					defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
					P_0.C_Send(i8.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
			}
			if (P_1.is称号开关)
			{
				if (!string.IsNullOrWhiteSpace(P_1.指定称号1) && !P_0.user.缓存数据.所有称号文本.ToString().Contains(P_1.指定称号1, StringComparison.CurrentCulture))
				{
					WdAPI i9 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你并未拥有#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.指定称号1);
					defaultInterpolatedStringHandler.AppendLiteral("#n称号，无法挑战#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
					defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
					P_0.C_Send(i9.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
				if (!string.IsNullOrWhiteSpace(P_1.指定称号2) && !P_0.user.缓存数据.所有称号文本.ToString().Contains(P_1.指定称号2, StringComparison.CurrentCulture))
				{
					WdAPI i10 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你并未拥有#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.指定称号2);
					defaultInterpolatedStringHandler.AppendLiteral("#n称号，无法挑战#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
					defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
					P_0.C_Send(i10.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return false;
				}
			}
			if (P_1.is击杀开关)
			{
				if (P_0.user.宠物数据.All( (宠物缓存数据类 a) => a.宠物ID == 0))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前并未携带任何宠物，无法挑战#R" + P_1.BOSS名字 + "#n！"));
					return false;
				}
				if (P_0.user.存档数据.挑战BOSS数据.TryGetValue(P_1.BOSS名字, out var value))
				{
					if (P_1.每日限制击杀 <= 0)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + P_1.BOSS名字 + "#nBOSS暂无法被挑战！"));
						return false;
					}
					int num2 = ((Singleton<全局变量类>.I.挑战BOSS配置.is指定会员双倍 && P_0.user.缓存数据.Is指定会员) ? (P_1.每日限制击杀 * 2) : P_1.每日限制击杀);
					if (value.已挑战次数 >= value.新增挑战次数 + num2)
					{
						WdAPI i11 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
						defaultInterpolatedStringHandler.AppendLiteral("今日已击杀了#R");
						defaultInterpolatedStringHandler.AppendFormatted(value.已挑战次数);
						defaultInterpolatedStringHandler.AppendLiteral("#n只#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法继续挑战BOSS！");
						P_0.C_Send(i11.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
				}
			}
			if (P_1.is挑战消耗 && P_1.消耗类型 != AllEnums.数值Type.无 && P_1.消耗数量 > 0)
			{
				switch (P_1.消耗类型)
				{
				case AllEnums.数值Type.道行:
					if (P_0.user.属性数据.道行 < P_1.消耗数量 * 360)
					{
						WdAPI i14 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的道行不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n年，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i14.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, -(P_1.消耗数量 * 360), false, "[BOSS]挑战消耗");
					break;
				case AllEnums.数值Type.声望:
					if (P_0.user.属性数据.声望 < P_1.消耗数量)
					{
						WdAPI i22 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的声望不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i22.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, -P_1.消耗数量, false, "[BOSS]挑战消耗");
					break;
				case AllEnums.数值Type.战绩:
					if (P_0.user.属性数据.战绩 < P_1.消耗数量)
					{
						WdAPI i21 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的战绩不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i21.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.total_score, -P_1.消耗数量, false, "[BOSS]挑战消耗");
					break;
				case AllEnums.数值Type.金元宝:
					if (P_0.user.背包数据.金元宝 < P_1.消耗数量)
					{
						WdAPI i16 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的金元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i16.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (!DB.I.cAJNoOkab6(P_0, -P_1.消耗数量, 0))
					{
						WdAPI i17 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的金元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i17.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.银元宝:
					if (P_0.user.背包数据.银元宝 < P_1.消耗数量)
					{
						WdAPI i18 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的银元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i18.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (!DB.I.cAJNoOkab6(P_0, 0, -P_1.消耗数量))
					{
						WdAPI i19 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的银元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i19.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.金钱:
					if (P_0.user.背包数据.金钱 < P_1.消耗数量)
					{
						WdAPI i13 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的游戏币不足");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(P_1.消耗数量));
						defaultInterpolatedStringHandler.AppendLiteral("文，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i13.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -P_1.消耗数量, false, "[BOSS]挑战消耗");
					break;
				case AllEnums.数值Type.累充点:
					if (P_0.user.存档数据.累计充值金额 < P_1.消耗数量)
					{
						WdAPI i20 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的累充点不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i20.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, -P_1.消耗数量, false, "挑战[" + P_1.BOSS名字 + "]BOSS消耗");
					break;
				case AllEnums.数值Type.南极点:
					if (P_0.user.存档数据.南极抽奖次数 < P_1.消耗数量)
					{
						WdAPI i15 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的南极点不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i15.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, -P_1.消耗数量, false, "挑战[" + P_1.BOSS名字 + "]消耗");
					break;
				case AllEnums.数值Type.体力:
					if (P_0.user.属性数据.当前体力 < P_1.消耗数量)
					{
						WdAPI i12 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的体力不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i12.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.stamina, -P_1.消耗数量, false, "[BOSS]挑战消耗");
					break;
				}
				if (P_1.消耗类型 != AllEnums.数值Type.道具)
				{
					P_0.user.缓存数据.is扣除标识 = true;
					WdAPI i23 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗类型);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					P_0.C_Send(i23.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				else if (P_1.消耗类型 == AllEnums.数值Type.道具 && !string.IsNullOrWhiteSpace(P_1.消耗道具) && P_1.消耗数量 > 0)
				{
					物品信息类 物品信息类2 = Singleton<WdAPI>.I.取背包物品格子实例(P_0, P_1.消耗道具);
					if (物品信息类2 == null)
					{
						WdAPI i24 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
						defaultInterpolatedStringHandler.AppendLiteral("背包暂无#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗道具);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i24.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (物品信息类2.数量 < P_1.消耗数量)
					{
						WdAPI i25 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 3);
						defaultInterpolatedStringHandler.AppendLiteral("背包中的#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗道具);
						defaultInterpolatedStringHandler.AppendLiteral("#n数量不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n个，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i25.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 1)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的背包已满，无法挑战#Y" + P_1.BOSS名字 + "#nBOSS！"));
						return false;
					}
					if (!Singleton<WdAPI>.I.dSCoKmGWP9(P_0))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的宠物栏已满，无法挑战#Y" + P_1.BOSS名字 + "#nBOSS！"));
						return false;
					}
					if (Singleton<WdAPI>.I.WywoUvuXuV(P_0, 物品信息类2.Index, P_1.消耗数量))
					{
						P_0.user.缓存数据.is扣除标识 = true;
						WdAPI i26 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗道具);
						defaultInterpolatedStringHandler.AppendLiteral("×");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n。");
						P_0.C_Send(i26.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("单人挑战BOSS验证-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	private bool YyeUdj6WSo(MyNATSocketClient P_0, 挑战BOSS列表类 P_1, int P_2)
	{
		try
		{
			ConcurrentDictionary<MyNATSocketClient, int> concurrentDictionary = new ConcurrentDictionary<MyNATSocketClient, int>();
			foreach (int item in P_0.user.队伍数据.成员列表)
			{
				MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定角色ID玩家MyClient(item);
				if (myNATSocketClient == null)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("队伍中有成员暂未在线，无法挑战#Y" + P_1.BOSS名字 + "#nBOSS，请重新组队！"));
					return false;
				}
				if (!myNATSocketClient.user.缓存数据.is队伍中)
				{
					continue;
				}
				if (P_1.is等级开关)
				{
					if (myNATSocketClient.user.属性数据.等级 < P_1.最低等级)
					{
						WdAPI i = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的等级不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.最低等级);
						defaultInterpolatedStringHandler.AppendLiteral("#n级，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (myNATSocketClient.user.属性数据.等级 > P_1.最高等级)
					{
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的等级超过了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.最高等级);
						defaultInterpolatedStringHandler.AppendLiteral("#n级，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
				}
				if (P_1.BOSS名字 == "上古妖王" || Singleton<ByteAPI>.I.寻找文本("|天魁星|天魔星|天机星|天闲星|天勇星|天雄星|天猛星|天威星|天英星|天贵星|天富星|天满星|天孤星|天伤星|天立星|天捷星|天暗星|天祐星|天空星|天速星|天异星|天杀星|天微星|天究星|天退星|天寿星|天剑星|天平星|天罪星|天损星|天败星|天牢星|天慧星|天暴星|天哭星|天巧星|地魁星|地煞星|地勇星|地杰星|地雄星|地威星|地英星|地奇星|地猛星|地文星|地正星|地辟星|地阖星|地强星|地暗星|地轴星|地会星|地佐星|地佑星|地灵星|地兽星|地微星|地慧星|地暴星|地默星|地猖星|地狂星|地飞星|地走星|地巧星|地明星|地进星|地退星|地满星|地遂星|地周星|地隐星|地异星|地理星|地俊星|地乐星|地捷星|地速星|地镇星|地稽星|地魔星|地妖星|地幽星|地伏星|地僻星|地空星|地孤星|地全星|地短星|地角星|地囚星|地藏星|地平星|地损星|地奴星|地察星|地恶星|地丑星|地数星|地阴星|地刑星|地壮星|地劣星|地健星|地耗星|地贼星|地狗星|", "|" + P_1.BOSS名字 + "|"))
				{
					int num = Singleton<yuKf6DUSQGygKeLSQdj>.I.vMqU7xfUTS(myNATSocketClient, P_2);
					if (num != 0 && myNATSocketClient.user.属性数据.等级 > num + 29)
					{
						WdAPI i3 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的等级超过了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.最高等级);
						defaultInterpolatedStringHandler.AppendLiteral("#n级，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
				}
				if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && Singleton<ByteAPI>.I.寻找文本(Ab7Ypu2aCcHMcLPG8Um.xh4mILM5j1.ToString(), P_1.BOSS名字 ?? ""))
				{
					元神境界配置类 元神境界配置类2 = Ab7Ypu2aCcHMcLPG8Um.wIn2YFWhMH(myNATSocketClient.user.存档数据.元神存档.当前境界);
					if (元神境界配置类2 != null && 元神境界配置类2.突破特殊需求.Is额外条件 && 元神境界配置类2.突破特殊需求.Is击杀BOSS要求 && Singleton<全局变量类>.I.元神系统配置.开启破境BOSS同境界挑战限制)
					{
						if (元神境界配置类2.突破特殊需求.击杀BOSS要求 != P_1.BOSS名字)
						{
							WdAPI i4 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
							defaultInterpolatedStringHandler.AppendLiteral("#R");
							defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
							defaultInterpolatedStringHandler.AppendLiteral("#n并非队伍成员#R");
							defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n当前突破境界的击杀达成BOSS，无法挑战！");
							P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return false;
						}
						if (myNATSocketClient.user.存档数据.数值存档.灵气值 < 元神境界配置类2.突破灵气值)
						{
							WdAPI i5 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 2);
							defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
							defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n当前并未达到#R");
							defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.当前境界);
							defaultInterpolatedStringHandler.AppendLiteral("#n的#R圆满#n状态，无法挑战！");
							P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return false;
						}
					}
				}
				if (P_1.is道行开关)
				{
					if (myNATSocketClient.user.属性数据.道行 < P_1.最低道行 * 360)
					{
						WdAPI i6 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的道行不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.最低道行);
						defaultInterpolatedStringHandler.AppendLiteral("#n年，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (myNATSocketClient.user.属性数据.道行 > P_1.最高道行 * 360)
					{
						WdAPI i7 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的道行超过了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.最高道行);
						defaultInterpolatedStringHandler.AppendLiteral("#n年，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i7.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
				}
				if (P_1.is活跃开关)
				{
					if (myNATSocketClient.user.缓存数据.活跃值 < P_1.最低活跃)
					{
						WdAPI i8 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的活跃度不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.最低活跃);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i8.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (myNATSocketClient.user.缓存数据.活跃值 > P_1.最高活跃)
					{
						WdAPI i9 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的活跃度超过了#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.最高活跃);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i9.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
				}
				if (P_1.is称号开关)
				{
					if (!string.IsNullOrWhiteSpace(P_1.指定称号1) && !myNATSocketClient.user.缓存数据.所有称号文本.ToString().Contains(P_1.指定称号1, StringComparison.CurrentCulture))
					{
						WdAPI i10 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n并未拥有#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.指定称号1);
						defaultInterpolatedStringHandler.AppendLiteral("#n称号，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i10.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (!string.IsNullOrWhiteSpace(P_1.指定称号2) && !myNATSocketClient.user.缓存数据.所有称号文本.ToString().Contains(P_1.指定称号2, StringComparison.CurrentCulture))
					{
						WdAPI i11 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n并未拥有#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.指定称号2);
						defaultInterpolatedStringHandler.AppendLiteral("#n称号，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i11.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
				}
				if (P_1.is击杀开关)
				{
					if (myNATSocketClient.user.宠物数据.All( (宠物缓存数据类 a) => a.宠物ID == 0))
					{
						WdAPI i12 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n并未携带任何宠物，无法挑战#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n！");
						P_0.C_Send(i12.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					if (P_1.每日限制击杀 <= 0)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + P_1.BOSS名字 + "#nBOSS暂无法被挑战！"));
						return false;
					}
					if (myNATSocketClient.user.存档数据.挑战BOSS数据.TryGetValue(P_1.BOSS名字, out var value))
					{
						int num2 = ((Singleton<全局变量类>.I.挑战BOSS配置.is指定会员双倍 && myNATSocketClient.user.缓存数据.Is指定会员) ? (P_1.每日限制击杀 * 2) : P_1.每日限制击杀);
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 4);
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("[已挑战次数：");
						defaultInterpolatedStringHandler.AppendFormatted(value.已挑战次数);
						defaultInterpolatedStringHandler.AppendLiteral("][新增挑战次数：");
						defaultInterpolatedStringHandler.AppendFormatted(value.新增挑战次数);
						defaultInterpolatedStringHandler.AppendLiteral("][可击杀：");
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
						if (value.已挑战次数 >= value.新增挑战次数 + num2)
						{
							WdAPI i13 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
							defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
							defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n今日已击杀了#R");
							defaultInterpolatedStringHandler.AppendFormatted(value.已挑战次数);
							defaultInterpolatedStringHandler.AppendLiteral("#n只#Y");
							defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
							defaultInterpolatedStringHandler.AppendLiteral("#n，无法继续挑战BOSS！");
							P_0.C_Send(i13.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return false;
						}
					}
					else
					{
						myNATSocketClient.user.存档数据.挑战BOSS数据.TryAdd(P_1.BOSS名字, new 挑战BOSS数据类
						{
							boss名字 = P_1.BOSS名字,
							已挑战次数 = 0,
							新增挑战次数 = 0
						});
					}
				}
				if (!P_1.is挑战消耗 || P_1.消耗类型 == AllEnums.数值Type.无 || P_1.消耗数量 <= 0)
				{
					continue;
				}
				物品信息类 物品信息类2 = Singleton<WdAPI>.I.取背包物品格子实例(myNATSocketClient, P_1.消耗道具);
				switch (P_1.消耗类型)
				{
				case AllEnums.数值Type.道行:
					if (myNATSocketClient.user.属性数据.道行 < P_1.消耗数量 * 360)
					{
						WdAPI i20 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的道行不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n年，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i20.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.声望:
					if (myNATSocketClient.user.属性数据.声望 < P_1.消耗数量)
					{
						WdAPI i24 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的声望不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i24.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.战绩:
					if (myNATSocketClient.user.属性数据.战绩 < P_1.消耗数量)
					{
						WdAPI i26 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的战绩不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i26.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.金元宝:
					if (myNATSocketClient.user.背包数据.金元宝 < P_1.消耗数量)
					{
						WdAPI i22 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的金元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i22.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.银元宝:
					if (myNATSocketClient.user.背包数据.银元宝 < P_1.消耗数量)
					{
						WdAPI i15 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的银元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i15.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.金钱:
					if (myNATSocketClient.user.背包数据.金钱 < P_1.消耗数量)
					{
						WdAPI i25 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的游戏币不足");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(P_1.消耗数量));
						defaultInterpolatedStringHandler.AppendLiteral("文钱，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i25.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.累充点:
					if (myNATSocketClient.user.存档数据.累计充值金额 < P_1.消耗数量)
					{
						WdAPI i23 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的累充点不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i23.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.南极点:
					if (myNATSocketClient.user.存档数据.南极抽奖次数 < P_1.消耗数量)
					{
						WdAPI i21 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的南极点不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i21.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				case AllEnums.数值Type.道具:
					if (!string.IsNullOrWhiteSpace(P_1.消耗道具) && P_1.消耗数量 > 0)
					{
						if (Singleton<WdAPI>.I.取背包剩余空格数(myNATSocketClient) < 1)
						{
							WdAPI i16 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
							defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
							defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n的背包已满，无法挑战#Y");
							defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
							defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
							P_0.C_Send(i16.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return false;
						}
						if (!Singleton<WdAPI>.I.dSCoKmGWP9(myNATSocketClient))
						{
							WdAPI i17 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
							defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
							defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n的宠物栏已满，无法挑战#Y");
							defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
							defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
							P_0.C_Send(i17.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return false;
						}
						物品信息类2 = Singleton<WdAPI>.I.取背包物品格子实例(myNATSocketClient, P_1.消耗道具);
						if (物品信息类2 == null)
						{
							WdAPI i18 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 3);
							defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
							defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n背包暂无#R");
							defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗道具);
							defaultInterpolatedStringHandler.AppendLiteral("#n，无法挑战#Y");
							defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
							defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
							P_0.C_Send(i18.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return false;
						}
						if (物品信息类2.数量 < P_1.消耗数量)
						{
							WdAPI i19 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 4);
							defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
							defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n背包中的#R");
							defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗道具);
							defaultInterpolatedStringHandler.AppendLiteral("#n数量不足#R");
							defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
							defaultInterpolatedStringHandler.AppendLiteral("#n个，无法挑战#Y");
							defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
							defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
							P_0.C_Send(i19.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return false;
						}
					}
					break;
				case AllEnums.数值Type.体力:
					if (myNATSocketClient.user.属性数据.当前体力 < P_1.消耗数量)
					{
						WdAPI i14 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
						defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
						defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的体力不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法挑战#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
						P_0.C_Send(i14.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return false;
					}
					break;
				}
				concurrentDictionary.TryAdd(myNATSocketClient, 物品信息类2?.Index ?? 0);
			}
			if (!concurrentDictionary.IsEmpty)
			{
				foreach (KeyValuePair<MyNATSocketClient, int> item2 in concurrentDictionary)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					switch (P_1.消耗类型)
					{
					case AllEnums.数值Type.道行:
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, -(P_1.消耗数量 * 360), false, "[BOSS]挑战消耗");
						break;
					case AllEnums.数值Type.声望:
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, -P_1.消耗数量, false, "[BOSS]挑战消耗");
						break;
					case AllEnums.数值Type.战绩:
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.total_score, -P_1.消耗数量, false, "[BOSS]挑战消耗");
						break;
					case AllEnums.数值Type.金元宝:
						if (!DB.I.cAJNoOkab6(item2.Key, -P_1.消耗数量, 0))
						{
							WdAPI i28 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
							defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
							defaultInterpolatedStringHandler.AppendFormatted(item2.Key.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n的金元宝扣除失败，无法挑战#Y");
							defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
							defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
							P_0.C_Send(i28.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return false;
						}
						break;
					case AllEnums.数值Type.银元宝:
						if (!DB.I.cAJNoOkab6(item2.Key, 0, -P_1.消耗数量))
						{
							WdAPI i27 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
							defaultInterpolatedStringHandler.AppendLiteral("队伍成员#R");
							defaultInterpolatedStringHandler.AppendFormatted(item2.Key.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n的银元宝扣除失败，无法挑战#Y");
							defaultInterpolatedStringHandler.AppendFormatted(P_1.BOSS名字);
							defaultInterpolatedStringHandler.AppendLiteral("#nBOSS！");
							P_0.C_Send(i27.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return false;
						}
						break;
					case AllEnums.数值Type.金钱:
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -P_1.消耗数量, false, "[BOSS]挑战消耗");
						break;
					case AllEnums.数值Type.累充点:
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, -P_1.消耗数量, false, "挑战[" + P_1.BOSS名字 + "]BOSS消耗");
						break;
					case AllEnums.数值Type.南极点:
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, -P_1.消耗数量, false, "挑战[" + P_1.BOSS名字 + "]消耗");
						break;
					case AllEnums.数值Type.道具:
						if (item2.Value != 0)
						{
							Singleton<WdAPI>.I.WywoUvuXuV(item2.Key, item2.Value, P_1.消耗数量);
						}
						break;
					case AllEnums.数值Type.体力:
						Singleton<WdAPI>.I.PndoGw5lW7(item2.Key, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.stamina, -P_1.消耗数量, false, "[BOSS]挑战消耗");
						break;
					}
					item2.Key.user.缓存数据.is扣除标识 = true;
					MyNATSocketClient key = item2.Key;
					WdAPI i29 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗类型);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					key.C_Send(i29.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("组队挑战BOSS验证-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal void jkMUssH7u1(MyNATSocketClient P_0, string P_1, 挑战BOSS列表类 P_2)
	{
		try
		{
			if (!P_2.is击杀开关 || !P_2.is补充开关 || !P_0.user.存档数据.挑战BOSS数据.TryGetValue(P_2.BOSS名字, out var value) || P_2.每日限制击杀 <= 0)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (P_2.补充消耗 > 0)
			{
				switch (P_2.补充类型)
				{
				case AllEnums.数值Type.声望:
					if (P_0.user.属性数据.声望 < P_2.补充消耗)
					{
						WdAPI i5 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的声望不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_2.补充消耗);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法补充#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_2.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n的挑战次数！");
						P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, -P_2.补充消耗, false, "[BOSS]挑战消耗");
					break;
				case AllEnums.数值Type.金元宝:
					if (P_0.user.背包数据.金元宝 < P_2.补充消耗)
					{
						WdAPI i2 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的金元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_2.补充消耗);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法补充#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_2.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n的挑战次数！");
						P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					if (!DB.I.cAJNoOkab6(P_0, -P_2.补充消耗, 0))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的金元宝扣除失败，无法补充#Y" + P_2.BOSS名字 + "#n的挑战次数！"));
						return;
					}
					break;
				case AllEnums.数值Type.银元宝:
					if (P_0.user.背包数据.银元宝 < P_2.补充消耗)
					{
						WdAPI i3 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的银元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_2.补充消耗);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法补充#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_2.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n的挑战次数！");
						P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					if (!DB.I.cAJNoOkab6(P_0, 0, -P_2.补充消耗))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的银元宝扣除失败，无法补充#Y" + P_2.BOSS名字 + "#n的挑战次数！"));
						return;
					}
					break;
				case AllEnums.数值Type.金钱:
					if (P_0.user.背包数据.金钱 < P_2.补充消耗)
					{
						WdAPI i4 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的游戏币不足");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(P_2.补充消耗));
						defaultInterpolatedStringHandler.AppendLiteral("文钱，无法补充#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_2.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n的挑战次数！");
						P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -P_2.补充消耗, false, "[BOSS]挑战消耗");
					break;
				case AllEnums.数值Type.体力:
					if (P_0.user.属性数据.当前体力 < P_2.补充消耗)
					{
						WdAPI i = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你的体力不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_2.补充消耗);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法补充#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_2.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n的挑战次数！");
						P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.stamina, -P_2.补充消耗, false, "[BOSS]补充消耗");
					break;
				}
			}
			value.新增挑战次数++;
			WdAPI i6 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 3);
			defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_2.补充消耗);
			defaultInterpolatedStringHandler.AppendFormatted(P_2.补充类型);
			defaultInterpolatedStringHandler.AppendLiteral("#n成功补充了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_2.BOSS名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n的挑战次数！");
			byte[] first = i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear());
			WdAPI i7 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 3);
			defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_2.补充消耗);
			defaultInterpolatedStringHandler.AppendFormatted(P_2.补充类型);
			defaultInterpolatedStringHandler.AppendLiteral("#n成功补充了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_2.BOSS名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n的挑战次数！");
			P_0.C_Send(first.Concat(i7.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
		}
		catch (Exception ex)
		{
			Log.Error("超级BOSS补充次数-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public async Task M3kUUiH02y(MyNATSocketClient P_0, bool P_1)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals58 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals58.u5ecWi476U = P_0;
		try
		{
			if (CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字 == "-1")
			{
				return;
			}
			if (string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字))
			{
				CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字 = "-1";
				return;
			}
			if (!Singleton<全局变量类>.I.挑战BOSS配置.功能开关 || P_1)
			{
				CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字 = "-1";
				return;
			}
			bool flag = true;
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && Singleton<ByteAPI>.I.寻找文本(Ab7Ypu2aCcHMcLPG8Um.xh4mILM5j1.ToString(), CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字 ?? ""))
			{
				元神境界配置类 元神境界配置类2 = Ab7Ypu2aCcHMcLPG8Um.wIn2YFWhMH(CS_0024_003C_003E8__locals58.u5ecWi476U.user.存档数据.元神存档.当前境界);
				if (元神境界配置类2 != null && 元神境界配置类2.突破特殊需求.Is额外条件 && 元神境界配置类2.突破特殊需求.Is击杀BOSS要求)
				{
					flag = 元神境界配置类2.突破特殊需求.击杀BOSS要求 == CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字;
					if (string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals58.u5ecWi476U.user.存档数据.元神存档.击杀BOSS达成) && 元神境界配置类2.突破特殊需求.击杀BOSS要求 == CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字 && (CS_0024_003C_003E8__locals58.u5ecWi476U.user.队伍数据.is队长 || CS_0024_003C_003E8__locals58.u5ecWi476U.user.队伍数据.成员列表.Count <= 0))
					{
						CS_0024_003C_003E8__locals58.u5ecWi476U.user.存档数据.元神存档.击杀BOSS达成 = CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字;
						MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals58.u5ecWi476U;
						WdAPI i = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你完成了#R");
						defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("#n突破至#R");
						defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.突破境界);
						defaultInterpolatedStringHandler.AppendLiteral("#n的击杀#R");
						defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.突破特殊需求.击杀BOSS要求);
						defaultInterpolatedStringHandler.AppendLiteral("#n条件。");
						myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					else
					{
						MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals58.u5ecWi476U;
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 3);
						defaultInterpolatedStringHandler.AppendLiteral("由于你已经完成了#R");
						defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("#n突破至#R");
						defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.突破境界);
						defaultInterpolatedStringHandler.AppendLiteral("#n的击杀#R");
						defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.突破特殊需求.击杀BOSS要求);
						defaultInterpolatedStringHandler.AppendLiteral("#n条件，无法重复完成。");
						myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
				}
			}
			if (Singleton<ByteAPI>.I.寻找文本("|天魁星|天魔星|天机星|天闲星|天勇星|天雄星|天猛星|天威星|天英星|天贵星|天富星|天满星|天孤星|天伤星|天立星|天捷星|天暗星|天祐星|天空星|天速星|天异星|天杀星|天微星|天究星|天退星|天寿星|天剑星|天平星|天罪星|天损星|天败星|天牢星|天慧星|天暴星|天哭星|天巧星|", "|" + CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字 + "|"))
			{
				CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字 = "天星";
			}
			else if (Singleton<ByteAPI>.I.寻找文本("|地魁星|地煞星|地勇星|地杰星|地雄星|地威星|地英星|地奇星|地猛星|地文星|地正星|地辟星|地阖星|地强星|地暗星|地轴星|地会星|地佐星|地佑星|地灵星|地兽星|地微星|地慧星|地暴星|地默星|地猖星|地狂星|地飞星|地走星|地巧星|地明星|地进星|地退星|地满星|地遂星|地周星|地隐星|地异星|地理星|地俊星|地乐星|地捷星|地速星|地镇星|地稽星|地魔星|地妖星|地幽星|地伏星|地僻星|地空星|地孤星|地全星|地短星|地角星|地囚星|地藏星|地平星|地损星|地奴星|地察星|地恶星|地丑星|地数星|地阴星|地刑星|地壮星|地劣星|地健星|地耗星|地贼星|地狗星|", "|" + CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字 + "|"))
			{
				CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字 = "地星";
			}
			if (!Singleton<全局变量类>.I.挑战BOSS配置.挑战boss列表.TryGetValue(CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字, out 挑战BOSS列表类 挑战boss数据))
			{
				挑战boss数据 = Singleton<全局变量类>.I.挑战BOSS配置.挑战boss列表.Values.ToList().Find( (挑战BOSS列表类 x) => x.BOSS战斗名字 == CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字);
			}
			CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字 = "-1";
			if (挑战boss数据 == null)
			{
				return;
			}
			if (挑战boss数据.is击杀开关)
			{
				if (CS_0024_003C_003E8__locals58.u5ecWi476U.user.存档数据.挑战BOSS数据.TryGetValue(挑战boss数据.BOSS名字, out var value))
				{
					value.已挑战次数++;
				}
				else
				{
					CS_0024_003C_003E8__locals58.u5ecWi476U.user.存档数据.挑战BOSS数据.TryAdd(挑战boss数据.BOSS名字, new 挑战BOSS数据类
					{
						boss名字 = 挑战boss数据.BOSS名字,
						已挑战次数 = 1,
						新增挑战次数 = 0
					});
				}
			}
			if (!挑战boss数据.is掉落开关 || 挑战boss数据.掉落列表 == null || 挑战boss数据.掉落列表.Count <= 0)
			{
				return;
			}
			if (挑战boss数据.只给队长 && !CS_0024_003C_003E8__locals58.u5ecWi476U.user.队伍数据.is队长)
			{
				CS_0024_003C_003E8__locals58.u5ecWi476U.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("由于你不是队长，无法获得#Y" + 挑战boss数据.BOSS名字 + "#n的额外奖励"));
				return;
			}
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND())
			{
				if (!flag)
				{
					return;
				}
				if (Singleton<全局变量类>.I.元神系统配置.超过BOSS二层境界不获得任何奖励 && Enum.TryParse<AllEnums.元神境界>(挑战boss数据.BOSS称号, out var result) && CS_0024_003C_003E8__locals58.u5ecWi476U.user.存档数据.元神存档.当前境界 - result > 2)
				{
					CS_0024_003C_003E8__locals58.u5ecWi476U.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("由于的境界超过#Y" + 挑战boss数据.BOSS名字 + "#n2个大境界，无法获得奖励。"));
					return;
				}
			}
			if (CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.is战斗中)
			{
				await Task.Delay(1000);
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int num = 0; num < 挑战boss数据.掉落列表.Count; num++)
			{
				int num2 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 10000);
				if (挑战boss数据.掉落列表[num].掉落几率 < num2)
				{
					continue;
				}
				int num3 = Singleton<WdAPI>.I.qrjo9TWIdy(挑战boss数据.掉落列表[num].掉落最低数量, 挑战boss数据.掉落列表[num].掉落最高数量);
				if (num3 <= 0)
				{
					continue;
				}
				if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.config.记录账号列表) && !string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals58.u5ecWi476U.user.人物数据.昵称) && Singleton<ByteAPI>.I.寻找文本(Singleton<全局变量类>.I.config.记录账号列表, "," + CS_0024_003C_003E8__locals58.u5ecWi476U.user.人物数据.昵称 + ","))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 4);
					defaultInterpolatedStringHandler.AppendLiteral("【接收】 【挑战boss掉落数据：");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals58.u5ecWi476U.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("】【id：");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals58.u5ecWi476U.user.人物数据.角色ID);
					defaultInterpolatedStringHandler.AppendLiteral("】【是否逃跑：[");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("]】【掉落数据：");
					defaultInterpolatedStringHandler.AppendFormatted(JsonConvert.SerializeObject(挑战boss数据.掉落列表[num]));
					defaultInterpolatedStringHandler.AppendLiteral("】");
					Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				switch (挑战boss数据.掉落列表[num].掉落类型)
				{
				case AllEnums.数值Type.金元宝:
				{
					WdAPI i9 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient9 = CS_0024_003C_003E8__locals58.u5ecWi476U;
					string empty2 = string.Empty;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
					defaultInterpolatedStringHandler.AppendLiteral("[【");
					defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
					defaultInterpolatedStringHandler.AppendLiteral("掉落】");
					defaultInterpolatedStringHandler.AppendFormatted(num3);
					defaultInterpolatedStringHandler.AppendLiteral("金元宝]");
					if (i9.PndoGw5lW7(myNATSocketClient9, AllEnums.发送数据Type.金元宝, empty2, AllEnums.指令Type.无, num3, false, defaultInterpolatedStringHandler.ToStringAndClear()))
					{
						MyNATSocketClient myNATSocketClient10 = CS_0024_003C_003E8__locals58.u5ecWi476U;
						WdAPI i10 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n奖励的#Y");
						defaultInterpolatedStringHandler.AppendFormatted(num3);
						defaultInterpolatedStringHandler.AppendLiteral("#n金元宝");
						myNATSocketClient10.C_Send(i10.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						if (挑战boss数据.掉落列表[num].Is谣言)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder8 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
							handler.AppendLiteral("、#Y");
							handler.AppendFormatted(num3);
							handler.AppendLiteral("金元宝#n");
							stringBuilder8.Append(ref handler);
						}
					}
					break;
				}
				case AllEnums.数值Type.银元宝:
				{
					WdAPI i4 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals58.u5ecWi476U;
					string empty = string.Empty;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
					defaultInterpolatedStringHandler.AppendLiteral("[【");
					defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
					defaultInterpolatedStringHandler.AppendLiteral("掉落】");
					defaultInterpolatedStringHandler.AppendFormatted(num3);
					defaultInterpolatedStringHandler.AppendLiteral("银元宝]");
					if (i4.PndoGw5lW7(myNATSocketClient4, AllEnums.发送数据Type.银元宝, empty, AllEnums.指令Type.无, num3, false, defaultInterpolatedStringHandler.ToStringAndClear()))
					{
						MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals58.u5ecWi476U;
						WdAPI i5 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n奖励的#Y");
						defaultInterpolatedStringHandler.AppendFormatted(num3);
						defaultInterpolatedStringHandler.AppendLiteral("#n银元宝");
						myNATSocketClient5.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						if (挑战boss数据.掉落列表[num].Is谣言)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder4 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
							handler.AppendLiteral("、#Y");
							handler.AppendFormatted(num3);
							handler.AppendLiteral("银元宝#n");
							stringBuilder4.Append(ref handler);
						}
					}
					break;
				}
				case AllEnums.数值Type.金钱:
					if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals58.u5ecWi476U, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, num3, false, 挑战boss数据.BOSS名字 + "boss掉落"))
					{
						MyNATSocketClient myNATSocketClient13 = CS_0024_003C_003E8__locals58.u5ecWi476U;
						WdAPI i13 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n奖励的");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(num3));
						defaultInterpolatedStringHandler.AppendLiteral("#n文钱。");
						myNATSocketClient13.C_Send(i13.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						if (挑战boss数据.掉落列表[num].Is谣言)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder11 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
							handler.AppendLiteral("、");
							handler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(num3));
							handler.AppendLiteral("#n文钱");
							stringBuilder11.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.代金券:
					if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals58.u5ecWi476U, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.voucher, num3, false, 挑战boss数据.BOSS名字 + "boss掉落"))
					{
						MyNATSocketClient myNATSocketClient15 = CS_0024_003C_003E8__locals58.u5ecWi476U;
						WdAPI i15 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n奖励的");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(num3));
						defaultInterpolatedStringHandler.AppendLiteral("#n代金券。");
						myNATSocketClient15.C_Send(i15.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						if (挑战boss数据.掉落列表[num].Is谣言)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder13 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, stringBuilder2);
							handler.AppendLiteral("、");
							handler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(num3));
							handler.AppendLiteral("#n代金券");
							stringBuilder13.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.声望:
					if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals58.u5ecWi476U, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, num3, false, 挑战boss数据.BOSS名字 + "boss掉落"))
					{
						MyNATSocketClient myNATSocketClient8 = CS_0024_003C_003E8__locals58.u5ecWi476U;
						WdAPI i8 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n奖励的#Y");
						defaultInterpolatedStringHandler.AppendFormatted(num3);
						defaultInterpolatedStringHandler.AppendLiteral("#n声望。");
						myNATSocketClient8.C_Send(i8.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						if (挑战boss数据.掉落列表[num].Is谣言)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder7 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(7, 1, stringBuilder2);
							handler.AppendLiteral("、#Y");
							handler.AppendFormatted(num3);
							handler.AppendLiteral("声望#n");
							stringBuilder7.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.道具:
					if (!string.IsNullOrWhiteSpace(挑战boss数据.掉落列表[num].掉落道具) && Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals58.u5ecWi476U, AllEnums.发送数据Type.道具, 挑战boss数据.掉落列表[num].掉落道具, AllEnums.指令Type.无, num3, false, 挑战boss数据.BOSS名字 + "boss掉落"))
					{
						MyNATSocketClient myNATSocketClient12 = CS_0024_003C_003E8__locals58.u5ecWi476U;
						WdAPI i12 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 3);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n奖励的#Y");
						defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.掉落列表[num].掉落道具);
						defaultInterpolatedStringHandler.AppendLiteral("×");
						defaultInterpolatedStringHandler.AppendFormatted(num3);
						defaultInterpolatedStringHandler.AppendLiteral("#n。");
						myNATSocketClient12.C_Send(i12.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						if (挑战boss数据.掉落列表[num].Is谣言)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder10 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(6, 2, stringBuilder2);
							handler.AppendLiteral("、#Y");
							handler.AppendFormatted(挑战boss数据.掉落列表[num].掉落道具);
							handler.AppendLiteral("×");
							handler.AppendFormatted(num3);
							handler.AppendLiteral("#n");
							stringBuilder10.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.道行:
					if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals58.u5ecWi476U, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, num3 * 360, false, 挑战boss数据.BOSS名字 + "boss掉落"))
					{
						MyNATSocketClient myNATSocketClient6 = CS_0024_003C_003E8__locals58.u5ecWi476U;
						WdAPI i6 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n奖励的#Y");
						defaultInterpolatedStringHandler.AppendFormatted(num3);
						defaultInterpolatedStringHandler.AppendLiteral("年#n道行。");
						myNATSocketClient6.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						if (挑战boss数据.掉落列表[num].Is谣言)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder5 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
							handler.AppendLiteral("、#Y");
							handler.AppendFormatted(num3);
							handler.AppendLiteral("年道行#n");
							stringBuilder5.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.累充点:
					if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals58.u5ecWi476U, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, num3, false, 挑战boss数据.BOSS名字 + "boss掉落"))
					{
						MyNATSocketClient myNATSocketClient14 = CS_0024_003C_003E8__locals58.u5ecWi476U;
						WdAPI i14 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n奖励的#Y累充点×");
						defaultInterpolatedStringHandler.AppendFormatted(num3);
						defaultInterpolatedStringHandler.AppendLiteral("#n。");
						myNATSocketClient14.C_Send(i14.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						if (挑战boss数据.掉落列表[num].Is谣言)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder12 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
							handler.AppendLiteral("、#Y");
							handler.AppendFormatted(num3);
							handler.AppendLiteral("累充点#n");
							stringBuilder12.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.南极点:
					if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals58.u5ecWi476U, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, num3, false, 挑战boss数据.BOSS名字 + "boss掉落"))
					{
						MyNATSocketClient myNATSocketClient11 = CS_0024_003C_003E8__locals58.u5ecWi476U;
						WdAPI i11 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n奖励的#Y南极点×");
						defaultInterpolatedStringHandler.AppendFormatted(num3);
						defaultInterpolatedStringHandler.AppendLiteral("#n。");
						myNATSocketClient11.C_Send(i11.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						if (挑战boss数据.掉落列表[num].Is谣言)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder9 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
							handler.AppendLiteral("、#Y");
							handler.AppendFormatted(num3);
							handler.AppendLiteral("南极点#n");
							stringBuilder9.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.奇宝点:
					if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals58.u5ecWi476U, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, num3, false, 挑战boss数据.BOSS名字 + "boss掉落"))
					{
						MyNATSocketClient myNATSocketClient7 = CS_0024_003C_003E8__locals58.u5ecWi476U;
						WdAPI i7 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n奖励的#Y奇宝点×");
						defaultInterpolatedStringHandler.AppendFormatted(num3);
						defaultInterpolatedStringHandler.AppendLiteral("#n。");
						myNATSocketClient7.C_Send(i7.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						if (挑战boss数据.掉落列表[num].Is谣言)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder6 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
							handler.AppendLiteral("、#Y");
							handler.AppendFormatted(num3);
							handler.AppendLiteral("奇宝点#n");
							stringBuilder6.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.灵气值:
					if (Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals58.u5ecWi476U, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, num3, false, 挑战boss数据.BOSS名字 + "boss掉落"))
					{
						MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals58.u5ecWi476U;
						WdAPI i3 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你获得了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n奖励的#Y灵气值×");
						defaultInterpolatedStringHandler.AppendFormatted(num3);
						defaultInterpolatedStringHandler.AppendLiteral("#n。");
						myNATSocketClient3.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						if (挑战boss数据.掉落列表[num].Is谣言)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder3 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
							handler.AppendLiteral("、#Y");
							handler.AppendFormatted(num3);
							handler.AppendLiteral("#n点灵气值");
							stringBuilder3.Append(ref handler);
						}
					}
					break;
				}
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append("。");
				stringBuilder.Remove(0, 1);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜#Y");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals58.u5ecWi476U.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("#n道友在击杀了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(挑战boss数据.BOSS名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n后意外获得了");
				stringBuilder.Insert(0, defaultInterpolatedStringHandler.ToStringAndClear());
				Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(stringBuilder.ToString(), "管理员"));
			}
		}
		catch (Exception ex)
		{
			CS_0024_003C_003E8__locals58.u5ecWi476U.user.缓存数据.当前战斗BOSS名字 = "-1";
			Log.Error("挑战boss战斗结算-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public void XyyUWS3eEO(MyNATSocketClient P_0, 挑战BOSS列表类 P_1)
	{
		try
		{
			if (!P_1.is挑战消耗 || P_1.消耗类型 == AllEnums.数值Type.无 || P_1.消耗数量 <= 0)
			{
				return;
			}
			if (P_0.user.队伍数据.成员列表.Count <= 1)
			{
				if (!P_0.user.缓存数据.is扣除标识)
				{
					return;
				}
				P_0.user.缓存数据.is扣除标识 = false;
				switch (P_1.消耗类型)
				{
				case AllEnums.数值Type.道行:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, P_1.消耗数量 * 360, false, "[BOSS]返回挑战消耗");
					WdAPI i8 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n年道行！");
					P_0.C_Send(i8.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.声望:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, P_1.消耗数量, false, "[BOSS]返回挑战消耗");
					WdAPI i6 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n点声望！");
					P_0.C_Send(i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.战绩:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.total_score, P_1.消耗数量, false, "[BOSS]返回挑战消耗");
					WdAPI i9 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n点战绩！");
					P_0.C_Send(i9.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.金元宝:
					if (DB.I.cAJNoOkab6(P_0, P_1.消耗数量, 0))
					{
						WdAPI i7 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
						defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n金元宝！");
						P_0.C_Send(i7.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					break;
				case AllEnums.数值Type.银元宝:
					if (!DB.I.cAJNoOkab6(P_0, 0, P_1.消耗数量))
					{
						WdAPI i5 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
						defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n银元宝！");
						P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					break;
				case AllEnums.数值Type.金钱:
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, P_1.消耗数量, false, "[BOSS]返回挑战消耗");
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的" + Singleton<WdAPI>.I.问道标准数值文本(P_1.消耗数量) + "文钱！"));
					break;
				case AllEnums.数值Type.累充点:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, P_1.消耗数量, false, "系统返回挑战[" + P_1.BOSS名字 + "]BOSS消耗");
					WdAPI i4 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n累充点！");
					P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.南极点:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, P_1.消耗数量, false, "返回挑战[" + P_1.BOSS名字 + "]消耗");
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n南极点！");
					P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.体力:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.stamina, P_1.消耗数量, false, "[BOSS]返回挑战消耗");
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n体力！");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.道具:
				{
					Singleton<WdAPI>.I.OhAIEJ4cvw(P_0, P_1.消耗道具, P_1.消耗数量);
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 2);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n×#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.经验:
					break;
				}
				return;
			}
			foreach (int item in P_0.user.队伍数据.成员列表)
			{
				MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定角色ID玩家MyClient(item);
				if (myNATSocketClient == null || !myNATSocketClient.user.缓存数据.is队伍中 || !myNATSocketClient.user.缓存数据.is扣除标识)
				{
					continue;
				}
				myNATSocketClient.user.缓存数据.is扣除标识 = false;
				switch (P_1.消耗类型)
				{
				case AllEnums.数值Type.道行:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(myNATSocketClient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, P_1.消耗数量 * 360, false, "[BOSS]返回挑战消耗");
					WdAPI i17 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n年道行！");
					myNATSocketClient.C_Send(i17.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.声望:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(myNATSocketClient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, P_1.消耗数量, false, "[BOSS]返回挑战消耗");
					WdAPI i15 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n点声望！");
					myNATSocketClient.C_Send(i15.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.战绩:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(myNATSocketClient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.total_score, P_1.消耗数量, false, "[BOSS]返回挑战消耗");
					WdAPI i18 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n点战绩！");
					myNATSocketClient.C_Send(i18.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.金元宝:
					if (DB.I.cAJNoOkab6(myNATSocketClient, P_1.消耗数量, 0))
					{
						WdAPI i16 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
						defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n金元宝！");
						myNATSocketClient.C_Send(i16.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					break;
				case AllEnums.数值Type.银元宝:
					if (!DB.I.cAJNoOkab6(myNATSocketClient, 0, P_1.消耗数量))
					{
						WdAPI i14 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
						defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n银元宝！");
						myNATSocketClient.C_Send(i14.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					break;
				case AllEnums.数值Type.金钱:
					Singleton<WdAPI>.I.PndoGw5lW7(myNATSocketClient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, P_1.消耗数量, false, "[BOSS]返回挑战消耗");
					myNATSocketClient.C_Send(Singleton<WdAPI>.I.提示_中心提醒("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的" + Singleton<WdAPI>.I.问道标准数值文本(P_1.消耗数量) + "文钱！"));
					break;
				case AllEnums.数值Type.累充点:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(myNATSocketClient, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, P_1.消耗数量, false, "系统返回挑战[" + P_1.BOSS名字 + "]BOSS消耗");
					WdAPI i13 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n累充点！");
					myNATSocketClient.C_Send(i13.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.南极点:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(myNATSocketClient, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, P_1.消耗数量, false, "返回挑战[" + P_1.BOSS名字 + "]消耗");
					WdAPI i12 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n南极点！");
					myNATSocketClient.C_Send(i12.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.体力:
				{
					Singleton<WdAPI>.I.PndoGw5lW7(myNATSocketClient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.stamina, P_1.消耗数量, false, "[BOSS]返回挑战消耗");
					WdAPI i11 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n体力！");
					myNATSocketClient.C_Send(i11.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.道具:
				{
					Singleton<WdAPI>.I.OhAIEJ4cvw(myNATSocketClient, P_1.消耗道具, P_1.消耗数量);
					WdAPI i10 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 2);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，挑战失败，当前BOSS已经被别人抢先了，系统即将返回你消耗的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n×#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.消耗数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n！");
					myNATSocketClient.C_Send(i10.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("挑战boss失败返还-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public FBGRmlstyRWQdqi0pHa()
	{
	}

	static FBGRmlstyRWQdqi0pHa()
	{
	}
}
