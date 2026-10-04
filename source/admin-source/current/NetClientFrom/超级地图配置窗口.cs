using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 超级地图配置窗口 : Form
{
	private static 超级地图配置窗口 i;

	private IContainer components;

	private CheckBox 超级地图_开关;

	private Button 超级地图_重载按钮;

	private Button 超级地图_保存按钮;

	private GroupBox groupBox1;

	private Label label6;

	private TextBox 超级地图_地图名字;

	private CheckBox 超级地图_限制等级开关;

	private CheckBox 超级地图_限制组队开关;

	private CheckBox 超级地图_限制称号开关;

	private NumericUpDown 超级地图_最高道行;

	private Label label2;

	private NumericUpDown 超级地图_最低道行;

	private CheckBox 超级地图_限制道行开关;

	private NumericUpDown 超级地图_最高等级;

	private Label label1;

	private NumericUpDown 超级地图_最低等级;

	private CheckBox 超级地图_消耗开关;

	private Label label4;

	private TextBox 超级地图_限副称号;

	private Label label3;

	private TextBox 超级地图_限主称号;

	private Label label14;

	private ComboBox 超级地图_消耗类型;

	private Button 超级地图_添加按钮;

	private NumericUpDown 超级地图_消耗数量;

	private Label label7;

	private Label label5;

	private TextBox 超级地图_消耗名字;

	private DataGridView 超级地图_地图列表;

	private Panel 修改窗口;

	private Button 修改_取消按钮;

	private Button 修改_确定按钮;

	private NumericUpDown 修改_消耗数量;

	private Label label13;

	private Label label15;

	private TextBox 修改_消耗名字;

	private Label label16;

	private ComboBox 修改_消耗类型;

	private CheckBox 修改_消耗开关;

	private Label label11;

	private TextBox 修改_副称号;

	private Label label12;

	private TextBox 修改_主称号;

	private CheckBox 修改_称号开关;

	private NumericUpDown 修改_最高道行;

	private Label label9;

	private NumericUpDown 修改_最低道行;

	private CheckBox 修改_道行开关;

	private NumericUpDown 修改_最高等级;

	private Label label10;

	private NumericUpDown 修改_最低等级;

	private CheckBox 修改_等级开关;

	private CheckBox 修改_组队开关;

	private Label label8;

	private TextBox 修改_名字;

	private Label label17;

	private Label label18;

	private TextBox 修改_关键词;

	private Label label19;

	private TextBox 超级地图_关键词;

	private NumericUpDown 超级地图_最高活跃;

	private Label label20;

	private NumericUpDown 超级地图_最低活跃;

	private CheckBox 超级地图_限制活跃开关;

	private NumericUpDown 修改_最高活跃;

	private Label label21;

	private NumericUpDown 修改_最低活跃;

	private CheckBox 修改_活跃开关;

	private DataGridViewTextBoxColumn 地图名字;

	private DataGridViewTextBoxColumn 进入关键词;

	private DataGridViewTextBoxColumn 组队限制;

	private DataGridViewTextBoxColumn 等级限制;

	private DataGridViewTextBoxColumn 道行限制;

	private DataGridViewTextBoxColumn 活跃限制;

	private DataGridViewTextBoxColumn 称号限制;

	private DataGridViewTextBoxColumn 消耗限制;

	public static 超级地图配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 超级地图配置窗口();
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

	public 超级地图配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 超级地图配置窗口_Load(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			超级地图_地图列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(修改事件回调, 删除事件回调);
			修改_取消按钮.Click += delegate
			{
				修改窗口.Visible = false;
			};
			修改_确定按钮.Click += 确定修改事件回调;
			Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
			全局变量类 obj = Singleton<全局变量类>.I;
			obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
			超级地图_重载按钮_Click(sender, e);
		}
	}

	private void 修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 超级地图_地图列表.CurrentRow == null)
		{
			return;
		}
		int index = 超级地图_地图列表.CurrentRow.Index;
		if (index >= 0)
		{
			DataGridViewCellCollection cells = 超级地图_地图列表.Rows[index].Cells;
			修改_名字.Text = cells["地图名字"].Value.ToString();
			if (Singleton<全局变量类>.I.超级地图配置.地图列表.TryGetValue(修改_名字.Text, out 地图限制列表类 value))
			{
				修改_关键词.Text = value.关键词;
				修改_组队开关.Checked = value.is限制组队;
				修改_等级开关.Checked = value.is限制等级;
				修改_最低等级.Value = value.最低等级;
				修改_最高等级.Value = value.最高等级;
				修改_道行开关.Checked = value.is限制道行;
				修改_最低道行.Value = value.最低道行;
				修改_最高道行.Value = value.最高道行;
				修改_活跃开关.Checked = value.is限制活跃;
				修改_最低活跃.Value = value.最低活跃;
				修改_最高活跃.Value = value.最高活跃;
				修改_称号开关.Checked = value.is限制称号;
				修改_主称号.Text = value.限主称号;
				修改_副称号.Text = value.限副称号;
				修改_消耗开关.Checked = value.is消耗道具;
				修改_消耗类型.Text = value.消耗类型.ToString();
				修改_消耗名字.Text = value.消耗道具;
				修改_消耗数量.Value = value.消耗数量;
				修改窗口.Visible = true;
			}
		}
	}

	private void 确定修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || !Singleton<全局变量类>.I.超级地图配置.地图列表.TryGetValue(修改_名字.Text, out 地图限制列表类 value))
		{
			return;
		}
		value.关键词 = 修改_关键词.Text;
		value.is限制组队 = 修改_组队开关.Checked;
		value.is限制等级 = 修改_等级开关.Checked;
		value.最低等级 = (int)修改_最低等级.Value;
		value.最高等级 = (int)修改_最高等级.Value;
		value.is限制道行 = 修改_道行开关.Checked;
		value.最低道行 = (int)修改_最低道行.Value;
		value.最高道行 = (int)修改_最高道行.Value;
		value.is限制活跃 = 修改_活跃开关.Checked;
		value.最低活跃 = (int)修改_最低活跃.Value;
		value.最高活跃 = (int)修改_最高活跃.Value;
		value.is限制称号 = 修改_称号开关.Checked;
		value.限主称号 = 修改_主称号.Text;
		value.限副称号 = 修改_副称号.Text;
		value.is消耗道具 = 修改_消耗开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(修改_消耗类型.Text, out value.消耗类型);
		value.消耗道具 = 修改_消耗名字.Text;
		value.消耗数量 = (int)修改_消耗数量.Value;
		修改窗口.Visible = false;
		if (超级地图_地图列表.CurrentRow != null)
		{
			int index = 超级地图_地图列表.CurrentRow.Index;
			if (index >= 0)
			{
				DataGridViewCellCollection cells = 超级地图_地图列表.Rows[index].Cells;
				cells["进入关键词"].Value = value.关键词;
				cells["组队限制"].Value = (value.is限制组队 ? "是" : "否");
				cells["等级限制"].Value = ((!value.is限制等级) ? "否" : $"是[{value.最低等级}-{value.最高等级}]");
				cells["道行限制"].Value = ((!value.is限制道行) ? "否" : $"是[{value.最低道行}-{value.最高道行}]");
				cells["活跃限制"].Value = ((!value.is限制活跃) ? "否" : $"是[{value.最低活跃}-{value.最高活跃}]");
				cells["称号限制"].Value = ((!value.is限制称号) ? "否" : $"是[{value.限主称号}、{value.限副称号}]");
				cells["消耗限制"].Value = ((!value.is消耗道具) ? "否" : $"是[{value.消耗道具}×{value.消耗数量}]");
				MessageBox.Show("[" + 修改_名字.Text + "]的配置已经修改，请及时点击保存配置按钮更新服务端配置！");
			}
		}
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 超级地图_地图列表.CurrentRow == null)
		{
			return;
		}
		int index = 超级地图_地图列表.CurrentRow.Index;
		if (index >= 0)
		{
			string text = 超级地图_地图列表.Rows[index].Cells["地图名字"].Value.ToString();
			if (Singleton<全局变量类>.I.超级地图配置.地图列表.ContainsKey(text))
			{
				Singleton<全局变量类>.I.超级地图配置.地图列表.TryRemove(text, out 地图限制列表类 _);
				MessageBox.Show("[" + text + "]已从列表中删除，请及时点击保存配置按钮更新服务端配置！");
				超级地图_地图列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 超级地图_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 26, JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级地图配置, Formatting.Indented));
		}
	}

	private void 超级地图_重载按钮_Click(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.SendRT(10017, 26);
	}

	private void 超级地图_添加按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(超级地图_地图名字.Text))
			{
				MessageBox.Show("请输入要添加的地图！");
				return;
			}
			if (Singleton<全局变量类>.I.超级地图配置.地图列表.ContainsKey(超级地图_地图名字.Text))
			{
				MessageBox.Show("列表中已经存在【" + 超级地图_地图名字.Text + "】，无法重复添加！");
				return;
			}
			地图限制列表类 地图限制列表类2 = new 地图限制列表类
			{
				地图名字 = 超级地图_地图名字.Text,
				关键词 = 超级地图_关键词.Text
			};
			地图限制列表类2.is限制组队 = 超级地图_限制组队开关.Checked;
			地图限制列表类2.is限制等级 = 超级地图_限制等级开关.Checked;
			地图限制列表类2.最低等级 = (int)超级地图_最低等级.Value;
			地图限制列表类2.最高等级 = (int)超级地图_最高等级.Value;
			地图限制列表类2.is限制道行 = 超级地图_限制道行开关.Checked;
			地图限制列表类2.最低道行 = (int)超级地图_最低道行.Value;
			地图限制列表类2.最高道行 = (int)超级地图_最高道行.Value;
			地图限制列表类2.is限制活跃 = 超级地图_限制活跃开关.Checked;
			地图限制列表类2.最低活跃 = (int)超级地图_最低活跃.Value;
			地图限制列表类2.最高活跃 = (int)超级地图_最高活跃.Value;
			地图限制列表类2.is限制称号 = 超级地图_限制称号开关.Checked;
			地图限制列表类2.限主称号 = 超级地图_限主称号.Text;
			地图限制列表类2.限副称号 = 超级地图_限副称号.Text;
			地图限制列表类2.is消耗道具 = 超级地图_消耗开关.Checked;
			Enum.TryParse<AllEnums.数值Type>(超级地图_消耗类型.Text, out 地图限制列表类2.消耗类型);
			地图限制列表类2.消耗道具 = 超级地图_消耗名字.Text;
			地图限制列表类2.消耗数量 = (int)超级地图_消耗数量.Value;
			Singleton<全局变量类>.I.超级地图配置.地图列表.TryAdd(地图限制列表类2.地图名字, 地图限制列表类2);
			超级地图_地图列表.Rows.Add(地图限制列表类2.地图名字, 地图限制列表类2.关键词, 地图限制列表类2.is限制组队 ? "是" : "否", (!地图限制列表类2.is限制等级) ? "否" : $"是[{地图限制列表类2.最低等级}-{地图限制列表类2.最高等级}]", (!地图限制列表类2.is限制道行) ? "否" : $"是[{地图限制列表类2.最低道行}-{地图限制列表类2.最高道行}]", (!地图限制列表类2.is限制活跃) ? "否" : $"是[{地图限制列表类2.最低活跃}-{地图限制列表类2.最高活跃}]", (!地图限制列表类2.is限制称号) ? "否" : $"是[{地图限制列表类2.限主称号}、{地图限制列表类2.限副称号}]", (!地图限制列表类2.is消耗道具) ? "否" : $"是[{地图限制列表类2.消耗道具}×{地图限制列表类2.消耗数量}]");
			MessageBox.Show("[" + 地图限制列表类2.地图名字 + "]添加成功");
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 26)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			超级地图_开关.Checked = Singleton<全局变量类>.I.超级地图配置.功能开关;
			超级地图_地图列表.Rows.Clear();
			foreach (地图限制列表类 value in Singleton<全局变量类>.I.超级地图配置.地图列表.Values)
			{
				超级地图_地图列表.Rows.Add(value.地图名字, value.关键词, value.is限制组队 ? "是" : "否", (!value.is限制等级) ? "否" : $"是[{value.最低等级}-{value.最高等级}]", (!value.is限制道行) ? "否" : $"是[{value.最低道行}-{value.最高道行}]", (!value.is限制活跃) ? "否" : $"是[{value.最低活跃}-{value.最高活跃}]", (!value.is限制称号) ? "否" : $"是[{value.限主称号}、{value.限副称号}]", (!value.is消耗道具) ? "否" : $"是[{value.消耗道具}×{value.消耗数量}]");
			}
		});
	}

	private void 配置变量赋值()
	{
		Singleton<全局变量类>.I.超级地图配置.功能开关 = 超级地图_开关.Checked;
	}

	private void 超级地图_消耗类型_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && Enum.TryParse<AllEnums.数值Type>(超级地图_消耗类型.Text, out var result))
		{
			switch (result)
			{
			case AllEnums.数值Type.无:
				超级地图_消耗开关.Checked = false;
				break;
			case AllEnums.数值Type.道具:
				超级地图_消耗名字.Text = string.Empty;
				break;
			default:
				超级地图_消耗名字.Text = 超级地图_消耗类型.Text;
				break;
			}
		}
	}

	private void 修改_消耗类型_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && Enum.TryParse<AllEnums.数值Type>(修改_消耗类型.Text, out var result))
		{
			switch (result)
			{
			case AllEnums.数值Type.无:
				修改_消耗开关.Checked = false;
				break;
			case AllEnums.数值Type.道具:
				修改_消耗名字.Text = string.Empty;
				break;
			default:
				修改_消耗名字.Text = 修改_消耗类型.Text;
				break;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.超级地图配置窗口));
		this.超级地图_开关 = new System.Windows.Forms.CheckBox();
		this.超级地图_重载按钮 = new System.Windows.Forms.Button();
		this.超级地图_保存按钮 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.超级地图_最高活跃 = new System.Windows.Forms.NumericUpDown();
		this.label20 = new System.Windows.Forms.Label();
		this.超级地图_最低活跃 = new System.Windows.Forms.NumericUpDown();
		this.超级地图_限制活跃开关 = new System.Windows.Forms.CheckBox();
		this.label19 = new System.Windows.Forms.Label();
		this.超级地图_关键词 = new System.Windows.Forms.TextBox();
		this.超级地图_消耗数量 = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.超级地图_消耗名字 = new System.Windows.Forms.TextBox();
		this.label14 = new System.Windows.Forms.Label();
		this.超级地图_消耗类型 = new System.Windows.Forms.ComboBox();
		this.超级地图_消耗开关 = new System.Windows.Forms.CheckBox();
		this.label4 = new System.Windows.Forms.Label();
		this.超级地图_限副称号 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.超级地图_限主称号 = new System.Windows.Forms.TextBox();
		this.超级地图_限制称号开关 = new System.Windows.Forms.CheckBox();
		this.超级地图_最高道行 = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.超级地图_最低道行 = new System.Windows.Forms.NumericUpDown();
		this.超级地图_限制道行开关 = new System.Windows.Forms.CheckBox();
		this.超级地图_最高等级 = new System.Windows.Forms.NumericUpDown();
		this.label1 = new System.Windows.Forms.Label();
		this.超级地图_最低等级 = new System.Windows.Forms.NumericUpDown();
		this.超级地图_限制等级开关 = new System.Windows.Forms.CheckBox();
		this.超级地图_限制组队开关 = new System.Windows.Forms.CheckBox();
		this.label6 = new System.Windows.Forms.Label();
		this.超级地图_地图名字 = new System.Windows.Forms.TextBox();
		this.超级地图_添加按钮 = new System.Windows.Forms.Button();
		this.超级地图_地图列表 = new System.Windows.Forms.DataGridView();
		this.修改窗口 = new System.Windows.Forms.Panel();
		this.修改_最高活跃 = new System.Windows.Forms.NumericUpDown();
		this.label21 = new System.Windows.Forms.Label();
		this.修改_最低活跃 = new System.Windows.Forms.NumericUpDown();
		this.修改_活跃开关 = new System.Windows.Forms.CheckBox();
		this.label18 = new System.Windows.Forms.Label();
		this.修改_关键词 = new System.Windows.Forms.TextBox();
		this.修改_消耗数量 = new System.Windows.Forms.NumericUpDown();
		this.label13 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.修改_消耗名字 = new System.Windows.Forms.TextBox();
		this.label16 = new System.Windows.Forms.Label();
		this.修改_消耗类型 = new System.Windows.Forms.ComboBox();
		this.修改_消耗开关 = new System.Windows.Forms.CheckBox();
		this.label11 = new System.Windows.Forms.Label();
		this.修改_副称号 = new System.Windows.Forms.TextBox();
		this.label12 = new System.Windows.Forms.Label();
		this.修改_主称号 = new System.Windows.Forms.TextBox();
		this.修改_称号开关 = new System.Windows.Forms.CheckBox();
		this.修改_最高道行 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.修改_最低道行 = new System.Windows.Forms.NumericUpDown();
		this.修改_道行开关 = new System.Windows.Forms.CheckBox();
		this.修改_最高等级 = new System.Windows.Forms.NumericUpDown();
		this.label10 = new System.Windows.Forms.Label();
		this.修改_最低等级 = new System.Windows.Forms.NumericUpDown();
		this.修改_等级开关 = new System.Windows.Forms.CheckBox();
		this.修改_组队开关 = new System.Windows.Forms.CheckBox();
		this.label8 = new System.Windows.Forms.Label();
		this.修改_名字 = new System.Windows.Forms.TextBox();
		this.修改_取消按钮 = new System.Windows.Forms.Button();
		this.修改_确定按钮 = new System.Windows.Forms.Button();
		this.label17 = new System.Windows.Forms.Label();
		this.地图名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.进入关键词 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.组队限制 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.等级限制 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.道行限制 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.活跃限制 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.称号限制 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.消耗限制 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.超级地图_最高活跃).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_最低活跃).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_消耗数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_最高道行).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_最低道行).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_最高等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_最低等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_地图列表).BeginInit();
		this.修改窗口.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_最高活跃).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低活跃).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_消耗数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高道行).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低道行).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低等级).BeginInit();
		base.SuspendLayout();
		this.超级地图_开关.AutoSize = true;
		this.超级地图_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级地图_开关.Location = new System.Drawing.Point(12, 12);
		this.超级地图_开关.Name = "超级地图_开关";
		this.超级地图_开关.Size = new System.Drawing.Size(106, 23);
		this.超级地图_开关.TabIndex = 51;
		this.超级地图_开关.Text = "超级地图开关";
		this.超级地图_开关.UseVisualStyleBackColor = true;
		this.超级地图_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级地图_重载按钮.Location = new System.Drawing.Point(230, 7);
		this.超级地图_重载按钮.Name = "超级地图_重载按钮";
		this.超级地图_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.超级地图_重载按钮.TabIndex = 53;
		this.超级地图_重载按钮.Text = "重载配置";
		this.超级地图_重载按钮.UseVisualStyleBackColor = true;
		this.超级地图_重载按钮.Click += new System.EventHandler(超级地图_重载按钮_Click);
		this.超级地图_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级地图_保存按钮.Location = new System.Drawing.Point(124, 7);
		this.超级地图_保存按钮.Name = "超级地图_保存按钮";
		this.超级地图_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.超级地图_保存按钮.TabIndex = 52;
		this.超级地图_保存按钮.Text = "保存配置";
		this.超级地图_保存按钮.UseVisualStyleBackColor = true;
		this.超级地图_保存按钮.Click += new System.EventHandler(超级地图_保存按钮_Click);
		this.groupBox1.Controls.Add(this.超级地图_最高活跃);
		this.groupBox1.Controls.Add(this.label20);
		this.groupBox1.Controls.Add(this.超级地图_最低活跃);
		this.groupBox1.Controls.Add(this.超级地图_限制活跃开关);
		this.groupBox1.Controls.Add(this.label19);
		this.groupBox1.Controls.Add(this.超级地图_关键词);
		this.groupBox1.Controls.Add(this.超级地图_消耗数量);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.超级地图_消耗名字);
		this.groupBox1.Controls.Add(this.label14);
		this.groupBox1.Controls.Add(this.超级地图_消耗类型);
		this.groupBox1.Controls.Add(this.超级地图_消耗开关);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.超级地图_限副称号);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.超级地图_限主称号);
		this.groupBox1.Controls.Add(this.超级地图_限制称号开关);
		this.groupBox1.Controls.Add(this.超级地图_最高道行);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.超级地图_最低道行);
		this.groupBox1.Controls.Add(this.超级地图_限制道行开关);
		this.groupBox1.Controls.Add(this.超级地图_最高等级);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.超级地图_最低等级);
		this.groupBox1.Controls.Add(this.超级地图_限制等级开关);
		this.groupBox1.Controls.Add(this.超级地图_限制组队开关);
		this.groupBox1.Controls.Add(this.label6);
		this.groupBox1.Controls.Add(this.超级地图_地图名字);
		this.groupBox1.Location = new System.Drawing.Point(12, 44);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(721, 176);
		this.groupBox1.TabIndex = 54;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "新增超级地图配置";
		this.超级地图_最高活跃.Location = new System.Drawing.Point(214, 105);
		this.超级地图_最高活跃.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.超级地图_最高活跃.Name = "超级地图_最高活跃";
		this.超级地图_最高活跃.Size = new System.Drawing.Size(60, 23);
		this.超级地图_最高活跃.TabIndex = 90;
		this.label20.BackColor = System.Drawing.Color.Transparent;
		this.label20.Location = new System.Drawing.Point(191, 105);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(110, 23);
		this.label20.TabIndex = 89;
		this.label20.Text = "—                  点";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.超级地图_最低活跃.Location = new System.Drawing.Point(128, 105);
		this.超级地图_最低活跃.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.超级地图_最低活跃.Name = "超级地图_最低活跃";
		this.超级地图_最低活跃.Size = new System.Drawing.Size(60, 23);
		this.超级地图_最低活跃.TabIndex = 88;
		this.超级地图_限制活跃开关.AutoSize = true;
		this.超级地图_限制活跃开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级地图_限制活跃开关.Location = new System.Drawing.Point(16, 105);
		this.超级地图_限制活跃开关.Name = "超级地图_限制活跃开关";
		this.超级地图_限制活跃开关.Size = new System.Drawing.Size(106, 23);
		this.超级地图_限制活跃开关.TabIndex = 87;
		this.超级地图_限制活跃开关.Text = "限制活跃开关";
		this.超级地图_限制活跃开关.UseVisualStyleBackColor = true;
		this.label19.Location = new System.Drawing.Point(199, 19);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(47, 23);
		this.label19.TabIndex = 85;
		this.label19.Text = "关键词";
		this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.超级地图_关键词.Location = new System.Drawing.Point(247, 19);
		this.超级地图_关键词.Name = "超级地图_关键词";
		this.超级地图_关键词.Size = new System.Drawing.Size(80, 23);
		this.超级地图_关键词.TabIndex = 86;
		this.超级地图_消耗数量.Location = new System.Drawing.Point(564, 105);
		this.超级地图_消耗数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.超级地图_消耗数量.Name = "超级地图_消耗数量";
		this.超级地图_消耗数量.Size = new System.Drawing.Size(150, 23);
		this.超级地图_消耗数量.TabIndex = 84;
		this.label7.Location = new System.Drawing.Point(503, 105);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(60, 23);
		this.label7.TabIndex = 83;
		this.label7.Text = "消耗数量";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label5.Location = new System.Drawing.Point(503, 76);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(60, 23);
		this.label5.TabIndex = 81;
		this.label5.Text = "名      字";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.超级地图_消耗名字.Location = new System.Drawing.Point(564, 76);
		this.超级地图_消耗名字.Name = "超级地图_消耗名字";
		this.超级地图_消耗名字.Size = new System.Drawing.Size(150, 23);
		this.超级地图_消耗名字.TabIndex = 82;
		this.label14.Location = new System.Drawing.Point(503, 47);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(60, 23);
		this.label14.TabIndex = 79;
		this.label14.Text = "消耗类型";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.超级地图_消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.超级地图_消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.超级地图_消耗类型.FormattingEnabled = true;
		this.超级地图_消耗类型.Items.AddRange(new object[11]
		{
			"无", "金元宝", "银元宝", "声望", "战绩", "金钱", "累充点", "南极点", "灵气值", "体力",
			"道具"
		});
		this.超级地图_消耗类型.Location = new System.Drawing.Point(564, 46);
		this.超级地图_消耗类型.Name = "超级地图_消耗类型";
		this.超级地图_消耗类型.Size = new System.Drawing.Size(150, 25);
		this.超级地图_消耗类型.TabIndex = 80;
		this.超级地图_消耗类型.SelectedIndexChanged += new System.EventHandler(超级地图_消耗类型_SelectedIndexChanged);
		this.超级地图_消耗开关.AutoSize = true;
		this.超级地图_消耗开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级地图_消耗开关.Location = new System.Drawing.Point(503, 19);
		this.超级地图_消耗开关.Name = "超级地图_消耗开关";
		this.超级地图_消耗开关.Size = new System.Drawing.Size(106, 23);
		this.超级地图_消耗开关.TabIndex = 78;
		this.超级地图_消耗开关.Text = "进入消耗开关";
		this.超级地图_消耗开关.UseVisualStyleBackColor = true;
		this.label4.Location = new System.Drawing.Point(307, 105);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 76;
		this.label4.Text = "限副称号";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.超级地图_限副称号.Location = new System.Drawing.Point(368, 105);
		this.超级地图_限副称号.Name = "超级地图_限副称号";
		this.超级地图_限副称号.Size = new System.Drawing.Size(120, 23);
		this.超级地图_限副称号.TabIndex = 77;
		this.label3.Location = new System.Drawing.Point(307, 76);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(60, 23);
		this.label3.TabIndex = 74;
		this.label3.Text = "限主称号";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.超级地图_限主称号.Location = new System.Drawing.Point(368, 76);
		this.超级地图_限主称号.Name = "超级地图_限主称号";
		this.超级地图_限主称号.Size = new System.Drawing.Size(120, 23);
		this.超级地图_限主称号.TabIndex = 75;
		this.超级地图_限制称号开关.AutoSize = true;
		this.超级地图_限制称号开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级地图_限制称号开关.Location = new System.Drawing.Point(314, 47);
		this.超级地图_限制称号开关.Name = "超级地图_限制称号开关";
		this.超级地图_限制称号开关.Size = new System.Drawing.Size(106, 23);
		this.超级地图_限制称号开关.TabIndex = 73;
		this.超级地图_限制称号开关.Text = "限制称号开关";
		this.超级地图_限制称号开关.UseVisualStyleBackColor = true;
		this.超级地图_最高道行.Location = new System.Drawing.Point(214, 76);
		this.超级地图_最高道行.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.超级地图_最高道行.Name = "超级地图_最高道行";
		this.超级地图_最高道行.Size = new System.Drawing.Size(60, 23);
		this.超级地图_最高道行.TabIndex = 72;
		this.label2.BackColor = System.Drawing.Color.Transparent;
		this.label2.Location = new System.Drawing.Point(191, 76);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(110, 23);
		this.label2.TabIndex = 71;
		this.label2.Text = "—                  年";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.超级地图_最低道行.Location = new System.Drawing.Point(128, 76);
		this.超级地图_最低道行.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.超级地图_最低道行.Name = "超级地图_最低道行";
		this.超级地图_最低道行.Size = new System.Drawing.Size(60, 23);
		this.超级地图_最低道行.TabIndex = 70;
		this.超级地图_限制道行开关.AutoSize = true;
		this.超级地图_限制道行开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级地图_限制道行开关.Location = new System.Drawing.Point(16, 76);
		this.超级地图_限制道行开关.Name = "超级地图_限制道行开关";
		this.超级地图_限制道行开关.Size = new System.Drawing.Size(106, 23);
		this.超级地图_限制道行开关.TabIndex = 69;
		this.超级地图_限制道行开关.Text = "限制道行开关";
		this.超级地图_限制道行开关.UseVisualStyleBackColor = true;
		this.超级地图_最高等级.Location = new System.Drawing.Point(214, 47);
		this.超级地图_最高等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.超级地图_最高等级.Name = "超级地图_最高等级";
		this.超级地图_最高等级.Size = new System.Drawing.Size(60, 23);
		this.超级地图_最高等级.TabIndex = 68;
		this.label1.BackColor = System.Drawing.Color.Transparent;
		this.label1.Location = new System.Drawing.Point(191, 47);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(110, 23);
		this.label1.TabIndex = 67;
		this.label1.Text = "—                  级";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.超级地图_最低等级.Location = new System.Drawing.Point(128, 47);
		this.超级地图_最低等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.超级地图_最低等级.Name = "超级地图_最低等级";
		this.超级地图_最低等级.Size = new System.Drawing.Size(60, 23);
		this.超级地图_最低等级.TabIndex = 66;
		this.超级地图_限制等级开关.AutoSize = true;
		this.超级地图_限制等级开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级地图_限制等级开关.Location = new System.Drawing.Point(16, 47);
		this.超级地图_限制等级开关.Name = "超级地图_限制等级开关";
		this.超级地图_限制等级开关.Size = new System.Drawing.Size(106, 23);
		this.超级地图_限制等级开关.TabIndex = 65;
		this.超级地图_限制等级开关.Text = "限制等级开关";
		this.超级地图_限制等级开关.UseVisualStyleBackColor = true;
		this.超级地图_限制组队开关.AutoSize = true;
		this.超级地图_限制组队开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级地图_限制组队开关.Location = new System.Drawing.Point(333, 19);
		this.超级地图_限制组队开关.Name = "超级地图_限制组队开关";
		this.超级地图_限制组队开关.Size = new System.Drawing.Size(106, 23);
		this.超级地图_限制组队开关.TabIndex = 64;
		this.超级地图_限制组队开关.Text = "限制组队开关";
		this.超级地图_限制组队开关.UseVisualStyleBackColor = true;
		this.label6.Location = new System.Drawing.Point(16, 19);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(60, 23);
		this.label6.TabIndex = 62;
		this.label6.Text = "地图名字";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.超级地图_地图名字.Location = new System.Drawing.Point(77, 19);
		this.超级地图_地图名字.Name = "超级地图_地图名字";
		this.超级地图_地图名字.Size = new System.Drawing.Size(120, 23);
		this.超级地图_地图名字.TabIndex = 63;
		this.超级地图_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级地图_添加按钮.Location = new System.Drawing.Point(739, 52);
		this.超级地图_添加按钮.Name = "超级地图_添加按钮";
		this.超级地图_添加按钮.Size = new System.Drawing.Size(49, 168);
		this.超级地图_添加按钮.TabIndex = 85;
		this.超级地图_添加按钮.Text = "添加地图";
		this.超级地图_添加按钮.UseVisualStyleBackColor = true;
		this.超级地图_添加按钮.Click += new System.EventHandler(超级地图_添加按钮_Click);
		this.超级地图_地图列表.AllowUserToAddRows = false;
		this.超级地图_地图列表.AllowUserToDeleteRows = false;
		this.超级地图_地图列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.超级地图_地图列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.超级地图_地图列表.BackgroundColor = System.Drawing.Color.White;
		this.超级地图_地图列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.超级地图_地图列表.Columns.AddRange(this.地图名字, this.进入关键词, this.组队限制, this.等级限制, this.道行限制, this.活跃限制, this.称号限制, this.消耗限制);
		this.超级地图_地图列表.Location = new System.Drawing.Point(12, 226);
		this.超级地图_地图列表.MultiSelect = false;
		this.超级地图_地图列表.Name = "超级地图_地图列表";
		this.超级地图_地图列表.ReadOnly = true;
		this.超级地图_地图列表.RowHeadersVisible = false;
		this.超级地图_地图列表.RowTemplate.Height = 25;
		this.超级地图_地图列表.Size = new System.Drawing.Size(776, 393);
		this.超级地图_地图列表.TabIndex = 79;
		this.修改窗口.BackColor = System.Drawing.Color.WhiteSmoke;
		this.修改窗口.Controls.Add(this.修改_最高活跃);
		this.修改窗口.Controls.Add(this.label21);
		this.修改窗口.Controls.Add(this.修改_最低活跃);
		this.修改窗口.Controls.Add(this.修改_活跃开关);
		this.修改窗口.Controls.Add(this.label18);
		this.修改窗口.Controls.Add(this.修改_关键词);
		this.修改窗口.Controls.Add(this.修改_消耗数量);
		this.修改窗口.Controls.Add(this.label13);
		this.修改窗口.Controls.Add(this.label15);
		this.修改窗口.Controls.Add(this.修改_消耗名字);
		this.修改窗口.Controls.Add(this.label16);
		this.修改窗口.Controls.Add(this.修改_消耗类型);
		this.修改窗口.Controls.Add(this.修改_消耗开关);
		this.修改窗口.Controls.Add(this.label11);
		this.修改窗口.Controls.Add(this.修改_副称号);
		this.修改窗口.Controls.Add(this.label12);
		this.修改窗口.Controls.Add(this.修改_主称号);
		this.修改窗口.Controls.Add(this.修改_称号开关);
		this.修改窗口.Controls.Add(this.修改_最高道行);
		this.修改窗口.Controls.Add(this.label9);
		this.修改窗口.Controls.Add(this.修改_最低道行);
		this.修改窗口.Controls.Add(this.修改_道行开关);
		this.修改窗口.Controls.Add(this.修改_最高等级);
		this.修改窗口.Controls.Add(this.label10);
		this.修改窗口.Controls.Add(this.修改_最低等级);
		this.修改窗口.Controls.Add(this.修改_等级开关);
		this.修改窗口.Controls.Add(this.修改_组队开关);
		this.修改窗口.Controls.Add(this.label8);
		this.修改窗口.Controls.Add(this.修改_名字);
		this.修改窗口.Controls.Add(this.修改_取消按钮);
		this.修改窗口.Controls.Add(this.修改_确定按钮);
		this.修改窗口.Location = new System.Drawing.Point(250, 226);
		this.修改窗口.Name = "修改窗口";
		this.修改窗口.Size = new System.Drawing.Size(325, 368);
		this.修改窗口.TabIndex = 87;
		this.修改_最高活跃.Location = new System.Drawing.Point(215, 144);
		this.修改_最高活跃.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最高活跃.Name = "修改_最高活跃";
		this.修改_最高活跃.Size = new System.Drawing.Size(60, 23);
		this.修改_最高活跃.TabIndex = 130;
		this.label21.BackColor = System.Drawing.Color.Transparent;
		this.label21.Location = new System.Drawing.Point(192, 144);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(110, 23);
		this.label21.TabIndex = 129;
		this.label21.Text = "—                  点";
		this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_最低活跃.Location = new System.Drawing.Point(129, 144);
		this.修改_最低活跃.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最低活跃.Name = "修改_最低活跃";
		this.修改_最低活跃.Size = new System.Drawing.Size(60, 23);
		this.修改_最低活跃.TabIndex = 128;
		this.修改_活跃开关.AutoSize = true;
		this.修改_活跃开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_活跃开关.Location = new System.Drawing.Point(17, 144);
		this.修改_活跃开关.Name = "修改_活跃开关";
		this.修改_活跃开关.Size = new System.Drawing.Size(106, 23);
		this.修改_活跃开关.TabIndex = 127;
		this.修改_活跃开关.Text = "限制活跃开关";
		this.修改_活跃开关.UseVisualStyleBackColor = true;
		this.label18.Location = new System.Drawing.Point(17, 50);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(60, 23);
		this.label18.TabIndex = 125;
		this.label18.Text = "关键词";
		this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_关键词.Location = new System.Drawing.Point(78, 49);
		this.修改_关键词.Name = "修改_关键词";
		this.修改_关键词.Size = new System.Drawing.Size(111, 23);
		this.修改_关键词.TabIndex = 126;
		this.修改_消耗数量.Location = new System.Drawing.Point(182, 292);
		this.修改_消耗数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_消耗数量.Name = "修改_消耗数量";
		this.修改_消耗数量.Size = new System.Drawing.Size(120, 23);
		this.修改_消耗数量.TabIndex = 124;
		this.label13.Location = new System.Drawing.Point(121, 292);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(60, 23);
		this.label13.TabIndex = 123;
		this.label13.Text = "消耗数量";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label15.Location = new System.Drawing.Point(121, 265);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(60, 23);
		this.label15.TabIndex = 121;
		this.label15.Text = "名      字";
		this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_消耗名字.Location = new System.Drawing.Point(182, 265);
		this.修改_消耗名字.Name = "修改_消耗名字";
		this.修改_消耗名字.Size = new System.Drawing.Size(120, 23);
		this.修改_消耗名字.TabIndex = 122;
		this.label16.Location = new System.Drawing.Point(121, 238);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(60, 23);
		this.label16.TabIndex = 119;
		this.label16.Text = "消耗类型";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.修改_消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.修改_消耗类型.FormattingEnabled = true;
		this.修改_消耗类型.Items.AddRange(new object[11]
		{
			"无", "金元宝", "银元宝", "声望", "战绩", "金钱", "累充点", "南极点", "灵气值", "体力",
			"道具"
		});
		this.修改_消耗类型.Location = new System.Drawing.Point(182, 237);
		this.修改_消耗类型.Name = "修改_消耗类型";
		this.修改_消耗类型.Size = new System.Drawing.Size(120, 25);
		this.修改_消耗类型.TabIndex = 120;
		this.修改_消耗类型.SelectedIndexChanged += new System.EventHandler(修改_消耗类型_SelectedIndexChanged);
		this.修改_消耗开关.AutoSize = true;
		this.修改_消耗开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_消耗开关.Location = new System.Drawing.Point(17, 238);
		this.修改_消耗开关.Name = "修改_消耗开关";
		this.修改_消耗开关.Size = new System.Drawing.Size(106, 23);
		this.修改_消耗开关.TabIndex = 118;
		this.修改_消耗开关.Text = "进入消耗开关";
		this.修改_消耗开关.UseVisualStyleBackColor = true;
		this.label11.Location = new System.Drawing.Point(121, 201);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(60, 23);
		this.label11.TabIndex = 116;
		this.label11.Text = "限副称号";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_副称号.Location = new System.Drawing.Point(182, 201);
		this.修改_副称号.Name = "修改_副称号";
		this.修改_副称号.Size = new System.Drawing.Size(120, 23);
		this.修改_副称号.TabIndex = 117;
		this.label12.Location = new System.Drawing.Point(121, 175);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(60, 23);
		this.label12.TabIndex = 114;
		this.label12.Text = "限主称号";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_主称号.Location = new System.Drawing.Point(182, 174);
		this.修改_主称号.Name = "修改_主称号";
		this.修改_主称号.Size = new System.Drawing.Size(120, 23);
		this.修改_主称号.TabIndex = 115;
		this.修改_称号开关.AutoSize = true;
		this.修改_称号开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_称号开关.Location = new System.Drawing.Point(17, 175);
		this.修改_称号开关.Name = "修改_称号开关";
		this.修改_称号开关.Size = new System.Drawing.Size(106, 23);
		this.修改_称号开关.TabIndex = 113;
		this.修改_称号开关.Text = "限制称号开关";
		this.修改_称号开关.UseVisualStyleBackColor = true;
		this.修改_最高道行.Location = new System.Drawing.Point(215, 113);
		this.修改_最高道行.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最高道行.Name = "修改_最高道行";
		this.修改_最高道行.Size = new System.Drawing.Size(60, 23);
		this.修改_最高道行.TabIndex = 112;
		this.label9.BackColor = System.Drawing.Color.Transparent;
		this.label9.Location = new System.Drawing.Point(192, 113);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(110, 23);
		this.label9.TabIndex = 111;
		this.label9.Text = "—                  年";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_最低道行.Location = new System.Drawing.Point(129, 113);
		this.修改_最低道行.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最低道行.Name = "修改_最低道行";
		this.修改_最低道行.Size = new System.Drawing.Size(60, 23);
		this.修改_最低道行.TabIndex = 110;
		this.修改_道行开关.AutoSize = true;
		this.修改_道行开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_道行开关.Location = new System.Drawing.Point(17, 113);
		this.修改_道行开关.Name = "修改_道行开关";
		this.修改_道行开关.Size = new System.Drawing.Size(106, 23);
		this.修改_道行开关.TabIndex = 109;
		this.修改_道行开关.Text = "限制道行开关";
		this.修改_道行开关.UseVisualStyleBackColor = true;
		this.修改_最高等级.Location = new System.Drawing.Point(215, 84);
		this.修改_最高等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最高等级.Name = "修改_最高等级";
		this.修改_最高等级.Size = new System.Drawing.Size(60, 23);
		this.修改_最高等级.TabIndex = 108;
		this.label10.BackColor = System.Drawing.Color.Transparent;
		this.label10.Location = new System.Drawing.Point(192, 84);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(110, 23);
		this.label10.TabIndex = 107;
		this.label10.Text = "—                  级";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_最低等级.Location = new System.Drawing.Point(129, 84);
		this.修改_最低等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最低等级.Name = "修改_最低等级";
		this.修改_最低等级.Size = new System.Drawing.Size(60, 23);
		this.修改_最低等级.TabIndex = 106;
		this.修改_等级开关.AutoSize = true;
		this.修改_等级开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_等级开关.Location = new System.Drawing.Point(17, 84);
		this.修改_等级开关.Name = "修改_等级开关";
		this.修改_等级开关.Size = new System.Drawing.Size(106, 23);
		this.修改_等级开关.TabIndex = 105;
		this.修改_等级开关.Text = "限制等级开关";
		this.修改_等级开关.UseVisualStyleBackColor = true;
		this.修改_组队开关.AutoSize = true;
		this.修改_组队开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_组队开关.Location = new System.Drawing.Point(196, 50);
		this.修改_组队开关.Name = "修改_组队开关";
		this.修改_组队开关.Size = new System.Drawing.Size(106, 23);
		this.修改_组队开关.TabIndex = 104;
		this.修改_组队开关.Text = "限制组队开关";
		this.修改_组队开关.UseVisualStyleBackColor = true;
		this.label8.Location = new System.Drawing.Point(17, 20);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(60, 23);
		this.label8.TabIndex = 102;
		this.label8.Text = "地图名字";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_名字.Location = new System.Drawing.Point(78, 20);
		this.修改_名字.Name = "修改_名字";
		this.修改_名字.ReadOnly = true;
		this.修改_名字.Size = new System.Drawing.Size(224, 23);
		this.修改_名字.TabIndex = 103;
		this.修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_取消按钮.Location = new System.Drawing.Point(159, 323);
		this.修改_取消按钮.Name = "修改_取消按钮";
		this.修改_取消按钮.Size = new System.Drawing.Size(78, 30);
		this.修改_取消按钮.TabIndex = 101;
		this.修改_取消按钮.Text = "取消";
		this.修改_取消按钮.UseVisualStyleBackColor = true;
		this.修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_确定按钮.Location = new System.Drawing.Point(61, 323);
		this.修改_确定按钮.Name = "修改_确定按钮";
		this.修改_确定按钮.Size = new System.Drawing.Size(78, 30);
		this.修改_确定按钮.TabIndex = 100;
		this.修改_确定按钮.Text = "修改";
		this.修改_确定按钮.UseVisualStyleBackColor = true;
		this.label17.ForeColor = System.Drawing.Color.Red;
		this.label17.Location = new System.Drawing.Point(336, 0);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(452, 49);
		this.label17.TabIndex = 88;
		this.label17.Text = "进入地图的消耗类型为“道具”时，该消耗道具必须写成空礼包，并且建议添加在超级道具中的禁止使用道具中防止玩家手误使用消耗掉了";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.地图名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.地图名字.HeaderText = "地图名字";
		this.地图名字.MinimumWidth = 100;
		this.地图名字.Name = "地图名字";
		this.地图名字.ReadOnly = true;
		this.进入关键词.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.进入关键词.HeaderText = "进入关键词";
		this.进入关键词.MinimumWidth = 100;
		this.进入关键词.Name = "进入关键词";
		this.进入关键词.ReadOnly = true;
		this.组队限制.HeaderText = "组队限制";
		this.组队限制.MinimumWidth = 80;
		this.组队限制.Name = "组队限制";
		this.组队限制.ReadOnly = true;
		this.组队限制.Width = 80;
		this.等级限制.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.等级限制.HeaderText = "等级限制";
		this.等级限制.MinimumWidth = 100;
		this.等级限制.Name = "等级限制";
		this.等级限制.ReadOnly = true;
		this.道行限制.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.道行限制.HeaderText = "道行限制";
		this.道行限制.MinimumWidth = 100;
		this.道行限制.Name = "道行限制";
		this.道行限制.ReadOnly = true;
		this.活跃限制.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.活跃限制.HeaderText = "活跃限制";
		this.活跃限制.MinimumWidth = 100;
		this.活跃限制.Name = "活跃限制";
		this.活跃限制.ReadOnly = true;
		this.称号限制.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.称号限制.HeaderText = "称号限制";
		this.称号限制.MinimumWidth = 150;
		this.称号限制.Name = "称号限制";
		this.称号限制.ReadOnly = true;
		this.称号限制.Width = 150;
		this.消耗限制.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
		this.消耗限制.HeaderText = "消耗限制";
		this.消耗限制.MinimumWidth = 150;
		this.消耗限制.Name = "消耗限制";
		this.消耗限制.ReadOnly = true;
		this.消耗限制.Width = 150;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(803, 631);
		base.Controls.Add(this.超级地图_添加按钮);
		base.Controls.Add(this.label17);
		base.Controls.Add(this.修改窗口);
		base.Controls.Add(this.超级地图_地图列表);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.超级地图_开关);
		base.Controls.Add(this.超级地图_重载按钮);
		base.Controls.Add(this.超级地图_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "超级地图配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "超级地图配置窗口";
		base.Load += new System.EventHandler(超级地图配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.超级地图_最高活跃).EndInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_最低活跃).EndInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_消耗数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_最高道行).EndInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_最低道行).EndInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_最高等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_最低等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.超级地图_地图列表).EndInit();
		this.修改窗口.ResumeLayout(false);
		this.修改窗口.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_最高活跃).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低活跃).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_消耗数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高道行).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低道行).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低等级).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
