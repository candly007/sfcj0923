using System.Collections.Generic;

public class 无双圣榜存档类
{
	public int 当前大圣继承者Gid;

	public string 当前大圣名字 = string.Empty;

	public int 当前大圣等级;

	public int 当前大圣道行;

	public int 当前雕像参拜次数;

	public List<圣无双排行榜数据类> 排行数据 = new List<圣无双排行榜数据类>();

	public NPC数据类 大圣雕像 = new NPC数据类();

	public 无双圣榜存档类()
	{
		排行数据 = new List<圣无双排行榜数据类>();
	}

	public void 清空()
	{
		当前大圣继承者Gid = 0;
		当前大圣名字 = string.Empty;
		当前大圣等级 = 0;
		当前大圣道行 = 0;
		当前雕像参拜次数 = 0;
		排行数据.Clear();
	}
}
