using System.Runtime.CompilerServices;

public class 支付数据类
{
	public string 支付单号;

	public bool 支付中;

	public string 支付项目;

	public AllEnums.项目类型 项目Type;

	public string 游戏账号;

	public string 角色昵称;

	public int GID;

	public AllEnums.数值Type 购买物品类型;

	public string 购买物品名字;

	public int 购买物品数量;

	public int 购买物品总价;

	public AllEnums.支付类型 支付Type;

	public string 二维码地址;

	public string 物品编号;

	
	public 支付数据类()
	{
		支付单号 = string.Empty;
		支付项目 = string.Empty;
		游戏账号 = string.Empty;
		角色昵称 = string.Empty;
		购买物品名字 = string.Empty;
		二维码地址 = string.Empty;
		物品编号 = string.Empty;
	}

	static 支付数据类()
	{
	}
}
