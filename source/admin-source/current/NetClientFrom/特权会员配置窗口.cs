using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 特权会员配置窗口 : Form
{
	private static 特权会员配置窗口 i;

	private IContainer components;

	private CheckBox 特权会员_开关;

	private Button 特权会员_重载按钮;

	private Button 特权会员_保存按钮;

	private GroupBox groupBox1;

	private NumericUpDown 特权会员_形象;

	private Label label9;

	private ComboBox 特权会员_朝向;

	private Label label8;

	private NumericUpDown 特权会员_坐标Y;

	private NumericUpDown 特权会员_坐标X;

	private Label label7;

	private Label label5;

	private TextBox 特权会员_npc称号;

	private Label label4;

	private TextBox 特权会员_npc名字;

	private GroupBox groupBox2;

	private Label label2;

	private Label label3;

	private TextBox 特权会员_会员地图;

	private NumericUpDown 特权会员_每周分红;

	private Label label6;

	private TextBox 特权会员_每日福利;

	private Label label10;

	private TextBox 特权会员_指定称号;

	private Label label12;

	private Label label11;

	private NumericUpDown 特权会员_分红比例;

	private Label label1;

	public static 特权会员配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 特权会员配置窗口();
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

	public 特权会员配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 特权会员配置窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		特权会员_重载按钮_Click(sender, e);
	}

	private void 特权会员_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 7, JsonConvert.SerializeObject(Singleton<全局变量类>.I.指定会员配置, Formatting.Indented));
		}
	}

	private void 特权会员_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 7);
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (base.IsHandleCreated && 配置类型 == 7)
		{
			Invoke((MethodInvoker)delegate
			{
				特权会员_开关.Checked = Singleton<全局变量类>.I.指定会员配置.功能开关;
				特权会员_npc名字.Text = Singleton<全局变量类>.I.指定会员配置.NPC数据.npc名字;
				特权会员_npc称号.Text = Singleton<全局变量类>.I.指定会员配置.NPC数据.npc称号;
				特权会员_坐标X.Value = Singleton<全局变量类>.I.指定会员配置.NPC数据.坐标.X;
				特权会员_坐标Y.Value = Singleton<全局变量类>.I.指定会员配置.NPC数据.坐标.Y;
				特权会员_朝向.Text = $"{(AllEnums.朝向Type)Singleton<全局变量类>.I.指定会员配置.NPC数据.朝向}";
				特权会员_形象.Value = Singleton<全局变量类>.I.指定会员配置.NPC数据.npc形象;
				特权会员_指定称号.Text = Singleton<全局变量类>.I.指定会员配置.指定称号;
				特权会员_每日福利.Text = Singleton<全局变量类>.I.指定会员配置.每日领取;
				特权会员_会员地图.Text = Singleton<全局变量类>.I.指定会员配置.指定地图;
				特权会员_每周分红.Value = Singleton<全局变量类>.I.指定会员配置.每周最低分红;
				特权会员_分红比例.Value = Singleton<全局变量类>.I.指定会员配置.分红比例;
			});
		}
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.指定会员配置.功能开关 = 特权会员_开关.Checked;
			Singleton<全局变量类>.I.指定会员配置.NPC数据.npc名字 = 特权会员_npc名字.Text;
			Singleton<全局变量类>.I.指定会员配置.NPC数据.npc称号 = 特权会员_npc称号.Text;
			Singleton<全局变量类>.I.指定会员配置.NPC数据.坐标.X = (short)特权会员_坐标X.Value;
			Singleton<全局变量类>.I.指定会员配置.NPC数据.坐标.Y = (short)特权会员_坐标Y.Value;
			Singleton<全局变量类>.I.指定会员配置.NPC数据.朝向 = (short)Enum.Parse<AllEnums.朝向Type>(特权会员_朝向.Text);
			Singleton<全局变量类>.I.指定会员配置.NPC数据.npc形象 = (int)特权会员_形象.Value;
			Singleton<全局变量类>.I.指定会员配置.指定称号 = 特权会员_指定称号.Text;
			Singleton<全局变量类>.I.指定会员配置.每日领取 = 特权会员_每日福利.Text;
			Singleton<全局变量类>.I.指定会员配置.指定地图 = 特权会员_会员地图.Text;
			Singleton<全局变量类>.I.指定会员配置.每周最低分红 = (int)特权会员_每周分红.Value;
			Singleton<全局变量类>.I.指定会员配置.分红比例 = (int)特权会员_分红比例.Value;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.特权会员配置窗口));
		this.特权会员_开关 = new System.Windows.Forms.CheckBox();
		this.特权会员_重载按钮 = new System.Windows.Forms.Button();
		this.特权会员_保存按钮 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.特权会员_形象 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.特权会员_朝向 = new System.Windows.Forms.ComboBox();
		this.label8 = new System.Windows.Forms.Label();
		this.特权会员_坐标Y = new System.Windows.Forms.NumericUpDown();
		this.特权会员_坐标X = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.特权会员_npc称号 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.特权会员_npc名字 = new System.Windows.Forms.TextBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.label12 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.特权会员_分红比例 = new System.Windows.Forms.NumericUpDown();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.特权会员_会员地图 = new System.Windows.Forms.TextBox();
		this.特权会员_每周分红 = new System.Windows.Forms.NumericUpDown();
		this.label6 = new System.Windows.Forms.Label();
		this.特权会员_每日福利 = new System.Windows.Forms.TextBox();
		this.label10 = new System.Windows.Forms.Label();
		this.特权会员_指定称号 = new System.Windows.Forms.TextBox();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.特权会员_形象).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.特权会员_坐标Y).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.特权会员_坐标X).BeginInit();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.特权会员_分红比例).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.特权会员_每周分红).BeginInit();
		base.SuspendLayout();
		this.特权会员_开关.AutoSize = true;
		this.特权会员_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.特权会员_开关.Location = new System.Drawing.Point(12, 12);
		this.特权会员_开关.Name = "特权会员_开关";
		this.特权会员_开关.Size = new System.Drawing.Size(106, 23);
		this.特权会员_开关.TabIndex = 96;
		this.特权会员_开关.Text = "特权会员开关";
		this.特权会员_开关.UseVisualStyleBackColor = true;
		this.特权会员_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.特权会员_重载按钮.Location = new System.Drawing.Point(230, 8);
		this.特权会员_重载按钮.Name = "特权会员_重载按钮";
		this.特权会员_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.特权会员_重载按钮.TabIndex = 98;
		this.特权会员_重载按钮.Text = "重载配置";
		this.特权会员_重载按钮.UseVisualStyleBackColor = true;
		this.特权会员_重载按钮.Click += new System.EventHandler(特权会员_重载按钮_Click);
		this.特权会员_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.特权会员_保存按钮.Location = new System.Drawing.Point(124, 8);
		this.特权会员_保存按钮.Name = "特权会员_保存按钮";
		this.特权会员_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.特权会员_保存按钮.TabIndex = 97;
		this.特权会员_保存按钮.Text = "保存配置";
		this.特权会员_保存按钮.UseVisualStyleBackColor = true;
		this.特权会员_保存按钮.Click += new System.EventHandler(特权会员_保存按钮_Click);
		this.groupBox1.Controls.Add(this.特权会员_形象);
		this.groupBox1.Controls.Add(this.label9);
		this.groupBox1.Controls.Add(this.特权会员_朝向);
		this.groupBox1.Controls.Add(this.label8);
		this.groupBox1.Controls.Add(this.特权会员_坐标Y);
		this.groupBox1.Controls.Add(this.特权会员_坐标X);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.特权会员_npc称号);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.特权会员_npc名字);
		this.groupBox1.Location = new System.Drawing.Point(12, 44);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(776, 58);
		this.groupBox1.TabIndex = 99;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "npc配置";
		this.特权会员_形象.Location = new System.Drawing.Point(644, 17);
		this.特权会员_形象.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.特权会员_形象.Name = "特权会员_形象";
		this.特权会员_形象.Size = new System.Drawing.Size(100, 23);
		this.特权会员_形象.TabIndex = 112;
		this.label9.BackColor = System.Drawing.Color.Transparent;
		this.label9.Location = new System.Drawing.Point(611, 17);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(32, 23);
		this.label9.TabIndex = 111;
		this.label9.Text = "形象";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.特权会员_朝向.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.特权会员_朝向.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.特权会员_朝向.FormattingEnabled = true;
		this.特权会员_朝向.Items.AddRange(new object[8] { "左", "左上", "上", "右上", "右", "右下", "下", "左下" });
		this.特权会员_朝向.Location = new System.Drawing.Point(545, 17);
		this.特权会员_朝向.Name = "特权会员_朝向";
		this.特权会员_朝向.Size = new System.Drawing.Size(60, 25);
		this.特权会员_朝向.TabIndex = 110;
		this.label8.BackColor = System.Drawing.Color.Transparent;
		this.label8.Location = new System.Drawing.Point(513, 19);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(32, 23);
		this.label8.TabIndex = 109;
		this.label8.Text = "朝向";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.特权会员_坐标Y.Location = new System.Drawing.Point(447, 19);
		this.特权会员_坐标Y.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.特权会员_坐标Y.Name = "特权会员_坐标Y";
		this.特权会员_坐标Y.Size = new System.Drawing.Size(60, 23);
		this.特权会员_坐标Y.TabIndex = 108;
		this.特权会员_坐标X.Location = new System.Drawing.Point(370, 19);
		this.特权会员_坐标X.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.特权会员_坐标X.Name = "特权会员_坐标X";
		this.特权会员_坐标X.Size = new System.Drawing.Size(60, 23);
		this.特权会员_坐标X.TabIndex = 107;
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
		this.特权会员_npc称号.Location = new System.Drawing.Point(229, 19);
		this.特权会员_npc称号.Name = "特权会员_npc称号";
		this.特权会员_npc称号.Size = new System.Drawing.Size(100, 23);
		this.特权会员_npc称号.TabIndex = 105;
		this.label4.Location = new System.Drawing.Point(6, 19);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 102;
		this.label4.Text = "npc名字";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.特权会员_npc名字.Location = new System.Drawing.Point(67, 19);
		this.特权会员_npc名字.Name = "特权会员_npc名字";
		this.特权会员_npc名字.Size = new System.Drawing.Size(100, 23);
		this.特权会员_npc名字.TabIndex = 103;
		this.groupBox2.Controls.Add(this.label12);
		this.groupBox2.Controls.Add(this.label11);
		this.groupBox2.Controls.Add(this.特权会员_分红比例);
		this.groupBox2.Controls.Add(this.label1);
		this.groupBox2.Controls.Add(this.label2);
		this.groupBox2.Controls.Add(this.label3);
		this.groupBox2.Controls.Add(this.特权会员_会员地图);
		this.groupBox2.Controls.Add(this.特权会员_每周分红);
		this.groupBox2.Controls.Add(this.label6);
		this.groupBox2.Controls.Add(this.特权会员_每日福利);
		this.groupBox2.Controls.Add(this.label10);
		this.groupBox2.Controls.Add(this.特权会员_指定称号);
		this.groupBox2.Location = new System.Drawing.Point(12, 108);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(776, 77);
		this.groupBox2.TabIndex = 100;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "特权会员配置";
		this.label12.ForeColor = System.Drawing.Color.Red;
		this.label12.Location = new System.Drawing.Point(6, 45);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(764, 23);
		this.label12.TabIndex = 119;
		this.label12.Text = "每周分红固定位银元宝，分红比例：比如10%，就是多一个人在每周最低分红的基础上增加10%";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label11.BackColor = System.Drawing.Color.Transparent;
		this.label11.Location = new System.Drawing.Point(753, 19);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(23, 23);
		this.label11.TabIndex = 118;
		this.label11.Text = "%";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.特权会员_分红比例.Location = new System.Drawing.Point(702, 19);
		this.特权会员_分红比例.Name = "特权会员_分红比例";
		this.特权会员_分红比例.Size = new System.Drawing.Size(50, 23);
		this.特权会员_分红比例.TabIndex = 117;
		this.label1.BackColor = System.Drawing.Color.Transparent;
		this.label1.Location = new System.Drawing.Point(669, 19);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(32, 23);
		this.label1.TabIndex = 116;
		this.label1.Text = "比例";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label2.Location = new System.Drawing.Point(502, 19);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(60, 23);
		this.label2.TabIndex = 115;
		this.label2.Text = "每周分红";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label3.Location = new System.Drawing.Point(335, 19);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(60, 23);
		this.label3.TabIndex = 113;
		this.label3.Text = "会员地图";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.特权会员_会员地图.Location = new System.Drawing.Point(396, 19);
		this.特权会员_会员地图.Name = "特权会员_会员地图";
		this.特权会员_会员地图.Size = new System.Drawing.Size(100, 23);
		this.特权会员_会员地图.TabIndex = 114;
		this.特权会员_每周分红.Location = new System.Drawing.Point(563, 19);
		this.特权会员_每周分红.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.特权会员_每周分红.Name = "特权会员_每周分红";
		this.特权会员_每周分红.Size = new System.Drawing.Size(100, 23);
		this.特权会员_每周分红.TabIndex = 112;
		this.label6.Location = new System.Drawing.Point(168, 19);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(60, 23);
		this.label6.TabIndex = 104;
		this.label6.Text = "每日福利";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.特权会员_每日福利.Location = new System.Drawing.Point(229, 19);
		this.特权会员_每日福利.Name = "特权会员_每日福利";
		this.特权会员_每日福利.Size = new System.Drawing.Size(100, 23);
		this.特权会员_每日福利.TabIndex = 105;
		this.label10.Location = new System.Drawing.Point(6, 19);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(60, 23);
		this.label10.TabIndex = 102;
		this.label10.Text = "指定称号";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.特权会员_指定称号.Location = new System.Drawing.Point(67, 19);
		this.特权会员_指定称号.Name = "特权会员_指定称号";
		this.特权会员_指定称号.Size = new System.Drawing.Size(100, 23);
		this.特权会员_指定称号.TabIndex = 103;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(800, 201);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.特权会员_开关);
		base.Controls.Add(this.特权会员_重载按钮);
		base.Controls.Add(this.特权会员_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "特权会员配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "特权会员配置窗口";
		base.Load += new System.EventHandler(特权会员配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.特权会员_形象).EndInit();
		((System.ComponentModel.ISupportInitialize)this.特权会员_坐标Y).EndInit();
		((System.ComponentModel.ISupportInitialize)this.特权会员_坐标X).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.特权会员_分红比例).EndInit();
		((System.ComponentModel.ISupportInitialize)this.特权会员_每周分红).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
