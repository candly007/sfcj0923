using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace sVcPYnW2a67ob5mDj4x;

internal class TOqsYfW68LIGjCtAgK8 : Singleton<TOqsYfW68LIGjCtAgK8>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public MyNATSocketClient RSSncoCCPE;

		public bool llwnnSZwrg;

		public byte KwFn5oqyoh;

		public byte[] S48nMqEE9H;

		public bool LfbnhTkhuQ;

		public 属性数据 tACnvT11VM;

		public Predicate<特效列表类> Cspn7APSjL;

		
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		
		internal void jg4nLLU2Pc(string v)
		{
			_003C_003Ec__DisplayClass9_1 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass9_1();
			CS_0024_003C_003E8__locals4.NPHn919bsR = this;
			if (v != Singleton<全局变量类>.I.特效配置.鉴定特效道具)
			{
				return;
			}
			RSSncoCCPE.销毁回调事件 = null;
			if (llwnnSZwrg)
			{
				Singleton<WdAPI>.I.iaDIkvl1cj(RSSncoCCPE, KwFn5oqyoh);
				if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.特效配置.爆炸补偿道具) && Singleton<全局变量类>.I.特效配置.爆炸补偿道具数量 > 0)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(RSSncoCCPE, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.特效配置.爆炸补偿道具, AllEnums.指令Type.无, Singleton<全局变量类>.I.特效配置.爆炸补偿道具数量);
				}
				RSSncoCCPE.C_Send(S48nMqEE9H);
				return;
			}
			if (!LfbnhTkhuQ)
			{
				RSSncoCCPE.C_Send(S48nMqEE9H);
				return;
			}
			CS_0024_003C_003E8__locals4.T6cnTIVPlc = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
			List<特效列表类> list = Singleton<全局变量类>.I.特效配置.特效列表.FindAll( (特效列表类 x) => x.特效类型 != (AllEnums.特效类型Type)CS_0024_003C_003E8__locals4.NPHn919bsR.tACnvT11VM.属性标识 && x.是否启用 && x.加成数值 != 0 && CS_0024_003C_003E8__locals4.T6cnTIVPlc <= x.出现几率);
			if (list.Count <= 0)
			{
				list = Singleton<全局变量类>.I.特效配置.特效列表.FindAll( (特效列表类 x) => x.特效类型 != (AllEnums.特效类型Type)tACnvT11VM.属性标识 && x.是否启用 && x.加成数值 != 0);
			}
			特效列表类 特效列表类2 = list[Singleton<WdAPI>.I.qrjo9TWIdy(0, list.Count - 1)];
			byte[] first = S48nMqEE9H;
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
			defaultInterpolatedStringHandler.AppendLiteral("#41恭喜你，成功鉴定出了#L特效：");
			defaultInterpolatedStringHandler.AppendFormatted(特效列表类2.特效类型);
			defaultInterpolatedStringHandler.AppendLiteral("#n，可喜可贺！");
			S48nMqEE9H = first.Concat(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray();
			List<string[]> list2 = new List<string[]>();
			string[] array = new string[2];
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral("prop_rebuild/");
			defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)tACnvT11VM.属性标识);
			array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
			array[1] = "0";
			list2.Add(array);
			string[] array2 = new string[2];
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral("prop_rebuild/");
			defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)特效列表类2.特效类型);
			array2[0] = defaultInterpolatedStringHandler.ToStringAndClear();
			array2[1] = $"{特效列表类2.加成数值}";
			list2.Add(array2);
			List<string[]> list3 = list2;
			Singleton<WdAPI>.I.NNfIVUuyWv(RSSncoCCPE, KwFn5oqyoh, list3);
			RSSncoCCPE.C_Send(S48nMqEE9H);
			if (特效列表类2.鉴定成功出谣言)
			{
				Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
				if (client频道事件 != null)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
					defaultInterpolatedStringHandler.AppendLiteral("#83天呐，#Y");
					defaultInterpolatedStringHandler.AppendFormatted(RSSncoCCPE.user.人物数据.昵称);
					defaultInterpolatedStringHandler.AppendLiteral("#n的#Y");
					defaultInterpolatedStringHandler.AppendFormatted(RSSncoCCPE.user.背包数据.物品列表[KwFn5oqyoh].名字);
					defaultInterpolatedStringHandler.AppendLiteral("#n成功鉴定出了！#L特效：");
					defaultInterpolatedStringHandler.AppendFormatted(特效列表类2.特效类型);
					defaultInterpolatedStringHandler.AppendLiteral("#n，简直牛逼！");
					client频道事件(i2.组包聊天信息(defaultInterpolatedStringHandler.ToStringAndClear(), "管理员"));
				}
			}
		}

		
		internal bool RlDnSBklkB(特效列表类 x)
		{
			if (x.特效类型 != (AllEnums.特效类型Type)tACnvT11VM.属性标识 && x.是否启用)
			{
				return x.加成数值 != 0;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass9_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_1
	{
		public int T6cnTIVPlc;

		public _003C_003Ec__DisplayClass9_0 NPHn919bsR;

		
		public _003C_003Ec__DisplayClass9_1()
		{
		}

		
		internal bool gfjnaiw3QT(特效列表类 x)
		{
			if (x.特效类型 != (AllEnums.特效类型Type)NPHn919bsR.tACnvT11VM.属性标识 && x.是否启用 && x.加成数值 != 0)
			{
				return T6cnTIVPlc <= x.出现几率;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass9_1()
		{
		}
	}

	
	[SpecialName]
	public static bool AlyW5lfYvE()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is特效系统)
		{
			return Singleton<全局变量类>.I.特效配置.功能开关;
		}
		return false;
	}

	
	internal void FdWWmFkfsG()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("特效配置类.json")))
			{
				Singleton<全局变量类>.I.特效配置 = JsonConvert.DeserializeObject<特效配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("特效配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.特效配置 = new 特效配置类();
			Singleton<全局变量类>.I.特效配置.功能开关 = true;
			Singleton<全局变量类>.I.特效配置.绑定装备才可鉴定 = false;
			Singleton<全局变量类>.I.特效配置.鉴定特效道具 = "特效鉴定符";
			Singleton<全局变量类>.I.特效配置.鉴定花费道具数量 = 1;
			Singleton<全局变量类>.I.特效配置.鉴定成功几率 = 20;
			Singleton<全局变量类>.I.特效配置.失败装备爆炸几率 = 100;
			Singleton<全局变量类>.I.特效配置.爆炸补偿道具 = "一叶草";
			Singleton<全局变量类>.I.特效配置.爆炸补偿道具数量 = 1;
			Singleton<全局变量类>.I.特效配置.使用装备等级 = new int[2] { 0, 999 };
			Singleton<全局变量类>.I.特效配置.特效列表.Clear();
			foreach (AllEnums.特效类型Type value in Enum.GetValues(typeof(AllEnums.特效类型Type)))
			{
				Singleton<全局变量类>.I.特效配置.特效列表.Add(new 特效列表类
				{
					特效类型 = value,
					是否启用 = true,
					鉴定成功出谣言 = true,
					出现几率 = 0,
					对应属性名字 = $"{(AllEnums.属性名字Type)value}",
					加成数值 = 0
				});
			}
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("特效配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.特效配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("特效配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void acRWPUAU4Q()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("特效配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.特效配置, Formatting.Indented));
			Log.Debug("特效配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("特效配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string THDWXSOgh3()
	{
		FdWWmFkfsG();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.特效配置, Formatting.Indented);
	}

	
	public void KqeWFPPUh7(string P_0)
	{
		Singleton<全局变量类>.I.特效配置 = JsonConvert.DeserializeObject<特效配置类>(P_0);
		acRWPUAU4Q();
	}

	
	internal bool TJ8WLEtvx7(MyNATSocketClient P_0, byte P_1, byte P_2)
	{
		try
		{
			if (!ceVWSo8Q3s(P_0, P_1, P_2, out var 属性数据2))
			{
				return false;
			}
			P_0.C_Send(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_1].封包缓存, P_1).Concat(Singleton<WdAPI>.I.V8ToFdAZn7(P_0.user.背包数据.物品列表[P_2].封包缓存, P_2)).ToArray());
			KFFWcdAOcU(P_0, P_1, P_2, 属性数据2);
			return true;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Is符合鉴定特效使用-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return false;
		}
	}

	
	private bool ceVWSo8Q3s(MyNATSocketClient P_0, byte P_1, byte P_2, out 属性数据 P_3)
	{
		P_3 = default(属性数据);
		try
		{
			if (!AlyW5lfYvE())
			{
				return false;
			}
			if (Singleton<全局变量类>.I.特效配置.特效列表.Count <= 0)
			{
				return false;
			}
			if (!Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, P_1) || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, P_2))
			{
				return false;
			}
			if (P_0.user.背包数据.物品列表[P_1].物品ID == 0 || P_0.user.背包数据.物品列表[P_2].物品ID == 0)
			{
				return false;
			}
			if (P_0.user.背包数据.物品列表[P_2].物品类型 != 1 && P_0.user.背包数据.物品列表[P_2].物品类型 != 2 && P_0.user.背包数据.物品列表[P_2].物品类型 != 3 && P_0.user.背包数据.物品列表[P_2].物品类型 != 7 && P_0.user.背包数据.物品列表[P_2].物品类型 != 10)
			{
				return false;
			}
			if (Singleton<全局变量类>.I.特效配置.鉴定特效道具 != P_0.user.背包数据.物品列表[P_1].名字)
			{
				return false;
			}
			if (P_0.user.背包数据.物品列表[P_1].数量 < Singleton<全局变量类>.I.特效配置.鉴定花费道具数量)
			{
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("装备特效鉴定最低需要#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.特效配置.鉴定花费道具数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.特效配置.鉴定特效道具);
				defaultInterpolatedStringHandler.AppendLiteral("#n。");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return false;
			}
			if (P_0.user.背包数据.物品列表[P_2].等级 < Singleton<全局变量类>.I.特效配置.使用装备等级[0] || P_0.user.背包数据.物品列表[P_2].等级 > Singleton<全局变量类>.I.特效配置.使用装备等级[1])
			{
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
				defaultInterpolatedStringHandler.AppendLiteral("等级在#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.特效配置.使用装备等级[0]);
				defaultInterpolatedStringHandler.AppendLiteral(" - ");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.特效配置.使用装备等级[1]);
				defaultInterpolatedStringHandler.AppendLiteral("#n级之间的装备才可鉴定特效。");
				P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return false;
			}
			if (Singleton<全局变量类>.I.特效配置.绑定装备才可鉴定 && !P_0.user.背包数据.物品列表[P_2].是否绑定)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R绑定的装备才能进行特效鉴定。"));
				return false;
			}
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return false;
			}
			P_3 = P_0.user.背包数据.物品列表[P_2].装备属性列表.Find( (属性数据 x) => x.鉴定属性筛选());
			return true;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("检测鉴定条件成立-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return false;
		}
	}

	
	private void KFFWcdAOcU(MyNATSocketClient P_0, byte P_1, byte P_2, 属性数据 P_3)
	{
		try
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[@确定/特效鉴定_");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:");
			StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
			if (P_3.属性数值 == 0)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(74, 1, stringBuilder2);
				handler.AppendLiteral("你确定要对#R");
				handler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].名字);
				handler.AppendLiteral("#n进行特效鉴定吗？#R（点击确定会自动进行鉴定操作，直到满足以下条件后停止）#r#M1、鉴定成功，自动停止#r2、材料不足，自动停止");
				stringBuilder3.Append(ref handler);
			}
			else
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(83, 2, stringBuilder2);
				handler.AppendLiteral("你的#R");
				handler.AppendFormatted(P_0.user.背包数据.物品列表[P_2].名字);
				handler.AppendLiteral("#n已经带有#L");
				handler.AppendFormatted((AllEnums.特效类型Type)P_3.属性标识);
				handler.AppendLiteral("#n特效，确定要继续鉴定吗？#R（点击确定会自动进行鉴定操作，直到满足以下条件后停止）#r#Y1、鉴定成功，自动停止#r2、材料不足，自动停止");
				stringBuilder4.Append(ref handler);
			}
			if (Singleton<全局变量类>.I.特效配置.失败装备爆炸几率 > 0)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(16, 1, stringBuilder2);
				handler.AppendLiteral("#r3、鉴定失败，");
				handler.AppendFormatted((float)Singleton<全局变量类>.I.特效配置.失败装备爆炸几率 / 100f, "N2");
				handler.AppendLiteral("%几率装备炸掉");
				stringBuilder5.Append(ref handler);
				if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.特效配置.爆炸补偿道具) && Singleton<全局变量类>.I.特效配置.爆炸补偿道具数量 > 0)
				{
					WdAPI i = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
					defaultInterpolatedStringHandler.AppendLiteral("温馨提示：装备炸掉后系统会返还#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.特效配置.爆炸补偿道具);
					defaultInterpolatedStringHandler.AppendLiteral("*");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.特效配置.爆炸补偿道具数量);
					defaultInterpolatedStringHandler.AppendLiteral("#n作为补偿。");
					P_0.C_Send(i.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			}
			stringBuilder.Append("#n]");
			P_0.C_Send(Singleton<WdAPI>.I.组包确定框(P_0, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("装备鉴定确定弹窗-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal async Task KdnWnB845U(MyNATSocketClient P_0, string P_1, string P_2)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals63 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals63.RSSncoCCPE = P_0;
		try
		{
			if (string.IsNullOrWhiteSpace(P_1))
			{
				CS_0024_003C_003E8__locals63.RSSncoCCPE.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的物品数据有误，原因：1！"));
				return;
			}
			new StringBuilder();
			string[] array = P_1.Split("|");
			if (array.Length != 2)
			{
				CS_0024_003C_003E8__locals63.RSSncoCCPE.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的物品数据有误，原因：2！"));
				return;
			}
			if (!byte.TryParse(array[0], out var 格子1) || !byte.TryParse(array[1], out CS_0024_003C_003E8__locals63.KwFn5oqyoh))
			{
				CS_0024_003C_003E8__locals63.RSSncoCCPE.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的物品数据有误，原因：3！"));
				return;
			}
			if (!ceVWSo8Q3s(CS_0024_003C_003E8__locals63.RSSncoCCPE, 格子1, CS_0024_003C_003E8__locals63.KwFn5oqyoh, out CS_0024_003C_003E8__locals63.tACnvT11VM))
			{
				CS_0024_003C_003E8__locals63.RSSncoCCPE.C_Send(Singleton<WdAPI>.I.提示_中心提醒("提交的物品数据有误，无法精炼！"));
				return;
			}
			int num = CS_0024_003C_003E8__locals63.RSSncoCCPE.user.背包数据.物品列表[格子1].数量 / Singleton<全局变量类>.I.特效配置.鉴定花费道具数量;
			int 已用次数 = 0;
			CS_0024_003C_003E8__locals63.LfbnhTkhuQ = false;
			CS_0024_003C_003E8__locals63.llwnnSZwrg = false;
			CS_0024_003C_003E8__locals63.S48nMqEE9H = Array.Empty<byte>();
			for (int i = 0; i < num; i++)
			{
				已用次数++;
				CS_0024_003C_003E8__locals63.RSSncoCCPE.user.存档数据.精炼存档.已鉴定次数++;
				CS_0024_003C_003E8__locals63.RSSncoCCPE.user.存档数据.精炼存档.总鉴定次数++;
				int successRoll = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
				CS_0024_003C_003E8__locals63.LfbnhTkhuQ = EffectIdentificationProbability.IsSuccess(Singleton<全局变量类>.I.特效配置.鉴定成功几率, successRoll);
				byte[] first = CS_0024_003C_003E8__locals63.S48nMqEE9H;
				WdAPI i2 = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
				defaultInterpolatedStringHandler.AppendLiteral("你使用了#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.特效配置.鉴定花费道具数量);
				defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.特效配置.鉴定特效道具);
				defaultInterpolatedStringHandler.AppendLiteral("#n对#R");
				defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals63.RSSncoCCPE.user.背包数据.物品列表[CS_0024_003C_003E8__locals63.KwFn5oqyoh].名字);
				defaultInterpolatedStringHandler.AppendLiteral("#n进行了一次特效鉴定。");
				CS_0024_003C_003E8__locals63.S48nMqEE9H = first.Concat(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray();
				if (CS_0024_003C_003E8__locals63.LfbnhTkhuQ)
				{
					CS_0024_003C_003E8__locals63.RSSncoCCPE.user.存档数据.精炼存档.已鉴定次数 = 0;
					CS_0024_003C_003E8__locals63.S48nMqEE9H = CS_0024_003C_003E8__locals63.S48nMqEE9H.Concat(Singleton<WdAPI>.I.提示_中心提醒("#44#G鉴定成功！")).ToArray();
					break;
				}
				int num4 = Singleton<WdAPI>.I.qrjo9TWIdy(1, 10000);
				CS_0024_003C_003E8__locals63.llwnnSZwrg = CS_0024_003C_003E8__locals63.RSSncoCCPE.user.存档数据.精炼存档.总鉴定次数 > 1000 && num4 <= Singleton<全局变量类>.I.特效配置.失败装备爆炸几率;
				if (CS_0024_003C_003E8__locals63.llwnnSZwrg)
				{
					CS_0024_003C_003E8__locals63.RSSncoCCPE.user.存档数据.精炼存档.总鉴定次数 = 0;
					CS_0024_003C_003E8__locals63.S48nMqEE9H = CS_0024_003C_003E8__locals63.S48nMqEE9H.Concat(Singleton<WdAPI>.I.提示_中心提醒("#45#R糟糕，鉴定失败装备炸掉了！")).ToArray();
					if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.特效配置.爆炸补偿道具) && Singleton<全局变量类>.I.特效配置.爆炸补偿道具数量 > 0)
					{
						byte[] first2 = CS_0024_003C_003E8__locals63.S48nMqEE9H;
						WdAPI i3 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
						defaultInterpolatedStringHandler.AppendLiteral("#30你获得了系统返还的#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.特效配置.爆炸补偿道具数量);
						defaultInterpolatedStringHandler.AppendLiteral("#n个#R");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.特效配置.爆炸补偿道具);
						defaultInterpolatedStringHandler.AppendLiteral("#n作为补偿。");
						CS_0024_003C_003E8__locals63.S48nMqEE9H = first2.Concat(i3.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear())).ToArray();
					}
					break;
				}
			}
			CS_0024_003C_003E8__locals63.RSSncoCCPE.销毁回调事件 =  (string v) =>
			{
				_003C_003Ec__DisplayClass9_1 CS_0024_003C_003E8__locals62 = new _003C_003Ec__DisplayClass9_1();
				CS_0024_003C_003E8__locals62.NPHn919bsR = CS_0024_003C_003E8__locals63;
				if (!(v != Singleton<全局变量类>.I.特效配置.鉴定特效道具))
				{
					CS_0024_003C_003E8__locals63.RSSncoCCPE.销毁回调事件 = null;
					if (CS_0024_003C_003E8__locals63.llwnnSZwrg)
					{
						Singleton<WdAPI>.I.iaDIkvl1cj(CS_0024_003C_003E8__locals63.RSSncoCCPE, CS_0024_003C_003E8__locals63.KwFn5oqyoh);
						if (!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.特效配置.爆炸补偿道具) && Singleton<全局变量类>.I.特效配置.爆炸补偿道具数量 > 0)
						{
							Singleton<WdAPI>.I.PndoGw5lW7(CS_0024_003C_003E8__locals63.RSSncoCCPE, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.特效配置.爆炸补偿道具, AllEnums.指令Type.无, Singleton<全局变量类>.I.特效配置.爆炸补偿道具数量);
						}
						CS_0024_003C_003E8__locals63.RSSncoCCPE.C_Send(CS_0024_003C_003E8__locals63.S48nMqEE9H);
					}
					else if (!CS_0024_003C_003E8__locals63.LfbnhTkhuQ)
					{
						CS_0024_003C_003E8__locals63.RSSncoCCPE.C_Send(CS_0024_003C_003E8__locals63.S48nMqEE9H);
					}
					else
					{
						CS_0024_003C_003E8__locals62.T6cnTIVPlc = Singleton<WdAPI>.I.qrjo9TWIdy(1, 100);
						List<特效列表类> list = Singleton<全局变量类>.I.特效配置.特效列表.FindAll( (特效列表类 x) => x.特效类型 != (AllEnums.特效类型Type)CS_0024_003C_003E8__locals62.NPHn919bsR.tACnvT11VM.属性标识 && x.是否启用 && x.加成数值 != 0 && CS_0024_003C_003E8__locals62.T6cnTIVPlc <= x.出现几率);
						if (list.Count <= 0)
						{
							list = Singleton<全局变量类>.I.特效配置.特效列表.FindAll( (特效列表类 x) => x.特效类型 != (AllEnums.特效类型Type)CS_0024_003C_003E8__locals63.tACnvT11VM.属性标识 && x.是否启用 && x.加成数值 != 0);
						}
						特效列表类 特效列表类2 = list[Singleton<WdAPI>.I.qrjo9TWIdy(0, list.Count - 1)];
						byte[] first3 = CS_0024_003C_003E8__locals63.S48nMqEE9H;
						WdAPI i4 = Singleton<WdAPI>.I;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(26, 1);
						defaultInterpolatedStringHandler2.AppendLiteral("#41恭喜你，成功鉴定出了#L特效：");
						defaultInterpolatedStringHandler2.AppendFormatted(特效列表类2.特效类型);
						defaultInterpolatedStringHandler2.AppendLiteral("#n，可喜可贺！");
						CS_0024_003C_003E8__locals63.S48nMqEE9H = first3.Concat(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler2.ToStringAndClear())).ToArray();
						List<string[]> list2 = new List<string[]>();
						string[] array2 = new string[2];
						defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(13, 1);
						defaultInterpolatedStringHandler2.AppendLiteral("prop_rebuild/");
						defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性标识Type)CS_0024_003C_003E8__locals63.tACnvT11VM.属性标识);
						array2[0] = defaultInterpolatedStringHandler2.ToStringAndClear();
						array2[1] = "0";
						list2.Add(array2);
						string[] array3 = new string[2];
						defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(13, 1);
						defaultInterpolatedStringHandler2.AppendLiteral("prop_rebuild/");
						defaultInterpolatedStringHandler2.AppendFormatted((AllEnums.属性标识Type)特效列表类2.特效类型);
						array3[0] = defaultInterpolatedStringHandler2.ToStringAndClear();
						array3[1] = $"{特效列表类2.加成数值}";
						list2.Add(array3);
						List<string[]> list3 = list2;
						Singleton<WdAPI>.I.NNfIVUuyWv(CS_0024_003C_003E8__locals63.RSSncoCCPE, CS_0024_003C_003E8__locals63.KwFn5oqyoh, list3);
						CS_0024_003C_003E8__locals63.RSSncoCCPE.C_Send(CS_0024_003C_003E8__locals63.S48nMqEE9H);
						if (特效列表类2.鉴定成功出谣言)
						{
							Action<byte[]> client频道事件 = Singleton<全局变量类>.I.Client频道事件;
							if (client频道事件 != null)
							{
								WdAPI i5 = Singleton<WdAPI>.I;
								defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(35, 3);
								defaultInterpolatedStringHandler2.AppendLiteral("#83天呐，#Y");
								defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals63.RSSncoCCPE.user.人物数据.昵称);
								defaultInterpolatedStringHandler2.AppendLiteral("#n的#Y");
								defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals63.RSSncoCCPE.user.背包数据.物品列表[CS_0024_003C_003E8__locals63.KwFn5oqyoh].名字);
								defaultInterpolatedStringHandler2.AppendLiteral("#n成功鉴定出了！#L特效：");
								defaultInterpolatedStringHandler2.AppendFormatted(特效列表类2.特效类型);
								defaultInterpolatedStringHandler2.AppendLiteral("#n，简直牛逼！");
								client频道事件(i5.组包聊天信息(defaultInterpolatedStringHandler2.ToStringAndClear(), "管理员"));
							}
						}
					}
				}
			};
			CS_0024_003C_003E8__locals63.RSSncoCCPE.C_Send(Singleton<WdAPI>.I.QewoEwLLTD("特效鉴定中", 1));
			await Task.Delay(1000);
			CS_0024_003C_003E8__locals63.RSSncoCCPE.S_Send(Singleton<WdAPI>.I.rxTojoeFsR(格子1, 已用次数 * Singleton<全局变量类>.I.特效配置.鉴定花费道具数量));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("特效鉴定选项处理-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public TOqsYfW68LIGjCtAgK8()
	{
	}

	static TOqsYfW68LIGjCtAgK8()
	{
	}
}
