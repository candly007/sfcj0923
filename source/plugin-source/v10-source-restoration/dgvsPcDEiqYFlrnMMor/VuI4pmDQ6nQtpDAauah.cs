using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Serilog;
using vEAdPGPTkDFOYsbi303;

namespace dgvsPcDEiqYFlrnMMor;

internal class VuI4pmDQ6nQtpDAauah : Singleton<VuI4pmDQ6nQtpDAauah>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public byte[] zBl5rP0CN3;

		
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		
		internal bool n1Y5qqlNgx(超级坐骑列表类 a)
		{
			return Singleton<ByteAPI>.I.寻找字节集(zBl5rP0CN3, Singleton<ByteAPI>.I.到字节集固定反转(a.坐骑编号));
		}

		static _003C_003Ec__DisplayClass7_0()
		{
		}
	}

	
	internal void XndD3HYHh6()
	{
		try
		{
			if (File.Exists(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级坐骑配置类.json")))
			{
				Singleton<全局变量类>.I.超级坐骑配置 = JsonConvert.DeserializeObject<超级坐骑配置类>(File.ReadAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级坐骑配置类.json")));
				return;
			}
			Singleton<全局变量类>.I.超级坐骑配置 = new 超级坐骑配置类();
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级坐骑配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级坐骑配置, Formatting.Indented));
		}
		catch (Exception ex)
		{
			Log.Error("超级坐骑配置读取失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal void kEZDYIgoB2()
	{
		try
		{
			File.WriteAllText(mEdebOPadFyb5ykL5Wy.W80P9ipOVU("超级坐骑配置类.json"), JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级坐骑配置, Formatting.Indented));
			Log.Debug("超级坐骑配置保存完毕！");
		}
		catch (Exception ex)
		{
			Log.Error("超级坐骑配置保存失败：" + ex.Message + "(" + ex.StackTrace + ")");
		}
	}

	
	internal string xV4DpjcO6v()
	{
		XndD3HYHh6();
		return JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级坐骑配置, Formatting.Indented);
	}

	
	public void blHD1QtAhD(string P_0)
	{
		Singleton<全局变量类>.I.超级坐骑配置 = JsonConvert.DeserializeObject<超级坐骑配置类>(P_0);
		kEZDYIgoB2();
	}

	
	public void ROnDxwkop8(byte[] P_0, ref byte[] P_1)
	{
		if (Singleton<ByteAPI>.I.寻找字节集(P_1, new byte[9] { 0, 0, 0, 0, 2, 0, 0, 0, 0 }) && Singleton<全局变量类>.I.超级坐骑配置.超级坐骑编号列表.TryGetValue(Singleton<ByteAPI>.I.反转_整数(P_0), out 超级坐骑列表类 value) && value.飞行编号 != 0)
		{
			P_1 = Singleton<ByteAPI>.I.寻找字节集并替换(P_1, new byte[4] { 4, 0, 1, 2 }, new byte[4] { 4, 0, 1, 0 });
			P_1 = Singleton<ByteAPI>.I.寻找字节集并替换(P_1, new byte[4] { 4, 0, 1, 1 }, new byte[4] { 4, 0, 1, 0 });
			P_1 = Singleton<ByteAPI>.I.寻找字节集并替换(P_1, new byte[4] { 4, 0, 0, 2 }, new byte[4] { 4, 0, 0, 0 });
			P_1 = Singleton<ByteAPI>.I.寻找字节集并替换(P_1, new byte[4] { 4, 0, 0, 1 }, new byte[4] { 4, 0, 0, 0 });
			P_1 = Singleton<ByteAPI>.I.寻找字节集并替换(P_1, P_0, Singleton<ByteAPI>.I.到字节集固定反转(value.飞行编号));
		}
	}

	
	public int xGWDHubVgk(int P_0, int P_1, ref bool P_2)
	{
		if (Singleton<全局变量类>.I.超级坐骑配置.功能开关 && P_1 != 0 && Singleton<全局变量类>.I.超级坐骑配置.超级坐骑编号列表.TryGetValue(P_0, out 超级坐骑列表类 value) && value.飞行编号 != 0)
		{
			P_2 = true;
			P_0 = value.飞行编号;
		}
		return P_0;
	}

	
	public int u3pD4VJ8HA(int P_0)
	{
		if (Singleton<全局变量类>.I.超级坐骑配置.功能开关 && Singleton<全局变量类>.I.超级坐骑配置.超级坐骑编号列表.TryGetValue(P_0, out 超级坐骑列表类 value) && value.战斗编号 != 0)
		{
			P_0 = value.战斗编号;
		}
		return P_0;
	}

	
	public byte[] IFBDeeKFGq(MyNATSocketClient P_0, byte[] P_1)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals5.zBl5rP0CN3 = P_1;
		超级坐骑列表类 超级坐骑列表类2 = Singleton<全局变量类>.I.超级坐骑配置.超级坐骑编号列表.Values.ToList().Find( (超级坐骑列表类 a) => Singleton<ByteAPI>.I.寻找字节集(CS_0024_003C_003E8__locals5.zBl5rP0CN3, Singleton<ByteAPI>.I.到字节集固定反转(a.坐骑编号)));
		if (超级坐骑列表类2 != null)
		{
			CS_0024_003C_003E8__locals5.zBl5rP0CN3 = Singleton<ByteAPI>.I.寻找字节集并替换(CS_0024_003C_003E8__locals5.zBl5rP0CN3, Singleton<ByteAPI>.I.到字节集固定反转(超级坐骑列表类2.坐骑编号), Singleton<ByteAPI>.I.到字节集固定反转(超级坐骑列表类2.战斗编号));
		}
		return CS_0024_003C_003E8__locals5.zBl5rP0CN3;
	}

	
	public VuI4pmDQ6nQtpDAauah()
	{
	}

	static VuI4pmDQ6nQtpDAauah()
	{
	}
}
