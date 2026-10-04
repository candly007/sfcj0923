using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using B6XRmUwQK7iatdTWLwc;
using DRafti6FMxQYhxQAQHW;
using GJSyJYUDOfxE331QwT1;
using KEvDjBdeoLOoBKWXFAH;
using OwjyAmRhZ9nO8Ec0bP9;
using R8lTaqgbEc6MvH2j6n0;
using Serilog;
using UQuLZEj71kRGhQn6jmQ;
using UbblDNG1yFpxk6Q0ui4;
using VcF0pbBvJqp0x0IfwN;
using WbRTrCLpc2rxKDLScV;
using YOheREbBnDq6LvvWZEr;
using hUWm54DrC1dskj6PIsS;
using irBd2ubEj0IMVbGRstp;
using jVVIM9j1PL0VAliGELE;
using kNOi3Vbgo4LTDja4YFk;
using mxyyZlfUTTOCu8Y4ZsN;
using swC6eeDmDlHvujbhoCw;
using uI75fJjR7A2e7wWdq9f;
using vBIs2Rf2vSSk1OdhoS7;
using xqlPMM2TJRNXpZnNDFn;

namespace F2RFuVfrhBPBhCG1Yrv;

internal class hQdJQufqsH3l9bnUemG : Singleton<hQdJQufqsH3l9bnUemG>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public string ch39259tkr;

		
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		
		internal bool Ifv96Pru60(string x)
		{
			return ch39259tkr.Contains(x, StringComparison.CurrentCulture);
		}

		static _003C_003Ec__DisplayClass2_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public short uTk9PTHFpu;

		public Func<int, bool> eYQ9Xm1PMJ;

		
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		
		internal bool n0b9mvYcpc(int x)
		{
			return x == uTk9PTHFpu;
		}

		static _003C_003Ec__DisplayClass7_0()
		{
		}
	}

	public short Qe56JI1uxR;

	
	internal byte[] AX8fZUSN5X(MyNATSocketClient P_0, byte[] P_1, int P_2)
	{
		封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
		封包_读2.Seek(12L, SeekOrigin.Begin);
		StringBuilder stringBuilder = new StringBuilder();
		if (P_2 == 8165)
		{
			stringBuilder.Append(封包_读2.读文本型(是否声明长度: true, 1, 是否反转长度: true));
		}
		else
		{
			封包_读2.读字节集(6);
			stringBuilder.Append(封包_读2.读文本型(是否声明长度: true, 1, 是否反转长度: true));
		}
		if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "帐号安全级别：#R危险，您的帐号没有绑定任何密保", "光宇安全中心"))
		{
			P_0.user.缓存数据.上半部分卡密 = Singleton<ByteAPI>.I.取文本中间(stringBuilder.ToString(), "http://", "。");
			return null;
		}
		if (Singleton<ByteAPI>.I.寻找文本或(stringBuilder.ToString(), "你死亡了，", "你死亡了，因此损失了", "由于你一天内死亡超过了", "本次死亡的惩罚已经被免除了", "你得到了神的护佑，免去了", "次死亡惩罚，当前还可以免死") && (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is神级掉落))
		{
			P_0.user.缓存数据.is战斗逃跑指令 = true;
		}
		if (P_2 == 8165 && Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "吞天之变幻无穷大，道友还需多加参透再来挑战"))
		{
			P_0.user.缓存数据.is战斗逃跑指令 = true;
		}
		if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "（原因：", "）"))
		{
			Singleton<MainService>.I.历史IP账号列表.TryGetValue(P_0.当前client.IP, out P_0.账号);
			if (string.IsNullOrWhiteSpace(P_0.账号))
			{
				Singleton<全局变量类>.I.异常记录执行(P_0.账号, Singleton<ByteAPI>.I.取文本中间(stringBuilder.ToString(), "（原因：", "）"));
			}
		}
		if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "你复制了", "自动摆摊卡") && !P_0.user.存档数据.is防摆摊状态)
		{
			Singleton<WdAPI>.I.H80o7hWH9k(P_0);
		}
		if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "没有这个道具：", "。"))
		{
			string 总文本 = Singleton<ByteAPI>.I.到文本(P_1);
			string text = Singleton<ByteAPI>.I.文本_取出中间文本(总文本, "没有这个道具：", "。");
			if (!string.IsNullOrWhiteSpace(text))
			{
				Singleton<fK6mLrjpv26MU2YIIF9>.I.Ym9jrsy6dl(P_0, "发送道具失败：" + text);
			}
			return null;
		}
		if (Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "发货获得") || Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "地图", "没有找到") || Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "试炼鬼才设置", "试炼开始") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "你的现金数量已超过携带上限") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "你上次登入的IP地址为") || (Singleton<全局变量类>.I.config.is悟道转换 && Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "次附加属性的转换次数")) || (iRGieud4qtscW6ESmxk.wGmslE7YU3() && Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "你当前已经销毁了绑定的")) || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "你包裹已满，无法装载") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "你复制了") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "没有这个目标") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "你指天画地，念了好几遍咒语") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "比较贵重，本次成功交易后") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "你被踢下线了") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "没有天生技能") || Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "你将", "踢下线") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "此功能暂时关闭") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "只可回购最近10次物品交易") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "没有找到匹配的结果") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "天生技能小于") || Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "已经清除", "任务的相关信息") || Singleton<ByteAPI>.I.寻找文本或(stringBuilder.ToString(), "你使用了#R融丹专用经验包", "你使用了#R融丹专用道行包") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "你当前已经卖出了贵重物品"))
		{
			return null;
		}
		if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "你销毁了", "。") && !Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "#R"))
		{
			string text2 = Singleton<ByteAPI>.I.文本_取出中间文本(stringBuilder.ToString(), "你销毁了", "。");
			if (!string.IsNullOrWhiteSpace(text2))
			{
				P_0.销毁回调事件?.Invoke(text2);
				return null;
			}
		}
		else if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "你丢弃了#R", "#n。"))
		{
			string[] array = stringBuilder.ToString().Replace("#n。", string.Empty).Split("#R");
			if (array.Length != 0)
			{
				P_0.销毁回调事件?.Invoke(array[^1]);
				return null;
			}
		}
		if (YHfw7nGpg7WfdCBKDH4.qapfK9UWNV() && Singleton<YHfw7nGpg7WfdCBKDH4>.I.wEwGqeJbdD(P_0, stringBuilder, P_2))
		{
			return null;
		}
		if (P_2 == 2829 && (Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "你卖出了") || Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "你捐赠了")) && Singleton<全局变量类>.I.道具宠物回收配置.is道具回收)
		{
			Singleton<fFv8GpjvE2cusnNqivq>.I.nZJjCGoMSO(P_0, P_1);
			return P_1;
		}
		if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.QLk24Vn589(stringBuilder.ToString()))
		{
			return null;
		}
		Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "由于你在规定时间内没有完成通天塔修炼任务");
		if (P_2 == 2829 && Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "额外领取一次#R通天塔"))
		{
			P_0.user.存档数据.通天塔额外次数++;
		}
		else if (!Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "恭喜你完成了通天塔的修炼") && Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "你当前已经丢弃了", "回购该宠物"))
		{
			return null;
		}
		if (XhaJ3cfswGhhnmIequv.vI0fNpyhWg())
		{
			日常存档类 value4;
			if (P_2 == 2829 && Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "你完成了#R师门任务#n得到了#R", "#n点师门贡献度"))
			{
				if (!P_0.user.存档数据.日常存档.TryGetValue(AllEnums.日常类型Type.师门任务, out var value))
				{
					value = new 日常存档类
					{
						日常类型 = AllEnums.日常类型Type.师门任务,
						完成次数 = 0,
						任务星级 = AllEnums.任务星级Type.通用
					};
					P_0.user.存档数据.日常存档.TryAdd(AllEnums.日常类型Type.师门任务, value);
				}
				Singleton<XhaJ3cfswGhhnmIequv>.I.ULvf8HlQXX(P_0, value);
			}
			else if (P_2 == 2829 && Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "你消耗了", "五雷令耐久", "领取了", "#n任务奖励"))
			{
				if (Enum.TryParse<AllEnums.日常类型Type>(Singleton<ByteAPI>.I.取文本中间(stringBuilder.ToString(), "星#n的#R", "#n任务奖励"), out var result))
				{
					if (!P_0.user.存档数据.日常存档.TryGetValue(result, out var value2))
					{
						value2 = new 日常存档类
						{
							日常类型 = result,
							完成次数 = 0,
							任务星级 = (Singleton<ByteAPI>.I.寻找文本或(stringBuilder.ToString(), "领取了#R一星#n", "领取了#R二星#n") ? Enum.Parse<AllEnums.任务星级Type>(Singleton<ByteAPI>.I.取文本中间(stringBuilder.ToString(), "领取了#R", "#n的")) : AllEnums.任务星级Type.通用)
						};
						P_0.user.存档数据.日常存档.TryAdd(result, value2);
					}
					else
					{
						value2.任务星级 = (Singleton<ByteAPI>.I.寻找文本或(stringBuilder.ToString(), "领取了#R一星#n", "领取了#R二星#n") ? Enum.Parse<AllEnums.任务星级Type>(Singleton<ByteAPI>.I.取文本中间(stringBuilder.ToString(), "领取了#R", "#n的")) : AllEnums.任务星级Type.通用);
					}
					Singleton<XhaJ3cfswGhhnmIequv>.I.ULvf8HlQXX(P_0, value2, true);
				}
			}
			else if (P_2 == 2829 && stringBuilder.ToString() == "你获得了#R1点#n任务积分。" && P_0.user.缓存数据.任务缓存字典.ContainsKey("300环连环"))
			{
				if (P_0.user.存档数据.日常存档.TryGetValue(AllEnums.日常类型Type.跑环任务, out var value3))
				{
					Singleton<XhaJ3cfswGhhnmIequv>.I.ULvf8HlQXX(P_0, value3);
				}
			}
			else if (P_2 == 2829 && Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "由于你成功完成副本挑战任务") && P_0.user.存档数据.日常存档.TryGetValue(AllEnums.日常类型Type.副本挑战, out value4))
			{
				Singleton<XhaJ3cfswGhhnmIequv>.I.ULvf8HlQXX(P_0, value4);
			}
			日常存档类 value9;
			if (P_2 == 8165 && Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "一股莫名的力量使你从八仙梦境中惊醒"))
			{
				if (P_0.user.存档数据.日常存档.TryGetValue(AllEnums.日常类型Type.八仙梦境, out var value5))
				{
					Singleton<XhaJ3cfswGhhnmIequv>.I.ULvf8HlQXX(P_0, value5);
				}
			}
			else if (P_2 == 8165 && Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "恭喜你，破阵修道成功。十绝阵之变化，你已有所了解"))
			{
				if (P_0.user.存档数据.日常存档.TryGetValue(AllEnums.日常类型Type.十绝阵, out var value6))
				{
					Singleton<XhaJ3cfswGhhnmIequv>.I.ULvf8HlQXX(P_0, value6);
				}
			}
			else if (P_2 == 8165 && Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "恭喜你，第", "轮修炼顺利完成", "领取下一轮修炼任务吧"))
			{
				if (P_0.user.存档数据.日常存档.TryGetValue(AllEnums.日常类型Type.仙人指路, out var value7))
				{
					Singleton<XhaJ3cfswGhhnmIequv>.I.ULvf8HlQXX(P_0, value7);
				}
			}
			else if (P_2 == 8165 && Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "恭喜！你已完成了一轮八阵图修炼"))
			{
				if (P_0.user.存档数据.日常存档.TryGetValue(AllEnums.日常类型Type.八阵图, out var value8))
				{
					Singleton<XhaJ3cfswGhhnmIequv>.I.ULvf8HlQXX(P_0, value8);
				}
			}
			else if (P_2 == 8165 && stringBuilder.ToString().StartsWith("你被一股奇怪的力量送出了【昆仑神镜】") && P_0.user.存档数据.日常存档.TryGetValue(AllEnums.日常类型Type.昆仑神镜, out value9))
			{
				Singleton<XhaJ3cfswGhhnmIequv>.I.ULvf8HlQXX(P_0, value9);
			}
		}
		if (P_2 == 2829)
		{
			if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "#R天星石#n", "进化成功", "进化后的装备需求等级为", "套装效果将会消失。"))
			{
				Singleton<QxBx5YDqZUOBMg9A6NN>.I.超级进化事件处理(P_0, Singleton<ByteAPI>.I.取文本中间(stringBuilder.ToString(), "进化后的装备需求等级为#R", "#n级，"));
			}
			if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "你身上天星石不足#R", "#n块，不能进化"))
			{
				P_0.user.缓存数据.超级进化格子 = 0;
			}
			if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "恭喜你，你们队伍是本区组第一队战胜#Y", "#n的"))
			{
				Singleton<KmvE5t6XclSPSYZqqE9>.I.Lk76MVhTOJ(P_0, Singleton<ByteAPI>.I.文本_取出中间文本(stringBuilder.ToString(), "恭喜你，你们队伍是本区组第一队战胜#Y", "#n的"), true);
			}
			string empty = string.Empty;
			string empty2 = string.Empty;
			string empty3 = string.Empty;
			if (stringBuilder.ToString().Contains("你销毁了物品#R", StringComparison.CurrentCulture))
			{
				empty3 = Singleton<ByteAPI>.I.文本_取出中间文本(stringBuilder.ToString(), "你销毁了物品#R", "#n");
				if (!string.IsNullOrWhiteSpace(empty3))
				{
					P_0.销毁回调事件?.Invoke(empty3);
				}
				return null;
			}
			if (stringBuilder.ToString().Contains("你使用了#R", StringComparison.CurrentCulture))
			{
				empty = (stringBuilder.ToString().Contains("#n。", StringComparison.CurrentCulture) ? Singleton<ByteAPI>.I.文本_取出中间文本(stringBuilder.ToString(), "你使用了#R", "#n。") : ((!stringBuilder.ToString().Contains("#n，", StringComparison.CurrentCulture)) ? Singleton<ByteAPI>.I.取文本中间(stringBuilder.ToString(), "你使用了#R", "") : Singleton<ByteAPI>.I.文本_取出中间文本(stringBuilder.ToString(), "你使用了#R", "#n，")));
				if (!string.IsNullOrWhiteSpace(empty))
				{
					Singleton<zeYnwTjKgpmAbfSQh5J>.I.aEOjDQKDSy(P_0, empty);
				}
				return P_1;
			}
			if (stringBuilder.ToString().Contains("你得到了#R", StringComparison.CurrentCulture) && stringBuilder.ToString().Contains("#n。", StringComparison.CurrentCulture))
			{
				empty2 = Singleton<ByteAPI>.I.文本_取出中间文本(stringBuilder.ToString(), "你得到了#R", "#n。");
				if (empty2.Contains("#R", StringComparison.CurrentCulture))
				{
					empty2 = Singleton<ByteAPI>.I.取文本中间(empty2, "#R", "");
				}
				if (string.IsNullOrWhiteSpace(empty2))
				{
					return null;
				}
				if (Singleton<全局变量类>.I.超级道具配置.功能开关 && ("|" + Singleton<全局变量类>.I.超级道具配置.自动使用道具 + "|").Contains("|" + empty2 + "|", StringComparison.CurrentCulture))
				{
					return null;
				}
				return P_1;
			}
			if (Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "切换至加点方案"))
			{
				if (fuMNpgieFTYU3Wah53.BojPVlpN4())
				{
					P_0.user.缓存数据.is加点方案一 = true;
				}
				else
				{
					P_0.user.缓存数据.is加点方案一 = Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "切换至加点方案一");
				}
			}
			else if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "你在#Y", "#n上线"))
			{
				P_0.user.人物数据.所在区线路 = Singleton<ByteAPI>.I.取文本中间(stringBuilder.ToString(), "你在#Y", "#n上线");
			}
			else if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "你从#Y", "#n换至#Y"))
			{
				P_0.user.人物数据.所在区线路 = Singleton<ByteAPI>.I.取文本中间(stringBuilder.ToString(), "换至#Y", "#n啦");
			}
			else if (!Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "发出了组队申请。"))
			{
				if (Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "你组建了一支队伍。"))
				{
					P_0.user.缓存数据.is队伍中 = true;
				}
				else if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "你加入#Y", "#n的队伍。"))
				{
					P_0.user.缓存数据.is队伍中 = true;
				}
				else if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "你暂时离开了#Y", "#n的队伍。"))
				{
					P_0.user.缓存数据.is队伍中 = false;
				}
				else if (Singleton<ByteAPI>.I.寻找文本与(stringBuilder.ToString(), "你回到了#Y", "#n的队伍。"))
				{
					P_0.user.缓存数据.is队伍中 = true;
				}
				else if (Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "队伍解散了。"))
				{
					P_0.user.缓存数据.is队伍中 = false;
				}
				else if (Singleton<ByteAPI>.I.寻找文本(stringBuilder.ToString(), "你成为了新的队长。"))
				{
					P_0.user.缓存数据.is队伍中 = true;
				}
			}
		}
		return P_1;
	}

	
	internal byte[] XjBft4bbJj(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
			obj.Seek(10L, SeekOrigin.Begin);
			obj.读字节集(2);
			obj.读短整数型(reverse: true, out var _);
			obj.读整数型(reverse: true, out var _);
			obj.读文本型(out string _, true, (byte)0, false);
			obj.读文本型(out string value4, true, (byte)1, true);
			obj.读文本型(out string _, true, (byte)0, false);
			obj.读文本型(out string _, true, (byte)0, false);
			obj.读文本型(out string value7, true, (byte)0, false);
			if (Singleton<ByteAPI>.I.寻找文本(value4, "请尽快锁定自己的帐号"))
			{
				if (Singleton<全局变量类>.I.验证client?.是否成功 != true)
				{
					Log.Error("【非法登录】IP：" + P_0.当前client.IP + "，授权租约未验证");
					Singleton<全局变量类>.I.卡密验证状态 = false;
					Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
				}
				else
				{
					Singleton<全局变量类>.I.卡密验证状态 = true;
				}
				return null;
			}
			if (Singleton<ByteAPI>.I.寻找文本(value4, "本次登入的IP地址为#G"))
			{
				if (P_0.user.人物数据.所在区线路 != value7)
				{
					P_0.user.人物数据.所在区线路 = value7;
				}
				return null;
			}
			if (Singleton<ByteAPI>.I.寻找文本或(value4, "你上次登入的IP地址", "由于您的帐号还未采用安全密保措施或密", "心法宝典周卡", "为了保障更多玩家的账号安全", "近期出现了一批极具欺骗性的", "《问道》#R1.60#n新版本", "开放！此竞技场"))
			{
				return null;
			}
			if (Singleton<ByteAPI>.I.寻找文本(value4, ":69FD94F6139D17088888:"))
			{
				return Singleton<YHfw7nGpg7WfdCBKDH4>.I.gFOGtSxclt(P_1);
			}
			if (FcVoHRwOVsflDmDUQOP.JhVwZ5yCsf() && Singleton<ByteAPI>.I.寻找文本(value4.ToString(), "在捕捉精怪时，竟然捕捉到了隐藏在精怪之中的"))
			{
				P_0.召唤精怪事件?.Invoke(Singleton<ByteAPI>.I.取文本中间(value4.ToString(), "十阶坐骑", "奖励"));
				return null;
			}
			if (Singleton<全局变量类>.I.试道大会配置.功能开关)
			{
				if (Singleton<ByteAPI>.I.寻找文本(value4.ToString(), "试道大会之#R巅峰对决#n，正式开始啦！") && P_0.user.人物数据.Is试道场)
				{
					P_0.user.存档数据.Is试道奖励领取 = false;
					Singleton<SSW8tHD2MvRIUVygbNo>.I.TTdDSExcHm(P_0);
				}
				else
				{
					if (Singleton<ByteAPI>.I.寻找文本与(value4, "恭喜你，", "请前往", "级别的试道大会的", "名#n，请前往"))
					{
						string text = Singleton<ByteAPI>.I.取文本中间(Singleton<ByteAPI>.I.取文本中间(value4, "恭喜你，", "请前往"), "级别的试道大会的#R第", "名#n，");
						Singleton<SSW8tHD2MvRIUVygbNo>.I.zjBDcFQnMU(P_0, text);
						return null;
					}
					if (Singleton<ByteAPI>.I.寻找文本与(value4, "#Y" + P_0.user.人物数据.昵称 + "#n", "赢得了", "级别试道大会，获得了", "的奖励"))
					{
						Singleton<SSW8tHD2MvRIUVygbNo>.I.zjBDcFQnMU(P_0, "1");
						return null;
					}
				}
			}
			if (Singleton<KmvE5t6XclSPSYZqqE9>.I.aWX65nZjut(value4))
			{
				return null;
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("接收_频道信息处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	internal byte[] GJ9fAVJb8P(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass2_0();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(22L, SeekOrigin.Begin);
			CS_0024_003C_003E8__locals3.ch39259tkr = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			if (Singleton<全局变量类>.I.喊话限制配置.功能开关 && Singleton<全局变量类>.I.喊话限制配置.敏感词.Any( (string x) => CS_0024_003C_003E8__locals3.ch39259tkr.Contains(x, StringComparison.CurrentCulture)))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
				defaultInterpolatedStringHandler.AppendLiteral("异常喊话触发：账号[");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral("]  昵称[");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("]  发言内容[");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals3.ch39259tkr);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				if (Singleton<全局变量类>.I.喊话限制配置.is触发掉线)
				{
					Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
				}
				return null;
			}
			return P_1;
		}
		catch (Exception ex)
		{
			Log.Error("请求_私聊信息处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	internal byte[] sTWfzj4nZy(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value), reverse: true);
			封包_写2.写字节集(封包_读2.读字节集(5), hasCount: false, 0);
			string text = 封包_读2.读文本型(是否声明长度: true, 0);
			string text2 = Singleton<ByteAPI>.I.取文本右边(text, text.Length - 8);
			if (text2.Length == 36 && text2.StartsWith("A*") && text2.EndsWith("*Z") && text2.验证是否只有英文和数字() && (Singleton<全局变量类>.I.config.is点卡cdk || Singleton<全局变量类>.I.config.is道具cdk))
			{
				if (P_0.user.缓存数据.is战斗中 || P_0.user.缓存数据.is观战中)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R战斗中#n、#R观战中#n等状态下无法进行CDK兑换操作。"));
					return null;
				}
				Singleton<EMBQv9FAOd3LKHwy7T>.I.ANFcKGBuL(P_0, text2);
				return null;
			}
			if (text2 == "小助手")
			{
				Singleton<Xh4EKmRML8L7x53wDHM>.I.小助手_呼叫(P_0);
				return null;
			}
			if (Singleton<全局变量类>.I.喊话限制配置.功能开关)
			{
				if (value == 19 && Singleton<全局变量类>.I.喊话限制配置.喇叭喊话最低等级 != 0 && P_0.user.属性数据.等级 < Singleton<全局变量类>.I.喊话限制配置.喇叭喊话最低等级)
				{
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的等级不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.喊话限制配置.喇叭喊话最低等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法使用此频道！");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return null;
				}
				foreach (string item in Singleton<全局变量类>.I.喊话限制配置.敏感词)
				{
					if (!string.IsNullOrWhiteSpace(item) && text2.Contains(item, StringComparison.CurrentCulture))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
						defaultInterpolatedStringHandler.AppendLiteral("异常喊话触发：账号[");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
						defaultInterpolatedStringHandler.AppendLiteral("]  昵称[");
						defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
						defaultInterpolatedStringHandler.AppendLiteral("]  发言内容[");
						defaultInterpolatedStringHandler.AppendFormatted(text2);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
						if (Singleton<全局变量类>.I.喊话限制配置.is触发掉线)
						{
							Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
						}
						return null;
					}
				}
			}
			if (Singleton<全局变量类>.I.config.is内置辅助 && text2 == Singleton<全局变量类>.I.config.打开辅助指令)
			{
				P_0.C_Send(Singleton<WdAPI>.I.MdUomVRsfU(P_0));
				return null;
			}
			if (Singleton<全局变量类>.I.推荐拉人配置.功能开关 && text2 == "推荐查询")
			{
				P_0.C_Send(Singleton<EfHAVFUgqrnaj1QwnLW>.I.DdCUoGfo6q(P_0));
				return null;
			}
			if (text2 == Singleton<全局变量类>.I.config.退出战斗指令 && !P_0.user.人物数据.Is试道场)
			{
				if (P_0.user.队伍数据.成员列表.Count > 0 && !P_0.user.队伍数据.is队长 && P_0.user.缓存数据.is队伍中)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("【退出战斗】指令需要队长下达才能生效！"));
					return null;
				}
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R退出战斗#n指令已经下达，等待本回合结束。"));
				Singleton<WdAPI>.I.EOYImZQJeG(P_0, true);
				P_0.S_Send(Singleton<WdAPI>.I.zXxoPwQcb0(P_0.user.人物数据.昵称));
				return null;
			}
			if (text2 == "找回属性")
			{
				Singleton<KU0aMobWe16QEEmpLCj>.I.iPIbNC4UnR(P_0, $"{(P_0.user.缓存数据.is加点方案一 ? 1 : 2)}");
				return null;
			}
			if (P_0.user.人物数据.账号 == Singleton<全局变量类>.I.config.挂载GM账号 && text2 == "清空全区相性")
			{
				foreach (角色存档数据类 value6 in Singleton<全局变量类>.I.角色存档表.Values)
				{
					value6.Is清空相性 = true;
				}
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("全区存档状态已经重置，所有玩家下次上线会自动清空相性重新加点"));
				return null;
			}
			if (P_0.user.人物数据.账号 == Singleton<全局变量类>.I.config.挂载GM账号 && text2 == "启动无双")
			{
				Singleton<BpcEfFbiGBBV3s2B0ai>.I.uGGb7FpVJN();
				return null;
			}
			if (Singleton<全局变量类>.I.签到配置.功能开关 && text2 == "签到")
			{
				Singleton<p63Ra5gwg6vJ45gPiim>.I.xnmgskXkX0(P_0);
				return null;
			}
			if (Singleton<全局变量类>.I.在线抽奖配置.功能开关 && text2 == "抽奖")
			{
				Singleton<cGiRplbQfaJV9guWDIS>.I.cqMbxmXGun(P_0);
				return null;
			}
			if (text2 == "卡战斗")
			{
				P_0.S_Send(new byte[12]
				{
					77, 90, 0, 0, 0, 0, 0, 0, 0, 6,
					65, 4
				}.Concat(P_0.user.缓存数据.截取时间).ToArray());
				return null;
			}
			if (text2 == "摊位" && P_0.user.存档数据.摊位ID != 0)
			{
				string oldValue = "摊位";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
				defaultInterpolatedStringHandler.AppendLiteral("1/");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.摊位ID);
				defaultInterpolatedStringHandler.AppendLiteral("/:69FD94F6139D17088888:");
				封包_写2.写文本型(text.Replace(oldValue, defaultInterpolatedStringHandler.ToStringAndClear()), hasCount: true, 0);
				封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
				return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
			}
			if (text2 == "下线")
			{
				Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
				Log.Error("下线指令-错误：[" + P_0.user.人物数据.昵称 + "]强制下线");
				return null;
			}
			if (P_0.当前权限 == 300 && Singleton<ByteAPI>.I.寻找文本(text2, "技能等级同步+") && int.TryParse(text2.Replace("技能等级同步+", string.Empty), out var result))
			{
				foreach (MyNATSocketClient value7 in Singleton<全局变量类>.I.会话Dict.Values)
				{
					if (!value7.使用中)
					{
						continue;
					}
					foreach (KeyValuePair<string, short> item2 in value7.user.技能数据.技能列表)
					{
						if (item2.Value != result && item2.Value != 1 && item2.Value != 60 && 问道数据类.所有技能ID.TryGetValue(item2.Key, out var value3))
						{
							Singleton<WdAPI>.I.W9lI1TZlUs(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), $"{value3}", $"{result}");
						}
					}
				}
			}
			if (全局变量类.Is调试)
			{
				if (text2 == "GM突破" && P_0.当前权限 == 300)
				{
					Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.hyd21cIsmI(P_0, true);
				}
				if (Singleton<ByteAPI>.I.寻找文本(text2, "测试大飞"))
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), "upgrade/state", "1", "admin_set_attrib");
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), "upgrade/type", "3", "admin_set_attrib");
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), "max_assign_polar", "40", "admin_set_attrib");
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), "upgrade/level", "140", "admin_set_attrib");
				}
				if (Singleton<ByteAPI>.I.寻找文本(text2, "energy"))
				{
					Singleton<WdAPI>.I.lvuI30yCQE(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), text2.Split("+")[0], text2.Split("+")[1], "admin_set_attrib");
				}
				if (Singleton<ByteAPI>.I.寻找文本(text2, "灵气+"))
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, int.Parse(text2.Replace("灵气+", string.Empty)), false, "[个人突破-" + P_0.user.人物数据.昵称 + "-GM增加]");
				}
				if (Singleton<ByteAPI>.I.寻找文本(text2, "添加技能：") && 问道数据类.所有技能ID.TryGetValue(text2.Replace("添加技能：", string.Empty), out var value4))
				{
					Singleton<WdAPI>.I.W9lI1TZlUs(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), $"{value4}", "330");
				}
				if (Singleton<ByteAPI>.I.寻找文本(text2, "临时测试："))
				{
					P_0.临时测试 = int.Parse(text2.Replace("临时测试：", string.Empty));
				}
				if (text2 == "qqq")
				{
					P_0.C_Send(new byte[27]
					{
						77, 90, 0, 0, 0, 0, 0, 0, 0, 17,
						255, 223, 0, 1, 0, 0, 0, 0, 0, 0,
						0, 2, 0, 0, 0, 0, 0
					});
					P_0.C_Send(new byte[26]
					{
						77, 90, 0, 0, 0, 0, 0, 0, 0, 16,
						82, 3, 0, 0, 0, 0, 0, 0, 0, 25,
						0, 0, 0, 0, 0, 1
					});
				}
				if (text2 == "www")
				{
					string[] array = "#@AchievementEffectDlg|Open:AchievementEffectDlg#@\r\n#@AchievementFriendDlg|Open:AchievementFriendDlg#@\r\n#@AchievementInfo|Open:AchievementInfo#@\r\n#@AchievementInfoAtc|Open:AchievementInfoAtc#@\r\n#@AchievementMeAtcDlg|Open:AchievementMeAtcDlg#@\r\n#@AchievementMeDlg|Open:AchievementMeDlg#@\r\n#@AchievementOverviewDlg|Open:AchievementOverviewDlg#@\r\n#@AchievementShareDlg|Open:AchievementShareDlg#@\r\n#@AchievementTree|Open:AchievementTree#@\r\n#@AchievementTreeAtc|Open:AchievementTreeAtc#@\r\n#@AchieveTipsInfoDlg|Open:AchieveTipsInfoDlg#@\r\n#@AchieveTitleLevel|Open:AchieveTitleLevel#@\r\n#@AchievTrackDlg|Open:AchievTrackDlg#@\r\n#@ActionAni|Open:ActionAni#@\r\n#@ActivationDlg|Open:ActivationDlg#@\r\n#@ActivityXbssbDlg|Open:ActivityXbssbDlg#@\r\n#@ActorNpc|Open:ActorNpc#@\r\n#@AlchemyDlg|Open:AlchemyDlg#@\r\n#@AllCity|Open:AllCity#@\r\n#@AllIsOkDlg|Open:AllIsOkDlg#@\r\n#@AllPropertyList|Open:AllPropertyList#@\r\n#@AllTaskDlg|Open:AllTaskDlg#@\r\n#@AlterPropNameDlg|Open:AlterPropNameDlg#@\r\n#@AngerDeltaDlg|Open:AngerDeltaDlg#@\r\n#@AniColorTypeCfg|Open:AniColorTypeCfg#@\r\n#@AnniversaryActivity|Open:AnniversaryActivity#@\r\n#@AnniversaryActivityDlg|Open:AnniversaryActivityDlg#@\r\n#@AnniversaryDlg|Open:AnniversaryDlg#@\r\n#@AnniversarySignDlg|Open:AnniversarySignDlg#@\r\n#@AnswerCfmDlg|Open:AnswerCfmDlg#@\r\n#@AnswerMiniDlg|Open:AnswerMiniDlg#@\r\n#@AntiBotDlg|Open:AntiBotDlg#@\r\n#@AntiBotDlg_1024_768|Open:AntiBotDlg_1024_768#@\r\n#@AntiBotPicSelectDlg|Open:AntiBotPicSelectDlg#@\r\n#@AntiBotPicSelectDlg_1024_768|Open:AntiBotPicSelectDlg_1024_768#@\r\n#@AntiBotReaffirmDlg|Open:AntiBotReaffirmDlg#@\r\n#@AntiBotReaffirmDlg_1024_768|Open:AntiBotReaffirmDlg_1024_768#@\r\n#@ApplyJoinTeamDlg|Open:ApplyJoinTeamDlg#@\r\n#@AppointRaidEffectDlg|Open:AppointRaidEffectDlg#@\r\n#@ArenaAgainstDlg|Open:ArenaAgainstDlg#@\r\n#@ArenaChannelDlg|Open:ArenaChannelDlg#@\r\n#@ArenaCharInfoDlg|Open:ArenaCharInfoDlg#@\r\n#@ArenaCreateRoomDlg|Open:ArenaCreateRoomDlg#@\r\n#@ArenaEntryDlg|Open:ArenaEntryDlg#@\r\n#@ArenaHallDlg|Open:ArenaHallDlg#@\r\n#@ArenaHallDlg_1024_768|Open:ArenaHallDlg_1024_768#@\r\n#@ArenaItemDlg|Open:ArenaItemDlg#@\r\n#@ArenaMatchingDlg|Open:ArenaMatchingDlg#@\r\n#@ArenaMatchingDlg_1024_768|Open:ArenaMatchingDlg_1024_768#@\r\n#@ArenaOtherMenuDlg|Open:ArenaOtherMenuDlg#@\r\n#@ArenaQuickJoinDlg|Open:ArenaQuickJoinDlg#@\r\n#@ArenaRaceHallDlg|Open:ArenaRaceHallDlg#@\r\n#@ArenaRaceHallDlg_1024_768|Open:ArenaRaceHallDlg_1024_768#@\r\n#@ArenaRaceRoomDlg|Open:ArenaRaceRoomDlg#@\r\n#@ArenaRaceRoomDlg_1024_768|Open:ArenaRaceRoomDlg_1024_768#@\r\n#@ArenaRoomDlg|Open:ArenaRoomDlg#@\r\n#@ArenaRoomDlg_1024_768|Open:ArenaRoomDlg_1024_768#@\r\n#@ArenaSelectDlg|Open:ArenaSelectDlg#@\r\n#@ArenaStoreDlg|Open:ArenaStoreDlg#@\r\n#@ArtifactDlg|Open:ArtifactDlg#@\r\n#@ArtifactTalkDlg|Open:ArtifactTalkDlg#@\r\n#@AskDlg|Open:AskDlg#@\r\n#@AskForBtnDlg|Open:AskForBtnDlg#@\r\n#@AssistentDlg|Open:AssistentDlg#@\r\n#@AstrologyBhDlg|Open:AstrologyBhDlg#@\r\n#@AstrologyDlgCfg|Open:AstrologyDlgCfg#@\r\n#@AstrologyQlDlg|Open:AstrologyQlDlg#@\r\n#@AstrologyXwDlg|Open:AstrologyXwDlg#@\r\n#@AstrologyZqDlg|Open:AstrologyZqDlg#@\r\n#@AtcAcceptCombatDlg|Open:AtcAcceptCombatDlg#@\r\n#@AtcActivityDeckDlg|Open:AtcActivityDeckDlg#@\r\n#@AtcActivityDlg|Open:AtcActivityDlg#@\r\n#@AtcAddNewHandDlg|Open:AtcAddNewHandDlg#@\r\n#@AtcArenaModeDlg|Open:AtcArenaModeDlg#@\r\n#@AtcBaseCardsDlg|Open:AtcBaseCardsDlg#@\r\n#@AtcCardInfoDlg|Open:AtcCardInfoDlg#@\r\n#@AtcChannelCtrlDlg|Open:AtcChannelCtrlDlg#@\r\n#@AtcChannelDlg|Open:AtcChannelDlg#@\r\n#@AtcChannelMsgQueryDlg|Open:AtcChannelMsgQueryDlg#@\r\n#@AtcChatEditDlg|Open:AtcChatEditDlg#@\r\n#@AtcChoiceDeckDlg|Open:AtcChoiceDeckDlg#@\r\n#@AtcChoiceHeroDlg|Open:AtcChoiceHeroDlg#@\r\n#@AtcDeckInfoDlg|Open:AtcDeckInfoDlg#@\r\n#@AtcDropCardDlg|Open:AtcDropCardDlg#@\r\n#@AtcDuelModeDlg|Open:AtcDuelModeDlg#@\r\n#@AtcFightChoiceCardDlg|Open:AtcFightChoiceCardDlg#@\r\n#@AtcFightChooseCardDlg|Open:AtcFightChooseCardDlg#@\r\n#@AtcFightHistoryDlg|Open:AtcFightHistoryDlg#@\r\n#@AtcFightHistoryInfoDlg|Open:AtcFightHistoryInfoDlg#@\r\n#@AtcFightInfoDlg|Open:AtcFightInfoDlg#@\r\n#@AtcFightMyCardDlg|Open:AtcFightMyCardDlg#@\r\n#@AtcFightOperDlg|Open:AtcFightOperDlg#@\r\n#@AtcFightOppoCardDlg|Open:AtcFightOppoCardDlg#@\r\n#@AtcFightOppoSklDlg|Open:AtcFightOppoSklDlg#@\r\n#@AtcFightPanButtonDlg|Open:AtcFightPanButtonDlg#@\r\n#@AtcFightResultDlg|Open:AtcFightResultDlg#@\r\n#@AtcFightShowCardDlg|Open:AtcFightShowCardDlg#@\r\n#@AtcFightUseCardDlg|Open:AtcFightUseCardDlg#@\r\n#@AtcFriendSetDlg|Open:AtcFriendSetDlg#@\r\n#@AtcGuideDlg|Open:AtcGuideDlg#@\r\n#@AtcGuideWar1|Open:AtcGuideWar1#@\r\n#@AtcGuideWar2|Open:AtcGuideWar2#@\r\n#@AtcMainDlg|Open:AtcMainDlg#@\r\n#@AtcMakeModeDlg|Open:AtcMakeModeDlg#@\r\n#@AtcMatchGameDlg|Open:AtcMatchGameDlg#@\r\n#@AtcMyCollectionDlg|Open:AtcMyCollectionDlg#@\r\n#@AtcOnlinemailDlg|Open:AtcOnlinemailDlg#@\r\n#@AtcPkModeDlg|Open:AtcPkModeDlg#@\r\n#@AtcQuickFindDlg|Open:AtcQuickFindDlg#@\r\n#@AtcRankDlg|Open:AtcRankDlg#@\r\n#@AtcRecommendCardDlg|Open:AtcRecommendCardDlg#@\r\n#@AtcSkills|Open:AtcSkills#@\r\n#@AtcSocChatDlg|Open:AtcSocChatDlg#@\r\n#@AtcSocGroupDlg|Open:AtcSocGroupDlg#@\r\n#@AtcSocHisDlg|Open:AtcSocHisDlg#@\r\n#@AtcSocInfoDlg|Open:AtcSocInfoDlg#@\r\n#@AtcSocMainDlg|Open:AtcSocMainDlg#@\r\n#@AtcSocRecvDlg|Open:AtcSocRecvDlg#@\r\n#@AtcSocSendDlg|Open:AtcSocSendDlg#@\r\n#@AtcSocSetDlg|Open:AtcSocSetDlg#@\r\n#@AtcSocStateDlg|Open:AtcSocStateDlg#@\r\n#@AtcSourceCardDlg|Open:AtcSourceCardDlg#@\r\n#@AtcSplitOrMakeDlg|Open:AtcSplitOrMakeDlg#@\r\n#@AtcSysExitDlg|Open:AtcSysExitDlg#@\r\n#@AtcSysSetDlg|Open:AtcSysSetDlg#@\r\n#@AtcTaskDlg|Open:AtcTaskDlg#@\r\n#@AtcTipInfoDlg|Open:AtcTipInfoDlg#@\r\n#@AtcTitleSelectDlg|Open:AtcTitleSelectDlg#@\r\n#@AtcTodayStateTipsInfoDlg|Open:AtcTodayStateTipsInfoDlg#@\r\n#@AtcUi|Open:AtcUi#@\r\n#@AtcViewCardSetDlg|Open:AtcViewCardSetDlg#@\r\n#@ATRadioDlg|Open:ATRadioDlg#@\r\n#@AttentAsktaoDlg|Open:AttentAsktaoDlg#@\r\n#@AutoFightConfigDlg|Open:AutoFightConfigDlg#@\r\n#@AutoFightDlg|Open:AutoFightDlg#@\r\n#@AutoFightItemDlg|Open:AutoFightItemDlg#@\r\n#@AutoFightSkillListDlg|Open:AutoFightSkillListDlg#@\r\n#@AutoMenu|Open:AutoMenu#@\r\n#@BagDlg|Open:BagDlg#@\r\n#@BankDlg|Open:BankDlg#@\r\n#@BasketDlg|Open:BasketDlg#@\r\n#@BatchBuyDlg|Open:BatchBuyDlg#@\r\n#@BattleFieldMemberDlg|Open:BattleFieldMemberDlg#@\r\n#@BirthdaySetDlg|Open:BirthdaySetDlg#@\r\n#@BlackWhiteChessDlg|Open:BlackWhiteChessDlg#@\r\n#@block_reason|Open:block_reason#@\r\n#@BlueItemSplitDlg|Open:BlueItemSplitDlg#@\r\n#@BoBingDlg|Open:BoBingDlg#@\r\n#@BoBingPvpDlg|Open:BoBingPvpDlg#@\r\n#@BoBingPvpMatchDlg|Open:BoBingPvpMatchDlg#@\r\n#@BoBingPvpPrepareDlg|Open:BoBingPvpPrepareDlg#@\r\n#@BookDlg|Open:BookDlg#@\r\n#@BoxAdventureDlg|Open:BoxAdventureDlg#@\r\n#@BpAddOrderDlg|Open:BpAddOrderDlg#@\r\n#@BpAliasList|Open:BpAliasList#@\r\n#@BpAllOrderDlg|Open:BpAllOrderDlg#@\r\n#@BpHisOrderDlg|Open:BpHisOrderDlg#@\r\n#@BpJewelryList|Open:BpJewelryList#@\r\n#@BpOrderDetailDlg|Open:BpOrderDetailDlg#@\r\n#@BpPersonalOrderDlg|Open:BpPersonalOrderDlg#@\r\n#@BpPetList|Open:BpPetList#@\r\n#@BpQuickSellDlg|Open:BpQuickSellDlg#@\r\n#@BpSellPetDlg|Open:BpSellPetDlg#@\r\n#@BpSpecialItemList|Open:BpSpecialItemList#@\r\n#@BpSysHisDlg|Open:BpSysHisDlg#@\r\n#@BpSysSellDlg|Open:BpSysSellDlg#@\r\n#@Brow|Open:Brow#@\r\n#@Brow2|Open:Brow2#@\r\n#@BrowListDlg|Open:BrowListDlg#@\r\n#@BrowserDlg|Open:BrowserDlg#@\r\n#@BubbleTipsDlg|Open:BubbleTipsDlg#@\r\n#@BuyAndSellGoodsDlg|Open:BuyAndSellGoodsDlg#@\r\n#@BuyFishingWeaponDlg|Open:BuyFishingWeaponDlg#@\r\n#@BuyItemDlg|Open:BuyItemDlg#@\r\n#@BuyMemberDlg|Open:BuyMemberDlg#@\r\n#@BuyPetDlg|Open:BuyPetDlg#@\r\n#@BuyPlatformList|Open:BuyPlatformList#@\r\n#@CalendarBrowerDlg|Open:CalendarBrowerDlg#@\r\n#@CalendarSystemDlg|Open:CalendarSystemDlg#@\r\n#@CallForPetDlg|Open:CallForPetDlg#@\r\n#@CangBaoGeDlg|Open:CangBaoGeDlg#@\r\n#@CangBaoGeRuleDlg|Open:CangBaoGeRuleDlg#@\r\n#@Card|Open:Card#@\r\n#@CardMemoryDlg|Open:CardMemoryDlg#@\r\n#@CardSetDlg|Open:CardSetDlg#@\r\n#@CardSheathDlg|Open:CardSheathDlg#@\r\n#@CardShopDlg|Open:CardShopDlg#@\r\n#@cards_info|Open:cards_info#@\r\n#@CasualWzqDlg|Open:CasualWzqDlg#@\r\n#@ChallengeDlg|Open:ChallengeDlg#@\r\n#@ChallengeDlgCfg|Open:ChallengeDlgCfg#@\r\n#@ChallengeMatchTopDlg|Open:ChallengeMatchTopDlg#@\r\n#@ChallengePetDlg|Open:ChallengePetDlg#@\r\n#@ChallengePlayerDlg|Open:ChallengePlayerDlg#@\r\n#@ChallengerInfoDlg|Open:ChallengerInfoDlg#@\r\n#@ChallengeTaskInfo|Open:ChallengeTaskInfo#@\r\n#@ChampionDlg|Open:ChampionDlg#@\r\n#@ChannelCtrlDlg|Open:ChannelCtrlDlg#@\r\n#@ChannelDlg|Open:ChannelDlg#@\r\n#@ChannelMsgQueryDlg|Open:ChannelMsgQueryDlg#@\r\n#@Char|Open:Char#@\r\n#@CharAbilityCalcDlg|Open:CharAbilityCalcDlg#@\r\n#@CharacterFightDlg|Open:CharacterFightDlg#@\r\n#@CharBalkDlg|Open:CharBalkDlg#@\r\n#@CharBalkShareDlg|Open:CharBalkShareDlg#@\r\n#@CharChoiceDlg|Open:CharChoiceDlg#@\r\n#@CharChoiceDlg_1024_768|Open:CharChoiceDlg_1024_768#@\r\n#@CharCreateDlg|Open:CharCreateDlg#@\r\n#@CharCreationDlg|Open:CharCreationDlg#@\r\n#@CharCreationDlg_1024_768|Open:CharCreationDlg_1024_768#@\r\n#@CharMeditationDlg|Open:CharMeditationDlg#@\r\n#@CharPolarDlg|Open:CharPolarDlg#@\r\n#@CharPolarShareDlg|Open:CharPolarShareDlg#@\r\n#@CharResistDlg|Open:CharResistDlg#@\r\n#@CharResistShareDlg|Open:CharResistShareDlg#@\r\n#@CharStatusShareDlg|Open:CharStatusShareDlg#@\r\n#@CharStatusShareExDlg|Open:CharStatusShareExDlg#@\r\n#@CharTipsInfoDlg|Open:CharTipsInfoDlg#@\r\n#@ChartStatusDlg|Open:ChartStatusDlg#@\r\n#@ChatAnnounceDlg|Open:ChatAnnounceDlg#@\r\n#@ChatEditDlg|Open:ChatEditDlg#@\r\n#@ChatEditDlg_1024_768|Open:ChatEditDlg_1024_768#@\r\n#@ChatGroupChatDlg|Open:ChatGroupChatDlg#@\r\n#@ChatGroupClaimDlg|Open:ChatGroupClaimDlg#@\r\n#@ChatGroupCreateDlg|Open:ChatGroupCreateDlg#@\r\n#@ChatGroupDlg|Open:ChatGroupDlg#@\r\n#@ChatGroupInfoDlg|Open:ChatGroupInfoDlg#@\r\n#@ChatGroupLogDlg|Open:ChatGroupLogDlg#@\r\n#@ChatGroupMemMgrDlg|Open:ChatGroupMemMgrDlg#@\r\n#@ChatGroupMgrDlg|Open:ChatGroupMgrDlg#@\r\n#@ChatGroupMsgDlg|Open:ChatGroupMsgDlg#@\r\n#@ChatGroupSearchDlg|Open:ChatGroupSearchDlg#@\r\n#@ChatGroupSettingDlg|Open:ChatGroupSettingDlg#@\r\n#@ChatGroupShortcutDlg|Open:ChatGroupShortcutDlg#@\r\n#@ChatGroupTipsInfoDlg|Open:ChatGroupTipsInfoDlg#@\r\n#@ChatRecordDlg|Open:ChatRecordDlg#@\r\n#@ChatRecordDlg_1024_768|Open:ChatRecordDlg_1024_768#@\r\n#@ChatToolDlg|Open:ChatToolDlg#@\r\n#@CheckCfmDlg|Open:CheckCfmDlg#@\r\n#@ChildAdventureDlg|Open:ChildAdventureDlg#@\r\n#@ChildApplyFightDlg|Open:ChildApplyFightDlg#@\r\n#@ChildBooksDlg|Open:ChildBooksDlg#@\r\n#@ChildCultivateDlg|Open:ChildCultivateDlg#@\r\n#@ChildCultivateQueryDlg|Open:ChildCultivateQueryDlg#@\r\n#@ChildDlg|Open:ChildDlg#@\r\n#@ChildEquipDlg|Open:ChildEquipDlg#@\r\n#@ChildExTitleDlg|Open:ChildExTitleDlg#@\r\n#@ChildFeedDlg|Open:ChildFeedDlg#@\r\n#@ChildFightAloneDlg|Open:ChildFightAloneDlg#@\r\n#@ChildFightDlg|Open:ChildFightDlg#@\r\n#@ChildFightInfoDlg|Open:ChildFightInfoDlg#@\r\n#@ChildFightMenuDlg|Open:ChildFightMenuDlg#@\r\n#@ChildGrowDlg|Open:ChildGrowDlg#@\r\n#@ChildInfoDlg|Open:ChildInfoDlg#@\r\n#@ChildListDlg|Open:ChildListDlg#@\r\n#@ChildMainDlg|Open:ChildMainDlg#@\r\n#@ChildMap|Open:ChildMap#@\r\n#@ChildMudDlg|Open:ChildMudDlg#@\r\n#@ChildPacketDlg|Open:ChildPacketDlg#@\r\n#@ChildResultDlg|Open:ChildResultDlg#@\r\n#@ChildScene|Open:ChildScene#@\r\n#@ChildSkillDlg|Open:ChildSkillDlg#@\r\n#@ChildSklLearnDlg|Open:ChildSklLearnDlg#@\r\n#@ChildTeamApplyDlg|Open:ChildTeamApplyDlg#@\r\n#@ChildTeamInfoDlg|Open:ChildTeamInfoDlg#@\r\n#@ChildTeamInviteDlg|Open:ChildTeamInviteDlg#@\r\n#@ChildTipsInfoDlg|Open:ChildTipsInfoDlg#@\r\n#@ChildTitle|Open:ChildTitle#@\r\n#@ChlgCfmDlg|Open:ChlgCfmDlg#@\r\n#@CityBuildingDlg|Open:CityBuildingDlg#@\r\n#@CityLimitDlg|Open:CityLimitDlg#@\r\n#@CityMap|Open:CityMap#@\r\n#@CityMapDlg|Open:CityMapDlg#@\r\n#@CityMapDlgShare|Open:CityMapDlgShare#@\r\n#@CityMapFightDlg|Open:CityMapFightDlg#@\r\n#@CityMapFightProgressDlg|Open:CityMapFightProgressDlg#@\r\n#@CityMapWalkObj|Open:CityMapWalkObj#@\r\n#@CityWorldMapDlg|Open:CityWorldMapDlg#@\r\n#@CityWorldSmallMapDlg|Open:CityWorldSmallMapDlg#@\r\n#@ClientServeCenterDlg|Open:ClientServeCenterDlg#@\r\n#@ClientTalkDlg|Open:ClientTalkDlg#@\r\n#@ClotheDlg|Open:ClotheDlg#@\r\n#@CodeProtectDlg|Open:CodeProtectDlg#@\r\n#@CodeProtectDlg_1024_768|Open:CodeProtectDlg_1024_768#@\r\n#@CoinBuyCfmDlg|Open:CoinBuyCfmDlg#@\r\n#@CoinBuyListDlg|Open:CoinBuyListDlg#@\r\n#@CoinExchangeHistoryDlg|Open:CoinExchangeHistoryDlg#@\r\n#@CoinOperationDlg|Open:CoinOperationDlg#@\r\n#@CoinPromotionDlg|Open:CoinPromotionDlg#@\r\n#@CoinQueryListDlg|Open:CoinQueryListDlg#@\r\n#@CoinSaleCfmDlg|Open:CoinSaleCfmDlg#@\r\n#@CoinSaleListDlg|Open:CoinSaleListDlg#@\r\n#@CoinSendListDlg|Open:CoinSendListDlg#@\r\n#@CoinWishDlg|Open:CoinWishDlg#@\r\n#@Color|Open:Color#@\r\n#@ColorExDlg|Open:ColorExDlg#@\r\n#@CombineModelMgr|Open:CombineModelMgr#@\r\n#@CompassDlg|Open:CompassDlg#@\r\n#@CompassExDlg|Open:CompassExDlg#@\r\n#@ConfirmationDlg|Open:ConfirmationDlg#@\r\n#@ConfirmBoxDlg|Open:ConfirmBoxDlg#@\r\n#@CookBookDlg|Open:CookBookDlg#@\r\n#@CookBookInfoDlg|Open:CookBookInfoDlg#@\r\n#@CorpsRoutArrayOptDlg|Open:CorpsRoutArrayOptDlg#@\r\n#@CorpsSiege|Open:CorpsSiege#@\r\n#@CorpsSiegeResultDlg|Open:CorpsSiegeResultDlg#@\r\n#@CorpsSiegeTempoDlg|Open:CorpsSiegeTempoDlg#@\r\n#@CorpsTrapDlg|Open:CorpsTrapDlg#@\r\n#@CountDownDlg|Open:CountDownDlg#@\r\n#@CountyMapDlg|Open:CountyMapDlg#@\r\n#@CoupletDlg|Open:CoupletDlg#@\r\n#@CoupletWriteDlg|Open:CoupletWriteDlg#@\r\n#@CrossDistFightDlg|Open:CrossDistFightDlg#@\r\n#@CrossDistPartyDlg|Open:CrossDistPartyDlg#@\r\n#@CrossDistShiDaoRankDlg|Open:CrossDistShiDaoRankDlg#@\r\n#@CrossDistWarSituationDlg|Open:CrossDistWarSituationDlg#@\r\n#@CrossWarItemDlg|Open:CrossWarItemDlg#@\r\n#@CrystalDlg|Open:CrystalDlg#@\r\n#@CurrChannelOnHeadDlg|Open:CurrChannelOnHeadDlg#@\r\n#@Curse|Open:Curse#@\r\n#@CustomTalkOperDlg|Open:CustomTalkOperDlg#@\r\n#@CutACaperDlg|Open:CutACaperDlg#@\r\n#@DailyActivities4T|Open:DailyActivities4T#@\r\n#@DailyActivityDlg|Open:DailyActivityDlg#@\r\n#@DailyActivityList|Open:DailyActivityList#@\r\n#@DailyAnswerDlg|Open:DailyAnswerDlg#@\r\n#@DailyLoopDlg|Open:DailyLoopDlg#@\r\n#@DarkChessDlg|Open:DarkChessDlg#@\r\n#@DataInputDefineDlg|Open:DataInputDefineDlg#@\r\n#@DeleteConfirmDlg|Open:DeleteConfirmDlg#@\r\n#@DevelopSkillLearnDlg|Open:DevelopSkillLearnDlg#@\r\n#@DiceDlg|Open:DiceDlg#@\r\n#@DictionaryDlg|Open:DictionaryDlg#@\r\n#@DirectFurnitureMakeDlg|Open:DirectFurnitureMakeDlg#@\r\n#@DirectUpSetDlg|Open:DirectUpSetDlg#@\r\n#@DiscoveryEvents|Open:DiscoveryEvents#@\r\n#@DiscoveryGames|Open:DiscoveryGames#@\r\n#@DiscoveryPlatformDlg|Open:DiscoveryPlatformDlg#@\r\n#@DiscoveryTipsInfoDlg|Open:DiscoveryTipsInfoDlg#@\r\n#@DiscoveryWaitingRoomDlg|Open:DiscoveryWaitingRoomDlg#@\r\n#@DiscoveryWorldMapDlg|Open:DiscoveryWorldMapDlg#@\r\n#@DiyPatternDlg|Open:DiyPatternDlg#@\r\n#@DiyPatternTemplet|Open:DiyPatternTemplet#@\r\n#@DlgHelp|Open:DlgHelp#@\r\n#@DlgMgr|Open:DlgMgr#@\r\n#@DlgMgrCfg|Open:DlgMgrCfg#@\r\n#@DlgMgrGMCfg|Open:DlgMgrGMCfg#@\r\n#@dlg_arrow|Open:dlg_arrow#@\r\n#@DoubleBonusTalkDlg|Open:DoubleBonusTalkDlg#@\r\n#@DraftHallDlg|Open:DraftHallDlg#@\r\n#@DraftRollDlg|Open:DraftRollDlg#@\r\n#@DraftSelfDlg|Open:DraftSelfDlg#@\r\n#@DramaDlg|Open:DramaDlg#@\r\n#@DramaDlg_1024_768|Open:DramaDlg_1024_768#@\r\n#@DriftDefaultMsg|Open:DriftDefaultMsg#@\r\n#@DrifterDlg|Open:DrifterDlg#@\r\n#@DrifterDropDlg|Open:DrifterDropDlg#@\r\n#@DrifterInfoDlg|Open:DrifterInfoDlg#@\r\n#@DrifterRcvDlg|Open:DrifterRcvDlg#@\r\n#@DrifterReplyDlg|Open:DrifterReplyDlg#@\r\n#@DrifterViewDlg|Open:DrifterViewDlg#@\r\n#@DshxDlg|Open:DshxDlg#@\r\n#@DshxRewardDlg|Open:DshxRewardDlg#@\r\n#@DuelAcceptDlg|Open:DuelAcceptDlg#@\r\n#@DuelMiniDlg|Open:DuelMiniDlg#@\r\n#@DuelSendDlg|Open:DuelSendDlg#@\r\n#@DuelStartDlg|Open:DuelStartDlg#@\r\n#@DuplicateDlg|Open:DuplicateDlg#@\r\n#@EatFish|Open:EatFish#@\r\n#@EatFishDlg|Open:EatFishDlg#@\r\n#@EatFishDlg_1024_768|Open:EatFishDlg_1024_768#@\r\n#@EatFishHelpDlg|Open:EatFishHelpDlg#@\r\n#@EatFishResultDlg|Open:EatFishResultDlg#@\r\n#@EchoProp|Open:EchoProp#@\r\n#@EditCfmDlg|Open:EditCfmDlg#@\r\n#@EditSkillTalkDlg|Open:EditSkillTalkDlg#@\r\n#@effect|Open:effect#@\r\n#@EffectEx|Open:EffectEx#@\r\n#@EffectSetDlg|Open:EffectSetDlg#@\r\n#@Emote|Open:Emote#@\r\n#@EmoteType|Open:EmoteType#@\r\n#@Emotion|Open:Emotion#@\r\n#@EncryptShareDlg|Open:EncryptShareDlg#@\r\n#@EndChallengeBtnDlg|Open:EndChallengeBtnDlg#@\r\n#@EndFlyPreviewDlg|Open:EndFlyPreviewDlg#@\r\n#@EntranceDlg|Open:EntranceDlg#@\r\n#@EntranceDlg_1024_768|Open:EntranceDlg_1024_768#@\r\n#@EquipAdvancedBaseDlg|Open:EquipAdvancedBaseDlg#@\r\n#@EquipInfoDlg|Open:EquipInfoDlg#@\r\n#@EquipInlayDlg|Open:EquipInlayDlg#@\r\n#@EquipInlayExDlg|Open:EquipInlayExDlg#@\r\n#@EquipmentDlg|Open:EquipmentDlg#@\r\n#@EquipPunchDlg|Open:EquipPunchDlg#@\r\n#@EquipPunchExDlg|Open:EquipPunchExDlg#@\r\n#@EquipStatusDlg|Open:EquipStatusDlg#@\r\n#@ErAliPayCodeDlg|Open:ErAliPayCodeDlg#@\r\n#@ErAliPayDlg|Open:ErAliPayDlg#@\r\n#@ErGuangyuCardDlg|Open:ErGuangyuCardDlg#@\r\n#@ErInternetBankDlg|Open:ErInternetBankDlg#@\r\n#@ErMobileRechargeCardDlg|Open:ErMobileRechargeCardDlg#@\r\n#@ErShareDlg|Open:ErShareDlg#@\r\n#@EuroCupGuessViewDlg|Open:EuroCupGuessViewDlg#@\r\n#@EvaluateTipDlg|Open:EvaluateTipDlg#@\r\n#@event|Open:event#@\r\n#@EventRecorded|Open:EventRecorded#@\r\n#@EventRecordedDlg|Open:EventRecordedDlg#@\r\n#@ExcAntiCheatTipDlg|Open:ExcAntiCheatTipDlg#@\r\n#@ExchangeDlg|Open:ExchangeDlg#@\r\n#@exp_to_next_level|Open:exp_to_next_level#@\r\n#@FamilyResMap|Open:FamilyResMap#@\r\n#@FangChenMiDlg|Open:FangChenMiDlg#@\r\n#@FeedDlg|Open:FeedDlg#@\r\n#@FeedDlgGeneral|Open:FeedDlgGeneral#@\r\n#@FestivalActivities4T|Open:FestivalActivities4T#@\r\n#@FetchMoneyDlg|Open:FetchMoneyDlg#@\r\n#@FightCallForChildDlg|Open:FightCallForChildDlg#@\r\n#@FightCallForPetDlg|Open:FightCallForPetDlg#@\r\n#@FightCampDlg|Open:FightCampDlg#@\r\n#@FightDrama|Open:FightDrama#@\r\n#@FightLookMenuDlg|Open:FightLookMenuDlg#@\r\n#@FightLookOperDlg|Open:FightLookOperDlg#@\r\n#@FightMeMenuDlg|Open:FightMeMenuDlg#@\r\n#@FightMePrDlg|Open:FightMePrDlg#@\r\n#@FightMeStatusDlg|Open:FightMeStatusDlg#@\r\n#@FightObjDlg|Open:FightObjDlg#@\r\n#@FightObjectStatusTipsDlg|Open:FightObjectStatusTipsDlg#@\r\n#@FightPetMenuDlg|Open:FightPetMenuDlg#@\r\n#@FightPetPrDlg|Open:FightPetPrDlg#@\r\n#@FightPetStatusDlg|Open:FightPetStatusDlg#@\r\n#@FightPos|Open:FightPos#@\r\n#@FightPos_1024_768|Open:FightPos_1024_768#@\r\n#@FightScheduleDlg|Open:FightScheduleDlg#@\r\n#@FightScoreDlg|Open:FightScoreDlg#@\r\n#@FightSkillDescDlg|Open:FightSkillDescDlg#@\r\n#@FightSkillListDlg|Open:FightSkillListDlg#@\r\n#@FightSpeedDlg|Open:FightSpeedDlg#@\r\n#@FightStatus|Open:FightStatus#@\r\n#@FightTalkMenuDlg|Open:FightTalkMenuDlg#@\r\n#@FightTargetDlg|Open:FightTargetDlg#@\r\n#@fight_test|Open:fight_test#@\r\n#@Figure|Open:Figure#@\r\n#@Filter|Open:Filter#@\r\n#@FilterTip|Open:FilterTip#@\r\n#@FindBackCfmDlg|Open:FindBackCfmDlg#@\r\n#@FindPathMenu|Open:FindPathMenu#@\r\n#@FindStoneOperDlg|Open:FindStoneOperDlg#@\r\n#@FishingDlg|Open:FishingDlg#@\r\n#@FishingDlg_1024_768|Open:FishingDlg_1024_768#@\r\n#@FishingPoolDlg|Open:FishingPoolDlg#@\r\n#@FishingPoolDlg_1024_768|Open:FishingPoolDlg_1024_768#@\r\n#@FlowerBasket|Open:FlowerBasket#@\r\n#@FlyDlg|Open:FlyDlg#@\r\n#@font|Open:font#@\r\n#@FriendDeliverCfmDlg|Open:FriendDeliverCfmDlg#@\r\n#@FriendDeliverDlg|Open:FriendDeliverDlg#@\r\n#@FriendDrinkDlg|Open:FriendDrinkDlg#@\r\n#@FriendSetDlg|Open:FriendSetDlg#@\r\n#@frontinfo|Open:frontinfo#@\r\n#@FurnitureBagDlg|Open:FurnitureBagDlg#@\r\n#@FurnitureDisplayDlg|Open:FurnitureDisplayDlg#@\r\n#@FurnitureInfo|Open:FurnitureInfo#@\r\n#@FurnitureMakeDlg|Open:FurnitureMakeDlg#@\r\n#@FurnitureRepairDlg|Open:FurnitureRepairDlg#@\r\n#@FurnitureShapeInfo|Open:FurnitureShapeInfo#@\r\n#@GaiZaoLingDlg|Open:GaiZaoLingDlg#@\r\n#@GamblingDlg|Open:GamblingDlg#@\r\n#@GameExitDlg|Open:GameExitDlg#@\r\n#@GameRecommendDlg|Open:GameRecommendDlg#@\r\n#@GatherHerbsDlg|Open:GatherHerbsDlg#@\r\n#@gather_pos|Open:gather_pos#@\r\n#@GCSLDlg|Open:GCSLDlg#@\r\n#@GeneralActivityDlg|Open:GeneralActivityDlg#@\r\n#@Gfsg7Items|Open:Gfsg7Items#@\r\n#@Gfsg7ItemsNew|Open:Gfsg7ItemsNew#@\r\n#@Gfsg7PetAndItems|Open:Gfsg7PetAndItems#@\r\n#@Gfsg8ItemsNew|Open:Gfsg8ItemsNew#@\r\n#@GfsgArtifactCombineDlg|Open:GfsgArtifactCombineDlg#@\r\n#@GfsgArtifactFengyinDlg|Open:GfsgArtifactFengyinDlg#@\r\n#@GfsgArtifactHomeDlg|Open:GfsgArtifactHomeDlg#@\r\n#@GfsgArtifactInheritDlg|Open:GfsgArtifactInheritDlg#@\r\n#@GfsgArtifactIntimacyDlg|Open:GfsgArtifactIntimacyDlg#@\r\n#@GfsgArtifactSealTransDlg|Open:GfsgArtifactSealTransDlg#@\r\n#@GfsgArtifactSkillUpDlg|Open:GfsgArtifactSkillUpDlg#@\r\n#@GfsgAutoConfirmDlg|Open:GfsgAutoConfirmDlg#@\r\n#@GfsgBack1|Open:GfsgBack1#@\r\n#@GfsgBack2|Open:GfsgBack2#@\r\n#@GfsgBack3|Open:GfsgBack3#@\r\n#@GfsgBack4|Open:GfsgBack4#@\r\n#@GfsgBaseDlg|Open:GfsgBaseDlg#@\r\n#@GfsgBaseDlgEx|Open:GfsgBaseDlgEx#@\r\n#@GfsgClxRefineGreenDlg|Open:GfsgClxRefineGreenDlg#@\r\n#@GfsgDirectGreekSwitchDlg|Open:GfsgDirectGreekSwitchDlg#@\r\n#@GfsgDirectItemUpDlg|Open:GfsgDirectItemUpDlg#@\r\n#@GfsgDirectPetDunWuDlg|Open:GfsgDirectPetDunWuDlg#@\r\n#@GfsgDirectPetFuseDlg|Open:GfsgDirectPetFuseDlg#@\r\n#@GfsgDirectRefineDlg|Open:GfsgDirectRefineDlg#@\r\n#@GfsgOnceRefineGreenDlg|Open:GfsgOnceRefineGreenDlg#@\r\n#@GfsgPackage|Open:GfsgPackage#@\r\n#@GfsgPackageEx|Open:GfsgPackageEx#@\r\n#@GfsgPetCittaDlg|Open:GfsgPetCittaDlg#@\r\n#@GfsgPetComposeStoneDlg|Open:GfsgPetComposeStoneDlg#@\r\n#@GfsgPetDunWuDlg|Open:GfsgPetDunWuDlg#@\r\n#@GfsgPetEnchantDlg|Open:GfsgPetEnchantDlg#@\r\n#@GfsgPetEvolutionDlg|Open:GfsgPetEvolutionDlg#@\r\n#@GfsgPetExBaseDlg|Open:GfsgPetExBaseDlg#@\r\n#@GfsgPetFuseDlg|Open:GfsgPetFuseDlg#@\r\n#@GfsgPetGreekEnhanceDlg|Open:GfsgPetGreekEnhanceDlg#@\r\n#@GfsgPetGreekInheritDlg|Open:GfsgPetGreekInheritDlg#@\r\n#@GfsgPetGreekMeltDlg|Open:GfsgPetGreekMeltDlg#@\r\n#@GfsgPetGreekSwitchDlg|Open:GfsgPetGreekSwitchDlg#@\r\n#@GfsgPetHomeDlg|Open:GfsgPetHomeDlg#@\r\n#@GfsgPetIntimacyDlg|Open:GfsgPetIntimacyDlg#@\r\n#@GfsgPetLieQuHunShouDlg|Open:GfsgPetLieQuHunShouDlg#@\r\n#@GfsgPetList|Open:GfsgPetList#@\r\n#@GfsgPetListEx|Open:GfsgPetListEx#@\r\n#@GfsgPetPutInStoneDlg|Open:GfsgPetPutInStoneDlg#@\r\n#@GfsgPetReinforceDlg|Open:GfsgPetReinforceDlg#@\r\n#@GfsgPetReinforceLevelDlg|Open:GfsgPetReinforceLevelDlg#@\r\n#@GfsgPetRemoveStoneDlg|Open:GfsgPetRemoveStoneDlg#@\r\n#@GfsgPetSoulStoneUpDlg|Open:GfsgPetSoulStoneUpDlg#@\r\n#@GfsgPetTransformDlg|Open:GfsgPetTransformDlg#@\r\n#@GfsgPetYuHuaDlg|Open:GfsgPetYuHuaDlg#@\r\n#@GfsgSsDirectRefineDlg|Open:GfsgSsDirectRefineDlg#@\r\n#@GfsgSsjgComposeDlg|Open:GfsgSsjgComposeDlg#@\r\n#@GfsgSsjgHomeDlg|Open:GfsgSsjgHomeDlg#@\r\n#@GfsgSsjgMakeDlg|Open:GfsgSsjgMakeDlg#@\r\n#@GfsgSsjgRefineSuitDlg|Open:GfsgSsjgRefineSuitDlg#@\r\n#@GfsgSsjgSwitchPropDlg|Open:GfsgSsjgSwitchPropDlg#@\r\n#@GfsgSsjgThreeInOneDlg|Open:GfsgSsjgThreeInOneDlg#@\r\n#@GfsgSsjgUpgradeDlg|Open:GfsgSsjgUpgradeDlg#@\r\n#@GfsgTips|Open:GfsgTips#@\r\n#@GfsgTipsEx|Open:GfsgTipsEx#@\r\n#@GfsgWwzbComposeDlg|Open:GfsgWwzbComposeDlg#@\r\n#@GfsgWwzbEnhanceDlg|Open:GfsgWwzbEnhanceDlg#@\r\n#@GfsgWwzbHomeDlg|Open:GfsgWwzbHomeDlg#@\r\n#@GfsgWwzbSplitDlg|Open:GfsgWwzbSplitDlg#@\r\n#@GfsgWwzbThreeInOneDlg|Open:GfsgWwzbThreeInOneDlg#@\r\n#@GfsgZbdzAppraiseDlg|Open:GfsgZbdzAppraiseDlg#@\r\n#@GfsgZbdzHomeDlg|Open:GfsgZbdzHomeDlg#@\r\n#@GfsgZbdzItemDispartDlg|Open:GfsgZbdzItemDispartDlg#@\r\n#@GfsgZbdzItemUpDlg|Open:GfsgZbdzItemUpDlg#@\r\n#@GfsgZbdzPinkItemRefineDlg|Open:GfsgZbdzPinkItemRefineDlg#@\r\n#@GfsgZbdzRefineBlueDlg|Open:GfsgZbdzRefineBlueDlg#@\r\n#@GfsgZbdzRefineGoldDlg|Open:GfsgZbdzRefineGoldDlg#@\r\n#@GfsgZbdzRefineGreenDlg|Open:GfsgZbdzRefineGreenDlg#@\r\n#@GfsgZbdzRefinePinkDlg|Open:GfsgZbdzRefinePinkDlg#@\r\n#@GfsgZbdzSwitchEquipDlg|Open:GfsgZbdzSwitchEquipDlg#@\r\n#@GfsgZbjjBaseDlg|Open:GfsgZbjjBaseDlg#@\r\n#@GfsgZbjjEchoDlg|Open:GfsgZbjjEchoDlg#@\r\n#@GfsgZbjjEnhanceDlg|Open:GfsgZbjjEnhanceDlg#@\r\n#@GfsgZbjjEvolveDlg|Open:GfsgZbjjEvolveDlg#@\r\n#@GfsgZbjjFengyinDlg|Open:GfsgZbjjFengyinDlg#@\r\n#@GfsgZbjjInlayDlg|Open:GfsgZbjjInlayDlg#@\r\n#@GfsgZbjjInlayLevelDlg|Open:GfsgZbjjInlayLevelDlg#@\r\n#@GfsgZbjjSplitInlayDlg|Open:GfsgZbjjSplitInlayDlg#@\r\n#@GfsgZbjjWitherDlg|Open:GfsgZbjjWitherDlg#@\r\n#@GiftBagTipDlg|Open:GiftBagTipDlg#@\r\n#@GiftsDlg|Open:GiftsDlg#@\r\n#@GMAccountListDlg|Open:GMAccountListDlg#@\r\n#@GMAccountOperDlg|Open:GMAccountOperDlg#@\r\n#@GMActivityDlg|Open:GMActivityDlg#@\r\n#@GMAntiCheatDlg|Open:GMAntiCheatDlg#@\r\n#@GMAtcCardGroupListDlg|Open:GMAtcCardGroupListDlg#@\r\n#@GMAtcCharOperDataDlg|Open:GMAtcCharOperDataDlg#@\r\n#@GMAtcCharScoreQryDlg|Open:GMAtcCharScoreQryDlg#@\r\n#@GMAtcInfoListDlg|Open:GMAtcInfoListDlg#@\r\n#@GMBlockNameDlg|Open:GMBlockNameDlg#@\r\n#@GMBoardDlg|Open:GMBoardDlg#@\r\n#@GMBonusListDlg|Open:GMBonusListDlg#@\r\n#@GMBonusOperationDlg|Open:GMBonusOperationDlg#@\r\n#@GMBonusQueryDlg|Open:GMBonusQueryDlg#@\r\n#@GMBonusSetDlg|Open:GMBonusSetDlg#@\r\n#@GMCfmDlg|Open:GMCfmDlg#@\r\n#@GMCharAccountQryDlg|Open:GMCharAccountQryDlg#@\r\n#@GMCharAttrDlg|Open:GMCharAttrDlg#@\r\n#@GMCharBlockDlg|Open:GMCharBlockDlg#@\r\n#@GMCharIpQryDlg|Open:GMCharIpQryDlg#@\r\n#@GMCharJailDlg|Open:GMCharJailDlg#@\r\n#@GMCharLevelQryDlg|Open:GMCharLevelQryDlg#@\r\n#@GMCharListDlg|Open:GMCharListDlg#@\r\n#@GMCharMacQryDlg|Open:GMCharMacQryDlg#@\r\n#@GMCharMoneyQryDlg|Open:GMCharMoneyQryDlg#@\r\n#@GMCharNameQryDlg|Open:GMCharNameQryDlg#@\r\n#@GMCharOperDataDlg|Open:GMCharOperDataDlg#@\r\n#@GMCharOperDlg|Open:GMCharOperDlg#@\r\n#@GMCharOperExDlg|Open:GMCharOperExDlg#@\r\n#@GMCharOperGmDlg|Open:GMCharOperGmDlg#@\r\n#@GMCharOperSpecialDlg|Open:GMCharOperSpecialDlg#@\r\n#@GMCharQryDlg|Open:GMCharQryDlg#@\r\n#@GMCharQuietDlg|Open:GMCharQuietDlg#@\r\n#@GMCharQuotaDlg|Open:GMCharQuotaDlg#@\r\n#@GMCharRestrictDlg|Open:GMCharRestrictDlg#@\r\n#@GMCharSendMsgDlg|Open:GMCharSendMsgDlg#@\r\n#@GMCharShowDlg|Open:GMCharShowDlg#@\r\n#@GMCharSklDlg|Open:GMCharSklDlg#@\r\n#@GMCharSpyDlg|Open:GMCharSpyDlg#@\r\n#@GMCharTaoQryDlg|Open:GMCharTaoQryDlg#@\r\n#@GMCharTaskQryDlg|Open:GMCharTaskQryDlg#@\r\n#@GMCharTiaoliaoDlg|Open:GMCharTiaoliaoDlg#@\r\n#@GMCharWarnDlg|Open:GMCharWarnDlg#@\r\n#@GMCheckResourceDlg|Open:GMCheckResourceDlg#@\r\n#@GMCmdRecordDlg|Open:GMCmdRecordDlg#@\r\n#@GMCollectDlg|Open:GMCollectDlg#@\r\n#@GMCollectOperationDlg|Open:GMCollectOperationDlg#@\r\n#@GMCommonBlockReasonDlg|Open:GMCommonBlockReasonDlg#@\r\n#@GMCustomLaoJunDlg|Open:GMCustomLaoJunDlg#@\r\n#@GMDlgMgr|Open:GMDlgMgr#@\r\n#@GMDoubleBonusDlg|Open:GMDoubleBonusDlg#@\r\n#@GMDoubtInfoDlg|Open:GMDoubtInfoDlg#@\r\n#@GMEquipPropDlg|Open:GMEquipPropDlg#@\r\n#@GMFestalActionDlg|Open:GMFestalActionDlg#@\r\n#@GMFestalDlg|Open:GMFestalDlg#@\r\n#@GMFestalListDlg|Open:GMFestalListDlg#@\r\n#@GMFetchBonusDlg|Open:GMFetchBonusDlg#@\r\n#@GMFetchBonusListDlg|Open:GMFetchBonusListDlg#@\r\n#@GMGameActivityDlg|Open:GMGameActivityDlg#@\r\n#@GMGameActivityOpSingleDlg|Open:GMGameActivityOpSingleDlg#@\r\n#@GMGIDDlg|Open:GMGIDDlg#@\r\n#@GMIpDlg|Open:GMIpDlg#@\r\n#@GMIpStatisticsDlg|Open:GMIpStatisticsDlg#@\r\n#@GMLaoJunDlg|Open:GMLaoJunDlg#@\r\n#@GMLeaderNpcDlg|Open:GMLeaderNpcDlg#@\r\n#@GMLoginBoardDlg|Open:GMLoginBoardDlg#@\r\n#@GMMacDlg|Open:GMMacDlg#@\r\n#@GMMacStatisticsDlg|Open:GMMacStatisticsDlg#@\r\n#@GMMainDlg|Open:GMMainDlg#@\r\n#@GMMapCoordDlg|Open:GMMapCoordDlg#@\r\n#@GMMapListDlg|Open:GMMapListDlg#@\r\n#@GMMapNameQryDlg|Open:GMMapNameQryDlg#@\r\n#@GMMapObstacleListDlg|Open:GMMapObstacleListDlg#@\r\n#@GMMapOperDlg|Open:GMMapOperDlg#@\r\n#@GMMapQryDlg|Open:GMMapQryDlg#@\r\n#@GMMapTeleportDlg|Open:GMMapTeleportDlg#@\r\n#@GMMeOperDlg|Open:GMMeOperDlg#@\r\n#@GMModuleListDlg|Open:GMModuleListDlg#@\r\n#@GMModuleOperDlg|Open:GMModuleOperDlg#@\r\n#@GMModuleQryDlg|Open:GMModuleQryDlg#@\r\n#@GMMsgBroadDlg|Open:GMMsgBroadDlg#@\r\n#@GMMsgListDlg|Open:GMMsgListDlg#@\r\n#@GMMsgModDlg|Open:GMMsgModDlg#@\r\n#@GMMsgPreDlg|Open:GMMsgPreDlg#@\r\n#@GMMsgSysDlg|Open:GMMsgSysDlg#@\r\n#@GMMsgTypeDlg|Open:GMMsgTypeDlg#@\r\n#@GMMysteryTreasureDlg|Open:GMMysteryTreasureDlg#@\r\n#@GMMysteryTreasureOperationDlg|Open:GMMysteryTreasureOperationDlg#@\r\n#@GMNpcListDlg|Open:GMNpcListDlg#@\r\n#@GMNpcLocDlg|Open:GMNpcLocDlg#@\r\n#@GMNpcMapQryDlg|Open:GMNpcMapQryDlg#@\r\n#@GMNpcNameQryDlg|Open:GMNpcNameQryDlg#@\r\n#@GMNpcOperDlg|Open:GMNpcOperDlg#@\r\n#@GMNpcQryDlg|Open:GMNpcQryDlg#@\r\n#@GMNpcSetIconDlg|Open:GMNpcSetIconDlg#@\r\n#@GMOperateNpcDlg|Open:GMOperateNpcDlg#@\r\n#@GMOtherBonusListDlg|Open:GMOtherBonusListDlg#@\r\n#@GMProcessInfoDlg|Open:GMProcessInfoDlg#@\r\n#@GMProcessListDlg|Open:GMProcessListDlg#@\r\n#@GMProcessOperDlg|Open:GMProcessOperDlg#@\r\n#@GMQueryResultDlg|Open:GMQueryResultDlg#@\r\n#@GMRecordAddDlg|Open:GMRecordAddDlg#@\r\n#@GMRecordDlg|Open:GMRecordDlg#@\r\n#@GMRecordListForAccountDlg|Open:GMRecordListForAccountDlg#@\r\n#@GMRecordListForCharDlg|Open:GMRecordListForCharDlg#@\r\n#@GMServerInfoDlg|Open:GMServerInfoDlg#@\r\n#@GMServerQryDlg|Open:GMServerQryDlg#@\r\n#@GMServerStatusDlg|Open:GMServerStatusDlg#@\r\n#@GMServerVerionDlg|Open:GMServerVerionDlg#@\r\n#@GMStatusAniDlg|Open:GMStatusAniDlg#@\r\n#@GMSuperBlackCrystalDlg|Open:GMSuperBlackCrystalDlg#@\r\n#@GMSysActListDlg|Open:GMSysActListDlg#@\r\n#@GMSysBoardDlg|Open:GMSysBoardDlg#@\r\n#@GMSysBonusAddDlg|Open:GMSysBonusAddDlg#@\r\n#@GMSysBonusDlg|Open:GMSysBonusDlg#@\r\n#@GMSysBonusListDlg|Open:GMSysBonusListDlg#@\r\n#@GMSysBonusMainDlg|Open:GMSysBonusMainDlg#@\r\n#@GMSysDistLoginDlg|Open:GMSysDistLoginDlg#@\r\n#@GMSysGmListDlg|Open:GMSysGmListDlg#@\r\n#@GMSysInfoDlg|Open:GMSysInfoDlg#@\r\n#@GMSysLocalLoginDlg|Open:GMSysLocalLoginDlg#@\r\n#@GMSysLoginCfmDlg|Open:GMSysLoginCfmDlg#@\r\n#@GMSysLoginDlg|Open:GMSysLoginDlg#@\r\n#@GMSysRebootCfmDlg|Open:GMSysRebootCfmDlg#@\r\n#@GMSysScriptListDlg|Open:GMSysScriptListDlg#@\r\n#@GMSysScriptMainDlg|Open:GMSysScriptMainDlg#@\r\n#@GMSysScriptOperDlg|Open:GMSysScriptOperDlg#@\r\n#@GMSysScriptSearchDlg|Open:GMSysScriptSearchDlg#@\r\n#@GMSysServerDlg|Open:GMSysServerDlg#@\r\n#@GMTestAcrossMapDlg|Open:GMTestAcrossMapDlg#@\r\n#@GMTestAutoConvey|Open:GMTestAutoConvey#@\r\n#@GMTestAutoFightDlg|Open:GMTestAutoFightDlg#@\r\n#@GMTestBankDlg|Open:GMTestBankDlg#@\r\n#@GMTestBuySaleDlg|Open:GMTestBuySaleDlg#@\r\n#@GMTestMarketDlg|Open:GMTestMarketDlg#@\r\n#@GMTestMarketResultDlg|Open:GMTestMarketResultDlg#@\r\n#@GMTestOnlyDlg|Open:GMTestOnlyDlg#@\r\n#@GMTorchActionDlg|Open:GMTorchActionDlg#@\r\n#@GMTorchOperDlg|Open:GMTorchOperDlg#@\r\n#@GMWndOpDlg|Open:GMWndOpDlg#@\r\n#@GodBookDlg|Open:GodBookDlg#@\r\n#@GodBookPropSelectDlg|Open:GodBookPropSelectDlg#@\r\n#@GreenProp|Open:GreenProp#@\r\n#@GuardDlg|Open:GuardDlg#@\r\n#@GuardSkillDlg|Open:GuardSkillDlg#@\r\n#@GuardTipsInfoDlg|Open:GuardTipsInfoDlg#@\r\n#@GuardTowerDlg|Open:GuardTowerDlg#@\r\n#@GuardTowerMainDlg|Open:GuardTowerMainDlg#@\r\n#@GuardTowerResultDlg|Open:GuardTowerResultDlg#@\r\n#@GuessEleAnimalsDlg|Open:GuessEleAnimalsDlg#@\r\n#@GuideDramaDlg|Open:GuideDramaDlg#@\r\n#@GuideTipDlg|Open:GuideTipDlg#@\r\n#@GYCardInfoInputDlg|Open:GYCardInfoInputDlg#@\r\n#@GYCardTradeDlg|Open:GYCardTradeDlg#@\r\n#@HappyNewYearDlg|Open:HappyNewYearDlg#@\r\n#@HawkeyeSearchDlg|Open:HawkeyeSearchDlg#@\r\n#@HellGuide|Open:HellGuide#@\r\n#@HellGuideDlg|Open:HellGuideDlg#@\r\n#@HellItmTradeDlg|Open:HellItmTradeDlg#@\r\n#@HelpDlg|Open:HelpDlg#@\r\n#@HelpIndexDlg|Open:HelpIndexDlg#@\r\n#@HeTuLuoShuDlg|Open:HeTuLuoShuDlg#@\r\n#@HornChatRecordDlg|Open:HornChatRecordDlg#@\r\n#@HornChatRecordDlg_1024_768|Open:HornChatRecordDlg_1024_768#@\r\n#@HotKeySetDlg|Open:HotKeySetDlg#@\r\n#@HouseMgrDlg|Open:HouseMgrDlg#@\r\n#@HouseViewDlg|Open:HouseViewDlg#@\r\n#@HouseViewDlg_1024_768|Open:HouseViewDlg_1024_768#@\r\n#@house_feicuizhuangyuan|Open:house_feicuizhuangyuan#@\r\n#@house_haohuajusuo|Open:house_haohuajusuo#@\r\n#@house_huayuanbieshu|Open:house_huayuanbieshu#@\r\n#@house_youyaxiaoju|Open:house_youyaxiaoju#@\r\n#@HsslBossChooseDlg|Open:HsslBossChooseDlg#@\r\n#@HsslMapDlg|Open:HsslMapDlg#@\r\n#@HunShouShiDlg|Open:HunShouShiDlg#@\r\n#@Hunt|Open:Hunt#@\r\n#@HuntDlg|Open:HuntDlg#@\r\n#@HuntDlg_1024_768|Open:HuntDlg_1024_768#@\r\n#@Hunt_1024|Open:Hunt_1024#@\r\n#@IcChooseFormDlg|Open:IcChooseFormDlg#@\r\n#@IcHorFormDlg|Open:IcHorFormDlg#@\r\n#@IcShareDlg|Open:IcShareDlg#@\r\n#@IcVerFormDlg|Open:IcVerFormDlg#@\r\n#@ImageTipsDlg|Open:ImageTipsDlg#@\r\n#@InteractionCenterDlg|Open:InteractionCenterDlg#@\r\n#@interface_tip|Open:interface_tip#@\r\n#@InvalidRect|Open:InvalidRect#@\r\n#@InviterDlg|Open:InviterDlg#@\r\n#@IpBoundDlg|Open:IpBoundDlg#@\r\n#@IpCheckDlg|Open:IpCheckDlg#@\r\n#@IpWarnDlg|Open:IpWarnDlg#@\r\n#@Item|Open:Item#@\r\n#@ItemGoldCompDlg|Open:ItemGoldCompDlg#@\r\n#@ItemPillDlg|Open:ItemPillDlg#@\r\n#@ItemTradeExDlg|Open:ItemTradeExDlg#@\r\n#@item_desc|Open:item_desc#@\r\n#@item_help|Open:item_help#@\r\n#@item_tips|Open:item_tips#@\r\n#@ItmExcDlg|Open:ItmExcDlg#@\r\n#@ItmInfoDlg|Open:ItmInfoDlg#@\r\n#@ItmInfoDlg1|Open:ItmInfoDlg1#@\r\n#@ItmInfoDlg2|Open:ItmInfoDlg2#@\r\n#@ItmStoreDlg|Open:ItmStoreDlg#@\r\n#@ItmTradeDlg|Open:ItmTradeDlg#@\r\n#@JadeDlg|Open:JadeDlg#@\r\n#@JewelrySuitProp|Open:JewelrySuitProp#@\r\n#@JigsawDlg|Open:JigsawDlg#@\r\n#@JoinFightDlg|Open:JoinFightDlg#@\r\n#@LaoJunCodeDlg|Open:LaoJunCodeDlg#@\r\n#@LaoJunSelectItemDlg|Open:LaoJunSelectItemDlg#@\r\n#@LaoJunSliderDlg|Open:LaoJunSliderDlg#@\r\n#@LatestRecommandDlg|Open:LatestRecommandDlg#@\r\n#@latestrecommend|Open:latestrecommend#@\r\n#@LeaderNPCDlg|Open:LeaderNPCDlg#@\r\n#@LeagueCommonDlg|Open:LeagueCommonDlg#@\r\n#@LeagueReceiveDlg|Open:LeagueReceiveDlg#@\r\n#@LeagueSendDlg|Open:LeagueSendDlg#@\r\n#@LeagueSendViewDlg|Open:LeagueSendViewDlg#@\r\n#@LeisureGameDlg|Open:LeisureGameDlg#@\r\n#@LgxyCountDownDlg|Open:LgxyCountDownDlg#@\r\n#@LimitChatTipsDlg|Open:LimitChatTipsDlg#@\r\n#@LineChoiceDlg|Open:LineChoiceDlg#@\r\n#@LineChoiceDlg_1024_768|Open:LineChoiceDlg_1024_768#@\r\n#@LineChoiceExDlg|Open:LineChoiceExDlg#@\r\n#@LineChoiceExDlg_1024_768|Open:LineChoiceExDlg_1024_768#@\r\n#@LinkPageDlg|Open:LinkPageDlg#@\r\n#@LocalEncryptDlg|Open:LocalEncryptDlg#@\r\n#@LoginChangeProtectDlg|Open:LoginChangeProtectDlg#@\r\n#@LoginChangePwdDlg|Open:LoginChangePwdDlg#@\r\n#@LoginDlg|Open:LoginDlg#@\r\n#@LogSrvInfoDlg|Open:LogSrvInfoDlg#@\r\n#@LookForPetDlg|Open:LookForPetDlg#@\r\n#@LookingForMemberDlg|Open:LookingForMemberDlg#@\r\n#@LookingForTeamDlg|Open:LookingForTeamDlg#@\r\n#@LookingForTeamShare|Open:LookingForTeamShare#@\r\n#@LookonMainDlg|Open:LookonMainDlg#@\r\n#@LookonTipDlg|Open:LookonTipDlg#@\r\n#@LotteryDlg|Open:LotteryDlg#@\r\n#@LotteryTicketDlg|Open:LotteryTicketDlg#@\r\n#@LotteryTicketNewDlg|Open:LotteryTicketNewDlg#@\r\n#@LuaDlgCfg|Open:LuaDlgCfg#@\r\n#@LuckeyTurnItem|Open:LuckeyTurnItem#@\r\n#@MaBg1|Open:MaBg1#@\r\n#@MaBg2|Open:MaBg2#@\r\n#@MaFindApprenticeDlg|Open:MaFindApprenticeDlg#@\r\n#@MaFindMasterDlg|Open:MaFindMasterDlg#@\r\n#@Magic|Open:Magic#@\r\n#@MagicStoneAwardDlg|Open:MagicStoneAwardDlg#@\r\n#@MagicStoneList|Open:MagicStoneList#@\r\n#@MagicUIDlg|Open:MagicUIDlg#@\r\n#@MainInterfaceDlg|Open:MainInterfaceDlg#@\r\n#@MainLineTask|Open:MainLineTask#@\r\n#@MainLineTaskDlg|Open:MainLineTaskDlg#@\r\n#@MainMenuDlg|Open:MainMenuDlg#@\r\n#@MakeUpTeamDlg|Open:MakeUpTeamDlg#@\r\n#@MaOperDlg|Open:MaOperDlg#@\r\n#@MapFragmentDlg|Open:MapFragmentDlg#@\r\n#@MapGuide|Open:MapGuide#@\r\n#@MapGuideDlg|Open:MapGuideDlg#@\r\n#@MapGuideIconDlg|Open:MapGuideIconDlg#@\r\n#@MapNames|Open:MapNames#@\r\n#@MapNpcDlg|Open:MapNpcDlg#@\r\n#@MapSetting|Open:MapSetting#@\r\n#@MapShadow|Open:MapShadow#@\r\n#@MaRequestDlg|Open:MaRequestDlg#@\r\n#@MarryBonusDlg|Open:MarryBonusDlg#@\r\n#@MarryGiftChooseDlg|Open:MarryGiftChooseDlg#@\r\n#@MarryGiftDlg|Open:MarryGiftDlg#@\r\n#@MarryNoticeDlg|Open:MarryNoticeDlg#@\r\n#@MarryStoreDlg|Open:MarryStoreDlg#@\r\n#@MemberStoreDlg|Open:MemberStoreDlg#@\r\n#@MenuItemDeliver|Open:MenuItemDeliver#@\r\n#@MessageVerifyDlg|Open:MessageVerifyDlg#@\r\n#@MingPai|Open:MingPai#@\r\n#@MisCfmDlg|Open:MisCfmDlg#@\r\n#@MisTipDlg|Open:MisTipDlg#@\r\n#@MoBalkDlg|Open:MoBalkDlg#@\r\n#@ModeSelectDlg|Open:ModeSelectDlg#@\r\n#@MoneyItemDepositDlg|Open:MoneyItemDepositDlg#@\r\n#@MoneyItemDlg|Open:MoneyItemDlg#@\r\n#@MoPolarDlg|Open:MoPolarDlg#@\r\n#@MoResistDlg|Open:MoResistDlg#@\r\n#@MoStatusDlg|Open:MoStatusDlg#@\r\n#@MountAbilityCalcDlg|Open:MountAbilityCalcDlg#@\r\n#@MountDlg|Open:MountDlg#@\r\n#@msg|Open:msg#@\r\n#@MudWarResultDlg|Open:MudWarResultDlg#@\r\n#@MusicDiyDlg|Open:MusicDiyDlg#@\r\n#@MusicListDlg|Open:MusicListDlg#@\r\n#@MusicRepositoryDlg|Open:MusicRepositoryDlg#@\r\n#@MuteCfmDlg|Open:MuteCfmDlg#@\r\n#@MuteListDlg|Open:MuteListDlg#@\r\n#@MysteryAwardDlg|Open:MysteryAwardDlg#@\r\n#@NewbieDramaListDlg|Open:NewbieDramaListDlg#@\r\n#@NewbieGiftBtnDlg|Open:NewbieGiftBtnDlg#@\r\n#@NewbieGiftDlg|Open:NewbieGiftDlg#@\r\n#@NewbieGuide|Open:NewbieGuide#@\r\n#@NewbieGuideDlg|Open:NewbieGuideDlg#@\r\n#@NewbieOperDlg|Open:NewbieOperDlg#@\r\n#@NewbieTip|Open:NewbieTip#@\r\n#@NewRankDlg|Open:NewRankDlg#@\r\n#@NewVersionGuide|Open:NewVersionGuide#@\r\n#@NewVersionGuideDlg|Open:NewVersionGuideDlg#@\r\n#@NewYearActivityDlg|Open:NewYearActivityDlg#@\r\n#@NoFluctuatePropItm|Open:NoFluctuatePropItm#@\r\n#@NominateDlg|Open:NominateDlg#@\r\n#@NormalCountDownDlg|Open:NormalCountDownDlg#@\r\n#@NoviceTipDlg|Open:NoviceTipDlg#@\r\n#@NpcCollectDlg|Open:NpcCollectDlg#@\r\n#@NpcGuideDlg|Open:NpcGuideDlg#@\r\n#@NpcSpeech|Open:NpcSpeech#@\r\n#@NpcTalkList|Open:NpcTalkList#@\r\n#@NpcTalkScene|Open:NpcTalkScene#@\r\n#@NullDlg|Open:NullDlg#@\r\n#@ObInSmallMap|Open:ObInSmallMap#@\r\n#@OffLineStallOptionDlg|Open:OffLineStallOptionDlg#@\r\n#@OlypicGuessInfoDlg|Open:OlypicGuessInfoDlg#@\r\n#@OlypicTopInfoDlg|Open:OlypicTopInfoDlg#@\r\n#@OnlineItemDesc|Open:OnlineItemDesc#@\r\n#@OnlineMallRebateDlg|Open:OnlineMallRebateDlg#@\r\n#@OnlineMarketClothesIcon|Open:OnlineMarketClothesIcon#@\r\n#@OnlineMarketplaceDlg|Open:OnlineMarketplaceDlg#@\r\n#@OnlineMarketplaceDlgBase|Open:OnlineMarketplaceDlgBase#@\r\n#@OptionalGiftsDlg|Open:OptionalGiftsDlg#@\r\n#@Order|Open:Order#@\r\n#@OrderItemList|Open:OrderItemList#@\r\n#@PackageClearClass|Open:PackageClearClass#@\r\n#@PackageClearDlg|Open:PackageClearDlg#@\r\n#@PanButtonDlg|Open:PanButtonDlg#@\r\n#@PanInfoDlg|Open:PanInfoDlg#@\r\n#@PanMeDlg|Open:PanMeDlg#@\r\n#@PanPetDlg|Open:PanPetDlg#@\r\n#@PanSkillDlg|Open:PanSkillDlg#@\r\n#@PanTeamDlg|Open:PanTeamDlg#@\r\n#@PanToolDlg|Open:PanToolDlg#@\r\n#@PanToolDlg_1024_768|Open:PanToolDlg_1024_768#@\r\n#@PartyActivity|Open:PartyActivity#@\r\n#@PartyActivityDlg|Open:PartyActivityDlg#@\r\n#@PartyCfmDlg|Open:PartyCfmDlg#@\r\n#@PartyCommandDlg|Open:PartyCommandDlg#@\r\n#@PartyFightChampionDlg|Open:PartyFightChampionDlg#@\r\n#@PartyFightProcessDlg|Open:PartyFightProcessDlg#@\r\n#@PartyFightRollDlg|Open:PartyFightRollDlg#@\r\n#@PartyFightTaxisDlg|Open:PartyFightTaxisDlg#@\r\n#@PartyIconDlg|Open:PartyIconDlg#@\r\n#@PartyIconSubmitDlg|Open:PartyIconSubmitDlg#@\r\n#@PartyInfoDlg|Open:PartyInfoDlg#@\r\n#@PartyLogDlg|Open:PartyLogDlg#@\r\n#@PartyMemberDlg|Open:PartyMemberDlg#@\r\n#@PartyMemberInfoDlg|Open:PartyMemberInfoDlg#@\r\n#@PartyMessageDlg|Open:PartyMessageDlg#@\r\n#@PartyModifyDescDlg|Open:PartyModifyDescDlg#@\r\n#@PartyModifyJobDlg|Open:PartyModifyJobDlg#@\r\n#@PartyMsgDiyDlg|Open:PartyMsgDiyDlg#@\r\n#@PartyMsgViewDlg|Open:PartyMsgViewDlg#@\r\n#@PartyPiecesDlg|Open:PartyPiecesDlg#@\r\n#@PartyQueryDlg|Open:PartyQueryDlg#@\r\n#@PartyRequestDlg|Open:PartyRequestDlg#@\r\n#@PartySkillDlg|Open:PartySkillDlg#@\r\n#@PartySkillQueryDlg|Open:PartySkillQueryDlg#@\r\n#@PartyStoreDlg|Open:PartyStoreDlg#@\r\n#@PartySubHistoryDlg|Open:PartySubHistoryDlg#@\r\n#@PartySysMsg|Open:PartySysMsg#@\r\n#@PartyTipsInfoDlg|Open:PartyTipsInfoDlg#@\r\n#@PasspodDlg|Open:PasspodDlg#@\r\n#@PasspodDlg_1024_768|Open:PasspodDlg_1024_768#@\r\n#@PasswordDlg|Open:PasswordDlg#@\r\n#@PastTimeDlg|Open:PastTimeDlg#@\r\n#@PastTimeShareDlg|Open:PastTimeShareDlg#@\r\n#@patharrow|Open:patharrow#@\r\n#@PatternFontDlg|Open:PatternFontDlg#@\r\n#@PatternTimeSetDlg|Open:PatternTimeSetDlg#@\r\n#@PenContainerDlg|Open:PenContainerDlg#@\r\n#@Pet|Open:Pet#@\r\n#@PetBodyBagDlg|Open:PetBodyBagDlg#@\r\n#@PetBodyComposeDlg|Open:PetBodyComposeDlg#@\r\n#@PetClotheDlg|Open:PetClotheDlg#@\r\n#@PetDetailsDlg|Open:PetDetailsDlg#@\r\n#@PetDlg|Open:PetDlg#@\r\n#@PetDunwuSkill|Open:PetDunwuSkill#@\r\n#@PetExcDlg|Open:PetExcDlg#@\r\n#@PetFightCountDownDlg|Open:PetFightCountDownDlg#@\r\n#@PetFightDlg|Open:PetFightDlg#@\r\n#@PetGrow|Open:PetGrow#@\r\n#@PetGrowCalDlg|Open:PetGrowCalDlg#@\r\n#@PetGrowInfoDlg|Open:PetGrowInfoDlg#@\r\n#@PetInbornSklDlg|Open:PetInbornSklDlg#@\r\n#@PetInfoDlg|Open:PetInfoDlg#@\r\n#@PetInheritExpDlg|Open:PetInheritExpDlg#@\r\n#@PetMelt|Open:PetMelt#@\r\n#@PetMeltDlg|Open:PetMeltDlg#@\r\n#@PetMeltJlshDlg|Open:PetMeltJlshDlg#@\r\n#@PetPosDlg|Open:PetPosDlg#@\r\n#@PetRawSkill|Open:PetRawSkill#@\r\n#@PetSecludedQueryDlg|Open:PetSecludedQueryDlg#@\r\n#@PetSecludedUpDlg|Open:PetSecludedUpDlg#@\r\n#@PetSkillBaseDlg|Open:PetSkillBaseDlg#@\r\n#@PetSkillDlg|Open:PetSkillDlg#@\r\n#@PetTipsInfoDlg|Open:PetTipsInfoDlg#@\r\n#@PetXinfaDlg|Open:PetXinfaDlg#@\r\n#@PhotoDlg|Open:PhotoDlg#@\r\n#@PickDlg|Open:PickDlg#@\r\n#@PinkItemSplitDlg|Open:PinkItemSplitDlg#@\r\n#@PlantGuide|Open:PlantGuide#@\r\n#@PlantGuideDlg|Open:PlantGuideDlg#@\r\n#@PlayMusicDlg|Open:PlayMusicDlg#@\r\n#@PlayVideoDlg|Open:PlayVideoDlg#@\r\n#@PointsWishingDlg|Open:PointsWishingDlg#@\r\n#@PointsWishingOperDlg|Open:PointsWishingOperDlg#@\r\n#@PointsWishingRecordDlg|Open:PointsWishingRecordDlg#@\r\n#@PointsWishingResultDlg|Open:PointsWishingResultDlg#@\r\n#@PolarNPC|Open:PolarNPC#@\r\n#@PopMenuDlg|Open:PopMenuDlg#@\r\n#@PortraitReuse|Open:PortraitReuse#@\r\n#@PrepareDevelopSkillDlg|Open:PrepareDevelopSkillDlg#@\r\n#@PresentMusicDlg|Open:PresentMusicDlg#@\r\n#@ProgressDlg|Open:ProgressDlg#@\r\n#@ProtectedDlg|Open:ProtectedDlg#@\r\n#@Province|Open:Province#@\r\n#@PuzzleDlg|Open:PuzzleDlg#@\r\n#@QRCodeEntranceDlg|Open:QRCodeEntranceDlg#@\r\n#@QRCodeEntranceDlg_1024_768|Open:QRCodeEntranceDlg_1024_768#@\r\n#@QueryWakeContentDlg|Open:QueryWakeContentDlg#@\r\n#@questions|Open:questions#@\r\n#@questions80|Open:questions80#@\r\n#@questions_safe|Open:questions_safe#@\r\n#@QuickBuyListDlg|Open:QuickBuyListDlg#@\r\n#@QuitGameDlg|Open:QuitGameDlg#@\r\n#@RaceOperDlg|Open:RaceOperDlg#@\r\n#@RaidApplyDlg|Open:RaidApplyDlg#@\r\n#@RaidInviteDlg|Open:RaidInviteDlg#@\r\n#@RaidKickoutVoteDlg|Open:RaidKickoutVoteDlg#@\r\n#@RaidLevelLimitDlg|Open:RaidLevelLimitDlg#@\r\n#@RaidListDlg|Open:RaidListDlg#@\r\n#@RaidMemberDlg|Open:RaidMemberDlg#@\r\n#@RandomAwardBoxDlg|Open:RandomAwardBoxDlg#@\r\n#@RandomAwardDlg|Open:RandomAwardDlg#@\r\n#@RandomAwardList|Open:RandomAwardList#@\r\n#@RandomAwardResultDlg|Open:RandomAwardResultDlg#@\r\n#@RankBattleDistDlg|Open:RankBattleDistDlg#@\r\n#@RankBattleFixturesDlg|Open:RankBattleFixturesDlg#@\r\n#@RankBattleScoreDlg|Open:RankBattleScoreDlg#@\r\n#@RankBoxDlg|Open:RankBoxDlg#@\r\n#@RankClass|Open:RankClass#@\r\n#@RankDlg|Open:RankDlg#@\r\n#@RankFamilyLevelDlg|Open:RankFamilyLevelDlg#@\r\n#@RankFamilyTaoDlg|Open:RankFamilyTaoDlg#@\r\n#@RankFightDlg|Open:RankFightDlg#@\r\n#@RankFindBackDlg|Open:RankFindBackDlg#@\r\n#@RankGuideDlg|Open:RankGuideDlg#@\r\n#@RankInterServerDlg|Open:RankInterServerDlg#@\r\n#@RankLevelDlg|Open:RankLevelDlg#@\r\n#@RankMoneyDlg|Open:RankMoneyDlg#@\r\n#@RankPartyActivityDlg|Open:RankPartyActivityDlg#@\r\n#@RankPartyDlg|Open:RankPartyDlg#@\r\n#@RankPkScoreDlg|Open:RankPkScoreDlg#@\r\n#@RankRepurchaseDlg|Open:RankRepurchaseDlg#@\r\n#@RankScoreDlg|Open:RankScoreDlg#@\r\n#@RankTaoDlg|Open:RankTaoDlg#@\r\n#@RankTitle|Open:RankTitle#@\r\n#@RankTowerDlg|Open:RankTowerDlg#@\r\n#@RankXYStarDlg|Open:RankXYStarDlg#@\r\n#@RBtnOperDlg|Open:RBtnOperDlg#@\r\n#@ReadingDlg|Open:ReadingDlg#@\r\n#@RebuildSilkRoadDlg|Open:RebuildSilkRoadDlg#@\r\n#@ReceiveMsgDlg|Open:ReceiveMsgDlg#@\r\n#@RechargeAwardDlg|Open:RechargeAwardDlg#@\r\n#@RechargeExRandomAwardDlg|Open:RechargeExRandomAwardDlg#@\r\n#@RechargeInfoDlg|Open:RechargeInfoDlg#@\r\n#@RechargeRandomAwardDlg|Open:RechargeRandomAwardDlg#@\r\n#@RecipeDlg|Open:RecipeDlg#@\r\n#@RecommdAttribShareCfg|Open:RecommdAttribShareCfg#@\r\n#@recommend|Open:recommend#@\r\n#@RecommendAssignAttribDlg|Open:RecommendAssignAttribDlg#@\r\n#@RecommendAttribPetDlg|Open:RecommendAttribPetDlg#@\r\n#@RecommendGreenProperty|Open:RecommendGreenProperty#@\r\n#@RecommendProperty|Open:RecommendProperty#@\r\n#@RecordDlg|Open:RecordDlg#@\r\n#@RecordSettingDlg|Open:RecordSettingDlg#@\r\n#@RecordVoiceStateDlg|Open:RecordVoiceStateDlg#@\r\n#@RecruitTeamDlg|Open:RecruitTeamDlg#@\r\n#@RedEnvelopeInfoDlg|Open:RedEnvelopeInfoDlg#@\r\n#@RedEnvelopeMainDlg|Open:RedEnvelopeMainDlg#@\r\n#@RedEnvelopeMemberChooseDlg|Open:RedEnvelopeMemberChooseDlg#@\r\n#@RedEnvelopeSendDlg|Open:RedEnvelopeSendDlg#@\r\n#@RedNameListDlg|Open:RedNameListDlg#@\r\n#@RegisterAccountDlg|Open:RegisterAccountDlg#@\r\n#@RegisterDlg|Open:RegisterDlg#@\r\n#@RegisterDlg_1024_768|Open:RegisterDlg_1024_768#@\r\n#@RemoteStoreDlg|Open:RemoteStoreDlg#@\r\n#@ReportClassDlg|Open:ReportClassDlg#@\r\n#@ReportIllegalCharDlg|Open:ReportIllegalCharDlg#@\r\n#@RequestFightDlg|Open:RequestFightDlg#@\r\n#@ReselectDistDlg|Open:ReselectDistDlg#@\r\n#@ReselectDistDlg_1024_768|Open:ReselectDistDlg_1024_768#@\r\n#@ResourceGatherScoreDlg|Open:ResourceGatherScoreDlg#@\r\n#@ResourceGatherTipDlg|Open:ResourceGatherTipDlg#@\r\n#@RewardExchangeDlg|Open:RewardExchangeDlg#@\r\n#@RewardRankDlg|Open:RewardRankDlg#@\r\n#@reward_item|Open:reward_item#@\r\n#@RollerTaskDlg|Open:RollerTaskDlg#@\r\n#@RoupAgentItemDlg|Open:RoupAgentItemDlg#@\r\n#@RoupAgentPetDlg|Open:RoupAgentPetDlg#@\r\n#@RoupAgentSysItemDlg|Open:RoupAgentSysItemDlg#@\r\n#@RoupDepotDlg|Open:RoupDepotDlg#@\r\n#@RoupItemDlg|Open:RoupItemDlg#@\r\n#@RoupItemInfoDlg|Open:RoupItemInfoDlg#@\r\n#@RoupPetDlg|Open:RoupPetDlg#@\r\n#@RoupPetInfoDlg|Open:RoupPetInfoDlg#@\r\n#@RuneBoxDlg|Open:RuneBoxDlg#@\r\n#@SafeLoginSetupDlg|Open:SafeLoginSetupDlg#@\r\n#@SafeQuestionAnswerDlg|Open:SafeQuestionAnswerDlg#@\r\n#@SafeQuestionCancleDlg|Open:SafeQuestionCancleDlg#@\r\n#@SafeQuestionConfirmDlg|Open:SafeQuestionConfirmDlg#@\r\n#@SafeQuestionDlg|Open:SafeQuestionDlg#@\r\n#@safe_tips|Open:safe_tips#@\r\n#@SaleLogDlg|Open:SaleLogDlg#@\r\n#@SaofeiChuzeiDlg|Open:SaofeiChuzeiDlg#@\r\n#@ScBack|Open:ScBack#@\r\n#@ScMobileServiceDlg|Open:ScMobileServiceDlg#@\r\n#@ScMoreSecurityDlg|Open:ScMoreSecurityDlg#@\r\n#@ScPsdProtectedDlg|Open:ScPsdProtectedDlg#@\r\n#@ScrollTextDlg|Open:ScrollTextDlg#@\r\n#@ScSecurityLockDlg|Open:ScSecurityLockDlg#@\r\n#@SearchEquipShareDlg|Open:SearchEquipShareDlg#@\r\n#@SearchItemShareDlg|Open:SearchItemShareDlg#@\r\n#@SearchPetShareDlg|Open:SearchPetShareDlg#@\r\n#@SearchPropShareDlg|Open:SearchPropShareDlg#@\r\n#@SearchStallByPropDlg|Open:SearchStallByPropDlg#@\r\n#@SearchStallEquipDlg|Open:SearchStallEquipDlg#@\r\n#@SearchStallPetDlg|Open:SearchStallPetDlg#@\r\n#@search_prop|Open:search_prop#@\r\n#@SeasonActivityDlg|Open:SeasonActivityDlg#@\r\n#@SecurityCenterDlg|Open:SecurityCenterDlg#@\r\n#@SelectCharacterDlg|Open:SelectCharacterDlg#@\r\n#@SelectServerDlg|Open:SelectServerDlg#@\r\n#@SelectZoneDlg|Open:SelectZoneDlg#@\r\n#@SelfSetColorDlg|Open:SelfSetColorDlg#@\r\n#@SellItemDlg|Open:SellItemDlg#@\r\n#@SellPetDlg|Open:SellPetDlg#@\r\n#@SellSkillDlg|Open:SellSkillDlg#@\r\n#@SenderOpeDlg|Open:SenderOpeDlg#@\r\n#@SendMsgDlg|Open:SendMsgDlg#@\r\n#@SetDoubleBonusTimeDlg|Open:SetDoubleBonusTimeDlg#@\r\n#@SetTaskModeDlg|Open:SetTaskModeDlg#@\r\n#@SetWakeContentDlg|Open:SetWakeContentDlg#@\r\n#@SetWeatherDlg|Open:SetWeatherDlg#@\r\n#@SeventhAnnivesaryDlg|Open:SeventhAnnivesaryDlg#@\r\n#@ShengsxhDlg|Open:ShengsxhDlg#@\r\n#@ShopAdDlg|Open:ShopAdDlg#@\r\n#@ShopBuyItemDlg|Open:ShopBuyItemDlg#@\r\n#@ShopBuyPetDlg|Open:ShopBuyPetDlg#@\r\n#@ShopEnterTypeDlg|Open:ShopEnterTypeDlg#@\r\n#@ShopManagePetDlg|Open:ShopManagePetDlg#@\r\n#@ShopManamgeItemDlg|Open:ShopManamgeItemDlg#@\r\n#@ShopRegDlg|Open:ShopRegDlg#@\r\n#@ShopRoupDlg|Open:ShopRoupDlg#@\r\n#@ShopSearchEquipDlg|Open:ShopSearchEquipDlg#@\r\n#@ShopSearchItemDlg|Open:ShopSearchItemDlg#@\r\n#@ShopSearchPetDlg|Open:ShopSearchPetDlg#@\r\n#@ShopSearchPropDlg|Open:ShopSearchPropDlg#@\r\n#@ShopSearchShareDlg|Open:ShopSearchShareDlg#@\r\n#@ShopSelectDlg|Open:ShopSelectDlg#@\r\n#@ShopSellDlg|Open:ShopSellDlg#@\r\n#@ShowMapNameDlg|Open:ShowMapNameDlg#@\r\n#@ShutdownCfmDlg|Open:ShutdownCfmDlg#@\r\n#@ShutdownSetDlg|Open:ShutdownSetDlg#@\r\n#@ShutdownTipDlg|Open:ShutdownTipDlg#@\r\n#@SignInDlg|Open:SignInDlg#@\r\n#@SimColorTipsDlg|Open:SimColorTipsDlg#@\r\n#@SkillDevelopDlg|Open:SkillDevelopDlg#@\r\n#@SkillDlg|Open:SkillDlg#@\r\n#@SkillLearningDlg|Open:SkillLearningDlg#@\r\n#@SkillListDlg|Open:SkillListDlg#@\r\n#@SkillReplace|Open:SkillReplace#@\r\n#@Skills|Open:Skills#@\r\n#@SkillTalkDlg|Open:SkillTalkDlg#@\r\n#@skill_desc|Open:skill_desc#@\r\n#@SklMainDlg|Open:SklMainDlg#@\r\n#@SmallGameCloseMenuDlg|Open:SmallGameCloseMenuDlg#@\r\n#@SmallGameScoreDlg|Open:SmallGameScoreDlg#@\r\n#@SmallGameTipDlg|Open:SmallGameTipDlg#@\r\n#@SmallMapNpc|Open:SmallMapNpc#@\r\n#@SmallTipsDlg|Open:SmallTipsDlg#@\r\n#@SmplTipDlg|Open:SmplTipDlg#@\r\n#@SocApplyDlg|Open:SocApplyDlg#@\r\n#@SocCfmDlg|Open:SocCfmDlg#@\r\n#@SocChatDlg|Open:SocChatDlg#@\r\n#@SocChatReportDlg|Open:SocChatReportDlg#@\r\n#@SocClaimerDlg|Open:SocClaimerDlg#@\r\n#@SocDefImgDlg|Open:SocDefImgDlg#@\r\n#@SocFindDlg|Open:SocFindDlg#@\r\n#@SocGmRcvDlg|Open:SocGmRcvDlg#@\r\n#@SocGroupAllDlg|Open:SocGroupAllDlg#@\r\n#@SocGroupDlg|Open:SocGroupDlg#@\r\n#@SocHisDlg|Open:SocHisDlg#@\r\n#@SocInfoDlg|Open:SocInfoDlg#@\r\n#@SocMainDlg|Open:SocMainDlg#@\r\n#@SocNewImgDlg|Open:SocNewImgDlg#@\r\n#@SocOperateDlg|Open:SocOperateDlg#@\r\n#@SocRecvDlg|Open:SocRecvDlg#@\r\n#@SocReplyDlg|Open:SocReplyDlg#@\r\n#@SocReportDetailDlg|Open:SocReportDetailDlg#@\r\n#@SocSendAllDlg|Open:SocSendAllDlg#@\r\n#@SocSendDlg|Open:SocSendDlg#@\r\n#@SocSetDlg|Open:SocSetDlg#@\r\n#@SocStateDlg|Open:SocStateDlg#@\r\n#@SocSysMsgMainDlg|Open:SocSysMsgMainDlg#@\r\n#@SocSysMsgViewDlg|Open:SocSysMsgViewDlg#@\r\n#@SocVerifyDlg|Open:SocVerifyDlg#@\r\n#@SoftKeyBoardDlg|Open:SoftKeyBoardDlg#@\r\n#@Sound|Open:Sound#@\r\n#@SpecialPortrait|Open:SpecialPortrait#@\r\n#@special_path|Open:special_path#@\r\n#@SpriteConfig|Open:SpriteConfig#@\r\n#@StallCollectListDlg|Open:StallCollectListDlg#@\r\n#@StallItemBack|Open:StallItemBack#@\r\n#@StallPetBack|Open:StallPetBack#@\r\n#@StallPetInfoDlg|Open:StallPetInfoDlg#@\r\n#@StallPriceInputDlg|Open:StallPriceInputDlg#@\r\n#@StallSearchListDlg|Open:StallSearchListDlg#@\r\n#@StarAllStoneTipsDlg|Open:StarAllStoneTipsDlg#@\r\n#@StarMap|Open:StarMap#@\r\n#@StarMapAoYuDlg|Open:StarMapAoYuDlg#@\r\n#@StarMapBaXiaDlg|Open:StarMapBaXiaDlg#@\r\n#@StarMapBiAnDlg|Open:StarMapBiAnDlg#@\r\n#@StarMapChaoFengDlg|Open:StarMapChaoFengDlg#@\r\n#@StarMapDescDlg|Open:StarMapDescDlg#@\r\n#@StarMapDlgBase|Open:StarMapDlgBase#@\r\n#@StarMapPiXiuDlg|Open:StarMapPiXiuDlg#@\r\n#@StarMapPuLaoDlg|Open:StarMapPuLaoDlg#@\r\n#@StarMapQiuNiuDlg|Open:StarMapQiuNiuDlg#@\r\n#@StarMapTaoTieDlg|Open:StarMapTaoTieDlg#@\r\n#@StarMapTipsDlg|Open:StarMapTipsDlg#@\r\n#@StarMapYaZiDlg|Open:StarMapYaZiDlg#@\r\n#@StartHuntDlg|Open:StartHuntDlg#@\r\n#@StarTipsDlg|Open:StarTipsDlg#@\r\n#@StateShowDlg|Open:StateShowDlg#@\r\n#@StatusAni|Open:StatusAni#@\r\n#@StopDanceDlg|Open:StopDanceDlg#@\r\n#@StopDatingDlg|Open:StopDatingDlg#@\r\n#@StopFightDlg|Open:StopFightDlg#@\r\n#@StopMarchDlg|Open:StopMarchDlg#@\r\n#@StopTdsfFightDlg|Open:StopTdsfFightDlg#@\r\n#@StopXycxjFightDlg|Open:StopXycxjFightDlg#@\r\n#@StorePetDlg|Open:StorePetDlg#@\r\n#@StrategyWarDlg|Open:StrategyWarDlg#@\r\n#@StrategyWarPlanVsInfoDlg|Open:StrategyWarPlanVsInfoDlg#@\r\n#@StrategyWarSelectTeamDlg|Open:StrategyWarSelectTeamDlg#@\r\n#@SubChannelSetDlg|Open:SubChannelSetDlg#@\r\n#@SubChatRecordDlg|Open:SubChatRecordDlg#@\r\n#@SubmitCfmDlg|Open:SubmitCfmDlg#@\r\n#@SubmitRuneDlg|Open:SubmitRuneDlg#@\r\n#@SubmitXindeDlg|Open:SubmitXindeDlg#@\r\n#@SubSocChatDlg|Open:SubSocChatDlg#@\r\n#@SuperFlyDlg|Open:SuperFlyDlg#@\r\n#@SysExitDlg|Open:SysExitDlg#@\r\n#@SysGuide|Open:SysGuide#@\r\n#@SysGuideDlg|Open:SysGuideDlg#@\r\n#@SysInfoDlg|Open:SysInfoDlg#@\r\n#@SysMainDlg|Open:SysMainDlg#@\r\n#@SysSecurityCfg|Open:SysSecurityCfg#@\r\n#@SysSecurityDlg|Open:SysSecurityDlg#@\r\n#@SysSetPublicDlg|Open:SysSetPublicDlg#@\r\n#@SystemBulletinDlg|Open:SystemBulletinDlg#@\r\n#@SystemDlg|Open:SystemDlg#@\r\n#@SysWarn|Open:SysWarn#@\r\n#@TabGroup|Open:TabGroup#@\r\n#@TalkDlg|Open:TalkDlg#@\r\n#@TalkItemDlg|Open:TalkItemDlg#@\r\n#@TalkMenuDlg|Open:TalkMenuDlg#@\r\n#@TalkMenuDlgShare|Open:TalkMenuDlgShare#@\r\n#@TalkNoMenuDlg|Open:TalkNoMenuDlg#@\r\n#@TaoTaoTaoDlg|Open:TaoTaoTaoDlg#@\r\n#@TaoWinManDlg|Open:TaoWinManDlg#@\r\n#@TaskBuyItemDlg|Open:TaskBuyItemDlg#@\r\n#@TaskBuyItemList|Open:TaskBuyItemList#@\r\n#@TaskChallengeDlg|Open:TaskChallengeDlg#@\r\n#@TaskDlg|Open:TaskDlg#@\r\n#@TaskExtraGainList|Open:TaskExtraGainList#@\r\n#@TaskTipDlg|Open:TaskTipDlg#@\r\n#@TaskTipMgrDlg|Open:TaskTipMgrDlg#@\r\n#@TaskTipsInfoDlg|Open:TaskTipsInfoDlg#@\r\n#@TaskTraceDlg|Open:TaskTraceDlg#@\r\n#@TeamApplicateDlg|Open:TeamApplicateDlg#@\r\n#@TeamBuyAccountDlg|Open:TeamBuyAccountDlg#@\r\n#@TeamBuyDetailDlg|Open:TeamBuyDetailDlg#@\r\n#@TeamBuyDlg|Open:TeamBuyDlg#@\r\n#@TeamBuyOrderDlg|Open:TeamBuyOrderDlg#@\r\n#@TeamPlatformBaseDlg|Open:TeamPlatformBaseDlg#@\r\n#@TeamPlatformDlg|Open:TeamPlatformDlg#@\r\n#@TeamPlatformTaskDlg|Open:TeamPlatformTaskDlg#@\r\n#@TeamPurpose|Open:TeamPurpose#@\r\n#@TeamStatusTopDlg|Open:TeamStatusTopDlg#@\r\n#@TeleportNpc|Open:TeleportNpc#@\r\n#@TenYearsItem|Open:TenYearsItem#@\r\n#@TenYearsSignDlg|Open:TenYearsSignDlg#@\r\n#@TimeLimitDlg|Open:TimeLimitDlg#@\r\n#@TimeLuckDlg|Open:TimeLuckDlg#@\r\n#@TimeMachine|Open:TimeMachine#@\r\n#@TimingDlg|Open:TimingDlg#@\r\n#@TipDlg|Open:TipDlg#@\r\n#@title|Open:title#@\r\n#@TitleAni|Open:TitleAni#@\r\n#@TitleColor|Open:TitleColor#@\r\n#@TitleSelectDlg|Open:TitleSelectDlg#@\r\n#@TodayListDlg|Open:TodayListDlg#@\r\n#@TodayRemindList|Open:TodayRemindList#@\r\n#@TodayStatDlg|Open:TodayStatDlg#@\r\n#@TodayStateTipsInfoDlg|Open:TodayStateTipsInfoDlg#@\r\n#@ToolUsingDlg|Open:ToolUsingDlg#@\r\n#@TowerOperDlg|Open:TowerOperDlg#@\r\n#@TowerSelDlg|Open:TowerSelDlg#@\r\n#@TowerWalkObj|Open:TowerWalkObj#@\r\n#@TownMapDlg|Open:TownMapDlg#@\r\n#@TradeArtifactDlg|Open:TradeArtifactDlg#@\r\n#@TradeAuctionModifyDlg|Open:TradeAuctionModifyDlg#@\r\n#@TradeCharPropDlg|Open:TradeCharPropDlg#@\r\n#@TradeCharYLFDlg|Open:TradeCharYLFDlg#@\r\n#@TradeChildPropDlg|Open:TradeChildPropDlg#@\r\n#@TradeChildrenBooksDlg|Open:TradeChildrenBooksDlg#@\r\n#@TradeChildrenEquipDlg|Open:TradeChildrenEquipDlg#@\r\n#@TradeChildrenPropDlg|Open:TradeChildrenPropDlg#@\r\n#@TradeChildrenSkillDlg|Open:TradeChildrenSkillDlg#@\r\n#@TradeClotheDlg|Open:TradeClotheDlg#@\r\n#@TradeDlgRadioCfg|Open:TradeDlgRadioCfg#@\r\n#@TradeDunWuSkillDlg|Open:TradeDunWuSkillDlg#@\r\n#@TradeEquipPropDlg|Open:TradeEquipPropDlg#@\r\n#@TradeEvaluateDlg|Open:TradeEvaluateDlg#@\r\n#@TradeExchangeListDlg|Open:TradeExchangeListDlg#@\r\n#@TradeGodBookSkillDlg|Open:TradeGodBookSkillDlg#@\r\n#@TradeGuardPropDlg|Open:TradeGuardPropDlg#@\r\n#@TradeHunShouShiDlg|Open:TradeHunShouShiDlg#@\r\n#@TradeJadeDlg|Open:TradeJadeDlg#@\r\n#@TradeMyStoreDlg|Open:TradeMyStoreDlg#@\r\n#@TradeNoBookSaleDlg|Open:TradeNoBookSaleDlg#@\r\n#@TradeNotesDlg|Open:TradeNotesDlg#@\r\n#@TradePetDetailDlg|Open:TradePetDetailDlg#@\r\n#@TradePetInbornSklDlg|Open:TradePetInbornSklDlg#@\r\n#@TradePetPropDlg|Open:TradePetPropDlg#@\r\n#@TradePetSkillDlg|Open:TradePetSkillDlg#@\r\n#@TradePropBaseDlg|Open:TradePropBaseDlg#@\r\n#@TradeRoleSkillDlg|Open:TradeRoleSkillDlg#@\r\n#@TradeSaleCashDlg|Open:TradeSaleCashDlg#@\r\n#@TradeSaleCfg|Open:TradeSaleCfg#@\r\n#@TradeSaleCharDlg|Open:TradeSaleCharDlg#@\r\n#@TradeSaleModifyDlg|Open:TradeSaleModifyDlg#@\r\n#@TradeSaleObjDlg|Open:TradeSaleObjDlg#@\r\n#@TradeSaleQuestionDlg|Open:TradeSaleQuestionDlg#@\r\n#@TradeShowList|Open:TradeShowList#@\r\n#@TradeShowListDlg|Open:TradeShowListDlg#@\r\n#@TradeSkillBaseDlg|Open:TradeSkillBaseDlg#@\r\n#@TradeSuitDlg|Open:TradeSuitDlg#@\r\n#@TradeUpPetDlg|Open:TradeUpPetDlg#@\r\n#@TradeWuDaoDlg|Open:TradeWuDaoDlg#@\r\n#@TradeXinFaSkillDlg|Open:TradeXinFaSkillDlg#@\r\n#@TreasureMapDlg|Open:TreasureMapDlg#@\r\n#@TriggerGuide|Open:TriggerGuide#@\r\n#@TwoFestivalsDlg|Open:TwoFestivalsDlg#@\r\n#@TYCZhuangShiChooseDlg|Open:TYCZhuangShiChooseDlg#@\r\n#@TYCZhuangShiTalkSetDlg|Open:TYCZhuangShiTalkSetDlg#@\r\n#@UiEditInUse|Open:UiEditInUse#@\r\n#@UnderMapReUse|Open:UnderMapReUse#@\r\n#@UpgradeGuardDlg|Open:UpgradeGuardDlg#@\r\n#@VerifyCodeDlg|Open:VerifyCodeDlg#@\r\n#@VipItemList|Open:VipItemList#@\r\n#@VipPetList|Open:VipPetList#@\r\n#@VitalityBonusDlg|Open:VitalityBonusDlg#@\r\n#@WansjItems|Open:WansjItems#@\r\n#@WansjRandomAwardDlg|Open:WansjRandomAwardDlg#@\r\n#@WdShowAskForDlg|Open:WdShowAskForDlg#@\r\n#@WdShowBureauDlg|Open:WdShowBureauDlg#@\r\n#@WdShowBuyOperDlg|Open:WdShowBuyOperDlg#@\r\n#@WdShowExtraBureauDlg|Open:WdShowExtraBureauDlg#@\r\n#@WdShowGiftBoxDlg|Open:WdShowGiftBoxDlg#@\r\n#@WdShowItemInfoDlg|Open:WdShowItemInfoDlg#@\r\n#@WdShowMarketDlg|Open:WdShowMarketDlg#@\r\n#@weather|Open:weather#@\r\n#@WebDlg|Open:WebDlg#@\r\n#@WebDlg_1024_768|Open:WebDlg_1024_768#@\r\n#@WebMiniDlg|Open:WebMiniDlg#@\r\n#@WinterTitleRewardDlg|Open:WinterTitleRewardDlg#@\r\n#@WishingDlg|Open:WishingDlg#@\r\n#@WishItemDlg|Open:WishItemDlg#@\r\n#@WishRealizedDlg|Open:WishRealizedDlg#@\r\n#@WordBrowDlg|Open:WordBrowDlg#@\r\n#@Wordsimg|Open:Wordsimg#@\r\n#@WorkShopOrderDlg|Open:WorkShopOrderDlg#@\r\n#@WorldLevelDlg|Open:WorldLevelDlg#@\r\n#@WorldMapDlg|Open:WorldMapDlg#@\r\n#@WorldMapLinkDlg|Open:WorldMapLinkDlg#@\r\n#@WsbwzzCountDownDlg|Open:WsbwzzCountDownDlg#@\r\n#@WuDaoDlg|Open:WuDaoDlg#@\r\n#@XianBalkDlg|Open:XianBalkDlg#@\r\n#@XiangQianLingDlg|Open:XiangQianLingDlg#@\r\n#@XianPolarDlg|Open:XianPolarDlg#@\r\n#@XianResistDlg|Open:XianResistDlg#@\r\n#@XianStatusDlg|Open:XianStatusDlg#@\r\n#@XinfaFeedDlg|Open:XinfaFeedDlg#@\r\n#@XinfaSkillDlg|Open:XinfaSkillDlg#@\r\n#@XueyingBalkDlg|Open:XueyingBalkDlg#@\r\n#@XueyingPolarDlg|Open:XueyingPolarDlg#@\r\n#@XueyingResistDlg|Open:XueyingResistDlg#@\r\n#@XueyingStatusDlg|Open:XueyingStatusDlg#@\r\n#@YaoYaoLeDlg|Open:YaoYaoLeDlg#@\r\n#@YearInsiderDlg|Open:YearInsiderDlg#@\r\n#@YellowItemSplitDlg|Open:YellowItemSplitDlg#@\r\n#@YLFDlg|Open:YLFDlg#@\r\n#@YuanXiaoJieTaskDlg|Open:YuanXiaoJieTaskDlg#@\r\n#@YuanXiaoWordDlg|Open:YuanXiaoWordDlg#@\r\n#@YuanyingBalkDlg|Open:YuanyingBalkDlg#@\r\n#@YuanyingPolarDlg|Open:YuanyingPolarDlg#@\r\n#@YuanyingResistDlg|Open:YuanyingResistDlg#@\r\n#@YuanyingStatusDlg|Open:YuanyingStatusDlg#@\r\n#@ZhenfaCards|Open:ZhenfaCards#@\r\n#@ZhenFaChooseDlg|Open:ZhenFaChooseDlg#@\r\n#@ZhenFaChooseFightDlg|Open:ZhenFaChooseFightDlg#@\r\n#@ZhenFaFightMenuDlg|Open:ZhenFaFightMenuDlg#@\r\n#@ZhenFaInfo|Open:ZhenFaInfo#@\r\n#@ZhenFaIntroductionDlg|Open:ZhenFaIntroductionDlg#@\r\n#@ZhenFaLearnDlg|Open:ZhenFaLearnDlg#@\r\n#@ZhenyRankDlg|Open:ZhenyRankDlg#@\r\n#@ZodiacPlateDlg|Open:ZodiacPlateDlg#@\r\n#@ZzcfRewardDlg|Open:ZzcfRewardDlg#@".Split("\r\n");
					for (int j = 0; j < array.Length; j++)
					{
						Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(array[j], "管理员", AllEnums.频道Type.系统));
					}
				}
			}
			return P_1;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("请求_角色喊话处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return null;
		}
	}

	
	internal byte[] hac6uc0JTy(MyNATSocketClient P_0, byte[] P_1)
	{
		封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
		obj.Seek(12L, SeekOrigin.Begin);
		obj.读文本型(out string value, true, (byte)0, false);
		if (Singleton<ByteAPI>.I.寻找文本(value, ":69FD94F6139D17088888:"))
		{
			return Singleton<YHfw7nGpg7WfdCBKDH4>.I.hEyGAJ0Jyy(P_0, value);
		}
		return P_1;
	}

	
	internal byte[] RuQ6wGrDXV(MyNATSocketClient P_0, byte[] P_1)
	{
		封包_读 obj = new 封包_读(P_1, 0, P_1.Length);
		obj.Seek(14L, SeekOrigin.Begin);
		obj.读字节集(2);
		obj.读文本型(是否声明长度: true, 0);
		obj.读字节型(out var value);
		if (value == 1)
		{
			return bIY6bwxGuZ(P_0, P_1);
		}
		return P_1;
	}

	
	internal byte[] bIY6bwxGuZ(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			int num = 0;
			short num2 = 0;
			int num3 = 0;
			string empty = string.Empty;
			Array.Empty<byte>();
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写 封包_写3 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(4), hasCount: false, 0);
			封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
			封包_写2.写字节型(封包_读2.读字节型(out var value));
			封包_写2.写字节集(封包_读2.读字节集(4), hasCount: false, 0);
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value2), reverse: true);
			物品信息类 物品信息类2 = new 物品信息类
			{
				Index = value
			};
			for (int i = 0; i < value2; i++)
			{
				_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass7_0();
				封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out CS_0024_003C_003E8__locals8.uTk9PTHFpu), reverse: true);
				封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value3), reverse: true);
				for (int j = 0; j < value3; j++)
				{
					封包_写3.写字节集(封包_读2.读字节集(2, out byte[] value4), hasCount: false, 0);
					封包_写3.写字节型(封包_读2.读字节型(out var value5));
					short 属性标识 = Singleton<ByteAPI>.I.反转_短整数(value4);
					num = 0;
					num2 = 0;
					num3 = 0;
					empty = string.Empty;
					switch (value5)
					{
					case 1:
						num = 封包_读2.读字节型();
						if (Enumerable.SequenceEqual(value4, Singleton<ByteAPI>.I.HtoC("01B1")))
						{
							物品信息类2.装备已进化次数 = num;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 151 }))
						{
							物品信息类2.是否绑定 = num >= 3;
							物品信息类2.绑定状态 = ((num != 3 && num != 4) ? AllEnums.绑定Type.不绑定 : ((num == 4) ? AllEnums.绑定Type.死绑 : AllEnums.绑定Type.红绑));
						}
						封包_写3.写字节型(num);
						break;
					case 2:
						num2 = 封包_读2.读短整数型(reverse: true);
						if (Enumerable.SequenceEqual(value4, Singleton<ByteAPI>.I.HtoC("00CB")))
						{
							物品信息类2.数量 = num2;
						}
						封包_写3.写短整数型(num2, reverse: true);
						break;
					case 3:
						num3 = 封包_读2.读整数型(reverse: true);
						if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 84 }))
						{
							物品信息类2.物品ID = num3;
						}
						else if (Enumerable.SequenceEqual(value4, Singleton<ByteAPI>.I.HtoC("0251")))
						{
							物品信息类2.首饰可转换次数 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, Singleton<ByteAPI>.I.HtoC("0247")))
						{
							物品信息类2.首饰已转换次数 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 6 }) && num3 == 999)
						{
							num3 = 0;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 7 }))
						{
							物品信息类2.绑定气血 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 10 }))
						{
							物品信息类2.装备天伤 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 12 }))
						{
							物品信息类2.绑定法力 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 40 }))
						{
							物品信息类2.图标 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 42 }))
						{
							物品信息类2.当前耐久度 = num3;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 43 }))
						{
							物品信息类2.最大耐久度 = num3;
						}
						else if (!Enumerable.SequenceEqual(value4, new byte[2] { 0, 206 }) && Enumerable.SequenceEqual(value4, new byte[2] { 0, 208 }))
						{
							物品信息类2.改造等级 = num3;
						}
						封包_写3.写整数型(num3, reverse: true);
						break;
					case 4:
						empty = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
						if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 1 }))
						{
							if (CS_0024_003C_003E8__locals8.uTk9PTHFpu == 1)
							{
								物品信息类2.名字 = empty;
								物品信息类2.前缀 = ((empty.Length > Singleton<全局变量类>.I.config.前缀长度) ? Singleton<ByteAPI>.I.取文本左边(empty, Singleton<全局变量类>.I.config.前缀长度) : string.Empty);
							}
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 55 }))
						{
							物品信息类2.单位 = empty;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 1, 8 }))
						{
							物品信息类2.描述 = empty;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 89 }))
						{
							物品信息类2.改造人 = empty;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 209 }))
						{
							物品信息类2.物品颜色 = empty;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 2, 65 }))
						{
							物品信息类2.别名 = empty;
						}
						封包_写3.写文本型(empty, hasCount: true, 0, reverse: true);
						break;
					case 6:
						num = 封包_读2.读字节型();
						if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 202 }))
						{
							物品信息类2.物品类型 = (byte)num;
						}
						else if (Enumerable.SequenceEqual(value4, new byte[2] { 0, 205 }))
						{
							物品信息类2.等级 = (byte)num;
						}
						封包_写3.写字节型(num);
						break;
					case 7:
						num2 = 封包_读2.读短整数型(reverse: true);
						封包_写3.写短整数型(num2, reverse: true);
						break;
					}
					if (全局常量类.属性类别组.Any( (int x) => x == CS_0024_003C_003E8__locals8.uTk9PTHFpu))
					{
						switch (value5)
						{
						case 1:
							物品信息类2.装备属性列表.Add(new 属性数据
							{
								属性类别 = CS_0024_003C_003E8__locals8.uTk9PTHFpu,
								属性标识 = 属性标识,
								属性数值 = num
							});
							break;
						case 2:
							物品信息类2.装备属性列表.Add(new 属性数据
							{
								属性类别 = CS_0024_003C_003E8__locals8.uTk9PTHFpu,
								属性标识 = 属性标识,
								属性数值 = num2
							});
							break;
						case 3:
							物品信息类2.装备属性列表.Add(new 属性数据
							{
								属性类别 = CS_0024_003C_003E8__locals8.uTk9PTHFpu,
								属性标识 = 属性标识,
								属性数值 = num3
							});
							break;
						case 6:
							物品信息类2.装备属性列表.Add(new 属性数据
							{
								属性类别 = CS_0024_003C_003E8__locals8.uTk9PTHFpu,
								属性标识 = 属性标识,
								属性数值 = num
							});
							break;
						case 7:
							物品信息类2.装备属性列表.Add(new 属性数据
							{
								属性类别 = CS_0024_003C_003E8__locals8.uTk9PTHFpu,
								属性标识 = 属性标识,
								属性数值 = num2
							});
							break;
						}
					}
				}
			}
			物品信息类2.rgh8r0QQvs(P_0);
			if (Singleton<COyX27f6L3uCF3F6Kp5>.I.rCpfLKhKrZ(P_0, 物品信息类2))
			{
				物品信息类2.封包缓存 = 封包_写3.取数据();
				封包_写3.清数据();
				封包_写3.写入数据(Singleton<COyX27f6L3uCF3F6Kp5>.I.KDQfSpe9nM(P_0, 物品信息类2.封包缓存, 物品信息类2), hasCount: false, 0);
			}
			封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			Log.Error("接收_交易背包响应-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_1;
		}
	}

	
	public hQdJQufqsH3l9bnUemG()
	{
		Qe56JI1uxR = 165;
	}

	static hQdJQufqsH3l9bnUemG()
	{
	}
}
