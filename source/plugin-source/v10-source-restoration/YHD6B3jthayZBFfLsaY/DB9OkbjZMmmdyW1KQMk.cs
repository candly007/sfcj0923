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

namespace YHD6B3jthayZBFfLsaY;

internal class DB9OkbjZMmmdyW1KQMk : Singleton<DB9OkbjZMmmdyW1KQMk>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public string RmHMTtMGTo;

		public int S1sM9LEyDs;

		
		public _003C_003Ec__DisplayClass18_0()
		{
		}

		
		internal bool J7FMad4BBd(技能详细数据类 x)
		{
			if (x.技能门派.ToString() == RmHMTtMGTo)
			{
				if (x.技能类型 != 0)
				{
					return x.技能类型 == S1sM9LEyDs;
				}
				return true;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass18_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_1
	{
		public KeyValuePair<string, short> eX4MVjL2G7;

		
		public _003C_003Ec__DisplayClass18_1()
		{
		}

		
		internal bool DQZMyHY4r6(技能详细数据类 x)
		{
			return x.技能名字 == eX4MVjL2G7.Key;
		}

		
		internal bool qZxMC0bBWI(技能详细数据类 x)
		{
			return x.技能名字 == eX4MVjL2G7.Key;
		}

		static _003C_003Ec__DisplayClass18_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_2
	{
		public 技能详细数据类 NPFM01slht;

		
		public _003C_003Ec__DisplayClass18_2()
		{
		}

		
		internal bool M4cMkJJsys(技能详细数据类 x)
		{
			if (x.技能名字 != NPFM01slht.技能名字)
			{
				return x.技能品阶 == NPFM01slht.技能品阶;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass18_2()
		{
		}
	}

	
	internal void N6ejApwwb8()
	{
		GhjlufS2TJ();
		eRMlKuWDrV();
		yuElUNwJJW();
	}

	
	internal void TlJjzcbEKx()
	{
		L6OlwsTXdE();
		ec3lRClLGI();
		iXtlWSV3Sw();
	}

	
	internal void GhjlufS2TJ()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("门派转换配置类.json")))
			{
				Singleton<全局变量类>.I.门派转换配置 = JsonConvert.DeserializeObject<门派转换配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("门派转换配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.门派转换配置 = new 门派转换配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("门派转换配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.门派转换配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("门派转换配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void L6OlwsTXdE()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("门派转换配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.门派转换配置, Formatting.Indented));
			Log.Debug("门派转换配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("门派转换配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string EdKlb3p3jo()
	{
		GhjlufS2TJ();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.门派转换配置, Formatting.Indented);
	}

	
	public void qr2lJfZFlI(string P_0)
	{
		Singleton<全局变量类>.I.门派转换配置 = JsonConvert.DeserializeObject<门派转换配置类>(P_0);
		L6OlwsTXdE();
	}

	
	internal void eRMlKuWDrV()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("一键大飞配置类.json")))
			{
				Singleton<全局变量类>.I.一键大飞配置 = JsonConvert.DeserializeObject<一键大飞配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("一键大飞配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.一键大飞配置 = new 一键大飞配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("一键大飞配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.一键大飞配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("一键大飞配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void ec3lRClLGI()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("一键大飞配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.一键大飞配置, Formatting.Indented));
			Log.Debug("一键大飞配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("一键大飞配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string FBaldgRFjW()
	{
		eRMlKuWDrV();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.一键大飞配置, Formatting.Indented);
	}

	
	public void w2ClsnjIRg(string P_0)
	{
		Singleton<全局变量类>.I.一键大飞配置 = JsonConvert.DeserializeObject<一键大飞配置类>(P_0);
		ec3lRClLGI();
	}

	
	internal void yuElUNwJJW()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("法宝共生配置类.json")))
			{
				Singleton<全局变量类>.I.法宝共生配置 = JsonConvert.DeserializeObject<法宝共生配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("法宝共生配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.法宝共生配置 = new 法宝共生配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("法宝共生配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.法宝共生配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("法宝共生配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void iXtlWSV3Sw()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("法宝共生配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.法宝共生配置, Formatting.Indented));
			Log.Debug("法宝共生配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("法宝共生配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string k42lgB0Cf0()
	{
		yuElUNwJJW();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.法宝共生配置, Formatting.Indented);
	}

	
	public void JrdlDBQ9iD(string P_0)
	{
		Singleton<全局变量类>.I.法宝共生配置 = JsonConvert.DeserializeObject<法宝共生配置类>(P_0);
		iXtlWSV3Sw();
	}

	
	internal void BZvlj8oDVj(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_0.user.属性数据.等级 < Singleton<全局变量类>.I.一键大飞配置.飞升要求最低等级 || P_0.user.属性数据.等级 >= Singleton<全局变量类>.I.一键大飞配置.飞升到等级)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前的等级不符合飞升要求！"));
			}
			else if (P_1 == "大飞操作_仙" || P_1 == "大飞操作_魔")
			{
				WdAPI i = Singleton<WdAPI>.I;
				int 角色ID = P_0.user.人物数据.角色ID;
				int 形象ID = P_0.user.人物数据.形象ID;
				string npc名字 = Singleton<全局变量类>.I.一键大飞配置.npc名字;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(68, 5);
				defaultInterpolatedStringHandler.AppendLiteral("[@确定/");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("_确定#DLG:1#prompt:#Y飞升价格：");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.一键大飞配置.消耗数值);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.一键大飞配置.消耗数值类型);
				defaultInterpolatedStringHandler.AppendLiteral("#n#r#Y飞升等级：");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.一键大飞配置.飞升到等级);
				defaultInterpolatedStringHandler.AppendLiteral("#n#r#Y飞升仙魔：");
				defaultInterpolatedStringHandler.AppendFormatted(P_1.Replace("大飞操作_", ""));
				defaultInterpolatedStringHandler.AppendLiteral("#n#r你确定要进行飞升操作吗？]");
				P_0.C_Send(i.组包确定框(角色ID, 形象ID, npc名字, defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else if (P_1 == "大飞操作_仙_确定" || P_1 == "大飞操作_魔_确定")
			{
				DB.I.L3cNvWKwjx(P_0, P_1 == "大飞操作_仙_确定");
			}
		}
		catch (Exception ex)
		{
			Log.Error("一键大飞事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void ncbllV8KTo(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_1 == "共生操作_选中")
			{
				WdAPI i = Singleton<WdAPI>.I;
				int 角色ID = P_0.user.人物数据.角色ID;
				int 形象ID = P_0.user.人物数据.形象ID;
				string npc名字 = Singleton<全局变量类>.I.一键大飞配置.npc名字;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[@确定/共生操作_确定#DLG:1#prompt:你确定花费#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.法宝共生配置.消耗数值);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.法宝共生配置.消耗数值类型);
				defaultInterpolatedStringHandler.AppendLiteral("开通法宝共生技能吗？]");
				P_0.C_Send(i.组包确定框(角色ID, 形象ID, npc名字, defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else
			{
				if (!(P_1 == "共生操作_确定"))
				{
					return;
				}
				if (Singleton<全局变量类>.I.法宝共生配置.消耗数值类型 == AllEnums.数值Type.金元宝)
				{
					if (P_0.user.背包数据.金元宝 < Singleton<全局变量类>.I.法宝共生配置.消耗数值)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y金元宝#n不足，无法开通法宝共生技能！"));
						return;
					}
					if (!DB.I.cAJNoOkab6(P_0, -Singleton<全局变量类>.I.法宝共生配置.消耗数值, 0))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y金元宝#n扣除失败，无法开通法宝共生技能！"));
						return;
					}
				}
				else if (Singleton<全局变量类>.I.法宝共生配置.消耗数值类型 == AllEnums.数值Type.银元宝)
				{
					if (P_0.user.背包数据.银元宝 < Singleton<全局变量类>.I.法宝共生配置.消耗数值)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y银元宝#n不足，无法开通法宝共生技能！"));
						return;
					}
					if (!DB.I.cAJNoOkab6(P_0, 0, -Singleton<全局变量类>.I.法宝共生配置.消耗数值))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y银元宝#n扣除失败，无法开通法宝共生技能！"));
						return;
					}
				}
				DB.I.lcMN7neI7I(P_0).Wait();
			}
		}
		catch (Exception ex)
		{
			Log.Error("法宝共生事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void Abnl8QO9nH(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_1 == "元神合体_选中")
			{
				WdAPI i = Singleton<WdAPI>.I;
				int 角色ID = P_0.user.人物数据.角色ID;
				int 形象ID = P_0.user.人物数据.形象ID;
				string npc名字 = Singleton<全局变量类>.I.一键大飞配置.npc名字;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[@确定/元神合体_确定#DLG:1#prompt:你确定花费#Y");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值);
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值类型);
				defaultInterpolatedStringHandler.AppendLiteral("学习元神合体之术吗？]");
				P_0.C_Send(i.组包确定框(角色ID, 形象ID, npc名字, defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else
			{
				if (!(P_1 == "元神合体_确定"))
				{
					return;
				}
				if (P_0.user.属性数据.等级 < Singleton<全局变量类>.I.法宝共生配置.最低等级)
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的等级不足#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.法宝共生配置.最低等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法学习元神合体之术！");
					P_0.C_Send(i2.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (P_0.user.属性数据.等级 > Singleton<全局变量类>.I.法宝共生配置.最高等级)
				{
					WdAPI i3 = Singleton<WdAPI>.I;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
					defaultInterpolatedStringHandler.AppendLiteral("你的等级超过了#R");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.法宝共生配置.最高等级);
					defaultInterpolatedStringHandler.AppendLiteral("#n级，无法学习元神合体之术！");
					P_0.C_Send(i3.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				if (P_0.user.存档数据.Is元神合体)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你已经学习了元神合体之术，无法重复学习！"));
					return;
				}
				P_0.user.存档数据.Is元神合体 = DB.I.sAYNamlSOP(P_0);
				if (P_0.user.存档数据.Is元神合体)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你已经学习了元神合体之术，无法重复学习！"));
					return;
				}
				if (Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值类型 == AllEnums.数值Type.金元宝)
				{
					if (P_0.user.背包数据.金元宝 < Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y金元宝#n不足，无法学习元神合体之术！"));
						return;
					}
					if (!DB.I.cAJNoOkab6(P_0, -Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值, 0))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y金元宝#n扣除失败，无法学习元神合体之术！"));
						return;
					}
				}
				else if (Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值类型 == AllEnums.数值Type.银元宝)
				{
					if (P_0.user.背包数据.银元宝 < Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y银元宝#n不足，无法学习元神合体之术！"));
						return;
					}
					if (!DB.I.cAJNoOkab6(P_0, 0, -Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值))
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y银元宝#n扣除失败，无法学习元神合体之术！"));
						return;
					}
				}
				else if (Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值类型 == AllEnums.数值Type.金钱)
				{
					if (P_0.user.背包数据.金钱 < Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值)
					{
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y金钱#n不足，无法学习元神合体之术！"));
						return;
					}
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.cash, -Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值, false, "[双属性]消耗");
				}
				DB.I.w0pNTI2rmG(P_0).Wait();
			}
		}
		catch (Exception ex)
		{
			Log.Error("角色开通元神合体操作事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void jNflIqBHyk(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (!Singleton<全局变量类>.I.门派转换配置.功能开关)
			{
				return;
			}
			if (P_0.user.属性数据.等级 < 80)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("低于80级无法进行转换"));
			}
			else if (string.IsNullOrWhiteSpace(P_0.user.人物数据.门派))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前并未师门，请先拜入师门再来吧。"));
			}
			else if (P_1 == "门派转换操作_门派转换")
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
				defaultInterpolatedStringHandler.AppendLiteral("转换门派需消耗：#R");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.转换消耗);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.消耗类型);
				defaultInterpolatedStringHandler.AppendLiteral("，请选择要转换的门派：");
				StringBuilder stringBuilder = new StringBuilder(defaultInterpolatedStringHandler.ToStringAndClear());
				bool flag = Singleton<WdAPI>.I.edtonKXt5C(P_0.user.人物数据.形象ID);
				Singleton<WdAPI>.I.取对应妖族类型(P_0.user.人物数据.形象ID);
				string 门派 = P_0.user.人物数据.门派;
				if (!(门派 == "五龙山云霄洞"))
				{
					if (!(门派 == "终南山玉柱洞"))
					{
						if (!(门派 == "凤凰山斗阙宫"))
						{
							if (!(门派 == "乾元山金光洞"))
							{
								if (门派 == "骷髅山白骨洞")
								{
									StringBuilder stringBuilder2 = stringBuilder;
									StringBuilder stringBuilder3 = stringBuilder2;
									StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
									handler.AppendLiteral("[");
									handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老金门派);
									handler.AppendLiteral("/门派转换操作_老五龙山云霄洞]");
									handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新金门派 + "/门派转换操作_新五龙山云霄洞]") : string.Empty);
									stringBuilder3.Append(ref handler);
									stringBuilder2 = stringBuilder;
									StringBuilder stringBuilder4 = stringBuilder2;
									handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
									handler.AppendLiteral("[");
									handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老木门派);
									handler.AppendLiteral("/门派转换操作_老终南山玉柱洞]");
									handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新木门派 + "/门派转换操作_新终南山玉柱洞]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 1) ? "[【竹熊】转换妖族竹熊/门派转换操作_新终南山玉柱洞]" : string.Empty));
									stringBuilder4.Append(ref handler);
									stringBuilder2 = stringBuilder;
									StringBuilder stringBuilder5 = stringBuilder2;
									handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
									handler.AppendLiteral("[");
									handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老水门派);
									handler.AppendLiteral("/门派转换操作_老凤凰山斗阙宫]");
									handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新水门派 + "/门派转换操作_新凤凰山斗阙宫]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 2) ? "[【玉兔】转换妖族玉兔/门派转换操作_新凤凰山斗阙宫]" : string.Empty));
									stringBuilder5.Append(ref handler);
									stringBuilder2 = stringBuilder;
									StringBuilder stringBuilder6 = stringBuilder2;
									handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
									handler.AppendLiteral("[");
									handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老火门派);
									handler.AppendLiteral("/门派转换操作_老乾元山金光洞]");
									handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新火门派 + "/门派转换操作_新乾元山金光洞]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 2) ? "[【灵蛇】转换妖族灵蛇/门派转换操作_新乾元山金光洞]" : string.Empty));
									stringBuilder6.Append(ref handler);
									if (flag)
									{
										stringBuilder2 = stringBuilder;
										StringBuilder stringBuilder7 = stringBuilder2;
										handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
										handler.AppendLiteral("[");
										handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老土门派);
										handler.AppendLiteral("/门派转换操作_老骷髅山白骨洞]");
										stringBuilder7.Append(ref handler);
									}
									else if (Singleton<全局变量类>.I.门派转换配置.is新角色)
									{
										stringBuilder2 = stringBuilder;
										StringBuilder stringBuilder8 = stringBuilder2;
										handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
										handler.AppendLiteral("[");
										handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.新土门派);
										handler.AppendLiteral("/门派转换操作_新骷髅山白骨洞]");
										stringBuilder8.Append(ref handler);
									}
									else if (Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 1)
									{
										stringBuilder.Append("[【孔雀】转换妖族孔雀/门派转换操作_新骷髅山白骨洞]");
									}
								}
							}
							else
							{
								StringBuilder stringBuilder2 = stringBuilder;
								StringBuilder stringBuilder9 = stringBuilder2;
								StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
								handler.AppendLiteral("[");
								handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老金门派);
								handler.AppendLiteral("/门派转换操作_老五龙山云霄洞]");
								handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新金门派 + "/门派转换操作_新五龙山云霄洞]") : string.Empty);
								stringBuilder9.Append(ref handler);
								stringBuilder2 = stringBuilder;
								StringBuilder stringBuilder10 = stringBuilder2;
								handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
								handler.AppendLiteral("[");
								handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老木门派);
								handler.AppendLiteral("/门派转换操作_老终南山玉柱洞]");
								handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新木门派 + "/门派转换操作_新终南山玉柱洞]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 1) ? "[【竹熊】转换妖族竹熊/门派转换操作_新终南山玉柱洞]" : string.Empty));
								stringBuilder10.Append(ref handler);
								stringBuilder2 = stringBuilder;
								StringBuilder stringBuilder11 = stringBuilder2;
								handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
								handler.AppendLiteral("[");
								handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老水门派);
								handler.AppendLiteral("/门派转换操作_老凤凰山斗阙宫]");
								handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新水门派 + "/门派转换操作_新凤凰山斗阙宫]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 2) ? "[【玉兔】转换妖族玉兔/门派转换操作_新凤凰山斗阙宫]" : string.Empty));
								stringBuilder11.Append(ref handler);
								if (flag)
								{
									stringBuilder2 = stringBuilder;
									StringBuilder stringBuilder12 = stringBuilder2;
									handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
									handler.AppendLiteral("[");
									handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老火门派);
									handler.AppendLiteral("/门派转换操作_老乾元山金光洞]");
									stringBuilder12.Append(ref handler);
								}
								else if (Singleton<全局变量类>.I.门派转换配置.is新角色)
								{
									stringBuilder2 = stringBuilder;
									StringBuilder stringBuilder13 = stringBuilder2;
									handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
									handler.AppendLiteral("[");
									handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.新火门派);
									handler.AppendLiteral("/门派转换操作_新乾元山金光洞]");
									stringBuilder13.Append(ref handler);
								}
								else if (Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 2)
								{
									stringBuilder.Append("[【灵蛇】转换妖族灵蛇/门派转换操作_新乾元山金光洞]");
								}
								stringBuilder2 = stringBuilder;
								StringBuilder stringBuilder14 = stringBuilder2;
								handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
								handler.AppendLiteral("[");
								handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老土门派);
								handler.AppendLiteral("/门派转换操作_老骷髅山白骨洞]");
								handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新土门派 + "/门派转换操作_新骷髅山白骨洞]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 1) ? "[【孔雀】转换妖族孔雀/门派转换操作_新骷髅山白骨洞]" : string.Empty));
								stringBuilder14.Append(ref handler);
							}
						}
						else
						{
							StringBuilder stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder15 = stringBuilder2;
							StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
							handler.AppendLiteral("[");
							handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老金门派);
							handler.AppendLiteral("/门派转换操作_老五龙山云霄洞]");
							handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新金门派 + "/门派转换操作_新五龙山云霄洞]") : string.Empty);
							stringBuilder15.Append(ref handler);
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder16 = stringBuilder2;
							handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
							handler.AppendLiteral("[");
							handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老木门派);
							handler.AppendLiteral("/门派转换操作_老终南山玉柱洞]");
							handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新木门派 + "/门派转换操作_新终南山玉柱洞]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 1) ? "[【竹熊】转换妖族竹熊/门派转换操作_新终南山玉柱洞]" : string.Empty));
							stringBuilder16.Append(ref handler);
							if (flag)
							{
								stringBuilder2 = stringBuilder;
								StringBuilder stringBuilder17 = stringBuilder2;
								handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
								handler.AppendLiteral("[");
								handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老水门派);
								handler.AppendLiteral("/门派转换操作_老凤凰山斗阙宫]");
								stringBuilder17.Append(ref handler);
							}
							else if (Singleton<全局变量类>.I.门派转换配置.is新角色)
							{
								stringBuilder2 = stringBuilder;
								StringBuilder stringBuilder18 = stringBuilder2;
								handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
								handler.AppendLiteral("[");
								handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.新水门派);
								handler.AppendLiteral("/门派转换操作_新凤凰山斗阙宫]");
								stringBuilder18.Append(ref handler);
							}
							else if (Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 2)
							{
								stringBuilder.Append("[【玉兔】转换妖族玉兔/门派转换操作_新凤凰山斗阙宫]");
							}
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder19 = stringBuilder2;
							handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
							handler.AppendLiteral("[");
							handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老火门派);
							handler.AppendLiteral("/门派转换操作_老乾元山金光洞]");
							handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新火门派 + "/门派转换操作_新乾元山金光洞]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 2) ? "[【灵蛇】转换妖族灵蛇/门派转换操作_新乾元山金光洞]" : string.Empty));
							stringBuilder19.Append(ref handler);
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder20 = stringBuilder2;
							handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
							handler.AppendLiteral("[");
							handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老土门派);
							handler.AppendLiteral("/门派转换操作_老骷髅山白骨洞]");
							handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新土门派 + "/门派转换操作_新骷髅山白骨洞]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 1) ? "[【孔雀】转换妖族孔雀/门派转换操作_新骷髅山白骨洞]" : string.Empty));
							stringBuilder20.Append(ref handler);
						}
					}
					else
					{
						StringBuilder stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder21 = stringBuilder2;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
						handler.AppendLiteral("[");
						handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老金门派);
						handler.AppendLiteral("/门派转换操作_老五龙山云霄洞]");
						handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新金门派 + "/门派转换操作_新五龙山云霄洞]") : string.Empty);
						stringBuilder21.Append(ref handler);
						if (flag)
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder22 = stringBuilder2;
							handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
							handler.AppendLiteral("[");
							handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老木门派);
							handler.AppendLiteral("/门派转换操作_老终南山玉柱洞]");
							stringBuilder22.Append(ref handler);
						}
						else if (Singleton<全局变量类>.I.门派转换配置.is新角色)
						{
							stringBuilder2 = stringBuilder;
							StringBuilder stringBuilder23 = stringBuilder2;
							handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
							handler.AppendLiteral("[");
							handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.新木门派);
							handler.AppendLiteral("/门派转换操作_新终南山玉柱洞]");
							stringBuilder23.Append(ref handler);
						}
						else if (Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 1)
						{
							stringBuilder.Append("[【竹熊】转换妖族竹熊/门派转换操作_新终南山玉柱洞]");
						}
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder24 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
						handler.AppendLiteral("[");
						handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老水门派);
						handler.AppendLiteral("/门派转换操作_老凤凰山斗阙宫]");
						handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新水门派 + "/门派转换操作_新凤凰山斗阙宫]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 2) ? "[【玉兔】转换妖族玉兔/门派转换操作_新凤凰山斗阙宫]" : string.Empty));
						stringBuilder24.Append(ref handler);
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder25 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
						handler.AppendLiteral("[");
						handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老火门派);
						handler.AppendLiteral("/门派转换操作_老乾元山金光洞]");
						handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新火门派 + "/门派转换操作_新乾元山金光洞]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 2) ? "[【灵蛇】转换妖族灵蛇/门派转换操作_新乾元山金光洞]" : string.Empty));
						stringBuilder25.Append(ref handler);
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder26 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
						handler.AppendLiteral("[");
						handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老土门派);
						handler.AppendLiteral("/门派转换操作_老骷髅山白骨洞]");
						handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新土门派 + "/门派转换操作_新骷髅山白骨洞]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 1) ? "[【孔雀】转换妖族孔雀/门派转换操作_新骷髅山白骨洞]" : string.Empty));
						stringBuilder26.Append(ref handler);
					}
				}
				else
				{
					StringBuilder stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler;
					if (flag)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder27 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
						handler.AppendLiteral("[");
						handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老金门派);
						handler.AppendLiteral("/门派转换操作_老五龙山云霄洞]");
						stringBuilder27.Append(ref handler);
					}
					else if (Singleton<全局变量类>.I.门派转换配置.is新角色)
					{
						stringBuilder2 = stringBuilder;
						StringBuilder stringBuilder28 = stringBuilder2;
						handler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, stringBuilder2);
						handler.AppendLiteral("[");
						handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.新金门派);
						handler.AppendLiteral("/门派转换操作_新五龙山云霄洞]");
						stringBuilder28.Append(ref handler);
					}
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder29 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
					handler.AppendLiteral("[");
					handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老木门派);
					handler.AppendLiteral("/门派转换操作_老终南山玉柱洞]");
					handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新木门派 + "/门派转换操作_新终南山玉柱洞]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 1) ? "[【竹熊】转换妖族竹熊/门派转换操作_新终南山玉柱洞]" : string.Empty));
					stringBuilder29.Append(ref handler);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder30 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
					handler.AppendLiteral("[");
					handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老水门派);
					handler.AppendLiteral("/门派转换操作_老凤凰山斗阙宫]");
					handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新水门派 + "/门派转换操作_新凤凰山斗阙宫]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 2) ? "[【玉兔】转换妖族玉兔/门派转换操作_新凤凰山斗阙宫]" : string.Empty));
					stringBuilder30.Append(ref handler);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder31 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
					handler.AppendLiteral("[");
					handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老火门派);
					handler.AppendLiteral("/门派转换操作_老乾元山金光洞]");
					handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新火门派 + "/门派转换操作_新乾元山金光洞]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 2) ? "[【灵蛇】转换妖族灵蛇/门派转换操作_新乾元山金光洞]" : string.Empty));
					stringBuilder31.Append(ref handler);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder32 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(17, 2, stringBuilder2);
					handler.AppendLiteral("[");
					handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.老土门派);
					handler.AppendLiteral("/门派转换操作_老骷髅山白骨洞]");
					handler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.is新角色 ? ("[" + Singleton<全局变量类>.I.门派转换配置.新土门派 + "/门派转换操作_新骷髅山白骨洞]") : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_0.user.人物数据.性别 == 1) ? "[【孔雀】转换妖族孔雀/门派转换操作_新骷髅山白骨洞]" : string.Empty));
					stringBuilder32.Append(ref handler);
				}
				P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.NPC_逍遥仙, 6032, "逍遥仙", stringBuilder.ToString()));
			}
			else if (P_1.IndexOf("门派转换操作_新") != -1)
			{
				string text = P_1.Replace("门派转换操作_新", "");
				LyqloaGIyP(P_0, text, false);
			}
			else if (P_1.IndexOf("门派转换操作_老") != -1)
			{
				string text2 = P_1.Replace("门派转换操作_老", "");
				LyqloaGIyP(P_0, text2);
			}
		}
		catch (Exception ex)
		{
			Log.Error("门派转换事件处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task LyqloaGIyP(MyNATSocketClient P_0, string P_1, bool P_2 = true)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals13 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals13.RmHMTtMGTo = P_1;
		try
		{
			if (Singleton<全局变量类>.I.门派转换配置.消耗类型 == AllEnums.数值Type.金元宝)
			{
				if (P_0.user.背包数据.金元宝 < Singleton<全局变量类>.I.门派转换配置.转换消耗)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R金元宝不足，无法进行门派转换！"));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, -Singleton<全局变量类>.I.门派转换配置.转换消耗, 0))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R金元宝不足，无法进行门派转换！"));
					return;
				}
			}
			if (Singleton<全局变量类>.I.门派转换配置.消耗类型 == AllEnums.数值Type.银元宝)
			{
				if (P_0.user.背包数据.银元宝 < Singleton<全局变量类>.I.门派转换配置.转换消耗)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R银元宝不足，无法进行门派转换！"));
					return;
				}
				if (!DB.I.cAJNoOkab6(P_0, 0, -Singleton<全局变量类>.I.门派转换配置.转换消耗))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R银元宝不足，无法进行门派转换！"));
					return;
				}
			}
			if (Singleton<全局变量类>.I.门派转换配置.消耗类型 == AllEnums.数值Type.灵气值)
			{
				if (P_0.user.存档数据.数值存档.灵气值 < Singleton<全局变量类>.I.门派转换配置.转换消耗)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R灵气值不足，无法进行门派转换！"));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.灵气值, string.Empty, AllEnums.指令Type.无, -Singleton<全局变量类>.I.门派转换配置.转换消耗, false, "[门派转换]消耗");
			}
			string 临时GID = Singleton<ByteAPI>.I.GetHexGid_(P_0.user.人物数据.GID);
			string 当前角色账号 = P_0.user.人物数据.账号;
			int 当前角色性别 = P_0.user.人物数据.性别;
			string 当前装备 = ((P_0.user.背包数据.物品列表[1] != null) ? P_0.user.背包数据.物品列表[1].名字 : string.Empty);
			_ = P_0.user.缓存数据.几代弟子文本;
			WdAPI i = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 2);
			defaultInterpolatedStringHandler.AppendLiteral("你使用了#R");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.转换消耗);
			defaultInterpolatedStringHandler.AppendLiteral("#n");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.门派转换配置.消耗类型);
			defaultInterpolatedStringHandler.AppendLiteral("进行了门派转换操作。为了保证数据安全，游戏将掉线10秒后才可恢复。");
			P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
			CS_0024_003C_003E8__locals13.S1sM9LEyDs = (P_2 ? 1 : 2);
			List<技能详细数据类> list = 问道数据类.技能详细数据.FindAll( (技能详细数据类 x) => x.技能门派.ToString() == CS_0024_003C_003E8__locals13.RmHMTtMGTo && (x.技能类型 == 0 || x.技能类型 == CS_0024_003C_003E8__locals13.S1sM9LEyDs));
			if (list.Count > 0)
			{
				List<string[]> list2 = new List<string[]>();
				using (IEnumerator<KeyValuePair<string, short>> enumerator = P_0.user.技能数据.技能列表.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						_003C_003Ec__DisplayClass18_1 CS_0024_003C_003E8__locals15 = new _003C_003Ec__DisplayClass18_1();
						CS_0024_003C_003E8__locals15.eX4MVjL2G7 = enumerator.Current;
						_003C_003Ec__DisplayClass18_2 CS_0024_003C_003E8__locals17 = new _003C_003Ec__DisplayClass18_2();
						if (CS_0024_003C_003E8__locals15.eX4MVjL2G7.Value <= 0 || !问道数据类.技能详细数据.Any( (技能详细数据类 x) => x.技能名字 == CS_0024_003C_003E8__locals15.eX4MVjL2G7.Key))
						{
							continue;
						}
						CS_0024_003C_003E8__locals17.NPFM01slht = 问道数据类.技能详细数据.Find( (技能详细数据类 x) => x.技能名字 == CS_0024_003C_003E8__locals15.eX4MVjL2G7.Key);
						if (CS_0024_003C_003E8__locals17.NPFM01slht != null)
						{
							技能详细数据类 技能详细数据类2 = list.Find( (技能详细数据类 x) => x.技能名字 != CS_0024_003C_003E8__locals17.NPFM01slht.技能名字 && x.技能品阶 == CS_0024_003C_003E8__locals17.NPFM01slht.技能品阶);
							if (技能详细数据类2 != null)
							{
								list2.Add(new string[2]
								{
									CS_0024_003C_003E8__locals17.NPFM01slht.技能id.ToString(),
									"0"
								});
								list2.Add(new string[2]
								{
									技能详细数据类2.技能id.ToString(),
									CS_0024_003C_003E8__locals15.eX4MVjL2G7.Value.ToString()
								});
							}
						}
					}
				}
				if (list2.Count > 0)
				{
					Singleton<WdAPI>.I.f5oIxL5Jqw(P_0, P_0.user.人物数据.昵称, P_0.user.人物数据.角色ID.ToString(), list2);
					await Task.Delay(2000);
				}
			}
			if (!DB.I.锁定账号操作(当前角色账号, "1"))
			{
				Log.Error("确定执行门派转换-错误：账号锁定失败");
				return;
			}
			Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
			await Task.Delay(5000);
			DB.I.iIiN5qmkYH(临时GID, 当前角色账号, 当前装备, CS_0024_003C_003E8__locals13.RmHMTtMGTo, 当前角色性别, P_2);
		}
		catch (Exception ex)
		{
			Log.Error("确定执行门派转换-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public DB9OkbjZMmmdyW1KQMk()
	{
	}

	static DB9OkbjZMmmdyW1KQMk()
	{
	}
}
