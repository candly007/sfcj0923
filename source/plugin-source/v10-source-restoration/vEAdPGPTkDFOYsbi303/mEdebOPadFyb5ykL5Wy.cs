using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Net.System;
using Serilog;
using Serilog.Configuration;
using Serilog.Events;
using cVS5v9gmXX8TceaB2WW;

namespace vEAdPGPTkDFOYsbi303;

internal class mEdebOPadFyb5ykL5Wy
{
	public static Process LJLPkNiFSB;

	public static TimeSpan zOAP0mMwcF;

	public static int YtCPOshNwG;

	public static string uXlPQopXNv;

	public static string iK2PEDBpEm;

	
	public static string W80P9ipOVU(string P_0)
	{
		return uXlPQopXNv + "/" + P_0;
	}

	
	public static string KcdPy986T8(string P_0)
	{
		using SHA256 sHA = SHA256.Create();
		using FileStream inputStream = File.OpenRead(P_0);
		return BitConverter.ToString(sHA.ComputeHash(inputStream)).Replace("-", "").ToLowerInvariant();
	}

	
	private static void BegPCtbndV()
	{
		string logDirectory = Path.Combine(AppContext.BaseDirectory, "logs");
		Directory.CreateDirectory(logDirectory);
		Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().MinimumLevel.Override("Microsoft", LogEventLevel.Debug).Enrich.FromLogContext().Enrich.WithProperty("AppName", "ShunfengPlugin").Enrich.WithProperty("Environment", "Production").WriteTo.Console(LogEventLevel.Debug, "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}").WriteTo.Async( (LoggerSinkConfiguration a) =>
		{
			a.File(Path.Combine(logDirectory, "log-.log"), LogEventLevel.Debug, "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}", null, retainedFileCountLimit: 100, fileSizeLimitBytes: 10485760L, levelSwitch: null, buffered: false, shared: false, flushToDiskInterval: null, rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true);
		}).WriteTo.Logger( (LoggerConfiguration paymentAudit) =>
		{
			paymentAudit.Filter.ByIncludingOnly( (LogEvent evt) => evt.Properties.TryGetValue("AuditCategory", out LogEventPropertyValue category) && string.Equals(category.ToString().Trim('"'), "internal-payment", StringComparison.Ordinal)).WriteTo.Async( (LoggerSinkConfiguration a) =>
			{
				 a.File(Path.Combine(uXlPQopXNv, "内充支付日志", "log-.log"), LogEventLevel.Information, "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}", null, retainedFileCountLimit: 10, fileSizeLimitBytes: 10485760L, levelSwitch: null, buffered: false, shared: false, flushToDiskInterval: null, rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true);
			});
		}).WriteTo.Logger( (LoggerConfiguration playerPacket) =>
		{
			playerPacket.Filter.ByIncludingOnly( (LogEvent evt) => evt.Properties.TryGetValue("AuditCategory", out LogEventPropertyValue category) && string.Equals(category.ToString().Trim('"'), "player-anomaly", StringComparison.Ordinal)).WriteTo.Async( (LoggerSinkConfiguration a) =>
			{
				a.File(Path.Combine(uXlPQopXNv, "玩家异常封包日志", "log-.log"), LogEventLevel.Error, "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}", null, retainedFileCountLimit: 20, fileSizeLimitBytes: 10485760L, levelSwitch: null, buffered: false, shared: false, flushToDiskInterval: null, rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true);
			});
		}).CreateLogger();
	}

	
	public static async Task cGgPVyYtIA(string[] P_0)
	{
		Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
		AppDomain.CurrentDomain.UnhandledException +=  (object sender, UnhandledExceptionEventArgs e) =>
		{
			Exception ex2 = e.ExceptionObject as Exception;
			string path = Path.Combine(AppContext.BaseDirectory, "crash.log");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(11, 2);
			defaultInterpolatedStringHandler2.AppendLiteral("[CRASH] ");
			defaultInterpolatedStringHandler2.AppendFormatted(DateTime.Now);
			defaultInterpolatedStringHandler2.AppendLiteral(": ");
			defaultInterpolatedStringHandler2.AppendFormatted(ex2?.ToString());
			defaultInterpolatedStringHandler2.AppendLiteral("\n");
			File.AppendAllText(path, defaultInterpolatedStringHandler2.ToStringAndClear());
		};
		TaskScheduler.UnobservedTaskException +=  (object? sender, UnobservedTaskExceptionEventArgs e) =>
		{
			string path = Path.Combine(AppContext.BaseDirectory, "crash.log");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler2.AppendLiteral("[TASK CRASH] ");
			defaultInterpolatedStringHandler2.AppendFormatted(DateTime.Now);
			defaultInterpolatedStringHandler2.AppendLiteral(": ");
			defaultInterpolatedStringHandler2.AppendFormatted(e.Exception?.ToString());
			defaultInterpolatedStringHandler2.AppendLiteral("\n");
			File.AppendAllText(path, defaultInterpolatedStringHandler2.ToStringAndClear());
			e.SetObserved();
		};
		try
		{
			uXlPQopXNv = Path.Combine(AppContext.BaseDirectory, "插件配置夹");
			if (!Directory.Exists(uXlPQopXNv))
			{
				Directory.CreateDirectory(uXlPQopXNv);
			}
			if (!Directory.Exists(uXlPQopXNv + "/合区文件夹"))
			{
				Directory.CreateDirectory(uXlPQopXNv + "/合区文件夹");
			}
			if (!Directory.Exists(uXlPQopXNv + "/角色存档夹"))
			{
				Directory.CreateDirectory(uXlPQopXNv + "/角色存档夹");
			}
			if (!Directory.Exists(uXlPQopXNv + "/宠物存档夹"))
			{
				Directory.CreateDirectory(uXlPQopXNv + "/宠物存档夹");
			}
			if (!Directory.Exists(uXlPQopXNv + "/内充支付日志"))
			{
				Directory.CreateDirectory(uXlPQopXNv + "/内充支付日志");
			}
			if (!Directory.Exists(uXlPQopXNv + "/玩家异常封包日志"))
			{
				Directory.CreateDirectory(uXlPQopXNv + "/玩家异常封包日志");
			}
			LJLPkNiFSB = Process.GetCurrentProcess();
			zOAP0mMwcF = LJLPkNiFSB.TotalProcessorTime;
			YtCPOshNwG = Environment.TickCount;
			BegPCtbndV();
			Log.Warning("🚀高性能日志系统启动成功！");
			Singleton<全局变量类>.I.Config读取();
			Singleton<全局变量类>.I.Config保存();
			ByteAPI.SetChinaToAsia(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
			// Production builds never infer an authorization bypass from the host OS or
			// a loopback plugin address. 验证平台校验() remains available for its
			// non-authorization path handling (for example persisted file naming).
			全局变量类.Is调试 = false;
			if (Singleton<全局变量类>.I.config.后台管理端口 == 0)
			{
				Singleton<全局变量类>.I.config.后台管理端口 = 43210;
			}
			// The license gate is deliberately before WdServer, CC protection, gateway,
			// database reads and game-line initialization. An invalid card must leave no
			// plugin listener running and must fail with a direct, actionable message.
			Singleton<全局变量类>.I.验证client = new MyGdTcpClient();
			var startupLicense = await Singleton<全局变量类>.I.验证client.验证授权(
				Singleton<全局变量类>.I.config.卡密,
				Singleton<全局变量类>.I.config.取当前授权服务器地址());
			if (!startupLicense.Valid)
			{
				var message = "卡密验证失败，插件未启动：" + startupLicense.Message;
				Console.Error.WriteLine(message);
				Log.Error("{Message}", message);
				return;
			}
			BufferPool.Size = 5242880;
			Singleton<MainService>.I.server = new WdServer();
			Singleton<MainService>.I.server.Start(Singleton<全局变量类>.I.config.后台管理端口);
			Singleton<全局变量类>.I.防CCServer = new MyFccServer();
			if (!全局变量类.Is调试)
			{
				Singleton<全局变量类>.I.防CCServer.启动防CC();
			}
			Singleton<GyJyg8g24jqCD31mjD6>.I.mqggP8ij2u();
			Singleton<全局变量类>.I.网关Server = new MyHPServer();
			if (Singleton<全局变量类>.I.网关Config.网关端口 != 0)
			{
				Singleton<全局变量类>.I.网关Server.启动网关();
			}
			Singleton<MainService>.I.ReadMianConfig();
			await Singleton<后台验证交互类>.I.Init();
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				while (true)
				{
					Console.ReadKey();
				}
			}
			Thread.Sleep(-1);
		}
		catch (Exception ex)
		{
			Log.Error(ex, "Server startup failed: {Exception}", ex.ToString());
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
			defaultInterpolatedStringHandler.AppendLiteral("捕获到一个异常：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				while (true)
				{
					Console.ReadKey();
				}
			}
		}
		finally
		{
			Log.CloseAndFlush();
		}
	}

	
	public mEdebOPadFyb5ykL5Wy()
	{
	}

	
	static mEdebOPadFyb5ykL5Wy()
	{
		iK2PEDBpEm = "";
	}
}
