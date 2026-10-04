using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 盲盒配置窗口 : Form
{
	private static 盲盒配置窗口 i;

	private IContainer components;

	private CheckBox 盲盒_开关;

	private Button 盲盒_重载按钮;

	private Button 盲盒_保存按钮;

	private DataGridView 盲盒_合成列表;

	private DataGridView 盲盒_配置列表;

	private GroupBox 修改窗口;

	private Button 修改_取消按钮;

	private Button 修改_确定按钮;

	private TextBox 修改_礼包名字;

	private Label label3;

	private TextBox 盲盒_添加名字;

	private TextBox textBox4;

	private Button 盲盒_添加按钮;

	private DataGridViewComboBoxColumn 奖励类型;

	private DataGridViewTextBoxColumn 奖励名字;

	private DataGridViewTextBoxColumn 获得几率;

	private DataGridViewTextBoxColumn 最低数量;

	private DataGridViewTextBoxColumn 最高数量;

	private Label label1;

	private Label label2;

	private CheckBox 修改_多奖励开关;

	private DataGridViewTextBoxColumn 盲盒名字;

	private DataGridViewTextBoxColumn 多奖励开关;

	private DataGridViewTextBoxColumn 盲盒内容;

	public static 盲盒配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 盲盒配置窗口();
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
		修改窗口.Visible = false;
	}

	public 盲盒配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 盲盒配置窗口_Load(object sender, EventArgs e)
	{
		盲盒_合成列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(修改事件回调, 删除事件回调);
		盲盒_配置列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 删除配置列表回调);
		修改_取消按钮.Click += delegate
		{
			修改窗口.Visible = false;
			盲盒_合成列表.Enabled = true;
		};
		修改_确定按钮.Click += 确定修改事件回调;
		((DataGridViewComboBoxColumn)盲盒_配置列表.Columns[0]).DataSource = new List<string>
		{
			"等级", "道行", "经验", "声望", "战绩", "金元宝", "银元宝", "金钱", "代金券", "累充点",
			"南极点", "道具", "宠物", "坐骑"
		};
		盲盒_配置列表.DataError += delegate
		{
		};
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		盲盒_重载按钮_Click(sender, e);
	}

	private void 修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 盲盒_合成列表.CurrentRow == null)
		{
			return;
		}
		int index = 盲盒_合成列表.CurrentRow.Index;
		if (index < 0)
		{
			return;
		}
		DataGridViewCellCollection cells = 盲盒_合成列表.Rows[index].Cells;
		修改_礼包名字.Text = cells[0].Value.ToString();
		修改_多奖励开关.Checked = Convert.ToString(cells[1].Value) == "开";
		string 配置内容列 = cells[2].Value.ToString();
		修改窗口.Visible = true;
		盲盒_合成列表.Enabled = false;
		盲盒_配置列表.Invoke((MethodInvoker)delegate
		{
			盲盒_配置列表.Rows.Clear();
			if (!string.IsNullOrWhiteSpace(配置内容列))
			{
				List<盲盒奖励类> list = JsonConvert.DeserializeObject<List<盲盒奖励类>>(配置内容列);
				if (list != null)
				{
					for (int i = 0; i < list.Count; i++)
					{
						盲盒_配置列表.Rows.Add(list[i].奖励类型, list[i].奖励名字, list[i].获得几率, list[i].最低数量, list[i].最高数量);
						((DataGridViewComboBoxCell)盲盒_配置列表.Rows[i].Cells[0]).Value = list[i].奖励类型.ToString();
					}
				}
			}
		});
	}

	private void 确定修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || string.IsNullOrWhiteSpace(修改_礼包名字.Text))
		{
			return;
		}
		if (盲盒_配置列表.Rows.Count <= 0)
		{
			MessageBox.Show("请配置有效的盲盒内容，否则请删除当前盲盒！");
			return;
		}
		List<盲盒奖励类> list = new List<盲盒奖励类>();
		for (int i = 0; i < 盲盒_配置列表.Rows.Count; i++)
		{
			DataGridViewCellCollection cells = 盲盒_配置列表.Rows[i].Cells;
			if (cells != null && cells[0].Value != null)
			{
				盲盒奖励类 盲盒奖励类2 = new 盲盒奖励类();
				Enum.TryParse<AllEnums.数值Type>(cells[0].Value.ToString(), out 盲盒奖励类2.奖励类型);
				盲盒奖励类2.奖励名字 = ((盲盒奖励类2.奖励类型 != AllEnums.数值Type.道具 && 盲盒奖励类2.奖励类型 != AllEnums.数值Type.宠物 && 盲盒奖励类2.奖励类型 != AllEnums.数值Type.坐骑) ? 盲盒奖励类2.奖励类型.ToString() : cells[1].Value?.ToString());
				int.TryParse(cells[2].Value?.ToString(), out 盲盒奖励类2.获得几率);
				int.TryParse(cells[3].Value?.ToString(), out 盲盒奖励类2.最低数量);
				int.TryParse(cells[4].Value?.ToString(), out 盲盒奖励类2.最高数量);
				list.Add(盲盒奖励类2);
			}
		}
		修改窗口.Visible = false;
		MessageBox.Show("[" + 修改_礼包名字.Text + "]的配置已经修改，请及时点击保存配置按钮更新服务端配置！");
		盲盒_合成列表.Enabled = true;
		if (盲盒_合成列表.CurrentRow != null)
		{
			int index = 盲盒_合成列表.CurrentRow.Index;
			if (index >= 0)
			{
				DataGridViewCellCollection cells2 = 盲盒_合成列表.Rows[index].Cells;
				cells2[1].Value = (修改_多奖励开关.Checked ? "开" : "关");
				cells2[2].Value = JsonConvert.SerializeObject(list, Formatting.Indented);
			}
		}
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 盲盒_合成列表.CurrentRow != null)
		{
			int index = 盲盒_合成列表.CurrentRow.Index;
			if (index >= 0)
			{
				盲盒_合成列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 删除配置列表回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 盲盒_配置列表.CurrentRow != null)
		{
			int index = 盲盒_配置列表.CurrentRow.Index;
			if (index >= 0)
			{
				盲盒_配置列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 42)
		{
			return;
		}
		盲盒_开关.Checked = Singleton<全局变量类>.I.盲盒配置.功能开关;
		盲盒_合成列表.Invoke((MethodInvoker)delegate
		{
			盲盒_合成列表.Rows.Clear();
			foreach (KeyValuePair<string, List<盲盒奖励类>> item in Singleton<全局变量类>.I.盲盒配置.盲盒列表)
			{
				bool flag = Singleton<全局变量类>.I.盲盒配置.多奖励列表.ContainsKey(item.Key) && Singleton<全局变量类>.I.盲盒配置.多奖励列表[item.Key];
				盲盒_合成列表.Rows.Add(item.Key, flag ? "开" : "关", JsonConvert.SerializeObject(item.Value, Formatting.Indented));
			}
		});
	}

	private void 配置变量赋值()
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		Singleton<全局变量类>.I.盲盒配置.功能开关 = 盲盒_开关.Checked;
		Singleton<全局变量类>.I.盲盒配置.盲盒列表.Clear();
		Singleton<全局变量类>.I.盲盒配置.多奖励列表.Clear();
		List<盲盒奖励类> list = new List<盲盒奖励类>();
		for (int i = 0; i < 盲盒_合成列表.Rows.Count; i++)
		{
			DataGridViewCellCollection cells = 盲盒_合成列表.Rows[i].Cells;
			if (!string.IsNullOrWhiteSpace(cells[0].Value?.ToString()) && !string.IsNullOrWhiteSpace(cells[2].Value?.ToString()))
			{
				bool value = Convert.ToString(cells[1].Value) == "开";
				list = JsonConvert.DeserializeObject<List<盲盒奖励类>>(cells[2].Value.ToString());
				list.Reverse();
				Singleton<全局变量类>.I.盲盒配置.盲盒列表.TryAdd(cells[0].Value.ToString(), list);
				Singleton<全局变量类>.I.盲盒配置.多奖励列表.TryAdd(Convert.ToString(cells[0].Value), value);
			}
		}
	}

	private void 盲盒_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 42, JsonConvert.SerializeObject(Singleton<全局变量类>.I.盲盒配置, Formatting.Indented));
		}
	}

	private void 盲盒_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 42);
		}
	}

	private void 盲盒_添加按钮_Click(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(盲盒_添加名字.Text))
		{
			MessageBox.Show("请填写要添加的盲盒礼包名字！");
			return;
		}
		for (int i = 0; i < 盲盒_合成列表.Rows.Count; i++)
		{
			string text = 盲盒_合成列表.Rows[i].Cells[0].Value.ToString();
			if (盲盒_添加名字.Text == text)
			{
				MessageBox.Show("列表中已有相同的盲盒礼包了，无法配置重复的盲盒！");
				return;
			}
		}
		盲盒_合成列表.Invoke((MethodInvoker)delegate
		{
			盲盒_合成列表.Rows.Add(盲盒_添加名字.Text, "关", string.Empty);
			MessageBox.Show("[" + 盲盒_添加名字.Text + "]盲盒已经添加到列表中了，请及时配置盲盒内容！");
		});
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.盲盒配置窗口));
		this.盲盒_开关 = new System.Windows.Forms.CheckBox();
		this.盲盒_重载按钮 = new System.Windows.Forms.Button();
		this.盲盒_保存按钮 = new System.Windows.Forms.Button();
		this.盲盒_合成列表 = new System.Windows.Forms.DataGridView();
		this.盲盒_配置列表 = new System.Windows.Forms.DataGridView();
		this.奖励类型 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.奖励名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.获得几率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.最低数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.最高数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.修改窗口 = new System.Windows.Forms.GroupBox();
		this.label1 = new System.Windows.Forms.Label();
		this.修改_礼包名字 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.修改_取消按钮 = new System.Windows.Forms.Button();
		this.修改_确定按钮 = new System.Windows.Forms.Button();
		this.盲盒_添加名字 = new System.Windows.Forms.TextBox();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.盲盒_添加按钮 = new System.Windows.Forms.Button();
		this.修改_多奖励开关 = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.盲盒名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.多奖励开关 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.盲盒内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		((System.ComponentModel.ISupportInitialize)this.盲盒_合成列表).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.盲盒_配置列表).BeginInit();
		this.修改窗口.SuspendLayout();
		base.SuspendLayout();
		this.盲盒_开关.AutoSize = true;
		this.盲盒_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.盲盒_开关.Location = new System.Drawing.Point(12, 12);
		this.盲盒_开关.Name = "盲盒_开关";
		this.盲盒_开关.Size = new System.Drawing.Size(106, 23);
		this.盲盒_开关.TabIndex = 120;
		this.盲盒_开关.Text = "盲盒功能开关";
		this.盲盒_开关.UseVisualStyleBackColor = true;
		this.盲盒_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.盲盒_重载按钮.Location = new System.Drawing.Point(201, 8);
		this.盲盒_重载按钮.Name = "盲盒_重载按钮";
		this.盲盒_重载按钮.Size = new System.Drawing.Size(74, 30);
		this.盲盒_重载按钮.TabIndex = 122;
		this.盲盒_重载按钮.Text = "重载配置";
		this.盲盒_重载按钮.UseVisualStyleBackColor = true;
		this.盲盒_重载按钮.Click += new System.EventHandler(盲盒_重载按钮_Click);
		this.盲盒_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.盲盒_保存按钮.Location = new System.Drawing.Point(124, 7);
		this.盲盒_保存按钮.Name = "盲盒_保存按钮";
		this.盲盒_保存按钮.Size = new System.Drawing.Size(74, 30);
		this.盲盒_保存按钮.TabIndex = 121;
		this.盲盒_保存按钮.Text = "保存配置";
		this.盲盒_保存按钮.UseVisualStyleBackColor = true;
		this.盲盒_保存按钮.Click += new System.EventHandler(盲盒_保存按钮_Click);
		this.盲盒_合成列表.AllowUserToAddRows = false;
		this.盲盒_合成列表.AllowUserToDeleteRows = false;
		this.盲盒_合成列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.盲盒_合成列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.盲盒_合成列表.BackgroundColor = System.Drawing.Color.White;
		this.盲盒_合成列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.盲盒_合成列表.Columns.AddRange(this.盲盒名字, this.多奖励开关, this.盲盒内容);
		this.盲盒_合成列表.Location = new System.Drawing.Point(12, 78);
		this.盲盒_合成列表.MultiSelect = false;
		this.盲盒_合成列表.Name = "盲盒_合成列表";
		this.盲盒_合成列表.ReadOnly = true;
		this.盲盒_合成列表.RowHeadersVisible = false;
		this.盲盒_合成列表.RowTemplate.Height = 25;
		this.盲盒_合成列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.盲盒_合成列表.Size = new System.Drawing.Size(255, 364);
		this.盲盒_合成列表.TabIndex = 172;
		this.盲盒_配置列表.AllowUserToDeleteRows = false;
		this.盲盒_配置列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.盲盒_配置列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
		this.盲盒_配置列表.BackgroundColor = System.Drawing.Color.White;
		this.盲盒_配置列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.盲盒_配置列表.Columns.AddRange(this.奖励类型, this.奖励名字, this.获得几率, this.最低数量, this.最高数量);
		this.盲盒_配置列表.Location = new System.Drawing.Point(16, 86);
		this.盲盒_配置列表.MultiSelect = false;
		this.盲盒_配置列表.Name = "盲盒_配置列表";
		this.盲盒_配置列表.RowHeadersVisible = false;
		this.盲盒_配置列表.RowTemplate.Height = 25;
		this.盲盒_配置列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
		this.盲盒_配置列表.Size = new System.Drawing.Size(487, 299);
		this.盲盒_配置列表.TabIndex = 173;
		this.奖励类型.HeaderText = "奖励类型";
		this.奖励类型.Items.AddRange("金元宝", "银元宝", "累充点", "南极点", "道具", "宠物", "坐骑");
		this.奖励类型.MinimumWidth = 90;
		this.奖励类型.Name = "奖励类型";
		this.奖励类型.Width = 90;
		this.奖励名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.奖励名字.HeaderText = "奖励名字";
		this.奖励名字.MinimumWidth = 90;
		this.奖励名字.Name = "奖励名字";
		this.奖励名字.Width = 90;
		this.获得几率.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
		this.获得几率.HeaderText = "几率(0-10000)";
		this.获得几率.MinimumWidth = 90;
		this.获得几率.Name = "获得几率";
		this.获得几率.ToolTipText = "几率数值区间为0-10000";
		this.获得几率.Width = 112;
		this.最低数量.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.最低数量.HeaderText = "最低数量";
		this.最低数量.MinimumWidth = 90;
		this.最低数量.Name = "最低数量";
		this.最低数量.Width = 90;
		this.最高数量.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.最高数量.HeaderText = "最高数量";
		this.最高数量.MinimumWidth = 100;
		this.最高数量.Name = "最高数量";
		this.修改窗口.Controls.Add(this.label2);
		this.修改窗口.Controls.Add(this.修改_多奖励开关);
		this.修改窗口.Controls.Add(this.label1);
		this.修改窗口.Controls.Add(this.修改_礼包名字);
		this.修改窗口.Controls.Add(this.label3);
		this.修改窗口.Controls.Add(this.修改_取消按钮);
		this.修改窗口.Controls.Add(this.修改_确定按钮);
		this.修改窗口.Controls.Add(this.盲盒_配置列表);
		this.修改窗口.Location = new System.Drawing.Point(278, 8);
		this.修改窗口.Name = "修改窗口";
		this.修改窗口.Size = new System.Drawing.Size(512, 434);
		this.修改窗口.TabIndex = 174;
		this.修改窗口.TabStop = false;
		this.修改窗口.Text = "盲盒列表配置项";
		this.label1.ForeColor = System.Drawing.Color.Red;
		this.label1.Location = new System.Drawing.Point(263, 24);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(240, 23);
		this.label1.TabIndex = 178;
		this.label1.Text = "类型为宠物、坐骑时，数量必须固定位1";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_礼包名字.Location = new System.Drawing.Point(107, 24);
		this.修改_礼包名字.Name = "修改_礼包名字";
		this.修改_礼包名字.ReadOnly = true;
		this.修改_礼包名字.Size = new System.Drawing.Size(150, 23);
		this.修改_礼包名字.TabIndex = 177;
		this.label3.Location = new System.Drawing.Point(16, 24);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(94, 23);
		this.label3.TabIndex = 176;
		this.label3.Text = "当前操作盲盒：";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_取消按钮.Location = new System.Drawing.Point(257, 391);
		this.修改_取消按钮.Name = "修改_取消按钮";
		this.修改_取消按钮.Size = new System.Drawing.Size(100, 30);
		this.修改_取消按钮.TabIndex = 175;
		this.修改_取消按钮.Text = "取    消";
		this.修改_取消按钮.UseVisualStyleBackColor = true;
		this.修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_确定按钮.Location = new System.Drawing.Point(140, 391);
		this.修改_确定按钮.Name = "修改_确定按钮";
		this.修改_确定按钮.Size = new System.Drawing.Size(100, 30);
		this.修改_确定按钮.TabIndex = 174;
		this.修改_确定按钮.Text = "修     改";
		this.修改_确定按钮.UseVisualStyleBackColor = true;
		this.盲盒_添加名字.Location = new System.Drawing.Point(74, 49);
		this.盲盒_添加名字.Name = "盲盒_添加名字";
		this.盲盒_添加名字.Size = new System.Drawing.Size(130, 23);
		this.盲盒_添加名字.TabIndex = 179;
		this.textBox4.Location = new System.Drawing.Point(12, 49);
		this.textBox4.Name = "textBox4";
		this.textBox4.ReadOnly = true;
		this.textBox4.Size = new System.Drawing.Size(60, 23);
		this.textBox4.TabIndex = 180;
		this.textBox4.Text = "盲盒礼包：";
		this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.盲盒_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.盲盒_添加按钮.Location = new System.Drawing.Point(210, 49);
		this.盲盒_添加按钮.Name = "盲盒_添加按钮";
		this.盲盒_添加按钮.Size = new System.Drawing.Size(57, 23);
		this.盲盒_添加按钮.TabIndex = 181;
		this.盲盒_添加按钮.Text = "添加";
		this.盲盒_添加按钮.UseVisualStyleBackColor = true;
		this.盲盒_添加按钮.Click += new System.EventHandler(盲盒_添加按钮_Click);
		this.修改_多奖励开关.AutoSize = true;
		this.修改_多奖励开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_多奖励开关.Location = new System.Drawing.Point(16, 53);
		this.修改_多奖励开关.Name = "修改_多奖励开关";
		this.修改_多奖励开关.Size = new System.Drawing.Size(93, 23);
		this.修改_多奖励开关.TabIndex = 179;
		this.修改_多奖励开关.Text = "多奖励开关";
		this.修改_多奖励开关.UseVisualStyleBackColor = true;
		this.label2.ForeColor = System.Drawing.Color.Red;
		this.label2.Location = new System.Drawing.Point(117, 53);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(386, 23);
		this.label2.TabIndex = 180;
		this.label2.Text = "开启后你配置的每一行奖励都有几率获得，不再只随机一种";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.盲盒名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.盲盒名字.Frozen = true;
		this.盲盒名字.HeaderText = "盲盒名字";
		this.盲盒名字.MinimumWidth = 150;
		this.盲盒名字.Name = "盲盒名字";
		this.盲盒名字.ReadOnly = true;
		this.盲盒名字.ToolTipText = "右键修改可进行盲盒内容修改";
		this.盲盒名字.Width = 150;
		this.多奖励开关.HeaderText = "多奖励开关";
		this.多奖励开关.MinimumWidth = 100;
		this.多奖励开关.Name = "多奖励开关";
		this.多奖励开关.ReadOnly = true;
		this.盲盒内容.HeaderText = "盲盒内容";
		this.盲盒内容.MinimumWidth = 100;
		this.盲盒内容.Name = "盲盒内容";
		this.盲盒内容.ReadOnly = true;
		this.盲盒内容.Visible = false;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(795, 450);
		base.Controls.Add(this.盲盒_添加按钮);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.盲盒_添加名字);
		base.Controls.Add(this.修改窗口);
		base.Controls.Add(this.盲盒_合成列表);
		base.Controls.Add(this.盲盒_开关);
		base.Controls.Add(this.盲盒_重载按钮);
		base.Controls.Add(this.盲盒_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "盲盒配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "盲盒配置窗口";
		base.Load += new System.EventHandler(盲盒配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.盲盒_合成列表).EndInit();
		((System.ComponentModel.ISupportInitialize)this.盲盒_配置列表).EndInit();
		this.修改窗口.ResumeLayout(false);
		this.修改窗口.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
