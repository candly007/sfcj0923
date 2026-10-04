using System;

public class 鸿运物品列表类
{
	public short 下标;

	public AllEnums.数值Type 分类;

	public int 物品数量 = 1;

	public int 盲盒份数 = 1;

	public int 商店类型 = 7;

	public string 名字 = string.Empty;

	public int 价格;

	public int 图标;

	public AllEnums.颜色Type 颜色 = AllEnums.颜色Type.金色;

	public string 单位 = "个";

	public string 道具描述 = string.Empty;

	public bool 是否叠加;

	public bool 是否限购;

	public int 限购数量;

	internal byte[] _物品封包 = Array.Empty<byte>();

	public byte[] 物品封包
	{
		get
		{
			if (_物品封包 == Array.Empty<byte>())
			{
				内部组包();
			}
			return _物品封包;
		}
	}

	private void 内部组包()
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写短整数型(下标, reverse: true);
		封包_写2.写字节型(商店类型);
		封包_写2.写整数型(价格, reverse: true);
		封包_写2.写短整数型(1, reverse: true);
		封包_写2.写短整数型(1, reverse: true);
		封包_写2.写短整数型(15, reverse: true);
		封包_写2.写短整数型(264, reverse: true);
		封包_写2.写字节型(4);
		封包_写2.写文本型(道具描述, hasCount: true, 0);
		封包_写2.写短整数型(1, reverse: true);
		封包_写2.写字节型(4);
		封包_写2.写文本型(名字, hasCount: true, 0);
		封包_写2.写字节集(new byte[7] { 0, 206, 3, 0, 0, 0, 1 }, hasCount: false, 0);
		封包_写2.写短整数型(311, reverse: true);
		封包_写2.写字节型(4);
		封包_写2.写文本型(单位, hasCount: true, 0);
		封包_写2.写字节集(new byte[12]
		{
			0, 38, 3, 0, 0, 0, 0, 0, 74, 7,
			0, 10
		}, hasCount: false, 0);
		封包_写2.写短整数型(84, reverse: true);
		封包_写2.写字节型(3);
		封包_写2.写整数型(1000000 + 下标, reverse: true);
		封包_写2.写短整数型(209, reverse: true);
		封包_写2.写字节型(4);
		封包_写2.写文本型(颜色.ToString(), hasCount: true, 0);
		封包_写2.写字节集(new byte[24]
		{
			1, 108, 2, 0, 0, 0, 41, 3, 0, 0,
			0, 8, 0, 203, 2, 0, 1, 1, 150, 3,
			0, 0, 0, 0
		}, hasCount: false, 0);
		封包_写2.写短整数型(40, reverse: true);
		封包_写2.写字节型(3);
		封包_写2.写整数型(图标, reverse: true);
		封包_写2.写字节集(new byte[11]
		{
			1, 252, 1, 0, 0, 207, 3, 0, 0, 0,
			0
		}, hasCount: false, 0);
		_物品封包 = 封包_写2.取数据();
	}
}
