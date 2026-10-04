using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Net.Share;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 试道大会配置窗口 : Form
{
	private static 试道大会配置窗口 i;

	private IContainer components;

	private CheckBox 试道_开关;

	private Button 试道_重载按钮;

	private Button 试道_保存按钮;

	private DataGridView 试道_角色列表;

	private TextBox textBox5;

	private NumericUpDown 试道_参与奖数量;

	private ComboBox 试道_参与奖类型;

	private TextBox 试道_参与奖名字;

	private TextBox textBox1;

	private NumericUpDown 试道_第一名数量;

	private ComboBox 试道_第一名类型;

	private TextBox 试道_第一名名字;

	private TextBox textBox3;

	private NumericUpDown 试道_第二名数量;

	private ComboBox 试道_第二名类型;

	private TextBox 试道_第二名名字;

	private TextBox textBox6;

	private NumericUpDown 试道_第三名数量;

	private ComboBox 试道_第三名类型;

	private TextBox 试道_第三名名字;

	private DataGridViewTextBoxColumn 账号;

	private DataGridViewTextBoxColumn 昵称;

	private DataGridViewTextBoxColumn 等级;

	private DataGridViewTextBoxColumn 金元宝;

	private DataGridViewTextBoxColumn 银元宝;

	private Button 试道_刷新按钮;

	private Label 试道_总人数;

	private TextBox textBox8;

	private NumericUpDown 试道_发送金元宝;

	private TextBox textBox9;

	private NumericUpDown 试道_发送银元宝;

	private Button 试道_发送按钮;

	private Label label1;

	private Label label2;

	private ComboBox 试道_队伍最高人数;

	public static 试道大会配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 试道大会配置窗口();
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

	public 试道大会配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 试道大会配置窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		试道_重载按钮_Click(sender, e);
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 45)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			试道_开关.Checked = Singleton<全局变量类>.I.试道大会配置.功能开关;
			试道_参与奖类型.Text = Singleton<全局变量类>.I.试道大会配置.参与奖励.奖励类型.ToString();
			试道_参与奖名字.Text = ((Singleton<全局变量类>.I.试道大会配置.参与奖励.奖励类型 != AllEnums.数值Type.道具) ? Singleton<全局变量类>.I.试道大会配置.参与奖励.奖励类型.ToString() : Singleton<全局变量类>.I.试道大会配置.参与奖励.奖励名字);
			试道_参与奖数量.Value = Singleton<全局变量类>.I.试道大会配置.参与奖励.获得数量;
			试道_第一名类型.Text = Singleton<全局变量类>.I.试道大会配置.第一奖励.奖励类型.ToString();
			试道_第一名名字.Text = ((Singleton<全局变量类>.I.试道大会配置.第一奖励.奖励类型 != AllEnums.数值Type.道具) ? Singleton<全局变量类>.I.试道大会配置.第一奖励.奖励类型.ToString() : Singleton<全局变量类>.I.试道大会配置.第一奖励.奖励名字);
			试道_第一名数量.Value = Singleton<全局变量类>.I.试道大会配置.第一奖励.获得数量;
			试道_第二名类型.Text = Singleton<全局变量类>.I.试道大会配置.第二奖励.奖励类型.ToString();
			试道_第二名名字.Text = ((Singleton<全局变量类>.I.试道大会配置.第二奖励.奖励类型 != AllEnums.数值Type.道具) ? Singleton<全局变量类>.I.试道大会配置.第二奖励.奖励类型.ToString() : Singleton<全局变量类>.I.试道大会配置.第二奖励.奖励名字);
			试道_第二名数量.Value = Singleton<全局变量类>.I.试道大会配置.第二奖励.获得数量;
			试道_第三名类型.Text = Singleton<全局变量类>.I.试道大会配置.第三奖励.奖励类型.ToString();
			试道_第三名名字.Text = ((Singleton<全局变量类>.I.试道大会配置.第三奖励.奖励类型 != AllEnums.数值Type.道具) ? Singleton<全局变量类>.I.试道大会配置.第三奖励.奖励类型.ToString() : Singleton<全局变量类>.I.试道大会配置.第三奖励.奖励名字);
			试道_第三名数量.Value = Singleton<全局变量类>.I.试道大会配置.第三奖励.获得数量;
			试道_队伍最高人数.Text = Singleton<全局变量类>.I.试道大会配置.队伍最高人数.ToString();
			if (string.IsNullOrWhiteSpace(试道_队伍最高人数.Text))
			{
				试道_队伍最高人数.Text = "5";
			}
			试道_总人数.Text = string.Empty;
			试道_角色列表.Rows.Clear();
		});
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.试道大会配置.功能开关 = 试道_开关.Checked;
			Enum.TryParse<AllEnums.数值Type>(试道_参与奖类型.Text, out Singleton<全局变量类>.I.试道大会配置.参与奖励.奖励类型);
			Singleton<全局变量类>.I.试道大会配置.参与奖励.奖励名字 = ((Singleton<全局变量类>.I.试道大会配置.参与奖励.奖励类型 != AllEnums.数值Type.道具) ? Singleton<全局变量类>.I.试道大会配置.参与奖励.奖励类型.ToString() : 试道_参与奖名字.Text);
			Singleton<全局变量类>.I.试道大会配置.参与奖励.获得数量 = (int)试道_参与奖数量.Value;
			Enum.TryParse<AllEnums.数值Type>(试道_第一名类型.Text, out Singleton<全局变量类>.I.试道大会配置.第一奖励.奖励类型);
			Singleton<全局变量类>.I.试道大会配置.第一奖励.奖励名字 = ((Singleton<全局变量类>.I.试道大会配置.第一奖励.奖励类型 != AllEnums.数值Type.道具) ? Singleton<全局变量类>.I.试道大会配置.第一奖励.奖励类型.ToString() : 试道_第一名名字.Text);
			Singleton<全局变量类>.I.试道大会配置.第一奖励.获得数量 = (int)试道_第一名数量.Value;
			Enum.TryParse<AllEnums.数值Type>(试道_第二名类型.Text, out Singleton<全局变量类>.I.试道大会配置.第二奖励.奖励类型);
			Singleton<全局变量类>.I.试道大会配置.第二奖励.奖励名字 = ((Singleton<全局变量类>.I.试道大会配置.第二奖励.奖励类型 != AllEnums.数值Type.道具) ? Singleton<全局变量类>.I.试道大会配置.第二奖励.奖励类型.ToString() : 试道_第二名名字.Text);
			Singleton<全局变量类>.I.试道大会配置.第二奖励.获得数量 = (int)试道_第二名数量.Value;
			Enum.TryParse<AllEnums.数值Type>(试道_第三名类型.Text, out Singleton<全局变量类>.I.试道大会配置.第三奖励.奖励类型);
			Singleton<全局变量类>.I.试道大会配置.第三奖励.奖励名字 = ((Singleton<全局变量类>.I.试道大会配置.第三奖励.奖励类型 != AllEnums.数值Type.道具) ? Singleton<全局变量类>.I.试道大会配置.第三奖励.奖励类型.ToString() : 试道_第三名名字.Text);
			Singleton<全局变量类>.I.试道大会配置.第三奖励.获得数量 = (int)试道_第三名数量.Value;
			Singleton<全局变量类>.I.试道大会配置.队伍最高人数 = Convert.ToInt32(试道_队伍最高人数.Text);
		}
	}

	private void 试道_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 45, JsonConvert.SerializeObject(Singleton<全局变量类>.I.试道大会配置, Formatting.Indented));
		}
	}

	private void 试道_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 45);
		}
	}

	private void 试道_刷新按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			试道_角色列表.Rows.Clear();
			Singleton<全局变量类>.I.验证client.SendRT(10044, true);
		}
	}

	[Rpc(hash = 10073)]
	private void 返回刷新试道场内信息(string 角色列表)
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(角色列表))
		{
			试道_总人数.Text = "场内总人数：0";
			MessageBox.Show("试道场内并无任何玩家！");
			return;
		}
		试道_角色列表.Invoke((MethodInvoker)delegate
		{
			string[] array = 角色列表.Split("|");
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split("=");
				if (array2.Length == 5)
				{
					试道_角色列表.Rows.Add(array2[0], array2[1], array2[2], array2[3], array2[4]);
				}
			}
		});
		试道_总人数.Text = $"场内总人数：{试道_角色列表.Rows.Count}";
	}

	private void 试道_发送按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && (!(试道_发送金元宝.Value <= 0m) || !(试道_发送银元宝.Value <= 0m)))
		{
			Singleton<全局变量类>.I.验证client.SendRT(10045, (int)试道_发送金元宝.Value, (int)试道_发送银元宝.Value);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.试道大会配置窗口));
		this.试道_开关 = new System.Windows.Forms.CheckBox();
		this.试道_重载按钮 = new System.Windows.Forms.Button();
		this.试道_保存按钮 = new System.Windows.Forms.Button();
		this.试道_角色列表 = new System.Windows.Forms.DataGridView();
		this.账号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.昵称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.等级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.金元宝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.银元宝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.试道_参与奖数量 = new System.Windows.Forms.NumericUpDown();
		this.试道_参与奖类型 = new System.Windows.Forms.ComboBox();
		this.试道_参与奖名字 = new System.Windows.Forms.TextBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.试道_第一名数量 = new System.Windows.Forms.NumericUpDown();
		this.试道_第一名类型 = new System.Windows.Forms.ComboBox();
		this.试道_第一名名字 = new System.Windows.Forms.TextBox();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.试道_第二名数量 = new System.Windows.Forms.NumericUpDown();
		this.试道_第二名类型 = new System.Windows.Forms.ComboBox();
		this.试道_第二名名字 = new System.Windows.Forms.TextBox();
		this.textBox6 = new System.Windows.Forms.TextBox();
		this.试道_第三名数量 = new System.Windows.Forms.NumericUpDown();
		this.试道_第三名类型 = new System.Windows.Forms.ComboBox();
		this.试道_第三名名字 = new System.Windows.Forms.TextBox();
		this.试道_刷新按钮 = new System.Windows.Forms.Button();
		this.试道_总人数 = new System.Windows.Forms.Label();
		this.textBox8 = new System.Windows.Forms.TextBox();
		this.试道_发送金元宝 = new System.Windows.Forms.NumericUpDown();
		this.textBox9 = new System.Windows.Forms.TextBox();
		this.试道_发送银元宝 = new System.Windows.Forms.NumericUpDown();
		this.试道_发送按钮 = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.试道_队伍最高人数 = new System.Windows.Forms.ComboBox();
		((System.ComponentModel.ISupportInitialize)this.试道_角色列表).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.试道_参与奖数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.试道_第一名数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.试道_第二名数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.试道_第三名数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.试道_发送金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.试道_发送银元宝).BeginInit();
		base.SuspendLayout();
		this.试道_开关.AutoSize = true;
		this.试道_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.试道_开关.Location = new System.Drawing.Point(12, 12);
		this.试道_开关.Name = "试道_开关";
		this.试道_开关.Size = new System.Drawing.Size(132, 23);
		this.试道_开关.TabIndex = 129;
		this.试道_开关.Text = "试道大会功能开关";
		this.试道_开关.UseVisualStyleBackColor = true;
		this.试道_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.试道_重载按钮.Location = new System.Drawing.Point(256, 8);
		this.试道_重载按钮.Name = "试道_重载按钮";
		this.试道_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.试道_重载按钮.TabIndex = 131;
		this.试道_重载按钮.Text = "重载配置";
		this.试道_重载按钮.UseVisualStyleBackColor = true;
		this.试道_重载按钮.Click += new System.EventHandler(试道_重载按钮_Click);
		this.试道_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.试道_保存按钮.Location = new System.Drawing.Point(150, 8);
		this.试道_保存按钮.Name = "试道_保存按钮";
		this.试道_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.试道_保存按钮.TabIndex = 130;
		this.试道_保存按钮.Text = "保存配置";
		this.试道_保存按钮.UseVisualStyleBackColor = true;
		this.试道_保存按钮.Click += new System.EventHandler(试道_保存按钮_Click);
		this.试道_角色列表.AllowUserToAddRows = false;
		this.试道_角色列表.AllowUserToDeleteRows = false;
		this.试道_角色列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.试道_角色列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.试道_角色列表.BackgroundColor = System.Drawing.Color.White;
		this.试道_角色列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.试道_角色列表.Columns.AddRange(this.账号, this.昵称, this.等级, this.金元宝, this.银元宝);
		this.试道_角色列表.Location = new System.Drawing.Point(12, 264);
		this.试道_角色列表.MultiSelect = false;
		this.试道_角色列表.Name = "试道_角色列表";
		this.试道_角色列表.ReadOnly = true;
		this.试道_角色列表.RowHeadersVisible = false;
		this.试道_角色列表.RowTemplate.Height = 25;
		this.试道_角色列表.Size = new System.Drawing.Size(398, 233);
		this.试道_角色列表.TabIndex = 132;
		this.账号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.账号.Frozen = true;
		this.账号.HeaderText = "账号";
		this.账号.MinimumWidth = 60;
		this.账号.Name = "账号";
		this.账号.ReadOnly = true;
		this.账号.Width = 60;
		this.昵称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.昵称.Frozen = true;
		this.昵称.HeaderText = "昵称";
		this.昵称.MinimumWidth = 80;
		this.昵称.Name = "昵称";
		this.昵称.ReadOnly = true;
		this.昵称.Width = 80;
		this.等级.Frozen = true;
		this.等级.HeaderText = "等级";
		this.等级.MinimumWidth = 80;
		this.等级.Name = "等级";
		this.等级.ReadOnly = true;
		this.等级.Width = 80;
		this.金元宝.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.金元宝.Frozen = true;
		this.金元宝.HeaderText = "金元宝";
		this.金元宝.MinimumWidth = 70;
		this.金元宝.Name = "金元宝";
		this.金元宝.ReadOnly = true;
		this.金元宝.Width = 70;
		this.银元宝.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.银元宝.Frozen = true;
		this.银元宝.HeaderText = "银元宝";
		this.银元宝.MinimumWidth = 70;
		this.银元宝.Name = "银元宝";
		this.银元宝.ReadOnly = true;
		this.银元宝.Width = 70;
		this.textBox5.Location = new System.Drawing.Point(12, 87);
		this.textBox5.Name = "textBox5";
		this.textBox5.ReadOnly = true;
		this.textBox5.Size = new System.Drawing.Size(80, 23);
		this.textBox5.TabIndex = 154;
		this.textBox5.Text = "试道参与奖励";
		this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.试道_参与奖数量.Location = new System.Drawing.Point(310, 87);
		this.试道_参与奖数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.试道_参与奖数量.Name = "试道_参与奖数量";
		this.试道_参与奖数量.Size = new System.Drawing.Size(100, 23);
		this.试道_参与奖数量.TabIndex = 153;
		this.试道_参与奖类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.试道_参与奖类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.试道_参与奖类型.FormattingEnabled = true;
		this.试道_参与奖类型.Items.AddRange(new object[7] { "金元宝", "银元宝", "南极点", "累充点", "奇宝点", "金钱", "道具" });
		this.试道_参与奖类型.Location = new System.Drawing.Point(98, 86);
		this.试道_参与奖类型.Name = "试道_参与奖类型";
		this.试道_参与奖类型.Size = new System.Drawing.Size(100, 25);
		this.试道_参与奖类型.TabIndex = 152;
		this.试道_参与奖名字.Location = new System.Drawing.Point(204, 87);
		this.试道_参与奖名字.Name = "试道_参与奖名字";
		this.试道_参与奖名字.Size = new System.Drawing.Size(100, 23);
		this.试道_参与奖名字.TabIndex = 151;
		this.textBox1.Location = new System.Drawing.Point(12, 117);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(80, 23);
		this.textBox1.TabIndex = 158;
		this.textBox1.Text = "试道第一奖励";
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.试道_第一名数量.Location = new System.Drawing.Point(310, 117);
		this.试道_第一名数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.试道_第一名数量.Name = "试道_第一名数量";
		this.试道_第一名数量.Size = new System.Drawing.Size(100, 23);
		this.试道_第一名数量.TabIndex = 157;
		this.试道_第一名类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.试道_第一名类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.试道_第一名类型.FormattingEnabled = true;
		this.试道_第一名类型.Items.AddRange(new object[7] { "金元宝", "银元宝", "南极点", "累充点", "奇宝点", "金钱", "道具" });
		this.试道_第一名类型.Location = new System.Drawing.Point(98, 116);
		this.试道_第一名类型.Name = "试道_第一名类型";
		this.试道_第一名类型.Size = new System.Drawing.Size(100, 25);
		this.试道_第一名类型.TabIndex = 156;
		this.试道_第一名名字.Location = new System.Drawing.Point(204, 117);
		this.试道_第一名名字.Name = "试道_第一名名字";
		this.试道_第一名名字.Size = new System.Drawing.Size(100, 23);
		this.试道_第一名名字.TabIndex = 155;
		this.textBox3.Location = new System.Drawing.Point(12, 146);
		this.textBox3.Name = "textBox3";
		this.textBox3.ReadOnly = true;
		this.textBox3.Size = new System.Drawing.Size(80, 23);
		this.textBox3.TabIndex = 162;
		this.textBox3.Text = "试道第二奖励";
		this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.试道_第二名数量.Location = new System.Drawing.Point(310, 146);
		this.试道_第二名数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.试道_第二名数量.Name = "试道_第二名数量";
		this.试道_第二名数量.Size = new System.Drawing.Size(100, 23);
		this.试道_第二名数量.TabIndex = 161;
		this.试道_第二名类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.试道_第二名类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.试道_第二名类型.FormattingEnabled = true;
		this.试道_第二名类型.Items.AddRange(new object[7] { "金元宝", "银元宝", "南极点", "累充点", "奇宝点", "金钱", "道具" });
		this.试道_第二名类型.Location = new System.Drawing.Point(98, 145);
		this.试道_第二名类型.Name = "试道_第二名类型";
		this.试道_第二名类型.Size = new System.Drawing.Size(100, 25);
		this.试道_第二名类型.TabIndex = 160;
		this.试道_第二名名字.Location = new System.Drawing.Point(204, 146);
		this.试道_第二名名字.Name = "试道_第二名名字";
		this.试道_第二名名字.Size = new System.Drawing.Size(100, 23);
		this.试道_第二名名字.TabIndex = 159;
		this.textBox6.Location = new System.Drawing.Point(12, 176);
		this.textBox6.Name = "textBox6";
		this.textBox6.ReadOnly = true;
		this.textBox6.Size = new System.Drawing.Size(80, 23);
		this.textBox6.TabIndex = 166;
		this.textBox6.Text = "试道第三奖励";
		this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.试道_第三名数量.Location = new System.Drawing.Point(310, 176);
		this.试道_第三名数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.试道_第三名数量.Name = "试道_第三名数量";
		this.试道_第三名数量.Size = new System.Drawing.Size(100, 23);
		this.试道_第三名数量.TabIndex = 165;
		this.试道_第三名类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.试道_第三名类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.试道_第三名类型.FormattingEnabled = true;
		this.试道_第三名类型.Items.AddRange(new object[7] { "金元宝", "银元宝", "南极点", "累充点", "奇宝点", "金钱", "道具" });
		this.试道_第三名类型.Location = new System.Drawing.Point(98, 175);
		this.试道_第三名类型.Name = "试道_第三名类型";
		this.试道_第三名类型.Size = new System.Drawing.Size(100, 25);
		this.试道_第三名类型.TabIndex = 164;
		this.试道_第三名名字.Location = new System.Drawing.Point(204, 176);
		this.试道_第三名名字.Name = "试道_第三名名字";
		this.试道_第三名名字.Size = new System.Drawing.Size(100, 23);
		this.试道_第三名名字.TabIndex = 163;
		this.试道_刷新按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.试道_刷新按钮.Location = new System.Drawing.Point(12, 209);
		this.试道_刷新按钮.Name = "试道_刷新按钮";
		this.试道_刷新按钮.Size = new System.Drawing.Size(132, 25);
		this.试道_刷新按钮.TabIndex = 167;
		this.试道_刷新按钮.Text = "刷新试道场内数据";
		this.试道_刷新按钮.UseVisualStyleBackColor = true;
		this.试道_刷新按钮.Click += new System.EventHandler(试道_刷新按钮_Click);
		this.试道_总人数.ForeColor = System.Drawing.Color.Blue;
		this.试道_总人数.Location = new System.Drawing.Point(12, 238);
		this.试道_总人数.Name = "试道_总人数";
		this.试道_总人数.Size = new System.Drawing.Size(132, 23);
		this.试道_总人数.TabIndex = 168;
		this.试道_总人数.Text = "场内总人数：0";
		this.试道_总人数.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.textBox8.Location = new System.Drawing.Point(12, 503);
		this.textBox8.Name = "textBox8";
		this.textBox8.ReadOnly = true;
		this.textBox8.Size = new System.Drawing.Size(50, 23);
		this.textBox8.TabIndex = 170;
		this.textBox8.Text = "金元宝";
		this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.试道_发送金元宝.Location = new System.Drawing.Point(63, 503);
		this.试道_发送金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.试道_发送金元宝.Name = "试道_发送金元宝";
		this.试道_发送金元宝.Size = new System.Drawing.Size(90, 23);
		this.试道_发送金元宝.TabIndex = 169;
		this.textBox9.Location = new System.Drawing.Point(155, 503);
		this.textBox9.Name = "textBox9";
		this.textBox9.ReadOnly = true;
		this.textBox9.Size = new System.Drawing.Size(50, 23);
		this.textBox9.TabIndex = 172;
		this.textBox9.Text = "银元宝";
		this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.试道_发送银元宝.Location = new System.Drawing.Point(207, 503);
		this.试道_发送银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.试道_发送银元宝.Name = "试道_发送银元宝";
		this.试道_发送银元宝.Size = new System.Drawing.Size(90, 23);
		this.试道_发送银元宝.TabIndex = 171;
		this.试道_发送按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.试道_发送按钮.Location = new System.Drawing.Point(310, 502);
		this.试道_发送按钮.Name = "试道_发送按钮";
		this.试道_发送按钮.Size = new System.Drawing.Size(100, 25);
		this.试道_发送按钮.TabIndex = 173;
		this.试道_发送按钮.Text = "发送全部玩家";
		this.试道_发送按钮.UseVisualStyleBackColor = true;
		this.试道_发送按钮.Click += new System.EventHandler(试道_发送按钮_Click);
		this.label1.ForeColor = System.Drawing.Color.Red;
		this.label1.Location = new System.Drawing.Point(12, 41);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(215, 42);
		this.label1.TabIndex = 174;
		this.label1.Text = "参与奖：巅峰对决开始时系统自动发送\r\n前三名：在试道大会结束后自动发放";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label2.ForeColor = System.Drawing.Color.Red;
		this.label2.Location = new System.Drawing.Point(150, 237);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(164, 23);
		this.label2.TabIndex = 175;
		this.label2.Text = "设置试道队伍组队最高人数";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.试道_队伍最高人数.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.试道_队伍最高人数.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.试道_队伍最高人数.FormattingEnabled = true;
		this.试道_队伍最高人数.Items.AddRange(new object[5] { "1", "2", "3", "4", "5" });
		this.试道_队伍最高人数.Location = new System.Drawing.Point(320, 236);
		this.试道_队伍最高人数.Name = "试道_队伍最高人数";
		this.试道_队伍最高人数.Size = new System.Drawing.Size(90, 25);
		this.试道_队伍最高人数.TabIndex = 176;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(428, 539);
		base.Controls.Add(this.试道_队伍最高人数);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.试道_发送按钮);
		base.Controls.Add(this.textBox9);
		base.Controls.Add(this.试道_发送银元宝);
		base.Controls.Add(this.textBox8);
		base.Controls.Add(this.试道_发送金元宝);
		base.Controls.Add(this.试道_总人数);
		base.Controls.Add(this.试道_刷新按钮);
		base.Controls.Add(this.textBox6);
		base.Controls.Add(this.试道_第三名数量);
		base.Controls.Add(this.试道_第三名类型);
		base.Controls.Add(this.试道_第三名名字);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.试道_第二名数量);
		base.Controls.Add(this.试道_第二名类型);
		base.Controls.Add(this.试道_第二名名字);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.试道_第一名数量);
		base.Controls.Add(this.试道_第一名类型);
		base.Controls.Add(this.试道_第一名名字);
		base.Controls.Add(this.textBox5);
		base.Controls.Add(this.试道_参与奖数量);
		base.Controls.Add(this.试道_参与奖类型);
		base.Controls.Add(this.试道_参与奖名字);
		base.Controls.Add(this.试道_角色列表);
		base.Controls.Add(this.试道_开关);
		base.Controls.Add(this.试道_重载按钮);
		base.Controls.Add(this.试道_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "试道大会配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "试道大会配置窗口";
		base.Load += new System.EventHandler(试道大会配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.试道_角色列表).EndInit();
		((System.ComponentModel.ISupportInitialize)this.试道_参与奖数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.试道_第一名数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.试道_第二名数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.试道_第三名数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.试道_发送金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.试道_发送银元宝).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
