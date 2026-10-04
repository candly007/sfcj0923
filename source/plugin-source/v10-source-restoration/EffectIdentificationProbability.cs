using System;

internal static class EffectIdentificationProbability
{
	internal static bool IsSuccess(int configuredPercent, int roll)
	{
		if (roll < 1 || roll > 100)
		{
			throw new ArgumentOutOfRangeException(nameof(roll), "Probability roll must be between 1 and 100.");
		}
		return roll <= Math.Clamp(configuredPercent, 0, 100);
	}

	internal static void RunSelfTest()
	{
		if (IsSuccess(0, 1) || !IsSuccess(100, 100) || !IsSuccess(30, 30) || IsSuccess(30, 31))
		{
			throw new InvalidOperationException("Effect identification probability boundary test failed.");
		}
		int successes = 0;
		for (int roll = 1; roll <= 100; roll++)
		{
			if (IsSuccess(37, roll))
			{
				successes++;
			}
		}
		if (successes != 37)
		{
			throw new InvalidOperationException("Effect identification probability distribution test failed.");
		}
		Console.WriteLine("EFFECT_IDENTIFICATION_PROBABILITY_SELF_TEST=PASS");
		Console.WriteLine("PERCENT_0_ALWAYS_FAIL=PASS");
		Console.WriteLine("PERCENT_100_ALWAYS_SUCCESS=PASS");
		Console.WriteLine("PERCENT_BOUNDARY_MATRIX=PASS");
	}
}
