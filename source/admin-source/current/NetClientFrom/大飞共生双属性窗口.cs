using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 大飞共生双属性窗口 : Form
{
	private static 大飞共生双属性窗口 i;

	private IContainer components;

	private GroupBox groupBox1;

	private Button 大飞_重载按钮;

	private Button 大飞_保存按钮;

	private CheckBox 大飞_开关;

	private Label label3;

	private NumericUpDown 大飞_飞升等级;

	private Label label1;

	private NumericUpDown 大飞_最低等级;

	private Label label14;

	private Label label2;

	private NumericUpDown 大飞_消耗价格;

	private Label label6;

	private TextBox 大飞_npc名字;

	private ComboBox 大飞_消耗类型;

	private GroupBox groupBox2;

	private Label label7;

	private Label label8;

	private NumericUpDown 共生_消耗价格;

	private Label label9;

	private TextBox 共生_npc名字;

	private ComboBox 共生_消耗类型;

	private Button 共生_重载按钮;

	private Button 共生_保存按钮;

	private CheckBox 共生_开关;

	private GroupBox groupBox3;

	private Label label4;

	private Label label5;

	private NumericUpDown 双属性_消耗价格;

	private Label label10;

	private TextBox 双属性_npc名字;

	private ComboBox 双属性_消耗类型;

	private CheckBox 双属性_开关;

	private Label label11;

	private NumericUpDown 双属性_最高等级;

	private Label label12;

	private NumericUpDown 双属性_最低等级;

	private CheckBox 大飞_技能精研;

	public static 大飞共生双属性窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 大飞共生双属性窗口();
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

	public 大飞共生双属性窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 大飞共生双属性窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		大飞_重载按钮_Click(sender, e);
		共生_重载按钮_Click(sender, e);
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			if (配置类型 == 27)
			{
				大飞_开关.Checked = Singleton<全局变量类>.I.一键大飞配置.功能开关;
				大飞_技能精研.Checked = Singleton<全局变量类>.I.一键大飞配置.大飞后技能是否精研;
				大飞_npc名字.Text = Singleton<全局变量类>.I.一键大飞配置.npc名字;
				大飞_消耗类型.Text = Singleton<全局变量类>.I.一键大飞配置.消耗数值类型.ToString();
				大飞_消耗价格.Value = Singleton<全局变量类>.I.一键大飞配置.消耗数值;
				大飞_最低等级.Value = Singleton<全局变量类>.I.一键大飞配置.飞升要求最低等级;
				大飞_飞升等级.Value = Singleton<全局变量类>.I.一键大飞配置.飞升到等级;
			}
			else if (配置类型 == 28)
			{
				共生_开关.Checked = Singleton<全局变量类>.I.法宝共生配置.功能开关;
				共生_npc名字.Text = Singleton<全局变量类>.I.法宝共生配置.npc名字;
				共生_消耗类型.Text = Singleton<全局变量类>.I.法宝共生配置.消耗数值类型.ToString();
				共生_消耗价格.Value = Singleton<全局变量类>.I.法宝共生配置.消耗数值;
				双属性_开关.Checked = Singleton<全局变量类>.I.法宝共生配置.元神合体开关;
				双属性_npc名字.Text = Singleton<全局变量类>.I.法宝共生配置.元神合体npc名字;
				双属性_消耗类型.Text = Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值类型.ToString();
				双属性_消耗价格.Value = Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值;
				双属性_最低等级.Value = Singleton<全局变量类>.I.法宝共生配置.最低等级;
				双属性_最高等级.Value = Singleton<全局变量类>.I.法宝共生配置.最高等级;
			}
		});
	}

	private void 大飞_配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.一键大飞配置.功能开关 = 大飞_开关.Checked;
			Singleton<全局变量类>.I.一键大飞配置.大飞后技能是否精研 = 大飞_技能精研.Checked;
			Singleton<全局变量类>.I.一键大飞配置.npc名字 = 大飞_npc名字.Text;
			Enum.TryParse<AllEnums.数值Type>(大飞_消耗类型.Text, out Singleton<全局变量类>.I.一键大飞配置.消耗数值类型);
			Singleton<全局变量类>.I.一键大飞配置.消耗数值 = (int)大飞_消耗价格.Value;
			Singleton<全局变量类>.I.一键大飞配置.飞升要求最低等级 = (int)大飞_最低等级.Value;
			Singleton<全局变量类>.I.一键大飞配置.飞升到等级 = (int)大飞_飞升等级.Value;
		}
	}

	private void 共生_配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.法宝共生配置.功能开关 = 共生_开关.Checked;
			Singleton<全局变量类>.I.法宝共生配置.npc名字 = 共生_npc名字.Text;
			Enum.TryParse<AllEnums.数值Type>(共生_消耗类型.Text, out Singleton<全局变量类>.I.法宝共生配置.消耗数值类型);
			Singleton<全局变量类>.I.法宝共生配置.消耗数值 = (int)共生_消耗价格.Value;
			Singleton<全局变量类>.I.法宝共生配置.元神合体开关 = 双属性_开关.Checked;
			Singleton<全局变量类>.I.法宝共生配置.元神合体npc名字 = 双属性_npc名字.Text;
			Enum.TryParse<AllEnums.数值Type>(双属性_消耗类型.Text, out Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值类型);
			Singleton<全局变量类>.I.法宝共生配置.元神合体消耗数值 = (int)双属性_消耗价格.Value;
			Singleton<全局变量类>.I.法宝共生配置.最低等级 = (int)双属性_最低等级.Value;
			Singleton<全局变量类>.I.法宝共生配置.最高等级 = (int)双属性_最高等级.Value;
		}
	}

	private void 大飞_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			大飞_配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 27, JsonConvert.SerializeObject(Singleton<全局变量类>.I.一键大飞配置, Formatting.Indented));
		}
	}

	private void 大飞_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 27);
		}
	}

	private void 共生_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			共生_配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 28, JsonConvert.SerializeObject(Singleton<全局变量类>.I.法宝共生配置, Formatting.Indented));
		}
	}

	private void 共生_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 28);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.大飞共生双属性窗口));
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label3 = new System.Windows.Forms.Label();
		this.大飞_飞升等级 = new System.Windows.Forms.NumericUpDown();
		this.label1 = new System.Windows.Forms.Label();
		this.大飞_最低等级 = new System.Windows.Forms.NumericUpDown();
		this.label14 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.大飞_消耗价格 = new System.Windows.Forms.NumericUpDown();
		this.label6 = new System.Windows.Forms.Label();
		this.大飞_npc名字 = new System.Windows.Forms.TextBox();
		this.大飞_消耗类型 = new System.Windows.Forms.ComboBox();
		this.大飞_重载按钮 = new System.Windows.Forms.Button();
		this.大飞_保存按钮 = new System.Windows.Forms.Button();
		this.大飞_开关 = new System.Windows.Forms.CheckBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.共生_消耗价格 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.共生_npc名字 = new System.Windows.Forms.TextBox();
		this.共生_消耗类型 = new System.Windows.Forms.ComboBox();
		this.共生_重载按钮 = new System.Windows.Forms.Button();
		this.共生_保存按钮 = new System.Windows.Forms.Button();
		this.共生_开关 = new System.Windows.Forms.CheckBox();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.label11 = new System.Windows.Forms.Label();
		this.双属性_最高等级 = new System.Windows.Forms.NumericUpDown();
		this.label12 = new System.Windows.Forms.Label();
		this.双属性_最低等级 = new System.Windows.Forms.NumericUpDown();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.双属性_消耗价格 = new System.Windows.Forms.NumericUpDown();
		this.label10 = new System.Windows.Forms.Label();
		this.双属性_npc名字 = new System.Windows.Forms.TextBox();
		this.双属性_消耗类型 = new System.Windows.Forms.ComboBox();
		this.双属性_开关 = new System.Windows.Forms.CheckBox();
		this.大飞_技能精研 = new System.Windows.Forms.CheckBox();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.大飞_飞升等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.大飞_最低等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.大飞_消耗价格).BeginInit();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.共生_消耗价格).BeginInit();
		this.groupBox3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.双属性_最高等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.双属性_最低等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.双属性_消耗价格).BeginInit();
		base.SuspendLayout();
		this.groupBox1.Controls.Add(this.大飞_技能精研);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.大飞_飞升等级);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.大飞_最低等级);
		this.groupBox1.Controls.Add(this.label14);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.大飞_消耗价格);
		this.groupBox1.Controls.Add(this.label6);
		this.groupBox1.Controls.Add(this.大飞_npc名字);
		this.groupBox1.Controls.Add(this.大飞_消耗类型);
		this.groupBox1.Controls.Add(this.大飞_重载按钮);
		this.groupBox1.Controls.Add(this.大飞_保存按钮);
		this.groupBox1.Controls.Add(this.大飞_开关);
		this.groupBox1.Location = new System.Drawing.Point(12, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(351, 173);
		this.groupBox1.TabIndex = 0;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "一键大飞";
		this.label3.Location = new System.Drawing.Point(173, 136);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(60, 23);
		this.label3.TabIndex = 74;
		this.label3.Text = "飞升等级";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.大飞_飞升等级.Location = new System.Drawing.Point(239, 137);
		this.大飞_飞升等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.大飞_飞升等级.Name = "大飞_飞升等级";
		this.大飞_飞升等级.Size = new System.Drawing.Size(90, 23);
		this.大飞_飞升等级.TabIndex = 75;
		this.label1.Location = new System.Drawing.Point(16, 135);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 23);
		this.label1.TabIndex = 72;
		this.label1.Text = "最低等级";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.大飞_最低等级.Location = new System.Drawing.Point(77, 136);
		this.大飞_最低等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.大飞_最低等级.Name = "大飞_最低等级";
		this.大飞_最低等级.Size = new System.Drawing.Size(90, 23);
		this.大飞_最低等级.TabIndex = 73;
		this.label14.Location = new System.Drawing.Point(16, 62);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(60, 23);
		this.label14.TabIndex = 70;
		this.label14.Text = "附加NPC";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label2.Location = new System.Drawing.Point(173, 100);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(60, 23);
		this.label2.TabIndex = 66;
		this.label2.Text = "消耗价格";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.大飞_消耗价格.Location = new System.Drawing.Point(239, 101);
		this.大飞_消耗价格.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.大飞_消耗价格.Name = "大飞_消耗价格";
		this.大飞_消耗价格.Size = new System.Drawing.Size(90, 23);
		this.大飞_消耗价格.TabIndex = 67;
		this.label6.Location = new System.Drawing.Point(16, 100);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(60, 23);
		this.label6.TabIndex = 68;
		this.label6.Text = "消耗类型";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.大飞_npc名字.Location = new System.Drawing.Point(77, 62);
		this.大飞_npc名字.Name = "大飞_npc名字";
		this.大飞_npc名字.Size = new System.Drawing.Size(90, 23);
		this.大飞_npc名字.TabIndex = 69;
		this.大飞_消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.大飞_消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.大飞_消耗类型.FormattingEnabled = true;
		this.大飞_消耗类型.Items.AddRange(new object[2] { "金元宝", "银元宝" });
		this.大飞_消耗类型.Location = new System.Drawing.Point(77, 98);
		this.大飞_消耗类型.Name = "大飞_消耗类型";
		this.大飞_消耗类型.Size = new System.Drawing.Size(90, 25);
		this.大飞_消耗类型.TabIndex = 71;
		this.大飞_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.大飞_重载按钮.Location = new System.Drawing.Point(234, 18);
		this.大飞_重载按钮.Name = "大飞_重载按钮";
		this.大飞_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.大飞_重载按钮.TabIndex = 65;
		this.大飞_重载按钮.Text = "重载配置";
		this.大飞_重载按钮.UseVisualStyleBackColor = true;
		this.大飞_重载按钮.Click += new System.EventHandler(大飞_重载按钮_Click);
		this.大飞_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.大飞_保存按钮.Location = new System.Drawing.Point(128, 18);
		this.大飞_保存按钮.Name = "大飞_保存按钮";
		this.大飞_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.大飞_保存按钮.TabIndex = 64;
		this.大飞_保存按钮.Text = "保存配置";
		this.大飞_保存按钮.UseVisualStyleBackColor = true;
		this.大飞_保存按钮.Click += new System.EventHandler(大飞_保存按钮_Click);
		this.大飞_开关.AutoSize = true;
		this.大飞_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.大飞_开关.Location = new System.Drawing.Point(16, 22);
		this.大飞_开关.Name = "大飞_开关";
		this.大飞_开关.Size = new System.Drawing.Size(106, 23);
		this.大飞_开关.TabIndex = 63;
		this.大飞_开关.Text = "一键大飞开关";
		this.大飞_开关.UseVisualStyleBackColor = true;
		this.groupBox2.Controls.Add(this.label7);
		this.groupBox2.Controls.Add(this.label8);
		this.groupBox2.Controls.Add(this.共生_消耗价格);
		this.groupBox2.Controls.Add(this.label9);
		this.groupBox2.Controls.Add(this.共生_npc名字);
		this.groupBox2.Controls.Add(this.共生_消耗类型);
		this.groupBox2.Controls.Add(this.共生_重载按钮);
		this.groupBox2.Controls.Add(this.共生_保存按钮);
		this.groupBox2.Controls.Add(this.共生_开关);
		this.groupBox2.Location = new System.Drawing.Point(12, 191);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(351, 137);
		this.groupBox2.TabIndex = 1;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "法宝共生";
		this.label7.Location = new System.Drawing.Point(16, 62);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(60, 23);
		this.label7.TabIndex = 70;
		this.label7.Text = "附加NPC";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label8.Location = new System.Drawing.Point(173, 100);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(60, 23);
		this.label8.TabIndex = 66;
		this.label8.Text = "消耗价格";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.共生_消耗价格.Location = new System.Drawing.Point(239, 101);
		this.共生_消耗价格.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.共生_消耗价格.Name = "共生_消耗价格";
		this.共生_消耗价格.Size = new System.Drawing.Size(90, 23);
		this.共生_消耗价格.TabIndex = 67;
		this.label9.Location = new System.Drawing.Point(16, 100);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(60, 23);
		this.label9.TabIndex = 68;
		this.label9.Text = "消耗类型";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.共生_npc名字.Location = new System.Drawing.Point(77, 62);
		this.共生_npc名字.Name = "共生_npc名字";
		this.共生_npc名字.Size = new System.Drawing.Size(150, 23);
		this.共生_npc名字.TabIndex = 69;
		this.共生_消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.共生_消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.共生_消耗类型.FormattingEnabled = true;
		this.共生_消耗类型.Items.AddRange(new object[2] { "金元宝", "银元宝" });
		this.共生_消耗类型.Location = new System.Drawing.Point(77, 98);
		this.共生_消耗类型.Name = "共生_消耗类型";
		this.共生_消耗类型.Size = new System.Drawing.Size(90, 25);
		this.共生_消耗类型.TabIndex = 71;
		this.共生_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.共生_重载按钮.Location = new System.Drawing.Point(234, 18);
		this.共生_重载按钮.Name = "共生_重载按钮";
		this.共生_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.共生_重载按钮.TabIndex = 65;
		this.共生_重载按钮.Text = "重载配置";
		this.共生_重载按钮.UseVisualStyleBackColor = true;
		this.共生_重载按钮.Click += new System.EventHandler(共生_重载按钮_Click);
		this.共生_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.共生_保存按钮.Location = new System.Drawing.Point(128, 18);
		this.共生_保存按钮.Name = "共生_保存按钮";
		this.共生_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.共生_保存按钮.TabIndex = 64;
		this.共生_保存按钮.Text = "保存配置";
		this.共生_保存按钮.UseVisualStyleBackColor = true;
		this.共生_保存按钮.Click += new System.EventHandler(共生_保存按钮_Click);
		this.共生_开关.AutoSize = true;
		this.共生_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.共生_开关.Location = new System.Drawing.Point(16, 22);
		this.共生_开关.Name = "共生_开关";
		this.共生_开关.Size = new System.Drawing.Size(106, 23);
		this.共生_开关.TabIndex = 63;
		this.共生_开关.Text = "法宝共生开关";
		this.共生_开关.UseVisualStyleBackColor = true;
		this.groupBox3.Controls.Add(this.label11);
		this.groupBox3.Controls.Add(this.双属性_最高等级);
		this.groupBox3.Controls.Add(this.label12);
		this.groupBox3.Controls.Add(this.双属性_最低等级);
		this.groupBox3.Controls.Add(this.label4);
		this.groupBox3.Controls.Add(this.label5);
		this.groupBox3.Controls.Add(this.双属性_消耗价格);
		this.groupBox3.Controls.Add(this.label10);
		this.groupBox3.Controls.Add(this.双属性_npc名字);
		this.groupBox3.Controls.Add(this.双属性_消耗类型);
		this.groupBox3.Controls.Add(this.双属性_开关);
		this.groupBox3.Location = new System.Drawing.Point(12, 334);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(351, 141);
		this.groupBox3.TabIndex = 2;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "元神合体双属性";
		this.label11.Location = new System.Drawing.Point(170, 53);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(60, 23);
		this.label11.TabIndex = 78;
		this.label11.Text = "最高等级";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.双属性_最高等级.Location = new System.Drawing.Point(236, 54);
		this.双属性_最高等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.双属性_最高等级.Name = "双属性_最高等级";
		this.双属性_最高等级.Size = new System.Drawing.Size(90, 23);
		this.双属性_最高等级.TabIndex = 79;
		this.label12.Location = new System.Drawing.Point(13, 52);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(60, 23);
		this.label12.TabIndex = 76;
		this.label12.Text = "最低等级";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.双属性_最低等级.Location = new System.Drawing.Point(74, 53);
		this.双属性_最低等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.双属性_最低等级.Name = "双属性_最低等级";
		this.双属性_最低等级.Size = new System.Drawing.Size(90, 23);
		this.双属性_最低等级.TabIndex = 77;
		this.label4.Location = new System.Drawing.Point(115, 22);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 70;
		this.label4.Text = "附加NPC";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label5.Location = new System.Drawing.Point(170, 84);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(60, 23);
		this.label5.TabIndex = 66;
		this.label5.Text = "消耗价格";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.双属性_消耗价格.Location = new System.Drawing.Point(236, 85);
		this.双属性_消耗价格.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.双属性_消耗价格.Name = "双属性_消耗价格";
		this.双属性_消耗价格.Size = new System.Drawing.Size(90, 23);
		this.双属性_消耗价格.TabIndex = 67;
		this.label10.Location = new System.Drawing.Point(13, 84);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(60, 23);
		this.label10.TabIndex = 68;
		this.label10.Text = "消耗类型";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.双属性_npc名字.Location = new System.Drawing.Point(176, 22);
		this.双属性_npc名字.Name = "双属性_npc名字";
		this.双属性_npc名字.Size = new System.Drawing.Size(150, 23);
		this.双属性_npc名字.TabIndex = 69;
		this.双属性_消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.双属性_消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.双属性_消耗类型.FormattingEnabled = true;
		this.双属性_消耗类型.Items.AddRange(new object[2] { "金元宝", "银元宝" });
		this.双属性_消耗类型.Location = new System.Drawing.Point(74, 82);
		this.双属性_消耗类型.Name = "双属性_消耗类型";
		this.双属性_消耗类型.Size = new System.Drawing.Size(90, 25);
		this.双属性_消耗类型.TabIndex = 71;
		this.双属性_开关.AutoSize = true;
		this.双属性_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.双属性_开关.Location = new System.Drawing.Point(16, 22);
		this.双属性_开关.Name = "双属性_开关";
		this.双属性_开关.Size = new System.Drawing.Size(93, 23);
		this.双属性_开关.TabIndex = 63;
		this.双属性_开关.Text = "双属性开关";
		this.双属性_开关.UseVisualStyleBackColor = true;
		this.大飞_技能精研.AutoSize = true;
		this.大飞_技能精研.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.大飞_技能精研.Location = new System.Drawing.Point(170, 62);
		this.大飞_技能精研.Name = "大飞_技能精研";
		this.大飞_技能精研.Size = new System.Drawing.Size(145, 23);
		this.大飞_技能精研.TabIndex = 76;
		this.大飞_技能精研.Text = "大飞后技能是否精研";
		this.大飞_技能精研.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(377, 487);
		base.Controls.Add(this.groupBox3);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "大飞共生双属性窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "大飞共生双属性窗口";
		base.Load += new System.EventHandler(大飞共生双属性窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.大飞_飞升等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.大飞_最低等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.大飞_消耗价格).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.共生_消耗价格).EndInit();
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.双属性_最高等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.双属性_最低等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.双属性_消耗价格).EndInit();
		base.ResumeLayout(false);
	}
}
