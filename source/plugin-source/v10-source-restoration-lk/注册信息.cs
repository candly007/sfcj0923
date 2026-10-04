using System.Linq;

public class 注册信息
{
	public string 账号 = string.Empty;

	public string 密码 = string.Empty;

	public string 安全码 = string.Empty;

	public string 注册验证码 = string.Empty;

	public string 名字 = string.Empty;

	public int 等级;

	public string IP = string.Empty;

	public string Mac = string.Empty;

	public string qq = string.Empty;

	public string 注册时间 = string.Empty;

	public bool Is重复qq(string 玩家qq)
	{
		if (string.IsNullOrWhiteSpace(玩家qq))
		{
			return false;
		}
		return 玩家qq.Split("|").Any((string x) => !string.IsNullOrWhiteSpace(x) && Singleton<ByteAPI>.I.寻找文本("|" + qq + "|", "|" + x + "|"));
	}
}
