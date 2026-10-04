using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft_X.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace htk7ADBGgMdoyiK2inI;

internal class wki1dRBBTGa2CXII175 : Singleton<wki1dRBBTGa2CXII175>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public 注册信息 ivHaU6M6PV;

		
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		
		internal bool T0Was6rAJU(注册信息 x)
		{
			return x.账号 == ivHaU6M6PV.账号;
		}

		static _003C_003Ec__DisplayClass4_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public int qCsagE7KhQ;

		
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		
		internal bool jtPaWuc08N(合区记录列表 x)
		{
			if (x.类型值)
			{
				return x.旧值 == $"{qCsagE7KhQ}";
			}
			return false;
		}

		static _003C_003Ec__DisplayClass5_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public 注册信息 JL8aji33de;

		
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		
		internal bool Lg5aDVnMbg(合区记录列表 x)
		{
			if (!x.类型值)
			{
				return x.旧值 == JL8aji33de.账号;
			}
			return false;
		}

		static _003C_003Ec__DisplayClass7_0()
		{
		}
	}

	public 合区记录配置表 jDcBLpno7D;

	
	[SpecialName]
	public static bool RwABX24lCy()
	{
		if (!全局变量类.Is调试)
		{
			return Singleton<全局变量类>.I.验证client.授权配置.Is专属合区;
		}
		return true;
	}

	
	internal bool BbnBfEwQSV()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("合区文件夹/合区记录配置表.json")))
			{
				jDcBLpno7D = JsonConvert.DeserializeObject<合区记录配置表>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("合区文件夹/合区记录配置表.json")));
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			Log.Error("合区记录配置表读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	public async Task NbJB6ku1Gh(string P_0, string P_1, string P_2, string P_3, string P_4, string P_5, Action<bool, string> P_6)
	{
		_ = 2;
		try
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(69, 5);
			defaultInterpolatedStringHandler.AppendLiteral("server=");
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(";user='");
			defaultInterpolatedStringHandler.AppendFormatted(P_3);
			defaultInterpolatedStringHandler.AppendLiteral("';database=");
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			defaultInterpolatedStringHandler.AppendLiteral(";port=");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral(";password=");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(";charset='gbk';pooling=true;");
			DB.B区连接 = defaultInterpolatedStringHandler.ToStringAndClear();
			ConcurrentDictionary<int, 角色存档数据类> concurrentDictionary = sgwB22noKe(P_6);
			ConcurrentDictionary<string, 宠物存档数据类> 宠物列表 = OBvBmu3xBR(P_6);
			List<注册信息> 注册列表 = VHkBPNVTh0(P_6);
			if (!concurrentDictionary.IsEmpty)
			{
				foreach (KeyValuePair<int, 角色存档数据类> item in concurrentDictionary)
				{
					DB.I.oMuiwEHr6E(item.Key, item.Value);
					if (P_6 != null)
					{
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
						defaultInterpolatedStringHandler.AppendLiteral("GID[");
						defaultInterpolatedStringHandler.AppendFormatted(item.Key);
						defaultInterpolatedStringHandler.AppendLiteral("]角色迁移成功");
						P_6(arg1: false, defaultInterpolatedStringHandler.ToStringAndClear());
					}
					await Task.Delay(10);
				}
			}
			if (!宠物列表.IsEmpty)
			{
				foreach (KeyValuePair<string, 宠物存档数据类> item2 in 宠物列表)
				{
					DB.I.irWib79NaP(item2.Key, item2.Value);
					P_6?.Invoke(arg1: false, "IID[" + item2.Key + "]宠物迁移成功");
					await Task.Delay(10);
				}
			}
			if (注册列表.Count > 0)
			{
				using List<注册信息>.Enumerator enumerator3 = 注册列表.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass4_0();
					CS_0024_003C_003E8__locals3.ivHaU6M6PV = enumerator3.Current;
					if (!Singleton<全局变量类>.I.注册列表.Any( (注册信息 x) => x.账号 == CS_0024_003C_003E8__locals3.ivHaU6M6PV.账号))
					{
						DB.I.创建注册存档数据(CS_0024_003C_003E8__locals3.ivHaU6M6PV);
					}
					await Task.Delay(10);
				}
			}
			P_6?.Invoke(arg1: true, "全部完成！");
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("初始化玩家存档数据错误：");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal ConcurrentDictionary<int, 角色存档数据类> sgwB22noKe(Action<bool, string> P_0)
	{
		ConcurrentDictionary<int, 角色存档数据类> concurrentDictionary = new ConcurrentDictionary<int, 角色存档数据类>();
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(DB.B区连接);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				P_0?.Invoke(arg1: true, "数据库打开失败！");
				return concurrentDictionary;
			}
			DB.I.o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select * from yjuser";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			concurrentDictionary.Clear();
			if (mySqlDataReader != null)
			{
				while (mySqlDataReader.Read())
				{
					_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass5_0();
					CS_0024_003C_003E8__locals3.qCsagE7KhQ = int.Parse(mySqlDataReader["gid"].ToString());
					string value = DB.I.ujjNRZ9vuH(mySqlDataReader["info"].ToString());
					try
					{
						角色存档数据类 角色存档数据类2 = JsonConvert.DeserializeObject<角色存档数据类>(value);
						合区记录列表 合区记录列表2 = jDcBLpno7D.列表.Find( (合区记录列表 x) => x.类型值 && x.旧值 == $"{CS_0024_003C_003E8__locals3.qCsagE7KhQ}");
						if (合区记录列表2 != null)
						{
							角色存档数据类2.GID = int.Parse(合区记录列表2.新值);
						}
						concurrentDictionary.TryAdd(角色存档数据类2.GID, 角色存档数据类2);
					}
					catch (Exception ex)
					{
						Log.Error("B区角色存档读取报错：[" + CS_0024_003C_003E8__locals3.qCsagE7KhQ + "]" + ex.Message + "(" + ex.StackTrace + ")");
					}
				}
			}
			mySqlDataReader.Close();
			return concurrentDictionary;
		}
		catch (Exception ex2)
		{
			P_0?.Invoke(arg1: true, "数据库打开失败！");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("B区初始化玩家存档数据错误：");
			defaultInterpolatedStringHandler.AppendFormatted(ex2.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex2.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return concurrentDictionary;
		}
	}

	
	internal ConcurrentDictionary<string, 宠物存档数据类> OBvBmu3xBR(Action<bool, string> P_0)
	{
		ConcurrentDictionary<string, 宠物存档数据类> concurrentDictionary = new ConcurrentDictionary<string, 宠物存档数据类>();
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(DB.B区连接);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				P_0?.Invoke(arg1: true, "数据库打开失败！");
				return concurrentDictionary;
			}
			DB.I.o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select * from yjpet";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			concurrentDictionary.Clear();
			if (mySqlDataReader != null)
			{
				while (mySqlDataReader.Read())
				{
					string key = mySqlDataReader["iid"].ToString();
					string value = DB.I.ujjNRZ9vuH(mySqlDataReader["info"].ToString());
					concurrentDictionary.TryAdd(key, JsonConvert.DeserializeObject<宠物存档数据类>(value));
				}
			}
			mySqlDataReader.Close();
			return concurrentDictionary;
		}
		catch (Exception ex)
		{
			P_0?.Invoke(arg1: true, "数据库打开失败！");
			Log.Error("初始化宠物存档数据错误：" + ex.Message + "(" + ex.StackTrace + ")");
			return concurrentDictionary;
		}
	}

	
	internal List<注册信息> VHkBPNVTh0(Action<bool, string> P_0)
	{
		List<注册信息> list = new List<注册信息>();
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(DB.B区连接);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				P_0?.Invoke(arg1: true, "数据库打开失败！");
				return list;
			}
			DB.I.o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select * from yjzcxx";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			list.Clear();
			if (mySqlDataReader != null)
			{
				while (mySqlDataReader.Read())
				{
					_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass7_0();
					CS_0024_003C_003E8__locals4.JL8aji33de = new 注册信息
					{
						账号 = mySqlDataReader["account"].ToString(),
						密码 = mySqlDataReader["pass"].ToString(),
						安全码 = mySqlDataReader["aqpass"].ToString(),
						注册验证码 = mySqlDataReader["yzm"].ToString(),
						名字 = DB.I.ujjNRZ9vuH(mySqlDataReader["zcname"].ToString()),
						等级 = int.Parse(mySqlDataReader["zclv"].ToString()),
						IP = mySqlDataReader["zcip"].ToString(),
						Mac = mySqlDataReader["zcmac"].ToString(),
						qq = mySqlDataReader["zcqq"].ToString(),
						注册时间 = mySqlDataReader["zctime"].ToString()
					};
					合区记录列表 合区记录列表2 = jDcBLpno7D.列表.Find( (合区记录列表 x) => !x.类型值 && x.旧值 == CS_0024_003C_003E8__locals4.JL8aji33de.账号);
					if (合区记录列表2 != null)
					{
						CS_0024_003C_003E8__locals4.JL8aji33de.账号 = 合区记录列表2.新值;
					}
					list.Add(CS_0024_003C_003E8__locals4.JL8aji33de);
				}
			}
			mySqlDataReader.Close();
			return list;
		}
		catch (Exception ex)
		{
			Log.Error("初始化注册信息数据错误：" + ex.Message + "(" + ex.StackTrace + ")");
			P_0?.Invoke(arg1: true, "数据库打开失败！");
			return list;
		}
	}

	
	public wki1dRBBTGa2CXII175()
	{
		jDcBLpno7D = new 合区记录配置表();
	}

	static wki1dRBBTGa2CXII175()
	{
	}
}
