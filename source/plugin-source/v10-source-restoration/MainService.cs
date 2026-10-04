using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using B2uVXfUco7vjsxVN2Bc;
using QsZODwJPWinsfjttlCn;
using Serilog;
using TouchSocket.Core;
using TouchSocket.Sockets;

public class MainService : Singleton<MainService>
{
	public ConcurrentDictionary<int, MyNATService> Server组;

	public ConcurrentDictionary<short, short> 游戏端口对应插件端口组;

	public ConcurrentDictionary<string, string> 历史IP机器码列表;

	public ConcurrentDictionary<string, string> 历史IP账号列表;

	public WdServer server;

	
	public async Task Init(string 真实游戏IP, Action<bool, string> 启动回调 = null)
	{
		try
		{
			// All line creation paths converge here. Keep the authorization gate inside the
			// service so a caller cannot bypass the authenticated RPC start button.
			if (Singleton<全局变量类>.I.验证client?.授权线路启动许可() != true)
			{
				Log.Error("拒绝启动游戏线路：授权租约未验证");
				启动回调?.Invoke(false, "授权未验证");
				return;
			}
			if (真实游戏IP == "255.255.255.255")
			{
				启动回调?.Invoke(arg1: true, "插件启动失败！");
				return;
			}
			游戏端口对应插件端口组.Clear();
			Singleton<yuKf6DUSQGygKeLSQdj>.I.Eu4UC51HfM.Clear();
			Singleton<全局变量类>.I.所有NPC字典.Clear();
			List<int> 插件端口组 = Singleton<全局变量类>.I.config.插件端口.Split(',').Select(int.Parse).ToList();
			List<int> 游戏端口组 = Singleton<全局变量类>.I.config.游戏端口.Split(',').Select(int.Parse).ToList();
			for (int i = 0; i < 插件端口组.Count; i++)
			{
				MyNATService service = new MyNATService
				{
					游戏IP = 真实游戏IP,
					插件端口 = 插件端口组[i],
					游戏端口 = 游戏端口组[i]
				};
				游戏端口对应插件端口组.TryAdd((short)游戏端口组[i], (short)插件端口组[i]);
				service.Setup(new TouchSocketConfig().SetListenIPHosts(插件端口组[i]).SetTcpDataHandlingAdapter( () => new MyFixedHeaderCustomDataHandlingAdapter()));
				await service.StartAsync();
				Server组.TryAdd(插件端口组[i], service);
				Singleton<全局变量类>.I.所有NPC字典.TryAdd(插件端口组[i], new ConcurrentDictionary<int, NPC信息类>());
				Singleton<yuKf6DUSQGygKeLSQdj>.I.Eu4UC51HfM.TryAdd(插件端口组[i], new ConcurrentDictionary<int, int>());
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
				defaultInterpolatedStringHandler.AppendFormatted(插件端口组[i]);
				defaultInterpolatedStringHandler.AppendLiteral("端口正常启动");
				Log.Warning(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			foreach (ConcurrentDictionary<int, NPC信息类> value in Singleton<全局变量类>.I.所有NPC字典.Values)
			{
				value.TryAdd(-1, new NPC信息类());
			}
			Log.Warning("顺风插件启动成功，祝您顺风顺水顺财神！");
			Singleton<全局变量类>.I.插件启动状态 = true;
			启动回调?.Invoke(arg1: true, "顺风插件启动成功，祝您顺风顺水顺财神！");
			Singleton<版本相关处理>.I.启动巅峰对决读取();
		}
		catch (Exception ex)
		{
			Singleton<全局变量类>.I.插件启动状态 = false;
			启动回调?.Invoke(arg1: false, "插件启动错误：" + ex.Message);
			Log.Error("插件启动错误：" + ex.Message + "【" + ex.StackTrace + "】");
		}
	}

	
	public async Task SendAllClient(byte[] buffer, string clientkey = "")
	{
		try
		{
			foreach (KeyValuePair<string, MyNATSocketClient> item in Singleton<全局变量类>.I.会话Dict)
			{
				if (!(item.Key == clientkey))
				{
					if (item.Value.使用中 && item.Value.user.人物数据.角色ID != 0)
					{
						item.Value.C_Send(buffer);
					}
					await Task.Delay(10);
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("发送全部客户端报错：" + ex.Message + ex.StackTrace);
		}
	}

	
	public void SendAllServer(byte[] buffer, string clientkey = "")
	{
		try
		{
			foreach (KeyValuePair<string, MyNATSocketClient> item in Singleton<全局变量类>.I.会话Dict)
			{
				if (!(item.Key == clientkey) && item.Value.使用中 && item.Value.user.人物数据.角色ID != 0)
				{
					item.Value.S_Send(buffer, "SendAllServer");
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("发送全部服务端报错：" + ex.Message + ex.StackTrace);
		}
	}

	
	public async Task ServerClose()
	{
		foreach (KeyValuePair<int, MyNATService> item in Server组)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
			defaultInterpolatedStringHandler.AppendFormatted(item.Key);
			defaultInterpolatedStringHandler.AppendLiteral("端口出现异常，已被关闭");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			item.Value.Clear();
			await item.Value.StopAsync();
		}
		Server组.Clear();
	}

	
	public string 获取指定玩家ClientId(string 玩家名字)
	{
		try
		{
			foreach (KeyValuePair<string, MyNATSocketClient> item in Singleton<全局变量类>.I.会话Dict)
			{
				if (item.Value.使用中 && item.Value.user.人物数据.角色ID != 0 && item.Value.user.人物数据.昵称 == 玩家名字)
				{
					return item.Key;
				}
			}
			return string.Empty;
		}
		catch (Exception ex)
		{
			Log.Error("获取指定玩家ClientId-报错：" + ex.Message + ex.StackTrace);
			return string.Empty;
		}
	}

	
	public MyNATSocketClient 获取指定GID玩家MyClient(int GID)
	{
		try
		{
			foreach (MyNATSocketClient value in Singleton<全局变量类>.I.会话Dict.Values)
			{
				if (value.当前client.Online && value.转发client.Online && value.使用中 && value.user.人物数据.角色ID != 0 && value.user.人物数据.GID == GID)
				{
					return value;
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("获取指定玩家Client-报错：" + ex.Message + ex.StackTrace);
		}
		return null;
	}

	
	public MyNATSocketClient 获取指定角色ID玩家MyClient(int 角色id)
	{
		try
		{
			foreach (MyNATSocketClient value in Singleton<全局变量类>.I.会话Dict.Values)
			{
				if (value.当前client.Online && value.转发client.Online && value.使用中 && value.user.人物数据.角色ID != 0 && value.user.人物数据.角色ID == 角色id)
				{
					return value;
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("获取指定角色ID玩家MyClient-报错：" + ex.Message + ex.StackTrace);
		}
		return null;
	}

	
	public MyNATSocketClient 获取指定角色账号玩家MyClient(string 角色账号)
	{
		try
		{
			foreach (MyNATSocketClient value in Singleton<全局变量类>.I.会话Dict.Values)
			{
				if (value.当前client.Online && value.转发client.Online && value.使用中 && value.user.人物数据.角色ID != 0 && value.user.人物数据.账号 == 角色账号)
				{
					return value;
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("获取指定角色账号玩家MyClient-报错：" + ex.Message + ex.StackTrace);
		}
		return null;
	}

	
	public bool 取指定Key玩家是否存在(string Clientkey)
	{
		try
		{
			return Singleton<全局变量类>.I.会话Dict.ContainsKey(Clientkey);
		}
		catch (Exception ex)
		{
			Log.Error("取指定Key玩家是否存在-报错：" + ex.Message + ex.StackTrace);
			return false;
		}
	}

	
	public MyNATSocketClient 获取指定key玩家MyClient(string Clientkey)
	{
		try
		{
			Singleton<全局变量类>.I.会话Dict.TryGetValue(Clientkey, out var value);
			return value;
		}
		catch (Exception ex)
		{
			Log.Error("获取指定玩家Client-报错：" + ex.Message + ex.StackTrace);
			return null;
		}
	}

	
	public MyNATSocketClient 获取指定Name玩家MyClient(string 玩家名字)
	{
		try
		{
			foreach (MyNATSocketClient value in Singleton<全局变量类>.I.会话Dict.Values)
			{
				if (value.当前client.Online && value.转发client.Online && value.使用中 && value.user.人物数据.角色ID != 0 && value.user.人物数据.昵称 == 玩家名字)
				{
					return value;
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("获取指定Name玩家MyClient-报错：" + ex.Message + ex.StackTrace);
		}
		return null;
	}

	
	public void 主动断开指定客户端(string clientid)
	{
		foreach (MyNATService value in Server组.Values)
		{
			foreach (NATSocketClient client in value.GetClients())
			{
				if (client.Id == clientid)
				{
					client.Disconnected = null;
					client.Disconnecting = null;
					break;
				}
			}
		}
	}

	
	public bool 发送角色属性道具(MyNATSocketClient myclient, AllEnums.数值Type 发送类型, int 发送数量 = 1, string 道具名字 = "", string 提示文本 = "")
	{
		if (myclient == null || 发送数量 == 0)
		{
			return false;
		}
		if (!myclient.当前client.Online || !myclient.转发client.Online)
		{
			return false;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 5);
		defaultInterpolatedStringHandler.AppendLiteral("【接收】 【发送角色属性道具：");
		defaultInterpolatedStringHandler.AppendFormatted(myclient.user.人物数据.昵称);
		defaultInterpolatedStringHandler.AppendLiteral("】【id：");
		defaultInterpolatedStringHandler.AppendFormatted(myclient.user.人物数据.角色ID);
		defaultInterpolatedStringHandler.AppendLiteral("】【发送类型：[");
		defaultInterpolatedStringHandler.AppendFormatted(发送类型);
		defaultInterpolatedStringHandler.AppendLiteral("]】【发送数量：");
		defaultInterpolatedStringHandler.AppendFormatted(发送数量);
		defaultInterpolatedStringHandler.AppendLiteral("】【道具名字：");
		defaultInterpolatedStringHandler.AppendFormatted(道具名字);
		defaultInterpolatedStringHandler.AppendLiteral("】");
		Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
		switch (发送类型)
		{
		case AllEnums.数值Type.等级:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.level, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.道行:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.tao, 发送数量 * 360, false, "后台在线发货");
			break;
		case AllEnums.数值Type.经验:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.exp, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.声望:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.战绩:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.total_score, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.金元宝:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.金元宝, string.Empty, AllEnums.指令Type.无, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.银元宝:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.银元宝, string.Empty, AllEnums.指令Type.无, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.金钱:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.累充点:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.道具:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.道具, 道具名字, AllEnums.指令Type.无, 发送数量, false, "GM发送");
			break;
		case AllEnums.数值Type.体力:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.stamina, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.南极点:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.代金券:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.voucher, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.宠物:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.宠物, 道具名字, AllEnums.指令Type.无, 发送数量, false, "GM发送");
			break;
		case AllEnums.数值Type.坐骑:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.坐骑, 道具名字, AllEnums.指令Type.无, 发送数量, false, "GM发送");
			break;
		case AllEnums.数值Type.奇宝点:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.灵气值:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.点卡点数:
			myclient.user.存档数据.点卡存档.当前点数 += 发送数量;
			break;
		case AllEnums.数值Type.论道点:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.论道点, string.Empty, AllEnums.指令Type.无, 发送数量, false, "后台在线发货");
			break;
		case AllEnums.数值Type.潜能:
			Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.pot, 发送数量, false, "后台在线发货");
			break;
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
		defaultInterpolatedStringHandler.AppendLiteral("获得了#R");
		defaultInterpolatedStringHandler.AppendFormatted(发送数量);
		defaultInterpolatedStringHandler.AppendLiteral("#n");
		string value;
		if (string.IsNullOrWhiteSpace(道具名字))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler2.AppendLiteral("个#R");
			defaultInterpolatedStringHandler2.AppendFormatted(发送类型);
			defaultInterpolatedStringHandler2.AppendLiteral("#n。");
			value = defaultInterpolatedStringHandler2.ToStringAndClear();
		}
		else
		{
			value = "个#R" + 道具名字 + "#n。";
		}
		defaultInterpolatedStringHandler.AppendFormatted(value);
		提示文本 = defaultInterpolatedStringHandler.ToStringAndClear();
		if (!string.IsNullOrWhiteSpace(提示文本))
		{
			myclient.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(提示文本));
		}
		return true;
	}

	
	public void ReadMianConfig()
	{
		Singleton<全局变量类>.I.Config读取();
		Singleton<全局变量类>.I.初始所有配置();
		TimedDungeonService.I.Initialize();
		问道数据类.Init();
		DB.I.fwlNbKZtLa();
		DB.I.vWiNp7QZQV();
		DB.I.OfvNAsuSuZ();
		if (!DB.I.VEaN3PYcQZ())
		{
			Log.Error("【数据库连接异常】请正确假设后并且完善数据库配置信息后重启插件！");
		}
		Singleton<OKaMOvJmaKgK6WqoSYv>.I.APaJXnx4wA();
		if (全局变量类.Is调试)
		{
			Init(Singleton<全局变量类>.I.config.游戏IP);
		}
	}

	
	public MainService()
	{
		Server组 = new ConcurrentDictionary<int, MyNATService>();
		游戏端口对应插件端口组 = new ConcurrentDictionary<short, short>();
		历史IP机器码列表 = new ConcurrentDictionary<string, string>();
		历史IP账号列表 = new ConcurrentDictionary<string, string>();
	}

	static MainService()
	{
	}
}
