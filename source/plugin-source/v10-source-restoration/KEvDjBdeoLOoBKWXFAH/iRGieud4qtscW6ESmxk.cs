using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;
using Serilog;
using VcF0pbBvJqp0x0IfwN;
using vEAdPGPTkDFOYsbi303;

namespace KEvDjBdeoLOoBKWXFAH;

internal class iRGieud4qtscW6ESmxk : Singleton<iRGieud4qtscW6ESmxk>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public 异兽录图鉴列表类 QVvSQWktnJ;

		
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		
		internal bool kWFSORtuk3(string a)
		{
			return a == QVvSQWktnJ.宠物名字;
		}

		static _003C_003Ec__DisplayClass20_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public string LZ4SYW0wal;

		public 宠物缓存数据类 t3HSpSxBJZ;

		
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		
		internal bool UBkSEPUlXQ(宠物缓存数据类 a)
		{
			return a.宠物ID.ToString() == LZ4SYW0wal;
		}

		
		internal bool VTrS3ttlnh(string a)
		{
			return a == t3HSpSxBJZ.昵称B;
		}

		static _003C_003Ec__DisplayClass21_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public int BjvSHsNUfX;

		public 异兽录图鉴列表类 UnKS4hn5Cl;

		
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		
		internal bool xLgS1GXDMB(宠物缓存数据类 a)
		{
			if (BjvSHsNUfX != 0)
			{
				return a.宠物ID == BjvSHsNUfX;
			}
			return false;
		}

		
		internal bool DHFSxXpaNd(string a)
		{
			return a == UnKS4hn5Cl.宠物名字;
		}

		static _003C_003Ec__DisplayClass22_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public AllEnums.异兽Type qw1SqbdEkU;

		
		public _003C_003Ec__DisplayClass26_0()
		{
		}

		
		internal bool BGFSeAr8HR(异兽录图鉴列表类 x)
		{
			return x.所属分类 == qw1SqbdEkU;
		}

		static _003C_003Ec__DisplayClass26_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass26_1
	{
		public 异兽录图鉴列表类 KVPSZhtany;

		
		public _003C_003Ec__DisplayClass26_1()
		{
		}

		
		internal bool S8wSrtw9cO(string x)
		{
			return x == KVPSZhtany.宠物名字;
		}

		static _003C_003Ec__DisplayClass26_1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public 异兽录图鉴列表类 fIbSAFBkCX;

		
		public _003C_003Ec__DisplayClass27_0()
		{
		}

		
		internal bool wIeStRAie7(string x)
		{
			return x == fIbSAFBkCX.宠物名字;
		}

		static _003C_003Ec__DisplayClass27_0()
		{
		}
	}

	private StringBuilder aNqsIXvjFq;

	internal byte[] mRtsohUNC2;

	internal ConcurrentDictionary<string, 异兽录图鉴列表类> W5hsNnYAjN;

	internal ConcurrentDictionary<string, 异兽录图鉴列表类> T6gsiwMmCv;

	internal ConcurrentDictionary<string, 异兽录图鉴列表类> iFLsBvoaBy;

	internal ConcurrentDictionary<string, 异兽录图鉴列表类> Q1xsG3Fx3O;

	internal ConcurrentDictionary<string, 异兽录图鉴列表类> f1esfGQQpj;

	
	[SpecialName]
	internal static bool C9dsD7Vloy()
	{
		if (全局变量类.Is调试 || Singleton<全局变量类>.I.验证client.授权配置.Is定制异兽)
		{
			return Singleton<全局变量类>.I.异兽录配置.定制功能开关;
		}
		return false;
	}

	
	[SpecialName]
	internal static bool wGmslE7YU3()
	{
		if (!C9dsD7Vloy())
		{
			return Singleton<全局变量类>.I.异兽录配置.功能开关;
		}
		return true;
	}

	
	internal void OpkdqqPm9l()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("异兽录配置类.json")))
			{
				Singleton<全局变量类>.I.异兽录配置 = JsonConvert.DeserializeObject<异兽录配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("异兽录配置类.json")));
				f1esfGQQpj.Clear();
				W5hsNnYAjN.Clear();
				T6gsiwMmCv.Clear();
				iFLsBvoaBy.Clear();
				Q1xsG3Fx3O.Clear();
				foreach (异兽录图鉴列表类 value in Singleton<全局变量类>.I.异兽录配置.图鉴列表.Values)
				{
					switch (value.所属分类)
					{
					case AllEnums.异兽Type.御灵:
						f1esfGQQpj.TryAdd(value.宠物名字, value);
						break;
					case AllEnums.异兽Type.变异:
						W5hsNnYAjN.TryAdd(value.宠物名字, value);
						break;
					case AllEnums.异兽Type.神兽:
						T6gsiwMmCv.TryAdd(value.宠物名字, value);
						break;
					case AllEnums.异兽Type.元灵:
						iFLsBvoaBy.TryAdd(value.宠物名字, value);
						break;
					case AllEnums.异兽Type.仙元:
						Q1xsG3Fx3O.TryAdd(value.宠物名字, value);
						break;
					}
				}
			}
			else
			{
				Singleton<全局变量类>.I.异兽录配置 = new 异兽录配置类();
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("异兽录配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.异兽录配置, Formatting.Indented));
			}
			rO2dArEE5i();
		}
		catch (Exception ex)
		{
			Log.Error("异兽录配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void Iw4drR3GtU()
	{
		try
		{
			f1esfGQQpj.Clear();
			W5hsNnYAjN.Clear();
			T6gsiwMmCv.Clear();
			iFLsBvoaBy.Clear();
			Q1xsG3Fx3O.Clear();
			foreach (异兽录图鉴列表类 value in Singleton<全局变量类>.I.异兽录配置.图鉴列表.Values)
			{
				switch (value.所属分类)
				{
				case AllEnums.异兽Type.御灵:
					f1esfGQQpj.TryAdd(value.宠物名字, value);
					break;
				case AllEnums.异兽Type.变异:
					W5hsNnYAjN.TryAdd(value.宠物名字, value);
					break;
				case AllEnums.异兽Type.神兽:
					T6gsiwMmCv.TryAdd(value.宠物名字, value);
					break;
				case AllEnums.异兽Type.元灵:
					iFLsBvoaBy.TryAdd(value.宠物名字, value);
					break;
				case AllEnums.异兽Type.仙元:
					Q1xsG3Fx3O.TryAdd(value.宠物名字, value);
					break;
				}
			}
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("异兽录配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.异兽录配置, Formatting.Indented));
			Log.Debug("异兽录配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("异兽录配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string OCfdZSboSF()
	{
		OpkdqqPm9l();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.异兽录配置, Formatting.Indented);
	}

	
	public void dcidtIYJfS(string P_0)
	{
		Singleton<全局变量类>.I.异兽录配置 = JsonConvert.DeserializeObject<异兽录配置类>(P_0);
		Iw4drR3GtU();
	}

	
	public void rO2dArEE5i()
	{
		mRtsohUNC2 = (wGmslE7YU3() ? Singleton<WdAPI>.I.组包假NPC站街(Singleton<全局变量类>.I.异兽录配置.NPC数据, 103) : Array.Empty<byte>());
	}

	
	internal void gMQdzSPHss(MyNATSocketClient P_0)
	{
		try
		{
			if (!C9dsD7Vloy() && P_0.user.属性数据.剩余相性 != 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("角色有相性点尚未使用，无法使用异兽录图鉴功能！"));
				return;
			}
			aNqsIXvjFq.Clear();
			aNqsIXvjFq.Append("吾乃上古人族，耗费千年炼成一法宝，名为异兽录，可收录天下的奇珍异兽，增强自身战力，今日与你有缘，赠宝与你，望你好好利用此物，斩妖除魔，扬我人族之威！#r");
			if (wGmslE7YU3())
			{
				aNqsIXvjFq.Append("[【介绍】图鉴收录信息/异兽录操作_收录信息][【提交】图鉴收录异兽/异兽录操作_收录异兽][【属性】图鉴属性查询/异兽录操作_收录查询]");
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(Singleton<全局变量类>.I.异兽录配置.NPC数据.npcid, Singleton<全局变量类>.I.异兽录配置.NPC数据.npc形象, Singleton<全局变量类>.I.异兽录配置.NPC数据.npc名字, aNqsIXvjFq.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("NPC对话生成-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void JUesuc12a3(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_1 == "异兽录操作_收录信息")
			{
				oxWsb28y7Y(P_0);
			}
			else if (P_1 == "异兽录操作_收录异兽")
			{
				JrosJL6cL8(P_0);
			}
			else if (P_1.Contains("异兽录操作_提交", StringComparison.CurrentCulture))
			{
				BbksKH354D(P_0, P_1);
			}
			else if (P_1.Contains("异兽录操作_确定", StringComparison.CurrentCulture))
			{
				arwsRxOHjG(P_0, P_1);
			}
			else if (P_1.Contains("异兽录操作_收录查询", StringComparison.CurrentCulture))
			{
				if (!(P_1 == "异兽录操作_收录查询"))
				{
					if (!(P_1 == "异兽录操作_收录查询御灵"))
					{
						if (!(P_1 == "异兽录操作_收录查询变异"))
						{
							if (!(P_1 == "异兽录操作_收录查询神兽"))
							{
								if (!(P_1 == "异兽录操作_收录查询元灵"))
								{
									if (P_1 == "异兽录操作_收录查询仙元")
									{
										QWmsU6SGFr(P_0, AllEnums.异兽Type.仙元);
									}
								}
								else
								{
									QWmsU6SGFr(P_0, AllEnums.异兽Type.元灵);
								}
							}
							else
							{
								QWmsU6SGFr(P_0, AllEnums.异兽Type.神兽);
							}
						}
						else
						{
							QWmsU6SGFr(P_0, AllEnums.异兽Type.变异);
						}
					}
					else
					{
						QWmsU6SGFr(P_0, AllEnums.异兽Type.御灵);
					}
				}
				else
				{
					QWmsU6SGFr(P_0, AllEnums.异兽Type.御灵);
				}
			}
			else if (P_1.Contains("异兽录操作_使用特效道具", StringComparison.CurrentCulture))
			{
				TaCsgcwB2w(P_0, P_1.Replace("异兽录操作_使用特效道具", ""));
			}
		}
		catch (Exception ex)
		{
			Log.Error("异兽录对话点击处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void x1vswD7Ba4(MyNATSocketClient P_0, byte[] P_1)
	{
		try
		{
			if (P_0.user.人物数据.形象ID == 7008 || P_0.user.人物数据.形象ID == 7009)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("只有真身才能参与异兽录图鉴活动！"));
			}
			else if (!C9dsD7Vloy() && P_0.user.属性数据.剩余相性 != 0)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("你当前有剩余的相性点未分配，无法参与异兽录图鉴活动！"));
			}
			else if (Enumerable.SequenceEqual(P_1, new byte[4] { 0, 0, 3, 1 }) || Enumerable.SequenceEqual(P_1, new byte[4] { 0, 3, 0, 1 }))
			{
				oxWsb28y7Y(P_0);
			}
			else if (Enumerable.SequenceEqual(P_1, new byte[4] { 0, 0, 4, 0 }) || Enumerable.SequenceEqual(P_1, new byte[4] { 0, 4, 0, 0 }))
			{
				QWmsU6SGFr(P_0, AllEnums.异兽Type.御灵);
			}
			else if (Enumerable.SequenceEqual(P_1, new byte[4]))
			{
				JrosJL6cL8(P_0);
			}
		}
		catch (Exception ex)
		{
			Log.Error("异兽录对话处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void oxWsb28y7Y(MyNATSocketClient P_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder("异兽录中记载了每个宠物的图鉴信息，每成功收录一个宠物时，就会获得其对应的独特属性加成。并且当你把同一类型宠物收录齐全时还能获得额外属性加成，变得更强，下面是你的图鉴收录信息：#r");
			异兽录存档数据类 异兽录存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.异兽录数据.方案1 : P_0.user.存档数据.异兽录数据.方案2);
			if (!f1esfGQQpj.IsEmpty)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(17, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
				handler.AppendLiteral("图鉴收录进度（#Y");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[AllEnums.异兽Type.御灵].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(f1esfGQQpj.Count);
				handler.AppendLiteral("#G）#r");
				stringBuilder3.Append(ref handler);
			}
			if (!W5hsNnYAjN.IsEmpty)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(17, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
				handler.AppendLiteral("图鉴收录进度（#Y");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[AllEnums.异兽Type.变异].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(W5hsNnYAjN.Count);
				handler.AppendLiteral("#G）#r");
				stringBuilder4.Append(ref handler);
			}
			if (!T6gsiwMmCv.IsEmpty)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(17, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
				handler.AppendLiteral("图鉴收录进度（#Y");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[AllEnums.异兽Type.神兽].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(T6gsiwMmCv.Count);
				handler.AppendLiteral("#G）#r");
				stringBuilder5.Append(ref handler);
			}
			if (!iFLsBvoaBy.IsEmpty)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder6 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(17, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
				handler.AppendLiteral("图鉴收录进度（#Y");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[AllEnums.异兽Type.元灵].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(iFLsBvoaBy.Count);
				handler.AppendLiteral("#G）#r");
				stringBuilder6.Append(ref handler);
			}
			if (!Q1xsG3Fx3O.IsEmpty)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder7 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(17, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
				handler.AppendLiteral("图鉴收录进度（#Y");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[AllEnums.异兽Type.仙元].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(Q1xsG3Fx3O.Count);
				handler.AppendLiteral("#G）#r");
				stringBuilder7.Append(ref handler);
			}
			stringBuilder.Append("[【提交】图鉴收录异兽/异兽录操作_收录异兽][【属性】图鉴收录查询/异兽录操作_收录查询]");
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(103, Singleton<全局变量类>.I.异兽录配置.NPC数据.npc形象, Singleton<全局变量类>.I.异兽录配置.NPC数据.npc名字, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("异兽录_收录查询-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void JrosJL6cL8(MyNATSocketClient P_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder("#G下列是可以收录进异兽录图鉴的宠物，请选择你想要收录的宠物提交：#n");
			异兽录存档数据类 异兽录存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.异兽录数据.方案1 : P_0.user.存档数据.异兽录数据.方案2);
			for (int i = 0; i < P_0.user.宠物数据.Length; i++)
			{
				_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass20_0();
				if (P_0.user.宠物数据[i].PetID != 0 && Singleton<全局变量类>.I.异兽录配置.图鉴列表.TryGetValue(P_0.user.宠物数据[i].昵称B, out CS_0024_003C_003E8__locals7.QVvSQWktnJ) && 异兽录存档数据类2.收录列表.TryGetValue(CS_0024_003C_003E8__locals7.QVvSQWktnJ.所属分类, out var value) && !value.Any( (string a) => a == CS_0024_003C_003E8__locals7.QVvSQWktnJ.宠物名字) && !(P_0.user.宠物数据[i].昵称A != P_0.user.宠物数据[i].昵称B) && P_0.user.缓存数据.当前乘骑坐骑id != P_0.user.宠物数据[i].宠物ID && P_0.user.缓存数据.当前参战宠物id != P_0.user.宠物数据[i].宠物ID && P_0.user.缓存数据.当前掠阵宠物id != P_0.user.宠物数据[i].宠物ID)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(18, 5, stringBuilder2);
					handler.AppendLiteral("[");
					handler.AppendFormatted(P_0.user.宠物数据[i].昵称A);
					handler.AppendLiteral("（");
					handler.AppendFormatted(CS_0024_003C_003E8__locals7.QVvSQWktnJ.所属分类);
					handler.AppendLiteral("：");
					handler.AppendFormatted(C9dsD7Vloy() ? ((object)CS_0024_003C_003E8__locals7.QVvSQWktnJ.定制收录属性) : ((object)CS_0024_003C_003E8__locals7.QVvSQWktnJ.收录属性));
					handler.AppendLiteral(" ");
					handler.AppendFormatted(CS_0024_003C_003E8__locals7.QVvSQWktnJ.收录数值);
					handler.AppendLiteral(" 增加）/异兽录操作_提交");
					handler.AppendFormatted(P_0.user.宠物数据[i].宠物ID);
					handler.AppendLiteral("]");
					stringBuilder2.Append(ref handler);
				}
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(103, Singleton<全局变量类>.I.异兽录配置.NPC数据.npc形象, Singleton<全局变量类>.I.异兽录配置.NPC数据.npc名字, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("异兽录_提交查询-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void BbksKH354D(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass21_0();
			CS_0024_003C_003E8__locals8.LZ4SYW0wal = P_1.Replace("异兽录操作_提交", "");
			CS_0024_003C_003E8__locals8.t3HSpSxBJZ = P_0.user.宠物数据.ToList().Find( (宠物缓存数据类 a) => a.宠物ID.ToString() == CS_0024_003C_003E8__locals8.LZ4SYW0wal);
			if (CS_0024_003C_003E8__locals8.t3HSpSxBJZ != null)
			{
				异兽录存档数据类 异兽录存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.异兽录数据.方案1 : P_0.user.存档数据.异兽录数据.方案2);
				if (Singleton<全局变量类>.I.异兽录配置.图鉴列表.TryGetValue(CS_0024_003C_003E8__locals8.t3HSpSxBJZ.昵称B, out 异兽录图鉴列表类 value) && !异兽录存档数据类2.收录列表[value.所属分类].Any( (string a) => a == CS_0024_003C_003E8__locals8.t3HSpSxBJZ.昵称B))
				{
					WdAPI i = Singleton<WdAPI>.I;
					int 角色ID = P_0.user.人物数据.角色ID;
					int 形象ID = P_0.user.人物数据.形象ID;
					string 昵称 = P_0.user.人物数据.昵称;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 2);
					defaultInterpolatedStringHandler.AppendLiteral("[@确定/异兽录操作_确定");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals8.LZ4SYW0wal);
					defaultInterpolatedStringHandler.AppendLiteral("#DLG:1#prompt:你确定要将#Y");
					defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals8.t3HSpSxBJZ.昵称B);
					defaultInterpolatedStringHandler.AppendLiteral("#n收录到异兽录图鉴中吗？]");
					P_0.C_Send(i.组包确定框(角色ID, 形象ID, 昵称, defaultInterpolatedStringHandler.ToStringAndClear()));
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("异兽录_提交问询-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void arwsRxOHjG(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass22_0();
			int.TryParse(P_1.Replace("异兽录操作_确定", ""), out CS_0024_003C_003E8__locals8.BjvSHsNUfX);
			宠物缓存数据类 宠物缓存数据类2 = P_0.user.宠物数据.ToList().Find( (宠物缓存数据类 a) => CS_0024_003C_003E8__locals8.BjvSHsNUfX != 0 && a.宠物ID == CS_0024_003C_003E8__locals8.BjvSHsNUfX);
			if (宠物缓存数据类2.昵称A != 宠物缓存数据类2.昵称B || 宠物缓存数据类2 == null)
			{
				return;
			}
			if (P_0.user.缓存数据.当前乘骑坐骑id != 0 && 宠物缓存数据类2.宠物ID == P_0.user.缓存数据.当前乘骑坐骑id)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("乘骑中的宠物无法收录到异兽图鉴！"));
				return;
			}
			if (P_0.user.缓存数据.当前参战宠物id != 0 && 宠物缓存数据类2.宠物ID == P_0.user.缓存数据.当前参战宠物id)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("参战中的宠物无法收录到异兽图鉴！"));
				return;
			}
			if (P_0.user.缓存数据.当前掠阵宠物id != 0 && 宠物缓存数据类2.宠物ID == P_0.user.缓存数据.当前掠阵宠物id)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("掠阵中的宠物无法收录到异兽图鉴！"));
				return;
			}
			if (宠物缓存数据类2.绑定状态 != AllEnums.绑定Type.不绑定)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("只有可交易且不限时的宠物方可被收录！"));
				return;
			}
			异兽录存档数据类 异兽录存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.异兽录数据.方案1 : P_0.user.存档数据.异兽录数据.方案2);
			if (Singleton<全局变量类>.I.异兽录配置.图鉴列表.TryGetValue(宠物缓存数据类2.昵称B, out CS_0024_003C_003E8__locals8.UnKS4hn5Cl) && !异兽录存档数据类2.收录列表[CS_0024_003C_003E8__locals8.UnKS4hn5Cl.所属分类].Any( (string a) => a == CS_0024_003C_003E8__locals8.UnKS4hn5Cl.宠物名字))
			{
				P_0.S_Send(全局常量类.丢弃宠物包.Concat(Singleton<ByteAPI>.I.到字节集固定反转(CS_0024_003C_003E8__locals8.BjvSHsNUfX)).ToArray());
				y3Isd9VIwA(P_0, 异兽录存档数据类2, CS_0024_003C_003E8__locals8.UnKS4hn5Cl);
			}
		}
		catch (Exception ex)
		{
			Log.Error("异兽录_提交确定-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void y3Isd9VIwA(MyNATSocketClient P_0, 异兽录存档数据类 P_1, 异兽录图鉴列表类 P_2)
	{
		try
		{
			if (C9dsD7Vloy())
			{
				WG4ssKushe(P_0, P_1, P_2);
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			P_1.收录列表[P_2.所属分类].Add(P_2.宠物名字);
			Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, (AllEnums.指令Type)P_2.收录属性, P_2.收录数值, false, "[异兽录]属性增加");
			int count = P_1.收录列表[P_2.所属分类].Count;
			switch (P_2.所属分类)
			{
			case AllEnums.异兽Type.御灵:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 4, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(P_2.宠物名字);
				handler.AppendLiteral("#n已经收录到【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
				handler.AppendLiteral("图鉴】中，激活了#G");
				handler.AppendFormatted(P_2.收录属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_2.收录数值);
				handler.AppendLiteral(" 增加#n属性！");
				stringBuilder5.Append(ref handler);
				if (count == f1esfGQQpj.Count && Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值 > 0)
				{
					P_1.分类圆满状态[P_2.所属分类] = true;
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, (AllEnums.指令Type)Singleton<全局变量类>.I.异兽录配置.御灵圆满附加属性, Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值, false, "[异兽录]属性增加");
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(41, 3, stringBuilder2);
					handler.AppendLiteral("#r恭喜你，#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
					handler.AppendLiteral("图鉴#n中的所有异兽已全部激活，激活了额外的#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值);
					handler.AppendLiteral(" 增加#n属性！");
					stringBuilder6.Append(ref handler);
				}
				break;
			}
			case AllEnums.异兽Type.变异:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder11 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 4, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(P_2.宠物名字);
				handler.AppendLiteral("#n已经收录到【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
				handler.AppendLiteral("图鉴】中，激活了#G");
				handler.AppendFormatted(P_2.收录属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_2.收录数值);
				handler.AppendLiteral(" 增加#n属性！");
				stringBuilder11.Append(ref handler);
				if (count == W5hsNnYAjN.Count && Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值 > 0)
				{
					P_1.分类圆满状态[P_2.所属分类] = true;
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, (AllEnums.指令Type)Singleton<全局变量类>.I.异兽录配置.变异圆满附加属性, Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值, false, "[异兽录]属性增加");
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder12 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(41, 3, stringBuilder2);
					handler.AppendLiteral("#r恭喜你，#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
					handler.AppendLiteral("图鉴#n中的所有异兽已全部激活，激活了额外的#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值);
					handler.AppendLiteral(" 增加#n属性！");
					stringBuilder12.Append(ref handler);
				}
				break;
			}
			case AllEnums.异兽Type.神兽:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder7 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 4, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(P_2.宠物名字);
				handler.AppendLiteral("#n已经收录到【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
				handler.AppendLiteral("图鉴】中，激活了#G");
				handler.AppendFormatted(P_2.收录属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_2.收录数值);
				handler.AppendLiteral(" 增加#n属性！");
				stringBuilder7.Append(ref handler);
				if (count == T6gsiwMmCv.Count && Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值 > 0)
				{
					P_1.分类圆满状态[P_2.所属分类] = true;
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, (AllEnums.指令Type)Singleton<全局变量类>.I.异兽录配置.神兽圆满附加属性, Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值, false, "[异兽录]属性增加");
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(41, 3, stringBuilder2);
					handler.AppendLiteral("#r恭喜你，#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
					handler.AppendLiteral("图鉴#n中的所有异兽已全部激活，激活了额外的#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值);
					handler.AppendLiteral(" 增加#n属性！");
					stringBuilder8.Append(ref handler);
				}
				break;
			}
			case AllEnums.异兽Type.元灵:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder9 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 4, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(P_2.宠物名字);
				handler.AppendLiteral("#n已经收录到【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
				handler.AppendLiteral("图鉴】中，激活了#G");
				handler.AppendFormatted(P_2.收录属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_2.收录数值);
				handler.AppendLiteral(" 增加#n属性！");
				stringBuilder9.Append(ref handler);
				if (count == iFLsBvoaBy.Count && Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值 > 0)
				{
					P_1.分类圆满状态[P_2.所属分类] = true;
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, (AllEnums.指令Type)Singleton<全局变量类>.I.异兽录配置.元灵圆满附加属性, Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值, false, "[异兽录]属性增加");
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder10 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(41, 3, stringBuilder2);
					handler.AppendLiteral("#r恭喜你，#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
					handler.AppendLiteral("图鉴#n中的所有异兽已全部激活，激活了额外的#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值);
					handler.AppendLiteral(" 增加#n属性！");
					stringBuilder10.Append(ref handler);
				}
				break;
			}
			case AllEnums.异兽Type.仙元:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 4, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(P_2.宠物名字);
				handler.AppendLiteral("#n已经收录到【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
				handler.AppendLiteral("图鉴】中，激活了#G");
				handler.AppendFormatted(P_2.收录属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_2.收录数值);
				handler.AppendLiteral(" 增加#n属性！");
				stringBuilder3.Append(ref handler);
				if (count == Q1xsG3Fx3O.Count && Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值 > 0)
				{
					P_1.分类圆满状态[P_2.所属分类] = true;
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.数值, string.Empty, (AllEnums.指令Type)Singleton<全局变量类>.I.异兽录配置.仙元圆满附加属性, Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值, false, "[异兽录]属性增加");
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(41, 3, stringBuilder2);
					handler.AppendLiteral("#r恭喜你，#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
					handler.AppendLiteral("图鉴#n中的所有异兽已全部激活，激活了额外的#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值);
					handler.AppendLiteral(" 增加#n属性！");
					stringBuilder4.Append(ref handler);
				}
				break;
			}
			}
			P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(stringBuilder.ToString()));
			if (P_1.分类圆满状态.All( (KeyValuePair<AllEnums.异兽Type, bool> x) => x.Value))
			{
				Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息("#24#Y恭喜大佬#G" + P_0.user.人物数据.昵称 + "#Y的异兽录图鉴全部收录齐全，简直太牛逼了，快去天墉城找#P异兽尊者#P参与异兽录活动吧！", "管理员"));
			}
		}
		catch (Exception ex)
		{
			Log.Error("执行添加到异兽录存档-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void WG4ssKushe(MyNATSocketClient P_0, 异兽录存档数据类 P_1, 异兽录图鉴列表类 P_2)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			P_1.收录列表[P_2.所属分类].Add(P_2.宠物名字);
			List<string[]> list = new List<string[]>();
			P_0.user.存档数据.中州论道存档.jxpIgn1imh(P_2.定制收录属性, P_2.收录数值, out var text);
			string[] array = new string[2];
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler.AppendLiteral("prop/");
			defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)P_2.定制收录属性);
			array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
			array[1] = text;
			list.Add(array);
			int count = P_1.收录列表[P_2.所属分类].Count;
			switch (P_2.所属分类)
			{
			case AllEnums.异兽Type.御灵:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 4, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(P_2.宠物名字);
				handler.AppendLiteral("#n已经收录到【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
				handler.AppendLiteral("图鉴】中，激活了#G");
				handler.AppendFormatted(P_2.定制收录属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_2.收录数值);
				handler.AppendLiteral(" 增加#n属性！");
				stringBuilder5.Append(ref handler);
				if (count == f1esfGQQpj.Count && Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值 > 0)
				{
					P_1.分类圆满状态[P_2.所属分类] = true;
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.异兽录配置.定制御灵圆满附加属性, Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值, out var text3);
					string[] array3 = new string[2];
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.异兽录配置.定制御灵圆满附加属性);
					array3[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array3[1] = text3;
					list.Add(array3);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(41, 3, stringBuilder2);
					handler.AppendLiteral("#r恭喜你，#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
					handler.AppendLiteral("图鉴#n中的所有异兽已全部激活，激活了额外的#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.定制御灵圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值);
					handler.AppendLiteral(" 增加#n属性！");
					stringBuilder6.Append(ref handler);
				}
				break;
			}
			case AllEnums.异兽Type.变异:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder11 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 4, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(P_2.宠物名字);
				handler.AppendLiteral("#n已经收录到【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
				handler.AppendLiteral("图鉴】中，激活了#G");
				handler.AppendFormatted(P_2.定制收录属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_2.收录数值);
				handler.AppendLiteral(" 增加#n属性！");
				stringBuilder11.Append(ref handler);
				if (count == W5hsNnYAjN.Count && Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值 > 0)
				{
					P_1.分类圆满状态[P_2.所属分类] = true;
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.异兽录配置.定制变异圆满附加属性, Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值, out var text6);
					string[] array6 = new string[2];
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.异兽录配置.定制变异圆满附加属性);
					array6[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array6[1] = text6;
					list.Add(array6);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder12 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(41, 3, stringBuilder2);
					handler.AppendLiteral("#r恭喜你，#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
					handler.AppendLiteral("图鉴#n中的所有异兽已全部激活，激活了额外的#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.定制变异圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值);
					handler.AppendLiteral(" 增加#n属性！");
					stringBuilder12.Append(ref handler);
				}
				break;
			}
			case AllEnums.异兽Type.神兽:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder7 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 4, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(P_2.宠物名字);
				handler.AppendLiteral("#n已经收录到【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
				handler.AppendLiteral("图鉴】中，激活了#G");
				handler.AppendFormatted(P_2.定制收录属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_2.收录数值);
				handler.AppendLiteral(" 增加#n属性！");
				stringBuilder7.Append(ref handler);
				if (count == T6gsiwMmCv.Count && Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值 > 0)
				{
					P_1.分类圆满状态[P_2.所属分类] = true;
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.异兽录配置.定制神兽圆满附加属性, Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值, out var text4);
					string[] array4 = new string[2];
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.异兽录配置.定制神兽圆满附加属性);
					array4[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array4[1] = text4;
					list.Add(array4);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(41, 3, stringBuilder2);
					handler.AppendLiteral("#r恭喜你，#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
					handler.AppendLiteral("图鉴#n中的所有异兽已全部激活，激活了额外的#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.定制神兽圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值);
					handler.AppendLiteral(" 增加#n属性！");
					stringBuilder8.Append(ref handler);
				}
				break;
			}
			case AllEnums.异兽Type.元灵:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder9 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 4, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(P_2.宠物名字);
				handler.AppendLiteral("#n已经收录到【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
				handler.AppendLiteral("图鉴】中，激活了#G");
				handler.AppendFormatted(P_2.定制收录属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_2.收录数值);
				handler.AppendLiteral(" 增加#n属性！");
				stringBuilder9.Append(ref handler);
				if (count == iFLsBvoaBy.Count && Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值 > 0)
				{
					P_1.分类圆满状态[P_2.所属分类] = true;
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.异兽录配置.定制元灵圆满附加属性, Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值, out var text5);
					string[] array5 = new string[2];
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.异兽录配置.定制元灵圆满附加属性);
					array5[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array5[1] = text5;
					list.Add(array5);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder10 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(41, 3, stringBuilder2);
					handler.AppendLiteral("#r恭喜你，#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
					handler.AppendLiteral("图鉴#n中的所有异兽已全部激活，激活了额外的#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.定制元灵圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值);
					handler.AppendLiteral(" 增加#n属性！");
					stringBuilder10.Append(ref handler);
				}
				break;
			}
			case AllEnums.异兽Type.仙元:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(29, 4, stringBuilder2);
				handler.AppendLiteral("#Y");
				handler.AppendFormatted(P_2.宠物名字);
				handler.AppendLiteral("#n已经收录到【");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
				handler.AppendLiteral("图鉴】中，激活了#G");
				handler.AppendFormatted(P_2.定制收录属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_2.收录数值);
				handler.AppendLiteral(" 增加#n属性！");
				stringBuilder3.Append(ref handler);
				if (count == Q1xsG3Fx3O.Count && Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值 > 0)
				{
					P_1.分类圆满状态[P_2.所属分类] = true;
					P_0.user.存档数据.中州论道存档.jxpIgn1imh(Singleton<全局变量类>.I.异兽录配置.定制仙元圆满附加属性, Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值, out var text2);
					string[] array2 = new string[2];
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("prop/");
					defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)Singleton<全局变量类>.I.异兽录配置.定制仙元圆满附加属性);
					array2[0] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[1] = text2;
					list.Add(array2);
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(41, 3, stringBuilder2);
					handler.AppendLiteral("#r恭喜你，#Y");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
					handler.AppendLiteral("图鉴#n中的所有异兽已全部激活，激活了额外的#G");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.定制仙元圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值);
					handler.AppendLiteral(" 增加#n属性！");
					stringBuilder4.Append(ref handler);
				}
				break;
			}
			}
			Singleton<fuMNpgieFTYU3Wah53>.I.mMMfZ3LX2(P_0, list);
			P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告(stringBuilder.ToString()));
			if (P_1.分类圆满状态.All( (KeyValuePair<AllEnums.异兽Type, bool> x) => x.Value))
			{
				Singleton<全局变量类>.I.Client频道事件?.Invoke(Singleton<WdAPI>.I.组包聊天信息("#24#Y恭喜大佬#G" + P_0.user.人物数据.昵称 + "#Y的异兽录图鉴全部收录齐全，简直太牛逼了，快去天墉城找#P异兽尊者#P参与异兽录活动吧！", "管理员"));
			}
		}
		catch (Exception ex)
		{
			Log.Error("执行添加到异兽录存档-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void QWmsU6SGFr(MyNATSocketClient P_0, AllEnums.异兽Type P_1)
	{
		try
		{
			if (C9dsD7Vloy())
			{
				me4sWIdxPE(P_0, P_1);
				return;
			}
			StringBuilder stringBuilder = new StringBuilder("当前异兽录图鉴已收录图鉴及属性加成（加点方案" + (P_0.user.缓存数据.is加点方案一 ? "一" : "二") + "）：#r");
			异兽录存档数据类 异兽录存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.异兽录数据.方案1 : P_0.user.存档数据.异兽录数据.方案2);
			switch (P_1)
			{
			case AllEnums.异兽Type.御灵:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
				handler.AppendLiteral("收录（");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[P_1].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(f1esfGQQpj.Count);
				handler.AppendLiteral("）：#n#r");
				stringBuilder5.Append(ref handler);
				if (异兽录存档数据类2.分类圆满状态[P_1])
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
					handler.AppendLiteral("图鉴收录齐全（#L");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值);
					handler.AppendLiteral(" 增加）#r");
					stringBuilder6.Append(ref handler);
				}
				break;
			}
			case AllEnums.异兽Type.变异:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder9 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
				handler.AppendLiteral("收录（");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[P_1].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(W5hsNnYAjN.Count);
				handler.AppendLiteral("）：#n#r");
				stringBuilder9.Append(ref handler);
				if (异兽录存档数据类2.分类圆满状态[P_1])
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder10 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
					handler.AppendLiteral("图鉴收录齐全（#L");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值);
					handler.AppendLiteral(" 增加）#r");
					stringBuilder10.Append(ref handler);
				}
				break;
			}
			case AllEnums.异兽Type.神兽:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder11 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
				handler.AppendLiteral("收录（");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[P_1].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(T6gsiwMmCv.Count);
				handler.AppendLiteral("）：#n#r");
				stringBuilder11.Append(ref handler);
				if (异兽录存档数据类2.分类圆满状态[P_1])
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder12 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
					handler.AppendLiteral("图鉴收录齐全（#L");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值);
					handler.AppendLiteral(" 增加）#r");
					stringBuilder12.Append(ref handler);
				}
				break;
			}
			case AllEnums.异兽Type.元灵:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder7 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
				handler.AppendLiteral("收录（");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[P_1].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(iFLsBvoaBy.Count);
				handler.AppendLiteral("）：#n#r");
				stringBuilder7.Append(ref handler);
				if (异兽录存档数据类2.分类圆满状态[P_1])
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
					handler.AppendLiteral("图鉴收录齐全（#L");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值);
					handler.AppendLiteral(" 增加）#r");
					stringBuilder8.Append(ref handler);
				}
				break;
			}
			case AllEnums.异兽Type.仙元:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
				handler.AppendLiteral("收录（");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[P_1].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(Q1xsG3Fx3O.Count);
				handler.AppendLiteral("）：#n#r");
				stringBuilder3.Append(ref handler);
				if (异兽录存档数据类2.分类圆满状态[P_1])
				{
					stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					handler = new StringBuilder.AppendInterpolatedStringHandler(16, 3, stringBuilder2);
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
					handler.AppendLiteral("图鉴收录齐全（#L");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元圆满附加属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值);
					handler.AppendLiteral(" 增加）#r");
					stringBuilder4.Append(ref handler);
				}
				break;
			}
			}
			foreach (string item in 异兽录存档数据类2.收录列表[P_1])
			{
				if (Singleton<全局变量类>.I.异兽录配置.图鉴列表.TryGetValue(item, out 异兽录图鉴列表类 value))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder13 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(14, 3, stringBuilder2);
					handler.AppendLiteral("#Y");
					handler.AppendFormatted(item);
					handler.AppendLiteral("（#L");
					handler.AppendFormatted(value.收录属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(value.收录数值);
					handler.AppendLiteral(" 增加#Y）#r");
					stringBuilder13.Append(ref handler);
				}
			}
			switch (P_1)
			{
			case AllEnums.异兽Type.御灵:
				if (!W5hsNnYAjN.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder30 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询变异]");
					stringBuilder30.Append(ref handler);
				}
				if (!T6gsiwMmCv.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder31 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询神兽]");
					stringBuilder31.Append(ref handler);
				}
				if (!iFLsBvoaBy.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder32 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询元灵]");
					stringBuilder32.Append(ref handler);
				}
				if (!Q1xsG3Fx3O.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder33 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询仙元]");
					stringBuilder33.Append(ref handler);
				}
				break;
			case AllEnums.异兽Type.变异:
				if (!f1esfGQQpj.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder18 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询御灵]");
					stringBuilder18.Append(ref handler);
				}
				if (!T6gsiwMmCv.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder19 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询神兽]");
					stringBuilder19.Append(ref handler);
				}
				if (!iFLsBvoaBy.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder20 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询元灵]");
					stringBuilder20.Append(ref handler);
				}
				if (!Q1xsG3Fx3O.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder21 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询仙元]");
					stringBuilder21.Append(ref handler);
				}
				break;
			case AllEnums.异兽Type.神兽:
				if (!f1esfGQQpj.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder22 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询御灵]");
					stringBuilder22.Append(ref handler);
				}
				if (!W5hsNnYAjN.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder23 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询变异]");
					stringBuilder23.Append(ref handler);
				}
				if (!iFLsBvoaBy.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder24 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询元灵]");
					stringBuilder24.Append(ref handler);
				}
				if (!Q1xsG3Fx3O.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder25 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询仙元]");
					stringBuilder25.Append(ref handler);
				}
				break;
			case AllEnums.异兽Type.元灵:
				if (!f1esfGQQpj.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder26 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询御灵]");
					stringBuilder26.Append(ref handler);
				}
				if (!W5hsNnYAjN.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder27 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询变异]");
					stringBuilder27.Append(ref handler);
				}
				if (!T6gsiwMmCv.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder28 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询神兽]");
					stringBuilder28.Append(ref handler);
				}
				if (!Q1xsG3Fx3O.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder29 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询仙元]");
					stringBuilder29.Append(ref handler);
				}
				break;
			case AllEnums.异兽Type.仙元:
				if (!f1esfGQQpj.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder14 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询御灵]");
					stringBuilder14.Append(ref handler);
				}
				if (!W5hsNnYAjN.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder15 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询变异]");
					stringBuilder15.Append(ref handler);
				}
				if (!T6gsiwMmCv.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder16 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询神兽]");
					stringBuilder16.Append(ref handler);
				}
				if (!iFLsBvoaBy.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder17 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询元灵]");
					stringBuilder17.Append(ref handler);
				}
				break;
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(103, Singleton<全局变量类>.I.异兽录配置.NPC数据.npc形象, Singleton<全局变量类>.I.异兽录配置.NPC数据.npc名字, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("异兽录_属性查询-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private void me4sWIdxPE(MyNATSocketClient P_0, AllEnums.异兽Type P_1)
	{
		_003C_003Ec__DisplayClass26_0 CS_0024_003C_003E8__locals21 = new _003C_003Ec__DisplayClass26_0();
		CS_0024_003C_003E8__locals21.qw1SqbdEkU = P_1;
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			异兽录存档数据类 异兽录存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.异兽录数据.方案1 : P_0.user.存档数据.异兽录数据.方案2);
			switch (CS_0024_003C_003E8__locals21.qw1SqbdEkU)
			{
			case AllEnums.异兽Type.御灵:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
				handler.AppendLiteral("收录（");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[CS_0024_003C_003E8__locals21.qw1SqbdEkU].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(f1esfGQQpj.Count);
				handler.AppendLiteral("）：#n#r");
				stringBuilder5.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder6 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(18, 4, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
				handler.AppendLiteral("图鉴收录齐全");
				handler.AppendFormatted(异兽录存档数据类2.分类圆满状态[CS_0024_003C_003E8__locals21.qw1SqbdEkU] ? "#L" : "#D");
				handler.AppendLiteral("（");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.定制御灵圆满附加属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值);
				handler.AppendLiteral(" 增加）#n#r");
				stringBuilder6.Append(ref handler);
				break;
			}
			case AllEnums.异兽Type.变异:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder9 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
				handler.AppendLiteral("收录（");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[CS_0024_003C_003E8__locals21.qw1SqbdEkU].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(W5hsNnYAjN.Count);
				handler.AppendLiteral("）：#n#r");
				stringBuilder9.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder10 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(20, 4, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
				handler.AppendLiteral("图鉴收录齐全 ");
				handler.AppendFormatted(异兽录存档数据类2.分类圆满状态[CS_0024_003C_003E8__locals21.qw1SqbdEkU] ? "#L" : "#D");
				handler.AppendLiteral(" （");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.定制变异圆满附加属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值);
				handler.AppendLiteral(" 增加）#n#r");
				stringBuilder10.Append(ref handler);
				break;
			}
			case AllEnums.异兽Type.神兽:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder7 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
				handler.AppendLiteral("收录（");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[CS_0024_003C_003E8__locals21.qw1SqbdEkU].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(T6gsiwMmCv.Count);
				handler.AppendLiteral("）：#n#r");
				stringBuilder7.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder8 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(18, 4, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
				handler.AppendLiteral("图鉴收录齐全");
				handler.AppendFormatted(异兽录存档数据类2.分类圆满状态[CS_0024_003C_003E8__locals21.qw1SqbdEkU] ? "#L" : "#D");
				handler.AppendLiteral("（");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.定制神兽圆满附加属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值);
				handler.AppendLiteral(" 增加）#n#r");
				stringBuilder8.Append(ref handler);
				break;
			}
			case AllEnums.异兽Type.元灵:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder11 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
				handler.AppendLiteral("收录（");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[CS_0024_003C_003E8__locals21.qw1SqbdEkU].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(iFLsBvoaBy.Count);
				handler.AppendLiteral("）：#n#r");
				stringBuilder11.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder12 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(18, 4, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
				handler.AppendLiteral("图鉴收录齐全");
				handler.AppendFormatted(异兽录存档数据类2.分类圆满状态[CS_0024_003C_003E8__locals21.qw1SqbdEkU] ? "#L" : "#D");
				handler.AppendLiteral("（");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.定制元灵圆满附加属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值);
				handler.AppendLiteral(" 增加）#n#r");
				stringBuilder12.Append(ref handler);
				break;
			}
			case AllEnums.异兽Type.仙元:
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 3, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
				handler.AppendLiteral("收录（");
				handler.AppendFormatted(异兽录存档数据类2.收录列表[CS_0024_003C_003E8__locals21.qw1SqbdEkU].Count);
				handler.AppendLiteral("/");
				handler.AppendFormatted(Q1xsG3Fx3O.Count);
				handler.AppendLiteral("）：#n#r");
				stringBuilder3.Append(ref handler);
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(19, 4, stringBuilder2);
				handler.AppendLiteral("#G");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
				handler.AppendLiteral("图鉴收录齐全 ");
				handler.AppendFormatted(异兽录存档数据类2.分类圆满状态[CS_0024_003C_003E8__locals21.qw1SqbdEkU] ? "#L" : "#D");
				handler.AppendLiteral("（");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.定制仙元圆满附加属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值);
				handler.AppendLiteral(" 增加）#n#r");
				stringBuilder4.Append(ref handler);
				break;
			}
			}
			List<异兽录图鉴列表类> list = Singleton<全局变量类>.I.异兽录配置.图鉴列表.Values.ToList().FindAll( (异兽录图鉴列表类 x) => x.所属分类 == CS_0024_003C_003E8__locals21.qw1SqbdEkU);
			List<string> source = 异兽录存档数据类2.收录列表[CS_0024_003C_003E8__locals21.qw1SqbdEkU];
			using (List<异兽录图鉴列表类>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass26_1 CS_0024_003C_003E8__locals22 = new _003C_003Ec__DisplayClass26_1();
					CS_0024_003C_003E8__locals22.KVPSZhtany = enumerator.Current;
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder13 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(6, 3, stringBuilder2);
					handler.AppendFormatted(source.Any( (string x) => x == CS_0024_003C_003E8__locals22.KVPSZhtany.宠物名字) ? ("#Y【" + CS_0024_003C_003E8__locals22.KVPSZhtany.宠物名字 + " - 已收录】") : ("#D【" + CS_0024_003C_003E8__locals22.KVPSZhtany.宠物名字 + " - 未收录】"));
					handler.AppendFormatted(CS_0024_003C_003E8__locals22.KVPSZhtany.定制收录属性);
					handler.AppendLiteral(" ");
					handler.AppendFormatted(CS_0024_003C_003E8__locals22.KVPSZhtany.收录数值);
					handler.AppendLiteral(" 增加#r");
					stringBuilder13.Append(ref handler);
				}
			}
			switch (CS_0024_003C_003E8__locals21.qw1SqbdEkU)
			{
			case AllEnums.异兽Type.御灵:
				if (!W5hsNnYAjN.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder30 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询变异]");
					stringBuilder30.Append(ref handler);
				}
				if (!T6gsiwMmCv.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder31 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询神兽]");
					stringBuilder31.Append(ref handler);
				}
				if (!iFLsBvoaBy.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder32 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询元灵]");
					stringBuilder32.Append(ref handler);
				}
				if (!Q1xsG3Fx3O.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder33 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询仙元]");
					stringBuilder33.Append(ref handler);
				}
				break;
			case AllEnums.异兽Type.变异:
				if (!f1esfGQQpj.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder18 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询御灵]");
					stringBuilder18.Append(ref handler);
				}
				if (!T6gsiwMmCv.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder19 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询神兽]");
					stringBuilder19.Append(ref handler);
				}
				if (!iFLsBvoaBy.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder20 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询元灵]");
					stringBuilder20.Append(ref handler);
				}
				if (!Q1xsG3Fx3O.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder21 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询仙元]");
					stringBuilder21.Append(ref handler);
				}
				break;
			case AllEnums.异兽Type.神兽:
				if (!f1esfGQQpj.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder22 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询御灵]");
					stringBuilder22.Append(ref handler);
				}
				if (!W5hsNnYAjN.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder23 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询变异]");
					stringBuilder23.Append(ref handler);
				}
				if (!iFLsBvoaBy.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder24 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询元灵]");
					stringBuilder24.Append(ref handler);
				}
				if (!Q1xsG3Fx3O.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder25 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询仙元]");
					stringBuilder25.Append(ref handler);
				}
				break;
			case AllEnums.异兽Type.元灵:
				if (!f1esfGQQpj.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder26 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询御灵]");
					stringBuilder26.Append(ref handler);
				}
				if (!W5hsNnYAjN.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder27 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询变异]");
					stringBuilder27.Append(ref handler);
				}
				if (!T6gsiwMmCv.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder28 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询神兽]");
					stringBuilder28.Append(ref handler);
				}
				if (!Q1xsG3Fx3O.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder29 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.仙元别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询仙元]");
					stringBuilder29.Append(ref handler);
				}
				break;
			case AllEnums.异兽Type.仙元:
				if (!f1esfGQQpj.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder14 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.御灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询御灵]");
					stringBuilder14.Append(ref handler);
				}
				if (!W5hsNnYAjN.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder15 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.变异别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询变异]");
					stringBuilder15.Append(ref handler);
				}
				if (!T6gsiwMmCv.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder16 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.神兽别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询神兽]");
					stringBuilder16.Append(ref handler);
				}
				if (!iFLsBvoaBy.IsEmpty)
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder17 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(23, 1, stringBuilder2);
					handler.AppendLiteral("[【");
					handler.AppendFormatted(Singleton<全局变量类>.I.异兽录配置.元灵别称);
					handler.AppendLiteral("】图鉴收录查询/异兽录操作_收录查询元灵]");
					stringBuilder17.Append(ref handler);
				}
				break;
			}
			P_0.C_Send(Singleton<WdAPI>.I.对话生成_NPC(103, Singleton<全局变量类>.I.异兽录配置.NPC数据.npc形象, Singleton<全局变量类>.I.异兽录配置.NPC数据.npc名字, stringBuilder.ToString()));
		}
		catch (Exception ex)
		{
			Log.Error("异兽录_属性查询-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void TaCsgcwB2w(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (!int.TryParse(P_1, out var result) || !Singleton<WdAPI>.I.QSgoJ8DvVe(P_0, result))
			{
				return;
			}
			if (Singleton<WdAPI>.I.取背包剩余空格数(P_0) < 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的背包已满，无法使用。"));
				return;
			}
			if (!Singleton<WdAPI>.I.dSCoKmGWP9(P_0))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R你的宠物栏已满，无法使用。"));
				return;
			}
			异兽录存档数据类 异兽录存档数据类2 = (P_0.user.缓存数据.is加点方案一 ? P_0.user.存档数据.异兽录数据.方案1 : P_0.user.存档数据.异兽录数据.方案2);
			if (异兽录存档数据类2.分类圆满状态.All( (KeyValuePair<AllEnums.异兽Type, bool> x) => x.Value))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("当前加点方案的所有异兽录图鉴已经收录齐全，无法重复收录！"));
				return;
			}
			P_0.S_Send(Singleton<WdAPI>.I.naeodnd6MY(result));
			if (Singleton<全局变量类>.I.异兽录配置.图鉴列表.IsEmpty)
			{
				return;
			}
			using IEnumerator<异兽录图鉴列表类> enumerator = Singleton<全局变量类>.I.异兽录配置.图鉴列表.Values.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass27_0();
				CS_0024_003C_003E8__locals4.fIbSAFBkCX = enumerator.Current;
				if (!异兽录存档数据类2.收录列表[CS_0024_003C_003E8__locals4.fIbSAFBkCX.所属分类].Any( (string x) => x == CS_0024_003C_003E8__locals4.fIbSAFBkCX.宠物名字))
				{
					y3Isd9VIwA(P_0, 异兽录存档数据类2, CS_0024_003C_003E8__locals4.fIbSAFBkCX);
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("使用特效道具处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public iRGieud4qtscW6ESmxk()
	{
		aNqsIXvjFq = new StringBuilder();
		W5hsNnYAjN = new ConcurrentDictionary<string, 异兽录图鉴列表类>();
		T6gsiwMmCv = new ConcurrentDictionary<string, 异兽录图鉴列表类>();
		iFLsBvoaBy = new ConcurrentDictionary<string, 异兽录图鉴列表类>();
		Q1xsG3Fx3O = new ConcurrentDictionary<string, 异兽录图鉴列表类>();
		f1esfGQQpj = new ConcurrentDictionary<string, 异兽录图鉴列表类>();
	}

	static iRGieud4qtscW6ESmxk()
	{
	}
}
