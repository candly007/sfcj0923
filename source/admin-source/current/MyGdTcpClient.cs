using System.Threading;
using System.Threading.Tasks;
using Net.Client;
using Net.Event;

public class MyGdTcpClient : TcpClient
{
	public Thread 心跳Fun;

	public void 验证断开事件()
	{
		NDebug.Log("插件验证异常断开，请重启插件！");
	}

	public void 验证连接事件()
	{
		SendRT(10014, false);
	}

	protected override bool HeartHandler()
	{
		return base.HeartHandler();
	}

	public async void 心跳线程()
	{
		while (true)
		{
			if (base.Connected)
			{
				SendRT(10014, false);
				await Task.Delay(60000);
			}
		}
	}
}
