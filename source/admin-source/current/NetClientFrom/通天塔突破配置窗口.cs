using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 通天塔突破配置窗口 : Form
{
	private static 通天塔突破配置窗口 i;

	private IContainer components;

	private CheckBox 通天塔_开关;

	private Button 通天塔_重载按钮;

	private Button 通天塔_保存按钮;

	private NumericUpDown 通天塔_突破层数;

	private Label label6;

	private TextBox 通天塔_突破奖励;

	private Label label1;

	private Button 通天塔_添加按钮;

	private DataGridView 通天塔_奖励列表;

	private DataGridViewTextBoxColumn 突破层数;

	private DataGridViewTextBoxColumn 首次突破奖励;

	private Panel 修改窗口;

	private Label label3;

	private TextBox 修改_奖励;

	private Label label2;

	private Button 修改_取消按钮;

	private Button 修改_确定按钮;

	private TextBox 修改_名字;

	public static 通天塔突破配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 通天塔突破配置窗口();
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

	public 通天塔突破配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 通天塔突破配置窗口_Load(object sender, EventArgs e)
	{
		通天塔_奖励列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(修改事件回调, 删除事件回调);
		修改_取消按钮.Click += delegate
		{
			修改窗口.Visible = false;
		};
		修改_确定按钮.Click += 确定修改事件回调;
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		通天塔_重载按钮_Click(sender, e);
	}

	private void 修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 通天塔_奖励列表.CurrentRow == null)
		{
			return;
		}
		int index = 通天塔_奖励列表.CurrentRow.Index;
		if (index >= 0)
		{
			DataGridViewCellCollection cells = 通天塔_奖励列表.Rows[index].Cells;
			修改_名字.Text = cells["突破层数"].Value.ToString();
			if (Singleton<全局变量类>.I.通天塔突破配置.通天塔奖励列表.ContainsKey(int.Parse(修改_名字.Text)))
			{
				修改_奖励.Text = cells["首次突破奖励"].Value.ToString();
				修改窗口.Visible = true;
			}
		}
	}

	private void 确定修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || !Singleton<全局变量类>.I.通天塔突破配置.通天塔奖励列表.ContainsKey(int.Parse(修改_名字.Text)))
		{
			return;
		}
		Singleton<全局变量类>.I.通天塔突破配置.通天塔奖励列表[int.Parse(修改_名字.Text)] = 修改_奖励.Text;
		修改窗口.Visible = false;
		if (通天塔_奖励列表.CurrentRow != null)
		{
			int index = 通天塔_奖励列表.CurrentRow.Index;
			if (index >= 0)
			{
				通天塔_奖励列表.Rows[index].Cells["首次突破奖励"].Value = 修改_奖励.Text;
				MessageBox.Show("[" + 修改_名字.Text + "]的配置已经修改，请及时点击保存配置按钮更新服务端配置！");
			}
		}
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 通天塔_奖励列表.CurrentRow == null)
		{
			return;
		}
		int index = 通天塔_奖励列表.CurrentRow.Index;
		if (index >= 0)
		{
			int num = (int)通天塔_奖励列表.Rows[index].Cells["突破层数"].Value;
			if (Singleton<全局变量类>.I.通天塔突破配置.通天塔奖励列表.ContainsKey(num))
			{
				Singleton<全局变量类>.I.通天塔突破配置.通天塔奖励列表.TryRemove(num, out string _);
				MessageBox.Show($"[{num}]已从列表中删除，请及时点击保存配置按钮更新服务端配置！");
				通天塔_奖励列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 通天塔_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 23, JsonConvert.SerializeObject(Singleton<全局变量类>.I.通天塔突破配置, Formatting.Indented));
		}
	}

	private void 通天塔_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 23);
		}
	}

	private void 通天塔_添加按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(通天塔_突破奖励.Text))
			{
				MessageBox.Show($"请输入突破【{通天塔_突破层数.Value}】层的奖励！");
				return;
			}
			if (Singleton<全局变量类>.I.通天塔突破配置.通天塔奖励列表.ContainsKey((int)通天塔_突破层数.Value))
			{
				MessageBox.Show($"列表中已经存在【{通天塔_突破层数.Value}】，无法重复添加！");
				return;
			}
			Singleton<全局变量类>.I.通天塔突破配置.通天塔奖励列表.TryAdd((int)通天塔_突破层数.Value, 通天塔_突破奖励.Text);
			通天塔_奖励列表.Rows.Add(通天塔_突破层数.Value, 通天塔_突破奖励.Text);
			MessageBox.Show($"[{通天塔_突破层数.Value}]添加成功");
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 23)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			通天塔_开关.Checked = Singleton<全局变量类>.I.通天塔突破配置.功能开关;
			通天塔_奖励列表.Rows.Clear();
			foreach (KeyValuePair<int, string> item in Singleton<全局变量类>.I.通天塔突破配置.通天塔奖励列表)
			{
				通天塔_奖励列表.Rows.Add(item.Key, item.Value);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.通天塔突破配置.功能开关 = 通天塔_开关.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.通天塔突破配置窗口));
		this.通天塔_开关 = new System.Windows.Forms.CheckBox();
		this.通天塔_重载按钮 = new System.Windows.Forms.Button();
		this.通天塔_保存按钮 = new System.Windows.Forms.Button();
		this.通天塔_突破层数 = new System.Windows.Forms.NumericUpDown();
		this.label6 = new System.Windows.Forms.Label();
		this.通天塔_突破奖励 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.通天塔_添加按钮 = new System.Windows.Forms.Button();
		this.通天塔_奖励列表 = new System.Windows.Forms.DataGridView();
		this.突破层数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.首次突破奖励 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.修改窗口 = new System.Windows.Forms.Panel();
		this.修改_名字 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.修改_奖励 = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.修改_取消按钮 = new System.Windows.Forms.Button();
		this.修改_确定按钮 = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.通天塔_突破层数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.通天塔_奖励列表).BeginInit();
		this.修改窗口.SuspendLayout();
		base.SuspendLayout();
		this.通天塔_开关.AutoSize = true;
		this.通天塔_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.通天塔_开关.Location = new System.Drawing.Point(12, 12);
		this.通天塔_开关.Name = "通天塔_开关";
		this.通天塔_开关.Size = new System.Drawing.Size(145, 23);
		this.通天塔_开关.TabIndex = 67;
		this.通天塔_开关.Text = "通天塔突破奖励开关";
		this.通天塔_开关.UseVisualStyleBackColor = true;
		this.通天塔_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.通天塔_重载按钮.Location = new System.Drawing.Point(299, 7);
		this.通天塔_重载按钮.Name = "通天塔_重载按钮";
		this.通天塔_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.通天塔_重载按钮.TabIndex = 69;
		this.通天塔_重载按钮.Text = "重载配置";
		this.通天塔_重载按钮.UseVisualStyleBackColor = true;
		this.通天塔_重载按钮.Click += new System.EventHandler(通天塔_重载按钮_Click);
		this.通天塔_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.通天塔_保存按钮.Location = new System.Drawing.Point(193, 7);
		this.通天塔_保存按钮.Name = "通天塔_保存按钮";
		this.通天塔_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.通天塔_保存按钮.TabIndex = 68;
		this.通天塔_保存按钮.Text = "保存配置";
		this.通天塔_保存按钮.UseVisualStyleBackColor = true;
		this.通天塔_保存按钮.Click += new System.EventHandler(通天塔_保存按钮_Click);
		this.通天塔_突破层数.Location = new System.Drawing.Point(78, 62);
		this.通天塔_突破层数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.通天塔_突破层数.Name = "通天塔_突破层数";
		this.通天塔_突破层数.Size = new System.Drawing.Size(80, 23);
		this.通天塔_突破层数.TabIndex = 72;
		this.label6.Location = new System.Drawing.Point(159, 62);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(60, 23);
		this.label6.TabIndex = 70;
		this.label6.Text = "首次奖励";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.通天塔_突破奖励.Location = new System.Drawing.Point(220, 62);
		this.通天塔_突破奖励.Name = "通天塔_突破奖励";
		this.通天塔_突破奖励.Size = new System.Drawing.Size(120, 23);
		this.通天塔_突破奖励.TabIndex = 71;
		this.label1.Location = new System.Drawing.Point(12, 62);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 23);
		this.label1.TabIndex = 73;
		this.label1.Text = "突破层数";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.通天塔_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.通天塔_添加按钮.Location = new System.Drawing.Point(346, 57);
		this.通天塔_添加按钮.Name = "通天塔_添加按钮";
		this.通天塔_添加按钮.Size = new System.Drawing.Size(53, 30);
		this.通天塔_添加按钮.TabIndex = 74;
		this.通天塔_添加按钮.Text = "添加";
		this.通天塔_添加按钮.UseVisualStyleBackColor = true;
		this.通天塔_添加按钮.Click += new System.EventHandler(通天塔_添加按钮_Click);
		this.通天塔_奖励列表.AllowUserToAddRows = false;
		this.通天塔_奖励列表.AllowUserToDeleteRows = false;
		this.通天塔_奖励列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.通天塔_奖励列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.通天塔_奖励列表.BackgroundColor = System.Drawing.Color.White;
		this.通天塔_奖励列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.通天塔_奖励列表.Columns.AddRange(this.突破层数, this.首次突破奖励);
		this.通天塔_奖励列表.Location = new System.Drawing.Point(12, 93);
		this.通天塔_奖励列表.MultiSelect = false;
		this.通天塔_奖励列表.Name = "通天塔_奖励列表";
		this.通天塔_奖励列表.ReadOnly = true;
		this.通天塔_奖励列表.RowHeadersVisible = false;
		this.通天塔_奖励列表.RowTemplate.Height = 25;
		this.通天塔_奖励列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.通天塔_奖励列表.Size = new System.Drawing.Size(387, 345);
		this.通天塔_奖励列表.TabIndex = 80;
		this.突破层数.HeaderText = "突破层数";
		this.突破层数.MinimumWidth = 83;
		this.突破层数.Name = "突破层数";
		this.突破层数.ReadOnly = true;
		this.突破层数.Width = 83;
		this.首次突破奖励.HeaderText = "首次突破奖励";
		this.首次突破奖励.MinimumWidth = 300;
		this.首次突破奖励.Name = "首次突破奖励";
		this.首次突破奖励.ReadOnly = true;
		this.首次突破奖励.Width = 300;
		this.修改窗口.BackColor = System.Drawing.Color.WhiteSmoke;
		this.修改窗口.Controls.Add(this.修改_名字);
		this.修改窗口.Controls.Add(this.label3);
		this.修改窗口.Controls.Add(this.修改_奖励);
		this.修改窗口.Controls.Add(this.label2);
		this.修改窗口.Controls.Add(this.修改_取消按钮);
		this.修改窗口.Controls.Add(this.修改_确定按钮);
		this.修改窗口.Location = new System.Drawing.Point(78, 172);
		this.修改窗口.Name = "修改窗口";
		this.修改窗口.Size = new System.Drawing.Size(230, 159);
		this.修改窗口.TabIndex = 87;
		this.修改_名字.Location = new System.Drawing.Point(83, 30);
		this.修改_名字.Name = "修改_名字";
		this.修改_名字.ReadOnly = true;
		this.修改_名字.Size = new System.Drawing.Size(120, 23);
		this.修改_名字.TabIndex = 106;
		this.label3.Location = new System.Drawing.Point(22, 65);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(60, 23);
		this.label3.TabIndex = 104;
		this.label3.Text = "首次奖励";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_奖励.Location = new System.Drawing.Point(83, 65);
		this.修改_奖励.Name = "修改_奖励";
		this.修改_奖励.Size = new System.Drawing.Size(120, 23);
		this.修改_奖励.TabIndex = 105;
		this.label2.Location = new System.Drawing.Point(22, 30);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(60, 23);
		this.label2.TabIndex = 103;
		this.label2.Text = "突破层数";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_取消按钮.Location = new System.Drawing.Point(120, 106);
		this.修改_取消按钮.Name = "修改_取消按钮";
		this.修改_取消按钮.Size = new System.Drawing.Size(78, 30);
		this.修改_取消按钮.TabIndex = 101;
		this.修改_取消按钮.Text = "取消";
		this.修改_取消按钮.UseVisualStyleBackColor = true;
		this.修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_确定按钮.Location = new System.Drawing.Point(22, 106);
		this.修改_确定按钮.Name = "修改_确定按钮";
		this.修改_确定按钮.Size = new System.Drawing.Size(78, 30);
		this.修改_确定按钮.TabIndex = 100;
		this.修改_确定按钮.Text = "修改";
		this.修改_确定按钮.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(411, 450);
		base.Controls.Add(this.修改窗口);
		base.Controls.Add(this.通天塔_奖励列表);
		base.Controls.Add(this.通天塔_添加按钮);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.通天塔_开关);
		base.Controls.Add(this.通天塔_重载按钮);
		base.Controls.Add(this.通天塔_保存按钮);
		base.Controls.Add(this.通天塔_突破层数);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.通天塔_突破奖励);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "通天塔突破配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "通天塔突破配置窗口";
		base.Load += new System.EventHandler(通天塔突破配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.通天塔_突破层数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.通天塔_奖励列表).EndInit();
		this.修改窗口.ResumeLayout(false);
		this.修改窗口.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
