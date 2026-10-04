using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 活跃度奖励配置窗口 : Form
{
	private static 活跃度奖励配置窗口 i;

	private IContainer components;

	private CheckBox 活跃度_开关;

	private Button 活跃度_重载按钮;

	private Button 活跃度_保存按钮;

	private CheckBox 活跃度_普通玩家可领取开关;

	private TextBox 活跃度50奖励_道具;

	private NumericUpDown 活跃度50奖励_金元宝;

	private TextBox textBox6;

	private TextBox textBox1;

	private TextBox textBox2;

	private NumericUpDown 活跃度50奖励_银元宝;

	private TextBox textBox3;

	private NumericUpDown 活跃度50奖励_累充点;

	private TextBox textBox4;

	private NumericUpDown 活跃度50奖励_南极点;

	private TextBox textBox5;

	private TextBox textBox7;

	private TextBox textBox8;

	private NumericUpDown 活跃度100奖励_南极点;

	private TextBox textBox9;

	private NumericUpDown 活跃度100奖励_累充点;

	private TextBox textBox10;

	private NumericUpDown 活跃度100奖励_银元宝;

	private TextBox textBox11;

	private TextBox 活跃度100奖励_道具;

	private NumericUpDown 活跃度100奖励_金元宝;

	private TextBox textBox13;

	private TextBox textBox14;

	private TextBox textBox15;

	private NumericUpDown 活跃度150奖励_南极点;

	private TextBox textBox16;

	private NumericUpDown 活跃度150奖励_累充点;

	private TextBox textBox17;

	private NumericUpDown 活跃度150奖励_银元宝;

	private TextBox textBox18;

	private TextBox 活跃度150奖励_道具;

	private NumericUpDown 活跃度150奖励_金元宝;

	private TextBox textBox20;

	private TextBox textBox21;

	private TextBox textBox22;

	private NumericUpDown 活跃度200奖励_南极点;

	private TextBox textBox23;

	private NumericUpDown 活跃度200奖励_累充点;

	private TextBox textBox24;

	private NumericUpDown 活跃度200奖励_银元宝;

	private TextBox textBox25;

	private TextBox 活跃度200奖励_道具;

	private NumericUpDown 活跃度200奖励_金元宝;

	private TextBox textBox27;

	private TextBox textBox28;

	private TextBox textBox29;

	private NumericUpDown 活跃度250奖励_南极点;

	private TextBox textBox30;

	private NumericUpDown 活跃度250奖励_累充点;

	private TextBox textBox31;

	private NumericUpDown 活跃度250奖励_银元宝;

	private TextBox textBox32;

	private TextBox 活跃度250奖励_道具;

	private NumericUpDown 活跃度250奖励_金元宝;

	private TextBox textBox34;

	private TextBox textBox35;

	private TextBox textBox36;

	private NumericUpDown 活跃度300奖励_南极点;

	private TextBox textBox37;

	private NumericUpDown 活跃度300奖励_累充点;

	private TextBox textBox38;

	private NumericUpDown 活跃度300奖励_银元宝;

	private TextBox textBox39;

	private TextBox 活跃度300奖励_道具;

	private NumericUpDown 活跃度300奖励_金元宝;

	private TextBox textBox41;

	public static 活跃度奖励配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 活跃度奖励配置窗口();
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

	public 活跃度奖励配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 活跃度奖励配置窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		活跃度_重载按钮_Click(sender, e);
	}

	private void 活跃度_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 39, JsonConvert.SerializeObject(Singleton<全局变量类>.I.活跃度配置, Formatting.Indented));
		}
	}

	private void 活跃度_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 39);
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (base.IsHandleCreated && 配置类型 == 39)
		{
			Invoke((MethodInvoker)delegate
			{
				活跃度_开关.Checked = Singleton<全局变量类>.I.活跃度配置.功能开关;
				活跃度_普通玩家可领取开关.Checked = Singleton<全局变量类>.I.活跃度配置.is普通玩家可领取;
				活跃度50奖励_金元宝.Value = Singleton<全局变量类>.I.活跃度配置.活跃度50奖励.奖金元宝;
				活跃度50奖励_银元宝.Value = Singleton<全局变量类>.I.活跃度配置.活跃度50奖励.奖银元宝;
				活跃度50奖励_累充点.Value = Singleton<全局变量类>.I.活跃度配置.活跃度50奖励.奖累充点;
				活跃度50奖励_南极点.Value = Singleton<全局变量类>.I.活跃度配置.活跃度50奖励.奖南极点;
				活跃度50奖励_道具.Text = Singleton<全局变量类>.I.活跃度配置.活跃度50奖励.奖励道具;
				活跃度100奖励_金元宝.Value = Singleton<全局变量类>.I.活跃度配置.活跃度100奖励.奖金元宝;
				活跃度100奖励_银元宝.Value = Singleton<全局变量类>.I.活跃度配置.活跃度100奖励.奖银元宝;
				活跃度100奖励_累充点.Value = Singleton<全局变量类>.I.活跃度配置.活跃度100奖励.奖累充点;
				活跃度100奖励_南极点.Value = Singleton<全局变量类>.I.活跃度配置.活跃度100奖励.奖南极点;
				活跃度100奖励_道具.Text = Singleton<全局变量类>.I.活跃度配置.活跃度100奖励.奖励道具;
				活跃度150奖励_金元宝.Value = Singleton<全局变量类>.I.活跃度配置.活跃度150奖励.奖金元宝;
				活跃度150奖励_银元宝.Value = Singleton<全局变量类>.I.活跃度配置.活跃度150奖励.奖银元宝;
				活跃度150奖励_累充点.Value = Singleton<全局变量类>.I.活跃度配置.活跃度150奖励.奖累充点;
				活跃度150奖励_南极点.Value = Singleton<全局变量类>.I.活跃度配置.活跃度150奖励.奖南极点;
				活跃度150奖励_道具.Text = Singleton<全局变量类>.I.活跃度配置.活跃度150奖励.奖励道具;
				活跃度200奖励_金元宝.Value = Singleton<全局变量类>.I.活跃度配置.活跃度200奖励.奖金元宝;
				活跃度200奖励_银元宝.Value = Singleton<全局变量类>.I.活跃度配置.活跃度200奖励.奖银元宝;
				活跃度200奖励_累充点.Value = Singleton<全局变量类>.I.活跃度配置.活跃度200奖励.奖累充点;
				活跃度200奖励_南极点.Value = Singleton<全局变量类>.I.活跃度配置.活跃度200奖励.奖南极点;
				活跃度200奖励_道具.Text = Singleton<全局变量类>.I.活跃度配置.活跃度200奖励.奖励道具;
				活跃度250奖励_金元宝.Value = Singleton<全局变量类>.I.活跃度配置.活跃度250奖励.奖金元宝;
				活跃度250奖励_银元宝.Value = Singleton<全局变量类>.I.活跃度配置.活跃度250奖励.奖银元宝;
				活跃度250奖励_累充点.Value = Singleton<全局变量类>.I.活跃度配置.活跃度250奖励.奖累充点;
				活跃度250奖励_南极点.Value = Singleton<全局变量类>.I.活跃度配置.活跃度250奖励.奖南极点;
				活跃度250奖励_道具.Text = Singleton<全局变量类>.I.活跃度配置.活跃度250奖励.奖励道具;
				活跃度300奖励_金元宝.Value = Singleton<全局变量类>.I.活跃度配置.活跃度300奖励.奖金元宝;
				活跃度300奖励_银元宝.Value = Singleton<全局变量类>.I.活跃度配置.活跃度300奖励.奖银元宝;
				活跃度300奖励_累充点.Value = Singleton<全局变量类>.I.活跃度配置.活跃度300奖励.奖累充点;
				活跃度300奖励_南极点.Value = Singleton<全局变量类>.I.活跃度配置.活跃度300奖励.奖南极点;
				活跃度300奖励_道具.Text = Singleton<全局变量类>.I.活跃度配置.活跃度300奖励.奖励道具;
			});
		}
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.活跃度配置.功能开关 = 活跃度_开关.Checked;
			Singleton<全局变量类>.I.活跃度配置.is普通玩家可领取 = 活跃度_普通玩家可领取开关.Checked;
			Singleton<全局变量类>.I.活跃度配置.活跃度50奖励.奖金元宝 = (int)活跃度50奖励_金元宝.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度50奖励.奖银元宝 = (int)活跃度50奖励_银元宝.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度50奖励.奖累充点 = (int)活跃度50奖励_累充点.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度50奖励.奖南极点 = (int)活跃度50奖励_南极点.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度50奖励.奖励道具 = 活跃度50奖励_道具.Text;
			Singleton<全局变量类>.I.活跃度配置.活跃度100奖励.奖金元宝 = (int)活跃度100奖励_金元宝.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度100奖励.奖银元宝 = (int)活跃度100奖励_银元宝.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度100奖励.奖累充点 = (int)活跃度100奖励_累充点.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度100奖励.奖南极点 = (int)活跃度100奖励_南极点.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度100奖励.奖励道具 = 活跃度100奖励_道具.Text;
			Singleton<全局变量类>.I.活跃度配置.活跃度150奖励.奖金元宝 = (int)活跃度150奖励_金元宝.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度150奖励.奖银元宝 = (int)活跃度150奖励_银元宝.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度150奖励.奖累充点 = (int)活跃度150奖励_累充点.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度150奖励.奖南极点 = (int)活跃度150奖励_南极点.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度150奖励.奖励道具 = 活跃度150奖励_道具.Text;
			Singleton<全局变量类>.I.活跃度配置.活跃度200奖励.奖金元宝 = (int)活跃度200奖励_金元宝.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度200奖励.奖银元宝 = (int)活跃度200奖励_银元宝.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度200奖励.奖累充点 = (int)活跃度200奖励_累充点.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度200奖励.奖南极点 = (int)活跃度200奖励_南极点.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度200奖励.奖励道具 = 活跃度200奖励_道具.Text;
			Singleton<全局变量类>.I.活跃度配置.活跃度250奖励.奖金元宝 = (int)活跃度250奖励_金元宝.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度250奖励.奖银元宝 = (int)活跃度250奖励_银元宝.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度250奖励.奖累充点 = (int)活跃度250奖励_累充点.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度250奖励.奖南极点 = (int)活跃度250奖励_南极点.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度250奖励.奖励道具 = 活跃度250奖励_道具.Text;
			Singleton<全局变量类>.I.活跃度配置.活跃度300奖励.奖金元宝 = (int)活跃度300奖励_金元宝.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度300奖励.奖银元宝 = (int)活跃度300奖励_银元宝.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度300奖励.奖累充点 = (int)活跃度300奖励_累充点.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度300奖励.奖南极点 = (int)活跃度300奖励_南极点.Value;
			Singleton<全局变量类>.I.活跃度配置.活跃度300奖励.奖励道具 = 活跃度300奖励_道具.Text;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.活跃度奖励配置窗口));
		this.活跃度_开关 = new System.Windows.Forms.CheckBox();
		this.活跃度_重载按钮 = new System.Windows.Forms.Button();
		this.活跃度_保存按钮 = new System.Windows.Forms.Button();
		this.活跃度_普通玩家可领取开关 = new System.Windows.Forms.CheckBox();
		this.活跃度50奖励_道具 = new System.Windows.Forms.TextBox();
		this.活跃度50奖励_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox6 = new System.Windows.Forms.TextBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.活跃度50奖励_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.活跃度50奖励_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.活跃度50奖励_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.textBox7 = new System.Windows.Forms.TextBox();
		this.textBox8 = new System.Windows.Forms.TextBox();
		this.活跃度100奖励_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox9 = new System.Windows.Forms.TextBox();
		this.活跃度100奖励_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox10 = new System.Windows.Forms.TextBox();
		this.活跃度100奖励_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox11 = new System.Windows.Forms.TextBox();
		this.活跃度100奖励_道具 = new System.Windows.Forms.TextBox();
		this.活跃度100奖励_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox13 = new System.Windows.Forms.TextBox();
		this.textBox14 = new System.Windows.Forms.TextBox();
		this.textBox15 = new System.Windows.Forms.TextBox();
		this.活跃度150奖励_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox16 = new System.Windows.Forms.TextBox();
		this.活跃度150奖励_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox17 = new System.Windows.Forms.TextBox();
		this.活跃度150奖励_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox18 = new System.Windows.Forms.TextBox();
		this.活跃度150奖励_道具 = new System.Windows.Forms.TextBox();
		this.活跃度150奖励_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox20 = new System.Windows.Forms.TextBox();
		this.textBox21 = new System.Windows.Forms.TextBox();
		this.textBox22 = new System.Windows.Forms.TextBox();
		this.活跃度200奖励_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox23 = new System.Windows.Forms.TextBox();
		this.活跃度200奖励_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox24 = new System.Windows.Forms.TextBox();
		this.活跃度200奖励_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox25 = new System.Windows.Forms.TextBox();
		this.活跃度200奖励_道具 = new System.Windows.Forms.TextBox();
		this.活跃度200奖励_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox27 = new System.Windows.Forms.TextBox();
		this.textBox28 = new System.Windows.Forms.TextBox();
		this.textBox29 = new System.Windows.Forms.TextBox();
		this.活跃度250奖励_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox30 = new System.Windows.Forms.TextBox();
		this.活跃度250奖励_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox31 = new System.Windows.Forms.TextBox();
		this.活跃度250奖励_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox32 = new System.Windows.Forms.TextBox();
		this.活跃度250奖励_道具 = new System.Windows.Forms.TextBox();
		this.活跃度250奖励_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox34 = new System.Windows.Forms.TextBox();
		this.textBox35 = new System.Windows.Forms.TextBox();
		this.textBox36 = new System.Windows.Forms.TextBox();
		this.活跃度300奖励_南极点 = new System.Windows.Forms.NumericUpDown();
		this.textBox37 = new System.Windows.Forms.TextBox();
		this.活跃度300奖励_累充点 = new System.Windows.Forms.NumericUpDown();
		this.textBox38 = new System.Windows.Forms.TextBox();
		this.活跃度300奖励_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox39 = new System.Windows.Forms.TextBox();
		this.活跃度300奖励_道具 = new System.Windows.Forms.TextBox();
		this.活跃度300奖励_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox41 = new System.Windows.Forms.TextBox();
		((System.ComponentModel.ISupportInitialize)this.活跃度50奖励_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度50奖励_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度50奖励_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度50奖励_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度100奖励_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度100奖励_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度100奖励_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度100奖励_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度150奖励_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度150奖励_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度150奖励_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度150奖励_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度200奖励_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度200奖励_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度200奖励_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度200奖励_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度250奖励_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度250奖励_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度250奖励_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度250奖励_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度300奖励_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度300奖励_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度300奖励_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度300奖励_金元宝).BeginInit();
		base.SuspendLayout();
		this.活跃度_开关.AutoSize = true;
		this.活跃度_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.活跃度_开关.Location = new System.Drawing.Point(12, 12);
		this.活跃度_开关.Name = "活跃度_开关";
		this.活跃度_开关.Size = new System.Drawing.Size(119, 23);
		this.活跃度_开关.TabIndex = 124;
		this.活跃度_开关.Text = "活跃度奖励开关";
		this.活跃度_开关.UseVisualStyleBackColor = true;
		this.活跃度_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.活跃度_重载按钮.Location = new System.Drawing.Point(469, 8);
		this.活跃度_重载按钮.Name = "活跃度_重载按钮";
		this.活跃度_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.活跃度_重载按钮.TabIndex = 126;
		this.活跃度_重载按钮.Text = "重载配置";
		this.活跃度_重载按钮.UseVisualStyleBackColor = true;
		this.活跃度_重载按钮.Click += new System.EventHandler(活跃度_重载按钮_Click);
		this.活跃度_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.活跃度_保存按钮.Location = new System.Drawing.Point(363, 8);
		this.活跃度_保存按钮.Name = "活跃度_保存按钮";
		this.活跃度_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.活跃度_保存按钮.TabIndex = 125;
		this.活跃度_保存按钮.Text = "保存配置";
		this.活跃度_保存按钮.UseVisualStyleBackColor = true;
		this.活跃度_保存按钮.Click += new System.EventHandler(活跃度_保存按钮_Click);
		this.活跃度_普通玩家可领取开关.AutoSize = true;
		this.活跃度_普通玩家可领取开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.活跃度_普通玩家可领取开关.Location = new System.Drawing.Point(137, 12);
		this.活跃度_普通玩家可领取开关.Name = "活跃度_普通玩家可领取开关";
		this.活跃度_普通玩家可领取开关.Size = new System.Drawing.Size(223, 23);
		this.活跃度_普通玩家可领取开关.TabIndex = 127;
		this.活跃度_普通玩家可领取开关.Text = "非特权会员可领取活跃度奖励开关";
		this.活跃度_普通玩家可领取开关.UseVisualStyleBackColor = true;
		this.活跃度50奖励_道具.Location = new System.Drawing.Point(681, 75);
		this.活跃度50奖励_道具.Name = "活跃度50奖励_道具";
		this.活跃度50奖励_道具.Size = new System.Drawing.Size(100, 23);
		this.活跃度50奖励_道具.TabIndex = 166;
		this.活跃度50奖励_金元宝.Location = new System.Drawing.Point(113, 75);
		this.活跃度50奖励_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度50奖励_金元宝.Name = "活跃度50奖励_金元宝";
		this.活跃度50奖励_金元宝.Size = new System.Drawing.Size(100, 23);
		this.活跃度50奖励_金元宝.TabIndex = 168;
		this.textBox6.Location = new System.Drawing.Point(12, 51);
		this.textBox6.Name = "textBox6";
		this.textBox6.ReadOnly = true;
		this.textBox6.Size = new System.Drawing.Size(100, 23);
		this.textBox6.TabIndex = 167;
		this.textBox6.Text = " 50活跃度奖励";
		this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox1.Location = new System.Drawing.Point(52, 75);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(60, 23);
		this.textBox1.TabIndex = 169;
		this.textBox1.Text = "金元宝";
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox2.Location = new System.Drawing.Point(219, 75);
		this.textBox2.Name = "textBox2";
		this.textBox2.ReadOnly = true;
		this.textBox2.Size = new System.Drawing.Size(60, 23);
		this.textBox2.TabIndex = 171;
		this.textBox2.Text = "银元宝";
		this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度50奖励_银元宝.Location = new System.Drawing.Point(280, 75);
		this.活跃度50奖励_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度50奖励_银元宝.Name = "活跃度50奖励_银元宝";
		this.活跃度50奖励_银元宝.Size = new System.Drawing.Size(100, 23);
		this.活跃度50奖励_银元宝.TabIndex = 170;
		this.textBox3.Location = new System.Drawing.Point(386, 75);
		this.textBox3.Name = "textBox3";
		this.textBox3.ReadOnly = true;
		this.textBox3.Size = new System.Drawing.Size(60, 23);
		this.textBox3.TabIndex = 173;
		this.textBox3.Text = "累充点";
		this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度50奖励_累充点.Location = new System.Drawing.Point(447, 75);
		this.活跃度50奖励_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度50奖励_累充点.Name = "活跃度50奖励_累充点";
		this.活跃度50奖励_累充点.Size = new System.Drawing.Size(60, 23);
		this.活跃度50奖励_累充点.TabIndex = 172;
		this.textBox4.Location = new System.Drawing.Point(513, 75);
		this.textBox4.Name = "textBox4";
		this.textBox4.ReadOnly = true;
		this.textBox4.Size = new System.Drawing.Size(60, 23);
		this.textBox4.TabIndex = 175;
		this.textBox4.Text = "南极点";
		this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度50奖励_南极点.Location = new System.Drawing.Point(574, 75);
		this.活跃度50奖励_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度50奖励_南极点.Name = "活跃度50奖励_南极点";
		this.活跃度50奖励_南极点.Size = new System.Drawing.Size(60, 23);
		this.活跃度50奖励_南极点.TabIndex = 174;
		this.textBox5.Location = new System.Drawing.Point(640, 75);
		this.textBox5.Name = "textBox5";
		this.textBox5.ReadOnly = true;
		this.textBox5.Size = new System.Drawing.Size(40, 23);
		this.textBox5.TabIndex = 176;
		this.textBox5.Text = "道具";
		this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox7.Location = new System.Drawing.Point(640, 133);
		this.textBox7.Name = "textBox7";
		this.textBox7.ReadOnly = true;
		this.textBox7.Size = new System.Drawing.Size(40, 23);
		this.textBox7.TabIndex = 187;
		this.textBox7.Text = "道具";
		this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox8.Location = new System.Drawing.Point(513, 133);
		this.textBox8.Name = "textBox8";
		this.textBox8.ReadOnly = true;
		this.textBox8.Size = new System.Drawing.Size(60, 23);
		this.textBox8.TabIndex = 186;
		this.textBox8.Text = "南极点";
		this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度100奖励_南极点.Location = new System.Drawing.Point(574, 133);
		this.活跃度100奖励_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度100奖励_南极点.Name = "活跃度100奖励_南极点";
		this.活跃度100奖励_南极点.Size = new System.Drawing.Size(60, 23);
		this.活跃度100奖励_南极点.TabIndex = 185;
		this.textBox9.Location = new System.Drawing.Point(386, 133);
		this.textBox9.Name = "textBox9";
		this.textBox9.ReadOnly = true;
		this.textBox9.Size = new System.Drawing.Size(60, 23);
		this.textBox9.TabIndex = 184;
		this.textBox9.Text = "累充点";
		this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度100奖励_累充点.Location = new System.Drawing.Point(447, 133);
		this.活跃度100奖励_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度100奖励_累充点.Name = "活跃度100奖励_累充点";
		this.活跃度100奖励_累充点.Size = new System.Drawing.Size(60, 23);
		this.活跃度100奖励_累充点.TabIndex = 183;
		this.textBox10.Location = new System.Drawing.Point(219, 133);
		this.textBox10.Name = "textBox10";
		this.textBox10.ReadOnly = true;
		this.textBox10.Size = new System.Drawing.Size(60, 23);
		this.textBox10.TabIndex = 182;
		this.textBox10.Text = "银元宝";
		this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度100奖励_银元宝.Location = new System.Drawing.Point(280, 133);
		this.活跃度100奖励_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度100奖励_银元宝.Name = "活跃度100奖励_银元宝";
		this.活跃度100奖励_银元宝.Size = new System.Drawing.Size(100, 23);
		this.活跃度100奖励_银元宝.TabIndex = 181;
		this.textBox11.Location = new System.Drawing.Point(52, 133);
		this.textBox11.Name = "textBox11";
		this.textBox11.ReadOnly = true;
		this.textBox11.Size = new System.Drawing.Size(60, 23);
		this.textBox11.TabIndex = 180;
		this.textBox11.Text = "金元宝";
		this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度100奖励_道具.Location = new System.Drawing.Point(681, 133);
		this.活跃度100奖励_道具.Name = "活跃度100奖励_道具";
		this.活跃度100奖励_道具.Size = new System.Drawing.Size(100, 23);
		this.活跃度100奖励_道具.TabIndex = 177;
		this.活跃度100奖励_金元宝.Location = new System.Drawing.Point(113, 133);
		this.活跃度100奖励_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度100奖励_金元宝.Name = "活跃度100奖励_金元宝";
		this.活跃度100奖励_金元宝.Size = new System.Drawing.Size(100, 23);
		this.活跃度100奖励_金元宝.TabIndex = 179;
		this.textBox13.Location = new System.Drawing.Point(12, 109);
		this.textBox13.Name = "textBox13";
		this.textBox13.ReadOnly = true;
		this.textBox13.Size = new System.Drawing.Size(100, 23);
		this.textBox13.TabIndex = 178;
		this.textBox13.Text = "100活跃度奖励";
		this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox14.Location = new System.Drawing.Point(640, 191);
		this.textBox14.Name = "textBox14";
		this.textBox14.ReadOnly = true;
		this.textBox14.Size = new System.Drawing.Size(40, 23);
		this.textBox14.TabIndex = 198;
		this.textBox14.Text = "道具";
		this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox15.Location = new System.Drawing.Point(513, 191);
		this.textBox15.Name = "textBox15";
		this.textBox15.ReadOnly = true;
		this.textBox15.Size = new System.Drawing.Size(60, 23);
		this.textBox15.TabIndex = 197;
		this.textBox15.Text = "南极点";
		this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度150奖励_南极点.Location = new System.Drawing.Point(574, 191);
		this.活跃度150奖励_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度150奖励_南极点.Name = "活跃度150奖励_南极点";
		this.活跃度150奖励_南极点.Size = new System.Drawing.Size(60, 23);
		this.活跃度150奖励_南极点.TabIndex = 196;
		this.textBox16.Location = new System.Drawing.Point(386, 191);
		this.textBox16.Name = "textBox16";
		this.textBox16.ReadOnly = true;
		this.textBox16.Size = new System.Drawing.Size(60, 23);
		this.textBox16.TabIndex = 195;
		this.textBox16.Text = "累充点";
		this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度150奖励_累充点.Location = new System.Drawing.Point(447, 191);
		this.活跃度150奖励_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度150奖励_累充点.Name = "活跃度150奖励_累充点";
		this.活跃度150奖励_累充点.Size = new System.Drawing.Size(60, 23);
		this.活跃度150奖励_累充点.TabIndex = 194;
		this.textBox17.Location = new System.Drawing.Point(219, 191);
		this.textBox17.Name = "textBox17";
		this.textBox17.ReadOnly = true;
		this.textBox17.Size = new System.Drawing.Size(60, 23);
		this.textBox17.TabIndex = 193;
		this.textBox17.Text = "银元宝";
		this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度150奖励_银元宝.Location = new System.Drawing.Point(280, 191);
		this.活跃度150奖励_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度150奖励_银元宝.Name = "活跃度150奖励_银元宝";
		this.活跃度150奖励_银元宝.Size = new System.Drawing.Size(100, 23);
		this.活跃度150奖励_银元宝.TabIndex = 192;
		this.textBox18.Location = new System.Drawing.Point(52, 191);
		this.textBox18.Name = "textBox18";
		this.textBox18.ReadOnly = true;
		this.textBox18.Size = new System.Drawing.Size(60, 23);
		this.textBox18.TabIndex = 191;
		this.textBox18.Text = "金元宝";
		this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度150奖励_道具.Location = new System.Drawing.Point(681, 191);
		this.活跃度150奖励_道具.Name = "活跃度150奖励_道具";
		this.活跃度150奖励_道具.Size = new System.Drawing.Size(100, 23);
		this.活跃度150奖励_道具.TabIndex = 188;
		this.活跃度150奖励_金元宝.Location = new System.Drawing.Point(113, 191);
		this.活跃度150奖励_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度150奖励_金元宝.Name = "活跃度150奖励_金元宝";
		this.活跃度150奖励_金元宝.Size = new System.Drawing.Size(100, 23);
		this.活跃度150奖励_金元宝.TabIndex = 190;
		this.textBox20.Location = new System.Drawing.Point(12, 167);
		this.textBox20.Name = "textBox20";
		this.textBox20.ReadOnly = true;
		this.textBox20.Size = new System.Drawing.Size(100, 23);
		this.textBox20.TabIndex = 189;
		this.textBox20.Text = "150活跃度奖励";
		this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox21.Location = new System.Drawing.Point(640, 249);
		this.textBox21.Name = "textBox21";
		this.textBox21.ReadOnly = true;
		this.textBox21.Size = new System.Drawing.Size(40, 23);
		this.textBox21.TabIndex = 209;
		this.textBox21.Text = "道具";
		this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox22.Location = new System.Drawing.Point(513, 249);
		this.textBox22.Name = "textBox22";
		this.textBox22.ReadOnly = true;
		this.textBox22.Size = new System.Drawing.Size(60, 23);
		this.textBox22.TabIndex = 208;
		this.textBox22.Text = "南极点";
		this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度200奖励_南极点.Location = new System.Drawing.Point(574, 249);
		this.活跃度200奖励_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度200奖励_南极点.Name = "活跃度200奖励_南极点";
		this.活跃度200奖励_南极点.Size = new System.Drawing.Size(60, 23);
		this.活跃度200奖励_南极点.TabIndex = 207;
		this.textBox23.Location = new System.Drawing.Point(386, 249);
		this.textBox23.Name = "textBox23";
		this.textBox23.ReadOnly = true;
		this.textBox23.Size = new System.Drawing.Size(60, 23);
		this.textBox23.TabIndex = 206;
		this.textBox23.Text = "累充点";
		this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度200奖励_累充点.Location = new System.Drawing.Point(447, 249);
		this.活跃度200奖励_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度200奖励_累充点.Name = "活跃度200奖励_累充点";
		this.活跃度200奖励_累充点.Size = new System.Drawing.Size(60, 23);
		this.活跃度200奖励_累充点.TabIndex = 205;
		this.textBox24.Location = new System.Drawing.Point(219, 249);
		this.textBox24.Name = "textBox24";
		this.textBox24.ReadOnly = true;
		this.textBox24.Size = new System.Drawing.Size(60, 23);
		this.textBox24.TabIndex = 204;
		this.textBox24.Text = "银元宝";
		this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度200奖励_银元宝.Location = new System.Drawing.Point(280, 249);
		this.活跃度200奖励_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度200奖励_银元宝.Name = "活跃度200奖励_银元宝";
		this.活跃度200奖励_银元宝.Size = new System.Drawing.Size(100, 23);
		this.活跃度200奖励_银元宝.TabIndex = 203;
		this.textBox25.Location = new System.Drawing.Point(52, 249);
		this.textBox25.Name = "textBox25";
		this.textBox25.ReadOnly = true;
		this.textBox25.Size = new System.Drawing.Size(60, 23);
		this.textBox25.TabIndex = 202;
		this.textBox25.Text = "金元宝";
		this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度200奖励_道具.Location = new System.Drawing.Point(681, 249);
		this.活跃度200奖励_道具.Name = "活跃度200奖励_道具";
		this.活跃度200奖励_道具.Size = new System.Drawing.Size(100, 23);
		this.活跃度200奖励_道具.TabIndex = 199;
		this.活跃度200奖励_金元宝.Location = new System.Drawing.Point(113, 249);
		this.活跃度200奖励_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度200奖励_金元宝.Name = "活跃度200奖励_金元宝";
		this.活跃度200奖励_金元宝.Size = new System.Drawing.Size(100, 23);
		this.活跃度200奖励_金元宝.TabIndex = 201;
		this.textBox27.Location = new System.Drawing.Point(12, 225);
		this.textBox27.Name = "textBox27";
		this.textBox27.ReadOnly = true;
		this.textBox27.Size = new System.Drawing.Size(100, 23);
		this.textBox27.TabIndex = 200;
		this.textBox27.Text = "200活跃度奖励";
		this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox28.Location = new System.Drawing.Point(640, 307);
		this.textBox28.Name = "textBox28";
		this.textBox28.ReadOnly = true;
		this.textBox28.Size = new System.Drawing.Size(40, 23);
		this.textBox28.TabIndex = 220;
		this.textBox28.Text = "道具";
		this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox29.Location = new System.Drawing.Point(513, 307);
		this.textBox29.Name = "textBox29";
		this.textBox29.ReadOnly = true;
		this.textBox29.Size = new System.Drawing.Size(60, 23);
		this.textBox29.TabIndex = 219;
		this.textBox29.Text = "南极点";
		this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度250奖励_南极点.Location = new System.Drawing.Point(574, 307);
		this.活跃度250奖励_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度250奖励_南极点.Name = "活跃度250奖励_南极点";
		this.活跃度250奖励_南极点.Size = new System.Drawing.Size(60, 23);
		this.活跃度250奖励_南极点.TabIndex = 218;
		this.textBox30.Location = new System.Drawing.Point(386, 307);
		this.textBox30.Name = "textBox30";
		this.textBox30.ReadOnly = true;
		this.textBox30.Size = new System.Drawing.Size(60, 23);
		this.textBox30.TabIndex = 217;
		this.textBox30.Text = "累充点";
		this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度250奖励_累充点.Location = new System.Drawing.Point(447, 307);
		this.活跃度250奖励_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度250奖励_累充点.Name = "活跃度250奖励_累充点";
		this.活跃度250奖励_累充点.Size = new System.Drawing.Size(60, 23);
		this.活跃度250奖励_累充点.TabIndex = 216;
		this.textBox31.Location = new System.Drawing.Point(219, 307);
		this.textBox31.Name = "textBox31";
		this.textBox31.ReadOnly = true;
		this.textBox31.Size = new System.Drawing.Size(60, 23);
		this.textBox31.TabIndex = 215;
		this.textBox31.Text = "银元宝";
		this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度250奖励_银元宝.Location = new System.Drawing.Point(280, 307);
		this.活跃度250奖励_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度250奖励_银元宝.Name = "活跃度250奖励_银元宝";
		this.活跃度250奖励_银元宝.Size = new System.Drawing.Size(100, 23);
		this.活跃度250奖励_银元宝.TabIndex = 214;
		this.textBox32.Location = new System.Drawing.Point(52, 307);
		this.textBox32.Name = "textBox32";
		this.textBox32.ReadOnly = true;
		this.textBox32.Size = new System.Drawing.Size(60, 23);
		this.textBox32.TabIndex = 213;
		this.textBox32.Text = "金元宝";
		this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度250奖励_道具.Location = new System.Drawing.Point(681, 307);
		this.活跃度250奖励_道具.Name = "活跃度250奖励_道具";
		this.活跃度250奖励_道具.Size = new System.Drawing.Size(100, 23);
		this.活跃度250奖励_道具.TabIndex = 210;
		this.活跃度250奖励_金元宝.Location = new System.Drawing.Point(113, 307);
		this.活跃度250奖励_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度250奖励_金元宝.Name = "活跃度250奖励_金元宝";
		this.活跃度250奖励_金元宝.Size = new System.Drawing.Size(100, 23);
		this.活跃度250奖励_金元宝.TabIndex = 212;
		this.textBox34.Location = new System.Drawing.Point(12, 283);
		this.textBox34.Name = "textBox34";
		this.textBox34.ReadOnly = true;
		this.textBox34.Size = new System.Drawing.Size(100, 23);
		this.textBox34.TabIndex = 211;
		this.textBox34.Text = "250活跃度奖励";
		this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox35.Location = new System.Drawing.Point(640, 365);
		this.textBox35.Name = "textBox35";
		this.textBox35.ReadOnly = true;
		this.textBox35.Size = new System.Drawing.Size(40, 23);
		this.textBox35.TabIndex = 231;
		this.textBox35.Text = "道具";
		this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox36.Location = new System.Drawing.Point(513, 365);
		this.textBox36.Name = "textBox36";
		this.textBox36.ReadOnly = true;
		this.textBox36.Size = new System.Drawing.Size(60, 23);
		this.textBox36.TabIndex = 230;
		this.textBox36.Text = "南极点";
		this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度300奖励_南极点.Location = new System.Drawing.Point(574, 365);
		this.活跃度300奖励_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度300奖励_南极点.Name = "活跃度300奖励_南极点";
		this.活跃度300奖励_南极点.Size = new System.Drawing.Size(60, 23);
		this.活跃度300奖励_南极点.TabIndex = 229;
		this.textBox37.Location = new System.Drawing.Point(386, 365);
		this.textBox37.Name = "textBox37";
		this.textBox37.ReadOnly = true;
		this.textBox37.Size = new System.Drawing.Size(60, 23);
		this.textBox37.TabIndex = 228;
		this.textBox37.Text = "累充点";
		this.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度300奖励_累充点.Location = new System.Drawing.Point(447, 365);
		this.活跃度300奖励_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度300奖励_累充点.Name = "活跃度300奖励_累充点";
		this.活跃度300奖励_累充点.Size = new System.Drawing.Size(60, 23);
		this.活跃度300奖励_累充点.TabIndex = 227;
		this.textBox38.Location = new System.Drawing.Point(219, 365);
		this.textBox38.Name = "textBox38";
		this.textBox38.ReadOnly = true;
		this.textBox38.Size = new System.Drawing.Size(60, 23);
		this.textBox38.TabIndex = 226;
		this.textBox38.Text = "银元宝";
		this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度300奖励_银元宝.Location = new System.Drawing.Point(280, 365);
		this.活跃度300奖励_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度300奖励_银元宝.Name = "活跃度300奖励_银元宝";
		this.活跃度300奖励_银元宝.Size = new System.Drawing.Size(100, 23);
		this.活跃度300奖励_银元宝.TabIndex = 225;
		this.textBox39.Location = new System.Drawing.Point(52, 365);
		this.textBox39.Name = "textBox39";
		this.textBox39.ReadOnly = true;
		this.textBox39.Size = new System.Drawing.Size(60, 23);
		this.textBox39.TabIndex = 224;
		this.textBox39.Text = "金元宝";
		this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.活跃度300奖励_道具.Location = new System.Drawing.Point(681, 365);
		this.活跃度300奖励_道具.Name = "活跃度300奖励_道具";
		this.活跃度300奖励_道具.Size = new System.Drawing.Size(100, 23);
		this.活跃度300奖励_道具.TabIndex = 221;
		this.活跃度300奖励_金元宝.Location = new System.Drawing.Point(113, 365);
		this.活跃度300奖励_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.活跃度300奖励_金元宝.Name = "活跃度300奖励_金元宝";
		this.活跃度300奖励_金元宝.Size = new System.Drawing.Size(100, 23);
		this.活跃度300奖励_金元宝.TabIndex = 223;
		this.textBox41.Location = new System.Drawing.Point(12, 341);
		this.textBox41.Name = "textBox41";
		this.textBox41.ReadOnly = true;
		this.textBox41.Size = new System.Drawing.Size(100, 23);
		this.textBox41.TabIndex = 222;
		this.textBox41.Text = "300活跃度奖励";
		this.textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(800, 407);
		base.Controls.Add(this.textBox35);
		base.Controls.Add(this.textBox36);
		base.Controls.Add(this.活跃度300奖励_南极点);
		base.Controls.Add(this.textBox37);
		base.Controls.Add(this.活跃度300奖励_累充点);
		base.Controls.Add(this.textBox38);
		base.Controls.Add(this.活跃度300奖励_银元宝);
		base.Controls.Add(this.textBox39);
		base.Controls.Add(this.活跃度300奖励_道具);
		base.Controls.Add(this.活跃度300奖励_金元宝);
		base.Controls.Add(this.textBox41);
		base.Controls.Add(this.textBox28);
		base.Controls.Add(this.textBox29);
		base.Controls.Add(this.活跃度250奖励_南极点);
		base.Controls.Add(this.textBox30);
		base.Controls.Add(this.活跃度250奖励_累充点);
		base.Controls.Add(this.textBox31);
		base.Controls.Add(this.活跃度250奖励_银元宝);
		base.Controls.Add(this.textBox32);
		base.Controls.Add(this.活跃度250奖励_道具);
		base.Controls.Add(this.活跃度250奖励_金元宝);
		base.Controls.Add(this.textBox34);
		base.Controls.Add(this.textBox21);
		base.Controls.Add(this.textBox22);
		base.Controls.Add(this.活跃度200奖励_南极点);
		base.Controls.Add(this.textBox23);
		base.Controls.Add(this.活跃度200奖励_累充点);
		base.Controls.Add(this.textBox24);
		base.Controls.Add(this.活跃度200奖励_银元宝);
		base.Controls.Add(this.textBox25);
		base.Controls.Add(this.活跃度200奖励_道具);
		base.Controls.Add(this.活跃度200奖励_金元宝);
		base.Controls.Add(this.textBox27);
		base.Controls.Add(this.textBox14);
		base.Controls.Add(this.textBox15);
		base.Controls.Add(this.活跃度150奖励_南极点);
		base.Controls.Add(this.textBox16);
		base.Controls.Add(this.活跃度150奖励_累充点);
		base.Controls.Add(this.textBox17);
		base.Controls.Add(this.活跃度150奖励_银元宝);
		base.Controls.Add(this.textBox18);
		base.Controls.Add(this.活跃度150奖励_道具);
		base.Controls.Add(this.活跃度150奖励_金元宝);
		base.Controls.Add(this.textBox20);
		base.Controls.Add(this.textBox7);
		base.Controls.Add(this.textBox8);
		base.Controls.Add(this.活跃度100奖励_南极点);
		base.Controls.Add(this.textBox9);
		base.Controls.Add(this.活跃度100奖励_累充点);
		base.Controls.Add(this.textBox10);
		base.Controls.Add(this.活跃度100奖励_银元宝);
		base.Controls.Add(this.textBox11);
		base.Controls.Add(this.活跃度100奖励_道具);
		base.Controls.Add(this.活跃度100奖励_金元宝);
		base.Controls.Add(this.textBox13);
		base.Controls.Add(this.textBox5);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.活跃度50奖励_南极点);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.活跃度50奖励_累充点);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.活跃度50奖励_银元宝);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.活跃度50奖励_道具);
		base.Controls.Add(this.活跃度50奖励_金元宝);
		base.Controls.Add(this.textBox6);
		base.Controls.Add(this.活跃度_普通玩家可领取开关);
		base.Controls.Add(this.活跃度_开关);
		base.Controls.Add(this.活跃度_重载按钮);
		base.Controls.Add(this.活跃度_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "活跃度奖励配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "活跃度奖励配置窗口";
		base.Load += new System.EventHandler(活跃度奖励配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.活跃度50奖励_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度50奖励_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度50奖励_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度50奖励_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度100奖励_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度100奖励_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度100奖励_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度100奖励_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度150奖励_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度150奖励_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度150奖励_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度150奖励_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度200奖励_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度200奖励_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度200奖励_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度200奖励_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度250奖励_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度250奖励_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度250奖励_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度250奖励_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度300奖励_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度300奖励_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度300奖励_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.活跃度300奖励_金元宝).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
