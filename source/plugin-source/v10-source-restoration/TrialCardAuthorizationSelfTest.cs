using System;
using System.Collections.Generic;

internal static class TrialCardAuthorizationSelfTest
{
	internal static void Run()
	{
		功能授权类 authorization = new 功能授权类();
		Assert(!authorization.Is测试卡, "固定卡密初始化后不应处于体验卡状态");

		authorization.更新(new List<bool> { true, true });
		Assert(!authorization.Is测试卡, "更新功能授权后不应重新启用体验卡限制");

		Console.WriteLine("FIXED_KEY_TRIAL_CARD_DISABLED_SELF_TEST=PASS");
	}

	private static void Assert(bool condition, string message)
	{
		if (!condition)
		{
			throw new InvalidOperationException(message);
		}
	}
}
