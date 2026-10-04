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

namespace eYLrotRIovAGM9lAtVf;

internal class AZI1HsR8MjRfegmETY5 : Singleton<AZI1HsR8MjRfegmETY5>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public string W6vLMK3ABm;

		
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		
		internal bool WHcL5ZOlMJ(宠物缓存数据类 x)
		{
			return x.IID == W6vLMK3ABm;
		}

		static _003C_003Ec__DisplayClass10_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public int JVdLvFuga8;

		
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		
		internal bool iMlLh7fWRZ(宠物缓存数据类 a)
		{
			if (a.宠物ID != 0)
			{
				return a.PetID == JVdLvFuga8;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass12_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public int PFvLaGpX06;

		public string QVGLTDFMTy;

		public MyNATSocketClient ScyL9cpwkZ;

		public AZI1HsR8MjRfegmETY5 WSSLyjBvV6;

		
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		
		internal bool LHXL7hOBAV(宠物缓存数据类 a)
		{
			if (a.宠物ID != 0)
			{
				return a.PetID == PFvLaGpX06;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass13_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_1
	{
		public int sEeLVrPhwx;

		public 宠物缓存数据类 iyjLk2RX2g;

		public 宠物存档数据类 KXcL0nuwV7;

		public double mJlLONvyCH;

		public bool dcILQAJ56Q;

		public 宠物转生列表类 uXALE4lLan;

		public _003C_003Ec__DisplayClass13_0 W95L3eD97T;

		
		public _003C_003Ec__DisplayClass13_1()
		{
		}

		
		internal void AYwLC7aTvV(string v)
		{
			if (!(v != W95L3eD97T.QVGLTDFMTy))
			{
				W95L3eD97T.ScyL9cpwkZ.销毁回调事件 = null;
				MyNATSocketClient myNATSocketClient = W95L3eD97T.ScyL9cpwkZ;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(sEeLVrPhwx);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(W95L3eD97T.QVGLTDFMTy);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				MyNATSocketClient myNATSocketClient2 = W95L3eD97T.ScyL9cpwkZ;
				WdAPI i2 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 4);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(iyjLk2RX2g.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n的第#R");
				defaultInterpolatedStringHandler.AppendFormatted(KXcL0nuwV7.转生数据.转生次数 + 1);
				defaultInterpolatedStringHandler.AppendLiteral("#n转生进度提升了#R");
				defaultInterpolatedStringHandler.AppendFormatted(mJlLONvyCH, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n，当前转生进度为#R");
				defaultInterpolatedStringHandler.AppendFormatted(mJlLONvyCH * (double)KXcL0nuwV7.转生数据.道具数量, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n。");
				myNATSocketClient2.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				if (dcILQAJ56Q)
				{
					KXcL0nuwV7.转生数据.道具数量 = 0;
					W95L3eD97T.WSSLyjBvV6.haLRP4KmAL(W95L3eD97T.ScyL9cpwkZ, iyjLk2RX2g, KXcL0nuwV7, uXALE4lLan);
				}
				else
				{
					KXcL0nuwV7.转生数据.道具数量 += sEeLVrPhwx;
				}
			}
		}

		static _003C_003Ec__DisplayClass13_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public int HrmLpDymBC;

		
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		
		internal bool wnHLYYOx8K(MyNATSocketClient x)
		{
			return x.user.人物数据.GID == HrmLpDymBC;
		}

		static _003C_003Ec__DisplayClass14_0()
		{
		}
	}

	internal byte[] pIKRLuww7H;

	internal static StringBuilder fZ1RSIDoZn;

	
	[SpecialName]
	internal static bool zmURXpEr61()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.IsVip)
		{
			return Singleton<全局变量类>.I.宠物转生配置.功能开关;
		}
		return false;
	}

	
	internal void I0FRodI0W1()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物转生配置类.json")))
			{
				Singleton<全局变量类>.I.宠物转生配置 = JsonConvert.DeserializeObject<宠物转生配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物转生配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.宠物转生配置 = new 宠物转生配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物转生配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物转生配置, Formatting.Indented));
			}
			fZ1RSIDoZn.Clear();
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.宠物转生配置.转生洗髓道具))
			{
				StringBuilder stringBuilder = fZ1RSIDoZn;
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder);
				handler.AppendLiteral("|");
				handler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.转生洗髓道具);
				stringBuilder2.Append(ref handler);
			}
			for (int i = 0; i < Singleton<全局变量类>.I.宠物转生配置.转生阶段.Count; i++)
			{
				StringBuilder stringBuilder = fZ1RSIDoZn;
				StringBuilder stringBuilder3 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder);
				handler.AppendLiteral("|");
				handler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].转生道具名字);
				stringBuilder3.Append(ref handler);
			}
			fZ1RSIDoZn.Append("|");
			giVRGEK2SH();
		}
		catch (Exception ex)
		{
			Log.Error("宠物转生配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void UvtRNqMOnA()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("宠物转生配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物转生配置, Formatting.Indented));
			Log.Debug("宠物转生配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("宠物转生配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string aZCRi5ea9K()
	{
		I0FRodI0W1();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物转生配置, Formatting.Indented);
	}

	
	public void OC6RBQnEQA(string P_0)
	{
		Singleton<全局变量类>.I.宠物转生配置 = JsonConvert.DeserializeObject<宠物转生配置类>(P_0);
		UvtRNqMOnA();
	}

	
	public void giVRGEK2SH()
	{
		pIKRLuww7H = (Singleton<全局变量类>.I.宠物转生配置.功能开关 ? Singleton<WdAPI>.I.组包假NPC站街(Singleton<全局变量类>.I.宠物转生配置.NPC数据, 110) : Array.Empty<byte>());
	}

	
	internal void aKnRf5NpSf(MyNATSocketClient P_0)
	{
		try
		{
			if (zmURXpEr61() && !P_0.user.缓存数据.is使用仙灵卡)
			{
				StringBuilder stringBuilder = new StringBuilder(Singleton<全局变量类>.I.宠物转生配置.NPC数据.对话文本);
				stringBuilder.Append("[【宠物转生】详情介绍/转生操作_宠物详情][【宠物转生】选择宠物/转生操作_宠物转生]");
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.宠物转生配置.NPC数据.npcid, Singleton<全局变量类>.I.宠物转生配置.NPC数据.npc形象, Singleton<全局变量类>.I.宠物转生配置.NPC数据.npc名字, stringBuilder.ToString()));
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("NPC对话生成-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void bWjR6H4yeP(MyNATSocketClient P_0, string P_1, string P_2)
	{
		try
		{
			if (!zmURXpEr61() || P_0.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			if (P_1 == "转生操作_宠物详情")
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(68, 1, stringBuilder2);
				handler.AppendLiteral("宠物最大转生上限#R");
				handler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.宠物最大转生次数);
				handler.AppendLiteral("#n转，宠物每次转生需求的属性要求可能大不不同，达到了要求的宠物可在此处开启转生任务，达到条件以后即可完成转生任务。");
				stringBuilder3.Append(ref handler);
				for (int i = 0; i < Singleton<全局变量类>.I.宠物转生配置.转生阶段.Count; i++)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(22, 6, stringBuilder2);
					handler.AppendLiteral("#r#Y");
					handler.AppendFormatted(i + 1);
					handler.AppendLiteral("转：#n");
					string value;
					if (Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].开启转生等级要求 <= 0)
					{
						value = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
						defaultInterpolatedStringHandler.AppendLiteral("#n等级#R≥");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].开启转生等级要求);
						defaultInterpolatedStringHandler.AppendLiteral("#n级 ");
						value = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value);
					string value2;
					if (Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].开启转生武学要求 <= 0)
					{
						value2 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
						defaultInterpolatedStringHandler.AppendLiteral("武学#R≥");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].开启转生武学要求);
						defaultInterpolatedStringHandler.AppendLiteral("#n点");
						value2 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value2);
					handler.AppendLiteral("宠物可喂食#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].转生道具名字);
					handler.AppendLiteral("#n提升进度 ");
					string value3;
					if (Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].各项成长提升 <= 0)
					{
						value3 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
						defaultInterpolatedStringHandler.AppendLiteral("转生后宠物的各项成长提升#O");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].各项成长提升);
						defaultInterpolatedStringHandler.AppendLiteral("%#n，");
						value3 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value3);
					string value4;
					if (string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].转生技能名字))
					{
						value4 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
						defaultInterpolatedStringHandler.AppendLiteral("并且有#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].获得技能几率);
						defaultInterpolatedStringHandler.AppendLiteral("%#n几率获得转生专属技能#G");
						string value5;
						if (string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].转生力系技能) || !(Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].转生力系技能 != Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].转生技能名字))
						{
							value5 = Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].转生技能名字 + ".";
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 2);
							defaultInterpolatedStringHandler2.AppendLiteral("(");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].转生技能名字);
							defaultInterpolatedStringHandler2.AppendLiteral(" 或 ");
							defaultInterpolatedStringHandler2.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].转生力系技能);
							defaultInterpolatedStringHandler2.AppendLiteral(")");
							value5 = defaultInterpolatedStringHandler2.ToStringAndClear();
						}
						defaultInterpolatedStringHandler.AppendFormatted(value5);
						defaultInterpolatedStringHandler.AppendLiteral("Lv");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.转生阶段[i].转生技能等级);
						defaultInterpolatedStringHandler.AppendLiteral("#n");
						value4 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value4);
					stringBuilder4.Append(ref handler);
					if (i >= Singleton<全局变量类>.I.宠物转生配置.转生阶段.Count - 1)
					{
						stringBuilder.Append("#r等等");
						break;
					}
				}
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.宠物转生配置.NPC数据.npcid, Singleton<全局变量类>.I.宠物转生配置.NPC数据.npc形象, Singleton<全局变量类>.I.宠物转生配置.NPC数据.npc名字, stringBuilder.ToString()));
			}
			else
			{
				if (Singleton<全局变量类>.I.宠物转生配置.宠物最大转生次数 <= 0 || Singleton<全局变量类>.I.宠物转生配置.转生阶段.Count <= 0)
				{
					return;
				}
				if (P_1 == "转生操作_宠物转生")
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(25, 1, stringBuilder2);
					handler.AppendLiteral("宠物转生上限为#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.宠物最大转生次数);
					handler.AppendLiteral("#n转，请选择要开启转生的宠物。");
					stringBuilder5.Append(ref handler);
					int num = 0;
					for (int j = 0; j < P_0.user.宠物数据.Length; j++)
					{
						if (!string.IsNullOrWhiteSpace(P_0.user.宠物数据[j].IID))
						{
							if (!Singleton<全局变量类>.I.宠物存档表.TryGetValue(P_0.user.宠物数据[j].IID, out var value6))
							{
								value6 = new 宠物存档数据类
								{
									IID = P_0.user.宠物数据[j].IID
								};
								Singleton<全局变量类>.I.宠物存档表.TryAdd(P_0.user.宠物数据[j].IID, value6);
								DB.I.irWib79NaP(P_0.user.宠物数据[j].IID, value6);
							}
							if (!value6.转生数据.Is开启)
							{
								num++;
								stringBuilder2 = stringBuilder;
								StringBuilder stringBuilder6 = stringBuilder2;
								handler = new StringBuilder.AppendInterpolatedStringHandler(25, 6, stringBuilder2);
								handler.AppendLiteral("[");
								handler.AppendFormatted(num);
								handler.AppendLiteral(".");
								handler.AppendFormatted(P_0.user.宠物数据[j].昵称A);
								handler.AppendLiteral("(");
								handler.AppendFormatted(value6.转生数据.转生次数);
								handler.AppendLiteral("转)       - ");
								handler.AppendFormatted(P_0.user.宠物数据[j].等级);
								handler.AppendLiteral("级 ");
								handler.AppendFormatted(P_0.user.宠物数据[j].昵称B);
								handler.AppendLiteral("/转生操作_选择");
								handler.AppendFormatted(P_0.user.宠物数据[j].IID);
								handler.AppendLiteral("]");
								stringBuilder6.Append(ref handler);
							}
						}
					}
					P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.宠物转生配置.NPC数据.npcid, Singleton<全局变量类>.I.宠物转生配置.NPC数据.npc形象, Singleton<全局变量类>.I.宠物转生配置.NPC数据.npc名字, stringBuilder.ToString()));
				}
				else if (P_1.Contains("转生操作_选择", StringComparison.CurrentCulture))
				{
					_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass10_0();
					CS_0024_003C_003E8__locals5.W6vLMK3ABm = P_1.Replace("转生操作_选择", string.Empty);
					宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.Find( (宠物缓存数据类 x) => x.IID == CS_0024_003C_003E8__locals5.W6vLMK3ABm);
					if (宠物缓存数据类2 == null)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("宠物不存在，无法开启转生！"));
						return;
					}
					if (!Singleton<全局变量类>.I.宠物存档表.TryGetValue(CS_0024_003C_003E8__locals5.W6vLMK3ABm, out var value7))
					{
						value7 = new 宠物存档数据类
						{
							IID = CS_0024_003C_003E8__locals5.W6vLMK3ABm,
							转生数据 = new 宠物转生数据类
							{
								转生次数 = 0,
								道具数量 = 0
							}
						};
						Singleton<全局变量类>.I.宠物存档表.TryAdd(CS_0024_003C_003E8__locals5.W6vLMK3ABm, value7);
					}
					if (value7.转生数据.Is开启)
					{
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
						defaultInterpolatedStringHandler.AppendLiteral("#Y");
						defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n已经开启了第#R");
						defaultInterpolatedStringHandler.AppendFormatted(value7.转生数据.转生次数 + 1);
						defaultInterpolatedStringHandler.AppendLiteral("#n次的转生，请先完成本次转生才行。");
						P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					else if (value7.转生数据.转生次数 >= Singleton<全局变量类>.I.宠物转生配置.宠物最大转生次数)
					{
						WdAPI i3 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
						defaultInterpolatedStringHandler.AppendLiteral("#Y");
						defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n的转生次数已经达到了#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.宠物最大转生次数);
						defaultInterpolatedStringHandler.AppendLiteral("#n次，无法继续进行转生操作了。");
						P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					else if (Singleton<全局变量类>.I.宠物转生配置.转生阶段[value7.转生数据.转生次数].开启转生等级要求 > 宠物缓存数据类2.等级)
					{
						WdAPI i4 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
						defaultInterpolatedStringHandler.AppendLiteral("#Y");
						defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n的等级未达到#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.转生阶段[value7.转生数据.转生次数].开启转生等级要求);
						defaultInterpolatedStringHandler.AppendLiteral("#n级，无法开启当前转生。");
						P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					else if (Singleton<全局变量类>.I.宠物转生配置.转生阶段[value7.转生数据.转生次数].开启转生武学要求 > 宠物缓存数据类2.武学)
					{
						WdAPI i5 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
						defaultInterpolatedStringHandler.AppendLiteral("#Y");
						defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n的武学未达到#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.转生阶段[value7.转生数据.转生次数].开启转生武学要求);
						defaultInterpolatedStringHandler.AppendLiteral("#n点，无法开启当前转生。");
						P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					else
					{
						value7.转生数据.Is开启 = true;
						value7.转生数据.道具数量 = 0;
						WdAPI i6 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
						defaultInterpolatedStringHandler.AppendLiteral("#Y");
						defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n的第#R");
						defaultInterpolatedStringHandler.AppendFormatted(value7.转生数据.转生次数 + 1);
						defaultInterpolatedStringHandler.AppendLiteral("#n次转生开启成功，当前转生进度为#R0.00%#n。");
						P_0.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
				}
				else if (P_1.Contains("转生操作_使用_", StringComparison.CurrentCulture))
				{
					TKER2juskP(P_0, P_1.Replace("转生操作_使用_", string.Empty));
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("宠物转生对话处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void TKER2juskP(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (!zmURXpEr61())
			{
				return;
			}
			string[] array = P_1.Split("|");
			if (array.Length == 2 && int.TryParse(array[0], out var result) && int.TryParse(array[1], out var result2) && P_0.user.背包数据.物品列表[result2].物品ID != 0 && P_0.user.背包数据.物品列表[result2].数量 > 0)
			{
				string 名字 = P_0.user.背包数据.物品列表[result2].名字;
				if (Singleton<全局变量类>.I.宠物转生配置.转生洗髓道具 == 名字)
				{
					宠物转生洗髓处理(P_0, result, result2, 名字);
				}
				else
				{
					DZORmwf8yX(P_0, result, result2, 名字);
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("宠物转生使用处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal async Task 宠物转生洗髓处理(MyNATSocketClient myclient, int 宠物位置, int 道具格子, string 使用道具名字)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals3.JVdLvFuga8 = 宠物位置;
		try
		{
			if (!zmURXpEr61())
			{
				return;
			}
			宠物缓存数据类 当前宠物 = myclient.user.宠物数据.Find( (宠物缓存数据类 a) => a.宠物ID != 0 && a.PetID == CS_0024_003C_003E8__locals3.JVdLvFuga8);
			if (当前宠物 == null)
			{
				return;
			}
			if (!Singleton<全局变量类>.I.宠物存档表.TryGetValue(当前宠物.IID, out var value))
			{
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(当前宠物.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n并没有开启转生，无法使用#R");
				defaultInterpolatedStringHandler.AppendFormatted(使用道具名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				myclient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (value.转生数据.转生次数 <= 0)
			{
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(当前宠物.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n1次转生都没有成功，无法使用#R");
				defaultInterpolatedStringHandler.AppendFormatted(使用道具名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				myclient.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			int num = ((value.转生数据.转生次数 > Singleton<全局变量类>.I.宠物转生配置.转生阶段.Count) ? Singleton<全局变量类>.I.宠物转生配置.转生阶段.Count : value.转生数据.转生次数);
			List<string[]> 可用技能列表 = new List<string[]>();
			for (int num2 = 0; num2 < num; num2++)
			{
				if (当前宠物.相性 == 0)
				{
					if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.宠物转生配置.转生阶段[num2].转生力系技能) && Singleton<全局变量类>.I.宠物转生配置.转生阶段[num2].转生技能等级 > 0)
					{
						可用技能列表.Add(new string[3]
						{
							Singleton<全局变量类>.I.宠物转生配置.转生阶段[num2].转生力系技能,
							Singleton<全局变量类>.I.宠物转生配置.转生阶段[num2].转生技能等级.ToString(),
							Singleton<全局变量类>.I.宠物转生配置.转生阶段[num2].技能最大等级.ToString()
						});
					}
				}
				else if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.宠物转生配置.转生阶段[num2].转生技能名字) && Singleton<全局变量类>.I.宠物转生配置.转生阶段[num2].转生技能等级 > 0)
				{
					可用技能列表.Add(new string[3]
					{
						Singleton<全局变量类>.I.宠物转生配置.转生阶段[num2].转生技能名字,
						Singleton<全局变量类>.I.宠物转生配置.转生阶段[num2].转生技能等级.ToString(),
						Singleton<全局变量类>.I.宠物转生配置.转生阶段[num2].技能最大等级.ToString()
					});
				}
			}
			if (可用技能列表.Count <= 0)
			{
				WdAPI i3 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(当前宠物.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n并没有可以通过洗髓获得的转生技能，无法使用#R");
				defaultInterpolatedStringHandler.AppendFormatted(使用道具名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				myclient.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			int 最多次数 = Math.Min(100, myclient.user.背包数据.物品列表[道具格子].数量);
			_ = new string[3];
			int value2 = 0;
			int result = 0;
			int result2 = 0;
			for (int i4 = 0; i4 < 最多次数; i4++)
			{
				if (myclient.user.背包数据.物品列表[道具格子].数量 <= 0)
				{
					break;
				}
				myclient.user.背包数据.物品列表[道具格子].数量--;
				await myclient.S_Send异步(Singleton<WdAPI>.I.ruAoIqjP2a(CS_0024_003C_003E8__locals3.JVdLvFuga8, 道具格子), "宠物转生洗髓处理");
				int num3 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 10000);
				if (Singleton<全局变量类>.I.宠物转生配置.转生洗髓几率 < num3)
				{
					myclient.C_Send(Singleton<WdAPI>.I.提示_杂项公告("很遗憾，#R" + 当前宠物.昵称A + "#n洗髓失败，并没有洗出新的的转生技能。"));
					continue;
				}
				string[] array = 可用技能列表[Singleton<WdAPI>.I.qrjo9TWIdy(0, 可用技能列表.Count - 1)];
				if (!问道数据类.所有技能ID.ContainsKey(array[0]))
				{
					myclient.C_Send(Singleton<WdAPI>.I.提示_杂项公告("很遗憾，#R" + 当前宠物.昵称A + "#n洗髓失败，并没有洗出新的的转生技能。"));
				}
				else if (int.TryParse(array[1], out result) && int.TryParse(array[2], out result2))
				{
					if (当前宠物.技能列表.TryGetValue(array[0], out value2))
					{
						if (value2 >= result2)
						{
							myclient.C_Send(Singleton<WdAPI>.I.提示_杂项公告("很遗憾，#R" + 当前宠物.昵称A + "#n洗髓失败，并没有洗出新的的转生技能。"));
							continue;
						}
						num3 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
						if (num3 < 30)
						{
							myclient.C_Send(Singleton<WdAPI>.I.提示_杂项公告("很遗憾，#R" + 当前宠物.昵称A + "#n洗髓失败，并没有洗出新的的转生技能。"));
							continue;
						}
						value2++;
						Singleton<WdAPI>.I.W9lI1TZlUs(myclient, myclient.user.人物数据.昵称, 当前宠物.宠物ID.ToString(), $"{问道数据类.所有技能ID[array[0]]}", $"{value2}");
						WdAPI i5 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你，#R");
						defaultInterpolatedStringHandler.AppendFormatted(当前宠物.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n洗髓成功，#G");
						defaultInterpolatedStringHandler.AppendFormatted(array[0]);
						defaultInterpolatedStringHandler.AppendLiteral("#n转生技能等级 + #Y1#n。");
						myclient.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						await Task.Delay(50);
					}
					else
					{
						Singleton<WdAPI>.I.W9lI1TZlUs(myclient, myclient.user.人物数据.昵称, 当前宠物.宠物ID.ToString(), $"{问道数据类.所有技能ID[array[0]]}", $"{result}");
						WdAPI i6 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你，#R");
						defaultInterpolatedStringHandler.AppendFormatted(当前宠物.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n洗髓成功，获得了#G");
						defaultInterpolatedStringHandler.AppendFormatted(array[0]);
						defaultInterpolatedStringHandler.AppendLiteral("#n转生技能。");
						myclient.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						await Task.Delay(50);
					}
				}
				else
				{
					myclient.C_Send(Singleton<WdAPI>.I.提示_杂项公告("很遗憾，#R" + 当前宠物.昵称A + "#n洗髓失败，并没有洗出新的的转生技能。"));
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("宠物转生洗髓处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void DZORmwf8yX(MyNATSocketClient P_0, int P_1, int P_2, string P_3)
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_2 = new _003C_003Ec__DisplayClass13_0();
		_003C_003Ec__DisplayClass13_2.PFvLaGpX06 = P_1;
		_003C_003Ec__DisplayClass13_2.QVGLTDFMTy = P_3;
		_003C_003Ec__DisplayClass13_2.ScyL9cpwkZ = P_0;
		_003C_003Ec__DisplayClass13_2.WSSLyjBvV6 = this;
		try
		{
			_003C_003Ec__DisplayClass13_1 CS_0024_003C_003E8__locals74 = new _003C_003Ec__DisplayClass13_1();
			CS_0024_003C_003E8__locals74.W95L3eD97T = _003C_003Ec__DisplayClass13_2;
			CS_0024_003C_003E8__locals74.iyjLk2RX2g = CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ.user.宠物数据.Find( (宠物缓存数据类 a) => a.宠物ID != 0 && a.PetID == CS_0024_003C_003E8__locals74.W95L3eD97T.PFvLaGpX06);
			if (CS_0024_003C_003E8__locals74.iyjLk2RX2g == null)
			{
				return;
			}
			if (!Singleton<全局变量类>.I.宠物存档表.TryGetValue(CS_0024_003C_003E8__locals74.iyjLk2RX2g.IID, out CS_0024_003C_003E8__locals74.KXcL0nuwV7))
			{
				MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals74.iyjLk2RX2g.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n并没有开启转生，无法使用#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals74.W95L3eD97T.QVGLTDFMTy);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (!CS_0024_003C_003E8__locals74.KXcL0nuwV7.转生数据.Is开启)
			{
				MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ;
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals74.iyjLk2RX2g.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n并没有开启转生，无法使用#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals74.W95L3eD97T.QVGLTDFMTy);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				myNATSocketClient2.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (CS_0024_003C_003E8__locals74.KXcL0nuwV7.转生数据.转生次数 >= Singleton<全局变量类>.I.宠物转生配置.转生阶段.Count)
			{
				MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ;
				WdAPI i3 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals74.iyjLk2RX2g.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n的转生次数已经达到了#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.宠物最大转生次数);
				defaultInterpolatedStringHandler.AppendLiteral("#n次，无法继续进行转生操作了。");
				myNATSocketClient3.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			CS_0024_003C_003E8__locals74.uXALE4lLan = Singleton<全局变量类>.I.宠物转生配置.转生阶段[CS_0024_003C_003E8__locals74.KXcL0nuwV7.转生数据.转生次数];
			if (CS_0024_003C_003E8__locals74.uXALE4lLan.转生道具名字 != CS_0024_003C_003E8__locals74.W95L3eD97T.QVGLTDFMTy)
			{
				MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ;
				WdAPI i4 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals74.W95L3eD97T.QVGLTDFMTy);
				defaultInterpolatedStringHandler.AppendLiteral("#n不符合#n");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals74.iyjLk2RX2g.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n提升当前转生进度所需的道具，无法继续提升转生进度。");
				myNATSocketClient4.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (CS_0024_003C_003E8__locals74.KXcL0nuwV7.转生数据.道具数量 >= CS_0024_003C_003E8__locals74.uXALE4lLan.转生道具数量)
			{
				CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + CS_0024_003C_003E8__locals74.iyjLk2RX2g.昵称A + "#n的转生进度已经达到了#R100%#n，无法继续提升转生进度。"));
				return;
			}
			if (CS_0024_003C_003E8__locals74.iyjLk2RX2g.等级 < CS_0024_003C_003E8__locals74.uXALE4lLan.开启转生等级要求)
			{
				MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ;
				WdAPI i5 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals74.iyjLk2RX2g.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n的等级不足#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals74.uXALE4lLan.开启转生等级要求);
				defaultInterpolatedStringHandler.AppendLiteral("#n级，无法继续提升转生进度。");
				myNATSocketClient5.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (CS_0024_003C_003E8__locals74.iyjLk2RX2g.武学 < CS_0024_003C_003E8__locals74.uXALE4lLan.开启转生武学要求)
			{
				MyNATSocketClient myNATSocketClient6 = CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ;
				WdAPI i6 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals74.iyjLk2RX2g.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n的武学不足#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals74.uXALE4lLan.开启转生武学要求);
				defaultInterpolatedStringHandler.AppendLiteral("#n点，无法继续提升转生进度。");
				myNATSocketClient6.C_Send(i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			CS_0024_003C_003E8__locals74.mJlLONvyCH = 100.0 / (double)CS_0024_003C_003E8__locals74.uXALE4lLan.转生道具数量;
			int 数量 = CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ.user.背包数据.物品列表[P_2].数量;
			CS_0024_003C_003E8__locals74.sEeLVrPhwx = 0;
			CS_0024_003C_003E8__locals74.dcILQAJ56Q = false;
			for (int num = 0; num < 数量; num++)
			{
				CS_0024_003C_003E8__locals74.sEeLVrPhwx++;
				if (CS_0024_003C_003E8__locals74.KXcL0nuwV7.转生数据.道具数量 + CS_0024_003C_003E8__locals74.sEeLVrPhwx >= CS_0024_003C_003E8__locals74.uXALE4lLan.转生道具数量)
				{
					CS_0024_003C_003E8__locals74.dcILQAJ56Q = true;
					break;
				}
			}
			CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ.销毁回调事件 =  (string v) =>
			{
				if (!(v != CS_0024_003C_003E8__locals74.W95L3eD97T.QVGLTDFMTy))
				{
					CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ.销毁回调事件 = null;
					MyNATSocketClient myNATSocketClient7 = CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ;
					WdAPI i7 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(14, 2);
					defaultInterpolatedStringHandler2.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals74.sEeLVrPhwx);
					defaultInterpolatedStringHandler2.AppendLiteral("#n个#R");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals74.W95L3eD97T.QVGLTDFMTy);
					defaultInterpolatedStringHandler2.AppendLiteral("#n。");
					myNATSocketClient7.C_Send(i7.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
					MyNATSocketClient myNATSocketClient8 = CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ;
					WdAPI i8 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(36, 4);
					defaultInterpolatedStringHandler2.AppendLiteral("#Y");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals74.iyjLk2RX2g.昵称A);
					defaultInterpolatedStringHandler2.AppendLiteral("#n的第#R");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals74.KXcL0nuwV7.转生数据.转生次数 + 1);
					defaultInterpolatedStringHandler2.AppendLiteral("#n转生进度提升了#R");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals74.mJlLONvyCH, "F2");
					defaultInterpolatedStringHandler2.AppendLiteral("%#n，当前转生进度为#R");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals74.mJlLONvyCH * (double)CS_0024_003C_003E8__locals74.KXcL0nuwV7.转生数据.道具数量, "F2");
					defaultInterpolatedStringHandler2.AppendLiteral("%#n。");
					myNATSocketClient8.C_Send(i8.提示_杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
					if (CS_0024_003C_003E8__locals74.dcILQAJ56Q)
					{
						CS_0024_003C_003E8__locals74.KXcL0nuwV7.转生数据.道具数量 = 0;
						CS_0024_003C_003E8__locals74.W95L3eD97T.WSSLyjBvV6.haLRP4KmAL(CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ, CS_0024_003C_003E8__locals74.iyjLk2RX2g, CS_0024_003C_003E8__locals74.KXcL0nuwV7, CS_0024_003C_003E8__locals74.uXALE4lLan);
					}
					else
					{
						CS_0024_003C_003E8__locals74.KXcL0nuwV7.转生数据.道具数量 += CS_0024_003C_003E8__locals74.sEeLVrPhwx;
					}
				}
			};
			if (CS_0024_003C_003E8__locals74.sEeLVrPhwx >= 数量)
			{
				CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ.S_Send(Singleton<WdAPI>.I.CxWI0uMCPh(CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ, P_2));
			}
			else
			{
				CS_0024_003C_003E8__locals74.W95L3eD97T.ScyL9cpwkZ.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(P_2, CS_0024_003C_003E8__locals74.sEeLVrPhwx));
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("宠物转生进度处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal async Task haLRP4KmAL(MyNATSocketClient P_0, 宠物缓存数据类 P_1, 宠物存档数据类 P_2, 宠物转生列表类 P_3)
	{
		_ = 6;
		try
		{
			if (!zmURXpEr61())
			{
				return;
			}
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler.AppendLiteral("第");
			defaultInterpolatedStringHandler.AppendFormatted(P_2.转生数据.转生次数 + 1);
			defaultInterpolatedStringHandler.AppendLiteral("次转生即将完成");
			P_0.C_Send(i.QewoEwLLTD(defaultInterpolatedStringHandler.ToStringAndClear(), 3));
			await Task.Delay(3000);
			WdAPI i2 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
			defaultInterpolatedStringHandler.AppendLiteral("#G恭喜，#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_1.昵称A);
			defaultInterpolatedStringHandler.AppendLiteral("#G的第#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_2.转生数据.转生次数 + 1);
			defaultInterpolatedStringHandler.AppendLiteral("#G次转生成功。");
			byte[] first = i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear());
			WdAPI i3 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
			defaultInterpolatedStringHandler.AppendLiteral("#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_1.昵称A);
			defaultInterpolatedStringHandler.AppendLiteral("#n的第#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_2.转生数据.转生次数 + 1);
			defaultInterpolatedStringHandler.AppendLiteral("#n次转生进度达到了#R100.00%#n。");
			P_0.C_Send(first.Concat(i3.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
			if (P_3.Is重置等级)
			{
				Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_1.宠物ID.ToString(), $"{AllEnums.指令Type.exp}", $"{P_3.结束重置等级}", "admin_set_attrib");
				Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_1.宠物ID.ToString(), $"{AllEnums.指令Type.level}", $"{P_3.结束重置等级}", "admin_set_attrib");
				WdAPI i4 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n的等级已经重置到#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_3.结束重置等级);
				defaultInterpolatedStringHandler.AppendLiteral("#n级。");
				P_0.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			if (P_3.Is重置武学)
			{
				Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_1.宠物ID.ToString(), "martial", $"{P_3.结束重置武学}", "admin_set_attrib");
				WdAPI i5 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n的武学已经重置到#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_3.结束重置武学);
				defaultInterpolatedStringHandler.AppendLiteral("#n点。");
				P_0.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			if (P_1.相性 == 0 && !string.IsNullOrWhiteSpace(P_3.转生力系技能) && P_3.转生技能等级 > 0)
			{
				int num = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				if (P_3.获得技能几率 >= num && 问道数据类.所有技能ID.ContainsKey(P_3.转生力系技能))
				{
					Singleton<WdAPI>.I.W9lI1TZlUs(P_0, P_0.user.人物数据.昵称, P_1.宠物ID.ToString(), $"{问道数据类.所有技能ID[P_3.转生力系技能]}", $"{P_3.转生技能等级}");
					WdAPI i6 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#G恭喜你，#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#G在完成转生时意外获得了转生专属技能<#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_3.转生力系技能);
					defaultInterpolatedStringHandler.AppendLiteral("(");
					defaultInterpolatedStringHandler.AppendFormatted(P_3.转生技能等级);
					defaultInterpolatedStringHandler.AppendLiteral("级)#G>，真是鸿运齐天啊。");
					P_0.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件 != null)
					{
						WdAPI i7 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(61, 5);
						defaultInterpolatedStringHandler.AppendLiteral("#82恭喜#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的爱宠#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n第#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_2.转生数据.转生次数 + 1);
						defaultInterpolatedStringHandler.AppendLiteral("#n次转生成功。并且意外获得了转生专属技能#Y<");
						defaultInterpolatedStringHandler.AppendFormatted(P_3.转生力系技能);
						defaultInterpolatedStringHandler.AppendLiteral("(");
						defaultInterpolatedStringHandler.AppendFormatted(P_3.转生技能等级);
						defaultInterpolatedStringHandler.AppendLiteral("级)>#n，真是鸿运齐天啊。#82");
						client频道事件(i7.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
				}
			}
			else if (P_1.相性 != 0 && !string.IsNullOrWhiteSpace(P_3.转生技能名字) && P_3.转生技能等级 > 0)
			{
				int num2 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				if (P_3.获得技能几率 >= num2 && 问道数据类.所有技能ID.ContainsKey(P_3.转生技能名字))
				{
					Singleton<WdAPI>.I.W9lI1TZlUs(P_0, P_0.user.人物数据.昵称, P_1.宠物ID.ToString(), $"{问道数据类.所有技能ID[P_3.转生技能名字]}", $"{P_3.转生技能等级}");
					WdAPI i8 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#G恭喜你，#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#G在完成转生时意外获得了转生专属技能<#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_3.转生技能名字);
					defaultInterpolatedStringHandler.AppendLiteral("(");
					defaultInterpolatedStringHandler.AppendFormatted(P_3.转生技能等级);
					defaultInterpolatedStringHandler.AppendLiteral("级)#G>，真是鸿运齐天啊。");
					P_0.C_Send(i8.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					Action<byte[]> client频道事件2 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件2 != null)
					{
						WdAPI i9 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(61, 5);
						defaultInterpolatedStringHandler.AppendLiteral("#82恭喜#Y");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("#n的爱宠#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_1.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n第#R");
						defaultInterpolatedStringHandler.AppendFormatted(P_2.转生数据.转生次数 + 1);
						defaultInterpolatedStringHandler.AppendLiteral("#n次转生成功。并且意外获得了转生专属技能#Y<");
						defaultInterpolatedStringHandler.AppendFormatted(P_3.转生技能名字);
						defaultInterpolatedStringHandler.AppendLiteral("(");
						defaultInterpolatedStringHandler.AppendFormatted(P_3.转生技能等级);
						defaultInterpolatedStringHandler.AppendLiteral("级)>#n，真是鸿运齐天啊。#82");
						client频道事件2(i9.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
					}
				}
			}
			bool flag = true;
			if (P_3.各项成长提升 > 0)
			{
				_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass14_0();
				WdAPI i10 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n的物攻、法攻、气血、法力、速度各项基础成长提升了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_3.各项成长提升);
				defaultInterpolatedStringHandler.AppendLiteral("%#n。#G3秒后自动下线更新宠物转生数值！");
				P_0.C_Send(i10.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				Action<byte[]> client频道事件3 = Singleton<全局变量类>.I.Client频道事件;
				if (client频道事件3 != null)
				{
					WdAPI i11 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(67, 4);
					defaultInterpolatedStringHandler.AppendLiteral("#82恭喜#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("#n的爱宠#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_1.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n第#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_2.转生数据.转生次数 + 1);
					defaultInterpolatedStringHandler.AppendLiteral("#n次转生成功。物攻、法攻、气血、法力、速度各项基础成长提升了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_3.各项成长提升);
					defaultInterpolatedStringHandler.AppendLiteral("%#n，真是鸿运齐天啊。#82");
					client频道事件3(i11.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
				}
				CS_0024_003C_003E8__locals3.HrmLpDymBC = P_0.user.人物数据.GID;
				string 账号 = P_0.user.人物数据.账号;
				string 昵称 = P_0.user.人物数据.昵称;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendFormatted(P_1.PetID);
				defaultInterpolatedStringHandler.AppendLiteral(":\"");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.昵称B);
				string 宠物头 = defaultInterpolatedStringHandler.ToStringAndClear();
				Singleton<WdAPI>.I.WT9IHmFS6c(P_0, 昵称);
				if (!(await DB.I.锁定账号操作异步(账号, "1")))
				{
					Log.Error("宠物转生完成处理-错误：账号锁定失败");
					return;
				}
				await Task.Delay(2000);
				if (Singleton<全局变量类>.I.会话Dict.Values.Any( (MyNATSocketClient x) => x.user.人物数据.GID == CS_0024_003C_003E8__locals3.HrmLpDymBC))
				{
					await Singleton<WdAPI>.I.GM_安全下线(昵称);
					await Task.Delay(2000);
				}
				await Task.Delay(1000);
				flag = await DB.I.Jo4iUQtFYN(宠物头, CS_0024_003C_003E8__locals3.HrmLpDymBC, 账号, P_3.各项成长提升);
				DB.I.锁定账号操作(账号, "0");
			}
			if (flag)
			{
				P_2.转生数据.道具数量 = 0;
				P_2.转生数据.转生次数++;
				P_2.转生数据.Is开启 = false;
				DB.I.irWib79NaP(P_2.IID, P_2);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("宠物转生完成处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public AZI1HsR8MjRfegmETY5()
	{
		pIKRLuww7H = Array.Empty<byte>();
	}

	
	static AZI1HsR8MjRfegmETY5()
	{
		fZ1RSIDoZn = new StringBuilder();
	}
}
