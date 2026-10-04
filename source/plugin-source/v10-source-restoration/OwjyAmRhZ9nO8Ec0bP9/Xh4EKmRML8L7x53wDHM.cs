using System;
using System.Runtime.CompilerServices;
using System.Text;
using GJSyJYUDOfxE331QwT1;
using R8lTaqgbEc6MvH2j6n0;
using UbblDNG1yFpxk6Q0ui4;
using XWKUjNiqpjLqc4emuCT;
using irBd2ubEj0IMVbGRstp;
using xqlPMM2TJRNXpZnNDFn;

namespace OwjyAmRhZ9nO8Ec0bP9;

internal class Xh4EKmRML8L7x53wDHM : Singleton<Xh4EKmRML8L7x53wDHM>
{
	private static StringBuilder OggR7UM8bG;

	
	internal void 小助手_呼叫(MyNATSocketClient myclient)
	{
		myclient.助手对话.Clear();
		StringBuilder 助手对话 = myclient.助手对话;
		StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(56, 1, 助手对话);
		handler.AppendLiteral("#G尊敬的#Y");
		handler.AppendFormatted(myclient.user.人物数据.昵称);
		handler.AppendLiteral("#G道友您好，欢迎使用小助手！#r#Y温馨提示：在当前频道发送CDK卡密即可快速兑换奖励了#r#n");
		助手对话.Append(ref handler);
		myclient.助手对话.Append("[点击查看人物详情/小助手_详情查询]");
		myclient.助手对话.Append("[点击查看所有指令/小助手_指令查询]");
		if (xH3TPsiexTnpJAMMnJm.clyBlug2Xa())
		{
			myclient.助手对话.Append("[点击快速充值支付/小助手_内充支付]");
			if (Singleton<全局变量类>.I.内充支付配置.开启抽奖模式)
			{
				myclient.助手对话.Append("[【打开】抽奖界面/小助手_在线抽奖]");
			}
		}
		myclient.C_Send(Singleton<WdAPI>.I.对话生成_NPC(100, myclient.user.人物数据.形象ID, "小助手精灵", myclient.助手对话.ToString()));
	}

	
	internal void YqYRvRZH8x(MyNATSocketClient P_0, string P_1)
	{
		if (P_1 == "小助手_呼叫")
		{
			小助手_呼叫(P_0);
			return;
		}
		if (P_1.Contains("小助手_详情", StringComparison.CurrentCulture))
		{
			小助手_详情(P_0, P_1);
			return;
		}
		if (P_1.Contains("小助手_指令", StringComparison.CurrentCulture))
		{
			小助手_指令(P_0, P_1);
			return;
		}
		if (xH3TPsiexTnpJAMMnJm.clyBlug2Xa())
		{
			if (P_1 == "小助手_内充支付")
			{
				WdAPI i = Singleton<WdAPI>.I;
				string 执行关键词 = "!^内充支付充值";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.点卡充值类型);
				defaultInterpolatedStringHandler.AppendLiteral("充值比例 1：");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.点卡充值比例);
				defaultInterpolatedStringHandler.AppendLiteral("#r请输入你要充值的金额：");
				P_0.C_Send(i.组包输入数字框(P_0, 执行关键词, defaultInterpolatedStringHandler.ToStringAndClear(), 9999));
				return;
			}
			if (Singleton<全局变量类>.I.内充支付配置.开启抽奖模式 && P_1 == "小助手_在线抽奖")
			{
				P_0.C_Send(Singleton<WdAPI>.I.vdSoet7MIX(Singleton<全局变量类>.I.内充支付配置.剩余奖池.Count));
				return;
			}
		}
		P_1.Contains("小助手_活动", StringComparison.CurrentCulture);
	}

	
	internal void 小助手_详情(MyNATSocketClient myclient, string 内容)
	{
		myclient.助手对话.Clear();
		if (内容 == "小助手_详情查询")
		{
			StringBuilder 助手对话 = myclient.助手对话;
			StringBuilder stringBuilder = 助手对话;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(18, 4, 助手对话);
			handler.AppendLiteral("#Y");
			handler.AppendFormatted(myclient.user.人物数据.昵称);
			handler.AppendLiteral(" #RLv.");
			handler.AppendFormatted(myclient.user.属性数据.等级);
			handler.AppendLiteral("#L(");
			handler.AppendFormatted((myclient.user.缓存数据.is会员卡 && myclient.user.缓存数据.当前会员天数 > 0) ? "#Y位列仙班#L" : "#n凡人#L");
			handler.AppendLiteral(")#n ");
			handler.AppendFormatted(myclient.user.缓存数据.is战斗中 ? "战斗中" : "非战斗中");
			handler.AppendLiteral(" #r");
			stringBuilder.Append(ref handler);
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND())
			{
				助手对话 = myclient.助手对话;
				StringBuilder stringBuilder2 = 助手对话;
				handler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, 助手对话);
				handler.AppendLiteral("#G当前境界：#Y");
				handler.AppendFormatted(myclient.user.存档数据.元神存档.当前境界);
				handler.AppendLiteral("#r");
				stringBuilder2.Append(ref handler);
			}
			if (myclient.user.队伍数据.成员列表.Count <= 0)
			{
				myclient.助手对话.Append("#R队伍：无#r");
			}
			else if (myclient.user.缓存数据.is队伍中)
			{
				助手对话 = myclient.助手对话;
				StringBuilder stringBuilder3 = 助手对话;
				handler = new StringBuilder.AppendInterpolatedStringHandler(7, 1, 助手对话);
				handler.AppendLiteral("#R队伍：");
				handler.AppendFormatted(myclient.user.队伍数据.is队长 ? "队伍中(队长)" : "队伍中");
				handler.AppendLiteral("#r");
				stringBuilder3.Append(ref handler);
			}
			else
			{
				myclient.助手对话.Append("#R队伍：暂离#r");
			}
			助手对话 = myclient.助手对话;
			StringBuilder stringBuilder4 = 助手对话;
			handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, 助手对话);
			handler.AppendLiteral("#G南极点：#Y");
			handler.AppendFormatted(myclient.user.存档数据.南极抽奖次数);
			handler.AppendLiteral("#r");
			stringBuilder4.Append(ref handler);
			助手对话 = myclient.助手对话;
			StringBuilder stringBuilder5 = 助手对话;
			handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, 助手对话);
			handler.AppendLiteral("#G累充点：#Y");
			handler.AppendFormatted(myclient.user.存档数据.累计充值金额);
			handler.AppendLiteral("#r");
			stringBuilder5.Append(ref handler);
			助手对话 = myclient.助手对话;
			StringBuilder stringBuilder6 = 助手对话;
			handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, 助手对话);
			handler.AppendLiteral("#G奇宝点：#Y");
			handler.AppendFormatted(myclient.user.存档数据.奇宝斋存档.奇宝斋余额);
			handler.AppendLiteral("#r");
			stringBuilder6.Append(ref handler);
			助手对话 = myclient.助手对话;
			StringBuilder stringBuilder7 = 助手对话;
			handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, 助手对话);
			handler.AppendLiteral("#G灵气值：#Y");
			handler.AppendFormatted(myclient.user.存档数据.数值存档.灵气值);
			handler.AppendLiteral("#r");
			stringBuilder7.Append(ref handler);
			if (YHfw7nGpg7WfdCBKDH4.qapfK9UWNV() && Singleton<全局变量类>.I.摆摊配置.货币类型 == AllEnums.数值Type.道具)
			{
				助手对话 = myclient.助手对话;
				StringBuilder stringBuilder8 = 助手对话;
				handler = new StringBuilder.AppendInterpolatedStringHandler(11, 2, 助手对话);
				handler.AppendLiteral("#G百宝囊：#Y");
				handler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
				handler.AppendLiteral("*");
				handler.AppendFormatted(myclient.user.存档数据.数值存档.摆摊道具货币);
				handler.AppendLiteral("#r");
				stringBuilder8.Append(ref handler);
			}
			myclient.助手对话.Append("[返回/小助手_呼叫]");
			myclient.C_Send(Singleton<WdAPI>.I.对话生成_NPC(100, myclient.user.人物数据.形象ID, "小助手精灵", myclient.助手对话.ToString()));
		}
	}

	
	internal void 小助手_指令(MyNATSocketClient myclient, string 内容)
	{
		myclient.助手对话.Clear();
		if (内容 == "小助手_指令查询")
		{
			myclient.助手对话.Append("#M所有指令在当前频道输入发送即可：#r");
			if (Singleton<全局变量类>.I.签到配置.功能开关)
			{
				StringBuilder 助手对话 = myclient.助手对话;
				StringBuilder stringBuilder = 助手对话;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(25, 2, 助手对话);
				handler.AppendLiteral("#G指令：#Y签到#L（");
				handler.AppendFormatted(myclient.user.存档数据.签到数据.本日是否签到 ? "已签到" : "未签到");
				handler.AppendLiteral("，累计签到#R");
				handler.AppendFormatted(myclient.user.存档数据.签到数据.累计签到天数);
				handler.AppendLiteral("#n天）#r");
				stringBuilder.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.在线抽奖配置.功能开关)
			{
				myclient.助手对话.Append("#G指令：#Y抽奖#r");
			}
			if (Singleton<全局变量类>.I.圣无双配置.功能开关 && myclient.user.人物数据.账号 == Singleton<全局变量类>.I.config.挂载GM账号)
			{
				myclient.助手对话.Append("#G指令：#Y启动无双#L（可快速开启无双争夺战）#r");
			}
			if (Singleton<全局变量类>.I.推荐拉人配置.功能开关)
			{
				myclient.助手对话.Append("#G指令：#Y推荐查询#L（查好友推荐信息）#r");
			}
			myclient.助手对话.Append("#G指令：#Y退出战斗#L（战斗中可用，试道场中无效）#r");
			myclient.助手对话.Append("#G指令：#Y找回属性#L（找回前不可有剩余相性点）#r");
			myclient.助手对话.Append("#G指令：#Y下线#L（自动安全下线）#r");
			if (myclient.user.人物数据.账号 == Singleton<全局变量类>.I.config.挂载GM账号)
			{
				myclient.助手对话.Append("#G指令：#Y清空全区相性#L(GM可快速清空全区玩家相性，需要所有玩家下线以后操作)#r");
			}
			if (!myclient.user.缓存数据.is战斗中 && Singleton<全局变量类>.I.签到配置.功能开关 && !myclient.user.存档数据.签到数据.本日是否签到)
			{
				myclient.助手对话.Append("[点击进行本日签到/小助手_指令操作_签到]");
			}
			if (!myclient.user.缓存数据.is战斗中 && Singleton<全局变量类>.I.在线抽奖配置.功能开关)
			{
				StringBuilder 助手对话 = myclient.助手对话;
				StringBuilder stringBuilder2 = 助手对话;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(24, 2, 助手对话);
				handler.AppendLiteral("[点击进行在线抽奖（");
				handler.AppendFormatted(Singleton<全局变量类>.I.在线抽奖配置.消耗数值);
				handler.AppendFormatted(Singleton<全局变量类>.I.在线抽奖配置.消耗类型);
				handler.AppendLiteral("）/小助手_指令操作_抽奖]");
				stringBuilder2.Append(ref handler);
			}
			if (!myclient.user.缓存数据.is战斗中 && Singleton<全局变量类>.I.推荐拉人配置.功能开关)
			{
				myclient.助手对话.Append("[点击查询拉人详情/小助手_指令操作_推荐]");
			}
			if (myclient.user.缓存数据.is战斗中)
			{
				myclient.助手对话.Append("[点击快速退出战斗/小助手_指令操作_战斗]");
			}
			myclient.助手对话.Append("[点击清空背包第一页/小助手_指令操作_背包1][点击清空背包第二页/小助手_指令操作_背包2][点击清空背包第三页/小助手_指令操作_背包3]");
			if (myclient.user.缓存数据.is坐骑风灵丸)
			{
				myclient.助手对话.Append("[点击清空背包第四页/小助手_指令操作_背包4]");
			}
			myclient.助手对话.Append("[返回/小助手_呼叫]");
			myclient.C_Send(Singleton<WdAPI>.I.对话生成_NPC(100, myclient.user.人物数据.形象ID, "小助手精灵", myclient.助手对话.ToString()));
		}
		else if (内容.Contains("小助手_指令操作_", StringComparison.CurrentCulture))
		{
			if (!myclient.user.缓存数据.is战斗中 && 内容 == "小助手_指令操作_签到")
			{
				Singleton<p63Ra5gwg6vJ45gPiim>.I.xnmgskXkX0(myclient);
			}
			else if (!myclient.user.缓存数据.is战斗中 && 内容 == "小助手_指令操作_抽奖")
			{
				Singleton<cGiRplbQfaJV9guWDIS>.I.cqMbxmXGun(myclient);
			}
			else if (!myclient.user.缓存数据.is战斗中 && 内容 == "小助手_指令操作_推荐")
			{
				myclient.C_Send(Singleton<EfHAVFUgqrnaj1QwnLW>.I.DdCUoGfo6q(myclient));
			}
			else if (myclient.user.缓存数据.is战斗中 && 内容 == "小助手_指令操作_战斗")
			{
				Singleton<WdAPI>.I.EOYImZQJeG(myclient, true);
				myclient.C_Send(Singleton<WdAPI>.I.提示_中心提醒("管理员以成功为您退出战斗,请耐心等待战斗回合结束！"));
				myclient.S_Send(Singleton<WdAPI>.I.zXxoPwQcb0(myclient.user.人物数据.昵称));
			}
			else if (内容 == "小助手_指令操作_背包1")
			{
				myclient.S_Send(Singleton<WdAPI>.I.sH3IQ5eetN(myclient, 101, 120));
			}
			else if (内容 == "小助手_指令操作_背包2")
			{
				myclient.S_Send(Singleton<WdAPI>.I.sH3IQ5eetN(myclient, 121, 140));
			}
			else if (内容 == "小助手_指令操作_背包3")
			{
				myclient.S_Send(Singleton<WdAPI>.I.sH3IQ5eetN(myclient, 141, 160));
			}
			else if (myclient.user.缓存数据.is坐骑风灵丸 && 内容 == "小助手_指令操作_背包4")
			{
				myclient.S_Send(Singleton<WdAPI>.I.sH3IQ5eetN(myclient, 161, 180));
			}
		}
	}

	
	public Xh4EKmRML8L7x53wDHM()
	{
	}

	
	static Xh4EKmRML8L7x53wDHM()
	{
		OggR7UM8bG = new StringBuilder();
	}
}
