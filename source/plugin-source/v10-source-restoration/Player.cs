using System.Runtime.CompilerServices;
using Net.Server;
using Serilog;

public class Player : NetPlayer
{
	internal bool tWVlQZZf7U;

	public string IP;

	
	public override void OnStart()
	{
		base.OnStart();
	}

	
	public override void OnRemoveClient()
	{
		Log.Error(base.RemotePoint.ToString() + " 下线");
		tWVlQZZf7U = false;
		base.OnRemoveClient();
	}

	
	public Player()
	{
		IP = string.Empty;
	}

	static Player()
	{
	}
}
