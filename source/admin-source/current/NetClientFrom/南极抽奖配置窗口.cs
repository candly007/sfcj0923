using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 南极抽奖配置窗口 : Form
{
	private static 南极抽奖配置窗口 i;

	private IContainer components;

	private CheckBox 南极抽奖_开关;

	private Button 南极抽奖_重载按钮;

	private Button 南极抽奖_保存按钮;

	private CheckBox 南极抽奖_大额抽奖;

	private Label label1;

	private TextBox 南极抽奖_到期时间;

	private Label label2;

	private TextBox 南极抽奖_活动描述;

	private GroupBox groupBox1;

	private Label label3;

	private TextBox 南极抽奖_添加奖品;

	private ComboBox 南极抽奖_奖品等级;

	private Label label4;

	private NumericUpDown 南极抽奖_奖品概率;

	private Label label7;

	private NumericUpDown 南极抽奖_奖品数量;

	private Label label6;

	private NumericUpDown 南极抽奖_奖品图标;

	private Label label5;

	private Button 南极抽奖_添加按钮;

	private DataGridView 南极抽奖_奖品列表;

	private CheckBox 南极抽奖_是否大额;

	private NumericUpDown 南极抽奖_出特等次数;

	private Label label8;

	private DataGridViewTextBoxColumn 奖品名字;

	private DataGridViewTextBoxColumn 奖品类别;

	private DataGridViewTextBoxColumn 奖品等级;

	private DataGridViewTextBoxColumn 奖品图标;

	private DataGridViewTextBoxColumn 奖品数量;

	private DataGridViewTextBoxColumn 奖品概率;

	public static 南极抽奖配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 南极抽奖配置窗口();
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

	public 南极抽奖配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 南极抽奖配置窗口_Load(object sender, EventArgs e)
	{
		南极抽奖_奖品列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 删除事件回调);
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		南极抽奖_重载按钮_Click(sender, e);
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 南极抽奖_奖品列表.CurrentRow != null)
		{
			int index = 南极抽奖_奖品列表.CurrentRow.Index;
			if (index >= 0)
			{
				南极抽奖_奖品列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 2)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			南极抽奖_开关.Checked = Singleton<全局变量类>.I.南极配置.功能开关;
			南极抽奖_大额抽奖.Checked = Singleton<全局变量类>.I.南极配置.is开启大额;
			南极抽奖_到期时间.Text = Singleton<全局变量类>.I.南极配置.到期时间;
			南极抽奖_活动描述.Text = Singleton<全局变量类>.I.南极配置.活动描述;
			南极抽奖_出特等次数.Value = Singleton<全局变量类>.I.南极配置.总累计出特等;
			南极抽奖_奖品列表.Rows.Clear();
			for (int i = 0; i < Singleton<全局变量类>.I.南极配置.奖池.Count; i++)
			{
				南极抽奖物品类 南极抽奖物品类2 = Singleton<全局变量类>.I.南极配置.奖池[i];
				南极抽奖_奖品列表.Rows.Add(南极抽奖物品类2.名字, 南极抽奖物品类2.is大额 ? "大额" : "小额", 南极抽奖物品类2.等级, 南极抽奖物品类2.图标, 南极抽奖物品类2.数量, 南极抽奖物品类2.概率);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		Singleton<全局变量类>.I.南极配置.功能开关 = 南极抽奖_开关.Checked;
		Singleton<全局变量类>.I.南极配置.is开启大额 = 南极抽奖_大额抽奖.Checked;
		Singleton<全局变量类>.I.南极配置.到期时间 = 南极抽奖_到期时间.Text;
		Singleton<全局变量类>.I.南极配置.活动描述 = 南极抽奖_活动描述.Text;
		Singleton<全局变量类>.I.南极配置.总累计出特等 = (int)南极抽奖_出特等次数.Value;
		Singleton<全局变量类>.I.南极配置.奖池.Clear();
		for (int i = 0; i < 南极抽奖_奖品列表.Rows.Count; i++)
		{
			DataGridViewCellCollection cells = 南极抽奖_奖品列表.Rows[i].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value.ToString()))
			{
				南极抽奖物品类 南极抽奖物品类2 = new 南极抽奖物品类
				{
					名字 = cells[0].Value.ToString(),
					is大额 = (cells[1].Value.ToString() == "大额")
				};
				Enum.TryParse<AllEnums.奖品Type>(cells[2].Value.ToString(), out 南极抽奖物品类2.等级);
				南极抽奖物品类2.图标 = int.Parse(cells[3].Value.ToString());
				南极抽奖物品类2.数量 = int.Parse(cells[4].Value.ToString());
				南极抽奖物品类2.概率 = int.Parse(cells[5].Value.ToString());
				Singleton<全局变量类>.I.南极配置.奖池.Add(南极抽奖物品类2);
			}
		}
	}

	private void 南极抽奖_添加按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(南极抽奖_添加奖品.Text))
			{
				MessageBox.Show("请输入要添加回收的宠物或者道具！");
				return;
			}
			if (string.IsNullOrWhiteSpace(南极抽奖_奖品等级.Text))
			{
				MessageBox.Show("请选择要添加回收的类型！");
				return;
			}
			if (Singleton<全局变量类>.I.南极配置.奖池.Any((南极抽奖物品类 x) => x.名字 == 南极抽奖_添加奖品.Text && x.is大额 == 南极抽奖_是否大额.Checked))
			{
				MessageBox.Show($"南极列表中已经存在【{(南极抽奖_是否大额.Checked ? "大额" : "小额")}-{南极抽奖_添加奖品.Text}】，无法重复添加！");
				return;
			}
			Singleton<全局变量类>.I.南极配置.奖池.Add(new 南极抽奖物品类
			{
				名字 = 南极抽奖_添加奖品.Text,
				is大额 = 南极抽奖_是否大额.Checked,
				等级 = Enum.Parse<AllEnums.奖品Type>(南极抽奖_奖品等级.Text),
				图标 = (int)南极抽奖_奖品图标.Value,
				数量 = (int)南极抽奖_奖品数量.Value,
				概率 = (int)南极抽奖_奖品概率.Value
			});
			南极抽奖_奖品列表.Rows.Add(南极抽奖_添加奖品.Text, 南极抽奖_是否大额.Checked ? "大额" : "小额", 南极抽奖_奖品等级.Text, 南极抽奖_奖品图标.Value, 南极抽奖_奖品数量.Value, 南极抽奖_奖品概率.Value);
			MessageBox.Show("[" + 南极抽奖_添加奖品.Text + "]添加成功");
		}
	}

	private void 南极抽奖_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 2, JsonConvert.SerializeObject(Singleton<全局变量类>.I.南极配置, Formatting.Indented));
		}
	}

	private void 南极抽奖_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 2);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.南极抽奖配置窗口));
		this.南极抽奖_开关 = new System.Windows.Forms.CheckBox();
		this.南极抽奖_重载按钮 = new System.Windows.Forms.Button();
		this.南极抽奖_保存按钮 = new System.Windows.Forms.Button();
		this.南极抽奖_大额抽奖 = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.南极抽奖_到期时间 = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.南极抽奖_活动描述 = new System.Windows.Forms.TextBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.南极抽奖_是否大额 = new System.Windows.Forms.CheckBox();
		this.南极抽奖_奖品列表 = new System.Windows.Forms.DataGridView();
		this.南极抽奖_添加按钮 = new System.Windows.Forms.Button();
		this.南极抽奖_奖品概率 = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.南极抽奖_奖品数量 = new System.Windows.Forms.NumericUpDown();
		this.label6 = new System.Windows.Forms.Label();
		this.南极抽奖_奖品图标 = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.南极抽奖_奖品等级 = new System.Windows.Forms.ComboBox();
		this.label4 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.南极抽奖_添加奖品 = new System.Windows.Forms.TextBox();
		this.南极抽奖_出特等次数 = new System.Windows.Forms.NumericUpDown();
		this.label8 = new System.Windows.Forms.Label();
		this.奖品名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.奖品类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.奖品等级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.奖品图标 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.奖品数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.奖品概率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.南极抽奖_奖品列表).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.南极抽奖_奖品概率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.南极抽奖_奖品数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.南极抽奖_奖品图标).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.南极抽奖_出特等次数).BeginInit();
		base.SuspendLayout();
		this.南极抽奖_开关.AutoSize = true;
		this.南极抽奖_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.南极抽奖_开关.Location = new System.Drawing.Point(12, 12);
		this.南极抽奖_开关.Name = "南极抽奖_开关";
		this.南极抽奖_开关.Size = new System.Drawing.Size(106, 23);
		this.南极抽奖_开关.TabIndex = 90;
		this.南极抽奖_开关.Text = "南极抽奖开关";
		this.南极抽奖_开关.UseVisualStyleBackColor = true;
		this.南极抽奖_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.南极抽奖_重载按钮.Location = new System.Drawing.Point(342, 8);
		this.南极抽奖_重载按钮.Name = "南极抽奖_重载按钮";
		this.南极抽奖_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.南极抽奖_重载按钮.TabIndex = 92;
		this.南极抽奖_重载按钮.Text = "重载配置";
		this.南极抽奖_重载按钮.UseVisualStyleBackColor = true;
		this.南极抽奖_重载按钮.Click += new System.EventHandler(南极抽奖_重载按钮_Click);
		this.南极抽奖_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.南极抽奖_保存按钮.Location = new System.Drawing.Point(236, 8);
		this.南极抽奖_保存按钮.Name = "南极抽奖_保存按钮";
		this.南极抽奖_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.南极抽奖_保存按钮.TabIndex = 91;
		this.南极抽奖_保存按钮.Text = "保存配置";
		this.南极抽奖_保存按钮.UseVisualStyleBackColor = true;
		this.南极抽奖_保存按钮.Click += new System.EventHandler(南极抽奖_保存按钮_Click);
		this.南极抽奖_大额抽奖.AutoSize = true;
		this.南极抽奖_大额抽奖.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.南极抽奖_大额抽奖.Location = new System.Drawing.Point(124, 12);
		this.南极抽奖_大额抽奖.Name = "南极抽奖_大额抽奖";
		this.南极抽奖_大额抽奖.Size = new System.Drawing.Size(106, 23);
		this.南极抽奖_大额抽奖.TabIndex = 93;
		this.南极抽奖_大额抽奖.Text = "大额抽奖开关";
		this.南极抽奖_大额抽奖.UseVisualStyleBackColor = true;
		this.label1.Location = new System.Drawing.Point(12, 51);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(80, 23);
		this.label1.TabIndex = 153;
		this.label1.Text = "活动到期时间";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.南极抽奖_到期时间.Location = new System.Drawing.Point(93, 51);
		this.南极抽奖_到期时间.Name = "南极抽奖_到期时间";
		this.南极抽奖_到期时间.ReadOnly = true;
		this.南极抽奖_到期时间.Size = new System.Drawing.Size(130, 23);
		this.南极抽奖_到期时间.TabIndex = 154;
		this.南极抽奖_到期时间.Text = "2029-01-01 00:00:00";
		this.label2.Location = new System.Drawing.Point(229, 51);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(80, 23);
		this.label2.TabIndex = 155;
		this.label2.Text = "活动奖励描述";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.南极抽奖_活动描述.Location = new System.Drawing.Point(310, 51);
		this.南极抽奖_活动描述.Name = "南极抽奖_活动描述";
		this.南极抽奖_活动描述.Size = new System.Drawing.Size(321, 23);
		this.南极抽奖_活动描述.TabIndex = 156;
		this.南极抽奖_活动描述.Text = "2029-01-01 00:00:00";
		this.groupBox1.Controls.Add(this.南极抽奖_是否大额);
		this.groupBox1.Controls.Add(this.南极抽奖_奖品列表);
		this.groupBox1.Controls.Add(this.南极抽奖_添加按钮);
		this.groupBox1.Controls.Add(this.南极抽奖_奖品概率);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.南极抽奖_奖品数量);
		this.groupBox1.Controls.Add(this.label6);
		this.groupBox1.Controls.Add(this.南极抽奖_奖品图标);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.南极抽奖_奖品等级);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.南极抽奖_添加奖品);
		this.groupBox1.Location = new System.Drawing.Point(12, 80);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(776, 469);
		this.groupBox1.TabIndex = 157;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "南极抽奖奖池配置";
		this.南极抽奖_是否大额.AutoSize = true;
		this.南极抽奖_是否大额.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.南极抽奖_是否大额.Location = new System.Drawing.Point(639, 23);
		this.南极抽奖_是否大额.Name = "南极抽奖_是否大额";
		this.南极抽奖_是否大额.Size = new System.Drawing.Size(75, 21);
		this.南极抽奖_是否大额.TabIndex = 167;
		this.南极抽奖_是否大额.Text = "是否大额";
		this.南极抽奖_是否大额.UseVisualStyleBackColor = true;
		this.南极抽奖_奖品列表.AllowUserToAddRows = false;
		this.南极抽奖_奖品列表.AllowUserToDeleteRows = false;
		this.南极抽奖_奖品列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.南极抽奖_奖品列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.南极抽奖_奖品列表.BackgroundColor = System.Drawing.Color.White;
		this.南极抽奖_奖品列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.南极抽奖_奖品列表.Columns.AddRange(this.奖品名字, this.奖品类别, this.奖品等级, this.奖品图标, this.奖品数量, this.奖品概率);
		this.南极抽奖_奖品列表.Location = new System.Drawing.Point(0, 54);
		this.南极抽奖_奖品列表.MultiSelect = false;
		this.南极抽奖_奖品列表.Name = "南极抽奖_奖品列表";
		this.南极抽奖_奖品列表.RowHeadersVisible = false;
		this.南极抽奖_奖品列表.RowTemplate.Height = 25;
		this.南极抽奖_奖品列表.Size = new System.Drawing.Size(776, 409);
		this.南极抽奖_奖品列表.TabIndex = 166;
		this.南极抽奖_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.南极抽奖_添加按钮.Location = new System.Drawing.Point(718, 22);
		this.南极抽奖_添加按钮.Name = "南极抽奖_添加按钮";
		this.南极抽奖_添加按钮.Size = new System.Drawing.Size(50, 23);
		this.南极抽奖_添加按钮.TabIndex = 165;
		this.南极抽奖_添加按钮.Text = "添加";
		this.南极抽奖_添加按钮.UseVisualStyleBackColor = true;
		this.南极抽奖_添加按钮.Click += new System.EventHandler(南极抽奖_添加按钮_Click);
		this.南极抽奖_奖品概率.Location = new System.Drawing.Point(573, 22);
		this.南极抽奖_奖品概率.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.南极抽奖_奖品概率.Name = "南极抽奖_奖品概率";
		this.南极抽奖_奖品概率.Size = new System.Drawing.Size(60, 23);
		this.南极抽奖_奖品概率.TabIndex = 164;
		this.label7.Location = new System.Drawing.Point(537, 22);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(40, 23);
		this.label7.TabIndex = 163;
		this.label7.Text = "概率";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.南极抽奖_奖品数量.Location = new System.Drawing.Point(451, 22);
		this.南极抽奖_奖品数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.南极抽奖_奖品数量.Name = "南极抽奖_奖品数量";
		this.南极抽奖_奖品数量.Size = new System.Drawing.Size(80, 23);
		this.南极抽奖_奖品数量.TabIndex = 162;
		this.label6.Location = new System.Drawing.Point(415, 22);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(40, 23);
		this.label6.TabIndex = 161;
		this.label6.Text = "数量";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.南极抽奖_奖品图标.Location = new System.Drawing.Point(329, 22);
		this.南极抽奖_奖品图标.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.南极抽奖_奖品图标.Name = "南极抽奖_奖品图标";
		this.南极抽奖_奖品图标.Size = new System.Drawing.Size(80, 23);
		this.南极抽奖_奖品图标.TabIndex = 160;
		this.label5.Location = new System.Drawing.Point(293, 22);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(40, 23);
		this.label5.TabIndex = 159;
		this.label5.Text = "图标";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.南极抽奖_奖品等级.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.南极抽奖_奖品等级.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.南极抽奖_奖品等级.FormattingEnabled = true;
		this.南极抽奖_奖品等级.Items.AddRange(new object[5] { "特等奖", "一等奖", "二等奖", "三等奖", "普通奖" });
		this.南极抽奖_奖品等级.Location = new System.Drawing.Point(207, 21);
		this.南极抽奖_奖品等级.Name = "南极抽奖_奖品等级";
		this.南极抽奖_奖品等级.Size = new System.Drawing.Size(80, 25);
		this.南极抽奖_奖品等级.TabIndex = 158;
		this.label4.Location = new System.Drawing.Point(172, 22);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(40, 23);
		this.label4.TabIndex = 157;
		this.label4.Text = "等级";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.Location = new System.Drawing.Point(10, 22);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(60, 23);
		this.label3.TabIndex = 155;
		this.label3.Text = "填写奖品";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.南极抽奖_添加奖品.Location = new System.Drawing.Point(71, 22);
		this.南极抽奖_添加奖品.Name = "南极抽奖_添加奖品";
		this.南极抽奖_添加奖品.Size = new System.Drawing.Size(100, 23);
		this.南极抽奖_添加奖品.TabIndex = 156;
		this.南极抽奖_出特等次数.Location = new System.Drawing.Point(708, 51);
		this.南极抽奖_出特等次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.南极抽奖_出特等次数.Name = "南极抽奖_出特等次数";
		this.南极抽奖_出特等次数.Size = new System.Drawing.Size(80, 23);
		this.南极抽奖_出特等次数.TabIndex = 164;
		this.南极抽奖_出特等次数.Value = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.label8.Location = new System.Drawing.Point(637, 51);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(75, 23);
		this.label8.TabIndex = 163;
		this.label8.Text = "出特等次数";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.奖品名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.奖品名字.Frozen = true;
		this.奖品名字.HeaderText = "奖品名字";
		this.奖品名字.MinimumWidth = 100;
		this.奖品名字.Name = "奖品名字";
		this.奖品名字.ReadOnly = true;
		this.奖品类别.HeaderText = "奖品类别";
		this.奖品类别.MinimumWidth = 100;
		this.奖品类别.Name = "奖品类别";
		this.奖品类别.ReadOnly = true;
		this.奖品等级.HeaderText = "奖品等级";
		this.奖品等级.MinimumWidth = 100;
		this.奖品等级.Name = "奖品等级";
		this.奖品等级.ReadOnly = true;
		this.奖品图标.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.奖品图标.HeaderText = "奖品图标";
		this.奖品图标.MinimumWidth = 100;
		this.奖品图标.Name = "奖品图标";
		this.奖品数量.HeaderText = "奖品数量";
		this.奖品数量.MinimumWidth = 100;
		this.奖品数量.Name = "奖品数量";
		this.奖品概率.HeaderText = "奖品概率";
		this.奖品概率.MinimumWidth = 100;
		this.奖品概率.Name = "奖品概率";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(800, 561);
		base.Controls.Add(this.南极抽奖_出特等次数);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.南极抽奖_活动描述);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.南极抽奖_到期时间);
		base.Controls.Add(this.南极抽奖_大额抽奖);
		base.Controls.Add(this.南极抽奖_开关);
		base.Controls.Add(this.南极抽奖_重载按钮);
		base.Controls.Add(this.南极抽奖_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "南极抽奖配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "南极抽奖配置窗口";
		base.Load += new System.EventHandler(南极抽奖配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.南极抽奖_奖品列表).EndInit();
		((System.ComponentModel.ISupportInitialize)this.南极抽奖_奖品概率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.南极抽奖_奖品数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.南极抽奖_奖品图标).EndInit();
		((System.ComponentModel.ISupportInitialize)this.南极抽奖_出特等次数).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
