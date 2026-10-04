using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AM5rMIgHdrOR1f8tXCQ;
using B2uVXfUco7vjsxVN2Bc;
using B6XRmUwQK7iatdTWLwc;
using CKS3DKsTBrUPphoeWmS;
using CrwA1FwcYB2ZUOWYe7I;
using DRafti6FMxQYhxQAQHW;
using EKROCVD7DRi8Cx5mpUu;
using GJSyJYUDOfxE331QwT1;
using H0Y8GEJQx5wfb6t3alR;
using HS2GfXB7hJCX6tDXuc0;
using KEvDjBdeoLOoBKWXFAH;
using LpZ3AarVOTSw8FiAAE;
using MAZG7tsAp4qxkk1uF8R;
using MGlqQ3brPEBI9uuUVKc;
using MOuTmqw7qFKlAkRNasG;
using Ncq4nMwbH5sPfLR2xwf;
using Newtonsoft.Json;
using P80h4IDRZbpvERvsoap;
using PB0xx2KvGeQt7ty6y1C;
using PJ8VymWjWDfaUUlTW62;
using QsZODwJPWinsfjttlCn;
using R0F7EJKsPwFRj7h6amU;
using R8lTaqgbEc6MvH2j6n0;
using S0XwWmgI18jlYE3IPoe;
using Serilog;
using SuTsFOBHSZNdBh5bUZB;
using TouchSocket.Core;
using UQuLZEj71kRGhQn6jmQ;
using UbblDNG1yFpxk6Q0ui4;
using XWKUjNiqpjLqc4emuCT;
using YHD6B3jthayZBFfLsaY;
using YOheREbBnDq6LvvWZEr;
using aSItGBlifY3VT2BvkBH;
using aqNktcWvi5bXttp7syQ;
using bDlweAW3n8LaSgX06LQ;
using cVS5v9gmXX8TceaB2WW;
using cwZ0hNl9X9ytQCThyJG;
using dgvsPcDEiqYFlrnMMor;
using eYLrotRIovAGM9lAtVf;
using gEdioZfkTLM2TXU6jgd;
using hUWm54DrC1dskj6PIsS;
using irBd2ubEj0IMVbGRstp;
using ixYEhcwWIdwrtDxOO94;
using jVVIM9j1PL0VAliGELE;
using kNOi3Vbgo4LTDja4YFk;
using mxyyZlfUTTOCu8Y4ZsN;
using o6qwVWbu5whwUP31LfM;
using q52xqsRVVwmOLlpWkb3;
using r6H7Ets2Rns31EhC17Y;
using rNxGErgTwcV0cyHVsjc;
using s4E8DnU2AI3UWfigLPZ;
using sVcPYnW2a67ob5mDj4x;
using srBApEg0K2LqE1QaSFj;
using swC6eeDmDlHvujbhoCw;
using tMMEyfgcW4XCGjj522C;
using uI75fJjR7A2e7wWdq9f;
using vEAdPGPTkDFOYsbi303;
using wcxwepjSDDAt5sUJfS8;
using xqlPMM2TJRNXpZnNDFn;
using y24fbEG8KTuMIdiCbG1;
using yopQYJj0MvaHRRJcMLp;
using zA970iRwZCxW0g6uljn;

public class 全局变量类 : Singleton<全局变量类>
{
	public string qqs;

	public static string[] 禁止注册名字;

	public ConcurrentList<int> 临时id字典;

	public ConcurrentDictionary<string, int> 在线IP计数字典;

	public bool 卡密验证状态;

	public Action<byte[]> Client频道事件;

	public Action 限时属性事件;

	public Action 点卡扣除事件;

	public static string 插件类型;

	public static string ServerHash;

	public static string ClientHash;

	public static bool Is调试;

	public static bool Is所有地图;

	public int 注册id;

	public MyGdTcpClient 验证client;

	public MyHPServer 网关Server;

	public MyFccServer 防CCServer;

	public bool 插件启动状态;

	public static byte[] HeadData;

	public static byte[] 问道头;

	public static int[] 全_坐骑;

	public string 全_本区区名;

	public string 公告存档;

	public ConcurrentDictionary<string, string> 异常字典;

	public AsyncFileWriter writer;

	public 网关配置 网关Config;

	public ConcurrentList<注册信息> 注册列表;

	public ConcurrentDictionary<string, string> 所有地图字典;

	public ConcurrentDictionary<int, ConcurrentDictionary<int, NPC信息类>> 所有NPC字典;

	public ConcurrentQueue<string> 下线账号列表;

	public List<可发货物品列表类> 王中王物品列表;

	public byte[] 王中王整体封包;

	public List<商城数据类> 商城数据列表;

	public MainConfig config;

	public 南极配置类 南极配置;

	public 累充配置类 累充配置;

	public 燃眉配置类 燃眉配置;

	public 邮箱配置类 邮箱配置;

	public 超级坐骑配置类 超级坐骑配置;

	public 商城限购配置类 商城限购配置;

	public 圣无双配置类 圣无双配置;

	public 挑战BOSS配置类 挑战BOSS配置;

	public 时装坐姿染色配置类 时装坐姿染色配置;

	public 自选道具配置类 自选道具配置;

	public 通天塔突破配置类 通天塔突破配置;

	public 推荐拉人配置类 推荐拉人配置;

	public 门派转换配置类 门派转换配置;

	public 六道轮回配置类 六道轮回配置;

	public 一键大飞配置类 一键大飞配置;

	public 法宝共生配置类 法宝共生配置;

	public 异兽录配置类 异兽录配置;

	public 指定会员配置类 指定会员配置;

	public 礼包开元宝配置类 礼包开元宝配置;

	public 超级道具配置类 超级道具配置;

	public 宠物绑定配置类 宠物绑定配置;

	public 升级奖励配置类 升级奖励配置;

	public 宠物召唤配置类 宠物召唤配置;

	public 浮生录配置类 浮生录配置;

	public 超级地图配置类 超级地图配置;

	public 喊话限制配置类 喊话限制配置;

	public 属性洗炼配置类 属性洗炼配置;

	public 全服共享存档数据类 全服共享存档数据;

	public 道具宠物回收配置类 道具宠物回收配置;

	public 奇宝斋配置类 奇宝斋配置;

	public 宠物同源配置类 宠物同源配置;

	public 在线泡点配置类 在线泡点配置;

	public 等级道行检测类 等级道行检测;

	public 百炼功能配置类 百炼功能配置;

	public 超级NPC配置类 超级NPC配置;

	public 道行达标配置类 道行达标配置;

	public 活跃度配置类 活跃度配置;

	public 黑名单记录类 黑名单记录;

	public 签到配置类 签到配置;

	public 盲盒配置类 盲盒配置;

	public 在线抽奖配置类 在线抽奖配置;

	public 召唤精怪配置类 召唤精怪配置;

	public 试道大会配置类 试道大会配置;

	public 宠物转生配置类 宠物转生配置;

	public 妖族化形配置类 妖族化形配置;

	public 怀旧专区配置类 怀旧专区配置;

	public 首饰系统配置类 首饰系统配置;

	public 融丹配置类 融丹配置;

	public 守护配置类 守护配置;

	public 娃娃配置类 娃娃配置;

	public 宠物突破配置类 宠物突破配置;

	public 自定义宠物类 自定义宠物;

	public 装备系统配置类 装备系统配置;

	public 地府商城配置类 地府商城配置;

	public 装备分解配置类 装备分解配置;

	public 龙血BOSS配置类 龙血BOSS配置;

	public 装备强化配置类 装备强化配置;

	public 礼包飘屏配置类 礼包飘屏配置;

	public 超级进化配置类 超级进化配置;

	public 自助商店配置类 自助商店配置;

	public 特效配置类 特效配置;

	public 摆摊配置类 摆摊配置;

	public 智能怪物配置类 智能怪物配置;

	public 鸿运当头配置类 鸿运当头配置;

	public 天机神算配置类 天机神算配置;

	public 日常配置类 日常配置;

	public 元神系统配置类 元神系统配置;

	public 狐狸和狗配置类 狐狸和狗配置;

	public 内充支付配置类 内充支付配置;

	public 道具数据配置类 道具数据配置;

	public int NPC_王中王;

	public int NPC_妙手道人;

	public int NPC_北斗星使;

	public int NPC_活动大使;

	public int NPC_逍遥仙;

	public int NPC_五行竞猜使;

	public int NPC_玉真子;

	public ConcurrentDictionary<string, MyNATSocketClient> 会话Dict;

	public ConcurrentDictionary<int, 角色存档数据类> 角色存档表;

	public ConcurrentDictionary<string, 宠物存档数据类> 宠物存档表;

	public List<富豪榜排行数据类> 富豪榜数据列表;

	public byte[] 富豪排行_百晓通;

	public static bool 点卡使用中
	{
		
		get
		{
			if (Singleton<全局变量类>.I.验证client.授权配置.Is点卡功能)
			{
				return Singleton<全局变量类>.I.config.点卡配置.系统开关;
			}
			return false;
		}
	}

	
	public int IpAddMac字典(string key, int 操作类型 = 0)
	{
		switch (操作类型)
		{
		case 0:
			if (!在线IP计数字典.ContainsKey(key))
			{
				return 0;
			}
			return 在线IP计数字典[key];
		case 1:
		{
			if (在线IP计数字典.TryGetValue(key, out var value))
			{
				在线IP计数字典[key] = value + 1;
			}
			else
			{
				在线IP计数字典.TryAdd(key, 1);
			}
			break;
		}
		}
		if (操作类型 == 2 && 在线IP计数字典.TryGetValue(key, out var value2))
		{
			if (value2 <= 0)
			{
				在线IP计数字典.TryRemove(key, out var _);
			}
			else
			{
				在线IP计数字典[key] = value2 - 1;
			}
		}
		return 0;
	}

	
	public bool 验证平台校验()
	{
		return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
	}

	
	public void 异常记录执行(string 账号, string value, bool 是否清空 = true)
	{
		try
		{
			if (!string.IsNullOrWhiteSpace(账号) && !string.IsNullOrWhiteSpace(value))
			{
				Log.Error("账号=" + 账号 + " value=" + value);
			}
		}
		catch (Exception ex)
		{
			Log.Error("异常记录执行-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public int 获取实际在线人数()
	{
		return 会话Dict.Values.Count( (MyNATSocketClient x) => x.当前client.Online && x.转发client.Online && x.使用中 && x.user.人物数据.角色ID != 0);
	}

	
	public int 获取实际在线IP数()
	{
		try
		{
			return (from role in 会话Dict.Values.ToList().FindAll( (MyNATSocketClient x) => x.当前client.Online && x.转发client.Online && x.使用中 && x.user.人物数据.角色ID != 0)
				select role.当前client.IP).Distinct().Count();
		}
		catch (Exception ex)
		{
			Log.Error("获取实际在线IP数-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return 0;
		}
	}

	
	public void 初始所有配置()
	{
		Singleton<BsbfIlwwf1YnPvbq8GT>.I.DocwJRxiSX();
		Singleton<Rfq62uDvr7Ur9Lpyctd>.I.rjSDarumvY();
		Singleton<OxtnHXwv6N41rhEtfdc>.I.PTqwav30x0();
		Singleton<VlLcswg81JdPCi5w8lm>.I.YXfgo5Qtcc();
		Singleton<lrYK0bWD4sTSDkaJic1>.I.nwcWlNDATc();
		Singleton<fK6mLrjpv26MU2YIIF9>.I.SGSjxNg9Xs();
		Singleton<VuI4pmDQ6nQtpDAauah>.I.XndD3HYHh6();
		Singleton<FusVSwwzpuFHNrjHS7T>.I.Gblbwm7rpW();
		Singleton<BpcEfFbiGBBV3s2B0ai>.I.P30bG1pJNF();
		Singleton<FBGRmlstyRWQdqi0pHa>.I.YGtsz7JSCc();
		Singleton<pn8GKqU6fTj7IRdG6Bm>.I.KVTUmFj736();
		Singleton<RdU9KHgkxD6vGY8ZRKE>.I.X33gO976tP();
		Singleton<KB0ManjLR9N2YNMntee>.I.H5fjcI5HaH();
		Singleton<EfHAVFUgqrnaj1QwnLW>.I.HZDUjlT8jE();
		Singleton<DB9OkbjZMmmdyW1KQMk>.I.N6ejApwwb8();
		Singleton<MbtVicwUkp5LuxTooFW>.I.NfKwgqpcv5();
		Singleton<iRGieud4qtscW6ESmxk>.I.OpkdqqPm9l();
		Singleton<L4IbybsayJA7RG5d8t7>.I.fwTs9lslDP();
		Singleton<zeYnwTjKgpmAbfSQh5J>.I.y6Bjdh9IFK();
		Singleton<WI2SZ8qRj7MBmbqI09>.I.DaKZv4wqL();
		Singleton<VYkVdJwSrcOTHUW8BPK>.I.bhFwnsHfKm();
		Singleton<FoohJvKhxbMTfceeiIF>.I.bxGK74CNVM();
		Singleton<浮生录功能>.I.IPCUV1PLI0();
		Singleton<KU0aMobWe16QEEmpLCj>.I.V1jbDnDP98();
		Singleton<t3Hr1lRCL4Z1QF9uWXP>.I.b8MR0Q1j9t();
		Singleton<fFv8GpjvE2cusnNqivq>.I.hssjaBeD11();
		Singleton<svsUCqKdlsQkBBIo3St>.I.WfVKUuEhbJ();
		Singleton<OKaMOvJmaKgK6WqoSYv>.I.IRRJceRumm();
		Singleton<等级道行检测功能>.I.CTOWAd4ZZ7();
		Singleton<FoINHjWh9BHxZ3BiiA5>.I.F5PW7WmX3U();
		Singleton<GyJyg8g24jqCD31mjD6>.I.mqggP8ij2u();
		Singleton<超级NPC功能>.I.DJBD5uQVvS();
		Singleton<L4IbybsayJA7RG5d8t7>.I.gTqsk13OCC();
		Singleton<L4IbybsayJA7RG5d8t7>.I.HaWsEY7G5V();
		Singleton<xloVkMlT29HN5P5svHC>.I.yIbly8PnUi();
		Singleton<p63Ra5gwg6vJ45gPiim>.I.pJlgJ0YCmt();
		Singleton<xKp3aGWENEfI6KIHVKi>.I.SU8WYDbyeM();
		Singleton<xKp3aGWENEfI6KIHVKi>.I.uTYWH1wtjI();
		Singleton<cGiRplbQfaJV9guWDIS>.I.phAb3DF63f();
		Singleton<FcVoHRwOVsflDmDUQOP>.I.NgDwE6S406();
		Singleton<SSW8tHD2MvRIUVygbNo>.I.tI9DP8J1fx();
		Singleton<AZI1HsR8MjRfegmETY5>.I.I0FRodI0W1();
		Singleton<妖族化形功能>.I.GmeKnW9UYt();
		Singleton<sUhuV4s664O5VhBMqaF>.I.Nt1smqPHFo();
		Singleton<cCs7kYlNIp7pmjCmEml>.I.jHglB2LkXK();
		Singleton<APqDp4bq1ecVdMifnI1>.I.h0sbZQi7MM();
		Singleton<LaobQfgSrA1tYPe60GA>.I.jq3gnvy3Lu();
		Singleton<U8hGTORuviqLJbXPJ0Y>.I.t1ARbFh2RI();
		Singleton<xxsAZpga7ronqw5ilvg>.I.FPBg995sXp();
		Singleton<pN4kvFDKqDQRQBnO8BW>.I.NW6Dd34OfT();
		Singleton<mDs6hiBvFvG3CRi3MZk>.I.Je0BaBf7ZZ();
		Singleton<pN4kvFDKqDQRQBnO8BW>.I.T3eDg89ZBH();
		Singleton<KmvE5t6XclSPSYZqqE9>.I.equ6LlOIcw();
		Singleton<rZ9xAdgxKYQQZPeE8Rm>.I.XrsgeafuGi();
		Singleton<QxBx5YDqZUOBMg9A6NN>.I.SueDZGCGlv();
		Singleton<uh2edhfVGtogUy49Lpv>.I.JJif0HwPdK();
		Singleton<TOqsYfW68LIGjCtAgK8>.I.FdWWmFkfsG();
		Singleton<YHfw7nGpg7WfdCBKDH4>.I.a7oGx57LZC();
		Singleton<MtacAPJOeul0knZiQar>.I.Ca9JEJT7Co();
		Singleton<yuKf6DUSQGygKeLSQdj>.I.pnNUngJoks();
		Singleton<mQEQjEBxYW4SsAecBHJ>.I.WOBB4mX1tE();
		Singleton<XhaJ3cfswGhhnmIequv>.I.FVUfWSHPAF();
		Singleton<Ab7Ypu2aCcHMcLPG8Um>.I.j2J2Ox7As5();
		Singleton<OmF9SPGlN77YLFkkoqN>.I.RqiGIcOsbs();
		Singleton<xH3TPsiexTnpJAMMnJm>.I.BvvirO2hli();
		Singleton<pGS3mljky49pI9pArc9>.I.OxYjO9uilD();
		注册id = 网关Config.注册id;
		if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("更新公告存档.txt")))
		{
			公告存档 = File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("更新公告存档.txt"));
		}
		else
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("更新公告存档.txt"), 公告存档);
		}
	}

	
	public void Config读取()
	{
		if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("插件主配置类.json")))
		{
			config = JsonConvert.DeserializeObject<MainConfig>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("插件主配置类.json")));
		}
		else
		{
			config = new MainConfig();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("插件主配置类.json"), JsonConvert.SerializeObject(config, Formatting.Indented));
		}
		config.is超级天星石 = true;
	}

	
	public void Config保存()
	{
		DB.更新连接字符串();
		config.is超级天星石 = true;
		File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("插件主配置类.json"), JsonConvert.SerializeObject(config, Formatting.Indented));
	}

	
	public string Config配置ToJson()
	{
		Config读取();
		return JsonConvert.SerializeObject(config, Formatting.Indented);
	}

	
	public void ConfigJsonTo配置(string value)
	{
		config = JsonConvert.DeserializeObject<MainConfig>(value);
		Config保存();
	}

	
	public void 保存所有配置()
	{
		Config保存();
		Singleton<Rfq62uDvr7Ur9Lpyctd>.I.QEEDT9XrNK();
		Singleton<OxtnHXwv6N41rhEtfdc>.I.zntwT68bbV();
		Singleton<VlLcswg81JdPCi5w8lm>.I.AqsgNkkkLF();
		Singleton<lrYK0bWD4sTSDkaJic1>.I.GQHW8ce28r();
		Singleton<fK6mLrjpv26MU2YIIF9>.I.I3QjH17Swx();
		Singleton<VuI4pmDQ6nQtpDAauah>.I.kEZDYIgoB2();
		Singleton<FusVSwwzpuFHNrjHS7T>.I.IkAbbbPDb2();
		Singleton<BpcEfFbiGBBV3s2B0ai>.I.ht5bfR8AH9();
		Singleton<FBGRmlstyRWQdqi0pHa>.I.kSnUuq4dcR();
		Singleton<pn8GKqU6fTj7IRdG6Bm>.I.n1fUPdsc2G();
		Singleton<RdU9KHgkxD6vGY8ZRKE>.I.G5wgQdkerd();
		Singleton<KB0ManjLR9N2YNMntee>.I.QYQjni4aPR();
		Singleton<EfHAVFUgqrnaj1QwnLW>.I.nvYUluNlQJ();
		Singleton<DB9OkbjZMmmdyW1KQMk>.I.TlJjzcbEKx();
		Singleton<MbtVicwUkp5LuxTooFW>.I.xbPwDR6AkH();
		Singleton<iRGieud4qtscW6ESmxk>.I.Iw4drR3GtU();
		Singleton<L4IbybsayJA7RG5d8t7>.I.zuXsybcJpN();
		Singleton<zeYnwTjKgpmAbfSQh5J>.I.XZ0jspu4UN();
		Singleton<WI2SZ8qRj7MBmbqI09>.I.K7btGQrgN();
		Singleton<VYkVdJwSrcOTHUW8BPK>.I.Xe7w5yNJfw();
		Singleton<FoohJvKhxbMTfceeiIF>.I.XTlKa6nARp();
		Singleton<浮生录功能>.I.v2hUkDkTda();
		Singleton<KU0aMobWe16QEEmpLCj>.I.kd2bjmeMXG();
		Singleton<BsbfIlwwf1YnPvbq8GT>.I.o2gwKNo6hU();
		Singleton<t3Hr1lRCL4Z1QF9uWXP>.I.w1VROIUihj();
		Singleton<fFv8GpjvE2cusnNqivq>.I.HPmjTQ6Mjj();
		Singleton<svsUCqKdlsQkBBIo3St>.I.OB7KWHwPa4();
		Singleton<OKaMOvJmaKgK6WqoSYv>.I.pNIJnpHdZV();
		Singleton<等级道行检测功能>.I.UuYWzOeaZY();
		Singleton<FoINHjWh9BHxZ3BiiA5>.I.MGnWayWEmi();
		Singleton<GyJyg8g24jqCD31mjD6>.I.lScgXuebT5();
		Singleton<超级NPC功能>.I.mndDM8OIAS();
		Singleton<L4IbybsayJA7RG5d8t7>.I.Ksls0duMVI();
		Singleton<L4IbybsayJA7RG5d8t7>.I.JJvs3nRZte();
		Singleton<sUhuV4s664O5VhBMqaF>.I.TEisPgrX8Q();
		Singleton<cCs7kYlNIp7pmjCmEml>.I.CaplGKRwQg();
	}

	
	public 全局变量类()
	{
		qqs = string.Empty;
		临时id字典 = new ConcurrentList<int>();
		在线IP计数字典 = new ConcurrentDictionary<string, int>();
		全_本区区名 = string.Empty;
		公告存档 = string.Empty;
		异常字典 = new ConcurrentDictionary<string, string>();
		网关Config = new 网关配置();
		注册列表 = new ConcurrentList<注册信息>();
		所有地图字典 = new ConcurrentDictionary<string, string>();
		所有NPC字典 = new ConcurrentDictionary<int, ConcurrentDictionary<int, NPC信息类>>();
		下线账号列表 = new ConcurrentQueue<string>();
		王中王物品列表 = new List<可发货物品列表类>();
		王中王整体封包 = Array.Empty<byte>();
		商城数据列表 = new List<商城数据类>();
		config = new MainConfig();
		南极配置 = new 南极配置类();
		累充配置 = new 累充配置类();
		燃眉配置 = new 燃眉配置类();
		邮箱配置 = new 邮箱配置类();
		超级坐骑配置 = new 超级坐骑配置类();
		商城限购配置 = new 商城限购配置类();
		圣无双配置 = new 圣无双配置类();
		挑战BOSS配置 = new 挑战BOSS配置类();
		时装坐姿染色配置 = new 时装坐姿染色配置类();
		自选道具配置 = new 自选道具配置类();
		通天塔突破配置 = new 通天塔突破配置类();
		推荐拉人配置 = new 推荐拉人配置类();
		门派转换配置 = new 门派转换配置类();
		六道轮回配置 = new 六道轮回配置类();
		一键大飞配置 = new 一键大飞配置类();
		法宝共生配置 = new 法宝共生配置类();
		异兽录配置 = new 异兽录配置类();
		指定会员配置 = new 指定会员配置类();
		礼包开元宝配置 = new 礼包开元宝配置类();
		超级道具配置 = new 超级道具配置类();
		宠物绑定配置 = new 宠物绑定配置类();
		升级奖励配置 = new 升级奖励配置类();
		宠物召唤配置 = new 宠物召唤配置类();
		浮生录配置 = new 浮生录配置类();
		超级地图配置 = new 超级地图配置类();
		喊话限制配置 = new 喊话限制配置类();
		属性洗炼配置 = new 属性洗炼配置类();
		全服共享存档数据 = new 全服共享存档数据类();
		道具宠物回收配置 = new 道具宠物回收配置类();
		奇宝斋配置 = new 奇宝斋配置类();
		宠物同源配置 = new 宠物同源配置类();
		在线泡点配置 = new 在线泡点配置类();
		等级道行检测 = new 等级道行检测类();
		百炼功能配置 = new 百炼功能配置类();
		超级NPC配置 = new 超级NPC配置类();
		道行达标配置 = new 道行达标配置类();
		活跃度配置 = new 活跃度配置类();
		黑名单记录 = new 黑名单记录类();
		签到配置 = new 签到配置类();
		盲盒配置 = new 盲盒配置类();
		在线抽奖配置 = new 在线抽奖配置类();
		召唤精怪配置 = new 召唤精怪配置类();
		试道大会配置 = new 试道大会配置类();
		宠物转生配置 = new 宠物转生配置类();
		妖族化形配置 = new 妖族化形配置类();
		怀旧专区配置 = new 怀旧专区配置类();
		首饰系统配置 = new 首饰系统配置类();
		融丹配置 = new 融丹配置类();
		守护配置 = new 守护配置类();
		娃娃配置 = new 娃娃配置类();
		宠物突破配置 = new 宠物突破配置类();
		自定义宠物 = new 自定义宠物类();
		装备系统配置 = new 装备系统配置类();
		地府商城配置 = new 地府商城配置类();
		装备分解配置 = new 装备分解配置类();
		龙血BOSS配置 = new 龙血BOSS配置类();
		装备强化配置 = new 装备强化配置类();
		礼包飘屏配置 = new 礼包飘屏配置类();
		超级进化配置 = new 超级进化配置类();
		自助商店配置 = new 自助商店配置类();
		特效配置 = new 特效配置类();
		摆摊配置 = new 摆摊配置类();
		智能怪物配置 = new 智能怪物配置类();
		鸿运当头配置 = new 鸿运当头配置类();
		天机神算配置 = new 天机神算配置类();
		日常配置 = new 日常配置类();
		元神系统配置 = new 元神系统配置类();
		狐狸和狗配置 = new 狐狸和狗配置类();
		内充支付配置 = new 内充支付配置类();
		道具数据配置 = new 道具数据配置类();
		会话Dict = new ConcurrentDictionary<string, MyNATSocketClient>();
		角色存档表 = new ConcurrentDictionary<int, 角色存档数据类>();
		宠物存档表 = new ConcurrentDictionary<string, 宠物存档数据类>();
		富豪榜数据列表 = new List<富豪榜排行数据类>();
		富豪排行_百晓通 = Array.Empty<byte>();
	}

	
	static 全局变量类()
	{
		禁止注册名字 = new string[11]
		{
			"练气境",
			"筑基境",
			"金丹境",
			"元婴境",
			"化神境",
			"炼虚境",
			"合体境",
			"渡劫境",
			"大乘境",
			"真仙境",
			"无上境"
		};
		插件类型 = "";
		ServerHash = "";
		ClientHash = "";
		Is调试 = false;
		Is所有地图 = false;
		HeadData = new byte[8] { 77, 90, 0, 0, 0, 0, 0, 0 };
		问道头 = new byte[4] { 77, 90, 0, 0 };
		全_坐骑 = new int[30]
		{
			77, 78, 79, 80, 81, 82, 83, 84, 85, 86,
			87, 88, 89, 90, 91, 92, 93, 94, 95, 96,
			97, 98, 99, 100, 101, 102, 103, 104, 105, 106
		};
	}
}
