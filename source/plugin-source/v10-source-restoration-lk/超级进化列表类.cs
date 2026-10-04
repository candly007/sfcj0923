public class 超级进化列表类
{
	public AllEnums.属性名字Type 属性名字;

	public bool 是否启用;

	public int 进化数值89;

	public int 进化数值90;

	public int 进化数值99;

	public int 进化数值100;

	public int 进化数值109;

	public int 进化数值110;

	public int 进化数值119;

	public int 进化数值120;

	public int 进化数值129;

	public int 进化数值130;

	public int 进化数值139;

	public int 进化数值140;

	public int 进化数值149;

	public int 进化数值150;

	public int 进化数值159;

	public int 进化数值160;

	public int 进化数值169;

	public int 进化数值170;

	public int 进化数值179;

	public int 进化数值180;

	public int 进化数值189;

	public int 进化数值190;

	public int 进化数值199;

	public bool Is可进化(int 装备等级, int 当前数值)
	{
		switch (装备等级)
		{
		case 89:
			if (进化数值89 != 0)
			{
				return 进化数值89 > 当前数值;
			}
			return false;
		case 90:
			if (进化数值90 != 0)
			{
				return 进化数值90 > 当前数值;
			}
			return false;
		case 99:
			if (进化数值99 != 0)
			{
				return 进化数值99 > 当前数值;
			}
			return false;
		case 100:
			if (进化数值100 != 0)
			{
				return 进化数值100 > 当前数值;
			}
			return false;
		case 109:
			if (进化数值109 != 0)
			{
				return 进化数值109 > 当前数值;
			}
			return false;
		case 110:
			if (进化数值110 != 0)
			{
				return 进化数值110 > 当前数值;
			}
			return false;
		case 119:
			if (进化数值119 != 0)
			{
				return 进化数值119 > 当前数值;
			}
			return false;
		case 120:
			if (进化数值120 != 0)
			{
				return 进化数值120 > 当前数值;
			}
			return false;
		case 129:
			if (进化数值129 != 0)
			{
				return 进化数值129 > 当前数值;
			}
			return false;
		case 130:
			if (进化数值130 != 0)
			{
				return 进化数值130 > 当前数值;
			}
			return false;
		case 139:
			if (进化数值139 != 0)
			{
				return 进化数值139 > 当前数值;
			}
			return false;
		case 140:
			if (进化数值140 != 0)
			{
				return 进化数值140 > 当前数值;
			}
			return false;
		case 149:
			if (进化数值149 != 0)
			{
				return 进化数值149 > 当前数值;
			}
			return false;
		case 150:
			if (进化数值150 != 0)
			{
				return 进化数值150 > 当前数值;
			}
			return false;
		case 159:
			if (进化数值159 != 0)
			{
				return 进化数值159 > 当前数值;
			}
			return false;
		case 160:
			if (进化数值160 != 0)
			{
				return 进化数值160 > 当前数值;
			}
			return false;
		case 169:
			if (进化数值169 != 0)
			{
				return 进化数值169 > 当前数值;
			}
			return false;
		case 170:
			if (进化数值170 != 0)
			{
				return 进化数值170 > 当前数值;
			}
			return false;
		case 179:
			if (进化数值179 != 0)
			{
				return 进化数值179 > 当前数值;
			}
			return false;
		case 180:
			if (进化数值180 != 0)
			{
				return 进化数值180 > 当前数值;
			}
			return false;
		case 189:
			if (进化数值189 != 0)
			{
				return 进化数值189 > 当前数值;
			}
			return false;
		case 190:
			if (进化数值190 != 0)
			{
				return 进化数值190 > 当前数值;
			}
			return false;
		case 199:
			if (进化数值199 != 0)
			{
				return 进化数值199 > 当前数值;
			}
			return false;
		default:
			return false;
		}
	}

	public int Is取数值(int 装备等级)
	{
		return 装备等级 switch
		{
			89 => 进化数值89, 
			90 => 进化数值90, 
			99 => 进化数值99, 
			100 => 进化数值100, 
			109 => 进化数值109, 
			110 => 进化数值110, 
			119 => 进化数值119, 
			120 => 进化数值120, 
			129 => 进化数值129, 
			130 => 进化数值130, 
			139 => 进化数值139, 
			140 => 进化数值140, 
			149 => 进化数值149, 
			150 => 进化数值150, 
			159 => 进化数值159, 
			160 => 进化数值160, 
			169 => 进化数值169, 
			170 => 进化数值170, 
			179 => 进化数值179, 
			180 => 进化数值180, 
			189 => 进化数值189, 
			190 => 进化数值190, 
			199 => 进化数值199, 
			_ => 0, 
		};
	}
}
