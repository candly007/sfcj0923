using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using CrwA1FwcYB2ZUOWYe7I;
using Serilog;
using dgvsPcDEiqYFlrnMMor;
using s4E8DnU2AI3UWfigLPZ;
using xqlPMM2TJRNXpZnNDFn;

namespace qP09WjBc7nUNQOcDDy3;

internal class L1ya6XBSPGoekkP8WeX : Singleton<L1ya6XBSPGoekkP8WeX>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public int m0waI1m47W;

		
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		
		internal bool e0EaleLuHE(宠物缓存数据类 x)
		{
			return x.宠物ID == m0waI1m47W;
		}

		
		internal bool tlKa8QU1aG(娃娃缓存数据类 x)
		{
			return x.娃娃ID == m0waI1m47W;
		}

		static _003C_003Ec__DisplayClass2_0()
		{
		}
	}

	
	internal byte[] baYBnXhLY9(MyNATSocketClient P_0, byte[] P_1)
	{
		封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
		封包_写 封包_写2 = new 封包_写();
		封包_写 封包_写3 = new 封包_写();
		封包_读2.Seek(10L, SeekOrigin.Begin);
		封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
		int num = 封包_读2.读整数型(reverse: true);
		封包_写2.写整数型(num, reverse: true);
		short num2 = 封包_读2.读短整数型(reverse: true);
		if (P_0.user.人物数据.角色ID != num)
		{
			return P_1;
		}
		P_0.user.缓存数据.is会员卡 = false;
		bool is战斗中 = false;
		bool is观战中 = false;
		bool is使用仙灵卡 = false;
		for (int i = 0; i < num2; i++)
		{
			string text = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			封包_写3.写文本型(text, hasCount: true, 0, reverse: true);
			if (text == "位列仙班")
			{
				P_0.user.缓存数据.is会员卡 = true;
			}
			else if (text == "正在战斗中")
			{
				is战斗中 = true;
			}
			else if (text == "正在使用仙灵卡")
			{
				is使用仙灵卡 = true;
			}
			else if (text == "正在观战中")
			{
				is观战中 = true;
			}
		}
		P_0.user.缓存数据.is战斗中 = is战斗中;
		P_0.user.缓存数据.is观战中 = is观战中;
		if (P_0.user.缓存数据.is战斗中)
		{
			P_0.user.缓存数据.is观战中 = false;
		}
		else if (P_0.user.缓存数据.is观战中)
		{
			P_0.user.缓存数据.is战斗中 = false;
		}
		P_0.user.缓存数据.is使用仙灵卡 = is使用仙灵卡;
		封包_写2.写短整数型(num2, reverse: true);
		封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] hcdB5D6A9G(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var value), reverse: true);
			if (P_0.user.人物数据.角色ID == 0)
			{
				P_0.user.人物数据.角色ID = value;
			}
			else if (P_0.user.人物数据.角色ID != value)
			{
				return P_1;
			}
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value2), reverse: true);
			int num = 0;
			short num2 = 0;
			int num3 = 0;
			string empty = string.Empty;
			byte[] value3 = Array.Empty<byte>();
			int value4 = 0;
			int 等级 = P_0.user.属性数据.等级;
			for (int i = 0; i < value2; i++)
			{
				num = 0;
				num2 = 0;
				num3 = 0;
				empty = string.Empty;
				封包_写2.写字节集(封包_读2.读字节集(2, out value3), hasCount: false, 0);
				封包_写2.写字节型(封包_读2.读字节型(out value4));
				switch (value4)
				{
				case 1:
					num = 封包_读2.读字节型();
					if (Enumerable.SequenceEqual(value3, 全局常量类.性别头))
					{
						P_0.user.人物数据.性别 = num;
					}
					if (Enumerable.SequenceEqual(value3, 全局常量类.经验锁头))
					{
						P_0.user.人物数据.经验锁状态 = num;
					}
					封包_写2.写字节型(num);
					break;
				case 2:
					num2 = 封包_读2.读短整数型(reverse: true);
					if (Enumerable.SequenceEqual(value3, 全局常量类.等级头))
					{
						P_0.user.属性数据.等级 = num2;
						P_0.user.存档数据.排行数据_等级 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.修为值头))
					{
						P_0.user.属性数据.修为值 = num2 * 2700;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.金相性值头))
					{
						P_0.user.属性数据.金相性值 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.木相性值头))
					{
						P_0.user.属性数据.木相性值 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.水相性值头))
					{
						P_0.user.属性数据.水相性值 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.火相性值头))
					{
						P_0.user.属性数据.火相性值 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.土相性值头))
					{
						P_0.user.属性数据.土相性值 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.剩余属性头))
					{
						P_0.user.属性数据.剩余属性 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.剩余相性头))
					{
						P_0.user.属性数据.剩余相性 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.当前速度头))
					{
						P_0.user.属性数据.当前速度 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.物理吸收头))
					{
						P_0.user.属性数据.物理吸收 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.法术吸收头))
					{
						P_0.user.属性数据.法术吸收 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.攻击效果头))
					{
						P_0.user.属性数据.攻击效果 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.当前力量头))
					{
						P_0.user.属性数据.当前力量 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.当前敏捷头))
					{
						P_0.user.属性数据.当前敏捷 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.当前灵力头))
					{
						P_0.user.属性数据.当前灵力 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.当前体质头))
					{
						P_0.user.属性数据.当前体质 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.相性丹药头))
					{
						P_0.user.属性数据.相性丹药 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.当前体力头))
					{
						P_0.user.属性数据.当前体力 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.最大体力头))
					{
						P_0.user.属性数据.最大体力 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.闪避头))
					{
						P_0.user.属性数据.闪避 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.破防头))
					{
						P_0.user.属性数据.破防 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.准确头))
					{
						P_0.user.属性数据.准确 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.金抗性头))
					{
						P_0.user.属性数据.金抗性 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.木抗性头))
					{
						P_0.user.属性数据.木抗性 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.水抗性头))
					{
						P_0.user.属性数据.水抗性 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.火抗性头))
					{
						P_0.user.属性数据.火抗性 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.土抗性头))
					{
						P_0.user.属性数据.土抗性 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.五行头))
					{
						P_0.user.人物数据.五行 = num2;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.强物理头))
					{
						P_0.user.属性数据.强物理 = num2;
					}
					封包_写2.写短整数型(num2, reverse: true);
					break;
				case 3:
					num3 = 封包_读2.读整数型(reverse: true);
					if (Enumerable.SequenceEqual(value3, 全局常量类.金钱头))
					{
						P_0.user.背包数据.金钱 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.代金券头))
					{
						P_0.user.背包数据.代金券 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.银元宝头))
					{
						P_0.user.背包数据.银元宝 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.金元宝头))
					{
						P_0.user.背包数据.金元宝 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.潜能头))
					{
						P_0.user.属性数据.潜能 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.道行头))
					{
						P_0.user.属性数据.道行 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.本月道行头))
					{
						P_0.user.存档数据.本月道行 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.形象ID头))
					{
						P_0.user.人物数据.形象ID = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.经验头))
					{
						P_0.user.属性数据.经验 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.经验上限头))
					{
						P_0.user.属性数据.经验上限 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.声望头))
					{
						P_0.user.属性数据.声望 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.战绩头))
					{
						P_0.user.属性数据.战绩 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.当前物攻头))
					{
						P_0.user.属性数据.当前物攻 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.当前法攻头))
					{
						P_0.user.属性数据.当前法攻 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.当前防御头))
					{
						P_0.user.属性数据.当前防御 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.当前气血头))
					{
						P_0.user.属性数据.当前气血 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.最大气血头))
					{
						P_0.user.属性数据.最大气血 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.当前法力头))
					{
						P_0.user.属性数据.当前法力 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.最大法力头))
					{
						P_0.user.属性数据.最大法力 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.携带金钱上限头))
					{
						num3 = int.MaxValue;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.存款金钱上限头))
					{
						num3 = int.MaxValue;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.仙道点头))
					{
						P_0.user.属性数据.仙道点 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.魔道点头))
					{
						P_0.user.属性数据.魔道点 = num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.修道点头))
					{
						P_0.user.属性数据.修道点 = num3;
						if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND())
						{
							num3 = P_0.user.存档数据.数值存档.灵气值;
						}
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.反震度头))
					{
						P_0.user.属性数据.反震度 = (short)num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.反震率头))
					{
						P_0.user.属性数据.反震率 = (short)num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.必杀率头))
					{
						P_0.user.属性数据.必杀率 = (short)num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.连击率头))
					{
						P_0.user.属性数据.连击率 = (short)num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.连击数头))
					{
						P_0.user.属性数据.连击数 = (short)num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.反击率头))
					{
						P_0.user.属性数据.反击率 = (short)num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.反击数头))
					{
						P_0.user.属性数据.反击数 = (short)num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.好心值头))
					{
						P_0.user.属性数据.好心值 = (short)num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.精力头))
					{
						P_0.user.属性数据.精力 = (short)num3;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.最大精力头))
					{
						P_0.user.属性数据.最大精力 = (short)num3;
					}
					封包_写2.写整数型(num3, reverse: true);
					break;
				case 4:
					empty = 封包_读2.读文本型(是否声明长度: true, 0);
					if (Enumerable.SequenceEqual(value3, 全局常量类.昵称头))
					{
						P_0.user.人物数据.昵称 = empty;
						P_0.user.存档数据.昵称 = empty;
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.称谓头))
					{
						P_0.user.人物数据.称谓 = empty;
						if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && P_0.user.人物数据.称谓 != $"{P_0.user.存档数据.元神存档.当前境界}")
						{
							empty = $"{P_0.user.存档数据.元神存档.当前境界}";
						}
					}
					else if (Enumerable.SequenceEqual(value3, 全局常量类.门派头))
					{
						P_0.user.人物数据.门派 = empty;
						P_0.user.存档数据.排行数据_门派 = empty;
					}
					封包_写2.写文本型(empty, hasCount: true, 0);
					break;
				}
			}
			if (P_0.user.存档数据.等级 != P_0.user.属性数据.等级)
			{
				if (Singleton<全局变量类>.I.升级奖励配置.功能开关 && P_0.user.人物数据.形象ID != 7008 && P_0.user.人物数据.形象ID != 7009 && P_0.user.存档数据.等级 < P_0.user.属性数据.等级)
				{
					Singleton<VYkVdJwSrcOTHUW8BPK>.I.Y1GwhVTIty(P_0, P_0.user.属性数据.等级);
				}
				P_0.user.存档数据.等级 = P_0.user.属性数据.等级;
			}
			if (P_0.当前权限 != 300)
			{
				if (!P_0.user.缓存数据.Is等级调整)
				{
					if (等级 != 0 && 等级 != P_0.user.属性数据.等级 && Math.Abs(P_0.user.属性数据.等级 - 等级) > 3)
					{
						DB.I.锁定账号操作(P_0.user.人物数据.账号, "1");
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 4);
						defaultInterpolatedStringHandler.AppendLiteral("刷等级封号[账号：");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
						defaultInterpolatedStringHandler.AppendLiteral("] [名字：");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("] [等级：");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.属性数据.等级);
						defaultInterpolatedStringHandler.AppendLiteral("/");
						defaultInterpolatedStringHandler.AppendFormatted(等级);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
						Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
						return null;
					}
				}
				else
				{
					P_0.user.缓存数据.Is等级调整 = false;
				}
				if (Singleton<全局变量类>.I.等级道行检测.is检测等级)
				{
					if (P_0.user.属性数据.等级 < Singleton<全局变量类>.I.等级道行检测.最低等级)
					{
						Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.exp, 0, true, "[检测等级]重置");
						WdAPI i2 = Singleton<WdAPI>.I;
						string empty2 = string.Empty;
						int 最低等级 = Singleton<全局变量类>.I.等级道行检测.最低等级;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
						defaultInterpolatedStringHandler.AppendLiteral("[检测等级]重置最低");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.属性数据.等级);
						defaultInterpolatedStringHandler.AppendLiteral("/");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.等级道行检测.最低等级);
						i2.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, empty2, AllEnums.指令Type.level, 最低等级, true, defaultInterpolatedStringHandler.ToStringAndClear());
					}
					else if (P_0.user.属性数据.等级 >= Singleton<全局变量类>.I.等级道行检测.最高等级)
					{
						if (P_0.user.属性数据.经验 > 0)
						{
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.exp, 0, true, "[检测等级]重置");
						}
						if (P_0.user.属性数据.等级 > Singleton<全局变量类>.I.等级道行检测.最高等级)
						{
							WdAPI i3 = Singleton<WdAPI>.I;
							string empty3 = string.Empty;
							int 最高等级 = Singleton<全局变量类>.I.等级道行检测.最高等级;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
							defaultInterpolatedStringHandler.AppendLiteral("[检测等级]重置最高");
							defaultInterpolatedStringHandler.AppendFormatted(P_0.user.属性数据.等级);
							defaultInterpolatedStringHandler.AppendLiteral("/");
							defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.等级道行检测.最高等级);
							i3.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, empty3, AllEnums.指令Type.level, 最高等级, true, defaultInterpolatedStringHandler.ToStringAndClear());
						}
					}
				}
				if (Singleton<全局变量类>.I.等级道行检测.is检测道行)
				{
					if (P_0.user.属性数据.道行 < Singleton<全局变量类>.I.等级道行检测.最低道行 * 360)
					{
						Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, Singleton<全局变量类>.I.等级道行检测.最低道行 * 360, true, "[检测道行]重置");
					}
					else if (P_0.user.属性数据.道行 > Singleton<全局变量类>.I.等级道行检测.最高道行 * 360)
					{
						Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, Singleton<全局变量类>.I.等级道行检测.最高道行 * 360, true, "[检测道行]重置");
					}
				}
				int num4 = ((P_0.user.属性数据.等级 > 130) ? ((P_0.user.属性数据.等级 - 130) * 3 + 15) : 0);
				int num5 = P_0.user.属性数据.修道点 + P_0.user.属性数据.仙道点 + P_0.user.属性数据.魔道点;
				if (num4 == 0 && num5 != 0)
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), "upgrade_immortal", "0", "admin_set_attrib");
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), "upgrade_magic", "0", "admin_set_attrib");
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), "upgrade/total", "0", "admin_set_attrib");
				}
				else if (num5 > 0 && num5 > num4)
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), "upgrade_immortal", $"{P_0.user.属性数据.等级 - 130}", "admin_set_attrib");
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), "upgrade_magic", $"{P_0.user.属性数据.等级 - 130}", "admin_set_attrib");
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), "upgrade/total", $"{P_0.user.属性数据.等级 - 130}", "admin_set_attrib");
				}
			}
			if (P_0.user.背包数据.银元宝 > 2000000000 || P_0.user.背包数据.银元宝 < 0 || P_0.user.背包数据.金元宝 > 2000000000 || P_0.user.背包数据.金元宝 < 0)
			{
				DB.I.cAJNoOkab6(P_0, 0, 0);
			}
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && P_0.user.人物数据.称谓 != $"{P_0.user.存档数据.元神存档.当前境界}")
			{
				Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), "title", $"{P_0.user.存档数据.元神存档.当前境界}", "admin_set_attrib");
			}
			if (Singleton<ByteAPI>.I.寻找文本("|妖皇小弟|北冥幼狮|玄天刺猬|魔猪幼仔|小猪猡|财神|福星|战神|海盗|僵尸王|恶鬼|凶魂|地星|天星|上古妖王|海盗|吞天|噬地|傀儡王|羊头怪|牛头怪|牛魔王|夜叉王|罗刹王|百年猪妖|百年象精|百年狂狮怪|百年黑熊精|百年刺猬精|百花羞|白骨精|孔雀妖姬|阎摩罗王|金角大仙|黑熊妖皇|天煞狂狮|灭天血刺|血炼魔猪|天魁星|天魔星|天机星|天闲星|天勇星|天雄星|天猛星|天威星|天英星|天贵星|天富星|天满星|天孤星|天伤星|天立星|天捷星|天暗星|天祐星|天空星|天速星|天异星|天杀星|天微星|天究星|天退星|天寿星|天剑星|天平星|天罪星|天损星|天败星|天牢星|天慧星|天暴星|天哭星|天巧星|地魁星|地煞星|地勇星|地杰星|地雄星|地威星|地英星|地奇星|地猛星|地文星|地正星|地辟星|地阖星|地强星|地暗星|地轴星|地会星|地佐星|地佑星|地灵星|地兽星|地微星|地慧星|地暴星|地默星|地猖星|地狂星|地飞星|地走星|地巧星|地明星|地进星|地退星|地满星|地遂星|地周星|地隐星|地异星|地理星|地俊星|地乐星|地捷星|地速星|地镇星|地稽星|地魔星|地妖星|地幽星|地伏星|地僻星|地空星|地孤星|地全星|地短星|地角星|地囚星|地藏星|地平星|地损星|地奴星|地察星|地恶星|地丑星|地数星|地阴星|地刑星|地壮星|地劣星|地健星|地耗星|地贼星|地狗星|反叛的天魁星|反叛的天魔星|反叛的天机星|反叛的天闲星|反叛的天勇星|反叛的天雄星|反叛的天猛星|反叛的天威星|反叛的天英星|反叛的天贵星|反叛的天富星|反叛的天满星|反叛的天孤星|反叛的天伤星|反叛的天立星|反叛的天捷星|反叛的天暗星|反叛的天祐星|反叛的天空星|反叛的天速星|反叛的天异星|反叛的天杀星|反叛的天微星|反叛的天究星|反叛的天退星|反叛的天寿星|反叛的天剑星|反叛的天平星|反叛的天罪星|反叛的天损星|反叛的天败星|反叛的天牢星|反叛的天慧星|反叛的天暴星|反叛的天哭星|反叛的天巧星|反叛的地魁星|反叛的地煞星|反叛的地勇星|反叛的地杰星|反叛的地雄星|反叛的地威星|反叛的地英星|反叛的地奇星|反叛的地猛星|反叛的地文星|反叛的地正星|反叛的地辟星|反叛的地阖星|反叛的地强星|反叛的地暗星|反叛的地轴星|反叛的地会星|反叛的地佐星|反叛的地佑星|反叛的地灵星|反叛的地兽星|反叛的地微星|反叛的地慧星|反叛的地暴星|反叛的地默星|反叛的地猖星|反叛的地狂星|反叛的地飞星|反叛的地走星|反叛的地巧星|反叛的地明星|反叛的地进星|反叛的地退星|反叛的地满星|反叛的地遂星|反叛的地周星|反叛的地隐星|反叛的地异星|反叛的地理星|反叛的地俊星|反叛的地乐星|反叛的地捷星|反叛的地速星|反叛的地镇星|反叛的地稽星|反叛的地魔星|反叛的地妖星|反叛的地幽星|反叛的地伏星|反叛的地僻星|反叛的地空星|反叛的地孤星|反叛的地全星|反叛的地短星|反叛的地角星|反叛的地囚星|反叛的地藏星|反叛的地平星|反叛的地损星|反叛的地奴星|反叛的地察星|反叛的地恶星|反叛的地丑星|反叛的地数星|反叛的地阴星|反叛的地刑星|反叛的地壮星|反叛的地劣星|反叛的地健星|反叛的地耗星|反叛的地贼星|反叛的地狗星|入侵的黑熊妖皇|入侵的天煞狂狮|入侵的灭天血刺|入侵的血炼魔猪|五龙窟一层的上古妖王|五龙窟二层的上古妖王|五龙窟三层的上古妖王|五龙窟四层的上古妖王|五龙窟五层的上古妖王|五龙山的上古妖王|乾元山的上古妖王|终南山的上古妖王|凤凰山的上古妖王|骷髅山的上古妖王|十里坡的上古妖王|幽冥涧的上古妖王|蓬莱岛的上古妖王|百花谷一的上古妖王|百花谷二的上古妖王|百花谷三的上古妖王|百花谷四的上古妖王|百花谷五的上古妖王|百花谷六的上古妖王|百花谷七的上古妖王|绝人阵的上古妖王|东昆仑的上古妖王|绝仙阵的上古妖王|地绝阵的上古妖王|天绝阵的上古妖王|海底迷宫的上古妖王|昆仑云海的上古妖王|雪域冰原的上古妖王|迷境花树的上古妖王|水云间的上古妖王|热砂荒漠的上古妖王|方丈岛的上古妖王|断魂窟的上古妖王|弑神殿的上古妖王|灭魔堂的上古妖王|太极圣境的上古妖王|玉清山巅的上古妖王|", "|" + P_0.user.人物数据.昵称 + "|") || Singleton<ByteAPI>.I.寻找文本(Singleton<全局变量类>.I.config.扩展BOSS名字, "|" + P_0.user.人物数据.昵称 + "|"))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("角色昵称不合规，系统将自动修改昵称！"));
				WdAPI i4 = Singleton<WdAPI>.I;
				string 昵称 = P_0.user.人物数据.昵称;
				string text = P_0.user.人物数据.角色ID.ToString();
				string text2 = "name";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("道友ID：");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.角色ID);
				i4.lvuI30yCQE(P_0, 昵称, text, text2, defaultInterpolatedStringHandler.ToStringAndClear(), "admin_set_attrib");
			}
			封包_写2.写入数据(封包_读2.剩余数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("接收_人物面板刷新-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal void TUPBMyTp98(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass2_0();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(12L, SeekOrigin.Begin);
			封包_读2.读整数型(reverse: true, out CS_0024_003C_003E8__locals4.m0waI1m47W);
			属性缓存数据类 属性缓存数据类2 = default(属性缓存数据类);
			bool flag = false;
			if (!P_0.user.宠物数据.Any( (宠物缓存数据类 x) => x.宠物ID == CS_0024_003C_003E8__locals4.m0waI1m47W) && !P_0.user.娃娃数据.Any( (娃娃缓存数据类 x) => x.娃娃ID == CS_0024_003C_003E8__locals4.m0waI1m47W) && P_0.user.人物数据.角色ID == CS_0024_003C_003E8__locals4.m0waI1m47W)
			{
				属性缓存数据类2 = P_0.user.附加数据;
				flag = true;
			}
			if (!flag)
			{
				return;
			}
			short value = 0;
			int value2 = 0;
			int num = 0;
			封包_读2.读短整数型(reverse: true, out var value3);
			for (int num2 = 0; num2 < value3; num2++)
			{
				num = 0;
				封包_读2.读短整数型(reverse: true, out value);
				封包_读2.读字节型(out value2);
				switch (value2)
				{
				case 1:
					num = 封包_读2.读字节型();
					break;
				case 2:
					num = 封包_读2.读短整数型(reverse: true);
					break;
				case 3:
					num = 封包_读2.读整数型(reverse: true);
					break;
				}
				switch ((AllEnums.属性名字Type)value)
				{
				case AllEnums.属性名字Type.物理伤害:
					属性缓存数据类2.物理伤害 = num;
					break;
				case AllEnums.属性名字Type.准确:
					属性缓存数据类2.准确 = num;
					break;
				case AllEnums.属性名字Type.气血:
					属性缓存数据类2.最大气血 = num;
					break;
				case AllEnums.属性名字Type.防御:
					属性缓存数据类2.防御 = num;
					break;
				case AllEnums.属性名字Type.法术伤害:
					属性缓存数据类2.法术伤害 = num;
					break;
				case AllEnums.属性名字Type.法力:
					属性缓存数据类2.最大法力 = num;
					break;
				case AllEnums.属性名字Type.速度:
					属性缓存数据类2.速度 = num;
					break;
				case AllEnums.属性名字Type.躲闪率:
					属性缓存数据类2.躲闪率 = num;
					break;
				case AllEnums.属性名字Type.金抗性:
					属性缓存数据类2.金抗性 = num;
					break;
				case AllEnums.属性名字Type.木抗性:
					属性缓存数据类2.木抗性 = num;
					break;
				case AllEnums.属性名字Type.水抗性:
					属性缓存数据类2.水抗性 = num;
					break;
				case AllEnums.属性名字Type.火抗性:
					属性缓存数据类2.火抗性 = num;
					break;
				case AllEnums.属性名字Type.土抗性:
					属性缓存数据类2.土抗性 = num;
					break;
				case AllEnums.属性名字Type.抗中毒:
					属性缓存数据类2.抗中毒 = num;
					break;
				case AllEnums.属性名字Type.抗冰冻:
					属性缓存数据类2.抗冰冻 = num;
					break;
				case AllEnums.属性名字Type.抗昏睡:
					属性缓存数据类2.抗昏睡 = num;
					break;
				case AllEnums.属性名字Type.抗遗忘:
					属性缓存数据类2.抗遗忘 = num;
					break;
				case AllEnums.属性名字Type.抗混乱:
					属性缓存数据类2.抗混乱 = num;
					break;
				case AllEnums.属性名字Type.连击:
					属性缓存数据类2.连击 = num;
					break;
				case AllEnums.属性名字Type.反击:
					属性缓存数据类2.反击 = num;
					break;
				case AllEnums.属性名字Type.反击率:
					属性缓存数据类2.反击率 = num;
					break;
				case AllEnums.属性名字Type.连击率:
					属性缓存数据类2.连击率 = num;
					break;
				case AllEnums.属性名字Type.物理必杀率:
					属性缓存数据类2.物理必杀率 = num;
					break;
				case AllEnums.属性名字Type.反震度:
					属性缓存数据类2.反震度 = num;
					break;
				case AllEnums.属性名字Type.反震率:
					属性缓存数据类2.反震率 = num;
					break;
				case AllEnums.属性名字Type.破防:
					属性缓存数据类2.破防 = num;
					break;
				case AllEnums.属性名字Type.破防率:
					属性缓存数据类2.破防率 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗金:
					属性缓存数据类2.忽视目标抗金 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗木:
					属性缓存数据类2.忽视目标抗木 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗水:
					属性缓存数据类2.忽视目标抗水 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗火:
					属性缓存数据类2.忽视目标抗火 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗土:
					属性缓存数据类2.忽视目标抗土 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗遗忘:
					属性缓存数据类2.忽视目标抗遗忘 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗中毒:
					属性缓存数据类2.忽视目标抗中毒 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗冰冻:
					属性缓存数据类2.忽视目标抗冰冻 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗昏睡:
					属性缓存数据类2.忽视目标抗昏睡 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗混乱:
					属性缓存数据类2.忽视目标抗混乱 = num;
					break;
				case AllEnums.属性名字Type.强力克金:
					属性缓存数据类2.强力克金 = num;
					break;
				case AllEnums.属性名字Type.强力克木:
					属性缓存数据类2.强力克木 = num;
					break;
				case AllEnums.属性名字Type.强力克水:
					属性缓存数据类2.强力克水 = num;
					break;
				case AllEnums.属性名字Type.强力克火:
					属性缓存数据类2.强力克火 = num;
					break;
				case AllEnums.属性名字Type.强力克土:
					属性缓存数据类2.强力克土 = num;
					break;
				case AllEnums.属性名字Type.师门攻击技能消耗降低:
					属性缓存数据类2.师门攻击技能消耗降低 = num;
					break;
				case AllEnums.属性名字Type.师门障碍技能消耗降低:
					属性缓存数据类2.师门障碍技能消耗降低 = num;
					break;
				case AllEnums.属性名字Type.师门辅助技能消耗降低:
					属性缓存数据类2.师门辅助技能消耗降低 = num;
					break;
				case AllEnums.属性名字Type.强力中毒:
					属性缓存数据类2.强力中毒 = num;
					break;
				case AllEnums.属性名字Type.强力昏睡:
					属性缓存数据类2.强力昏睡 = num;
					break;
				case AllEnums.属性名字Type.强力遗忘:
					属性缓存数据类2.强力遗忘 = num;
					break;
				case AllEnums.属性名字Type.强力混乱:
					属性缓存数据类2.强力混乱 = num;
					break;
				case AllEnums.属性名字Type.强力冰冻:
					属性缓存数据类2.强力冰冻 = num;
					break;
				case AllEnums.属性名字Type.强金法伤害:
					属性缓存数据类2.强金法伤害 = num;
					break;
				case AllEnums.属性名字Type.强木法伤害:
					属性缓存数据类2.强木法伤害 = num;
					break;
				case AllEnums.属性名字Type.强水法伤害:
					属性缓存数据类2.强水法伤害 = num;
					break;
				case AllEnums.属性名字Type.强火法伤害:
					属性缓存数据类2.强火法伤害 = num;
					break;
				case AllEnums.属性名字Type.强土法伤害:
					属性缓存数据类2.强土法伤害 = num;
					break;
				case AllEnums.属性名字Type.躲避攻击:
					属性缓存数据类2.躲避攻击 = num;
					break;
				case AllEnums.属性名字Type.金光乍现反击率:
					属性缓存数据类2.金光乍现反击率 = num;
					break;
				case AllEnums.属性名字Type.摘叶飞花反击率:
					属性缓存数据类2.摘叶飞花反击率 = num;
					break;
				case AllEnums.属性名字Type.滴水穿石反击率:
					属性缓存数据类2.滴水穿石反击率 = num;
					break;
				case AllEnums.属性名字Type.举火焚天反击率:
					属性缓存数据类2.举火焚天反击率 = num;
					break;
				case AllEnums.属性名字Type.落土飞岩反击率:
					属性缓存数据类2.落土飞岩反击率 = num;
					break;
				case AllEnums.属性名字Type.金系法攻:
					属性缓存数据类2.金系法攻 = num;
					break;
				case AllEnums.属性名字Type.木系法攻:
					属性缓存数据类2.木系法攻 = num;
					break;
				case AllEnums.属性名字Type.水系法攻:
					属性缓存数据类2.水系法攻 = num;
					break;
				case AllEnums.属性名字Type.火系法攻:
					属性缓存数据类2.火系法攻 = num;
					break;
				case AllEnums.属性名字Type.土系法攻:
					属性缓存数据类2.土系法攻 = num;
					break;
				case AllEnums.属性名字Type.解除遗忘状态:
					属性缓存数据类2.解除遗忘状态 = num;
					break;
				case AllEnums.属性名字Type.解除中毒状态:
					属性缓存数据类2.解除中毒状态 = num;
					break;
				case AllEnums.属性名字Type.解除冰冻状态:
					属性缓存数据类2.解除冰冻状态 = num;
					break;
				case AllEnums.属性名字Type.解除昏睡状态:
					属性缓存数据类2.解除昏睡状态 = num;
					break;
				case AllEnums.属性名字Type.解除混乱状态:
					属性缓存数据类2.解除混乱状态 = num;
					break;
				case AllEnums.属性名字Type.所有技能上升:
					属性缓存数据类2.所有技能上升 = num;
					break;
				case AllEnums.属性名字Type.攻击效果:
					属性缓存数据类2.攻击效果 = num;
					break;
				case AllEnums.属性名字Type.抗物理:
					属性缓存数据类2.抗物理 = num;
					break;
				case AllEnums.属性名字Type.抗法术:
					属性缓存数据类2.抗法术 = num;
					break;
				case AllEnums.属性名字Type.忽视目标连击:
					属性缓存数据类2.忽视目标连击 = num;
					break;
				case AllEnums.属性名字Type.忽视目标物理必杀:
					属性缓存数据类2.忽视目标物理必杀 = num;
					break;
				case AllEnums.属性名字Type.追击率:
					属性缓存数据类2.追击率 = num;
					break;
				case AllEnums.属性名字Type.强力障碍宠物:
					属性缓存数据类2.强力障碍宠物 = num;
					break;
				case AllEnums.属性名字Type.忽视躲避攻击:
					属性缓存数据类2.忽视躲避攻击 = num;
					break;
				case AllEnums.属性名字Type.强物理伤害:
					属性缓存数据类2.强物理伤害 = num;
					break;
				case AllEnums.属性名字Type.法术必杀率:
					属性缓存数据类2.法术必杀率 = num;
					break;
				case AllEnums.属性名字Type.忽视目标法术必杀:
					属性缓存数据类2.忽视目标法术必杀 = num;
					break;
				case AllEnums.属性名字Type.抗神圣之光:
					属性缓存数据类2.抗神圣之光 = num;
					break;
				case AllEnums.属性名字Type.抗游说之舌:
					属性缓存数据类2.抗游说之舌 = num;
					break;
				case AllEnums.属性名字Type.抗舍命一击:
					属性缓存数据类2.抗舍命一击 = num;
					break;
				case AllEnums.属性名字Type.抗翻转乾坤:
					属性缓存数据类2.抗翻转乾坤 = num;
					break;
				case AllEnums.属性名字Type.抗漫天血舞:
					属性缓存数据类2.抗漫天血舞 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗物理:
					属性缓存数据类2.忽视目标抗物理 = num;
					break;
				case AllEnums.属性名字Type.闪避:
					属性缓存数据类2.闪避 = num;
					break;
				case AllEnums.属性名字Type.抗镇魂:
					属性缓存数据类2.抗镇魂 = num;
					break;
				case AllEnums.属性名字Type.抗化功:
					属性缓存数据类2.抗化功 = num;
					break;
				case AllEnums.属性名字Type.抗水牢:
					属性缓存数据类2.抗水牢 = num;
					break;
				case AllEnums.属性名字Type.抗锁灵:
					属性缓存数据类2.抗锁灵 = num;
					break;
				case AllEnums.属性名字Type.抗迷心:
					属性缓存数据类2.抗迷心 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗镇魂:
					属性缓存数据类2.忽视目标抗镇魂 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗化功:
					属性缓存数据类2.忽视目标抗化功 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗水牢:
					属性缓存数据类2.忽视目标抗水牢 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗锁灵:
					属性缓存数据类2.忽视目标抗锁灵 = num;
					break;
				case AllEnums.属性名字Type.忽视目标抗迷心:
					属性缓存数据类2.忽视目标抗迷心 = num;
					break;
				case AllEnums.属性名字Type.解除镇魂状态:
					属性缓存数据类2.解除镇魂状态 = num;
					break;
				case AllEnums.属性名字Type.解除化功状态:
					属性缓存数据类2.解除化功状态 = num;
					break;
				case AllEnums.属性名字Type.解除水牢状态:
					属性缓存数据类2.解除水牢状态 = num;
					break;
				case AllEnums.属性名字Type.解除锁灵状态:
					属性缓存数据类2.解除锁灵状态 = num;
					break;
				case AllEnums.属性名字Type.解除迷心状态:
					属性缓存数据类2.解除迷心状态 = num;
					break;
				case AllEnums.属性名字Type.强力镇魂:
					属性缓存数据类2.强力镇魂 = num;
					break;
				case AllEnums.属性名字Type.强力化功:
					属性缓存数据类2.强力化功 = num;
					break;
				case AllEnums.属性名字Type.强力水牢:
					属性缓存数据类2.强力水牢 = num;
					break;
				case AllEnums.属性名字Type.强力锁灵:
					属性缓存数据类2.强力锁灵 = num;
					break;
				case AllEnums.属性名字Type.强力迷心:
					属性缓存数据类2.强力迷心 = num;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("接收_对象附加属性信息-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal byte[] lqTBhgvsWt(MyNATSocketClient P_0, byte[] P_1, AllEnums.接收包头枚举 P_2 = AllEnums.接收包头枚举.接收_人物状态)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var value), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value2), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value3), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写2.写字节集(封包_读2.读字节集(12), hasCount: false, 0);
			封包_读2.读整数型(reverse: true, out var value7);
			封包_写2.写整数型(value7, reverse: true);
			封包_读2.读整数型(reverse: true, out var value8);
			封包_写2.写整数型(value8, reverse: true);
			int num = 封包_读2.读整数型(reverse: true);
			int value9 = 封包_读2.读整数型(reverse: true);
			int value10 = 封包_读2.读整数型(reverse: true);
			string text = 封包_读2.读文本型(是否声明长度: true, 0);
			byte[] bytes = 封包_读2.读字节集(6);
			string zone = 封包_读2.读文本型(是否声明长度: true, 0);
			string zone2 = 封包_读2.读文本型(是否声明长度: true, 0);
			string zone3 = 封包_读2.读文本型(是否声明长度: true, 0);
			string zone4 = 封包_读2.读文本型(是否声明长度: true, 0);
			byte[] bytes2 = 封包_读2.读字节集(10);
			int value11 = 封包_读2.读整数型(reverse: true);
			int value12 = 封包_读2.读整数型(reverse: true);
			int num2 = 封包_读2.读整数型(reverse: true);
			int num3 = 封包_读2.读整数型(reverse: true);
			byte[] array = 封包_读2.读字节集(2);
			byte[] bytes3 = 封包_读2.读字节集(2);
			int num4 = 封包_读2.读字节型();
			if (value == P_0.user.人物数据.角色ID)
			{
				P_0.user.缓存数据.X4j8zimpds = num3;
				P_0.user.缓存数据.pexIuRNo9u = num2;
			}
			string 当前原坐姿id = string.Empty;
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定角色ID玩家MyClient(value);
			if (myNATSocketClient != null)
			{
				string 染色坐姿key = string.Empty;
				if (Enumerable.SequenceEqual(array, new byte[2] { 0, 4 }))
				{
					string text2 = num2.ToString();
					string text3 = num3.ToString();
					string text4 = string.Empty;
					if (Singleton<全局变量类>.I.时装坐姿染色配置.时装坐姿开关)
					{
						text4 = Singleton<pn8GKqU6fTj7IRdG6Bm>.I.S3gUL37bJn(text2, text3);
					}
					if (string.IsNullOrWhiteSpace(text4))
					{
						text4 = text3;
					}
					当前原坐姿id = text4;
					if (Singleton<全局变量类>.I.时装坐姿染色配置.坐姿染色开关 && !string.IsNullOrWhiteSpace(text4) && !string.IsNullOrWhiteSpace(myNATSocketClient.user.存档数据.染色数据.原坐姿ID) && text4 == myNATSocketClient.user.存档数据.染色数据.原坐姿ID && !string.IsNullOrWhiteSpace(myNATSocketClient.user.存档数据.染色数据.染后坐姿ID))
					{
						text4 = myNATSocketClient.user.存档数据.染色数据.染后坐姿ID;
						染色坐姿key = text3;
					}
					if (text4 != text3)
					{
						num3 = int.Parse(text4);
					}
				}
				myNATSocketClient.user.缓存数据.染色坐姿key = 染色坐姿key;
			}
			bool flag = false;
			封包_写2.写整数型(Singleton<VuI4pmDQ6nQtpDAauah>.I.xGWDHubVgk(num, num4, ref flag), reverse: true);
			封包_写2.写整数型(value9, reverse: true);
			封包_写2.写整数型(value10, reverse: true);
			封包_写2.写文本型(text, hasCount: true, 0);
			封包_写2.写字节集(bytes, hasCount: false, 0);
			if (Singleton<全局变量类>.I.挑战BOSS配置.功能开关 && Singleton<全局变量类>.I.挑战BOSS配置.挑战boss列表.TryGetValue(text, out 挑战BOSS列表类 value13) && !string.IsNullOrWhiteSpace(value13.BOSS称号))
			{
				zone = value13.BOSS称号;
			}
			封包_写2.写文本型(zone, hasCount: true, 0);
			封包_写2.写文本型(zone2, hasCount: true, 0);
			封包_写2.写文本型(zone3, hasCount: true, 0);
			封包_写2.写文本型(zone4, hasCount: true, 0);
			封包_写2.写字节集(bytes2, hasCount: false, 0);
			封包_写2.写整数型(value11, reverse: true);
			封包_写2.写整数型(value12, reverse: true);
			封包_写2.写整数型(num2, reverse: true);
			封包_写2.写整数型(num3, reverse: true);
			封包_写2.写字节集(array, hasCount: false, 0);
			封包_写2.写字节集(bytes3, hasCount: false, 0);
			if (P_0.user.人物数据.昵称 == text)
			{
				P_0.user.缓存数据.当前原坐姿id = 当前原坐姿id;
				P_0.user.缓存数据.自身显示封包备份 = P_1;
				P_0.user.人物数据.飞行器 = (byte)num4;
			}
			if (flag)
			{
				num4 = 0;
			}
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && P_0.user.存档数据.元神存档.突破中)
			{
				num4 = 1;
			}
			封包_写2.写字节型(num4);
			封包_写2.写字节集(封包_读2.读字节集(19), hasCount: false, 0);
			封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
			封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			if (P_2 == AllEnums.接收包头枚举.接收_人物对象显示)
			{
				Singleton<WdAPI>.I.NPCID预读(P_0, text, value, value2, value3);
			}
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return obj.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("组包人物状态报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	public L1ya6XBSPGoekkP8WeX()
	{
	}

	static L1ya6XBSPGoekkP8WeX()
	{
	}
}
