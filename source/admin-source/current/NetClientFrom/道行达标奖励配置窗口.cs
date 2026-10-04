using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 道行达标奖励配置窗口 : Form
{
	private static 道行达标奖励配置窗口 i;

	private IContainer components;

	private CheckBox 道行达标_开关;

	private Button 道行达标_重载按钮;

	private Button 道行达标_保存按钮;

	private TextBox 道行达标_奖励道具;

	private TextBox textBox1;

	private Button 道行达标_添加按钮;

	private DataGridView 道行达标_道行列表;

	private NumericUpDown 道行达标_添加道行;

	private DataGridViewTextBoxColumn 达标道行;

	private DataGridViewTextBoxColumn 奖励内容;

	public static 道行达标奖励配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 道行达标奖励配置窗口();
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

	public 道行达标奖励配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 道行达标奖励配置窗口_Load(object sender, EventArgs e)
	{
		道行达标_道行列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 删除事件回调);
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		道行达标_重载按钮_Click(sender, e);
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 道行达标_道行列表.CurrentRow != null)
		{
			int index = 道行达标_道行列表.CurrentRow.Index;
			if (index >= 0)
			{
				道行达标_道行列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 道行达标_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 38, JsonConvert.SerializeObject(Singleton<全局变量类>.I.道行达标配置, Formatting.Indented));
		}
	}

	private void 道行达标_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 38);
		}
	}

	private void 道行达标_添加按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (道行达标_添加道行.Value <= 0m)
			{
				MessageBox.Show("请输入正确的达标道行！");
				return;
			}
			if (string.IsNullOrWhiteSpace(道行达标_奖励道具.Text))
			{
				MessageBox.Show("请添加达标的奖励！");
				return;
			}
			if (Singleton<全局变量类>.I.道行达标配置.道行达标奖励列表.Any((道行达标奖励配置类 x) => x.最低道行 == (int)道行达标_添加道行.Value))
			{
				MessageBox.Show($"列表中已经存在【{道行达标_添加道行.Value}】年道行，无法重复添加！");
				return;
			}
			Singleton<全局变量类>.I.道行达标配置.道行达标奖励列表.Add(new 道行达标奖励配置类
			{
				最低道行 = (int)道行达标_添加道行.Value,
				奖励道具 = 道行达标_奖励道具.Text
			});
			道行达标_道行列表.Rows.Add(道行达标_添加道行.Value, 道行达标_奖励道具.Text);
			MessageBox.Show($"[{道行达标_添加道行.Value}]道行达标奖励添加成功");
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 38)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			道行达标_开关.Checked = Singleton<全局变量类>.I.道行达标配置.功能开关;
			道行达标_道行列表.Rows.Clear();
			Singleton<全局变量类>.I.道行达标配置.道行达标奖励列表.Sort();
			for (int i = 0; i < Singleton<全局变量类>.I.道行达标配置.道行达标奖励列表.Count; i++)
			{
				道行达标_道行列表.Rows.Add(Singleton<全局变量类>.I.道行达标配置.道行达标奖励列表[i].最低道行, Singleton<全局变量类>.I.道行达标配置.道行达标奖励列表[i].奖励道具);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.道行达标配置.功能开关 = 道行达标_开关.Checked;
			Singleton<全局变量类>.I.道行达标配置.道行达标奖励列表.Clear();
			for (int i = 0; i < 道行达标_道行列表.Rows.Count; i++)
			{
				DataGridViewCellCollection cells = 道行达标_道行列表.Rows[i].Cells;
				Singleton<全局变量类>.I.道行达标配置.道行达标奖励列表.Add(new 道行达标奖励配置类
				{
					最低道行 = int.Parse(cells[0].Value.ToString()),
					奖励道具 = cells[1].Value.ToString()
				});
			}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.道行达标奖励配置窗口));
		this.道行达标_开关 = new System.Windows.Forms.CheckBox();
		this.道行达标_重载按钮 = new System.Windows.Forms.Button();
		this.道行达标_保存按钮 = new System.Windows.Forms.Button();
		this.道行达标_奖励道具 = new System.Windows.Forms.TextBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.道行达标_添加按钮 = new System.Windows.Forms.Button();
		this.道行达标_道行列表 = new System.Windows.Forms.DataGridView();
		this.达标道行 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.奖励内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.道行达标_添加道行 = new System.Windows.Forms.NumericUpDown();
		((System.ComponentModel.ISupportInitialize)this.道行达标_道行列表).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.道行达标_添加道行).BeginInit();
		base.SuspendLayout();
		this.道行达标_开关.AutoSize = true;
		this.道行达标_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.道行达标_开关.Location = new System.Drawing.Point(12, 12);
		this.道行达标_开关.Name = "道行达标_开关";
		this.道行达标_开关.Size = new System.Drawing.Size(132, 23);
		this.道行达标_开关.TabIndex = 127;
		this.道行达标_开关.Text = "道行达标奖励开关";
		this.道行达标_开关.UseVisualStyleBackColor = true;
		this.道行达标_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.道行达标_重载按钮.Location = new System.Drawing.Point(253, 8);
		this.道行达标_重载按钮.Name = "道行达标_重载按钮";
		this.道行达标_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.道行达标_重载按钮.TabIndex = 129;
		this.道行达标_重载按钮.Text = "重载配置";
		this.道行达标_重载按钮.UseVisualStyleBackColor = true;
		this.道行达标_重载按钮.Click += new System.EventHandler(道行达标_重载按钮_Click);
		this.道行达标_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.道行达标_保存按钮.Location = new System.Drawing.Point(147, 8);
		this.道行达标_保存按钮.Name = "道行达标_保存按钮";
		this.道行达标_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.道行达标_保存按钮.TabIndex = 128;
		this.道行达标_保存按钮.Text = "保存配置";
		this.道行达标_保存按钮.UseVisualStyleBackColor = true;
		this.道行达标_保存按钮.Click += new System.EventHandler(道行达标_保存按钮_Click);
		this.道行达标_奖励道具.Location = new System.Drawing.Point(194, 55);
		this.道行达标_奖励道具.Name = "道行达标_奖励道具";
		this.道行达标_奖励道具.Size = new System.Drawing.Size(100, 23);
		this.道行达标_奖励道具.TabIndex = 160;
		this.textBox1.Location = new System.Drawing.Point(12, 55);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(80, 23);
		this.textBox1.TabIndex = 158;
		this.textBox1.Text = "达标道行(年)";
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.道行达标_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.道行达标_添加按钮.Location = new System.Drawing.Point(300, 51);
		this.道行达标_添加按钮.Name = "道行达标_添加按钮";
		this.道行达标_添加按钮.Size = new System.Drawing.Size(53, 30);
		this.道行达标_添加按钮.TabIndex = 161;
		this.道行达标_添加按钮.Text = "添加";
		this.道行达标_添加按钮.UseVisualStyleBackColor = true;
		this.道行达标_添加按钮.Click += new System.EventHandler(道行达标_添加按钮_Click);
		this.道行达标_道行列表.AllowUserToAddRows = false;
		this.道行达标_道行列表.AllowUserToDeleteRows = false;
		this.道行达标_道行列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.道行达标_道行列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.道行达标_道行列表.BackgroundColor = System.Drawing.Color.White;
		this.道行达标_道行列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.道行达标_道行列表.Columns.AddRange(this.达标道行, this.奖励内容);
		this.道行达标_道行列表.Location = new System.Drawing.Point(12, 89);
		this.道行达标_道行列表.MultiSelect = false;
		this.道行达标_道行列表.Name = "道行达标_道行列表";
		this.道行达标_道行列表.RowHeadersVisible = false;
		this.道行达标_道行列表.RowTemplate.Height = 25;
		this.道行达标_道行列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.道行达标_道行列表.Size = new System.Drawing.Size(341, 354);
		this.道行达标_道行列表.TabIndex = 178;
		this.达标道行.Frozen = true;
		this.达标道行.HeaderText = "达标道行";
		this.达标道行.MinimumWidth = 100;
		this.达标道行.Name = "达标道行";
		this.达标道行.ReadOnly = true;
		this.奖励内容.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.奖励内容.HeaderText = "奖励内容";
		this.奖励内容.MinimumWidth = 200;
		this.奖励内容.Name = "奖励内容";
		this.奖励内容.Width = 200;
		this.道行达标_添加道行.Location = new System.Drawing.Point(93, 55);
		this.道行达标_添加道行.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.道行达标_添加道行.Name = "道行达标_添加道行";
		this.道行达标_添加道行.Size = new System.Drawing.Size(100, 23);
		this.道行达标_添加道行.TabIndex = 179;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(367, 450);
		base.Controls.Add(this.道行达标_添加道行);
		base.Controls.Add(this.道行达标_道行列表);
		base.Controls.Add(this.道行达标_添加按钮);
		base.Controls.Add(this.道行达标_奖励道具);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.道行达标_开关);
		base.Controls.Add(this.道行达标_重载按钮);
		base.Controls.Add(this.道行达标_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "道行达标奖励配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "道行达标奖励配置窗口";
		base.Load += new System.EventHandler(道行达标奖励配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.道行达标_道行列表).EndInit();
		((System.ComponentModel.ISupportInitialize)this.道行达标_添加道行).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
