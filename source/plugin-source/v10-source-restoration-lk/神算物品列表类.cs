public class 神算物品列表类
{
	public short 下标;

	public string 名字 = string.Empty;

	public int 物品数量 = 1;

	public int 图标;

	public int 售罄图标;

	public int 价值;

	public int 物品份数 = 1;

	public int 已出份数;

	public bool 开启谣言;

	public string 单位 = "个";

	public string 道具描述 = string.Empty;

	public byte[] 内部组包()
	{
		封包_写 封包_写2 = new 封包_写();
		封包_写2.写短整数型(下标, reverse: true);
		封包_写2.写字节型(1);
		封包_写2.写整数型(0, reverse: true);
		封包_写2.写短整数型(1, reverse: true);
		封包_写2.写短整数型(1, reverse: true);
		封包_写2.写短整数型(15, reverse: true);
		封包_写2.写短整数型(264, reverse: true);
		封包_写2.写字节型(4);
		封包_写2.写文本型($"#Y已出份数：#R{已出份数}#n份#r#Y奖品份数：#L{物品份数}#n份{((已出份数 >= 物品份数) ? "#r#R【已售罄】#n" : string.Empty)}#r{道具描述}", hasCount: true, 0);
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
		封包_写2.写整数型(下标, reverse: true);
		封包_写2.写短整数型(209, reverse: true);
		封包_写2.写字节型(4);
		封包_写2.写文本型("金色", hasCount: true, 0);
		封包_写2.写字节集(new byte[24]
		{
			1, 108, 2, 0, 0, 0, 41, 3, 0, 0,
			0, 8, 0, 203, 2, 0, 1, 1, 150, 3,
			0, 0, 0, 0
		}, hasCount: false, 0);
		封包_写2.写短整数型(40, reverse: true);
		封包_写2.写字节型(3);
		封包_写2.写整数型((已出份数 < 物品份数) ? 图标 : ((售罄图标 != 0) ? 售罄图标 : (420000000 + 图标)), reverse: true);
		封包_写2.写字节集(new byte[11]
		{
			1, 252, 1, 0, 0, 207, 3, 0, 0, 0,
			0
		}, hasCount: false, 0);
		return 封包_写2.取数据();
	}
}
