using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using CKS3DKsTBrUPphoeWmS;
using F2RFuVfrhBPBhCG1Yrv;
using HS2GfXB7hJCX6tDXuc0;
using KEvDjBdeoLOoBKWXFAH;
using MGlqQ3brPEBI9uuUVKc;
using MOuTmqw7qFKlAkRNasG;
using OwjyAmRhZ9nO8Ec0bP9;
using P80h4IDRZbpvERvsoap;
using QuSFUe6R0602j4mCi3W;
using R0F7EJKsPwFRj7h6amU;
using S0XwWmgI18jlYE3IPoe;
using SGIgOgiC7KPqObpOnGQ;
using Serilog;
using SuTsFOBHSZNdBh5bUZB;
using UbblDNG1yFpxk6Q0ui4;
using WbRTrCLpc2rxKDLScV;
using XWKUjNiqpjLqc4emuCT;
using YOheREbBnDq6LvvWZEr;
using eYLrotRIovAGM9lAtVf;
using gEdioZfkTLM2TXU6jgd;
using o6qwVWbu5whwUP31LfM;
using r6H7Ets2Rns31EhC17Y;
using vBIs2Rf2vSSk1OdhoS7;
using xjMDbr53dgFg8eTWhG;
using xqlPMM2TJRNXpZnNDFn;
using y24fbEG8KTuMIdiCbG1;
using zA970iRwZCxW0g6uljn;

public class 请求数据响应处理类 : Singleton<请求数据响应处理类>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public MyNATSocketClient bhPynindCs;

		
		public _003C_003Ec__DisplayClass0_0()
		{
		}

		
		internal bool fJiyc9BdNP(角色存档数据类 x)
		{
			return x.账号 == bhPynindCs.账号;
		}

		static _003C_003Ec__DisplayClass0_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_1
	{
		public int AMTyMxLMIY;

		
		public _003C_003Ec__DisplayClass0_1()
		{
		}

		
		internal bool NnWy5Ok8ZI(int x)
		{
			return x == AMTyMxLMIY;
		}

		static _003C_003Ec__DisplayClass0_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public string YX9y7AVKdk;

		public string UtIyaBYpTU;

		
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		
		internal bool dK9yh5iDc6(string x)
		{
			return x == YX9y7AVKdk;
		}

		
		internal bool RcryvxdRFI(string x)
		{
			return x == UtIyaBYpTU;
		}

		static _003C_003Ec__DisplayClass3_0()
		{
		}
	}

	
	public byte[] 请求处理中心(MyNATSocketClient myclient, byte[] buffer)
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals239 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals239.bhPynindCs = myclient;
		try
		{
			if (myclient == null || !MyFixedHeaderRequestInfo.IsValidFrame(buffer))
			{
				return null;
			}
			_003C_003Ec__DisplayClass0_1 CS_0024_003C_003E8__locals238 = new _003C_003Ec__DisplayClass0_1();
			CS_0024_003C_003E8__locals238.AMTyMxLMIY = Singleton<WdAPI>.I.获取包头(buffer, 10, 2);
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.config.记录账号列表) && !string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称) && Singleton<ByteAPI>.I.寻找文本(Singleton<全局变量类>.I.config.记录账号列表, "," + CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称 + ","))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 4);
				defaultInterpolatedStringHandler.AppendLiteral("【请求】 【昵称：");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("】【id：");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.角色ID);
				defaultInterpolatedStringHandler.AppendLiteral("】【包头：[");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.请求包头枚举)CS_0024_003C_003E8__locals238.AMTyMxLMIY);
				defaultInterpolatedStringHandler.AppendLiteral("]】【内容：");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(buffer));
				defaultInterpolatedStringHandler.AppendLiteral("】");
				Log.ForContext("AuditCategory", "player-packet").Debug(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			if (全局变量类.Is调试)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
				defaultInterpolatedStringHandler.AppendLiteral("【请求-封包测试】 角色编号：");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(Singleton<ByteAPI>.I.到字节集固定反转(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.角色ID)));
				defaultInterpolatedStringHandler.AppendLiteral("     包头：[");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.请求包头枚举)CS_0024_003C_003E8__locals238.AMTyMxLMIY);
				defaultInterpolatedStringHandler.AppendLiteral("]  内容：[");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(buffer));
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.ForContext("AuditCategory", "player-packet").Debug(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			if (!CS_0024_003C_003E8__locals239.bhPynindCs.使用中 && CS_0024_003C_003E8__locals238.AMTyMxLMIY != 2821 && CS_0024_003C_003E8__locals238.AMTyMxLMIY != 6915 && CS_0024_003C_003E8__locals238.AMTyMxLMIY != 9040 && CS_0024_003C_003E8__locals238.AMTyMxLMIY != 13140 && CS_0024_003C_003E8__locals238.AMTyMxLMIY != 13142 && CS_0024_003C_003E8__locals238.AMTyMxLMIY != 16676 && CS_0024_003C_003E8__locals238.AMTyMxLMIY != 8402 && CS_0024_003C_003E8__locals238.AMTyMxLMIY != 63939 && CS_0024_003C_003E8__locals238.AMTyMxLMIY != 4192 && CS_0024_003C_003E8__locals238.AMTyMxLMIY != 15914 && CS_0024_003C_003E8__locals238.AMTyMxLMIY != 6913)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 3);
				defaultInterpolatedStringHandler.AppendLiteral("【非法请求】IP：");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals239.bhPynindCs.当前client.IP);
				defaultInterpolatedStringHandler.AppendLiteral("  包头：[");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals238.AMTyMxLMIY);
				defaultInterpolatedStringHandler.AppendLiteral("]  内容：[");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(buffer));
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.ForContext("AuditCategory", "player-anomaly").Error(defaultInterpolatedStringHandler.ToStringAndClear());
				CS_0024_003C_003E8__locals239.bhPynindCs.Close();
				return null;
			}
			if (Singleton<全局变量类>.I.config.异常封包日志开关 && !Singleton<WdAPI>.I.bJboBw7BEu(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 7);
				defaultInterpolatedStringHandler.AppendLiteral("【");
				defaultInterpolatedStringHandler.AppendLiteral("异常");
				defaultInterpolatedStringHandler.AppendLiteral("请求封包】包头：[");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.请求包头枚举)CS_0024_003C_003E8__locals238.AMTyMxLMIY);
				defaultInterpolatedStringHandler.AppendLiteral("] [线路：");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals239.bhPynindCs.插件端口);
				defaultInterpolatedStringHandler.AppendLiteral("]  账号：[");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral("]  角色(");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.GID);
				defaultInterpolatedStringHandler.AppendLiteral(")：[");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("]  内容：[");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(buffer));
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.ForContext("AuditCategory", "player-anomaly").Error(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			if (Singleton<ByteAPI>.I.寻找字节集(buffer, "180天年费会员卡"))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
				defaultInterpolatedStringHandler.AppendLiteral("【黑名单】时间：");
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now);
				defaultInterpolatedStringHandler.AppendLiteral(" 账号：");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral(" 名字：");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral(" 原因：捣乱崩服");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return null;
			}
			if (CS_0024_003C_003E8__locals238.AMTyMxLMIY == 12243 || CS_0024_003C_003E8__locals238.AMTyMxLMIY == 64924 || CS_0024_003C_003E8__locals238.AMTyMxLMIY == 64932)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
				defaultInterpolatedStringHandler.AppendLiteral("【黑名单】时间：");
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now);
				defaultInterpolatedStringHandler.AppendLiteral(" 账号：");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral(" 名字：");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral(" 原因：捣乱崩服");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("草泥马瘪犊子玩意蹦我服，吃屎把你！"));
				if (!DB.I.锁定账号操作(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.账号, "1"))
				{
					Log.Error("崩服-错误：账号锁定失败");
				}
				Singleton<WdAPI>.I.WT9IHmFS6c(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称);
				Log.Error("崩服3-错误：[" + CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称 + "]强制下线");
				CS_0024_003C_003E8__locals239.bhPynindCs.Close();
				return null;
			}
			if (CS_0024_003C_003E8__locals239.bhPynindCs.当前权限 != 300 && 问道数据类.GM权限请求包头组.Any( (int x) => x == CS_0024_003C_003E8__locals238.AMTyMxLMIY))
			{
				Singleton<WdAPI>.I.WT9IHmFS6c(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称);
				Log.Error("卡GM权限-错误：[" + CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称 + "]强制下线");
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
				defaultInterpolatedStringHandler.AppendLiteral("【黑名单】时间：");
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now);
				defaultInterpolatedStringHandler.AppendLiteral(" 账号：");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral(" 名字：");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral(" 原因：卡GM权限");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return null;
			}
			if (CS_0024_003C_003E8__locals238.AMTyMxLMIY == 4356 || CS_0024_003C_003E8__locals238.AMTyMxLMIY == 4408 || CS_0024_003C_003E8__locals238.AMTyMxLMIY == 8570)
			{
				return Singleton<OmF9SPGlN77YLFkkoqN>.I.ksPG7uEnJM(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
			}
			if (CS_0024_003C_003E8__locals238.AMTyMxLMIY == 16644)
			{
				CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.截取时间 = Singleton<ByteAPI>.I.取字节集右边(buffer, 4);
			}
			switch ((AllEnums.请求包头枚举)CS_0024_003C_003E8__locals238.AMTyMxLMIY)
			{
			case AllEnums.请求包头枚举.请求_修改雪花ID:
				return null;
			case AllEnums.请求包头枚举.请求_绑定操作:
				buffer = Singleton<COyX27f6L3uCF3F6Kp5>.I.Qjxfao1jQp(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_娃娃技能勾选:
				buffer = Singleton<mQEQjEBxYW4SsAecBHJ>.I.P0GGK9s4W0(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_GM操作:
				buffer = Singleton<WdAPI>.I.rGlotFRFOy(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_小助手图标:
				if (xH3TPsiexTnpJAMMnJm.clyBlug2Xa())
				{
					Singleton<Xh4EKmRML8L7x53wDHM>.I.小助手_呼叫(CS_0024_003C_003E8__locals239.bhPynindCs);
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_引灵幡恢复耐久:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!Singleton<WdAPI>.I.bJboBw7BEu(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节))
				{
					return null;
				}
				if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && Singleton<全局变量类>.I.元神系统配置.灵幡附灵配置.功能开关)
				{
					Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.QKImKoWgLf(CS_0024_003C_003E8__locals239.bhPynindCs);
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_经验锁定:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!Singleton<WdAPI>.I.bJboBw7BEu(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节))
				{
					return null;
				}
				if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND())
				{
					return Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.jRJ2remBsP(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				}
				break;
			case AllEnums.请求包头枚举.请求_整理背包:
				lock (CS_0024_003C_003E8__locals239.bhPynindCs.自选取消锁)
				{
					if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.自选道具))
					{
						CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R使用自选礼包期间无法进行整理背包！"));
						return null;
					}
				}
				break;
			case AllEnums.请求包头枚举.请求_观看隐藏:
				Singleton<ByteAPI>.I.到整数(Singleton<ByteAPI>.I.取字节集右边(buffer, 4));
				break;
			case AllEnums.请求包头枚举.请求_五行竞猜:
				if (Singleton<全局变量类>.I.燃眉配置.功能开关)
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_娃娃喂养:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				buffer = Singleton<mQEQjEBxYW4SsAecBHJ>.I.TkXBtCEc5i(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_取出摆摊账户现金:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!Singleton<WdAPI>.I.bJboBw7BEu(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节))
				{
					return null;
				}
				buffer = Singleton<YHfw7nGpg7WfdCBKDH4>.I.UNPfbU5Z1y(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_确定购买摆摊:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!Singleton<WdAPI>.I.bJboBw7BEu(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节))
				{
					return null;
				}
				buffer = Singleton<YHfw7nGpg7WfdCBKDH4>.I.QJSfwnhYfW(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_输入摆摊物品价格:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!Singleton<WdAPI>.I.bJboBw7BEu(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节))
				{
					return null;
				}
				buffer = Singleton<YHfw7nGpg7WfdCBKDH4>.I.J7ffua6YYd(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_仓库存物品:
				buffer = Singleton<COyX27f6L3uCF3F6Kp5>.I.ED4fcWuaoc(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_仓库取物品:
				buffer = Singleton<COyX27f6L3uCF3F6Kp5>.I.NGtfnF0R5b(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_地府商城购买询问:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				buffer = Singleton<mDs6hiBvFvG3CRi3MZk>.I.Nc8B0RfNPE(CS_0024_003C_003E8__locals239.bhPynindCs, buffer, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节);
				break;
			case AllEnums.请求包头枚举.请求_地府图标点击:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!Singleton<全局变量类>.I.地府商城配置.功能开关)
				{
					return buffer;
				}
				if (!Singleton<WdAPI>.I.bJboBw7BEu(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节))
				{
					return null;
				}
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is战斗中)
				{
					return null;
				}
				CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<mDs6hiBvFvG3CRi3MZk>.I.ouWBk4AhMx(CS_0024_003C_003E8__locals239.bhPynindCs, buffer));
				return null;
			case AllEnums.请求包头枚举.请求_频道物品查看:
				buffer = Singleton<hQdJQufqsH3l9bnUemG>.I.hac6uc0JTy(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_奇宝交易明细:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				Singleton<svsUCqKdlsQkBBIo3St>.I.JigK8AQ6lE(CS_0024_003C_003E8__locals239.bhPynindCs);
				return null;
			case AllEnums.请求包头枚举.请求_单次悟道:
				if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.悟道_领悟按钮)
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_悟道修为购买:
				if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.悟道_加号按钮)
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_悟道周卡购买:
				if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.悟道_购买按钮)
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_悟道展开事件:
				if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.悟道_悟道按钮)
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_一键悟道:
				if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.悟道_领悟按钮)
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_悟道转换属性:
				if (sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.悟道_悟道按钮)
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_宠物改名事件:
				buffer = Singleton<请求数据响应处理类>.I.C8L2c2YcIC(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_守护改名事件:
				buffer = Singleton<请求数据响应处理类>.I.MMK2nmH3WI(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_娃娃改名事件:
				buffer = Singleton<请求数据响应处理类>.I.PIt257Wdmg(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_居所打坐事件:
				if (buffer[12] == 2 && buffer[13] == 1)
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_按钮点击事件:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				buffer = cQB2Sq3aZ1(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_对宠物使用道具:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				buffer = YNs2LktTKf(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_使用技能:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!全局变量类.Is调试 && Enumerable.SequenceEqual(Singleton<ByteAPI>.I.取字节集右边(buffer, 3), new byte[3] { 0, 39, 15 }))
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_首次选择线路:
				if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.config.禁止登录线路) && Nqi2PRktEt(CS_0024_003C_003E8__locals239.bhPynindCs, buffer))
				{
					CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R当前线路禁止登录！"));
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_注册角色:
				CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("本游戏禁止私自创建角色！"));
				return null;
			case AllEnums.请求包头枚举.请求_加仙魔点:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.属性数据.修道点 <= 0)
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_穿戴装备:
				buffer = Singleton<COyX27f6L3uCF3F6Kp5>.I.basf7jeST3(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_FD64:
				buffer = fdk2vID3DK(CS_0024_003C_003E8__locals239.bhPynindCs, buffer, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节);
				break;
			case AllEnums.请求包头枚举.请求_换线:
				if (!Singleton<WdAPI>.I.bJboBw7BEu(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节))
				{
					return null;
				}
				if (Singleton<全局变量类>.I.圣无双配置.功能开关 && !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.圣无双配置.地图名字) && CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.所在地图名字 == Singleton<全局变量类>.I.圣无双配置.地图名字)
				{
					CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.换线_中心提醒("无双战场内禁止切换线路！"));
					return null;
				}
				if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.config.禁止登录线路) && EnL2XAk7s0(CS_0024_003C_003E8__locals239.bhPynindCs, buffer))
				{
					CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.换线_中心提醒("#R当前线路禁止换线！"));
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_切换装备:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.切换装备时间 != 0 && CS_0024_003C_003E8__locals239.bhPynindCs.请求时间戳 / 1000 - CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.切换装备时间 < 10)
				{
					CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请不要频繁的切换装备！"));
					return null;
				}
				CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.切换装备时间 = (int)(CS_0024_003C_003E8__locals239.bhPynindCs.请求时间戳 / 1000);
				break;
			case AllEnums.请求包头枚举.请求_取消对话:
				Singleton<请求数据响应处理类>.I.vXN2mciFrh(CS_0024_003C_003E8__locals239.bhPynindCs);
				break;
			case AllEnums.请求包头枚举.请求_异兽录:
				if (iRGieud4qtscW6ESmxk.wGmslE7YU3() && Singleton<全局变量类>.I.异兽录配置.推荐开关)
				{
					Singleton<iRGieud4qtscW6ESmxk>.I.x1vswD7Ba4(CS_0024_003C_003E8__locals239.bhPynindCs, Singleton<ByteAPI>.I.取字节集中间(buffer, 16, 4));
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_无双争夺战:
				if (Singleton<全局变量类>.I.圣无双配置.功能开关)
				{
					Singleton<BpcEfFbiGBBV3s2B0ai>.I.V4cbXi2m8r(CS_0024_003C_003E8__locals239.bhPynindCs, Singleton<ByteAPI>.I.取字节集右边(buffer, 4));
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_各种状态设置:
				buffer = Singleton<请求数据响应处理类>.I.uFs2MnTaqN(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_宠物抗性加点:
				buffer = Singleton<请求数据响应处理类>.I.adK2h5hw3V(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_玩家切磋:
				if (Singleton<全局变量类>.I.圣无双配置.功能开关 && CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.所在地图名字 == Singleton<全局变量类>.I.圣无双配置.地图名字 && !Singleton<BpcEfFbiGBBV3s2B0ai>.I.uowbcISuTj(CS_0024_003C_003E8__locals239.bhPynindCs, Singleton<ByteAPI>.I.反转_整数(Singleton<ByteAPI>.I.取字节集中间(buffer, 12, 4))))
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_逃跑操作:
				if (Singleton<全局变量类>.I.圣无双配置.功能开关 && CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.所在地图名字 == Singleton<全局变量类>.I.圣无双配置.地图名字)
				{
					CS_0024_003C_003E8__locals239.bhPynindCs.S_Send(Singleton<ByteAPI>.I.AddByte(new byte[12]
					{
						77, 90, 0, 0, 0, 0, 0, 0, 0, 22,
						17, 4
					}, Singleton<ByteAPI>.I.到字节集反转(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.角色ID), Singleton<ByteAPI>.I.到字节集反转(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.角色ID), new byte[12]
					{
						0, 0, 0, 1, 0, 0, 0, 0, 0, 0,
						0, 0
					}), "请求_逃跑操作");
					CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("我辈修士岂可不战而逃，逃跑失败已转为#R防御#n状态#r可使用#Y金蝉脱壳#n结束战斗，但会被判定战斗失败！"));
					return null;
				}
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.Is试道场)
				{
					CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("我辈修士岂可不战而逃，试道场内无法逃跑！"));
					CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.组包指令取消框(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.角色ID));
					return null;
				}
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.队伍数据.成员列表.Count <= 1 || !CS_0024_003C_003E8__locals239.bhPynindCs.user.队伍数据.is队长)
				{
					CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is战斗逃跑指令 = true;
					break;
				}
				CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.组包确定框(CS_0024_003C_003E8__locals239.bhPynindCs, "[@确定/战斗指令_逃跑确定#DLG:1#prompt:#R逃跑会导致整个队伍立即退出战斗，你确定要逃跑吗？]"));
				CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.组包指令取消框(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.角色ID));
				return null;
			case AllEnums.请求包头枚举.请求_查无双排行榜:
				if (Singleton<ByteAPI>.I.寻找字节集(buffer, "领取连胜奖励-"))
				{
					Singleton<BpcEfFbiGBBV3s2B0ai>.I.Yq5bn4pHcy(CS_0024_003C_003E8__locals239.bhPynindCs);
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_组队操作:
				buffer = n1b2BjvyDn(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_同意入队操作:
				buffer = Usr2GsNlbJ(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_首次登录:
				CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.Server心跳 = Singleton<ByteAPI>.I.反转_整数(CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节);
				break;
			case AllEnums.请求包头枚举.请求_道具丢弃:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				buffer = Singleton<请求数据响应处理类>.I.O6E2FnybWx(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_宠物丢弃:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_重置异兽录操作:
				CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is异兽录操作 = false;
				break;
			case AllEnums.请求包头枚举.请求_商城购买:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (Singleton<全局变量类>.I.商城限购配置.功能开关 && !Singleton<FusVSwwzpuFHNrjHS7T>.I.yHNbsmUYJd(CS_0024_003C_003E8__locals239.bhPynindCs, buffer))
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_角色喊话:
				buffer = Singleton<hQdJQufqsH3l9bnUemG>.I.sTWfzj4nZy(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_私聊处理:
				buffer = Singleton<hQdJQufqsH3l9bnUemG>.I.GJ9fAVJb8P(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_输入框提交:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.cdk类型 != AllEnums.CdkType.无)
				{
					Singleton<EMBQv9FAOd3LKHwy7T>.I.y0ZSs00Eg(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_富豪榜:
				if (Singleton<全局变量类>.I.config.is富豪榜 && Enumerable.SequenceEqual(Singleton<ByteAPI>.I.取字节集右边(buffer, 7), Singleton<ByteAPI>.I.HtoC("20740100000067")) && Singleton<全局变量类>.I.富豪榜数据列表.Count > 0)
				{
					CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<全局变量类>.I.富豪排行_百晓通);
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_登录游戏:
				if (全局变量类.点卡使用中)
				{
					角色存档数据类 角色存档数据类2 = Singleton<全局变量类>.I.角色存档表.Values.ToList().Find( (角色存档数据类 x) => x.账号 == CS_0024_003C_003E8__locals239.bhPynindCs.账号);
					if (角色存档数据类2 == null)
					{
						return null;
					}
					if (角色存档数据类2.点卡存档.当前点数 <= 0)
					{
						CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你当前剩余点卡数为0，无法登录游戏。"));
						return null;
					}
				}
				break;
			case AllEnums.请求包头枚举.请求_坐骑心法防御:
				buffer = LlW2245di0(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_鬼斧神工:
				buffer = Singleton<V5YtDM6KCytDucgVcpG>.I.vFd6dErhDH(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_Pack登陆:
				buffer = Singleton<请求数据响应处理类>.I.Oje2fb3qO6(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_鬼才试炼:
				CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.Is燃煤葫芦 = false;
				break;
			case AllEnums.请求包头枚举.请求_NPC点击1:
				buffer = Singleton<z4BxVniyeUkxpq0lEyg>.I.YUAiYp4QDE(CS_0024_003C_003E8__locals239.bhPynindCs, buffer, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节);
				break;
			case AllEnums.请求包头枚举.请求_NPC点击2:
				buffer = Singleton<z4BxVniyeUkxpq0lEyg>.I.YUAiYp4QDE(CS_0024_003C_003E8__locals239.bhPynindCs, buffer, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节);
				break;
			case AllEnums.请求包头枚举.请求_NPC点击3:
				buffer = Singleton<z4BxVniyeUkxpq0lEyg>.I.YUAiYp4QDE(CS_0024_003C_003E8__locals239.bhPynindCs, buffer, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节);
				break;
			case AllEnums.请求包头枚举.请求_漂流瓶点击:
				if (xH3TPsiexTnpJAMMnJm.clyBlug2Xa() && Singleton<全局变量类>.I.内充支付配置.开启抽奖模式)
				{
					Singleton<xH3TPsiexTnpJAMMnJm>.I.akMBgtZ7xZ(CS_0024_003C_003E8__locals239.bhPynindCs);
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_五周年提交:
				if (xH3TPsiexTnpJAMMnJm.clyBlug2Xa() && Singleton<全局变量类>.I.内充支付配置.开启抽奖模式)
				{
					MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals239.bhPynindCs;
					WdAPI i = Singleton<WdAPI>.I;
					MyNATSocketClient myclient2 = CS_0024_003C_003E8__locals239.bhPynindCs;
					string 执行关键词 = "!^内充支付充值抽奖";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
					defaultInterpolatedStringHandler.AppendLiteral("#Y抽奖单价：");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.内充支付配置.单价);
					defaultInterpolatedStringHandler.AppendLiteral("元/次#r#Y请输入你要抽奖的次数：");
					myNATSocketClient.C_Send(i.组包输入数字框(myclient2, 执行关键词, defaultInterpolatedStringHandler.ToStringAndClear(), 9999));
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_南极五周年:
			{
				byte[] array = Singleton<ByteAPI>.I.取字节集右边(buffer, 2);
				if (array[0] == 4)
				{
					if ((array[1] == 1 || array[1] == 2) && Singleton<全局变量类>.I.南极配置.功能开关)
					{
						if (Singleton<WdAPI>.I.取背包剩余空格数(CS_0024_003C_003E8__locals239.bhPynindCs) < 1)
						{
							CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的包裹空位不足，请整理后再来。"));
							return null;
						}
						if (array[1] == 1)
						{
							CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<ByteAPI>.I.HtoC("4D5A000000000000000B3059000000000000000400"));
							return null;
						}
						Singleton<OxtnHXwv6N41rhEtfdc>.I.KWVwC5uwbQ(CS_0024_003C_003E8__locals239.bhPynindCs);
						return null;
					}
				}
				else if (array[0] == 3)
				{
					if (array[1] == 1 && xH3TPsiexTnpJAMMnJm.clyBlug2Xa() && Singleton<全局变量类>.I.内充支付配置.开启抽奖模式)
					{
						Singleton<xH3TPsiexTnpJAMMnJm>.I.INXBDkjQvh(CS_0024_003C_003E8__locals239.bhPynindCs);
						return null;
					}
				}
				else if (array[0] != 2)
				{
				}
				break;
			}
			case AllEnums.请求包头枚举.请求_累充面板:
				if (Singleton<全局变量类>.I.累充配置.功能开关)
				{
					CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<VlLcswg81JdPCi5w8lm>.I.zl7gfNTsJC(CS_0024_003C_003E8__locals239.bhPynindCs));
				}
				return null;
			case AllEnums.请求包头枚举.请求_商店购买:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				buffer = kAv27W86j6(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_物品使用:
				return Singleton<COyX27f6L3uCF3F6Kp5>.I.mb2fmTGBvK(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
			case AllEnums.请求包头枚举.请求_打开领双:
				if (uh2edhfVGtogUy49Lpv.pdEfxlnyv1())
				{
					Singleton<uh2edhfVGtogUy49Lpv>.I.YQCf3wWxLI(CS_0024_003C_003E8__locals239.bhPynindCs);
					return null;
				}
				if (Singleton<全局变量类>.I.config.is随身货栈)
				{
					if (Singleton<全局变量类>.I.王中王整体封包 == Array.Empty<byte>())
					{
						return buffer;
					}
					CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<全局变量类>.I.王中王整体封包);
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_假人点击1:
				if (!Singleton<z4BxVniyeUkxpq0lEyg>.I.Vh8iEHMoNM(CS_0024_003C_003E8__locals239.bhPynindCs, buffer))
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_假人点击2:
				if (!Singleton<z4BxVniyeUkxpq0lEyg>.I.Vh8iEHMoNM(CS_0024_003C_003E8__locals239.bhPynindCs, buffer))
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_假人点击3:
				if (!Singleton<z4BxVniyeUkxpq0lEyg>.I.Vh8iEHMoNM(CS_0024_003C_003E8__locals239.bhPynindCs, buffer))
				{
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_心跳包:
				CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.Server心跳 = Singleton<ByteAPI>.I.反转_整数(Singleton<ByteAPI>.I.取字节集中间(buffer, 12, 4));
				break;
			case AllEnums.请求包头枚举.请求_崩服包1:
				CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("草泥马瘪犊子玩意蹦我服，吃屎把你！"));
				if (!DB.I.锁定账号操作(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.账号, "1"))
				{
					Log.Error("崩服-错误：账号锁定失败");
				}
				Singleton<WdAPI>.I.WT9IHmFS6c(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称);
				Log.Error("请求_崩服包1-错误：[" + CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称 + "]强制下线");
				return null;
			case AllEnums.请求包头枚举.请求_崩服包2:
				CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("草泥马瘪犊子玩意蹦我服，吃屎把你！"));
				if (!DB.I.锁定账号操作(CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.账号, "1"))
				{
					Log.Error("崩服-错误：账号锁定失败");
				}
				Singleton<WdAPI>.I.WT9IHmFS6c(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称);
				Log.Error("请求_崩服包2-错误：[" + CS_0024_003C_003E8__locals239.bhPynindCs.user.人物数据.昵称 + "]强制下线");
				return null;
			case AllEnums.请求包头枚举.请求_乾坤袋:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (Singleton<全局变量类>.I.config.is乾坤袋)
				{
					Singleton<HCrxJFnoveWsmxYAyd>.I.ow5MV1MwL(CS_0024_003C_003E8__locals239.bhPynindCs, "乾坤袋_领取物品");
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_属性洗炼:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (pN4kvFDKqDQRQBnO8BW.XynDBwYvGf())
				{
					Singleton<pN4kvFDKqDQRQBnO8BW>.I.eC4DNMRbED(CS_0024_003C_003E8__locals239.bhPynindCs);
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_格子交换:
				buffer = Singleton<COyX27f6L3uCF3F6Kp5>.I.zrBfPuUeNu(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			case AllEnums.请求包头枚举.请求_奇宝斋打开:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!全局变量类.Is调试 && !Singleton<全局变量类>.I.验证client.授权配置.IsVip)
				{
					return null;
				}
				if (!Singleton<全局变量类>.I.奇宝斋配置.功能开关)
				{
					CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("奇宝斋暂未开启，敬请期待！"));
				}
				return null;
			case AllEnums.请求包头枚举.请求_奇宝斋列表:
				if (!svsUCqKdlsQkBBIo3St.I5CKPFClWO())
				{
					return null;
				}
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (Singleton<全局变量类>.I.奇宝斋配置.功能开关)
				{
					if (Singleton<ByteAPI>.I.寻找字节集(buffer, new byte[5] { 55, 10, 1, 0, 4 }))
					{
						Singleton<svsUCqKdlsQkBBIo3St>.I.D6mKl3PdeA(CS_0024_003C_003E8__locals239.bhPynindCs);
					}
					else if (Singleton<ByteAPI>.I.寻找字节集(buffer, new byte[4] { 9, 55, 10, 3 }))
					{
						Singleton<svsUCqKdlsQkBBIo3St>.I.JigK8AQ6lE(CS_0024_003C_003E8__locals239.bhPynindCs);
					}
					return null;
				}
				break;
			case AllEnums.请求包头枚举.请求_奇宝斋我的货架:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!全局变量类.Is调试 && !Singleton<全局变量类>.I.验证client.授权配置.IsVip)
				{
					return null;
				}
				if (Singleton<全局变量类>.I.奇宝斋配置.功能开关 && Singleton<全局变量类>.I.奇宝斋配置.玩家上架开关)
				{
					CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(全局常量类.我的货架);
				}
				return null;
			case AllEnums.请求包头枚举.请求_奇宝斋我的货架2:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!全局变量类.Is调试 && !Singleton<全局变量类>.I.验证client.授权配置.IsVip)
				{
					return null;
				}
				if (Singleton<全局变量类>.I.奇宝斋配置.功能开关 && Singleton<全局变量类>.I.奇宝斋配置.玩家上架开关)
				{
					CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(全局常量类.我的货架);
				}
				return null;
			case AllEnums.请求包头枚举.请求_奇宝斋玩家上架:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!Singleton<WdAPI>.I.bJboBw7BEu(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节))
				{
					return null;
				}
				if (!svsUCqKdlsQkBBIo3St.I5CKPFClWO())
				{
					return null;
				}
				if (Singleton<全局变量类>.I.奇宝斋配置.玩家上架开关 && !Singleton<ByteAPI>.I.寻找字节集(buffer, new byte[5] { 250, 252, 5, 0, 1 }))
				{
					Singleton<svsUCqKdlsQkBBIo3St>.I.luaKInnxZX(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				}
				return null;
			case AllEnums.请求包头枚举.请求_奇宝斋物品展示:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!Singleton<WdAPI>.I.bJboBw7BEu(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节))
				{
					return null;
				}
				if (!svsUCqKdlsQkBBIo3St.I5CKPFClWO())
				{
					return null;
				}
				Singleton<svsUCqKdlsQkBBIo3St>.I.UFFKo9bN60(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				return null;
			case AllEnums.请求包头枚举.请求_奇宝斋下单:
				if (CS_0024_003C_003E8__locals239.bhPynindCs.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!Singleton<WdAPI>.I.bJboBw7BEu(CS_0024_003C_003E8__locals239.bhPynindCs, CS_0024_003C_003E8__locals239.bhPynindCs.当前时间字节))
				{
					return null;
				}
				if (!svsUCqKdlsQkBBIo3St.I5CKPFClWO())
				{
					return null;
				}
				Singleton<svsUCqKdlsQkBBIo3St>.I.JWCKNnYWQj(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				return null;
			case AllEnums.请求包头枚举.请求_交易放入:
			{
				if (!Singleton<全局变量类>.I.超级道具配置.功能开关)
				{
					break;
				}
				int num = Singleton<ByteAPI>.I.取字节集数据(buffer, 1, 18);
				if (Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals239.bhPynindCs, num))
				{
					string 名字 = CS_0024_003C_003E8__locals239.bhPynindCs.user.背包数据.物品列表[num].名字;
					if (!string.IsNullOrWhiteSpace(名字) && ("|" + Singleton<全局变量类>.I.超级道具配置.禁止交易道具 + "|").Contains("|" + 名字 + "|", StringComparison.CurrentCulture))
					{
						CS_0024_003C_003E8__locals239.bhPynindCs.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + 名字 + "#n被禁止交易！"));
						return null;
					}
				}
				break;
			}
			case AllEnums.请求包头枚举.请求_商会存放:
				buffer = Singleton<COyX27f6L3uCF3F6Kp5>.I.jEffhTTGGK(CS_0024_003C_003E8__locals239.bhPynindCs, buffer);
				break;
			}
			return buffer;
		}
		catch (Exception ex)
		{
			Log.ForContext("AuditCategory", "player-anomaly").Error("请求处理中心-报错：" + ex.Message + "[" + ex.StackTrace + "]");
			return null;
		}
	}

	
	private byte[] n1b2BjvyDn(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(12L, SeekOrigin.Begin);
			string 玩家名字 = obj.读文本型(是否声明长度: true, 0);
			string text = obj.读文本型(是否声明长度: true, 0);
			if (Singleton<全局变量类>.I.圣无双配置.功能开关 && P_0.user.人物数据.所在地图名字 == Singleton<全局变量类>.I.圣无双配置.地图名字)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y" + P_0.user.人物数据.所在地图名字 + "#n禁止组队！"));
				return null;
			}
			if (Singleton<全局变量类>.I.超级地图配置.功能开关 && Singleton<全局变量类>.I.超级地图配置.地图列表.TryGetValue(P_0.user.人物数据.所在地图名字, out 地图限制列表类 value) && value.is限制组队)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y" + P_0.user.人物数据.所在地图名字 + "#n禁止组队！"));
				return null;
			}
			if (text == "request_join" && P_0.user.人物数据.Is试道场 && Singleton<全局变量类>.I.试道大会配置.功能开关 && Singleton<全局变量类>.I.试道大会配置.队伍最高人数 != 5)
			{
				MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定Name玩家MyClient(玩家名字);
				if (myNATSocketClient == null)
				{
					return null;
				}
				if (myNATSocketClient.user.队伍数据.成员列表.Count >= Singleton<全局变量类>.I.试道大会配置.队伍最高人数)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R对方队伍已满员！"));
					return null;
				}
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("请求_组包组队操作-报错：" + ex.Message + "[" + ex.StackTrace + "]");
			return null;
		}
	}

	
	private byte[] Usr2GsNlbJ(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			if (P_0.user.人物数据.Is试道场 && Singleton<全局变量类>.I.试道大会配置.功能开关 && Singleton<全局变量类>.I.试道大会配置.队伍最高人数 != 5 && P_0.user.队伍数据.成员列表.Count >= Singleton<全局变量类>.I.试道大会配置.队伍最高人数)
			{
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
				defaultInterpolatedStringHandler.AppendLiteral("#R无法同意申请！#n你的队伍成员人数已经达到了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.队伍数据.成员列表.Count);
				defaultInterpolatedStringHandler.AppendLiteral("#n人！");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return null;
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("请求_组包组队操作-报错：" + ex.Message + "[" + ex.StackTrace + "]");
			return null;
		}
	}

	
	internal byte[] Oje2fb3qO6(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals14 = new _003C_003Ec__DisplayClass3_0();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(12L, SeekOrigin.Begin);
			封包_写2.写字节集(new byte[2] { 35, 80 }, hasCount: false, 0);
			CS_0024_003C_003E8__locals14.UtIyaBYpTU = 封包_读2.读文本型(是否声明长度: true, 0);
			string zone = 封包_读2.读文本型(是否声明长度: true, 0);
			CS_0024_003C_003E8__locals14.YX9y7AVKdk = 封包_读2.读文本型(是否声明长度: true, 0);
			if (Singleton<全局变量类>.I.config.is禁止登陆 && CS_0024_003C_003E8__locals14.UtIyaBYpTU != Singleton<全局变量类>.I.config.挂载GM账号)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前服务器维护中，禁止登录，等待GM通知。"));
				P_0.Close();
				return null;
			}
			if (Singleton<全局变量类>.I.黑名单记录.黑名单MAC列表.Any( (string x) => x == CS_0024_003C_003E8__locals14.YX9y7AVKdk) || Singleton<全局变量类>.I.黑名单记录.黑名单账号列表.Any( (string x) => x == CS_0024_003C_003E8__locals14.UtIyaBYpTU))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R黑名单玩家禁止登录！"));
				P_0.Close();
				return null;
			}
			if (Singleton<全局变量类>.I.config.自动修复1009 && !DB.I.JY2NIJPMcG(CS_0024_003C_003E8__locals14.UtIyaBYpTU))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R账号不存在！"));
				P_0.Close();
				return null;
			}
			P_0.Mac = CS_0024_003C_003E8__locals14.YX9y7AVKdk;
			P_0.账号 = CS_0024_003C_003E8__locals14.UtIyaBYpTU;
			封包_写2.写文本型(CS_0024_003C_003E8__locals14.UtIyaBYpTU, hasCount: true, 0);
			封包_写2.写文本型(zone, hasCount: true, 0);
			封包_写2.写文本型(CS_0024_003C_003E8__locals14.YX9y7AVKdk, hasCount: true, 0);
			if (Singleton<MainService>.I.历史IP机器码列表.ContainsKey(P_0.当前client.IP))
			{
				Singleton<MainService>.I.历史IP机器码列表[P_0.当前client.IP] = CS_0024_003C_003E8__locals14.YX9y7AVKdk;
			}
			else
			{
				Singleton<MainService>.I.历史IP机器码列表.TryAdd(P_0.当前client.IP, CS_0024_003C_003E8__locals14.YX9y7AVKdk);
			}
			if (Singleton<MainService>.I.历史IP账号列表.ContainsKey(P_0.当前client.IP))
			{
				Singleton<MainService>.I.历史IP账号列表[P_0.当前client.IP] = CS_0024_003C_003E8__locals14.UtIyaBYpTU;
			}
			else
			{
				Singleton<MainService>.I.历史IP账号列表.TryAdd(P_0.当前client.IP, CS_0024_003C_003E8__locals14.UtIyaBYpTU);
			}
			封包_写2.写字节集(new byte[4] { 0, 2, 124, 49 }, hasCount: false, 0);
			封包_读2.Seek(4L, SeekOrigin.Current);
			Singleton<全局变量类>.I.全_本区区名 = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			封包_写2.写文本型(Singleton<全局变量类>.I.全_本区区名, hasCount: true, 0, reverse: true);
			封包_写2.写字节集(new byte[35]
			{
				0, 32, 50, 48, 53, 52, 52, 68, 69, 51,
				56, 67, 50, 49, 54, 48, 68, 54, 69, 65,
				67, 57, 66, 70, 69, 48, 55, 52, 56, 54,
				50, 52, 50, 69, 0
			}, hasCount: false, 0);
			封包_写 obj = new 封包_写();
			obj.写字节集(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return obj.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("请求_账号密码登录-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal byte[] hY82636f6G(byte[] P_0)
	{
		try
		{
			short num = Singleton<ByteAPI>.I.反转_短整数(P_0, P_0.Length - 2, 2);
			if (num > 1399 && num < 1500)
			{
				return null;
			}
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("请求_心法防御-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal byte[] LlW2245di0(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(12L, SeekOrigin.Begin);
			int num = obj.读整数型(reverse: true);
			obj.读整数型(reverse: true);
			short num2 = obj.读短整数型(reverse: true);
			if (num2 > 1399 && num2 < 1500)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[账号：");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral("][角色：");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("][理由：刷心法]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return null;
			}
			if (((num2 > 1100 && num2 < 1201) || (num2 > 1202 && num2 < 1301)) && num != Singleton<全局变量类>.I.NPC_玉真子)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[账号：");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral("][角色：");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("][理由：刷坐骑天赋]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return null;
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("请求_学习技能-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal void vXN2mciFrh(MyNATSocketClient P_0)
	{
		lock (P_0.自选取消锁)
		{
			if (!string.IsNullOrWhiteSpace(P_0.user.缓存数据.自选道具))
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, P_0.user.缓存数据.自选道具, AllEnums.指令Type.无, 1, false, "自选退回");
				P_0.user.缓存数据.自选道具 = string.Empty;
			}
		}
	}

	
	internal bool Nqi2PRktEt(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(12L, SeekOrigin.Begin);
			string text = obj.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			obj.Seek(4L, SeekOrigin.Current);
			string text2 = obj.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			return text != Singleton<全局变量类>.I.config.挂载GM账号 && Singleton<ByteAPI>.I.寻找文本("," + Singleton<全局变量类>.I.config.禁止登录线路 + ",", "," + text2 + ",");
		}
		catch (Exception ex)
		{
			Log.Error("请求_首次选择线路-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal bool EnL2XAk7s0(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(12L, SeekOrigin.Begin);
			string text = obj.读文本型(是否声明长度: true, 0);
			return P_0.user.人物数据.账号 != Singleton<全局变量类>.I.config.挂载GM账号 && Singleton<ByteAPI>.I.寻找文本("," + Singleton<全局变量类>.I.config.禁止登录线路 + ",", "," + text + ",");
		}
		catch (Exception ex)
		{
			Log.Error("请求_换线-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal byte[] O6E2FnybWx(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(12L, SeekOrigin.Begin);
			obj.读字节型(out var value);
			obj.读整数型(reverse: true, out var _);
			if (value > 200 || value < 1)
			{
				return P_1;
			}
			if (P_0.user.背包数据.物品列表[value] == null)
			{
				return null;
			}
			if (string.IsNullOrWhiteSpace(P_0.user.背包数据.物品列表[value].名字))
			{
				return null;
			}
			string 名字 = P_0.user.背包数据.物品列表[value].名字;
			if (Singleton<全局变量类>.I.超级道具配置.功能开关 && Singleton<全局变量类>.I.超级道具配置.禁止丢弃道具.Contains("|" + 名字 + "|", StringComparison.CurrentCulture))
			{
				P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[value].封包缓存, value).Concat(Singleton<WdAPI>.I.提示_中心提醒("该物品禁止丢弃。")).ToArray());
				return null;
			}
			if (Singleton<全局变量类>.I.config.is丢弃管控 && Singleton<全局变量类>.I.config.丢弃频率 > 0)
			{
				if (P_0.user.缓存数据.道具丢弃个数 >= 230)
				{
					if (Singleton<ByteAPI>.I.取时间戳(是否到秒: false) - P_0.请求时间戳 <= Singleton<全局变量类>.I.config.丢弃频率)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("道具丢弃太快了，快歇一歇吧。"));
						return null;
					}
					P_0.user.缓存数据.道具丢弃个数 = 1;
				}
				else
				{
					P_0.user.缓存数据.道具丢弃个数++;
				}
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("物品丢弃请求处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal byte[] YNs2LktTKf(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(12L, SeekOrigin.Begin);
			obj.读字节型(out var value);
			obj.读字节型(out var value2);
			if (value < 1 || value > 8)
			{
				return null;
			}
			string 名字 = P_0.user.背包数据.物品列表[value2].名字;
			if (U8hGTORuviqLJbXPJ0Y.n3VRDqR2M4() && U8hGTORuviqLJbXPJ0Y.HvERl5OIw9.Contains("|" + 名字 + "|", StringComparison.CurrentCulture))
			{
				Singleton<U8hGTORuviqLJbXPJ0Y>.I.zVtRdnLs6u(P_0, "宠物突破_", value, value2, 名字);
				return null;
			}
			if (AZI1HsR8MjRfegmETY5.zmURXpEr61() && AZI1HsR8MjRfegmETY5.fZ1RSIDoZn.ToString().Contains("|" + 名字 + "|", StringComparison.CurrentCulture))
			{
				Singleton<U8hGTORuviqLJbXPJ0Y>.I.zVtRdnLs6u(P_0, "转生操作_使用_", value, value2, 名字);
				return null;
			}
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && Singleton<全局变量类>.I.元神系统配置.心法升级配置.功能开关 && Ab7Ypu2aCcHMcLPG8Um.sK3m8a9JNp.ToString().Contains("|" + 名字 + "|", StringComparison.CurrentCulture))
			{
				Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.Qenmwn5Jk4(P_0, value, value2, 名字);
				return null;
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("请求_宠物使用道具处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal byte[] cQB2Sq3aZ1(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(12L, SeekOrigin.Begin);
			obj.读字节型(out var value);
			obj.读字节型(out var value2);
			obj.读短整数型(reverse: true, out var value3);
			obj.读字节型(out var value4);
			if ((Singleton<全局变量类>.I.验证client.授权配置.IsVip || 全局变量类.Is调试) && Singleton<全局变量类>.I.融丹配置.功能开关 && Enumerable.SequenceEqual(Singleton<ByteAPI>.I.取字节集右边(P_1, 5), new byte[5] { 0, 1, 0, 0, 0 }))
			{
				Singleton<APqDp4bq1ecVdMifnI1>.I.kSGJw7utSV(P_0);
				return null;
			}
			if ((Singleton<全局变量类>.I.验证client.授权配置.IsVip || 全局变量类.Is调试) && Singleton<全局变量类>.I.融丹配置.功能开关 && value == 2 && value2 == 2)
			{
				Singleton<APqDp4bq1ecVdMifnI1>.I.JTvJbdsgAc(P_0, value3, value4);
				return null;
			}
			if ((Singleton<全局变量类>.I.验证client.授权配置.IsVip || 全局变量类.Is调试) && Singleton<全局变量类>.I.融丹配置.功能开关 && value == 2 && value2 == 3)
			{
				Singleton<APqDp4bq1ecVdMifnI1>.I.h0oJRdZfIg(P_0);
				return null;
			}
			if ((Singleton<全局变量类>.I.验证client.授权配置.IsVip || 全局变量类.Is调试) && Singleton<全局变量类>.I.融丹配置.功能开关 && value == 2 && value2 == 4)
			{
				Singleton<APqDp4bq1ecVdMifnI1>.I.YLjJJjSlWw(P_0);
				return null;
			}
			if ((Singleton<全局变量类>.I.验证client.授权配置.IsVip || 全局变量类.Is调试) && Singleton<全局变量类>.I.融丹配置.功能开关 && value == 2 && value2 == 5)
			{
				Singleton<APqDp4bq1ecVdMifnI1>.I.PGOJdAtPYp(P_0);
				return null;
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("请求_按钮点击事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal byte[] C8L2c2YcIC(MyNATSocketClient P_0, byte[] P_1)
	{
		if (P_1.Length < 14)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R非法错误，请重新填写！"));
			return null;
		}
		封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
		obj.Seek(12L, SeekOrigin.Begin);
		obj.读字节型(out var _);
		obj.读文本型(out string value2, true, (byte)0, false);
		if (!WdAPI.Q1HoyN6wEg(value2))
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R非法错误，请重新填写！"));
			return null;
		}
		return P_1;
	}

	
	internal byte[] MMK2nmH3WI(MyNATSocketClient P_0, byte[] P_1)
	{
		if (P_1.Length < 17)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R非法错误，请重新填写！"));
			return null;
		}
		封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
		obj.Seek(12L, SeekOrigin.Begin);
		obj.读整数型(reverse: true, out var _);
		obj.读文本型(out string value2, true, (byte)0, false);
		if (!WdAPI.Q1HoyN6wEg(value2))
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R非法错误，请重新填写！"));
			return null;
		}
		return P_1;
	}

	
	internal byte[] PIt257Wdmg(MyNATSocketClient P_0, byte[] P_1)
	{
		if (P_1.Length < 14)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R非法错误，请重新填写！"));
			return null;
		}
		封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
		obj.Seek(12L, SeekOrigin.Begin);
		obj.读字节型(out var _);
		obj.读文本型(out string value2, true, (byte)0, false);
		if (!WdAPI.Q1HoyN6wEg(value2))
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R非法错误，请重新填写！"));
			return null;
		}
		return P_1;
	}

	
	internal byte[] uFs2MnTaqN(MyNATSocketClient P_0, byte[] P_1)
	{
		封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
		封包_读2.Seek(12L, SeekOrigin.Begin);
		封包_读2.读文本型(out string value, true, (byte)0, false);
		int value2 = 0;
		int value3 = 0;
		if (!(value == "fight"))
		{
			if (value == "mount_not_cheer")
			{
				封包_读2.读字节型(out value2);
				封包_读2.读字节型(out value3);
				if (value3 == 0 && sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.宠物_助阵按钮)
				{
					return null;
				}
			}
		}
		else
		{
			封包_读2.读字节型(out value2);
			封包_读2.读字节型(out value3);
			if (value3 == 1 && Singleton<全局变量类>.I.圣无双配置.功能开关 && P_0.user.人物数据.所在地图名字 == Singleton<全局变量类>.I.圣无双配置.地图名字)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("很抱歉，无双争夺战场内禁止设置拒绝切磋！"));
				return null;
			}
		}
		return P_1;
	}

	
	internal byte[] adK2h5hw3V(MyNATSocketClient P_0, byte[] P_1)
	{
		封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
		obj.Seek(12L, SeekOrigin.Begin);
		obj.读整数型(reverse: true, out var _);
		obj.读文本型(out string value2, true, (byte)0, false);
		string[] array = value2.Split(",");
		if (array.Length != 15)
		{
			return null;
		}
		if ((array[10] != "0" || array[11] != "0" || array[12] != "0" || array[13] != "0" || array[14] != "0") && sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.鬼斧_法宝转换)
		{
			return null;
		}
		return P_1;
	}

	
	internal byte[] fdk2vID3DK(MyNATSocketClient P_0, byte[] P_1, byte[] P_2)
	{
		try
		{
			new 封包_读(P_1, 0, P_1.Length).Seek(12L, SeekOrigin.Begin);
			if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
			{
				return null;
			}
			if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的包裹栏空位不足，整理后再来。"));
				return null;
			}
			if (Enumerable.SequenceEqual(Singleton<ByteAPI>.I.取字节集右边(P_1, 4), new byte[4] { 0, 1, 0, 0 }))
			{
				if (!Singleton<浮生录功能>.I.V6GUQkKJV4(P_0))
				{
					return null;
				}
			}
			else if (Enumerable.SequenceEqual(Singleton<ByteAPI>.I.取字节集右边(P_1, 4), new byte[4] { 0, 43, 0, 0 }))
			{
				Singleton<浮生录功能>.I.cw9UEXjGLr(P_0, -1);
				return null;
			}
			if (Enumerable.SequenceEqual(Singleton<ByteAPI>.I.取字节集中间(P_1, 10, 4), Singleton<ByteAPI>.I.HtoC("FD64004B")))
			{
				if (Singleton<全局变量类>.I.累充配置.功能开关)
				{
					Singleton<VlLcswg81JdPCi5w8lm>.I.cKSgGJIkAf(P_0, P_1);
				}
				return null;
			}
			if (Singleton<全局变量类>.I.活跃度配置.功能开关)
			{
				if (Enumerable.SequenceEqual(Singleton<ByteAPI>.I.取字节集中间(P_1, 14, 2), new byte[2] { 1, 54 }))
				{
					Singleton<L4IbybsayJA7RG5d8t7>.I.IX8sHwNB3t(P_0, 1);
				}
				if (Enumerable.SequenceEqual(Singleton<ByteAPI>.I.取字节集中间(P_1, 14, 2), new byte[2] { 1, 55 }))
				{
					Singleton<L4IbybsayJA7RG5d8t7>.I.IX8sHwNB3t(P_0, 2);
				}
				if (Enumerable.SequenceEqual(Singleton<ByteAPI>.I.取字节集中间(P_1, 14, 2), new byte[2] { 1, 56 }))
				{
					Singleton<L4IbybsayJA7RG5d8t7>.I.IX8sHwNB3t(P_0, 3);
				}
				if (Enumerable.SequenceEqual(Singleton<ByteAPI>.I.取字节集中间(P_1, 14, 2), new byte[2] { 1, 57 }))
				{
					Singleton<L4IbybsayJA7RG5d8t7>.I.IX8sHwNB3t(P_0, 4);
				}
				if (Enumerable.SequenceEqual(Singleton<ByteAPI>.I.取字节集中间(P_1, 14, 3), new byte[3] { 2, 49, 48 }))
				{
					Singleton<L4IbybsayJA7RG5d8t7>.I.IX8sHwNB3t(P_0, 5);
				}
				if (Enumerable.SequenceEqual(Singleton<ByteAPI>.I.取字节集中间(P_1, 14, 3), new byte[3] { 2, 49, 49 }))
				{
					Singleton<L4IbybsayJA7RG5d8t7>.I.IX8sHwNB3t(P_0, 6);
				}
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("组包FD64请求处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal byte[] kAv27W86j6(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(封包_读2.读字节集(12), hasCount: false, 0);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value), reverse: true);
			封包_读2.读整数型(reverse: true, out var value2);
			封包_读2.读短整数型(reverse: true, out var value3);
			封包_读2.读短整数型(reverse: true, out var value4);
			if (value2 == Singleton<全局变量类>.I.NPC_妙手道人)
			{
				return null;
			}
			if (value2 == 8)
			{
				if (uh2edhfVGtogUy49Lpv.pdEfxlnyv1())
				{
					if (value <= 0 || value > Singleton<全局变量类>.I.自助商店配置.点数列表.Count)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R购买的物品不存在！"));
						return null;
					}
					uh2edhfVGtogUy49Lpv i = Singleton<uh2edhfVGtogUy49Lpv>.I;
					自助商店列表类 obj = Singleton<全局变量类>.I.自助商店配置.点数列表[value - 1];
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendLiteral("!^自助货栈_下单_");
					defaultInterpolatedStringHandler.AppendFormatted(value - 1);
					i.ALHfp3Nlra(P_0, obj, defaultInterpolatedStringHandler.ToStringAndClear());
					return null;
				}
				if (Singleton<全局变量类>.I.config.is随身货栈)
				{
					封包_写2.写整数型(Singleton<全局变量类>.I.NPC_王中王, reverse: true);
					封包_写2.写短整数型(value3, reverse: true);
					封包_写2.写短整数型(value4, reverse: true);
					封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
					return 封包_写2.取数据();
				}
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("请求_商店购买-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	public 请求数据响应处理类()
	{
	}

	static 请求数据响应处理类()
	{
	}
}
