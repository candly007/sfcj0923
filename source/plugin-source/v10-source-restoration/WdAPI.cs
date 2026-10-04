using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Net.Share;
using SGIgOgiC7KPqObpOnGQ;
using Serilog;
using jVVIM9j1PL0VAliGELE;
using sVcPYnW2a67ob5mDj4x;
using vBIs2Rf2vSSk1OdhoS7;
using xqlPMM2TJRNXpZnNDFn;

public class WdAPI : Singleton<WdAPI>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public int Pva72vKMwk;

		
		public _003C_003Ec__DisplayClass106_0()
		{
		}

		
		internal bool Jsx76c5Gkx(宠物缓存数据类 a)
		{
			return a.宠物ID == Pva72vKMwk;
		}

		static _003C_003Ec__DisplayClass106_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass126_0
	{
		public string Lsw7PZjrII;

		
		public _003C_003Ec__DisplayClass126_0()
		{
		}

		
		internal bool UIN7meLfko(超级NPC传送类 x)
		{
			return x.地图名字 == Lsw7PZjrII;
		}

		static _003C_003Ec__DisplayClass126_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass128_0
	{
		public string PZa7FuRaQh;

		
		public _003C_003Ec__DisplayClass128_0()
		{
		}

		
		internal bool Bfk7XsJbns(NPC信息类 x)
		{
			return x.名字 == PZa7FuRaQh;
		}

		static _003C_003Ec__DisplayClass128_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass141_0<T>
	{
		public Func<T, int> 权重字段;

		
		public _003C_003Ec__DisplayClass141_0()
		{
		}

		
		internal int G2k7LMRN9w(T x)
		{
			return Math.Max(0, 权重字段(x));
		}

		static _003C_003Ec__DisplayClass141_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass149_0
	{
		public short Bsh7c42DAt;

		public Func<int, bool> zm67nLfWyd;

		
		public _003C_003Ec__DisplayClass149_0()
		{
		}

		
		internal bool TOn7SLdQsV(int x)
		{
			return x == Bsh7c42DAt;
		}

		static _003C_003Ec__DisplayClass149_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public string F377MZ70Nw;

		
		public _003C_003Ec__DisplayClass41_0()
		{
		}

		
		internal bool tC075mjx5b(MyNATSocketClient x)
		{
			return x.user.人物数据.昵称 == F377MZ70Nw;
		}

		static _003C_003Ec__DisplayClass41_0()
		{
		}
	}

	
	public int 获取包头(byte[] buffer, int offset, int count)
	{
		byte[] array = new byte[2 + count];
		for (int i = 0; i < count; i++)
		{
			array[i] = buffer[offset + count - 1 - i];
		}
		return BitConverter.ToInt32(array);
	}

	
	public byte[] 组装化形面板(int 当前值, int 最大值 = 100)
	{
		return new byte[30]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 31,
			240, 169, 1, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 2, 2, 118, 3
		}.Concat(Singleton<ByteAPI>.I.到字节集固定反转(当前值)).Concat(new byte[3] { 2, 119, 3 }).Concat(Singleton<ByteAPI>.I.到字节集固定反转(最大值))
			.ToArray();
	}

	
	public int 进入战斗获取化形初值(MyNATSocketClient myclient)
	{
		try
		{
			int num = 0;
			num += myclient.user.背包数据.物品列表[1].装备属性列表.Find( (属性数据 x) => x.属性类别 == 3330 && x.属性标识 == 337).属性数值;
			num += myclient.user.背包数据.物品列表[31].装备属性列表.Find( (属性数据 x) => (x.属性类别 == 514 || x.属性类别 == 770 || x.属性类别 == 3074) && x.属性标识 == 337).属性数值;
			num += myclient.user.背包数据.物品列表[32].装备属性列表.Find( (属性数据 x) => (x.属性类别 == 514 || x.属性类别 == 770 || x.属性类别 == 3074) && x.属性标识 == 337).属性数值;
			洗炼属性缓存列表类 洗炼属性缓存列表类2 = myclient.user.背包数据.物品列表[9].洗炼属性列表.Find( (洗炼属性缓存列表类 x) => x.属性 == AllEnums.洗炼属性Type.出战化形);
			if (洗炼属性缓存列表类2 != null)
			{
				num += 洗炼属性缓存列表类2.数值;
			}
			洗炼属性缓存列表类 洗炼属性缓存列表类3 = myclient.user.背包数据.物品列表[8].洗炼属性列表.Find( (洗炼属性缓存列表类 x) => x.属性 == AllEnums.洗炼属性Type.出战化形);
			if (洗炼属性缓存列表类3 != null)
			{
				num += 洗炼属性缓存列表类3.数值;
			}
			洗炼属性缓存列表类 洗炼属性缓存列表类4 = myclient.user.背包数据.物品列表[33].洗炼属性列表.Find( (洗炼属性缓存列表类 x) => x.属性 == AllEnums.洗炼属性Type.出战化形);
			if (洗炼属性缓存列表类4 != null)
			{
				num += 洗炼属性缓存列表类4.数值;
			}
			洗炼属性缓存列表类 洗炼属性缓存列表类5 = myclient.user.背包数据.物品列表[41].洗炼属性列表.Find( (洗炼属性缓存列表类 x) => x.属性 == AllEnums.洗炼属性Type.出战化形);
			if (洗炼属性缓存列表类5 != null)
			{
				num += 洗炼属性缓存列表类5.数值;
			}
			洗炼属性缓存列表类 洗炼属性缓存列表类6 = myclient.user.背包数据.物品列表[42].洗炼属性列表.Find( (洗炼属性缓存列表类 x) => x.属性 == AllEnums.洗炼属性Type.出战化形);
			if (洗炼属性缓存列表类6 != null)
			{
				num += 洗炼属性缓存列表类6.数值;
			}
			洗炼属性缓存列表类 洗炼属性缓存列表类7 = myclient.user.背包数据.物品列表[43].洗炼属性列表.Find( (洗炼属性缓存列表类 x) => x.属性 == AllEnums.洗炼属性Type.出战化形);
			if (洗炼属性缓存列表类7 != null)
			{
				num += 洗炼属性缓存列表类7.数值;
			}
			洗炼属性缓存列表类 洗炼属性缓存列表类8 = myclient.user.背包数据.物品列表[44].洗炼属性列表.Find( (洗炼属性缓存列表类 x) => x.属性 == AllEnums.洗炼属性Type.出战化形);
			if (洗炼属性缓存列表类8 != null)
			{
				num += 洗炼属性缓存列表类8.数值;
			}
			return num;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("进入战斗获取化形初值-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return 0;
		}
	}

	
	public void 妖族化形加成处理(MyNATSocketClient myclient, AllEnums.妖族Type 类型, bool 是否化形)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (类型 == AllEnums.妖族Type.无)
			{
				return;
			}
			svcIp9X8sa(myclient, AllEnums.指令Type.release_forgotten, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.release_poison, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.release_frozen, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.release_sleep, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.release_confusion, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.release_repress, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.release_melt, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.release_cage, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.release_lock, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.release_lost, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.resist_shenszg, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.resist_youszs, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.resist_shemyj, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.resist_fanzqk, 是否化形 ? 100 : 0, true);
			svcIp9X8sa(myclient, AllEnums.指令Type.resist_mantxw, 是否化形 ? 100 : 0, true);
			switch (类型)
			{
			case AllEnums.妖族Type.竹熊:
			{
				svcIp9X8sa(myclient, AllEnums.指令Type.phy_absorb, 是否化形 ? (-Singleton<全局变量类>.I.妖族化形配置.竹熊化形增幅) : 0, true);
				svcIp9X8sa(myclient, AllEnums.指令Type.mag_absorb, 是否化形 ? (-Singleton<全局变量类>.I.妖族化形配置.竹熊化形增幅) : 0, true);
				string value2;
				if (!是否化形)
				{
					value2 = "化形状态结束，化形加成失效";
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#Y竹熊化形加成：#G受到所有的伤害消减");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.妖族化形配置.竹熊化形增幅);
					defaultInterpolatedStringHandler.AppendLiteral("%#n。");
					value2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				stringBuilder.Append(value2);
				break;
			}
			case AllEnums.妖族Type.玉兔:
			{
				svcIp9X8sa(myclient, AllEnums.指令Type.attack_effect, 是否化形 ? Singleton<全局变量类>.I.妖族化形配置.玉兔化形增幅 : 0, true);
				string value4;
				if (!是否化形)
				{
					value4 = "化形状态结束，化形加成失效";
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#Y玉兔化形加成：#G法术伤害增加");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.妖族化形配置.玉兔化形增幅);
					defaultInterpolatedStringHandler.AppendLiteral("%。");
					value4 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				stringBuilder.Append(value4);
				break;
			}
			case AllEnums.妖族Type.灵蛇:
			{
				svcIp9X8sa(myclient, AllEnums.指令Type.mag_dodge, 是否化形 ? Singleton<全局变量类>.I.妖族化形配置.灵蛇化形增幅 : 0, true);
				svcIp9X8sa(myclient, AllEnums.指令Type.dodge_effect, 是否化形 ? (Singleton<全局变量类>.I.妖族化形配置.灵蛇化形增幅 * 100) : 0, true);
				string value3;
				if (!是否化形)
				{
					value3 = "化形状态结束，化形加成失效";
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#Y灵蛇化形加成：#G受到攻击和技能时闪避增加");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.妖族化形配置.灵蛇化形增幅);
					defaultInterpolatedStringHandler.AppendLiteral("%#n。");
					value3 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				stringBuilder.Append(value3);
				break;
			}
			case AllEnums.妖族Type.孔雀:
			{
				svcIp9X8sa(myclient, AllEnums.指令Type.attack_effect, 是否化形 ? Singleton<全局变量类>.I.妖族化形配置.孔雀化形增幅 : 0, true);
				string value;
				if (!是否化形)
				{
					value = "化形状态结束，化形加成失效";
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#Y孔雀化形加成：#G物理伤害增加");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.妖族化形配置.孔雀化形增幅);
					defaultInterpolatedStringHandler.AppendLiteral("%#n。");
					value = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				stringBuilder.Append(value);
				break;
			}
			}
			if (myclient.user.缓存数据.is战斗中)
			{
				myclient.C_Send(提示_提醒和杂项公告(stringBuilder.ToString()));
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("妖族化形加成处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public int 取对应化形ID(int 形象ID)
	{
		return 形象ID switch
		{
			4002 => 951704, 
			4005 => 8101, 
			5003 => 8102, 
			5004 => 951702, 
			_ => 0, 
		};
	}

	
	public int 取对应化形特效(int 形象ID, bool 是否友方)
	{
		switch (形象ID)
		{
		case 4002:
			if (!是否友方)
			{
				return 9507;
			}
			return 9507;
		case 4005:
			if (!是否友方)
			{
				return 10751;
			}
			return 10750;
		case 5003:
			if (!是否友方)
			{
				return 9296;
			}
			return 9296;
		case 5004:
			if (!是否友方)
			{
				return 8023;
			}
			return 8023;
		default:
			return 0;
		}
	}

	
	public string 形象ID取技能名(int 形象ID, string 技能名)
	{
		switch (形象ID)
		{
		case 4002:
			if (技能名 == "木遁术")
			{
				return "熊灵遁";
			}
			if (技能名 == "花舞叶飞")
			{
				return "一鼓作气";
			}
			if (技能名 == "扬花飞柳")
			{
				return "战鼓雷鸣";
			}
			if (技能名 == "秋风扫叶")
			{
				return "震耳欲聋";
			}
			if (技能名 == "一叶菩提")
			{
				return "阳关三叠";
			}
			if (技能名 == "天女散花")
			{
				return "惊天动地";
			}
			if (技能名 == "芒刺在背")
			{
				return "激忿填膺";
			}
			if (技能名 == "物腐虫生")
			{
				return "怒意勃发";
			}
			if (技能名 == "毒入骨髓")
			{
				return "怒目金刚";
			}
			if (技能名 == "九死一生")
			{
				return "血怒熊灵";
			}
			if (技能名 == "遮天蔽日")
			{
				return "不怒自威";
			}
			if (技能名 == "甘之如饴")
			{
				return "熊灵怒吼";
			}
			if (技能名 == "春风化雨")
			{
				return "蓄势挑衅";
			}
			if (技能名 == "润物无声")
			{
				return "招风惹草";
			}
			if (技能名 == "醍醐灌顶")
			{
				return "冷嘲热讽";
			}
			if (技能名 == "妙手回春")
			{
				return "众矢之的";
			}
			if (技能名 == "落叶萧萧")
			{
				return "妖熊神咒";
			}
			if (技能名 == "蔓舞飞天")
			{
				return "天妖熊力";
			}
			if (技能名 == "百毒不侵")
			{
				return "妖熊护佑";
			}
			if (技能名 == "剧毒攻心")
			{
				return "妖影无踪";
			}
			break;
		case 4005:
			if (技能名 == "土遁术")
			{
				return "羽翎遁";
			}
			if (技能名 == "土崩瓦解")
			{
				return "旋刃飞空";
			}
			if (技能名 == "尘土飞扬")
			{
				return "疾刃追风";
			}
			if (技能名 == "扬砾飞沙")
			{
				return "穿云破月";
			}
			if (技能名 == "地动山摇")
			{
				return "落羽飞翎";
			}
			if (技能名 == "千岩万壑")
			{
				return "月影惊鸿";
			}
			if (技能名 == "惊惶失措")
			{
				return "飞空连刃";
			}
			if (技能名 == "染神乱志")
			{
				return "追风叠刃";
			}
			if (技能名 == "神魂飘荡")
			{
				return "破月残芒";
			}
			if (技能名 == "神摇意夺")
			{
				return "飞翎疾影";
			}
			if (技能名 == "惊神破胆")
			{
				return "惊鸿裂宇";
			}
			if (技能名 == "虚虚实实")
			{
				return "噬血回元";
			}
			if (技能名 == "故弄玄虚")
			{
				return "落羽回魂";
			}
			if (技能名 == "空幻虚实")
			{
				return "血刃汲魂";
			}
			if (技能名 == "虚空幻影")
			{
				return "浴血还神";
			}
			if (技能名 == "虚无飘渺")
			{
				return "浴血盛宴";
			}
			if (技能名 == "飞沙走石")
			{
				return "妖皇天咒";
			}
			if (技能名 == "开碑裂石")
			{
				return "妖皇神力";
			}
			if (技能名 == "心如磐石")
			{
				return "妖神庇佑";
			}
			if (技能名 == "敌我难分")
			{
				return "妖影迷影";
			}
			break;
		case 5003:
			if (技能名 == "水遁术")
			{
				return "兔灵遁";
			}
			if (技能名 == "水流花谢")
			{
				return "低吟浅唱";
			}
			if (技能名 == "积水成渊")
			{
				return "余音袅袅";
			}
			if (技能名 == "风起水涌")
			{
				return "渔舟唱晚";
			}
			if (技能名 == "雪窑冰天")
			{
				return "响遏行云";
			}
			if (技能名 == "蛟龙得水")
			{
				return "大音希声";
			}
			if (技能名 == "滴水不漏")
			{
				return "乐灵护佑";
			}
			if (技能名 == "深沟壁垒")
			{
				return "镜花乐壁";
			}
			if (技能名 == "积雪封霜")
			{
				return "雾霭仙音";
			}
			if (技能名 == "日月合璧")
			{
				return "仙韵圣咏";
			}
			if (技能名 == "镜花水月")
			{
				return "空谷绝响";
			}
			if (技能名 == "吐故纳新")
			{
				return "真灵护体";
			}
			if (技能名 == "防患未然")
			{
				return "雾语天华";
			}
			if (技能名 == "浑然一体")
			{
				return "云霓咏唱";
			}
			if (技能名 == "雨消云散")
			{
				return "仙音天佑";
			}
			if (技能名 == "水火不侵")
			{
				return "圣心激扬";
			}
			if (技能名 == "水天一色")
			{
				return "妖皇神咒";
			}
			if (技能名 == "铁马冰河")
			{
				return "天妖神力";
			}
			if (技能名 == "霜甲冰盾")
			{
				return "妖神护佑";
			}
			if (技能名 == "雪飘万里")
			{
				return "妖影迷踪";
			}
			break;
		case 5004:
			if (技能名 == "火遁术")
			{
				return "灵蛇遁";
			}
			if (技能名 == "驽箭离弦")
			{
				return "秘术蛇炎";
			}
			if (技能名 == "一箭双雕")
			{
				return "火蛇吐息";
			}
			if (技能名 == "箭不虚发")
			{
				return "烈火蛇涎";
			}
			if (技能名 == "星飞云散")
			{
				return "业火阳炎";
			}
			if (技能名 == "万箭穿心")
			{
				return "烽火连天";
			}
			if (技能名 == "心锁神封")
			{
				return "毒炎蚀骨";
			}
			if (技能名 == "重垣迭锁")
			{
				return "烈焰灭魂";
			}
			if (技能名 == "如封似闭")
			{
				return "疠焰无形";
			}
			if (技能名 == "困灵锁心")
			{
				return "怒火焚心";
			}
			if (技能名 == "云迷雾锁")
			{
				return "幽冥业火";
			}
			if (技能名 == "急如星火")
			{
				return "烈刃毒炎";
			}
			if (技能名 == "星驰电走")
			{
				return "毒刃灼身";
			}
			if (技能名 == "电光石火")
			{
				return "炙阳蚀心";
			}
			if (技能名 == "飞云掣电")
			{
				return "魔焰融金";
			}
			if (技能名 == "虎啸风驰")
			{
				return "业火融魂";
			}
			if (技能名 == "火树银花")
			{
				return "妖蛇神咒";
			}
			if (技能名 == "灰飞烟灭")
			{
				return "天妖蛇力";
			}
			if (技能名 == "三昧炼心")
			{
				return "妖蛇护佑";
			}
			if (技能名 == "离火夺魄")
			{
				return "妖影蛇踪";
			}
			break;
		}
		return 技能名;
	}

	
	public AllEnums.妖族Type 取对应妖族类型(int 形象ID)
	{
		return 形象ID switch
		{
			4002 => AllEnums.妖族Type.竹熊, 
			4005 => AllEnums.妖族Type.孔雀, 
			5003 => AllEnums.妖族Type.玉兔, 
			5004 => AllEnums.妖族Type.灵蛇, 
			_ => AllEnums.妖族Type.无, 
		};
	}

	
	public byte[] 动态设置全局双倍(string 开始时间, string 结束时间, string 最低等级, string 最高等级, string 全局倍率)
	{
		byte[] first = new byte[30]
		{
			35, 20, 23, 97, 100, 109, 105, 110, 95, 111,
			112, 101, 114, 95, 103, 108, 111, 98, 97, 108,
			95, 98, 111, 110, 117, 115, 3, 115, 101, 116
		};
		byte[] array = Singleton<ByteAPI>.I.到字节集(开始时间);
		byte[] array2 = Singleton<ByteAPI>.I.到字节集(结束时间);
		byte[] array3 = Singleton<ByteAPI>.I.到字节集(最低等级);
		byte[] array4 = Singleton<ByteAPI>.I.到字节集(最高等级);
		byte[] array5 = Singleton<ByteAPI>.I.到字节集(全局倍率);
		first = first.Concat(Singleton<ByteAPI>.I.还原字节集(array.Length)).Concat(array).Concat(Singleton<ByteAPI>.I.还原字节集(array2.Length))
			.Concat(array2)
			.Concat(Singleton<ByteAPI>.I.还原字节集(array3.Length))
			.Concat(array3)
			.Concat(Singleton<ByteAPI>.I.还原字节集(array4.Length))
			.Concat(array4)
			.Concat(new byte[4] { 3, 97, 108, 108 })
			.Concat(Singleton<ByteAPI>.I.还原字节集(array5.Length))
			.Concat(array5)
			.Concat(new byte[5] { 1, 48, 0, 1, 49 })
			.ToArray();
		byte[] second = Singleton<ByteAPI>.I.到字节集反转(first.Length, 2);
		return 全局变量类.HeadData.Concat(second).Concat(first).ToArray();
	}

	
	public void 清空玩家相性点(MyNATSocketClient myclient)
	{
		svcIp9X8sa(myclient, AllEnums.指令Type.metal, 0, true);
		svcIp9X8sa(myclient, AllEnums.指令Type.wood, 0, true);
		svcIp9X8sa(myclient, AllEnums.指令Type.water, 0, true);
		svcIp9X8sa(myclient, AllEnums.指令Type.fire, 0, true);
		svcIp9X8sa(myclient, AllEnums.指令Type.earth, 0, true);
		myclient.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#R系统已经清空了你当前的相性点，请切换装备刷新面板！"));
	}

	
	internal void EOYImZQJeG(MyNATSocketClient P_0, bool P_1)
	{
		try
		{
			if (P_0.user.队伍数据.成员列表.Count <= 0)
			{
				P_0.user.缓存数据.is战斗逃跑指令 = P_1;
				return;
			}
			foreach (int item in P_0.user.队伍数据.成员列表)
			{
				MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定角色ID玩家MyClient(item);
				if (myNATSocketClient != null && myNATSocketClient.使用中)
				{
					myNATSocketClient.user.缓存数据.is战斗逃跑指令 = true;
					myNATSocketClient.C_Send(Singleton<WdAPI>.I.提示_中心提醒("【退出战斗】指令已下达，请耐心等待当前战斗回合结束！"));
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("刷新战斗结束状态报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal byte[] u02IPnG1Nm(MyNATSocketClient P_0)
	{
		return new byte[12]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 9,
			17, 86
		}.Concat(Singleton<ByteAPI>.I.到字节集反转(P_0.user.人物数据.角色ID)).Concat(new byte[3] { 0, 39, 15 }).ToArray();
	}

	
	internal byte[] HDvIXkjH6A(MyNATSocketClient P_0)
	{
		return new byte[12]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 9,
			17, 86
		}.Concat(Singleton<ByteAPI>.I.到字节集反转(P_0.user.人物数据.角色ID)).Concat(new byte[3] { 0, 39, 15 }).Concat(new byte[26]
		{
			77, 90, 0, 0, 2, 192, 178, 103, 0, 16,
			48, 202, 0, 0, 0, 1, 8, 181, 192, 190,
			223, 178, 203, 181, 165, 0
		})
			.ToArray();
	}

	
	internal byte[] YRZIFYPBBa(int P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[6] { 48, 202, 0, 0, 0, 1 }, hasCount: false, 0);
		ByteAPI i = Singleton<ByteAPI>.I;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
		defaultInterpolatedStringHandler.AppendLiteral("包裹道具2(");
		defaultInterpolatedStringHandler.AppendFormatted(P_0);
		defaultInterpolatedStringHandler.AppendLiteral(")");
		byte[] array = i.到字节集(defaultInterpolatedStringHandler.ToStringAndClear());
		封包_写2.写字节型(array.Length);
		封包_写2.写字节集(array, hasCount: false, 0);
		封包_写2.写字节集(new byte[1], hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] qFUIL8eDTg(int P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[6] { 48, 202, 0, 0, 0, 1 }, hasCount: false, 0);
		ByteAPI i = Singleton<ByteAPI>.I;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
		defaultInterpolatedStringHandler.AppendLiteral("销毁道具(");
		defaultInterpolatedStringHandler.AppendFormatted(P_0);
		defaultInterpolatedStringHandler.AppendLiteral(")");
		byte[] array = i.到字节集(defaultInterpolatedStringHandler.ToStringAndClear());
		封包_写2.写字节型(array.Length);
		封包_写2.写字节集(array, hasCount: false, 0);
		封包_写2.写字节集(new byte[1], hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] pcxISb1Y8s(int P_0, string P_1, string P_2)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[6] { 16, 66, 0, 0, 0, 1 }, hasCount: false, 0);
		ByteAPI i = Singleton<ByteAPI>.I;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
		defaultInterpolatedStringHandler.AppendLiteral("!更改道具1(");
		defaultInterpolatedStringHandler.AppendFormatted(P_1);
		defaultInterpolatedStringHandler.AppendLiteral(",int,");
		defaultInterpolatedStringHandler.AppendFormatted(P_0);
		defaultInterpolatedStringHandler.AppendLiteral(")");
		byte[] array = i.到字节集(defaultInterpolatedStringHandler.ToStringAndClear());
		封包_写2.写字节型(array.Length);
		封包_写2.写字节集(array, hasCount: false, 0);
		array = Singleton<ByteAPI>.I.到字节集(P_2);
		封包_写2.写字节型(array.Length);
		封包_写2.写字节集(array, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] qkgIc6Hs1J(int P_0, List<string[]> P_1)
	{
		byte[] array = Array.Empty<byte>();
		byte[] first = YRZIFYPBBa(P_0);
		for (int i = 0; i < P_1.Count; i++)
		{
			if (P_1[i].Length == 2)
			{
				封包_写 封包_写2 = new 封包_写();
				封包_写2.写字节集(new byte[6] { 16, 66, 0, 0, 0, 1 }, hasCount: false, 0);
				ByteAPI i2 = Singleton<ByteAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
				defaultInterpolatedStringHandler.AppendLiteral("!更改道具1(");
				defaultInterpolatedStringHandler.AppendFormatted(P_1[i][0]);
				defaultInterpolatedStringHandler.AppendLiteral(",int,");
				defaultInterpolatedStringHandler.AppendFormatted(P_0);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				byte[] array2 = i2.到字节集(defaultInterpolatedStringHandler.ToStringAndClear());
				封包_写2.写字节型(array2.Length);
				封包_写2.写字节集(array2, hasCount: false, 0);
				array2 = Singleton<ByteAPI>.I.到字节集(P_1[i][1]);
				封包_写2.写字节型(array2.Length);
				封包_写2.写字节集(array2, hasCount: false, 0);
				封包_写 封包_写3 = new 封包_写();
				封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
				封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
				array = array.Concat(first.Concat(封包_写3.取数据())).ToArray();
			}
		}
		return array;
	}

	
	internal byte[] eiiIn9Gguk(MyNATSocketClient P_0, string P_1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[17]
		{
			33, 94, 0, 0, 0, 1, 10, 33, 184, 180,
			214, 198, 181, 192, 190, 223, 49
		}, hasCount: false, 0);
		byte[] array = Singleton<ByteAPI>.I.到字节集(P_1);
		封包_写2.写字节型(array.Length);
		封包_写2.写字节集(array, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal void k1vI5WDVju(MyNATSocketClient P_0, List<string> P_1)
	{
		P_0.S_Send(s2dIMSYboj(P_0).Concat(CyNIhuQ5l3(P_0, P_1)).Concat(全局常量类.退出如律令).ToArray());
	}

	
	internal byte[] s2dIMSYboj(MyNATSocketClient P_0)
	{
		return new byte[12]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 9,
			17, 86
		}.Concat(Singleton<ByteAPI>.I.到字节集反转(P_0.user.人物数据.角色ID)).Concat(new byte[3] { 0, 39, 15 }).Concat(new byte[26]
		{
			77, 90, 0, 0, 23, 67, 136, 85, 0, 16,
			16, 66, 0, 0, 0, 1, 8, 202, 253, 190,
			221, 206, 172, 187, 164, 0
		})
			.Concat(new byte[27]
			{
				77, 90, 0, 0, 23, 68, 251, 156, 0, 17,
				16, 66, 0, 0, 0, 1, 9, 200, 206, 206,
				241, 202, 253, 190, 221, 49, 0
			})
			.ToArray();
	}

	
	internal byte[] CyNIhuQ5l3(MyNATSocketClient P_0, List<string> P_1)
	{
		封包_写 封包_写2 = new 封包_写();
		byte[] first = Array.Empty<byte>();
		for (int i = 0; i < P_1.Count; i++)
		{
			封包_写2.清数据();
			封包_写2.写字节集(new byte[6] { 48, 202, 0, 0, 0, 1 }, hasCount: false, 0);
			封包_写2.写文本型("任务数据2(" + P_1[i] + ")", hasCount: true, 0);
			封包_写2.写字节型(0);
			first = first.Concat(组包包头(封包_写2.取数据())).ToArray();
			封包_写2.清数据();
			封包_写2.写字节集(new byte[6] { 48, 202, 0, 0, 0, 1 }, hasCount: false, 0);
			封包_写2.写文本型("删除任务(" + P_1[i] + ")", hasCount: true, 0);
			封包_写2.写字节型(0);
			first = first.Concat(组包包头(封包_写2.取数据())).ToArray();
		}
		return first.Concat(new byte[28]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 18,
			48, 202, 0, 0, 0, 1, 10, 183, 181, 187,
			216, 214, 247, 178, 203, 181, 165, 0
		}).ToArray();
	}

	
	internal byte[] TNUIvv8IeY(MyNATSocketClient P_0, string P_1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 33, 94 }, hasCount: false, 0);
		封包_写2.写字节集(new byte[4] { 0, 0, 0, 1 }, hasCount: false, 0);
		封包_写2.写字节集(new byte[11]
		{
			10, 33, 184, 180, 214, 198, 179, 232, 206, 239,
			49
		}, hasCount: false, 0);
		byte[] array = Singleton<ByteAPI>.I.到字节集(P_1);
		封包_写2.写字节型(array.Length);
		封包_写2.写字节集(array, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] JMrI7BkW0T(MyNATSocketClient P_0, string P_1, int P_2)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 33, 94 }, hasCount: false, 0);
		封包_写2.写字节集(new byte[4] { 0, 0, 0, 1 }, hasCount: false, 0);
		ByteAPI i = Singleton<ByteAPI>.I;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
		defaultInterpolatedStringHandler.AppendLiteral("!^输入宠物等级(");
		defaultInterpolatedStringHandler.AppendFormatted(P_1);
		defaultInterpolatedStringHandler.AppendLiteral(",");
		defaultInterpolatedStringHandler.AppendFormatted(P_2);
		defaultInterpolatedStringHandler.AppendLiteral(")");
		byte[] array = i.到字节集(defaultInterpolatedStringHandler.ToStringAndClear());
		封包_写2.写字节型(array.Length);
		封包_写2.写字节集(array, hasCount: false, 0);
		封包_写2.写字节集(new byte[2] { 1, 49 }, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] T1uIaOho0A(MyNATSocketClient P_0, string P_1, int P_2)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 33, 94 }, hasCount: false, 0);
		封包_写2.写字节集(new byte[4] { 0, 0, 0, 1 }, hasCount: false, 0);
		ByteAPI i = Singleton<ByteAPI>.I;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
		defaultInterpolatedStringHandler.AppendLiteral("复制宠物4(");
		defaultInterpolatedStringHandler.AppendFormatted(P_1);
		defaultInterpolatedStringHandler.AppendLiteral(",");
		defaultInterpolatedStringHandler.AppendFormatted(P_2);
		defaultInterpolatedStringHandler.AppendLiteral(",1,3)");
		byte[] array = i.到字节集(defaultInterpolatedStringHandler.ToStringAndClear());
		封包_写2.写字节型(array.Length);
		封包_写2.写字节集(array, hasCount: false, 0);
		封包_写2.写字节集(new byte[1], hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] mIGITAO4In(MyNATSocketClient P_0, string P_1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 33, 94 }, hasCount: false, 0);
		封包_写2.写字节集(new byte[4] { 0, 0, 0, 1 }, hasCount: false, 0);
		封包_写2.写字节集(new byte[11]
		{
			10, 33, 184, 180, 214, 198, 198, 239, 179, 232,
			49
		}, hasCount: false, 0);
		byte[] array = Singleton<ByteAPI>.I.到字节集(P_1);
		封包_写2.写字节型(array.Length);
		封包_写2.写字节集(array, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] n7wI94j2Ta(MyNATSocketClient P_0, string P_1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 33, 94 }, hasCount: false, 0);
		封包_写2.写字节集(new byte[4] { 0, 0, 0, 1 }, hasCount: false, 0);
		byte[] array = Singleton<ByteAPI>.I.到字节集("!^输入骑宠等级(" + P_1 + ",2)");
		封包_写2.写字节型(array.Length);
		封包_写2.写字节集(array, hasCount: false, 0);
		封包_写2.写字节集(new byte[2] { 1, 49 }, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] R2IIyHk4u2(MyNATSocketClient P_0, string P_1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 33, 94 }, hasCount: false, 0);
		封包_写2.写字节集(new byte[4] { 0, 0, 0, 1 }, hasCount: false, 0);
		byte[] array = Singleton<ByteAPI>.I.到字节集("复制骑宠4(" + P_1 + ",2,1,3)");
		封包_写2.写字节型(array.Length);
		封包_写2.写字节集(array, hasCount: false, 0);
		封包_写2.写字节集(new byte[1], hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal void Mr8ICwW3qX(MyNATSocketClient P_0, int P_1, string P_2, string P_3)
	{
		byte[] buffer = HDvIXkjH6A(P_0).Concat(全局常量类.净心决_包裹道具).Concat(YRZIFYPBBa(P_1)).Concat(pcxISb1Y8s(P_1, P_2, P_3))
			.Concat(全局常量类.退出如律令)
			.ToArray();
		P_0.S_Send(buffer);
	}

	
	internal void NNfIVUuyWv(MyNATSocketClient P_0, int P_1, List<string[]> P_2)
	{
		byte[] buffer = HDvIXkjH6A(P_0).Concat(全局常量类.净心决_包裹道具).Concat(qkgIc6Hs1J(P_1, P_2)).Concat(全局常量类.退出如律令)
			.ToArray();
		P_0.S_Send(buffer);
	}

	
	internal void iaDIkvl1cj(MyNATSocketClient P_0, int P_1)
	{
		byte[] buffer = HDvIXkjH6A(P_0).Concat(全局常量类.净心决_包裹道具).Concat(YRZIFYPBBa(P_1)).Concat(qFUIL8eDTg(P_1))
			.Concat(全局常量类.退出如律令)
			.ToArray();
		P_0.S_Send(buffer);
	}

	
	internal byte[] CxWI0uMCPh(MyNATSocketClient P_0, int P_1)
	{
		return HDvIXkjH6A(P_0).Concat(全局常量类.净心决_包裹道具).Concat(YRZIFYPBBa(P_1)).Concat(qFUIL8eDTg(P_1))
			.Concat(全局常量类.退出如律令)
			.ToArray();
	}

	
	internal byte[] DN4IOFDdr5(MyNATSocketClient P_0, int[] P_1)
	{
		byte[] first = HDvIXkjH6A(P_0).Concat(全局常量类.净心决_包裹道具).ToArray();
		for (int i = 0; i < P_1.Length; i++)
		{
			first = first.Concat(YRZIFYPBBa(P_1[i])).Concat(qFUIL8eDTg(P_1[i])).ToArray();
		}
		return first.Concat(全局常量类.退出如律令).ToArray();
	}

	
	internal byte[] sH3IQ5eetN(MyNATSocketClient P_0, int P_1, int P_2)
	{
		byte[] first = HDvIXkjH6A(P_0).Concat(全局常量类.净心决_包裹道具).ToArray();
		for (int i = P_1; i <= P_2; i++)
		{
			first = first.Concat(YRZIFYPBBa(i)).Concat(qFUIL8eDTg(i)).ToArray();
		}
		return first.Concat(全局常量类.退出如律令).ToArray();
	}

	
	internal void OhAIEJ4cvw(MyNATSocketClient P_0, string P_1, int P_2 = 1)
	{
		P_0.S_Send(HDvIXkjH6A(P_0));
		P_2--;
		byte[] array = eiiIn9Gguk(P_0, P_1);
		if (P_2 > 0)
		{
			int num = 0;
			while (P_2 > 0)
			{
				if (P_2 >= 99)
				{
					P_2 -= 99;
					num = 99;
				}
				else
				{
					num = P_2;
					P_2 = 0;
				}
				封包_写 封包_写2 = new 封包_写();
				封包_写2.写字节集(new byte[6] { 16, 66, 0, 0, 0, 1 }, hasCount: false, 0);
				ByteAPI i = Singleton<ByteAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 2);
				defaultInterpolatedStringHandler.AppendLiteral("复制道具1(");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("x");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				byte[] array2 = i.到字节集(defaultInterpolatedStringHandler.ToStringAndClear());
				封包_写2.写字节型(array2.Length);
				封包_写2.写字节集(array2, hasCount: false, 0);
				封包_写2.写字节集(new byte[1], hasCount: false, 0);
				封包_写 封包_写3 = new 封包_写();
				封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
				封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
				array = array.Concat(封包_写3.取数据()).ToArray();
			}
		}
		P_0.S_Send(array);
		P_0.S_Send(全局常量类.退出如律令);
	}

	
	internal void lvuI30yCQE(MyNATSocketClient P_0, string P_1, string P_2, string P_3, string P_4, string P_5 = "admin_set_attrib")
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2314"), hasCount: false, 0);
		封包_写2.写文本型(P_5, hasCount: true, 0);
		封包_写2.写文本型(P_1, hasCount: true, 0, reverse: true);
		封包_写2.写文本型(P_2, hasCount: true, 0, reverse: true);
		封包_写2.写文本型(P_3, hasCount: true, 0, reverse: true);
		封包_写2.写文本型(P_4, hasCount: true, 0, reverse: true);
		封包_写 封包_写3 = new 封包_写();
		封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
		封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		P_0.S_Send(封包_写3.取数据());
	}

	
	internal byte[] mgVIYoDksB(string P_0, string P_1, string P_2, string P_3, string P_4 = "admin_set_attrib")
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2314"), hasCount: false, 0);
		封包_写2.写文本型(P_4, hasCount: true, 0);
		封包_写2.写文本型(P_0, hasCount: true, 0, reverse: true);
		封包_写2.写文本型(P_1, hasCount: true, 0, reverse: true);
		封包_写2.写文本型(P_2, hasCount: true, 0, reverse: true);
		封包_写2.写文本型(P_3, hasCount: true, 0, reverse: true);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	private void svcIp9X8sa(MyNATSocketClient P_0, AllEnums.指令Type P_1, int P_2, bool P_3 = false)
	{
		try
		{
			if (P_0.当前权限 == 0)
			{
				Log.Error("账号信息异常");
			}
			else if (P_1 == AllEnums.指令Type.all_polar)
			{
				for (int i = 24; i <= 28; i++)
				{
					int num = oBhIqdUB4x(P_0, (AllEnums.指令Type)i, P_2);
					封包_写 封包_写2 = new 封包_写();
					封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2314"), hasCount: false, 0);
					封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("1061646D696E5F7365745F617474726962"), hasCount: false, 0);
					封包_写2.写文本型(P_0.user.人物数据.昵称, hasCount: true, 0, reverse: true);
					封包_写2.写文本型(P_0.user.人物数据.角色ID.ToString(), hasCount: true, 0, reverse: true);
					封包_写2.写文本型($"{(AllEnums.指令Type)i}", hasCount: true, 0, reverse: true);
					封包_写2.写文本型(num.ToString(), hasCount: true, 0, reverse: true);
					封包_写 封包_写3 = new 封包_写();
					封包_写3.写字节集(全局变量类.问道头, hasCount: false, 0);
					封包_写3.写整数型(Singleton<ByteAPI>.I.取启动时间(), reverse: true);
					封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
					P_0.S_Send(封包_写3.取数据());
				}
			}
			else
			{
				int num2 = oBhIqdUB4x(P_0, P_1, P_2, P_3);
				封包_写 封包_写4 = new 封包_写();
				封包_写4.写字节集(Singleton<ByteAPI>.I.HtoC("2314"), hasCount: false, 0);
				封包_写4.写字节集(Singleton<ByteAPI>.I.HtoC("1061646D696E5F7365745F617474726962"), hasCount: false, 0);
				封包_写4.写文本型(P_0.user.人物数据.昵称, hasCount: true, 0, reverse: true);
				封包_写4.写文本型(P_0.user.人物数据.角色ID.ToString(), hasCount: true, 0, reverse: true);
				封包_写4.写文本型(P_1.ToString(), hasCount: true, 0, reverse: true);
				封包_写4.写文本型(num2.ToString(), hasCount: true, 0, reverse: true);
				封包_写 封包_写5 = new 封包_写();
				封包_写5.写字节集(全局变量类.HeadData, hasCount: false, 0);
				封包_写5.写入数据(封包_写4.取数据(), hasCount: true, 1, reverse: true);
				P_0.S_Send(封包_写5.取数据());
				if (!P_3 && (P_1 == AllEnums.指令Type.cash || (P_1 == AllEnums.指令Type.tao && Math.Abs(P_2) <= 6000) || P_1 == AllEnums.指令Type.exp || P_1 == AllEnums.指令Type.reputation || P_1 == AllEnums.指令Type.total_score || P_1 == AllEnums.指令Type.voucher))
				{
					Ej2IeJLI07(P_0, P_1.ToString(), P_2);
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("调整属性封包报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void W9lI1TZlUs(MyNATSocketClient P_0, string P_1, string P_2, string P_3, string P_4)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2314"), hasCount: false, 0);
		封包_写2.写文本型("admin_set_skill", hasCount: true, 0);
		封包_写2.写文本型(P_1, hasCount: true, 0);
		封包_写2.写文本型(P_2, hasCount: true, 0);
		封包_写2.写文本型(P_3, hasCount: true, 0);
		封包_写2.写文本型(P_4, hasCount: true, 0);
		封包_写 封包_写3 = new 封包_写();
		封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
		封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		P_0.S_Send(封包_写3.取数据());
	}

	
	internal void f5oIxL5Jqw(MyNATSocketClient P_0, string P_1, string P_2, List<string[]> P_3)
	{
		byte[] array = Array.Empty<byte>();
		封包_写 封包_写2 = new 封包_写();
		for (int i = 0; i < P_3.Count; i++)
		{
			封包_写2.清数据();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2314"), hasCount: false, 0);
			封包_写2.写文本型("admin_set_skill", hasCount: true, 0);
			封包_写2.写文本型(P_1, hasCount: true, 0);
			封包_写2.写文本型(P_2, hasCount: true, 0);
			封包_写2.写文本型(P_3[i][0], hasCount: true, 0);
			封包_写2.写文本型(P_3[i][1], hasCount: true, 0);
			array = array.Concat(组包包头(封包_写2.取数据())).ToArray();
		}
		P_0.S_Send(array);
	}

	
	internal void WT9IHmFS6c(MyNATSocketClient P_0, string P_1, bool P_2 = false)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 35, 20 }, hasCount: false, 0);
		封包_写2.写字节集(new byte[14]
		{
			13, 97, 100, 109, 105, 110, 95, 107, 105, 99,
			107, 111, 102, 102
		}, hasCount: false, 0);
		封包_写2.写文本型(P_1, hasCount: true, 0);
		P_0.S_Send(P_2 ? zXxoPwQcb0(P_1).Concat(组包包头(封包_写2.取数据())).ToArray() : 组包包头(封包_写2.取数据()));
	}

	
	internal byte[] lexI4Im4MS(string P_0, bool P_1 = false)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 35, 20 }, hasCount: false, 0);
		封包_写2.写字节集(new byte[14]
		{
			13, 97, 100, 109, 105, 110, 95, 107, 105, 99,
			107, 111, 102, 102
		}, hasCount: false, 0);
		封包_写2.写文本型(P_0, hasCount: true, 0);
		if (!P_1)
		{
			return 组包包头(封包_写2.取数据());
		}
		return zXxoPwQcb0(P_0).Concat(组包包头(封包_写2.取数据())).ToArray();
	}

	
	internal async Task GM_安全下线(string 玩家昵称)
	{
		_003C_003Ec__DisplayClass41_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass41_0();
		CS_0024_003C_003E8__locals3.F377MZ70Nw = 玩家昵称;
		try
		{
			MyNATSocketClient myNATSocketClient = Singleton<全局变量类>.I.会话Dict.Values.Where( (MyNATSocketClient x) => x.user.人物数据.昵称 == CS_0024_003C_003E8__locals3.F377MZ70Nw).FirstOrDefault();
			if (myNATSocketClient != null)
			{
				await myNATSocketClient.S_Send异步(lexI4Im4MS(CS_0024_003C_003E8__locals3.F377MZ70Nw), "GM_安全下线");
			}
		}
		catch (Exception ex)
		{
			Log.Error("下线报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void Ej2IeJLI07(MyNATSocketClient P_0, string P_1, int P_2)
	{
		try
		{
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(new byte[2] { 96, 1 }, hasCount: false, 0);
			封包_写2.写文本型(P_1, hasCount: true, 0, reverse: true);
			封包_写2.写整数型(P_2, reverse: true);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			P_0.C_Send(封包_写3.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("调整属性提示报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private int oBhIqdUB4x(MyNATSocketClient P_0, AllEnums.指令Type P_1, int P_2, bool P_3 = false)
	{
		switch (P_1)
		{
		case AllEnums.指令Type.level:
			P_2 = ((!P_3) ? (P_0.user.属性数据.等级 + P_2) : P_2);
			P_0.user.属性数据.等级 = ((P_2 >= 0) ? ((P_2 > 30000) ? 30000 : P_2) : 0);
			return P_0.user.属性数据.等级;
		case AllEnums.指令Type.tao:
			P_2 = ((!P_3) ? (P_0.user.属性数据.道行 + P_2) : P_2);
			P_0.user.属性数据.道行 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.道行;
		case AllEnums.指令Type.pot:
			P_2 = ((!P_3) ? (P_0.user.属性数据.潜能 + P_2) : P_2);
			P_0.user.属性数据.潜能 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.潜能;
		case AllEnums.指令Type.exp:
			P_2 = ((!P_3) ? (P_0.user.属性数据.经验 + P_2) : P_2);
			P_0.user.属性数据.经验 = ((P_2 > 2000000000) ? 2000000000 : P_2);
			return P_0.user.属性数据.经验;
		case AllEnums.指令Type.reputation:
			P_2 = ((!P_3) ? (P_0.user.属性数据.声望 + P_2) : P_2);
			P_0.user.属性数据.声望 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.声望;
		case AllEnums.指令Type.total_score:
			P_2 = ((!P_3) ? (P_0.user.属性数据.战绩 + P_2) : P_2);
			P_0.user.属性数据.战绩 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.战绩;
		case AllEnums.指令Type.stamina:
			P_2 = ((!P_3) ? (P_0.user.属性数据.当前体力 + P_2) : P_2);
			P_0.user.属性数据.当前体力 = ((P_2 >= 0) ? ((P_2 > 30000) ? 30000 : P_2) : 0);
			return P_0.user.属性数据.当前体力;
		case AllEnums.指令Type.max_stamina:
			P_2 = ((!P_3) ? (P_0.user.属性数据.最大体力 + P_2) : P_2);
			P_0.user.属性数据.最大体力 = ((P_2 >= 0) ? ((P_2 > 30000) ? 30000 : P_2) : 0);
			return P_0.user.属性数据.最大体力;
		case AllEnums.指令Type.total_pk:
			P_2 = ((!P_3) ? (P_0.user.属性数据.PK值 + P_2) : P_2);
			P_0.user.属性数据.PK值 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.PK值;
		case AllEnums.指令Type.cash:
			P_2 = ((!P_3) ? (P_0.user.背包数据.金钱 + P_2) : P_2);
			P_0.user.背包数据.金钱 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.背包数据.金钱;
		case AllEnums.指令Type.voucher:
			P_2 = ((!P_3) ? (P_0.user.背包数据.代金券 + P_2) : P_2);
			P_0.user.背包数据.代金券 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.背包数据.代金券;
		case AllEnums.指令Type.life:
			P_2 = ((!P_3) ? (P_0.user.属性数据.当前气血 + P_2) : P_2);
			P_0.user.属性数据.当前气血 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.当前气血;
		case AllEnums.指令Type.max_life:
			P_2 = ((!P_3) ? (P_0.user.属性数据.最大气血 + P_2) : P_2);
			P_0.user.属性数据.最大气血 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.最大气血;
		case AllEnums.指令Type.mana:
			P_2 = ((!P_3) ? (P_0.user.属性数据.当前法力 + P_2) : P_2);
			P_0.user.属性数据.当前法力 = ((P_2 >= 0) ? ((P_2 > P_0.user.属性数据.最大法力) ? P_0.user.属性数据.最大气血 : P_2) : 0);
			return P_0.user.属性数据.当前法力;
		case AllEnums.指令Type.max_mana:
			P_2 = ((!P_3) ? (P_0.user.属性数据.最大法力 + P_2) : P_2);
			P_0.user.属性数据.最大法力 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.最大法力;
		case AllEnums.指令Type.upgrade_immortal:
			P_2 = ((!P_3) ? (P_0.user.属性数据.仙道点 + P_2) : P_2);
			P_0.user.属性数据.仙道点 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.仙道点;
		case AllEnums.指令Type.upgrade_magic:
			P_2 = ((!P_3) ? (P_0.user.属性数据.魔道点 + P_2) : P_2);
			P_0.user.属性数据.魔道点 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.魔道点;
		case AllEnums.指令Type.accurate:
			P_2 = ((!P_3) ? (P_0.user.属性数据.准确 + P_2) : P_2);
			P_0.user.属性数据.准确 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.准确;
		case AllEnums.指令Type.parry:
			P_2 = ((!P_3) ? (P_0.user.属性数据.闪避 + P_2) : P_2);
			P_0.user.属性数据.闪避 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.闪避;
		case AllEnums.指令Type.counter_attack:
			P_2 = ((!P_3) ? (P_0.user.属性数据.反击数 + P_2) : P_2);
			P_0.user.属性数据.反击数 = (short)((P_2 >= 0) ? ((P_2 > 12) ? 12 : P_2) : 0);
			return P_0.user.属性数据.反击数;
		case AllEnums.指令Type.stunt_rate:
			P_2 = ((!P_3) ? (P_0.user.属性数据.必杀率 + P_2) : P_2);
			P_0.user.属性数据.必杀率 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.必杀率;
		case AllEnums.指令Type.nice:
			P_2 = ((!P_3) ? (P_0.user.属性数据.好心值 + P_2) : P_2);
			P_0.user.属性数据.好心值 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.好心值;
		case AllEnums.指令Type.attack_effect:
			P_2 = ((!P_3) ? (P_0.user.属性数据.攻击效果 + P_2) : P_2);
			P_0.user.属性数据.攻击效果 = (short)((P_2 > 32767) ? 32767 : P_2);
			return P_0.user.属性数据.攻击效果;
		case AllEnums.指令Type.phy_absorb:
			P_2 = ((!P_3) ? (P_0.user.属性数据.抗物理 + P_2) : P_2);
			P_0.user.属性数据.抗物理 = (short)((P_2 > 32767) ? 32767 : P_2);
			return P_0.user.属性数据.抗物理;
		case AllEnums.指令Type.mag_absorb:
			P_2 = ((!P_3) ? (P_0.user.属性数据.抗法术 + P_2) : P_2);
			P_0.user.属性数据.抗法术 = (short)((P_2 > 32767) ? 32767 : P_2);
			return P_0.user.属性数据.抗法术;
		case AllEnums.指令Type.phy_power:
			P_2 = ((!P_3) ? (P_0.user.属性数据.当前物攻 + P_2) : P_2);
			P_0.user.属性数据.当前物攻 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.当前物攻;
		case AllEnums.指令Type.mag_power:
			P_2 = ((!P_3) ? (P_0.user.属性数据.当前法攻 + P_2) : P_2);
			P_0.user.属性数据.当前法攻 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.当前法攻;
		case AllEnums.指令Type.def:
			P_2 = ((!P_3) ? (P_0.user.属性数据.当前防御 + P_2) : P_2);
			P_0.user.属性数据.当前防御 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.当前防御;
		case AllEnums.指令Type.speed:
			P_2 = ((!P_3) ? (P_0.user.属性数据.当前速度 + P_2) : P_2);
			P_0.user.属性数据.当前速度 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.当前速度;
		case AllEnums.指令Type.resist_metal:
			P_2 = ((!P_3) ? (P_0.user.属性数据.金抗性 + P_2) : P_2);
			P_0.user.属性数据.金抗性 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.金抗性;
		case AllEnums.指令Type.resist_wood:
			P_2 = ((!P_3) ? (P_0.user.属性数据.木抗性 + P_2) : P_2);
			P_0.user.属性数据.木抗性 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.木抗性;
		case AllEnums.指令Type.resist_water:
			P_2 = ((!P_3) ? (P_0.user.属性数据.水抗性 + P_2) : P_2);
			P_0.user.属性数据.水抗性 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.水抗性;
		case AllEnums.指令Type.resist_fire:
			P_2 = ((!P_3) ? (P_0.user.属性数据.火抗性 + P_2) : P_2);
			P_0.user.属性数据.火抗性 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.火抗性;
		case AllEnums.指令Type.resist_earth:
			P_2 = ((!P_3) ? (P_0.user.属性数据.土抗性 + P_2) : P_2);
			P_0.user.属性数据.土抗性 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.土抗性;
		case AllEnums.指令Type.penetrate:
			P_2 = ((!P_3) ? (P_0.user.属性数据.破防 + P_2) : P_2);
			P_0.user.属性数据.破防 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.破防;
		case AllEnums.指令Type.double_hit:
			P_2 = ((!P_3) ? (P_0.user.属性数据.连击数 + P_2) : P_2);
			P_0.user.属性数据.连击数 = (short)((P_2 >= 0) ? ((P_2 > 12) ? 12 : P_2) : 0);
			return P_0.user.属性数据.连击数;
		case AllEnums.指令Type.double_hit_rate:
			P_2 = ((!P_3) ? (P_0.user.属性数据.连击率 + P_2) : P_2);
			P_0.user.属性数据.连击率 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.连击率;
		case AllEnums.指令Type.stunt:
			P_2 = ((!P_3) ? (P_0.user.属性数据.必杀率 + P_2) : P_2);
			P_0.user.属性数据.必杀率 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.必杀率;
		case AllEnums.指令Type.counter_attack_rate:
			P_2 = ((!P_3) ? (P_0.user.属性数据.反击率 + P_2) : P_2);
			P_0.user.属性数据.反击率 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.反击率;
		case AllEnums.指令Type.damage_sel:
			P_2 = ((!P_3) ? (P_0.user.属性数据.反震度 + P_2) : P_2);
			P_0.user.属性数据.反震度 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.反震度;
		case AllEnums.指令Type.damage_sel_rate:
			P_2 = ((!P_3) ? (P_0.user.属性数据.反震率 + P_2) : P_2);
			P_0.user.属性数据.反震率 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.反震率;
		case AllEnums.指令Type.metal:
			P_2 = ((!P_3) ? (P_0.user.属性数据.金相性值 + P_2) : P_2);
			P_0.user.属性数据.金相性值 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.金相性值;
		case AllEnums.指令Type.wood:
			P_2 = ((!P_3) ? (P_0.user.属性数据.木相性值 + P_2) : P_2);
			P_0.user.属性数据.木相性值 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.木相性值;
		case AllEnums.指令Type.water:
			P_2 = ((!P_3) ? (P_0.user.属性数据.水相性值 + P_2) : P_2);
			P_0.user.属性数据.水相性值 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.水相性值;
		case AllEnums.指令Type.fire:
			P_2 = ((!P_3) ? (P_0.user.属性数据.火相性值 + P_2) : P_2);
			P_0.user.属性数据.火相性值 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.火相性值;
		case AllEnums.指令Type.earth:
			P_2 = ((!P_3) ? (P_0.user.属性数据.土相性值 + P_2) : P_2);
			P_0.user.属性数据.土相性值 = (short)((P_2 >= 0) ? ((P_2 > 32767) ? 32767 : P_2) : 0);
			return P_0.user.属性数据.土相性值;
		case AllEnums.指令Type.wudao_rep:
			P_2 = ((!P_3) ? (P_0.user.属性数据.修为值 + P_2) : P_2);
			P_0.user.属性数据.修为值 = ((P_2 >= 0) ? ((P_2 > 2000000000) ? 2000000000 : P_2) : 0);
			return P_0.user.属性数据.修为值;
		default:
			return P_2;
		}
	}

	
	internal byte[] T0cIrKQx15(byte[] P_0, int P_1)
	{
		try
		{
			byte[] array = new byte[2] { 34, 120 }.Concat(Singleton<ByteAPI>.I.还原字节集(P_0.Length)).Concat(P_0).ToArray();
			return Singleton<ByteAPI>.I.AddByte(全局变量类.HeadData, Singleton<ByteAPI>.I.到字节集(array.Length), array, 全局变量类.HeadData, new byte[4] { 0, 12, 48, 202 }, Singleton<ByteAPI>.I.到字节集固定反转(P_1), new byte[6] { 4, 200, 183, 182, 168, 0 });
		}
		catch (Exception ex)
		{
			Log.Error("GM拉到身边报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal void xfMIZbTlE0(MyNATSocketClient P_0, int P_1)
	{
		try
		{
			if (P_0.使用中)
			{
				P_0.S_Send(Singleton<ByteAPI>.I.AddByte(全局变量类.HeadData, new byte[4] { 0, 8, 253, 66 }, Singleton<ByteAPI>.I.到字节集固定反转(P_1), new byte[2]));
			}
		}
		catch (Exception ex)
		{
			Log.Error("GM强制切磋报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal byte[] N0fItllKg2(byte[] P_0, int P_1, int P_2, int P_3)
	{
		return new byte[12]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 15,
			57, 241
		}.Concat(Singleton<ByteAPI>.I.到字节集固定反转(P_1)).Concat(new byte[2] { 0, 1 }).Concat(P_0)
			.Concat(Singleton<ByteAPI>.I.还原字节集(P_2))
			.Concat(Singleton<ByteAPI>.I.到字节集固定反转(P_3))
			.ToArray();
	}

	
	public byte[] 换线_中心提醒(string 提示内容)
	{
		if (string.IsNullOrWhiteSpace(提示内容))
		{
			return null;
		}
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[4] { 32, 213, 0, 0 }, hasCount: false, 0);
		封包_写2.写文本型(提示内容, hasCount: true, 0);
		return 组包包头(封包_写2.取数据());
	}

	
	public byte[] 提示_中心提醒(string 提示内容)
	{
		if (string.IsNullOrWhiteSpace(提示内容))
		{
			return null;
		}
		封包_写 封包_写2 = new 封包_写();
		封包_写 封包_写3 = new 封包_写();
		封包_写2.Write(Singleton<ByteAPI>.I.HtoC(8165));
		封包_写2.写文本型(提示内容, hasCount: true, 1, reverse: true);
		封包_写2.Write(new byte[2] { 0, 0 });
		封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
		封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return 封包_写3.ToArray();
	}

	
	public byte[] 提示_杂项公告(string 提示内容)
	{
		if (string.IsNullOrWhiteSpace(提示内容))
		{
			return null;
		}
		封包_写 封包_写2 = new 封包_写();
		封包_写 封包_写3 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0B0D"), hasCount: false, 0);
		封包_写2.写字节集(new byte[6], hasCount: false, 0);
		封包_写2.写文本型(提示内容, hasCount: true, 1, reverse: true);
		封包_写2.写文本型(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000CB7E7D4C6D4D9C6F0D2BBCFDF0003"), hasCount: false, 0);
		封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
		封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return 封包_写3.ToArray();
	}

	
	public byte[] 提示_提醒和杂项公告(string 提示内容)
	{
		return 提示_中心提醒(提示内容).Concat(提示_杂项公告(提示内容)).ToArray();
	}

	
	public byte[] 提示_提醒和杂项公告(string 提示内容, string 杂项内容)
	{
		return 提示_中心提醒(提示内容).Concat(提示_杂项公告(杂项内容)).ToArray();
	}

	
	public byte[] 组包邮件南极次数(MyNATSocketClient myclient)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(60, 1);
		defaultInterpolatedStringHandler.AppendLiteral("你有关于#R充值送抽奖活动#n共计#Y[");
		defaultInterpolatedStringHandler.AppendFormatted(myclient.user.存档数据.南极抽奖次数);
		defaultInterpolatedStringHandler.AppendLiteral("]#n次抽奖次数尚未抽取，请及时前往#Z天墉城#Z的#P南极仙翁#P处进行抽奖。");
		string zone = defaultInterpolatedStringHandler.ToStringAndClear();
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[9] { 63, 255, 0, 9, 0, 0, 0, 0, 0 }, hasCount: false, 0);
		封包_写2.写文本型(zone, hasCount: true, 1, reverse: true);
		封包_写2.写文本型(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), hasCount: true, 0, reverse: true);
		封包_写2.写字节集(new byte[2], hasCount: false, 0);
		封包_写2.写文本型(Singleton<全局变量类>.I.全_本区区名 + "一线", hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("000300000050"), hasCount: false, 0);
		封包_写2.写文本型(myclient.user.人物数据.昵称, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000000000000000000100010000000000"), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public byte[] 组包包头(byte[] Buffer)
	{
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(Buffer, hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] jyLIAFgHTA(MyNATSocketClient P_0, string P_1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("3FFF00090000000000"), hasCount: false, 0);
		封包_写2.写文本型(P_1, hasCount: true, 1, reverse: true);
		封包_写2.写文本型(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000"), hasCount: false, 0);
		封包_写2.写文本型(Singleton<全局变量类>.I.全_本区区名 + "一线", hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("000300000050"), hasCount: false, 0);
		封包_写2.写文本型(P_0.user.人物数据.昵称, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000000000000000000100010000000000"), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] O8qIzajjvj(string P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("33930912323032323031323131383335343430303030"), hasCount: false, 0);
		封包_写2.写文本型(P_0, hasCount: true, 1, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000600800002"), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] PWRouuXjmn(string P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("11E7"), hasCount: false, 0);
		封包_写2.写文本型(P_0, hasCount: true, 0);
		封包_写2.写整数型((int)(Singleton<ByteAPI>.I.取时间戳() + ((P_0.Length / 2 > 30) ? 30 : 15)), reverse: true);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] o5iowqAXwm(string P_0, string P_1 = "")
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("33930A12323032323033323531343031313330323131"), hasCount: false, 0);
		封包_写2.写文本型(string.IsNullOrWhiteSpace(P_1) ? "#Y" : ("#Y" + P_1 + "#n在："), hasCount: true, 1, reverse: true);
		封包_写2.写文本型(P_0, hasCount: true, 1, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000001200800000"), hasCount: false, 0);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("163A36323344353934373031434230313342324333413A"), hasCount: false, 0);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0CBAC0BBAABAECB0FCC0F1BBA8"), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public byte[] 组包元宝刷新(int 角色ID, int 金元宝, int 银元宝)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("39F1"), hasCount: false, 0);
		封包_写2.写整数型(角色ID, reverse: true);
		封包_写2.写短整数型(2, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("007703"), hasCount: false, 0);
		封包_写2.写整数型(银元宝, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("007803"), hasCount: false, 0);
		封包_写2.写整数型(金元宝, reverse: true);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public byte[] 对话生成_NPC(int NPCID, int NPC形象, string NPC名称, string 对话文本)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2037"), hasCount: false, 0);
		封包_写2.写整数型(NPCID, reverse: true);
		封包_写2.写整数型(NPC形象, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0001"), hasCount: false, 0);
		封包_写2.写文本型(对话文本, hasCount: true, 1, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
		封包_写2.写文本型(NPC名称, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000001000"), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public byte[] 对话生成_自己(MyNATSocketClient myclient, string 对话文本)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2037"), hasCount: false, 0);
		封包_写2.写整数型(myclient.user.人物数据.角色ID, reverse: true);
		封包_写2.写整数型(myclient.user.人物数据.形象ID, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0001"), hasCount: false, 0);
		封包_写2.写文本型(对话文本, hasCount: true, 1, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
		封包_写2.写文本型(myclient.user.人物数据.昵称, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000001000"), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public byte[] 对话窗口_取消(int 角色ID)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[12]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 10,
			253, 160
		}, hasCount: false, 0);
		封包_写2.写整数型(角色ID, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000000"), hasCount: false, 0);
		return 封包_写2.取数据();
	}

	
	public byte[] 组包谣言刷新(string 内容)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("3fff00060000000000"), hasCount: false, 0);
		封包_写2.写文本型(内容, hasCount: true, 1, reverse: true);
		封包_写2.写文本型(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), hasCount: true, 1, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000"), hasCount: false, 0);
		封包_写2.写文本型(Singleton<全局变量类>.I.全_本区区名 ?? "", hasCount: true, 1, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0003"), hasCount: false, 0);
		封包_写2.写整数型(内容.Length, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
		封包_写2.写文本型("", hasCount: true, 1, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("000000000000000000000000000000000000000000000000000000000000000000000000000000"), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public byte[] 组包聊天信息(string 内容, string 发送方 = "管理员", AllEnums.频道Type 频道 = AllEnums.频道Type.谣言)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("3FFF"), hasCount: false, 0);
		if (频道 == AllEnums.频道Type.问道 || 频道 == AllEnums.频道Type.问道维护 || 频道 == AllEnums.频道Type.问道活动)
		{
			封包_写2.写短整数型(7, reverse: true);
		}
		else
		{
			封包_写2.写短整数型((short)频道, reverse: true);
		}
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
		封包_写2.写文本型(发送方, hasCount: true, 0, reverse: true);
		封包_写2.写文本型(内容, hasCount: true, 1, reverse: true);
		封包_写2.写文本型(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), hasCount: true, 0, reverse: true);
		switch (频道)
		{
		case AllEnums.频道Type.问道:
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("000008CECAB5C0D2BBC7F800030000000C00000000000000000200840001000100000000000000000100"), hasCount: false, 0);
			break;
		case AllEnums.频道Type.问道维护:
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("000008CECAB5C0D2BBC7F800030000000C00000000000000000300840001000100000000000000000100"), hasCount: false, 0);
			break;
		case AllEnums.频道Type.问道活动:
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("000008CECAB5C0D2BBC7F800030000000C00000000000000000400840001000100000000000000000100"), hasCount: false, 0);
			break;
		default:
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("000008CECAB5C0D2BBC7F800030000000C00000000000000000000840001000100000000000000000100"), hasCount: false, 0);
			break;
		}
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public byte[] 组包输入框(string 内容, bool 是否数字 = false)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("39E3000200"), hasCount: false, 0);
		封包_写2.写文本型((是否数字 ? "^" : string.Empty) + "#prompt:" + 内容, hasCount: true, 1, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000"), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public byte[] 组包输入数字框(MyNATSocketClient myclient, string 执行关键词, string 内容, int 最大数量, int 默认数量 = 1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写短整数型(8247, reverse: true);
		封包_写2.写整数型(myclient.user.人物数据.角色ID, reverse: true);
		封包_写2.写整数型(myclient.user.人物数据.形象ID, reverse: true);
		封包_写2.写短整数型(1, reverse: true);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 4);
		defaultInterpolatedStringHandler.AppendLiteral("[@批量使用/");
		defaultInterpolatedStringHandler.AppendFormatted(执行关键词);
		defaultInterpolatedStringHandler.AppendLiteral("#prompt:");
		defaultInterpolatedStringHandler.AppendFormatted(内容);
		defaultInterpolatedStringHandler.AppendLiteral("#MAX:");
		defaultInterpolatedStringHandler.AppendFormatted(最大数量);
		defaultInterpolatedStringHandler.AppendLiteral("#TEXT:");
		defaultInterpolatedStringHandler.AppendFormatted(默认数量);
		defaultInterpolatedStringHandler.AppendLiteral("]");
		封包_写2.写文本型(defaultInterpolatedStringHandler.ToStringAndClear(), hasCount: true, 1, reverse: true);
		封包_写2.写整数型(0, reverse: true);
		封包_写2.写文本型(myclient.user.人物数据.昵称, hasCount: true, 0);
		封包_写2.写字节集(new byte[5] { 0, 0, 0, 15, 0 }, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public byte[] 组包确定框(int npcid, int 形象ID, string 角色名字, string 内容)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2037"), hasCount: false, 0);
		封包_写2.写整数型(npcid, reverse: true);
		封包_写2.写整数型(形象ID, reverse: true);
		封包_写2.写字节集(new byte[3] { 0, 1, 0 }, hasCount: false, 0);
		封包_写2.写文本型(内容, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(new byte[4], hasCount: false, 0);
		封包_写2.写文本型(角色名字, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(new byte[5] { 0, 0, 0, 25, 0 }, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public byte[] 组包确定框(MyNATSocketClient myclient, string 内容)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2037"), hasCount: false, 0);
		封包_写2.写整数型(myclient.user.人物数据.角色ID, reverse: true);
		封包_写2.写整数型(myclient.user.人物数据.形象ID, reverse: true);
		封包_写2.写字节集(new byte[3] { 0, 1, 0 }, hasCount: false, 0);
		封包_写2.写文本型(内容, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(new byte[4], hasCount: false, 0);
		封包_写2.写文本型(myclient.user.人物数据.昵称, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(new byte[5] { 0, 0, 0, 25, 0 }, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public byte[] 组包指令取消框(int 角色ID)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[12]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 8,
			240, 227
		}, hasCount: false, 0);
		封包_写2.写整数型(角色ID, reverse: true);
		封包_写2.写短整数型(0, reverse: true);
		return 封包_写2.取数据();
	}

	
	public byte[] 组包提交物品框(int npcid, int npc形象, string npc名字, string 内容)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2037"), hasCount: false, 0);
		封包_写2.写整数型(npcid, reverse: true);
		封包_写2.写整数型(npc形象, reverse: true);
		封包_写2.写字节集(new byte[3] { 0, 1, 0 }, hasCount: false, 0);
		封包_写2.写文本型(内容, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(new byte[4], hasCount: false, 0);
		封包_写2.写文本型(npc名字, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(new byte[5] { 0, 0, 0, 80, 0 }, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public byte[] 组包提交物品框(MyNATSocketClient myclient, string 内容)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2037"), hasCount: false, 0);
		封包_写2.写整数型(myclient.user.人物数据.角色ID, reverse: true);
		封包_写2.写整数型(myclient.user.人物数据.形象ID, reverse: true);
		封包_写2.写字节集(new byte[3] { 0, 1, 0 }, hasCount: false, 0);
		封包_写2.写文本型(内容, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(new byte[4], hasCount: false, 0);
		封包_写2.写文本型(myclient.user.人物数据.昵称, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(new byte[5] { 0, 0, 0, 80, 0 }, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public string 组装数值类型文本(AllEnums.数值Type 数值1, int 数值2)
	{
		switch (数值1)
		{
		case AllEnums.数值Type.等级:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n级");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case AllEnums.数值Type.道行:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n年道行");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case AllEnums.数值Type.经验:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n点经验");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case AllEnums.数值Type.声望:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n点声望");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case AllEnums.数值Type.战绩:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n点战绩");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case AllEnums.数值Type.金元宝:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n金元宝");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case AllEnums.数值Type.银元宝:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n银元宝");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case AllEnums.数值Type.金钱:
			return 问道标准数值文本(数值2) + "#n文";
		case AllEnums.数值Type.累充点:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n累充点");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case AllEnums.数值Type.体力:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n点体力");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case AllEnums.数值Type.南极点:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n南极点");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case AllEnums.数值Type.代金券:
			return 问道标准数值文本(数值2) + "#n代金券";
		case AllEnums.数值Type.奇宝点:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case AllEnums.数值Type.灵气值:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n灵气值");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case AllEnums.数值Type.论道点:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n论道点");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case AllEnums.数值Type.潜能:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#R");
			defaultInterpolatedStringHandler.AppendFormatted(数值2);
			defaultInterpolatedStringHandler.AppendLiteral("#n点潜能");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		default:
			return string.Empty;
		}
	}

	
	public string 问道标准数值文本(int value, bool is颜色 = true)
	{
		string text = value.ToString("#,###;-#,###;0");
		if (is颜色)
		{
			if (value.ToString().Length < 6)
			{
				text = "#n" + text;
			}
			else if (value.ToString().Length == 6)
			{
				text = "#G" + text + "#n";
			}
			else if (value.ToString().Length == 7)
			{
				text = "#O" + text + "#n";
			}
			else if (value.ToString().Length == 8)
			{
				text = "#Y" + text + "#n";
			}
			else if (value.ToString().Length == 9)
			{
				text = "#R" + text + "#n";
			}
			else if (value.ToString().Length == 10)
			{
				text = "#L" + text + "#n";
			}
		}
		return text;
	}

	
	public string 货币转文本(int value)
	{
		if (value < 10000)
		{
			return value.ToString();
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (value % 10000 == 0)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted(value / 10000);
			defaultInterpolatedStringHandler.AppendLiteral("万");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
		defaultInterpolatedStringHandler.AppendFormatted(value / 10000);
		defaultInterpolatedStringHandler.AppendLiteral(".");
		defaultInterpolatedStringHandler.AppendFormatted(value % 10000);
		defaultInterpolatedStringHandler.AppendLiteral("万");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	
	public string 道行转文本(int value)
	{
		if (value < 360)
		{
			return value + "天";
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (value % 360 == 0)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted(value / 360);
			defaultInterpolatedStringHandler.AppendLiteral("年");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
		defaultInterpolatedStringHandler.AppendFormatted(value / 360);
		defaultInterpolatedStringHandler.AppendLiteral("年");
		defaultInterpolatedStringHandler.AppendFormatted(value % 360);
		defaultInterpolatedStringHandler.AppendLiteral("天");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	
	public void 使用特八飞NPC(MyNATSocketClient myclient, string NPC名)
	{
		int num = 取背包物品格子(myclient, "特级八卦阴阳令");
		if (num != 0 && myclient.user.背包数据.物品列表[num] != null)
		{
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("1162"), hasCount: false, 0);
			封包_写2.写整数型(myclient.user.背包数据.物品列表[num].物品ID, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("02000001"), hasCount: false, 0);
			封包_写2.写文本型(NPC名, hasCount: true, 0, reverse: true);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			myclient.S_Send(封包_写3.取数据());
		}
	}

	
	public async Task 如意寻宝令挖宝(MyNATSocketClient myclient, string 宝藏地图, string X, string Y)
	{
		Singleton<WdAPI>.I.地图传送事件(myclient, 宝藏地图, X, Y);
		await Task.Delay(300);
		myclient.S_Send(Singleton<ByteAPI>.I.取字节集左边(Singleton<ByteAPI>.I.AddByte(全局变量类.HeadData, Singleton<ByteAPI>.I.HtoC("0003220C"), Singleton<ByteAPI>.I.到字节集(Singleton<WdAPI>.I.取背包物品格子(myclient, "锄头"))), 13));
	}

	
	public void 使用特八坐标飞(MyNATSocketClient myclient, string 传送数据)
	{
		int num = 取背包物品格子(myclient, "特级八卦阴阳令");
		if (num != 0 && myclient.user.背包数据.物品列表[num] != null)
		{
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("1162"), hasCount: false, 0);
			封包_写2.写整数型(myclient.user.背包数据.物品列表[num].物品ID, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("10000001"), hasCount: false, 0);
			封包_写2.写文本型(传送数据, hasCount: true, 1, reverse: true);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			myclient.S_Send(封包_写3.取数据());
		}
	}

	
	internal byte[] dn5obQBNHX(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写字节型(封包_读2.读字节型());
			封包_写2.写整数型(封包_读2.读整数型(reverse: true), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value), reverse: true);
			Singleton<全局变量类>.I.王中王物品列表.Clear();
			封包_写 封包_写3 = new 封包_写();
			物品信息类 物品信息类2 = null;
			for (int i = 0; i < value; i++)
			{
				可发货物品列表类 可发货物品列表类2 = new 可发货物品列表类(i);
				封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out 可发货物品列表类2.物品编号), reverse: true);
				封包_写2.写字节集(封包_读2.读字节集(1, out byte[] _), hasCount: false, 0);
				封包_写2.写整数型(封包_读2.读整数型(reverse: true, out 可发货物品列表类2.物品价格), reverse: true);
				if (物品信息类2 == null)
				{
					物品信息类2 = new 物品信息类
					{
						Index = 可发货物品列表类2.物品编号
					};
				}
				else
				{
					物品信息类2.C7n8ZR5IQ0(可发货物品列表类2.物品编号);
				}
				封包_写3.清数据();
				封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value3), reverse: true);
				for (int j = 0; j < value3; j++)
				{
					封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value4), reverse: true);
					封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value5), reverse: true);
					for (int k = 0; k < value5; k++)
					{
						封包_写3.写字节集(封包_读2.读字节集(2, out byte[] value6), hasCount: false, 0);
						封包_写3.写字节型(封包_读2.读字节型(out var value7));
						switch (value7)
						{
						case 1:
							封包_写3.写字节型(封包_读2.读字节型());
							break;
						case 2:
							封包_写3.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
							break;
						case 3:
						{
							int num2 = 封包_读2.读整数型(reverse: true);
							if (Enumerable.SequenceEqual(value6, new byte[2] { 0, 84 }))
							{
								物品信息类2.物品ID = num2;
							}
							else if (Enumerable.SequenceEqual(value6, new byte[2] { 0, 6 }) && num2 == 999)
							{
								num2 = 0;
							}
							else if (Enumerable.SequenceEqual(value6, new byte[2] { 0, 40 }))
							{
								物品信息类2.图标 = num2;
							}
							封包_写3.写整数型(num2, reverse: true);
							break;
						}
						case 4:
						{
							string text = 封包_读2.读文本型(是否声明长度: true, 0);
							if (Enumerable.SequenceEqual(value6, new byte[2] { 0, 1 }))
							{
								if (value4 == 1)
								{
									物品信息类2.名字 = text;
									可发货物品列表类2.物品名字 = text;
								}
							}
							else if (Enumerable.SequenceEqual(value6, new byte[2] { 1, 55 }))
							{
								物品信息类2.单位 = text;
							}
							else if (Enumerable.SequenceEqual(value6, new byte[2] { 1, 8 }))
							{
								物品信息类2.描述 = text;
							}
							else if (Enumerable.SequenceEqual(value6, new byte[2] { 0, 209 }))
							{
								物品信息类2.物品颜色 = text;
							}
							else if (Enumerable.SequenceEqual(value6, new byte[2] { 2, 65 }))
							{
								物品信息类2.别名 = text;
							}
							封包_写3.写文本型(text, hasCount: true, 0);
							break;
						}
						case 6:
						{
							int num = 封包_读2.读字节型();
							if (Enumerable.SequenceEqual(value6, new byte[2] { 0, 202 }))
							{
								物品信息类2.物品类型 = (byte)num;
							}
							else if (Enumerable.SequenceEqual(value6, new byte[2] { 0, 205 }))
							{
								物品信息类2.等级 = (byte)num;
							}
							封包_写3.写字节型(num);
							break;
						}
						case 7:
							封包_写3.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
							break;
						}
					}
				}
				物品信息类2.rgh8r0QQvs(P_0);
				if (Singleton<COyX27f6L3uCF3F6Kp5>.I.rCpfLKhKrZ(P_0, 物品信息类2))
				{
					物品信息类2.封包缓存 = 封包_写3.取数据();
					封包_写3.清数据();
					封包_写3.写入数据(Singleton<COyX27f6L3uCF3F6Kp5>.I.KDQfSpe9nM(P_0, 物品信息类2.封包缓存, 物品信息类2), hasCount: false, 0);
				}
				Singleton<全局变量类>.I.王中王物品列表.Add(可发货物品列表类2);
				Singleton<全局变量类>.I.王中王物品列表[i].物品封包 = 封包_写3.取数据();
				封包_写2.写字节集(Singleton<全局变量类>.I.王中王物品列表[i].物品封包, hasCount: false, 0);
			}
			Singleton<全局变量类>.I.王中王整体封包 = Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
			Singleton<全局变量类>.I.王中王整体封包[13] = 0;
			Singleton<全局变量类>.I.王中王整体封包[14] = 0;
			Singleton<全局变量类>.I.王中王整体封包[15] = 0;
			Singleton<全局变量类>.I.王中王整体封包[16] = 8;
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("王中王数据取出-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	public void NPCID预读(MyNATSocketClient myclient, string 对象昵称, int 对象ID, short 坐标X, short 坐标Y)
	{
		Singleton<z4BxVniyeUkxpq0lEyg>.I.X56iVZIf2q(myclient.插件端口, 对象ID, 对象昵称, 坐标X, 坐标Y, myclient.user.人物数据.所在地图名字);
		if (对象昵称.Contains("帮派总管", StringComparison.CurrentCulture))
		{
			if (myclient.user.人物数据.帮派总管ID == 0)
			{
				myclient.user.人物数据.帮派总管ID = 对象ID;
			}
			if (myclient.user.人物数据.is内置辅助_刷帮派 && myclient.user.人物数据.帮派总管ID == 0)
			{
				myclient.S_Send(Singleton<ByteAPI>.I.AddByte(Singleton<ByteAPI>.I.HtoC("4D5A00000000000000062064"), Singleton<ByteAPI>.I.反转_字节集(Singleton<ByteAPI>.I.到字节集(对象ID))));
			}
		}
		else if (myclient.user.人物数据.is内置辅助_降妖)
		{
			if (对象昵称 == "通灵道人" || 对象昵称.IndexOf("猥琐的") != -1 || 对象昵称.IndexOf("嗜血的") != -1 || 对象昵称.IndexOf("贪财的") != -1 || 对象昵称.IndexOf("无知的") != -1 || 对象昵称.IndexOf("奸诈的") != -1 || 对象昵称.IndexOf("罪恶的") != -1 || 对象昵称.IndexOf("龌龊的") != -1 || 对象昵称.IndexOf("狂妄的") != -1 || 对象昵称.IndexOf("自私的") != -1 || 对象昵称.IndexOf("吝啬的") != -1 || 对象昵称.IndexOf("贪婪的") != -1 || 对象昵称.IndexOf("扰民的") != -1 || 对象昵称.IndexOf("愚蠢的") != -1 || 对象昵称.IndexOf("黑心的") != -1 || 对象昵称.IndexOf("富有的") != -1 || 对象昵称.IndexOf("卑鄙的") != -1 || 对象昵称.IndexOf("万恶的") != -1 || 对象昵称.IndexOf("饥饿的") != -1 || 对象昵称.IndexOf("嚣张的") != -1 || 对象昵称.IndexOf("恐怖的") != -1 || 对象昵称.IndexOf("杀生的") != -1 || 对象昵称.IndexOf("害人的") != -1 || 对象昵称.IndexOf("凶狠的") != -1 || 对象昵称.IndexOf("得意的") != -1 || 对象昵称.IndexOf("自大的") != -1 || 对象昵称.IndexOf("猖獗的") != -1 || 对象昵称.IndexOf("狡猾的") != -1 || 对象昵称.IndexOf("丑陋的") != -1 || 对象昵称.IndexOf("残忍的") != -1)
			{
				myclient.S_Send(Singleton<ByteAPI>.I.AddByte(Singleton<ByteAPI>.I.HtoC("4D5A00000000000000062064"), Singleton<ByteAPI>.I.反转_字节集(Singleton<ByteAPI>.I.到字节集(对象ID))));
			}
		}
		else if (myclient.user.人物数据.is内置辅助_飞仙渡邪)
		{
			if (对象昵称 == "通灵道人" || 对象昵称.IndexOf("灭天") != -1 || 对象昵称.IndexOf("诛天") != -1 || 对象昵称.IndexOf("噬血") != -1 || 对象昵称.IndexOf("至恶") != -1 || 对象昵称.IndexOf("恶煞") != -1 || 对象昵称.IndexOf("阳奎") != -1 || 对象昵称.IndexOf("灭地") != -1 || 对象昵称.IndexOf("黑煞") != -1 || 对象昵称.IndexOf("逆天") != -1 || 对象昵称.IndexOf("邪仙") != -1 || 对象昵称.IndexOf("邪神") != -1 || 对象昵称.IndexOf("狂獠") != -1 || 对象昵称.IndexOf("猖枭") != -1 || 对象昵称.IndexOf("凶狈") != -1 || 对象昵称.IndexOf("傲世") != -1 || 对象昵称.IndexOf("飘渺") != -1 || 对象昵称.IndexOf("巫辰") != -1 || 对象昵称.IndexOf("无极") != -1 || 对象昵称.IndexOf("混元") != -1 || 对象昵称.IndexOf("虚空") != -1)
			{
				myclient.S_Send(Singleton<ByteAPI>.I.AddByte(Singleton<ByteAPI>.I.HtoC("4D5A00000000000000062064"), Singleton<ByteAPI>.I.反转_字节集(Singleton<ByteAPI>.I.到字节集(对象ID))));
			}
		}
		else if (myclient.user.人物数据.is内置辅助_伏魔)
		{
			if (对象昵称 == "陆压真人" || 对象昵称.IndexOf("魔王") != -1 || 对象昵称.IndexOf("妖王") != -1 || 对象昵称.IndexOf("戮神") != -1 || 对象昵称.IndexOf("赤地") != -1 || 对象昵称.IndexOf("玄溟") != -1 || 对象昵称.IndexOf("撼雷") != -1 || 对象昵称.IndexOf("焚魂") != -1 || 对象昵称.IndexOf("幻世") != -1 || 对象昵称.IndexOf("邪牙") != -1 || 对象昵称.IndexOf("尤鸾") != -1 || 对象昵称.IndexOf("破天") != -1)
			{
				myclient.S_Send(Singleton<ByteAPI>.I.AddByte(Singleton<ByteAPI>.I.HtoC("4D5A00000000000000062064"), Singleton<ByteAPI>.I.反转_字节集(Singleton<ByteAPI>.I.到字节集(对象ID))));
			}
		}
		else if (myclient.user.人物数据.is内置辅助_仙界通缉)
		{
			if (对象昵称 == "玉鉴上人" || 对象昵称.IndexOf("灭世") != -1 || 对象昵称.IndexOf("幻世") != -1 || 对象昵称.IndexOf("噬杀") != -1 || 对象昵称.IndexOf("血袍") != -1 || 对象昵称.IndexOf("万骨") != -1 || 对象昵称.IndexOf("百变") != -1 || 对象昵称.IndexOf("至邪") != -1 || 对象昵称.IndexOf("赤地") != -1 || 对象昵称.IndexOf("炽翼") != -1 || 对象昵称.IndexOf("擎天") != -1 || 对象昵称.IndexOf("御煞") != -1)
			{
				myclient.S_Send(Singleton<ByteAPI>.I.AddByte(Singleton<ByteAPI>.I.HtoC("4D5A00000000000000062064"), Singleton<ByteAPI>.I.反转_字节集(Singleton<ByteAPI>.I.到字节集(对象ID))));
			}
		}
		else if (myclient.user.人物数据.is内置辅助_仙人指路)
		{
			if (对象昵称 == "湖镜仙" || 对象昵称 == "叶猾仙" || 对象昵称 == "霹雳仙" || 对象昵称 == "煽赤仙" || 对象昵称 == "地藤仙" || 对象昵称 == "柳如烟")
			{
				myclient.S_Send(Singleton<ByteAPI>.I.AddByte(Singleton<ByteAPI>.I.HtoC("4D5A00000000000000062064"), Singleton<ByteAPI>.I.反转_字节集(Singleton<ByteAPI>.I.到字节集(对象ID))));
			}
		}
		else if (myclient.user.人物数据.is内置辅助_修行)
		{
			if (对象昵称 == "雷神" || 对象昵称 == "花神" || 对象昵称 == "龙神" || 对象昵称 == "炎神" || 对象昵称 == "山神" || 对象昵称 == "柳如尘")
			{
				myclient.S_Send(Singleton<ByteAPI>.I.AddByte(Singleton<ByteAPI>.I.HtoC("4D5A00000000000000062064"), Singleton<ByteAPI>.I.反转_字节集(Singleton<ByteAPI>.I.到字节集(对象ID))));
			}
		}
		else if (myclient.user.人物数据.is内置辅助_十绝阵 || myclient.user.人物数据.is内置辅助_天罡十绝阵)
		{
			if (对象昵称 == "寒冰阵主" || 对象昵称 == "红水阵主" || 对象昵称 == "天阙阵主" || 对象昵称 == "红砂阵主" || 对象昵称 == "风吼阵主" || 对象昵称 == "金光阵主" || 对象昵称 == "地烈阵主" || 对象昵称 == "烈焰阵主" || 对象昵称 == "化血阵主" || 对象昵称 == "落魄阵主" || 对象昵称 == "玉泉真人")
			{
				myclient.S_Send(Singleton<ByteAPI>.I.AddByte(Singleton<ByteAPI>.I.HtoC("4D5A00000000000000062064"), Singleton<ByteAPI>.I.反转_字节集(Singleton<ByteAPI>.I.到字节集(对象ID))));
			}
		}
		else if (myclient.user.存档数据.燃眉之急任务.当前NPC == 对象昵称)
		{
			myclient.user.存档数据.燃眉之急任务.当前NPCID = 对象ID;
			myclient.S_Send(Singleton<ByteAPI>.I.AddByte(Singleton<ByteAPI>.I.HtoC("4D5A00000000000000062064"), Singleton<ByteAPI>.I.反转_字节集(Singleton<ByteAPI>.I.到字节集(对象ID))));
			myclient.S_Send(组包对话NPC(myclient.user.存档数据.燃眉之急任务.当前NPCID));
		}
		if (对象昵称 == "王中王")
		{
			Singleton<全局变量类>.I.NPC_王中王 = 对象ID;
		}
		if (对象昵称 == "玉真子")
		{
			Singleton<全局变量类>.I.NPC_玉真子 = 对象ID;
		}
		else if (对象昵称 == "妙手道人")
		{
			Singleton<全局变量类>.I.NPC_妙手道人 = 对象ID;
		}
		else if (对象昵称 == "北斗星使")
		{
			Singleton<全局变量类>.I.NPC_北斗星使 = 对象ID;
		}
		else if (对象昵称 == "活动大使")
		{
			Singleton<全局变量类>.I.NPC_活动大使 = 对象ID;
		}
		else if (对象昵称 == "逍遥仙")
		{
			Singleton<全局变量类>.I.NPC_逍遥仙 = 对象ID;
		}
		else if (对象昵称 == "五行竞猜使")
		{
			Singleton<全局变量类>.I.NPC_五行竞猜使 = 对象ID;
		}
	}

	
	public byte[] 组包对话NPC(int NPCID)
	{
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(Singleton<ByteAPI>.I.AddByte(Singleton<ByteAPI>.I.HtoC("7012"), Singleton<ByteAPI>.I.反转_字节集(Singleton<ByteAPI>.I.到字节集(NPCID))), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public int 取背包最大格子(MyNATSocketClient myclient)
	{
		if (!myclient.user.缓存数据.is坐骑风灵丸)
		{
			return 160;
		}
		return 180;
	}

	
	public int 取背包物品格子(MyNATSocketClient myclient, string 物品名字)
	{
		if (string.IsNullOrWhiteSpace(物品名字))
		{
			return 0;
		}
		for (int i = 1; i <= 60; i++)
		{
			if (myclient.user.背包数据.物品列表[100 + i] != null && myclient.user.背包数据.物品列表[100 + i].名字 == 物品名字)
			{
				return 100 + i;
			}
		}
		if (!myclient.user.缓存数据.is坐骑风灵丸)
		{
			return 0;
		}
		for (int j = 1; j <= 20; j++)
		{
			if (myclient.user.背包数据.物品列表[160 + j] != null && myclient.user.背包数据.物品列表[160 + j].名字 == 物品名字)
			{
				return 160 + j;
			}
		}
		return 0;
	}

	
	public 物品信息类 取背包物品格子实例(MyNATSocketClient myclient, string 物品名字)
	{
		if (string.IsNullOrWhiteSpace(物品名字))
		{
			return null;
		}
		for (int i = 1; i <= 60; i++)
		{
			if (myclient.user.背包数据.物品列表[100 + i] != null && myclient.user.背包数据.物品列表[100 + i].名字 == 物品名字)
			{
				return myclient.user.背包数据.物品列表[100 + i];
			}
		}
		if (!myclient.user.缓存数据.is坐骑风灵丸)
		{
			return null;
		}
		for (int j = 1; j <= 20; j++)
		{
			if (myclient.user.背包数据.物品列表[160 + j] != null && myclient.user.背包数据.物品列表[160 + j].名字 == 物品名字)
			{
				return myclient.user.背包数据.物品列表[160 + j];
			}
		}
		return null;
	}

	
	public List<int> 取背包物品格子组(MyNATSocketClient myclient, string 物品名字, bool 是否修为丹 = true)
	{
		List<int> list = new List<int>();
		if (string.IsNullOrWhiteSpace(物品名字))
		{
			return list;
		}
		for (int i = 1; i <= 60; i++)
		{
			if (myclient.user.背包数据.物品列表[100 + i] != null && myclient.user.背包数据.物品列表[100 + i].名字 == 物品名字)
			{
				list.Add(100 + i);
			}
		}
		if (是否修为丹 && list.Count >= 3)
		{
			return list;
		}
		if (!myclient.user.缓存数据.is坐骑风灵丸)
		{
			return list;
		}
		for (int j = 1; j <= 20; j++)
		{
			if (myclient.user.背包数据.物品列表[160 + j] != null && myclient.user.背包数据.物品列表[160 + j].名字 == 物品名字)
			{
				list.Add(160 + j);
			}
		}
		return list;
	}

	
	public ConcurrentDictionary<int, int> 取背包物品格子丢弃数(MyNATSocketClient myclient, string 物品名字, int 丢弃总数)
	{
		if (string.IsNullOrWhiteSpace(物品名字) || 丢弃总数 <= 0)
		{
			return null;
		}
		ConcurrentDictionary<int, int> concurrentDictionary = new ConcurrentDictionary<int, int>();
		for (int i = 1; i <= 60; i++)
		{
			if (myclient.user.背包数据.物品列表[100 + i] == null)
			{
				continue;
			}
			if (丢弃总数 <= 0)
			{
				break;
			}
			if (myclient.user.背包数据.物品列表[100 + i].名字 == 物品名字)
			{
				if (丢弃总数 - myclient.user.背包数据.物品列表[100 + i].数量 <= 0)
				{
					concurrentDictionary.TryAdd(100 + i, 丢弃总数);
				}
				else
				{
					concurrentDictionary.TryAdd(100 + i, myclient.user.背包数据.物品列表[100 + i].数量);
				}
				丢弃总数 -= myclient.user.背包数据.物品列表[100 + i].数量;
			}
		}
		if (丢弃总数 <= 0 || !myclient.user.缓存数据.is坐骑风灵丸)
		{
			return concurrentDictionary;
		}
		for (int j = 1; j <= 20; j++)
		{
			if (myclient.user.背包数据.物品列表[160 + j] == null)
			{
				continue;
			}
			if (丢弃总数 <= 0)
			{
				break;
			}
			if (myclient.user.背包数据.物品列表[160 + j].名字 == 物品名字)
			{
				if (丢弃总数 - myclient.user.背包数据.物品列表[160 + j].数量 <= 0)
				{
					concurrentDictionary.TryAdd(160 + j, 丢弃总数);
				}
				else
				{
					concurrentDictionary.TryAdd(160 + j, myclient.user.背包数据.物品列表[160 + j].数量);
				}
				丢弃总数 -= myclient.user.背包数据.物品列表[160 + j].数量;
			}
		}
		return concurrentDictionary;
	}

	
	public int 取背包指定物品数量(MyNATSocketClient myclient, string 物品名字)
	{
		if (string.IsNullOrWhiteSpace(物品名字))
		{
			return 0;
		}
		int num = 0;
		for (int i = 1; i <= 60; i++)
		{
			if (myclient.user.背包数据.物品列表[100 + i] != null && myclient.user.背包数据.物品列表[100 + i].名字 == 物品名字)
			{
				num += myclient.user.背包数据.物品列表[100 + i].数量;
			}
		}
		if (!myclient.user.缓存数据.is坐骑风灵丸)
		{
			return num;
		}
		for (int j = 1; j <= 20; j++)
		{
			if (myclient.user.背包数据.物品列表[160 + j] != null && myclient.user.背包数据.物品列表[160 + j].名字 == 物品名字)
			{
				num += myclient.user.背包数据.物品列表[160 + j].数量;
			}
		}
		return num;
	}

	
	public int 取背包剩余格子数量(MyNATSocketClient myclient, string 物品名字, bool 是否绑定)
	{
		if (string.IsNullOrWhiteSpace(物品名字))
		{
			return 0;
		}
		int num = 0;
		for (int i = 1; i <= 60; i++)
		{
			if (myclient.user.背包数据.物品列表[100 + i] == null || myclient.user.背包数据.物品列表[100 + i].物品ID == 0)
			{
				num += Singleton<全局变量类>.I.config.背包叠加上限;
			}
			else if (myclient.user.背包数据.物品列表[100 + i].名字 == 物品名字 && myclient.user.背包数据.物品列表[100 + i].是否绑定 == 是否绑定 && myclient.user.背包数据.物品列表[100 + i].数量 < Singleton<全局变量类>.I.config.背包叠加上限)
			{
				num += Singleton<全局变量类>.I.config.背包叠加上限 - myclient.user.背包数据.物品列表[100 + i].数量;
			}
		}
		if (!myclient.user.缓存数据.is坐骑风灵丸)
		{
			return num;
		}
		for (int j = 1; j <= 20; j++)
		{
			if (myclient.user.背包数据.物品列表[160 + j] == null || myclient.user.背包数据.物品列表[160 + j].物品ID == 0)
			{
				num += Singleton<全局变量类>.I.config.背包叠加上限;
			}
			else if (myclient.user.背包数据.物品列表[160 + j].名字 == 物品名字 && myclient.user.背包数据.物品列表[160 + j].是否绑定 == 是否绑定 && myclient.user.背包数据.物品列表[160 + j].数量 < Singleton<全局变量类>.I.config.背包叠加上限)
			{
				num += Singleton<全局变量类>.I.config.背包叠加上限 - myclient.user.背包数据.物品列表[160 + j].数量;
			}
		}
		return num;
	}

	
	public int 取背包剩余空格数(MyNATSocketClient myclient)
	{
		int num = 0;
		for (int i = 1; i <= 60; i++)
		{
			if (myclient.user.背包数据.物品列表[100 + i] == null)
			{
				num++;
			}
			else if (myclient.user.背包数据.物品列表[100 + i].物品ID == 0)
			{
				num++;
			}
		}
		if (!myclient.user.缓存数据.is坐骑风灵丸)
		{
			return num;
		}
		for (int j = 1; j <= 20; j++)
		{
			if (myclient.user.背包数据.物品列表[160 + j] == null)
			{
				num++;
			}
			else if (myclient.user.背包数据.物品列表[160 + j].物品ID == 0)
			{
				num++;
			}
		}
		return num;
	}

	
	public int 取背包可用格子(MyNATSocketClient myclient)
	{
		int num = 0;
		for (int i = 1; i <= 60; i++)
		{
			if (myclient.user.背包数据.物品列表[100 + i] == null || (myclient.user.背包数据.物品列表[100 + i] != null && string.IsNullOrWhiteSpace(myclient.user.背包数据.物品列表[100 + i].名字)))
			{
				num = 100 + i;
				break;
			}
		}
		if (num > 0 || !myclient.user.缓存数据.is坐骑风灵丸)
		{
			return num;
		}
		for (int j = 1; j <= 20; j++)
		{
			if (myclient.user.背包数据.物品列表[160 + j] == null || (myclient.user.背包数据.物品列表[160 + j] != null && string.IsNullOrWhiteSpace(myclient.user.背包数据.物品列表[160 + j].名字)))
			{
				num = 160 + j;
				break;
			}
		}
		return num;
	}

	
	internal bool QSgoJ8DvVe(MyNATSocketClient P_0, int P_1)
	{
		if (P_1 > 100 && P_1 <= 160)
		{
			return true;
		}
		if (P_1 > 160 && P_1 <= 180)
		{
			return P_0.user.缓存数据.is坐骑风灵丸;
		}
		return false;
	}

	
	internal bool dSCoKmGWP9(MyNATSocketClient P_0)
	{
		int num = ((P_0.user.属性数据.等级 >= 70) ? 70 : P_0.user.属性数据.等级) / 10 + 1;
		if (P_0.user.宠物数据.ToList().FindAll( (宠物缓存数据类 item) => item.PetID != 0).Count >= num)
		{
			return false;
		}
		return true;
	}

	
	internal bool wfboRXZawH(MyNATSocketClient P_0, int P_1, bool P_2 = false)
	{
		if (!QSgoJ8DvVe(P_0, P_1))
		{
			P_0.C_Send(V8ToFdAZn7(P_0.user.背包数据.物品列表[P_1].封包缓存, P_1));
			return false;
		}
		if (!P_2)
		{
			if (取背包剩余空格数(P_0) < 1)
			{
				P_0.C_Send(V8ToFdAZn7(P_0.user.背包数据.物品列表[P_1].封包缓存, P_1).Concat(提示_中心提醒("你的包裹空位不足，无法使用道具。")).ToArray());
				return false;
			}
			if (!dSCoKmGWP9(P_0))
			{
				P_0.C_Send(V8ToFdAZn7(P_0.user.背包数据.物品列表[P_1].封包缓存, P_1).Concat(提示_中心提醒("宠物栏已满，无法使用道具！")).ToArray());
				return false;
			}
		}
		return true;
	}

	
	internal byte[] naeodnd6MY(int P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("220C"), hasCount: false, 0);
		封包_写2.写字节型(P_0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal void UH7oscwt9s(MyNATSocketClient P_0, int P_1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("220C"), hasCount: false, 0);
		封包_写2.写字节型(P_1);
		封包_写 封包_写3 = new 封包_写();
		封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
		封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		P_0.S_Send(封包_写3.取数据());
	}

	
	public async void 使用背包批量异步(MyNATSocketClient myclient, int 格子, int 数量)
	{
		for (int i = 0; i < 数量; i++)
		{
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("220C"), hasCount: false, 0);
			封包_写2.写字节型(格子);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			myclient.S_Send(封包_写3.取数据());
			await Task.Delay(1);
		}
	}

	
	internal bool WywoUvuXuV(MyNATSocketClient P_0, int P_1, int P_2)
	{
		for (int i = 0; i < P_2; i++)
		{
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("220C"), hasCount: false, 0);
			封包_写2.写字节型(P_1);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			P_0.S_Send(封包_写3.取数据());
		}
		return true;
	}

	
	public async Task 自动使用背包(MyNATSocketClient myclient, int 格子, int 数量)
	{
		for (int i = 0; i < 数量; i++)
		{
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("220C"), hasCount: false, 0);
			封包_写2.写字节型(格子);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			myclient.S_Send(封包_写3.取数据());
			await Task.Delay(1);
		}
	}

	
	internal byte[] FUioW2lnt4(int P_0, int P_1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[12]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 4,
			18, 40
		}, hasCount: false, 0);
		封包_写2.写字节型(P_0);
		封包_写2.写字节型(P_1);
		return 封包_写2.取数据();
	}

	
	internal byte[] dSCog5GPxy(int P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[12]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 12,
			33, 94
		}, hasCount: false, 0);
		封包_写2.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(P_0), hasCount: false, 0);
		封包_写2.写字节集(new byte[6] { 4, 200, 183, 182, 168, 0 }, hasCount: false, 0);
		return 封包_写2.取数据();
	}

	
	internal byte[] FfBoDN31h8(int P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(全局变量类.HeadData, hasCount: false, 0);
		封包_写2.写字节集(new byte[4] { 0, 16, 33, 94 }, hasCount: false, 0);
		封包_写2.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(P_0), hasCount: false, 0);
		封包_写2.写字节集(new byte[10] { 8, 207, 250, 187, 217, 181, 192, 190, 223, 0 }, hasCount: false, 0);
		return 封包_写2.取数据();
	}

	
	internal byte[] rxTojoeFsR(int P_0, int P_1)
	{
		return 全局变量类.HeadData.Concat(new byte[4] { 0, 7, 34, 54 }).Concat(Singleton<ByteAPI>.I.还原字节集(P_0)).Concat(Singleton<ByteAPI>.I.到字节集固定反转(P_1))
			.ToArray();
	}

	
	internal byte[] FdioldHrOI(int P_0)
	{
		return 全局常量类.丢弃宠物包.Concat(Singleton<ByteAPI>.I.到字节集固定反转(P_0)).ToArray();
	}

	
	internal byte[] Fruo8nupmJ(int P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[4] { 61, 243, 0, 94 }, hasCount: false, 0);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
		defaultInterpolatedStringHandler.AppendLiteral("#Y当前场内人数：#R");
		defaultInterpolatedStringHandler.AppendFormatted(P_0);
		defaultInterpolatedStringHandler.AppendLiteral("#n");
		封包_写2.写文本型(defaultInterpolatedStringHandler.ToStringAndClear(), hasCount: true, 0, reverse: true);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] ruAoIqjP2a(int P_0, int P_1)
	{
		return 全局常量类.宠物使用道具包.Concat(Singleton<ByteAPI>.I.还原字节集(P_0)).Concat(Singleton<ByteAPI>.I.还原字节集(P_1)).ToArray();
	}

	
	internal 宠物缓存数据类 h2Uoosf8y4(MyNATSocketClient P_0)
	{
		return P_0.user.宠物数据.ToList().Find( (宠物缓存数据类 x) => x.PetID == 0);
	}

	
	internal void Ua2oNtysKT(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			if (!Enumerable.SequenceEqual(Singleton<ByteAPI>.I.取字节集右边(P_1, 4), new byte[4]))
			{
				return;
			}
			_003C_003Ec__DisplayClass106_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass106_0();
			CS_0024_003C_003E8__locals3.Pva72vKMwk = Singleton<ByteAPI>.I.反转_整数(Singleton<ByteAPI>.I.取字节集中间(P_1, 12, 4));
			if (CS_0024_003C_003E8__locals3.Pva72vKMwk != 0)
			{
				P_0.user.宠物数据.ToList().Find( (宠物缓存数据类 a) => a.宠物ID == CS_0024_003C_003E8__locals3.Pva72vKMwk)?.初始化();
			}
		}
		catch (Exception ex)
		{
			Log.Error("接收_宠物增减事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public byte[] 组包假NPC站街(NPC数据类 NPC数据, int npcid = 0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("F05D"), hasCount: false, 0);
		封包_写2.写整数型((npcid == 0) ? NPC数据.npcid : npcid, reverse: true);
		封包_写2.写短整数型(NPC数据.坐标.X, reverse: true);
		封包_写2.写短整数型(NPC数据.坐标.Y, reverse: true);
		封包_写2.写短整数型(NPC数据.朝向, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000492000000040000000000000000000000000000000000000000000000000000000000000000"), hasCount: false, 0);
		封包_写2.写文本型(NPC数据.npc名字, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000008B"), hasCount: false, 0);
		封包_写2.写文本型(NPC数据.npc称号, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000000000000000000000"), hasCount: false, 0);
		封包_写2.写整数型(NPC数据.npc形象, reverse: true);
		封包_写2.写整数型(NPC数据.npc形象, reverse: true);
		封包_写2.写整数型(NPC数据.npc形象, reverse: true);
		封包_写2.写整数型(NPC数据.npc形象, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("000300030000000000000000000000000000000000000000000000"), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public byte[] 组包假NPC站街(NPC数据类 NPC数据, int npcid = 0, int npc形象 = 0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("F05D"), hasCount: false, 0);
		封包_写2.写整数型((npcid == 0) ? NPC数据.npcid : npcid, reverse: true);
		封包_写2.写短整数型(NPC数据.坐标.X, reverse: true);
		封包_写2.写短整数型(NPC数据.坐标.Y, reverse: true);
		封包_写2.写短整数型(NPC数据.朝向, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000492000000040000000000000000000000000000000000000000000000000000000000000000"), hasCount: false, 0);
		封包_写2.写文本型(NPC数据.npc名字, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000008B"), hasCount: false, 0);
		封包_写2.写文本型(NPC数据.npc称号, hasCount: true, 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000000000000000000000"), hasCount: false, 0);
		封包_写2.写整数型((npc形象 != 0) ? NPC数据.npc形象 : 0, reverse: true);
		封包_写2.写整数型((npc形象 != 0) ? NPC数据.npc形象 : 0, reverse: true);
		封包_写2.写整数型((npc形象 != 0) ? NPC数据.npc形象 : 0, reverse: true);
		封包_写2.写整数型((npc形象 != 0) ? NPC数据.npc形象 : 0, reverse: true);
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("000300030000000000000000000000000000000000000000000000"), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal bool dWOoi046qt(int P_0, ref DateTime P_1)
	{
		if (P_1 != DateTime.MinValue && (DateTime.Now - P_1).TotalMilliseconds < (double)P_0)
		{
			return false;
		}
		P_1 = DateTime.Now;
		return true;
	}

	
	internal bool bJboBw7BEu(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			if (P_0.user.缓存数据.Server心跳 == 0)
			{
				return true;
			}
			int num = Singleton<ByteAPI>.I.反转_整数(P_1) / 1000;
			int num2 = P_0.user.缓存数据.Server心跳 / 1000;
			if (Math.Abs(num - num2) < 15)
			{
				return true;
			}
			if (Singleton<全局变量类>.I.config.is指定辅助)
			{
				num = Math.Abs(num - 1902527150);
				if (num >= 0 && num <= 10000)
				{
					return true;
				}
			}
			return false;
		}
		catch (Exception ex)
		{
			Log.Error("校验当前封包时间戳-报错：" + ex.Message);
			return false;
		}
	}

	
	internal bool PndoGw5lW7(MyNATSocketClient P_0, AllEnums.发送数据Type P_1, string P_2, AllEnums.指令Type P_3 = AllEnums.指令Type.无, int P_4 = 1, bool P_5 = false, string P_6 = "")
	{
		switch (P_1)
		{
		case AllEnums.发送数据Type.道具:
			GmIoflSYxB(P_0, P_2, P_4);
			return true;
		case AllEnums.发送数据Type.宠物:
			return Y6Uo6JxbC9(P_0, P_2, P_4);
		case AllEnums.发送数据Type.坐骑:
			return UgSo2nWWJJ(P_0, P_2, P_4);
		case AllEnums.发送数据Type.数值:
			if (P_3 == AllEnums.指令Type.level)
			{
				P_0.user.缓存数据.Is等级调整 = true;
			}
			svcIp9X8sa(P_0, P_3, P_4, P_5);
			return true;
		case AllEnums.发送数据Type.累充点:
			if (P_5)
			{
				P_0.user.存档数据.累计充值金额 = P_4;
			}
			else
			{
				P_0.user.存档数据.累计充值金额 += P_4;
			}
			return true;
		case AllEnums.发送数据Type.南极点:
			if (P_5)
			{
				P_0.user.存档数据.南极抽奖次数 = P_4;
			}
			else
			{
				P_0.user.存档数据.南极抽奖次数 += P_4;
			}
			return true;
		case AllEnums.发送数据Type.奇宝点:
			if (P_5)
			{
				P_0.user.存档数据.奇宝斋存档.奇宝斋余额 = P_4;
			}
			else
			{
				P_0.user.存档数据.奇宝斋存档.奇宝斋余额 += P_4;
			}
			return true;
		case AllEnums.发送数据Type.灵气值:
			if (P_5)
			{
				P_0.user.存档数据.数值存档.灵气值 = P_4;
			}
			else
			{
				P_0.user.存档数据.数值存档.灵气值 += P_4;
			}
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND())
			{
				if (Singleton<全局变量类>.I.元神系统配置.禁止灵气存储 && P_0.user.存档数据.数值存档.灵气值 > P_0.user.存档数据.元神存档.JkJIRtbr1R())
				{
					P_0.user.存档数据.数值存档.灵气值 = P_0.user.存档数据.元神存档.JkJIRtbr1R();
				}
				同步灵气值到修道点(P_0);
			}
			return true;
		case AllEnums.发送数据Type.论道点:
			if (P_5)
			{
				P_0.user.存档数据.数值存档.论道点 = P_4;
			}
			else
			{
				P_0.user.存档数据.数值存档.论道点 += P_4;
			}
			return true;
		case AllEnums.发送数据Type.金元宝:
			return DB.I.cAJNoOkab6(P_0, P_4, 0);
		case AllEnums.发送数据Type.银元宝:
			return DB.I.cAJNoOkab6(P_0, 0, P_4);
		case AllEnums.发送数据Type.金银元宝:
			return DB.I.cAJNoOkab6(P_0, int.Parse(P_2), P_4);
		default:
			return false;
		}
	}

	
	public async Task 同步灵气值到修道点(MyNATSocketClient myclient)
	{
		await Task.Delay(0);
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[12]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 15,
			57, 241
		}, hasCount: false, 0);
		封包_写2.写整数型(myclient.user.人物数据.角色ID, reverse: true);
		封包_写2.写短整数型(1, reverse: true);
		封包_写2.写字节集(new byte[2] { 1, 129 }, hasCount: false, 0);
		封包_写2.写字节型(3);
		封包_写2.写整数型(myclient.user.存档数据.数值存档.灵气值, reverse: true);
		myclient.C_Send(封包_写2.取数据());
	}

	
	public void 同步境界到称谓(MyNATSocketClient myclient)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 57, 241 }, hasCount: false, 0);
		封包_写2.写整数型(myclient.user.人物数据.角色ID, reverse: true);
		封包_写2.写短整数型(1, reverse: true);
		封包_写2.写字节集(new byte[2] { 0, 36 }, hasCount: false, 0);
		封包_写2.写字节型(4);
		封包_写2.写文本型(myclient.user.存档数据.元神存档.当前境界.ToString(), hasCount: true, 0);
		myclient.C_Send(组包包头(封包_写2.取数据()));
	}

	
	private void GmIoflSYxB(MyNATSocketClient P_0, string P_1, int P_2 = 1, string P_3 = "")
	{
		try
		{
			if (string.IsNullOrWhiteSpace(P_1))
			{
				return;
			}
			int num = 取背包剩余空格数(P_0);
			if (!Singleton<ByteAPI>.I.寻找文本(P_3, "乾坤袋_") && (P_0.user.缓存数据.is战斗中 || P_0.user.缓存数据.is观战中 || num <= 1))
			{
				乾坤袋数据类 乾坤袋数据类2 = new 乾坤袋数据类
				{
					道具名字 = P_1,
					道具数量 = P_2
				};
				P_0.user.存档数据.乾坤袋列表.Enqueue(乾坤袋数据类2);
				Singleton<fK6mLrjpv26MU2YIIF9>.I.EJ0jquAYHE(P_0, 乾坤袋数据类2);
				return;
			}
			P_0.S_Send(HDvIXkjH6A(P_0));
			P_2--;
			byte[] array = eiiIn9Gguk(P_0, P_1);
			if (P_2 <= 0)
			{
				P_0.S_Send(array);
				P_0.S_Send(全局常量类.退出如律令);
				return;
			}
			int num2 = 0;
			while (P_2 > 0)
			{
				if (P_2 >= 99)
				{
					P_2 -= 99;
					num2 = 99;
				}
				else
				{
					num2 = P_2;
					P_2 = 0;
				}
				封包_写 封包_写2 = new 封包_写();
				封包_写2.写字节集(new byte[6] { 16, 66, 0, 0, 0, 1 }, hasCount: false, 0);
				ByteAPI i = Singleton<ByteAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 2);
				defaultInterpolatedStringHandler.AppendLiteral("复制道具1(");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("x");
				defaultInterpolatedStringHandler.AppendFormatted(num2);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				byte[] array2 = i.到字节集(defaultInterpolatedStringHandler.ToStringAndClear());
				封包_写2.写字节型(array2.Length);
				封包_写2.写字节集(array2, hasCount: false, 0);
				封包_写2.写字节集(new byte[1], hasCount: false, 0);
				封包_写 封包_写3 = new 封包_写();
				封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
				封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
				array = array.Concat(封包_写3.取数据()).ToArray();
			}
			P_0.S_Send(array);
			P_0.S_Send(全局常量类.退出如律令);
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
			defaultInterpolatedStringHandler.AppendLiteral("发送物品-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private bool Y6Uo6JxbC9(MyNATSocketClient P_0, string P_1, int P_2 = 1, string P_3 = "")
	{
		try
		{
			if (string.IsNullOrWhiteSpace(P_1))
			{
				return false;
			}
			if (!dSCoKmGWP9(P_0))
			{
				return false;
			}
			int num = 2;
			if (问道数据类.宠物分类字典.ContainsKey(P_1))
			{
				num = (int)问道数据类.宠物分类字典[P_1];
			}
			else
			{
				if (!Singleton<全局变量类>.I.自定义宠物.自定义宠物列表.ContainsKey(P_1))
				{
					Singleton<fK6mLrjpv26MU2YIIF9>.I.Ym9jrsy6dl(P_0, "#R" + P_1 + "#n宠物不存在，无法获得。");
					return false;
				}
				if (!Singleton<全局变量类>.I.验证client.授权配置.IsVip && !全局变量类.Is调试)
				{
					Singleton<fK6mLrjpv26MU2YIIF9>.I.Ym9jrsy6dl(P_0, "#R" + P_1 + "#n宠物暂无法发送，请联系管理员进行补偿。");
					return false;
				}
				num = (int)Enum.Parse<AllEnums.宠物Type>(Singleton<全局变量类>.I.自定义宠物.自定义宠物列表[P_1]);
			}
			P_0.S_Send(HDvIXkjH6A(P_0));
			byte[] buffer = TNUIvv8IeY(P_0, P_1).Concat(JMrI7BkW0T(P_0, P_1, num)).Concat(T1uIaOho0A(P_0, P_1, num)).ToArray();
			P_0.S_Send(buffer);
			P_0.S_Send(全局常量类.退出如律令);
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("发送宠物-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	private bool UgSo2nWWJJ(MyNATSocketClient P_0, string P_1, int P_2 = 1, string P_3 = "")
	{
		try
		{
			if (string.IsNullOrWhiteSpace(P_1))
			{
				return false;
			}
			if (!dSCoKmGWP9(P_0))
			{
				return false;
			}
			P_0.S_Send(HDvIXkjH6A(P_0));
			byte[] buffer = mIGITAO4In(P_0, P_1).Concat(n7wI94j2Ta(P_0, P_1)).Concat(R2IIyHk4u2(P_0, P_1)).ToArray();
			P_0.S_Send(buffer);
			P_0.S_Send(全局常量类.退出如律令);
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("发送坐骑-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal byte[] MdUomVRsfU(MyNATSocketClient P_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder("#O使用自动伏魔等任务时自行组好队伍且挂好自动战斗#r#n#O手动吃好天道神符，惊妖铃等，否则辅助无法使用#r#n#O无极散人设置好固定一星或者二星模式#n#r#Y所有内置辅助都需要自行组队和领取好时间。#n#r自动改造默认金元宝改造包裹第一个格子#n");
			return 对话生成_NPC(100, 20177, "小精灵", stringBuilder.ToString());
		}
		catch (Exception ex)
		{
			Log.Error("组包_内置辅助对话-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal byte[] zXxoPwQcb0(string P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2314"), hasCount: false, 0);
		封包_写2.写字节集(new byte[18]
		{
			17, 97, 100, 109, 105, 110, 95, 104, 97, 108,
			116, 95, 99, 111, 109, 98, 97, 116
		}, hasCount: false, 0);
		封包_写2.写文本型(P_0, hasCount: true, 0, reverse: true);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.问道头, hasCount: false, 0);
		obj.写整数型(Singleton<ByteAPI>.I.取启动时间(), reverse: true);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] ouooX9CUkZ(MyNATSocketClient P_0, int P_1, string P_2, bool P_3 = false, int P_4 = 0)
	{
		int num = 0;
		string empty = string.Empty;
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("5103"), hasCount: false, 0);
		封包_写2.写短整数型(1, reverse: true);
		封包_写2.写字节型(P_1);
		封包_读 封包_读2 = new 封包_读(P_0.user.背包数据.物品列表[P_1].封包缓存, 0, P_0.user.背包数据.物品列表[P_1].封包缓存.Length);
		封包_写 封包_写3 = new 封包_写();
		封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value), reverse: true);
		for (int i = 0; i < value; i++)
		{
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value3), reverse: true);
			for (int j = 0; j < value3; j++)
			{
				封包_写3.写字节集(封包_读2.读字节集(2, out byte[] value4), hasCount: false, 0);
				Singleton<ByteAPI>.I.反转_短整数(value4);
				封包_写3.写字节型(封包_读2.读字节型(out var value5));
				switch (value5)
				{
				case 1:
					封包_写3.写字节型(封包_读2.读字节型());
					break;
				case 2:
					封包_写3.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
					break;
				case 3:
					num = 封包_读2.读整数型(reverse: true);
					if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 40 }) && P_4 != 0)
					{
						num = P_4;
					}
					封包_写3.写整数型(num, reverse: true);
					break;
				case 4:
					empty = 封包_读2.读文本型(是否声明长度: true, 0);
					if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 8 }))
					{
						empty = ((!P_3) ? P_2 : (empty += P_2));
					}
					封包_写3.写文本型(empty, hasCount: true, 0, reverse: true);
					break;
				case 6:
					封包_写3.写字节型(封包_读2.读字节型());
					break;
				case 7:
					封包_写3.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
					break;
				}
			}
		}
		封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] V8ToFdAZn7(byte[] P_0, int P_1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("5103"), hasCount: false, 0);
		封包_写2.写短整数型(1, reverse: true);
		封包_写2.写字节型(P_1);
		封包_写2.写字节集(P_0, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] egooLaVjLu(MyNATSocketClient P_0, int P_1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("5103"), hasCount: false, 0);
		封包_写2.写短整数型(1, reverse: true);
		封包_写2.写字节型(P_1);
		封包_写2.写字节集(P_0.user.背包数据.物品列表[P_1].封包缓存, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] TMjoSFpjbL(物品信息类 P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("5103"), hasCount: false, 0);
		封包_写2.写短整数型(1, reverse: true);
		封包_写2.写字节型(P_0.Index);
		封包_写2.写字节集(P_0.封包缓存, hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public void 使用技能事件(MyNATSocketClient myclient, string 技能名字)
	{
		if (问道数据类.所有技能ID.TryGetValue(技能名字, out var value))
		{
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(new byte[12]
			{
				77, 90, 0, 0, 0, 0, 0, 0, 0, 9,
				17, 86
			}, hasCount: false, 0);
			封包_写2.写整数型(myclient.user.人物数据.角色ID, reverse: true);
			封包_写2.写字节型(0);
			封包_写2.写短整数型((short)value, reverse: true);
			myclient.S_Send(封包_写2.取数据());
		}
	}

	
	public void 地图传送事件(MyNATSocketClient myclient, string zone文件, string X, string Y)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2314"), hasCount: false, 0);
		封包_写2.写文本型("admin_teleport", hasCount: true, 0, reverse: true);
		封包_写2.写文本型(zone文件, hasCount: true, 0, reverse: true);
		封包_写2.写文本型((X == "0") ? string.Empty : X, hasCount: true, 0);
		封包_写2.写文本型((Y == "0") ? string.Empty : Y, hasCount: true, 0);
		封包_写 封包_写3 = new 封包_写();
		封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
		封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		myclient.S_Send(封包_写3.取数据());
	}

	
	public void 地图传送事件(MyNATSocketClient myclient, string zone文件)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 35, 20 }, hasCount: false, 0);
		封包_写2.写文本型("admin_teleport", hasCount: true, 0, reverse: true);
		封包_写2.写文本型(zone文件, hasCount: true, 0, reverse: true);
		封包_写2.写文本型(string.Empty, hasCount: true, 0);
		封包_写2.写文本型(string.Empty, hasCount: true, 0);
		封包_写 封包_写3 = new 封包_写();
		封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
		封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		myclient.S_Send(封包_写3.取数据());
	}

	
	public bool 地图传送事件(MyNATSocketClient myclient, 超级NPC列表类 超级NPC, string 地图名字)
	{
		_003C_003Ec__DisplayClass126_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass126_0();
		CS_0024_003C_003E8__locals3.Lsw7PZjrII = 地图名字;
		if (!Singleton<全局变量类>.I.所有地图字典.TryGetValue(CS_0024_003C_003E8__locals3.Lsw7PZjrII, out var value))
		{
			return false;
		}
		超级NPC传送类 超级NPC传送类2 = 超级NPC.地图列表.Find( (超级NPC传送类 x) => x.地图名字 == CS_0024_003C_003E8__locals3.Lsw7PZjrII);
		if (超级NPC传送类2 == null)
		{
			return false;
		}
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2314"), hasCount: false, 0);
		封包_写2.写文本型("admin_teleport", hasCount: true, 0, reverse: true);
		封包_写2.写文本型(value, hasCount: true, 0, reverse: true);
		封包_写2.写文本型(超级NPC传送类2.X坐标, hasCount: true, 0);
		封包_写2.写文本型(超级NPC传送类2.Y坐标, hasCount: true, 0);
		封包_写 封包_写3 = new 封包_写();
		封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
		封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		myclient.S_Send(封包_写3.取数据());
		return true;
	}

	
	public byte[] 接近玩家事件(string 对方名字)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 34, 4 }, hasCount: false, 0);
		封包_写2.写文本型(对方名字, hasCount: true, 0);
		封包_写2.写短整数型(1, reverse: true);
		return 组包包头(封包_写2.取数据());
	}

	
	public bool NPC传送事件(MyNATSocketClient myclient, string NPC名字)
	{
		_003C_003Ec__DisplayClass128_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass128_0();
		CS_0024_003C_003E8__locals2.PZa7FuRaQh = NPC名字;
		NPC信息类 nPC信息类 = Singleton<z4BxVniyeUkxpq0lEyg>.I.vbkiQt86xb(myclient.插件端口).Values.ToList().Find( (NPC信息类 x) => x.名字 == CS_0024_003C_003E8__locals2.PZa7FuRaQh);
		if (nPC信息类 == null)
		{
			return false;
		}
		if (!Singleton<全局变量类>.I.所有地图字典.TryGetValue(nPC信息类.所在地图, out var value))
		{
			return false;
		}
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("2314"), hasCount: false, 0);
		封包_写2.写文本型("admin_teleport", hasCount: true, 0, reverse: true);
		封包_写2.写文本型(value, hasCount: true, 0, reverse: true);
		封包_写2.写文本型(nPC信息类.坐标X.ToString(), hasCount: true, 0, reverse: true);
		封包_写2.写文本型(nPC信息类.坐标Y.ToString(), hasCount: true, 0, reverse: true);
		封包_写 封包_写3 = new 封包_写();
		封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
		封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		myclient.S_Send(封包_写3.取数据());
		return true;
	}

	
	internal void Omcocp8jd5(MyNATSocketClient P_0, string P_1, string P_2)
	{
		try
		{
			int num = 0;
			string 内容 = string.Empty;
			if (!(P_1 == "金相性_加点"))
			{
				if (!(P_1 == "木相性_加点"))
				{
					if (!(P_1 == "水相性_加点"))
					{
						if (!(P_1 == "火相性_加点"))
						{
							if (P_1 == "土相性_加点")
							{
								P_0.user.缓存数据.cdk类型 = AllEnums.CdkType.加土相性;
								num = Singleton<全局变量类>.I.config.单相最高上限 - P_0.user.属性数据.土相性值;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
								defaultInterpolatedStringHandler.AppendLiteral("请输入你要加的#R土相性#n点数：#MAX:");
								defaultInterpolatedStringHandler.AppendFormatted(num);
								defaultInterpolatedStringHandler.AppendLiteral("#TEXT:");
								defaultInterpolatedStringHandler.AppendFormatted(num);
								内容 = defaultInterpolatedStringHandler.ToStringAndClear();
							}
						}
						else
						{
							P_0.user.缓存数据.cdk类型 = AllEnums.CdkType.加火相性;
							num = Singleton<全局变量类>.I.config.单相最高上限 - P_0.user.属性数据.火相性值;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
							defaultInterpolatedStringHandler.AppendLiteral("请输入你要加的#R火相性#n点数：#MAX:");
							defaultInterpolatedStringHandler.AppendFormatted(num);
							defaultInterpolatedStringHandler.AppendLiteral("#TEXT:");
							defaultInterpolatedStringHandler.AppendFormatted(num);
							内容 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
					}
					else
					{
						P_0.user.缓存数据.cdk类型 = AllEnums.CdkType.加水相性;
						num = Singleton<全局变量类>.I.config.单相最高上限 - P_0.user.属性数据.水相性值;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
						defaultInterpolatedStringHandler.AppendLiteral("请输入你要加的#R水相性#n点数：#MAX:");
						defaultInterpolatedStringHandler.AppendFormatted(num);
						defaultInterpolatedStringHandler.AppendLiteral("#TEXT:");
						defaultInterpolatedStringHandler.AppendFormatted(num);
						内容 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
				else
				{
					P_0.user.缓存数据.cdk类型 = AllEnums.CdkType.加木相性;
					num = Singleton<全局变量类>.I.config.单相最高上限 - P_0.user.属性数据.木相性值;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
					defaultInterpolatedStringHandler.AppendLiteral("请输入你要加的#R木相性#n点数：#MAX:");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#TEXT:");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					内容 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			else
			{
				P_0.user.缓存数据.cdk类型 = AllEnums.CdkType.加金相性;
				num = Singleton<全局变量类>.I.config.单相最高上限 - P_0.user.属性数据.金相性值;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
				defaultInterpolatedStringHandler.AppendLiteral("请输入你要加的#R金相性#n点数：#MAX:");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#TEXT:");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				内容 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (num <= 0)
			{
				P_0.user.缓存数据.cdk类型 = AllEnums.CdkType.无;
			}
			else
			{
				P_0.C_Send(组包输入框(内容));
			}
		}
		catch (Exception ex)
		{
			Log.Error("相性加点输入设置-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal bool edtonKXt5C(int P_0)
	{
		return P_0 switch
		{
			4001 => true, 
			4002 => true, 
			4003 => true, 
			4004 => true, 
			4005 => true, 
			5001 => true, 
			5002 => true, 
			5003 => true, 
			5004 => true, 
			5005 => true, 
			6001 => false, 
			6002 => false, 
			6003 => false, 
			6004 => false, 
			6005 => false, 
			7001 => false, 
			7002 => false, 
			7003 => false, 
			7004 => false, 
			7005 => false, 
			_ => false, 
		};
	}

	
	internal void qAOo5w4shp(MyNATSocketClient P_0)
	{
		try
		{
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("1208"), hasCount: false, 0);
			string zone = "5,11,100,2,-8,6,6,6,6,6,1,5,5,5,5,5,5,5,5,5,5,1";
			封包_写2.写文本型(zone, hasCount: true, 1, reverse: true);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			P_0.S_Send(封包_写3.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("Pack_进入鬼才战斗-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string JQloMTM30O(string P_0, string P_1 = "", string P_2 = "")
	{
		Regex regex = (P_2.Equals("") ? new Regex("(?<=(" + P_1 + "))[.\\s\\S]*") : ((!P_1.Equals("")) ? new Regex("(?<=(" + P_1 + "))[.\\s\\S]*?(?=(" + P_2 + "))") : new Regex(".*?(?=(" + P_2 + "))")));
		return regex.Match(P_0).Value;
	}

	
	internal List<CJ20jjovgN5h2aIuR1k> usfohIuMNi<CJ20jjovgN5h2aIuR1k>(List<CJ20jjovgN5h2aIuR1k> P_0)
	{
		try
		{
			Random random = new Random();
			List<CJ20jjovgN5h2aIuR1k> list = new List<CJ20jjovgN5h2aIuR1k>();
			foreach (CJ20jjovgN5h2aIuR1k item in P_0)
			{
				list.Insert(random.Next(list.Count), item);
			}
			return list;
		}
		catch (Exception ex)
		{
			Log.Error("RandomizeList错误：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_0;
		}
	}

	
	internal async void H80o7hWH9k(MyNATSocketClient P_0)
	{
		try
		{
			int num = 取背包物品格子(P_0, "自动摆摊卡");
			for (int i = 0; i < 10; i++)
			{
				await Task.Delay(500);
				num = 取背包物品格子(P_0, "自动摆摊卡");
				if (num != 0)
				{
					break;
				}
			}
			if (num != 0)
			{
				P_0.user.存档数据.is防摆摊状态 = true;
				P_0.S_Send(naeodnd6MY(num));
			}
		}
		catch (Exception ex)
		{
			Log.Error("防刷摆摊处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal bool ExCoaKAsad(ConcurrentDictionary<string, 百炼提交校验类> P_0, string[] P_1)
	{
		try
		{
			for (int i = 0; i < P_1.Length; i++)
			{
				if (string.IsNullOrWhiteSpace(P_1[i]))
				{
					continue;
				}
				string[] array = P_1[i].Split("-");
				if (array.Length == 2 && !string.IsNullOrWhiteSpace(array[0]) && !string.IsNullOrWhiteSpace(array[1]) && !(array[1] == "0") && int.TryParse(array[1], out var result) && P_0.TryGetValue(array[0], out var value))
				{
					if (value.提交数量 < result)
					{
						return false;
					}
					value.是否符合 = true;
					value.需求数量 = result;
				}
			}
			return P_0.Values.ToList().All( (百炼提交校验类 x) => x.是否符合);
		}
		catch (Exception)
		{
			return false;
		}
	}

	
	internal bool HqcoTm6EXC(string P_0, string P_1)
	{
		string[] array = P_0.Split('|');
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrWhiteSpace(array[i]) && ("|" + P_1).Contains("|" + array[i] + "|", StringComparison.CurrentCulture))
			{
				return true;
			}
		}
		return false;
	}

	
	internal int qrjo9TWIdy(int P_0, int P_1)
	{
		return RandomHelper.Range(P_0, P_1 + 1);
	}

	
	internal static bool Q1HoyN6wEg(string P_0)
	{
		string pattern = "^[\\u4e00-\\u9fa5\\w，、（）]*$";
		return Regex.IsMatch(P_0, pattern);
	}

	
	internal static int RHRoCUPuJm(int P_0)
	{
		return P_0 ^ 0x744;
	}

	
	internal static int tfAoVvpVVT(int P_0, int P_1)
	{
		int num = RHRoCUPuJm(P_0);
		if (P_1 / 360 < num)
		{
			return Singleton<WdAPI>.I.qrjo9TWIdy(P_0 * 10, P_0 * 20);
		}
		return (int)((double)(P_0 + 10) / ((double)P_1 / 360.0 / (double)num));
	}

	
	internal static r5bnKpo0yGa4rNr451w gv9okTxCWh<r5bnKpo0yGa4rNr451w>(List<r5bnKpo0yGa4rNr451w> P_0, Func<r5bnKpo0yGa4rNr451w, int> P_1)
	{
		_003C_003Ec__DisplayClass141_0<r5bnKpo0yGa4rNr451w> CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass141_0<r5bnKpo0yGa4rNr451w>();
		CS_0024_003C_003E8__locals3.权重字段 = P_1;
		if (P_0 == null || !P_0.Any())
		{
			return default(r5bnKpo0yGa4rNr451w);
		}
		int num = P_0.Sum( (r5bnKpo0yGa4rNr451w x) => Math.Max(0, CS_0024_003C_003E8__locals3.权重字段(x)));
		if (num <= 0)
		{
			return default(r5bnKpo0yGa4rNr451w);
		}
		int num2 = Singleton<WdAPI>.I.qrjo9TWIdy(1, num);
		int num3 = 0;
		int num4 = 0;
		foreach (r5bnKpo0yGa4rNr451w item in P_0)
		{
			num4 = Math.Max(0, CS_0024_003C_003E8__locals3.权重字段(item));
			num3 += num4;
			if (num2 <= num3)
			{
				return item;
			}
		}
		return default(r5bnKpo0yGa4rNr451w);
	}

	
	internal async Task<string> AKEoOlhFAx(MyNATSocketClient P_0, AllEnums.数值Type P_1, string P_2, int P_3, bool P_4 = false, string P_5 = "")
	{
		try
		{
			string 奖励后缀 = string.Empty;
			if (P_3 == 0 || P_0 == null)
			{
				return 奖励后缀;
			}
			switch (P_1)
			{
			case AllEnums.数值Type.等级:
				PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.level, P_3, false, P_5);
				奖励后缀 = "等级提升了#R1#n级";
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你的" + 奖励后缀 + "。"));
				}
				break;
			case AllEnums.数值Type.道行:
				PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, P_3, false, P_5);
				奖励后缀 = "获得了#R" + 道行转文本(P_3) + "#n道行";
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			case AllEnums.数值Type.经验:
			{
				PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.exp, P_3, false, P_5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n点经验");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			case AllEnums.数值Type.声望:
			{
				PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, P_3, false, P_5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n点声望");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			case AllEnums.数值Type.战绩:
			{
				PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.total_score, P_3, false, P_5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n点战绩");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			case AllEnums.数值Type.金元宝:
			{
				DB.I.cAJNoOkab6(P_0, P_3, 0);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("金元宝#n");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			case AllEnums.数值Type.银元宝:
			{
				DB.I.cAJNoOkab6(P_0, 0, P_3);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("银元宝#n");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			case AllEnums.数值Type.金钱:
				PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, P_3, false, P_5);
				奖励后缀 = "获得了" + 问道标准数值文本(P_3) + "文钱";
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			case AllEnums.数值Type.累充点:
			{
				PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.cash, P_3, false, P_5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n累充点");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			case AllEnums.数值Type.道具:
			{
				PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, P_2, AllEnums.指令Type.无, P_3, false, P_5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4 && P_2 != "融丹专用经验包" && P_2 != "融丹专用道行包")
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			case AllEnums.数值Type.体力:
			{
				PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, P_2, AllEnums.指令Type.stamina, P_3, false, P_5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n点体力");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			case AllEnums.数值Type.南极点:
			{
				PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, P_2, AllEnums.指令Type.stamina, P_3, false, P_5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n南极点");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			case AllEnums.数值Type.代金券:
				PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, P_2, AllEnums.指令Type.voucher, P_3, false, P_5);
				奖励后缀 = "获得了" + 问道标准数值文本(P_3) + "代金券";
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			case AllEnums.数值Type.宠物:
			{
				PndoGw5lW7(P_0, AllEnums.发送数据Type.宠物, P_2, AllEnums.指令Type.无, P_3, false, P_5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n只#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			case AllEnums.数值Type.坐骑:
			{
				PndoGw5lW7(P_0, AllEnums.发送数据Type.坐骑, P_2, AllEnums.指令Type.无, P_3, false, P_5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n只#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			case AllEnums.数值Type.奇宝点:
			{
				PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, P_2, AllEnums.指令Type.无, P_3, false, P_5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			case AllEnums.数值Type.灵气值:
			{
				PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, P_2, AllEnums.指令Type.无, P_3, false, P_5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n点灵气值");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			case AllEnums.数值Type.论道点:
			{
				PndoGw5lW7(P_0, AllEnums.发送数据Type.论道点, P_2, AllEnums.指令Type.无, P_3, false, P_5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_3);
				defaultInterpolatedStringHandler.AppendLiteral("#n论道点");
				奖励后缀 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (P_4)
				{
					P_0.C_Send(提示_杂项公告("你" + 奖励后缀 + "。"));
				}
				break;
			}
			}
			await Task.Delay(1);
			return 奖励后缀;
		}
		catch (Exception ex)
		{
			Log.Error("发送玩家奖励-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return string.Empty;
		}
	}

	
	internal void uiroQSjehP(角色存档数据类 P_0, AllEnums.数值Type P_1, string P_2, int P_3)
	{
		try
		{
			if (P_3 != 0 && P_0 != null)
			{
				switch (P_1)
				{
				case AllEnums.数值Type.金元宝:
					DB.I.c1GNBnKh5d(P_0.账号, P_3, 0);
					break;
				case AllEnums.数值Type.银元宝:
					DB.I.c1GNBnKh5d(P_0.账号, 0, P_3);
					break;
				case AllEnums.数值Type.累充点:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[");
					defaultInterpolatedStringHandler.AppendFormatted(P_0.GID);
					defaultInterpolatedStringHandler.AppendLiteral("]推荐拉人离线获得");
					Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
					P_0.累计充值金额 += P_3;
					break;
				}
				case AllEnums.数值Type.道具:
				{
					乾坤袋数据类 item = new 乾坤袋数据类
					{
						道具名字 = P_2,
						道具数量 = P_3
					};
					P_0.乾坤袋列表.Enqueue(item);
					break;
				}
				case AllEnums.数值Type.南极点:
					P_0.南极抽奖次数 += P_3;
					break;
				case AllEnums.数值Type.奇宝点:
				{
					P_0.奇宝斋存档.奇宝斋余额 += P_3;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(53, 3);
					defaultInterpolatedStringHandler.AppendLiteral("[账号：");
					defaultInterpolatedStringHandler.AppendFormatted(P_0.账号);
					defaultInterpolatedStringHandler.AppendLiteral("] [昵称：");
					defaultInterpolatedStringHandler.AppendFormatted(P_0.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("] [发送类型：奇宝点] [物品名字：] [属性：] [数值：");
					defaultInterpolatedStringHandler.AppendFormatted(P_3);
					defaultInterpolatedStringHandler.AppendLiteral("]  [理由：离线发送]");
					Log.Warning(defaultInterpolatedStringHandler.ToStringAndClear());
					break;
				}
				case AllEnums.数值Type.等级:
				case AllEnums.数值Type.道行:
				case AllEnums.数值Type.经验:
				case AllEnums.数值Type.声望:
				case AllEnums.数值Type.战绩:
				case AllEnums.数值Type.金钱:
				case AllEnums.数值Type.体力:
				case AllEnums.数值Type.气血上限:
				case AllEnums.数值Type.代金券:
				case AllEnums.数值Type.宠物:
				case AllEnums.数值Type.坐骑:
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("发送玩家奖励-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal byte[] QewoEwLLTD(string P_0, short P_1 = 2)
	{
		if (P_1 < 1)
		{
			P_1 = 1;
		}
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[6] { 16, 121, 0, 0, 0, 0 }, hasCount: false, 0);
		封包_写2.写短整数型(P_1, reverse: true);
		封包_写2.写文本型(P_0, hasCount: true, 0);
		return 组包包头(封包_写2.取数据());
	}

	
	internal byte[] JISo3hLVxd(int P_0, int P_1, short P_2 = 30)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 62, 9 }, hasCount: false, 0);
		封包_写2.写整数型(P_0, reverse: true);
		封包_写2.写字节集(new byte[6] { 0, 0, 39, 31, 0, 15 }, hasCount: false, 0);
		return 组包包头(封包_写2.取数据());
	}

	
	public bool 玩家昵称违规(string 昵称)
	{
		if (!Singleton<ByteAPI>.I.寻找文本或(昵称, "GM", "gm", "Gm", "gM", "客服", "QQ", "qq", "群", "裙", "君羊", "null", "企", "鹅") && Tools.文本校验(昵称) && !Singleton<ByteAPI>.I.寻找文本("|妖皇小弟|北冥幼狮|玄天刺猬|魔猪幼仔|小猪猡|财神|福星|战神|海盗|僵尸王|恶鬼|凶魂|地星|天星|上古妖王|海盗|吞天|噬地|傀儡王|羊头怪|牛头怪|牛魔王|夜叉王|罗刹王|百年猪妖|百年象精|百年狂狮怪|百年黑熊精|百年刺猬精|百花羞|白骨精|孔雀妖姬|阎摩罗王|金角大仙|黑熊妖皇|天煞狂狮|灭天血刺|血炼魔猪|天魁星|天魔星|天机星|天闲星|天勇星|天雄星|天猛星|天威星|天英星|天贵星|天富星|天满星|天孤星|天伤星|天立星|天捷星|天暗星|天祐星|天空星|天速星|天异星|天杀星|天微星|天究星|天退星|天寿星|天剑星|天平星|天罪星|天损星|天败星|天牢星|天慧星|天暴星|天哭星|天巧星|地魁星|地煞星|地勇星|地杰星|地雄星|地威星|地英星|地奇星|地猛星|地文星|地正星|地辟星|地阖星|地强星|地暗星|地轴星|地会星|地佐星|地佑星|地灵星|地兽星|地微星|地慧星|地暴星|地默星|地猖星|地狂星|地飞星|地走星|地巧星|地明星|地进星|地退星|地满星|地遂星|地周星|地隐星|地异星|地理星|地俊星|地乐星|地捷星|地速星|地镇星|地稽星|地魔星|地妖星|地幽星|地伏星|地僻星|地空星|地孤星|地全星|地短星|地角星|地囚星|地藏星|地平星|地损星|地奴星|地察星|地恶星|地丑星|地数星|地阴星|地刑星|地壮星|地劣星|地健星|地耗星|地贼星|地狗星|反叛的天魁星|反叛的天魔星|反叛的天机星|反叛的天闲星|反叛的天勇星|反叛的天雄星|反叛的天猛星|反叛的天威星|反叛的天英星|反叛的天贵星|反叛的天富星|反叛的天满星|反叛的天孤星|反叛的天伤星|反叛的天立星|反叛的天捷星|反叛的天暗星|反叛的天祐星|反叛的天空星|反叛的天速星|反叛的天异星|反叛的天杀星|反叛的天微星|反叛的天究星|反叛的天退星|反叛的天寿星|反叛的天剑星|反叛的天平星|反叛的天罪星|反叛的天损星|反叛的天败星|反叛的天牢星|反叛的天慧星|反叛的天暴星|反叛的天哭星|反叛的天巧星|反叛的地魁星|反叛的地煞星|反叛的地勇星|反叛的地杰星|反叛的地雄星|反叛的地威星|反叛的地英星|反叛的地奇星|反叛的地猛星|反叛的地文星|反叛的地正星|反叛的地辟星|反叛的地阖星|反叛的地强星|反叛的地暗星|反叛的地轴星|反叛的地会星|反叛的地佐星|反叛的地佑星|反叛的地灵星|反叛的地兽星|反叛的地微星|反叛的地慧星|反叛的地暴星|反叛的地默星|反叛的地猖星|反叛的地狂星|反叛的地飞星|反叛的地走星|反叛的地巧星|反叛的地明星|反叛的地进星|反叛的地退星|反叛的地满星|反叛的地遂星|反叛的地周星|反叛的地隐星|反叛的地异星|反叛的地理星|反叛的地俊星|反叛的地乐星|反叛的地捷星|反叛的地速星|反叛的地镇星|反叛的地稽星|反叛的地魔星|反叛的地妖星|反叛的地幽星|反叛的地伏星|反叛的地僻星|反叛的地空星|反叛的地孤星|反叛的地全星|反叛的地短星|反叛的地角星|反叛的地囚星|反叛的地藏星|反叛的地平星|反叛的地损星|反叛的地奴星|反叛的地察星|反叛的地恶星|反叛的地丑星|反叛的地数星|反叛的地阴星|反叛的地刑星|反叛的地壮星|反叛的地劣星|反叛的地健星|反叛的地耗星|反叛的地贼星|反叛的地狗星|入侵的黑熊妖皇|入侵的天煞狂狮|入侵的灭天血刺|入侵的血炼魔猪|五龙窟一层的上古妖王|五龙窟二层的上古妖王|五龙窟三层的上古妖王|五龙窟四层的上古妖王|五龙窟五层的上古妖王|五龙山的上古妖王|乾元山的上古妖王|终南山的上古妖王|凤凰山的上古妖王|骷髅山的上古妖王|十里坡的上古妖王|幽冥涧的上古妖王|蓬莱岛的上古妖王|百花谷一的上古妖王|百花谷二的上古妖王|百花谷三的上古妖王|百花谷四的上古妖王|百花谷五的上古妖王|百花谷六的上古妖王|百花谷七的上古妖王|绝人阵的上古妖王|东昆仑的上古妖王|绝仙阵的上古妖王|地绝阵的上古妖王|天绝阵的上古妖王|海底迷宫的上古妖王|昆仑云海的上古妖王|雪域冰原的上古妖王|迷境花树的上古妖王|水云间的上古妖王|热砂荒漠的上古妖王|方丈岛的上古妖王|断魂窟的上古妖王|弑神殿的上古妖王|灭魔堂的上古妖王|太极圣境的上古妖王|玉清山巅的上古妖王|", "|" + 昵称 + "|"))
		{
			return Singleton<ByteAPI>.I.寻找文本(Singleton<全局变量类>.I.config.扩展BOSS名字, "|" + 昵称 + "|");
		}
		return true;
	}

	
	internal byte[] xVVoYsOCKa(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写字节型(封包_读2.读字节型(out var _));
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			short num = 封包_读2.读短整数型(reverse: true);
			short value4 = 0;
			short value5 = 0;
			int num2 = 0;
			int num3 = 0;
			short num4 = 0;
			int num5 = 0;
			string empty = string.Empty;
			封包_写2.写短整数型(num, reverse: true);
			for (int i = 0; i < num; i++)
			{
				num3 = 0;
				num4 = 0;
				num5 = 0;
				empty = string.Empty;
				封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out value4), reverse: true);
				for (int j = 0; j < value4; j++)
				{
					封包_读2.读短整数型(reverse: true, out value5);
					封包_写2.写短整数型(value5, reverse: true);
					num2 = 封包_读2.读字节型();
					封包_写2.写字节型(num2);
					switch (num2)
					{
					case 1:
						num3 = 封包_读2.读字节型();
						封包_写2.写字节型(num3);
						break;
					case 2:
						num4 = 封包_读2.读短整数型(reverse: true);
						封包_写2.写短整数型(num4, reverse: true);
						break;
					case 3:
						num5 = 封包_读2.读整数型(reverse: true);
						封包_写2.写整数型(num5, reverse: true);
						break;
					case 4:
						empty = 封包_读2.读文本型(是否声明长度: true, 0);
						封包_写2.写文本型(empty, hasCount: true, 0);
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
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return obj.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("请求_排行榜-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal byte[] PHfopOeqG8(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var value), reverse: true);
			if (value == 201 || value == 202 || value == 203 || value == 204 || value == 205 || value == 20101 || value == 20102 || value == 20103 || value == 20104 || value == 20105 || value == 20201 || value == 20202 || value == 20203 || value == 20204 || value == 20205 || value == 20301 || value == 20302 || value == 20303 || value == 20304 || value == 20305 || value == 20401 || value == 20402 || value == 20403 || value == 20404 || value == 20405 || value == 20501 || value == 20502 || value == 20503 || value == 20504 || value == 20505)
			{
				return Efeo11nqQ5(P_0, P_1);
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("组包排行榜数据2-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal byte[] Efeo11nqQ5(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass149_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass149_0();
			short value = 0;
			CS_0024_003C_003E8__locals5.Bsh7c42DAt = 0;
			short value2 = 0;
			int value3 = 0;
			int num = 0;
			short num2 = 0;
			int num3 = 0;
			string empty = string.Empty;
			int num4 = 0;
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			short num5 = 封包_读2.读短整数型(reverse: true);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写短整数型(num5, reverse: true);
			物品信息类 物品信息类2 = new 物品信息类();
			for (int i = 0; i < num5; i++)
			{
				num = 0;
				num2 = 0;
				num3 = 0;
				empty = string.Empty;
				封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out CS_0024_003C_003E8__locals5.Bsh7c42DAt), reverse: true);
				封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out value), reverse: true);
				for (int j = 0; j < value; j++)
				{
					封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out value2), reverse: true);
					封包_写3.写字节型(封包_读2.读字节型(out value3));
					num4 = 0;
					switch (value3)
					{
					case 1:
						num = 封包_读2.读字节型();
						封包_写3.写字节型(num);
						num4 = num;
						break;
					case 2:
						num2 = 封包_读2.读短整数型(reverse: true);
						封包_写3.写短整数型(num2, reverse: true);
						num4 = num2;
						break;
					case 3:
						num3 = 封包_读2.读整数型(reverse: true);
						if (value2 == 43)
						{
							物品信息类2.最大耐久度 = num3;
						}
						封包_写3.写整数型(num3, reverse: true);
						num4 = num3;
						break;
					case 4:
						empty = 封包_读2.读文本型(是否声明长度: true, 0);
						if (value2 == 1 && CS_0024_003C_003E8__locals5.Bsh7c42DAt == 1)
						{
							物品信息类2.名字 = empty;
							if (Singleton<全局变量类>.I.元神系统配置.功能开关)
							{
								物品信息类2.前缀 = ((empty.Length > 4) ? Singleton<ByteAPI>.I.取文本左边(empty, 4) : string.Empty);
								物品信息类2.穿戴要求 = AllEnums.元神境界.凡人境;
								if (物品信息类2.前缀.EndsWith("★"))
								{
									Enum.TryParse<AllEnums.元神境界>(物品信息类2.前缀.Replace("★", string.Empty), out 物品信息类2.穿戴要求);
								}
							}
							else
							{
								物品信息类2.前缀 = string.Empty;
							}
						}
						封包_写3.写文本型(empty, hasCount: true, 0);
						break;
					case 6:
						num = 封包_读2.读字节型();
						封包_写3.写字节型(num);
						if (value2 == 202)
						{
							物品信息类2.物品类型 = (byte)num;
						}
						num4 = num;
						break;
					case 7:
						num2 = 封包_读2.读短整数型(reverse: true);
						封包_写3.写短整数型(num2, reverse: true);
						num4 = num2;
						break;
					}
					if (全局常量类.属性类别组.Any( (int x) => x == CS_0024_003C_003E8__locals5.Bsh7c42DAt))
					{
						物品信息类2.装备属性列表.Add(new 属性数据
						{
							属性类别 = CS_0024_003C_003E8__locals5.Bsh7c42DAt,
							属性标识 = value2,
							属性数值 = num4
						});
					}
				}
			}
			if (p1hoxSIAN0(物品信息类2))
			{
				物品信息类2.封包缓存 = 封包_写3.取数据();
				封包_写3.清数据();
				封包_写3.写入数据(MbToHRM1fL(物品信息类2.封包缓存, 物品信息类2), hasCount: false, 0);
			}
			封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return obj.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("组包排行榜装备数据-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal bool p1hoxSIAN0(物品信息类 P_0)
	{
		if (string.IsNullOrWhiteSpace(P_0.名字))
		{
			return false;
		}
		if (TOqsYfW68LIGjCtAgK8.AlyW5lfYvE() && P_0.装备属性列表.Any( (属性数据 x) => x.属性类别 == 2562 && 问道数据类.特效类型字典.Contains(x.属性标识)))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.元神系统配置.功能开关 && Singleton<全局变量类>.I.元神系统配置.装备升阶数据.功能开关 && P_0.最大耐久度 > 100000 && P_0.最大耐久度 <= 200000)
		{
			return true;
		}
		return false;
	}

	
	internal byte[] MbToHRM1fL(byte[] P_0, 物品信息类 P_1)
	{
		try
		{
			if (Singleton<全局变量类>.I.元神系统配置.功能开关 && Singleton<全局变量类>.I.元神系统配置.装备升阶数据.功能开关 && P_1.最大耐久度 > 100000 && P_1.最大耐久度 <= 200000 && Singleton<全局变量类>.I.元神系统配置.装备升阶数据.装备升阶类型.ContainsKey((AllEnums.Equip类型)P_1.物品类型))
			{
				P_1.穿戴要求 = (AllEnums.元神境界)((P_1.最大耐久度 - 100000) / 10000);
			}
			string empty = string.Empty;
			int value = 0;
			int value2 = 0;
			short value3 = 0;
			StringBuilder stringBuilder = new StringBuilder();
			封包_读 封包_读2 = new 封包_读(P_0, 0, P_0.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写 封包_写3 = new 封包_写();
			封包_写 封包_写4 = new 封包_写();
			new StringBuilder();
			short num = 封包_读2.读短整数型(reverse: true);
			封包_写2.写短整数型(num, reverse: true);
			short num2 = 0;
			short num3 = 0;
			short num4 = 0;
			int num5 = 0;
			for (int i = 0; i < num; i++)
			{
				num2 = 封包_读2.读短整数型(reverse: true);
				num3 = 封包_读2.读短整数型(reverse: true);
				封包_写3.清数据();
				int num6 = 0;
				for (int j = 0; j < num3; j++)
				{
					num4 = 封包_读2.读短整数型(reverse: true);
					num5 = 封包_读2.读字节型();
					封包_写4.清数据();
					封包_写4.写短整数型(num4, reverse: true);
					封包_写4.写字节型(num5);
					switch (num5)
					{
					case 1:
						封包_读2.读字节型(out value);
						封包_写4.写字节型(value);
						break;
					case 2:
						封包_读2.读短整数型(reverse: true, out value3);
						封包_写4.写短整数型(value3, reverse: true);
						break;
					case 3:
						封包_读2.读整数型(reverse: true, out value2);
						封包_写4.写整数型(value2, reverse: true);
						break;
					case 4:
						empty = 封包_读2.读文本型(是否声明长度: true, 0);
						if (num4 == 264)
						{
							stringBuilder.Clear();
							if (Singleton<全局变量类>.I.元神系统配置.功能开关 && Singleton<全局变量类>.I.元神系统配置.装备升阶数据.功能开关 && P_1.最大耐久度 > 100000 && P_1.最大耐久度 <= 200000 && Singleton<全局变量类>.I.元神系统配置.装备升阶数据.装备升阶类型.ContainsKey((AllEnums.Equip类型)P_1.物品类型))
							{
								升阶需求类 value4;
								if (P_1.最大耐久度 >= 200000)
								{
									StringBuilder stringBuilder2 = stringBuilder;
									StringBuilder stringBuilder3 = stringBuilder2;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
									handler.AppendLiteral("#Y当前品阶：#G");
									handler.AppendFormatted(AllEnums.元神境界.真仙境);
									handler.AppendLiteral("#n#r");
									stringBuilder3.Append(ref handler);
								}
								else if (Singleton<全局变量类>.I.元神系统配置.装备升阶数据.需求字典.TryGetValue(P_1.穿戴要求 + 1, out value4))
								{
									StringBuilder stringBuilder2 = stringBuilder;
									StringBuilder stringBuilder4 = stringBuilder2;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(24, 2, stringBuilder2);
									handler.AppendLiteral("#Y当前品阶：#n");
									handler.AppendFormatted(P_1.穿戴要求);
									handler.AppendLiteral("#r#R(升阶进度");
									handler.AppendFormatted((P_1.最大耐久度 - 100000) % 10000 / value4.需求数量, "F2");
									handler.AppendLiteral("%)#n#r");
									stringBuilder4.Append(ref handler);
								}
								empty += $"{((empty.EndsWith("#r") || string.IsNullOrWhiteSpace(empty)) ? string.Empty : "#r")}{stringBuilder}";
							}
							if (TOqsYfW68LIGjCtAgK8.AlyW5lfYvE())
							{
								List<属性数据> list = P_1.装备属性列表.FindAll( (属性数据 x) => x.属性类别 == 2562 && x.属性数值 != 0 && 问道数据类.特效类型字典.Contains(x.属性标识));
								if (list.Count > 0)
								{
									string text = empty;
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
									defaultInterpolatedStringHandler.AppendFormatted((empty.EndsWith("#r") || string.IsNullOrWhiteSpace(empty)) ? string.Empty : "#r");
									defaultInterpolatedStringHandler.AppendLiteral("#M特效：");
									defaultInterpolatedStringHandler.AppendFormatted((AllEnums.特效类型Type)list[0].属性标识);
									defaultInterpolatedStringHandler.AppendLiteral("#n");
									empty = text + defaultInterpolatedStringHandler.ToStringAndClear();
								}
							}
						}
						封包_写4.写文本型(empty, hasCount: true, 0);
						break;
					case 6:
						封包_读2.读字节型(out value);
						封包_写4.写字节型(value);
						break;
					case 7:
						封包_读2.读短整数型(reverse: true, out value3);
						封包_写4.写短整数型(value3, reverse: true);
						break;
					}
					if (TOqsYfW68LIGjCtAgK8.AlyW5lfYvE() && num2 == 2562 && 问道数据类.特效类型字典.Contains(num4))
					{
						num6++;
					}
					else
					{
						封包_写3.写字节集(封包_写4.取数据(), hasCount: false, 0);
					}
				}
				封包_写2.写短整数型(num2, reverse: true);
				封包_写2.写短整数型((short)(num3 - num6), reverse: true);
				封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			}
			return 封包_写2.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("指定排行道具信息重组-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_0;
		}
	}

	
	public static string Get注册码()
	{
		using RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
		byte[] array = new byte[8];
		randomNumberGenerator.GetBytes(array);
		StringBuilder stringBuilder = new StringBuilder(8);
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"[b % "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Length]);
		}
		return stringBuilder.ToString();
	}

	
	internal byte[] AKCo4gK26i(List<int[]> P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写短整数型(4707, reverse: true);
		封包_写2.写短整数型((short)P_0.Count, reverse: true);
		for (int i = 0; i < P_0.Count; i++)
		{
			封包_写2.写整数型(P_0[i][0], reverse: true);
			封包_写2.写短整数型(2, reverse: true);
			封包_写2.写短整数型(6, reverse: true);
			封包_写2.写字节型(3);
			封包_写2.写整数型(P_0[i][1], reverse: true);
			封包_写2.写短整数型(7, reverse: true);
			封包_写2.写字节型(3);
			封包_写2.写整数型(P_0[i][1], reverse: true);
		}
		return 组包包头(封包_写2.取数据());
	}

	
	internal byte[] vdSoet7MIX(int P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[12]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 10,
			33, 135
		}, hasCount: false, 0);
		封包_写2.写字节型(3);
		封包_写2.写整数型(P_0, reverse: true);
		封包_写2.写字节集(new byte[3] { 1, 0, 0 }, hasCount: false, 0);
		return 封包_写2.取数据();
	}

	
	internal byte[] yIfoq3v2MW(string P_0, int P_1, string P_2)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 32, 179 }, hasCount: false, 0);
		封包_写2.写文本型(P_0, hasCount: true, 0);
		封包_写2.写整数型(P_1, reverse: true);
		封包_写2.写文本型(P_2, hasCount: true, 0);
		封包_写2.写字节集(new byte[3] { 1, 0, 0 }, hasCount: false, 0);
		return 组包包头(封包_写2.取数据());
	}

	
	internal byte[] ymxorl7Gud(string P_0, int P_1, string P_2)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 48, 89 }, hasCount: false, 0);
		封包_写2.写文本型(P_0, hasCount: true, 0);
		封包_写2.写整数型(P_1, reverse: true);
		封包_写2.写文本型(P_2, hasCount: true, 0);
		封包_写2.写字节集(new byte[3] { 1, 0, 0 }, hasCount: false, 0);
		return 组包包头(封包_写2.取数据());
	}

	
	internal byte[] UuhoZAdpED(string P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 35, 65 }, hasCount: false, 0);
		封包_写2.写文本型(string.Empty, hasCount: true, 0);
		封包_写2.写文本型(P_0, hasCount: true, 1, reverse: true);
		return 组包包头(封包_写2.取数据());
	}

	
	internal byte[] rGlotFRFOy(MyNATSocketClient P_0, byte[] P_1)
	{
		if (P_0.当前权限 != 300)
		{
			return null;
		}
		封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
		封包_读2.Seek(12L, SeekOrigin.Begin);
		string text = 封包_读2.读文本型(是否声明长度: true, 0);
		if (text == "admin_set_attrib")
		{
			封包_读2.读文本型(是否声明长度: true, 0);
			string s = 封包_读2.读文本型(是否声明长度: true, 0);
			if (封包_读2.读文本型(是否声明长度: true, 0) == "level")
			{
				if (!int.TryParse(s, out var result))
				{
					return null;
				}
				MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定角色ID玩家MyClient(result);
				if (myNATSocketClient != null)
				{
					myNATSocketClient.user.缓存数据.Is等级调整 = true;
				}
			}
		}
		else if (text == "admin_halt_combat")
		{
			string 玩家名字 = 封包_读2.读文本型(是否声明长度: true, 0);
			MyNATSocketClient myNATSocketClient2 = Singleton<MainService>.I.获取指定Name玩家MyClient(玩家名字);
			if (myNATSocketClient2 == null)
			{
				return null;
			}
			EOYImZQJeG(myNATSocketClient2, true);
			myNATSocketClient2.C_Send(提示_中心提醒("管理员以成功为您退出战斗,请耐心等待战斗回合结束！"));
		}
		return P_1;
	}

	
	internal byte[] KvfoAUfbgY(int P_0, int P_1, int P_2 = 1)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 40, 0 }, hasCount: false, 0);
		封包_写2.写整数型(P_0, reverse: true);
		封包_写2.写整数型(P_1, reverse: true);
		封包_写2.写字节型(P_2);
		return 组包包头(封包_写2.取数据());
	}

	
	internal byte[] bN2ozaM3HC(int P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 52, 5 }, hasCount: false, 0);
		封包_写2.写整数型(P_0, reverse: true);
		return 组包包头(封包_写2.取数据());
	}

	
	internal byte[] sfjNuF8Sek(string P_0)
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写字节集(new byte[2] { 62, 36 }, hasCount: false, 0);
		封包_写2.写文本型(P_0, hasCount: true, 0);
		封包_写2.写字节集(new byte[2] { 0, 255 }, hasCount: false, 0);
		return new byte[17]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 7,
			253, 100, 0, 98, 1, 52, 0
		}.Concat(组包包头(封包_写2.取数据())).ToArray();
	}

	
	public WdAPI()
	{
	}

	static WdAPI()
	{
	}
}
