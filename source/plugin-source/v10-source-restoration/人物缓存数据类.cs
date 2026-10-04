using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

public class 人物缓存数据类
{
	public 支付数据类 支付数据;

	public string 上半部分卡密;

	public int Server心跳;

	public byte[] 截取时间;

	public bool GM在线号;

	public int 当前乘骑坐骑id;

	public int 当前参战宠物id;

	public int 当前掠阵宠物id;

	public int 切换装备时间;

	public long 神算请求时间;

	public byte[] 房屋ID;

	public byte[] 自身显示封包备份;

	public short 战斗回合数;

	public bool is坐骑风灵丸;

	public bool is坐骑助阵;

	public bool is会员卡;

	public int 当前会员天数;

	public string 穿戴时装名;

	public string 自选道具;

	public bool is南极大额;

	public string 几代弟子文本;

	public int 几代弟子;

	public int 活跃值;

	public AllEnums.CdkType cdk类型;

	public DateTime 上次请求兑换时间;

	public StringBuilder 所有称号文本;

	public bool is加点方案一;

	public string 当前战斗BOSS名字;

	public string 当前点击NPC名字;

	public bool is战斗中;

	public bool is观战中;

	public bool is使用仙灵卡;

	public int 战斗结束时间戳;

	public string 当前原坐姿id;

	internal int X4j8zimpds;

	internal int pexIuRNo9u;

	public bool is异兽录操作;

	internal Stopwatch l9XIwuUeoO;

	public DateTime endNpc点击时间;

	public DateTime end道具使用时间;

	public DateTime end道具丢弃时间;

	public long BOSS请求战斗时间;

	public int 道具丢弃个数;

	public int 使用特殊道具时间戳;

	public bool is领取特权分红;

	public bool Is切图;

	public bool is队伍中;

	public bool is扣除标识;

	public bool is首次登录;

	public bool is是否使用寻宝令;

	public bool Is自动使用道具;

	public string 宠物绑定道具;

	public bool is商城刷新;

	public bool is战斗逃跑指令;

	public bool is同源自动转属;

	public bool Is梭子刷新属性;

	public bool Is等级调整;

	public bool Is燃煤葫芦;

	public int Is首次穿戴梭子;

	public int Is摆摊购买金钱记录;

	public bool Is五雷令;

	public 打开摊位数据类 打开摊位数据;

	public string 染色坐姿key;

	public int 燃煤计数器;

	public ConcurrentDictionary<int, 洗炼属性缓存数据类> 洗炼属性数据;

	public bool Is自动洗炼;

	public 无双缓存数据类 无双缓存数据;

	public int 战斗角色模型;

	public int 战斗武器模型;

	public int 战斗坐姿模型;

	public int 战斗坐骑模型;

	public string family;

	public string 战斗铭牌文本;

	public byte[] 战斗状态标识;

	public byte[] 初始战斗我方数据包;

	public byte[] 初始战斗敌方数据包;

	public byte[] 实时战斗buff包;

	public ConcurrentDictionary<string, bool> 战斗成员字典;

	public long 喂养时间戳;

	public int 超级进化格子;

	public ConcurrentDictionary<string, string> 任务缓存字典;

	public bool Is指定会员
	{
		
		get
		{
			if (Singleton<全局变量类>.I.指定会员配置.功能开关)
			{
				return Singleton<ByteAPI>.I.寻找文本(所有称号文本.ToString(), "|" + Singleton<全局变量类>.I.指定会员配置.指定称号 + "|");
			}
			return false;
		}
	}

	
	public 人物缓存数据类()
	{
		支付数据 = new 支付数据类();
		上半部分卡密 = string.Empty;
		截取时间 = Array.Empty<byte>();
		房屋ID = Array.Empty<byte>();
		自身显示封包备份 = Array.Empty<byte>();
		穿戴时装名 = string.Empty;
		自选道具 = string.Empty;
		几代弟子文本 = string.Empty;
		上次请求兑换时间 = DateTime.MinValue;
		所有称号文本 = new StringBuilder();
		is加点方案一 = true;
		当前战斗BOSS名字 = "-1";
		当前点击NPC名字 = string.Empty;
		当前原坐姿id = string.Empty;
		l9XIwuUeoO = Stopwatch.StartNew();
		endNpc点击时间 = DateTime.MinValue;
		end道具使用时间 = DateTime.UtcNow;
		end道具丢弃时间 = DateTime.UtcNow;
		Is切图 = true;
		is队伍中 = true;
		宠物绑定道具 = string.Empty;
		Is摆摊购买金钱记录 = -1;
		打开摊位数据 = new 打开摊位数据类();
		染色坐姿key = string.Empty;
		洗炼属性数据 = new ConcurrentDictionary<int, 洗炼属性缓存数据类>();
		无双缓存数据 = new 无双缓存数据类();
		family = string.Empty;
		战斗铭牌文本 = string.Empty;
		战斗状态标识 = Array.Empty<byte>();
		初始战斗我方数据包 = Array.Empty<byte>();
		初始战斗敌方数据包 = Array.Empty<byte>();
		实时战斗buff包 = Array.Empty<byte>();
		战斗成员字典 = new ConcurrentDictionary<string, bool>();
		任务缓存字典 = new ConcurrentDictionary<string, string>();
	}

	static 人物缓存数据类()
	{
	}
}
