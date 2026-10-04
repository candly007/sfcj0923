using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AjM3S5iHgLtKng5UpEe;
using EoNAUnGWS8H1K1ckt64;
using F2RFuVfrhBPBhCG1Yrv;
using HS2GfXB7hJCX6tDXuc0;
using Ldau4kRn6nFHhj6A594;
using QsZODwJPWinsfjttlCn;
using SGIgOgiC7KPqObpOnGQ;
using Serilog;
using SuTsFOBHSZNdBh5bUZB;
using UbblDNG1yFpxk6Q0ui4;
using VcF0pbBvJqp0x0IfwN;
using WUi9QivDmyMdpkvOap;
using XWKUjNiqpjLqc4emuCT;
using YOheREbBnDq6LvvWZEr;
using YiLFP4xGOZy9p4dVlP;
using gEdioZfkTLM2TXU6jgd;
using o6qwVWbu5whwUP31LfM;
using qP09WjBc7nUNQOcDDy3;
using swC6eeDmDlHvujbhoCw;
using vBIs2Rf2vSSk1OdhoS7;
using vEAdPGPTkDFOYsbi303;
using xqlPMM2TJRNXpZnNDFn;
using y24fbEG8KTuMIdiCbG1;

public class 接收数据响应处理类 : Singleton<接收数据响应处理类>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public int xqAyiBR1nZ;

		
		public _003C_003Ec__DisplayClass0_0()
		{
		}

		
		internal bool gbjyNFfaFq(宠物缓存数据类 a)
		{
			return a.iQFIbnJHxG(xqAyiBR1nZ);
		}

		static _003C_003Ec__DisplayClass0_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public int JGdyfmq5Yr;

		
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		
		internal bool RNuyBICeRL(娃娃缓存数据类 x)
		{
			return x.娃娃ID == JGdyfmq5Yr;
		}

		
		internal bool if4yGg3WVj(宠物缓存数据类 x)
		{
			return x.宠物ID == JGdyfmq5Yr;
		}

		static _003C_003Ec__DisplayClass15_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public int zbly21nUPq;

		
		public _003C_003Ec__DisplayClass18_0()
		{
		}

		
		internal bool aliy6Be16n(宠物缓存数据类 x)
		{
			return x.宠物ID == zbly21nUPq;
		}

		static _003C_003Ec__DisplayClass18_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public string mufyPEmhF5;

		
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		
		internal bool CU5ym51SZ3(注册信息 x)
		{
			return x.账号 == mufyPEmhF5;
		}

		static _003C_003Ec__DisplayClass5_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public MyNATSocketClient HJVyFR6pbr;

		
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		
		internal bool nfiyXd8Avf(string x)
		{
			return ("|" + HJVyFR6pbr.user.存档数据.账号注册QQ).Contains("|" + x + "|", StringComparison.CurrentCulture);
		}

		static _003C_003Ec__DisplayClass6_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public MyNATSocketClient hl2yS0Ml0M;

		
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		
		internal bool ogayLsnWCL(宠物缓存数据类 a)
		{
			return a.iQFIbnJHxG(hl2yS0Ml0M.user.缓存数据.当前乘骑坐骑id);
		}

		static _003C_003Ec__DisplayClass8_0()
		{
		}
	}

	
	public byte[] 接收处理中心(ref bool allow, MyNATSocketClient myclient, byte[] buffer, byte[] packType = null)
	{
		try
		{
			if (myclient == null || !MyFixedHeaderRequestInfo.IsValidFrame(buffer))
			{
				return null;
			}
			int num = ((packType == null) ? Singleton<WdAPI>.I.获取包头(buffer, 10, 2) : Singleton<WdAPI>.I.获取包头(packType, 0, 2));
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.config.记录账号列表) && !string.IsNullOrWhiteSpace(myclient.user.人物数据.昵称) && Singleton<ByteAPI>.I.寻找文本(Singleton<全局变量类>.I.config.记录账号列表, "," + myclient.user.人物数据.昵称 + ","))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 4);
				defaultInterpolatedStringHandler.AppendLiteral("【接收】 【昵称：");
				defaultInterpolatedStringHandler.AppendFormatted(myclient.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("】【id：");
				defaultInterpolatedStringHandler.AppendFormatted(myclient.user.人物数据.角色ID);
				defaultInterpolatedStringHandler.AppendLiteral("】【包头：[");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.接收包头枚举)num);
				defaultInterpolatedStringHandler.AppendLiteral("]】【内容：");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(buffer));
				defaultInterpolatedStringHandler.AppendLiteral("】");
				Log.ForContext("AuditCategory", "player-packet").Debug(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			if (全局变量类.Is调试)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 4);
				defaultInterpolatedStringHandler.AppendLiteral("【接收-封包测试】【昵称：");
				defaultInterpolatedStringHandler.AppendFormatted(myclient.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("】【角色编号：");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(Singleton<ByteAPI>.I.到字节集固定反转(myclient.user.人物数据.角色ID)));
				defaultInterpolatedStringHandler.AppendLiteral("】【包头：[");
				defaultInterpolatedStringHandler.AppendFormatted((AllEnums.接收包头枚举)num);
				defaultInterpolatedStringHandler.AppendLiteral("]】  内容：[");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(buffer));
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.ForContext("AuditCategory", "player-packet").Debug(defaultInterpolatedStringHandler.ToStringAndClear());
				foreach (int item in Singleton<全局变量类>.I.临时id字典)
				{
					if (Singleton<ByteAPI>.I.寻找字节集(buffer, Singleton<ByteAPI>.I.到字节集固定反转(item)))
					{
						string path = mEdebOPadFyb5ykL5Wy.W80P9ipOVU("封包测试-接收.txt");
						string text = File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("封包测试-接收.txt"));
						string text2 = "\n";
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
						defaultInterpolatedStringHandler.AppendLiteral("临时id字典：");
						defaultInterpolatedStringHandler.AppendFormatted(item);
						defaultInterpolatedStringHandler.AppendLiteral("     包头：[");
						defaultInterpolatedStringHandler.AppendFormatted((AllEnums.接收包头枚举)num);
						defaultInterpolatedStringHandler.AppendLiteral("]  内容：[");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(buffer));
						defaultInterpolatedStringHandler.AppendLiteral("]");
						File.WriteAllText(path, text + text2 + defaultInterpolatedStringHandler.ToStringAndClear());
					}
				}
				_ = 15859;
				if (buffer[9] == 61 && buffer[10] == 243)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 4);
					defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now);
					defaultInterpolatedStringHandler.AppendLiteral("【接收-封包图标】 角色编号：");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(Singleton<ByteAPI>.I.到字节集固定反转(myclient.user.人物数据.角色ID)));
					defaultInterpolatedStringHandler.AppendLiteral("     包头：[");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.接收包头枚举)num);
					defaultInterpolatedStringHandler.AppendLiteral("]  内容：[");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.到文本存储(buffer));
					defaultInterpolatedStringHandler.AppendLiteral("]");
					Log.ForContext("AuditCategory", "player-packet").Debug(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			_ = Singleton<全局变量类>.I.config.异常封包日志开关;
			Singleton<ByteAPI>.I.寻找字节集(buffer, Singleton<ByteAPI>.I.到字节集(Singleton<全局变量类>.I.config.游戏IP));
			if (Singleton<ByteAPI>.I.寻找字节集(buffer, Singleton<ByteAPI>.I.到字节集("mount_not_cheer")))
			{
				int num2 = Singleton<ByteAPI>.I.寻找字节集下标(buffer, new byte[16]
				{
					15, 109, 111, 117, 110, 116, 95, 110, 111, 116,
					95, 99, 104, 101, 101, 114
				});
				if (num2 >= 0)
				{
					byte[] first = Singleton<ByteAPI>.I.取字节集中间(buffer, num2 + 16, 2);
					myclient.user.缓存数据.is坐骑助阵 = Enumerable.SequenceEqual(first, new byte[2]);
				}
			}
			if (Singleton<ByteAPI>.I.寻找字节集(buffer, "请注意：", "上线了"))
			{
				return null;
			}
			if (num == 64924 || num == 64932 || num == 64837)
			{
				return null;
			}
			封包_读 封包_读2 = new 封包_读(buffer, 0, buffer.Length);
			封包_写 obj = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			obj.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			int value = 封包_读2.读整数型(reverse: true);
			obj.写整数型(value, reverse: true);
			short value2 = 封包_读2.读短整数型(reverse: true);
			obj.写短整数型(value2, reverse: true);
			short value3 = 封包_读2.读短整数型(reverse: true);
			obj.写短整数型(value3, reverse: true);
			short value4 = 封包_读2.读短整数型(reverse: true);
			obj.写短整数型(value4, reverse: true);
			int value5 = 封包_读2.读整数型(reverse: true);
			obj.写整数型(value5, reverse: true);
			obj.写整数型(封包_读2.读整数型(reverse: true), reverse: true);
			obj.写字节集(封包_读2.读字节集(4), hasCount: false, 0);
			obj.写字节集(封包_读2.读字节集(16), hasCount: false, 0);
			byte[] bytes = 封包_读2.读字节集(4);
			obj.写字节集(bytes, hasCount: false, 0);
			_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass0_0();
			switch ((AllEnums.接收包头枚举)num)
			{
			case AllEnums.接收包头枚举.接收_商城界面打开:
				if (myclient.user.缓存数据.is商城刷新)
				{
					myclient.user.缓存数据.is商城刷新 = false;
					return null;
				}
				break;
			case AllEnums.接收包头枚举.接收_排行榜数据1:
				buffer = Singleton<WdAPI>.I.xVVoYsOCKa(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_排行榜数据2:
				buffer = Singleton<WdAPI>.I.PHfopOeqG8(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_元婴切换状态:
				myclient.user.缓存数据.Is等级调整 = true;
				if (buffer.Length == 14)
				{
					Singleton<WdAPI>.I.W9lI1TZlUs(myclient, myclient.user.人物数据.昵称, myclient.user.人物数据.角色ID.ToString(), "9999", "1");
				}
				break;
			case AllEnums.接收包头枚举.接收_所有线路详情:
				buffer = 接收_线路组合详情(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_喊话物品详情:
				buffer = Singleton<hQdJQufqsH3l9bnUemG>.I.RuQ6wGrDXV(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_商会背包响应:
				buffer = Singleton<COyX27f6L3uCF3F6Kp5>.I.EcGfvlEKGn(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_交易背包响应:
				buffer = Singleton<COyX27f6L3uCF3F6Kp5>.I.zw2fMOGq2o(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_摊位背包响应:
				buffer = Singleton<YHfw7nGpg7WfdCBKDH4>.I.WbyGrSj3WK(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_摆摊上架确定询问:
				buffer = Singleton<YHfw7nGpg7WfdCBKDH4>.I.XFiGz7GUDa(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_仓库背包响应:
				buffer = Singleton<COyX27f6L3uCF3F6Kp5>.I.o5pf5rjR8h(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_属性刷新:
				buffer = lqu2iqp13H(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_地府商城列表:
				buffer = Singleton<mDs6hiBvFvG3CRi3MZk>.I.ouWBk4AhMx(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_摊位数据:
				buffer = Singleton<YHfw7nGpg7WfdCBKDH4>.I.x4jGZGHH44(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_成功失败展示:
				rur2NV5PRN(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_所有NPC信息:
				Singleton<z4BxVniyeUkxpq0lEyg>.I.K1bipvfXc4(myclient, buffer);
				if (myclient.user.人物数据.Is试道场 && Singleton<全局变量类>.I.试道大会配置.功能开关 && Singleton<全局变量类>.I.试道大会配置.队伍最高人数 != 5 && myclient.user.队伍数据.成员列表.Count > Singleton<全局变量类>.I.试道大会配置.队伍最高人数 && myclient.user.队伍数据.is队长)
				{
					Singleton<SSW8tHD2MvRIUVygbNo>.I.k17Dnj17RB(myclient);
				}
				if (myclient.user.缓存数据.Is切图)
				{
					myclient.user.缓存数据.Is切图 = false;
					return null;
				}
				if (Singleton<z4BxVniyeUkxpq0lEyg>.I.vbkiQt86xb(myclient.插件端口).ContainsKey(-1))
				{
					Singleton<z4BxVniyeUkxpq0lEyg>.I.v2diOkGfAn(myclient.插件端口, -1);
					return null;
				}
				break;
			case AllEnums.接收包头枚举.接收_战斗伤害处理:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.FVYGkutIN2(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_火眼金睛返回:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.JIbGCjRRkh(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_战斗技能1:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.bPoGhSEhXT(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_战斗技能2:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.bPoGhSEhXT(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_进入战斗信息:
				Singleton<OmF9SPGlN77YLFkkoqN>.I.IqKGBZSJD3(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_战斗结束:
				Singleton<OmF9SPGlN77YLFkkoqN>.I.IhLGfPfE99(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_战斗日志信息:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.FuLG2pU2sy(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_敌方战斗信息1:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.uFlGndCwNW(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_敌方战斗信息2:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.uFlGndCwNW(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_敌方战斗信息3:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.uFlGndCwNW(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_敌方战斗信息4:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.uFlGndCwNW(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_友方战斗信息1:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.cauG527dwQ(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_友方战斗信息2:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.cauG527dwQ(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_友方战斗信息3:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.cauG527dwQ(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_友方战斗信息4:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.cauG527dwQ(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_是否允许播放:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.AObG06rAnP(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_是否允许播放2:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.xxjGOAKAtD(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_回合结束:
				buffer = Singleton<OmF9SPGlN77YLFkkoqN>.I.DtcGMUj4dN(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_娃娃面板属性:
				Singleton<mQEQjEBxYW4SsAecBHJ>.I.FiSBAZIO6W(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_娃娃面板刷新:
				Singleton<mQEQjEBxYW4SsAecBHJ>.I.y3qBzkOvuB(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_娃娃属性刷新:
				Singleton<mQEQjEBxYW4SsAecBHJ>.I.d4tGunb9sP(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_GM权限返回:
				if (myclient.当前权限 != 300)
				{
					return null;
				}
				break;
			case AllEnums.接收包头枚举.接收_所有属性列表:
				buffer = Singleton<接收数据响应处理类>.I.接收_所有属性列表处理(buffer);
				break;
			case AllEnums.接收包头枚举.接收_所有属性列二:
				buffer = Singleton<接收数据响应处理类>.I.接收_所有属性列表处理(buffer);
				break;
			case AllEnums.接收包头枚举.接收_所有地图:
				if (!全局变量类.Is所有地图 && Singleton<ByteAPI>.I.寻找字节集(buffer, Singleton<ByteAPI>.I.到字节集("/gs/zone/guandao/guandaobei.c")))
				{
					全局变量类.Is所有地图 = true;
					OrB2DR5eqm(myclient, buffer);
					return null;
				}
				break;
			case AllEnums.接收包头枚举.接收_会员时间:
				if (Singleton<ByteAPI>.I.寻找字节集(buffer, Singleton<ByteAPI>.I.到字节集("使用了#R道具套餐卡#n，有效时间还有#R")))
				{
					string 总文本2 = Singleton<ByteAPI>.I.到文本(buffer);
					if (int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(总文本2, "有效时间还有#R", "#n天"), out myclient.user.缓存数据.当前会员天数))
					{
						myclient.user.缓存数据.is会员卡 = myclient.user.缓存数据.当前会员天数 > 0;
					}
				}
				break;
			case AllEnums.接收包头枚举.接收_频道信息:
				buffer = Singleton<hQdJQufqsH3l9bnUemG>.I.XjBft4bbJj(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_商城道具信息:
				if (FusVSwwzpuFHNrjHS7T.ICGbUwAM9X == Array.Empty<byte>())
				{
					FusVSwwzpuFHNrjHS7T.ICGbUwAM9X = buffer;
					Singleton<FusVSwwzpuFHNrjHS7T>.I.kZSbd0MGHY(buffer);
				}
				break;
			case AllEnums.接收包头枚举.接收_系统设置信息:
				if (Singleton<ByteAPI>.I.寻找字节集(buffer, "fight"))
				{
					myclient.user.人物数据.is允许切磋 = Singleton<ByteAPI>.I.寻找字节集(buffer, new byte[7] { 102, 105, 103, 104, 116, 0, 0 });
				}
				break;
			case AllEnums.接收包头枚举.接收_无双圣榜信息:
				buffer = Singleton<BpcEfFbiGBBV3s2B0ai>.I.IdQbP9y1rt(myclient);
				break;
			case AllEnums.接收包头枚举.接收_技能刷新信息:
				if (Singleton<ByteAPI>.I.寻找字节集(buffer, Singleton<ByteAPI>.I.到字节集("法宝共生")))
				{
					myclient.user.人物数据.is法宝共生 = true;
				}
				buffer = KcN2jtISLw(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_对象附加属性信息:
				Singleton<L1ya6XBSPGoekkP8WeX>.I.TUPBMyTp98(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_宠物刷新信息:
				buffer = Singleton<i3kWo8GUakCSddRpyDe>.I.dj3GDEQoE3(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_修复年费1:
				return null;
			case AllEnums.接收包头枚举.接收_修复年费2:
				return null;
			case AllEnums.接收包头枚举.接收_上线IP提示:
				return null;
			case AllEnums.接收包头枚举.接收_登录账号返回:
				buffer = 接收_登录账号密码(buffer);
				break;
			case AllEnums.接收包头枚举.接收_换线返回信息:
				buffer = 接收_换线响应(buffer);
				break;
			case AllEnums.接收包头枚举.接收_线路组合信息:
				buffer = 接收_线路组合(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_切换角色信息:
				buffer = bpc2gODwUd(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_地图更新信息:
				buffer = 接收_地图更新(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_丢弃物品信息:
				if (Singleton<全局变量类>.I.config.is屏蔽垃圾)
				{
					return null;
				}
				return buffer;
			case AllEnums.接收包头枚举.接收_上线预读信息:
				接收_预读基本数据(myclient, buffer);
				pTy2dHvHBD(myclient);
				break;
			case AllEnums.接收包头枚举.接收_人物面板刷新1:
				buffer = Singleton<L1ya6XBSPGoekkP8WeX>.I.hcdB5D6A9G(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_人物面板刷新2:
				buffer = Singleton<L1ya6XBSPGoekkP8WeX>.I.hcdB5D6A9G(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_人物面板刷新3:
				buffer = Singleton<L1ya6XBSPGoekkP8WeX>.I.hcdB5D6A9G(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_称号列表信息:
				InH2WWXkT7(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_周围对象信息:
				buffer = Singleton<L1ya6XBSPGoekkP8WeX>.I.baYBnXhLY9(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_背包响应信息:
				buffer = Singleton<COyX27f6L3uCF3F6Kp5>.I.tIvfFfsumd(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_交易信息:
				buffer = eCB2slIhto(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_宠物面板信息:
				buffer = Singleton<i3kWo8GUakCSddRpyDe>.I.v2ZGgD6bGf(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_增减宠物信息:
				Singleton<WdAPI>.I.Ua2oNtysKT(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_乘骑坐骑信息:
				CS_0024_003C_003E8__locals3.xqAyiBR1nZ = Singleton<ByteAPI>.I.反转_整数(Singleton<ByteAPI>.I.取字节集右边(buffer, 4));
				myclient.user.缓存数据.当前乘骑坐骑id = CS_0024_003C_003E8__locals3.xqAyiBR1nZ;
				myclient.user.缓存数据.is坐骑风灵丸 = myclient.user.宠物数据.Any( (宠物缓存数据类 a) => a.iQFIbnJHxG(CS_0024_003C_003E8__locals3.xqAyiBR1nZ));
				break;
			case AllEnums.接收包头枚举.接收_提示信息1:
				buffer = Singleton<hQdJQufqsH3l9bnUemG>.I.AX8fZUSN5X(myclient, buffer, num);
				break;
			case AllEnums.接收包头枚举.接收_提示信息2:
				buffer = Singleton<hQdJQufqsH3l9bnUemG>.I.AX8fZUSN5X(myclient, buffer, num);
				break;
			case AllEnums.接收包头枚举.接收_人物状态:
				buffer = Singleton<L1ya6XBSPGoekkP8WeX>.I.lqTBhgvsWt(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_人物对象显示:
				buffer = Singleton<L1ya6XBSPGoekkP8WeX>.I.lqTBhgvsWt(myclient, buffer, AllEnums.接收包头枚举.接收_人物对象显示);
				break;
			case AllEnums.接收包头枚举.接收_商店售卖信息:
				buffer = 接收_组包商店信息(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_NPC点击:
				buffer = Singleton<z4BxVniyeUkxpq0lEyg>.I.a9Vi3pVQj3(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_任务列表信息:
			{
				AllEnums.任务Type 任务Type = Singleton<UuQEWHhexEnQTYynfh>.I.Ebt7PQbhf(myclient, buffer);
				if (任务Type != AllEnums.任务Type.无)
				{
					Singleton<UuQEWHhexEnQTYynfh>.I.LMVajrfJF(myclient, 任务Type);
					return (任务Type == AllEnums.任务Type.自动摆摊) ? Singleton<sGGAjyixPch0Uk158L6>.I.GBZi4oRkq3(myclient, buffer) : null;
				}
				return Singleton<sGGAjyixPch0Uk158L6>.I.GBZi4oRkq3(myclient, buffer);
			}
			case AllEnums.接收包头枚举.接收_创建队伍信息1:
				buffer = EKl2R6vWRl(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_创建队伍信息2:
				buffer = EKl2R6vWRl(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_越活度信息:
				myclient.user.缓存数据.活跃值 = Singleton<ByteAPI>.I.反转_短整数(Singleton<ByteAPI>.I.取字节集中间(buffer, 63, 2));
				break;
			case AllEnums.接收包头枚举.接收_摆摊放入:
				if (Singleton<全局变量类>.I.超级道具配置.功能开关 && !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.超级道具配置.禁止摆摊道具))
				{
					string 总文本 = Singleton<ByteAPI>.I.到文本(buffer);
					总文本 = Singleton<ByteAPI>.I.文本_取出中间文本(总文本, "请输入出售#R", "#n的单价");
					if (("|" + Singleton<全局变量类>.I.超级道具配置.禁止摆摊道具 + "|").Contains("|" + 总文本 + "|", StringComparison.CurrentCulture))
					{
						myclient.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + 总文本 + "#n被禁止摆摊！"));
						return null;
					}
				}
				break;
			case AllEnums.接收包头枚举.接收_宠物参战休息:
			{
				byte[] buffer2 = Singleton<ByteAPI>.I.取字节集右边(buffer, 6);
				int num3 = Singleton<ByteAPI>.I.反转_整数(Singleton<ByteAPI>.I.取字节集左边(buffer2, 4));
				switch (Singleton<ByteAPI>.I.反转_短整数(Singleton<ByteAPI>.I.取字节集右边(buffer2, 2)))
				{
				case 0:
					myclient.user.缓存数据.当前参战宠物id = 0;
					break;
				case 1:
					myclient.user.缓存数据.当前参战宠物id = num3;
					break;
				case 2:
					myclient.user.缓存数据.当前掠阵宠物id = num3;
					break;
				}
				break;
			}
			case AllEnums.接收包头枚举.接收_退出界面:
				buffer = Singleton<接收数据响应处理类>.I.ua32oYtqbg(myclient, buffer);
				break;
			case AllEnums.接收包头枚举.接收_角色列表:
				Singleton<MainService>.I.历史IP账号列表.TryGetValue(myclient.当前client.IP, out myclient.账号);
				break;
			}
			return buffer;
		}
		catch (Exception ex)
		{
			Log.ForContext("AuditCategory", "player-anomaly").Error("接收处理中心-报错：" + ex.Message + "[" + ex.StackTrace + "]");
			return null;
		}
	}

	
	public byte[] 接收_登录账号密码(byte[] buffer)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(buffer, 0, buffer.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value), reverse: true);
			for (int i = 0; i < value; i++)
			{
				string zone = 封包_读2.读文本型(是否声明长度: true, 0);
				封包_读2.读文本型(是否声明长度: true, 0);
				封包_写2.写文本型(zone, hasCount: true, 0);
				封包_写2.写文本型(Singleton<全局变量类>.I.config.插件IP, hasCount: true, 0, reverse: true);
			}
			封包_写2.写入数据(封包_读2.剩余数据(), hasCount: false, 0);
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return obj.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("接收_登录账号密码-报错：" + ex.Message + ex.StackTrace);
			return null;
		}
	}

	
	public byte[] 接收_换线响应(byte[] buffer)
	{
		try
		{
			封包_读 obj = new 封包_读(buffer, 0, buffer.Length);
			封包_写 封包_写2 = new 封包_写();
			obj.Seek(10L, SeekOrigin.Begin);
			byte[] bytes = obj.读字节集(4);
			string text = obj.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			text = text.Replace(Singleton<全局变量类>.I.config.游戏IP, Singleton<全局变量类>.I.config.插件IP);
			string[] array = Singleton<全局变量类>.I.config.游戏端口.Split(",");
			string[] array2 = Singleton<全局变量类>.I.config.插件端口.Split(",");
			for (int i = 0; i < array.Length; i++)
			{
				text = text.Replace(array[i], array2[i]);
			}
			封包_写2.写字节集(bytes, hasCount: false, 0);
			封包_写2.写文本型(text, hasCount: true, 0, reverse: true);
			封包_写 obj2 = new 封包_写();
			obj2.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj2.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return obj2.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("接收_换线响应-报错：" + ex.Message + ex.StackTrace);
			return null;
		}
	}

	
	public byte[] 接收_线路组合(MyNATSocketClient myclient, byte[] buffer)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(buffer, 0, buffer.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			byte[] array = 封包_读2.读字节集(2);
			封包_写2.Write(array);
			array = 封包_读2.读字节集(4);
			封包_写2.Write(array);
			short value = (short)(myclient.当前权限 = 封包_读2.读短整数型(reverse: true));
			if (myclient.当前权限 != 300)
			{
				value = 0;
			}
			封包_写2.写短整数型(value, reverse: true);
			封包_读2.读文本型(out string value2, true, (byte)0, false);
			if (string.IsNullOrWhiteSpace(value2))
			{
				return buffer;
			}
			封包_写2.写文本型(Singleton<全局变量类>.I.config.插件IP, hasCount: true, 0);
			short key = 封包_读2.读短整数型(reverse: true);
			if (Singleton<MainService>.I.游戏端口对应插件端口组.ContainsKey(key))
			{
				封包_写2.写短整数型(Singleton<MainService>.I.游戏端口对应插件端口组[key], reverse: true);
				array = 封包_读2.剩余数据();
				封包_写2.写入数据(array, hasCount: false, 0);
				封包_写 obj = new 封包_写();
				obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
				obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
				return obj.取数据();
			}
			return null;
		}
		catch (Exception ex)
		{
			Log.Error("接收_线路组合-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	public byte[] 接收_线路组合详情(MyNATSocketClient myclient, byte[] buffer)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(buffer, 0, buffer.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value), reverse: true);
			for (int i = 0; i < value; i++)
			{
				string text = 封包_读2.读文本型(是否声明长度: true, 0);
				封包_写2.写文本型((text == Singleton<全局变量类>.I.config.游戏IP) ? Singleton<全局变量类>.I.config.插件IP : text, hasCount: true, 0);
				封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
				封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
			}
			封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("接收_线路组合详情-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	public 角色存档数据类 初始创建角色存档(int GID, string 昵称, string 账号)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals3.mufyPEmhF5 = 账号;
		角色存档数据类 角色存档数据类2 = new 角色存档数据类
		{
			GID = GID,
			昵称 = 昵称,
			账号 = CS_0024_003C_003E8__locals3.mufyPEmhF5
		};
		注册信息 注册信息2 = Singleton<全局变量类>.I.注册列表.Find( (注册信息 x) => x.账号 == CS_0024_003C_003E8__locals3.mufyPEmhF5);
		if (注册信息2 != null)
		{
			角色存档数据类2.账号注册QQ = 注册信息2.qq;
		}
		角色存档数据类2.轮回转世数据.存档方案1.转世属性列表[0] = new 轮回转世属性存档();
		角色存档数据类2.轮回转世数据.存档方案1.转世属性列表[1] = new 轮回转世属性存档();
		角色存档数据类2.轮回转世数据.存档方案1.转世属性列表[2] = new 轮回转世属性存档();
		角色存档数据类2.轮回转世数据.存档方案1.转世属性列表[3] = new 轮回转世属性存档();
		角色存档数据类2.轮回转世数据.存档方案1.转世属性列表[4] = new 轮回转世属性存档();
		角色存档数据类2.轮回转世数据.存档方案1.转世属性列表[5] = new 轮回转世属性存档();
		角色存档数据类2.轮回转世数据.存档方案2.转世属性列表[0] = new 轮回转世属性存档();
		角色存档数据类2.轮回转世数据.存档方案2.转世属性列表[1] = new 轮回转世属性存档();
		角色存档数据类2.轮回转世数据.存档方案2.转世属性列表[2] = new 轮回转世属性存档();
		角色存档数据类2.轮回转世数据.存档方案2.转世属性列表[3] = new 轮回转世属性存档();
		角色存档数据类2.轮回转世数据.存档方案2.转世属性列表[4] = new 轮回转世属性存档();
		角色存档数据类2.轮回转世数据.存档方案2.转世属性列表[5] = new 轮回转世属性存档();
		return 角色存档数据类2;
	}

	
	public void 接收_预读基本数据(MyNATSocketClient myclient, byte[] buffer)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals67 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals67.HJVyFR6pbr = myclient;
		try
		{
			if (CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.GID != 0)
			{
				return;
			}
			Singleton<MainService>.I.历史IP机器码列表.TryGetValue(CS_0024_003C_003E8__locals67.HJVyFR6pbr.当前client.IP, out CS_0024_003C_003E8__locals67.HJVyFR6pbr.Mac);
			CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.昵称 = Singleton<ByteAPI>.I.到文本(Singleton<ByteAPI>.I.取字节集中间(buffer, 13, Singleton<ByteAPI>.I.取字节集中间(buffer, 12, 1)[0]));
			int num = DB.I.E3iNgPntG8(CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.昵称);
			if (num == 0)
			{
				Log.Error("[" + CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.昵称 + "]取角色GID失败");
				CS_0024_003C_003E8__locals67.HJVyFR6pbr.C_Send(Singleton<WdAPI>.I.提示_中心提醒("[" + CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.昵称 + "]取角色GID失败"));
				Singleton<WdAPI>.I.WT9IHmFS6c(CS_0024_003C_003E8__locals67.HJVyFR6pbr, CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.昵称);
				return;
			}
			Singleton<ByteAPI>.I.GetHexGid_(num);
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定GID玩家MyClient(num);
			if (myNATSocketClient != null)
			{
				CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据 = myNATSocketClient.user.人物数据;
				CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.属性数据 = myNATSocketClient.user.属性数据;
				CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.缓存数据 = myNATSocketClient.user.缓存数据;
				CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.队伍数据 = myNATSocketClient.user.队伍数据;
			}
			else
			{
				CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.GID = num;
			}
			CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.角色ID = 0;
			if (!DB.I.RhsNloVXFg(CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据))
			{
				Log.Error("[" + CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.昵称 + "]取角色账号失败强制下线");
				CS_0024_003C_003E8__locals67.HJVyFR6pbr.C_Send(Singleton<WdAPI>.I.提示_中心提醒("[" + CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.昵称 + "]取角色账号失败"));
				Singleton<WdAPI>.I.WT9IHmFS6c(CS_0024_003C_003E8__locals67.HJVyFR6pbr, CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.昵称);
				return;
			}
			CS_0024_003C_003E8__locals67.HJVyFR6pbr.当前权限 = DB.I.UliN8mrbMu(CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.账号);
			if (Singleton<全局变量类>.I.角色存档表.ContainsKey(CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.GID))
			{
				CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据 = Singleton<全局变量类>.I.角色存档表[CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.GID];
			}
			else
			{
				CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据 = 初始创建角色存档(CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.GID, CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.昵称, CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.账号);
				Singleton<全局变量类>.I.角色存档表.TryAdd(CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.GID, CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据);
				DB.I.oMuiwEHr6E(CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.GID, CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据);
			}
			if (Singleton<全局变量类>.I.黑名单记录.黑名单QQ列表.Any( (string x) => ("|" + CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.账号注册QQ).Contains("|" + x + "|", StringComparison.CurrentCulture)))
			{
				CS_0024_003C_003E8__locals67.HJVyFR6pbr.Close();
				return;
			}
			Singleton<全局变量类>.I.IpAddMac字典(CS_0024_003C_003E8__locals67.HJVyFR6pbr.当前client.IP + "|" + CS_0024_003C_003E8__locals67.HJVyFR6pbr.Mac, 1);
			CS_0024_003C_003E8__locals67.HJVyFR6pbr.使用中 = true;
			CS_0024_003C_003E8__locals67.HJVyFR6pbr.账号 = CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.账号;
			CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.账号 = CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.账号;
			CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.昵称 = CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.人物数据.昵称;
			CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.最后上线时间 = Singleton<ByteAPI>.I.取时间文本();
			if (CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.南极抽奖次数 > 0 && Singleton<全局变量类>.I.南极配置.功能开关)
			{
				CS_0024_003C_003E8__locals67.HJVyFR6pbr.C_Send(Singleton<WdAPI>.I.组包邮件南极次数(CS_0024_003C_003E8__locals67.HJVyFR6pbr));
			}
			if (!CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.is首登邮箱状态 && Singleton<全局变量类>.I.邮箱配置.功能开关 && Singleton<全局变量类>.I.邮箱配置.首登开关 && !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.邮箱配置.首登邮件))
			{
				CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.is首登邮箱状态 = true;
				CS_0024_003C_003E8__locals67.HJVyFR6pbr.C_Send(Singleton<WdAPI>.I.jyLIAFgHTA(CS_0024_003C_003E8__locals67.HJVyFR6pbr, Singleton<全局变量类>.I.邮箱配置.首登邮件));
			}
			CS_0024_003C_003E8__locals67.HJVyFR6pbr.C_Send(全局常量类.累充图标包);
			Singleton<mDs6hiBvFvG3CRi3MZk>.I.ElmBC999cR(CS_0024_003C_003E8__locals67.HJVyFR6pbr);
			if (CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.累计充值金额 >= Singleton<全局变量类>.I.config.累充金额 && Singleton<全局变量类>.I.config.is上线牌面)
			{
				int num2 = (int)Singleton<ByteAPI>.I.取时间戳();
				int num3 = (int)Singleton<ByteAPI>.I.取时间戳(CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.上次牌面时间);
				if (num2 - num3 >= Singleton<全局变量类>.I.config.上线牌面时间间隔 * 60)
				{
					CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.上次牌面时间 = num2;
					switch (Singleton<全局变量类>.I.config.上线牌面)
					{
					case AllEnums.上线牌面Type.烟花雨:
						Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.O8qIzajjvj(string.Format(Singleton<全局变量类>.I.config.上线牌面内容, CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.昵称)));
						break;
					case AllEnums.上线牌面Type.流动广播:
						Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.PWRouuXjmn(string.Format(Singleton<全局变量类>.I.config.上线牌面内容, CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.昵称)));
						break;
					case AllEnums.上线牌面Type.横幅:
						Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.o5iowqAXwm(string.Format(Singleton<全局变量类>.I.config.上线牌面内容, CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.昵称)));
						break;
					case AllEnums.上线牌面Type.烟花雨_流动广播:
						Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.O8qIzajjvj(string.Empty).Concat(Singleton<WdAPI>.I.PWRouuXjmn(string.Format(Singleton<全局变量类>.I.config.上线牌面内容, CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.昵称))).ToArray());
						break;
					case AllEnums.上线牌面Type.系统频道:
						Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(string.Format(Singleton<全局变量类>.I.config.上线牌面内容, CS_0024_003C_003E8__locals67.HJVyFR6pbr.user.存档数据.昵称), "管理员", AllEnums.频道Type.系统));
						break;
					}
				}
			}
			Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals67.HJVyFR6pbr, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.attack_effect, 0, true);
			if (num == Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣继承者Gid && Singleton<全局变量类>.I.圣无双配置.每次参拜雕像增幅 > 0)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals67.HJVyFR6pbr, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.attack_effect, Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前雕像参拜次数 * Singleton<全局变量类>.I.圣无双配置.每次参拜雕像增幅, true, "[无双]雕像参拜属性上线自动检测");
			}
		}
		catch (Exception ex)
		{
			Log.Error("接收_预读基本数据-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal byte[] EKl2R6vWRl(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			short num = 封包_读2.读短整数型(reverse: true);
			封包_写2.写短整数型(num, reverse: true);
			P_0.user.队伍数据.is队长 = false;
			P_0.user.队伍数据.成员列表.Clear();
			byte[] value = Array.Empty<byte>();
			int value2 = 0;
			short value3 = 0;
			int value4 = 0;
			int value5 = 0;
			short value6 = 0;
			int value7 = 0;
			string value8 = string.Empty;
			for (int i = 0; i < num; i++)
			{
				封包_写2.写整数型(封包_读2.读整数型(reverse: true, out value4), reverse: true);
				封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out value3), reverse: true);
				if (i == 0)
				{
					P_0.user.队伍数据.is队长 = P_0.user.人物数据.角色ID == value4;
				}
				P_0.user.队伍数据.成员列表.Add(value4);
				for (int j = 0; j < value3; j++)
				{
					封包_写2.写字节集(封包_读2.读字节集(2, out value), hasCount: false, 0);
					封包_写2.写字节型(封包_读2.读字节型(out value2));
					switch (value2)
					{
					case 1:
						封包_写2.写字节型(封包_读2.读字节型(out value5));
						break;
					case 2:
						封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out value6), reverse: true);
						break;
					case 3:
						封包_写2.写整数型(封包_读2.读整数型(reverse: true, out value7), reverse: true);
						break;
					case 4:
						封包_写2.写文本型(封包_读2.读文本型(out value8, true, (byte)0, false), hasCount: true, 0);
						break;
					}
				}
				封包_写2.写字节集(封包_读2.读字节集(12), hasCount: false, 0);
				封包_写2.写文本型(封包_读2.读文本型(out string _, true, (byte)0, false), hasCount: true, 0);
				封包_写2.写字节集(封包_读2.读字节集(6), hasCount: false, 0);
			}
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return obj.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("组合创建组队-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal async Task pTy2dHvHBD(MyNATSocketClient P_0)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals77 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals77.hl2yS0Ml0M = P_0;
		try
		{
			await Task.Delay(1000);
			if (!CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.技能数据.技能列表.ContainsKey("急急如律令"))
			{
				Singleton<WdAPI>.I.W9lI1TZlUs(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.昵称, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.角色ID.ToString(), "9999", "1");
				await Task.Delay(100);
			}
			if (!CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.技能数据.技能列表.ContainsKey("腾云驾雾"))
			{
				Singleton<WdAPI>.I.W9lI1TZlUs(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.昵称, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.角色ID.ToString(), "308", "1");
				await Task.Delay(100);
			}
			if (!CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.技能数据.技能列表.ContainsKey("金遁术") && CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.五行 == 1)
			{
				Singleton<WdAPI>.I.W9lI1TZlUs(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.昵称, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.角色ID.ToString(), "2", "1");
				await Task.Delay(100);
			}
			else if (!CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.技能数据.技能列表.ContainsKey("木遁术") && CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.五行 == 2)
			{
				Singleton<WdAPI>.I.W9lI1TZlUs(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.昵称, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.角色ID.ToString(), "52", "1");
				await Task.Delay(100);
			}
			else if (!CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.技能数据.技能列表.ContainsKey("水遁术") && CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.五行 == 3)
			{
				Singleton<WdAPI>.I.W9lI1TZlUs(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.昵称, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.角色ID.ToString(), "102", "1");
				await Task.Delay(100);
			}
			else if (!CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.技能数据.技能列表.ContainsKey("火遁术") && CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.五行 == 4)
			{
				Singleton<WdAPI>.I.W9lI1TZlUs(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.昵称, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.角色ID.ToString(), "152", "1");
				await Task.Delay(100);
			}
			else if (!CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.技能数据.技能列表.ContainsKey("土遁术") && CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.五行 == 5)
			{
				Singleton<WdAPI>.I.W9lI1TZlUs(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.昵称, CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.角色ID.ToString(), "202", "1");
				await Task.Delay(100);
			}
			if (fuMNpgieFTYU3Wah53.BojPVlpN4() && CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.背包数据.物品列表[8].物品ID == 0)
			{
				CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.缓存数据.Is首次穿戴梭子 = 1;
				Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, AllEnums.发送数据Type.道具, "御天梭", AllEnums.指令Type.无, 1, false, "发送御天梭");
			}
			CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.缓存数据.is商城刷新 = true;
			CS_0024_003C_003E8__locals77.hl2yS0Ml0M.S_Send(Singleton<WdAPI>.I.sfjNuF8Sek(CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.昵称));
			CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.妖族化形数据.Close();
			if (CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.is摆摊中 && Singleton<全局变量类>.I.在线泡点配置.泡点开关 && Singleton<全局变量类>.I.在线泡点配置.双倍开关)
			{
				Singleton<等级道行检测功能>.I.发放离线泡点奖励(CS_0024_003C_003E8__locals77.hl2yS0Ml0M);
			}
			if (Singleton<z4BxVniyeUkxpq0lEyg>.I.vbkiQt86xb(CS_0024_003C_003E8__locals77.hl2yS0Ml0M.插件端口).ContainsKey(-1))
			{
				CS_0024_003C_003E8__locals77.hl2yS0Ml0M.S_Send(全局常量类.获取所有NPC包, "首次上线系列处理事件2");
				await Task.Delay(1000);
			}
			if (!全局变量类.Is所有地图)
			{
				CS_0024_003C_003E8__locals77.hl2yS0Ml0M.S_Send(new byte[12]
				{
					77, 90, 0, 0, 0, 0, 0, 0, 0, 2,
					112, 10
				}, "首次上线系列处理事件1");
				await Task.Delay(1000);
			}
			if (!CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.is防摆摊状态)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, AllEnums.发送数据Type.道具, "自动摆摊卡", AllEnums.指令Type.无, 1, false, "发送自动摆摊卡");
			}
			if (Singleton<全局变量类>.I.推荐拉人配置.功能开关 && CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.推荐拉人数据.推荐人GID == 0)
			{
				CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.缓存数据.cdk类型 = AllEnums.CdkType.推荐;
				MyNATSocketClient myNATSocketClient = CS_0024_003C_003E8__locals77.hl2yS0Ml0M;
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
				myNATSocketClient.C_Send(i.组包输入框(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND())
			{
				Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.N1k2pMUNPH(CS_0024_003C_003E8__locals77.hl2yS0Ml0M);
				await Task.Delay(1000);
			}
			if (Singleton<全局变量类>.I.config.is首登赠送)
			{
				if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.config.首登赠送1) && CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.首登礼包领取阶段 == 0)
				{
					CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.首登礼包领取阶段 = 1;
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.config.首登赠送1, AllEnums.指令Type.无, 1, false, "首登赠送1");
				}
				else if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.config.首登赠送2) && CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.首登礼包领取阶段 == 1)
				{
					CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.首登礼包领取阶段 = 2;
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.config.首登赠送2, AllEnums.指令Type.无, 1, false, "首登赠送2");
				}
				else if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.config.首登赠送3) && CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.首登礼包领取阶段 == 2)
				{
					CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.首登礼包领取阶段 = 3;
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.config.首登赠送3, AllEnums.指令Type.无, 1, false, "首登赠送3");
				}
				else if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.config.首登赠送4) && CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.首登礼包领取阶段 == 3)
				{
					CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.首登礼包领取阶段 = 4;
					Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.config.首登赠送4, AllEnums.指令Type.无, 1, false, "首登赠送4");
				}
			}
			CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.缓存数据.is坐骑风灵丸 = CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.宠物数据.Any( (宠物缓存数据类 a) => a.iQFIbnJHxG(CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.缓存数据.当前乘骑坐骑id));
			List<string> list = new List<string>();
			foreach (string item in 问道数据类.删除任务列表)
			{
				if (CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.缓存数据.任务缓存字典.ContainsKey(item))
				{
					list.Add(item);
				}
			}
			Singleton<WdAPI>.I.k1vI5WDVju(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, list);
			if (Singleton<全局变量类>.I.config.is随身货栈)
			{
				Singleton<全局变量类>.I.王中王物品列表.Clear();
				if (!uh2edhfVGtogUy49Lpv.pdEfxlnyv1() && CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.人物数据.账号 == Singleton<全局变量类>.I.config.挂载GM账号)
				{
					CS_0024_003C_003E8__locals77.hl2yS0Ml0M.C_Send(Singleton<WdAPI>.I.提示_中心提醒("开始自动获取NPC和商店类，停止前请勿操作"));
					Singleton<OKaMOvJmaKgK6WqoSYv>.I.VPyJ77BObK(CS_0024_003C_003E8__locals77.hl2yS0Ml0M);
				}
			}
			Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals77.hl2yS0Ml0M, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.enhanced_phy, 0, true);
			if (CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.Is清空相性)
			{
				CS_0024_003C_003E8__locals77.hl2yS0Ml0M.user.存档数据.Is清空相性 = false;
				Singleton<WdAPI>.I.清空玩家相性点(CS_0024_003C_003E8__locals77.hl2yS0Ml0M);
			}
			Singleton<xH3TPsiexTnpJAMMnJm>.I.zphBuNjiUj(CS_0024_003C_003E8__locals77.hl2yS0Ml0M);
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("首次上线系列处理事件-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal byte[] eCB2slIhto(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(12L, SeekOrigin.Begin);
			obj.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			int num = obj.读字节型();
			if (P_0.user.背包数据.物品列表[num] == null)
			{
				return null;
			}
			if (num > 100 && num <= 180)
			{
				string 名字 = P_0.user.背包数据.物品列表[num].名字;
				if (名字 == "特级藏宝图" || 名字 == "老酒" || ("|" + Singleton<全局变量类>.I.超级道具配置.禁止交易道具 + "|").Contains("|" + 名字 + "|", StringComparison.CurrentCulture))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R" + 名字 + "#n无法进行交易出售。"));
					return null;
				}
			}
			return P_1;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_交易判断-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return null;
		}
	}

	
	internal byte[] bnI2UiRg6u(MyNATSocketClient P_0, byte[] P_1, int P_2, string P_3)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			short num = 封包_读2.读短整数型(reverse: true);
			封包_写2.写短整数型(num, reverse: true);
			for (int i = 0; i < num; i++)
			{
				short value = 封包_读2.读短整数型(reverse: true);
				封包_写2.写短整数型(value, reverse: true);
				short num2 = 封包_读2.读短整数型(reverse: true);
				封包_写2.写短整数型(num2, reverse: true);
				for (int j = 0; j < num2; j++)
				{
					byte[] array = 封包_读2.读字节集(2);
					封包_写2.写字节集(array, hasCount: false, 0);
					int num3 = 封包_读2.读字节型();
					封包_写2.写字节型(num3);
					string empty = string.Empty;
					switch (num3)
					{
					case 1:
						封包_写2.写字节型(封包_读2.读字节型());
						break;
					case 2:
						封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
						break;
					case 3:
						封包_写2.写整数型(封包_读2.读整数型(reverse: true), reverse: true);
						break;
					case 4:
						empty = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
						if (Enumerable.SequenceEqual(array, new byte[2] { 1, 8 }))
						{
							empty = ((("、" + Singleton<全局变量类>.I.属性洗炼配置.时装配置.装备名字 + "、").IndexOf("、" + P_3 + "、") == -1 && ("、" + Singleton<全局变量类>.I.属性洗炼配置.仙器配置.装备名字 + "、").IndexOf("、" + P_3 + "、") == -1) ? empty.Replace("#B洗炼：", "#B") : string.Empty);
						}
						封包_写2.写文本型(empty, hasCount: true, 0, reverse: true);
						break;
					case 6:
						封包_写2.写字节型(封包_读2.读字节型());
						break;
					case 7:
						封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
						break;
					}
				}
			}
			return 封包_写2.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("背包物品封包重组-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal void InH2WWXkT7(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(12L, SeekOrigin.Begin);
			short num = 封包_读2.读短整数型(reverse: true);
			P_0.user.缓存数据.所有称号文本.Clear();
			P_0.user.缓存数据.所有称号文本.Append('|');
			for (int i = 0; i < num; i++)
			{
				封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
				string text = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
				string text2 = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
				if (string.IsNullOrWhiteSpace(text))
				{
					continue;
				}
				P_0.user.缓存数据.所有称号文本.Append(text + "|");
				if (text.Contains("代弟子", StringComparison.CurrentCulture))
				{
					if (text.Contains("第一代弟子", StringComparison.CurrentCulture))
					{
						P_0.user.缓存数据.几代弟子 = 1;
					}
					else if (text.Contains("第二代弟子", StringComparison.CurrentCulture))
					{
						P_0.user.缓存数据.几代弟子 = 2;
					}
					else if (text.Contains("第三代弟子", StringComparison.CurrentCulture))
					{
						P_0.user.缓存数据.几代弟子 = 3;
					}
					P_0.user.缓存数据.几代弟子文本 = Singleton<ByteAPI>.I.取文本右边(text, 10);
				}
				else if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.指定会员配置.指定称号) && text == Singleton<全局变量类>.I.指定会员配置.指定称号)
				{
					P_0.user.存档数据.指定会员到期时间戳 = (int)((!string.IsNullOrWhiteSpace(text2)) ? Singleton<ByteAPI>.I.取时间戳(text2) : 0);
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_称号列表事件处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal byte[] 接收_地图更新(MyNATSocketClient myclient, byte[] buffer)
	{
		try
		{
			封包_读 obj = new 封包_读(buffer, 0, buffer.Length);
			new 封包_写();
			obj.Seek(12L, SeekOrigin.Begin);
			int num = obj.读整数型(reverse: true);
			obj.Seek(4L, SeekOrigin.Current);
			string text = obj.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			short x = obj.读短整数型(reverse: true);
			short y = obj.读短整数型(reverse: true);
			if (myclient.user.人物数据.所在地图名字 == "GM工作室" && myclient.user.人物数据.账号 != Singleton<全局变量类>.I.config.挂载GM账号)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
				defaultInterpolatedStringHandler.AppendLiteral("账号：");
				defaultInterpolatedStringHandler.AppendFormatted(myclient.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral(" 昵称：");
				defaultInterpolatedStringHandler.AppendFormatted(myclient.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral(" 非法进入GM工作室");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				Singleton<WdAPI>.I.地图传送事件(myclient, "/gs/zone/tianyongcheng/tianyongcheng.c", "253", "196");
				return null;
			}
			if (text == "天墉城")
			{
				if (Singleton<全局变量类>.I.config.is红毯雪景)
				{
					buffer = buffer.Concat(Singleton<ByteAPI>.I.HtoC("4D5A00000000000000274225040AFFF448FA001D277908FFF448FA001D27790BFFF448FA001D277907FFF448FA001D2779")).ToArray();
				}
				buffer = buffer.Concat(Singleton<qWJBSr1mUIDAkQ6sSS>.I.Ul5eFS46P()).ToArray();
			}
			if (Singleton<全局变量类>.I.超级NPC配置.功能开关 && Singleton<超级NPC功能>.I.超级NPC封包.TryGetValue(text, out var value))
			{
				buffer = buffer.Concat(value).ToArray();
			}
			if (Singleton<全局变量类>.I.config.is本月试道 && myclient.user.人物数据.所在地图id != num)
			{
				if (num == 40067)
				{
					myclient.user.存档数据.原本道行 = myclient.user.属性数据.道行;
					WdAPI i = Singleton<WdAPI>.I;
					string empty = string.Empty;
					int 本月道行 = myclient.user.存档数据.本月道行;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
					defaultInterpolatedStringHandler.AppendLiteral("[本月道行]进入试道地图道行置换当前道行");
					defaultInterpolatedStringHandler.AppendFormatted(myclient.user.属性数据.道行);
					defaultInterpolatedStringHandler.AppendLiteral(" 到 本月道行");
					defaultInterpolatedStringHandler.AppendFormatted(myclient.user.存档数据.本月道行);
					i.PndoGw5lW7(myclient, AllEnums.发送数据Type.数值, empty, AllEnums.指令Type.tao, 本月道行, true, defaultInterpolatedStringHandler.ToStringAndClear());
				}
				else if (myclient.user.存档数据.原本道行 > -1)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					string empty2 = string.Empty;
					int 原本道行 = myclient.user.存档数据.原本道行;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
					defaultInterpolatedStringHandler.AppendLiteral("[本月道行]退出试道地图道行置换当前道行");
					defaultInterpolatedStringHandler.AppendFormatted(myclient.user.属性数据.道行);
					defaultInterpolatedStringHandler.AppendLiteral(" 到 原本道行");
					defaultInterpolatedStringHandler.AppendFormatted(myclient.user.存档数据.原本道行);
					i2.PndoGw5lW7(myclient, AllEnums.发送数据Type.数值, empty2, AllEnums.指令Type.tao, 原本道行, true, defaultInterpolatedStringHandler.ToStringAndClear());
					myclient.user.存档数据.原本道行 = -1;
				}
			}
			myclient.user.人物数据.所在地图id = num;
			myclient.user.人物数据.所在地图名字 = text;
			myclient.user.人物数据.坐标.X = x;
			myclient.user.人物数据.坐标.Y = y;
			TimedDungeonService.I.OnMapUpdated(myclient, num, text);
			myclient.user.缓存数据.Is切图 = true;
			myclient.C_Send(buffer);
			myclient.S_Send(全局常量类.获取当前NPC包, "接收_地图更新");
			return null;
		}
		catch (Exception ex)
		{
			Log.Error("接收_地图更新-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return buffer;
		}
	}

	
	internal byte[] bpc2gODwUd(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(4), hasCount: false, 0);
			string text = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			string[] array = text.Split(" ");
			if (!text.Contains("角色", StringComparison.CurrentCulture))
			{
				text = Singleton<全局变量类>.I.config.插件IP + " ";
			}
			for (int i = 0; i < array.Length - 1; i++)
			{
				if (P_0.游戏端口.ToString() == array[i + 1])
				{
					array[i + 1] = P_0.插件端口.ToString();
				}
				text = text + array[i + 1] + " ";
			}
			text = Singleton<ByteAPI>.I.取文本左边(text, text.Length - 1);
			封包_写2.写文本型(text, hasCount: true, 0, reverse: true);
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return obj.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("接收_切换角色-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal async Task OrB2DR5eqm(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			Singleton<全局变量类>.I.所有地图字典.Clear();
			封包_读 读 = new 封包_读(P_1, 0, P_1.Length);
			读.Seek(12L, SeekOrigin.Begin);
			short 数量 = 读.读短整数型(reverse: true);
			_ = string.Empty;
			_ = string.Empty;
			for (int i = 0; i < 数量; i++)
			{
				string value = 读.读文本型(是否声明长度: true, 0);
				读.读整数型(reverse: true);
				string key = 读.读文本型(是否声明长度: true, 0);
				Singleton<全局变量类>.I.所有地图字典.TryAdd(key, value);
				await Task.Delay(1);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_所有地图处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal byte[] KcN2jtISLw(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass15_0();
			CS_0024_003C_003E8__locals4.JGdyfmq5Yr = Singleton<ByteAPI>.I.反转_整数(Singleton<ByteAPI>.I.取字节集中间(P_1, 12, 4));
			if (CS_0024_003C_003E8__locals4.JGdyfmq5Yr == P_0.user.人物数据.角色ID)
			{
				return vGl28Pv9rm(P_0, P_1);
			}
			if (P_0.user.娃娃数据.Any( (娃娃缓存数据类 x) => x.娃娃ID == CS_0024_003C_003E8__locals4.JGdyfmq5Yr))
			{
				return Singleton<mQEQjEBxYW4SsAecBHJ>.I.uiGGbOUvrG(P_0, P_1);
			}
			if (P_0.user.宠物数据.Any( (宠物缓存数据类 x) => x.宠物ID == CS_0024_003C_003E8__locals4.JGdyfmq5Yr))
			{
				return gom2IxJYSZ(P_0, P_1);
			}
			return P_1;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_技能相关处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	internal byte[] ch92lERo2M(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(12L, SeekOrigin.Begin);
			封包_读2.读整数型(reverse: true, out var _);
			封包_读2.读短整数型(reverse: true, out var value2);
			for (int i = 0; i < value2; i++)
			{
				封包_读2.读短整数型(reverse: true);
				封包_读2.读字节集(4);
				封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
				封包_读2.读字节集(2);
				封包_读2.读短整数型(reverse: true, out var _);
				封包_读2.读短整数型(reverse: true);
				封包_读2.读字节集(39);
				封包_读2.读短整数型(reverse: true, out var value4);
				for (int j = 0; j < value4; j++)
				{
					封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
					封包_读2.读字节集(4);
				}
				封包_读2.读字节集(5);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_所有技能处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return P_1;
	}

	
	internal byte[] vGl28Pv9rm(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			int num = 0;
			string value = string.Empty;
			short value2 = 0;
			short num2 = 0;
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写 封包_写3 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			bool flag = 妖族化形功能.使用中 && Singleton<WdAPI>.I.取对应化形ID(P_0.user.人物数据.形象ID) != 0;
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value4), reverse: true);
			byte[] value5;
			for (int i = 0; i < value4; i++)
			{
				封包_写3.清数据();
				封包_写3.写字节集(封包_读2.读字节集(6, out value5), hasCount: false, 0);
				封包_读2.读文本型(out value, true, (byte)0, false);
				封包_写3.写文本型(flag ? Singleton<WdAPI>.I.形象ID取技能名(P_0.user.人物数据.形象ID, value) : value, hasCount: true, 0);
				封包_写3.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
				封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out value2), reverse: true);
				num2 = 封包_读2.读短整数型(reverse: true);
				封包_写3.写短整数型(num2, reverse: true);
				封包_写3.写字节集(封包_读2.读字节集(25), hasCount: false, 0);
				封包_写3.写字节集(封包_读2.读字节集(14), hasCount: false, 0);
				P_0.user.技能数据.额外附加等级 = num2;
				if (P_0.user.技能数据.技能列表.ContainsKey(value))
				{
					P_0.user.技能数据.技能列表[value] = (short)(value2 - num2);
				}
				else
				{
					P_0.user.技能数据.技能列表.TryAdd(value, (short)(value2 - num2));
				}
				封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value6), reverse: true);
				for (int j = 0; j < value6; j++)
				{
					string zone = 封包_读2.读文本型(是否声明长度: true, 0);
					封包_写3.写文本型(zone, hasCount: true, 0);
					封包_写3.写字节集(封包_读2.读字节集(4), hasCount: false, 0);
				}
				封包_写3.写字节集(封包_读2.读字节集(5), hasCount: false, 0);
				if (!(value == "急急如律令") || (全局变量类.Is调试 && P_0.当前权限 >= 300))
				{
					num++;
					封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
				}
			}
			value5 = 封包_写2.取数据();
			if (num != value4)
			{
				byte[] array = Singleton<ByteAPI>.I.到字节集(num);
				value5[6] = array[0];
				value5[7] = array[1];
			}
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(value5, hasCount: true, 1, reverse: true);
			return obj.取数据();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_人物技能处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	internal byte[] gom2IxJYSZ(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass18_0();
			string value = string.Empty;
			short value2 = 0;
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out CS_0024_003C_003E8__locals2.zbly21nUPq), reverse: true);
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.Find( (宠物缓存数据类 x) => x.宠物ID == CS_0024_003C_003E8__locals2.zbly21nUPq);
			if (宠物缓存数据类2 == null)
			{
				return P_1;
			}
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value3), reverse: true);
			for (int num = 0; num < value3; num++)
			{
				封包_写2.写字节集(封包_读2.读字节集(6), hasCount: false, 0);
				封包_写2.写文本型(封包_读2.读文本型(out value, true, (byte)0, false), hasCount: true, 0);
				封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
				封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out value2), reverse: true);
				封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
				封包_写2.写字节集(封包_读2.读字节集(25), hasCount: false, 0);
				封包_写2.写字节集(封包_读2.读字节集(12), hasCount: false, 0);
				if (value2 <= 0)
				{
					if (宠物缓存数据类2.技能列表.ContainsKey(value))
					{
						宠物缓存数据类2.技能列表.TryRemove(value, out var _);
					}
				}
				else if (宠物缓存数据类2.技能列表.ContainsKey(value))
				{
					宠物缓存数据类2.技能列表[value] = value2;
				}
				else
				{
					宠物缓存数据类2.技能列表.TryAdd(value, value2);
				}
				封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
				封包_写2.写字节集(封包_读2.读字节集(3), hasCount: false, 0);
				封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
				封包_写2.写字节集(封包_读2.读字节集(4), hasCount: false, 0);
				封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
				封包_写2.写字节集(封包_读2.读字节集(9), hasCount: false, 0);
			}
			封包_写2.写入数据(封包_读2.剩余数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_宠物技能处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	internal byte[] ua32oYtqbg(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			int num = Singleton<ByteAPI>.I.寻找字节集下标(P_1, 全局常量类.通天塔文字);
			if (num == -1)
			{
				return P_1;
			}
			P_1[num + 7] = (byte)(Singleton<全局变量类>.I.config.通天塔次数 + P_0.user.存档数据.通天塔额外次数);
			P_1[num + 9] = (byte)P_0.user.存档数据.已打通天塔次数;
			return P_1;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_退出界面刷新-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	public byte[] 接收_所有属性列表处理(byte[] buffer)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(buffer, 0, buffer.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value), reverse: true);
			for (short num = 0; num < value; num++)
			{
				封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
				封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
			}
			封包_写2.写入数据(封包_读2.剩余数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("所有属性列表处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return buffer;
		}
	}

	
	public byte[] 接收_所有道具描述处理(byte[] buffer)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(buffer, 0, buffer.Length);
			_ = string.Empty;
			封包_读2.Seek(12L, SeekOrigin.Begin);
			封包_读2.读短整数型(reverse: true, out var value);
			for (short num = 0; num < value; num++)
			{
				_ = 封包_读2.读文本型(是否声明长度: true, 0) + "：" + 封包_读2.读文本型(是否声明长度: true, 0);
			}
			return buffer;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_所有道具描述处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return null;
		}
	}

	
	public byte[] 接收_组包商店信息(MyNATSocketClient myclient, byte[] buffer)
	{
		try
		{
			do
			{
				buffer = Singleton<ByteAPI>.I.寻找字节集并替换(buffer, new byte[7] { 0, 6, 3, 0, 0, 3, 231 }, new byte[7] { 0, 6, 3, 0, 0, 0, 0 });
			}
			while (Singleton<ByteAPI>.I.寻找字节集(buffer, new byte[7] { 0, 6, 3, 0, 0, 3, 231 }));
			封包_读 封包_读2 = new 封包_读(buffer, 0, buffer.Length);
			封包_写 obj = new 封包_写();
			new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			obj.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			obj.写字节型(封包_读2.读字节型(out var value));
			obj.写整数型(封包_读2.读整数型(reverse: true, out var value2), reverse: true);
			if (value == 8 && value2 == Singleton<全局变量类>.I.NPC_王中王)
			{
				return Singleton<WdAPI>.I.dn5obQBNHX(myclient, buffer);
			}
			if (value == 6)
			{
				return Singleton<S09daDRcFbnf5np5xrV>.I.IOCR54YOlC(buffer);
			}
			return buffer;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_组包商店信息-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return buffer;
		}
	}

	
	internal void rur2NV5PRN(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(12L, SeekOrigin.Begin);
			if (P_1.Length >= 14)
			{
				封包_读2.读短整数型(reverse: true, out var _);
			}
			if (P_1.Length >= 16)
			{
				封包_读2.读文本型(out string _, true, (byte)0, false);
			}
			P_0.超级进化事件?.Invoke(-1);
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_成功失败展示-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal byte[] lqu2iqp13H(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(12L, SeekOrigin.Begin);
			obj.读文本型(out string value, true, (byte)0, false);
			obj.读整数型(reverse: true, out var _);
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && value == "exp")
			{
				return null;
			}
			if (P_0.user.缓存数据.Is梭子刷新属性 || P_0.user.缓存数据.Is摆摊购买金钱记录 != -1)
			{
				return null;
			}
			return P_1;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_属性刷新提示-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	public 接收数据响应处理类()
	{
	}

	static 接收数据响应处理类()
	{
	}
}
