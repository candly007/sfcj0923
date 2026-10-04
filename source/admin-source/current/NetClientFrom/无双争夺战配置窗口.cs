using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Net.Share;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 无双争夺战配置窗口 : Form
{
	private static 无双争夺战配置窗口 i;

	private IContainer components;

	private CheckBox 无双_开关;

	private Button 无双_重载按钮;

	private Button 无双_保存按钮;

	private GroupBox groupBox1;

	private NumericUpDown 无双_形象;

	private Label label9;

	private ComboBox 无双_朝向;

	private Label label8;

	private NumericUpDown 无双_坐标Y;

	private NumericUpDown 无双_坐标X;

	private Label label7;

	private Label label5;

	private TextBox 无双_npc称号;

	private Label label4;

	private TextBox 无双_npc名字;

	private GroupBox groupBox2;

	private CheckBox 无双_匹配开关;

	private CheckBox 无双_同IP战斗开关;

	private TextBox 无双_活动战场地图;

	private TextBox textBox2;

	private TextBox 无双_活动开始时间;

	private TextBox 地狱道_名字;

	private TextBox 无双_无双大圣奖励;

	private TextBox textBox9;

	private TextBox textBox7;

	private NumericUpDown 无双_胜利夺取积分;

	private TextBox textBox6;

	private NumericUpDown 无双_初始无双积分;

	private TextBox textBox5;

	private NumericUpDown 无双_开启最低人数;

	private TextBox textBox4;

	private TextBox textBox3;

	private NumericUpDown 无双_报名花费价格;

	private ComboBox 无双_报名花费类型;

	private TextBox textBox13;

	private NumericUpDown 无双_积分兑换比例;

	private TextBox textBox12;

	private ComboBox 无双_积分兑换类型;

	private TextBox 无双_活动开始线路;

	private TextBox textBox11;

	private TextBox 无双_参拜获得奖励;

	private TextBox textBox18;

	private TextBox textBox15;

	private NumericUpDown 无双_参拜消耗价格;

	private TextBox textBox14;

	private NumericUpDown 无双_每日参拜次数;

	private GroupBox groupBox3;

	private TextBox 无双_圣榜第四奖励;

	private TextBox textBox25;

	private TextBox 无双_圣榜第二奖励;

	private TextBox textBox27;

	private TextBox 无双_圣榜第九奖励;

	private TextBox textBox29;

	private TextBox textBox30;

	private TextBox textBox31;

	private TextBox textBox32;

	private TextBox textBox33;

	private TextBox textBox34;

	private TextBox 无双_圣榜第三奖励;

	private TextBox textBox36;

	private TextBox 无双_圣榜第一奖励;

	private TextBox textBox38;

	private TextBox 无双_圣榜第十奖励;

	private TextBox 无双_圣榜第八奖励;

	private TextBox 无双_圣榜第六奖励;

	private TextBox 无双_圣榜第七奖励;

	private TextBox 无双_圣榜第五奖励;

	private GroupBox groupBox4;

	private TextBox 无双_连胜200奖励;

	private TextBox 无双_连胜50奖励;

	private TextBox 无双_连胜10奖励;

	private TextBox 无双_连胜30奖励;

	private TextBox 无双_累胜500奖励;

	private TextBox 无双_累胜200奖励;

	private TextBox textBox45;

	private TextBox 无双_累胜50奖励;

	private TextBox textBox47;

	private TextBox 无双_连胜100奖励;

	private TextBox textBox49;

	private TextBox textBox50;

	private TextBox textBox51;

	private TextBox textBox52;

	private TextBox textBox53;

	private TextBox textBox54;

	private TextBox 无双_累胜100奖励;

	private TextBox textBox56;

	private TextBox 无双_累胜20奖励;

	private TextBox textBox58;

	private TextBox textBox16;

	private ComboBox 无双_参拜消耗类型;

	private TextBox 无双_开始前公告;

	private TextBox textBox60;

	private TextBox 无双_开始后公告;

	private TextBox textBox62;

	private TextBox 无双_结束后公告;

	private TextBox textBox64;

	private GroupBox groupBox5;

	private TextBox 无双_活动状态;

	private TextBox textBox66;

	private Button 无双_刷新战场按钮;

	private Button 无双_结束按钮;

	private Button 无双_开启按钮;

	private DataGridView 无双_战场列表;

	private DataGridViewTextBoxColumn 道友名字;

	private DataGridViewTextBoxColumn 是否报名;

	private DataGridViewTextBoxColumn 当前状态;

	private DataGridViewTextBoxColumn 无双积分;

	private Label 无双_战场人数;

	private TextBox textBox1;

	private NumericUpDown 无双_每次参拜雕像增幅;

	public static 无双争夺战配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 无双争夺战配置窗口();
			}
			return i;
		}
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		e.Cancel = true;
		base.Visible = false;
	}

	public new void Show()
	{
		if (base.WindowState == FormWindowState.Minimized)
		{
			base.WindowState = FormWindowState.Normal;
		}
		base.Visible = true;
		if (base.ContainsFocus)
		{
			初始化();
		}
	}

	private void 初始化()
	{
		无双_活动状态.Text = "未开启";
	}

	public 无双争夺战配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 无双争夺战配置窗口_Load(object sender, EventArgs e)
	{
		无双_战场列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建无双列表菜单(淘汰事件回调);
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		无双_重载按钮_Click(sender, e);
	}

	private void 无双_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 10, JsonConvert.SerializeObject(Singleton<全局变量类>.I.圣无双配置, Formatting.Indented));
			Singleton<全局变量类>.I.验证client.SendRT(10018, 37, JsonConvert.SerializeObject(Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像, Formatting.Indented));
		}
	}

	private void 无双_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 10);
			Singleton<全局变量类>.I.验证client.SendRT(10017, 37);
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		switch (配置类型)
		{
		case 37:
		{
			无双_npc名字.Text = Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc名字;
			无双_npc称号.Text = Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc称号;
			无双_坐标X.Value = Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.坐标.X;
			无双_坐标Y.Value = Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.坐标.Y;
			ComboBox comboBox = 无双_朝向;
			AllEnums.朝向Type 朝向 = (AllEnums.朝向Type)Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.朝向;
			comboBox.Text = 朝向.ToString();
			无双_形象.Value = Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc形象;
			break;
		}
		case 10:
			Invoke((MethodInvoker)delegate
			{
				无双_开关.Checked = Singleton<全局变量类>.I.圣无双配置.功能开关;
				无双_匹配开关.Checked = Singleton<全局变量类>.I.圣无双配置.is匹配模式;
				无双_同IP战斗开关.Checked = Singleton<全局变量类>.I.圣无双配置.is同IP战斗;
				无双_参拜消耗类型.Text = Singleton<全局变量类>.I.圣无双配置.参拜消耗类型.ToString();
				无双_参拜消耗价格.Value = Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗;
				无双_每次参拜雕像增幅.Value = Singleton<全局变量类>.I.圣无双配置.每次参拜雕像增幅;
				无双_参拜获得奖励.Text = Singleton<全局变量类>.I.圣无双配置.参拜雕像奖励;
				无双_每日参拜次数.Value = Singleton<全局变量类>.I.圣无双配置.参拜雕像次数;
				无双_活动开始时间.Text = Singleton<全局变量类>.I.圣无双配置.开始时间;
				无双_活动开始线路.Text = Singleton<全局变量类>.I.圣无双配置.活动线路名字;
				无双_活动战场地图.Text = Singleton<全局变量类>.I.圣无双配置.地图名字;
				无双_报名花费类型.Text = Singleton<全局变量类>.I.圣无双配置.门票类型.ToString();
				无双_报名花费价格.Value = Singleton<全局变量类>.I.圣无双配置.门票价格;
				无双_开启最低人数.Value = Singleton<全局变量类>.I.圣无双配置.最低人数;
				无双_初始无双积分.Value = Singleton<全局变量类>.I.圣无双配置.初始积分;
				无双_胜利夺取积分.Value = Singleton<全局变量类>.I.圣无双配置.夺取积分;
				无双_无双大圣奖励.Text = Singleton<全局变量类>.I.圣无双配置.无双奖励;
				无双_积分兑换类型.Text = Singleton<全局变量类>.I.圣无双配置.兑换类型.ToString();
				无双_积分兑换比例.Value = Singleton<全局变量类>.I.圣无双配置.兑换比例;
				无双_圣榜第一奖励.Text = Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[0];
				无双_圣榜第二奖励.Text = Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[1];
				无双_圣榜第三奖励.Text = Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[2];
				无双_圣榜第四奖励.Text = Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[3];
				无双_圣榜第五奖励.Text = Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[4];
				无双_圣榜第六奖励.Text = Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[5];
				无双_圣榜第七奖励.Text = Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[6];
				无双_圣榜第八奖励.Text = Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[7];
				无双_圣榜第九奖励.Text = Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[8];
				无双_圣榜第十奖励.Text = Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[9];
				无双_累胜20奖励.Text = (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.ContainsKey(20) ? Singleton<全局变量类>.I.圣无双配置.累胜奖励列表[20].名字 : string.Empty);
				无双_累胜50奖励.Text = (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.ContainsKey(50) ? Singleton<全局变量类>.I.圣无双配置.累胜奖励列表[50].名字 : string.Empty);
				无双_累胜100奖励.Text = (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.ContainsKey(100) ? Singleton<全局变量类>.I.圣无双配置.累胜奖励列表[100].名字 : string.Empty);
				无双_累胜200奖励.Text = (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.ContainsKey(200) ? Singleton<全局变量类>.I.圣无双配置.累胜奖励列表[200].名字 : string.Empty);
				无双_累胜500奖励.Text = (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.ContainsKey(500) ? Singleton<全局变量类>.I.圣无双配置.累胜奖励列表[500].名字 : string.Empty);
				无双_连胜10奖励.Text = (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.ContainsKey(10) ? Singleton<全局变量类>.I.圣无双配置.连胜奖励列表[10].名字 : string.Empty);
				无双_连胜30奖励.Text = (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.ContainsKey(30) ? Singleton<全局变量类>.I.圣无双配置.连胜奖励列表[30].名字 : string.Empty);
				无双_连胜50奖励.Text = (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.ContainsKey(50) ? Singleton<全局变量类>.I.圣无双配置.连胜奖励列表[50].名字 : string.Empty);
				无双_连胜100奖励.Text = (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.ContainsKey(100) ? Singleton<全局变量类>.I.圣无双配置.连胜奖励列表[100].名字 : string.Empty);
				无双_连胜200奖励.Text = (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.ContainsKey(200) ? Singleton<全局变量类>.I.圣无双配置.连胜奖励列表[200].名字 : string.Empty);
				无双_开始前公告.Text = Singleton<全局变量类>.I.圣无双配置.开启前公告;
				无双_开始后公告.Text = Singleton<全局变量类>.I.圣无双配置.开启后公告;
				无双_结束后公告.Text = Singleton<全局变量类>.I.圣无双配置.结束后公告;
			});
			break;
		}
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.圣无双配置.功能开关 = 无双_开关.Checked;
			Singleton<全局变量类>.I.圣无双配置.is匹配模式 = 无双_匹配开关.Checked;
			Singleton<全局变量类>.I.圣无双配置.is同IP战斗 = 无双_同IP战斗开关.Checked;
			Singleton<全局变量类>.I.圣无双配置.is同IP夺取 = true;
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc名字 = 无双_npc名字.Text;
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc称号 = 无双_npc称号.Text;
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.坐标.X = (short)无双_坐标X.Value;
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.坐标.Y = (short)无双_坐标Y.Value;
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.朝向 = (short)Enum.Parse<AllEnums.朝向Type>(无双_朝向.Text);
			Singleton<全局变量类>.I.全服共享存档数据.无双排行数据.大圣雕像.npc形象 = (int)无双_形象.Value;
			Enum.TryParse<AllEnums.数值Type>(无双_参拜消耗类型.Text, out Singleton<全局变量类>.I.圣无双配置.参拜消耗类型);
			Singleton<全局变量类>.I.圣无双配置.参拜雕像消耗 = (int)无双_参拜消耗价格.Value;
			Singleton<全局变量类>.I.圣无双配置.每次参拜雕像增幅 = (int)无双_每次参拜雕像增幅.Value;
			Singleton<全局变量类>.I.圣无双配置.参拜雕像奖励 = 无双_参拜获得奖励.Text;
			Singleton<全局变量类>.I.圣无双配置.参拜雕像次数 = (int)无双_每日参拜次数.Value;
			Singleton<全局变量类>.I.圣无双配置.开始时间 = 无双_活动开始时间.Text;
			Singleton<全局变量类>.I.圣无双配置.活动线路名字 = 无双_活动开始线路.Text;
			Singleton<全局变量类>.I.圣无双配置.地图名字 = 无双_活动战场地图.Text;
			Enum.TryParse<AllEnums.数值Type>(无双_报名花费类型.Text, out Singleton<全局变量类>.I.圣无双配置.门票类型);
			Singleton<全局变量类>.I.圣无双配置.门票价格 = (int)无双_报名花费价格.Value;
			Singleton<全局变量类>.I.圣无双配置.最低人数 = (int)无双_开启最低人数.Value;
			Singleton<全局变量类>.I.圣无双配置.初始积分 = (int)无双_初始无双积分.Value;
			Singleton<全局变量类>.I.圣无双配置.夺取积分 = (int)无双_胜利夺取积分.Value;
			Singleton<全局变量类>.I.圣无双配置.无双奖励 = 无双_无双大圣奖励.Text;
			Enum.TryParse<AllEnums.数值Type>(无双_积分兑换类型.Text, out Singleton<全局变量类>.I.圣无双配置.兑换类型);
			Singleton<全局变量类>.I.圣无双配置.兑换比例 = (int)无双_积分兑换比例.Value;
			Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[0] = 无双_圣榜第一奖励.Text;
			Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[1] = 无双_圣榜第二奖励.Text;
			Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[2] = 无双_圣榜第三奖励.Text;
			Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[3] = 无双_圣榜第四奖励.Text;
			Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[4] = 无双_圣榜第五奖励.Text;
			Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[5] = 无双_圣榜第六奖励.Text;
			Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[6] = 无双_圣榜第七奖励.Text;
			Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[7] = 无双_圣榜第八奖励.Text;
			Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[8] = 无双_圣榜第九奖励.Text;
			Singleton<全局变量类>.I.圣无双配置.无双圣榜前十奖励[9] = 无双_圣榜第十奖励.Text;
			if (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.ContainsKey(20))
			{
				Singleton<全局变量类>.I.圣无双配置.累胜奖励列表[20].名字 = 无双_累胜20奖励.Text;
			}
			else
			{
				Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.TryAdd(20, new 发送物品数据类
				{
					名字 = 无双_累胜20奖励.Text
				});
			}
			if (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.ContainsKey(50))
			{
				Singleton<全局变量类>.I.圣无双配置.累胜奖励列表[50].名字 = 无双_累胜50奖励.Text;
			}
			else
			{
				Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.TryAdd(50, new 发送物品数据类
				{
					名字 = 无双_累胜50奖励.Text
				});
			}
			if (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.ContainsKey(100))
			{
				Singleton<全局变量类>.I.圣无双配置.累胜奖励列表[100].名字 = 无双_累胜100奖励.Text;
			}
			else
			{
				Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.TryAdd(100, new 发送物品数据类
				{
					名字 = 无双_累胜100奖励.Text
				});
			}
			if (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.ContainsKey(200))
			{
				Singleton<全局变量类>.I.圣无双配置.累胜奖励列表[200].名字 = 无双_累胜200奖励.Text;
			}
			else
			{
				Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.TryAdd(200, new 发送物品数据类
				{
					名字 = 无双_累胜200奖励.Text
				});
			}
			if (Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.ContainsKey(500))
			{
				Singleton<全局变量类>.I.圣无双配置.累胜奖励列表[500].名字 = 无双_累胜500奖励.Text;
			}
			else
			{
				Singleton<全局变量类>.I.圣无双配置.累胜奖励列表.TryAdd(500, new 发送物品数据类
				{
					名字 = 无双_累胜500奖励.Text
				});
			}
			if (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.ContainsKey(10))
			{
				Singleton<全局变量类>.I.圣无双配置.连胜奖励列表[10].名字 = 无双_连胜10奖励.Text;
			}
			else
			{
				Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.TryAdd(10, new 发送物品数据类
				{
					名字 = 无双_连胜10奖励.Text
				});
			}
			if (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.ContainsKey(30))
			{
				Singleton<全局变量类>.I.圣无双配置.连胜奖励列表[30].名字 = 无双_连胜30奖励.Text;
			}
			else
			{
				Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.TryAdd(30, new 发送物品数据类
				{
					名字 = 无双_连胜30奖励.Text
				});
			}
			if (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.ContainsKey(50))
			{
				Singleton<全局变量类>.I.圣无双配置.连胜奖励列表[50].名字 = 无双_连胜50奖励.Text;
			}
			else
			{
				Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.TryAdd(50, new 发送物品数据类
				{
					名字 = 无双_连胜50奖励.Text
				});
			}
			if (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.ContainsKey(100))
			{
				Singleton<全局变量类>.I.圣无双配置.连胜奖励列表[100].名字 = 无双_连胜100奖励.Text;
			}
			else
			{
				Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.TryAdd(100, new 发送物品数据类
				{
					名字 = 无双_连胜100奖励.Text
				});
			}
			if (Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.ContainsKey(200))
			{
				Singleton<全局变量类>.I.圣无双配置.连胜奖励列表[200].名字 = 无双_连胜200奖励.Text;
			}
			else
			{
				Singleton<全局变量类>.I.圣无双配置.连胜奖励列表.TryAdd(200, new 发送物品数据类
				{
					名字 = 无双_连胜200奖励.Text
				});
			}
			Singleton<全局变量类>.I.圣无双配置.开启前公告 = 无双_开始前公告.Text;
			Singleton<全局变量类>.I.圣无双配置.开启后公告 = 无双_开始后公告.Text;
			Singleton<全局变量类>.I.圣无双配置.结束后公告 = 无双_结束后公告.Text;
		}
	}

	private void 无双_开启按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(无双_活动开始时间.Text))
			{
				MessageBox.Show("请输入活动要开启的时间！");
				return;
			}
			if (string.IsNullOrWhiteSpace(无双_活动开始线路.Text))
			{
				MessageBox.Show("请输入活动要开启的线路！");
				return;
			}
			if (string.IsNullOrWhiteSpace(无双_活动战场地图.Text))
			{
				MessageBox.Show("请输入无双战场地图！");
				return;
			}
			if (string.IsNullOrWhiteSpace(无双_报名花费类型.Text))
			{
				MessageBox.Show("请选择报名无双争夺战花费的类型！");
				return;
			}
			Singleton<全局变量类>.I.验证client.SendRT(10031, true);
		}
	}

	private void 无双_结束按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10032, false);
		}
	}

	[Rpc(hash = 10070)]
	private void 返回无双状态(int 无双状态, string 提示)
	{
		if (base.IsHandleCreated)
		{
			无双_活动状态.Text = $"{(AllEnums.圣无双Type)无双状态}";
			MessageBox.Show(提示);
		}
	}

	private void 无双_刷新战场按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			无双_战场列表.Rows.Clear();
			Singleton<全局变量类>.I.验证client.SendRT(10033, true);
		}
	}

	[Rpc(hash = 10071)]
	private void 返回刷新无双(bool 刷新状态, string 名字, bool 是否报名, bool 战斗状态, int 积分)
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		if (!刷新状态)
		{
			无双_战场人数.Text = "0";
			return;
		}
		无双_战场列表.Invoke((MethodInvoker)delegate
		{
			无双_战场列表.Rows.Add(名字, 是否报名 ? "是" : "否", 战斗状态 ? "战斗中" : "休息中", 积分);
		});
	}

	private void 淘汰事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 无双_战场列表.CurrentRow != null)
		{
			int index = 无双_战场列表.CurrentRow.Index;
			if (index >= 0)
			{
				string text = 无双_战场列表.Rows[index].Cells[0].Value.ToString();
				无双_战场列表.Rows.RemoveAt(index);
				Singleton<全局变量类>.I.验证client.SendRT(10034, text);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.无双争夺战配置窗口));
		this.无双_开关 = new System.Windows.Forms.CheckBox();
		this.无双_重载按钮 = new System.Windows.Forms.Button();
		this.无双_保存按钮 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.textBox14 = new System.Windows.Forms.TextBox();
		this.无双_每日参拜次数 = new System.Windows.Forms.NumericUpDown();
		this.无双_参拜获得奖励 = new System.Windows.Forms.TextBox();
		this.textBox16 = new System.Windows.Forms.TextBox();
		this.textBox18 = new System.Windows.Forms.TextBox();
		this.无双_参拜消耗类型 = new System.Windows.Forms.ComboBox();
		this.textBox15 = new System.Windows.Forms.TextBox();
		this.无双_参拜消耗价格 = new System.Windows.Forms.NumericUpDown();
		this.无双_形象 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.无双_朝向 = new System.Windows.Forms.ComboBox();
		this.label8 = new System.Windows.Forms.Label();
		this.无双_坐标Y = new System.Windows.Forms.NumericUpDown();
		this.无双_坐标X = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.无双_npc称号 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.无双_npc名字 = new System.Windows.Forms.TextBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.textBox13 = new System.Windows.Forms.TextBox();
		this.无双_积分兑换比例 = new System.Windows.Forms.NumericUpDown();
		this.textBox12 = new System.Windows.Forms.TextBox();
		this.无双_积分兑换类型 = new System.Windows.Forms.ComboBox();
		this.无双_活动开始线路 = new System.Windows.Forms.TextBox();
		this.textBox11 = new System.Windows.Forms.TextBox();
		this.无双_无双大圣奖励 = new System.Windows.Forms.TextBox();
		this.textBox9 = new System.Windows.Forms.TextBox();
		this.textBox7 = new System.Windows.Forms.TextBox();
		this.无双_胜利夺取积分 = new System.Windows.Forms.NumericUpDown();
		this.textBox6 = new System.Windows.Forms.TextBox();
		this.无双_初始无双积分 = new System.Windows.Forms.NumericUpDown();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.无双_开启最低人数 = new System.Windows.Forms.NumericUpDown();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.无双_报名花费价格 = new System.Windows.Forms.NumericUpDown();
		this.无双_报名花费类型 = new System.Windows.Forms.ComboBox();
		this.无双_活动战场地图 = new System.Windows.Forms.TextBox();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.无双_活动开始时间 = new System.Windows.Forms.TextBox();
		this.地狱道_名字 = new System.Windows.Forms.TextBox();
		this.无双_匹配开关 = new System.Windows.Forms.CheckBox();
		this.无双_同IP战斗开关 = new System.Windows.Forms.CheckBox();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.无双_圣榜第十奖励 = new System.Windows.Forms.TextBox();
		this.无双_圣榜第八奖励 = new System.Windows.Forms.TextBox();
		this.无双_圣榜第六奖励 = new System.Windows.Forms.TextBox();
		this.无双_圣榜第七奖励 = new System.Windows.Forms.TextBox();
		this.无双_圣榜第五奖励 = new System.Windows.Forms.TextBox();
		this.无双_圣榜第四奖励 = new System.Windows.Forms.TextBox();
		this.textBox25 = new System.Windows.Forms.TextBox();
		this.无双_圣榜第二奖励 = new System.Windows.Forms.TextBox();
		this.textBox27 = new System.Windows.Forms.TextBox();
		this.无双_圣榜第九奖励 = new System.Windows.Forms.TextBox();
		this.textBox29 = new System.Windows.Forms.TextBox();
		this.textBox30 = new System.Windows.Forms.TextBox();
		this.textBox31 = new System.Windows.Forms.TextBox();
		this.textBox32 = new System.Windows.Forms.TextBox();
		this.textBox33 = new System.Windows.Forms.TextBox();
		this.textBox34 = new System.Windows.Forms.TextBox();
		this.无双_圣榜第三奖励 = new System.Windows.Forms.TextBox();
		this.textBox36 = new System.Windows.Forms.TextBox();
		this.无双_圣榜第一奖励 = new System.Windows.Forms.TextBox();
		this.textBox38 = new System.Windows.Forms.TextBox();
		this.groupBox4 = new System.Windows.Forms.GroupBox();
		this.无双_连胜200奖励 = new System.Windows.Forms.TextBox();
		this.无双_连胜50奖励 = new System.Windows.Forms.TextBox();
		this.无双_连胜10奖励 = new System.Windows.Forms.TextBox();
		this.无双_连胜30奖励 = new System.Windows.Forms.TextBox();
		this.无双_累胜500奖励 = new System.Windows.Forms.TextBox();
		this.无双_累胜200奖励 = new System.Windows.Forms.TextBox();
		this.textBox45 = new System.Windows.Forms.TextBox();
		this.无双_累胜50奖励 = new System.Windows.Forms.TextBox();
		this.textBox47 = new System.Windows.Forms.TextBox();
		this.无双_连胜100奖励 = new System.Windows.Forms.TextBox();
		this.textBox49 = new System.Windows.Forms.TextBox();
		this.textBox50 = new System.Windows.Forms.TextBox();
		this.textBox51 = new System.Windows.Forms.TextBox();
		this.textBox52 = new System.Windows.Forms.TextBox();
		this.textBox53 = new System.Windows.Forms.TextBox();
		this.textBox54 = new System.Windows.Forms.TextBox();
		this.无双_累胜100奖励 = new System.Windows.Forms.TextBox();
		this.textBox56 = new System.Windows.Forms.TextBox();
		this.无双_累胜20奖励 = new System.Windows.Forms.TextBox();
		this.textBox58 = new System.Windows.Forms.TextBox();
		this.无双_开始前公告 = new System.Windows.Forms.TextBox();
		this.textBox60 = new System.Windows.Forms.TextBox();
		this.无双_开始后公告 = new System.Windows.Forms.TextBox();
		this.textBox62 = new System.Windows.Forms.TextBox();
		this.无双_结束后公告 = new System.Windows.Forms.TextBox();
		this.textBox64 = new System.Windows.Forms.TextBox();
		this.groupBox5 = new System.Windows.Forms.GroupBox();
		this.无双_战场人数 = new System.Windows.Forms.Label();
		this.无双_战场列表 = new System.Windows.Forms.DataGridView();
		this.道友名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.是否报名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.当前状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.无双积分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.无双_刷新战场按钮 = new System.Windows.Forms.Button();
		this.无双_结束按钮 = new System.Windows.Forms.Button();
		this.无双_开启按钮 = new System.Windows.Forms.Button();
		this.无双_活动状态 = new System.Windows.Forms.TextBox();
		this.textBox66 = new System.Windows.Forms.TextBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.无双_每次参拜雕像增幅 = new System.Windows.Forms.NumericUpDown();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.无双_每日参拜次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.无双_参拜消耗价格).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.无双_形象).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.无双_坐标Y).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.无双_坐标X).BeginInit();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.无双_积分兑换比例).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.无双_胜利夺取积分).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.无双_初始无双积分).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.无双_开启最低人数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.无双_报名花费价格).BeginInit();
		this.groupBox3.SuspendLayout();
		this.groupBox4.SuspendLayout();
		this.groupBox5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.无双_战场列表).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.无双_每次参拜雕像增幅).BeginInit();
		base.SuspendLayout();
		this.无双_开关.AutoSize = true;
		this.无双_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.无双_开关.Location = new System.Drawing.Point(12, 12);
		this.无双_开关.Name = "无双_开关";
		this.无双_开关.Size = new System.Drawing.Size(119, 23);
		this.无双_开关.TabIndex = 113;
		this.无双_开关.Text = "无双争夺战开关";
		this.无双_开关.UseVisualStyleBackColor = true;
		this.无双_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.无双_重载按钮.Location = new System.Drawing.Point(457, 8);
		this.无双_重载按钮.Name = "无双_重载按钮";
		this.无双_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.无双_重载按钮.TabIndex = 115;
		this.无双_重载按钮.Text = "重载配置";
		this.无双_重载按钮.UseVisualStyleBackColor = true;
		this.无双_重载按钮.Click += new System.EventHandler(无双_重载按钮_Click);
		this.无双_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.无双_保存按钮.Location = new System.Drawing.Point(351, 8);
		this.无双_保存按钮.Name = "无双_保存按钮";
		this.无双_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.无双_保存按钮.TabIndex = 114;
		this.无双_保存按钮.Text = "保存配置";
		this.无双_保存按钮.UseVisualStyleBackColor = true;
		this.无双_保存按钮.Click += new System.EventHandler(无双_保存按钮_Click);
		this.groupBox1.BackColor = System.Drawing.Color.Transparent;
		this.groupBox1.Controls.Add(this.textBox14);
		this.groupBox1.Controls.Add(this.无双_每日参拜次数);
		this.groupBox1.Controls.Add(this.无双_参拜获得奖励);
		this.groupBox1.Controls.Add(this.textBox16);
		this.groupBox1.Controls.Add(this.textBox18);
		this.groupBox1.Controls.Add(this.无双_参拜消耗类型);
		this.groupBox1.Controls.Add(this.textBox15);
		this.groupBox1.Controls.Add(this.无双_参拜消耗价格);
		this.groupBox1.Controls.Add(this.无双_形象);
		this.groupBox1.Controls.Add(this.label9);
		this.groupBox1.Controls.Add(this.无双_朝向);
		this.groupBox1.Controls.Add(this.label8);
		this.groupBox1.Controls.Add(this.无双_坐标Y);
		this.groupBox1.Controls.Add(this.无双_坐标X);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.无双_npc称号);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.无双_npc名字);
		this.groupBox1.Location = new System.Drawing.Point(12, 44);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(752, 83);
		this.groupBox1.TabIndex = 116;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "大圣雕像数据（请勿随意更改）";
		this.textBox14.Location = new System.Drawing.Point(563, 48);
		this.textBox14.Name = "textBox14";
		this.textBox14.ReadOnly = true;
		this.textBox14.Size = new System.Drawing.Size(80, 23);
		this.textBox14.TabIndex = 145;
		this.textBox14.Text = "每日参拜次数";
		this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_每日参拜次数.Location = new System.Drawing.Point(644, 48);
		this.无双_每日参拜次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.无双_每日参拜次数.Name = "无双_每日参拜次数";
		this.无双_每日参拜次数.Size = new System.Drawing.Size(100, 23);
		this.无双_每日参拜次数.TabIndex = 144;
		this.无双_参拜获得奖励.Location = new System.Drawing.Point(457, 48);
		this.无双_参拜获得奖励.Name = "无双_参拜获得奖励";
		this.无双_参拜获得奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_参拜获得奖励.TabIndex = 151;
		this.textBox16.Location = new System.Drawing.Point(6, 48);
		this.textBox16.Name = "textBox16";
		this.textBox16.ReadOnly = true;
		this.textBox16.Size = new System.Drawing.Size(80, 23);
		this.textBox16.TabIndex = 149;
		this.textBox16.Text = "参拜雕像消耗";
		this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox18.Location = new System.Drawing.Point(376, 48);
		this.textBox18.Name = "textBox18";
		this.textBox18.ReadOnly = true;
		this.textBox18.Size = new System.Drawing.Size(80, 23);
		this.textBox18.TabIndex = 150;
		this.textBox18.Text = "参拜获得奖励";
		this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_参拜消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.无双_参拜消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.无双_参拜消耗类型.FormattingEnabled = true;
		this.无双_参拜消耗类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "金钱" });
		this.无双_参拜消耗类型.Location = new System.Drawing.Point(87, 47);
		this.无双_参拜消耗类型.Name = "无双_参拜消耗类型";
		this.无双_参拜消耗类型.Size = new System.Drawing.Size(100, 25);
		this.无双_参拜消耗类型.TabIndex = 148;
		this.textBox15.Location = new System.Drawing.Point(193, 48);
		this.textBox15.Name = "textBox15";
		this.textBox15.ReadOnly = true;
		this.textBox15.Size = new System.Drawing.Size(80, 23);
		this.textBox15.TabIndex = 149;
		this.textBox15.Text = "参拜消耗价格";
		this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_参拜消耗价格.Location = new System.Drawing.Point(274, 48);
		this.无双_参拜消耗价格.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.无双_参拜消耗价格.Name = "无双_参拜消耗价格";
		this.无双_参拜消耗价格.Size = new System.Drawing.Size(100, 23);
		this.无双_参拜消耗价格.TabIndex = 148;
		this.无双_形象.Location = new System.Drawing.Point(644, 19);
		this.无双_形象.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.无双_形象.Name = "无双_形象";
		this.无双_形象.Size = new System.Drawing.Size(100, 23);
		this.无双_形象.TabIndex = 112;
		this.label9.BackColor = System.Drawing.Color.Transparent;
		this.label9.Location = new System.Drawing.Point(611, 19);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(32, 23);
		this.label9.TabIndex = 111;
		this.label9.Text = "形象";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.无双_朝向.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.无双_朝向.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.无双_朝向.FormattingEnabled = true;
		this.无双_朝向.Items.AddRange(new object[8] { "左", "左上", "上", "右上", "右", "右下", "下", "左下" });
		this.无双_朝向.Location = new System.Drawing.Point(545, 18);
		this.无双_朝向.Name = "无双_朝向";
		this.无双_朝向.Size = new System.Drawing.Size(60, 25);
		this.无双_朝向.TabIndex = 110;
		this.label8.BackColor = System.Drawing.Color.Transparent;
		this.label8.Location = new System.Drawing.Point(513, 19);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(32, 23);
		this.label8.TabIndex = 109;
		this.label8.Text = "朝向";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.无双_坐标Y.Location = new System.Drawing.Point(447, 19);
		this.无双_坐标Y.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.无双_坐标Y.Name = "无双_坐标Y";
		this.无双_坐标Y.Size = new System.Drawing.Size(60, 23);
		this.无双_坐标Y.TabIndex = 108;
		this.无双_坐标X.Location = new System.Drawing.Point(370, 19);
		this.无双_坐标X.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.无双_坐标X.Name = "无双_坐标X";
		this.无双_坐标X.Size = new System.Drawing.Size(60, 23);
		this.无双_坐标X.TabIndex = 107;
		this.label7.BackColor = System.Drawing.Color.Transparent;
		this.label7.Location = new System.Drawing.Point(330, 19);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(115, 23);
		this.label7.TabIndex = 106;
		this.label7.Text = "坐标X                 Y";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label5.Location = new System.Drawing.Point(168, 19);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(60, 23);
		this.label5.TabIndex = 104;
		this.label5.Text = "雕像称号";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.无双_npc称号.Location = new System.Drawing.Point(229, 19);
		this.无双_npc称号.Name = "无双_npc称号";
		this.无双_npc称号.Size = new System.Drawing.Size(100, 23);
		this.无双_npc称号.TabIndex = 105;
		this.label4.Location = new System.Drawing.Point(6, 19);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 102;
		this.label4.Text = "雕像名字";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.无双_npc名字.Location = new System.Drawing.Point(67, 19);
		this.无双_npc名字.Name = "无双_npc名字";
		this.无双_npc名字.Size = new System.Drawing.Size(100, 23);
		this.无双_npc名字.TabIndex = 103;
		this.groupBox2.Controls.Add(this.textBox13);
		this.groupBox2.Controls.Add(this.无双_积分兑换比例);
		this.groupBox2.Controls.Add(this.textBox12);
		this.groupBox2.Controls.Add(this.无双_积分兑换类型);
		this.groupBox2.Controls.Add(this.无双_活动开始线路);
		this.groupBox2.Controls.Add(this.textBox11);
		this.groupBox2.Controls.Add(this.无双_无双大圣奖励);
		this.groupBox2.Controls.Add(this.textBox9);
		this.groupBox2.Controls.Add(this.textBox7);
		this.groupBox2.Controls.Add(this.无双_胜利夺取积分);
		this.groupBox2.Controls.Add(this.textBox6);
		this.groupBox2.Controls.Add(this.无双_初始无双积分);
		this.groupBox2.Controls.Add(this.textBox5);
		this.groupBox2.Controls.Add(this.无双_开启最低人数);
		this.groupBox2.Controls.Add(this.textBox4);
		this.groupBox2.Controls.Add(this.textBox3);
		this.groupBox2.Controls.Add(this.无双_报名花费价格);
		this.groupBox2.Controls.Add(this.无双_报名花费类型);
		this.groupBox2.Controls.Add(this.无双_活动战场地图);
		this.groupBox2.Controls.Add(this.textBox2);
		this.groupBox2.Controls.Add(this.无双_活动开始时间);
		this.groupBox2.Controls.Add(this.地狱道_名字);
		this.groupBox2.Location = new System.Drawing.Point(12, 133);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(196, 348);
		this.groupBox2.TabIndex = 117;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "活动基础配置";
		this.textBox13.Location = new System.Drawing.Point(6, 314);
		this.textBox13.Name = "textBox13";
		this.textBox13.ReadOnly = true;
		this.textBox13.Size = new System.Drawing.Size(80, 23);
		this.textBox13.TabIndex = 143;
		this.textBox13.Text = "积分兑换比例";
		this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_积分兑换比例.Location = new System.Drawing.Point(87, 314);
		this.无双_积分兑换比例.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.无双_积分兑换比例.Name = "无双_积分兑换比例";
		this.无双_积分兑换比例.Size = new System.Drawing.Size(100, 23);
		this.无双_积分兑换比例.TabIndex = 142;
		this.textBox12.Location = new System.Drawing.Point(6, 284);
		this.textBox12.Name = "textBox12";
		this.textBox12.ReadOnly = true;
		this.textBox12.Size = new System.Drawing.Size(80, 23);
		this.textBox12.TabIndex = 141;
		this.textBox12.Text = "积分兑换类型";
		this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_积分兑换类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.无双_积分兑换类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.无双_积分兑换类型.FormattingEnabled = true;
		this.无双_积分兑换类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "金钱" });
		this.无双_积分兑换类型.Location = new System.Drawing.Point(87, 283);
		this.无双_积分兑换类型.Name = "无双_积分兑换类型";
		this.无双_积分兑换类型.Size = new System.Drawing.Size(100, 25);
		this.无双_积分兑换类型.TabIndex = 140;
		this.无双_活动开始线路.Location = new System.Drawing.Point(87, 51);
		this.无双_活动开始线路.Name = "无双_活动开始线路";
		this.无双_活动开始线路.Size = new System.Drawing.Size(100, 23);
		this.无双_活动开始线路.TabIndex = 139;
		this.textBox11.Location = new System.Drawing.Point(6, 51);
		this.textBox11.Name = "textBox11";
		this.textBox11.ReadOnly = true;
		this.textBox11.Size = new System.Drawing.Size(80, 23);
		this.textBox11.TabIndex = 138;
		this.textBox11.Text = "活动开始线路";
		this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_无双大圣奖励.Location = new System.Drawing.Point(87, 255);
		this.无双_无双大圣奖励.Name = "无双_无双大圣奖励";
		this.无双_无双大圣奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_无双大圣奖励.TabIndex = 137;
		this.textBox9.Location = new System.Drawing.Point(6, 255);
		this.textBox9.Name = "textBox9";
		this.textBox9.ReadOnly = true;
		this.textBox9.Size = new System.Drawing.Size(80, 23);
		this.textBox9.TabIndex = 136;
		this.textBox9.Text = "无双大圣奖励";
		this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox7.Location = new System.Drawing.Point(6, 226);
		this.textBox7.Name = "textBox7";
		this.textBox7.ReadOnly = true;
		this.textBox7.Size = new System.Drawing.Size(80, 23);
		this.textBox7.TabIndex = 135;
		this.textBox7.Text = "胜利夺取积分";
		this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_胜利夺取积分.Location = new System.Drawing.Point(87, 226);
		this.无双_胜利夺取积分.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.无双_胜利夺取积分.Name = "无双_胜利夺取积分";
		this.无双_胜利夺取积分.Size = new System.Drawing.Size(100, 23);
		this.无双_胜利夺取积分.TabIndex = 134;
		this.textBox6.Location = new System.Drawing.Point(6, 197);
		this.textBox6.Name = "textBox6";
		this.textBox6.ReadOnly = true;
		this.textBox6.Size = new System.Drawing.Size(80, 23);
		this.textBox6.TabIndex = 133;
		this.textBox6.Text = "初始无双积分";
		this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_初始无双积分.Location = new System.Drawing.Point(87, 197);
		this.无双_初始无双积分.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.无双_初始无双积分.Name = "无双_初始无双积分";
		this.无双_初始无双积分.Size = new System.Drawing.Size(100, 23);
		this.无双_初始无双积分.TabIndex = 132;
		this.textBox5.Location = new System.Drawing.Point(6, 168);
		this.textBox5.Name = "textBox5";
		this.textBox5.ReadOnly = true;
		this.textBox5.Size = new System.Drawing.Size(80, 23);
		this.textBox5.TabIndex = 131;
		this.textBox5.Text = "活动最低人数";
		this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_开启最低人数.Location = new System.Drawing.Point(87, 168);
		this.无双_开启最低人数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.无双_开启最低人数.Name = "无双_开启最低人数";
		this.无双_开启最低人数.Size = new System.Drawing.Size(100, 23);
		this.无双_开启最低人数.TabIndex = 130;
		this.textBox4.Location = new System.Drawing.Point(6, 139);
		this.textBox4.Name = "textBox4";
		this.textBox4.ReadOnly = true;
		this.textBox4.Size = new System.Drawing.Size(80, 23);
		this.textBox4.TabIndex = 129;
		this.textBox4.Text = "报名花费价格";
		this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox3.Location = new System.Drawing.Point(6, 109);
		this.textBox3.Name = "textBox3";
		this.textBox3.ReadOnly = true;
		this.textBox3.Size = new System.Drawing.Size(80, 23);
		this.textBox3.TabIndex = 128;
		this.textBox3.Text = "报名花费类型";
		this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_报名花费价格.Location = new System.Drawing.Point(87, 139);
		this.无双_报名花费价格.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.无双_报名花费价格.Name = "无双_报名花费价格";
		this.无双_报名花费价格.Size = new System.Drawing.Size(100, 23);
		this.无双_报名花费价格.TabIndex = 127;
		this.无双_报名花费类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.无双_报名花费类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.无双_报名花费类型.FormattingEnabled = true;
		this.无双_报名花费类型.Items.AddRange(new object[4] { "无", "金元宝", "银元宝", "金钱" });
		this.无双_报名花费类型.Location = new System.Drawing.Point(87, 108);
		this.无双_报名花费类型.Name = "无双_报名花费类型";
		this.无双_报名花费类型.Size = new System.Drawing.Size(100, 25);
		this.无双_报名花费类型.TabIndex = 126;
		this.无双_活动战场地图.Location = new System.Drawing.Point(87, 80);
		this.无双_活动战场地图.Name = "无双_活动战场地图";
		this.无双_活动战场地图.Size = new System.Drawing.Size(100, 23);
		this.无双_活动战场地图.TabIndex = 125;
		this.textBox2.Location = new System.Drawing.Point(6, 80);
		this.textBox2.Name = "textBox2";
		this.textBox2.ReadOnly = true;
		this.textBox2.Size = new System.Drawing.Size(80, 23);
		this.textBox2.TabIndex = 124;
		this.textBox2.Text = "无双战场地图";
		this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_活动开始时间.Location = new System.Drawing.Point(87, 22);
		this.无双_活动开始时间.Name = "无双_活动开始时间";
		this.无双_活动开始时间.Size = new System.Drawing.Size(100, 23);
		this.无双_活动开始时间.TabIndex = 123;
		this.地狱道_名字.Location = new System.Drawing.Point(6, 22);
		this.地狱道_名字.Name = "地狱道_名字";
		this.地狱道_名字.ReadOnly = true;
		this.地狱道_名字.Size = new System.Drawing.Size(80, 23);
		this.地狱道_名字.TabIndex = 122;
		this.地狱道_名字.Text = "活动开始时间";
		this.地狱道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_匹配开关.AutoSize = true;
		this.无双_匹配开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.无双_匹配开关.Location = new System.Drawing.Point(137, 12);
		this.无双_匹配开关.Name = "无双_匹配开关";
		this.无双_匹配开关.Size = new System.Drawing.Size(106, 23);
		this.无双_匹配开关.TabIndex = 118;
		this.无双_匹配开关.Text = "开启匹配模式";
		this.无双_匹配开关.UseVisualStyleBackColor = true;
		this.无双_同IP战斗开关.AutoSize = true;
		this.无双_同IP战斗开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.无双_同IP战斗开关.Location = new System.Drawing.Point(252, 12);
		this.无双_同IP战斗开关.Name = "无双_同IP战斗开关";
		this.无双_同IP战斗开关.Size = new System.Drawing.Size(93, 23);
		this.无双_同IP战斗开关.TabIndex = 119;
		this.无双_同IP战斗开关.Text = "同IP可战斗";
		this.无双_同IP战斗开关.UseVisualStyleBackColor = true;
		this.groupBox3.Controls.Add(this.无双_圣榜第十奖励);
		this.groupBox3.Controls.Add(this.无双_圣榜第八奖励);
		this.groupBox3.Controls.Add(this.无双_圣榜第六奖励);
		this.groupBox3.Controls.Add(this.无双_圣榜第七奖励);
		this.groupBox3.Controls.Add(this.无双_圣榜第五奖励);
		this.groupBox3.Controls.Add(this.无双_圣榜第四奖励);
		this.groupBox3.Controls.Add(this.textBox25);
		this.groupBox3.Controls.Add(this.无双_圣榜第二奖励);
		this.groupBox3.Controls.Add(this.textBox27);
		this.groupBox3.Controls.Add(this.无双_圣榜第九奖励);
		this.groupBox3.Controls.Add(this.textBox29);
		this.groupBox3.Controls.Add(this.textBox30);
		this.groupBox3.Controls.Add(this.textBox31);
		this.groupBox3.Controls.Add(this.textBox32);
		this.groupBox3.Controls.Add(this.textBox33);
		this.groupBox3.Controls.Add(this.textBox34);
		this.groupBox3.Controls.Add(this.无双_圣榜第三奖励);
		this.groupBox3.Controls.Add(this.textBox36);
		this.groupBox3.Controls.Add(this.无双_圣榜第一奖励);
		this.groupBox3.Controls.Add(this.textBox38);
		this.groupBox3.Location = new System.Drawing.Point(286, 133);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(196, 318);
		this.groupBox3.TabIndex = 121;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "无双圣榜排行前十奖励";
		this.无双_圣榜第十奖励.Location = new System.Drawing.Point(87, 283);
		this.无双_圣榜第十奖励.Name = "无双_圣榜第十奖励";
		this.无双_圣榜第十奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_圣榜第十奖励.TabIndex = 157;
		this.无双_圣榜第八奖励.Location = new System.Drawing.Point(87, 227);
		this.无双_圣榜第八奖励.Name = "无双_圣榜第八奖励";
		this.无双_圣榜第八奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_圣榜第八奖励.TabIndex = 156;
		this.无双_圣榜第六奖励.Location = new System.Drawing.Point(87, 168);
		this.无双_圣榜第六奖励.Name = "无双_圣榜第六奖励";
		this.无双_圣榜第六奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_圣榜第六奖励.TabIndex = 155;
		this.无双_圣榜第七奖励.Location = new System.Drawing.Point(87, 197);
		this.无双_圣榜第七奖励.Name = "无双_圣榜第七奖励";
		this.无双_圣榜第七奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_圣榜第七奖励.TabIndex = 154;
		this.无双_圣榜第五奖励.Location = new System.Drawing.Point(87, 139);
		this.无双_圣榜第五奖励.Name = "无双_圣榜第五奖励";
		this.无双_圣榜第五奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_圣榜第五奖励.TabIndex = 153;
		this.无双_圣榜第四奖励.Location = new System.Drawing.Point(87, 110);
		this.无双_圣榜第四奖励.Name = "无双_圣榜第四奖励";
		this.无双_圣榜第四奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_圣榜第四奖励.TabIndex = 152;
		this.textBox25.Location = new System.Drawing.Point(6, 284);
		this.textBox25.Name = "textBox25";
		this.textBox25.ReadOnly = true;
		this.textBox25.Size = new System.Drawing.Size(80, 23);
		this.textBox25.TabIndex = 141;
		this.textBox25.Text = "圣榜第十奖励";
		this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_圣榜第二奖励.Location = new System.Drawing.Point(87, 51);
		this.无双_圣榜第二奖励.Name = "无双_圣榜第二奖励";
		this.无双_圣榜第二奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_圣榜第二奖励.TabIndex = 139;
		this.textBox27.Location = new System.Drawing.Point(6, 51);
		this.textBox27.Name = "textBox27";
		this.textBox27.ReadOnly = true;
		this.textBox27.Size = new System.Drawing.Size(80, 23);
		this.textBox27.TabIndex = 138;
		this.textBox27.Text = "圣榜第二奖励";
		this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_圣榜第九奖励.Location = new System.Drawing.Point(87, 255);
		this.无双_圣榜第九奖励.Name = "无双_圣榜第九奖励";
		this.无双_圣榜第九奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_圣榜第九奖励.TabIndex = 137;
		this.textBox29.Location = new System.Drawing.Point(6, 255);
		this.textBox29.Name = "textBox29";
		this.textBox29.ReadOnly = true;
		this.textBox29.Size = new System.Drawing.Size(80, 23);
		this.textBox29.TabIndex = 136;
		this.textBox29.Text = "圣榜第九奖励";
		this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox30.Location = new System.Drawing.Point(6, 226);
		this.textBox30.Name = "textBox30";
		this.textBox30.ReadOnly = true;
		this.textBox30.Size = new System.Drawing.Size(80, 23);
		this.textBox30.TabIndex = 135;
		this.textBox30.Text = "圣榜第八奖励";
		this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox31.Location = new System.Drawing.Point(6, 197);
		this.textBox31.Name = "textBox31";
		this.textBox31.ReadOnly = true;
		this.textBox31.Size = new System.Drawing.Size(80, 23);
		this.textBox31.TabIndex = 133;
		this.textBox31.Text = "圣榜第七奖励";
		this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox32.Location = new System.Drawing.Point(6, 168);
		this.textBox32.Name = "textBox32";
		this.textBox32.ReadOnly = true;
		this.textBox32.Size = new System.Drawing.Size(80, 23);
		this.textBox32.TabIndex = 131;
		this.textBox32.Text = "圣榜第六奖励";
		this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox33.Location = new System.Drawing.Point(6, 139);
		this.textBox33.Name = "textBox33";
		this.textBox33.ReadOnly = true;
		this.textBox33.Size = new System.Drawing.Size(80, 23);
		this.textBox33.TabIndex = 129;
		this.textBox33.Text = "圣榜第五奖励";
		this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox34.Location = new System.Drawing.Point(6, 109);
		this.textBox34.Name = "textBox34";
		this.textBox34.ReadOnly = true;
		this.textBox34.Size = new System.Drawing.Size(80, 23);
		this.textBox34.TabIndex = 128;
		this.textBox34.Text = "圣榜第四奖励";
		this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_圣榜第三奖励.Location = new System.Drawing.Point(87, 80);
		this.无双_圣榜第三奖励.Name = "无双_圣榜第三奖励";
		this.无双_圣榜第三奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_圣榜第三奖励.TabIndex = 125;
		this.textBox36.Location = new System.Drawing.Point(6, 80);
		this.textBox36.Name = "textBox36";
		this.textBox36.ReadOnly = true;
		this.textBox36.Size = new System.Drawing.Size(80, 23);
		this.textBox36.TabIndex = 124;
		this.textBox36.Text = "圣榜第三奖励";
		this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_圣榜第一奖励.Location = new System.Drawing.Point(87, 22);
		this.无双_圣榜第一奖励.Name = "无双_圣榜第一奖励";
		this.无双_圣榜第一奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_圣榜第一奖励.TabIndex = 123;
		this.textBox38.Location = new System.Drawing.Point(6, 22);
		this.textBox38.Name = "textBox38";
		this.textBox38.ReadOnly = true;
		this.textBox38.Size = new System.Drawing.Size(80, 23);
		this.textBox38.TabIndex = 122;
		this.textBox38.Text = "圣榜第一奖励";
		this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.groupBox4.Controls.Add(this.无双_连胜200奖励);
		this.groupBox4.Controls.Add(this.无双_连胜50奖励);
		this.groupBox4.Controls.Add(this.无双_连胜10奖励);
		this.groupBox4.Controls.Add(this.无双_连胜30奖励);
		this.groupBox4.Controls.Add(this.无双_累胜500奖励);
		this.groupBox4.Controls.Add(this.无双_累胜200奖励);
		this.groupBox4.Controls.Add(this.textBox45);
		this.groupBox4.Controls.Add(this.无双_累胜50奖励);
		this.groupBox4.Controls.Add(this.textBox47);
		this.groupBox4.Controls.Add(this.无双_连胜100奖励);
		this.groupBox4.Controls.Add(this.textBox49);
		this.groupBox4.Controls.Add(this.textBox50);
		this.groupBox4.Controls.Add(this.textBox51);
		this.groupBox4.Controls.Add(this.textBox52);
		this.groupBox4.Controls.Add(this.textBox53);
		this.groupBox4.Controls.Add(this.textBox54);
		this.groupBox4.Controls.Add(this.无双_累胜100奖励);
		this.groupBox4.Controls.Add(this.textBox56);
		this.groupBox4.Controls.Add(this.无双_累胜20奖励);
		this.groupBox4.Controls.Add(this.textBox58);
		this.groupBox4.Location = new System.Drawing.Point(568, 133);
		this.groupBox4.Name = "groupBox4";
		this.groupBox4.Size = new System.Drawing.Size(196, 318);
		this.groupBox4.TabIndex = 122;
		this.groupBox4.TabStop = false;
		this.groupBox4.Text = "无双圣榜累胜/连胜奖励";
		this.无双_连胜200奖励.Location = new System.Drawing.Point(87, 283);
		this.无双_连胜200奖励.Name = "无双_连胜200奖励";
		this.无双_连胜200奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_连胜200奖励.TabIndex = 157;
		this.无双_连胜50奖励.Location = new System.Drawing.Point(87, 227);
		this.无双_连胜50奖励.Name = "无双_连胜50奖励";
		this.无双_连胜50奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_连胜50奖励.TabIndex = 156;
		this.无双_连胜10奖励.Location = new System.Drawing.Point(87, 168);
		this.无双_连胜10奖励.Name = "无双_连胜10奖励";
		this.无双_连胜10奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_连胜10奖励.TabIndex = 155;
		this.无双_连胜30奖励.Location = new System.Drawing.Point(87, 197);
		this.无双_连胜30奖励.Name = "无双_连胜30奖励";
		this.无双_连胜30奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_连胜30奖励.TabIndex = 154;
		this.无双_累胜500奖励.Location = new System.Drawing.Point(87, 139);
		this.无双_累胜500奖励.Name = "无双_累胜500奖励";
		this.无双_累胜500奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_累胜500奖励.TabIndex = 153;
		this.无双_累胜200奖励.Location = new System.Drawing.Point(87, 110);
		this.无双_累胜200奖励.Name = "无双_累胜200奖励";
		this.无双_累胜200奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_累胜200奖励.TabIndex = 152;
		this.textBox45.Location = new System.Drawing.Point(6, 284);
		this.textBox45.Name = "textBox45";
		this.textBox45.ReadOnly = true;
		this.textBox45.Size = new System.Drawing.Size(80, 23);
		this.textBox45.TabIndex = 141;
		this.textBox45.Text = "连胜200场";
		this.textBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_累胜50奖励.Location = new System.Drawing.Point(87, 51);
		this.无双_累胜50奖励.Name = "无双_累胜50奖励";
		this.无双_累胜50奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_累胜50奖励.TabIndex = 139;
		this.textBox47.Location = new System.Drawing.Point(6, 51);
		this.textBox47.Name = "textBox47";
		this.textBox47.ReadOnly = true;
		this.textBox47.Size = new System.Drawing.Size(80, 23);
		this.textBox47.TabIndex = 138;
		this.textBox47.Text = "累胜50场";
		this.textBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_连胜100奖励.Location = new System.Drawing.Point(87, 255);
		this.无双_连胜100奖励.Name = "无双_连胜100奖励";
		this.无双_连胜100奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_连胜100奖励.TabIndex = 137;
		this.textBox49.Location = new System.Drawing.Point(6, 255);
		this.textBox49.Name = "textBox49";
		this.textBox49.ReadOnly = true;
		this.textBox49.Size = new System.Drawing.Size(80, 23);
		this.textBox49.TabIndex = 136;
		this.textBox49.Text = "连胜100场";
		this.textBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox50.Location = new System.Drawing.Point(6, 226);
		this.textBox50.Name = "textBox50";
		this.textBox50.ReadOnly = true;
		this.textBox50.Size = new System.Drawing.Size(80, 23);
		this.textBox50.TabIndex = 135;
		this.textBox50.Text = "连胜50场";
		this.textBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox51.Location = new System.Drawing.Point(6, 197);
		this.textBox51.Name = "textBox51";
		this.textBox51.ReadOnly = true;
		this.textBox51.Size = new System.Drawing.Size(80, 23);
		this.textBox51.TabIndex = 133;
		this.textBox51.Text = "连胜30场";
		this.textBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox52.Location = new System.Drawing.Point(6, 168);
		this.textBox52.Name = "textBox52";
		this.textBox52.ReadOnly = true;
		this.textBox52.Size = new System.Drawing.Size(80, 23);
		this.textBox52.TabIndex = 131;
		this.textBox52.Text = "连胜10场";
		this.textBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox53.Location = new System.Drawing.Point(6, 139);
		this.textBox53.Name = "textBox53";
		this.textBox53.ReadOnly = true;
		this.textBox53.Size = new System.Drawing.Size(80, 23);
		this.textBox53.TabIndex = 129;
		this.textBox53.Text = "累胜500场";
		this.textBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox54.Location = new System.Drawing.Point(6, 109);
		this.textBox54.Name = "textBox54";
		this.textBox54.ReadOnly = true;
		this.textBox54.Size = new System.Drawing.Size(80, 23);
		this.textBox54.TabIndex = 128;
		this.textBox54.Text = "累胜200场";
		this.textBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_累胜100奖励.Location = new System.Drawing.Point(87, 80);
		this.无双_累胜100奖励.Name = "无双_累胜100奖励";
		this.无双_累胜100奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_累胜100奖励.TabIndex = 125;
		this.textBox56.Location = new System.Drawing.Point(6, 80);
		this.textBox56.Name = "textBox56";
		this.textBox56.ReadOnly = true;
		this.textBox56.Size = new System.Drawing.Size(80, 23);
		this.textBox56.TabIndex = 124;
		this.textBox56.Text = "累胜100场";
		this.textBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_累胜20奖励.Location = new System.Drawing.Point(87, 22);
		this.无双_累胜20奖励.Name = "无双_累胜20奖励";
		this.无双_累胜20奖励.Size = new System.Drawing.Size(100, 23);
		this.无双_累胜20奖励.TabIndex = 123;
		this.textBox58.Location = new System.Drawing.Point(6, 22);
		this.textBox58.Name = "textBox58";
		this.textBox58.ReadOnly = true;
		this.textBox58.Size = new System.Drawing.Size(80, 23);
		this.textBox58.TabIndex = 122;
		this.textBox58.Text = "累胜20场";
		this.textBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_开始前公告.Location = new System.Drawing.Point(93, 487);
		this.无双_开始前公告.Name = "无双_开始前公告";
		this.无双_开始前公告.Size = new System.Drawing.Size(671, 23);
		this.无双_开始前公告.TabIndex = 139;
		this.无双_开始前公告.Text = "#Y【无双争夺战】#n活动还有#Y{0}#n分钟就要开始了，请要参加的道友计时报名，以免错过活动时间。#@点击报名|Open:ArenaEntryDlg#@";
		this.textBox60.Location = new System.Drawing.Point(12, 487);
		this.textBox60.Name = "textBox60";
		this.textBox60.ReadOnly = true;
		this.textBox60.Size = new System.Drawing.Size(80, 23);
		this.textBox60.TabIndex = 138;
		this.textBox60.Text = "开启之前公告";
		this.textBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_开始后公告.Location = new System.Drawing.Point(93, 516);
		this.无双_开始后公告.Name = "无双_开始后公告";
		this.无双_开始后公告.Size = new System.Drawing.Size(671, 23);
		this.无双_开始后公告.TabIndex = 141;
		this.无双_开始后公告.Text = "#Y【无双争夺战】#n活动正在激烈进行中，当前参与的人数为#R{0}#n人，乾坤未定，诸位皆是黑马！";
		this.textBox62.Location = new System.Drawing.Point(12, 516);
		this.textBox62.Name = "textBox62";
		this.textBox62.ReadOnly = true;
		this.textBox62.Size = new System.Drawing.Size(80, 23);
		this.textBox62.TabIndex = 140;
		this.textBox62.Text = "开启之后公告";
		this.textBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_结束后公告.Location = new System.Drawing.Point(93, 545);
		this.无双_结束后公告.Name = "无双_结束后公告";
		this.无双_结束后公告.Size = new System.Drawing.Size(671, 23);
		this.无双_结束后公告.TabIndex = 143;
		this.无双_结束后公告.Text = "#Y【无双争夺战】#n经过一番激烈展争夺战斗后，终于结束了，恭喜#Y{0}#n击败众多道友，战到最后，荣登圣位，成为新任的#Y无双大圣#n，与天同齐，特此在九州大陆#Z天墉城#Z设立雕像，供世人膜拜，享人间香火，聚九州信仰！";
		this.textBox64.Location = new System.Drawing.Point(12, 545);
		this.textBox64.Name = "textBox64";
		this.textBox64.ReadOnly = true;
		this.textBox64.Size = new System.Drawing.Size(80, 23);
		this.textBox64.TabIndex = 142;
		this.textBox64.Text = "活动结束公告";
		this.textBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.groupBox5.Controls.Add(this.无双_战场人数);
		this.groupBox5.Controls.Add(this.无双_战场列表);
		this.groupBox5.Controls.Add(this.无双_刷新战场按钮);
		this.groupBox5.Controls.Add(this.无双_结束按钮);
		this.groupBox5.Controls.Add(this.无双_开启按钮);
		this.groupBox5.Controls.Add(this.无双_活动状态);
		this.groupBox5.Controls.Add(this.textBox66);
		this.groupBox5.Location = new System.Drawing.Point(770, 8);
		this.groupBox5.Name = "groupBox5";
		this.groupBox5.Size = new System.Drawing.Size(402, 560);
		this.groupBox5.TabIndex = 144;
		this.groupBox5.TabStop = false;
		this.groupBox5.Text = "无双战场实时数据";
		this.无双_战场人数.Location = new System.Drawing.Point(162, 56);
		this.无双_战场人数.Name = "无双_战场人数";
		this.无双_战场人数.Size = new System.Drawing.Size(237, 23);
		this.无双_战场人数.TabIndex = 171;
		this.无双_战场人数.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.无双_战场列表.AllowUserToAddRows = false;
		this.无双_战场列表.AllowUserToDeleteRows = false;
		this.无双_战场列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.无双_战场列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.无双_战场列表.BackgroundColor = System.Drawing.Color.White;
		this.无双_战场列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.无双_战场列表.Columns.AddRange(this.道友名字, this.是否报名, this.当前状态, this.无双积分);
		this.无双_战场列表.Location = new System.Drawing.Point(6, 85);
		this.无双_战场列表.MultiSelect = false;
		this.无双_战场列表.Name = "无双_战场列表";
		this.无双_战场列表.RowHeadersVisible = false;
		this.无双_战场列表.RowTemplate.Height = 25;
		this.无双_战场列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.无双_战场列表.Size = new System.Drawing.Size(393, 469);
		this.无双_战场列表.TabIndex = 170;
		this.道友名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.道友名字.Frozen = true;
		this.道友名字.HeaderText = "道友名字";
		this.道友名字.MinimumWidth = 100;
		this.道友名字.Name = "道友名字";
		this.道友名字.ReadOnly = true;
		this.是否报名.HeaderText = "是否报名";
		this.是否报名.MinimumWidth = 80;
		this.是否报名.Name = "是否报名";
		this.是否报名.Width = 80;
		this.当前状态.HeaderText = "当前状态";
		this.当前状态.MinimumWidth = 80;
		this.当前状态.Name = "当前状态";
		this.当前状态.Width = 80;
		this.无双积分.HeaderText = "无双积分";
		this.无双积分.MinimumWidth = 90;
		this.无双积分.Name = "无双积分";
		this.无双积分.Width = 90;
		this.无双_刷新战场按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.无双_刷新战场按钮.Location = new System.Drawing.Point(6, 56);
		this.无双_刷新战场按钮.Name = "无双_刷新战场按钮";
		this.无双_刷新战场按钮.Size = new System.Drawing.Size(150, 23);
		this.无双_刷新战场按钮.TabIndex = 128;
		this.无双_刷新战场按钮.Text = "刷新当前战场道友列表";
		this.无双_刷新战场按钮.UseVisualStyleBackColor = true;
		this.无双_刷新战场按钮.Click += new System.EventHandler(无双_刷新战场按钮_Click);
		this.无双_结束按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.无双_结束按钮.Location = new System.Drawing.Point(299, 22);
		this.无双_结束按钮.Name = "无双_结束按钮";
		this.无双_结束按钮.Size = new System.Drawing.Size(100, 23);
		this.无双_结束按钮.TabIndex = 127;
		this.无双_结束按钮.Text = "结束活动";
		this.无双_结束按钮.UseVisualStyleBackColor = true;
		this.无双_结束按钮.Click += new System.EventHandler(无双_结束按钮_Click);
		this.无双_开启按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.无双_开启按钮.Location = new System.Drawing.Point(193, 22);
		this.无双_开启按钮.Name = "无双_开启按钮";
		this.无双_开启按钮.Size = new System.Drawing.Size(100, 23);
		this.无双_开启按钮.TabIndex = 126;
		this.无双_开启按钮.Text = "开启活动";
		this.无双_开启按钮.UseVisualStyleBackColor = true;
		this.无双_开启按钮.Click += new System.EventHandler(无双_开启按钮_Click);
		this.无双_活动状态.BackColor = System.Drawing.Color.Yellow;
		this.无双_活动状态.ForeColor = System.Drawing.Color.Red;
		this.无双_活动状态.Location = new System.Drawing.Point(87, 22);
		this.无双_活动状态.Name = "无双_活动状态";
		this.无双_活动状态.ReadOnly = true;
		this.无双_活动状态.Size = new System.Drawing.Size(100, 23);
		this.无双_活动状态.TabIndex = 125;
		this.无双_活动状态.Text = "未开启";
		this.无双_活动状态.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox66.Location = new System.Drawing.Point(6, 22);
		this.textBox66.Name = "textBox66";
		this.textBox66.ReadOnly = true;
		this.textBox66.Size = new System.Drawing.Size(80, 23);
		this.textBox66.TabIndex = 124;
		this.textBox66.Text = "活动开启状态";
		this.textBox66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox1.Location = new System.Drawing.Point(574, 12);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(80, 23);
		this.textBox1.TabIndex = 147;
		this.textBox1.Text = "每次参拜增幅";
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.无双_每次参拜雕像增幅.Location = new System.Drawing.Point(655, 12);
		this.无双_每次参拜雕像增幅.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.无双_每次参拜雕像增幅.Name = "无双_每次参拜雕像增幅";
		this.无双_每次参拜雕像增幅.Size = new System.Drawing.Size(100, 23);
		this.无双_每次参拜雕像增幅.TabIndex = 146;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(1184, 583);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.无双_每次参拜雕像增幅);
		base.Controls.Add(this.groupBox5);
		base.Controls.Add(this.无双_结束后公告);
		base.Controls.Add(this.textBox64);
		base.Controls.Add(this.无双_开始后公告);
		base.Controls.Add(this.textBox62);
		base.Controls.Add(this.无双_开始前公告);
		base.Controls.Add(this.textBox60);
		base.Controls.Add(this.groupBox4);
		base.Controls.Add(this.groupBox3);
		base.Controls.Add(this.无双_同IP战斗开关);
		base.Controls.Add(this.无双_匹配开关);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.无双_开关);
		base.Controls.Add(this.无双_重载按钮);
		base.Controls.Add(this.无双_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "无双争夺战配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "无双争夺战配置窗口";
		base.Load += new System.EventHandler(无双争夺战配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.无双_每日参拜次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.无双_参拜消耗价格).EndInit();
		((System.ComponentModel.ISupportInitialize)this.无双_形象).EndInit();
		((System.ComponentModel.ISupportInitialize)this.无双_坐标Y).EndInit();
		((System.ComponentModel.ISupportInitialize)this.无双_坐标X).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.无双_积分兑换比例).EndInit();
		((System.ComponentModel.ISupportInitialize)this.无双_胜利夺取积分).EndInit();
		((System.ComponentModel.ISupportInitialize)this.无双_初始无双积分).EndInit();
		((System.ComponentModel.ISupportInitialize)this.无双_开启最低人数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.无双_报名花费价格).EndInit();
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		this.groupBox4.ResumeLayout(false);
		this.groupBox4.PerformLayout();
		this.groupBox5.ResumeLayout(false);
		this.groupBox5.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.无双_战场列表).EndInit();
		((System.ComponentModel.ISupportInitialize)this.无双_每次参拜雕像增幅).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
