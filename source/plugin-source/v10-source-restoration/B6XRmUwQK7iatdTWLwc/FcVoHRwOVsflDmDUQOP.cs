using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace B6XRmUwQK7iatdTWLwc;

internal class FcVoHRwOVsflDmDUQOP : Singleton<FcVoHRwOVsflDmDUQOP>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public MyNATSocketClient aFHX0SCC7v;

		public int x4DXOtQ8wE;

		
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		
		internal async void RVPXkAhHO2(string v)
		{
			aFHX0SCC7v.召唤精怪事件 = null;
			if (aFHX0SCC7v.user.宠物数据[x4DXOtQ8wE].昵称B != v)
			{
				return;
			}
			int 宠物ID = aFHX0SCC7v.user.宠物数据[x4DXOtQ8wE].宠物ID;
			do
			{
				await Task.Delay(2000);
				if (!aFHX0SCC7v.user.缓存数据.is战斗中)
				{
					aFHX0SCC7v.S_Send(Singleton<WdAPI>.I.FdioldHrOI(宠物ID));
					break;
				}
				await Task.Delay(1);
			}
			while (aFHX0SCC7v.user.缓存数据.is战斗中);
		}

		static _003C_003Ec__DisplayClass12_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public string bdfXEcDmvy;

		public Predicate<召唤精怪列表类> B7oX3BWLpH;

		
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		
		internal bool IptXQpbCJU(召唤精怪列表类 x)
		{
			return x.礼包名字 == bdfXEcDmvy;
		}

		static _003C_003Ec__DisplayClass7_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public MyNATSocketClient sgVXp5j6FM;

		public List<int> wFPX1Viop6;

		
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		
		internal void S1BXYvZTAZ(string v)
		{
			sgVXp5j6FM.召唤精怪事件 = null;
			sgVXp5j6FM.S_Send(Singleton<WdAPI>.I.DN4IOFDdr5(sgVXp5j6FM, wFPX1Viop6.ToArray()));
		}

		static _003C_003Ec__DisplayClass8_0()
		{
		}
	}

	public static string xMdwA0JR7B;

	
	[SpecialName]
	public static bool JhVwZ5yCsf()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.IsVip)
		{
			return Singleton<全局变量类>.I.召唤精怪配置.功能开关;
		}
		return false;
	}

	
	internal void NgDwE6S406()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("召唤精怪配置类.json")))
			{
				Singleton<全局变量类>.I.召唤精怪配置 = JsonConvert.DeserializeObject<召唤精怪配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("召唤精怪配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.召唤精怪配置 = new 召唤精怪配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("召唤精怪配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.召唤精怪配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("召唤精怪配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void DG9w3utaPB()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("召唤精怪配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.召唤精怪配置, Formatting.Indented));
			Log.Debug("召唤精怪配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("召唤精怪配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string EQrwYJO23T()
	{
		NgDwE6S406();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.召唤精怪配置, Formatting.Indented);
	}

	
	public void eb2wpkgUo1(string P_0)
	{
		Singleton<全局变量类>.I.召唤精怪配置 = JsonConvert.DeserializeObject<召唤精怪配置类>(P_0);
		DG9w3utaPB();
	}

	
	public 召唤精怪列表类 tMOw1LxwSn(string P_0)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals2.bdfXEcDmvy = P_0;
		召唤精怪列表类 召唤精怪列表类2 = null;
		foreach (List<召唤精怪列表类> value in Singleton<全局变量类>.I.召唤精怪配置.召唤列表.Values)
		{
			召唤精怪列表类2 = value.Find( (召唤精怪列表类 x) => x.礼包名字 == CS_0024_003C_003E8__locals2.bdfXEcDmvy);
			if (召唤精怪列表类2 != null)
			{
				break;
			}
		}
		return 召唤精怪列表类2;
	}

	
	internal void NOAwxkWxnf(MyNATSocketClient P_0, ref string P_1, ref string P_2)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals20 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals20.sgVXp5j6FM = P_0;
		try
		{
			if (!(P_1 == "$提交诱饵"))
			{
				return;
			}
			CS_0024_003C_003E8__locals20.sgVXp5j6FM.user.存档数据.召唤数据.精怪召唤.Clear();
			if (!JhVwZ5yCsf())
			{
				return;
			}
			string[] array = P_2.Replace("money:0,", "").Split(",");
			if (array.Length != 10)
			{
				return;
			}
			CS_0024_003C_003E8__locals20.wFPX1Viop6 = new List<int>();
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				int[] array2 = array[i].Split(':').Select(int.Parse).ToArray();
				if (!Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals20.sgVXp5j6FM, array2[0]))
				{
					return;
				}
				if (!Singleton<ByteAPI>.I.寻找文本(xMdwA0JR7B, "|" + CS_0024_003C_003E8__locals20.sgVXp5j6FM.user.背包数据.物品列表[array2[0]].名字 + "|"))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder2);
					handler.AppendFormatted(CS_0024_003C_003E8__locals20.sgVXp5j6FM.user.背包数据.物品列表[array2[0]].名字);
					handler.AppendLiteral("、");
					stringBuilder2.Append(ref handler);
				}
				CS_0024_003C_003E8__locals20.wFPX1Viop6.Add(array2[0]);
				CS_0024_003C_003E8__locals20.sgVXp5j6FM.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals20.sgVXp5j6FM.user.背包数据.物品列表[array2[0]].封包缓存, array2[0]));
			}
			if (!string.IsNullOrWhiteSpace(stringBuilder.ToString()))
			{
				stringBuilder.Remove(stringBuilder.Length - 1, 1);
				MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals20.sgVXp5j6FM;
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你提交的#R");
				defaultInterpolatedStringHandler.AppendFormatted(stringBuilder);
				defaultInterpolatedStringHandler.AppendLiteral("#n无法召唤精怪，请重新提交。");
				myNATSocketClient.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else
			{
				for (int j = 0; j < CS_0024_003C_003E8__locals20.wFPX1Viop6.Count; j++)
				{
					CS_0024_003C_003E8__locals20.sgVXp5j6FM.user.存档数据.召唤数据.精怪召唤.Add(CS_0024_003C_003E8__locals20.sgVXp5j6FM.user.背包数据.物品列表[CS_0024_003C_003E8__locals20.wFPX1Viop6[j]].名字);
				}
				P_2 = "money:0," + array[0];
				CS_0024_003C_003E8__locals20.wFPX1Viop6.RemoveAt(0);
				CS_0024_003C_003E8__locals20.sgVXp5j6FM.召唤精怪事件 =  (string v) =>
				{
					CS_0024_003C_003E8__locals20.sgVXp5j6FM.召唤精怪事件 = null;
					CS_0024_003C_003E8__locals20.sgVXp5j6FM.S_Send(Singleton<WdAPI>.I.DN4IOFDdr5(CS_0024_003C_003E8__locals20.sgVXp5j6FM, CS_0024_003C_003E8__locals20.wFPX1Viop6.ToArray()));
				};
			}
		}
		catch (Exception ex)
		{
			Log.Error("对话请求事件处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task fpdwHejFuw(MyNATSocketClient P_0)
	{
		try
		{
			await Task.Delay(0);
			if (!JhVwZ5yCsf() || P_0.user.存档数据.召唤数据.精怪召唤.Count <= 0)
			{
				return;
			}
			for (int i = 0; i < P_0.user.存档数据.召唤数据.精怪召唤.Count; i++)
			{
				if (!Enum.TryParse<AllEnums.召唤材料Type>(P_0.user.存档数据.召唤数据.精怪召唤[i], out var result) || !Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(result, out List<召唤精怪列表类> value) || value.Count <= 0)
				{
					continue;
				}
				int num = value.Sum( (召唤精怪列表类 x) => x.获得几率);
				int num2 = Singleton<WdAPI>.I.qrjo9TWIdy(1, num);
				int num3 = 0;
				foreach (召唤精怪列表类 item in value)
				{
					num3 += item.获得几率;
					if (num2 > num3)
					{
						continue;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, item.礼包名字, AllEnums.指令Type.无, 1, false, "召唤精怪抽中");
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("恭喜你获得了一个镇压着#R" + item.镇压宠物 + "#n的锁麟囊。"));
					if (item.谣言广播)
					{
						Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
						if (client频道事件 != null)
						{
							WdAPI i2 = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 2);
							defaultInterpolatedStringHandler.AppendLiteral("恭喜#Y");
							defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n获得了镇压#G");
							defaultInterpolatedStringHandler.AppendFormatted(item.镇压宠物);
							defaultInterpolatedStringHandler.AppendLiteral("#n的灵物#R锁麟囊#n，大家快去找#Y玉真子#n进行精怪召唤吧。");
							client频道事件(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
						}
					}
					break;
				}
			}
			P_0.user.存档数据.召唤数据.精怪召唤.Clear();
		}
		catch (Exception ex)
		{
			Log.Error("召唤精怪掉落处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void ClGw4qKbEV(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			召唤精怪列表类 召唤精怪列表类2 = tMOw1LxwSn(P_1);
			if (召唤精怪列表类2 != null)
			{
				P_0.user.缓存数据.自选道具 = P_1;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(71, 7);
				defaultInterpolatedStringHandler.AppendLiteral("请选择锁麟囊中的物品：[选择精怪（");
				defaultInterpolatedStringHandler.AppendFormatted(召唤精怪列表类2.镇压宠物);
				defaultInterpolatedStringHandler.AppendLiteral("）/召唤精怪_精怪_");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("][选择银元宝（");
				defaultInterpolatedStringHandler.AppendFormatted(召唤精怪列表类2.最低银元宝);
				defaultInterpolatedStringHandler.AppendLiteral("至");
				defaultInterpolatedStringHandler.AppendFormatted(召唤精怪列表类2.最高银元宝);
				defaultInterpolatedStringHandler.AppendLiteral("）/召唤精怪_元宝_");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				string value;
				if (召唤精怪列表类2.奇宝点数 <= 0)
				{
					value = string.Empty;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(20, 2);
					defaultInterpolatedStringHandler2.AppendLiteral("[选择奇宝点数（");
					defaultInterpolatedStringHandler2.AppendFormatted(召唤精怪列表类2.奇宝点数);
					defaultInterpolatedStringHandler2.AppendLiteral("点）/召唤精怪_奇宝_");
					defaultInterpolatedStringHandler2.AppendFormatted(P_1);
					defaultInterpolatedStringHandler2.AppendLiteral("]");
					value = defaultInterpolatedStringHandler2.ToStringAndClear();
				}
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("[我在考虑考虑（返还锁麟囊）/召唤精怪_返回_");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				P_0.C_Send(i.对话生成_自己(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}
		catch (Exception ex)
		{
			Log.Error("锁麟囊自选使用处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void XyAweo0Afy(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			string empty = string.Empty;
			if (P_1.StartsWith("召唤精怪_精怪_"))
			{
				empty = P_1.Replace("召唤精怪_精怪_", string.Empty);
			}
			else if (P_1.StartsWith("召唤精怪_元宝_"))
			{
				empty = P_1.Replace("召唤精怪_元宝_", string.Empty);
			}
			else if (P_1.StartsWith("召唤精怪_奇宝_"))
			{
				empty = P_1.Replace("召唤精怪_奇宝_", string.Empty);
			}
			else
			{
				if (!P_1.StartsWith("召唤精怪_返回_"))
				{
					return;
				}
				empty = P_1.Replace("召唤精怪_返回_", string.Empty);
			}
			if (empty != P_0.user.缓存数据.自选道具 || string.IsNullOrWhiteSpace(P_0.user.缓存数据.自选道具))
			{
				return;
			}
			召唤精怪列表类 召唤精怪列表类2 = tMOw1LxwSn(empty);
			if (召唤精怪列表类2 == null)
			{
				return;
			}
			lock (P_0.自选请求锁)
			{
				if (string.IsNullOrWhiteSpace(P_0.user.缓存数据.自选道具))
				{
					return;
				}
				P_0.user.缓存数据.自选道具 = string.Empty;
				if (P_0.user.缓存数据.endNpc点击时间 != DateTime.MinValue && (DateTime.Now - P_0.user.缓存数据.endNpc点击时间).TotalMilliseconds < 1000.0)
				{
					return;
				}
				P_0.user.缓存数据.endNpc点击时间 = DateTime.Now;
				if (P_1.StartsWith("召唤精怪_精怪_"))
				{
					if (!Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.坐骑, 召唤精怪列表类2.镇压宠物, AllEnums.指令Type.无, 1, false, P_1 + "使用获得精怪"))
					{
						return;
					}
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你从锁麟囊中获得了一只#R" + 召唤精怪列表类2.镇压宠物 + "#n。"));
					if (召唤精怪列表类2.谣言广播)
					{
						Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
						if (client频道事件 != null)
						{
							WdAPI i = Singleton<WdAPI>.I;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 2);
							defaultInterpolatedStringHandler.AppendLiteral("恭喜#Y");
							defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n在#R锁麟囊#n中召唤出了一只#G");
							defaultInterpolatedStringHandler.AppendFormatted(召唤精怪列表类2.镇压宠物);
							defaultInterpolatedStringHandler.AppendLiteral("#n，大家快去找#Y玉真子#n进行精怪召唤吧。");
							client频道事件(i.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
						}
					}
				}
				else if (P_1.StartsWith("召唤精怪_元宝_"))
				{
					int num = Singleton<WdAPI>.I.qrjo9TWIdy((召唤精怪列表类2.最低银元宝 < 召唤精怪列表类2.平均银元宝) ? 召唤精怪列表类2.平均银元宝 : 召唤精怪列表类2.最低银元宝, 召唤精怪列表类2.最高银元宝);
					if (!Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.银元宝, string.Empty, AllEnums.指令Type.无, num, false, P_1 + "使用获得元宝"))
					{
						return;
					}
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你从锁麟囊中获得了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n银元宝。");
					P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					if (召唤精怪列表类2.谣言广播)
					{
						Action<byte[]> client频道事件2 = Singleton<全局变量类>.I.Client频道事件;
						if (client频道事件2 != null)
						{
							WdAPI i3 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 2);
							defaultInterpolatedStringHandler.AppendLiteral("恭喜#Y");
							defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n在#R锁麟囊#n中获得了#R");
							defaultInterpolatedStringHandler.AppendFormatted(num);
							defaultInterpolatedStringHandler.AppendLiteral("#n银元宝，大家快去找#Y玉真子#n进行精怪召唤吧。");
							client频道事件2(i3.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
						}
					}
				}
				else if (P_1.StartsWith("召唤精怪_奇宝_"))
				{
					if (召唤精怪列表类2.奇宝点数 <= 0 || !Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, 召唤精怪列表类2.奇宝点数, false, P_1 + "使用获得奇宝点数"))
					{
						return;
					}
					WdAPI i4 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你从锁麟囊中获得了#R");
					defaultInterpolatedStringHandler.AppendFormatted(召唤精怪列表类2.奇宝点数);
					defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点。");
					P_0.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					if (召唤精怪列表类2.谣言广播)
					{
						Action<byte[]> client频道事件3 = Singleton<全局变量类>.I.Client频道事件;
						if (client频道事件3 != null)
						{
							WdAPI i5 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 2);
							defaultInterpolatedStringHandler.AppendLiteral("恭喜#Y");
							defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n在#R锁麟囊#n中获得了#R");
							defaultInterpolatedStringHandler.AppendFormatted(召唤精怪列表类2.奇宝点数);
							defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点，大家快去找#Y玉真子#n进行精怪召唤吧。");
							client频道事件3(i5.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
						}
					}
				}
				else if (P_1.StartsWith("召唤精怪_返回_"))
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 召唤精怪列表类2.礼包名字, AllEnums.指令Type.无, 1, false, P_1 + "取消使用");
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("锁麟囊自选请求处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void wH8wqOhv93(MyNATSocketClient P_0)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals13 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals13.aFHX0SCC7v = P_0;
		try
		{
			CS_0024_003C_003E8__locals13.x4DXOtQ8wE = CS_0024_003C_003E8__locals13.aFHX0SCC7v.user.宠物数据.ToList().FindIndex( (宠物缓存数据类 x) => x.宠物ID == 0);
			if (CS_0024_003C_003E8__locals13.x4DXOtQ8wE < 0)
			{
				return;
			}
			CS_0024_003C_003E8__locals13.aFHX0SCC7v.召唤精怪事件 =  async (string v) =>
			{
				CS_0024_003C_003E8__locals13.aFHX0SCC7v.召唤精怪事件 = null;
				if (!(CS_0024_003C_003E8__locals13.aFHX0SCC7v.user.宠物数据[CS_0024_003C_003E8__locals13.x4DXOtQ8wE].昵称B != v))
				{
					int 宠物ID = CS_0024_003C_003E8__locals13.aFHX0SCC7v.user.宠物数据[CS_0024_003C_003E8__locals13.x4DXOtQ8wE].宠物ID;
					do
					{
						await Task.Delay(2000);
						if (!CS_0024_003C_003E8__locals13.aFHX0SCC7v.user.缓存数据.is战斗中)
						{
							CS_0024_003C_003E8__locals13.aFHX0SCC7v.S_Send(Singleton<WdAPI>.I.FdioldHrOI(宠物ID));
							break;
						}
						await Task.Delay(1);
					}
					while (CS_0024_003C_003E8__locals13.aFHX0SCC7v.user.缓存数据.is战斗中);
				}
			};
		}
		catch (Exception ex)
		{
			Log.Error("请求战斗处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task g4XwraLKfV(MyNATSocketClient P_0)
	{
		while (P_0.user.缓存数据.is战斗中)
		{
			await Task.Delay(10);
		}
		fpdwHejFuw(P_0);
	}

	
	public FcVoHRwOVsflDmDUQOP()
	{
	}

	
	static FcVoHRwOVsflDmDUQOP()
	{
		xMdwA0JR7B = "|珊瑚|还阳露|醉仙酒|五彩香|仙露草|百草集|凝香草|醒狮丹|鱼仙饵|猿兽丹|菩提子|御仙饮|";
	}
}
