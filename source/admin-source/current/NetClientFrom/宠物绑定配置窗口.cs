using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 宠物绑定配置窗口 : Form
{
	private static 宠物绑定配置窗口 i;

	private IContainer components;

	private Button 宠物绑定_添加按钮;

	private Button 宠物绑定_重载按钮;

	private Button 宠物绑定_保存按钮;

	private TextBox 宠物绑定_自动绑定宠物名字;

	private Label label23;

	private CheckBox 宠物绑定_开关;

	private CheckBox 宠物绑定_死绑开关;

	private Label label1;

	private TextBox 宠物绑定_礼包名字;

	private Label label2;

	private TextBox 宠物绑定_礼包宠物名字;

	private Label label3;

	private DataGridView 宠物绑定_绑定列表;

	private DataGridViewTextBoxColumn 礼包名字;

	private DataGridViewTextBoxColumn 绑定宠物列表;

	private Label label4;

	private Panel 修改窗口;

	private TextBox 修改_宠物名字;

	private Label label5;

	private TextBox 修改_名字;

	private Label label6;

	private Button 修改_取消按钮;

	private Button 修改_确定按钮;

	public static 宠物绑定配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 宠物绑定配置窗口();
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

	public 宠物绑定配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 宠物绑定配置窗口_Load(object sender, EventArgs e)
	{
		宠物绑定_绑定列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(修改事件回调, 删除事件回调);
		修改_取消按钮.Click += delegate
		{
			修改窗口.Visible = false;
		};
		修改_确定按钮.Click += 确定修改事件回调;
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		宠物绑定_重载按钮_Click(sender, e);
	}

	private void 修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 宠物绑定_绑定列表.CurrentRow == null)
		{
			return;
		}
		int index = 宠物绑定_绑定列表.CurrentRow.Index;
		if (index >= 0)
		{
			DataGridViewCellCollection cells = 宠物绑定_绑定列表.Rows[index].Cells;
			修改_名字.Text = cells["礼包名字"].Value.ToString();
			if (Singleton<全局变量类>.I.宠物绑定配置.道具宠物绑定列表.ContainsKey(修改_名字.Text))
			{
				修改_宠物名字.Text = Singleton<全局变量类>.I.宠物绑定配置.道具宠物绑定列表[修改_名字.Text];
				修改窗口.Visible = true;
			}
		}
	}

	private void 确定修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || !Singleton<全局变量类>.I.宠物绑定配置.道具宠物绑定列表.ContainsKey(修改_名字.Text))
		{
			return;
		}
		Singleton<全局变量类>.I.宠物绑定配置.道具宠物绑定列表[修改_名字.Text] = 修改_宠物名字.Text;
		修改窗口.Visible = false;
		if (宠物绑定_绑定列表.CurrentRow != null)
		{
			int index = 宠物绑定_绑定列表.CurrentRow.Index;
			if (index >= 0)
			{
				宠物绑定_绑定列表.Rows[index].Cells["绑定宠物列表"].Value = 修改_宠物名字.Text;
				MessageBox.Show("[" + 修改_名字.Text + "]的配置已经修改，请及时点击保存配置按钮更新服务端配置！");
			}
		}
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 宠物绑定_绑定列表.CurrentRow == null)
		{
			return;
		}
		int index = 宠物绑定_绑定列表.CurrentRow.Index;
		if (index >= 0)
		{
			string text = 宠物绑定_绑定列表.Rows[index].Cells["礼包名字"].Value.ToString();
			if (Singleton<全局变量类>.I.宠物绑定配置.道具宠物绑定列表.ContainsKey(text))
			{
				Singleton<全局变量类>.I.宠物绑定配置.道具宠物绑定列表.TryRemove(text, out string _);
				MessageBox.Show("[" + text + "]已从列表中删除，请及时点击保存配置按钮更新服务端配置！");
				宠物绑定_绑定列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 25)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			宠物绑定_开关.Checked = Singleton<全局变量类>.I.宠物绑定配置.功能开关;
			宠物绑定_死绑开关.Checked = Singleton<全局变量类>.I.宠物绑定配置.is死绑开关;
			宠物绑定_自动绑定宠物名字.Text = Singleton<全局变量类>.I.宠物绑定配置.宠物自动绑定列表;
			宠物绑定_绑定列表.Rows.Clear();
			foreach (KeyValuePair<string, string> item in Singleton<全局变量类>.I.宠物绑定配置.道具宠物绑定列表)
			{
				宠物绑定_绑定列表.Rows.Add(item.Key, item.Value);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.宠物绑定配置.功能开关 = 宠物绑定_开关.Checked;
			Singleton<全局变量类>.I.宠物绑定配置.is死绑开关 = 宠物绑定_死绑开关.Checked;
			Singleton<全局变量类>.I.宠物绑定配置.宠物自动绑定列表 = 宠物绑定_自动绑定宠物名字.Text;
		}
	}

	private void 宠物绑定_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 25, JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物绑定配置, Formatting.Indented));
		}
	}

	private void 宠物绑定_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 25);
		}
	}

	private void 宠物绑定_添加按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(宠物绑定_礼包名字.Text))
			{
				MessageBox.Show("请输入礼包名字！");
				return;
			}
			if (string.IsNullOrWhiteSpace(宠物绑定_礼包宠物名字.Text))
			{
				MessageBox.Show("请选择要绑定的宠物名字！");
				return;
			}
			if (Singleton<全局变量类>.I.宠物绑定配置.道具宠物绑定列表.ContainsKey(宠物绑定_礼包名字.Text))
			{
				MessageBox.Show("列表中已经存在【" + 宠物绑定_礼包名字.Text + "】，无法重复添加！");
				return;
			}
			Singleton<全局变量类>.I.宠物绑定配置.道具宠物绑定列表.TryAdd(宠物绑定_礼包名字.Text, 宠物绑定_礼包宠物名字.Text);
			宠物绑定_绑定列表.Rows.Add(宠物绑定_礼包名字.Text, 宠物绑定_礼包宠物名字.Text);
			MessageBox.Show("[" + 宠物绑定_礼包名字.Text + "]添加成功");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.宠物绑定配置窗口));
		this.宠物绑定_添加按钮 = new System.Windows.Forms.Button();
		this.宠物绑定_重载按钮 = new System.Windows.Forms.Button();
		this.宠物绑定_保存按钮 = new System.Windows.Forms.Button();
		this.宠物绑定_自动绑定宠物名字 = new System.Windows.Forms.TextBox();
		this.label23 = new System.Windows.Forms.Label();
		this.宠物绑定_开关 = new System.Windows.Forms.CheckBox();
		this.宠物绑定_死绑开关 = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.宠物绑定_礼包名字 = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.宠物绑定_礼包宠物名字 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.宠物绑定_绑定列表 = new System.Windows.Forms.DataGridView();
		this.礼包名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.绑定宠物列表 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.label4 = new System.Windows.Forms.Label();
		this.修改窗口 = new System.Windows.Forms.Panel();
		this.修改_宠物名字 = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.修改_名字 = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.修改_取消按钮 = new System.Windows.Forms.Button();
		this.修改_确定按钮 = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.宠物绑定_绑定列表).BeginInit();
		this.修改窗口.SuspendLayout();
		base.SuspendLayout();
		this.宠物绑定_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.宠物绑定_添加按钮.Location = new System.Drawing.Point(370, 103);
		this.宠物绑定_添加按钮.Name = "宠物绑定_添加按钮";
		this.宠物绑定_添加按钮.Size = new System.Drawing.Size(130, 23);
		this.宠物绑定_添加按钮.TabIndex = 63;
		this.宠物绑定_添加按钮.Text = "添加绑定宠物礼包";
		this.宠物绑定_添加按钮.UseVisualStyleBackColor = true;
		this.宠物绑定_添加按钮.Click += new System.EventHandler(宠物绑定_添加按钮_Click);
		this.宠物绑定_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.宠物绑定_重载按钮.Location = new System.Drawing.Point(370, 7);
		this.宠物绑定_重载按钮.Name = "宠物绑定_重载按钮";
		this.宠物绑定_重载按钮.Size = new System.Drawing.Size(130, 30);
		this.宠物绑定_重载按钮.TabIndex = 62;
		this.宠物绑定_重载按钮.Text = "重载绑定配置";
		this.宠物绑定_重载按钮.UseVisualStyleBackColor = true;
		this.宠物绑定_重载按钮.Click += new System.EventHandler(宠物绑定_重载按钮_Click);
		this.宠物绑定_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.宠物绑定_保存按钮.Location = new System.Drawing.Point(234, 7);
		this.宠物绑定_保存按钮.Name = "宠物绑定_保存按钮";
		this.宠物绑定_保存按钮.Size = new System.Drawing.Size(130, 30);
		this.宠物绑定_保存按钮.TabIndex = 61;
		this.宠物绑定_保存按钮.Text = "保存绑定配置";
		this.宠物绑定_保存按钮.UseVisualStyleBackColor = true;
		this.宠物绑定_保存按钮.Click += new System.EventHandler(宠物绑定_保存按钮_Click);
		this.宠物绑定_自动绑定宠物名字.Location = new System.Drawing.Point(122, 48);
		this.宠物绑定_自动绑定宠物名字.Name = "宠物绑定_自动绑定宠物名字";
		this.宠物绑定_自动绑定宠物名字.Size = new System.Drawing.Size(378, 23);
		this.宠物绑定_自动绑定宠物名字.TabIndex = 60;
		this.label23.Location = new System.Drawing.Point(12, 48);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(110, 23);
		this.label23.TabIndex = 59;
		this.label23.Text = "自动绑定宠物名字";
		this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.宠物绑定_开关.AutoSize = true;
		this.宠物绑定_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.宠物绑定_开关.Location = new System.Drawing.Point(12, 12);
		this.宠物绑定_开关.Name = "宠物绑定_开关";
		this.宠物绑定_开关.Size = new System.Drawing.Size(106, 23);
		this.宠物绑定_开关.TabIndex = 58;
		this.宠物绑定_开关.Text = "宠物绑定开关";
		this.宠物绑定_开关.UseVisualStyleBackColor = true;
		this.宠物绑定_死绑开关.AutoSize = true;
		this.宠物绑定_死绑开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.宠物绑定_死绑开关.Location = new System.Drawing.Point(122, 12);
		this.宠物绑定_死绑开关.Name = "宠物绑定_死绑开关";
		this.宠物绑定_死绑开关.Size = new System.Drawing.Size(106, 23);
		this.宠物绑定_死绑开关.TabIndex = 64;
		this.宠物绑定_死绑开关.Text = "宠物死绑开关";
		this.宠物绑定_死绑开关.UseVisualStyleBackColor = true;
		this.label1.ForeColor = System.Drawing.Color.Red;
		this.label1.Location = new System.Drawing.Point(12, 71);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(488, 23);
		this.label1.TabIndex = 65;
		this.label1.Text = "从任何方式获取到自动绑定配置中的宠物时，系统将自动绑定，格式：青蛙|金头陀";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.宠物绑定_礼包名字.Location = new System.Drawing.Point(122, 103);
		this.宠物绑定_礼包名字.Name = "宠物绑定_礼包名字";
		this.宠物绑定_礼包名字.Size = new System.Drawing.Size(242, 23);
		this.宠物绑定_礼包名字.TabIndex = 67;
		this.label2.Location = new System.Drawing.Point(12, 103);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(110, 23);
		this.label2.TabIndex = 66;
		this.label2.Text = "打开绑定宠物礼包";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.宠物绑定_礼包宠物名字.Location = new System.Drawing.Point(122, 129);
		this.宠物绑定_礼包宠物名字.Name = "宠物绑定_礼包宠物名字";
		this.宠物绑定_礼包宠物名字.Size = new System.Drawing.Size(242, 23);
		this.宠物绑定_礼包宠物名字.TabIndex = 69;
		this.label3.Location = new System.Drawing.Point(12, 129);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(110, 23);
		this.label3.TabIndex = 68;
		this.label3.Text = "礼包需绑定宠物名";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.宠物绑定_绑定列表.AllowUserToAddRows = false;
		this.宠物绑定_绑定列表.AllowUserToDeleteRows = false;
		this.宠物绑定_绑定列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.宠物绑定_绑定列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.宠物绑定_绑定列表.BackgroundColor = System.Drawing.Color.White;
		this.宠物绑定_绑定列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.宠物绑定_绑定列表.Columns.AddRange(this.礼包名字, this.绑定宠物列表);
		this.宠物绑定_绑定列表.Location = new System.Drawing.Point(12, 158);
		this.宠物绑定_绑定列表.MultiSelect = false;
		this.宠物绑定_绑定列表.Name = "宠物绑定_绑定列表";
		this.宠物绑定_绑定列表.ReadOnly = true;
		this.宠物绑定_绑定列表.RowHeadersVisible = false;
		this.宠物绑定_绑定列表.RowTemplate.Height = 25;
		this.宠物绑定_绑定列表.Size = new System.Drawing.Size(488, 280);
		this.宠物绑定_绑定列表.TabIndex = 80;
		this.礼包名字.HeaderText = "礼包名字";
		this.礼包名字.Name = "礼包名字";
		this.礼包名字.ReadOnly = true;
		this.礼包名字.Width = 184;
		this.绑定宠物列表.HeaderText = "绑定宠物列表";
		this.绑定宠物列表.Name = "绑定宠物列表";
		this.绑定宠物列表.ReadOnly = true;
		this.绑定宠物列表.Width = 300;
		this.label4.ForeColor = System.Drawing.Color.Red;
		this.label4.Location = new System.Drawing.Point(370, 129);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(130, 23);
		this.label4.TabIndex = 81;
		this.label4.Text = "格式：青蛙|金头陀";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改窗口.Controls.Add(this.修改_宠物名字);
		this.修改窗口.Controls.Add(this.label5);
		this.修改窗口.Controls.Add(this.修改_名字);
		this.修改窗口.Controls.Add(this.label6);
		this.修改窗口.Controls.Add(this.修改_取消按钮);
		this.修改窗口.Controls.Add(this.修改_确定按钮);
		this.修改窗口.Location = new System.Drawing.Point(37, 201);
		this.修改窗口.Name = "修改窗口";
		this.修改窗口.Size = new System.Drawing.Size(406, 170);
		this.修改窗口.TabIndex = 82;
		this.修改_宠物名字.Location = new System.Drawing.Point(132, 47);
		this.修改_宠物名字.Multiline = true;
		this.修改_宠物名字.Name = "修改_宠物名字";
		this.修改_宠物名字.Size = new System.Drawing.Size(242, 69);
		this.修改_宠物名字.TabIndex = 105;
		this.label5.Location = new System.Drawing.Point(22, 47);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(110, 23);
		this.label5.TabIndex = 104;
		this.label5.Text = "礼包需绑定宠物名";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_名字.Location = new System.Drawing.Point(132, 21);
		this.修改_名字.Name = "修改_名字";
		this.修改_名字.ReadOnly = true;
		this.修改_名字.Size = new System.Drawing.Size(242, 23);
		this.修改_名字.TabIndex = 103;
		this.label6.Location = new System.Drawing.Point(22, 21);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(110, 23);
		this.label6.TabIndex = 102;
		this.label6.Text = "打开绑定宠物礼包";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_取消按钮.Location = new System.Drawing.Point(198, 122);
		this.修改_取消按钮.Name = "修改_取消按钮";
		this.修改_取消按钮.Size = new System.Drawing.Size(118, 30);
		this.修改_取消按钮.TabIndex = 101;
		this.修改_取消按钮.Text = "取消";
		this.修改_取消按钮.UseVisualStyleBackColor = true;
		this.修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_确定按钮.Location = new System.Drawing.Point(58, 122);
		this.修改_确定按钮.Name = "修改_确定按钮";
		this.修改_确定按钮.Size = new System.Drawing.Size(118, 30);
		this.修改_确定按钮.TabIndex = 100;
		this.修改_确定按钮.Text = "修改";
		this.修改_确定按钮.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(510, 450);
		base.Controls.Add(this.修改窗口);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.宠物绑定_绑定列表);
		base.Controls.Add(this.宠物绑定_礼包宠物名字);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.宠物绑定_礼包名字);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.宠物绑定_死绑开关);
		base.Controls.Add(this.宠物绑定_添加按钮);
		base.Controls.Add(this.宠物绑定_重载按钮);
		base.Controls.Add(this.宠物绑定_保存按钮);
		base.Controls.Add(this.宠物绑定_自动绑定宠物名字);
		base.Controls.Add(this.label23);
		base.Controls.Add(this.宠物绑定_开关);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "宠物绑定配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "宠物绑定配置窗口";
		base.Load += new System.EventHandler(宠物绑定配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.宠物绑定_绑定列表).EndInit();
		this.修改窗口.ResumeLayout(false);
		this.修改窗口.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
