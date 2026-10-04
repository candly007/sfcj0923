using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

/// <summary>
/// Low-frequency integrity evidence for the control plane. It never runs on a
/// player packet path: startup performs one SHA-256 pass, metadata is checked
/// every five minutes, and a full rehash is limited to once per hour.
/// </summary>
[Obfuscation(Exclude = false, ApplyToMembers = true)]
internal static class IntegrityGuard
{
	private static readonly object Sync = new();
	private static string executablePath = string.Empty;
	private static string initialHash = string.Empty;
	private static long initialLength;
	private static DateTime initialWriteTimeUtc;
	private static DateTimeOffset nextMetadataCheck;
	private static DateTimeOffset nextFullHashCheck;

	public static bool TryGetBinaryHash(out string hash, out string reason)
	{
		lock (Sync)
		{
			if (initialHash.Length == 64)
			{
				hash = initialHash;
				reason = string.Empty;
				return true;
			}
			try
			{
				executablePath = ResolveExecutablePath();
				var info = new FileInfo(executablePath);
				if (!info.Exists) throw new FileNotFoundException();
				initialHash = ComputeHash(executablePath);
				initialLength = info.Length;
				initialWriteTimeUtc = info.LastWriteTimeUtc;
				nextMetadataCheck = DateTimeOffset.UtcNow.AddMinutes(5);
				nextFullHashCheck = DateTimeOffset.UtcNow.AddHours(1);
				hash = initialHash;
				reason = string.Empty;
				return true;
			}
			catch
			{
				hash = string.Empty;
				reason = "binary_integrity_unavailable";
				return false;
			}
		}
	}

	public static bool TryGetHighConfidenceReason(out string reason)
	{
		if (!BuildIdentity.IsAuthentic())
		{
			reason = "release_signature_invalid";
			return true;
		}
		if (!TryGetBinaryHash(out _, out reason)) return true;
		lock (Sync)
		{
			var now = DateTimeOffset.UtcNow;
			if (now < nextMetadataCheck)
			{
				reason = string.Empty;
				return false;
			}
			nextMetadataCheck = now.AddMinutes(5);
			try
			{
				var info = new FileInfo(executablePath);
				info.Refresh();
				if (!info.Exists || info.Length != initialLength || info.LastWriteTimeUtc != initialWriteTimeUtc)
				{
					reason = "binary_metadata_changed";
					return true;
				}
				if (now >= nextFullHashCheck)
				{
					nextFullHashCheck = now.AddHours(1);
					if (!CryptographicOperations.FixedTimeEquals(
						Convert.FromHexString(initialHash), Convert.FromHexString(ComputeHash(executablePath))))
					{
						reason = "binary_hash_mismatch";
						return true;
					}
				}
			}
			catch
			{
				reason = "binary_integrity_unavailable";
				return true;
			}
			reason = string.Empty;
			return false;
		}
	}

	private static string ResolveExecutablePath()
	{
		var assemblyPath = Assembly.GetExecutingAssembly().Location;
		if (!string.IsNullOrWhiteSpace(assemblyPath) && File.Exists(assemblyPath)) return assemblyPath;
		return Environment.ProcessPath ?? throw new FileNotFoundException();
	}

	private static string ComputeHash(string path)
	{
		using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete, 1024 * 1024,
			FileOptions.SequentialScan);
		using var sha256 = SHA256.Create();
		return Convert.ToHexString(sha256.ComputeHash(stream));
	}
}
