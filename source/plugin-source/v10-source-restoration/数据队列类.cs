using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

public class 数据队列类
{
	[CompilerGenerated]
	private readonly Channel<byte[]> WMs6xSwTh4;

	[CompilerGenerated]
	private Task? Lgp6H49MHA;

	[CompilerGenerated]
	private CancellationTokenSource? bgT64fVjp1;

	public Channel<byte[]> PacketChannel
	{
		
		[CompilerGenerated]
		get
		{
			return WMs6xSwTh4;
		}
	}

	public Task? ProcessingTask
	{
		
		[CompilerGenerated]
		get
		{
			return Lgp6H49MHA;
		}
		
		[CompilerGenerated]
		set
		{
			Lgp6H49MHA = value;
		}
	}

	public CancellationTokenSource? TokenSource
	{
		
		[CompilerGenerated]
		get
		{
			return bgT64fVjp1;
		}
		
		[CompilerGenerated]
		set
		{
			bgT64fVjp1 = value;
		}
	}

	
	public 数据队列类()
	{
		BoundedChannelOptions options = new BoundedChannelOptions(1000)
		{
			FullMode = BoundedChannelFullMode.Wait
		};
		WMs6xSwTh4 = Channel.CreateBounded<byte[]>(options);
		TokenSource = new CancellationTokenSource();
	}

	static 数据队列类()
	{
	}
}
