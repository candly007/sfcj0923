using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

public class 宠物缓存数据类
{
	public int 宠物ID;

	public int PetID;

	public string IID;

	public string 昵称A;

	public string 昵称B;

	public short 相性;

	public byte 类型;

	public AllEnums.绑定Type 绑定状态;

	public int 头像;

	public short 等级;

	public short 缓存等级;

	public int 寿命;

	public int 亲密;

	public int 忠诚度;

	public int 武学;

	public int 经验;

	public int 速度;

	public byte 阶级;

	public int 成长;

	public int 总成长;

	public short 血量成长;

	public short 法力成长;

	public short 速度成长;

	public short 物攻成长;

	public short 法攻成长;

	public int 基础总成长;

	public short 基础血量成长;

	public short 基础法力成长;

	public short 基础速度成长;

	public short 基础物攻成长;

	public short 基础法攻成长;

	public bool is风灵丸;

	public byte[] 封包备份;

	public int 发送次数;

	public int 反震度;

	public int 血量幻化次数;

	public int 法力幻化次数;

	public int 速度幻化次数;

	public int 物攻幻化次数;

	public int 法攻幻化次数;

	public int 飞升;

	public int 法攻强化次数;

	public int 物攻强化次数;

	public int 法攻强化进度;

	public int 物攻强化进度;

	public int 坐骑增加法攻;

	public int 坐骑增加物攻;

	public int 坐骑增加防御;

	public int 坐骑增加仙属;

	public int 坐骑增加魔属;

	public short 坐骑增加所属;

	public int 坐骑持续时间;

	public int 提高移动速度;

	public ConcurrentDictionary<string, int> 技能列表;

	
	public void 初始化()
	{
		宠物ID = 0;
		PetID = 0;
		IID = string.Empty;
		昵称A = string.Empty;
		昵称B = string.Empty;
		相性 = 0;
		类型 = 0;
		头像 = 0;
		等级 = 0;
		缓存等级 = 0;
		绑定状态 = AllEnums.绑定Type.不绑定;
		寿命 = 0;
		亲密 = 0;
		忠诚度 = 0;
		武学 = 0;
		经验 = 0;
		速度 = 0;
		阶级 = 0;
		成长 = 0;
		总成长 = 0;
		血量成长 = 0;
		法力成长 = 0;
		速度成长 = 0;
		物攻成长 = 0;
		法攻成长 = 0;
		基础总成长 = 0;
		基础血量成长 = 0;
		基础法力成长 = 0;
		基础速度成长 = 0;
		基础物攻成长 = 0;
		基础法攻成长 = 0;
		is风灵丸 = false;
		封包备份 = Array.Empty<byte>();
		发送次数 = 0;
		反震度 = 0;
		血量幻化次数 = 0;
		法力幻化次数 = 0;
		速度幻化次数 = 0;
		物攻幻化次数 = 0;
		法攻幻化次数 = 0;
		飞升 = 0;
		法攻强化次数 = 0;
		物攻强化次数 = 0;
		法攻强化进度 = 0;
		物攻强化进度 = 0;
		技能列表.Clear();
		坐骑增加法攻 = 0;
		坐骑增加物攻 = 0;
		坐骑增加防御 = 0;
		坐骑增加仙属 = 0;
		坐骑增加魔属 = 0;
		坐骑持续时间 = 0;
		提高移动速度 = 0;
		坐骑增加所属 = 0;
	}

	
	internal bool iQFIbnJHxG(int P_0)
	{
		if (P_0 == 0)
		{
			return false;
		}
		if (P_0 != 宠物ID)
		{
			return false;
		}
		return is风灵丸;
	}

	
	public 宠物缓存数据类()
	{
		IID = string.Empty;
		昵称A = string.Empty;
		昵称B = string.Empty;
		绑定状态 = AllEnums.绑定Type.不绑定;
		封包备份 = Array.Empty<byte>();
		技能列表 = new ConcurrentDictionary<string, int>();
	}

	static 宠物缓存数据类()
	{
	}
}
