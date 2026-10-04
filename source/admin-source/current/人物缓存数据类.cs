using System;
using System.Collections.Concurrent;
using System.Text;

public class 人物缓存数据类
{
	public string 上半部分卡密 = string.Empty;

	public int Server心跳;

	public byte[] 截取时间 = Array.Empty<byte>();

	public bool GM在线号;

	public int 当前乘骑坐骑id;

	public int 当前参战宠物id;

	public int 切换装备时间;

	public byte[] 房屋ID = Array.Empty<byte>();

	public byte[] 自身显示封包备份 = Array.Empty<byte>();

	public short 战斗回合数;

	public bool is坐骑风灵丸;

	public bool is坐骑助阵;

	public bool is指定会员;

	public bool is会员卡;

	public int 当前会员天数;

	public string 穿戴时装名 = string.Empty;

	public string 自选道具 = string.Empty;

	public bool is南极大额;

	public string 几代弟子文本 = string.Empty;

	public int 几代弟子;

	public int 活跃值;

	public AllEnums.CdkType cdk类型;

	public DateTime 上次请求兑换时间 = DateTime.MinValue;

	public StringBuilder 所有称号文本 = new StringBuilder();

	public bool is加点方案一 = true;

	public string 当前战斗BOSS名字;

	public bool is战斗中;

	public int 战斗结束时间戳;

	public string 当前原坐姿id = string.Empty;

	public bool is异兽录操作;

	public DateTime endNpc点击时间 = DateTime.MinValue;

	public long end对话点击时间;

	public DateTime end道具使用时间 = DateTime.MinValue;

	public int 使用特殊道具时间戳;

	public bool is领取特权分红;

	public bool is队伍中 = true;

	public bool is扣除标识;

	public bool is首次登录;

	public bool is是否使用寻宝令;

	public string 宠物绑定道具 = string.Empty;

	public bool is战斗逃跑指令;

	public bool is试道参与奖领取;

	public bool is同源自动转属;

	public string 染色坐姿key = string.Empty;

	public int 燃煤计数器;

	public ConcurrentDictionary<int, 洗炼属性缓存数据类> 洗炼属性数据 = new ConcurrentDictionary<int, 洗炼属性缓存数据类>();

	public bool Is自动洗炼;

	public 无双缓存数据类 无双缓存数据 = new 无双缓存数据类();

	public int 战斗角色模型;

	public int 战斗武器模型;

	public int 战斗坐姿模型;

	public int 战斗坐骑模型;

	public string family = string.Empty;

	public string 战斗铭牌文本 = string.Empty;

	public byte[] 战斗状态标识 = Array.Empty<byte>();

	public byte[] 初始战斗数据包 = Array.Empty<byte>();

	public byte[] 实时战斗buff包 = Array.Empty<byte>();

	public ConcurrentDictionary<string, bool> 战斗成员字典 = new ConcurrentDictionary<string, bool>();
}
