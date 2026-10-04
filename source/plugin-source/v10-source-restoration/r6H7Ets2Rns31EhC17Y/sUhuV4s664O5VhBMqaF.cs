using System;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace r6H7Ets2Rns31EhC17Y;

internal class sUhuV4s664O5VhBMqaF : Singleton<sUhuV4s664O5VhBMqaF>
{
	
	internal void Nt1smqPHFo()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("怀旧专区配置类.json")))
			{
				Singleton<全局变量类>.I.怀旧专区配置 = JsonConvert.DeserializeObject<怀旧专区配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("怀旧专区配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.怀旧专区配置 = new 怀旧专区配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("怀旧专区配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.怀旧专区配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("怀旧专区配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void TEisPgrX8Q()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("怀旧专区配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.怀旧专区配置, Formatting.Indented));
			Log.Debug("怀旧专区配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("怀旧专区配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string opFsXCbOIy()
	{
		Nt1smqPHFo();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.怀旧专区配置, Formatting.Indented);
	}

	
	public void bfCsF4MgP0(string P_0)
	{
		Singleton<全局变量类>.I.怀旧专区配置 = JsonConvert.DeserializeObject<怀旧专区配置类>(P_0);
		TEisPgrX8Q();
	}

	
	[SpecialName]
	internal static bool wo7snB1Lah()
	{
		if (Singleton<全局变量类>.I.验证client.授权配置.Is一四怀旧 || 全局变量类.Is调试)
		{
			return Singleton<全局变量类>.I.怀旧专区配置.功能开关;
		}
		return false;
	}

	
	internal static bool boisLCl3wO(string P_0, string P_1, int P_2)
	{
		if (wo7snB1Lah())
		{
			if (P_0.Contains("【封神榜】梦入封神", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_梦入封神)
			{
				return true;
			}
			if (P_0.Contains("【月活动】仙界宠物大逃亡", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_宠物大逃亡)
			{
				return true;
			}
			if (P_0.Contains("【月活动】夜游百鬼地", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_夜游百鬼地)
			{
				return true;
			}
			if (P_0.Contains("【跨服玩法】登上九重天", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_九重天)
			{
				return true;
			}
			if (P_0.Contains("【西域】中洲异客", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_中洲异客)
			{
				return true;
			}
			if (P_0.Contains("【修炼】法宝共生之术", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_法宝共生)
			{
				return true;
			}
			if (P_0.Contains("地藏王传", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_地藏王传)
			{
				return true;
			}
			if (P_0.Contains("坐骑炼魄", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.选项_坐骑助阵)
			{
				return true;
			}
			if (P_0.Contains("天劫任务", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_天劫 && P_2 >= 139)
			{
				return true;
			}
			if (P_0.Contains("【新手】", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_新手指引)
			{
				return true;
			}
			if (P_0.Contains("【指引】法宝三合一", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_法宝三合一指引)
			{
				return true;
			}
			if (P_0.Contains("【指引】天降神石", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_天降神石指引)
			{
				return true;
			}
			if (P_0.Contains("【指引】悟道系统", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_悟道系统指引)
			{
				return true;
			}
			if (P_0.Contains("【指引】学习物理法术合击", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_合击指引)
			{
				return true;
			}
			if (P_0.Contains("安全设置指引", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_安全设置指引)
			{
				return true;
			}
			if (P_0.Contains("地府指引", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_地府指引)
			{
				return true;
			}
			if (P_0.Contains("【指引】中洲争霸", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_中洲争霸指引)
			{
				return true;
			}
			if (P_0.Contains("【指引】宠物心法", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_宠物心法指引)
			{
				return true;
			}
			if (P_0.Contains("【指引】奇宝斋系统", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_奇宝斋指引)
			{
				return true;
			}
			if (P_0.Contains("竞技场", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_竞技场)
			{
				return true;
			}
			if (P_0.Contains("缤纷好礼大派送", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_缤纷好礼)
			{
				return true;
			}
			if (P_0.Contains("拜师", StringComparison.CurrentCulture) && P_1.Contains("完成相应目标后可以获得奖励", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_拜师)
			{
				return true;
			}
			if (P_0.Contains("采购", StringComparison.CurrentCulture) && P_1.Contains("完成相应目标后可以获得奖励", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_采购)
			{
				return true;
			}
			if (P_0.Contains("除暴", StringComparison.CurrentCulture) && P_1.Contains("完成相应目标后可以获得奖励", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_除暴)
			{
				return true;
			}
			if (P_0.Contains("答题", StringComparison.CurrentCulture) && P_1.Contains("完成相应目标后可以获得奖励", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_答题)
			{
				return true;
			}
			if (P_0.Contains("钱庄", StringComparison.CurrentCulture) && P_1.Contains("完成相应目标后可以获得奖励", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_钱庄)
			{
				return true;
			}
			if (P_0.Contains("妖魔道", StringComparison.CurrentCulture) && P_1.Contains("完成相应目标后可以获得奖励", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_妖魔道)
			{
				return true;
			}
			if (P_0.Contains("捉宠", StringComparison.CurrentCulture) && P_1.Contains("完成相应目标后可以获得奖励", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_捉宠)
			{
				return true;
			}
			if (P_0.Contains("学习新的法术", StringComparison.CurrentCulture) && Singleton<全局变量类>.I.怀旧专区配置.任务_第二门派)
			{
				return true;
			}
			if (P_0.Contains("修为周卡", StringComparison.CurrentCulture) || P_1.Contains("购买修为周卡后", StringComparison.CurrentCulture))
			{
				return true;
			}
		}
		return false;
	}

	
	internal static void N4osSqPSXX(ref string P_0)
	{
		if (wo7snB1Lah())
		{
			if (Singleton<全局变量类>.I.怀旧专区配置.选项_初识新貌 && P_0.Contains("[【初识新貌】我想了解何为新旧角色/了解新旧门派]", StringComparison.CurrentCulture))
			{
				P_0 = P_0.Replace("[【初识新貌】我想了解何为新旧角色/了解新旧门派]", string.Empty);
			}
			if (Singleton<全局变量类>.I.怀旧专区配置.选项_万象宇化 && P_0.Contains("万象宇化", StringComparison.CurrentCulture))
			{
				P_0 = P_0.Replace("[我要学习万象宇化阵型/学习阵型][【指引】物理法术合击/物理法术合击指引][【合击技能】我要学习合击技能/学习合击技能][【阵型修炼】我要领悟阵型之力/阵型修炼]", string.Empty);
			}
			if (Singleton<全局变量类>.I.怀旧专区配置.选项_宠物顿悟 && P_0.Contains("宠物顿悟", StringComparison.CurrentCulture))
			{
				P_0 = P_0.Replace("[宠物顿悟技能/宠物顿悟技能]", string.Empty);
			}
			if (Singleton<全局变量类>.I.怀旧专区配置.选项_坐骑助阵 && P_0.Contains("坐骑天赋", StringComparison.CurrentCulture))
			{
				P_0 = P_0.Replace("[【天赋】坐骑天赋/坐骑天赋]", string.Empty);
			}
			if (Singleton<全局变量类>.I.怀旧专区配置.选项_坐骑炼魄 && P_0.Contains("坐骑炼魄", StringComparison.CurrentCulture))
			{
				P_0 = P_0.Replace("[【炼魄】坐骑炼魄/坐骑炼魄]", string.Empty);
			}
			if (Singleton<全局变量类>.I.怀旧专区配置.选项_宠物进阶 && P_0.Contains("宠物进阶", StringComparison.CurrentCulture))
			{
				P_0 = P_0.Replace("[提升宠物进阶技能/提升宠物进阶技能]", string.Empty);
			}
			if (Singleton<全局变量类>.I.怀旧专区配置.选项_全部镶嵌 && P_0.Contains("镶嵌令", StringComparison.CurrentCulture))
			{
				P_0 = P_0.Replace("[【镶嵌】我要使用镶嵌令/使用镶嵌令]", string.Empty);
			}
			if (Singleton<全局变量类>.I.怀旧专区配置.选项_元宝商人 && P_0.Contains("我要兑换商城道具", StringComparison.CurrentCulture))
			{
				P_0 = P_0.Replace("[【兑换】我要兑换商城道具/兑换商城道具]", string.Empty);
			}
			if (Singleton<全局变量类>.I.怀旧专区配置.选项_董老头 && P_0.Contains("我要查询我的活跃值情况", StringComparison.CurrentCulture))
			{
				P_0 = P_0.Replace("[我要查询我的活跃值情况/查询上月活跃度][问道嘉年华积分抽奖/抽奖][问道嘉年华活动介绍/介绍]", string.Empty);
			}
			if (Singleton<全局变量类>.I.怀旧专区配置.选项_法宝转世 && P_0.Contains("法宝净化转世", StringComparison.CurrentCulture))
			{
				P_0 = P_0.Replace("[【转世】法宝净化转世/法宝净化转世]", string.Empty);
				P_0 = P_0.Replace("[【指引】法宝三合一/【指引】新法宝系统]", string.Empty);
			}
			if (Singleton<全局变量类>.I.怀旧专区配置.选项_问道活动大使 && P_0.Contains("我是问道活动大使", StringComparison.CurrentCulture))
			{
				P_0 = P_0.Replace("[【夜游百鬼地】传送至百鬼地/月活动夜游百鬼地]", string.Empty);
			}
			if (Singleton<全局变量类>.I.怀旧专区配置.选项_守护天神 && P_0.Contains("我要请回我的守护", StringComparison.CurrentCulture))
			{
				P_0 = P_0.Replace("[我要请回我的守护/请守护]", string.Empty);
				P_0 = P_0.Replace("[关于守护/关于]", string.Empty);
			}
		}
	}

	
	internal static bool AaGscRm47i(string P_0, string P_1)
	{
		if (!wo7snB1Lah())
		{
			return false;
		}
		if (Singleton<全局变量类>.I.怀旧专区配置.选项_初识新貌 && P_0.Contains("了解新旧门派", StringComparison.CurrentCulture))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.怀旧专区配置.选项_万象宇化 && (P_0.Contains("学习阵型", StringComparison.CurrentCulture) || P_0.Contains("物理法术合击指引", StringComparison.CurrentCulture) || P_0.Contains("学习合击技能", StringComparison.CurrentCulture) || P_0.Contains("阵型修炼", StringComparison.CurrentCulture)))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.怀旧专区配置.选项_宠物顿悟 && P_0.Contains("宠物顿悟技能", StringComparison.CurrentCulture))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.怀旧专区配置.选项_坐骑炼魄 && P_1 == "玉真子" && (P_0.Contains("炼魄", StringComparison.CurrentCulture) || P_0.Contains("提交坐骑(", StringComparison.CurrentCulture)))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.怀旧专区配置.选项_坐骑助阵 && P_1 == "玉真子" && (P_0.Contains("天赋", StringComparison.CurrentCulture) || P_0.Contains("助阵", StringComparison.CurrentCulture)))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.怀旧专区配置.选项_宠物进阶 && P_0.Contains("提升宠物进阶技能", StringComparison.CurrentCulture))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.怀旧专区配置.选项_全部镶嵌 && P_0.Contains("使用镶嵌令", StringComparison.CurrentCulture))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.怀旧专区配置.选项_元宝商人 && P_1 == "元宝商人" && P_0.Contains("兑换商城道具", StringComparison.CurrentCulture))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.怀旧专区配置.选项_董老头 && P_1 == "董老头" && (P_0.Contains("查询上月活跃度", StringComparison.CurrentCulture) || P_0.Contains("抽奖", StringComparison.CurrentCulture) || P_0.Contains("介绍", StringComparison.CurrentCulture)))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.怀旧专区配置.选项_法宝转世 && P_1 == "普华天尊" && (P_0.Contains("法宝净化转世", StringComparison.CurrentCulture) || P_0.Contains("【指引】新法宝系统", StringComparison.CurrentCulture)))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.怀旧专区配置.选项_问道活动大使 && P_1 == "问道活动大使" && P_0.Contains("月活动夜游百鬼地", StringComparison.CurrentCulture))
		{
			return true;
		}
		if (Singleton<全局变量类>.I.怀旧专区配置.选项_守护天神 && P_1 == "守护天神" && P_0.Contains("请守护", StringComparison.CurrentCulture))
		{
			return true;
		}
		return false;
	}

	
	public sUhuV4s664O5VhBMqaF()
	{
	}

	static sUhuV4s664O5VhBMqaF()
	{
	}
}
