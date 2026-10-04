using System;
using System.Runtime.CompilerServices;
using Serilog;
using TouchSocket.Core;
using TouchSocket.Sockets;

public class MyFccServer : TcpService<MyFccClient>
{
	
	protected override void LoadConfig(TouchSocketConfig config)
	{
		base.LoadConfig(config);
	}

	
	public void 启动防CC()
	{
		try
		{
			Setup(new TouchSocketConfig().SetListenIPHosts(9999).SetTcpDataHandlingAdapter( () => new WdMyFixedHeaderCustomDataHandlingAdapter()));
			StartAsync().Wait();
		}
		catch (Exception ex)
		{
			Log.Error("防CC启动失败：" + ex.Message);
		}
	}

	
	public MyFccServer()
	{
	}

	static MyFccServer()
	{
	}
}
