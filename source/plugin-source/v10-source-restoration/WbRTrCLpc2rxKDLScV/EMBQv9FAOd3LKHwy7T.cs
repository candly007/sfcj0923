using System;
using System.IO;
using System.Runtime.CompilerServices;
using GJSyJYUDOfxE331QwT1;
using Serilog;

namespace WbRTrCLpc2rxKDLScV;

internal class EMBQv9FAOd3LKHwy7T : Singleton<EMBQv9FAOd3LKHwy7T>
{
	
	internal void y0ZSs00Eg(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(13L, SeekOrigin.Begin);
			string text = obj.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			if (string.IsNullOrWhiteSpace(text) || text == "0")
			{
				P_0.user.缓存数据.cdk类型 = AllEnums.CdkType.无;
				return;
			}
			switch (P_0.user.缓存数据.cdk类型)
			{
			case AllEnums.CdkType.推荐:
				Singleton<EfHAVFUgqrnaj1QwnLW>.I.G5VUBpw0Mx(P_0, text);
				break;
			}
			P_0.user.缓存数据.cdk类型 = AllEnums.CdkType.无;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("输入框提交事件处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void ANFcKGBuL(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_0.user.缓存数据.上次请求兑换时间 != DateTime.MinValue && (DateTime.Now - P_0.user.缓存数据.上次请求兑换时间).TotalMilliseconds < 3000.0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的速度太快了,请稍后再试！"));
				return;
			}
			P_0.user.缓存数据.上次请求兑换时间 = DateTime.Now;
			DB.I.wmMNqYIGuE(P_0, P_1);
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("CDK兑换事件处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public EMBQv9FAOd3LKHwy7T()
	{
	}

	static EMBQv9FAOd3LKHwy7T()
	{
	}
}
