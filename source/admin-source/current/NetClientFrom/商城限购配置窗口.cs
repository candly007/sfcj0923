using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Net.Share;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 商城限购配置窗口 : Form
{
	private static 商城限购配置窗口 i;

	private IContainer components;

	private CheckBox 商城限购_开关;

	private Button 商城限购_重载按钮;

	private Button 商城限购_保存按钮;

	private DataGridView 商城限购_商品列表;

	private Label label6;

	private DataGridViewTextBoxColumn 商品条码;

	private DataGridViewTextBoxColumn 商城名字;

	private DataGridViewTextBoxColumn 限购数量;

	private DataGridViewTextBoxColumn 商城编号;

	private DataGridViewTextBoxColumn 商品类别;

	private DataGridViewTextBoxColumn 花费类型;

	private DataGridViewTextBoxColumn 购买类型;

	private DataGridViewTextBoxColumn 购买价格;

	public static 商城限购配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 商城限购配置窗口();
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
		商城限购_商品列表.Rows.Clear();
		Singleton<全局变量类>.I.商城数据列表.Clear();
		Singleton<全局变量类>.I.验证client.SendRT(10055, true);
	}

	public 商城限购配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 商城限购配置窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
	}

	private void 商城限购_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 29, JsonConvert.SerializeObject(Singleton<全局变量类>.I.商城限购配置, Formatting.Indented));
		}
	}

	private void 商城限购_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 29);
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 29)
		{
			return;
		}
		商城限购_商品列表.Invoke((MethodInvoker)delegate
		{
			商城限购_开关.Checked = Singleton<全局变量类>.I.商城限购配置.功能开关;
			商城限购_商品列表.Rows.Clear();
			for (int i = 0; i < Singleton<全局变量类>.I.商城数据列表.Count; i++)
			{
				商城数据类 item = Singleton<全局变量类>.I.商城数据列表[i];
				商城数据类 商城数据类2 = Singleton<全局变量类>.I.商城限购配置.限购数据列表.Find((商城数据类 x) => x.商品条码 == item.商品条码 && x.名字 == item.名字 && x.限购数量 > -1);
				商城限购_商品列表.Rows.Add(item.商品条码, item.名字, 商城数据类2?.限购数量 ?? item.限购数量, item.编号, item.所在类别, item.花费类型, item.is银元宝购买, item.价格);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		Singleton<全局变量类>.I.商城限购配置.功能开关 = 商城限购_开关.Checked;
		Singleton<全局变量类>.I.商城限购配置.限购数据列表.Clear();
		for (int i = 0; i < 商城限购_商品列表.Rows.Count; i++)
		{
			DataGridViewCellCollection cells = 商城限购_商品列表.Rows[i].Cells;
			int num = Convert.ToInt32(cells[2].Value);
			if (num != -1)
			{
				Singleton<全局变量类>.I.商城限购配置.限购数据列表.Add(new 商城数据类
				{
					商品条码 = cells[0].Value.ToString(),
					名字 = cells[1].Value.ToString(),
					限购数量 = num,
					编号 = Convert.ToInt32(cells[3].Value),
					所在类别 = Convert.ToByte(cells[4].Value),
					花费类型 = Convert.ToByte(cells[5].Value),
					is银元宝购买 = Convert.ToBoolean(cells[6].Value),
					价格 = Convert.ToInt32(cells[7].Value)
				});
			}
		}
	}

	[Rpc(hash = 10078)]
	private void 返回商城道具列表(string value, bool 是否结束)
	{
		if (!是否结束 && !string.IsNullOrWhiteSpace(value))
		{
			Singleton<全局变量类>.I.商城数据列表.Add(JsonConvert.DeserializeObject<商城数据类>(value));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.商城限购配置窗口));
		this.商城限购_开关 = new System.Windows.Forms.CheckBox();
		this.商城限购_重载按钮 = new System.Windows.Forms.Button();
		this.商城限购_保存按钮 = new System.Windows.Forms.Button();
		this.商城限购_商品列表 = new System.Windows.Forms.DataGridView();
		this.商品条码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.商城名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.限购数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.商城编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.商品类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.花费类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.购买类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.购买价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.label6 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.商城限购_商品列表).BeginInit();
		base.SuspendLayout();
		this.商城限购_开关.AutoSize = true;
		this.商城限购_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.商城限购_开关.Location = new System.Drawing.Point(12, 12);
		this.商城限购_开关.Name = "商城限购_开关";
		this.商城限购_开关.Size = new System.Drawing.Size(106, 23);
		this.商城限购_开关.TabIndex = 87;
		this.商城限购_开关.Text = "商城限购开关";
		this.商城限购_开关.UseVisualStyleBackColor = true;
		this.商城限购_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.商城限购_重载按钮.Location = new System.Drawing.Point(233, 8);
		this.商城限购_重载按钮.Name = "商城限购_重载按钮";
		this.商城限购_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.商城限购_重载按钮.TabIndex = 89;
		this.商城限购_重载按钮.Text = "重载配置";
		this.商城限购_重载按钮.UseVisualStyleBackColor = true;
		this.商城限购_重载按钮.Click += new System.EventHandler(商城限购_重载按钮_Click);
		this.商城限购_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.商城限购_保存按钮.Location = new System.Drawing.Point(127, 8);
		this.商城限购_保存按钮.Name = "商城限购_保存按钮";
		this.商城限购_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.商城限购_保存按钮.TabIndex = 88;
		this.商城限购_保存按钮.Text = "保存配置";
		this.商城限购_保存按钮.UseVisualStyleBackColor = true;
		this.商城限购_保存按钮.Click += new System.EventHandler(商城限购_保存按钮_Click);
		this.商城限购_商品列表.AllowUserToAddRows = false;
		this.商城限购_商品列表.AllowUserToDeleteRows = false;
		this.商城限购_商品列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.商城限购_商品列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.商城限购_商品列表.BackgroundColor = System.Drawing.Color.White;
		this.商城限购_商品列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.商城限购_商品列表.Columns.AddRange(this.商品条码, this.商城名字, this.限购数量, this.商城编号, this.商品类别, this.花费类型, this.购买类型, this.购买价格);
		this.商城限购_商品列表.Location = new System.Drawing.Point(12, 64);
		this.商城限购_商品列表.MultiSelect = false;
		this.商城限购_商品列表.Name = "商城限购_商品列表";
		this.商城限购_商品列表.RowHeadersVisible = false;
		this.商城限购_商品列表.RowTemplate.Height = 25;
		this.商城限购_商品列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.商城限购_商品列表.Size = new System.Drawing.Size(776, 374);
		this.商城限购_商品列表.TabIndex = 146;
		this.商品条码.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.商品条码.Frozen = true;
		this.商品条码.HeaderText = "商品条码";
		this.商品条码.MinimumWidth = 100;
		this.商品条码.Name = "商品条码";
		this.商品条码.ReadOnly = true;
		this.商城名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.商城名字.Frozen = true;
		this.商城名字.HeaderText = "商城名字";
		this.商城名字.MinimumWidth = 100;
		this.商城名字.Name = "商城名字";
		this.商城名字.ReadOnly = true;
		this.限购数量.HeaderText = "限购数量";
		this.限购数量.MinimumWidth = 100;
		this.限购数量.Name = "限购数量";
		this.商城编号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.商城编号.HeaderText = "商城编号";
		this.商城编号.MinimumWidth = 100;
		this.商城编号.Name = "商城编号";
		this.商城编号.ReadOnly = true;
		this.商品类别.HeaderText = "商品类别";
		this.商品类别.MinimumWidth = 100;
		this.商品类别.Name = "商品类别";
		this.商品类别.ReadOnly = true;
		this.花费类型.HeaderText = "花费类型";
		this.花费类型.MinimumWidth = 80;
		this.花费类型.Name = "花费类型";
		this.花费类型.ReadOnly = true;
		this.花费类型.Width = 80;
		this.购买类型.HeaderText = "购买类型";
		this.购买类型.MinimumWidth = 80;
		this.购买类型.Name = "购买类型";
		this.购买类型.ReadOnly = true;
		this.购买类型.Width = 80;
		this.购买价格.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.购买价格.HeaderText = "购买价格";
		this.购买价格.MinimumWidth = 100;
		this.购买价格.Name = "购买价格";
		this.购买价格.ReadOnly = true;
		this.label6.ForeColor = System.Drawing.Color.Red;
		this.label6.Location = new System.Drawing.Point(12, 38);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(776, 23);
		this.label6.TabIndex = 145;
		this.label6.Text = "不限制不写，不让购买写0，元宝商城可放入叠加物品，限制单次最大购买数量80，总价值不可超出拥有的元宝数";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(800, 450);
		base.Controls.Add(this.商城限购_商品列表);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.商城限购_开关);
		base.Controls.Add(this.商城限购_重载按钮);
		base.Controls.Add(this.商城限购_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "商城限购配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "商城限购配置窗口";
		base.Load += new System.EventHandler(商城限购配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.商城限购_商品列表).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
