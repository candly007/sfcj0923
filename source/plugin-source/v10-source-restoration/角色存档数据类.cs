using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class 角色存档数据类
{
	public int GID;

	public string 昵称;

	public string 账号;

	public int 等级;

	public int 排行数据_等级;

	public int 累计充值_积分;

	public bool is防摆摊状态;

	public int 累计充值金额;

	public int 总累充金额数;

	public int 累计充值_奖励领取情况;

	public int 南极抽奖次数;

	public 燃眉之急任务类 燃眉之急任务;

	public 染色数据类 染色数据;

	public int 凤仙花数量;

	public string 几代弟子;

	public int 本月道行;

	public int 原本道行;

	public int 在线时间;

	public string 最后上线时间;

	public string 最后下线时间;

	public 召唤数据类 召唤数据;

	public string 道行奖励领取阶段;

	public int 首登礼包领取阶段;

	public int 指定会员到期时间戳;

	public int 上次牌面时间;

	public bool Is元神合体;

	public bool is摆摊中;

	public bool is使用新手大礼包;

	public bool Is试道奖励领取;

	public int 已打通天塔次数;

	public int 通天塔额外次数;

	public bool[] 指定活跃奖励领取;

	public ConcurrentDictionary<string, 挑战BOSS数据类> 挑战BOSS数据;

	public bool is每日首冲领取;

	public bool is指定会员每日奖励;

	public List<限购商城数据类> 限购商城数据;

	public int 每周分红领取时间;

	public string 排行数据_门派;

	public int 通天塔突破层数;

	public string 通天塔突破领取;

	public 轮回转世数据类 轮回转世数据;

	public 异兽录数据类 异兽录数据;

	public 无双圣榜数据类 无双圣榜数据;

	public 推荐拉人数据类 推荐拉人数据;

	public List<超级道具数据类> 超级道具数据;

	public ConcurrentDictionary<AllEnums.属性Type, 限时属性类> 限时属性数据;

	public string 账号注册QQ;

	public bool is首登邮箱状态;

	public 浮生录数据类 浮生录数据;

	public ConcurrentQueue<乾坤袋数据类> 乾坤袋列表;

	public 中州论道存档类 中州论道存档;

	public 妖族化形数据类 妖族化形数据;

	public 签到存档类 签到数据;

	public 奇宝斋存档类 奇宝斋存档;

	public 融丹存档类 融丹存档;

	public int 在线抽奖次数;

	public ConcurrentQueue<string> 邮箱存档;

	public ConcurrentDictionary<string, 地府购买存档类> 地府购买存档;

	public 数值存档类 数值存档;

	public 精炼存档类 精炼存档;

	public 点卡存档类 点卡存档;

	public int 摊位ID;

	public int 摊位现金;

	public bool Is清空相性;

	public ConcurrentDictionary<AllEnums.日常类型Type, 日常存档类> 日常存档;

	public 元神存档类 元神存档;

	
	public void 清空()
	{
		累计充值_积分 = 0;
		累计充值金额 = 0;
		总累充金额数 = 0;
		累计充值_奖励领取情况 = 0;
		南极抽奖次数 = 0;
		凤仙花数量 = 0;
		召唤数据.变异珠 = 0;
		召唤数据.神兽珠 = 0;
		召唤数据.元灵珠 = 0;
		召唤数据.仙元珠 = 0;
		召唤数据.御灵珠 = 0;
		道行奖励领取阶段 = string.Empty;
		首登礼包领取阶段 = 0;
		已打通天塔次数 = 0;
		通天塔额外次数 = 0;
		签到数据.累计签到天数 = 0;
		签到数据.累计领取天数 = 0;
		签到数据.本日是否签到 = false;
		奇宝斋存档.奇宝斋余额 = 0;
		在线抽奖次数 = 0;
		邮箱存档.Clear();
		日常存档.Clear();
		精炼存档.精炼计数字典.Clear();
		摊位ID = 0;
		摊位现金 = 0;
	}

	
	public 角色存档数据类()
	{
		昵称 = string.Empty;
		账号 = string.Empty;
		燃眉之急任务 = new 燃眉之急任务类();
		染色数据 = new 染色数据类();
		几代弟子 = string.Empty;
		原本道行 = -1;
		最后上线时间 = string.Empty;
		最后下线时间 = string.Empty;
		召唤数据 = new 召唤数据类();
		道行奖励领取阶段 = string.Empty;
		指定活跃奖励领取 = new bool[6];
		挑战BOSS数据 = new ConcurrentDictionary<string, 挑战BOSS数据类>();
		限购商城数据 = new List<限购商城数据类>();
		排行数据_门派 = string.Empty;
		通天塔突破领取 = string.Empty;
		轮回转世数据 = new 轮回转世数据类();
		异兽录数据 = new 异兽录数据类();
		无双圣榜数据 = new 无双圣榜数据类();
		推荐拉人数据 = new 推荐拉人数据类();
		超级道具数据 = new List<超级道具数据类>();
		限时属性数据 = new ConcurrentDictionary<AllEnums.属性Type, 限时属性类>();
		账号注册QQ = string.Empty;
		浮生录数据 = new 浮生录数据类();
		乾坤袋列表 = new ConcurrentQueue<乾坤袋数据类>();
		中州论道存档 = new 中州论道存档类();
		妖族化形数据 = new 妖族化形数据类();
		签到数据 = new 签到存档类();
		奇宝斋存档 = new 奇宝斋存档类();
		融丹存档 = new 融丹存档类();
		邮箱存档 = new ConcurrentQueue<string>();
		地府购买存档 = new ConcurrentDictionary<string, 地府购买存档类>();
		数值存档 = new 数值存档类();
		精炼存档 = new 精炼存档类();
		点卡存档 = new 点卡存档类();
		日常存档 = new ConcurrentDictionary<AllEnums.日常类型Type, 日常存档类>();
		元神存档 = new 元神存档类();
	}

	static 角色存档数据类()
	{
	}
}
