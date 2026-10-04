using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 推荐拉人配置窗口 : Form
{
	private static 推荐拉人配置窗口 i;

	private IContainer components;

	private CheckBox 推荐_开关;

	private Button 推荐_重载按钮;

	private Button 推荐_保存按钮;

	private CheckBox 推荐_禁止相同IP推荐;

	private CheckBox 推荐_禁止相同MAC推荐;

	private CheckBox 推荐_禁止相同QQ推荐;

	private CheckBox 推荐_禁止推荐自己;

	private GroupBox groupBox1;

	private TextBox 推荐_被推荐人奖励数值;

	private ComboBox 推荐_被推荐人奖励类型;

	private TextBox textBox5;

	private TextBox textBox2;

	private TextBox 推荐_推荐人奖励数值;

	private ComboBox 推荐_推荐人奖励类型;

	private TextBox textBox1;

	private NumericUpDown 推荐_被推荐人最低充值;

	private TextBox textBox3;

	private NumericUpDown 推荐_推荐人返利奖励数值;

	private ComboBox 推荐_推荐人返利奖励类型;

	private CheckBox 推荐_推荐人获得充值返利开关;

	private Label label5;

	private GroupBox groupBox2;

	private NumericUpDown 推荐_推荐100人奖励数值;

	private ComboBox 推荐_推荐100人奖励类型;

	private TextBox textBox10;

	private NumericUpDown 推荐_推荐80人奖励数值;

	private ComboBox 推荐_推荐80人奖励类型;

	private TextBox textBox11;

	private NumericUpDown 推荐_推荐60人奖励数值;

	private ComboBox 推荐_推荐60人奖励类型;

	private TextBox textBox12;

	private NumericUpDown 推荐_推荐40人奖励数值;

	private ComboBox 推荐_推荐40人奖励类型;

	private TextBox textBox9;

	private NumericUpDown 推荐_推荐20人奖励数值;

	private ComboBox 推荐_推荐20人奖励类型;

	private TextBox textBox8;

	private NumericUpDown 推荐_推荐10人奖励数值;

	private ComboBox 推荐_推荐10人奖励类型;

	private TextBox textBox7;

	private NumericUpDown 推荐_推荐5人奖励数值;

	private ComboBox 推荐_推荐5人奖励类型;

	private TextBox textBox6;

	private CheckBox 推荐_累计推荐奖励开关;

	public static 推荐拉人配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 推荐拉人配置窗口();
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

	public 推荐拉人配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 推荐拉人配置窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		推荐_重载按钮_Click(sender, e);
	}

	private void 推荐_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 11, JsonConvert.SerializeObject(Singleton<全局变量类>.I.推荐拉人配置, Formatting.Indented));
		}
	}

	private void 推荐_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 11);
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (base.IsHandleCreated && 配置类型 == 11)
		{
			Invoke((MethodInvoker)delegate
			{
				推荐_开关.Checked = Singleton<全局变量类>.I.推荐拉人配置.功能开关;
				推荐_禁止相同IP推荐.Checked = Singleton<全局变量类>.I.推荐拉人配置.is同IP推荐无效;
				推荐_禁止相同MAC推荐.Checked = Singleton<全局变量类>.I.推荐拉人配置.is同机器码推荐无效;
				推荐_禁止相同QQ推荐.Checked = Singleton<全局变量类>.I.推荐拉人配置.is同QQ推荐无效;
				推荐_禁止推荐自己.Checked = Singleton<全局变量类>.I.推荐拉人配置.is推荐自己无效;
				推荐_推荐人奖励类型.Text = Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励类型.ToString();
				推荐_推荐人奖励数值.Text = Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励;
				推荐_被推荐人奖励类型.Text = Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励类型.ToString();
				推荐_被推荐人奖励数值.Text = Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励;
				推荐_推荐人获得充值返利开关.Checked = Singleton<全局变量类>.I.推荐拉人配置.is获取被推荐人充值奖励;
				推荐_被推荐人最低充值.Value = Singleton<全局变量类>.I.推荐拉人配置.最低充值;
				推荐_推荐人返利奖励类型.Text = Singleton<全局变量类>.I.推荐拉人配置.充值奖励类型.ToString();
				推荐_推荐人返利奖励数值.Value = Singleton<全局变量类>.I.推荐拉人配置.充值奖励;
				推荐_累计推荐奖励开关.Checked = Singleton<全局变量类>.I.推荐拉人配置.is累计推荐奖励开关;
				推荐_推荐5人奖励类型.Text = Singleton<全局变量类>.I.推荐拉人配置.累计推荐5人奖励类型.ToString();
				推荐_推荐5人奖励数值.Value = Singleton<全局变量类>.I.推荐拉人配置.累计推荐5人奖励;
				推荐_推荐10人奖励类型.Text = Singleton<全局变量类>.I.推荐拉人配置.累计推荐10人奖励类型.ToString();
				推荐_推荐10人奖励数值.Value = Singleton<全局变量类>.I.推荐拉人配置.累计推荐10人奖励;
				推荐_推荐20人奖励类型.Text = Singleton<全局变量类>.I.推荐拉人配置.累计推荐20人奖励类型.ToString();
				推荐_推荐20人奖励数值.Value = Singleton<全局变量类>.I.推荐拉人配置.累计推荐20人奖励;
				推荐_推荐40人奖励类型.Text = Singleton<全局变量类>.I.推荐拉人配置.累计推荐40人奖励类型.ToString();
				推荐_推荐40人奖励数值.Value = Singleton<全局变量类>.I.推荐拉人配置.累计推荐40人奖励;
				推荐_推荐60人奖励类型.Text = Singleton<全局变量类>.I.推荐拉人配置.累计推荐60人奖励类型.ToString();
				推荐_推荐60人奖励数值.Value = Singleton<全局变量类>.I.推荐拉人配置.累计推荐60人奖励;
				推荐_推荐80人奖励类型.Text = Singleton<全局变量类>.I.推荐拉人配置.累计推荐80人奖励类型.ToString();
				推荐_推荐80人奖励数值.Value = Singleton<全局变量类>.I.推荐拉人配置.累计推荐80人奖励;
				推荐_推荐100人奖励类型.Text = Singleton<全局变量类>.I.推荐拉人配置.累计推荐100人奖励类型.ToString();
				推荐_推荐100人奖励数值.Value = Singleton<全局变量类>.I.推荐拉人配置.累计推荐100人奖励;
			});
		}
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.推荐拉人配置.功能开关 = 推荐_开关.Checked;
			Singleton<全局变量类>.I.推荐拉人配置.is同IP推荐无效 = 推荐_禁止相同IP推荐.Checked;
			Singleton<全局变量类>.I.推荐拉人配置.is同机器码推荐无效 = 推荐_禁止相同MAC推荐.Checked;
			Singleton<全局变量类>.I.推荐拉人配置.is同QQ推荐无效 = 推荐_禁止相同QQ推荐.Checked;
			Singleton<全局变量类>.I.推荐拉人配置.is推荐自己无效 = 推荐_禁止推荐自己.Checked;
			Enum.TryParse<AllEnums.数值Type>(推荐_推荐人奖励类型.Text, out Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励类型);
			Singleton<全局变量类>.I.推荐拉人配置.推荐人奖励 = 推荐_推荐人奖励数值.Text;
			Enum.TryParse<AllEnums.数值Type>(推荐_被推荐人奖励类型.Text, out Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励类型);
			Singleton<全局变量类>.I.推荐拉人配置.被推荐人填写奖励 = 推荐_被推荐人奖励数值.Text;
			Singleton<全局变量类>.I.推荐拉人配置.is获取被推荐人充值奖励 = 推荐_推荐人获得充值返利开关.Checked;
			Singleton<全局变量类>.I.推荐拉人配置.最低充值 = (int)推荐_被推荐人最低充值.Value;
			Enum.TryParse<AllEnums.数值Type>(推荐_推荐人返利奖励类型.Text, out Singleton<全局变量类>.I.推荐拉人配置.充值奖励类型);
			Singleton<全局变量类>.I.推荐拉人配置.充值奖励 = (int)推荐_推荐人返利奖励数值.Value;
			Singleton<全局变量类>.I.推荐拉人配置.is累计推荐奖励开关 = 推荐_累计推荐奖励开关.Checked;
			Enum.TryParse<AllEnums.数值Type>(推荐_推荐5人奖励类型.Text, out Singleton<全局变量类>.I.推荐拉人配置.累计推荐5人奖励类型);
			Singleton<全局变量类>.I.推荐拉人配置.累计推荐5人奖励 = (int)推荐_推荐5人奖励数值.Value;
			Enum.TryParse<AllEnums.数值Type>(推荐_推荐10人奖励类型.Text, out Singleton<全局变量类>.I.推荐拉人配置.累计推荐10人奖励类型);
			Singleton<全局变量类>.I.推荐拉人配置.累计推荐10人奖励 = (int)推荐_推荐10人奖励数值.Value;
			Enum.TryParse<AllEnums.数值Type>(推荐_推荐20人奖励类型.Text, out Singleton<全局变量类>.I.推荐拉人配置.累计推荐20人奖励类型);
			Singleton<全局变量类>.I.推荐拉人配置.累计推荐20人奖励 = (int)推荐_推荐20人奖励数值.Value;
			Enum.TryParse<AllEnums.数值Type>(推荐_推荐40人奖励类型.Text, out Singleton<全局变量类>.I.推荐拉人配置.累计推荐40人奖励类型);
			Singleton<全局变量类>.I.推荐拉人配置.累计推荐40人奖励 = (int)推荐_推荐40人奖励数值.Value;
			Enum.TryParse<AllEnums.数值Type>(推荐_推荐60人奖励类型.Text, out Singleton<全局变量类>.I.推荐拉人配置.累计推荐60人奖励类型);
			Singleton<全局变量类>.I.推荐拉人配置.累计推荐60人奖励 = (int)推荐_推荐60人奖励数值.Value;
			Enum.TryParse<AllEnums.数值Type>(推荐_推荐80人奖励类型.Text, out Singleton<全局变量类>.I.推荐拉人配置.累计推荐80人奖励类型);
			Singleton<全局变量类>.I.推荐拉人配置.累计推荐80人奖励 = (int)推荐_推荐80人奖励数值.Value;
			Enum.TryParse<AllEnums.数值Type>(推荐_推荐100人奖励类型.Text, out Singleton<全局变量类>.I.推荐拉人配置.累计推荐100人奖励类型);
			Singleton<全局变量类>.I.推荐拉人配置.累计推荐100人奖励 = (int)推荐_推荐100人奖励数值.Value;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.推荐拉人配置窗口));
		this.推荐_开关 = new System.Windows.Forms.CheckBox();
		this.推荐_重载按钮 = new System.Windows.Forms.Button();
		this.推荐_保存按钮 = new System.Windows.Forms.Button();
		this.推荐_禁止相同IP推荐 = new System.Windows.Forms.CheckBox();
		this.推荐_禁止相同MAC推荐 = new System.Windows.Forms.CheckBox();
		this.推荐_禁止相同QQ推荐 = new System.Windows.Forms.CheckBox();
		this.推荐_禁止推荐自己 = new System.Windows.Forms.CheckBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label5 = new System.Windows.Forms.Label();
		this.推荐_推荐人返利奖励数值 = new System.Windows.Forms.NumericUpDown();
		this.推荐_推荐人返利奖励类型 = new System.Windows.Forms.ComboBox();
		this.推荐_推荐人获得充值返利开关 = new System.Windows.Forms.CheckBox();
		this.推荐_被推荐人奖励数值 = new System.Windows.Forms.TextBox();
		this.推荐_被推荐人奖励类型 = new System.Windows.Forms.ComboBox();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.推荐_推荐人奖励数值 = new System.Windows.Forms.TextBox();
		this.推荐_推荐人奖励类型 = new System.Windows.Forms.ComboBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.推荐_被推荐人最低充值 = new System.Windows.Forms.NumericUpDown();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.推荐_推荐100人奖励数值 = new System.Windows.Forms.NumericUpDown();
		this.推荐_推荐100人奖励类型 = new System.Windows.Forms.ComboBox();
		this.textBox10 = new System.Windows.Forms.TextBox();
		this.推荐_推荐80人奖励数值 = new System.Windows.Forms.NumericUpDown();
		this.推荐_推荐80人奖励类型 = new System.Windows.Forms.ComboBox();
		this.textBox11 = new System.Windows.Forms.TextBox();
		this.推荐_推荐60人奖励数值 = new System.Windows.Forms.NumericUpDown();
		this.推荐_推荐60人奖励类型 = new System.Windows.Forms.ComboBox();
		this.textBox12 = new System.Windows.Forms.TextBox();
		this.推荐_推荐40人奖励数值 = new System.Windows.Forms.NumericUpDown();
		this.推荐_推荐40人奖励类型 = new System.Windows.Forms.ComboBox();
		this.textBox9 = new System.Windows.Forms.TextBox();
		this.推荐_推荐20人奖励数值 = new System.Windows.Forms.NumericUpDown();
		this.推荐_推荐20人奖励类型 = new System.Windows.Forms.ComboBox();
		this.textBox8 = new System.Windows.Forms.TextBox();
		this.推荐_推荐10人奖励数值 = new System.Windows.Forms.NumericUpDown();
		this.推荐_推荐10人奖励类型 = new System.Windows.Forms.ComboBox();
		this.textBox7 = new System.Windows.Forms.TextBox();
		this.推荐_推荐5人奖励数值 = new System.Windows.Forms.NumericUpDown();
		this.推荐_推荐5人奖励类型 = new System.Windows.Forms.ComboBox();
		this.textBox6 = new System.Windows.Forms.TextBox();
		this.推荐_累计推荐奖励开关 = new System.Windows.Forms.CheckBox();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐人返利奖励数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_被推荐人最低充值).BeginInit();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐100人奖励数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐80人奖励数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐60人奖励数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐40人奖励数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐20人奖励数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐10人奖励数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐5人奖励数值).BeginInit();
		base.SuspendLayout();
		this.推荐_开关.AutoSize = true;
		this.推荐_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.推荐_开关.Location = new System.Drawing.Point(12, 12);
		this.推荐_开关.Name = "推荐_开关";
		this.推荐_开关.Size = new System.Drawing.Size(132, 23);
		this.推荐_开关.TabIndex = 121;
		this.推荐_开关.Text = "推荐拉人活动开关";
		this.推荐_开关.UseVisualStyleBackColor = true;
		this.推荐_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.推荐_重载按钮.Location = new System.Drawing.Point(254, 8);
		this.推荐_重载按钮.Name = "推荐_重载按钮";
		this.推荐_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.推荐_重载按钮.TabIndex = 123;
		this.推荐_重载按钮.Text = "重载配置";
		this.推荐_重载按钮.UseVisualStyleBackColor = true;
		this.推荐_重载按钮.Click += new System.EventHandler(推荐_重载按钮_Click);
		this.推荐_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.推荐_保存按钮.Location = new System.Drawing.Point(148, 8);
		this.推荐_保存按钮.Name = "推荐_保存按钮";
		this.推荐_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.推荐_保存按钮.TabIndex = 122;
		this.推荐_保存按钮.Text = "保存配置";
		this.推荐_保存按钮.UseVisualStyleBackColor = true;
		this.推荐_保存按钮.Click += new System.EventHandler(推荐_保存按钮_Click);
		this.推荐_禁止相同IP推荐.AutoSize = true;
		this.推荐_禁止相同IP推荐.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.推荐_禁止相同IP推荐.Location = new System.Drawing.Point(12, 41);
		this.推荐_禁止相同IP推荐.Name = "推荐_禁止相同IP推荐";
		this.推荐_禁止相同IP推荐.Size = new System.Drawing.Size(119, 23);
		this.推荐_禁止相同IP推荐.TabIndex = 124;
		this.推荐_禁止相同IP推荐.Text = "禁止相同IP推荐";
		this.推荐_禁止相同IP推荐.UseVisualStyleBackColor = true;
		this.推荐_禁止相同MAC推荐.AutoSize = true;
		this.推荐_禁止相同MAC推荐.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.推荐_禁止相同MAC推荐.Location = new System.Drawing.Point(137, 41);
		this.推荐_禁止相同MAC推荐.Name = "推荐_禁止相同MAC推荐";
		this.推荐_禁止相同MAC推荐.Size = new System.Drawing.Size(138, 23);
		this.推荐_禁止相同MAC推荐.TabIndex = 125;
		this.推荐_禁止相同MAC推荐.Text = "禁止相同MAC推荐";
		this.推荐_禁止相同MAC推荐.UseVisualStyleBackColor = true;
		this.推荐_禁止相同QQ推荐.AutoSize = true;
		this.推荐_禁止相同QQ推荐.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.推荐_禁止相同QQ推荐.Location = new System.Drawing.Point(281, 41);
		this.推荐_禁止相同QQ推荐.Name = "推荐_禁止相同QQ推荐";
		this.推荐_禁止相同QQ推荐.Size = new System.Drawing.Size(128, 23);
		this.推荐_禁止相同QQ推荐.TabIndex = 126;
		this.推荐_禁止相同QQ推荐.Text = "禁止相同QQ推荐";
		this.推荐_禁止相同QQ推荐.UseVisualStyleBackColor = true;
		this.推荐_禁止推荐自己.AutoSize = true;
		this.推荐_禁止推荐自己.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.推荐_禁止推荐自己.Location = new System.Drawing.Point(415, 41);
		this.推荐_禁止推荐自己.Name = "推荐_禁止推荐自己";
		this.推荐_禁止推荐自己.Size = new System.Drawing.Size(106, 23);
		this.推荐_禁止推荐自己.TabIndex = 127;
		this.推荐_禁止推荐自己.Text = "禁止推荐自己";
		this.推荐_禁止推荐自己.UseVisualStyleBackColor = true;
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.推荐_推荐人返利奖励数值);
		this.groupBox1.Controls.Add(this.推荐_推荐人返利奖励类型);
		this.groupBox1.Controls.Add(this.推荐_推荐人获得充值返利开关);
		this.groupBox1.Controls.Add(this.推荐_被推荐人奖励数值);
		this.groupBox1.Controls.Add(this.推荐_被推荐人奖励类型);
		this.groupBox1.Controls.Add(this.textBox5);
		this.groupBox1.Controls.Add(this.textBox2);
		this.groupBox1.Controls.Add(this.推荐_推荐人奖励数值);
		this.groupBox1.Controls.Add(this.推荐_推荐人奖励类型);
		this.groupBox1.Controls.Add(this.textBox1);
		this.groupBox1.Controls.Add(this.推荐_被推荐人最低充值);
		this.groupBox1.Controls.Add(this.textBox3);
		this.groupBox1.Location = new System.Drawing.Point(12, 70);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(599, 166);
		this.groupBox1.TabIndex = 128;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "首次推荐奖励";
		this.label5.ForeColor = System.Drawing.Color.Red;
		this.label5.Location = new System.Drawing.Point(6, 112);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(570, 40);
		this.label5.TabIndex = 164;
		this.label5.Text = "每次充值是一次性充值金额，作为最低基数，例如：\r\n设置被推荐人充值100，推荐人奖励10点累充点，那么被推荐人充值200，推荐人奖励20点累充点";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.推荐_推荐人返利奖励数值.Location = new System.Drawing.Point(403, 86);
		this.推荐_推荐人返利奖励数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.推荐_推荐人返利奖励数值.Name = "推荐_推荐人返利奖励数值";
		this.推荐_推荐人返利奖励数值.Size = new System.Drawing.Size(100, 23);
		this.推荐_推荐人返利奖励数值.TabIndex = 163;
		this.推荐_推荐人返利奖励数值.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐人返利奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.推荐_推荐人返利奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.推荐_推荐人返利奖励类型.FormattingEnabled = true;
		this.推荐_推荐人返利奖励类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "累充点", "南极点" });
		this.推荐_推荐人返利奖励类型.Location = new System.Drawing.Point(302, 85);
		this.推荐_推荐人返利奖励类型.Name = "推荐_推荐人返利奖励类型";
		this.推荐_推荐人返利奖励类型.Size = new System.Drawing.Size(100, 25);
		this.推荐_推荐人返利奖励类型.TabIndex = 162;
		this.推荐_推荐人获得充值返利开关.AutoSize = true;
		this.推荐_推荐人获得充值返利开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.推荐_推荐人获得充值返利开关.Location = new System.Drawing.Point(6, 61);
		this.推荐_推荐人获得充值返利开关.Name = "推荐_推荐人获得充值返利开关";
		this.推荐_推荐人获得充值返利开关.Size = new System.Drawing.Size(210, 23);
		this.推荐_推荐人获得充值返利开关.TabIndex = 161;
		this.推荐_推荐人获得充值返利开关.Text = "推荐人可获得被推荐人充值返利";
		this.推荐_推荐人获得充值返利开关.UseVisualStyleBackColor = true;
		this.推荐_被推荐人奖励数值.Location = new System.Drawing.Point(476, 22);
		this.推荐_被推荐人奖励数值.Name = "推荐_被推荐人奖励数值";
		this.推荐_被推荐人奖励数值.Size = new System.Drawing.Size(100, 23);
		this.推荐_被推荐人奖励数值.TabIndex = 160;
		this.推荐_被推荐人奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.推荐_被推荐人奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.推荐_被推荐人奖励类型.FormattingEnabled = true;
		this.推荐_被推荐人奖励类型.Items.AddRange(new object[5] { "金元宝", "银元宝", "累充点", "南极点", "道具" });
		this.推荐_被推荐人奖励类型.Location = new System.Drawing.Point(375, 21);
		this.推荐_被推荐人奖励类型.Name = "推荐_被推荐人奖励类型";
		this.推荐_被推荐人奖励类型.Size = new System.Drawing.Size(100, 25);
		this.推荐_被推荐人奖励类型.TabIndex = 159;
		this.textBox5.Location = new System.Drawing.Point(294, 22);
		this.textBox5.Name = "textBox5";
		this.textBox5.ReadOnly = true;
		this.textBox5.Size = new System.Drawing.Size(80, 23);
		this.textBox5.TabIndex = 158;
		this.textBox5.Text = "被推荐人奖励";
		this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox2.Location = new System.Drawing.Point(162, 86);
		this.textBox2.Name = "textBox2";
		this.textBox2.ReadOnly = true;
		this.textBox2.Size = new System.Drawing.Size(139, 23);
		this.textBox2.TabIndex = 156;
		this.textBox2.Text = "元以上，推荐人获得返利";
		this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐人奖励数值.Location = new System.Drawing.Point(188, 22);
		this.推荐_推荐人奖励数值.Name = "推荐_推荐人奖励数值";
		this.推荐_推荐人奖励数值.Size = new System.Drawing.Size(100, 23);
		this.推荐_推荐人奖励数值.TabIndex = 157;
		this.推荐_推荐人奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.推荐_推荐人奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.推荐_推荐人奖励类型.FormattingEnabled = true;
		this.推荐_推荐人奖励类型.Items.AddRange(new object[5] { "金元宝", "银元宝", "累充点", "南极点", "道具" });
		this.推荐_推荐人奖励类型.Location = new System.Drawing.Point(87, 21);
		this.推荐_推荐人奖励类型.Name = "推荐_推荐人奖励类型";
		this.推荐_推荐人奖励类型.Size = new System.Drawing.Size(100, 25);
		this.推荐_推荐人奖励类型.TabIndex = 155;
		this.textBox1.Location = new System.Drawing.Point(6, 22);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(80, 23);
		this.textBox1.TabIndex = 152;
		this.textBox1.Text = "推荐人奖励";
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_被推荐人最低充值.Location = new System.Drawing.Point(101, 86);
		this.推荐_被推荐人最低充值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.推荐_被推荐人最低充值.Name = "推荐_被推荐人最低充值";
		this.推荐_被推荐人最低充值.Size = new System.Drawing.Size(60, 23);
		this.推荐_被推荐人最低充值.TabIndex = 153;
		this.推荐_被推荐人最低充值.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox3.Location = new System.Drawing.Point(6, 86);
		this.textBox3.Name = "textBox3";
		this.textBox3.ReadOnly = true;
		this.textBox3.Size = new System.Drawing.Size(94, 23);
		this.textBox3.TabIndex = 154;
		this.textBox3.Text = "被推荐人每充值";
		this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.groupBox2.Controls.Add(this.推荐_推荐100人奖励数值);
		this.groupBox2.Controls.Add(this.推荐_推荐100人奖励类型);
		this.groupBox2.Controls.Add(this.textBox10);
		this.groupBox2.Controls.Add(this.推荐_推荐80人奖励数值);
		this.groupBox2.Controls.Add(this.推荐_推荐80人奖励类型);
		this.groupBox2.Controls.Add(this.textBox11);
		this.groupBox2.Controls.Add(this.推荐_推荐60人奖励数值);
		this.groupBox2.Controls.Add(this.推荐_推荐60人奖励类型);
		this.groupBox2.Controls.Add(this.textBox12);
		this.groupBox2.Controls.Add(this.推荐_推荐40人奖励数值);
		this.groupBox2.Controls.Add(this.推荐_推荐40人奖励类型);
		this.groupBox2.Controls.Add(this.textBox9);
		this.groupBox2.Controls.Add(this.推荐_推荐20人奖励数值);
		this.groupBox2.Controls.Add(this.推荐_推荐20人奖励类型);
		this.groupBox2.Controls.Add(this.textBox8);
		this.groupBox2.Controls.Add(this.推荐_推荐10人奖励数值);
		this.groupBox2.Controls.Add(this.推荐_推荐10人奖励类型);
		this.groupBox2.Controls.Add(this.textBox7);
		this.groupBox2.Controls.Add(this.推荐_推荐5人奖励数值);
		this.groupBox2.Controls.Add(this.推荐_推荐5人奖励类型);
		this.groupBox2.Controls.Add(this.textBox6);
		this.groupBox2.Controls.Add(this.推荐_累计推荐奖励开关);
		this.groupBox2.Location = new System.Drawing.Point(12, 246);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(599, 267);
		this.groupBox2.TabIndex = 129;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "累计推荐奖励配置";
		this.推荐_推荐100人奖励数值.Location = new System.Drawing.Point(237, 226);
		this.推荐_推荐100人奖励数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.推荐_推荐100人奖励数值.Name = "推荐_推荐100人奖励数值";
		this.推荐_推荐100人奖励数值.Size = new System.Drawing.Size(100, 23);
		this.推荐_推荐100人奖励数值.TabIndex = 183;
		this.推荐_推荐100人奖励数值.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐100人奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.推荐_推荐100人奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.推荐_推荐100人奖励类型.FormattingEnabled = true;
		this.推荐_推荐100人奖励类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "累充点", "南极点" });
		this.推荐_推荐100人奖励类型.Location = new System.Drawing.Point(136, 225);
		this.推荐_推荐100人奖励类型.Name = "推荐_推荐100人奖励类型";
		this.推荐_推荐100人奖励类型.Size = new System.Drawing.Size(100, 25);
		this.推荐_推荐100人奖励类型.TabIndex = 182;
		this.textBox10.Location = new System.Drawing.Point(25, 226);
		this.textBox10.Name = "textBox10";
		this.textBox10.ReadOnly = true;
		this.textBox10.Size = new System.Drawing.Size(110, 23);
		this.textBox10.TabIndex = 181;
		this.textBox10.Text = "累计推荐100人奖励";
		this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐80人奖励数值.Location = new System.Drawing.Point(237, 197);
		this.推荐_推荐80人奖励数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.推荐_推荐80人奖励数值.Name = "推荐_推荐80人奖励数值";
		this.推荐_推荐80人奖励数值.Size = new System.Drawing.Size(100, 23);
		this.推荐_推荐80人奖励数值.TabIndex = 180;
		this.推荐_推荐80人奖励数值.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐80人奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.推荐_推荐80人奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.推荐_推荐80人奖励类型.FormattingEnabled = true;
		this.推荐_推荐80人奖励类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "累充点", "南极点" });
		this.推荐_推荐80人奖励类型.Location = new System.Drawing.Point(136, 196);
		this.推荐_推荐80人奖励类型.Name = "推荐_推荐80人奖励类型";
		this.推荐_推荐80人奖励类型.Size = new System.Drawing.Size(100, 25);
		this.推荐_推荐80人奖励类型.TabIndex = 179;
		this.textBox11.Location = new System.Drawing.Point(25, 197);
		this.textBox11.Name = "textBox11";
		this.textBox11.ReadOnly = true;
		this.textBox11.Size = new System.Drawing.Size(110, 23);
		this.textBox11.TabIndex = 178;
		this.textBox11.Text = "累计推荐 80人奖励";
		this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐60人奖励数值.Location = new System.Drawing.Point(237, 168);
		this.推荐_推荐60人奖励数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.推荐_推荐60人奖励数值.Name = "推荐_推荐60人奖励数值";
		this.推荐_推荐60人奖励数值.Size = new System.Drawing.Size(100, 23);
		this.推荐_推荐60人奖励数值.TabIndex = 177;
		this.推荐_推荐60人奖励数值.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐60人奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.推荐_推荐60人奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.推荐_推荐60人奖励类型.FormattingEnabled = true;
		this.推荐_推荐60人奖励类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "累充点", "南极点" });
		this.推荐_推荐60人奖励类型.Location = new System.Drawing.Point(136, 167);
		this.推荐_推荐60人奖励类型.Name = "推荐_推荐60人奖励类型";
		this.推荐_推荐60人奖励类型.Size = new System.Drawing.Size(100, 25);
		this.推荐_推荐60人奖励类型.TabIndex = 176;
		this.textBox12.Location = new System.Drawing.Point(25, 168);
		this.textBox12.Name = "textBox12";
		this.textBox12.ReadOnly = true;
		this.textBox12.Size = new System.Drawing.Size(110, 23);
		this.textBox12.TabIndex = 175;
		this.textBox12.Text = "累计推荐 60人奖励";
		this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐40人奖励数值.Location = new System.Drawing.Point(237, 139);
		this.推荐_推荐40人奖励数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.推荐_推荐40人奖励数值.Name = "推荐_推荐40人奖励数值";
		this.推荐_推荐40人奖励数值.Size = new System.Drawing.Size(100, 23);
		this.推荐_推荐40人奖励数值.TabIndex = 174;
		this.推荐_推荐40人奖励数值.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐40人奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.推荐_推荐40人奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.推荐_推荐40人奖励类型.FormattingEnabled = true;
		this.推荐_推荐40人奖励类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "累充点", "南极点" });
		this.推荐_推荐40人奖励类型.Location = new System.Drawing.Point(136, 138);
		this.推荐_推荐40人奖励类型.Name = "推荐_推荐40人奖励类型";
		this.推荐_推荐40人奖励类型.Size = new System.Drawing.Size(100, 25);
		this.推荐_推荐40人奖励类型.TabIndex = 173;
		this.textBox9.Location = new System.Drawing.Point(25, 139);
		this.textBox9.Name = "textBox9";
		this.textBox9.ReadOnly = true;
		this.textBox9.Size = new System.Drawing.Size(110, 23);
		this.textBox9.TabIndex = 172;
		this.textBox9.Text = "累计推荐 40人奖励";
		this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐20人奖励数值.Location = new System.Drawing.Point(237, 110);
		this.推荐_推荐20人奖励数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.推荐_推荐20人奖励数值.Name = "推荐_推荐20人奖励数值";
		this.推荐_推荐20人奖励数值.Size = new System.Drawing.Size(100, 23);
		this.推荐_推荐20人奖励数值.TabIndex = 171;
		this.推荐_推荐20人奖励数值.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐20人奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.推荐_推荐20人奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.推荐_推荐20人奖励类型.FormattingEnabled = true;
		this.推荐_推荐20人奖励类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "累充点", "南极点" });
		this.推荐_推荐20人奖励类型.Location = new System.Drawing.Point(136, 109);
		this.推荐_推荐20人奖励类型.Name = "推荐_推荐20人奖励类型";
		this.推荐_推荐20人奖励类型.Size = new System.Drawing.Size(100, 25);
		this.推荐_推荐20人奖励类型.TabIndex = 170;
		this.textBox8.Location = new System.Drawing.Point(25, 110);
		this.textBox8.Name = "textBox8";
		this.textBox8.ReadOnly = true;
		this.textBox8.Size = new System.Drawing.Size(110, 23);
		this.textBox8.TabIndex = 169;
		this.textBox8.Text = "累计推荐 20人奖励";
		this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐10人奖励数值.Location = new System.Drawing.Point(237, 81);
		this.推荐_推荐10人奖励数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.推荐_推荐10人奖励数值.Name = "推荐_推荐10人奖励数值";
		this.推荐_推荐10人奖励数值.Size = new System.Drawing.Size(100, 23);
		this.推荐_推荐10人奖励数值.TabIndex = 168;
		this.推荐_推荐10人奖励数值.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐10人奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.推荐_推荐10人奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.推荐_推荐10人奖励类型.FormattingEnabled = true;
		this.推荐_推荐10人奖励类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "累充点", "南极点" });
		this.推荐_推荐10人奖励类型.Location = new System.Drawing.Point(136, 80);
		this.推荐_推荐10人奖励类型.Name = "推荐_推荐10人奖励类型";
		this.推荐_推荐10人奖励类型.Size = new System.Drawing.Size(100, 25);
		this.推荐_推荐10人奖励类型.TabIndex = 167;
		this.textBox7.Location = new System.Drawing.Point(25, 81);
		this.textBox7.Name = "textBox7";
		this.textBox7.ReadOnly = true;
		this.textBox7.Size = new System.Drawing.Size(110, 23);
		this.textBox7.TabIndex = 166;
		this.textBox7.Text = "累计推荐 10人奖励";
		this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐5人奖励数值.Location = new System.Drawing.Point(237, 51);
		this.推荐_推荐5人奖励数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.推荐_推荐5人奖励数值.Name = "推荐_推荐5人奖励数值";
		this.推荐_推荐5人奖励数值.Size = new System.Drawing.Size(100, 23);
		this.推荐_推荐5人奖励数值.TabIndex = 165;
		this.推荐_推荐5人奖励数值.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_推荐5人奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.推荐_推荐5人奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.推荐_推荐5人奖励类型.FormattingEnabled = true;
		this.推荐_推荐5人奖励类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "累充点", "南极点" });
		this.推荐_推荐5人奖励类型.Location = new System.Drawing.Point(136, 50);
		this.推荐_推荐5人奖励类型.Name = "推荐_推荐5人奖励类型";
		this.推荐_推荐5人奖励类型.Size = new System.Drawing.Size(100, 25);
		this.推荐_推荐5人奖励类型.TabIndex = 164;
		this.textBox6.Location = new System.Drawing.Point(25, 51);
		this.textBox6.Name = "textBox6";
		this.textBox6.ReadOnly = true;
		this.textBox6.Size = new System.Drawing.Size(110, 23);
		this.textBox6.TabIndex = 163;
		this.textBox6.Text = "累计推荐  5人奖励";
		this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.推荐_累计推荐奖励开关.AutoSize = true;
		this.推荐_累计推荐奖励开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.推荐_累计推荐奖励开关.Location = new System.Drawing.Point(6, 22);
		this.推荐_累计推荐奖励开关.Name = "推荐_累计推荐奖励开关";
		this.推荐_累计推荐奖励开关.Size = new System.Drawing.Size(171, 23);
		this.推荐_累计推荐奖励开关.TabIndex = 162;
		this.推荐_累计推荐奖励开关.Text = "开启推荐人累计推荐奖励";
		this.推荐_累计推荐奖励开关.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(620, 525);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.推荐_禁止推荐自己);
		base.Controls.Add(this.推荐_禁止相同QQ推荐);
		base.Controls.Add(this.推荐_禁止相同MAC推荐);
		base.Controls.Add(this.推荐_禁止相同IP推荐);
		base.Controls.Add(this.推荐_开关);
		base.Controls.Add(this.推荐_重载按钮);
		base.Controls.Add(this.推荐_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "推荐拉人配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "推荐拉人配置窗口";
		base.Load += new System.EventHandler(推荐拉人配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐人返利奖励数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_被推荐人最低充值).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐100人奖励数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐80人奖励数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐60人奖励数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐40人奖励数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐20人奖励数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐10人奖励数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.推荐_推荐5人奖励数值).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
