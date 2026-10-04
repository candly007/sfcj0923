using System;
using System.Collections.Generic;

public static class 全局常量类
{
	public const string 版本日期 = "2026-06-30";

	public const string 过滤使用道具名字 = "|超级灵宝丸|特级八卦阴阳令|";

	public static byte[] 净心决_包裹道具 = new byte[27]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 0, 17,
		48, 202, 0, 0, 0, 1, 9, 176, 252, 185,
		252, 181, 192, 190, 223, 49, 0
	};

	public static byte[] 退出如律令 = new byte[22]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 0, 12,
		33, 94, 0, 0, 0, 1, 4, 205, 203, 179,
		246, 0
	};

	public static byte[] 随身货站包 = new byte[16]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 0, 6,
		61, 243, 0, 152, 1, 49
	};

	public static byte[] 累充图标包 = new byte[16]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 0, 6,
		61, 243, 0, 65, 1, 49
	};

	public static byte[] 红毯雪景包 = new byte[49]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 0, 39,
		66, 37, 4, 10, 255, 244, 72, 250, 0, 29,
		39, 121, 8, 255, 244, 72, 250, 0, 29, 39,
		121, 11, 255, 244, 72, 250, 0, 29, 39, 121,
		7, 255, 244, 72, 250, 0, 29, 39, 121
	};

	public static byte[] 我的货架 = new byte[844]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 3, 66,
		61, 241, 1, 20, 0, 1, 1, 0, 0, 15,
		160, 0, 1, 0, 1, 0, 16, 1, 8, 4,
		0, 0, 1, 4, 4, 186, 239, 195, 171, 0,
		206, 3, 0, 0, 0, 1, 1, 55, 4, 2,
		180, 233, 0, 38, 3, 0, 0, 0, 0, 0,
		74, 7, 0, 3, 0, 84, 3, 0, 0, 109,
		108, 0, 209, 4, 0, 0, 31, 2, 0, 0,
		1, 108, 2, 0, 0, 0, 41, 3, 0, 0,
		0, 8, 0, 203, 2, 0, 1, 1, 150, 3,
		0, 0, 0, 5, 0, 40, 3, 0, 0, 6,
		77, 1, 252, 1, 0, 0, 207, 3, 0, 0,
		0, 5, 0, 2, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 3, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 4,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 5, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 6, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 7, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 8, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 9,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 10, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 11, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 12, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 13, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 14,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 15, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 16, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 17, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 18, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 19,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 20, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0
	};

	public const string 好友初始数据 = "\"friends\":([\"5\":([]),\"4\":([]),\"3\":([]),\"2\":([]),\"1\":([]),\"6\":([]),]),";

	public const string 引号 = "\"";

	public const string 法宝名字全 = "|定海珠|番天印|混元金斗|阴阳镜|九龙神火罩|金蛟剪|卸甲金葫|十二品莲台|混沌钟|七宝妙树|";

	public const string 天书名字全 = "|魔引|狂暴|烈炎|惊雷|青木|碎石|寒冰|怒击|破天|降魔斩|修罗术|反击|云体|仙风|尽忠|";

	public const string 世界BOSS名字 = "|黑熊妖皇|天煞狂狮|灭天血刺|血炼魔猪|";

	public const string 基础BOSS名字 = "|妖皇小弟|北冥幼狮|玄天刺猬|魔猪幼仔|小猪猡|财神|福星|战神|海盗|僵尸王|恶鬼|凶魂|地星|天星|上古妖王|海盗|吞天|噬地|傀儡王|羊头怪|牛头怪|牛魔王|夜叉王|罗刹王|百年猪妖|百年象精|百年狂狮怪|百年黑熊精|百年刺猬精|百花羞|白骨精|孔雀妖姬|阎摩罗王|金角大仙|黑熊妖皇|天煞狂狮|灭天血刺|血炼魔猪|天魁星|天魔星|天机星|天闲星|天勇星|天雄星|天猛星|天威星|天英星|天贵星|天富星|天满星|天孤星|天伤星|天立星|天捷星|天暗星|天祐星|天空星|天速星|天异星|天杀星|天微星|天究星|天退星|天寿星|天剑星|天平星|天罪星|天损星|天败星|天牢星|天慧星|天暴星|天哭星|天巧星|地魁星|地煞星|地勇星|地杰星|地雄星|地威星|地英星|地奇星|地猛星|地文星|地正星|地辟星|地阖星|地强星|地暗星|地轴星|地会星|地佐星|地佑星|地灵星|地兽星|地微星|地慧星|地暴星|地默星|地猖星|地狂星|地飞星|地走星|地巧星|地明星|地进星|地退星|地满星|地遂星|地周星|地隐星|地异星|地理星|地俊星|地乐星|地捷星|地速星|地镇星|地稽星|地魔星|地妖星|地幽星|地伏星|地僻星|地空星|地孤星|地全星|地短星|地角星|地囚星|地藏星|地平星|地损星|地奴星|地察星|地恶星|地丑星|地数星|地阴星|地刑星|地壮星|地劣星|地健星|地耗星|地贼星|地狗星|反叛的天魁星|反叛的天魔星|反叛的天机星|反叛的天闲星|反叛的天勇星|反叛的天雄星|反叛的天猛星|反叛的天威星|反叛的天英星|反叛的天贵星|反叛的天富星|反叛的天满星|反叛的天孤星|反叛的天伤星|反叛的天立星|反叛的天捷星|反叛的天暗星|反叛的天祐星|反叛的天空星|反叛的天速星|反叛的天异星|反叛的天杀星|反叛的天微星|反叛的天究星|反叛的天退星|反叛的天寿星|反叛的天剑星|反叛的天平星|反叛的天罪星|反叛的天损星|反叛的天败星|反叛的天牢星|反叛的天慧星|反叛的天暴星|反叛的天哭星|反叛的天巧星|反叛的地魁星|反叛的地煞星|反叛的地勇星|反叛的地杰星|反叛的地雄星|反叛的地威星|反叛的地英星|反叛的地奇星|反叛的地猛星|反叛的地文星|反叛的地正星|反叛的地辟星|反叛的地阖星|反叛的地强星|反叛的地暗星|反叛的地轴星|反叛的地会星|反叛的地佐星|反叛的地佑星|反叛的地灵星|反叛的地兽星|反叛的地微星|反叛的地慧星|反叛的地暴星|反叛的地默星|反叛的地猖星|反叛的地狂星|反叛的地飞星|反叛的地走星|反叛的地巧星|反叛的地明星|反叛的地进星|反叛的地退星|反叛的地满星|反叛的地遂星|反叛的地周星|反叛的地隐星|反叛的地异星|反叛的地理星|反叛的地俊星|反叛的地乐星|反叛的地捷星|反叛的地速星|反叛的地镇星|反叛的地稽星|反叛的地魔星|反叛的地妖星|反叛的地幽星|反叛的地伏星|反叛的地僻星|反叛的地空星|反叛的地孤星|反叛的地全星|反叛的地短星|反叛的地角星|反叛的地囚星|反叛的地藏星|反叛的地平星|反叛的地损星|反叛的地奴星|反叛的地察星|反叛的地恶星|反叛的地丑星|反叛的地数星|反叛的地阴星|反叛的地刑星|反叛的地壮星|反叛的地劣星|反叛的地健星|反叛的地耗星|反叛的地贼星|反叛的地狗星|入侵的黑熊妖皇|入侵的天煞狂狮|入侵的灭天血刺|入侵的血炼魔猪|五龙窟一层的上古妖王|五龙窟二层的上古妖王|五龙窟三层的上古妖王|五龙窟四层的上古妖王|五龙窟五层的上古妖王|五龙山的上古妖王|乾元山的上古妖王|终南山的上古妖王|凤凰山的上古妖王|骷髅山的上古妖王|十里坡的上古妖王|幽冥涧的上古妖王|蓬莱岛的上古妖王|百花谷一的上古妖王|百花谷二的上古妖王|百花谷三的上古妖王|百花谷四的上古妖王|百花谷五的上古妖王|百花谷六的上古妖王|百花谷七的上古妖王|绝人阵的上古妖王|东昆仑的上古妖王|绝仙阵的上古妖王|地绝阵的上古妖王|天绝阵的上古妖王|海底迷宫的上古妖王|昆仑云海的上古妖王|雪域冰原的上古妖王|迷境花树的上古妖王|水云间的上古妖王|热砂荒漠的上古妖王|方丈岛的上古妖王|断魂窟的上古妖王|弑神殿的上古妖王|灭魔堂的上古妖王|太极圣境的上古妖王|玉清山巅的上古妖王|";

	public const string 天地星名字 = "|天魁星|天魔星|天机星|天闲星|天勇星|天雄星|天猛星|天威星|天英星|天贵星|天富星|天满星|天孤星|天伤星|天立星|天捷星|天暗星|天祐星|天空星|天速星|天异星|天杀星|天微星|天究星|天退星|天寿星|天剑星|天平星|天罪星|天损星|天败星|天牢星|天慧星|天暴星|天哭星|天巧星|地魁星|地煞星|地勇星|地杰星|地雄星|地威星|地英星|地奇星|地猛星|地文星|地正星|地辟星|地阖星|地强星|地暗星|地轴星|地会星|地佐星|地佑星|地灵星|地兽星|地微星|地慧星|地暴星|地默星|地猖星|地狂星|地飞星|地走星|地巧星|地明星|地进星|地退星|地满星|地遂星|地周星|地隐星|地异星|地理星|地俊星|地乐星|地捷星|地速星|地镇星|地稽星|地魔星|地妖星|地幽星|地伏星|地僻星|地空星|地孤星|地全星|地短星|地角星|地囚星|地藏星|地平星|地损星|地奴星|地察星|地恶星|地丑星|地数星|地阴星|地刑星|地壮星|地劣星|地健星|地耗星|地贼星|地狗星|";

	public const string 天星名字 = "|天魁星|天魔星|天机星|天闲星|天勇星|天雄星|天猛星|天威星|天英星|天贵星|天富星|天满星|天孤星|天伤星|天立星|天捷星|天暗星|天祐星|天空星|天速星|天异星|天杀星|天微星|天究星|天退星|天寿星|天剑星|天平星|天罪星|天损星|天败星|天牢星|天慧星|天暴星|天哭星|天巧星|";

	public const string 地星名字 = "|地魁星|地煞星|地勇星|地杰星|地雄星|地威星|地英星|地奇星|地猛星|地文星|地正星|地辟星|地阖星|地强星|地暗星|地轴星|地会星|地佐星|地佑星|地灵星|地兽星|地微星|地慧星|地暴星|地默星|地猖星|地狂星|地飞星|地走星|地巧星|地明星|地进星|地退星|地满星|地遂星|地周星|地隐星|地异星|地理星|地俊星|地乐星|地捷星|地速星|地镇星|地稽星|地魔星|地妖星|地幽星|地伏星|地僻星|地空星|地孤星|地全星|地短星|地角星|地囚星|地藏星|地平星|地损星|地奴星|地察星|地恶星|地丑星|地数星|地阴星|地刑星|地壮星|地劣星|地健星|地耗星|地贼星|地狗星|";

	public const string 首饰转换头 = "\\\"cvt_chance\\\":";

	public static string[] 全_首饰 = new string[45]
	{
		"金刚手镯", "七星手链", "凤舞环", "龙鳞手镯", "法文手轮", "闭月双环", "三清手镯", "天星奇光", "碎梦涵光", "九天霜华",
		"岚金火链", "龙御七星", "贪狼破日", "屠龙封魔", "九霞朝真", "纹龙佩", "温玉玦", "血心石", "八角晶牌", "蟠螭结",
		"七龙珠", "金蝉宝囊", "通灵宝玉", "寒玉龙勾", "八宝如意", "游火灵焰", "炫元玲珑", "七杀固元", "菩提镜明", "和光同尘",
		"青珑挂珠", "紫晶坠子", "三才项圈", "幻彩项链", "雪魂丝链", "天机锁链", "秘魔灵珠", "金碧莲花", "流光绝影", "五蕴悯光",
		"千彩流光", "掠虹宝坠", "破军捆灵", "洛神回雪", "景云烛日"
	};

	public static byte[] 空数据包 = Array.Empty<byte>();

	public static byte[] 标识头 = new byte[2] { 77, 90 };

	public static byte[] 协议头 = new byte[4] { 77, 90, 0, 0 };

	public static byte[] 下线包 = new byte[12]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 0, 2,
		64, 4
	};

	public static byte[] 通天塔文字 = new byte[6] { 205, 168, 204, 236, 203, 254 };

	public static byte[] 宠物使用道具包 = new byte[12]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 0, 4,
		32, 62
	};

	public static int[] 属性颜色组 = new int[4] { 514, 770, 3074, 1026 };

	public static byte[] 获取所有NPC包 = new byte[15]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 0, 5,
		48, 28, 0, 0, 3
	};

	public static byte[] 获取当前NPC包 = new byte[15]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 0, 5,
		48, 28, 0, 0, 4
	};

	public static byte[] 丢弃物品包 = new byte[43]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 0, 7,
		34, 54, 0, 0, 0, 0, 0, 77, 90, 0,
		0, 0, 0, 0, 0, 0, 16, 16, 66, 0,
		0, 0, 0, 8, 207, 250, 187, 217, 181, 192,
		190, 223, 0
	};

	public static byte[] 丢弃宠物包 = new byte[12]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 0, 6,
		51, 0
	};

	public static byte[] 切换装备包1 = new byte[13]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 0, 3,
		33, 16, 0
	};

	public static byte[] 切换装备包2 = new byte[13]
	{
		77, 90, 0, 0, 0, 0, 0, 0, 0, 3,
		33, 16, 1
	};

	public static byte[] 昵称头 = new byte[2] { 0, 1 };

	public static byte[] 称谓头 = new byte[2] { 0, 36 };

	public static byte[] 精力头 = new byte[2] { 2, 220 };

	public static byte[] 最大精力头 = new byte[2] { 2, 221 };

	public static byte[] 当前力量头 = new byte[2] { 0, 2 };

	public static byte[] 当前物攻头 = new byte[2] { 0, 3 };

	public static byte[] 准确头 = new byte[2] { 0, 4 };

	public static byte[] 当前体质头 = new byte[2] { 0, 5 };

	public static byte[] 当前气血头 = new byte[2] { 0, 6 };

	public static byte[] 最大气血头 = new byte[2] { 0, 7 };

	public static byte[] 当前防御头 = new byte[2] { 0, 8 };

	public static byte[] 当前灵力头 = new byte[2] { 0, 9 };

	public static byte[] 当前法攻头 = new byte[2] { 0, 10 };

	public static byte[] 当前法力头 = new byte[2] { 0, 11 };

	public static byte[] 最大法力头 = new byte[2] { 0, 12 };

	public static byte[] 当前敏捷头 = new byte[2] { 0, 13 };

	public static byte[] 当前速度头 = new byte[2] { 0, 14 };

	public static byte[] 闪避头 = new byte[2] { 0, 15 };

	public static byte[] 剩余属性头 = new byte[2] { 0, 16 };

	public static byte[] 剩余相性头 = new byte[2] { 0, 17 };

	public static byte[] 当前体力头 = new byte[2] { 0, 18 };

	public static byte[] 最大体力头 = new byte[2] { 0, 19 };

	public static byte[] 道行头 = new byte[2] { 0, 20 };

	public static byte[] 经验头 = new byte[2] { 0, 25 };

	public static byte[] 经验上限头 = new byte[2] { 0, 55 };

	public static byte[] 潜能头 = new byte[2] { 0, 26 };

	public static byte[] 金钱头 = new byte[2] { 0, 27 };

	public static byte[] 性别头 = new byte[2] { 0, 29 };

	public static byte[] 经验锁头 = new byte[2] { 2, 82 };

	public static byte[] 等级头 = new byte[2] { 0, 31 };

	public static byte[] 好心值头 = new byte[2] { 0, 37 };

	public static byte[] 声望头 = new byte[2] { 0, 38 };

	public static byte[] 战绩头 = new byte[2] { 0, 75 };

	public static byte[] 五行头 = new byte[2] { 0, 44 };

	public static byte[] 金相性值头 = new byte[2] { 0, 45 };

	public static byte[] 木相性值头 = new byte[2] { 0, 46 };

	public static byte[] 水相性值头 = new byte[2] { 0, 47 };

	public static byte[] 火相性值头 = new byte[2] { 0, 48 };

	public static byte[] 土相性值头 = new byte[2] { 0, 49 };

	public static byte[] 金抗性头 = new byte[2] { 0, 50 };

	public static byte[] 木抗性头 = new byte[2] { 0, 51 };

	public static byte[] 水抗性头 = new byte[2] { 0, 52 };

	public static byte[] 火抗性头 = new byte[2] { 0, 53 };

	public static byte[] 土抗性头 = new byte[2] { 0, 54 };

	public static byte[] 连击数头 = new byte[2] { 0, 67 };

	public static byte[] 反击数头 = new byte[2] { 0, 69 };

	public static byte[] 反击率头 = new byte[2] { 0, 77 };

	public static byte[] 连击率头 = new byte[2] { 0, 78 };

	public static byte[] 必杀率头 = new byte[2] { 0, 79 };

	public static byte[] 反震度头 = new byte[2] { 0, 80 };

	public static byte[] 门派头 = new byte[2] { 0, 81 };

	public static byte[] 反震率头 = new byte[2] { 0, 85 };

	public static byte[] 形象ID头 = new byte[2] { 0, 86 };

	public static byte[] 破防头 = new byte[2] { 0, 110 };

	public static byte[] 银元宝头 = new byte[2] { 0, 119 };

	public static byte[] 金元宝头 = new byte[2] { 0, 120 };

	public static byte[] 携带金钱上限头 = new byte[2] { 0, 124 };

	public static byte[] 存款金钱上限头 = new byte[2] { 0, 125 };

	public static byte[] 物理吸收头 = new byte[2] { 0, 238 };

	public static byte[] 法术吸收头 = new byte[2] { 0, 239 };

	public static byte[] 攻击效果头 = new byte[2] { 0, 234 };

	public static byte[] 修道点头 = new byte[2] { 1, 129 };

	public static byte[] 仙道点头 = new byte[2] { 1, 50 };

	public static byte[] 魔道点头 = new byte[2] { 1, 51 };

	public static byte[] 代金券头 = new byte[2] { 1, 62 };

	public static byte[] 相性丹药头 = new byte[2] { 1, 133 };

	public static byte[] 强物理头 = new byte[2] { 1, 149 };

	public static byte[] 本月道行头 = new byte[2] { 3, 36 };

	public static byte[] 修为值头 = new byte[2] { 3, 38 };

	public const string 门派师傅1 = "\"master\":\"";

	public const string 门派师傅2 = "\",";

	public const string 角色门派1 = "\"polar\":";

	public const string 角色门派2 = ",\"";

	public const string 角色性别1 = "\"gender\":";

	public const string 角色性别2 = ",\"";

	public const string 原来新旧1 = "\"religion\":";

	public const string 原来新旧2 = ",\"";

	public static string 镶嵌过滤 = "|净心真咒|玄灵真咒|九星真咒|净心神咒|玄灵神咒|九星神咒|无为真咒|空明真咒|八方真咒|无为神咒|空明神咒|八方神咒|符文宝石·蓝玉髓|符文宝石·红玛瑙|符文宝石·羊脂玉|符文宝石·黄龙石|符文宝石·祖母绿|符文宝石·紫袍玉|";

	public static string[] 燃眉星级 = new string[6] { "", "★", "★★", "★★★", "★★★★", "★★★★★" };

	public static List<string[]> 燃眉奖品组 = new List<string[]>
	{
		new string[6] { "珍珠", "珍珠", "珍珠", "珍珠", "珍珠", "珍珠" },
		new string[6] { "珍珠", "珍珠", "珍珠", "玉盘", "金樽", "紫晶" },
		new string[6] { "云珍珠", "云珍珠", "云珍珠", "琼玉盘", "金龙樽", "紫皇晶" },
		new string[6] { "虹珍珠", "虹珍珠", "虹珍珠", "玄玉盘", "金凤樽", "紫帝晶" }
	};

	public static string[] 同源颜色 = new string[6] { "", "#R", "#L", "#M", "#Y", "#G" };

	public const string 仙婴 = "[\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":7008,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":1,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":134,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":1080000,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":7008,]),";

	public const string 魔婴 = "[\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":7009,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":134,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":1080000,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":7009,]),";

	public const string 金 = "\"jindun-shu\":1,\"jingying-zhidao\":1,";

	public const string 木 = "\"mudun-shu\":1,\"jingying-zhidao\":1,";

	public const string 水 = "\"shuidun-shu\":1,\"jingying-zhidao\":1,";

	public const string 火 = "\"huodun-shu\":1,\"jingying-zhidao\":1,";

	public const string 土 = "\"tudun-shu\":1,\"jingying-zhidao\":1,";

	public const string 大飞技能老金 = "\"jinguang-zhaxian\":数值,\"daoguang-jianying\":数值,\"jinhong-guanri\":数值,\"liuguang-yicai\":数值,\"nitian-canren\":数值,\"liulian-wangfan\":数值,\"deyi-wangxing\":数值,\"ruchi-ruzui\":数值,\"rumeng-chuxing\":数值,\"huangruo-geshi\":数值,\"tiansheng-shenli\":数值,\"qichong-douniu\":数值,\"jiuniu-erhu\":数值,\"ruhu-tianyi\":数值,\"liwan-kuanglan\":数值,\"jinbi-huihuang\":数值,\"zhidao-huanglong\":数值,\"jincheng-tangchi\":数值,\"jinfa-fenghun\":数值,";

	public const string 大飞技能老木 = "\"zhaiye-feihua\":数值,\"feiliu-xianshi\":数值,\"pangen-cuojie\":数值,\"luoying-binfen\":数值,\"guiwu-kuteng\":数值,\"jianxie-fenghou\":数值,\"shekou-fengzhen\":数值,\"heding-hongfen\":数值,\"xiewei-shexian\":数值,\"wanyi-shixin\":数值,\"bamiao-zhuzhang\":数值,\"huoshang-jiaoyou\":数值,\"shuizhang-chuangao\":数值,\"honghua-lvye\":数值,\"jinshang-tianhua\":数值,\"luoye-xiaoxiao\":数值,\"manwu-feitian\":数值,\"baidu-buqin\":数值,\"judu-gongxin\":数值,";

	public const string 大飞技能老水 = "\"dishui-chuanshi\":数值,\"yuhen-yunchou\":数值,\"xuanhe-xieshui\":数值,\"nubo-kuangtao\":数值,\"jiaohai-fanjiang\":数值,\"sanjiu-yanhan\":数值,\"tianhan-didong\":数值,\"bingdong-sanchi\":数值,\"jidi-binghan\":数值,\"baoluo-wanxiang\":数值,\"fangwei-dujian\":数值,\"tiegu-zhengzheng\":数值,\"binglai-jiangdang\":数值,\"tongqiang-tiebi\":数值,\"tiandi-hunyuan\":数值,\"shuitian-yise\":数值,\"tiema-binghe\":数值,\"shuangjia-bingdun\":数值,\"xuepiao-wanli\":数值,";

	public const string 大飞技能老火 = "\"juhuo-fentian\":数值,\"xinghuo-liaoyuan\":数值,\"yantian-huoyu\":数值,\"jiaojin-lishi\":数值,\"lianyu-huohai\":数值,\"xinzui-shenmi\":数值,\"shenhun-diandao\":数值,\"hunbu-shoushe\":数值,\"hunqian-mengying\":数值,\"hunbu-futi\":数值,\"shiwan-huoji\":数值,\"xiansheng-duoren\":数值,\"jifeng-xunlei\":数值,\"fengchi-dianche\":数值,\"binggui-shensu\":数值,\"huoshu-yinhua\":数值,\"huifei-yanmie\":数值,\"sanmei-lianxin\":数值,\"lihuo-duopo\":数值,";

	public const string 大飞技能老土 = "\"luotu-feiyan\":数值,\"tumo-chenmai\":数值,\"shanbeng-dilie\":数值,\"tianta-dixian\":数值,\"shipo-tianjing\":数值,\"youxin-wuli\":数值,\"guci-shibi\":数值,\"liushen-wuzhu\":数值,\"dishu-qipo\":数值,\"tianding-sanhun\":数值,\"bianchang-moji\":数值,\"wangfeng-puying\":数值,\"huaxian-weiyi\":数值,\"bishi-jiuxu\":数值,\"yixing-huanying\":数值,\"feisha-zoushi\":数值,\"kaibei-lieshi\":数值,\"xinru-panshi\":数值,\"diwo-nanfen\":数值,";

	public const string 大飞技能新金 = "\"dandao-zhiru\":数值,\"ruibu-kedang\":数值,\"qiandao-wanren\":数值,\"fengmang-bilou\":数值,\"wandao-jinguang\":数值,\"buzhi-suocuo\":数值,\"danzhan-xinjing\":数值,\"jinghun-weiding\":数值,\"zhenhun-suoxin\":数值,\"duoshen-shepo\":数值,\"quanli-yifu\":数值,\"qiguan-changhong\":数值,\"jianba-nuzhang\":数值,\"shiru-pozhu\":数值,\"lipi-xuanhuang\":数值,\"jinbi-huihuang\":数值,\"zhidao-huanglong\":数值,\"jincheng-tangchi\":数值,\"jinfa-fenghun\":数值,";

	public const string 大飞技能新木 = "\"huawu-yefei\":数值,\"yanghua-feiliu\":数值,\"qiufeng-saoye\":数值,\"yiye-puti\":数值,\"tiannv-sanhua\":数值,\"mangci-zaibei\":数值,\"wufu-chongsheng\":数值,\"duru-gusui\":数值,\"jiusi-yisheng\":数值,\"zhetian-biri\":数值,\"ganzhi-ruyi\":数值,\"chunfeng-huayu\":数值,\"runwu-wusheng\":数值,\"tihu-guanding\":数值,\"miaoshou-huichun\":数值,\"luoye-xiaoxiao\":数值,\"manwu-feitian\":数值,\"baidu-buqin\":数值,\"judu-gongxin\":数值,";

	public const string 大飞技能新水 = "\"shuiliu-huaxie\":数值,\"jishui-chengyuan\":数值,\"fengqi-shuiyong\":数值,\"xueyao-bingtian\":数值,\"jiaolong-deshui\":数值,\"dishui-bulou\":数值,\"shengou-bilei\":数值,\"jixue-fengshuang\":数值,\"riyue-hebi\":数值,\"jinghua-shuiyue\":数值,\"tugu-naxin\":数值,\"fanghuan-weiran\":数值,\"hunran-yiti\":数值,\"yuxiao-yunsan\":数值,\"shuihuo-buqin\":数值,\"shuitian-yise\":数值,\"tiema-binghe\":数值,\"shuangjia-bingdun\":数值,\"xuepiao-wanli\":数值,";

	public const string 大飞技能新火 = "\"nujian-lixian\":数值,\"yijian-shuangdiao\":数值,\"jianbu-xufa\":数值,\"xingfei-yunsan\":数值,\"wanjian-chuanxin\":数值,\"xinsuo-shenfeng\":数值,\"chongyuan-diesuo\":数值,\"rufeng-sibi\":数值,\"kunling-suoxin\":数值,\"yunmi-wusuo\":数值,\"jiru-xinghuo\":数值,\"xingchi-dianzou\":数值,\"dianguang-shihuo\":数值,\"feiyun-zhidian\":数值,\"huxiao-fengchi\":数值,\"huoshu-yinhua\":数值,\"huifei-yanmie\":数值,\"sanmei-lianxin\":数值,\"lihuo-duopo\":数值,";

	public const string 大飞技能新土 = "\"tubeng-wajie\":数值,\"chentu-feiyang\":数值,\"yangli-feisha\":数值,\"didong-shanyao\":数值,\"qianyan-wanhe\":数值,\"jinghuang-shicuo\":数值,\"ranshen-luanzhi\":数值,\"shenhun-piaodang\":数值,\"shenyao-yiduo\":数值,\"jingshen-podan\":数值,\"xuxu-shishi\":数值,\"gunong-xuanxu\":数值,\"konghuan-xushi\":数值,\"xukong-huanying\":数值,\"xuwu-piaomiao\":数值,\"feisha-zoushi\":数值,\"kaibei-lieshi\":数值,\"xinru-panshi\":数值,\"diwo-nanfen\":数值,";

	public static byte[] 小助手 = new byte[4] { 0, 0, 0, 100 };

	public static byte[] 无双NPC = new byte[4] { 0, 0, 0, 101 };

	public static byte[] 宠物NPC = new byte[4] { 0, 0, 0, 102 };

	public static byte[] 异兽NPC = new byte[4] { 0, 0, 0, 103 };

	public static byte[] 浮生NPC = new byte[4] { 0, 0, 0, 104 };

	public static byte[] 妙妙NPC = new byte[4] { 0, 0, 0, 105 };

	public static byte[] 洗炼NPC = new byte[4] { 0, 0, 0, 106 };

	public static byte[] 百炼NPC = new byte[4] { 0, 0, 0, 107 };

	public static byte[] 转生NPC = new byte[4] { 0, 0, 0, 110 };

	public const string 属性尾 = "]),";

	public const string 数值尾 = ",";

	public const string 文本尾 = "\\\",";

	public const string 蓝属性 = "229:([";

	public const string 粉属性 = "231:([";

	public const string 黄属性 = "236:([";

	public const string 绿属性 = "234:([";

	public const string 套装属性 = "235:([";

	public const string 封印明属性 = "254:([";

	public const string 封印暗属性 = "241:([";

	public const string 改造属性 = "253:([";

	public static int[] 属性类别组 = new int[16]
	{
		514, 770, 3074, 1026, 2050, 3330, 3586, 2562, 5378, 7170,
		7426, 7682, 7938, 258, 2306, 4610
	};

	public static int[] 首饰次数组 = new int[7] { 0, 0, 1, 3, 7, 15, 31 };

	public const string 装备等级 = "228:";

	public const string 改造等级 = "54:";

	public const string 耐久度 = "35:";

	public const string 赠品 = "226:1,";

	public const string 五系套装 = "224:";

	public const string 查找出品人 = ",206:\\\"";

	public const string 套装等级 = "227:\\\"";

	public const string 装备颜色 = "55:\\\"";

	public const string 出品人 = "206:\\\"";

	public const string 附加说明 = "1:\\\"";

	public const string 共鸣属性 = "272:\\\"";

	public const string open_nimbus = "\\\"open_nimbus\\\":1,";

	public const string 镶嵌属性 = "\"runic_holes\":({";

	public const string 娃娃头 = "10086:\"赠送娃娃:1:0:0::ID:\",";

	public const string 娃娃模版 = "([\"carry\":([]),\"attrib\":([\"food\":100000,\"mood\":100000,\"refresh_stamina_time\":1560346270,\"gender\":2,\"status\":0,\"life\":23962,\"attack_speed\":4,\"combat_mode\":7,\"max_stamina\":200,\"pot\":0,\"max_mood\":100000,\"phy_effect\":100,\"exp_to_next_level\":0,\"level_up_time\":1560364099,\"max_food\":100000,\"str\":力气,\"stamina\":200,\"dex\":灵敏,\"def\":2604,\"icon\":娃娃图片id,娃娃相性\"max_limit_level\":1600,\"repair_ver\":6,\"intimacy\":娃娃亲密度,\"phy_power\":7326,\"capacity\":娃娃潜能点,\"mag_power\":7328,\"str_effect\":100,\"train_process\":0,\"lock_exp\":1,\"birthday\":娃娃生日,\"dodge\":11,\"iid\"::娃娃iid:,\"wisdom\":智慧,娃娃门派\"physique\":体魄,\"rank\":6,\"mana\":1000,\"wit_effect\":100,\"use_skill\":([娃娃技能]),\"name\":\"赠送娃娃\",\"parents\":({\"角色GID\",}),\"level\":等级,\"max_life\":23962,\"exp\":0,\"dex_effect\":100,\"stamina_effect\":100,\"max_mana\":0,\"health\":0,\"portrait\":240020233,]),\"skills\":([娃娃技能]),])";

	public const string 元神合体 = "\"finish_ysht\":1,\"backup_attrib_plan\":([\"wood\":0,\"attrib_already\":([\"total\":0,\"wiz\":0,]),\"earth\":0,\"water\":0,\"polar_point\":0,\"upgrade_magic\":0,\"upgrade_immortal\":0,\"fire\":0,\"attrib_point\":0,\"cur_attrib_plan\":2,\"metal\":0,\"upgrade\":([\"dex\":0,\"attrib_point\":0,\"con\":0,\"str\":0,\"wiz\":0,]),]),\"cur_attrib_plan\":1,";

	public const string 引灵幡技能 = "\"liaodi-xianji\":等级,\"yulu-huanyuan\":等级,\"tianji-shenjia\":等级,\"wuxing-xiangsheng\":等级,\"yaowang-shending\":等级,\"wuxing-xiangfu\":等级,\"ruyou-shenzhu\":等级,\"lingli-zengfu\":等级,\"yiya-huanya\":等级,\"shixue-kuangluan\":等级,\"xieling-futi\":等级,\"shibu-kedang\":等级,\"dadao-lunhui\":等级,\"fali-wubian\":等级,\"tuiling-xuezhou\":等级,\"tianjiang-xiafan\":等级,\"houfa-zhiren\":等级,\"sanyuan-guiyi\":等级,\"duhua-chengkong\":等级,\"youchou-bibao\":等级,\"jingang-zhiqu\":等级,\"nujiao-lianzhan\":等级,\"kexue-qishu\":等级,\"gonggong-mieshi\":等级,\"jinshen-bumie\":等级,\"ruhuan-simeng\":等级,";

	public static string[] 遁术技能 = new string[6] { "", "jindun-shu", "mudun-shu", "shuidun-shu", "huodun-shu", "tudun-shu" };

	public static string[] 二代师尊 = new string[6] { "", "文殊天尊", "云中子", "龙吉公主", "太乙真人", "石矶娘娘" };

	public static string[] 一代师尊 = new string[6] { "", "元始天尊", "准提道人", "西方教主", "太上老君", "通天教主" };

	public const string 金技能 = "\"jinguang-zhaxian\":数值,\"daoguang-jianying\":数值,\"jinhong-guanri\":数值,\"liuguang-yicai\":数值,\"liulian-wangfan\":数值,\"deyi-wangxing\":数值,\"ruchi-ruzui\":数值,\"rumeng-chuxing\":数值,\"tiansheng-shenli\":数值,\"qichong-douniu\":数值,\"jiuniu-erhu\":数值,\"ruhu-tianyi\":数值,";

	public const string 木技能 = "\"zhaiye-feihua\":数值,\"feiliu-xianshi\":数值,\"pangen-cuojie\":数值,\"luoying-binfen\":数值,\"jianxie-fenghou\":数值,\"shekou-fengzhen\":数值,\"heding-hongfen\":数值,\"xiewei-shexian\":数值,\"bamiao-zhuzhang\":数值,\"huoshang-jiaoyou\":数值,\"shuizhang-chuangao\":数值,\"honghua-lvye\":数值,";

	public const string 水技能 = "\"dishui-chuanshi\":数值,\"yuhen-yunchou\":数值,\"xuanhe-xieshui\":数值,\"nubo-kuangtao\":数值,\"sanjiu-yanhan\":数值,\"tianhan-didong\":数值,\"bingdong-sanchi\":数值,\"jidi-binghan\":数值,\"fangwei-dujian\":数值,\"tiegu-zhengzheng\":数值,\"binglai-jiangdang\":数值,\"tongqiang-tiebi\":数值,";

	public const string 火技能 = "\"juhuo-fentian\":数值,\"xinghuo-liaoyuan\":数值,\"yantian-huoyu\":数值,\"jiaojin-lishi\":数值,\"xinzui-shenmi\":数值,\"shenhun-diandao\":数值,\"hunbu-shoushe\":数值,\"hunqian-mengying\":数值,\"shiwan-huoji\":数值,\"xiansheng-duoren\":数值,\"jifeng-xunlei\":数值,\"fengchi-dianche\":数值,";

	public const string 土技能 = "\"luotu-feiyan\":数值,\"tumo-chenmai\":数值,\"shanbeng-dilie\":数值,\"tianta-dixian\":数值,\"youxin-wuli\":数值,\"guci-shibi\":数值,\"liushen-wuzhu\":数值,\"dishu-qipo\":数值,\"bianchang-moji\":数值,\"wangfeng-puying\":数值,\"huaxian-weiyi\":数值,\"bishi-jiuxu\":数值,";

	public const string 金技能125 = "\"jinguang-zhaxian\":数值,\"daoguang-jianying\":数值,\"jinhong-guanri\":数值,\"liuguang-yicai\":数值,\"nitian-canren\":数值,\"liulian-wangfan\":数值,\"deyi-wangxing\":数值,\"ruchi-ruzui\":数值,\"rumeng-chuxing\":数值,\"huangruo-geshi\":数值,\"tiansheng-shenli\":数值,\"qichong-douniu\":数值,\"jiuniu-erhu\":数值,\"ruhu-tianyi\":数值,\"liwan-kuanglan\":数值,\"jinbi-huihuang\":数值,\"zhidao-huanglong\":数值,\"jincheng-tangchi\":数值,\"jinfa-fenghun\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264,";

	public const string 木技能125 = "\"zhaiye-feihua\":数值,\"feiliu-xianshi\":数值,\"pangen-cuojie\":数值,\"luoying-binfen\":数值,\"guiwu-kuteng\":数值,\"jianxie-fenghou\":数值,\"shekou-fengzhen\":数值,\"heding-hongfen\":数值,\"xiewei-shexian\":数值,\"wanyi-shixin\":数值,\"bamiao-zhuzhang\":数值,\"huoshang-jiaoyou\":数值,\"shuizhang-chuangao\":数值,\"honghua-lvye\":数值,\"jinshang-tianhua\":数值,\"luoye-xiaoxiao\":数值,\"manwu-feitian\":数值,\"baidu-buqin\":数值,\"judu-gongxin\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264,";

	public const string 水技能125 = "\"dishui-chuanshi\":数值,\"yuhen-yunchou\":数值,\"xuanhe-xieshui\":数值,\"nubo-kuangtao\":数值,\"jiaohai-fanjiang\":数值,\"sanjiu-yanhan\":数值,\"tianhan-didong\":数值,\"bingdong-sanchi\":数值,\"jidi-binghan\":数值,\"baoluo-wanxiang\":数值,\"fangwei-dujian\":数值,\"tiegu-zhengzheng\":数值,\"binglai-jiangdang\":数值,\"tongqiang-tiebi\":数值,\"tiandi-hunyuan\":数值,\"shuitian-yise\":数值,\"tiema-binghe\":数值,\"shuangjia-bingdun\":数值,\"xuepiao-wanli\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264,";

	public const string 火技能125 = "\"juhuo-fentian\":数值,\"xinghuo-liaoyuan\":数值,\"yantian-huoyu\":数值,\"jiaojin-lishi\":数值,\"lianyu-huohai\":数值,\"xinzui-shenmi\":数值,\"shenhun-diandao\":数值,\"hunbu-shoushe\":数值,\"hunqian-mengying\":数值,\"hunbu-futi\":数值,\"shiwan-huoji\":数值,\"xiansheng-duoren\":数值,\"jifeng-xunlei\":数值,\"fengchi-dianche\":数值,\"binggui-shensu\":数值,\"huoshu-yinhua\":数值,\"huifei-yanmie\":数值,\"sanmei-lianxin\":数值,\"lihuo-duopo\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264,";

	public const string 土技能125 = "\"luotu-feiyan\":数值,\"tumo-chenmai\":数值,\"shanbeng-dilie\":数值,\"tianta-dixian\":数值,\"shipo-tianjing\":数值,\"youxin-wuli\":数值,\"guci-shibi\":数值,\"liushen-wuzhu\":数值,\"dishu-qipo\":数值,\"tianding-sanhun\":数值,\"bianchang-moji\":数值,\"wangfeng-puying\":数值,\"huaxian-weiyi\":数值,\"bishi-jiuxu\":数值,\"yixing-huanying\":数值,\"feisha-zoushi\":数值,\"kaibei-lieshi\":数值,\"xinru-panshi\":数值,\"diwo-nanfen\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264,";

	public const string 新金技能 = "\"dandao-zhiru\":数值,\"ruibu-kedang\":数值,\"qiandao-wanren\":数值,\"fengmang-bilou\":数值,\"buzhi-suocuo\":数值,\"danzhan-xinjing\":数值,\"jinghun-weiding\":数值,\"zhenhun-suoxin\":数值,\"quanli-yifu\":数值,\"qiguan-changhong\":数值,\"jianba-nuzhang\":数值,\"shiru-pozhu\":数值,";

	public const string 新木技能 = "\"huawu-yefei\":数值,\"yanghua-feiliu\":数值,\"qiufeng-saoye\":数值,\"yiye-puti\":数值,\"mangci-zaibei\":数值,\"wufu-chongsheng\":数值,\"duru-gusui\":数值,\"jiusi-yisheng\":数值,\"ganzhi-ruyi\":数值,\"chunfeng-huayu\":数值,\"runwu-wusheng\":数值,\"tihu-guanding\":数值,";

	public const string 新水技能 = "\"shuiliu-huaxie\":数值,\"jishui-chengyuan\":数值,\"fengqi-shuiyong\":数值,\"xueyao-bingtian\":数值,\"dishui-bulou\":数值,\"shengou-bilei\":数值,\"jixue-fengshuang\":数值,\"riyue-hebi\":数值,\"tugu-naxin\":数值,\"fanghuan-weiran\":数值,\"hunran-yiti\":数值,\"yuxiao-yunsan\":数值,";

	public const string 新火技能 = "\"nujian-lixian\":数值,\"yijian-shuangdiao\":数值,\"jianbu-xufa\":数值,\"xingfei-yunsan\":数值,\"xinsuo-shenfeng\":数值,\"chongyuan-diesuo\":数值,\"rufeng-sibi\":数值,\"kunling-suoxin\":数值,\"jiru-xinghuo\":数值,\"xingchi-dianzou\":数值,\"dianguang-shihuo\":数值,\"feiyun-zhidian\":数值,";

	public const string 新土技能 = "\"tubeng-wajie\":数值,\"chentu-feiyang\":数值,\"yangli-feisha\":数值,\"didong-shanyao\":数值,\"jinghuang-shicuo\":数值,\"ranshen-luanzhi\":数值,\"shenhun-piaodang\":数值,\"shenyao-yiduo\":数值,\"xuxu-shishi\":数值,\"gunong-xuanxu\":数值,\"konghuan-xushi\":数值,\"xukong-huanying\":数值,";

	public const string 新金技能125 = "\"dandao-zhiru\":数值,\"ruibu-kedang\":数值,\"qiandao-wanren\":数值,\"fengmang-bilou\":数值,\"wandao-jinguang\":数值,\"buzhi-suocuo\":数值,\"danzhan-xinjing\":数值,\"jinghun-weiding\":数值,\"zhenhun-suoxin\":数值,\"duoshen-shepo\":数值,\"quanli-yifu\":数值,\"qiguan-changhong\":数值,\"jianba-nuzhang\":数值,\"shiru-pozhu\":数值,\"lipi-xuanhuang\":数值,\"jinbi-huihuang\":数值,\"zhidao-huanglong\":数值,\"jincheng-tangchi\":数值,\"jinfa-fenghun\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264,";

	public const string 新木技能125 = "\"huawu-yefei\":数值,\"yanghua-feiliu\":数值,\"qiufeng-saoye\":数值,\"yiye-puti\":数值,\"tiannv-sanhua\":数值,\"mangci-zaibei\":数值,\"wufu-chongsheng\":数值,\"duru-gusui\":数值,\"jiusi-yisheng\":数值,\"zhetian-biri\":数值,\"ganzhi-ruyi\":数值,\"chunfeng-huayu\":数值,\"runwu-wusheng\":数值,\"tihu-guanding\":数值,\"miaoshou-huichun\":数值,\"luoye-xiaoxiao\":数值,\"manwu-feitian\":数值,\"baidu-buqin\":数值,\"judu-gongxin\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264,";

	public const string 新水技能125 = "\"shuiliu-huaxie\":数值,\"jishui-chengyuan\":数值,\"fengqi-shuiyong\":数值,\"xueyao-bingtian\":数值,\"jiaolong-deshui\":数值,\"dishui-bulou\":数值,\"shengou-bilei\":数值,\"jixue-fengshuang\":数值,\"riyue-hebi\":数值,\"jinghua-shuiyue\":数值,\"tugu-naxin\":数值,\"fanghuan-weiran\":数值,\"hunran-yiti\":数值,\"yuxiao-yunsan\":数值,\"shuihuo-buqin\":数值,\"shuitian-yise\":数值,\"tiema-binghe\":数值,\"shuangjia-bingdun\":数值,\"xuepiao-wanli\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264,";

	public const string 新火技能125 = "\"nujian-lixian\":数值,\"yijian-shuangdiao\":数值,\"jianbu-xufa\":数值,\"xingfei-yunsan\":数值,\"wanjian-chuanxin\":数值,\"xinsuo-shenfeng\":数值,\"chongyuan-diesuo\":数值,\"rufeng-sibi\":数值,\"kunling-suoxin\":数值,\"yunmi-wusuo\":数值,\"jiru-xinghuo\":数值,\"xingchi-dianzou\":数值,\"dianguang-shihuo\":数值,\"feiyun-zhidian\":数值,\"huxiao-fengchi\":数值,\"huoshu-yinhua\":数值,\"huifei-yanmie\":数值,\"sanmei-lianxin\":数值,\"lihuo-duopo\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264,";

	public const string 新土技能125 = "\"tubeng-wajie\":数值,\"chentu-feiyang\":数值,\"yangli-feisha\":数值,\"didong-shanyao\":数值,\"qianyan-wanhe\":数值,\"jinghuang-shicuo\":数值,\"ranshen-luanzhi\":数值,\"shenhun-piaodang\":数值,\"shenyao-yiduo\":数值,\"jingshen-podan\":数值,\"xuxu-shishi\":数值,\"gunong-xuanxu\":数值,\"konghuan-xushi\":数值,\"xukong-huanying\":数值,\"xuwu-piaomiao\":数值,\"feisha-zoushi\":数值,\"kaibei-lieshi\":数值,\"xinru-panshi\":数值,\"diwo-nanfen\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264,";

	public const string 法宝共生 = "\"fabao-gongsheng\":1,";

	public const string 急急如律令 = "\"jiji-rulvling\":1,";

	public const string 百级以下模板 = "([\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([\"wood\":0,\"resist_lost\":0,\"durability\":100,\"life\":105,\"cash\":游戏金币,\"pot\":角色潜能,\"religion\":新老角色转换,\"type\":1,\"resist_wood\":0,\"friend_converted\":3,\"con\":角色等级,\"earth\":0,\"reputation\":0,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1569479697,\"resist_poison\":0,\"voucher\":游戏代金卷,\"last_login_time\":1569481420,\"resisit_wood\":0,\"dex\":角色等级,\"store_converted\":1,\"energy\":1500,\"polar\":角色五行相性,\"block_state\":0,\"polar_wood\":0,\"create_time\":1569479696,\"generate_time\":必需替换的时间戳,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"last_login_ip\":\"\",\"resist_metal\":0,\"phy_power\":45,\"anticheater_info\":([\"total_steps\":4,\"interval\":1739,\"last_move_time\":1569481420,]),\"recover_energy_time\":1569481307,\"has_trade_goods\":0,\"max_cash\":21015,\"today_played_time\":12,\"balance\":0,\"fire\":0,\"task\":([243:([\"state\":\"b\",\"ver\":1,]),1000:([\"state\":\"0\",\"ti\":1574665420,\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),644:([\"state\":\"0\",\"upgrade_type\":0,]),614:([\"state\":\"1\",\"st\":1569481200,]),1091:([\"et\":1569772799,\"total\":480,]),1087:([\"ti\":1569481420,\"exp\":2875162,\"tao\":102813,]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1061:([\"et\":1569772799,\"total\":120,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1569427199,\"upgrade_type\":0,]),]),\"title_type_effect\":\"无显示\",\"newbie\":1,\"age\":0,\"resist_lock\":0,\"speed\":226,\"init_basic_info\":1,\"mana\":10000,\"water\":0,\"signature\":\"\",\"name\":\"玩家角色名称\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"protect_bonus\":([\"ti\":1569481420,\"hour\":0,]),\"double_balance\":2,\"attrib_point\":角色属性点,\"resist_fire\":0,\"level\":角色等级,\"resist_frozen\":0,\"max_life\":8154,\"unique_data\":([0:536870912,5:16,2:64,1:67584,]),\"max_mana\":5498,\"tao\":道行,\"soul_cob_rate\":0,\"portrait\":角色图片代码,\"account\":\"角色游戏帐号\",\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1569479698,\"ytd\":([]),\"td\":([\"0\":1569481385,\"4\":500,\"2\":100,\"3\":0,]),]),\"last_login_mac\":\"\",\"resist_earth\":0,\"last_privilege\":300,\"question\":([\"answer_times\":0,]),\"gender\":角色性别,\"max_stamina\":188,\"last_logout_time\":必需替换的时间戳,\"settings\":([\"convert\":1,]),\"polar_water\":0,\"exp_to_next_level\":475592,\"polar_earth\":0,\"gold_coin\":金元宝数量,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1569481420,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"pker\":0,\"resist_forgotten\":0,\"task_round\":([\"962\":0,]),\"cur_ver\":17,\"metal\":0,\"str\":角色等级,\"total_pk\":0,\"wiz\":角色等级,\"max_balance\":45690,\"stamina\":100,\"salary\":([\"online_time\":([\"1569772800\":1738,]),]),\"def\":465,\"polar_fire\":0,\"icon\":角色图片代码,\"max_durability\":100,\"resisit_fire\":0,\"tao_ex\":0,\"resist_repress\":0,\"previous_login_ip\":\"\",\"appellation_ids\":([7:33554432,]),\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"resist_melt\":0,\"mag_power\":485,\"limit_trade_coin\":0,\"title_type\":\"无显示\",\"total_played_time\":1739,\"newbie\":1,\"dodge\":0,\"resist_confusion\":0,\"top_data\":([\"speed\":226,\"def\":465,\"phy_power\":485,\"mag_power\":485,]),\"resisit_water\":0,\"resist_sleep\":0,\"gid\":\"角色GID\",\"first_login_ip\":\"\",\"user_converted\":7,\"max_assign_polar\":30,\"silver_coin\":银元宝数量,\"limit_per_month\":([\"ti\":1569481385,\"11\":1,\"7\":100,\"8\":0,]),\"title_effect\":\"\",\"title\":\"初始称号\",\"polar_point\":58,\"resist_water\":0,\"resisit_metal\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"\",\"max_account_lv\":角色等级,\"wudou\":([\"last_cost_time\":1569168000,]),\"polar_metal\":0,\"logout_time\":必需替换的时间戳,\"exp\":0,\"newbie_gift\":1,\"limit_per_day\":([\"ti\":1569481313,\"93\":1,\"777\":1,\"895\":100,\"783\":1,]),\"scroll\":([\"time\":1569481408,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"insider_time\":315360000,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"\",({76,0,1,}),({37,0,1,}),({57,0,1,}),({41,0,1,}),({33,0,1,}),}),}),\"skills_map\":([]),\"skills\":([\"jingying-zhidao\":1,技能]),])";

	public const string 百级拜师模板 = "([\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([\"wood\":0,\"resist_lost\":0,\"durability\":100,\"life\":10000,\"cash\":游戏金币,\"pot\":角色潜能,\"religion\":新老角色转换,\"type\":1,\"resist_wood\":0,\"master\":\"角色二代祖师\",\"friend_converted\":3,\"con\":角色等级,\"earth\":0,\"reputation\":0,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1569479697,\"resist_poison\":0,\"voucher\":游戏代金卷,\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1569481420,\"resisit_wood\":0,\"dex\":角色等级,\"store_converted\":1,\"energy\":1500,\"polar\":角色五行相性,\"block_state\":0,\"polar_wood\":0,\"create_time\":1569479696,\"generate_time\":必需替换的时间戳,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"last_login_ip\":\"\",\"resist_metal\":0,\"phy_power\":485,\"anticheater_info\":([\"total_steps\":4,\"interval\":1739,\"last_move_time\":1569481420,]),\"recover_energy_time\":1569481307,\"has_trade_goods\":0,\"max_cash\":42030,\"today_played_time\":1739,\"balance\":0,\"fire\":0,\"task\":([243:([\"state\":\"b\",\"ver\":1,]),48:([\"end_time\":1829279214,]),1000:([\"state\":\"0\",\"ti\":1574665420,\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),644:([\"state\":\"0\",\"upgrade_type\":0,]),614:([\"state\":\"1\",\"st\":1569481200,]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"角色GID\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"玩家角色名称\",]),]),]),1091:([\"et\":1569772799,\"total\":480,]),1087:([\"ti\":1569481420,\"exp\":2875162,\"tao\":102813,]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1061:([\"et\":1569772799,\"total\":120,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1569427199,\"upgrade_type\":0,]),]),\"title_type_effect\":\"无显示\",\"age\":0,\"resist_lock\":0,\"speed\":226,\"init_basic_info\":1,\"mana\":10000,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"signature\":\"\",\"name\":\"玩家角色名称\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第二代弟子\",\"protect_bonus\":([\"ti\":1569481420,\"hour\":0,]),\"double_balance\":2,\"attrib_point\":角色属性点,\"resist_fire\":0,\"level\":角色等级,\"resist_frozen\":0,\"max_life\":8154,\"unique_data\":([0:536870912,5:16,2:64,1:67584,]),\"max_mana\":5498,\"tao\":道行,\"soul_cob_rate\":0,\"appellation\":([\"family\":\"角色一代弟子称号\",\"无显示\":\"\",]),\"portrait\":角色图片代码,\"account\":\"角色游戏帐号\",\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1569479698,\"ytd\":([]),\"td\":([\"0\":1569481385,\"4\":500,\"2\":100,\"3\":0,]),]),\"last_login_mac\":\"\",\"resist_earth\":0,\"last_privilege\":300,\"question\":([\"answer_times\":0,]),\"gender\":角色性别,\"max_stamina\":188,\"last_logout_time\":必需替换的时间戳,\"settings\":([\"convert\":1,]),\"polar_water\":0,\"exp_to_next_level\":475592,\"polar_earth\":0,\"gold_coin\":金元宝数量,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1569481420,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"pker\":0,\"resist_forgotten\":0,\"task_round\":([\"962\":0,]),\"cur_ver\":17,\"metal\":0,\"str\":角色等级,\"total_pk\":0,\"wiz\":角色等级,\"max_balance\":45690,\"stamina\":100,\"salary\":([\"online_time\":([\"1569772800\":1738,]),]),\"def\":465,\"polar_fire\":0,\"icon\":角色图片代码,\"max_durability\":100,\"resisit_fire\":0,\"tao_ex\":0,\"resist_repress\":0,\"previous_login_ip\":\"\",\"appellation_ids\":([7:33554432,4:32,]),\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"resist_melt\":0,\"mag_power\":485,\"limit_trade_coin\":0,\"title_type\":\"无显示\",\"total_played_time\":1739,\"newbie\":1,\"dodge\":0,\"resist_confusion\":0,\"top_data\":([\"speed\":226,\"def\":465,\"phy_power\":485,\"mag_power\":485,]),\"resisit_water\":0,\"resist_sleep\":0,\"gid\":\"角色GID\",\"first_login_ip\":\"\",\"user_converted\":7,\"max_assign_polar\":30,\"silver_coin\":银元宝数量,\"limit_per_month\":([\"ti\":1569481385,\"11\":1,\"7\":100,\"8\":0,]),\"title_effect\":\"\",\"family\":\"山门\",\"title\":\"初始称号\",\"polar_point\":58,\"resist_water\":0,\"resisit_metal\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"\",\"max_account_lv\":角色等级,\"wudou\":([\"last_cost_time\":1569168000,]),\"polar_metal\":0,\"logout_time\":必需替换的时间戳,\"exp\":0,\"newbie_gift\":1,\"limit_per_day\":([\"ti\":1569481313,\"93\":1,\"777\":1,\"895\":100,\"783\":1,]),\"scroll\":([\"time\":1569481408,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"insider_time\":315360000,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"\",({76,0,1,}),({37,0,1,}),({57,0,1,}),({41,0,1,}),({33,0,1,}),}),}),\"skills_map\":([]),\"skills\":([\"盾术\":1,\"jingying-zhidao\":1,技能]),])";

	public const string 一25到134模板 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"dijie_finish10\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"dijie_finish10\",\"finished_time\":([\"dijie_finish10\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":10,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":40,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"dijie_finish\":\"夜长梦多\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":10,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"dijie_finish\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";

	public const string 一134到139模板 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie1\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie2\",\"finished_time\":([\"tianjie1\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":11,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":41,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"regal\":100,\"appellation\":([\"family\":\"%s\",\"tianjie\":\"一劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":11,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";

	public const string 一139到144模板 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie2\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie3\",\"finished_time\":([\"tianjie2\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":12,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":42,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"二劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":12,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";

	public const string 一144到149模板 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie3\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie4\",\"finished_time\":([\"tianjie3\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":13,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":43,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"三劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":13,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";

	public const string 一149到154模板 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie4\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie5\",\"finished_time\":([\"tianjie4\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":14,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":44,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"四劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":14,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";

	public const string 一154到159模板 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie5\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie6\",\"finished_time\":([\"tianjie5\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":15,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":45,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"五劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":15,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";

	public const string 一139到165模板 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":242,\"y\":194,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie7\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie8\",\"finished_time\":([\"tianjie7\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":17,\"str\":165,\"total_pk\":0,\"wiz\":165,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":47,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":165,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":165,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":165,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"七劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":17,\"bonus\":1,\"max_level\":165,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":165,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";

	public const string achieve = "([90102:([5:294,4:1557680413,]),60413:([5:0,4:1557680404,]),60414:([5:0,4:1557680404,]),60415:([5:0,4:1557680404,]),70113:([4:1557596605,3:1,]),\"update_ti\":1557677100,10201:([1:1,]),70110:([4:1557596608,3:1,]),\"ver\":2,30169:([1:1,]),10703:([5:0,4:1557596587,]),10702:([5:0,4:1557596587,]),10701:([5:0,4:1557596587,]),30134:([1:1,]),20406:([1:1,]),20407:([5:3,4:1557608768,7:([\"ti\":3486,]),]),30122:([5:1,4:1557611645,]),30121:([1:1,]),51101:([5:5,4:1557677789,7:([\"ti\":216,]),]),51103:([5:0,4:1557596587,]),51102:([5:0,4:1557596587,]),30101:([1:1,]),30107:([1:1,]),\"total\":155,90401:([1:1,]),10505:([5:0,4:1557680404,]),10506:([5:0,4:1557680404,]),40206:([5:0,4:1557680404,7:([]),]),90336:([1:1,]),50403:([1:1,]),50910:([1:1,4:1557596688,]),50909:([1:1,]),90331:([1:1,]),90308:([5:47,4:1557675755,]),90307:([1:1,]),60102:([5:1,4:1557675613,]),60101:([1:1,]),90316:([5:1,4:1557606398,]),90315:([1:1,]),90313:([1:1,]),90314:([5:9,4:1557607101,]),90301:([1:1,]),40105:([5:0,4:1557680404,]),40106:([5:0,4:1557680404,]),\"traces\":({}),20113:([5:0,4:1557610503,]),20114:([5:0,4:1557610503,]),20110:([5:0,4:1557609711,]),20106:([5:0,4:1557610503,]),20102:([5:0,4:1557610503,]),20103:([5:0,4:1557610503,]),20104:([5:0,4:1557610503,]),20101:([1:1,]),90208:([5:1,4:1557605766,]),90215:([1:1,]),90217:([1:1,]),90216:([1:1,]),90218:([1:1,]),90207:([1:1,]),\"lastest\":({90307,10201,60101,}),80404:([5:0,4:1557680404,]),80405:([5:0,4:1557680404,]),80406:([5:0,4:1557680404,]),])";

	public const string item文本_绑定 = "%s:\"%s:([255:36,232:%s,47:%s,\\\"type\\\":8,257:([48:%s,]),])\",";

	public const string item文本_绑定1 = "%s:\"%s:([255:36,232:%s,47:%s,35:%s,\\\"type\\\":8,257:([48:%s,]),])\",";

	public const string carry = "([\"carry\":([道具]),])";

	public const string patch = "([\"pets\":([宠物]),\"guards\":([%s]),\"friends\":([\"5\":([]),\"4\":([]),\"3\":([]),\"2\":([]),\"1\":([]),\"6\":([]),]),\"children\":([%s]),\"practice_children\":([]),\"practice_pets\":([]),])";

	public const string login_Content = "([\"rec_role\":\"%s\",\"create_time\":1556371353,\"chars\":({\"%s\",}),\"safe_status\":0,\"register_time\":0,])";

	public const string 娃娃数据 = "1:\"娃娃:1:0:0::%s:\",";

	public const string DB_娃娃数据 = "([\"carry\":([]),\"attrib\":([\"food\":10000,\"mood\":10000,\"refresh_stamina_time\":1568464012,\"gender\":2,\"status\":0,\"life\":23962,\"attack_speed\":4,\"combat_mode\":7,\"max_stamina\":200,\"pot\":0,\"max_mood\":10000,\"phy_effect\":100,\"exp_to_next_level\":0,\"level_up_time\":1560364099,\"str\":%s,\"max_food\":10000,\"stamina\":200,\"dex\":%s,\"def\":2604,\"icon\":7015,\"max_limit_level\":165,\"lock_exp\":0,\"repair_ver\":6,\"intimacy\":%s,\"phy_power\":7326,\"capacity\":%s,\"mag_power\":7328,\"train_process\":0,\"str_effect\":100,\"birthday\":%s,\"dodge\":11,\"iid\"::%s:,\"rank\":6,\"physique\":%s,\"wisdom\":%s,\"wit_effect\":100,\"mana\":1000,\"use_skill\":([]),\"name\":\"[名字]娃娃\",\"parents\":({\"%s\",}),\"level\":%s,\"max_life\":23962,\"stamina_effect\":100,\"dex_effect\":100,\"exp\":0,\"max_mana\":0,\"health\":0,\"portrait\":7015,]),\"skills\":([]),])";

	public const string 守护数据 = "0:\"0:([\\\"attrib\\\":([106:2,107:12409,108:91954,104:2,76:5,72:5004,68:1302716,67:%s,66:6171,64:0,75:34,71:20,69:6100,53:0,52:110,51:34277,49:495,48:236555,63:165,62:4,61:5004,60:0,58:0,57:0,56:0,55:2,47:0,44:165,37:34277,36:2171,35:5,33::%s:,22:30868,21:59039,16:18921,31:190,5:420,3:360,2:236555,]),])\",";

	public const string 天生技能组 = "|翻转乾坤|神圣之光|如意圈|游说之舌|漫天血舞|舍命一击|乾坤罩|神龙罩|死亡缠绵|法力护盾|人宠合体|解除合体|移花接木|五色光环|舍身取义|";

	public const string 心法技能组 = "|破龙之击=1410|乘胜追击=1412|生命汲取=1413|撕裂伤口=1414|防不胜防=1417|解意之击=1429|法术汲取=1430|抵消法必=1431|抵消混元=1432|伤害反馈=1442|抵消番天=1433|汲取法力=1447|物理免死=1436|法术免死=1437|天技回生=1444|";
}
