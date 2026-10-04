using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

public class 元神存档类
{
	public AllEnums.元神境界 当前境界;

	public AllEnums.元神境界 突破境界;

	public int 突破几率;

	public string 突破使用道具;

	public string 增加几率道具;

	public bool 突破中;

	public string 击杀BOSS达成;

	public string 获取道具达成;

	public ConcurrentDictionary<AllEnums.元神境界, 元神境界加成类> 已获得突破加成;

	
	[SpecialName]
	internal int JkJIRtbr1R()
	{
		if (!Singleton<全局变量类>.I.元神系统配置.境界列表.ContainsKey(当前境界))
		{
			return 0;
		}
		return Singleton<全局变量类>.I.元神系统配置.境界列表[当前境界].突破灵气值;
	}

	
	public 元神存档类()
	{
		突破境界 = AllEnums.元神境界.练气境;
		突破使用道具 = string.Empty;
		增加几率道具 = string.Empty;
		击杀BOSS达成 = string.Empty;
		获取道具达成 = string.Empty;
		已获得突破加成 = new ConcurrentDictionary<AllEnums.元神境界, 元神境界加成类>();
	}

	static 元神存档类()
	{
	}
}
