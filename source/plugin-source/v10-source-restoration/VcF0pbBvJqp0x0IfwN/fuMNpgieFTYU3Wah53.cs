using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using KEvDjBdeoLOoBKWXFAH;
using ixYEhcwWIdwrtDxOO94;
using uI75fJjR7A2e7wWdq9f;

namespace VcF0pbBvJqp0x0IfwN;

internal class fuMNpgieFTYU3Wah53 : Singleton<fuMNpgieFTYU3Wah53>
{
	
	[SpecialName]
	public static bool BojPVlpN4()
	{
		if (!zeYnwTjKgpmAbfSQh5J.ARHjmZgHJU() && !iRGieud4qtscW6ESmxk.C9dsD7Vloy() && !浮生录功能.J7aWuMQOCf())
		{
			return MbtVicwUkp5LuxTooFW.EaewmWn7Ul();
		}
		return true;
	}

	
	public void rPGGaUKqN(MyNATSocketClient P_0, int P_1)
	{
		List<string[]> list = new List<string[]>();
		list.Add(new string[2]
		{
			"durability",
			"10000"
		});
		list.Add(new string[2]
		{
			"open_nimbus",
			"1"
		});
		List<string[]> list2 = list;
		foreach (KeyValuePair<AllEnums.属性名字Type, int> item in P_0.user.存档数据.中州论道存档.属性列表)
		{
			string[] array = new string[2];
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler.AppendLiteral("prop/");
			defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)item.Key);
			array[0] = defaultInterpolatedStringHandler.ToStringAndClear();
			array[1] = item.Value.ToString();
			list2.Add(array);
		}
		Singleton<WdAPI>.I.NNfIVUuyWv(P_0, P_1, list2);
	}

	
	public void mMMfZ3LX2(MyNATSocketClient P_0, List<string[]> P_1)
	{
		Singleton<WdAPI>.I.NNfIVUuyWv(P_0, 8, P_1);
		刷新人物面板(P_0);
	}

	
	public void efa62ixfA(MyNATSocketClient P_0, string[] P_1)
	{
		Singleton<WdAPI>.I.Mr8ICwW3qX(P_0, 8, P_1[0], P_1[1]);
		刷新人物面板(P_0);
	}

	
	public void WFU2WhwnC(MyNATSocketClient P_0, string P_1, string P_2)
	{
		Singleton<WdAPI>.I.Mr8ICwW3qX(P_0, 8, P_1, P_2);
		刷新人物面板(P_0);
	}

	
	public void KIdmWo2NZ(MyNATSocketClient P_0, AllEnums.属性名字Type P_1, string P_2)
	{
		WdAPI i = Singleton<WdAPI>.I;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
		defaultInterpolatedStringHandler.AppendLiteral("prop/");
		defaultInterpolatedStringHandler.AppendFormatted((AllEnums.属性标识Type)P_1);
		i.Mr8ICwW3qX(P_0, 8, defaultInterpolatedStringHandler.ToStringAndClear(), P_2);
		刷新人物面板(P_0);
	}

	
	private async void 刷新人物面板(MyNATSocketClient myclient)
	{
		DB.I.oMuiwEHr6E(myclient.user.人物数据.GID, myclient.user.存档数据);
		myclient.S_Send(new byte[26]
		{
			77, 90, 0, 0, 0, 0, 0, 0, 0, 4,
			37, 26, 0, 8, 77, 90, 0, 0, 0, 0,
			0, 0, 0, 2, 18, 38
		}, "刷新人物面板");
		myclient.user.缓存数据.Is梭子刷新属性 = true;
		await Task.Delay(1000);
		myclient.user.缓存数据.Is梭子刷新属性 = false;
	}

	
	public fuMNpgieFTYU3Wah53()
	{
	}

	static fuMNpgieFTYU3Wah53()
	{
	}
}
