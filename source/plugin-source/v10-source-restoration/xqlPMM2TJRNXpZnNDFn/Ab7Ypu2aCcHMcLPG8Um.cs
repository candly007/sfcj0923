using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ncq4nMwbH5sPfLR2xwf;
using Newtonsoft_X.Json;
using Serilog;
using VcF0pbBvJqp0x0IfwN;
using vEAdPGPTkDFOYsbi303;

namespace xqlPMM2TJRNXpZnNDFn;

internal class Ab7Ypu2aCcHMcLPG8Um : Singleton<Ab7Ypu2aCcHMcLPG8Um>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public 元神境界配置类 xKTy31WpCq;

		
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		
		internal bool iVryEQKjtx(MyNATSocketClient x)
		{
			return x.user.存档数据.元神存档.当前境界 == xKTy31WpCq.当前境界;
		}

		static _003C_003Ec__DisplayClass22_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public MyNATSocketClient mdIypnFODR;

		public 本命法宝属性类 aCvy1idXta;

		public byte rSdyxOqkEj;

		public int oEZyHsmsi9;

		public byte wZly4DO6uJ;

		public float xTOyeEdha8;

		public int Mumyq8Yo6c;

		
		public _003C_003Ec__DisplayClass31_0()
		{
		}

		
		internal async void sqYyYCGtQg(string v)
		{
			if (v != aCvy1idXta.强化道具)
			{
				return;
			}
			mdIypnFODR.销毁回调事件 = null;
			MyNATSocketClient myNATSocketClient = mdIypnFODR;
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
			defaultInterpolatedStringHandler.AppendLiteral("#Y");
			defaultInterpolatedStringHandler.AppendFormatted(mdIypnFODR.user.背包数据.物品列表[rSdyxOqkEj].名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n吸收了#R");
			defaultInterpolatedStringHandler.AppendFormatted(oEZyHsmsi9);
			defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
			defaultInterpolatedStringHandler.AppendFormatted(mdIypnFODR.user.背包数据.物品列表[wZly4DO6uJ].名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n。");
			myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			if (xTOyeEdha8 < 1f)
			{
				Singleton<WdAPI>.I.Mr8ICwW3qX(mdIypnFODR, rSdyxOqkEj, "durability", $"{Mumyq8Yo6c}");
				MyNATSocketClient myNATSocketClient2 = mdIypnFODR;
				WdAPI i2 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
				defaultInterpolatedStringHandler.AppendLiteral("很遗憾，#R强化失败#n了！当前强化几率提升至#R");
				defaultInterpolatedStringHandler.AppendFormatted(xTOyeEdha8 * 100f, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("%#n。");
				myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			List<string[]> list = new List<string[]>
			{
				new string[2]
				{
					"durability",
					"1"
				},
				new string[2]
				{
					"rebuild_level",
					$"{mdIypnFODR.user.背包数据.物品列表[rSdyxOqkEj].改造等级 + 1}"
				}
			};
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
			defaultInterpolatedStringHandler.AppendLiteral("#Y");
			defaultInterpolatedStringHandler.AppendFormatted(mdIypnFODR.user.背包数据.物品列表[rSdyxOqkEj].名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n强化#G+");
			defaultInterpolatedStringHandler.AppendFormatted(mdIypnFODR.user.背包数据.物品列表[rSdyxOqkEj].改造等级 + 1);
			defaultInterpolatedStringHandler.AppendLiteral("成功！#n强化属性如下：#r");
			StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
			foreach (通用属性类 item in aCvy1idXta.属性列表)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 4, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(item.属性名字);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(Math.Abs(item.属性数值));
				handler.AppendFormatted(item.Is比例 ? "%" : string.Empty);
				handler.AppendFormatted((item.属性数值 > 0) ? " 增加" : string.Empty);
				handler.AppendLiteral("#r");
				stringBuilder2.Append(ref handler);
				string[] array = new string[2];
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)item.属性名字);
				array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[1] = $"{item.属性数值}";
				list.Add(array);
			}
			Singleton<WdAPI>.I.NNfIVUuyWv(mdIypnFODR, rSdyxOqkEj, list);
			await Task.Delay(200);
			mdIypnFODR.C_Send(Singleton<WdAPI>.I.对话生成_自己(mdIypnFODR, stringBuilder.ToString()));
		}

		static _003C_003Ec__DisplayClass31_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public MyNATSocketClient bgXyZEtN0u;

		public byte ld4ytuqCs7;

		
		public _003C_003Ec__DisplayClass32_0()
		{
		}

		
		internal void qfkyrXhoVp(string v)
		{
			if (!(v != Singleton<全局变量类>.I.元神系统配置.转化道具))
			{
				bgXyZEtN0u.销毁回调事件 = null;
				Singleton<WdAPI>.I.NNfIVUuyWv(bgXyZEtN0u, ld4ytuqCs7, new List<string[]>
				{
					new string[2]
					{
						"max_durability",
						"100000"
					},
					new string[2]
					{
						"durability",
						"100000"
					}
				});
				bgXyZEtN0u.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#Y" + bgXyZEtN0u.user.背包数据.物品列表[ld4ytuqCs7].名字 + "#n转化成功，可以进行进阶了。"));
			}
		}

		static _003C_003Ec__DisplayClass32_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public MyNATSocketClient AF8yzm4fGY;

		public 升阶需求类 al7CufZc4q;

		public byte BDjCwsXeja;

		public int S7gCbdpPoI;

		public byte WRGCJgXV80;

		public float RP9CKhJ8kt;

		public int q7XCR9Ffcb;

		public List<string[]> SMPCdNHeBL;

		public AllEnums.元神境界 zCvCsL3xFn;

		public StringBuilder NCgCUQI4FB;

		
		public _003C_003Ec__DisplayClass33_0()
		{
		}

		
		internal async void S5TyAFBfyx(string v)
		{
			if (!(v != al7CufZc4q.需求材料))
			{
				AF8yzm4fGY.销毁回调事件 = null;
				MyNATSocketClient myNATSocketClient = AF8yzm4fGY;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 3);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(AF8yzm4fGY.user.背包数据.物品列表[BDjCwsXeja].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n吸收了#R");
				defaultInterpolatedStringHandler.AppendFormatted(S7gCbdpPoI);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#Y");
				defaultInterpolatedStringHandler.AppendFormatted(AF8yzm4fGY.user.背包数据.物品列表[WRGCJgXV80].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n中的灵气。");
				myNATSocketClient.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				if (RP9CKhJ8kt < 1f)
				{
					Singleton<WdAPI>.I.Mr8ICwW3qX(AF8yzm4fGY, BDjCwsXeja, "max_durability", $"{q7XCR9Ffcb + S7gCbdpPoI}");
					MyNATSocketClient myNATSocketClient2 = AF8yzm4fGY;
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，#R升阶失败#n了！当前升阶几率提升至#R");
					defaultInterpolatedStringHandler.AppendFormatted(RP9CKhJ8kt * 100f, "F2");
					defaultInterpolatedStringHandler.AppendLiteral("%#n。");
					myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				else
				{
					SMPCdNHeBL.Add(new string[2]
					{
						"max_durability",
						$"{100000 + (int)zCvCsL3xFn * 10000}"
					});
					Singleton<WdAPI>.I.NNfIVUuyWv(AF8yzm4fGY, BDjCwsXeja, SMPCdNHeBL);
					await Task.Delay(200);
					AF8yzm4fGY.C_Send(Singleton<WdAPI>.I.对话生成_自己(AF8yzm4fGY, NCgCUQI4FB.ToString()));
				}
			}
		}

		static _003C_003Ec__DisplayClass33_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public int mWACgBQNDk;

		
		public _003C_003Ec__DisplayClass34_0()
		{
		}

		
		internal bool FimCWfRWVG(宠物缓存数据类 a)
		{
			if (a.宠物ID != 0)
			{
				return a.PetID == mWACgBQNDk;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass34_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public MyNATSocketClient EwgClX6wxK;

		public int bEcC85ooIg;

		public string E0OCIp6JbR;

		public 宠物缓存数据类 EnMCoFeex4;

		public int uaOCNtuf44;

		public int[] CYuCiPOiDJ;

		public int lH3CBKUqT9;

		public int Oi3CGBK4RK;

		public int RZcCfaIKmx;

		public int qQXC6rp2Kx;

		
		public _003C_003Ec__DisplayClass36_0()
		{
		}

		
		internal bool PvlCDvs7BA(宠物缓存数据类 a)
		{
			if (a.宠物ID != 0)
			{
				return a.宠物ID == bEcC85ooIg;
			}
			return false;
		}

		
		internal void YKHCjOUXFL(string v)
		{
			if (v != E0OCIp6JbR)
			{
				return;
			}
			EwgClX6wxK.销毁回调事件 = null;
			MyNATSocketClient myNATSocketClient = EwgClX6wxK;
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 3);
			defaultInterpolatedStringHandler.AppendLiteral("你的宠物#R");
			defaultInterpolatedStringHandler.AppendFormatted(EnMCoFeex4.昵称A);
			defaultInterpolatedStringHandler.AppendLiteral("#n消耗了#R");
			defaultInterpolatedStringHandler.AppendFormatted(uaOCNtuf44);
			defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
			defaultInterpolatedStringHandler.AppendFormatted(E0OCIp6JbR);
			defaultInterpolatedStringHandler.AppendLiteral("#n。");
			myNATSocketClient.C_Send(i.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			List<string[]> list = new List<string[]>();
			for (int j = 0; j < CYuCiPOiDJ.Length; j++)
			{
				if (CYuCiPOiDJ[j] > 0 && 问道数据类.所有技能ID.TryGetValue(sERmNhDmob[j], out var value))
				{
					switch (j)
					{
					case 0:
					{
						list.Add(new string[2]
						{
							$"{value}",
							$"{lH3CBKUqT9 + CYuCiPOiDJ[j]}"
						});
						MyNATSocketClient myNATSocketClient5 = EwgClX6wxK;
						WdAPI i5 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 4);
						defaultInterpolatedStringHandler.AppendLiteral("你的宠物#R");
						defaultInterpolatedStringHandler.AppendFormatted(EnMCoFeex4.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n的心法技能#Y");
						defaultInterpolatedStringHandler.AppendFormatted(sERmNhDmob[j]);
						defaultInterpolatedStringHandler.AppendLiteral("#n等级提升#Y");
						defaultInterpolatedStringHandler.AppendFormatted(lH3CBKUqT9);
						defaultInterpolatedStringHandler.AppendLiteral("#n→#Y");
						defaultInterpolatedStringHandler.AppendFormatted(lH3CBKUqT9 + CYuCiPOiDJ[j]);
						defaultInterpolatedStringHandler.AppendLiteral("#G↑#n。");
						myNATSocketClient5.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case 1:
					{
						list.Add(new string[2]
						{
							$"{value}",
							$"{Oi3CGBK4RK + CYuCiPOiDJ[j]}"
						});
						MyNATSocketClient myNATSocketClient4 = EwgClX6wxK;
						WdAPI i4 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 4);
						defaultInterpolatedStringHandler.AppendLiteral("你的宠物#R");
						defaultInterpolatedStringHandler.AppendFormatted(EnMCoFeex4.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n的心法技能#Y");
						defaultInterpolatedStringHandler.AppendFormatted(sERmNhDmob[j]);
						defaultInterpolatedStringHandler.AppendLiteral("#n等级提升#Y");
						defaultInterpolatedStringHandler.AppendFormatted(Oi3CGBK4RK);
						defaultInterpolatedStringHandler.AppendLiteral("#n→#Y");
						defaultInterpolatedStringHandler.AppendFormatted(Oi3CGBK4RK + CYuCiPOiDJ[j]);
						defaultInterpolatedStringHandler.AppendLiteral("#G↑#n。");
						myNATSocketClient4.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case 2:
					{
						list.Add(new string[2]
						{
							$"{value}",
							$"{RZcCfaIKmx + CYuCiPOiDJ[j]}"
						});
						MyNATSocketClient myNATSocketClient3 = EwgClX6wxK;
						WdAPI i3 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 4);
						defaultInterpolatedStringHandler.AppendLiteral("你的宠物#R");
						defaultInterpolatedStringHandler.AppendFormatted(EnMCoFeex4.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n的心法技能#Y");
						defaultInterpolatedStringHandler.AppendFormatted(sERmNhDmob[j]);
						defaultInterpolatedStringHandler.AppendLiteral("#n等级提升#Y");
						defaultInterpolatedStringHandler.AppendFormatted(RZcCfaIKmx);
						defaultInterpolatedStringHandler.AppendLiteral("#n→#Y");
						defaultInterpolatedStringHandler.AppendFormatted(RZcCfaIKmx + CYuCiPOiDJ[j]);
						defaultInterpolatedStringHandler.AppendLiteral("#G↑#n。");
						myNATSocketClient3.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					case 3:
					{
						list.Add(new string[2]
						{
							$"{value}",
							$"{qQXC6rp2Kx + CYuCiPOiDJ[j]}"
						});
						MyNATSocketClient myNATSocketClient2 = EwgClX6wxK;
						WdAPI i2 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 4);
						defaultInterpolatedStringHandler.AppendLiteral("你的宠物#R");
						defaultInterpolatedStringHandler.AppendFormatted(EnMCoFeex4.昵称A);
						defaultInterpolatedStringHandler.AppendLiteral("#n的心法技能#Y");
						defaultInterpolatedStringHandler.AppendFormatted(sERmNhDmob[j]);
						defaultInterpolatedStringHandler.AppendLiteral("#n等级提升#Y");
						defaultInterpolatedStringHandler.AppendFormatted(qQXC6rp2Kx);
						defaultInterpolatedStringHandler.AppendLiteral("#n→#Y");
						defaultInterpolatedStringHandler.AppendFormatted(qQXC6rp2Kx + CYuCiPOiDJ[j]);
						defaultInterpolatedStringHandler.AppendLiteral("#G↑#n。");
						myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					}
				}
			}
			if (list.Count > 0)
			{
				Singleton<WdAPI>.I.f5oIxL5Jqw(EwgClX6wxK, EwgClX6wxK.user.人物数据.昵称, EnMCoFeex4.宠物ID.ToString(), list);
			}
		}

		static _003C_003Ec__DisplayClass36_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public MyNATSocketClient lYJCPgtNtn;

		public int LHaCXCIy2m;

		public 引灵幡属性列表类 JjOCF4QNDi;

		public 物品信息类 tk1CL3okF6;

		public int BJLCS0WQHs;

		
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		
		internal bool CYbC2pNN3s(物品信息类 x)
		{
			return x.Index == LHaCXCIy2m + 40;
		}

		
		internal async void XoVCmMvK2D(string v)
		{
			if (v != JjOCF4QNDi.附灵道具)
			{
				return;
			}
			lYJCPgtNtn.销毁回调事件 = null;
			List<string[]> list = new List<string[]>
			{
				new string[2]
				{
					"lianhun",
					$"{tk1CL3okF6.最大炼魂值 + 1}"
				},
				new string[2]
				{
					"max_lianhun",
					$"{tk1CL3okF6.最大炼魂值 + 1}"
				}
			};
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("#Y");
			defaultInterpolatedStringHandler.AppendFormatted(tk1CL3okF6.名字);
			defaultInterpolatedStringHandler.AppendLiteral("·");
			defaultInterpolatedStringHandler.AppendFormatted(BJLCS0WQHs + 1);
			defaultInterpolatedStringHandler.AppendLiteral("品#n附灵属性：#r");
			StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
			if (Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryGetValue(tk1CL3okF6.最大炼魂值, out 引灵幡属性列表类 value))
			{
				for (int i = 0; i < value.属性列表.Count; i++)
				{
					string[] array = new string[2];
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)value.属性列表[i].属性名字);
					array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array[1] = "0";
					list.Add(array);
				}
			}
			for (int j = 0; j < JjOCF4QNDi.属性列表.Count; j++)
			{
				string[] array2 = new string[2];
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)JjOCF4QNDi.属性列表[j].属性名字);
				array2[0] = defaultInterpolatedStringHandler.ToStringAndClear();
				array2[1] = $"{JjOCF4QNDi.属性列表[j].属性数值}";
				list.Add(array2);
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 2, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(JjOCF4QNDi.属性列表[j].属性名字);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(JjOCF4QNDi.属性列表[j].属性数值);
				handler.AppendLiteral(" 增加#r");
				stringBuilder2.Append(ref handler);
			}
			Singleton<WdAPI>.I.NNfIVUuyWv(lYJCPgtNtn, tk1CL3okF6.Index, list);
			await Task.Delay(500);
			lYJCPgtNtn.C_Send(Singleton<WdAPI>.I.对话生成_自己(lYJCPgtNtn, stringBuilder.ToString()));
		}

		static _003C_003Ec__DisplayClass39_0()
		{
		}
	}

	public static StringBuilder IkymDsp1jm;

	public static StringBuilder Yp6mjOM9qh;

	public static StringBuilder yQ0mlWibO6;

	public static StringBuilder sK3m8a9JNp;

	public static StringBuilder xh4mILM5j1;

	public static StringBuilder sPhmoeHQ4M;

	public static string[] sERmNhDmob;

	public static ConcurrentDictionary<AllEnums.元神境界, 元神特效配置类> Pihmi6fRa9;

	
	[SpecialName]
	public static bool o5DmWnO5ND()
	{
		if (全局变量类.Is调试 || (Singleton<全局变量类>.I.验证client.授权配置.Is道友挖宝 && Singleton<全局变量类>.I.config.Is道友挖宝))
		{
			return Singleton<全局变量类>.I.元神系统配置.功能开关;
		}
		return false;
	}

	
	private void AYW29EI84m()
	{
		Pihmi6fRa9.Clear();
		Pihmi6fRa9.TryAdd(AllEnums.元神境界.练气境, new 元神特效配置类
		{
			当前境界特效 = 0,
			当前雷劫特效 = 50094,
			当前雷劫秒数 = 1,
			当前基础进度秒数 = 2,
			突破成功特效 = 30003,
			突破成功特效秒数 = 1,
			突破失败特效 = 9988,
			突破失败特效秒数 = 1
		});
		Pihmi6fRa9.TryAdd(AllEnums.元神境界.筑基境, new 元神特效配置类
		{
			当前境界特效 = 0,
			当前雷劫特效 = 50094,
			当前雷劫秒数 = 2,
			当前基础进度秒数 = 3,
			突破成功特效 = 30003,
			突破成功特效秒数 = 1,
			突破失败特效 = 9988,
			突破失败特效秒数 = 1
		});
		Pihmi6fRa9.TryAdd(AllEnums.元神境界.金丹境, new 元神特效配置类
		{
			当前境界特效 = 0,
			当前雷劫特效 = 50094,
			当前雷劫秒数 = 4,
			当前基础进度秒数 = 5,
			突破成功特效 = 30003,
			突破成功特效秒数 = 1,
			突破失败特效 = 9988,
			突破失败特效秒数 = 1
		});
		Pihmi6fRa9.TryAdd(AllEnums.元神境界.元婴境, new 元神特效配置类
		{
			当前境界特效 = 0,
			当前雷劫特效 = 50094,
			当前雷劫秒数 = 6,
			当前基础进度秒数 = 6,
			突破成功特效 = 30003,
			突破成功特效秒数 = 1,
			突破失败特效 = 9988,
			突破失败特效秒数 = 1
		});
		Pihmi6fRa9.TryAdd(AllEnums.元神境界.化神境, new 元神特效配置类
		{
			当前境界特效 = 0,
			当前雷劫特效 = 50094,
			当前雷劫秒数 = 8,
			当前基础进度秒数 = 8,
			突破成功特效 = 30003,
			突破成功特效秒数 = 1,
			突破失败特效 = 9988,
			突破失败特效秒数 = 1
		});
		Pihmi6fRa9.TryAdd(AllEnums.元神境界.炼虚境, new 元神特效配置类
		{
			当前境界特效 = 0,
			当前雷劫特效 = 50094,
			当前雷劫秒数 = 10,
			当前基础进度秒数 = 11,
			突破成功特效 = 30003,
			突破成功特效秒数 = 1,
			突破失败特效 = 9988,
			突破失败特效秒数 = 1
		});
		Pihmi6fRa9.TryAdd(AllEnums.元神境界.合体境, new 元神特效配置类
		{
			当前境界特效 = 0,
			当前雷劫特效 = 50094,
			当前雷劫秒数 = 12,
			当前基础进度秒数 = 13,
			突破成功特效 = 30003,
			突破成功特效秒数 = 1,
			突破失败特效 = 9988,
			突破失败特效秒数 = 1
		});
		Pihmi6fRa9.TryAdd(AllEnums.元神境界.渡劫境, new 元神特效配置类
		{
			当前境界特效 = 0,
			当前雷劫特效 = 50094,
			当前雷劫秒数 = 14,
			当前基础进度秒数 = 15,
			突破成功特效 = 30003,
			突破成功特效秒数 = 1,
			突破失败特效 = 9988,
			突破失败特效秒数 = 1
		});
		Pihmi6fRa9.TryAdd(AllEnums.元神境界.大乘境, new 元神特效配置类
		{
			当前境界特效 = 0,
			当前雷劫特效 = 50094,
			当前雷劫秒数 = 16,
			当前基础进度秒数 = 17,
			突破成功特效 = 30003,
			突破成功特效秒数 = 1,
			突破失败特效 = 9988,
			突破失败特效秒数 = 1
		});
	}

	
	private void asX2yY8cuj()
	{
		Singleton<全局变量类>.I.元神系统配置.功能开关 = false;
		Singleton<全局变量类>.I.元神系统配置.初始赠送礼包 = "道友修仙大礼包";
		Singleton<全局变量类>.I.元神系统配置.渡劫地图 = "渡劫台";
		Singleton<全局变量类>.I.元神系统配置.地图坐标X = "66";
		Singleton<全局变量类>.I.元神系统配置.地图坐标Y = "99";
		Singleton<全局变量类>.I.元神系统配置.当前境界上限 = AllEnums.元神境界.化神境;
		Singleton<全局变量类>.I.元神系统配置.境界列表.Clear();
		元神境界配置类 value = new 元神境界配置类
		{
			当前境界 = AllEnums.元神境界.凡人境,
			突破境界 = AllEnums.元神境界.练气境,
			突破灵气值 = 10
		};
		Singleton<全局变量类>.I.元神系统配置.境界列表.TryAdd(AllEnums.元神境界.凡人境, value);
		元神境界配置类 元神境界配置类2 = new 元神境界配置类
		{
			当前境界 = AllEnums.元神境界.练气境,
			突破境界 = AllEnums.元神境界.筑基境,
			突破灵气值 = 100
		};
		元神境界配置类2.突破加成配置 = new 元神境界加成类
		{
			突破道具 = "筑基丹",
			突破几率 = 30,
			所有相性 = 5,
			所有属性 = 2,
			物理伤害 = 0,
			法术伤害 = 0,
			防御 = 0,
			速度 = 0,
			气血 = 0,
			法力 = 0
		};
		元神境界配置类2.突破失败受伤程度 = 100;
		元神境界配置类2.增加突破几率道具.TryAdd("冰凌花", 5);
		元神境界配置类2.增加突破几率道具.TryAdd("血灵芝", 10);
		元神境界配置类2.增加突破几率道具.TryAdd("筑基花", 15);
		元神境界配置类2.突破特殊需求 = new 元神突破特殊需求类
		{
			Is额外条件 = false,
			Is道行达标 = true,
			道行要求 = 5000,
			Is声望达标 = true,
			声望要求 = 100,
			Is击杀BOSS要求 = true,
			击杀BOSS要求 = "野狗",
			Is获取道具要求 = false,
			获取道具要求 = string.Empty
		};
		元神境界配置类2.Is全服突破境界奖励 = true;
		元神境界配置类2.首次突破奖励.奖励金元宝 = 0;
		元神境界配置类2.首次突破奖励.奖励银元宝 = 0;
		元神境界配置类2.首次突破奖励.奖励游戏币 = 0;
		元神境界配置类2.首次突破奖励.奖励道行 = 2000;
		元神境界配置类2.首次突破奖励.奖励声望 = 1000;
		元神境界配置类2.首次突破奖励.奖励道具 = "";
		元神境界配置类2.首次突破奖励.奖励技能 = "";
		元神境界配置类2.首次突破奖励.技能等级 = 1;
		元神境界配置类2.Is突破横幅 = true;
		元神境界配置类2.全服横幅文字 = "恭喜#Y#user#n突破至#G筑基境#n，百日筑基今日满，雷音一震破玄关。";
		Singleton<全局变量类>.I.元神系统配置.境界列表.TryAdd(AllEnums.元神境界.练气境, 元神境界配置类2);
		元神境界配置类 元神境界配置类3 = new 元神境界配置类
		{
			当前境界 = AllEnums.元神境界.筑基境,
			突破境界 = AllEnums.元神境界.金丹境,
			突破灵气值 = 1000
		};
		元神境界配置类3.突破加成配置 = new 元神境界加成类
		{
			突破道具 = "结金丹",
			突破几率 = 30,
			所有相性 = 5,
			所有属性 = 2,
			物理伤害 = 0,
			法术伤害 = 0,
			防御 = 0,
			速度 = 0,
			气血 = 0,
			法力 = 0
		};
		元神境界配置类3.突破失败受伤程度 = 100;
		元神境界配置类3.增加突破几率道具.TryAdd("天水露", 5);
		元神境界配置类3.增加突破几率道具.TryAdd("醉灵酒", 10);
		元神境界配置类3.增加突破几率道具.TryAdd("洗髓液", 15);
		元神境界配置类3.突破特殊需求 = new 元神突破特殊需求类
		{
			Is额外条件 = false,
			Is道行达标 = false,
			道行要求 = 0,
			Is声望达标 = false,
			声望要求 = 0,
			Is击杀BOSS要求 = false,
			击杀BOSS要求 = string.Empty,
			Is获取道具要求 = false,
			获取道具要求 = string.Empty
		};
		元神境界配置类3.Is全服突破境界奖励 = true;
		元神境界配置类3.首次突破奖励.奖励金元宝 = 0;
		元神境界配置类3.首次突破奖励.奖励银元宝 = 0;
		元神境界配置类3.首次突破奖励.奖励游戏币 = 0;
		元神境界配置类3.首次突破奖励.奖励道行 = 2000;
		元神境界配置类3.首次突破奖励.奖励声望 = 1000;
		元神境界配置类3.首次突破奖励.奖励道具 = "";
		元神境界配置类3.首次突破奖励.奖励技能 = "";
		元神境界配置类3.首次突破奖励.技能等级 = 1;
		元神境界配置类3.Is突破横幅 = true;
		元神境界配置类3.全服横幅文字 = "恭喜#Y#user#n突破至#G金丹境#n，一粒金丹吞入腹，我命由我不由天。";
		Singleton<全局变量类>.I.元神系统配置.境界列表.TryAdd(AllEnums.元神境界.筑基境, 元神境界配置类3);
		元神境界配置类 元神境界配置类4 = new 元神境界配置类
		{
			当前境界 = AllEnums.元神境界.金丹境,
			突破境界 = AllEnums.元神境界.元婴境,
			突破灵气值 = 10000
		};
		元神境界配置类4.突破加成配置 = new 元神境界加成类
		{
			突破道具 = "元婴丹",
			突破几率 = 30,
			所有相性 = 5,
			所有属性 = 2,
			物理伤害 = 0,
			法术伤害 = 0,
			防御 = 0,
			速度 = 0,
			气血 = 0,
			法力 = 0
		};
		元神境界配置类4.突破失败受伤程度 = 100;
		元神境界配置类4.增加突破几率道具.TryAdd("星光神水", 5);
		元神境界配置类4.增加突破几率道具.TryAdd("月光神水", 15);
		元神境界配置类4.增加突破几率道具.TryAdd("日光神水", 70);
		元神境界配置类4.突破特殊需求 = new 元神突破特殊需求类
		{
			Is额外条件 = false,
			Is道行达标 = false,
			道行要求 = 0,
			Is声望达标 = false,
			声望要求 = 0,
			Is击杀BOSS要求 = false,
			击杀BOSS要求 = string.Empty,
			Is获取道具要求 = false,
			获取道具要求 = string.Empty
		};
		元神境界配置类4.Is全服突破境界奖励 = true;
		元神境界配置类4.首次突破奖励.奖励金元宝 = 0;
		元神境界配置类4.首次突破奖励.奖励银元宝 = 0;
		元神境界配置类4.首次突破奖励.奖励游戏币 = 0;
		元神境界配置类4.首次突破奖励.奖励道行 = 2000;
		元神境界配置类4.首次突破奖励.奖励声望 = 1000;
		元神境界配置类4.首次突破奖励.奖励道具 = "";
		元神境界配置类4.首次突破奖励.奖励技能 = "";
		元神境界配置类4.首次突破奖励.技能等级 = 1;
		元神境界配置类4.Is突破横幅 = true;
		元神境界配置类4.全服横幅文字 = "恭喜#Y#user#n突破至#G元婴境#n，紫府元婴初坐定，乾坤一气纳丹庭。";
		Singleton<全局变量类>.I.元神系统配置.境界列表.TryAdd(AllEnums.元神境界.金丹境, 元神境界配置类4);
		元神境界配置类 元神境界配置类5 = new 元神境界配置类
		{
			当前境界 = AllEnums.元神境界.元婴境,
			突破境界 = AllEnums.元神境界.化神境,
			突破灵气值 = 100000
		};
		元神境界配置类5.突破加成配置 = new 元神境界加成类
		{
			突破道具 = "化神丹",
			突破几率 = 30,
			所有相性 = 5,
			所有属性 = 2,
			物理伤害 = 0,
			法术伤害 = 0,
			防御 = 0,
			速度 = 0,
			气血 = 0,
			法力 = 0
		};
		元神境界配置类5.突破失败受伤程度 = 100;
		元神境界配置类5.增加突破几率道具.TryAdd("秘银神沙", 5);
		元神境界配置类5.增加突破几率道具.TryAdd("梧桐神叶", 10);
		元神境界配置类5.增加突破几率道具.TryAdd("悟道古茶", 70);
		元神境界配置类5.突破特殊需求 = new 元神突破特殊需求类
		{
			Is额外条件 = false,
			Is道行达标 = false,
			道行要求 = 0,
			Is声望达标 = false,
			声望要求 = 0,
			Is击杀BOSS要求 = false,
			击杀BOSS要求 = string.Empty,
			Is获取道具要求 = false,
			获取道具要求 = string.Empty
		};
		元神境界配置类5.Is全服突破境界奖励 = true;
		元神境界配置类5.首次突破奖励.奖励金元宝 = 0;
		元神境界配置类5.首次突破奖励.奖励银元宝 = 0;
		元神境界配置类5.首次突破奖励.奖励游戏币 = 0;
		元神境界配置类5.首次突破奖励.奖励道行 = 2000;
		元神境界配置类5.首次突破奖励.奖励声望 = 1000;
		元神境界配置类5.首次突破奖励.奖励道具 = "";
		元神境界配置类5.首次突破奖励.奖励技能 = "";
		元神境界配置类5.首次突破奖励.技能等级 = 1;
		元神境界配置类5.Is突破横幅 = true;
		元神境界配置类5.全服横幅文字 = "恭喜#Y#user#n突破至#G化神境#n，一念通神破凡胎，灵台清明万法开。";
		Singleton<全局变量类>.I.元神系统配置.境界列表.TryAdd(AllEnums.元神境界.元婴境, 元神境界配置类5);
		元神境界配置类 元神境界配置类6 = new 元神境界配置类
		{
			当前境界 = AllEnums.元神境界.化神境,
			突破境界 = AllEnums.元神境界.炼虚境,
			突破灵气值 = 1000000
		};
		元神境界配置类6.突破加成配置 = new 元神境界加成类
		{
			突破道具 = "炼虚丹",
			突破几率 = 30,
			所有相性 = 5,
			所有属性 = 2,
			物理伤害 = 0,
			法术伤害 = 0,
			防御 = 0,
			速度 = 0,
			气血 = 0,
			法力 = 0
		};
		元神境界配置类6.突破失败受伤程度 = 100;
		元神境界配置类6.增加突破几率道具.TryAdd("一元神石", 5);
		元神境界配置类6.增加突破几率道具.TryAdd("两仪神石", 10);
		元神境界配置类6.增加突破几率道具.TryAdd("三彩神石", 70);
		元神境界配置类6.突破特殊需求 = new 元神突破特殊需求类
		{
			Is额外条件 = false,
			Is道行达标 = false,
			道行要求 = 0,
			Is声望达标 = false,
			声望要求 = 0,
			Is击杀BOSS要求 = false,
			击杀BOSS要求 = string.Empty,
			Is获取道具要求 = false,
			获取道具要求 = string.Empty
		};
		元神境界配置类6.Is全服突破境界奖励 = true;
		元神境界配置类6.首次突破奖励.奖励金元宝 = 0;
		元神境界配置类6.首次突破奖励.奖励银元宝 = 0;
		元神境界配置类6.首次突破奖励.奖励游戏币 = 0;
		元神境界配置类6.首次突破奖励.奖励道行 = 2000;
		元神境界配置类6.首次突破奖励.奖励声望 = 1000;
		元神境界配置类6.首次突破奖励.奖励道具 = "";
		元神境界配置类6.首次突破奖励.奖励技能 = "";
		元神境界配置类6.首次突破奖励.技能等级 = 1;
		元神境界配置类6.Is突破横幅 = true;
		元神境界配置类6.全服横幅文字 = "恭喜#Y#user#n突破至#G炼虚境#n，身融天地入虚无，阴阳流转自为炉。";
		Singleton<全局变量类>.I.元神系统配置.境界列表.TryAdd(AllEnums.元神境界.化神境, 元神境界配置类6);
		元神境界配置类 元神境界配置类7 = new 元神境界配置类
		{
			当前境界 = AllEnums.元神境界.炼虚境,
			突破境界 = AllEnums.元神境界.合体境,
			突破灵气值 = 10000000
		};
		元神境界配置类7.突破加成配置 = new 元神境界加成类
		{
			突破道具 = "合体丹",
			突破几率 = 30,
			所有相性 = 5,
			所有属性 = 2,
			物理伤害 = 0,
			法术伤害 = 0,
			防御 = 0,
			速度 = 0,
			气血 = 0,
			法力 = 0
		};
		元神境界配置类7.突破失败受伤程度 = 100;
		元神境界配置类7.增加突破几率道具.TryAdd("神念水滴", 5);
		元神境界配置类7.增加突破几率道具.TryAdd("木灵精魄", 10);
		元神境界配置类7.增加突破几率道具.TryAdd("人道紫气", 70);
		元神境界配置类7.突破特殊需求 = new 元神突破特殊需求类
		{
			Is额外条件 = false,
			Is道行达标 = false,
			道行要求 = 0,
			Is声望达标 = false,
			声望要求 = 0,
			Is击杀BOSS要求 = false,
			击杀BOSS要求 = string.Empty,
			Is获取道具要求 = false,
			获取道具要求 = string.Empty
		};
		元神境界配置类7.Is全服突破境界奖励 = true;
		元神境界配置类7.首次突破奖励.奖励金元宝 = 0;
		元神境界配置类7.首次突破奖励.奖励银元宝 = 0;
		元神境界配置类7.首次突破奖励.奖励游戏币 = 0;
		元神境界配置类7.首次突破奖励.奖励道行 = 2000;
		元神境界配置类7.首次突破奖励.奖励声望 = 1000;
		元神境界配置类7.首次突破奖励.奖励道具 = "";
		元神境界配置类7.首次突破奖励.奖励技能 = "";
		元神境界配置类7.首次突破奖励.技能等级 = 1;
		元神境界配置类7.Is突破横幅 = true;
		元神境界配置类7.全服横幅文字 = "恭喜#Y#user#n突破至#G合体境#n，形神合一归大道，天地与我共逍遥。";
		Singleton<全局变量类>.I.元神系统配置.境界列表.TryAdd(AllEnums.元神境界.炼虚境, 元神境界配置类7);
		元神境界配置类 元神境界配置类8 = new 元神境界配置类
		{
			当前境界 = AllEnums.元神境界.合体境,
			突破境界 = AllEnums.元神境界.渡劫境,
			突破灵气值 = 100000000
		};
		元神境界配置类8.突破加成配置 = new 元神境界加成类
		{
			突破道具 = "渡劫丹",
			突破几率 = 30,
			所有相性 = 5,
			所有属性 = 2,
			物理伤害 = 0,
			法术伤害 = 0,
			防御 = 0,
			速度 = 0,
			气血 = 0,
			法力 = 0
		};
		元神境界配置类8.突破失败受伤程度 = 100;
		元神境界配置类8.增加突破几率道具.TryAdd("仙雷劫精晶", 2);
		元神境界配置类8.增加突破几率道具.TryAdd("万年朱血果", 3);
		元神境界配置类8.增加突破几率道具.TryAdd("紫魂赤血果", 5);
		元神境界配置类8.增加突破几率道具.TryAdd("万年人参精", 70);
		元神境界配置类8.突破特殊需求 = new 元神突破特殊需求类
		{
			Is额外条件 = false,
			Is道行达标 = false,
			道行要求 = 0,
			Is声望达标 = false,
			声望要求 = 0,
			Is击杀BOSS要求 = false,
			击杀BOSS要求 = string.Empty,
			Is获取道具要求 = false,
			获取道具要求 = string.Empty
		};
		元神境界配置类8.Is全服突破境界奖励 = true;
		元神境界配置类8.首次突破奖励.奖励金元宝 = 0;
		元神境界配置类8.首次突破奖励.奖励银元宝 = 0;
		元神境界配置类8.首次突破奖励.奖励游戏币 = 0;
		元神境界配置类8.首次突破奖励.奖励道行 = 2000;
		元神境界配置类8.首次突破奖励.奖励声望 = 1000;
		元神境界配置类8.首次突破奖励.奖励道具 = "";
		元神境界配置类8.首次突破奖励.奖励技能 = "";
		元神境界配置类8.首次突破奖励.技能等级 = 1;
		元神境界配置类8.Is突破横幅 = true;
		元神境界配置类8.全服横幅文字 = "恭喜#Y#user#n突破至#G渡劫境#n，九霄雷劫洗尘垢，不死不灭真灵留。";
		Singleton<全局变量类>.I.元神系统配置.境界列表.TryAdd(AllEnums.元神境界.合体境, 元神境界配置类8);
		元神境界配置类 元神境界配置类9 = new 元神境界配置类
		{
			当前境界 = AllEnums.元神境界.渡劫境,
			突破境界 = AllEnums.元神境界.大乘境,
			突破灵气值 = 1000000000
		};
		元神境界配置类9.突破加成配置 = new 元神境界加成类
		{
			突破道具 = "大乘丹",
			突破几率 = 30,
			所有相性 = 5,
			所有属性 = 2,
			物理伤害 = 0,
			法术伤害 = 0,
			防御 = 0,
			速度 = 0,
			气血 = 0,
			法力 = 0
		};
		元神境界配置类9.突破失败受伤程度 = 100;
		元神境界配置类9.增加突破几率道具.TryAdd("玄阴雷晶", 10);
		元神境界配置类9.增加突破几率道具.TryAdd("五行雷晶", 15);
		元神境界配置类9.增加突破几率道具.TryAdd("紫霄雷晶", 70);
		元神境界配置类9.突破特殊需求 = new 元神突破特殊需求类
		{
			Is额外条件 = false,
			Is道行达标 = false,
			道行要求 = 0,
			Is声望达标 = false,
			声望要求 = 0,
			Is击杀BOSS要求 = false,
			击杀BOSS要求 = string.Empty,
			Is获取道具要求 = false,
			获取道具要求 = string.Empty
		};
		元神境界配置类9.Is全服突破境界奖励 = true;
		元神境界配置类9.首次突破奖励.奖励金元宝 = 0;
		元神境界配置类9.首次突破奖励.奖励银元宝 = 0;
		元神境界配置类9.首次突破奖励.奖励游戏币 = 0;
		元神境界配置类9.首次突破奖励.奖励道行 = 2000;
		元神境界配置类9.首次突破奖励.奖励声望 = 1000;
		元神境界配置类9.首次突破奖励.奖励道具 = "";
		元神境界配置类9.首次突破奖励.奖励技能 = "";
		元神境界配置类9.首次突破奖励.技能等级 = 1;
		元神境界配置类9.Is突破横幅 = true;
		元神境界配置类9.全服横幅文字 = "恭喜#Y#user#n突破至#G大乘境#n，万法归宗臻圆满，纵横三界无人拦。";
		Singleton<全局变量类>.I.元神系统配置.境界列表.TryAdd(AllEnums.元神境界.渡劫境, 元神境界配置类9);
		元神境界配置类 元神境界配置类10 = new 元神境界配置类
		{
			当前境界 = AllEnums.元神境界.大乘境,
			突破境界 = AllEnums.元神境界.真仙境,
			突破灵气值 = 10000
		};
		元神境界配置类10.突破加成配置 = new 元神境界加成类
		{
			突破道具 = "真仙丹",
			突破几率 = 30,
			所有相性 = 5,
			所有属性 = 2,
			物理伤害 = 0,
			法术伤害 = 0,
			防御 = 0,
			速度 = 0,
			气血 = 0,
			法力 = 0
		};
		元神境界配置类10.突破失败受伤程度 = 100;
		元神境界配置类10.增加突破几率道具.TryAdd("真龙护体珠", 5);
		元神境界配置类10.增加突破几率道具.TryAdd("四圣仙魄石", 10);
		元神境界配置类10.增加突破几率道具.TryAdd("九转金灵丹", 70);
		元神境界配置类10.突破特殊需求 = new 元神突破特殊需求类
		{
			Is额外条件 = false,
			Is道行达标 = false,
			道行要求 = 0,
			Is声望达标 = false,
			声望要求 = 0,
			Is击杀BOSS要求 = false,
			击杀BOSS要求 = string.Empty,
			Is获取道具要求 = false,
			获取道具要求 = string.Empty
		};
		元神境界配置类10.Is全服突破境界奖励 = true;
		元神境界配置类10.首次突破奖励.奖励金元宝 = 0;
		元神境界配置类10.首次突破奖励.奖励银元宝 = 0;
		元神境界配置类10.首次突破奖励.奖励游戏币 = 0;
		元神境界配置类10.首次突破奖励.奖励道行 = 2000;
		元神境界配置类10.首次突破奖励.奖励声望 = 1000;
		元神境界配置类10.首次突破奖励.奖励道具 = "";
		元神境界配置类10.首次突破奖励.奖励技能 = "";
		元神境界配置类10.首次突破奖励.技能等级 = 1;
		元神境界配置类10.Is突破横幅 = true;
		元神境界配置类10.全服横幅文字 = "恭喜#Y#user#n突破至#G真仙境#n，斩尽尘缘登仙路，凌霄之上我为尊。";
		Singleton<全局变量类>.I.元神系统配置.境界列表.TryAdd(AllEnums.元神境界.大乘境, 元神境界配置类10);
	}

	
	public void sNJ2CwwU5I()
	{
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.Clear();
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(0, new 本命法宝属性类());
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(1, new 本命法宝属性类
		{
			强化进度 = 2,
			强化道具 = "练气境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 1
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(2, new 本命法宝属性类
		{
			强化进度 = 4,
			强化道具 = "练气境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 2
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(3, new 本命法宝属性类
		{
			强化进度 = 6,
			强化道具 = "练气境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 3
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(4, new 本命法宝属性类
		{
			强化进度 = 8,
			强化道具 = "练气境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 4
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(5, new 本命法宝属性类
		{
			强化进度 = 16,
			强化道具 = "练气境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(6, new 本命法宝属性类
		{
			强化进度 = 32,
			强化道具 = "练气境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 6
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(7, new 本命法宝属性类
		{
			强化进度 = 64,
			强化道具 = "练气境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 7
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(8, new 本命法宝属性类
		{
			强化进度 = 128,
			强化道具 = "练气境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 8
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(9, new 本命法宝属性类
		{
			强化进度 = 256,
			强化道具 = "练气境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 9
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(10, new 本命法宝属性类
		{
			强化进度 = 512,
			强化道具 = "练气境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 10
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 10
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(11, new 本命法宝属性类
		{
			强化进度 = 4,
			强化道具 = "筑基境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 11
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 11
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(12, new 本命法宝属性类
		{
			强化进度 = 6,
			强化道具 = "筑基境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 12
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 12
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(13, new 本命法宝属性类
		{
			强化进度 = 8,
			强化道具 = "筑基境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 13
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 13
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(14, new 本命法宝属性类
		{
			强化进度 = 16,
			强化道具 = "筑基境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 14
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 14
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(15, new 本命法宝属性类
		{
			强化进度 = 32,
			强化道具 = "筑基境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 15
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 15
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(16, new 本命法宝属性类
		{
			强化进度 = 64,
			强化道具 = "筑基境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 16
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 16
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(17, new 本命法宝属性类
		{
			强化进度 = 128,
			强化道具 = "筑基境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 17
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 17
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(18, new 本命法宝属性类
		{
			强化进度 = 256,
			强化道具 = "筑基境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 18
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 18
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(19, new 本命法宝属性类
		{
			强化进度 = 512,
			强化道具 = "筑基境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 19
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 19
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(20, new 本命法宝属性类
		{
			强化进度 = 1024,
			强化道具 = "筑基境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 20
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 20
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 20
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(21, new 本命法宝属性类
		{
			强化进度 = 6,
			强化道具 = "金丹境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 21
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 21
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 21
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(22, new 本命法宝属性类
		{
			强化进度 = 8,
			强化道具 = "金丹境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 22
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 22
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 22
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(23, new 本命法宝属性类
		{
			强化进度 = 16,
			强化道具 = "金丹境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 23
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 23
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 23
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(24, new 本命法宝属性类
		{
			强化进度 = 32,
			强化道具 = "金丹境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 24
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 24
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 24
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(25, new 本命法宝属性类
		{
			强化进度 = 64,
			强化道具 = "金丹境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 25
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 25
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 25
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(26, new 本命法宝属性类
		{
			强化进度 = 128,
			强化道具 = "金丹境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 26
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 26
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 26
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(27, new 本命法宝属性类
		{
			强化进度 = 256,
			强化道具 = "金丹境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 27
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 27
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 27
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(28, new 本命法宝属性类
		{
			强化进度 = 512,
			强化道具 = "金丹境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 28
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 28
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 28
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(29, new 本命法宝属性类
		{
			强化进度 = 1024,
			强化道具 = "金丹境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 29
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 29
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 29
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(30, new 本命法宝属性类
		{
			强化进度 = 2048,
			强化道具 = "金丹境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 30
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 30
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 30
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 300,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(31, new 本命法宝属性类
		{
			强化进度 = 8,
			强化道具 = "元婴境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 31
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 31
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 31
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 300,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(32, new 本命法宝属性类
		{
			强化进度 = 16,
			强化道具 = "元婴境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 32
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 32
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 32
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 300,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(33, new 本命法宝属性类
		{
			强化进度 = 32,
			强化道具 = "元婴境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 33
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 33
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 33
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 300,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(34, new 本命法宝属性类
		{
			强化进度 = 64,
			强化道具 = "元婴境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 34
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 34
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 34
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 300,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(35, new 本命法宝属性类
		{
			强化进度 = 128,
			强化道具 = "元婴境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 35
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 35
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 35
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 300,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(36, new 本命法宝属性类
		{
			强化进度 = 256,
			强化道具 = "元婴境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 36
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 36
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 36
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 300,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(37, new 本命法宝属性类
		{
			强化进度 = 512,
			强化道具 = "元婴境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 37
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 37
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 37
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 300,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(38, new 本命法宝属性类
		{
			强化进度 = 1024,
			强化道具 = "元婴境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 38
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 38
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 38
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 300,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(39, new 本命法宝属性类
		{
			强化进度 = 2048,
			强化道具 = "元婴境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 39
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 39
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 39
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 300,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(40, new 本命法宝属性类
		{
			强化进度 = 3072,
			强化道具 = "元婴境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 40
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 40
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 40
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 400,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 400,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(41, new 本命法宝属性类
		{
			强化进度 = 16,
			强化道具 = "化神境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 41
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 41
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 41
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 400,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 400,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(42, new 本命法宝属性类
		{
			强化进度 = 32,
			强化道具 = "化神境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 42
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 42
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 42
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 400,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 400,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(43, new 本命法宝属性类
		{
			强化进度 = 64,
			强化道具 = "化神境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 43
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 43
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 43
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 400,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 400,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(44, new 本命法宝属性类
		{
			强化进度 = 128,
			强化道具 = "化神境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 44
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 44
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 44
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 400,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 400,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(45, new 本命法宝属性类
		{
			强化进度 = 256,
			强化道具 = "化神境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 45
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 45
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 45
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 400,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 400,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(46, new 本命法宝属性类
		{
			强化进度 = 512,
			强化道具 = "化神境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 46
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 46
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 46
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 400,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 400,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(47, new 本命法宝属性类
		{
			强化进度 = 1024,
			强化道具 = "化神境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 47
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 47
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 47
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 400,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 400,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(48, new 本命法宝属性类
		{
			强化进度 = 2048,
			强化道具 = "化神境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 48
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 48
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 48
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 400,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 400,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(49, new 本命法宝属性类
		{
			强化进度 = 3072,
			强化道具 = "化神境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 49
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 49
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 49
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 400,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 400,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(50, new 本命法宝属性类
		{
			强化进度 = 4096,
			强化道具 = "化神境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 50
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 50
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 50
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(51, new 本命法宝属性类
		{
			强化进度 = 32,
			强化道具 = "炼虚境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 51
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 51
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 51
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(52, new 本命法宝属性类
		{
			强化进度 = 64,
			强化道具 = "炼虚境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 52
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 52
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 52
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(53, new 本命法宝属性类
		{
			强化进度 = 128,
			强化道具 = "炼虚境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 53
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 53
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 53
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(54, new 本命法宝属性类
		{
			强化进度 = 256,
			强化道具 = "炼虚境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 54
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 54
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 54
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(55, new 本命法宝属性类
		{
			强化进度 = 512,
			强化道具 = "炼虚境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 55
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 55
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 55
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(56, new 本命法宝属性类
		{
			强化进度 = 1024,
			强化道具 = "炼虚境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 56
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 56
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 56
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(57, new 本命法宝属性类
		{
			强化进度 = 2048,
			强化道具 = "炼虚境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 57
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 57
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 57
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(58, new 本命法宝属性类
		{
			强化进度 = 3072,
			强化道具 = "炼虚境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 58
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 58
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 58
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(59, new 本命法宝属性类
		{
			强化进度 = 4096,
			强化道具 = "炼虚境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 59
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 59
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 59
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(60, new 本命法宝属性类
		{
			强化进度 = 5120,
			强化道具 = "炼虚境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 60
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 60
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 60
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 600
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -60,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(61, new 本命法宝属性类
		{
			强化进度 = 64,
			强化道具 = "合体境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 61
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 61
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 61
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 600
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -60,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(62, new 本命法宝属性类
		{
			强化进度 = 128,
			强化道具 = "合体境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 62
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 62
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 62
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 600
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -60,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(63, new 本命法宝属性类
		{
			强化进度 = 256,
			强化道具 = "合体境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 63
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 63
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 63
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 600
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -60,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(64, new 本命法宝属性类
		{
			强化进度 = 512,
			强化道具 = "合体境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 64
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 64
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 64
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 600
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -60,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(65, new 本命法宝属性类
		{
			强化进度 = 1024,
			强化道具 = "合体境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 65
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 65
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 65
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 600
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -60,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(66, new 本命法宝属性类
		{
			强化进度 = 2048,
			强化道具 = "合体境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 66
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 66
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 66
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 600
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -60,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(67, new 本命法宝属性类
		{
			强化进度 = 3072,
			强化道具 = "合体境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 67
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 67
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 67
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 600
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -60,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(68, new 本命法宝属性类
		{
			强化进度 = 4096,
			强化道具 = "合体境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 68
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 68
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 68
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 600
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -60,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(69, new 本命法宝属性类
		{
			强化进度 = 5120,
			强化道具 = "合体境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 69
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 69
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 69
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 600
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -60,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(70, new 本命法宝属性类
		{
			强化进度 = 6144,
			强化道具 = "合体境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 70
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 70
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 70
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 700
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(71, new 本命法宝属性类
		{
			强化进度 = 128,
			强化道具 = "渡劫境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 71
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 71
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 71
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 700
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(72, new 本命法宝属性类
		{
			强化进度 = 256,
			强化道具 = "渡劫境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 72
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 72
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 72
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 700
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(73, new 本命法宝属性类
		{
			强化进度 = 512,
			强化道具 = "渡劫境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 73
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 73
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 73
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 700
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(74, new 本命法宝属性类
		{
			强化进度 = 1024,
			强化道具 = "渡劫境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 74
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 74
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 74
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 700
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(75, new 本命法宝属性类
		{
			强化进度 = 2048,
			强化道具 = "渡劫境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 75
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 75
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 75
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 700
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(76, new 本命法宝属性类
		{
			强化进度 = 3072,
			强化道具 = "渡劫境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 76
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 76
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 76
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 700
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(77, new 本命法宝属性类
		{
			强化进度 = 4096,
			强化道具 = "渡劫境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 77
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 77
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 77
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 700
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(78, new 本命法宝属性类
		{
			强化进度 = 5120,
			强化道具 = "渡劫境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 78
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 78
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 78
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 700
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(79, new 本命法宝属性类
		{
			强化进度 = 6144,
			强化道具 = "渡劫境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 79
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 79
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 79
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 700,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 700
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -70,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(80, new 本命法宝属性类
		{
			强化进度 = 7168,
			强化道具 = "渡劫境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 80
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 80
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 80
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 800
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(81, new 本命法宝属性类
		{
			强化进度 = 256,
			强化道具 = "大乘境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 81
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 81
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 81
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 800
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(82, new 本命法宝属性类
		{
			强化进度 = 512,
			强化道具 = "大乘境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 82
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 82
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 82
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 800
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(83, new 本命法宝属性类
		{
			强化进度 = 1024,
			强化道具 = "大乘境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 83
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 83
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 83
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 800
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(84, new 本命法宝属性类
		{
			强化进度 = 2048,
			强化道具 = "大乘境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 84
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 84
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 84
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 800
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(85, new 本命法宝属性类
		{
			强化进度 = 3072,
			强化道具 = "大乘境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 85
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 85
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 85
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 800
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(86, new 本命法宝属性类
		{
			强化进度 = 4096,
			强化道具 = "大乘境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 86
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 86
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 86
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 800
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(87, new 本命法宝属性类
		{
			强化进度 = 5120,
			强化道具 = "大乘境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 87
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 87
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 87
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 800
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(88, new 本命法宝属性类
		{
			强化进度 = 6144,
			强化道具 = "大乘境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 88
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 88
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 88
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 800
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(89, new 本命法宝属性类
		{
			强化进度 = 7168,
			强化道具 = "大乘境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 89
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 89
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 89
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 800,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 800
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -80,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(90, new 本命法宝属性类
		{
			强化进度 = 8192,
			强化道具 = "大乘境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 90
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 90
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 90
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 900
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.闪避,
					属性数值 = 100
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(91, new 本命法宝属性类
		{
			强化进度 = 512,
			强化道具 = "真仙境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 91
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 91
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 91
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 900
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.闪避,
					属性数值 = 200
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(92, new 本命法宝属性类
		{
			强化进度 = 1024,
			强化道具 = "真仙境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 92
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 92
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 92
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 900
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.闪避,
					属性数值 = 300
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(93, new 本命法宝属性类
		{
			强化进度 = 2048,
			强化道具 = "真仙境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 93
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 93
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 93
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 900
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.闪避,
					属性数值 = 400
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(94, new 本命法宝属性类
		{
			强化进度 = 3072,
			强化道具 = "真仙境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 94
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 94
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 94
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 900
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.闪避,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(95, new 本命法宝属性类
		{
			强化进度 = 4096,
			强化道具 = "真仙境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 95
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 95
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 95
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 900
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.闪避,
					属性数值 = 600
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(96, new 本命法宝属性类
		{
			强化进度 = 5120,
			强化道具 = "真仙境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 96
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 96
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 96
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 900
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.闪避,
					属性数值 = 700
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(97, new 本命法宝属性类
		{
			强化进度 = 6144,
			强化道具 = "真仙境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 97
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 97
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 97
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 900
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.闪避,
					属性数值 = 800
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(98, new 本命法宝属性类
		{
			强化进度 = 7168,
			强化道具 = "真仙境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 98
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 98
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 98
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 900
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.闪避,
					属性数值 = 900
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(99, new 本命法宝属性类
		{
			强化进度 = 8192,
			强化道具 = "真仙境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 99
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 99
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 99
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 900,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 900
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -90,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.闪避,
					属性数值 = 1000
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryAdd(100, new 本命法宝属性类
		{
			强化进度 = 9216,
			强化道具 = "真仙境生魂",
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 100
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有技能上升,
					属性数值 = 100
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有属性,
					属性数值 = 100
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 1000,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗性,
					属性数值 = 1000,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 1000
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
					属性数值 = -100,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
					属性数值 = -100,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
					属性数值 = -100,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.闪避,
					属性数值 = 2000
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.攻击效果,
					属性数值 = 100,
					Is比例 = true
				}
			}
		});
	}

	
	public void jYr2V2wvsY()
	{
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.功能开关 = true;
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is等级要求 = false;
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低等级 = 0;
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is道行要求 = false;
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低道行 = 0;
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is装备等级要求 = false;
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低装备等级 = 0;
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is改造要求 = false;
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低改造 = 0;
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.Clear();
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.装备升阶类型.Clear();
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.装备升阶类型.TryAdd(AllEnums.Equip类型.武器, value: true);
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.装备升阶类型.TryAdd(AllEnums.Equip类型.帽子, value: true);
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.装备升阶类型.TryAdd(AllEnums.Equip类型.衣服, value: true);
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.装备升阶类型.TryAdd(AllEnums.Equip类型.鞋子, value: true);
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.装备升阶类型.TryAdd(AllEnums.Equip类型.腰带, value: true);
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.装备升阶类型.TryAdd(AllEnums.Equip类型.玉佩, value: true);
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.装备升阶类型.TryAdd(AllEnums.Equip类型.手链, value: true);
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.装备升阶类型.TryAdd(AllEnums.Equip类型.手镯, value: true);
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.TryAdd(AllEnums.元神境界.练气境, new 升阶需求类
		{
			需求材料 = "练气升阶符",
			需求数量 = 1,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.TryAdd(AllEnums.元神境界.筑基境, new 升阶需求类
		{
			需求材料 = "筑基升阶符",
			需求数量 = 1,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.TryAdd(AllEnums.元神境界.金丹境, new 升阶需求类
		{
			需求材料 = "金丹升阶符",
			需求数量 = 1,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.TryAdd(AllEnums.元神境界.元婴境, new 升阶需求类
		{
			需求材料 = "元婴升阶符",
			需求数量 = 1,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.TryAdd(AllEnums.元神境界.化神境, new 升阶需求类
		{
			需求材料 = "化神升阶符",
			需求数量 = 1,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.TryAdd(AllEnums.元神境界.炼虚境, new 升阶需求类
		{
			需求材料 = "炼虚升阶符",
			需求数量 = 1,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.TryAdd(AllEnums.元神境界.合体境, new 升阶需求类
		{
			需求材料 = "合体升阶符",
			需求数量 = 1,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.TryAdd(AllEnums.元神境界.渡劫境, new 升阶需求类
		{
			需求材料 = "渡劫升阶符",
			需求数量 = 1,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.TryAdd(AllEnums.元神境界.大乘境, new 升阶需求类
		{
			需求材料 = "大乘升阶符",
			需求数量 = 1,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.TryAdd(AllEnums.元神境界.真仙境, new 升阶需求类
		{
			需求材料 = "真仙升阶符",
			需求数量 = 1,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.Clear();
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.力量, new int[11]
		{
			34, 68, 102, 136, 170, 204, 238, 282, 306, 340,
			374
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.物理伤害, new int[11]
		{
			4200, 8400, 12600, 16800, 21000, 25200, 29400, 33600, 37800, 42000,
			46200
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.准确, new int[11]
		{
			40, 80, 120, 160, 200, 240, 280, 320, 360, 400,
			440
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.体质, new int[11]
		{
			34, 68, 102, 136, 170, 204, 238, 282, 306, 340,
			374
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.气血, new int[11]
		{
			3800, 7600, 11400, 15200, 19000, 22800, 26600, 30400, 34200, 38000,
			41800
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.防御, new int[11]
		{
			1200, 2400, 3600, 4800, 6000, 7200, 8400, 9600, 10800, 12000,
			13200
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.灵力, new int[11]
		{
			34, 68, 102, 136, 170, 204, 238, 282, 306, 340,
			374
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.法术伤害, new int[11]
		{
			4200, 8400, 12600, 16800, 21000, 25200, 29400, 33600, 37800, 42000,
			46200
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.法力, new int[11]
		{
			7500, 15000, 22500, 30000, 37500, 45000, 52500, 60000, 67500, 75000,
			82500
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.敏捷, new int[11]
		{
			34, 68, 102, 136, 170, 204, 238, 282, 306, 340,
			374
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.速度, new int[11]
		{
			180, 360, 540, 720, 900, 1080, 1260, 1440, 1620, 1800,
			1980
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.金相性, new int[11]
		{
			5, 10, 15, 20, 25, 30, 35, 40, 45, 50,
			55
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.木相性, new int[11]
		{
			5, 10, 15, 20, 25, 30, 35, 40, 45, 50,
			55
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.水相性, new int[11]
		{
			5, 10, 15, 20, 25, 30, 35, 40, 45, 50,
			55
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.火相性, new int[11]
		{
			5, 10, 15, 20, 25, 30, 35, 40, 45, 50,
			55
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.土相性, new int[11]
		{
			5, 10, 15, 20, 25, 30, 35, 40, 45, 50,
			55
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.金抗性, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.木抗性, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.水抗性, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.火抗性, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.土抗性, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.抗中毒, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.抗冰冻, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.抗昏睡, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.抗遗忘, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.抗混乱, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.反击率, new int[11]
		{
			30, 30, 30, 30, 60, 60, 60, 90, 90, 90,
			100
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.连击率, new int[11]
		{
			30, 30, 30, 30, 60, 60, 60, 90, 90, 90,
			100
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.物理必杀率, new int[11]
		{
			30, 30, 30, 30, 60, 60, 60, 90, 90, 90,
			100
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.反震度, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.反震率, new int[11]
		{
			30, 30, 30, 30, 60, 60, 60, 90, 90, 90,
			100
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.破防, new int[11]
		{
			30, 30, 30, 30, 60, 60, 60, 90, 90, 90,
			100
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.破防率, new int[11]
		{
			30, 30, 30, 30, 60, 60, 60, 90, 90, 90,
			100
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗金, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗木, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗水, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗火, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗土, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗遗忘, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗中毒, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗冰冻, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗昏睡, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗混乱, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力克金, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力克木, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力克水, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力克火, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力克土, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力中毒, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力昏睡, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力遗忘, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力混乱, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力冰冻, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强金法伤害, new int[11]
		{
			10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
			110
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强木法伤害, new int[11]
		{
			10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
			110
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强水法伤害, new int[11]
		{
			10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
			110
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强火法伤害, new int[11]
		{
			10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
			110
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强土法伤害, new int[11]
		{
			10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
			110
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视所有抗性, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视所有抗异常, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.解除遗忘状态, new int[11]
		{
			15, 30, 45, 60, 75, 90, 105, 120, 135, 150,
			165
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.解除中毒状态, new int[11]
		{
			15, 30, 45, 60, 75, 90, 105, 120, 135, 150,
			165
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.解除冰冻状态, new int[11]
		{
			15, 30, 45, 60, 75, 90, 105, 120, 135, 150,
			165
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.解除昏睡状态, new int[11]
		{
			15, 30, 45, 60, 75, 90, 105, 120, 135, 150,
			165
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.解除混乱状态, new int[11]
		{
			15, 30, 45, 60, 75, 90, 105, 120, 135, 150,
			165
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.所有属性, new int[11]
		{
			27, 56, 84, 112, 140, 168, 196, 224, 252, 280,
			308
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.所有相性, new int[11]
		{
			5, 10, 15, 20, 25, 30, 35, 40, 45, 50,
			55
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.所有抗性, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.抗所有异常, new int[11]
		{
			15, 30, 45, 60, 75, 90, 105, 120, 135, 150,
			165
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.所有技能上升, new int[11]
		{
			10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
			110
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标连击, new int[11]
		{
			30, 30, 30, 30, 60, 60, 60, 90, 90, 90,
			100
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标物理必杀, new int[11]
		{
			30, 30, 30, 30, 60, 60, 60, 90, 90, 90,
			100
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强物理伤害, new int[11]
		{
			10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
			110
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.法术必杀率, new int[11]
		{
			30, 30, 30, 30, 60, 60, 60, 90, 90, 90,
			100
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标法术必杀, new int[11]
		{
			30, 30, 30, 30, 60, 60, 60, 90, 90, 90,
			100
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.闪避, new int[11]
		{
			180, 360, 540, 720, 900, 1080, 1260, 1440, 1620, 1800,
			1980
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.抗镇魂, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.抗化功, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.抗水牢, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.抗锁灵, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.抗迷心, new int[11]
		{
			20, 40, 60, 80, 100, 120, 140, 160, 180, 200,
			220
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗镇魂, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗化功, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗水牢, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗锁灵, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.忽视目标抗迷心, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.解除镇魂状态, new int[11]
		{
			15, 30, 45, 60, 75, 90, 105, 120, 135, 150,
			165
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.解除化功状态, new int[11]
		{
			15, 30, 45, 60, 75, 90, 105, 120, 135, 150,
			165
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.解除水牢状态, new int[11]
		{
			15, 30, 45, 60, 75, 90, 105, 120, 135, 150,
			165
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.解除锁灵状态, new int[11]
		{
			15, 30, 45, 60, 75, 90, 105, 120, 135, 150,
			165
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.解除迷心状态, new int[11]
		{
			15, 30, 45, 60, 75, 90, 105, 120, 135, 150,
			165
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力镇魂, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力化功, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力水牢, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力锁灵, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
		Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryAdd(AllEnums.属性名字Type.强力迷心, new int[11]
		{
			30, 60, 90, 120, 150, 180, 210, 240, 270, 300,
			330
		});
	}

	
	public void ENO2kyr212()
	{
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.功能开关 = true;
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.Is等级要求 = false;
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.最低等级 = 0;
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.Is武学要求 = false;
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.最低武学 = 0;
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求 = 200;
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级 = 1000;
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.最低消耗数量 = 1;
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.递增消耗倍数 = 1;
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.随机升级道具 = "基础心法升级卷轴";
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.气血升级道具 = "气血心法升级卷轴";
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.速度升级道具 = "速度心法升级卷轴";
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.攻击升级道具 = "攻击心法升级卷轴";
		Singleton<全局变量类>.I.元神系统配置.心法升级配置.防御升级道具 = "防御心法升级卷轴";
	}

	
	public void Hdr20l4823()
	{
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.功能开关 = true;
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(10001, new 引灵幡属性列表类
		{
			附灵道具 = "武力附灵符",
			需求数量 = 1,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(10002, new 引灵幡属性列表类
		{
			附灵道具 = "武力附灵符",
			需求数量 = 2,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.土相性,
					属性数值 = 5
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(10003, new 引灵幡属性列表类
		{
			附灵道具 = "武力附灵符",
			需求数量 = 3,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.土相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.力量,
					属性数值 = 32
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(10004, new 引灵幡属性列表类
		{
			附灵道具 = "武力附灵符",
			需求数量 = 4,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.土相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.力量,
					属性数值 = 32
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 20,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(10005, new 引灵幡属性列表类
		{
			附灵道具 = "武力附灵符",
			需求数量 = 5,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.土相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.力量,
					属性数值 = 32
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 20,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 200
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(10006, new 引灵幡属性列表类
		{
			附灵道具 = "武力附灵符",
			需求数量 = 6,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 10
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.土相性,
					属性数值 = 10
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.力量,
					属性数值 = 64
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 30,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 300
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(10007, new 引灵幡属性列表类
		{
			附灵道具 = "武力附灵符",
			需求数量 = 7,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 20
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.土相性,
					属性数值 = 20
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.力量,
					属性数值 = 96
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 40,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 400
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(10008, new 引灵幡属性列表类
		{
			附灵道具 = "武力附灵符",
			需求数量 = 8,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 30
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.土相性,
					属性数值 = 30
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.力量,
					属性数值 = 128
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 50,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(10009, new 引灵幡属性列表类
		{
			附灵道具 = "武力附灵符",
			需求数量 = 9,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 40
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.土相性,
					属性数值 = 40
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.力量,
					属性数值 = 160
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 60,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 600
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(10010, new 引灵幡属性列表类
		{
			附灵道具 = "武力附灵符",
			需求数量 = 10,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 50
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.土相性,
					属性数值 = 50
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.力量,
					属性数值 = 192
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 70,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 700
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(20001, new 引灵幡属性列表类
		{
			附灵道具 = "仙术附灵符",
			需求数量 = 1,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(20002, new 引灵幡属性列表类
		{
			附灵道具 = "仙术附灵符",
			需求数量 = 2,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.金相性,
					属性数值 = 5
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(20003, new 引灵幡属性列表类
		{
			附灵道具 = "仙术附灵符",
			需求数量 = 3,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.金相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.灵力,
					属性数值 = 32
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(20004, new 引灵幡属性列表类
		{
			附灵道具 = "仙术附灵符",
			需求数量 = 4,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.金相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.灵力,
					属性数值 = 32
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 20,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(20005, new 引灵幡属性列表类
		{
			附灵道具 = "仙术附灵符",
			需求数量 = 5,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.金相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.灵力,
					属性数值 = 32
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 20,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 200
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(20006, new 引灵幡属性列表类
		{
			附灵道具 = "仙术附灵符",
			需求数量 = 6,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 10
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.金相性,
					属性数值 = 10
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.灵力,
					属性数值 = 64
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 30,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 300
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(20007, new 引灵幡属性列表类
		{
			附灵道具 = "仙术附灵符",
			需求数量 = 7,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 20
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.金相性,
					属性数值 = 20
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.灵力,
					属性数值 = 96
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 40,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 400
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(20008, new 引灵幡属性列表类
		{
			附灵道具 = "仙术附灵符",
			需求数量 = 8,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 30
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.金相性,
					属性数值 = 30
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.灵力,
					属性数值 = 128
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 50,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(20009, new 引灵幡属性列表类
		{
			附灵道具 = "仙术附灵符",
			需求数量 = 9,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 40
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.金相性,
					属性数值 = 40
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.灵力,
					属性数值 = 160
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 60,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 600
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(20010, new 引灵幡属性列表类
		{
			附灵道具 = "仙术附灵符",
			需求数量 = 10,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 50
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.金相性,
					属性数值 = 50
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.灵力,
					属性数值 = 192
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
					属性数值 = 70,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.准确,
					属性数值 = 700
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(30001, new 引灵幡属性列表类
		{
			附灵道具 = "防护附灵符",
			需求数量 = 1,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(30002, new 引灵幡属性列表类
		{
			附灵道具 = "防护附灵符",
			需求数量 = 2,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.木相性,
					属性数值 = 5
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(30003, new 引灵幡属性列表类
		{
			附灵道具 = "防护附灵符",
			需求数量 = 3,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.木相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.体质,
					属性数值 = 32
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(30004, new 引灵幡属性列表类
		{
			附灵道具 = "防护附灵符",
			需求数量 = 4,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.木相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.体质,
					属性数值 = 32
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.反震率,
					属性数值 = 20,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(30005, new 引灵幡属性列表类
		{
			附灵道具 = "防护附灵符",
			需求数量 = 5,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.木相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.体质,
					属性数值 = 32
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.反震率,
					属性数值 = 20,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.反震度,
					属性数值 = 50
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(30006, new 引灵幡属性列表类
		{
			附灵道具 = "防护附灵符",
			需求数量 = 6,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 10
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.木相性,
					属性数值 = 10
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.体质,
					属性数值 = 64
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.反震率,
					属性数值 = 30,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.反震度,
					属性数值 = 100
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(30007, new 引灵幡属性列表类
		{
			附灵道具 = "防护附灵符",
			需求数量 = 7,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 20
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.木相性,
					属性数值 = 20
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.体质,
					属性数值 = 96
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.反震率,
					属性数值 = 40,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.反震度,
					属性数值 = 200
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(30008, new 引灵幡属性列表类
		{
			附灵道具 = "防护附灵符",
			需求数量 = 8,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 30
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.木相性,
					属性数值 = 30
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.体质,
					属性数值 = 128
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.反震率,
					属性数值 = 50,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.反震度,
					属性数值 = 300
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(30009, new 引灵幡属性列表类
		{
			附灵道具 = "防护附灵符",
			需求数量 = 9,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 40
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.木相性,
					属性数值 = 40
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.体质,
					属性数值 = 160
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.反震率,
					属性数值 = 60,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.反震度,
					属性数值 = 400
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(30010, new 引灵幡属性列表类
		{
			附灵道具 = "防护附灵符",
			需求数量 = 10,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 50
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.木相性,
					属性数值 = 50
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.体质,
					属性数值 = 192
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.反震率,
					属性数值 = 70,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.反震度,
					属性数值 = 500
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(40001, new 引灵幡属性列表类
		{
			附灵道具 = "身法附灵符",
			需求数量 = 1,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(40002, new 引灵幡属性列表类
		{
			附灵道具 = "身法附灵符",
			需求数量 = 2,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.火相性,
					属性数值 = 5
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(40003, new 引灵幡属性列表类
		{
			附灵道具 = "身法附灵符",
			需求数量 = 3,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.火相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.敏捷,
					属性数值 = 32
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(40004, new 引灵幡属性列表类
		{
			附灵道具 = "身法附灵符",
			需求数量 = 4,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.火相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.敏捷,
					属性数值 = 32
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.速度,
					属性数值 = 100,
					Is比例 = true
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(40005, new 引灵幡属性列表类
		{
			附灵道具 = "身法附灵符",
			需求数量 = 5,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.火相性,
					属性数值 = 5
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.敏捷,
					属性数值 = 32
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.速度,
					属性数值 = 100,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 20
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(40006, new 引灵幡属性列表类
		{
			附灵道具 = "身法附灵符",
			需求数量 = 6,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 10
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.火相性,
					属性数值 = 10
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.敏捷,
					属性数值 = 64
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.速度,
					属性数值 = 200,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 40
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(40007, new 引灵幡属性列表类
		{
			附灵道具 = "身法附灵符",
			需求数量 = 7,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 20
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.火相性,
					属性数值 = 20
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.敏捷,
					属性数值 = 96
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.速度,
					属性数值 = 300,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 60
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(40008, new 引灵幡属性列表类
		{
			附灵道具 = "身法附灵符",
			需求数量 = 8,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 30
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.火相性,
					属性数值 = 30
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.敏捷,
					属性数值 = 128
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.速度,
					属性数值 = 400,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 80
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(40009, new 引灵幡属性列表类
		{
			附灵道具 = "身法附灵符",
			需求数量 = 9,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 40
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.火相性,
					属性数值 = 40
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.敏捷,
					属性数值 = 160
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.速度,
					属性数值 = 500,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 100
				}
			}
		});
		Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryAdd(40010, new 引灵幡属性列表类
		{
			附灵道具 = "身法附灵符",
			需求数量 = 10,
			属性列表 = new List<通用属性类>
			{
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.所有相性,
					属性数值 = 50
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.火相性,
					属性数值 = 50
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.敏捷,
					属性数值 = 192
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.速度,
					属性数值 = 600,
					Is比例 = true
				},
				new 通用属性类
				{
					属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
					属性数值 = 120
				}
			}
		});
	}

	
	internal void j2J2Ox7As5()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("元神系统配置类.json")))
			{
				Singleton<全局变量类>.I.元神系统配置 = JsonConvert.DeserializeObject<元神系统配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("元神系统配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.元神系统配置 = new 元神系统配置类();
				asX2yY8cuj();
				sNJ2CwwU5I();
				jYr2V2wvsY();
				ENO2kyr212();
				Hdr20l4823();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("元神系统配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.元神系统配置, Formatting.Indented));
			}
			AYW29EI84m();
			foreach (KeyValuePair<AllEnums.元神境界, 元神特效配置类> item in Pihmi6fRa9)
			{
				if (Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue(item.Key, out 元神境界配置类 value))
				{
					value.境界特效 = item.Value;
				}
			}
			IkymDsp1jm.Clear();
			IkymDsp1jm.Append("|");
			StringBuilder ikymDsp1jm;
			StringBuilder.AppendInterpolatedStringHandler handler;
			foreach (元神境界配置类 value3 in Singleton<全局变量类>.I.元神系统配置.境界列表.Values)
			{
				ikymDsp1jm = IkymDsp1jm;
				StringBuilder stringBuilder = ikymDsp1jm;
				handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, ikymDsp1jm);
				handler.AppendFormatted(value3.突破加成配置.突破道具);
				handler.AppendLiteral("|");
				stringBuilder.Append(ref handler);
				foreach (string key in value3.增加突破几率道具.Keys)
				{
					ikymDsp1jm = IkymDsp1jm;
					StringBuilder stringBuilder2 = ikymDsp1jm;
					handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, ikymDsp1jm);
					handler.AppendFormatted(key);
					handler.AppendLiteral("|");
					stringBuilder2.Append(ref handler);
				}
			}
			Yp6mjOM9qh.Clear();
			Yp6mjOM9qh.Append("|");
			for (int i = 1; i <= 10; i++)
			{
				if (Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryGetValue(i * 10, out 本命法宝属性类 value2))
				{
					ikymDsp1jm = Yp6mjOM9qh;
					StringBuilder stringBuilder3 = ikymDsp1jm;
					handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, ikymDsp1jm);
					handler.AppendFormatted(value2.强化道具);
					handler.AppendLiteral("|");
					stringBuilder3.Append(ref handler);
				}
			}
			yQ0mlWibO6.Clear();
			ikymDsp1jm = yQ0mlWibO6;
			StringBuilder stringBuilder4 = ikymDsp1jm;
			handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, ikymDsp1jm);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.转化道具);
			handler.AppendLiteral("|");
			stringBuilder4.Append(ref handler);
			foreach (升阶需求类 value4 in Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.Values)
			{
				ikymDsp1jm = yQ0mlWibO6;
				StringBuilder stringBuilder5 = ikymDsp1jm;
				handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, ikymDsp1jm);
				handler.AppendFormatted(value4.需求材料);
				handler.AppendLiteral("|");
				stringBuilder5.Append(ref handler);
			}
			sK3m8a9JNp.Clear();
			ikymDsp1jm = sK3m8a9JNp;
			StringBuilder stringBuilder6 = ikymDsp1jm;
			handler = new StringBuilder.AppendInterpolatedStringHandler(6, 5, ikymDsp1jm);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.心法升级配置.随机升级道具);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.心法升级配置.气血升级道具);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.心法升级配置.速度升级道具);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.心法升级配置.攻击升级道具);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.心法升级配置.防御升级道具);
			handler.AppendLiteral("|");
			stringBuilder6.Append(ref handler);
			sPhmoeHQ4M.Clear();
			ikymDsp1jm = sPhmoeHQ4M;
			StringBuilder stringBuilder7 = ikymDsp1jm;
			handler = new StringBuilder.AppendInterpolatedStringHandler(5, 4, ikymDsp1jm);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.一阶灵幡名字);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.二阶灵幡名字);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.三阶灵幡名字);
			handler.AppendLiteral("|");
			handler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.四阶灵幡名字);
			handler.AppendLiteral("|");
			stringBuilder7.Append(ref handler);
			xh4mILM5j1.Clear();
			xh4mILM5j1.Append("|");
			foreach (元神境界配置类 value5 in Singleton<全局变量类>.I.元神系统配置.境界列表.Values)
			{
				ikymDsp1jm = xh4mILM5j1;
				StringBuilder stringBuilder8 = ikymDsp1jm;
				handler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, ikymDsp1jm);
				handler.AppendFormatted(value5.突破特殊需求.击杀BOSS要求);
				handler.AppendLiteral("|");
				stringBuilder8.Append(ref handler);
			}
		}
		catch (Exception ex)
		{
			Log.Error("元神系统配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void IJQ2QqXI7w()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("元神系统配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.元神系统配置, Formatting.Indented));
			Log.Debug("元神系统配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("元神系统配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string cjR2E2RJAj()
	{
		j2J2Ox7As5();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.元神系统配置, Formatting.Indented);
	}

	
	public void evk23G9j1A(string P_0)
	{
		Singleton<全局变量类>.I.元神系统配置 = JsonConvert.DeserializeObject<元神系统配置类>(P_0);
		IJQ2QqXI7w();
	}

	
	public static 元神境界配置类 wIn2YFWhMH(AllEnums.元神境界 P_0, bool P_1 = false)
	{
		Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue(P_0, out 元神境界配置类 value);
		if (!P_1)
		{
			return value;
		}
		if (value == null)
		{
			return null;
		}
		Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue(value.突破境界, out 元神境界配置类 value2);
		return value2;
	}

	
	public void N1k2pMUNPH(MyNATSocketClient P_0)
	{
		try
		{
			if (o5DmWnO5ND() && P_0.user.存档数据.元神存档.当前境界 == AllEnums.元神境界.凡人境 && Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue(AllEnums.元神境界.凡人境, out 元神境界配置类 value))
			{
				if (Singleton<全局变量类>.I.元神系统配置.禁止灵气存储)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, 0, true, "[练气境]重置");
				}
				P_0.user.存档数据.元神存档.当前境界 = value.突破境界;
				P_0.user.存档数据.元神存档.突破境界 = value.突破境界 + 1;
				P_0.user.存档数据.元神存档.突破几率 = 0;
				P_0.user.存档数据.元神存档.突破使用道具 = string.Empty;
				P_0.user.存档数据.元神存档.增加几率道具 = string.Empty;
				P_0.user.存档数据.元神存档.突破中 = false;
				P_0.user.存档数据.元神存档.击杀BOSS达成 = string.Empty;
				P_0.user.存档数据.元神存档.获取道具达成 = string.Empty;
				if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.元神系统配置.初始赠送礼包))
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.元神系统配置.初始赠送礼包, AllEnums.指令Type.无, 1, false, "凡人初始赠送");
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#Y欢迎进入道友来挖宝世界#G由于道友位于666位进入挖宝世界，特此获得了中州天道馈赠的#R" + Singleton<全局变量类>.I.元神系统配置.初始赠送礼包 + "#G，成功引气入体，踏入练气境！"));
				}
				Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), "title", $"{P_0.user.存档数据.元神存档.当前境界}", "admin_set_attrib");
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("步骤_1_首次上线-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public async Task<byte[]> hyd21cIsmI(MyNATSocketClient P_0, bool P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals146 = new _003C_003Ec__DisplayClass22_0();
			CS_0024_003C_003E8__locals146.xKTy31WpCq = wIn2YFWhMH(P_0.user.存档数据.元神存档.当前境界);
			元神境界配置类 下一境界 = wIn2YFWhMH(P_0.user.存档数据.元神存档.当前境界, true);
			Singleton<全局变量类>.I.会话Dict.Values.Any( (MyNATSocketClient x) => x.user.存档数据.元神存档.当前境界 == CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
			if (P_1)
			{
				if (Singleton<全局变量类>.I.元神系统配置.禁止灵气存储)
				{
					WdAPI i = Singleton<WdAPI>.I;
					string empty = string.Empty;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[");
					defaultInterpolatedStringHandler.AppendFormatted((CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界 < AllEnums.元神境界.真仙境) ? CS_0024_003C_003E8__locals146.xKTy31WpCq.突破境界 : AllEnums.元神境界.真仙境);
					defaultInterpolatedStringHandler.AppendLiteral("]突破成功重置");
					i.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, empty, AllEnums.指令Type.无, 0, true, defaultInterpolatedStringHandler.ToStringAndClear());
				}
				else
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					string empty2 = string.Empty;
					int num = -P_0.user.存档数据.元神存档.JkJIRtbr1R();
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[");
					defaultInterpolatedStringHandler.AppendFormatted((CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界 < AllEnums.元神境界.真仙境) ? CS_0024_003C_003E8__locals146.xKTy31WpCq.突破境界 : AllEnums.元神境界.真仙境);
					defaultInterpolatedStringHandler.AppendLiteral("]突破成功重置");
					i2.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, empty2, AllEnums.指令Type.无, num, false, defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			else
			{
				WdAPI i3 = Singleton<WdAPI>.I;
				string empty3 = string.Empty;
				int num2 = -(int)((float)P_0.user.存档数据.元神存档.JkJIRtbr1R() / 100f * (float)CS_0024_003C_003E8__locals146.xKTy31WpCq.突破失败受伤程度);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[");
				defaultInterpolatedStringHandler.AppendFormatted((CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界 < AllEnums.元神境界.真仙境) ? CS_0024_003C_003E8__locals146.xKTy31WpCq.突破境界 : AllEnums.元神境界.真仙境);
				defaultInterpolatedStringHandler.AppendLiteral("]突破失败重置");
				i3.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, empty3, AllEnums.指令Type.无, num2, false, defaultInterpolatedStringHandler.ToStringAndClear());
			}
			P_0.user.存档数据.元神存档.突破几率 = 0;
			P_0.user.存档数据.元神存档.突破使用道具 = string.Empty;
			P_0.user.存档数据.元神存档.增加几率道具 = string.Empty;
			P_0.user.存档数据.元神存档.突破中 = false;
			P_0.user.存档数据.元神存档.击杀BOSS达成 = (P_1 ? string.Empty : ((CS_0024_003C_003E8__locals146.xKTy31WpCq.突破特殊需求.Is击杀BOSS要求 && CS_0024_003C_003E8__locals146.xKTy31WpCq.突破特殊需求.破境BOSS只需击杀一次) ? P_0.user.存档数据.元神存档.击杀BOSS达成 : string.Empty));
			P_0.user.存档数据.元神存档.获取道具达成 = string.Empty;
			if (!P_1)
			{
				WdAPI i4 = Singleton<WdAPI>.I;
				string text = "很遗憾，突破失败！";
				string text2;
				if (CS_0024_003C_003E8__locals146.xKTy31WpCq.突破失败受伤程度 <= 0)
				{
					text2 = string.Empty;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler.AppendLiteral("损失了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破失败受伤程度);
					defaultInterpolatedStringHandler.AppendLiteral("%#n的灵气值。");
					text2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				P_0.C_Send(i4.提示_提醒和杂项公告(text + text2));
				return null;
			}
			P_0.user.存档数据.元神存档.当前境界 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破境界;
			P_0.user.存档数据.元神存档.突破境界 = 下一境界?.突破境界 ?? CS_0024_003C_003E8__locals146.xKTy31WpCq.突破境界;
			StringBuilder 提示文本 = new StringBuilder();
			StringBuilder stringBuilder = 提示文本;
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(15, 1, stringBuilder);
			handler.AppendLiteral("#64成功突破，晋级#G");
			handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破境界);
			handler.AppendLiteral("#n！");
			stringBuilder2.Append(ref handler);
			if (!P_0.user.存档数据.元神存档.已获得突破加成.ContainsKey(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界))
			{
				提示文本.Append("角色加成提升：#Y");
				if (CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型 != AllEnums.数值Type.无 && CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量 > 0)
				{
					switch (CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型)
					{
					case AllEnums.数值Type.道行:
					{
						WdAPI i16 = Singleton<WdAPI>.I;
						string empty12 = string.Empty;
						int num3 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量 * 360;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 4);
						defaultInterpolatedStringHandler.AppendLiteral("[个人突破-");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						i16.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, empty12, AllEnums.指令Type.tao, num3, false, defaultInterpolatedStringHandler.ToStringAndClear());
						stringBuilder = 提示文本;
						StringBuilder stringBuilder14 = stringBuilder;
						handler = new StringBuilder.AppendInterpolatedStringHandler(7, 1, stringBuilder);
						handler.AppendLiteral("#r道行提升");
						handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						handler.AppendLiteral("年");
						stringBuilder14.Append(ref handler);
						break;
					}
					case AllEnums.数值Type.声望:
					{
						WdAPI i15 = Singleton<WdAPI>.I;
						string empty11 = string.Empty;
						int 奖励数量9 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 4);
						defaultInterpolatedStringHandler.AppendLiteral("[个人突破-");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						i15.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, empty11, AllEnums.指令Type.reputation, 奖励数量9, false, defaultInterpolatedStringHandler.ToStringAndClear());
						stringBuilder = 提示文本;
						StringBuilder stringBuilder13 = stringBuilder;
						handler = new StringBuilder.AppendInterpolatedStringHandler(7, 1, stringBuilder);
						handler.AppendLiteral("#r声望提升");
						handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						handler.AppendLiteral("点");
						stringBuilder13.Append(ref handler);
						break;
					}
					case AllEnums.数值Type.金元宝:
					{
						WdAPI i14 = Singleton<WdAPI>.I;
						string empty10 = string.Empty;
						int 奖励数量8 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 4);
						defaultInterpolatedStringHandler.AppendLiteral("[个人突破-");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						i14.PndoGw5lW7(P_0, AllEnums.发送数据Type.金元宝, empty10, AllEnums.指令Type.无, 奖励数量8, false, defaultInterpolatedStringHandler.ToStringAndClear());
						stringBuilder = 提示文本;
						StringBuilder stringBuilder12 = stringBuilder;
						handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder);
						handler.AppendLiteral("#r金元宝提升");
						handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						handler.AppendLiteral("点");
						stringBuilder12.Append(ref handler);
						break;
					}
					case AllEnums.数值Type.银元宝:
					{
						WdAPI i13 = Singleton<WdAPI>.I;
						string empty9 = string.Empty;
						int 奖励数量7 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 4);
						defaultInterpolatedStringHandler.AppendLiteral("[个人突破-");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						i13.PndoGw5lW7(P_0, AllEnums.发送数据Type.银元宝, empty9, AllEnums.指令Type.无, 奖励数量7, false, defaultInterpolatedStringHandler.ToStringAndClear());
						stringBuilder = 提示文本;
						StringBuilder stringBuilder11 = stringBuilder;
						handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder);
						handler.AppendLiteral("#r银元宝提升");
						handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						handler.AppendLiteral("点");
						stringBuilder11.Append(ref handler);
						break;
					}
					case AllEnums.数值Type.金钱:
					{
						WdAPI i12 = Singleton<WdAPI>.I;
						string empty8 = string.Empty;
						int 奖励数量6 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 4);
						defaultInterpolatedStringHandler.AppendLiteral("[个人突破-");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						i12.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, empty8, AllEnums.指令Type.cash, 奖励数量6, false, defaultInterpolatedStringHandler.ToStringAndClear());
						stringBuilder = 提示文本;
						StringBuilder stringBuilder10 = stringBuilder;
						handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder);
						handler.AppendLiteral("#r游戏币提升");
						handler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量));
						handler.AppendLiteral("文");
						stringBuilder10.Append(ref handler);
						break;
					}
					case AllEnums.数值Type.累充点:
					{
						WdAPI i11 = Singleton<WdAPI>.I;
						string empty7 = string.Empty;
						int 奖励数量5 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 4);
						defaultInterpolatedStringHandler.AppendLiteral("[个人突破-");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						i11.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, empty7, AllEnums.指令Type.无, 奖励数量5, false, defaultInterpolatedStringHandler.ToStringAndClear());
						stringBuilder = 提示文本;
						StringBuilder stringBuilder9 = stringBuilder;
						handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder);
						handler.AppendLiteral("#r累充点提升");
						handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						handler.AppendLiteral("点");
						stringBuilder9.Append(ref handler);
						break;
					}
					case AllEnums.数值Type.道具:
					{
						WdAPI i10 = Singleton<WdAPI>.I;
						string 奖励名字3 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励名字;
						int 奖励数量4 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 4);
						defaultInterpolatedStringHandler.AppendLiteral("[个人突破-");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						i10.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 奖励名字3, AllEnums.指令Type.无, 奖励数量4, false, defaultInterpolatedStringHandler.ToStringAndClear());
						stringBuilder = 提示文本;
						StringBuilder stringBuilder8 = stringBuilder;
						handler = new StringBuilder.AppendInterpolatedStringHandler(3, 2, stringBuilder);
						handler.AppendLiteral("#r");
						handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励名字);
						handler.AppendLiteral("*");
						handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						stringBuilder8.Append(ref handler);
						break;
					}
					case AllEnums.数值Type.南极点:
					{
						WdAPI i9 = Singleton<WdAPI>.I;
						string empty6 = string.Empty;
						int 奖励数量3 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 4);
						defaultInterpolatedStringHandler.AppendLiteral("[个人突破-");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						i9.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, empty6, AllEnums.指令Type.无, 奖励数量3, false, defaultInterpolatedStringHandler.ToStringAndClear());
						stringBuilder = 提示文本;
						StringBuilder stringBuilder7 = stringBuilder;
						handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder);
						handler.AppendLiteral("#r南极点提升");
						handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						handler.AppendLiteral("点");
						stringBuilder7.Append(ref handler);
						break;
					}
					case AllEnums.数值Type.宠物:
					{
						WdAPI i8 = Singleton<WdAPI>.I;
						string 奖励名字2 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励名字;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 4);
						defaultInterpolatedStringHandler.AppendLiteral("[个人突破-");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型);
						defaultInterpolatedStringHandler.AppendLiteral(" * ");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						i8.PndoGw5lW7(P_0, AllEnums.发送数据Type.宠物, 奖励名字2, AllEnums.指令Type.无, 1, false, defaultInterpolatedStringHandler.ToStringAndClear());
						stringBuilder = 提示文本;
						StringBuilder stringBuilder6 = stringBuilder;
						handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder);
						handler.AppendLiteral("#r");
						handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励名字);
						handler.AppendLiteral("*1只");
						stringBuilder6.Append(ref handler);
						break;
					}
					case AllEnums.数值Type.坐骑:
					{
						WdAPI i7 = Singleton<WdAPI>.I;
						string 奖励名字 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励名字;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 4);
						defaultInterpolatedStringHandler.AppendLiteral("[个人突破-");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型);
						defaultInterpolatedStringHandler.AppendLiteral(" * ");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						i7.PndoGw5lW7(P_0, AllEnums.发送数据Type.坐骑, 奖励名字, AllEnums.指令Type.无, 1, false, defaultInterpolatedStringHandler.ToStringAndClear());
						stringBuilder = 提示文本;
						StringBuilder stringBuilder5 = stringBuilder;
						handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder);
						handler.AppendLiteral("#r");
						handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励名字);
						handler.AppendLiteral("*1只");
						stringBuilder5.Append(ref handler);
						break;
					}
					case AllEnums.数值Type.奇宝点:
					{
						WdAPI i6 = Singleton<WdAPI>.I;
						string empty5 = string.Empty;
						int 奖励数量2 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 4);
						defaultInterpolatedStringHandler.AppendLiteral("[个人突破-");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						i6.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, empty5, AllEnums.指令Type.无, 奖励数量2, false, defaultInterpolatedStringHandler.ToStringAndClear());
						stringBuilder = 提示文本;
						StringBuilder stringBuilder4 = stringBuilder;
						handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder);
						handler.AppendLiteral("#r奇宝点提升");
						handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						handler.AppendLiteral("点");
						stringBuilder4.Append(ref handler);
						break;
					}
					case AllEnums.数值Type.灵气值:
					{
						WdAPI i5 = Singleton<WdAPI>.I;
						string empty4 = string.Empty;
						int 奖励数量 = CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 4);
						defaultInterpolatedStringHandler.AppendLiteral("[个人突破-");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
						defaultInterpolatedStringHandler.AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励类型);
						defaultInterpolatedStringHandler.AppendLiteral("*");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						i5.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, empty4, AllEnums.指令Type.无, 奖励数量, false, defaultInterpolatedStringHandler.ToStringAndClear());
						stringBuilder = 提示文本;
						StringBuilder stringBuilder3 = stringBuilder;
						handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder);
						handler.AppendLiteral("#r灵气值提升");
						handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.奖励数量);
						handler.AppendLiteral("点");
						stringBuilder3.Append(ref handler);
						break;
					}
					}
				}
				List<string[]> list = new List<string[]>();
				P_0.user.存档数据.元神存档.已获得突破加成.TryAdd(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界, CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置);
				if (CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.所有相性 != 0)
				{
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(AllEnums.属性名字Type.所有相性, CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.所有相性, out var text3);
					string[] array = new string[2];
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.all_polar);
					array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array[1] = text3;
					list.Add(array);
					stringBuilder = 提示文本;
					StringBuilder stringBuilder15 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder);
					handler.AppendLiteral("#r#L所有相性 ");
					handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.所有相性);
					handler.AppendLiteral(" 增加#n");
					stringBuilder15.Append(ref handler);
				}
				if (CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.所有属性 != 0)
				{
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(AllEnums.属性名字Type.所有属性, CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.所有属性, out var text4);
					string[] array2 = new string[2];
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.all_attrib);
					array2[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[1] = text4;
					list.Add(array2);
					stringBuilder = 提示文本;
					StringBuilder stringBuilder16 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder);
					handler.AppendLiteral("#r#L所有属性 ");
					handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.所有属性);
					handler.AppendLiteral(" 增加#n");
					stringBuilder16.Append(ref handler);
				}
				if (CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.物理伤害 != 0)
				{
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(AllEnums.属性名字Type.物理伤害, CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.物理伤害, out var text5);
					string[] array3 = new string[2];
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.phy_power);
					array3[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array3[1] = text5;
					list.Add(array3);
					stringBuilder = 提示文本;
					StringBuilder stringBuilder17 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder);
					handler.AppendLiteral("#r#L物理伤害 ");
					handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.物理伤害);
					handler.AppendLiteral(" 增加#n");
					stringBuilder17.Append(ref handler);
				}
				if (CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.法术伤害 != 0)
				{
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(AllEnums.属性名字Type.法术伤害, CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.法术伤害, out var text6);
					string[] array4 = new string[2];
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.mag_power);
					array4[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array4[1] = text6;
					list.Add(array4);
					stringBuilder = 提示文本;
					StringBuilder stringBuilder18 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder);
					handler.AppendLiteral("#r#L法术伤害 ");
					handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.法术伤害);
					handler.AppendLiteral(" 增加#n");
					stringBuilder18.Append(ref handler);
				}
				if (CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.防御 != 0)
				{
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(AllEnums.属性名字Type.防御, CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.防御, out var text7);
					string[] array5 = new string[2];
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.def);
					array5[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array5[1] = text7;
					list.Add(array5);
					stringBuilder = 提示文本;
					StringBuilder stringBuilder19 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder);
					handler.AppendLiteral("#r#L防御 ");
					handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.防御);
					handler.AppendLiteral(" 增加#n");
					stringBuilder19.Append(ref handler);
				}
				if (CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.速度 != 0)
				{
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(AllEnums.属性名字Type.速度, CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.速度, out var text8);
					string[] array6 = new string[2];
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.speed);
					array6[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array6[1] = text8;
					list.Add(array6);
					stringBuilder = 提示文本;
					StringBuilder stringBuilder20 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder);
					handler.AppendLiteral("#r#L速度 ");
					handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.速度);
					handler.AppendLiteral(" 增加#n");
					stringBuilder20.Append(ref handler);
				}
				if (CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.气血 != 0)
				{
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(AllEnums.属性名字Type.气血, CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.气血, out var text9);
					string[] array7 = new string[2];
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.max_life);
					array7[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array7[1] = text9;
					list.Add(array7);
					stringBuilder = 提示文本;
					StringBuilder stringBuilder21 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder);
					handler.AppendLiteral("#r#L气血 ");
					handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.气血);
					handler.AppendLiteral(" 增加#n");
					stringBuilder21.Append(ref handler);
				}
				if (CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.法力 != 0)
				{
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(AllEnums.属性名字Type.法力, CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.法力, out var text10);
					string[] array8 = new string[2];
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.max_mana);
					array8[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array8[1] = text10;
					list.Add(array8);
					stringBuilder = 提示文本;
					StringBuilder stringBuilder22 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder);
					handler.AppendLiteral("#r#L法力 ");
					handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破加成配置.法力);
					handler.AppendLiteral(" 增加#n");
					stringBuilder22.Append(ref handler);
				}
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(提示文本.ToString(), 提示文本.ToString().Replace("#r", " ")));
				if (list.Count > 0)
				{
					Singleton<fuMNpgieFTYU3Wah53>.I.mMMfZ3LX2(P_0, list);
					await Task.Delay(100);
				}
			}
			提示文本.Clear();
			if (CS_0024_003C_003E8__locals146.xKTy31WpCq.Is突破横幅)
			{
				Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.PWRouuXjmn(CS_0024_003C_003E8__locals146.xKTy31WpCq.全服横幅文字.Replace("#user", P_0.user.人物数据.昵称)));
			}
			if (Singleton<全局变量类>.I.全服共享存档数据.全服境界突破第一人组.ContainsKey(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破境界))
			{
				return null;
			}
			Singleton<全局变量类>.I.全服共享存档数据.全服境界突破第一人组.TryAdd(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破境界, P_0.user.人物数据.昵称);
			Singleton<BsbfIlwwf1YnPvbq8GT>.I.o2gwKNo6hU();
			if (!CS_0024_003C_003E8__locals146.xKTy31WpCq.Is全服突破境界奖励)
			{
				return null;
			}
			if (下一境界 == null)
			{
				stringBuilder = 提示文本;
				StringBuilder stringBuilder23 = stringBuilder;
				handler = new StringBuilder.AppendInterpolatedStringHandler(56, 3, stringBuilder);
				handler.AppendLiteral("#30全体起立！恭贺#Y");
				handler.AppendFormatted(P_0.user.人物数据.昵称);
				handler.AppendLiteral("#n成为本服第一位突破至#G");
				handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破境界);
				handler.AppendLiteral("#n至尊，已经达到了当前世界的最高修为【#O");
				handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破境界);
				handler.AppendLiteral("#n】。并且奖励");
				stringBuilder23.Append(ref handler);
			}
			else
			{
				stringBuilder = 提示文本;
				StringBuilder stringBuilder24 = stringBuilder;
				handler = new StringBuilder.AppendInterpolatedStringHandler(35, 2, stringBuilder);
				handler.AppendLiteral("#30全体起立！恭贺#Y");
				handler.AppendFormatted(P_0.user.人物数据.昵称);
				handler.AppendLiteral("#n成为本服第一位突破至#G");
				handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.突破境界);
				handler.AppendLiteral("#n大佬，并且奖励");
				stringBuilder24.Append(ref handler);
			}
			if (CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励金元宝 != 0)
			{
				WdAPI i17 = Singleton<WdAPI>.I;
				string empty13 = string.Empty;
				int 奖励金元宝 = CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励金元宝;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[全服突破-金元宝-");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				if (i17.PndoGw5lW7(P_0, AllEnums.发送数据Type.金元宝, empty13, AllEnums.指令Type.无, 奖励金元宝, false, defaultInterpolatedStringHandler.ToStringAndClear()))
				{
					stringBuilder = 提示文本;
					StringBuilder stringBuilder25 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder);
					handler.AppendLiteral("#Y金元宝*");
					handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励金元宝);
					handler.AppendLiteral("#n、");
					stringBuilder25.Append(ref handler);
				}
			}
			if (CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励银元宝 != 0)
			{
				WdAPI i18 = Singleton<WdAPI>.I;
				string empty14 = string.Empty;
				int 奖励银元宝 = CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励银元宝;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[全服突破-银元宝-");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				if (i18.PndoGw5lW7(P_0, AllEnums.发送数据Type.银元宝, empty14, AllEnums.指令Type.无, 奖励银元宝, false, defaultInterpolatedStringHandler.ToStringAndClear()))
				{
					stringBuilder = 提示文本;
					StringBuilder stringBuilder26 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder);
					handler.AppendLiteral("#Y银元宝*");
					handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励银元宝);
					handler.AppendLiteral("#n、");
					stringBuilder26.Append(ref handler);
				}
			}
			if (CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励游戏币 != 0)
			{
				WdAPI i19 = Singleton<WdAPI>.I;
				string empty15 = string.Empty;
				int 奖励游戏币 = CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励游戏币;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[全服突破-游戏币-");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				if (i19.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, empty15, AllEnums.指令Type.cash, 奖励游戏币, false, defaultInterpolatedStringHandler.ToStringAndClear()))
				{
					stringBuilder = 提示文本;
					StringBuilder stringBuilder27 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder);
					handler.AppendLiteral("#Y游戏币*");
					handler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励游戏币));
					handler.AppendLiteral("#n、");
					stringBuilder27.Append(ref handler);
				}
			}
			if (CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励道行 != 0)
			{
				WdAPI i20 = Singleton<WdAPI>.I;
				string empty16 = string.Empty;
				int num4 = CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励道行 * 360;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[全服突破-道行-");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				if (i20.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, empty16, AllEnums.指令Type.tao, num4, false, defaultInterpolatedStringHandler.ToStringAndClear()))
				{
					stringBuilder = 提示文本;
					StringBuilder stringBuilder28 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder);
					handler.AppendLiteral("#Y道行*");
					handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励道行);
					handler.AppendLiteral("年#n、");
					stringBuilder28.Append(ref handler);
				}
			}
			if (CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励声望 != 0)
			{
				WdAPI i21 = Singleton<WdAPI>.I;
				string empty17 = string.Empty;
				int 奖励声望 = CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励声望;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[全服突破-声望-");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				if (i21.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, empty17, AllEnums.指令Type.reputation, 奖励声望, false, defaultInterpolatedStringHandler.ToStringAndClear()))
				{
					stringBuilder = 提示文本;
					StringBuilder stringBuilder29 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder);
					handler.AppendLiteral("#Y声望*");
					handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励声望);
					handler.AppendLiteral("#n、");
					stringBuilder29.Append(ref handler);
				}
			}
			if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励道具))
			{
				WdAPI i22 = Singleton<WdAPI>.I;
				string 奖励道具 = CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励道具;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 3);
				defaultInterpolatedStringHandler.AppendLiteral("[全服突破-道具(");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励道具);
				defaultInterpolatedStringHandler.AppendLiteral(")-");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.当前境界);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				if (i22.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 奖励道具, AllEnums.指令Type.无, 1, false, defaultInterpolatedStringHandler.ToStringAndClear()))
				{
					stringBuilder = 提示文本;
					StringBuilder stringBuilder30 = stringBuilder;
					handler = new StringBuilder.AppendInterpolatedStringHandler(7, 1, stringBuilder);
					handler.AppendLiteral("#Y");
					handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励道具);
					handler.AppendLiteral("*1#n、");
					stringBuilder30.Append(ref handler);
				}
			}
			if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励技能) && 问道数据类.所有技能ID.TryGetValue(CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励技能, out var value))
			{
				Singleton<WdAPI>.I.W9lI1TZlUs(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), $"{value}", $"{CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.技能等级}");
				stringBuilder = 提示文本;
				StringBuilder stringBuilder31 = stringBuilder;
				handler = new StringBuilder.AppendInterpolatedStringHandler(10, 2, stringBuilder);
				handler.AppendLiteral("#Y神通*");
				handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.奖励技能);
				handler.AppendLiteral("Lv");
				handler.AppendFormatted(CS_0024_003C_003E8__locals146.xKTy31WpCq.首次突破奖励.技能等级);
				handler.AppendLiteral("#n、");
				stringBuilder31.Append(ref handler);
			}
			提示文本.Append("、、");
			提示文本 = 提示文本.Replace("、、、", "。");
			return Singleton<WdAPI>.I.组包聊天信息(提示文本.ToString(), "管理员", AllEnums.频道Type.系统);
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("封包修改渡劫后数据-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return null;
		}
	}

	
	public bool YQC2xhnV59(int P_0)
	{
		if (P_0 >= 100)
		{
			return true;
		}
		return P_0 >= Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
	}

	
	public byte[] wrH2HZG48w(short P_0, short P_1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[12]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 8,
			16, 142
		}, hasCount: false, 0);
		封包_写2.写短整数型(P_0, reverse: true);
		封包_写2.写短整数型(P_1, reverse: true);
		封包_写2.写短整数型(0, reverse: true);
		return 封包_写2.取数据();
	}

	
	internal bool QLk24Vn589(string P_0)
	{
		if (Singleton<ByteAPI>.I.寻找文本与(P_0, "你获得了", "点经验") || Singleton<ByteAPI>.I.寻找文本与(P_0, "你得到了", "点经验"))
		{
			return true;
		}
		return false;
	}

	
	public void OWg2eJvbFP(MyNATSocketClient P_0, string P_1, string P_2)
	{
		try
		{
			if (P_1 == "元神系统_确定突破")
			{
				Lcj2qBxZWT(P_0);
			}
			else if (Singleton<ByteAPI>.I.寻找文本(P_1, "元神系统_本命法宝强化"))
			{
				E0B2AMjcsf(P_0, P_1.Replace("元神系统_本命法宝强化", string.Empty));
			}
			else if (Singleton<ByteAPI>.I.寻找文本(P_1, "元神系统_装备升阶"))
			{
				Nykmufq2NY(P_0, P_1.Replace("元神系统_装备升阶", string.Empty));
			}
			else if (Singleton<ByteAPI>.I.寻找文本(P_1, "元神系统_装备转化"))
			{
				xwt2z3hksd(P_0, P_1.Replace("元神系统_装备转化", string.Empty));
			}
			else if (Singleton<ByteAPI>.I.寻找文本(P_1, "!^元神系统_心法升级"))
			{
				l02mJcku8S(P_0, P_1.Replace("!^元神系统_心法升级", string.Empty), P_2);
			}
			else if (Singleton<ByteAPI>.I.寻找文本(P_1, "元神系统_附灵灵幡"))
			{
				wl2mRN5WkM(P_0, P_1.Replace("元神系统_附灵灵幡", string.Empty), P_2);
			}
			else if (Singleton<ByteAPI>.I.寻找文本(P_1, "$*元神系统_附灵确定") && P_0.user.缓存数据.l9XIwuUeoO.ElapsedMilliseconds >= 1000)
			{
				P_0.user.缓存数据.l9XIwuUeoO.Restart();
				XGomdfB8td(P_0, P_1.Replace("$*元神系统_附灵确定", string.Empty), P_2);
			}
		}
		catch (Exception ex)
		{
			Log.Error("NPC相关事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public async Task Lcj2qBxZWT(MyNATSocketClient P_0)
	{
		_ = 3;
		try
		{
			if (P_0.user.缓存数据.is战斗中)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R战斗中无法突破。"));
				return;
			}
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R仙灵卡异常。"));
				return;
			}
			if (P_0.user.队伍数据.成员列表.Count > 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R组队状态中无法进行突破。"));
				return;
			}
			元神境界配置类 当前境界 = wIn2YFWhMH(P_0.user.存档数据.元神存档.当前境界);
			if (当前境界 == null)
			{
				return;
			}
			if (P_0.user.存档数据.元神存档.当前境界 >= Singleton<全局变量类>.I.元神系统配置.当前境界上限)
			{
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
				defaultInterpolatedStringHandler.AppendLiteral("当前世界境界上限为#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.当前境界上限);
				defaultInterpolatedStringHandler.AppendLiteral("#n，您暂无法进行破境突破。");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else
			{
				if (P_0.user.存档数据.元神存档.突破中 || P_0.user.存档数据.数值存档.灵气值 < P_0.user.存档数据.元神存档.JkJIRtbr1R() || (当前境界.突破特殊需求.Is额外条件 && ((当前境界.突破特殊需求.Is道行达标 && P_0.user.属性数据.道行 / 360 < 当前境界.突破特殊需求.道行要求) || (当前境界.突破特殊需求.Is声望达标 && P_0.user.属性数据.声望 < 当前境界.突破特殊需求.声望要求) || (当前境界.突破特殊需求.Is击杀BOSS要求 && string.IsNullOrWhiteSpace(P_0.user.存档数据.元神存档.击杀BOSS达成)) || (当前境界.突破特殊需求.Is获取道具要求 && string.IsNullOrWhiteSpace(P_0.user.存档数据.元神存档.获取道具达成)))))
				{
					return;
				}
				if (!Singleton<全局变量类>.I.所有地图字典.TryGetValue(Singleton<全局变量类>.I.元神系统配置.渡劫地图, out var value))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R地图异常。"));
					return;
				}
				if (P_0.user.人物数据.飞行器 != 0)
				{
					Singleton<WdAPI>.I.使用技能事件(P_0, "腾云驾雾");
				}
				Singleton<WdAPI>.I.地图传送事件(P_0, value, Singleton<全局变量类>.I.元神系统配置.地图坐标X, Singleton<全局变量类>.I.元神系统配置.地图坐标Y);
				await Task.Delay(500);
				if (P_0.user.人物数据.所在地图名字 != Singleton<全局变量类>.I.元神系统配置.渡劫地图)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R进入雷劫地图失败，暂时无法渡劫！"));
					return;
				}
				P_0.user.存档数据.元神存档.突破中 = true;
				if (P_0.user.人物数据.飞行器 == 0)
				{
					Singleton<WdAPI>.I.使用技能事件(P_0, "腾云驾雾");
				}
				bool Is成功 = YQC2xhnV59(P_0.user.存档数据.元神存档.突破几率);
				byte[] 频道数据包 = await hyd21cIsmI(P_0, Is成功);
				int num = (Is成功 ? (当前境界.境界特效.当前基础进度秒数 + 当前境界.境界特效.突破成功特效秒数) : (当前境界.境界特效.当前基础进度秒数 + 当前境界.境界特效.突破失败特效秒数));
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("正在突破");
				defaultInterpolatedStringHandler.AppendFormatted(当前境界.突破境界);
				defaultInterpolatedStringHandler.AppendLiteral("中");
				P_0.C_Send(i2.QewoEwLLTD(defaultInterpolatedStringHandler.ToStringAndClear(), (short)num).Concat(wrH2HZG48w((short)当前境界.境界特效.当前雷劫特效, 当前境界.境界特效.当前雷劫秒数)).ToArray());
				await Task.Delay(当前境界.境界特效.当前基础进度秒数 * 1000);
				int num2 = (Is成功 ? 当前境界.境界特效.突破成功特效 : 当前境界.境界特效.突破失败特效);
				num = (Is成功 ? 当前境界.境界特效.突破成功特效秒数 : 当前境界.境界特效.突破失败特效秒数);
				P_0.C_Send(wrH2HZG48w((short)num2, (short)num));
				Singleton<全局变量类>.I.Client频道事件?.Invoke(频道数据包);
				await Task.Delay(num * 1000);
				P_0.user.存档数据.元神存档.突破中 = false;
				Singleton<WdAPI>.I.同步灵气值到修道点(P_0);
				Singleton<WdAPI>.I.同步境界到称谓(P_0);
				if (P_0.user.人物数据.飞行器 != 0)
				{
					Singleton<WdAPI>.I.使用技能事件(P_0, "腾云驾雾");
				}
				Singleton<WdAPI>.I.地图传送事件(P_0, "/gs/zone/tianyongcheng/tianyongcheng.c", "262", "205");
			}
		}
		catch (Exception ex)
		{
			Log.Error("步骤_2_突破境界-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal byte[] jRJ2remBsP(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(12L, SeekOrigin.Begin);
			int num = obj.读字节型();
			int num2 = obj.读整数型(reverse: true);
			if (num != 1)
			{
				return P_1;
			}
			if (num2 == 0)
			{
				元神境界配置类 元神境界配置类2 = wIn2YFWhMH(P_0.user.存档数据.元神存档.当前境界);
				if (元神境界配置类2 == null)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R道友当前无境界可突破。"));
					return null;
				}
				if (P_0.user.存档数据.元神存档.突破中)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R道友当前已经处于突破状态。"));
					return null;
				}
				bool flag = true;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
				defaultInterpolatedStringHandler.AppendLiteral("当前境界：#Y");
				defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.当前境界);
				defaultInterpolatedStringHandler.AppendLiteral("#n，突破至#Y【");
				defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.突破境界);
				defaultInterpolatedStringHandler.AppendLiteral("】#n条件达成：#r");
				StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				int num3 = P_0.user.存档数据.元神存档.JkJIRtbr1R();
				bool flag2 = P_0.user.存档数据.数值存档.灵气值 >= num3;
				flag = flag2;
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 4, stringBuilder2);
				handler.AppendFormatted(flag2 ? "#Y「√」" : "#R「×」");
				handler.AppendLiteral("灵气进度：");
				handler.AppendFormatted(P_0.user.存档数据.数值存档.灵气值);
				handler.AppendLiteral("/");
				handler.AppendFormatted(num3);
				handler.AppendLiteral("(");
				handler.AppendFormatted((float)P_0.user.存档数据.数值存档.灵气值 * 100f / (float)num3, "F2");
				handler.AppendLiteral("%)#n#r");
				stringBuilder3.Append(ref handler);
				flag = !string.IsNullOrWhiteSpace(P_0.user.存档数据.元神存档.突破使用道具);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
				handler.AppendFormatted(flag ? ("#Y「√」破境丹药：" + P_0.user.存档数据.元神存档.突破使用道具) : "#R「×」破境丹药：暂未服用");
				handler.AppendLiteral("#n#r");
				stringBuilder4.Append(ref handler);
				if (元神境界配置类2.突破特殊需求.Is额外条件)
				{
					if (元神境界配置类2.突破特殊需求.Is道行达标)
					{
						flag = P_0.user.属性数据.道行 / 360 >= 元神境界配置类2.突破特殊需求.道行要求;
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder5 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(11, 3, stringBuilder2);
						handler.AppendFormatted(flag ? "#Y「√」" : "#R「×」");
						handler.AppendLiteral("道行要求：");
						handler.AppendFormatted(P_0.user.属性数据.道行 / 360);
						handler.AppendLiteral("/");
						handler.AppendFormatted(元神境界配置类2.突破特殊需求.道行要求);
						handler.AppendLiteral("年#n#r");
						stringBuilder5.Append(ref handler);
					}
					if (元神境界配置类2.突破特殊需求.Is声望达标)
					{
						flag = P_0.user.属性数据.声望 >= 元神境界配置类2.突破特殊需求.声望要求;
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder6 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(11, 3, stringBuilder2);
						handler.AppendFormatted(flag ? "#Y「√」" : "#R「×」");
						handler.AppendLiteral("声望要求：");
						handler.AppendFormatted(P_0.user.属性数据.声望);
						handler.AppendLiteral("/");
						handler.AppendFormatted(元神境界配置类2.突破特殊需求.声望要求);
						handler.AppendLiteral("点#n#r");
						stringBuilder6.Append(ref handler);
					}
					if (元神境界配置类2.突破特殊需求.Is击杀BOSS要求)
					{
						flag = !string.IsNullOrWhiteSpace(P_0.user.存档数据.元神存档.击杀BOSS达成);
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder7 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(9, 2, stringBuilder2);
						handler.AppendFormatted(flag ? "#Y「√」" : "#R「×」");
						handler.AppendLiteral("击杀怪物：");
						handler.AppendFormatted(元神境界配置类2.突破特殊需求.击杀BOSS要求);
						handler.AppendLiteral("#n#r");
						stringBuilder7.Append(ref handler);
					}
					if (元神境界配置类2.突破特殊需求.Is获取道具要求)
					{
						flag = !string.IsNullOrWhiteSpace(P_0.user.存档数据.元神存档.获取道具达成);
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder8 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(9, 2, stringBuilder2);
						handler.AppendFormatted(flag ? "#Y「√」" : "#R「×」");
						handler.AppendLiteral("寻找物品：");
						handler.AppendFormatted(元神境界配置类2.突破特殊需求.获取道具要求);
						handler.AppendLiteral("#n#r");
						stringBuilder8.Append(ref handler);
					}
				}
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder9 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(10, 2, stringBuilder2);
				handler.AppendFormatted((P_0.user.存档数据.元神存档.突破几率 > 0) ? "#Y「●」" : "#R「●」");
				handler.AppendLiteral("突破几率：");
				handler.AppendFormatted(P_0.user.存档数据.元神存档.突破几率);
				handler.AppendLiteral("%#n#r");
				stringBuilder9.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder10 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(31, 1, stringBuilder2);
				handler.AppendLiteral("#O「●」失败惩罚：损失");
				handler.AppendFormatted(元神境界配置类2.突破失败受伤程度);
				handler.AppendLiteral("%的灵气值，并且重置达成的条件#n#r");
				stringBuilder10.Append(ref handler);
				stringBuilder.Append("#Y突破加成：#r");
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder11 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(7, 1, stringBuilder2);
				handler.AppendLiteral("#L  ");
				handler.AppendFormatted((元神境界配置类2.突破加成配置.突破道具 == P_0.user.存档数据.元神存档.突破使用道具) ? P_0.user.存档数据.元神存档.突破使用道具 : 元神境界配置类2.突破加成配置.突破道具);
				handler.AppendLiteral("：#B");
				stringBuilder11.Append(ref handler);
				if (元神境界配置类2.突破加成配置.所有相性 > 0)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder12 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, stringBuilder2);
					handler.AppendLiteral("所有相性+");
					handler.AppendFormatted(元神境界配置类2.突破加成配置.所有相性);
					handler.AppendLiteral("、");
					stringBuilder12.Append(ref handler);
				}
				if (元神境界配置类2.突破加成配置.所有属性 > 0)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder13 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, stringBuilder2);
					handler.AppendLiteral("所有属性+");
					handler.AppendFormatted(元神境界配置类2.突破加成配置.所有属性);
					handler.AppendLiteral("、");
					stringBuilder13.Append(ref handler);
				}
				if (元神境界配置类2.突破加成配置.物理伤害 > 0)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder14 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, stringBuilder2);
					handler.AppendLiteral("物理伤害+");
					handler.AppendFormatted(元神境界配置类2.突破加成配置.物理伤害);
					handler.AppendLiteral("、");
					stringBuilder14.Append(ref handler);
				}
				if (元神境界配置类2.突破加成配置.法术伤害 > 0)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder15 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, stringBuilder2);
					handler.AppendLiteral("法术伤害+");
					handler.AppendFormatted(元神境界配置类2.突破加成配置.法术伤害);
					handler.AppendLiteral("、");
					stringBuilder15.Append(ref handler);
				}
				if (元神境界配置类2.突破加成配置.防御 > 0)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder16 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
					handler.AppendLiteral("防御+");
					handler.AppendFormatted(元神境界配置类2.突破加成配置.防御);
					handler.AppendLiteral("、");
					stringBuilder16.Append(ref handler);
				}
				if (元神境界配置类2.突破加成配置.速度 > 0)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder17 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
					handler.AppendLiteral("速度+");
					handler.AppendFormatted(元神境界配置类2.突破加成配置.速度);
					handler.AppendLiteral("、");
					stringBuilder17.Append(ref handler);
				}
				if (元神境界配置类2.突破加成配置.气血 > 0)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder18 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
					handler.AppendLiteral("气血+");
					handler.AppendFormatted(元神境界配置类2.突破加成配置.气血);
					handler.AppendLiteral("、");
					stringBuilder18.Append(ref handler);
				}
				if (元神境界配置类2.突破加成配置.法力 > 0)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder19 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
					handler.AppendLiteral("法力+");
					handler.AppendFormatted(元神境界配置类2.突破加成配置.法力);
					handler.AppendLiteral("、");
					stringBuilder19.Append(ref handler);
				}
				stringBuilder.Append("、、#r");
				if (元神境界配置类2.Is全服突破境界奖励 && !Singleton<全局变量类>.I.全服共享存档数据.全服境界突破第一人组.ContainsKey(元神境界配置类2.突破境界))
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder20 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(27, 1, stringBuilder2);
					handler.AppendLiteral("#n全服#Y首位#n突破至#b#O");
					handler.AppendFormatted(元神境界配置类2.突破境界);
					handler.AppendLiteral("#n的道友将获得#Y");
					stringBuilder20.Append(ref handler);
					if (元神境界配置类2.首次突破奖励.奖励金元宝 > 0)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder21 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
						handler.AppendLiteral("金元宝+");
						handler.AppendFormatted(元神境界配置类2.首次突破奖励.奖励金元宝);
						handler.AppendLiteral("、");
						stringBuilder21.Append(ref handler);
					}
					if (元神境界配置类2.首次突破奖励.奖励银元宝 > 0)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder22 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
						handler.AppendLiteral("银元宝+");
						handler.AppendFormatted(元神境界配置类2.首次突破奖励.奖励银元宝);
						handler.AppendLiteral("、");
						stringBuilder22.Append(ref handler);
					}
					if (元神境界配置类2.首次突破奖励.奖励游戏币 > 0)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder23 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
						handler.AppendLiteral("游戏币+");
						handler.AppendFormatted(元神境界配置类2.首次突破奖励.奖励游戏币);
						handler.AppendLiteral("、");
						stringBuilder23.Append(ref handler);
					}
					if (元神境界配置类2.首次突破奖励.奖励道行 > 0)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder24 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(5, 1, stringBuilder2);
						handler.AppendLiteral("道行+");
						handler.AppendFormatted(元神境界配置类2.首次突破奖励.奖励道行);
						handler.AppendLiteral("年、");
						stringBuilder24.Append(ref handler);
					}
					if (元神境界配置类2.首次突破奖励.奖励声望 > 0)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder25 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
						handler.AppendLiteral("声望+");
						handler.AppendFormatted(元神境界配置类2.首次突破奖励.奖励声望);
						handler.AppendLiteral("、");
						stringBuilder25.Append(ref handler);
					}
					if (!string.IsNullOrWhiteSpace(元神境界配置类2.首次突破奖励.奖励道具))
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder26 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(3, 1, stringBuilder2);
						handler.AppendFormatted(元神境界配置类2.首次突破奖励.奖励道具);
						handler.AppendLiteral("*1、");
						stringBuilder26.Append(ref handler);
					}
					if (!string.IsNullOrWhiteSpace(元神境界配置类2.首次突破奖励.奖励技能))
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder27 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(4, 2, stringBuilder2);
						handler.AppendFormatted(元神境界配置类2.首次突破奖励.奖励技能);
						handler.AppendLiteral("Lv*");
						handler.AppendFormatted(元神境界配置类2.首次突破奖励.技能等级);
						handler.AppendLiteral("、");
						stringBuilder27.Append(ref handler);
					}
					stringBuilder.Append("、、#n#r");
				}
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder28 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, stringBuilder2);
				handler.AppendFormatted(flag ? "[【确定】开始接受雷劫洗礼/元神系统_确定突破][【取消】我还得准备准备/离开]" : "[未满足所有条件无法进行境界突破/离开]");
				stringBuilder28.Append(ref handler);
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_自己(P_0, stringBuilder.ToString().Replace("、、、", string.Empty)));
				return null;
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("道友_破镜请求处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal void KOq2ZTLen8(MyNATSocketClient P_0, int P_1)
	{
		try
		{
			元神境界配置类 元神境界配置类2 = wIn2YFWhMH(P_0.user.存档数据.元神存档.当前境界);
			int num = P_0.user.存档数据.元神存档.JkJIRtbr1R();
			int value;
			if (P_0.user.存档数据.数值存档.灵气值 < num)
			{
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 4);
				defaultInterpolatedStringHandler.AppendLiteral("你当前的灵气#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.数值存档.灵气值);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n未达到#R");
				defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.当前境界);
				defaultInterpolatedStringHandler.AppendLiteral("#n的圆满值，无法使用#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_1].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else if (元神境界配置类2.增加突破几率道具.TryGetValue(P_0.user.背包数据.物品列表[P_1].名字, out value))
			{
				if (string.IsNullOrWhiteSpace(P_0.user.存档数据.元神存档.突破使用道具))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你并未服用过任何突破丹药，暂无法服用#R" + P_0.user.背包数据.物品列表[P_1].名字 + "#n。"));
					return;
				}
				if (Singleton<ByteAPI>.I.寻找文本(P_0.user.存档数据.元神存档.增加几率道具 + "|", "|" + P_0.user.背包数据.物品列表[P_1].名字 + "|"))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你已经服用过#R" + P_0.user.背包数据.物品列表[P_1].名字 + "#n了。"));
					return;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (P_0.user.存档数据.元神存档.突破几率 >= 100)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你当前突破#R");
					defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.突破境界);
					defaultInterpolatedStringHandler.AppendLiteral("#n的几率是#R100%#n，无法再次提升。");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				Singleton<WdAPI>.I.UH7oscwt9s(P_0, P_1);
				元神存档类 元神存档 = P_0.user.存档数据.元神存档;
				元神存档.增加几率道具 = 元神存档.增加几率道具 + "|" + P_0.user.背包数据.物品列表[P_1].名字;
				P_0.user.存档数据.元神存档.突破几率 += value;
				WdAPI i3 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你服用了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_1].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n，增加了#R");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("%#n的突破几率。");
				P_0.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else if (元神境界配置类2.突破加成配置.突破道具 == P_0.user.背包数据.物品列表[P_1].名字)
			{
				if (!string.IsNullOrWhiteSpace(P_0.user.存档数据.元神存档.突破使用道具))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你已经服用过了#R" + P_0.user.存档数据.元神存档.突破使用道具 + "#n，无法重复服用突破丹药。"));
					return;
				}
				Singleton<WdAPI>.I.UH7oscwt9s(P_0, P_1);
				P_0.user.存档数据.元神存档.突破使用道具 = P_0.user.背包数据.物品列表[P_1].名字;
				P_0.user.存档数据.元神存档.突破几率 = 元神境界配置类2.突破加成配置.突破几率;
				WdAPI i4 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你服用了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_1].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n，当前突破#R");
				defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.突破境界);
				defaultInterpolatedStringHandler.AppendLiteral("#n的几率为#R");
				defaultInterpolatedStringHandler.AppendFormatted(元神境界配置类2.突破加成配置.突破几率);
				defaultInterpolatedStringHandler.AppendLiteral("%#n。");
				P_0.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}
		catch (Exception ex)
		{
			Log.Error("服用突破丹药请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal bool tCU2t0Ktbn(MyNATSocketClient P_0, byte P_1, byte P_2)
	{
		try
		{
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return false;
			}
			if (!Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, P_1) || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, P_2))
			{
				return false;
			}
			if (P_0.user.背包数据.物品列表[P_1].物品ID == 0 || P_0.user.背包数据.物品列表[P_2].物品ID == 0)
			{
				return false;
			}
			if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.功能开关 && Singleton<ByteAPI>.I.寻找文本(yQ0mlWibO6.ToString(), "|" + P_0.user.背包数据.物品列表[P_1].名字 + "|") && 问道数据类.Get道具类型(P_0.user.背包数据.物品列表[P_2].物品类型, Is校验装备: true, Is校验首饰: false))
			{
				if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is等级要求 && P_0.user.属性数据.等级 < Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低等级)
				{
					return false;
				}
				if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is道行要求 && P_0.user.属性数据.道行 < Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低道行 * 360)
				{
					return false;
				}
				if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is装备等级要求 && P_0.user.背包数据.物品列表[P_2].等级 < Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低装备等级)
				{
					return false;
				}
				if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is改造要求 && P_0.user.背包数据.物品列表[P_2].改造等级 < Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低改造)
				{
					return false;
				}
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilder stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler;
				if (P_0.user.背包数据.物品列表[P_1].名字 == Singleton<全局变量类>.I.元神系统配置.转化道具)
				{
					if (P_0.user.背包数据.物品列表[P_2].最大耐久度 < 100000 || P_0.user.背包数据.物品列表[P_2].最大耐久度 >= 200000)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder3 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(47, 3, stringBuilder2);
						handler.AppendLiteral("[@确定/元神系统_装备转化");
						handler.AppendFormatted(P_1);
						handler.AppendLiteral("|");
						handler.AppendFormatted(P_2);
						handler.AppendLiteral("#DLG:1#prompt:你确定要对#R");
						handler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].名字);
						handler.AppendLiteral("#n装备进行转化吗？]");
						stringBuilder3.Append(ref handler);
						P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_1].封包缓存, P_1).Concat(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_2].封包缓存, P_2)).Concat(Singleton<WdAPI>.I.组包确定框(P_0, stringBuilder.ToString()))
							.ToArray());
						return true;
					}
					return false;
				}
				if (P_0.user.背包数据.物品列表[P_2].最大耐久度 < 100000 || P_0.user.背包数据.物品列表[P_2].最大耐久度 >= 200000)
				{
					return false;
				}
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(29, 2, stringBuilder2);
				handler.AppendLiteral("[@确定/元神系统_装备升阶");
				handler.AppendFormatted(P_1);
				handler.AppendLiteral("|");
				handler.AppendFormatted(P_2);
				handler.AppendLiteral("#DLG:1#prompt:");
				stringBuilder4.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
				handler.AppendLiteral("你确定要对#R");
				handler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].名字);
				handler.AppendLiteral("#n装备进行升阶吗？]");
				stringBuilder5.Append(ref handler);
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_1].封包缓存, P_1).Concat(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_2].封包缓存, P_2)).Concat(Singleton<WdAPI>.I.组包确定框(P_0, stringBuilder.ToString()))
					.ToArray());
				return true;
			}
			if (Singleton<ByteAPI>.I.寻找文本(Yp6mjOM9qh.ToString(), "|" + P_0.user.背包数据.物品列表[P_1].名字 + "|") && P_0.user.背包数据.物品列表[P_2].名字 == "本命法宝★人皇幡")
			{
				if (P_0.user.背包数据.物品列表[P_2].改造等级 >= 100)
				{
					return false;
				}
				if (!Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryGetValue(P_0.user.背包数据.物品列表[P_2].改造等级 + 1, out 本命法宝属性类 value))
				{
					return false;
				}
				if (value.强化道具 != P_0.user.背包数据.物品列表[P_1].名字)
				{
					return false;
				}
				float value2 = 100f * (float)((P_0.user.背包数据.物品列表[P_2].当前耐久度 <= 0) ? 1 : P_0.user.背包数据.物品列表[P_2].当前耐久度) / (float)value.强化进度;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[@确定/元神系统_本命法宝强化");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:");
				StringBuilder stringBuilder6 = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				StringBuilder stringBuilder2 = stringBuilder6;
				StringBuilder stringBuilder7 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(28, 2, stringBuilder2);
				handler.AppendLiteral("当前强化几率#Y");
				handler.AppendFormatted(value2, "N2");
				handler.AppendLiteral("%#n，你确定要对#R");
				handler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].名字);
				handler.AppendLiteral("#n进行强化吗？]");
				stringBuilder7.Append(ref handler);
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_1].封包缓存, P_1).Concat(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_2].封包缓存, P_2)).Concat(Singleton<WdAPI>.I.组包确定框(P_0, stringBuilder6.ToString()))
					.ToArray());
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			Log.Error("Is符合道友道具使用-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	private async Task E0B2AMjcsf(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass31_0 CS_0024_003C_003E8__locals80 = new _003C_003Ec__DisplayClass31_0();
		CS_0024_003C_003E8__locals80.mdIypnFODR = P_0;
		try
		{
			if (string.IsNullOrWhiteSpace(P_1))
			{
				CS_0024_003C_003E8__locals80.mdIypnFODR.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的本命法宝强化物品有误，原因：1！"));
				return;
			}
			new StringBuilder();
			string[] array = P_1.Split("|");
			if (array.Length != 2)
			{
				CS_0024_003C_003E8__locals80.mdIypnFODR.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的本命法宝强化物品有误，原因：2！"));
			}
			else if (!byte.TryParse(array[0], out CS_0024_003C_003E8__locals80.wZly4DO6uJ) || !byte.TryParse(array[1], out CS_0024_003C_003E8__locals80.rSdyxOqkEj))
			{
				CS_0024_003C_003E8__locals80.mdIypnFODR.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的本命法宝强化物品有误，原因：3！"));
			}
			else
			{
				if (CS_0024_003C_003E8__locals80.mdIypnFODR.user.缓存数据.is使用仙灵卡 || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals80.mdIypnFODR, CS_0024_003C_003E8__locals80.wZly4DO6uJ) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals80.mdIypnFODR, CS_0024_003C_003E8__locals80.rSdyxOqkEj) || CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.wZly4DO6uJ].物品ID == 0 || CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.rSdyxOqkEj].物品ID == 0)
				{
					return;
				}
				if (CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.rSdyxOqkEj].改造等级 >= 100)
				{
					CS_0024_003C_003E8__locals80.mdIypnFODR.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的本命法宝已经强化到极致了！"));
					return;
				}
				if (!Singleton<全局变量类>.I.元神系统配置.本命法宝属性.TryGetValue(CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.rSdyxOqkEj].改造等级 + 1, out CS_0024_003C_003E8__locals80.aCvy1idXta))
				{
					CS_0024_003C_003E8__locals80.mdIypnFODR.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的本命法宝已经无法强化了！"));
					return;
				}
				if (CS_0024_003C_003E8__locals80.aCvy1idXta.强化道具 != CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.wZly4DO6uJ].名字)
				{
					MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals80.mdIypnFODR;
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.rSdyxOqkEj].名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n需要吸收#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals80.aCvy1idXta.强化道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n才可以进行强化！");
					myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				CS_0024_003C_003E8__locals80.oEZyHsmsi9 = 0;
				CS_0024_003C_003E8__locals80.xTOyeEdha8 = 0f;
				CS_0024_003C_003E8__locals80.Mumyq8Yo6c = CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.rSdyxOqkEj].当前耐久度;
				int 随机值 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				for (int j = 0; j < CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.wZly4DO6uJ].数量; j++)
				{
					CS_0024_003C_003E8__locals80.oEZyHsmsi9++;
					CS_0024_003C_003E8__locals80.Mumyq8Yo6c++;
					CS_0024_003C_003E8__locals80.xTOyeEdha8 = (float)CS_0024_003C_003E8__locals80.Mumyq8Yo6c * 1f / (float)CS_0024_003C_003E8__locals80.aCvy1idXta.强化进度;
					if (CS_0024_003C_003E8__locals80.xTOyeEdha8 >= 0.8f)
					{
						if (CS_0024_003C_003E8__locals80.xTOyeEdha8 >= 1f || Singleton<WdAPI>.I.qrjo9TWIdy(1, 100) == 随机值)
						{
							CS_0024_003C_003E8__locals80.xTOyeEdha8 = 1f;
							break;
						}
						await Task.Delay(1);
					}
				}
				CS_0024_003C_003E8__locals80.mdIypnFODR.销毁回调事件 =  async (string v) =>
				{
					if (!(v != CS_0024_003C_003E8__locals80.aCvy1idXta.强化道具))
					{
						CS_0024_003C_003E8__locals80.mdIypnFODR.销毁回调事件 = null;
						MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals80.mdIypnFODR;
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(17, 3);
						defaultInterpolatedStringHandler2.AppendLiteral("#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.rSdyxOqkEj].名字);
						defaultInterpolatedStringHandler2.AppendLiteral("#n吸收了#R");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals80.oEZyHsmsi9);
						defaultInterpolatedStringHandler2.AppendLiteral("#n个#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.wZly4DO6uJ].名字);
						defaultInterpolatedStringHandler2.AppendLiteral("#n。");
						myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						if (CS_0024_003C_003E8__locals80.xTOyeEdha8 < 1f)
						{
							Singleton<WdAPI>.I.Mr8ICwW3qX(CS_0024_003C_003E8__locals80.mdIypnFODR, CS_0024_003C_003E8__locals80.rSdyxOqkEj, "durability", $"{CS_0024_003C_003E8__locals80.Mumyq8Yo6c}");
							MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals80.mdIypnFODR;
							WdAPI i3 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(29, 1);
							defaultInterpolatedStringHandler2.AppendLiteral("很遗憾，#R强化失败#n了！当前强化几率提升至#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals80.xTOyeEdha8 * 100f, "F2");
							defaultInterpolatedStringHandler2.AppendLiteral("%#n。");
							myNATSocketClient3.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						}
						else
						{
							List<string[]> list = new List<string[]>
							{
								new string[2]
								{
									"durability",
									"1"
								},
								new string[2]
								{
									"rebuild_level",
									$"{CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.rSdyxOqkEj].改造等级 + 1}"
								}
							};
							defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(23, 2);
							defaultInterpolatedStringHandler2.AppendLiteral("#Y");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.rSdyxOqkEj].名字);
							defaultInterpolatedStringHandler2.AppendLiteral("#n强化#G+");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.rSdyxOqkEj].改造等级 + 1);
							defaultInterpolatedStringHandler2.AppendLiteral("成功！#n强化属性如下：#r");
							StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler2.ToStringAndClear());
							foreach (通用属性类 item in CS_0024_003C_003E8__locals80.aCvy1idXta.属性列表)
							{
								StringBuilder stringBuilder2 = stringBuilder;
								StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 4, stringBuilder2);
								handler.AppendLiteral("#G");
								handler.AppendFormatted(item.属性名字);
								handler.AppendLiteral(" ");
								handler.AppendFormatted(Math.Abs(item.属性数值));
								handler.AppendFormatted(item.Is比例 ? "%" : string.Empty);
								handler.AppendFormatted((item.属性数值 > 0) ? " 增加" : string.Empty);
								handler.AppendLiteral("#r");
								stringBuilder2.Append(ref handler);
								string[] array2 = new string[2];
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
								defaultInterpolatedStringHandler2.AppendLiteral("prop/");
								defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性标识Type)item.属性名字);
								array2[0] = defaultInterpolatedStringHandler2.ToStringAndClear();
								array2[1] = $"{item.属性数值}";
								list.Add(array2);
							}
							Singleton<WdAPI>.I.NNfIVUuyWv(CS_0024_003C_003E8__locals80.mdIypnFODR, CS_0024_003C_003E8__locals80.rSdyxOqkEj, list);
							await Task.Delay(200);
							CS_0024_003C_003E8__locals80.mdIypnFODR.C_Send(Singleton<WdAPI>.I.对话生成_自己(CS_0024_003C_003E8__locals80.mdIypnFODR, stringBuilder.ToString()));
						}
					}
				};
				CS_0024_003C_003E8__locals80.mdIypnFODR.C_Send(Singleton<WdAPI>.I.QewoEwLLTD("本命法宝强化中", 1));
				if (CS_0024_003C_003E8__locals80.oEZyHsmsi9 >= CS_0024_003C_003E8__locals80.mdIypnFODR.user.背包数据.物品列表[CS_0024_003C_003E8__locals80.wZly4DO6uJ].数量)
				{
					CS_0024_003C_003E8__locals80.mdIypnFODR.S_Send(Singleton<WdAPI>.I.CxWI0uMCPh(CS_0024_003C_003E8__locals80.mdIypnFODR, CS_0024_003C_003E8__locals80.wZly4DO6uJ));
				}
				else
				{
					CS_0024_003C_003E8__locals80.mdIypnFODR.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(CS_0024_003C_003E8__locals80.wZly4DO6uJ, CS_0024_003C_003E8__locals80.oEZyHsmsi9));
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("本命法宝强化确定处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private async Task xwt2z3hksd(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass32_0 CS_0024_003C_003E8__locals48 = new _003C_003Ec__DisplayClass32_0();
		CS_0024_003C_003E8__locals48.bgXyZEtN0u = P_0;
		try
		{
			if (string.IsNullOrWhiteSpace(P_1))
			{
				CS_0024_003C_003E8__locals48.bgXyZEtN0u.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的转化装备有误！"));
				return;
			}
			new StringBuilder();
			string[] array = P_1.Split("|");
			byte result;
			if (array.Length != 2)
			{
				CS_0024_003C_003E8__locals48.bgXyZEtN0u.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的转化装备有误。"));
			}
			else if (!byte.TryParse(array[0], out result) || !byte.TryParse(array[1], out CS_0024_003C_003E8__locals48.ld4ytuqCs7))
			{
				CS_0024_003C_003E8__locals48.bgXyZEtN0u.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R提交的转化装备有误。#n"));
			}
			else
			{
				if (CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.缓存数据.is使用仙灵卡 || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals48.bgXyZEtN0u, result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals48.bgXyZEtN0u, CS_0024_003C_003E8__locals48.ld4ytuqCs7) || CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.背包数据.物品列表[result].物品ID == 0 || CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.背包数据.物品列表[CS_0024_003C_003E8__locals48.ld4ytuqCs7].物品ID == 0 || string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.元神系统配置.转化道具) || CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.背包数据.物品列表[result].名字 != Singleton<全局变量类>.I.元神系统配置.转化道具)
				{
					return;
				}
				if (CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.背包数据.物品列表[CS_0024_003C_003E8__locals48.ld4ytuqCs7].最大耐久度 >= 100000 && CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.背包数据.物品列表[CS_0024_003C_003E8__locals48.ld4ytuqCs7].最大耐久度 < 200000)
				{
					CS_0024_003C_003E8__locals48.bgXyZEtN0u.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.背包数据.物品列表[CS_0024_003C_003E8__locals48.ld4ytuqCs7].名字 + "#n无法转化！"));
					return;
				}
				if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is等级要求 && CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.属性数据.等级 < Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低等级)
				{
					MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals48.bgXyZEtN0u;
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的等级不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法转化！");
					myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is道行要求 && CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.属性数据.道行 < Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低道行 * 360)
				{
					MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals48.bgXyZEtN0u;
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的道行不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n年，无法转化！");
					myNATSocketClient2.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is装备等级要求 && CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.背包数据.物品列表[CS_0024_003C_003E8__locals48.ld4ytuqCs7].等级 < Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低装备等级)
				{
					MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals48.bgXyZEtN0u;
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.背包数据.物品列表[CS_0024_003C_003E8__locals48.ld4ytuqCs7].名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n的等级不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低装备等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法转化！");
					myNATSocketClient3.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is改造要求 && CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.背包数据.物品列表[CS_0024_003C_003E8__locals48.ld4ytuqCs7].改造等级 < Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低改造)
				{
					MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals48.bgXyZEtN0u;
					WdAPI i4 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.背包数据.物品列表[CS_0024_003C_003E8__locals48.ld4ytuqCs7].名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n的改造等级不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低改造);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法转化！");
					myNATSocketClient4.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				foreach (属性数据 item in CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.背包数据.物品列表[CS_0024_003C_003E8__locals48.ld4ytuqCs7].装备属性列表.FindAll( (属性数据 x) => (x.属性类别 == 514 || x.属性类别 == 770 || x.属性类别 == 3074 || x.属性类别 == 1026 || x.属性类别 == 3330) && Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.ContainsKey((AllEnums.属性名字Type)x.属性标识)))
				{
					if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryGetValue((AllEnums.属性名字Type)item.属性标识, out int[] value) && value.Length != 0 && item.属性数值 < value[0])
					{
						MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals48.bgXyZEtN0u;
						WdAPI i5 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 5);
						defaultInterpolatedStringHandler.AppendLiteral("#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.背包数据.物品列表[CS_0024_003C_003E8__locals48.ld4ytuqCs7].名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n的");
						defaultInterpolatedStringHandler.AppendFormatted(问道数据类.Get属性颜色((AllEnums.属性类别)item.属性类别));
						defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性名字Type)item.属性标识);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(item.属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加#n属性数值不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(value[0]);
						defaultInterpolatedStringHandler.AppendLiteral("#n，不符合最低进阶条件，无法转化！");
						myNATSocketClient5.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
				}
				CS_0024_003C_003E8__locals48.bgXyZEtN0u.销毁回调事件 =  (string v) =>
				{
					if (!(v != Singleton<全局变量类>.I.元神系统配置.转化道具))
					{
						CS_0024_003C_003E8__locals48.bgXyZEtN0u.销毁回调事件 = null;
						Singleton<WdAPI>.I.NNfIVUuyWv(CS_0024_003C_003E8__locals48.bgXyZEtN0u, CS_0024_003C_003E8__locals48.ld4ytuqCs7, new List<string[]>
						{
							new string[2]
							{
								"max_durability",
								"100000"
							},
							new string[2]
							{
								"durability",
								"100000"
							}
						});
						CS_0024_003C_003E8__locals48.bgXyZEtN0u.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#Y" + CS_0024_003C_003E8__locals48.bgXyZEtN0u.user.背包数据.物品列表[CS_0024_003C_003E8__locals48.ld4ytuqCs7].名字 + "#n转化成功，可以进行进阶了。"));
					}
				};
				CS_0024_003C_003E8__locals48.bgXyZEtN0u.C_Send(Singleton<WdAPI>.I.QewoEwLLTD("装备转化中", 1));
				await CS_0024_003C_003E8__locals48.bgXyZEtN0u.S_Send异步(Singleton<WdAPI>.I.rxTojoeFsR(result, 1));
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("装备转化确定处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private async Task Nykmufq2NY(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass33_0 CS_0024_003C_003E8__locals120 = new _003C_003Ec__DisplayClass33_0();
		CS_0024_003C_003E8__locals120.AF8yzm4fGY = P_0;
		try
		{
			if (string.IsNullOrWhiteSpace(P_1))
			{
				CS_0024_003C_003E8__locals120.AF8yzm4fGY.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的升阶装备物品有误！"));
				return;
			}
			new StringBuilder();
			string[] array = P_1.Split("|");
			if (array.Length != 2)
			{
				CS_0024_003C_003E8__locals120.AF8yzm4fGY.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的升阶装备物品有误。"));
			}
			else if (!byte.TryParse(array[0], out CS_0024_003C_003E8__locals120.WRGCJgXV80) || !byte.TryParse(array[1], out CS_0024_003C_003E8__locals120.BDjCwsXeja))
			{
				CS_0024_003C_003E8__locals120.AF8yzm4fGY.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R提交的升阶装备物品有误！#n"));
			}
			else
			{
				if (CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.缓存数据.is使用仙灵卡 || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals120.AF8yzm4fGY, CS_0024_003C_003E8__locals120.WRGCJgXV80) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals120.AF8yzm4fGY, CS_0024_003C_003E8__locals120.BDjCwsXeja) || CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.WRGCJgXV80].物品ID == 0 || CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].物品ID == 0)
				{
					return;
				}
				if (CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].最大耐久度 < 100000 || CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].最大耐久度 >= 200000)
				{
					CS_0024_003C_003E8__locals120.AF8yzm4fGY.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].名字 + "#n无法进阶！"));
					return;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is等级要求 && CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.属性数据.等级 < Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低等级)
				{
					MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals120.AF8yzm4fGY;
					WdAPI i = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的等级不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法进阶！");
					myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is道行要求 && CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.属性数据.道行 < Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低道行 * 360)
				{
					MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals120.AF8yzm4fGY;
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的道行不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n年，无法进阶！");
					myNATSocketClient2.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is装备等级要求 && CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].等级 < Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低装备等级)
				{
					MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals120.AF8yzm4fGY;
					WdAPI i3 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n的等级不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低装备等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法进阶！");
					myNATSocketClient3.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.Is改造要求 && CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].改造等级 < Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低改造)
				{
					MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals120.AF8yzm4fGY;
					WdAPI i4 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n的改造等级不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.装备升阶数据.最低改造);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法进阶！");
					myNATSocketClient4.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				CS_0024_003C_003E8__locals120.zCvCsL3xFn = (AllEnums.元神境界)((CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].最大耐久度 - 100000) / 10000 + 1);
				int 已有进度 = CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].最大耐久度 % 10000;
				if (!Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.TryGetValue(CS_0024_003C_003E8__locals120.zCvCsL3xFn, out CS_0024_003C_003E8__locals120.al7CufZc4q))
				{
					CS_0024_003C_003E8__locals120.AF8yzm4fGY.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].名字 + "#n不符合进阶条件！"));
					return;
				}
				if (string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals120.al7CufZc4q.需求材料) || CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.WRGCJgXV80].名字 != CS_0024_003C_003E8__locals120.al7CufZc4q.需求材料)
				{
					MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals120.AF8yzm4fGY;
					WdAPI i5 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#Y");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals120.zCvCsL3xFn - 1);
					defaultInterpolatedStringHandler.AppendLiteral("#n的#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n需要使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals120.al7CufZc4q.需求材料);
					defaultInterpolatedStringHandler.AppendLiteral("#n才可以进阶！");
					myNATSocketClient5.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				CS_0024_003C_003E8__locals120.SMPCdNHeBL = new List<string[]>();
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n升阶成功！进阶#Y");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals120.zCvCsL3xFn);
				defaultInterpolatedStringHandler.AppendLiteral("#n。#n升阶后属性：#r");
				CS_0024_003C_003E8__locals120.NCgCUQI4FB = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				foreach (属性数据 item in CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].装备属性列表.FindAll( (属性数据 x) => (x.属性类别 == 514 || x.属性类别 == 770 || x.属性类别 == 3074 || x.属性类别 == 1026 || x.属性类别 == 3330) && Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.ContainsKey((AllEnums.属性名字Type)x.属性标识)))
				{
					if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.属性字典.TryGetValue((AllEnums.属性名字Type)item.属性标识, out int[] value) && value.Length > (int)CS_0024_003C_003E8__locals120.zCvCsL3xFn)
					{
						if (item.属性数值 < value[0])
						{
							MyNATSocketClient myNATSocketClient6 = CS_0024_003C_003E8__locals120.AF8yzm4fGY;
							WdAPI i6 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 5);
							defaultInterpolatedStringHandler.AppendLiteral("#R");
							defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].名字);
							defaultInterpolatedStringHandler.AppendLiteral("#n的");
							defaultInterpolatedStringHandler.AppendFormatted(问道数据类.Get属性颜色((AllEnums.属性类别)item.属性类别));
							defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性名字Type)item.属性标识);
							defaultInterpolatedStringHandler.AppendLiteral(" ");
							defaultInterpolatedStringHandler.AppendFormatted(item.属性数值);
							defaultInterpolatedStringHandler.AppendLiteral(" 增加#n属性数值不足#R");
							defaultInterpolatedStringHandler.AppendFormatted(value[0]);
							defaultInterpolatedStringHandler.AppendLiteral("#n，不符合最低进阶条件！");
							myNATSocketClient6.C_Send(i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
							return;
						}
						List<string[]> list = CS_0024_003C_003E8__locals120.SMPCdNHeBL;
						string[] array2 = new string[2];
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
						defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性类别)item.属性类别);
						defaultInterpolatedStringHandler.AppendLiteral("/");
						defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)item.属性标识);
						array2[0] = defaultInterpolatedStringHandler.ToStringAndClear();
						array2[1] = $"{value[(int)CS_0024_003C_003E8__locals120.zCvCsL3xFn]}";
						list.Add(array2);
						StringBuilder stringBuilder = CS_0024_003C_003E8__locals120.NCgCUQI4FB;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 4, stringBuilder);
						handler.AppendFormatted(问道数据类.Get属性颜色((AllEnums.属性类别)item.属性类别));
						handler.AppendLiteral("↑ ");
						handler.AppendFormatted((AllEnums.属性名字Type)item.属性标识);
						handler.AppendLiteral(" ");
						handler.AppendFormatted(item.属性数值);
						handler.AppendLiteral(" → ");
						handler.AppendFormatted(value[(int)CS_0024_003C_003E8__locals120.zCvCsL3xFn]);
						handler.AppendLiteral(" 增加#n#r");
						stringBuilder.Append(ref handler);
					}
				}
				if (CS_0024_003C_003E8__locals120.SMPCdNHeBL.Count <= 0)
				{
					return;
				}
				CS_0024_003C_003E8__locals120.S7gCbdpPoI = 0;
				CS_0024_003C_003E8__locals120.RP9CKhJ8kt = (float)已有进度 * 1f / (float)CS_0024_003C_003E8__locals120.al7CufZc4q.需求数量;
				float 浮动几率 = (float)CS_0024_003C_003E8__locals120.al7CufZc4q.浮动率 * 1f / 100f;
				CS_0024_003C_003E8__locals120.q7XCR9Ffcb = CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].最大耐久度;
				int 随机值 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				for (int i7 = 0; i7 < CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.WRGCJgXV80].数量; i7++)
				{
					CS_0024_003C_003E8__locals120.S7gCbdpPoI++;
					已有进度++;
					CS_0024_003C_003E8__locals120.RP9CKhJ8kt = (float)已有进度 * 1f / (float)CS_0024_003C_003E8__locals120.al7CufZc4q.需求数量;
					if (CS_0024_003C_003E8__locals120.RP9CKhJ8kt >= 浮动几率)
					{
						if (CS_0024_003C_003E8__locals120.RP9CKhJ8kt >= 1f || Singleton<WdAPI>.I.qrjo9TWIdy(1, 100) == 随机值)
						{
							CS_0024_003C_003E8__locals120.RP9CKhJ8kt = 1f;
							break;
						}
						await Task.Delay(1);
					}
				}
				CS_0024_003C_003E8__locals120.AF8yzm4fGY.销毁回调事件 =  async (string v) =>
				{
					if (!(v != CS_0024_003C_003E8__locals120.al7CufZc4q.需求材料))
					{
						CS_0024_003C_003E8__locals120.AF8yzm4fGY.销毁回调事件 = null;
						MyNATSocketClient myNATSocketClient7 = CS_0024_003C_003E8__locals120.AF8yzm4fGY;
						WdAPI i8 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(21, 3);
						defaultInterpolatedStringHandler2.AppendLiteral("#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.BDjCwsXeja].名字);
						defaultInterpolatedStringHandler2.AppendLiteral("#n吸收了#R");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals120.S7gCbdpPoI);
						defaultInterpolatedStringHandler2.AppendLiteral("#n个#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.WRGCJgXV80].名字);
						defaultInterpolatedStringHandler2.AppendLiteral("#n中的灵气。");
						myNATSocketClient7.C_Send(i8.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						if (CS_0024_003C_003E8__locals120.RP9CKhJ8kt < 1f)
						{
							Singleton<WdAPI>.I.Mr8ICwW3qX(CS_0024_003C_003E8__locals120.AF8yzm4fGY, CS_0024_003C_003E8__locals120.BDjCwsXeja, "max_durability", $"{CS_0024_003C_003E8__locals120.q7XCR9Ffcb + CS_0024_003C_003E8__locals120.S7gCbdpPoI}");
							MyNATSocketClient myNATSocketClient8 = CS_0024_003C_003E8__locals120.AF8yzm4fGY;
							WdAPI i9 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(29, 1);
							defaultInterpolatedStringHandler2.AppendLiteral("很遗憾，#R升阶失败#n了！当前升阶几率提升至#R");
							defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals120.RP9CKhJ8kt * 100f, "F2");
							defaultInterpolatedStringHandler2.AppendLiteral("%#n。");
							myNATSocketClient8.C_Send(i9.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						}
						else
						{
							CS_0024_003C_003E8__locals120.SMPCdNHeBL.Add(new string[2]
							{
								"max_durability",
								$"{100000 + (int)CS_0024_003C_003E8__locals120.zCvCsL3xFn * 10000}"
							});
							Singleton<WdAPI>.I.NNfIVUuyWv(CS_0024_003C_003E8__locals120.AF8yzm4fGY, CS_0024_003C_003E8__locals120.BDjCwsXeja, CS_0024_003C_003E8__locals120.SMPCdNHeBL);
							await Task.Delay(200);
							CS_0024_003C_003E8__locals120.AF8yzm4fGY.C_Send(Singleton<WdAPI>.I.对话生成_自己(CS_0024_003C_003E8__locals120.AF8yzm4fGY, CS_0024_003C_003E8__locals120.NCgCUQI4FB.ToString()));
						}
					}
				};
				CS_0024_003C_003E8__locals120.AF8yzm4fGY.C_Send(Singleton<WdAPI>.I.QewoEwLLTD("装备升阶中", 1));
				if (CS_0024_003C_003E8__locals120.S7gCbdpPoI >= CS_0024_003C_003E8__locals120.AF8yzm4fGY.user.背包数据.物品列表[CS_0024_003C_003E8__locals120.WRGCJgXV80].数量)
				{
					CS_0024_003C_003E8__locals120.AF8yzm4fGY.S_Send(Singleton<WdAPI>.I.CxWI0uMCPh(CS_0024_003C_003E8__locals120.AF8yzm4fGY, CS_0024_003C_003E8__locals120.WRGCJgXV80));
				}
				else
				{
					CS_0024_003C_003E8__locals120.AF8yzm4fGY.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(CS_0024_003C_003E8__locals120.WRGCJgXV80, CS_0024_003C_003E8__locals120.S7gCbdpPoI));
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("装备升阶确定处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void Qenmwn5Jk4(MyNATSocketClient P_0, int P_1, int P_2, string P_3)
	{
		_003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass34_0();
		CS_0024_003C_003E8__locals2.mWACgBQNDk = P_1;
		try
		{
			P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_2].封包缓存, P_2));
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.Find( (宠物缓存数据类 a) => a.宠物ID != 0 && a.PetID == CS_0024_003C_003E8__locals2.mWACgBQNDk);
			if (宠物缓存数据类2 == null)
			{
				return;
			}
			int value;
			int value2;
			int value3;
			int value4;
			if (Singleton<全局变量类>.I.元神系统配置.心法升级配置.Is等级要求 && 宠物缓存数据类2.等级 < Singleton<全局变量类>.I.元神系统配置.心法升级配置.最低等级)
			{
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
				defaultInterpolatedStringHandler.AppendLiteral("#R");
				defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n的等级不足#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.心法升级配置.最低等级);
				defaultInterpolatedStringHandler.AppendLiteral("#n级，无法使用#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else if (Singleton<全局变量类>.I.元神系统配置.心法升级配置.Is武学要求 && 宠物缓存数据类2.武学 < Singleton<全局变量类>.I.元神系统配置.心法升级配置.最低武学)
			{
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
				defaultInterpolatedStringHandler.AppendLiteral("#R");
				defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
				defaultInterpolatedStringHandler.AppendLiteral("#n的武学不足#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.心法升级配置.最低武学);
				defaultInterpolatedStringHandler.AppendLiteral("#n点，无法使用#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else if (宠物缓存数据类2.技能列表.TryGetValue("气血增加", out value) && 宠物缓存数据类2.技能列表.TryGetValue("速度增加", out value2) && 宠物缓存数据类2.技能列表.TryGetValue("攻击增加", out value3) && 宠物缓存数据类2.技能列表.TryGetValue("防御增加", out value4))
			{
				if (value < Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求 && value2 < Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求 && value3 < Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求 && value4 < Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求)
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(61, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的#R气血增加#n、#R速度增加#n、#R攻击增加#n、#R防御增加#n心法等级不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_3);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				else if (value >= Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级 && value2 >= Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级 && value3 >= Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级 && value4 >= Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级)
				{
					WdAPI i4 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(64, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的#R气血增加#n、#R速度增加#n、#R攻击增加#n、#R防御增加#n心法等级已经全部达到#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法继续提升了。");
					P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				else if ((!(P_3 == Singleton<全局变量类>.I.元神系统配置.心法升级配置.气血升级道具) || Pw4mb7IYFy(P_0, "气血增加", value, 宠物缓存数据类2.昵称A, P_3)) && (!(P_3 == Singleton<全局变量类>.I.元神系统配置.心法升级配置.速度升级道具) || Pw4mb7IYFy(P_0, "速度增加", value2, 宠物缓存数据类2.昵称A, P_3)) && (!(P_3 == Singleton<全局变量类>.I.元神系统配置.心法升级配置.攻击升级道具) || Pw4mb7IYFy(P_0, "攻击增加", value3, 宠物缓存数据类2.昵称A, P_3)) && (!(P_3 == Singleton<全局变量类>.I.元神系统配置.心法升级配置.防御升级道具) || Pw4mb7IYFy(P_0, "防御增加", value4, 宠物缓存数据类2.昵称A, P_3)) && (!(P_3 == Singleton<全局变量类>.I.元神系统配置.心法升级配置.随机升级道具) || Pw4mb7IYFy(P_0, "气血增加", value, 宠物缓存数据类2.昵称A, P_3) || Pw4mb7IYFy(P_0, "速度增加", value2, 宠物缓存数据类2.昵称A, P_3) || Pw4mb7IYFy(P_0, "攻击增加", value3, 宠物缓存数据类2.昵称A, P_3) || Pw4mb7IYFy(P_0, "防御增加", value4, 宠物缓存数据类2.昵称A, P_3)))
				{
					WdAPI i5 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
					defaultInterpolatedStringHandler.AppendLiteral("!^元神系统_心法升级");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.宠物ID);
					defaultInterpolatedStringHandler.AppendLiteral("|");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					string 执行关键词 = defaultInterpolatedStringHandler.ToStringAndClear();
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral("请输入#R");
					defaultInterpolatedStringHandler.AppendFormatted(宠物缓存数据类2.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n要服用的#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_3);
					defaultInterpolatedStringHandler.AppendLiteral("#n数量：");
					P_0.C_Send(i5.组包输入数字框(P_0, 执行关键词, defaultInterpolatedStringHandler.ToStringAndClear(), P_0.user.背包数据.物品列表[P_2].数量));
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("道友宠物道具询问处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private bool Pw4mb7IYFy(MyNATSocketClient P_0, string P_1, int P_2, string P_3, string P_4)
	{
		if (P_2 <= 0)
		{
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_3);
			defaultInterpolatedStringHandler.AppendLiteral("#n并没有学习过#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("#n心法，无法使用#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			defaultInterpolatedStringHandler.AppendLiteral("#n。");
			P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			return false;
		}
		if (P_2 < Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求)
		{
			WdAPI i2 = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 4);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_3);
			defaultInterpolatedStringHandler.AppendLiteral("#n的#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("#n心法等级不足#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求);
			defaultInterpolatedStringHandler.AppendLiteral("#n级，无法使用#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			defaultInterpolatedStringHandler.AppendLiteral("#n。");
			P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			return false;
		}
		if (P_2 >= Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级)
		{
			WdAPI i3 = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 4);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_3);
			defaultInterpolatedStringHandler.AppendLiteral("#n的#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("#n心法等级超过#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级);
			defaultInterpolatedStringHandler.AppendLiteral("#n级，无法使用#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			defaultInterpolatedStringHandler.AppendLiteral("#n。");
			P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			return false;
		}
		return true;
	}

	
	private async Task l02mJcku8S(MyNATSocketClient P_0, string P_1, string P_2)
	{
		_003C_003Ec__DisplayClass36_0 CS_0024_003C_003E8__locals100 = new _003C_003Ec__DisplayClass36_0();
		CS_0024_003C_003E8__locals100.EwgClX6wxK = P_0;
		try
		{
			if (!Singleton<全局变量类>.I.元神系统配置.心法升级配置.功能开关)
			{
				return;
			}
			if (string.IsNullOrWhiteSpace(P_1) || string.IsNullOrWhiteSpace(P_2))
			{
				CS_0024_003C_003E8__locals100.EwgClX6wxK.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的心法升级物品有误，原因：1！"));
				return;
			}
			new StringBuilder();
			string[] array = P_1.Split("|");
			int result;
			int result2;
			if (array.Length != 2)
			{
				CS_0024_003C_003E8__locals100.EwgClX6wxK.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的心法升级物品有误，原因：2！"));
			}
			else if (!int.TryParse(array[0], out CS_0024_003C_003E8__locals100.bEcC85ooIg) || !int.TryParse(array[1], out result) || !int.TryParse(P_2, out result2))
			{
				CS_0024_003C_003E8__locals100.EwgClX6wxK.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的心法升级物品有误，原因：3！"));
			}
			else
			{
				if (CS_0024_003C_003E8__locals100.EwgClX6wxK.user.缓存数据.is使用仙灵卡 || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals100.EwgClX6wxK, result) || CS_0024_003C_003E8__locals100.EwgClX6wxK.user.背包数据.物品列表[result].物品ID == 0 || CS_0024_003C_003E8__locals100.EwgClX6wxK.user.背包数据.物品列表[result].数量 < result2 || result2 <= 0)
				{
					return;
				}
				CS_0024_003C_003E8__locals100.E0OCIp6JbR = CS_0024_003C_003E8__locals100.EwgClX6wxK.user.背包数据.物品列表[result].名字;
				if (!Singleton<ByteAPI>.I.寻找文本(sK3m8a9JNp.ToString(), "|" + CS_0024_003C_003E8__locals100.E0OCIp6JbR + "|"))
				{
					return;
				}
				CS_0024_003C_003E8__locals100.EnMCoFeex4 = CS_0024_003C_003E8__locals100.EwgClX6wxK.user.宠物数据.Find( (宠物缓存数据类 a) => a.宠物ID != 0 && a.宠物ID == CS_0024_003C_003E8__locals100.bEcC85ooIg);
				if (CS_0024_003C_003E8__locals100.EnMCoFeex4 == null || (Singleton<全局变量类>.I.元神系统配置.心法升级配置.Is等级要求 && CS_0024_003C_003E8__locals100.EnMCoFeex4.等级 < Singleton<全局变量类>.I.元神系统配置.心法升级配置.最低等级) || (Singleton<全局变量类>.I.元神系统配置.心法升级配置.Is武学要求 && CS_0024_003C_003E8__locals100.EnMCoFeex4.武学 < Singleton<全局变量类>.I.元神系统配置.心法升级配置.最低武学) || !CS_0024_003C_003E8__locals100.EnMCoFeex4.技能列表.TryGetValue("气血增加", out CS_0024_003C_003E8__locals100.lH3CBKUqT9) || !CS_0024_003C_003E8__locals100.EnMCoFeex4.技能列表.TryGetValue("速度增加", out CS_0024_003C_003E8__locals100.Oi3CGBK4RK) || !CS_0024_003C_003E8__locals100.EnMCoFeex4.技能列表.TryGetValue("攻击增加", out CS_0024_003C_003E8__locals100.RZcCfaIKmx) || !CS_0024_003C_003E8__locals100.EnMCoFeex4.技能列表.TryGetValue("防御增加", out CS_0024_003C_003E8__locals100.qQXC6rp2Kx))
				{
					return;
				}
				if (CS_0024_003C_003E8__locals100.lH3CBKUqT9 < Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求 || CS_0024_003C_003E8__locals100.Oi3CGBK4RK < Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求 || CS_0024_003C_003E8__locals100.RZcCfaIKmx < Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求 || CS_0024_003C_003E8__locals100.qQXC6rp2Kx < Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求)
				{
					MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals100.EwgClX6wxK;
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(61, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals100.EnMCoFeex4.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的#R气血增加#n、#R速度增加#n、#R攻击增加#n、#R防御增加#n心法等级不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法使用#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals100.E0OCIp6JbR);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (CS_0024_003C_003E8__locals100.lH3CBKUqT9 >= Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级 || CS_0024_003C_003E8__locals100.Oi3CGBK4RK >= Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级 || CS_0024_003C_003E8__locals100.RZcCfaIKmx >= Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级 || CS_0024_003C_003E8__locals100.qQXC6rp2Kx >= Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级)
				{
					MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals100.EwgClX6wxK;
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(64, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals100.EnMCoFeex4.昵称A);
					defaultInterpolatedStringHandler.AppendLiteral("#n的#R气血增加#n、#R速度增加#n、#R攻击增加#n、#R防御增加#n心法等级已经全部达到#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法继续提升了。");
					myNATSocketClient2.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				int num = 0;
				CS_0024_003C_003E8__locals100.CYuCiPOiDJ = new int[4];
				bool[] array2 = new bool[4] { true, true, true, true };
				int 数量 = CS_0024_003C_003E8__locals100.EwgClX6wxK.user.背包数据.物品列表[result].数量;
				CS_0024_003C_003E8__locals100.uaOCNtuf44 = 0;
				bool flag;
				do
				{
					flag = array2.All( (bool x) => !x);
					if (flag)
					{
						break;
					}
					if (CS_0024_003C_003E8__locals100.E0OCIp6JbR == Singleton<全局变量类>.I.元神系统配置.心法升级配置.随机升级道具)
					{
						num = Singleton<WdAPI>.I.qrjo9TWIdy(0, 3);
					}
					else if (CS_0024_003C_003E8__locals100.E0OCIp6JbR == Singleton<全局变量类>.I.元神系统配置.心法升级配置.气血升级道具)
					{
						num = 0;
					}
					else if (CS_0024_003C_003E8__locals100.E0OCIp6JbR == Singleton<全局变量类>.I.元神系统配置.心法升级配置.速度升级道具)
					{
						num = 1;
					}
					else if (CS_0024_003C_003E8__locals100.E0OCIp6JbR == Singleton<全局变量类>.I.元神系统配置.心法升级配置.攻击升级道具)
					{
						num = 2;
					}
					else if (CS_0024_003C_003E8__locals100.E0OCIp6JbR == Singleton<全局变量类>.I.元神系统配置.心法升级配置.防御升级道具)
					{
						num = 3;
					}
					CS_0024_003C_003E8__locals100.EnMCoFeex4.技能列表.TryGetValue(sERmNhDmob[num], out var value);
					int num2 = value + CS_0024_003C_003E8__locals100.CYuCiPOiDJ[num];
					if (num2 >= Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最高升级等级)
					{
						array2[num] = false;
						continue;
					}
					int num3 = (num2 - Singleton<全局变量类>.I.元神系统配置.心法升级配置.心法最低等级要求) * Singleton<全局变量类>.I.元神系统配置.心法升级配置.最低消耗数量 * Singleton<全局变量类>.I.元神系统配置.心法升级配置.递增消耗倍数 + Singleton<全局变量类>.I.元神系统配置.心法升级配置.最低消耗数量;
					if (CS_0024_003C_003E8__locals100.uaOCNtuf44 + num3 > result2)
					{
						break;
					}
					CS_0024_003C_003E8__locals100.uaOCNtuf44 += num3;
					CS_0024_003C_003E8__locals100.CYuCiPOiDJ[num]++;
				}
				while (!flag);
				if (CS_0024_003C_003E8__locals100.CYuCiPOiDJ.All( (int x) => x <= 0))
				{
					CS_0024_003C_003E8__locals100.EwgClX6wxK.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + CS_0024_003C_003E8__locals100.E0OCIp6JbR + "#n的数量不足以提升#R气血增加#n、#R速度增加#n、#R攻击增加#n、#R防御增加#n其中任何#R1#n级心法等级。"));
					return;
				}
				CS_0024_003C_003E8__locals100.EwgClX6wxK.销毁回调事件 =  (string v) =>
				{
					if (!(v != CS_0024_003C_003E8__locals100.E0OCIp6JbR))
					{
						CS_0024_003C_003E8__locals100.EwgClX6wxK.销毁回调事件 = null;
						MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals100.EwgClX6wxK;
						WdAPI i3 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(21, 3);
						defaultInterpolatedStringHandler2.AppendLiteral("你的宠物#R");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.EnMCoFeex4.昵称A);
						defaultInterpolatedStringHandler2.AppendLiteral("#n消耗了#R");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.uaOCNtuf44);
						defaultInterpolatedStringHandler2.AppendLiteral("#n个#R");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.E0OCIp6JbR);
						defaultInterpolatedStringHandler2.AppendLiteral("#n。");
						myNATSocketClient3.C_Send(i3.提示_杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
						List<string[]> list = new List<string[]>();
						for (int j = 0; j < CS_0024_003C_003E8__locals100.CYuCiPOiDJ.Length; j++)
						{
							if (CS_0024_003C_003E8__locals100.CYuCiPOiDJ[j] > 0 && 问道数据类.所有技能ID.TryGetValue(sERmNhDmob[j], out var value2))
							{
								switch (j)
								{
								case 0:
								{
									list.Add(new string[2]
									{
										$"{value2}",
										$"{CS_0024_003C_003E8__locals100.lH3CBKUqT9 + CS_0024_003C_003E8__locals100.CYuCiPOiDJ[j]}"
									});
									MyNATSocketClient myNATSocketClient7 = CS_0024_003C_003E8__locals100.EwgClX6wxK;
									WdAPI i7 = Singleton<WdAPI>.I;
									defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(34, 4);
									defaultInterpolatedStringHandler2.AppendLiteral("你的宠物#R");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.EnMCoFeex4.昵称A);
									defaultInterpolatedStringHandler2.AppendLiteral("#n的心法技能#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(sERmNhDmob[j]);
									defaultInterpolatedStringHandler2.AppendLiteral("#n等级提升#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.lH3CBKUqT9);
									defaultInterpolatedStringHandler2.AppendLiteral("#n→#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.lH3CBKUqT9 + CS_0024_003C_003E8__locals100.CYuCiPOiDJ[j]);
									defaultInterpolatedStringHandler2.AppendLiteral("#G↑#n。");
									myNATSocketClient7.C_Send(i7.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
									break;
								}
								case 1:
								{
									list.Add(new string[2]
									{
										$"{value2}",
										$"{CS_0024_003C_003E8__locals100.Oi3CGBK4RK + CS_0024_003C_003E8__locals100.CYuCiPOiDJ[j]}"
									});
									MyNATSocketClient myNATSocketClient6 = CS_0024_003C_003E8__locals100.EwgClX6wxK;
									WdAPI i6 = Singleton<WdAPI>.I;
									defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(34, 4);
									defaultInterpolatedStringHandler2.AppendLiteral("你的宠物#R");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.EnMCoFeex4.昵称A);
									defaultInterpolatedStringHandler2.AppendLiteral("#n的心法技能#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(sERmNhDmob[j]);
									defaultInterpolatedStringHandler2.AppendLiteral("#n等级提升#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.Oi3CGBK4RK);
									defaultInterpolatedStringHandler2.AppendLiteral("#n→#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.Oi3CGBK4RK + CS_0024_003C_003E8__locals100.CYuCiPOiDJ[j]);
									defaultInterpolatedStringHandler2.AppendLiteral("#G↑#n。");
									myNATSocketClient6.C_Send(i6.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
									break;
								}
								case 2:
								{
									list.Add(new string[2]
									{
										$"{value2}",
										$"{CS_0024_003C_003E8__locals100.RZcCfaIKmx + CS_0024_003C_003E8__locals100.CYuCiPOiDJ[j]}"
									});
									MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals100.EwgClX6wxK;
									WdAPI i5 = Singleton<WdAPI>.I;
									defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(34, 4);
									defaultInterpolatedStringHandler2.AppendLiteral("你的宠物#R");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.EnMCoFeex4.昵称A);
									defaultInterpolatedStringHandler2.AppendLiteral("#n的心法技能#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(sERmNhDmob[j]);
									defaultInterpolatedStringHandler2.AppendLiteral("#n等级提升#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.RZcCfaIKmx);
									defaultInterpolatedStringHandler2.AppendLiteral("#n→#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.RZcCfaIKmx + CS_0024_003C_003E8__locals100.CYuCiPOiDJ[j]);
									defaultInterpolatedStringHandler2.AppendLiteral("#G↑#n。");
									myNATSocketClient5.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
									break;
								}
								case 3:
								{
									list.Add(new string[2]
									{
										$"{value2}",
										$"{CS_0024_003C_003E8__locals100.qQXC6rp2Kx + CS_0024_003C_003E8__locals100.CYuCiPOiDJ[j]}"
									});
									MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals100.EwgClX6wxK;
									WdAPI i4 = Singleton<WdAPI>.I;
									defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(34, 4);
									defaultInterpolatedStringHandler2.AppendLiteral("你的宠物#R");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.EnMCoFeex4.昵称A);
									defaultInterpolatedStringHandler2.AppendLiteral("#n的心法技能#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(sERmNhDmob[j]);
									defaultInterpolatedStringHandler2.AppendLiteral("#n等级提升#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.qQXC6rp2Kx);
									defaultInterpolatedStringHandler2.AppendLiteral("#n→#Y");
									defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals100.qQXC6rp2Kx + CS_0024_003C_003E8__locals100.CYuCiPOiDJ[j]);
									defaultInterpolatedStringHandler2.AppendLiteral("#G↑#n。");
									myNATSocketClient4.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
									break;
								}
								}
							}
						}
						if (list.Count > 0)
						{
							Singleton<WdAPI>.I.f5oIxL5Jqw(CS_0024_003C_003E8__locals100.EwgClX6wxK, CS_0024_003C_003E8__locals100.EwgClX6wxK.user.人物数据.昵称, CS_0024_003C_003E8__locals100.EnMCoFeex4.宠物ID.ToString(), list);
						}
					}
				};
				if (CS_0024_003C_003E8__locals100.uaOCNtuf44 >= 数量)
				{
					CS_0024_003C_003E8__locals100.EwgClX6wxK.S_Send(Singleton<WdAPI>.I.CxWI0uMCPh(CS_0024_003C_003E8__locals100.EwgClX6wxK, result));
				}
				else
				{
					CS_0024_003C_003E8__locals100.EwgClX6wxK.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(result, CS_0024_003C_003E8__locals100.uaOCNtuf44));
				}
				await Task.Delay(100);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("心法升级确定处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void QKImKoWgLf(MyNATSocketClient P_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder("道友可对引灵幡进行附灵操作，附灵几率#Y100%#n成功：#r");
			if (P_0.user.背包数据.物品列表[41].名字 == Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.一阶灵幡名字 && P_0.user.背包数据.物品列表[41].物品ID != 0 && P_0.user.背包数据.物品列表[41].最大炼魂值 >= 10000)
			{
				if (P_0.user.背包数据.物品列表[41].当前耐久度 < 10000)
				{
					Singleton<WdAPI>.I.Mr8ICwW3qX(P_0, 41, "durability", "1000000");
				}
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(15, 1, stringBuilder2);
				handler.AppendLiteral("[附灵");
				handler.AppendFormatted(P_0.user.背包数据.物品列表[41].名字);
				handler.AppendLiteral("/元神系统_附灵灵幡1]");
				stringBuilder3.Append(ref handler);
			}
			if (P_0.user.背包数据.物品列表[42].名字 == Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.二阶灵幡名字 && P_0.user.背包数据.物品列表[42].物品ID != 0 && P_0.user.背包数据.物品列表[42].最大炼魂值 >= 20000)
			{
				if (P_0.user.背包数据.物品列表[42].当前耐久度 < 10000)
				{
					Singleton<WdAPI>.I.Mr8ICwW3qX(P_0, 42, "durability", "1000000");
				}
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(15, 1, stringBuilder2);
				handler.AppendLiteral("[附灵");
				handler.AppendFormatted(P_0.user.背包数据.物品列表[42].名字);
				handler.AppendLiteral("/元神系统_附灵灵幡2]");
				stringBuilder4.Append(ref handler);
			}
			if (P_0.user.背包数据.物品列表[43].名字 == Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.三阶灵幡名字 && P_0.user.背包数据.物品列表[43].物品ID != 0 && P_0.user.背包数据.物品列表[43].最大炼魂值 >= 30000)
			{
				if (P_0.user.背包数据.物品列表[43].当前耐久度 < 10000)
				{
					Singleton<WdAPI>.I.Mr8ICwW3qX(P_0, 43, "durability", "1000000");
				}
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(15, 1, stringBuilder2);
				handler.AppendLiteral("[附灵");
				handler.AppendFormatted(P_0.user.背包数据.物品列表[43].名字);
				handler.AppendLiteral("/元神系统_附灵灵幡3]");
				stringBuilder5.Append(ref handler);
			}
			if (P_0.user.背包数据.物品列表[44].名字 == Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.四阶灵幡名字 && P_0.user.背包数据.物品列表[44].物品ID != 0 && P_0.user.背包数据.物品列表[44].最大炼魂值 >= 40000)
			{
				if (P_0.user.背包数据.物品列表[44].当前耐久度 < 10000)
				{
					Singleton<WdAPI>.I.Mr8ICwW3qX(P_0, 44, "durability", "1000000");
				}
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder6 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(15, 1, stringBuilder2);
				handler.AppendLiteral("[附灵");
				handler.AppendFormatted(P_0.user.背包数据.物品列表[44].名字);
				handler.AppendLiteral("/元神系统_附灵灵幡4]");
				stringBuilder6.Append(ref handler);
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_自己(P_0, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("道友_灵幡附灵请求处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void wl2mRN5WkM(MyNATSocketClient P_0, string P_1, string P_2)
	{
		try
		{
			string text = P_1.Replace("元神系统_附灵灵幡", string.Empty);
			int num = 0;
			int value = 0;
			物品信息类 物品信息类2 = null;
			if (!(text == "1"))
			{
				if (!(text == "2"))
				{
					if (!(text == "3"))
					{
						if (text == "4")
						{
							物品信息类2 = P_0.user.背包数据.物品列表[44];
							if (物品信息类2.名字 != Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.四阶灵幡名字 || 物品信息类2.物品ID == 0 || 物品信息类2.最大炼魂值 < 40000)
							{
								return;
							}
							num = 物品信息类2.最大炼魂值;
							value = 物品信息类2.最大炼魂值 - 40000;
						}
					}
					else
					{
						物品信息类2 = P_0.user.背包数据.物品列表[43];
						if (物品信息类2.名字 != Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.三阶灵幡名字 || 物品信息类2.物品ID == 0 || 物品信息类2.最大炼魂值 < 30000)
						{
							return;
						}
						num = 物品信息类2.最大炼魂值;
						value = 物品信息类2.最大炼魂值 - 30000;
					}
				}
				else
				{
					物品信息类2 = P_0.user.背包数据.物品列表[42];
					if (物品信息类2.名字 != Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.二阶灵幡名字 || 物品信息类2.物品ID == 0 || 物品信息类2.最大炼魂值 < 20000)
					{
						return;
					}
					num = 物品信息类2.最大炼魂值;
					value = 物品信息类2.最大炼魂值 - 20000;
				}
			}
			else
			{
				物品信息类2 = P_0.user.背包数据.物品列表[41];
				if (物品信息类2.名字 != Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.一阶灵幡名字 || 物品信息类2.物品ID == 0 || 物品信息类2.最大炼魂值 < 10000)
				{
					return;
				}
				num = 物品信息类2.最大炼魂值;
				value = 物品信息类2.最大炼魂值 - 10000;
			}
			if (Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryGetValue(num + 1, out 引灵幡属性列表类 value2) && 物品信息类2 != null && value2.需求数量 > 0 && !string.IsNullOrWhiteSpace(value2.附灵道具))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 4);
				defaultInterpolatedStringHandler.AppendLiteral("请提交#R");
				defaultInterpolatedStringHandler.AppendFormatted(物品信息类2.名字);
				defaultInterpolatedStringHandler.AppendLiteral("·");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("品#n附灵所需要的#R");
				defaultInterpolatedStringHandler.AppendFormatted(value2.需求数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(value2.附灵道具);
				defaultInterpolatedStringHandler.AppendLiteral("#n，附灵成功后品阶提升#Y1#n品。");
				StringBuilder value3 = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[@/$*元神系统_附灵确定");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(value3);
				defaultInterpolatedStringHandler.AppendLiteral(",1,0]\r\n");
				P_0.C_Send(i.组包提交物品框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}
		catch (Exception ex)
		{
			Log.Error("附灵灵幡提交处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private async Task XGomdfB8td(MyNATSocketClient P_0, string P_1, string P_2)
	{
		_003C_003Ec__DisplayClass39_0 CS_0024_003C_003E8__locals57 = new _003C_003Ec__DisplayClass39_0();
		CS_0024_003C_003E8__locals57.lYJCPgtNtn = P_0;
		try
		{
			Regex regex = new Regex("(?<=\\,)\\d+(?=\\:)");
			if (!int.TryParse(P_1, out CS_0024_003C_003E8__locals57.LHaCXCIy2m) || !int.TryParse(regex.Match(P_2)?.Value, out var result))
			{
				return;
			}
			CS_0024_003C_003E8__locals57.lYJCPgtNtn.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(CS_0024_003C_003E8__locals57.lYJCPgtNtn.user.背包数据.物品列表[result].封包缓存, result));
			if (!Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals57.lYJCPgtNtn, result))
			{
				return;
			}
			CS_0024_003C_003E8__locals57.tk1CL3okF6 = CS_0024_003C_003E8__locals57.lYJCPgtNtn.user.背包数据.物品列表.Find( (物品信息类 x) => x.Index == CS_0024_003C_003E8__locals57.LHaCXCIy2m + 40);
			if (CS_0024_003C_003E8__locals57.tk1CL3okF6 == null)
			{
				CS_0024_003C_003E8__locals57.lYJCPgtNtn.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R要附灵的引灵幡不存在！"));
				return;
			}
			CS_0024_003C_003E8__locals57.BJLCS0WQHs = CS_0024_003C_003E8__locals57.tk1CL3okF6.最大炼魂值 - 10000 * CS_0024_003C_003E8__locals57.LHaCXCIy2m;
			if (!Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryGetValue(CS_0024_003C_003E8__locals57.tk1CL3okF6.最大炼魂值 + 1, out CS_0024_003C_003E8__locals57.JjOCF4QNDi))
			{
				MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals57.lYJCPgtNtn;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals57.tk1CL3okF6.名字);
				defaultInterpolatedStringHandler.AppendLiteral("·");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals57.BJLCS0WQHs);
				defaultInterpolatedStringHandler.AppendLiteral("品#n无法附灵。");
				myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else
			{
				if (CS_0024_003C_003E8__locals57.JjOCF4QNDi.需求数量 <= 0 || string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals57.JjOCF4QNDi.附灵道具))
				{
					return;
				}
				if (CS_0024_003C_003E8__locals57.lYJCPgtNtn.user.背包数据.物品列表[result].名字 != CS_0024_003C_003E8__locals57.JjOCF4QNDi.附灵道具)
				{
					MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals57.lYJCPgtNtn;
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals57.tk1CL3okF6.名字);
					defaultInterpolatedStringHandler.AppendLiteral("·");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals57.BJLCS0WQHs);
					defaultInterpolatedStringHandler.AppendLiteral("品#n需要#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals57.JjOCF4QNDi.附灵道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n才能附灵。");
					myNATSocketClient2.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (CS_0024_003C_003E8__locals57.lYJCPgtNtn.user.背包数据.物品列表[result].数量 < CS_0024_003C_003E8__locals57.JjOCF4QNDi.需求数量)
				{
					MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals57.lYJCPgtNtn;
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 4);
					defaultInterpolatedStringHandler.AppendLiteral("#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals57.tk1CL3okF6.名字);
					defaultInterpolatedStringHandler.AppendLiteral("·");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals57.BJLCS0WQHs);
					defaultInterpolatedStringHandler.AppendLiteral("品#n需要#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals57.JjOCF4QNDi.需求数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals57.JjOCF4QNDi.附灵道具);
					defaultInterpolatedStringHandler.AppendLiteral("#n才能附灵。");
					myNATSocketClient3.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				CS_0024_003C_003E8__locals57.lYJCPgtNtn.销毁回调事件 =  async (string v) =>
				{
					if (!(v != CS_0024_003C_003E8__locals57.JjOCF4QNDi.附灵道具))
					{
						CS_0024_003C_003E8__locals57.lYJCPgtNtn.销毁回调事件 = null;
						List<string[]> list = new List<string[]>
						{
							new string[2]
							{
								"lianhun",
								$"{CS_0024_003C_003E8__locals57.tk1CL3okF6.最大炼魂值 + 1}"
							},
							new string[2]
							{
								"max_lianhun",
								$"{CS_0024_003C_003E8__locals57.tk1CL3okF6.最大炼魂值 + 1}"
							}
						};
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(13, 2);
						defaultInterpolatedStringHandler2.AppendLiteral("#Y");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals57.tk1CL3okF6.名字);
						defaultInterpolatedStringHandler2.AppendLiteral("·");
						defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals57.BJLCS0WQHs + 1);
						defaultInterpolatedStringHandler2.AppendLiteral("品#n附灵属性：#r");
						StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler2.ToStringAndClear());
						if (Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.附灵字典.TryGetValue(CS_0024_003C_003E8__locals57.tk1CL3okF6.最大炼魂值, out 引灵幡属性列表类 value))
						{
							for (int j = 0; j < value.属性列表.Count; j++)
							{
								string[] array = new string[2];
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
								defaultInterpolatedStringHandler2.AppendLiteral("prop/");
								defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性标识Type)value.属性列表[j].属性名字);
								array[0] = defaultInterpolatedStringHandler2.ToStringAndClear();
								array[1] = "0";
								list.Add(array);
							}
						}
						for (int k = 0; k < CS_0024_003C_003E8__locals57.JjOCF4QNDi.属性列表.Count; k++)
						{
							string[] array2 = new string[2];
							defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(5, 1);
							defaultInterpolatedStringHandler2.AppendLiteral("prop/");
							defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性标识Type)CS_0024_003C_003E8__locals57.JjOCF4QNDi.属性列表[k].属性名字);
							array2[0] = defaultInterpolatedStringHandler2.ToStringAndClear();
							array2[1] = $"{CS_0024_003C_003E8__locals57.JjOCF4QNDi.属性列表[k].属性数值}";
							list.Add(array2);
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 2, stringBuilder2);
							handler.AppendLiteral("#G");
							handler.AppendFormatted(CS_0024_003C_003E8__locals57.JjOCF4QNDi.属性列表[k].属性名字);
							handler.AppendLiteral(" ");
							handler.AppendFormatted(CS_0024_003C_003E8__locals57.JjOCF4QNDi.属性列表[k].属性数值);
							handler.AppendLiteral(" 增加#r");
							stringBuilder2.Append(ref handler);
						}
						Singleton<WdAPI>.I.NNfIVUuyWv(CS_0024_003C_003E8__locals57.lYJCPgtNtn, CS_0024_003C_003E8__locals57.tk1CL3okF6.Index, list);
						await Task.Delay(500);
						CS_0024_003C_003E8__locals57.lYJCPgtNtn.C_Send(Singleton<WdAPI>.I.对话生成_自己(CS_0024_003C_003E8__locals57.lYJCPgtNtn, stringBuilder.ToString()));
					}
				};
				CS_0024_003C_003E8__locals57.lYJCPgtNtn.C_Send(Singleton<WdAPI>.I.QewoEwLLTD("引灵幡附灵中", 1));
				if (CS_0024_003C_003E8__locals57.JjOCF4QNDi.需求数量 >= CS_0024_003C_003E8__locals57.lYJCPgtNtn.user.背包数据.物品列表[result].数量)
				{
					await CS_0024_003C_003E8__locals57.lYJCPgtNtn.S_Send异步(Singleton<WdAPI>.I.CxWI0uMCPh(CS_0024_003C_003E8__locals57.lYJCPgtNtn, result));
				}
				else
				{
					await CS_0024_003C_003E8__locals57.lYJCPgtNtn.S_Send异步(Singleton<WdAPI>.I.rxTojoeFsR(result, CS_0024_003C_003E8__locals57.JjOCF4QNDi.需求数量));
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("附灵灵幡确定处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public static bool rK5msrHmp8(string P_0, int P_1, out string P_2)
	{
		P_2 = string.Empty;
		if (string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.元神系统配置.限制使用特技地图) || string.IsNullOrWhiteSpace(P_0))
		{
			return false;
		}
		if (Singleton<全局变量类>.I.元神系统配置.限制使用特技地图 != "0" && !Singleton<ByteAPI>.I.寻找文本("|" + Singleton<全局变量类>.I.元神系统配置.限制使用特技地图 + "|", P_0))
		{
			return false;
		}
		if (string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.元神系统配置.限制使用特技名字))
		{
			return false;
		}
		foreach (KeyValuePair<string, int> item in 问道数据类.所有技能ID)
		{
			if (item.Value == P_1)
			{
				P_2 = item.Key;
				return Singleton<ByteAPI>.I.寻找文本("|" + Singleton<全局变量类>.I.元神系统配置.限制使用特技名字 + "|", "|" + item.Key + "|");
			}
		}
		return false;
	}

	
	internal async Task XnTmU999dI(MyNATSocketClient P_0)
	{
		try
		{
			AllEnums.元神境界 key = await P_0.取队长境界();
			if (Singleton<全局变量类>.I.元神系统配置.战斗背景列表.TryGetValue(key, out var value) && value != 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.bN2ozaM3HC(value));
			}
		}
		catch (Exception ex)
		{
			Log.Error("设置战斗背景-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public Ab7Ypu2aCcHMcLPG8Um()
	{
	}

	
	static Ab7Ypu2aCcHMcLPG8Um()
	{
		IkymDsp1jm = new StringBuilder();
		Yp6mjOM9qh = new StringBuilder();
		yQ0mlWibO6 = new StringBuilder();
		sK3m8a9JNp = new StringBuilder();
		xh4mILM5j1 = new StringBuilder();
		sPhmoeHQ4M = new StringBuilder();
		sERmNhDmob = new string[4]
		{
			"气血增加",
			"速度增加",
			"攻击增加",
			"防御增加"
		};
		Pihmi6fRa9 = new ConcurrentDictionary<AllEnums.元神境界, 元神特效配置类>();
	}
}
