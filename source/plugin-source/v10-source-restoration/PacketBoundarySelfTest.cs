using System;

internal static class PacketBoundarySelfTest
{
	internal static void Run()
	{
		byte[] valid = new byte[12];
		valid[0] = 77;
		valid[1] = 90;
		valid[8] = 0;
		valid[9] = 2;
		if (!MyFixedHeaderRequestInfo.IsValidFrame(valid))
		{
			throw new InvalidOperationException("valid empty frame was rejected");
		}

		byte[] invalidLength = (byte[])valid.Clone();
		invalidLength[9] = 1;
		if (MyFixedHeaderRequestInfo.IsValidFrame(invalidLength))
		{
			throw new InvalidOperationException("short declared length was accepted");
		}

		byte[] truncated = new byte[11];
		if (MyFixedHeaderRequestInfo.IsValidFrame(truncated))
		{
			throw new InvalidOperationException("truncated frame was accepted");
		}

		byte[] mismatched = (byte[])valid.Clone();
		mismatched[9] = 4;
		if (MyFixedHeaderRequestInfo.IsValidFrame(mismatched))
		{
			throw new InvalidOperationException("mismatched frame length was accepted");
		}

		Console.WriteLine("PACKET_BOUNDARY_SELF_TEST=PASS");
	}
}
