using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace GJSyJYUDOfxE331QwT1;

internal class EfHAVFUgqrnaj1QwnLW : Singleton<EfHAVFUgqrnaj1QwnLW>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public string aEtcjCBWTN;

		public MyNATSocketClient Mt5cl2rPef;

		
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		
		internal bool xKscgCW7Y4(注册信息 x)
		{
			return x.账号 == aEtcjCBWTN;
		}

		
		internal bool LJscD7bihg(注册信息 x)
		{
			return x.账号 == Mt5cl2rPef.user.人物数据.账号;
		}

		static _003C_003Ec__DisplayClass8_0()
		{
		}
	}

	
	internal void HZDUjlT8jE()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("推荐拉人配置类.json")))
			{
				Singleton<全局变量类>.I.推荐拉人配置 = JsonConvert.DeserializeObject<推荐拉人配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("推荐拉人配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.推荐拉人配置 = new 推荐拉人配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("推荐拉人配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.推荐拉人配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("推荐拉人配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void nvYUluNlQJ()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("推荐拉人配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.推荐拉人配置, Formatting.Indented));
			Log.Debug("推荐拉人配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("推荐拉人配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string T4aU8b0msE()
	{
		HZDUjlT8jE();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.推荐拉人配置, Formatting.Indented);
	}

	
	public void rZPUIjo2EM(string P_0)
	{
		Singleton<全局变量类>.I.推荐拉人配置 = JsonConvert.DeserializeObject<推荐拉人配置类>(P_0);
		nvYUluNlQJ();
	}

	
	internal byte[] DdCUoGfo6q(MyNATSocketClient P_0)
	{
		try
		{
			if (!Singleton<全局变量类>.I.推荐拉人配置.功能开关)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder("#G欢迎使用推荐查询功能：#r");
			StringBuilder stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler;
			if (Singleton<全局变量类>.I.推荐拉人配置.is获取被推荐人充值奖励)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(30, 3, stringBuilder2);
				handler.AppendLiteral("#n（被推荐人每充值#Y￥");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.最低充值);
				handler.AppendLiteral("#n元以上奖励推荐人#Y");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.充值奖励);
				handler.AppendLiteral("#n");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.充值奖励类型);
				handler.AppendLiteral(")#r");
				stringBuilder3.Append(ref handler);
			}
			string empty = string.Empty;
			if (P_0.user.存档数据.推荐拉人数据.推荐人GID != 0 && DB.I.DGHNDad7XG(P_0.user.存档数据.推荐拉人数据.推荐人GID, ref empty))
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder2);
				handler.AppendLiteral("#G你的推荐人：");
				handler.AppendFormatted((!string.IsNullOrWhiteSpace(empty)) ? ("#Y" + empty + "#n") : "#n无");
				handler.AppendLiteral("#r");
				stringBuilder4.Append(ref handler);
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder5 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(15, 1, stringBuilder2);
			handler.AppendLiteral("#G已推荐玩家：#Y");
			handler.AppendFormatted(P_0.user.存档数据.推荐拉人数据.累计推荐人数);
			handler.AppendLiteral("#G人#r");
			stringBuilder5.Append(ref handler);
			if (Singleton<全局变量类>.I.推荐拉人配置.is同IP推荐无效 || Singleton<全局变量类>.I.推荐拉人配置.is同机器码推荐无效 || Singleton<全局变量类>.I.推荐拉人配置.is同QQ推荐无效)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder6 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(8, 3, stringBuilder2);
				handler.AppendLiteral("#M温馨小提示：");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.is同IP推荐无效 ? "推荐相同登录IP的角色无效、" : "");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.is同机器码推荐无效 ? "推荐相同电脑注册的角色无效、" : "");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.is同QQ推荐无效 ? "推荐相同QQ注册的角色无效#r" : "#r");
				stringBuilder6.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.推荐拉人配置.is累计推荐奖励开关)
			{
				if (P_0.user.存档数据.推荐拉人数据.累计推荐人数 >= 5)
				{
					if (P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 5)
					{
						stringBuilder.Append("已领取推荐5人奖励#r");
					}
					else
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder7 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(26, 2, stringBuilder2);
						handler.AppendLiteral("[领取推荐  5人奖励（");
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐5人奖励);
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐5人奖励类型);
						handler.AppendLiteral("）/拉人_领取推荐5人奖励]");
						stringBuilder7.Append(ref handler);
					}
				}
				if (P_0.user.存档数据.推荐拉人数据.累计推荐人数 >= 10)
				{
					if (P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 10)
					{
						stringBuilder.Append("已领取推荐10人奖励#r");
					}
					else
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder8 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(27, 2, stringBuilder2);
						handler.AppendLiteral("[领取推荐 10人奖励（");
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐10人奖励);
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐10人奖励类型);
						handler.AppendLiteral("）/拉人_领取推荐10人奖励]");
						stringBuilder8.Append(ref handler);
					}
				}
				if (P_0.user.存档数据.推荐拉人数据.累计推荐人数 >= 20)
				{
					if (P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 20)
					{
						stringBuilder.Append("已领取推荐20人奖励#r");
					}
					else
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder9 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(27, 2, stringBuilder2);
						handler.AppendLiteral("[领取推荐 20人奖励（");
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐20人奖励);
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐20人奖励类型);
						handler.AppendLiteral("）/拉人_领取推荐20人奖励]");
						stringBuilder9.Append(ref handler);
					}
				}
				if (P_0.user.存档数据.推荐拉人数据.累计推荐人数 >= 40)
				{
					if (P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 40)
					{
						stringBuilder.Append("已领取推荐40人奖励#r");
					}
					else
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder10 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(27, 2, stringBuilder2);
						handler.AppendLiteral("[领取推荐 40人奖励（");
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐40人奖励);
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐40人奖励类型);
						handler.AppendLiteral("）/拉人_领取推荐40人奖励]");
						stringBuilder10.Append(ref handler);
					}
				}
				if (P_0.user.存档数据.推荐拉人数据.累计推荐人数 >= 60)
				{
					if (P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 60)
					{
						stringBuilder.Append("已领取推荐60人奖励#r");
					}
					else
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder11 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(28, 2, stringBuilder2);
						handler.AppendLiteral("[领取推荐 60人奖励（");
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐60人奖励);
						handler.AppendLiteral(" ");
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐60人奖励类型);
						handler.AppendLiteral("）/拉人_领取推荐60人奖励]");
						stringBuilder11.Append(ref handler);
					}
				}
				if (P_0.user.存档数据.推荐拉人数据.累计推荐人数 >= 80)
				{
					if (P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 80)
					{
						stringBuilder.Append("已领取推荐80人奖励#r");
					}
					else
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder12 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(28, 2, stringBuilder2);
						handler.AppendLiteral("[领取推荐 80人奖励（");
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐80人奖励);
						handler.AppendLiteral(" ");
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐80人奖励类型);
						handler.AppendLiteral("）/拉人_领取推荐80人奖励]");
						stringBuilder12.Append(ref handler);
					}
				}
				if (P_0.user.存档数据.推荐拉人数据.累计推荐人数 >= 100)
				{
					if (P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 100)
					{
						stringBuilder.Append("已领取推荐100人奖励#r");
					}
					else
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder13 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(29, 2, stringBuilder2);
						handler.AppendLiteral("[领取推荐100人奖励（");
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐100人奖励);
						handler.AppendLiteral(" ");
						handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐100人奖励类型);
						handler.AppendLiteral("）/拉人_领取推荐100人奖励]");
						stringBuilder13.Append(ref handler);
					}
				}
			}
			return Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, P_0.user.人物数据.形象ID, "推荐拉人查询功能", stringBuilder.ToString());
		}
		catch (Exception ex)
		{
			Log.Error("推荐查询对话处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal void XB6UNvxshS(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (Singleton<全局变量类>.I.推荐拉人配置.功能开关)
			{
				P_0.user.缓存数据.cdk类型 = AllEnums.CdkType.推荐;
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 5);
				defaultInterpolatedStringHandler.AppendLiteral("请输入你的推荐人玩家名称");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.is推荐自己无效 ? "" : "（没有推荐人可以填写自己）");
				defaultInterpolatedStringHandler.AppendLiteral("：#r  推荐人奖励：#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励类型);
				defaultInterpolatedStringHandler.AppendLiteral("#r被推荐人奖励：#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励类型);
				P_0.C_Send(i.组包输入框(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("推荐拉人对话事件报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void zKSUiidHmj(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (!Singleton<全局变量类>.I.推荐拉人配置.功能开关)
			{
				return;
			}
			P_1 = P_1.Replace("拉人_领取推荐", string.Empty);
			P_1 = P_1.Replace("人奖励", string.Empty);
			if (!int.TryParse(P_1, out var result) || (result != 5 && result != 10 && result != 20 && result != 40 && result != 60 && result != 80 && result != 100))
			{
				return;
			}
			if (P_0.user.存档数据.推荐拉人数据.累计推荐人数 < result)
			{
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你当前累计推荐为#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.推荐拉人数据.累计推荐人数);
				defaultInterpolatedStringHandler.AppendLiteral("#n人，暂时无法领取推荐#Y");
				defaultInterpolatedStringHandler.AppendFormatted(result);
				defaultInterpolatedStringHandler.AppendLiteral("#n人的奖励！");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= result)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前累计推荐奖励已经被领取，无法重复领取奖励！"));
				return;
			}
			P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 = result;
			AllEnums.数值Type 数值Type = AllEnums.数值Type.无;
			int num = 0;
			switch (result)
			{
			case 5:
				数值Type = Singleton<全局变量类>.I.推荐拉人配置.累计推荐5人奖励类型;
				num = Singleton<全局变量类>.I.推荐拉人配置.累计推荐5人奖励;
				break;
			case 10:
				数值Type = Singleton<全局变量类>.I.推荐拉人配置.累计推荐10人奖励类型;
				num = Singleton<全局变量类>.I.推荐拉人配置.累计推荐10人奖励;
				break;
			case 20:
				数值Type = Singleton<全局变量类>.I.推荐拉人配置.累计推荐20人奖励类型;
				num = Singleton<全局变量类>.I.推荐拉人配置.累计推荐20人奖励;
				break;
			case 40:
				数值Type = Singleton<全局变量类>.I.推荐拉人配置.累计推荐40人奖励类型;
				num = Singleton<全局变量类>.I.推荐拉人配置.累计推荐40人奖励;
				break;
			case 60:
				数值Type = Singleton<全局变量类>.I.推荐拉人配置.累计推荐60人奖励类型;
				num = Singleton<全局变量类>.I.推荐拉人配置.累计推荐60人奖励;
				break;
			case 80:
				数值Type = Singleton<全局变量类>.I.推荐拉人配置.累计推荐80人奖励类型;
				num = Singleton<全局变量类>.I.推荐拉人配置.累计推荐80人奖励;
				break;
			case 100:
				数值Type = Singleton<全局变量类>.I.推荐拉人配置.累计推荐100人奖励类型;
				num = Singleton<全局变量类>.I.推荐拉人配置.累计推荐100人奖励;
				break;
			}
			Singleton<WdAPI>.I.AKEoOlhFAx(P_0, 数值Type, string.Empty, num, true);
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("推荐拉人领取奖励处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal async Task G5VUBpw0Mx(MyNATSocketClient P_0, string P_1)
	{
		if (!Singleton<全局变量类>.I.推荐拉人配置.功能开关)
		{
			return;
		}
		if (P_0.user.存档数据.推荐拉人数据.推荐人GID != 0)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("无法重复填写推荐人。"));
			return;
		}
		int gid = DB.I.E3iNgPntG8(P_1);
		if (!Singleton<全局变量类>.I.角色存档表.TryGetValue(gid, out var value))
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你填写的推荐人昵称无效，可以在#Y活动大使#n处请重新填写。"));
		}
		else if (Singleton<全局变量类>.I.推荐拉人配置.is推荐自己无效 && gid == P_0.user.人物数据.GID)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("无法推荐自己，请在#Y活动大使#n处请重新填写。"));
		}
		else if (await KLZUGcQSOR(P_0, value.账号))
		{
			P_0.user.存档数据.推荐拉人数据.推荐人GID = gid;
			string text = await Singleton<WdAPI>.I.AKEoOlhFAx(P_0, Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励类型, Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励, (Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励类型 == AllEnums.数值Type.道具) ? 1 : int.Parse(Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励), false, "发放被[推荐人：" + P_0.user.人物数据.昵称 + "]奖励");
			P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("恭喜你，领取了推荐系统的奖励，" + text + "。"));
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(gid);
			角色存档数据类 value2;
			if (myNATSocketClient != null)
			{
				myNATSocketClient.user.存档数据.推荐拉人数据.累计推荐人数++;
				text = await Singleton<WdAPI>.I.AKEoOlhFAx(myNATSocketClient, Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励类型, Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励, (Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励类型 == AllEnums.数值Type.道具) ? 1 : int.Parse(Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励), false, "发放[推荐人：" + P_0.user.人物数据.昵称 + "]奖励");
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你推荐了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("#n，");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral("。");
				P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else if (Singleton<全局变量类>.I.角色存档表.TryGetValue(gid, out value2))
			{
				value2.推荐拉人数据.累计推荐人数++;
				Singleton<WdAPI>.I.uiroQSjehP(value2, Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励类型, Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励, (Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励类型 == AllEnums.数值Type.道具) ? 1 : int.Parse(Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励));
			}
		}
	}

	
	private async Task<bool> KLZUGcQSOR(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals7.aEtcjCBWTN = P_1;
		CS_0024_003C_003E8__locals7.Mt5cl2rPef = P_0;
		注册信息 注册信息2 = Singleton<全局变量类>.I.注册列表.Find( (注册信息 x) => x.账号 == CS_0024_003C_003E8__locals7.aEtcjCBWTN);
		注册信息 注册信息3 = Singleton<全局变量类>.I.注册列表.Find( (注册信息 x) => x.账号 == CS_0024_003C_003E8__locals7.Mt5cl2rPef.user.人物数据.账号);
		if (注册信息2 == null || 注册信息3 == null)
		{
			return true;
		}
		if (注册信息2.IP == 注册信息3.IP)
		{
			CS_0024_003C_003E8__locals7.Mt5cl2rPef.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你与填写的推荐人的注册IP相同，请在#Y活动大使#n处请重新填写。"));
			return false;
		}
		if (注册信息2.Mac == 注册信息3.Mac)
		{
			CS_0024_003C_003E8__locals7.Mt5cl2rPef.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你与填写的推荐人的注册机器相同，请在#Y活动大使#n处请重新填写。"));
			return false;
		}
		if (Singleton<WdAPI>.I.HqcoTm6EXC(注册信息2.qq, 注册信息3.qq))
		{
			CS_0024_003C_003E8__locals7.Mt5cl2rPef.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你与填写的推荐人的注册QQ有相同，请在#Y活动大使#n处请重新填写。"));
			return false;
		}
		await Task.Delay(1);
		return true;
	}

	
	public async Task ktVUfSuD8y(MyNATSocketClient P_0, int P_1)
	{
		if (Singleton<全局变量类>.I.推荐拉人配置.功能开关 && Singleton<全局变量类>.I.推荐拉人配置.is获取被推荐人充值奖励 && P_0.user.存档数据.推荐拉人数据.推荐人GID != 0 && P_1 >= Singleton<全局变量类>.I.推荐拉人配置.最低充值)
		{
			int num = P_1 / Singleton<全局变量类>.I.推荐拉人配置.最低充值;
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(P_0.user.存档数据.推荐拉人数据.推荐人GID);
			角色存档数据类 value2;
			if (myNATSocketClient != null)
			{
				string value = await Singleton<WdAPI>.I.AKEoOlhFAx(myNATSocketClient, Singleton<全局变量类>.I.推荐拉人配置.充值奖励类型, string.Empty, Singleton<全局变量类>.I.推荐拉人配置.充值奖励 * num, false, "发放[推荐人：" + P_0.user.人物数据.昵称 + "]返利奖励");
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你推荐的道友#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("#n在充值时触发了推荐返利，因此你");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("。");
				P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else if (Singleton<全局变量类>.I.角色存档表.TryGetValue(P_0.user.存档数据.推荐拉人数据.推荐人GID, out value2))
			{
				Singleton<WdAPI>.I.uiroQSjehP(value2, Singleton<全局变量类>.I.推荐拉人配置.充值奖励类型, string.Empty, Singleton<全局变量类>.I.推荐拉人配置.充值奖励 * num);
			}
		}
	}

	
	public EfHAVFUgqrnaj1QwnLW()
	{
	}

	static EfHAVFUgqrnaj1QwnLW()
	{
	}
}
