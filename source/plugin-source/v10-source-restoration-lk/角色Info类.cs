public class 角色Info类
{
	public AllEnums.五行Type 五行;

	public AllEnums.门派Type 门派;

	public AllEnums.性别Type 性别;

	public AllEnums.新旧Type 新旧 = AllEnums.新旧Type.旧;

	public string 形象 = string.Empty;

	public 角色Info类(AllEnums.五行Type 五行, AllEnums.门派Type 门派, AllEnums.性别Type 性别, AllEnums.新旧Type 新旧, string 形象)
	{
		this.五行 = 五行;
		this.门派 = 门派;
		this.性别 = 性别;
		this.新旧 = 新旧;
		this.形象 = 形象;
	}
}
