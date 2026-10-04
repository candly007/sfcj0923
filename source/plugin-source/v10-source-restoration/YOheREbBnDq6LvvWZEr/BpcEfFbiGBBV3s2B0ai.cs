using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace YOheREbBnDq6LvvWZEr;

internal class BpcEfFbiGBBV3s2B0ai : Singleton<BpcEfFbiGBBV3s2B0ai>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public int UIlFj8fwkS;

		
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		
		internal bool DEQFDopuF5(MyNATSocketClient a)
		{
			if (a.使用中 && a.user.人物数据.所在地图名字 == Singleton<全局变量类>.I.圣无双配置.地图名字 && a.user.存档数据.无双圣榜数据.is报名 && a.user.存档数据.无双圣榜数据.当前积分 > 0 && UIlFj8fwkS - a.user.缓存数据.无双缓存数据.无双战斗结束时间戳 >= 30)
			{
				return !a.user.缓存数据.is战斗中;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass22_0()
		{
		}
	}

	internal AllEnums.圣无双Type zCybkJu0wB;

	internal byte[] XBPb0fJUAe;

	internal StringBuilder kwObOsrG9Y;

	
	internal void P30bG1pJNF()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("圣无双配置类.json")))
			{
				Singleton<全局变量类>.I.圣无双配置 = JsonConvert.DeserializeObject<圣无双配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("圣无双配置类.json")));
			}
			else
			{
				Singleton<全局变量类>.I.圣无双配置 = new 圣无双配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("圣无双配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.圣无双配置, Formatting.Indented));
			}
			ahfbmf4uyK();
		}
		catch (Exception ex)
		{
			Log.Error("圣无双配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void ht5bfR8AH9()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("圣无双配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.圣无双配置, Formatting.Indented));
			Log.Debug("圣无双配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("圣无双配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string WPLb6Xy65R()
	{
		P30bG1pJNF();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.圣无双配置, Formatting.Indented);
	}

	
	public void m67b2CrTje(string P_0)
	{
		Singleton<全局变量类>.I.圣无双配置 = JsonConvert.DeserializeObject<圣无双配置类>(P_0);
		ahfbmf4uyK();
		ht5bfR8AH9();
	}

	
	public void ahfbmf4uyK()
	{
		XBPb0fJUAe = (Singleton<全局变量类>.I.圣无双配置.功能开关 ? Singleton<WdAPI>.I.组包假NPC站街(Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像, 101) : Array.Empty<byte>());
	}

	
	public byte[] IdQbP9y1rt(MyNATSocketClient P_0)
	{
		return Singleton<ByteAPI>.I.AddByte(new byte[16]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 62,
			253, 249, 0, 0, 0, 0
		}, Singleton<ByteAPI>.I.到字节集反转(P_0.user.存档数据.无双圣榜数据.圣榜排名), Singleton<ByteAPI>.I.到字节集反转(P_0.user.存档数据.无双圣榜数据.总累胜场次), new byte[12], Singleton<ByteAPI>.I.到字节集反转(P_0.user.存档数据.无双圣榜数据.本届累胜场次), new byte[12], Singleton<ByteAPI>.I.到字节集反转(P_0.user.存档数据.无双圣榜数据.总连胜场次), new byte[16]);
	}

	
	internal void V4cbXi2m8r(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			if (Enumerable.SequenceEqual(P_1, new byte[4] { 3, 65, 0, 2 }))
			{
				r16bLTg3QG(P_0);
			}
			else if (Enumerable.SequenceEqual(P_1, new byte[4] { 3, 65, 0, 3 }))
			{
				fk4bS9LOiG(P_0);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("圣无双借用按钮处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void KRFbFwXOpy(MyNATSocketClient P_0)
	{
		try
		{
			if (!Singleton<全局变量类>.I.圣无双配置.功能开关)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("本届圣无双争夺战暂未开启，请等候通知！"));
				return;
			}
			if (zCybkJu0wB != AllEnums.圣无双Type.报名时)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前时间并未在报名期间，请注意系统公告的报名时间！"));
				return;
			}
			if (P_0.user.存档数据.无双圣榜数据.is报名)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你已经报名了本届圣无双争夺战！"));
				return;
			}
			int num = (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.圣无双配置.开始时间);
			int num2 = (int)Singleton<ByteAPI>.I.取时间戳();
			if (num2 >= num)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("本届圣无双争夺战已经开始，无法进行报名了！"));
				return;
			}
			if (num - num2 > 1800)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("本届圣无双争夺战报名时间为开始时间#Y" + Singleton<全局变量类>.I.圣无双配置.开始时间 + "#n的前半小时！"));
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			switch (Singleton<全局变量类>.I.圣无双配置.门票类型)
			{
			case AllEnums.数值Type.金元宝:
			{
				if (P_0.user.背包数据.金元宝 < Singleton<全局变量类>.I.圣无双配置.门票价格)
				{
					WdAPI i5 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，你的金元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.门票价格);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法参加无双争夺战活动！");
					P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, -Singleton<全局变量类>.I.圣无双配置.门票价格, 0))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("很遗憾，你的金元宝扣除失败，无法参加无双争夺战活动！"));
					return;
				}
				WdAPI i6 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你，花费了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.门票价格);
				defaultInterpolatedStringHandler.AppendLiteral("#n金元宝成功报名了本届的无双争夺战！");
				byte[] first2 = i6.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear());
				WdAPI i7 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你，花费了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.门票价格);
				defaultInterpolatedStringHandler.AppendLiteral("#n金元宝成功报名了本届的无双争夺战！");
				P_0.C_Send(first2.Concat(i7.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
				break;
			}
			case AllEnums.数值Type.银元宝:
			{
				if (P_0.user.背包数据.银元宝 < Singleton<全局变量类>.I.圣无双配置.门票价格)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，你的银元宝不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.门票价格);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法参加无双争夺战活动！");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, 0, -Singleton<全局变量类>.I.圣无双配置.门票价格))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("很遗憾，你的银元宝扣除失败，无法参加无双争夺战活动！"));
					return;
				}
				WdAPI i3 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你，花费了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.门票价格);
				defaultInterpolatedStringHandler.AppendLiteral("#n银元宝成功报名了本届的无双争夺战！");
				byte[] first = i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear());
				WdAPI i4 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你，花费了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.门票价格);
				defaultInterpolatedStringHandler.AppendLiteral("#n银元宝成功报名了本届的无双争夺战！");
				P_0.C_Send(first.Concat(i4.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray());
				break;
			}
			case AllEnums.数值Type.金钱:
				if (P_0.user.背包数据.金钱 < Singleton<全局变量类>.I.圣无双配置.门票价格)
				{
					WdAPI i = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
					defaultInterpolatedStringHandler.AppendLiteral("很遗憾，你的游戏币不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.门票价格);
					defaultInterpolatedStringHandler.AppendLiteral("#n，无法参加无双争夺战活动！");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -Singleton<全局变量类>.I.圣无双配置.门票价格, false, "[无双]门票消耗");
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("恭喜你，花费了" + Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.圣无双配置.门票价格) + "文钱成功报名了本届的无双争夺战！").Concat(Singleton<WdAPI>.I.提示_杂项公告("恭喜你，花费了" + Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.圣无双配置.门票价格) + "文钱成功报名了本届的无双争夺战！")).ToArray());
				break;
			}
			P_0.user.存档数据.无双圣榜数据.is报名 = true;
			P_0.user.存档数据.无双圣榜数据.当前积分 = Singleton<全局变量类>.I.圣无双配置.初始积分;
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.attack_effect, 0, true);
			WdAPI i8 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler.AppendLiteral("报名成功，你获得了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.初始积分);
			defaultInterpolatedStringHandler.AppendLiteral("#n点初始无双积分。");
			P_0.C_Send(i8.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("无双战场报名校验-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void r16bLTg3QG(MyNATSocketClient P_0)
	{
		try
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 2);
			defaultInterpolatedStringHandler.AppendLiteral("#G你的无双争夺战胜场信息如下：#n#r#Y累计胜利场次：#n#G");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.无双圣榜数据.总累胜场次);
			defaultInterpolatedStringHandler.AppendLiteral("#n#r#Y连续胜利场次：#G");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.无双圣榜数据.总连胜场次);
			defaultInterpolatedStringHandler.AppendLiteral("#n#r");
			StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
			switch (P_0.user.存档数据.无双圣榜数据.累胜领取进度)
			{
			case 0:
				stringBuilder.Append("[领取累胜场次奖励（未领取）/圣无双操作_领取累胜奖励]");
				break;
			case 20:
				stringBuilder.Append("[领取累胜场次奖励（20场胜利奖励已领取）/圣无双操作_领取累胜奖励]");
				break;
			case 50:
				stringBuilder.Append("[领取累胜场次奖励（20、50场胜利奖励已领取）/圣无双操作_领取累胜奖励]");
				break;
			case 100:
				stringBuilder.Append("[领取累胜场次奖励（20、50、100场胜利奖励已领取）/圣无双操作_领取累胜奖励]");
				break;
			case 200:
				stringBuilder.Append("[领取累胜场次奖励（20、50、100、200场胜利奖励已领取）/圣无双操作_领取累胜奖励]");
				break;
			case 500:
				stringBuilder.Append("#G累胜场次（20、50、100、200、500场奖励已领取）#n#r");
				break;
			}
			switch (P_0.user.存档数据.无双圣榜数据.连胜领取进度)
			{
			case 0:
				stringBuilder.Append("[领取连胜场次奖励（未领取）/圣无双操作_领取连胜奖励]");
				break;
			case 10:
				stringBuilder.Append("[领取连胜场次奖励（10场连胜奖励已领取）/圣无双操作_领取连胜奖励]");
				break;
			case 30:
				stringBuilder.Append("[领取连胜场次奖励（10、30场连胜奖励已领取）/圣无双操作_领取连胜奖励]");
				break;
			case 50:
				stringBuilder.Append("[领取连胜场次奖励（10、30、50场连胜奖励已领取）/圣无双操作_领取连胜奖励]");
				break;
			case 100:
				stringBuilder.Append("[领取连胜场次奖励（10、30、50、100场连胜奖励已领取）/圣无双操作_领取连胜奖励]");
				break;
			case 200:
				stringBuilder.Append("#G连胜场次（10、30、50、100、200场奖励已领取）#n#r");
				break;
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(101, Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc形象, Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc名字, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("领取胜场奖励对话-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private void fk4bS9LOiG(MyNATSocketClient P_0)
	{
		try
		{
			if (zCybkJu0wB == AllEnums.圣无双Type.未开始)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("本届活动尚未开始，暂无活动规则可查询！"));
				return;
			}
			kwObOsrG9Y.Clear();
			StringBuilder stringBuilder = kwObOsrG9Y;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(119, 8, stringBuilder);
			handler.AppendLiteral("#G本届无双争夺战重要规则如下：#r#n1、争夺战开启最低人数为#Y");
			handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.最低人数);
			handler.AppendLiteral("人#r2、报名缴纳费用为#Y");
			handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.门票价格);
			handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.门票类型);
			handler.AppendLiteral("#n#r3、初始无双积分为#Y");
			handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.初始积分);
			handler.AppendLiteral("点#n#r4、每场战斗胜者夺取败方#R");
			handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.夺取积分);
			handler.AppendLiteral("点#n积分#r5、本届争夺战为#Y");
			handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.is匹配模式 ? "随机匹配" : "自由战斗");
			handler.AppendLiteral("#n模式#r6、当前模式");
			handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.is同IP战斗 ? "#Y允许#n相同IP玩家战斗" : "#R不允许#n相同IP玩家战斗");
			handler.AppendLiteral("#r7、当前模式");
			handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.is同IP夺取 ? "#Y允许#n相同IP玩家相互夺取无双积分" : "#R不允许#n相同IP玩家相互夺取无双积分");
			stringBuilder.Append(ref handler);
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(101, Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc形象, Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc名字, kwObOsrG9Y.ToString()));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("取当前活动规则-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal bool uowbcISuTj(MyNATSocketClient P_0, int P_1)
	{
		if (zCybkJu0wB != AllEnums.圣无双Type.进行时)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前活动尚未开始，无法进行争夺战斗！"));
			return false;
		}
		if (Singleton<全局变量类>.I.圣无双配置.is匹配模式)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前活动模式为系统匹配，无法自行选择争夺对手战斗！"));
			return false;
		}
		if (P_0.user.人物数据.角色ID == P_1)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("不能选择自己！"));
			return false;
		}
		MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定角色ID玩家MyClient(P_1);
		if (myNATSocketClient == null)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("选择的对手暂时不在线，无法开始战斗！"));
			return false;
		}
		if (myNATSocketClient.user.缓存数据.is战斗中)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("选择的对手正在战斗中！"));
			return false;
		}
		if (myNATSocketClient.user.存档数据.无双圣榜数据.当前积分 <= 0)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("选择的对手已经被淘汰，请重新选择对手！"));
			return false;
		}
		P_0.user.缓存数据.无双缓存数据.对手ClientId = myNATSocketClient.IdKey;
		myNATSocketClient.user.缓存数据.无双缓存数据.对手ClientId = P_0.IdKey;
		P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("无双争夺战斗开始，你当前的对手为#Y" + myNATSocketClient.user.人物数据.昵称 + "#n"));
		myNATSocketClient.C_Send(Singleton<WdAPI>.I.提示_中心提醒("无双争夺战斗开始，你当前的对手为#Y" + P_0.user.人物数据.昵称 + "#n"));
		return true;
	}

	
	internal void Yq5bn4pHcy(MyNATSocketClient P_0)
	{
		StringBuilder stringBuilder = new StringBuilder("#G本届无双圣榜排名如下：#n#r");
		StringBuilder stringBuilder2;
		StringBuilder.AppendInterpolatedStringHandler handler;
		for (int i = 0; i < Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励.Length; i++)
		{
			if (i >= Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.排行数据.Count)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
				handler.AppendLiteral("#Y第");
				handler.AppendFormatted(i + 1);
				handler.AppendLiteral("名：#n暂无数据(");
				handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[i]);
				handler.AppendLiteral("奖励)#r");
				stringBuilder3.Append(ref handler);
			}
			else
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 3, stringBuilder2);
				handler.AppendLiteral("#Y第");
				handler.AppendFormatted(i + 1);
				handler.AppendLiteral("名：#n");
				handler.AppendFormatted(Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.排行数据[i].玩家名字);
				handler.AppendLiteral("(");
				handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[i]);
				handler.AppendLiteral("奖励)#r");
				stringBuilder4.Append(ref handler);
			}
		}
		stringBuilder2 = stringBuilder;
		StringBuilder stringBuilder5 = stringBuilder2;
		handler = new StringBuilder.AppendInterpolatedStringHandler(16, 1, stringBuilder2);
		handler.AppendLiteral("你在本届无双圣榜第#Y");
		handler.AppendFormatted((P_0.user.存档数据.无双圣榜数据.圣榜排名 <= 0) ? "11" : ((object)P_0.user.存档数据.无双圣榜数据.圣榜排名));
		handler.AppendLiteral("#n名#r");
		stringBuilder5.Append(ref handler);
		if (P_0.user.存档数据.无双圣榜数据.圣榜排名 > 0 && P_0.user.存档数据.无双圣榜数据.圣榜排名 <= 10)
		{
			if (P_0.user.存档数据.无双圣榜数据.is排行领取)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder6 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(21, 1, stringBuilder2);
				handler.AppendLiteral("#r#G本届无双圣榜第");
				handler.AppendFormatted(P_0.user.存档数据.无双圣榜数据.圣榜排名);
				handler.AppendLiteral("名奖励（已领取）#n");
				stringBuilder6.Append(ref handler);
			}
			else
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder7 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(31, 1, stringBuilder2);
				handler.AppendLiteral("[领取本届无双圣榜第");
				handler.AppendFormatted(P_0.user.存档数据.无双圣榜数据.圣榜排名);
				handler.AppendLiteral("名奖励/圣无双操作_领取本届无双圣榜奖励]");
				stringBuilder7.Append(ref handler);
			}
		}
		P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(101, Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc形象, Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc名字, stringBuilder.ToString()));
	}

	
	internal void qmbb5HS1Ea(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_1 == "圣无双操作_查看排名")
			{
				Yq5bn4pHcy(P_0);
			}
			else if (P_1 == "圣无双操作_领取奖励")
			{
				r16bLTg3QG(P_0);
			}
			else if (P_1 == "圣无双操作_领取本届无双圣榜奖励")
			{
				if (P_0.user.存档数据.无双圣榜数据.is排行领取)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你已经领取了本届无双圣榜排行奖励！"));
				}
				else if (P_0.user.存档数据.无双圣榜数据.圣榜排名 == 0 || P_0.user.存档数据.无双圣榜数据.圣榜排名 > 10)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前并不在排行榜，无法领取奖励！"));
				}
				else if (Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励.Length >= P_0.user.存档数据.无双圣榜数据.圣榜排名)
				{
					P_0.user.存档数据.无双圣榜数据.is排行领取 = true;
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[P_0.user.存档数据.无双圣榜数据.圣榜排名 - 1], AllEnums.指令Type.无, 1, false, "领取无双圣榜奖励");
					WdAPI i = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
					defaultInterpolatedStringHandler.AppendLiteral("恭喜你，领取了无双圣榜第#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.无双圣榜数据.圣榜排名);
					defaultInterpolatedStringHandler.AppendLiteral("#n名的#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[P_0.user.存档数据.无双圣榜数据.圣榜排名 - 1]);
					defaultInterpolatedStringHandler.AppendLiteral("#n奖励！");
					P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			}
			else if (P_1 == "圣无双操作_大圣雕像参拜")
			{
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(74, 3);
				defaultInterpolatedStringHandler.AppendLiteral("[@确定/圣无双操作_大圣雕像参拜确认#DLG:1#prompt:你确定要花费#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.参拜消耗类型);
				defaultInterpolatedStringHandler.AppendLiteral("#n参拜本届的无双大圣吗#R（本日剩余#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.参拜雕像次数 - P_0.user.存档数据.无双圣榜数据.本日参拜次数);
				defaultInterpolatedStringHandler.AppendLiteral("#R次参拜机会）#n？]");
				P_0.C_Send(i2.组包确定框(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else if (P_1 == "圣无双操作_大圣雕像参拜确认")
			{
				if (P_0.user.存档数据.无双圣榜数据.本日参拜次数 >= Singleton<全局变量类>.I.圣无双配置.参拜雕像次数)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("今日参拜次数已用尽，无法进行参拜！"));
					return;
				}
				switch (Singleton<全局变量类>.I.圣无双配置.参拜消耗类型)
				{
				case AllEnums.数值Type.金元宝:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.背包数据.金元宝 < Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗)
					{
						WdAPI i5 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你的金元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法进行参拜！");
						P_0.C_Send(i5.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					if (!DB.I.cAJNoOkab6(P_0, -Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗, 0))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的金元宝#R扣除失败#n，无法进行参拜！"));
						return;
					}
					WdAPI i6 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗);
					defaultInterpolatedStringHandler.AppendLiteral("#n金元宝参拜了本届的无双大圣！");
					P_0.C_Send(i6.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.银元宝:
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0.user.背包数据.银元宝 < Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗)
					{
						WdAPI i3 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
						defaultInterpolatedStringHandler.AppendLiteral("你的银元宝不足#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗);
						defaultInterpolatedStringHandler.AppendLiteral("#n，无法进行参拜！");
						P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
					if (!DB.I.cAJNoOkab6(P_0, 0, -Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的银元宝#R扣除失败#n，无法进行参拜！"));
						return;
					}
					WdAPI i4 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你消耗了#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗);
					defaultInterpolatedStringHandler.AppendLiteral("#n银元宝参拜了本届的无双大圣！");
					P_0.C_Send(i4.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					break;
				}
				case AllEnums.数值Type.金钱:
					if (P_0.user.背包数据.金钱 < Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你的金钱不足" + Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗) + "文钱，无法进行参拜！"));
						return;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗, false, "[无双]门票消耗");
					P_0.C_Send(Singleton<WdAPI>.I.提示_杂项公告("你消耗了" + Singleton<WdAPI>.I.问道标准数值文本(Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗) + "文钱参拜了本届的无双大圣！"));
					break;
				}
				P_0.user.存档数据.无双圣榜数据.本日参拜次数++;
				Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前雕像参拜次数++;
				if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.圣无双配置.参拜雕像奖励) && !Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.圣无双配置.参拜雕像奖励, AllEnums.指令Type.无, 1, false, "参拜奖励"))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("由于你诚心参拜了大圣雕像提供了精纯的信仰，获得了无双大圣赏赐的#Y" + Singleton<全局变量类>.I.圣无双配置.参拜雕像奖励 + "#n！"));
				}
				Singleton<MainService>.I.获取指定GID玩家MyClient(Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣继承者Gid)?.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("由于#Y" + P_0.user.人物数据.昵称 + "#n对你的雕像诚心参拜，你获得了精纯的信仰，圣位加持有所提升"));
			}
			else if (P_1 == "圣无双操作_大圣雕像吸取")
			{
				if (P_0.user.人物数据.GID != Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣继承者Gid)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你非本届无双大圣，无法吸收大圣雕像之中的信仰之力！"));
				}
				else if (Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前雕像参拜次数 <= 0)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前并无人参拜你的大圣雕像，所以没有信仰之力可供吸收！"));
				}
				else if (Singleton<全局变量类>.I.圣无双配置.每次参拜雕像增幅 > 0)
				{
					if (P_0.user.存档数据.无双圣榜数据.is本日加成领取)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("大圣雕像的信仰之力转化的无双圣力今日已注入你的道躯，等待明日信仰之力恢复吧！"));
						return;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.attack_effect, Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前雕像参拜次数 * Singleton<全局变量类>.I.圣无双配置.每次参拜雕像增幅, true, "[无双]雕像参拜属性增加");
					P_0.user.存档数据.无双圣榜数据.is本日加成领取 = true;
					WdAPI i7 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 1);
					defaultInterpolatedStringHandler.AppendLiteral("恭喜道友，大圣雕像内精纯的信仰之力已经转化为无双圣力注入你的道躯，获得#Y");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前雕像参拜次数);
					defaultInterpolatedStringHandler.AppendLiteral("%#n的无双攻击效果！");
					P_0.C_Send(i7.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			}
			else if (P_1 == "圣无双操作_领取累胜奖励")
			{
				switch (P_0.user.存档数据.无双圣榜数据.累胜领取进度)
				{
				case 0:
					if (P_0.user.存档数据.无双圣榜数据.总累胜场次 >= 20)
					{
						if (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.TryGetValue(20, out 发送物品数据类 value4))
						{
							P_0.user.存档数据.无双圣榜数据.累胜领取进度 = 20;
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, value4.名字, AllEnums.指令Type.无, value4.数量, false, "领取累胜20奖励");
						}
					}
					else
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前总累计胜利场次不足20场，无法领取奖励！"));
					}
					break;
				case 20:
					if (P_0.user.存档数据.无双圣榜数据.总累胜场次 >= 50)
					{
						if (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.TryGetValue(50, out 发送物品数据类 value3))
						{
							P_0.user.存档数据.无双圣榜数据.累胜领取进度 = 50;
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, value3.名字, AllEnums.指令Type.无, value3.数量, false, "领取累胜50奖励");
						}
					}
					else
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前总累计胜利场次不足50场，无法领取奖励！"));
					}
					break;
				case 50:
					if (P_0.user.存档数据.无双圣榜数据.总累胜场次 >= 100)
					{
						if (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.TryGetValue(100, out 发送物品数据类 value2))
						{
							P_0.user.存档数据.无双圣榜数据.累胜领取进度 = 100;
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, value2.名字, AllEnums.指令Type.无, value2.数量, false, "领取累胜100奖励");
						}
					}
					else
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前总累计胜利场次不足100场，无法领取奖励！"));
					}
					break;
				case 100:
					if (P_0.user.存档数据.无双圣榜数据.总累胜场次 >= 200)
					{
						if (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.TryGetValue(200, out 发送物品数据类 value5))
						{
							P_0.user.存档数据.无双圣榜数据.累胜领取进度 = 200;
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, value5.名字, AllEnums.指令Type.无, value5.数量, false, "领取累胜200奖励");
						}
					}
					else
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前总累计胜利场次不足200场，无法领取奖励！"));
					}
					break;
				case 200:
					if (P_0.user.存档数据.无双圣榜数据.总累胜场次 >= 500)
					{
						if (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.TryGetValue(500, out 发送物品数据类 value))
						{
							P_0.user.存档数据.无双圣榜数据.累胜领取进度 = 500;
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, value.名字, AllEnums.指令Type.无, value.数量, false, "领取累胜500奖励");
						}
					}
					else
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前总累计胜利场次不足500场，无法领取奖励！"));
					}
					break;
				}
			}
			else if (P_1 == "圣无双操作_领取连胜奖励")
			{
				switch (P_0.user.存档数据.无双圣榜数据.连胜领取进度)
				{
				case 0:
					if (P_0.user.存档数据.无双圣榜数据.总连胜场次 >= 10)
					{
						if (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.TryGetValue(10, out 发送物品数据类 value9))
						{
							P_0.user.存档数据.无双圣榜数据.连胜领取进度 = 10;
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, value9.名字, AllEnums.指令Type.无, value9.数量, false, "领取连胜10奖励");
						}
					}
					else
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前总连胜场次不足10场，无法领取奖励！"));
					}
					break;
				case 10:
					if (P_0.user.存档数据.无双圣榜数据.总连胜场次 >= 30)
					{
						if (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.TryGetValue(30, out 发送物品数据类 value8))
						{
							P_0.user.存档数据.无双圣榜数据.连胜领取进度 = 30;
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, value8.名字, AllEnums.指令Type.无, value8.数量, false, "领取连胜30奖励");
						}
					}
					else
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前总连胜场次不足30场，无法领取奖励！"));
					}
					break;
				case 30:
					if (P_0.user.存档数据.无双圣榜数据.总连胜场次 >= 50)
					{
						if (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.TryGetValue(50, out 发送物品数据类 value7))
						{
							P_0.user.存档数据.无双圣榜数据.连胜领取进度 = 50;
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, value7.名字, AllEnums.指令Type.无, value7.数量, false, "领取连胜50奖励");
						}
					}
					else
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前总连胜场次不足50场，无法领取奖励！"));
					}
					break;
				case 50:
					if (P_0.user.存档数据.无双圣榜数据.总连胜场次 >= 100)
					{
						if (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.TryGetValue(100, out 发送物品数据类 value10))
						{
							P_0.user.存档数据.无双圣榜数据.连胜领取进度 = 100;
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, value10.名字, AllEnums.指令Type.无, value10.数量, false, "领取连胜100奖励");
						}
					}
					else
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前总连胜场次不足100场，无法领取奖励！"));
					}
					break;
				case 100:
					if (P_0.user.存档数据.无双圣榜数据.总连胜场次 >= 200)
					{
						if (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.TryGetValue(200, out 发送物品数据类 value6))
						{
							P_0.user.存档数据.无双圣榜数据.连胜领取进度 = 200;
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, value6.名字, AllEnums.指令Type.无, value6.数量, false, "领取连胜200奖励");
						}
					}
					else
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前总连胜场次不足200场，无法领取奖励！"));
					}
					break;
				}
			}
			else if (P_1 == "圣无双操作_确定报名")
			{
				KRFbFwXOpy(P_0);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("圣无双对话事件处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void a3KbMq9b3m(MyNATSocketClient P_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (Singleton<全局变量类>.I.圣无双配置.功能开关)
			{
				if (Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣继承者Gid == 0)
				{
					stringBuilder.Append("无双圣位空缺，敢问天下谁人，可夺此神位、立此雕像、万人参拜、居高临下、俯瞰众生#r#R乾坤未定，你我皆可成圣位，立圣像！！！#n所有已经报名成功的道友在规定时间内可在此处进入战场，切忌不要错误了活动开始时间，否则即使报名成功也无法进入战场了#r");
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(47, 3, stringBuilder2);
					handler.AppendLiteral("#Y活动开始时间：#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.开始时间);
					handler.AppendLiteral("#n#r#Y最低报名人数：#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.最低人数);
					handler.AppendLiteral("#n#r#Y当前活动模式：#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.is匹配模式 ? "随机匹配" : "自由战斗");
					handler.AppendLiteral("#n模式#r");
					stringBuilder3.Append(ref handler);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(15, 2, stringBuilder2);
					handler.AppendLiteral("#Y活动报名花费：#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.门票价格);
					handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.门票类型);
					handler.AppendLiteral("#n#r");
					stringBuilder4.Append(ref handler);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
					handler.AppendFormatted(P_0.user.存档数据.无双圣榜数据.is报名 ? "#Y当前已经报名成功" : "#R当前并未报名");
					handler.AppendLiteral("#r");
					stringBuilder5.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(92, 7, stringBuilder2);
					handler.AppendLiteral("#Y本届无双大圣：#R");
					handler.AppendFormatted(Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣名字);
					handler.AppendLiteral("#n#r#Y无双大圣等级：#R");
					handler.AppendFormatted(Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣等级);
					handler.AppendLiteral("#n#r#Y无双大圣道行：#R");
					handler.AppendFormatted(Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣道行 / 360);
					handler.AppendLiteral("#n年#r#Y圣像信仰加持：#R");
					handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.参拜雕像次数);
					handler.AppendLiteral("#n%#r#Y参拜无双大圣：#R");
					handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗);
					handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.参拜消耗类型);
					handler.AppendLiteral("/次#n#r#Y参拜圣像奖励：#R");
					handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.参拜雕像奖励);
					handler.AppendLiteral("#n");
					stringBuilder6.Append(ref handler);
					if (P_0.user.人物数据.GID == Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣继承者Gid && Singleton<全局变量类>.I.圣无双配置.每次参拜雕像增幅 > 0)
					{
						stringBuilder.Append("[吸取众生信仰之力（限每日一次）/圣无双操作_大圣雕像吸取]");
					}
					else
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder7 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(21, 1, stringBuilder2);
						handler.AppendLiteral("[【参拜大圣】");
						handler.AppendFormatted(Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣名字);
						handler.AppendLiteral("/圣无双操作_大圣雕像参拜]");
						stringBuilder7.Append(ref handler);
					}
				}
				if (zCybkJu0wB == AllEnums.圣无双Type.报名时)
				{
					if (!P_0.user.存档数据.无双圣榜数据.is报名)
					{
						stringBuilder.Append("[【报名】无双争夺战/圣无双操作_确定报名]");
					}
					else
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder8 = stringBuilder2;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 2, stringBuilder2);
						handler.AppendLiteral("[【传送】");
						handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.地图名字);
						handler.AppendLiteral("/前往");
						handler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.地图名字);
						handler.AppendLiteral("]");
						stringBuilder8.Append(ref handler);
					}
				}
				else
				{
					stringBuilder.Append("[【圣榜】查看本届排名/圣无双操作_查看排名][【奖励】领取胜场奖励/圣无双操作_领取奖励]");
				}
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(101, Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc形象, string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣名字) ? Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc名字 : Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣名字, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("NPC对话生成-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal string x4JbhM8PEi(MyNATSocketClient P_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (P_0.user.人物数据.所在地图名字 == Singleton<全局变量类>.I.圣无双配置.地图名字)
			{
				if (P_0.user.存档数据.无双圣榜数据.is报名)
				{
					stringBuilder.Append("我可以将你传送回天墉城！#r#R活动开始期间离开战场(#O已淘汰人员不影响#R)有以下影响：#r#Y清空当前所有无双积分#r清空本届累胜场次#r无法上榜本届无双圣榜#r#R请仔细考虑后在进行操作！");
				}
				else
				{
					stringBuilder.Append("我可以将你传送回天墉城！");
				}
			}
			return stringBuilder.ToString();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("组合回城NPC对话-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return string.Empty;
		}
	}

	
	internal void g5DbvWpAhY(MyNATSocketClient P_0)
	{
		try
		{
			string value;
			if (!Singleton<全局变量类>.I.圣无双配置.功能开关)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前时间并非无双争夺战报名期间，无法进入#R" + Singleton<全局变量类>.I.圣无双配置.地图名字 + "#n！"));
			}
			else if (zCybkJu0wB != AllEnums.圣无双Type.报名时)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前时间并非无双争夺战报名期间，无法进入#R" + Singleton<全局变量类>.I.圣无双配置.地图名字 + "#n！"));
			}
			else if (!P_0.user.存档数据.无双圣榜数据.is报名)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前并未报名，无法进入#R" + Singleton<全局变量类>.I.圣无双配置.地图名字 + "#n！"));
			}
			else if (P_0.user.人物数据.所在区线路 != Singleton<全局变量类>.I.圣无双配置.活动线路名字)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("无双争夺战活动在#Y" + Singleton<全局变量类>.I.圣无双配置.活动线路名字 + "#n举行，请切换到对应线路参加！"));
			}
			else if (!P_0.user.人物数据.is允许切磋)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("请打开切磋开关，否则无法进入无双战场！"));
			}
			else if (P_0.user.队伍数据.成员列表.Count > 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("无法组队进入无双战场！"));
			}
			else if (Singleton<全局变量类>.I.所有地图字典.TryGetValue(Singleton<全局变量类>.I.圣无双配置.地图名字, out value))
			{
				Singleton<WdAPI>.I.地图传送事件(P_0, value);
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("圣无双战场传送检验-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void uGGb7FpVJN()
	{
		zCybkJu0wB = AllEnums.圣无双Type.报名时;
		rHEba3jMig();
		HqVbTMOdLh();
		if (Singleton<全局变量类>.I.圣无双配置.is匹配模式)
		{
			Lp5b9HRZMi();
		}
	}

	
	internal async Task rHEba3jMig()
	{
		try
		{
			foreach (角色存档数据类 value in Singleton<全局变量类>.I.角色存档表.Values)
			{
				value.无双圣榜数据.清空();
			}
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.清空();
			int 开始时间 = (int)Singleton<ByteAPI>.I.取时间戳(Singleton<全局变量类>.I.圣无双配置.开始时间);
			while (Singleton<全局变量类>.I.圣无双配置.功能开关 && zCybkJu0wB == AllEnums.圣无双Type.报名时)
			{
				int num = (int)Singleton<ByteAPI>.I.取时间戳();
				if (开始时间 - num <= 0)
				{
					Log.Debug("活动开始时间到了");
					break;
				}
				if (开始时间 - num <= 1800)
				{
					Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息(string.Format(Singleton<全局变量类>.I.圣无双配置.开启前公告, (开始时间 - num) / 60), "管理员", AllEnums.频道Type.系统));
				}
				await Task.Delay(60000);
			}
			if (!Singleton<全局变量类>.I.圣无双配置.功能开关)
			{
				zCybkJu0wB = AllEnums.圣无双Type.未开始;
				foreach (角色存档数据类 value2 in Singleton<全局变量类>.I.角色存档表.Values)
				{
					value2.无双圣榜数据.清空();
				}
				Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息("很遗憾，系统关闭了无双争夺战，本届无双争夺战活动开启失败，无双大圣之位即将空缺！", "管理员", AllEnums.频道Type.系统));
			}
			else
			{
				if (zCybkJu0wB != AllEnums.圣无双Type.报名时)
				{
					return;
				}
				List<MyNATSocketClient> list = Singleton<全局变量类>.I.会话Dict.Values.ToList().FindAll( (MyNATSocketClient a) => a.使用中 && a.user.人物数据.所在地图名字 == Singleton<全局变量类>.I.圣无双配置.地图名字 && a.user.存档数据.无双圣榜数据.is报名);
				if (list.Count < Singleton<全局变量类>.I.圣无双配置.最低人数)
				{
					zCybkJu0wB = AllEnums.圣无双Type.未开始;
					foreach (角色存档数据类 value3 in Singleton<全局变量类>.I.角色存档表.Values)
					{
						value3.无双圣榜数据.清空();
					}
					Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件 != null)
					{
						WdAPI i = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 1);
						defaultInterpolatedStringHandler.AppendLiteral("很遗憾，当前参与无双争夺战的人数不足#Y");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.最低人数);
						defaultInterpolatedStringHandler.AppendLiteral("#n人，本届无双争夺战活动开启失败，无双大圣之位即将空缺！");
						client频道事件(i.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员", AllEnums.频道Type.系统));
					}
				}
				else
				{
					Action<byte[]> client频道事件2 = Singleton<全局变量类>.I.Client频道事件;
					if (client频道事件2 != null)
					{
						WdAPI i2 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(55, 1);
						defaultInterpolatedStringHandler.AppendLiteral("#Y【无双争夺战】#n活动正式开始了，当前参与无双圣位争夺人数为#Y");
						defaultInterpolatedStringHandler.AppendFormatted(list.Count);
						defaultInterpolatedStringHandler.AppendLiteral("#n人，乾坤未定，究竟谁才能继承大圣之位？");
						client频道事件2(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员", AllEnums.频道Type.系统));
					}
					for (int num2 = 0; num2 < list.Count; num2++)
					{
						list[num2].C_Send(Singleton<WdAPI>.I.提示_中心提醒(Singleton<全局变量类>.I.圣无双配置.is匹配模式 ? "无双争夺战正式开始，等待系统匹配对手！" : "无双争夺战正式开始，可随意挑选你的对手进行争夺战斗了！"));
					}
					zCybkJu0wB = AllEnums.圣无双Type.进行时;
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("无双活动启动线程：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private async Task HqVbTMOdLh()
	{
		try
		{
			new List<MyNATSocketClient>();
			Array.Empty<byte>();
			while (Singleton<全局变量类>.I.圣无双配置.功能开关)
			{
				await Task.Delay(60000);
				if (zCybkJu0wB == AllEnums.圣无双Type.未开始)
				{
					break;
				}
				List<MyNATSocketClient> list = Singleton<全局变量类>.I.会话Dict.Values.ToList().FindAll( (MyNATSocketClient a) => a.使用中 && a.user.人物数据.所在地图名字 == Singleton<全局变量类>.I.圣无双配置.地图名字 && a.user.存档数据.无双圣榜数据.is报名);
				if (list == null || list.Count <= 0)
				{
					continue;
				}
				byte[] buffer = Singleton<WdAPI>.I.Fruo8nupmJ(list.Count);
				for (int num = 0; num < list.Count; num++)
				{
					if (!list[num].user.缓存数据.is战斗中)
					{
						list[num].C_Send(buffer);
					}
				}
				if (zCybkJu0wB == AllEnums.圣无双Type.进行时 && list.Count <= 1)
				{
					M0BbVebCOv((list.Count == 1) ? list[0] : null);
					zCybkJu0wB = AllEnums.圣无双Type.未开始;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Log.Debug("启动实时统计人数线程：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private async Task Lp5b9HRZMi()
	{
		try
		{
			_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass22_0();
			if (!Singleton<全局变量类>.I.所有地图字典.ContainsKey(Singleton<全局变量类>.I.圣无双配置.地图名字))
			{
				return;
			}
			CS_0024_003C_003E8__locals3.UIlFj8fwkS = 0;
			new List<MyNATSocketClient>();
			while (Singleton<全局变量类>.I.圣无双配置.功能开关)
			{
				await Task.Delay(30000);
				if (zCybkJu0wB == AllEnums.圣无双Type.未开始)
				{
					break;
				}
				if (zCybkJu0wB == AllEnums.圣无双Type.报名时 || zCybkJu0wB != AllEnums.圣无双Type.进行时)
				{
					continue;
				}
				if (!Singleton<全局变量类>.I.圣无双配置.is匹配模式)
				{
					Singleton<MainService>.I.SendAllClient(Singleton<WdAPI>.I.提示_提醒和杂项公告("匹配规则已取消，参与无双争夺战的道友现在可以自由选择对手进行战斗！"));
					break;
				}
				CS_0024_003C_003E8__locals3.UIlFj8fwkS = (int)Singleton<ByteAPI>.I.取时间戳();
				List<MyNATSocketClient> list = Singleton<全局变量类>.I.会话Dict.Values.ToList().FindAll( (MyNATSocketClient a) => a.使用中 && a.user.人物数据.所在地图名字 == Singleton<全局变量类>.I.圣无双配置.地图名字 && a.user.存档数据.无双圣榜数据.is报名 && a.user.存档数据.无双圣榜数据.当前积分 > 0 && CS_0024_003C_003E8__locals3.UIlFj8fwkS - a.user.缓存数据.无双缓存数据.无双战斗结束时间戳 >= 30 && !a.user.缓存数据.is战斗中);
				if (list.Count < 2)
				{
					continue;
				}
				list = Singleton<WdAPI>.I.usfohIuMNi(list);
				if (list.Count % 2 != 0)
				{
					list.RemoveAt(0);
				}
				for (int num = 0; num < list.Count; num++)
				{
					if (num == 0 || num % 2 == 0)
					{
						RRnbyRcExc(list[num], list[num + 1]);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("启动实时匹配模式线程：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task RRnbyRcExc(MyNATSocketClient P_0, MyNATSocketClient P_1)
	{
		try
		{
			if (P_0 != null && P_1 != null && !(P_0.user.人物数据.所在地图名字 != P_1.user.人物数据.所在地图名字) && Singleton<全局变量类>.I.所有地图字典.TryGetValue(Singleton<全局变量类>.I.圣无双配置.地图名字, out var _))
			{
				P_0.user.缓存数据.无双缓存数据.对手ClientId = P_1.IdKey;
				P_1.user.缓存数据.无双缓存数据.对手ClientId = P_0.IdKey;
				string format = "系统已自动为您匹配到争夺对手，即将在#R3秒#n内进入战斗，请做好准备！#G当前对手：#Y{0}#n";
				P_0.C_Send(Singleton<WdAPI>.I.提示_杂项公告(string.Format(format, P_1.user.人物数据.昵称)));
				P_1.C_Send(Singleton<WdAPI>.I.提示_杂项公告(string.Format(format, P_0.user.人物数据.昵称)));
				P_1.S_Send(Singleton<WdAPI>.I.接近玩家事件(P_0.user.人物数据.昵称));
				await Task.Delay(2000);
				Singleton<WdAPI>.I.xfMIZbTlE0(P_0, P_1.user.人物数据.角色ID);
			}
		}
		catch (Exception ex)
		{
			Log.Error("无双系统匹配双方处理：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task LnRbC8OVA0(MyNATSocketClient P_0, bool P_1)
	{
		try
		{
			await Task.Delay(10);
			MyNATSocketClient myNATSocketClient = Singleton<MainService>.I.获取指定key玩家MyClient(P_0.user.缓存数据.无双缓存数据.对手ClientId);
			if (myNATSocketClient == null)
			{
				return;
			}
			P_0.user.缓存数据.无双缓存数据.无双战斗结束时间戳 = (int)Singleton<ByteAPI>.I.取时间戳();
			P_0.user.缓存数据.无双缓存数据.对手ClientId = string.Empty;
			if (!P_1)
			{
				return;
			}
			P_0.user.存档数据.无双圣榜数据.总连胜场次 = 0;
			P_0.user.存档数据.无双圣榜数据.当前积分 -= Singleton<全局变量类>.I.圣无双配置.夺取积分;
			if (P_0.user.存档数据.无双圣榜数据.当前积分 < 0)
			{
				P_0.user.存档数据.无双圣榜数据.当前积分 = 0;
			}
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗失败，损失#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.夺取积分);
			defaultInterpolatedStringHandler.AppendLiteral("#n点无双积分，当前积分：#Y");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.无双圣榜数据.当前积分);
			defaultInterpolatedStringHandler.AppendLiteral("#n点");
			P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			if (P_0.user.存档数据.无双圣榜数据.当前积分 <= 0)
			{
				P_0.user.存档数据.无双圣榜数据.is报名 = false;
				P_0.user.存档数据.无双圣榜数据.淘汰时间 = (int)Singleton<ByteAPI>.I.取时间戳();
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("由于当前积分为#R0#n，你被淘汰了！"));
				Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
				if (client频道事件 != null)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#Y");
					defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("#n道友在无双争夺战中大杀四方，将#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("#n道友击杀淘汰！！！");
					client频道事件(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
				}
				Singleton<WdAPI>.I.地图传送事件(P_0, "/gs/zone/tianyongcheng/tianyongcheng.c", "253", "196");
			}
			myNATSocketClient.user.存档数据.无双圣榜数据.总连胜场次++;
			myNATSocketClient.user.存档数据.无双圣榜数据.本届累胜场次++;
			myNATSocketClient.user.存档数据.无双圣榜数据.总累胜场次++;
			WdAPI i3 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗胜出，夺取了对方#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.圣无双配置.夺取积分);
			defaultInterpolatedStringHandler.AppendLiteral("#n点无双积分，当前积分：#Y");
			defaultInterpolatedStringHandler.AppendFormatted(myNATSocketClient.user.存档数据.无双圣榜数据.当前积分);
			defaultInterpolatedStringHandler.AppendLiteral("#n点");
			myNATSocketClient.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("战斗结束双方回调-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	private async Task M0BbVebCOv(MyNATSocketClient P_0)
	{
		try
		{
			await Task.Delay(1000);
			if (P_0 == null)
			{
				Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc名字 = "虚位以待";
				Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc称号 = "无双大圣雕像（暂无）";
				Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息("很遗憾，由于战场内玩家全部提前离场，本届无双大圣空缺！", "管理员", AllEnums.频道Type.系统));
				return;
			}
			P_0.user.存档数据.无双圣榜数据.is报名 = false;
			P_0.user.存档数据.无双圣榜数据.圣榜排名 = 1;
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣继承者Gid = P_0.user.人物数据.GID;
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣名字 = P_0.user.人物数据.昵称;
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣等级 = P_0.user.属性数据.等级;
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.当前大圣道行 = P_0.user.属性数据.道行;
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npcid = 101;
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc名字 = P_0.user.人物数据.昵称;
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc称号 = "无双大圣";
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc形象 = 6341;
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.圣无双配置.无双奖励, AllEnums.指令Type.无, 1, false, "无双活动第一奖励");
			int num = P_0.user.存档数据.无双圣榜数据.当前积分 * Singleton<全局变量类>.I.圣无双配置.兑换比例;
			switch (Singleton<全局变量类>.I.圣无双配置.兑换类型)
			{
			case AllEnums.数值Type.金元宝:
				if (DB.I.cAJNoOkab6(P_0, num, 0))
				{
					WdAPI i4 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.无双圣榜数据.当前积分);
					defaultInterpolatedStringHandler.AppendLiteral("#n点无双积分已经自动兑换为#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n金元宝");
					P_0.C_Send(i4.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				break;
			case AllEnums.数值Type.银元宝:
				if (DB.I.cAJNoOkab6(P_0, 0, num))
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
					defaultInterpolatedStringHandler.AppendLiteral("你的#Y");
					defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.无双圣榜数据.当前积分);
					defaultInterpolatedStringHandler.AppendLiteral("#n点无双积分已经自动兑换为#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num);
					defaultInterpolatedStringHandler.AppendLiteral("#n银元宝");
					P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				break;
			case AllEnums.数值Type.累充点:
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, num, false, "无双积分经自动兑换");
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你的#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.无双圣榜数据.当前积分);
				defaultInterpolatedStringHandler.AppendLiteral("#n点无双积分已经自动兑换为#Y");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n累充点");
				P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			case AllEnums.数值Type.南极点:
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, num, false, "[无双积分兑换]获得");
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
				defaultInterpolatedStringHandler.AppendLiteral("你的#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.无双圣榜数据.当前积分);
				defaultInterpolatedStringHandler.AppendLiteral("#n点无双积分已经自动兑换为#Y");
				defaultInterpolatedStringHandler.AppendFormatted(num);
				defaultInterpolatedStringHandler.AppendLiteral("#n次南极抽奖");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			}
			P_0.user.存档数据.无双圣榜数据.当前积分 = 0;
			Singleton<WdAPI>.I.地图传送事件(P_0, "/gs/zone/tianyongcheng/tianyongcheng.c", "253", "196");
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.排行数据.Add(new 圣无双排行榜数据类
			{
				玩家GID = P_0.user.人物数据.GID,
				玩家名字 = P_0.user.人物数据.昵称,
				排行名次 = 1,
				本届胜利场次 = P_0.user.存档数据.无双圣榜数据.本届累胜场次
			});
			P_0.C_Send(Singleton<WdAPI>.I.jyLIAFgHTA(P_0, "恭喜你获得本届无双争夺战第一名，继承无双大圣圣位，请及时在无双圣榜领取奖励。并已在天墉城为您建立了大圣雕像可供世人参拜！"));
			List<角色存档数据类> list = Singleton<全局变量类>.I.角色存档表.Values.ToList().FindAll( (角色存档数据类 a) => a.无双圣榜数据.淘汰时间 > 0)?.OrderBy( (角色存档数据类 a) => a.无双圣榜数据.淘汰时间).ToList();
			if (list != null)
			{
				list = list.OrderBy( (角色存档数据类 a) => a.无双圣榜数据.淘汰时间).ToList();
				list.Reverse();
				for (int num2 = 0; num2 < ((list.Count > 9) ? 9 : list.Count); num2++)
				{
					list[num2].无双圣榜数据.圣榜排名 = num2 + 2;
					Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.排行数据.Add(new 圣无双排行榜数据类
					{
						玩家GID = list[num2].GID,
						玩家名字 = list[num2].昵称,
						排行名次 = num2 + 2,
						本届胜利场次 = list[num2].无双圣榜数据.本届累胜场次
					});
				}
			}
			Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息("恭喜#Y" + P_0.user.人物数据.昵称 + "#n以武入圣，成为本届无双大圣，与天同齐，天下无双！！！", "管理员", AllEnums.频道Type.系统));
			ahfbmf4uyK();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("无双活动结束处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public BpcEfFbiGBBV3s2B0ai()
	{
		XBPb0fJUAe = Array.Empty<byte>();
		kwObOsrG9Y = new StringBuilder();
	}

	static BpcEfFbiGBBV3s2B0ai()
	{
	}
}
