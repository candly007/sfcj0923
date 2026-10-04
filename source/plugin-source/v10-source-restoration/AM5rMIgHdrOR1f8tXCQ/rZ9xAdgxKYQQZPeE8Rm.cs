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

namespace AM5rMIgHdrOR1f8tXCQ;

internal class rZ9xAdgxKYQQZPeE8Rm : Singleton<rZ9xAdgxKYQQZPeE8Rm>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public MyNATSocketClient WhJ5s4S7ED;

		public 精炼属性条件类 p9U5U8U5Ia;

		public List<属性数据> vWg5W1WNe0;

		public 精炼属性数值类 A7q5gn3E1Z;

		public 属性数据 zYN5DgiSbE;

		public int zVD5jxBir1;

		public 通用次数类 fR85lxAH2P;

		public StringBuilder Mnp58oSfFI;

		public byte ELc5IBRXwR;

		
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		
		internal bool XQj5btiWOG(属性数据 x)
		{
			return x.属性类别 == (int)p9U5U8U5Ia.精炼属性;
		}

		
		internal bool Njo5JrO3A7(精炼属性数值类 x)
		{
			_003C_003Ec__DisplayClass11_1 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass11_1();
			CS_0024_003C_003E8__locals7.vq05iyqwoF = this;
			CS_0024_003C_003E8__locals7.qwT5NiUI8Y = x;
			if (vWg5W1WNe0.Any( (属性数据 属性数据2) => 属性数据2.精炼属性筛选(CS_0024_003C_003E8__locals7.vq05iyqwoF.p9U5U8U5Ia.精炼属性) == (int)CS_0024_003C_003E8__locals7.qwT5NiUI8Y.属性名字 && Math.Abs(属性数据2.属性数值) >= CS_0024_003C_003E8__locals7.qwT5NiUI8Y.最小值 && Math.Abs(属性数据2.属性数值) < CS_0024_003C_003E8__locals7.qwT5NiUI8Y.最大值))
			{
				return CS_0024_003C_003E8__locals7.qwT5NiUI8Y.Is符合条件(p9U5U8U5Ia.精炼属性);
			}
			return false;
		}

		
		internal bool UMB5KotFQP(属性数据 x)
		{
			return x.精炼属性选中(p9U5U8U5Ia.精炼属性, A7q5gn3E1Z.属性名字);
		}

		
		internal bool u5j5RTjOr7(通用次数类 x)
		{
			return x.数值 > Math.Abs(zYN5DgiSbE.属性数值);
		}

		
		internal async void hYd5dZDQlV(string v)
		{
			if (!(v != p9U5U8U5Ia.消耗道具名字))
			{
				WhJ5s4S7ED.销毁回调事件 = null;
				Singleton<WdAPI>.I.PndoGw5lW7(WhJ5s4S7ED, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -zVD5jxBir1 * p9U5U8U5Ia.消耗灵气数量, false, "[个人突破-" + WhJ5s4S7ED.user.人物数据.昵称 + "-精炼消耗]");
				WhJ5s4S7ED.user.存档数据.精炼存档.精炼计数字典[p9U5U8U5Ia.精炼属性] = 0;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.物理伤害 || A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.法术伤害 || A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.改造伤害)
				{
					List<string[]> list = new List<string[]>();
					string[] array = new string[2];
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性类别)zYN5DgiSbE.属性类别);
					defaultInterpolatedStringHandler.AppendLiteral("/phy_power");
					array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array[1] = $"{fR85lxAH2P.数值}";
					list.Add(array);
					string[] array2 = new string[2];
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性类别)zYN5DgiSbE.属性类别);
					defaultInterpolatedStringHandler.AppendLiteral("/mag_power");
					array2[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[1] = $"{fR85lxAH2P.数值}";
					list.Add(array2);
					List<string[]> list2 = list;
					StringBuilder stringBuilder = Mnp58oSfFI;
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(35, 5, stringBuilder);
					handler.AppendLiteral("#26天呐，#Y");
					handler.AppendFormatted(WhJ5s4S7ED.user.人物数据.昵称);
					handler.AppendLiteral("#n的#Y");
					handler.AppendFormatted(WhJ5s4S7ED.user.背包数据.物品列表[ELc5IBRXwR].名字);
					handler.AppendLiteral("#n成功精炼！#G");
					handler.AppendFormatted((A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.改造伤害) ? "改造伤害" : "伤害");
					handler.AppendLiteral(" ");
					handler.AppendFormatted(zYN5DgiSbE.属性数值);
					handler.AppendLiteral(" #Y→#G");
					handler.AppendFormatted(fR85lxAH2P.数值);
					handler.AppendLiteral("#Y↑#G。");
					stringBuilder2.Append(ref handler);
					Singleton<WdAPI>.I.NNfIVUuyWv(WhJ5s4S7ED, ELc5IBRXwR, list2);
				}
				else if (A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.师门攻击技能消耗降低 || A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.师门障碍技能消耗降低 || A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.师门辅助技能消耗降低)
				{
					StringBuilder stringBuilder = Mnp58oSfFI;
					StringBuilder stringBuilder3 = stringBuilder;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(37, 5, stringBuilder);
					handler.AppendLiteral("#26天呐，#Y");
					handler.AppendFormatted(WhJ5s4S7ED.user.人物数据.昵称);
					handler.AppendLiteral("#n的#Y");
					handler.AppendFormatted(WhJ5s4S7ED.user.背包数据.物品列表[ELc5IBRXwR].名字);
					handler.AppendLiteral("#n成功精炼！#G");
					handler.AppendFormatted(A7q5gn3E1Z.属性名字);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Math.Abs(zYN5DgiSbE.属性数值));
					handler.AppendLiteral("% #Y→#G");
					handler.AppendFormatted(fR85lxAH2P.数值);
					handler.AppendLiteral("%#Y↑#G。");
					stringBuilder3.Append(ref handler);
					WdAPI i = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient = WhJ5s4S7ED;
					byte num = ELc5IBRXwR;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性类别)zYN5DgiSbE.属性类别);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)zYN5DgiSbE.属性标识);
					string text = defaultInterpolatedStringHandler.ToStringAndClear();
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
					defaultInterpolatedStringHandler.AppendLiteral("-");
					defaultInterpolatedStringHandler.AppendFormatted(fR85lxAH2P.数值);
					i.Mr8ICwW3qX(myNATSocketClient, num, text, defaultInterpolatedStringHandler.ToStringAndClear());
				}
				else
				{
					StringBuilder stringBuilder = Mnp58oSfFI;
					StringBuilder stringBuilder4 = stringBuilder;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(35, 5, stringBuilder);
					handler.AppendLiteral("#26天呐，#Y");
					handler.AppendFormatted(WhJ5s4S7ED.user.人物数据.昵称);
					handler.AppendLiteral("#n的#Y");
					handler.AppendFormatted(WhJ5s4S7ED.user.背包数据.物品列表[ELc5IBRXwR].名字);
					handler.AppendLiteral("#n成功精炼！#G");
					handler.AppendFormatted((AllEnums.属性名字Type)zYN5DgiSbE.属性标识);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(zYN5DgiSbE.属性数值);
					handler.AppendLiteral(" #Y→#G");
					handler.AppendFormatted(fR85lxAH2P.数值);
					handler.AppendLiteral("#Y↑#G。");
					stringBuilder4.Append(ref handler);
					WdAPI i2 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient2 = WhJ5s4S7ED;
					byte num2 = ELc5IBRXwR;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性类别)zYN5DgiSbE.属性类别);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)zYN5DgiSbE.属性标识);
					i2.Mr8ICwW3qX(myNATSocketClient2, num2, defaultInterpolatedStringHandler.ToStringAndClear(), fR85lxAH2P.数值.ToString());
				}
				MyNATSocketClient myNATSocketClient3 = WhJ5s4S7ED;
				WdAPI i3 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendFormatted(p9U5U8U5Ia.精炼属性);
				defaultInterpolatedStringHandler.AppendLiteral("精炼中");
				myNATSocketClient3.C_Send(i3.QewoEwLLTD(defaultInterpolatedStringHandler.ToStringAndClear(), 1));
				await Task.Delay(1000);
				MyNATSocketClient myNATSocketClient4 = WhJ5s4S7ED;
				WdAPI i4 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 3);
				defaultInterpolatedStringHandler.AppendLiteral("#Y精炼成功！#n你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(p9U5U8U5Ia.消耗道具数量 * zVD5jxBir1);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(p9U5U8U5Ia.消耗道具名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				string value;
				if (p9U5U8U5Ia.消耗灵气数量 > 0)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(14, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("和#R");
					defaultInterpolatedStringHandler2.AppendFormatted(p9U5U8U5Ia.消耗灵气数量 * zVD5jxBir1);
					defaultInterpolatedStringHandler2.AppendLiteral("#n点#R灵气值#n。");
					value = defaultInterpolatedStringHandler2.ToStringAndClear();
				}
				else
				{
					value = "。";
				}
				defaultInterpolatedStringHandler.AppendFormatted(value);
				myNATSocketClient4.C_Send(i4.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_中心提醒("#G精炼成功！")).ToArray());
				if (Singleton<全局变量类>.I.装备强化配置.谣言开关)
				{
					Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(Mnp58oSfFI.ToString(), "管理员"));
				}
			}
		}

		static _003C_003Ec__DisplayClass11_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_1
	{
		public 精炼属性数值类 qwT5NiUI8Y;

		public _003C_003Ec__DisplayClass11_0 vq05iyqwoF;

		
		public _003C_003Ec__DisplayClass11_1()
		{
		}

		
		internal bool oOa5oh918k(属性数据 x2)
		{
			if (x2.精炼属性筛选(vq05iyqwoF.p9U5U8U5Ia.精炼属性) == (int)qwT5NiUI8Y.属性名字 && Math.Abs(x2.属性数值) >= qwT5NiUI8Y.最小值)
			{
				return Math.Abs(x2.属性数值) < qwT5NiUI8Y.最大值;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass11_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public MyNATSocketClient uVa56UgZsu;

		public byte U3p52MeNcY;

		public byte YJb5mp7r9Z;

		
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		
		internal bool IeT5Bk6mel(精炼属性条件类 x)
		{
			return x.消耗道具名字 == uVa56UgZsu.user.背包数据.物品列表[U3p52MeNcY].名字;
		}

		
		internal bool SjN5GTPulg(AllEnums.Equip类型 x)
		{
			return x == (AllEnums.Equip类型)uVa56UgZsu.user.背包数据.物品列表[YJb5mp7r9Z].物品类型;
		}

		
		internal bool eea5f0GtAG(精炼属性条件类 x)
		{
			return x.消耗道具名字 == uVa56UgZsu.user.背包数据.物品列表[U3p52MeNcY].名字;
		}

		static _003C_003Ec__DisplayClass9_0()
		{
		}
	}

	
	[SpecialName]
	internal static bool dXBDbesuNI()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is装备强化)
		{
			return Singleton<全局变量类>.I.装备强化配置.功能开关;
		}
		return false;
	}

	
	private void knVg4QW5qI()
	{
		Singleton<全局变量类>.I.装备强化配置 = new 装备强化配置类();
		Singleton<全局变量类>.I.装备强化配置.功能开关 = true;
		Singleton<全局变量类>.I.装备强化配置.绑定装备才可精炼 = false;
		Singleton<全局变量类>.I.装备强化配置.装备最低精炼等级 = 1;
		Singleton<全局变量类>.I.装备强化配置.装备最高精炼等级 = 180;
		Singleton<全局变量类>.I.装备强化配置.条件列表.Clear();
		Singleton<全局变量类>.I.装备强化配置.属性列表.Clear();
		Singleton<全局变量类>.I.装备强化配置.可精炼装备类型.Clear();
		Singleton<全局变量类>.I.装备强化配置.可精炼装备类型.Add(AllEnums.Equip类型.武器);
		Singleton<全局变量类>.I.装备强化配置.可精炼装备类型.Add(AllEnums.Equip类型.帽子);
		Singleton<全局变量类>.I.装备强化配置.可精炼装备类型.Add(AllEnums.Equip类型.衣服);
		Singleton<全局变量类>.I.装备强化配置.可精炼装备类型.Add(AllEnums.Equip类型.鞋子);
		Singleton<全局变量类>.I.装备强化配置.可精炼装备类型.Add(AllEnums.Equip类型.腰带);
		Singleton<全局变量类>.I.装备强化配置.条件列表.Add(new 精炼属性条件类
		{
			功能开关 = true,
			精炼属性 = AllEnums.精炼属性Type.蓝属性,
			消耗道具名字 = "精炼蓝晶石",
			消耗道具数量 = 1,
			消耗灵气数量 = 10,
			装备最低改造等级 = 0
		});
		Singleton<全局变量类>.I.装备强化配置.条件列表.Add(new 精炼属性条件类
		{
			功能开关 = true,
			精炼属性 = AllEnums.精炼属性Type.粉属性,
			消耗道具名字 = "精炼粉晶石",
			消耗道具数量 = 1,
			消耗灵气数量 = 10,
			装备最低改造等级 = 0
		});
		Singleton<全局变量类>.I.装备强化配置.条件列表.Add(new 精炼属性条件类
		{
			功能开关 = true,
			精炼属性 = AllEnums.精炼属性Type.黄属性,
			消耗道具名字 = "精炼黄晶石",
			消耗道具数量 = 1,
			消耗灵气数量 = 10,
			装备最低改造等级 = 0
		});
		Singleton<全局变量类>.I.装备强化配置.条件列表.Add(new 精炼属性条件类
		{
			功能开关 = true,
			精炼属性 = AllEnums.精炼属性Type.绿属性,
			消耗道具名字 = "精炼绿晶石",
			消耗道具数量 = 1,
			消耗灵气数量 = 10,
			装备最低改造等级 = 0
		});
		Singleton<全局变量类>.I.装备强化配置.条件列表.Add(new 精炼属性条件类
		{
			功能开关 = true,
			精炼属性 = AllEnums.精炼属性Type.封印属性,
			消耗道具名字 = "精炼封印石",
			消耗道具数量 = 1,
			消耗灵气数量 = 10,
			装备最低改造等级 = 0
		});
		Singleton<全局变量类>.I.装备强化配置.条件列表.Add(new 精炼属性条件类
		{
			功能开关 = true,
			精炼属性 = AllEnums.精炼属性Type.改造属性,
			消耗道具名字 = "精炼五色玉",
			消耗道具数量 = 1,
			消耗灵气数量 = 10,
			装备最低改造等级 = 12
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.所有相性,
			最小值 = 1,
			最大值 = 10,
			数值次数 = new List<通用次数类>
			{
				new 通用次数类
				{
					数值 = 2,
					次数 = 1
				},
				new 通用次数类
				{
					数值 = 3,
					次数 = 5
				},
				new 通用次数类
				{
					数值 = 4,
					次数 = 10
				},
				new 通用次数类
				{
					数值 = 5,
					次数 = 20
				},
				new 通用次数类
				{
					数值 = 6,
					次数 = 40
				},
				new 通用次数类
				{
					数值 = 7,
					次数 = 80
				},
				new 通用次数类
				{
					数值 = 8,
					次数 = 120
				},
				new 通用次数类
				{
					数值 = 9,
					次数 = 160
				},
				new 通用次数类
				{
					数值 = 10,
					次数 = 200
				}
			},
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.金相性,
			最小值 = 1,
			最大值 = 10,
			数值次数 = new List<通用次数类>
			{
				new 通用次数类
				{
					数值 = 2,
					次数 = 1
				},
				new 通用次数类
				{
					数值 = 3,
					次数 = 3
				},
				new 通用次数类
				{
					数值 = 4,
					次数 = 5
				},
				new 通用次数类
				{
					数值 = 5,
					次数 = 10
				},
				new 通用次数类
				{
					数值 = 6,
					次数 = 20
				},
				new 通用次数类
				{
					数值 = 7,
					次数 = 40
				},
				new 通用次数类
				{
					数值 = 8,
					次数 = 80
				},
				new 通用次数类
				{
					数值 = 9,
					次数 = 160
				},
				new 通用次数类
				{
					数值 = 10,
					次数 = 200
				}
			},
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.木相性,
			最小值 = 1,
			最大值 = 10,
			数值次数 = new List<通用次数类>
			{
				new 通用次数类
				{
					数值 = 2,
					次数 = 1
				},
				new 通用次数类
				{
					数值 = 3,
					次数 = 3
				},
				new 通用次数类
				{
					数值 = 4,
					次数 = 5
				},
				new 通用次数类
				{
					数值 = 5,
					次数 = 10
				},
				new 通用次数类
				{
					数值 = 6,
					次数 = 20
				},
				new 通用次数类
				{
					数值 = 7,
					次数 = 40
				},
				new 通用次数类
				{
					数值 = 8,
					次数 = 80
				},
				new 通用次数类
				{
					数值 = 9,
					次数 = 160
				},
				new 通用次数类
				{
					数值 = 10,
					次数 = 200
				}
			},
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.水相性,
			最小值 = 1,
			最大值 = 10,
			数值次数 = new List<通用次数类>
			{
				new 通用次数类
				{
					数值 = 2,
					次数 = 1
				},
				new 通用次数类
				{
					数值 = 3,
					次数 = 3
				},
				new 通用次数类
				{
					数值 = 4,
					次数 = 5
				},
				new 通用次数类
				{
					数值 = 5,
					次数 = 10
				},
				new 通用次数类
				{
					数值 = 6,
					次数 = 20
				},
				new 通用次数类
				{
					数值 = 7,
					次数 = 40
				},
				new 通用次数类
				{
					数值 = 8,
					次数 = 80
				},
				new 通用次数类
				{
					数值 = 9,
					次数 = 160
				},
				new 通用次数类
				{
					数值 = 10,
					次数 = 200
				}
			},
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.火相性,
			最小值 = 1,
			最大值 = 10,
			数值次数 = new List<通用次数类>
			{
				new 通用次数类
				{
					数值 = 2,
					次数 = 1
				},
				new 通用次数类
				{
					数值 = 3,
					次数 = 3
				},
				new 通用次数类
				{
					数值 = 4,
					次数 = 5
				},
				new 通用次数类
				{
					数值 = 5,
					次数 = 10
				},
				new 通用次数类
				{
					数值 = 6,
					次数 = 20
				},
				new 通用次数类
				{
					数值 = 7,
					次数 = 40
				},
				new 通用次数类
				{
					数值 = 8,
					次数 = 80
				},
				new 通用次数类
				{
					数值 = 9,
					次数 = 160
				},
				new 通用次数类
				{
					数值 = 10,
					次数 = 200
				}
			},
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.土相性,
			最小值 = 1,
			最大值 = 10,
			数值次数 = new List<通用次数类>
			{
				new 通用次数类
				{
					数值 = 2,
					次数 = 1
				},
				new 通用次数类
				{
					数值 = 3,
					次数 = 3
				},
				new 通用次数类
				{
					数值 = 4,
					次数 = 5
				},
				new 通用次数类
				{
					数值 = 5,
					次数 = 10
				},
				new 通用次数类
				{
					数值 = 6,
					次数 = 20
				},
				new 通用次数类
				{
					数值 = 7,
					次数 = 40
				},
				new 通用次数类
				{
					数值 = 8,
					次数 = 80
				},
				new 通用次数类
				{
					数值 = 9,
					次数 = 160
				},
				new 通用次数类
				{
					数值 = 10,
					次数 = 200
				}
			},
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.气血,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.法力,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.准确,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.物理伤害,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.法术伤害,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.防御,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.体质,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.力量,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.灵力,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.敏捷,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.速度,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.金抗性,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.木抗性,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.水抗性,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.火抗性,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.土抗性,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗中毒,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗冰冻,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗昏睡,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗遗忘,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗混乱,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗所有异常,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.连击,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.连击率,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.反击率,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.反震度,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.反震率,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.躲闪率,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.反击,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.物理必杀率,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.所有抗性,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.所有属性,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.所有技能上升,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗金,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗木,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗水,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗火,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗土,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗遗忘,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗中毒,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗冰冻,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗昏睡,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗混乱,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力克金,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力克木,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力克水,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力克火,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力克土,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强金法伤害,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强木法伤害,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强水法伤害,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强火法伤害,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强土法伤害,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强物理伤害,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.躲避攻击,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.师门攻击技能消耗降低,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.师门障碍技能消耗降低,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.师门辅助技能消耗降低,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力中毒,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力昏睡,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力冰冻,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力遗忘,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力混乱,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.金系法攻,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.木系法攻,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.水系法攻,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.火系法攻,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.土系法攻,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗物理,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视所有抗性,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视所有抗异常,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.解除遗忘状态,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.解除中毒状态,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.解除冰冻状态,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.解除昏睡状态,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.解除混乱状态,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标连击,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标物理必杀,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力障碍宠物,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视躲避攻击,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.法术必杀率,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标法术必杀,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗神圣之光,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗游说之舌,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗舍命一击,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗翻转乾坤,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗漫天血舞,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.闪避,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗镇魂,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗化功,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗水牢,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗锁灵,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.抗迷心,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗镇魂,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗化功,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗水牢,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗锁灵,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.忽视目标抗迷心,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.解除镇魂状态,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.解除化功状态,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.解除水牢状态,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.解除锁灵状态,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.解除迷心状态,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力镇魂,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力化功,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力水牢,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力锁灵,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.强力迷心,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.破防率,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.破防,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.改造所有属性,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.改造伤害,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.改造气血,
			浮动率 = 50
		});
		Singleton<全局变量类>.I.装备强化配置.属性列表.Add(new 精炼属性数值类
		{
			属性名字 = AllEnums.属性名字Type.改造防御,
			浮动率 = 50
		});
		File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("装备强化配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.装备强化配置, Formatting.Indented));
	}

	
	internal void XrsgeafuGi()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("装备强化配置类.json")))
			{
				Singleton<全局变量类>.I.装备强化配置 = JsonConvert.DeserializeObject<装备强化配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("装备强化配置类.json")));
			}
			else
			{
				knVg4QW5qI();
			}
		}
		catch (Exception ex)
		{
			Log.Error("装备强化配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void yvlgq4Lxya()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("装备强化配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.装备强化配置, Formatting.Indented));
			Log.Debug("装备强化配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("装备强化配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string tdmgrdkXXP()
	{
		XrsgeafuGi();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.装备强化配置, Formatting.Indented);
	}

	
	public void P6lgZ8HlOR(string P_0)
	{
		Singleton<全局变量类>.I.装备强化配置 = JsonConvert.DeserializeObject<装备强化配置类>(P_0);
		yvlgq4Lxya();
	}

	
	internal void RixgtWR3tr(MyNATSocketClient P_0, string P_1, string P_2)
	{
		if (dXBDbesuNI() && Singleton<ByteAPI>.I.寻找文本(P_1, "装备强化_装备精炼"))
		{
			P_1 = P_1.Replace("装备强化_装备精炼", string.Empty);
			WU6DwHEkZX(P_0, P_1).Wait();
		}
	}

	
	internal bool QADgAuyiPE(MyNATSocketClient P_0, byte P_1, byte P_2)
	{
		try
		{
			if (!v1igzjHmfW(P_0, P_1, P_2, out var 精炼属性条件类2))
			{
				return false;
			}
			P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_1].封包缓存, P_1).Concat(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_2].封包缓存, P_2)).ToArray());
			EYyDuFP0vh(P_0, P_1, P_2, 精炼属性条件类2);
			return true;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Is符合装备强化使用-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return false;
		}
	}

	
	private bool v1igzjHmfW(MyNATSocketClient P_0, byte P_1, byte P_2, out 精炼属性条件类 P_3)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals29 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals29.uVa56UgZsu = P_0;
		CS_0024_003C_003E8__locals29.U3p52MeNcY = P_1;
		CS_0024_003C_003E8__locals29.YJb5mp7r9Z = P_2;
		P_3 = null;
		try
		{
			if (!dXBDbesuNI())
			{
				return false;
			}
			if (!Singleton<全局变量类>.I.装备强化配置.条件列表.Any( (精炼属性条件类 x) => x.消耗道具名字 == CS_0024_003C_003E8__locals29.uVa56UgZsu.user.背包数据.物品列表[CS_0024_003C_003E8__locals29.U3p52MeNcY].名字))
			{
				return false;
			}
			if (!Singleton<全局变量类>.I.装备强化配置.可精炼装备类型.Any( (AllEnums.Equip类型 x) => x == (AllEnums.Equip类型)CS_0024_003C_003E8__locals29.uVa56UgZsu.user.背包数据.物品列表[CS_0024_003C_003E8__locals29.YJb5mp7r9Z].物品类型))
			{
				return false;
			}
			if (Singleton<全局变量类>.I.装备强化配置.绑定装备才可精炼 && !CS_0024_003C_003E8__locals29.uVa56UgZsu.user.背包数据.物品列表[CS_0024_003C_003E8__locals29.YJb5mp7r9Z].是否绑定)
			{
				CS_0024_003C_003E8__locals29.uVa56UgZsu.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R绑定的装备才能进行属性精炼。#n"));
				return false;
			}
			if (CS_0024_003C_003E8__locals29.uVa56UgZsu.user.背包数据.物品列表[CS_0024_003C_003E8__locals29.YJb5mp7r9Z].等级 < Singleton<全局变量类>.I.装备强化配置.装备最低精炼等级 || CS_0024_003C_003E8__locals29.uVa56UgZsu.user.背包数据.物品列表[CS_0024_003C_003E8__locals29.YJb5mp7r9Z].等级 > Singleton<全局变量类>.I.装备强化配置.装备最高精炼等级)
			{
				MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals29.uVa56UgZsu;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
				defaultInterpolatedStringHandler.AppendLiteral("装备等级在#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.装备强化配置.装备最低精炼等级);
				defaultInterpolatedStringHandler.AppendLiteral("-");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.装备强化配置.装备最高精炼等级);
				defaultInterpolatedStringHandler.AppendLiteral("#n级区间才可进行属性精炼。");
				myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return false;
			}
			P_3 = Singleton<全局变量类>.I.装备强化配置.条件列表.Find( (精炼属性条件类 x) => x.消耗道具名字 == CS_0024_003C_003E8__locals29.uVa56UgZsu.user.背包数据.物品列表[CS_0024_003C_003E8__locals29.U3p52MeNcY].名字);
			if (P_3 == null)
			{
				return false;
			}
			if (!P_3.功能开关)
			{
				MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals29.uVa56UgZsu;
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
				defaultInterpolatedStringHandler.AppendLiteral("#R装备");
				defaultInterpolatedStringHandler.AppendFormatted(P_3.精炼属性);
				defaultInterpolatedStringHandler.AppendLiteral("精炼活动暂未开启。#n");
				myNATSocketClient2.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return false;
			}
			if (CS_0024_003C_003E8__locals29.uVa56UgZsu.user.背包数据.物品列表[CS_0024_003C_003E8__locals29.YJb5mp7r9Z].改造等级 < P_3.装备最低改造等级)
			{
				MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals29.uVa56UgZsu;
				WdAPI i3 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
				defaultInterpolatedStringHandler.AppendLiteral("#R装备改造等级不足");
				defaultInterpolatedStringHandler.AppendFormatted(P_3.装备最低改造等级);
				defaultInterpolatedStringHandler.AppendLiteral("级，无法进行属性精炼。#n");
				myNATSocketClient3.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return false;
			}
			if (CS_0024_003C_003E8__locals29.uVa56UgZsu.user.背包数据.物品列表[CS_0024_003C_003E8__locals29.U3p52MeNcY].数量 < P_3.消耗道具数量)
			{
				CS_0024_003C_003E8__locals29.uVa56UgZsu.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + CS_0024_003C_003E8__locals29.uVa56UgZsu.user.背包数据.物品列表[CS_0024_003C_003E8__locals29.U3p52MeNcY].名字 + "#n的数量不足以进行属性精炼。"));
				return false;
			}
			if (CS_0024_003C_003E8__locals29.uVa56UgZsu.user.存档数据.数值存档.灵气值 < P_3.消耗灵气数量)
			{
				CS_0024_003C_003E8__locals29.uVa56UgZsu.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前剩余的灵气值不足以进行属性精炼。"));
				return false;
			}
			if (CS_0024_003C_003E8__locals29.uVa56UgZsu.user.缓存数据.is使用仙灵卡)
			{
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("检测鉴定条件成立-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return false;
		}
	}

	
	private void EYyDuFP0vh(MyNATSocketClient P_0, byte P_1, byte P_2, 精炼属性条件类 P_3)
	{
		try
		{
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(79, 4);
			defaultInterpolatedStringHandler.AppendLiteral("[@确定/装备强化_装备精炼");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要对#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n的#R");
			defaultInterpolatedStringHandler.AppendFormatted(P_3.精炼属性);
			defaultInterpolatedStringHandler.AppendLiteral("#n进行精炼操作吗？#R（点击确定会自动一直精炼直到成功或者材料不足）#n]");
			P_0.C_Send(i.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("装备精炼确定弹窗-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private async Task WU6DwHEkZX(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals154 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals154.WhJ5s4S7ED = P_0;
		try
		{
			if (string.IsNullOrWhiteSpace(P_1))
			{
				CS_0024_003C_003E8__locals154.WhJ5s4S7ED.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的物品数据有误，原因：1！"));
				return;
			}
			CS_0024_003C_003E8__locals154.Mnp58oSfFI = new StringBuilder();
			string[] array = P_1.Split("|");
			if (array.Length != 2)
			{
				CS_0024_003C_003E8__locals154.WhJ5s4S7ED.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的物品数据有误，原因：2！"));
				return;
			}
			if (!byte.TryParse(array[0], out var result) || !byte.TryParse(array[1], out CS_0024_003C_003E8__locals154.ELc5IBRXwR))
			{
				CS_0024_003C_003E8__locals154.WhJ5s4S7ED.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的物品数据有误，原因：3！"));
				return;
			}
			if (!Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals154.WhJ5s4S7ED, result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals154.WhJ5s4S7ED, CS_0024_003C_003E8__locals154.ELc5IBRXwR))
			{
				CS_0024_003C_003E8__locals154.WhJ5s4S7ED.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的物品数据有误，原因：4！"));
				return;
			}
			if (CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.背包数据.物品列表[result].物品ID == 0 || CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.背包数据.物品列表[CS_0024_003C_003E8__locals154.ELc5IBRXwR].物品ID == 0)
			{
				CS_0024_003C_003E8__locals154.WhJ5s4S7ED.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的物品数据有误，原因：5！"));
				return;
			}
			if (!v1igzjHmfW(CS_0024_003C_003E8__locals154.WhJ5s4S7ED, result, CS_0024_003C_003E8__locals154.ELc5IBRXwR, out CS_0024_003C_003E8__locals154.p9U5U8U5Ia))
			{
				CS_0024_003C_003E8__locals154.WhJ5s4S7ED.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的物品数据有误，无法精炼！"));
				return;
			}
			CS_0024_003C_003E8__locals154.vWg5W1WNe0 = CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.背包数据.物品列表[CS_0024_003C_003E8__locals154.ELc5IBRXwR].装备属性列表.FindAll( (属性数据 x) => x.属性类别 == (int)CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性);
			if (CS_0024_003C_003E8__locals154.vWg5W1WNe0.Count <= 0)
			{
				MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals154.WhJ5s4S7ED;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你的装备都没有#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性);
				defaultInterpolatedStringHandler.AppendLiteral("#n隔这凑什么热闹。");
				myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			List<精炼属性数值类> list = Singleton<全局变量类>.I.装备强化配置.属性列表.FindAll( (精炼属性数值类 x) =>
			{
				_003C_003Ec__DisplayClass11_1 CS_0024_003C_003E8__locals158 = new _003C_003Ec__DisplayClass11_1();
				CS_0024_003C_003E8__locals158.vq05iyqwoF = CS_0024_003C_003E8__locals154;
				CS_0024_003C_003E8__locals158.qwT5NiUI8Y = x;
				return CS_0024_003C_003E8__locals154.vWg5W1WNe0.Any( (属性数据 属性数据2) => 属性数据2.精炼属性筛选(CS_0024_003C_003E8__locals158.vq05iyqwoF.p9U5U8U5Ia.精炼属性) == (int)CS_0024_003C_003E8__locals158.qwT5NiUI8Y.属性名字 && Math.Abs(属性数据2.属性数值) >= CS_0024_003C_003E8__locals158.qwT5NiUI8Y.最小值 && Math.Abs(属性数据2.属性数值) < CS_0024_003C_003E8__locals158.qwT5NiUI8Y.最大值) && CS_0024_003C_003E8__locals158.qwT5NiUI8Y.Is符合条件(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性);
			});
			if (list.Count <= 0)
			{
				MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals154.WhJ5s4S7ED;
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.背包数据.物品列表[CS_0024_003C_003E8__locals154.ELc5IBRXwR].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n已无可精炼的#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				myNATSocketClient2.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (!CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.存档数据.精炼存档.精炼计数字典.TryGetValue(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性, out var value))
			{
				CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.存档数据.精炼存档.精炼计数字典.Add(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性, 0);
				value = 0;
			}
			CS_0024_003C_003E8__locals154.A7q5gn3E1Z = list[Singleton<WdAPI>.I.qrjo9TWIdy(0, list.Count - 1)];
			CS_0024_003C_003E8__locals154.zYN5DgiSbE = CS_0024_003C_003E8__locals154.vWg5W1WNe0.Find( (属性数据 x) => x.精炼属性选中(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性, CS_0024_003C_003E8__locals154.A7q5gn3E1Z.属性名字));
			if (CS_0024_003C_003E8__locals154.zYN5DgiSbE.属性标识 == 0 || CS_0024_003C_003E8__locals154.zYN5DgiSbE.属性类别 == 0)
			{
				MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals154.WhJ5s4S7ED;
				WdAPI i3 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
				defaultInterpolatedStringHandler.AppendLiteral("当前装备的#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性);
				defaultInterpolatedStringHandler.AppendLiteral("#n已无可精炼的属性！");
				myNATSocketClient3.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			CS_0024_003C_003E8__locals154.fR85lxAH2P = CS_0024_003C_003E8__locals154.A7q5gn3E1Z.数值次数.Find( (通用次数类 x) => x.数值 > Math.Abs(CS_0024_003C_003E8__locals154.zYN5DgiSbE.属性数值));
			if (CS_0024_003C_003E8__locals154.fR85lxAH2P == null)
			{
				Log.Error("选中装备属性=" + JsonConvert.SerializeObject(CS_0024_003C_003E8__locals154.zYN5DgiSbE) + "  ||||  当前条件=" + JsonConvert.SerializeObject(CS_0024_003C_003E8__locals154.p9U5U8U5Ia));
				MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals154.WhJ5s4S7ED;
				WdAPI i4 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
				defaultInterpolatedStringHandler.AppendLiteral("当前装备的#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性);
				defaultInterpolatedStringHandler.AppendLiteral("#n已无可精炼的属性！");
				myNATSocketClient4.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			int num = Singleton<WdAPI>.I.qrjo9TWIdy(CS_0024_003C_003E8__locals154.fR85lxAH2P.次数, (int)((float)CS_0024_003C_003E8__locals154.fR85lxAH2P.次数 * ((float)CS_0024_003C_003E8__locals154.A7q5gn3E1Z.浮动率 / 100f + 1f)));
			CS_0024_003C_003E8__locals154.zVD5jxBir1 = num - value;
			if (CS_0024_003C_003E8__locals154.zVD5jxBir1 == 0)
			{
				MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals154.WhJ5s4S7ED;
				WdAPI i5 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
				defaultInterpolatedStringHandler.AppendLiteral("当前装备的#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性);
				defaultInterpolatedStringHandler.AppendLiteral("#n已无可精炼的属性了！");
				myNATSocketClient5.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (CS_0024_003C_003E8__locals154.zVD5jxBir1 < 0)
			{
				CS_0024_003C_003E8__locals154.zVD5jxBir1 = 1;
			}
			_ = CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗灵气数量;
			_ = CS_0024_003C_003E8__locals154.zVD5jxBir1;
			int num2 = CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.背包数据.物品列表[result].数量 / CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗道具数量;
			int num3 = ((CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗灵气数量 <= 0) ? num2 : (CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.存档数据.数值存档.灵气值 / CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗灵气数量));
			int 要使用次数 = ((num2 > num3) ? num3 : num2);
			if (要使用次数 < CS_0024_003C_003E8__locals154.zVD5jxBir1)
			{
				CS_0024_003C_003E8__locals154.WhJ5s4S7ED.销毁回调事件 = null;
				Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals154.WhJ5s4S7ED, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -要使用次数 * CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗灵气数量, false, "[个人突破-" + CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.人物数据.昵称 + "-精炼消耗]");
				CS_0024_003C_003E8__locals154.WhJ5s4S7ED.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(result, 要使用次数 * CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗道具数量));
				CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.存档数据.精炼存档.精炼计数字典[CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性] += 要使用次数;
				MyNATSocketClient myNATSocketClient6 = CS_0024_003C_003E8__locals154.WhJ5s4S7ED;
				WdAPI i6 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性);
				defaultInterpolatedStringHandler.AppendLiteral("精炼中");
				myNATSocketClient6.C_Send(i6.QewoEwLLTD(defaultInterpolatedStringHandler.ToStringAndClear(), 1));
				await Task.Delay(1000);
				MyNATSocketClient myNATSocketClient7 = CS_0024_003C_003E8__locals154.WhJ5s4S7ED;
				WdAPI i7 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 4);
				defaultInterpolatedStringHandler.AppendLiteral("#R精炼了");
				defaultInterpolatedStringHandler.AppendFormatted(要使用次数);
				defaultInterpolatedStringHandler.AppendLiteral("次失败！#n你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗道具数量 * 要使用次数);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗道具名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				string value2;
				if (CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗灵气数量 > 0)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(14, 1);
					defaultInterpolatedStringHandler2.AppendLiteral("和#R");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗灵气数量 * 要使用次数);
					defaultInterpolatedStringHandler2.AppendLiteral("#n点#R灵气值#n。");
					value2 = defaultInterpolatedStringHandler2.ToStringAndClear();
				}
				else
				{
					value2 = "。";
				}
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				myNATSocketClient7.C_Send(i7.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_中心提醒("#R很遗憾，精炼失败了！但是请不要沮丧，每一次的失败都是为了以后成功，加油！#21")).ToArray());
				return;
			}
			CS_0024_003C_003E8__locals154.WhJ5s4S7ED.销毁回调事件 =  async (string v) =>
			{
				if (!(v != CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗道具名字))
				{
					CS_0024_003C_003E8__locals154.WhJ5s4S7ED.销毁回调事件 = null;
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals154.WhJ5s4S7ED, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -CS_0024_003C_003E8__locals154.zVD5jxBir1 * CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗灵气数量, false, "[个人突破-" + CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.人物数据.昵称 + "-精炼消耗]");
					CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.存档数据.精炼存档.精炼计数字典[CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性] = 0;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3;
					if (CS_0024_003C_003E8__locals154.A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.物理伤害 || CS_0024_003C_003E8__locals154.A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.法术伤害 || CS_0024_003C_003E8__locals154.A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.改造伤害)
					{
						List<string[]> list2 = new List<string[]>();
						string[] array2 = new string[2];
						defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(10, 1);
						defaultInterpolatedStringHandler3.AppendFormatted((AllEnums.属性类别)CS_0024_003C_003E8__locals154.zYN5DgiSbE.属性类别);
						defaultInterpolatedStringHandler3.AppendLiteral("/phy_power");
						array2[0] = defaultInterpolatedStringHandler3.ToStringAndClear();
						array2[1] = $"{CS_0024_003C_003E8__locals154.fR85lxAH2P.数值}";
						list2.Add(array2);
						string[] array3 = new string[2];
						defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(10, 1);
						defaultInterpolatedStringHandler3.AppendFormatted((AllEnums.属性类别)CS_0024_003C_003E8__locals154.zYN5DgiSbE.属性类别);
						defaultInterpolatedStringHandler3.AppendLiteral("/mag_power");
						array3[0] = defaultInterpolatedStringHandler3.ToStringAndClear();
						array3[1] = $"{CS_0024_003C_003E8__locals154.fR85lxAH2P.数值}";
						list2.Add(array3);
						List<string[]> list3 = list2;
						StringBuilder stringBuilder = CS_0024_003C_003E8__locals154.Mnp58oSfFI;
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(35, 5, stringBuilder);
						handler.AppendLiteral("#26天呐，#Y");
						handler.AppendFormatted(CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.人物数据.昵称);
						handler.AppendLiteral("#n的#Y");
						handler.AppendFormatted(CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.背包数据.物品列表[CS_0024_003C_003E8__locals154.ELc5IBRXwR].名字);
						handler.AppendLiteral("#n成功精炼！#G");
						handler.AppendFormatted((CS_0024_003C_003E8__locals154.A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.改造伤害) ? "改造伤害" : "伤害");
						handler.AppendLiteral(" ");
						handler.AppendFormatted(CS_0024_003C_003E8__locals154.zYN5DgiSbE.属性数值);
						handler.AppendLiteral(" #Y→#G");
						handler.AppendFormatted(CS_0024_003C_003E8__locals154.fR85lxAH2P.数值);
						handler.AppendLiteral("#Y↑#G。");
						stringBuilder2.Append(ref handler);
						Singleton<WdAPI>.I.NNfIVUuyWv(CS_0024_003C_003E8__locals154.WhJ5s4S7ED, CS_0024_003C_003E8__locals154.ELc5IBRXwR, list3);
					}
					else if (CS_0024_003C_003E8__locals154.A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.师门攻击技能消耗降低 || CS_0024_003C_003E8__locals154.A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.师门障碍技能消耗降低 || CS_0024_003C_003E8__locals154.A7q5gn3E1Z.属性名字 == AllEnums.属性名字Type.师门辅助技能消耗降低)
					{
						StringBuilder stringBuilder = CS_0024_003C_003E8__locals154.Mnp58oSfFI;
						StringBuilder stringBuilder3 = stringBuilder;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(37, 5, stringBuilder);
						handler.AppendLiteral("#26天呐，#Y");
						handler.AppendFormatted(CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.人物数据.昵称);
						handler.AppendLiteral("#n的#Y");
						handler.AppendFormatted(CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.背包数据.物品列表[CS_0024_003C_003E8__locals154.ELc5IBRXwR].名字);
						handler.AppendLiteral("#n成功精炼！#G");
						handler.AppendFormatted(CS_0024_003C_003E8__locals154.A7q5gn3E1Z.属性名字);
						handler.AppendLiteral(" ");
						handler.AppendFormatted(Math.Abs(CS_0024_003C_003E8__locals154.zYN5DgiSbE.属性数值));
						handler.AppendLiteral("% #Y→#G");
						handler.AppendFormatted(CS_0024_003C_003E8__locals154.fR85lxAH2P.数值);
						handler.AppendLiteral("%#Y↑#G。");
						stringBuilder3.Append(ref handler);
						WdAPI i8 = Singleton<WdAPI>.I;
						MyNATSocketClient myNATSocketClient8 = CS_0024_003C_003E8__locals154.WhJ5s4S7ED;
						byte num4 = CS_0024_003C_003E8__locals154.ELc5IBRXwR;
						defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(1, 2);
						defaultInterpolatedStringHandler3.AppendFormatted((AllEnums.属性类别)CS_0024_003C_003E8__locals154.zYN5DgiSbE.属性类别);
						defaultInterpolatedStringHandler3.AppendLiteral("/");
						defaultInterpolatedStringHandler3.AppendFormatted((AllEnums.属性标识Type)CS_0024_003C_003E8__locals154.zYN5DgiSbE.属性标识);
						string text = defaultInterpolatedStringHandler3.ToStringAndClear();
						defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(1, 1);
						defaultInterpolatedStringHandler3.AppendLiteral("-");
						defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals154.fR85lxAH2P.数值);
						i8.Mr8ICwW3qX(myNATSocketClient8, num4, text, defaultInterpolatedStringHandler3.ToStringAndClear());
					}
					else
					{
						StringBuilder stringBuilder = CS_0024_003C_003E8__locals154.Mnp58oSfFI;
						StringBuilder stringBuilder4 = stringBuilder;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(35, 5, stringBuilder);
						handler.AppendLiteral("#26天呐，#Y");
						handler.AppendFormatted(CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.人物数据.昵称);
						handler.AppendLiteral("#n的#Y");
						handler.AppendFormatted(CS_0024_003C_003E8__locals154.WhJ5s4S7ED.user.背包数据.物品列表[CS_0024_003C_003E8__locals154.ELc5IBRXwR].名字);
						handler.AppendLiteral("#n成功精炼！#G");
						handler.AppendFormatted((AllEnums.属性名字Type)CS_0024_003C_003E8__locals154.zYN5DgiSbE.属性标识);
						handler.AppendLiteral(" ");
						handler.AppendFormatted(CS_0024_003C_003E8__locals154.zYN5DgiSbE.属性数值);
						handler.AppendLiteral(" #Y→#G");
						handler.AppendFormatted(CS_0024_003C_003E8__locals154.fR85lxAH2P.数值);
						handler.AppendLiteral("#Y↑#G。");
						stringBuilder4.Append(ref handler);
						WdAPI i9 = Singleton<WdAPI>.I;
						MyNATSocketClient myNATSocketClient9 = CS_0024_003C_003E8__locals154.WhJ5s4S7ED;
						byte num5 = CS_0024_003C_003E8__locals154.ELc5IBRXwR;
						defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(1, 2);
						defaultInterpolatedStringHandler3.AppendFormatted((AllEnums.属性类别)CS_0024_003C_003E8__locals154.zYN5DgiSbE.属性类别);
						defaultInterpolatedStringHandler3.AppendLiteral("/");
						defaultInterpolatedStringHandler3.AppendFormatted((AllEnums.属性标识Type)CS_0024_003C_003E8__locals154.zYN5DgiSbE.属性标识);
						i9.Mr8ICwW3qX(myNATSocketClient9, num5, defaultInterpolatedStringHandler3.ToStringAndClear(), CS_0024_003C_003E8__locals154.fR85lxAH2P.数值.ToString());
					}
					MyNATSocketClient myNATSocketClient10 = CS_0024_003C_003E8__locals154.WhJ5s4S7ED;
					WdAPI i10 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(3, 1);
					defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.精炼属性);
					defaultInterpolatedStringHandler3.AppendLiteral("精炼中");
					myNATSocketClient10.C_Send(i10.QewoEwLLTD(defaultInterpolatedStringHandler3.ToStringAndClear(), 1));
					await Task.Delay(1000);
					MyNATSocketClient myNATSocketClient11 = CS_0024_003C_003E8__locals154.WhJ5s4S7ED;
					WdAPI i11 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler3 = new DefaultInterpolatedStringHandler(22, 3);
					defaultInterpolatedStringHandler3.AppendLiteral("#Y精炼成功！#n你消耗了#R");
					defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗道具数量 * CS_0024_003C_003E8__locals154.zVD5jxBir1);
					defaultInterpolatedStringHandler3.AppendLiteral("#n个#R");
					defaultInterpolatedStringHandler3.AppendFormatted(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗道具名字);
					defaultInterpolatedStringHandler3.AppendLiteral("#n");
					string value3;
					if (CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗灵气数量 > 0)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = new DefaultInterpolatedStringHandler(14, 1);
						defaultInterpolatedStringHandler4.AppendLiteral("和#R");
						defaultInterpolatedStringHandler4.AppendFormatted(CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗灵气数量 * CS_0024_003C_003E8__locals154.zVD5jxBir1);
						defaultInterpolatedStringHandler4.AppendLiteral("#n点#R灵气值#n。");
						value3 = defaultInterpolatedStringHandler4.ToStringAndClear();
					}
					else
					{
						value3 = "。";
					}
					defaultInterpolatedStringHandler3.AppendFormatted(value3);
					myNATSocketClient11.C_Send(i11.提示_杂项公告(defaultInterpolatedStringHandler3.ToStringAndClear()).Concat(Singleton<WdAPI>.I.提示_中心提醒("#G精炼成功！")).ToArray());
					if (Singleton<全局变量类>.I.装备强化配置.谣言开关)
					{
						Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(CS_0024_003C_003E8__locals154.Mnp58oSfFI.ToString(), "管理员"));
					}
				}
			};
			CS_0024_003C_003E8__locals154.WhJ5s4S7ED.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(result, CS_0024_003C_003E8__locals154.zVD5jxBir1 * CS_0024_003C_003E8__locals154.p9U5U8U5Ia.消耗道具数量));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("装备精炼确定处理 - 报错:");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public rZ9xAdgxKYQQZPeE8Rm()
	{
	}

	static rZ9xAdgxKYQQZPeE8Rm()
	{
	}
}
