using System.Runtime.CompilerServices;

public class 无双圣榜数据类
{
	public bool is报名;

	public bool is排行领取;

	public int 淘汰时间;

	public int 当前积分;

	public int 圣榜排名;

	public int 总累胜场次;

	public int 本届累胜场次;

	public int 总连胜场次;

	public int 累胜领取进度;

	public int 连胜领取进度;

	public int 本日参拜次数;

	public bool is本日加成领取;

	
	public void 清空()
	{
		is报名 = false;
		is排行领取 = false;
		淘汰时间 = 0;
		当前积分 = 0;
		圣榜排名 = 0;
		本届累胜场次 = 0;
		本日参拜次数 = 0;
		is本日加成领取 = false;
	}

	
	public 无双圣榜数据类()
	{
	}

	static 无双圣榜数据类()
	{
	}
}
