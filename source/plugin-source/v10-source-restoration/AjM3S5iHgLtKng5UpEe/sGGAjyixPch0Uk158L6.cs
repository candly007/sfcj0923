using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using B6XRmUwQK7iatdTWLwc;
using mxyyZlfUTTOCu8Y4ZsN;
using r6H7Ets2Rns31EhC17Y;

namespace AjM3S5iHgLtKng5UpEe;

internal class sGGAjyixPch0Uk158L6 : Singleton<sGGAjyixPch0Uk158L6>
{
	
	internal byte[] GBZi4oRkq3(MyNATSocketClient P_0, byte[] P_1)
	{
		封包_读 封包_读2 = new 封包_读(P_1, 0, P_1.Length);
		封包_写 封包_写2 = new 封包_写();
		封包_读2.Seek(10L, SeekOrigin.Begin);
		封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
		封包_写2.写字节集(封包_读2.读字节集(2), hasCount: false, 0);
		封包_写2.写文本型(封包_读2.读文本型(out string value, true, (byte)0, false), hasCount: true, 0);
		if (Singleton<ByteAPI>.I.寻找文本等(value, "【指引】天降神石", "安全设置指引", "速赛竞技场", "【修炼】法宝共生之术"))
		{
			return null;
		}
		string text = 封包_读2.读文本型(是否声明长度: true, 1, 是否反转长度: true);
		string text2 = 封包_读2.读文本型(是否声明长度: true, 1, 是否反转长度: true);
		if (value == "学习新的法术" && !string.IsNullOrWhiteSpace(text2))
		{
			text2 = string.Empty;
			Singleton<WdAPI>.I.k1vI5WDVju(P_0, new List<string> { value });
		}
		if (全局变量类.Is调试)
		{
			P_0.C_Send(Singleton<WdAPI>.I.提示_杂项公告("任务名称=" + value));
		}
		if (P_0.user.缓存数据.任务缓存字典.TryGetValue(value, out var _))
		{
			Singleton<ByteAPI>.I.寻找文本等(value, "妖魔道", "仙魔录", "伏魔录", "幻仙劫", "鲲鹏变", "地劫任务", "天劫任务");
			if (string.IsNullOrWhiteSpace(text2))
			{
				P_0.user.缓存数据.任务缓存字典.TryRemove(value, out var _);
			}
		}
		else if (!string.IsNullOrWhiteSpace(text2))
		{
			P_0.user.缓存数据.任务缓存字典.TryAdd(value, text2);
		}
		if (XhaJ3cfswGhhnmIequv.vI0fNpyhWg() && (Enum.TryParse<AllEnums.日常类型Type>(value, out var result) || value.StartsWith("八仙梦境|") || Singleton<ByteAPI>.I.寻找文本等(value, "降妖任务", "伏魔任务", "仙界通缉", "飞仙渡邪", "天罡十绝阵", "天罡寻仙任务", "300环连环", "兰若寺", "烈火涧", "桃花谷", "古树仙境", "【昆仑神镜】伏羲创八卦", "【昆仑神镜】神农尝百草", "【昆仑神镜】燧人取圣火", "【昆仑神镜】女娲补苍天")))
		{
			if (Singleton<ByteAPI>.I.寻找文本等(value, "降妖任务", "伏魔任务", "仙界通缉", "飞仙渡邪"))
			{
				result = AllEnums.日常类型Type.刷道任务;
			}
			else if (value.StartsWith("八仙梦境|"))
			{
				result = AllEnums.日常类型Type.八仙梦境;
			}
			else if (value == "天罡十绝阵")
			{
				result = AllEnums.日常类型Type.十绝阵;
			}
			else if (value == "天罡寻仙任务")
			{
				result = AllEnums.日常类型Type.寻仙任务;
			}
			else if (value == "300环连环")
			{
				result = AllEnums.日常类型Type.跑环任务;
			}
			else if (Singleton<ByteAPI>.I.寻找文本等(value, "兰若寺", "烈火涧", "桃花谷", "古树仙境"))
			{
				result = AllEnums.日常类型Type.副本挑战;
			}
			else if (Singleton<ByteAPI>.I.寻找文本等(value, "【昆仑神镜】伏羲创八卦", "【昆仑神镜】神农尝百草", "【昆仑神镜】燧人取圣火", "【昆仑神镜】女娲补苍天"))
			{
				result = AllEnums.日常类型Type.昆仑神镜;
			}
			Singleton<XhaJ3cfswGhhnmIequv>.I.TR2fluO5Bi(P_0, result, value, text2);
		}
		if (FcVoHRwOVsflDmDUQOP.JhVwZ5yCsf() && value == "捕捉精怪" && Singleton<ByteAPI>.I.寻找文本与(text2, "精怪消息已打听到了", "温馨提醒：#n捕捉精怪时"))
		{
			P_0.召唤精怪事件?.Invoke(string.Empty);
		}
		if (sUhuV4s664O5VhBMqaF.boisLCl3wO(value, text, P_0.user.属性数据.等级))
		{
			return null;
		}
		if (value == "五雷令" && Singleton<ByteAPI>.I.寻找文本(text2, "五雷令当前耐久度剩余"))
		{
			short.TryParse(Singleton<ByteAPI>.I.取文本中间(text2, "五雷令当前耐久度剩余#R", "#n点"), out P_0.user.属性数据.五雷令点);
		}
		if (value == "自动摆摊" && Singleton<全局变量类>.I.在线泡点配置.泡点开关 && Singleton<全局变量类>.I.在线泡点配置.双倍开关)
		{
			text = (string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.在线泡点配置.泡点道具) ? (text + "#r在本服#Y一线天上集市摆摊#n的道友获得#Y双倍泡点奖励#n的福利#n") : (text + "#r使用了#Y" + Singleton<全局变量类>.I.在线泡点配置.泡点道具 + "#n的道友可享受在本服#Y一线天上集市摆摊#n获得#Y双倍泡点奖励#n的福利#n"));
			bool flag = text2.IndexOf("你现在正在") != -1 && text2.IndexOf("一线") != -1 && text2.IndexOf("进行自动摆摊") != -1;
			if ((P_0.user.存档数据.is使用新手大礼包 || string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.在线泡点配置.泡点道具)) && flag)
			{
				P_0.user.存档数据.is摆摊中 = true;
			}
			else
			{
				P_0.user.存档数据.is摆摊中 = false;
			}
			if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.在线泡点配置.泡点道具))
			{
				string text3 = text2;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#r#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点道具);
				defaultInterpolatedStringHandler.AppendLiteral("：");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.is使用新手大礼包 ? "条件已达成" : "条件未达成");
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				text2 = text3 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			text2 = text2 + "#r#Y在一线摆摊：" + (flag ? "条件已达成" : "条件未达成") + "#n";
			text2 = text2 + "#r（" + (P_0.user.存档数据.is摆摊中 ? "#Y恭喜你，当前正在享受摆摊双倍泡点福利#n" : "#R很遗憾，当前未能享受摆摊双倍泡点福利#n") + "）";
		}
		封包_写2.写文本型(text, hasCount: true, 1, reverse: true);
		if (!(value == "仙人指路"))
		{
			if (!(value == "修行任务"))
			{
				if (!(value == "十绝阵"))
				{
					if (!(value == "天罡十绝阵"))
					{
						if (!(value == "伏魔任务"))
						{
							if (value == "仙界通缉")
							{
								P_0.user.人物数据.仙界通缉任务数据 = text2;
							}
						}
						else
						{
							P_0.user.人物数据.伏魔任务数据 = text2;
						}
					}
					else
					{
						P_0.user.人物数据.天罡十绝阵任务数据 = text2;
					}
				}
				else
				{
					P_0.user.人物数据.十绝阵任务数据 = text2;
				}
			}
			else
			{
				P_0.user.人物数据.修行任务数据 = text2;
			}
		}
		else
		{
			P_0.user.人物数据.仙人指路任务数据 = text2;
		}
		if (text2.Contains("似乎有宝藏出现", StringComparison.CurrentCulture) && P_0.user.缓存数据.is是否使用寻宝令)
		{
			string[] array = Singleton<ByteAPI>.I.取文本中间(text2, "在#Z", ")#Z似乎").Split("(");
			if (array.Length == 2 && Singleton<全局变量类>.I.所有地图字典.TryGetValue(array[0], out var value4))
			{
				string[] array2 = array[1].Split(",");
				if (array2.Length == 2)
				{
					Singleton<WdAPI>.I.如意寻宝令挖宝(P_0, value4, array2[0], array2[1]).Wait();
				}
			}
			P_0.user.缓存数据.is是否使用寻宝令 = false;
		}
		封包_写2.写文本型(text2, hasCount: true, 1, reverse: true);
		封包_写2.写字节集(封包_读2.剩余数据(), hasCount: false, 0);
		封包_写 obj = new 封包_写();
		obj.写入数据(全局变量类.HeadData, hasCount: false, 0);
		obj.写入数据(封包_写2.取数据(), hasCount: true, 1, reverse: true);
		return obj.取数据();
	}

	
	public sGGAjyixPch0Uk158L6()
	{
	}

	static sGGAjyixPch0Uk158L6()
	{
	}
}
