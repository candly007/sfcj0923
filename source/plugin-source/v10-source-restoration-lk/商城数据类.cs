using System;

public class 商城数据类
{
	public string 商品条码 = string.Empty;

	public string 名字 = string.Empty;

	public int 限购数量 = -1;

	public int 编号;

	public byte 所在类别;

	public byte 花费类型;

	public bool is银元宝购买;

	public int 价格;

	public byte[] 物品封包 = Array.Empty<byte>();
}
