using System;

public class 宠物缓存数据类
{
	public int 宠物ID;

	public int PetID;

	public string IID = string.Empty;

	public string 昵称A = string.Empty;

	public string 昵称B = string.Empty;

	public short 相性;

	public byte 类型;

	public int 头像;

	public short 等级;

	public short 缓存等级;

	public int 亲密;

	public int 武学;

	public int 速度;

	public byte 阶级;

	public int 成长;

	public int 总成长;

	public short 血量成长;

	public short 法力成长;

	public short 速度成长;

	public short 物理成长;

	public short 法术成长;

	public int 总成长2;

	public short 血量成长2;

	public short 法力成长2;

	public short 速度成长2;

	public short 物理成长2;

	public short 法术成长2;

	public bool is风灵丸;

	public byte[] 封包备份 = Array.Empty<byte>();

	public int 发送次数;

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
		亲密 = 0;
		武学 = 0;
		速度 = 0;
		阶级 = 0;
		成长 = 0;
		总成长 = 0;
		血量成长 = 0;
		法力成长 = 0;
		速度成长 = 0;
		物理成长 = 0;
		法术成长 = 0;
		总成长2 = 0;
		血量成长2 = 0;
		法力成长2 = 0;
		速度成长2 = 0;
		物理成长2 = 0;
		法术成长2 = 0;
		is风灵丸 = false;
		封包备份 = Array.Empty<byte>();
		发送次数 = 0;
	}
}
