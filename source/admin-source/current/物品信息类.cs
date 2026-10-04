using System;
using Net.System;

public class 物品信息类
{
	public int Index;

	public string 名字 = string.Empty;

	public string 别名 = string.Empty;

	public string 前缀 = string.Empty;

	public string 单位 = string.Empty;

	public string 描述 = string.Empty;

	public string 改造人 = string.Empty;

	public int 数量;

	public byte 等级;

	public int 物品ID;

	public int 图标;

	public int 装备天伤;

	public int 绑定气血;

	public int 绑定法力;

	public int 当前耐久度;

	public int 最大耐久度;

	public byte 物品类型;

	public string 物品颜色 = string.Empty;

	public bool 是否绑定;

	public byte[] 封包缓存 = Array.Empty<byte>();

	public int 首饰可转换次数;

	public int 首饰已转换次数;

	public int 装备已进化次数;

	public string 封印宠物 = string.Empty;

	public string IID = string.Empty;

	public FastListSafe<属性数据> 装备属性列表 = new FastListSafe<属性数据>();

	public FastListSafe<洗炼属性缓存列表类> 洗炼属性列表 = new FastListSafe<洗炼属性缓存列表类>();

	internal void 初始化(int index)
	{
		Index = index;
		名字 = string.Empty;
		别名 = string.Empty;
		单位 = string.Empty;
		描述 = string.Empty;
		改造人 = string.Empty;
		数量 = 0;
		等级 = 0;
		物品ID = 0;
		图标 = 0;
		物品类型 = 0;
		物品颜色 = string.Empty;
		是否绑定 = false;
		封包缓存 = Array.Empty<byte>();
		首饰可转换次数 = 0;
		首饰已转换次数 = 0;
		装备已进化次数 = 0;
		封印宠物 = string.Empty;
		IID = string.Empty;
		装备属性列表.Clear();
		洗炼属性列表.Clear();
	}
}
