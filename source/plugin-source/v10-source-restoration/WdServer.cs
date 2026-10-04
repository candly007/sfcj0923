using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AM5rMIgHdrOR1f8tXCQ;
using B2uVXfUco7vjsxVN2Bc;
using B6XRmUwQK7iatdTWLwc;
using CKS3DKsTBrUPphoeWmS;
using DRafti6FMxQYhxQAQHW;
using EKROCVD7DRi8Cx5mpUu;
using GJSyJYUDOfxE331QwT1;
using H0Y8GEJQx5wfb6t3alR;
using HS2GfXB7hJCX6tDXuc0;
using KEvDjBdeoLOoBKWXFAH;
using LpZ3AarVOTSw8FiAAE;
using MAZG7tsAp4qxkk1uF8R;
using MGlqQ3brPEBI9uuUVKc;
using MOuTmqw7qFKlAkRNasG;
using Ncq4nMwbH5sPfLR2xwf;
using Net.Serialize;
using Net.Server;
using Net.Share;
using Newtonsoft_X.Json;
using P80h4IDRZbpvERvsoap;
using PB0xx2KvGeQt7ty6y1C;
using PJ8VymWjWDfaUUlTW62;
using QsZODwJPWinsfjttlCn;
using R0F7EJKsPwFRj7h6amU;
using R8lTaqgbEc6MvH2j6n0;
using S0XwWmgI18jlYE3IPoe;
using Serilog;
using SuTsFOBHSZNdBh5bUZB;
using UQuLZEj71kRGhQn6jmQ;
using UbblDNG1yFpxk6Q0ui4;
using VcF0pbBvJqp0x0IfwN;
using XWKUjNiqpjLqc4emuCT;
using YHD6B3jthayZBFfLsaY;
using YOheREbBnDq6LvvWZEr;
using aSItGBlifY3VT2BvkBH;
using aqNktcWvi5bXttp7syQ;
using bDlweAW3n8LaSgX06LQ;
using cVS5v9gmXX8TceaB2WW;
using cwZ0hNl9X9ytQCThyJG;
using dgvsPcDEiqYFlrnMMor;
using eYLrotRIovAGM9lAtVf;
using fko2rGl5XRonNTCL8b0;
using gEdioZfkTLM2TXU6jgd;
using hUWm54DrC1dskj6PIsS;
using htk7ADBGgMdoyiK2inI;
using irBd2ubEj0IMVbGRstp;
using ixYEhcwWIdwrtDxOO94;
using jVVIM9j1PL0VAliGELE;
using kNOi3Vbgo4LTDja4YFk;
using mxyyZlfUTTOCu8Y4ZsN;
using o6qwVWbu5whwUP31LfM;
using q52xqsRVVwmOLlpWkb3;
using r6H7Ets2Rns31EhC17Y;
using rNxGErgTwcV0cyHVsjc;
using s4E8DnU2AI3UWfigLPZ;
using sVcPYnW2a67ob5mDj4x;
using srBApEg0K2LqE1QaSFj;
using swC6eeDmDlHvujbhoCw;
using tMMEyfgcW4XCGjj522C;
using uI75fJjR7A2e7wWdq9f;
using vEAdPGPTkDFOYsbi303;
using wcxwepjSDDAt5sUJfS8;
using xqlPMM2TJRNXpZnNDFn;
using y24fbEG8KTuMIdiCbG1;
using yopQYJj0MvaHRRJcMLp;
using zA970iRwZCxW0g6uljn;

public class WdServer : TcpServer<Player, Scene>
{
	private const int TimedDungeonConfigType = 1000;
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public WdServer yZ6h7Z2KZF;

		public Player UuHhaeQYlM;

		
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		
		internal void qmmhvRgf6U(bool v1, string v2)
		{
			if (!v1)
			{
				yZ6h7Z2KZF.Send(UuHhaeQYlM, 10062, v1, v2);
			}
			else
			{
				yZ6h7Z2KZF.Send(UuHhaeQYlM, 10062, v1, "续费成功！");
				yZ6h7Z2KZF.HBDlxsBCXv(UuHhaeQYlM, true);
			}
		}

		static _003C_003Ec__DisplayClass12_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public WdServer zUEhytogF6;

		public Player X6QhCCtAAy;

		public Action<bool, string> qT3hVQUjI2;

		
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		
		internal void CcphTLgo9e(bool v1, string v2)
		{
			if (!v1)
			{
				Serilog.Log.Error("启动失败！");
				zUEhytogF6.Send(X6QhCCtAAy, 10063, v2);
				return;
			}
			string 真实游戏IP = (全局变量类.Is调试 ? Singleton<全局变量类>.I.config.游戏IP : (Singleton<全局变量类>.I.验证client.是否成功 ? Singleton<全局变量类>.I.config.游戏IP : "255.255.255.255"));
			Singleton<MainService>.I.Init(真实游戏IP,  (bool value1, string value2) =>
			{
				zUEhytogF6.Send(X6QhCCtAAy, 10063, value2);
				zUEhytogF6.HBDlxsBCXv(X6QhCCtAAy, true);
				if (value1)
				{
					zUEhytogF6.Wnhlrr0DCF(X6QhCCtAAy);
				}
			});
		}

		
		internal void stJh9DFpIX(bool value1, string value2)
		{
			zUEhytogF6.Send(X6QhCCtAAy, 10063, value2);
			zUEhytogF6.HBDlxsBCXv(X6QhCCtAAy, true);
			if (value1)
			{
				zUEhytogF6.Wnhlrr0DCF(X6QhCCtAAy);
			}
		}

		static _003C_003Ec__DisplayClass15_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public OnlyTotenData DZNh0ialdl;

		public _003C_003Ec__DisplayClass15_0 uuIhO4Gkky;

		
		public _003C_003Ec__DisplayClass15_1()
		{
		}

		
		internal void QENhkhMwM7(bool value1, string value2)
		{
			if (value1)
			{
				Singleton<全局变量类>.I.验证client.授权配置.更新(DZNh0ialdl.boolist, "私有部署");
			}
			uuIhO4Gkky.zUEhytogF6.Send(uuIhO4Gkky.X6QhCCtAAy, 10063, value2);
			uuIhO4Gkky.zUEhytogF6.HBDlxsBCXv(uuIhO4Gkky.X6QhCCtAAy, true);
			if (value1)
			{
				uuIhO4Gkky.zUEhytogF6.Wnhlrr0DCF(uuIhO4Gkky.X6QhCCtAAy);
			}
		}

		static _003C_003Ec__DisplayClass15_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public WdServer vplhEwU6NB;

		public Player nIph3vhtaB;

		
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		
		internal void vxxhQp9794(int v1, string v2)
		{
			vplhEwU6NB.Send(nIph3vhtaB, 10064, v2);
		}

		static _003C_003Ec__DisplayClass24_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public WdServer JFshphatD6;

		public Player qjth1Eed1d;

		
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		
		internal void gGPhY8sKpS(CDK信息类 v1, bool v2)
		{
			JFshphatD6.Send(qjth1Eed1d, 10066, JsonConvert.SerializeObject(v1, Formatting.Indented), v2);
		}

		static _003C_003Ec__DisplayClass25_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public WdServer JrshHOG2is;

		public Player UZvh4T92Jy;

		
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		
		internal async Task? i0qhxEXe5c()
		{
			List<MyNATSocketClient> list = Singleton<全局变量类>.I.会话Dict.Values.ToList().FindAll( (MyNATSocketClient item) => item.使用中 && item.当前client.Online && item.转发client.Online && item.user.人物数据.GID != 0 && item.user.人物数据.账号 != Singleton<全局变量类>.I.config.挂载GM账号);
			if (list.Count <= 0)
			{
				JrshHOG2is.Send(UZvh4T92Jy, 10065, "当前并无在线玩家。");
				return;
			}
			while (list.Count > 0)
			{
				foreach (MyNATSocketClient item in list)
				{
					if (!item.使用中 || !item.当前client.Online || !item.转发client.Online || item.user.人物数据.GID == 0 || !(item.user.人物数据.账号 != Singleton<全局变量类>.I.config.挂载GM账号))
					{
						continue;
					}
					if (item.user.缓存数据.is战斗中)
					{
						if (item.user.队伍数据.成员列表.Count <= 0 || item.user.队伍数据.is队长)
						{
							Singleton<WdAPI>.I.EOYImZQJeG(item, true);
							await Task.Delay(1000);
							item.S_Send异步(Singleton<WdAPI>.I.zXxoPwQcb0(item.user.人物数据.昵称), "强制所有玩家下线");
						}
					}
					else
					{
						item.S_Send异步(Singleton<WdAPI>.I.lexI4Im4MS(item.user.人物数据.昵称, item.user.缓存数据.is战斗中), "强制所有玩家下线");
					}
				}
				await Task.Delay(1000);
				list = Singleton<全局变量类>.I.会话Dict.Values.ToList().FindAll( (MyNATSocketClient item) => item.使用中 && item.当前client.Online && item.转发client.Online && item.user.人物数据.GID != 0 && item.user.人物数据.账号 != Singleton<全局变量类>.I.config.挂载GM账号);
				WdServer wdServer = JrshHOG2is;
				Player client = UZvh4T92Jy;
				object[] array = new object[1];
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("当前剩余[");
				defaultInterpolatedStringHandler.AppendFormatted(list.Count);
				defaultInterpolatedStringHandler.AppendLiteral("]个玩家在线，请等待......");
				array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
				wdServer.Send(client, 10065, array);
				if (list.Count <= 0)
				{
					break;
				}
			}
			JrshHOG2is.Send(UZvh4T92Jy, 10065, "当前并无在线玩家。");
		}

		static _003C_003Ec__DisplayClass29_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public string zA6hqBc69r;

		
		public _003C_003Ec__DisplayClass33_0()
		{
		}

		
		internal bool twihe7sHPl(MyNATSocketClient a)
		{
			if (a.使用中)
			{
				return a.user.人物数据.昵称 == zA6hqBc69r;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass33_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public WdServer VlcvwuHlCY;

		public Player xAKvbTmUFJ;

		
		public _003C_003Ec__DisplayClass34_0()
		{
		}

		
		internal void WiBhrZKsP4(bool v1)
		{
			VlcvwuHlCY.Send(xAKvbTmUFJ, 10065, v1 ? "发送成功！" : "发送失败！");
		}

		
		internal void kJPhZE4kOV(bool v1)
		{
			VlcvwuHlCY.Send(xAKvbTmUFJ, 10065, v1 ? "发送成功！" : "发送失败！");
		}

		
		internal void fxxhtEdeW0(bool v1)
		{
			VlcvwuHlCY.Send(xAKvbTmUFJ, 10065, v1 ? "发送成功！" : "发送失败！");
		}

		
		internal void LDphAuqvMl(bool v1)
		{
			VlcvwuHlCY.Send(xAKvbTmUFJ, 10065, v1 ? "发送成功！" : "发送失败！");
		}

		
		internal void Mq9hzLDlw9(bool v1)
		{
			VlcvwuHlCY.Send(xAKvbTmUFJ, 10065, v1 ? "发送成功！" : "发送失败！");
		}

		
		internal void y3cvuUgke7(bool v1)
		{
			VlcvwuHlCY.Send(xAKvbTmUFJ, 10065, v1 ? "发送成功！" : "发送失败！");
		}

		static _003C_003Ec__DisplayClass34_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public string gp1vKSwisj;

		
		public _003C_003Ec__DisplayClass35_0()
		{
		}

		
		internal bool N3RvJsEhap(MyNATSocketClient x)
		{
			if (x.使用中 && x.当前client.Online && x.转发client.Online)
			{
				return x.user.人物数据.账号 == gp1vKSwisj;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass35_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public MyNATSocketClient D1kvdjQsjD;

		
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		
		internal bool EiEvRvL22w(string x)
		{
			return x == D1kvdjQsjD.当前client.IP;
		}

		static _003C_003Ec__DisplayClass39_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public MyNATSocketClient bZ3vU1JRHd;

		
		public _003C_003Ec__DisplayClass40_0()
		{
		}

		
		internal bool DZTvsKVDsW(string x)
		{
			return x == bZ3vU1JRHd.Mac;
		}

		static _003C_003Ec__DisplayClass40_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public string[] gyavDocsFX;

		public int EDyvjpqApM;

		public Func<string, bool> xvQvlWGJkm;

		public Predicate<MyNATSocketClient> bQUv8sflcG;

		
		public _003C_003Ec__DisplayClass41_0()
		{
		}

		
		internal bool aUkvWZ5CK8(string x)
		{
			return x == gyavDocsFX[EDyvjpqApM];
		}

		
		internal bool XVjvgcdgbp(MyNATSocketClient x)
		{
			if (x.使用中 && x.当前client.Online && x.转发client.Online)
			{
				return ("|" + x.user.存档数据.账号注册QQ + "|").Contains("|" + gyavDocsFX[EDyvjpqApM] + "|", StringComparison.CurrentCulture);
			}
			return false;
		}

		static _003C_003Ec__DisplayClass41_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public string Y4Avom9NhM;

		
		public _003C_003Ec__DisplayClass52_0()
		{
		}

		
		internal bool hkovIhF2d9(注册信息 x)
		{
			return x.账号 == Y4Avom9NhM;
		}

		static _003C_003Ec__DisplayClass52_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public int i1YvivcNSK;

		
		public _003C_003Ec__DisplayClass59_0()
		{
		}

		
		internal bool TCrvNQb14y(MyNATSocketClient x)
		{
			if (x.使用中 && x.当前client.Online && x.转发client.Online)
			{
				return x.user.人物数据.GID == i1YvivcNSK;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass59_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public int ggwvG4Ah7b;

		
		public _003C_003Ec__DisplayClass60_0()
		{
		}

		
		internal bool W5tvBDA7fR(MyNATSocketClient x)
		{
			if (x.使用中 && x.当前client.Online && x.转发client.Online)
			{
				return x.user.人物数据.GID == ggwvG4Ah7b;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass60_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public WdServer jcHv6y2tX6;

		public Player UtSv2XKwuM;

		
		public _003C_003Ec__DisplayClass64_0()
		{
		}

		
		internal void osgvfNeBXE(string v1)
		{
			jcHv6y2tX6.Send(UtSv2XKwuM, 10074, v1);
		}

		static _003C_003Ec__DisplayClass64_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public string YaovX2RIBE;

		
		public _003C_003Ec__DisplayClass77_0()
		{
		}

		
		internal bool Sx5vmvhFta(MyNATSocketClient x)
		{
			return x.账号 == YaovX2RIBE;
		}

		
		internal bool cAYvPFYIct(角色存档数据类 x)
		{
			return x.账号 == YaovX2RIBE;
		}

		static _003C_003Ec__DisplayClass77_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass78_0
	{
		public WdServer OlcvLqduJp;

		public Player pHFvSHRFkv;

		public int PwGvccwJXw;

		
		public _003C_003Ec__DisplayClass78_0()
		{
		}

		
		internal void CWsvFw3LJF(bool v1, string v2)
		{
			OlcvLqduJp.Send(pHFvSHRFkv, 10083, PwGvccwJXw, v1, v2);
		}

		static _003C_003Ec__DisplayClass78_0()
		{
		}
	}

	public List<string> 防CC命令;

	
	protected override void OnStarting()
	{
		Serilog.Log.Debug("插件后台开始启动...");
	}

	
	protected override void OnStartupCompleted()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
		defaultInterpolatedStringHandler.AppendLiteral("插件后台端口[");
		defaultInterpolatedStringHandler.AppendFormatted(base.Port);
		defaultInterpolatedStringHandler.AppendLiteral("]启动成功...");
		Serilog.Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
		try
		{
			NetConvertBinary.Init();
		}
		catch (Exception ex)
		{
			Serilog.Log.Error(ex, "NetConvertBinary initialization failed: {Exception}", ex.ToString());
			throw;
		}
	}

	
	protected override Scene OnAddDefaultScene()
	{
		return null;
	}

	
	protected override void OnAddPlayerToScene(Player client)
	{
	}

	
	public override void OnSignOut(Player client)
	{
		base.OnSignOut(client);
	}

	
	protected override bool OnUnClientRequest(Player unClient, RPCModel model)
	{
		unClient.IP = unClient.RemotePoint.ToString().Split(':')[0];
		if (!尝试读取RPC字段<byte>(model, "cmd", out var command))
		{
			// A malformed request must not become an authorization bypass for an
			// already authenticated backend session. Player traffic is unaffected.
			if (unClient.tWVlQZZf7U)
			{
				Serilog.Log.Warning("拒绝无法解析 RPC 命令的后台请求：IP={IP}", unClient.IP);
				Send(unClient, 10065, "后台请求格式无效，操作已拒绝。");
				return false;
			}
			return true;
		}
		if (command == 2)
		{
			var methodAvailable = 尝试读取RPC字段<ushort>(model, "methodHash", out var methodHash);
			if (unClient.tWVlQZZf7U && (!methodAvailable || (!后台握手请求(methodHash)
				&& unClient.tWVlQZZf7U
				&& !管理员授权租约有效(unClient))))
			{
				Serilog.Log.Warning("拒绝未授权或无法解析的后台操作：RPC={RPC} IP={IP}", methodAvailable ? methodHash : ushort.MaxValue, unClient.IP);
				Send(unClient, 10065, "授权已失效，插件即将关闭！");
				if (methodAvailable)
					Singleton<全局变量类>.I.验证client?.触发授权失效关闭("后台操作前授权租约无效");
				return false;
			}
		}
		return true;
	}

	private static bool 尝试读取RPC字段<T>(RPCModel model, string name, out T value)
	{
		value = default;
		try
		{
			var field = model.GetType().GetField(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (field?.GetValue(model) is T fieldValue)
			{
				value = fieldValue;
				return true;
			}
			var property = model.GetType().GetProperty(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (property?.GetValue(model) is T propertyValue)
			{
				value = propertyValue;
				return true;
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Warning("读取 RPC 元数据失败：{Message}", ex.Message);
		}
		return false;
	}

	private static bool 后台握手请求(ushort methodHash)
	{
		// 10014 心跳、10015 登录、10020 状态、10023 启动授权必须允许完成初始握手。
		return methodHash is 10014 or 10015 or 10020 or 10023;
	}

	private static bool 管理员授权租约有效(Player player)
	{
		return player != null
			&& player.tWVlQZZf7U
			&& Singleton<全局变量类>.I.验证client?.授权控制面许可() == true;
	}

	private static bool 是有效IPv4(string value)
	{
		return IPAddress.TryParse(value, out var address)
			&& address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork;
	}

	
	[Rpc(cmd = 2, hash = 10014, func = "h1jlEfBrgt")]
	internal void h1jlEfBrgt(Player P_0, bool P_1)
	{
		if (P_1)
		{
			if (!管理员授权租约有效(P_0))
			{
				Send(P_0, 10065, "请先完成后台登录和授权验证！");
			}
			else if (!是有效IPv4(P_0.IP))
			{
				Serilog.Log.Warning("拒绝使用无效后台来源地址放行数据库端口：{IP}", P_0.IP);
				Send(P_0, 10065, "后台来源地址无效，未执行放行。");
			}
			else
			{
				if (OperatingSystem.IsWindows())
				{
					if (!ExecuteWindowsFirewallAllowRule("顺风插件-MySQL-" + P_0.IP, 3306, P_0.IP))
					{
						Send(P_0, 10065, "Windows 防火墙规则更新失败，请使用管理员身份运行 ServerCore。");
						return;
					}
				}
				else
				{
					ExecuteCommand("iptables -I INPUT -s " + P_0.IP + " -p tcp --dport 3306 -j ACCEPT");
				}
				Send(P_0, 10065, "更新成功！");
			}
		}
	}

	
	[Rpc(cmd = 2, hash = 10015, func = "eCvl3Qjo7w")]
	internal async void eCvl3Qjo7w(Player P_0, string P_1, string P_2, string P_3)
	{
		var card = P_1?.Trim() ?? string.Empty;
		if (string.IsNullOrWhiteSpace(card))
		{
			Send(P_0, 10057, false, "请输入授权卡密！");
			return;
		}
		if (!string.Equals(card, Singleton<全局变量类>.I.config.卡密?.Trim(), StringComparison.Ordinal))
		{
			Send(P_0, 10057, false, "卡密错误，禁止进入后台！");
			return;
		}
		var license = await Singleton<全局变量类>.I.验证client.验证授权(
			card, Singleton<全局变量类>.I.config.取当前授权服务器地址());
		if (!license.Valid)
		{
			Send(P_0, 10057, false, "卡密验证失败，禁止进入后台：" + license.Message);
			return;
		}
		if (P_2 != Singleton<全局变量类>.I.config.管理员账号)
		{
			Send(P_0, 10057, false, "管理员账号有误！");
			return;
		}
		if (P_3 != Singleton<全局变量类>.I.config.管理员密码)
		{
			Send(P_0, 10057, false, "管理员密码有误！");
			return;
		}
		Player player = base.Clients.Find( (Player x) => x.tWVlQZZf7U);
		if (player != null)
		{
			Send(player, 10057, false, "你被来自其他终端的用户顶掉，即将下线！");
			OnRemoveClient(player);
		}
		if (!全局变量类.Is调试 && Singleton<全局变量类>.I.插件启动状态)
		{
			Singleton<全局变量类>.I.验证client?.lgalOjYQbI();
		}
		P_0.tWVlQZZf7U = true;
		Send(P_0, 10057, true, "恭喜你，登录[" + P_1 + "]成功！");
		await Task.Delay(50);
		Send(P_0, 10058, Singleton<全局变量类>.I.公告存档);
		await Task.Delay(50);
		Send(P_0, 10059, true, 1, Singleton<全局变量类>.I.Config配置ToJson());
		await Task.Delay(100);
		if (P_0.tWVlQZZf7U && Singleton<全局变量类>.I.插件启动状态)
		{
			HBDlxsBCXv(P_0, true);
			await Task.Delay(50);
		}
		Send(P_0, 10059, true, 37, Singleton<BsbfIlwwf1YnPvbq8GT>.I.LP2wR4cotl());
		await Task.Delay(100);
		Send(P_0, 10059, true, 35, Singleton<GyJyg8g24jqCD31mjD6>.I.NDPgFq96ae());
		await Task.Delay(100);
		Send(P_0, 10059, true, 40, Singleton<xloVkMlT29HN5P5svHC>.I.PcZlVQdEji());
		await Task.Delay(100);
		Send(P_0, 10059, true, 47, Singleton<svsUCqKdlsQkBBIo3St>.I.hxTKgNnEGq());
		await Task.Delay(100);
		Send(P_0, 10059, true, 49, Singleton<sUhuV4s664O5VhBMqaF>.I.opFsXCbOIy());
		await Task.Delay(100);
		Send(P_0, 10059, true, 50, Singleton<cCs7kYlNIp7pmjCmEml>.I.CfZlfyC6Ah());
		await Task.Delay(100);
		Send(P_0, 10059, true, 51, Singleton<APqDp4bq1ecVdMifnI1>.I.UD9bASX4uS());
		await Task.Delay(100);
		Send(P_0, 10059, true, 52, Singleton<LaobQfgSrA1tYPe60GA>.I.uvXgM9EuOq());
		await Task.Delay(100);
		Send(P_0, 10059, true, 53, Singleton<U8hGTORuviqLJbXPJ0Y>.I.E05RKVDNcJ());
		await Task.Delay(100);
		Send(P_0, 10059, true, 54, Singleton<xxsAZpga7ronqw5ilvg>.I.T1vgCLCOYE());
		await Task.Delay(100);
		Send(P_0, 10059, true, 46, Singleton<AZI1HsR8MjRfegmETY5>.I.aZCRi5ea9K());
		await Task.Delay(100);
		Send(P_0, 10059, true, 55, Singleton<pN4kvFDKqDQRQBnO8BW>.I.AD9DUWCLuf());
		await Task.Delay(100);
		Send(P_0, 10059, true, 44, Singleton<FcVoHRwOVsflDmDUQOP>.I.EQrwYJO23T());
		await Task.Delay(100);
		Send(P_0, 10059, true, 56, Singleton<mDs6hiBvFvG3CRi3MZk>.I.EOWB9RqD3q());
		await Task.Delay(100);
		Send(P_0, 10059, true, 57, Singleton<pN4kvFDKqDQRQBnO8BW>.I.CMCDjg0Hj2());
		await Task.Delay(100);
		Send(P_0, 10059, true, 58, Singleton<KmvE5t6XclSPSYZqqE9>.I.eRy6cDlFsl());
		await Task.Delay(100);
		Send(P_0, 10059, true, 59, Singleton<rZ9xAdgxKYQQZPeE8Rm>.I.tdmgrdkXXP());
		await Task.Delay(100);
		Send(P_0, 10059, true, 60, Singleton<xKp3aGWENEfI6KIHVKi>.I.GBbWeFLi6m());
		await Task.Delay(100);
		Send(P_0, 10059, true, 61, Singleton<QxBx5YDqZUOBMg9A6NN>.I.KPRDAP1Op1());
		await Task.Delay(100);
		Send(P_0, 10059, true, 62, Singleton<S0U8ESlnAtMSWsCIoNo>.I.wnxlvpJ53o());
		await Task.Delay(100);
		Send(P_0, 10059, true, 63, Singleton<TOqsYfW68LIGjCtAgK8>.I.THDWXSOgh3());
		await Task.Delay(100);
		Send(P_0, 10059, true, 64, Singleton<YHfw7nGpg7WfdCBKDH4>.I.kQyG43gxlw());
		await Task.Delay(100);
		Send(P_0, 10059, true, 65, Singleton<yuKf6DUSQGygKeLSQdj>.I.GtIUMUM1g7());
		await Task.Delay(100);
		Send(P_0, 10059, true, 66, Singleton<MtacAPJOeul0knZiQar>.I.dRGJYYbTKu());
		await Task.Delay(100);
		Send(P_0, 10059, true, 68, Singleton<mQEQjEBxYW4SsAecBHJ>.I.IvkBquR2HE());
		await Task.Delay(100);
		Send(P_0, 10059, true, 69, Singleton<XhaJ3cfswGhhnmIequv>.I.TptfDBxime());
		await Task.Delay(100);
		Send(P_0, 10059, true, 9, Singleton<iRGieud4qtscW6ESmxk>.I.OCfdZSboSF());
		await Task.Delay(200);
		Send(P_0, 10059, true, 12, Singleton<浮生录功能>.I.zu8U03iVFQ());
		await Task.Delay(200);
		Send(P_0, 10059, true, 8, Singleton<MbtVicwUkp5LuxTooFW>.I.nmwwj3ov5K());
		await Task.Delay(200);
		Send(P_0, 10059, true, 70, Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.cjR2E2RJAj());
		await Task.Delay(100);
		Send(P_0, 10059, true, 71, Singleton<OmF9SPGlN77YLFkkoqN>.I.nVdGNZ1SEe());
		await Task.Delay(100);
		Send(P_0, 10059, true, 72, Singleton<xH3TPsiexTnpJAMMnJm>.I.EOniteRSQC());
		await Task.Delay(100);
		Send(P_0, 10059, true, 73, Singleton<pGS3mljky49pI9pArc9>.I.yhPjEpfa3d());
		await Task.Delay(100);
		Send(P_0, 10059, true, 74, Singleton<uh2edhfVGtogUy49Lpv>.I.AHrfQdHMKD());
	}

	
	[Rpc(cmd = 2, hash = 10017, func = "N3ilY2Koyd")]
	internal async void N3ilY2Koyd(Player P_0, int P_1)
	{
		_ = 30;
		try
		{
			if (!P_0.tWVlQZZf7U)
			{
				Send(P_0, 10059, false, P_1, "请先登录管理员！");
				return;
			}
			if (P_1 == TimedDungeonConfigType)
			{
				Send(P_0, 10059, true, P_1, TimedDungeonService.I.GetConfigJson());
				return;
			}
			switch ((AllEnums.后台通信类型)P_1)
			{
			case AllEnums.后台通信类型.获取所有配置:
				Send(P_0, 10059, true, 1, Singleton<全局变量类>.I.Config配置ToJson());
				await Task.Delay(100);
				Send(P_0, 10059, true, 2, Singleton<OxtnHXwv6N41rhEtfdc>.I.eM8w9U81fV());
				await Task.Delay(100);
				Send(P_0, 10059, true, 3, Singleton<VlLcswg81JdPCi5w8lm>.I.fTSgiE2Qro());
				await Task.Delay(100);
				Send(P_0, 10059, true, 4, Singleton<OKaMOvJmaKgK6WqoSYv>.I.fC8J59qKTa());
				await Task.Delay(100);
				Send(P_0, 10059, true, 5, Singleton<fFv8GpjvE2cusnNqivq>.I.VZ2j9tqxiw());
				await Task.Delay(100);
				Send(P_0, 10059, true, 6, Singleton<KU0aMobWe16QEEmpLCj>.I.kx5bl7uTFr());
				await Task.Delay(100);
				Send(P_0, 10059, true, 7, Singleton<L4IbybsayJA7RG5d8t7>.I.N5TsCgqBI4());
				await Task.Delay(100);
				Send(P_0, 10059, true, 8, Singleton<MbtVicwUkp5LuxTooFW>.I.nmwwj3ov5K());
				await Task.Delay(100);
				Send(P_0, 10059, true, 9, Singleton<iRGieud4qtscW6ESmxk>.I.OCfdZSboSF());
				await Task.Delay(100);
				Send(P_0, 10059, true, 10, Singleton<BpcEfFbiGBBV3s2B0ai>.I.WPLb6Xy65R());
				await Task.Delay(100);
				Send(P_0, 10059, true, 11, Singleton<EfHAVFUgqrnaj1QwnLW>.I.T4aU8b0msE());
				await Task.Delay(100);
				Send(P_0, 10059, true, 12, Singleton<浮生录功能>.I.zu8U03iVFQ());
				await Task.Delay(100);
				Send(P_0, 10059, true, 15, Singleton<zeYnwTjKgpmAbfSQh5J>.I.xVfjUb6CVC());
				await Task.Delay(100);
				Send(P_0, 10059, true, 16, Singleton<lrYK0bWD4sTSDkaJic1>.I.KjUWISAYCu());
				await Task.Delay(100);
				Send(P_0, 10059, true, 17, Singleton<FoohJvKhxbMTfceeiIF>.I.oGwK3CjB6O());
				await Task.Delay(100);
				Send(P_0, 10059, true, 18, Singleton<DB9OkbjZMmmdyW1KQMk>.I.EdKlb3p3jo());
				await Task.Delay(100);
				Send(P_0, 10059, true, 19, Singleton<t3Hr1lRCL4Z1QF9uWXP>.I.gXERQBLW9A());
				await Task.Delay(100);
				Send(P_0, 10059, true, 20, Singleton<pn8GKqU6fTj7IRdG6Bm>.I.lwmUXS1MmP());
				await Task.Delay(100);
				Send(P_0, 10059, true, 21, Singleton<等级道行检测功能>.I.ybqguthC6f());
				await Task.Delay(100);
				Send(P_0, 10059, true, 22, Singleton<FoohJvKhxbMTfceeiIF>.I.WwXKyq2YXx());
				await Task.Delay(100);
				Send(P_0, 10059, true, 23, Singleton<KB0ManjLR9N2YNMntee>.I.sMyj5SvIp0());
				await Task.Delay(100);
				Send(P_0, 10059, true, 24, Singleton<RdU9KHgkxD6vGY8ZRKE>.I.yMmgE4jXIY());
				await Task.Delay(100);
				Send(P_0, 10059, true, 25, Singleton<FoohJvKhxbMTfceeiIF>.I.bTVK0xQw8v());
				await Task.Delay(100);
				Send(P_0, 10059, true, 26, Singleton<Rfq62uDvr7Ur9Lpyctd>.I.whnD92BCek());
				await Task.Delay(100);
				Send(P_0, 10059, true, 27, Singleton<DB9OkbjZMmmdyW1KQMk>.I.FBaldgRFjW());
				await Task.Delay(100);
				Send(P_0, 10059, true, 28, Singleton<DB9OkbjZMmmdyW1KQMk>.I.k42lgB0Cf0());
				await Task.Delay(100);
				Send(P_0, 10059, true, 29, Singleton<FusVSwwzpuFHNrjHS7T>.I.c75bJttR9s());
				await Task.Delay(100);
				Send(P_0, 10059, true, 30, Singleton<WI2SZ8qRj7MBmbqI09>.I.UMDAfv45b());
				await Task.Delay(100);
				Send(P_0, 10059, true, 31, Singleton<FBGRmlstyRWQdqi0pHa>.I.bLVUww08og());
				await Task.Delay(100);
				Send(P_0, 10059, true, 32, Singleton<VuI4pmDQ6nQtpDAauah>.I.xV4DpjcO6v());
				await Task.Delay(100);
				Send(P_0, 10059, true, 33, Singleton<fK6mLrjpv26MU2YIIF9>.I.ABkj4vsRRs());
				await Task.Delay(100);
				Send(P_0, 10059, true, 34, Singleton<FoINHjWh9BHxZ3BiiA5>.I.m9MWTREQxX());
				break;
			case AllEnums.后台通信类型.后台首页配置:
				Send(P_0, 10059, true, P_1, Singleton<全局变量类>.I.Config配置ToJson());
				break;
			case AllEnums.后台通信类型.南极抽奖配置:
				Send(P_0, 10059, true, P_1, Singleton<OxtnHXwv6N41rhEtfdc>.I.eM8w9U81fV());
				break;
			case AllEnums.后台通信类型.累充奖励配置:
				Send(P_0, 10059, true, P_1, Singleton<VlLcswg81JdPCi5w8lm>.I.fTSgiE2Qro());
				break;
			case AllEnums.后台通信类型.全服泡点配置:
				Send(P_0, 10059, true, P_1, Singleton<OKaMOvJmaKgK6WqoSYv>.I.fC8J59qKTa());
				break;
			case AllEnums.后台通信类型.道宠回收配置:
				Send(P_0, 10059, true, P_1, Singleton<fFv8GpjvE2cusnNqivq>.I.VZ2j9tqxiw());
				break;
			case AllEnums.后台通信类型.喊话限制配置:
				Send(P_0, 10059, true, P_1, Singleton<KU0aMobWe16QEEmpLCj>.I.kx5bl7uTFr());
				break;
			case AllEnums.后台通信类型.专属会员配置:
				Send(P_0, 10059, true, P_1, Singleton<L4IbybsayJA7RG5d8t7>.I.N5TsCgqBI4());
				break;
			case AllEnums.后台通信类型.六道轮回配置:
				Send(P_0, 10059, true, P_1, Singleton<MbtVicwUkp5LuxTooFW>.I.nmwwj3ov5K());
				break;
			case AllEnums.后台通信类型.异兽图鉴配置:
				Send(P_0, 10059, true, P_1, Singleton<iRGieud4qtscW6ESmxk>.I.OCfdZSboSF());
				break;
			case AllEnums.后台通信类型.无双战场配置:
				Send(P_0, 10059, true, P_1, Singleton<BpcEfFbiGBBV3s2B0ai>.I.WPLb6Xy65R());
				break;
			case AllEnums.后台通信类型.推荐拉人配置:
				Send(P_0, 10059, true, P_1, Singleton<EfHAVFUgqrnaj1QwnLW>.I.T4aU8b0msE());
				break;
			case AllEnums.后台通信类型.浮生化身配置:
				Send(P_0, 10059, true, P_1, Singleton<浮生录功能>.I.zu8U03iVFQ());
				break;
			case AllEnums.后台通信类型.超级道具配置:
				Send(P_0, 10059, true, P_1, Singleton<zeYnwTjKgpmAbfSQh5J>.I.xVfjUb6CVC());
				break;
			case AllEnums.后台通信类型.燃眉之急配置:
				Send(P_0, 10059, true, P_1, Singleton<lrYK0bWD4sTSDkaJic1>.I.KjUWISAYCu());
				break;
			case AllEnums.后台通信类型.宠物同源配置:
				Send(P_0, 10059, true, P_1, Singleton<FoohJvKhxbMTfceeiIF>.I.oGwK3CjB6O());
				break;
			case AllEnums.后台通信类型.门派转换配置:
				Send(P_0, 10059, true, P_1, Singleton<DB9OkbjZMmmdyW1KQMk>.I.EdKlb3p3jo());
				break;
			case AllEnums.后台通信类型.属性洗炼配置:
				Send(P_0, 10059, true, P_1, Singleton<t3Hr1lRCL4Z1QF9uWXP>.I.gXERQBLW9A());
				break;
			case AllEnums.后台通信类型.时装染色配置:
				Send(P_0, 10059, true, P_1, Singleton<pn8GKqU6fTj7IRdG6Bm>.I.lwmUXS1MmP());
				break;
			case AllEnums.后台通信类型.检测限制配置:
				Send(P_0, 10059, true, P_1, Singleton<等级道行检测功能>.I.ybqguthC6f());
				break;
			case AllEnums.后台通信类型.宠物召唤配置:
				Send(P_0, 10059, true, P_1, Singleton<FoohJvKhxbMTfceeiIF>.I.WwXKyq2YXx());
				break;
			case AllEnums.后台通信类型.天塔突破配置:
				Send(P_0, 10059, true, P_1, Singleton<KB0ManjLR9N2YNMntee>.I.sMyj5SvIp0());
				break;
			case AllEnums.后台通信类型.自选礼包配置:
				Send(P_0, 10059, true, P_1, Singleton<RdU9KHgkxD6vGY8ZRKE>.I.yMmgE4jXIY());
				break;
			case AllEnums.后台通信类型.宠物绑定配置:
				Send(P_0, 10059, true, P_1, Singleton<FoohJvKhxbMTfceeiIF>.I.bTVK0xQw8v());
				break;
			case AllEnums.后台通信类型.超级地图配置:
				Send(P_0, 10059, true, P_1, Singleton<Rfq62uDvr7Ur9Lpyctd>.I.whnD92BCek());
				break;
			case AllEnums.后台通信类型.一键飞升配置:
				Send(P_0, 10059, true, P_1, Singleton<DB9OkbjZMmmdyW1KQMk>.I.FBaldgRFjW());
				break;
			case AllEnums.后台通信类型.法宝共生配置:
				Send(P_0, 10059, true, P_1, Singleton<DB9OkbjZMmmdyW1KQMk>.I.k42lgB0Cf0());
				break;
			case AllEnums.后台通信类型.商城限购配置:
				Send(P_0, 10059, true, P_1, Singleton<FusVSwwzpuFHNrjHS7T>.I.c75bJttR9s());
				break;
			case AllEnums.后台通信类型.元宝礼包配置:
				Send(P_0, 10059, true, P_1, Singleton<WI2SZ8qRj7MBmbqI09>.I.UMDAfv45b());
				break;
			case AllEnums.后台通信类型.超级BOSS配置:
				Send(P_0, 10059, true, P_1, Singleton<FBGRmlstyRWQdqi0pHa>.I.bLVUww08og());
				break;
			case AllEnums.后台通信类型.超级坐骑配置:
				Send(P_0, 10059, true, P_1, Singleton<VuI4pmDQ6nQtpDAauah>.I.xV4DpjcO6v());
				break;
			case AllEnums.后台通信类型.定义邮箱配置:
				Send(P_0, 10059, true, P_1, Singleton<fK6mLrjpv26MU2YIIF9>.I.ABkj4vsRRs());
				break;
			case AllEnums.后台通信类型.百炼合成配置:
				Send(P_0, 10059, true, P_1, Singleton<FoINHjWh9BHxZ3BiiA5>.I.m9MWTREQxX());
				break;
			case AllEnums.后台通信类型.网关配置:
				Send(P_0, 10059, true, 35, Singleton<GyJyg8g24jqCD31mjD6>.I.NDPgFq96ae());
				Send(P_0, 10056, true, Singleton<全局变量类>.I.网关Server.启动网关());
				break;
			case AllEnums.后台通信类型.超级NPC配置:
				Send(P_0, 10059, true, 36, Singleton<超级NPC功能>.I.TCsDhAwkCx());
				break;
			case AllEnums.后台通信类型.共享存档配置:
				Send(P_0, 10059, true, 37, Singleton<BsbfIlwwf1YnPvbq8GT>.I.LP2wR4cotl());
				break;
			case AllEnums.后台通信类型.道行达标配置:
				Send(P_0, 10059, true, 38, Singleton<L4IbybsayJA7RG5d8t7>.I.PAxsOqS9w0());
				break;
			case AllEnums.后台通信类型.活跃奖励配置:
				Send(P_0, 10059, true, 39, Singleton<L4IbybsayJA7RG5d8t7>.I.XBTsY9u8tI());
				break;
			case AllEnums.后台通信类型.黑名单记录:
				Send(P_0, 10059, true, 40, Singleton<xloVkMlT29HN5P5svHC>.I.PcZlVQdEji());
				break;
			case AllEnums.后台通信类型.签到配置:
				Send(P_0, 10059, true, 41, Singleton<p63Ra5gwg6vJ45gPiim>.I.oWYgR5m966());
				break;
			case AllEnums.后台通信类型.盲盒配置:
				Send(P_0, 10059, true, 42, Singleton<xKp3aGWENEfI6KIHVKi>.I.iVwW1qtOUK());
				break;
			case AllEnums.后台通信类型.在线抽奖配置:
				Send(P_0, 10059, true, 43, Singleton<cGiRplbQfaJV9guWDIS>.I.bLKbpAqRyh());
				break;
			case AllEnums.后台通信类型.召唤精怪配置:
				Send(P_0, 10059, true, 44, Singleton<FcVoHRwOVsflDmDUQOP>.I.EQrwYJO23T());
				break;
			case AllEnums.后台通信类型.试道大会配置:
				Send(P_0, 10059, true, 45, Singleton<SSW8tHD2MvRIUVygbNo>.I.ODUDFZHiP3());
				break;
			case AllEnums.后台通信类型.宠物转生配置:
				Send(P_0, 10059, true, 46, Singleton<AZI1HsR8MjRfegmETY5>.I.aZCRi5ea9K());
				break;
			case AllEnums.后台通信类型.奇宝斋配置:
				Send(P_0, 10059, true, 47, Singleton<svsUCqKdlsQkBBIo3St>.I.hxTKgNnEGq());
				break;
			case AllEnums.后台通信类型.妖族化形配置:
				Send(P_0, 10059, true, 48, Singleton<妖族化形功能>.I.yFBKMD6Llw());
				break;
			case AllEnums.后台通信类型.怀旧专区配置:
				Send(P_0, 10059, true, 49, Singleton<sUhuV4s664O5VhBMqaF>.I.opFsXCbOIy());
				break;
			case AllEnums.后台通信类型.首饰系统配置:
				Send(P_0, 10059, true, 50, Singleton<cCs7kYlNIp7pmjCmEml>.I.CfZlfyC6Ah());
				break;
			case AllEnums.后台通信类型.融丹配置:
				Send(P_0, 10059, true, 51, Singleton<APqDp4bq1ecVdMifnI1>.I.UD9bASX4uS());
				break;
			case AllEnums.后台通信类型.守护配置:
				Send(P_0, 10059, true, 52, Singleton<LaobQfgSrA1tYPe60GA>.I.uvXgM9EuOq());
				break;
			case AllEnums.后台通信类型.宠物突破配置:
				Send(P_0, 10059, true, 53, Singleton<U8hGTORuviqLJbXPJ0Y>.I.E05RKVDNcJ());
				break;
			case AllEnums.后台通信类型.自定义宠物:
				Send(P_0, 10059, true, 54, Singleton<xxsAZpga7ronqw5ilvg>.I.T1vgCLCOYE());
				break;
			case AllEnums.后台通信类型.装备系统配置:
				Send(P_0, 10059, true, 55, Singleton<pN4kvFDKqDQRQBnO8BW>.I.AD9DUWCLuf());
				break;
			case AllEnums.后台通信类型.地府商城配置:
				Send(P_0, 10059, true, 56, Singleton<mDs6hiBvFvG3CRi3MZk>.I.EOWB9RqD3q());
				break;
			case AllEnums.后台通信类型.装备分解配置:
				Send(P_0, 10059, true, 57, Singleton<pN4kvFDKqDQRQBnO8BW>.I.CMCDjg0Hj2());
				break;
			case AllEnums.后台通信类型.龙血BOSS配置:
				Send(P_0, 10059, true, 58, Singleton<KmvE5t6XclSPSYZqqE9>.I.eRy6cDlFsl());
				break;
			case AllEnums.后台通信类型.装备强化配置:
				Send(P_0, 10059, true, 59, Singleton<rZ9xAdgxKYQQZPeE8Rm>.I.tdmgrdkXXP());
				break;
			case AllEnums.后台通信类型.礼包飘屏配置:
				Send(P_0, 10059, true, 60, Singleton<xKp3aGWENEfI6KIHVKi>.I.GBbWeFLi6m());
				break;
			case AllEnums.后台通信类型.超级进化配置:
				Send(P_0, 10059, true, 61, Singleton<QxBx5YDqZUOBMg9A6NN>.I.KPRDAP1Op1());
				break;
			case AllEnums.后台通信类型.鸿运当头配置:
				Send(P_0, 10059, true, 62, Singleton<S0U8ESlnAtMSWsCIoNo>.I.wnxlvpJ53o());
				break;
			case AllEnums.后台通信类型.特效配置:
				Send(P_0, 10059, true, 63, Singleton<TOqsYfW68LIGjCtAgK8>.I.THDWXSOgh3());
				break;
			case AllEnums.后台通信类型.摆摊配置:
				Send(P_0, 10059, true, 64, Singleton<YHfw7nGpg7WfdCBKDH4>.I.kQyG43gxlw());
				break;
			case AllEnums.后台通信类型.智能怪物配置:
				Send(P_0, 10059, true, 65, Singleton<yuKf6DUSQGygKeLSQdj>.I.GtIUMUM1g7());
				break;
			case AllEnums.后台通信类型.天机神算配置:
				Send(P_0, 10059, true, 66, Singleton<MtacAPJOeul0knZiQar>.I.dRGJYYbTKu());
				break;
			case AllEnums.后台通信类型.娃娃配置:
				Send(P_0, 10059, true, 68, Singleton<mQEQjEBxYW4SsAecBHJ>.I.IvkBquR2HE());
				break;
			case AllEnums.后台通信类型.日常配置:
				Send(P_0, 10059, true, 69, Singleton<XhaJ3cfswGhhnmIequv>.I.TptfDBxime());
				break;
			case AllEnums.后台通信类型.元神系统配置:
				Send(P_0, 10059, true, 70, Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.cjR2E2RJAj());
				break;
			case AllEnums.后台通信类型.狐狸和狗配置:
				Send(P_0, 10059, true, 71, Singleton<OmF9SPGlN77YLFkkoqN>.I.nVdGNZ1SEe());
				break;
			case AllEnums.后台通信类型.内充支付配置:
				Send(P_0, 10059, true, 72, Singleton<xH3TPsiexTnpJAMMnJm>.I.EOniteRSQC());
				break;
			case AllEnums.后台通信类型.道具数据配置:
				Send(P_0, 10059, true, 73, Singleton<pGS3mljky49pI9pArc9>.I.yhPjEpfa3d());
				break;
			case AllEnums.后台通信类型.自助商店配置:
				Send(P_0, 10059, true, 74, Singleton<uh2edhfVGtogUy49Lpv>.I.AHrfQdHMKD());
				break;
			case AllEnums.后台通信类型.角色监控信息:
			case AllEnums.后台通信类型.CDK兑换信息:
			case AllEnums.后台通信类型.专属合区配置:
				break;
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求获取配置-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10018, func = "hYblpshwyM")]
	internal void hYblpshwyM(Player P_0, int P_1, string P_2)
	{
		try
		{
			if (P_0.tWVlQZZf7U)
			{
				if (P_1 == TimedDungeonConfigType)
				{
					TimedDungeonService.I.UpdateConfigJson(P_2);
					Send(P_0, 10060, "限时副本地图配置保存完毕！");
					return;
				}
				switch ((AllEnums.后台通信类型)P_1)
				{
				case AllEnums.后台通信类型.后台首页配置:
					Singleton<全局变量类>.I.ConfigJsonTo配置(P_2);
					Send(P_0, 10060, "首页配置保存完毕！");
					break;
				case AllEnums.后台通信类型.南极抽奖配置:
					Singleton<OxtnHXwv6N41rhEtfdc>.I.eybwyF7b1e(P_2);
					Send(P_0, 10060, "南极配置保存完毕！");
					break;
				case AllEnums.后台通信类型.累充奖励配置:
					Singleton<VlLcswg81JdPCi5w8lm>.I.SokgBiG3MJ(P_2);
					Send(P_0, 10060, "累充配置保存完毕！");
					break;
				case AllEnums.后台通信类型.全服泡点配置:
					Singleton<OKaMOvJmaKgK6WqoSYv>.I.Q9fJMk65PL(P_2);
					Send(P_0, 10060, "泡点配置保存完毕！");
					break;
				case AllEnums.后台通信类型.道宠回收配置:
					Singleton<fFv8GpjvE2cusnNqivq>.I.mPdjyWF3yY(P_2);
					Send(P_0, 10060, "道宠回收配置保存完毕！");
					break;
				case AllEnums.后台通信类型.喊话限制配置:
					Singleton<KU0aMobWe16QEEmpLCj>.I.Onjb8EdMVV(P_2);
					Send(P_0, 10060, "喊话配置保存完毕！");
					break;
				case AllEnums.后台通信类型.专属会员配置:
					Singleton<L4IbybsayJA7RG5d8t7>.I.x5HsVAvg3Z(P_2);
					Send(P_0, 10060, "专属会员配置保存完毕！");
					break;
				case AllEnums.后台通信类型.六道轮回配置:
					Singleton<MbtVicwUkp5LuxTooFW>.I.RniwlKKj9C(P_2);
					Send(P_0, 10060, "六道轮回配置保存完毕！");
					break;
				case AllEnums.后台通信类型.异兽图鉴配置:
					Singleton<iRGieud4qtscW6ESmxk>.I.dcidtIYJfS(P_2);
					Send(P_0, 10060, "异兽录配置保存完毕！");
					break;
				case AllEnums.后台通信类型.无双战场配置:
					Singleton<BpcEfFbiGBBV3s2B0ai>.I.m67b2CrTje(P_2);
					Send(P_0, 10060, "圣无双配置保存完毕！");
					break;
				case AllEnums.后台通信类型.推荐拉人配置:
					Singleton<EfHAVFUgqrnaj1QwnLW>.I.rZPUIjo2EM(P_2);
					Send(P_0, 10060, "推荐拉人配置保存完毕！");
					break;
				case AllEnums.后台通信类型.浮生化身配置:
					Singleton<浮生录功能>.I.JsonTo配置(P_2);
					Send(P_0, 10060, "浮生录配置保存完毕！");
					break;
				case AllEnums.后台通信类型.超级道具配置:
					Singleton<zeYnwTjKgpmAbfSQh5J>.I.TAdjWknqoD(P_2);
					Send(P_0, 10060, "超级道具配置保存完毕！");
					break;
				case AllEnums.后台通信类型.燃眉之急配置:
					Singleton<lrYK0bWD4sTSDkaJic1>.I.T02WoMyoAm(P_2);
					Send(P_0, 10060, "燃眉之急配置保存完毕！");
					break;
				case AllEnums.后台通信类型.宠物同源配置:
					Singleton<FoohJvKhxbMTfceeiIF>.I.tQKKYMOPrl(P_2);
					Send(P_0, 10060, "宠物同源配置保存完毕！");
					break;
				case AllEnums.后台通信类型.门派转换配置:
					Singleton<DB9OkbjZMmmdyW1KQMk>.I.qr2lJfZFlI(P_2);
					Send(P_0, 10060, "门派转换配置保存完毕！");
					break;
				case AllEnums.后台通信类型.属性洗炼配置:
					Singleton<t3Hr1lRCL4Z1QF9uWXP>.I.ue8REjR2bZ(P_2);
					Send(P_0, 10060, "属性洗炼配置保存完毕！");
					break;
				case AllEnums.后台通信类型.时装染色配置:
					Singleton<pn8GKqU6fTj7IRdG6Bm>.I.RGQUFfsNVt(P_2);
					Send(P_0, 10060, "时装坐姿染色配置保存完毕！");
					break;
				case AllEnums.后台通信类型.检测限制配置:
					Singleton<等级道行检测功能>.I.JsonTo配置(P_2);
					Send(P_0, 10060, "检测限制配置保存完毕！");
					break;
				case AllEnums.后台通信类型.宠物召唤配置:
					Singleton<FoohJvKhxbMTfceeiIF>.I.LjmKC4Pywu(P_2);
					Send(P_0, 10060, "宠物召唤配置保存完毕！");
					break;
				case AllEnums.后台通信类型.天塔突破配置:
					Singleton<KB0ManjLR9N2YNMntee>.I.nfijMIY1tS(P_2);
					Send(P_0, 10060, "通天塔突破奖励配置保存完毕！");
					break;
				case AllEnums.后台通信类型.自选礼包配置:
					Singleton<RdU9KHgkxD6vGY8ZRKE>.I.DHsg34Ihvx(P_2);
					Send(P_0, 10060, "自选礼包配置保存完毕！");
					break;
				case AllEnums.后台通信类型.宠物绑定配置:
					Singleton<FoohJvKhxbMTfceeiIF>.I.MYhKOU8bbt(P_2);
					Send(P_0, 10060, "宠物绑定配置保存完毕！");
					break;
				case AllEnums.后台通信类型.超级地图配置:
					Singleton<Rfq62uDvr7Ur9Lpyctd>.I.OepDyBtBRW(P_2);
					Send(P_0, 10060, "超级地图配置保存完毕！");
					break;
				case AllEnums.后台通信类型.一键飞升配置:
					Singleton<DB9OkbjZMmmdyW1KQMk>.I.w2ClsnjIRg(P_2);
					Send(P_0, 10060, "一键飞升配置保存完毕！");
					break;
				case AllEnums.后台通信类型.法宝共生配置:
					Singleton<DB9OkbjZMmmdyW1KQMk>.I.JrdlDBQ9iD(P_2);
					Send(P_0, 10060, "法宝共生配置保存完毕！");
					break;
				case AllEnums.后台通信类型.商城限购配置:
					Singleton<FusVSwwzpuFHNrjHS7T>.I.jJtbKj1SvX(P_2);
					Send(P_0, 10060, "商城限购配置保存完毕！");
					break;
				case AllEnums.后台通信类型.元宝礼包配置:
					Singleton<WI2SZ8qRj7MBmbqI09>.I.v6czMOSJa(P_2);
					Send(P_0, 10060, "元宝礼包配置保存完毕！");
					break;
				case AllEnums.后台通信类型.超级BOSS配置:
					Singleton<FBGRmlstyRWQdqi0pHa>.I.xqeUb7KnBy(P_2);
					Send(P_0, 10060, "挑战boss配置保存完毕！");
					break;
				case AllEnums.后台通信类型.超级坐骑配置:
					Singleton<VuI4pmDQ6nQtpDAauah>.I.blHD1QtAhD(P_2);
					Send(P_0, 10060, "超级坐骑配置保存完毕！");
					break;
				case AllEnums.后台通信类型.定义邮箱配置:
					Singleton<fK6mLrjpv26MU2YIIF9>.I.AG2jeS2fXT(P_2);
					Send(P_0, 10060, "自定义邮箱配置保存完毕！");
					break;
				case AllEnums.后台通信类型.百炼合成配置:
					Singleton<FoINHjWh9BHxZ3BiiA5>.I.vPqW9FUgE9(P_2);
					Send(P_0, 10060, "百炼合成配置保存完毕！");
					break;
				case AllEnums.后台通信类型.网关配置:
					Singleton<GyJyg8g24jqCD31mjD6>.I.mrngLtkZfj(P_2);
					Singleton<全局变量类>.I.网关Server.gvp607MLJZ();
					Send(P_0, 10060, "网关配置保存完毕！");
					break;
				case AllEnums.后台通信类型.超级NPC配置:
					Singleton<超级NPC功能>.I.JsonTo配置(P_2);
					Send(P_0, 10060, "超级NPC配置保存完毕！");
					break;
				case AllEnums.后台通信类型.共享存档配置:
					Singleton<BsbfIlwwf1YnPvbq8GT>.I.j29wdiwK2i(P_2);
					Send(P_0, 10060, "共享存档配置保存完毕！");
					break;
				case AllEnums.后台通信类型.道行达标配置:
					Singleton<L4IbybsayJA7RG5d8t7>.I.ApLsQOLl41(P_2);
					Send(P_0, 10060, "道行达标配置保存完毕！");
					break;
				case AllEnums.后台通信类型.活跃奖励配置:
					Singleton<L4IbybsayJA7RG5d8t7>.I.PAWspU191w(P_2);
					Send(P_0, 10060, "活跃奖励配置保存完毕！");
					break;
				case AllEnums.后台通信类型.黑名单记录:
					Singleton<xloVkMlT29HN5P5svHC>.I.DXylkZedx9(P_2);
					Send(P_0, 10060, "黑名单记录保存完毕！");
					break;
				case AllEnums.后台通信类型.签到配置:
					Singleton<p63Ra5gwg6vJ45gPiim>.I.pqkgdPLEt7(P_2);
					Send(P_0, 10060, "签到配置保存完毕！");
					break;
				case AllEnums.后台通信类型.盲盒配置:
					Singleton<xKp3aGWENEfI6KIHVKi>.I.Tl5WxvS9Wp(P_2);
					Send(P_0, 10060, "盲盒配置保存完毕！");
					break;
				case AllEnums.后台通信类型.在线抽奖配置:
					Singleton<cGiRplbQfaJV9guWDIS>.I.BvOb1h4DtW(P_2);
					Send(P_0, 10060, "在线抽奖配置保存完毕！");
					break;
				case AllEnums.后台通信类型.召唤精怪配置:
					Singleton<FcVoHRwOVsflDmDUQOP>.I.eb2wpkgUo1(P_2);
					Send(P_0, 10060, "召唤精怪配置保存完毕！");
					break;
				case AllEnums.后台通信类型.试道大会配置:
					Singleton<SSW8tHD2MvRIUVygbNo>.I.Vl9DLiO3M1(P_2);
					Send(P_0, 10060, "试道大会配置保存完毕！");
					break;
				case AllEnums.后台通信类型.宠物转生配置:
					Singleton<AZI1HsR8MjRfegmETY5>.I.OC6RBQnEQA(P_2);
					Send(P_0, 10060, "宠物转生配置保存完毕！");
					break;
				case AllEnums.后台通信类型.奇宝斋配置:
					Singleton<svsUCqKdlsQkBBIo3St>.I.NvDKD01bMw(P_2);
					Send(P_0, 10060, "奇宝斋配置保存完毕！");
					break;
				case AllEnums.后台通信类型.妖族化形配置:
					Singleton<妖族化形功能>.I.JsonTo配置(P_2);
					Send(P_0, 10060, "妖族化形配置保存完毕！");
					break;
				case AllEnums.后台通信类型.怀旧专区配置:
					Singleton<sUhuV4s664O5VhBMqaF>.I.bfCsF4MgP0(P_2);
					Send(P_0, 10060, "怀旧专区配置保存完毕！");
					break;
				case AllEnums.后台通信类型.首饰系统配置:
					Singleton<cCs7kYlNIp7pmjCmEml>.I.fDhl67iWfM(P_2);
					Send(P_0, 10060, "首饰系统配置保存完毕！");
					break;
				case AllEnums.后台通信类型.融丹配置:
					Singleton<APqDp4bq1ecVdMifnI1>.I.hPVbzSgvsu(P_2);
					Send(P_0, 10060, "融丹配置保存完毕！");
					break;
				case AllEnums.后台通信类型.守护配置:
					Singleton<LaobQfgSrA1tYPe60GA>.I.omjghl8xgf(P_2);
					Send(P_0, 10060, "守护配置保存完毕！");
					break;
				case AllEnums.后台通信类型.宠物突破配置:
					Singleton<U8hGTORuviqLJbXPJ0Y>.I.wZXRRYZSAQ(P_2);
					Send(P_0, 10060, "宠物突破配置保存完毕！");
					break;
				case AllEnums.后台通信类型.自定义宠物:
					Singleton<xxsAZpga7ronqw5ilvg>.I.sDogVLGeQU(P_2);
					Send(P_0, 10060, "自定义宠物破配置保存完毕！");
					break;
				case AllEnums.后台通信类型.装备系统配置:
					Singleton<pN4kvFDKqDQRQBnO8BW>.I.GHvDWoMo85(P_2);
					Send(P_0, 10060, "装备系统配置保存完毕！");
					break;
				case AllEnums.后台通信类型.地府商城配置:
					Singleton<mDs6hiBvFvG3CRi3MZk>.I.SYqByvsuLR(P_2);
					Send(P_0, 10060, "地府商城配置保存完毕！");
					break;
				case AllEnums.后台通信类型.装备分解配置:
					Singleton<pN4kvFDKqDQRQBnO8BW>.I.qWbDly07yg(P_2);
					Send(P_0, 10060, "装备分解配置保存完毕！");
					break;
				case AllEnums.后台通信类型.龙血BOSS配置:
					Singleton<KmvE5t6XclSPSYZqqE9>.I.CdC6nM7ONR(P_2);
					Send(P_0, 10060, "龙血BOSS配置保存完毕！");
					break;
				case AllEnums.后台通信类型.装备强化配置:
					Singleton<rZ9xAdgxKYQQZPeE8Rm>.I.P6lgZ8HlOR(P_2);
					Send(P_0, 10060, "装备强化配置保存完毕！");
					break;
				case AllEnums.后台通信类型.礼包飘屏配置:
					Singleton<xKp3aGWENEfI6KIHVKi>.I.xs7WqBkdu8(P_2);
					Send(P_0, 10060, "礼包飘屏配置保存完毕！");
					break;
				case AllEnums.后台通信类型.超级进化配置:
					Singleton<QxBx5YDqZUOBMg9A6NN>.I.BvhDzQDRki(P_2);
					Send(P_0, 10060, "超级进化配置保存完毕！");
					break;
				case AllEnums.后台通信类型.鸿运当头配置:
					Singleton<S0U8ESlnAtMSWsCIoNo>.I.Gkfl7TUlqB(P_2);
					Send(P_0, 10060, "鸿运当头配置保存完毕！");
					break;
				case AllEnums.后台通信类型.特效配置:
					Singleton<TOqsYfW68LIGjCtAgK8>.I.KqeWFPPUh7(P_2);
					Send(P_0, 10060, "特效配置保存完毕！");
					break;
				case AllEnums.后台通信类型.摆摊配置:
					Singleton<YHfw7nGpg7WfdCBKDH4>.I.UOKGeGO3Co(P_2);
					Send(P_0, 10060, "摆摊配置保存完毕！");
					break;
				case AllEnums.后台通信类型.智能怪物配置:
					Singleton<yuKf6DUSQGygKeLSQdj>.I.P6FUhRK84D(P_2);
					Send(P_0, 10060, "智能怪物配置保存完毕！");
					break;
				case AllEnums.后台通信类型.天机神算配置:
					Singleton<MtacAPJOeul0knZiQar>.I.taLJpPUKc5(P_2);
					Send(P_0, 10060, "天机神算配置保存完毕！");
					break;
				case AllEnums.后台通信类型.娃娃配置:
					Singleton<mQEQjEBxYW4SsAecBHJ>.I.tvYBru4LWD(P_2);
					Send(P_0, 10060, "娃娃配置保存完毕！");
					break;
				case AllEnums.后台通信类型.日常配置:
					Singleton<XhaJ3cfswGhhnmIequv>.I.G6Kfjamqld(P_2);
					Send(P_0, 10060, "日常配置保存完毕！");
					break;
				case AllEnums.后台通信类型.元神系统配置:
					Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.evk23G9j1A(P_2);
					Send(P_0, 10060, "元神系统配置保存完毕！");
					break;
				case AllEnums.后台通信类型.狐狸和狗配置:
					Singleton<OmF9SPGlN77YLFkkoqN>.I.SpMGimfMK0(P_2);
					Send(P_0, 10060, "狐狸和狗配置保存完毕！");
					break;
				case AllEnums.后台通信类型.内充支付配置:
					Singleton<xH3TPsiexTnpJAMMnJm>.I.Sh7iAaTCjV(P_2);
					Send(P_0, 10060, "内充支付配置保存完毕！");
					break;
				case AllEnums.后台通信类型.道具数据配置:
					Singleton<pGS3mljky49pI9pArc9>.I.agtj33Mvf1(P_2);
					Send(P_0, 10060, "道具数据配置保存完毕！");
					break;
				case AllEnums.后台通信类型.自助商店配置:
					Singleton<uh2edhfVGtogUy49Lpv>.I.zwSfEKJQBQ(P_2);
					Send(P_0, 10060, "自助商店配置保存完毕！");
					break;
				case AllEnums.后台通信类型.角色监控信息:
				case AllEnums.后台通信类型.CDK兑换信息:
				case AllEnums.后台通信类型.专属合区配置:
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求保存配置-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10019, func = "Mf5l1VWOSw")]
	internal void Mf5l1VWOSw(Player P_0, bool P_1)
	{
		if (P_1)
		{
			Send(P_0, 10056, true, Singleton<全局变量类>.I.网关Server.启动网关());
		}
		else
		{
			Send(P_0, 10056, false, Singleton<全局变量类>.I.网关Server.关闭网关());
		}
	}

	
	[Rpc(cmd = 2, hash = 10020, func = "HBDlxsBCXv")]
	internal void HBDlxsBCXv(Player P_0, bool P_1)
	{
		try
		{
			if (!P_1 || !P_0.tWVlQZZf7U)
			{
				return;
			}
			mEdebOPadFyb5ykL5Wy.LJLPkNiFSB.Refresh();
			double memoryMb = mEdebOPadFyb5ykL5Wy.LJLPkNiFSB.WorkingSet64 / 1024.0 / 1024.0;
			if (Singleton<全局变量类>.I.验证client != null)
			{
				string expiry = Singleton<全局变量类>.I.验证client.是否成功
					? 格式化授权到期时间(Singleton<全局变量类>.I.验证client.到期时间)
					: (string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.config.卡密) ? "请先正式启动插件" : "授权未验证");
				string text = $"运行状态：{(Singleton<全局变量类>.I.插件启动状态 ? "已启动" : "未启动")}（内存 {memoryMb:0.0} MB） 到期时间：{expiry}";
				object[] obj = new object[7]
				{
					Singleton<全局变量类>.I.插件启动状态,
					text,
					null,
					null,
					null,
					null,
					null
				};
				obj[2] = expiry;
				obj[3] = fuMNpgieFTYU3Wah53.BojPVlpN4();
				obj[4] = Singleton<全局变量类>.I.验证client.授权配置.Is点卡功能;
				obj[5] = Singleton<全局变量类>.I.验证client.授权配置.Is简化版本;
				obj[6] = Singleton<全局变量类>.I.验证client.授权配置.Is完美力魄;
				Send(P_0, 10061, obj);
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求插件基本信息-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10021, func = "LZplHl3Z9J")]
	internal void LZplHl3Z9J(Player P_0, string P_1)
	{
		try
		{
			// 10021 is retained only for wire compatibility. Never interpret a card/key as a shell command.
			if (P_0 != null && P_0.tWVlQZZf7U)
				Send(P_0, 10062, false, "旧续费接口已停用，请在授权服务中管理授权。");
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求插件续费-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10022, func = "euHl4vZl5F")]
	internal async void euHl4vZl5F(Player P_0, bool P_1)
	{
		if (P_1)
		{
			ArchiveSaveResult result = await DB.I.保存全部存档();
			if (result == ArchiveSaveResult.Completed)
			{
				Send(P_0, 10060, "所有玩家和宠物存档保存完毕！");
			}
			else if (result == ArchiveSaveResult.Busy)
			{
				Send(P_0, 10060, "已有存档任务正在执行，本次未重复保存。");
			}
			else
			{
				Send(P_0, 10060, "存档失败，请检查插件日志。");
			}
		}
	}

	private static string 格式化授权到期时间(string value)
	{
		if (string.IsNullOrWhiteSpace(value) || string.Equals(value, "永久", StringComparison.Ordinal)) return "永久";
		return DateTimeOffset.TryParse(value, out var expires)
			? expires.ToLocalTime().ToString("yyyy-MM-dd HH:mm")
			: value.Split('.', '+')[0].Trim();
	}

	
	[Rpc(cmd = 2, hash = 10085, func = "lqsleDO8yt")]
	internal void lqsleDO8yt(Player P_0, string P_1)
	{
	}

	
	[Rpc(cmd = 2, hash = 10023, func = "BkElqTwyog")]
	internal async void BkElqTwyog(Player P_0, string P_1, string P_2)
	{
		try
		{
			if (P_2 != "2026-06-30")
			{
				Send(P_0, 10063, "插件版本和后台管理版本不一致，请使用同一版本！");
				return;
			}
			if (!P_0.tWVlQZZf7U)
			{
				Send(P_0, 10063, "请先登录管理员！");
				return;
			}
			if (Singleton<全局变量类>.I.插件启动状态)
			{
				HBDlxsBCXv(P_0, true);
				Send(P_0, 10063, "插件已经启动，无法重复监听！");
				return;
			}
			// Ignore legacy config values so an old file cannot redirect validation.
			var licenseAddress = Singleton<全局变量类>.I.config.取当前授权服务器地址();
			var license = await Singleton<全局变量类>.I.验证client.验证授权(Singleton<全局变量类>.I.config.卡密, licenseAddress);
			if (!license.Valid)
			{
				Send(P_0, 10063, license.Message);
				return;
			}
			if (Singleton<全局变量类>.I.验证client?.授权线路启动许可() != true)
			{
				Send(P_0, 10063, "授权完整性检查失败，线路未启动。");
				return;
			}
			await Singleton<MainService>.I.Init(Singleton<全局变量类>.I.config.游戏IP, (bool started, string message) =>
			{
				Send(P_0, 10063, message);
				HBDlxsBCXv(P_0, true);
				if (started) Wnhlrr0DCF(P_0);
			});
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求启动插件-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void Wnhlrr0DCF(Player P_0)
	{
		if (OperatingSystem.IsWindows())
		{
			执行Windows基础防火墙规则(P_0?.IP);
			return;
		}
		List<string> list = new List<string> { "iptables -F" };
		List<int> list2 = Singleton<全局变量类>.I.config.游戏端口.Split(',').Select(int.Parse).ToList();
		for (int i = 0; i < list2.Count; i++)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 1);
			defaultInterpolatedStringHandler.AppendLiteral("iptables -I INPUT -p tcp --dport ");
			defaultInterpolatedStringHandler.AppendFormatted(list2[i]);
			defaultInterpolatedStringHandler.AppendLiteral(" -j DROP");
			list.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		list.Add("iptables -I INPUT -p tcp --dport 8120 -j DROP");
		if (Singleton<全局变量类>.I.config.数据库防护开关)
		{
			list.Add("iptables -I INPUT -p tcp --dport 3306 -j DROP");
		}
		for (int j = 0; j < list2.Count; j++)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
			defaultInterpolatedStringHandler.AppendLiteral("iptables -I INPUT -s ");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.游戏IP);
			defaultInterpolatedStringHandler.AppendLiteral(" -p tcp --dport ");
			defaultInterpolatedStringHandler.AppendFormatted(list2[j]);
			defaultInterpolatedStringHandler.AppendLiteral(" -j ACCEPT");
			list.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		list.Add("iptables -I INPUT -s " + Singleton<全局变量类>.I.config.游戏IP + " -p tcp --dport 8120 -j ACCEPT");
		if (Singleton<全局变量类>.I.config.数据库防护开关)
		{
			list.Add("iptables -I INPUT -s " + Singleton<全局变量类>.I.config.游戏IP + " -p tcp --dport 3306 -j ACCEPT");
			list.Add("iptables -I INPUT -s " + P_0.IP + " -p tcp --dport 3306 -j ACCEPT");
		}
		if (Singleton<全局变量类>.I.config.防CC开关)
		{
			List<int> list3 = Singleton<全局变量类>.I.config.插件端口.Split(',').Select(int.Parse).ToList();
			for (int k = 0; k < list3.Count; k++)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 1);
				defaultInterpolatedStringHandler.AppendLiteral("iptables -I INPUT -p tcp --dport ");
				defaultInterpolatedStringHandler.AppendFormatted(list3[k]);
				defaultInterpolatedStringHandler.AppendLiteral(" -j DROP");
				list.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			for (int l = 0; l < list3.Count; l++)
			{
				List<string> list4 = 防CC命令;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
				defaultInterpolatedStringHandler.AppendLiteral("iptables -I INPUT -s ");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.游戏IP);
				defaultInterpolatedStringHandler.AppendLiteral(" -p tcp --dport ");
				defaultInterpolatedStringHandler.AppendFormatted(list3[l]);
				defaultInterpolatedStringHandler.AppendLiteral(" -j ACCEPT");
				list4.Add(defaultInterpolatedStringHandler.ToStringAndClear());
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
				defaultInterpolatedStringHandler.AppendLiteral("iptables -I INPUT -s ");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.游戏IP);
				defaultInterpolatedStringHandler.AppendLiteral(" -p tcp --dport ");
				defaultInterpolatedStringHandler.AppendFormatted(list3[l]);
				defaultInterpolatedStringHandler.AppendLiteral(" -j ACCEPT");
				list.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}
		for (int m = 0; m < list.Count; m++)
		{
			ExecuteCommand(list[m]);
		}
	}

	

	private static bool ExecuteWindowsNetsh(IEnumerable<string> arguments, out string output, out string error)
	{
		output = string.Empty;
		error = string.Empty;
		try
		{
			string netsh = Path.Combine(Environment.SystemDirectory, "netsh.exe");
			using Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = netsh,
					UseShellExecute = false,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					CreateNoWindow = true
				}
			};
			foreach (string argument in arguments) process.StartInfo.ArgumentList.Add(argument);
			if (!process.Start()) return false;
			output = process.StandardOutput.ReadToEnd();
			error = process.StandardError.ReadToEnd();
			if (!process.WaitForExit(10000))
			{
				try { process.Kill(entireProcessTree: true); } catch { }
				Serilog.Log.Error("Windows netsh 执行超时。");
				return false;
			}
			return process.ExitCode == 0;
		}
		catch (Exception ex)
		{
			Serilog.Log.Error(ex, "Windows netsh 执行失败");
			return false;
		}
	}

	private static bool ExecuteWindowsFirewallAllowRule(string ruleName, int localPort, string remoteIp = null)
	{
		if (localPort <= 0 || localPort > 65535) return false;
		ExecuteWindowsNetsh(new[] { "advfirewall", "firewall", "delete", "rule", "name=" + ruleName }, out _, out _);
		List<string> args = new List<string>
		{
			"advfirewall", "firewall", "add", "rule", "name=" + ruleName,
			"dir=in", "action=allow", "protocol=TCP", "localport=" + localPort,
			"profile=any", "enable=yes"
		};
		if (是有效IPv4(remoteIp)) args.Add("remoteip=" + remoteIp);
		bool ok = ExecuteWindowsNetsh(args, out string output, out string error);
		if (!ok) Serilog.Log.Error("Windows 防火墙规则创建失败：{Rule} {Error} {Output}", ruleName, error, output);
		return ok;
	}

	private void 执行Windows基础防火墙规则(string remoteIp)
	{
		try
		{
			List<int> gamePorts = Singleton<全局变量类>.I.config.游戏端口
				.Split(',', StringSplitOptions.RemoveEmptyEntries)
				.Select(x => int.TryParse(x.Trim(), out int value) ? value : 0)
				.Where(x => x > 0 && x <= 65535)
				.Distinct()
				.ToList();
			foreach (int port in gamePorts)
				ExecuteWindowsFirewallAllowRule("顺风插件-Game-" + port, port);
			ExecuteWindowsFirewallAllowRule("顺风插件-8120", 8120);

			if (Singleton<全局变量类>.I.config.数据库防护开关)
			{
				ExecuteWindowsFirewallAllowRule("顺风插件-MySQL-GameIP", 3306, Singleton<全局变量类>.I.config.游戏IP);
				if (是有效IPv4(remoteIp)) ExecuteWindowsFirewallAllowRule("顺风插件-MySQL-Admin-" + remoteIp, 3306, remoteIp);
			}

			if (Singleton<全局变量类>.I.config.防CC开关)
			{
				foreach (int port in Singleton<全局变量类>.I.config.插件端口
					.Split(',', StringSplitOptions.RemoveEmptyEntries)
					.Select(x => int.TryParse(x.Trim(), out int value) ? value : 0)
					.Where(x => x > 0 && x <= 65535)
					.Distinct())
				{
					// Windows 防火墙不直接等价 iptables 的当前防 CC 规则，这里只负责放行插件业务端口。
					ExecuteWindowsFirewallAllowRule("顺风插件-Plugin-" + port, port);
				}
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error(ex, "Windows 防火墙初始化异常");
		}
	}

	public void ExecuteCommand(string command)
	{
		try
		{
			if (OperatingSystem.IsWindows())
			{
				Serilog.Log.Debug("忽略 Windows 环境下的 Linux shell 命令：{Command}", command);
				return;
			}
			using Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "/bin/bash",
					Arguments = "-c \"" + command + "\"",
					RedirectStandardOutput = true,
					UseShellExecute = false,
					CreateNoWindow = true
				}
			};
			process.Start();
			process.StandardOutput.ReadToEnd();
			process.WaitForExit();
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("ExecuteCommand-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	public void AdminExecuteCommand(string command)
	{
		try
		{
			if (OperatingSystem.IsWindows())
			{
				// Windows 只终止当前 ServerCore 进程，避免误杀其他同名实例。
				using Process process = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = Path.Combine(Environment.SystemDirectory, "taskkill.exe"),
						UseShellExecute = false,
						RedirectStandardOutput = true,
						RedirectStandardError = true,
						CreateNoWindow = true
					}
				};
				process.StartInfo.ArgumentList.Add("/PID");
				process.StartInfo.ArgumentList.Add(Environment.ProcessId.ToString());
				process.StartInfo.ArgumentList.Add("/T");
				process.StartInfo.ArgumentList.Add("/F");
				process.Start();
				string output = process.StandardOutput.ReadToEnd();
				string error = process.StandardError.ReadToEnd();
				process.WaitForExit();
				if (process.ExitCode != 0) Serilog.Log.Warning("Windows taskkill 未成功：{Output} {Error}", output, error);
				return;
			}

			using Process linuxProcess = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "sudo",
					Arguments = "/bin/kill -9 " + command,
					RedirectStandardOutput = true,
					UseShellExecute = false,
					CreateNoWindow = true
				}
			};
			linuxProcess.Start();
			linuxProcess.StandardOutput.ReadToEnd();
			linuxProcess.WaitForExit();
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("ExecuteCommand-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	[Rpc(cmd = 2, hash = 10100, func = "OpenPlayerPorts")]
	internal void OpenPlayerPorts(Player player)
	{
		if (!player.tWVlQZZf7U)
		{
			Send(player, 10101, false, "插件后台尚未完成认证，端口规则未执行");
			return;
		}
		try
		{
			if (OperatingSystem.IsWindows())
			{
				int[] ports = { 18101, 18160, 18161, 18162, 18163 };
				bool allOk = true;
				foreach (int port in ports) allOk &= ExecuteWindowsFirewallAllowRule("顺风插件-Player-" + port, port);
				if (!allOk)
				{
					Send(player, 10101, false, "Windows 防火墙端口规则执行失败，请使用管理员身份运行 ServerCore。");
					return;
				}
				Send(player, 10101, true, "Windows 防火墙已放行：18101、18160-18163");
				return;
			}

			const string command = "set -e; for port in 18101 18160 18161 18162 18163; do while iptables -C INPUT -p tcp --dport $port -j ACCEPT >/dev/null 2>&1; do iptables -D INPUT -p tcp --dport $port -j ACCEPT; done; while iptables -C INPUT -p tcp --dport $port -j DROP >/dev/null 2>&1; do iptables -D INPUT -p tcp --dport $port -j DROP; done; iptables -I INPUT 2 -p tcp --dport $port -j ACCEPT; done; if command -v iptables-save >/dev/null 2>&1 && [ -d /etc/sysconfig ]; then iptables-save > /etc/sysconfig/iptables; fi";
			using Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "/bin/bash",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					CreateNoWindow = true
				}
			};
			process.StartInfo.ArgumentList.Add("-lc");
			process.StartInfo.ArgumentList.Add(command);
			process.Start();
			string output = process.StandardOutput.ReadToEnd();
			string error = process.StandardError.ReadToEnd();
			process.WaitForExit();
			if (process.ExitCode != 0)
			{
				Send(player, 10101, false, "端口规则执行失败：" + (string.IsNullOrWhiteSpace(error) ? output : error).Trim());
				return;
			}
			Send(player, 10101, true, "端口已永久放开：18101、18160-18163");
		}
		catch (Exception ex)
		{
			Serilog.Log.Error(ex, "开放游戏端口失败");
			Send(player, 10101, false, "端口规则执行异常，请检查日志。");
		}
	}

	public void 添加防CCIP白名单(string 白名单ip)
	{
		if (!是有效IPv4(白名单ip))
		{
			Serilog.Log.Warning("拒绝为无效 IPv4 地址添加防 CC 白名单：{IP}", 白名单ip);
			return;
		}
		if (OperatingSystem.IsWindows())
		{
			foreach (int port in Singleton<全局变量类>.I.config.插件端口
				.Split(',', StringSplitOptions.RemoveEmptyEntries)
				.Select(x => int.TryParse(x.Trim(), out int value) ? value : 0)
				.Where(x => x > 0 && x <= 65535)
				.Distinct())
			{
				ExecuteWindowsFirewallAllowRule("顺风插件-CC-" + port + "-" + 白名单ip, port, 白名单ip);
			}
			return;
		}
		for (int i = 0; i < 防CC命令.Count; i++)
		{
			ExecuteCommand(防CC命令[i].Replace(Singleton<全局变量类>.I.config.游戏IP, 白名单ip));
		}
	}

	
	[Rpc(cmd = 2, hash = 10024, func = "AS7lZZkAjd")]
	internal async Task AS7lZZkAjd(Player P_0, bool P_1)
	{
		_ = 1;
		try
		{
			if (P_1 && P_0.tWVlQZZf7U)
			{
				ArchiveSaveResult result = await DB.I.保存全部存档();
				if (result == ArchiveSaveResult.Completed)
				{
					Send(P_0, 10065, "所有角色和宠物存档完成！");
				}
				else if (result == ArchiveSaveResult.Busy)
				{
					Send(P_0, 10065, "已有存档任务正在执行，本次取消重启，请稍后重试。");
					return;
				}
				else
				{
					Send(P_0, 10065, "存档失败，本次取消重启，请检查插件日志。");
					return;
				}
				执行重启插件操作();
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("重启插件-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public void 执行重启插件操作()
	{
		if (!Singleton<全局变量类>.I.会话Dict.IsEmpty) return;
		try
		{
			if (OperatingSystem.IsWindows())
			{
				string processPath = Environment.ProcessPath;
				if (string.IsNullOrWhiteSpace(processPath) || !File.Exists(processPath))
				{
					Serilog.Log.Error("Windows 重启失败：无法确定当前 ServerCore.exe 路径。");
					return;
				}
				string scriptPath = Path.Combine(Path.GetTempPath(), "shunfeng-restart-" + Environment.ProcessId + ".cmd");
				string escapedPath = processPath.Replace("%", "%%").Replace("\"", "\"\"");
				File.WriteAllText(scriptPath,
					"@echo off\r\n" +
					"timeout /t 2 /nobreak >nul\r\n" +
					"start \"\" \"" + escapedPath + "\"\r\n" +
					"del /f /q \"%~f0\" >nul 2>&1\r\n",
					Encoding.ASCII);
				using Process restartProcess = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = scriptPath,
						WorkingDirectory = Path.GetDirectoryName(processPath) ?? AppContext.BaseDirectory,
						UseShellExecute = true,
						CreateNoWindow = true,
						WindowStyle = ProcessWindowStyle.Hidden
					}
				};
				restartProcess.Start();
				Environment.Exit(0);
				return;
			}

			using Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "/usr/bin/sudo",
					Arguments = "/root/qd",
					RedirectStandardOutput = true,
					UseShellExecute = false,
					CreateNoWindow = true
				}
			};
			process.Start();
			process.StandardOutput.ReadToEnd();
			process.WaitForExit();
		}
		catch (Exception ex)
		{
			Serilog.Log.Error(ex, "执行重启插件操作失败");
		}
	}

	public void 执行关闭插件操作()
	{
		AdminExecuteCommand("ServerCore");
	}

	
	[Rpc(cmd = 2, hash = 10025, func = "JrSltxoVqu")]
	internal async void JrSltxoVqu(Player P_0, int P_1, int P_2, string P_3, int P_4)
	{
		_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass24_0();
		CS_0024_003C_003E8__locals6.vplhEwU6NB = this;
		CS_0024_003C_003E8__locals6.nIph3vhtaB = P_0;
		try
		{
			if (CS_0024_003C_003E8__locals6.nIph3vhtaB.tWVlQZZf7U)
			{
				await DB.I.lrCN10MduL(P_1, P_3, P_4, P_2,  (int v1, string v2) =>
				{
					CS_0024_003C_003E8__locals6.vplhEwU6NB.Send(CS_0024_003C_003E8__locals6.nIph3vhtaB, 10064, v2);
				});
				Send(CS_0024_003C_003E8__locals6.nIph3vhtaB, 10065, "CDK生成完毕，记得复制保存！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求CDK生成-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10026, func = "I7LlAIe5S8")]
	internal void I7LlAIe5S8(Player P_0, bool P_1)
	{
		_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass25_0();
		CS_0024_003C_003E8__locals5.JFshphatD6 = this;
		CS_0024_003C_003E8__locals5.qjth1Eed1d = P_0;
		try
		{
			if (CS_0024_003C_003E8__locals5.qjth1Eed1d.tWVlQZZf7U)
			{
				DB.I.wf9N4MHQvU(string.Empty, 0, string.Empty, string.Empty,  (CDK信息类 v1, bool v2) =>
				{
					CS_0024_003C_003E8__locals5.JFshphatD6.Send(CS_0024_003C_003E8__locals5.qjth1Eed1d, 10066, JsonConvert.SerializeObject(v1, Formatting.Indented), v2);
				});
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求CDK刷新-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10027, func = "gcolzBeURO")]
	internal void gcolzBeURO(Player P_0, string P_1)
	{
		try
		{
			if (P_0.tWVlQZZf7U)
			{
				DB.I.K6CNeCnGhr(P_1);
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求CDK删除-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10028, func = "cvi8u3DZ8m")]
	internal async void cvi8u3DZ8m(Player P_0, string P_1, int P_2, int P_3, string P_4)
	{
		try
		{
			if (!P_0.tWVlQZZf7U)
			{
				return;
			}
			if (P_1 == "所有在线玩家")
			{
				int 人数 = 0;
				foreach (MyNATSocketClient value in Singleton<全局变量类>.I.会话Dict.Values)
				{
					if (Singleton<MainService>.I.发送角色属性道具(value, (AllEnums.数值Type)P_2, P_3, P_4))
					{
						人数++;
					}
					await Task.Delay(50);
				}
				Send(P_0, 10067, 人数 > 0);
			}
			else
			{
				MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定Name玩家MyClient(P_1);
				if (myNATSocketClient == null)
				{
					Send(P_0, 10067, false);
				}
				else
				{
					bool flag = Singleton<MainService>.I.发送角色属性道具(myNATSocketClient, (AllEnums.数值Type)P_2, P_3, P_4);
					Send(P_0, 10067, flag);
				}
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求发货在线角色-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10029, func = "t4R8wPOepr")]
	private async void t4R8wPOepr(Player P_0, bool P_1)
	{
		_ = 1;
		try
		{
			if (Singleton<全局变量类>.I.角色存档表.IsEmpty)
			{
				Send(P_0, 10068, string.Empty, true);
				return;
			}
			foreach (KeyValuePair<int, 角色存档数据类> item in Singleton<全局变量类>.I.角色存档表)
			{
				MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(item.Key);
				bool flag = myNATSocketClient?.使用中 ?? false;
				if (!P_1 || flag)
				{
					角色汇总类 value = new 角色汇总类
					{
						是否在线 = flag,
						GID = item.Value.GID,
						账号 = item.Value.账号,
						昵称 = (flag ? myNATSocketClient.user.人物数据.昵称 : item.Value.昵称),
						等级 = (flag ? myNATSocketClient.user.属性数据.等级 : item.Value.等级),
						性别 = (byte)((!flag) ? 1u : ((uint)myNATSocketClient.user.人物数据.性别)),
						五行 = (byte)((!flag) ? 1 : myNATSocketClient.user.人物数据.五行),
						所在地图名字 = (flag ? myNATSocketClient.user.人物数据.所在地图名字 : string.Empty),
						金元宝 = (flag ? myNATSocketClient.user.背包数据.金元宝 : 0),
						银元宝 = (flag ? myNATSocketClient.user.背包数据.银元宝 : 0),
						金钱 = (flag ? myNATSocketClient.user.背包数据.金钱 : 0),
						活跃值 = (flag ? myNATSocketClient.user.缓存数据.活跃值 : 0),
						奇宝点 = item.Value.奇宝斋存档.奇宝斋余额,
						南极点 = item.Value.南极抽奖次数,
						累充点 = item.Value.累计充值金额,
						is指定会员 = (flag && myNATSocketClient.user.缓存数据.Is指定会员),
						is战斗中 = (flag && myNATSocketClient.user.缓存数据.is战斗中),
						IP = (flag ? myNATSocketClient.当前client.IP : string.Empty),
						Mac = (flag ? myNATSocketClient.Mac : string.Empty),
						历史QQ = item.Value.账号注册QQ,
						上线时间 = item.Value.最后上线时间,
						离线时间 = item.Value.最后下线时间
					};
					Send(P_0, 10068, JsonConvert.SerializeObject(value, Formatting.Indented), false);
					await Task.Delay(50);
				}
			}
			await Task.Delay(100);
			Send(P_0, 10068, $"{Singleton<全局变量类>.I.角色存档表.Count}", true);
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("更新角色监控列表-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			Send(P_0, 10068, string.Empty, true);
		}
	}

	
	[Rpc(cmd = 2, hash = 10030, func = "强制所有玩家下线")]
	private void 强制所有玩家下线(Player player, bool 是否保存)
	{
		_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass29_0();
		CS_0024_003C_003E8__locals8.JrshHOG2is = this;
		CS_0024_003C_003E8__locals8.UZvh4T92Jy = player;
		try
		{
			Task.Run( async () =>
			{
				List<MyNATSocketClient> list = Singleton<全局变量类>.I.会话Dict.Values.ToList().FindAll( (MyNATSocketClient item) => item.使用中 && item.当前client.Online && item.转发client.Online && item.user.人物数据.GID != 0 && item.user.人物数据.账号 != Singleton<全局变量类>.I.config.挂载GM账号);
				if (list.Count <= 0)
				{
					CS_0024_003C_003E8__locals8.JrshHOG2is.Send(CS_0024_003C_003E8__locals8.UZvh4T92Jy, 10065, "当前并无在线玩家。");
				}
				else
				{
					while (list.Count > 0)
					{
						foreach (MyNATSocketClient item in list)
						{
							if (item.使用中 && item.当前client.Online && item.转发client.Online && item.user.人物数据.GID != 0 && item.user.人物数据.账号 != Singleton<全局变量类>.I.config.挂载GM账号)
							{
								if (item.user.缓存数据.is战斗中)
								{
									if (item.user.队伍数据.成员列表.Count <= 0 || item.user.队伍数据.is队长)
									{
										Singleton<WdAPI>.I.EOYImZQJeG(item, true);
										await Task.Delay(1000);
										item.S_Send异步(Singleton<WdAPI>.I.zXxoPwQcb0(item.user.人物数据.昵称), "强制所有玩家下线");
									}
								}
								else
								{
									item.S_Send异步(Singleton<WdAPI>.I.lexI4Im4MS(item.user.人物数据.昵称, item.user.缓存数据.is战斗中), "强制所有玩家下线");
								}
							}
						}
						await Task.Delay(1000);
						list = Singleton<全局变量类>.I.会话Dict.Values.ToList().FindAll( (MyNATSocketClient item) => item.使用中 && item.当前client.Online && item.转发client.Online && item.user.人物数据.GID != 0 && item.user.人物数据.账号 != Singleton<全局变量类>.I.config.挂载GM账号);
						WdServer wdServer = CS_0024_003C_003E8__locals8.JrshHOG2is;
						Player client = CS_0024_003C_003E8__locals8.UZvh4T92Jy;
						object[] array = new object[1];
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
						defaultInterpolatedStringHandler.AppendLiteral("当前剩余[");
						defaultInterpolatedStringHandler.AppendFormatted(list.Count);
						defaultInterpolatedStringHandler.AppendLiteral("]个玩家在线，请等待......");
						array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
						wdServer.Send(client, 10065, array);
						if (list.Count <= 0)
						{
							break;
						}
					}
					CS_0024_003C_003E8__locals8.JrshHOG2is.Send(CS_0024_003C_003E8__locals8.UZvh4T92Jy, 10065, "当前并无在线玩家。");
				}
			});
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("强制所有玩家下线-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10031, func = "cH18br30CY")]
	private void cH18br30CY(Player P_0, bool P_1)
	{
		try
		{
			if (Singleton<BpcEfFbiGBBV3s2B0ai>.I.zCybkJu0wB != AllEnums.圣无双Type.未开始)
			{
				Send(P_0, 10070, (int)Singleton<BpcEfFbiGBBV3s2B0ai>.I.zCybkJu0wB, "无双活动已经开启，无法重复开！");
			}
			else
			{
				Singleton<BpcEfFbiGBBV3s2B0ai>.I.uGGb7FpVJN();
				Send(P_0, 10070, (int)Singleton<BpcEfFbiGBBV3s2B0ai>.I.zCybkJu0wB, "无双活动已经开启，请留意游戏内的系统公告！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求开始无双-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10032, func = "Uc98Jqshkd")]
	private void Uc98Jqshkd(Player P_0, bool P_1)
	{
		try
		{
			if (Singleton<BpcEfFbiGBBV3s2B0ai>.I.zCybkJu0wB == AllEnums.圣无双Type.未开始)
			{
				Send(P_0, 10070, (int)Singleton<BpcEfFbiGBBV3s2B0ai>.I.zCybkJu0wB, "无双活动已经结束了！");
			}
			else
			{
				Singleton<BpcEfFbiGBBV3s2B0ai>.I.zCybkJu0wB = AllEnums.圣无双Type.未开始;
				Send(P_0, 10070, (int)Singleton<BpcEfFbiGBBV3s2B0ai>.I.zCybkJu0wB, "无双活动已经结束！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求结束无双-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10033, func = "u9v8KnUiDQ")]
	private async void u9v8KnUiDQ(Player P_0, bool P_1)
	{
		try
		{
			if (Singleton<BpcEfFbiGBBV3s2B0ai>.I.zCybkJu0wB == AllEnums.圣无双Type.未开始)
			{
				Send(P_0, 10070, (int)Singleton<BpcEfFbiGBBV3s2B0ai>.I.zCybkJu0wB, "无双活动未开始！");
				return;
			}
			List<MyNATSocketClient> 无双地图玩家列表 = Singleton<全局变量类>.I.会话Dict.Values.ToList().FindAll( (MyNATSocketClient a) => a.使用中 && a.user.人物数据.所在地图名字 == Singleton<全局变量类>.I.圣无双配置.地图名字 && a.user.存档数据.无双圣榜数据.is报名);
			if (无双地图玩家列表 == null || (无双地图玩家列表 != null && 无双地图玩家列表.Count <= 0))
			{
				Send(P_0, 10071, false, string.Empty, false, false, 0);
			}
			for (int i = 0; i < 无双地图玩家列表.Count; i++)
			{
				Send(P_0, 10071, true, 无双地图玩家列表[i].user.人物数据.昵称, 无双地图玩家列表[i].user.存档数据.无双圣榜数据.is报名, 无双地图玩家列表[i].user.缓存数据.is战斗中, 无双地图玩家列表[i].user.存档数据.无双圣榜数据.当前积分);
				await Task.Delay(100);
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求结束无双-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10034, func = "rsL8R4FUQv")]
	private void rsL8R4FUQv(Player P_0, string P_1)
	{
		_003C_003Ec__DisplayClass33_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass33_0();
		CS_0024_003C_003E8__locals2.zA6hqBc69r = P_1;
		try
		{
			if (Singleton<BpcEfFbiGBBV3s2B0ai>.I.zCybkJu0wB == AllEnums.圣无双Type.未开始)
			{
				Send(P_0, 10070, (int)Singleton<BpcEfFbiGBBV3s2B0ai>.I.zCybkJu0wB, "无双活动未开始！");
			}
			else
			{
				Singleton<全局变量类>.I.会话Dict.Values.ToList().Find( (MyNATSocketClient a) => a.使用中 && a.user.人物数据.昵称 == CS_0024_003C_003E8__locals2.zA6hqBc69r)?.user.存档数据.无双圣榜数据.清空();
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求结束无双-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10035, func = "iy48dd1yC6")]
	private void iy48dd1yC6(Player P_0, int P_1, string P_2, int P_3, string P_4, string P_5, int P_6, string P_7, int P_8, string P_9, int P_10, string P_11, int P_12, string P_13, int P_14)
	{
		_003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals17 = new _003C_003Ec__DisplayClass34_0();
		CS_0024_003C_003E8__locals17.VlcvwuHlCY = this;
		CS_0024_003C_003E8__locals17.xAKvbTmUFJ = P_0;
		try
		{
			int num = DB.I.E3iNgPntG8(P_4);
			if (num == 0)
			{
				Send(CS_0024_003C_003E8__locals17.xAKvbTmUFJ, 10065, "取角色GID失败！");
				return;
			}
			Singleton<ByteAPI>.I.GetHexGid_(num);
			string text = DB.I.ODoNjwX1A1(num);
			if (string.IsNullOrWhiteSpace(text))
			{
				Send(CS_0024_003C_003E8__locals17.xAKvbTmUFJ, 10065, "取角色账号失败！");
				return;
			}
			if (DB.I.KmyN2tdqQc(text))
			{
				Send(CS_0024_003C_003E8__locals17.xAKvbTmUFJ, 10065, "当前角色并未下线！");
				return;
			}
			洗炼属性缓存数据类 洗炼属性缓存数据类2 = new 洗炼属性缓存数据类();
			if (Enum.TryParse<AllEnums.洗炼属性Type>(P_5, out var result) && P_6 != 0)
			{
				洗炼属性缓存数据类2.属性列表.Add(new 洗炼属性缓存列表类
				{
					属性 = result,
					数值 = P_6
				});
			}
			if (Enum.TryParse<AllEnums.洗炼属性Type>(P_7, out var result2) && P_8 != 0)
			{
				洗炼属性缓存数据类2.属性列表.Add(new 洗炼属性缓存列表类
				{
					属性 = result2,
					数值 = P_8
				});
			}
			if (Enum.TryParse<AllEnums.洗炼属性Type>(P_9, out var result3) && P_10 != 0)
			{
				洗炼属性缓存数据类2.属性列表.Add(new 洗炼属性缓存列表类
				{
					属性 = result3,
					数值 = P_10
				});
			}
			if (Enum.TryParse<AllEnums.洗炼属性Type>(P_11, out var result4) && P_12 != 0)
			{
				洗炼属性缓存数据类2.属性列表.Add(new 洗炼属性缓存列表类
				{
					属性 = result4,
					数值 = P_12
				});
			}
			if (Enum.TryParse<AllEnums.洗炼属性Type>(P_13, out var result5) && P_14 != 0)
			{
				洗炼属性缓存数据类2.属性列表.Add(new 洗炼属性缓存列表类
				{
					属性 = result5,
					数值 = P_14
				});
			}
			switch ((AllEnums.装备Type)P_1)
			{
			case AllEnums.装备Type.时装:
				DB.I.C2XNVmntJa(num, text, P_4, P_3, P_2, 洗炼属性缓存数据类2,  (bool v1) =>
				{
					CS_0024_003C_003E8__locals17.VlcvwuHlCY.Send(CS_0024_003C_003E8__locals17.xAKvbTmUFJ, 10065, v1 ? "发送成功！" : "发送失败！");
				});
				break;
			case AllEnums.装备Type.法宝:
				DB.I.ThVNkUOkV1(num, text, P_4, P_3, P_2, 洗炼属性缓存数据类2,  (bool v1) =>
				{
					CS_0024_003C_003E8__locals17.VlcvwuHlCY.Send(CS_0024_003C_003E8__locals17.xAKvbTmUFJ, 10065, v1 ? "发送成功！" : "发送失败！");
				});
				break;
			case AllEnums.装备Type.梭子:
				DB.I.EOON01Bhu7(num, text, P_4, P_3, P_2, 洗炼属性缓存数据类2,  (bool v1) =>
				{
					CS_0024_003C_003E8__locals17.VlcvwuHlCY.Send(CS_0024_003C_003E8__locals17.xAKvbTmUFJ, 10065, v1 ? "发送成功！" : "发送失败！");
				});
				break;
			case AllEnums.装备Type.铭牌:
				DB.I.LuPNOoBm9M(num, text, P_4, P_3, P_2, 洗炼属性缓存数据类2,  (bool v1) =>
				{
					CS_0024_003C_003E8__locals17.VlcvwuHlCY.Send(CS_0024_003C_003E8__locals17.xAKvbTmUFJ, 10065, v1 ? "发送成功！" : "发送失败！");
				});
				break;
			case AllEnums.装备Type.仙器:
				DB.I.XS1NQib1hv(num, text, P_4, P_3, P_2, 洗炼属性缓存数据类2,  (bool v1) =>
				{
					CS_0024_003C_003E8__locals17.VlcvwuHlCY.Send(CS_0024_003C_003E8__locals17.xAKvbTmUFJ, 10065, v1 ? "发送成功！" : "发送失败！");
				});
				break;
			case AllEnums.装备Type.引灵幡:
				DB.I.q4tNElyr7E(num, text, P_4, P_3, P_2, 洗炼属性缓存数据类2,  (bool v1) =>
				{
					CS_0024_003C_003E8__locals17.VlcvwuHlCY.Send(CS_0024_003C_003E8__locals17.xAKvbTmUFJ, 10065, v1 ? "发送成功！" : "发送失败！");
				});
				break;
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求发送洗炼装备-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10036, func = "rZg8sCBuxo")]
	private void rZg8sCBuxo(Player P_0, bool P_1, string P_2, string P_3)
	{
		_003C_003Ec__DisplayClass35_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass35_0();
		CS_0024_003C_003E8__locals2.gp1vKSwisj = P_2;
		try
		{
			MyNATSocketClient myNATSocketClient = Singleton<全局变量类>.I.会话Dict.Values.ToList().Find( (MyNATSocketClient x) => x.使用中 && x.当前client.Online && x.转发client.Online && x.user.人物数据.账号 == CS_0024_003C_003E8__locals2.gp1vKSwisj);
			if (myNATSocketClient == null)
			{
				return;
			}
			string[] array = P_3.Split('|');
			for (int num = 0; num < array.Length; num++)
			{
				byte[] buffer = array[num].Split(',').Select(byte.Parse).ToArray();
				if (P_1)
				{
					myNATSocketClient.C_Send(buffer);
				}
				else
				{
					myNATSocketClient.S_Send(buffer);
				}
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求调试封包-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10090, func = "a5u8UysETO")]
	private void a5u8UysETO(Player P_0, int P_1, int P_2, string P_3)
	{
		try
		{
			if (P_0.tWVlQZZf7U)
			{
				switch ((AllEnums.菜单操作类型)P_1)
				{
				case AllEnums.菜单操作类型.个人_强制下线:
					f4V8gw5egP(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_拉黑IP:
					Iia8DWGc5b(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_拉黑Mac:
					NsF8jxvq63(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_拉黑QQ:
					l458lpUdk5(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_清空存档:
					H2J88K362S(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_清空南极点:
					Brw8IOVuMH(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_清空累充点:
					qB48oD71cS(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_清空奇宝点:
					Rfr8NuLhPI(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_清空金元宝:
					JfQ8ibJBYC(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_清空银元宝:
					uy98BGU9Is(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_清空定制异兽录:
					yTk8GMGKdW(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_清空定制浮生录:
					UOq8f6EvGG(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_清空定制六道轮回:
					a0I86JAX3B(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_清空定制超级道具:
					fEb82a2BNB(P_0, P_2);
					break;
				case AllEnums.菜单操作类型.个人_清空注册表数据:
					DZp8m7U7K5(P_0, P_3);
					break;
				case AllEnums.菜单操作类型.全区_清空全区存档:
					haM8PW8aZE(P_0);
					break;
				case AllEnums.菜单操作类型.全区_清空全区南极点:
					auw8XoCQBt(P_0);
					break;
				case AllEnums.菜单操作类型.全区_清空全区累充点:
					SIf8FUIJvH(P_0);
					break;
				case AllEnums.菜单操作类型.全区_清空全区奇宝点:
					q0a8LXZUmU(P_0);
					break;
				case AllEnums.菜单操作类型.全区_清空全区金元宝:
					HhU8SucTCZ(P_0);
					break;
				case AllEnums.菜单操作类型.全区_清空全区银元宝:
					dLR8csTKoH(P_0);
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("菜单操作集成-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private async Task LiJ8WKJvxt(MyNATSocketClient P_0, bool P_1 = false)
	{
		if (P_0.user.缓存数据.is战斗中)
		{
			Singleton<WdAPI>.I.EOYImZQJeG(P_0, true);
			P_0.S_Send(Singleton<WdAPI>.I.zXxoPwQcb0(P_0.user.人物数据.昵称));
			for (int i = 0; i < 100; i++)
			{
				if (!P_0.user.缓存数据.is战斗中)
				{
					break;
				}
				await Task.Delay(200);
			}
		}
		if (P_1)
		{
			P_0.S_Send(Singleton<WdAPI>.I.lexI4Im4MS(P_0.user.人物数据.昵称));
		}
	}

	
	private async Task f4V8gw5egP(Player P_0, int P_1)
	{
		try
		{
			MyNATSocketClient 当前角色 = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (当前角色 != null)
			{
				await LiJ8WKJvxt(当前角色, true);
				Send(P_0, 10065, "[" + 当前角色.user.人物数据.昵称 + "]已经被强制下线！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_强踢下线-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private async Task Iia8DWGc5b(Player P_0, int P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass39_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass39_0();
			CS_0024_003C_003E8__locals7.D1kvdjQsjD = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (CS_0024_003C_003E8__locals7.D1kvdjQsjD != null)
			{
				if (!Singleton<全局变量类>.I.黑名单记录.黑名单IP列表.Any( (string x) => x == CS_0024_003C_003E8__locals7.D1kvdjQsjD.当前client.IP))
				{
					Singleton<全局变量类>.I.黑名单记录.黑名单IP列表.Add(CS_0024_003C_003E8__locals7.D1kvdjQsjD.当前client.IP);
					Singleton<xloVkMlT29HN5P5svHC>.I.PCSlCXfEjx();
				}
				DB.I.锁定账号操作(CS_0024_003C_003E8__locals7.D1kvdjQsjD.user.人物数据.账号, "1");
				await LiJ8WKJvxt(CS_0024_003C_003E8__locals7.D1kvdjQsjD, true);
				Send(P_0, 10065, "[" + CS_0024_003C_003E8__locals7.D1kvdjQsjD.user.人物数据.昵称 + "]已经被强制下线！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_拉黑IP-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private async Task NsF8jxvq63(Player P_0, int P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass40_0();
			CS_0024_003C_003E8__locals7.bZ3vU1JRHd = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (CS_0024_003C_003E8__locals7.bZ3vU1JRHd != null)
			{
				if (!Singleton<全局变量类>.I.黑名单记录.黑名单MAC列表.Any( (string x) => x == CS_0024_003C_003E8__locals7.bZ3vU1JRHd.Mac))
				{
					Singleton<全局变量类>.I.黑名单记录.黑名单MAC列表.Add(CS_0024_003C_003E8__locals7.bZ3vU1JRHd.Mac);
					Singleton<xloVkMlT29HN5P5svHC>.I.PCSlCXfEjx();
				}
				DB.I.锁定账号操作(CS_0024_003C_003E8__locals7.bZ3vU1JRHd.user.人物数据.账号, "1");
				await LiJ8WKJvxt(CS_0024_003C_003E8__locals7.bZ3vU1JRHd, true);
				Send(P_0, 10065, "[" + CS_0024_003C_003E8__locals7.bZ3vU1JRHd.user.人物数据.昵称 + "]已经被强制下线！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_拉黑MAC-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private async Task l458lpUdk5(Player P_0, int P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass41_0 CS_0024_003C_003E8__locals13 = new _003C_003Ec__DisplayClass41_0();
			MyNATSocketClient 当前角色 = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (当前角色 == null || string.IsNullOrWhiteSpace(当前角色.user.存档数据.账号注册QQ))
			{
				return;
			}
			CS_0024_003C_003E8__locals13.gyavDocsFX = 当前角色.user.存档数据.账号注册QQ.Split("|");
			CS_0024_003C_003E8__locals13.EDyvjpqApM = 0;
			while (CS_0024_003C_003E8__locals13.EDyvjpqApM < CS_0024_003C_003E8__locals13.gyavDocsFX.Length)
			{
				if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals13.gyavDocsFX[CS_0024_003C_003E8__locals13.EDyvjpqApM]))
				{
					if (!Singleton<全局变量类>.I.黑名单记录.黑名单QQ列表.Any( (string x) => x == CS_0024_003C_003E8__locals13.gyavDocsFX[CS_0024_003C_003E8__locals13.EDyvjpqApM]))
					{
						Singleton<全局变量类>.I.黑名单记录.黑名单QQ列表.Add(CS_0024_003C_003E8__locals13.gyavDocsFX[CS_0024_003C_003E8__locals13.EDyvjpqApM]);
					}
					List<MyNATSocketClient> 当前角色列表 = Singleton<全局变量类>.I.会话Dict.Values.ToList().FindAll( (MyNATSocketClient x) => x.使用中 && x.当前client.Online && x.转发client.Online && ("|" + x.user.存档数据.账号注册QQ + "|").Contains("|" + CS_0024_003C_003E8__locals13.gyavDocsFX[CS_0024_003C_003E8__locals13.EDyvjpqApM] + "|", StringComparison.CurrentCulture));
					if (当前角色列表 != null)
					{
						for (int j = 0; j < 当前角色列表.Count; j++)
						{
							await LiJ8WKJvxt(当前角色, true);
							Send(P_0, 10065, "[" + 当前角色列表[j].user.人物数据.昵称 + "]已经被强制下线！");
						}
					}
				}
				CS_0024_003C_003E8__locals13.EDyvjpqApM++;
			}
			Singleton<xloVkMlT29HN5P5svHC>.I.PCSlCXfEjx();
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_拉黑QQ-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private async Task H2J88K362S(Player P_0, int P_1)
	{
		try
		{
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (myNATSocketClient != null)
			{
				await LiJ8WKJvxt(myNATSocketClient, true);
			}
			if (Singleton<全局变量类>.I.角色存档表.ContainsKey(P_1))
			{
				string 昵称 = Singleton<全局变量类>.I.角色存档表[P_1].昵称;
				Singleton<全局变量类>.I.角色存档表[P_1] = new 角色存档数据类
				{
					GID = P_1
				};
				DB.I.oMuiwEHr6E(P_1, Singleton<全局变量类>.I.角色存档表[P_1]);
				Send(P_0, 10065, "[" + 昵称 + "]的存档已经清除！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_清空存档-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void Brw8IOVuMH(Player P_0, int P_1)
	{
		try
		{
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (Singleton<全局变量类>.I.角色存档表.ContainsKey(P_1))
			{
				string 昵称 = Singleton<全局变量类>.I.角色存档表[P_1].昵称;
				if (myNATSocketClient != null)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(myNATSocketClient, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, 0, true, "后台清空");
				}
				else
				{
					Singleton<全局变量类>.I.角色存档表[P_1].南极抽奖次数 = 0;
					DB.I.oMuiwEHr6E(P_1, Singleton<全局变量类>.I.角色存档表[P_1]);
				}
				Send(P_0, 10065, "[" + 昵称 + "]的南极点已经清除！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_清空南极点-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void qB48oD71cS(Player P_0, int P_1)
	{
		try
		{
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (Singleton<全局变量类>.I.角色存档表.ContainsKey(P_1))
			{
				string 昵称 = Singleton<全局变量类>.I.角色存档表[P_1].昵称;
				if (myNATSocketClient != null)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(myNATSocketClient, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, 0, true, "后台清空");
				}
				else
				{
					Singleton<全局变量类>.I.角色存档表[P_1].累计充值金额 = 0;
					DB.I.oMuiwEHr6E(P_1, Singleton<全局变量类>.I.角色存档表[P_1]);
				}
				Send(P_0, 10065, "[" + 昵称 + "]的累充点已经清除！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_清空累充点-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void Rfr8NuLhPI(Player P_0, int P_1)
	{
		try
		{
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (Singleton<全局变量类>.I.角色存档表.ContainsKey(P_1))
			{
				string 昵称 = Singleton<全局变量类>.I.角色存档表[P_1].昵称;
				if (myNATSocketClient != null)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(myNATSocketClient, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, 0, true, "后台清空");
				}
				else
				{
					Singleton<全局变量类>.I.角色存档表[P_1].奇宝斋存档.奇宝斋余额 = 0;
					DB.I.oMuiwEHr6E(P_1, Singleton<全局变量类>.I.角色存档表[P_1]);
				}
				Send(P_0, 10065, "[" + 昵称 + "]的奇宝点已经清除！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_清空奇宝点-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void JfQ8ibJBYC(Player P_0, int P_1)
	{
		try
		{
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (!Singleton<全局变量类>.I.角色存档表.ContainsKey(P_1))
			{
				return;
			}
			string 昵称 = Singleton<全局变量类>.I.角色存档表[P_1].昵称;
			if (myNATSocketClient != null)
			{
				if (!DB.I.XTGNNsRFkB(myNATSocketClient, true))
				{
					return;
				}
			}
			else if (!DB.I.oEqNfmWhM4(Singleton<全局变量类>.I.角色存档表[P_1].账号))
			{
				return;
			}
			Send(P_0, 10065, "[" + 昵称 + "]的金元宝已经清除！");
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_清空金元宝-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void uy98BGU9Is(Player P_0, int P_1)
	{
		try
		{
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (!Singleton<全局变量类>.I.角色存档表.ContainsKey(P_1))
			{
				return;
			}
			string 昵称 = Singleton<全局变量类>.I.角色存档表[P_1].昵称;
			if (myNATSocketClient != null)
			{
				if (!DB.I.XTGNNsRFkB(myNATSocketClient, false))
				{
					return;
				}
			}
			else if (!DB.I.PtuN65WBZ6(Singleton<全局变量类>.I.角色存档表[P_1].账号))
			{
				return;
			}
			Send(P_0, 10065, "[" + 昵称 + "]的银元宝已经清除！");
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_清空银元宝-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void yTk8GMGKdW(Player P_0, int P_1)
	{
		try
		{
			if (!iRGieud4qtscW6ESmxk.C9dsD7Vloy())
			{
				Send(P_0, 10065, "当前卡密并没有开通 或者 开启 定制异兽录功能！");
				return;
			}
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (myNATSocketClient == null)
			{
				Send(P_0, 10065, "当前角色不在线，无法操作！");
			}
			else
			{
				myNATSocketClient.c2q6rOHHY9();
				Send(P_0, 10065, "[" + myNATSocketClient.user.人物数据.昵称 + "]的异兽录存档和属性已经清除！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_清空异兽录-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void UOq8f6EvGG(Player P_0, int P_1)
	{
		try
		{
			if (!浮生录功能.J7aWuMQOCf())
			{
				Send(P_0, 10065, "当前卡密并没有开通 或者 开启 定制浮生录功能！");
				return;
			}
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (myNATSocketClient == null)
			{
				Send(P_0, 10065, "当前角色不在线，无法操作！");
			}
			else
			{
				myNATSocketClient.l586ZEtJJW();
				Send(P_0, 10065, "[" + myNATSocketClient.user.人物数据.昵称 + "]的浮生录存档和属性已经清除！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_清空浮生录-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void a0I86JAX3B(Player P_0, int P_1)
	{
		try
		{
			if (!MbtVicwUkp5LuxTooFW.EaewmWn7Ul())
			{
				Send(P_0, 10065, "当前卡密并没有开通 或者 开启 定制六道轮回功能！");
				return;
			}
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (myNATSocketClient == null)
			{
				Send(P_0, 10065, "当前角色不在线，无法操作！");
			}
			else
			{
				myNATSocketClient.tNK6tvTO1H();
				Send(P_0, 10065, "[" + myNATSocketClient.user.人物数据.昵称 + "]的六道轮回存档和属性已经清除！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_清空六道轮回-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void fEb82a2BNB(Player P_0, int P_1)
	{
		try
		{
			if (!zeYnwTjKgpmAbfSQh5J.ARHjmZgHJU())
			{
				Send(P_0, 10065, "当前卡密并没有开通 或者 开启 定制超级道具功能！");
				return;
			}
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(P_1);
			if (myNATSocketClient == null)
			{
				Send(P_0, 10065, "当前角色不在线，无法操作！");
			}
			else
			{
				myNATSocketClient.O566AMjsok();
				Send(P_0, 10065, "[" + myNATSocketClient.user.人物数据.昵称 + "]的超级道具存档和属性已经清除！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_清空超级道具-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void DZp8m7U7K5(Player P_0, string P_1)
	{
		_003C_003Ec__DisplayClass52_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass52_0();
		CS_0024_003C_003E8__locals3.Y4Avom9NhM = P_1;
		try
		{
			注册信息 注册信息2 = Singleton<全局变量类>.I.注册列表.Find( (注册信息 x) => x.账号 == CS_0024_003C_003E8__locals3.Y4Avom9NhM);
			if (注册信息2 != null)
			{
				注册信息2.qq = string.Empty;
				注册信息2.IP = string.Empty;
				注册信息2.Mac = string.Empty;
				Send(P_0, 10065, "[账号=" + CS_0024_003C_003E8__locals3.Y4Avom9NhM + "]的注册信息已经清除，可以多注册一个号了！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("个人事件_清空注册表数据-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void haM8PW8aZE(Player P_0)
	{
		try
		{
			if (Singleton<全局变量类>.I.会话Dict.Values.ToArray().Any( (MyNATSocketClient x) => x.使用中))
			{
				Send(P_0, 10065, "清理全部存档需要没有任何玩家在线才可操作！");
				return;
			}
			Singleton<全局变量类>.I.角色存档表.Clear();
			File.Delete(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("/角色存档夹"));
			Send(P_0, 10065, "全区的存档已经清除！");
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("全区事件_清空存档-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void auw8XoCQBt(Player P_0)
	{
		try
		{
			foreach (角色存档数据类 value in Singleton<全局变量类>.I.角色存档表.Values)
			{
				value.南极抽奖次数 = 0;
				DB.I.oMuiwEHr6E(value.GID, value);
			}
			Send(P_0, 10065, "全区的南极点已经清除！");
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("全区事件_清空南极点-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void SIf8FUIJvH(Player P_0)
	{
		try
		{
			foreach (角色存档数据类 value in Singleton<全局变量类>.I.角色存档表.Values)
			{
				value.累计充值金额 = 0;
				DB.I.oMuiwEHr6E(value.GID, value);
			}
			Send(P_0, 10065, "全区的累计点已经清除！");
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("全区事件_清空累计点-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void q0a8LXZUmU(Player P_0)
	{
		try
		{
			foreach (角色存档数据类 value in Singleton<全局变量类>.I.角色存档表.Values)
			{
				value.奇宝斋存档.奇宝斋余额 = 0;
				DB.I.oMuiwEHr6E(value.GID, value);
			}
			Send(P_0, 10065, "全区的奇宝点已经清除！");
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("全区事件_清空奇宝点-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private async Task HhU8SucTCZ(Player P_0)
	{
		try
		{
			foreach (角色存档数据类 value in Singleton<全局变量类>.I.角色存档表.Values)
			{
				MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(value.GID);
				if (myNATSocketClient != null)
				{
					DB.I.XTGNNsRFkB(myNATSocketClient, true);
				}
				else
				{
					DB.I.oEqNfmWhM4(value.账号);
				}
				await Task.Delay(200);
			}
			Send(P_0, 10065, "全区的金元宝已经清除！");
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("全区事件_清空金元宝-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private async Task dLR8csTKoH(Player P_0)
	{
		try
		{
			foreach (角色存档数据类 value in Singleton<全局变量类>.I.角色存档表.Values)
			{
				MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(value.GID);
				if (myNATSocketClient != null)
				{
					DB.I.XTGNNsRFkB(myNATSocketClient, false);
				}
				else
				{
					DB.I.PtuN65WBZ6(value.账号);
				}
				await Task.Delay(200);
			}
			Send(P_0, 10065, "全区的银元宝已经清除！");
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("全区事件_清空银元宝-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10041, func = "w948n8AZGd")]
	private void w948n8AZGd(Player P_0, int P_1, int P_2)
	{
		_003C_003Ec__DisplayClass59_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass59_0();
		CS_0024_003C_003E8__locals5.i1YvivcNSK = P_2;
		MyNATSocketClient myNATSocketClient = Singleton<全局变量类>.I.会话Dict.Values.ToList().Find( (MyNATSocketClient x) => x.使用中 && x.当前client.Online && x.转发client.Online && x.user.人物数据.GID == CS_0024_003C_003E8__locals5.i1YvivcNSK);
		if (myNATSocketClient != null)
		{
			Send(P_0, 10072, CS_0024_003C_003E8__locals5.i1YvivcNSK, true, JsonConvert.SerializeObject(myNATSocketClient.user, Formatting.Indented));
		}
		else
		{
			Send(P_0, 10072, CS_0024_003C_003E8__locals5.i1YvivcNSK, false, JsonConvert.SerializeObject(Singleton<全局变量类>.I.角色存档表[CS_0024_003C_003E8__locals5.i1YvivcNSK], Formatting.Indented));
		}
	}

	
	[Rpc(cmd = 2, hash = 10042, func = "paS85wuais")]
	private void paS85wuais(Player P_0, int P_1, int P_2)
	{
		_003C_003Ec__DisplayClass60_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass60_0();
		CS_0024_003C_003E8__locals3.ggwvG4Ah7b = P_2;
		try
		{
			MyNATSocketClient myNATSocketClient = Singleton<全局变量类>.I.会话Dict.Values.ToList().Find( (MyNATSocketClient x) => x.使用中 && x.当前client.Online && x.转发client.Online && x.user.人物数据.GID == CS_0024_003C_003E8__locals3.ggwvG4Ah7b);
			if (myNATSocketClient == null && P_1 < 8)
			{
				Send(P_0, 10065, "要操作的角色不在线！");
				return;
			}
			switch (P_1)
			{
			case 1:
				myNATSocketClient.user.存档数据.南极抽奖次数 = 0;
				break;
			case 2:
				myNATSocketClient.user.存档数据.累计充值金额 = 0;
				myNATSocketClient.user.存档数据.累计充值_积分 = 0;
				myNATSocketClient.user.存档数据.累计充值_奖励领取情况 = 0;
				break;
			case 3:
				DB.I.cAJNoOkab6(myNATSocketClient, -myNATSocketClient.user.背包数据.金元宝, -myNATSocketClient.user.背包数据.银元宝);
				break;
			case 4:
				myNATSocketClient.user.存档数据.浮生录数据.清空();
				Singleton<WdAPI>.I.清空玩家相性点(myNATSocketClient);
				break;
			case 5:
				myNATSocketClient.user.存档数据.轮回转世数据.清空();
				Singleton<WdAPI>.I.清空玩家相性点(myNATSocketClient);
				break;
			case 6:
				myNATSocketClient.user.存档数据.异兽录数据.清空();
				Singleton<WdAPI>.I.清空玩家相性点(myNATSocketClient);
				break;
			case 7:
				myNATSocketClient.user.存档数据.超级道具数据.Find( (超级道具数据类 x) => x.加成属性 == AllEnums.数值Type.气血上限)?.清空();
				break;
			}
			if (myNATSocketClient != null)
			{
				DB.I.oMuiwEHr6E(CS_0024_003C_003E8__locals3.ggwvG4Ah7b, myNATSocketClient.user.存档数据);
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求调试封包-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10043, func = "xRD8MlyBom")]
	private async void xRD8MlyBom(Player P_0, int P_1)
	{
		_ = 1;
		try
		{
			switch (P_1)
			{
			case 1:
				foreach (角色存档数据类 value in Singleton<全局变量类>.I.角色存档表.Values)
				{
					value.南极抽奖次数 = 0;
				}
				break;
			case 2:
				foreach (角色存档数据类 value2 in Singleton<全局变量类>.I.角色存档表.Values)
				{
					value2.累计充值金额 = 0;
					value2.累计充值_积分 = 0;
					value2.累计充值_奖励领取情况 = 0;
				}
				break;
			case 3:
				foreach (角色存档数据类 value3 in Singleton<全局变量类>.I.角色存档表.Values)
				{
					DB.I.b0lNGoCiRI(value3.账号);
					await Task.Delay(100);
				}
				break;
			case 4:
				foreach (角色存档数据类 value4 in Singleton<全局变量类>.I.角色存档表.Values)
				{
					value4.浮生录数据.清空();
					await Task.Delay(100);
				}
				break;
			}
			await DB.I.oSPiJX3g49();
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求调试封包-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10044, func = "qiR8hh72Kh")]
	private async void qiR8hh72Kh(Player P_0, bool P_1)
	{
		try
		{
			List<MyNATSocketClient> 角色列表 = Singleton<全局变量类>.I.会话Dict.Values.ToList().FindAll( (MyNATSocketClient x) => x.使用中 && x.当前client.Online && x.转发client.Online && x.user.人物数据.Is试道场);
			if (角色列表 == null)
			{
				Send(P_0, 10073, string.Empty);
				return;
			}
			string 角色组 = string.Empty;
			for (int i = 0; i < 角色列表.Count; i++)
			{
				string text = 角色组;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 6);
				defaultInterpolatedStringHandler.AppendFormatted((i != 0) ? "|" : string.Empty);
				defaultInterpolatedStringHandler.AppendFormatted(角色列表[i].user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral("=");
				defaultInterpolatedStringHandler.AppendFormatted(角色列表[i].user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("=");
				defaultInterpolatedStringHandler.AppendFormatted(角色列表[i].user.属性数据.等级);
				defaultInterpolatedStringHandler.AppendLiteral("=");
				defaultInterpolatedStringHandler.AppendFormatted(角色列表[i].user.背包数据.金元宝);
				defaultInterpolatedStringHandler.AppendLiteral("=");
				defaultInterpolatedStringHandler.AppendFormatted(角色列表[i].user.背包数据.银元宝);
				角色组 = text + defaultInterpolatedStringHandler.ToStringAndClear();
				await Task.Delay(1);
			}
			Send(P_0, 10073, 角色组);
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求刷新试道场内信息-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10045, func = "fyH8v3WJU5")]
	private async void fyH8v3WJU5(Player P_0, int P_1, int P_2)
	{
		try
		{
			List<MyNATSocketClient> 角色列表 = Singleton<全局变量类>.I.会话Dict.Values.ToList().FindAll( (MyNATSocketClient x) => x.使用中 && x.当前client.Online && x.转发client.Online && x.user.人物数据.Is试道场);
			if (角色列表 == null)
			{
				Send(P_0, 10065, "试道场内并无任何玩家！");
				return;
			}
			int 角色组 = 0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			for (int i = 0; i < 角色列表.Count; i++)
			{
				if (DB.I.cAJNoOkab6(角色列表[i], P_1, P_2))
				{
					MyNATSocketClient myNATSocketClient = 角色列表[i];
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你获得了试道期间管理员发放的#Y金元宝×");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("#n，#Y银元宝×");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					myNATSocketClient.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					角色组++;
				}
				await Task.Delay(1);
			}
			WdServer wdServer = this;
			object[] array = new object[1];
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
			defaultInterpolatedStringHandler.AppendLiteral("发送成功，总计发送人数：");
			defaultInterpolatedStringHandler.AppendFormatted(角色组);
			defaultInterpolatedStringHandler.AppendLiteral("人！");
			array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
			wdServer.Send(P_0, 10065, array);
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求试道发送元宝-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10046, func = "n2v875uHXQ")]
	private void n2v875uHXQ(Player P_0, string P_1, string P_2, string P_3, int P_4, int P_5, int P_6, int P_7, int P_8)
	{
		_003C_003Ec__DisplayClass64_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass64_0();
		CS_0024_003C_003E8__locals6.jcHv6y2tX6 = this;
		CS_0024_003C_003E8__locals6.UtSv2XKwuM = P_0;
		try
		{
			if (!CS_0024_003C_003E8__locals6.UtSv2XKwuM.tWVlQZZf7U)
			{
				Send(CS_0024_003C_003E8__locals6.UtSv2XKwuM, 10074, "请先登录管理员！");
				return;
			}
			DB.I.后台注册GM账号事件(P_1, P_2, P_3, "", P_5, P_6, P_4, P_7, P_8,  (string v1) =>
			{
				CS_0024_003C_003E8__locals6.jcHv6y2tX6.Send(CS_0024_003C_003E8__locals6.UtSv2XKwuM, 10074, v1);
			});
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求注册GM号-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10047, func = "HlE8aGHQZ8")]
	private void HlE8aGHQZ8(Player P_0, bool P_1)
	{
		try
		{
			if (P_0.tWVlQZZf7U)
			{
				Singleton<全局变量类>.I.喊话限制配置.Is开启 = P_1;
				Singleton<KU0aMobWe16QEEmpLCj>.I.kd2bjmeMXG();
				Send(P_0, 10065, (P_1 ? "定时喊话开启成功！" : "定时喊话已经关闭！") ?? "");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求定时喊话-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10048, func = "GLl8T8DQBd")]
	private void GLl8T8DQBd(Player P_0, string P_1, string P_2, string P_3, string P_4, string P_5)
	{
		try
		{
			if (P_0.tWVlQZZf7U)
			{
				MyNATSocketClient myNATSocketClient = Singleton<全局变量类>.I.会话Dict.Values.ToList().Find( (MyNATSocketClient x) => x.user.人物数据.账号 == Singleton<全局变量类>.I.config.挂载GM账号);
				if (myNATSocketClient == null)
				{
					Send(P_0, 10065, "管理员不在线，设置失败！");
				}
				else
				{
					myNATSocketClient.S_Send(Singleton<WdAPI>.I.动态设置全局双倍(P_1, P_2, P_3, P_4, P_5));
					Send(P_0, 10065, "设置完毕，请在游戏中查看是否成功设置了全局多倍！");
				}
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求设置全局多倍-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10049, func = "fdc89NcPvr")]
	private void fdc89NcPvr(Player P_0, bool P_1, bool P_2, int P_3, string P_4, string P_5, int P_6, int P_7)
	{
		try
		{
			if (P_0.tWVlQZZf7U)
			{
				Singleton<全局变量类>.I.奇宝斋配置.功能开关 = P_1;
				Singleton<全局变量类>.I.奇宝斋配置.玩家上架开关 = P_2;
				Singleton<全局变量类>.I.奇宝斋配置.卖出手续费 = P_3;
				Singleton<全局变量类>.I.奇宝斋配置.充值网址 = P_4;
				Singleton<全局变量类>.I.奇宝斋配置.上架押金 = P_6;
				Singleton<全局变量类>.I.奇宝斋配置.奇宝点比例 = P_7;
				Singleton<全局变量类>.I.奇宝斋配置.可上架商品 = P_5;
				Singleton<svsUCqKdlsQkBBIo3St>.I.OB7KWHwPa4();
				Send(P_0, 10065, "保存成功！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求设置全局多倍-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10050, func = "VU48yxdmTy")]
	private void VU48yxdmTy(Player P_0, string P_1, int P_2, int P_3, string P_4, int P_5, int P_6)
	{
		try
		{
			if (P_0.tWVlQZZf7U)
			{
				奇宝斋数据类 奇宝斋数据类2 = Singleton<svsUCqKdlsQkBBIo3St>.I.tVMKi1CdPF(string.Empty, P_1, P_2, P_5, P_3, P_4, P_6);
				Send(P_0, 10075, (奇宝斋数据类2 == null) ? string.Empty : JsonConvert.SerializeObject(奇宝斋数据类2, Formatting.Indented));
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求设置全局多倍-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10051, func = "UUJ8CBDMlN")]
	private void UUJ8CBDMlN(Player P_0, string P_1, int P_2)
	{
		try
		{
			if (P_0.tWVlQZZf7U)
			{
				if (!Singleton<全局变量类>.I.奇宝斋配置.物品列表.ContainsKey(P_1))
				{
					Send(P_0, 10065, "当前要删除的奇宝斋商品已经不存在！");
					return;
				}
				Singleton<全局变量类>.I.奇宝斋配置.物品列表.TryRemove(P_1, out 奇宝斋数据类 _);
				Singleton<svsUCqKdlsQkBBIo3St>.I.OB7KWHwPa4();
				svsUCqKdlsQkBBIo3St.r9kKchaSXB = true;
				Send(P_0, 10076, P_1, P_2);
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求设置全局多倍-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10052, func = "jtn8VMAthZ")]
	private void jtn8VMAthZ(Player P_0, string P_1, string P_2, int P_3, int P_4, int P_5, string P_6, int P_7, string P_8)
	{
		try
		{
			if (P_0.tWVlQZZf7U)
			{
				if (Singleton<全局变量类>.I.奇宝斋配置.物品列表.TryGetValue(P_1, out 奇宝斋数据类 value))
				{
					value.物品名称 = P_2;
					value.物品价格 = P_3;
					value.出售数量 = P_4;
					value.物品图标 = P_5;
					value.出售账号 = P_6;
					value.物品权重 = P_7;
					value.到期时间 = P_8;
					Singleton<svsUCqKdlsQkBBIo3St>.I.OB7KWHwPa4();
					svsUCqKdlsQkBBIo3St.r9kKchaSXB = true;
					Send(P_0, 10077, true);
				}
				else
				{
					Send(P_0, 10065, "当前要修改的奇宝斋商品不存在！");
				}
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求设置全局多倍-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10053, func = "Fua8krM2Kx")]
	private void Fua8krM2Kx(Player P_0, bool P_1)
	{
		if (P_0.tWVlQZZf7U)
		{
			Singleton<APqDp4bq1ecVdMifnI1>.I.oY7JUm7D0t();
			Send(P_0, 10065, "本期融丹存档已经全部清空！");
		}
	}

	
	internal void K8S80r9K9f(string P_0)
	{
		if (base.Clients.Count <= 0)
		{
			return;
		}
		foreach (Player client in base.Clients)
		{
			Send(client, 10058, P_0);
		}
	}

	
	internal void tB88OiXhZ8(bool P_0)
	{
		try
		{
			if (base.Clients.Count <= 0)
			{
				return;
			}
			foreach (Player client in base.Clients)
			{
				if (!P_0)
				{
					client.Dispose();
				}
			}
		}
		catch
		{
		}
	}

	
	[Rpc(cmd = 2, hash = 10054, func = "sfN8QyAFJp")]
	internal void sfN8QyAFJp(Player P_0, string P_1, string P_2)
	{
		if (!P_0.tWVlQZZf7U || string.IsNullOrWhiteSpace(P_1))
		{
			return;
		}
		if (P_1 == "所有玩家")
		{
			foreach (MyNATSocketClient value in Singleton<全局变量类>.I.会话Dict.Values)
			{
				if (value.使用中 && value.user.人物数据.角色ID != 0)
				{
					Singleton<fK6mLrjpv26MU2YIIF9>.I.Ym9jrsy6dl(value, P_2);
				}
			}
			return;
		}
		MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定Name玩家MyClient(P_1);
		if (myNATSocketClient == null)
		{
			Send(P_0, 10065, "当前角色不在线！");
		}
		else
		{
			Singleton<fK6mLrjpv26MU2YIIF9>.I.Ym9jrsy6dl(myNATSocketClient, P_2);
			Send(P_0, 10065, "邮箱发送成功！");
		}
	}

	
	[Rpc(cmd = 2, hash = 10081, func = "MHf8EgdWBo")]
	internal void MHf8EgdWBo(Player P_0, bool P_1)
	{
		if (P_0.tWVlQZZf7U)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  保存写入日志\n");
			Serilog.Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
			Send(P_0, 10065, "日志保存成功！");
		}
	}

	
	[Rpc(cmd = 2, hash = 10055, func = "pG8830eib1")]
	internal async Task pG8830eib1(Player P_0, bool P_1)
	{
		if (P_0.tWVlQZZf7U)
		{
			for (int i = 0; i < Singleton<全局变量类>.I.商城数据列表.Count; i++)
			{
				Send(P_0, 10078, JsonConvert.SerializeObject(Singleton<全局变量类>.I.商城数据列表[i], Formatting.Indented), false);
				await Task.Delay(1);
			}
			Send(P_0, 10078, string.Empty, true);
			await Task.Delay(1000);
			Send(P_0, 10059, true, 29, Singleton<FusVSwwzpuFHNrjHS7T>.I.c75bJttR9s());
		}
	}

	
	[Rpc(cmd = 2, hash = 10082, func = "av68YudAYR")]
	internal void av68YudAYR(Player P_0, string P_1, int P_2)
	{
		_003C_003Ec__DisplayClass77_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass77_0();
		CS_0024_003C_003E8__locals3.YaovX2RIBE = P_1;
		if (!P_0.tWVlQZZf7U)
		{
			return;
		}
		MyNATSocketClient myNATSocketClient = Singleton<全局变量类>.I.会话Dict.Values.ToList().Find( (MyNATSocketClient x) => x.账号 == CS_0024_003C_003E8__locals3.YaovX2RIBE);
		if (myNATSocketClient != null)
		{
			bool flag = Singleton<MainService>.I.发送角色属性道具(myNATSocketClient, AllEnums.数值Type.点卡点数, P_2);
			Send(P_0, 10065, flag ? "发送成功" : "发送失败");
			return;
		}
		角色存档数据类 角色存档数据类2 = Singleton<全局变量类>.I.角色存档表.Values.ToList().Find( (角色存档数据类 x) => x.账号 == CS_0024_003C_003E8__locals3.YaovX2RIBE);
		if (角色存档数据类2 != null)
		{
			角色存档数据类2.点卡存档.当前点数 += P_2;
			Send(P_0, 10065, "发送成功");
		}
		else
		{
			Send(P_0, 10065, "发送失败，账号不存在");
		}
	}

	
	[Rpc(cmd = 2, hash = 10083, func = "SSp8pyIMgD")]
	internal void SSp8pyIMgD(Player P_0, int P_1, string P_2, string P_3, string P_4, string P_5, string P_6, string P_7)
	{
		_003C_003Ec__DisplayClass78_0 CS_0024_003C_003E8__locals12 = new _003C_003Ec__DisplayClass78_0();
		CS_0024_003C_003E8__locals12.OlcvLqduJp = this;
		CS_0024_003C_003E8__locals12.pHFvSHRFkv = P_0;
		CS_0024_003C_003E8__locals12.PwGvccwJXw = P_1;
		if (!CS_0024_003C_003E8__locals12.pHFvSHRFkv.tWVlQZZf7U || !wki1dRBBTGa2CXII175.RwABX24lCy())
		{
			return;
		}
		bool flag = false;
		switch (CS_0024_003C_003E8__locals12.PwGvccwJXw)
		{
		case 1:
			flag = DB.I.V0wNwNfGJR(P_2, P_3, P_4, P_5, P_6, P_7);
			Send(CS_0024_003C_003E8__locals12.pHFvSHRFkv, 10083, CS_0024_003C_003E8__locals12.PwGvccwJXw, flag, flag ? "成功连接" : "连接失败");
			break;
		case 2:
			flag = Singleton<wki1dRBBTGa2CXII175>.I.BbnBfEwQSV();
			Send(CS_0024_003C_003E8__locals12.pHFvSHRFkv, 10083, CS_0024_003C_003E8__locals12.PwGvccwJXw, flag, flag ? "读取成功" : "读取失败");
			break;
		case 3:
			Singleton<wki1dRBBTGa2CXII175>.I.NbJB6ku1Gh(P_2, P_3, P_4, P_5, P_6, P_7,  (bool v1, string v2) =>
			{
				CS_0024_003C_003E8__locals12.OlcvLqduJp.Send(CS_0024_003C_003E8__locals12.pHFvSHRFkv, 10083, CS_0024_003C_003E8__locals12.PwGvccwJXw, v1, v2);
			});
			break;
		}
	}

	
	[Rpc(cmd = 2, hash = 10084, func = "wMU81BvObj")]
	internal void wMU81BvObj(Player P_0, string P_1)
	{
		try
		{
			if (!管理员授权租约有效(P_0))
			{
				Send(P_0, 10084, false, "请先完成后台登录和授权验证！");
			}
			else if (string.IsNullOrWhiteSpace(P_1))
			{
				Send(P_0, 10084, false, "卡密无效！");
			}
			else if (Singleton<全局变量类>.I.config.卡密 != P_1)
			{
				Send(P_0, 10084, false, "卡密错误！");
			}
			else if (!Singleton<全局变量类>.I.验证client.授权配置.IsVip && !Singleton<全局变量类>.I.验证client.授权配置.Is测试卡)
			{
				Send(P_0, 10084, false, "非[VIP功能]或[测试卡]用户无法使用自助适配功能呦。");
			}
			else
			{
				Send(P_0, 10084, true, string.Empty);
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求适配操作-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10088, func = "esw8xdJDVB")]
	internal void esw8xdJDVB(Player P_0, string P_1)
	{
		try
		{
			if (!P_0.tWVlQZZf7U)
			{
				Send(P_0, 10084, false, "请先登录后台！");
			}
			else
			{
				Singleton<BsbfIlwwf1YnPvbq8GT>.I.ukmwscj752(P_1);
				Send(P_0, 10060, "全服记录的首次破境道友信息已经被清除！");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("请求适配操作-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	[Rpc(cmd = 2, hash = 10089, func = "gXC8HcqOI5")]
	internal void gXC8HcqOI5(Player P_0, bool P_1, string P_2)
	{
		try
		{
			if (!P_0.tWVlQZZf7U)
			{
				Send(P_0, 10084, false, "请先登录后台！");
			}
			else
			{
				if (string.IsNullOrWhiteSpace(P_2))
				{
					return;
				}
				if (P_1)
				{
					MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定角色账号玩家MyClient(P_2);
					if (myNATSocketClient != null)
					{
						Singleton<WdAPI>.I.WT9IHmFS6c(myNATSocketClient, myNATSocketClient.user.人物数据.昵称);
					}
				}
				bool flag = DB.I.锁定账号操作(P_2, P_1 ? "1" : "0");
				Send(P_0, 10065, flag ? "操作完成，请登录查看！" : "操作失败，请重新输入账号。");
			}
		}
		catch (Exception ex)
		{
			Serilog.Log.Error("封解账号操作-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public WdServer()
	{
		StableRuntime.Install();
		防CC命令 = new List<string>();
	}

	static WdServer()
	{
	}
}
