using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 礼包开元宝配置窗口 : Form
{
	private static 礼包开元宝配置窗口 i;

	private IContainer components;

	private Button 元宝礼包_重载按钮;

	private Button 元宝礼包_保存按钮;

	private CheckBox 元宝礼包_开关;

	private Label label7;

	private Label label8;

	private NumericUpDown 元宝礼包_金元宝;

	private TextBox 元宝礼包_礼包名字;

	private Label label1;

	private NumericUpDown 元宝礼包_银元宝;

	private DataGridView 元宝礼包_礼包列表;

	private Button 元宝礼包_添加按钮;

	private Panel 修改窗口;

	private Label label2;

	private NumericUpDown 修改_银元宝;

	private Label label3;

	private Label label4;

	private NumericUpDown 修改_金元宝;

	private TextBox 修改_名字;

	private Button 修改_取消按钮;

	private Button 修改_确定按钮;

	private Label label9;

	private NumericUpDown 修改_奇宝点;

	private Label label6;

	private NumericUpDown 修改_南极点;

	private Label label5;

	private NumericUpDown 修改_累充点;

	private Label label10;

	private NumericUpDown 元宝礼包_南极点;

	private Label label11;

	private NumericUpDown 元宝礼包_累充点;

	private Label label12;

	private NumericUpDown 元宝礼包_奇宝点;

	private Label label13;

	private NumericUpDown 修改_灵气值;

	private DataGridViewTextBoxColumn 礼包名字;

	private DataGridViewTextBoxColumn 金元宝;

	private DataGridViewTextBoxColumn 银元宝;

	private DataGridViewTextBoxColumn 累充点;

	private DataGridViewTextBoxColumn 南极点;

	private DataGridViewTextBoxColumn 奇宝点;

	private DataGridViewTextBoxColumn Column1;

	private Label label14;

	private NumericUpDown 元宝礼包_灵气值;

	public static 礼包开元宝配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 礼包开元宝配置窗口();
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

	public 礼包开元宝配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 礼包开元宝配置窗口_Load(object sender, EventArgs e)
	{
		元宝礼包_礼包列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(修改事件回调, 删除事件回调);
		修改_取消按钮.Click += delegate
		{
			修改窗口.Visible = false;
		};
		修改_确定按钮.Click += 确定修改事件回调;
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		元宝礼包_重载按钮_Click(sender, e);
	}

	private void 修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 元宝礼包_礼包列表.CurrentRow == null)
		{
			return;
		}
		int index = 元宝礼包_礼包列表.CurrentRow.Index;
		if (index >= 0)
		{
			DataGridViewCellCollection cells = 元宝礼包_礼包列表.Rows[index].Cells;
			修改_名字.Text = cells[0].Value.ToString();
			if (Singleton<全局变量类>.I.礼包开元宝配置.礼包列表.TryGetValue(修改_名字.Text, out int[] value) && value.Length >= 6)
			{
				修改_金元宝.Value = value[0];
				修改_银元宝.Value = value[1];
				修改_累充点.Value = value[2];
				修改_南极点.Value = value[3];
				修改_奇宝点.Value = value[4];
				修改_灵气值.Value = value[5];
				修改窗口.Visible = true;
			}
		}
	}

	private void 确定修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || !Singleton<全局变量类>.I.礼包开元宝配置.礼包列表.ContainsKey(修改_名字.Text))
		{
			return;
		}
		Singleton<全局变量类>.I.礼包开元宝配置.礼包列表[修改_名字.Text] = new int[6]
		{
			(int)修改_金元宝.Value,
			(int)修改_银元宝.Value,
			(int)修改_累充点.Value,
			(int)修改_南极点.Value,
			(int)修改_奇宝点.Value,
			(int)修改_灵气值.Value
		};
		修改窗口.Visible = false;
		if (元宝礼包_礼包列表.CurrentRow != null)
		{
			int index = 元宝礼包_礼包列表.CurrentRow.Index;
			if (index >= 0)
			{
				DataGridViewCellCollection cells = 元宝礼包_礼包列表.Rows[index].Cells;
				cells[1].Value = 修改_金元宝.Value;
				cells[2].Value = 修改_银元宝.Value;
				cells[3].Value = 修改_累充点.Value;
				cells[4].Value = 修改_南极点.Value;
				cells[5].Value = 修改_奇宝点.Value;
				cells[6].Value = 修改_灵气值.Value;
				MessageBox.Show("[" + 修改_名字.Text + "]的配置已经修改，请及时点击保存配置按钮更新服务端配置！");
			}
		}
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 元宝礼包_礼包列表.CurrentRow == null)
		{
			return;
		}
		int index = 元宝礼包_礼包列表.CurrentRow.Index;
		if (index >= 0)
		{
			string text = 元宝礼包_礼包列表.Rows[index].Cells["礼包名字"].Value.ToString();
			if (Singleton<全局变量类>.I.礼包开元宝配置.礼包列表.ContainsKey(text))
			{
				Singleton<全局变量类>.I.礼包开元宝配置.礼包列表.TryRemove(text, out int[] _);
				MessageBox.Show("[" + text + "]已从回收列表中删除，请及时点击保存配置按钮更新服务端配置！");
				元宝礼包_礼包列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 30)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			元宝礼包_开关.Checked = Singleton<全局变量类>.I.礼包开元宝配置.功能开关;
			元宝礼包_礼包列表.Rows.Clear();
			foreach (KeyValuePair<string, int[]> item in Singleton<全局变量类>.I.礼包开元宝配置.礼包列表)
			{
				元宝礼包_礼包列表.Rows.Add(item.Key, (item.Value.Length != 0) ? item.Value[0] : 0, (item.Value.Length > 1) ? item.Value[1] : 0, (item.Value.Length > 2) ? item.Value[2] : 0, (item.Value.Length > 3) ? item.Value[3] : 0, (item.Value.Length > 4) ? item.Value[4] : 0, (item.Value.Length > 5) ? item.Value[5] : 0);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.礼包开元宝配置.功能开关 = 元宝礼包_开关.Checked;
		}
	}

	private void 元宝礼包_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 30, JsonConvert.SerializeObject(Singleton<全局变量类>.I.礼包开元宝配置, Formatting.Indented));
		}
	}

	private void 元宝礼包_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 30);
		}
	}

	private void 元宝礼包_添加按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(元宝礼包_礼包名字.Text))
			{
				MessageBox.Show("请输入要添加的元宝礼包名字！");
				return;
			}
			if (Singleton<全局变量类>.I.礼包开元宝配置.礼包列表.ContainsKey(元宝礼包_礼包名字.Text))
			{
				MessageBox.Show("列表中已经存在【" + 元宝礼包_礼包名字.Text + "】，无法重复添加！");
				return;
			}
			Singleton<全局变量类>.I.礼包开元宝配置.礼包列表.TryAdd(元宝礼包_礼包名字.Text, new int[6]
			{
				(int)元宝礼包_金元宝.Value,
				(int)元宝礼包_银元宝.Value,
				(int)元宝礼包_累充点.Value,
				(int)元宝礼包_南极点.Value,
				(int)元宝礼包_奇宝点.Value,
				(int)元宝礼包_灵气值.Value
			});
			元宝礼包_礼包列表.Rows.Add(元宝礼包_礼包名字.Text, 元宝礼包_金元宝.Value, 元宝礼包_银元宝.Value, 元宝礼包_累充点.Value, 元宝礼包_南极点.Value, 元宝礼包_奇宝点.Value, 元宝礼包_灵气值.Value);
			MessageBox.Show("[" + 元宝礼包_礼包名字.Text + "]添加成功");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.礼包开元宝配置窗口));
		this.元宝礼包_重载按钮 = new System.Windows.Forms.Button();
		this.元宝礼包_保存按钮 = new System.Windows.Forms.Button();
		this.元宝礼包_开关 = new System.Windows.Forms.CheckBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.元宝礼包_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.元宝礼包_礼包名字 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.元宝礼包_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.元宝礼包_礼包列表 = new System.Windows.Forms.DataGridView();
		this.礼包名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.金元宝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.银元宝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.累充点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.南极点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.奇宝点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.元宝礼包_添加按钮 = new System.Windows.Forms.Button();
		this.修改窗口 = new System.Windows.Forms.Panel();
		this.label13 = new System.Windows.Forms.Label();
		this.修改_灵气值 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.修改_奇宝点 = new System.Windows.Forms.NumericUpDown();
		this.label6 = new System.Windows.Forms.Label();
		this.修改_南极点 = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.修改_累充点 = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.修改_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.修改_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.修改_名字 = new System.Windows.Forms.TextBox();
		this.修改_取消按钮 = new System.Windows.Forms.Button();
		this.修改_确定按钮 = new System.Windows.Forms.Button();
		this.label10 = new System.Windows.Forms.Label();
		this.元宝礼包_南极点 = new System.Windows.Forms.NumericUpDown();
		this.label11 = new System.Windows.Forms.Label();
		this.元宝礼包_累充点 = new System.Windows.Forms.NumericUpDown();
		this.label12 = new System.Windows.Forms.Label();
		this.元宝礼包_奇宝点 = new System.Windows.Forms.NumericUpDown();
		this.label14 = new System.Windows.Forms.Label();
		this.元宝礼包_灵气值 = new System.Windows.Forms.NumericUpDown();
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_礼包列表).BeginInit();
		this.修改窗口.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_灵气值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_奇宝点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_奇宝点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_灵气值).BeginInit();
		base.SuspendLayout();
		this.元宝礼包_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.元宝礼包_重载按钮.Location = new System.Drawing.Point(243, 7);
		this.元宝礼包_重载按钮.Name = "元宝礼包_重载按钮";
		this.元宝礼包_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.元宝礼包_重载按钮.TabIndex = 68;
		this.元宝礼包_重载按钮.Text = "重载配置";
		this.元宝礼包_重载按钮.UseVisualStyleBackColor = true;
		this.元宝礼包_重载按钮.Click += new System.EventHandler(元宝礼包_重载按钮_Click);
		this.元宝礼包_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.元宝礼包_保存按钮.Location = new System.Drawing.Point(137, 7);
		this.元宝礼包_保存按钮.Name = "元宝礼包_保存按钮";
		this.元宝礼包_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.元宝礼包_保存按钮.TabIndex = 67;
		this.元宝礼包_保存按钮.Text = "保存配置";
		this.元宝礼包_保存按钮.UseVisualStyleBackColor = true;
		this.元宝礼包_保存按钮.Click += new System.EventHandler(元宝礼包_保存按钮_Click);
		this.元宝礼包_开关.AutoSize = true;
		this.元宝礼包_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.元宝礼包_开关.Location = new System.Drawing.Point(12, 12);
		this.元宝礼包_开关.Name = "元宝礼包_开关";
		this.元宝礼包_开关.Size = new System.Drawing.Size(119, 23);
		this.元宝礼包_开关.TabIndex = 66;
		this.元宝礼包_开关.Text = "礼包开元宝开关";
		this.元宝礼包_开关.UseVisualStyleBackColor = true;
		this.label7.Location = new System.Drawing.Point(12, 51);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(60, 23);
		this.label7.TabIndex = 74;
		this.label7.Text = "礼包名字";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label8.Location = new System.Drawing.Point(12, 81);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(60, 23);
		this.label8.TabIndex = 71;
		this.label8.Text = "开金元宝";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.元宝礼包_金元宝.Location = new System.Drawing.Point(73, 81);
		this.元宝礼包_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.元宝礼包_金元宝.Name = "元宝礼包_金元宝";
		this.元宝礼包_金元宝.Size = new System.Drawing.Size(100, 23);
		this.元宝礼包_金元宝.TabIndex = 72;
		this.元宝礼包_礼包名字.Location = new System.Drawing.Point(73, 51);
		this.元宝礼包_礼包名字.Name = "元宝礼包_礼包名字";
		this.元宝礼包_礼包名字.Size = new System.Drawing.Size(150, 23);
		this.元宝礼包_礼包名字.TabIndex = 73;
		this.label1.Location = new System.Drawing.Point(182, 81);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 23);
		this.label1.TabIndex = 75;
		this.label1.Text = "开银元宝";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.元宝礼包_银元宝.Location = new System.Drawing.Point(243, 81);
		this.元宝礼包_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.元宝礼包_银元宝.Name = "元宝礼包_银元宝";
		this.元宝礼包_银元宝.Size = new System.Drawing.Size(100, 23);
		this.元宝礼包_银元宝.TabIndex = 76;
		this.元宝礼包_礼包列表.AllowUserToAddRows = false;
		this.元宝礼包_礼包列表.AllowUserToDeleteRows = false;
		this.元宝礼包_礼包列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.元宝礼包_礼包列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.元宝礼包_礼包列表.BackgroundColor = System.Drawing.Color.White;
		this.元宝礼包_礼包列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.元宝礼包_礼包列表.Columns.AddRange(this.礼包名字, this.金元宝, this.银元宝, this.累充点, this.南极点, this.奇宝点, this.Column1);
		this.元宝礼包_礼包列表.Location = new System.Drawing.Point(12, 141);
		this.元宝礼包_礼包列表.MultiSelect = false;
		this.元宝礼包_礼包列表.Name = "元宝礼包_礼包列表";
		this.元宝礼包_礼包列表.ReadOnly = true;
		this.元宝礼包_礼包列表.RowHeadersVisible = false;
		this.元宝礼包_礼包列表.RowTemplate.Height = 25;
		this.元宝礼包_礼包列表.Size = new System.Drawing.Size(595, 297);
		this.元宝礼包_礼包列表.TabIndex = 81;
		this.礼包名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.礼包名字.HeaderText = "礼包名字";
		this.礼包名字.MinimumWidth = 100;
		this.礼包名字.Name = "礼包名字";
		this.礼包名字.ReadOnly = true;
		this.金元宝.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.金元宝.HeaderText = "金元宝";
		this.金元宝.MinimumWidth = 100;
		this.金元宝.Name = "金元宝";
		this.金元宝.ReadOnly = true;
		this.银元宝.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.银元宝.HeaderText = "银元宝";
		this.银元宝.MinimumWidth = 100;
		this.银元宝.Name = "银元宝";
		this.银元宝.ReadOnly = true;
		this.累充点.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.累充点.HeaderText = "累充点";
		this.累充点.MinimumWidth = 100;
		this.累充点.Name = "累充点";
		this.累充点.ReadOnly = true;
		this.南极点.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.南极点.HeaderText = "南极点";
		this.南极点.MinimumWidth = 100;
		this.南极点.Name = "南极点";
		this.南极点.ReadOnly = true;
		this.奇宝点.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.奇宝点.HeaderText = "奇宝点";
		this.奇宝点.MinimumWidth = 100;
		this.奇宝点.Name = "奇宝点";
		this.奇宝点.ReadOnly = true;
		this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.Column1.HeaderText = "灵气值";
		this.Column1.MinimumWidth = 100;
		this.Column1.Name = "Column1";
		this.Column1.ReadOnly = true;
		this.元宝礼包_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.元宝礼包_添加按钮.Location = new System.Drawing.Point(518, 81);
		this.元宝礼包_添加按钮.Name = "元宝礼包_添加按钮";
		this.元宝礼包_添加按钮.Size = new System.Drawing.Size(89, 54);
		this.元宝礼包_添加按钮.TabIndex = 82;
		this.元宝礼包_添加按钮.Text = "添加礼包";
		this.元宝礼包_添加按钮.UseVisualStyleBackColor = true;
		this.元宝礼包_添加按钮.Click += new System.EventHandler(元宝礼包_添加按钮_Click);
		this.修改窗口.Controls.Add(this.label13);
		this.修改窗口.Controls.Add(this.修改_灵气值);
		this.修改窗口.Controls.Add(this.label9);
		this.修改窗口.Controls.Add(this.修改_奇宝点);
		this.修改窗口.Controls.Add(this.label6);
		this.修改窗口.Controls.Add(this.修改_南极点);
		this.修改窗口.Controls.Add(this.label5);
		this.修改窗口.Controls.Add(this.修改_累充点);
		this.修改窗口.Controls.Add(this.label2);
		this.修改窗口.Controls.Add(this.修改_银元宝);
		this.修改窗口.Controls.Add(this.label3);
		this.修改窗口.Controls.Add(this.label4);
		this.修改窗口.Controls.Add(this.修改_金元宝);
		this.修改窗口.Controls.Add(this.修改_名字);
		this.修改窗口.Controls.Add(this.修改_取消按钮);
		this.修改窗口.Controls.Add(this.修改_确定按钮);
		this.修改窗口.Location = new System.Drawing.Point(80, 193);
		this.修改窗口.Name = "修改窗口";
		this.修改窗口.Size = new System.Drawing.Size(379, 200);
		this.修改窗口.TabIndex = 83;
		this.label13.Location = new System.Drawing.Point(17, 115);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(60, 23);
		this.label13.TabIndex = 114;
		this.label13.Text = "开灵气值";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_灵气值.Location = new System.Drawing.Point(78, 115);
		this.修改_灵气值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_灵气值.Name = "修改_灵气值";
		this.修改_灵气值.Size = new System.Drawing.Size(100, 23);
		this.修改_灵气值.TabIndex = 115;
		this.label9.Location = new System.Drawing.Point(184, 115);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(60, 23);
		this.label9.TabIndex = 112;
		this.label9.Text = "开奇宝点";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_奇宝点.Location = new System.Drawing.Point(245, 115);
		this.修改_奇宝点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_奇宝点.Name = "修改_奇宝点";
		this.修改_奇宝点.Size = new System.Drawing.Size(100, 23);
		this.修改_奇宝点.TabIndex = 113;
		this.label6.Location = new System.Drawing.Point(184, 84);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(60, 23);
		this.label6.TabIndex = 110;
		this.label6.Text = "开南极点";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_南极点.Location = new System.Drawing.Point(245, 84);
		this.修改_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_南极点.Name = "修改_南极点";
		this.修改_南极点.Size = new System.Drawing.Size(100, 23);
		this.修改_南极点.TabIndex = 111;
		this.label5.Location = new System.Drawing.Point(184, 53);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(60, 23);
		this.label5.TabIndex = 108;
		this.label5.Text = "开累充点";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_累充点.Location = new System.Drawing.Point(245, 53);
		this.修改_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_累充点.Name = "修改_累充点";
		this.修改_累充点.Size = new System.Drawing.Size(100, 23);
		this.修改_累充点.TabIndex = 109;
		this.label2.Location = new System.Drawing.Point(17, 84);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(60, 23);
		this.label2.TabIndex = 106;
		this.label2.Text = "开银元宝";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_银元宝.Location = new System.Drawing.Point(78, 84);
		this.修改_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_银元宝.Name = "修改_银元宝";
		this.修改_银元宝.Size = new System.Drawing.Size(100, 23);
		this.修改_银元宝.TabIndex = 107;
		this.label3.Location = new System.Drawing.Point(17, 22);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(60, 23);
		this.label3.TabIndex = 105;
		this.label3.Text = "礼包名字";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label4.Location = new System.Drawing.Point(17, 53);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 102;
		this.label4.Text = "开金元宝";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_金元宝.Location = new System.Drawing.Point(78, 53);
		this.修改_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_金元宝.Name = "修改_金元宝";
		this.修改_金元宝.Size = new System.Drawing.Size(100, 23);
		this.修改_金元宝.TabIndex = 103;
		this.修改_名字.Location = new System.Drawing.Point(78, 22);
		this.修改_名字.Name = "修改_名字";
		this.修改_名字.ReadOnly = true;
		this.修改_名字.Size = new System.Drawing.Size(267, 23);
		this.修改_名字.TabIndex = 104;
		this.修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_取消按钮.Location = new System.Drawing.Point(191, 155);
		this.修改_取消按钮.Name = "修改_取消按钮";
		this.修改_取消按钮.Size = new System.Drawing.Size(78, 30);
		this.修改_取消按钮.TabIndex = 101;
		this.修改_取消按钮.Text = "取消";
		this.修改_取消按钮.UseVisualStyleBackColor = true;
		this.修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_确定按钮.Location = new System.Drawing.Point(100, 155);
		this.修改_确定按钮.Name = "修改_确定按钮";
		this.修改_确定按钮.Size = new System.Drawing.Size(78, 30);
		this.修改_确定按钮.TabIndex = 100;
		this.修改_确定按钮.Text = "修改";
		this.修改_确定按钮.UseVisualStyleBackColor = true;
		this.label10.Location = new System.Drawing.Point(182, 115);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(60, 23);
		this.label10.TabIndex = 86;
		this.label10.Text = "开南极点";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.元宝礼包_南极点.Location = new System.Drawing.Point(243, 115);
		this.元宝礼包_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.元宝礼包_南极点.Name = "元宝礼包_南极点";
		this.元宝礼包_南极点.Size = new System.Drawing.Size(100, 23);
		this.元宝礼包_南极点.TabIndex = 87;
		this.label11.Location = new System.Drawing.Point(12, 115);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(60, 23);
		this.label11.TabIndex = 84;
		this.label11.Text = "开累充点";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.元宝礼包_累充点.Location = new System.Drawing.Point(73, 115);
		this.元宝礼包_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.元宝礼包_累充点.Name = "元宝礼包_累充点";
		this.元宝礼包_累充点.Size = new System.Drawing.Size(100, 23);
		this.元宝礼包_累充点.TabIndex = 85;
		this.label12.Location = new System.Drawing.Point(351, 115);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(60, 23);
		this.label12.TabIndex = 88;
		this.label12.Text = "开奇宝点";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.元宝礼包_奇宝点.Location = new System.Drawing.Point(412, 115);
		this.元宝礼包_奇宝点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.元宝礼包_奇宝点.Name = "元宝礼包_奇宝点";
		this.元宝礼包_奇宝点.Size = new System.Drawing.Size(100, 23);
		this.元宝礼包_奇宝点.TabIndex = 89;
		this.label14.Location = new System.Drawing.Point(351, 81);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(60, 23);
		this.label14.TabIndex = 90;
		this.label14.Text = "开灵气值";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.元宝礼包_灵气值.Location = new System.Drawing.Point(412, 81);
		this.元宝礼包_灵气值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.元宝礼包_灵气值.Name = "元宝礼包_灵气值";
		this.元宝礼包_灵气值.Size = new System.Drawing.Size(100, 23);
		this.元宝礼包_灵气值.TabIndex = 91;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(630, 450);
		base.Controls.Add(this.label14);
		base.Controls.Add(this.元宝礼包_灵气值);
		base.Controls.Add(this.label12);
		base.Controls.Add(this.元宝礼包_奇宝点);
		base.Controls.Add(this.label10);
		base.Controls.Add(this.元宝礼包_南极点);
		base.Controls.Add(this.label11);
		base.Controls.Add(this.元宝礼包_累充点);
		base.Controls.Add(this.修改窗口);
		base.Controls.Add(this.元宝礼包_添加按钮);
		base.Controls.Add(this.元宝礼包_礼包列表);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.元宝礼包_银元宝);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.元宝礼包_金元宝);
		base.Controls.Add(this.元宝礼包_礼包名字);
		base.Controls.Add(this.元宝礼包_重载按钮);
		base.Controls.Add(this.元宝礼包_保存按钮);
		base.Controls.Add(this.元宝礼包_开关);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "礼包开元宝配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "礼包开元宝配置窗口";
		base.Load += new System.EventHandler(礼包开元宝配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_礼包列表).EndInit();
		this.修改窗口.ResumeLayout(false);
		this.修改窗口.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_灵气值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_奇宝点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_奇宝点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.元宝礼包_灵气值).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
