using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using KEvDjBdeoLOoBKWXFAH;
using Serilog;
using eYLrotRIovAGM9lAtVf;
using ixYEhcwWIdwrtDxOO94;
using uI75fJjR7A2e7wWdq9f;

namespace WUi9QivDmyMdpkvOap;

internal class UuQEWHhexEnQTYynfh : Singleton<UuQEWHhexEnQTYynfh>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public 异兽录图鉴列表类 B5MXDLJL1t;

		
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		
		internal bool sBhXgp535r(string x)
		{
			return x == B5MXDLJL1t.宠物名字;
		}

		static _003C_003Ec__DisplayClass5_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_1
	{
		public 异兽录图鉴列表类 jbxXlYJsgp;

		
		public _003C_003Ec__DisplayClass5_1()
		{
		}

		
		internal bool h2gXj60Ybi(string x)
		{
			return x == jbxXlYJsgp.宠物名字;
		}

		static _003C_003Ec__DisplayClass5_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_2
	{
		public 异兽录图鉴列表类 lO0XIJdq7U;

		
		public _003C_003Ec__DisplayClass5_2()
		{
		}

		
		internal bool SJcX8FJMmm(string x)
		{
			return x == lO0XIJdq7U.宠物名字;
		}

		static _003C_003Ec__DisplayClass5_2()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_3
	{
		public 异兽录图鉴列表类 iUqXNb8Pqq;

		
		public _003C_003Ec__DisplayClass5_3()
		{
		}

		
		internal bool O1jXovPiLR(string x)
		{
			return x == iUqXNb8Pqq.宠物名字;
		}

		static _003C_003Ec__DisplayClass5_3()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_4
	{
		public 异兽录图鉴列表类 hNHXBqHvtF;

		
		public _003C_003Ec__DisplayClass5_4()
		{
		}

		
		internal bool Un7XiddYiK(string x)
		{
			return x == hNHXBqHvtF.宠物名字;
		}

		static _003C_003Ec__DisplayClass5_4()
		{
		}
	}

	
	internal AllEnums.任务Type Ebt7PQbhf(MyNATSocketClient P_0, byte[] P_1)
	{
		if (Singleton<ByteAPI>.I.寻找字节集(P_1, "自动摆摊"))
		{
			return AllEnums.任务Type.自动摆摊;
		}
		if (Singleton<ByteAPI>.I.寻找字节集(P_1, "宠物召唤活动"))
		{
			return AllEnums.任务Type.宠物召唤活动;
		}
		if (Singleton<全局变量类>.I.超级道具配置.功能开关 && Singleton<ByteAPI>.I.寻找字节集(P_1, "超级道具活动"))
		{
			return AllEnums.任务Type.超级道具活动;
		}
		if (Singleton<ByteAPI>.I.寻找字节集(P_1, "六道轮回活动"))
		{
			return AllEnums.任务Type.六道轮回活动;
		}
		if (Singleton<ByteAPI>.I.寻找字节集(P_1, "异兽收录活动"))
		{
			return AllEnums.任务Type.异兽收录活动;
		}
		if (Singleton<ByteAPI>.I.寻找字节集(P_1, "大圣无双活动"))
		{
			return AllEnums.任务Type.大圣无双活动;
		}
		if (Singleton<ByteAPI>.I.寻找字节集(P_1, "推荐拉人活动"))
		{
			return AllEnums.任务Type.推荐拉人活动;
		}
		if (Singleton<ByteAPI>.I.寻找字节集(P_1, "燃眉之急活动") && Singleton<全局变量类>.I.燃眉配置.功能开关 && !string.IsNullOrWhiteSpace(P_0.user.存档数据.燃眉之急任务.当前NPC))
		{
			return AllEnums.任务Type.燃眉之急活动;
		}
		if (Singleton<ByteAPI>.I.寻找字节集(P_1, "浮生加护活动"))
		{
			return AllEnums.任务Type.浮生加护活动;
		}
		if (Singleton<ByteAPI>.I.寻找字节集(P_1, "宠物转生活动"))
		{
			return AllEnums.任务Type.宠物转生活动;
		}
		if (版本相关处理.Is巅峰对决 && Singleton<ByteAPI>.I.寻找字节集(P_1, "巅峰套装系统"))
		{
			return AllEnums.任务Type.巅峰对决版本;
		}
		if (全局变量类.点卡使用中 && Singleton<ByteAPI>.I.寻找字节集(P_1, "点卡系统"))
		{
			return AllEnums.任务Type.点卡系统;
		}
		if (Singleton<全局变量类>.I.在线泡点配置.泡点开关 && Singleton<ByteAPI>.I.寻找字节集(P_1, "每日泡点活动"))
		{
			return AllEnums.任务Type.每日泡点活动;
		}
		return AllEnums.任务Type.无;
	}

	
	internal void LMVajrfJF(MyNATSocketClient P_0, AllEnums.任务Type P_1)
	{
		try
		{
			switch (P_1)
			{
			case AllEnums.任务Type.自动摆摊:
				MrNT5FAY4(P_0);
				r0Z967e4Q(P_0);
				oKgyr17IZ(P_0);
				bF1CLEGvj(P_0);
				QGPVepPbZ(P_0);
				RxFknNtaC(P_0);
				mfC0jVvZE(P_0);
				QQiOL5J88(P_0);
				DGvE5pDFW(P_0);
				if (版本相关处理.Is巅峰对决)
				{
					Fga3MjO0r(P_0);
				}
				if (全局变量类.点卡使用中)
				{
					jgYYACInD(P_0);
				}
				IEwpSTAlC(P_0);
				break;
			case AllEnums.任务Type.超级道具活动:
				MrNT5FAY4(P_0);
				break;
			case AllEnums.任务Type.宠物召唤活动:
				r0Z967e4Q(P_0);
				break;
			case AllEnums.任务Type.六道轮回活动:
				oKgyr17IZ(P_0);
				break;
			case AllEnums.任务Type.异兽收录活动:
				bF1CLEGvj(P_0);
				break;
			case AllEnums.任务Type.大圣无双活动:
				QGPVepPbZ(P_0);
				break;
			case AllEnums.任务Type.推荐拉人活动:
				RxFknNtaC(P_0);
				break;
			case AllEnums.任务Type.燃眉之急活动:
				mfC0jVvZE(P_0);
				break;
			case AllEnums.任务Type.浮生加护活动:
				QQiOL5J88(P_0);
				break;
			case AllEnums.任务Type.宠物转生活动:
				DGvE5pDFW(P_0);
				break;
			case AllEnums.任务Type.巅峰对决版本:
				Fga3MjO0r(P_0);
				break;
			case AllEnums.任务Type.点卡系统:
				jgYYACInD(P_0);
				break;
			case AllEnums.任务Type.每日泡点活动:
				IEwpSTAlC(P_0);
				break;
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("刷新任务事件处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void MrNT5FAY4(MyNATSocketClient P_0)
	{
		try
		{
			if (!Singleton<全局变量类>.I.超级道具配置.功能开关)
			{
				return;
			}
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("26030001"), hasCount: false, 0);
			封包_写2.写文本型("超级道具活动|超级道具活动", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("超级道具中有些道具会赋予角色额外的附加属性，你当前拥有的附加属性如下：", hasCount: true, 1, reverse: true);
			StringBuilder stringBuilder = new StringBuilder();
			foreach (超级道具数据类 item in P_0.user.存档数据.超级道具数据)
			{
				if (string.IsNullOrWhiteSpace(item.道具名字) || item.已用数量 <= 0 || !Singleton<全局变量类>.I.超级道具配置.超级道具列表.TryGetValue(item.道具名字, out 超级道具列表配置类 value))
				{
					continue;
				}
				if (zeYnwTjKgpmAbfSQh5J.ARHjmZgHJU())
				{
					if (item.附加属性类型 != AllEnums.属性名字Type.无 && item.加成数值 != 0)
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder3 = stringBuilder2;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(30, 6, stringBuilder2);
						handler.AppendLiteral("#Y道具：");
						handler.AppendFormatted(item.道具名字);
						handler.AppendLiteral("#R(已使用");
						handler.AppendFormatted(item.已用数量);
						handler.AppendLiteral("/");
						handler.AppendFormatted(value.最多使用数量);
						handler.AppendLiteral(")#n#r      #L");
						handler.AppendFormatted(item.附加属性类型);
						handler.AppendLiteral("+");
						handler.AppendFormatted(item.加成数值);
						handler.AppendFormatted(问道数据类.Add属性名字后缀(value.附加属性类型));
						handler.AppendLiteral("#n#r");
						stringBuilder3.Append(ref handler);
					}
				}
				else if (value.is累计开关)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
					handler.AppendLiteral("#Y道具：");
					handler.AppendFormatted(item.道具名字);
					handler.AppendLiteral("#R(已使用");
					handler.AppendFormatted(item.已用数量);
					string value2;
					if (value.最多使用数量 <= 0)
					{
						value2 = string.Empty;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
						defaultInterpolatedStringHandler.AppendLiteral("/");
						defaultInterpolatedStringHandler.AppendFormatted(value.最多使用数量);
						value2 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					handler.AppendFormatted(value2);
					handler.AppendLiteral(")#n#r");
					stringBuilder4.Append(ref handler);
					for (int i = 0; i < value.累计奖励列表.Count && (!value.is重置累计 || i < 1); i++)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder5 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(15, 4, stringBuilder2);
						handler.AppendLiteral("#G    累计");
						handler.AppendFormatted(value.累计奖励列表[i].最低累计);
						handler.AppendLiteral("-");
						handler.AppendFormatted(value.累计奖励列表[i].最高累计);
						handler.AppendLiteral("奖励(");
						handler.AppendFormatted(value.累计奖励列表[i].奖励类型);
						handler.AppendFormatted(value.累计奖励列表[i].奖励内容);
						handler.AppendLiteral(")#r");
						stringBuilder5.Append(ref handler);
					}
				}
			}
			if (!P_0.user.存档数据.中州论道存档.限时属性列表.IsEmpty)
			{
				stringBuilder.Append("#r#Y限时属性如下：#r");
				foreach (KeyValuePair<AllEnums.属性名字Type, int[]> item2 in P_0.user.存档数据.中州论道存档.限时属性列表)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(25, 4, stringBuilder2);
					handler.AppendLiteral("      #L");
					handler.AppendFormatted(item2.Key);
					handler.AppendLiteral("：+ ");
					handler.AppendFormatted(item2.Value[0]);
					handler.AppendFormatted(问道数据类.Add属性名字后缀(item2.Key));
					handler.AppendLiteral("#r      #R");
					handler.AppendFormatted(Singleton<ByteAPI>.I.取时间文本(item2.Value[1]));
					handler.AppendLiteral("#n#r");
					stringBuilder6.Append(ref handler);
				}
			}
			封包_写2.写文本型(stringBuilder.ToString(), hasCount: true, 1, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000101000002"), hasCount: false, 0);
			封包_写2.写文本型("1~5人", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("40级及以上", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("几率获得：", hasCount: true, 1, reverse: true);
			封包_写2.写文本型("活动", hasCount: true, 0, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			P_0.C_Send(封包_写3.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("任务_超级道具-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void r0Z967e4Q(MyNATSocketClient P_0)
	{
		try
		{
			if (Singleton<全局变量类>.I.宠物召唤配置.功能开关)
			{
				封包_写 封包_写2 = new 封包_写();
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("26030001"), hasCount: false, 0);
				封包_写2.写文本型("宠物召唤活动|宠物召唤活动", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("本服正在举行宠物召唤活动，活动NPC在天墉城的#P" + Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字 + "#P处，提交指定道具即可召唤宠物呦", hasCount: true, 1, reverse: true);
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilder stringBuilder2 = new StringBuilder();
				if (Singleton<全局变量类>.I.宠物召唤配置.is变异召唤)
				{
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder stringBuilder4 = stringBuilder3;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder3);
					handler.AppendLiteral("#I");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异奖励);
					handler.AppendLiteral("|随机变异#I");
					stringBuilder4.Append(ref handler);
					stringBuilder3 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder3;
					handler = new StringBuilder.AppendInterpolatedStringHandler(56, 5, stringBuilder3);
					handler.AppendLiteral("#Y变异召唤：#r#Y    材料：#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异材料);
					handler.AppendLiteral("#r#Y    进度：#G");
					handler.AppendFormatted((double)P_0.user.存档数据.召唤数据.变异珠 * 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.变异最高, "F2");
					handler.AppendLiteral("%(");
					handler.AppendFormatted(P_0.user.存档数据.召唤数据.变异珠);
					handler.AppendLiteral("/");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异最高);
					handler.AppendLiteral(")#r#Y    奖励：#R");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.变异奖励);
					handler.AppendLiteral("#n#r#r");
					stringBuilder5.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.宠物召唤配置.is神兽召唤)
				{
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder stringBuilder6 = stringBuilder3;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder3);
					handler.AppendLiteral("#I");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽奖励);
					handler.AppendLiteral("|随机神兽#I");
					stringBuilder6.Append(ref handler);
					stringBuilder3 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder3;
					handler = new StringBuilder.AppendInterpolatedStringHandler(56, 5, stringBuilder3);
					handler.AppendLiteral("#Y神兽召唤：#r#Y    材料：#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽材料);
					handler.AppendLiteral("#r#Y    进度：#G");
					handler.AppendFormatted((double)P_0.user.存档数据.召唤数据.神兽珠 * 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.神兽最高, "F2");
					handler.AppendLiteral("%(");
					handler.AppendFormatted(P_0.user.存档数据.召唤数据.神兽珠);
					handler.AppendLiteral("/");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽最高);
					handler.AppendLiteral(")#r#Y    奖励：#R");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.神兽奖励);
					handler.AppendLiteral("#n#r#r");
					stringBuilder7.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.宠物召唤配置.is元灵召唤)
				{
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder stringBuilder8 = stringBuilder3;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder3);
					handler.AppendLiteral("#I");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵奖励);
					handler.AppendLiteral("|随机元灵#I");
					stringBuilder8.Append(ref handler);
					stringBuilder3 = stringBuilder;
					StringBuilder stringBuilder9 = stringBuilder3;
					handler = new StringBuilder.AppendInterpolatedStringHandler(56, 5, stringBuilder3);
					handler.AppendLiteral("#Y元灵召唤：#r#Y    材料：#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵材料);
					handler.AppendLiteral("#r#Y    进度：#G");
					handler.AppendFormatted((double)P_0.user.存档数据.召唤数据.元灵珠 * 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.元灵最高, "F2");
					handler.AppendLiteral("%(");
					handler.AppendFormatted(P_0.user.存档数据.召唤数据.元灵珠);
					handler.AppendLiteral("/");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵最高);
					handler.AppendLiteral(")#r#Y    奖励：#R");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.元灵奖励);
					handler.AppendLiteral("#n#r#r");
					stringBuilder9.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.宠物召唤配置.is仙元召唤)
				{
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder stringBuilder10 = stringBuilder3;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder3);
					handler.AppendLiteral("#I");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元奖励);
					handler.AppendLiteral("|随机仙元#I");
					stringBuilder10.Append(ref handler);
					stringBuilder3 = stringBuilder;
					StringBuilder stringBuilder11 = stringBuilder3;
					handler = new StringBuilder.AppendInterpolatedStringHandler(56, 5, stringBuilder3);
					handler.AppendLiteral("#Y仙元召唤：#r#Y    材料：#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元材料);
					handler.AppendLiteral("#r#Y    进度：#G");
					handler.AppendFormatted((double)P_0.user.存档数据.召唤数据.仙元珠 * 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.仙元最高, "F2");
					handler.AppendLiteral("%(");
					handler.AppendFormatted(P_0.user.存档数据.召唤数据.仙元珠);
					handler.AppendLiteral("/");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元最高);
					handler.AppendLiteral(")#r#Y    奖励：#R");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.仙元奖励);
					handler.AppendLiteral("#n#r#r");
					stringBuilder11.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.宠物召唤配置.is御灵召唤)
				{
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder stringBuilder12 = stringBuilder3;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder3);
					handler.AppendLiteral("#I");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵奖励);
					handler.AppendLiteral("|随机御灵#I");
					stringBuilder12.Append(ref handler);
					stringBuilder3 = stringBuilder;
					StringBuilder stringBuilder13 = stringBuilder3;
					handler = new StringBuilder.AppendInterpolatedStringHandler(56, 5, stringBuilder3);
					handler.AppendLiteral("#Y御灵召唤：#r#Y    材料：#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵材料);
					handler.AppendLiteral("#r#Y    进度：#G");
					handler.AppendFormatted((double)P_0.user.存档数据.召唤数据.御灵珠 * 100.0 / (double)Singleton<全局变量类>.I.宠物召唤配置.御灵最高, "F2");
					handler.AppendLiteral("%(");
					handler.AppendFormatted(P_0.user.存档数据.召唤数据.御灵珠);
					handler.AppendLiteral("/");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵最高);
					handler.AppendLiteral(")#r#Y    奖励：#R");
					handler.AppendFormatted(Singleton<全局变量类>.I.宠物召唤配置.御灵奖励);
					handler.AppendLiteral("#n#r#r");
					stringBuilder13.Append(ref handler);
				}
				封包_写2.写文本型(stringBuilder.ToString(), hasCount: true, 1, reverse: true);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000101000002"), hasCount: false, 0);
				封包_写2.写文本型("1~5人", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("40级及以上", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("几率获得：#I数值奖励|数值奖励#I", hasCount: true, 1, reverse: true);
				封包_写2.写文本型("活动", hasCount: true, 0, reverse: true);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
				封包_写 封包_写3 = new 封包_写();
				封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
				封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
				P_0.C_Send(封包_写3.取数据());
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("任务_宠物召唤-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void oKgyr17IZ(MyNATSocketClient P_0)
	{
		try
		{
			if (!MbtVicwUkp5LuxTooFW.c5PwXOYtHf())
			{
				return;
			}
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("26030001"), hasCount: false, 0);
			封包_写2.写文本型("六道轮回活动|六道轮回活动", hasCount: true, 0, reverse: true);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(67, 3);
			defaultInterpolatedStringHandler.AppendLiteral("据说等级达到了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.最低需求等级);
			defaultInterpolatedStringHandler.AppendLiteral("#n级以上的道友可以在#P");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.npc名字);
			defaultInterpolatedStringHandler.AppendLiteral("#P处开启六道轮回转世通道，体验六道之玄妙，参轮回之大道。详情可前往#P");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.npc名字);
			defaultInterpolatedStringHandler.AppendLiteral("#P处查询具体信息");
			封包_写2.写文本型(defaultInterpolatedStringHandler.ToStringAndClear(), hasCount: true, 1, reverse: true);
			StringBuilder stringBuilder = new StringBuilder();
			if (!MbtVicwUkp5LuxTooFW.EaewmWn7Ul())
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder2);
				handler.AppendLiteral("#G所属生效加点方案");
				handler.AppendFormatted(P_0.user.缓存数据.is加点方案一 ? "一" : "二");
				handler.AppendLiteral("#n#r");
				stringBuilder3.Append(ref handler);
			}
			六道轮回存档数据类 六道轮回存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.轮回转世数据.存档方案1 : P_0.user.存档数据.轮回转世数据.存档方案2);
			for (int i = 0; i < Singleton<全局变量类>.I.六道轮回配置.六道轮回列表.Length; i++)
			{
				if (六道轮回存档数据类2.转世阶段 < Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[i].六道名字)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(33, 3, stringBuilder2);
					handler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[i].六道名字);
					handler.AppendLiteral("（未转世）：#n#r    轮回属性：所有相性+");
					handler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[i].所相数值);
					handler.AppendLiteral("/单相性+");
					handler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[i].单相数值);
					handler.AppendLiteral("#n#r");
					stringBuilder4.Append(ref handler);
				}
				else if (六道轮回存档数据类2.转世阶段 == Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[i].六道名字)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(20, 2, stringBuilder2);
					handler.AppendLiteral("#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[i].六道名字);
					handler.AppendLiteral("(");
					handler.AppendFormatted(六道轮回存档数据类2.转世状态);
					handler.AppendLiteral(")：#n#r    #G轮回属性：");
					stringBuilder5.Append(ref handler);
					if (六道轮回存档数据类2.转世状态 == AllEnums.轮回Type.已转世)
					{
						轮回转世属性存档 轮回转世属性存档2 = 六道轮回存档数据类2.转世属性列表[(int)六道轮回存档数据类2.转世阶段];
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder6 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(10, 2, stringBuilder2);
						handler.AppendLiteral("#G");
						handler.AppendFormatted((AllEnums.属性Type)轮回转世属性存档2.转世属性);
						handler.AppendLiteral(" ");
						handler.AppendFormatted(轮回转世属性存档2.属性数值);
						handler.AppendLiteral(" 增加#n#r");
						stringBuilder6.Append(ref handler);
					}
					else if (六道轮回存档数据类2.转世状态 == AllEnums.轮回Type.已圆满)
					{
						轮回转世属性存档 轮回转世属性存档3 = 六道轮回存档数据类2.转世属性列表[(int)六道轮回存档数据类2.转世阶段];
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder7 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(10, 2, stringBuilder2);
						handler.AppendLiteral("#G");
						handler.AppendFormatted((AllEnums.属性Type)轮回转世属性存档3.转世属性);
						handler.AppendLiteral(" ");
						handler.AppendFormatted(轮回转世属性存档3.属性数值);
						handler.AppendLiteral(" 增加#n#r");
						stringBuilder7.Append(ref handler);
					}
					else
					{
						stringBuilder.Append("#n暂无#r");
					}
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[i].六道名字);
					handler.AppendLiteral("(已完成)：#n#r    #G轮回属性：");
					stringBuilder8.Append(ref handler);
					轮回转世属性存档 轮回转世属性存档4 = 六道轮回存档数据类2.转世属性列表[i];
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder9 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(10, 2, stringBuilder2);
					handler.AppendLiteral("#G");
					handler.AppendFormatted((AllEnums.属性Type)轮回转世属性存档4.转世属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(轮回转世属性存档4.属性数值);
					handler.AppendLiteral(" 增加#n#r");
					stringBuilder9.Append(ref handler);
				}
			}
			封包_写2.写文本型(stringBuilder.ToString(), hasCount: true, 1, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000101000002"), hasCount: false, 0);
			封包_写2.写文本型("1~5人", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("100级及以上", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("几率获得：#I数值奖励|数值奖励#I", hasCount: true, 1, reverse: true);
			封包_写2.写文本型("活动", hasCount: true, 0, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			P_0.C_Send(封包_写3.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("任务_六道轮回-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void bF1CLEGvj(MyNATSocketClient P_0)
	{
		try
		{
			if (!iRGieud4qtscW6ESmxk.wGmslE7YU3())
			{
				return;
			}
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("26030001"), hasCount: false, 0);
			封包_写2.写文本型("异兽收录活动|异兽收录活动", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("本服正在举行异兽收录活动，活动NPC在天墉城的#P" + Singleton<全局变量类>.I.异兽录配置.NPC数据.npc名字 + "#P处，提交指定宠物即可激活对应的异兽录属性呦", hasCount: true, 1, reverse: true);
			StringBuilder stringBuilder = new StringBuilder("#Y当前异兽录图鉴收录情况：#n#r");
			异兽录存档数据类 异兽录存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.异兽录数据.方案1 : P_0.user.存档数据.异兽录数据.方案2);
			List<string> value = new List<string>();
			bool flag = false;
			if (!Singleton<iRGieud4qtscW6ESmxk>.I.f1esfGQQpj.IsEmpty)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
				handler.AppendLiteral("#Y【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
				handler.AppendLiteral("】图鉴收录进度：#Y");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[AllEnums.异兽Type.御灵].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(Singleton<iRGieud4qtscW6ESmxk>.I.f1esfGQQpj.Count);
				handler.AppendLiteral("#r");
				stringBuilder3.Append(ref handler);
				异兽录存档数据类2.收录列表.TryGetValue(AllEnums.异兽Type.御灵, out value);
				using IEnumerator<异兽录图鉴列表类> enumerator = Singleton<iRGieud4qtscW6ESmxk>.I.f1esfGQQpj.Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals30 = new _003C_003Ec__DisplayClass5_0();
					CS_0024_003C_003E8__locals30.B5MXDLJL1t = enumerator.Current;
					flag = value.Any( (string x) => x == CS_0024_003C_003E8__locals30.B5MXDLJL1t.宠物名字);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(10, 4, stringBuilder2);
					handler.AppendLiteral("    ");
					handler.AppendFormatted(flag ? "#L" : "#D");
					handler.AppendFormatted(CS_0024_003C_003E8__locals30.B5MXDLJL1t.宠物名字);
					handler.AppendLiteral("：");
					handler.AppendFormatted(iRGieud4qtscW6ESmxk.wGmslE7YU3() ? $"{CS_0024_003C_003E8__locals30.B5MXDLJL1t.定制收录属性}" : $"{CS_0024_003C_003E8__locals30.B5MXDLJL1t.收录属性}");
					handler.AppendLiteral("+");
					handler.AppendFormatted(CS_0024_003C_003E8__locals30.B5MXDLJL1t.收录数值);
					handler.AppendLiteral("#n#r");
					stringBuilder4.Append(ref handler);
				}
			}
			if (!Singleton<iRGieud4qtscW6ESmxk>.I.W5hsNnYAjN.IsEmpty)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
				handler.AppendLiteral("#Y【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
				handler.AppendLiteral("】图鉴收录进度：#Y");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[AllEnums.异兽Type.变异].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(Singleton<iRGieud4qtscW6ESmxk>.I.W5hsNnYAjN.Count);
				handler.AppendLiteral("#r");
				stringBuilder5.Append(ref handler);
				异兽录存档数据类2.收录列表.TryGetValue(AllEnums.异兽Type.变异, out value);
				using IEnumerator<异兽录图鉴列表类> enumerator = Singleton<iRGieud4qtscW6ESmxk>.I.W5hsNnYAjN.Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass5_1 CS_0024_003C_003E8__locals31 = new _003C_003Ec__DisplayClass5_1();
					CS_0024_003C_003E8__locals31.jbxXlYJsgp = enumerator.Current;
					flag = value.Any( (string x) => x == CS_0024_003C_003E8__locals31.jbxXlYJsgp.宠物名字);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(10, 4, stringBuilder2);
					handler.AppendLiteral("    ");
					handler.AppendFormatted(flag ? "#L" : "#D");
					handler.AppendFormatted(CS_0024_003C_003E8__locals31.jbxXlYJsgp.宠物名字);
					handler.AppendLiteral("：");
					handler.AppendFormatted(iRGieud4qtscW6ESmxk.wGmslE7YU3() ? $"{CS_0024_003C_003E8__locals31.jbxXlYJsgp.定制收录属性}" : $"{CS_0024_003C_003E8__locals31.jbxXlYJsgp.收录属性}");
					handler.AppendLiteral("+");
					handler.AppendFormatted(CS_0024_003C_003E8__locals31.jbxXlYJsgp.收录数值);
					handler.AppendLiteral("#n#r");
					stringBuilder6.Append(ref handler);
				}
			}
			if (!Singleton<iRGieud4qtscW6ESmxk>.I.T6gsiwMmCv.IsEmpty)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder7 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
				handler.AppendLiteral("#Y【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
				handler.AppendLiteral("】图鉴收录进度：#Y");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[AllEnums.异兽Type.神兽].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(Singleton<iRGieud4qtscW6ESmxk>.I.T6gsiwMmCv.Count);
				handler.AppendLiteral("#r");
				stringBuilder7.Append(ref handler);
				异兽录存档数据类2.收录列表.TryGetValue(AllEnums.异兽Type.神兽, out value);
				using IEnumerator<异兽录图鉴列表类> enumerator = Singleton<iRGieud4qtscW6ESmxk>.I.T6gsiwMmCv.Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass5_2 CS_0024_003C_003E8__locals32 = new _003C_003Ec__DisplayClass5_2();
					CS_0024_003C_003E8__locals32.lO0XIJdq7U = enumerator.Current;
					flag = value.Any( (string x) => x == CS_0024_003C_003E8__locals32.lO0XIJdq7U.宠物名字);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(12, 4, stringBuilder2);
					handler.AppendLiteral("    ");
					handler.AppendFormatted(flag ? "#L" : "#D");
					handler.AppendFormatted(CS_0024_003C_003E8__locals32.lO0XIJdq7U.宠物名字);
					handler.AppendLiteral("：");
					handler.AppendFormatted(iRGieud4qtscW6ESmxk.wGmslE7YU3() ? $"{CS_0024_003C_003E8__locals32.lO0XIJdq7U.定制收录属性}" : $"{CS_0024_003C_003E8__locals32.lO0XIJdq7U.收录属性}");
					handler.AppendLiteral("+ ");
					handler.AppendFormatted(CS_0024_003C_003E8__locals32.lO0XIJdq7U.收录数值);
					handler.AppendLiteral(" #n#r");
					stringBuilder8.Append(ref handler);
				}
			}
			if (!Singleton<iRGieud4qtscW6ESmxk>.I.iFLsBvoaBy.IsEmpty)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder9 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
				handler.AppendLiteral("#Y【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
				handler.AppendLiteral("】图鉴收录进度：#Y");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[AllEnums.异兽Type.元灵].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(Singleton<iRGieud4qtscW6ESmxk>.I.iFLsBvoaBy.Count);
				handler.AppendLiteral("#r");
				stringBuilder9.Append(ref handler);
				异兽录存档数据类2.收录列表.TryGetValue(AllEnums.异兽Type.元灵, out value);
				using IEnumerator<异兽录图鉴列表类> enumerator = Singleton<iRGieud4qtscW6ESmxk>.I.iFLsBvoaBy.Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass5_3 CS_0024_003C_003E8__locals33 = new _003C_003Ec__DisplayClass5_3();
					CS_0024_003C_003E8__locals33.iUqXNb8Pqq = enumerator.Current;
					flag = value.Any( (string x) => x == CS_0024_003C_003E8__locals33.iUqXNb8Pqq.宠物名字);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder10 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(12, 4, stringBuilder2);
					handler.AppendLiteral("    ");
					handler.AppendFormatted(flag ? "#L" : "#D");
					handler.AppendFormatted(CS_0024_003C_003E8__locals33.iUqXNb8Pqq.宠物名字);
					handler.AppendLiteral("：");
					handler.AppendFormatted(iRGieud4qtscW6ESmxk.wGmslE7YU3() ? $"{CS_0024_003C_003E8__locals33.iUqXNb8Pqq.定制收录属性}" : $"{CS_0024_003C_003E8__locals33.iUqXNb8Pqq.收录属性}");
					handler.AppendLiteral("+ ");
					handler.AppendFormatted(CS_0024_003C_003E8__locals33.iUqXNb8Pqq.收录数值);
					handler.AppendLiteral(" #n#r");
					stringBuilder10.Append(ref handler);
				}
			}
			if (!Singleton<iRGieud4qtscW6ESmxk>.I.Q1xsG3Fx3O.IsEmpty)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder11 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
				handler.AppendLiteral("#Y【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
				handler.AppendLiteral("】图鉴收录进度：#Y");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[AllEnums.异兽Type.仙元].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(Singleton<iRGieud4qtscW6ESmxk>.I.Q1xsG3Fx3O.Count);
				handler.AppendLiteral("#r");
				stringBuilder11.Append(ref handler);
				异兽录存档数据类2.收录列表.TryGetValue(AllEnums.异兽Type.仙元, out value);
				using IEnumerator<异兽录图鉴列表类> enumerator = Singleton<iRGieud4qtscW6ESmxk>.I.Q1xsG3Fx3O.Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass5_4 CS_0024_003C_003E8__locals34 = new _003C_003Ec__DisplayClass5_4();
					CS_0024_003C_003E8__locals34.hNHXBqHvtF = enumerator.Current;
					flag = value.Any( (string x) => x == CS_0024_003C_003E8__locals34.hNHXBqHvtF.宠物名字);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder12 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(12, 4, stringBuilder2);
					handler.AppendLiteral("    ");
					handler.AppendFormatted(flag ? "#L" : "#D");
					handler.AppendFormatted(CS_0024_003C_003E8__locals34.hNHXBqHvtF.宠物名字);
					handler.AppendLiteral("：");
					handler.AppendFormatted(iRGieud4qtscW6ESmxk.wGmslE7YU3() ? $"{CS_0024_003C_003E8__locals34.hNHXBqHvtF.定制收录属性}" : $"{CS_0024_003C_003E8__locals34.hNHXBqHvtF.收录属性}");
					handler.AppendLiteral("+ ");
					handler.AppendFormatted(CS_0024_003C_003E8__locals34.hNHXBqHvtF.收录数值);
					handler.AppendLiteral(" #n#r");
					stringBuilder12.Append(ref handler);
				}
			}
			封包_写2.写文本型(stringBuilder.ToString(), hasCount: true, 1, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000101000002"), hasCount: false, 0);
			封包_写2.写文本型("1~5人", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("40级及以上", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("几率获得：#I数值奖励|数值奖励#I", hasCount: true, 1, reverse: true);
			封包_写2.写文本型("活动", hasCount: true, 0, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			P_0.C_Send(封包_写3.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("任务_异兽收录-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void QGPVepPbZ(MyNATSocketClient P_0)
	{
		try
		{
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("任务_大圣无双-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void RxFknNtaC(MyNATSocketClient P_0)
	{
		try
		{
			if (!Singleton<全局变量类>.I.推荐拉人配置.功能开关)
			{
				return;
			}
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("26030001"), hasCount: false, 0);
			封包_写2.写文本型("推荐拉人活动|推荐拉人活动", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("本服开启推荐拉人返利活动，各位道友可向朋友推荐邀请进入本服一起畅游。邀请的人数越多奖励越丰厚，道友请动动尊贵的小手，要求好友一起来本服愉快的玩耍吧。邀请规则如下：", hasCount: true, 1, reverse: true);
			StringBuilder stringBuilder = new StringBuilder("#Y你的引路道友：" + (Singleton<全局变量类>.I.角色存档表.ContainsKey(P_0.user.存档数据.推荐拉人数据.推荐人GID) ? Singleton<全局变量类>.I.角色存档表[P_0.user.存档数据.推荐拉人数据.推荐人GID].昵称 : "无") + "#r");
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(21, 1, stringBuilder2);
			handler.AppendLiteral("#Y邀请规则如下#R(已邀请");
			handler.AppendFormatted(P_0.user.存档数据.推荐拉人数据.累计推荐人数);
			handler.AppendLiteral("人)#Y：#r");
			stringBuilder3.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
			handler.AppendLiteral("#G    ");
			handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.is推荐自己无效 ? "推荐自己无效" : "推荐自己有效");
			handler.AppendLiteral("#r");
			stringBuilder4.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder5 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
			handler.AppendLiteral("#G    ");
			handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.is同IP推荐无效 ? "推荐相同注册IP角色无效" : "推荐相同注册IP角色有效");
			handler.AppendLiteral("#r");
			stringBuilder5.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder6 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
			handler.AppendLiteral("#G    ");
			handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.is同机器码推荐无效 ? "推荐相同注册MAC角色无效" : "推荐相同注册MAC角色有效");
			handler.AppendLiteral("#r");
			stringBuilder6.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder7 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
			handler.AppendLiteral("#G    ");
			handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.is同QQ推荐无效 ? "推荐相同注册QQ角色无效" : "推荐相同注册QQ角色有效");
			handler.AppendLiteral("#r");
			stringBuilder7.Append(ref handler);
			stringBuilder.Append("#Y邀请奖励如下：#L#r");
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励) || !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励))
			{
				if (Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励类型 != AllEnums.数值Type.无 && !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励))
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(16, 2, stringBuilder2);
					handler.AppendLiteral("#Y    推荐人奖励(");
					handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励类型);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励);
					handler.AppendLiteral(")#r");
					stringBuilder8.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励类型 != AllEnums.数值Type.无 && !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励))
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder9 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
					handler.AppendLiteral("#Y  被推荐人奖励(");
					handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励类型);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励);
					handler.AppendLiteral(")#r");
					stringBuilder9.Append(ref handler);
				}
			}
			if (Singleton<全局变量类>.I.推荐拉人配置.is获取被推荐人充值奖励)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder10 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(73, 3, stringBuilder2);
				handler.AppendLiteral("#M温馨提示：你推荐的道友每次最低充值#Y");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.最低充值);
				handler.AppendLiteral("#M元你即可获得#Y");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.充值奖励类型);
				handler.AppendFormatted(Singleton<WdAPI>.I.货币转文本(Singleton<全局变量类>.I.推荐拉人配置.充值奖励));
				handler.AppendLiteral("#M返利#O(例子:如果最低充值为10，单次充值20则可获得双倍返利，依次类推)#r");
				stringBuilder10.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.推荐拉人配置.is累计推荐奖励开关)
			{
				stringBuilder.Append("#r#Y累计邀请奖励如下：#r");
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder11 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(11, 3, stringBuilder2);
				handler.AppendLiteral("#G    5人：");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐5人奖励类型);
				handler.AppendFormatted(Singleton<WdAPI>.I.货币转文本(Singleton<全局变量类>.I.推荐拉人配置.累计推荐5人奖励));
				handler.AppendFormatted((P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 5) ? "#R(已领取)" : string.Empty);
				handler.AppendLiteral("#r");
				stringBuilder11.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder12 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(11, 3, stringBuilder2);
				handler.AppendLiteral("#G   10人：");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐10人奖励类型);
				handler.AppendFormatted(Singleton<WdAPI>.I.货币转文本(Singleton<全局变量类>.I.推荐拉人配置.累计推荐10人奖励));
				handler.AppendFormatted((P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 10) ? "#R(已领取)" : string.Empty);
				handler.AppendLiteral("#r");
				stringBuilder12.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder13 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(11, 3, stringBuilder2);
				handler.AppendLiteral("#G   20人：");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐20人奖励类型);
				handler.AppendFormatted(Singleton<WdAPI>.I.货币转文本(Singleton<全局变量类>.I.推荐拉人配置.累计推荐20人奖励));
				handler.AppendFormatted((P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 20) ? "#R(已领取)" : string.Empty);
				handler.AppendLiteral("#r");
				stringBuilder13.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder14 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(11, 3, stringBuilder2);
				handler.AppendLiteral("#G   40人：");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐40人奖励类型);
				handler.AppendFormatted(Singleton<WdAPI>.I.货币转文本(Singleton<全局变量类>.I.推荐拉人配置.累计推荐40人奖励));
				handler.AppendFormatted((P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 40) ? "#R(已领取)" : string.Empty);
				handler.AppendLiteral("#r");
				stringBuilder14.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder15 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(11, 3, stringBuilder2);
				handler.AppendLiteral("#G   60人：");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐60人奖励类型);
				handler.AppendFormatted(Singleton<WdAPI>.I.货币转文本(Singleton<全局变量类>.I.推荐拉人配置.累计推荐60人奖励));
				handler.AppendFormatted((P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 60) ? "#R(已领取)" : string.Empty);
				handler.AppendLiteral("#r");
				stringBuilder15.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder16 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(11, 3, stringBuilder2);
				handler.AppendLiteral("#G   80人：");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐80人奖励类型);
				handler.AppendFormatted(Singleton<WdAPI>.I.货币转文本(Singleton<全局变量类>.I.推荐拉人配置.累计推荐80人奖励));
				handler.AppendFormatted((P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 80) ? "#R(已领取)" : string.Empty);
				handler.AppendLiteral("#r");
				stringBuilder16.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder17 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(11, 3, stringBuilder2);
				handler.AppendLiteral("#G  100人：");
				handler.AppendFormatted(Singleton<全局变量类>.I.推荐拉人配置.累计推荐100人奖励类型);
				handler.AppendFormatted(Singleton<WdAPI>.I.货币转文本(Singleton<全局变量类>.I.推荐拉人配置.累计推荐100人奖励));
				handler.AppendFormatted((P_0.user.存档数据.推荐拉人数据.领取累计推荐奖励阶段 >= 100) ? "#R(已领取)" : string.Empty);
				handler.AppendLiteral("#r");
				stringBuilder17.Append(ref handler);
			}
			封包_写2.写文本型(stringBuilder.ToString(), hasCount: true, 1, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000101000002"), hasCount: false, 0);
			封包_写2.写文本型("1人", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("40级及以上", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("几率获得：#I其它奖励|奇珍异宝#I#I金钱奖励|金钱奖励#I", hasCount: true, 1, reverse: true);
			封包_写2.写文本型("活动", hasCount: true, 0, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			P_0.C_Send(封包_写3.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("任务_推荐拉人-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void mfC0jVvZE(MyNATSocketClient P_0)
	{
		try
		{
			if (Singleton<全局变量类>.I.燃眉配置.功能开关 && !string.IsNullOrWhiteSpace(P_0.user.存档数据.燃眉之急任务.当前NPC))
			{
				封包_写 封包_写2 = new 封包_写();
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("26030001"), hasCount: false, 0);
				封包_写2.写文本型("燃眉之急活动|燃眉之急活动", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("近日来，不少人向五行竞猜使借钱周转。偏偏最近资金周转不灵，五行竞猜使为了保证自己的金字招牌，只得请求高人追讨，以解燃眉之急。#R(该任务离线后自动放弃)#n", hasCount: true, 1, reverse: true);
				封包_写2.写文本型("听闻#P" + P_0.user.存档数据.燃眉之急任务.当前NPC + "#P靠着借来的钱财发家致富，#R五行竞猜使#n请你前去讨要，缴纳一定的保证金后，讨回的宝物均归你所有。", hasCount: true, 1, reverse: true);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000101000002"), hasCount: false, 0);
				封包_写2.写文本型("1~5人", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("40级及以上", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("几率获得：#I其它奖励|奇珍异宝#I#I金钱奖励|金钱奖励#I", hasCount: true, 1, reverse: true);
				封包_写2.写文本型("活动", hasCount: true, 0, reverse: true);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
				封包_写 封包_写3 = new 封包_写();
				封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
				封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
				P_0.C_Send(封包_写3.取数据());
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("任务_燃眉之急-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void QQiOL5J88(MyNATSocketClient P_0)
	{
		try
		{
			if (浮生录功能.J7aWuMQOCf())
			{
				OqAQtemtQ(P_0);
			}
			else
			{
				if (!Singleton<全局变量类>.I.浮生录配置.功能开关)
				{
					return;
				}
				封包_写 封包_写2 = new 封包_写();
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("26030001"), hasCount: false, 0);
				封包_写2.写文本型("浮生加护活动|浮生加护活动", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("#G【浮生录系统】#n通过召唤不同星级的化身，玩家可以获得各种属性加成。化身分为不同的星级，从一星到五星不等，每个化身都有不同的分类总卷，当每个分类总卷的所有化身全部激活时，可获得属性加成 。", hasCount: true, 1, reverse: true);
				浮生录存档类 浮生录存档类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.浮生录数据.方案1 : P_0.user.存档数据.浮生录数据.方案2);
				StringBuilder stringBuilder = new StringBuilder("#G所属生效加点方案" + (P_0.user.缓存数据.is加点方案一 ? "一" : "二") + "#r#Y当前已加护生效属性：#n#G#r");
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
				handler.AppendLiteral("#r#Y乱世书(");
				handler.AppendFormatted(浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.乱世书));
				handler.AppendLiteral("/");
				handler.AppendFormatted(Singleton<浮生录功能>.I.Ih6WdCmIqb.Count);
				handler.AppendLiteral(")：#r");
				stringBuilder3.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(28, 2, stringBuilder2);
				handler.AppendLiteral("#Y乱世书总卷属性：");
				handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乱世书属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乱世书数值);
				handler.AppendLiteral(" 增加#r#Y乱世书化身列表：#n");
				stringBuilder4.Append(ref handler);
				for (int num = 0; num < Singleton<浮生录功能>.I.Ih6WdCmIqb.Count; num++)
				{
					if (num > 0)
					{
						stringBuilder.Append(",");
					}
					if (浮生录存档类2.化身列表.TryGetValue(Singleton<浮生录功能>.I.Ih6WdCmIqb[num].化身名字, out var value))
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder5 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(7, 2, stringBuilder2);
						handler.AppendLiteral("#B");
						handler.AppendFormatted(Singleton<浮生录功能>.I.Ih6WdCmIqb[num].化身名字);
						handler.AppendLiteral("(");
						handler.AppendFormatted(value.激活进度);
						handler.AppendLiteral("%)#n");
						stringBuilder5.Append(ref handler);
					}
					else
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder6 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
						handler.AppendLiteral("#n");
						handler.AppendFormatted(Singleton<浮生录功能>.I.Ih6WdCmIqb[num].化身名字);
						handler.AppendLiteral("#n");
						stringBuilder6.Append(ref handler);
					}
				}
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder7 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
				handler.AppendLiteral("#r#Y千钧卷(");
				handler.AppendFormatted(浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.千钧卷));
				handler.AppendLiteral("/");
				handler.AppendFormatted(Singleton<浮生录功能>.I.CsTWsdbKp5.Count);
				handler.AppendLiteral(")：#r");
				stringBuilder7.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder8 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(28, 2, stringBuilder2);
				handler.AppendLiteral("#Y千钧卷总卷属性：");
				handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.千钧卷属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.千钧卷数值);
				handler.AppendLiteral(" 增加#r#Y千钧卷化身列表：#n");
				stringBuilder8.Append(ref handler);
				for (int num2 = 0; num2 < Singleton<浮生录功能>.I.CsTWsdbKp5.Count; num2++)
				{
					if (num2 > 0)
					{
						stringBuilder.Append(",");
					}
					if (浮生录存档类2.化身列表.TryGetValue(Singleton<浮生录功能>.I.CsTWsdbKp5[num2].化身名字, out var value2))
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder9 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(7, 2, stringBuilder2);
						handler.AppendLiteral("#B");
						handler.AppendFormatted(Singleton<浮生录功能>.I.CsTWsdbKp5[num2].化身名字);
						handler.AppendLiteral("(");
						handler.AppendFormatted(value2.激活进度);
						handler.AppendLiteral("%)#n");
						stringBuilder9.Append(ref handler);
					}
					else
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder10 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
						handler.AppendLiteral("#n");
						handler.AppendFormatted(Singleton<浮生录功能>.I.CsTWsdbKp5[num2].化身名字);
						handler.AppendLiteral("#n");
						stringBuilder10.Append(ref handler);
					}
				}
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder11 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
				handler.AppendLiteral("#r#Y灵虚卷(");
				handler.AppendFormatted(浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.灵虚卷));
				handler.AppendLiteral("/");
				handler.AppendFormatted(Singleton<浮生录功能>.I.nppWUisDdB.Count);
				handler.AppendLiteral(")：#r");
				stringBuilder11.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder12 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(28, 2, stringBuilder2);
				handler.AppendLiteral("#Y灵虚卷总卷属性：");
				handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.灵虚卷属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.灵虚卷数值);
				handler.AppendLiteral(" 增加#r#Y灵虚卷化身列表：#n");
				stringBuilder12.Append(ref handler);
				for (int num3 = 0; num3 < Singleton<浮生录功能>.I.nppWUisDdB.Count; num3++)
				{
					if (num3 > 0)
					{
						stringBuilder.Append(",");
					}
					if (浮生录存档类2.化身列表.TryGetValue(Singleton<浮生录功能>.I.nppWUisDdB[num3].化身名字, out var value3))
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder13 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(9, 2, stringBuilder2);
						handler.AppendLiteral("#B");
						handler.AppendFormatted(Singleton<浮生录功能>.I.nppWUisDdB[num3].化身名字);
						handler.AppendLiteral("( ");
						handler.AppendFormatted(value3.激活进度);
						handler.AppendLiteral(" %)#n");
						stringBuilder13.Append(ref handler);
					}
					else
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder14 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
						handler.AppendLiteral("#n");
						handler.AppendFormatted(Singleton<浮生录功能>.I.nppWUisDdB[num3].化身名字);
						handler.AppendLiteral("#n");
						stringBuilder14.Append(ref handler);
					}
				}
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder15 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
				handler.AppendLiteral("#r#Y御元卷(");
				handler.AppendFormatted(浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.御元卷));
				handler.AppendLiteral("/");
				handler.AppendFormatted(Singleton<浮生录功能>.I.RNoWWSOvFy.Count);
				handler.AppendLiteral(")：#r");
				stringBuilder15.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder16 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(28, 2, stringBuilder2);
				handler.AppendLiteral("#Y御元卷总卷属性：");
				handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.御元卷属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.御元卷数值);
				handler.AppendLiteral(" 增加#r#Y御元卷化身列表：#n");
				stringBuilder16.Append(ref handler);
				for (int num4 = 0; num4 < Singleton<浮生录功能>.I.RNoWWSOvFy.Count; num4++)
				{
					if (num4 > 0)
					{
						stringBuilder.Append(",");
					}
					if (浮生录存档类2.化身列表.TryGetValue(Singleton<浮生录功能>.I.RNoWWSOvFy[num4].化身名字, out var value4))
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder17 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(9, 2, stringBuilder2);
						handler.AppendLiteral("#B");
						handler.AppendFormatted(Singleton<浮生录功能>.I.RNoWWSOvFy[num4].化身名字);
						handler.AppendLiteral("( ");
						handler.AppendFormatted(value4.激活进度);
						handler.AppendLiteral(" %)#n");
						stringBuilder17.Append(ref handler);
					}
					else
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder18 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
						handler.AppendLiteral("#n");
						handler.AppendFormatted(Singleton<浮生录功能>.I.RNoWWSOvFy[num4].化身名字);
						handler.AppendLiteral("#n");
						stringBuilder18.Append(ref handler);
					}
				}
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder19 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
				handler.AppendLiteral("#r#Y乘风卷(");
				handler.AppendFormatted(浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.乘风卷));
				handler.AppendLiteral("/");
				handler.AppendFormatted(Singleton<浮生录功能>.I.LHGWgAIE0Z.Count);
				handler.AppendLiteral(")：#r");
				stringBuilder19.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder20 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(28, 2, stringBuilder2);
				handler.AppendLiteral("#Y乘风卷总卷属性：");
				handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乘风卷属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乘风卷数值);
				handler.AppendLiteral(" 增加#r#Y乘风卷化身列表：#n");
				stringBuilder20.Append(ref handler);
				for (int num5 = 0; num5 < Singleton<浮生录功能>.I.LHGWgAIE0Z.Count; num5++)
				{
					if (num5 > 0)
					{
						stringBuilder.Append(",");
					}
					if (浮生录存档类2.化身列表.TryGetValue(Singleton<浮生录功能>.I.LHGWgAIE0Z[num5].化身名字, out var value5))
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder21 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(9, 2, stringBuilder2);
						handler.AppendLiteral("#B");
						handler.AppendFormatted(Singleton<浮生录功能>.I.LHGWgAIE0Z[num5].化身名字);
						handler.AppendLiteral("( ");
						handler.AppendFormatted(value5.激活进度);
						handler.AppendLiteral(" %)#n");
						stringBuilder21.Append(ref handler);
					}
					else
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder22 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(4, 1, stringBuilder2);
						handler.AppendLiteral("#n");
						handler.AppendFormatted(Singleton<浮生录功能>.I.LHGWgAIE0Z[num5].化身名字);
						handler.AppendLiteral("#n");
						stringBuilder22.Append(ref handler);
					}
				}
				封包_写2.写文本型(stringBuilder.ToString(), hasCount: true, 1, reverse: true);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000101000002"), hasCount: false, 0);
				封包_写2.写文本型("1~5人", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("40级及以上", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("几率获得：#I数值奖励|数值奖励#I", hasCount: true, 1, reverse: true);
				封包_写2.写文本型("活动", hasCount: true, 0, reverse: true);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
				封包_写 封包_写3 = new 封包_写();
				封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
				封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
				P_0.C_Send(封包_写3.取数据());
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("任务_浮生加护-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void OqAQtemtQ(MyNATSocketClient P_0)
	{
		try
		{
			if (!浮生录功能.GrAWb1KahR())
			{
				return;
			}
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("26030001"), hasCount: false, 0);
			封包_写2.写文本型("浮生加护活动|浮生加护活动", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("#G【浮生录系统】#n通过召唤不同星级的化身，玩家可以获得各种属性加成。化身分为不同的星级，从一星到五星不等，每个化身都有不同的属性和分类总卷，当每个化身被激活至100%时即可自动加护获得属性，并且分类总卷的所有化身全部激活时，也可获得属性加成 。", hasCount: true, 1, reverse: true);
			浮生录存档类 浮生录存档类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.浮生录数据.方案1 : P_0.user.存档数据.浮生录数据.方案2);
			StringBuilder stringBuilder = new StringBuilder("#Y当前已加护生效属性：#n#G#r");
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
			handler.AppendLiteral("#r#Y乱世书(");
			handler.AppendFormatted(浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.乱世书));
			handler.AppendLiteral("/");
			handler.AppendFormatted(Singleton<浮生录功能>.I.Ih6WdCmIqb.Count);
			handler.AppendLiteral(")：#r");
			stringBuilder3.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(16, 2, stringBuilder2);
			handler.AppendLiteral("#Y乱世书总卷属性：");
			handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制乱世书属性);
			handler.AppendLiteral(" ");
			handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乱世书数值);
			handler.AppendLiteral(" 增加#r");
			stringBuilder4.Append(ref handler);
			for (int num = 0; num < Singleton<浮生录功能>.I.Ih6WdCmIqb.Count; num++)
			{
				if (浮生录存档类2.化身列表.TryGetValue(Singleton<浮生录功能>.I.Ih6WdCmIqb[num].化身名字, out var value))
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(13, 5, stringBuilder2);
					handler.AppendLiteral("    ");
					handler.AppendFormatted((value.激活进度 >= 100) ? "#G" : "#B");
					handler.AppendFormatted(Singleton<浮生录功能>.I.Ih6WdCmIqb[num].化身名字);
					handler.AppendLiteral("(");
					handler.AppendFormatted(value.激活进度);
					handler.AppendLiteral("%)：");
					handler.AppendFormatted(Singleton<浮生录功能>.I.Ih6WdCmIqb[num].属性名字);
					handler.AppendLiteral("+");
					handler.AppendFormatted(Singleton<浮生录功能>.I.Ih6WdCmIqb[num].属性数值);
					handler.AppendLiteral("#n#r");
					stringBuilder5.Append(ref handler);
				}
				else
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
					handler.AppendLiteral("    #D");
					handler.AppendFormatted(Singleton<浮生录功能>.I.Ih6WdCmIqb[num].化身名字);
					handler.AppendLiteral("(0%)：");
					handler.AppendFormatted(Singleton<浮生录功能>.I.Ih6WdCmIqb[num].属性名字);
					handler.AppendLiteral("+");
					handler.AppendFormatted(Singleton<浮生录功能>.I.Ih6WdCmIqb[num].属性数值);
					handler.AppendLiteral("#n#r");
					stringBuilder6.Append(ref handler);
				}
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder7 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
			handler.AppendLiteral("#r#Y千钧卷(");
			handler.AppendFormatted(浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.千钧卷));
			handler.AppendLiteral("/");
			handler.AppendFormatted(Singleton<浮生录功能>.I.CsTWsdbKp5.Count);
			handler.AppendLiteral(")：#r");
			stringBuilder7.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder8 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(16, 2, stringBuilder2);
			handler.AppendLiteral("#Y千钧卷总卷属性：");
			handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制千钧卷属性);
			handler.AppendLiteral(" ");
			handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.千钧卷数值);
			handler.AppendLiteral(" 增加#r");
			stringBuilder8.Append(ref handler);
			for (int num2 = 0; num2 < Singleton<浮生录功能>.I.CsTWsdbKp5.Count; num2++)
			{
				if (浮生录存档类2.化身列表.TryGetValue(Singleton<浮生录功能>.I.CsTWsdbKp5[num2].化身名字, out var value2))
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder9 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(13, 5, stringBuilder2);
					handler.AppendLiteral("    ");
					handler.AppendFormatted((value2.激活进度 >= 100) ? "#G" : "#B");
					handler.AppendFormatted(Singleton<浮生录功能>.I.CsTWsdbKp5[num2].化身名字);
					handler.AppendLiteral("(");
					handler.AppendFormatted(value2.激活进度);
					handler.AppendLiteral("%)：");
					handler.AppendFormatted(Singleton<浮生录功能>.I.CsTWsdbKp5[num2].属性名字);
					handler.AppendLiteral("+");
					handler.AppendFormatted(Singleton<浮生录功能>.I.CsTWsdbKp5[num2].属性数值);
					handler.AppendLiteral("#n#r");
					stringBuilder9.Append(ref handler);
				}
				else
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder10 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
					handler.AppendLiteral("    #D");
					handler.AppendFormatted(Singleton<浮生录功能>.I.CsTWsdbKp5[num2].化身名字);
					handler.AppendLiteral("(0%)：");
					handler.AppendFormatted(Singleton<浮生录功能>.I.CsTWsdbKp5[num2].属性名字);
					handler.AppendLiteral("+");
					handler.AppendFormatted(Singleton<浮生录功能>.I.CsTWsdbKp5[num2].属性数值);
					handler.AppendLiteral("#n#r");
					stringBuilder10.Append(ref handler);
				}
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder11 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
			handler.AppendLiteral("#r#Y灵虚卷(");
			handler.AppendFormatted(浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.灵虚卷));
			handler.AppendLiteral("/");
			handler.AppendFormatted(Singleton<浮生录功能>.I.nppWUisDdB.Count);
			handler.AppendLiteral(")：#r");
			stringBuilder11.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder12 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(16, 2, stringBuilder2);
			handler.AppendLiteral("#Y灵虚卷总卷属性：");
			handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制灵虚卷属性);
			handler.AppendLiteral(" ");
			handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.灵虚卷数值);
			handler.AppendLiteral(" 增加#r");
			stringBuilder12.Append(ref handler);
			for (int num3 = 0; num3 < Singleton<浮生录功能>.I.nppWUisDdB.Count; num3++)
			{
				if (浮生录存档类2.化身列表.TryGetValue(Singleton<浮生录功能>.I.nppWUisDdB[num3].化身名字, out var value3))
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder13 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(13, 5, stringBuilder2);
					handler.AppendLiteral("    ");
					handler.AppendFormatted((value3.激活进度 >= 100) ? "#G" : "#B");
					handler.AppendFormatted(Singleton<浮生录功能>.I.nppWUisDdB[num3].化身名字);
					handler.AppendLiteral("(");
					handler.AppendFormatted(value3.激活进度);
					handler.AppendLiteral("%)：");
					handler.AppendFormatted(Singleton<浮生录功能>.I.nppWUisDdB[num3].属性名字);
					handler.AppendLiteral("+");
					handler.AppendFormatted(Singleton<浮生录功能>.I.nppWUisDdB[num3].属性数值);
					handler.AppendLiteral("#n#r");
					stringBuilder13.Append(ref handler);
				}
				else
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder14 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
					handler.AppendLiteral("    #D");
					handler.AppendFormatted(Singleton<浮生录功能>.I.nppWUisDdB[num3].化身名字);
					handler.AppendLiteral("(0%)：");
					handler.AppendFormatted(Singleton<浮生录功能>.I.nppWUisDdB[num3].属性名字);
					handler.AppendLiteral("+");
					handler.AppendFormatted(Singleton<浮生录功能>.I.nppWUisDdB[num3].属性数值);
					handler.AppendLiteral("#n#r");
					stringBuilder14.Append(ref handler);
				}
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder15 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
			handler.AppendLiteral("#r#Y御元卷(");
			handler.AppendFormatted(浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.御元卷));
			handler.AppendLiteral("/");
			handler.AppendFormatted(Singleton<浮生录功能>.I.RNoWWSOvFy.Count);
			handler.AppendLiteral(")：#r");
			stringBuilder15.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder16 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(16, 2, stringBuilder2);
			handler.AppendLiteral("#Y御元卷总卷属性：");
			handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制御元卷属性);
			handler.AppendLiteral(" ");
			handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.御元卷数值);
			handler.AppendLiteral(" 增加#r");
			stringBuilder16.Append(ref handler);
			for (int num4 = 0; num4 < Singleton<浮生录功能>.I.RNoWWSOvFy.Count; num4++)
			{
				if (浮生录存档类2.化身列表.TryGetValue(Singleton<浮生录功能>.I.RNoWWSOvFy[num4].化身名字, out var value4))
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder17 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(14, 5, stringBuilder2);
					handler.AppendLiteral("     ");
					handler.AppendFormatted((value4.激活进度 >= 100) ? "#G" : "#B");
					handler.AppendFormatted(Singleton<浮生录功能>.I.RNoWWSOvFy[num4].化身名字);
					handler.AppendLiteral("(");
					handler.AppendFormatted(value4.激活进度);
					handler.AppendLiteral("%)：");
					handler.AppendFormatted(Singleton<浮生录功能>.I.RNoWWSOvFy[num4].属性名字);
					handler.AppendLiteral("+");
					handler.AppendFormatted(Singleton<浮生录功能>.I.RNoWWSOvFy[num4].属性数值);
					handler.AppendLiteral("#n#r");
					stringBuilder17.Append(ref handler);
				}
				else
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder18 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
					handler.AppendLiteral("    #D");
					handler.AppendFormatted(Singleton<浮生录功能>.I.RNoWWSOvFy[num4].化身名字);
					handler.AppendLiteral("(0%)：");
					handler.AppendFormatted(Singleton<浮生录功能>.I.RNoWWSOvFy[num4].属性名字);
					handler.AppendLiteral("+");
					handler.AppendFormatted(Singleton<浮生录功能>.I.RNoWWSOvFy[num4].属性数值);
					handler.AppendLiteral("#n#r");
					stringBuilder18.Append(ref handler);
				}
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder19 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(13, 2, stringBuilder2);
			handler.AppendLiteral("#r#Y乘风卷(");
			handler.AppendFormatted(浮生录存档类2.化身列表.Values.Count( (浮生录化身列表类 x) => x.分类 == AllEnums.化身分类.乘风卷));
			handler.AppendLiteral("/");
			handler.AppendFormatted(Singleton<浮生录功能>.I.LHGWgAIE0Z.Count);
			handler.AppendLiteral(")：#r");
			stringBuilder19.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder20 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(16, 2, stringBuilder2);
			handler.AppendLiteral("#Y乘风卷总卷属性：");
			handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.定制乘风卷属性);
			handler.AppendLiteral(" ");
			handler.AppendFormatted(Singleton<全局变量类>.I.浮生录配置.乘风卷数值);
			handler.AppendLiteral(" 增加#r");
			stringBuilder20.Append(ref handler);
			for (int num5 = 0; num5 < Singleton<浮生录功能>.I.LHGWgAIE0Z.Count; num5++)
			{
				if (浮生录存档类2.化身列表.TryGetValue(Singleton<浮生录功能>.I.LHGWgAIE0Z[num5].化身名字, out var value5))
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder21 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(14, 5, stringBuilder2);
					handler.AppendLiteral("     ");
					handler.AppendFormatted((value5.激活进度 >= 100) ? "#G" : "#B");
					handler.AppendFormatted(Singleton<浮生录功能>.I.LHGWgAIE0Z[num5].化身名字);
					handler.AppendLiteral("(");
					handler.AppendFormatted(value5.激活进度);
					handler.AppendLiteral("%)：");
					handler.AppendFormatted(Singleton<浮生录功能>.I.LHGWgAIE0Z[num5].属性名字);
					handler.AppendLiteral("+");
					handler.AppendFormatted(Singleton<浮生录功能>.I.LHGWgAIE0Z[num5].属性数值);
					handler.AppendLiteral("#n#r");
					stringBuilder21.Append(ref handler);
				}
				else
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder22 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
					handler.AppendLiteral("    #D");
					handler.AppendFormatted(Singleton<浮生录功能>.I.LHGWgAIE0Z[num5].化身名字);
					handler.AppendLiteral("(0%)：");
					handler.AppendFormatted(Singleton<浮生录功能>.I.LHGWgAIE0Z[num5].属性名字);
					handler.AppendLiteral("+");
					handler.AppendFormatted(Singleton<浮生录功能>.I.LHGWgAIE0Z[num5].属性数值);
					handler.AppendLiteral("#n#r");
					stringBuilder22.Append(ref handler);
				}
			}
			封包_写2.写文本型(stringBuilder.ToString(), hasCount: true, 1, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000101000002"), hasCount: false, 0);
			封包_写2.写文本型("1~5人", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("40级及以上", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("几率获得：#I数值奖励|数值奖励#I", hasCount: true, 1, reverse: true);
			封包_写2.写文本型("活动", hasCount: true, 0, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			P_0.C_Send(封包_写3.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("中州_任务_浮生加护-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void DGvE5pDFW(MyNATSocketClient P_0)
	{
		try
		{
			if (!AZI1HsR8MjRfegmETY5.zmURXpEr61())
			{
				return;
			}
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("26030001"), hasCount: false, 0);
			封包_写2.写文本型("宠物转生活动|宠物转生活动", hasCount: true, 0, reverse: true);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(121, 2);
			defaultInterpolatedStringHandler.AppendLiteral("#Y九天应雷普化天尊#n巡游下界时发现人间界的宠物似乎有些羸弱，已经无法更好的与主人并肩战斗。特此化身#Y");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.NPC数据.npc名字);
			defaultInterpolatedStringHandler.AppendLiteral("#n下界为宠物开启转生功能，增强宠物的战斗力。#r#M温馨提示：#n宠物喂养#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物转生配置.转生洗髓道具);
			defaultInterpolatedStringHandler.AppendLiteral("#n有一定几率可以重新为宠物洗髓出未获得的转生专属技能。");
			封包_写2.写文本型(defaultInterpolatedStringHandler.ToStringAndClear(), hasCount: true, 1, reverse: true);
			StringBuilder stringBuilder = new StringBuilder("你的以下宠物已经参与了转生活动：#r");
			宠物转生列表类 宠物转生列表类2 = null;
			宠物缓存数据类[] 宠物数据 = P_0.user.宠物数据;
			foreach (宠物缓存数据类 宠物缓存数据类2 in 宠物数据)
			{
				if (宠物缓存数据类2.宠物ID != 0 && !string.IsNullOrWhiteSpace(宠物缓存数据类2.IID) && Singleton<全局变量类>.I.宠物存档表.TryGetValue(宠物缓存数据类2.IID, out var value) && (value.转生数据.转生次数 > 0 || value.转生数据.Is开启) && value.转生数据.转生次数 <= Singleton<全局变量类>.I.宠物转生配置.转生阶段.Count)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(11, 4, stringBuilder2);
					handler.AppendLiteral("#r#G");
					handler.AppendFormatted(宠物缓存数据类2.PetID);
					handler.AppendLiteral(".");
					handler.AppendFormatted(宠物缓存数据类2.昵称A);
					handler.AppendLiteral(" - ");
					handler.AppendFormatted(宠物缓存数据类2.等级);
					handler.AppendLiteral("级 ");
					handler.AppendFormatted(value.转生数据.转生次数);
					handler.AppendLiteral("转");
					stringBuilder3.Append(ref handler);
					if (value.转生数据.Is开启 && value.转生数据.转生次数 < Singleton<全局变量类>.I.宠物转生配置.转生阶段.Count)
					{
						宠物转生列表类2 = Singleton<全局变量类>.I.宠物转生配置.转生阶段[value.转生数据.转生次数];
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder4 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
						handler.AppendLiteral("#R(+");
						handler.AppendFormatted(100.0 / (double)宠物转生列表类2.转生道具数量 * (double)value.转生数据.道具数量, "F2");
						handler.AppendLiteral("%)#n");
						stringBuilder4.Append(ref handler);
					}
				}
			}
			封包_写2.写文本型(stringBuilder.ToString(), hasCount: true, 1, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000101000002"), hasCount: false, 0);
			封包_写2.写文本型("1~5人", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("40级及以上", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("几率获得：#I数值奖励|数值奖励#I", hasCount: true, 1, reverse: true);
			封包_写2.写文本型("活动", hasCount: true, 0, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			P_0.C_Send(封包_写3.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("任务_宠物转生-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void Fga3MjO0r(MyNATSocketClient P_0)
	{
		try
		{
			if (版本相关处理.Is巅峰对决)
			{
				封包_写 封包_写2 = new 封包_写();
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("26030001"), hasCount: false, 0);
				封包_写2.写文本型("巅峰套装系统|巅峰套装系统", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("本服巅峰套装拥有神鬼莫测之力，首次穿戴齐全同一阶段装备则为激活，激活后的装备自动成为死绑状态，并且提升玩家等级", hasCount: true, 1, reverse: true);
				封包_写2.写文本型(Singleton<版本相关处理>.I.组装任务提示(P_0), hasCount: true, 1, reverse: true);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000101000002"), hasCount: false, 0);
				封包_写2.写文本型("1~5人", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("40级及以上", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("几率获得：", hasCount: true, 1, reverse: true);
				封包_写2.写文本型("活动", hasCount: true, 0, reverse: true);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
				封包_写 封包_写3 = new 封包_写();
				封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
				封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
				P_0.C_Send(封包_写3.取数据());
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("任务_巅峰对决-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void jgYYACInD(MyNATSocketClient P_0)
	{
		try
		{
			if (全局变量类.点卡使用中)
			{
				封包_写 封包_写2 = new 封包_写();
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("26030001"), hasCount: false, 0);
				封包_写2.写文本型("点卡系统|点卡系统", hasCount: true, 0, reverse: true);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
				defaultInterpolatedStringHandler.AppendLiteral("#Y本服特制点卡系统，每在线1分钟扣除#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.点卡配置.每分钟扣除点);
				defaultInterpolatedStringHandler.AppendLiteral("#n点点卡点数。");
				封包_写2.写文本型(defaultInterpolatedStringHandler.ToStringAndClear(), hasCount: true, 1, reverse: true);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
				defaultInterpolatedStringHandler.AppendLiteral("#Y当前剩余点卡点数：#n");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.点卡存档.当前点数);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				封包_写2.写文本型(stringBuilder.ToString(), hasCount: true, 1, reverse: true);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000101000002"), hasCount: false, 0);
				封包_写2.写文本型("1~5人", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("40级及以上", hasCount: true, 0, reverse: true);
				封包_写2.写文本型("几率获得：#I数值奖励|数值奖励#I", hasCount: true, 1, reverse: true);
				封包_写2.写文本型("活动", hasCount: true, 0, reverse: true);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
				封包_写 封包_写3 = new 封包_写();
				封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
				封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
				P_0.C_Send(封包_写3.取数据());
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("任务_点卡系统-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal async Task IEwpSTAlC(MyNATSocketClient P_0)
	{
		try
		{
			if (!Singleton<全局变量类>.I.在线泡点配置.泡点开关)
			{
				await Task.Delay(0);
				return;
			}
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("26030001"), hasCount: false, 0);
			封包_写2.写文本型("每日泡点活动|每日泡点活动", hasCount: true, 0, reverse: true);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
			defaultInterpolatedStringHandler.AppendLiteral("#Y为庆贺新服火爆开启，每日在线#Y");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点间隔分钟);
			defaultInterpolatedStringHandler.AppendLiteral("#n分钟领取好礼。");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.双倍开关 ? "果然在天上集市进行摆摊后会获得双倍的奖励哦" : string.Empty);
			封包_写2.写文本型(defaultInterpolatedStringHandler.ToStringAndClear(), hasCount: true, 1, reverse: true);
			StringBuilder stringBuilder = new StringBuilder();
			if (Singleton<全局变量类>.I.在线泡点配置.泡点地图 == "0")
			{
				stringBuilder.Append("#Y可领取泡点奖励地图：#G所有地图#n");
			}
			else if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.在线泡点配置.泡点地图))
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(16, 1, stringBuilder2);
				handler.AppendLiteral("#Y可领取泡点奖励地图：#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点地图);
				handler.AppendLiteral("#n");
				stringBuilder3.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励金元宝 != 0)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#r#Y可领取金元宝：#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励金元宝);
				handler.AppendLiteral("#n");
				handler.AppendFormatted((Singleton<全局变量类>.I.在线泡点配置.双倍开关 && P_0.user.存档数据.is摆摊中) ? "×2" : string.Empty);
				stringBuilder4.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励银元宝 != 0)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#r#Y可领取银元宝：#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励银元宝);
				handler.AppendLiteral("#n");
				handler.AppendFormatted((Singleton<全局变量类>.I.在线泡点配置.双倍开关 && P_0.user.存档数据.is摆摊中) ? "×2" : string.Empty);
				stringBuilder5.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励南极点 != 0)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder6 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#r#Y可领取南极点：#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励南极点);
				handler.AppendLiteral("#n");
				handler.AppendFormatted((Singleton<全局变量类>.I.在线泡点配置.双倍开关 && P_0.user.存档数据.is摆摊中) ? "×2" : string.Empty);
				stringBuilder6.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励累充点 != 0)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder7 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#r#Y可领取累充点：#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励累充点);
				handler.AppendLiteral("#n");
				handler.AppendFormatted((Singleton<全局变量类>.I.在线泡点配置.双倍开关 && P_0.user.存档数据.is摆摊中) ? "×2" : string.Empty);
				stringBuilder7.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励灵气值 != 0)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder8 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
				handler.AppendLiteral("#r#Y可领取灵气值：#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励灵气值);
				handler.AppendLiteral("#n");
				handler.AppendFormatted((Singleton<全局变量类>.I.在线泡点配置.双倍开关 && P_0.user.存档数据.is摆摊中) ? "×2" : string.Empty);
				stringBuilder8.Append(ref handler);
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具) && Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量 > 0)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder9 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(14, 2, stringBuilder2);
				handler.AppendLiteral("#r#Y可领取道具：#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具);
				handler.AppendLiteral("#n");
				handler.AppendFormatted((Singleton<全局变量类>.I.在线泡点配置.双倍开关 && P_0.user.存档数据.is摆摊中) ? $"{Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量 * 2}" : $"{Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量}");
				stringBuilder9.Append(ref handler);
			}
			封包_写2.写文本型(stringBuilder.ToString(), hasCount: true, 1, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0000000101000002"), hasCount: false, 0);
			封包_写2.写文本型("1~5人", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("40级及以上", hasCount: true, 0, reverse: true);
			封包_写2.写文本型("几率获得：#I数值奖励|数值奖励#I", hasCount: true, 1, reverse: true);
			封包_写2.写文本型("活动", hasCount: true, 0, reverse: true);
			封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("00000000"), hasCount: false, 0);
			封包_写 封包_写3 = new 封包_写();
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			P_0.C_Send(封包_写3.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("任务_每日泡点活动-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public UuQEWHhexEnQTYynfh()
	{
	}

	static UuQEWHhexEnQTYynfh()
	{
	}
}
