using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Net.System;
using P80h4IDRZbpvERvsoap;
using Serilog;

public class 物品信息类
{
	public int Index;

	public string 名字;

	public string 别名;

	public string 前缀;

	public AllEnums.元神境界 穿戴要求;

	public string 单位;

	public string 描述;

	public string 改造人;

	public int 摊位价格;

	public int 数量;

	public byte 等级;

	public int 改造等级;

	public int 性别;

	public int 物品ID;

	public int 图标;

	public int 装备天伤;

	public int 绑定气血;

	public int 绑定法力;

	public int 当前耐久度;

	public int 最大耐久度;

	public int 当前炼魂值;

	public int 最大炼魂值;

	public int 亲密度;

	public short 奇术技能增加;

	public int 售出价格;

	public byte 物品类型;

	public string 物品颜色;

	public bool 是否绑定;

	public AllEnums.绑定Type 绑定状态;

	public byte[] 封包缓存;

	public int 首饰可转换次数;

	public int 首饰已转换次数;

	public int 装备已进化次数;

	public string 封印宠物;

	public string IID;

	public FastListSafe<属性数据> 装备属性列表;

	public FastListSafe<洗炼属性缓存列表类> 洗炼属性列表;

	public 分解详情配置类 分解Data;

	
	internal void rgh8r0QQvs(MyNATSocketClient P_0)
	{
		try
		{
			if (!pN4kvFDKqDQRQBnO8BW.XynDBwYvGf())
			{
				分解Data = null;
				return;
			}
			if (!Singleton<全局变量类>.I.装备分解配置.绑定开关 && 是否绑定)
			{
				分解Data = null;
				return;
			}
			if (Index < 101 || Index > 180)
			{
				分解Data = null;
				return;
			}
			if (!Singleton<全局变量类>.I.装备分解配置.分解列表.Any())
			{
				分解Data = null;
				return;
			}
			if (!Singleton<全局变量类>.I.装备分解配置.分解列表.Any( (分解详情配置类 分解详情配置类2) => 名字.StartsWith(分解详情配置类2.校验文字)))
			{
				分解Data = null;
				return;
			}
			分解Data = Singleton<全局变量类>.I.装备分解配置.分解列表.Find( (分解详情配置类 分解详情配置类2) => 名字.StartsWith(分解详情配置类2.校验文字));
		}
		catch (Exception ex)
		{
			Log.Error("Init_分解-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void C7n8ZR5IQ0(int P_0)
	{
		Index = P_0;
		名字 = string.Empty;
		别名 = string.Empty;
		前缀 = string.Empty;
		穿戴要求 = AllEnums.元神境界.凡人境;
		单位 = string.Empty;
		描述 = string.Empty;
		改造人 = string.Empty;
		摊位价格 = 0;
		数量 = 0;
		等级 = 0;
		性别 = 0;
		改造等级 = 0;
		物品ID = 0;
		图标 = 0;
		装备天伤 = 0;
		绑定气血 = 0;
		绑定法力 = 0;
		当前耐久度 = 0;
		最大耐久度 = 0;
		当前炼魂值 = 0;
		最大炼魂值 = 0;
		亲密度 = 0;
		奇术技能增加 = 0;
		售出价格 = 0;
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
		分解Data = null;
	}

	
	public 物品信息类()
	{
		名字 = string.Empty;
		别名 = string.Empty;
		前缀 = string.Empty;
		单位 = string.Empty;
		描述 = string.Empty;
		改造人 = string.Empty;
		物品颜色 = string.Empty;
		绑定状态 = AllEnums.绑定Type.不绑定;
		封包缓存 = Array.Empty<byte>();
		封印宠物 = string.Empty;
		IID = string.Empty;
		装备属性列表 = new FastListSafe<属性数据>();
		洗炼属性列表 = new FastListSafe<洗炼属性缓存列表类>();
	}

	
	[CompilerGenerated]
	private bool QbN8t6Gb7Q(分解详情配置类 P_0)
	{
		return 名字.StartsWith(P_0.校验文字);
	}

	
	[CompilerGenerated]
	private bool k3a8AEXwJK(分解详情配置类 P_0)
	{
		return 名字.StartsWith(P_0.校验文字);
	}

	static 物品信息类()
	{
	}
}
