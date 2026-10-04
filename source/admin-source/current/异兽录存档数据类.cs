using System.Collections.Concurrent;
using System.Collections.Generic;

public class 异兽录存档数据类
{
	public ConcurrentDictionary<AllEnums.异兽Type, bool> 分类圆满状态 = new ConcurrentDictionary<AllEnums.异兽Type, bool>();

	public ConcurrentDictionary<AllEnums.异兽Type, List<string>> 收录列表 = new ConcurrentDictionary<AllEnums.异兽Type, List<string>>();

	public 异兽录存档数据类()
	{
		分类圆满状态.TryAdd(AllEnums.异兽Type.御灵, value: false);
		分类圆满状态.TryAdd(AllEnums.异兽Type.变异, value: false);
		分类圆满状态.TryAdd(AllEnums.异兽Type.神兽, value: false);
		分类圆满状态.TryAdd(AllEnums.异兽Type.元灵, value: false);
		分类圆满状态.TryAdd(AllEnums.异兽Type.仙元, value: false);
		收录列表.TryAdd(AllEnums.异兽Type.御灵, new List<string>());
		收录列表.TryAdd(AllEnums.异兽Type.变异, new List<string>());
		收录列表.TryAdd(AllEnums.异兽Type.神兽, new List<string>());
		收录列表.TryAdd(AllEnums.异兽Type.元灵, new List<string>());
		收录列表.TryAdd(AllEnums.异兽Type.仙元, new List<string>());
	}

	public void 清空()
	{
		收录列表.Clear();
		分类圆满状态.Clear();
		分类圆满状态.TryAdd(AllEnums.异兽Type.御灵, value: false);
		分类圆满状态.TryAdd(AllEnums.异兽Type.变异, value: false);
		分类圆满状态.TryAdd(AllEnums.异兽Type.神兽, value: false);
		分类圆满状态.TryAdd(AllEnums.异兽Type.元灵, value: false);
		分类圆满状态.TryAdd(AllEnums.异兽Type.仙元, value: false);
		收录列表.TryAdd(AllEnums.异兽Type.御灵, new List<string>());
		收录列表.TryAdd(AllEnums.异兽Type.变异, new List<string>());
		收录列表.TryAdd(AllEnums.异兽Type.神兽, new List<string>());
		收录列表.TryAdd(AllEnums.异兽Type.元灵, new List<string>());
		收录列表.TryAdd(AllEnums.异兽Type.仙元, new List<string>());
	}
}
