using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 自选礼包配置窗口 : Form
{
	private static 自选礼包配置窗口 i;

	private IContainer components;

	private Button 自选_重载按钮;

	private Button 自选_保存按钮;

	private TextBox 自选_礼包名字;

	private Label label23;

	private CheckBox 自选_开关;

	private TextBox 自选_选项配置;

	private Label label1;

	private Button 自选_添加按钮;

	private Label label2;

	private Button 自选_例子按钮;

	private DataGridView 自选_自选礼包列表;

	private DataGridViewTextBoxColumn 礼包名字;

	private DataGridViewTextBoxColumn 自选选项;

	private Panel 修改窗口;

	private TextBox 修改_选项配置;

	private Label label4;

	private TextBox 修改_礼包名字;

	private Label label3;

	private Button 修改_取消按钮;

	private Button 修改_确定按钮;

	public static 自选礼包配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 自选礼包配置窗口();
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

	public 自选礼包配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 自选礼包配置窗口_Load(object sender, EventArgs e)
	{
		自选_自选礼包列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(修改事件回调, 删除事件回调);
		修改_取消按钮.Click += delegate
		{
			修改窗口.Visible = false;
		};
		修改_确定按钮.Click += 确定修改事件回调;
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		自选_重载按钮_Click(sender, e);
	}

	private void 修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 自选_自选礼包列表.CurrentRow == null)
		{
			return;
		}
		int index = 自选_自选礼包列表.CurrentRow.Index;
		if (index >= 0)
		{
			DataGridViewCellCollection cells = 自选_自选礼包列表.Rows[index].Cells;
			修改_礼包名字.Text = cells["礼包名字"].Value.ToString();
			if (Singleton<全局变量类>.I.自选道具配置.自选道具列表.ContainsKey(修改_礼包名字.Text))
			{
				修改_选项配置.Text = cells["自选选项"].Value.ToString();
				修改窗口.Visible = true;
			}
		}
	}

	private void 确定修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || !Singleton<全局变量类>.I.自选道具配置.自选道具列表.TryGetValue(修改_礼包名字.Text, out 自选道具列表类 value))
		{
			return;
		}
		value.选项配置 = 修改_选项配置.Text;
		修改窗口.Visible = false;
		MessageBox.Show("[" + 修改_礼包名字.Text + "]的配置已经修改，请及时点击保存配置按钮更新服务端配置！");
		if (自选_自选礼包列表.CurrentRow != null)
		{
			int index = 自选_自选礼包列表.CurrentRow.Index;
			if (index >= 0)
			{
				自选_自选礼包列表.Rows[index].Cells["自选选项"].Value = 修改_选项配置.Text;
			}
		}
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 自选_自选礼包列表.CurrentRow == null)
		{
			return;
		}
		int index = 自选_自选礼包列表.CurrentRow.Index;
		if (index >= 0)
		{
			string text = 自选_自选礼包列表.Rows[index].Cells["礼包名字"].Value.ToString();
			if (Singleton<全局变量类>.I.自选道具配置.自选道具列表.ContainsKey(text))
			{
				Singleton<全局变量类>.I.自选道具配置.自选道具列表.TryRemove(text, out 自选道具列表类 _);
				MessageBox.Show("[" + text + "]已从列表中删除，请及时点击保存配置按钮更新服务端配置！");
				自选_自选礼包列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 24)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			自选_开关.Checked = Singleton<全局变量类>.I.自选道具配置.功能开关;
			自选_自选礼包列表.Rows.Clear();
			foreach (自选道具列表类 value in Singleton<全局变量类>.I.自选道具配置.自选道具列表.Values)
			{
				自选_自选礼包列表.Rows.Add(value.道具名字, value.选项配置);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.自选道具配置.功能开关 = 自选_开关.Checked;
		}
	}

	private void 自选_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 24, JsonConvert.SerializeObject(Singleton<全局变量类>.I.自选道具配置, Formatting.Indented));
		}
	}

	private void 自选_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 24);
		}
	}

	private void 自选_例子按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			自选_礼包名字.Text = "锦囊";
			自选_选项配置.Text = "[自选·血玲珑/确定自选_血玲珑][自选·法玲珑/确定自选_法玲珑][自选·血池/确定自选_血池]";
		}
	}

	private void 自选_添加按钮_Click(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		自选_自选礼包列表.Invoke((MethodInvoker)delegate
		{
			if (string.IsNullOrWhiteSpace(自选_礼包名字.Text))
			{
				MessageBox.Show("请输入要添加的自选礼包名字！");
			}
			else if (string.IsNullOrWhiteSpace(自选_选项配置.Text))
			{
				MessageBox.Show("请输入[" + 自选_礼包名字.Text + "]对应的自选选项！");
			}
			else if (Singleton<全局变量类>.I.自选道具配置.自选道具列表.ContainsKey(自选_礼包名字.Text))
			{
				MessageBox.Show("[" + 自选_礼包名字.Text + "]自选礼包已经存在！");
			}
			else
			{
				自选道具列表类 自选道具列表类2 = new 自选道具列表类
				{
					道具名字 = 自选_礼包名字.Text,
					选项配置 = 自选_选项配置.Text
				};
				Singleton<全局变量类>.I.自选道具配置.自选道具列表.TryAdd(自选道具列表类2.道具名字, 自选道具列表类2);
				自选_自选礼包列表.Rows.Add(自选道具列表类2.道具名字, 自选道具列表类2.选项配置);
				MessageBox.Show("[" + 自选_礼包名字.Text + "]添加成功，请点击保存配置实时同步到服务器！");
			}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.自选礼包配置窗口));
		this.自选_重载按钮 = new System.Windows.Forms.Button();
		this.自选_保存按钮 = new System.Windows.Forms.Button();
		this.自选_礼包名字 = new System.Windows.Forms.TextBox();
		this.label23 = new System.Windows.Forms.Label();
		this.自选_开关 = new System.Windows.Forms.CheckBox();
		this.自选_选项配置 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.自选_添加按钮 = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.自选_例子按钮 = new System.Windows.Forms.Button();
		this.自选_自选礼包列表 = new System.Windows.Forms.DataGridView();
		this.礼包名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.自选选项 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.修改窗口 = new System.Windows.Forms.Panel();
		this.修改_取消按钮 = new System.Windows.Forms.Button();
		this.修改_确定按钮 = new System.Windows.Forms.Button();
		this.修改_选项配置 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.修改_礼包名字 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.自选_自选礼包列表).BeginInit();
		this.修改窗口.SuspendLayout();
		base.SuspendLayout();
		this.自选_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.自选_重载按钮.Location = new System.Drawing.Point(260, 7);
		this.自选_重载按钮.Name = "自选_重载按钮";
		this.自选_重载按钮.Size = new System.Drawing.Size(130, 30);
		this.自选_重载按钮.TabIndex = 52;
		this.自选_重载按钮.Text = "重载自选配置";
		this.自选_重载按钮.UseVisualStyleBackColor = true;
		this.自选_重载按钮.Click += new System.EventHandler(自选_重载按钮_Click);
		this.自选_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.自选_保存按钮.Location = new System.Drawing.Point(124, 7);
		this.自选_保存按钮.Name = "自选_保存按钮";
		this.自选_保存按钮.Size = new System.Drawing.Size(130, 30);
		this.自选_保存按钮.TabIndex = 51;
		this.自选_保存按钮.Text = "保存自选配置";
		this.自选_保存按钮.UseVisualStyleBackColor = true;
		this.自选_保存按钮.Click += new System.EventHandler(自选_保存按钮_Click);
		this.自选_礼包名字.Location = new System.Drawing.Point(78, 48);
		this.自选_礼包名字.Name = "自选_礼包名字";
		this.自选_礼包名字.Size = new System.Drawing.Size(150, 23);
		this.自选_礼包名字.TabIndex = 50;
		this.label23.Location = new System.Drawing.Point(12, 48);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(65, 23);
		this.label23.TabIndex = 49;
		this.label23.Text = "礼包名字";
		this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.自选_开关.AutoSize = true;
		this.自选_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.自选_开关.Location = new System.Drawing.Point(12, 12);
		this.自选_开关.Name = "自选_开关";
		this.自选_开关.Size = new System.Drawing.Size(106, 23);
		this.自选_开关.TabIndex = 48;
		this.自选_开关.Text = "自选礼包开关";
		this.自选_开关.UseVisualStyleBackColor = true;
		this.自选_选项配置.Location = new System.Drawing.Point(78, 74);
		this.自选_选项配置.Name = "自选_选项配置";
		this.自选_选项配置.Size = new System.Drawing.Size(651, 23);
		this.自选_选项配置.TabIndex = 54;
		this.label1.Location = new System.Drawing.Point(12, 74);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(65, 23);
		this.label1.TabIndex = 53;
		this.label1.Text = "选项配置";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.自选_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.自选_添加按钮.Location = new System.Drawing.Point(735, 69);
		this.自选_添加按钮.Name = "自选_添加按钮";
		this.自选_添加按钮.Size = new System.Drawing.Size(53, 30);
		this.自选_添加按钮.TabIndex = 55;
		this.自选_添加按钮.Text = "添加";
		this.自选_添加按钮.UseVisualStyleBackColor = true;
		this.自选_添加按钮.Click += new System.EventHandler(自选_添加按钮_Click);
		this.label2.ForeColor = System.Drawing.Color.Red;
		this.label2.Location = new System.Drawing.Point(78, 100);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(651, 23);
		this.label2.TabIndex = 56;
		this.label2.Text = "选项固定格式：[自选·道具名字/确定自选_道具名字][自选·道具名字/确定自选_道具名字]";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.自选_例子按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.自选_例子按钮.Location = new System.Drawing.Point(234, 47);
		this.自选_例子按钮.Name = "自选_例子按钮";
		this.自选_例子按钮.Size = new System.Drawing.Size(90, 25);
		this.自选_例子按钮.TabIndex = 57;
		this.自选_例子按钮.Text = "举个例子";
		this.自选_例子按钮.UseVisualStyleBackColor = true;
		this.自选_例子按钮.Click += new System.EventHandler(自选_例子按钮_Click);
		this.自选_自选礼包列表.AllowUserToAddRows = false;
		this.自选_自选礼包列表.AllowUserToDeleteRows = false;
		this.自选_自选礼包列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.自选_自选礼包列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.自选_自选礼包列表.BackgroundColor = System.Drawing.Color.White;
		this.自选_自选礼包列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.自选_自选礼包列表.Columns.AddRange(this.礼包名字, this.自选选项);
		this.自选_自选礼包列表.Location = new System.Drawing.Point(12, 126);
		this.自选_自选礼包列表.MultiSelect = false;
		this.自选_自选礼包列表.Name = "自选_自选礼包列表";
		this.自选_自选礼包列表.ReadOnly = true;
		this.自选_自选礼包列表.RowHeadersVisible = false;
		this.自选_自选礼包列表.RowTemplate.Height = 25;
		this.自选_自选礼包列表.Size = new System.Drawing.Size(776, 312);
		this.自选_自选礼包列表.TabIndex = 79;
		this.礼包名字.HeaderText = "礼包名字";
		this.礼包名字.Name = "礼包名字";
		this.礼包名字.ReadOnly = true;
		this.礼包名字.Width = 170;
		this.自选选项.HeaderText = "自选选项";
		this.自选选项.Name = "自选选项";
		this.自选选项.ReadOnly = true;
		this.自选选项.Width = 600;
		this.修改窗口.Controls.Add(this.修改_取消按钮);
		this.修改窗口.Controls.Add(this.修改_确定按钮);
		this.修改窗口.Controls.Add(this.修改_选项配置);
		this.修改窗口.Controls.Add(this.label4);
		this.修改窗口.Controls.Add(this.修改_礼包名字);
		this.修改窗口.Controls.Add(this.label3);
		this.修改窗口.Location = new System.Drawing.Point(219, 126);
		this.修改窗口.Name = "修改窗口";
		this.修改窗口.Size = new System.Drawing.Size(304, 302);
		this.修改窗口.TabIndex = 80;
		this.修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_取消按钮.Location = new System.Drawing.Point(162, 248);
		this.修改_取消按钮.Name = "修改_取消按钮";
		this.修改_取消按钮.Size = new System.Drawing.Size(118, 30);
		this.修改_取消按钮.TabIndex = 101;
		this.修改_取消按钮.Text = "取消";
		this.修改_取消按钮.UseVisualStyleBackColor = true;
		this.修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_确定按钮.Location = new System.Drawing.Point(22, 248);
		this.修改_确定按钮.Name = "修改_确定按钮";
		this.修改_确定按钮.Size = new System.Drawing.Size(118, 30);
		this.修改_确定按钮.TabIndex = 100;
		this.修改_确定按钮.Text = "修改";
		this.修改_确定按钮.UseVisualStyleBackColor = true;
		this.修改_选项配置.Location = new System.Drawing.Point(72, 47);
		this.修改_选项配置.Multiline = true;
		this.修改_选项配置.Name = "修改_选项配置";
		this.修改_选项配置.Size = new System.Drawing.Size(208, 177);
		this.修改_选项配置.TabIndex = 54;
		this.label4.Location = new System.Drawing.Point(6, 47);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(65, 23);
		this.label4.TabIndex = 53;
		this.label4.Text = "选项配置";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_礼包名字.Location = new System.Drawing.Point(72, 16);
		this.修改_礼包名字.Name = "修改_礼包名字";
		this.修改_礼包名字.ReadOnly = true;
		this.修改_礼包名字.Size = new System.Drawing.Size(208, 23);
		this.修改_礼包名字.TabIndex = 52;
		this.label3.Location = new System.Drawing.Point(6, 16);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(65, 23);
		this.label3.TabIndex = 51;
		this.label3.Text = "礼包名字";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(800, 450);
		base.Controls.Add(this.修改窗口);
		base.Controls.Add(this.自选_自选礼包列表);
		base.Controls.Add(this.自选_例子按钮);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.自选_添加按钮);
		base.Controls.Add(this.自选_选项配置);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.自选_重载按钮);
		base.Controls.Add(this.自选_保存按钮);
		base.Controls.Add(this.自选_礼包名字);
		base.Controls.Add(this.label23);
		base.Controls.Add(this.自选_开关);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "自选礼包配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "自选礼包配置窗口";
		base.Load += new System.EventHandler(自选礼包配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.自选_自选礼包列表).EndInit();
		this.修改窗口.ResumeLayout(false);
		this.修改窗口.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
