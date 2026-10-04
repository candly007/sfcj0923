using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 等级道行限制配置窗口 : Form
{
	private static 等级道行限制配置窗口 i;

	private IContainer components;

	private Button 检测_重载按钮;

	private Button 检测_保存按钮;

	private NumericUpDown 检测_最低等级;

	private TextBox textBox11;

	private CheckBox 检测_等级开关;

	private NumericUpDown 检测_最高等级;

	private TextBox textBox1;

	private NumericUpDown 检测_最高道行;

	private TextBox textBox2;

	private NumericUpDown 检测_最低道行;

	private TextBox textBox3;

	private CheckBox 检测_道行开关;

	private Label label5;

	public static 等级道行限制配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 等级道行限制配置窗口();
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

	public 等级道行限制配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 等级道行限制配置窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		检测_重载按钮_Click(sender, e);
	}

	private void 检测_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 21, JsonConvert.SerializeObject(Singleton<全局变量类>.I.等级道行检测, Formatting.Indented));
		}
	}

	private void 检测_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 21);
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (base.IsHandleCreated && 配置类型 == 21)
		{
			Invoke((MethodInvoker)delegate
			{
				检测_等级开关.Checked = Singleton<全局变量类>.I.等级道行检测.is检测等级;
				检测_最低等级.Value = Singleton<全局变量类>.I.等级道行检测.最低等级;
				检测_最高等级.Value = Singleton<全局变量类>.I.等级道行检测.最高等级;
				检测_道行开关.Checked = Singleton<全局变量类>.I.等级道行检测.is检测道行;
				检测_最低道行.Value = Singleton<全局变量类>.I.等级道行检测.最低道行;
				检测_最高道行.Value = Singleton<全局变量类>.I.等级道行检测.最高道行;
			});
		}
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.等级道行检测.is检测等级 = 检测_等级开关.Checked;
			Singleton<全局变量类>.I.等级道行检测.最低等级 = (int)检测_最低等级.Value;
			Singleton<全局变量类>.I.等级道行检测.最高等级 = (int)检测_最高等级.Value;
			Singleton<全局变量类>.I.等级道行检测.is检测道行 = 检测_道行开关.Checked;
			Singleton<全局变量类>.I.等级道行检测.最低道行 = (int)检测_最低道行.Value;
			Singleton<全局变量类>.I.等级道行检测.最高道行 = (int)检测_最高道行.Value;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.等级道行限制配置窗口));
		this.检测_重载按钮 = new System.Windows.Forms.Button();
		this.检测_保存按钮 = new System.Windows.Forms.Button();
		this.检测_最低等级 = new System.Windows.Forms.NumericUpDown();
		this.textBox11 = new System.Windows.Forms.TextBox();
		this.检测_等级开关 = new System.Windows.Forms.CheckBox();
		this.检测_最高等级 = new System.Windows.Forms.NumericUpDown();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.检测_最高道行 = new System.Windows.Forms.NumericUpDown();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.检测_最低道行 = new System.Windows.Forms.NumericUpDown();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.检测_道行开关 = new System.Windows.Forms.CheckBox();
		this.label5 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.检测_最低等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.检测_最高等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.检测_最高道行).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.检测_最低道行).BeginInit();
		base.SuspendLayout();
		this.检测_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.检测_重载按钮.Location = new System.Drawing.Point(118, 12);
		this.检测_重载按钮.Name = "检测_重载按钮";
		this.检测_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.检测_重载按钮.TabIndex = 122;
		this.检测_重载按钮.Text = "重载配置";
		this.检测_重载按钮.UseVisualStyleBackColor = true;
		this.检测_重载按钮.Click += new System.EventHandler(检测_重载按钮_Click);
		this.检测_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.检测_保存按钮.Location = new System.Drawing.Point(12, 12);
		this.检测_保存按钮.Name = "检测_保存按钮";
		this.检测_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.检测_保存按钮.TabIndex = 121;
		this.检测_保存按钮.Text = "保存配置";
		this.检测_保存按钮.UseVisualStyleBackColor = true;
		this.检测_保存按钮.Click += new System.EventHandler(检测_保存按钮_Click);
		this.检测_最低等级.Location = new System.Drawing.Point(205, 59);
		this.检测_最低等级.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.检测_最低等级.Name = "检测_最低等级";
		this.检测_最低等级.Size = new System.Drawing.Size(100, 23);
		this.检测_最低等级.TabIndex = 144;
		this.textBox11.Location = new System.Drawing.Point(124, 58);
		this.textBox11.Name = "textBox11";
		this.textBox11.ReadOnly = true;
		this.textBox11.Size = new System.Drawing.Size(80, 23);
		this.textBox11.TabIndex = 145;
		this.textBox11.Text = "全服最低等级";
		this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.检测_等级开关.AutoSize = true;
		this.检测_等级开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.检测_等级开关.Location = new System.Drawing.Point(12, 58);
		this.检测_等级开关.Name = "检测_等级开关";
		this.检测_等级开关.Size = new System.Drawing.Size(106, 23);
		this.检测_等级开关.TabIndex = 143;
		this.检测_等级开关.Text = "开启等级检测";
		this.检测_等级开关.UseVisualStyleBackColor = true;
		this.检测_最高等级.Location = new System.Drawing.Point(205, 89);
		this.检测_最高等级.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.检测_最高等级.Name = "检测_最高等级";
		this.检测_最高等级.Size = new System.Drawing.Size(100, 23);
		this.检测_最高等级.TabIndex = 146;
		this.textBox1.Location = new System.Drawing.Point(124, 88);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(80, 23);
		this.textBox1.TabIndex = 147;
		this.textBox1.Text = "全服最高等级";
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.检测_最高道行.Location = new System.Drawing.Point(205, 160);
		this.检测_最高道行.Maximum = new decimal(new int[4] { 5000000, 0, 0, 0 });
		this.检测_最高道行.Name = "检测_最高道行";
		this.检测_最高道行.Size = new System.Drawing.Size(100, 23);
		this.检测_最高道行.TabIndex = 151;
		this.textBox2.Location = new System.Drawing.Point(124, 159);
		this.textBox2.Name = "textBox2";
		this.textBox2.ReadOnly = true;
		this.textBox2.Size = new System.Drawing.Size(80, 23);
		this.textBox2.TabIndex = 152;
		this.textBox2.Text = "全服最高道行";
		this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.检测_最低道行.Location = new System.Drawing.Point(205, 130);
		this.检测_最低道行.Maximum = new decimal(new int[4] { 5000000, 0, 0, 0 });
		this.检测_最低道行.Name = "检测_最低道行";
		this.检测_最低道行.Size = new System.Drawing.Size(100, 23);
		this.检测_最低道行.TabIndex = 149;
		this.textBox3.Location = new System.Drawing.Point(124, 129);
		this.textBox3.Name = "textBox3";
		this.textBox3.ReadOnly = true;
		this.textBox3.Size = new System.Drawing.Size(80, 23);
		this.textBox3.TabIndex = 150;
		this.textBox3.Text = "全服最低道行";
		this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.检测_道行开关.AutoSize = true;
		this.检测_道行开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.检测_道行开关.Location = new System.Drawing.Point(12, 129);
		this.检测_道行开关.Name = "检测_道行开关";
		this.检测_道行开关.Size = new System.Drawing.Size(106, 23);
		this.检测_道行开关.TabIndex = 148;
		this.检测_道行开关.Text = "开启道行检测";
		this.检测_道行开关.UseVisualStyleBackColor = true;
		this.label5.ForeColor = System.Drawing.Color.Red;
		this.label5.Location = new System.Drawing.Point(1, 185);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(340, 52);
		this.label5.TabIndex = 153;
		this.label5.Text = "开启和关闭检测选择以后，点击保存配置即可实时开启或关闭\r\n开启等级检测后，刷等级会被直接封号";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(341, 246);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.检测_最高道行);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.检测_最低道行);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.检测_道行开关);
		base.Controls.Add(this.检测_最高等级);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.检测_最低等级);
		base.Controls.Add(this.textBox11);
		base.Controls.Add(this.检测_等级开关);
		base.Controls.Add(this.检测_重载按钮);
		base.Controls.Add(this.检测_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "等级道行限制配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "等级道行限制配置窗口";
		base.Load += new System.EventHandler(等级道行限制配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.检测_最低等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.检测_最高等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.检测_最高道行).EndInit();
		((System.ComponentModel.ISupportInitialize)this.检测_最低道行).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
