public class MyWgList
{
	public string 数据库IP = string.Empty;

	public string 数据库账号 = "root";

	public string 数据库密码 = string.Empty;

	public string 数据库adb = "dl_adb_all";

	public string 数据库ddb = "dl_ddb_1";

	public int 限制注册 = 5;

	public int 送金元宝 = 2000000000;

	public int 送银元宝;

	public int 送道行;

	public int 送金钱;

	public int 送代金;

	public int 送潜能;

	public int 送声望;

	public int 送战绩;

	public string 送称号 = "大飞";

	public bool Is法宝共生;

	public bool Is元神合体;

	public string 出生地图 = "天墉城";

	public string 出生坐标 = "260,200";

	public bool Is送娃娃;

	public int 娃娃亲密;

	public int 娃娃外观;

	public bool Is送守护;

	public int 守护亲密;

	public bool Is带技能;

	public bool Is带技能精研;

	public int 引灵幡技能等级 = 288;

	public bool 赠送道具;

	public string 赠送道具名字 = "新手礼包（10级）";

	public int 道具数量 = 1;

	public int 道具耐久 = 1;

	public int 道具绑定 = 2;

	public MyWgClientInfo 共享配置 = new MyWgClientInfo();
}
