using System.Collections.Generic;

public class 宠物突破配置类
{
	public string 忠诚储备道具 = string.Empty;

	public int 忠诚储备数量;

	public int 忠诚储备上限;

	public string 武学突破道具 = "武学破障丹";

	public int 增加武学数值 = 10000;

	public int 使用武学上限 = 100000000;

	public string 飞升突破道具 = "宠物飞升丹";

	public int 最低使用等级 = 1;

	public int 最高使用等级 = 999;

	public int 强化最低上限;

	public int 强化最高上限 = 12;

	public string 法攻强化道具 = "法攻强化丹";

	public string 物攻强化道具 = "物攻强化丹";

	public bool Is禁止普通强化 = true;

	public bool Is禁止变异强化 = true;

	public bool Is禁止神兽强化 = true;

	public bool Is禁止元灵强化 = true;

	public bool Is禁止仙元强化 = true;

	public List<int> 强化进度组 = new List<int>();

	public int 变异强化进度倍数 = 1;

	public int 神兽强化进度倍数 = 1;

	public int 元灵强化进度倍数 = 1;

	public int 仙元强化进度倍数 = 1;

	public int 幻化最低上限;

	public int 幻化最高上限 = 12;

	public string 血量幻化道具 = "血量幻化丹";

	public string 法力幻化道具 = "法力幻化丹";

	public string 速度幻化道具 = "速度幻化丹";

	public string 物攻幻化道具 = "物攻幻化丹";

	public string 法攻幻化道具 = "法攻幻化丹";
}
