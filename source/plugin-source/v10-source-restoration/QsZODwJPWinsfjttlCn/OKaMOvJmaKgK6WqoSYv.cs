using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using H0Y8GEJQx5wfb6t3alR;
using Ncq4nMwbH5sPfLR2xwf;
using Newtonsoft_X.Json;
using R0F7EJKsPwFRj7h6amU;
using Serilog;
using jVVIM9j1PL0VAliGELE;
using uI75fJjR7A2e7wWdq9f;
using vEAdPGPTkDFOYsbi303;

namespace QsZODwJPWinsfjttlCn;

internal class OKaMOvJmaKgK6WqoSYv : Singleton<OKaMOvJmaKgK6WqoSYv>
{
	private Thread ydpJy3DulN;

	private Thread adEJCdYNcN;

	private Thread QBmJVxdlY9;

	public Thread dgKJklyBdt;

	public Thread ULNJ0yDXBo;

	
	internal void APaJXnx4wA()
	{
		ydpJy3DulN = new Thread(ubSJFIKnHH);
		ydpJy3DulN.IsBackground = true;
		ydpJy3DulN.Start();
		Sm5JhyJ6vf();
		QBmJVxdlY9 = new Thread(SuyJv9oEr1);
		QBmJVxdlY9.IsBackground = true;
		QBmJVxdlY9.Start();
		dgKJklyBdt = new Thread(jgpJaemjkR);
		dgKJklyBdt.IsBackground = true;
		dgKJklyBdt.Start();
		ULNJ0yDXBo = new Thread(mLAJTebGrd);
		ULNJ0yDXBo.IsBackground = true;
		ULNJ0yDXBo.Start();
		hk2J9kwbDC();
	}

	
	private async void ubSJFIKnHH()
	{
		if (Singleton<ByteAPI>.I.取时间(string.Empty).Second != 0)
		{
			for (int i = 0; i < 60; i++)
			{
				if (Singleton<ByteAPI>.I.取时间(string.Empty).Second == 0)
				{
					break;
				}
				await Task.Delay(1000);
			}
		}
		Log.Warning("[线程-每秒统计]开启");
		while (true)
		{
			DateTimeOffset 当前时间 = Singleton<ByteAPI>.I.取时间(string.Empty);
			if (当前时间.ToString("yyyy-MM-dd") != Singleton<全局变量类>.I.全服共享存档数据.日期记录)
			{
				Singleton<全局变量类>.I.全服共享存档数据.日期记录 = 当前时间.ToString("yyyy-MM-dd");
				await rV4JLTrEkR();
				Singleton<BsbfIlwwf1YnPvbq8GT>.I.o2gwKNo6hU();
				NAZJStcrtj();
			}
			if (MtacAPJOeul0knZiQar.N8mJACclNW() && !Singleton<全局变量类>.I.天机神算配置.自动刷新开关 && !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.天机神算配置.每日刷新时间) && 当前时间.ToString("HH:mm") == (Singleton<全局变量类>.I.天机神算配置.每日刷新时间 ?? ""))
			{
				Singleton<MtacAPJOeul0knZiQar>.I.FGlJxK9Onf();
			}
			if (zeYnwTjKgpmAbfSQh5J.ARHjmZgHJU())
			{
				Singleton<全局变量类>.I.限时属性事件?.Invoke();
			}
			if (全局变量类.点卡使用中)
			{
				Singleton<全局变量类>.I.点卡扣除事件?.Invoke();
			}
			await Task.Delay(60000);
		}
	}

	
	private async Task rV4JLTrEkR()
	{
		Singleton<全局变量类>.I.全服共享存档数据.当日紫帝晶数量 = 0;
		foreach (角色存档数据类 value in Singleton<全局变量类>.I.角色存档表.Values)
		{
			value.已打通天塔次数 = 0;
			value.通天塔额外次数 = 0;
			value.指定活跃奖励领取[0] = false;
			value.指定活跃奖励领取[1] = false;
			value.指定活跃奖励领取[2] = false;
			value.指定活跃奖励领取[3] = false;
			value.指定活跃奖励领取[4] = false;
			value.指定活跃奖励领取[5] = false;
			value.挑战BOSS数据.Clear();
			value.is每日首冲领取 = false;
			value.is指定会员每日奖励 = false;
			value.限购商城数据.Clear();
			value.无双圣榜数据.本日参拜次数 = 0;
			value.无双圣榜数据.is本日加成领取 = false;
			value.燃眉之急任务.任务次数 = 0;
			value.签到数据.本日是否签到 = false;
			value.地府购买存档.Clear();
			await Task.Delay(100);
		}
		foreach (MyNATSocketClient value2 in Singleton<全局变量类>.I.会话Dict.Values)
		{
			if (value2.使用中 && value2.user.人物数据.GID != 0)
			{
				fK6mLrjpv26MU2YIIF9 i = Singleton<fK6mLrjpv26MU2YIIF9>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 9);
				defaultInterpolatedStringHandler.AppendLiteral("#Y亲爱的道友你好，新的一天又开始了。#G");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.签到配置.功能开关 ? "#r本日签到状态已重置" : string.Empty);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.通天塔突破配置.功能开关 ? "#r通天塔挑战次数已重置" : string.Empty);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.功能开关 ? "#r活跃度额外奖励已重置" : string.Empty);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.挑战BOSS配置.功能开关 ? "#rBOSS挑战次数已重置" : string.Empty);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.is点卡cdk ? "#r每日首冲奖励已重置" : string.Empty);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.指定会员配置.功能开关 ? "#r指定会员每日奖励已重置" : string.Empty);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.商城限购配置.功能开关 ? "#r每日商城限购已重置" : string.Empty);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.燃眉配置.功能开关 ? "#r每日燃眉之急已重置" : string.Empty);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.功能开关 ? "#r无双大圣参拜已重置#r无双大圣加成领取已重置" : string.Empty);
				i.Ym9jrsy6dl(value2, defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}
		Log.Debug("所有玩家存档日常数据重置成功！");
	}

	
	private void NAZJStcrtj()
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写 封包_写3 = new 封包_写();
		封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("20A3010000006700000000"), hasCount: false, 0);
		Singleton<全局变量类>.I.富豪榜数据列表.Clear();
		foreach (角色存档数据类 value in Singleton<全局变量类>.I.角色存档表.Values)
		{
			if (value.累计充值金额 > 0)
			{
				Singleton<全局变量类>.I.富豪榜数据列表.Add(new 富豪榜排行数据类
				{
					名字 = value.昵称,
					等级 = (short)value.等级,
					金额 = value.累计充值金额,
					门派 = value.排行数据_门派
				});
			}
		}
		Singleton<全局变量类>.I.富豪榜数据列表.Sort();
		Singleton<全局变量类>.I.富豪榜数据列表.Reverse();
		int num = ((Singleton<全局变量类>.I.富豪榜数据列表.Count > 30) ? 30 : Singleton<全局变量类>.I.富豪榜数据列表.Count);
		if (num > 0)
		{
			封包_写2.写短整数型((short)num, reverse: true);
			for (int i = 0; i < num; i++)
			{
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("0004"), hasCount: false, 0);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("001F02"), hasCount: false, 0);
				封包_写2.写短整数型(Singleton<全局变量类>.I.富豪榜数据列表[i].等级, reverse: true);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("01B303"), hasCount: false, 0);
				封包_写2.写整数型(Singleton<全局变量类>.I.富豪榜数据列表[i].金额 * 100, reverse: true);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("000104"), hasCount: false, 0);
				封包_写2.写文本型(Singleton<全局变量类>.I.富豪榜数据列表[i].名字, hasCount: true, 0, reverse: true);
				封包_写2.写字节集(Singleton<ByteAPI>.I.HtoC("005104"), hasCount: false, 0);
				封包_写2.写文本型(Singleton<全局变量类>.I.富豪榜数据列表[i].门派, hasCount: true, 0, reverse: true);
			}
			封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
			封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
			Singleton<全局变量类>.I.富豪排行_百晓通 = 封包_写3.取数据();
		}
		封包_写2.写短整数型(0, reverse: true);
		封包_写3.写入数据(全局变量类.HeadData, hasCount: false, 0);
		封包_写3.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		Singleton<全局变量类>.I.富豪排行_百晓通 = 封包_写3.取数据();
	}

	
	internal void IRRJceRumm()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("在线泡点配置类.json")))
			{
				Singleton<全局变量类>.I.在线泡点配置 = JsonConvert.DeserializeObject<在线泡点配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("在线泡点配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.在线泡点配置 = new 在线泡点配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("在线泡点配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.在线泡点配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("在线泡点配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void pNIJnpHdZV()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("在线泡点配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.在线泡点配置, Formatting.Indented));
			Log.Debug("在线泡点配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("在线泡点配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string fC8J59qKTa()
	{
		IRRJceRumm();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.在线泡点配置, Formatting.Indented);
	}

	
	public void Q9fJMk65PL(string P_0)
	{
		Singleton<全局变量类>.I.在线泡点配置 = JsonConvert.DeserializeObject<在线泡点配置类>(P_0);
		pNIJnpHdZV();
	}

	
	private async Task Sm5JhyJ6vf()
	{
		StringBuilder 提示文字 = new StringBuilder();
		int 间隔分钟 = 60000;
		while (true)
		{
			try
			{
				await Task.Delay(间隔分钟);
				if (!Singleton<全局变量类>.I.在线泡点配置.泡点开关 || string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.在线泡点配置.泡点地图) || Singleton<全局变量类>.I.会话Dict.IsEmpty)
				{
					continue;
				}
				间隔分钟 = ((Singleton<全局变量类>.I.在线泡点配置.泡点间隔分钟 * 60000 <= 0) ? 60000 : (Singleton<全局变量类>.I.在线泡点配置.泡点间隔分钟 * 60000));
				int num = 0;
				foreach (MyNATSocketClient value in Singleton<全局变量类>.I.会话Dict.Values)
				{
					if (!value.使用中 || !value.转发client.Online || !value.当前client.Online || value.user.人物数据.GID == 0 || (Singleton<全局变量类>.I.在线泡点配置.泡点地图 != "0" && !Singleton<ByteAPI>.I.寻找文本("|" + Singleton<全局变量类>.I.在线泡点配置.泡点地图 + "|", "|" + value.user.人物数据.所在地图名字 + "|")))
					{
						continue;
					}
					int num2 = ((!value.user.存档数据.is摆摊中 || !Singleton<全局变量类>.I.在线泡点配置.双倍开关) ? 1 : 2);
					提示文字.Clear();
					提示文字.Append("#G获得泡点系统奖励的：");
					if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励金元宝 != 0 || Singleton<全局变量类>.I.在线泡点配置.泡点奖励银元宝 != 0)
					{
						Singleton<WdAPI>.I.PndoGw5lW7(value, AllEnums.发送数据Type.金银元宝, $"{Singleton<全局变量类>.I.在线泡点配置.泡点奖励金元宝 * num2}", AllEnums.指令Type.无, Singleton<全局变量类>.I.在线泡点配置.泡点奖励银元宝 * num2, false, "泡点获得");
						StringBuilder stringBuilder = 提示文字;
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(20, 2, stringBuilder);
						handler.AppendLiteral("#Y金元宝*");
						handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励金元宝);
						handler.AppendLiteral("#n  #Y银元宝*");
						handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励银元宝);
						handler.AppendLiteral("#n  ");
						stringBuilder2.Append(ref handler);
					}
					if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励南极点 != 0)
					{
						Singleton<WdAPI>.I.PndoGw5lW7(value, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, Singleton<全局变量类>.I.在线泡点配置.泡点奖励南极点 * num2, false, "[泡点]获得");
						StringBuilder stringBuilder = 提示文字;
						StringBuilder stringBuilder3 = stringBuilder;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder);
						handler.AppendLiteral("#Y南极点*");
						handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励南极点);
						handler.AppendLiteral("#n  ");
						stringBuilder3.Append(ref handler);
					}
					if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励累充点 != 0)
					{
						Singleton<WdAPI>.I.PndoGw5lW7(value, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, Singleton<全局变量类>.I.在线泡点配置.泡点奖励累充点 * num2, false, "泡点获得");
						StringBuilder stringBuilder = 提示文字;
						StringBuilder stringBuilder4 = stringBuilder;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder);
						handler.AppendLiteral("#Y累充点*");
						handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励累充点);
						handler.AppendLiteral("#n  ");
						stringBuilder4.Append(ref handler);
					}
					if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具) && Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量 > 0 && Singleton<WdAPI>.I.PndoGw5lW7(value, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具, AllEnums.指令Type.无, Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量 * num2, false, "泡点奖励"))
					{
						StringBuilder stringBuilder = 提示文字;
						StringBuilder stringBuilder5 = stringBuilder;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 2, stringBuilder);
						handler.AppendLiteral("#Y");
						handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具);
						handler.AppendLiteral("*");
						handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量);
						handler.AppendLiteral("#n");
						stringBuilder5.Append(ref handler);
					}
					if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励灵气值 > 0 && Singleton<WdAPI>.I.PndoGw5lW7(value, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, Singleton<全局变量类>.I.在线泡点配置.泡点奖励灵气值 * num2, false, "泡点奖励"))
					{
						StringBuilder stringBuilder = 提示文字;
						StringBuilder stringBuilder6 = stringBuilder;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder);
						handler.AppendLiteral("#Y灵气值*");
						handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励灵气值);
						handler.AppendLiteral("#n");
						stringBuilder6.Append(ref handler);
					}
					if (value.user.存档数据.is摆摊中 && Singleton<全局变量类>.I.在线泡点配置.双倍开关)
					{
						提示文字.Append("#r#G获得天上集市摆摊奖励的：");
						if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励金元宝 != 0 || Singleton<全局变量类>.I.在线泡点配置.泡点奖励银元宝 != 0)
						{
							StringBuilder stringBuilder = 提示文字;
							StringBuilder stringBuilder7 = stringBuilder;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(20, 2, stringBuilder);
							handler.AppendLiteral("#Y金元宝*");
							handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励金元宝);
							handler.AppendLiteral("#n  #Y银元宝*");
							handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励银元宝);
							handler.AppendLiteral("#n  ");
							stringBuilder7.Append(ref handler);
						}
						if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励南极点 != 0)
						{
							StringBuilder stringBuilder = 提示文字;
							StringBuilder stringBuilder8 = stringBuilder;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder);
							handler.AppendLiteral("#Y南极点*");
							handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励南极点);
							handler.AppendLiteral("#n  ");
							stringBuilder8.Append(ref handler);
						}
						if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励累充点 != 0)
						{
							StringBuilder stringBuilder = 提示文字;
							StringBuilder stringBuilder9 = stringBuilder;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder);
							handler.AppendLiteral("#Y累充点*");
							handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励累充点);
							handler.AppendLiteral("#n  ");
							stringBuilder9.Append(ref handler);
						}
						if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具) && Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量 > 0)
						{
							StringBuilder stringBuilder = 提示文字;
							StringBuilder stringBuilder10 = stringBuilder;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 2, stringBuilder);
							handler.AppendLiteral("#Y");
							handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具);
							handler.AppendLiteral("*");
							handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量);
							handler.AppendLiteral("#n");
							stringBuilder10.Append(ref handler);
						}
						if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励灵气值 > 0)
						{
							StringBuilder stringBuilder = 提示文字;
							StringBuilder stringBuilder11 = stringBuilder;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder);
							handler.AppendLiteral("#Y灵气值*");
							handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励灵气值);
							handler.AppendLiteral("#n  ");
							stringBuilder11.Append(ref handler);
						}
					}
					num++;
					value.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(提示文字.ToString()));
				}
				if (num > 0)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 6);
					defaultInterpolatedStringHandler.AppendLiteral("泡点系统：发送人数：");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("，金元宝：");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励金元宝);
					defaultInterpolatedStringHandler.AppendLiteral("，银元宝：");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励银元宝);
					defaultInterpolatedStringHandler.AppendLiteral("，道具：");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具);
					defaultInterpolatedStringHandler.AppendLiteral("*");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量);
					defaultInterpolatedStringHandler.AppendLiteral("，灵气值：");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励灵气值);
					Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			catch (Exception ex)
			{
				Log.Error("在线泡点线程失败：" + ex.Message + "(" + ex.StackTrace + ")");
			}
		}
	}

	
	private async void SuyJv9oEr1()
	{
		try
		{
			while (true)
			{
				await Task.Delay(600000);
				ArchiveSaveResult result = await DB.I.保存在线存档();
				if (result == ArchiveSaveResult.Failed)
				{
					Log.Error("自动存档失败，请检查存档目录和磁盘状态");
				}
				Singleton<BsbfIlwwf1YnPvbq8GT>.I.o2gwKNo6hU();
				Singleton<全局变量类>.I.验证client?.验证存档插件数据();
			}
		}
		catch (Exception ex)
		{
			Log.Error("自动存档失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public async Task VPyJ77BObK(MyNATSocketClient P_0)
	{
		_ = 3;
		try
		{
			await Task.Delay(1000);
			Singleton<WdAPI>.I.地图传送事件(P_0, "/gs/zone/misc/GM-workroom.c", "21", "21");
			await Task.Delay(1000);
			if (Singleton<全局变量类>.I.NPC_王中王 != 0)
			{
				P_0.S_Send(Singleton<ByteAPI>.I.HtoC("4D5A00000000000000067012").Concat(Singleton<ByteAPI>.I.到字节集固定反转(Singleton<全局变量类>.I.NPC_王中王)).ToArray());
				P_0.S_Send(Singleton<ByteAPI>.I.HtoC("4D5A00000000000000141042").Concat(Singleton<ByteAPI>.I.到字节集固定反转(Singleton<全局变量类>.I.NPC_王中王)).Concat(Singleton<ByteAPI>.I.HtoC("08B9BAC2F2CEEFC6B7000002E663"))
					.ToArray());
				await Task.Delay(2000);
			}
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("货栈初始化完成！"));
			await Task.Delay(1000);
			Singleton<WdAPI>.I.地图传送事件(P_0, "/gs/zone/tianyongcheng/tianyongcheng.c", "266", "204");
		}
		catch (Exception ex)
		{
			Log.Error("自动读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public async void jgpJaemjkR()
	{
		try
		{
			int 间隔毫秒 = 60000;
			while (true)
			{
				if (Singleton<全局变量类>.I.喊话限制配置.Is开启 && !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.喊话限制配置.喊话内容))
				{
					int num = (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.喊话限制配置.开始时间);
					int num2 = (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.喊话限制配置.结束时间);
					int num3 = (int)Singleton<ByteAPI>.I.取时间戳();
					if (num <= num3 && num2 > num3)
					{
						间隔毫秒 = ((Singleton<全局变量类>.I.喊话限制配置.间隔时间 <= 0) ? 60000 : (Singleton<全局变量类>.I.喊话限制配置.间隔时间 * 60000));
						if (Singleton<全局变量类>.I.喊话限制配置.喊话频道 == AllEnums.频道Type.横批公告)
						{
							Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.PWRouuXjmn(Singleton<全局变量类>.I.喊话限制配置.喊话内容));
						}
						else
						{
							Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(Singleton<全局变量类>.I.喊话限制配置.喊话内容, "管理员", Singleton<全局变量类>.I.喊话限制配置.喊话频道));
						}
					}
				}
				await Task.Delay(间隔毫秒);
			}
		}
		catch (Exception ex)
		{
			Log.Error("自动喊话-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public async void mLAJTebGrd()
	{
		_ = 2;
		try
		{
			new List<MyNATSocketClient>();
			new List<物品信息类>();
			while (true)
			{
				if (Singleton<全局变量类>.I.超级道具配置.功能开关)
				{
					List<MyNATSocketClient> list = Singleton<全局变量类>.I.会话Dict.Values.ToList().FindAll( (MyNATSocketClient x) => x.使用中 && x.user.缓存数据.Is自动使用道具);
					if (list.Count > 0)
					{
						foreach (MyNATSocketClient 当前玩家 in list)
						{
							List<物品信息类> list2 = 当前玩家.user.背包数据.物品列表.ToList().FindAll( (物品信息类 x) => x.Index != 0 && x.物品ID != 0 && ("|" + Singleton<全局变量类>.I.超级道具配置.自动使用道具 + "|").Contains("|" + x.名字 + "|", StringComparison.CurrentCulture));
							foreach (物品信息类 item in list2)
							{
								await Singleton<WdAPI>.I.自动使用背包(当前玩家, item.Index, item.数量);
							}
							当前玩家.user.缓存数据.Is自动使用道具 = false;
							await Task.Delay(1);
						}
					}
				}
				await Task.Delay(1);
			}
		}
		catch (Exception ex)
		{
			Log.Error("自动使用道具线程-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public async Task hk2J9kwbDC()
	{
		string filePath = mEdebOPadFyb5ykL5Wy.W80P9ipOVU("奇宝交易记录.txt");
		StringBuilder txts = new StringBuilder();
		while (true)
		{
			if (!Singleton<svsUCqKdlsQkBBIo3St>.I.pC3KFDFA6k.IsEmpty)
			{
				int count = Singleton<svsUCqKdlsQkBBIo3St>.I.pC3KFDFA6k.Count;
				txts.Clear();
				for (int i = 0; i < count; i++)
				{
					if (Singleton<svsUCqKdlsQkBBIo3St>.I.pC3KFDFA6k.TryDequeue(out var result))
					{
						txts.AppendLine(result);
					}
				}
				try
				{
					await File.AppendAllTextAsync(filePath, txts.ToString());
				}
				catch
				{
				}
			}
			await Task.Delay(60000);
		}
	}

	
	public OKaMOvJmaKgK6WqoSYv()
	{
	}

	static OKaMOvJmaKgK6WqoSYv()
	{
	}
}
