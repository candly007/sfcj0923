public class 六道轮回列表类
{
	public AllEnums.六道Type 六道名字;

	public int 开启消耗数值;

	public AllEnums.数值Type 开启消耗类型 = AllEnums.数值Type.银元宝;

	public int 最低等级;

	public int 转世结束数值;

	public AllEnums.数值Type 转世结束类型 = AllEnums.数值Type.经验;

	public bool is扣除;

	public int 所相数值;

	public int 单相数值;

	public 六道轮回列表类()
	{
	}

	public 六道轮回列表类(AllEnums.六道Type 六道名字, int 开启消耗数值, AllEnums.数值Type 开启消耗类型, int 最低等级, int 转世结束数值, AllEnums.数值Type 转世结束类型, bool is扣除, int 所相数值, int 单相数值)
	{
		this.六道名字 = 六道名字;
		this.开启消耗数值 = 开启消耗数值;
		this.开启消耗类型 = 开启消耗类型;
		this.最低等级 = 最低等级;
		this.转世结束数值 = 转世结束数值;
		this.转世结束类型 = 转世结束类型;
		this.is扣除 = is扣除;
		this.所相数值 = 所相数值;
		this.单相数值 = 单相数值;
	}
}
