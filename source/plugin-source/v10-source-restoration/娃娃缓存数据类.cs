using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

public class 娃娃缓存数据类
{
	public int 娃娃ID;

	public int 娃娃index;

	public string IID;

	public string 昵称A;

	public string 昵称B;

	public short 相性;

	public int 头像;

	public short 等级;

	public int 亲密;

	public int 经验;

	public short 当前体力;

	public short 最大体力;

	internal int xwjIJZ7mNY;

	internal int L9UIKY6HXU;

	public ConcurrentDictionary<string, int> 技能列表;

	
	public void 初始化(int id = 0, int index = 0)
	{
		娃娃ID = id;
		娃娃index = index;
		IID = string.Empty;
		昵称A = string.Empty;
		昵称B = string.Empty;
		相性 = 0;
		头像 = 0;
		等级 = 0;
		亲密 = 0;
		当前体力 = 0;
		最大体力 = 0;
		技能列表 = new ConcurrentDictionary<string, int>();
	}

	
	public 娃娃缓存数据类()
	{
		IID = string.Empty;
		昵称A = string.Empty;
		昵称B = string.Empty;
		技能列表 = new ConcurrentDictionary<string, int>();
	}

	static 娃娃缓存数据类()
	{
	}
}
