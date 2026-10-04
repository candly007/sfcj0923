using System.Runtime.CompilerServices;
using TouchSocket.Core;
using TouchSocket.Sockets;

public class MyWdServer : TcpService<MyWdClient>
{
	
	protected override void LoadConfig(TouchSocketConfig config)
	{
		base.LoadConfig(config);
	}

	
	public MyWdServer()
	{
	}

	static MyWdServer()
	{
	}
}
