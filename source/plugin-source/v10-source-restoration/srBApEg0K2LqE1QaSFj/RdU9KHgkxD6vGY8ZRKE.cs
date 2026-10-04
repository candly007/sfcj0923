using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace srBApEg0K2LqE1QaSFj;

internal class RdU9KHgkxD6vGY8ZRKE : Singleton<RdU9KHgkxD6vGY8ZRKE>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public MyNATSocketClient GtU5ueW44v;

		public int wOw5wfZ1h0;

		
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		
		internal async void NhNnz86NHm(string v)
		{
			if (!(v != "超级天星石"))
			{
				GtU5ueW44v.销毁回调事件 = null;
				int gID = GtU5ueW44v.user.人物数据.GID;
				string 名字 = GtU5ueW44v.user.背包数据.物品列表[wOw5wfZ1h0].名字;
				int 形象ID = GtU5ueW44v.user.人物数据.形象ID;
				string 账号 = GtU5ueW44v.user.人物数据.账号;
				GtU5ueW44v.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你使用了#R超级天星石#n为#R" + 名字 + "#n突破了进化限制。为了保证数据安全，游戏将掉线10秒后才可恢复。"));
				if (!DB.I.锁定账号操作(账号, "1"))
				{
					Log.Error("天星石事件处理-错误：账号锁定失败");
					return;
				}
				Singleton<WdAPI>.I.WT9IHmFS6c(GtU5ueW44v, GtU5ueW44v.user.人物数据.昵称);
				await Task.Delay(5000);
				DB i = DB.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendFormatted(wOw5wfZ1h0);
				defaultInterpolatedStringHandler.AppendLiteral(":\"");
				defaultInterpolatedStringHandler.AppendFormatted(名字);
				i.JfDNL1qVLO(gID, 账号, defaultInterpolatedStringHandler.ToStringAndClear(), 形象ID);
			}
		}

		static _003C_003Ec__DisplayClass6_0()
		{
		}
	}

	
	internal void X33gO976tP()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("自选道具配置类.json")))
			{
				Singleton<全局变量类>.I.自选道具配置 = JsonConvert.DeserializeObject<自选道具配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("自选道具配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.自选道具配置 = new 自选道具配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("自选道具配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.自选道具配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("自选道具配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void G5wgQdkerd()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("自选道具配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.自选道具配置, Formatting.Indented));
			Log.Debug("自选道具配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("自选道具配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string yMmgE4jXIY()
	{
		X33gO976tP();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.自选道具配置, Formatting.Indented);
	}

	
	public void DHsg34Ihvx(string P_0)
	{
		Singleton<全局变量类>.I.自选道具配置 = JsonConvert.DeserializeObject<自选道具配置类>(P_0);
		G5wgQdkerd();
	}

	
	internal void CGqgYXA10I(MyNATSocketClient P_0, 自选道具列表类 P_1)
	{
		P_0.user.缓存数据.自选道具 = P_1.道具名字;
		P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(P_0.user.人物数据.角色ID, P_0.user.人物数据.形象ID, P_0.user.人物数据.昵称, "请选择你需要的物品：#n#r#M注意：如果暂时不想选择自选物品，请右键取消对话框系统自动返还已使用的自选道具#n" + P_1.选项配置));
	}

	
	internal void pPrgpZASFj(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			lock (P_0.自选请求锁)
			{
				if (Singleton<全局变量类>.I.自选道具配置.自选道具列表.TryGetValue(P_0.user.缓存数据.自选道具, out 自选道具列表类 value) && value.选项配置.Contains("/" + P_1 + "]", StringComparison.CurrentCulture))
				{
					string text = P_1.Replace("确定自选_", "");
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, text, AllEnums.指令Type.无, 1, false, "自选礼包");
				}
				P_0.user.缓存数据.自选道具 = string.Empty;
			}
		}
		catch (Exception ex)
		{
			Log.Error("自选确定选项处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void nK0g1fBaXx(MyNATSocketClient P_0, string P_1)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals20 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals20.GtU5ueW44v = P_0;
		try
		{
			string[] array = P_1.Replace("使用超级天星石_", "").Split("|");
			if (!int.TryParse(array[0], out var result) || !int.TryParse(array[1], out CS_0024_003C_003E8__locals20.wOw5wfZ1h0) || string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals20.GtU5ueW44v.user.背包数据.物品列表[result].名字) || string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals20.GtU5ueW44v.user.背包数据.物品列表[CS_0024_003C_003E8__locals20.wOw5wfZ1h0].名字) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals20.GtU5ueW44v, result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(CS_0024_003C_003E8__locals20.GtU5ueW44v, CS_0024_003C_003E8__locals20.wOw5wfZ1h0))
			{
				return;
			}
			CS_0024_003C_003E8__locals20.GtU5ueW44v.销毁回调事件 =  async (string v) =>
			{
				if (!(v != "超级天星石"))
				{
					CS_0024_003C_003E8__locals20.GtU5ueW44v.销毁回调事件 = null;
					int gID = CS_0024_003C_003E8__locals20.GtU5ueW44v.user.人物数据.GID;
					string 名字 = CS_0024_003C_003E8__locals20.GtU5ueW44v.user.背包数据.物品列表[CS_0024_003C_003E8__locals20.wOw5wfZ1h0].名字;
					int 形象ID = CS_0024_003C_003E8__locals20.GtU5ueW44v.user.人物数据.形象ID;
					string 账号 = CS_0024_003C_003E8__locals20.GtU5ueW44v.user.人物数据.账号;
					CS_0024_003C_003E8__locals20.GtU5ueW44v.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你使用了#R超级天星石#n为#R" + 名字 + "#n突破了进化限制。为了保证数据安全，游戏将掉线10秒后才可恢复。"));
					if (!DB.I.锁定账号操作(账号, "1"))
					{
						Log.Error("天星石事件处理-错误：账号锁定失败");
					}
					else
					{
						Singleton<WdAPI>.I.WT9IHmFS6c(CS_0024_003C_003E8__locals20.GtU5ueW44v, CS_0024_003C_003E8__locals20.GtU5ueW44v.user.人物数据.昵称);
						await Task.Delay(5000);
						DB i = DB.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
						defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals20.wOw5wfZ1h0);
						defaultInterpolatedStringHandler.AppendLiteral(":\"");
						defaultInterpolatedStringHandler.AppendFormatted(名字);
						i.JfDNL1qVLO(gID, 账号, defaultInterpolatedStringHandler.ToStringAndClear(), 形象ID);
					}
				}
			};
			CS_0024_003C_003E8__locals20.GtU5ueW44v.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(result, 1));
		}
		catch (Exception ex)
		{
			Log.Error("请求_天星石事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public RdU9KHgkxD6vGY8ZRKE()
	{
	}

	static RdU9KHgkxD6vGY8ZRKE()
	{
	}
}
