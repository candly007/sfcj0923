using System.Runtime.CompilerServices;
using TouchSocket.Core;

public class WdMyFixedHeaderCustomDataHandlingAdapter : CustomFixedHeaderDataHandlingAdapter<WdMyFixedHeaderRequestInfo>
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

	
	protected override WdMyFixedHeaderRequestInfo GetInstance()
	{
		return new WdMyFixedHeaderRequestInfo();
	}

	
	public WdMyFixedHeaderCustomDataHandlingAdapter()
	{
	}

	static WdMyFixedHeaderCustomDataHandlingAdapter()
	{
	}
}
