using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft_X.Json;
using Serilog;
using TouchSocket.Sockets;

public class MyWdClient : SocketClient
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public MyWdClient XqP9TGZTdE;

		public byte[] I2f99Chltl;

		
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		
		internal void kAC9aBgtAr(bool v1, string v2)
		{
			XqP9TGZTdE.DefaultSend(Singleton<ByteAPI>.I.AddByte(I2f99Chltl, (!v1) ? new byte[1] : new byte[1] { 1 }, Singleton<ByteAPI>.I.到字节集(v2)));
		}

		static _003C_003Ec__DisplayClass6_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public MyWdClient cQW9Cai9bK;

		public byte[] pqb9VAh3xB;

		
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		
		internal void KEw9yHWjKt(bool v1, string v2)
		{
			cQW9Cai9bK.DefaultSend(Singleton<ByteAPI>.I.AddByte(pqb9VAh3xB, (!v1) ? new byte[1] : new byte[1] { 1 }, Singleton<ByteAPI>.I.到字节集(v2)));
		}

		static _003C_003Ec__DisplayClass7_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public MyWdClient kq790gONKA;

		public byte[] iM09OjQKix;

		public string[] J599QlHgAC;

		public string[] lWL9EiankB;

		
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		
		internal bool a3Y9kAN3v6(MyNATSocketClient x)
		{
			if (x.使用中)
			{
				return x.user.人物数据.昵称 == J599QlHgAC[0];
			}
			return false;
		}

		static _003C_003Ec__DisplayClass9_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_1
	{
		public int uS89Y6B6oU;

		public _003C_003Ec__DisplayClass9_0 RIM9pOEh6E;

		
		public _003C_003Ec__DisplayClass9_1()
		{
		}

		
		internal void UfE93vIixB(bool v1, string v2)
		{
			RIM9pOEh6E.kq790gONKA.DefaultSend(Singleton<ByteAPI>.I.AddByte(RIM9pOEh6E.iM09OjQKix, new byte[1] { 1 }, Singleton<ByteAPI>.I.到字节集("【" + v2 + "】" + RIM9pOEh6E.lWL9EiankB[uS89Y6B6oU])));
		}

		static _003C_003Ec__DisplayClass9_1()
		{
		}
	}

	public 网关连接用户 当前信息;

	
	protected override Task OnConnecting(ConnectingEventArgs e)
	{
		return base.OnConnecting(e);
	}

	
	protected override Task OnConnected(ConnectedEventArgs e)
	{
		Singleton<全局变量类>.I.网关Server.转换初始封包();
		return base.OnConnected(e);
	}

	
	protected override async Task ReceivedData(ReceivedDataEventArgs e)
	{
		if (e.RequestInfo is WdMyFixedHeaderRequestInfo myRequest)
		{
			await 请求数据处理事件(myRequest);
		}
	}

	
	protected override Task OnDisconnected(DisconnectEventArgs e)
	{
		return base.OnDisconnected(e);
	}

	
	public async Task 请求数据处理事件(WdMyFixedHeaderRequestInfo myRequest)
	{
		_ = 1;
		try
		{
			string text = Singleton<ByteAPI>.I.到文本(myRequest.InfoTye);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("登录器-请求头：");
			defaultInterpolatedStringHandler.AppendFormatted(myRequest.packType[0]);
			defaultInterpolatedStringHandler.AppendLiteral("，数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			Log.Warning(defaultInterpolatedStringHandler.ToStringAndClear());
			if (Enumerable.SequenceEqual(myRequest.packType, new byte[2] { 1, 0 }))
			{
				当前信息 = JsonConvert.DeserializeObject<网关连接用户>(text);
				this.DefaultSend(Singleton<全局变量类>.I.网关Server.初始封包);
				await Task.Delay(1);
			}
			else if (Enumerable.SequenceEqual(myRequest.packType, new byte[2] { 10, 0 }))
			{
				请求_注册事件(myRequest.packType, text);
			}
			else if (Enumerable.SequenceEqual(myRequest.packType, new byte[2] { 20, 0 }))
			{
				请求_修改事件(myRequest.packType, text);
			}
			else if (Enumerable.SequenceEqual(myRequest.packType, new byte[2] { 30, 0 }))
			{
				await 请求_兑换CDK事件(myRequest.packType, text);
			}
			else if (Enumerable.SequenceEqual(myRequest.packType, new byte[2] { 30, 1 }))
			{
				请求_获取角色列表事件(myRequest.packType, text);
			}
			else
			{
				Enumerable.SequenceEqual(myRequest.packType, new byte[2] { 40, 0 });
			}
		}
		catch (Exception ex)
		{
			Log.Error("请求数据处理事件-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public void 请求_注册事件(byte[] 包头, string 请求数据)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals6.XqP9TGZTdE = this;
		CS_0024_003C_003E8__locals6.I2f99Chltl = 包头;
		try
		{
			if (!Singleton<全局变量类>.I.网关Config.共享配置.Is可注册)
			{
				this.DefaultSend(Singleton<ByteAPI>.I.AddByte(CS_0024_003C_003E8__locals6.I2f99Chltl, new byte[1], Singleton<ByteAPI>.I.到字节集("当前并未开启注册通道，无法注册！")));
				return;
			}
			string[] array = 请求数据.Split('|');
			if (array.Length < 9)
			{
				this.DefaultSend(Singleton<ByteAPI>.I.AddByte(CS_0024_003C_003E8__locals6.I2f99Chltl, new byte[1], Singleton<ByteAPI>.I.到字节集("你提交的注册信息有误，注册失败！")));
				return;
			}
			DB.I.网关注册账号事件(array[0], array[1], array[2], array[3], int.Parse(array[4]), int.Parse(array[5]), int.Parse(array[6]), int.Parse(array[7]), int.Parse(array[8]), 当前信息.IP, 当前信息.Mac, 当前信息.历史登录qq.Replace(" ", string.Empty), (array.Length >= 10) ? array[9] : string.Empty,  (bool v1, string v2) =>
			{
				CS_0024_003C_003E8__locals6.XqP9TGZTdE.DefaultSend(Singleton<ByteAPI>.I.AddByte(CS_0024_003C_003E8__locals6.I2f99Chltl, (!v1) ? new byte[1] : new byte[1] { 1 }, Singleton<ByteAPI>.I.到字节集(v2)));
			});
		}
		catch (Exception ex)
		{
			Log.Error("请求_注册事件-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public void 请求_修改事件(byte[] 包头, string 请求数据)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals6.cQW9Cai9bK = this;
		CS_0024_003C_003E8__locals6.pqb9VAh3xB = 包头;
		try
		{
			if (!Singleton<全局变量类>.I.网关Config.共享配置.Is可改密码)
			{
				this.DefaultSend(Singleton<ByteAPI>.I.AddByte(CS_0024_003C_003E8__locals6.pqb9VAh3xB, new byte[1], Singleton<ByteAPI>.I.到字节集("当前并未开启修改密码功能！")));
				return;
			}
			string[] array = 请求数据.Split('|');
			if (array.Length != 3)
			{
				this.DefaultSend(Singleton<ByteAPI>.I.AddByte(CS_0024_003C_003E8__locals6.pqb9VAh3xB, new byte[1], Singleton<ByteAPI>.I.到字节集("你提交的修改密码信息有误！")));
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
			defaultInterpolatedStringHandler.AppendLiteral("修改密码操作：[账号=");
			defaultInterpolatedStringHandler.AppendFormatted(array[0]);
			defaultInterpolatedStringHandler.AppendLiteral("][安全码=");
			defaultInterpolatedStringHandler.AppendFormatted(array[1]);
			defaultInterpolatedStringHandler.AppendLiteral("][新密码=");
			defaultInterpolatedStringHandler.AppendFormatted(array[2]);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			DB.I.网关修改密码事件(array[0], array[1], array[2],  (bool v1, string v2) =>
			{
				CS_0024_003C_003E8__locals6.cQW9Cai9bK.DefaultSend(Singleton<ByteAPI>.I.AddByte(CS_0024_003C_003E8__locals6.pqb9VAh3xB, (!v1) ? new byte[1] : new byte[1] { 1 }, Singleton<ByteAPI>.I.到字节集(v2)));
			});
		}
		catch (Exception ex)
		{
			Log.Error("请求_修改事件-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public void 请求_获取角色列表事件(byte[] 包头, string 请求数据)
	{
		try
		{
			if (!Singleton<全局变量类>.I.网关Config.共享配置.Is可兑换CDK)
			{
				this.DefaultSend(Singleton<ByteAPI>.I.AddByte(包头, new byte[1], Singleton<ByteAPI>.I.到字节集("当前并未开启CDK兑换功能！")));
				return;
			}
			if (string.IsNullOrWhiteSpace(请求数据))
			{
				this.DefaultSend(Singleton<ByteAPI>.I.AddByte(包头, new byte[1], Singleton<ByteAPI>.I.到字节集("你提交的账号有误！")));
				return;
			}
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定角色账号玩家MyClient(请求数据);
			if (myNATSocketClient == null)
			{
				this.DefaultSend(Singleton<ByteAPI>.I.AddByte(包头, new byte[1], Singleton<ByteAPI>.I.到字节集("当前账号下并无任何角色在线！")));
				return;
			}
			this.DefaultSend(Singleton<ByteAPI>.I.AddByte(包头, new byte[1] { 1 }, Singleton<ByteAPI>.I.到字节集(myNATSocketClient.user.人物数据.昵称)));
		}
		catch (Exception ex)
		{
			Log.Error("请求_获取角色列表事件-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public async Task 请求_兑换CDK事件(byte[] 包头, string 请求数据)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals24 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals24.kq790gONKA = this;
		CS_0024_003C_003E8__locals24.iM09OjQKix = 包头;
		try
		{
			if (!Singleton<全局变量类>.I.网关Config.共享配置.Is可兑换CDK)
			{
				this.DefaultSend(Singleton<ByteAPI>.I.AddByte(CS_0024_003C_003E8__locals24.iM09OjQKix, new byte[1], Singleton<ByteAPI>.I.到字节集(请求数据)));
				return;
			}
			if (string.IsNullOrWhiteSpace(请求数据))
			{
				this.DefaultSend(Singleton<ByteAPI>.I.AddByte(CS_0024_003C_003E8__locals24.iM09OjQKix, new byte[1], Singleton<ByteAPI>.I.到字节集(请求数据)));
				return;
			}
			Log.Error("cdk兑换内容：" + 请求数据);
			CS_0024_003C_003E8__locals24.J599QlHgAC = 请求数据.Split("*-*");
			if (CS_0024_003C_003E8__locals24.J599QlHgAC.Length != 2)
			{
				this.DefaultSend(Singleton<ByteAPI>.I.AddByte(CS_0024_003C_003E8__locals24.iM09OjQKix, new byte[1], Singleton<ByteAPI>.I.到字节集(请求数据)));
				return;
			}
			MyNATSocketClient 角色信息 = Singleton<全局变量类>.I.会话Dict.Values.ToList().Find( (MyNATSocketClient x) => x.使用中 && x.user.人物数据.昵称 == CS_0024_003C_003E8__locals24.J599QlHgAC[0]);
			if (角色信息 == null)
			{
				this.DefaultSend(Singleton<ByteAPI>.I.AddByte(CS_0024_003C_003E8__locals24.iM09OjQKix, new byte[1], Singleton<ByteAPI>.I.到字节集(请求数据)));
				return;
			}
			CS_0024_003C_003E8__locals24.lWL9EiankB = CS_0024_003C_003E8__locals24.J599QlHgAC[1].Split("|*|");
			if (CS_0024_003C_003E8__locals24.lWL9EiankB.Length > 50)
			{
				this.DefaultSend(Singleton<ByteAPI>.I.AddByte(CS_0024_003C_003E8__locals24.iM09OjQKix, new byte[1], Singleton<ByteAPI>.I.到字节集(请求数据)));
				return;
			}
			_003C_003Ec__DisplayClass9_1 CS_0024_003C_003E8__locals28 = new _003C_003Ec__DisplayClass9_1();
			CS_0024_003C_003E8__locals28.RIM9pOEh6E = CS_0024_003C_003E8__locals24;
			CS_0024_003C_003E8__locals28.uS89Y6B6oU = 0;
			while (CS_0024_003C_003E8__locals28.uS89Y6B6oU < CS_0024_003C_003E8__locals28.RIM9pOEh6E.lWL9EiankB.Length)
			{
				if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals28.RIM9pOEh6E.lWL9EiankB[CS_0024_003C_003E8__locals28.uS89Y6B6oU]))
				{
					string text = Singleton<ByteAPI>.I.文本_取出中间文本(CS_0024_003C_003E8__locals28.RIM9pOEh6E.lWL9EiankB[CS_0024_003C_003E8__locals28.uS89Y6B6oU], "A*", "*Z");
					await DB.I.IPJNZeRxy9(角色信息, text,  (bool v1, string v2) =>
					{
						CS_0024_003C_003E8__locals28.RIM9pOEh6E.kq790gONKA.DefaultSend(Singleton<ByteAPI>.I.AddByte(CS_0024_003C_003E8__locals28.RIM9pOEh6E.iM09OjQKix, new byte[1] { 1 }, Singleton<ByteAPI>.I.到字节集("【" + v2 + "】" + CS_0024_003C_003E8__locals28.RIM9pOEh6E.lWL9EiankB[CS_0024_003C_003E8__locals28.uS89Y6B6oU])));
					});
				}
				CS_0024_003C_003E8__locals28.uS89Y6B6oU++;
			}
		}
		catch (Exception ex)
		{
			Log.Error("请求_兑换CDK事件-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public MyWdClient()
	{
		当前信息 = new 网关连接用户();
	}

	static MyWdClient()
	{
	}
}
