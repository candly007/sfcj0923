using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft_X.Json;
using R0F7EJKsPwFRj7h6amU;
using Serilog;
using vEAdPGPTkDFOYsbi303;
using yopQYJj0MvaHRRJcMLp;

namespace XWKUjNiqpjLqc4emuCT;

internal class xH3TPsiexTnpJAMMnJm : Singleton<xH3TPsiexTnpJAMMnJm>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public MyNATSocketClient sXfadiHEMb;

		
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		
		internal bool GehaRH82Wx(注册信息 x)
		{
			return x.账号 == sXfadiHEMb.user.人物数据.账号;
		}

		static _003C_003Ec__DisplayClass19_0()
		{
		}
	}

	private static byte[] oBWBIxhL18;

	private static byte[] dgbBo80P89;

	private PayConfig Nk8BNPLypI;

	private static object EQxBibi4kd;

	
	[SpecialName]
	public static bool clyBlug2Xa()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is内充支付)
		{
			return Singleton<全局变量类>.I.内充支付配置.功能开关;
		}
		return false;
	}

	
	internal void BvvirO2hli()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("内充支付配置类.json")))
			{
				Singleton<全局变量类>.I.内充支付配置 = JsonConvert.DeserializeObject<内充支付配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("内充支付配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.内充支付配置 = new 内充支付配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("内充支付配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.内充支付配置, Formatting.Indented));
			}
			Nk8BNPLypI.Pid = Singleton<全局变量类>.I.内充支付配置.Pid;
			Nk8BNPLypI.GatewayUrl = Singleton<全局变量类>.I.内充支付配置.GatewayUrl;
			Nk8BNPLypI.Md5Key = Singleton<全局变量类>.I.内充支付配置.Md5Key;
			Nk8BNPLypI.SignType = Singleton<全局变量类>.I.内充支付配置.SignType;
		}
		catch (Exception ex)
		{
			Log.Error("内充支付配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void ubQiZpwiaK()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("内充支付配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.内充支付配置, Formatting.Indented));
			Log.Debug("内充支付配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("内充支付配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string EOniteRSQC()
	{
		BvvirO2hli();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.内充支付配置, Formatting.Indented);
	}

	
	public void Sh7iAaTCjV(string P_0)
	{
		Singleton<全局变量类>.I.内充支付配置 = JsonConvert.DeserializeObject<内充支付配置类>(P_0);
		if (Singleton<全局变量类>.I.内充支付配置.剩余奖池.IsEmpty)
		{
			for (int i = 0; i < Singleton<全局变量类>.I.内充支付配置.总奖池.Count; i++)
			{
				Singleton<全局变量类>.I.内充支付配置.剩余奖池.Enqueue(Singleton<全局变量类>.I.内充支付配置.总奖池[i]);
			}
		}
		ubQiZpwiaK();
	}

	
	public async Task<内充抽奖类> f9wizFJ7tV()
	{
		if (Singleton<全局变量类>.I.内充支付配置.剩余奖池.TryDequeue(out 内充抽奖类 result))
		{
			return result;
		}
		await Task.Delay(0);
		lock (EQxBibi4kd)
		{
			if (Singleton<全局变量类>.I.内充支付配置.剩余奖池.IsEmpty)
			{
				for (int i = 0; i < Singleton<全局变量类>.I.内充支付配置.总奖池.Count; i++)
				{
					Singleton<全局变量类>.I.内充支付配置.剩余奖池.Enqueue(Singleton<全局变量类>.I.内充支付配置.总奖池[i]);
				}
			}
			Singleton<全局变量类>.I.内充支付配置.剩余奖池.TryDequeue(out result);
			return result;
		}
	}

	
	internal void zphBuNjiUj(MyNATSocketClient P_0)
	{
		if (clyBlug2Xa())
		{
			P_0.C_Send(oBWBIxhL18);
		}
	}

	
	public void wi1BwcNEdS(MyNATSocketClient P_0, string P_1, AllEnums.项目类型 P_2, AllEnums.数值Type P_3, string P_4, int P_5, int P_6, AllEnums.支付类型 P_7, string P_8 = "", string P_9 = "")
	{
		P_0.user.缓存数据.支付数据.支付项目 = P_1;
		P_0.user.缓存数据.支付数据.项目Type = P_2;
		P_0.user.缓存数据.支付数据.游戏账号 = P_0.user.人物数据.账号;
		P_0.user.缓存数据.支付数据.角色昵称 = P_0.user.人物数据.昵称;
		P_0.user.缓存数据.支付数据.GID = P_0.user.人物数据.GID;
		P_0.user.缓存数据.支付数据.购买物品类型 = P_3;
		P_0.user.缓存数据.支付数据.购买物品名字 = P_4;
		P_0.user.缓存数据.支付数据.购买物品数量 = P_5;
		P_0.user.缓存数据.支付数据.购买物品总价 = P_6;
		P_0.user.缓存数据.支付数据.支付Type = P_7;
		P_0.user.缓存数据.支付数据.二维码地址 = P_8;
		P_0.user.缓存数据.支付数据.物品编号 = P_9;
	}

	
	public void vAnBbhKEoG(MyNATSocketClient P_0, string P_1, AllEnums.项目类型 P_2, int P_3, int P_4, AllEnums.支付类型 P_5, string P_6 = "", string P_7 = "")
	{
		P_0.user.缓存数据.支付数据.支付项目 = P_1;
		P_0.user.缓存数据.支付数据.项目Type = P_2;
		P_0.user.缓存数据.支付数据.游戏账号 = P_0.user.人物数据.账号;
		P_0.user.缓存数据.支付数据.角色昵称 = P_0.user.人物数据.昵称;
		P_0.user.缓存数据.支付数据.GID = P_0.user.人物数据.GID;
		P_0.user.缓存数据.支付数据.购买物品类型 = AllEnums.数值Type.无;
		P_0.user.缓存数据.支付数据.购买物品名字 = string.Empty;
		P_0.user.缓存数据.支付数据.购买物品数量 = P_3;
		P_0.user.缓存数据.支付数据.购买物品总价 = P_4;
		P_0.user.缓存数据.支付数据.支付Type = P_5;
		P_0.user.缓存数据.支付数据.二维码地址 = P_6;
		P_0.user.缓存数据.支付数据.物品编号 = P_7;
	}

	
	public async Task kbaBJ1ydbE(MyNATSocketClient P_0, string P_1)
	{
		if (!int.TryParse(P_1, out var result))
		{
			return;
		}
		if (result <= 0 || result >= 10000)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你输入的充值金额有误。"));
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 2);
		defaultInterpolatedStringHandler.AppendLiteral("当前充值类型#Y【");
		defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.点卡充值类型);
		defaultInterpolatedStringHandler.AppendLiteral("】#n，抽奖次数#Y【");
		defaultInterpolatedStringHandler.AppendFormatted(P_1);
		defaultInterpolatedStringHandler.AppendLiteral("元】#n，请选择一下要支付的方式：#r");
		StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
		if (Singleton<全局变量类>.I.内充支付配置.支付宝支付)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 2, stringBuilder2);
			handler.AppendLiteral("[【支付宝扫码支付(");
			handler.AppendFormatted(result);
			handler.AppendLiteral("元)】/内充支付充值_alipay_");
			handler.AppendFormatted(result);
			handler.AppendLiteral("]");
			stringBuilder3.Append(ref handler);
		}
		if (Singleton<全局变量类>.I.内充支付配置.微信支付)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(27, 2, stringBuilder2);
			handler.AppendLiteral("[【微信扫码支付(");
			handler.AppendFormatted(result);
			handler.AppendLiteral("元)】/内充支付充值_wxpay_");
			handler.AppendFormatted(result);
			handler.AppendLiteral("]");
			stringBuilder4.Append(ref handler);
		}
		if (Singleton<全局变量类>.I.内充支付配置.QQ钱包支付)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder5 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 2, stringBuilder2);
			handler.AppendLiteral("[【QQ钱包扫码支付(");
			handler.AppendFormatted(result);
			handler.AppendLiteral("元)】/内充支付充值_qqpay_");
			handler.AppendFormatted(result);
			handler.AppendLiteral("]");
			stringBuilder5.Append(ref handler);
		}
		P_0.C_Send(Singleton<WdAPI>.I.对话生成_自己(P_0, stringBuilder.ToString()));
		await Task.Delay(0);
	}

	
	public async Task FBsBKXIf8k(MyNATSocketClient P_0, string P_1)
	{
		await Task.Delay(0);
		AllEnums.支付类型 支付类型 = AllEnums.支付类型.无;
		string s = string.Empty;
		if (Singleton<ByteAPI>.I.寻找文本(P_1, "内充支付充值_alipay_") && Singleton<全局变量类>.I.内充支付配置.支付宝支付)
		{
			s = P_1.Replace("内充支付充值_alipay_", "");
			支付类型 = AllEnums.支付类型.alipay;
		}
		else if (Singleton<ByteAPI>.I.寻找文本(P_1, "内充支付充值_wxpay_") && Singleton<全局变量类>.I.内充支付配置.微信支付)
		{
			s = P_1.Replace("内充支付充值_wxpay_", "");
			支付类型 = AllEnums.支付类型.wxpay;
		}
		else if (Singleton<ByteAPI>.I.寻找文本(P_1, "内充支付充值_qqpay_") && Singleton<全局变量类>.I.内充支付配置.QQ钱包支付)
		{
			s = P_1.Replace("内充支付充值_qqpay_", "");
			支付类型 = AllEnums.支付类型.qqpay;
		}
		if (int.TryParse(s, out var result) && 支付类型 != AllEnums.支付类型.无)
		{
			if (result <= 0 || result >= 10000)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你输入的充值金额有误。"));
				return;
			}
			xH3TPsiexTnpJAMMnJm obj = this;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
			defaultInterpolatedStringHandler.AppendLiteral("充值");
			defaultInterpolatedStringHandler.AppendFormatted(result);
			defaultInterpolatedStringHandler.AppendLiteral("元");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.点卡充值类型);
			obj.wi1BwcNEdS(P_0, defaultInterpolatedStringHandler.ToStringAndClear(), AllEnums.项目类型.系统充值, Singleton<全局变量类>.I.config.点卡充值类型, $"{Singleton<全局变量类>.I.config.点卡充值类型}", result * Singleton<全局变量类>.I.config.点卡充值比例, result, 支付类型, string.Empty, string.Empty);
			h4WBsGPweS(P_0);
		}
	}

	
	public async Task KUiBRPrqmH(MyNATSocketClient P_0, string P_1)
	{
		if (!int.TryParse(P_1, out var result))
		{
			return;
		}
		if (result <= 0 || result >= 10000)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你输入的抽奖次数有误。"));
			return;
		}
		int value = Singleton<全局变量类>.I.内充支付配置.单价 * result;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 2);
		defaultInterpolatedStringHandler.AppendLiteral("你要抽奖的次数为#Y");
		defaultInterpolatedStringHandler.AppendFormatted(result);
		defaultInterpolatedStringHandler.AppendLiteral("#n次，需要支付金额为#Y");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("#n元，请选择一下要支付的方式：#r");
		StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
		if (Singleton<全局变量类>.I.内充支付配置.支付宝支付)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(26, 1, stringBuilder2);
			handler.AppendLiteral("[【支付宝扫码支付】/内充支付抽奖_alipay_");
			handler.AppendFormatted(result);
			handler.AppendLiteral("]");
			stringBuilder3.Append(ref handler);
		}
		if (Singleton<全局变量类>.I.内充支付配置.微信支付)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(24, 1, stringBuilder2);
			handler.AppendLiteral("[【微信扫码支付】/内充支付抽奖_wxpay_");
			handler.AppendFormatted(result);
			handler.AppendLiteral("]");
			stringBuilder4.Append(ref handler);
		}
		P_0.C_Send(Singleton<WdAPI>.I.对话生成_自己(P_0, stringBuilder.ToString()));
		await Task.Delay(0);
	}

	
	public async Task T7rBdObvJg(MyNATSocketClient P_0, string P_1)
	{
		await Task.Delay(0);
		AllEnums.支付类型 支付类型 = AllEnums.支付类型.无;
		string text = string.Empty;
		if (Singleton<ByteAPI>.I.寻找文本(P_1, "内充支付抽奖_alipay_") && Singleton<全局变量类>.I.内充支付配置.支付宝支付)
		{
			text = P_1.Replace("内充支付抽奖_alipay_", "");
			支付类型 = AllEnums.支付类型.alipay;
		}
		else if (Singleton<ByteAPI>.I.寻找文本(P_1, "内充支付抽奖_wxpay_") && Singleton<全局变量类>.I.内充支付配置.微信支付)
		{
			text = P_1.Replace("内充支付抽奖_wxpay_", "");
			支付类型 = AllEnums.支付类型.wxpay;
		}
		else if (Singleton<ByteAPI>.I.寻找文本(P_1, "内充支付抽奖_qqpay_") && Singleton<全局变量类>.I.内充支付配置.QQ钱包支付)
		{
			text = P_1.Replace("内充支付抽奖_qqpay_", "");
			支付类型 = AllEnums.支付类型.qqpay;
		}
		if (int.TryParse(text, out var result) && 支付类型 != AllEnums.支付类型.无)
		{
			int num = result * Singleton<全局变量类>.I.内充支付配置.单价;
			if (num <= 0 || num >= 10000)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你输入的抽奖次数有误。"));
				return;
			}
			xH3TPsiexTnpJAMMnJm obj = this;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 3);
			defaultInterpolatedStringHandler.AppendLiteral("独家抽奖活动：");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
			defaultInterpolatedStringHandler.AppendLiteral(")进行");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("次抽奖");
			obj.vAnBbhKEoG(P_0, defaultInterpolatedStringHandler.ToStringAndClear(), AllEnums.项目类型.发卡抽奖, result, num, 支付类型);
			h4WBsGPweS(P_0);
		}
	}

	
	public async Task h4WBsGPweS(MyNATSocketClient P_0)
	{
		PaySDK sdk = new PaySDK(Nk8BNPLypI);
		try
		{
			P_0.user.缓存数据.支付数据.支付单号 = "ORDER" + DateTimeOffset.Now.ToUnixTimeSeconds();
			Dictionary<string, object> obj = new Dictionary<string, object>
			{
				["out_trade_no"] = P_0.user.缓存数据.支付数据.支付单号,
				["total_amount"] = $"{P_0.user.缓存数据.支付数据.购买物品总价}"
			};
			string key = "subject";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.GID);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.取时间戳(是否到秒: false));
			obj[key] = defaultInterpolatedStringHandler.ToStringAndClear();
			obj["paytype_code"] = $"{P_0.user.缓存数据.支付数据.支付Type}";
			obj["notify_url"] = "https://your-domain.com/api/pay/notify";
			obj["return_url"] = "https://your-domain.com/pay/success";
			obj["client_ip"] = P_0.当前client.IP;
			obj["attach"] = "";
			Dictionary<string, object> parameters = obj;
			JsonElement jsonElement = await sdk.CreateOrderAsync(parameters);
			int @int = jsonElement.GetProperty("code").GetInt32();
			string text = jsonElement.GetProperty("msg").GetString();
			string 二维码地址 = jsonElement.GetProperty("data").GetProperty("pay_url").GetString();
			string text2 = jsonElement.GetProperty("data").GetProperty("out_trade_no").GetString();
			if (@int != 1 || text != "success")
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒(text));
				return;
			}
			P_0.user.缓存数据.支付数据.二维码地址 = 二维码地址;
			BtmBUcrGdo(P_0, sdk, text2);
		}
		catch (Exception ex)
		{
			Log.Error("下单失败: " + ex.Message);
		}
	}

	
	public async Task BtmBUcrGdo(MyNATSocketClient P_0, PaySDK P_1, string P_2)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals25 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals25.sXfadiHEMb = P_0;
		try
		{
			StringBuilder 对话文本 = new StringBuilder();
			_ = string.Empty;
			_ = string.Empty;
			_ = string.Empty;
			string 支付状态 = string.Empty;
			int 倒计时 = 90;
			bool Is支付成功 = false;
			CS_0024_003C_003E8__locals25.sXfadiHEMb.user.缓存数据.支付数据.支付中 = true;
			while (支付状态 != "TRADE_SUCCESS")
			{
				倒计时--;
				if (倒计时 <= 0)
				{
					CS_0024_003C_003E8__locals25.sXfadiHEMb.C_Send(Singleton<WdAPI>.I.对话生成_自己(CS_0024_003C_003E8__locals25.sXfadiHEMb, "订单超时，请重新下单"));
					break;
				}
				if (!CS_0024_003C_003E8__locals25.sXfadiHEMb.user.缓存数据.支付数据.支付中)
				{
					CS_0024_003C_003E8__locals25.sXfadiHEMb.C_Send(Singleton<WdAPI>.I.提示_中心提醒("订单已经取消。"));
					break;
				}
				对话文本.Clear();
				StringBuilder stringBuilder = 对话文本;
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(47, 1, stringBuilder);
				handler.AppendLiteral("#12请道友在#R90#n秒内完成支付，支付完成后购买物品自动到账。剩余时间#Y#b ");
				handler.AppendFormatted(倒计时);
				handler.AppendLiteral(" #n秒");
				stringBuilder2.Append(ref handler);
				对话文本.Append("#r#R（支付过程期间请原地等待，勿进行战斗、观战、打卡仙灵卡等操作）");
				stringBuilder = 对话文本;
				StringBuilder stringBuilder3 = stringBuilder;
				handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder);
				handler.AppendLiteral("#r#Y支付项目：");
				handler.AppendFormatted(CS_0024_003C_003E8__locals25.sXfadiHEMb.user.缓存数据.支付数据.支付项目);
				stringBuilder3.Append(ref handler);
				stringBuilder = 对话文本;
				StringBuilder stringBuilder4 = stringBuilder;
				handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder);
				handler.AppendLiteral("#r#Y支付类型：");
				handler.AppendFormatted((AllEnums.支付类型名字)CS_0024_003C_003E8__locals25.sXfadiHEMb.user.缓存数据.支付数据.支付Type);
				stringBuilder4.Append(ref handler);
				stringBuilder = 对话文本;
				StringBuilder stringBuilder5 = stringBuilder;
				handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder);
				handler.AppendLiteral("#r#Y支付总价：");
				handler.AppendFormatted(CS_0024_003C_003E8__locals25.sXfadiHEMb.user.缓存数据.支付数据.购买物品总价);
				handler.AppendLiteral("元");
				stringBuilder5.Append(ref handler);
				对话文本.Append("#r#url#L点击前往支付页面支付{" + CS_0024_003C_003E8__locals25.sXfadiHEMb.user.缓存数据.支付数据.二维码地址 + "}#t");
				对话文本.Append("[取消支付/扫码支付_取消支付]");
				CS_0024_003C_003E8__locals25.sXfadiHEMb.C_Send(Singleton<WdAPI>.I.对话生成_自己(CS_0024_003C_003E8__locals25.sXfadiHEMb, 对话文本.ToString()));
				JsonElement jsonElement = await P_1.QueryOrderAsync(null, P_2);
				int @int = jsonElement.GetProperty("code").GetInt32();
				string 提示内容 = jsonElement.GetProperty("msg").GetString();
				if (@int != 1)
				{
					CS_0024_003C_003E8__locals25.sXfadiHEMb.C_Send(Singleton<WdAPI>.I.提示_中心提醒(提示内容));
					break;
				}
				jsonElement.GetProperty("data").GetProperty("trade_no").GetString();
				jsonElement.GetProperty("data").GetProperty("out_trade_no").GetString();
				jsonElement.GetProperty("data").GetProperty("total_amount").GetInt32();
				支付状态 = jsonElement.GetProperty("data").GetProperty("trade_status").GetString();
				if (Singleton<ByteAPI>.I.寻找文本等(支付状态, "TRADE_CLOSED", "TRADE_REFUND", "TRADE_FREEZE", "TRADE_UNFREEZE"))
				{
					CS_0024_003C_003E8__locals25.sXfadiHEMb.C_Send(Singleton<WdAPI>.I.提示_中心提醒(提示内容));
					break;
				}
				if (支付状态 == "TRADE_SUCCESS")
				{
					Is支付成功 = true;
					break;
				}
				if (支付状态 == "WAIT_BUYER_PAY")
				{
					await Task.Delay(1000);
				}
			}
			if (Is支付成功)
			{
				注册信息 注册信息2 = Singleton<全局变量类>.I.注册列表.Find( (注册信息 x) => x.账号 == CS_0024_003C_003E8__locals25.sXfadiHEMb.user.人物数据.账号);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 8);
				defaultInterpolatedStringHandler.AppendLiteral("支付日志：[订单号=");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals25.sXfadiHEMb.user.缓存数据.支付数据.支付单号);
				defaultInterpolatedStringHandler.AppendLiteral("] [账号=");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals25.sXfadiHEMb.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals25.sXfadiHEMb.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral(")] ");
				defaultInterpolatedStringHandler.AppendFormatted((注册信息2 == null) ? string.Empty : (string.IsNullOrWhiteSpace(注册信息2.注册验证码) ? string.Empty : ("[注册码=" + 注册信息2.注册验证码 + "] ")));
				defaultInterpolatedStringHandler.AppendLiteral("[金额=");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals25.sXfadiHEMb.user.缓存数据.支付数据.购买物品总价);
				defaultInterpolatedStringHandler.AppendLiteral("（");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals25.sXfadiHEMb.user.缓存数据.支付数据.支付Type);
				defaultInterpolatedStringHandler.AppendLiteral("）] [购买物品=");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals25.sXfadiHEMb.user.缓存数据.支付数据.购买物品名字);
				defaultInterpolatedStringHandler.AppendLiteral("×");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals25.sXfadiHEMb.user.缓存数据.支付数据.购买物品数量);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.ForContext("AuditCategory", "internal-payment").Information(defaultInterpolatedStringHandler.ToStringAndClear());
				CS_0024_003C_003E8__locals25.sXfadiHEMb.C_Send(Singleton<WdAPI>.I.对话生成_自己(CS_0024_003C_003E8__locals25.sXfadiHEMb, "#Y支付成功。"));
				nCwBWKfcc3(CS_0024_003C_003E8__locals25.sXfadiHEMb);
			}
		}
		catch (Exception ex)
		{
			Log.Error("返回客户等待支付结束-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public async Task nCwBWKfcc3(MyNATSocketClient P_0)
	{
		P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#G支付成功，即将发放奖励。", "#G[" + P_0.user.缓存数据.支付数据.支付项目 + "]支付成功，即将发放奖励。"));
		switch (P_0.user.缓存数据.支付数据.项目Type)
		{
		case AllEnums.项目类型.系统充值:
			await DB.I.rZCNrYJFT4(P_0);
			break;
		case AllEnums.项目类型.奇宝充值:
			if (P_0.user.缓存数据.支付数据.购买物品类型 == AllEnums.数值Type.奇宝点)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, P_0.user.缓存数据.支付数据.购买物品数量, false, "[支付奇宝点]");
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
				defaultInterpolatedStringHandler.AppendLiteral("#G支付成功！你获得了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.缓存数据.支付数据.购买物品数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点。");
				P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			break;
		case AllEnums.项目类型.奇宝购买:
			Singleton<svsUCqKdlsQkBBIo3St>.I.Df7Kfoshay(P_0);
			P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#G支付成功！你获得了#Y1#n个#R" + P_0.user.缓存数据.支付数据.购买物品名字 + "#n。"));
			break;
		case AllEnums.项目类型.发卡抽奖:
			await O7gBj7CiyG(P_0, P_0.user.缓存数据.支付数据.购买物品数量);
			break;
		case AllEnums.项目类型.天机神算:
		case AllEnums.项目类型.其他购买:
			break;
		}
	}

	
	internal async Task akMBgtZ7xZ(MyNATSocketClient P_0)
	{
		P_0.C_Send(dgbBo80P89);
		await P_0.C_Send异步(Singleton<WdAPI>.I.vdSoet7MIX(Singleton<全局变量类>.I.内充支付配置.剩余奖池.Count));
	}

	
	internal async Task INXBDkjQvh(MyNATSocketClient P_0)
	{
		try
		{
			await Task.Delay(0);
			StringBuilder stringBuilder = new StringBuilder();
			if (Singleton<全局变量类>.I.内充支付配置.总奖池.Count > 0)
			{
				List<内充抽奖类> source = Singleton<全局变量类>.I.内充支付配置.总奖池.DistinctBy( (内充抽奖类 x) => x.名字).ToList();
				stringBuilder.Append(string.Join("、", source.Select( (内充抽奖类 x) => x.名字)));
			}
			else
			{
				stringBuilder.Append("当前奖池暂无奖励。");
			}
			P_0.C_Send(Singleton<WdAPI>.I.UuhoZAdpED(stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("点击查询奖励详情-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task O7gBj7CiyG(MyNATSocketClient P_0, int P_1)
	{
		_ = 1;
		try
		{
			if (Singleton<全局变量类>.I.南极配置.功能开关 && P_0.user.缓存数据.支付数据.购买物品总价 >= Singleton<全局变量类>.I.config.点卡充值南极金额)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, P_0.user.缓存数据.支付数据.购买物品总价 / Singleton<全局变量类>.I.config.点卡充值南极金额, false, "[扫码支付]获得");
				P_0.C_Send(Singleton<WdAPI>.I.组包邮件南极次数(P_0));
			}
			if (Singleton<全局变量类>.I.累充配置.功能开关)
			{
				P_0.user.存档数据.总累充金额数 += P_0.user.缓存数据.支付数据.购买物品总价;
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, P_0.user.缓存数据.支付数据.购买物品总价, false, "[扫码支付]获得");
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你：累充进度又提升了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.缓存数据.支付数据.购买物品总价);
				defaultInterpolatedStringHandler.AppendLiteral("#n点，当前累充进度为#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.累计充值金额);
				defaultInterpolatedStringHandler.AppendLiteral("#n点。");
				P_0.C_Send(i.jyLIAFgHTA(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			StringBuilder 谣言文本 = new StringBuilder();
			string 杂项文本 = string.Empty;
			List<内充抽奖类> 最终奖励 = new List<内充抽奖类>(P_1);
			for (int j = 0; j < P_1; j++)
			{
				内充抽奖类 内充抽奖类2 = await f9wizFJ7tV();
				if (内充抽奖类2 != null)
				{
					最终奖励.Add(内充抽奖类2);
				}
			}
			if (最终奖励.Count > 0)
			{
				道具数据 道具数据2 = Singleton<pGS3mljky49pI9pArc9>.I.eyhjY1a75Q(最终奖励[0].名字);
				P_0.C_Send(Singleton<WdAPI>.I.ymxorl7Gud(最终奖励[0].名字, 道具数据2?.图标 ?? 0, string.Empty));
			}
			for (int j = 0; j < 最终奖励.Count; j++)
			{
				谣言文本.Clear();
				switch (最终奖励[j].类型)
				{
				case AllEnums.数值Type.道具:
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, 最终奖励[j].名字, AllEnums.指令Type.无, 最终奖励[j].数量, false, "内充抽奖"))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你抽到了#R");
						defaultInterpolatedStringHandler.AppendFormatted(最终奖励[j].数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
						defaultInterpolatedStringHandler.AppendFormatted(最终奖励[j].名字);
						defaultInterpolatedStringHandler.AppendLiteral("#n。");
						杂项文本 = defaultInterpolatedStringHandler.ToStringAndClear();
						if (最终奖励[j].Is谣言)
						{
							StringBuilder stringBuilder = 谣言文本;
							StringBuilder stringBuilder3 = stringBuilder;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(36, 3, stringBuilder);
							handler.AppendLiteral("恭喜#Y");
							handler.AppendFormatted(P_0.user.人物数据.昵称);
							handler.AppendLiteral("#n在幸运轮盘中抽到了#R");
							handler.AppendFormatted(最终奖励[j].数量);
							handler.AppendLiteral("#n个#R");
							handler.AppendFormatted(最终奖励[j].名字);
							handler.AppendLiteral("#n，让我们来一起恭喜他吧。");
							stringBuilder3.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.金元宝:
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.金元宝, string.Empty, AllEnums.指令Type.无, 最终奖励[j].数量, false, "内充抽奖"))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你抽到了#R");
						defaultInterpolatedStringHandler.AppendFormatted(最终奖励[j].数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n个#R金元宝#n。");
						杂项文本 = defaultInterpolatedStringHandler.ToStringAndClear();
						if (最终奖励[j].Is谣言)
						{
							StringBuilder stringBuilder = 谣言文本;
							StringBuilder stringBuilder7 = stringBuilder;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(39, 2, stringBuilder);
							handler.AppendLiteral("恭喜#Y");
							handler.AppendFormatted(P_0.user.人物数据.昵称);
							handler.AppendLiteral("#n在幸运轮盘中抽到了#R");
							handler.AppendFormatted(最终奖励[j].数量);
							handler.AppendLiteral("#n个#R金元宝#n，让我们来一起恭喜他吧。");
							stringBuilder7.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.银元宝:
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.银元宝, string.Empty, AllEnums.指令Type.无, 最终奖励[j].数量, false, "内充抽奖"))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你抽到了#R");
						defaultInterpolatedStringHandler.AppendFormatted(最终奖励[j].数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n个#R银元宝#n。");
						杂项文本 = defaultInterpolatedStringHandler.ToStringAndClear();
						if (最终奖励[j].Is谣言)
						{
							StringBuilder stringBuilder = 谣言文本;
							StringBuilder stringBuilder4 = stringBuilder;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(39, 2, stringBuilder);
							handler.AppendLiteral("恭喜#Y");
							handler.AppendFormatted(P_0.user.人物数据.昵称);
							handler.AppendLiteral("#n在幸运轮盘中抽到了#R");
							handler.AppendFormatted(最终奖励[j].数量);
							handler.AppendLiteral("#n个#R银元宝#n，让我们来一起恭喜他吧。");
							stringBuilder4.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.奇宝点:
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, 最终奖励[j].数量, false, "内充抽奖"))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你抽到了#R");
						defaultInterpolatedStringHandler.AppendFormatted(最终奖励[j].数量);
						defaultInterpolatedStringHandler.AppendLiteral("奇宝点#n。");
						杂项文本 = defaultInterpolatedStringHandler.ToStringAndClear();
						if (最终奖励[j].Is谣言)
						{
							StringBuilder stringBuilder = 谣言文本;
							StringBuilder stringBuilder6 = stringBuilder;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(34, 2, stringBuilder);
							handler.AppendLiteral("恭喜#Y");
							handler.AppendFormatted(P_0.user.人物数据.昵称);
							handler.AppendLiteral("#n在幸运轮盘中抽到了#R");
							handler.AppendFormatted(最终奖励[j].数量);
							handler.AppendLiteral("奇宝点#n，让我们来一起恭喜他吧。");
							stringBuilder6.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.累充点:
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, 最终奖励[j].数量, false, "内充抽奖"))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你抽到了#R");
						defaultInterpolatedStringHandler.AppendFormatted(最终奖励[j].数量);
						defaultInterpolatedStringHandler.AppendLiteral("累充点#n。");
						杂项文本 = defaultInterpolatedStringHandler.ToStringAndClear();
						if (最终奖励[j].Is谣言)
						{
							StringBuilder stringBuilder = 谣言文本;
							StringBuilder stringBuilder8 = stringBuilder;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(34, 2, stringBuilder);
							handler.AppendLiteral("恭喜#Y");
							handler.AppendFormatted(P_0.user.人物数据.昵称);
							handler.AppendLiteral("#n在幸运轮盘中抽到了#R");
							handler.AppendFormatted(最终奖励[j].数量);
							handler.AppendLiteral("累充点#n，让我们来一起恭喜他吧。");
							stringBuilder8.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.灵气值:
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, 最终奖励[j].数量, false, "内充抽奖"))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你抽到了#R");
						defaultInterpolatedStringHandler.AppendFormatted(最终奖励[j].数量);
						defaultInterpolatedStringHandler.AppendLiteral("灵气值#n。");
						杂项文本 = defaultInterpolatedStringHandler.ToStringAndClear();
						if (最终奖励[j].Is谣言)
						{
							StringBuilder stringBuilder = 谣言文本;
							StringBuilder stringBuilder5 = stringBuilder;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(34, 2, stringBuilder);
							handler.AppendLiteral("恭喜#Y");
							handler.AppendFormatted(P_0.user.人物数据.昵称);
							handler.AppendLiteral("#n在幸运轮盘中抽到了#R");
							handler.AppendFormatted(最终奖励[j].数量);
							handler.AppendLiteral("灵气值#n，让我们来一起恭喜他吧。");
							stringBuilder5.Append(ref handler);
						}
					}
					break;
				case AllEnums.数值Type.金钱:
					if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, 最终奖励[j].数量, false, "内充抽奖"))
					{
						杂项文本 = "你抽到了" + Singleton<WdAPI>.I.问道标准数值文本(最终奖励[j].数量) + "#R金钱#n。";
						if (最终奖励[j].Is谣言)
						{
							StringBuilder stringBuilder = 谣言文本;
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(33, 2, stringBuilder);
							handler.AppendLiteral("恭喜#Y");
							handler.AppendFormatted(P_0.user.人物数据.昵称);
							handler.AppendLiteral("#n在幸运轮盘中抽到了");
							handler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(最终奖励[j].数量));
							handler.AppendLiteral("#R金钱#n，让我们来一起恭喜他吧。");
							stringBuilder2.Append(ref handler);
						}
					}
					break;
				}
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(杂项文本));
				if (最终奖励[j].Is谣言)
				{
					Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(谣言文本.ToString(), "管理员"));
				}
				await Task.Delay(50);
			}
			ubQiZpwiaK();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("发放抽奖奖励-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public xH3TPsiexTnpJAMMnJm()
	{
		Nk8BNPLypI = new PayConfig
		{
			Pid = "2088532464887788",
			GatewayUrl = "https://v3.zhiyjs.com",
			SignType = "MD5",
			Md5Key = "7TC6YRL2I7MMZAWMK3KSM3DWGLU01JAG"
		};
	}

	
	static xH3TPsiexTnpJAMMnJm()
	{
		oBWBIxhL18 = new byte[16]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 6,
			61, 243, 0, 31, 1, 49
		};
		dgbBo80P89 = new byte[16]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 6,
			61, 243, 0, 15, 1, 49
		};
		EQxBibi4kd = new object();
	}
}
