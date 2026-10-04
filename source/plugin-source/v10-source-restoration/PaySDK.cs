using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class PaySDK
{
	private readonly PayConfig WNuIGLPcMc;

	private readonly HttpClient yQmIff6DHd;

	private string? XW6I6oYWxL;

	private Dictionary<string, object>? DKNI2wOSKl;

	
	public PaySDK(PayConfig config, HttpClient? httpClient = null)
	{
		WNuIGLPcMc = config;
		if (WNuIGLPcMc.GatewayUrl.EndsWith("/"))
		{
			PayConfig wNuIGLPcMc = WNuIGLPcMc;
			string gatewayUrl = WNuIGLPcMc.GatewayUrl;
			wNuIGLPcMc.GatewayUrl = gatewayUrl.Substring(0, gatewayUrl.Length - 1);
		}
		yQmIff6DHd = httpClient ?? new HttpClient();
		yQmIff6DHd.Timeout = TimeSpan.FromSeconds(30.0);
	}

	
	public string? GetLastRequestUrl()
	{
		return XW6I6oYWxL;
	}

	
	public Dictionary<string, object>? GetLastRequestParams()
	{
		return DKNI2wOSKl;
	}

	
	public async Task<JsonElement> CreateOrderAsync(Dictionary<string, object> parameters)
	{
		parameters["pid"] = WNuIGLPcMc.Pid;
		parameters["timestamp"] = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
		return await AQAIjgFidM("/openapi/pay/create", parameters);
	}

	
	public async Task<JsonElement> QueryOrderAsync(string? tradeNo, string? outTradeNo)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>
		{
			["pid"] = WNuIGLPcMc.Pid,
			["timestamp"] = DateTimeOffset.Now.ToUnixTimeSeconds().ToString()
		};
		if (!string.IsNullOrEmpty(tradeNo))
		{
			dictionary["trade_no"] = tradeNo;
		}
		if (!string.IsNullOrEmpty(outTradeNo))
		{
			dictionary["out_trade_no"] = outTradeNo;
		}
		return await AQAIjgFidM("/openapi/pay/query", dictionary);
	}

	
	public async Task<JsonElement> RefundOrderAsync(Dictionary<string, object> parameters)
	{
		parameters["pid"] = WNuIGLPcMc.Pid;
		parameters["timestamp"] = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
		return await AQAIjgFidM("/openapi/pay/refund", parameters);
	}

	
	public async Task<JsonElement> QueryBalanceAsync()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>
		{
			["pid"] = WNuIGLPcMc.Pid,
			["timestamp"] = DateTimeOffset.Now.ToUnixTimeSeconds().ToString()
		};
		return await AQAIjgFidM("/openapi/merchant/balance_query", dictionary);
	}

	
	public bool VerifyNotify(Dictionary<string, string> parameters)
	{
		if (!parameters.ContainsKey("sign"))
		{
			return false;
		}
		string text = parameters["sign"];
		string valueOrDefault = parameters.GetValueOrDefault("sign_type", "MD5");
		Dictionary<string, string> dictionary = (from kvp in parameters
			where kvp.Key != "sign" && kvp.Key != "sign_type" && !string.IsNullOrEmpty(kvp.Value)
			orderby kvp.Key
			select kvp).ToDictionary( (KeyValuePair<string, string> kvp) => kvp.Key,  (KeyValuePair<string, string> kvp) => kvp.Value);
		string text2 = qJ9I8QxhKo(dictionary);
		if (valueOrDefault.Equals("RSA", StringComparison.OrdinalIgnoreCase))
		{
			if (string.IsNullOrEmpty(WNuIGLPcMc.RsaPublicKey))
			{
				return false;
			}
			try
			{
				return QUdIibPaOy(text2, text);
			}
			catch
			{
				return false;
			}
		}
		if (string.IsNullOrEmpty(WNuIGLPcMc.Md5Key))
		{
			return false;
		}
		string value = kBuIoNWps6(text2 + "&key=" + WNuIGLPcMc.Md5Key).ToUpper();
		return text.Equals(value, StringComparison.OrdinalIgnoreCase);
	}

	
	private async Task<JsonElement> AQAIjgFidM(string P_0, Dictionary<string, object> P_1)
	{
		P_1["sign_type"] = WNuIGLPcMc.SignType;
		P_1["sign"] = OFBIlts5FI(P_1);
		string requestUri = (XW6I6oYWxL = WNuIGLPcMc.GatewayUrl + P_0);
		DKNI2wOSKl = new Dictionary<string, object>(P_1);
		FormUrlEncodedContent content = new FormUrlEncodedContent(P_1.ToDictionary( (KeyValuePair<string, object> k) => k.Key,  (KeyValuePair<string, object> v) => v.Value?.ToString() ?? string.Empty));
		HttpResponseMessage response = await yQmIff6DHd.PostAsync(requestUri, content);
		string text = await response.Content.ReadAsStringAsync();
		if (!response.IsSuccessStatusCode)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("请求失败: ");
			defaultInterpolatedStringHandler.AppendFormatted(response.StatusCode);
			defaultInterpolatedStringHandler.AppendLiteral(", 内容: ");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			throw new HttpRequestException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		using JsonDocument jsonDocument = JsonDocument.Parse(text);
		return jsonDocument.RootElement.Clone();
	}

	
	private string OFBIlts5FI(Dictionary<string, object> P_0)
	{
		Dictionary<string, string> dictionary = (from kvp in P_0
			where kvp.Key != "sign" && kvp.Key != "sign_type" && kvp.Value != null && !string.IsNullOrEmpty(kvp.Value.ToString())
			orderby kvp.Key
			select kvp).ToDictionary( (KeyValuePair<string, object> kvp) => kvp.Key,  (KeyValuePair<string, object> kvp) => kvp.Value.ToString());
		string text = qJ9I8QxhKo(dictionary);
		if (WNuIGLPcMc.SignType.Equals("RSA", StringComparison.OrdinalIgnoreCase))
		{
			if (string.IsNullOrEmpty(WNuIGLPcMc.RsaPrivateKey))
			{
				throw new InvalidOperationException("RSA 私钥未配置");
			}
			return yEoINbteq1(text);
		}
		if (string.IsNullOrEmpty(WNuIGLPcMc.Md5Key))
		{
			throw new InvalidOperationException("MD5 密钥未配置");
		}
		return kBuIoNWps6(text + "&key=" + WNuIGLPcMc.Md5Key).ToUpper();
	}

	
	private string qJ9I8QxhKo<n1ZnHbIIMM0LqBLMVnS>(Dictionary<string, n1ZnHbIIMM0LqBLMVnS> P_0)
	{
		return string.Join("&", P_0.Select( (KeyValuePair<string, n1ZnHbIIMM0LqBLMVnS> kvp) =>
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(kvp.Key);
			defaultInterpolatedStringHandler.AppendLiteral("=");
			defaultInterpolatedStringHandler.AppendFormatted(kvp.Value);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}));
	}

	
	private string kBuIoNWps6(string P_0)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.UTF8.GetBytes(P_0);
		return BitConverter.ToString(mD.ComputeHash(bytes)).Replace("-", "").ToLower();
	}

	
	private string yEoINbteq1(string P_0)
	{
		byte[] array = Convert.FromBase64String(QI8IBs0FAY(WNuIGLPcMc.RsaPrivateKey));
		using RSA rSA = RSA.Create();
		rSA.ImportPkcs8PrivateKey(array, out var _);
		using (SHA256.Create())
		{
			byte[] bytes = Encoding.UTF8.GetBytes(P_0);
			return Convert.ToBase64String(rSA.SignData(bytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1));
		}
	}

	
	private bool QUdIibPaOy(string P_0, string P_1)
	{
		byte[] array = Convert.FromBase64String(QI8IBs0FAY(WNuIGLPcMc.RsaPublicKey));
		using RSA rSA = RSA.Create();
		rSA.ImportSubjectPublicKeyInfo(array, out var _);
		using (SHA256.Create())
		{
			byte[] bytes = Encoding.UTF8.GetBytes(P_0);
			byte[] signature = Convert.FromBase64String(P_1);
			return rSA.VerifyData(bytes, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
		}
	}

	
	private string QI8IBs0FAY(string P_0)
	{
		return P_0.Replace("-----BEGIN PRIVATE KEY-----", "").Replace("-----END PRIVATE KEY-----", "").Replace("-----BEGIN RSA PRIVATE KEY-----", "")
			.Replace("-----END RSA PRIVATE KEY-----", "")
			.Replace("-----BEGIN PUBLIC KEY-----", "")
			.Replace("-----END PUBLIC KEY-----", "")
			.Replace("\r", "")
			.Replace("\n", "")
			.Replace(" ", "");
	}

	static PaySDK()
	{
	}
}
