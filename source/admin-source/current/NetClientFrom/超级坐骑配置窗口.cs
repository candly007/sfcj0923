using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 超级坐骑配置窗口 : Form
{
	private static 超级坐骑配置窗口 i;

	private IContainer components;

	private Button 超级坐骑_重载按钮;

	private Button 超级坐骑_保存按钮;

	private CheckBox 超级坐骑_开关;

	private CheckBox 超级坐骑_战斗开关;

	private Button 超级坐骑_添加按钮;

	private Label label6;

	private TextBox 超级坐骑_坐骑编号;

	private Label label1;

	private TextBox 超级坐骑_飞行编号;

	private Label label2;

	private TextBox 超级坐骑_战斗编号;

	private Label label3;

	private TextBox 超级坐骑_备注;

	private DataGridView 超级坐骑_坐骑列表;

	private DataGridViewTextBoxColumn 坐骑编号;

	private DataGridViewTextBoxColumn 飞行编号;

	private DataGridViewTextBoxColumn 战斗编号;

	private DataGridViewTextBoxColumn 备注;

	private Panel 修改窗口;

	private Label label4;

	private TextBox 修改_坐骑备注;

	private Label label5;

	private TextBox 修改_战斗编号;

	private Label label7;

	private TextBox 修改_飞行编号;

	private Label label8;

	private TextBox 修改_名字;

	private Button 修改_取消按钮;

	private Button 修改_确定按钮;

	public static 超级坐骑配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 超级坐骑配置窗口();
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

	public 超级坐骑配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 超级坐骑配置窗口_Load(object sender, EventArgs e)
	{
		超级坐骑_坐骑列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(修改事件回调, 删除事件回调);
		修改_取消按钮.Click += delegate
		{
			修改窗口.Visible = false;
		};
		修改_确定按钮.Click += 确定修改事件回调;
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		超级坐骑_重载按钮_Click(sender, e);
	}

	private void 修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 超级坐骑_坐骑列表.CurrentRow == null)
		{
			return;
		}
		int index = 超级坐骑_坐骑列表.CurrentRow.Index;
		if (index >= 0)
		{
			DataGridViewCellCollection cells = 超级坐骑_坐骑列表.Rows[index].Cells;
			修改_名字.Text = cells["坐骑编号"].Value.ToString();
			if (Singleton<全局变量类>.I.超级坐骑配置.超级坐骑编号列表.TryGetValue(int.Parse(修改_名字.Text), out 超级坐骑列表类 value))
			{
				修改_飞行编号.Text = value.飞行编号.ToString();
				修改_战斗编号.Text = value.战斗编号.ToString();
				修改_坐骑备注.Text = value.备注;
				修改窗口.Visible = true;
			}
		}
	}

	private void 确定修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || !Singleton<全局变量类>.I.超级坐骑配置.超级坐骑编号列表.TryGetValue(int.Parse(修改_名字.Text), out 超级坐骑列表类 value))
		{
			return;
		}
		int.TryParse(修改_飞行编号.Text, out value.飞行编号);
		int.TryParse(修改_战斗编号.Text, out value.战斗编号);
		value.备注 = 修改_坐骑备注.Text;
		修改窗口.Visible = false;
		MessageBox.Show("[" + 修改_名字.Text + "]的配置已经修改，请及时点击保存配置按钮更新服务端配置！");
		if (超级坐骑_坐骑列表.CurrentRow != null)
		{
			int index = 超级坐骑_坐骑列表.CurrentRow.Index;
			if (index >= 0)
			{
				DataGridViewCellCollection cells = 超级坐骑_坐骑列表.Rows[index].Cells;
				cells["飞行编号"].Value = 修改_飞行编号.Text;
				cells["战斗编号"].Value = 修改_战斗编号.Text;
				cells["备注"].Value = 修改_坐骑备注.Text;
			}
		}
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 超级坐骑_坐骑列表.CurrentRow == null)
		{
			return;
		}
		int index = 超级坐骑_坐骑列表.CurrentRow.Index;
		if (index >= 0)
		{
			int num = (int)超级坐骑_坐骑列表.Rows[index].Cells["坐骑编号"].Value;
			if (Singleton<全局变量类>.I.超级坐骑配置.超级坐骑编号列表.ContainsKey(num))
			{
				Singleton<全局变量类>.I.超级坐骑配置.超级坐骑编号列表.TryRemove(num, out 超级坐骑列表类 _);
				MessageBox.Show($"[{num}]已从列表中删除，请及时点击保存配置按钮更新服务端配置！");
				超级坐骑_坐骑列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 32)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			超级坐骑_开关.Checked = Singleton<全局变量类>.I.超级坐骑配置.功能开关;
			超级坐骑_战斗开关.Checked = Singleton<全局变量类>.I.超级坐骑配置.战斗开关;
			超级坐骑_坐骑列表.Rows.Clear();
			foreach (超级坐骑列表类 value in Singleton<全局变量类>.I.超级坐骑配置.超级坐骑编号列表.Values)
			{
				超级坐骑_坐骑列表.Rows.Add(value.坐骑编号, value.飞行编号, value.战斗编号, value.备注);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.超级坐骑配置.功能开关 = 超级坐骑_开关.Checked;
			Singleton<全局变量类>.I.超级坐骑配置.战斗开关 = 超级坐骑_战斗开关.Checked;
		}
	}

	private void 超级坐骑_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 32, JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级坐骑配置, Formatting.Indented));
		}
	}

	private void 超级坐骑_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 32);
		}
	}

	private void 超级坐骑_添加按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(超级坐骑_坐骑编号.Text))
			{
				MessageBox.Show("请输入要添加的超级坐骑！");
				return;
			}
			if (!int.TryParse(超级坐骑_坐骑编号.Text, out var result))
			{
				MessageBox.Show("请输入要添加的超级坐骑！");
				return;
			}
			if (string.IsNullOrWhiteSpace(超级坐骑_飞行编号.Text))
			{
				MessageBox.Show("请填写飞行编号！");
				return;
			}
			if (Singleton<全局变量类>.I.超级坐骑配置.超级坐骑编号列表.ContainsKey(result))
			{
				MessageBox.Show("列表中已经存在【" + 超级坐骑_坐骑编号.Text + "】，无法重复添加！");
				return;
			}
			超级坐骑列表类 超级坐骑列表类2 = new 超级坐骑列表类
			{
				坐骑编号 = result,
				备注 = 超级坐骑_备注.Text
			};
			int.TryParse(超级坐骑_飞行编号.Text, out 超级坐骑列表类2.飞行编号);
			int.TryParse(超级坐骑_战斗编号.Text, out 超级坐骑列表类2.战斗编号);
			Singleton<全局变量类>.I.超级坐骑配置.超级坐骑编号列表.TryAdd(result, 超级坐骑列表类2);
			超级坐骑_坐骑列表.Rows.Add(超级坐骑列表类2.坐骑编号, 超级坐骑列表类2.飞行编号, 超级坐骑列表类2.战斗编号, 超级坐骑列表类2.备注);
			MessageBox.Show("[" + 超级坐骑_坐骑编号.Text + "]添加成功");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.超级坐骑配置窗口));
		this.超级坐骑_重载按钮 = new System.Windows.Forms.Button();
		this.超级坐骑_保存按钮 = new System.Windows.Forms.Button();
		this.超级坐骑_开关 = new System.Windows.Forms.CheckBox();
		this.超级坐骑_战斗开关 = new System.Windows.Forms.CheckBox();
		this.超级坐骑_添加按钮 = new System.Windows.Forms.Button();
		this.label6 = new System.Windows.Forms.Label();
		this.超级坐骑_坐骑编号 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.超级坐骑_飞行编号 = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.超级坐骑_战斗编号 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.超级坐骑_备注 = new System.Windows.Forms.TextBox();
		this.超级坐骑_坐骑列表 = new System.Windows.Forms.DataGridView();
		this.坐骑编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.飞行编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.战斗编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.修改窗口 = new System.Windows.Forms.Panel();
		this.label4 = new System.Windows.Forms.Label();
		this.修改_坐骑备注 = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.修改_战斗编号 = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.修改_飞行编号 = new System.Windows.Forms.TextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.修改_名字 = new System.Windows.Forms.TextBox();
		this.修改_取消按钮 = new System.Windows.Forms.Button();
		this.修改_确定按钮 = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.超级坐骑_坐骑列表).BeginInit();
		this.修改窗口.SuspendLayout();
		base.SuspendLayout();
		this.超级坐骑_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级坐骑_重载按钮.Location = new System.Drawing.Point(342, 8);
		this.超级坐骑_重载按钮.Name = "超级坐骑_重载按钮";
		this.超级坐骑_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.超级坐骑_重载按钮.TabIndex = 74;
		this.超级坐骑_重载按钮.Text = "重载配置";
		this.超级坐骑_重载按钮.UseVisualStyleBackColor = true;
		this.超级坐骑_重载按钮.Click += new System.EventHandler(超级坐骑_重载按钮_Click);
		this.超级坐骑_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级坐骑_保存按钮.Location = new System.Drawing.Point(236, 8);
		this.超级坐骑_保存按钮.Name = "超级坐骑_保存按钮";
		this.超级坐骑_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.超级坐骑_保存按钮.TabIndex = 73;
		this.超级坐骑_保存按钮.Text = "保存配置";
		this.超级坐骑_保存按钮.UseVisualStyleBackColor = true;
		this.超级坐骑_保存按钮.Click += new System.EventHandler(超级坐骑_保存按钮_Click);
		this.超级坐骑_开关.AutoSize = true;
		this.超级坐骑_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级坐骑_开关.Location = new System.Drawing.Point(12, 12);
		this.超级坐骑_开关.Name = "超级坐骑_开关";
		this.超级坐骑_开关.Size = new System.Drawing.Size(106, 23);
		this.超级坐骑_开关.TabIndex = 72;
		this.超级坐骑_开关.Text = "超级坐骑开关";
		this.超级坐骑_开关.UseVisualStyleBackColor = true;
		this.超级坐骑_战斗开关.AutoSize = true;
		this.超级坐骑_战斗开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级坐骑_战斗开关.Location = new System.Drawing.Point(124, 12);
		this.超级坐骑_战斗开关.Name = "超级坐骑_战斗开关";
		this.超级坐骑_战斗开关.Size = new System.Drawing.Size(106, 23);
		this.超级坐骑_战斗开关.TabIndex = 75;
		this.超级坐骑_战斗开关.Text = "战斗显示开关";
		this.超级坐骑_战斗开关.UseVisualStyleBackColor = true;
		this.超级坐骑_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级坐骑_添加按钮.Location = new System.Drawing.Point(386, 62);
		this.超级坐骑_添加按钮.Name = "超级坐骑_添加按钮";
		this.超级坐骑_添加按钮.Size = new System.Drawing.Size(56, 58);
		this.超级坐骑_添加按钮.TabIndex = 78;
		this.超级坐骑_添加按钮.Text = "添加坐骑";
		this.超级坐骑_添加按钮.UseVisualStyleBackColor = true;
		this.超级坐骑_添加按钮.Click += new System.EventHandler(超级坐骑_添加按钮_Click);
		this.label6.Location = new System.Drawing.Point(12, 62);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(60, 23);
		this.label6.TabIndex = 76;
		this.label6.Text = "坐骑编号";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.超级坐骑_坐骑编号.Location = new System.Drawing.Point(73, 62);
		this.超级坐骑_坐骑编号.Name = "超级坐骑_坐骑编号";
		this.超级坐骑_坐骑编号.Size = new System.Drawing.Size(120, 23);
		this.超级坐骑_坐骑编号.TabIndex = 77;
		this.label1.Location = new System.Drawing.Point(199, 62);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 23);
		this.label1.TabIndex = 79;
		this.label1.Text = "飞行编号";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.超级坐骑_飞行编号.Location = new System.Drawing.Point(260, 62);
		this.超级坐骑_飞行编号.Name = "超级坐骑_飞行编号";
		this.超级坐骑_飞行编号.Size = new System.Drawing.Size(120, 23);
		this.超级坐骑_飞行编号.TabIndex = 80;
		this.label2.Location = new System.Drawing.Point(12, 97);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(60, 23);
		this.label2.TabIndex = 81;
		this.label2.Text = "战斗编号";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.超级坐骑_战斗编号.Location = new System.Drawing.Point(73, 97);
		this.超级坐骑_战斗编号.Name = "超级坐骑_战斗编号";
		this.超级坐骑_战斗编号.Size = new System.Drawing.Size(120, 23);
		this.超级坐骑_战斗编号.TabIndex = 82;
		this.label3.Location = new System.Drawing.Point(199, 97);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(60, 23);
		this.label3.TabIndex = 83;
		this.label3.Text = "坐骑备注";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.超级坐骑_备注.Location = new System.Drawing.Point(260, 97);
		this.超级坐骑_备注.Name = "超级坐骑_备注";
		this.超级坐骑_备注.Size = new System.Drawing.Size(120, 23);
		this.超级坐骑_备注.TabIndex = 84;
		this.超级坐骑_坐骑列表.AllowUserToAddRows = false;
		this.超级坐骑_坐骑列表.AllowUserToDeleteRows = false;
		this.超级坐骑_坐骑列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.超级坐骑_坐骑列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.超级坐骑_坐骑列表.BackgroundColor = System.Drawing.Color.White;
		this.超级坐骑_坐骑列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.超级坐骑_坐骑列表.Columns.AddRange(this.坐骑编号, this.飞行编号, this.战斗编号, this.备注);
		this.超级坐骑_坐骑列表.Location = new System.Drawing.Point(12, 126);
		this.超级坐骑_坐骑列表.MultiSelect = false;
		this.超级坐骑_坐骑列表.Name = "超级坐骑_坐骑列表";
		this.超级坐骑_坐骑列表.ReadOnly = true;
		this.超级坐骑_坐骑列表.RowHeadersVisible = false;
		this.超级坐骑_坐骑列表.RowTemplate.Height = 25;
		this.超级坐骑_坐骑列表.Size = new System.Drawing.Size(430, 312);
		this.超级坐骑_坐骑列表.TabIndex = 85;
		this.坐骑编号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.坐骑编号.HeaderText = "坐骑编号";
		this.坐骑编号.MinimumWidth = 100;
		this.坐骑编号.Name = "坐骑编号";
		this.坐骑编号.ReadOnly = true;
		this.飞行编号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.飞行编号.HeaderText = "飞行编号";
		this.飞行编号.MinimumWidth = 100;
		this.飞行编号.Name = "飞行编号";
		this.飞行编号.ReadOnly = true;
		this.战斗编号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.战斗编号.HeaderText = "战斗编号";
		this.战斗编号.MinimumWidth = 100;
		this.战斗编号.Name = "战斗编号";
		this.战斗编号.ReadOnly = true;
		this.备注.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.备注.HeaderText = "备注";
		this.备注.MinimumWidth = 100;
		this.备注.Name = "备注";
		this.备注.ReadOnly = true;
		this.修改窗口.Controls.Add(this.label4);
		this.修改窗口.Controls.Add(this.修改_坐骑备注);
		this.修改窗口.Controls.Add(this.label5);
		this.修改窗口.Controls.Add(this.修改_战斗编号);
		this.修改窗口.Controls.Add(this.label7);
		this.修改窗口.Controls.Add(this.修改_飞行编号);
		this.修改窗口.Controls.Add(this.label8);
		this.修改窗口.Controls.Add(this.修改_名字);
		this.修改窗口.Controls.Add(this.修改_取消按钮);
		this.修改窗口.Controls.Add(this.修改_确定按钮);
		this.修改窗口.Location = new System.Drawing.Point(96, 139);
		this.修改窗口.Name = "修改窗口";
		this.修改窗口.Size = new System.Drawing.Size(230, 224);
		this.修改窗口.TabIndex = 86;
		this.label4.Location = new System.Drawing.Point(17, 129);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 108;
		this.label4.Text = "坐骑备注";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_坐骑备注.Location = new System.Drawing.Point(78, 129);
		this.修改_坐骑备注.Name = "修改_坐骑备注";
		this.修改_坐骑备注.Size = new System.Drawing.Size(120, 23);
		this.修改_坐骑备注.TabIndex = 109;
		this.label5.Location = new System.Drawing.Point(17, 92);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(60, 23);
		this.label5.TabIndex = 106;
		this.label5.Text = "战斗编号";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_战斗编号.Location = new System.Drawing.Point(78, 92);
		this.修改_战斗编号.Name = "修改_战斗编号";
		this.修改_战斗编号.Size = new System.Drawing.Size(120, 23);
		this.修改_战斗编号.TabIndex = 107;
		this.label7.Location = new System.Drawing.Point(17, 55);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(60, 23);
		this.label7.TabIndex = 104;
		this.label7.Text = "飞行编号";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_飞行编号.Location = new System.Drawing.Point(78, 55);
		this.修改_飞行编号.Name = "修改_飞行编号";
		this.修改_飞行编号.Size = new System.Drawing.Size(120, 23);
		this.修改_飞行编号.TabIndex = 105;
		this.label8.Location = new System.Drawing.Point(17, 20);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(60, 23);
		this.label8.TabIndex = 102;
		this.label8.Text = "坐骑编号";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_名字.Location = new System.Drawing.Point(78, 20);
		this.修改_名字.Name = "修改_名字";
		this.修改_名字.ReadOnly = true;
		this.修改_名字.Size = new System.Drawing.Size(120, 23);
		this.修改_名字.TabIndex = 103;
		this.修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_取消按钮.Location = new System.Drawing.Point(120, 172);
		this.修改_取消按钮.Name = "修改_取消按钮";
		this.修改_取消按钮.Size = new System.Drawing.Size(78, 30);
		this.修改_取消按钮.TabIndex = 101;
		this.修改_取消按钮.Text = "取消";
		this.修改_取消按钮.UseVisualStyleBackColor = true;
		this.修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_确定按钮.Location = new System.Drawing.Point(22, 172);
		this.修改_确定按钮.Name = "修改_确定按钮";
		this.修改_确定按钮.Size = new System.Drawing.Size(78, 30);
		this.修改_确定按钮.TabIndex = 100;
		this.修改_确定按钮.Text = "修改";
		this.修改_确定按钮.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(456, 450);
		base.Controls.Add(this.修改窗口);
		base.Controls.Add(this.超级坐骑_坐骑列表);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.超级坐骑_备注);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.超级坐骑_战斗编号);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.超级坐骑_飞行编号);
		base.Controls.Add(this.超级坐骑_添加按钮);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.超级坐骑_坐骑编号);
		base.Controls.Add(this.超级坐骑_战斗开关);
		base.Controls.Add(this.超级坐骑_重载按钮);
		base.Controls.Add(this.超级坐骑_保存按钮);
		base.Controls.Add(this.超级坐骑_开关);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "超级坐骑配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "超级坐骑配置窗口";
		base.Load += new System.EventHandler(超级坐骑配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.超级坐骑_坐骑列表).EndInit();
		this.修改窗口.ResumeLayout(false);
		this.修改窗口.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
