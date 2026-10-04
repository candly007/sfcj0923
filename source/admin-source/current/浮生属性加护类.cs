public class 浮生属性加护类
{
	public int 金相性;

	public int 木相性;

	public int 水相性;

	public int 火相性;

	public int 土相性;

	internal void Add(浮生属性加护类 属性)
	{
		金相性 += 属性.金相性;
		木相性 += 属性.木相性;
		水相性 += 属性.水相性;
		火相性 += 属性.火相性;
		土相性 += 属性.土相性;
	}

	internal void Clear()
	{
		金相性 = 0;
		木相性 = 0;
		水相性 = 0;
		火相性 = 0;
		土相性 = 0;
	}
}
