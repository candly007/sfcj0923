using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 签到配置窗口 : Form
{
	private static 签到配置窗口 i;

	private IContainer components;

	private CheckBox 签到_开关;

	private Button 签到_重载按钮;

	private Button 签到_保存按钮;

	private TextBox 地狱道_名字;

	private TextBox 签到每日_道具;

	private NumericUpDown 签到每日_金元宝;

	private TextBox textBox1;

	private TextBox textBox2;

	private TextBox textBox3;

	private NumericUpDown 签到每日_银元宝;

	private TextBox textBox4;

	private NumericUpDown 签到每日_南极点;

	private TextBox textBox5;

	private NumericUpDown 签到每日_累充点;

	private TextBox textBox6;

	private NumericUpDown 签到5日_累充点;

	private TextBox textBox7;

	private NumericUpDown 签到5日_南极点;

	private TextBox textBox8;

	private NumericUpDown 签到5日_银元宝;

	private TextBox textBox9;

	private TextBox textBox10;

	private TextBox textBox11;

	private TextBox 签到5日_道具;

	private NumericUpDown 签到5日_金元宝;

	private TextBox textBox13;

	private NumericUpDown 签到10日_累充点;

	private TextBox textBox14;

	private NumericUpDown 签到10日_南极点;

	private TextBox textBox15;

	private NumericUpDown 签到10日_银元宝;

	private TextBox textBox16;

	private TextBox textBox17;

	private TextBox textBox18;

	private TextBox 签到10日_道具;

	private NumericUpDown 签到10日_金元宝;

	private TextBox textBox20;

	private NumericUpDown 签到20日_累充点;

	private TextBox textBox21;

	private NumericUpDown 签到20日_南极点;

	private TextBox textBox22;

	private NumericUpDown 签到20日_银元宝;

	private TextBox textBox23;

	private TextBox textBox24;

	private TextBox textBox25;

	private TextBox 签到20日_道具;

	private NumericUpDown 签到20日_金元宝;

	private TextBox textBox27;

	private NumericUpDown 签到30日_累充点;

	private TextBox textBox28;

	private NumericUpDown 签到30日_南极点;

	private TextBox textBox29;

	private NumericUpDown 签到30日_银元宝;

	private TextBox textBox30;

	private TextBox textBox31;

	private TextBox textBox32;

	private TextBox 签到30日_道具;

	private NumericUpDown 签到30日_金元宝;

	private TextBox textBox34;

	private NumericUpDown 签到40日_累充点;

	private TextBox textBox35;

	private NumericUpDown 签到40日_南极点;

	private TextBox textBox36;

	private NumericUpDown 签到40日_银元宝;

	private TextBox textBox37;

	private TextBox textBox38;

	private TextBox textBox39;

	private TextBox 签到40日_道具;

	private NumericUpDown 签到40日_金元宝;

	private TextBox textBox41;

	private NumericUpDown 签到50日_累充点;

	private TextBox textBox42;

	private NumericUpDown 签到50日_南极点;

	private TextBox textBox43;

	private NumericUpDown 签到50日_银元宝;

	private TextBox textBox44;

	private TextBox textBox45;

	private TextBox textBox46;

	private TextBox 签到50日_道具;

	private NumericUpDown 签到50日_金元宝;

	private TextBox textBox48;

	private NumericUpDown 签到60日_累充点;

	private TextBox textBox49;

	private NumericUpDown 签到60日_南极点;

	private TextBox textBox50;

	private NumericUpDown 签到60日_银元宝;

	private TextBox textBox51;

	private TextBox textBox52;

	private TextBox textBox53;

	private TextBox 签到60日_道具;

	private NumericUpDown 签到60日_金元宝;

	private TextBox textBox55;

	private NumericUpDown 签到70日_累充点;

	private TextBox textBox56;

	private NumericUpDown 签到70日_南极点;

	private TextBox textBox57;

	private NumericUpDown 签到70日_银元宝;

	private TextBox textBox58;

	private TextBox textBox59;

	private TextBox textBox60;

	private TextBox 签到70日_道具;

	private NumericUpDown 签到70日_金元宝;

	private TextBox textBox62;

	private NumericUpDown 签到100日_累充点;

	private TextBox textBox63;

	private NumericUpDown 签到100日_南极点;

	private TextBox textBox64;

	private NumericUpDown 签到100日_银元宝;

	private TextBox textBox65;

	private TextBox textBox66;

	private TextBox textBox67;

	private TextBox 签到100日_道具;

	private NumericUpDown 签到100日_金元宝;

	private TextBox textBox69;

	private NumericUpDown 签到90日_累充点;

	private TextBox textBox70;

	private NumericUpDown 签到90日_南极点;

	private TextBox textBox71;

	private NumericUpDown 签到90日_银元宝;

	private TextBox textBox72;

	private TextBox textBox73;

	private TextBox textBox74;

	private TextBox 签到90日_道具;

	private NumericUpDown 签到90日_金元宝;

	private TextBox textBox76;

	private NumericUpDown 签到80日_累充点;

	private TextBox textBox77;

	private NumericUpDown 签到80日_南极点;

	private TextBox textBox78;

	private NumericUpDown 签到80日_银元宝;

	private TextBox textBox79;

	private TextBox textBox80;

	private TextBox textBox81;

	private TextBox 签到80日_道具;

	private NumericUpDown 签到80日_金元宝;

	private Label label1;

	public static 签到配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 签到配置窗口();
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
	}

	public 签到配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 签到配置窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		签到_重载按钮_Click(sender, e);
	}

	private void 签到_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 41, JsonConvert.SerializeObject(Singleton<全局变量类>.I.签到配置, Formatting.Indented));
		}
	}

	private void 签到_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 41);
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (base.IsHandleCreated && 配置类型 == 41)
		{
			Invoke((MethodInvoker)delegate
			{
				签到_开关.Checked = Singleton<全局变量类>.I.签到配置.功能开关;
				签到每日_道具.Text = Singleton<全局变量类>.I.签到配置.每日签到奖励.道具;
				签到每日_金元宝.Value = Singleton<全局变量类>.I.签到配置.每日签到奖励.金元宝;
				签到每日_银元宝.Value = Singleton<全局变量类>.I.签到配置.每日签到奖励.银元宝;
				签到每日_南极点.Value = Singleton<全局变量类>.I.签到配置.每日签到奖励.南极点;
				签到每日_累充点.Value = Singleton<全局变量类>.I.签到配置.每日签到奖励.累充点;
				签到5日_道具.Text = Singleton<全局变量类>.I.签到配置.累计5天签到奖励.道具;
				签到5日_金元宝.Value = Singleton<全局变量类>.I.签到配置.累计5天签到奖励.金元宝;
				签到5日_银元宝.Value = Singleton<全局变量类>.I.签到配置.累计5天签到奖励.银元宝;
				签到5日_南极点.Value = Singleton<全局变量类>.I.签到配置.累计5天签到奖励.南极点;
				签到5日_累充点.Value = Singleton<全局变量类>.I.签到配置.累计5天签到奖励.累充点;
				签到10日_道具.Text = Singleton<全局变量类>.I.签到配置.累计10天签到奖励.道具;
				签到10日_金元宝.Value = Singleton<全局变量类>.I.签到配置.累计10天签到奖励.金元宝;
				签到10日_银元宝.Value = Singleton<全局变量类>.I.签到配置.累计10天签到奖励.银元宝;
				签到10日_南极点.Value = Singleton<全局变量类>.I.签到配置.累计10天签到奖励.南极点;
				签到10日_累充点.Value = Singleton<全局变量类>.I.签到配置.累计10天签到奖励.累充点;
				签到20日_道具.Text = Singleton<全局变量类>.I.签到配置.累计20天签到奖励.道具;
				签到20日_金元宝.Value = Singleton<全局变量类>.I.签到配置.累计20天签到奖励.金元宝;
				签到20日_银元宝.Value = Singleton<全局变量类>.I.签到配置.累计20天签到奖励.银元宝;
				签到20日_南极点.Value = Singleton<全局变量类>.I.签到配置.累计20天签到奖励.南极点;
				签到20日_累充点.Value = Singleton<全局变量类>.I.签到配置.累计20天签到奖励.累充点;
				签到30日_道具.Text = Singleton<全局变量类>.I.签到配置.累计30天签到奖励.道具;
				签到30日_金元宝.Value = Singleton<全局变量类>.I.签到配置.累计30天签到奖励.金元宝;
				签到30日_银元宝.Value = Singleton<全局变量类>.I.签到配置.累计30天签到奖励.银元宝;
				签到30日_南极点.Value = Singleton<全局变量类>.I.签到配置.累计30天签到奖励.南极点;
				签到30日_累充点.Value = Singleton<全局变量类>.I.签到配置.累计30天签到奖励.累充点;
				签到40日_道具.Text = Singleton<全局变量类>.I.签到配置.累计40天签到奖励.道具;
				签到40日_金元宝.Value = Singleton<全局变量类>.I.签到配置.累计40天签到奖励.金元宝;
				签到40日_银元宝.Value = Singleton<全局变量类>.I.签到配置.累计40天签到奖励.银元宝;
				签到40日_南极点.Value = Singleton<全局变量类>.I.签到配置.累计40天签到奖励.南极点;
				签到40日_累充点.Value = Singleton<全局变量类>.I.签到配置.累计40天签到奖励.累充点;
				签到50日_道具.Text = Singleton<全局变量类>.I.签到配置.累计50天签到奖励.道具;
				签到50日_金元宝.Value = Singleton<全局变量类>.I.签到配置.累计50天签到奖励.金元宝;
				签到50日_银元宝.Value = Singleton<全局变量类>.I.签到配置.累计50天签到奖励.银元宝;
				签到50日_南极点.Value = Singleton<全局变量类>.I.签到配置.累计50天签到奖励.南极点;
				签到50日_累充点.Value = Singleton<全局变量类>.I.签到配置.累计50天签到奖励.累充点;
				签到60日_道具.Text = Singleton<全局变量类>.I.签到配置.累计60天签到奖励.道具;
				签到60日_金元宝.Value = Singleton<全局变量类>.I.签到配置.累计60天签到奖励.金元宝;
				签到60日_银元宝.Value = Singleton<全局变量类>.I.签到配置.累计60天签到奖励.银元宝;
				签到60日_南极点.Value = Singleton<全局变量类>.I.签到配置.累计60天签到奖励.南极点;
				签到60日_累充点.Value = Singleton<全局变量类>.I.签到配置.累计60天签到奖励.累充点;
				签到70日_道具.Text = Singleton<全局变量类>.I.签到配置.累计70天签到奖励.道具;
				签到70日_金元宝.Value = Singleton<全局变量类>.I.签到配置.累计70天签到奖励.金元宝;
				签到70日_银元宝.Value = Singleton<全局变量类>.I.签到配置.累计70天签到奖励.银元宝;
				签到70日_南极点.Value = Singleton<全局变量类>.I.签到配置.累计70天签到奖励.南极点;
				签到70日_累充点.Value = Singleton<全局变量类>.I.签到配置.累计70天签到奖励.累充点;
				签到80日_道具.Text = Singleton<全局变量类>.I.签到配置.累计80天签到奖励.道具;
				签到80日_金元宝.Value = Singleton<全局变量类>.I.签到配置.累计80天签到奖励.金元宝;
				签到80日_银元宝.Value = Singleton<全局变量类>.I.签到配置.累计80天签到奖励.银元宝;
				签到80日_南极点.Value = Singleton<全局变量类>.I.签到配置.累计80天签到奖励.南极点;
				签到80日_累充点.Value = Singleton<全局变量类>.I.签到配置.累计80天签到奖励.累充点;
				签到90日_道具.Text = Singleton<全局变量类>.I.签到配置.累计90天签到奖励.道具;
				签到90日_金元宝.Value = Singleton<全局变量类>.I.签到配置.累计90天签到奖励.金元宝;
				签到90日_银元宝.Value = Singleton<全局变量类>.I.签到配置.累计90天签到奖励.银元宝;
				签到90日_南极点.Value = Singleton<全局变量类>.I.签到配置.累计90天签到奖励.南极点;
				签到90日_累充点.Value = Singleton<全局变量类>.I.签到配置.累计90天签到奖励.累充点;
				签到100日_道具.Text = Singleton<全局变量类>.I.签到配置.累计100天签到奖励.道具;
				签到100日_金元宝.Value = Singleton<全局变量类>.I.签到配置.累计100天签到奖励.金元宝;
				签到100日_银元宝.Value = Singleton<全局变量类>.I.签到配置.累计100天签到奖励.银元宝;
				签到100日_南极点.Value = Singleton<全局变量类>.I.签到配置.累计100天签到奖励.南极点;
				签到100日_累充点.Value = Singleton<全局变量类>.I.签到配置.累计100天签到奖励.累充点;
			});
		}
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.签到配置.功能开关 = 签到_开关.Checked;
			Singleton<全局变量类>.I.签到配置.每日签到奖励.道具 = 签到每日_道具.Text;
			Singleton<全局变量类>.I.签到配置.每日签到奖励.金元宝 = (int)签到每日_金元宝.Value;
			Singleton<全局变量类>.I.签到配置.每日签到奖励.银元宝 = (int)签到每日_银元宝.Value;
			Singleton<全局变量类>.I.签到配置.每日签到奖励.南极点 = (int)签到每日_南极点.Value;
			Singleton<全局变量类>.I.签到配置.每日签到奖励.累充点 = (int)签到每日_累充点.Value;
			Singleton<全局变量类>.I.签到配置.累计5天签到奖励.道具 = 签到5日_道具.Text;
			Singleton<全局变量类>.I.签到配置.累计5天签到奖励.金元宝 = (int)签到5日_金元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计5天签到奖励.银元宝 = (int)签到5日_银元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计5天签到奖励.南极点 = (int)签到5日_南极点.Value;
			Singleton<全局变量类>.I.签到配置.累计5天签到奖励.累充点 = (int)签到5日_累充点.Value;
			Singleton<全局变量类>.I.签到配置.累计10天签到奖励.道具 = 签到10日_道具.Text;
			Singleton<全局变量类>.I.签到配置.累计10天签到奖励.金元宝 = (int)签到10日_金元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计10天签到奖励.银元宝 = (int)签到10日_银元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计10天签到奖励.南极点 = (int)签到10日_南极点.Value;
			Singleton<全局变量类>.I.签到配置.累计10天签到奖励.累充点 = (int)签到10日_累充点.Value;
			Singleton<全局变量类>.I.签到配置.累计20天签到奖励.道具 = 签到20日_道具.Text;
			Singleton<全局变量类>.I.签到配置.累计20天签到奖励.金元宝 = (int)签到20日_金元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计20天签到奖励.银元宝 = (int)签到20日_银元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计20天签到奖励.南极点 = (int)签到20日_南极点.Value;
			Singleton<全局变量类>.I.签到配置.累计20天签到奖励.累充点 = (int)签到20日_累充点.Value;
			Singleton<全局变量类>.I.签到配置.累计30天签到奖励.道具 = 签到30日_道具.Text;
			Singleton<全局变量类>.I.签到配置.累计30天签到奖励.金元宝 = (int)签到30日_金元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计30天签到奖励.银元宝 = (int)签到30日_银元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计30天签到奖励.南极点 = (int)签到30日_南极点.Value;
			Singleton<全局变量类>.I.签到配置.累计30天签到奖励.累充点 = (int)签到30日_累充点.Value;
			Singleton<全局变量类>.I.签到配置.累计40天签到奖励.道具 = 签到40日_道具.Text;
			Singleton<全局变量类>.I.签到配置.累计40天签到奖励.金元宝 = (int)签到40日_金元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计40天签到奖励.银元宝 = (int)签到40日_银元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计40天签到奖励.南极点 = (int)签到40日_南极点.Value;
			Singleton<全局变量类>.I.签到配置.累计40天签到奖励.累充点 = (int)签到40日_累充点.Value;
			Singleton<全局变量类>.I.签到配置.累计50天签到奖励.道具 = 签到50日_道具.Text;
			Singleton<全局变量类>.I.签到配置.累计50天签到奖励.金元宝 = (int)签到50日_金元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计50天签到奖励.银元宝 = (int)签到50日_银元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计50天签到奖励.南极点 = (int)签到50日_南极点.Value;
			Singleton<全局变量类>.I.签到配置.累计50天签到奖励.累充点 = (int)签到50日_累充点.Value;
			Singleton<全局变量类>.I.签到配置.累计60天签到奖励.道具 = 签到60日_道具.Text;
			Singleton<全局变量类>.I.签到配置.累计60天签到奖励.金元宝 = (int)签到60日_金元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计60天签到奖励.银元宝 = (int)签到60日_银元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计60天签到奖励.南极点 = (int)签到60日_南极点.Value;
			Singleton<全局变量类>.I.签到配置.累计60天签到奖励.累充点 = (int)签到60日_累充点.Value;
			Singleton<全局变量类>.I.签到配置.累计70天签到奖励.道具 = 签到70日_道具.Text;
			Singleton<全局变量类>.I.签到配置.累计70天签到奖励.金元宝 = (int)签到70日_金元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计70天签到奖励.银元宝 = (int)签到70日_银元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计70天签到奖励.南极点 = (int)签到70日_南极点.Value;
			Singleton<全局变量类>.I.签到配置.累计70天签到奖励.累充点 = (int)签到70日_累充点.Value;
			Singleton<全局变量类>.I.签到配置.累计80天签到奖励.道具 = 签到80日_道具.Text;
			Singleton<全局变量类>.I.签到配置.累计80天签到奖励.金元宝 = (int)签到80日_金元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计80天签到奖励.银元宝 = (int)签到80日_银元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计80天签到奖励.南极点 = (int)签到80日_南极点.Value;
			Singleton<全局变量类>.I.签到配置.累计80天签到奖励.累充点 = (int)签到80日_累充点.Value;
			Singleton<全局变量类>.I.签到配置.累计90天签到奖励.道具 = 签到90日_道具.Text;
			Singleton<全局变量类>.I.签到配置.累计90天签到奖励.金元宝 = (int)签到90日_金元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计90天签到奖励.银元宝 = (int)签到90日_银元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计90天签到奖励.南极点 = (int)签到90日_南极点.Value;
			Singleton<全局变量类>.I.签到配置.累计90天签到奖励.累充点 = (int)签到90日_累充点.Value;
			Singleton<全局变量类>.I.签到配置.累计100天签到奖励.道具 = 签到100日_道具.Text;
			Singleton<全局变量类>.I.签到配置.累计100天签到奖励.金元宝 = (int)签到100日_金元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计100天签到奖励.银元宝 = (int)签到100日_银元宝.Value;
			Singleton<全局变量类>.I.签到配置.累计100天签到奖励.南极点 = (int)签到100日_南极点.Value;
			Singleton<全局变量类>.I.签到配置.累计100天签到奖励.累充点 = (int)签到100日_累充点.Value;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.签到配置窗口));
		this.签到_开关 = new System.Windows.Forms.CheckBox();
		this.签到_重载按钮 = new System.Windows.Forms.Button();
		this.签到_保存按钮 = new System.Windows.Forms.Button();
		this.地狱道_名字 = new System.Windows.Forms.TextBox();
		this.签到每日_道具 = new System.Windows.Forms.TextBox();
		this.签到每日_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.签到每日_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.签到每日_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.签到每日_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox6 = new System.Windows.Forms.TextBox();
		this.签到5日_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox7 = new System.Windows.Forms.TextBox();
		this.签到5日_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox8 = new System.Windows.Forms.TextBox();
		this.签到5日_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox9 = new System.Windows.Forms.TextBox();
		this.textBox10 = new System.Windows.Forms.TextBox();
		this.textBox11 = new System.Windows.Forms.TextBox();
		this.签到5日_道具 = new System.Windows.Forms.TextBox();
		this.签到5日_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox13 = new System.Windows.Forms.TextBox();
		this.签到10日_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox14 = new System.Windows.Forms.TextBox();
		this.签到10日_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox15 = new System.Windows.Forms.TextBox();
		this.签到10日_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox16 = new System.Windows.Forms.TextBox();
		this.textBox17 = new System.Windows.Forms.TextBox();
		this.textBox18 = new System.Windows.Forms.TextBox();
		this.签到10日_道具 = new System.Windows.Forms.TextBox();
		this.签到10日_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox20 = new System.Windows.Forms.TextBox();
		this.签到20日_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox21 = new System.Windows.Forms.TextBox();
		this.签到20日_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox22 = new System.Windows.Forms.TextBox();
		this.签到20日_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox23 = new System.Windows.Forms.TextBox();
		this.textBox24 = new System.Windows.Forms.TextBox();
		this.textBox25 = new System.Windows.Forms.TextBox();
		this.签到20日_道具 = new System.Windows.Forms.TextBox();
		this.签到20日_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox27 = new System.Windows.Forms.TextBox();
		this.签到30日_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox28 = new System.Windows.Forms.TextBox();
		this.签到30日_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox29 = new System.Windows.Forms.TextBox();
		this.签到30日_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox30 = new System.Windows.Forms.TextBox();
		this.textBox31 = new System.Windows.Forms.TextBox();
		this.textBox32 = new System.Windows.Forms.TextBox();
		this.签到30日_道具 = new System.Windows.Forms.TextBox();
		this.签到30日_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox34 = new System.Windows.Forms.TextBox();
		this.签到40日_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox35 = new System.Windows.Forms.TextBox();
		this.签到40日_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox36 = new System.Windows.Forms.TextBox();
		this.签到40日_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox37 = new System.Windows.Forms.TextBox();
		this.textBox38 = new System.Windows.Forms.TextBox();
		this.textBox39 = new System.Windows.Forms.TextBox();
		this.签到40日_道具 = new System.Windows.Forms.TextBox();
		this.签到40日_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox41 = new System.Windows.Forms.TextBox();
		this.签到50日_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox42 = new System.Windows.Forms.TextBox();
		this.签到50日_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox43 = new System.Windows.Forms.TextBox();
		this.签到50日_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox44 = new System.Windows.Forms.TextBox();
		this.textBox45 = new System.Windows.Forms.TextBox();
		this.textBox46 = new System.Windows.Forms.TextBox();
		this.签到50日_道具 = new System.Windows.Forms.TextBox();
		this.签到50日_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox48 = new System.Windows.Forms.TextBox();
		this.签到60日_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox49 = new System.Windows.Forms.TextBox();
		this.签到60日_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox50 = new System.Windows.Forms.TextBox();
		this.签到60日_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox51 = new System.Windows.Forms.TextBox();
		this.textBox52 = new System.Windows.Forms.TextBox();
		this.textBox53 = new System.Windows.Forms.TextBox();
		this.签到60日_道具 = new System.Windows.Forms.TextBox();
		this.签到60日_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox55 = new System.Windows.Forms.TextBox();
		this.签到70日_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox56 = new System.Windows.Forms.TextBox();
		this.签到70日_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox57 = new System.Windows.Forms.TextBox();
		this.签到70日_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox58 = new System.Windows.Forms.TextBox();
		this.textBox59 = new System.Windows.Forms.TextBox();
		this.textBox60 = new System.Windows.Forms.TextBox();
		this.签到70日_道具 = new System.Windows.Forms.TextBox();
		this.签到70日_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox62 = new System.Windows.Forms.TextBox();
		this.签到100日_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox63 = new System.Windows.Forms.TextBox();
		this.签到100日_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox64 = new System.Windows.Forms.TextBox();
		this.签到100日_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox65 = new System.Windows.Forms.TextBox();
		this.textBox66 = new System.Windows.Forms.TextBox();
		this.textBox67 = new System.Windows.Forms.TextBox();
		this.签到100日_道具 = new System.Windows.Forms.TextBox();
		this.签到100日_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox69 = new System.Windows.Forms.TextBox();
		this.签到90日_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox70 = new System.Windows.Forms.TextBox();
		this.签到90日_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox71 = new System.Windows.Forms.TextBox();
		this.签到90日_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox72 = new System.Windows.Forms.TextBox();
		this.textBox73 = new System.Windows.Forms.TextBox();
		this.textBox74 = new System.Windows.Forms.TextBox();
		this.签到90日_道具 = new System.Windows.Forms.TextBox();
		this.签到90日_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox76 = new System.Windows.Forms.TextBox();
		this.签到80日_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox77 = new System.Windows.Forms.TextBox();
		this.签到80日_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox78 = new System.Windows.Forms.TextBox();
		this.签到80日_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox79 = new System.Windows.Forms.TextBox();
		this.textBox80 = new System.Windows.Forms.TextBox();
		this.textBox81 = new System.Windows.Forms.TextBox();
		this.签到80日_道具 = new System.Windows.Forms.TextBox();
		this.签到80日_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.label1 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.签到每日_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到每日_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到每日_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到每日_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到5日_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到5日_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到5日_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到5日_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到10日_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到10日_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到10日_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到10日_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到20日_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到20日_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到20日_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到20日_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到30日_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到30日_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到30日_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到30日_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到40日_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到40日_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到40日_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到40日_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到50日_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到50日_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到50日_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到50日_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到60日_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到60日_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到60日_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到60日_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到70日_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到70日_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到70日_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到70日_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到100日_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到100日_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到100日_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到100日_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到90日_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到90日_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到90日_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到90日_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到80日_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到80日_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到80日_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.签到80日_金元宝).BeginInit();
		base.SuspendLayout();
		this.签到_开关.AutoSize = true;
		this.签到_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.签到_开关.Location = new System.Drawing.Point(12, 12);
		this.签到_开关.Name = "签到_开关";
		this.签到_开关.Size = new System.Drawing.Size(106, 23);
		this.签到_开关.TabIndex = 117;
		this.签到_开关.Text = "签到功能开关";
		this.签到_开关.UseVisualStyleBackColor = true;
		this.签到_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.签到_重载按钮.Location = new System.Drawing.Point(246, 8);
		this.签到_重载按钮.Name = "签到_重载按钮";
		this.签到_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.签到_重载按钮.TabIndex = 119;
		this.签到_重载按钮.Text = "重载配置";
		this.签到_重载按钮.UseVisualStyleBackColor = true;
		this.签到_重载按钮.Click += new System.EventHandler(签到_重载按钮_Click);
		this.签到_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.签到_保存按钮.Location = new System.Drawing.Point(140, 8);
		this.签到_保存按钮.Name = "签到_保存按钮";
		this.签到_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.签到_保存按钮.TabIndex = 118;
		this.签到_保存按钮.Text = "保存配置";
		this.签到_保存按钮.UseVisualStyleBackColor = true;
		this.签到_保存按钮.Click += new System.EventHandler(签到_保存按钮_Click);
		this.地狱道_名字.Location = new System.Drawing.Point(12, 53);
		this.地狱道_名字.Name = "地狱道_名字";
		this.地狱道_名字.ReadOnly = true;
		this.地狱道_名字.Size = new System.Drawing.Size(90, 23);
		this.地狱道_名字.TabIndex = 131;
		this.地狱道_名字.Text = "每日签到奖励";
		this.地狱道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到每日_道具.Location = new System.Drawing.Point(154, 53);
		this.签到每日_道具.Name = "签到每日_道具";
		this.签到每日_道具.Size = new System.Drawing.Size(100, 23);
		this.签到每日_道具.TabIndex = 132;
		this.签到每日_金元宝.Location = new System.Drawing.Point(316, 53);
		this.签到每日_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到每日_金元宝.Name = "签到每日_金元宝";
		this.签到每日_金元宝.Size = new System.Drawing.Size(80, 23);
		this.签到每日_金元宝.TabIndex = 133;
		this.textBox1.Location = new System.Drawing.Point(108, 53);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(40, 23);
		this.textBox1.TabIndex = 134;
		this.textBox1.Text = "道具";
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox2.Location = new System.Drawing.Point(260, 53);
		this.textBox2.Name = "textBox2";
		this.textBox2.ReadOnly = true;
		this.textBox2.Size = new System.Drawing.Size(50, 23);
		this.textBox2.TabIndex = 135;
		this.textBox2.Text = "金元宝";
		this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox3.Location = new System.Drawing.Point(402, 53);
		this.textBox3.Name = "textBox3";
		this.textBox3.ReadOnly = true;
		this.textBox3.Size = new System.Drawing.Size(50, 23);
		this.textBox3.TabIndex = 137;
		this.textBox3.Text = "银元宝";
		this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到每日_银元宝.Location = new System.Drawing.Point(458, 53);
		this.签到每日_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到每日_银元宝.Name = "签到每日_银元宝";
		this.签到每日_银元宝.Size = new System.Drawing.Size(80, 23);
		this.签到每日_银元宝.TabIndex = 136;
		this.textBox4.Location = new System.Drawing.Point(544, 53);
		this.textBox4.Name = "textBox4";
		this.textBox4.ReadOnly = true;
		this.textBox4.Size = new System.Drawing.Size(50, 23);
		this.textBox4.TabIndex = 139;
		this.textBox4.Text = "南极点";
		this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到每日_南极点.Location = new System.Drawing.Point(600, 53);
		this.签到每日_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到每日_南极点.Name = "签到每日_南极点";
		this.签到每日_南极点.Size = new System.Drawing.Size(80, 23);
		this.签到每日_南极点.TabIndex = 138;
		this.textBox5.Location = new System.Drawing.Point(686, 53);
		this.textBox5.Name = "textBox5";
		this.textBox5.ReadOnly = true;
		this.textBox5.Size = new System.Drawing.Size(50, 23);
		this.textBox5.TabIndex = 141;
		this.textBox5.Text = "累充点";
		this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到每日_累充点.Location = new System.Drawing.Point(742, 53);
		this.签到每日_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到每日_累充点.Name = "签到每日_累充点";
		this.签到每日_累充点.Size = new System.Drawing.Size(80, 23);
		this.签到每日_累充点.TabIndex = 140;
		this.textBox6.Location = new System.Drawing.Point(686, 82);
		this.textBox6.Name = "textBox6";
		this.textBox6.ReadOnly = true;
		this.textBox6.Size = new System.Drawing.Size(50, 23);
		this.textBox6.TabIndex = 152;
		this.textBox6.Text = "累充点";
		this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到5日_累充点.Location = new System.Drawing.Point(742, 82);
		this.签到5日_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到5日_累充点.Name = "签到5日_累充点";
		this.签到5日_累充点.Size = new System.Drawing.Size(80, 23);
		this.签到5日_累充点.TabIndex = 151;
		this.textBox7.Location = new System.Drawing.Point(544, 82);
		this.textBox7.Name = "textBox7";
		this.textBox7.ReadOnly = true;
		this.textBox7.Size = new System.Drawing.Size(50, 23);
		this.textBox7.TabIndex = 150;
		this.textBox7.Text = "南极点";
		this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到5日_南极点.Location = new System.Drawing.Point(600, 82);
		this.签到5日_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到5日_南极点.Name = "签到5日_南极点";
		this.签到5日_南极点.Size = new System.Drawing.Size(80, 23);
		this.签到5日_南极点.TabIndex = 149;
		this.textBox8.Location = new System.Drawing.Point(402, 82);
		this.textBox8.Name = "textBox8";
		this.textBox8.ReadOnly = true;
		this.textBox8.Size = new System.Drawing.Size(50, 23);
		this.textBox8.TabIndex = 148;
		this.textBox8.Text = "银元宝";
		this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到5日_银元宝.Location = new System.Drawing.Point(458, 82);
		this.签到5日_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到5日_银元宝.Name = "签到5日_银元宝";
		this.签到5日_银元宝.Size = new System.Drawing.Size(80, 23);
		this.签到5日_银元宝.TabIndex = 147;
		this.textBox9.Location = new System.Drawing.Point(260, 82);
		this.textBox9.Name = "textBox9";
		this.textBox9.ReadOnly = true;
		this.textBox9.Size = new System.Drawing.Size(50, 23);
		this.textBox9.TabIndex = 146;
		this.textBox9.Text = "金元宝";
		this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox10.Location = new System.Drawing.Point(108, 82);
		this.textBox10.Name = "textBox10";
		this.textBox10.ReadOnly = true;
		this.textBox10.Size = new System.Drawing.Size(40, 23);
		this.textBox10.TabIndex = 145;
		this.textBox10.Text = "道具";
		this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox11.Location = new System.Drawing.Point(12, 82);
		this.textBox11.Name = "textBox11";
		this.textBox11.ReadOnly = true;
		this.textBox11.Size = new System.Drawing.Size(90, 23);
		this.textBox11.TabIndex = 142;
		this.textBox11.Text = "累计5天签到";
		this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到5日_道具.Location = new System.Drawing.Point(154, 82);
		this.签到5日_道具.Name = "签到5日_道具";
		this.签到5日_道具.Size = new System.Drawing.Size(100, 23);
		this.签到5日_道具.TabIndex = 143;
		this.签到5日_金元宝.Location = new System.Drawing.Point(316, 82);
		this.签到5日_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到5日_金元宝.Name = "签到5日_金元宝";
		this.签到5日_金元宝.Size = new System.Drawing.Size(80, 23);
		this.签到5日_金元宝.TabIndex = 144;
		this.textBox13.Location = new System.Drawing.Point(686, 111);
		this.textBox13.Name = "textBox13";
		this.textBox13.ReadOnly = true;
		this.textBox13.Size = new System.Drawing.Size(50, 23);
		this.textBox13.TabIndex = 163;
		this.textBox13.Text = "累充点";
		this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到10日_累充点.Location = new System.Drawing.Point(742, 111);
		this.签到10日_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到10日_累充点.Name = "签到10日_累充点";
		this.签到10日_累充点.Size = new System.Drawing.Size(80, 23);
		this.签到10日_累充点.TabIndex = 162;
		this.textBox14.Location = new System.Drawing.Point(544, 111);
		this.textBox14.Name = "textBox14";
		this.textBox14.ReadOnly = true;
		this.textBox14.Size = new System.Drawing.Size(50, 23);
		this.textBox14.TabIndex = 161;
		this.textBox14.Text = "南极点";
		this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到10日_南极点.Location = new System.Drawing.Point(600, 111);
		this.签到10日_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到10日_南极点.Name = "签到10日_南极点";
		this.签到10日_南极点.Size = new System.Drawing.Size(80, 23);
		this.签到10日_南极点.TabIndex = 160;
		this.textBox15.Location = new System.Drawing.Point(402, 111);
		this.textBox15.Name = "textBox15";
		this.textBox15.ReadOnly = true;
		this.textBox15.Size = new System.Drawing.Size(50, 23);
		this.textBox15.TabIndex = 159;
		this.textBox15.Text = "银元宝";
		this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到10日_银元宝.Location = new System.Drawing.Point(458, 111);
		this.签到10日_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到10日_银元宝.Name = "签到10日_银元宝";
		this.签到10日_银元宝.Size = new System.Drawing.Size(80, 23);
		this.签到10日_银元宝.TabIndex = 158;
		this.textBox16.Location = new System.Drawing.Point(260, 111);
		this.textBox16.Name = "textBox16";
		this.textBox16.ReadOnly = true;
		this.textBox16.Size = new System.Drawing.Size(50, 23);
		this.textBox16.TabIndex = 157;
		this.textBox16.Text = "金元宝";
		this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox17.Location = new System.Drawing.Point(108, 111);
		this.textBox17.Name = "textBox17";
		this.textBox17.ReadOnly = true;
		this.textBox17.Size = new System.Drawing.Size(40, 23);
		this.textBox17.TabIndex = 156;
		this.textBox17.Text = "道具";
		this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox18.Location = new System.Drawing.Point(12, 111);
		this.textBox18.Name = "textBox18";
		this.textBox18.ReadOnly = true;
		this.textBox18.Size = new System.Drawing.Size(90, 23);
		this.textBox18.TabIndex = 153;
		this.textBox18.Text = "累计10天签到";
		this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到10日_道具.Location = new System.Drawing.Point(154, 111);
		this.签到10日_道具.Name = "签到10日_道具";
		this.签到10日_道具.Size = new System.Drawing.Size(100, 23);
		this.签到10日_道具.TabIndex = 154;
		this.签到10日_金元宝.Location = new System.Drawing.Point(316, 111);
		this.签到10日_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到10日_金元宝.Name = "签到10日_金元宝";
		this.签到10日_金元宝.Size = new System.Drawing.Size(80, 23);
		this.签到10日_金元宝.TabIndex = 155;
		this.textBox20.Location = new System.Drawing.Point(686, 140);
		this.textBox20.Name = "textBox20";
		this.textBox20.ReadOnly = true;
		this.textBox20.Size = new System.Drawing.Size(50, 23);
		this.textBox20.TabIndex = 174;
		this.textBox20.Text = "累充点";
		this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到20日_累充点.Location = new System.Drawing.Point(742, 140);
		this.签到20日_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到20日_累充点.Name = "签到20日_累充点";
		this.签到20日_累充点.Size = new System.Drawing.Size(80, 23);
		this.签到20日_累充点.TabIndex = 173;
		this.textBox21.Location = new System.Drawing.Point(544, 140);
		this.textBox21.Name = "textBox21";
		this.textBox21.ReadOnly = true;
		this.textBox21.Size = new System.Drawing.Size(50, 23);
		this.textBox21.TabIndex = 172;
		this.textBox21.Text = "南极点";
		this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到20日_南极点.Location = new System.Drawing.Point(600, 140);
		this.签到20日_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到20日_南极点.Name = "签到20日_南极点";
		this.签到20日_南极点.Size = new System.Drawing.Size(80, 23);
		this.签到20日_南极点.TabIndex = 171;
		this.textBox22.Location = new System.Drawing.Point(402, 140);
		this.textBox22.Name = "textBox22";
		this.textBox22.ReadOnly = true;
		this.textBox22.Size = new System.Drawing.Size(50, 23);
		this.textBox22.TabIndex = 170;
		this.textBox22.Text = "银元宝";
		this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到20日_银元宝.Location = new System.Drawing.Point(458, 140);
		this.签到20日_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到20日_银元宝.Name = "签到20日_银元宝";
		this.签到20日_银元宝.Size = new System.Drawing.Size(80, 23);
		this.签到20日_银元宝.TabIndex = 169;
		this.textBox23.Location = new System.Drawing.Point(260, 140);
		this.textBox23.Name = "textBox23";
		this.textBox23.ReadOnly = true;
		this.textBox23.Size = new System.Drawing.Size(50, 23);
		this.textBox23.TabIndex = 168;
		this.textBox23.Text = "金元宝";
		this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox24.Location = new System.Drawing.Point(108, 140);
		this.textBox24.Name = "textBox24";
		this.textBox24.ReadOnly = true;
		this.textBox24.Size = new System.Drawing.Size(40, 23);
		this.textBox24.TabIndex = 167;
		this.textBox24.Text = "道具";
		this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox25.Location = new System.Drawing.Point(12, 140);
		this.textBox25.Name = "textBox25";
		this.textBox25.ReadOnly = true;
		this.textBox25.Size = new System.Drawing.Size(90, 23);
		this.textBox25.TabIndex = 164;
		this.textBox25.Text = "累计20天签到";
		this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到20日_道具.Location = new System.Drawing.Point(154, 140);
		this.签到20日_道具.Name = "签到20日_道具";
		this.签到20日_道具.Size = new System.Drawing.Size(100, 23);
		this.签到20日_道具.TabIndex = 165;
		this.签到20日_金元宝.Location = new System.Drawing.Point(316, 140);
		this.签到20日_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到20日_金元宝.Name = "签到20日_金元宝";
		this.签到20日_金元宝.Size = new System.Drawing.Size(80, 23);
		this.签到20日_金元宝.TabIndex = 166;
		this.textBox27.Location = new System.Drawing.Point(686, 169);
		this.textBox27.Name = "textBox27";
		this.textBox27.ReadOnly = true;
		this.textBox27.Size = new System.Drawing.Size(50, 23);
		this.textBox27.TabIndex = 185;
		this.textBox27.Text = "累充点";
		this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到30日_累充点.Location = new System.Drawing.Point(742, 169);
		this.签到30日_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到30日_累充点.Name = "签到30日_累充点";
		this.签到30日_累充点.Size = new System.Drawing.Size(80, 23);
		this.签到30日_累充点.TabIndex = 184;
		this.textBox28.Location = new System.Drawing.Point(544, 169);
		this.textBox28.Name = "textBox28";
		this.textBox28.ReadOnly = true;
		this.textBox28.Size = new System.Drawing.Size(50, 23);
		this.textBox28.TabIndex = 183;
		this.textBox28.Text = "南极点";
		this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到30日_南极点.Location = new System.Drawing.Point(600, 169);
		this.签到30日_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到30日_南极点.Name = "签到30日_南极点";
		this.签到30日_南极点.Size = new System.Drawing.Size(80, 23);
		this.签到30日_南极点.TabIndex = 182;
		this.textBox29.Location = new System.Drawing.Point(402, 169);
		this.textBox29.Name = "textBox29";
		this.textBox29.ReadOnly = true;
		this.textBox29.Size = new System.Drawing.Size(50, 23);
		this.textBox29.TabIndex = 181;
		this.textBox29.Text = "银元宝";
		this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到30日_银元宝.Location = new System.Drawing.Point(458, 169);
		this.签到30日_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到30日_银元宝.Name = "签到30日_银元宝";
		this.签到30日_银元宝.Size = new System.Drawing.Size(80, 23);
		this.签到30日_银元宝.TabIndex = 180;
		this.textBox30.Location = new System.Drawing.Point(260, 169);
		this.textBox30.Name = "textBox30";
		this.textBox30.ReadOnly = true;
		this.textBox30.Size = new System.Drawing.Size(50, 23);
		this.textBox30.TabIndex = 179;
		this.textBox30.Text = "金元宝";
		this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox31.Location = new System.Drawing.Point(108, 169);
		this.textBox31.Name = "textBox31";
		this.textBox31.ReadOnly = true;
		this.textBox31.Size = new System.Drawing.Size(40, 23);
		this.textBox31.TabIndex = 178;
		this.textBox31.Text = "道具";
		this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox32.Location = new System.Drawing.Point(12, 169);
		this.textBox32.Name = "textBox32";
		this.textBox32.ReadOnly = true;
		this.textBox32.Size = new System.Drawing.Size(90, 23);
		this.textBox32.TabIndex = 175;
		this.textBox32.Text = "累计30天签到";
		this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到30日_道具.Location = new System.Drawing.Point(154, 169);
		this.签到30日_道具.Name = "签到30日_道具";
		this.签到30日_道具.Size = new System.Drawing.Size(100, 23);
		this.签到30日_道具.TabIndex = 176;
		this.签到30日_金元宝.Location = new System.Drawing.Point(316, 169);
		this.签到30日_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到30日_金元宝.Name = "签到30日_金元宝";
		this.签到30日_金元宝.Size = new System.Drawing.Size(80, 23);
		this.签到30日_金元宝.TabIndex = 177;
		this.textBox34.Location = new System.Drawing.Point(686, 198);
		this.textBox34.Name = "textBox34";
		this.textBox34.ReadOnly = true;
		this.textBox34.Size = new System.Drawing.Size(50, 23);
		this.textBox34.TabIndex = 196;
		this.textBox34.Text = "累充点";
		this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到40日_累充点.Location = new System.Drawing.Point(742, 198);
		this.签到40日_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到40日_累充点.Name = "签到40日_累充点";
		this.签到40日_累充点.Size = new System.Drawing.Size(80, 23);
		this.签到40日_累充点.TabIndex = 195;
		this.textBox35.Location = new System.Drawing.Point(544, 198);
		this.textBox35.Name = "textBox35";
		this.textBox35.ReadOnly = true;
		this.textBox35.Size = new System.Drawing.Size(50, 23);
		this.textBox35.TabIndex = 194;
		this.textBox35.Text = "南极点";
		this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到40日_南极点.Location = new System.Drawing.Point(600, 198);
		this.签到40日_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到40日_南极点.Name = "签到40日_南极点";
		this.签到40日_南极点.Size = new System.Drawing.Size(80, 23);
		this.签到40日_南极点.TabIndex = 193;
		this.textBox36.Location = new System.Drawing.Point(402, 198);
		this.textBox36.Name = "textBox36";
		this.textBox36.ReadOnly = true;
		this.textBox36.Size = new System.Drawing.Size(50, 23);
		this.textBox36.TabIndex = 192;
		this.textBox36.Text = "银元宝";
		this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到40日_银元宝.Location = new System.Drawing.Point(458, 198);
		this.签到40日_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到40日_银元宝.Name = "签到40日_银元宝";
		this.签到40日_银元宝.Size = new System.Drawing.Size(80, 23);
		this.签到40日_银元宝.TabIndex = 191;
		this.textBox37.Location = new System.Drawing.Point(260, 198);
		this.textBox37.Name = "textBox37";
		this.textBox37.ReadOnly = true;
		this.textBox37.Size = new System.Drawing.Size(50, 23);
		this.textBox37.TabIndex = 190;
		this.textBox37.Text = "金元宝";
		this.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox38.Location = new System.Drawing.Point(108, 198);
		this.textBox38.Name = "textBox38";
		this.textBox38.ReadOnly = true;
		this.textBox38.Size = new System.Drawing.Size(40, 23);
		this.textBox38.TabIndex = 189;
		this.textBox38.Text = "道具";
		this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox39.Location = new System.Drawing.Point(12, 198);
		this.textBox39.Name = "textBox39";
		this.textBox39.ReadOnly = true;
		this.textBox39.Size = new System.Drawing.Size(90, 23);
		this.textBox39.TabIndex = 186;
		this.textBox39.Text = "累计40天签到";
		this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到40日_道具.Location = new System.Drawing.Point(154, 198);
		this.签到40日_道具.Name = "签到40日_道具";
		this.签到40日_道具.Size = new System.Drawing.Size(100, 23);
		this.签到40日_道具.TabIndex = 187;
		this.签到40日_金元宝.Location = new System.Drawing.Point(316, 198);
		this.签到40日_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到40日_金元宝.Name = "签到40日_金元宝";
		this.签到40日_金元宝.Size = new System.Drawing.Size(80, 23);
		this.签到40日_金元宝.TabIndex = 188;
		this.textBox41.Location = new System.Drawing.Point(686, 227);
		this.textBox41.Name = "textBox41";
		this.textBox41.ReadOnly = true;
		this.textBox41.Size = new System.Drawing.Size(50, 23);
		this.textBox41.TabIndex = 207;
		this.textBox41.Text = "累充点";
		this.textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到50日_累充点.Location = new System.Drawing.Point(742, 227);
		this.签到50日_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到50日_累充点.Name = "签到50日_累充点";
		this.签到50日_累充点.Size = new System.Drawing.Size(80, 23);
		this.签到50日_累充点.TabIndex = 206;
		this.textBox42.Location = new System.Drawing.Point(544, 227);
		this.textBox42.Name = "textBox42";
		this.textBox42.ReadOnly = true;
		this.textBox42.Size = new System.Drawing.Size(50, 23);
		this.textBox42.TabIndex = 205;
		this.textBox42.Text = "南极点";
		this.textBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到50日_南极点.Location = new System.Drawing.Point(600, 227);
		this.签到50日_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到50日_南极点.Name = "签到50日_南极点";
		this.签到50日_南极点.Size = new System.Drawing.Size(80, 23);
		this.签到50日_南极点.TabIndex = 204;
		this.textBox43.Location = new System.Drawing.Point(402, 227);
		this.textBox43.Name = "textBox43";
		this.textBox43.ReadOnly = true;
		this.textBox43.Size = new System.Drawing.Size(50, 23);
		this.textBox43.TabIndex = 203;
		this.textBox43.Text = "银元宝";
		this.textBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到50日_银元宝.Location = new System.Drawing.Point(458, 227);
		this.签到50日_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到50日_银元宝.Name = "签到50日_银元宝";
		this.签到50日_银元宝.Size = new System.Drawing.Size(80, 23);
		this.签到50日_银元宝.TabIndex = 202;
		this.textBox44.Location = new System.Drawing.Point(260, 227);
		this.textBox44.Name = "textBox44";
		this.textBox44.ReadOnly = true;
		this.textBox44.Size = new System.Drawing.Size(50, 23);
		this.textBox44.TabIndex = 201;
		this.textBox44.Text = "金元宝";
		this.textBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox45.Location = new System.Drawing.Point(108, 227);
		this.textBox45.Name = "textBox45";
		this.textBox45.ReadOnly = true;
		this.textBox45.Size = new System.Drawing.Size(40, 23);
		this.textBox45.TabIndex = 200;
		this.textBox45.Text = "道具";
		this.textBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox46.Location = new System.Drawing.Point(12, 227);
		this.textBox46.Name = "textBox46";
		this.textBox46.ReadOnly = true;
		this.textBox46.Size = new System.Drawing.Size(90, 23);
		this.textBox46.TabIndex = 197;
		this.textBox46.Text = "累计50天签到";
		this.textBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到50日_道具.Location = new System.Drawing.Point(154, 227);
		this.签到50日_道具.Name = "签到50日_道具";
		this.签到50日_道具.Size = new System.Drawing.Size(100, 23);
		this.签到50日_道具.TabIndex = 198;
		this.签到50日_金元宝.Location = new System.Drawing.Point(316, 227);
		this.签到50日_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到50日_金元宝.Name = "签到50日_金元宝";
		this.签到50日_金元宝.Size = new System.Drawing.Size(80, 23);
		this.签到50日_金元宝.TabIndex = 199;
		this.textBox48.Location = new System.Drawing.Point(686, 256);
		this.textBox48.Name = "textBox48";
		this.textBox48.ReadOnly = true;
		this.textBox48.Size = new System.Drawing.Size(50, 23);
		this.textBox48.TabIndex = 218;
		this.textBox48.Text = "累充点";
		this.textBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到60日_累充点.Location = new System.Drawing.Point(742, 256);
		this.签到60日_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到60日_累充点.Name = "签到60日_累充点";
		this.签到60日_累充点.Size = new System.Drawing.Size(80, 23);
		this.签到60日_累充点.TabIndex = 217;
		this.textBox49.Location = new System.Drawing.Point(544, 256);
		this.textBox49.Name = "textBox49";
		this.textBox49.ReadOnly = true;
		this.textBox49.Size = new System.Drawing.Size(50, 23);
		this.textBox49.TabIndex = 216;
		this.textBox49.Text = "南极点";
		this.textBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到60日_南极点.Location = new System.Drawing.Point(600, 256);
		this.签到60日_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到60日_南极点.Name = "签到60日_南极点";
		this.签到60日_南极点.Size = new System.Drawing.Size(80, 23);
		this.签到60日_南极点.TabIndex = 215;
		this.textBox50.Location = new System.Drawing.Point(402, 256);
		this.textBox50.Name = "textBox50";
		this.textBox50.ReadOnly = true;
		this.textBox50.Size = new System.Drawing.Size(50, 23);
		this.textBox50.TabIndex = 214;
		this.textBox50.Text = "银元宝";
		this.textBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到60日_银元宝.Location = new System.Drawing.Point(458, 256);
		this.签到60日_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到60日_银元宝.Name = "签到60日_银元宝";
		this.签到60日_银元宝.Size = new System.Drawing.Size(80, 23);
		this.签到60日_银元宝.TabIndex = 213;
		this.textBox51.Location = new System.Drawing.Point(260, 256);
		this.textBox51.Name = "textBox51";
		this.textBox51.ReadOnly = true;
		this.textBox51.Size = new System.Drawing.Size(50, 23);
		this.textBox51.TabIndex = 212;
		this.textBox51.Text = "金元宝";
		this.textBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox52.Location = new System.Drawing.Point(108, 256);
		this.textBox52.Name = "textBox52";
		this.textBox52.ReadOnly = true;
		this.textBox52.Size = new System.Drawing.Size(40, 23);
		this.textBox52.TabIndex = 211;
		this.textBox52.Text = "道具";
		this.textBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox53.Location = new System.Drawing.Point(12, 256);
		this.textBox53.Name = "textBox53";
		this.textBox53.ReadOnly = true;
		this.textBox53.Size = new System.Drawing.Size(90, 23);
		this.textBox53.TabIndex = 208;
		this.textBox53.Text = "累计60天签到";
		this.textBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到60日_道具.Location = new System.Drawing.Point(154, 256);
		this.签到60日_道具.Name = "签到60日_道具";
		this.签到60日_道具.Size = new System.Drawing.Size(100, 23);
		this.签到60日_道具.TabIndex = 209;
		this.签到60日_金元宝.Location = new System.Drawing.Point(316, 256);
		this.签到60日_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到60日_金元宝.Name = "签到60日_金元宝";
		this.签到60日_金元宝.Size = new System.Drawing.Size(80, 23);
		this.签到60日_金元宝.TabIndex = 210;
		this.textBox55.Location = new System.Drawing.Point(686, 285);
		this.textBox55.Name = "textBox55";
		this.textBox55.ReadOnly = true;
		this.textBox55.Size = new System.Drawing.Size(50, 23);
		this.textBox55.TabIndex = 229;
		this.textBox55.Text = "累充点";
		this.textBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到70日_累充点.Location = new System.Drawing.Point(742, 285);
		this.签到70日_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到70日_累充点.Name = "签到70日_累充点";
		this.签到70日_累充点.Size = new System.Drawing.Size(80, 23);
		this.签到70日_累充点.TabIndex = 228;
		this.textBox56.Location = new System.Drawing.Point(544, 285);
		this.textBox56.Name = "textBox56";
		this.textBox56.ReadOnly = true;
		this.textBox56.Size = new System.Drawing.Size(50, 23);
		this.textBox56.TabIndex = 227;
		this.textBox56.Text = "南极点";
		this.textBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到70日_南极点.Location = new System.Drawing.Point(600, 285);
		this.签到70日_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到70日_南极点.Name = "签到70日_南极点";
		this.签到70日_南极点.Size = new System.Drawing.Size(80, 23);
		this.签到70日_南极点.TabIndex = 226;
		this.textBox57.Location = new System.Drawing.Point(402, 285);
		this.textBox57.Name = "textBox57";
		this.textBox57.ReadOnly = true;
		this.textBox57.Size = new System.Drawing.Size(50, 23);
		this.textBox57.TabIndex = 225;
		this.textBox57.Text = "银元宝";
		this.textBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到70日_银元宝.Location = new System.Drawing.Point(458, 285);
		this.签到70日_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到70日_银元宝.Name = "签到70日_银元宝";
		this.签到70日_银元宝.Size = new System.Drawing.Size(80, 23);
		this.签到70日_银元宝.TabIndex = 224;
		this.textBox58.Location = new System.Drawing.Point(260, 285);
		this.textBox58.Name = "textBox58";
		this.textBox58.ReadOnly = true;
		this.textBox58.Size = new System.Drawing.Size(50, 23);
		this.textBox58.TabIndex = 223;
		this.textBox58.Text = "金元宝";
		this.textBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox59.Location = new System.Drawing.Point(108, 285);
		this.textBox59.Name = "textBox59";
		this.textBox59.ReadOnly = true;
		this.textBox59.Size = new System.Drawing.Size(40, 23);
		this.textBox59.TabIndex = 222;
		this.textBox59.Text = "道具";
		this.textBox59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox60.Location = new System.Drawing.Point(12, 285);
		this.textBox60.Name = "textBox60";
		this.textBox60.ReadOnly = true;
		this.textBox60.Size = new System.Drawing.Size(90, 23);
		this.textBox60.TabIndex = 219;
		this.textBox60.Text = "累计70天签到";
		this.textBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到70日_道具.Location = new System.Drawing.Point(154, 285);
		this.签到70日_道具.Name = "签到70日_道具";
		this.签到70日_道具.Size = new System.Drawing.Size(100, 23);
		this.签到70日_道具.TabIndex = 220;
		this.签到70日_金元宝.Location = new System.Drawing.Point(316, 285);
		this.签到70日_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到70日_金元宝.Name = "签到70日_金元宝";
		this.签到70日_金元宝.Size = new System.Drawing.Size(80, 23);
		this.签到70日_金元宝.TabIndex = 221;
		this.textBox62.Location = new System.Drawing.Point(686, 372);
		this.textBox62.Name = "textBox62";
		this.textBox62.ReadOnly = true;
		this.textBox62.Size = new System.Drawing.Size(50, 23);
		this.textBox62.TabIndex = 262;
		this.textBox62.Text = "累充点";
		this.textBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到100日_累充点.Location = new System.Drawing.Point(742, 372);
		this.签到100日_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到100日_累充点.Name = "签到100日_累充点";
		this.签到100日_累充点.Size = new System.Drawing.Size(80, 23);
		this.签到100日_累充点.TabIndex = 261;
		this.textBox63.Location = new System.Drawing.Point(544, 372);
		this.textBox63.Name = "textBox63";
		this.textBox63.ReadOnly = true;
		this.textBox63.Size = new System.Drawing.Size(50, 23);
		this.textBox63.TabIndex = 260;
		this.textBox63.Text = "南极点";
		this.textBox63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到100日_南极点.Location = new System.Drawing.Point(600, 372);
		this.签到100日_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到100日_南极点.Name = "签到100日_南极点";
		this.签到100日_南极点.Size = new System.Drawing.Size(80, 23);
		this.签到100日_南极点.TabIndex = 259;
		this.textBox64.Location = new System.Drawing.Point(402, 372);
		this.textBox64.Name = "textBox64";
		this.textBox64.ReadOnly = true;
		this.textBox64.Size = new System.Drawing.Size(50, 23);
		this.textBox64.TabIndex = 258;
		this.textBox64.Text = "银元宝";
		this.textBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到100日_银元宝.Location = new System.Drawing.Point(458, 372);
		this.签到100日_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到100日_银元宝.Name = "签到100日_银元宝";
		this.签到100日_银元宝.Size = new System.Drawing.Size(80, 23);
		this.签到100日_银元宝.TabIndex = 257;
		this.textBox65.Location = new System.Drawing.Point(260, 372);
		this.textBox65.Name = "textBox65";
		this.textBox65.ReadOnly = true;
		this.textBox65.Size = new System.Drawing.Size(50, 23);
		this.textBox65.TabIndex = 256;
		this.textBox65.Text = "金元宝";
		this.textBox65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox66.Location = new System.Drawing.Point(108, 372);
		this.textBox66.Name = "textBox66";
		this.textBox66.ReadOnly = true;
		this.textBox66.Size = new System.Drawing.Size(40, 23);
		this.textBox66.TabIndex = 255;
		this.textBox66.Text = "道具";
		this.textBox66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox67.Location = new System.Drawing.Point(12, 372);
		this.textBox67.Name = "textBox67";
		this.textBox67.ReadOnly = true;
		this.textBox67.Size = new System.Drawing.Size(90, 23);
		this.textBox67.TabIndex = 252;
		this.textBox67.Text = "累计100天签到";
		this.textBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到100日_道具.Location = new System.Drawing.Point(154, 372);
		this.签到100日_道具.Name = "签到100日_道具";
		this.签到100日_道具.Size = new System.Drawing.Size(100, 23);
		this.签到100日_道具.TabIndex = 253;
		this.签到100日_金元宝.Location = new System.Drawing.Point(316, 372);
		this.签到100日_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到100日_金元宝.Name = "签到100日_金元宝";
		this.签到100日_金元宝.Size = new System.Drawing.Size(80, 23);
		this.签到100日_金元宝.TabIndex = 254;
		this.textBox69.Location = new System.Drawing.Point(686, 343);
		this.textBox69.Name = "textBox69";
		this.textBox69.ReadOnly = true;
		this.textBox69.Size = new System.Drawing.Size(50, 23);
		this.textBox69.TabIndex = 251;
		this.textBox69.Text = "累充点";
		this.textBox69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到90日_累充点.Location = new System.Drawing.Point(742, 343);
		this.签到90日_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到90日_累充点.Name = "签到90日_累充点";
		this.签到90日_累充点.Size = new System.Drawing.Size(80, 23);
		this.签到90日_累充点.TabIndex = 250;
		this.textBox70.Location = new System.Drawing.Point(544, 343);
		this.textBox70.Name = "textBox70";
		this.textBox70.ReadOnly = true;
		this.textBox70.Size = new System.Drawing.Size(50, 23);
		this.textBox70.TabIndex = 249;
		this.textBox70.Text = "南极点";
		this.textBox70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到90日_南极点.Location = new System.Drawing.Point(600, 343);
		this.签到90日_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到90日_南极点.Name = "签到90日_南极点";
		this.签到90日_南极点.Size = new System.Drawing.Size(80, 23);
		this.签到90日_南极点.TabIndex = 248;
		this.textBox71.Location = new System.Drawing.Point(402, 343);
		this.textBox71.Name = "textBox71";
		this.textBox71.ReadOnly = true;
		this.textBox71.Size = new System.Drawing.Size(50, 23);
		this.textBox71.TabIndex = 247;
		this.textBox71.Text = "银元宝";
		this.textBox71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到90日_银元宝.Location = new System.Drawing.Point(458, 343);
		this.签到90日_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到90日_银元宝.Name = "签到90日_银元宝";
		this.签到90日_银元宝.Size = new System.Drawing.Size(80, 23);
		this.签到90日_银元宝.TabIndex = 246;
		this.textBox72.Location = new System.Drawing.Point(260, 343);
		this.textBox72.Name = "textBox72";
		this.textBox72.ReadOnly = true;
		this.textBox72.Size = new System.Drawing.Size(50, 23);
		this.textBox72.TabIndex = 245;
		this.textBox72.Text = "金元宝";
		this.textBox72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox73.Location = new System.Drawing.Point(108, 343);
		this.textBox73.Name = "textBox73";
		this.textBox73.ReadOnly = true;
		this.textBox73.Size = new System.Drawing.Size(40, 23);
		this.textBox73.TabIndex = 244;
		this.textBox73.Text = "道具";
		this.textBox73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox74.Location = new System.Drawing.Point(12, 343);
		this.textBox74.Name = "textBox74";
		this.textBox74.ReadOnly = true;
		this.textBox74.Size = new System.Drawing.Size(90, 23);
		this.textBox74.TabIndex = 241;
		this.textBox74.Text = "累计90天签到";
		this.textBox74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到90日_道具.Location = new System.Drawing.Point(154, 343);
		this.签到90日_道具.Name = "签到90日_道具";
		this.签到90日_道具.Size = new System.Drawing.Size(100, 23);
		this.签到90日_道具.TabIndex = 242;
		this.签到90日_金元宝.Location = new System.Drawing.Point(316, 343);
		this.签到90日_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到90日_金元宝.Name = "签到90日_金元宝";
		this.签到90日_金元宝.Size = new System.Drawing.Size(80, 23);
		this.签到90日_金元宝.TabIndex = 243;
		this.textBox76.Location = new System.Drawing.Point(686, 314);
		this.textBox76.Name = "textBox76";
		this.textBox76.ReadOnly = true;
		this.textBox76.Size = new System.Drawing.Size(50, 23);
		this.textBox76.TabIndex = 240;
		this.textBox76.Text = "累充点";
		this.textBox76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到80日_累充点.Location = new System.Drawing.Point(742, 314);
		this.签到80日_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到80日_累充点.Name = "签到80日_累充点";
		this.签到80日_累充点.Size = new System.Drawing.Size(80, 23);
		this.签到80日_累充点.TabIndex = 239;
		this.textBox77.Location = new System.Drawing.Point(544, 314);
		this.textBox77.Name = "textBox77";
		this.textBox77.ReadOnly = true;
		this.textBox77.Size = new System.Drawing.Size(50, 23);
		this.textBox77.TabIndex = 238;
		this.textBox77.Text = "南极点";
		this.textBox77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到80日_南极点.Location = new System.Drawing.Point(600, 314);
		this.签到80日_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到80日_南极点.Name = "签到80日_南极点";
		this.签到80日_南极点.Size = new System.Drawing.Size(80, 23);
		this.签到80日_南极点.TabIndex = 237;
		this.textBox78.Location = new System.Drawing.Point(402, 314);
		this.textBox78.Name = "textBox78";
		this.textBox78.ReadOnly = true;
		this.textBox78.Size = new System.Drawing.Size(50, 23);
		this.textBox78.TabIndex = 236;
		this.textBox78.Text = "银元宝";
		this.textBox78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到80日_银元宝.Location = new System.Drawing.Point(458, 314);
		this.签到80日_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到80日_银元宝.Name = "签到80日_银元宝";
		this.签到80日_银元宝.Size = new System.Drawing.Size(80, 23);
		this.签到80日_银元宝.TabIndex = 235;
		this.textBox79.Location = new System.Drawing.Point(260, 314);
		this.textBox79.Name = "textBox79";
		this.textBox79.ReadOnly = true;
		this.textBox79.Size = new System.Drawing.Size(50, 23);
		this.textBox79.TabIndex = 234;
		this.textBox79.Text = "金元宝";
		this.textBox79.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox80.Location = new System.Drawing.Point(108, 314);
		this.textBox80.Name = "textBox80";
		this.textBox80.ReadOnly = true;
		this.textBox80.Size = new System.Drawing.Size(40, 23);
		this.textBox80.TabIndex = 233;
		this.textBox80.Text = "道具";
		this.textBox80.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox81.Location = new System.Drawing.Point(12, 314);
		this.textBox81.Name = "textBox81";
		this.textBox81.ReadOnly = true;
		this.textBox81.Size = new System.Drawing.Size(90, 23);
		this.textBox81.TabIndex = 230;
		this.textBox81.Text = "累计80天签到";
		this.textBox81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.签到80日_道具.Location = new System.Drawing.Point(154, 314);
		this.签到80日_道具.Name = "签到80日_道具";
		this.签到80日_道具.Size = new System.Drawing.Size(100, 23);
		this.签到80日_道具.TabIndex = 231;
		this.签到80日_金元宝.Location = new System.Drawing.Point(316, 314);
		this.签到80日_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.签到80日_金元宝.Name = "签到80日_金元宝";
		this.签到80日_金元宝.Size = new System.Drawing.Size(80, 23);
		this.签到80日_金元宝.TabIndex = 232;
		this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label1.Location = new System.Drawing.Point(352, 8);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(470, 30);
		this.label1.TabIndex = 263;
		this.label1.Text = "当前频道输入：签到，即可完成本日签到";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(839, 409);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.textBox62);
		base.Controls.Add(this.签到100日_累充点);
		base.Controls.Add(this.textBox63);
		base.Controls.Add(this.签到100日_南极点);
		base.Controls.Add(this.textBox64);
		base.Controls.Add(this.签到100日_银元宝);
		base.Controls.Add(this.textBox65);
		base.Controls.Add(this.textBox66);
		base.Controls.Add(this.textBox67);
		base.Controls.Add(this.签到100日_道具);
		base.Controls.Add(this.签到100日_金元宝);
		base.Controls.Add(this.textBox69);
		base.Controls.Add(this.签到90日_累充点);
		base.Controls.Add(this.textBox70);
		base.Controls.Add(this.签到90日_南极点);
		base.Controls.Add(this.textBox71);
		base.Controls.Add(this.签到90日_银元宝);
		base.Controls.Add(this.textBox72);
		base.Controls.Add(this.textBox73);
		base.Controls.Add(this.textBox74);
		base.Controls.Add(this.签到90日_道具);
		base.Controls.Add(this.签到90日_金元宝);
		base.Controls.Add(this.textBox76);
		base.Controls.Add(this.签到80日_累充点);
		base.Controls.Add(this.textBox77);
		base.Controls.Add(this.签到80日_南极点);
		base.Controls.Add(this.textBox78);
		base.Controls.Add(this.签到80日_银元宝);
		base.Controls.Add(this.textBox79);
		base.Controls.Add(this.textBox80);
		base.Controls.Add(this.textBox81);
		base.Controls.Add(this.签到80日_道具);
		base.Controls.Add(this.签到80日_金元宝);
		base.Controls.Add(this.textBox55);
		base.Controls.Add(this.签到70日_累充点);
		base.Controls.Add(this.textBox56);
		base.Controls.Add(this.签到70日_南极点);
		base.Controls.Add(this.textBox57);
		base.Controls.Add(this.签到70日_银元宝);
		base.Controls.Add(this.textBox58);
		base.Controls.Add(this.textBox59);
		base.Controls.Add(this.textBox60);
		base.Controls.Add(this.签到70日_道具);
		base.Controls.Add(this.签到70日_金元宝);
		base.Controls.Add(this.textBox48);
		base.Controls.Add(this.签到60日_累充点);
		base.Controls.Add(this.textBox49);
		base.Controls.Add(this.签到60日_南极点);
		base.Controls.Add(this.textBox50);
		base.Controls.Add(this.签到60日_银元宝);
		base.Controls.Add(this.textBox51);
		base.Controls.Add(this.textBox52);
		base.Controls.Add(this.textBox53);
		base.Controls.Add(this.签到60日_道具);
		base.Controls.Add(this.签到60日_金元宝);
		base.Controls.Add(this.textBox41);
		base.Controls.Add(this.签到50日_累充点);
		base.Controls.Add(this.textBox42);
		base.Controls.Add(this.签到50日_南极点);
		base.Controls.Add(this.textBox43);
		base.Controls.Add(this.签到50日_银元宝);
		base.Controls.Add(this.textBox44);
		base.Controls.Add(this.textBox45);
		base.Controls.Add(this.textBox46);
		base.Controls.Add(this.签到50日_道具);
		base.Controls.Add(this.签到50日_金元宝);
		base.Controls.Add(this.textBox34);
		base.Controls.Add(this.签到40日_累充点);
		base.Controls.Add(this.textBox35);
		base.Controls.Add(this.签到40日_南极点);
		base.Controls.Add(this.textBox36);
		base.Controls.Add(this.签到40日_银元宝);
		base.Controls.Add(this.textBox37);
		base.Controls.Add(this.textBox38);
		base.Controls.Add(this.textBox39);
		base.Controls.Add(this.签到40日_道具);
		base.Controls.Add(this.签到40日_金元宝);
		base.Controls.Add(this.textBox27);
		base.Controls.Add(this.签到30日_累充点);
		base.Controls.Add(this.textBox28);
		base.Controls.Add(this.签到30日_南极点);
		base.Controls.Add(this.textBox29);
		base.Controls.Add(this.签到30日_银元宝);
		base.Controls.Add(this.textBox30);
		base.Controls.Add(this.textBox31);
		base.Controls.Add(this.textBox32);
		base.Controls.Add(this.签到30日_道具);
		base.Controls.Add(this.签到30日_金元宝);
		base.Controls.Add(this.textBox20);
		base.Controls.Add(this.签到20日_累充点);
		base.Controls.Add(this.textBox21);
		base.Controls.Add(this.签到20日_南极点);
		base.Controls.Add(this.textBox22);
		base.Controls.Add(this.签到20日_银元宝);
		base.Controls.Add(this.textBox23);
		base.Controls.Add(this.textBox24);
		base.Controls.Add(this.textBox25);
		base.Controls.Add(this.签到20日_道具);
		base.Controls.Add(this.签到20日_金元宝);
		base.Controls.Add(this.textBox13);
		base.Controls.Add(this.签到10日_累充点);
		base.Controls.Add(this.textBox14);
		base.Controls.Add(this.签到10日_南极点);
		base.Controls.Add(this.textBox15);
		base.Controls.Add(this.签到10日_银元宝);
		base.Controls.Add(this.textBox16);
		base.Controls.Add(this.textBox17);
		base.Controls.Add(this.textBox18);
		base.Controls.Add(this.签到10日_道具);
		base.Controls.Add(this.签到10日_金元宝);
		base.Controls.Add(this.textBox6);
		base.Controls.Add(this.签到5日_累充点);
		base.Controls.Add(this.textBox7);
		base.Controls.Add(this.签到5日_南极点);
		base.Controls.Add(this.textBox8);
		base.Controls.Add(this.签到5日_银元宝);
		base.Controls.Add(this.textBox9);
		base.Controls.Add(this.textBox10);
		base.Controls.Add(this.textBox11);
		base.Controls.Add(this.签到5日_道具);
		base.Controls.Add(this.签到5日_金元宝);
		base.Controls.Add(this.textBox5);
		base.Controls.Add(this.签到每日_累充点);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.签到每日_南极点);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.签到每日_银元宝);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.地狱道_名字);
		base.Controls.Add(this.签到每日_道具);
		base.Controls.Add(this.签到每日_金元宝);
		base.Controls.Add(this.签到_开关);
		base.Controls.Add(this.签到_重载按钮);
		base.Controls.Add(this.签到_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "签到配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "签到配置窗口";
		base.Load += new System.EventHandler(签到配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.签到每日_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到每日_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到每日_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到每日_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到5日_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到5日_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到5日_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到5日_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到10日_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到10日_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到10日_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到10日_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到20日_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到20日_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到20日_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到20日_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到30日_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到30日_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到30日_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到30日_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到40日_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到40日_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到40日_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到40日_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到50日_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到50日_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到50日_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到50日_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到60日_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到60日_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到60日_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到60日_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到70日_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到70日_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到70日_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到70日_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到100日_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到100日_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到100日_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到100日_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到90日_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到90日_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到90日_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到90日_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到80日_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到80日_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到80日_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.签到80日_金元宝).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
