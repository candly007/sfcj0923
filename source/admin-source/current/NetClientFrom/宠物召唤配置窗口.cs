using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 宠物召唤配置窗口 : Form
{
	private static 宠物召唤配置窗口 i;

	private IContainer components;

	private GroupBox groupBox1;

	private NumericUpDown 宠物召唤_形象;

	private Label label9;

	private ComboBox 宠物召唤_朝向;

	private Label label8;

	private NumericUpDown 宠物召唤_坐标Y;

	private NumericUpDown 宠物召唤_坐标X;

	private Label label7;

	private Label label5;

	private TextBox 宠物召唤_npc称号;

	private Label label4;

	private TextBox 宠物召唤_npc名字;

	private CheckBox 宠物召唤_开关;

	private Button 宠物召唤_重载按钮;

	private Button 宠物召唤_保存按钮;

	private CheckBox 宠物召唤_变异开关;

	private TextBox 宠物召唤_变异材料;

	private NumericUpDown 宠物召唤_变异最低;

	private TextBox 地狱道_名字;

	private TextBox 宠物召唤_变异奖励;

	private TextBox textBox2;

	private TextBox textBox3;

	private TextBox textBox4;

	private NumericUpDown 宠物召唤_变异最高;

	private TextBox 宠物召唤_变异对话;

	private TextBox textBox6;

	private TextBox 宠物召唤_神兽对话;

	private TextBox textBox8;

	private TextBox textBox9;

	private NumericUpDown 宠物召唤_神兽最高;

	private TextBox textBox10;

	private TextBox 宠物召唤_神兽奖励;

	private TextBox textBox12;

	private TextBox 宠物召唤_神兽材料;

	private NumericUpDown 宠物召唤_神兽最低;

	private TextBox textBox14;

	private CheckBox 宠物召唤_神兽开关;

	private TextBox 宠物召唤_元灵对话;

	private TextBox textBox16;

	private TextBox textBox17;

	private NumericUpDown 宠物召唤_元灵最高;

	private TextBox textBox18;

	private TextBox 宠物召唤_元灵奖励;

	private TextBox textBox20;

	private TextBox 宠物召唤_元灵材料;

	private NumericUpDown 宠物召唤_元灵最低;

	private TextBox textBox22;

	private CheckBox 宠物召唤_元灵开关;

	private TextBox 宠物召唤_仙元对话;

	private TextBox textBox24;

	private TextBox textBox25;

	private NumericUpDown 宠物召唤_仙元最高;

	private TextBox textBox26;

	private TextBox 宠物召唤_仙元奖励;

	private TextBox textBox28;

	private TextBox 宠物召唤_仙元材料;

	private NumericUpDown 宠物召唤_仙元最低;

	private TextBox textBox30;

	private CheckBox 宠物召唤_仙元开关;

	private TextBox 宠物召唤_御灵对话;

	private TextBox textBox32;

	private TextBox textBox33;

	private NumericUpDown 宠物召唤_御灵最高;

	private TextBox textBox34;

	private TextBox 宠物召唤_御灵奖励;

	private TextBox textBox36;

	private TextBox 宠物召唤_御灵材料;

	private NumericUpDown 宠物召唤_御灵最低;

	private TextBox textBox38;

	private CheckBox 宠物召唤_御灵开关;

	private Label label17;

	private Label label1;

	private TextBox 宠物召唤_npc对话;

	public static 宠物召唤配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 宠物召唤配置窗口();
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

	public 宠物召唤配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 宠物召唤配置窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		宠物召唤_重载按钮_Click(sender, e);
	}

	private void 宠物召唤_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 22, JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物召唤配置, Formatting.Indented));
		}
	}

	private void 宠物召唤_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 22);
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (base.IsHandleCreated && 配置类型 == 22)
		{
			Invoke((MethodInvoker)delegate
			{
				宠物召唤_开关.Checked = Singleton<全局变量类>.I.宠物召唤配置.功能开关;
				宠物召唤_npc名字.Text = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字;
				宠物召唤_npc称号.Text = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc称号;
				宠物召唤_坐标X.Value = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.坐标.X;
				宠物召唤_坐标Y.Value = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.坐标.Y;
				宠物召唤_朝向.Text = $"{(AllEnums.朝向Type)Singleton<全局变量类>.I.宠物召唤配置.NPC数据.朝向}";
				宠物召唤_形象.Value = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象;
				宠物召唤_npc对话.Text = Singleton<全局变量类>.I.宠物召唤配置.NPC数据.对话文本;
				宠物召唤_变异开关.Checked = Singleton<全局变量类>.I.宠物召唤配置.is变异召唤;
				宠物召唤_变异材料.Text = Singleton<全局变量类>.I.宠物召唤配置.变异材料;
				宠物召唤_变异奖励.Text = Singleton<全局变量类>.I.宠物召唤配置.变异奖励;
				宠物召唤_变异最低.Value = Singleton<全局变量类>.I.宠物召唤配置.变异最低;
				宠物召唤_变异最高.Value = Singleton<全局变量类>.I.宠物召唤配置.变异最高;
				宠物召唤_变异对话.Text = Singleton<全局变量类>.I.宠物召唤配置.变异对话;
				宠物召唤_神兽开关.Checked = Singleton<全局变量类>.I.宠物召唤配置.is神兽召唤;
				宠物召唤_神兽材料.Text = Singleton<全局变量类>.I.宠物召唤配置.神兽材料;
				宠物召唤_神兽奖励.Text = Singleton<全局变量类>.I.宠物召唤配置.神兽奖励;
				宠物召唤_神兽最低.Value = Singleton<全局变量类>.I.宠物召唤配置.神兽最低;
				宠物召唤_神兽最高.Value = Singleton<全局变量类>.I.宠物召唤配置.神兽最高;
				宠物召唤_神兽对话.Text = Singleton<全局变量类>.I.宠物召唤配置.神兽对话;
				宠物召唤_元灵开关.Checked = Singleton<全局变量类>.I.宠物召唤配置.is元灵召唤;
				宠物召唤_元灵材料.Text = Singleton<全局变量类>.I.宠物召唤配置.元灵材料;
				宠物召唤_元灵奖励.Text = Singleton<全局变量类>.I.宠物召唤配置.元灵奖励;
				宠物召唤_元灵最低.Value = Singleton<全局变量类>.I.宠物召唤配置.元灵最低;
				宠物召唤_元灵最高.Value = Singleton<全局变量类>.I.宠物召唤配置.元灵最高;
				宠物召唤_元灵对话.Text = Singleton<全局变量类>.I.宠物召唤配置.元灵对话;
				宠物召唤_仙元开关.Checked = Singleton<全局变量类>.I.宠物召唤配置.is仙元召唤;
				宠物召唤_仙元材料.Text = Singleton<全局变量类>.I.宠物召唤配置.仙元材料;
				宠物召唤_仙元奖励.Text = Singleton<全局变量类>.I.宠物召唤配置.仙元奖励;
				宠物召唤_仙元最低.Value = Singleton<全局变量类>.I.宠物召唤配置.仙元最低;
				宠物召唤_仙元最高.Value = Singleton<全局变量类>.I.宠物召唤配置.仙元最高;
				宠物召唤_仙元对话.Text = Singleton<全局变量类>.I.宠物召唤配置.仙元对话;
				宠物召唤_御灵开关.Checked = Singleton<全局变量类>.I.宠物召唤配置.is御灵召唤;
				宠物召唤_御灵材料.Text = Singleton<全局变量类>.I.宠物召唤配置.御灵材料;
				宠物召唤_御灵奖励.Text = Singleton<全局变量类>.I.宠物召唤配置.御灵奖励;
				宠物召唤_御灵最低.Value = Singleton<全局变量类>.I.宠物召唤配置.御灵最低;
				宠物召唤_御灵最高.Value = Singleton<全局变量类>.I.宠物召唤配置.御灵最高;
				宠物召唤_御灵对话.Text = Singleton<全局变量类>.I.宠物召唤配置.御灵对话;
			});
		}
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.宠物召唤配置.功能开关 = 宠物召唤_开关.Checked;
			Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc名字 = 宠物召唤_npc名字.Text;
			Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc称号 = 宠物召唤_npc称号.Text;
			Singleton<全局变量类>.I.宠物召唤配置.NPC数据.坐标.X = (short)宠物召唤_坐标X.Value;
			Singleton<全局变量类>.I.宠物召唤配置.NPC数据.坐标.Y = (short)宠物召唤_坐标Y.Value;
			Singleton<全局变量类>.I.宠物召唤配置.NPC数据.朝向 = (short)Enum.Parse<AllEnums.朝向Type>(宠物召唤_朝向.Text);
			Singleton<全局变量类>.I.宠物召唤配置.NPC数据.npc形象 = (int)宠物召唤_形象.Value;
			Singleton<全局变量类>.I.宠物召唤配置.NPC数据.对话文本 = 宠物召唤_npc对话.Text;
			Singleton<全局变量类>.I.宠物召唤配置.is变异召唤 = 宠物召唤_变异开关.Checked;
			Singleton<全局变量类>.I.宠物召唤配置.变异材料 = 宠物召唤_变异材料.Text;
			Singleton<全局变量类>.I.宠物召唤配置.变异奖励 = 宠物召唤_变异奖励.Text;
			Singleton<全局变量类>.I.宠物召唤配置.变异最低 = (int)宠物召唤_变异最低.Value;
			Singleton<全局变量类>.I.宠物召唤配置.变异最高 = (int)宠物召唤_变异最高.Value;
			Singleton<全局变量类>.I.宠物召唤配置.变异对话 = 宠物召唤_变异对话.Text;
			Singleton<全局变量类>.I.宠物召唤配置.is神兽召唤 = 宠物召唤_神兽开关.Checked;
			Singleton<全局变量类>.I.宠物召唤配置.神兽材料 = 宠物召唤_神兽材料.Text;
			Singleton<全局变量类>.I.宠物召唤配置.神兽奖励 = 宠物召唤_神兽奖励.Text;
			Singleton<全局变量类>.I.宠物召唤配置.神兽最低 = (int)宠物召唤_神兽最低.Value;
			Singleton<全局变量类>.I.宠物召唤配置.神兽最高 = (int)宠物召唤_神兽最高.Value;
			Singleton<全局变量类>.I.宠物召唤配置.神兽对话 = 宠物召唤_神兽对话.Text;
			Singleton<全局变量类>.I.宠物召唤配置.is元灵召唤 = 宠物召唤_元灵开关.Checked;
			Singleton<全局变量类>.I.宠物召唤配置.元灵材料 = 宠物召唤_元灵材料.Text;
			Singleton<全局变量类>.I.宠物召唤配置.元灵奖励 = 宠物召唤_元灵奖励.Text;
			Singleton<全局变量类>.I.宠物召唤配置.元灵最低 = (int)宠物召唤_元灵最低.Value;
			Singleton<全局变量类>.I.宠物召唤配置.元灵最高 = (int)宠物召唤_元灵最高.Value;
			Singleton<全局变量类>.I.宠物召唤配置.元灵对话 = 宠物召唤_元灵对话.Text;
			Singleton<全局变量类>.I.宠物召唤配置.is仙元召唤 = 宠物召唤_仙元开关.Checked;
			Singleton<全局变量类>.I.宠物召唤配置.仙元材料 = 宠物召唤_仙元材料.Text;
			Singleton<全局变量类>.I.宠物召唤配置.仙元奖励 = 宠物召唤_仙元奖励.Text;
			Singleton<全局变量类>.I.宠物召唤配置.仙元最低 = (int)宠物召唤_仙元最低.Value;
			Singleton<全局变量类>.I.宠物召唤配置.仙元最高 = (int)宠物召唤_仙元最高.Value;
			Singleton<全局变量类>.I.宠物召唤配置.仙元对话 = 宠物召唤_仙元对话.Text;
			Singleton<全局变量类>.I.宠物召唤配置.is御灵召唤 = 宠物召唤_御灵开关.Checked;
			Singleton<全局变量类>.I.宠物召唤配置.御灵材料 = 宠物召唤_御灵材料.Text;
			Singleton<全局变量类>.I.宠物召唤配置.御灵奖励 = 宠物召唤_御灵奖励.Text;
			Singleton<全局变量类>.I.宠物召唤配置.御灵最低 = (int)宠物召唤_御灵最低.Value;
			Singleton<全局变量类>.I.宠物召唤配置.御灵最高 = (int)宠物召唤_御灵最高.Value;
			Singleton<全局变量类>.I.宠物召唤配置.御灵对话 = 宠物召唤_御灵对话.Text;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.宠物召唤配置窗口));
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.宠物召唤_形象 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.宠物召唤_朝向 = new System.Windows.Forms.ComboBox();
		this.label8 = new System.Windows.Forms.Label();
		this.宠物召唤_坐标Y = new System.Windows.Forms.NumericUpDown();
		this.宠物召唤_坐标X = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.宠物召唤_npc称号 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.宠物召唤_npc名字 = new System.Windows.Forms.TextBox();
		this.宠物召唤_开关 = new System.Windows.Forms.CheckBox();
		this.宠物召唤_重载按钮 = new System.Windows.Forms.Button();
		this.宠物召唤_保存按钮 = new System.Windows.Forms.Button();
		this.宠物召唤_变异开关 = new System.Windows.Forms.CheckBox();
		this.宠物召唤_变异材料 = new System.Windows.Forms.TextBox();
		this.宠物召唤_变异最低 = new System.Windows.Forms.NumericUpDown();
		this.地狱道_名字 = new System.Windows.Forms.TextBox();
		this.宠物召唤_变异奖励 = new System.Windows.Forms.TextBox();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.宠物召唤_变异最高 = new System.Windows.Forms.NumericUpDown();
		this.宠物召唤_变异对话 = new System.Windows.Forms.TextBox();
		this.textBox6 = new System.Windows.Forms.TextBox();
		this.宠物召唤_神兽对话 = new System.Windows.Forms.TextBox();
		this.textBox8 = new System.Windows.Forms.TextBox();
		this.textBox9 = new System.Windows.Forms.TextBox();
		this.宠物召唤_神兽最高 = new System.Windows.Forms.NumericUpDown();
		this.textBox10 = new System.Windows.Forms.TextBox();
		this.宠物召唤_神兽奖励 = new System.Windows.Forms.TextBox();
		this.textBox12 = new System.Windows.Forms.TextBox();
		this.宠物召唤_神兽材料 = new System.Windows.Forms.TextBox();
		this.宠物召唤_神兽最低 = new System.Windows.Forms.NumericUpDown();
		this.textBox14 = new System.Windows.Forms.TextBox();
		this.宠物召唤_神兽开关 = new System.Windows.Forms.CheckBox();
		this.宠物召唤_元灵对话 = new System.Windows.Forms.TextBox();
		this.textBox16 = new System.Windows.Forms.TextBox();
		this.textBox17 = new System.Windows.Forms.TextBox();
		this.宠物召唤_元灵最高 = new System.Windows.Forms.NumericUpDown();
		this.textBox18 = new System.Windows.Forms.TextBox();
		this.宠物召唤_元灵奖励 = new System.Windows.Forms.TextBox();
		this.textBox20 = new System.Windows.Forms.TextBox();
		this.宠物召唤_元灵材料 = new System.Windows.Forms.TextBox();
		this.宠物召唤_元灵最低 = new System.Windows.Forms.NumericUpDown();
		this.textBox22 = new System.Windows.Forms.TextBox();
		this.宠物召唤_元灵开关 = new System.Windows.Forms.CheckBox();
		this.宠物召唤_仙元对话 = new System.Windows.Forms.TextBox();
		this.textBox24 = new System.Windows.Forms.TextBox();
		this.textBox25 = new System.Windows.Forms.TextBox();
		this.宠物召唤_仙元最高 = new System.Windows.Forms.NumericUpDown();
		this.textBox26 = new System.Windows.Forms.TextBox();
		this.宠物召唤_仙元奖励 = new System.Windows.Forms.TextBox();
		this.textBox28 = new System.Windows.Forms.TextBox();
		this.宠物召唤_仙元材料 = new System.Windows.Forms.TextBox();
		this.宠物召唤_仙元最低 = new System.Windows.Forms.NumericUpDown();
		this.textBox30 = new System.Windows.Forms.TextBox();
		this.宠物召唤_仙元开关 = new System.Windows.Forms.CheckBox();
		this.宠物召唤_御灵对话 = new System.Windows.Forms.TextBox();
		this.textBox32 = new System.Windows.Forms.TextBox();
		this.textBox33 = new System.Windows.Forms.TextBox();
		this.宠物召唤_御灵最高 = new System.Windows.Forms.NumericUpDown();
		this.textBox34 = new System.Windows.Forms.TextBox();
		this.宠物召唤_御灵奖励 = new System.Windows.Forms.TextBox();
		this.textBox36 = new System.Windows.Forms.TextBox();
		this.宠物召唤_御灵材料 = new System.Windows.Forms.TextBox();
		this.宠物召唤_御灵最低 = new System.Windows.Forms.NumericUpDown();
		this.textBox38 = new System.Windows.Forms.TextBox();
		this.宠物召唤_御灵开关 = new System.Windows.Forms.CheckBox();
		this.label17 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.宠物召唤_npc对话 = new System.Windows.Forms.TextBox();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_形象).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_坐标Y).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_坐标X).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_变异最低).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_变异最高).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_神兽最高).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_神兽最低).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_元灵最高).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_元灵最低).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_仙元最高).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_仙元最低).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_御灵最高).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_御灵最低).BeginInit();
		base.SuspendLayout();
		this.groupBox1.BackColor = System.Drawing.Color.White;
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.宠物召唤_npc对话);
		this.groupBox1.Controls.Add(this.宠物召唤_形象);
		this.groupBox1.Controls.Add(this.label9);
		this.groupBox1.Controls.Add(this.宠物召唤_朝向);
		this.groupBox1.Controls.Add(this.label8);
		this.groupBox1.Controls.Add(this.宠物召唤_坐标Y);
		this.groupBox1.Controls.Add(this.宠物召唤_坐标X);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.宠物召唤_npc称号);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.宠物召唤_npc名字);
		this.groupBox1.Location = new System.Drawing.Point(12, 44);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(997, 85);
		this.groupBox1.TabIndex = 113;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "npc配置";
		this.宠物召唤_形象.Location = new System.Drawing.Point(644, 17);
		this.宠物召唤_形象.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.宠物召唤_形象.Name = "宠物召唤_形象";
		this.宠物召唤_形象.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_形象.TabIndex = 112;
		this.label9.BackColor = System.Drawing.Color.Transparent;
		this.label9.Location = new System.Drawing.Point(611, 17);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(32, 23);
		this.label9.TabIndex = 111;
		this.label9.Text = "形象";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.宠物召唤_朝向.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.宠物召唤_朝向.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.宠物召唤_朝向.FormattingEnabled = true;
		this.宠物召唤_朝向.Items.AddRange(new object[8] { "左", "左上", "上", "右上", "右", "右下", "下", "左下" });
		this.宠物召唤_朝向.Location = new System.Drawing.Point(545, 17);
		this.宠物召唤_朝向.Name = "宠物召唤_朝向";
		this.宠物召唤_朝向.Size = new System.Drawing.Size(60, 25);
		this.宠物召唤_朝向.TabIndex = 110;
		this.label8.BackColor = System.Drawing.Color.Transparent;
		this.label8.Location = new System.Drawing.Point(513, 19);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(32, 23);
		this.label8.TabIndex = 109;
		this.label8.Text = "朝向";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.宠物召唤_坐标Y.Location = new System.Drawing.Point(447, 19);
		this.宠物召唤_坐标Y.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.宠物召唤_坐标Y.Name = "宠物召唤_坐标Y";
		this.宠物召唤_坐标Y.Size = new System.Drawing.Size(60, 23);
		this.宠物召唤_坐标Y.TabIndex = 108;
		this.宠物召唤_坐标X.Location = new System.Drawing.Point(370, 19);
		this.宠物召唤_坐标X.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.宠物召唤_坐标X.Name = "宠物召唤_坐标X";
		this.宠物召唤_坐标X.Size = new System.Drawing.Size(60, 23);
		this.宠物召唤_坐标X.TabIndex = 107;
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
		this.label5.Text = "npc称号";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.宠物召唤_npc称号.Location = new System.Drawing.Point(229, 19);
		this.宠物召唤_npc称号.Name = "宠物召唤_npc称号";
		this.宠物召唤_npc称号.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_npc称号.TabIndex = 105;
		this.label4.Location = new System.Drawing.Point(6, 19);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 102;
		this.label4.Text = "npc名字";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.宠物召唤_npc名字.Location = new System.Drawing.Point(67, 19);
		this.宠物召唤_npc名字.Name = "宠物召唤_npc名字";
		this.宠物召唤_npc名字.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_npc名字.TabIndex = 103;
		this.宠物召唤_开关.AutoSize = true;
		this.宠物召唤_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.宠物召唤_开关.Location = new System.Drawing.Point(12, 12);
		this.宠物召唤_开关.Name = "宠物召唤_开关";
		this.宠物召唤_开关.Size = new System.Drawing.Size(106, 23);
		this.宠物召唤_开关.TabIndex = 110;
		this.宠物召唤_开关.Text = "宠物召唤开关";
		this.宠物召唤_开关.UseVisualStyleBackColor = true;
		this.宠物召唤_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.宠物召唤_重载按钮.Location = new System.Drawing.Point(246, 8);
		this.宠物召唤_重载按钮.Name = "宠物召唤_重载按钮";
		this.宠物召唤_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.宠物召唤_重载按钮.TabIndex = 112;
		this.宠物召唤_重载按钮.Text = "重载配置";
		this.宠物召唤_重载按钮.UseVisualStyleBackColor = true;
		this.宠物召唤_重载按钮.Click += new System.EventHandler(宠物召唤_重载按钮_Click);
		this.宠物召唤_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.宠物召唤_保存按钮.Location = new System.Drawing.Point(140, 8);
		this.宠物召唤_保存按钮.Name = "宠物召唤_保存按钮";
		this.宠物召唤_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.宠物召唤_保存按钮.TabIndex = 111;
		this.宠物召唤_保存按钮.Text = "保存配置";
		this.宠物召唤_保存按钮.UseVisualStyleBackColor = true;
		this.宠物召唤_保存按钮.Click += new System.EventHandler(宠物召唤_保存按钮_Click);
		this.宠物召唤_变异开关.AutoSize = true;
		this.宠物召唤_变异开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.宠物召唤_变异开关.Location = new System.Drawing.Point(12, 135);
		this.宠物召唤_变异开关.Name = "宠物召唤_变异开关";
		this.宠物召唤_变异开关.Size = new System.Drawing.Size(106, 23);
		this.宠物召唤_变异开关.TabIndex = 114;
		this.宠物召唤_变异开关.Text = "变异召唤开关";
		this.宠物召唤_变异开关.UseVisualStyleBackColor = true;
		this.宠物召唤_变异材料.Location = new System.Drawing.Point(93, 164);
		this.宠物召唤_变异材料.Name = "宠物召唤_变异材料";
		this.宠物召唤_变异材料.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_变异材料.TabIndex = 121;
		this.宠物召唤_变异最低.Location = new System.Drawing.Point(93, 222);
		this.宠物召唤_变异最低.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.宠物召唤_变异最低.Name = "宠物召唤_变异最低";
		this.宠物召唤_变异最低.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_变异最低.TabIndex = 120;
		this.地狱道_名字.Location = new System.Drawing.Point(12, 164);
		this.地狱道_名字.Name = "地狱道_名字";
		this.地狱道_名字.ReadOnly = true;
		this.地狱道_名字.Size = new System.Drawing.Size(80, 23);
		this.地狱道_名字.TabIndex = 119;
		this.地狱道_名字.Text = "变异召唤材料";
		this.地狱道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_变异奖励.Location = new System.Drawing.Point(93, 193);
		this.宠物召唤_变异奖励.Name = "宠物召唤_变异奖励";
		this.宠物召唤_变异奖励.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_变异奖励.TabIndex = 123;
		this.textBox2.Location = new System.Drawing.Point(12, 193);
		this.textBox2.Name = "textBox2";
		this.textBox2.ReadOnly = true;
		this.textBox2.Size = new System.Drawing.Size(80, 23);
		this.textBox2.TabIndex = 122;
		this.textBox2.Text = "变异召唤奖励";
		this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox3.Location = new System.Drawing.Point(12, 222);
		this.textBox3.Name = "textBox3";
		this.textBox3.ReadOnly = true;
		this.textBox3.Size = new System.Drawing.Size(80, 23);
		this.textBox3.TabIndex = 124;
		this.textBox3.Text = "最低提交数量";
		this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox4.Location = new System.Drawing.Point(12, 251);
		this.textBox4.Name = "textBox4";
		this.textBox4.ReadOnly = true;
		this.textBox4.Size = new System.Drawing.Size(80, 23);
		this.textBox4.TabIndex = 128;
		this.textBox4.Text = "最高提交数量";
		this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_变异最高.Location = new System.Drawing.Point(93, 251);
		this.宠物召唤_变异最高.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.宠物召唤_变异最高.Name = "宠物召唤_变异最高";
		this.宠物召唤_变异最高.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_变异最高.TabIndex = 127;
		this.宠物召唤_变异对话.Location = new System.Drawing.Point(93, 280);
		this.宠物召唤_变异对话.Name = "宠物召唤_变异对话";
		this.宠物召唤_变异对话.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_变异对话.TabIndex = 130;
		this.textBox6.Location = new System.Drawing.Point(12, 280);
		this.textBox6.Name = "textBox6";
		this.textBox6.ReadOnly = true;
		this.textBox6.Size = new System.Drawing.Size(80, 23);
		this.textBox6.TabIndex = 129;
		this.textBox6.Text = "点击对话选项";
		this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_神兽对话.Location = new System.Drawing.Point(296, 280);
		this.宠物召唤_神兽对话.Name = "宠物召唤_神兽对话";
		this.宠物召唤_神兽对话.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_神兽对话.TabIndex = 141;
		this.textBox8.Location = new System.Drawing.Point(215, 280);
		this.textBox8.Name = "textBox8";
		this.textBox8.ReadOnly = true;
		this.textBox8.Size = new System.Drawing.Size(80, 23);
		this.textBox8.TabIndex = 140;
		this.textBox8.Text = "点击对话选项";
		this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox9.Location = new System.Drawing.Point(215, 251);
		this.textBox9.Name = "textBox9";
		this.textBox9.ReadOnly = true;
		this.textBox9.Size = new System.Drawing.Size(80, 23);
		this.textBox9.TabIndex = 139;
		this.textBox9.Text = "最高提交数量";
		this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_神兽最高.Location = new System.Drawing.Point(296, 251);
		this.宠物召唤_神兽最高.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.宠物召唤_神兽最高.Name = "宠物召唤_神兽最高";
		this.宠物召唤_神兽最高.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_神兽最高.TabIndex = 138;
		this.textBox10.Location = new System.Drawing.Point(215, 222);
		this.textBox10.Name = "textBox10";
		this.textBox10.ReadOnly = true;
		this.textBox10.Size = new System.Drawing.Size(80, 23);
		this.textBox10.TabIndex = 137;
		this.textBox10.Text = "最低提交数量";
		this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_神兽奖励.Location = new System.Drawing.Point(296, 193);
		this.宠物召唤_神兽奖励.Name = "宠物召唤_神兽奖励";
		this.宠物召唤_神兽奖励.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_神兽奖励.TabIndex = 136;
		this.textBox12.Location = new System.Drawing.Point(215, 193);
		this.textBox12.Name = "textBox12";
		this.textBox12.ReadOnly = true;
		this.textBox12.Size = new System.Drawing.Size(80, 23);
		this.textBox12.TabIndex = 135;
		this.textBox12.Text = "神兽召唤奖励";
		this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_神兽材料.Location = new System.Drawing.Point(296, 164);
		this.宠物召唤_神兽材料.Name = "宠物召唤_神兽材料";
		this.宠物召唤_神兽材料.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_神兽材料.TabIndex = 134;
		this.宠物召唤_神兽最低.Location = new System.Drawing.Point(296, 222);
		this.宠物召唤_神兽最低.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.宠物召唤_神兽最低.Name = "宠物召唤_神兽最低";
		this.宠物召唤_神兽最低.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_神兽最低.TabIndex = 133;
		this.textBox14.Location = new System.Drawing.Point(215, 164);
		this.textBox14.Name = "textBox14";
		this.textBox14.ReadOnly = true;
		this.textBox14.Size = new System.Drawing.Size(80, 23);
		this.textBox14.TabIndex = 132;
		this.textBox14.Text = "神兽召唤材料";
		this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_神兽开关.AutoSize = true;
		this.宠物召唤_神兽开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.宠物召唤_神兽开关.Location = new System.Drawing.Point(215, 135);
		this.宠物召唤_神兽开关.Name = "宠物召唤_神兽开关";
		this.宠物召唤_神兽开关.Size = new System.Drawing.Size(106, 23);
		this.宠物召唤_神兽开关.TabIndex = 131;
		this.宠物召唤_神兽开关.Text = "神兽召唤开关";
		this.宠物召唤_神兽开关.UseVisualStyleBackColor = true;
		this.宠物召唤_元灵对话.Location = new System.Drawing.Point(501, 280);
		this.宠物召唤_元灵对话.Name = "宠物召唤_元灵对话";
		this.宠物召唤_元灵对话.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_元灵对话.TabIndex = 152;
		this.textBox16.Location = new System.Drawing.Point(420, 280);
		this.textBox16.Name = "textBox16";
		this.textBox16.ReadOnly = true;
		this.textBox16.Size = new System.Drawing.Size(80, 23);
		this.textBox16.TabIndex = 151;
		this.textBox16.Text = "点击对话选项";
		this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox17.Location = new System.Drawing.Point(420, 251);
		this.textBox17.Name = "textBox17";
		this.textBox17.ReadOnly = true;
		this.textBox17.Size = new System.Drawing.Size(80, 23);
		this.textBox17.TabIndex = 150;
		this.textBox17.Text = "最高提交数量";
		this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_元灵最高.Location = new System.Drawing.Point(501, 251);
		this.宠物召唤_元灵最高.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.宠物召唤_元灵最高.Name = "宠物召唤_元灵最高";
		this.宠物召唤_元灵最高.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_元灵最高.TabIndex = 149;
		this.textBox18.Location = new System.Drawing.Point(420, 222);
		this.textBox18.Name = "textBox18";
		this.textBox18.ReadOnly = true;
		this.textBox18.Size = new System.Drawing.Size(80, 23);
		this.textBox18.TabIndex = 148;
		this.textBox18.Text = "最低提交数量";
		this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_元灵奖励.Location = new System.Drawing.Point(501, 193);
		this.宠物召唤_元灵奖励.Name = "宠物召唤_元灵奖励";
		this.宠物召唤_元灵奖励.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_元灵奖励.TabIndex = 147;
		this.textBox20.Location = new System.Drawing.Point(420, 193);
		this.textBox20.Name = "textBox20";
		this.textBox20.ReadOnly = true;
		this.textBox20.Size = new System.Drawing.Size(80, 23);
		this.textBox20.TabIndex = 146;
		this.textBox20.Text = "元灵召唤奖励";
		this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_元灵材料.Location = new System.Drawing.Point(501, 164);
		this.宠物召唤_元灵材料.Name = "宠物召唤_元灵材料";
		this.宠物召唤_元灵材料.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_元灵材料.TabIndex = 145;
		this.宠物召唤_元灵最低.Location = new System.Drawing.Point(501, 222);
		this.宠物召唤_元灵最低.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.宠物召唤_元灵最低.Name = "宠物召唤_元灵最低";
		this.宠物召唤_元灵最低.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_元灵最低.TabIndex = 144;
		this.textBox22.Location = new System.Drawing.Point(420, 164);
		this.textBox22.Name = "textBox22";
		this.textBox22.ReadOnly = true;
		this.textBox22.Size = new System.Drawing.Size(80, 23);
		this.textBox22.TabIndex = 143;
		this.textBox22.Text = "元灵召唤材料";
		this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_元灵开关.AutoSize = true;
		this.宠物召唤_元灵开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.宠物召唤_元灵开关.Location = new System.Drawing.Point(420, 135);
		this.宠物召唤_元灵开关.Name = "宠物召唤_元灵开关";
		this.宠物召唤_元灵开关.Size = new System.Drawing.Size(106, 23);
		this.宠物召唤_元灵开关.TabIndex = 142;
		this.宠物召唤_元灵开关.Text = "元灵召唤开关";
		this.宠物召唤_元灵开关.UseVisualStyleBackColor = true;
		this.宠物召唤_仙元对话.Location = new System.Drawing.Point(704, 280);
		this.宠物召唤_仙元对话.Name = "宠物召唤_仙元对话";
		this.宠物召唤_仙元对话.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_仙元对话.TabIndex = 163;
		this.textBox24.Location = new System.Drawing.Point(623, 280);
		this.textBox24.Name = "textBox24";
		this.textBox24.ReadOnly = true;
		this.textBox24.Size = new System.Drawing.Size(80, 23);
		this.textBox24.TabIndex = 162;
		this.textBox24.Text = "点击对话选项";
		this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox25.Location = new System.Drawing.Point(623, 251);
		this.textBox25.Name = "textBox25";
		this.textBox25.ReadOnly = true;
		this.textBox25.Size = new System.Drawing.Size(80, 23);
		this.textBox25.TabIndex = 161;
		this.textBox25.Text = "最高提交数量";
		this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_仙元最高.Location = new System.Drawing.Point(704, 251);
		this.宠物召唤_仙元最高.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.宠物召唤_仙元最高.Name = "宠物召唤_仙元最高";
		this.宠物召唤_仙元最高.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_仙元最高.TabIndex = 160;
		this.textBox26.Location = new System.Drawing.Point(623, 222);
		this.textBox26.Name = "textBox26";
		this.textBox26.ReadOnly = true;
		this.textBox26.Size = new System.Drawing.Size(80, 23);
		this.textBox26.TabIndex = 159;
		this.textBox26.Text = "最低提交数量";
		this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_仙元奖励.Location = new System.Drawing.Point(704, 193);
		this.宠物召唤_仙元奖励.Name = "宠物召唤_仙元奖励";
		this.宠物召唤_仙元奖励.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_仙元奖励.TabIndex = 158;
		this.textBox28.Location = new System.Drawing.Point(623, 193);
		this.textBox28.Name = "textBox28";
		this.textBox28.ReadOnly = true;
		this.textBox28.Size = new System.Drawing.Size(80, 23);
		this.textBox28.TabIndex = 157;
		this.textBox28.Text = "仙元召唤奖励";
		this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_仙元材料.Location = new System.Drawing.Point(704, 164);
		this.宠物召唤_仙元材料.Name = "宠物召唤_仙元材料";
		this.宠物召唤_仙元材料.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_仙元材料.TabIndex = 156;
		this.宠物召唤_仙元最低.Location = new System.Drawing.Point(704, 222);
		this.宠物召唤_仙元最低.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.宠物召唤_仙元最低.Name = "宠物召唤_仙元最低";
		this.宠物召唤_仙元最低.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_仙元最低.TabIndex = 155;
		this.textBox30.Location = new System.Drawing.Point(623, 164);
		this.textBox30.Name = "textBox30";
		this.textBox30.ReadOnly = true;
		this.textBox30.Size = new System.Drawing.Size(80, 23);
		this.textBox30.TabIndex = 154;
		this.textBox30.Text = "仙元召唤材料";
		this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_仙元开关.AutoSize = true;
		this.宠物召唤_仙元开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.宠物召唤_仙元开关.Location = new System.Drawing.Point(623, 135);
		this.宠物召唤_仙元开关.Name = "宠物召唤_仙元开关";
		this.宠物召唤_仙元开关.Size = new System.Drawing.Size(106, 23);
		this.宠物召唤_仙元开关.TabIndex = 153;
		this.宠物召唤_仙元开关.Text = "仙元召唤开关";
		this.宠物召唤_仙元开关.UseVisualStyleBackColor = true;
		this.宠物召唤_御灵对话.Location = new System.Drawing.Point(909, 280);
		this.宠物召唤_御灵对话.Name = "宠物召唤_御灵对话";
		this.宠物召唤_御灵对话.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_御灵对话.TabIndex = 174;
		this.textBox32.Location = new System.Drawing.Point(828, 280);
		this.textBox32.Name = "textBox32";
		this.textBox32.ReadOnly = true;
		this.textBox32.Size = new System.Drawing.Size(80, 23);
		this.textBox32.TabIndex = 173;
		this.textBox32.Text = "点击对话选项";
		this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox33.Location = new System.Drawing.Point(828, 251);
		this.textBox33.Name = "textBox33";
		this.textBox33.ReadOnly = true;
		this.textBox33.Size = new System.Drawing.Size(80, 23);
		this.textBox33.TabIndex = 172;
		this.textBox33.Text = "最高提交数量";
		this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_御灵最高.Location = new System.Drawing.Point(909, 251);
		this.宠物召唤_御灵最高.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.宠物召唤_御灵最高.Name = "宠物召唤_御灵最高";
		this.宠物召唤_御灵最高.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_御灵最高.TabIndex = 171;
		this.textBox34.Location = new System.Drawing.Point(828, 222);
		this.textBox34.Name = "textBox34";
		this.textBox34.ReadOnly = true;
		this.textBox34.Size = new System.Drawing.Size(80, 23);
		this.textBox34.TabIndex = 170;
		this.textBox34.Text = "最低提交数量";
		this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_御灵奖励.Location = new System.Drawing.Point(909, 193);
		this.宠物召唤_御灵奖励.Name = "宠物召唤_御灵奖励";
		this.宠物召唤_御灵奖励.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_御灵奖励.TabIndex = 169;
		this.textBox36.Location = new System.Drawing.Point(828, 193);
		this.textBox36.Name = "textBox36";
		this.textBox36.ReadOnly = true;
		this.textBox36.Size = new System.Drawing.Size(80, 23);
		this.textBox36.TabIndex = 168;
		this.textBox36.Text = "御灵召唤奖励";
		this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_御灵材料.Location = new System.Drawing.Point(909, 164);
		this.宠物召唤_御灵材料.Name = "宠物召唤_御灵材料";
		this.宠物召唤_御灵材料.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_御灵材料.TabIndex = 167;
		this.宠物召唤_御灵最低.Location = new System.Drawing.Point(909, 222);
		this.宠物召唤_御灵最低.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.宠物召唤_御灵最低.Name = "宠物召唤_御灵最低";
		this.宠物召唤_御灵最低.Size = new System.Drawing.Size(100, 23);
		this.宠物召唤_御灵最低.TabIndex = 166;
		this.textBox38.Location = new System.Drawing.Point(828, 164);
		this.textBox38.Name = "textBox38";
		this.textBox38.ReadOnly = true;
		this.textBox38.Size = new System.Drawing.Size(80, 23);
		this.textBox38.TabIndex = 165;
		this.textBox38.Text = "御灵召唤材料";
		this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.宠物召唤_御灵开关.AutoSize = true;
		this.宠物召唤_御灵开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.宠物召唤_御灵开关.Location = new System.Drawing.Point(828, 135);
		this.宠物召唤_御灵开关.Name = "宠物召唤_御灵开关";
		this.宠物召唤_御灵开关.Size = new System.Drawing.Size(106, 23);
		this.宠物召唤_御灵开关.TabIndex = 164;
		this.宠物召唤_御灵开关.Text = "御灵召唤开关";
		this.宠物召唤_御灵开关.UseVisualStyleBackColor = true;
		this.label17.ForeColor = System.Drawing.Color.Red;
		this.label17.Location = new System.Drawing.Point(352, 9);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(657, 26);
		this.label17.TabIndex = 175;
		this.label17.Text = "该消耗道具必须写成材料，具体写法可参照后台首页中的材料礼包例子";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label1.Location = new System.Drawing.Point(6, 48);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 23);
		this.label1.TabIndex = 113;
		this.label1.Text = "npc对话";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.宠物召唤_npc对话.Location = new System.Drawing.Point(67, 48);
		this.宠物召唤_npc对话.Name = "宠物召唤_npc对话";
		this.宠物召唤_npc对话.Size = new System.Drawing.Size(924, 23);
		this.宠物召唤_npc对话.TabIndex = 114;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(1023, 310);
		base.Controls.Add(this.label17);
		base.Controls.Add(this.宠物召唤_御灵对话);
		base.Controls.Add(this.textBox32);
		base.Controls.Add(this.textBox33);
		base.Controls.Add(this.宠物召唤_御灵最高);
		base.Controls.Add(this.textBox34);
		base.Controls.Add(this.宠物召唤_御灵奖励);
		base.Controls.Add(this.textBox36);
		base.Controls.Add(this.宠物召唤_御灵材料);
		base.Controls.Add(this.宠物召唤_御灵最低);
		base.Controls.Add(this.textBox38);
		base.Controls.Add(this.宠物召唤_御灵开关);
		base.Controls.Add(this.宠物召唤_仙元对话);
		base.Controls.Add(this.textBox24);
		base.Controls.Add(this.textBox25);
		base.Controls.Add(this.宠物召唤_仙元最高);
		base.Controls.Add(this.textBox26);
		base.Controls.Add(this.宠物召唤_仙元奖励);
		base.Controls.Add(this.textBox28);
		base.Controls.Add(this.宠物召唤_仙元材料);
		base.Controls.Add(this.宠物召唤_仙元最低);
		base.Controls.Add(this.textBox30);
		base.Controls.Add(this.宠物召唤_仙元开关);
		base.Controls.Add(this.宠物召唤_元灵对话);
		base.Controls.Add(this.textBox16);
		base.Controls.Add(this.textBox17);
		base.Controls.Add(this.宠物召唤_元灵最高);
		base.Controls.Add(this.textBox18);
		base.Controls.Add(this.宠物召唤_元灵奖励);
		base.Controls.Add(this.textBox20);
		base.Controls.Add(this.宠物召唤_元灵材料);
		base.Controls.Add(this.宠物召唤_元灵最低);
		base.Controls.Add(this.textBox22);
		base.Controls.Add(this.宠物召唤_元灵开关);
		base.Controls.Add(this.宠物召唤_神兽对话);
		base.Controls.Add(this.textBox8);
		base.Controls.Add(this.textBox9);
		base.Controls.Add(this.宠物召唤_神兽最高);
		base.Controls.Add(this.textBox10);
		base.Controls.Add(this.宠物召唤_神兽奖励);
		base.Controls.Add(this.textBox12);
		base.Controls.Add(this.宠物召唤_神兽材料);
		base.Controls.Add(this.宠物召唤_神兽最低);
		base.Controls.Add(this.textBox14);
		base.Controls.Add(this.宠物召唤_神兽开关);
		base.Controls.Add(this.宠物召唤_变异对话);
		base.Controls.Add(this.textBox6);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.宠物召唤_变异最高);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.宠物召唤_变异奖励);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.宠物召唤_变异材料);
		base.Controls.Add(this.宠物召唤_变异最低);
		base.Controls.Add(this.地狱道_名字);
		base.Controls.Add(this.宠物召唤_变异开关);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.宠物召唤_开关);
		base.Controls.Add(this.宠物召唤_重载按钮);
		base.Controls.Add(this.宠物召唤_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "宠物召唤配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "宠物召唤配置窗口";
		base.Load += new System.EventHandler(宠物召唤配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_形象).EndInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_坐标Y).EndInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_坐标X).EndInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_变异最低).EndInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_变异最高).EndInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_神兽最高).EndInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_神兽最低).EndInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_元灵最高).EndInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_元灵最低).EndInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_仙元最高).EndInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_仙元最低).EndInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_御灵最高).EndInit();
		((System.ComponentModel.ISupportInitialize)this.宠物召唤_御灵最低).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
