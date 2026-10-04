using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using KEvDjBdeoLOoBKWXFAH;
using Serilog;
using TouchSocket.Core;
using TouchSocket.Sockets;
using VcF0pbBvJqp0x0IfwN;
using jVVIM9j1PL0VAliGELE;
using y24fbEG8KTuMIdiCbG1;

public class MyNATSocketClient
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public int IKsyoyQxyG;

		
		public _003C_003Ec__DisplayClass58_0()
		{
		}

		
		internal bool eAjyIYFpXg(KeyValuePair<AllEnums.属性名字Type, int[]> x)
		{
			if (x.Value.Length == 2 && x.Value[0] != 0)
			{
				return x.Value[1] < IKsyoyQxyG;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass58_0()
		{
		}
	}

	public NATSocketClient 当前client;

	public ITcpClient 转发client;

	public string IdKey;

	public string 游戏IP;

	public int 游戏端口;

	public int 插件端口;

	public bool 使用中;

	public string Mac;

	public string Macs;

	public string 账号;

	internal int QnJ2uKpF1v;

	internal ConcurrentDictionary<string, int> Su32wKC833;

	public 角色数据类 user;

	public Action<string> 销毁回调事件;

	public Action<string, bool> 战斗化形事件;

	public Action<int, string> 拆卸回调事件;

	public Action<bool> 智能怪物事件;

	public Action<int> 超级进化事件;

	public Action 摆摊购买后调整金钱事件;

	public Action<string> 召唤精怪事件;

	public Action 砍尾火眼事件;

	public Action 燃眉之急事件;

	public byte[] 当前时间字节;

	public int 当前权限;

	public StringBuilder 助手对话;

	[CompilerGenerated]
	private long L852bKqjNg;

	[CompilerGenerated]
	private long ygg2JRrwoF;

	public 数据队列类 数据队列;

	public readonly object 自选请求锁;

	public readonly object 自选取消锁;

	public readonly object 对话点击锁;

	public readonly object 使用道具锁;

	public readonly object BOSS挑战锁;

	public readonly object 巅峰套装锁;

	public readonly object 喂养频率锁;

	public int 临时测试;

	private ConcurrentQueue<byte[]> n4u2KBNYRE;

	public bool 频道锁;

	public readonly Channel<bool> _channel;

	public Action 战斗退出回调事件
	{
		
		get
		{
			return h7U6eOjw7p;
		}
	}

	public long 请求时间戳
	{
		
		[CompilerGenerated]
		get
		{
			return L852bKqjNg;
		}
		
		[CompilerGenerated]
		set
		{
			L852bKqjNg = value;
		}
	}

	public long 返回时间戳
	{
		
		[CompilerGenerated]
		get
		{
			return ygg2JRrwoF;
		}
		
		[CompilerGenerated]
		set
		{
			ygg2JRrwoF = value;
		}
	}

	
	public void 压入数据队列(byte[] data)
	{
		数据队列.PacketChannel.Writer.WriteAsync(data);
		if (数据队列.ProcessingTask == null || 数据队列.ProcessingTask.IsCompleted)
		{
			数据队列类 数据队列类2 = 数据队列;
			if (数据队列类2.TokenSource == null)
			{
				CancellationTokenSource cancellationTokenSource = (数据队列类2.TokenSource = new CancellationTokenSource());
			}
			数据队列.ProcessingTask = Task.Run( () => ConsumeUserPacketsAsync(数据队列.TokenSource.Token));
		}
	}

	
	private async Task ConsumeUserPacketsAsync(CancellationToken token)
	{
		_ = 1;
		try
		{
			await foreach (byte[] item in 数据队列.PacketChannel.Reader.ReadAllAsync(token))
			{
				S_Send(Singleton<请求数据响应处理类>.I.请求处理中心(this, item), "ConsumeUserPacketsAsync");
			}
		}
		catch (OperationCanceledException)
		{
		}
		catch (Exception ex2)
		{
			Log.Error("❌ 用户 " + IdKey + " 消费异常: " + ex2.Message);
		}
	}

	
	public void GM_Send(byte[] buffer)
	{
		try
		{
			if (转发client.Online && buffer != null)
			{
				转发client.DefaultSend(buffer);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 4);
			defaultInterpolatedStringHandler.AppendLiteral("GM_调整属性封包：IP[");
			defaultInterpolatedStringHandler.AppendFormatted(当前client.IP);
			defaultInterpolatedStringHandler.AppendLiteral("] 角色[");
			defaultInterpolatedStringHandler.AppendFormatted(user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public void S_Send(byte[] buffer, string FunName = "")
	{
		try
		{
			if (转发client.Online && buffer != null)
			{
				转发client.DefaultSend(buffer);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 6);
			defaultInterpolatedStringHandler.AppendFormatted(FunName);
			defaultInterpolatedStringHandler.AppendLiteral("：S_Send报错：IP[");
			defaultInterpolatedStringHandler.AppendFormatted(当前client.IP);
			defaultInterpolatedStringHandler.AppendLiteral("] 角色[");
			defaultInterpolatedStringHandler.AppendFormatted(user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(") 内容：[");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(buffer));
			defaultInterpolatedStringHandler.AppendLiteral("]");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public async Task S_Send异步(byte[] buffer, string FunName = "")
	{
		try
		{
			if (转发client.Online && buffer != null)
			{
				await 转发client.DefaultSendAsync(buffer);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 6);
			defaultInterpolatedStringHandler.AppendFormatted(FunName);
			defaultInterpolatedStringHandler.AppendLiteral("：S_Send异步报错：IP[");
			defaultInterpolatedStringHandler.AppendFormatted(当前client.IP);
			defaultInterpolatedStringHandler.AppendLiteral("] 角色[");
			defaultInterpolatedStringHandler.AppendFormatted(user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(") 内容：[");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(buffer));
			defaultInterpolatedStringHandler.AppendLiteral("]");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public void C_Send(byte[] buffer)
	{
		try
		{
			if (当前client.Online && buffer != null)
			{
				当前client.DefaultSend(buffer);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 4);
			defaultInterpolatedStringHandler.AppendLiteral("C_Send报错：IP[");
			defaultInterpolatedStringHandler.AppendFormatted(当前client.IP);
			defaultInterpolatedStringHandler.AppendLiteral("] 角色[");
			defaultInterpolatedStringHandler.AppendFormatted(user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public async Task C_Send异步(byte[] buffer, int 延迟毫秒 = 0)
	{
		try
		{
			if (当前client.Online && buffer != null)
			{
				if (延迟毫秒 > 0)
				{
					await Task.Delay(延迟毫秒);
				}
				当前client.DefaultSendAsync(buffer);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 4);
			defaultInterpolatedStringHandler.AppendLiteral("C_Send异步-报错：IP[");
			defaultInterpolatedStringHandler.AppendFormatted(当前client.IP);
			defaultInterpolatedStringHandler.AppendLiteral("] 角色[");
			defaultInterpolatedStringHandler.AppendFormatted(user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public void Close()
	{
		try
		{
			数据队列.TokenSource?.Cancel();
			TimedDungeonService.I.OnDisconnected(this);
			if (使用中)
			{
				user.存档数据.燃眉之急任务.下线清空();
				user.存档数据.最后下线时间 = Singleton<ByteAPI>.I.取时间文本();
				DB.I.oMuiwEHr6E(user.人物数据.GID, user.存档数据);
			}
			使用中 = false;
			Su32wKC833.Clear();
			当前client.SafeDispose();
			转发client.SafeDispose();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 4);
			defaultInterpolatedStringHandler.AppendLiteral("Close报错：IP[");
			defaultInterpolatedStringHandler.AppendFormatted(当前client.IP);
			defaultInterpolatedStringHandler.AppendLiteral("] 角色[");
			defaultInterpolatedStringHandler.AppendFormatted(user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void h7U6eOjw7p()
	{
		if (!妖族化形功能.使用中 || !Singleton<全局变量类>.I.妖族化形配置.变身开关)
		{
			return;
		}
		if (!user.缓存数据.战斗成员字典.IsEmpty)
		{
			foreach (string key in user.缓存数据.战斗成员字典.Keys)
			{
				if (Singleton<全局变量类>.I.会话Dict.TryGetValue(key, out var value))
				{
					value?.user.缓存数据.战斗成员字典.TryRemove(key, out var _);
				}
			}
		}
		user.缓存数据.战斗成员字典.Clear();
	}

	
	public void 化形同步处理(string idkey, bool 是否化形)
	{
		try
		{
			if (user.缓存数据.战斗成员字典.TryGetValue(idkey, out var value) && Singleton<全局变量类>.I.会话Dict.TryGetValue(idkey, out var value2) && value2.user.缓存数据.战斗回合数 == user.缓存数据.战斗回合数)
			{
				if (是否化形)
				{
					C_Send(Singleton<OmF9SPGlN77YLFkkoqN>.I.j03G92ZUrm(value2, value));
				}
				else
				{
					C_Send(value ? value2.user.缓存数据.初始战斗我方数据包 : value2.user.缓存数据.初始战斗敌方数据包);
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 4);
			defaultInterpolatedStringHandler.AppendLiteral("化形同步处理报错：IP[");
			defaultInterpolatedStringHandler.AppendFormatted(当前client.IP);
			defaultInterpolatedStringHandler.AppendLiteral("] 角色[");
			defaultInterpolatedStringHandler.AppendFormatted(user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public void 频道返回客户端处理(byte[] buffer)
	{
		try
		{
			if (当前client.Online && 使用中)
			{
				n4u2KBNYRE.Enqueue(buffer);
				if (!频道锁)
				{
					频道锁 = true;
					频道处理线程();
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 4);
			defaultInterpolatedStringHandler.AppendLiteral("频道返回客户端处理-报错：IP[");
			defaultInterpolatedStringHandler.AppendFormatted(当前client.IP);
			defaultInterpolatedStringHandler.AppendLiteral("] 角色[");
			defaultInterpolatedStringHandler.AppendFormatted(user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public async Task 频道处理线程()
	{
		try
		{
			byte[] result;
			while (n4u2KBNYRE.TryDequeue(out result) && 当前client.Online && 使用中)
			{
				C_Send(result);
				await Task.Delay(10);
			}
			频道锁 = false;
		}
		catch (Exception ex)
		{
			Log.Error("频道处理线程-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			频道锁 = false;
		}
	}

	
	public void 限时属性处理()
	{
		_003C_003Ec__DisplayClass58_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass58_0();
		if (!当前client.Online || !使用中 || user.存档数据.中州论道存档.限时属性列表.IsEmpty)
		{
			return;
		}
		CS_0024_003C_003E8__locals2.IKsyoyQxyG = (int)Singleton<ByteAPI>.I.取时间戳();
		Dictionary<AllEnums.属性名字Type, int[]> dictionary = user.存档数据.中州论道存档.限时属性列表.Where( (KeyValuePair<AllEnums.属性名字Type, int[]> x) => x.Value.Length == 2 && x.Value[0] != 0 && x.Value[1] < CS_0024_003C_003E8__locals2.IKsyoyQxyG).ToDictionary( (KeyValuePair<AllEnums.属性名字Type, int[]> kvp) => kvp.Key,  (KeyValuePair<AllEnums.属性名字Type, int[]> kvp) => kvp.Value);
		List<string[]> list = new List<string[]>();
		if (!dictionary.Any())
		{
			return;
		}
		foreach (KeyValuePair<AllEnums.属性名字Type, int[]> item in dictionary)
		{
			user.存档数据.中州论道存档.jxpIgn1imh(item.Key, -item.Value[0], out var text);
			string[] array = new string[2];
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler.AppendLiteral("prop/");
			defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)item.Key);
			array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
			array[1] = text;
			list.Add(array);
			user.存档数据.中州论道存档.限时属性列表.TryRemove(item.Key, out var _);
			WdAPI i = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
			defaultInterpolatedStringHandler.AppendLiteral("由于时间到期，你限时属性#R");
			defaultInterpolatedStringHandler.AppendFormatted(item.Key);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(item.Value[0]);
			defaultInterpolatedStringHandler.AppendFormatted(问道数据类.Add属性名字后缀(item.Key));
			defaultInterpolatedStringHandler.AppendLiteral(" 增加#n失效了。");
			C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
		}
		Singleton<fuMNpgieFTYU3Wah53>.I.mMMfZ3LX2(this, list);
	}

	
	internal async void U476qJsWtr()
	{
		try
		{
			if (全局变量类.点卡使用中 && 当前client.Online && 使用中)
			{
				user.存档数据.点卡存档.当前点数 -= Singleton<全局变量类>.I.config.点卡配置.每分钟扣除点;
				if (user.存档数据.点卡存档.当前点数 <= 0)
				{
					user.存档数据.点卡存档.当前点数 = 0;
					C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#R你当前点卡已经用完，即将下线！请及时补充点卡点数哦"));
					await Task.Delay(1000);
					Singleton<WdAPI>.I.WT9IHmFS6c(this, user.人物数据.昵称);
				}
				else if (user.存档数据.点卡存档.当前点数 <= 10)
				{
					fK6mLrjpv26MU2YIIF9 i = Singleton<fK6mLrjpv26MU2YIIF9>.I;
					MyNATSocketClient myNATSocketClient = this;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你当前的点卡点数仅剩#R");
					defaultInterpolatedStringHandler.AppendFormatted(user.存档数据.点卡存档.当前点数);
					defaultInterpolatedStringHandler.AppendLiteral("#n点，请及时补充，以免影响游戏体验。");
					i.Ym9jrsy6dl(myNATSocketClient, defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("点卡扣除处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public void Try写()
	{
		C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("【前】" + user.人物数据.所在地图名字));
		_channel.Writer.TryWrite(item: true);
	}

	
	public async Task Try读()
	{
		await _channel.Reader.WaitToReadAsync();
		await _channel.Reader.ReadAsync();
		C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("【后】" + user.人物数据.所在地图名字));
	}

	
	public async Task<AllEnums.元神境界> 取队长境界()
	{
		try
		{
			await Task.Delay(0);
			if (user.队伍数据.成员列表.Count <= 1 || user.队伍数据.is队长)
			{
				return user.存档数据.元神存档.当前境界;
			}
			return Singleton<MainService>.I.获取指定角色ID玩家MyClient(user.队伍数据.成员列表[0])?.user.存档数据.元神存档.当前境界 ?? AllEnums.元神境界.凡人境;
		}
		catch (Exception ex)
		{
			Log.Error("取队长境界-失败：" + ex.Message + "(" + ex.StackTrace + ")");
			return AllEnums.元神境界.凡人境;
		}
	}

	
	internal void c2q6rOHHY9()
	{
		try
		{
			异兽录存档数据类 obj = (user.缓存数据.is加点方案一 ? user.存档数据.异兽录数据.方案1 : user.存档数据.异兽录数据.方案2);
			List<string[]> list = new List<string[]>();
			ConcurrentDictionary<AllEnums.属性名字Type, string> concurrentDictionary = new ConcurrentDictionary<AllEnums.属性名字Type, string>();
			foreach (KeyValuePair<AllEnums.异兽Type, List<string>> item in obj.收录列表)
			{
				foreach (string item2 in item.Value)
				{
					if (Singleton<全局变量类>.I.异兽录配置.图鉴列表.TryGetValue(item2, out 异兽录图鉴列表类 value))
					{
						user.存档数据.中州论道存档.jxpIgn1imh(value.定制收录属性, -value.收录数值, out var value2);
						if (concurrentDictionary.ContainsKey(value.定制收录属性))
						{
							concurrentDictionary[value.定制收录属性] = value2;
						}
						else
						{
							concurrentDictionary.TryAdd(value.定制收录属性, value2);
						}
					}
				}
				int count = item.Value.Count;
				switch (item.Key)
				{
				case AllEnums.异兽Type.御灵:
					if (count == Singleton<iRGieud4qtscW6ESmxk>.I.f1esfGQQpj.Count && Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值 > 0)
					{
						user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.异兽录配置.定制御灵圆满附加属性, -Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值, out var value5);
						if (concurrentDictionary.ContainsKey(Singleton<全局变量类>.I.异兽录配置.定制御灵圆满附加属性))
						{
							concurrentDictionary[Singleton<全局变量类>.I.异兽录配置.定制御灵圆满附加属性] = value5;
						}
						else
						{
							concurrentDictionary.TryAdd(Singleton<全局变量类>.I.异兽录配置.定制御灵圆满附加属性, value5);
						}
					}
					break;
				case AllEnums.异兽Type.变异:
					if (count == Singleton<iRGieud4qtscW6ESmxk>.I.W5hsNnYAjN.Count && Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值 > 0)
					{
						user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.异兽录配置.定制变异圆满附加属性, -Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值, out var value7);
						if (concurrentDictionary.ContainsKey(Singleton<全局变量类>.I.异兽录配置.定制变异圆满附加属性))
						{
							concurrentDictionary[Singleton<全局变量类>.I.异兽录配置.定制变异圆满附加属性] = value7;
						}
						else
						{
							concurrentDictionary.TryAdd(Singleton<全局变量类>.I.异兽录配置.定制变异圆满附加属性, value7);
						}
					}
					break;
				case AllEnums.异兽Type.神兽:
					if (count == Singleton<iRGieud4qtscW6ESmxk>.I.T6gsiwMmCv.Count && Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值 > 0)
					{
						user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.异兽录配置.定制神兽圆满附加属性, -Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值, out var value6);
						if (concurrentDictionary.ContainsKey(Singleton<全局变量类>.I.异兽录配置.定制神兽圆满附加属性))
						{
							concurrentDictionary[Singleton<全局变量类>.I.异兽录配置.定制神兽圆满附加属性] = value6;
						}
						else
						{
							concurrentDictionary.TryAdd(Singleton<全局变量类>.I.异兽录配置.定制神兽圆满附加属性, value6);
						}
					}
					break;
				case AllEnums.异兽Type.元灵:
					if (count == Singleton<iRGieud4qtscW6ESmxk>.I.iFLsBvoaBy.Count && Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值 > 0)
					{
						user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.异兽录配置.定制元灵圆满附加属性, -Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值, out var value4);
						if (concurrentDictionary.ContainsKey(Singleton<全局变量类>.I.异兽录配置.定制元灵圆满附加属性))
						{
							concurrentDictionary[Singleton<全局变量类>.I.异兽录配置.定制元灵圆满附加属性] = value4;
						}
						else
						{
							concurrentDictionary.TryAdd(Singleton<全局变量类>.I.异兽录配置.定制元灵圆满附加属性, value4);
						}
					}
					break;
				case AllEnums.异兽Type.仙元:
					if (count == Singleton<iRGieud4qtscW6ESmxk>.I.Q1xsG3Fx3O.Count && Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值 > 0)
					{
						user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.异兽录配置.定制仙元圆满附加属性, -Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值, out var value3);
						if (concurrentDictionary.ContainsKey(Singleton<全局变量类>.I.异兽录配置.定制仙元圆满附加属性))
						{
							concurrentDictionary[Singleton<全局变量类>.I.异兽录配置.定制仙元圆满附加属性] = value3;
						}
						else
						{
							concurrentDictionary.TryAdd(Singleton<全局变量类>.I.异兽录配置.定制仙元圆满附加属性, value3);
						}
					}
					break;
				}
			}
			foreach (KeyValuePair<AllEnums.属性名字Type, string> item3 in concurrentDictionary)
			{
				string[] array = new string[2];
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)item3.Key);
				array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[1] = item3.Value;
				list.Add(array);
			}
			Singleton<fuMNpgieFTYU3Wah53>.I.mMMfZ3LX2(this, list);
			user.存档数据.异兽录数据.清空();
			DB.I.oMuiwEHr6E(user.人物数据.GID, user.存档数据);
			C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你的异兽录存档已经被清除。"));
		}
		catch (Exception ex)
		{
			Log.Error("清空定制异兽录-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void l586ZEtJJW()
	{
		try
		{
			浮生录存档类 浮生录存档类2 = (user.缓存数据.is加点方案一 ? user.存档数据.浮生录数据.方案1 : user.存档数据.浮生录数据.方案2);
			List<string[]> list = new List<string[]>();
			ConcurrentDictionary<AllEnums.属性名字Type, string> concurrentDictionary = new ConcurrentDictionary<AllEnums.属性名字Type, string>();
			foreach (浮生录化身列表类 value8 in 浮生录存档类2.化身列表.Values)
			{
				if (value8.激活进度 >= 100 && Singleton<全局变量类>.I.浮生录配置.化身列表.TryGetValue(value8.化身名字, out 浮生化身配置类 value))
				{
					user.存档数据.中州论道存档.jxpIgn1imh(value.属性名字, -value.属性数值, out var value2);
					if (concurrentDictionary.ContainsKey(value.属性名字))
					{
						concurrentDictionary[value.属性名字] = value2;
					}
					else
					{
						concurrentDictionary.TryAdd(value.属性名字, value2);
					}
				}
			}
			if (Singleton<浮生录功能>.I.Ih6WdCmIqb.Count == 浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.乱世书 && x.激活进度 >= 100))
			{
				user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制乱世书属性, -Singleton<全局变量类>.I.浮生录配置.乱世书数值, out var value3);
				if (concurrentDictionary.ContainsKey(Singleton<全局变量类>.I.浮生录配置.定制乱世书属性))
				{
					concurrentDictionary[Singleton<全局变量类>.I.浮生录配置.定制乱世书属性] = value3;
				}
				else
				{
					concurrentDictionary.TryAdd(Singleton<全局变量类>.I.浮生录配置.定制乱世书属性, value3);
				}
			}
			if (Singleton<浮生录功能>.I.CsTWsdbKp5.Count == 浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.千钧卷 && x.激活进度 >= 100))
			{
				user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性, -Singleton<全局变量类>.I.浮生录配置.千钧卷数值, out var value4);
				if (concurrentDictionary.ContainsKey(Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性))
				{
					concurrentDictionary[Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性] = value4;
				}
				else
				{
					concurrentDictionary.TryAdd(Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性, value4);
				}
			}
			if (Singleton<浮生录功能>.I.nppWUisDdB.Count == 浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.灵虚卷 && x.激活进度 >= 100))
			{
				user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性, -Singleton<全局变量类>.I.浮生录配置.灵虚卷数值, out var value5);
				if (concurrentDictionary.ContainsKey(Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性))
				{
					concurrentDictionary[Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性] = value5;
				}
				else
				{
					concurrentDictionary.TryAdd(Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性, value5);
				}
			}
			if (Singleton<浮生录功能>.I.RNoWWSOvFy.Count == 浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.御元卷 && x.激活进度 >= 100))
			{
				user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制御元卷属性, -Singleton<全局变量类>.I.浮生录配置.御元卷数值, out var value6);
				if (concurrentDictionary.ContainsKey(Singleton<全局变量类>.I.浮生录配置.定制御元卷属性))
				{
					concurrentDictionary[Singleton<全局变量类>.I.浮生录配置.定制御元卷属性] = value6;
				}
				else
				{
					concurrentDictionary.TryAdd(Singleton<全局变量类>.I.浮生录配置.定制御元卷属性, value6);
				}
			}
			if (Singleton<浮生录功能>.I.LHGWgAIE0Z.Count == 浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.乘风卷 && x.激活进度 >= 100))
			{
				user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性, -Singleton<全局变量类>.I.浮生录配置.乘风卷数值, out var value7);
				if (concurrentDictionary.ContainsKey(Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性))
				{
					concurrentDictionary[Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性] = value7;
				}
				else
				{
					concurrentDictionary.TryAdd(Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性, value7);
				}
			}
			foreach (KeyValuePair<AllEnums.属性名字Type, string> item in concurrentDictionary)
			{
				string[] array = new string[2];
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)item.Key);
				array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[1] = item.Value;
				list.Add(array);
			}
			Singleton<fuMNpgieFTYU3Wah53>.I.mMMfZ3LX2(this, list);
			user.存档数据.浮生录数据.清空();
			DB.I.oMuiwEHr6E(user.人物数据.GID, user.存档数据);
			C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你的浮生录存档已经被清除。"));
		}
		catch (Exception ex)
		{
			Log.Error("清空定制浮生录-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void tNK6tvTO1H()
	{
		try
		{
			六道轮回存档数据类 obj = (user.缓存数据.is加点方案一 ? user.存档数据.轮回转世数据.存档方案1 : user.存档数据.轮回转世数据.存档方案2);
			List<string[]> list = new List<string[]>();
			ConcurrentDictionary<AllEnums.属性名字Type, string> concurrentDictionary = new ConcurrentDictionary<AllEnums.属性名字Type, string>();
			轮回转世属性存档[] 转世属性列表 = obj.转世属性列表;
			foreach (轮回转世属性存档 轮回转世属性存档2 in 转世属性列表)
			{
				if (轮回转世属性存档2.属性数值 > 0 && Enum.TryParse<AllEnums.属性名字Type>($"{(AllEnums.属性Type)轮回转世属性存档2.转世属性}", out var result))
				{
					user.存档数据.中州论道存档.jxpIgn1imh(result, -轮回转世属性存档2.属性数值, out var value);
					if (concurrentDictionary.ContainsKey(result))
					{
						concurrentDictionary[result] = value;
					}
					else
					{
						concurrentDictionary.TryAdd(result, value);
					}
				}
			}
			foreach (KeyValuePair<AllEnums.属性名字Type, string> item in concurrentDictionary)
			{
				string[] array = new string[2];
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)item.Key);
				array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[1] = item.Value;
				list.Add(array);
			}
			Singleton<fuMNpgieFTYU3Wah53>.I.mMMfZ3LX2(this, list);
			user.存档数据.轮回转世数据.清空();
			DB.I.oMuiwEHr6E(user.人物数据.GID, user.存档数据);
			C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你的六道轮回存档已经被清除。"));
		}
		catch (Exception ex)
		{
			Log.Error("清空定制六道轮回-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void O566AMjsok()
	{
		try
		{
			List<string[]> list = new List<string[]>();
			ConcurrentDictionary<AllEnums.属性名字Type, string> concurrentDictionary = new ConcurrentDictionary<AllEnums.属性名字Type, string>();
			foreach (超级道具数据类 item in user.存档数据.超级道具数据)
			{
				if (item.加成数值 > 0)
				{
					user.存档数据.中州论道存档.jxpIgn1imh(item.附加属性类型, -item.加成数值, out var value);
					if (concurrentDictionary.ContainsKey(item.附加属性类型))
					{
						concurrentDictionary[item.附加属性类型] = value;
					}
					else
					{
						concurrentDictionary.TryAdd(item.附加属性类型, value);
					}
					item.清空();
				}
			}
			foreach (KeyValuePair<AllEnums.属性名字Type, string> item2 in concurrentDictionary)
			{
				string[] array = new string[2];
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)item2.Key);
				array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[1] = item2.Value;
				list.Add(array);
			}
			Singleton<fuMNpgieFTYU3Wah53>.I.mMMfZ3LX2(this, list);
			user.存档数据.超级道具数据.RemoveAll( (超级道具数据类 x) => x.已用数量 <= 0);
			DB.I.oMuiwEHr6E(user.人物数据.GID, user.存档数据);
			C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("你的超级道具存档已经被清除。"));
		}
		catch (Exception ex)
		{
			Log.Error("清空定制超级道具-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public MyNATSocketClient()
	{
		IdKey = string.Empty;
		游戏IP = string.Empty;
		Mac = string.Empty;
		Macs = string.Empty;
		账号 = string.Empty;
		Su32wKC833 = new ConcurrentDictionary<string, int>();
		user = new 角色数据类();
		当前时间字节 = Array.Empty<byte>();
		助手对话 = new StringBuilder();
		自选请求锁 = new object();
		自选取消锁 = new object();
		对话点击锁 = new object();
		使用道具锁 = new object();
		BOSS挑战锁 = new object();
		巅峰套装锁 = new object();
		喂养频率锁 = new object();
		临时测试 = 1;
		n4u2KBNYRE = new ConcurrentQueue<byte[]>();
		_channel = Channel.CreateUnbounded<bool>(new UnboundedChannelOptions
		{
			SingleWriter = false,
			SingleReader = false
		});
	}

	
	[CompilerGenerated]
	private Task? XLo6zgM0b1()
	{
		return ConsumeUserPacketsAsync(数据队列.TokenSource.Token);
	}

	static MyNATSocketClient()
	{
	}
}
