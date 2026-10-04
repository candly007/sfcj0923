using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using KEvDjBdeoLOoBKWXFAH;
using Newtonsoft.Json;
using Serilog;
using ixYEhcwWIdwrtDxOO94;
using vEAdPGPTkDFOYsbi303;

namespace kNOi3Vbgo4LTDja4YFk;

internal class KU0aMobWe16QEEmpLCj : Singleton<KU0aMobWe16QEEmpLCj>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public 异兽录图鉴列表类 Cm1Xz8knmV;

		
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		
		internal bool YKIXAy80ae(string x)
		{
			return x == Cm1Xz8knmV.宠物名字;
		}

		static _003C_003Ec__DisplayClass4_0()
		{
		}
	}

	
	internal void V1jbDnDP98()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("喊话限制配置类.json")))
			{
				Singleton<全局变量类>.I.喊话限制配置 = JsonConvert.DeserializeObject<喊话限制配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("喊话限制配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.喊话限制配置 = new 喊话限制配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("喊话限制配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.喊话限制配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("喊话限制配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void kd2bjmeMXG()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("喊话限制配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.喊话限制配置, Formatting.Indented));
			Log.Debug("喊话限制配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("喊话限制配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string kx5bl7uTFr()
	{
		V1jbDnDP98();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.喊话限制配置, Formatting.Indented);
	}

	
	public void Onjb8EdMVV(string P_0)
	{
		Singleton<全局变量类>.I.喊话限制配置 = JsonConvert.DeserializeObject<喊话限制配置类>(P_0);
		kd2bjmeMXG();
	}

	
	internal 相性池 SIPbIQGTML(MyNATSocketClient P_0, 相性池 P_1)
	{
		try
		{
			异兽录存档数据类 异兽录存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.异兽录数据.方案1 : P_0.user.存档数据.异兽录数据.方案2);
			using (IEnumerator<异兽录图鉴列表类> enumerator = Singleton<全局变量类>.I.异兽录配置.图鉴列表.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals14 = new _003C_003Ec__DisplayClass4_0();
					CS_0024_003C_003E8__locals14.Cm1Xz8knmV = enumerator.Current;
					if (异兽录存档数据类2.收录列表[CS_0024_003C_003E8__locals14.Cm1Xz8knmV.所属分类].Any( (string x) => x == CS_0024_003C_003E8__locals14.Cm1Xz8knmV.宠物名字))
					{
						switch (CS_0024_003C_003E8__locals14.Cm1Xz8knmV.收录属性)
						{
						case AllEnums.属性Type.金相性:
							P_1.金 += CS_0024_003C_003E8__locals14.Cm1Xz8knmV.收录数值;
							break;
						case AllEnums.属性Type.木相性:
							P_1.木 += CS_0024_003C_003E8__locals14.Cm1Xz8knmV.收录数值;
							break;
						case AllEnums.属性Type.水相性:
							P_1.水 += CS_0024_003C_003E8__locals14.Cm1Xz8knmV.收录数值;
							break;
						case AllEnums.属性Type.火相性:
							P_1.火 += CS_0024_003C_003E8__locals14.Cm1Xz8knmV.收录数值;
							break;
						case AllEnums.属性Type.土相性:
							P_1.土 += CS_0024_003C_003E8__locals14.Cm1Xz8knmV.收录数值;
							break;
						case AllEnums.属性Type.所有相性:
							P_1.金 += CS_0024_003C_003E8__locals14.Cm1Xz8knmV.收录数值;
							P_1.木 += CS_0024_003C_003E8__locals14.Cm1Xz8knmV.收录数值;
							P_1.水 += CS_0024_003C_003E8__locals14.Cm1Xz8knmV.收录数值;
							P_1.火 += CS_0024_003C_003E8__locals14.Cm1Xz8knmV.收录数值;
							P_1.土 += CS_0024_003C_003E8__locals14.Cm1Xz8knmV.收录数值;
							break;
						}
					}
				}
			}
			foreach (KeyValuePair<AllEnums.异兽Type, bool> item in 异兽录存档数据类2.分类圆满状态)
			{
				if (!item.Value)
				{
					continue;
				}
				if (item.Key == AllEnums.异兽Type.变异)
				{
					switch (Singleton<全局变量类>.I.异兽录配置.变异圆满附加属性)
					{
					case AllEnums.属性Type.金相性:
						P_1.金 += Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值;
						break;
					case AllEnums.属性Type.木相性:
						P_1.木 += Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值;
						break;
					case AllEnums.属性Type.水相性:
						P_1.水 += Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值;
						break;
					case AllEnums.属性Type.火相性:
						P_1.火 += Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值;
						break;
					case AllEnums.属性Type.土相性:
						P_1.土 += Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值;
						break;
					case AllEnums.属性Type.所有相性:
						P_1.金 += Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值;
						P_1.木 += Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值;
						P_1.水 += Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值;
						P_1.火 += Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值;
						P_1.土 += Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值;
						break;
					}
				}
				else if (item.Key == AllEnums.异兽Type.神兽)
				{
					switch (Singleton<全局变量类>.I.异兽录配置.神兽圆满附加属性)
					{
					case AllEnums.属性Type.金相性:
						P_1.金 += Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值;
						break;
					case AllEnums.属性Type.木相性:
						P_1.木 += Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值;
						break;
					case AllEnums.属性Type.水相性:
						P_1.水 += Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值;
						break;
					case AllEnums.属性Type.火相性:
						P_1.火 += Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值;
						break;
					case AllEnums.属性Type.土相性:
						P_1.土 += Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值;
						break;
					case AllEnums.属性Type.所有相性:
						P_1.金 += Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值;
						P_1.木 += Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值;
						P_1.水 += Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值;
						P_1.火 += Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值;
						P_1.土 += Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值;
						break;
					}
				}
				else if (item.Key == AllEnums.异兽Type.元灵)
				{
					switch (Singleton<全局变量类>.I.异兽录配置.元灵圆满附加属性)
					{
					case AllEnums.属性Type.金相性:
						P_1.金 += Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值;
						break;
					case AllEnums.属性Type.木相性:
						P_1.木 += Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值;
						break;
					case AllEnums.属性Type.水相性:
						P_1.水 += Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值;
						break;
					case AllEnums.属性Type.火相性:
						P_1.火 += Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值;
						break;
					case AllEnums.属性Type.土相性:
						P_1.土 += Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值;
						break;
					case AllEnums.属性Type.所有相性:
						P_1.金 += Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值;
						P_1.木 += Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值;
						P_1.水 += Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值;
						P_1.火 += Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值;
						P_1.土 += Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值;
						break;
					}
				}
				else if (item.Key == AllEnums.异兽Type.仙元)
				{
					switch (Singleton<全局变量类>.I.异兽录配置.仙元圆满附加属性)
					{
					case AllEnums.属性Type.金相性:
						P_1.金 += Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值;
						break;
					case AllEnums.属性Type.木相性:
						P_1.木 += Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值;
						break;
					case AllEnums.属性Type.水相性:
						P_1.水 += Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值;
						break;
					case AllEnums.属性Type.火相性:
						P_1.火 += Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值;
						break;
					case AllEnums.属性Type.土相性:
						P_1.土 += Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值;
						break;
					case AllEnums.属性Type.所有相性:
						P_1.金 += Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值;
						P_1.木 += Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值;
						P_1.水 += Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值;
						P_1.火 += Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值;
						P_1.土 += Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值;
						break;
					}
				}
				else if (item.Key == AllEnums.异兽Type.御灵)
				{
					switch (Singleton<全局变量类>.I.异兽录配置.御灵圆满附加属性)
					{
					case AllEnums.属性Type.金相性:
						P_1.金 += Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值;
						break;
					case AllEnums.属性Type.木相性:
						P_1.木 += Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值;
						break;
					case AllEnums.属性Type.水相性:
						P_1.水 += Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值;
						break;
					case AllEnums.属性Type.火相性:
						P_1.火 += Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值;
						break;
					case AllEnums.属性Type.土相性:
						P_1.土 += Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值;
						break;
					case AllEnums.属性Type.所有相性:
						P_1.金 += Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值;
						P_1.木 += Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值;
						P_1.水 += Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值;
						P_1.火 += Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值;
						P_1.土 += Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值;
						break;
					}
				}
			}
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("找回异兽录属性查询-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return P_1;
	}

	
	internal 相性池 spYboaWcPd(MyNATSocketClient P_0, 相性池 P_1)
	{
		try
		{
			六道轮回存档数据类 六道轮回存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.轮回转世数据.存档方案1 : P_0.user.存档数据.轮回转世数据.存档方案2);
			相性池 相性池2 = default(相性池);
			for (int i = 0; i < 六道轮回存档数据类2.转世属性列表.Length; i++)
			{
				switch ((AllEnums.属性Type)六道轮回存档数据类2.转世属性列表[i].转世属性)
				{
				case AllEnums.属性Type.金相性:
					相性池2.金 += 六道轮回存档数据类2.转世属性列表[i].属性数值;
					break;
				case AllEnums.属性Type.木相性:
					相性池2.木 += 六道轮回存档数据类2.转世属性列表[i].属性数值;
					break;
				case AllEnums.属性Type.水相性:
					相性池2.水 += 六道轮回存档数据类2.转世属性列表[i].属性数值;
					break;
				case AllEnums.属性Type.火相性:
					相性池2.火 += 六道轮回存档数据类2.转世属性列表[i].属性数值;
					break;
				case AllEnums.属性Type.土相性:
					相性池2.土 += 六道轮回存档数据类2.转世属性列表[i].属性数值;
					break;
				case AllEnums.属性Type.所有相性:
					相性池2.金 += 六道轮回存档数据类2.转世属性列表[i].属性数值;
					相性池2.木 += 六道轮回存档数据类2.转世属性列表[i].属性数值;
					相性池2.水 += 六道轮回存档数据类2.转世属性列表[i].属性数值;
					相性池2.火 += 六道轮回存档数据类2.转世属性列表[i].属性数值;
					相性池2.土 += 六道轮回存档数据类2.转世属性列表[i].属性数值;
					break;
				}
			}
			P_1.金 += 相性池2.金;
			P_1.木 += 相性池2.木;
			P_1.水 += 相性池2.水;
			P_1.火 += 相性池2.火;
			P_1.土 += 相性池2.土;
			WdAPI i2 = Singleton<WdAPI>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 5);
			defaultInterpolatedStringHandler.AppendLiteral("可找回六道轮回相性：#Y金相性×");
			defaultInterpolatedStringHandler.AppendFormatted(相性池2.金);
			defaultInterpolatedStringHandler.AppendLiteral("#n、#Y木相性×");
			defaultInterpolatedStringHandler.AppendFormatted(相性池2.木);
			defaultInterpolatedStringHandler.AppendLiteral("#n、#Y水相性×");
			defaultInterpolatedStringHandler.AppendFormatted(相性池2.水);
			defaultInterpolatedStringHandler.AppendLiteral("#n、#Y火相性×");
			defaultInterpolatedStringHandler.AppendFormatted(相性池2.火);
			defaultInterpolatedStringHandler.AppendLiteral("#n、#Y土相性×");
			defaultInterpolatedStringHandler.AppendFormatted(相性池2.土);
			defaultInterpolatedStringHandler.AppendLiteral("#n");
			P_0.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			return P_1;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("找回六道属性查询-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return P_1;
		}
	}

	
	internal void iPIbNC4UnR(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_0.user.属性数据.等级 < 61)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("当前等级过低，不符合此功能的使用条件！"));
				return;
			}
			if (P_0.user.属性数据.剩余相性 != 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前还有未使用的的剩余相性点，不符合此功能的使用条件！"));
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (Math.Abs(P_0.user.属性数据.等级 + P_0.user.属性数据.相性丹药 - 31 - (P_0.user.属性数据.金相性值 + P_0.user.属性数据.木相性值 + P_0.user.属性数据.水相性值 + P_0.user.属性数据.火相性值 + P_0.user.属性数据.土相性值)) > 5)
			{
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
				defaultInterpolatedStringHandler.AppendLiteral("当前已加的总相性点≠");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.属性数据.等级 + P_0.user.属性数据.相性丹药 - 31);
				defaultInterpolatedStringHandler.AppendLiteral("，不符合此功能的使用条件！");
				P_0.C_Send(i.提示_中心提醒(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			if ((P_0.user.缓存数据.is加点方案一 && P_1 != "1") || (!P_0.user.缓存数据.is加点方案一 && P_1 != "2"))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("选择找回属性的加点方案与你当前生效的加点方案不一致，请刷新重试，不要给我耍小聪明，OK！"));
				return;
			}
			相性池 相性池2 = default(相性池);
			if (!iRGieud4qtscW6ESmxk.C9dsD7Vloy() && Singleton<全局变量类>.I.异兽录配置.功能开关)
			{
				相性池2 = SIPbIQGTML(P_0, 相性池2);
				WdAPI i2 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(53, 5);
				defaultInterpolatedStringHandler.AppendLiteral("可找回异兽录相性：#Y金相性×");
				defaultInterpolatedStringHandler.AppendFormatted(相性池2.金);
				defaultInterpolatedStringHandler.AppendLiteral("#n、#Y木相性×");
				defaultInterpolatedStringHandler.AppendFormatted(相性池2.木);
				defaultInterpolatedStringHandler.AppendLiteral("#n、#Y水相性×");
				defaultInterpolatedStringHandler.AppendFormatted(相性池2.水);
				defaultInterpolatedStringHandler.AppendLiteral("#n、#Y火相性×");
				defaultInterpolatedStringHandler.AppendFormatted(相性池2.火);
				defaultInterpolatedStringHandler.AppendLiteral("#n、#Y土相性×");
				defaultInterpolatedStringHandler.AppendFormatted(相性池2.土);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				P_0.C_Send(i2.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			if (!MbtVicwUkp5LuxTooFW.EaewmWn7Ul() && Singleton<全局变量类>.I.六道轮回配置.功能开关)
			{
				相性池2 = spYboaWcPd(P_0, 相性池2);
			}
			if (!浮生录功能.J7aWuMQOCf() && Singleton<全局变量类>.I.浮生录配置.功能开关)
			{
				浮生录存档类 浮生录存档类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.浮生录数据.方案1 : P_0.user.存档数据.浮生录数据.方案2);
				相性池2.金 += 浮生录存档类2.浮生属性.金相性;
				相性池2.木 += 浮生录存档类2.浮生属性.木相性;
				相性池2.水 += 浮生录存档类2.浮生属性.水相性;
				相性池2.火 += 浮生录存档类2.浮生属性.火相性;
				相性池2.土 += 浮生录存档类2.浮生属性.土相性;
				WdAPI i3 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(53, 5);
				defaultInterpolatedStringHandler.AppendLiteral("可找回浮生录相性：#Y金相性×");
				defaultInterpolatedStringHandler.AppendFormatted(浮生录存档类2.浮生属性.金相性);
				defaultInterpolatedStringHandler.AppendLiteral("#n、#Y木相性×");
				defaultInterpolatedStringHandler.AppendFormatted(浮生录存档类2.浮生属性.木相性);
				defaultInterpolatedStringHandler.AppendLiteral("#n、#Y水相性×");
				defaultInterpolatedStringHandler.AppendFormatted(浮生录存档类2.浮生属性.水相性);
				defaultInterpolatedStringHandler.AppendLiteral("#n、#Y火相性×");
				defaultInterpolatedStringHandler.AppendFormatted(浮生录存档类2.浮生属性.火相性);
				defaultInterpolatedStringHandler.AppendLiteral("#n、#Y土相性×");
				defaultInterpolatedStringHandler.AppendFormatted(浮生录存档类2.浮生属性.土相性);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				P_0.C_Send(i3.提示_杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			if (相性池2.金 > 0)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.metal, 相性池2.金, false, "[找回属性]属性增加");
			}
			if (相性池2.木 > 0)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.wood, 相性池2.木, false, "[找回属性]属性增加");
			}
			if (相性池2.水 > 0)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.water, 相性池2.水, false, "[找回属性]属性增加");
			}
			if (相性池2.火 > 0)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.fire, 相性池2.火, false, "[找回属性]属性增加");
			}
			if (相性池2.土 > 0)
			{
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, AllEnums.指令Type.earth, 相性池2.土, false, "[找回属性]属性增加");
			}
			WdAPI i4 = Singleton<WdAPI>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 5);
			defaultInterpolatedStringHandler.AppendLiteral("恭喜你，总共找回了#Y");
			defaultInterpolatedStringHandler.AppendFormatted(相性池2.金);
			defaultInterpolatedStringHandler.AppendLiteral("点金相性#n、#Y");
			defaultInterpolatedStringHandler.AppendFormatted(相性池2.木);
			defaultInterpolatedStringHandler.AppendLiteral("点木相性#n、#Y");
			defaultInterpolatedStringHandler.AppendFormatted(相性池2.水);
			defaultInterpolatedStringHandler.AppendLiteral("点水相性#n、#Y");
			defaultInterpolatedStringHandler.AppendFormatted(相性池2.火);
			defaultInterpolatedStringHandler.AppendLiteral("点火相性#n、#Y");
			defaultInterpolatedStringHandler.AppendFormatted(相性池2.土);
			defaultInterpolatedStringHandler.AppendLiteral("点土相性#n！");
			P_0.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("确定属性找回事件-报错：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("（");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	public KU0aMobWe16QEEmpLCj()
	{
	}

	static KU0aMobWe16QEEmpLCj()
	{
	}
}
