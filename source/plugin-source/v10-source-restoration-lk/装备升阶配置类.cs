using System.Collections.Concurrent;

public class 装备升阶配置类
{
	public bool 功能开关;

	public bool Is等级要求;

	public int 最低等级;

	public bool Is道行要求;

	public int 最低道行;

	public bool Is装备等级要求;

	public int 最低装备等级;

	public bool Is改造要求;

	public int 最低改造;

	public ConcurrentDictionary<AllEnums.Equip类型, bool> 装备升阶类型 = new ConcurrentDictionary<AllEnums.Equip类型, bool>();

	public ConcurrentDictionary<AllEnums.元神境界, 升阶需求类> 需求字典 = new ConcurrentDictionary<AllEnums.元神境界, 升阶需求类>();

	public ConcurrentDictionary<AllEnums.属性名字Type, int[]> 属性字典 = new ConcurrentDictionary<AllEnums.属性名字Type, int[]>();
}
