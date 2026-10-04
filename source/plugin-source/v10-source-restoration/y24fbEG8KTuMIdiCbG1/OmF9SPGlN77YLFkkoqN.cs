using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using B2uVXfUco7vjsxVN2Bc;
using B6XRmUwQK7iatdTWLwc;
using EoNAUnGWS8H1K1ckt64;
using HS2GfXB7hJCX6tDXuc0;
using MAZG7tsAp4qxkk1uF8R;
using Newtonsoft_X.Json;
using PJ8VymWjWDfaUUlTW62;
using Serilog;
using YOheREbBnDq6LvvWZEr;
using dgvsPcDEiqYFlrnMMor;
using mxyyZlfUTTOCu8Y4ZsN;
using s4E8DnU2AI3UWfigLPZ;
using vEAdPGPTkDFOYsbi303;
using xqlPMM2TJRNXpZnNDFn;

namespace y24fbEG8KTuMIdiCbG1;

internal class OmF9SPGlN77YLFkkoqN : Singleton<OmF9SPGlN77YLFkkoqN>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public MyNATSocketClient AYeTg4Arhf;

		public List<int[]> SDyTDtPYKR;

		
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		
		internal void d8MTWCxK8M()
		{
			AYeTg4Arhf.砍尾火眼事件 = null;
			AYeTg4Arhf.C_Send(Singleton<WdAPI>.I.AKCo4gK26i(SDyTDtPYKR));
		}

		static _003C_003Ec__DisplayClass20_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_1
	{
		public int rtuTlR4tQ7;

		public _003C_003Ec__DisplayClass20_0 KUXT8xxamL;

		
		public _003C_003Ec__DisplayClass20_1()
		{
		}

		
		internal void gX7TjgGkmV(bool v1)
		{
			Singleton<yuKf6DUSQGygKeLSQdj>.I.BNoUTIgmnO(KUXT8xxamL.AYeTg4Arhf, rtuTlR4tQ7, v1);
		}

		static _003C_003Ec__DisplayClass20_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public int HEuTo6Nput;

		public Predicate<MyNATSocketClient> RQvTND9SST;

		
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		
		internal bool UCwTII4gHh(MyNATSocketClient x)
		{
			if (x.当前client.Online && x.转发client.Online)
			{
				return x.user.人物数据.角色ID == HEuTo6Nput;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass21_0()
		{
		}
	}

	public static string hBnG3iSkZ3;

	public ConcurrentDictionary<int, ConcurrentDictionary<int, 砍尾怪物数据>> lqoGYaYlNv;

	
	[SpecialName]
	public static bool bv9GQKOlSY()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is道北砍尾)
		{
			return Singleton<全局变量类>.I.狐狸和狗配置.功能开关;
		}
		return false;
	}

	
	internal void RqiGIcOsbs()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("狐狸和狗配置类.json")))
			{
				Singleton<全局变量类>.I.狐狸和狗配置 = JsonConvert.DeserializeObject<狐狸和狗配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("狐狸和狗配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.狐狸和狗配置 = new 狐狸和狗配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("狐狸和狗配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.狐狸和狗配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("狐狸和狗配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void jupGosES70()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("狐狸和狗配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.狐狸和狗配置, Formatting.Indented));
			Log.Debug("狐狸和狗配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("狐狸和狗配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string nVdGNZ1SEe()
	{
		RqiGIcOsbs();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.狐狸和狗配置, Formatting.Indented);
	}

	
	public void SpMGimfMK0(string P_0)
	{
		Singleton<全局变量类>.I.狐狸和狗配置 = JsonConvert.DeserializeObject<狐狸和狗配置类>(P_0);
		jupGosES70();
	}

	
	internal void IqKGBZSJD3(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			Singleton<mDs6hiBvFvG3CRi3MZk>.I.ElmBC999cR(P_0, false);
			P_0.user.缓存数据.is扣除标识 = false;
			P_0.user.存档数据.妖族化形数据.Close();
			P_0.user.缓存数据.is战斗逃跑指令 = false;
			if (妖族化形功能.使用中 && Singleton<WdAPI>.I.取对应化形ID(P_0.user.人物数据.形象ID) != 0)
			{
				P_0.user.存档数据.妖族化形数据.化形值 = (ushort)Singleton<WdAPI>.I.进入战斗获取化形初值(P_0);
			}
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND())
			{
				Singleton<版本相关处理>.I.ScyffSSCxe(P_0);
			}
			else if (版本相关处理.Is力魄处理)
			{
				Singleton<版本相关处理>.I.MuPfGABrDe(P_0);
			}
			Singleton<版本相关处理>.I.Nk6fB0M6gJ(P_0);
		}
		catch (Exception ex)
		{
			Log.Error("战斗_进入处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void mPAGG43Ect(MyNATSocketClient P_0, byte[] P_1)
	{
	}

	
	internal async Task IhLGfPfE99(MyNATSocketClient P_0, byte[] P_1)
	{
		_ = 1;
		try
		{
			if (bv9GQKOlSY() && P_0.user.人物数据.账号 == Singleton<全局变量类>.I.狐狸和狗配置.托号账号)
			{
				lqoGYaYlNv.Clear();
			}
			if (妖族化形功能.使用中)
			{
				P_0.战斗化形事件 = null;
				P_0.战斗退出回调事件?.Invoke();
				Singleton<WdAPI>.I.妖族化形加成处理(P_0, Singleton<WdAPI>.I.取对应妖族类型(P_0.user.人物数据.形象ID), 是否化形: false);
			}
			if (yuKf6DUSQGygKeLSQdj.uf8U9RfBer())
			{
				P_0.智能怪物事件?.Invoke(obj: false);
			}
			if (P_0.user.缓存数据.当前战斗BOSS名字 == "吞天")
			{
				await Task.Delay(1000);
			}
			if (全局变量类.Is调试)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_杂项公告("战斗结果：" + P_0.user.缓存数据.is战斗逃跑指令));
			}
			await BSSG60OTqA(P_0, P_0.user.属性数据.当前气血, P_0.user.缓存数据.is战斗逃跑指令);
			Singleton<mDs6hiBvFvG3CRi3MZk>.I.ElmBC999cR(P_0);
			TimedDungeonService.I.OnCombatEnded(P_0);
		}
		catch (Exception ex)
		{
			Log.Error("战斗_结束处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public async Task BSSG60OTqA(MyNATSocketClient P_0, int P_1, bool P_2)
	{
		_ = 1;
		try
		{
			if (Singleton<全局变量类>.I.圣无双配置.功能开关 && P_0.user.人物数据.所在地图名字 == Singleton<全局变量类>.I.圣无双配置.地图名字 && Singleton<BpcEfFbiGBBV3s2B0ai>.I.zCybkJu0wB == AllEnums.圣无双Type.进行时 && (P_2 || P_1 <= 0))
			{
				await Singleton<BpcEfFbiGBBV3s2B0ai>.I.LnRbC8OVA0(P_0, P_2 || P_1 <= 0);
			}
			await Singleton<FBGRmlstyRWQdqi0pHa>.I.M3kUUiH02y(P_0, P_2 || P_1 <= 0);
		}
		catch (Exception ex)
		{
			Log.Error("接收_战斗结束相关处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public byte[] FuLG2pU2sy(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_读2.Seek(14L, SeekOrigin.Begin);
			byte[] first = 封包_读2.读字节集(2);
			if (Singleton<ByteAPI>.I.寻找字节集(P_1, "你本次额外挑战成功了#R", "层#n的星君，耗时"))
			{
				int num = int.Parse(Singleton<ByteAPI>.I.到文本(Singleton<ByteAPI>.I.取字节集中间(P_1, Singleton<ByteAPI>.I.到字节集("你本次额外挑战成功了#R"), Singleton<ByteAPI>.I.到字节集("层#n的星君"))));
				if (num > P_0.user.存档数据.通天塔突破层数)
				{
					P_0.user.存档数据.通天塔突破层数 = num;
				}
			}
			if (Singleton<ByteAPI>.I.寻找字节集(P_1, Singleton<ByteAPI>.I.到字节集("你成功的使用了#R金蝉脱壳#n")))
			{
				Singleton<WdAPI>.I.EOYImZQJeG(P_0, true);
				return P_1;
			}
			if (FcVoHRwOVsflDmDUQOP.JhVwZ5yCsf())
			{
				if (Singleton<ByteAPI>.I.寻找字节集(P_1, "恭喜你成功地捕捉到了"))
				{
					if (Enumerable.SequenceEqual(first, new byte[2] { 31, 229 }))
					{
						string value = 封包_读2.读文本型(是否声明长度: true, 1, 是否反转长度: true);
						P_0.召唤精怪事件?.Invoke(Singleton<ByteAPI>.I.取文本中间(value, "#Y", "#n"));
					}
					return null;
				}
				if (Singleton<ByteAPI>.I.寻找字节集(P_1, "捕捉精怪", "精怪#I有几率获得#I其它奖励|十阶坐骑"))
				{
					Singleton<FcVoHRwOVsflDmDUQOP>.I.g4XwraLKfV(P_0);
				}
			}
			if (XhaJ3cfswGhhnmIequv.vI0fNpyhWg())
			{
				日常存档类 value4;
				if (Singleton<ByteAPI>.I.寻找字节集或(P_1, Singleton<ByteAPI>.I.到字节集("恭喜你完成了#R降妖任务#n"), Singleton<ByteAPI>.I.到字节集("恭喜你完成了#R伏魔任务#n"), Singleton<ByteAPI>.I.到字节集("恭喜你完成了#R仙界通缉#n"), Singleton<ByteAPI>.I.到字节集("恭喜你完成了#R飞仙渡邪#n")))
				{
					if (P_0.user.存档数据.日常存档.TryGetValue(AllEnums.日常类型Type.刷道任务, out var value2))
					{
						Singleton<XhaJ3cfswGhhnmIequv>.I.ULvf8HlQXX(P_0, value2);
					}
				}
				else if (Singleton<ByteAPI>.I.寻找字节集(P_1, Singleton<ByteAPI>.I.到字节集("恭喜你，第"), Singleton<ByteAPI>.I.到字节集("轮修行顺利完成。")))
				{
					if (P_0.user.存档数据.日常存档.TryGetValue(AllEnums.日常类型Type.修行任务, out var value3))
					{
						Singleton<XhaJ3cfswGhhnmIequv>.I.ULvf8HlQXX(P_0, value3);
					}
				}
				else if (Singleton<ByteAPI>.I.寻找字节集(P_1, Singleton<ByteAPI>.I.到字节集("恭喜你，你的修为更进一步了。")) && P_0.user.存档数据.日常存档.TryGetValue(AllEnums.日常类型Type.寻仙任务, out value4))
				{
					Singleton<XhaJ3cfswGhhnmIequv>.I.ULvf8HlQXX(P_0, value4);
				}
			}
			if (Enumerable.SequenceEqual(first, Singleton<ByteAPI>.I.HtoC("2381")))
			{
				return tXYGmAP1CI(P_0, P_1);
			}
			if (Enumerable.SequenceEqual(first, Singleton<ByteAPI>.I.HtoC("2111")))
			{
				return notGP6BL9D(P_0, P_1);
			}
			if (Enumerable.SequenceEqual(first, Singleton<ByteAPI>.I.HtoC("2315")))
			{
				return f0SGXYOr5u(P_0, P_1);
			}
			if (Enumerable.SequenceEqual(first, Singleton<ByteAPI>.I.HtoC("FDA8")))
			{
				return MnrGFfQg01(P_0, P_1);
			}
			if (Enumerable.SequenceEqual(first, Singleton<ByteAPI>.I.HtoC("FA01")))
			{
				return lHxGLMKrTL(P_0, P_1);
			}
			if (Enumerable.SequenceEqual(first, Singleton<ByteAPI>.I.HtoC("1FE5")))
			{
				return uhdGSBJE4x(P_0, P_1);
			}
			if (Enumerable.SequenceEqual(first, Singleton<ByteAPI>.I.HtoC("20CF")))
			{
				return Singleton<i3kWo8GUakCSddRpyDe>.I.rAqGjiGmji(P_0, P_1);
			}
			if (Enumerable.SequenceEqual(first, Singleton<ByteAPI>.I.HtoC("0B0D")) && Singleton<ByteAPI>.I.寻找字节集(P_1, "乐意奉陪", "道友请出手"))
			{
				return Singleton<ByteAPI>.I.寻找字节集并替换(P_1, Singleton<ByteAPI>.I.到字节集("我很乐意奉陪，道友请出手！"), Singleton<ByteAPI>.I.到字节集("要想获得宝贝，得先打败我！"));
			}
			return P_1;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗_日志处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	private byte[] tXYGmAP1CI(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写 封包_写3 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_读2.读短整数型(reverse: true);
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写文本型(封包_读2.读文本型(out string _, true, (byte)0, false), hasCount: true, 0);
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写文本型(封包_读2.读文本型(out string value6, true, (byte)1, true), hasCount: true, 1, reverse: true);
			if (Singleton<ByteAPI>.I.寻找文本与(value6, "鬼才已经领教", "祝道友早日修成正果") && P_0.user.缓存数据.当前战斗BOSS名字 == "葫芦")
			{
				if (Singleton<全局变量类>.I.燃眉配置.功能开关 && !string.IsNullOrWhiteSpace(P_0.user.存档数据.燃眉之急任务.当前NPC) && P_0.user.存档数据.燃眉之急任务.任务类型 != 0 && P_0.user.存档数据.燃眉之急任务.任务星级 != 0)
				{
					Singleton<lrYK0bWD4sTSDkaJic1>.I.drqWNtYw8O(P_0, true);
				}
				return null;
			}
			封包_写3.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			封包_写2.写短整数型((short)(封包_写3.Length + 2), reverse: true);
			封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗_怪物对话处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	private byte[] notGP6BL9D(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写 封包_写3 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_读2.读短整数型(reverse: true);
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写3.写文本型(封包_读2.读文本型(out string _, true, (byte)0, false), hasCount: true, 0);
			封包_写3.写文本型(封包_读2.读文本型(out string _, true, (byte)1, true), hasCount: true, 1, reverse: true);
			封包_写3.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			封包_写2.写短整数型((short)(封包_写3.Length + 2), reverse: true);
			封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗_自己说话处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	private byte[] f0SGXYOr5u(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写 封包_写3 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_读2.读短整数型(reverse: true);
			封包_写3.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var value), reverse: true);
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定角色ID玩家MyClient(value);
			if (value == P_0.user.人物数据.角色ID)
			{
				P_0.user.缓存数据.初始战斗我方数据包 = P_1;
				P_0.user.缓存数据.初始战斗我方数据包 = CfLGyUB86q(P_0, true);
				P_0.user.缓存数据.初始战斗敌方数据包 = P_0.user.缓存数据.初始战斗我方数据包;
			}
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_读2.读整数型(reverse: true, out var value12);
			if (Singleton<全局变量类>.I.超级坐骑配置.功能开关 && Singleton<全局变量类>.I.超级坐骑配置.战斗开关)
			{
				value12 = Singleton<VuI4pmDQ6nQtpDAauah>.I.u3pD4VJ8HA(value12);
			}
			封包_写3.写整数型(value12, reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写文本型(封包_读2.读文本型(out string _, true, (byte)0, false), hasCount: true, 0);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写3.写文本型(封包_读2.读文本型(out string _, true, (byte)0, false), hasCount: true, 0);
			封包_写3.写文本型(封包_读2.读文本型(out string _, true, (byte)0, false), hasCount: true, 0);
			封包_写3.写文本型(封包_读2.读文本型(out string _, true, (byte)0, false), hasCount: true, 0);
			封包_写3.写文本型(封包_读2.读文本型(out string _, true, (byte)0, false), hasCount: true, 0);
			封包_写3.写字节集(封包_读2.读字节集(3), hasCount: false, 0);
			封包_写3.写字节集(封包_读2.读字节集(3), hasCount: false, 0);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_读2.读整数型(reverse: true, out var value26);
			if (myNATSocketClient != null && Singleton<全局变量类>.I.时装坐姿染色配置.时装坐姿开关 && Singleton<全局变量类>.I.时装坐姿染色配置.坐姿染色战斗开关)
			{
				if (!string.IsNullOrWhiteSpace(myNATSocketClient.user.存档数据.染色数据.染后坐姿ID) && value26.ToString() == myNATSocketClient.user.存档数据.染色数据.原坐姿ID)
				{
					int.TryParse(myNATSocketClient.user.存档数据.染色数据.染后坐姿ID, out value26);
				}
				else
				{
					string text = Singleton<pn8GKqU6fTj7IRdG6Bm>.I.S3gUL37bJn(myNATSocketClient.user.缓存数据.pexIuRNo9u.ToString(), myNATSocketClient.user.缓存数据.X4j8zimpds.ToString());
					if (!string.IsNullOrWhiteSpace(text))
					{
						int.TryParse(text, out value26);
					}
				}
			}
			封包_写3.写整数型(value26, reverse: true);
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写3.写字节型(封包_读2.读字节型(out var _));
			封包_写3.写字节集(封包_读2.读字节集(19), hasCount: false, 0);
			封包_写3.写文本型(封包_读2.读文本型(out string _, true, (byte)0, false), hasCount: true, 0);
			封包_写3.写字节型(封包_读2.读字节型(out var _));
			封包_写3.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			封包_写2.写短整数型((short)(封包_写3.Length + 2), reverse: true);
			封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗_宠物合体处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	private byte[] MnrGFfQg01(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写2.写字节集(封包_读2.读字节集(3), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value4), reverse: true);
			short value5 = 0;
			short value6 = 0;
			short value7 = 0;
			int value8 = 0;
			int value9 = 0;
			short value10 = 0;
			int value11 = 0;
			string value12 = string.Empty;
			for (int i = 0; i < value4; i++)
			{
				封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out value5), reverse: true);
				封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out value6), reverse: true);
				for (int j = 0; j < value6; j++)
				{
					封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out value7), reverse: true);
					封包_写2.写字节型(封包_读2.读字节型(out value8));
					switch (value8)
					{
					case 1:
						封包_写2.写字节型(封包_读2.读字节型(out value9));
						break;
					case 2:
						封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out value10), reverse: true);
						break;
					case 3:
						封包_写2.写整数型(封包_读2.读整数型(reverse: true, out value11), reverse: true);
						break;
					case 4:
						封包_写2.写文本型(封包_读2.读文本型(out value12, true, (byte)0, false), hasCount: true, 0);
						break;
					}
				}
			}
			封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗_日志FDA8处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	private byte[] lHxGLMKrTL(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value4), reverse: true);
			short value5 = 0;
			int value6 = 0;
			int value7 = 0;
			short value8 = 0;
			int value9 = 0;
			string value10 = string.Empty;
			for (int i = 0; i < value4; i++)
			{
				封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out value5), reverse: true);
				封包_写2.写字节型(封包_读2.读字节型(out value6));
				switch (value6)
				{
				case 1:
					封包_写2.写字节型(封包_读2.读字节型(out value7));
					break;
				case 2:
					封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out value8), reverse: true);
					break;
				case 3:
					封包_写2.写整数型(封包_读2.读整数型(reverse: true, out value9), reverse: true);
					break;
				case 4:
					封包_写2.写文本型(封包_读2.读文本型(out value10, true, (byte)0, false), hasCount: true, 0);
					break;
				}
			}
			封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗_日志FA01处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	private byte[] uhdGSBJE4x(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写2.写文本型(封包_读2.读文本型(out string _, true, (byte)1, true), hasCount: true, 1, reverse: true);
			封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗_日志1FE5处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	public byte[] uLnGcvtW3y(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写 封包_写3 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_读2.读短整数型(reverse: true);
			封包_写3.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写3.写整数型(封包_读2.读整数型(reverse: true, out var value), reverse: true);
			if (value == P_0.user.人物数据.角色ID)
			{
				P_0.user.缓存数据.初始战斗我方数据包 = P_1;
				P_0.user.缓存数据.初始战斗我方数据包 = CfLGyUB86q(P_0, true);
				P_0.user.缓存数据.初始战斗敌方数据包 = P_0.user.缓存数据.初始战斗我方数据包;
			}
			byte[] bytes = 封包_读2.读字节集(14);
			封包_写3.写字节集(bytes, hasCount: false, 0);
			封包_写3.写字节集(封包_读2.读字节集(16), hasCount: false, 0);
			byte[] bytes2 = 封包_读2.读字节集(4);
			封包_写3.写字节集(bytes2, hasCount: false, 0);
			byte[] bytes3 = 封包_读2.读字节集(4);
			封包_写3.写字节集(bytes3, hasCount: false, 0);
			byte[] bytes4 = 封包_读2.读字节集(8);
			封包_写3.写字节集(bytes4, hasCount: false, 0);
			string zone = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			封包_写3.写文本型(zone, hasCount: true, 0);
			封包_写3.写字节集(封包_读2.读字节集(4), hasCount: false, 0);
			byte[] bytes5 = 封包_读2.读字节集(2);
			封包_写3.写字节集(bytes5, hasCount: false, 0);
			string zone2 = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			封包_写3.写文本型(zone2, hasCount: true, 0);
			string zone3 = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			封包_写3.写文本型(zone3, hasCount: true, 0);
			string zone4 = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			封包_写3.写文本型(zone4, hasCount: true, 0);
			封包_写3.写文本型(封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true), hasCount: true, 0, reverse: true);
			byte[] bytes6 = 封包_读2.读字节集(3);
			封包_写3.写字节集(bytes6, hasCount: false, 0);
			byte[] bytes7 = 封包_读2.读字节集(3);
			封包_写3.写字节集(bytes7, hasCount: false, 0);
			封包_写3.写字节集(封包_读2.读字节集(4), hasCount: false, 0);
			byte[] bytes8 = 封包_读2.读字节集(4);
			封包_写3.写字节集(bytes8, hasCount: false, 0);
			byte[] bytes9 = 封包_读2.读字节集(4);
			封包_写3.写字节集(bytes9, hasCount: false, 0);
			byte[] bytes10 = 封包_读2.读字节集(4);
			封包_写3.写字节集(bytes10, hasCount: false, 0);
			byte[] bytes11 = 封包_读2.读字节集(4);
			封包_写3.写字节集(bytes11, hasCount: false, 0);
			byte[] bytes12 = 封包_读2.读字节集(2);
			封包_写3.写字节集(bytes12, hasCount: false, 0);
			byte[] bytes13 = 封包_读2.读字节集(2);
			封包_写3.写字节集(bytes13, hasCount: false, 0);
			封包_写3.写字节集(封包_读2.读字节集(1), hasCount: false, 0);
			封包_写3.写字节集(封包_读2.读字节集(19), hasCount: false, 0);
			封包_写3.写字节集(封包_读2.读字节集(1), hasCount: false, 0);
			string zone5 = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			封包_写3.写文本型(zone5, hasCount: true, 0, reverse: true);
			封包_写3.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			封包_写2.写短整数型((short)(封包_写3.Length + 2), reverse: true);
			封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return P_1;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_战斗成员信息刷新-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	internal byte[] uFlGndCwNW(MyNATSocketClient P_0, byte[] P_1)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals45 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals45.AYeTg4Arhf = P_0;
		int value = 0;
		short value2 = 0;
		int num = 0;
		string empty = string.Empty;
		封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
		封包_写 封包_写2 = new 封包_写();
		封包_读2.Seek(10L, SeekOrigin.Begin);
		封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
		int num2 = 封包_读2.读字节型();
		封包_写2.写字节型(num2);
		MyNATSocketClient myNATSocketClient = null;
		if (bv9GQKOlSY() && CS_0024_003C_003E8__locals45.AYeTg4Arhf.user.人物数据.账号 == Singleton<全局变量类>.I.狐狸和狗配置.托号账号)
		{
			if (lqoGYaYlNv.TryGetValue(CS_0024_003C_003E8__locals45.AYeTg4Arhf.插件端口, out var value3))
			{
				value3.Clear();
			}
			else
			{
				lqoGYaYlNv.TryAdd(CS_0024_003C_003E8__locals45.AYeTg4Arhf.插件端口, new ConcurrentDictionary<int, 砍尾怪物数据>());
			}
		}
		CS_0024_003C_003E8__locals45.SDyTDtPYKR = new List<int[]>();
		bool flag = false;
		for (int i = 0; i < num2; i++)
		{
			_003C_003Ec__DisplayClass20_1 CS_0024_003C_003E8__locals42 = new _003C_003Ec__DisplayClass20_1();
			CS_0024_003C_003E8__locals42.KUXT8xxamL = CS_0024_003C_003E8__locals45;
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out CS_0024_003C_003E8__locals42.rtuTlR4tQ7), reverse: true);
			封包_写2.写字节集(封包_读2.读字节集(2, out byte[] value4), hasCount: false, 0);
			封包_写2.写字节集(封包_读2.读字节集(4, out value4), hasCount: false, 0);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value5), reverse: true);
			string text = string.Empty;
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value6), reverse: true);
			for (int j = 0; j < value6; j++)
			{
				封包_写2.写字节集(封包_读2.读字节集(2, out byte[] value7), hasCount: false, 0);
				封包_写2.写字节型(封包_读2.读字节型(out var value8));
				switch (value8)
				{
				case 1:
					封包_写2.写字节型(封包_读2.读字节型(out value));
					break;
				case 2:
					封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out value2), reverse: true);
					break;
				case 3:
					num = 封包_读2.读整数型(reverse: true);
					if (value7 == Singleton<ByteAPI>.I.HtoC("0028") && num == 20053 && CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.Is燃煤葫芦)
					{
						num = 6331;
					}
					封包_写2.写整数型(num, reverse: true);
					break;
				case 4:
					empty = 封包_读2.读文本型(是否声明长度: true, 0);
					if (Enumerable.SequenceEqual(value7, new byte[2] { 0, 1 }))
					{
						if (empty == "鬼才" && CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.Is燃煤葫芦)
						{
							text = "葫芦";
							empty = "葫芦";
						}
						else
						{
							text = empty;
						}
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
			封包_写2.写字节集(封包_读2.读字节集(4), hasCount: false, 0);
			封包_读2.读字节集(4, out value4);
			if (CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.Is燃煤葫芦)
			{
				封包_写2.写整数型(6331, reverse: true);
			}
			else
			{
				封包_写2.写字节集(value4, hasCount: false, 0);
			}
			封包_写2.写字节集(封包_读2.读字节集(4, out value4), hasCount: false, 0);
			封包_读2.读整数型(reverse: true, out var value9);
			if (CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.Is燃煤葫芦)
			{
				封包_写2.写整数型(6331, reverse: true);
			}
			else
			{
				封包_写2.写整数型(value9, reverse: true);
			}
			封包_写2.写字节集(封包_读2.读字节集(12, out value4), hasCount: false, 0);
			byte[] bytes = 封包_读2.读字节集(4);
			if (CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.Is燃煤葫芦)
			{
				封包_写2.写整数型(6331, reverse: true);
			}
			else
			{
				封包_写2.写字节集(bytes, hasCount: false, 0);
			}
			封包_写2.写字节集(封包_读2.读字节集(4, out value4), hasCount: false, 0);
			封包_写2.写字节集(封包_读2.读字节集(4, out value4), hasCount: false, 0);
			封包_写2.写字节集(封包_读2.读字节集(4, out value4), hasCount: false, 0);
			封包_写2.写字节集(封包_读2.读字节集(4, out value4), hasCount: false, 0);
			封包_写2.写字节集(封包_读2.读字节集(4, out value4), hasCount: false, 0);
			封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
			myNATSocketClient = Singleton<MainService>.I.获取指定角色ID玩家MyClient(CS_0024_003C_003E8__locals42.rtuTlR4tQ7);
			if (妖族化形功能.使用中 && Singleton<全局变量类>.I.妖族化形配置.变身开关 && myNATSocketClient != null)
			{
				MyNATSocketClient myNATSocketClient2 = CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf;
				myNATSocketClient2.战斗化形事件 = (Action<string, bool>)Delegate.Combine(myNATSocketClient2.战斗化形事件, new Action<string, bool>(myNATSocketClient.化形同步处理));
				CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.战斗成员字典.TryAdd(myNATSocketClient.IdKey, value: false);
			}
			if (value5 == 3)
			{
				if (yuKf6DUSQGygKeLSQdj.uf8U9RfBer() && myNATSocketClient == null)
				{
					CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.智能怪物事件 =  (bool v1) =>
					{
						Singleton<yuKf6DUSQGygKeLSQdj>.I.BNoUTIgmnO(CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf, CS_0024_003C_003E8__locals42.rtuTlR4tQ7, v1);
					};
				}
				if (CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.当前战斗BOSS名字 == "-1" && CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.is战斗中)
				{
					if (myNATSocketClient != null)
					{
						CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.当前战斗BOSS名字 = string.Empty;
					}
					else if (Singleton<ByteAPI>.I.寻找文本等(text, "妖皇小弟", "北冥幼狮", "玄天刺猬", "小猪猡"))
					{
						if (CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.队伍数据.成员列表.Count > 0)
						{
							if (CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.队伍数据.is队长)
							{
								foreach (int item in CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.队伍数据.成员列表)
								{
									MyNATSocketClient myNATSocketClient3 = Singleton<MainService>.I.获取指定角色ID玩家MyClient(item);
									if (myNATSocketClient3 != null)
									{
										myNATSocketClient3.user.缓存数据.当前战斗BOSS名字 = (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.当前点击NPC名字, "入侵的") ? CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.当前点击NPC名字 : text);
									}
								}
							}
						}
						else
						{
							CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.当前战斗BOSS名字 = (Singleton<ByteAPI>.I.寻找文本(CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.当前点击NPC名字, "入侵的") ? CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.当前点击NPC名字 : text);
						}
					}
					else
					{
						CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.当前战斗BOSS名字 = ((myNATSocketClient != null) ? string.Empty : text);
					}
					CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.缓存数据.当前点击NPC名字 = string.Empty;
				}
			}
			if (!bv9GQKOlSY() || CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.队伍数据.成员列表.Count < 1 || !Singleton<ByteAPI>.I.寻找文本或(hBnG3iSkZ3, "|" + text + "|") || !(CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.人物数据.账号 == Singleton<全局变量类>.I.狐狸和狗配置.托号账号))
			{
				continue;
			}
			MyNATSocketClient myNATSocketClient4 = Singleton<MainService>.I.获取指定角色ID玩家MyClient(CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.user.队伍数据.成员列表[0]);
			if (myNATSocketClient4 != null && myNATSocketClient4.user.人物数据.账号 == Singleton<全局变量类>.I.狐狸和狗配置.队长账号)
			{
				flag = true;
				int num3 = Singleton<WdAPI>.I.qrjo9TWIdy(0, 9);
				CS_0024_003C_003E8__locals42.KUXT8xxamL.SDyTDtPYKR.Add(new int[2] { CS_0024_003C_003E8__locals42.rtuTlR4tQ7, num3 });
				if (lqoGYaYlNv.TryGetValue(CS_0024_003C_003E8__locals42.KUXT8xxamL.AYeTg4Arhf.插件端口, out var value10))
				{
					value10.TryAdd(CS_0024_003C_003E8__locals42.rtuTlR4tQ7, new 砍尾怪物数据
					{
						当前尾数值 = num3,
						最大气血值 = 0,
						Is已处理 = false
					});
				}
			}
		}
		CS_0024_003C_003E8__locals45.AYeTg4Arhf.user.缓存数据.Is燃煤葫芦 = false;
		if (flag)
		{
			CS_0024_003C_003E8__locals45.AYeTg4Arhf.砍尾火眼事件 =  () =>
			{
				CS_0024_003C_003E8__locals45.AYeTg4Arhf.砍尾火眼事件 = null;
				CS_0024_003C_003E8__locals45.AYeTg4Arhf.C_Send(Singleton<WdAPI>.I.AKCo4gK26i(CS_0024_003C_003E8__locals45.SDyTDtPYKR));
			};
		}
		return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
	}

	
	internal byte[] cauG527dwQ(MyNATSocketClient P_0, byte[] P_1)
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass21_0();
		P_0.user.缓存数据.初始战斗我方数据包 = null;
		P_0.user.缓存数据.初始战斗敌方数据包 = null;
		封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
		封包_写 封包_写2 = new 封包_写();
		封包_读2.Seek(10L, SeekOrigin.Begin);
		封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
		int num = 封包_读2.读字节型();
		封包_写2.写字节型(num);
		short value = 0;
		for (int i = 0; i < num; i++)
		{
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out CS_0024_003C_003E8__locals6.HEuTo6Nput), reverse: true);
			封包_写2.写字节集(封包_读2.读字节集(4), hasCount: false, 0);
			byte[] array = 封包_读2.读字节集(2);
			封包_写2.写字节集(array, hasCount: false, 0);
			if (CS_0024_003C_003E8__locals6.HEuTo6Nput == P_0.user.人物数据.角色ID)
			{
				P_0.user.缓存数据.战斗武器模型 = Singleton<ByteAPI>.I.反转_短整数(array);
			}
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out value), reverse: true);
			if (妖族化形功能.使用中 && Singleton<全局变量类>.I.妖族化形配置.变身开关)
			{
				MyNATSocketClient myNATSocketClient = Singleton<全局变量类>.I.会话Dict.Values.ToList().Find( (MyNATSocketClient x) => x.当前client.Online && x.转发client.Online && x.user.人物数据.角色ID == CS_0024_003C_003E8__locals6.HEuTo6Nput);
				if (myNATSocketClient != null)
				{
					P_0.战斗化形事件 = (Action<string, bool>)Delegate.Combine(P_0.战斗化形事件, new Action<string, bool>(myNATSocketClient.化形同步处理));
					P_0.user.缓存数据.战斗成员字典.TryAdd(myNATSocketClient.IdKey, value: true);
				}
			}
			short num2 = 封包_读2.读短整数型(reverse: true);
			封包_写2.写短整数型(num2, reverse: true);
			for (int num3 = 0; num3 < num2; num3++)
			{
				byte[] array2 = 封包_读2.读字节集(2);
				封包_写2.写字节集(array2, hasCount: false, 0);
				int num4 = 封包_读2.读字节型();
				封包_写2.写字节型(num4);
				switch (num4)
				{
				case 1:
				{
					byte[] bytes2 = 封包_读2.读字节集(1);
					封包_写2.写字节集(bytes2, hasCount: false, 0);
					break;
				}
				case 2:
				{
					byte[] bytes = 封包_读2.读字节集(2);
					封包_写2.写字节集(bytes, hasCount: false, 0);
					break;
				}
				case 3:
				{
					int value2 = 封包_读2.读整数型(reverse: true);
					if (!Enumerable.SequenceEqual(array2, new byte[2] { 0, 40 }) && !Enumerable.SequenceEqual(array2, new byte[2] { 0, 41 }) && !Enumerable.SequenceEqual(array2, new byte[2] { 0, 204 }) && !Enumerable.SequenceEqual(array2, new byte[2] { 2, 118 }) && !Enumerable.SequenceEqual(array2, new byte[2] { 2, 119 }) && !Enumerable.SequenceEqual(array2, new byte[2] { 0, 11 }) && !Enumerable.SequenceEqual(array2, new byte[2] { 0, 12 }) && !Enumerable.SequenceEqual(array2, new byte[2] { 0, 6 }))
					{
						Enumerable.SequenceEqual(array2, new byte[2] { 0, 7 });
					}
					封包_写2.写整数型(value2, reverse: true);
					break;
				}
				case 4:
				{
					string zone = 封包_读2.读文本型(是否声明长度: true, 0);
					Enumerable.SequenceEqual(array2, new byte[2] { 0, 1 });
					封包_写2.写文本型(zone, hasCount: true, 0, reverse: true);
					break;
				}
				}
			}
			byte[] bytes3 = 封包_读2.读字节集(4);
			封包_写2.写字节集(bytes3, hasCount: false, 0);
			bytes3 = 封包_读2.读字节集(4);
			封包_写2.写字节集(bytes3, hasCount: false, 0);
			bytes3 = 封包_读2.读字节集(4);
			封包_写2.写字节集(bytes3, hasCount: false, 0);
			bytes3 = 封包_读2.读字节集(4);
			封包_写2.写字节集(bytes3, hasCount: false, 0);
			if (CS_0024_003C_003E8__locals6.HEuTo6Nput == P_0.user.人物数据.角色ID)
			{
				P_0.user.缓存数据.战斗角色模型 = Singleton<ByteAPI>.I.反转_整数(bytes3);
			}
			bytes3 = 封包_读2.读字节集(4);
			封包_写2.写字节集(bytes3, hasCount: false, 0);
			bytes3 = 封包_读2.读字节集(4);
			封包_写2.写字节集(bytes3, hasCount: false, 0);
			bytes3 = 封包_读2.读字节集(4);
			封包_写2.写字节集(bytes3, hasCount: false, 0);
			byte[] array3 = 封包_读2.读字节集(4);
			封包_写2.写字节集(array3, hasCount: false, 0);
			if (CS_0024_003C_003E8__locals6.HEuTo6Nput == P_0.user.人物数据.角色ID)
			{
				P_0.user.缓存数据.战斗坐姿模型 = Singleton<ByteAPI>.I.反转_整数(array3);
			}
			bytes3 = 封包_读2.读字节集(4);
			封包_写2.写字节集(bytes3, hasCount: false, 0);
			if (CS_0024_003C_003E8__locals6.HEuTo6Nput == P_0.user.人物数据.角色ID)
			{
				P_0.user.缓存数据.战斗状态标识 = bytes3;
			}
			bytes3 = 封包_读2.读字节集(16);
			封包_写2.写字节集(bytes3, hasCount: false, 0);
			string text = 封包_读2.读文本型(是否声明长度: true, 0, 是否反转长度: true);
			封包_写2.写文本型(text, hasCount: true, 0, reverse: true);
			P_0.user.缓存数据.战斗铭牌文本 = text;
		}
		P_0.user.缓存数据.初始战斗我方数据包 = CfLGyUB86q(P_0, true);
		P_0.user.缓存数据.初始战斗我方数据包 = CfLGyUB86q(P_0, false);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	internal byte[] DtcGMUj4dN(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			P_0.user.缓存数据.is战斗逃跑指令 = false;
			P_0.Su32wKC833.Clear();
			P_0.user.缓存数据.战斗回合数 = P_1[^1];
			P_0.C_Send(P_1);
			if (P_0.user.缓存数据.战斗回合数 >= 149)
			{
				Singleton<WdAPI>.I.EOYImZQJeG(P_0, true);
				P_0.S_Send(Singleton<WdAPI>.I.zXxoPwQcb0(P_0.user.人物数据.昵称));
			}
			if (妖族化形功能.使用中 && Singleton<WdAPI>.I.取对应化形ID(P_0.user.人物数据.形象ID) != 0)
			{
				if (P_0.user.存档数据.妖族化形数据.Is已化形)
				{
					P_0.user.存档数据.妖族化形数据.化形值 = 0;
					P_0.user.存档数据.妖族化形数据.已化形回合数++;
					if (P_0.user.存档数据.妖族化形数据.已化形回合数 >= 3)
					{
						P_0.user.存档数据.妖族化形数据.已化形回合数 = 0;
						P_0.user.存档数据.妖族化形数据.Is已化形 = false;
						P_0.战斗化形事件?.Invoke(P_0.IdKey, arg2: false);
						Singleton<WdAPI>.I.妖族化形加成处理(P_0, Singleton<WdAPI>.I.取对应妖族类型(P_0.user.人物数据.形象ID), 是否化形: false);
					}
				}
				else
				{
					P_0.user.存档数据.妖族化形数据.化形值 += 10;
					int num = Singleton<WdAPI>.I.qrjo9TWIdy(70, 100);
					if (P_0.user.存档数据.妖族化形数据.化形值 > num || P_0.user.存档数据.妖族化形数据.化形值 >= 100)
					{
						P_0.user.存档数据.妖族化形数据.Is已化形 = true;
					}
					if (P_0.user.存档数据.妖族化形数据.Is已化形)
					{
						P_0.战斗化形事件?.Invoke(P_0.IdKey, arg2: true);
						Singleton<WdAPI>.I.妖族化形加成处理(P_0, Singleton<WdAPI>.I.取对应妖族类型(P_0.user.人物数据.形象ID), 是否化形: true);
					}
					P_0.C_Send(Singleton<WdAPI>.I.组装化形面板(P_0.user.存档数据.妖族化形数据.化形值));
				}
			}
			if (P_0.user.缓存数据.战斗回合数 == 1)
			{
				P_0.砍尾火眼事件?.Invoke();
				if (yuKf6DUSQGygKeLSQdj.uf8U9RfBer())
				{
					P_0.智能怪物事件?.Invoke(obj: true);
				}
				if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND())
				{
					Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.XnTmU999dI(P_0);
				}
			}
			return P_1;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_战斗回合刷新-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	public byte[] bPoGhSEhXT(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			if (!全局变量类.Is调试)
			{
				return P_1;
			}
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(封包_读2.读字节集(8), hasCount: false, 0);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value), reverse: true);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var _), reverse: true);
			if (value > 8)
			{
				封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
				封包_读2.读整数型(reverse: true, out var value5);
				封包_写2.写整数型(问道数据类.怀旧技能字典.ContainsKey(value5) ? 问道数据类.怀旧技能字典[value5] : value5, reverse: true);
			}
			return 封包_写2.取数据();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("接收_战斗技能释放处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	public byte[] byxGvYsLUM(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			if (!全局变量类.Is调试)
			{
				return P_1;
			}
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 obj = new 封包_写();
			obj.写字节集(封包_读2.读字节集(12), hasCount: false, 0);
			封包_读2.读整数型(reverse: true, out var value);
			封包_读2.读整数型(reverse: true, out var value2);
			封包_读2.读短整数型(reverse: true, out var value3);
			封包_读2.读整数型(reverse: true, out var value4);
			obj.写整数型(value, reverse: true);
			obj.写整数型(value2, reverse: true);
			obj.写短整数型(value3, reverse: true);
			obj.写整数型(value4, reverse: true);
			obj.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			return obj.取数据();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗_过程处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	internal byte[] ksPG7uEnJM(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(封包_读2.读字节集(12), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var value), reverse: true);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			封包_读2.读整数型(reverse: true, out var value3);
			封包_读2.读整数型(reverse: true, out var value4);
			if (Ab7Ypu2aCcHMcLPG8Um.o5DmWnO5ND() && value3 == 3 && Ab7Ypu2aCcHMcLPG8Um.rK5msrHmp8(P_0.user.人物数据.所在地图名字, value4, out var value5))
			{
				byte[] first = Singleton<WdAPI>.I.组包指令取消框(value);
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#R");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.所在地图名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n内战斗不允许使用#R");
				defaultInterpolatedStringHandler.AppendFormatted(value5);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(first.Concat(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
				return null;
			}
			if (妖族化形功能.使用中 && value4 >= 2210 && value4 <= 2214 && value == P_0.user.人物数据.角色ID && Singleton<WdAPI>.I.取对应化形ID(P_0.user.人物数据.形象ID) != 0)
			{
				value4 = 501;
			}
			Singleton<版本相关处理>.I.战斗释放技能刷新属性(P_0, value, value3, value4);
			封包_写2.写整数型(value3, reverse: true);
			封包_写2.写整数型(value4, reverse: true);
			封包_写2.写字节集(封包_读2.读字节集(4), hasCount: false, 0);
			return 封包_写2.取数据();
		}
		catch (Exception ex)
		{
			Log.Error("战斗操作指令处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return null;
		}
	}

	
	public byte[] sKHGaxjugr(MyNATSocketClient P_0)
	{
		try
		{
			if (P_0.user.缓存数据.实时战斗buff包.Length != 0)
			{
				byte[] 实时战斗buff包 = P_0.user.缓存数据.实时战斗buff包;
				实时战斗buff包[^3] = (byte)(P_0.user.存档数据.妖族化形数据.Is已化形 ? 4u : 0u);
				return 实时战斗buff包;
			}
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(new byte[2] { 65, 7 }, hasCount: false, 0);
			封包_写2.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(P_0.user.人物数据.角色ID), hasCount: false, 0);
			封包_写2.写字节集(new byte[2] { 0, 7 }, hasCount: false, 0);
			封包_写2.写字节集(new byte[2], hasCount: false, 0);
			封包_写2.写字节集(new byte[1], hasCount: false, 0);
			封包_写2.写字节集(new byte[1], hasCount: false, 0);
			封包_写2.写字节集(new byte[21], hasCount: false, 0);
			if (P_0.user.存档数据.妖族化形数据.Is已化形)
			{
				封包_写2.写字节集(new byte[1] { 4 }, hasCount: false, 0);
			}
			else
			{
				封包_写2.写字节集(new byte[1], hasCount: false, 0);
			}
			封包_写2.写字节集(new byte[2], hasCount: false, 0);
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return obj.取数据();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗_化形buff处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_0.user.缓存数据.实时战斗buff包;
		}
	}

	
	public byte[] bdpGTXnDUu(MyNATSocketClient P_0, short P_1 = 8023, string P_2 = "如有神助")
	{
		try
		{
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(new byte[2] { 38, 4 }, hasCount: false, 0);
			封包_写2.写整数型(P_0.user.人物数据.角色ID, reverse: true);
			封包_写2.写短整数型(P_1, reverse: true);
			封包_写2.写字节集(new byte[4] { 0, 0, 0, 4 }, hasCount: false, 0);
			封包_写2.写文本型(P_2, hasCount: true, 0, reverse: true);
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return obj.取数据();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("组装_战斗成员化形特效-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return null;
		}
	}

	
	public byte[] j03G92ZUrm(MyNATSocketClient P_0, bool P_1)
	{
		try
		{
			封包_写 封包_写2 = new 封包_写();
			封包_写 封包_写3 = new 封包_写();
			封包_写2.写字节集(new byte[2] { 26, 41 }, hasCount: false, 0);
			封包_写3.写字节集(new byte[2] { 35, 21 }, hasCount: false, 0);
			封包_写3.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(P_0.user.人物数据.角色ID), hasCount: false, 0);
			封包_写3.写字节集(new byte[6], hasCount: false, 0);
			封包_写3.写字节集(new byte[4], hasCount: false, 0);
			封包_写3.写字节集(new byte[4], hasCount: false, 0);
			封包_写3.写字节集(new byte[16], hasCount: false, 0);
			封包_写3.写字节集(new byte[4], hasCount: false, 0);
			封包_写3.写字节集(new byte[4], hasCount: false, 0);
			封包_写3.写字节集(new byte[8], hasCount: false, 0);
			封包_写3.写文本型(P_0.user.人物数据.昵称, hasCount: true, 0);
			封包_写3.写字节集(new byte[4], hasCount: false, 0);
			封包_写3.写字节集(Singleton<ByteAPI>.I.到字节集((short)P_0.user.属性数据.等级), hasCount: false, 0);
			封包_写3.写文本型(P_0.user.人物数据.称谓, hasCount: true, 0, reverse: true);
			封包_写3.写文本型(P_0.user.缓存数据.family, hasCount: true, 0, reverse: true);
			封包_写3.写文本型(P_0.user.人物数据.门派, hasCount: true, 0, reverse: true);
			封包_写3.写文本型(P_0.user.缓存数据.战斗铭牌文本, hasCount: true, 0, reverse: true);
			封包_写3.写字节集(new byte[10] { 0, 0, 0, 0, 0, 4, 0, 0, 0, 0 }, hasCount: false, 0);
			封包_写3.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(P_0.user.人物数据.形象ID), hasCount: false, 0);
			封包_写3.写字节集(new byte[4], hasCount: false, 0);
			int value = Singleton<WdAPI>.I.取对应化形ID(P_0.user.人物数据.形象ID);
			封包_写3.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(value), hasCount: false, 0);
			封包_写3.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(value), hasCount: false, 0);
			封包_写3.写字节集(P_0.user.缓存数据.战斗状态标识, hasCount: false, 0);
			封包_写3.写字节集(new byte[23], hasCount: false, 0);
			封包_写2.写短整数型((short)(封包_写3.Length + 2), reverse: true);
			封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return obj.取数据().Concat(bdpGTXnDUu(P_0, (short)Singleton<WdAPI>.I.取对应化形特效(P_0.user.人物数据.形象ID, P_1), "化形")).ToArray();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗_成员化形开启-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return null;
		}
	}

	
	public byte[] CfLGyUB86q(MyNATSocketClient P_0, bool P_1)
	{
		try
		{
			if (P_0.user.缓存数据.初始战斗我方数据包 != null)
			{
				return P_0.user.缓存数据.初始战斗我方数据包.Concat(bdpGTXnDUu(P_0, 8331, "取消化形")).ToArray();
			}
			封包_写 封包_写2 = new 封包_写();
			封包_写 封包_写3 = new 封包_写();
			封包_写2.写字节集(new byte[2] { 26, 41 }, hasCount: false, 0);
			封包_写3.写字节集(new byte[2] { 35, 21 }, hasCount: false, 0);
			封包_写3.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(P_0.user.人物数据.角色ID), hasCount: false, 0);
			封包_写3.写字节集(new byte[6] { 1, 2, 0, 75, 0, 2 }, hasCount: false, 0);
			封包_写3.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(P_0.user.缓存数据.战斗武器模型), hasCount: false, 0);
			封包_写3.写字节集(new byte[4] { 0, 0, 0, 1 }, hasCount: false, 0);
			封包_写3.写字节集(new byte[16], hasCount: false, 0);
			封包_写3.写字节集(new byte[4] { 0, 0, 23, 208 }, hasCount: false, 0);
			if (P_0.user.缓存数据.战斗坐骑模型 != 0)
			{
				封包_写3.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(P_0.user.缓存数据.战斗坐骑模型), hasCount: false, 0);
				封包_写3.写字节集(new byte[8] { 0, 0, 0, 0, 0, 0, 0, 1 }, hasCount: false, 0);
			}
			else
			{
				封包_写3.写字节集(new byte[4], hasCount: false, 0);
				封包_写3.写字节集(new byte[8], hasCount: false, 0);
			}
			封包_写3.写文本型(P_0.user.人物数据.昵称, hasCount: true, 0);
			封包_写3.写字节集(new byte[4], hasCount: false, 0);
			封包_写3.写字节集(Singleton<ByteAPI>.I.到字节集((short)P_0.user.属性数据.等级), hasCount: false, 0);
			封包_写3.写文本型(P_0.user.人物数据.称谓, hasCount: true, 0, reverse: true);
			封包_写3.写文本型("使用称号", hasCount: true, 0, reverse: true);
			封包_写3.写文本型(P_0.user.人物数据.门派, hasCount: true, 0, reverse: true);
			封包_写3.写文本型(P_0.user.缓存数据.战斗铭牌文本, hasCount: true, 0, reverse: true);
			封包_写3.写字节集(new byte[10] { 0, 0, 0, 0, 0, 4, 0, 0, 0, 0 }, hasCount: false, 0);
			封包_写3.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(P_0.user.人物数据.形象ID), hasCount: false, 0);
			封包_写3.写字节集(new byte[4], hasCount: false, 0);
			封包_写3.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(P_0.user.人物数据.形象ID), hasCount: false, 0);
			if (P_0.user.缓存数据.战斗坐姿模型 != 0)
			{
				封包_写3.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(P_0.user.缓存数据.战斗坐姿模型), hasCount: false, 0);
			}
			else
			{
				封包_写3.写字节集(Singleton<ByteAPI>.I.到字节集固定反转(P_0.user.缓存数据.战斗角色模型), hasCount: false, 0);
			}
			封包_写3.写字节集(P_0.user.缓存数据.战斗状态标识, hasCount: false, 0);
			封包_写3.写字节集(new byte[23], hasCount: false, 0);
			封包_写2.写短整数型((short)(封包_写3.Length + 2), reverse: true);
			封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
			封包_写 obj = new 封包_写();
			obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
			obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			return obj.取数据().Concat(bdpGTXnDUu(P_0, 8331, "取消化形")).ToArray();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗_成员化形取消-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return null;
		}
	}

	
	internal byte[] JIbGCjRRkh(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			if (!lqoGYaYlNv.TryGetValue(P_0.插件端口, out var value))
			{
				return P_1;
			}
			int num = 0;
			int num2 = 0;
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写 封包_写3 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value2), reverse: true);
			for (int i = 0; i < value2; i++)
			{
				封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var value3), reverse: true);
				封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value4), reverse: true);
				封包_写3.清数据();
				num = 0;
				num2 = 0;
				for (int j = 0; j < value4; j++)
				{
					封包_写3.写短整数型(封包_读2.读短整数型(reverse: true, out var value5), reverse: true);
					封包_写3.写字节型(封包_读2.读字节型(out var value6));
					switch (value6)
					{
					case 1:
						封包_写3.写字节型(封包_读2.读字节型());
						break;
					case 2:
						封包_写3.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
						break;
					case 3:
					{
						int num3 = 封包_读2.读整数型(reverse: true);
						switch (value5)
						{
						case 6:
							num = num3;
							break;
						case 7:
							num2 = num3;
							break;
						}
						封包_写3.写整数型(num3, reverse: true);
						break;
					}
					case 4:
						封包_写3.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
						break;
					}
				}
				if (value.ContainsKey(value3))
				{
					封包_写2.写字节集(tqsGVyD6Ms(封包_写3.取数据(), P_0, value4, value3, num, num2), hasCount: false, 0);
				}
				else
				{
					封包_写2.写字节集(封包_写3.取数据(), hasCount: false, 0);
				}
			}
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("组包火眼金睛返回-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	private byte[] tqsGVyD6Ms(byte[] P_0, MyNATSocketClient P_1, int P_2, int P_3, int P_4, int P_5)
	{
		if (!lqoGYaYlNv.TryGetValue(P_1.插件端口, out var value))
		{
			return P_0;
		}
		if (!value.TryGetValue(P_3, out var value2))
		{
			return P_0;
		}
		value2.最大气血值 = P_5;
		value2.显示气血值 = P_5 / 10 * 10 + value2.当前尾数值;
		封包_读 封包_读2 = new 封包_读(P_0, 0, P_0.Length);
		封包_写 封包_写2 = new 封包_写();
		for (int i = 0; i < P_2; i++)
		{
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value3), reverse: true);
			封包_写2.写字节型(封包_读2.读字节型(out var value4));
			switch (value4)
			{
			case 1:
				封包_写2.写字节型(封包_读2.读字节型());
				break;
			case 2:
				封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
				break;
			case 3:
			{
				int value5 = 封包_读2.读整数型(reverse: true);
				switch (value3)
				{
				case 6:
					if (P_4 == value2.最大气血值)
					{
						value5 = value2.显示气血值;
					}
					break;
				case 7:
					value5 = value2.显示气血值;
					break;
				}
				封包_写2.写整数型(value5, reverse: true);
				break;
			}
			case 4:
				封包_写2.写文本型(封包_读2.读文本型(是否声明长度: true, 0), hasCount: true, 0);
				break;
			}
		}
		return 封包_写2.取数据();
	}

	
	internal byte[] FVYGkutIN2(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_读2.Seek(10L, SeekOrigin.Begin);
			封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var value), reverse: true);
			if (!lqoGYaYlNv.TryGetValue(P_0.插件端口, out var value2))
			{
				return P_1;
			}
			if (!value2.TryGetValue(value, out var value3))
			{
				return P_1;
			}
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var _), reverse: true);
			int value5 = ByteAPI.BytesToInt(封包_读2.读字节集(4));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 5);
			defaultInterpolatedStringHandler.AppendLiteral("砍尾-组包战斗处理数值：[物体ID=");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("] [尾数值=");
			defaultInterpolatedStringHandler.AppendFormatted(value3.当前尾数值);
			defaultInterpolatedStringHandler.AppendLiteral("] [最大气血值=");
			defaultInterpolatedStringHandler.AppendFormatted(value3.最大气血值);
			defaultInterpolatedStringHandler.AppendLiteral("] [显示气血值=");
			defaultInterpolatedStringHandler.AppendFormatted(value3.显示气血值);
			defaultInterpolatedStringHandler.AppendLiteral("] [实际伤害=");
			defaultInterpolatedStringHandler.AppendFormatted(value5);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
			if (Math.Abs(value5) == value3.最大气血值)
			{
				value5 = -value3.显示气血值;
			}
			if (全局变量类.Is调试)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder2);
				handler.AppendLiteral(" [显示实际伤害=");
				handler.AppendFormatted(value5);
				handler.AppendLiteral("]");
				stringBuilder2.Append(ref handler);
				P_0.C_Send(Singleton<WdAPI>.I.提示_杂项公告(stringBuilder.ToString()));
			}
			byte[] bytes = ByteAPI.IntToBytes(value5);
			封包_写2.写字节集(bytes, hasCount: false, 0);
			封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
			return Singleton<WdAPI>.I.组包包头(封包_写2.取数据());
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("组包战斗处理数值-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	internal byte[] AObG06rAnP(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			封包_写 封包_写2 = new 封包_写();
			封包_写2.写字节集(封包_读2.读字节集(12), hasCount: false, 0);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var value), reverse: true);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true, out var value2), reverse: true);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true), reverse: true);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true), reverse: true);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true, out var value3), reverse: true);
			if (value3 == 17)
			{
				ConcurrentDictionary<string, int> su32wKC = P_0.Su32wKC833;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				if (su32wKC.ContainsKey(defaultInterpolatedStringHandler.ToStringAndClear()))
				{
					return null;
				}
				ConcurrentDictionary<string, int> su32wKC2 = P_0.Su32wKC833;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				su32wKC2.TryAdd(defaultInterpolatedStringHandler.ToStringAndClear(), 1);
			}
			int value4 = 封包_读2.读整数型(reverse: true);
			封包_写2.写整数型(value4, reverse: true);
			封包_写2.写整数型(封包_读2.读整数型(reverse: true), reverse: true);
			封包_写2.写短整数型(封包_读2.读短整数型(reverse: true), reverse: true);
			return 封包_写2.取数据();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗_动作播放处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	internal byte[] xxjGOAKAtD(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
			new 封包_写().写字节集(封包_读2.读字节集(12), hasCount: false, 0);
			封包_读2.读整数型(reverse: true, out var value);
			封包_读2.读整数型(reverse: true, out var value2);
			封包_读2.读整数型(reverse: true, out var value3);
			if (value3 == 17)
			{
				ConcurrentDictionary<string, int> su32wKC = P_0.Su32wKC833;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				if (su32wKC.ContainsKey(defaultInterpolatedStringHandler.ToStringAndClear()))
				{
					return null;
				}
				ConcurrentDictionary<string, int> su32wKC2 = P_0.Su32wKC833;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				su32wKC2.TryAdd(defaultInterpolatedStringHandler.ToStringAndClear(), 1);
			}
			return P_1;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗_动作播放处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	public OmF9SPGlN77YLFkkoqN()
	{
		lqoGYaYlNv = new ConcurrentDictionary<int, ConcurrentDictionary<int, 砍尾怪物数据>>();
	}

	
	static OmF9SPGlN77YLFkkoqN()
	{
		hBnG3iSkZ3 = "|野狗|野狗头领|狐狸|狐狸头领|";
	}
}
