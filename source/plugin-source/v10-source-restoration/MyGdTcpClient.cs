using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Net.Client;
using Net.Share;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

public class MyGdTcpClient : TcpClient
{
	public Action<bool, string> 验证回调;

	public Action<bool, string> 续费回调;

	public string 真实IP;

	public bool 是否成功;

	public string 到期时间;

	public 功能授权类 授权配置;
	private CancellationTokenSource 租约监控取消;
	private CancellationTokenSource 状态心跳取消;
	private string 当前卡密 = string.Empty;
	private string 当前授权服务器 = string.Empty;
	private DateTimeOffset 最近在线授权成功时间 = DateTimeOffset.MinValue;
	private int 授权失效关闭中;
	private LicenseValidationResult 最近有效租约 = new(false, "尚未授权", string.Empty);

	
	public MyGdTcpClient()
	{
		真实IP = string.Empty;
		// Fail closed until the license service returns a verified signed lease.
		是否成功 = false;
		授权配置 = new 功能授权类();
		AddRpc(this);
		AddRpcHandle(this);
	}

	
	public void 验证插件(string 用户QQ, string 当前登录QQ, Action<bool, string> 当前验证回调 = null)
	{
	}

	public async Task<LicenseValidationResult> 验证授权(string 卡密, string 授权服务器地址)
	{
		当前卡密 = 卡密 ?? string.Empty;
		当前授权服务器 = 授权服务器地址 ?? string.Empty;
		var result = await LicenseClient.ValidateAsync(卡密, 授权服务器地址);
		应用授权结果(result);
		if (result.Valid)
		{
			if (await 检查并上报篡改(result))
			{
				是否成功 = false;
				return result with { Valid = false, Message = "检测到运行时调试或完整性异常" };
			}
			启动租约监控();
			启动状态心跳();
		}
		else
		{
			停止租约监控();
			if (Singleton<全局变量类>.I.插件启动状态) 触发授权失效关闭(result.Message);
		}
		return result;
	}

	private void 应用授权结果(LicenseValidationResult result)
	{
		if (result.Valid && result.ValidatedAt != DateTimeOffset.MinValue
			&& (!result.FromCache || 最近在线授权成功时间 == DateTimeOffset.MinValue))
		{
			// Only a fresh, signed online response starts a new grace window. A cache
			// response keeps its persisted timestamp, so repeated backend logins during
			// an outage cannot extend the ten-minute offline window.
			最近在线授权成功时间 = result.ValidatedAt;
		}
		是否成功 = result.Valid && 授权租约有效时间内();
		到期时间 = result.ExpiresAt;
		if (result.Valid)
		{
			Interlocked.Exchange(ref 授权失效关闭中, 0);
			最近有效租约 = result;
			// This product has one full-access plan; no per-feature card matrix is used.
			授权配置.更新(new List<bool>(), "在线全功能授权");
		}
	}

	/// <summary>
	/// 后台 RPC 和线路启动使用的同步租约闸门。读取本地缓存不会刷新最近一次在线成功时间。
	/// </summary>
	public bool 授权租约有效()
	{
		return 是否成功 && 授权租约有效时间内();
	}

	public bool 授权控制面许可()
	{
		if (!授权租约有效()) return false;
		if (!TamperGuard.TryGetHighConfidenceReason(out _)) return true;
		_ = 检查并上报篡改(最近有效租约);
		return false;
	}

	public bool 授权线路启动许可()
	{
		return 授权控制面许可() && BuildIdentity.IsAuthentic();
	}

	private bool 授权租约有效时间内()
	{
		return 最近在线授权成功时间 != DateTimeOffset.MinValue
			&& DateTimeOffset.UtcNow - 最近在线授权成功时间 <= TimeSpan.FromMinutes(10);
	}

	public void 触发授权失效关闭(string 原因)
	{
		是否成功 = false;
		try { Singleton<全局变量类>.I.插件启动状态 = false; } catch { }
		if (Interlocked.Exchange(ref 授权失效关闭中, 1) != 0) return;
		停止租约监控();
		停止状态心跳();
		_ = 授权失效关闭线路(原因);
	}

	private async Task 授权失效关闭线路(string 原因)
	{
		try
		{
			Serilog.Log.Error("授权租约失效，停止游戏线路：{Message}", 原因);
			await Singleton<MainService>.I.ServerClose();
		}
		catch (Exception ex)
		{
			Serilog.Log.Error(ex, "授权失效关闭游戏线路失败");
		}
	}

	private async Task<bool> 检查并上报篡改(LicenseValidationResult result)
	{
		if (!result.Valid || !TamperGuard.TryGetHighConfidenceReason(out var reason)) return false;
		Serilog.Log.Error("检测到高置信度调试或完整性异常，立即停止线路并上报授权服务：{Reason}", reason);
		await LicenseClient.ReportTamperAsync(当前卡密, 当前授权服务器, result, reason);
		触发授权失效关闭("检测到运行时调试或完整性异常");
		return true;
	}

	private void 启动租约监控()
	{
		停止租约监控();
		租约监控取消 = new CancellationTokenSource();
		_ = 租约监控循环(租约监控取消.Token);
	}

	private void 停止租约监控()
	{
		try { 租约监控取消?.Cancel(); } catch { }
		租约监控取消?.Dispose();
		租约监控取消 = null;
	}

	private void 启动状态心跳()
	{
		停止状态心跳();
		状态心跳取消 = new CancellationTokenSource();
		_ = 状态心跳循环(状态心跳取消.Token);
	}

	private void 停止状态心跳()
	{
		try { 状态心跳取消?.Cancel(); } catch { }
		状态心跳取消?.Dispose();
		状态心跳取消 = null;
	}

	private async Task 状态心跳循环(CancellationToken cancellationToken)
	{
		try
		{
			while (!cancellationToken.IsCancellationRequested)
			{
				var ok = await LicenseClient.ReportRuntimeStatusAsync(当前卡密, 当前授权服务器, 最近有效租约);
				Serilog.Log.Debug("授权运行状态心跳{Result}", ok ? "成功" : "失败");
				await Task.Delay(TimeSpan.FromMinutes(5), cancellationToken);
			}
		}
		catch (OperationCanceledException) { }
		catch (Exception ex) { Serilog.Log.Warning(ex, "授权运行状态心跳异常"); }
	}

	private async Task 租约监控循环(CancellationToken cancellationToken)
	{
		try
		{
			while (!cancellationToken.IsCancellationRequested)
			{
				// Keep revocation responsive without adding work to player packet paths.
				await Task.Delay(TimeSpan.FromMinutes(1), cancellationToken);
				var result = await LicenseClient.ValidateAsync(当前卡密, 当前授权服务器);
				if (result.Valid)
				{
					应用授权结果(result);
					if (await 检查并上报篡改(result)) break;
					if (!授权租约有效())
					{
						触发授权失效关闭("授权租约宽限期已结束");
						break;
					}
					continue;
				}
				触发授权失效关闭(result.Message);
				break;
			}
		}
		catch (OperationCanceledException) { }
		catch (Exception ex) { Serilog.Log.Error(ex, "授权租约监控异常"); }
	}

	
	[Rpc(hash = 10004)]
	public void 验证插件返回(bool 是否成功, string 真实IP, string 提示文本, string 到期时间, string 插件类型)
	{
	}

	
	public void 验证存档插件数据()
	{
	}

	
	public void CunDangClientQq(string qq)
	{
	}

	
	public void 续费插件(string 用作续费卡密, Action<bool, string> 当前验证回调 = null)
	{
	}

	
	[Rpc(hash = 10007)]
	public void 续费插件返回(bool 是否成功, string 真实IP, string 提示文本, string 到期时间)
	{
	}

	
	[Rpc(hash = 10016)]
	public void 强制用户下线(bool 是否到期)
	{
	}

	
	[Rpc(hash = 10001)]
	public void 初始连接返回(string value)
	{
	}

	
	[Rpc(hash = 10005)]
	public void 更新用户授权信息(string value)
	{
	}

	
	[Rpc(hash = 10006)]
	public void 更新公告返回(string value)
	{
	}

	
	internal void lgalOjYQbI()
	{
	}

	
	[Rpc(hash = 10087)]
	public void 返回验证QQ(bool IsTrue)
	{
	}

	
	public void 验证断开事件()
	{
	}

	
	public override void Close(bool await = true, int millisecondsTimeout = 100)
	{
		停止租约监控();
		停止状态心跳();
		base.Close(await, millisecondsTimeout);
	}

	static MyGdTcpClient()
	{
	}
}
