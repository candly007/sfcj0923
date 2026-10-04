using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 在线抽奖配置窗口 : Form
{
	private static 在线抽奖配置窗口 i;

	private IContainer components;

	private CheckBox 抽奖_开关;

	private Button 抽奖_重载按钮;

	private Button 抽奖_保存按钮;

	private TextBox 地狱道_名字;

	private TextBox 抽奖_指令;

	private TextBox textBox5;

	private NumericUpDown 抽奖_花费价格;

	private ComboBox 抽奖_花费类型;

	private TextBox textBox1;

	private NumericUpDown 抽奖_保底次数;

	private DataGridView 抽奖_奖励列表;

	private DataGridViewComboBoxColumn 类型;

	private DataGridViewTextBoxColumn 奖励名字;

	private DataGridViewCheckBoxColumn Is出谣言;

	private DataGridViewCheckBoxColumn 保底奖励;

	private DataGridViewTextBoxColumn 获得几率;

	private DataGridViewTextBoxColumn 获得数量;

	private DataGridViewCheckBoxColumn 限制数量;

	private DataGridViewTextBoxColumn 已抽出数量;

	private DataGridViewTextBoxColumn 可抽出数量;

	private TextBox textBox2;

	private Button 抽奖_重置按钮;

	public static 在线抽奖配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 在线抽奖配置窗口();
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

	public 在线抽奖配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 在线抽奖配置窗口_Load(object sender, EventArgs e)
	{
		抽奖_奖励列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 删除事件回调);
		((DataGridViewComboBoxColumn)抽奖_奖励列表.Columns[0]).DataSource = new List<string>
		{
			"等级", "道行", "经验", "声望", "战绩", "金元宝", "银元宝", "金钱", "代金券", "累充点",
			"南极点", "道具"
		};
		抽奖_奖励列表.DataError += delegate
		{
		};
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		抽奖_重载按钮_Click(sender, e);
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 抽奖_奖励列表.CurrentRow != null)
		{
			int index = 抽奖_奖励列表.CurrentRow.Index;
			if (index >= 0)
			{
				抽奖_奖励列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 43)
		{
			return;
		}
		抽奖_开关.Checked = Singleton<全局变量类>.I.在线抽奖配置.功能开关;
		抽奖_指令.Text = Singleton<全局变量类>.I.在线抽奖配置.触发指令;
		抽奖_花费类型.Text = Singleton<全局变量类>.I.在线抽奖配置.消耗类型.ToString();
		抽奖_花费价格.Value = Singleton<全局变量类>.I.在线抽奖配置.消耗数值;
		抽奖_保底次数.Value = Singleton<全局变量类>.I.在线抽奖配置.累计出保底次数;
		抽奖_奖励列表.Invoke((MethodInvoker)delegate
		{
			抽奖_奖励列表.Rows.Clear();
			Singleton<全局变量类>.I.在线抽奖配置.奖池列表.Sort();
			for (int i = 0; i < Singleton<全局变量类>.I.在线抽奖配置.奖池列表.Count; i++)
			{
				在线奖池配置类 在线奖池配置类2 = Singleton<全局变量类>.I.在线抽奖配置.奖池列表[i];
				抽奖_奖励列表.Rows.Add(在线奖池配置类2.类型, (在线奖池配置类2.类型 != AllEnums.数值Type.道具) ? 在线奖池配置类2.类型.ToString() : 在线奖池配置类2.奖励名字, 在线奖池配置类2.是否出谣言, 在线奖池配置类2.是否为保底奖励, 在线奖池配置类2.获得几率, 在线奖池配置类2.获得数量, 在线奖池配置类2.是否限制数量, 在线奖池配置类2.已抽出数量, 在线奖池配置类2.可抽出数量);
				((DataGridViewComboBoxCell)抽奖_奖励列表.Rows[i].Cells[0]).Value = 在线奖池配置类2.类型.ToString();
			}
		});
	}

	private void 配置变量赋值(bool 是否重置 = false)
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		try
		{
			Singleton<全局变量类>.I.在线抽奖配置.功能开关 = 抽奖_开关.Checked;
			Singleton<全局变量类>.I.在线抽奖配置.触发指令 = 抽奖_指令.Text;
			Enum.TryParse<AllEnums.数值Type>(抽奖_花费类型.Text, out Singleton<全局变量类>.I.在线抽奖配置.消耗类型);
			Singleton<全局变量类>.I.在线抽奖配置.消耗数值 = Convert.ToInt32(抽奖_花费价格.Value);
			Singleton<全局变量类>.I.在线抽奖配置.累计出保底次数 = Convert.ToInt32(抽奖_保底次数.Value);
			Singleton<全局变量类>.I.在线抽奖配置.奖池列表.Clear();
			for (int i = 0; i < 抽奖_奖励列表.Rows.Count; i++)
			{
				DataGridViewCellCollection cells = 抽奖_奖励列表.Rows[i].Cells;
				if (cells[0].Value != null && !string.IsNullOrWhiteSpace(Convert.ToString(cells[0].Value)))
				{
					在线奖池配置类 在线奖池配置类2 = new 在线奖池配置类();
					if (Enum.TryParse<AllEnums.数值Type>(cells[0].Value.ToString(), out 在线奖池配置类2.类型))
					{
						在线奖池配置类2.奖励名字 = ((在线奖池配置类2.类型 != AllEnums.数值Type.道具) ? 在线奖池配置类2.类型.ToString() : Convert.ToString(cells[1].Value));
						在线奖池配置类2.是否出谣言 = Convert.ToBoolean(cells[2].Value);
						在线奖池配置类2.是否为保底奖励 = Convert.ToBoolean(cells[3].Value);
						在线奖池配置类2.获得几率 = Convert.ToInt32(cells[4].Value);
						在线奖池配置类2.获得数量 = Convert.ToInt32(cells[5].Value);
						在线奖池配置类2.是否限制数量 = Convert.ToBoolean(cells[6].Value);
						在线奖池配置类2.已抽出数量 = ((!是否重置) ? Convert.ToInt32(cells[7].Value) : 0);
						在线奖池配置类2.可抽出数量 = Convert.ToInt32(cells[8].Value);
						Singleton<全局变量类>.I.在线抽奖配置.奖池列表.Add(在线奖池配置类2);
					}
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show($"错误：{ex.Message}（{ex.StackTrace}）");
		}
	}

	private void 抽奖_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 43, JsonConvert.SerializeObject(Singleton<全局变量类>.I.在线抽奖配置, Formatting.Indented));
		}
	}

	private void 抽奖_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 43);
		}
	}

	private void 抽奖_重置按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值(是否重置: true);
			Singleton<全局变量类>.I.验证client.SendRT(10018, 43, JsonConvert.SerializeObject(Singleton<全局变量类>.I.在线抽奖配置, Formatting.Indented));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.在线抽奖配置窗口));
		this.抽奖_开关 = new System.Windows.Forms.CheckBox();
		this.抽奖_重载按钮 = new System.Windows.Forms.Button();
		this.抽奖_保存按钮 = new System.Windows.Forms.Button();
		this.地狱道_名字 = new System.Windows.Forms.TextBox();
		this.抽奖_指令 = new System.Windows.Forms.TextBox();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.抽奖_花费价格 = new System.Windows.Forms.NumericUpDown();
		this.抽奖_花费类型 = new System.Windows.Forms.ComboBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.抽奖_保底次数 = new System.Windows.Forms.NumericUpDown();
		this.抽奖_奖励列表 = new System.Windows.Forms.DataGridView();
		this.类型 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.奖励名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Is出谣言 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.保底奖励 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.获得几率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.获得数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.限制数量 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.已抽出数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.可抽出数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.抽奖_重置按钮 = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.抽奖_花费价格).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.抽奖_保底次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.抽奖_奖励列表).BeginInit();
		base.SuspendLayout();
		this.抽奖_开关.AutoSize = true;
		this.抽奖_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.抽奖_开关.Location = new System.Drawing.Point(12, 12);
		this.抽奖_开关.Name = "抽奖_开关";
		this.抽奖_开关.Size = new System.Drawing.Size(132, 23);
		this.抽奖_开关.TabIndex = 123;
		this.抽奖_开关.Text = "在线抽奖功能开关";
		this.抽奖_开关.UseVisualStyleBackColor = true;
		this.抽奖_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.抽奖_重载按钮.Location = new System.Drawing.Point(256, 8);
		this.抽奖_重载按钮.Name = "抽奖_重载按钮";
		this.抽奖_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.抽奖_重载按钮.TabIndex = 125;
		this.抽奖_重载按钮.Text = "重载配置";
		this.抽奖_重载按钮.UseVisualStyleBackColor = true;
		this.抽奖_重载按钮.Click += new System.EventHandler(抽奖_重载按钮_Click);
		this.抽奖_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.抽奖_保存按钮.Location = new System.Drawing.Point(150, 8);
		this.抽奖_保存按钮.Name = "抽奖_保存按钮";
		this.抽奖_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.抽奖_保存按钮.TabIndex = 124;
		this.抽奖_保存按钮.Text = "保存配置";
		this.抽奖_保存按钮.UseVisualStyleBackColor = true;
		this.抽奖_保存按钮.Click += new System.EventHandler(抽奖_保存按钮_Click);
		this.地狱道_名字.Location = new System.Drawing.Point(12, 41);
		this.地狱道_名字.Name = "地狱道_名字";
		this.地狱道_名字.ReadOnly = true;
		this.地狱道_名字.Size = new System.Drawing.Size(90, 23);
		this.地狱道_名字.TabIndex = 140;
		this.地狱道_名字.Text = "抽奖触发指令";
		this.地狱道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.抽奖_指令.Location = new System.Drawing.Point(108, 41);
		this.抽奖_指令.Name = "抽奖_指令";
		this.抽奖_指令.Size = new System.Drawing.Size(100, 23);
		this.抽奖_指令.TabIndex = 141;
		this.textBox5.Location = new System.Drawing.Point(214, 41);
		this.textBox5.Name = "textBox5";
		this.textBox5.ReadOnly = true;
		this.textBox5.Size = new System.Drawing.Size(80, 23);
		this.textBox5.TabIndex = 150;
		this.textBox5.Text = "抽奖花费类型";
		this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.抽奖_花费价格.Location = new System.Drawing.Point(397, 41);
		this.抽奖_花费价格.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.抽奖_花费价格.Name = "抽奖_花费价格";
		this.抽奖_花费价格.Size = new System.Drawing.Size(100, 23);
		this.抽奖_花费价格.TabIndex = 149;
		this.抽奖_花费类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.抽奖_花费类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.抽奖_花费类型.FormattingEnabled = true;
		this.抽奖_花费类型.Items.AddRange(new object[5] { "金元宝", "银元宝", "金钱", "奇宝点", "南极点" });
		this.抽奖_花费类型.Location = new System.Drawing.Point(296, 40);
		this.抽奖_花费类型.Name = "抽奖_花费类型";
		this.抽奖_花费类型.Size = new System.Drawing.Size(100, 25);
		this.抽奖_花费类型.TabIndex = 148;
		this.textBox1.Location = new System.Drawing.Point(508, 41);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(90, 23);
		this.textBox1.TabIndex = 151;
		this.textBox1.Text = "累计出保底次数";
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.抽奖_保底次数.Location = new System.Drawing.Point(599, 41);
		this.抽奖_保底次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.抽奖_保底次数.Name = "抽奖_保底次数";
		this.抽奖_保底次数.Size = new System.Drawing.Size(100, 23);
		this.抽奖_保底次数.TabIndex = 152;
		this.抽奖_奖励列表.AllowUserToDeleteRows = false;
		this.抽奖_奖励列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.抽奖_奖励列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.抽奖_奖励列表.BackgroundColor = System.Drawing.Color.White;
		this.抽奖_奖励列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.抽奖_奖励列表.Columns.AddRange(this.类型, this.奖励名字, this.Is出谣言, this.保底奖励, this.获得几率, this.获得数量, this.限制数量, this.已抽出数量, this.可抽出数量);
		this.抽奖_奖励列表.Location = new System.Drawing.Point(12, 71);
		this.抽奖_奖励列表.MultiSelect = false;
		this.抽奖_奖励列表.Name = "抽奖_奖励列表";
		this.抽奖_奖励列表.RowHeadersVisible = false;
		this.抽奖_奖励列表.RowTemplate.Height = 25;
		this.抽奖_奖励列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.抽奖_奖励列表.Size = new System.Drawing.Size(829, 367);
		this.抽奖_奖励列表.TabIndex = 174;
		this.类型.HeaderText = "类型";
		this.类型.Items.AddRange("等级", "道行", "经验", "声望", "战绩", "金元宝", "银元宝", "金钱", "代金券", "累充点", "南极点", "道具");
		this.类型.MinimumWidth = 90;
		this.类型.Name = "类型";
		this.类型.Width = 90;
		this.奖励名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.奖励名字.HeaderText = "奖励名字";
		this.奖励名字.MinimumWidth = 90;
		this.奖励名字.Name = "奖励名字";
		this.奖励名字.Width = 90;
		this.Is出谣言.FalseValue = "false";
		this.Is出谣言.HeaderText = "Is出谣言";
		this.Is出谣言.MinimumWidth = 80;
		this.Is出谣言.Name = "Is出谣言";
		this.Is出谣言.TrueValue = "true";
		this.Is出谣言.Width = 80;
		this.保底奖励.FalseValue = "false";
		this.保底奖励.HeaderText = "Is保底奖励";
		this.保底奖励.MinimumWidth = 80;
		this.保底奖励.Name = "保底奖励";
		this.保底奖励.TrueValue = "true";
		this.保底奖励.Width = 80;
		this.获得几率.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
		this.获得几率.HeaderText = "几率(0-10000)";
		this.获得几率.MinimumWidth = 90;
		this.获得几率.Name = "获得几率";
		this.获得几率.ToolTipText = "几率数值区间为";
		this.获得几率.Width = 112;
		this.获得数量.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.获得数量.HeaderText = "获得数量";
		this.获得数量.MinimumWidth = 90;
		this.获得数量.Name = "获得数量";
		this.获得数量.Width = 90;
		this.限制数量.FalseValue = "false";
		this.限制数量.HeaderText = "Is限制数量";
		this.限制数量.MinimumWidth = 80;
		this.限制数量.Name = "限制数量";
		this.限制数量.TrueValue = "true";
		this.限制数量.Width = 80;
		this.已抽出数量.HeaderText = "已抽出数量";
		this.已抽出数量.MinimumWidth = 100;
		this.已抽出数量.Name = "已抽出数量";
		this.可抽出数量.HeaderText = "可抽出数量";
		this.可抽出数量.MinimumWidth = 100;
		this.可抽出数量.Name = "可抽出数量";
		this.textBox2.BackColor = System.Drawing.SystemColors.Control;
		this.textBox2.ForeColor = System.Drawing.Color.Red;
		this.textBox2.Location = new System.Drawing.Point(362, 12);
		this.textBox2.Name = "textBox2";
		this.textBox2.ReadOnly = true;
		this.textBox2.Size = new System.Drawing.Size(479, 23);
		this.textBox2.TabIndex = 175;
		this.textBox2.Text = "保底意思为：如果累计次数达到了保底还没有出标识了保底的奖励则强制随机给一个保底";
		this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.抽奖_重置按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.抽奖_重置按钮.Location = new System.Drawing.Point(741, 37);
		this.抽奖_重置按钮.Name = "抽奖_重置按钮";
		this.抽奖_重置按钮.Size = new System.Drawing.Size(100, 30);
		this.抽奖_重置按钮.TabIndex = 176;
		this.抽奖_重置按钮.Text = "重置奖池";
		this.抽奖_重置按钮.UseVisualStyleBackColor = true;
		this.抽奖_重置按钮.Click += new System.EventHandler(抽奖_重置按钮_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(858, 450);
		base.Controls.Add(this.抽奖_重置按钮);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.抽奖_奖励列表);
		base.Controls.Add(this.抽奖_保底次数);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.textBox5);
		base.Controls.Add(this.抽奖_花费价格);
		base.Controls.Add(this.抽奖_花费类型);
		base.Controls.Add(this.地狱道_名字);
		base.Controls.Add(this.抽奖_指令);
		base.Controls.Add(this.抽奖_开关);
		base.Controls.Add(this.抽奖_重载按钮);
		base.Controls.Add(this.抽奖_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "在线抽奖配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "在线抽奖配置窗口";
		base.Load += new System.EventHandler(在线抽奖配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.抽奖_花费价格).EndInit();
		((System.ComponentModel.ISupportInitialize)this.抽奖_保底次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.抽奖_奖励列表).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
