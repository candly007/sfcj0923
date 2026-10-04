using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TouchSocket.Sockets;

public class MyFccClient : SocketClient
{
	
	protected override Task OnConnecting(ConnectingEventArgs e)
	{
		if (Singleton<全局变量类>.I.config.防CC开关)
		{
			if (!Singleton<全局变量类>.I.黑名单记录.黑名单IP列表.Any( (string P_0) => P_0 == base.IP))
			{
				Singleton<MainService>.I.server.添加防CCIP白名单(base.IP);
			}
			else
			{
				this.Close();
			}
		}
		return base.OnConnecting(e);
	}

	
	protected override Task OnDisconnected(DisconnectEventArgs e)
	{
		return base.OnDisconnected(e);
	}

	
	public MyFccClient()
	{
	}

	
	[CompilerGenerated]
	private bool tP66k7KlHj(string P_0)
	{
		return P_0 == base.IP;
	}

	static MyFccClient()
	{
	}
}
