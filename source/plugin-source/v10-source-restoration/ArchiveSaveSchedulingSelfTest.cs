using System;

internal static class ArchiveSaveSchedulingSelfTest
{
	public static void Run()
	{
		ArchiveSaveGate gate = new ArchiveSaveGate();
		if (!gate.TryEnter())
		{
			throw new InvalidOperationException("首次进入全量存档门失败");
		}
		if (gate.TryEnter())
		{
			throw new InvalidOperationException("全量存档门允许重叠任务");
		}
		gate.Exit();
		if (!gate.TryEnter())
		{
			throw new InvalidOperationException("全量存档门释放后无法重新进入");
		}
		gate.Exit();
		Console.WriteLine("ARCHIVE_SAVE_SCHEDULING_SELF_TEST=PASS");
	}
}
