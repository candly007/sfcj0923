using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 喊话聊天配置窗口 : Form
{
	private static 喊话聊天配置窗口 i;

	private IContainer components;

	private CheckBox 喊话_限制开关;

	private Button 喊话_重载按钮;

	private Button 喊话_保存按钮;

	private CheckBox 喊话_敏感词掉线开关;

	private Label label2;

	private NumericUpDown 喊话_喇叭等级;

	private Label label6;

	private TextBox 喊话_添加敏感词;

	private Button 喊话_添加按钮;

	private TextBox 喊话_敏感词列表;

	private GroupBox groupBox1;

	private Label label4;

	private NumericUpDown 喊话_间隔分钟;

	private Label label3;

	private TextBox 喊话_结束时间;

	private Label label1;

	private TextBox 喊话_开始时间;

	private Label label5;

	private Button 喊话_停止定时按钮;

	private Button 喊话_启动定时按钮;

	private Label label7;

	private TextBox 喊话_喊话内容;

	private ComboBox 喊话_频道;

	private GroupBox groupBox2;

	private DataGridView 喊话_日志列表;

	private DataGridViewTextBoxColumn 类型;

	private DataGridViewTextBoxColumn 名字;

	private DataGridViewTextBoxColumn 金元宝;

	private DataGridViewTextBoxColumn 银元宝;

	public static 喊话聊天配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 喊话聊天配置窗口();
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

	public 喊话聊天配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 喊话聊天配置窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		喊话_重载按钮_Click(sender, e);
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 6)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			喊话_限制开关.Checked = Singleton<全局变量类>.I.喊话限制配置.功能开关;
			喊话_敏感词掉线开关.Checked = Singleton<全局变量类>.I.喊话限制配置.is触发掉线;
			喊话_喇叭等级.Value = Singleton<全局变量类>.I.喊话限制配置.喇叭喊话最低等级;
			喊话_敏感词列表.Text = string.Empty;
			for (int i = 0; i < Singleton<全局变量类>.I.喊话限制配置.敏感词.Count; i++)
			{
				TextBox textBox = 喊话_敏感词列表;
				textBox.Text = textBox.Text + Singleton<全局变量类>.I.喊话限制配置.敏感词[i] + "\r\n";
			}
			喊话_开始时间.Text = (string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.喊话限制配置.开始时间) ? "2025-1-1 0:00:00" : Singleton<全局变量类>.I.喊话限制配置.开始时间);
			喊话_结束时间.Text = (string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.喊话限制配置.结束时间) ? "2025-1-1 0:00:00" : Singleton<全局变量类>.I.喊话限制配置.结束时间);
			喊话_间隔分钟.Value = Singleton<全局变量类>.I.喊话限制配置.间隔时间;
			喊话_频道.Text = Singleton<全局变量类>.I.喊话限制配置.喊话频道.ToString();
			喊话_喊话内容.Text = Singleton<全局变量类>.I.喊话限制配置.喊话内容;
		});
	}

	private void 配置变量赋值()
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		Singleton<全局变量类>.I.喊话限制配置.功能开关 = 喊话_限制开关.Checked;
		Singleton<全局变量类>.I.喊话限制配置.is触发掉线 = 喊话_敏感词掉线开关.Checked;
		Singleton<全局变量类>.I.喊话限制配置.喇叭喊话最低等级 = (int)喊话_喇叭等级.Value;
		string[] array = 喊话_敏感词列表.Text.Split("\r\n");
		Singleton<全局变量类>.I.喊话限制配置.敏感词.Clear();
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrWhiteSpace(array[i]))
			{
				Singleton<全局变量类>.I.喊话限制配置.敏感词.Add(array[i]);
			}
		}
		Singleton<全局变量类>.I.喊话限制配置.开始时间 = 喊话_开始时间.Text;
		Singleton<全局变量类>.I.喊话限制配置.结束时间 = 喊话_结束时间.Text;
		Singleton<全局变量类>.I.喊话限制配置.间隔时间 = (int)喊话_间隔分钟.Value;
		Enum.TryParse<AllEnums.频道Type>(喊话_频道.Text, out Singleton<全局变量类>.I.喊话限制配置.喊话频道);
		Singleton<全局变量类>.I.喊话限制配置.喊话内容 = 喊话_喊话内容.Text;
	}

	private void 喊话_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 6, JsonConvert.SerializeObject(Singleton<全局变量类>.I.喊话限制配置, Formatting.Indented));
		}
	}

	private void 喊话_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 6);
		}
	}

	private void 喊话_添加按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(喊话_添加敏感词.Text))
			{
				MessageBox.Show("请输入敏感词！");
				return;
			}
			if (Singleton<全局变量类>.I.喊话限制配置.敏感词.Any((string x) => x == 喊话_添加敏感词.Text))
			{
				MessageBox.Show("敏感词[" + 喊话_添加敏感词.Text + "]已存在！");
				return;
			}
			Singleton<全局变量类>.I.喊话限制配置.敏感词.Add(喊话_添加敏感词.Text);
			TextBox textBox = 喊话_敏感词列表;
			textBox.Text = textBox.Text + 喊话_添加敏感词.Text + "\r\n";
		}
	}

	private void 喊话_启动定时按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (Singleton<全局变量类>.I.喊话限制配置.Is开启)
			{
				MessageBox.Show("定时喊话已经开启了！");
				return;
			}
			if (string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.喊话限制配置.开始时间) || string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.喊话限制配置.结束时间))
			{
				MessageBox.Show("请先保存喊话配置，输入正确的喊话时间！");
				return;
			}
			if (Singleton<全局变量类>.I.喊话限制配置.间隔时间 <= 0)
			{
				MessageBox.Show("请输入正确的喊话间隔分钟！");
				return;
			}
			if (string.IsNullOrWhiteSpace(Singleton<全局变量类>.I.喊话限制配置.喊话内容))
			{
				MessageBox.Show("请输入有效的喊话内容！");
				return;
			}
			Singleton<全局变量类>.I.喊话限制配置.Is开启 = true;
			Singleton<全局变量类>.I.验证client.SendRT(10018, 6, JsonConvert.SerializeObject(Singleton<全局变量类>.I.喊话限制配置, Formatting.Indented));
			Singleton<全局变量类>.I.验证client.SendRT(10047, true);
		}
	}

	private void 喊话_停止定时按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.喊话限制配置.Is开启 = false;
			Singleton<全局变量类>.I.验证client.SendRT(10018, 6, JsonConvert.SerializeObject(Singleton<全局变量类>.I.喊话限制配置, Formatting.Indented));
			Singleton<全局变量类>.I.验证client.SendRT(10047, false);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.喊话聊天配置窗口));
		this.喊话_限制开关 = new System.Windows.Forms.CheckBox();
		this.喊话_重载按钮 = new System.Windows.Forms.Button();
		this.喊话_保存按钮 = new System.Windows.Forms.Button();
		this.喊话_敏感词掉线开关 = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.喊话_喇叭等级 = new System.Windows.Forms.NumericUpDown();
		this.label6 = new System.Windows.Forms.Label();
		this.喊话_添加敏感词 = new System.Windows.Forms.TextBox();
		this.喊话_添加按钮 = new System.Windows.Forms.Button();
		this.喊话_敏感词列表 = new System.Windows.Forms.TextBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.喊话_停止定时按钮 = new System.Windows.Forms.Button();
		this.喊话_启动定时按钮 = new System.Windows.Forms.Button();
		this.label7 = new System.Windows.Forms.Label();
		this.喊话_喊话内容 = new System.Windows.Forms.TextBox();
		this.喊话_频道 = new System.Windows.Forms.ComboBox();
		this.label5 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.喊话_间隔分钟 = new System.Windows.Forms.NumericUpDown();
		this.label3 = new System.Windows.Forms.Label();
		this.喊话_结束时间 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.喊话_开始时间 = new System.Windows.Forms.TextBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.喊话_日志列表 = new System.Windows.Forms.DataGridView();
		this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.金元宝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.银元宝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		((System.ComponentModel.ISupportInitialize)this.喊话_喇叭等级).BeginInit();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.喊话_间隔分钟).BeginInit();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.喊话_日志列表).BeginInit();
		base.SuspendLayout();
		this.喊话_限制开关.AutoSize = true;
		this.喊话_限制开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.喊话_限制开关.Location = new System.Drawing.Point(12, 12);
		this.喊话_限制开关.Name = "喊话_限制开关";
		this.喊话_限制开关.Size = new System.Drawing.Size(106, 23);
		this.喊话_限制开关.TabIndex = 51;
		this.喊话_限制开关.Text = "喊话限制开关";
		this.喊话_限制开关.UseVisualStyleBackColor = true;
		this.喊话_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.喊话_重载按钮.Location = new System.Drawing.Point(141, 408);
		this.喊话_重载按钮.Name = "喊话_重载按钮";
		this.喊话_重载按钮.Size = new System.Drawing.Size(110, 30);
		this.喊话_重载按钮.TabIndex = 53;
		this.喊话_重载按钮.Text = "重载喊话配置";
		this.喊话_重载按钮.UseVisualStyleBackColor = true;
		this.喊话_重载按钮.Click += new System.EventHandler(喊话_重载按钮_Click);
		this.喊话_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.喊话_保存按钮.Location = new System.Drawing.Point(12, 408);
		this.喊话_保存按钮.Name = "喊话_保存按钮";
		this.喊话_保存按钮.Size = new System.Drawing.Size(110, 30);
		this.喊话_保存按钮.TabIndex = 52;
		this.喊话_保存按钮.Text = "保存喊话配置";
		this.喊话_保存按钮.UseVisualStyleBackColor = true;
		this.喊话_保存按钮.Click += new System.EventHandler(喊话_保存按钮_Click);
		this.喊话_敏感词掉线开关.AutoSize = true;
		this.喊话_敏感词掉线开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.喊话_敏感词掉线开关.Location = new System.Drawing.Point(124, 12);
		this.喊话_敏感词掉线开关.Name = "喊话_敏感词掉线开关";
		this.喊话_敏感词掉线开关.Size = new System.Drawing.Size(145, 23);
		this.喊话_敏感词掉线开关.TabIndex = 54;
		this.喊话_敏感词掉线开关.Text = "触发敏感词掉线开关";
		this.喊话_敏感词掉线开关.UseVisualStyleBackColor = true;
		this.label2.Location = new System.Drawing.Point(12, 56);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(106, 23);
		this.label2.TabIndex = 55;
		this.label2.Text = "使用喇叭最低等级";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.喊话_喇叭等级.Location = new System.Drawing.Point(124, 56);
		this.喊话_喇叭等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.喊话_喇叭等级.Name = "喊话_喇叭等级";
		this.喊话_喇叭等级.Size = new System.Drawing.Size(127, 23);
		this.喊话_喇叭等级.TabIndex = 56;
		this.label6.Location = new System.Drawing.Point(12, 91);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(73, 23);
		this.label6.TabIndex = 71;
		this.label6.Text = "添加敏感词";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.喊话_添加敏感词.Location = new System.Drawing.Point(91, 91);
		this.喊话_添加敏感词.Name = "喊话_添加敏感词";
		this.喊话_添加敏感词.Size = new System.Drawing.Size(101, 23);
		this.喊话_添加敏感词.TabIndex = 72;
		this.喊话_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.喊话_添加按钮.Location = new System.Drawing.Point(198, 87);
		this.喊话_添加按钮.Name = "喊话_添加按钮";
		this.喊话_添加按钮.Size = new System.Drawing.Size(53, 30);
		this.喊话_添加按钮.TabIndex = 73;
		this.喊话_添加按钮.Text = "添加";
		this.喊话_添加按钮.UseVisualStyleBackColor = true;
		this.喊话_添加按钮.Click += new System.EventHandler(喊话_添加按钮_Click);
		this.喊话_敏感词列表.Location = new System.Drawing.Point(12, 120);
		this.喊话_敏感词列表.Multiline = true;
		this.喊话_敏感词列表.Name = "喊话_敏感词列表";
		this.喊话_敏感词列表.Size = new System.Drawing.Size(239, 282);
		this.喊话_敏感词列表.TabIndex = 74;
		this.groupBox1.Controls.Add(this.喊话_停止定时按钮);
		this.groupBox1.Controls.Add(this.喊话_启动定时按钮);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.喊话_喊话内容);
		this.groupBox1.Controls.Add(this.喊话_频道);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.喊话_间隔分钟);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.喊话_结束时间);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.喊话_开始时间);
		this.groupBox1.Location = new System.Drawing.Point(275, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(281, 426);
		this.groupBox1.TabIndex = 75;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "定时喊话配置";
		this.喊话_停止定时按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.喊话_停止定时按钮.Location = new System.Drawing.Point(153, 390);
		this.喊话_停止定时按钮.Name = "喊话_停止定时按钮";
		this.喊话_停止定时按钮.Size = new System.Drawing.Size(110, 30);
		this.喊话_停止定时按钮.TabIndex = 84;
		this.喊话_停止定时按钮.Text = "停止喊话规则";
		this.喊话_停止定时按钮.UseVisualStyleBackColor = true;
		this.喊话_停止定时按钮.Click += new System.EventHandler(喊话_停止定时按钮_Click);
		this.喊话_启动定时按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.喊话_启动定时按钮.Location = new System.Drawing.Point(24, 390);
		this.喊话_启动定时按钮.Name = "喊话_启动定时按钮";
		this.喊话_启动定时按钮.Size = new System.Drawing.Size(110, 30);
		this.喊话_启动定时按钮.TabIndex = 83;
		this.喊话_启动定时按钮.Text = "启动喊话规则";
		this.喊话_启动定时按钮.UseVisualStyleBackColor = true;
		this.喊话_启动定时按钮.Click += new System.EventHandler(喊话_启动定时按钮_Click);
		this.label7.Location = new System.Drawing.Point(6, 125);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(60, 23);
		this.label7.TabIndex = 81;
		this.label7.Text = "喊话内容";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.喊话_喊话内容.Location = new System.Drawing.Point(72, 125);
		this.喊话_喊话内容.Multiline = true;
		this.喊话_喊话内容.Name = "喊话_喊话内容";
		this.喊话_喊话内容.Size = new System.Drawing.Size(203, 259);
		this.喊话_喊话内容.TabIndex = 82;
		this.喊话_频道.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.喊话_频道.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.喊话_频道.FormattingEnabled = true;
		this.喊话_频道.Items.AddRange(new object[13]
		{
			"世界", "谣言", "系统", "系统信箱", "门派", "信息", "交易", "客服", "喇叭", "问道",
			"问道维护", "问道活动", "横批公告"
		});
		this.喊话_频道.Location = new System.Drawing.Point(186, 88);
		this.喊话_频道.Name = "喊话_频道";
		this.喊话_频道.Size = new System.Drawing.Size(89, 25);
		this.喊话_频道.TabIndex = 80;
		this.label5.Location = new System.Drawing.Point(128, 89);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(60, 23);
		this.label5.TabIndex = 79;
		this.label5.Text = "喊话频道";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label4.Location = new System.Drawing.Point(6, 89);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 77;
		this.label4.Text = "间隔分钟";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.喊话_间隔分钟.Location = new System.Drawing.Point(72, 89);
		this.喊话_间隔分钟.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.喊话_间隔分钟.Name = "喊话_间隔分钟";
		this.喊话_间隔分钟.Size = new System.Drawing.Size(50, 23);
		this.喊话_间隔分钟.TabIndex = 78;
		this.label3.Location = new System.Drawing.Point(6, 50);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(60, 23);
		this.label3.TabIndex = 75;
		this.label3.Text = "结束时间";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.喊话_结束时间.Location = new System.Drawing.Point(72, 50);
		this.喊话_结束时间.Name = "喊话_结束时间";
		this.喊话_结束时间.Size = new System.Drawing.Size(203, 23);
		this.喊话_结束时间.TabIndex = 76;
		this.喊话_结束时间.Text = "2022-3-29 17:26:56";
		this.label1.Location = new System.Drawing.Point(6, 19);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 23);
		this.label1.TabIndex = 73;
		this.label1.Text = "开始时间";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.喊话_开始时间.Location = new System.Drawing.Point(72, 19);
		this.喊话_开始时间.Name = "喊话_开始时间";
		this.喊话_开始时间.Size = new System.Drawing.Size(203, 23);
		this.喊话_开始时间.TabIndex = 74;
		this.喊话_开始时间.Text = "2022-3-29 17:26:56";
		this.groupBox2.Controls.Add(this.喊话_日志列表);
		this.groupBox2.Location = new System.Drawing.Point(562, 12);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(447, 426);
		this.groupBox2.TabIndex = 76;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "触发敏感词日志";
		this.喊话_日志列表.AllowUserToAddRows = false;
		this.喊话_日志列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.喊话_日志列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.喊话_日志列表.BackgroundColor = System.Drawing.Color.White;
		this.喊话_日志列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.喊话_日志列表.Columns.AddRange(this.类型, this.名字, this.金元宝, this.银元宝);
		this.喊话_日志列表.Location = new System.Drawing.Point(6, 22);
		this.喊话_日志列表.MultiSelect = false;
		this.喊话_日志列表.Name = "喊话_日志列表";
		this.喊话_日志列表.ReadOnly = true;
		this.喊话_日志列表.RowHeadersVisible = false;
		this.喊话_日志列表.RowTemplate.Height = 25;
		this.喊话_日志列表.Size = new System.Drawing.Size(435, 398);
		this.喊话_日志列表.TabIndex = 79;
		this.类型.HeaderText = "账号";
		this.类型.Name = "类型";
		this.类型.ReadOnly = true;
		this.类型.Width = 80;
		this.名字.HeaderText = "昵称";
		this.名字.Name = "名字";
		this.名字.ReadOnly = true;
		this.名字.Width = 150;
		this.金元宝.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
		this.金元宝.HeaderText = "时间";
		this.金元宝.Name = "金元宝";
		this.金元宝.ReadOnly = true;
		this.金元宝.Width = 57;
		this.银元宝.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
		this.银元宝.HeaderText = "发言内容";
		this.银元宝.Name = "银元宝";
		this.银元宝.ReadOnly = true;
		this.银元宝.Width = 81;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(1021, 450);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.喊话_敏感词列表);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.喊话_添加敏感词);
		base.Controls.Add(this.喊话_添加按钮);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.喊话_喇叭等级);
		base.Controls.Add(this.喊话_敏感词掉线开关);
		base.Controls.Add(this.喊话_限制开关);
		base.Controls.Add(this.喊话_重载按钮);
		base.Controls.Add(this.喊话_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "喊话聊天配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "喊话聊天配置窗口";
		base.Load += new System.EventHandler(喊话聊天配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.喊话_喇叭等级).EndInit();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.喊话_间隔分钟).EndInit();
		this.groupBox2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.喊话_日志列表).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
