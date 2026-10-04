using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Serilog;
using TouchSocket.Core;
using TouchSocket.Sockets;

public class MyNATService : NATService
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public NATSocketClient Bf89tPokyw;

		
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		
		internal bool i4o9ZXehRI(string x)
		{
			return x == Bf89tPokyw.IP;
		}

		static _003C_003Ec__DisplayClass3_0()
		{
		}
	}

	public string 游戏IP;

	public int 游戏端口;

	public int 插件端口;

	
	protected override async Task OnConnected(NATSocketClient socketClient, ConnectedEventArgs e)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals13 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals13.Bf89tPokyw = socketClient;
		try
		{
			await base.OnConnected(CS_0024_003C_003E8__locals13.Bf89tPokyw, e);
			if (Singleton<全局变量类>.I.黑名单记录.黑名单IP列表.Any( (string x) => x == CS_0024_003C_003E8__locals13.Bf89tPokyw.IP))
			{
				CS_0024_003C_003E8__locals13.Bf89tPokyw.Close();
				return;
			}
			if (Singleton<全局变量类>.I.验证client.授权配置.Is测试卡 && Singleton<全局变量类>.I.会话Dict.Count( (KeyValuePair<string, MyNATSocketClient> x) => x.Value.使用中) > 15)
			{
				CS_0024_003C_003E8__locals13.Bf89tPokyw.Close();
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(插件端口);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals13.Bf89tPokyw.Id);
			string key = defaultInterpolatedStringHandler.ToStringAndClear();
			if (Singleton<全局变量类>.I.会话Dict.ContainsKey(key))
			{
				CS_0024_003C_003E8__locals13.Bf89tPokyw.Close();
				return;
			}
			NATSocketClient nATSocketClient = CS_0024_003C_003E8__locals13.Bf89tPokyw;
			TouchSocketConfig config = new TouchSocketConfig();
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(游戏IP);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(游戏端口);
			ITcpClient 转发client = nATSocketClient.AddTargetClient(config.SetRemoteIPHost(defaultInterpolatedStringHandler.ToStringAndClear()).SetTcpDataHandlingAdapter( () => new MyFixedHeaderCustomDataHandlingAdapter()).ConfigurePlugins( (IPluginManager a) =>
			{
			}));
			MyNATSocketClient obj = new MyNATSocketClient
			{
				当前client = CS_0024_003C_003E8__locals13.Bf89tPokyw,
				转发client = 转发client,
				游戏IP = 游戏IP,
				游戏端口 = 游戏端口,
				插件端口 = 插件端口
			};
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(插件端口);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals13.Bf89tPokyw.Id);
			obj.IdKey = defaultInterpolatedStringHandler.ToStringAndClear();
			MyNATSocketClient myNATSocketClient = obj;
			MyNATSocketClient myNATSocketClient2 = myNATSocketClient;
			if (myNATSocketClient2.数据队列 == null)
			{
				myNATSocketClient2.数据队列 = new 数据队列类();
			}
			全局变量类 i = Singleton<全局变量类>.I;
			i.Client频道事件 = (Action<byte[]>)Delegate.Combine(i.Client频道事件, new Action<byte[]>(myNATSocketClient.频道返回客户端处理));
			全局变量类 i2 = Singleton<全局变量类>.I;
			i2.限时属性事件 = (Action)Delegate.Combine(i2.限时属性事件, new Action(myNATSocketClient.限时属性处理));
			全局变量类 i3 = Singleton<全局变量类>.I;
			i3.点卡扣除事件 = (Action)Delegate.Combine(i3.点卡扣除事件, new Action(myNATSocketClient.U476qJsWtr));
			Singleton<全局变量类>.I.会话Dict.TryAdd(myNATSocketClient.IdKey, myNATSocketClient);
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 4);
			defaultInterpolatedStringHandler.AppendLiteral("客户端连接失败-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals13.Bf89tPokyw.IP);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals13.Bf89tPokyw.Port);
			defaultInterpolatedStringHandler.AppendLiteral("【");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）】");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			CS_0024_003C_003E8__locals13.Bf89tPokyw.Close();
		}
	}

	
	protected override Task OnDisconnected(NATSocketClient socketClient, DisconnectEventArgs e)
	{
		try
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(插件端口);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(socketClient.Id);
			string key = defaultInterpolatedStringHandler.ToStringAndClear();
			if (Singleton<全局变量类>.I.会话Dict.TryRemove(key, out var value))
			{
				value.使用中 = false;
				全局变量类 i = Singleton<全局变量类>.I;
				i.Client频道事件 = (Action<byte[]>)Delegate.Remove(i.Client频道事件, new Action<byte[]>(value.频道返回客户端处理));
				全局变量类 i2 = Singleton<全局变量类>.I;
				i2.限时属性事件 = (Action)Delegate.Remove(i2.限时属性事件, new Action(value.限时属性处理));
				全局变量类 i3 = Singleton<全局变量类>.I;
				i3.点卡扣除事件 = (Action)Delegate.Remove(i3.点卡扣除事件, new Action(value.U476qJsWtr));
				value.Close();
			}
			return base.OnDisconnected(socketClient, e);
		}
		catch (Exception ex)
		{
			Log.Error("OnDisconnected-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	protected override void OnTargetClientDisconnected(NATSocketClient socketClient, ITcpClient tcpClient, DisconnectEventArgs e)
	{
		try
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(插件端口);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(socketClient.Id);
			string key = defaultInterpolatedStringHandler.ToStringAndClear();
			if (Singleton<全局变量类>.I.会话Dict.TryRemove(key, out var value))
			{
				value.使用中 = false;
				全局变量类 i = Singleton<全局变量类>.I;
				i.Client频道事件 = (Action<byte[]>)Delegate.Remove(i.Client频道事件, new Action<byte[]>(value.频道返回客户端处理));
				全局变量类 i2 = Singleton<全局变量类>.I;
				i2.限时属性事件 = (Action)Delegate.Remove(i2.限时属性事件, new Action(value.限时属性处理));
				全局变量类 i3 = Singleton<全局变量类>.I;
				i3.点卡扣除事件 = (Action)Delegate.Remove(i3.点卡扣除事件, new Action(value.U476qJsWtr));
				value.Close();
			}
			base.OnTargetClientDisconnected(socketClient, tcpClient, e);
		}
		catch (Exception ex)
		{
			Log.Error("OnTargetClientDisconnected-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	protected override byte[] OnNATReceived(NATSocketClient socketClient, ReceivedDataEventArgs e)
	{
		try
		{
			if (e.RequestInfo is MyFixedHeaderRequestInfo myFixedHeaderRequestInfo)
			{
				MainService i = Singleton<MainService>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted(插件端口);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted(socketClient.Id);
				MyNATSocketClient myNATSocketClient = i.获取指定key玩家MyClient(defaultInterpolatedStringHandler.ToStringAndClear());
				if (myNATSocketClient != null && myNATSocketClient.转发client.Online)
				{
					byte[] array = myFixedHeaderRequestInfo.BuildAsBytes();
					if (!MyFixedHeaderRequestInfo.IsValidFrame(array))
					{
						return null;
					}
					if (array.Length > 1000)
					{
						return null;
					}
					if (Singleton<全局变量类>.I.config.is指定辅助 && !Singleton<WdAPI>.I.bJboBw7BEu(myNATSocketClient, myFixedHeaderRequestInfo.timeType))
					{
						return null;
					}
					myNATSocketClient.当前时间字节 = myFixedHeaderRequestInfo.timeType;
					myNATSocketClient.请求时间戳 = Singleton<ByteAPI>.I.取时间戳(是否到秒: false);
					if (Enumerable.SequenceEqual(myFixedHeaderRequestInfo.packType, new byte[2] { 62, 42 }))
					{
						Singleton<WdAPI>.I.WT9IHmFS6c(myNATSocketClient, myNATSocketClient.user.人物数据.昵称);
						Singleton<请求数据响应处理类>.I.请求处理中心(myNATSocketClient, array);
					}
					else
					{
						myNATSocketClient.压入数据队列(array);
					}
					return null;
				}
			}
			return base.OnNATReceived(socketClient, e);
		}
		catch (Exception ex)
		{
			Log.Error("OnNATReceived-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return base.OnNATReceived(socketClient, e);
		}
	}

	
	protected override byte[] OnTargetClientReceived(NATSocketClient socketClient, ITcpClient tcpClient, ReceivedDataEventArgs e)
	{
		try
		{
			if (e.RequestInfo is MyFixedHeaderRequestInfo myFixedHeaderRequestInfo)
			{
				MainService i = Singleton<MainService>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted(插件端口);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted(socketClient.Id);
				MyNATSocketClient myNATSocketClient = i.获取指定key玩家MyClient(defaultInterpolatedStringHandler.ToStringAndClear());
				if (myNATSocketClient != null && myNATSocketClient.转发client.Online)
				{
					byte[] buffer = myFixedHeaderRequestInfo.BuildAsBytes();
					if (!MyFixedHeaderRequestInfo.IsValidFrame(buffer))
					{
						return null;
					}
					bool allow = false;
					myNATSocketClient.返回时间戳 = Singleton<ByteAPI>.I.取时间戳(是否到秒: false);
					return Singleton<接收数据响应处理类>.I.接收处理中心(ref allow, myNATSocketClient, buffer, myFixedHeaderRequestInfo.packType);
				}
				return null;
			}
			return null;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
			defaultInterpolatedStringHandler.AppendLiteral("OnTargetClientReceived-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return null;
		}
	}

	
	public void 预处理76(ref byte[] buffer)
	{
		if (Singleton<ByteAPI>.I.ByteTo十六(Singleton<ByteAPI>.I.取字节集中间(buffer, 10, 3)) == "FD6400")
		{
			buffer = Singleton<ByteAPI>.I.子字节集指定替换(buffer, 10, 2, Singleton<ByteAPI>.I.HtoC(问道数据类.预处理包头["FD6400"]));
			return;
		}
		byte[] buffer2 = Singleton<ByteAPI>.I.取字节集中间(buffer, 10, 2);
		if (问道数据类.预处理包头.TryGetValue(Singleton<ByteAPI>.I.ByteTo十六(buffer2), out string value))
		{
			buffer = Singleton<ByteAPI>.I.子字节集指定替换(buffer, 10, 2, Singleton<ByteAPI>.I.HtoC(value));
		}
	}

	
	public MyNATService()
	{
		游戏IP = string.Empty;
	}

	
	[CompilerGenerated]
	private Task Vol616BHyO(NATSocketClient P_0, ConnectedEventArgs P_1)
	{
		return base.OnConnected(P_0, P_1);
	}

	static MyNATService()
	{
	}
}
