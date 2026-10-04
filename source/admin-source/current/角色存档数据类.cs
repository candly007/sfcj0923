using System.Collections.Concurrent;
using System.Collections.Generic;

public class 角色存档数据类
{
	public int GID;

	internal string 昵称 = string.Empty;

	public string 账号 = string.Empty;

	public int 等级;

	public int 排行数据_等级;

	public int 累计充值_积分;

	public bool is防摆摊状态;

	public int 累计充值金额;

	public int 总累充金额数;

	public int 累计充值_奖励领取情况;

	public int 南极抽奖次数;

	public 燃眉之急任务类 燃眉之急任务 = new 燃眉之急任务类();

	public 染色数据类 染色数据 = new 染色数据类();

	public int 凤仙花数量;

	public string 几代弟子 = string.Empty;

	public int 本月道行;

	public int 原本道行 = -1;

	public int 在线时间;

	public string 最后上线时间 = string.Empty;

	public string 最后下线时间 = string.Empty;

	public 召唤数据类 召唤数据 = new 召唤数据类();

	public string 道行奖励领取阶段 = string.Empty;

	public int 首登礼包领取阶段;

	public int 指定会员到期时间戳;

	public bool Is元神合体;

	public bool is摆摊中;

	public bool is使用新手大礼包;

	public int 已打通天塔次数;

	public int 通天塔额外次数;

	public bool[] 指定活跃奖励领取 = new bool[6];

	public ConcurrentDictionary<string, 挑战BOSS数据类> 挑战BOSS数据 = new ConcurrentDictionary<string, 挑战BOSS数据类>();

	public bool is每日首冲领取;

	public bool is指定会员每日奖励;

	public List<限购商城数据类> 限购商城数据 = new List<限购商城数据类>();

	public int 每周分红领取时间;

	public string 排行数据_门派 = string.Empty;

	public int 通天塔突破层数;

	public string 通天塔突破领取 = string.Empty;

	public 轮回转世数据类 轮回转世数据 = new 轮回转世数据类();

	public 异兽录数据类 异兽录数据 = new 异兽录数据类();

	public 无双圣榜数据类 无双圣榜数据 = new 无双圣榜数据类();

	public 推荐拉人数据类 推荐拉人数据 = new 推荐拉人数据类();

	public List<超级道具数据类> 超级道具数据 = new List<超级道具数据类>();

	public ConcurrentDictionary<AllEnums.属性Type, 限时属性类> 限时属性数据 = new ConcurrentDictionary<AllEnums.属性Type, 限时属性类>();

	public string 账号注册QQ = string.Empty;

	public bool is首登邮箱状态;

	public 浮生录数据类 浮生录数据 = new 浮生录数据类();

	public ConcurrentQueue<乾坤袋数据类> 乾坤袋列表 = new ConcurrentQueue<乾坤袋数据类>();

	public 额外附加属性类 额外附加属性 = new 额外附加属性类();

	public 妖族化形数据类 妖族化形数据 = new 妖族化形数据类();

	public 签到存档类 签到数据 = new 签到存档类();

	public 奇宝斋存档类 奇宝斋存档 = new 奇宝斋存档类();

	public int 在线抽奖次数;

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
	}
}
