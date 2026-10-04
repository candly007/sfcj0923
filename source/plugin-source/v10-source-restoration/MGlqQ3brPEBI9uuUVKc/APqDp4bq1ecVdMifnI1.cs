using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace MGlqQ3brPEBI9uuUVKc;

internal class APqDp4bq1ecVdMifnI1 : Singleton<APqDp4bq1ecVdMifnI1>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public MyNATSocketClient X7PFXysbZe;

		
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		
		internal bool jBPFP9c0MA(融丹排行榜 x)
		{
			if (x.名字 == X7PFXysbZe.user.人物数据.昵称)
			{
				return x.GID == X7PFXysbZe.user.人物数据.GID;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass23_0()
		{
		}
	}

	private static int hTcJg7S33o;

	private static int[] N4JJDkQBnp;

	private static int[] afPJjb7NhJ;

	private static string dJgJlV9I4H;

	private static string q1PJ8nk78G;

	private static string T1eJIH7Ikb;

	private static string ej0JoRrlMi;

	private static string cEuJNhB2DX;

	private static string QF1Jiacd8w;

	private static string UMtJBHvwbM;

	internal static ConcurrentDictionary<AllEnums.荣丹Type, List<融丹奖池类>> MyOJG2GsQ2;

	internal static byte[] adiJf9U5pw;

	internal static byte[] qbiJ617QEH;

	private static object dl1J2sM5Ch;

	
	internal void h0sbZQi7MM()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("融丹配置类.json")))
			{
				Singleton<全局变量类>.I.融丹配置 = JsonConvert.DeserializeObject<融丹配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("融丹配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.融丹配置 = new 融丹配置类();
				Singleton<全局变量类>.I.融丹配置.各等奖份数组 = new int[6];
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("融丹配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.融丹配置, Formatting.Indented));
			}
			Singleton<全局变量类>.I.融丹配置.Is按照份数出 = true;
			Singleton<全局变量类>.I.融丹配置.Is校验累充点 = false;
			hTcJg7S33o = Singleton<全局变量类>.I.融丹配置.各等奖份数组[0] + Singleton<全局变量类>.I.融丹配置.各等奖份数组[1] + Singleton<全局变量类>.I.融丹配置.各等奖份数组[2] + Singleton<全局变量类>.I.融丹配置.各等奖份数组[3] + Singleton<全局变量类>.I.融丹配置.各等奖份数组[4] + Singleton<全局变量类>.I.融丹配置.各等奖份数组[5];
			N4JJDkQBnp[0] = ((Singleton<全局变量类>.I.融丹配置.各等奖份数组[0] > 0) ? (hTcJg7S33o / Singleton<全局变量类>.I.融丹配置.各等奖份数组[0]) : 0);
			N4JJDkQBnp[1] = ((Singleton<全局变量类>.I.融丹配置.各等奖份数组[1] > 0) ? (hTcJg7S33o / Singleton<全局变量类>.I.融丹配置.各等奖份数组[1]) : 0);
			N4JJDkQBnp[2] = ((Singleton<全局变量类>.I.融丹配置.各等奖份数组[2] > 0) ? (hTcJg7S33o / Singleton<全局变量类>.I.融丹配置.各等奖份数组[2]) : 0);
			N4JJDkQBnp[3] = ((Singleton<全局变量类>.I.融丹配置.各等奖份数组[3] > 0) ? (hTcJg7S33o / Singleton<全局变量类>.I.融丹配置.各等奖份数组[3]) : 0);
			N4JJDkQBnp[4] = ((Singleton<全局变量类>.I.融丹配置.各等奖份数组[4] > 0) ? (hTcJg7S33o / Singleton<全局变量类>.I.融丹配置.各等奖份数组[4]) : 0);
			N4JJDkQBnp[5] = ((Singleton<全局变量类>.I.融丹配置.各等奖份数组[5] > 0) ? (hTcJg7S33o / Singleton<全局变量类>.I.融丹配置.各等奖份数组[5]) : 0);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 4);
			defaultInterpolatedStringHandler.AppendLiteral("每次熔炼需要花费#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.消耗数量);
			defaultInterpolatedStringHandler.AppendLiteral("#n");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.消耗类型);
			defaultInterpolatedStringHandler.AppendLiteral("，您正准备熔炼#R1#n次聚元仙丹，需要花费#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.消耗数量);
			defaultInterpolatedStringHandler.AppendLiteral("#n");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.消耗类型);
			defaultInterpolatedStringHandler.AppendLiteral("，确定熔炼吗？");
			cEuJNhB2DX = defaultInterpolatedStringHandler.ToStringAndClear();
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 4);
			defaultInterpolatedStringHandler.AppendLiteral("每次熔炼需要花费#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.消耗数量);
			defaultInterpolatedStringHandler.AppendLiteral("#n");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.消耗类型);
			defaultInterpolatedStringHandler.AppendLiteral("，您正准备熔炼#R10#n次聚元仙丹，需要花费#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.消耗数量 * 10);
			defaultInterpolatedStringHandler.AppendLiteral("#n");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.消耗类型);
			defaultInterpolatedStringHandler.AppendLiteral("，确定熔炼吗？");
			QF1Jiacd8w = defaultInterpolatedStringHandler.ToStringAndClear();
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 4);
			defaultInterpolatedStringHandler.AppendLiteral("每次熔炼需要花费#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.消耗数量);
			defaultInterpolatedStringHandler.AppendLiteral("#n");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.消耗类型);
			defaultInterpolatedStringHandler.AppendLiteral("，您正准备熔炼#R50#n次聚元仙丹，需要花费#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.消耗数量 * 50);
			defaultInterpolatedStringHandler.AppendLiteral("#n");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.消耗类型);
			defaultInterpolatedStringHandler.AppendLiteral("，确定熔炼吗？");
			UMtJBHvwbM = defaultInterpolatedStringHandler.ToStringAndClear();
			dJgJlV9I4H = string.Empty;
			q1PJ8nk78G = string.Empty;
			T1eJIH7Ikb = string.Empty;
			ej0JoRrlMi = string.Empty;
			Singleton<全局变量类>.I.融丹配置.奖池.Sort();
			Singleton<全局变量类>.I.融丹配置.奖池.Reverse();
			MyOJG2GsQ2.Clear();
			afPJjb7NhJ[0] = 0;
			afPJjb7NhJ[1] = 0;
			afPJjb7NhJ[2] = 0;
			afPJjb7NhJ[3] = 0;
			afPJjb7NhJ[4] = 0;
			afPJjb7NhJ[5] = 0;
			for (int i = 0; i < Singleton<全局变量类>.I.融丹配置.奖池.Count; i++)
			{
				if (Singleton<全局变量类>.I.融丹配置.奖池[i].等级 == AllEnums.荣丹Type.特等奖)
				{
					afPJjb7NhJ[0] += Singleton<全局变量类>.I.融丹配置.奖池[i].概率;
					dJgJlV9I4H = dJgJlV9I4H + ((!string.IsNullOrWhiteSpace(dJgJlV9I4H)) ? "、" : string.Empty) + Singleton<全局变量类>.I.融丹配置.奖池[i].名字;
				}
				else if (Singleton<全局变量类>.I.融丹配置.奖池[i].等级 == AllEnums.荣丹Type.一等奖)
				{
					afPJjb7NhJ[1] += Singleton<全局变量类>.I.融丹配置.奖池[i].概率;
					q1PJ8nk78G = q1PJ8nk78G + ((!string.IsNullOrWhiteSpace(q1PJ8nk78G)) ? "、" : string.Empty) + Singleton<全局变量类>.I.融丹配置.奖池[i].名字;
				}
				else if (Singleton<全局变量类>.I.融丹配置.奖池[i].等级 == AllEnums.荣丹Type.二等奖)
				{
					afPJjb7NhJ[2] += Singleton<全局变量类>.I.融丹配置.奖池[i].概率;
					T1eJIH7Ikb = T1eJIH7Ikb + ((!string.IsNullOrWhiteSpace(T1eJIH7Ikb)) ? "、" : string.Empty) + Singleton<全局变量类>.I.融丹配置.奖池[i].名字;
				}
				else if (Singleton<全局变量类>.I.融丹配置.奖池[i].等级 == AllEnums.荣丹Type.三等奖)
				{
					afPJjb7NhJ[3] += Singleton<全局变量类>.I.融丹配置.奖池[i].概率;
					ej0JoRrlMi = ej0JoRrlMi + ((!string.IsNullOrWhiteSpace(ej0JoRrlMi)) ? "、" : string.Empty) + Singleton<全局变量类>.I.融丹配置.奖池[i].名字;
				}
				else if (Singleton<全局变量类>.I.融丹配置.奖池[i].等级 == AllEnums.荣丹Type.四等奖)
				{
					afPJjb7NhJ[4] += Singleton<全局变量类>.I.融丹配置.奖池[i].概率;
				}
				else if (Singleton<全局变量类>.I.融丹配置.奖池[i].等级 == AllEnums.荣丹Type.参与奖)
				{
					afPJjb7NhJ[5] += Singleton<全局变量类>.I.融丹配置.奖池[i].概率;
				}
				if (MyOJG2GsQ2.ContainsKey(Singleton<全局变量类>.I.融丹配置.奖池[i].等级))
				{
					MyOJG2GsQ2[Singleton<全局变量类>.I.融丹配置.奖池[i].等级].Add(Singleton<全局变量类>.I.融丹配置.奖池[i]);
					continue;
				}
				MyOJG2GsQ2.TryAdd(Singleton<全局变量类>.I.融丹配置.奖池[i].等级, new List<融丹奖池类> { Singleton<全局变量类>.I.融丹配置.奖池[i] });
			}
		}
		catch (Exception ex)
		{
			Log.Error("融丹配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void QR7btPsog4()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("融丹配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.融丹配置, Formatting.Indented));
			Log.Debug("融丹配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("融丹配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string UD9bASX4uS()
	{
		h0sbZQi7MM();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.融丹配置, Formatting.Indented);
	}

	
	public void hPVbzSgvsu(string P_0)
	{
		Singleton<全局变量类>.I.融丹配置 = JsonConvert.DeserializeObject<融丹配置类>(P_0);
		QR7btPsog4();
	}

	
	internal void SSAJuCLMVQ(MyNATSocketClient P_0)
	{
		if ((Singleton<全局变量类>.I.验证client.授权配置.IsVip || 全局变量类.Is调试) && Singleton<全局变量类>.I.融丹配置.功能开关 && Singleton<全局变量类>.I.融丹配置.Is开通图标)
		{
			P_0.C_Send(adiJf9U5pw);
		}
	}

	
	internal void kSGJw7utSV(MyNATSocketClient P_0)
	{
		if ((Singleton<全局变量类>.I.验证client.授权配置.IsVip || 全局变量类.Is调试) && Singleton<全局变量类>.I.融丹配置.功能开关)
		{
			int num = (int)Singleton<ByteAPI>.I.取时间戳();
			if (num >= (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.融丹配置.开始时间) && num <= (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.融丹配置.到期时间))
			{
				P_0.C_Send(qbiJ617QEH);
				return;
			}
		}
		P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("本期熔炼仙丹已经结束！"));
	}

	
	internal void JTvJbdsgAc(MyNATSocketClient P_0, short P_1, int P_2)
	{
		int num = (int)Singleton<ByteAPI>.I.取时间戳();
		if (num < (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.融丹配置.开始时间) || num > (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.融丹配置.结束时间))
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("本期熔炼仙丹已经结束！"));
			return;
		}
		P_2 = (Singleton<全局变量类>.I.融丹配置.Is转换元宝 ? P_2 : 0);
		switch (P_1)
		{
		case 1:
		{
			WdAPI i3 = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[@确定/荣丹请求_熔炼_");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:");
			defaultInterpolatedStringHandler.AppendFormatted(cEuJNhB2DX);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			P_0.C_Send(i3.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
			break;
		}
		case 10:
		{
			WdAPI i2 = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[@确定/荣丹请求_熔炼_");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:");
			defaultInterpolatedStringHandler.AppendFormatted(QF1Jiacd8w);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			P_0.C_Send(i2.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
			break;
		}
		case 50:
		{
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[@确定/荣丹请求_熔炼_");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:");
			defaultInterpolatedStringHandler.AppendFormatted(UMtJBHvwbM);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			P_0.C_Send(i.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
			break;
		}
		}
	}

	
	internal void YLjJJjSlWw(MyNATSocketClient P_0)
	{
		StringBuilder stringBuilder = new StringBuilder("到现在为止，本区组熔炼仙丹数量排名如下：");
		List<融丹排行榜> list = NulJKTBv0Z();
		StringBuilder stringBuilder2;
		StringBuilder.AppendInterpolatedStringHandler handler;
		for (int i = 0; i < list.Count; i++)
		{
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(12, 3, stringBuilder2);
			handler.AppendLiteral("#r第");
			handler.AppendFormatted(i + 1);
			handler.AppendLiteral("名：#Y");
			handler.AppendFormatted(list[i].名字);
			handler.AppendLiteral("（");
			handler.AppendFormatted(list[i].次数);
			handler.AppendLiteral("次）#n");
			stringBuilder3.Append(ref handler);
		}
		stringBuilder2 = stringBuilder;
		StringBuilder stringBuilder4 = stringBuilder2;
		handler = new StringBuilder.AppendInterpolatedStringHandler(32, 1, stringBuilder2);
		handler.AppendLiteral("#r到#R");
		handler.AppendFormatted(Singleton<ByteAPI>.I.取时间文本(Singleton<全局变量类>.I.融丹配置.结束时间));
		handler.AppendLiteral("#n活动结束时，位于排名中的玩家可领取相应的排名奖励。");
		stringBuilder4.Append(ref handler);
		for (int j = 0; j < Singleton<全局变量类>.I.融丹配置.奖励列表.Count; j++)
		{
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder5 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(17, 3, stringBuilder2);
			handler.AppendLiteral("#r#R第");
			handler.AppendFormatted((AllEnums.大写Type)(j + 1));
			handler.AppendLiteral("奖励：#Y");
			handler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.奖励列表[j].奖励内容);
			handler.AppendLiteral("#n×#Y");
			handler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.奖励列表[j].奖励数量);
			handler.AppendLiteral("#n");
			stringBuilder5.Append(ref handler);
		}
		P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, 0, string.Empty, stringBuilder.ToString()));
	}

	
	internal List<融丹排行榜> NulJKTBv0Z()
	{
		List<融丹排行榜> list = new List<融丹排行榜>();
		List<角色存档数据类> list2 = Singleton<全局变量类>.I.角色存档表.Values.ToList().FindAll( (角色存档数据类 x) => x.融丹存档.总融丹次数 > 0);
		for (int num = 0; num < list2.Count; num++)
		{
			list.Add(new 融丹排行榜
			{
				名字 = list2[num].昵称,
				GID = list2[num].GID,
				次数 = list2[num].融丹存档.总融丹次数
			});
		}
		list.Sort();
		list.Reverse();
		return list.Take(Singleton<全局变量类>.I.融丹配置.奖励列表.Count).ToList();
	}

	
	internal void h0oJRdZfIg(MyNATSocketClient P_0)
	{
		int num = fpfJWwxiNx();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 2);
		defaultInterpolatedStringHandler.AppendLiteral("到现在为止，已经熔炼了#R");
		defaultInterpolatedStringHandler.AppendFormatted(num);
		defaultInterpolatedStringHandler.AppendLiteral("#n次聚元仙丹，还有#R");
		defaultInterpolatedStringHandler.AppendFormatted(hTcJg7S33o - num);
		defaultInterpolatedStringHandler.AppendLiteral("#n次尚未熔炼。");
		StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
		StringBuilder stringBuilder2 = stringBuilder;
		StringBuilder stringBuilder3 = stringBuilder2;
		StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 3, stringBuilder2);
		handler.AppendLiteral("#r本期三等奖共#R");
		handler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.各等奖份数组[3]);
		handler.AppendLiteral("#n份，已经产生了#R");
		handler.AppendFormatted(Singleton<全局变量类>.I.全服共享存档数据.已融丹次数[3]);
		handler.AppendLiteral("#n份，奖品为");
		handler.AppendFormatted(ej0JoRrlMi);
		handler.AppendLiteral("；");
		stringBuilder3.Append(ref handler);
		stringBuilder2 = stringBuilder;
		StringBuilder stringBuilder4 = stringBuilder2;
		handler = new StringBuilder.AppendInterpolatedStringHandler(29, 3, stringBuilder2);
		handler.AppendLiteral("#r本期二等奖共#R");
		handler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.各等奖份数组[2]);
		handler.AppendLiteral("#n份，已经产生了#R");
		handler.AppendFormatted(Singleton<全局变量类>.I.全服共享存档数据.已融丹次数[2]);
		handler.AppendLiteral("#n份，奖品为");
		handler.AppendFormatted(T1eJIH7Ikb);
		handler.AppendLiteral("；");
		stringBuilder4.Append(ref handler);
		stringBuilder2 = stringBuilder;
		StringBuilder stringBuilder5 = stringBuilder2;
		handler = new StringBuilder.AppendInterpolatedStringHandler(29, 3, stringBuilder2);
		handler.AppendLiteral("#r本期一等奖共#R");
		handler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.各等奖份数组[1]);
		handler.AppendLiteral("#n份，已经产生了#R");
		handler.AppendFormatted(Singleton<全局变量类>.I.全服共享存档数据.已融丹次数[1]);
		handler.AppendLiteral("#n份，奖品为");
		handler.AppendFormatted(q1PJ8nk78G);
		handler.AppendLiteral("；");
		stringBuilder5.Append(ref handler);
		stringBuilder2 = stringBuilder;
		StringBuilder stringBuilder6 = stringBuilder2;
		handler = new StringBuilder.AppendInterpolatedStringHandler(29, 3, stringBuilder2);
		handler.AppendLiteral("#r本期特等奖共#R");
		handler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.各等奖份数组[0]);
		handler.AppendLiteral("#n份，已经产生了#R");
		handler.AppendFormatted(Singleton<全局变量类>.I.全服共享存档数据.已融丹次数[0]);
		handler.AppendLiteral("#n份，奖品为");
		handler.AppendFormatted(dJgJlV9I4H);
		handler.AppendLiteral("；");
		stringBuilder6.Append(ref handler);
		P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, 0, string.Empty, stringBuilder.ToString()));
	}

	
	internal void PGOJdAtPYp(MyNATSocketClient P_0)
	{
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals14 = new _003C_003Ec__DisplayClass23_0();
		CS_0024_003C_003E8__locals14.X7PFXysbZe = P_0;
		int num = (int)Singleton<ByteAPI>.I.取时间戳();
		if (num > (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.融丹配置.开始时间) && num < (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.融丹配置.结束时间))
		{
			CS_0024_003C_003E8__locals14.X7PFXysbZe.C_Send(Singleton<WdAPI>.I.提示_中心提醒("对不起，你当前没有排名奖励可领取！"));
		}
		else if (num > (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.融丹配置.结束时间) && num < (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.融丹配置.到期时间))
		{
			int num2 = NulJKTBv0Z().FindIndex( (融丹排行榜 x) => x.名字 == CS_0024_003C_003E8__locals14.X7PFXysbZe.user.人物数据.昵称 && x.GID == CS_0024_003C_003E8__locals14.X7PFXysbZe.user.人物数据.GID);
			if (num2 < 0 || num2 > Singleton<全局变量类>.I.融丹配置.奖励列表.Count - 1)
			{
				CS_0024_003C_003E8__locals14.X7PFXysbZe.C_Send(Singleton<WdAPI>.I.提示_中心提醒("对不起，你当前没有排名奖励可领取！"));
				return;
			}
			if (CS_0024_003C_003E8__locals14.X7PFXysbZe.user.存档数据.融丹存档.Is领奖)
			{
				CS_0024_003C_003E8__locals14.X7PFXysbZe.C_Send(Singleton<WdAPI>.I.提示_中心提醒("排名奖励已领取！"));
				return;
			}
			if (!Singleton<WdAPI>.I.dSCoKmGWP9(CS_0024_003C_003E8__locals14.X7PFXysbZe) && (Singleton<全局变量类>.I.融丹配置.奖励列表[num2].奖励类型 == AllEnums.数值Type.宠物 || Singleton<全局变量类>.I.融丹配置.奖励列表[num2].奖励类型 == AllEnums.数值Type.坐骑))
			{
				CS_0024_003C_003E8__locals14.X7PFXysbZe.C_Send(Singleton<WdAPI>.I.提示_中心提醒("宠物栏已满，无法领取奖励！"));
				return;
			}
			CS_0024_003C_003E8__locals14.X7PFXysbZe.user.存档数据.融丹存档.Is领奖 = true;
			WdAPI i = Singleton<WdAPI>.I;
			MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals14.X7PFXysbZe;
			AllEnums.数值Type 奖励类型 = Singleton<全局变量类>.I.融丹配置.奖励列表[num2].奖励类型;
			string 奖励内容 = Singleton<全局变量类>.I.融丹配置.奖励列表[num2].奖励内容;
			int 奖励数量 = Singleton<全局变量类>.I.融丹配置.奖励列表[num2].奖励数量;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("发放[");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals14.X7PFXysbZe.user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("]熔炼仙丹排名第");
			defaultInterpolatedStringHandler.AppendFormatted((AllEnums.大写Type)(num2 + 1));
			defaultInterpolatedStringHandler.AppendLiteral("的奖励");
			i.AKEoOlhFAx(myNATSocketClient, 奖励类型, 奖励内容, 奖励数量, true, defaultInterpolatedStringHandler.ToStringAndClear());
			MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals14.X7PFXysbZe;
			WdAPI i2 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
			defaultInterpolatedStringHandler.AppendLiteral("你领取了熔炼仙丹排名第");
			defaultInterpolatedStringHandler.AppendFormatted((AllEnums.大写Type)(num2 + 1));
			defaultInterpolatedStringHandler.AppendLiteral("的奖励。");
			myNATSocketClient2.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
		}
		else
		{
			CS_0024_003C_003E8__locals14.X7PFXysbZe.C_Send(Singleton<WdAPI>.I.提示_中心提醒("本期熔炼仙丹已经结束！"));
		}
	}

	
	internal async Task ACsJsluSp7(MyNATSocketClient P_0, string P_1)
	{
		_ = 2;
		try
		{
			if (P_1 == "荣丹请求_熔炼_打开")
			{
				kSGJw7utSV(P_0);
				return;
			}
			int num = (int)Singleton<ByteAPI>.I.取时间戳();
			if (num < (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.融丹配置.开始时间) || num > (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.融丹配置.结束时间))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("本期熔炼仙丹已经结束！"));
				return;
			}
			int 已融次数 = fpfJWwxiNx();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 2);
			defaultInterpolatedStringHandler.AppendLiteral("到现在为止，已经熔炼了#R");
			defaultInterpolatedStringHandler.AppendFormatted(已融次数);
			defaultInterpolatedStringHandler.AppendLiteral("#n次聚元仙丹，还有#R");
			defaultInterpolatedStringHandler.AppendFormatted(hTcJg7S33o - 已融次数);
			defaultInterpolatedStringHandler.AppendLiteral("#n次尚未熔炼。");
			new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
			string[] array = P_1.Replace("荣丹请求_熔炼_", string.Empty).Split("_");
			if (array.Length != 2 || !int.TryParse(array[0], out var 次数) || (次数 != 1 && 次数 != 10 && 次数 != 50) || !int.TryParse(array[1], out var 转换))
			{
				return;
			}
			if (hTcJg7S33o - 已融次数 < 次数)
			{
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
				defaultInterpolatedStringHandler.AppendLiteral("聚元仙丹的熔炼次数不足#R");
				defaultInterpolatedStringHandler.AppendFormatted(次数);
				defaultInterpolatedStringHandler.AppendLiteral("#n次，无法进行熔炼仙丹。");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			转换 = (Singleton<全局变量类>.I.融丹配置.Is转换元宝 ? 转换 : 0);
			int num2 = Singleton<全局变量类>.I.融丹配置.消耗数量 * 次数;
			switch (Singleton<全局变量类>.I.融丹配置.消耗类型)
			{
			case AllEnums.数值Type.金元宝:
				if (P_0.user.背包数据.金元宝 < num2)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("金元宝不足，无法进行熔炼仙丹。"));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, -num2, 0))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("金元宝扣除失败，无法进行熔炼仙丹。"));
					return;
				}
				break;
			case AllEnums.数值Type.银元宝:
				if (P_0.user.背包数据.银元宝 < num2)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("银元宝不足，无法进行熔炼仙丹。"));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, 0, -num2))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("银元宝扣除失败，无法进行熔炼仙丹。"));
					return;
				}
				break;
			case AllEnums.数值Type.金钱:
				if (P_0.user.背包数据.金钱 < num2)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("游戏币不足，无法进行熔炼仙丹。"));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -num2);
				break;
			case AllEnums.数值Type.声望:
				if (P_0.user.属性数据.声望 < num2)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("声望不足，无法进行熔炼仙丹。"));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.reputation, -num2);
				break;
			case AllEnums.数值Type.奇宝点:
				if (P_0.user.存档数据.奇宝斋存档.奇宝斋余额 < num2)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("奇宝点不足，无法进行熔炼仙丹。"));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, -num2, false, "[荣丹]消耗");
				break;
			case AllEnums.数值Type.论道点:
				if (P_0.user.存档数据.数值存档.论道点 < num2)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("论道点不足，无法进行熔炼仙丹。"));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.论道点, string.Empty, AllEnums.指令Type.无, -num2, false, "[荣丹]消耗");
				break;
			case AllEnums.数值Type.灵气值:
				if (P_0.user.存档数据.数值存档.灵气值 < num2)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("灵气值不足，无法进行熔炼仙丹。"));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -num2, false, "[荣丹]消耗");
				break;
			}
			P_0.user.存档数据.融丹存档.总融丹次数 += 次数;
			WdAPI i2 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 3);
			defaultInterpolatedStringHandler.AppendLiteral("你花费#R");
			defaultInterpolatedStringHandler.AppendFormatted(num2);
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.融丹配置.消耗类型);
			defaultInterpolatedStringHandler.AppendLiteral("#n熔炼了#R");
			defaultInterpolatedStringHandler.AppendFormatted(次数);
			defaultInterpolatedStringHandler.AppendLiteral("#n次聚元仙丹。");
			P_0.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			封包_写 写 = new 封包_写();
			写.写字节集(new byte[3] { 253, 205, 2 }, hasCount: false, 0);
			写.写短整数型((short)次数, reverse: true);
			List<融丹奖池类> value = null;
			new List<融丹奖池类>();
			int 总转换元宝 = 0;
			StringBuilder 奖励后缀 = new StringBuilder();
			Dictionary<int, bool> 随机等奖字典 = new Dictionary<int, bool>();
			随机等奖字典.TryAdd(0, value: false);
			随机等奖字典.TryAdd(1, value: false);
			随机等奖字典.TryAdd(2, value: false);
			随机等奖字典.TryAdd(3, value: false);
			随机等奖字典.TryAdd(4, value: false);
			for (int j = 0; j < 次数; j++)
			{
				int num3 = 0;
				融丹奖池类 当前奖励 = null;
				奖励后缀.Clear();
				随机等奖字典[0] = false;
				随机等奖字典[1] = false;
				随机等奖字典[2] = false;
				随机等奖字典[3] = false;
				随机等奖字典[4] = false;
				P_0.user.存档数据.融丹存档.现融丹次数++;
				if (Singleton<全局变量类>.I.融丹配置.Is按照份数出)
				{
					while (!随机等奖字典.Values.All( (bool x) => x))
					{
						int num4 = Singleton<WdAPI>.I.qrjo9TWIdy(0, 4);
						随机等奖字典[num4] = true;
						int num5 = Singleton<全局变量类>.I.全服共享存档数据.已融丹次数[num4];
						int num6 = N4JJDkQBnp[num4] * (num5 + 1);
						int num7 = Singleton<WdAPI>.I.qrjo9TWIdy((num6 > 8) ? (num6 - 8) : (num6 / 2), num6);
						if (num5 < Singleton<全局变量类>.I.融丹配置.各等奖份数组[num4] && 已融次数 >= num7 && afPJjb7NhJ[num4] > 0 && MyOJG2GsQ2.TryGetValue((AllEnums.荣丹Type)num4, out value) && value.Count > 0)
						{
							int num8 = Singleton<WdAPI>.I.qrjo9TWIdy(1, afPJjb7NhJ[num4]);
							foreach (融丹奖池类 item in value)
							{
								num3 += item.概率;
								if (num8 <= num3)
								{
									当前奖励 = item;
									break;
								}
							}
						}
						if (当前奖励 != null)
						{
							break;
						}
					}
					if (当前奖励 == null)
					{
						int num5 = Singleton<全局变量类>.I.全服共享存档数据.已融丹次数[5];
						if (num5 < Singleton<全局变量类>.I.融丹配置.各等奖份数组[5] && afPJjb7NhJ[5] > 0 && MyOJG2GsQ2.TryGetValue(AllEnums.荣丹Type.参与奖, out value) && value.Count > 0)
						{
							int num8 = Singleton<WdAPI>.I.qrjo9TWIdy(1, afPJjb7NhJ[5]);
							num3 = 0;
							foreach (融丹奖池类 item2 in value)
							{
								num3 += item2.概率;
								if (num8 <= num3)
								{
									当前奖励 = item2;
									break;
								}
							}
						}
					}
				}
				if (当前奖励 == null)
				{
					Log.Error("账号：" + P_0.user.人物数据.账号 + " 融丹：空奖励");
					continue;
				}
				lock (dl1J2sM5Ch)
				{
					Singleton<全局变量类>.I.全服共享存档数据.已融丹次数[(int)当前奖励.等级]++;
					已融次数 = fpfJWwxiNx();
				}
				if (转换 == 1 && 当前奖励.等级 >= AllEnums.荣丹Type.二等奖 && 当前奖励.价值 <= 500)
				{
					写.写字节集(new byte[9] { 6, 10, 0, 0, 0, 0, 0, 0, 1 }, hasCount: false, 0);
					总转换元宝 += 当前奖励.价值 / 10;
				}
				else
				{
					if (当前奖励.类型 == AllEnums.数值Type.道具)
					{
						写.写字节型((int)(当前奖励.等级 + 1));
						写.写字节型(3);
						写.写文本型((当前奖励.名字 == "融丹专用经验包") ? "经验奖励" : ((当前奖励.名字 == "融丹专用道行包") ? "道行奖励" : 当前奖励.名字), hasCount: true, 0);
						写.写字节集(new byte[5] { 0, 0, 0, 0, 1 }, hasCount: false, 0);
					}
					else
					{
						写.写字节型((int)(当前奖励.等级 + 1));
						写.写字节型(3);
						switch (当前奖励.类型)
						{
						case AllEnums.数值Type.等级:
							写.写文本型("等级奖励", hasCount: true, 0);
							break;
						case AllEnums.数值Type.道行:
							写.写文本型("道行奖励", hasCount: true, 0);
							break;
						case AllEnums.数值Type.经验:
							写.写文本型("经验奖励", hasCount: true, 0);
							break;
						case AllEnums.数值Type.声望:
							写.写文本型("声望", hasCount: true, 0);
							break;
						case AllEnums.数值Type.战绩:
							写.写文本型("战绩", hasCount: true, 0);
							break;
						case AllEnums.数值Type.金元宝:
							写.写文本型("金元宝", hasCount: true, 0);
							break;
						case AllEnums.数值Type.银元宝:
							写.写文本型("银元宝奖励", hasCount: true, 0);
							break;
						case AllEnums.数值Type.金钱:
							写.写文本型("金钱奖励", hasCount: true, 0);
							break;
						case AllEnums.数值Type.累充点:
							写.写文本型("累充点", hasCount: true, 0);
							break;
						case AllEnums.数值Type.体力:
							写.写文本型("体力奖励", hasCount: true, 0);
							break;
						case AllEnums.数值Type.南极点:
							写.写文本型("南极点", hasCount: true, 0);
							break;
						case AllEnums.数值Type.代金券:
							写.写文本型("代金券奖励", hasCount: true, 0);
							break;
						case AllEnums.数值Type.宠物:
							写.写文本型(当前奖励.名字, hasCount: true, 0);
							break;
						case AllEnums.数值Type.坐骑:
							写.写文本型(当前奖励.名字, hasCount: true, 0);
							break;
						case AllEnums.数值Type.奇宝点:
							写.写文本型("奇宝点", hasCount: true, 0);
							break;
						case AllEnums.数值Type.灵气值:
							写.写文本型("灵气值", hasCount: true, 0);
							break;
						case AllEnums.数值Type.论道点:
							写.写文本型("论道点", hasCount: true, 0);
							break;
						}
						写.写字节集(new byte[5] { 0, 0, 0, 0, 1 }, hasCount: false, 0);
					}
					int num9 = Singleton<WdAPI>.I.qrjo9TWIdy(当前奖励.数量区间[0], 当前奖励.数量区间[1]);
					if (当前奖励.类型 == AllEnums.数值Type.经验 && Singleton<全局变量类>.I.融丹配置.Is经验消减)
					{
						num9 = Singleton<WdAPI>.I.qrjo9TWIdy(P_0.user.属性数据.等级 * P_0.user.属性数据.等级 * 10, P_0.user.属性数据.等级 * P_0.user.属性数据.等级 * 20);
					}
					else if (当前奖励.类型 == AllEnums.数值Type.道行 && Singleton<全局变量类>.I.融丹配置.Is道行消减)
					{
						num9 = WdAPI.tfAoVvpVVT(P_0.user.属性数据.等级, P_0.user.属性数据.道行);
					}
					StringBuilder stringBuilder = 奖励后缀;
					stringBuilder.Append(await Singleton<WdAPI>.I.AKEoOlhFAx(P_0, 当前奖励.类型, 当前奖励.名字, num9, true, "发放[" + P_0.user.人物数据.昵称 + "]荣丹奖励"));
					if (当前奖励.等级 <= AllEnums.荣丹Type.一等奖)
					{
						Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
						if (client频道事件 != null)
						{
							WdAPI i3 = Singleton<WdAPI>.I;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(112, 3);
							defaultInterpolatedStringHandler.AppendLiteral("熔炼仙丹，证道修行！恭喜！恭喜！#Y");
							defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
							defaultInterpolatedStringHandler.AppendLiteral("#n在新服熔炼仙丹活动中竟然幸运地中了");
							defaultInterpolatedStringHandler.AppendFormatted(当前奖励.等级);
							defaultInterpolatedStringHandler.AppendLiteral("！");
							defaultInterpolatedStringHandler.AppendFormatted(奖励后缀);
							defaultInterpolatedStringHandler.AppendLiteral("，真是好运气啊！本次活动大礼多多，大家快打开#@互动中心|Open:InteractionCenterDlg#@选择#Y熔炼仙丹#n图标参与活动吧！");
							client频道事件(i3.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "系统", AllEnums.频道Type.系统));
						}
					}
				}
				await Task.Delay(10);
			}
			if (总转换元宝 > 0)
			{
				await Singleton<WdAPI>.I.AKEoOlhFAx(P_0, AllEnums.数值Type.银元宝, string.Empty, 总转换元宝, true);
			}
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写2.写入数据(写.取数据(), hasCount: true, 1, reverse: true);
			P_0.C_Send(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("融丹抽取奖励事件处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public void oY7JUm7D0t()
	{
		Singleton<全局变量类>.I.全服共享存档数据.已融丹次数 = new int[6];
		foreach (角色存档数据类 value in Singleton<全局变量类>.I.角色存档表.Values)
		{
			value.融丹存档.总融丹次数 = 0;
			value.融丹存档.现融丹次数 = 0;
			value.融丹存档.Is领奖 = false;
		}
	}

	
	public static int fpfJWwxiNx()
	{
		return Singleton<全局变量类>.I.全服共享存档数据.已融丹次数[0] + Singleton<全局变量类>.I.全服共享存档数据.已融丹次数[1] + Singleton<全局变量类>.I.全服共享存档数据.已融丹次数[2] + Singleton<全局变量类>.I.全服共享存档数据.已融丹次数[3] + Singleton<全局变量类>.I.全服共享存档数据.已融丹次数[4] + Singleton<全局变量类>.I.全服共享存档数据.已融丹次数[5];
	}

	
	public APqDp4bq1ecVdMifnI1()
	{
	}

	
	static APqDp4bq1ecVdMifnI1()
	{
		hTcJg7S33o = 0;
		N4JJDkQBnp = new int[6];
		afPJjb7NhJ = new int[6];
		dJgJlV9I4H = string.Empty;
		q1PJ8nk78G = string.Empty;
		T1eJIH7Ikb = string.Empty;
		ej0JoRrlMi = string.Empty;
		cEuJNhB2DX = string.Empty;
		QF1Jiacd8w = string.Empty;
		UMtJBHvwbM = string.Empty;
		MyOJG2GsQ2 = new ConcurrentDictionary<AllEnums.荣丹Type, List<融丹奖池类>>();
		adiJf9U5pw = new byte[25]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 15,
			61, 243, 0, 159, 10, 49, 56, 53, 50, 50,
			49, 52, 51, 57, 57
		};
		qbiJ617QEH = new byte[13]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 3,
			253, 205, 2
		};
		dl1J2sM5Ch = new object();
	}
}
