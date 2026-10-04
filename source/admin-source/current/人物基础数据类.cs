public class 人物基础数据类
{
	public string 昵称 = string.Empty;

	public string 账号 = string.Empty;

	public int GID;

	public 坐标类 坐标 = new 坐标类();

	public int 角色ID;

	public int 形象ID;

	public byte 五行;

	public byte 性别;

	public string 门派 = string.Empty;

	public string 师尊 = string.Empty;

	public int 所在地图id;

	public string 所在地图名字 = string.Empty;

	public string 称谓 = string.Empty;

	public string 所在区线路 = string.Empty;

	public byte 飞行器;

	public bool is法宝共生;

	public bool is内置辅助_伏魔;

	public string 伏魔任务数据 = string.Empty;

	public bool is内置辅助_仙界通缉;

	public string 仙界通缉任务数据 = string.Empty;

	public bool is内置辅助_仙人指路;

	public string 仙人指路任务数据 = string.Empty;

	public bool is内置辅助_修行;

	public string 修行任务数据 = string.Empty;

	public bool is内置辅助_十绝阵;

	public string 十绝阵任务数据 = string.Empty;

	public bool is内置辅助_天罡十绝阵;

	public string 天罡十绝阵任务数据 = string.Empty;

	public bool is内置辅助_刷帮派;

	public string 帮派任务数据 = string.Empty;

	public int 帮派总管ID;

	public int 帮派军师ID;

	public bool is内置辅助_自动挖宝;

	public bool is每周刷道时间存在任务;

	public bool is内置辅助_降妖;

	public string 降妖任务数据 = string.Empty;

	public bool is内置辅助_飞仙渡邪;

	public string 飞仙渡邪任务数据 = string.Empty;

	public bool is内置辅助_自动改造;

	public bool is允许切磋;

	public bool Is试道场 => 所在地图id == 40067;
}
