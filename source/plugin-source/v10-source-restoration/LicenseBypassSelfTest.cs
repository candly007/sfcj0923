using System;

internal static class LicenseBypassSelfTest
{
    internal static void Run()
    {
        var client = new MyGdTcpClient();
        Assert(!client.是否成功, "授权客户端必须在验证前保持失败状态");
        Assert(!全局变量类.Is调试, "生产默认调试门必须关闭");
        Console.WriteLine("LICENSE_BYPASS_GATES_SELF_TEST=PASS");
    }

    private static void Assert(bool condition, string message)
    {
        if (!condition) throw new InvalidOperationException(message);
    }
}
