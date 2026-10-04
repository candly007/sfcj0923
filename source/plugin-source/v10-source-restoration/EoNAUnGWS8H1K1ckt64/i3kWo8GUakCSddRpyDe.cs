using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Serilog;

namespace EoNAUnGWS8H1K1ckt64;

internal class i3kWo8GUakCSddRpyDe : Singleton<i3kWo8GUakCSddRpyDe>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public int kETTJDLKFj;

		
		public _003C_003Ec__DisplayClass0_0()
		{
		}

		
		internal bool PS3TbMsQsv(宠物缓存数据类 a)
		{
			return a.宠物ID == kETTJDLKFj;
		}

		static _003C_003Ec__DisplayClass0_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public int TXrTR2fIka;

		public int DKVTdQbPAC;

		
		public _003C_003Ec__DisplayClass1_0()
		{
		}

		
		internal bool BdsTKwe1Uc(宠物缓存数据类 a)
		{
			if (a.宠物ID == TXrTR2fIka)
			{
				return a.PetID == DKVTdQbPAC;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass1_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public int b2TTUqq3R3;

		
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		
		internal bool dQCTsNxBNT(宠物缓存数据类 a)
		{
			return a.宠物ID == b2TTUqq3R3;
		}

		static _003C_003Ec__DisplayClass2_0()
		{
		}
	}

	
	internal byte[] v2ZGgD6bGf(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass0_0();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			int num = 封包_读2.读字节型();
			封包_写2.写字节型(num);
			CS_0024_003C_003E8__locals10.kETTJDLKFj = 封包_读2.读整数型(reverse: true);
			封包_写2.写整数型(CS_0024_003C_003E8__locals10.kETTJDLKFj, reverse: true);
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.ToList().Find( (宠物缓存数据类 a) => a.宠物ID == CS_0024_003C_003E8__locals10.kETTJDLKFj);
			if (宠物缓存数据类2 == null)
			{
				宠物缓存数据类2 = Singleton<WdAPI>.I.h2Uoosf8y4(P_0);
				if (宠物缓存数据类2 == null)
				{
					return P_1;
				}
			}
			宠物缓存数据类2.宠物ID = CS_0024_003C_003E8__locals10.kETTJDLKFj;
			宠物缓存数据类2.PetID = num;
			string empty = string.Empty;
			string text = string.Empty;
			宠物缓存数据类2.IID = DB.I.u0sNXMe2QN(P_0, num, ref empty);
			short num2 = 封包_读2.读短整数型(reverse: true);
			封包_写2.写短整数型(num2, reverse: true);
			int num3 = 0;
			short num4 = 0;
			int num5 = 0;
			string empty2 = string.Empty;
			for (int num6 = 0; num6 < num2; num6++)
			{
				封包_写2.写字节集(封包_读2.读字节集(2, out byte[] value), hasCount: false, 0);
				short num7 = 封包_读2.读短整数型(reverse: true);
				封包_写2.写短整数型(num7, reverse: true);
				for (int num8 = 0; num8 < num7; num8++)
				{
					num3 = 0;
					num4 = 0;
					num5 = 0;
					empty2 = string.Empty;
					byte[] array = 封包_读2.读字节集(2);
					封包_写2.写字节集(array, hasCount: false, 0);
					int num9 = 封包_读2.读字节型();
					封包_写2.写字节型(num9);
					switch (num9)
					{
					case 1:
						num3 = 封包_读2.读字节型();
						封包_写2.写字节型(num3);
						if (Enumerable.SequenceEqual(value, new byte[2] { 0, 1 }))
						{
							if (Enumerable.SequenceEqual(array, new byte[2] { 1, 151 }))
							{
								宠物缓存数据类2.绑定状态 = ((num3 != 3 && num3 != 4) ? AllEnums.绑定Type.不绑定 : ((num3 == 4) ? AllEnums.绑定Type.死绑 : AllEnums.绑定Type.红绑));
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 157 }))
							{
								宠物缓存数据类2.阶级 = (byte)num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 109 }))
							{
								宠物缓存数据类2.类型 = (byte)num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 48 }))
							{
								宠物缓存数据类2.血量幻化次数 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 50 }))
							{
								宠物缓存数据类2.法力幻化次数 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 52 }))
							{
								宠物缓存数据类2.速度幻化次数 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 54 }))
							{
								宠物缓存数据类2.物攻幻化次数 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 56 }))
							{
								宠物缓存数据类2.法攻幻化次数 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 56 }))
							{
								宠物缓存数据类2.飞升 = num3;
							}
						}
						else if (Enumerable.SequenceEqual(value, new byte[2] { 23, 2 }) && Enumerable.SequenceEqual(array, new byte[2] { 1, 61 }))
						{
							宠物缓存数据类2.提高移动速度 = num3;
						}
						break;
					case 2:
						num4 = 封包_读2.读短整数型(reverse: true);
						封包_写2.写短整数型(num4, reverse: true);
						if (Enumerable.SequenceEqual(value, new byte[2] { 0, 1 }))
						{
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 31 }))
							{
								宠物缓存数据类2.等级 = num4;
							}
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 44 }))
							{
								宠物缓存数据类2.相性 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 104 }))
							{
								宠物缓存数据类2.血量成长 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 105 }))
							{
								宠物缓存数据类2.法力成长 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 106 }))
							{
								宠物缓存数据类2.速度成长 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 107 }))
							{
								宠物缓存数据类2.物攻成长 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 108 }))
							{
								宠物缓存数据类2.法攻成长 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 165 }))
							{
								宠物缓存数据类2.基础血量成长 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 166 }))
							{
								宠物缓存数据类2.基础法力成长 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 167 }))
							{
								宠物缓存数据类2.基础速度成长 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 168 }))
							{
								宠物缓存数据类2.基础物攻成长 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 169 }))
							{
								宠物缓存数据类2.基础法攻成长 = num4;
							}
						}
						else if (Enumerable.SequenceEqual(value, new byte[2] { 23, 2 }))
						{
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 220 }))
							{
								宠物缓存数据类2.坐骑增加所属 = num4;
							}
						}
						else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 14 }))
						{
							宠物缓存数据类2.速度 = (ushort)num4;
						}
						break;
					case 3:
						num5 = 封包_读2.读整数型(reverse: true);
						封包_写2.写整数型(num5, reverse: true);
						if (Enumerable.SequenceEqual(value, new byte[2] { 0, 1 }))
						{
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 61 }))
							{
								宠物缓存数据类2.寿命 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 62 }))
							{
								宠物缓存数据类2.武学 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 63 }))
							{
								宠物缓存数据类2.亲密 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 66 }))
							{
								宠物缓存数据类2.忠诚度 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 64 }))
							{
								宠物缓存数据类2.总成长 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 170 }))
							{
								宠物缓存数据类2.基础总成长 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 10 }))
							{
								宠物缓存数据类2.法攻强化次数 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 9 }))
							{
								宠物缓存数据类2.物攻强化次数 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 80 }))
							{
								宠物缓存数据类2.反震度 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 208 }))
							{
								宠物缓存数据类2.法攻强化进度 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 207 }))
							{
								宠物缓存数据类2.物攻强化进度 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 25 }))
							{
								宠物缓存数据类2.经验 = num5;
							}
						}
						else if (Enumerable.SequenceEqual(value, new byte[2] { 23, 2 }))
						{
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 10 }))
							{
								宠物缓存数据类2.坐骑增加法攻 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 3 }))
							{
								宠物缓存数据类2.坐骑增加物攻 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 3 }))
							{
								宠物缓存数据类2.坐骑增加防御 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 50 }))
							{
								宠物缓存数据类2.坐骑增加仙属 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 51 }))
							{
								宠物缓存数据类2.坐骑增加魔属 = num5;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 60 }))
							{
								宠物缓存数据类2.坐骑持续时间 = num5;
							}
						}
						break;
					case 4:
						empty2 = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
						封包_写2.写文本型(empty2, hasCount: true, 0, reverse: true);
						if (Enumerable.SequenceEqual(value, new byte[2] { 0, 1 }))
						{
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 1 }))
							{
								宠物缓存数据类2.昵称A = empty2;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 11 }))
							{
								宠物缓存数据类2.昵称B = empty2;
								if (empty2 != empty)
								{
									宠物缓存数据类2.IID = string.Empty;
								}
								text = empty2;
							}
						}
						else if (Enumerable.SequenceEqual(value, new byte[2] { 23, 2 }) && Enumerable.SequenceEqual(array, new byte[2] { 0, 1 }))
						{
							宠物缓存数据类2.is风灵丸 = empty2 == "风灵丸";
						}
						break;
					case 6:
						num3 = 封包_读2.读字节型();
						封包_写2.写字节型(num3);
						break;
					case 7:
						num4 = 封包_读2.读短整数型(reverse: true);
						封包_写2.写短整数型(num4, reverse: true);
						break;
					}
				}
			}
			if (P_0.user.缓存数据.当前乘骑坐骑id == CS_0024_003C_003E8__locals10.kETTJDLKFj)
			{
				P_0.user.缓存数据.is坐骑风灵丸 = 宠物缓存数据类2.is风灵丸;
			}
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			if (Singleton<全局变量类>.I.宠物绑定配置.功能开关)
			{
				if (Singleton<全局变量类>.I.宠物绑定配置.道具宠物绑定列表.TryGetValue(P_0.user.缓存数据.宠物绑定道具, out string value2))
				{
					if (("|" + value2 + "|").Contains("|" + text + "|", StringComparison.CurrentCulture))
					{
						Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals10.kETTJDLKFj.ToString(), "property_bind/attrib", Singleton<全局变量类>.I.宠物绑定配置.is死绑开关 ? "4" : "3", "admin_set_attrib");
					}
				}
				else if (("|" + Singleton<全局变量类>.I.宠物绑定配置.宠物自动绑定列表 + "|").Contains("|" + text + "|", StringComparison.CurrentCulture))
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals10.kETTJDLKFj.ToString(), "property_bind/attrib", Singleton<全局变量类>.I.宠物绑定配置.is死绑开关 ? "4" : "3", "admin_set_attrib");
				}
				P_0.user.缓存数据.宠物绑定道具 = string.Empty;
			}
			if (Singleton<全局变量类>.I.等级道行检测.is检测等级)
			{
				if (宠物缓存数据类2.等级 > Singleton<全局变量类>.I.等级道行检测.最高等级 + 15)
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals10.kETTJDLKFj.ToString(), "level", $"{Singleton<全局变量类>.I.等级道行检测.最高等级 + 15}", "admin_set_attrib");
					if (宠物缓存数据类2.经验 != 0)
					{
						Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals10.kETTJDLKFj.ToString(), "exp", "0", "admin_set_attrib");
					}
				}
				else if (宠物缓存数据类2.等级 == Singleton<全局变量类>.I.等级道行检测.最高等级 + 15 && 宠物缓存数据类2.经验 != 0)
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals10.kETTJDLKFj.ToString(), "exp", "0", "admin_set_attrib");
				}
			}
			return obj.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("接收_宠物面板-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	public byte[] dj3GDEQoE3(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass1_0();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(12L, SeekOrigin.Begin);
			封包_读2.读字节集(2);
			封包_读2.读字节型(out CS_0024_003C_003E8__locals8.DKVTdQbPAC);
			封包_读2.读整数型(reverse: true, out CS_0024_003C_003E8__locals8.TXrTR2fIka);
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.Find( (宠物缓存数据类 a) => a.宠物ID == CS_0024_003C_003E8__locals8.TXrTR2fIka && a.PetID == CS_0024_003C_003E8__locals8.DKVTdQbPAC);
			if (宠物缓存数据类2 == null)
			{
				return P_1;
			}
			封包_读2.读短整数型(reverse: true, out var value);
			int num = 0;
			short num2 = 0;
			int num3 = 0;
			string empty = string.Empty;
			for (int num4 = 0; num4 < value; num4++)
			{
				封包_读2.读字节集(2, out byte[] value2);
				封包_读2.读短整数型(reverse: true, out var value3);
				for (int num5 = 0; num5 < value3; num5++)
				{
					封包_读2.读字节集(2, out byte[] value4);
					封包_读2.读字节型(out var value5);
					switch (value5)
					{
					case 1:
						num = 封包_读2.读字节型();
						if (Enumerable.SequenceEqual(value2, new byte[2] { 0, 1 }))
						{
							if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 151 }))
							{
								宠物缓存数据类2.绑定状态 = ((num != 3 && num != 4) ? AllEnums.绑定Type.不绑定 : ((num == 4) ? AllEnums.绑定Type.死绑 : AllEnums.绑定Type.红绑));
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 157 }))
							{
								宠物缓存数据类2.阶级 = (byte)num;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 109 }))
							{
								宠物缓存数据类2.类型 = (byte)num;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 2, 48 }))
							{
								宠物缓存数据类2.血量幻化次数 = num;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 2, 50 }))
							{
								宠物缓存数据类2.法力幻化次数 = num;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 2, 52 }))
							{
								宠物缓存数据类2.速度幻化次数 = num;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 2, 54 }))
							{
								宠物缓存数据类2.物攻幻化次数 = num;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 2, 56 }))
							{
								宠物缓存数据类2.法攻幻化次数 = num;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 56 }))
							{
								宠物缓存数据类2.飞升 = num;
							}
						}
						else if (Enumerable.SequenceEqual(value2, new byte[2] { 23, 2 }) && Enumerable.SequenceEqual(value4, new byte[2] { 1, 61 }))
						{
							宠物缓存数据类2.提高移动速度 = num;
						}
						break;
					case 2:
						num2 = 封包_读2.读短整数型(reverse: true);
						if (Enumerable.SequenceEqual(value2, new byte[2] { 0, 1 }))
						{
							if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 31 }))
							{
								宠物缓存数据类2.等级 = num2;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 104 }))
							{
								宠物缓存数据类2.血量成长 = num2;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 105 }))
							{
								宠物缓存数据类2.法力成长 = num2;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 106 }))
							{
								宠物缓存数据类2.速度成长 = num2;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 107 }))
							{
								宠物缓存数据类2.物攻成长 = num2;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 108 }))
							{
								宠物缓存数据类2.法攻成长 = num2;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 165 }))
							{
								宠物缓存数据类2.基础血量成长 = num2;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 166 }))
							{
								宠物缓存数据类2.基础法力成长 = num2;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 167 }))
							{
								宠物缓存数据类2.基础速度成长 = num2;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 168 }))
							{
								宠物缓存数据类2.基础物攻成长 = num2;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 169 }))
							{
								宠物缓存数据类2.基础法攻成长 = num2;
							}
						}
						else if (Enumerable.SequenceEqual(value2, new byte[2] { 23, 2 }) && Enumerable.SequenceEqual(value4, new byte[2] { 0, 220 }))
						{
							宠物缓存数据类2.坐骑增加所属 = num2;
						}
						break;
					case 3:
						num3 = 封包_读2.读整数型(reverse: true);
						if (Enumerable.SequenceEqual(value2, new byte[2] { 0, 1 }))
						{
							if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 61 }))
							{
								宠物缓存数据类2.寿命 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 62 }))
							{
								宠物缓存数据类2.武学 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 63 }))
							{
								宠物缓存数据类2.亲密 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 66 }))
							{
								宠物缓存数据类2.忠诚度 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 64 }))
							{
								宠物缓存数据类2.总成长 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 170 }))
							{
								宠物缓存数据类2.基础总成长 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 10 }))
							{
								宠物缓存数据类2.法攻强化次数 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 9 }))
							{
								宠物缓存数据类2.物攻强化次数 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 80 }))
							{
								宠物缓存数据类2.反震度 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 2, 208 }))
							{
								宠物缓存数据类2.法攻强化进度 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 2, 207 }))
							{
								宠物缓存数据类2.物攻强化进度 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 25 }))
							{
								宠物缓存数据类2.经验 = num3;
							}
						}
						else if (Enumerable.SequenceEqual(value2, new byte[2] { 23, 2 }))
						{
							if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 10 }))
							{
								宠物缓存数据类2.坐骑增加法攻 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 3 }))
							{
								宠物缓存数据类2.坐骑增加物攻 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 3 }))
							{
								宠物缓存数据类2.坐骑增加防御 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 50 }))
							{
								宠物缓存数据类2.坐骑增加仙属 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 51 }))
							{
								宠物缓存数据类2.坐骑增加魔属 = num3;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 60 }))
							{
								宠物缓存数据类2.坐骑持续时间 = num3;
							}
						}
						break;
					case 4:
						empty = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
						if (Enumerable.SequenceEqual(value2, new byte[2] { 0, 1 }))
						{
							if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 1 }))
							{
								宠物缓存数据类2.昵称A = empty;
							}
							else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 11 }))
							{
								宠物缓存数据类2.昵称B = empty;
							}
						}
						else if (Enumerable.SequenceEqual(value2, new byte[2] { 23, 2 }) && Enumerable.SequenceEqual(value4, new byte[2] { 0, 1 }))
						{
							宠物缓存数据类2.is风灵丸 = empty == "风灵丸";
						}
						break;
					case 6:
						num = 封包_读2.读字节型();
						break;
					case 7:
						num2 = 封包_读2.读短整数型(reverse: true);
						break;
					}
				}
			}
			if (P_0.user.缓存数据.当前乘骑坐骑id == CS_0024_003C_003E8__locals8.TXrTR2fIka)
			{
				P_0.user.缓存数据.is坐骑风灵丸 = 宠物缓存数据类2.is风灵丸;
			}
			if (Singleton<全局变量类>.I.等级道行检测.is检测等级)
			{
				if (宠物缓存数据类2.等级 > Singleton<全局变量类>.I.等级道行检测.最高等级 + 15)
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals8.TXrTR2fIka.ToString(), "level", $"{Singleton<全局变量类>.I.等级道行检测.最高等级 + 15}", "admin_set_attrib");
					if (宠物缓存数据类2.经验 != 0)
					{
						Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals8.TXrTR2fIka.ToString(), "exp", "0", "admin_set_attrib");
					}
				}
				else if (宠物缓存数据类2.等级 == Singleton<全局变量类>.I.等级道行检测.最高等级 + 15 && 宠物缓存数据类2.经验 != 0)
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals8.TXrTR2fIka.ToString(), "exp", "0", "admin_set_attrib");
				}
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("接收_宠物刷新信息-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] rAqGjiGmji(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass2_0();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写字节集(封包_读2.读字节集(6), hasCount: false, 0);
			封包_写2.写字节型(封包_读2.读字节型(out var value));
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out CS_0024_003C_003E8__locals9.b2TTUqq3R3), reverse: true);
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.ToList().Find( (宠物缓存数据类 a) => a.宠物ID == CS_0024_003C_003E8__locals9.b2TTUqq3R3);
			if (宠物缓存数据类2 == null)
			{
				宠物缓存数据类2 = Singleton<WdAPI>.I.h2Uoosf8y4(P_0);
				if (宠物缓存数据类2 == null)
				{
					return P_1;
				}
			}
			宠物缓存数据类2.宠物ID = CS_0024_003C_003E8__locals9.b2TTUqq3R3;
			宠物缓存数据类2.PetID = value;
			string empty = string.Empty;
			string text = string.Empty;
			宠物缓存数据类2.IID = DB.I.u0sNXMe2QN(P_0, value, ref empty);
			short num = 封包_读2.读短整数型(reverse: true);
			封包_写2.写短整数型(num, reverse: true);
			int num2 = 0;
			short num3 = 0;
			int num4 = 0;
			string empty2 = string.Empty;
			for (int num5 = 0; num5 < num; num5++)
			{
				封包_写2.写字节集(封包_读2.读字节集(2, out byte[] value2), hasCount: false, 0);
				short num6 = 封包_读2.读短整数型(reverse: true);
				封包_写2.写短整数型(num6, reverse: true);
				for (int num7 = 0; num7 < num6; num7++)
				{
					num2 = 0;
					num3 = 0;
					num4 = 0;
					empty2 = string.Empty;
					byte[] array = 封包_读2.读字节集(2);
					封包_写2.写字节集(array, hasCount: false, 0);
					int num8 = 封包_读2.读字节型();
					封包_写2.写字节型(num8);
					switch (num8)
					{
					case 1:
						num2 = 封包_读2.读字节型();
						封包_写2.写字节型(num2);
						if (Enumerable.SequenceEqual(value2, new byte[2] { 0, 1 }))
						{
							if (Enumerable.SequenceEqual(array, new byte[2] { 1, 151 }))
							{
								宠物缓存数据类2.绑定状态 = ((num2 != 3 && num2 != 4) ? AllEnums.绑定Type.不绑定 : ((num2 == 4) ? AllEnums.绑定Type.死绑 : AllEnums.绑定Type.红绑));
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 157 }))
							{
								宠物缓存数据类2.阶级 = (byte)num2;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 109 }))
							{
								宠物缓存数据类2.类型 = (byte)num2;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 48 }))
							{
								宠物缓存数据类2.血量幻化次数 = num2;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 50 }))
							{
								宠物缓存数据类2.法力幻化次数 = num2;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 52 }))
							{
								宠物缓存数据类2.速度幻化次数 = num2;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 54 }))
							{
								宠物缓存数据类2.物攻幻化次数 = num2;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 56 }))
							{
								宠物缓存数据类2.法攻幻化次数 = num2;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 56 }))
							{
								宠物缓存数据类2.飞升 = num2;
							}
						}
						else if (Enumerable.SequenceEqual(value2, new byte[2] { 23, 2 }) && Enumerable.SequenceEqual(array, new byte[2] { 1, 61 }))
						{
							宠物缓存数据类2.提高移动速度 = num2;
						}
						break;
					case 2:
						num3 = 封包_读2.读短整数型(reverse: true);
						封包_写2.写短整数型(num3, reverse: true);
						if (Enumerable.SequenceEqual(value2, new byte[2] { 0, 1 }))
						{
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 31 }))
							{
								宠物缓存数据类2.等级 = num3;
							}
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 44 }))
							{
								宠物缓存数据类2.相性 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 104 }))
							{
								宠物缓存数据类2.血量成长 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 105 }))
							{
								宠物缓存数据类2.法力成长 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 106 }))
							{
								宠物缓存数据类2.速度成长 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 107 }))
							{
								宠物缓存数据类2.物攻成长 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 108 }))
							{
								宠物缓存数据类2.法攻成长 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 165 }))
							{
								宠物缓存数据类2.基础血量成长 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 166 }))
							{
								宠物缓存数据类2.基础法力成长 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 167 }))
							{
								宠物缓存数据类2.基础速度成长 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 168 }))
							{
								宠物缓存数据类2.基础物攻成长 = num3;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 169 }))
							{
								宠物缓存数据类2.基础法攻成长 = num3;
							}
						}
						else if (Enumerable.SequenceEqual(value2, new byte[2] { 23, 2 }))
						{
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 220 }))
							{
								宠物缓存数据类2.坐骑增加所属 = num3;
							}
						}
						else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 14 }))
						{
							宠物缓存数据类2.速度 = (ushort)num3;
						}
						break;
					case 3:
						num4 = 封包_读2.读整数型(reverse: true);
						封包_写2.写整数型(num4, reverse: true);
						if (Enumerable.SequenceEqual(value2, new byte[2] { 0, 1 }))
						{
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 61 }))
							{
								宠物缓存数据类2.寿命 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 62 }))
							{
								宠物缓存数据类2.武学 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 63 }))
							{
								宠物缓存数据类2.亲密 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 66 }))
							{
								宠物缓存数据类2.忠诚度 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 64 }))
							{
								宠物缓存数据类2.总成长 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 170 }))
							{
								宠物缓存数据类2.基础总成长 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 10 }))
							{
								宠物缓存数据类2.法攻强化次数 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 9 }))
							{
								宠物缓存数据类2.物攻强化次数 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 80 }))
							{
								宠物缓存数据类2.反震度 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 208 }))
							{
								宠物缓存数据类2.法攻强化进度 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 2, 207 }))
							{
								宠物缓存数据类2.物攻强化进度 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 25 }))
							{
								宠物缓存数据类2.经验 = num4;
							}
						}
						else if (Enumerable.SequenceEqual(value2, new byte[2] { 23, 2 }))
						{
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 10 }))
							{
								宠物缓存数据类2.坐骑增加法攻 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 3 }))
							{
								宠物缓存数据类2.坐骑增加物攻 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 0, 3 }))
							{
								宠物缓存数据类2.坐骑增加防御 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 50 }))
							{
								宠物缓存数据类2.坐骑增加仙属 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 51 }))
							{
								宠物缓存数据类2.坐骑增加魔属 = num4;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 60 }))
							{
								宠物缓存数据类2.坐骑持续时间 = num4;
							}
						}
						break;
					case 4:
						empty2 = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
						封包_写2.写文本型(empty2, hasCount: true, 0, reverse: true);
						if (Enumerable.SequenceEqual(value2, new byte[2] { 0, 1 }))
						{
							if (Enumerable.SequenceEqual(array, new byte[2] { 0, 1 }))
							{
								宠物缓存数据类2.昵称A = empty2;
							}
							else if (Enumerable.SequenceEqual(array, new byte[2] { 1, 11 }))
							{
								宠物缓存数据类2.昵称B = empty2;
								if (empty2 != empty)
								{
									宠物缓存数据类2.IID = string.Empty;
								}
								text = empty2;
							}
						}
						else if (Enumerable.SequenceEqual(value2, new byte[2] { 23, 2 }) && Enumerable.SequenceEqual(array, new byte[2] { 0, 1 }))
						{
							宠物缓存数据类2.is风灵丸 = empty2 == "风灵丸";
						}
						break;
					case 6:
						num2 = 封包_读2.读字节型();
						封包_写2.写字节型(num2);
						break;
					case 7:
						num3 = 封包_读2.读短整数型(reverse: true);
						封包_写2.写短整数型(num3, reverse: true);
						break;
					}
				}
			}
			if (P_0.user.缓存数据.当前乘骑坐骑id == CS_0024_003C_003E8__locals9.b2TTUqq3R3)
			{
				P_0.user.缓存数据.is坐骑风灵丸 = 宠物缓存数据类2.is风灵丸;
			}
			if (Singleton<全局变量类>.I.宠物绑定配置.功能开关)
			{
				if (Singleton<全局变量类>.I.宠物绑定配置.道具宠物绑定列表.TryGetValue(P_0.user.缓存数据.宠物绑定道具, out string value3))
				{
					if (("|" + value3 + "|").Contains("|" + text + "|", StringComparison.CurrentCulture))
					{
						Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals9.b2TTUqq3R3.ToString(), "property_bind/attrib", Singleton<全局变量类>.I.宠物绑定配置.is死绑开关 ? "4" : "3", "admin_set_attrib");
					}
				}
				else if (("|" + Singleton<全局变量类>.I.宠物绑定配置.宠物自动绑定列表 + "|").Contains("|" + text + "|", StringComparison.CurrentCulture))
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals9.b2TTUqq3R3.ToString(), "property_bind/attrib", Singleton<全局变量类>.I.宠物绑定配置.is死绑开关 ? "4" : "3", "admin_set_attrib");
				}
				P_0.user.缓存数据.宠物绑定道具 = string.Empty;
			}
			if (Singleton<全局变量类>.I.等级道行检测.is检测等级)
			{
				if (宠物缓存数据类2.等级 > Singleton<全局变量类>.I.等级道行检测.最高等级 + 15)
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals9.b2TTUqq3R3.ToString(), "level", $"{Singleton<全局变量类>.I.等级道行检测.最高等级 + 15}", "admin_set_attrib");
					if (宠物缓存数据类2.经验 != 0)
					{
						Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals9.b2TTUqq3R3.ToString(), "exp", "0", "admin_set_attrib");
					}
				}
				else if (宠物缓存数据类2.等级 == Singleton<全局变量类>.I.等级道行检测.最高等级 + 15 && 宠物缓存数据类2.经验 != 0)
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, CS_0024_003C_003E8__locals9.b2TTUqq3R3.ToString(), "exp", "0", "admin_set_attrib");
				}
			}
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("接收_宠物获得处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	public i3kWo8GUakCSddRpyDe()
	{
	}

	static i3kWo8GUakCSddRpyDe()
	{
	}
}
