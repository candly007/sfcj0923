using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 累充返利配置窗口 : Form
{
	private static 累充返利配置窗口 i;

	private IContainer components;

	private CheckBox 累充返利_开关;

	private Button 累充返利_重载按钮;

	private Button 累充返利_保存按钮;

	private GroupBox groupBox1;

	private DataGridView 累充返利_累充列表;

	private DataGridViewTextBoxColumn 累充金额;

	private DataGridViewTextBoxColumn 返利奖品1;

	private DataGridViewTextBoxColumn 数量1;

	private DataGridViewTextBoxColumn 返利奖品2;

	private DataGridViewTextBoxColumn 数量2;

	private DataGridViewTextBoxColumn 返利奖品3;

	private DataGridViewTextBoxColumn 数量3;

	private DataGridViewTextBoxColumn 返利奖品4;

	private DataGridViewTextBoxColumn 数量4;

	private DataGridViewTextBoxColumn 返利奖品5;

	private DataGridViewTextBoxColumn 数量5;

	public static 累充返利配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 累充返利配置窗口();
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

	public 累充返利配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	[STAThread]
	private void 累充返利配置窗口_Load(object sender, EventArgs e)
	{
		累充返利_累充列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 删除事件回调);
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		累充返利_重载按钮_Click(sender, e);
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 累充返利_累充列表.CurrentRow != null)
		{
			int index = 累充返利_累充列表.CurrentRow.Index;
			if (index >= 0 && !string.IsNullOrWhiteSpace(累充返利_累充列表.Rows[index].Cells[0].Value.ToString()))
			{
				累充返利_累充列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 3)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			累充返利_开关.Checked = Singleton<全局变量类>.I.累充配置.功能开关;
			累充返利_累充列表.Rows.Clear();
			Singleton<全局变量类>.I.累充配置.奖励列表.Sort();
			for (int i = 0; i < Singleton<全局变量类>.I.累充配置.奖励列表.Count; i++)
			{
				累充奖励列表类 累充奖励列表类2 = Singleton<全局变量类>.I.累充配置.奖励列表[i];
				累充返利_累充列表.Rows.Add(累充奖励列表类2.阶段, (累充奖励列表类2.奖励列表.Count >= 1) ? 累充奖励列表类2.奖励列表[0][0] : string.Empty, (累充奖励列表类2.奖励列表.Count >= 1) ? 累充奖励列表类2.奖励列表[0][1] : string.Empty, (累充奖励列表类2.奖励列表.Count >= 2) ? 累充奖励列表类2.奖励列表[1][0] : string.Empty, (累充奖励列表类2.奖励列表.Count >= 2) ? 累充奖励列表类2.奖励列表[1][1] : string.Empty, (累充奖励列表类2.奖励列表.Count >= 3) ? 累充奖励列表类2.奖励列表[2][0] : string.Empty, (累充奖励列表类2.奖励列表.Count >= 3) ? 累充奖励列表类2.奖励列表[2][1] : string.Empty, (累充奖励列表类2.奖励列表.Count >= 4) ? 累充奖励列表类2.奖励列表[3][0] : string.Empty, (累充奖励列表类2.奖励列表.Count >= 4) ? 累充奖励列表类2.奖励列表[3][1] : string.Empty, (累充奖励列表类2.奖励列表.Count >= 5) ? 累充奖励列表类2.奖励列表[4][0] : string.Empty, (累充奖励列表类2.奖励列表.Count >= 5) ? 累充奖励列表类2.奖励列表[4][1] : string.Empty);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		Singleton<全局变量类>.I.累充配置.功能开关 = 累充返利_开关.Checked;
		Singleton<全局变量类>.I.累充配置.奖励列表.Clear();
		for (int i = 0; i < 累充返利_累充列表.Rows.Count; i++)
		{
			DataGridViewCellCollection cells = 累充返利_累充列表.Rows[i].Cells;
			if (cells["累充金额"].Value != null && !string.IsNullOrWhiteSpace(cells["累充金额"].Value.ToString()))
			{
				累充奖励列表类 累充奖励列表类2 = new 累充奖励列表类();
				累充奖励列表类2.阶段 = Convert.ToInt32(cells["累充金额"].Value);
				if (cells["返利奖品1"].Value != null && !string.IsNullOrWhiteSpace(cells["返利奖品1"].Value.ToString()))
				{
					累充奖励列表类2.奖励列表.Add(new string[2]
					{
						cells["返利奖品1"].Value.ToString(),
						cells["数量1"].Value.ToString()
					});
				}
				if (cells["返利奖品2"].Value != null && !string.IsNullOrWhiteSpace(cells["返利奖品2"].Value.ToString()))
				{
					累充奖励列表类2.奖励列表.Add(new string[2]
					{
						cells["返利奖品2"].Value.ToString(),
						cells["数量2"].Value.ToString()
					});
				}
				if (cells["返利奖品3"].Value != null && !string.IsNullOrWhiteSpace(cells["返利奖品3"].Value.ToString()))
				{
					累充奖励列表类2.奖励列表.Add(new string[2]
					{
						cells["返利奖品3"].Value.ToString(),
						cells["数量3"].Value.ToString()
					});
				}
				if (cells["返利奖品4"].Value != null && !string.IsNullOrWhiteSpace(cells["返利奖品4"].Value.ToString()))
				{
					累充奖励列表类2.奖励列表.Add(new string[2]
					{
						cells["返利奖品4"].Value.ToString(),
						cells["数量4"].Value.ToString()
					});
				}
				if (cells["返利奖品5"].Value != null && !string.IsNullOrWhiteSpace(cells["返利奖品5"].Value.ToString()))
				{
					累充奖励列表类2.奖励列表.Add(new string[2]
					{
						cells["返利奖品5"].Value.ToString(),
						cells["数量5"].Value.ToString()
					});
				}
				Singleton<全局变量类>.I.累充配置.奖励列表.Add(累充奖励列表类2);
			}
		}
	}

	private void 累充返利_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 3, JsonConvert.SerializeObject(Singleton<全局变量类>.I.累充配置, Formatting.Indented));
		}
	}

	private void 累充返利_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 3);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.累充返利配置窗口));
		this.累充返利_开关 = new System.Windows.Forms.CheckBox();
		this.累充返利_重载按钮 = new System.Windows.Forms.Button();
		this.累充返利_保存按钮 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.累充返利_累充列表 = new System.Windows.Forms.DataGridView();
		this.累充金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.返利奖品1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.数量1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.返利奖品2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.数量2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.返利奖品3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.数量3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.返利奖品4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.数量4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.返利奖品5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.数量5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.累充返利_累充列表).BeginInit();
		base.SuspendLayout();
		this.累充返利_开关.AutoSize = true;
		this.累充返利_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.累充返利_开关.Location = new System.Drawing.Point(12, 12);
		this.累充返利_开关.Name = "累充返利_开关";
		this.累充返利_开关.Size = new System.Drawing.Size(106, 23);
		this.累充返利_开关.TabIndex = 93;
		this.累充返利_开关.Text = "累充返利开关";
		this.累充返利_开关.UseVisualStyleBackColor = true;
		this.累充返利_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.累充返利_重载按钮.Location = new System.Drawing.Point(230, 8);
		this.累充返利_重载按钮.Name = "累充返利_重载按钮";
		this.累充返利_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.累充返利_重载按钮.TabIndex = 95;
		this.累充返利_重载按钮.Text = "重载配置";
		this.累充返利_重载按钮.UseVisualStyleBackColor = true;
		this.累充返利_重载按钮.Click += new System.EventHandler(累充返利_重载按钮_Click);
		this.累充返利_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.累充返利_保存按钮.Location = new System.Drawing.Point(124, 8);
		this.累充返利_保存按钮.Name = "累充返利_保存按钮";
		this.累充返利_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.累充返利_保存按钮.TabIndex = 94;
		this.累充返利_保存按钮.Text = "保存配置";
		this.累充返利_保存按钮.UseVisualStyleBackColor = true;
		this.累充返利_保存按钮.Click += new System.EventHandler(累充返利_保存按钮_Click);
		this.groupBox1.Controls.Add(this.累充返利_累充列表);
		this.groupBox1.Location = new System.Drawing.Point(12, 54);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(848, 384);
		this.groupBox1.TabIndex = 96;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "配置累充返利阶段(最低配置5个阶段)";
		this.累充返利_累充列表.AllowUserToDeleteRows = false;
		this.累充返利_累充列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.累充返利_累充列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.累充返利_累充列表.BackgroundColor = System.Drawing.Color.White;
		this.累充返利_累充列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.累充返利_累充列表.Columns.AddRange(this.累充金额, this.返利奖品1, this.数量1, this.返利奖品2, this.数量2, this.返利奖品3, this.数量3, this.返利奖品4, this.数量4, this.返利奖品5, this.数量5);
		this.累充返利_累充列表.Location = new System.Drawing.Point(7, 22);
		this.累充返利_累充列表.MultiSelect = false;
		this.累充返利_累充列表.Name = "累充返利_累充列表";
		this.累充返利_累充列表.RowHeadersVisible = false;
		this.累充返利_累充列表.RowTemplate.Height = 25;
		this.累充返利_累充列表.Size = new System.Drawing.Size(835, 356);
		this.累充返利_累充列表.TabIndex = 167;
		this.累充金额.Frozen = true;
		this.累充金额.HeaderText = "累充金额";
		this.累充金额.MinimumWidth = 80;
		this.累充金额.Name = "累充金额";
		this.累充金额.Width = 80;
		this.返利奖品1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.返利奖品1.HeaderText = "返利奖品1";
		this.返利奖品1.MinimumWidth = 90;
		this.返利奖品1.Name = "返利奖品1";
		this.返利奖品1.Width = 90;
		this.数量1.HeaderText = "数量";
		this.数量1.MinimumWidth = 60;
		this.数量1.Name = "数量1";
		this.数量1.Width = 60;
		this.返利奖品2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.返利奖品2.HeaderText = "返利奖品2";
		this.返利奖品2.MinimumWidth = 90;
		this.返利奖品2.Name = "返利奖品2";
		this.返利奖品2.Width = 90;
		this.数量2.HeaderText = "数量";
		this.数量2.MinimumWidth = 60;
		this.数量2.Name = "数量2";
		this.数量2.Width = 60;
		this.返利奖品3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.返利奖品3.HeaderText = "返利奖品3";
		this.返利奖品3.MinimumWidth = 90;
		this.返利奖品3.Name = "返利奖品3";
		this.返利奖品3.Width = 90;
		this.数量3.HeaderText = "数量";
		this.数量3.MinimumWidth = 60;
		this.数量3.Name = "数量3";
		this.数量3.Width = 60;
		this.返利奖品4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.返利奖品4.HeaderText = "返利奖品4";
		this.返利奖品4.MinimumWidth = 90;
		this.返利奖品4.Name = "返利奖品4";
		this.返利奖品4.Width = 90;
		this.数量4.HeaderText = "数量";
		this.数量4.MinimumWidth = 60;
		this.数量4.Name = "数量4";
		this.数量4.Width = 60;
		this.返利奖品5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.返利奖品5.HeaderText = "返利奖品5";
		this.返利奖品5.MinimumWidth = 90;
		this.返利奖品5.Name = "返利奖品5";
		this.返利奖品5.Width = 90;
		this.数量5.HeaderText = "数量";
		this.数量5.MinimumWidth = 60;
		this.数量5.Name = "数量5";
		this.数量5.Width = 60;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(869, 450);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.累充返利_开关);
		base.Controls.Add(this.累充返利_重载按钮);
		base.Controls.Add(this.累充返利_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "累充返利配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "累充返利配置窗口";
		base.Load += new System.EventHandler(累充返利配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.累充返利_累充列表).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
