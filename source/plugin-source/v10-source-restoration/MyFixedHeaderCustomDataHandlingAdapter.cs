using System.Runtime.CompilerServices;
using TouchSocket.Core;

public class MyFixedHeaderCustomDataHandlingAdapter : CustomFixedHeaderDataHandlingAdapter<MyFixedHeaderRequestInfo>
{
	public override int HeaderLength
	{
		
		get
		{
			return 12;
		}
	}

	public override bool CanSendRequestInfo
	{
		
		get
		{
			return false;
		}
	}

	
	protected override MyFixedHeaderRequestInfo GetInstance()
	{
		return new MyFixedHeaderRequestInfo();
	}

	
	public MyFixedHeaderCustomDataHandlingAdapter()
	{
	}

	static MyFixedHeaderCustomDataHandlingAdapter()
	{
	}
}
