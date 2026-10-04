using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Serilog;
using VcF0pbBvJqp0x0IfwN;
using vEAdPGPTkDFOYsbi303;

namespace ixYEhcwWIdwrtDxOO94;

internal class MbtVicwUkp5LuxTooFW : Singleton<MbtVicwUkp5LuxTooFW>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public MyNATSocketClient qoeXf9Nv9E;

		public MbtVicwUkp5LuxTooFW utFX6Y058w;

		public 六道轮回列表类 fNmX2skyWX;

		public 六道轮回存档数据类 eUYXmONVCV;

		
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		
		internal void NBMXG69N0C(string v)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
			defaultInterpolatedStringHandler.AppendFormatted(fNmX2skyWX.六道名字);
			defaultInterpolatedStringHandler.AppendLiteral("·轮回印");
			if (!(v != defaultInterpolatedStringHandler.ToStringAndClear()))
			{
				qoeXf9Nv9E.销毁回调事件 = null;
				MyNATSocketClient myNATSocketClient = qoeXf9Nv9E;
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(fNmX2skyWX.转世结束数值);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(fNmX2skyWX.六道名字);
				defaultInterpolatedStringHandler.AppendLiteral("·轮回印#n，脱离了");
				defaultInterpolatedStringHandler.AppendFormatted(eUYXmONVCV.转世阶段);
				defaultInterpolatedStringHandler.AppendLiteral("成功完成轮回转世！");
				myNATSocketClient.C_Send(i.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				eUYXmONVCV.转世状态 = AllEnums.轮回Type.已转世;
				eUYXmONVCV.转世属性列表[(int)eUYXmONVCV.转世阶段].转世属性 = 29;
				eUYXmONVCV.转世属性列表[(int)eUYXmONVCV.转世阶段].属性数值 = 1;
				MyNATSocketClient myNATSocketClient2 = qoeXf9Nv9E;
				WdAPI i2 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 2);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你，达到了脱离#Y");
				defaultInterpolatedStringHandler.AppendFormatted(fNmX2skyWX.六道名字);
				defaultInterpolatedStringHandler.AppendLiteral("的条件，成功完成轮回转世，从此超脱#Y");
				defaultInterpolatedStringHandler.AppendFormatted(fNmX2skyWX.六道名字);
				defaultInterpolatedStringHandler.AppendLiteral("，万法不侵！");
				myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				Thread.Sleep(100);
				utFX6Y058w.nOXwI5A5Q2(qoeXf9Nv9E);
			}
		}

		static _003C_003Ec__DisplayClass12_0()
		{
		}
	}

	internal static AllEnums.数值Type[] J9lwLcfQky;

	
	[SpecialName]
	internal static bool EaewmWn7Ul()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is定制六道)
		{
			return Singleton<全局变量类>.I.六道轮回配置.定制功能开关;
		}
		return false;
	}

	
	[SpecialName]
	internal static bool c5PwXOYtHf()
	{
		if (!EaewmWn7Ul())
		{
			return Singleton<全局变量类>.I.六道轮回配置.功能开关;
		}
		return true;
	}

	
	internal void NfKwgqpcv5()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("六道轮回配置类.json")))
			{
				Singleton<全局变量类>.I.六道轮回配置 = JsonConvert.DeserializeObject<六道轮回配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("六道轮回配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.六道轮回配置 = new 六道轮回配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("六道轮回配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.六道轮回配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("六道轮回配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void xbPwDR6AkH()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("六道轮回配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.六道轮回配置, Formatting.Indented));
			Log.Debug("六道轮回配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("六道轮回配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string nmwwj3ov5K()
	{
		NfKwgqpcv5();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.六道轮回配置, Formatting.Indented);
	}

	
	public void RniwlKKj9C(string P_0)
	{
		Singleton<全局变量类>.I.六道轮回配置 = JsonConvert.DeserializeObject<六道轮回配置类>(P_0);
		xbPwDR6AkH();
	}

	
	internal void fsdw8chBuX(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_0.user.人物数据.形象ID == 7008 || P_0.user.人物数据.形象ID == 7009)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("只有真身才能参与六道轮回活动！"));
			}
			else if (!EaewmWn7Ul() && P_0.user.属性数据.剩余相性 != 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前有剩余的相性点未分配，无法进行六道轮回相关操作！"));
			}
			else if (P_0.user.属性数据.等级 < Singleton<全局变量类>.I.六道轮回配置.最低需求等级)
			{
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
				defaultInterpolatedStringHandler.AppendLiteral("你当前等级不足#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.最低需求等级);
				defaultInterpolatedStringHandler.AppendLiteral("#n级，无法进行六道轮回相关操作！");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else if (P_1 == "轮回操作_打开")
			{
				nOXwI5A5Q2(P_0);
			}
			else if (P_1 == "轮回操作_开启")
			{
				dibwo5XbOx(P_0);
			}
			else if (P_1 == "轮回操作_结束")
			{
				rVywN4tQBg(P_0);
			}
			else if (P_1 == "轮回操作_转属")
			{
				sRdwiVJ0lM(P_0);
			}
			else if (P_1 == "轮回操作_自动转属")
			{
				P_0.user.存档数据.轮回转世数据.qkVIsPyWCW = true;
				rJlwBP7M5q(P_0);
			}
			else if (P_1 == "轮回操作_停止自动转属")
			{
				P_0.user.存档数据.轮回转世数据.qkVIsPyWCW = false;
			}
			else if (P_1 == "轮回操作_激活")
			{
				PFmwGGwDc3(P_0);
			}
			else if (P_1.Contains("轮回操作_使用特效道具", StringComparison.CurrentCulture))
			{
				eFpw6Wj89Z(P_0, P_1.Replace("轮回操作_使用特效道具", ""));
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("六道轮回事件处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void nOXwI5A5Q2(MyNATSocketClient P_0)
	{
		try
		{
			六道轮回存档数据类 六道轮回存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.轮回转世数据.存档方案1 : P_0.user.存档数据.轮回转世数据.存档方案2);
			六道轮回列表类 六道轮回列表类2 = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[(int)六道轮回存档数据类2.转世阶段];
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("#Y当前阶段：#O");
			defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世状态);
			defaultInterpolatedStringHandler.AppendLiteral("）#n#r");
			StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(11, 2, stringBuilder2);
			handler.AppendLiteral("#Y轮回消耗：");
			handler.AppendFormatted(六道轮回列表类2.开启消耗数值);
			handler.AppendFormatted(六道轮回列表类2.开启消耗类型);
			handler.AppendLiteral("#n#r");
			stringBuilder3.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder2);
			handler.AppendLiteral("#Y开启等级：最低");
			handler.AppendFormatted(六道轮回列表类2.最低等级);
			handler.AppendLiteral("级#n#r");
			stringBuilder4.Append(ref handler);
			if (六道轮回列表类2.转世结束类型 == AllEnums.数值Type.道具)
			{
				if (六道轮回列表类2.is扣除)
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(35, 2, stringBuilder2);
					handler.AppendLiteral("#Y结束条件：获得#R");
					handler.AppendFormatted(六道轮回列表类2.转世结束数值);
					handler.AppendLiteral("#Y枚#G");
					handler.AppendFormatted(六道轮回存档数据类2.转世阶段);
					handler.AppendLiteral("·轮回印#n#R(结束时扣除)#n#r");
					stringBuilder5.Append(ref handler);
				}
				else
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(24, 2, stringBuilder2);
					handler.AppendLiteral("#Y结束条件：获得#R");
					handler.AppendFormatted(六道轮回列表类2.转世结束数值);
					handler.AppendLiteral("#Y枚#G");
					handler.AppendFormatted(六道轮回存档数据类2.转世阶段);
					handler.AppendLiteral("·轮回印#n#r");
					stringBuilder6.Append(ref handler);
				}
			}
			else if (六道轮回列表类2.is扣除)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder7 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(24, 2, stringBuilder2);
				handler.AppendLiteral("#Y结束条件：达到");
				handler.AppendFormatted(六道轮回列表类2.转世结束数值);
				handler.AppendFormatted(六道轮回列表类2.转世结束类型);
				handler.AppendLiteral("#n#R(结束时扣除)#n#r");
				stringBuilder7.Append(ref handler);
			}
			else
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder8 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
				handler.AppendLiteral("#Y结束条件：达到");
				handler.AppendFormatted(六道轮回列表类2.转世结束数值);
				handler.AppendFormatted(六道轮回列表类2.转世结束类型);
				handler.AppendLiteral("#n#r");
				stringBuilder8.Append(ref handler);
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder9 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(21, 2, stringBuilder2);
			handler.AppendLiteral("#Y奖励属性：最高所相+");
			handler.AppendFormatted(六道轮回列表类2.所相数值);
			handler.AppendLiteral("/单相性+");
			handler.AppendFormatted(六道轮回列表类2.单相数值);
			handler.AppendLiteral("#n#r");
			stringBuilder9.Append(ref handler);
			if (六道轮回存档数据类2.转世状态 == AllEnums.轮回Type.未开始)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder10 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
				handler.AppendLiteral("[【");
				handler.AppendFormatted(六道轮回存档数据类2.转世阶段);
				handler.AppendLiteral("】开启六道轮回/轮回操作_开启]");
				stringBuilder10.Append(ref handler);
			}
			else if (六道轮回存档数据类2.转世状态 == AllEnums.轮回Type.转世中)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder11 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
				handler.AppendLiteral("[【");
				handler.AppendFormatted(六道轮回存档数据类2.转世阶段);
				handler.AppendLiteral("】结束六道轮回/轮回操作_结束]");
				stringBuilder11.Append(ref handler);
			}
			else if (六道轮回存档数据类2.转世状态 == AllEnums.轮回Type.已转世)
			{
				轮回转世属性存档 轮回转世属性存档2 = 六道轮回存档数据类2.转世属性列表[(int)六道轮回存档数据类2.转世阶段];
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder12 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
				handler.AppendLiteral("#G当前属性：");
				handler.AppendFormatted((AllEnums.属性Type)轮回转世属性存档2.转世属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(轮回转世属性存档2.属性数值);
				handler.AppendLiteral("/");
				handler.AppendFormatted((轮回转世属性存档2.转世属性 == 29) ? 六道轮回列表类2.所相数值 : 六道轮回列表类2.单相数值);
				handler.AppendLiteral(" 增加#n#r");
				stringBuilder12.Append(ref handler);
				if (P_0.user.存档数据.轮回转世数据.qkVIsPyWCW)
				{
					stringBuilder.Append("[【取消自动重置】停止自动重置轮回属性操作/轮回操作_停止自动转属]");
				}
				else
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder13 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(86, 3, stringBuilder2);
					handler.AppendLiteral("[【转属】重置当前");
					handler.AppendFormatted(六道轮回存档数据类2.转世阶段);
					handler.AppendLiteral("属性(");
					handler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新价格);
					handler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新类型);
					handler.AppendLiteral(")/轮回操作_转属][【自动重置】自动重置出所相或单相最大值停止/轮回操作_自动转属][【激活】确认激活当前属性(激活后不可更改)/轮回操作_激活]");
					stringBuilder13.Append(ref handler);
				}
			}
			else if (六道轮回存档数据类2.转世状态 == AllEnums.轮回Type.已圆满)
			{
				stringBuilder.Append("#R恭喜道友，六道轮回转世圆满，自此超脱六道轮回，万法不侵，不堕地狱，大道可期！");
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, Singleton<全局变量类>.I.六道轮回配置.npc形象, Singleton<全局变量类>.I.六道轮回配置.npc名字, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("六道轮回打开处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void dibwo5XbOx(MyNATSocketClient P_0)
	{
		try
		{
			六道轮回存档数据类 六道轮回存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.轮回转世数据.存档方案1 : P_0.user.存档数据.轮回转世数据.存档方案2);
			六道轮回列表类 六道轮回列表类2 = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[(int)六道轮回存档数据类2.转世阶段];
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (P_0.user.属性数据.等级 < 六道轮回列表类2.最低等级)
			{
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你当前等级不足#R");
				defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类2.最低等级);
				defaultInterpolatedStringHandler.AppendLiteral("#n级，无法开启");
				defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
				defaultInterpolatedStringHandler.AppendLiteral("进入轮回！");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (六道轮回列表类2.开启消耗类型 == AllEnums.数值Type.金元宝)
			{
				if (P_0.user.背包数据.金元宝 < 六道轮回列表类2.开启消耗数值)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R金元宝#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类2.开启消耗数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法开启");
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("进入轮回！");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, -六道轮回列表类2.开启消耗数值, 0))
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R金元宝#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类2.开启消耗数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法开启");
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("进入轮回！");
					P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
			}
			if (六道轮回列表类2.开启消耗类型 == AllEnums.数值Type.银元宝)
			{
				if (P_0.user.背包数据.银元宝 < 六道轮回列表类2.开启消耗数值)
				{
					WdAPI i4 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R银元宝#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类2.开启消耗数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法开启");
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("进入轮回！");
					P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, 0, -六道轮回列表类2.开启消耗数值))
				{
					WdAPI i5 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R银元宝#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类2.开启消耗数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法开启");
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("进入轮回！");
					P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
			}
			if (六道轮回列表类2.开启消耗类型 == AllEnums.数值Type.灵气值)
			{
				if (P_0.user.存档数据.数值存档.灵气值 < 六道轮回列表类2.开启消耗数值)
				{
					WdAPI i6 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R灵气值#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类2.开启消耗数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法开启");
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("进入轮回！");
					P_0.C_Send(i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				WdAPI i7 = Singleton<WdAPI>.I;
				string empty = string.Empty;
				int num = -六道轮回列表类2.开启消耗数值;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[");
				defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
				defaultInterpolatedStringHandler.AppendLiteral("]开启消耗");
				i7.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, empty, AllEnums.指令Type.无, num, false, defaultInterpolatedStringHandler.ToStringAndClear());
			}
			六道轮回存档数据类2.转世状态 = AllEnums.轮回Type.转世中;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
			defaultInterpolatedStringHandler.AppendLiteral("#Y");
			defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
			defaultInterpolatedStringHandler.AppendLiteral("#n轮回已经开启，该阶段需要#Y");
			defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类2.转世结束类型);
			defaultInterpolatedStringHandler.AppendLiteral("#n达到#Y");
			defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类2.转世结束数值);
			defaultInterpolatedStringHandler.AppendLiteral("#n方可结束轮回转世！");
			string 提示内容 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (六道轮回列表类2.转世结束类型 == AllEnums.数值Type.道具)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 3);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
				defaultInterpolatedStringHandler.AppendLiteral("#n轮回已经开启，该阶段需要获取的#Y");
				defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
				defaultInterpolatedStringHandler.AppendLiteral("·轮回印#n达到#Y");
				defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类2.转世结束数值);
				defaultInterpolatedStringHandler.AppendLiteral("#n枚方可结束轮回转世！");
				提示内容 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒(提示内容).Concat(Singleton<WdAPI>.I.提示_杂项公告(提示内容)).ToArray());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("六道轮回开启处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void rVywN4tQBg(MyNATSocketClient P_0)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals143 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals143.qoeXf9Nv9E = P_0;
		CS_0024_003C_003E8__locals143.utFX6Y058w = this;
		try
		{
			CS_0024_003C_003E8__locals143.eUYXmONVCV = (CS_0024_003C_003E8__locals143.qoeXf9Nv9E.user.缓存数据.is加点方案一 ? CS_0024_003C_003E8__locals143.qoeXf9Nv9E.user.存档数据.轮回转世数据.存档方案1 : CS_0024_003C_003E8__locals143.qoeXf9Nv9E.user.存档数据.轮回转世数据.存档方案2);
			CS_0024_003C_003E8__locals143.fNmX2skyWX = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[(int)CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段];
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			switch (CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束类型)
			{
			case AllEnums.数值Type.金元宝:
				if (CS_0024_003C_003E8__locals143.qoeXf9Nv9E.user.背包数据.金元宝 < CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值)
				{
					MyNATSocketClient myNATSocketClient16 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i16 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R金元宝#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法脱离");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("结束轮回转世！");
					myNATSocketClient16.C_Send(i16.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (CS_0024_003C_003E8__locals143.fNmX2skyWX.is扣除)
				{
					if (!DB.I.cAJNoOkab6(CS_0024_003C_003E8__locals143.qoeXf9Nv9E, -CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值, 0))
					{
						MyNATSocketClient myNATSocketClient17 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
						WdAPI i17 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前#R金元宝#n不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法脱离");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
						defaultInterpolatedStringHandler.AppendLiteral("结束轮回转世！");
						myNATSocketClient17.C_Send(i17.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					MyNATSocketClient myNATSocketClient18 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i18 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n金元宝，脱离了");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("成功完成轮回转世！");
					myNATSocketClient18.C_Send(i18.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				break;
			case AllEnums.数值Type.银元宝:
				if (CS_0024_003C_003E8__locals143.qoeXf9Nv9E.user.背包数据.银元宝 < CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值)
				{
					MyNATSocketClient myNATSocketClient19 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i19 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R银元宝#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法脱离");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("结束轮回转世！");
					myNATSocketClient19.C_Send(i19.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (CS_0024_003C_003E8__locals143.fNmX2skyWX.is扣除)
				{
					if (!DB.I.cAJNoOkab6(CS_0024_003C_003E8__locals143.qoeXf9Nv9E, 0, -CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值))
					{
						MyNATSocketClient myNATSocketClient20 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
						WdAPI i20 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
						defaultInterpolatedStringHandler.AppendLiteral("你当前#R银元宝#n不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法脱离");
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
						defaultInterpolatedStringHandler.AppendLiteral("结束轮回转世！");
						myNATSocketClient20.C_Send(i20.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					MyNATSocketClient myNATSocketClient21 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i21 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n银元宝，脱离了");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("成功完成轮回转世！");
					myNATSocketClient21.C_Send(i21.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				break;
			case AllEnums.数值Type.声望:
				if (CS_0024_003C_003E8__locals143.qoeXf9Nv9E.user.属性数据.声望 < CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值)
				{
					MyNATSocketClient myNATSocketClient10 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i10 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R声望#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法脱离");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("结束轮回转世！");
					myNATSocketClient10.C_Send(i10.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (CS_0024_003C_003E8__locals143.fNmX2skyWX.is扣除)
				{
					WdAPI i11 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient11 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					string empty4 = string.Empty;
					int num4 = -CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("]完成消耗");
					i11.PndoGw5lW7(myNATSocketClient11, AllEnums.发送数据Type.数值, empty4, AllEnums.指令Type.reputation, num4, false, defaultInterpolatedStringHandler.ToStringAndClear());
					MyNATSocketClient myNATSocketClient12 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i12 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n声望，脱离了");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("成功完成轮回转世！");
					myNATSocketClient12.C_Send(i12.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				break;
			case AllEnums.数值Type.道行:
				if (CS_0024_003C_003E8__locals143.qoeXf9Nv9E.user.属性数据.道行 < CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值 * 360)
				{
					MyNATSocketClient myNATSocketClient4 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i4 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R道行#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n年，无法脱离");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("结束轮回转世！");
					myNATSocketClient4.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (CS_0024_003C_003E8__locals143.fNmX2skyWX.is扣除)
				{
					WdAPI i5 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient5 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					string empty2 = string.Empty;
					int num2 = -CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值 * 360;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("]完成消耗");
					i5.PndoGw5lW7(myNATSocketClient5, AllEnums.发送数据Type.数值, empty2, AllEnums.指令Type.tao, num2, false, defaultInterpolatedStringHandler.ToStringAndClear());
					MyNATSocketClient myNATSocketClient6 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i6 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n年道行，脱离了");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("成功完成轮回转世！");
					myNATSocketClient6.C_Send(i6.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				break;
			case AllEnums.数值Type.经验:
				if (CS_0024_003C_003E8__locals143.qoeXf9Nv9E.user.属性数据.经验 < CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值)
				{
					MyNATSocketClient myNATSocketClient7 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i7 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R经验#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法脱离");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("结束轮回转世！");
					myNATSocketClient7.C_Send(i7.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (CS_0024_003C_003E8__locals143.fNmX2skyWX.is扣除)
				{
					WdAPI i8 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient8 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					string empty3 = string.Empty;
					int num3 = -CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("]完成消耗");
					i8.PndoGw5lW7(myNATSocketClient8, AllEnums.发送数据Type.数值, empty3, AllEnums.指令Type.exp, num3, false, defaultInterpolatedStringHandler.ToStringAndClear());
					MyNATSocketClient myNATSocketClient9 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i9 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n点经验，脱离了");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("成功完成轮回转世！");
					myNATSocketClient9.C_Send(i9.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				break;
			case AllEnums.数值Type.等级:
				if (CS_0024_003C_003E8__locals143.qoeXf9Nv9E.user.属性数据.等级 < CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值)
				{
					MyNATSocketClient myNATSocketClient13 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i13 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R等级#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法脱离");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("结束轮回转世！");
					myNATSocketClient13.C_Send(i13.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (CS_0024_003C_003E8__locals143.fNmX2skyWX.is扣除)
				{
					WdAPI i14 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient14 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					string empty5 = string.Empty;
					int num5 = -CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("]完成消耗");
					i14.PndoGw5lW7(myNATSocketClient14, AllEnums.发送数据Type.数值, empty5, AllEnums.指令Type.level, num5, false, defaultInterpolatedStringHandler.ToStringAndClear());
					MyNATSocketClient myNATSocketClient15 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i15 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n等级，脱离了");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("成功完成轮回转世！");
					myNATSocketClient15.C_Send(i15.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				break;
			case AllEnums.数值Type.灵气值:
				if (CS_0024_003C_003E8__locals143.qoeXf9Nv9E.user.存档数据.数值存档.灵气值 < CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值)
				{
					MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R灵气值#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法脱离");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("结束轮回转世！");
					myNATSocketClient.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (CS_0024_003C_003E8__locals143.fNmX2skyWX.is扣除)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					string empty = string.Empty;
					int num = -CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("]完成消耗");
					i2.PndoGw5lW7(myNATSocketClient2, AllEnums.发送数据Type.灵气值, empty, AllEnums.指令Type.无, num, false, defaultInterpolatedStringHandler.ToStringAndClear());
					MyNATSocketClient myNATSocketClient3 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i3 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler.AppendLiteral("#n灵气值，脱离了");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("成功完成轮回转世！");
					myNATSocketClient3.C_Send(i3.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				break;
			}
			if (CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束类型 != AllEnums.数值Type.道具)
			{
				CS_0024_003C_003E8__locals143.eUYXmONVCV.转世状态 = AllEnums.轮回Type.已转世;
				CS_0024_003C_003E8__locals143.eUYXmONVCV.转世属性列表[(int)CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段].转世属性 = 29;
				CS_0024_003C_003E8__locals143.eUYXmONVCV.转世属性列表[(int)CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段].属性数值 = 1;
				MyNATSocketClient myNATSocketClient22 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
				WdAPI i22 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 2);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你，达到了脱离#Y");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.六道名字);
				defaultInterpolatedStringHandler.AppendLiteral("的条件，成功完成轮回转世，从此超脱#Y");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.六道名字);
				defaultInterpolatedStringHandler.AppendLiteral("，万法不侵！");
				myNATSocketClient22.C_Send(i22.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				nOXwI5A5Q2(CS_0024_003C_003E8__locals143.qoeXf9Nv9E);
				return;
			}
			WdAPI i23 = Singleton<WdAPI>.I;
			MyNATSocketClient myclient = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.六道名字);
			defaultInterpolatedStringHandler.AppendLiteral("·轮回印");
			物品信息类 物品信息类2 = i23.取背包物品格子实例(myclient, defaultInterpolatedStringHandler.ToStringAndClear());
			if (物品信息类2 == null || (物品信息类2 != null && 物品信息类2.数量 < CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值))
			{
				MyNATSocketClient myNATSocketClient23 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
				WdAPI i24 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你当前拥有的#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.六道名字);
				defaultInterpolatedStringHandler.AppendLiteral("·轮回印#n数量不足#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
				defaultInterpolatedStringHandler.AppendLiteral("#n个，无法脱离");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
				defaultInterpolatedStringHandler.AppendLiteral("结束轮回转世！");
				myNATSocketClient23.C_Send(i24.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if (!CS_0024_003C_003E8__locals143.fNmX2skyWX.is扣除)
			{
				CS_0024_003C_003E8__locals143.eUYXmONVCV.转世状态 = AllEnums.轮回Type.已转世;
				CS_0024_003C_003E8__locals143.eUYXmONVCV.转世属性列表[(int)CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段].转世属性 = 29;
				CS_0024_003C_003E8__locals143.eUYXmONVCV.转世属性列表[(int)CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段].属性数值 = 1;
				MyNATSocketClient myNATSocketClient24 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
				WdAPI i25 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 2);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你，达到了脱离#Y");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.六道名字);
				defaultInterpolatedStringHandler.AppendLiteral("的条件，成功完成轮回转世，从此超脱#Y");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.六道名字);
				defaultInterpolatedStringHandler.AppendLiteral("，万法不侵！");
				myNATSocketClient24.C_Send(i25.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				nOXwI5A5Q2(CS_0024_003C_003E8__locals143.qoeXf9Nv9E);
				return;
			}
			CS_0024_003C_003E8__locals143.qoeXf9Nv9E.销毁回调事件 =  (string v) =>
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(4, 1);
				defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.六道名字);
				defaultInterpolatedStringHandler2.AppendLiteral("·轮回印");
				if (!(v != defaultInterpolatedStringHandler2.ToStringAndClear()))
				{
					CS_0024_003C_003E8__locals143.qoeXf9Nv9E.销毁回调事件 = null;
					MyNATSocketClient myNATSocketClient25 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i26 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(30, 3);
					defaultInterpolatedStringHandler2.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值);
					defaultInterpolatedStringHandler2.AppendLiteral("#n个#R");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.六道名字);
					defaultInterpolatedStringHandler2.AppendLiteral("·轮回印#n，脱离了");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段);
					defaultInterpolatedStringHandler2.AppendLiteral("成功完成轮回转世！");
					myNATSocketClient25.C_Send(i26.提示_杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
					CS_0024_003C_003E8__locals143.eUYXmONVCV.转世状态 = AllEnums.轮回Type.已转世;
					CS_0024_003C_003E8__locals143.eUYXmONVCV.转世属性列表[(int)CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段].转世属性 = 29;
					CS_0024_003C_003E8__locals143.eUYXmONVCV.转世属性列表[(int)CS_0024_003C_003E8__locals143.eUYXmONVCV.转世阶段].属性数值 = 1;
					MyNATSocketClient myNATSocketClient26 = CS_0024_003C_003E8__locals143.qoeXf9Nv9E;
					WdAPI i27 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(36, 2);
					defaultInterpolatedStringHandler2.AppendLiteral("恭喜你，达到了脱离#Y");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.六道名字);
					defaultInterpolatedStringHandler2.AppendLiteral("的条件，成功完成轮回转世，从此超脱#Y");
					defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals143.fNmX2skyWX.六道名字);
					defaultInterpolatedStringHandler2.AppendLiteral("，万法不侵！");
					myNATSocketClient26.C_Send(i27.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear()));
					Thread.Sleep(100);
					CS_0024_003C_003E8__locals143.utFX6Y058w.nOXwI5A5Q2(CS_0024_003C_003E8__locals143.qoeXf9Nv9E);
				}
			};
			CS_0024_003C_003E8__locals143.qoeXf9Nv9E.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(物品信息类2.Index, CS_0024_003C_003E8__locals143.fNmX2skyWX.转世结束数值));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("六道轮回结束处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void sRdwiVJ0lM(MyNATSocketClient P_0)
	{
		try
		{
			六道轮回存档数据类 六道轮回存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.轮回转世数据.存档方案1 : P_0.user.存档数据.轮回转世数据.存档方案2);
			六道轮回列表类 六道轮回列表类2 = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[(int)六道轮回存档数据类2.转世阶段];
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (Singleton<全局变量类>.I.六道轮回配置.刷新类型 == AllEnums.数值Type.金元宝)
			{
				if (P_0.user.背包数据.金元宝 < Singleton<全局变量类>.I.六道轮回配置.刷新价格)
				{
					WdAPI i = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R金元宝#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新价格);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法重置轮回转世属性！");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, -Singleton<全局变量类>.I.六道轮回配置.刷新价格, 0))
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R金元宝#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新价格);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法重置轮回转世属性！");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
			}
			else if (Singleton<全局变量类>.I.六道轮回配置.刷新类型 == AllEnums.数值Type.银元宝)
			{
				if (P_0.user.背包数据.银元宝 < Singleton<全局变量类>.I.六道轮回配置.刷新价格)
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R银元宝#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新价格);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法重置轮回转世属性！");
					P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, 0, -Singleton<全局变量类>.I.六道轮回配置.刷新价格))
				{
					WdAPI i4 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R银元宝#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新价格);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法重置轮回转世属性！");
					P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
			}
			else if (Singleton<全局变量类>.I.六道轮回配置.刷新类型 == AllEnums.数值Type.灵气值)
			{
				if (P_0.user.存档数据.数值存档.灵气值 < Singleton<全局变量类>.I.六道轮回配置.刷新价格)
				{
					WdAPI i5 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你当前#R灵气值#n不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新价格);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法重置轮回转世属性！");
					P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				WdAPI i6 = Singleton<WdAPI>.I;
				string empty = string.Empty;
				int num = -Singleton<全局变量类>.I.六道轮回配置.刷新价格;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[");
				defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
				defaultInterpolatedStringHandler.AppendLiteral("]刷新消耗");
				i6.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, empty, AllEnums.指令Type.无, num, false, defaultInterpolatedStringHandler.ToStringAndClear());
			}
			六道轮回存档数据类2.已刷新次数++;
			六道轮回存档数据类2.转世属性列表[(int)六道轮回存档数据类2.转世阶段].转世属性 = Singleton<WdAPI>.I.qrjo9TWIdy(24, 29);
			int num2 = ((六道轮回存档数据类2.转世属性列表[(int)六道轮回存档数据类2.转世阶段].转世属性 == 29) ? 六道轮回列表类2.所相数值 : 六道轮回列表类2.单相数值);
			if (六道轮回存档数据类2.已刷新次数 < (int)(1 + 六道轮回存档数据类2.转世阶段) * 4)
			{
				六道轮回存档数据类2.转世属性列表[(int)六道轮回存档数据类2.转世阶段].属性数值 = Singleton<WdAPI>.I.qrjo9TWIdy(1, num2 / 2);
			}
			else
			{
				六道轮回存档数据类2.转世属性列表[(int)六道轮回存档数据类2.转世阶段].属性数值 = Singleton<WdAPI>.I.qrjo9TWIdy(1, num2);
			}
			WdAPI i7 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#Y");
			defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
			defaultInterpolatedStringHandler.AppendLiteral("#G轮回转世重置成功！");
			byte[] first = i7.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear());
			WdAPI i8 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 3);
			defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新价格);
			defaultInterpolatedStringHandler.AppendLiteral("#n");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新类型);
			defaultInterpolatedStringHandler.AppendLiteral("重置了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
			defaultInterpolatedStringHandler.AppendLiteral("#n的轮回转世属性！");
			P_0.C_Send(first.Concat(i8.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
			fsdw8chBuX(P_0, "轮回操作_打开");
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("六道轮回转属处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private async void rJlwBP7M5q(MyNATSocketClient P_0)
	{
		try
		{
			六道轮回存档数据类 当前存档方案 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.轮回转世数据.存档方案1 : P_0.user.存档数据.轮回转世数据.存档方案2);
			六道轮回列表类 当前轮回阶段 = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[(int)当前存档方案.转世阶段];
			while (P_0.user.存档数据.轮回转世数据.qkVIsPyWCW)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (Singleton<全局变量类>.I.六道轮回配置.刷新类型 == AllEnums.数值Type.金元宝)
				{
					if (P_0.user.背包数据.金元宝 < Singleton<全局变量类>.I.六道轮回配置.刷新价格)
					{
						P_0.user.存档数据.轮回转世数据.qkVIsPyWCW = false;
						WdAPI i = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你当前#R金元宝#n不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新价格);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法重置轮回转世属性！");
						P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					if (!DB.I.cAJNoOkab6(P_0, -Singleton<全局变量类>.I.六道轮回配置.刷新价格, 0))
					{
						P_0.user.存档数据.轮回转世数据.qkVIsPyWCW = false;
						WdAPI i2 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你当前#R金元宝#n不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新价格);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法重置轮回转世属性！");
						P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
				}
				else if (Singleton<全局变量类>.I.六道轮回配置.刷新类型 == AllEnums.数值Type.银元宝)
				{
					if (P_0.user.背包数据.银元宝 < Singleton<全局变量类>.I.六道轮回配置.刷新价格)
					{
						P_0.user.存档数据.轮回转世数据.qkVIsPyWCW = false;
						WdAPI i3 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你当前#R银元宝#n不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新价格);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法重置轮回转世属性！");
						P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					if (!DB.I.cAJNoOkab6(P_0, 0, -Singleton<全局变量类>.I.六道轮回配置.刷新价格))
					{
						P_0.user.存档数据.轮回转世数据.qkVIsPyWCW = false;
						WdAPI i4 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你当前#R银元宝#n不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新价格);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法重置轮回转世属性！");
						P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
				}
				else if (Singleton<全局变量类>.I.六道轮回配置.刷新类型 == AllEnums.数值Type.灵气值)
				{
					if (P_0.user.存档数据.数值存档.灵气值 < Singleton<全局变量类>.I.六道轮回配置.刷新价格)
					{
						P_0.user.存档数据.轮回转世数据.qkVIsPyWCW = false;
						WdAPI i5 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你当前#R灵气值#n不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新价格);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法重置轮回转世属性！");
						P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						break;
					}
					WdAPI i6 = Singleton<WdAPI>.I;
					string empty = string.Empty;
					int num = -Singleton<全局变量类>.I.六道轮回配置.刷新价格;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[");
					defaultInterpolatedStringHandler.AppendFormatted(当前存档方案.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("]刷新消耗");
					i6.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, empty, AllEnums.指令Type.无, num, false, defaultInterpolatedStringHandler.ToStringAndClear());
				}
				当前存档方案.已刷新次数++;
				当前存档方案.转世属性列表[(int)当前存档方案.转世阶段].转世属性 = Singleton<WdAPI>.I.qrjo9TWIdy(24, 29);
				int 转世属性 = 当前存档方案.转世属性列表[(int)当前存档方案.转世阶段].转世属性;
				int num2 = ((转世属性 == 29) ? 当前轮回阶段.所相数值 : 当前轮回阶段.单相数值);
				int num3 = ((当前存档方案.已刷新次数 >= (int)(1 + 当前存档方案.转世阶段) * 4) ? Singleton<WdAPI>.I.qrjo9TWIdy(1, num2) : Singleton<WdAPI>.I.qrjo9TWIdy(1, (num2 + 1) / 2));
				当前存档方案.转世属性列表[(int)当前存档方案.转世阶段].属性数值 = num3;
				if (转世属性 == 29)
				{
					if (num3 >= 当前轮回阶段.所相数值)
					{
						break;
					}
				}
				else if (num3 >= 当前轮回阶段.单相数值)
				{
					break;
				}
				WdAPI i7 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(当前存档方案.转世阶段);
				defaultInterpolatedStringHandler.AppendLiteral("#G轮回转世重置成功！");
				byte[] first = i7.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear());
				WdAPI i8 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新价格);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.刷新类型);
				defaultInterpolatedStringHandler.AppendLiteral("重置了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(当前存档方案.转世阶段);
				defaultInterpolatedStringHandler.AppendLiteral("#n的轮回转世属性！");
				P_0.C_Send(first.Concat(i8.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
				await Task.Delay(500);
				fsdw8chBuX(P_0, "轮回操作_打开");
			}
			P_0.user.存档数据.轮回转世数据.qkVIsPyWCW = false;
			fsdw8chBuX(P_0, "轮回操作_打开");
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("六道轮回自动转属处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void PFmwGGwDc3(MyNATSocketClient P_0)
	{
		try
		{
			六道轮回存档数据类 六道轮回存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.轮回转世数据.存档方案1 : P_0.user.存档数据.轮回转世数据.存档方案2);
			_ = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[(int)六道轮回存档数据类2.转世阶段];
			轮回转世属性存档 轮回转世属性存档2 = 六道轮回存档数据类2.转世属性列表[(int)六道轮回存档数据类2.转世阶段];
			六道轮回存档数据类2.已刷新次数 = 0;
			六道轮回存档数据类2.转世状态 = ((六道轮回存档数据类2.转世阶段 == AllEnums.六道Type.天道) ? AllEnums.轮回Type.已圆满 : AllEnums.轮回Type.未开始);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (EaewmWn7Ul())
			{
				P_0.user.存档数据.中州论道存档.jxpIgn1imh(GbewfdBZt4(轮回转世属性存档2.转世属性), 轮回转世属性存档2.属性数值, out var text);
				fuMNpgieFTYU3Wah53 i = Singleton<fuMNpgieFTYU3Wah53>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("prop/");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)GbewfdBZt4(轮回转世属性存档2.转世属性));
				i.WFU2WhwnC(P_0, defaultInterpolatedStringHandler.ToStringAndClear(), text);
			}
			else
			{
				WdAPI i2 = Singleton<WdAPI>.I;
				string empty = string.Empty;
				int 转世属性 = 轮回转世属性存档2.转世属性;
				int 属性数值 = 轮回转世属性存档2.属性数值;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[");
				defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
				defaultInterpolatedStringHandler.AppendLiteral("]完成消耗");
				i2.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, empty, (AllEnums.指令Type)转世属性, 属性数值, false, defaultInterpolatedStringHandler.ToStringAndClear());
			}
			WdAPI i3 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
			defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
			defaultInterpolatedStringHandler.AppendLiteral("轮回转世属性#G");
			defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性Type)轮回转世属性存档2.转世属性);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(轮回转世属性存档2.属性数值);
			defaultInterpolatedStringHandler.AppendLiteral(" 增加#n已经激活，请刷新人物面板查看！");
			P_0.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			if (六道轮回存档数据类2.转世阶段 != AllEnums.六道Type.天道)
			{
				六道轮回存档数据类2.转世阶段++;
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("六道轮回激活处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private static AllEnums.属性名字Type GbewfdBZt4(int P_0)
	{
		return P_0 switch
		{
			24 => AllEnums.属性名字Type.金相性, 
			25 => AllEnums.属性名字Type.木相性, 
			26 => AllEnums.属性名字Type.水相性, 
			27 => AllEnums.属性名字Type.火相性, 
			28 => AllEnums.属性名字Type.土相性, 
			29 => AllEnums.属性名字Type.所有相性, 
			_ => AllEnums.属性名字Type.无, 
		};
	}

	
	internal void eFpw6Wj89Z(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (!int.TryParse(P_1, out var result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result))
			{
				return;
			}
			if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的背包已满，无法使用。"));
				return;
			}
			if (!Singleton<WdAPI>.I.dSCoKmGWP9(P_0))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的宠物栏已满，无法使用。"));
				return;
			}
			if (EaewmWn7Ul())
			{
				k6kw2f50Ju(P_0, P_1);
				return;
			}
			六道轮回存档数据类 六道轮回存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.轮回转世数据.存档方案1 : P_0.user.存档数据.轮回转世数据.存档方案2);
			if (六道轮回存档数据类2.转世阶段 == AllEnums.六道Type.天道 && 六道轮回存档数据类2.转世状态 == AllEnums.轮回Type.已圆满)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("当前加点方案的六道轮回转世已经圆满，无法重复轮回转世！"));
				return;
			}
			P_0.S_Send(Singleton<WdAPI>.I.naeodnd6MY(result));
			六道轮回存档数据类2.已刷新次数 = 0;
			int 转世阶段 = (int)六道轮回存档数据类2.转世阶段;
			for (int i = 转世阶段; i < 6; i++)
			{
				if (转世阶段 > i)
				{
					六道轮回列表类 六道轮回列表类2 = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[i];
					AllEnums.属性Type 转世属性 = (AllEnums.属性Type)六道轮回存档数据类2.转世属性列表[i].转世属性;
					int 属性数值 = 六道轮回存档数据类2.转世属性列表[i].属性数值;
					if (转世属性 != AllEnums.属性Type.所有相性)
					{
						Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, (AllEnums.指令Type)六道轮回存档数据类2.转世属性列表[i].转世属性, -六道轮回存档数据类2.转世属性列表[i].属性数值, false, "[六道轮回]特效消耗");
						六道轮回存档数据类2.转世属性列表[i].转世属性 = 29;
						六道轮回存档数据类2.转世属性列表[i].属性数值 = 六道轮回列表类2.所相数值;
						Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, (AllEnums.指令Type)六道轮回存档数据类2.转世属性列表[i].转世属性, 六道轮回存档数据类2.转世属性列表[i].属性数值, false, "[六道轮回]属性增加");
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 5);
						defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
						defaultInterpolatedStringHandler.AppendLiteral("的转世属性已经从#G");
						defaultInterpolatedStringHandler.AppendFormatted(转世属性);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加#n调整为#G");
						defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性Type.所有相性);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类2.所相数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加#n");
						P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					else if (属性数值 != 六道轮回列表类2.所相数值)
					{
						Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, (AllEnums.指令Type)六道轮回存档数据类2.转世属性列表[i].转世属性, -六道轮回存档数据类2.转世属性列表[i].属性数值, false, "[六道轮回]特效消耗");
						六道轮回存档数据类2.转世属性列表[i].转世属性 = 29;
						六道轮回存档数据类2.转世属性列表[i].属性数值 = 六道轮回列表类2.所相数值;
						Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, (AllEnums.指令Type)六道轮回存档数据类2.转世属性列表[i].转世属性, 六道轮回存档数据类2.转世属性列表[i].属性数值, false, "[六道轮回]属性增加");
						WdAPI i3 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 5);
						defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
						defaultInterpolatedStringHandler.AppendLiteral("的转世属性已经从#G");
						defaultInterpolatedStringHandler.AppendFormatted(转世属性);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加#n调整为#G");
						defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性Type.所有相性);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类2.所相数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加#n");
						P_0.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
				}
				else
				{
					六道轮回列表类 六道轮回列表类3 = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[(int)六道轮回存档数据类2.转世阶段];
					六道轮回存档数据类2.转世属性列表[(int)六道轮回存档数据类2.转世阶段].转世属性 = 29;
					六道轮回存档数据类2.转世属性列表[(int)六道轮回存档数据类2.转世阶段].属性数值 = 六道轮回列表类3.所相数值;
					六道轮回存档数据类2.转世状态 = ((六道轮回存档数据类2.转世阶段 == AllEnums.六道Type.天道) ? AllEnums.轮回Type.已圆满 : AllEnums.轮回Type.未开始);
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, (AllEnums.指令Type)六道轮回存档数据类2.转世属性列表[(int)六道轮回存档数据类2.转世阶段].转世属性, 六道轮回列表类3.所相数值, false, "[六道轮回]属性增加");
					WdAPI i4 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("轮回转世属性#G");
					defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性Type.所有相性);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类3.所相数值);
					defaultInterpolatedStringHandler.AppendLiteral(" 增加#n已经激活，请刷新人物面板查看！");
					P_0.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					if (六道轮回存档数据类2.转世阶段 != AllEnums.六道Type.天道)
					{
						六道轮回存档数据类2.转世阶段++;
					}
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("使用特效道具处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void k6kw2f50Ju(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (!int.TryParse(P_1, out var result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result))
			{
				return;
			}
			六道轮回存档数据类 六道轮回存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.轮回转世数据.存档方案1 : P_0.user.存档数据.轮回转世数据.存档方案2);
			if (六道轮回存档数据类2.转世阶段 == AllEnums.六道Type.天道 && 六道轮回存档数据类2.转世状态 == AllEnums.轮回Type.已圆满)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("当前加点方案的六道轮回转世已经圆满，无法重复轮回转世！"));
				return;
			}
			P_0.S_Send(Singleton<WdAPI>.I.naeodnd6MY(result));
			六道轮回存档数据类2.已刷新次数 = 0;
			int 转世阶段 = (int)六道轮回存档数据类2.转世阶段;
			ConcurrentDictionary<string, string> concurrentDictionary = new ConcurrentDictionary<string, string>();
			for (int i = 转世阶段; i < 6; i++)
			{
				if (转世阶段 > i)
				{
					六道轮回列表类 六道轮回列表类2 = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[i];
					AllEnums.属性Type 转世属性 = (AllEnums.属性Type)六道轮回存档数据类2.转世属性列表[i].转世属性;
					int 属性数值 = 六道轮回存档数据类2.转世属性列表[i].属性数值;
					AllEnums.属性名字Type 属性名字Type = GbewfdBZt4(六道轮回存档数据类2.转世属性列表[i].转世属性);
					if (转世属性 != AllEnums.属性Type.所有相性)
					{
						P_0.user.存档数据.中州论道存档.jxpIgn1imh(属性名字Type, -属性数值, out var value);
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
						defaultInterpolatedStringHandler.AppendLiteral("prop/");
						defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)属性名字Type);
						if (concurrentDictionary.ContainsKey(defaultInterpolatedStringHandler.ToStringAndClear()))
						{
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
							defaultInterpolatedStringHandler.AppendLiteral("prop/");
							defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)属性名字Type);
							concurrentDictionary[defaultInterpolatedStringHandler.ToStringAndClear()] = value;
						}
						else
						{
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
							defaultInterpolatedStringHandler.AppendLiteral("prop/");
							defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)GbewfdBZt4(六道轮回存档数据类2.转世属性列表[i].转世属性));
							concurrentDictionary.TryAdd(defaultInterpolatedStringHandler.ToStringAndClear(), value);
						}
						六道轮回存档数据类2.转世属性列表[i].转世属性 = 29;
						六道轮回存档数据类2.转世属性列表[i].属性数值 = 六道轮回列表类2.所相数值;
						P_0.user.存档数据.中州论道存档.jxpIgn1imh(AllEnums.属性名字Type.所有相性, 六道轮回列表类2.所相数值, out value);
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
						defaultInterpolatedStringHandler.AppendLiteral("prop/");
						defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.all_polar);
						if (concurrentDictionary.ContainsKey(defaultInterpolatedStringHandler.ToStringAndClear()))
						{
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
							defaultInterpolatedStringHandler.AppendLiteral("prop/");
							defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.all_polar);
							concurrentDictionary[defaultInterpolatedStringHandler.ToStringAndClear()] = value;
						}
						else
						{
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
							defaultInterpolatedStringHandler.AppendLiteral("prop/");
							defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.all_polar);
							concurrentDictionary.TryAdd(defaultInterpolatedStringHandler.ToStringAndClear(), value);
						}
						WdAPI i2 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 5);
						defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
						defaultInterpolatedStringHandler.AppendLiteral("的转世属性已经从#G");
						defaultInterpolatedStringHandler.AppendFormatted(转世属性);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加#n调整为#G");
						defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性Type.所有相性);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类2.所相数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加#n");
						P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					else if (属性数值 < 六道轮回列表类2.所相数值)
					{
						P_0.user.存档数据.中州论道存档.jxpIgn1imh(AllEnums.属性名字Type.所有相性, 六道轮回列表类2.所相数值 - 属性数值, out var value2);
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
						defaultInterpolatedStringHandler.AppendLiteral("prop/");
						defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.all_polar);
						if (concurrentDictionary.ContainsKey(defaultInterpolatedStringHandler.ToStringAndClear()))
						{
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
							defaultInterpolatedStringHandler.AppendLiteral("prop/");
							defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.all_polar);
							concurrentDictionary[defaultInterpolatedStringHandler.ToStringAndClear()] = value2;
						}
						else
						{
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
							defaultInterpolatedStringHandler.AppendLiteral("prop/");
							defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.all_polar);
							concurrentDictionary.TryAdd(defaultInterpolatedStringHandler.ToStringAndClear(), value2);
						}
						六道轮回存档数据类2.转世属性列表[i].转世属性 = 29;
						六道轮回存档数据类2.转世属性列表[i].属性数值 = 六道轮回列表类2.所相数值;
						WdAPI i3 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 5);
						defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
						defaultInterpolatedStringHandler.AppendLiteral("的转世属性已经从#G");
						defaultInterpolatedStringHandler.AppendFormatted(转世属性);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(属性数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加#n调整为#G");
						defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性Type.所有相性);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类2.所相数值);
						defaultInterpolatedStringHandler.AppendLiteral(" 增加#n");
						P_0.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
				}
				else
				{
					六道轮回列表类 六道轮回列表类3 = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[(int)六道轮回存档数据类2.转世阶段];
					六道轮回存档数据类2.转世属性列表[(int)六道轮回存档数据类2.转世阶段].转世属性 = 29;
					六道轮回存档数据类2.转世属性列表[(int)六道轮回存档数据类2.转世阶段].属性数值 = 六道轮回列表类3.所相数值;
					六道轮回存档数据类2.转世状态 = ((六道轮回存档数据类2.转世阶段 == AllEnums.六道Type.天道) ? AllEnums.轮回Type.已圆满 : AllEnums.轮回Type.未开始);
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(AllEnums.属性名字Type.所有相性, 六道轮回列表类3.所相数值, out var value3);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.all_polar);
					if (concurrentDictionary.ContainsKey(defaultInterpolatedStringHandler.ToStringAndClear()))
					{
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
						defaultInterpolatedStringHandler.AppendLiteral("prop/");
						defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.all_polar);
						concurrentDictionary[defaultInterpolatedStringHandler.ToStringAndClear()] = value3;
					}
					else
					{
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
						defaultInterpolatedStringHandler.AppendLiteral("prop/");
						defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性标识Type.all_polar);
						concurrentDictionary.TryAdd(defaultInterpolatedStringHandler.ToStringAndClear(), value3);
					}
					WdAPI i4 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回存档数据类2.转世阶段);
					defaultInterpolatedStringHandler.AppendLiteral("轮回转世属性#G");
					defaultInterpolatedStringHandler.AppendFormatted(AllEnums.属性Type.所有相性);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(六道轮回列表类3.所相数值);
					defaultInterpolatedStringHandler.AppendLiteral(" 增加#n已经激活，请刷新人物面板查看！");
					P_0.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					if (六道轮回存档数据类2.转世阶段 != AllEnums.六道Type.天道)
					{
						六道轮回存档数据类2.转世阶段++;
					}
				}
			}
			List<string[]> list = new List<string[]>();
			foreach (KeyValuePair<string, string> item in concurrentDictionary)
			{
				list.Add(new string[2] { item.Key, item.Value });
			}
			Singleton<fuMNpgieFTYU3Wah53>.I.mMMfZ3LX2(P_0, list);
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("中州_使用特效道具处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public MbtVicwUkp5LuxTooFW()
	{
	}

	
	static MbtVicwUkp5LuxTooFW()
	{
		J9lwLcfQky = new AllEnums.数值Type[6]
		{
			AllEnums.数值Type.金元宝,
			AllEnums.数值Type.银元宝,
			AllEnums.数值Type.声望,
			AllEnums.数值Type.道行,
			AllEnums.数值Type.经验,
			AllEnums.数值Type.道具
		};
	}
}
