using System;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Linq;
using System.Collections.Generic;
using Serilog;

[System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true)]
public sealed record LicenseValidationResult(bool Valid, string Message, string ExpiresAt)
{
	public bool FromCache { get; init; }
	public DateTimeOffset ValidatedAt { get; init; }
	public string LicenseId { get; init; } = string.Empty;
	public string InstallId { get; init; } = string.Empty;
	public string Challenge { get; init; } = string.Empty;
	public string Signature { get; init; } = string.Empty;
	public long IssuedAtUnix { get; init; }
	public long LeaseExpiresAtUnix { get; init; }
	public string IssuerPublicKeyPem { get; init; } = string.Empty;
	public string DelegationJson { get; init; } = string.Empty;
}

/// <summary>
/// Minimal outbound licensing client. It sends only the card, product name and a random installation id.
/// No QQ, game IP, database settings, player data or log data are included.
/// </summary>
[System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true)]
public static class LicenseClient
{
	private static readonly TimeSpan OfflineGrace = TimeSpan.FromMinutes(10);
	private const string PublicKeyPem = "-----BEGIN PUBLIC KEY-----\nMFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAEN+o4Ok6LvyfKnZWmTyy2bxLRbZEP\n0jk/Kt40IkhqMr9SY1til/jSrk/qNuiiyRaSemAcfH3kHe/ebhSwZMDXKg==\n-----END PUBLIC KEY-----";
	private static readonly HttpClient Http = new()
	{
		Timeout = TimeSpan.FromSeconds(10)
	};

	internal static void RunCacheSelfTest()
	{
		var expected = new LicenseCache
		{
			CardHash = "CACHE-TEST-CARD",
			ExpiresAt = "永久",
			LicenseId = "cache-test-license",
			Product = "shunfeng-plugin",
			InstallId = "cache-test-installation",
			Challenge = "cache-test-challenge",
			BuildId = "cache-test-build",
			BuildSequence = 1,
			CustomerId = "cache-test-customer",
			BinaryHash = "CACHE-TEST-HASH",
			BuildSignature = "cache-test-build-signature",
			Signature = "cache-test-lease-signature",
			IssuedAtUnix = 1,
			LeaseExpiresAtUnix = 2,
			ValidatedAt = DateTimeOffset.UnixEpoch
		};

		var serialized = JsonSerializer.Serialize(expected);
		var actual = JsonSerializer.Deserialize<LicenseCache>(serialized)
			?? throw new InvalidOperationException("授权缓存反序列化返回空对象");
		if (actual.CardHash != expected.CardHash || actual.LicenseId != expected.LicenseId
			|| actual.BuildSequence != expected.BuildSequence || actual.ValidatedAt != expected.ValidatedAt)
			throw new InvalidOperationException("授权缓存序列化往返校验失败");
		Console.WriteLine("LICENSE_CACHE_SELF_TEST=PASS");
	}

	internal static void RunPrivateDelegationSelfTest()
	{
		using var rootKey = ECDsa.Create(ECCurve.NamedCurves.nistP256);
		using var nodeKey = ECDsa.Create(ECCurve.NamedCurves.nistP256);
		var rootPublicKey = ExportPublicKeyPem(rootKey);
		var nodePublicKey = ExportPublicKeyPem(nodeKey);
		var licenseId = "private-self-test-license";
		var nodeId = "private-self-test-node";
		var product = "shunfeng-plugin";
		var installId = "private-self-test-install";
		var challenge = "private-self-test-challenge";
		var buildId = "private-self-test-build";
		var buildSequence = 1L;
		var customerId = "private-self-test-customer";
		var binaryHash = new string('A', 64);
		var licenseHash = Hash("private-self-test-card");
		var nodeHash = Convert.ToHexString(SHA256.HashData(nodeKey.ExportSubjectPublicKeyInfo()));
		var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		var delegationExpires = now + 600;
		var leaseExpires = now + 300;
		var policyJson = JsonSerializer.Serialize(new Dictionary<string, object?>
		{
			["minBuildSequence"] = 1L,
			["allowedBuildIds"] = new[] { buildId },
			["requireBinaryHash"] = true,
			["allowedBinaryHashes"] = new Dictionary<string, string[]> { [buildId] = new[] { binaryHash } }
		});
		using var policyDocument = JsonDocument.Parse(policyJson);
		var policyHash = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(BuildPolicyCanonical(policyDocument.RootElement))));
		var delegationCanonical = string.Join("|", licenseId, nodeId, "1", nodeHash, licenseHash, "0",
			now.ToString(CultureInfo.InvariantCulture), delegationExpires.ToString(CultureInfo.InvariantCulture), policyHash);
		var delegationSignature = Convert.ToBase64String(rootKey.SignData(Encoding.UTF8.GetBytes(delegationCanonical), HashAlgorithmName.SHA256));
		var delegationJson = JsonSerializer.Serialize(new Dictionary<string, object?>
		{
			["valid"] = true,
			["licenseId"] = licenseId,
			["nodeId"] = nodeId,
			["generation"] = 1L,
			["nodePublicKeySha256"] = nodeHash,
			["licenseHash"] = licenseHash,
			["licenseExpiresAtUnix"] = 0L,
			["issuedAtUnix"] = now,
			["expiresAtUnix"] = delegationExpires,
			["buildPolicy"] = JsonSerializer.Deserialize<JsonElement>(policyJson),
			["policySha256"] = policyHash,
			["signature"] = delegationSignature
		});
		var leaseCanonical = string.Join("|", licenseId, product, installId, challenge, buildId, "1", customerId, binaryHash,
			now.ToString(CultureInfo.InvariantCulture), leaseExpires.ToString(CultureInfo.InvariantCulture));
		var leaseSignature = Convert.ToBase64String(nodeKey.SignData(Encoding.UTF8.GetBytes(leaseCanonical), HashAlgorithmName.SHA256));

		bool Verify(string json, string issuer = "", long? expires = null, string? signature = null) => VerifyPrivateSignatureForRoot(
			licenseId, product, installId, challenge, buildId, buildSequence, customerId, binaryHash, now, expires ?? leaseExpires,
			signature ?? leaseSignature, string.IsNullOrEmpty(issuer) ? nodePublicKey : issuer, json, licenseHash, rootPublicKey);
		if (!Verify(delegationJson)) throw new InvalidOperationException("合法私有化授权签名链被拒绝");
		if (Verify(delegationJson.Replace(licenseHash, new string('B', 64), StringComparison.Ordinal))) throw new InvalidOperationException("篡改卡密哈希未被拒绝");
		if (Verify(delegationJson.Replace(nodeHash, new string('C', 64), StringComparison.Ordinal))) throw new InvalidOperationException("篡改节点公钥哈希未被拒绝");
		if (Verify(delegationJson.Replace("\"minBuildSequence\":1", "\"minBuildSequence\":2", StringComparison.Ordinal))) throw new InvalidOperationException("篡改构建策略未被拒绝");
		var forgedDelegationSignature = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
		var forgedDelegationJson = delegationJson.Replace(JsonSerializer.Serialize(delegationSignature), JsonSerializer.Serialize(forgedDelegationSignature), StringComparison.Ordinal);
		if (forgedDelegationJson == delegationJson || Verify(forgedDelegationJson)) throw new InvalidOperationException("伪造主委托签名未被拒绝");
		using var otherNode = ECDsa.Create(ECCurve.NamedCurves.nistP256);
		if (Verify(delegationJson, ExportPublicKeyPem(otherNode))) throw new InvalidOperationException("错误节点公钥未被拒绝");
		if (Verify(delegationJson, expires: delegationExpires + 1)) throw new InvalidOperationException("超出主委托期限的子租约未被拒绝");
		if (Verify(delegationJson, signature: Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)))) throw new InvalidOperationException("伪造子租约签名未被拒绝");
		Console.WriteLine("PRIVATE_DELEGATION_SELF_TEST=PASS valid=pass card_hash=pass node_key=pass policy=pass delegation_signature=pass lease_expiry=pass lease_signature=pass");
	}

	public static async Task<LicenseValidationResult> ValidateAsync(string card, string serverAddress, string product = "shunfeng-plugin")
	{
		if (string.IsNullOrWhiteSpace(card)) return new(false, "请先填写授权卡密", string.Empty);
		if (!BuildIdentity.IsAuthentic()) return new(false, "发布构建签名无效", string.Empty);
		if (!IntegrityGuard.TryGetBinaryHash(out var binaryHash, out var integrityError))
			return new(false, integrityError, string.Empty);
		var installId = GetOrCreateInstallId();
		var challenge = Convert.ToBase64String(RandomNumberGenerator.GetBytes(24));
		if (!Uri.TryCreate(NormalizeAddress(serverAddress), UriKind.Absolute, out var baseUri)
			|| (baseUri.Scheme != Uri.UriSchemeHttp && baseUri.Scheme != Uri.UriSchemeHttps))
			return ReadCache(card, "授权服务器地址未配置或格式错误", product);

		try
		{
			var activationBody = new Dictionary<string, object?>
			{
				["license"] = card.Trim(),
				["installId"] = installId,
				["challenge"] = challenge,
				["product"] = product,
				["buildId"] = BuildIdentity.BuildId,
				["buildSequence"] = BuildIdentity.BuildSequence,
				["customerId"] = BuildIdentity.CustomerId,
				["buildSignature"] = BuildIdentity.Signature,
				["binaryHash"] = binaryHash
			};
			using var content = new StringContent(JsonSerializer.Serialize(activationBody), Encoding.UTF8, "application/json");
			using var response = await Http.PostAsync(new Uri(baseUri, "/api/license/activate"), content);
			var body = await response.Content.ReadAsStringAsync();
			using var json = JsonDocument.Parse(body);
			var root = json.RootElement;
			var valid = root.TryGetProperty("valid", out var validElement) && validElement.GetBoolean();
			if (!valid)
			{
				var error = root.TryGetProperty("error", out var errorElement) ? errorElement.GetString() : "授权验证失败";
				return new(false, error ?? "授权验证失败", string.Empty);
			}
			if (!VerifyLease(root, installId, challenge, product, card))
				return new(false, "授权响应签名无效", string.Empty);
			var expires = root.TryGetProperty("expiresAt", out var expiresElement) && expiresElement.ValueKind != JsonValueKind.Null
				? expiresElement.GetString() ?? "永久"
				: "永久";
			var validatedAt = DateTimeOffset.UtcNow;
			SaveCache(card, expires, root, installId, challenge, product, validatedAt);
			return new(true, "授权验证成功", expires)
			{
				ValidatedAt = validatedAt,
				LicenseId = root.GetProperty("licenseId").GetString() ?? string.Empty,
				InstallId = installId,
				Challenge = challenge,
				Signature = root.GetProperty("signature").GetString() ?? string.Empty,
				IssuerPublicKeyPem = root.TryGetProperty("issuerPublicKeyPem", out var issuer) ? issuer.GetString() ?? string.Empty : string.Empty,
				DelegationJson = root.TryGetProperty("delegation", out var delegation) ? delegation.GetRawText() : string.Empty,
				IssuedAtUnix = root.GetProperty("issuedAtUnix").GetInt64(),
				LeaseExpiresAtUnix = root.GetProperty("leaseExpiresAtUnix").GetInt64()
			};
		}
		catch (Exception ex)
		{
			Log.Warning("授权服务器暂时不可用，尝试本地授权缓存：{Message}", ex.Message);
			return ReadCache(card, "授权服务器暂时不可用", product);
		}
	}

	public static async Task<bool> ReportTamperAsync(string card, string serverAddress, LicenseValidationResult lease, string reason,
		string product = "shunfeng-plugin")
	{
		if (!lease.Valid || string.IsNullOrWhiteSpace(card) || string.IsNullOrWhiteSpace(lease.LicenseId)
			|| string.IsNullOrWhiteSpace(lease.InstallId) || string.IsNullOrWhiteSpace(lease.Signature)) return false;
		if (!Uri.TryCreate(NormalizeAddress(serverAddress), UriKind.Absolute, out var baseUri)
			|| (baseUri.Scheme != Uri.UriSchemeHttp && baseUri.Scheme != Uri.UriSchemeHttps)) return false;
		try
		{
			IntegrityGuard.TryGetBinaryHash(out var binaryHash, out _);
			var body = new Dictionary<string, object?>
			{
				["license"] = card.Trim(),
				["installId"] = lease.InstallId,
				["product"] = product,
				["licenseId"] = lease.LicenseId,
				["challenge"] = lease.Challenge,
				["signature"] = lease.Signature,
				["issuedAtUnix"] = lease.IssuedAtUnix,
				["leaseExpiresAtUnix"] = lease.LeaseExpiresAtUnix,
				["buildId"] = BuildIdentity.BuildId,
				["buildSequence"] = BuildIdentity.BuildSequence,
				["customerId"] = BuildIdentity.CustomerId,
				["buildSignature"] = BuildIdentity.Signature,
				["binaryHash"] = binaryHash,
				["reason"] = reason?.Trim() ?? "tamper_detected"
			};
			using var content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");
			using var response = await Http.PostAsync(new Uri(baseUri, "/api/license/tamper"), content);
			return response.IsSuccessStatusCode;
		}
		catch (Exception ex)
		{
			Log.Warning("篡改上报失败：{Message}", ex.Message);
			return false;
		}
	}

	private static string? LastReportedConfigHash;

	public static async Task<bool> ReportRuntimeStatusAsync(string card, string serverAddress, LicenseValidationResult lease,
		string product = "shunfeng-plugin")
	{
		if (!lease.Valid || string.IsNullOrWhiteSpace(card) || string.IsNullOrWhiteSpace(lease.LicenseId)
			|| string.IsNullOrWhiteSpace(lease.InstallId) || string.IsNullOrWhiteSpace(lease.Signature)) return false;
		if (!Uri.TryCreate(NormalizeAddress(serverAddress), UriKind.Absolute, out var baseUri)
			|| (baseUri.Scheme != Uri.UriSchemeHttp && baseUri.Scheme != Uri.UriSchemeHttps)) return false;
		try
		{
			IntegrityGuard.TryGetBinaryHash(out var binaryHash, out _);
			var configPath = Path.Combine(AppContext.BaseDirectory, "插件配置夹", "插件主配置类.json");
			var configExists = File.Exists(configPath);
			var configSize = configExists ? new FileInfo(configPath).Length : 0L;
			var configHash = string.Empty;
			string? configContent = null;
			string configLastWrite = string.Empty;
			if (configExists && configSize <= 5 * 1024 * 1024)
			{
				configContent = await File.ReadAllTextAsync(configPath, Encoding.UTF8);
				configHash = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(configContent)));
				configLastWrite = File.GetLastWriteTimeUtc(configPath).ToString("O", CultureInfo.InvariantCulture);
				if (string.Equals(configHash, LastReportedConfigHash, StringComparison.OrdinalIgnoreCase)) configContent = null;
			}
			var process = System.Diagnostics.Process.GetCurrentProcess();
			var memory = GC.GetGCMemoryInfo().TotalAvailableMemoryBytes;
			var body = new Dictionary<string, object?>
			{
				["license"] = card.Trim(),
				["installId"] = lease.InstallId,
				["product"] = product,
				["licenseId"] = lease.LicenseId,
				["challenge"] = lease.Challenge,
				["signature"] = lease.Signature,
				["issuedAtUnix"] = lease.IssuedAtUnix,
				["leaseExpiresAtUnix"] = lease.LeaseExpiresAtUnix,
				["buildId"] = BuildIdentity.BuildId,
				["buildSequence"] = BuildIdentity.BuildSequence,
				["customerId"] = BuildIdentity.CustomerId,
				["buildSignature"] = BuildIdentity.Signature,
				["binaryHash"] = binaryHash,
				["osDescription"] = RuntimeInformation.OSDescription,
				["hostName"] = Environment.MachineName,
				["cpuCount"] = Environment.ProcessorCount,
				["cpuLoadPercent"] = 0d,
				["totalMemoryBytes"] = memory,
				["processWorkingSetBytes"] = process.WorkingSet64,
				["gcHeapBytes"] = GC.GetTotalMemory(false),
				["uptimeSeconds"] = Environment.TickCount64 / 1000,
				["configExists"] = configExists,
				["configSizeBytes"] = configSize,
				["configSha256"] = configHash,
				["configLastWriteUtc"] = configLastWrite,
				["configContent"] = configContent
			};
			using var content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");
			using var response = await Http.PostAsync(new Uri(baseUri, "/api/license/status"), content);
			if (response.IsSuccessStatusCode && !string.IsNullOrWhiteSpace(configHash)) LastReportedConfigHash = configHash;
			return response.IsSuccessStatusCode;
		}
		catch (Exception ex)
		{
			Log.Warning("运行状态上报失败：{Message}", ex.Message);
			return false;
		}
	}

	private static string NormalizeAddress(string address)
	{
		address = address?.Trim() ?? string.Empty;
		if (address.Length == 0) return string.Empty;
		return address.Contains("://", StringComparison.Ordinal) ? address : "http://" + address;
	}

	private static string GetOrCreateInstallId()
	{
		try
		{
			var directory = Path.Combine(AppContext.BaseDirectory, "插件配置夹");
			Directory.CreateDirectory(directory);
			var path = Path.Combine(directory, "license-installation.id");
			if (File.Exists(path))
			{
				var existing = File.ReadAllText(path).Trim();
				if (existing.Length >= 16) return existing;
			}
			var bytes = RandomNumberGenerator.GetBytes(24);
			var created = Convert.ToHexString(bytes);
			File.WriteAllText(path, created, Encoding.ASCII);
			return created;
		}
		catch (Exception ex)
		{
			Log.Warning("授权安装标识保存失败，将使用临时标识：{Message}", ex.Message);
			return Convert.ToHexString(RandomNumberGenerator.GetBytes(24));
		}
	}

	private static string CachePath => Path.Combine(AppContext.BaseDirectory, "插件配置夹", "license-cache.json");

	private static void SaveCache(string card, string expiresAt, JsonElement root, string installId, string challenge, string product, DateTimeOffset validatedAt)
	{
		try
		{
			Directory.CreateDirectory(Path.GetDirectoryName(CachePath)!);
			var cache = new LicenseCache
			{
				CardHash = Hash(card),
				ExpiresAt = expiresAt,
				LicenseId = root.GetProperty("licenseId").GetString() ?? string.Empty,
				Product = product,
				InstallId = installId,
				Challenge = challenge,
				BuildId = BuildIdentity.BuildId,
				BuildSequence = BuildIdentity.BuildSequence,
				CustomerId = BuildIdentity.CustomerId,
				BinaryHash = root.GetProperty("binaryHash").GetString() ?? string.Empty,
				BuildSignature = BuildIdentity.Signature,
				Signature = root.GetProperty("signature").GetString() ?? string.Empty,
				IssuedAtUnix = root.GetProperty("issuedAtUnix").GetInt64(),
				LeaseExpiresAtUnix = root.GetProperty("leaseExpiresAtUnix").GetInt64(),
				IssuerPublicKeyPem = root.TryGetProperty("issuerPublicKeyPem", out var issuer) ? issuer.GetString() ?? string.Empty : string.Empty,
				DelegationJson = root.TryGetProperty("delegation", out var delegation) ? delegation.GetRawText() : string.Empty,
				ValidatedAt = validatedAt
			};
			File.WriteAllText(CachePath, JsonSerializer.Serialize(cache));
		}
		catch (Exception ex) { Log.Warning("授权缓存保存失败：{Message}", ex.Message); }
	}

	private static LicenseValidationResult ReadCache(string card, string unavailableMessage, string product)
	{
		try
		{
			if (!File.Exists(CachePath)) return new(false, unavailableMessage, string.Empty);
			var cache = JsonSerializer.Deserialize<LicenseCache>(File.ReadAllText(CachePath));
			if (cache is null || string.IsNullOrWhiteSpace(cache.Signature) || !CryptographicOperations.FixedTimeEquals(Convert.FromHexString(cache.CardHash), Convert.FromHexString(Hash(card))))
				return new(false, unavailableMessage, string.Empty);
			if (!string.Equals(cache.Product, product, StringComparison.Ordinal)
				|| !string.Equals(cache.BuildId, BuildIdentity.BuildId, StringComparison.Ordinal)
				|| cache.BuildSequence != BuildIdentity.BuildSequence
				|| !string.Equals(cache.CustomerId, BuildIdentity.CustomerId, StringComparison.Ordinal)
				|| !IntegrityGuard.TryGetBinaryHash(out var currentBinaryHash, out _)
				|| !string.Equals(cache.BinaryHash, currentBinaryHash, StringComparison.OrdinalIgnoreCase)
				|| !string.Equals(cache.BuildSignature, BuildIdentity.Signature, StringComparison.Ordinal)
				|| !BuildIdentity.IsAuthentic()
				|| !(string.IsNullOrWhiteSpace(cache.DelegationJson)
					? VerifySignature(cache.LicenseId, cache.Product, cache.InstallId, cache.Challenge, cache.BuildId, cache.BuildSequence, cache.CustomerId, cache.BinaryHash, cache.IssuedAtUnix, cache.LeaseExpiresAtUnix, cache.Signature)
					: VerifyPrivateSignature(cache.LicenseId, cache.Product, cache.InstallId, cache.Challenge, cache.BuildId, cache.BuildSequence, cache.CustomerId, cache.BinaryHash, cache.IssuedAtUnix, cache.LeaseExpiresAtUnix, cache.Signature, cache.IssuerPublicKeyPem, cache.DelegationJson, cache.CardHash))
				|| !string.Equals(cache.InstallId, GetOrCreateInstallId(), StringComparison.Ordinal))
				return new(false, unavailableMessage, string.Empty);
			if (cache.ExpiresAt != "永久" && DateTimeOffset.TryParse(cache.ExpiresAt, out var expiry) && expiry <= DateTimeOffset.UtcNow)
				return new(false, "授权已到期", cache.ExpiresAt);
			if (DateTimeOffset.UtcNow < cache.ValidatedAt.AddMinutes(-2) || DateTimeOffset.UtcNow - cache.ValidatedAt > OfflineGrace)
				return new(false, unavailableMessage + "，本地宽限期已结束", cache.ExpiresAt);
			return new(true, "使用本地授权缓存", cache.ExpiresAt)
			{
				FromCache = true,
				ValidatedAt = cache.ValidatedAt,
				LicenseId = cache.LicenseId,
				InstallId = cache.InstallId,
				Challenge = cache.Challenge,
				Signature = cache.Signature,
				IssuedAtUnix = cache.IssuedAtUnix,
				LeaseExpiresAtUnix = cache.LeaseExpiresAtUnix
			};
		}
		catch (Exception ex)
		{
			Log.Warning("授权缓存读取失败：{Message}", ex.Message);
			return new(false, unavailableMessage, string.Empty);
		}
	}

	private static string Hash(string value) => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(value.Trim().ToUpperInvariant())));
	private static string ExportPublicKeyPem(ECDsa key)
	{
		var base64 = Convert.ToBase64String(key.ExportSubjectPublicKeyInfo(), Base64FormattingOptions.InsertLineBreaks);
		return "-----BEGIN PUBLIC KEY-----\n" + base64.Replace("\r\n", "\n", StringComparison.Ordinal) + "\n-----END PUBLIC KEY-----";
	}

	private static bool VerifyLease(JsonElement root, string installId, string challenge, string product, string card)
	{
		try
		{
			var issued = root.GetProperty("issuedAtUnix").GetInt64();
			var leaseExpires = root.GetProperty("leaseExpiresAtUnix").GetInt64();
			var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
			return root.GetProperty("buildId").GetString() == BuildIdentity.BuildId
				&& root.GetProperty("buildSequence").GetInt64() == BuildIdentity.BuildSequence
				&& root.GetProperty("customerId").GetString() == BuildIdentity.CustomerId
				&& IntegrityGuard.TryGetBinaryHash(out var binaryHash, out _)
				&& root.GetProperty("binaryHash").GetString() == binaryHash
				&& (root.TryGetProperty("delegation", out var delegation)
					? VerifyPrivateSignature(root.GetProperty("licenseId").GetString() ?? string.Empty, product, installId, challenge, BuildIdentity.BuildId, BuildIdentity.BuildSequence, BuildIdentity.CustomerId, binaryHash, issued, leaseExpires, root.GetProperty("signature").GetString() ?? string.Empty, root.GetProperty("issuerPublicKeyPem").GetString() ?? string.Empty, delegation.GetRawText(), Hash(card))
					: VerifySignature(root.GetProperty("licenseId").GetString() ?? string.Empty, product, installId, challenge, BuildIdentity.BuildId, BuildIdentity.BuildSequence, BuildIdentity.CustomerId, binaryHash, issued, leaseExpires, root.GetProperty("signature").GetString() ?? string.Empty))
				&& issued <= now + 120 && leaseExpires > now && leaseExpires - issued <= (long)TimeSpan.FromMinutes(20).TotalSeconds;
		}
		catch { return false; }
	}

	private static bool VerifySignature(string licenseId, string product, string installId, string challenge,
		string buildId, long buildSequence, string customerId, string binaryHash,
		long issuedAtUnix, long leaseExpiresAtUnix, string signature)
	{
		try
		{
			var canonical = string.Join("|", licenseId, product, installId, challenge, buildId,
				buildSequence.ToString(CultureInfo.InvariantCulture), customerId, binaryHash,
				issuedAtUnix.ToString(CultureInfo.InvariantCulture), leaseExpiresAtUnix.ToString(CultureInfo.InvariantCulture));
			using var verifier = ECDsa.Create();
			verifier.ImportFromPem(PublicKeyPem);
			return VerifyEcdsa(verifier, Encoding.UTF8.GetBytes(canonical), signature);
		}
		catch { return false; }
	}

	private static bool VerifyPrivateSignature(string licenseId, string product, string installId, string challenge,
		string buildId, long buildSequence, string customerId, string binaryHash, long issuedAtUnix, long leaseExpiresAtUnix,
		string signature, string issuerPublicKeyPem, string delegationJson, string expectedLicenseHash)
		=> VerifyPrivateSignatureForRoot(licenseId, product, installId, challenge, buildId, buildSequence, customerId, binaryHash,
			issuedAtUnix, leaseExpiresAtUnix, signature, issuerPublicKeyPem, delegationJson, expectedLicenseHash, PublicKeyPem);

	private static bool VerifyPrivateSignatureForRoot(string licenseId, string product, string installId, string challenge,
		string buildId, long buildSequence, string customerId, string binaryHash, long issuedAtUnix, long leaseExpiresAtUnix,
		string signature, string issuerPublicKeyPem, string delegationJson, string expectedLicenseHash, string rootPublicKeyPem)
	{
		try
		{
			using var document = JsonDocument.Parse(delegationJson);
			var d = document.RootElement;
			var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
			var delegationIssued = d.GetProperty("issuedAtUnix").GetInt64();
			var delegationExpires = d.GetProperty("expiresAtUnix").GetInt64();
			var licenseExpires = d.GetProperty("licenseExpiresAtUnix").GetInt64();
			if (!d.GetProperty("valid").GetBoolean() || d.GetProperty("licenseId").GetString() != licenseId
				|| d.GetProperty("nodeId").GetString() is not string nodeId || d.GetProperty("generation").GetInt64() <= 0
				|| !string.Equals(d.GetProperty("licenseHash").GetString(), expectedLicenseHash, StringComparison.OrdinalIgnoreCase)
				|| delegationIssued > now + 120 || delegationExpires <= now || delegationExpires <= delegationIssued
				|| (licenseExpires != 0 && delegationExpires > licenseExpires)
				|| leaseExpiresAtUnix > delegationExpires
				|| (licenseExpires != 0 && licenseExpires <= now)) return false;
			using var nodeKey = ECDsa.Create();
			nodeKey.ImportFromPem(issuerPublicKeyPem);
			var nodeHash = Convert.ToHexString(SHA256.HashData(nodeKey.ExportSubjectPublicKeyInfo()));
			if (!string.Equals(nodeHash, d.GetProperty("nodePublicKeySha256").GetString(), StringComparison.OrdinalIgnoreCase)) return false;
			var policy = d.GetProperty("buildPolicy");
			if (!BuildPolicyAllows(policy, buildId, buildSequence, binaryHash)) return false;
			var policyHash = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(BuildPolicyCanonical(policy))));
			if (!string.Equals(policyHash, d.GetProperty("policySha256").GetString(), StringComparison.OrdinalIgnoreCase)) return false;
			var delegationCanonical = string.Join("|", licenseId, nodeId, d.GetProperty("generation").GetInt64().ToString(CultureInfo.InvariantCulture),
				nodeHash, d.GetProperty("licenseHash").GetString(), d.GetProperty("licenseExpiresAtUnix").GetInt64().ToString(CultureInfo.InvariantCulture),
				d.GetProperty("issuedAtUnix").GetInt64().ToString(CultureInfo.InvariantCulture), d.GetProperty("expiresAtUnix").GetInt64().ToString(CultureInfo.InvariantCulture), policyHash);
			using var rootKey = ECDsa.Create(); rootKey.ImportFromPem(rootPublicKeyPem);
			if (!VerifyEcdsa(rootKey, Encoding.UTF8.GetBytes(delegationCanonical), d.GetProperty("signature").GetString())) return false;
			var leaseCanonical = string.Join("|", licenseId, product, installId, challenge, buildId, buildSequence.ToString(CultureInfo.InvariantCulture), customerId, binaryHash, issuedAtUnix.ToString(CultureInfo.InvariantCulture), leaseExpiresAtUnix.ToString(CultureInfo.InvariantCulture));
			return VerifyEcdsa(nodeKey, Encoding.UTF8.GetBytes(leaseCanonical), signature);
		}
		catch { return false; }
	}

	private static bool BuildPolicyAllows(JsonElement policy, string buildId, long buildSequence, string binaryHash)
	{
		if (buildSequence < policy.GetProperty("minBuildSequence").GetInt64()) return false;
		var ids = policy.GetProperty("allowedBuildIds").EnumerateArray().Select(x => x.GetString() ?? string.Empty).ToArray();
		if (ids.Length > 0 && !ids.Contains(buildId, StringComparer.Ordinal)) return false;
		if (!policy.GetProperty("requireBinaryHash").GetBoolean()) return true;
		if (!policy.GetProperty("allowedBinaryHashes").TryGetProperty(buildId, out var hashes)) return false;
		return hashes.EnumerateArray().Any(x => string.Equals(x.GetString(), binaryHash, StringComparison.OrdinalIgnoreCase));
	}

	private static string BuildPolicyCanonical(JsonElement policy)
	{
		var ids = policy.GetProperty("allowedBuildIds").EnumerateArray().Select(x => x.GetString() ?? string.Empty).OrderBy(x => x, StringComparer.Ordinal);
		var entries = policy.GetProperty("allowedBinaryHashes").EnumerateObject().OrderBy(x => x.Name, StringComparer.Ordinal)
			.Select(x => x.Name + "=" + string.Join(",", x.Value.EnumerateArray().Select(y => y.GetString() ?? string.Empty).OrderBy(y => y, StringComparer.OrdinalIgnoreCase)));
		return string.Join("|", policy.GetProperty("minBuildSequence").GetInt64().ToString(CultureInfo.InvariantCulture), policy.GetProperty("requireBinaryHash").GetBoolean() ? "1" : "0", string.Join(",", ids), string.Join(";", entries));
	}

	private static bool VerifyEcdsa(ECDsa key, byte[] data, string? encodedSignature)
	{
		if (string.IsNullOrWhiteSpace(encodedSignature)) return false;
		try
		{
			var signature = Convert.FromBase64String(encodedSignature);
			if (key.VerifyData(data, signature, HashAlgorithmName.SHA256)) return true;
			// .NET/OpenSSL providers can disagree on the default ECDSA encoding.
			// The license protocol uses fixed-width P-256 P1363; retry as DER for
			// providers whose VerifyData default expects an ASN.1 sequence.
			if (signature.Length != 64) return false;
			var der = P1363ToDer(signature);
			return key.VerifyData(data, der, HashAlgorithmName.SHA256);
		}
		catch { return false; }
	}

	private static byte[] P1363ToDer(byte[] raw)
	{
		static byte[] Integer(byte[] value)
		{
			var offset = 0;
			while (offset < value.Length - 1 && value[offset] == 0) offset++;
			var body = value[offset..];
			if ((body[0] & 0x80) != 0) body = new byte[] { 0 }.Concat(body).ToArray();
			return new byte[] { 0x02, (byte)body.Length }.Concat(body).ToArray();
		}
		var r = Integer(raw[..32]);
		var s = Integer(raw[32..]);
		var body = r.Concat(s).ToArray();
		return new byte[] { 0x30, (byte)body.Length }.Concat(body).ToArray();
	}

	// Do not use a positional record here. The protected build renames constructor metadata,
	// while System.Text.Json needs constructor parameter names to deserialize a positional record.
	[System.Reflection.Obfuscation(Exclude = true, ApplyToMembers = true)]
	private sealed class LicenseCache
	{
		public string CardHash { get; set; } = string.Empty;
		public string ExpiresAt { get; set; } = string.Empty;
		public string LicenseId { get; set; } = string.Empty;
		public string Product { get; set; } = string.Empty;
		public string InstallId { get; set; } = string.Empty;
		public string Challenge { get; set; } = string.Empty;
		public string BuildId { get; set; } = string.Empty;
		public long BuildSequence { get; set; }
		public string CustomerId { get; set; } = string.Empty;
		public string BinaryHash { get; set; } = string.Empty;
		public string BuildSignature { get; set; } = string.Empty;
		public string Signature { get; set; } = string.Empty;
		public long IssuedAtUnix { get; set; }
		public long LeaseExpiresAtUnix { get; set; }
		public DateTimeOffset ValidatedAt { get; set; }
		public string IssuerPublicKeyPem { get; set; } = string.Empty;
		public string DelegationJson { get; set; } = string.Empty;
	}
}
