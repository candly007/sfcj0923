using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

public class AsyncFileWriter : IDisposable
{
	private readonly BlockingCollection<string> oud8dHqVq;

	private readonly string va9IUh6Es;

	private readonly int UyhoYNUG3;

	private bool qr0NVccmZ;

	
	public AsyncFileWriter(string filePath, int bufferSize = 1000)
	{
		oud8dHqVq = new BlockingCollection<string>();
		va9IUh6Es = filePath;
		UyhoYNUG3 = bufferSize;
		gBsl9uoJG();
	}

	
	public void WriteLine(string line)
	{
		if (!qr0NVccmZ)
		{
			oud8dHqVq.Add(line);
		}
	}

	
	private async Task gBsl9uoJG()
	{
		using FileStream fs = new FileStream(va9IUh6Es, FileMode.Append, FileAccess.Write, FileShare.Read, 4096, FileOptions.WriteThrough);
		using StreamWriter writer = new StreamWriter(fs);
		List<string> buffer = new List<string>(UyhoYNUG3);
		while (!oud8dHqVq.IsCompleted)
		{
			try
			{
				string item = oud8dHqVq.Take();
				buffer.Add(item);
				if (buffer.Count >= UyhoYNUG3 || oud8dHqVq.Count == 0)
				{
					await writer.WriteAsync(string.Join(Environment.NewLine, buffer));
					await writer.FlushAsync();
					buffer.Clear();
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		if (buffer.Count > 0)
		{
			await writer.WriteAsync(string.Join(Environment.NewLine, buffer));
			await writer.FlushAsync();
		}
	}

	
	public void Dispose()
	{
		if (!qr0NVccmZ)
		{
			qr0NVccmZ = true;
			oud8dHqVq.CompleteAdding();
			oud8dHqVq.Dispose();
		}
	}

	static AsyncFileWriter()
	{
	}
}
