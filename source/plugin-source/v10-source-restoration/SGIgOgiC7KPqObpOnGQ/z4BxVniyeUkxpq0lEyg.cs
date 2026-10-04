using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AM5rMIgHdrOR1f8tXCQ;
using B2uVXfUco7vjsxVN2Bc;
using B6XRmUwQK7iatdTWLwc;
using CKS3DKsTBrUPphoeWmS;
using EKROCVD7DRi8Cx5mpUu;
using GJSyJYUDOfxE331QwT1;
using H0Y8GEJQx5wfb6t3alR;
using HS2GfXB7hJCX6tDXuc0;
using KEvDjBdeoLOoBKWXFAH;
using MAZG7tsAp4qxkk1uF8R;
using MGlqQ3brPEBI9uuUVKc;
using MOuTmqw7qFKlAkRNasG;
using OwjyAmRhZ9nO8Ec0bP9;
using P80h4IDRZbpvERvsoap;
using PB0xx2KvGeQt7ty6y1C;
using PJ8VymWjWDfaUUlTW62;
using R0F7EJKsPwFRj7h6amU;
using R8lTaqgbEc6MvH2j6n0;
using Serilog;
using SuTsFOBHSZNdBh5bUZB;
using UbblDNG1yFpxk6Q0ui4;
using VcF0pbBvJqp0x0IfwN;
using XWKUjNiqpjLqc4emuCT;
using YHD6B3jthayZBFfLsaY;
using YOheREbBnDq6LvvWZEr;
using aSItGBlifY3VT2BvkBH;
using aqNktcWvi5bXttp7syQ;
using eYLrotRIovAGM9lAtVf;
using gEdioZfkTLM2TXU6jgd;
using irBd2ubEj0IMVbGRstp;
using ixYEhcwWIdwrtDxOO94;
using kNOi3Vbgo4LTDja4YFk;
using mxyyZlfUTTOCu8Y4ZsN;
using na6bKIshZPRKsEOcVLd;
using q52xqsRVVwmOLlpWkb3;
using r6H7Ets2Rns31EhC17Y;
using sVcPYnW2a67ob5mDj4x;
using srBApEg0K2LqE1QaSFj;
using tMMEyfgcW4XCGjj522C;
using uI75fJjR7A2e7wWdq9f;
using vBIs2Rf2vSSk1OdhoS7;
using wcxwepjSDDAt5sUJfS8;
using xjMDbr53dgFg8eTWhG;
using xqlPMM2TJRNXpZnNDFn;
using zA970iRwZCxW0g6uljn;

namespace SGIgOgiC7KPqObpOnGQ;

internal class z4BxVniyeUkxpq0lEyg : Singleton<z4BxVniyeUkxpq0lEyg>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public int u6h71KpQRe;

		
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		
		internal bool gT57pWualt(超级NPC列表类 x)
		{
			return x.NPC数据.npcid == u6h71KpQRe;
		}

		static _003C_003Ec__DisplayClass5_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public int lq47eArPWO;

		
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		
		internal bool xNT7xueXep(MyNATSocketClient x)
		{
			return x.user.人物数据.角色ID == lq47eArPWO;
		}

		
		internal bool NB67HPPB35(MyNATSocketClient x)
		{
			return x.user.人物数据.角色ID == lq47eArPWO;
		}

		
		internal bool rPL74Q39sN(MyNATSocketClient x)
		{
			return x.user.人物数据.角色ID == lq47eArPWO;
		}

		static _003C_003Ec__DisplayClass6_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public int zsC7ZSUAQC;

		public string iQU7t7BsPB;

		
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		
		internal bool ens7qZfTy9(超级NPC列表类 x)
		{
			return x.NPC数据.npcid == zsC7ZSUAQC;
		}

		
		internal bool AQP7ruQ84r(挑战BOSS列表类 x)
		{
			return Singleton<ByteAPI>.I.寻找文本(iQU7t7BsPB, x.对话关键词);
		}

		static _003C_003Ec__DisplayClass7_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_1
	{
		public string mF07zbcykB;

		
		public _003C_003Ec__DisplayClass7_1()
		{
		}

		
		internal bool EUk7AmO2Ua(超级NPC传送类 x)
		{
			return x.地图名字 == mF07zbcykB;
		}

		static _003C_003Ec__DisplayClass7_1()
		{
		}
	}

	
	public void X56iVZIf2q(int P_0, int P_1, string P_2, short P_3, short P_4, string P_5)
	{
		if (Singleton<全局变量类>.I.所有NPC字典.TryGetValue(P_0, out var value))
		{
			if (!value.TryGetValue(P_1, out var value2))
			{
				value2 = new NPC信息类
				{
					名字 = P_2,
					ID = P_1,
					坐标X = P_3,
					坐标Y = P_4,
					所在地图 = P_5
				};
				value.TryAdd(value2.ID, value2);
			}
			else
			{
				value2.名字 = P_2;
				value2.坐标X = P_3;
				value2.坐标Y = P_4;
				value2.所在地图 = P_5;
			}
		}
	}

	
	public async Task twSikBj3hZ(int P_0, int P_1, string P_2, string P_3)
	{
		if (Singleton<全局变量类>.I.所有NPC字典.TryGetValue(P_0, out var value))
		{
			if (!value.TryGetValue(P_1, out var value2))
			{
				value2 = new NPC信息类
				{
					名字 = P_2,
					ID = P_1,
					所在地图 = P_3
				};
				value.TryAdd(value2.ID, value2);
			}
			else
			{
				value2.名字 = P_2;
				value2.所在地图 = P_3;
			}
		}
		else
		{
			await Task.Delay(0);
		}
	}

	
	public NPC信息类 jeOi0kxo6O(int P_0, int P_1)
	{
		if (Singleton<全局变量类>.I.所有NPC字典.TryGetValue(P_0, out var value))
		{
			value.TryGetValue(P_1, out var value2);
			return value2;
		}
		return null;
	}

	
	public void v2diOkGfAn(int P_0, int P_1)
	{
		if (Singleton<全局变量类>.I.所有NPC字典.TryGetValue(P_0, out var value))
		{
			value.TryRemove(P_1, out var _);
		}
	}

	
	public ConcurrentDictionary<int, NPC信息类> vbkiQt86xb(int P_0)
	{
		Singleton<全局变量类>.I.所有NPC字典.TryGetValue(P_0, out var value);
		return value;
	}

	
	internal bool Vh8iEHMoNM(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass5_0();
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return false;
			}
			if (!string.IsNullOrWhiteSpace(P_0.user.缓存数据.自选道具))
			{
				Singleton<请求数据响应处理类>.I.vXN2mciFrh(P_0);
				return false;
			}
			if (Singleton<全局变量类>.I.config.isNpc点击管控)
			{
				if (P_0.user.缓存数据.endNpc点击时间 != DateTime.MinValue && (DateTime.Now - P_0.user.缓存数据.endNpc点击时间).TotalMilliseconds < (double)Singleton<全局变量类>.I.config.管控频率)
				{
					return false;
				}
				P_0.user.缓存数据.endNpc点击时间 = DateTime.Now;
			}
			byte[] buffer = Singleton<ByteAPI>.I.取字节集右边(P_1, 4);
			CS_0024_003C_003E8__locals5.u6h71KpQRe = Singleton<ByteAPI>.I.反转_整数(buffer);
			NPC信息类 nPC信息类 = jeOi0kxo6O(P_0.插件端口, CS_0024_003C_003E8__locals5.u6h71KpQRe);
			if (nPC信息类 != null && nPC信息类.名字 == "多宝道人" && !Singleton<全局变量类>.I.config.Is允许修法 && Singleton<全局变量类>.I.验证client.授权配置.IsLGL定制)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R修法活动暂未开启！"));
				return false;
			}
			switch (CS_0024_003C_003E8__locals5.u6h71KpQRe)
			{
			case 1:
				return 全局变量类.Is调试;
			case 101:
				Singleton<BpcEfFbiGBBV3s2B0ai>.I.a3KbMq9b3m(P_0);
				return false;
			case 102:
				Singleton<FoohJvKhxbMTfceeiIF>.I.QRkK1vRkbM(P_0);
				return false;
			case 103:
				Singleton<iRGieud4qtscW6ESmxk>.I.gMQdzSPHss(P_0);
				return false;
			case 104:
				Singleton<浮生录功能>.I.KbNUOy4Ia4(P_0);
				return false;
			case 105:
				Singleton<L4IbybsayJA7RG5d8t7>.I.B89sxUWGsQ(P_0);
				return false;
			case 106:
				Singleton<t3Hr1lRCL4Z1QF9uWXP>.I.pd8RpcUfjD(P_0);
				return false;
			case 107:
				Singleton<FoINHjWh9BHxZ3BiiA5>.I.tZtWC1Sb6L(P_0);
				return false;
			case 110:
				Singleton<AZI1HsR8MjRfegmETY5>.I.aKnRf5NpSf(P_0);
				return false;
			case 111:
				Singleton<MtacAPJOeul0knZiQar>.I.QJuJeZX6Kr(P_0);
				return false;
			default:
				if (Singleton<全局变量类>.I.超级NPC配置.功能开关 && Singleton<全局变量类>.I.超级NPC配置.NPC列表.Any( (超级NPC列表类 x) => x.NPC数据.npcid == CS_0024_003C_003E8__locals5.u6h71KpQRe))
				{
					Singleton<超级NPC功能>.I.超级NPC点击对话(P_0, CS_0024_003C_003E8__locals5.u6h71KpQRe);
					return false;
				}
				return true;
			}
		}
		catch (Exception ex)
		{
			Log.Error("请求_Npc点击请求-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	public byte[] a9Vi3pVQj3(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals14 = new _003C_003Ec__DisplayClass6_0();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写 封包_写3 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out CS_0024_003C_003E8__locals14.lq47eArPWO), reverse: true);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var value), reverse: true);
			封包_写2.写字节集(封包_读2.读字节集(2, out byte[] _), hasCount: false, 0);
			string text = 封包_读2.读文本型(是否声明长度: true, 1, 是否反转长度: true);
			string zone = 封包_读2.读文本型(是否声明长度: true, 0);
			byte[] bytes = 封包_读2.读字节集(3);
			string text2 = 封包_读2.读文本型(是否声明长度: true, 0);
			if (text2 == "多宝道人" && !Singleton<全局变量类>.I.config.Is允许修法 && Singleton<全局变量类>.I.验证client.授权配置.IsLGL定制)
			{
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(CS_0024_003C_003E8__locals14.lq47eArPWO, value, text2, "#R修法活动暂未开启！"));
				return null;
			}
			if (CS_0024_003C_003E8__locals14.lq47eArPWO != 1 || CS_0024_003C_003E8__locals14.lq47eArPWO != P_0.user.人物数据.角色ID)
			{
				twSikBj3hZ(P_0.插件端口, CS_0024_003C_003E8__locals14.lq47eArPWO, text2, P_0.user.人物数据.所在地图名字);
			}
			sUhuV4s664O5VhBMqaF.N4osSqPSXX(ref text);
			if (text2 == "妙手道人")
			{
				return null;
			}
			if (CS_0024_003C_003E8__locals14.lq47eArPWO == 1 && (!全局变量类.Is调试 || P_0.当前权限 != 300))
			{
				return null;
			}
			if (text.Contains("九天十地，没有我不知道", StringComparison.CurrentCulture))
			{
				return null;
			}
			if (text.Contains("是特殊物品，丢弃后将直接销毁", StringComparison.CurrentCulture))
			{
				P_0.S_Send(Singleton<WdAPI>.I.FfBoDN31h8(P_0.user.人物数据.角色ID));
				return null;
			}
			if (fuMNpgieFTYU3Wah53.BojPVlpN4() && Singleton<ByteAPI>.I.寻找文本与(text, "装备后，#R", "开始限时计时", "你确定要装备该法宝吗"))
			{
				P_0.S_Send(Singleton<WdAPI>.I.dSCog5GPxy(P_0.user.人物数据.角色ID));
				return null;
			}
			if (text.Contains("设定加锁密码", StringComparison.CurrentCulture) || text.Contains("再次设定加锁密码", StringComparison.CurrentCulture))
			{
				return null;
			}
			if (P_0.当前权限 != 300)
			{
				if (text.Contains("GM进入赛场", StringComparison.CurrentCulture))
				{
					text = text.Replace("[我是GM，我要进入赛场/GM进入赛场]", "");
				}
				if (text2 == "试道大会申请人" && text.Contains("进入比赛场地", StringComparison.CurrentCulture))
				{
					text = Singleton<ByteAPI>.I.取文本左边(text, "[随便看看/离开]");
				}
				if (text2 == "帮派使者" && text.Contains("GM帮派地图", StringComparison.CurrentCulture))
				{
					text = text.Replace("[GM去其他帮派地图快速通道/GM帮派地图]\n", "");
				}
			}
			if (XhaJ3cfswGhhnmIequv.vI0fNpyhWg())
			{
				if (text2 == "白邦芒" || Singleton<ByteAPI>.I.寻找文本与(text, "prompt:你确定要捐助", "给天墉城的穷人吗") || Singleton<ByteAPI>.I.寻找文本与(text, "你确定要消耗", "点五雷令耐久度直接领取", "#R助人为乐#n的任务奖励") || Singleton<ByteAPI>.I.寻找文本与(text, "/领取助人为乐(", "[【提交任务】任务我已经完成了/提交任务]"))
				{
					Singleton<XhaJ3cfswGhhnmIequv>.I.uhLfomm4gK(P_0, ref text);
				}
				else if (text2 == "仙界神捕" && Singleton<ByteAPI>.I.寻找文本与(text, "很好，你出色的完成了任务", "[我要经验奖励/经验奖励]", "[我要道行奖励/道行奖励]"))
				{
					text = text.Replace("[我要经验奖励/经验奖励]", "[我要经验奖励/日常_悬赏令_经验奖励]");
					text = text.Replace("[我要道行奖励/道行奖励]", "[我要道行奖励/日常_悬赏令_道行奖励]");
				}
			}
			if (FcVoHRwOVsflDmDUQOP.JhVwZ5yCsf())
			{
				if (text2 == "玉真子" && Singleton<ByteAPI>.I.寻找文本与(text, "[带来了/$提交诱饵|可提交你喜爱的精怪诱饵，诱饵与精怪一一对应。, 1, 0]"))
				{
					text = text.Replace("[带来了/$提交诱饵|可提交你喜爱的精怪诱饵，诱饵与精怪一一对应。, 1, 0]", "[带来了/$提交诱饵|可提交你喜爱的精怪诱饵，诱饵与精怪一一对应。, 10, 0]");
				}
				else if (text2 == P_0.user.人物数据.昵称 + "召唤的精怪" && Singleton<ByteAPI>.I.寻找文本与(text, "[我要提交天技召唤卡/$提交|请提交一张#R天技召唤卡#n。,1,0]"))
				{
					text = text.Replace("[我要提交天技召唤卡/$提交|请提交一张#R天技召唤卡#n。,1,0]", string.Empty);
					text = text.Replace("[我愿接受挑战/接受挑战]", "[我愿接受挑战/召唤精怪_接受挑战]");
				}
				else if (text2 == P_0.user.人物数据.昵称 + "召唤的精怪" && Singleton<ByteAPI>.I.寻找文本与(text, "想当我的主人你还得磨练"))
				{
					P_0.召唤精怪事件 = null;
				}
			}
			if (text2 == "游方术士")
			{
				text = text.Replace("[我要管理加锁密码/管理加锁密码]", "");
				text = text.Replace("[我要设置密保与加锁使用方式/设置密保与加锁方式]", "");
				text = text.Replace("[我要对物品进行加锁、解锁/显示加解锁物品]", "");
				text = text.Replace("[我要对宠物进行加锁、解锁/显示加解锁宠物]", "");
				text = text.Replace("[我要对守护进行加锁、解锁/显示加解锁守护]", "");
				text = text.Replace("[我要对角色属性进行加锁、解锁/显示加解锁属性]", "");
				text = text.Replace("[我要进行短信验证设置/设置短信验证]", "");
			}
			if (text.Contains("宠物被绑定后，可以进行解除绑定操作", StringComparison.CurrentCulture))
			{
				text += "当前宠物不可解绑，请联系GM";
			}
			if (mQEQjEBxYW4SsAecBHJ.IOQGR6WRUK() && Singleton<ByteAPI>.I.寻找文本(text, "[【转换】转换娃娃门派/转换门派]"))
			{
				text = text.Replace("[【转换】转换娃娃门派/转换门派]", string.Empty);
			}
			if (YHfw7nGpg7WfdCBKDH4.qapfK9UWNV() && Singleton<全局变量类>.I.摆摊配置.货币类型 == AllEnums.数值Type.道具 && text2 == Singleton<全局变量类>.I.摆摊配置.存取NPC名字)
			{
				string text3 = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(68, 5);
				defaultInterpolatedStringHandler.AppendLiteral("#r#Y你的百宝囊当前存放了#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.数值存档.摆摊道具货币);
				defaultInterpolatedStringHandler.AppendLiteral("#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.道具单位);
				defaultInterpolatedStringHandler.AppendLiteral("#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
				defaultInterpolatedStringHandler.AppendLiteral("#n[【存】请帮我把背包");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
				defaultInterpolatedStringHandler.AppendLiteral("存进百宝囊/摆摊系统_存][【取】请帮我取出百宝囊存放的");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.摆摊配置.货币道具);
				defaultInterpolatedStringHandler.AppendLiteral("/摆摊系统_取]");
				text = text3 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (Singleton<全局变量类>.I.通天塔突破配置.功能开关 && text2 == "北斗星使")
			{
				text = text.Replace("[删除任务/GM删任务]", string.Empty);
				text = text.Replace("[【领奖】领取通天塔突破奖励/领取通天塔突破奖励]", string.Empty);
				if (text.Contains("进塔修炼", StringComparison.CurrentCulture))
				{
					text += "[【领取】领取通天塔突破奖励/领取通天塔突破奖励]";
				}
			}
			if (Singleton<全局变量类>.I.门派转换配置.功能开关 && text2 == "逍遥仙")
			{
				text += "[【转换】我要进行门派转换/门派转换操作_门派转换]";
			}
			if (Singleton<全局变量类>.I.燃眉配置.功能开关 && text2 == "五行竞猜使")
			{
				text = "[【燃眉之急】领取任务/燃眉操作_领取讨债任务]";
			}
			if (Singleton<全局变量类>.I.燃眉配置.功能开关 && !string.IsNullOrWhiteSpace(P_0.user.存档数据.燃眉之急任务.当前NPC) && P_0.user.存档数据.燃眉之急任务.当前NPC == text2)
			{
				text += "[【燃眉之急】把身上值钱的都交出来/燃眉操作_完成讨债任务]";
				P_0.user.存档数据.燃眉之急任务.当前NPC形象ID = value;
				P_0.user.存档数据.燃眉之急任务.当前NPCID = CS_0024_003C_003E8__locals14.lq47eArPWO;
			}
			if (Singleton<全局变量类>.I.南极配置.功能开关 && text2 == "南极仙翁")
			{
				text += "[我要进行充值送奖励抽奖/南极抽取奖励_小额]";
				if (Singleton<全局变量类>.I.南极配置.is开启大额)
				{
					text += "[我要进行大额充值奖励抽奖/南极抽取奖励_大额]";
				}
			}
			if (text2 == "活动大使" && text.Contains("等有活动再来", StringComparison.CurrentCulture))
			{
				if (Singleton<全局变量类>.I.融丹配置.功能开关)
				{
					text += "[【独家熔炼仙丹】/荣丹请求_熔炼_打开]";
				}
				if (Singleton<全局变量类>.I.推荐拉人配置.功能开关 && P_0.user.存档数据.推荐拉人数据.推荐人GID == 0)
				{
					text += "[【填写】我的推荐人/推荐拉人操作_推荐人填写]";
				}
				if (Singleton<全局变量类>.I.config.is乾坤袋 && !P_0.user.存档数据.乾坤袋列表.IsEmpty)
				{
					text += "[【乾坤袋】领取物品/乾坤袋_领取物品]";
				}
				if (Singleton<全局变量类>.I.config.is相性加点 && P_0.user.属性数据.等级 >= Singleton<全局变量类>.I.config.加点最低等级 && P_0.user.属性数据.剩余相性 > 0 && P_0.user.属性数据.相性丹药 > 50)
				{
					text += "[【加点】金相性/金相性_加点][【加点】木相性/木相性_加点][【加点】水相性/水相性_加点][【加点】火相性/火相性_加点][【加点】土相性/土相性_加点]";
				}
			}
			if (Singleton<全局变量类>.I.config.is悟道转换 && text.Contains("提交#R3#n颗#R修为丹#n", StringComparison.CurrentCulture))
			{
				WdAPI i = Singleton<WdAPI>.I;
				int 角色ID = P_0.user.人物数据.角色ID;
				int 形象ID = P_0.user.人物数据.形象ID;
				string nPC名称 = "悟道天尊";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 2);
				defaultInterpolatedStringHandler.AppendLiteral("花费");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.config.悟道转换消耗));
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.悟道转换消耗类型);
				defaultInterpolatedStringHandler.AppendLiteral("可以兑换#R1#n次转换次数。[【转换】确定转换悟道属性/悟道操作_确定]");
				P_0.C_Send(i.对话生成_NPC(角色ID, 形象ID, nPC名称, defaultInterpolatedStringHandler.ToStringAndClear()));
				return null;
			}
			if (MbtVicwUkp5LuxTooFW.c5PwXOYtHf() && text2 == Singleton<全局变量类>.I.六道轮回配置.npc名字)
			{
				Singleton<全局变量类>.I.六道轮回配置.npc形象 = value;
				text = text + "[" + Singleton<全局变量类>.I.六道轮回配置.首级对话选项 + "/轮回操作_打开]";
			}
			if (Singleton<全局变量类>.I.一键大飞配置.功能开关 && text2 == Singleton<全局变量类>.I.一键大飞配置.npc名字 && P_0.user.属性数据.等级 >= Singleton<全局变量类>.I.一键大飞配置.飞升要求最低等级 && P_0.user.属性数据.等级 < Singleton<全局变量类>.I.一键大飞配置.飞升到等级)
			{
				string text4 = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 4);
				defaultInterpolatedStringHandler.AppendLiteral("[【大飞】一键飞升·仙（");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.一键大飞配置.消耗数值);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.一键大飞配置.消耗数值类型);
				defaultInterpolatedStringHandler.AppendLiteral("）/大飞操作_仙][【大飞】一键飞升·魔（");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.一键大飞配置.消耗数值);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.一键大飞配置.消耗数值类型);
				defaultInterpolatedStringHandler.AppendLiteral("）/大飞操作_魔]");
				text = text4 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (Singleton<全局变量类>.I.法宝共生配置.元神合体开关 && text2 == Singleton<全局变量类>.I.法宝共生配置.元神合体npc名字 && !P_0.user.存档数据.Is元神合体)
			{
				string text5 = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[【开通】元神合体之术（");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值类型);
				defaultInterpolatedStringHandler.AppendLiteral("）/元神合体_选中]");
				text = text5 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (Singleton<全局变量类>.I.法宝共生配置.功能开关 && text2 == Singleton<全局变量类>.I.法宝共生配置.npc名字 && !P_0.user.人物数据.is法宝共生)
			{
				string text6 = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[【开通】法宝共生之术（");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.法宝共生配置.消耗数值);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.法宝共生配置.消耗数值类型);
				defaultInterpolatedStringHandler.AppendLiteral("）/共生操作_选中]");
				text = text6 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (yuKf6DUSQGygKeLSQdj.uf8U9RfBer())
			{
				Singleton<yuKf6DUSQGygKeLSQdj>.I.rpxUvjkqND(P_0, CS_0024_003C_003E8__locals14.lq47eArPWO, 0);
				int result3;
				if (Singleton<ByteAPI>.I.寻找文本与(text, "休说废话，妖孽受死吧（#R", "#n级）/"))
				{
					if (!Singleton<全局变量类>.I.会话Dict.Values.Any( (MyNATSocketClient x) => x.user.人物数据.角色ID == CS_0024_003C_003E8__locals14.lq47eArPWO) && int.TryParse(Singleton<ByteAPI>.I.取文本中间(text, "休说废话，妖孽受死吧（#R", "#n级）/"), out var result))
					{
						Singleton<yuKf6DUSQGygKeLSQdj>.I.rpxUvjkqND(P_0, CS_0024_003C_003E8__locals14.lq47eArPWO, result);
					}
				}
				else if (Singleton<ByteAPI>.I.寻找文本与(text, "今天我要为民除害（妖王等级", "级）"))
				{
					if (!Singleton<全局变量类>.I.会话Dict.Values.Any( (MyNATSocketClient x) => x.user.人物数据.角色ID == CS_0024_003C_003E8__locals14.lq47eArPWO) && int.TryParse(Singleton<ByteAPI>.I.取文本中间(text, "今天我要为民除害（妖王等级", "级）"), out var result2))
					{
						Singleton<yuKf6DUSQGygKeLSQdj>.I.rpxUvjkqND(P_0, CS_0024_003C_003E8__locals14.lq47eArPWO, result2);
					}
				}
				else if (Singleton<ByteAPI>.I.寻找文本与(text, "我是来向你挑战的（星官等级", "级）") && !Singleton<全局变量类>.I.会话Dict.Values.Any( (MyNATSocketClient x) => x.user.人物数据.角色ID == CS_0024_003C_003E8__locals14.lq47eArPWO) && int.TryParse(Singleton<ByteAPI>.I.取文本中间(text, "我是来向你挑战的（星官等级", "级）"), out result3))
				{
					Singleton<yuKf6DUSQGygKeLSQdj>.I.rpxUvjkqND(P_0, CS_0024_003C_003E8__locals14.lq47eArPWO, result3);
				}
			}
			if (Singleton<全局变量类>.I.挑战BOSS配置.功能开关)
			{
				string empty = string.Empty;
				empty = (Singleton<ByteAPI>.I.寻找文本("|天魁星|天魔星|天机星|天闲星|天勇星|天雄星|天猛星|天威星|天英星|天贵星|天富星|天满星|天孤星|天伤星|天立星|天捷星|天暗星|天祐星|天空星|天速星|天异星|天杀星|天微星|天究星|天退星|天寿星|天剑星|天平星|天罪星|天损星|天败星|天牢星|天慧星|天暴星|天哭星|天巧星|", "|" + text2 + "|") ? "天星" : ((!Singleton<ByteAPI>.I.寻找文本("|地魁星|地煞星|地勇星|地杰星|地雄星|地威星|地英星|地奇星|地猛星|地文星|地正星|地辟星|地阖星|地强星|地暗星|地轴星|地会星|地佐星|地佑星|地灵星|地兽星|地微星|地慧星|地暴星|地默星|地猖星|地狂星|地飞星|地走星|地巧星|地明星|地进星|地退星|地满星|地遂星|地周星|地隐星|地异星|地理星|地俊星|地乐星|地捷星|地速星|地镇星|地稽星|地魔星|地妖星|地幽星|地伏星|地僻星|地空星|地孤星|地全星|地短星|地角星|地囚星|地藏星|地平星|地损星|地奴星|地察星|地恶星|地丑星|地数星|地阴星|地刑星|地壮星|地劣星|地健星|地耗星|地贼星|地狗星|", "|" + text2 + "|")) ? text2 : "地星"));
				if (Singleton<全局变量类>.I.挑战BOSS配置.挑战boss列表.TryGetValue(empty, out 挑战BOSS列表类 value3))
				{
					if (text.Contains("急什么", StringComparison.CurrentCulture))
					{
						Singleton<FBGRmlstyRWQdqi0pHa>.I.XyyUWS3eEO(P_0, value3);
						return P_1;
					}
					text += Singleton<FBGRmlstyRWQdqi0pHa>.I.qaqUJO1GZF(P_0, empty, text, value3);
				}
			}
			if (Singleton<全局变量类>.I.守护配置.功能开关 && text2 == Singleton<全局变量类>.I.守护配置.NPC名字)
			{
				string text7 = text;
				string text8 = "[【召唤】强力守护";
				string text9;
				if (Singleton<全局变量类>.I.守护配置.消耗数量 <= 0)
				{
					text9 = string.Empty;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
					defaultInterpolatedStringHandler.AppendLiteral("(");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.守护配置.消耗数量);
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.守护配置.消耗类型);
					defaultInterpolatedStringHandler.AppendLiteral(")");
					text9 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				text = text7 + text8 + text9 + "/强力守护_召唤]";
			}
			封包_写2.写文本型(text, hasCount: true, 1, reverse: true);
			封包_写2.写文本型(zone, hasCount: true, 0);
			封包_写2.写字节集(bytes, hasCount: false, 0);
			封包_写2.写文本型(text2, hasCount: true, 0);
			封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return 封包_写3.取数据();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_组合NPC对话-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return null;
		}
	}

	
	internal byte[] YUAiYp4QDE(MyNATSocketClient P_0, byte[] P_1, byte[] P_2)
	{
		try
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals203 = new _003C_003Ec__DisplayClass7_0();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out CS_0024_003C_003E8__locals203.zsC7ZSUAQC), reverse: true);
			CS_0024_003C_003E8__locals203.iQU7t7BsPB = 封包_读2.读文本型(是否声明长度: true, 0);
			string text = 封包_读2.读文本型(是否声明长度: true, 0);
			P_0.user.缓存数据.cdk类型 = AllEnums.CdkType.无;
			NPC信息类 nPC信息类 = jeOi0kxo6O(P_0.插件端口, CS_0024_003C_003E8__locals203.zsC7ZSUAQC);
			if (!全局变量类.Is调试 && CS_0024_003C_003E8__locals203.zsC7ZSUAQC == 1)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 3);
				defaultInterpolatedStringHandler.AppendLiteral("[账号：");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral("][角色：");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("][内容=");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals203.iQU7t7BsPB);
				defaultInterpolatedStringHandler.AppendLiteral("][理由：刷GM]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return null;
			}
			if (sUhuV4s664O5VhBMqaF.AaGscRm47i(CS_0024_003C_003E8__locals203.iQU7t7BsPB, (nPC信息类 == null) ? string.Empty : nPC信息类.名字))
			{
				return null;
			}
			if (!M9si158vHe(P_0, nPC信息类, CS_0024_003C_003E8__locals203.zsC7ZSUAQC))
			{
				return null;
			}
			if (nPC信息类 != null && Singleton<ByteAPI>.I.寻找文本等(nPC信息类.名字, "杨镖头", "陈镖头") && Singleton<ByteAPI>.I.寻找文本等(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "开始押送"))
			{
				lock (P_0.对话点击锁)
				{
					if (P_0.user.缓存数据.endNpc点击时间 != DateTime.MinValue && (DateTime.Now - P_0.user.缓存数据.endNpc点击时间).TotalMilliseconds < 1000.0)
					{
						return null;
					}
				}
				P_0.user.缓存数据.endNpc点击时间 = DateTime.Now;
			}
			if (CS_0024_003C_003E8__locals203.zsC7ZSUAQC == P_0.user.人物数据.角色ID && (CS_0024_003C_003E8__locals203.iQU7t7BsPB == "金元宝修为" || CS_0024_003C_003E8__locals203.iQU7t7BsPB == "银元宝修为") && sUhuV4s664O5VhBMqaF.wo7snB1Lah() && Singleton<全局变量类>.I.怀旧专区配置.悟道_加号按钮)
			{
				return null;
			}
			if (CS_0024_003C_003E8__locals203.iQU7t7BsPB == "时辰确定")
			{
				return null;
			}
			if (CS_0024_003C_003E8__locals203.iQU7t7BsPB == "确定无效")
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("认主无效，只能进行绑定操作！"));
				return null;
			}
			if (CS_0024_003C_003E8__locals203.iQU7t7BsPB == "战斗指令_逃跑确定")
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R退出战斗#n指令已经下达，等待本回合结束。"));
				Singleton<WdAPI>.I.EOYImZQJeG(P_0, true);
				P_0.S_Send(Singleton<WdAPI>.I.zXxoPwQcb0(P_0.user.人物数据.昵称));
				return null;
			}
			if (CS_0024_003C_003E8__locals203.iQU7t7BsPB == "!输入新姓名" && Singleton<WdAPI>.I.玩家昵称违规(text))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("输入有误，请勿输入敏感词！"));
				return null;
			}
			if (Singleton<全局变量类>.I.道具宠物回收配置.is禁止绑定宠物道具找回 && CS_0024_003C_003E8__locals203.iQU7t7BsPB == "找回物品或者宠物")
			{
				return null;
			}
			if (CS_0024_003C_003E8__locals203.iQU7t7BsPB == "设定密码" || CS_0024_003C_003E8__locals203.iQU7t7BsPB == "管理加锁密码" || CS_0024_003C_003E8__locals203.iQU7t7BsPB == "设置密保与加锁方式" || CS_0024_003C_003E8__locals203.iQU7t7BsPB == "显示加解锁物品" || CS_0024_003C_003E8__locals203.iQU7t7BsPB == "显示加解锁宠物" || CS_0024_003C_003E8__locals203.iQU7t7BsPB == "显示加解锁守护" || CS_0024_003C_003E8__locals203.iQU7t7BsPB == "显示加解锁属性" || CS_0024_003C_003E8__locals203.iQU7t7BsPB == "设置短信验证")
			{
				return null;
			}
			if (nPC信息类 != null)
			{
				P_0.user.缓存数据.当前点击NPC名字 = nPC信息类.名字;
			}
			if (!TimedDungeonService.I.BeforeEntry(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, nPC信息类?.名字 ?? P_0.user.缓存数据.当前点击NPC名字))
			{
				return null;
			}
			if (Singleton<全局变量类>.I.config.is通天塔管控 && CS_0024_003C_003E8__locals203.zsC7ZSUAQC == Singleton<全局变量类>.I.NPC_北斗星使 && CS_0024_003C_003E8__locals203.iQU7t7BsPB == "确认进塔")
			{
				if (P_0.user.存档数据.已打通天塔次数 >= Singleton<全局变量类>.I.config.通天塔次数 + P_0.user.存档数据.通天塔额外次数)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("修心悟道切莫操之过急，还请养精蓄锐，明日再来吧！"));
					return null;
				}
				P_0.user.存档数据.已打通天塔次数++;
			}
			if (XhaJ3cfswGhhnmIequv.vI0fNpyhWg() && Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "日常_"))
			{
				Singleton<XhaJ3cfswGhhnmIequv>.I.cWVfIV9m1C(P_0, ref CS_0024_003C_003E8__locals203.iQU7t7BsPB);
			}
			if (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "$提交诱饵"))
			{
				if (P_0.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				Singleton<FcVoHRwOVsflDmDUQOP>.I.NOAwxkWxnf(P_0, ref CS_0024_003C_003E8__locals203.iQU7t7BsPB, ref text);
			}
			if (FcVoHRwOVsflDmDUQOP.JhVwZ5yCsf() && Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "召唤精怪_"))
			{
				if (P_0.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!(CS_0024_003C_003E8__locals203.iQU7t7BsPB == "召唤精怪_接受挑战"))
				{
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<FcVoHRwOVsflDmDUQOP>.I.XyAweo0Afy(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				CS_0024_003C_003E8__locals203.iQU7t7BsPB = CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("召唤精怪_接受挑战", "接受挑战");
				Singleton<FcVoHRwOVsflDmDUQOP>.I.wH8wqOhv93(P_0);
			}
			else
			{
				if (CS_0024_003C_003E8__locals203.zsC7ZSUAQC == P_0.user.人物数据.角色ID && Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "天降石提交_"))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<zeYnwTjKgpmAbfSQh5J>.I.PTOjNchOoX(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, text);
					return null;
				}
				if (CS_0024_003C_003E8__locals203.zsC7ZSUAQC == P_0.user.人物数据.角色ID && Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "法宝亲密互换石提交_"))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<zeYnwTjKgpmAbfSQh5J>.I.bZHjipKmG4(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, text);
					return null;
				}
				if (CS_0024_003C_003E8__locals203.zsC7ZSUAQC == P_0.user.人物数据.角色ID && Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "装备男女转换玉提交_"))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<zeYnwTjKgpmAbfSQh5J>.I.rAbjBACuq5(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, text);
					return null;
				}
				if (CS_0024_003C_003E8__locals203.zsC7ZSUAQC == P_0.user.人物数据.角色ID && Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "武学互换丹提交_"))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<zeYnwTjKgpmAbfSQh5J>.I.EOPjfQe87D(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (CS_0024_003C_003E8__locals203.zsC7ZSUAQC == P_0.user.人物数据.角色ID && Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "宠物亲密互换丹提交_"))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<zeYnwTjKgpmAbfSQh5J>.I.qG9j2skJv4(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (CS_0024_003C_003E8__locals203.zsC7ZSUAQC == P_0.user.人物数据.角色ID && mQEQjEBxYW4SsAecBHJ.IOQGR6WRUK() && Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "娃娃系统_"))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<mQEQjEBxYW4SsAecBHJ>.I.fQRGJmw5kf(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (YHfw7nGpg7WfdCBKDH4.qapfK9UWNV() && Singleton<全局变量类>.I.摆摊配置.货币类型 == AllEnums.数值Type.道具 && Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "摆摊系统_"))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<YHfw7nGpg7WfdCBKDH4>.I.kcefJg8xS4(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (Singleton<全局变量类>.I.config.is相性加点 && CS_0024_003C_003E8__locals203.zsC7ZSUAQC == Singleton<全局变量类>.I.NPC_活动大使 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("相性_加点", StringComparison.CurrentCulture))
				{
					Singleton<WdAPI>.I.Omcocp8jd5(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, text);
					return null;
				}
				if (CS_0024_003C_003E8__locals203.zsC7ZSUAQC == P_0.user.人物数据.角色ID && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("属性找回操作", StringComparison.CurrentCulture))
				{
					Singleton<KU0aMobWe16QEEmpLCj>.I.iPIbNC4UnR(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("属性找回操作", ""));
					return null;
				}
				if (Singleton<全局变量类>.I.自选道具配置.功能开关 && CS_0024_003C_003E8__locals203.zsC7ZSUAQC == P_0.user.人物数据.角色ID && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("确定自选_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					Singleton<RdU9KHgkxD6vGY8ZRKE>.I.pPrgpZASFj(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (Singleton<全局变量类>.I.通天塔突破配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("领取通天塔突破奖励", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					Singleton<KB0ManjLR9N2YNMntee>.I.E0ejhchPa1(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (CS_0024_003C_003E8__locals203.zsC7ZSUAQC == 100 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("小助手_", StringComparison.CurrentCulture))
				{
					Singleton<Xh4EKmRML8L7x53wDHM>.I.YqYRvRZH8x(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
			}
			if (Singleton<全局变量类>.I.config.is悟道转换 && CS_0024_003C_003E8__locals203.iQU7t7BsPB == "$提交道具" && text.Contains("money:0", StringComparison.CurrentCulture))
			{
				if (P_0.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (Singleton<pHYsMfsMDubZLMGsWi3>.I.leXs7LK1TY(P_0, text.Replace("money:0,", string.Empty)))
				{
					return null;
				}
			}
			else
			{
				if (Singleton<全局变量类>.I.config.is乾坤袋 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("乾坤袋_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<HCrxJFnoveWsmxYAyd>.I.ow5MV1MwL(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (Singleton<全局变量类>.I.南极配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("南极抽取奖励_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<OxtnHXwv6N41rhEtfdc>.I.L09w0kkdIi(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if ((Singleton<全局变量类>.I.config.is轮转玉 || Singleton<全局变量类>.I.config.is超级轮转玉) && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("使用轮转玉_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<zeYnwTjKgpmAbfSQh5J>.I.请求_轮转玉事件处理(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (Singleton<全局变量类>.I.config.is超级天星石 && CS_0024_003C_003E8__locals203.zsC7ZSUAQC == P_0.user.人物数据.角色ID && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("使用超级天星石_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<RdU9KHgkxD6vGY8ZRKE>.I.nK0g1fBaXx(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (Singleton<全局变量类>.I.门派转换配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("门派转换操作_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<DB9OkbjZMmmdyW1KQMk>.I.jNflIqBHyk(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (CS_0024_003C_003E8__locals203.zsC7ZSUAQC == 102 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("宠物操作_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<FoohJvKhxbMTfceeiIF>.I.SEGKxwec5N(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, text);
					return null;
				}
				if (CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("转生操作_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					Singleton<AZI1HsR8MjRfegmETY5>.I.bWjR6H4yeP(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, text);
					return null;
				}
				if ((Singleton<全局变量类>.I.燃眉配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("燃眉操作_", StringComparison.CurrentCulture)) || (CS_0024_003C_003E8__locals203.iQU7t7BsPB == "DEFAULT" && P_0.user.缓存数据.燃煤计数器 > 0 && !string.IsNullOrWhiteSpace(P_0.user.存档数据.燃眉之急任务.当前NPC)))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<lrYK0bWD4sTSDkaJic1>.I.E90WiBs8DV(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (U8hGTORuviqLJbXPJ0Y.n3VRDqR2M4() && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("宠物突破_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					Singleton<U8hGTORuviqLJbXPJ0Y>.I.ujxRskI3P4(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("宠物突破_", string.Empty));
					return null;
				}
				if (Singleton<全局变量类>.I.config.is悟道转换 && CS_0024_003C_003E8__locals203.iQU7t7BsPB == "悟道操作_确定")
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					Singleton<pHYsMfsMDubZLMGsWi3>.I.dlXsvFbU82(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (Singleton<全局变量类>.I.一键大飞配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("大飞操作_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<DB9OkbjZMmmdyW1KQMk>.I.BZvlj8oDVj(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (Singleton<全局变量类>.I.法宝共生配置.元神合体开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("元神合体_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<DB9OkbjZMmmdyW1KQMk>.I.Abnl8QO9nH(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (Singleton<全局变量类>.I.法宝共生配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("共生操作_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!P_0.user.人物数据.is法宝共生)
					{
						Singleton<DB9OkbjZMmmdyW1KQMk>.I.ncbllV8KTo(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					}
					return null;
				}
				if (MbtVicwUkp5LuxTooFW.c5PwXOYtHf() && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("轮回操作_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<MbtVicwUkp5LuxTooFW>.I.fsdw8chBuX(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (iRGieud4qtscW6ESmxk.wGmslE7YU3() && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("异兽录操作_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<iRGieud4qtscW6ESmxk>.I.JUesuc12a3(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("指定会员操作_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						Singleton<L4IbybsayJA7RG5d8t7>.I.UtXseqbdnV(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					}
					return null;
				}
				if (Singleton<全局变量类>.I.圣无双配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("圣无双操作_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<BpcEfFbiGBBV3s2B0ai>.I.qmbb5HS1Ea(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (Singleton<全局变量类>.I.推荐拉人配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("推荐拉人操作_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<EfHAVFUgqrnaj1QwnLW>.I.XB6UNvxshS(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (Singleton<全局变量类>.I.推荐拉人配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("拉人_领取推荐", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<EfHAVFUgqrnaj1QwnLW>.I.zKSUiidHmj(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (浮生录功能.GrAWb1KahR() && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("浮生录_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<浮生录功能>.I.h9ZUYpIPHs(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, text);
					return null;
				}
				if (Singleton<全局变量类>.I.属性洗炼配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("属性洗炼_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<t3Hr1lRCL4Z1QF9uWXP>.I.TxnR1t8SK0(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, text);
					return null;
				}
				if (Singleton<全局变量类>.I.百炼功能配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("百炼功能_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<FoINHjWh9BHxZ3BiiA5>.I.f6LWVyVBWX(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, text);
					return null;
				}
				if (MtacAPJOeul0knZiQar.N8mJACclNW() && CS_0024_003C_003E8__locals203.iQU7t7BsPB.StartsWith("天机神算_"))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					long num = Singleton<ByteAPI>.I.取时间戳(是否到秒: false);
					if (P_0.user.缓存数据.神算请求时间 != 0L && Math.Abs(num - P_0.user.缓存数据.神算请求时间) < 500)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 5);
						defaultInterpolatedStringHandler.AppendLiteral("【错误-天机神算】非正常点击频率抽奖【昵称：");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("】【id：");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.角色ID);
						defaultInterpolatedStringHandler.AppendLiteral("】【请求时间间隔：");
						defaultInterpolatedStringHandler.AppendFormatted(Math.Abs(num - P_0.user.缓存数据.神算请求时间));
						defaultInterpolatedStringHandler.AppendLiteral("（");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.缓存数据.神算请求时间);
						defaultInterpolatedStringHandler.AppendLiteral("/");
						defaultInterpolatedStringHandler.AppendFormatted(num);
						defaultInterpolatedStringHandler.AppendLiteral("）】");
						Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
						return null;
					}
					P_0.user.缓存数据.神算请求时间 = num;
					Singleton<MtacAPJOeul0knZiQar>.I.MuyJqGvCba(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (Singleton<全局变量类>.I.签到配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("签到领取_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<p63Ra5gwg6vJ45gPiim>.I.gxFgWodoAU(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (Singleton<全局变量类>.I.在线抽奖配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("在线抽奖_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (int.TryParse(CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("在线抽奖_", ""), out var result))
					{
						Singleton<cGiRplbQfaJV9guWDIS>.I.RptbHtQJgI(P_0, result).Wait();
					}
					return null;
				}
				if (Singleton<全局变量类>.I.奇宝斋配置.功能开关 && Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "奇宝斋_"))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!svsUCqKdlsQkBBIo3St.I5CKPFClWO())
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					if (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "奇宝斋_余额支付_"))
					{
						Singleton<svsUCqKdlsQkBBIo3St>.I.YZZKB0B5B2(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("奇宝斋_余额支付_", ""));
					}
					else if (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "奇宝斋_取回_"))
					{
						Singleton<svsUCqKdlsQkBBIo3St>.I.vH4K6MJKYe(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("奇宝斋_取回_", ""));
					}
					else if (xH3TPsiexTnpJAMMnJm.clyBlug2Xa())
					{
						if (CS_0024_003C_003E8__locals203.iQU7t7BsPB == "奇宝斋_奇宝点充值")
						{
							WdAPI i = Singleton<WdAPI>.I;
							string 执行关键词 = "!^奇宝斋_奇宝点充值";
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
							defaultInterpolatedStringHandler.AppendLiteral("奇宝点充值比例 1=");
							defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.奇宝斋配置.奇宝点比例);
							defaultInterpolatedStringHandler.AppendLiteral("#r请输入你要充值的金额：");
							P_0.C_Send(i.组包输入数字框(P_0, 执行关键词, defaultInterpolatedStringHandler.ToStringAndClear(), 9999));
						}
						else if (CS_0024_003C_003E8__locals203.iQU7t7BsPB == "!^奇宝斋_奇宝点充值")
						{
							Singleton<svsUCqKdlsQkBBIo3St>.I.HRTK2EpS3M(P_0, text);
						}
						else if (Singleton<ByteAPI>.I.寻找文本或(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "奇宝斋_奇宝点充值_alipay_", "奇宝斋_奇宝点充值_wxpay_", "奇宝斋_奇宝点充值_qqpay_"))
						{
							Singleton<svsUCqKdlsQkBBIo3St>.I.QjLKmHRcZw(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
						}
						else if (Singleton<ByteAPI>.I.寻找文本或(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "奇宝斋_alipay_", "奇宝斋_wxpay_", "奇宝斋_qqpay_"))
						{
							AllEnums.支付类型 支付类型 = AllEnums.支付类型.无;
							string text2 = string.Empty;
							if (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "奇宝斋_alipay_"))
							{
								text2 = CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("奇宝斋_alipay_", "");
								支付类型 = AllEnums.支付类型.alipay;
							}
							else if (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "奇宝斋_wxpay_"))
							{
								text2 = CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("奇宝斋_wxpay_", "");
								支付类型 = AllEnums.支付类型.wxpay;
							}
							else if (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "奇宝斋_qqpay_"))
							{
								text2 = CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("奇宝斋_qqpay_", "");
								支付类型 = AllEnums.支付类型.qqpay;
							}
							Singleton<svsUCqKdlsQkBBIo3St>.I.X5gKGaHAv6(P_0, text2, 支付类型);
						}
					}
					return null;
				}
				if (CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("首饰系统_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					if (!全局变量类.Is调试 && !Singleton<全局变量类>.I.验证client.授权配置.IsVip)
					{
						return null;
					}
					if (Singleton<全局变量类>.I.首饰系统配置.首饰强化开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("首饰系统_强化操作_", StringComparison.CurrentCulture))
					{
						Singleton<cCs7kYlNIp7pmjCmEml>.I.xQulSxS09g(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("首饰系统_强化操作_", string.Empty));
						return null;
					}
					if (Singleton<全局变量类>.I.首饰系统配置.首饰降级开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("首饰系统_降级操作_", StringComparison.CurrentCulture))
					{
						Singleton<cCs7kYlNIp7pmjCmEml>.I.A6JlcWaPrH(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("首饰系统_降级操作_", string.Empty));
						return null;
					}
					return null;
				}
				if (CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("装备系统_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<pN4kvFDKqDQRQBnO8BW>.I.CfiD8OL64b(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, text);
					return null;
				}
				if (CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("装备强化_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<rZ9xAdgxKYQQZPeE8Rm>.I.RixgtWR3tr(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, text);
					return null;
				}
				if (TOqsYfW68LIGjCtAgK8.AlyW5lfYvE() && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("特效鉴定_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<TOqsYfW68LIGjCtAgK8>.I.KdnWnB845U(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("特效鉴定_", string.Empty), text);
					return null;
				}
				if ((Singleton<全局变量类>.I.验证client.授权配置.IsVip || 全局变量类.Is调试) && Singleton<全局变量类>.I.融丹配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("荣丹请求_熔炼_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<APqDp4bq1ecVdMifnI1>.I.ACsJsluSp7(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
				if (Singleton<全局变量类>.I.守护配置.功能开关 && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("强力守护_召唤", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					Singleton<LaobQfgSrA1tYPe60GA>.I.aoHgvy8aML(P_0);
					return null;
				}
				if (mDs6hiBvFvG3CRi3MZk.ecqBQD9Cis() && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("地府操作_", StringComparison.CurrentCulture))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					Singleton<mDs6hiBvFvG3CRi3MZk>.I.n6qBOuNONA(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					return null;
				}
			}
			if (Singleton<ByteAPI>.I.寻找文本或(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "传送(", "前往", "送我去") || Singleton<ByteAPI>.I.寻找文本等(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "捕鱼活动") || Singleton<Rfq62uDvr7Ur9Lpyctd>.I.mTRDCi5Wu2(CS_0024_003C_003E8__locals203.iQU7t7BsPB))
			{
				_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals202 = new _003C_003Ec__DisplayClass7_1();
				if (P_0.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				超级NPC列表类 超级NPC列表类2 = Singleton<全局变量类>.I.超级NPC配置.NPC列表.Find( (超级NPC列表类 x) => x.NPC数据.npcid == CS_0024_003C_003E8__locals203.zsC7ZSUAQC);
				CS_0024_003C_003E8__locals202.mF07zbcykB = string.Empty;
				if (CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("传送(", StringComparison.CurrentCulture))
				{
					CS_0024_003C_003E8__locals202.mF07zbcykB = Singleton<ByteAPI>.I.文本_取出中间文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "传送(", ")");
				}
				else if (CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("前往", StringComparison.CurrentCulture))
				{
					CS_0024_003C_003E8__locals202.mF07zbcykB = CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("前往", "");
				}
				else if (CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("送我去", StringComparison.CurrentCulture))
				{
					CS_0024_003C_003E8__locals202.mF07zbcykB = Singleton<ByteAPI>.I.文本_取出中间文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "送我去", "(");
				}
				if (string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals202.mF07zbcykB))
				{
					return P_1;
				}
				if (Singleton<全局变量类>.I.指定会员配置.功能开关 && Singleton<全局变量类>.I.指定会员配置.指定地图 == CS_0024_003C_003E8__locals202.mF07zbcykB)
				{
					Singleton<L4IbybsayJA7RG5d8t7>.I.C61srHS1Yx(P_0);
					return null;
				}
				if (P_0.user.人物数据.所在地图名字 == Singleton<全局变量类>.I.圣无双配置.地图名字 && CS_0024_003C_003E8__locals202.mF07zbcykB == "天墉城")
				{
					if (Singleton<BpcEfFbiGBBV3s2B0ai>.I.zCybkJu0wB == AllEnums.圣无双Type.进行时 && P_0.user.存档数据.无双圣榜数据.is报名)
					{
						P_0.user.存档数据.无双圣榜数据.当前积分 = 0;
						P_0.user.存档数据.无双圣榜数据.is报名 = false;
						P_0.user.存档数据.无双圣榜数据.淘汰时间 = 0;
					}
					Singleton<WdAPI>.I.地图传送事件(P_0, "/gs/zone/tianyongcheng/tianyongcheng.c");
					return null;
				}
				if (CS_0024_003C_003E8__locals202.mF07zbcykB == Singleton<全局变量类>.I.圣无双配置.地图名字)
				{
					Singleton<BpcEfFbiGBBV3s2B0ai>.I.g5DbvWpAhY(P_0);
					return null;
				}
				if (Singleton<全局变量类>.I.超级地图配置.功能开关 && Singleton<全局变量类>.I.超级地图配置.地图列表.TryGetValue(CS_0024_003C_003E8__locals202.mF07zbcykB, out 地图限制列表类 value) && !Singleton<Rfq62uDvr7Ur9Lpyctd>.I.iV4DVGrwZy(P_0, value, 超级NPC列表类2))
				{
					return null;
				}
				if (超级NPC列表类2 != null)
				{
					超级NPC传送类 超级NPC传送类2 = 超级NPC列表类2.地图列表.Find( (超级NPC传送类 x) => x.地图名字 == CS_0024_003C_003E8__locals202.mF07zbcykB);
					if (超级NPC传送类2 != null)
					{
						Singleton<WdAPI>.I.地图传送事件(P_0, CS_0024_003C_003E8__locals202.mF07zbcykB, 超级NPC传送类2.X坐标, 超级NPC传送类2.Y坐标);
					}
					return null;
				}
			}
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && CS_0024_003C_003E8__locals203.iQU7t7BsPB.Contains("元神系统_", StringComparison.CurrentCulture))
			{
				if (P_0.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
				{
					return null;
				}
				Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.OWg2eJvbFP(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, text);
				return null;
			}
			if (xH3TPsiexTnpJAMMnJm.clyBlug2Xa())
			{
				if (CS_0024_003C_003E8__locals203.iQU7t7BsPB == "扫码支付_取消支付")
				{
					P_0.user.缓存数据.支付数据.支付中 = false;
					return null;
				}
				if (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "内充支付"))
				{
					if (P_0.user.缓存数据.is使用仙灵卡)
					{
						return null;
					}
					if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
					{
						return null;
					}
					if (CS_0024_003C_003E8__locals203.iQU7t7BsPB == "!^内充支付充值")
					{
						Singleton<xH3TPsiexTnpJAMMnJm>.I.kbaBJ1ydbE(P_0, text);
					}
					else if (CS_0024_003C_003E8__locals203.iQU7t7BsPB == "!^内充支付充值抽奖" && Singleton<全局变量类>.I.内充支付配置.开启抽奖模式)
					{
						Singleton<xH3TPsiexTnpJAMMnJm>.I.KUiBRPrqmH(P_0, text);
					}
					else if (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "内充支付充值_"))
					{
						Singleton<xH3TPsiexTnpJAMMnJm>.I.FBsBKXIf8k(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					}
					else if (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "内充支付抽奖_"))
					{
						Singleton<xH3TPsiexTnpJAMMnJm>.I.T7rBdObvJg(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB);
					}
					return null;
				}
			}
			if (COyX27f6L3uCF3F6Kp5.nZify3Mg0F() && Singleton<ByteAPI>.I.寻找文本或(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "道具绑定操作_", "宠物绑定操作_"))
			{
				bool flag = false;
				int result2 = 0;
				if (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "道具绑定操作_"))
				{
					flag = true;
					if (!int.TryParse(CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("道具绑定操作_", string.Empty), out result2))
					{
						return null;
					}
				}
				else if (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "宠物绑定操作_"))
				{
					flag = false;
					if (!int.TryParse(CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("宠物绑定操作_", string.Empty), out result2))
					{
						return null;
					}
				}
				if (result2 == 0)
				{
					return null;
				}
				Singleton<COyX27f6L3uCF3F6Kp5>.I.peBfT2qkrC(P_0, flag, result2);
				return null;
			}
			if (uh2edhfVGtogUy49Lpv.pdEfxlnyv1() && Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "!^自助货栈_下单_"))
			{
				if (P_0.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (!Singleton<WdAPI>.I.bJboBw7BEu(P_0, P_2))
				{
					return null;
				}
				if (!int.TryParse(CS_0024_003C_003E8__locals203.iQU7t7BsPB.Replace("!^自助货栈_下单_", string.Empty), out var result3) || !int.TryParse(text, out var result4))
				{
					Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
					return null;
				}
				if (result4 <= 0 || result4 > 100 || result3 < 0 || result3 >= Singleton<全局变量类>.I.自助商店配置.点数列表.Count)
				{
					Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
					return null;
				}
				Singleton<uh2edhfVGtogUy49Lpv>.I.yf6f1XgX3g(P_0, Singleton<全局变量类>.I.自助商店配置.点数列表[result3], result4);
				return null;
			}
			if (Singleton<全局变量类>.I.挑战BOSS配置.功能开关 && (Singleton<全局变量类>.I.挑战BOSS配置.挑战boss列表.Values.Any( (挑战BOSS列表类 x) => Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, x.对话关键词)) || Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "超级BOSS操作_补充次数") || Singleton<ByteAPI>.I.寻找文本或(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "我要为民除害", "开始挑战", "战斗") || Singleton<ByteAPI>.I.寻找文本与(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "开始", "战斗") || Singleton<ByteAPI>.I.寻找文本与(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "进入战斗(", ")")))
			{
				if (P_0.user.缓存数据.is使用仙灵卡)
				{
					return null;
				}
				if (nPC信息类 == null)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("点击的NPC不存在"));
					return null;
				}
				_ = nPC信息类.名字;
				if (!Singleton<ByteAPI>.I.寻找文本("|天魁星|天魔星|天机星|天闲星|天勇星|天雄星|天猛星|天威星|天英星|天贵星|天富星|天满星|天孤星|天伤星|天立星|天捷星|天暗星|天祐星|天空星|天速星|天异星|天杀星|天微星|天究星|天退星|天寿星|天剑星|天平星|天罪星|天损星|天败星|天牢星|天慧星|天暴星|天哭星|天巧星|", "|" + nPC信息类.名字 + "|"))
				{
					Singleton<ByteAPI>.I.寻找文本("|地魁星|地煞星|地勇星|地杰星|地雄星|地威星|地英星|地奇星|地猛星|地文星|地正星|地辟星|地阖星|地强星|地暗星|地轴星|地会星|地佐星|地佑星|地灵星|地兽星|地微星|地慧星|地暴星|地默星|地猖星|地狂星|地飞星|地走星|地巧星|地明星|地进星|地退星|地满星|地遂星|地周星|地隐星|地异星|地理星|地俊星|地乐星|地捷星|地速星|地镇星|地稽星|地魔星|地妖星|地幽星|地伏星|地僻星|地空星|地孤星|地全星|地短星|地角星|地囚星|地藏星|地平星|地损星|地奴星|地察星|地恶星|地丑星|地数星|地阴星|地刑星|地壮星|地劣星|地健星|地耗星|地贼星|地狗星|", "|" + nPC信息类.名字 + "|");
				}
				if (Singleton<全局变量类>.I.挑战BOSS配置.挑战boss列表.TryGetValue(nPC信息类.名字, out 挑战BOSS列表类 value2))
				{
					if (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals203.iQU7t7BsPB, "超级BOSS操作_补充次数"))
					{
						Singleton<FBGRmlstyRWQdqi0pHa>.I.jkMUssH7u1(P_0, CS_0024_003C_003E8__locals203.iQU7t7BsPB, value2);
						return null;
					}
					bool flag2 = false;
					lock (P_0.BOSS挑战锁)
					{
						long num2 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
						if (num2 - P_0.user.缓存数据.BOSS请求战斗时间 >= 1000)
						{
							flag2 = true;
							P_0.user.缓存数据.BOSS请求战斗时间 = num2;
						}
						else
						{
							flag2 = false;
						}
						if (!flag2)
						{
							P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("点击NPC过快，无法进行此操作。"));
							return null;
						}
						if (!Singleton<FBGRmlstyRWQdqi0pHa>.I.XOfUKXehUo(P_0, value2, CS_0024_003C_003E8__locals203.zsC7ZSUAQC))
						{
							return null;
						}
					}
				}
			}
			封包_写2.写文本型(CS_0024_003C_003E8__locals203.iQU7t7BsPB, hasCount: true, 0);
			封包_写2.写文本型(text, hasCount: true, 0);
			封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
			defaultInterpolatedStringHandler.AppendLiteral("请求_NPC对话点击处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return null;
		}
	}

	
	internal async Task K1bipvfXc4(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(12L, SeekOrigin.Begin);
			封包_读2.读短整数型(reverse: true, out var value);
			string value2 = string.Empty;
			int value3 = 0;
			short value4 = 0;
			short value5 = 0;
			int value6 = 0;
			int value7 = 0;
			string value8 = string.Empty;
			for (int i = 0; i < value; i++)
			{
				封包_读2.读文本型(out value2, true, (byte)0, false);
				封包_读2.读整数型(reverse: true, out value3);
				封包_读2.读短整数型(reverse: true, out value4);
				封包_读2.读短整数型(reverse: true, out value5);
				封包_读2.读字节型(out value6);
				封包_读2.读字节型(out value7);
				封包_读2.读文本型(out value8, true, (byte)0, false);
				X56iVZIf2q(P_0.插件端口, value3, value2, value4, value5, value8);
			}
			await Task.Delay(1);
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_所有NPC信息-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private bool M9si158vHe(MyNATSocketClient P_0, NPC信息类 P_1, int P_2)
	{
		if (P_1 == null)
		{
			return true;
		}
		if (string.IsNullOrWhiteSpace(P_1.所在地图))
		{
			return true;
		}
		if (P_2 == P_0.user.人物数据.角色ID)
		{
			return true;
		}
		if (P_1.所在地图 == P_0.user.人物数据.所在地图名字)
		{
			return true;
		}
		if ("|通天塔|娃娃训练营|宠物训练营|体魄训练营|灵敏训练营|智慧训练营|力气训练营|帮派总坛|聚义堂|高级帮派总坛|高级聚义堂|".Contains("|" + P_1.所在地图 + "|", StringComparison.CurrentCulture))
		{
			return true;
		}
		if ("|李总兵|通灵道人|陆压真人|门派使者|多宝道人|玉鉴上人|太玄真君|仙界神捕|柳如尘|柳如烟|杨镖头|陈镖头|玉泉真人|清微真人|南华真人|".Contains("|" + P_1.名字 + "|", StringComparison.CurrentCulture))
		{
			return true;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 9);
		defaultInterpolatedStringHandler.AppendLiteral("异常原因：账号[");
		defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
		defaultInterpolatedStringHandler.AppendLiteral("] 昵称[");
		defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
		defaultInterpolatedStringHandler.AppendLiteral("(");
		defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.所在地图名字);
		defaultInterpolatedStringHandler.AppendLiteral("|");
		defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.坐标.X);
		defaultInterpolatedStringHandler.AppendLiteral(".");
		defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.坐标.Y);
		defaultInterpolatedStringHandler.AppendLiteral(")] 访问NPC[");
		defaultInterpolatedStringHandler.AppendFormatted(P_1.名字);
		defaultInterpolatedStringHandler.AppendLiteral("(");
		defaultInterpolatedStringHandler.AppendFormatted(P_1.所在地图);
		defaultInterpolatedStringHandler.AppendLiteral("|");
		defaultInterpolatedStringHandler.AppendFormatted(P_1.坐标X);
		defaultInterpolatedStringHandler.AppendLiteral(".");
		defaultInterpolatedStringHandler.AppendFormatted(P_1.坐标Y);
		defaultInterpolatedStringHandler.AppendLiteral(")]");
		Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		return false;
	}

	
	public z4BxVniyeUkxpq0lEyg()
	{
	}

	static z4BxVniyeUkxpq0lEyg()
	{
	}
}
