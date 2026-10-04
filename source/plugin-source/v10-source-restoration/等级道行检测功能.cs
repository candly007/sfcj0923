using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

public class 等级道行检测功能 : Singleton<等级道行检测功能>
{
	
	internal void CTOWAd4ZZ7()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("等级道行检测类.json")))
			{
				Singleton<全局变量类>.I.等级道行检测 = JsonConvert.DeserializeObject<等级道行检测类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("等级道行检测类.json")));
			}
			else
			{
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("等级道行检测类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.等级道行检测, Formatting.Indented));
			}
		}
		catch (Exception ex)
		{
			Log.Error("等级道行检测读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void UuYWzOeaZY()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("等级道行检测类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.等级道行检测, Formatting.Indented));
			Log.Debug("等级道行检测保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("等级道行检测保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string ybqguthC6f()
	{
		CTOWAd4ZZ7();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.等级道行检测, Formatting.Indented);
	}

	
	public void JsonTo配置(string value)
	{
		Singleton<全局变量类>.I.等级道行检测 = JsonConvert.DeserializeObject<等级道行检测类>(value);
		UuYWzOeaZY();
	}

	
	public void 发放离线泡点奖励(MyNATSocketClient myclient)
	{
		try
		{
			int num = (int)Singleton<ByteAPI>.I.取时间戳();
			if (string.IsNullOrWhiteSpace(myclient.user.存档数据.最后下线时间))
			{
				return;
			}
			int num2 = (int)Singleton<ByteAPI>.I.取时间戳(myclient.user.存档数据.最后下线时间);
			if (num2 <= 0 || num2 >= num)
			{
				return;
			}
			int num3 = (num - num2) / (Singleton<全局变量类>.I.在线泡点配置.泡点间隔分钟 * 60);
			if (num3 <= 0)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			if (num3 > 0 && Singleton<全局变量类>.I.在线泡点配置.离线奖励时间 > 0)
			{
				if (num3 > Singleton<全局变量类>.I.在线泡点配置.离线奖励时间 * 60)
				{
					num3 = Singleton<全局变量类>.I.在线泡点配置.离线奖励时间 * 60;
				}
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(57, 3, stringBuilder2);
				handler.AppendLiteral("由于你#R");
				handler.AppendFormatted(myclient.user.存档数据.最后下线时间);
				handler.AppendLiteral("#n下线时有自动摆摊摊位，并且距离本次上线的时间超过了#Y");
				handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点间隔分钟);
				handler.AppendLiteral("#n分钟，获得泡点系统离线#Y");
				handler.AppendFormatted(num3);
				handler.AppendLiteral("#n分钟奖励的：");
				stringBuilder3.Append(ref handler);
				if ((Singleton<全局变量类>.I.在线泡点配置.泡点奖励金元宝 != 0 || Singleton<全局变量类>.I.在线泡点配置.泡点奖励银元宝 != 0) && DB.I.cAJNoOkab6(myclient, Singleton<全局变量类>.I.在线泡点配置.泡点奖励金元宝 * num3, Singleton<全局变量类>.I.在线泡点配置.泡点奖励银元宝 * num3))
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(20, 2, stringBuilder2);
					handler.AppendLiteral("#Y金元宝*");
					handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励金元宝 * num3);
					handler.AppendLiteral("#n  #Y银元宝*");
					handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励银元宝 * num3);
					handler.AppendLiteral("#n  ");
					stringBuilder4.Append(ref handler);
				}
				if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具) && Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量 > 0 && Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具, AllEnums.指令Type.无, Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量 * num3, false, "泡点奖励"))
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(5, 2, stringBuilder2);
					handler.AppendLiteral("#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具);
					handler.AppendLiteral("*");
					handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量 * num3);
					handler.AppendLiteral("#n");
					stringBuilder5.Append(ref handler);
				}
				if (Singleton<全局变量类>.I.在线泡点配置.泡点奖励灵气值 > 0 && Singleton<WdAPI>.I.PndoGw5lW7(myclient, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, Singleton<全局变量类>.I.在线泡点配置.泡点奖励灵气值 * num3, false, "泡点奖励"))
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
					handler.AppendLiteral("#Y灵气值*");
					handler.AppendFormatted(Singleton<全局变量类>.I.在线泡点配置.泡点奖励灵气值 * num3);
					handler.AppendLiteral("#n");
					stringBuilder6.Append(ref handler);
				}
				myclient.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(stringBuilder.ToString()));
			}
			myclient.user.存档数据.最后下线时间 = string.Empty;
		}
		catch (Exception ex)
		{
			Log.Error("发放离线泡点奖励失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public 等级道行检测功能()
	{
	}

	static 等级道行检测功能()
	{
	}
}
