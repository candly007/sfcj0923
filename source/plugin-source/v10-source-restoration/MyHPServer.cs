using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft_X.Json;
using Serilog;
using TouchSocket.Core;
using TouchSocket.Sockets;

public class MyHPServer
{
	public MyWdServer server;

	public byte[] 初始封包;

	
	public void 转换初始封包()
	{
		初始封包 = Singleton<ByteAPI>.I.AddByte(new byte[3] { 1, 0, 1 }, Singleton<ByteAPI>.I.到字节集(JsonConvert.SerializeObject(Singleton<全局变量类>.I.网关Config.共享配置, Formatting.Indented)));
	}

	
	public MyHPServer()
	{
		初始封包 = Array.Empty<byte>();
		server = new MyWdServer();
	}

	
	public int 启动网关()
	{
		try
		{
			if (Singleton<全局变量类>.I.验证client?.授权线路启动许可() != true)
			{
				Log.Error("拒绝启动网关：授权或完整性检查未通过");
				return 0;
			}
			if (server.ServerState == ServerState.Running)
			{
				return 2;
			}
			if (Singleton<全局变量类>.I.网关Config.网关端口 == 0)
			{
				return 0;
			}
			server.Setup(new TouchSocketConfig().SetListenIPHosts(Singleton<全局变量类>.I.网关Config.网关端口).SetTcpDataHandlingAdapter( () => new WdMyFixedHeaderCustomDataHandlingAdapter()));
			server.StartAsync().Wait();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("网关后台[");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.网关Config.网关端口);
			defaultInterpolatedStringHandler.AppendLiteral("]端口启动状态：");
			defaultInterpolatedStringHandler.AppendFormatted((server.ServerState == ServerState.Running) ? "成功" : "失败");
			Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
			return (server.ServerState == ServerState.Running) ? 1 : 0;
		}
		catch (Exception ex)
		{
			Log.Error("网关启动失败：" + ex.Message);
			return 0;
		}
	}

	
	public int 关闭网关()
	{
		try
		{
			if (server.ServerState == ServerState.Stopped)
			{
				return 2;
			}
			if (server.ServerState == ServerState.Running)
			{
				server.StopAsync().Wait();
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
			defaultInterpolatedStringHandler.AppendLiteral("网关后台[");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.网关Config.网关端口);
			defaultInterpolatedStringHandler.AppendLiteral("]端口状态：");
			defaultInterpolatedStringHandler.AppendFormatted((server.ServerState == ServerState.Running) ? "启动中" : "已关闭");
			Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
			return (server.ServerState != ServerState.Stopped) ? 1 : 0;
		}
		catch (Exception ex)
		{
			Log.Error("关闭网关失败：" + ex.Message);
			return 0;
		}
	}

	
	internal void gvp607MLJZ()
	{
		if (server.ServerState == ServerState.Running)
		{
			转换初始封包();
			List<MyWdClient> list = server.GetClients().ToList();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].DefaultSend(Singleton<全局变量类>.I.网关Server.初始封包);
			}
		}
	}

	static MyHPServer()
	{
	}
}
