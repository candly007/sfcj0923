using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 自定义守护窗口 : Form
{
	private static 自定义守护窗口 i;

	private IContainer components;

	private TextBox NPC名字;

	private Label label8;

	private Button 守护_重载按钮;

	private Button 守护_保存按钮;

	private NumericUpDown 领取数量;

	private CheckBox 功能_开关;

	private CheckBox Is旧门派;

	private ComboBox 相性;

	private Label label1;

	private Label label2;

	private Label label3;

	private TextBox 守护名称;

	private Label label4;

	private NumericUpDown 守护亲密度;

	private Label label5;

	private NumericUpDown 守护元气值;

	private Label label6;

	private NumericUpDown 武力成长;

	private Label label7;

	private NumericUpDown 仙术成长;

	private Label label9;

	private NumericUpDown 身法成长;

	private Label label10;

	private NumericUpDown 防护成长;

	public static 自定义守护窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 自定义守护窗口();
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

	public 自定义守护窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 自定义守护窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		守护_重载按钮_Click(sender, e);
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (base.IsHandleCreated && 配置类型 == 52)
		{
			Invoke((MethodInvoker)delegate
			{
				功能_开关.Checked = Singleton<全局变量类>.I.守护配置.功能开关;
				Is旧门派.Checked = Singleton<全局变量类>.I.守护配置.Is旧门派;
				相性.Text = ((Singleton<全局变量类>.I.守护配置.相性 == 0) ? "随机" : $"{(AllEnums.五行Type)Singleton<全局变量类>.I.守护配置.相性}");
				NPC名字.Text = Singleton<全局变量类>.I.守护配置.NPC名字;
				领取数量.Value = Singleton<全局变量类>.I.守护配置.领取数量;
				守护名称.Text = Singleton<全局变量类>.I.守护配置.守护名称;
				守护亲密度.Value = Singleton<全局变量类>.I.守护配置.守护亲密度;
				守护元气值.Value = Singleton<全局变量类>.I.守护配置.守护元气值;
				武力成长.Value = Singleton<全局变量类>.I.守护配置.武力成长;
				仙术成长.Value = Singleton<全局变量类>.I.守护配置.仙术成长;
				身法成长.Value = Singleton<全局变量类>.I.守护配置.身法成长;
				防护成长.Value = Singleton<全局变量类>.I.守护配置.防护成长;
			});
		}
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.守护配置.功能开关 = 功能_开关.Checked;
			Singleton<全局变量类>.I.守护配置.Is旧门派 = Is旧门派.Checked;
			if (相性.Text == "随机")
			{
				Singleton<全局变量类>.I.守护配置.相性 = 0;
			}
			else
			{
				Singleton<全局变量类>.I.守护配置.相性 = (int)Enum.Parse<AllEnums.五行Type>(相性.Text);
			}
			Singleton<全局变量类>.I.守护配置.NPC名字 = NPC名字.Text;
			Singleton<全局变量类>.I.守护配置.领取数量 = (int)领取数量.Value;
			Singleton<全局变量类>.I.守护配置.守护名称 = 守护名称.Text;
			Singleton<全局变量类>.I.守护配置.守护亲密度 = (int)守护亲密度.Value;
			Singleton<全局变量类>.I.守护配置.守护元气值 = (int)守护元气值.Value;
			Singleton<全局变量类>.I.守护配置.武力成长 = (int)武力成长.Value;
			Singleton<全局变量类>.I.守护配置.仙术成长 = (int)仙术成长.Value;
			Singleton<全局变量类>.I.守护配置.身法成长 = (int)身法成长.Value;
			Singleton<全局变量类>.I.守护配置.防护成长 = (int)防护成长.Value;
		}
	}

	private void 守护_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 52, JsonConvert.SerializeObject(Singleton<全局变量类>.I.守护配置, Formatting.Indented));
		}
	}

	private void 守护_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 52);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.自定义守护窗口));
		this.NPC名字 = new System.Windows.Forms.TextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.守护_重载按钮 = new System.Windows.Forms.Button();
		this.守护_保存按钮 = new System.Windows.Forms.Button();
		this.领取数量 = new System.Windows.Forms.NumericUpDown();
		this.功能_开关 = new System.Windows.Forms.CheckBox();
		this.Is旧门派 = new System.Windows.Forms.CheckBox();
		this.相性 = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.守护名称 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.守护亲密度 = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.守护元气值 = new System.Windows.Forms.NumericUpDown();
		this.label6 = new System.Windows.Forms.Label();
		this.武力成长 = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.仙术成长 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.身法成长 = new System.Windows.Forms.NumericUpDown();
		this.label10 = new System.Windows.Forms.Label();
		this.防护成长 = new System.Windows.Forms.NumericUpDown();
		((System.ComponentModel.ISupportInitialize)this.领取数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.守护亲密度).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.守护元气值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.武力成长).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.仙术成长).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.身法成长).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.防护成长).BeginInit();
		base.SuspendLayout();
		this.NPC名字.Location = new System.Drawing.Point(81, 78);
		this.NPC名字.Name = "NPC名字";
		this.NPC名字.Size = new System.Drawing.Size(106, 23);
		this.NPC名字.TabIndex = 57;
		this.label8.Location = new System.Drawing.Point(12, 48);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(65, 23);
		this.label8.TabIndex = 56;
		this.label8.Text = "守护相性";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.守护_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.守护_重载按钮.Location = new System.Drawing.Point(118, 347);
		this.守护_重载按钮.Name = "守护_重载按钮";
		this.守护_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.守护_重载按钮.TabIndex = 55;
		this.守护_重载按钮.Text = "重载配置";
		this.守护_重载按钮.UseVisualStyleBackColor = true;
		this.守护_重载按钮.Click += new System.EventHandler(守护_重载按钮_Click);
		this.守护_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.守护_保存按钮.Location = new System.Drawing.Point(12, 347);
		this.守护_保存按钮.Name = "守护_保存按钮";
		this.守护_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.守护_保存按钮.TabIndex = 54;
		this.守护_保存按钮.Text = "保存配置";
		this.守护_保存按钮.UseVisualStyleBackColor = true;
		this.守护_保存按钮.Click += new System.EventHandler(守护_保存按钮_Click);
		this.领取数量.Location = new System.Drawing.Point(81, 108);
		this.领取数量.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
		this.领取数量.Name = "领取数量";
		this.领取数量.Size = new System.Drawing.Size(106, 23);
		this.领取数量.TabIndex = 53;
		this.功能_开关.AutoSize = true;
		this.功能_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.功能_开关.Location = new System.Drawing.Point(12, 12);
		this.功能_开关.Name = "功能_开关";
		this.功能_开关.Size = new System.Drawing.Size(80, 23);
		this.功能_开关.TabIndex = 51;
		this.功能_开关.Text = "功能开关";
		this.功能_开关.UseVisualStyleBackColor = true;
		this.Is旧门派.AutoSize = true;
		this.Is旧门派.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.Is旧门派.Location = new System.Drawing.Point(98, 12);
		this.Is旧门派.Name = "Is旧门派";
		this.Is旧门派.Size = new System.Drawing.Size(145, 23);
		this.Is旧门派.TabIndex = 58;
		this.Is旧门派.Text = "是否配送旧门派守护";
		this.Is旧门派.UseVisualStyleBackColor = true;
		this.相性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.相性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.相性.FormattingEnabled = true;
		this.相性.Items.AddRange(new object[6] { "随机", "金", "木", "水", "火", "土" });
		this.相性.Location = new System.Drawing.Point(81, 46);
		this.相性.Name = "相性";
		this.相性.Size = new System.Drawing.Size(106, 25);
		this.相性.TabIndex = 112;
		this.label1.Location = new System.Drawing.Point(12, 78);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(65, 23);
		this.label1.TabIndex = 113;
		this.label1.Text = "NPC名字";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label2.Location = new System.Drawing.Point(12, 108);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(65, 23);
		this.label2.TabIndex = 114;
		this.label2.Text = "领取数量";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.Location = new System.Drawing.Point(12, 138);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(65, 23);
		this.label3.TabIndex = 116;
		this.label3.Text = "守护名字";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.守护名称.Location = new System.Drawing.Point(81, 138);
		this.守护名称.Name = "守护名称";
		this.守护名称.Size = new System.Drawing.Size(106, 23);
		this.守护名称.TabIndex = 115;
		this.label4.Location = new System.Drawing.Point(12, 168);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(65, 23);
		this.label4.TabIndex = 118;
		this.label4.Text = "亲密度";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.守护亲密度.Location = new System.Drawing.Point(81, 168);
		this.守护亲密度.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.守护亲密度.Name = "守护亲密度";
		this.守护亲密度.Size = new System.Drawing.Size(106, 23);
		this.守护亲密度.TabIndex = 117;
		this.label5.Location = new System.Drawing.Point(12, 198);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(65, 23);
		this.label5.TabIndex = 120;
		this.label5.Text = "元气值";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.守护元气值.Location = new System.Drawing.Point(81, 198);
		this.守护元气值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.守护元气值.Name = "守护元气值";
		this.守护元气值.Size = new System.Drawing.Size(106, 23);
		this.守护元气值.TabIndex = 119;
		this.label6.Location = new System.Drawing.Point(12, 228);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(65, 23);
		this.label6.TabIndex = 122;
		this.label6.Text = "武力成长";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.武力成长.Location = new System.Drawing.Point(81, 228);
		this.武力成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.武力成长.Name = "武力成长";
		this.武力成长.Size = new System.Drawing.Size(106, 23);
		this.武力成长.TabIndex = 121;
		this.label7.Location = new System.Drawing.Point(12, 258);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(65, 23);
		this.label7.TabIndex = 124;
		this.label7.Text = "仙术成长";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.仙术成长.Location = new System.Drawing.Point(81, 258);
		this.仙术成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.仙术成长.Name = "仙术成长";
		this.仙术成长.Size = new System.Drawing.Size(106, 23);
		this.仙术成长.TabIndex = 123;
		this.label9.Location = new System.Drawing.Point(12, 288);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(65, 23);
		this.label9.TabIndex = 126;
		this.label9.Text = "身法成长";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.身法成长.Location = new System.Drawing.Point(81, 288);
		this.身法成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.身法成长.Name = "身法成长";
		this.身法成长.Size = new System.Drawing.Size(106, 23);
		this.身法成长.TabIndex = 125;
		this.label10.Location = new System.Drawing.Point(12, 318);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(65, 23);
		this.label10.TabIndex = 128;
		this.label10.Text = "防护成长";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.防护成长.Location = new System.Drawing.Point(81, 318);
		this.防护成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.防护成长.Name = "防护成长";
		this.防护成长.Size = new System.Drawing.Size(106, 23);
		this.防护成长.TabIndex = 127;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(254, 397);
		base.Controls.Add(this.label10);
		base.Controls.Add(this.防护成长);
		base.Controls.Add(this.label9);
		base.Controls.Add(this.身法成长);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.仙术成长);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.武力成长);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.守护元气值);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.守护亲密度);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.守护名称);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.相性);
		base.Controls.Add(this.Is旧门派);
		base.Controls.Add(this.NPC名字);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.守护_重载按钮);
		base.Controls.Add(this.守护_保存按钮);
		base.Controls.Add(this.领取数量);
		base.Controls.Add(this.功能_开关);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "自定义守护窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "自定义守护窗口";
		base.Load += new System.EventHandler(自定义守护窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.领取数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.守护亲密度).EndInit();
		((System.ComponentModel.ISupportInitialize)this.守护元气值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.武力成长).EndInit();
		((System.ComponentModel.ISupportInitialize)this.仙术成长).EndInit();
		((System.ComponentModel.ISupportInitialize)this.身法成长).EndInit();
		((System.ComponentModel.ISupportInitialize)this.防护成长).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
