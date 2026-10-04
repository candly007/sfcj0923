using System.Collections.Generic;

public class 功能授权类
{
	public List<bool> 授权状态 = new List<bool>();

	public bool IsVip = true;

	public bool Is测试卡 = false;

	public bool Is智能BOSS = true;

	public bool Is完美力魄 = true;

	public bool Is在线洗炼 = true;

	public bool Is在线商城 = true;

	public bool Is装备分解 = true;

	public bool Is一四怀旧 = true;

	public bool Is神级掉落 = true;

	public bool Is装备强化 = true;

	public bool Is超进化 = true;

	public bool Is单奇宝斋 = true;

	public bool Is点卡功能 = true;

	public bool Is特效系统 = true;

	public bool Is摆摊系统 = true;

	public bool Is定制道具 = true;

	public bool Is天机神算 = true;

	public bool Is鸿运当头 = true;

	public bool Is专属合区 = true;

	public bool Is验证注册 = true;

	public bool Is娃娃系统 = true;

	public bool Is简化版本 = true;

	public bool Is日常功能 = true;

	public bool Is定制异兽 = true;

	public bool Is定制浮生 = true;

	public bool Is定制六道 = true;

	public bool Is巅峰对决 = true;

	public bool Is道友挖宝 = true;

	public bool IsLGL定制 = true;

	public bool Is道北砍尾 = true;

	public bool Is内充支付 = true;

	public void 更新(List<bool> 授权列表, string 插件类型 = "")
	{
		IsVip = true;
		Is测试卡 = false;
		Is智能BOSS = true;
		Is完美力魄 = true;
		Is在线洗炼 = true;
		Is在线商城 = true;
		Is装备分解 = true;
		Is一四怀旧 = true;
		Is神级掉落 = true;
		Is装备强化 = true;
		Is超进化 = true;
		Is单奇宝斋 = true;
		Is点卡功能 = true;
		Is特效系统 = true;
		Is摆摊系统 = true;
		Is定制道具 = true;
		Is天机神算 = true;
		Is鸿运当头 = true;
		Is专属合区 = true;
		Is验证注册 = true;
		Is娃娃系统 = true;
		Is简化版本 = true;
		Is日常功能 = true;
		Is定制异兽 = true;
		Is定制浮生 = true;
		Is定制六道 = true;
		Is巅峰对决 = true;
		Is道友挖宝 = true;
		IsLGL定制 = true;
		Is道北砍尾 = true;
		Is内充支付 = true;
	}
}
