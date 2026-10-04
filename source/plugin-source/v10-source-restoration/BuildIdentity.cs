using System;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Signed release identity. The sequence is monotonic and is checked by the
/// license service before a lease is issued, which blocks old-build rollback.
/// </summary>
[System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true)]
internal static class BuildIdentity
{
	public const string BuildId = "sf-20260824-card-gate";
	public const long BuildSequence = 2026082401;
	public const string CustomerId = "standard";
	public const string Signature = "Q9B2f9eZh1SJXaEKwwNN3YT0iu2PZogcOyMiCKcFVMONSlDi1ijYrBbnfYTGjPoxPK9mn9ik3zO2vGLAFeNfLw==";
	private const string ReleasePublicKeyPem = "-----BEGIN PUBLIC KEY-----\nMFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAElhoxom4B20JEQT9OwvoTjIjndvHt\nv2BpR8JpS0cCVudLdkNXkWZjnZM/awbzAyFog3W8zthUQcCb32k6XNOaNA==\n-----END PUBLIC KEY-----";

	public static byte[] CanonicalBytes() => Encoding.UTF8.GetBytes(string.Join("|", BuildId, BuildSequence, CustomerId));

	public static bool IsAuthentic()
	{
		try
		{
			using var verifier = ECDsa.Create();
			verifier.ImportFromPem(ReleasePublicKeyPem);
			return verifier.VerifyData(CanonicalBytes(), Convert.FromBase64String(Signature), HashAlgorithmName.SHA256);
		}
		catch { return false; }
	}
}
