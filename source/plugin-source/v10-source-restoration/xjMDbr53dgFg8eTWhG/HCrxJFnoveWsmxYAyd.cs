using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace xjMDbr53dgFg8eTWhG;

internal class HCrxJFnoveWsmxYAyd : Singleton<HCrxJFnoveWsmxYAyd>
{
	
	public async void ow5MV1MwL(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_0.user.存档数据.乾坤袋列表.Count <= 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("乾坤袋中并无可领取的物品！"));
			}
			else if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("背包剩余格子数量不足，请先整理背包！"));
			}
			else if (P_0.user.缓存数据.is战斗中)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y温馨提示：战斗中无法领取乾坤袋中的物品哦。#n"));
			}
			else if (P_1 == "乾坤袋_领取物品")
			{
				int num = Singleton<WdAPI>.I.取背包剩余空格数(P_0);
				int count = P_0.user.存档数据.乾坤袋列表.Count;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(64, 2);
				defaultInterpolatedStringHandler.AppendLiteral("#R领取物品前请预留好背包空余位置，出现领取失败的情况后果自负(#M当前一键领取最多可从乾坤袋中领取#Y");
				defaultInterpolatedStringHandler.AppendFormatted((num > count) ? count : num);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted(count);
				defaultInterpolatedStringHandler.AppendLiteral("#M物品个)！#n#r");
				StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(46, 1, stringBuilder2);
				handler.AppendLiteral("#Y当前乾坤袋中存储了#M");
				handler.AppendFormatted(count);
				handler.AppendLiteral("#Y个道具，请点击一键领取，乾坤系统会根据你的背包空余格子智能领取");
				stringBuilder2.Append(ref handler);
				stringBuilder.Append("[【领取全部】一键领取全部道具/乾坤袋_领取物品一键领取]");
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, P_0.user.人物数据.形象ID, "乾坤之灵", stringBuilder.ToString()));
			}
			else
			{
				if (!(P_1 == "乾坤袋_领取物品一键领取") || P_0.user.存档数据.乾坤袋列表.Count <= 0)
				{
					return;
				}
				int 剩余格子 = Singleton<WdAPI>.I.取背包剩余空格数(P_0);
				if (剩余格子 < 1)
				{
					return;
				}
				while (剩余格子 > 0)
				{
					if (P_0.user.存档数据.乾坤袋列表.TryDequeue(out var result))
					{
						Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, result.道具名字, AllEnums.指令Type.无, result.道具数量, false, "乾坤袋_一键领取");
						WdAPI i = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你，成功从乾坤袋领取了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(result.道具名字);
						defaultInterpolatedStringHandler.AppendLiteral("×");
						defaultInterpolatedStringHandler.AppendFormatted(result.道具数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n");
						P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
					剩余格子--;
					if (剩余格子 <= 0 || P_0.user.存档数据.乾坤袋列表.Count <= 0)
					{
						break;
					}
					await Task.Delay(10);
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("乾坤袋对话处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public HCrxJFnoveWsmxYAyd()
	{
	}

	static HCrxJFnoveWsmxYAyd()
	{
	}
}
