using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Net.Share;

public class 后台验证交互类 : Singleton<后台验证交互类>, INetworkHandle
{
	
	public Task Init()
	{
		return Task.CompletedTask;
	}

	
	public void OnCloseConnect()
	{
	}

	
	public void OnConnected()
	{
	}

	
	public void OnConnectFailed()
	{
	}

	
	public void OnConnectLost()
	{
	}

	
	public void OnDisconnect()
	{
	}

	
	public void OnQueueCancellation()
	{
	}

	
	public void OnReconnect()
	{
	}

	
	public void OnServerFull()
	{
	}

	
	public void OnTryToConnect()
	{
	}

	
	public void OnWhenQueuing(int totalCount, int count)
	{
	}

	
	public 后台验证交互类()
	{
	}

	static 后台验证交互类()
	{
	}
}
