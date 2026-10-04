using System.Threading;

internal enum ArchiveSaveResult
{
	Completed,
	Busy,
	Failed
}

internal sealed class ArchiveSaveGate
{
	private int active;

	public bool TryEnter()
	{
		return Interlocked.CompareExchange(ref active, 1, 0) == 0;
	}

	public void Exit()
	{
		Volatile.Write(ref active, 0);
	}

	public bool IsActive => Volatile.Read(ref active) != 0;
}
