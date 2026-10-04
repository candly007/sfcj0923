using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using GJSyJYUDOfxE331QwT1;
using MySql.Data.MySqlClient;
using Newtonsoft_X.Json;
using Serilog;
using TouchSocket.Core;
using cVS5v9gmXX8TceaB2WW;
using vEAdPGPTkDFOYsbi303;

public class DB
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public Random pdN7OMg4tx;

		
		public _003C_003Ec__DisplayClass67_0()
		{
		}

		
		internal int eua70cEH7q(char x)
		{
			return pdN7OMg4tx.Next();
		}

		static _003C_003Ec__DisplayClass67_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public string HTa73kU9IY;

		public string T7G7Y7tfPQ;

		
		public _003C_003Ec__DisplayClass91_0()
		{
		}

		
		internal bool xRq7QNuDmT(注册信息 x)
		{
			return x.Mac == HTa73kU9IY;
		}

		
		internal bool Egw7EWJVpb(注册信息 x)
		{
			return x.Is重复qq(T7G7Y7tfPQ);
		}

		static _003C_003Ec__DisplayClass91_0()
		{
		}
	}

	private static DB l06iDy9jYV;

	public static readonly string sqlTolatin1;

	public static string allsql;

	public static string adbsql1;

	public static string ddbsql2;

	public static string B区连接;

	private static object s25ijnJt0L;

	private static object LiqileM5Re;

	private static object zl7i8BHLMm;

	private static readonly ArchiveSaveGate 全量存档门 = new ArchiveSaveGate();

	public static DB I
	{
		
		get
		{
			if (l06iDy9jYV == null)
			{
				l06iDy9jYV = new DB();
			}
			return l06iDy9jYV;
		}
	}

	
	public DB()
	{
	}

	
	internal bool V0wNwNfGJR(string P_0, string P_1, string P_2, string P_3, string P_4, string P_5)
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
		B区连接 = defaultInterpolatedStringHandler.ToStringAndClear();
		using MySqlConnection mySqlConnection = new MySqlConnection(B区连接);
		mySqlConnection.Open();
		if (mySqlConnection.State != ConnectionState.Open)
		{
			Log.Error("B区数据库连接失败！");
			return false;
		}
		using MySqlCommand mySqlCommand = new MySqlCommand();
		mySqlCommand.Connection = mySqlConnection;
		mySqlCommand.CommandText = sqlTolatin1;
		int num = mySqlCommand.ExecuteNonQuery();
		if (num < 0)
		{
			Log.Error("B区数据库连接失败！");
		}
		return num >= 0;
	}

	
	internal void fwlNbKZtLa()
	{
		更新连接字符串();
		using MySqlConnection mySqlConnection = new MySqlConnection(allsql);
		mySqlConnection.Open();
		if (mySqlConnection.State != ConnectionState.Open)
		{
			Log.Error("mysql数据库连接失败！");
			return;
		}
		using MySqlCommand mySqlCommand = new MySqlCommand();
		mySqlCommand.Connection = mySqlConnection;
		mySqlCommand.CommandText = sqlTolatin1;
		mySqlCommand.ExecuteNonQuery();
		if (mySqlCommand.ExecuteNonQuery() < 0)
		{
			Log.Error("mysql数据库连接失败！");
		}
	}

	
	public static void 更新连接字符串()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(67, 2);
		defaultInterpolatedStringHandler.AppendLiteral("server=");
		defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.游戏IP);
		defaultInterpolatedStringHandler.AppendLiteral(";user='root';port=3306;password=");
		defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.Mysql密码);
		defaultInterpolatedStringHandler.AppendLiteral(";charset='gbk';pooling=true;");
		allsql = defaultInterpolatedStringHandler.ToStringAndClear();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(87, 2);
		defaultInterpolatedStringHandler.AppendLiteral("server=");
		defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.游戏IP);
		defaultInterpolatedStringHandler.AppendLiteral(";user='root';database=dl_adb_all;port=3306;password=");
		defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.Mysql密码);
		defaultInterpolatedStringHandler.AppendLiteral(";charset='gbk';pooling=true;");
		adbsql1 = defaultInterpolatedStringHandler.ToStringAndClear();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(85, 2);
		defaultInterpolatedStringHandler.AppendLiteral("server=");
		defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.游戏IP);
		defaultInterpolatedStringHandler.AppendLiteral(";user='root';database=dl_ddb_1;port=3306;password=");
		defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.Mysql密码);
		defaultInterpolatedStringHandler.AppendLiteral(";charset='gbk';pooling=true;");
		ddbsql2 = defaultInterpolatedStringHandler.ToStringAndClear();
	}

	
	internal int o51NJkPfKI(MySqlConnection P_0)
	{
		try
		{
			using MySqlCommand mySqlCommand = new MySqlCommand(sqlTolatin1, P_0);
			return mySqlCommand.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			Log.Error("更新数据错误：" + ex.Message);
			return -1;
		}
	}

	
	internal string XEYNKGEPKJ(byte[] P_0)
	{
		return Encoding.GetEncoding(936).GetString(P_0);
	}

	
	internal string ujjNRZ9vuH(string P_0)
	{
		return Encoding.GetEncoding(936).GetString(Encoding.Latin1.GetBytes(P_0));
	}

	
	internal string BBHNdj61h3(MySqlDataReader P_0, string P_1)
	{
		byte[] bytes = (byte[])P_0[P_1];
		return Encoding.GetEncoding(936).GetString(bytes);
	}

	
	internal int c1ZNsjqlRc(MySqlConnection P_0, string P_1)
	{
		try
		{
			using MySqlCommand mySqlCommand = new MySqlCommand(P_1, P_0);
			return mySqlCommand.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
			defaultInterpolatedStringHandler.AppendLiteral("修改数据-错误：SQL语句【");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return -1;
		}
	}

	
	internal async Task<int> w3HNUJWfp3(MySqlConnection P_0, string P_1)
	{
		try
		{
			using MySqlCommand cmd = new MySqlCommand(P_1, P_0);
			int result = cmd.ExecuteNonQuery();
			await Task.Delay(1);
			return result;
		}
		catch (Exception ex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 3);
			defaultInterpolatedStringHandler.AppendLiteral("修改数据异步-错误：SQL语句【");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】");
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			return -1;
		}
	}

	
	internal string Ju3NWyx2CS(string P_0)
	{
		return "UPDATE account SET CHECKSUM = upper(CAST(md5(concat(CAST(account AS char CHARACTER SET utf8),CAST(PASSWORD AS char CHARACTER SET utf8),CAST(LPAD(CONV(privilege, 10, 16), 8, 0) AS char CHARACTER SET utf8),CAST(blocked_time AS char CHARACTER SET utf8),CAST(LPAD(CONV(gold_coin, 10, 16), 8, 0) AS char CHARACTER SET utf8),CAST(LPAD(CONV(silver_coin, 10, 16), 8, 0) AS char CHARACTER SET utf8),CAST(coin_password AS char CHARACTER SET utf8),CAST(unlock_coin_password_time AS char CHARACTER SET utf8),CAST(trade_lock_time AS char CHARACTER SET utf8),CAST(permit_ip AS char CHARACTER SET utf8),'ABCDEF')) AS CHAR))WHERE account = '" + P_0 + "'";
	}

	
	internal int E3iNgPntG8(string P_0)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("角色名取GID-mysql数据库连接失败！");
				return 0;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand("SELECT gid FROM gid_info WHERE name = @name", mySqlConnection);
			mySqlCommand.Parameters.Add(new MySqlParameter("@name", MySqlDbType.VarChar)
			{
				Value = P_0
			});
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (!mySqlDataReader.Read())
			{
				return 0;
			}
			return int.Parse(mySqlDataReader["gid"].ToString());
		}
		catch (Exception ex)
		{
			Log.Error("角色名取GID-mysql数据库连接失败！" + ex.Message + "(" + ex.StackTrace + ")");
			return 0;
		}
	}

	
	internal bool DGHNDad7XG(int P_0, ref string P_1)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("GID取角色名-mysql数据库连接失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand("select CAST(name AS BINARY) AS bytedata from gid_info where gid=@gid", mySqlConnection);
			mySqlCommand.Parameters.AddWithValue("@gid", P_0);
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			P_1 = string.Empty;
			if (mySqlDataReader == null)
			{
				return false;
			}
			if (!mySqlDataReader.Read())
			{
				return false;
			}
			P_1 = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("GID取角色名-mysql数据库连接失败！" + ex.Message + "(" + ex.StackTrace + ")");
			P_1 = string.Empty;
			return false;
		}
	}

	
	internal string ODoNjwX1A1(int P_0)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("取玩家账号-mysql数据库连接失败！");
				return string.Empty;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand("select CAST(content AS BINARY) AS bytedata from data where path='user' and branch='' and name=@name", mySqlConnection);
			mySqlCommand.Parameters.AddWithValue("@name", Singleton<ByteAPI>.I.GetHexGid_(P_0));
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null)
			{
				return string.Empty;
			}
			if (!mySqlDataReader.Read())
			{
				return string.Empty;
			}
			string 总文本 = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			return Singleton<ByteAPI>.I.文本_取出中间文本(总文本, "\"account\":\"", "\",");
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_取玩家账号报错=" + ex.Message + "(" + ex.StackTrace + ")");
			return string.Empty;
		}
	}

	
	internal bool RhsNloVXFg(人物基础数据类 P_0)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("取玩家账号-mysql数据库连接失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand("select CAST(content AS BINARY) AS bytedata from data where path='user' and branch='' and name=@name", mySqlConnection);
			mySqlCommand.Parameters.AddWithValue("@name", Singleton<ByteAPI>.I.GetHexGid_(P_0.GID));
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null)
			{
				return false;
			}
			if (!mySqlDataReader.Read())
			{
				return false;
			}
			string 总文本 = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			P_0.账号 = Singleton<ByteAPI>.I.文本_取出中间文本(总文本, "\"account\":\"", "\",");
			return !string.IsNullOrWhiteSpace(P_0.账号);
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_取玩家账号报错=" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal int UliN8mrbMu(string P_0)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("Mysql_查询权限失败！");
				return 0;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand("select privilege from account where account=@account", mySqlConnection);
			mySqlCommand.Parameters.AddWithValue("@account", P_0);
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null)
			{
				return 0;
			}
			if (!mySqlDataReader.Read())
			{
				return 0;
			}
			int.TryParse(mySqlDataReader["privilege"].ToString(), out var result);
			mySqlDataReader.Close();
			return result;
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_查询qx报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return 0;
		}
	}

	
	internal bool JY2NIJPMcG(string P_0)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("自动修复1009失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			int result = 0;
			int result2 = 0;
			int result3 = 0;
			using (MySqlCommand mySqlCommand = new MySqlCommand("select gold_coin,silver_coin,privilege from account where account=@account", mySqlConnection))
			{
				mySqlCommand.Parameters.AddWithValue("@account", P_0);
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null)
				{
					return false;
				}
				if (!mySqlDataReader.Read())
				{
					return false;
				}
				int.TryParse(mySqlDataReader["gold_coin"].ToString(), out result);
				int.TryParse(mySqlDataReader["silver_coin"].ToString(), out result2);
				int.TryParse(mySqlDataReader["privilege"].ToString(), out result3);
			}
			int num = 0;
			int num2 = 0;
			if (result > 2000000000)
			{
				num = 2000000000 - result;
			}
			if (result < 0)
			{
				num = -result;
			}
			if (result2 > 2000000000)
			{
				num2 = 2000000000 - result2;
			}
			if (result2 < 0)
			{
				num2 = -result2;
			}
			if (result3 == 0)
			{
				result3 = 200;
			}
			元宝CheckSum(P_0, "", 0, "", result + num, result2 + num2, "", "", "", "", "");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(354, 4);
			defaultInterpolatedStringHandler.AppendLiteral("UPDATE account SET gold_coin = gold_coin+");
			defaultInterpolatedStringHandler.AppendFormatted(num);
			defaultInterpolatedStringHandler.AppendLiteral(",silver_coin = silver_coin+");
			defaultInterpolatedStringHandler.AppendFormatted(num2);
			defaultInterpolatedStringHandler.AppendLiteral(",privilege ='");
			defaultInterpolatedStringHandler.AppendFormatted(result3);
			defaultInterpolatedStringHandler.AppendLiteral("', CHECKSUM =upper(md5(concat(account,PASSWORD,LPAD(conv(privilege, 10, 16), 8, 0),blocked_time,LPAD(conv(gold_coin, 10, 16),8,0),LPAD(conv(silver_coin, 10, 16),8,0),coin_password,unlock_coin_password_time,trade_lock_time,permit_ip,permit_id,'ABCDEF'))) WHERE account = '");
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral("';");
			if (c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear()) > -1)
			{
				c1ZNsjqlRc(mySqlConnection, "update account set checksum=UPPER(checksum) WHERE account = '" + P_0 + "';");
			}
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("自动修复1009-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal bool cAJNoOkab6(MyNATSocketClient P_0, int P_1, int P_2)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("调整元宝失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			int result = 0;
			int result2 = 0;
			using (MySqlCommand mySqlCommand = new MySqlCommand())
			{
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = "select gold_coin,silver_coin from account where account='" + P_0.user.人物数据.账号 + "'";
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null)
				{
					return false;
				}
				if (!mySqlDataReader.Read())
				{
					return false;
				}
				int.TryParse(mySqlDataReader["gold_coin"].ToString(), out result);
				int.TryParse(mySqlDataReader["silver_coin"].ToString(), out result2);
			}
			if (2000000000 - result < P_1)
			{
				P_1 = 2000000000 - result;
			}
			else if (result + P_1 < 0)
			{
				P_1 = -result;
			}
			if (2000000000 - result2 < P_2)
			{
				P_2 = 2000000000 - result2;
			}
			else if (result2 + P_2 < 0)
			{
				P_2 = -result2;
			}
			元宝CheckSum(P_0.user.人物数据.账号, "", 0, "", result + P_1, result2 + P_2, "", "", "", "", "");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(340, 3);
			defaultInterpolatedStringHandler.AppendLiteral("UPDATE account SET gold_coin = gold_coin+");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(",silver_coin = silver_coin+");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral(", CHECKSUM =upper(md5(concat(account,PASSWORD,LPAD(conv(privilege, 10, 16), 8, 0),blocked_time,LPAD(conv(gold_coin, 10, 16),8,0),LPAD(conv(silver_coin, 10, 16),8,0),coin_password,unlock_coin_password_time,trade_lock_time,permit_ip,permit_id,'ABCDEF'))) WHERE account = '");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
			defaultInterpolatedStringHandler.AppendLiteral("';");
			if (c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear()) > -1)
			{
				P_0.user.背包数据.金元宝 = result + P_1;
				P_0.user.背包数据.银元宝 = result2 + P_2;
				P_0.C_Send(Singleton<WdAPI>.I.组包元宝刷新(P_0.user.人物数据.角色ID, P_0.user.背包数据.金元宝, P_0.user.背包数据.银元宝));
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_调整元宝报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal bool XTGNNsRFkB(MyNATSocketClient P_0, bool P_1)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("调整元宝失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			using (MySqlCommand mySqlCommand = new MySqlCommand())
			{
				mySqlCommand.Connection = mySqlConnection;
				if (P_1)
				{
					mySqlCommand.CommandText = "select gold_coin from account where account='" + P_0.user.人物数据.账号 + "'";
				}
				else
				{
					mySqlCommand.CommandText = "select silver_coin from account where account='" + P_0.user.人物数据.账号 + "'";
				}
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null)
				{
					return false;
				}
				if (!mySqlDataReader.Read())
				{
					return false;
				}
			}
			if (P_1)
			{
				if (c1ZNsjqlRc(mySqlConnection, "UPDATE account SET gold_coin = 0, CHECKSUM =upper(md5(concat(account,PASSWORD,LPAD(conv(privilege, 10, 16), 8, 0),blocked_time,LPAD(conv(gold_coin, 10, 16),8,0),LPAD(conv(silver_coin, 10, 16),8,0),coin_password,unlock_coin_password_time,trade_lock_time,permit_ip,permit_id,'ABCDEF'))) WHERE account = '" + P_0.user.人物数据.账号 + "';") > -1)
				{
					P_0.user.背包数据.金元宝 = 0;
					P_0.C_Send(Singleton<WdAPI>.I.组包元宝刷新(P_0.user.人物数据.角色ID, P_0.user.背包数据.金元宝, P_0.user.背包数据.银元宝));
					return true;
				}
			}
			else if (c1ZNsjqlRc(mySqlConnection, "UPDATE account SET silver_coin = 0, CHECKSUM =upper(md5(concat(account,PASSWORD,LPAD(conv(privilege, 10, 16), 8, 0),blocked_time,LPAD(conv(gold_coin, 10, 16),8,0),LPAD(conv(silver_coin, 10, 16),8,0),coin_password,unlock_coin_password_time,trade_lock_time,permit_ip,permit_id,'ABCDEF'))) WHERE account = '" + P_0.user.人物数据.账号 + "';") > -1)
			{
				P_0.user.背包数据.银元宝 = 0;
				P_0.C_Send(Singleton<WdAPI>.I.组包元宝刷新(P_0.user.人物数据.角色ID, P_0.user.背包数据.金元宝, P_0.user.背包数据.银元宝));
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_清空元宝-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal async Task<bool> j3ANifCI7L(MyNATSocketClient P_0, int P_1, int P_2)
	{
		try
		{
			using MySqlConnection conn = new MySqlConnection(adbsql1);
			conn.Open();
			if (conn.State != ConnectionState.Open)
			{
				Log.Error("调整元宝失败！");
				return false;
			}
			o51NJkPfKI(conn);
			int result = 0;
			int result2 = 0;
			using (MySqlCommand mySqlCommand = new MySqlCommand())
			{
				mySqlCommand.Connection = conn;
				mySqlCommand.CommandText = "select gold_coin,silver_coin from account where account='" + P_0.user.人物数据.账号 + "'";
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null)
				{
					return false;
				}
				if (!mySqlDataReader.Read())
				{
					return false;
				}
				int.TryParse(mySqlDataReader["gold_coin"].ToString(), out result);
				int.TryParse(mySqlDataReader["silver_coin"].ToString(), out result2);
			}
			if (2000000000 - result < P_1)
			{
				P_1 = 2000000000 - result;
			}
			else if (result + P_1 < 0)
			{
				P_1 = -result;
			}
			if (2000000000 - result2 < P_2)
			{
				P_2 = 2000000000 - result2;
			}
			else if (result2 + P_2 < 0)
			{
				P_2 = -result2;
			}
			元宝CheckSum(P_0.user.人物数据.账号, "", 0, "", result + P_1, result2 + P_2, "", "", "", "", "");
			DB dB = this;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(340, 3);
			defaultInterpolatedStringHandler.AppendLiteral("UPDATE account SET gold_coin = gold_coin+");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(",silver_coin = silver_coin+");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral(", CHECKSUM =upper(md5(concat(account,PASSWORD,LPAD(conv(privilege, 10, 16), 8, 0),blocked_time,LPAD(conv(gold_coin, 10, 16),8,0),LPAD(conv(silver_coin, 10, 16),8,0),coin_password,unlock_coin_password_time,trade_lock_time,permit_ip,permit_id,'ABCDEF'))) WHERE account = '");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
			defaultInterpolatedStringHandler.AppendLiteral("';");
			if (dB.c1ZNsjqlRc(conn, defaultInterpolatedStringHandler.ToStringAndClear()) > -1)
			{
				P_0.user.背包数据.金元宝 = result + P_1;
				P_0.user.背包数据.银元宝 = result2 + P_2;
				await P_0.C_Send异步(Singleton<WdAPI>.I.组包元宝刷新(P_0.user.人物数据.角色ID, P_0.user.背包数据.金元宝, P_0.user.背包数据.银元宝));
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			Log.Error("Task_调整元宝报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal bool c1GNBnKh5d(string P_0, int P_1, int P_2)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("调整元宝失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			int result = 0;
			int result2 = 0;
			using (MySqlCommand mySqlCommand = new MySqlCommand())
			{
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = "select gold_coin,silver_coin from account where account='" + P_0 + "'";
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null)
				{
					return false;
				}
				if (!mySqlDataReader.Read())
				{
					return false;
				}
				int.TryParse(mySqlDataReader["gold_coin"].ToString(), out result);
				int.TryParse(mySqlDataReader["silver_coin"].ToString(), out result2);
			}
			if (2000000000 - result < P_1)
			{
				P_1 = 2000000000 - result;
			}
			else if (result + P_1 < 0)
			{
				P_1 = -result;
			}
			if (2000000000 - result2 < P_2)
			{
				P_2 = 2000000000 - result2;
			}
			else if (result2 + P_2 < 0)
			{
				P_2 = -result2;
			}
			元宝CheckSum(P_0, "", 0, "", result + P_1, result2 + P_2, "", "", "", "", "");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(340, 3);
			defaultInterpolatedStringHandler.AppendLiteral("UPDATE account SET gold_coin = gold_coin+");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(",silver_coin = silver_coin+");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral(", CHECKSUM =upper(md5(concat(account,PASSWORD,LPAD(conv(privilege, 10, 16), 8, 0),blocked_time,LPAD(conv(gold_coin, 10, 16),8,0),LPAD(conv(silver_coin, 10, 16),8,0),coin_password,unlock_coin_password_time,trade_lock_time,permit_ip,permit_id,'ABCDEF'))) WHERE account = '");
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral("';");
			if (c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear()) > -1)
			{
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_调整元宝_离线版-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal bool b0lNGoCiRI(string P_0)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("调整元宝失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			using (MySqlCommand mySqlCommand = new MySqlCommand())
			{
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = "select gold_coin,silver_coin from account where account='" + P_0 + "'";
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null)
				{
					return false;
				}
				if (!mySqlDataReader.Read())
				{
					return false;
				}
			}
			return c1ZNsjqlRc(mySqlConnection, "UPDATE account SET gold_coin = 0,silver_coin = 0, CHECKSUM =upper(md5(concat(account,PASSWORD,LPAD(conv(privilege, 10, 16), 8, 0),blocked_time,LPAD(conv(gold_coin, 10, 16),8,0),LPAD(conv(silver_coin, 10, 16),8,0),coin_password,unlock_coin_password_time,trade_lock_time,permit_ip,permit_id,'ABCDEF'))) WHERE account = '" + P_0 + "';") > -1;
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_清空元宝_离线版报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal bool oEqNfmWhM4(string P_0)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("调整金元宝失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			using (MySqlCommand mySqlCommand = new MySqlCommand())
			{
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = "select gold_coin from account where account='" + P_0 + "'";
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null)
				{
					return false;
				}
				if (!mySqlDataReader.Read())
				{
					return false;
				}
			}
			return c1ZNsjqlRc(mySqlConnection, "UPDATE account SET gold_coin = 0, CHECKSUM =upper(md5(concat(account,PASSWORD,LPAD(conv(privilege, 10, 16), 8, 0),blocked_time,LPAD(conv(gold_coin, 10, 16),8,0),LPAD(conv(silver_coin, 10, 16),8,0),coin_password,unlock_coin_password_time,trade_lock_time,permit_ip,permit_id,'ABCDEF'))) WHERE account = '" + P_0 + "';") > -1;
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_清空金元宝_离线版报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal bool PtuN65WBZ6(string P_0)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("调整银元宝失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			using (MySqlCommand mySqlCommand = new MySqlCommand())
			{
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = "select silver_coin from account where account='" + P_0 + "'";
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null)
				{
					return false;
				}
				if (!mySqlDataReader.Read())
				{
					return false;
				}
			}
			return c1ZNsjqlRc(mySqlConnection, "UPDATE account SET silver_coin = 0, CHECKSUM =upper(md5(concat(account,PASSWORD,LPAD(conv(privilege, 10, 16), 8, 0),blocked_time,LPAD(conv(gold_coin, 10, 16),8,0),LPAD(conv(silver_coin, 10, 16),8,0),coin_password,unlock_coin_password_time,trade_lock_time,permit_ip,permit_id,'ABCDEF'))) WHERE account = '" + P_0 + "';") > -1;
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_清空银元宝_离线版报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal bool KmyN2tdqQc(string P_0)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("监测用户是否真实下线失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select 1 from data where path = 'runtime' and name ='" + P_0 + "' LIMIT 1";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			return mySqlDataReader?.Read() ?? false;
		}
		catch (Exception ex)
		{
			Log.Error("监测用户是否真实下线报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal async Task<bool> z6HNmqLhum(string P_0)
	{
		try
		{
			using MySqlConnection conn = new MySqlConnection(ddbsql2);
			conn.Open();
			if (conn.State != ConnectionState.Open)
			{
				Log.Error("监测用户是否真实下线失败！");
				return false;
			}
			o51NJkPfKI(conn);
			using MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = "select 1 from data where path = 'runtime' and name ='" + P_0 + "' LIMIT 1";
			bool is下线 = false;
			for (int i = 0; i < 10; i++)
			{
				using MySqlDataReader 查询结果 = cmd.ExecuteReader();
				if ((查询结果?.Read()).Value)
				{
					is下线 = true;
					break;
				}
				await Task.Delay(200);
			}
			return is下线;
		}
		catch (Exception ex)
		{
			Log.Error("监测用户是否真实下线报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal void XjTNPETDem(int P_0, string P_1, string P_2)
	{
		try
		{
			Thread.Sleep(100);
			bool flag = KmyN2tdqQc(P_1);
			while (flag)
			{
				Thread.Sleep(100);
				flag = KmyN2tdqQc(P_1);
			}
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(P_0);
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("Mysql_恢复首饰次数处理失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			string text = string.Empty;
			using (MySqlCommand mySqlCommand = new MySqlCommand())
			{
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + hexGid_ + "' ORDER BY name DESC";
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null || !mySqlDataReader.Read())
				{
					return;
				}
				text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			}
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：首饰转换前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear());
			if (!text.Contains(P_2, StringComparison.CurrentCulture))
			{
				return;
			}
			string text2 = Singleton<ByteAPI>.I.文本_取出中间文本(text, P_2, "])\",");
			if (text.Contains(text2, StringComparison.CurrentCulture))
			{
				text2 = P_2 + text2 + "])\",";
				string text3 = Singleton<ByteAPI>.I.文本_取出中间文本(text2, "\\\"cvt_chance\\\":", ",");
				if (!string.IsNullOrWhiteSpace(text3))
				{
					string newValue = text2.Replace("\\\"cvt_chance\\\":" + text3 + ",", "\\\"cvt_chance\\\":0,");
					text = text.Replace(text2, newValue);
					int dataChecksum = GetDataChecksum("user" + hexGid_ + "carry" + text);
					text = text.Replace("\\", "\\\\");
					全局变量类 i2 = Singleton<全局变量类>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
					defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
					defaultInterpolatedStringHandler.AppendLiteral("  【操作：首饰转换后】 【账号：");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
					i2.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 3);
					defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
					defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
					defaultInterpolatedStringHandler.AppendLiteral("' where branch ='carry' and name ='");
					defaultInterpolatedStringHandler.AppendFormatted(hexGid_);
					defaultInterpolatedStringHandler.AppendLiteral("'");
					c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
					锁定账号操作(P_1, "0");
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_恢复首饰次数处理=" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string u0sNXMe2QN(MyNATSocketClient P_0, int P_1, ref string P_2)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("PetID取IID-mysql数据库连接失败！");
				return string.Empty;
			}
			o51NJkPfKI(mySqlConnection);
			string text = string.Empty;
			using (MySqlCommand mySqlCommand = new MySqlCommand())
			{
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where branch = 'patch' and name ='" + Singleton<ByteAPI>.I.GetHexGid_(P_0.user.人物数据.GID) + "'";
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null)
				{
					return string.Empty;
				}
				if (!mySqlDataReader.Read())
				{
					return string.Empty;
				}
				text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			}
			string text2 = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(":\"");
			int num = text2.IndexOf(defaultInterpolatedStringHandler.ToStringAndClear());
			if (num == -1)
			{
				return string.Empty;
			}
			P_2 = Singleton<ByteAPI>.I.文本_取出中间文本(text, "\"", ":", num);
			return string.IsNullOrWhiteSpace(Singleton<ByteAPI>.I.文本_取出中间文本(text, "33::", ",", num)) ? string.Empty : (":" + Singleton<ByteAPI>.I.文本_取出中间文本(text, "33::", ",", num));
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_PetID取IID-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return string.Empty;
		}
	}

	
	internal string kPJNFAhrFx(MyNATSocketClient P_0, int P_1, int P_2, string P_3)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("取指定格子道具IID-mysql数据库连接失败！");
				return string.Empty;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + Singleton<ByteAPI>.I.GetHexGid_(P_1) + "' ORDER BY name DESC";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null)
			{
				return string.Empty;
			}
			if (!mySqlDataReader.Read())
			{
				return string.Empty;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral(":\"");
			defaultInterpolatedStringHandler.AppendFormatted(P_3);
			string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (!text.Contains(text2, StringComparison.CurrentCulture))
			{
				return string.Empty;
			}
			if (string.IsNullOrWhiteSpace(Singleton<ByteAPI>.I.文本_取出中间文本(text, text2, "])\",")))
			{
				return string.Empty;
			}
			return Singleton<ByteAPI>.I.文本_取出中间文本(text, "33::", ":");
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_取指定格子道具IID-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return string.Empty;
		}
	}

	
	public int GetDataChecksum(string data)
	{
		int num = 1;
		int num2 = 0;
		try
		{
			byte[] bytes = Encoding.GetEncoding("GBK").GetBytes(data);
			for (int i = 0; i < bytes.Length; i++)
			{
				num = (num + (bytes[i] + 256) % 256) % 65521;
				num2 = (num2 + num) % 65521;
			}
			return ((num2 << 16) | num) ^ -1418120497;
		}
		catch (Exception)
		{
			return 0;
		}
	}

	
	public string 元宝CheckSum(string mAccountName, string mPasswdMD5, int mPrivilege, string mBlockTime, int mGoldCoins, int mSilverCoins, string mCoinPasswd, string mUnlockCoinPasswdTime, string mTradeLockTime, string mPermitIP, string mPermitID)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 11);
		defaultInterpolatedStringHandler.AppendFormatted(mAccountName);
		defaultInterpolatedStringHandler.AppendFormatted(mPasswdMD5);
		defaultInterpolatedStringHandler.AppendFormatted(mPrivilege, "X8");
		defaultInterpolatedStringHandler.AppendFormatted(mBlockTime);
		defaultInterpolatedStringHandler.AppendFormatted(mGoldCoins);
		defaultInterpolatedStringHandler.AppendFormatted(mSilverCoins, "X8");
		defaultInterpolatedStringHandler.AppendFormatted(mCoinPasswd);
		defaultInterpolatedStringHandler.AppendFormatted(mUnlockCoinPasswdTime);
		defaultInterpolatedStringHandler.AppendFormatted(mTradeLockTime, "X8");
		defaultInterpolatedStringHandler.AppendFormatted(mPermitIP);
		defaultInterpolatedStringHandler.AppendFormatted(mPermitID);
		defaultInterpolatedStringHandler.AppendLiteral("ABCDEF");
		string value = defaultInterpolatedStringHandler.ToStringAndClear();
		return 取数据摘要(Singleton<ByteAPI>.I.到字节集(value));
	}

	
	public string 取数据摘要(byte[] inputBytes)
	{
		using System.Security.Cryptography.MD5 mD = System.Security.Cryptography.MD5.Create();
		byte[] array = mD.ComputeHash(inputBytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	
	public string GetMD5Info(string value)
	{
		return BitConverter.ToString(System.Security.Cryptography.MD5.HashData(Encoding.Default.GetBytes(value))).ToUpper().Replace("-", "");
	}

	
	public string AccChecksum(string acc, string 表名 = "")
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(626, 2);
		defaultInterpolatedStringHandler.AppendLiteral("UPDATE ");
		defaultInterpolatedStringHandler.AppendFormatted(表名);
		defaultInterpolatedStringHandler.AppendLiteral("account SET CHECKSUM = upper(CAST(md5(concat(CAST(account AS char CHARACTER SET utf8),CAST(PASSWORD AS char CHARACTER SET utf8),CAST(LPAD(CONV(privilege, 10, 16), 8, 0) AS char CHARACTER SET utf8),CAST(blocked_time AS char CHARACTER SET utf8),CAST(LPAD(CONV(gold_coin, 10, 16), 8, 0) AS char CHARACTER SET utf8),CAST(LPAD(CONV(silver_coin, 10, 16), 8, 0) AS char CHARACTER SET utf8),CAST(coin_password AS char CHARACTER SET utf8),CAST(unlock_coin_password_time AS char CHARACTER SET utf8),CAST(trade_lock_time AS char CHARACTER SET utf8),CAST(permit_ip AS char CHARACTER SET utf8),'ABCDEF')) AS CHAR))WHERE account = '");
		defaultInterpolatedStringHandler.AppendFormatted(0);
		defaultInterpolatedStringHandler.AppendLiteral("'");
		return string.Format(defaultInterpolatedStringHandler.ToStringAndClear(), acc);
	}

	
	internal void JfDNL1qVLO(int P_0, string P_1, string P_2, int P_3)
	{
		try
		{
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(P_0);
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("装备突破进化处理-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + hexGid_ + "' ORDER BY name DESC";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null || !mySqlDataReader.Read())
			{
				return;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：装备进化前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear());
			if (!text.Contains(P_2, StringComparison.CurrentCulture))
			{
				return;
			}
			string text2 = Singleton<ByteAPI>.I.文本_取出中间文本(text, P_2, "])\",");
			if (!string.IsNullOrWhiteSpace(text2))
			{
				text2 = P_2 + text2 + "])\",";
				switch (P_3)
				{
				case 5001:
				case 5002:
				case 5003:
				case 5004:
				case 5005:
				case 6002:
				case 6003:
				case 7001:
				case 7004:
				case 7005:
					P_3 = 2;
					break;
				default:
					P_3 = 1;
					break;
				case 0:
					break;
				}
				string text3 = text2;
				text3 = text3.Replace("248:19,", "");
				text3 = text3.Replace("265:19,", "");
				text3 = UM8NS0dHHP(text3, P_3);
				text = text.Replace(text2, text3);
				int dataChecksum = GetDataChecksum("user" + hexGid_ + "carry" + text);
				text = text.Replace("\\", "\\\\");
				全局变量类 i2 = Singleton<全局变量类>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
				defaultInterpolatedStringHandler.AppendLiteral("  【操作：装备进化后】 【账号：");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
				i2.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 3);
				defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
				defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
				defaultInterpolatedStringHandler.AppendLiteral("' where branch ='carry' and name ='");
				defaultInterpolatedStringHandler.AppendFormatted(hexGid_);
				defaultInterpolatedStringHandler.AppendLiteral("'");
				c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
				锁定账号操作(P_1, "0");
			}
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_装备突破进化处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private string UM8NS0dHHP(string P_0, int P_1 = 0)
	{
		if (P_0.IndexOf("云龙枪") != -1)
		{
			P_0 = P_0.Replace("云龙枪", "蕴雷枪");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("蕴雷枪") != -1)
		{
			P_0 = P_0.Replace("蕴雷枪", "风火游龙枪");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("风火游龙枪") != -1)
		{
			P_0 = P_0.Replace("风火游龙枪", "九转金刚刃");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("九转金刚刃") != -1)
		{
			P_0 = P_0.Replace("九转金刚刃", "混元斩龙戟");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("混元斩龙戟") != -1)
		{
			P_0 = P_0.Replace("混元斩龙戟", "赤眼神龙枪");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("赤眼神龙枪") != -1)
		{
			P_0 = P_0.Replace("赤眼神龙枪", "九天祥云戟");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("九天祥云戟") != -1)
		{
			P_0 = P_0.Replace("九天祥云戟", "赤封侠胆戟");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("赤封侠胆戟") != -1)
		{
			P_0 = P_0.Replace("赤封侠胆戟", "天赐鸿福枪");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("天赐鸿福枪") != -1)
		{
			P_0 = P_0.Replace("天赐鸿福枪", "白虹贯日枪");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("冰雪残月刀") != -1)
		{
			P_0 = P_0.Replace("冰雪残月刀", "神魔幻影刀");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("神魔幻影刀") != -1)
		{
			P_0 = P_0.Replace("神魔幻影刀", "乾坤日月刀");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("乾坤日月刀") != -1)
		{
			P_0 = P_0.Replace("乾坤日月刀", "沉虹连斩刀");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("沉虹连斩刀") != -1)
		{
			P_0 = P_0.Replace("沉虹连斩刀", "银龙锁月刀");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("银龙锁月刀") != -1)
		{
			P_0 = P_0.Replace("银龙锁月刀", "三苗九藜刀");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("三苗九藜刀") != -1)
		{
			P_0 = P_0.Replace("三苗九藜刀", "洪荒苍龙刀");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("洪荒苍龙刀") != -1)
		{
			P_0 = P_0.Replace("洪荒苍龙刀", "凤舞梦魇刀");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("凤舞梦魇刀") != -1)
		{
			P_0 = P_0.Replace("凤舞梦魇刀", "屠龙旋幽刀");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("屠龙旋幽刀") != -1)
		{
			P_0 = P_0.Replace("屠龙旋幽刀", "娲皇戮魂刀");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("噬魂魔爪") != -1)
		{
			P_0 = P_0.Replace("噬魂魔爪", "拂兰指");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("拂兰指") != -1)
		{
			P_0 = P_0.Replace("拂兰指", "啼血爪");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("啼血爪") != -1)
		{
			P_0 = P_0.Replace("啼血爪", "七巧玲珑爪");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("七巧玲珑爪") != -1)
		{
			P_0 = P_0.Replace("七巧玲珑爪", "镇魂摄天刺");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("镇魂摄天刺") != -1)
		{
			P_0 = P_0.Replace("镇魂摄天刺", "红绫火毒爪");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("红绫火毒爪") != -1)
		{
			P_0 = P_0.Replace("红绫火毒爪", "九幽伏魔爪");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("九幽伏魔爪") != -1)
		{
			P_0 = P_0.Replace("九幽伏魔爪", "刺骨追魂爪");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("刺骨追魂爪") != -1)
		{
			P_0 = P_0.Replace("刺骨追魂爪", "赤目锥心爪");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("赤目锥心爪") != -1)
		{
			P_0 = P_0.Replace("赤目锥心爪", "蚀骨绝殇爪");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("刺骨玄冥拳套") != -1)
		{
			P_0 = P_0.Replace("刺骨玄冥拳套", "阴阳八卦拳套");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("阴阳八卦拳套") != -1)
		{
			P_0 = P_0.Replace("阴阳八卦拳套", "遮天降魔拳套");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("遮天降魔拳套") != -1)
		{
			P_0 = P_0.Replace("遮天降魔拳套", "鬼藏惊鸿拳套");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("鬼藏惊鸿拳套") != -1)
		{
			P_0 = P_0.Replace("鬼藏惊鸿拳套", "孤星流魂拳套");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("孤星流魂拳套") != -1)
		{
			P_0 = P_0.Replace("孤星流魂拳套", "震臂罗刹拳套");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("震臂罗刹拳套") != -1)
		{
			P_0 = P_0.Replace("震臂罗刹拳套", "烈焰之心拳套");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("烈焰之心拳套") != -1)
		{
			P_0 = P_0.Replace("烈焰之心拳套", "五灵单符拳套");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("五灵单符拳套") != -1)
		{
			P_0 = P_0.Replace("五灵单符拳套", "煞仙封魔拳套");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("煞仙封魔拳套") != -1)
		{
			P_0 = P_0.Replace("煞仙封魔拳套", "钧天弑神指");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("九黎剑") != -1)
		{
			P_0 = P_0.Replace("九黎剑", "轩辕剑");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("轩辕剑") != -1)
		{
			P_0 = P_0.Replace("轩辕剑", "乙木神剑");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("乙木神剑") != -1)
		{
			P_0 = P_0.Replace("乙木神剑", "紫青玄魔剑");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("紫青玄魔剑") != -1)
		{
			P_0 = P_0.Replace("紫青玄魔剑", "封神诛仙剑");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("封神诛仙剑") != -1)
		{
			P_0 = P_0.Replace("封神诛仙剑", "九天玄冥剑");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("九天玄冥剑") != -1)
		{
			P_0 = P_0.Replace("九天玄冥剑", "赤魇遁龙剑");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("赤魇遁龙剑") != -1)
		{
			P_0 = P_0.Replace("赤魇遁龙剑", "聚灵神风剑");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("聚灵神风剑") != -1)
		{
			P_0 = P_0.Replace("聚灵神风剑", "倚天玄霜剑");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("倚天玄霜剑") != -1)
		{
			P_0 = P_0.Replace("倚天玄霜剑", "紫宸仙霞剑");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("邪灵绝钩") != -1)
		{
			P_0 = P_0.Replace("邪灵绝钩", "无相断魂戟");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("无相断魂戟") != -1)
		{
			P_0 = P_0.Replace("无相断魂戟", "戮仙双钩");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("戮仙双钩") != -1)
		{
			P_0 = P_0.Replace("戮仙双钩", "屠魔追风戟");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("屠魔追风戟") != -1)
		{
			P_0 = P_0.Replace("屠魔追风戟", "兽灵吞日钩");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("兽灵吞日钩") != -1)
		{
			P_0 = P_0.Replace("兽灵吞日钩", "蛟龙翻天戟");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("蛟龙翻天戟") != -1)
		{
			P_0 = P_0.Replace("蛟龙翻天戟", "鬼神烈双钩");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("鬼神烈双钩") != -1)
		{
			P_0 = P_0.Replace("鬼神烈双钩", "寒冰陷地戟");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("寒冰陷地戟") != -1)
		{
			P_0 = P_0.Replace("寒冰陷地戟", "玄幽凤舞戟");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("玄幽凤舞戟") != -1)
		{
			P_0 = P_0.Replace("玄幽凤舞戟", "啸海逐浪戟");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("蔽日扇") != -1)
		{
			P_0 = P_0.Replace("蔽日扇", "乾坤扇");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("乾坤扇") != -1)
		{
			P_0 = P_0.Replace("乾坤扇", "五彩神焰扇");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("五彩神焰扇") != -1)
		{
			P_0 = P_0.Replace("五彩神焰扇", "离火七翎扇");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("离火七翎扇") != -1)
		{
			P_0 = P_0.Replace("离火七翎扇", "赤霄烈焰扇");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("赤霄烈焰扇") != -1)
		{
			P_0 = P_0.Replace("赤霄烈焰扇", "红云火霞扇");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("红云火霞扇") != -1)
		{
			P_0 = P_0.Replace("红云火霞扇", "熠焰通灵扇");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("熠焰通灵扇") != -1)
		{
			P_0 = P_0.Replace("熠焰通灵扇", "降魔诛宇扇");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("降魔诛宇扇") != -1)
		{
			P_0 = P_0.Replace("降魔诛宇扇", "幽冥天使扇");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("幽冥天使扇") != -1)
		{
			P_0 = P_0.Replace("幽冥天使扇", "参商拓风扇");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("无影弓") != -1)
		{
			P_0 = P_0.Replace("无影弓", "震天弓");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("震天弓") != -1)
		{
			P_0 = P_0.Replace("震天弓", "龙舌断魂弓");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("龙舌断魂弓") != -1)
		{
			P_0 = P_0.Replace("龙舌断魂弓", "追魂嗜魄弓");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("追魂嗜魄弓") != -1)
		{
			P_0 = P_0.Replace("追魂嗜魄弓", "轩辕飞羽弓");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("轩辕飞羽弓") != -1)
		{
			P_0 = P_0.Replace("轩辕飞羽弓", "落日闭月弓");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("落日闭月弓") != -1)
		{
			P_0 = P_0.Replace("落日闭月弓", "流月飞星弓");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("流月飞星弓") != -1)
		{
			P_0 = P_0.Replace("流月飞星弓", "蛟龙玄铁弓");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("蛟龙玄铁弓") != -1)
		{
			P_0 = P_0.Replace("蛟龙玄铁弓", "邪龙灭世弓");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("邪龙灭世弓") != -1)
		{
			P_0 = P_0.Replace("邪龙灭世弓", "荧惑堕天弓");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("撼地锤") != -1)
		{
			P_0 = P_0.Replace("撼地锤", "破天锤");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("破天锤") != -1)
		{
			P_0 = P_0.Replace("破天锤", "加持杵");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("加持杵") != -1)
		{
			P_0 = P_0.Replace("加持杵", "炼狱麒麟杵");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("炼狱麒麟杵") != -1)
		{
			P_0 = P_0.Replace("炼狱麒麟杵", "风雷如意杵");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("风雷如意杵") != -1)
		{
			P_0 = P_0.Replace("风雷如意杵", "玄黄破坚锤");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("玄黄破坚锤") != -1)
		{
			P_0 = P_0.Replace("玄黄破坚锤", "玄天火龙锤");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("玄天火龙锤") != -1)
		{
			P_0 = P_0.Replace("玄天火龙锤", "四海镇天锤");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("四海镇天锤") != -1)
		{
			P_0 = P_0.Replace("四海镇天锤", "九天炼狱锤");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("九天炼狱锤") != -1)
		{
			P_0 = P_0.Replace("九天炼狱锤", "魔枭嗜血锤");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("玄冥寒冰斧") != -1)
		{
			P_0 = P_0.Replace("玄冥寒冰斧", "青光碎灵斧");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("青光碎灵斧") != -1)
		{
			P_0 = P_0.Replace("青光碎灵斧", "鬼魅残影斧");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("鬼魅残影斧") != -1)
		{
			P_0 = P_0.Replace("鬼魅残影斧", "烈焰凤头斧");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("烈焰凤头斧") != -1)
		{
			P_0 = P_0.Replace("烈焰凤头斧", "蓝宝旋风斧");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("蓝宝旋风斧") != -1)
		{
			P_0 = P_0.Replace("蓝宝旋风斧", "飞龙破天斧");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("飞龙破天斧") != -1)
		{
			P_0 = P_0.Replace("飞龙破天斧", "烈焰屠魔斧");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("烈焰屠魔斧") != -1)
		{
			P_0 = P_0.Replace("烈焰屠魔斧", "戮鬼祭天斧");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("戮鬼祭天斧") != -1)
		{
			P_0 = P_0.Replace("戮鬼祭天斧", "黑暗火凤斧");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("黑暗火凤斧") != -1)
		{
			P_0 = P_0.Replace("黑暗火凤斧", "凰炎烈天斧");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("飞龙圈") != -1)
		{
			P_0 = P_0.Replace("飞龙圈", "凤舞圈");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("凤舞圈") != -1)
		{
			P_0 = P_0.Replace("凤舞圈", "八宝叶圈");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("八宝叶圈") != -1)
		{
			P_0 = P_0.Replace("八宝叶圈", "鱼皮宝甲圈");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("鱼皮宝甲圈") != -1)
		{
			P_0 = P_0.Replace("鱼皮宝甲圈", "七星额子带");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("七星额子带") != -1)
		{
			P_0 = P_0.Replace("七星额子带", "三叉盘珠圈");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("三叉盘珠圈") != -1)
		{
			P_0 = P_0.Replace("三叉盘珠圈", "紫金八叉带");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("紫金八叉带") != -1)
		{
			P_0 = P_0.Replace("紫金八叉带", "九吞八乍带");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("九吞八乍带") != -1)
		{
			P_0 = P_0.Replace("九吞八乍带", "九天幻影");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("九天幻影") != -1)
		{
			P_0 = P_0.Replace("九天幻影", "飞仙玉策绦");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("蟠龙冠") != -1)
		{
			P_0 = P_0.Replace("蟠龙冠", "九霄烈焰冠");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("龙冠") != -1)
		{
			P_0 = P_0.Replace("龙冠", "蟠龙冠");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("九霄烈焰冠") != -1)
		{
			P_0 = ((P_1 != 1) ? P_0.Replace("云霄彩霞冠", "凌波霞冠") : P_0.Replace("九霄烈焰冠", "星耀冠"));
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("星耀冠") != -1)
		{
			P_0 = P_0.Replace("星耀冠", "七星宝冠");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("七星宝冠") != -1)
		{
			P_0 = P_0.Replace("七星宝冠", "白玉星冠");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("白玉星冠") != -1)
		{
			P_0 = P_0.Replace("白玉星冠", "双翼灵枭冠");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("双翼灵枭冠") != -1)
		{
			P_0 = P_0.Replace("双翼灵枭冠", "金翼龙冠");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("金翼龙冠") != -1)
		{
			P_0 = P_0.Replace("金翼龙冠", "太清玄冠");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("太清玄冠") != -1)
		{
			P_0 = P_0.Replace("太清玄冠", "飘渺琼华冠");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("凤冠") != -1)
		{
			P_0 = P_0.Replace("凤冠", "金霞冠");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("金霞冠") != -1)
		{
			P_0 = P_0.Replace("金霞冠", "云霄彩霞冠");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("凌波霞冠") != -1)
		{
			P_0 = P_0.Replace("凌波霞冠", "天灵宝冠");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("天灵宝冠") != -1)
		{
			P_0 = P_0.Replace("天灵宝冠", "九彩玲珠冠");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("九彩玲珠冠") != -1)
		{
			P_0 = P_0.Replace("九彩玲珠冠", "赤鸾翎羽冠");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("赤鸾翎羽冠") != -1)
		{
			P_0 = P_0.Replace("赤鸾翎羽冠", "菁麟宝冠");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("菁麟宝冠") != -1)
		{
			P_0 = P_0.Replace("菁麟宝冠", "玉清仙冠");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("玉清仙冠") != -1)
		{
			P_0 = P_0.Replace("玉清仙冠", "云根沧霞冠");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("连环甲") != -1)
		{
			P_0 = P_0.Replace("连环甲", "金缕衣");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("金缕衣") != -1)
		{
			P_0 = P_0.Replace("金缕衣", "天衣");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("天衣") != -1)
		{
			P_0 = P_0.Replace("天衣", "瀚宇法袍");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("瀚宇法袍") != -1)
		{
			P_0 = P_0.Replace("瀚宇法袍", "诸天法袍");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("诸天法袍") != -1)
		{
			P_0 = P_0.Replace("诸天法袍", "天玄真神甲");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("天玄真神甲") != -1)
		{
			P_0 = P_0.Replace("天玄真神甲", "赤金磐龙甲");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("赤金磐龙甲") != -1)
		{
			P_0 = P_0.Replace("赤金磐龙甲", "紫金神风甲");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("紫金神风甲") != -1)
		{
			P_0 = P_0.Replace("紫金神风甲", "五方银龙铠");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("五方银龙铠") != -1)
		{
			P_0 = P_0.Replace("五方银龙铠", "鸿溟混元铠");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("蛟皮袄") != -1)
		{
			P_0 = P_0.Replace("蛟皮袄", "天蚕衣");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("天蚕衣") != -1)
		{
			P_0 = P_0.Replace("天蚕衣", "霓裳羽衣");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("霓裳羽衣") != -1)
		{
			P_0 = P_0.Replace("霓裳羽衣", "星晶法衣");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("星晶法衣") != -1)
		{
			P_0 = P_0.Replace("星晶法衣", "神鸢凤裘");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("神鸢凤裘") != -1)
		{
			P_0 = P_0.Replace("神鸢凤裘", "万霞霓罗裳");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("万霞霓罗裳") != -1)
		{
			P_0 = P_0.Replace("万霞霓罗裳", "玄女绛绡衣");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("玄女绛绡衣") != -1)
		{
			P_0 = P_0.Replace("玄女绛绡衣", "凤翼轻裘");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("凤翼轻裘") != -1)
		{
			P_0 = P_0.Replace("凤翼轻裘", "烟罗紫轻绡");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("烟罗紫轻绡") != -1)
		{
			P_0 = P_0.Replace("烟罗紫轻绡", "紫翠丹霞衣");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		if (P_0.IndexOf("无影靴") != -1)
		{
			P_0 = P_0.Replace("无影靴", "天行履");
			P_0 = P_0.Replace("80级", "90级");
			P_0 = P_0.Replace("259:89", "259:90");
			P_0 = P_0.Replace("228:80", "228:90");
			return P_0;
		}
		if (P_0.IndexOf("天行履") != -1)
		{
			P_0 = P_0.Replace("天行履", "踏云靴");
			P_0 = P_0.Replace("90级", "100级");
			P_0 = P_0.Replace("259:99", "259:100");
			P_0 = P_0.Replace("228:90", "228:100");
			return P_0;
		}
		if (P_0.IndexOf("踏云靴") != -1)
		{
			P_0 = P_0.Replace("踏云靴", "御风履");
			P_0 = P_0.Replace("100级", "110级");
			P_0 = P_0.Replace("259:109", "259:110");
			P_0 = P_0.Replace("228:100", "228:110");
			return P_0;
		}
		if (P_0.IndexOf("御风履") != -1)
		{
			P_0 = P_0.Replace("御风履", "钧天履");
			P_0 = P_0.Replace("110级", "120级");
			P_0 = P_0.Replace("259:119", "259:120");
			P_0 = P_0.Replace("228:110", "228:120");
			return P_0;
		}
		if (P_0.IndexOf("钧天履") != -1)
		{
			P_0 = P_0.Replace("钧天履", "雷弧闪");
			P_0 = P_0.Replace("120级", "130级");
			P_0 = P_0.Replace("259:129", "259:130");
			P_0 = P_0.Replace("228:120", "228:130");
			return P_0;
		}
		if (P_0.IndexOf("雷弧闪") != -1)
		{
			P_0 = P_0.Replace("雷弧闪", "惊虹战靴");
			P_0 = P_0.Replace("130级", "140级");
			P_0 = P_0.Replace("259:139", "259:140");
			P_0 = P_0.Replace("228:130", "228:140");
			return P_0;
		}
		if (P_0.IndexOf("惊虹战靴") != -1)
		{
			P_0 = P_0.Replace("惊虹战靴", "煞影履");
			P_0 = P_0.Replace("140级", "150级");
			P_0 = P_0.Replace("259:149", "259:150");
			P_0 = P_0.Replace("228:140", "228:150");
			return P_0;
		}
		if (P_0.IndexOf("煞影履") != -1)
		{
			P_0 = P_0.Replace("煞影履", "奔逸绝尘靴");
			P_0 = P_0.Replace("150级", "160级");
			P_0 = P_0.Replace("259:159", "259:160");
			P_0 = P_0.Replace("228:150", "228:160");
			return P_0;
		}
		if (P_0.IndexOf("奔逸绝尘靴") != -1)
		{
			P_0 = P_0.Replace("奔逸绝尘靴", "杳冥寂风履");
			P_0 = P_0.Replace("160级", "170级");
			P_0 = P_0.Replace("259:169", "259:170");
			P_0 = P_0.Replace("228:160", "228:170");
			return P_0;
		}
		return string.Empty;
	}

	
	private string AitNctbwoZ(string P_0, string P_1, int P_2, bool P_3)
	{
		if (问道数据类.equip.TryGetValue(P_0, out 装备数据表 value))
		{
			int num = -1;
			if (P_1 == "五龙山云霄洞")
			{
				num = ((!P_3) ? 5 : 0);
			}
			else if (P_1 == "终南山玉柱洞")
			{
				num = (P_3 ? 1 : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_2 == 1) ? 10 : 6));
			}
			else if (P_1 == "凤凰山斗阙宫")
			{
				num = (P_3 ? 2 : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_2 == 2) ? 11 : 7));
			}
			else if (P_1 == "乾元山金光洞")
			{
				num = (P_3 ? 3 : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_2 == 2) ? 12 : 8));
			}
			else if (P_1 == "骷髅山白骨洞")
			{
				num = (P_3 ? 4 : ((Singleton<全局变量类>.I.门派转换配置.is四妖族 && P_2 == 1) ? 13 : 9));
			}
			if (num == -1)
			{
				return P_0;
			}
			return value.可转换名字[num];
		}
		return P_0;
	}

	
	private string t7ONnPtteF(string P_0, string P_1, string P_2)
	{
		if (!问道数据类.userSkill.TryGetValue(P_1, out 角色技能类 value))
		{
			return string.Empty;
		}
		if (!问道数据类.userSkill.TryGetValue(P_2, out 角色技能类 value2))
		{
			return string.Empty;
		}
		return P_0.Replace(value.遁术技能, value2.遁术技能).Replace(value.攻击技能1, value2.攻击技能1).Replace(value.攻击技能2, value2.攻击技能2)
			.Replace(value.攻击技能3, value2.攻击技能3)
			.Replace(value.攻击技能4, value2.攻击技能4)
			.Replace(value.攻击技能5, value2.攻击技能5)
			.Replace(value.障碍技能1, value2.障碍技能1)
			.Replace(value.障碍技能2, value2.障碍技能2)
			.Replace(value.障碍技能3, value2.障碍技能3)
			.Replace(value.障碍技能4, value2.障碍技能4)
			.Replace(value.障碍技能5, value2.障碍技能5)
			.Replace(value.辅助技能1, value2.辅助技能1)
			.Replace(value.辅助技能2, value2.辅助技能2)
			.Replace(value.辅助技能3, value2.辅助技能3)
			.Replace(value.辅助技能4, value2.辅助技能4)
			.Replace(value.辅助技能5, value2.辅助技能5)
			.Replace(value.飞升技能1, value2.飞升技能1)
			.Replace(value.飞升技能2, value2.飞升技能2)
			.Replace(value.飞升技能3, value2.飞升技能3)
			.Replace(value.飞升技能4, value2.飞升技能4);
	}

	
	internal void iIiN5qmkYH(string P_0, string P_1, string P_2, string P_3, int P_4, bool P_5)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("门派转换-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (!string.IsNullOrWhiteSpace(P_2))
			{
				string text = string.Empty;
				using (MySqlCommand mySqlCommand = new MySqlCommand())
				{
					mySqlCommand.Connection = mySqlConnection;
					mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + P_0 + "' ORDER BY name DESC";
					using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
					if (mySqlDataReader == null || !mySqlDataReader.Read())
					{
						return;
					}
					text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
				}
				全局变量类 i = Singleton<全局变量类>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
				defaultInterpolatedStringHandler.AppendLiteral("  【操作：门派转换前】 【账号：");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
				i.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear());
				string text2 = AitNctbwoZ(P_2, P_3, P_4, P_5);
				if (text.Contains("1:\"" + P_2 + ":", StringComparison.CurrentCulture))
				{
					text = text.Replace("1:\"" + P_2 + ":", "1:\"" + text2 + ":");
				}
				int dataChecksum = GetDataChecksum("user" + P_0 + "carry" + text);
				text = text.Replace("\\", "\\\\");
				全局变量类 i2 = Singleton<全局变量类>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
				defaultInterpolatedStringHandler.AppendLiteral("  【操作：门派转换后】 【账号：");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
				i2.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 3);
				defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
				defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
				defaultInterpolatedStringHandler.AppendLiteral("' where branch ='carry' and name ='");
				defaultInterpolatedStringHandler.AppendFormatted(P_0);
				defaultInterpolatedStringHandler.AppendLiteral("'");
				c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
			}
			bool flag = false;
			string text3 = string.Empty;
			using (MySqlCommand mySqlCommand2 = new MySqlCommand())
			{
				mySqlCommand2.Connection = mySqlConnection;
				mySqlCommand2.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='' and name ='" + P_0 + "' ORDER BY name DESC";
				using MySqlDataReader mySqlDataReader2 = mySqlCommand2.ExecuteReader();
				if (mySqlDataReader2 == null || !mySqlDataReader2.Read())
				{
					return;
				}
				text3 = XEYNKGEPKJ((byte[])mySqlDataReader2["bytedata"]);
			}
			全局变量类 i3 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：门派转换前2】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text3);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i3.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear());
			flag = text3.Contains("第一代弟子", StringComparison.CurrentCulture);
			text3.Contains("静笃虚极", StringComparison.CurrentCulture);
			string text4 = Singleton<ByteAPI>.I.文本_取出中间文本(text3, "\"master\":\"", "\",");
			string text5 = Singleton<ByteAPI>.I.文本_取出中间文本(text3, "\"polar\":", ",\"");
			string text6 = Singleton<ByteAPI>.I.文本_取出中间文本(text3, "\"gender\":", ",\"");
			string text7 = Singleton<ByteAPI>.I.文本_取出中间文本(text3, "\"religion\":", ",\"");
			if (问道数据类.userInfo.TryGetValue(text5 + text7 + text6, out 角色Info类 value))
			{
				string text8 = string.Empty;
				AllEnums.五行Type value2 = AllEnums.五行Type.无;
				if (P_3 == AllEnums.门派Type.五龙山云霄洞.ToString())
				{
					text8 = (flag ? "元始天尊" : "文殊天尊");
					value2 = AllEnums.五行Type.金;
				}
				else if (P_3 == AllEnums.门派Type.终南山玉柱洞.ToString())
				{
					text8 = (flag ? "准提道人" : "云中子");
					value2 = AllEnums.五行Type.木;
				}
				else if (P_3 == AllEnums.门派Type.凤凰山斗阙宫.ToString())
				{
					text8 = (flag ? "西方教主" : "龙吉公主");
					value2 = AllEnums.五行Type.水;
				}
				else if (P_3 == AllEnums.门派Type.乾元山金光洞.ToString())
				{
					text8 = (flag ? "太上老君" : "太乙真人");
					value2 = AllEnums.五行Type.火;
				}
				else if (P_3 == AllEnums.门派Type.骷髅山白骨洞.ToString())
				{
					text8 = (flag ? "通天教主" : "石矶娘娘");
					value2 = AllEnums.五行Type.土;
				}
				if (问道数据类.userInfo.TryGetValue($"{(int)value2}{(P_5 ? "1" : "2")}{text6}", out 角色Info类 value3))
				{
					text3 = text3.Replace("\"portrait\":" + value.形象, "\"portrait\":" + value3.形象);
					text3 = text3.Replace("\"icon\":" + value.形象, "\"icon\":" + value3.形象);
					string text9 = text3;
					string text10 = "\"polar\":";
					int 五行 = (int)value.五行;
					string oldValue = text10 + 五行;
					string text11 = "\"polar\":";
					五行 = (int)value3.五行;
					text3 = text9.Replace(oldValue, text11 + 五行);
					string text12 = text3;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("\"family\":\"");
					defaultInterpolatedStringHandler.AppendFormatted(value.门派);
					defaultInterpolatedStringHandler.AppendLiteral("\",");
					string oldValue2 = defaultInterpolatedStringHandler.ToStringAndClear();
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
					defaultInterpolatedStringHandler.AppendLiteral("\"family\":\"");
					defaultInterpolatedStringHandler.AppendFormatted(value3.门派);
					defaultInterpolatedStringHandler.AppendLiteral("\",");
					text3 = text12.Replace(oldValue2, defaultInterpolatedStringHandler.ToStringAndClear());
					text3 = text3.Replace("\"master\":\"" + text4 + "\",", "\"master\":\"" + text8 + "\",");
					string text13 = text3;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler.AppendLiteral("\"religion\":");
					defaultInterpolatedStringHandler.AppendFormatted((int)value.新旧);
					defaultInterpolatedStringHandler.AppendLiteral(",\"");
					string oldValue3 = defaultInterpolatedStringHandler.ToStringAndClear();
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
					defaultInterpolatedStringHandler.AppendLiteral("\"religion\":");
					defaultInterpolatedStringHandler.AppendFormatted((int)value3.新旧);
					defaultInterpolatedStringHandler.AppendLiteral(",\"");
					text3 = text13.Replace(oldValue3, defaultInterpolatedStringHandler.ToStringAndClear());
					全局变量类 i4 = Singleton<全局变量类>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
					defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
					defaultInterpolatedStringHandler.AppendLiteral("  【操作：门派转换后2】 【账号：");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
					defaultInterpolatedStringHandler.AppendFormatted(text3);
					defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
					i4.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
					int dataChecksum2 = GetDataChecksum("user" + P_0 + text3);
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(82, 3);
					defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
					defaultInterpolatedStringHandler.AppendFormatted(text3);
					defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
					defaultInterpolatedStringHandler.AppendFormatted(dataChecksum2);
					defaultInterpolatedStringHandler.AppendLiteral("' where path='user' and branch='' and name='");
					defaultInterpolatedStringHandler.AppendFormatted(P_0);
					defaultInterpolatedStringHandler.AppendLiteral("'");
					c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
					锁定账号操作(P_1, "0");
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_门派转换报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task w5lNMH6DIt(string P_0, int P_1, string P_2, 宠物存档数据类 P_3, int P_4)
	{
		try
		{
			using MySqlConnection conn = new MySqlConnection(ddbsql2);
			conn.Open();
			if (conn.State != ConnectionState.Open)
			{
				Log.Error("激活宠物同源属性-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(conn);
			using MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = "select CAST(content AS BINARY) AS bytedata from data where branch ='patch' and name ='" + Singleton<ByteAPI>.I.GetHexGid_(P_1) + "'";
			using MySqlDataReader 查询结果 = cmd.ExecuteReader();
			if (查询结果 == null)
			{
				Log.Error("[账号：" + P_2 + "]激活宠物失败，查询结果为空！");
				return;
			}
			if (!查询结果.Read())
			{
				Log.Error("[账号：" + P_2 + "]激活宠物失败，查询结果为空！");
				return;
			}
			string content = XEYNKGEPKJ((byte[])查询结果["bytedata"]);
			查询结果.Close();
			if (string.IsNullOrWhiteSpace(content))
			{
				Log.Error("[账号：" + P_2 + "]激活宠物失败，查询结果为空！");
				return;
			}
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：宠物同源前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(content);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(P_2, defaultInterpolatedStringHandler.ToStringAndClear());
			string text = Singleton<ByteAPI>.I.文本_取出中间文本(content, P_0, "])\",");
			if (string.IsNullOrWhiteSpace(text))
			{
				Log.Error("[账号：" + P_2 + "]激活宠物失败，查询宠物结果为空！");
				return;
			}
			text = P_0 + text + "])\",";
			string text2 = Singleton<ByteAPI>.I.文本_取出中间文本(text, ",66:([", "]),");
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text2, "2:", ","), out var result))
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[血量：");
				defaultInterpolatedStringHandler.AppendFormatted(result);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return;
			}
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text2, "37:", ","), out var result2))
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[法力：");
				defaultInterpolatedStringHandler.AppendFormatted(result2);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return;
			}
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text2, "36:", ","), out var result3))
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[速度：");
				defaultInterpolatedStringHandler.AppendFormatted(result3);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return;
			}
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text2, "108:", ","), out var result4))
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[物攻：");
				defaultInterpolatedStringHandler.AppendFormatted(result4);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return;
			}
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text2, "107:", ","), out var result5))
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[法攻：");
				defaultInterpolatedStringHandler.AppendFormatted(result5);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return;
			}
			result += P_4;
			result2 += P_4;
			result4 += P_4;
			result5 += P_4;
			result3 += P_4;
			foreach (宠物同源数据类 item in P_3.同源属性)
			{
				switch (item.同源成长)
				{
				case AllEnums.宠物成长Type.血量成长:
					result += item.成长数值;
					break;
				case AllEnums.宠物成长Type.法力成长:
					result2 += item.成长数值;
					break;
				case AllEnums.宠物成长Type.法攻成长:
					result5 += item.成长数值;
					break;
				case AllEnums.宠物成长Type.物攻成长:
					result4 += item.成长数值;
					break;
				case AllEnums.宠物成长Type.速度成长:
					result3 += item.成长数值;
					break;
				}
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 5);
			defaultInterpolatedStringHandler.AppendLiteral(",66:([107:");
			defaultInterpolatedStringHandler.AppendFormatted(result5);
			defaultInterpolatedStringHandler.AppendLiteral(",108:");
			defaultInterpolatedStringHandler.AppendFormatted(result4);
			defaultInterpolatedStringHandler.AppendLiteral(",37:");
			defaultInterpolatedStringHandler.AppendFormatted(result2);
			defaultInterpolatedStringHandler.AppendLiteral(",36:");
			defaultInterpolatedStringHandler.AppendFormatted(result3);
			defaultInterpolatedStringHandler.AppendLiteral(",2:");
			defaultInterpolatedStringHandler.AppendFormatted(result);
			defaultInterpolatedStringHandler.AppendLiteral(",]),");
			string newValue = defaultInterpolatedStringHandler.ToStringAndClear();
			string newValue2 = text.Replace(",66:([" + text2 + "]),", newValue);
			content = content.Replace(text, newValue2);
			int dataChecksum = GetDataChecksum("user" + Singleton<ByteAPI>.I.GetHexGid_(P_1) + "patch" + content);
			content = content.Replace("\\", "\\\\");
			content = content.Replace("'", "\\'");
			全局变量类 i2 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：宠物同源后】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(content);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i2.异常记录执行(P_2, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
			DB dB = this;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(92, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(content);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where path = 'user' and  branch ='patch' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.GetHexGid_(P_1));
			defaultInterpolatedStringHandler.AppendLiteral("'");
			if (await dB.w3HNUJWfp3(conn, defaultInterpolatedStringHandler.ToStringAndClear()) == 1)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
				defaultInterpolatedStringHandler.AppendLiteral("【操作：宠物同源后】成功 【账号：");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
				defaultInterpolatedStringHandler.AppendFormatted(content);
				defaultInterpolatedStringHandler.AppendLiteral("】");
				Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
				P_3.is同源激活 = true;
				P_3.转属次数 = 0;
				irWib79NaP(P_3.IID, P_3);
			}
		}
		catch (Exception ex)
		{
			Log.Error("激活宠物同源属性-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task OvlNheWUZG(string P_0, int P_1, string P_2, 宠物存档数据类 P_3, int P_4)
	{
		try
		{
			using MySqlConnection conn = new MySqlConnection(ddbsql2);
			conn.Open();
			if (conn.State != ConnectionState.Open)
			{
				Log.Error("遗忘宠物同源属性-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(conn);
			using MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = "select CAST(content AS BINARY) AS bytedata from data where branch ='patch' and name ='" + Singleton<ByteAPI>.I.GetHexGid_(P_1) + "'";
			using MySqlDataReader 查询结果 = cmd.ExecuteReader();
			if (查询结果 == null)
			{
				Log.Error("[账号：" + P_2 + "]遗忘宠物同源属性失败，查询结果为空1！");
				return;
			}
			if (!查询结果.Read())
			{
				Log.Error("[账号：" + P_2 + "]遗忘宠物同源属性失败，查询结果为空2！");
				return;
			}
			string content = XEYNKGEPKJ((byte[])查询结果["bytedata"]);
			查询结果.Close();
			if (string.IsNullOrWhiteSpace(content))
			{
				Log.Error("[账号：" + P_2 + "]遗忘宠物同源属性失败，查询结果为空3！");
				return;
			}
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：遗忘宠物同源属性前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(content);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(P_2, defaultInterpolatedStringHandler.ToStringAndClear());
			string text = Singleton<ByteAPI>.I.文本_取出中间文本(content, P_0, "])\",");
			if (string.IsNullOrWhiteSpace(text))
			{
				Log.Error("[账号：" + P_2 + "]遗忘宠物同源属性失败，查询宠物结果为空4！");
				return;
			}
			text = P_0 + text + "])\",";
			string text2 = Singleton<ByteAPI>.I.文本_取出中间文本(text, ",66:([", "]),");
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text2, "2:", ","), out var result))
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[血量：");
				defaultInterpolatedStringHandler.AppendFormatted(result);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return;
			}
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text2, "37:", ","), out var result2))
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[法力：");
				defaultInterpolatedStringHandler.AppendFormatted(result2);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return;
			}
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text2, "36:", ","), out var result3))
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[速度：");
				defaultInterpolatedStringHandler.AppendFormatted(result3);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return;
			}
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text2, "108:", ","), out var result4))
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[物攻：");
				defaultInterpolatedStringHandler.AppendFormatted(result4);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return;
			}
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text2, "107:", ","), out var result5))
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[法攻：");
				defaultInterpolatedStringHandler.AppendFormatted(result5);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				return;
			}
			result -= P_4;
			result2 -= P_4;
			result4 -= P_4;
			result5 -= P_4;
			result3 -= P_4;
			foreach (宠物同源数据类 item in P_3.同源属性)
			{
				switch (item.同源成长)
				{
				case AllEnums.宠物成长Type.血量成长:
					result -= item.成长数值;
					break;
				case AllEnums.宠物成长Type.法力成长:
					result2 -= item.成长数值;
					break;
				case AllEnums.宠物成长Type.法攻成长:
					result5 -= item.成长数值;
					break;
				case AllEnums.宠物成长Type.物攻成长:
					result4 -= item.成长数值;
					break;
				case AllEnums.宠物成长Type.速度成长:
					result3 -= item.成长数值;
					break;
				}
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 5);
			defaultInterpolatedStringHandler.AppendLiteral(",66:([107:");
			defaultInterpolatedStringHandler.AppendFormatted(result5);
			defaultInterpolatedStringHandler.AppendLiteral(",108:");
			defaultInterpolatedStringHandler.AppendFormatted(result4);
			defaultInterpolatedStringHandler.AppendLiteral(",37:");
			defaultInterpolatedStringHandler.AppendFormatted(result2);
			defaultInterpolatedStringHandler.AppendLiteral(",36:");
			defaultInterpolatedStringHandler.AppendFormatted(result3);
			defaultInterpolatedStringHandler.AppendLiteral(",2:");
			defaultInterpolatedStringHandler.AppendFormatted(result);
			defaultInterpolatedStringHandler.AppendLiteral(",]),");
			string newValue = defaultInterpolatedStringHandler.ToStringAndClear();
			string newValue2 = text.Replace(",66:([" + text2 + "]),", newValue);
			content = content.Replace(text, newValue2);
			int dataChecksum = GetDataChecksum("user" + Singleton<ByteAPI>.I.GetHexGid_(P_1) + "patch" + content);
			content = content.Replace("\\", "\\\\");
			content = content.Replace("'", "\\'");
			全局变量类 i2 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：遗忘宠物同源属性后】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(content);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i2.异常记录执行(P_2, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
			DB dB = this;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(92, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(content);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where path = 'user' and  branch ='patch' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.GetHexGid_(P_1));
			defaultInterpolatedStringHandler.AppendLiteral("'");
			if (await dB.w3HNUJWfp3(conn, defaultInterpolatedStringHandler.ToStringAndClear()) == 1)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
				defaultInterpolatedStringHandler.AppendLiteral("【操作：遗忘宠物同源属性后】成功 【账号：");
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
				defaultInterpolatedStringHandler.AppendFormatted(content);
				defaultInterpolatedStringHandler.AppendLiteral("】");
				Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
				P_3.is同源激活 = false;
				P_3.转属次数 = 0;
				P_3.同源属性.Clear();
				irWib79NaP(P_3.IID, P_3);
			}
		}
		catch (Exception ex)
		{
			Log.Error("遗忘宠物同源属性-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task L3cNvWKwjx(MyNATSocketClient P_0, bool P_1)
	{
		try
		{
			string 临时GID = Singleton<ByteAPI>.I.GetHexGid_(P_0.user.人物数据.GID);
			using MySqlConnection conn = new MySqlConnection(ddbsql2);
			conn.Open();
			if (conn.State != ConnectionState.Open)
			{
				Log.Error("角色一键飞升操作-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(conn);
			using MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = "select CAST(content AS BINARY) AS bytedata from data where branch ='' and path = 'user' and name ='" + 临时GID + "'";
			using MySqlDataReader 查询结果 = cmd.ExecuteReader();
			if (查询结果 == null || !查询结果.Read())
			{
				return;
			}
			string content = XEYNKGEPKJ((byte[])查询结果["bytedata"]);
			查询结果.Close();
			if (string.IsNullOrWhiteSpace(content))
			{
				return;
			}
			if (content.Contains("\"upgrade_attrib\"", StringComparison.CurrentCulture) && P_0.user.属性数据.等级 > 134)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#G本角色已经飞升，无需再次飞升！"));
				return;
			}
			if (Singleton<全局变量类>.I.一键大飞配置.消耗数值类型 == AllEnums.数值Type.金元宝)
			{
				if (P_0.user.背包数据.金元宝 < Singleton<全局变量类>.I.一键大飞配置.消耗数值)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y金元宝#n不足，无法进行一键飞升！"));
					return;
				}
				if (!cAJNoOkab6(P_0, -Singleton<全局变量类>.I.一键大飞配置.消耗数值, 0))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y金元宝#n扣除失败，无法进行一键飞升！"));
					return;
				}
			}
			else if (Singleton<全局变量类>.I.一键大飞配置.消耗数值类型 == AllEnums.数值Type.银元宝)
			{
				if (P_0.user.背包数据.银元宝 < Singleton<全局变量类>.I.一键大飞配置.消耗数值)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y银元宝#n不足，无法进行一键飞升！"));
					return;
				}
				if (!cAJNoOkab6(P_0, 0, -Singleton<全局变量类>.I.一键大飞配置.消耗数值))
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#Y银元宝#n扣除失败，无法进行一键飞升！"));
					return;
				}
			}
			string 玩家账号 = P_0.user.人物数据.账号;
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#G角色已经飞升，即将自动下线，10秒以后再上线查看！"));
			if (!I.锁定账号操作(玩家账号, "1"))
			{
				Log.Error("一键飞升-错误：账号锁定失败");
				return;
			}
			Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
			Log.Error("一键飞升-错误：[" + P_0.user.人物数据.昵称 + "]强制下线");
			await Task.Delay(5000);
			content = "飞升替换" + content;
			content = content.Replace("飞升替换([", "(" + (P_1 ? "[\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":7008,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":1,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":134,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":1080000,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":7008,])," : "[\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":7009,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":134,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":1080000,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":7009,]),"));
			string text = Singleton<ByteAPI>.I.文本_取出中间文本(content, "\"polar\":", ",\"");
			string text2 = Singleton<ByteAPI>.I.文本_取出中间文本(content, "\"religion\":", ",\"");
			string oldValue = "\"skills\":([" + Singleton<ByteAPI>.I.文本_取出中间文本(content, "\"skills\":([", "])") + "])";
			string text3 = string.Empty;
			int 飞升到等级 = Singleton<全局变量类>.I.一键大飞配置.飞升到等级;
			double value = (Singleton<全局变量类>.I.一键大飞配置.大飞后技能是否精研 ? ((double)(飞升到等级 * 2)) : ((double)飞升到等级 * 1.6));
			if (text + text2 == "11")
			{
				text3 = "\"jinguang-zhaxian\":数值,\"daoguang-jianying\":数值,\"jinhong-guanri\":数值,\"liuguang-yicai\":数值,\"nitian-canren\":数值,\"liulian-wangfan\":数值,\"deyi-wangxing\":数值,\"ruchi-ruzui\":数值,\"rumeng-chuxing\":数值,\"huangruo-geshi\":数值,\"tiansheng-shenli\":数值,\"qichong-douniu\":数值,\"jiuniu-erhu\":数值,\"ruhu-tianyi\":数值,\"liwan-kuanglan\":数值,\"jinbi-huihuang\":数值,\"zhidao-huanglong\":数值,\"jincheng-tangchi\":数值,\"jinfa-fenghun\":数值,".Replace("数值", $"{value}") + "\"jindun-shu\":1,\"jingying-zhidao\":1,";
			}
			else if (text + text2 == "12")
			{
				text3 = "\"dandao-zhiru\":数值,\"ruibu-kedang\":数值,\"qiandao-wanren\":数值,\"fengmang-bilou\":数值,\"wandao-jinguang\":数值,\"buzhi-suocuo\":数值,\"danzhan-xinjing\":数值,\"jinghun-weiding\":数值,\"zhenhun-suoxin\":数值,\"duoshen-shepo\":数值,\"quanli-yifu\":数值,\"qiguan-changhong\":数值,\"jianba-nuzhang\":数值,\"shiru-pozhu\":数值,\"lipi-xuanhuang\":数值,\"jinbi-huihuang\":数值,\"zhidao-huanglong\":数值,\"jincheng-tangchi\":数值,\"jinfa-fenghun\":数值,".Replace("数值", $"{value}") + "\"jindun-shu\":1,\"jingying-zhidao\":1,";
			}
			else if (text + text2 == "21")
			{
				text3 = "\"zhaiye-feihua\":数值,\"feiliu-xianshi\":数值,\"pangen-cuojie\":数值,\"luoying-binfen\":数值,\"guiwu-kuteng\":数值,\"jianxie-fenghou\":数值,\"shekou-fengzhen\":数值,\"heding-hongfen\":数值,\"xiewei-shexian\":数值,\"wanyi-shixin\":数值,\"bamiao-zhuzhang\":数值,\"huoshang-jiaoyou\":数值,\"shuizhang-chuangao\":数值,\"honghua-lvye\":数值,\"jinshang-tianhua\":数值,\"luoye-xiaoxiao\":数值,\"manwu-feitian\":数值,\"baidu-buqin\":数值,\"judu-gongxin\":数值,".Replace("数值", $"{value}") + "\"mudun-shu\":1,\"jingying-zhidao\":1,";
			}
			else if (text + text2 == "22")
			{
				text3 = "\"huawu-yefei\":数值,\"yanghua-feiliu\":数值,\"qiufeng-saoye\":数值,\"yiye-puti\":数值,\"tiannv-sanhua\":数值,\"mangci-zaibei\":数值,\"wufu-chongsheng\":数值,\"duru-gusui\":数值,\"jiusi-yisheng\":数值,\"zhetian-biri\":数值,\"ganzhi-ruyi\":数值,\"chunfeng-huayu\":数值,\"runwu-wusheng\":数值,\"tihu-guanding\":数值,\"miaoshou-huichun\":数值,\"luoye-xiaoxiao\":数值,\"manwu-feitian\":数值,\"baidu-buqin\":数值,\"judu-gongxin\":数值,".Replace("数值", $"{value}") + "\"mudun-shu\":1,\"jingying-zhidao\":1,";
			}
			else if (text + text2 == "31")
			{
				text3 = "\"dishui-chuanshi\":数值,\"yuhen-yunchou\":数值,\"xuanhe-xieshui\":数值,\"nubo-kuangtao\":数值,\"jiaohai-fanjiang\":数值,\"sanjiu-yanhan\":数值,\"tianhan-didong\":数值,\"bingdong-sanchi\":数值,\"jidi-binghan\":数值,\"baoluo-wanxiang\":数值,\"fangwei-dujian\":数值,\"tiegu-zhengzheng\":数值,\"binglai-jiangdang\":数值,\"tongqiang-tiebi\":数值,\"tiandi-hunyuan\":数值,\"shuitian-yise\":数值,\"tiema-binghe\":数值,\"shuangjia-bingdun\":数值,\"xuepiao-wanli\":数值,".Replace("数值", $"{value}") + "\"shuidun-shu\":1,\"jingying-zhidao\":1,";
			}
			else if (text + text2 == "32")
			{
				text3 = "\"shuiliu-huaxie\":数值,\"jishui-chengyuan\":数值,\"fengqi-shuiyong\":数值,\"xueyao-bingtian\":数值,\"jiaolong-deshui\":数值,\"dishui-bulou\":数值,\"shengou-bilei\":数值,\"jixue-fengshuang\":数值,\"riyue-hebi\":数值,\"jinghua-shuiyue\":数值,\"tugu-naxin\":数值,\"fanghuan-weiran\":数值,\"hunran-yiti\":数值,\"yuxiao-yunsan\":数值,\"shuihuo-buqin\":数值,\"shuitian-yise\":数值,\"tiema-binghe\":数值,\"shuangjia-bingdun\":数值,\"xuepiao-wanli\":数值,".Replace("数值", $"{value}") + "\"shuidun-shu\":1,\"jingying-zhidao\":1,";
			}
			else if (text + text2 == "41")
			{
				text3 = "\"juhuo-fentian\":数值,\"xinghuo-liaoyuan\":数值,\"yantian-huoyu\":数值,\"jiaojin-lishi\":数值,\"lianyu-huohai\":数值,\"xinzui-shenmi\":数值,\"shenhun-diandao\":数值,\"hunbu-shoushe\":数值,\"hunqian-mengying\":数值,\"hunbu-futi\":数值,\"shiwan-huoji\":数值,\"xiansheng-duoren\":数值,\"jifeng-xunlei\":数值,\"fengchi-dianche\":数值,\"binggui-shensu\":数值,\"huoshu-yinhua\":数值,\"huifei-yanmie\":数值,\"sanmei-lianxin\":数值,\"lihuo-duopo\":数值,".Replace("数值", $"{value}") + "\"huodun-shu\":1,\"jingying-zhidao\":1,";
			}
			else if (text + text2 == "42")
			{
				text3 = "\"nujian-lixian\":数值,\"yijian-shuangdiao\":数值,\"jianbu-xufa\":数值,\"xingfei-yunsan\":数值,\"wanjian-chuanxin\":数值,\"xinsuo-shenfeng\":数值,\"chongyuan-diesuo\":数值,\"rufeng-sibi\":数值,\"kunling-suoxin\":数值,\"yunmi-wusuo\":数值,\"jiru-xinghuo\":数值,\"xingchi-dianzou\":数值,\"dianguang-shihuo\":数值,\"feiyun-zhidian\":数值,\"huxiao-fengchi\":数值,\"huoshu-yinhua\":数值,\"huifei-yanmie\":数值,\"sanmei-lianxin\":数值,\"lihuo-duopo\":数值,".Replace("数值", $"{value}") + "\"huodun-shu\":1,\"jingying-zhidao\":1,";
			}
			else if (text + text2 == "51")
			{
				text3 = "\"luotu-feiyan\":数值,\"tumo-chenmai\":数值,\"shanbeng-dilie\":数值,\"tianta-dixian\":数值,\"shipo-tianjing\":数值,\"youxin-wuli\":数值,\"guci-shibi\":数值,\"liushen-wuzhu\":数值,\"dishu-qipo\":数值,\"tianding-sanhun\":数值,\"bianchang-moji\":数值,\"wangfeng-puying\":数值,\"huaxian-weiyi\":数值,\"bishi-jiuxu\":数值,\"yixing-huanying\":数值,\"feisha-zoushi\":数值,\"kaibei-lieshi\":数值,\"xinru-panshi\":数值,\"diwo-nanfen\":数值,".Replace("数值", $"{value}") + "\"tudun-shu\":1,\"jingying-zhidao\":1,";
			}
			else if (text + text2 == "52")
			{
				text3 = "\"tubeng-wajie\":数值,\"chentu-feiyang\":数值,\"yangli-feisha\":数值,\"didong-shanyao\":数值,\"qianyan-wanhe\":数值,\"jinghuang-shicuo\":数值,\"ranshen-luanzhi\":数值,\"shenhun-piaodang\":数值,\"shenyao-yiduo\":数值,\"jingshen-podan\":数值,\"xuxu-shishi\":数值,\"gunong-xuanxu\":数值,\"konghuan-xushi\":数值,\"xukong-huanying\":数值,\"xuwu-piaomiao\":数值,\"feisha-zoushi\":数值,\"kaibei-lieshi\":数值,\"xinru-panshi\":数值,\"diwo-nanfen\":数值,".Replace("数值", $"{value}") + "\"tudun-shu\":1,\"jingying-zhidao\":1,";
			}
			string text4 = text3;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(78, 1);
			defaultInterpolatedStringHandler.AppendLiteral("\"lipo-qianjun\":");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(",\"wanxiang-yuhua\":264,\"zhulian-bihe\":264,\"leiting-qianjun\":264,");
			text3 = text4 + defaultInterpolatedStringHandler.ToStringAndClear();
			content = content.Replace(oldValue, "\"skills\":([" + text3 + "])");
			if (content.Contains("\"polar_metal\"", StringComparison.CurrentCulture))
			{
				content = content.Replace("\"polar_metal\"", "\"has_upgraded\":1,\"extra_life\":0,\"polar_metal\"");
			}
			if (content.Contains("\"previous_login_ip\"", StringComparison.CurrentCulture))
			{
				content = content.Replace("\"previous_login_ip\"", "\"upgrade\":([\"max_polar_extra\":12,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":0,\"type\":4,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"con\":0,\"ever_lv\":139,\"total\":10,\"immortal\":10,\"cur_ver\":6,\"magic\":10,]),\"previous_login_ip\"");
				foreach (Match item in new Regex("(?<=\\\"level\":)\\d+(?=\\,)").Matches(content))
				{
					content = content.Replace("\"level\":" + item.Value + ",", "\"level\":" + 飞升到等级 + ",");
				}
			}
			int dataChecksum = GetDataChecksum("user" + 临时GID + content);
			content = content.Replace("\\", "\\\\");
			content = content.Replace("'", "\\'");
			DB dB = this;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(83, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(content);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where path='user' and branch='' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(临时GID);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			dB.c1ZNsjqlRc(conn, defaultInterpolatedStringHandler.ToStringAndClear());
			锁定账号操作(玩家账号, "0");
		}
		catch (Exception ex)
		{
			Log.Error("角色一键飞升操作-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task lcMN7neI7I(MyNATSocketClient P_0)
	{
		try
		{
			string 临时GID = Singleton<ByteAPI>.I.GetHexGid_(P_0.user.人物数据.GID);
			_ = P_0.user.人物数据.昵称;
			string 玩家账号 = P_0.user.人物数据.账号;
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#G尊敬的道友，您已成功修炼法宝共生，为保证数据安全，将与服务器短暂断开连接，稍后重新上线即可，谢谢！"));
			if (!I.锁定账号操作(玩家账号, "1"))
			{
				Log.Error("法宝共生操作-错误：账号锁定失败");
				return;
			}
			Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
			Log.Error("法宝共生操作-错误：[" + P_0.user.人物数据.昵称 + "]强制下线");
			await Task.Delay(5000);
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("角色开通法宝共生操作-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where branch ='' and path = 'user' and name ='" + 临时GID + "'";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null || !mySqlDataReader.Read())
			{
				return;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：法宝共生前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(玩家账号);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(玩家账号, defaultInterpolatedStringHandler.ToStringAndClear());
			text = string.Concat(Singleton<WdAPI>.I.JQloMTM30O(text, "", "\"pker\":0,"), str2: Singleton<WdAPI>.I.JQloMTM30O(text, "\"pker\":0,").Replace("\"skills\":([", "\"skills\":([\"fabao-gongsheng\":1,"), str1: "\"pker\":0,\"assist_equip\":1,");
			int dataChecksum = GetDataChecksum("user" + 临时GID + text);
			text = text.Replace("\\", "\\\\");
			全局变量类 i2 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：法宝共生后】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(玩家账号);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i2.异常记录执行(玩家账号, defaultInterpolatedStringHandler.ToStringAndClear());
			DB dB = this;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(83, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where path='user' and branch='' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(临时GID);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			dB.c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
			锁定账号操作(玩家账号, "0");
		}
		catch (Exception ex)
		{
			Log.Error("角色开通法宝共生操作-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal bool sAYNamlSOP(MyNATSocketClient P_0)
	{
		try
		{
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(P_0.user.人物数据.GID);
			_ = P_0.user.人物数据.昵称;
			_ = P_0.user.人物数据.账号;
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("查询角色元神合体状态-mysql数据库连接失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where branch ='' and path = 'user' and name ='" + hexGid_ + "'";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null)
			{
				return false;
			}
			if (!mySqlDataReader.Read())
			{
				return false;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			return text.IndexOf("cur_attrib_plan") != -1;
		}
		catch (Exception ex)
		{
			Log.Error("角色开通元神合体操作-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal async Task w0pNTI2rmG(MyNATSocketClient P_0)
	{
		try
		{
			string 临时GID = Singleton<ByteAPI>.I.GetHexGid_(P_0.user.人物数据.GID);
			_ = P_0.user.人物数据.昵称;
			string 玩家账号 = P_0.user.人物数据.账号;
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#G尊敬的道友，您已成功学习了元神合体，为保证数据安全，将与服务器短暂断开连接，稍后重新上线即可，谢谢！"));
			if (!I.锁定账号操作(玩家账号, "1"))
			{
				Log.Error("元神合体操作-错误：账号锁定失败");
				return;
			}
			Singleton<WdAPI>.I.WT9IHmFS6c(P_0, P_0.user.人物数据.昵称);
			Log.Error("角色开通元神合体操作-错误：[" + P_0.user.人物数据.昵称 + "]强制下线");
			await Task.Delay(5000);
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("角色开通元神合体操作-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where branch ='' and path = 'user' and name ='" + 临时GID + "'";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null || !mySqlDataReader.Read())
			{
				return;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			text = text.Replace("\"me\":([", "\"me\":([\"finish_ysht\":1,\"backup_attrib_plan\":([\"wood\":0,\"attrib_already\":([\"total\":0,\"wiz\":0,]),\"earth\":0,\"water\":0,\"polar_point\":0,\"upgrade_magic\":0,\"upgrade_immortal\":0,\"fire\":0,\"attrib_point\":0,\"cur_attrib_plan\":2,\"metal\":0,\"upgrade\":([\"dex\":0,\"attrib_point\":0,\"con\":0,\"str\":0,\"wiz\":0,]),]),\"cur_attrib_plan\":1,");
			int dataChecksum = GetDataChecksum("user" + 临时GID + text);
			text = text.Replace("\\", "\\\\");
			DB dB = this;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(83, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where path='user' and branch='' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(临时GID);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			dB.c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
			锁定账号操作(玩家账号, "0");
		}
		catch (Exception ex)
		{
			Log.Error("角色开通元神合体操作-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void KknN9e9GTK(MyNATSocketClient P_0)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("刷新背包物品IID-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + Singleton<ByteAPI>.I.GetHexGid_(P_0.user.人物数据.GID) + "' ORDER BY name DESC";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null || !mySqlDataReader.Read())
			{
				return;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			for (int i = 101; i < 181; i++)
			{
				if (P_0.user.背包数据.物品列表[i] == null || string.IsNullOrWhiteSpace(P_0.user.背包数据.物品列表[i].名字))
				{
					continue;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendFormatted(i);
				defaultInterpolatedStringHandler.AppendLiteral(":\"");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.背包数据.物品列表[i].名字);
				string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
				if (!text.Contains(text2, StringComparison.CurrentCulture) || string.IsNullOrWhiteSpace(Singleton<ByteAPI>.I.文本_取出中间文本(text, text2, "])\",")))
				{
					continue;
				}
				int num = text.IndexOf(text2);
				if (num != -1)
				{
					string text3 = Singleton<ByteAPI>.I.文本_取出中间文本(text, "233::", ",", num);
					if (!string.IsNullOrWhiteSpace(text3))
					{
						P_0.user.背包数据.物品列表[i].IID = ":" + text3;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("刷新背包物品IID-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal List<洗炼属性缓存列表类> JevNyLC1UJ(int P_0, int P_1, string P_2, string P_3)
	{
		List<洗炼属性缓存列表类> list = new List<洗炼属性缓存列表类>();
		try
		{
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(P_0);
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("Mysql_蓝粉洗炼属性读取-mysql数据库连接失败！");
				return list;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + hexGid_ + "' ORDER BY name DESC";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null)
			{
				return list;
			}
			if (!mySqlDataReader.Read())
			{
				return list;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			if (string.IsNullOrWhiteSpace(text))
			{
				return list;
			}
			if (!text.Contains("233::" + P_3 + ":", StringComparison.CurrentCulture))
			{
				return list;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(":\"");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			string 文本前缀 = defaultInterpolatedStringHandler.ToStringAndClear();
			string text2 = Singleton<ByteAPI>.I.文本_取出中间文本(text, 文本前缀, "])\",");
			if (!text2.Contains("233::" + P_3 + ":", StringComparison.CurrentCulture))
			{
				for (int i = 101; i < 181; i++)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
					defaultInterpolatedStringHandler.AppendFormatted(i);
					defaultInterpolatedStringHandler.AppendLiteral(":\"");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					string text3 = defaultInterpolatedStringHandler.ToStringAndClear();
					string text4 = Singleton<ByteAPI>.I.文本_取出中间文本(text, text3, "])\",");
					if (text4.Contains("233::" + P_3 + ":", StringComparison.CurrentCulture))
					{
						文本前缀 = text3;
						text2 = text4;
					}
				}
			}
			if (string.IsNullOrWhiteSpace(text2))
			{
				return list;
			}
			string text5 = ((text2.IndexOf("229:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text2, "229:([", "]),") : string.Empty);
			string text6 = ((text2.IndexOf("231:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text2, "231:([", "]),") : string.Empty);
			if (string.IsNullOrWhiteSpace(text5) && string.IsNullOrWhiteSpace(text6))
			{
				return list;
			}
			string[] array = text5.Split(",");
			string[] array2 = text6.Split(",");
			for (int j = 0; j < array.Length; j++)
			{
				if (string.IsNullOrWhiteSpace(array[j]))
				{
					continue;
				}
				string[] array3 = array[j].Split(":");
				if (array3.Length == 2)
				{
					洗炼属性缓存列表类 洗炼属性缓存列表类2 = new 洗炼属性缓存列表类();
					if (Enum.TryParse<AllEnums.洗炼属性Type>(array3[0], out 洗炼属性缓存列表类2.属性) && int.TryParse(array3[1], out 洗炼属性缓存列表类2.数值))
					{
						list.Add(洗炼属性缓存列表类2);
					}
				}
			}
			for (int k = 0; k < array2.Length; k++)
			{
				if (string.IsNullOrWhiteSpace(array2[k]))
				{
					continue;
				}
				string[] array4 = array2[k].Split(":");
				if (array4.Length == 2)
				{
					洗炼属性缓存列表类 洗炼属性缓存列表类3 = new 洗炼属性缓存列表类();
					if (Enum.TryParse<AllEnums.洗炼属性Type>(array4[0], out 洗炼属性缓存列表类3.属性) && int.TryParse(array4[1], out 洗炼属性缓存列表类3.数值))
					{
						list.Add(洗炼属性缓存列表类3);
					}
				}
			}
			return list;
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_蓝粉洗炼属性读取：" + ex.Message + "(" + ex.StackTrace + ")");
			return list;
		}
	}

	
	internal List<洗炼属性缓存列表类> A1gNCx0GiF(int P_0, int P_1, string P_2, string P_3)
	{
		List<洗炼属性缓存列表类> list = new List<洗炼属性缓存列表类>();
		try
		{
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(P_0);
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("Mysql_黄绿洗炼属性读取-mysql数据库连接失败！");
				return list;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + hexGid_ + "' ORDER BY name DESC";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null)
			{
				return list;
			}
			if (!mySqlDataReader.Read())
			{
				return list;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			if (string.IsNullOrWhiteSpace(text))
			{
				return list;
			}
			if (!text.Contains("233::" + P_3 + ":", StringComparison.CurrentCulture))
			{
				return list;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(":\"");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			string 文本前缀 = defaultInterpolatedStringHandler.ToStringAndClear();
			string text2 = Singleton<ByteAPI>.I.文本_取出中间文本(text, 文本前缀, "])\",");
			if (!text2.Contains("233::" + P_3 + ":", StringComparison.CurrentCulture))
			{
				for (int i = 101; i < 181; i++)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
					defaultInterpolatedStringHandler.AppendFormatted(i);
					defaultInterpolatedStringHandler.AppendLiteral(":\"");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					string text3 = defaultInterpolatedStringHandler.ToStringAndClear();
					string text4 = Singleton<ByteAPI>.I.文本_取出中间文本(text, text3, "])\",");
					if (text4.Contains("233::" + P_3 + ":", StringComparison.CurrentCulture))
					{
						文本前缀 = text3;
						text2 = text4;
					}
				}
			}
			if (string.IsNullOrWhiteSpace(text2))
			{
				return list;
			}
			string text5 = ((text2.IndexOf("236:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text2, "236:([", "]),") : string.Empty);
			string text6 = ((text2.IndexOf("234:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text2, "234:([", "]),") : string.Empty);
			if (string.IsNullOrWhiteSpace(text5) && string.IsNullOrWhiteSpace(text6))
			{
				return list;
			}
			string[] array = text5.Split(",");
			string[] array2 = text6.Split(",");
			for (int j = 0; j < array.Length; j++)
			{
				if (string.IsNullOrWhiteSpace(array[j]))
				{
					continue;
				}
				string[] array3 = array[j].Split(":");
				if (array3.Length == 2)
				{
					洗炼属性缓存列表类 洗炼属性缓存列表类2 = new 洗炼属性缓存列表类();
					if (Enum.TryParse<AllEnums.洗炼属性Type>(array3[0], out 洗炼属性缓存列表类2.属性) && int.TryParse(array3[1], out 洗炼属性缓存列表类2.数值))
					{
						list.Add(洗炼属性缓存列表类2);
					}
				}
			}
			for (int k = 0; k < array2.Length; k++)
			{
				if (string.IsNullOrWhiteSpace(array2[k]))
				{
					continue;
				}
				string[] array4 = array2[k].Split(":");
				if (array4.Length == 2)
				{
					洗炼属性缓存列表类 洗炼属性缓存列表类3 = new 洗炼属性缓存列表类();
					if (Enum.TryParse<AllEnums.洗炼属性Type>(array4[0], out 洗炼属性缓存列表类3.属性) && int.TryParse(array4[1], out 洗炼属性缓存列表类3.数值))
					{
						list.Add(洗炼属性缓存列表类3);
					}
				}
			}
			return list;
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_黄绿洗炼属性读取报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return list;
		}
	}

	
	internal void C2XNVmntJa(int P_0, string P_1, string P_2, int P_3, string P_4, 洗炼属性缓存数据类 P_5, Action<bool> P_6 = null)
	{
		try
		{
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(P_0);
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("Mysql_洗炼属性更新时装-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + hexGid_ + "' ORDER BY name DESC";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null || !mySqlDataReader.Read())
			{
				return;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：洗炼时装前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear());
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted(P_3);
			defaultInterpolatedStringHandler.AppendLiteral(":\"");
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (!text.Contains(text2, StringComparison.CurrentCulture))
			{
				return;
			}
			string text3 = Singleton<ByteAPI>.I.文本_取出中间文本(text, text2, "])\",");
			if (string.IsNullOrWhiteSpace(text3))
			{
				return;
			}
			string text4 = text3;
			Singleton<ByteAPI>.I.文本_取出中间文本(text3, "233::", ":");
			string text5 = ((text3.IndexOf("229:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, "229:([", "]),") : string.Empty);
			string text6 = ((text3.IndexOf("231:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, "231:([", "]),") : string.Empty);
			string text7 = string.Empty;
			string text8 = string.Empty;
			StringBuilder stringBuilder = new StringBuilder();
			for (int j = 0; j < P_5.属性列表.Count; j++)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 4, stringBuilder2);
				handler.AppendFormatted((j != 0) ? "#r" : string.Empty);
				handler.AppendLiteral("#B洗炼：");
				handler.AppendFormatted(P_5.属性列表[j].属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_5.属性列表[j].数值);
				handler.AppendFormatted(Singleton<AllEnums>.I.洗炼属性是否比例(P_5.属性列表[j].属性) ? "%" : string.Empty);
				handler.AppendLiteral(" 增加");
				stringBuilder2.Append(ref handler);
				if (Enum.TryParse<AllEnums.数据库属性Type>(P_5.属性列表[j].属性.ToString(), out var result))
				{
					string text9 = "," + text7;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted((int)result);
					defaultInterpolatedStringHandler.AppendLiteral(":");
					if (text9.Contains(defaultInterpolatedStringHandler.ToStringAndClear(), StringComparison.CurrentCulture))
					{
						string text10 = text8;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
						defaultInterpolatedStringHandler.AppendFormatted((int)result);
						defaultInterpolatedStringHandler.AppendLiteral(":");
						defaultInterpolatedStringHandler.AppendFormatted(P_5.属性列表[j].数值);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						text8 = text10 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						string text11 = text7;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
						defaultInterpolatedStringHandler.AppendFormatted((int)result);
						defaultInterpolatedStringHandler.AppendLiteral(":");
						defaultInterpolatedStringHandler.AppendFormatted(P_5.属性列表[j].数值);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						text7 = text11 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
			}
			text4 = (string.IsNullOrWhiteSpace(text5) ? (string.IsNullOrWhiteSpace(text7) ? text4 : (text4 = text4 + "229:([" + text7 + "]),")) : (text4 = text4.Replace("229:([" + text5 + "]),", "229:([" + text7 + "]),")));
			text4 = (string.IsNullOrWhiteSpace(text6) ? (string.IsNullOrWhiteSpace(text8) ? text4 : (text4 = text4 + "231:([" + text8 + "]),")) : (text4 = text4.Replace("231:([" + text6 + "]),", "231:([" + text8 + "]),")));
			if (text4.IndexOf("\\\"open_nimbus\\\":1,") == -1)
			{
				text4 += "\\\"open_nimbus\\\":1,";
			}
			if (text4.IndexOf(",35:") == -1)
			{
				text4 += "35:10000,";
			}
			string text12 = ((text3.IndexOf(",55:\\\"") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, ",55:\\\"", "\\\",") : string.Empty);
			text4 = ((!string.IsNullOrWhiteSpace(text12)) ? text4.Replace(",55:\\\"" + text12 + "\\\",", ",55:\\\"金色\\\",") : (text4 + "55:\\\"金色\\\","));
			string text13 = (Singleton<ByteAPI>.I.寻找文本(text3, ",1:\\\"") ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, ",1:\\\"", "\\\",") : string.Empty);
			text = text.Replace(newValue: text2 + ((!string.IsNullOrWhiteSpace(text13)) ? text4.Replace(text13, stringBuilder.ToString() + ((!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.属性洗炼配置.时装配置.附加描述)) ? Singleton<全局变量类>.I.属性洗炼配置.时装配置.附加描述 : string.Empty)) : (text4 + "1:\\\"" + stringBuilder?.ToString() + ((!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.属性洗炼配置.时装配置.附加描述)) ? Singleton<全局变量类>.I.属性洗炼配置.时装配置.附加描述 : string.Empty) + "\\\",")) + "])\",", oldValue: text2 + text3 + "])\",");
			int dataChecksum = GetDataChecksum("user" + hexGid_ + "carry" + text);
			text = text.Replace("\\", "\\\\");
			全局变量类 i2 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：洗炼时装后】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i2.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where branch ='carry' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(hexGid_);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
			P_6?.Invoke(obj: true);
			锁定账号操作(P_1, "0");
		}
		catch (Exception ex)
		{
			Log.Error("洗炼属性更新时装错误：" + ex.Message + "(" + ex.StackTrace + ")");
			P_6?.Invoke(obj: false);
		}
	}

	
	internal void ThVNkUOkV1(int P_0, string P_1, string P_2, int P_3, string P_4, 洗炼属性缓存数据类 P_5, Action<bool> P_6 = null)
	{
		try
		{
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(P_0);
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("Mysql_洗炼属性更新法宝-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + hexGid_ + "' ORDER BY name DESC";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null || !mySqlDataReader.Read())
			{
				return;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：洗炼法宝前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear());
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted(P_3);
			defaultInterpolatedStringHandler.AppendLiteral(":\"");
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (!text.Contains(text2, StringComparison.CurrentCulture))
			{
				return;
			}
			string text3 = Singleton<ByteAPI>.I.文本_取出中间文本(text, text2, "])\",");
			if (string.IsNullOrWhiteSpace(text3))
			{
				return;
			}
			string text4 = text3;
			Singleton<ByteAPI>.I.文本_取出中间文本(text3, "233::", ":");
			string text5 = text4;
			if (text5[text5.Length - 1].ToString() != ",")
			{
				text4 += ",";
			}
			string text6 = ((text3.IndexOf("253:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, "253:([", "]),") : string.Empty);
			string text7 = string.Empty;
			string text8 = ((text3.IndexOf("254:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, "254:([", "]),") : string.Empty);
			string text9 = string.Empty;
			StringBuilder stringBuilder = new StringBuilder();
			for (int j = 0; j < P_5.属性列表.Count; j++)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 4, stringBuilder2);
				handler.AppendFormatted((j != 0) ? "#r" : string.Empty);
				handler.AppendLiteral("#B洗炼：");
				handler.AppendFormatted(P_5.属性列表[j].属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_5.属性列表[j].数值);
				handler.AppendFormatted(Singleton<AllEnums>.I.洗炼属性是否比例(P_5.属性列表[j].属性) ? "%" : string.Empty);
				handler.AppendLiteral(" 增加");
				stringBuilder2.Append(ref handler);
				if (Enum.TryParse<AllEnums.数据库属性Type>(P_5.属性列表[j].属性.ToString(), out var result))
				{
					string text10 = "," + text7;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted((int)result);
					defaultInterpolatedStringHandler.AppendLiteral(":");
					if (text10.IndexOf(defaultInterpolatedStringHandler.ToStringAndClear()) != -1)
					{
						string text11 = text9;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
						defaultInterpolatedStringHandler.AppendFormatted((int)result);
						defaultInterpolatedStringHandler.AppendLiteral(":");
						defaultInterpolatedStringHandler.AppendFormatted(P_5.属性列表[j].数值);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						text9 = text11 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						string text12 = text7;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
						defaultInterpolatedStringHandler.AppendFormatted((int)result);
						defaultInterpolatedStringHandler.AppendLiteral(":");
						defaultInterpolatedStringHandler.AppendFormatted(P_5.属性列表[j].数值);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						text7 = text12 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
			}
			if (text4.IndexOf("\\\"open_nimbus\\\":1,") == -1)
			{
				text4 += "\\\"open_nimbus\\\":1,";
			}
			if (text4.IndexOf(",35:") == -1)
			{
				text4 += "35:10000,";
			}
			text4 = (string.IsNullOrWhiteSpace(text6) ? (string.IsNullOrWhiteSpace(text7) ? text4 : (text4 = text4 + "253:([" + text7 + "]),")) : (text4 = text4.Replace("253:([" + text6 + "]),", "253:([" + text7 + "]),")));
			text4 = (string.IsNullOrWhiteSpace(text8) ? (string.IsNullOrWhiteSpace(text9) ? text4 : (text4 = text4 + "254:([" + text9 + "]),")) : (text4 = text4.Replace("254:([" + text8 + "]),", "254:([" + text9 + "]),")));
			if (Singleton<全局变量类>.I.属性洗炼配置.法宝配置.is附加描述)
			{
				string text13 = ((text3.IndexOf(",1:\\\"") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, ",1:\\\"", "\\\",") : string.Empty);
				text4 = ((!string.IsNullOrWhiteSpace(text13)) ? text4.Replace(text13, stringBuilder.ToString() + (Singleton<全局变量类>.I.属性洗炼配置.法宝配置.is附加描述 ? Singleton<全局变量类>.I.属性洗炼配置.法宝配置.附加描述 : string.Empty)) : (text4 + "1:\\\"" + stringBuilder?.ToString() + (Singleton<全局变量类>.I.属性洗炼配置.法宝配置.is附加描述 ? Singleton<全局变量类>.I.属性洗炼配置.法宝配置.附加描述 : string.Empty) + "\\\","));
			}
			text = text.Replace(text2 + text3 + "])\",", text2 + text4 + "])\",");
			int dataChecksum = GetDataChecksum("user" + hexGid_ + "carry" + text);
			text = text.Replace("\\", "\\\\");
			全局变量类 i2 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：洗炼法宝后】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i2.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where branch ='carry' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(hexGid_);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
			P_6?.Invoke(obj: true);
			锁定账号操作(P_1, "0");
		}
		catch (Exception ex)
		{
			Log.Error("洗炼属性更新法宝错误：" + ex.Message + "(" + ex.StackTrace + ")");
			P_6?.Invoke(obj: false);
		}
	}

	
	internal void EOON01Bhu7(int P_0, string P_1, string P_2, int P_3, string P_4, 洗炼属性缓存数据类 P_5, Action<bool> P_6 = null)
	{
		try
		{
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(P_0);
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("Mysql_洗炼属性更新梭子-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + hexGid_ + "' ORDER BY name DESC";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null || !mySqlDataReader.Read())
			{
				return;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：洗炼梭子前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear());
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted(P_3);
			defaultInterpolatedStringHandler.AppendLiteral(":\"");
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (!text.Contains(text2, StringComparison.CurrentCulture))
			{
				return;
			}
			string text3 = Singleton<ByteAPI>.I.文本_取出中间文本(text, text2, "])\",");
			if (string.IsNullOrWhiteSpace(text3))
			{
				return;
			}
			string text4 = text3;
			Singleton<ByteAPI>.I.文本_取出中间文本(text3, "233::", ":");
			string text5 = ((text3.IndexOf("229:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, "229:([", "]),") : string.Empty);
			string text6 = string.Empty;
			string text7 = ((text3.IndexOf("231:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, "231:([", "]),") : string.Empty);
			string text8 = string.Empty;
			new StringBuilder();
			StringBuilder stringBuilder = new StringBuilder();
			for (int j = 0; j < P_5.属性列表.Count; j++)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 4, stringBuilder2);
				handler.AppendFormatted((j != 0) ? "#r" : string.Empty);
				handler.AppendLiteral("#B洗炼：");
				handler.AppendFormatted(P_5.属性列表[j].属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_5.属性列表[j].数值);
				handler.AppendFormatted(Singleton<AllEnums>.I.洗炼属性是否比例(P_5.属性列表[j].属性) ? "%" : string.Empty);
				handler.AppendLiteral(" 增加");
				stringBuilder2.Append(ref handler);
				if (Enum.TryParse<AllEnums.数据库属性Type>(P_5.属性列表[j].属性.ToString(), out var result))
				{
					string text9 = "," + text6;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted((int)result);
					defaultInterpolatedStringHandler.AppendLiteral(":");
					if (text9.Contains(defaultInterpolatedStringHandler.ToStringAndClear(), StringComparison.CurrentCulture))
					{
						string text10 = text8;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
						defaultInterpolatedStringHandler.AppendFormatted((int)result);
						defaultInterpolatedStringHandler.AppendLiteral(":");
						defaultInterpolatedStringHandler.AppendFormatted(P_5.属性列表[j].数值);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						text8 = text10 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						string text11 = text6;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
						defaultInterpolatedStringHandler.AppendFormatted((int)result);
						defaultInterpolatedStringHandler.AppendLiteral(":");
						defaultInterpolatedStringHandler.AppendFormatted(P_5.属性列表[j].数值);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						text6 = text11 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
			}
			text4 = (string.IsNullOrWhiteSpace(text5) ? (string.IsNullOrWhiteSpace(text6) ? text4 : (text4 = text4 + "229:([" + text6 + "]),")) : (text4 = text4.Replace("229:([" + text5 + "]),", "229:([" + text6 + "]),")));
			text4 = (string.IsNullOrWhiteSpace(text7) ? (string.IsNullOrWhiteSpace(text8) ? text4 : (text4 = text4 + "231:([" + text8 + "]),")) : (text4 = text4.Replace("231:([" + text7 + "]),", "231:([" + text8 + "]),")));
			if (!text4.Contains("\\\"open_nimbus\\\":1,", StringComparison.CurrentCulture))
			{
				text4 += "\\\"open_nimbus\\\":1,";
			}
			if (!text4.Contains(",35:", StringComparison.CurrentCulture))
			{
				text4 += "35:10000,";
			}
			string text12 = ((text3.IndexOf(",55:\\\"") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, ",55:\\\"", "\\\",") : string.Empty);
			text4 = ((!string.IsNullOrWhiteSpace(text12)) ? text4.Replace(",55:\\\"" + text12 + "\\\",", ",55:\\\"金色\\\",") : (text4 + "55:\\\"金色\\\","));
			if (Singleton<全局变量类>.I.属性洗炼配置.梭子配置.is附加描述)
			{
				string text13 = ((text3.IndexOf(",1:\\\"") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, ",1:\\\"", "\\\",") : string.Empty);
				text4 = ((!string.IsNullOrWhiteSpace(text13)) ? text4.Replace(text13, stringBuilder.ToString() + (Singleton<全局变量类>.I.属性洗炼配置.梭子配置.is附加描述 ? Singleton<全局变量类>.I.属性洗炼配置.梭子配置.附加描述 : string.Empty)) : (text4 + "1:\\\"" + stringBuilder?.ToString() + (Singleton<全局变量类>.I.属性洗炼配置.梭子配置.is附加描述 ? Singleton<全局变量类>.I.属性洗炼配置.梭子配置.附加描述 : string.Empty) + "\\\","));
			}
			text = text.Replace(text2 + text3 + "])\",", text2 + text4 + "])\",");
			int dataChecksum = GetDataChecksum("user" + hexGid_ + "carry" + text);
			text = text.Replace("\\", "\\\\");
			全局变量类 i2 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：洗炼梭子后】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i2.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where branch ='carry' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(hexGid_);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
			P_6?.Invoke(obj: true);
			锁定账号操作(P_1, "0");
		}
		catch (Exception ex)
		{
			Log.Error("洗炼属性更新梭子错误：" + ex.Message + "(" + ex.StackTrace + ")");
			P_6?.Invoke(obj: false);
		}
	}

	
	internal void LuPNOoBm9M(int P_0, string P_1, string P_2, int P_3, string P_4, 洗炼属性缓存数据类 P_5, Action<bool> P_6 = null)
	{
		try
		{
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(P_0);
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("Mysql_洗炼属性更新铭牌-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + hexGid_ + "' ORDER BY name DESC";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null || !mySqlDataReader.Read())
			{
				return;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：洗炼铭牌前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear());
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted(P_3);
			defaultInterpolatedStringHandler.AppendLiteral(":\"");
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (!text.Contains(text2, StringComparison.CurrentCulture))
			{
				return;
			}
			string text3 = Singleton<ByteAPI>.I.文本_取出中间文本(text, text2, "])\",");
			if (string.IsNullOrWhiteSpace(text3))
			{
				return;
			}
			string text4 = text3;
			Singleton<ByteAPI>.I.文本_取出中间文本(text3, "233::", ":");
			string text5 = ((text3.IndexOf("229:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, "229:([", "]),") : string.Empty);
			string text6 = string.Empty;
			string text7 = ((text3.IndexOf("231:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, "231:([", "]),") : string.Empty);
			string text8 = string.Empty;
			new StringBuilder();
			StringBuilder stringBuilder = new StringBuilder();
			for (int j = 0; j < P_5.属性列表.Count; j++)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 4, stringBuilder2);
				handler.AppendFormatted((j != 0) ? "#r" : string.Empty);
				handler.AppendLiteral("#B洗炼：");
				handler.AppendFormatted(P_5.属性列表[j].属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_5.属性列表[j].数值);
				handler.AppendFormatted(Singleton<AllEnums>.I.洗炼属性是否比例(P_5.属性列表[j].属性) ? "%" : string.Empty);
				handler.AppendLiteral(" 增加");
				stringBuilder2.Append(ref handler);
				if (Enum.TryParse<AllEnums.数据库属性Type>(P_5.属性列表[j].属性.ToString(), out var result))
				{
					string text9 = "," + text6;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted((int)result);
					defaultInterpolatedStringHandler.AppendLiteral(":");
					if (text9.Contains(defaultInterpolatedStringHandler.ToStringAndClear(), StringComparison.CurrentCulture))
					{
						string text10 = text8;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
						defaultInterpolatedStringHandler.AppendFormatted((int)result);
						defaultInterpolatedStringHandler.AppendLiteral(":");
						defaultInterpolatedStringHandler.AppendFormatted(P_5.属性列表[j].数值);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						text8 = text10 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						string text11 = text6;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
						defaultInterpolatedStringHandler.AppendFormatted((int)result);
						defaultInterpolatedStringHandler.AppendLiteral(":");
						defaultInterpolatedStringHandler.AppendFormatted(P_5.属性列表[j].数值);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						text6 = text11 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
			}
			text4 = (string.IsNullOrWhiteSpace(text5) ? (string.IsNullOrWhiteSpace(text6) ? text4 : (text4 = text4 + "229:([" + text6 + "]),")) : (text4 = text4.Replace("229:([" + text5 + "]),", "229:([" + text6 + "]),")));
			text4 = (string.IsNullOrWhiteSpace(text7) ? (string.IsNullOrWhiteSpace(text8) ? text4 : (text4 = text4 + "231:([" + text8 + "]),")) : (text4 = text4.Replace("231:([" + text7 + "]),", "231:([" + text8 + "]),")));
			if (text4.IndexOf("\\\"open_nimbus\\\":1,") == -1)
			{
				text4 += "\\\"open_nimbus\\\":1,";
			}
			if (text4.IndexOf(",35:") == -1)
			{
				text4 += "35:10000,";
			}
			string text12 = ((text3.IndexOf(",55:\\\"") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, ",55:\\\"", "\\\",") : string.Empty);
			text4 = ((!string.IsNullOrWhiteSpace(text12)) ? text4.Replace(",55:\\\"" + text12 + "\\\",", ",55:\\\"金色\\\",") : (text4 + "55:\\\"金色\\\","));
			if (Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.is附加描述)
			{
				string text13 = ((text3.IndexOf(",1:\\\"") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, ",1:\\\"", "\\\",") : string.Empty);
				text4 = ((!string.IsNullOrWhiteSpace(text13)) ? text4.Replace(text13, stringBuilder.ToString() + (Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.is附加描述 ? Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.附加描述 : string.Empty)) : (text4 + "1:\\\"" + stringBuilder?.ToString() + (Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.is附加描述 ? Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.附加描述 : string.Empty) + "\\\","));
			}
			text = text.Replace(text2 + text3 + "])\",", text2 + text4 + "])\",");
			int dataChecksum = GetDataChecksum("user" + hexGid_ + "carry" + text);
			text = text.Replace("\\", "\\\\");
			全局变量类 i2 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：洗炼铭牌后】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i2.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where branch ='carry' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(hexGid_);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
			P_6?.Invoke(obj: true);
			锁定账号操作(P_1, "0");
		}
		catch (Exception ex)
		{
			Log.Error("洗炼属性更新铭牌错误：" + ex.Message + "(" + ex.StackTrace + ")");
			P_6?.Invoke(obj: false);
		}
	}

	
	internal void XS1NQib1hv(int P_0, string P_1, string P_2, int P_3, string P_4, 洗炼属性缓存数据类 P_5, Action<bool> P_6 = null)
	{
		try
		{
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(P_0);
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("Mysql_洗炼属性更新仙器-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + hexGid_ + "' ORDER BY name DESC";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null || !mySqlDataReader.Read())
			{
				return;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：仙器洗炼前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear());
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted(P_3);
			defaultInterpolatedStringHandler.AppendLiteral(":\"");
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (!text.Contains(text2, StringComparison.CurrentCulture))
			{
				return;
			}
			string text3 = Singleton<ByteAPI>.I.文本_取出中间文本(text, text2, "])\",");
			if (string.IsNullOrWhiteSpace(text3))
			{
				return;
			}
			string text4 = text3;
			Singleton<ByteAPI>.I.文本_取出中间文本(text3, "233::", ":");
			string text5 = ((text3.IndexOf("229:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, "229:([", "]),") : string.Empty);
			string text6 = string.Empty;
			string text7 = ((text3.IndexOf("231:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, "231:([", "]),") : string.Empty);
			string text8 = string.Empty;
			new StringBuilder();
			StringBuilder stringBuilder = new StringBuilder();
			for (int j = 0; j < P_5.属性列表.Count; j++)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 4, stringBuilder2);
				handler.AppendFormatted((j != 0) ? "#r" : string.Empty);
				handler.AppendLiteral("#B洗炼：");
				handler.AppendFormatted(P_5.属性列表[j].属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_5.属性列表[j].数值);
				handler.AppendFormatted(Singleton<AllEnums>.I.洗炼属性是否比例(P_5.属性列表[j].属性) ? "%" : string.Empty);
				handler.AppendLiteral(" 增加");
				stringBuilder2.Append(ref handler);
				if (Enum.TryParse<AllEnums.数据库属性Type>(P_5.属性列表[j].属性.ToString(), out var result))
				{
					string text9 = "," + text6;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted((int)result);
					defaultInterpolatedStringHandler.AppendLiteral(":");
					if (text9.Contains(defaultInterpolatedStringHandler.ToStringAndClear(), StringComparison.CurrentCulture))
					{
						string text10 = text8;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
						defaultInterpolatedStringHandler.AppendFormatted((int)result);
						defaultInterpolatedStringHandler.AppendLiteral(":");
						defaultInterpolatedStringHandler.AppendFormatted(P_5.属性列表[j].数值);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						text8 = text10 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						string text11 = text6;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
						defaultInterpolatedStringHandler.AppendFormatted((int)result);
						defaultInterpolatedStringHandler.AppendLiteral(":");
						defaultInterpolatedStringHandler.AppendFormatted(P_5.属性列表[j].数值);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						text6 = text11 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
			}
			text4 = (string.IsNullOrWhiteSpace(text5) ? (string.IsNullOrWhiteSpace(text6) ? text4 : (text4 = text4 + "229:([" + text6 + "]),")) : (text4 = text4.Replace("229:([" + text5 + "]),", "229:([" + text6 + "]),")));
			text4 = (string.IsNullOrWhiteSpace(text7) ? (string.IsNullOrWhiteSpace(text8) ? text4 : (text4 = text4 + "231:([" + text8 + "]),")) : (text4 = text4.Replace("231:([" + text7 + "]),", "231:([" + text8 + "]),")));
			if (!text4.Contains("\\\"open_nimbus\\\":1,", StringComparison.CurrentCulture))
			{
				text4 += "\\\"open_nimbus\\\":1,";
			}
			if (!text4.Contains(",35:", StringComparison.CurrentCulture))
			{
				text4 += "35:10000,";
			}
			string text12 = ((text3.IndexOf(",55:\\\"") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, ",55:\\\"", "\\\",") : string.Empty);
			text4 = ((!string.IsNullOrWhiteSpace(text12)) ? text4.Replace(",55:\\\"" + text12 + "\\\",", ",55:\\\"金色\\\",") : (text4 + "55:\\\"金色\\\","));
			string text13 = (Singleton<ByteAPI>.I.寻找文本(text3, ",1:\\\"") ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, ",1:\\\"", "\\\",") : string.Empty);
			text = text.Replace(newValue: text2 + ((!string.IsNullOrWhiteSpace(text13)) ? text4.Replace(text13, stringBuilder.ToString() + ((!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.属性洗炼配置.仙器配置.附加描述)) ? Singleton<全局变量类>.I.属性洗炼配置.仙器配置.附加描述 : string.Empty)) : (text4 + "1:\\\"" + stringBuilder?.ToString() + ((!string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.属性洗炼配置.仙器配置.附加描述)) ? Singleton<全局变量类>.I.属性洗炼配置.仙器配置.附加描述 : string.Empty) + "\\\",")) + "])\",", oldValue: text2 + text3 + "])\",");
			int dataChecksum = GetDataChecksum("user" + hexGid_ + "carry" + text);
			text = text.Replace("\\", "\\\\");
			全局变量类 i2 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：仙器洗炼后】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i2.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where branch ='carry' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(hexGid_);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
			P_6?.Invoke(obj: true);
			锁定账号操作(P_1, "0");
		}
		catch (Exception ex)
		{
			Log.Error("洗炼属性更新仙器错误：" + ex.Message + "(" + ex.StackTrace + ")");
			P_6?.Invoke(obj: false);
		}
	}

	
	internal void q4tNElyr7E(int P_0, string P_1, string P_2, int P_3, string P_4, 洗炼属性缓存数据类 P_5, Action<bool> P_6 = null)
	{
		try
		{
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(P_0);
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("Mysql_洗炼属性更新引灵幡-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + hexGid_ + "' ORDER BY name DESC";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null || !mySqlDataReader.Read())
			{
				return;
			}
			string text = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			mySqlDataReader.Close();
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：引灵幡洗炼前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear());
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted(P_3);
			defaultInterpolatedStringHandler.AppendLiteral(":\"");
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (!text.Contains(text2, StringComparison.CurrentCulture))
			{
				return;
			}
			string text3 = Singleton<ByteAPI>.I.文本_取出中间文本(text, text2, "])\",");
			if (string.IsNullOrWhiteSpace(text3))
			{
				return;
			}
			string text4 = text3;
			Singleton<ByteAPI>.I.文本_取出中间文本(text3, "233::", ":");
			string text5 = ((text3.IndexOf("229:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, "229:([", "]),") : string.Empty);
			string text6 = string.Empty;
			string text7 = ((text3.IndexOf("231:([") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, "231:([", "]),") : string.Empty);
			string text8 = string.Empty;
			StringBuilder stringBuilder = new StringBuilder();
			for (int j = 0; j < P_5.属性列表.Count; j++)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 4, stringBuilder2);
				handler.AppendFormatted((j != 0) ? "#r" : string.Empty);
				handler.AppendLiteral("#B洗炼：");
				handler.AppendFormatted(P_5.属性列表[j].属性);
				handler.AppendLiteral(" ");
				handler.AppendFormatted(P_5.属性列表[j].数值);
				handler.AppendFormatted(Singleton<AllEnums>.I.洗炼属性是否比例(P_5.属性列表[j].属性) ? "%" : string.Empty);
				handler.AppendLiteral(" 增加");
				stringBuilder2.Append(ref handler);
				if (Enum.TryParse<AllEnums.数据库属性Type>(P_5.属性列表[j].属性.ToString(), out var result))
				{
					string text9 = "," + text6;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted((int)result);
					defaultInterpolatedStringHandler.AppendLiteral(":");
					if (text9.Contains(defaultInterpolatedStringHandler.ToStringAndClear(), StringComparison.CurrentCulture))
					{
						string text10 = text8;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
						defaultInterpolatedStringHandler.AppendFormatted((int)result);
						defaultInterpolatedStringHandler.AppendLiteral(":");
						defaultInterpolatedStringHandler.AppendFormatted(P_5.属性列表[j].数值);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						text8 = text10 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						string text11 = text6;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
						defaultInterpolatedStringHandler.AppendFormatted((int)result);
						defaultInterpolatedStringHandler.AppendLiteral(":");
						defaultInterpolatedStringHandler.AppendFormatted(P_5.属性列表[j].数值);
						defaultInterpolatedStringHandler.AppendLiteral(",");
						text6 = text11 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
			}
			text4 = (string.IsNullOrWhiteSpace(text5) ? (string.IsNullOrWhiteSpace(text6) ? text4 : (text4 = text4 + "229:([" + text6 + "]),")) : (text4 = text4.Replace("229:([" + text5 + "]),", "229:([" + text6 + "]),")));
			text4 = (string.IsNullOrWhiteSpace(text7) ? (string.IsNullOrWhiteSpace(text8) ? text4 : (text4 = text4 + "231:([" + text8 + "]),")) : (text4 = text4.Replace("231:([" + text7 + "]),", "231:([" + text8 + "]),")));
			if (!text4.Contains("\\\"open_nimbus\\\":1,", StringComparison.CurrentCulture))
			{
				text4 += "\\\"open_nimbus\\\":1,";
			}
			if (!text4.Contains(",35:", StringComparison.CurrentCulture))
			{
				text4 += "35:10000,";
			}
			string text12 = ((text3.IndexOf(",55:\\\"") != -1) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, ",55:\\\"", "\\\",") : string.Empty);
			text4 = ((!string.IsNullOrWhiteSpace(text12)) ? text4.Replace(",55:\\\"" + text12 + "\\\",", ",55:\\\"金色\\\",") : (text4 + "55:\\\"金色\\\","));
			if (Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.is附加描述)
			{
				string text13 = (text3.Contains(",1:\\\"", StringComparison.CurrentCulture) ? Singleton<ByteAPI>.I.文本_取出中间文本(text3, ",1:\\\"", "\\\",") : string.Empty);
				text4 = ((!string.IsNullOrWhiteSpace(text13)) ? text4.Replace(text13, stringBuilder.ToString() + (Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.is附加描述 ? Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.附加描述 : string.Empty)) : (text4 + "1:\\\"" + stringBuilder?.ToString() + (Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.is附加描述 ? Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.附加描述 : string.Empty) + "\\\","));
			}
			text = text.Replace(text2 + text3 + "])\",", text2 + text4 + "])\",");
			int dataChecksum = GetDataChecksum("user" + hexGid_ + "carry" + text);
			text = text.Replace("\\", "\\\\");
			全局变量类 i2 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：引灵幡洗炼后】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i2.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where branch ='carry' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(hexGid_);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
			P_6?.Invoke(obj: true);
			锁定账号操作(P_1, "0");
		}
		catch (Exception ex)
		{
			Log.Error("洗炼属性更新引灵幡错误：" + ex.Message + "(" + ex.StackTrace + ")");
			P_6?.Invoke(obj: false);
		}
	}

	
	internal bool VEaN3PYcQZ()
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("初始化充值表-mysql数据库连接失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "SELECT 1 FROM information_schema.columns WHERE table_name = 'account' AND column_name = 'mu_cz' LIMIT 1";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader != null && mySqlDataReader.Read())
			{
				return true;
			}
			mySqlDataReader.Close();
			if (c1ZNsjqlRc(mySqlConnection, "alter table account add column mu_cz int(11) ZEROFILL not NULL after memo;") < 0)
			{
				Log.Error("充值数据表列插入失败，请重启插件！");
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("初始化充值表错误：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal bool OtMNYN4cvo()
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("更新化注册表-mysql数据库连接失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "SELECT COLUMN_NAME FROM information_schema.columns WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'yjzcxx' AND COLUMN_NAME = 'yzm'";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader != null && mySqlDataReader.Read())
			{
				return true;
			}
			mySqlDataReader.Close();
			if (c1ZNsjqlRc(mySqlConnection, "ALTER TABLE yjzcxx ADD COLUMN yzm varchar(32) CHARACTER SET latin1 NOT NULL DEFAULT '' AFTER aqpass;") < 0)
			{
				Log.Error("充值数据表列插入失败，请重启插件！");
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("初始化充值表错误：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal void vWiNp7QZQV()
	{
		try
		{
			bool flag = false;
			using MySqlConnection mySqlConnection = new MySqlConnection(allsql);
			mySqlConnection.Open();
			o51NJkPfKI(mySqlConnection);
			using (MySqlCommand mySqlCommand = new MySqlCommand())
			{
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = "show tables from " + Singleton<全局变量类>.I.config.adb表 + " LIKE 'yjcdk'";
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					flag = true;
				}
			}
			if (!flag && c1ZNsjqlRc(mySqlConnection, "create table " + Singleton<全局变量类>.I.config.adb表 + ".yjcdk(cdk varchar(36) not null,cdktype int not null,info varchar(36) not null,count smallint not null,sytime varchar(36),syname varchar(36),primary key(cdk));") < 0)
			{
				Log.Error("CDK数据表列插入失败，请重启插件！");
			}
		}
		catch (Exception ex)
		{
			Log.Error("初始化CDK表错误：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task lrCN10MduL(int P_0, string P_1, int P_2, int P_3, Action<int, string> P_4)
	{
		try
		{
			using MySqlConnection conn = new MySqlConnection(adbsql1);
			conn.Open();
			if (conn.State != ConnectionState.Open)
			{
				Log.Error("生成CDK处理-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(conn);
			StringBuilder 回显文本 = new StringBuilder();
			_ = string.Empty;
			for (int i = 0; i < P_3; i++)
			{
				lock (s25ijnJt0L)
				{
					string text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (P_0 != 4)
					{
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
						defaultInterpolatedStringHandler.AppendLiteral("A*");
						defaultInterpolatedStringHandler.AppendFormatted(Guid.NewGuid(), "N");
						defaultInterpolatedStringHandler.AppendLiteral("*Z");
						text = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						text = Get注册码6位();
					}
					string value = text;
					DB dB = this;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(67, 4);
					defaultInterpolatedStringHandler.AppendLiteral("insert into yjcdk(cdk, cdktype, info,count) values('");
					defaultInterpolatedStringHandler.AppendFormatted(value);
					defaultInterpolatedStringHandler.AppendLiteral("', '");
					defaultInterpolatedStringHandler.AppendFormatted(P_0);
					defaultInterpolatedStringHandler.AppendLiteral("', '");
					defaultInterpolatedStringHandler.AppendFormatted(P_1);
					defaultInterpolatedStringHandler.AppendLiteral("', '");
					defaultInterpolatedStringHandler.AppendFormatted(P_2);
					defaultInterpolatedStringHandler.AppendLiteral("');");
					if (dB.c1ZNsjqlRc(conn, defaultInterpolatedStringHandler.ToStringAndClear()) > 0)
					{
						StringBuilder stringBuilder = 回显文本;
						StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(5, 3, stringBuilder);
						handler.AppendFormatted(value);
						handler.AppendLiteral("---");
						handler.AppendFormatted((!string.IsNullOrWhiteSpace(P_1)) ? (P_1 + "*") : string.Empty);
						handler.AppendFormatted(P_2);
						handler.AppendLiteral("\r\n");
						stringBuilder.Append(ref handler);
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
						defaultInterpolatedStringHandler.AppendFormatted(value);
						defaultInterpolatedStringHandler.AppendLiteral("---");
						defaultInterpolatedStringHandler.AppendFormatted((!string.IsNullOrWhiteSpace(P_1)) ? (P_1 + "*") : string.Empty);
						defaultInterpolatedStringHandler.AppendFormatted(P_2);
						defaultInterpolatedStringHandler.AppendLiteral("\r\n");
						string arg = defaultInterpolatedStringHandler.ToStringAndClear();
						P_4(P_0, arg);
					}
				}
				await Task.Delay(50);
			}
		}
		catch (Exception ex)
		{
			Log.Error("生成CDK处理报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public string Get注册码6位()
	{
		List<char> source = (from i in Enumerable.Range(65, 26)
			select (char)i).ToList();
		string empty = string.Empty;
		bool flag = true;
		do
		{
			_003C_003Ec__DisplayClass67_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass67_0();
			CS_0024_003C_003E8__locals2.pdN7OMg4tx = new Random();
			empty = new string(source.OrderBy( (char x) => CS_0024_003C_003E8__locals2.pdN7OMg4tx.Next()).Take(6).ToArray());
			flag = JLeNxXwjvp(empty);
		}
		while (flag && flag);
		return empty;
	}

	
	internal bool JLeNxXwjvp(string P_0)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("查询所有CDK数据-mysql数据库连接失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select cdk from yjcdk where cdk='" + P_0 + "'";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			return mySqlDataReader.Read();
		}
		catch (Exception ex)
		{
			Log.Error("查询卡密是否重复-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal DataTable nfUNHWxQg5(DataTable P_0, string P_1, int P_2, string P_3, string P_4)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (!string.IsNullOrWhiteSpace(P_1))
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder2);
				handler.AppendLiteral("where cdk='");
				handler.AppendFormatted(P_1);
				handler.AppendLiteral("'");
				stringBuilder3.Append(ref handler);
			}
			if (P_2 != 0)
			{
				if (!string.IsNullOrWhiteSpace(stringBuilder.ToString()))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
					handler.AppendLiteral(" and cdktype=");
					handler.AppendFormatted(P_2);
					stringBuilder4.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder2);
					handler.AppendLiteral("where cdktype=");
					handler.AppendFormatted(P_2);
					stringBuilder5.Append(ref handler);
				}
			}
			if (!string.IsNullOrWhiteSpace(P_3))
			{
				if (!string.IsNullOrWhiteSpace(stringBuilder.ToString()))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder2);
					handler.AppendLiteral(" and info=");
					handler.AppendFormatted(P_3);
					stringBuilder6.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
					handler.AppendLiteral("where info=");
					handler.AppendFormatted(P_3);
					stringBuilder7.Append(ref handler);
				}
			}
			if (!string.IsNullOrWhiteSpace(P_4))
			{
				if (!string.IsNullOrWhiteSpace(stringBuilder.ToString()))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder2);
					handler.AppendLiteral(" and syname=");
					handler.AppendFormatted(P_4);
					stringBuilder8.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder9 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
					handler.AppendLiteral("where syname=");
					handler.AppendFormatted(P_4);
					stringBuilder9.Append(ref handler);
				}
			}
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("查询所有CDK数据-mysql数据库连接失败！");
				return P_0;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("select * from yjcdk ");
			defaultInterpolatedStringHandler.AppendFormatted(stringBuilder);
			mySqlCommand.CommandText = defaultInterpolatedStringHandler.ToStringAndClear();
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader != null)
			{
				while (mySqlDataReader.Read())
				{
					P_0.Rows.Add(null, mySqlDataReader["cdk"].ToString(), mySqlDataReader["cdktype"].ToString(), ujjNRZ9vuH(mySqlDataReader["info"].ToString()), mySqlDataReader["count"].ToString(), mySqlDataReader["sytime"].ToString(), ujjNRZ9vuH(mySqlDataReader["syname"].ToString()));
				}
			}
			mySqlDataReader.Close();
			return P_0;
		}
		catch (Exception ex)
		{
			Log.Error("查询所有CDK数据报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return P_0;
		}
	}

	
	internal async void wf9N4MHQvU(string P_0, int P_1, string P_2, string P_3, Action<CDK信息类, bool> P_4)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (!string.IsNullOrWhiteSpace(P_0))
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder2);
				handler.AppendLiteral("where cdk='");
				handler.AppendFormatted(P_0);
				handler.AppendLiteral("'");
				stringBuilder3.Append(ref handler);
			}
			if (P_1 != 0)
			{
				if (!string.IsNullOrWhiteSpace(stringBuilder.ToString()))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder4 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
					handler.AppendLiteral(" and cdktype=");
					handler.AppendFormatted(P_1);
					stringBuilder4.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder5 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder2);
					handler.AppendLiteral("where cdktype=");
					handler.AppendFormatted(P_1);
					stringBuilder5.Append(ref handler);
				}
			}
			if (!string.IsNullOrWhiteSpace(P_2))
			{
				if (!string.IsNullOrWhiteSpace(stringBuilder.ToString()))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder6 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder2);
					handler.AppendLiteral(" and info=");
					handler.AppendFormatted(P_2);
					stringBuilder6.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder7 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
					handler.AppendLiteral("where info=");
					handler.AppendFormatted(P_2);
					stringBuilder7.Append(ref handler);
				}
			}
			if (!string.IsNullOrWhiteSpace(P_3))
			{
				if (!string.IsNullOrWhiteSpace(stringBuilder.ToString()))
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder8 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder2);
					handler.AppendLiteral(" and syname=");
					handler.AppendFormatted(P_3);
					stringBuilder8.Append(ref handler);
				}
				else
				{
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder9 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
					handler.AppendLiteral("where syname=");
					handler.AppendFormatted(P_3);
					stringBuilder9.Append(ref handler);
				}
			}
			List<CDK信息类> cdk列表 = new List<CDK信息类>();
			using MySqlConnection conn = new MySqlConnection(adbsql1);
			conn.Open();
			if (conn.State != ConnectionState.Open)
			{
				Log.Error("查询所有CDK数据-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(conn);
			using MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conn;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("select * from yjcdk ");
			defaultInterpolatedStringHandler.AppendFormatted(stringBuilder);
			cmd.CommandText = defaultInterpolatedStringHandler.ToStringAndClear();
			using MySqlDataReader 查询结果 = cmd.ExecuteReader();
			if (查询结果 != null)
			{
				while (查询结果.Read())
				{
					CDK信息类 cDK信息类 = new CDK信息类();
					cDK信息类.卡密 = ujjNRZ9vuH(查询结果["cdk"].ToString());
					if (int.TryParse(查询结果["cdktype"].ToString(), out var result))
					{
						cDK信息类.CDK类型 = (AllEnums.CdkType)result;
					}
					cDK信息类.CDK道具名字 = ujjNRZ9vuH(查询结果["info"].ToString());
					if (int.TryParse(查询结果["count"].ToString(), out var result2))
					{
						cDK信息类.CDK数量 = result2;
					}
					cDK信息类.CDK使用时间 = 查询结果["sytime"].ToString();
					cDK信息类.CDK使用角色 = ujjNRZ9vuH(查询结果["syname"].ToString());
					cdk列表.Add(cDK信息类);
				}
			}
			查询结果.Close();
			if (cdk列表.Count <= 0)
			{
				P_4?.Invoke(new CDK信息类(), arg2: false);
				return;
			}
			for (int i = 0; i < cdk列表.Count; i++)
			{
				P_4?.Invoke(cdk列表[i], arg2: true);
				await Task.Delay(10);
			}
		}
		catch (Exception ex)
		{
			Log.Error("查询所有CDK数据报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void K6CNeCnGhr(string P_0)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("删除指定CDK数据-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			if (!string.IsNullOrWhiteSpace(P_0))
			{
				c1ZNsjqlRc(mySqlConnection, "DELETE  FROM  yjcdk WHERE cdk='" + P_0 + "';");
			}
			else
			{
				c1ZNsjqlRc(mySqlConnection, "TRUNCATE TABLE yjcdk");
			}
		}
		catch (Exception ex)
		{
			Log.Error("删除指定CDK报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void wmMNqYIGuE(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			int num = 0;
			string empty = string.Empty;
			int num2 = 0;
			_ = string.Empty;
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("道具CDK兑换处理-mysql数据库连接失败！");
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("数据库连接失败！"));
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select * from yjcdk where cdk='" + P_1 + "'";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#R兑换失败！卡密：" + P_1 + "，不存在！"));
				return;
			}
			if (!mySqlDataReader.Read())
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#R兑换失败！卡密：" + P_1 + "，不存在或已被使用！"));
				return;
			}
			num = int.Parse(mySqlDataReader["cdktype"].ToString());
			empty = ujjNRZ9vuH(mySqlDataReader["info"].ToString());
			num2 = int.Parse(mySqlDataReader["count"].ToString());
			string value = ujjNRZ9vuH(mySqlDataReader["syname"].ToString());
			mySqlDataReader.Close();
			if (!string.IsNullOrWhiteSpace(value))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#R兑换失败！卡密：" + P_1 + "，已被使用！"));
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update yjcdk set syname='");
			defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
			defaultInterpolatedStringHandler.AppendLiteral("',sytime='");
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("' where cdk='");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			if (c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear()) != 1)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#R兑换失败！卡密：" + P_1 + "，兑换异常！"));
				return;
			}
			switch (num)
			{
			case 1:
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, empty, AllEnums.指令Type.无, num2, false, "CDK道具兑换"))
				{
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
					defaultInterpolatedStringHandler.AppendLiteral("#G兑换成功！奖励：");
					defaultInterpolatedStringHandler.AppendFormatted(empty);
					defaultInterpolatedStringHandler.AppendLiteral("*");
					defaultInterpolatedStringHandler.AppendFormatted(num2);
					defaultInterpolatedStringHandler.AppendLiteral("。");
					P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				break;
			case 2:
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 2);
				defaultInterpolatedStringHandler.AppendLiteral("update account set mu_cz=mu_cz+");
				defaultInterpolatedStringHandler.AppendFormatted(num2);
				defaultInterpolatedStringHandler.AppendLiteral("  where account='");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.账号);
				defaultInterpolatedStringHandler.AppendLiteral("'");
				if (c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear()) != 1)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("#R兑换失败！卡密：" + P_1 + "，兑换异常！"));
					break;
				}
				if (全局变量类.点卡使用中)
				{
					P_0.user.存档数据.点卡存档.当前点数 += num2;
					WdAPI i3 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
					defaultInterpolatedStringHandler.AppendLiteral("恭喜你，成功充值了#R");
					defaultInterpolatedStringHandler.AppendFormatted(num2);
					defaultInterpolatedStringHandler.AppendLiteral("#n点点卡点数，当前剩余点数为#R");
					defaultInterpolatedStringHandler.AppendFormatted(P_0.user.存档数据.点卡存档.当前点数);
					defaultInterpolatedStringHandler.AppendLiteral("#n。");
					P_0.C_Send(i3.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				if (Singleton<全局变量类>.I.config.点卡充值类型 == AllEnums.数值Type.金元宝)
				{
					if (cAJNoOkab6(P_0, num2 * Singleton<全局变量类>.I.config.点卡充值比例, 0))
					{
						if (num2 >= Singleton<全局变量类>.I.config.点卡充值南极金额)
						{
							Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, num2 / Singleton<全局变量类>.I.config.点卡充值南极金额, false, "[CDK兑换]获得");
							P_0.C_Send(Singleton<WdAPI>.I.组包邮件南极次数(P_0));
						}
						P_0.user.存档数据.总累充金额数 += num2;
						Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, num2, false, "[CDK兑换]获得");
						WdAPI i4 = Singleton<WdAPI>.I;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
						defaultInterpolatedStringHandler.AppendLiteral("恭喜你：成功充值了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral("#n元的点卡，到账了#Y");
						defaultInterpolatedStringHandler.AppendFormatted(num2 * Singleton<全局变量类>.I.config.点卡充值比例);
						defaultInterpolatedStringHandler.AppendLiteral("#n");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.点卡充值类型);
						P_0.C_Send(i4.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					}
				}
				else if (Singleton<全局变量类>.I.config.点卡充值类型 == AllEnums.数值Type.银元宝 && cAJNoOkab6(P_0, 0, num2 * Singleton<全局变量类>.I.config.点卡充值比例))
				{
					if (num2 >= Singleton<全局变量类>.I.config.点卡充值南极金额)
					{
						Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, num2 / Singleton<全局变量类>.I.config.点卡充值南极金额, false, "[CDK兑换]获得");
						P_0.C_Send(Singleton<WdAPI>.I.组包邮件南极次数(P_0));
					}
					P_0.user.存档数据.总累充金额数 += num2;
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, num2, false, "[CDK兑换]获得");
					WdAPI i5 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
					defaultInterpolatedStringHandler.AppendLiteral("恭喜你：成功充值了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num2);
					defaultInterpolatedStringHandler.AppendLiteral("#n元的点卡，到账了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(num2 * Singleton<全局变量类>.I.config.点卡充值比例);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.点卡充值类型);
					P_0.C_Send(i5.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				}
				if (!P_0.user.存档数据.is每日首冲领取 && Singleton<全局变量类>.I.config.is日首冲赠送 && num2 >= Singleton<全局变量类>.I.config.日首冲金额 && Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.config.日首冲赠送, AllEnums.指令Type.无, 1, false, "每日首冲"))
				{
					P_0.user.存档数据.is每日首冲领取 = true;
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("恭喜你获得了今日首冲奖励的#Y" + Singleton<全局变量类>.I.config.日首冲赠送 + "#n。"));
				}
				Singleton<EfHAVFUgqrnaj1QwnLW>.I.ktVUfSuD8y(P_0, num2);
				break;
			case 17:
			{
				int num3 = num2 * Singleton<全局变量类>.I.config.奇宝充值比例;
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, num3, false, "[CDK兑换]获得");
				if (!Singleton<全局变量类>.I.config.CDK不加南极点开关 && num2 >= Singleton<全局变量类>.I.config.点卡充值南极金额)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, num2 / Singleton<全局变量类>.I.config.点卡充值南极金额, false, "[CDK兑换]获得");
					P_0.C_Send(Singleton<WdAPI>.I.组包邮件南极次数(P_0));
				}
				if (!Singleton<全局变量类>.I.config.CDK不加累充点开关)
				{
					P_0.user.存档数据.总累充金额数 += num2;
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, num2, false, "[CDK兑换]获得");
				}
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你：成功充值了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(num3);
				defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点。");
				P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				break;
			}
			}
		}
		catch (Exception ex)
		{
			Log.Error("CDK统一兑换处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task rZCNrYJFT4(MyNATSocketClient P_0)
	{
		try
		{
			await Task.Delay(0);
			if (P_0.user.缓存数据.is使用仙灵卡)
			{
				return;
			}
			bool flag = false;
			if (P_0.user.缓存数据.支付数据.购买物品类型 == AllEnums.数值Type.金元宝 && Singleton<全局变量类>.I.config.点卡充值类型 == AllEnums.数值Type.金元宝)
			{
				flag = cAJNoOkab6(P_0, P_0.user.缓存数据.支付数据.购买物品总价 * Singleton<全局变量类>.I.config.点卡充值比例, 0);
			}
			else if (P_0.user.缓存数据.支付数据.购买物品类型 == AllEnums.数值Type.银元宝 && Singleton<全局变量类>.I.config.点卡充值类型 == AllEnums.数值Type.银元宝)
			{
				flag = cAJNoOkab6(P_0, 0, P_0.user.缓存数据.支付数据.购买物品总价 * Singleton<全局变量类>.I.config.点卡充值比例);
			}
			if (flag)
			{
				if (P_0.user.缓存数据.支付数据.购买物品总价 >= Singleton<全局变量类>.I.config.点卡充值南极金额)
				{
					Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.南极点, string.Empty, AllEnums.指令Type.无, P_0.user.缓存数据.支付数据.购买物品总价 / Singleton<全局变量类>.I.config.点卡充值南极金额, false, "[扫码支付]获得");
					P_0.C_Send(Singleton<WdAPI>.I.组包邮件南极次数(P_0));
				}
				P_0.user.存档数据.总累充金额数 += P_0.user.缓存数据.支付数据.购买物品总价;
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.累充点, string.Empty, AllEnums.指令Type.无, P_0.user.缓存数据.支付数据.购买物品总价, false, "[扫码支付]获得");
				WdAPI i = Singleton<WdAPI>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 2);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你：成功充值了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.缓存数据.支付数据.购买物品总价);
				defaultInterpolatedStringHandler.AppendLiteral("#n元的点卡，累充点增加#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.缓存数据.支付数据.购买物品总价 * Singleton<全局变量类>.I.config.点卡充值比例);
				defaultInterpolatedStringHandler.AppendLiteral("#n点，可打开累充界面查看。");
				P_0.C_Send(i.jyLIAFgHTA(P_0, defaultInterpolatedStringHandler.ToStringAndClear()));
				WdAPI i2 = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你：成功充值了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.缓存数据.支付数据.购买物品总价);
				defaultInterpolatedStringHandler.AppendLiteral("#n元的点卡，到账了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.缓存数据.支付数据.购买物品总价 * Singleton<全局变量类>.I.config.点卡充值比例);
				defaultInterpolatedStringHandler.AppendLiteral("#n");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.点卡充值类型);
				P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				if (!P_0.user.存档数据.is每日首冲领取 && Singleton<全局变量类>.I.config.is日首冲赠送 && P_0.user.缓存数据.支付数据.购买物品总价 >= Singleton<全局变量类>.I.config.日首冲金额 && Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, Singleton<全局变量类>.I.config.日首冲赠送, AllEnums.指令Type.无, 1, false, "每日首冲"))
				{
					P_0.user.存档数据.is每日首冲领取 = true;
					P_0.C_Send(Singleton<WdAPI>.I.提示_提醒和杂项公告("恭喜你获得了今日首冲奖励的#Y" + Singleton<全局变量类>.I.config.日首冲赠送 + "#n。"));
				}
				Singleton<EfHAVFUgqrnaj1QwnLW>.I.ktVUfSuD8y(P_0, P_0.user.缓存数据.支付数据.购买物品总价);
			}
		}
		catch (Exception ex)
		{
			Log.Error("支付统一兑换处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task IPJNZeRxy9(MyNATSocketClient P_0, string P_1, Action<bool, string> P_2 = null)
	{
		try
		{
			if (P_1.Length != 32)
			{
				P_2?.Invoke(arg1: false, "卡密长度不符！");
				return;
			}
			if (!P_1.验证是否只有英文和数字())
			{
				P_2?.Invoke(arg1: false, "卡密内容不符！");
				return;
			}
			if (Singleton<ByteAPI>.I.寻找文本或(P_1, ",", "/", "\\", "'", "‘", "or", "is", "_", "-", "@", "where", "update", "del"))
			{
				P_2?.Invoke(arg1: false, "卡密内容不符");
				return;
			}
			P_1 = "A*" + P_1 + "*Z";
			int num = 0;
			string text = string.Empty;
			int num2 = 0;
			string value = string.Empty;
			using MySqlConnection conn = new MySqlConnection(adbsql1);
			conn.Open();
			if (conn.State != ConnectionState.Open)
			{
				P_2?.Invoke(arg1: false, "数据库连接失败！");
				Log.Error("道具CDK兑换处理-mysql数据库连接失败！");
				return;
			}
			await Task.Delay(500);
			o51NJkPfKI(conn);
			using (MySqlCommand mySqlCommand = new MySqlCommand("select * from yjcdk where cdk=@cdk", conn))
			{
				mySqlCommand.Parameters.AddWithValue("@cdk", P_1);
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null)
				{
					P_2?.Invoke(arg1: false, "CDK不存在！");
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("CDK不存在！"));
					return;
				}
				if (!mySqlDataReader.Read())
				{
					P_2?.Invoke(arg1: false, "CDK不存在或已被使用！");
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("CDK不存在或已被使用！"));
					return;
				}
				num = int.Parse(mySqlDataReader["cdktype"].ToString());
				text = ujjNRZ9vuH(mySqlDataReader["info"].ToString());
				num2 = int.Parse(mySqlDataReader["count"].ToString());
				value = ujjNRZ9vuH(mySqlDataReader["syname"].ToString());
			}
			if (!string.IsNullOrWhiteSpace(value))
			{
				P_2?.Invoke(arg1: false, "CDK已被使用！");
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("CDK已被使用！"));
				return;
			}
			switch (num)
			{
			case 1:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 2);
				defaultInterpolatedStringHandler.AppendLiteral("update yjcdk set syname='");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("',sytime='");
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
				defaultInterpolatedStringHandler.AppendLiteral("' where cdk=@cdk");
				using (MySqlCommand mySqlCommand3 = new MySqlCommand(defaultInterpolatedStringHandler.ToStringAndClear(), conn))
				{
					mySqlCommand3.Parameters.AddWithValue("@cdk", P_1);
					if (mySqlCommand3.ExecuteNonQuery() != 1)
					{
						P_2?.Invoke(arg1: false, "CDK兑换失败！");
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("CDK兑换失败！"));
						return;
					}
				}
				if (Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.道具, text, AllEnums.指令Type.无, num2, false, "CDK道具兑换"))
				{
					P_2?.Invoke(arg1: true, "兑换成功！");
					WdAPI i2 = Singleton<WdAPI>.I;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
					defaultInterpolatedStringHandler.AppendLiteral("恭喜你：成功兑换了#Y");
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral("*");
					defaultInterpolatedStringHandler.AppendFormatted(num2);
					defaultInterpolatedStringHandler.AppendLiteral("#n");
					P_0.C_Send(i2.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
					return;
				}
				break;
			}
			case 2:
			{
				if (!全局变量类.点卡使用中)
				{
					break;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 2);
				defaultInterpolatedStringHandler.AppendLiteral("update yjcdk set syname='");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("',sytime='");
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
				defaultInterpolatedStringHandler.AppendLiteral("' where cdk=@cdk");
				using (MySqlCommand mySqlCommand2 = new MySqlCommand(defaultInterpolatedStringHandler.ToStringAndClear(), conn))
				{
					mySqlCommand2.Parameters.AddWithValue("@cdk", P_1);
					if (mySqlCommand2.ExecuteNonQuery() != 1)
					{
						P_2?.Invoke(arg1: false, "CDK兑换失败！");
						P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("CDK兑换失败！"));
						return;
					}
				}
				P_0.user.存档数据.点卡存档.当前点数 += num2;
				P_2?.Invoke(arg1: true, "兑换成功！");
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你：成功兑换了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(num2);
				defaultInterpolatedStringHandler.AppendLiteral("#n点点卡点数。");
				P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			}
			P_2?.Invoke(arg1: false, "卡密有误，非道具CDK卡密，无法兑换！");
			P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R卡密有误，非道具CDK卡密，无法兑换！"));
		}
		catch (Exception ex)
		{
			P_2?.Invoke(arg1: false, ex.Message);
			Log.Error("道具兑换处理报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void uSXNt3pcrB(MyNATSocketClient P_0, string P_1)
	{
		try
		{
			int num = 0;
			int num2 = 0;
			_ = string.Empty;
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("奇宝点CDK兑换处理-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select * from yjcdk where cdk='" + P_1 + "'";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null)
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("CDK不存在！"));
				return;
			}
			if (!mySqlDataReader.Read())
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("CDK不存在或已被使用！"));
				return;
			}
			num = int.Parse(mySqlDataReader["cdktype"].ToString());
			num2 = int.Parse(mySqlDataReader["count"].ToString());
			string value = ujjNRZ9vuH(mySqlDataReader["syname"].ToString());
			mySqlDataReader.Close();
			if (!string.IsNullOrWhiteSpace(value))
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("CDK已被使用！"));
			}
			else if (num == 17)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 3);
				defaultInterpolatedStringHandler.AppendLiteral("update yjcdk set syname='");
				defaultInterpolatedStringHandler.AppendFormatted(P_0.user.人物数据.昵称);
				defaultInterpolatedStringHandler.AppendLiteral("',sytime='");
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
				defaultInterpolatedStringHandler.AppendLiteral("' where cdk='");
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral("'");
				if (c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear()) != 1)
				{
					P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("CDK兑换失败！"));
					return;
				}
				Singleton<WdAPI>.I.PndoGw5lW7(P_0, AllEnums.发送数据Type.奇宝点, string.Empty, AllEnums.指令Type.无, num2, false, "[CDK兑换]获得");
				WdAPI i = Singleton<WdAPI>.I;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
				defaultInterpolatedStringHandler.AppendLiteral("恭喜你：成功充值了#Y");
				defaultInterpolatedStringHandler.AppendFormatted(num2);
				defaultInterpolatedStringHandler.AppendLiteral("#n奇宝点。");
				P_0.C_Send(i.提示_提醒和杂项公告(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else
			{
				P_0.C_Send(Singleton<WdAPI>.I.提示_中心提醒("#R卡密有误，非奇宝点CDK卡密，无法兑换！"));
			}
		}
		catch (Exception ex)
		{
			Log.Error("奇宝点兑换处理报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal bool OfvNAsuSuZ()
	{
		try
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			using MySqlConnection mySqlConnection = new MySqlConnection(allsql);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("查询角色宠物存档json-mysql数据库连接失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "show tables from " + Singleton<全局变量类>.I.config.adb表;
			using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
			{
				if (mySqlDataReader != null)
				{
					while (mySqlDataReader.Read())
					{
						if (mySqlDataReader.GetString(0) == "yjuser")
						{
							flag = true;
						}
						else if (mySqlDataReader.GetString(0) == "yjpet")
						{
							flag2 = true;
						}
						else if (mySqlDataReader.GetString(0) == "yjzcxx")
						{
							flag3 = true;
						}
						if (flag && flag2 && flag3)
						{
							break;
						}
					}
				}
			}
			zZwNzPUOhm(flag);
			wQ0iu8C57G(flag2);
			if (flag3)
			{
				OtMNYN4cvo();
				vZGiRD2ejr();
			}
			else if (c1ZNsjqlRc(mySqlConnection, "create table " + Singleton<全局变量类>.I.config.adb表 + ".yjzcxx(account varchar(32) not null,pass varchar(32) not null,aqpass varchar(32) not null,yzm varchar(32) not null,zcname varchar(32) not null,zclv int(32) not null,zcip varchar(36) not null,zcmac varchar(32) not null,zcqq text null,zctime varchar(32) not null, primary key(account));") < 0)
			{
				Log.Error("网关注册信息表列插入失败，请重启插件！");
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			Log.Error("初始化角色宠物存档表错误：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal void zZwNzPUOhm(bool P_0)
	{
		try
		{
			Singleton<全局变量类>.I.角色存档表.Clear();
			if (P_0)
			{
				using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
				mySqlConnection.Open();
				if (mySqlConnection.State != ConnectionState.Open)
				{
					Log.Error("初始化玩家存档json-mysql数据库连接失败！");
					return;
				}
				o51NJkPfKI(mySqlConnection);
				using MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = "select * from yjuser";
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					int key = int.Parse(mySqlDataReader["gid"].ToString());
					string value = ujjNRZ9vuH(mySqlDataReader["info"].ToString());
					try
					{
						角色存档数据类 value2 = JsonConvert.DeserializeObject<角色存档数据类>(value);
						Singleton<全局变量类>.I.角色存档表.TryAdd(key, value2);
					}
					catch (Exception ex)
					{
						Log.Error("玩家存档读取报错：[" + key + "]" + ex.Message + "(" + ex.StackTrace + ")");
					}
				}
			}
			string[] files = Directory.GetFiles(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("/角色存档夹"), "*.json");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			foreach (string text in files)
			{
				try
				{
					角色存档数据类 角色存档数据类2 = JsonConvert.DeserializeObject<角色存档数据类>(File.ReadAllText(text));
					if (Singleton<全局变量类>.I.角色存档表.ContainsKey(角色存档数据类2.GID))
					{
						Singleton<全局变量类>.I.角色存档表[角色存档数据类2.GID] = 角色存档数据类2;
					}
					else
					{
						Singleton<全局变量类>.I.角色存档表.TryAdd(角色存档数据类2.GID, 角色存档数据类2);
					}
				}
				catch (Exception ex2)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 3);
					defaultInterpolatedStringHandler.AppendLiteral("玩家存档读取报错：路径=【");
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral("】 错误=【");
					defaultInterpolatedStringHandler.AppendFormatted(ex2.Message);
					defaultInterpolatedStringHandler.AppendLiteral("】(");
					defaultInterpolatedStringHandler.AppendFormatted(ex2.StackTrace);
					defaultInterpolatedStringHandler.AppendLiteral(")");
					Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("玩家存档读取完成：");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.角色存档表.Count);
			defaultInterpolatedStringHandler.AppendLiteral("人");
			Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		catch (Exception ex3)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendLiteral("初始化玩家存档数据错误：");
			defaultInterpolatedStringHandler.AppendFormatted(ex3.Message);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted(ex3.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	
	internal void wQ0iu8C57G(bool P_0)
	{
		try
		{
			Singleton<全局变量类>.I.宠物存档表.Clear();
			if (P_0)
			{
				using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
				mySqlConnection.Open();
				if (mySqlConnection.State != ConnectionState.Open)
				{
					Log.Error("初始化玩家存档json-mysql数据库连接失败！");
					return;
				}
				o51NJkPfKI(mySqlConnection);
				using MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = "select * from yjpet";
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					string text = mySqlDataReader["iid"].ToString();
					string value = ujjNRZ9vuH(mySqlDataReader["info"].ToString());
					try
					{
						宠物存档数据类 value2 = JsonConvert.DeserializeObject<宠物存档数据类>(value);
						Singleton<全局变量类>.I.宠物存档表.TryAdd(text, value2);
					}
					catch (Exception ex)
					{
						Log.Error("宠物存档读取报错：iid[" + text + "]" + ex.Message + "(" + ex.StackTrace + ")");
					}
				}
			}
			string[] files = Directory.GetFiles(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("/宠物存档夹"), "*.json");
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			foreach (string text2 in files)
			{
				try
				{
					宠物存档数据类 宠物存档数据类2 = JsonConvert.DeserializeObject<宠物存档数据类>(File.ReadAllText(text2));
					if (Singleton<全局变量类>.I.宠物存档表.ContainsKey(宠物存档数据类2.IID))
					{
						Singleton<全局变量类>.I.宠物存档表[宠物存档数据类2.IID] = 宠物存档数据类2;
					}
					else
					{
						Singleton<全局变量类>.I.宠物存档表.TryAdd(宠物存档数据类2.IID, 宠物存档数据类2);
					}
				}
				catch (Exception ex2)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 3);
					defaultInterpolatedStringHandler.AppendLiteral("宠物存档读取报错：路径=【");
					defaultInterpolatedStringHandler.AppendFormatted(text2);
					defaultInterpolatedStringHandler.AppendLiteral("】 错误=【");
					defaultInterpolatedStringHandler.AppendFormatted(ex2.Message);
					defaultInterpolatedStringHandler.AppendLiteral("】(");
					defaultInterpolatedStringHandler.AppendFormatted(ex2.StackTrace);
					defaultInterpolatedStringHandler.AppendLiteral(")");
					Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("宠物存档读取完成：");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.宠物存档表.Count);
			defaultInterpolatedStringHandler.AppendLiteral("只");
			Log.Debug(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		catch (Exception ex3)
		{
			Log.Error("初始化宠物存档数据错误：" + ex3.Message + "(" + ex3.StackTrace + ")");
		}
	}

	
	internal void oMuiwEHr6E(int P_0, 角色存档数据类 P_1)
	{
		try
		{
			lock (LiqileM5Re)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("/角色存档夹/key：");
				defaultInterpolatedStringHandler.AppendFormatted(P_0);
				defaultInterpolatedStringHandler.AppendLiteral(".json");
				File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU(defaultInterpolatedStringHandler.ToStringAndClear()), JsonConvert.SerializeObject(P_1));
			}
		}
		catch (Exception ex)
		{
			Log.Error("角色存档处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void irWib79NaP(string P_0, 宠物存档数据类 P_1)
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("/宠物存档夹/key：" + (Singleton<全局变量类>.I.验证平台校验() ? P_0.Replace(":", string.Empty) : P_0) + ".json"), JsonConvert.SerializeObject(P_1));
		}
		catch (Exception ex)
		{
			Log.Error("宠物存档处理-失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task oSPiJX3g49()
	{
		if (!全量存档门.TryEnter())
		{
			Log.Warning("全量存档请求已跳过：已有存档任务正在执行");
			return;
		}
		DateTime 开始时间 = DateTime.UtcNow;
		try
		{
			int index = 0;
			foreach (角色存档数据类 value in Singleton<全局变量类>.I.角色存档表.Values)
			{
				oMuiwEHr6E(value.GID, value);
				if ((++index & 31) == 0)
				{
					await Task.Yield();
				}
			}
			Log.Debug("角色存档完成，总存档数：" + Singleton<全局变量类>.I.角色存档表.Count + "，耗时：" + (DateTime.UtcNow - 开始时间).TotalMilliseconds + "ms");
		}
		catch (Exception ex)
		{
			Log.Error("自动存档角色数据错误：" + ex.Message);
		}
		finally
		{
			全量存档门.Exit();
		}
	}

	internal async Task<ArchiveSaveResult> 保存全部存档()
	{
		if (!全量存档门.TryEnter())
		{
			Log.Warning("全部存档请求已跳过：已有存档任务正在执行");
			return ArchiveSaveResult.Busy;
		}
		DateTime 开始时间 = DateTime.UtcNow;
		try
		{
			int 角色数量 = 0;
			foreach (角色存档数据类 value in Singleton<全局变量类>.I.角色存档表.Values)
			{
				oMuiwEHr6E(value.GID, value);
				角色数量++;
				if ((角色数量 & 31) == 0)
				{
					await Task.Yield();
				}
			}
			int 宠物数量 = 0;
			foreach (宠物存档数据类 value2 in Singleton<全局变量类>.I.宠物存档表.Values)
			{
				irWib79NaP(value2.IID, value2);
				宠物数量++;
				if ((宠物数量 & 31) == 0)
				{
					await Task.Yield();
				}
			}
			Log.Debug("全部存档完成，角色存档数：" + 角色数量 + "，宠物存档数：" + 宠物数量 + "，耗时：" + (DateTime.UtcNow - 开始时间).TotalMilliseconds + "ms");
			return ArchiveSaveResult.Completed;
		}
		catch (Exception ex)
		{
			Log.Error("全部存档错误：" + ex.Message);
			return ArchiveSaveResult.Failed;
		}
		finally
		{
			全量存档门.Exit();
		}
	}

	internal async Task<ArchiveSaveResult> 保存在线存档()
	{
		if (!全量存档门.TryEnter())
		{
			Log.Warning("在线存档请求已跳过：已有存档任务正在执行");
			return ArchiveSaveResult.Busy;
		}
		DateTime 开始时间 = DateTime.UtcNow;
		try
		{
			HashSet<int> 已保存角色 = new HashSet<int>();
			HashSet<string> 已保存宠物 = new HashSet<string>(StringComparer.Ordinal);
			int 角色数量 = 0;
			int 宠物数量 = 0;
			foreach (MyNATSocketClient session in Singleton<全局变量类>.I.会话Dict.Values)
			{
				if (session == null || !session.使用中 || session.当前client == null || !session.当前client.Online || session.转发client == null || !session.转发client.Online || session.user == null || session.user.人物数据 == null || session.user.存档数据 == null || session.user.人物数据.GID == 0)
				{
					continue;
				}
				int gid = session.user.人物数据.GID;
				if (已保存角色.Add(gid))
				{
					Singleton<全局变量类>.I.角色存档表.TryGetValue(gid, out 角色存档数据类 roleArchive);
					角色存档数据类 archive = roleArchive ?? session.user.存档数据;
					oMuiwEHr6E(gid, archive);
					角色数量++;
					if (((角色数量 + 宠物数量) & 31) == 0)
					{
						await Task.Yield();
					}
				}
				if (session.user.宠物数据 == null)
				{
					continue;
				}
				foreach (宠物缓存数据类 pet in session.user.宠物数据)
				{
					if (pet == null || pet.PetID == 0 || string.IsNullOrWhiteSpace(pet.IID) || !已保存宠物.Add(pet.IID))
					{
						continue;
					}
					if (Singleton<全局变量类>.I.宠物存档表.TryGetValue(pet.IID, out 宠物存档数据类 petArchive))
					{
						irWib79NaP(pet.IID, petArchive);
						宠物数量++;
						if (((角色数量 + 宠物数量) & 31) == 0)
						{
							await Task.Yield();
						}
					}
				}
			}
			Log.Debug("在线存档完成，角色存档数：" + 角色数量 + "，宠物存档数：" + 宠物数量 + "，耗时：" + (DateTime.UtcNow - 开始时间).TotalMilliseconds + "ms");
			return ArchiveSaveResult.Completed;
		}
		catch (Exception ex)
		{
			Log.Error("在线存档错误：" + ex.Message);
			return ArchiveSaveResult.Failed;
		}
		finally
		{
			全量存档门.Exit();
		}
	}

	
	internal async Task jbJiKEWvoC()
	{
		if (!全量存档门.TryEnter())
		{
			Log.Warning("宠物全量存档请求已跳过：已有存档任务正在执行");
			return;
		}
		DateTime 开始时间 = DateTime.UtcNow;
		try
		{
			int index = 0;
			foreach (宠物存档数据类 value in Singleton<全局变量类>.I.宠物存档表.Values)
			{
				irWib79NaP(value.IID, value);
				if ((++index & 31) == 0)
				{
					await Task.Yield();
				}
			}
			Log.Debug("宠物存档完成，总存档数：" + Singleton<全局变量类>.I.宠物存档表.Count + "，耗时：" + (DateTime.UtcNow - 开始时间).TotalMilliseconds + "ms");
		}
		catch (Exception ex)
		{
			Log.Error("自动存档宠物数据错误：" + ex.Message);
		}
		finally
		{
			全量存档门.Exit();
		}
	}

	
	internal void vZGiRD2ejr()
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("初始化注册信息数据-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select * from yjzcxx";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			Singleton<全局变量类>.I.注册列表.Clear();
			if (mySqlDataReader != null)
			{
				while (mySqlDataReader.Read())
				{
					注册信息 item = new 注册信息
					{
						账号 = mySqlDataReader["account"].ToString(),
						密码 = mySqlDataReader["pass"].ToString(),
						安全码 = mySqlDataReader["aqpass"].ToString(),
						注册验证码 = mySqlDataReader["yzm"].ToString(),
						名字 = ujjNRZ9vuH(mySqlDataReader["zcname"].ToString()),
						等级 = int.Parse(mySqlDataReader["zclv"].ToString()),
						IP = mySqlDataReader["zcip"].ToString(),
						Mac = mySqlDataReader["zcmac"].ToString(),
						qq = mySqlDataReader["zcqq"].ToString(),
						注册时间 = mySqlDataReader["zctime"].ToString()
					};
					Singleton<全局变量类>.I.注册列表.Add(item);
				}
			}
			mySqlDataReader.Close();
		}
		catch (Exception ex)
		{
			Log.Error("初始化注册信息数据错误：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public string GID取宠物数据(string 十六GID)
	{
		try
		{
			string result = string.Empty;
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("GID取宠物数据-mysql数据库连接失败！");
				return result;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where name='" + 十六GID + "'  and branch='patch'";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null)
			{
				return result;
			}
			while (mySqlDataReader.Read())
			{
				result = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
			}
			mySqlDataReader.Close();
			return result;
		}
		catch (Exception ex)
		{
			Log.Error("GID取宠物数据错误：" + ex.Message);
			return string.Empty;
		}
	}

	
	public string GID取娃娃数据(string 十六GID)
	{
		try
		{
			string result = string.Empty;
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("GID取宠物数据-mysql数据库连接失败！");
				return result;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bytedata from data where name='" + 十六GID + "'  and branch='patch'";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader == null)
			{
				return result;
			}
			while (mySqlDataReader.Read())
			{
				result = XEYNKGEPKJ((byte[])mySqlDataReader["bytedata"]);
				result = Singleton<ByteAPI>.I.文本_取出中间文本(result, "\"children\":([", ",]),\"practice_children");
			}
			mySqlDataReader.Close();
			return result;
		}
		catch (Exception ex)
		{
			Log.Error("GID取宠物数据错误：" + ex.Message);
			return string.Empty;
		}
	}

	
	public void Mysql_发送五系娃娃处理(int GID, string 账号, string 昵称, int 等级)
	{
		try
		{
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(GID);
			string text = GID取宠物数据(hexGid_);
			string text2 = GID取娃娃数据(hexGid_);
			int num = 0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			for (int i = 1; i < 10; i++)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted(i);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted("\"");
				if (text2.IndexOf(defaultInterpolatedStringHandler.ToStringAndClear()) == -1)
				{
					num = i;
					break;
				}
			}
			if (num == 0 || num >= 9)
			{
				return;
			}
			int value = (int)Singleton<ByteAPI>.I.取时间戳();
			int value2 = 等级;
			string newValue = "\"family\":\"五龙山云霄洞\",";
			string newValue2 = "\"polar\":1,";
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(150, 30);
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral("wulei-zhaoding");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral("liba-shanhe");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral("kumu-fengchun");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral("yulu-huanyang");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral("chuanliu-buxi");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral("xingyun-liushui");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral("daoyi-youdao");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral("dadao-wuwei");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral("bufeng-zhuoying");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral("tiandao-ziran");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			string newValue3 = defaultInterpolatedStringHandler.ToStringAndClear();
			string newValue4 = "五系强力娃娃";
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 3);
			defaultInterpolatedStringHandler.AppendLiteral("5D00EAE4");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.qrjo9TWIdy(10000, 49999), "X");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.qrjo9TWIdy(10000, 49999), "X");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<WdAPI>.I.qrjo9TWIdy(10000, 49999), "X");
			string text3 = defaultInterpolatedStringHandler.ToStringAndClear();
			string text4 = "10086:\"赠送娃娃:1:0:0::ID:\",";
			text4 = text4.Replace("10086", num.ToString());
			text4 = text4.Replace("赠送娃娃", newValue4);
			text4 = text4.Replace("ID", text3);
			string text5 = text;
			string oldValue = "\"children\":([";
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 3);
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral("children");
			defaultInterpolatedStringHandler.AppendFormatted("\"");
			defaultInterpolatedStringHandler.AppendLiteral(":([");
			defaultInterpolatedStringHandler.AppendFormatted(text4);
			text = text5.Replace(oldValue, defaultInterpolatedStringHandler.ToStringAndClear());
			int dataChecksum = GetDataChecksum("user" + hexGid_ + "patch" + text);
			text = text.Replace("\\", "\\\\");
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(111, 3);
			defaultInterpolatedStringHandler.AppendLiteral("UPDATE data SET content='");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("'  where path = 'user' and branch ='patch' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(hexGid_);
			defaultInterpolatedStringHandler.AppendLiteral("' ORDER BY name DESC");
			string text6 = defaultInterpolatedStringHandler.ToStringAndClear();
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("Mysql_发送五系娃娃处理失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			c1ZNsjqlRc(mySqlConnection, text6);
			text6 = string.Empty;
			text6 = "([\"carry\":([]),\"attrib\":([\"food\":100000,\"mood\":100000,\"refresh_stamina_time\":1560346270,\"gender\":2,\"status\":0,\"life\":23962,\"attack_speed\":4,\"combat_mode\":7,\"max_stamina\":200,\"pot\":0,\"max_mood\":100000,\"phy_effect\":100,\"exp_to_next_level\":0,\"level_up_time\":1560364099,\"max_food\":100000,\"str\":力气,\"stamina\":200,\"dex\":灵敏,\"def\":2604,\"icon\":娃娃图片id,娃娃相性\"max_limit_level\":1600,\"repair_ver\":6,\"intimacy\":娃娃亲密度,\"phy_power\":7326,\"capacity\":娃娃潜能点,\"mag_power\":7328,\"str_effect\":100,\"train_process\":0,\"lock_exp\":1,\"birthday\":娃娃生日,\"dodge\":11,\"iid\"::娃娃iid:,\"wisdom\":智慧,娃娃门派\"physique\":体魄,\"rank\":6,\"mana\":1000,\"wit_effect\":100,\"use_skill\":([娃娃技能]),\"name\":\"赠送娃娃\",\"parents\":({\"角色GID\",}),\"level\":等级,\"max_life\":23962,\"exp\":0,\"dex_effect\":100,\"stamina_effect\":100,\"max_mana\":0,\"health\":0,\"portrait\":240020233,]),\"skills\":([娃娃技能]),])".Replace("等级", 等级.ToString());
			text6 = text6.Replace("角色GID", hexGid_);
			text6 = text6.Replace("娃娃图片id", "7015");
			text6 = text6.Replace("娃娃亲密度", "1000000");
			text6 = text6.Replace("赠送娃娃", newValue4);
			text6 = text6.Replace("娃娃潜能点", $"{等级 * 4}");
			text6 = text6.Replace("娃娃iid", text3);
			text6 = text6.Replace("娃娃相性", newValue2);
			text6 = text6.Replace("娃娃门派", newValue);
			text6 = text6.Replace("娃娃技能", newValue3);
			text6 = text6.Replace("力气", $"{等级}");
			text6 = text6.Replace("灵敏", $"{等级}");
			text6 = text6.Replace("灵敏", $"{等级}");
			text6 = text6.Replace("智慧", $"{等级}");
			text6 = text6.Replace("体魄", $"{等级}");
			text6 = text6.Replace("娃娃生日", $"{value}");
			dataChecksum = GetDataChecksum("child:" + text3 + ":" + text6);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(103, 3);
			defaultInterpolatedStringHandler.AppendLiteral("INSERT INTO  data (path,name,branch,content,time,checksum) VALUES('child',':");
			defaultInterpolatedStringHandler.AppendFormatted(text3);
			defaultInterpolatedStringHandler.AppendLiteral(":','','");
			defaultInterpolatedStringHandler.AppendFormatted(text6);
			defaultInterpolatedStringHandler.AppendLiteral("','20190915115532',");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			text6 = defaultInterpolatedStringHandler.ToStringAndClear();
			c1ZNsjqlRc(mySqlConnection, text6);
			锁定账号操作(账号, "0");
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_发送五系娃娃处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	private int CYLidiqi5K()
	{
		lock (zl7i8BHLMm)
		{
			Singleton<全局变量类>.I.注册id++;
			return Singleton<全局变量类>.I.注册id;
		}
	}

	
	internal string GnMisRMvyJ(string P_0, string P_1)
	{
		try
		{
			int num = 0;
			int num2 = 0;
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("注册码兑换处理-mysql数据库连接失败！");
				return "数据库连接失败！";
			}
			o51NJkPfKI(mySqlConnection);
			using (MySqlCommand mySqlCommand = new MySqlCommand("select * from yjcdk where cdk=@cdk", mySqlConnection))
			{
				mySqlCommand.Parameters.AddWithValue("@cdk", P_0);
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null)
				{
					return "注册码不存在！";
				}
				if (!mySqlDataReader.Read())
				{
					return "注册码已被使用！";
				}
				num = int.Parse(mySqlDataReader["cdktype"].ToString());
				num2 = int.Parse(mySqlDataReader["count"].ToString());
			}
			if (num != 4)
			{
				return "非注册码卡密，无法使用！";
			}
			if (num2 <= 0)
			{
				return "当前注册码可使用次数为0，无法使用！";
			}
			num2--;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(58, 4);
			defaultInterpolatedStringHandler.AppendLiteral("update yjcdk set syname='");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("',count='");
			defaultInterpolatedStringHandler.AppendFormatted(num2);
			defaultInterpolatedStringHandler.AppendLiteral("',sytime='");
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("' where cdk='");
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			if (c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear()) != 1)
			{
				return "注册失败！";
			}
			return string.Empty;
		}
		catch (Exception ex)
		{
			Log.Error("注册码兑换处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return "注册异常";
		}
	}

	
	public void 网关注册账号事件(string 账号, string 密码, string 安全码, string 昵称, int 新旧, int 性别, int 门派, int 仙魔, int 等级, string IP, string mac, string qq, string 注册验证码 = "", Action<bool, string> 回调事件 = null)
	{
		_003C_003Ec__DisplayClass91_0 CS_0024_003C_003E8__locals15 = new _003C_003Ec__DisplayClass91_0();
		CS_0024_003C_003E8__locals15.HTa73kU9IY = mac;
		CS_0024_003C_003E8__locals15.T7G7Y7tfPQ = qq;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(72, 13);
		defaultInterpolatedStringHandler.AppendLiteral("网关注册：账号=");
		defaultInterpolatedStringHandler.AppendFormatted(账号);
		defaultInterpolatedStringHandler.AppendLiteral(", 密码=");
		defaultInterpolatedStringHandler.AppendFormatted(密码);
		defaultInterpolatedStringHandler.AppendLiteral(", 安全码=");
		defaultInterpolatedStringHandler.AppendFormatted(安全码);
		defaultInterpolatedStringHandler.AppendLiteral(", 昵称=");
		defaultInterpolatedStringHandler.AppendFormatted(昵称);
		defaultInterpolatedStringHandler.AppendLiteral(", 新旧=");
		defaultInterpolatedStringHandler.AppendFormatted(新旧);
		defaultInterpolatedStringHandler.AppendLiteral(", 性别=");
		defaultInterpolatedStringHandler.AppendFormatted(性别);
		defaultInterpolatedStringHandler.AppendLiteral(", 门派=");
		defaultInterpolatedStringHandler.AppendFormatted(门派);
		defaultInterpolatedStringHandler.AppendLiteral(", 仙魔=");
		defaultInterpolatedStringHandler.AppendFormatted(仙魔);
		defaultInterpolatedStringHandler.AppendLiteral(", 等级=");
		defaultInterpolatedStringHandler.AppendFormatted(等级);
		defaultInterpolatedStringHandler.AppendLiteral(", IP=");
		defaultInterpolatedStringHandler.AppendFormatted(IP);
		defaultInterpolatedStringHandler.AppendLiteral(", mac=");
		defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals15.HTa73kU9IY);
		defaultInterpolatedStringHandler.AppendLiteral(", qq=");
		defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals15.T7G7Y7tfPQ);
		defaultInterpolatedStringHandler.AppendLiteral("，注册验证码=");
		defaultInterpolatedStringHandler.AppendFormatted(注册验证码);
		Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		try
		{
			ByteAPI i = Singleton<ByteAPI>.I;
			string buffer = "|" + Singleton<全局变量类>.I.网关Config.共享配置.注册等级 + "|";
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted(等级);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			if (!i.寻找文本(buffer, defaultInterpolatedStringHandler.ToStringAndClear()))
			{
				回调事件?.Invoke(arg1: false, "注册的等级有误，警告一次！");
				return;
			}
			if (账号.Length > 16 || 密码.Length > 16 || 安全码.Length > 16)
			{
				回调事件?.Invoke(arg1: false, "注册的信息有敏感词，请重新输入（仅限数字、英文）");
				return;
			}
			if (Singleton<ByteAPI>.I.寻找文本或(账号, "GM", "gm", "Gm", "gM", "客服", "群", "裙", "君羊", "null", "企", "鹅"))
			{
				回调事件?.Invoke(arg1: false, "注册的账号有敏感词，请重新输入（仅限数字、英文）");
				return;
			}
			if (Singleton<ByteAPI>.I.寻找文本或(密码, ",", "/", "\\", "'", "‘", "or", "is", "_", "-", "@", "where"))
			{
				回调事件?.Invoke(arg1: false, "注册的密码有敏感词，请重新输入（仅限数字和英文）");
				return;
			}
			if (!Singleton<全局变量类>.I.网关Config.共享配置.Is注册昵称)
			{
				if (昵称.Length > 8)
				{
					回调事件?.Invoke(arg1: false, "注册的角色名字长度有误，请重新输入！");
					return;
				}
				if (Singleton<WdAPI>.I.玩家昵称违规(昵称))
				{
					回调事件?.Invoke(arg1: false, "注册的角色名字有敏感词，请重新输入（限中文、数字、英文）");
					return;
				}
			}
			if (Singleton<ByteAPI>.I.寻找文本或(昵称, 全局变量类.禁止注册名字.ToString()))
			{
				回调事件?.Invoke(arg1: false, "注册的角色名字有敏感词，请重新输入（限中文、数字、英文）");
				return;
			}
			if (!Singleton<全局变量类>.I.网关Config.共享配置.Is注册新角色 && 新旧 == 2)
			{
				回调事件?.Invoke(arg1: false, "暂时无法注册新角色！");
				return;
			}
			if (Singleton<全局变量类>.I.网关Config.共享配置.Is登录qq)
			{
				if (string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals15.T7G7Y7tfPQ))
				{
					回调事件?.Invoke(arg1: false, "请先登录QQ！");
					return;
				}
				List<string> list = CS_0024_003C_003E8__locals15.T7G7Y7tfPQ.Split('|').ToList();
				list.Remove(string.Empty);
				if (list.Count <= 0)
				{
					回调事件?.Invoke(arg1: false, "请先登录QQ！");
					return;
				}
			}
			if (string.IsNullOrWhiteSpace(账号) || 账号.Contains("test", StringComparison.CurrentCulture) || 账号.Contains("stanwind", StringComparison.CurrentCulture))
			{
				回调事件?.Invoke(arg1: false, "禁止注册非法账号！");
				return;
			}
			using MySqlConnection mySqlConnection = new MySqlConnection(allsql);
			_ = string.Empty;
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("网关注册账号事件-mysql数据库连接失败！");
				回调事件?.Invoke(arg1: false, "数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using (MySqlCommand mySqlCommand = new MySqlCommand())
			{
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = "select account from " + Singleton<全局变量类>.I.网关Config.数据库adb + ".account where account=@account";
				mySqlCommand.Parameters.AddWithValue("@account", 账号);
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null)
				{
					回调事件?.Invoke(arg1: false, "账号数据异常！");
					return;
				}
				if (mySqlDataReader.Read())
				{
					回调事件?.Invoke(arg1: false, "账号已存在！");
					return;
				}
			}
			if (!Singleton<全局变量类>.I.网关Config.共享配置.Is注册昵称)
			{
				bool flag = false;
				using (MySqlCommand mySqlCommand2 = new MySqlCommand())
				{
					mySqlCommand2.CommandText = "select name from " + Singleton<全局变量类>.I.网关Config.数据库ddb + ".gid_info where name=@name";
					mySqlCommand2.Parameters.AddWithValue("@name", 昵称);
					mySqlCommand2.Connection = mySqlConnection;
					using MySqlDataReader mySqlDataReader2 = mySqlCommand2.ExecuteReader();
					if (mySqlDataReader2 == null)
					{
						回调事件?.Invoke(arg1: false, "名字数据异常！");
						return;
					}
					if (mySqlDataReader2.Read())
					{
						flag = true;
					}
				}
				if (flag)
				{
					回调事件?.Invoke(arg1: false, "当前角色昵称已存在！");
					return;
				}
			}
			else
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("道友ID：");
				defaultInterpolatedStringHandler.AppendFormatted(CYLidiqi5K());
				昵称 = defaultInterpolatedStringHandler.ToStringAndClear();
				bool flag2 = true;
				do
				{
					using (MySqlCommand mySqlCommand3 = new MySqlCommand())
					{
						mySqlCommand3.Connection = mySqlConnection;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 2);
						defaultInterpolatedStringHandler.AppendLiteral("select name from ");
						defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.网关Config.数据库ddb);
						defaultInterpolatedStringHandler.AppendLiteral(".gid_info where name='");
						defaultInterpolatedStringHandler.AppendFormatted(昵称);
						defaultInterpolatedStringHandler.AppendLiteral("'");
						mySqlCommand3.CommandText = defaultInterpolatedStringHandler.ToStringAndClear();
						using MySqlDataReader mySqlDataReader3 = mySqlCommand3.ExecuteReader();
						flag2 = (mySqlDataReader3?.Read()).Value;
					}
					if (!flag2)
					{
						break;
					}
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendLiteral("道友ID：");
					defaultInterpolatedStringHandler.AppendFormatted(CYLidiqi5K());
					昵称 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				while (flag2);
			}
			if (Singleton<全局变量类>.I.网关Config.限制注册 > 0)
			{
				if (Singleton<全局变量类>.I.注册列表.Count( (注册信息 x) => x.Mac == CS_0024_003C_003E8__locals15.HTa73kU9IY) >= Singleton<全局变量类>.I.网关Config.限制注册)
				{
					回调事件?.Invoke(arg1: false, "ERROR-2，你当前已注册数量已达上限！");
					return;
				}
				if (Singleton<全局变量类>.I.注册列表.Count( (注册信息 x) => x.Is重复qq(CS_0024_003C_003E8__locals15.T7G7Y7tfPQ)) >= Singleton<全局变量类>.I.网关Config.限制注册)
				{
					回调事件?.Invoke(arg1: false, "ERROR-3，你当前已注册数量已达上限！");
					return;
				}
			}
			if (Singleton<全局变量类>.I.验证client.授权配置.Is验证注册 && Singleton<全局变量类>.I.网关Config.Is注册验证码)
			{
				if (string.IsNullOrWhiteSpace(注册验证码) || 注册验证码.Length > 16)
				{
					Log.Error("注册验证码必填！");
					回调事件?.Invoke(arg1: false, "注册验证码必填！");
					return;
				}
				string text = GnMisRMvyJ(注册验证码, 账号);
				if (!string.IsNullOrWhiteSpace(text))
				{
					Log.Error("注册验证码注册失败！");
					回调事件?.Invoke(arg1: false, text);
					return;
				}
			}
			int num = 0;
			string mD5Info = GetMD5Info(账号 + GetMD5Info(密码) + "20070201");
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(188, 1);
			defaultInterpolatedStringHandler.AppendLiteral("INSERT INTO ");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.adb表);
			defaultInterpolatedStringHandler.AppendLiteral(".account");
			defaultInterpolatedStringHandler.AppendLiteral("(account,password,gold_coin,silver_coin,checksum,memo,privilege,blocked_time)VALUES");
			defaultInterpolatedStringHandler.AppendLiteral("(@account,@password,@gold_coin,@silver_coin,@checksum,@memo,@privilege,@blocked_time)");
			using (MySqlCommand mySqlCommand4 = new MySqlCommand(defaultInterpolatedStringHandler.ToStringAndClear(), mySqlConnection))
			{
				mySqlCommand4.Parameters.AddWithValue("@account", 账号);
				mySqlCommand4.Parameters.AddWithValue("@password", mD5Info);
				mySqlCommand4.Parameters.AddWithValue("@gold_coin", Singleton<全局变量类>.I.网关Config.送金元宝);
				mySqlCommand4.Parameters.AddWithValue("@silver_coin", Singleton<全局变量类>.I.网关Config.送银元宝);
				mySqlCommand4.Parameters.AddWithValue("@checksum", string.Empty);
				mySqlCommand4.Parameters.AddWithValue("@memo", 安全码);
				mySqlCommand4.Parameters.AddWithValue("@privilege", Singleton<全局变量类>.I.网关Config.注册权限);
				mySqlCommand4.Parameters.AddWithValue("@blocked_time", string.Empty);
				num = mySqlCommand4.ExecuteNonQuery();
				if (num < 0)
				{
					Log.Error("账号注册数据插入失败！");
					回调事件?.Invoke(arg1: false, "账号注册失败，请稍后重试！");
					return;
				}
			}
			num = c1ZNsjqlRc(mySqlConnection, AccChecksum(账号, Singleton<全局变量类>.I.config.adb表 + "."));
			if (num <= -1)
			{
				return;
			}
			Singleton<GyJyg8g24jqCD31mjD6>.I.lScgXuebT5();
			int num2 = ((等级 < 139 && Singleton<全局变量类>.I.网关Config.Is注册1级大飞) ? 139 : 等级);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 3);
			defaultInterpolatedStringHandler.AppendLiteral("INSERT INTO ");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.网关Config.数据库ddb);
			defaultInterpolatedStringHandler.AppendLiteral(".gid_info VALUES(null,'user','");
			defaultInterpolatedStringHandler.AppendFormatted(昵称);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(string.Format("{0:yyyyMMddHHmmss}", DateTime.Now));
			defaultInterpolatedStringHandler.AppendLiteral("',null)");
			num = c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
			if (num < 0)
			{
				Log.Error("账号注册昵称数据插入失败！");
				回调事件?.Invoke(arg1: false, "账号注册失败，请稍后重试！");
				return;
			}
			int result = 0;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 2);
			defaultInterpolatedStringHandler.AppendLiteral("select gid from ");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.网关Config.数据库ddb);
			defaultInterpolatedStringHandler.AppendLiteral(".gid_info where name='");
			defaultInterpolatedStringHandler.AppendFormatted(昵称);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			using (MySqlCommand mySqlCommand5 = new MySqlCommand(defaultInterpolatedStringHandler.ToStringAndClear(), mySqlConnection))
			{
				using MySqlDataReader mySqlDataReader4 = mySqlCommand5.ExecuteReader();
				if (mySqlDataReader4.Read())
				{
					int.TryParse(mySqlDataReader4["gid"].ToString(), out result);
				}
				mySqlDataReader4.Close();
				if (result == 0)
				{
					Log.Error("账号注册昵称Gid数据插入失败！");
					回调事件?.Invoke(arg1: false, "增加Gid失败！");
					return;
				}
			}
			string text2 = ((性别 == 1) ? "7008" : "7009");
			string icons = 问道数据类.GetIcons(门派, 新旧, 性别);
			string text3 = $"{(AllEnums.门派Type)门派}";
			string text4 = 全局常量类.遁术技能[门派];
			string text5 = ((num2 >= 100) ? 全局常量类.一代师尊[门派] : 全局常量类.二代师尊[门派]);
			string text6 = "\"jiji-rulvling\":1,";
			string text7 = ((num2 < 100) ? "" : "\"liaodi-xianji\":等级,\"yulu-huanyuan\":等级,\"tianji-shenjia\":等级,\"wuxing-xiangsheng\":等级,\"yaowang-shending\":等级,\"wuxing-xiangfu\":等级,\"ruyou-shenzhu\":等级,\"lingli-zengfu\":等级,\"yiya-huanya\":等级,\"shixue-kuangluan\":等级,\"xieling-futi\":等级,\"shibu-kedang\":等级,\"dadao-lunhui\":等级,\"fali-wubian\":等级,\"tuiling-xuezhou\":等级,\"tianjiang-xiafan\":等级,\"houfa-zhiren\":等级,\"sanyuan-guiyi\":等级,\"duhua-chengkong\":等级,\"youchou-bibao\":等级,\"jingang-zhiqu\":等级,\"nujiao-lianzhan\":等级,\"kexue-qishu\":等级,\"gonggong-mieshi\":等级,\"jinshen-bumie\":等级,\"ruhuan-simeng\":等级,".Replace("等级", Singleton<全局变量类>.I.网关Config.引灵幡技能等级.ToString()));
			int num3 = 等级 - 130;
			string text8 = "";
			string text9 = string.Format("{0:X16}", result);
			int num4 = (((double)num2 * (Singleton<全局变量类>.I.网关Config.Is带技能精研 ? 2.0 : 1.5) > 330.0) ? 330 : ((int)((double)num2 * (Singleton<全局变量类>.I.网关Config.Is带技能精研 ? 2.0 : 1.5))));
			if (Singleton<全局变量类>.I.网关Config.Is带技能)
			{
				if (门派 == 1 && 新旧 == 1)
				{
					text6 += (((num2 >= 100) ? "\"jinguang-zhaxian\":数值,\"daoguang-jianying\":数值,\"jinhong-guanri\":数值,\"liuguang-yicai\":数值,\"nitian-canren\":数值,\"liulian-wangfan\":数值,\"deyi-wangxing\":数值,\"ruchi-ruzui\":数值,\"rumeng-chuxing\":数值,\"huangruo-geshi\":数值,\"tiansheng-shenli\":数值,\"qichong-douniu\":数值,\"jiuniu-erhu\":数值,\"ruhu-tianyi\":数值,\"liwan-kuanglan\":数值,\"jinbi-huihuang\":数值,\"zhidao-huanglong\":数值,\"jincheng-tangchi\":数值,\"jinfa-fenghun\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"jinguang-zhaxian\":数值,\"daoguang-jianying\":数值,\"jinhong-guanri\":数值,\"liuguang-yicai\":数值,\"liulian-wangfan\":数值,\"deyi-wangxing\":数值,\"ruchi-ruzui\":数值,\"rumeng-chuxing\":数值,\"tiansheng-shenli\":数值,\"qichong-douniu\":数值,\"jiuniu-erhu\":数值,\"ruhu-tianyi\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				else if (门派 == 1 && 新旧 == 2)
				{
					text6 += (((num2 >= 100) ? "\"dandao-zhiru\":数值,\"ruibu-kedang\":数值,\"qiandao-wanren\":数值,\"fengmang-bilou\":数值,\"wandao-jinguang\":数值,\"buzhi-suocuo\":数值,\"danzhan-xinjing\":数值,\"jinghun-weiding\":数值,\"zhenhun-suoxin\":数值,\"duoshen-shepo\":数值,\"quanli-yifu\":数值,\"qiguan-changhong\":数值,\"jianba-nuzhang\":数值,\"shiru-pozhu\":数值,\"lipi-xuanhuang\":数值,\"jinbi-huihuang\":数值,\"zhidao-huanglong\":数值,\"jincheng-tangchi\":数值,\"jinfa-fenghun\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"dandao-zhiru\":数值,\"ruibu-kedang\":数值,\"qiandao-wanren\":数值,\"fengmang-bilou\":数值,\"buzhi-suocuo\":数值,\"danzhan-xinjing\":数值,\"jinghun-weiding\":数值,\"zhenhun-suoxin\":数值,\"quanli-yifu\":数值,\"qiguan-changhong\":数值,\"jianba-nuzhang\":数值,\"shiru-pozhu\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				if (门派 == 2 && 新旧 == 1)
				{
					text6 += (((num2 >= 100) ? "\"zhaiye-feihua\":数值,\"feiliu-xianshi\":数值,\"pangen-cuojie\":数值,\"luoying-binfen\":数值,\"guiwu-kuteng\":数值,\"jianxie-fenghou\":数值,\"shekou-fengzhen\":数值,\"heding-hongfen\":数值,\"xiewei-shexian\":数值,\"wanyi-shixin\":数值,\"bamiao-zhuzhang\":数值,\"huoshang-jiaoyou\":数值,\"shuizhang-chuangao\":数值,\"honghua-lvye\":数值,\"jinshang-tianhua\":数值,\"luoye-xiaoxiao\":数值,\"manwu-feitian\":数值,\"baidu-buqin\":数值,\"judu-gongxin\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"zhaiye-feihua\":数值,\"feiliu-xianshi\":数值,\"pangen-cuojie\":数值,\"luoying-binfen\":数值,\"jianxie-fenghou\":数值,\"shekou-fengzhen\":数值,\"heding-hongfen\":数值,\"xiewei-shexian\":数值,\"bamiao-zhuzhang\":数值,\"huoshang-jiaoyou\":数值,\"shuizhang-chuangao\":数值,\"honghua-lvye\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				else if (门派 == 2 && 新旧 == 2)
				{
					text6 += (((num2 >= 100) ? "\"huawu-yefei\":数值,\"yanghua-feiliu\":数值,\"qiufeng-saoye\":数值,\"yiye-puti\":数值,\"tiannv-sanhua\":数值,\"mangci-zaibei\":数值,\"wufu-chongsheng\":数值,\"duru-gusui\":数值,\"jiusi-yisheng\":数值,\"zhetian-biri\":数值,\"ganzhi-ruyi\":数值,\"chunfeng-huayu\":数值,\"runwu-wusheng\":数值,\"tihu-guanding\":数值,\"miaoshou-huichun\":数值,\"luoye-xiaoxiao\":数值,\"manwu-feitian\":数值,\"baidu-buqin\":数值,\"judu-gongxin\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"huawu-yefei\":数值,\"yanghua-feiliu\":数值,\"qiufeng-saoye\":数值,\"yiye-puti\":数值,\"mangci-zaibei\":数值,\"wufu-chongsheng\":数值,\"duru-gusui\":数值,\"jiusi-yisheng\":数值,\"ganzhi-ruyi\":数值,\"chunfeng-huayu\":数值,\"runwu-wusheng\":数值,\"tihu-guanding\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				if (门派 == 3 && 新旧 == 1)
				{
					text6 += (((num2 >= 100) ? "\"dishui-chuanshi\":数值,\"yuhen-yunchou\":数值,\"xuanhe-xieshui\":数值,\"nubo-kuangtao\":数值,\"jiaohai-fanjiang\":数值,\"sanjiu-yanhan\":数值,\"tianhan-didong\":数值,\"bingdong-sanchi\":数值,\"jidi-binghan\":数值,\"baoluo-wanxiang\":数值,\"fangwei-dujian\":数值,\"tiegu-zhengzheng\":数值,\"binglai-jiangdang\":数值,\"tongqiang-tiebi\":数值,\"tiandi-hunyuan\":数值,\"shuitian-yise\":数值,\"tiema-binghe\":数值,\"shuangjia-bingdun\":数值,\"xuepiao-wanli\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"dishui-chuanshi\":数值,\"yuhen-yunchou\":数值,\"xuanhe-xieshui\":数值,\"nubo-kuangtao\":数值,\"sanjiu-yanhan\":数值,\"tianhan-didong\":数值,\"bingdong-sanchi\":数值,\"jidi-binghan\":数值,\"fangwei-dujian\":数值,\"tiegu-zhengzheng\":数值,\"binglai-jiangdang\":数值,\"tongqiang-tiebi\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				else if (门派 == 3 && 新旧 == 2)
				{
					text6 += (((num2 >= 100) ? "\"shuiliu-huaxie\":数值,\"jishui-chengyuan\":数值,\"fengqi-shuiyong\":数值,\"xueyao-bingtian\":数值,\"jiaolong-deshui\":数值,\"dishui-bulou\":数值,\"shengou-bilei\":数值,\"jixue-fengshuang\":数值,\"riyue-hebi\":数值,\"jinghua-shuiyue\":数值,\"tugu-naxin\":数值,\"fanghuan-weiran\":数值,\"hunran-yiti\":数值,\"yuxiao-yunsan\":数值,\"shuihuo-buqin\":数值,\"shuitian-yise\":数值,\"tiema-binghe\":数值,\"shuangjia-bingdun\":数值,\"xuepiao-wanli\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"shuiliu-huaxie\":数值,\"jishui-chengyuan\":数值,\"fengqi-shuiyong\":数值,\"xueyao-bingtian\":数值,\"dishui-bulou\":数值,\"shengou-bilei\":数值,\"jixue-fengshuang\":数值,\"riyue-hebi\":数值,\"tugu-naxin\":数值,\"fanghuan-weiran\":数值,\"hunran-yiti\":数值,\"yuxiao-yunsan\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				if (门派 == 4 && 新旧 == 1)
				{
					text6 += (((num2 >= 100) ? "\"juhuo-fentian\":数值,\"xinghuo-liaoyuan\":数值,\"yantian-huoyu\":数值,\"jiaojin-lishi\":数值,\"lianyu-huohai\":数值,\"xinzui-shenmi\":数值,\"shenhun-diandao\":数值,\"hunbu-shoushe\":数值,\"hunqian-mengying\":数值,\"hunbu-futi\":数值,\"shiwan-huoji\":数值,\"xiansheng-duoren\":数值,\"jifeng-xunlei\":数值,\"fengchi-dianche\":数值,\"binggui-shensu\":数值,\"huoshu-yinhua\":数值,\"huifei-yanmie\":数值,\"sanmei-lianxin\":数值,\"lihuo-duopo\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"juhuo-fentian\":数值,\"xinghuo-liaoyuan\":数值,\"yantian-huoyu\":数值,\"jiaojin-lishi\":数值,\"xinzui-shenmi\":数值,\"shenhun-diandao\":数值,\"hunbu-shoushe\":数值,\"hunqian-mengying\":数值,\"shiwan-huoji\":数值,\"xiansheng-duoren\":数值,\"jifeng-xunlei\":数值,\"fengchi-dianche\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				else if (门派 == 4 && 新旧 == 2)
				{
					text6 += (((num2 >= 100) ? "\"nujian-lixian\":数值,\"yijian-shuangdiao\":数值,\"jianbu-xufa\":数值,\"xingfei-yunsan\":数值,\"wanjian-chuanxin\":数值,\"xinsuo-shenfeng\":数值,\"chongyuan-diesuo\":数值,\"rufeng-sibi\":数值,\"kunling-suoxin\":数值,\"yunmi-wusuo\":数值,\"jiru-xinghuo\":数值,\"xingchi-dianzou\":数值,\"dianguang-shihuo\":数值,\"feiyun-zhidian\":数值,\"huxiao-fengchi\":数值,\"huoshu-yinhua\":数值,\"huifei-yanmie\":数值,\"sanmei-lianxin\":数值,\"lihuo-duopo\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"nujian-lixian\":数值,\"yijian-shuangdiao\":数值,\"jianbu-xufa\":数值,\"xingfei-yunsan\":数值,\"xinsuo-shenfeng\":数值,\"chongyuan-diesuo\":数值,\"rufeng-sibi\":数值,\"kunling-suoxin\":数值,\"jiru-xinghuo\":数值,\"xingchi-dianzou\":数值,\"dianguang-shihuo\":数值,\"feiyun-zhidian\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				if (门派 == 5 && 新旧 == 1)
				{
					text6 += (((num2 >= 100) ? "\"luotu-feiyan\":数值,\"tumo-chenmai\":数值,\"shanbeng-dilie\":数值,\"tianta-dixian\":数值,\"shipo-tianjing\":数值,\"youxin-wuli\":数值,\"guci-shibi\":数值,\"liushen-wuzhu\":数值,\"dishu-qipo\":数值,\"tianding-sanhun\":数值,\"bianchang-moji\":数值,\"wangfeng-puying\":数值,\"huaxian-weiyi\":数值,\"bishi-jiuxu\":数值,\"yixing-huanying\":数值,\"feisha-zoushi\":数值,\"kaibei-lieshi\":数值,\"xinru-panshi\":数值,\"diwo-nanfen\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"luotu-feiyan\":数值,\"tumo-chenmai\":数值,\"shanbeng-dilie\":数值,\"tianta-dixian\":数值,\"youxin-wuli\":数值,\"guci-shibi\":数值,\"liushen-wuzhu\":数值,\"dishu-qipo\":数值,\"bianchang-moji\":数值,\"wangfeng-puying\":数值,\"huaxian-weiyi\":数值,\"bishi-jiuxu\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				else if (门派 == 5 && 新旧 == 2)
				{
					text6 += (((num2 >= 100) ? "\"tubeng-wajie\":数值,\"chentu-feiyang\":数值,\"yangli-feisha\":数值,\"didong-shanyao\":数值,\"qianyan-wanhe\":数值,\"jinghuang-shicuo\":数值,\"ranshen-luanzhi\":数值,\"shenhun-piaodang\":数值,\"shenyao-yiduo\":数值,\"jingshen-podan\":数值,\"xuxu-shishi\":数值,\"gunong-xuanxu\":数值,\"konghuan-xushi\":数值,\"xukong-huanying\":数值,\"xuwu-piaomiao\":数值,\"feisha-zoushi\":数值,\"kaibei-lieshi\":数值,\"xinru-panshi\":数值,\"diwo-nanfen\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"tubeng-wajie\":数值,\"chentu-feiyang\":数值,\"yangli-feisha\":数值,\"didong-shanyao\":数值,\"jinghuang-shicuo\":数值,\"ranshen-luanzhi\":数值,\"shenhun-piaodang\":数值,\"shenyao-yiduo\":数值,\"xuxu-shishi\":数值,\"gunong-xuanxu\":数值,\"konghuan-xushi\":数值,\"xukong-huanying\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				if (num2 >= 130)
				{
					text6 += text7;
				}
			}
			if (num2 < 100)
			{
				text8 = "([\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([\"wood\":0,\"resist_lost\":0,\"durability\":100,\"life\":105,\"cash\":游戏金币,\"pot\":角色潜能,\"religion\":新老角色转换,\"type\":1,\"resist_wood\":0,\"friend_converted\":3,\"con\":角色等级,\"earth\":0,\"reputation\":0,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1569479697,\"resist_poison\":0,\"voucher\":游戏代金卷,\"last_login_time\":1569481420,\"resisit_wood\":0,\"dex\":角色等级,\"store_converted\":1,\"energy\":1500,\"polar\":角色五行相性,\"block_state\":0,\"polar_wood\":0,\"create_time\":1569479696,\"generate_time\":必需替换的时间戳,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"last_login_ip\":\"\",\"resist_metal\":0,\"phy_power\":45,\"anticheater_info\":([\"total_steps\":4,\"interval\":1739,\"last_move_time\":1569481420,]),\"recover_energy_time\":1569481307,\"has_trade_goods\":0,\"max_cash\":21015,\"today_played_time\":12,\"balance\":0,\"fire\":0,\"task\":([243:([\"state\":\"b\",\"ver\":1,]),1000:([\"state\":\"0\",\"ti\":1574665420,\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),644:([\"state\":\"0\",\"upgrade_type\":0,]),614:([\"state\":\"1\",\"st\":1569481200,]),1091:([\"et\":1569772799,\"total\":480,]),1087:([\"ti\":1569481420,\"exp\":2875162,\"tao\":102813,]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1061:([\"et\":1569772799,\"total\":120,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1569427199,\"upgrade_type\":0,]),]),\"title_type_effect\":\"无显示\",\"newbie\":1,\"age\":0,\"resist_lock\":0,\"speed\":226,\"init_basic_info\":1,\"mana\":10000,\"water\":0,\"signature\":\"\",\"name\":\"玩家角色名称\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"protect_bonus\":([\"ti\":1569481420,\"hour\":0,]),\"double_balance\":2,\"attrib_point\":角色属性点,\"resist_fire\":0,\"level\":角色等级,\"resist_frozen\":0,\"max_life\":8154,\"unique_data\":([0:536870912,5:16,2:64,1:67584,]),\"max_mana\":5498,\"tao\":道行,\"soul_cob_rate\":0,\"portrait\":角色图片代码,\"account\":\"角色游戏帐号\",\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1569479698,\"ytd\":([]),\"td\":([\"0\":1569481385,\"4\":500,\"2\":100,\"3\":0,]),]),\"last_login_mac\":\"\",\"resist_earth\":0,\"last_privilege\":300,\"question\":([\"answer_times\":0,]),\"gender\":角色性别,\"max_stamina\":188,\"last_logout_time\":必需替换的时间戳,\"settings\":([\"convert\":1,]),\"polar_water\":0,\"exp_to_next_level\":475592,\"polar_earth\":0,\"gold_coin\":金元宝数量,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1569481420,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"pker\":0,\"resist_forgotten\":0,\"task_round\":([\"962\":0,]),\"cur_ver\":17,\"metal\":0,\"str\":角色等级,\"total_pk\":0,\"wiz\":角色等级,\"max_balance\":45690,\"stamina\":100,\"salary\":([\"online_time\":([\"1569772800\":1738,]),]),\"def\":465,\"polar_fire\":0,\"icon\":角色图片代码,\"max_durability\":100,\"resisit_fire\":0,\"tao_ex\":0,\"resist_repress\":0,\"previous_login_ip\":\"\",\"appellation_ids\":([7:33554432,]),\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"resist_melt\":0,\"mag_power\":485,\"limit_trade_coin\":0,\"title_type\":\"无显示\",\"total_played_time\":1739,\"newbie\":1,\"dodge\":0,\"resist_confusion\":0,\"top_data\":([\"speed\":226,\"def\":465,\"phy_power\":485,\"mag_power\":485,]),\"resisit_water\":0,\"resist_sleep\":0,\"gid\":\"角色GID\",\"first_login_ip\":\"\",\"user_converted\":7,\"max_assign_polar\":30,\"silver_coin\":银元宝数量,\"limit_per_month\":([\"ti\":1569481385,\"11\":1,\"7\":100,\"8\":0,]),\"title_effect\":\"\",\"title\":\"初始称号\",\"polar_point\":58,\"resist_water\":0,\"resisit_metal\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"\",\"max_account_lv\":角色等级,\"wudou\":([\"last_cost_time\":1569168000,]),\"polar_metal\":0,\"logout_time\":必需替换的时间戳,\"exp\":0,\"newbie_gift\":1,\"limit_per_day\":([\"ti\":1569481313,\"93\":1,\"777\":1,\"895\":100,\"783\":1,]),\"scroll\":([\"time\":1569481408,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"insider_time\":315360000,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"\",({76,0,1,}),({37,0,1,}),({57,0,1,}),({41,0,1,}),({33,0,1,}),}),}),\"skills_map\":([]),\"skills\":([\"jingying-zhidao\":1,技能]),])";
			}
			else if (num2 >= 100 && num2 < 110)
			{
				text8 = "([\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([\"wood\":0,\"resist_lost\":0,\"durability\":100,\"life\":10000,\"cash\":游戏金币,\"pot\":角色潜能,\"religion\":新老角色转换,\"type\":1,\"resist_wood\":0,\"master\":\"角色二代祖师\",\"friend_converted\":3,\"con\":角色等级,\"earth\":0,\"reputation\":0,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1569479697,\"resist_poison\":0,\"voucher\":游戏代金卷,\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1569481420,\"resisit_wood\":0,\"dex\":角色等级,\"store_converted\":1,\"energy\":1500,\"polar\":角色五行相性,\"block_state\":0,\"polar_wood\":0,\"create_time\":1569479696,\"generate_time\":必需替换的时间戳,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"last_login_ip\":\"\",\"resist_metal\":0,\"phy_power\":485,\"anticheater_info\":([\"total_steps\":4,\"interval\":1739,\"last_move_time\":1569481420,]),\"recover_energy_time\":1569481307,\"has_trade_goods\":0,\"max_cash\":42030,\"today_played_time\":1739,\"balance\":0,\"fire\":0,\"task\":([243:([\"state\":\"b\",\"ver\":1,]),48:([\"end_time\":1829279214,]),1000:([\"state\":\"0\",\"ti\":1574665420,\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),644:([\"state\":\"0\",\"upgrade_type\":0,]),614:([\"state\":\"1\",\"st\":1569481200,]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"角色GID\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"玩家角色名称\",]),]),]),1091:([\"et\":1569772799,\"total\":480,]),1087:([\"ti\":1569481420,\"exp\":2875162,\"tao\":102813,]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1061:([\"et\":1569772799,\"total\":120,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1569427199,\"upgrade_type\":0,]),]),\"title_type_effect\":\"无显示\",\"age\":0,\"resist_lock\":0,\"speed\":226,\"init_basic_info\":1,\"mana\":10000,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"signature\":\"\",\"name\":\"玩家角色名称\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第二代弟子\",\"protect_bonus\":([\"ti\":1569481420,\"hour\":0,]),\"double_balance\":2,\"attrib_point\":角色属性点,\"resist_fire\":0,\"level\":角色等级,\"resist_frozen\":0,\"max_life\":8154,\"unique_data\":([0:536870912,5:16,2:64,1:67584,]),\"max_mana\":5498,\"tao\":道行,\"soul_cob_rate\":0,\"appellation\":([\"family\":\"角色一代弟子称号\",\"无显示\":\"\",]),\"portrait\":角色图片代码,\"account\":\"角色游戏帐号\",\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1569479698,\"ytd\":([]),\"td\":([\"0\":1569481385,\"4\":500,\"2\":100,\"3\":0,]),]),\"last_login_mac\":\"\",\"resist_earth\":0,\"last_privilege\":300,\"question\":([\"answer_times\":0,]),\"gender\":角色性别,\"max_stamina\":188,\"last_logout_time\":必需替换的时间戳,\"settings\":([\"convert\":1,]),\"polar_water\":0,\"exp_to_next_level\":475592,\"polar_earth\":0,\"gold_coin\":金元宝数量,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1569481420,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"pker\":0,\"resist_forgotten\":0,\"task_round\":([\"962\":0,]),\"cur_ver\":17,\"metal\":0,\"str\":角色等级,\"total_pk\":0,\"wiz\":角色等级,\"max_balance\":45690,\"stamina\":100,\"salary\":([\"online_time\":([\"1569772800\":1738,]),]),\"def\":465,\"polar_fire\":0,\"icon\":角色图片代码,\"max_durability\":100,\"resisit_fire\":0,\"tao_ex\":0,\"resist_repress\":0,\"previous_login_ip\":\"\",\"appellation_ids\":([7:33554432,4:32,]),\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"resist_melt\":0,\"mag_power\":485,\"limit_trade_coin\":0,\"title_type\":\"无显示\",\"total_played_time\":1739,\"newbie\":1,\"dodge\":0,\"resist_confusion\":0,\"top_data\":([\"speed\":226,\"def\":465,\"phy_power\":485,\"mag_power\":485,]),\"resisit_water\":0,\"resist_sleep\":0,\"gid\":\"角色GID\",\"first_login_ip\":\"\",\"user_converted\":7,\"max_assign_polar\":30,\"silver_coin\":银元宝数量,\"limit_per_month\":([\"ti\":1569481385,\"11\":1,\"7\":100,\"8\":0,]),\"title_effect\":\"\",\"family\":\"山门\",\"title\":\"初始称号\",\"polar_point\":58,\"resist_water\":0,\"resisit_metal\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"\",\"max_account_lv\":角色等级,\"wudou\":([\"last_cost_time\":1569168000,]),\"polar_metal\":0,\"logout_time\":必需替换的时间戳,\"exp\":0,\"newbie_gift\":1,\"limit_per_day\":([\"ti\":1569481313,\"93\":1,\"777\":1,\"895\":100,\"783\":1,]),\"scroll\":([\"time\":1569481408,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"insider_time\":315360000,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"\",({76,0,1,}),({37,0,1,}),({57,0,1,}),({41,0,1,}),({33,0,1,}),}),}),\"skills_map\":([]),\"skills\":([\"盾术\":1,\"jingying-zhidao\":1,技能]),])";
			}
			else if (num2 >= 110 && num2 < 134)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"dijie_finish10\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"dijie_finish10\",\"finished_time\":([\"dijie_finish10\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":10,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":40,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"dijie_finish\":\"夜长梦多\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":10,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"dijie_finish\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			else if (num2 >= 134 && num2 < 139)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie1\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie2\",\"finished_time\":([\"tianjie1\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":11,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":41,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"regal\":100,\"appellation\":([\"family\":\"%s\",\"tianjie\":\"一劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":11,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			else if (num2 >= 139 && num2 < 144)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie2\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie3\",\"finished_time\":([\"tianjie2\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":12,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":42,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"二劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":12,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			else if (num2 >= 144 && num2 < 149)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie3\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie4\",\"finished_time\":([\"tianjie3\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":13,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":43,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"三劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":13,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			else if (num2 >= 149 && num2 < 154)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie4\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie5\",\"finished_time\":([\"tianjie4\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":14,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":44,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"四劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":14,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			else if (num2 >= 154 && num2 < 159)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie5\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie6\",\"finished_time\":([\"tianjie5\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":15,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":45,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"五劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":15,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			else if (num2 >= 159)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":242,\"y\":194,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie7\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie8\",\"finished_time\":([\"tianjie7\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":17,\"str\":165,\"total_pk\":0,\"wiz\":165,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":47,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":165,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":165,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":165,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"七劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":17,\"bonus\":1,\"max_level\":165,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":165,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			text8 = text8.Replace("元神合体替换", Singleton<全局变量类>.I.网关Config.Is元神合体 ? "\"finish_ysht\":1,\"backup_attrib_plan\":([\"wood\":0,\"attrib_already\":([\"total\":0,\"wiz\":0,]),\"earth\":0,\"water\":0,\"polar_point\":0,\"upgrade_magic\":0,\"upgrade_immortal\":0,\"fire\":0,\"attrib_point\":0,\"cur_attrib_plan\":2,\"metal\":0,\"upgrade\":([\"dex\":0,\"attrib_point\":0,\"con\":0,\"str\":0,\"wiz\":0,]),]),\"cur_attrib_plan\":1," : "");
			if (问道数据类.出生地图列表.TryGetValue(Singleton<全局变量类>.I.网关Config.出生地图, out string value))
			{
				text8 = text8.Replace("出生地图", value);
			}
			text8 = text8.Replace("出生坐标X", Singleton<全局变量类>.I.网关Config.出生坐标.Split(",")[0]);
			text8 = text8.Replace("出生坐标Y", Singleton<全局变量类>.I.网关Config.出生坐标.Split(",")[1]);
			text8 = text8.Replace("大飞|有你刚好", Singleton<全局变量类>.I.网关Config.送称号);
			if (num2 < 110)
			{
				text8 = text8.Replace("游戏金币", Singleton<全局变量类>.I.网关Config.送金钱.ToString());
				text8 = text8.Replace("角色潜能", Singleton<全局变量类>.I.网关Config.送潜能.ToString());
				text8 = text8.Replace("新老角色转换", 新旧.ToString());
				text8 = text8.Replace("角色等级", num2.ToString());
				text8 = text8.Replace("游戏代金卷", Singleton<全局变量类>.I.网关Config.送代金.ToString());
				text8 = text8.Replace("必需替换的时间戳", 问道数据类.GetTimeChuo(bflag: true));
				text8 = text8.Replace("角色二代祖师", text5);
				text8 = text8.Replace("角色五行相性", 门派.ToString());
				text8 = text8.Replace("玩家角色名称", 昵称);
				text8 = text8.Replace("山门", text3);
				text8 = text8.Replace("角色属性点", (num2 * 4 - 4).ToString());
				text8 = text8.Replace("道行", (Singleton<全局变量类>.I.网关Config.送道行 * 360).ToString());
				text8 = text8.Replace("角色一代弟子称号", (num2 <= 10) ? string.Empty : (text3 + "第二代弟子"));
				text8 = text8.Replace("角色图片代码", icons);
				text8 = text8.Replace("角色游戏帐号", 账号);
				text8 = text8.Replace("角色性别", 性别.ToString());
				text8 = text8.Replace("金元宝数量", Singleton<全局变量类>.I.网关Config.送金元宝.ToString());
				text8 = text8.Replace("角色GID", text9);
				text8 = text8.Replace("银元宝数量", Singleton<全局变量类>.I.网关Config.送银元宝.ToString());
				text8 = text8.Replace("初始称号", Singleton<全局变量类>.I.网关Config.送称号);
				text8 = text8.Replace("技能", text6);
				text8 = text8.Replace("盾术", text4);
			}
			else
			{
				num2 = 等级;
				string[] infos = new string[23]
				{
					text2,
					num2.ToString(),
					text2,
					新旧.ToString(),
					Singleton<全局变量类>.I.网关Config.送代金.ToString(),
					门派.ToString(),
					text9,
					安全码,
					(Singleton<全局变量类>.I.网关Config.送道行 * 360).ToString(),
					icons,
					账号,
					性别.ToString(),
					icons,
					text3,
					Singleton<全局变量类>.I.网关Config.送金钱.ToString(),
					Singleton<全局变量类>.I.网关Config.送潜能.ToString(),
					text5,
					num2.ToString(),
					text3 + "第一代弟子",
					仙魔.ToString(),
					text9,
					text4,
					text6
				};
				text8 = 问道数据类.GetStringRe(text8, "%s", infos);
				text8 = text8.Replace("修道点", num3.ToString());
			}
			int dataChecksum = GetDataChecksum("user" + text9 + text8);
			num = c1ZNsjqlRc(mySqlConnection, string.Format("INSERT INTO dl_ddb_1.data(path,name,branch,content,checksum) VALUES('user','{0}','','{1}','{2}')", text9, text8, dataChecksum));
			if (num < 0)
			{
				Log.Error("角色数据生成失败！");
				回调事件?.Invoke(arg1: false, "角色数据生成失败，请稍后重试！");
				return;
			}
			Log.Debug("角色数据生成成功！");
			dataChecksum = GetDataChecksum("user" + text9 + "achieve([90102:([5:294,4:1557680413,]),60413:([5:0,4:1557680404,]),60414:([5:0,4:1557680404,]),60415:([5:0,4:1557680404,]),70113:([4:1557596605,3:1,]),\"update_ti\":1557677100,10201:([1:1,]),70110:([4:1557596608,3:1,]),\"ver\":2,30169:([1:1,]),10703:([5:0,4:1557596587,]),10702:([5:0,4:1557596587,]),10701:([5:0,4:1557596587,]),30134:([1:1,]),20406:([1:1,]),20407:([5:3,4:1557608768,7:([\"ti\":3486,]),]),30122:([5:1,4:1557611645,]),30121:([1:1,]),51101:([5:5,4:1557677789,7:([\"ti\":216,]),]),51103:([5:0,4:1557596587,]),51102:([5:0,4:1557596587,]),30101:([1:1,]),30107:([1:1,]),\"total\":155,90401:([1:1,]),10505:([5:0,4:1557680404,]),10506:([5:0,4:1557680404,]),40206:([5:0,4:1557680404,7:([]),]),90336:([1:1,]),50403:([1:1,]),50910:([1:1,4:1557596688,]),50909:([1:1,]),90331:([1:1,]),90308:([5:47,4:1557675755,]),90307:([1:1,]),60102:([5:1,4:1557675613,]),60101:([1:1,]),90316:([5:1,4:1557606398,]),90315:([1:1,]),90313:([1:1,]),90314:([5:9,4:1557607101,]),90301:([1:1,]),40105:([5:0,4:1557680404,]),40106:([5:0,4:1557680404,]),\"traces\":({}),20113:([5:0,4:1557610503,]),20114:([5:0,4:1557610503,]),20110:([5:0,4:1557609711,]),20106:([5:0,4:1557610503,]),20102:([5:0,4:1557610503,]),20103:([5:0,4:1557610503,]),20104:([5:0,4:1557610503,]),20101:([1:1,]),90208:([5:1,4:1557605766,]),90215:([1:1,]),90217:([1:1,]),90216:([1:1,]),90218:([1:1,]),90207:([1:1,]),\"lastest\":({90307,10201,60101,}),80404:([5:0,4:1557680404,]),80405:([5:0,4:1557680404,]),80406:([5:0,4:1557680404,]),])");
			num = c1ZNsjqlRc(mySqlConnection, string.Format("INSERT INTO dl_ddb_1.data(path,name,branch,content,checksum) VALUES('user','{0}','achieve','{1}','{2}')", text9, "([90102:([5:294,4:1557680413,]),60413:([5:0,4:1557680404,]),60414:([5:0,4:1557680404,]),60415:([5:0,4:1557680404,]),70113:([4:1557596605,3:1,]),\"update_ti\":1557677100,10201:([1:1,]),70110:([4:1557596608,3:1,]),\"ver\":2,30169:([1:1,]),10703:([5:0,4:1557596587,]),10702:([5:0,4:1557596587,]),10701:([5:0,4:1557596587,]),30134:([1:1,]),20406:([1:1,]),20407:([5:3,4:1557608768,7:([\"ti\":3486,]),]),30122:([5:1,4:1557611645,]),30121:([1:1,]),51101:([5:5,4:1557677789,7:([\"ti\":216,]),]),51103:([5:0,4:1557596587,]),51102:([5:0,4:1557596587,]),30101:([1:1,]),30107:([1:1,]),\"total\":155,90401:([1:1,]),10505:([5:0,4:1557680404,]),10506:([5:0,4:1557680404,]),40206:([5:0,4:1557680404,7:([]),]),90336:([1:1,]),50403:([1:1,]),50910:([1:1,4:1557596688,]),50909:([1:1,]),90331:([1:1,]),90308:([5:47,4:1557675755,]),90307:([1:1,]),60102:([5:1,4:1557675613,]),60101:([1:1,]),90316:([5:1,4:1557606398,]),90315:([1:1,]),90313:([1:1,]),90314:([5:9,4:1557607101,]),90301:([1:1,]),40105:([5:0,4:1557680404,]),40106:([5:0,4:1557680404,]),\"traces\":({}),20113:([5:0,4:1557610503,]),20114:([5:0,4:1557610503,]),20110:([5:0,4:1557609711,]),20106:([5:0,4:1557610503,]),20102:([5:0,4:1557610503,]),20103:([5:0,4:1557610503,]),20104:([5:0,4:1557610503,]),20101:([1:1,]),90208:([5:1,4:1557605766,]),90215:([1:1,]),90217:([1:1,]),90216:([1:1,]),90218:([1:1,]),90207:([1:1,]),\"lastest\":({90307,10201,60101,}),80404:([5:0,4:1557680404,]),80405:([5:0,4:1557680404,]),80406:([5:0,4:1557680404,]),])", dataChecksum));
			if (num < 0)
			{
				Log.Error("角色GID数据生成失败！");
				回调事件?.Invoke(arg1: false, "角色GID数据生成失败，请稍后重试！");
				return;
			}
			Log.Debug("角色GID数据生成成功！");
			string text10 = "";
			string text11 = "";
			string text12 = "";
			string text13 = "";
			if (Singleton<全局变量类>.I.网关Config.赠送道具 && !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.网关Config.赠送道具名字) && Singleton<全局变量类>.I.网关Config.道具数量 > 0)
			{
				try
				{
					for (int num5 = 1; num5 <= Singleton<全局变量类>.I.网关Config.道具数量; num5++)
					{
						string[] infos2 = new string[6]
						{
							(100 + num5).ToString(),
							Singleton<全局变量类>.I.网关Config.赠送道具名字,
							(100 + num5).ToString(),
							Singleton<全局变量类>.I.网关Config.道具数量.ToString(),
							"1",
							Singleton<全局变量类>.I.网关Config.道具绑定.ToString()
						};
						string stringRe = 问道数据类.GetStringRe("%s:\"%s:([255:36,232:%s,47:%s,35:%s,\\\"type\\\":8,257:([48:%s,]),])\",", "%s", infos2);
						text10 += stringRe;
					}
					text10 = "([\"carry\":([道具]),])".Replace("道具", text10);
				}
				catch (Exception)
				{
					text10 = "([\"carry\":([道具]),])";
					text10 = text10.Replace("道具", "");
				}
			}
			else
			{
				text10 = "([\"carry\":([道具]),])";
				text10 = text10.Replace("道具", "");
			}
			dataChecksum = GetDataChecksum("user" + text9 + "carry" + text10);
			num = c1ZNsjqlRc(mySqlConnection, string.Format("INSERT INTO dl_ddb_1.data(path,name,branch,content,checksum)  VALUES('user','{0}','carry','{1}','{2}')", text9, text10.Replace("\\", "\\\\"), dataChecksum));
			if (num < 0)
			{
				Log.Error("角色背包数据生成失败！");
				回调事件?.Invoke(arg1: false, "角色背包数据生成失败，请稍后重试！");
				return;
			}
			if (Singleton<全局变量类>.I.网关Config.Is送娃娃)
			{
				int num6 = num2 * 4 - 4;
				string text14 = string.Format("{0:X08}", result + 10101);
				text11 = "1:\"娃娃:1:0:0::%s:\",".Replace("%s", text14);
				string text15 = ":" + text14 + ":";
				string value2 = "([\"carry\":([]),\"attrib\":([\"food\":10000,\"mood\":10000,\"refresh_stamina_time\":1568464012,\"gender\":2,\"status\":0,\"life\":23962,\"attack_speed\":4,\"combat_mode\":7,\"max_stamina\":200,\"pot\":0,\"max_mood\":10000,\"phy_effect\":100,\"exp_to_next_level\":0,\"level_up_time\":1560364099,\"str\":%s,\"max_food\":10000,\"stamina\":200,\"dex\":%s,\"def\":2604,\"icon\":7015,\"max_limit_level\":165,\"lock_exp\":0,\"repair_ver\":6,\"intimacy\":%s,\"phy_power\":7326,\"capacity\":%s,\"mag_power\":7328,\"train_process\":0,\"str_effect\":100,\"birthday\":%s,\"dodge\":11,\"iid\"::%s:,\"rank\":6,\"physique\":%s,\"wisdom\":%s,\"wit_effect\":100,\"mana\":1000,\"use_skill\":([]),\"name\":\"[名字]娃娃\",\"parents\":({\"%s\",}),\"level\":%s,\"max_life\":23962,\"stamina_effect\":100,\"dex_effect\":100,\"exp\":0,\"max_mana\":0,\"health\":0,\"portrait\":7015,]),\"skills\":([]),])".Replace("[名字]", 昵称 + "的");
				string[] infos3 = new string[10]
				{
					num2.ToString(),
					num2.ToString(),
					Singleton<全局变量类>.I.网关Config.娃娃亲密.ToString(),
					num6.ToString(),
					问道数据类.GetTimeChuo(bflag: true),
					text14,
					num2.ToString(),
					num2.ToString(),
					text9,
					num2.ToString()
				};
				value2 = 问道数据类.GetStringRe(value2, "%s", infos3);
				dataChecksum = GetDataChecksum("child" + text15 + value2);
				num = c1ZNsjqlRc(mySqlConnection, string.Format("INSERT INTO dl_ddb_1.data(path,name,branch,content,checksum)  VALUES('child','{0}','','{1}','{2}')", text15, value2, dataChecksum));
				if (num < 0)
				{
					Log.Error("角色娃娃数据生成失败！");
					回调事件?.Invoke(arg1: false, "角色娃娃数据生成失败，请稍后重试！");
					return;
				}
			}
			if (Singleton<全局变量类>.I.网关Config.Is送守护)
			{
				text12 = "0:\"0:([\\\"attrib\\\":([106:2,107:12409,108:91954,104:2,76:5,72:5004,68:1302716,67:%s,66:6171,64:0,75:34,71:20,69:6100,53:0,52:110,51:34277,49:495,48:236555,63:165,62:4,61:5004,60:0,58:0,57:0,56:0,55:2,47:0,44:165,37:34277,36:2171,35:5,33::%s:,22:30868,21:59039,16:18921,31:190,5:420,3:360,2:236555,]),])\",";
				string text16 = "5D77E13A0002" + string.Format("{0:X08}", result);
				string[] infos4 = new string[2]
				{
					Singleton<全局变量类>.I.网关Config.守护亲密.ToString(),
					text16
				};
				text12 = 问道数据类.GetStringRe(text12, "%s", infos4);
			}
			text13 = "([\"pets\":([宠物]),\"guards\":([%s]),\"friends\":([\"5\":([]),\"4\":([]),\"3\":([]),\"2\":([]),\"1\":([]),\"6\":([]),]),\"children\":([%s]),\"practice_children\":([]),\"practice_pets\":([]),])";
			string[] infos5 = new string[2] { text12, text11 };
			text13 = 问道数据类.GetStringRe(text13, "%s", infos5).Replace("宠物", "");
			dataChecksum = GetDataChecksum("user" + text9 + "patch" + text13);
			num = c1ZNsjqlRc(mySqlConnection, string.Format("INSERT INTO dl_ddb_1.data(path,name,branch,content,checksum) VALUES('user','{0}','patch','{1}','{2}')", text9, text13.Replace("\\", "\\\\"), dataChecksum));
			if (num < 0)
			{
				Log.Error("角色宠物数据生成失败！");
				回调事件?.Invoke(arg1: false, "角色宠物数据生成失败，请稍后重试！");
				return;
			}
			string text17 = "([\"rec_role\":\"%s\",\"create_time\":1556371353,\"chars\":({\"%s\",}),\"safe_status\":0,\"register_time\":0,])";
			text17 = text17.Replace("%s", text9);
			dataChecksum = GetDataChecksum("login" + 账号 + text17);
			num = c1ZNsjqlRc(mySqlConnection, string.Format("INSERT INTO dl_ddb_1.data(path,name,branch,content,checksum)  VALUES('login','{0}','','{1}','{2}')", 账号, text17, dataChecksum));
			if (num < 0)
			{
				Log.Error("角色登录数据生成失败！");
				回调事件?.Invoke(arg1: false, "角色登录数据生成失败，请稍后重试！");
				return;
			}
			注册信息 obj = new 注册信息
			{
				账号 = 账号,
				密码 = 密码,
				安全码 = 安全码,
				注册验证码 = 注册验证码,
				名字 = 昵称,
				等级 = 等级,
				IP = IP,
				Mac = CS_0024_003C_003E8__locals15.HTa73kU9IY,
				qq = CS_0024_003C_003E8__locals15.T7G7Y7tfPQ
			};
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			obj.注册时间 = defaultInterpolatedStringHandler.ToStringAndClear();
			注册信息 item = obj;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(127, 10);
			defaultInterpolatedStringHandler.AppendLiteral("INSERT INTO dl_adb_all.yjzcxx(account,pass,aqpass,yzm,zcname,zclv,zcip,zcmac,zcqq,zctime) VALUES('");
			defaultInterpolatedStringHandler.AppendFormatted(账号);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(密码);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(安全码);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(注册验证码);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(昵称);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(num2);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(IP);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals15.HTa73kU9IY);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals15.T7G7Y7tfPQ);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("')");
			num = c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
			if (num < 0)
			{
				Log.Error("角色完整数据生成失败！");
				回调事件?.Invoke(arg1: false, "角色完整数据生成失败，请稍后重试！");
				return;
			}
			回调事件?.Invoke(num > 0, (num > 0) ? "注册成功！" : "注册失败！");
			Singleton<全局变量类>.I.注册列表.Add(item);
			if (!Singleton<全局变量类>.I.角色存档表.ContainsKey(result))
			{
				角色存档数据类 角色存档数据类2 = Singleton<接收数据响应处理类>.I.初始创建角色存档(result, 昵称, 账号);
				角色存档数据类2.账号注册QQ = CS_0024_003C_003E8__locals15.T7G7Y7tfPQ;
				角色存档数据类2.点卡存档.当前点数 = Singleton<全局变量类>.I.config.点卡配置.注册赠送点数;
				Singleton<全局变量类>.I.角色存档表.TryAdd(result, 角色存档数据类2);
			}
			if (!string.IsNullOrWhiteSpace(CS_0024_003C_003E8__locals15.T7G7Y7tfPQ))
			{
				Singleton<全局变量类>.I.验证client.CunDangClientQq(CS_0024_003C_003E8__locals15.T7G7Y7tfPQ);
			}
		}
		catch (Exception ex2)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
			defaultInterpolatedStringHandler.AppendLiteral("网关注册账号事件错误：");
			defaultInterpolatedStringHandler.AppendFormatted(ex2.Message);
			defaultInterpolatedStringHandler.AppendLiteral("[");
			defaultInterpolatedStringHandler.AppendFormatted(ex2.StackTrace);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			回调事件?.Invoke(arg1: false, "注册出现异常，请稍后重试！");
		}
	}

	
	public void 创建注册存档数据(注册信息 信息)
	{
		using MySqlConnection mySqlConnection = new MySqlConnection(allsql);
		_ = string.Empty;
		mySqlConnection.Open();
		if (mySqlConnection.State != ConnectionState.Open)
		{
			Log.Error("创建注册存档数据-mysql数据库连接失败！");
			return;
		}
		o51NJkPfKI(mySqlConnection);
		using (new MySqlCommand())
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(127, 10);
			defaultInterpolatedStringHandler.AppendLiteral("INSERT INTO dl_adb_all.yjzcxx(account,pass,aqpass,yzm,zcname,zclv,zcip,zcmac,zcqq,zctime) VALUES('");
			defaultInterpolatedStringHandler.AppendFormatted(信息.账号);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(信息.密码);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(信息.安全码);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(信息.注册验证码);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(信息.名字);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(信息.等级);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(信息.IP);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(信息.Mac);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(信息.qq);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(信息.注册时间);
			defaultInterpolatedStringHandler.AppendLiteral("')");
			if (c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear()) < 0)
			{
				Log.Error("角色完整数据生成失败！");
			}
		}
	}

	
	public void 后台注册GM账号事件(string 账号, string 密码, string 安全码, string 昵称, int 新旧, int 性别, int 门派, int 仙魔, int 等级, Action<string> 回调事件 = null)
	{
		try
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 9);
			defaultInterpolatedStringHandler.AppendLiteral("后台注册：账号=");
			defaultInterpolatedStringHandler.AppendFormatted(账号);
			defaultInterpolatedStringHandler.AppendLiteral(", 密码=");
			defaultInterpolatedStringHandler.AppendFormatted(密码);
			defaultInterpolatedStringHandler.AppendLiteral(", 安全码=");
			defaultInterpolatedStringHandler.AppendFormatted(安全码);
			defaultInterpolatedStringHandler.AppendLiteral(", 昵称=");
			defaultInterpolatedStringHandler.AppendFormatted(昵称);
			defaultInterpolatedStringHandler.AppendLiteral(", 新旧=");
			defaultInterpolatedStringHandler.AppendFormatted(新旧);
			defaultInterpolatedStringHandler.AppendLiteral(", 性别=");
			defaultInterpolatedStringHandler.AppendFormatted(性别);
			defaultInterpolatedStringHandler.AppendLiteral(", 门派=");
			defaultInterpolatedStringHandler.AppendFormatted(门派);
			defaultInterpolatedStringHandler.AppendLiteral(", 仙魔=");
			defaultInterpolatedStringHandler.AppendFormatted(仙魔);
			defaultInterpolatedStringHandler.AppendLiteral(", 等级=");
			defaultInterpolatedStringHandler.AppendFormatted(等级);
			Log.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			using MySqlConnection mySqlConnection = new MySqlConnection(allsql);
			_ = string.Empty;
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("网关注册账号事件-mysql数据库连接失败！");
				回调事件?.Invoke("数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			if (!string.IsNullOrWhiteSpace(账号))
			{
				using MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = mySqlConnection;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 2);
				defaultInterpolatedStringHandler.AppendLiteral("select account from ");
				defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.网关Config.数据库adb);
				defaultInterpolatedStringHandler.AppendLiteral(".account where account='");
				defaultInterpolatedStringHandler.AppendFormatted(账号);
				defaultInterpolatedStringHandler.AppendLiteral("'");
				mySqlCommand.CommandText = defaultInterpolatedStringHandler.ToStringAndClear();
				using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader == null)
				{
					return;
				}
				if (mySqlDataReader != null && mySqlDataReader.Read())
				{
					mySqlDataReader.Close();
					回调事件?.Invoke("账号已存在！");
					return;
				}
				mySqlDataReader.Close();
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler.AppendLiteral("道友ID：");
			defaultInterpolatedStringHandler.AppendFormatted(CYLidiqi5K());
			昵称 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (昵称 != "")
			{
				bool flag = false;
				using MySqlCommand mySqlCommand2 = new MySqlCommand();
				mySqlCommand2.Connection = mySqlConnection;
				while (!flag)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 2);
					defaultInterpolatedStringHandler.AppendLiteral("select name from ");
					defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.网关Config.数据库ddb);
					defaultInterpolatedStringHandler.AppendLiteral(".gid_info where name='");
					defaultInterpolatedStringHandler.AppendFormatted(昵称);
					defaultInterpolatedStringHandler.AppendLiteral("'");
					mySqlCommand2.CommandText = defaultInterpolatedStringHandler.ToStringAndClear();
					using (MySqlDataReader mySqlDataReader2 = mySqlCommand2.ExecuteReader())
					{
						if (mySqlDataReader2 != null && mySqlDataReader2.Read())
						{
							mySqlDataReader2.Close();
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
							defaultInterpolatedStringHandler.AppendLiteral("道友ID：");
							defaultInterpolatedStringHandler.AppendFormatted(CYLidiqi5K());
							昵称 = defaultInterpolatedStringHandler.ToStringAndClear();
							continue;
						}
						flag = true;
						mySqlDataReader2.Close();
					}
					break;
				}
			}
			string mD5Info = GetMD5Info(账号 + GetMD5Info(密码) + "20070201");
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(131, 8);
			defaultInterpolatedStringHandler.AppendLiteral("INSERT INTO ");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.config.adb表);
			defaultInterpolatedStringHandler.AppendLiteral(".account");
			defaultInterpolatedStringHandler.AppendLiteral("(account,password,gold_coin,silver_coin,checksum,memo,privilege,blocked_time)VALUES");
			defaultInterpolatedStringHandler.AppendLiteral("('");
			defaultInterpolatedStringHandler.AppendFormatted(账号);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(mD5Info);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.网关Config.送金元宝);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.网关Config.送银元宝);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted("");
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(安全码);
			defaultInterpolatedStringHandler.AppendLiteral("','300','");
			defaultInterpolatedStringHandler.AppendFormatted("");
			defaultInterpolatedStringHandler.AppendLiteral("')");
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			int num = c1ZNsjqlRc(mySqlConnection, text);
			if (num < 0)
			{
				Log.Error("账号注册数据插入失败！");
				回调事件?.Invoke("账号注册失败，请稍后重试！");
				return;
			}
			num = c1ZNsjqlRc(mySqlConnection, AccChecksum(账号, Singleton<全局变量类>.I.config.adb表 + "."));
			if (num <= -1)
			{
				return;
			}
			Singleton<GyJyg8g24jqCD31mjD6>.I.lScgXuebT5();
			int num2 = ((等级 < 139 && Singleton<全局变量类>.I.网关Config.Is注册1级大飞) ? 139 : 等级);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 3);
			defaultInterpolatedStringHandler.AppendLiteral("INSERT INTO ");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.网关Config.数据库ddb);
			defaultInterpolatedStringHandler.AppendLiteral(".gid_info VALUES(null,'user','");
			defaultInterpolatedStringHandler.AppendFormatted(昵称);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(string.Format("{0:yyyyMMddHHmmss}", DateTime.Now));
			defaultInterpolatedStringHandler.AppendLiteral("',null)");
			num = c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
			if (num < 0)
			{
				Log.Error("账号注册昵称数据插入失败！");
				回调事件?.Invoke("账号注册失败，请稍后重试！");
				return;
			}
			int result = 0;
			using MySqlCommand mySqlCommand3 = new MySqlCommand();
			mySqlCommand3.Connection = mySqlConnection;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 2);
			defaultInterpolatedStringHandler.AppendLiteral("select gid from ");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<全局变量类>.I.网关Config.数据库ddb);
			defaultInterpolatedStringHandler.AppendLiteral(".gid_info where name='");
			defaultInterpolatedStringHandler.AppendFormatted(昵称);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			mySqlCommand3.CommandText = defaultInterpolatedStringHandler.ToStringAndClear();
			using MySqlDataReader mySqlDataReader3 = mySqlCommand3.ExecuteReader();
			if (mySqlDataReader3.Read())
			{
				int.TryParse(mySqlDataReader3["gid"].ToString(), out result);
			}
			mySqlDataReader3.Close();
			if (result == 0)
			{
				Log.Error("账号注册昵称Gid数据插入失败！");
				回调事件?.Invoke("增加Gid失败！");
				return;
			}
			string text2 = ((性别 == 1) ? "7008" : "7009");
			string icons = 问道数据类.GetIcons(门派, 新旧, 性别);
			string text3 = $"{(AllEnums.门派Type)门派}";
			string text4 = 全局常量类.遁术技能[门派];
			string text5 = ((num2 >= 100) ? 全局常量类.一代师尊[门派] : 全局常量类.二代师尊[门派]);
			string text6 = "\"jiji-rulvling\":1,";
			string text7 = ((num2 < 100) ? "" : "\"liaodi-xianji\":等级,\"yulu-huanyuan\":等级,\"tianji-shenjia\":等级,\"wuxing-xiangsheng\":等级,\"yaowang-shending\":等级,\"wuxing-xiangfu\":等级,\"ruyou-shenzhu\":等级,\"lingli-zengfu\":等级,\"yiya-huanya\":等级,\"shixue-kuangluan\":等级,\"xieling-futi\":等级,\"shibu-kedang\":等级,\"dadao-lunhui\":等级,\"fali-wubian\":等级,\"tuiling-xuezhou\":等级,\"tianjiang-xiafan\":等级,\"houfa-zhiren\":等级,\"sanyuan-guiyi\":等级,\"duhua-chengkong\":等级,\"youchou-bibao\":等级,\"jingang-zhiqu\":等级,\"nujiao-lianzhan\":等级,\"kexue-qishu\":等级,\"gonggong-mieshi\":等级,\"jinshen-bumie\":等级,\"ruhuan-simeng\":等级,".Replace("等级", Singleton<全局变量类>.I.网关Config.引灵幡技能等级.ToString()));
			int num3 = 等级 - 130;
			string text8 = "";
			string text9 = string.Format("{0:X16}", result);
			int num4 = (((double)num2 * (Singleton<全局变量类>.I.网关Config.Is带技能精研 ? 2.0 : 1.5) > 330.0) ? 330 : ((int)((double)num2 * (Singleton<全局变量类>.I.网关Config.Is带技能精研 ? 2.0 : 1.5))));
			if (Singleton<全局变量类>.I.网关Config.Is带技能)
			{
				if (门派 == 1 && 新旧 == 1)
				{
					text6 += (((num2 >= 100) ? "\"jinguang-zhaxian\":数值,\"daoguang-jianying\":数值,\"jinhong-guanri\":数值,\"liuguang-yicai\":数值,\"nitian-canren\":数值,\"liulian-wangfan\":数值,\"deyi-wangxing\":数值,\"ruchi-ruzui\":数值,\"rumeng-chuxing\":数值,\"huangruo-geshi\":数值,\"tiansheng-shenli\":数值,\"qichong-douniu\":数值,\"jiuniu-erhu\":数值,\"ruhu-tianyi\":数值,\"liwan-kuanglan\":数值,\"jinbi-huihuang\":数值,\"zhidao-huanglong\":数值,\"jincheng-tangchi\":数值,\"jinfa-fenghun\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"jinguang-zhaxian\":数值,\"daoguang-jianying\":数值,\"jinhong-guanri\":数值,\"liuguang-yicai\":数值,\"liulian-wangfan\":数值,\"deyi-wangxing\":数值,\"ruchi-ruzui\":数值,\"rumeng-chuxing\":数值,\"tiansheng-shenli\":数值,\"qichong-douniu\":数值,\"jiuniu-erhu\":数值,\"ruhu-tianyi\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				else if (门派 == 1 && 新旧 == 2)
				{
					text6 += (((num2 >= 100) ? "\"dandao-zhiru\":数值,\"ruibu-kedang\":数值,\"qiandao-wanren\":数值,\"fengmang-bilou\":数值,\"wandao-jinguang\":数值,\"buzhi-suocuo\":数值,\"danzhan-xinjing\":数值,\"jinghun-weiding\":数值,\"zhenhun-suoxin\":数值,\"duoshen-shepo\":数值,\"quanli-yifu\":数值,\"qiguan-changhong\":数值,\"jianba-nuzhang\":数值,\"shiru-pozhu\":数值,\"lipi-xuanhuang\":数值,\"jinbi-huihuang\":数值,\"zhidao-huanglong\":数值,\"jincheng-tangchi\":数值,\"jinfa-fenghun\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"dandao-zhiru\":数值,\"ruibu-kedang\":数值,\"qiandao-wanren\":数值,\"fengmang-bilou\":数值,\"buzhi-suocuo\":数值,\"danzhan-xinjing\":数值,\"jinghun-weiding\":数值,\"zhenhun-suoxin\":数值,\"quanli-yifu\":数值,\"qiguan-changhong\":数值,\"jianba-nuzhang\":数值,\"shiru-pozhu\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				if (门派 == 2 && 新旧 == 1)
				{
					text6 += (((num2 >= 100) ? "\"zhaiye-feihua\":数值,\"feiliu-xianshi\":数值,\"pangen-cuojie\":数值,\"luoying-binfen\":数值,\"guiwu-kuteng\":数值,\"jianxie-fenghou\":数值,\"shekou-fengzhen\":数值,\"heding-hongfen\":数值,\"xiewei-shexian\":数值,\"wanyi-shixin\":数值,\"bamiao-zhuzhang\":数值,\"huoshang-jiaoyou\":数值,\"shuizhang-chuangao\":数值,\"honghua-lvye\":数值,\"jinshang-tianhua\":数值,\"luoye-xiaoxiao\":数值,\"manwu-feitian\":数值,\"baidu-buqin\":数值,\"judu-gongxin\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"zhaiye-feihua\":数值,\"feiliu-xianshi\":数值,\"pangen-cuojie\":数值,\"luoying-binfen\":数值,\"jianxie-fenghou\":数值,\"shekou-fengzhen\":数值,\"heding-hongfen\":数值,\"xiewei-shexian\":数值,\"bamiao-zhuzhang\":数值,\"huoshang-jiaoyou\":数值,\"shuizhang-chuangao\":数值,\"honghua-lvye\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				else if (门派 == 2 && 新旧 == 2)
				{
					text6 += (((num2 >= 100) ? "\"huawu-yefei\":数值,\"yanghua-feiliu\":数值,\"qiufeng-saoye\":数值,\"yiye-puti\":数值,\"tiannv-sanhua\":数值,\"mangci-zaibei\":数值,\"wufu-chongsheng\":数值,\"duru-gusui\":数值,\"jiusi-yisheng\":数值,\"zhetian-biri\":数值,\"ganzhi-ruyi\":数值,\"chunfeng-huayu\":数值,\"runwu-wusheng\":数值,\"tihu-guanding\":数值,\"miaoshou-huichun\":数值,\"luoye-xiaoxiao\":数值,\"manwu-feitian\":数值,\"baidu-buqin\":数值,\"judu-gongxin\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"huawu-yefei\":数值,\"yanghua-feiliu\":数值,\"qiufeng-saoye\":数值,\"yiye-puti\":数值,\"mangci-zaibei\":数值,\"wufu-chongsheng\":数值,\"duru-gusui\":数值,\"jiusi-yisheng\":数值,\"ganzhi-ruyi\":数值,\"chunfeng-huayu\":数值,\"runwu-wusheng\":数值,\"tihu-guanding\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				if (门派 == 3 && 新旧 == 1)
				{
					text6 += (((num2 >= 100) ? "\"dishui-chuanshi\":数值,\"yuhen-yunchou\":数值,\"xuanhe-xieshui\":数值,\"nubo-kuangtao\":数值,\"jiaohai-fanjiang\":数值,\"sanjiu-yanhan\":数值,\"tianhan-didong\":数值,\"bingdong-sanchi\":数值,\"jidi-binghan\":数值,\"baoluo-wanxiang\":数值,\"fangwei-dujian\":数值,\"tiegu-zhengzheng\":数值,\"binglai-jiangdang\":数值,\"tongqiang-tiebi\":数值,\"tiandi-hunyuan\":数值,\"shuitian-yise\":数值,\"tiema-binghe\":数值,\"shuangjia-bingdun\":数值,\"xuepiao-wanli\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"dishui-chuanshi\":数值,\"yuhen-yunchou\":数值,\"xuanhe-xieshui\":数值,\"nubo-kuangtao\":数值,\"sanjiu-yanhan\":数值,\"tianhan-didong\":数值,\"bingdong-sanchi\":数值,\"jidi-binghan\":数值,\"fangwei-dujian\":数值,\"tiegu-zhengzheng\":数值,\"binglai-jiangdang\":数值,\"tongqiang-tiebi\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				else if (门派 == 3 && 新旧 == 2)
				{
					text6 += (((num2 >= 100) ? "\"shuiliu-huaxie\":数值,\"jishui-chengyuan\":数值,\"fengqi-shuiyong\":数值,\"xueyao-bingtian\":数值,\"jiaolong-deshui\":数值,\"dishui-bulou\":数值,\"shengou-bilei\":数值,\"jixue-fengshuang\":数值,\"riyue-hebi\":数值,\"jinghua-shuiyue\":数值,\"tugu-naxin\":数值,\"fanghuan-weiran\":数值,\"hunran-yiti\":数值,\"yuxiao-yunsan\":数值,\"shuihuo-buqin\":数值,\"shuitian-yise\":数值,\"tiema-binghe\":数值,\"shuangjia-bingdun\":数值,\"xuepiao-wanli\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"shuiliu-huaxie\":数值,\"jishui-chengyuan\":数值,\"fengqi-shuiyong\":数值,\"xueyao-bingtian\":数值,\"dishui-bulou\":数值,\"shengou-bilei\":数值,\"jixue-fengshuang\":数值,\"riyue-hebi\":数值,\"tugu-naxin\":数值,\"fanghuan-weiran\":数值,\"hunran-yiti\":数值,\"yuxiao-yunsan\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				if (门派 == 4 && 新旧 == 1)
				{
					text6 += (((num2 >= 100) ? "\"juhuo-fentian\":数值,\"xinghuo-liaoyuan\":数值,\"yantian-huoyu\":数值,\"jiaojin-lishi\":数值,\"lianyu-huohai\":数值,\"xinzui-shenmi\":数值,\"shenhun-diandao\":数值,\"hunbu-shoushe\":数值,\"hunqian-mengying\":数值,\"hunbu-futi\":数值,\"shiwan-huoji\":数值,\"xiansheng-duoren\":数值,\"jifeng-xunlei\":数值,\"fengchi-dianche\":数值,\"binggui-shensu\":数值,\"huoshu-yinhua\":数值,\"huifei-yanmie\":数值,\"sanmei-lianxin\":数值,\"lihuo-duopo\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"juhuo-fentian\":数值,\"xinghuo-liaoyuan\":数值,\"yantian-huoyu\":数值,\"jiaojin-lishi\":数值,\"xinzui-shenmi\":数值,\"shenhun-diandao\":数值,\"hunbu-shoushe\":数值,\"hunqian-mengying\":数值,\"shiwan-huoji\":数值,\"xiansheng-duoren\":数值,\"jifeng-xunlei\":数值,\"fengchi-dianche\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				else if (门派 == 4 && 新旧 == 2)
				{
					text6 += (((num2 >= 100) ? "\"nujian-lixian\":数值,\"yijian-shuangdiao\":数值,\"jianbu-xufa\":数值,\"xingfei-yunsan\":数值,\"wanjian-chuanxin\":数值,\"xinsuo-shenfeng\":数值,\"chongyuan-diesuo\":数值,\"rufeng-sibi\":数值,\"kunling-suoxin\":数值,\"yunmi-wusuo\":数值,\"jiru-xinghuo\":数值,\"xingchi-dianzou\":数值,\"dianguang-shihuo\":数值,\"feiyun-zhidian\":数值,\"huxiao-fengchi\":数值,\"huoshu-yinhua\":数值,\"huifei-yanmie\":数值,\"sanmei-lianxin\":数值,\"lihuo-duopo\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"nujian-lixian\":数值,\"yijian-shuangdiao\":数值,\"jianbu-xufa\":数值,\"xingfei-yunsan\":数值,\"xinsuo-shenfeng\":数值,\"chongyuan-diesuo\":数值,\"rufeng-sibi\":数值,\"kunling-suoxin\":数值,\"jiru-xinghuo\":数值,\"xingchi-dianzou\":数值,\"dianguang-shihuo\":数值,\"feiyun-zhidian\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				if (门派 == 5 && 新旧 == 1)
				{
					text6 += (((num2 >= 100) ? "\"luotu-feiyan\":数值,\"tumo-chenmai\":数值,\"shanbeng-dilie\":数值,\"tianta-dixian\":数值,\"shipo-tianjing\":数值,\"youxin-wuli\":数值,\"guci-shibi\":数值,\"liushen-wuzhu\":数值,\"dishu-qipo\":数值,\"tianding-sanhun\":数值,\"bianchang-moji\":数值,\"wangfeng-puying\":数值,\"huaxian-weiyi\":数值,\"bishi-jiuxu\":数值,\"yixing-huanying\":数值,\"feisha-zoushi\":数值,\"kaibei-lieshi\":数值,\"xinru-panshi\":数值,\"diwo-nanfen\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"luotu-feiyan\":数值,\"tumo-chenmai\":数值,\"shanbeng-dilie\":数值,\"tianta-dixian\":数值,\"youxin-wuli\":数值,\"guci-shibi\":数值,\"liushen-wuzhu\":数值,\"dishu-qipo\":数值,\"bianchang-moji\":数值,\"wangfeng-puying\":数值,\"huaxian-weiyi\":数值,\"bishi-jiuxu\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				else if (门派 == 5 && 新旧 == 2)
				{
					text6 += (((num2 >= 100) ? "\"tubeng-wajie\":数值,\"chentu-feiyang\":数值,\"yangli-feisha\":数值,\"didong-shanyao\":数值,\"qianyan-wanhe\":数值,\"jinghuang-shicuo\":数值,\"ranshen-luanzhi\":数值,\"shenhun-piaodang\":数值,\"shenyao-yiduo\":数值,\"jingshen-podan\":数值,\"xuxu-shishi\":数值,\"gunong-xuanxu\":数值,\"konghuan-xushi\":数值,\"xukong-huanying\":数值,\"xuwu-piaomiao\":数值,\"feisha-zoushi\":数值,\"kaibei-lieshi\":数值,\"xinru-panshi\":数值,\"diwo-nanfen\":数值,\"lipo-qianjun\":数值,\"xuanhuan-shu\":1,\"qiangshen-shu\":1,\"qianliyan\":1,\"shenti-shu\":1,\"xiudao-shu\":1,\"leiting-qianjun\":264,\"zhulian-bihe\":264,\"wanxiang-yuhua\":264," : "\"tubeng-wajie\":数值,\"chentu-feiyang\":数值,\"yangli-feisha\":数值,\"didong-shanyao\":数值,\"jinghuang-shicuo\":数值,\"ranshen-luanzhi\":数值,\"shenhun-piaodang\":数值,\"shenyao-yiduo\":数值,\"xuxu-shishi\":数值,\"gunong-xuanxu\":数值,\"konghuan-xushi\":数值,\"xukong-huanying\":数值,") + (Singleton<全局变量类>.I.网关Config.Is法宝共生 ? "\"fabao-gongsheng\":1," : "")).Replace("数值", num4.ToString());
				}
				if (num2 >= 130)
				{
					text6 += text7;
				}
			}
			if (num2 < 100)
			{
				text8 = "([\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([\"wood\":0,\"resist_lost\":0,\"durability\":100,\"life\":105,\"cash\":游戏金币,\"pot\":角色潜能,\"religion\":新老角色转换,\"type\":1,\"resist_wood\":0,\"friend_converted\":3,\"con\":角色等级,\"earth\":0,\"reputation\":0,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1569479697,\"resist_poison\":0,\"voucher\":游戏代金卷,\"last_login_time\":1569481420,\"resisit_wood\":0,\"dex\":角色等级,\"store_converted\":1,\"energy\":1500,\"polar\":角色五行相性,\"block_state\":0,\"polar_wood\":0,\"create_time\":1569479696,\"generate_time\":必需替换的时间戳,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"last_login_ip\":\"\",\"resist_metal\":0,\"phy_power\":45,\"anticheater_info\":([\"total_steps\":4,\"interval\":1739,\"last_move_time\":1569481420,]),\"recover_energy_time\":1569481307,\"has_trade_goods\":0,\"max_cash\":21015,\"today_played_time\":12,\"balance\":0,\"fire\":0,\"task\":([243:([\"state\":\"b\",\"ver\":1,]),1000:([\"state\":\"0\",\"ti\":1574665420,\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),644:([\"state\":\"0\",\"upgrade_type\":0,]),614:([\"state\":\"1\",\"st\":1569481200,]),1091:([\"et\":1569772799,\"total\":480,]),1087:([\"ti\":1569481420,\"exp\":2875162,\"tao\":102813,]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1061:([\"et\":1569772799,\"total\":120,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1569427199,\"upgrade_type\":0,]),]),\"title_type_effect\":\"无显示\",\"newbie\":1,\"age\":0,\"resist_lock\":0,\"speed\":226,\"init_basic_info\":1,\"mana\":10000,\"water\":0,\"signature\":\"\",\"name\":\"玩家角色名称\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"protect_bonus\":([\"ti\":1569481420,\"hour\":0,]),\"double_balance\":2,\"attrib_point\":角色属性点,\"resist_fire\":0,\"level\":角色等级,\"resist_frozen\":0,\"max_life\":8154,\"unique_data\":([0:536870912,5:16,2:64,1:67584,]),\"max_mana\":5498,\"tao\":道行,\"soul_cob_rate\":0,\"portrait\":角色图片代码,\"account\":\"角色游戏帐号\",\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1569479698,\"ytd\":([]),\"td\":([\"0\":1569481385,\"4\":500,\"2\":100,\"3\":0,]),]),\"last_login_mac\":\"\",\"resist_earth\":0,\"last_privilege\":300,\"question\":([\"answer_times\":0,]),\"gender\":角色性别,\"max_stamina\":188,\"last_logout_time\":必需替换的时间戳,\"settings\":([\"convert\":1,]),\"polar_water\":0,\"exp_to_next_level\":475592,\"polar_earth\":0,\"gold_coin\":金元宝数量,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1569481420,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"pker\":0,\"resist_forgotten\":0,\"task_round\":([\"962\":0,]),\"cur_ver\":17,\"metal\":0,\"str\":角色等级,\"total_pk\":0,\"wiz\":角色等级,\"max_balance\":45690,\"stamina\":100,\"salary\":([\"online_time\":([\"1569772800\":1738,]),]),\"def\":465,\"polar_fire\":0,\"icon\":角色图片代码,\"max_durability\":100,\"resisit_fire\":0,\"tao_ex\":0,\"resist_repress\":0,\"previous_login_ip\":\"\",\"appellation_ids\":([7:33554432,]),\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"resist_melt\":0,\"mag_power\":485,\"limit_trade_coin\":0,\"title_type\":\"无显示\",\"total_played_time\":1739,\"newbie\":1,\"dodge\":0,\"resist_confusion\":0,\"top_data\":([\"speed\":226,\"def\":465,\"phy_power\":485,\"mag_power\":485,]),\"resisit_water\":0,\"resist_sleep\":0,\"gid\":\"角色GID\",\"first_login_ip\":\"\",\"user_converted\":7,\"max_assign_polar\":30,\"silver_coin\":银元宝数量,\"limit_per_month\":([\"ti\":1569481385,\"11\":1,\"7\":100,\"8\":0,]),\"title_effect\":\"\",\"title\":\"初始称号\",\"polar_point\":58,\"resist_water\":0,\"resisit_metal\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"\",\"max_account_lv\":角色等级,\"wudou\":([\"last_cost_time\":1569168000,]),\"polar_metal\":0,\"logout_time\":必需替换的时间戳,\"exp\":0,\"newbie_gift\":1,\"limit_per_day\":([\"ti\":1569481313,\"93\":1,\"777\":1,\"895\":100,\"783\":1,]),\"scroll\":([\"time\":1569481408,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"insider_time\":315360000,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"\",({76,0,1,}),({37,0,1,}),({57,0,1,}),({41,0,1,}),({33,0,1,}),}),}),\"skills_map\":([]),\"skills\":([\"jingying-zhidao\":1,技能]),])";
			}
			else if (num2 >= 100 && num2 < 110)
			{
				text8 = "([\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([\"wood\":0,\"resist_lost\":0,\"durability\":100,\"life\":10000,\"cash\":游戏金币,\"pot\":角色潜能,\"religion\":新老角色转换,\"type\":1,\"resist_wood\":0,\"master\":\"角色二代祖师\",\"friend_converted\":3,\"con\":角色等级,\"earth\":0,\"reputation\":0,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1569479697,\"resist_poison\":0,\"voucher\":游戏代金卷,\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1569481420,\"resisit_wood\":0,\"dex\":角色等级,\"store_converted\":1,\"energy\":1500,\"polar\":角色五行相性,\"block_state\":0,\"polar_wood\":0,\"create_time\":1569479696,\"generate_time\":必需替换的时间戳,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"last_login_ip\":\"\",\"resist_metal\":0,\"phy_power\":485,\"anticheater_info\":([\"total_steps\":4,\"interval\":1739,\"last_move_time\":1569481420,]),\"recover_energy_time\":1569481307,\"has_trade_goods\":0,\"max_cash\":42030,\"today_played_time\":1739,\"balance\":0,\"fire\":0,\"task\":([243:([\"state\":\"b\",\"ver\":1,]),48:([\"end_time\":1829279214,]),1000:([\"state\":\"0\",\"ti\":1574665420,\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),644:([\"state\":\"0\",\"upgrade_type\":0,]),614:([\"state\":\"1\",\"st\":1569481200,]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"角色GID\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"玩家角色名称\",]),]),]),1091:([\"et\":1569772799,\"total\":480,]),1087:([\"ti\":1569481420,\"exp\":2875162,\"tao\":102813,]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1061:([\"et\":1569772799,\"total\":120,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1569427199,\"upgrade_type\":0,]),]),\"title_type_effect\":\"无显示\",\"age\":0,\"resist_lock\":0,\"speed\":226,\"init_basic_info\":1,\"mana\":10000,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"signature\":\"\",\"name\":\"玩家角色名称\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第二代弟子\",\"protect_bonus\":([\"ti\":1569481420,\"hour\":0,]),\"double_balance\":2,\"attrib_point\":角色属性点,\"resist_fire\":0,\"level\":角色等级,\"resist_frozen\":0,\"max_life\":8154,\"unique_data\":([0:536870912,5:16,2:64,1:67584,]),\"max_mana\":5498,\"tao\":道行,\"soul_cob_rate\":0,\"appellation\":([\"family\":\"角色一代弟子称号\",\"无显示\":\"\",]),\"portrait\":角色图片代码,\"account\":\"角色游戏帐号\",\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1569479698,\"ytd\":([]),\"td\":([\"0\":1569481385,\"4\":500,\"2\":100,\"3\":0,]),]),\"last_login_mac\":\"\",\"resist_earth\":0,\"last_privilege\":300,\"question\":([\"answer_times\":0,]),\"gender\":角色性别,\"max_stamina\":188,\"last_logout_time\":必需替换的时间戳,\"settings\":([\"convert\":1,]),\"polar_water\":0,\"exp_to_next_level\":475592,\"polar_earth\":0,\"gold_coin\":金元宝数量,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1569481420,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"pker\":0,\"resist_forgotten\":0,\"task_round\":([\"962\":0,]),\"cur_ver\":17,\"metal\":0,\"str\":角色等级,\"total_pk\":0,\"wiz\":角色等级,\"max_balance\":45690,\"stamina\":100,\"salary\":([\"online_time\":([\"1569772800\":1738,]),]),\"def\":465,\"polar_fire\":0,\"icon\":角色图片代码,\"max_durability\":100,\"resisit_fire\":0,\"tao_ex\":0,\"resist_repress\":0,\"previous_login_ip\":\"\",\"appellation_ids\":([7:33554432,4:32,]),\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"resist_melt\":0,\"mag_power\":485,\"limit_trade_coin\":0,\"title_type\":\"无显示\",\"total_played_time\":1739,\"newbie\":1,\"dodge\":0,\"resist_confusion\":0,\"top_data\":([\"speed\":226,\"def\":465,\"phy_power\":485,\"mag_power\":485,]),\"resisit_water\":0,\"resist_sleep\":0,\"gid\":\"角色GID\",\"first_login_ip\":\"\",\"user_converted\":7,\"max_assign_polar\":30,\"silver_coin\":银元宝数量,\"limit_per_month\":([\"ti\":1569481385,\"11\":1,\"7\":100,\"8\":0,]),\"title_effect\":\"\",\"family\":\"山门\",\"title\":\"初始称号\",\"polar_point\":58,\"resist_water\":0,\"resisit_metal\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"\",\"max_account_lv\":角色等级,\"wudou\":([\"last_cost_time\":1569168000,]),\"polar_metal\":0,\"logout_time\":必需替换的时间戳,\"exp\":0,\"newbie_gift\":1,\"limit_per_day\":([\"ti\":1569481313,\"93\":1,\"777\":1,\"895\":100,\"783\":1,]),\"scroll\":([\"time\":1569481408,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"insider_time\":315360000,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"\",({76,0,1,}),({37,0,1,}),({57,0,1,}),({41,0,1,}),({33,0,1,}),}),}),\"skills_map\":([]),\"skills\":([\"盾术\":1,\"jingying-zhidao\":1,技能]),])";
			}
			else if (num2 >= 110 && num2 < 134)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"dijie_finish10\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"dijie_finish10\",\"finished_time\":([\"dijie_finish10\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":10,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":40,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"dijie_finish\":\"夜长梦多\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":10,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"dijie_finish\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			else if (num2 >= 134 && num2 < 139)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie1\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie2\",\"finished_time\":([\"tianjie1\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":11,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":41,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"regal\":100,\"appellation\":([\"family\":\"%s\",\"tianjie\":\"一劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":11,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			else if (num2 >= 139 && num2 < 144)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie2\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie3\",\"finished_time\":([\"tianjie2\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":12,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":42,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"二劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":12,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			else if (num2 >= 144 && num2 < 149)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie3\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie4\",\"finished_time\":([\"tianjie3\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":13,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":43,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"三劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":13,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			else if (num2 >= 149 && num2 < 154)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie4\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie5\",\"finished_time\":([\"tianjie4\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":14,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":44,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"四劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":14,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			else if (num2 >= 154 && num2 < 159)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":出生坐标X,\"y\":出生坐标Y,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie5\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie6\",\"finished_time\":([\"tianjie5\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":15,\"str\":139,\"total_pk\":0,\"wiz\":139,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":45,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":139,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":139,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":139,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"五劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":15,\"bonus\":1,\"max_level\":139,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":139,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			else if (num2 >= 159)
			{
				text8 = "([\"upgrade_attrib\":([\"wood\":0,\"life\":16495,\"max_stamina\":233,\"settings\":({}),\"exp_to_next_level\":111024092,\"die_stat\":([\"times\":0,\"time\":0,]),\"equip_page\":0,\"con\":134,\"earth\":0,\"exp_ex\":5,\"level_up_time\":5601,\"polar_already\":([\"wood\":0,\"earth\":0,\"total\":0,\"water\":0,\"fire\":0,\"metal\":0,]),\"str\":134,\"metal\":0,\"total_pk\":0,\"medicine_used\":([\"sanqingwan\":0,\"baohua-yuluwan\":0,]),\"wiz\":134,\"stamina\":116,\"dex\":134,\"icon\":%s,\"def\":690,\"lock_exp\":0,\"tao_ex\":0,\"trace_task\":({}),\"phy_power\":710,\"mag_power\":710,\"dodge\":0,\"fire\":0,\"medicine\":([\"life\":0,\"mana\":0,\"polar_point\":0,\"attrib_point\":0,]),\"task\":([203:([\"state\":\"x\",\"sub_name\":\"静笃虚极\",\"snap_log\":\"\",\"upgrade_type\":2,]),]),\"pets_state\":([]),\"speed\":316,\"mana\":11135,\"polar_point\":103,\"water\":0,\"pause_level_up\":0,\"accurate\":0,\"feedback\":([\"ti_last_apply\":0,\"apply_num\":0,]),\"attrib_point\":532,\"level\":%s,\"max_life\":16495,\"attrib_already\":([\"dex\":0,\"con\":0,\"total\":0,\"str\":0,\"wiz\":0,]),\"exp\":1787570287,\"max_mana\":11135,\"tao\":0,\"parry\":0,\"exp_to_be_added\":([]),\"portrait\":%s,]),\"position\":([\"room\":出生地图,\"dir\":4,\"x\":242,\"y\":194,]),\"me\":([48:([\"end_time\":1829279214,]),元神合体替换\"resist_lost\":0,\"durability\":100,\"life\":27614,\"religion\":%s,\"type\":1,\"stat_coin_cost\":([\"minfo\":({}),\"winfo\":({}),\"mcoin\":24,\"wcoin\":24,\"muptime\":1559318400,\"wuptime\":1559491200,\"lstime\":1559742196,]),\"friend_converted\":3,\"earth\":0,\"exp_ex\":0,\"voucher\":%s,\"service\":([]),\"task_finished\":([\"apprentice_task\":1,]),\"last_login_time\":1559740475,\"resisit_wood\":0,\"store_converted\":1,\"polar\":%s,\"block_state\":0,\"polar_wood\":0,\"trace_task\":({\"【新手】1-9级新手任务,0\",}),\"has_trade_goods\":0,\"max_cash\":2000000000,\"today_played_time\":11953,\"task\":([1000:([\"state\":\"0\",\"ti\":1564919290,\"upgrade_type\":0,]),982:([\"state\":\"0\",\"ti\":1559729912,]),852:([\"ct\":1559729912,]),257:([\"alias\":\"【指引】法宝三合一\",]),754:([\"state\":\"0\",\"et\":1595606399,]),750:([\"state\":\"0\",\"upgrade_type\":0,]),729:([\"state\":\"S2\",\"alias\":38,\"upgrade_type\":0,]),734:([]),698:([\"state\":\"1\",]),644:([\"state\":\"0\",\"upgrade_type\":0,]),601:([\"state\":\"0\",\"upgrade_type\":0,]),82:([\"time\":1580892204,\"week_secs\":0,\"week\":3,\"keep_hour\":0,\"rate\":2,\"keep_time\":0,\"total\":0,\"store_time\":0,]),395:([\"state\":100,\"sub_name\":\"tianjie7\",\"upgrade_type\":0,\"level\":164,\"next_task_name\":\"tianjie8\",\"finished_time\":([\"tianjie7\":\"2019-06-05-21:45:07\",]),]),339:([\"state\":\"1\",\"upgrade_type\":0,\"finish\":([]),]),294:([\"owner_gid\":\"%s\",\"rt\":1559738965,\"log\":\"当前提示：与五大门派的#P元始天尊#P、#P准提道人#P、#P西方教主#P、#P太上老君#P、#P通天教主#P交谈，并选择其一做为第二门派。\",\"dbase\":([\"state\":\"学习新法术\",\"init_time\":([\"1559740475\":\"测试04\",]),]),]),1117:([\"ver\":1,\"sn\":0,]),1091:([\"et\":1560095999,\"total\":480,]),1101:([\"state\":\"x\",\"items\":({\"混元金斗\",\"九龙神火罩\",}),\"upgrade_type\":0,\"item_name\":\"混元金斗\",]),1074:([\"state\":\"0\",]),1076:([\"state\":\"0\",]),1087:([\"ti\":1559740475,\"exp\":4739481,\"tao\":160574,]),1079:([\"state\":\"0\",\"upgrade_type\":0,]),1061:([\"et\":1560095999,\"total\":120,]),1044:([\"st\":1559664000,\"upgrade_type\":0,]),21:([\"state\":0,\"times\":0,\"new_ver\":1,\"max_times\":1,\"bonus_time\":1559663999,\"upgrade_type\":0,]),1027:([\"et\":1561910400,]),1028:([\"et\":1561910400,\"npc\":66,]),]),\"speed\":444,\"init_basic_info\":1,\"name\":\"%s\",\"accurate\":0,\"region\":([\"flag\":1,\"province\":1,\"city\":1,]),\"double_cash\":2,\"title_basic\":\"第一代弟子\",\"protect_bonus\":([\"ti\":1559740475,\"hour\":0,]),\"double_balance\":2,\"resist_fire\":0,\"resist_frozen\":0,\"max_life\":27614,\"extra_mana\":43948065,\"max_mana\":16114,\"nice\":9,\"tao\":%s,\"soul_cob_rate\":0,\"portrait\":%s,\"account\":\"%s\",\"last_privilege\":0,\"question\":([\"answer_times\":0,]),\"gender\":%s,\"last_logout_time\":1559742439,\"polar_water\":0,\"exp_to_next_level\":2100000000,\"polar_earth\":0,\"gold_coin\":0,\"ip_region\":([\"province\":\"北京市\",\"city\":\"东城区\",]),\"cur_pk\":0,\"restriction\":([\"login_time\":1559740475,]),\"character\":([\"harmony\":0,\"kindness\":0,\"desc\":\"普普通通\",\"carefulness\":0,\"courage\":0,]),\"resist_forgotten\":0,\"cur_ver\":17,\"str\":165,\"total_pk\":0,\"wiz\":165,\"stamina\":136,\"def\":1208,\"polar_fire\":0,\"icon\":%s,\"max_durability\":100,\"last_level_up_time\":1559742314,\"tao_ex\":0,\"appellation_ids\":([]),\"resist_melt\":0,\"total_played_time\":11953,\"newbie\":1,\"upgrade_magic\":修道点,\"dodge\":0,\"top_data\":([\"speed\":326,\"def\":715,\"phy_power\":735,\"mag_power\":735,]),\"resist_sleep\":0,\"first_login_ip\":\"171.221.225.8\",\"max_assign_polar\":47,\"title_effect\":\"\",\"family\":\"%s\",\"title\":\"大飞|有你刚好\",\"polar_point\":134,\"resist_water\":0,\"resisit_metal\":0,\"upgrade_immortal\":修道点,\"max_account_lv\":165,\"wudou\":([\"last_cost_time\":1559491200,]),\"attrib_already\":([]),\"limit_per_day\":([\"ti\":1559729904,\"777\":1,\"928\":0,\"361\":1,\"889\":2147483647,\"895\":2318500,\"886\":18880102,\"783\":1,]),\"parry\":0,\"auth_protect_prompt\":1,\"login_times\":2,\"wood\":0,\"cash\":%s,\"pot\":%s,\"first_get_upgrade_time\":1559735283,\"resist_wood\":0,\"master\":\"%s\",\"con\":165,\"reputation\":0,\"level_up_time\":11828,\"version_prompt\":([\"1.60\":2,]),\"first_login_time\":1559729748,\"resist_poison\":0,\"dex\":165,\"energy\":1500,\"create_time\":1559729508,\"generate_time\":1559742439,\"last_login_ip\":\"171.221.225.8\",\"resist_metal\":0,\"phy_power\":865,\"anticheater_info\":([\"total_steps\":1437,\"interval\":11953,\"last_move_time\":1559742352,]),\"recover_energy_time\":1559740736,\"balance\":0,\"fire\":0,\"medicine\":([]),\"title_type_effect\":\"无显示\",\"resist_lock\":0,\"age\":0,\"mana\":16114,\"task_score\":([\"total\":1,\"active_time\":1580709582,\"1\":({\"仙界通缉\",1,1580709582,}),]),\"water\":0,\"feedback\":([]),\"trigger_guide\":([\"203\":1,]),\"attrib_point\":682,\"level\":%s,\"unique_data\":([1:-257882112,3:5177344,0:536870912,2:8388672,5:32792,]),\"appellation\":([\"family\":\"%s\",\"tianjie\":\"七劫散仙\",\"upgrade\":\"飞升\",\"无显示\":\"\",]),\"act_stat\":([\"mons\":({0,0,0,}),\"ti\":1559729748,\"ytd\":([]),\"td\":([\"13\":24,\"0\":1559742302,\"1\":2145243651,\"2\":2318500,\"3\":0,\"4\":1000042947,\"5\":191,]),]),\"last_login_mac\":\"0000e0d55ec94456\",\"resist_earth\":0,\"max_stamina\":264,\"settings\":([\"convert\":1,]),\"die_stat\":([]),\"equip_page\":0,\"pker\":0,\"assist_equip\":1,\"task_round\":([\"962\":0,]),\"polar_already\":([]),\"metal\":0,\"medicine_used\":([]),\"max_balance\":556791250,\"salary\":([\"online_time\":([\"1560096000\":11953,]),]),\"upgrade\":([\"max_polar_extra\":17,\"bonus\":1,\"max_level\":165,\"attrib_point\":26,\"attrib_total\":26,\"type\":%s,\"ti_modify\":1335590733,\"state\":0,\"create_time\":1559735283,\"ever_lv\":165,\"total\":修道点,\"cur_ver\":6,]),\"resisit_fire\":0,\"resist_repress\":0,\"previous_login_ip\":\"无\",\"max_energy\":1500,\"resisit_earth\":0,\"resist_cage\":0,\"mag_power\":865,\"xieling\":1,\"limit_trade_coin\":0,\"title_type\":\"tianjie\",\"resist_confusion\":0,\"resisit_water\":0,\"gid\":\"%s\",\"user_converted\":7,\"silver_coin\":0,\"limit_per_month\":([\"ti\":1559729912,\"11\":1,\"7\":0,\"8\":707,\"9\":4,]),\"achieve\":120,\"pause_level_up\":0,\"have_coin_pwd\":0,\"first_login_mac\":\"0000e0d55ec94456\",\"total_score\":45,\"has_upgraded\":1,\"polar_metal\":0,\"extra_life\":43878176,\"logout_time\":1559742439,\"exp\":0,\"newbie_gift\":1,\"scroll\":([\"time\":1559739731,]),\"insider_time\":46672,]),\"discover_world\":([\"1\":([]),]),\"settings\":({({\"USER\",({2,308,123,}),}),({\"\",({80,0,0,}),({76,0,1,}),({37,0,0,}),({64,0,0,}),({78,0,0,}),({72,0,0,}),({50,0,0,}),({88,0,0,}),({65,0,0,}),({41,0,0,}),({57,0,0,}),({33,0,1,}),({74,0,0,}),({31,0,0,}),({52,0,0,}),({66,0,0,}),}),}),\"skills_map\":([]),\"skills\":([\"%s\":1,%s]),])";
			}
			text8 = text8.Replace("元神合体替换", Singleton<全局变量类>.I.网关Config.Is元神合体 ? "\"finish_ysht\":1,\"backup_attrib_plan\":([\"wood\":0,\"attrib_already\":([\"total\":0,\"wiz\":0,]),\"earth\":0,\"water\":0,\"polar_point\":0,\"upgrade_magic\":0,\"upgrade_immortal\":0,\"fire\":0,\"attrib_point\":0,\"cur_attrib_plan\":2,\"metal\":0,\"upgrade\":([\"dex\":0,\"attrib_point\":0,\"con\":0,\"str\":0,\"wiz\":0,]),]),\"cur_attrib_plan\":1," : "");
			if (问道数据类.出生地图列表.TryGetValue(Singleton<全局变量类>.I.网关Config.出生地图, out string value))
			{
				text8 = text8.Replace("出生地图", value);
			}
			text8 = text8.Replace("出生坐标X", Singleton<全局变量类>.I.网关Config.出生坐标.Split(",")[0]);
			text8 = text8.Replace("出生坐标Y", Singleton<全局变量类>.I.网关Config.出生坐标.Split(",")[1]);
			text8 = text8.Replace("大飞|有你刚好", Singleton<全局变量类>.I.网关Config.送称号);
			if (num2 < 110)
			{
				text8 = text8.Replace("游戏金币", Singleton<全局变量类>.I.网关Config.送金钱.ToString());
				text8 = text8.Replace("角色潜能", Singleton<全局变量类>.I.网关Config.送潜能.ToString());
				text8 = text8.Replace("新老角色转换", 新旧.ToString());
				text8 = text8.Replace("角色等级", num2.ToString());
				text8 = text8.Replace("游戏代金卷", Singleton<全局变量类>.I.网关Config.送代金.ToString());
				text8 = text8.Replace("必需替换的时间戳", 问道数据类.GetTimeChuo(bflag: true));
				text8 = text8.Replace("角色二代祖师", text5);
				text8 = text8.Replace("角色五行相性", 门派.ToString());
				text8 = text8.Replace("玩家角色名称", 昵称);
				text8 = text8.Replace("山门", text3);
				text8 = text8.Replace("角色属性点", (num2 * 4 - 4).ToString());
				text8 = text8.Replace("道行", (Singleton<全局变量类>.I.网关Config.送道行 * 360).ToString());
				text8 = text8.Replace("角色一代弟子称号", (num2 <= 10) ? string.Empty : (text3 + "第二代弟子"));
				text8 = text8.Replace("角色图片代码", icons);
				text8 = text8.Replace("角色游戏帐号", 账号);
				text8 = text8.Replace("角色性别", 性别.ToString());
				text8 = text8.Replace("金元宝数量", Singleton<全局变量类>.I.网关Config.送金元宝.ToString());
				text8 = text8.Replace("角色GID", text9);
				text8 = text8.Replace("银元宝数量", Singleton<全局变量类>.I.网关Config.送银元宝.ToString());
				text8 = text8.Replace("初始称号", Singleton<全局变量类>.I.网关Config.送称号);
				text8 = text8.Replace("技能", text6);
				text8 = text8.Replace("盾术", text4);
			}
			else
			{
				num2 = 等级;
				string[] infos = new string[23]
				{
					text2,
					num2.ToString(),
					text2,
					新旧.ToString(),
					Singleton<全局变量类>.I.网关Config.送代金.ToString(),
					门派.ToString(),
					text9,
					安全码,
					(Singleton<全局变量类>.I.网关Config.送道行 * 360).ToString(),
					icons,
					账号,
					性别.ToString(),
					icons,
					text3,
					Singleton<全局变量类>.I.网关Config.送金钱.ToString(),
					Singleton<全局变量类>.I.网关Config.送潜能.ToString(),
					text5,
					num2.ToString(),
					text3 + "第一代弟子",
					仙魔.ToString(),
					text9,
					text4,
					text6
				};
				text8 = 问道数据类.GetStringRe(text8, "%s", infos);
				text8 = text8.Replace("修道点", num3.ToString());
			}
			int dataChecksum = GetDataChecksum("user" + text9 + text8);
			num = c1ZNsjqlRc(mySqlConnection, string.Format("INSERT INTO dl_ddb_1.data(path,name,branch,content,checksum) VALUES('user','{0}','','{1}','{2}')", text9, text8, dataChecksum));
			if (num < 0)
			{
				Log.Error("角色数据生成失败！");
				回调事件?.Invoke("角色数据生成失败，请稍后重试！");
				return;
			}
			dataChecksum = GetDataChecksum("user" + text9 + "achieve([90102:([5:294,4:1557680413,]),60413:([5:0,4:1557680404,]),60414:([5:0,4:1557680404,]),60415:([5:0,4:1557680404,]),70113:([4:1557596605,3:1,]),\"update_ti\":1557677100,10201:([1:1,]),70110:([4:1557596608,3:1,]),\"ver\":2,30169:([1:1,]),10703:([5:0,4:1557596587,]),10702:([5:0,4:1557596587,]),10701:([5:0,4:1557596587,]),30134:([1:1,]),20406:([1:1,]),20407:([5:3,4:1557608768,7:([\"ti\":3486,]),]),30122:([5:1,4:1557611645,]),30121:([1:1,]),51101:([5:5,4:1557677789,7:([\"ti\":216,]),]),51103:([5:0,4:1557596587,]),51102:([5:0,4:1557596587,]),30101:([1:1,]),30107:([1:1,]),\"total\":155,90401:([1:1,]),10505:([5:0,4:1557680404,]),10506:([5:0,4:1557680404,]),40206:([5:0,4:1557680404,7:([]),]),90336:([1:1,]),50403:([1:1,]),50910:([1:1,4:1557596688,]),50909:([1:1,]),90331:([1:1,]),90308:([5:47,4:1557675755,]),90307:([1:1,]),60102:([5:1,4:1557675613,]),60101:([1:1,]),90316:([5:1,4:1557606398,]),90315:([1:1,]),90313:([1:1,]),90314:([5:9,4:1557607101,]),90301:([1:1,]),40105:([5:0,4:1557680404,]),40106:([5:0,4:1557680404,]),\"traces\":({}),20113:([5:0,4:1557610503,]),20114:([5:0,4:1557610503,]),20110:([5:0,4:1557609711,]),20106:([5:0,4:1557610503,]),20102:([5:0,4:1557610503,]),20103:([5:0,4:1557610503,]),20104:([5:0,4:1557610503,]),20101:([1:1,]),90208:([5:1,4:1557605766,]),90215:([1:1,]),90217:([1:1,]),90216:([1:1,]),90218:([1:1,]),90207:([1:1,]),\"lastest\":({90307,10201,60101,}),80404:([5:0,4:1557680404,]),80405:([5:0,4:1557680404,]),80406:([5:0,4:1557680404,]),])");
			num = c1ZNsjqlRc(mySqlConnection, string.Format("INSERT INTO dl_ddb_1.data(path,name,branch,content,checksum) VALUES('user','{0}','achieve','{1}','{2}')", text9, "([90102:([5:294,4:1557680413,]),60413:([5:0,4:1557680404,]),60414:([5:0,4:1557680404,]),60415:([5:0,4:1557680404,]),70113:([4:1557596605,3:1,]),\"update_ti\":1557677100,10201:([1:1,]),70110:([4:1557596608,3:1,]),\"ver\":2,30169:([1:1,]),10703:([5:0,4:1557596587,]),10702:([5:0,4:1557596587,]),10701:([5:0,4:1557596587,]),30134:([1:1,]),20406:([1:1,]),20407:([5:3,4:1557608768,7:([\"ti\":3486,]),]),30122:([5:1,4:1557611645,]),30121:([1:1,]),51101:([5:5,4:1557677789,7:([\"ti\":216,]),]),51103:([5:0,4:1557596587,]),51102:([5:0,4:1557596587,]),30101:([1:1,]),30107:([1:1,]),\"total\":155,90401:([1:1,]),10505:([5:0,4:1557680404,]),10506:([5:0,4:1557680404,]),40206:([5:0,4:1557680404,7:([]),]),90336:([1:1,]),50403:([1:1,]),50910:([1:1,4:1557596688,]),50909:([1:1,]),90331:([1:1,]),90308:([5:47,4:1557675755,]),90307:([1:1,]),60102:([5:1,4:1557675613,]),60101:([1:1,]),90316:([5:1,4:1557606398,]),90315:([1:1,]),90313:([1:1,]),90314:([5:9,4:1557607101,]),90301:([1:1,]),40105:([5:0,4:1557680404,]),40106:([5:0,4:1557680404,]),\"traces\":({}),20113:([5:0,4:1557610503,]),20114:([5:0,4:1557610503,]),20110:([5:0,4:1557609711,]),20106:([5:0,4:1557610503,]),20102:([5:0,4:1557610503,]),20103:([5:0,4:1557610503,]),20104:([5:0,4:1557610503,]),20101:([1:1,]),90208:([5:1,4:1557605766,]),90215:([1:1,]),90217:([1:1,]),90216:([1:1,]),90218:([1:1,]),90207:([1:1,]),\"lastest\":({90307,10201,60101,}),80404:([5:0,4:1557680404,]),80405:([5:0,4:1557680404,]),80406:([5:0,4:1557680404,]),])", dataChecksum));
			if (num < 0)
			{
				Log.Error("角色GID数据生成失败！");
				回调事件?.Invoke("角色GID数据生成失败，请稍后重试！");
				return;
			}
			string text10 = "";
			string text11 = "";
			string text12 = "";
			string text13 = "";
			if (Singleton<全局变量类>.I.网关Config.赠送道具 && !string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.网关Config.赠送道具名字) && Singleton<全局变量类>.I.网关Config.道具数量 > 0)
			{
				try
				{
					for (int i = 1; i <= Singleton<全局变量类>.I.网关Config.道具数量; i++)
					{
						string[] infos2 = new string[6]
						{
							(100 + i).ToString(),
							Singleton<全局变量类>.I.网关Config.赠送道具名字,
							(100 + i).ToString(),
							Singleton<全局变量类>.I.网关Config.道具数量.ToString(),
							"1",
							Singleton<全局变量类>.I.网关Config.道具绑定.ToString()
						};
						string stringRe = 问道数据类.GetStringRe("%s:\"%s:([255:36,232:%s,47:%s,35:%s,\\\"type\\\":8,257:([48:%s,]),])\",", "%s", infos2);
						text10 += stringRe;
					}
					text10 = "([\"carry\":([道具]),])".Replace("道具", text10);
				}
				catch (Exception)
				{
					text10 = "([\"carry\":([道具]),])";
					text10 = text10.Replace("道具", "");
				}
			}
			else
			{
				text10 = "([\"carry\":([道具]),])";
				text10 = text10.Replace("道具", "");
			}
			dataChecksum = GetDataChecksum("user" + text9 + "carry" + text10);
			num = c1ZNsjqlRc(mySqlConnection, string.Format("INSERT INTO dl_ddb_1.data(path,name,branch,content,checksum)  VALUES('user','{0}','carry','{1}','{2}')", text9, text10.Replace("\\", "\\\\"), dataChecksum));
			if (num < 0)
			{
				Log.Error("角色背包数据生成失败！");
				回调事件?.Invoke("角色背包数据生成失败，请稍后重试！");
				return;
			}
			if (Singleton<全局变量类>.I.网关Config.Is送娃娃)
			{
				int num5 = num2 * 4 - 4;
				string text14 = string.Format("{0:X08}", result + 10101);
				text11 = "1:\"娃娃:1:0:0::%s:\",".Replace("%s", text14);
				string text15 = ":" + text14 + ":";
				string value2 = "([\"carry\":([]),\"attrib\":([\"food\":10000,\"mood\":10000,\"refresh_stamina_time\":1568464012,\"gender\":2,\"status\":0,\"life\":23962,\"attack_speed\":4,\"combat_mode\":7,\"max_stamina\":200,\"pot\":0,\"max_mood\":10000,\"phy_effect\":100,\"exp_to_next_level\":0,\"level_up_time\":1560364099,\"str\":%s,\"max_food\":10000,\"stamina\":200,\"dex\":%s,\"def\":2604,\"icon\":7015,\"max_limit_level\":165,\"lock_exp\":0,\"repair_ver\":6,\"intimacy\":%s,\"phy_power\":7326,\"capacity\":%s,\"mag_power\":7328,\"train_process\":0,\"str_effect\":100,\"birthday\":%s,\"dodge\":11,\"iid\"::%s:,\"rank\":6,\"physique\":%s,\"wisdom\":%s,\"wit_effect\":100,\"mana\":1000,\"use_skill\":([]),\"name\":\"[名字]娃娃\",\"parents\":({\"%s\",}),\"level\":%s,\"max_life\":23962,\"stamina_effect\":100,\"dex_effect\":100,\"exp\":0,\"max_mana\":0,\"health\":0,\"portrait\":7015,]),\"skills\":([]),])".Replace("[名字]", 昵称 + "的");
				string[] infos3 = new string[10]
				{
					num2.ToString(),
					num2.ToString(),
					Singleton<全局变量类>.I.网关Config.娃娃亲密.ToString(),
					num5.ToString(),
					问道数据类.GetTimeChuo(bflag: true),
					text14,
					num2.ToString(),
					num2.ToString(),
					text9,
					num2.ToString()
				};
				value2 = 问道数据类.GetStringRe(value2, "%s", infos3);
				dataChecksum = GetDataChecksum("child" + text15 + value2);
				num = c1ZNsjqlRc(mySqlConnection, string.Format("INSERT INTO dl_ddb_1.data(path,name,branch,content,checksum)  VALUES('child','{0}','','{1}','{2}')", text15, value2, dataChecksum));
				if (num < 0)
				{
					Log.Error("角色娃娃数据生成失败！");
					回调事件?.Invoke("角色娃娃数据生成失败，请稍后重试！");
					return;
				}
			}
			if (Singleton<全局变量类>.I.网关Config.Is送守护)
			{
				text12 = "0:\"0:([\\\"attrib\\\":([106:2,107:12409,108:91954,104:2,76:5,72:5004,68:1302716,67:%s,66:6171,64:0,75:34,71:20,69:6100,53:0,52:110,51:34277,49:495,48:236555,63:165,62:4,61:5004,60:0,58:0,57:0,56:0,55:2,47:0,44:165,37:34277,36:2171,35:5,33::%s:,22:30868,21:59039,16:18921,31:190,5:420,3:360,2:236555,]),])\",";
				string text16 = "5D77E13A0002" + string.Format("{0:X08}", result);
				string[] infos4 = new string[2]
				{
					Singleton<全局变量类>.I.网关Config.守护亲密.ToString(),
					text16
				};
				text12 = 问道数据类.GetStringRe(text12, "%s", infos4);
			}
			text13 = "([\"pets\":([宠物]),\"guards\":([%s]),\"friends\":([\"5\":([]),\"4\":([]),\"3\":([]),\"2\":([]),\"1\":([]),\"6\":([]),]),\"children\":([%s]),\"practice_children\":([]),\"practice_pets\":([]),])";
			string[] infos5 = new string[2] { text12, text11 };
			text13 = 问道数据类.GetStringRe(text13, "%s", infos5).Replace("宠物", "");
			dataChecksum = GetDataChecksum("user" + text9 + "patch" + text13);
			num = c1ZNsjqlRc(mySqlConnection, string.Format("INSERT INTO dl_ddb_1.data(path,name,branch,content,checksum) VALUES('user','{0}','patch','{1}','{2}')", text9, text13.Replace("\\", "\\\\"), dataChecksum));
			if (num < 0)
			{
				Log.Error("角色宠物数据生成失败！");
				回调事件?.Invoke("角色宠物数据生成失败，请稍后重试！");
				return;
			}
			string text17 = "([\"rec_role\":\"%s\",\"create_time\":1556371353,\"chars\":({\"%s\",}),\"safe_status\":0,\"register_time\":0,])";
			text17 = text17.Replace("%s", text9);
			dataChecksum = GetDataChecksum("login" + 账号 + text17);
			num = c1ZNsjqlRc(mySqlConnection, string.Format("INSERT INTO dl_ddb_1.data(path,name,branch,content,checksum)  VALUES('login','{0}','','{1}','{2}')", 账号, text17, dataChecksum));
			if (num < 0)
			{
				Log.Error("角色登录数据生成失败！");
				回调事件?.Invoke("角色登录数据生成失败，请稍后重试！");
				return;
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(131, 6);
			defaultInterpolatedStringHandler.AppendLiteral("INSERT INTO dl_adb_all.yjzcxx(account,pass,aqpass,yzm,zcname,zclv,zcip,zcmac,zcqq,zctime) VALUES('");
			defaultInterpolatedStringHandler.AppendFormatted(账号);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(密码);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(安全码);
			defaultInterpolatedStringHandler.AppendLiteral("','GMzc','");
			defaultInterpolatedStringHandler.AppendFormatted(昵称);
			defaultInterpolatedStringHandler.AppendLiteral("','");
			defaultInterpolatedStringHandler.AppendFormatted(num2);
			defaultInterpolatedStringHandler.AppendLiteral("','','','','");
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("')");
			num = c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear());
			if (num < 0)
			{
				Log.Error("角色完整数据生成失败！");
				回调事件?.Invoke("角色完整数据生成失败，请稍后重试！");
				return;
			}
			ConcurrentList<注册信息> 注册列表 = Singleton<全局变量类>.I.注册列表;
			注册信息 obj = new 注册信息
			{
				账号 = 账号,
				密码 = 密码,
				安全码 = 安全码,
				名字 = 昵称,
				等级 = 等级,
				IP = "",
				Mac = "",
				qq = ""
			};
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			obj.注册时间 = defaultInterpolatedStringHandler.ToStringAndClear();
			注册列表.Add(obj);
			回调事件?.Invoke((num > 0) ? "注册成功！" : "注册失败！");
		}
		catch (Exception ex2)
		{
			Log.Error("后台注册GM账号事件-错误：" + ex2.Message);
		}
	}

	
	public void 网关修改密码事件(string 账号, string 安全码, string 密码, Action<bool, string> 回调事件 = null)
	{
		try
		{
			if (账号.Length > 16 || 密码.Length > 16 || 安全码.Length > 16)
			{
				回调事件?.Invoke(arg1: false, "账号或安全码的信息有敏感词，请重新输入（仅限数字、英文）");
				return;
			}
			if (Singleton<ByteAPI>.I.寻找文本或(账号, "GM", "gm", "Gm", "gM", "客服", "群", "裙", "君羊", "null", "企", "鹅"))
			{
				回调事件?.Invoke(arg1: false, "账号有敏感词，请重新输入（仅限数字、英文）");
				return;
			}
			if (Singleton<ByteAPI>.I.寻找文本或(安全码, ",", "/", "\\", "'", "‘", "or", "is", "_", "-", "@", "where"))
			{
				回调事件?.Invoke(arg1: false, "安全码有敏感词，请重新输入（仅限数字和英文）");
				return;
			}
			if (Singleton<ByteAPI>.I.寻找文本或(密码, ",", "/", "\\", "'", "‘", "or", "is", "_", "-", "@", "where"))
			{
				回调事件?.Invoke(arg1: false, "密码有敏感词，请重新输入（仅限数字和英文）");
				return;
			}
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			_ = string.Empty;
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("网关注册账号事件-mysql数据库连接失败！");
				回调事件?.Invoke(arg1: false, "数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			if (!string.IsNullOrWhiteSpace(账号))
			{
				using (MySqlCommand mySqlCommand = new MySqlCommand("select * from account where account=@account", mySqlConnection))
				{
					mySqlCommand.Parameters.AddWithValue("@account", 账号);
					using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
					if (mySqlDataReader == null)
					{
						回调事件?.Invoke(arg1: false, "账号不存在！");
						return;
					}
					if (!mySqlDataReader.Read())
					{
						mySqlDataReader.Close();
						回调事件?.Invoke(arg1: false, "账号不存在！");
						return;
					}
					ujjNRZ9vuH(mySqlDataReader["account"].ToString());
					string text = ujjNRZ9vuH(mySqlDataReader["memo"].ToString());
					int.Parse(mySqlDataReader["gold_coin"].ToString());
					int.Parse(mySqlDataReader["silver_coin"].ToString());
					int.Parse(mySqlDataReader["privilege"].ToString());
					if (安全码 != text)
					{
						回调事件?.Invoke(arg1: false, "安全码错误！");
						return;
					}
				}
				string mD5Info = GetMD5Info(账号 + GetMD5Info(密码) + "20070201");
				if (c1ZNsjqlRc(mySqlConnection, string.Format("UPDATE account SET password='{0}'  where account='{1}'", mD5Info, 账号)) != -1)
				{
					c1ZNsjqlRc(mySqlConnection, AccChecksum(账号));
				}
				回调事件?.Invoke(arg1: true, "密码修改成功！");
			}
			else
			{
				回调事件?.Invoke(arg1: false, "提交的信息有误！");
			}
		}
		catch (Exception ex)
		{
			Log.Error("网关修改密码事件-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	public bool 锁定账号操作(string 账号, string 状态)
	{
		try
		{
			using MySqlConnection mySqlConnection = new MySqlConnection(adbsql1);
			_ = string.Empty;
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("锁定账号[" + 账号 + "]操作失败！");
				return false;
			}
			o51NJkPfKI(mySqlConnection);
			if (!string.IsNullOrWhiteSpace(账号))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
				defaultInterpolatedStringHandler.AppendLiteral("update account set locked='");
				defaultInterpolatedStringHandler.AppendFormatted(状态);
				defaultInterpolatedStringHandler.AppendLiteral("' where account ='");
				defaultInterpolatedStringHandler.AppendFormatted(账号);
				defaultInterpolatedStringHandler.AppendLiteral("';");
				return c1ZNsjqlRc(mySqlConnection, defaultInterpolatedStringHandler.ToStringAndClear()) > 0;
			}
			return false;
		}
		catch (Exception ex)
		{
			Log.Error("锁定账号操作-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	public async Task<bool> 锁定账号操作异步(string 账号, string 状态)
	{
		try
		{
			if (string.IsNullOrWhiteSpace(账号))
			{
				return false;
			}
			using MySqlConnection conn = new MySqlConnection(adbsql1);
			_ = string.Empty;
			conn.Open();
			if (conn.State != ConnectionState.Open)
			{
				Log.Error("锁定账号[" + 账号 + "]操作失败！");
				return false;
			}
			o51NJkPfKI(conn);
			DB dB = this;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
			defaultInterpolatedStringHandler.AppendLiteral("update account set locked='");
			defaultInterpolatedStringHandler.AppendFormatted(状态);
			defaultInterpolatedStringHandler.AppendLiteral("' where account ='");
			defaultInterpolatedStringHandler.AppendFormatted(账号);
			defaultInterpolatedStringHandler.AppendLiteral("';");
			int 更新结果 = dB.c1ZNsjqlRc(conn, defaultInterpolatedStringHandler.ToStringAndClear());
			await Task.Delay(1);
			return 更新结果 > 0;
		}
		catch (Exception ex)
		{
			Log.Error("锁定账号操作-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	public string 修复背包9211操作(string content)
	{
		try
		{
			string value = Singleton<ByteAPI>.I.文本_取出中间文本(content, ",206:\\\"", ",");
			bool flag = !string.IsNullOrWhiteSpace(value);
			if (!flag)
			{
				return content;
			}
			while (flag)
			{
				value = Singleton<ByteAPI>.I.文本_取出中间文本(content, ",206:\\\"", ",");
				content = content.Replace(",206:\\\"" + value + ",", ",");
				flag = content.Contains(",206:\\\"", StringComparison.CurrentCulture);
				if (!flag)
				{
					break;
				}
			}
			return content;
		}
		catch (Exception ex)
		{
			Log.Error("修复背包9211操作-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return content;
		}
	}

	
	public async Task 更新强力守护操作(string 账号, string GID, string 守护数据)
	{
		try
		{
			string text = string.Empty;
			using MySqlConnection conn = new MySqlConnection(ddbsql2);
			conn.Open();
			if (conn.State != ConnectionState.Open)
			{
				Log.Error("GID取宠物数据-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(conn);
			using MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path='user' and branch='patch' and name='" + GID + "' ";
			using MySqlDataReader 查询结果 = cmd.ExecuteReader();
			if (查询结果 == null)
			{
				return;
			}
			if (查询结果.Read())
			{
				text = XEYNKGEPKJ((byte[])查询结果["bytedata"]);
			}
			查询结果.Close();
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：守护召唤前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(账号);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(账号, defaultInterpolatedStringHandler.ToStringAndClear());
			if (!text.Contains("\"guards\":([", StringComparison.CurrentCulture))
			{
				return;
			}
			string[] array = text.Split("\"guards\":([");
			if (!array[1].Contains("\"friends\"", StringComparison.CurrentCulture))
			{
				return;
			}
			string[] array2 = text.Split("\"friends\"");
			if (array2.Length <= 1)
			{
				return;
			}
			string text2 = array[0] + 守护数据 + array2[1];
			if (string.IsNullOrWhiteSpace(text2))
			{
				return;
			}
			int dataChecksum = GetDataChecksum("user" + GID + "patch" + text2);
			text2 = text2.Replace("\\", "\\\\");
			全局变量类 i2 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：守护召唤后】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(账号);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text2);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i2.异常记录执行(账号, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(92, 3);
			defaultInterpolatedStringHandler.AppendLiteral("UPDATE data SET content='");
			defaultInterpolatedStringHandler.AppendFormatted(text2);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("'  where path = 'user' and branch ='patch' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(GID);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			string text3 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (c1ZNsjqlRc(conn, text3) > -1)
			{
				Log.Debug("更新强力守护操作成功！");
			}
			await Task.Delay(1);
		}
		catch (Exception ex)
		{
			Log.Error("更新强力守护操作-错误：" + ex.Message);
		}
	}

	
	public void 测试数据库文本读取(string 账号, string GID)
	{
		try
		{
			string value = string.Empty;
			using MySqlConnection mySqlConnection = new MySqlConnection(ddbsql2);
			mySqlConnection.Open();
			if (mySqlConnection.State != ConnectionState.Open)
			{
				Log.Error("测试数据库文本读取-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(mySqlConnection);
			using MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = "select CAST(content AS BINARY) AS bin_data from data where path='user' and branch='patch' and name='" + GID + "' ";
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader != null)
			{
				if (mySqlDataReader.Read())
				{
					byte[] bytes = (byte[])mySqlDataReader["bin_data"];
					value = Encoding.GetEncoding(936).GetString(bytes);
				}
				mySqlDataReader.Close();
				全局变量类 i = Singleton<全局变量类>.I;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
				defaultInterpolatedStringHandler.AppendLiteral("【操作：转码前】 【账号：");
				defaultInterpolatedStringHandler.AppendFormatted(账号);
				defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
				i.异常记录执行(账号, defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}
		catch (Exception ex)
		{
			Log.Error("测试数据库文本读取-错误：" + ex.Message);
		}
	}

	
	internal async Task<bool> Jo4iUQtFYN(string P_0, int P_1, string P_2, int P_3)
	{
		try
		{
			using MySqlConnection conn = new MySqlConnection(ddbsql2);
			conn.Open();
			if (conn.State != ConnectionState.Open)
			{
				Log.Error("激活宠物转生属性-mysql数据库连接失败！");
				return false;
			}
			o51NJkPfKI(conn);
			using MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = "select CAST(content AS BINARY) AS bytedata from data where branch ='patch' and name ='" + Singleton<ByteAPI>.I.GetHexGid_(P_1) + "'";
			using MySqlDataReader 查询结果 = cmd.ExecuteReader();
			if (查询结果 == null)
			{
				return false;
			}
			if (!查询结果.Read())
			{
				return false;
			}
			string text = XEYNKGEPKJ((byte[])查询结果["bytedata"]);
			查询结果.Close();
			if (string.IsNullOrWhiteSpace(text))
			{
				return false;
			}
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：宠物转生前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(P_2, defaultInterpolatedStringHandler.ToStringAndClear());
			string text2 = Singleton<ByteAPI>.I.文本_取出中间文本(text, P_0, "])\",");
			if (string.IsNullOrWhiteSpace(text2))
			{
				return false;
			}
			text2 = P_0 + text2 + "])\",";
			string text3 = Singleton<ByteAPI>.I.文本_取出中间文本(text2, ",66:([", "]),");
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text3, "2:", ","), out var result))
			{
				return false;
			}
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text3, "37:", ","), out var result2))
			{
				return false;
			}
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text3, "36:", ","), out var result3))
			{
				return false;
			}
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text3, "108:", ","), out var result4))
			{
				return false;
			}
			if (!int.TryParse(Singleton<ByteAPI>.I.文本_取出中间文本(text3, "107:", ","), out var result5))
			{
				return false;
			}
			result += Math.Abs((result + 40) * P_3 / 100);
			result2 += Math.Abs((result2 + 40) * P_3 / 100);
			result4 += Math.Abs((result4 + 40) * P_3 / 100);
			result5 += Math.Abs((result5 + 40) * P_3 / 100);
			result3 += Math.Abs((result3 + 40) * P_3 / 100);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 5);
			defaultInterpolatedStringHandler.AppendLiteral(",66:([107:");
			defaultInterpolatedStringHandler.AppendFormatted(result5);
			defaultInterpolatedStringHandler.AppendLiteral(",108:");
			defaultInterpolatedStringHandler.AppendFormatted(result4);
			defaultInterpolatedStringHandler.AppendLiteral(",37:");
			defaultInterpolatedStringHandler.AppendFormatted(result2);
			defaultInterpolatedStringHandler.AppendLiteral(",36:");
			defaultInterpolatedStringHandler.AppendFormatted(result3);
			defaultInterpolatedStringHandler.AppendLiteral(",2:");
			defaultInterpolatedStringHandler.AppendFormatted(result);
			defaultInterpolatedStringHandler.AppendLiteral(",]),");
			string newValue = defaultInterpolatedStringHandler.ToStringAndClear();
			string newValue2 = text2.Replace(",66:([" + text3 + "]),", newValue);
			text = text.Replace(text2, newValue2);
			int dataChecksum = GetDataChecksum("user" + Singleton<ByteAPI>.I.GetHexGid_(P_1) + "patch" + text);
			text = text.Replace("\\", "\\\\");
			text = text.Replace("'", "\\'");
			全局变量类 i2 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：宠物转生后】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i2.异常记录执行(P_2, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
			DB dB = this;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(92, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where path = 'user' and  branch ='patch' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(Singleton<ByteAPI>.I.GetHexGid_(P_1));
			defaultInterpolatedStringHandler.AppendLiteral("'");
			return await dB.w3HNUJWfp3(conn, defaultInterpolatedStringHandler.ToStringAndClear()) == 1;
		}
		catch (Exception ex)
		{
			Log.Error("激活宠物转生属性-报错：" + ex.Message + "(" + ex.StackTrace + ")");
			return false;
		}
	}

	
	internal async Task DXLiWhENog(int P_0, string P_1, string P_2, string P_3)
	{
		try
		{
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(P_0);
			using MySqlConnection conn = new MySqlConnection(ddbsql2);
			conn.Open();
			if (conn.State != ConnectionState.Open)
			{
				Log.Error("Mysql_装备男女转换处理-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(conn);
			using MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + hexGid_ + "' ORDER BY name DESC";
			using MySqlDataReader 查询结果 = cmd.ExecuteReader();
			if (查询结果 == null || !查询结果.Read())
			{
				return;
			}
			string text = XEYNKGEPKJ((byte[])查询结果["bytedata"]);
			查询结果.Close();
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：装备男女转换前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear());
			if (!Singleton<ByteAPI>.I.寻找文本(text, P_2))
			{
				return;
			}
			string text2 = Singleton<ByteAPI>.I.文本_取出中间文本(text, P_2, "])\",");
			string oldValue = P_2 + text2 + "])\",";
			string newValue = P_3 + text2 + "])\",";
			text = text.Replace(oldValue, newValue);
			int dataChecksum = GetDataChecksum("user" + hexGid_ + "carry" + text);
			text = text.Replace("\\", "\\\\");
			全局变量类 i2 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：装备男女转换后】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i2.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
			DB dB = this;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where branch ='carry' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(hexGid_);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			dB.c1ZNsjqlRc(conn, defaultInterpolatedStringHandler.ToStringAndClear());
			await Task.Delay(10);
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_装备男女转换处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal async Task JTbigvkj7R(int P_0, string P_1, string P_2, string P_3, int P_4, int P_5)
	{
		try
		{
			string hexGid_ = Singleton<ByteAPI>.I.GetHexGid_(P_0);
			using MySqlConnection conn = new MySqlConnection(ddbsql2);
			conn.Open();
			if (conn.State != ConnectionState.Open)
			{
				Log.Error("Mysql_法宝亲密互换处理-mysql数据库连接失败！");
				return;
			}
			o51NJkPfKI(conn);
			using MySqlCommand cmd = new MySqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = "select CAST(content AS BINARY) AS bytedata from data where path = 'user' and branch ='carry' and name ='" + hexGid_ + "' ORDER BY name DESC";
			using MySqlDataReader 查询结果 = cmd.ExecuteReader();
			if (查询结果 == null || !查询结果.Read())
			{
				return;
			}
			string text = XEYNKGEPKJ((byte[])查询结果["bytedata"]);
			查询结果.Close();
			全局变量类 i = Singleton<全局变量类>.I;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：法宝亲密互换前】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear());
			if (!Singleton<ByteAPI>.I.寻找文本与(text, P_2, P_3))
			{
				return;
			}
			string text2 = P_2 + Singleton<ByteAPI>.I.文本_取出中间文本(text, P_2, "])\",") + "])\",";
			string text3 = P_3 + Singleton<ByteAPI>.I.文本_取出中间文本(text, P_3, "])\",") + "])\",";
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral(",280:");
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			string oldValue = defaultInterpolatedStringHandler.ToStringAndClear();
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral(",280:");
			defaultInterpolatedStringHandler.AppendFormatted(P_5);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			string newValue = text2.Replace(oldValue, defaultInterpolatedStringHandler.ToStringAndClear());
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral(",280:");
			defaultInterpolatedStringHandler.AppendFormatted(P_5);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			string oldValue2 = defaultInterpolatedStringHandler.ToStringAndClear();
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral(",280:");
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			string newValue2 = text3.Replace(oldValue2, defaultInterpolatedStringHandler.ToStringAndClear());
			text = text.Replace(text2, newValue);
			text = text.Replace(text3, newValue2);
			int dataChecksum = GetDataChecksum("user" + hexGid_ + "carry" + text);
			text = text.Replace("\\", "\\\\");
			全局变量类 i2 = Singleton<全局变量类>.I;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
			defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
			defaultInterpolatedStringHandler.AppendLiteral("  【操作：法宝亲密互换后】 【账号：");
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral("】 【数据：");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("】\n\r");
			i2.异常记录执行(P_1, defaultInterpolatedStringHandler.ToStringAndClear(), 是否清空: false);
			DB dB = this;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(73, 3);
			defaultInterpolatedStringHandler.AppendLiteral("update data set content='");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("',checksum='");
			defaultInterpolatedStringHandler.AppendFormatted(dataChecksum);
			defaultInterpolatedStringHandler.AppendLiteral("' where branch ='carry' and name ='");
			defaultInterpolatedStringHandler.AppendFormatted(hexGid_);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			dB.c1ZNsjqlRc(conn, defaultInterpolatedStringHandler.ToStringAndClear());
			await Task.Delay(10);
		}
		catch (Exception ex)
		{
			Log.Error("Mysql_法宝亲密互换处理-报错：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	static DB()
	{
		sqlTolatin1 = "set names latin1";
		allsql = string.Empty;
		adbsql1 = string.Empty;
		ddbsql2 = string.Empty;
		B区连接 = string.Empty;
		s25ijnJt0L = new object();
		LiqileM5Re = new object();
		zl7i8BHLMm = new object();
	}
}
