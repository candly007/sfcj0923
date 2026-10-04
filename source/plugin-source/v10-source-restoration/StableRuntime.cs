using System;
using System.Threading;
using System.Threading.Tasks;
using Serilog;

/// <summary>
/// 长期运行稳定性辅助。只负责记录异常，不在异常处理器中自行重启进程，
/// 避免数据库/网络状态尚未释放时发生重启风暴。进程级拉起交给外部守护程序。
/// </summary>
public static class StableRuntime
{
    private static int _installed;

    public static void Install()
    {
        if (Interlocked.Exchange(ref _installed, 1) != 0)
            return;

        TaskScheduler.UnobservedTaskException += (_, e) =>
        {
            try
            {
                Log.Error(e.Exception, "[稳定性] 未观察到的 Task 异常");
                e.SetObserved();
            }
            catch { }
        };

        AppDomain.CurrentDomain.UnhandledException += (_, e) =>
        {
            try
            {
                if (e.ExceptionObject is Exception ex)
                    Log.Fatal(ex, "[稳定性] 未处理异常，IsTerminating={IsTerminating}", e.IsTerminating);
                else
                    Log.Fatal("[稳定性] 未处理异常：{ExceptionObject}，IsTerminating={IsTerminating}", e.ExceptionObject, e.IsTerminating);
            }
            catch { }
        };
    }
}
