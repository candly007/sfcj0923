using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 自定义邮箱配置窗口 : Form
{
	private static 自定义邮箱配置窗口 i;

	private IContainer components;

	private Button 邮箱_重载按钮;

	private Button 邮箱_保存按钮;

	private CheckBox 邮箱_开关;

	private GroupBox groupBox1;

	private CheckBox 邮箱_首登邮箱发送开关;

	private Label label7;

	private TextBox 邮箱_首登邮箱内容;

	private GroupBox groupBox2;

	private Label label1;

	private TextBox textBox1;

	private CheckBox checkBox2;

	private Label label2;

	private Button 邮箱_自定义发送按钮;

	private ComboBox 邮箱_角色列表;

	private TextBox 邮箱_自定义邮箱内容;

	private Label label3;

	public static 自定义邮箱配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 自定义邮箱配置窗口();
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
		邮箱_角色列表.Items.Clear();
		邮箱_角色列表.Items.Add("所有玩家");
		for (int i = 0; i < Singleton<全局变量类>.I.角色列表.Count; i++)
		{
			邮箱_角色列表.Items.Add(Singleton<全局变量类>.I.角色列表[i].昵称);
		}
	}

	public 自定义邮箱配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 自定义邮箱配置窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		邮箱_重载按钮_Click(sender, e);
	}

	private void 邮箱_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 33, JsonConvert.SerializeObject(Singleton<全局变量类>.I.邮箱配置, Formatting.Indented));
		}
	}

	private void 邮箱_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 33);
		}
	}

	private void 邮箱_自定义发送按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(邮箱_角色列表.Text))
			{
				MessageBox.Show("请选择要发送邮件的玩家！");
				return;
			}
			Singleton<全局变量类>.I.验证client.SendRT(10054, 邮箱_角色列表.Text, 邮箱_自定义邮箱内容.Text);
		}
	}

	private void 邮箱_角色列表_TextUpdate(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(邮箱_角色列表.Text))
		{
			邮箱_角色列表.Items.Clear();
			邮箱_角色列表.Items.Add("所有玩家");
			for (int i = 0; i < Singleton<全局变量类>.I.角色列表.Count; i++)
			{
				邮箱_角色列表.Items.Add(Singleton<全局变量类>.I.角色列表[i].昵称);
			}
			return;
		}
		邮箱_角色列表.Items.Clear();
		List<角色汇总类> list = Singleton<全局变量类>.I.角色列表.FindAll((角色汇总类 x) => x.昵称.Contains(邮箱_角色列表.Text, StringComparison.CurrentCulture));
		if (list != null)
		{
			for (int num = 0; num < list.Count; num++)
			{
				邮箱_角色列表.Items.Add(list[num].昵称);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (base.IsHandleCreated && 配置类型 == 33)
		{
			Invoke((MethodInvoker)delegate
			{
				邮箱_开关.Checked = Singleton<全局变量类>.I.邮箱配置.功能开关;
				邮箱_首登邮箱发送开关.Checked = Singleton<全局变量类>.I.邮箱配置.首登开关;
				邮箱_首登邮箱内容.Text = Singleton<全局变量类>.I.邮箱配置.首登邮件;
			});
		}
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.邮箱配置.功能开关 = 邮箱_开关.Checked;
			Singleton<全局变量类>.I.邮箱配置.首登开关 = 邮箱_首登邮箱发送开关.Checked;
			Singleton<全局变量类>.I.邮箱配置.首登邮件 = 邮箱_首登邮箱内容.Text;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.自定义邮箱配置窗口));
		this.邮箱_重载按钮 = new System.Windows.Forms.Button();
		this.邮箱_保存按钮 = new System.Windows.Forms.Button();
		this.邮箱_开关 = new System.Windows.Forms.CheckBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label7 = new System.Windows.Forms.Label();
		this.邮箱_首登邮箱内容 = new System.Windows.Forms.TextBox();
		this.邮箱_首登邮箱发送开关 = new System.Windows.Forms.CheckBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.邮箱_自定义发送按钮 = new System.Windows.Forms.Button();
		this.邮箱_自定义邮箱内容 = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.邮箱_角色列表 = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.groupBox1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		base.SuspendLayout();
		this.邮箱_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.邮箱_重载按钮.Location = new System.Drawing.Point(243, 7);
		this.邮箱_重载按钮.Name = "邮箱_重载按钮";
		this.邮箱_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.邮箱_重载按钮.TabIndex = 71;
		this.邮箱_重载按钮.Text = "重载配置";
		this.邮箱_重载按钮.UseVisualStyleBackColor = true;
		this.邮箱_重载按钮.Click += new System.EventHandler(邮箱_重载按钮_Click);
		this.邮箱_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.邮箱_保存按钮.Location = new System.Drawing.Point(137, 7);
		this.邮箱_保存按钮.Name = "邮箱_保存按钮";
		this.邮箱_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.邮箱_保存按钮.TabIndex = 70;
		this.邮箱_保存按钮.Text = "保存配置";
		this.邮箱_保存按钮.UseVisualStyleBackColor = true;
		this.邮箱_保存按钮.Click += new System.EventHandler(邮箱_保存按钮_Click);
		this.邮箱_开关.AutoSize = true;
		this.邮箱_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.邮箱_开关.Location = new System.Drawing.Point(12, 12);
		this.邮箱_开关.Name = "邮箱_开关";
		this.邮箱_开关.Size = new System.Drawing.Size(119, 23);
		this.邮箱_开关.TabIndex = 69;
		this.邮箱_开关.Text = "自定义邮箱开关";
		this.邮箱_开关.UseVisualStyleBackColor = true;
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.邮箱_首登邮箱内容);
		this.groupBox1.Controls.Add(this.邮箱_首登邮箱发送开关);
		this.groupBox1.Location = new System.Drawing.Point(12, 52);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(755, 152);
		this.groupBox1.TabIndex = 72;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "发送首登邮箱配置";
		this.label7.Location = new System.Drawing.Point(20, 48);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(60, 23);
		this.label7.TabIndex = 72;
		this.label7.Text = "邮件内容";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.邮箱_首登邮箱内容.Location = new System.Drawing.Point(81, 48);
		this.邮箱_首登邮箱内容.Multiline = true;
		this.邮箱_首登邮箱内容.Name = "邮箱_首登邮箱内容";
		this.邮箱_首登邮箱内容.Size = new System.Drawing.Size(668, 98);
		this.邮箱_首登邮箱内容.TabIndex = 71;
		this.邮箱_首登邮箱发送开关.AutoSize = true;
		this.邮箱_首登邮箱发送开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.邮箱_首登邮箱发送开关.Location = new System.Drawing.Point(20, 22);
		this.邮箱_首登邮箱发送开关.Name = "邮箱_首登邮箱发送开关";
		this.邮箱_首登邮箱发送开关.Size = new System.Drawing.Size(158, 23);
		this.邮箱_首登邮箱发送开关.TabIndex = 70;
		this.邮箱_首登邮箱发送开关.Text = "首次登录发送邮件开关";
		this.邮箱_首登邮箱发送开关.UseVisualStyleBackColor = true;
		this.groupBox2.Controls.Add(this.label3);
		this.groupBox2.Controls.Add(this.邮箱_自定义发送按钮);
		this.groupBox2.Controls.Add(this.邮箱_自定义邮箱内容);
		this.groupBox2.Controls.Add(this.label2);
		this.groupBox2.Controls.Add(this.邮箱_角色列表);
		this.groupBox2.Controls.Add(this.label1);
		this.groupBox2.Location = new System.Drawing.Point(12, 210);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(755, 209);
		this.groupBox2.TabIndex = 73;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "自定义邮箱配置";
		this.邮箱_自定义发送按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.邮箱_自定义发送按钮.Location = new System.Drawing.Point(298, 23);
		this.邮箱_自定义发送按钮.Name = "邮箱_自定义发送按钮";
		this.邮箱_自定义发送按钮.Size = new System.Drawing.Size(79, 30);
		this.邮箱_自定义发送按钮.TabIndex = 78;
		this.邮箱_自定义发送按钮.Text = "确定发送";
		this.邮箱_自定义发送按钮.UseVisualStyleBackColor = true;
		this.邮箱_自定义发送按钮.Click += new System.EventHandler(邮箱_自定义发送按钮_Click);
		this.邮箱_自定义邮箱内容.Location = new System.Drawing.Point(102, 60);
		this.邮箱_自定义邮箱内容.Multiline = true;
		this.邮箱_自定义邮箱内容.Name = "邮箱_自定义邮箱内容";
		this.邮箱_自定义邮箱内容.Size = new System.Drawing.Size(647, 143);
		this.邮箱_自定义邮箱内容.TabIndex = 77;
		this.label2.Location = new System.Drawing.Point(20, 27);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(80, 23);
		this.label2.TabIndex = 76;
		this.label2.Text = "选择发送角色";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.邮箱_角色列表.FormattingEnabled = true;
		this.邮箱_角色列表.IntegralHeight = false;
		this.邮箱_角色列表.Location = new System.Drawing.Point(102, 26);
		this.邮箱_角色列表.MaxDropDownItems = 100;
		this.邮箱_角色列表.Name = "邮箱_角色列表";
		this.邮箱_角色列表.Size = new System.Drawing.Size(180, 25);
		this.邮箱_角色列表.TabIndex = 74;
		this.邮箱_角色列表.TextUpdate += new System.EventHandler(邮箱_角色列表_TextUpdate);
		this.label1.Location = new System.Drawing.Point(36, 60);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 23);
		this.label1.TabIndex = 72;
		this.label1.Text = "邮件内容";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label3.ForeColor = System.Drawing.Color.Red;
		this.label3.Location = new System.Drawing.Point(383, 26);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(366, 23);
		this.label3.TabIndex = 79;
		this.label3.Text = "先在角色监控刷新在线角色列表后再选择角色进行发送";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(780, 429);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.邮箱_重载按钮);
		base.Controls.Add(this.邮箱_保存按钮);
		base.Controls.Add(this.邮箱_开关);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "自定义邮箱配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "自定义邮箱配置窗口";
		base.Load += new System.EventHandler(自定义邮箱配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
