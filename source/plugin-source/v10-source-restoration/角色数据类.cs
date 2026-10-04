using System.Runtime.CompilerServices;

public class 角色数据类
{
	public 人物基础数据类 人物数据;

	public 人物属性数据类 属性数据;

	public 属性缓存数据类 附加数据;

	public 属性缓存数据类 属性总值;

	public 人物背包数据类 背包数据;

	public 人物缓存数据类 缓存数据;

	public 宠物缓存数据类[] 宠物数据;

	public 娃娃缓存数据类[] 娃娃数据;

	public 人物队伍数据类 队伍数据;

	public 人物技能数据类 技能数据;

	public 角色存档数据类 存档数据;

	
	public 角色数据类()
	{
		人物数据 = new 人物基础数据类();
		属性数据 = new 人物属性数据类();
		背包数据 = new 人物背包数据类();
		缓存数据 = new 人物缓存数据类();
		宠物数据 = new 宠物缓存数据类[8]
		{
			new 宠物缓存数据类(),
			new 宠物缓存数据类(),
			new 宠物缓存数据类(),
			new 宠物缓存数据类(),
			new 宠物缓存数据类(),
			new 宠物缓存数据类(),
			new 宠物缓存数据类(),
			new 宠物缓存数据类()
		};
		娃娃数据 = new 娃娃缓存数据类[6]
		{
			new 娃娃缓存数据类(),
			new 娃娃缓存数据类(),
			new 娃娃缓存数据类(),
			new 娃娃缓存数据类(),
			new 娃娃缓存数据类(),
			new 娃娃缓存数据类()
		};
		队伍数据 = new 人物队伍数据类();
		技能数据 = new 人物技能数据类();
		存档数据 = new 角色存档数据类();
	}

	static 角色数据类()
	{
	}
}
