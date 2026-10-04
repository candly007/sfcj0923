using System.Collections.Concurrent;

public class 超级道具配置类
{
	public bool 功能开关;

	public bool 定制功能开关;

	public ConcurrentDictionary<string, 超级道具列表配置类> 超级道具列表 = new ConcurrentDictionary<string, 超级道具列表配置类>();

	public string 自动使用道具 = string.Empty;

	public string 禁止使用道具 = string.Empty;

	public string 禁止交易道具 = string.Empty;

	public string 禁止摆摊道具 = string.Empty;

	public string 禁止拍卖道具 = string.Empty;

	public string 禁止商会道具 = string.Empty;

	public string 禁止丢弃道具 = string.Empty;

	public string 使用校验道具 = string.Empty;

	public string 自动绑定道具 = string.Empty;
}
