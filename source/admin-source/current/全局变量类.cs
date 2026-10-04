using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Net.Event;
using Net.Share;
using Newtonsoft_X.Json;

public class 全局变量类 : Singleton<全局变量类>
{
	public const string 版本提示信息 = "顺风插件 1.6 内置管理后台\r\n请登录后自行修改管理员信息";

	public static bool Is展示转生等级 = true;

	public static bool Is中州论道 = false;

	public static bool Is简化版本 = true;

	public static ConcurrentQueue<string> 日志组 = new ConcurrentQueue<string>();

	public MyGdTcpClient 验证client;

	public Config config = new Config();

	public static List<string> 洗炼属性列表 = new List<string>
	{
		"力量", "准确", "体质", "气血", "防御", "破防", "灵力", "法力", "敏捷", "速度",
		"金相性", "木相性", "水相性", "火相性", "土相性", "金抗性", "木抗性", "水抗性", "火抗性", "土抗性",
		"抗中毒", "抗冰冻", "抗昏睡", "抗遗忘", "抗混乱", "连击", "反击", "反击率", "连击率", "物理必杀率",
		"反震度", "反震率", "所有属性", "所有相性", "所有抗性", "抗所有异常", "所有技能上升", "破防率", "忽视目标抗金", "忽视目标抗木",
		"忽视目标抗水", "忽视目标抗火", "忽视目标抗土", "忽视目标抗遗忘", "忽视目标抗中毒", "忽视目标抗冰冻", "忽视目标抗昏睡", "忽视目标抗混乱", "强力克金", "强力克木",
		"强力克水", "强力克火", "强力克土", "强力中毒", "强力昏睡", "强力遗忘", "强力混乱", "强力冰冻", "强金法伤害", "强木法伤害",
		"强水法伤害", "强火法伤害", "强土法伤害", "躲避攻击", "忽视所有抗性", "忽视所有抗异常", "解除遗忘状态", "解除中毒状态", "解除冰冻状态", "解除昏睡状态",
		"解除混乱状态", "忽视目标连击", "忽视目标物理必杀", "忽视躲避攻击", "强物理伤害", "法术必杀率", "抗镇魂", "抗化功", "抗水牢", "抗锁灵",
		"抗迷心", "忽视目标抗镇魂", "忽视目标抗化功", "忽视目标抗水牢", "忽视目标抗锁灵", "忽视目标抗迷心", "解除镇魂状态", "解除化功状态", "解除水牢状态", "解除锁灵状态",
		"解除迷心状态", "强力镇魂", "强力化功", "强力水牢", "强力锁灵", "强力迷心", "闪避", "出战化形"
	};

	public static ConcurrentDictionary<string, string> O文件路径列表 = new ConcurrentDictionary<string, string>();

	internal string 更新公告 = string.Empty;

	internal bool Is更新公告提示;

	internal Action 更新公告事件;

	internal Action<int> 读取配置事件;

	internal Action CDK生成保存事件;

	public List<角色汇总类> 角色列表 = new List<角色汇总类>();

	public List<CDK信息类> CDK列表 = new List<CDK信息类>();

	public List<商城数据类> 商城数据列表 = new List<商城数据类>();

	public 网关配置 网关Config = new 网关配置();

	public MainConfig 首页配置 = new MainConfig();

	public 南极配置类 南极配置 = new 南极配置类();

	public 累充配置类 累充配置 = new 累充配置类();

	public 燃眉配置类 燃眉配置 = new 燃眉配置类();

	public 邮箱配置类 邮箱配置 = new 邮箱配置类();

	public 超级坐骑配置类 超级坐骑配置 = new 超级坐骑配置类();

	public 商城限购配置类 商城限购配置 = new 商城限购配置类();

	public 圣无双配置类 圣无双配置 = new 圣无双配置类();

	public 挑战BOSS配置类 挑战BOSS配置 = new 挑战BOSS配置类();

	public 时装坐姿染色配置类 时装坐姿染色配置 = new 时装坐姿染色配置类();

	public 自选道具配置类 自选道具配置 = new 自选道具配置类();

	public 通天塔突破配置类 通天塔突破配置 = new 通天塔突破配置类();

	public 推荐拉人配置类 推荐拉人配置 = new 推荐拉人配置类();

	public 门派转换配置类 门派转换配置 = new 门派转换配置类();

	public 六道轮回配置类 六道轮回配置 = new 六道轮回配置类();

	public 一键大飞配置类 一键大飞配置 = new 一键大飞配置类();

	public 法宝共生配置类 法宝共生配置 = new 法宝共生配置类();

	public 异兽录配置类 异兽录配置 = new 异兽录配置类();

	public 指定会员配置类 指定会员配置 = new 指定会员配置类();

	public 礼包开元宝配置类 礼包开元宝配置 = new 礼包开元宝配置类();

	public 超级道具配置类 超级道具配置 = new 超级道具配置类();

	public 宠物绑定配置类 宠物绑定配置 = new 宠物绑定配置类();

	public 升级奖励配置类 升级奖励配置 = new 升级奖励配置类();

	public 宠物召唤配置类 宠物召唤配置 = new 宠物召唤配置类();

	public 浮生录配置类 浮生录配置 = new 浮生录配置类();

	public 超级地图配置类 超级地图配置 = new 超级地图配置类();

	public 喊话限制配置类 喊话限制配置 = new 喊话限制配置类();

	public 属性洗炼配置类 属性洗炼配置 = new 属性洗炼配置类();

	public 全服共享存档数据类 全服共享存档数据 = new 全服共享存档数据类();

	public 道具宠物回收配置类 道具宠物回收配置 = new 道具宠物回收配置类();

	public 奇宝斋配置类 奇宝斋配置 = new 奇宝斋配置类();

	public 宠物同源配置类 宠物同源配置 = new 宠物同源配置类();

	public 在线泡点配置类 在线泡点配置 = new 在线泡点配置类();

	public 等级道行检测类 等级道行检测 = new 等级道行检测类();

	public 百炼功能配置类 百炼功能配置 = new 百炼功能配置类();

	public 超级NPC配置类 超级NPC配置 = new 超级NPC配置类();

	public 道行达标配置类 道行达标配置 = new 道行达标配置类();

	public 活跃度配置类 活跃度配置 = new 活跃度配置类();

	public 黑名单记录类 黑名单记录 = new 黑名单记录类();

	public 签到配置类 签到配置 = new 签到配置类();

	public 盲盒配置类 盲盒配置 = new 盲盒配置类();

	public 在线抽奖配置类 在线抽奖配置 = new 在线抽奖配置类();

	public 召唤精怪配置类 召唤精怪配置 = new 召唤精怪配置类();

	public 试道大会配置类 试道大会配置 = new 试道大会配置类();

	public 宠物转生配置类 宠物转生配置 = new 宠物转生配置类();

	public 妖族化形配置类 妖族化形配置 = new 妖族化形配置类();

	public 怀旧专区配置类 怀旧专区配置 = new 怀旧专区配置类();

	public 首饰系统配置类 首饰系统配置 = new 首饰系统配置类();

	public 融丹配置类 融丹配置 = new 融丹配置类();

	public 守护配置类 守护配置 = new 守护配置类();

	public 宠物突破配置类 宠物突破配置 = new 宠物突破配置类();

	public 自定义宠物类 自定义宠物 = new 自定义宠物类();

	public 装备系统配置类 装备系统配置 = new 装备系统配置类();

	public 地府商城配置类 地府商城配置 = new 地府商城配置类();

	public 装备分解配置类 装备分解配置 = new 装备分解配置类();

	public 龙血BOSS配置类 龙血BOSS配置 = new 龙血BOSS配置类();

	public 装备强化配置类 装备强化配置 = new 装备强化配置类();

	public 礼包飘屏配置类 礼包飘屏配置 = new 礼包飘屏配置类();

	public 超级进化配置类 超级进化配置 = new 超级进化配置类();

	public 鸿运当头配置类 鸿运当头配置 = new 鸿运当头配置类();

	public 特效配置类 特效配置 = new 特效配置类();

	public 摆摊配置类 摆摊配置 = new 摆摊配置类();

	public 智能怪物配置类 智能怪物配置 = new 智能怪物配置类();

	public 天机神算配置类 天机神算配置 = new 天机神算配置类();

	public 娃娃配置类 娃娃配置 = new 娃娃配置类();

	public 日常配置类 日常配置 = new 日常配置类();

	public 元神系统配置类 元神系统配置 = new 元神系统配置类();

	public 狐狸和狗配置类 狐狸和狗配置 = new 狐狸和狗配置类();

	public 内充支付配置类 内充支付配置 = new 内充支付配置类();

	public 道具数据配置类 道具数据配置 = new 道具数据配置类();

	public 自助商店配置类 自助商店配置 = new 自助商店配置类();

	public void 线程日志记录(string value)
	{
		日志组.Enqueue(value);
	}

	internal void Config读取()
	{
		try
		{
			if (File.Exists("Config.json"))
			{
				config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("Config.json"));
			}
			else
			{
				File.WriteAllText("Config.json", JsonConvert.SerializeObject(config, Formatting.Indented));
			}
		}
		catch (Exception ex)
		{
			NDebug.LogError("Config读取失败：" + ex.Message);
		}
	}

	internal void Config保存()
	{
		try
		{
			File.WriteAllText("Config.json", JsonConvert.SerializeObject(config, Formatting.Indented));
		}
		catch (Exception ex)
		{
			NDebug.LogError("Config保存失败：" + ex.Message);
		}
	}

	public static void 初始化O路径()
	{
		O文件路径列表.Clear();
		O文件路径列表.TryAdd("NetClientFrom.Resources.grant.list", "etc.pak\\grant.list");
		O文件路径列表.TryAdd("NetClientFrom.Resources.topd.o", "lib_gs32.pak\\gs\\daemons\\topd.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.gaitouhuanmianka.o", "lib_gs32.pak\\gs\\clone\\item\\charge\\gaitouhuanmianka.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.jiji-rulvling.o", "lib_gs32.pak\\gs\\skills\\jiji-rulvling.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.wizardd.o", "lib_gs32.pak\\gs\\daemons\\wizardd.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.recognized.o", "lib_gs32.pak\\gs\\daemons\\recognized.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.magic_towerd.o", "lib_gs32.pak\\gs\\daemons\\magic_towerd.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.cross_server.shidao_dahui.o", "lib_gs32.pak\\gs\\daemons\\cross_server\\shidao_dahui.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.laojun_chagang.o", "lib_gs32.pak\\gs\\daemons\\tasks\\laojun_chagang.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.laojun_chengfa.o", "lib_gs32.pak\\gs\\daemons\\tasks\\laojun_chengfa.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.script_xiufa-lianbao.o", "lib_gs32.pak\\gs\\daemons\\tasks\\script_xiufa-lianbao.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.tasks.tongtianta.o", "lib_gs32.pak\\gs\\daemons\\tasks\\tongtianta.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.script_apprentice_earth.o", "lib_gs32.pak\\gs\\daemons\\tasks\\apprentice_task\\script_apprentice_earth.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.script_apprentice_fire.o", "lib_gs32.pak\\gs\\daemons\\tasks\\apprentice_task\\script_apprentice_fire.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.script_apprentice_metal.o", "lib_gs32.pak\\gs\\daemons\\tasks\\apprentice_task\\script_apprentice_metal.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.script_apprentice_water.o", "lib_gs32.pak\\gs\\daemons\\tasks\\apprentice_task\\script_apprentice_water.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.script_apprentice_wood.o", "lib_gs32.pak\\gs\\daemons\\tasks\\apprentice_task\\script_apprentice_wood.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.menpaibiwu_dahui.o", "lib_gs32.pak\\gs\\daemons\\tasks\\menpai_biwu\\menpaibiwu_dahui.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.shidao-dahui.o", "lib_gs32.pak\\gs\\daemons\\tasks\\shidao-dahui\\shidao-dahui.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.wuzhuangyuan.o", "lib_gs32.pak\\gs\\daemons\\tasks\\wuzhuangyuan\\wuzhuangyuan.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.xianjie_tongji.o", "lib_gs32.pak\\gs\\daemons\\tasks\\xianjie_tongji\\xianjie_tongji.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.script_fengyin-dejie.o", "lib_gs32.pak\\gs\\daemons\\tasks\\xianmolu\\script_fengyin-dejie.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.shangguyaowang_template.o", "lib_gs32.pak\\gs\\daemons\\template\\shangguyaowang_template.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.rune_inlayd.o", "lib_gs32.pak\\gs\\daemons\\rune_inlayd.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.dishaxing_template.o", "lib_gs32.pak\\gs\\daemons\\tasks\\shaxing\\dishaxing_template.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.heartbeatd.o", "lib_gs32.pak\\gs\\daemons\\heartbeatd.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.stalld.o", "lib_gs32.pak\\gs\\daemons\\stalld.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.family_task.o", "lib_gs32.pak\\gs\\daemons\\tasks\\family_task\\family_task.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.logind.o", "lib_gs32.pak\\gs\\daemons\\logind.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.basic.o", "lib_gs32.pak\\gs\\clone\\item\\fly_artifact\\basic.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.double_magic_hit.o", "lib_gs32.pak\\gs\\daemons\\actions\\double_magic_hit.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.magic_double_hit.o", "lib_gs32.pak\\gs\\daemons\\actions\\magic_double_hit.o");
		O文件路径列表.TryAdd("NetClientFrom.Resources.multi_physical_attack.o", "lib_gs32.pak\\gs\\daemons\\actions\\multi_physical_attack.o");
	}

	internal int 取随机值(int a, int b)
	{
		return RandomHelper.Range(a, b + 1);
	}

	public long 取当前时间戳(bool 是否到秒 = false)
	{
		if (!是否到秒)
		{
			return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		}
		return DateTimeOffset.UtcNow.ToUnixTimeSeconds();
	}

}
