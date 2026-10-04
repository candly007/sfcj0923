public class PayConfig
{
	public string Pid { get; set; } = string.Empty;

	public string GatewayUrl { get; set; } = string.Empty;

	public string? Md5Key { get; set; }

	public string? RsaPrivateKey { get; set; }

	public string? RsaPublicKey { get; set; }

	public string SignType { get; set; } = "MD5";
}
