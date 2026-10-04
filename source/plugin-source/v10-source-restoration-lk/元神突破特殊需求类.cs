public class 元神突破特殊需求类
{
	public bool Is额外条件;

	public bool Is道行达标;

	public int 道行要求;

	public bool Is声望达标;

	public int 声望要求;

	public bool Is击杀BOSS要求;

	public bool 破境BOSS只需击杀一次;

	public string 击杀BOSS要求 = string.Empty;

	public bool Is获取道具要求;

	public string 获取道具要求 = string.Empty;

	public void Init()
	{
		Is额外条件 = false;
		Is道行达标 = false;
		道行要求 = 0;
		Is声望达标 = false;
		声望要求 = 0;
		Is击杀BOSS要求 = false;
		击杀BOSS要求 = string.Empty;
		Is获取道具要求 = false;
		获取道具要求 = string.Empty;
	}
}
