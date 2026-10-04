using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace NetClientFrom;

internal static class Program
{
	public static bool Istiaoshi;

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern int GetSystemFirmwareTable(uint firmwareTableProviderSignature, uint firmwareTableID, IntPtr pFirmwareTableBuffer, int bufferSize);

	[STAThread]
	private static void Main()
	{
		Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
		Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
		Application.ThreadException += static (_, args) =>
		{
			try
			{
				File.WriteAllText("startup-exception.txt", args.Exception.ToString());
			}
			catch
			{
			}
		};
		Istiaoshi = Enumerable.Contains(Environment.GetCommandLineArgs(), "--vs-run");
		if (!Istiaoshi && Debugger.IsAttached)
		{
			Environment.Exit(1);
			return;
		}
		Singleton<全局变量类>.I.Config读取();
		全局变量类.初始化O路径();
		Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		if (Enumerable.Contains(Environment.GetCommandLineArgs(), "--feature-page-layout-self-test"))
		{
			using 后台主页界面 form = new 后台主页界面();
			Environment.ExitCode = form.RunFeaturePageLayoutSelfTest() ? 0 : 1;
			return;
		}
		Application.Run(new 后台主页界面());
	}
}
