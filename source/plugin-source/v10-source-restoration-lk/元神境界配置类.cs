using System.Collections.Concurrent;

public class 元神境界配置类
{
	public AllEnums.元神境界 当前境界;

	public AllEnums.元神境界 突破境界 = AllEnums.元神境界.练气境;

	public int 突破灵气值;

	public int 突破失败受伤程度;

	public ConcurrentDictionary<string, int> 增加突破几率道具 = new ConcurrentDictionary<string, int>();

	public 元神突破特殊需求类 突破特殊需求 = new 元神突破特殊需求类();

	public 元神境界加成类 突破加成配置 = new 元神境界加成类();

	public 元神特效配置类 境界特效 = new 元神特效配置类();

	public bool Is全服突破境界奖励;

	public string 全服横幅文字 = string.Empty;

	public 元神全服突破境界奖励类 首次突破奖励 = new 元神全服突破境界奖励类();

	public bool Is突破横幅 = true;
}
