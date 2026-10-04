using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 道具宠物回收配置窗口 : Form
{
	private static 道具宠物回收配置窗口 i;

	private IContainer components;

	private Button 回收_重载按钮;

	private Button 回收_保存按钮;

	private CheckBox 回收_道具开关;

	private CheckBox 回收_宠物开关;

	private TextBox 回收_名字;

	private Label label6;

	private NumericUpDown 回收_累充点;

	private Label label5;

	private NumericUpDown 回收_金元宝;

	private Label label2;

	private ComboBox 回收_类型;

	private Label label14;

	private NumericUpDown 回收_累充点几率;

	private Label label1;

	private Button 回收_添加按钮;

	private NumericUpDown 回收_银元宝;

	private Label label3;

	private Label label4;

	private NumericUpDown 回收_南极点几率;

	private NumericUpDown 回收_南极点;

	private Label label9;

	private GroupBox groupBox1;

	private DataGridView 回收_回收列表;

	private Panel 修改窗口;

	private Label label7;

	private Label label8;

	private Label label10;

	private NumericUpDown 修改_南极点几率;

	private NumericUpDown 修改_金元宝;

	private NumericUpDown 修改_南极点;

	private Label label11;

	private Label label12;

	private NumericUpDown 修改_累充点;

	private NumericUpDown 修改_银元宝;

	private Label label13;

	private Label label15;

	private TextBox 修改_类型;

	private Button 修改_确定按钮;

	private Label label16;

	private NumericUpDown 修改_累充点几率;

	private Button 修改_取消按钮;

	private TextBox 修改_名字;

	private Label label17;

	private Label 回收_添加提示;

	private Label label18;

	private NumericUpDown 回收_奇宝点几率;

	private NumericUpDown 回收_奇宝点;

	private Label label19;

	private Label label20;

	private NumericUpDown 修改_奇宝点几率;

	private NumericUpDown 修改_奇宝点;

	private Label label21;

	private CheckBox 回收_禁止绑定宠物回收;

	private CheckBox 回收_禁止绑定找回;

	private Label label25;

	private NumericUpDown 回收_奖励道具最高数量;

	private Label label23;

	private NumericUpDown 回收_奖励道具几率;

	private NumericUpDown 回收_奖励道具最低数量;

	private Label label24;

	private Label label22;

	private TextBox 回收_奖励道具;

	private Label label26;

	private NumericUpDown 修改_奖励道具最高数量;

	private Label label27;

	private NumericUpDown 修改_奖励道具几率;

	private NumericUpDown 修改_奖励道具最低数量;

	private Label label28;

	private Label label29;

	private TextBox 修改_奖励道具;

	private Label label30;

	private NumericUpDown 回收_游戏币几率;

	private NumericUpDown 回收_游戏币;

	private Label label31;

	private Label label32;

	private NumericUpDown 修改_游戏币几率;

	private NumericUpDown 修改_游戏币;

	private Label label33;

	private Label label34;

	private Label label35;

	private NumericUpDown 回收_灵气值几率;

	private NumericUpDown 回收_灵气值;

	private Label label36;

	private Label label37;

	private NumericUpDown 修改_灵气值几率;

	private NumericUpDown 修改_灵气值;

	private Label label38;

	private DataGridViewTextBoxColumn 名字;

	private DataGridViewTextBoxColumn 类型;

	private DataGridViewTextBoxColumn 金元宝;

	private DataGridViewTextBoxColumn 银元宝;

	private DataGridViewTextBoxColumn 累充点;

	private DataGridViewTextBoxColumn 南极点;

	private DataGridViewTextBoxColumn 奇宝点;

	private DataGridViewTextBoxColumn 游戏币;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn 奖励道具;

	public static 道具宠物回收配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 道具宠物回收配置窗口();
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
		回收_添加提示.Text = string.Empty;
	}

	public 道具宠物回收配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 道具宠物回收配置窗口_Load(object sender, EventArgs e)
	{
		回收_回收列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(修改事件回调, 删除事件回调);
		修改_取消按钮.Click += delegate
		{
			修改窗口.Visible = false;
		};
		修改_确定按钮.Click += 确定修改事件回调;
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		回收_重载按钮_Click(sender, e);
	}

	private void 修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 回收_回收列表.CurrentRow == null)
		{
			return;
		}
		int index = 回收_回收列表.CurrentRow.Index;
		if (index >= 0)
		{
			DataGridViewCellCollection cells = 回收_回收列表.Rows[index].Cells;
			修改_名字.Text = cells[0].Value.ToString();
			if (Singleton<全局变量类>.I.道具宠物回收配置.回收列表.TryGetValue(修改_名字.Text, out 道宠回收数据类 value))
			{
				修改_类型.Text = (value.Is道具 ? "道具" : "宠物");
				修改_金元宝.Text = value.金元宝.ToString();
				修改_银元宝.Text = value.银元宝.ToString();
				修改_累充点.Text = value.累充点.ToString();
				修改_累充点几率.Text = value.累充点几率.ToString();
				修改_南极点.Text = value.南极点.ToString();
				修改_南极点几率.Text = value.南极点几率.ToString();
				修改_奇宝点.Text = value.奇宝点.ToString();
				修改_奇宝点几率.Text = value.奇宝点几率.ToString();
				修改_游戏币.Text = value.游戏币.ToString();
				修改_游戏币几率.Text = value.游戏币几率.ToString();
				修改_灵气值.Text = value.灵气值.ToString();
				修改_灵气值几率.Text = value.灵气值几率.ToString();
				修改_奖励道具.Text = value.奖励道具;
				修改_奖励道具几率.Text = value.奖励道具几率.ToString();
				修改_奖励道具最低数量.Text = value.奖励道具最低数量.ToString();
				修改_奖励道具最高数量.Text = value.奖励道具最高数量.ToString();
				修改窗口.Visible = true;
			}
		}
	}

	private void 确定修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || !Singleton<全局变量类>.I.道具宠物回收配置.回收列表.TryGetValue(修改_名字.Text, out 道宠回收数据类 value))
		{
			return;
		}
		value.金元宝 = (int)修改_金元宝.Value;
		value.银元宝 = (int)修改_银元宝.Value;
		value.累充点 = (int)修改_累充点.Value;
		value.累充点几率 = (int)修改_累充点几率.Value;
		value.南极点 = (int)修改_南极点.Value;
		value.南极点几率 = (int)修改_南极点几率.Value;
		value.奇宝点 = (int)修改_奇宝点.Value;
		value.奇宝点几率 = (int)修改_奇宝点几率.Value;
		value.游戏币 = (int)修改_游戏币.Value;
		value.游戏币几率 = (int)修改_游戏币几率.Value;
		value.灵气值 = (int)修改_灵气值.Value;
		value.灵气值几率 = (int)修改_灵气值几率.Value;
		value.奖励道具 = 修改_奖励道具.Text;
		value.奖励道具几率 = (int)修改_奖励道具几率.Value;
		value.奖励道具最低数量 = (int)修改_奖励道具最低数量.Value;
		value.奖励道具最高数量 = (int)修改_奖励道具最高数量.Value;
		修改窗口.Visible = false;
		MessageBox.Show("[" + 修改_名字.Text + "]的回收配置已经修改，请及时点击保存配置按钮更新服务端配置！");
		if (回收_回收列表.CurrentRow != null)
		{
			int index = 回收_回收列表.CurrentRow.Index;
			if (index >= 0)
			{
				DataGridViewCellCollection cells = 回收_回收列表.Rows[index].Cells;
				cells[2].Value = value.金元宝;
				cells[3].Value = value.银元宝;
				cells[4].Value = $"{value.累充点}({value.累充点几率}%)";
				cells[5].Value = $"{value.南极点}({value.南极点几率}%)";
				cells[6].Value = $"{value.奇宝点}({value.奇宝点几率}%)";
				cells[7].Value = $"{value.游戏币}({value.游戏币几率}%)";
				cells[8].Value = $"{value.灵气值}({value.灵气值几率}%)";
				cells[9].Value = $"{value.奖励道具}*{value.奖励道具最低数量}-{value.奖励道具最高数量}({value.奖励道具几率}%)";
			}
		}
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 回收_回收列表.CurrentRow == null)
		{
			return;
		}
		int index = 回收_回收列表.CurrentRow.Index;
		if (index >= 0)
		{
			string text = 回收_回收列表.Rows[index].Cells[0].Value.ToString();
			if (Singleton<全局变量类>.I.道具宠物回收配置.回收列表.ContainsKey(text))
			{
				Singleton<全局变量类>.I.道具宠物回收配置.回收列表.TryRemove(text, out 道宠回收数据类 _);
				MessageBox.Show("[" + text + "]已从回收列表中删除，请及时点击保存配置按钮更新服务端配置！");
				回收_回收列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 回收_添加按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(回收_名字.Text))
			{
				MessageBox.Show("请输入要添加回收的宠物或者道具！");
				return;
			}
			if (string.IsNullOrWhiteSpace(回收_类型.Text))
			{
				MessageBox.Show("请选择要添加回收的类型！");
				return;
			}
			if (Singleton<全局变量类>.I.道具宠物回收配置.回收列表.ContainsKey(回收_名字.Text))
			{
				MessageBox.Show("回收列表中已经存在【" + 回收_名字.Text + "】，无法重复添加！");
				return;
			}
			道宠回收数据类 道宠回收数据类2 = new 道宠回收数据类
			{
				名字 = 回收_名字.Text,
				Is道具 = (回收_类型.Text == "道具"),
				金元宝 = (int)回收_金元宝.Value,
				银元宝 = (int)回收_银元宝.Value,
				累充点 = (int)回收_累充点.Value,
				累充点几率 = (int)回收_累充点几率.Value,
				南极点 = (int)回收_南极点.Value,
				南极点几率 = (int)回收_南极点几率.Value,
				奇宝点 = (int)回收_奇宝点.Value,
				奇宝点几率 = (int)回收_奇宝点几率.Value,
				游戏币 = (int)回收_游戏币.Value,
				游戏币几率 = (int)回收_游戏币几率.Value,
				灵气值 = (int)回收_灵气值.Value,
				灵气值几率 = (int)回收_灵气值几率.Value,
				奖励道具 = 回收_奖励道具.Text,
				奖励道具几率 = (int)回收_奖励道具几率.Value,
				奖励道具最低数量 = (int)回收_奖励道具最低数量.Value,
				奖励道具最高数量 = (int)回收_奖励道具最高数量.Value
			};
			Singleton<全局变量类>.I.道具宠物回收配置.回收列表.TryAdd(道宠回收数据类2.名字, 道宠回收数据类2);
			回收_回收列表.Rows.Add(道宠回收数据类2.名字, 道宠回收数据类2.Is道具 ? "道具" : "宠物", 道宠回收数据类2.金元宝, 道宠回收数据类2.银元宝, $"{道宠回收数据类2.累充点}({道宠回收数据类2.累充点几率}%)", $"{道宠回收数据类2.南极点}({道宠回收数据类2.南极点几率}%)", $"{道宠回收数据类2.奇宝点}({道宠回收数据类2.奇宝点几率}%)", $"{道宠回收数据类2.游戏币}({道宠回收数据类2.游戏币几率}%)", $"{道宠回收数据类2.灵气值}({道宠回收数据类2.灵气值几率}%)", $"{道宠回收数据类2.奖励道具}*{道宠回收数据类2.奖励道具最低数量}-{道宠回收数据类2.奖励道具最高数量}({道宠回收数据类2.奖励道具几率}%)");
			回收_添加提示.Text = "[" + 道宠回收数据类2.名字 + "]添加成功";
		}
	}

	private void 回收_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 5, JsonConvert.SerializeObject(Singleton<全局变量类>.I.道具宠物回收配置, Formatting.Indented));
		}
	}

	private void 回收_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 5);
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 5)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			回收_道具开关.Checked = Singleton<全局变量类>.I.道具宠物回收配置.is道具回收;
			回收_宠物开关.Checked = Singleton<全局变量类>.I.道具宠物回收配置.is宠物回收;
			回收_禁止绑定宠物回收.Checked = Singleton<全局变量类>.I.道具宠物回收配置.is禁止绑定宠物回收;
			回收_禁止绑定找回.Checked = Singleton<全局变量类>.I.道具宠物回收配置.is禁止绑定宠物道具找回;
			回收_回收列表.Rows.Clear();
			foreach (道宠回收数据类 value in Singleton<全局变量类>.I.道具宠物回收配置.回收列表.Values)
			{
				回收_回收列表.Rows.Add(value.名字, value.Is道具 ? "道具" : "宠物", value.金元宝, value.银元宝, $"{value.累充点}({value.累充点几率}%)", $"{value.南极点}({value.南极点几率}%)", $"{value.奇宝点}({value.奇宝点几率}%)", $"{value.游戏币}({value.游戏币几率}%)", $"{value.灵气值}({value.灵气值几率}%)", $"{value.奖励道具}*{value.奖励道具最低数量}-{value.奖励道具最高数量}({value.奖励道具几率}%)");
			}
		});
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.道具宠物回收配置.is道具回收 = 回收_道具开关.Checked;
			Singleton<全局变量类>.I.道具宠物回收配置.is宠物回收 = 回收_宠物开关.Checked;
			Singleton<全局变量类>.I.道具宠物回收配置.is禁止绑定宠物回收 = 回收_禁止绑定宠物回收.Checked;
			Singleton<全局变量类>.I.道具宠物回收配置.is禁止绑定宠物道具找回 = 回收_禁止绑定找回.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.道具宠物回收配置窗口));
		this.回收_重载按钮 = new System.Windows.Forms.Button();
		this.回收_保存按钮 = new System.Windows.Forms.Button();
		this.回收_道具开关 = new System.Windows.Forms.CheckBox();
		this.回收_宠物开关 = new System.Windows.Forms.CheckBox();
		this.回收_名字 = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.回收_累充点 = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.回收_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.回收_类型 = new System.Windows.Forms.ComboBox();
		this.label14 = new System.Windows.Forms.Label();
		this.回收_累充点几率 = new System.Windows.Forms.NumericUpDown();
		this.label1 = new System.Windows.Forms.Label();
		this.回收_添加按钮 = new System.Windows.Forms.Button();
		this.回收_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.回收_南极点几率 = new System.Windows.Forms.NumericUpDown();
		this.回收_南极点 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label30 = new System.Windows.Forms.Label();
		this.回收_游戏币几率 = new System.Windows.Forms.NumericUpDown();
		this.回收_游戏币 = new System.Windows.Forms.NumericUpDown();
		this.label31 = new System.Windows.Forms.Label();
		this.label25 = new System.Windows.Forms.Label();
		this.回收_奖励道具最高数量 = new System.Windows.Forms.NumericUpDown();
		this.label23 = new System.Windows.Forms.Label();
		this.回收_奖励道具几率 = new System.Windows.Forms.NumericUpDown();
		this.回收_奖励道具最低数量 = new System.Windows.Forms.NumericUpDown();
		this.label24 = new System.Windows.Forms.Label();
		this.label22 = new System.Windows.Forms.Label();
		this.回收_奖励道具 = new System.Windows.Forms.TextBox();
		this.label18 = new System.Windows.Forms.Label();
		this.回收_奇宝点几率 = new System.Windows.Forms.NumericUpDown();
		this.回收_奇宝点 = new System.Windows.Forms.NumericUpDown();
		this.label19 = new System.Windows.Forms.Label();
		this.回收_添加提示 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.回收_回收列表 = new System.Windows.Forms.DataGridView();
		this.修改窗口 = new System.Windows.Forms.Panel();
		this.label32 = new System.Windows.Forms.Label();
		this.修改_游戏币几率 = new System.Windows.Forms.NumericUpDown();
		this.修改_游戏币 = new System.Windows.Forms.NumericUpDown();
		this.label33 = new System.Windows.Forms.Label();
		this.label26 = new System.Windows.Forms.Label();
		this.修改_奖励道具最高数量 = new System.Windows.Forms.NumericUpDown();
		this.label27 = new System.Windows.Forms.Label();
		this.修改_奖励道具几率 = new System.Windows.Forms.NumericUpDown();
		this.修改_奖励道具最低数量 = new System.Windows.Forms.NumericUpDown();
		this.label28 = new System.Windows.Forms.Label();
		this.label29 = new System.Windows.Forms.Label();
		this.修改_奖励道具 = new System.Windows.Forms.TextBox();
		this.label20 = new System.Windows.Forms.Label();
		this.修改_奇宝点几率 = new System.Windows.Forms.NumericUpDown();
		this.修改_奇宝点 = new System.Windows.Forms.NumericUpDown();
		this.label21 = new System.Windows.Forms.Label();
		this.修改_取消按钮 = new System.Windows.Forms.Button();
		this.修改_名字 = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.修改_南极点几率 = new System.Windows.Forms.NumericUpDown();
		this.修改_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.修改_南极点 = new System.Windows.Forms.NumericUpDown();
		this.label11 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.修改_累充点 = new System.Windows.Forms.NumericUpDown();
		this.修改_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.label13 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.修改_类型 = new System.Windows.Forms.TextBox();
		this.修改_确定按钮 = new System.Windows.Forms.Button();
		this.label16 = new System.Windows.Forms.Label();
		this.修改_累充点几率 = new System.Windows.Forms.NumericUpDown();
		this.回收_禁止绑定宠物回收 = new System.Windows.Forms.CheckBox();
		this.回收_禁止绑定找回 = new System.Windows.Forms.CheckBox();
		this.label34 = new System.Windows.Forms.Label();
		this.label35 = new System.Windows.Forms.Label();
		this.回收_灵气值几率 = new System.Windows.Forms.NumericUpDown();
		this.回收_灵气值 = new System.Windows.Forms.NumericUpDown();
		this.label36 = new System.Windows.Forms.Label();
		this.label37 = new System.Windows.Forms.Label();
		this.修改_灵气值几率 = new System.Windows.Forms.NumericUpDown();
		this.修改_灵气值 = new System.Windows.Forms.NumericUpDown();
		this.label38 = new System.Windows.Forms.Label();
		this.名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.金元宝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.银元宝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.累充点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.南极点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.奇宝点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.游戏币 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.奖励道具 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		((System.ComponentModel.ISupportInitialize)this.回收_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_累充点几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_南极点几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_南极点).BeginInit();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.回收_游戏币几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_游戏币).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_奖励道具最高数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_奖励道具几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_奖励道具最低数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_奇宝点几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_奇宝点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_回收列表).BeginInit();
		this.修改窗口.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_游戏币几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_游戏币).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_奖励道具最高数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_奖励道具几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_奖励道具最低数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_奇宝点几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_奇宝点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_南极点几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_累充点几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_灵气值几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.回收_灵气值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_灵气值几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_灵气值).BeginInit();
		base.SuspendLayout();
		this.回收_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.回收_重载按钮.Location = new System.Drawing.Point(137, 5);
		this.回收_重载按钮.Name = "回收_重载按钮";
		this.回收_重载按钮.Size = new System.Drawing.Size(110, 30);
		this.回收_重载按钮.TabIndex = 50;
		this.回收_重载按钮.Text = "重载回收配置";
		this.回收_重载按钮.UseVisualStyleBackColor = true;
		this.回收_重载按钮.Click += new System.EventHandler(回收_重载按钮_Click);
		this.回收_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.回收_保存按钮.Location = new System.Drawing.Point(12, 5);
		this.回收_保存按钮.Name = "回收_保存按钮";
		this.回收_保存按钮.Size = new System.Drawing.Size(110, 30);
		this.回收_保存按钮.TabIndex = 49;
		this.回收_保存按钮.Text = "保存回收配置";
		this.回收_保存按钮.UseVisualStyleBackColor = true;
		this.回收_保存按钮.Click += new System.EventHandler(回收_保存按钮_Click);
		this.回收_道具开关.AutoSize = true;
		this.回收_道具开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.回收_道具开关.Location = new System.Drawing.Point(253, 9);
		this.回收_道具开关.Name = "回收_道具开关";
		this.回收_道具开关.Size = new System.Drawing.Size(106, 23);
		this.回收_道具开关.TabIndex = 48;
		this.回收_道具开关.Text = "道具回收开关";
		this.回收_道具开关.UseVisualStyleBackColor = true;
		this.回收_宠物开关.AutoSize = true;
		this.回收_宠物开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.回收_宠物开关.Location = new System.Drawing.Point(365, 9);
		this.回收_宠物开关.Name = "回收_宠物开关";
		this.回收_宠物开关.Size = new System.Drawing.Size(106, 23);
		this.回收_宠物开关.TabIndex = 51;
		this.回收_宠物开关.Text = "宠物回收开关";
		this.回收_宠物开关.UseVisualStyleBackColor = true;
		this.回收_名字.Location = new System.Drawing.Point(88, 53);
		this.回收_名字.Name = "回收_名字";
		this.回收_名字.Size = new System.Drawing.Size(153, 23);
		this.回收_名字.TabIndex = 61;
		this.label6.Location = new System.Drawing.Point(14, 53);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(68, 23);
		this.label6.TabIndex = 60;
		this.label6.Text = "名字";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.回收_累充点.Location = new System.Drawing.Point(88, 135);
		this.回收_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.回收_累充点.Name = "回收_累充点";
		this.回收_累充点.Size = new System.Drawing.Size(81, 23);
		this.回收_累充点.TabIndex = 57;
		this.label5.Location = new System.Drawing.Point(6, 135);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(76, 23);
		this.label5.TabIndex = 56;
		this.label5.Text = "累充点";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.回收_金元宝.Location = new System.Drawing.Point(88, 79);
		this.回收_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.回收_金元宝.Name = "回收_金元宝";
		this.回收_金元宝.Size = new System.Drawing.Size(153, 23);
		this.回收_金元宝.TabIndex = 53;
		this.label2.Location = new System.Drawing.Point(6, 79);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(76, 23);
		this.label2.TabIndex = 52;
		this.label2.Text = "金元宝";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.回收_类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.回收_类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.回收_类型.FormattingEnabled = true;
		this.回收_类型.Items.AddRange(new object[2] { "道具", "宠物" });
		this.回收_类型.Location = new System.Drawing.Point(88, 22);
		this.回收_类型.Name = "回收_类型";
		this.回收_类型.Size = new System.Drawing.Size(153, 25);
		this.回收_类型.TabIndex = 63;
		this.label14.Location = new System.Drawing.Point(6, 23);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(76, 23);
		this.label14.TabIndex = 62;
		this.label14.Text = "回收类型";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.回收_累充点几率.Location = new System.Drawing.Point(175, 135);
		this.回收_累充点几率.Name = "回收_累充点几率";
		this.回收_累充点几率.Size = new System.Drawing.Size(45, 23);
		this.回收_累充点几率.TabIndex = 64;
		this.label1.Location = new System.Drawing.Point(226, 134);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(15, 23);
		this.label1.TabIndex = 65;
		this.label1.Text = "%";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.回收_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.回收_添加按钮.Location = new System.Drawing.Point(35, 331);
		this.回收_添加按钮.Name = "回收_添加按钮";
		this.回收_添加按钮.Size = new System.Drawing.Size(211, 30);
		this.回收_添加按钮.TabIndex = 70;
		this.回收_添加按钮.Text = "添加";
		this.回收_添加按钮.UseVisualStyleBackColor = true;
		this.回收_添加按钮.Click += new System.EventHandler(回收_添加按钮_Click);
		this.回收_银元宝.Location = new System.Drawing.Point(88, 107);
		this.回收_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.回收_银元宝.Name = "回收_银元宝";
		this.回收_银元宝.Size = new System.Drawing.Size(153, 23);
		this.回收_银元宝.TabIndex = 72;
		this.label3.Location = new System.Drawing.Point(19, 107);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(63, 23);
		this.label3.TabIndex = 71;
		this.label3.Text = "银元宝";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label4.Location = new System.Drawing.Point(226, 163);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(15, 23);
		this.label4.TabIndex = 76;
		this.label4.Text = "%";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.回收_南极点几率.Location = new System.Drawing.Point(175, 164);
		this.回收_南极点几率.Name = "回收_南极点几率";
		this.回收_南极点几率.Size = new System.Drawing.Size(45, 23);
		this.回收_南极点几率.TabIndex = 75;
		this.回收_南极点.Location = new System.Drawing.Point(88, 164);
		this.回收_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.回收_南极点.Name = "回收_南极点";
		this.回收_南极点.Size = new System.Drawing.Size(81, 23);
		this.回收_南极点.TabIndex = 74;
		this.label9.Location = new System.Drawing.Point(6, 164);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(76, 23);
		this.label9.TabIndex = 73;
		this.label9.Text = "南极点";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.groupBox1.Controls.Add(this.label35);
		this.groupBox1.Controls.Add(this.回收_灵气值几率);
		this.groupBox1.Controls.Add(this.回收_灵气值);
		this.groupBox1.Controls.Add(this.label36);
		this.groupBox1.Controls.Add(this.label30);
		this.groupBox1.Controls.Add(this.回收_游戏币几率);
		this.groupBox1.Controls.Add(this.回收_游戏币);
		this.groupBox1.Controls.Add(this.label31);
		this.groupBox1.Controls.Add(this.label25);
		this.groupBox1.Controls.Add(this.回收_奖励道具最高数量);
		this.groupBox1.Controls.Add(this.label23);
		this.groupBox1.Controls.Add(this.回收_奖励道具几率);
		this.groupBox1.Controls.Add(this.回收_奖励道具最低数量);
		this.groupBox1.Controls.Add(this.label24);
		this.groupBox1.Controls.Add(this.label22);
		this.groupBox1.Controls.Add(this.回收_奖励道具);
		this.groupBox1.Controls.Add(this.label18);
		this.groupBox1.Controls.Add(this.回收_奇宝点几率);
		this.groupBox1.Controls.Add(this.回收_奇宝点);
		this.groupBox1.Controls.Add(this.label19);
		this.groupBox1.Controls.Add(this.回收_添加提示);
		this.groupBox1.Controls.Add(this.label17);
		this.groupBox1.Controls.Add(this.label14);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.回收_南极点几率);
		this.groupBox1.Controls.Add(this.回收_金元宝);
		this.groupBox1.Controls.Add(this.回收_南极点);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.label9);
		this.groupBox1.Controls.Add(this.回收_累充点);
		this.groupBox1.Controls.Add(this.回收_银元宝);
		this.groupBox1.Controls.Add(this.label6);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.回收_名字);
		this.groupBox1.Controls.Add(this.回收_添加按钮);
		this.groupBox1.Controls.Add(this.回收_类型);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.回收_累充点几率);
		this.groupBox1.Location = new System.Drawing.Point(12, 41);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(255, 434);
		this.groupBox1.TabIndex = 77;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "填写添加回收配置";
		this.label30.Location = new System.Drawing.Point(226, 221);
		this.label30.Name = "label30";
		this.label30.Size = new System.Drawing.Size(15, 23);
		this.label30.TabIndex = 94;
		this.label30.Text = "%";
		this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.回收_游戏币几率.Location = new System.Drawing.Point(175, 222);
		this.回收_游戏币几率.Name = "回收_游戏币几率";
		this.回收_游戏币几率.Size = new System.Drawing.Size(45, 23);
		this.回收_游戏币几率.TabIndex = 93;
		this.回收_游戏币.Location = new System.Drawing.Point(88, 222);
		this.回收_游戏币.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.回收_游戏币.Name = "回收_游戏币";
		this.回收_游戏币.Size = new System.Drawing.Size(81, 23);
		this.回收_游戏币.TabIndex = 92;
		this.label31.Location = new System.Drawing.Point(6, 222);
		this.label31.Name = "label31";
		this.label31.Size = new System.Drawing.Size(76, 23);
		this.label31.TabIndex = 91;
		this.label31.Text = "游戏币";
		this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label25.Location = new System.Drawing.Point(160, 303);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(15, 23);
		this.label25.TabIndex = 90;
		this.label25.Text = "-";
		this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.回收_奖励道具最高数量.Location = new System.Drawing.Point(175, 305);
		this.回收_奖励道具最高数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.回收_奖励道具最高数量.Name = "回收_奖励道具最高数量";
		this.回收_奖励道具最高数量.Size = new System.Drawing.Size(66, 23);
		this.回收_奖励道具最高数量.TabIndex = 89;
		this.label23.Location = new System.Drawing.Point(226, 279);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(15, 23);
		this.label23.TabIndex = 88;
		this.label23.Text = "%";
		this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.回收_奖励道具几率.Location = new System.Drawing.Point(175, 279);
		this.回收_奖励道具几率.Name = "回收_奖励道具几率";
		this.回收_奖励道具几率.Size = new System.Drawing.Size(45, 23);
		this.回收_奖励道具几率.TabIndex = 87;
		this.回收_奖励道具最低数量.Location = new System.Drawing.Point(88, 304);
		this.回收_奖励道具最低数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.回收_奖励道具最低数量.Name = "回收_奖励道具最低数量";
		this.回收_奖励道具最低数量.Size = new System.Drawing.Size(70, 23);
		this.回收_奖励道具最低数量.TabIndex = 86;
		this.label24.Location = new System.Drawing.Point(6, 304);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(76, 23);
		this.label24.TabIndex = 85;
		this.label24.Text = "道具数量";
		this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label22.Location = new System.Drawing.Point(14, 279);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(68, 23);
		this.label22.TabIndex = 83;
		this.label22.Text = "奖励道具";
		this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.回收_奖励道具.Location = new System.Drawing.Point(88, 279);
		this.回收_奖励道具.Name = "回收_奖励道具";
		this.回收_奖励道具.Size = new System.Drawing.Size(81, 23);
		this.回收_奖励道具.TabIndex = 84;
		this.label18.Location = new System.Drawing.Point(226, 192);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(15, 23);
		this.label18.TabIndex = 82;
		this.label18.Text = "%";
		this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.回收_奇宝点几率.Location = new System.Drawing.Point(175, 193);
		this.回收_奇宝点几率.Name = "回收_奇宝点几率";
		this.回收_奇宝点几率.Size = new System.Drawing.Size(45, 23);
		this.回收_奇宝点几率.TabIndex = 81;
		this.回收_奇宝点.Location = new System.Drawing.Point(88, 193);
		this.回收_奇宝点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.回收_奇宝点.Name = "回收_奇宝点";
		this.回收_奇宝点.Size = new System.Drawing.Size(81, 23);
		this.回收_奇宝点.TabIndex = 80;
		this.label19.Location = new System.Drawing.Point(6, 193);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(76, 23);
		this.label19.TabIndex = 79;
		this.label19.Text = "奇宝点";
		this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.回收_添加提示.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.回收_添加提示.ForeColor = System.Drawing.Color.Blue;
		this.回收_添加提示.Location = new System.Drawing.Point(35, 367);
		this.回收_添加提示.Name = "回收_添加提示";
		this.回收_添加提示.Size = new System.Drawing.Size(211, 17);
		this.回收_添加提示.TabIndex = 78;
		this.回收_添加提示.Text = "122";
		this.回收_添加提示.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label17.ForeColor = System.Drawing.Color.Red;
		this.label17.Location = new System.Drawing.Point(35, 387);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(211, 34);
		this.label17.TabIndex = 77;
		this.label17.Text = "宠物回收的NPC和宠物同源、宠物召唤是一个npc";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.回收_回收列表.AllowUserToAddRows = false;
		this.回收_回收列表.AllowUserToDeleteRows = false;
		this.回收_回收列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.回收_回收列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.回收_回收列表.BackgroundColor = System.Drawing.Color.White;
		this.回收_回收列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.回收_回收列表.Columns.AddRange(this.名字, this.类型, this.金元宝, this.银元宝, this.累充点, this.南极点, this.奇宝点, this.游戏币, this.Column1, this.奖励道具);
		this.回收_回收列表.Location = new System.Drawing.Point(273, 41);
		this.回收_回收列表.MultiSelect = false;
		this.回收_回收列表.Name = "回收_回收列表";
		this.回收_回收列表.ReadOnly = true;
		this.回收_回收列表.RowHeadersVisible = false;
		this.回收_回收列表.RowTemplate.Height = 25;
		this.回收_回收列表.Size = new System.Drawing.Size(721, 397);
		this.回收_回收列表.TabIndex = 78;
		this.修改窗口.Controls.Add(this.label37);
		this.修改窗口.Controls.Add(this.修改_灵气值几率);
		this.修改窗口.Controls.Add(this.修改_灵气值);
		this.修改窗口.Controls.Add(this.label38);
		this.修改窗口.Controls.Add(this.label32);
		this.修改窗口.Controls.Add(this.修改_游戏币几率);
		this.修改窗口.Controls.Add(this.修改_游戏币);
		this.修改窗口.Controls.Add(this.label33);
		this.修改窗口.Controls.Add(this.label26);
		this.修改窗口.Controls.Add(this.修改_奖励道具最高数量);
		this.修改窗口.Controls.Add(this.label27);
		this.修改窗口.Controls.Add(this.修改_奖励道具几率);
		this.修改窗口.Controls.Add(this.修改_奖励道具最低数量);
		this.修改窗口.Controls.Add(this.label28);
		this.修改窗口.Controls.Add(this.label29);
		this.修改窗口.Controls.Add(this.修改_奖励道具);
		this.修改窗口.Controls.Add(this.label20);
		this.修改窗口.Controls.Add(this.修改_奇宝点几率);
		this.修改窗口.Controls.Add(this.修改_奇宝点);
		this.修改窗口.Controls.Add(this.label21);
		this.修改窗口.Controls.Add(this.修改_取消按钮);
		this.修改窗口.Controls.Add(this.修改_名字);
		this.修改窗口.Controls.Add(this.label7);
		this.修改窗口.Controls.Add(this.label8);
		this.修改窗口.Controls.Add(this.label10);
		this.修改窗口.Controls.Add(this.修改_南极点几率);
		this.修改窗口.Controls.Add(this.修改_金元宝);
		this.修改窗口.Controls.Add(this.修改_南极点);
		this.修改窗口.Controls.Add(this.label11);
		this.修改窗口.Controls.Add(this.label12);
		this.修改窗口.Controls.Add(this.修改_累充点);
		this.修改窗口.Controls.Add(this.修改_银元宝);
		this.修改窗口.Controls.Add(this.label13);
		this.修改窗口.Controls.Add(this.label15);
		this.修改窗口.Controls.Add(this.修改_类型);
		this.修改窗口.Controls.Add(this.修改_确定按钮);
		this.修改窗口.Controls.Add(this.label16);
		this.修改窗口.Controls.Add(this.修改_累充点几率);
		this.修改窗口.Location = new System.Drawing.Point(355, 120);
		this.修改窗口.Name = "修改窗口";
		this.修改窗口.Size = new System.Drawing.Size(492, 215);
		this.修改窗口.TabIndex = 77;
		this.修改窗口.Visible = false;
		this.label32.Location = new System.Drawing.Point(436, 135);
		this.label32.Name = "label32";
		this.label32.Size = new System.Drawing.Size(20, 23);
		this.label32.TabIndex = 111;
		this.label32.Text = "%";
		this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_游戏币几率.Location = new System.Drawing.Point(385, 135);
		this.修改_游戏币几率.Name = "修改_游戏币几率";
		this.修改_游戏币几率.Size = new System.Drawing.Size(51, 23);
		this.修改_游戏币几率.TabIndex = 110;
		this.修改_游戏币.Location = new System.Drawing.Point(300, 135);
		this.修改_游戏币.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_游戏币.Name = "修改_游戏币";
		this.修改_游戏币.Size = new System.Drawing.Size(81, 23);
		this.修改_游戏币.TabIndex = 109;
		this.label33.Location = new System.Drawing.Point(239, 135);
		this.label33.Name = "label33";
		this.label33.Size = new System.Drawing.Size(60, 23);
		this.label33.TabIndex = 108;
		this.label33.Text = "游戏币";
		this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label26.Location = new System.Drawing.Point(155, 135);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(10, 23);
		this.label26.TabIndex = 107;
		this.label26.Text = "-";
		this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_奖励道具最高数量.Location = new System.Drawing.Point(168, 135);
		this.修改_奖励道具最高数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_奖励道具最高数量.Name = "修改_奖励道具最高数量";
		this.修改_奖励道具最高数量.Size = new System.Drawing.Size(68, 23);
		this.修改_奖励道具最高数量.TabIndex = 106;
		this.label27.Location = new System.Drawing.Point(221, 107);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(15, 23);
		this.label27.TabIndex = 105;
		this.label27.Text = "%";
		this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_奖励道具几率.Location = new System.Drawing.Point(168, 107);
		this.修改_奖励道具几率.Name = "修改_奖励道具几率";
		this.修改_奖励道具几率.Size = new System.Drawing.Size(51, 23);
		this.修改_奖励道具几率.TabIndex = 104;
		this.修改_奖励道具最低数量.Location = new System.Drawing.Point(83, 135);
		this.修改_奖励道具最低数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_奖励道具最低数量.Name = "修改_奖励道具最低数量";
		this.修改_奖励道具最低数量.Size = new System.Drawing.Size(70, 23);
		this.修改_奖励道具最低数量.TabIndex = 103;
		this.label28.Location = new System.Drawing.Point(22, 135);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(60, 23);
		this.label28.TabIndex = 102;
		this.label28.Text = "道具数量";
		this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label29.Location = new System.Drawing.Point(22, 107);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(60, 23);
		this.label29.TabIndex = 100;
		this.label29.Text = "奖励道具";
		this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_奖励道具.Location = new System.Drawing.Point(83, 107);
		this.修改_奖励道具.Name = "修改_奖励道具";
		this.修改_奖励道具.Size = new System.Drawing.Size(81, 23);
		this.修改_奖励道具.TabIndex = 101;
		this.label20.Location = new System.Drawing.Point(436, 107);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(20, 23);
		this.label20.TabIndex = 99;
		this.label20.Text = "%";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_奇宝点几率.Location = new System.Drawing.Point(385, 107);
		this.修改_奇宝点几率.Name = "修改_奇宝点几率";
		this.修改_奇宝点几率.Size = new System.Drawing.Size(51, 23);
		this.修改_奇宝点几率.TabIndex = 98;
		this.修改_奇宝点.Location = new System.Drawing.Point(300, 107);
		this.修改_奇宝点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_奇宝点.Name = "修改_奇宝点";
		this.修改_奇宝点.Size = new System.Drawing.Size(81, 23);
		this.修改_奇宝点.TabIndex = 97;
		this.label21.Location = new System.Drawing.Point(239, 107);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(60, 23);
		this.label21.TabIndex = 96;
		this.label21.Text = "奇宝点";
		this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_取消按钮.Location = new System.Drawing.Point(134, 164);
		this.修改_取消按钮.Name = "修改_取消按钮";
		this.修改_取消按钮.Size = new System.Drawing.Size(100, 30);
		this.修改_取消按钮.TabIndex = 95;
		this.修改_取消按钮.Text = "取消";
		this.修改_取消按钮.UseVisualStyleBackColor = true;
		this.修改_名字.BackColor = System.Drawing.Color.WhiteSmoke;
		this.修改_名字.Location = new System.Drawing.Point(80, 21);
		this.修改_名字.Name = "修改_名字";
		this.修改_名字.ReadOnly = true;
		this.修改_名字.Size = new System.Drawing.Size(153, 23);
		this.修改_名字.TabIndex = 94;
		this.label7.Location = new System.Drawing.Point(19, 21);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(60, 23);
		this.label7.TabIndex = 83;
		this.label7.Text = "名字";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label8.Location = new System.Drawing.Point(436, 79);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(20, 23);
		this.label8.TabIndex = 93;
		this.label8.Text = "%";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label10.Location = new System.Drawing.Point(22, 53);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(60, 23);
		this.label10.TabIndex = 77;
		this.label10.Text = "金元宝";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_南极点几率.Location = new System.Drawing.Point(385, 79);
		this.修改_南极点几率.Name = "修改_南极点几率";
		this.修改_南极点几率.Size = new System.Drawing.Size(51, 23);
		this.修改_南极点几率.TabIndex = 92;
		this.修改_金元宝.Location = new System.Drawing.Point(83, 53);
		this.修改_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_金元宝.Name = "修改_金元宝";
		this.修改_金元宝.Size = new System.Drawing.Size(153, 23);
		this.修改_金元宝.TabIndex = 78;
		this.修改_南极点.Location = new System.Drawing.Point(300, 79);
		this.修改_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_南极点.Name = "修改_南极点";
		this.修改_南极点.Size = new System.Drawing.Size(81, 23);
		this.修改_南极点.TabIndex = 91;
		this.label11.Location = new System.Drawing.Point(239, 53);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(60, 23);
		this.label11.TabIndex = 79;
		this.label11.Text = "累充点";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label12.Location = new System.Drawing.Point(239, 79);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(60, 23);
		this.label12.TabIndex = 90;
		this.label12.Text = "南极点";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_累充点.Location = new System.Drawing.Point(300, 53);
		this.修改_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_累充点.Name = "修改_累充点";
		this.修改_累充点.Size = new System.Drawing.Size(81, 23);
		this.修改_累充点.TabIndex = 80;
		this.修改_银元宝.Location = new System.Drawing.Point(83, 79);
		this.修改_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_银元宝.Name = "修改_银元宝";
		this.修改_银元宝.Size = new System.Drawing.Size(153, 23);
		this.修改_银元宝.TabIndex = 89;
		this.label13.Location = new System.Drawing.Point(239, 21);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(60, 23);
		this.label13.TabIndex = 81;
		this.label13.Text = "回收类型";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label15.Location = new System.Drawing.Point(22, 79);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(60, 23);
		this.label15.TabIndex = 88;
		this.label15.Text = "银元宝";
		this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_类型.BackColor = System.Drawing.Color.WhiteSmoke;
		this.修改_类型.Location = new System.Drawing.Point(300, 21);
		this.修改_类型.Name = "修改_类型";
		this.修改_类型.ReadOnly = true;
		this.修改_类型.Size = new System.Drawing.Size(153, 23);
		this.修改_类型.TabIndex = 82;
		this.修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_确定按钮.Location = new System.Drawing.Point(28, 164);
		this.修改_确定按钮.Name = "修改_确定按钮";
		this.修改_确定按钮.Size = new System.Drawing.Size(100, 30);
		this.修改_确定按钮.TabIndex = 87;
		this.修改_确定按钮.Text = "修改";
		this.修改_确定按钮.UseVisualStyleBackColor = true;
		this.label16.Location = new System.Drawing.Point(436, 53);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(20, 23);
		this.label16.TabIndex = 86;
		this.label16.Text = "%";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_累充点几率.Location = new System.Drawing.Point(385, 53);
		this.修改_累充点几率.Name = "修改_累充点几率";
		this.修改_累充点几率.Size = new System.Drawing.Size(51, 23);
		this.修改_累充点几率.TabIndex = 85;
		this.回收_禁止绑定宠物回收.AutoSize = true;
		this.回收_禁止绑定宠物回收.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.回收_禁止绑定宠物回收.Location = new System.Drawing.Point(477, 9);
		this.回收_禁止绑定宠物回收.Name = "回收_禁止绑定宠物回收";
		this.回收_禁止绑定宠物回收.Size = new System.Drawing.Size(132, 23);
		this.回收_禁止绑定宠物回收.TabIndex = 79;
		this.回收_禁止绑定宠物回收.Text = "禁止绑定宠物回收";
		this.回收_禁止绑定宠物回收.UseVisualStyleBackColor = true;
		this.回收_禁止绑定找回.AutoSize = true;
		this.回收_禁止绑定找回.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.回收_禁止绑定找回.Location = new System.Drawing.Point(615, 9);
		this.回收_禁止绑定找回.Name = "回收_禁止绑定找回";
		this.回收_禁止绑定找回.Size = new System.Drawing.Size(220, 23);
		this.回收_禁止绑定找回.TabIndex = 80;
		this.回收_禁止绑定找回.Text = "禁止绑定宠物道具找回(白眉真人)";
		this.回收_禁止绑定找回.UseVisualStyleBackColor = true;
		this.label34.Font = new System.Drawing.Font("Microsoft YaHei UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.label34.ForeColor = System.Drawing.Color.Red;
		this.label34.Location = new System.Drawing.Point(273, 441);
		this.label34.Name = "label34";
		this.label34.Size = new System.Drawing.Size(718, 34);
		this.label34.TabIndex = 81;
		this.label34.Text = "宠物回收开了就不要开启贵重物品不能交易丢弃，原版etc即可";
		this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label35.Location = new System.Drawing.Point(226, 250);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(15, 23);
		this.label35.TabIndex = 98;
		this.label35.Text = "%";
		this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.回收_灵气值几率.Location = new System.Drawing.Point(175, 251);
		this.回收_灵气值几率.Name = "回收_灵气值几率";
		this.回收_灵气值几率.Size = new System.Drawing.Size(45, 23);
		this.回收_灵气值几率.TabIndex = 97;
		this.回收_灵气值.Location = new System.Drawing.Point(88, 251);
		this.回收_灵气值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.回收_灵气值.Name = "回收_灵气值";
		this.回收_灵气值.Size = new System.Drawing.Size(81, 23);
		this.回收_灵气值.TabIndex = 96;
		this.label36.Location = new System.Drawing.Point(6, 251);
		this.label36.Name = "label36";
		this.label36.Size = new System.Drawing.Size(76, 23);
		this.label36.TabIndex = 95;
		this.label36.Text = "灵气值";
		this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label37.Location = new System.Drawing.Point(436, 164);
		this.label37.Name = "label37";
		this.label37.Size = new System.Drawing.Size(20, 23);
		this.label37.TabIndex = 115;
		this.label37.Text = "%";
		this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_灵气值几率.Location = new System.Drawing.Point(385, 164);
		this.修改_灵气值几率.Name = "修改_灵气值几率";
		this.修改_灵气值几率.Size = new System.Drawing.Size(51, 23);
		this.修改_灵气值几率.TabIndex = 114;
		this.修改_灵气值.Location = new System.Drawing.Point(300, 164);
		this.修改_灵气值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_灵气值.Name = "修改_灵气值";
		this.修改_灵气值.Size = new System.Drawing.Size(81, 23);
		this.修改_灵气值.TabIndex = 113;
		this.label38.Location = new System.Drawing.Point(239, 164);
		this.label38.Name = "label38";
		this.label38.Size = new System.Drawing.Size(60, 23);
		this.label38.TabIndex = 112;
		this.label38.Text = "灵气值";
		this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.名字.HeaderText = "名字";
		this.名字.MinimumWidth = 80;
		this.名字.Name = "名字";
		this.名字.ReadOnly = true;
		this.名字.Width = 80;
		this.类型.HeaderText = "类型";
		this.类型.Name = "类型";
		this.类型.ReadOnly = true;
		this.类型.Width = 80;
		this.金元宝.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.金元宝.HeaderText = "金元宝";
		this.金元宝.MinimumWidth = 70;
		this.金元宝.Name = "金元宝";
		this.金元宝.ReadOnly = true;
		this.金元宝.Width = 70;
		this.银元宝.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.银元宝.HeaderText = "银元宝";
		this.银元宝.MinimumWidth = 70;
		this.银元宝.Name = "银元宝";
		this.银元宝.ReadOnly = true;
		this.银元宝.Width = 70;
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
		this.游戏币.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.游戏币.HeaderText = "游戏币";
		this.游戏币.MinimumWidth = 100;
		this.游戏币.Name = "游戏币";
		this.游戏币.ReadOnly = true;
		this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.Column1.HeaderText = "灵气值";
		this.Column1.MinimumWidth = 100;
		this.Column1.Name = "Column1";
		this.Column1.ReadOnly = true;
		this.奖励道具.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.奖励道具.HeaderText = "奖励道具";
		this.奖励道具.MinimumWidth = 100;
		this.奖励道具.Name = "奖励道具";
		this.奖励道具.ReadOnly = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(1003, 475);
		base.Controls.Add(this.label34);
		base.Controls.Add(this.回收_禁止绑定找回);
		base.Controls.Add(this.回收_禁止绑定宠物回收);
		base.Controls.Add(this.修改窗口);
		base.Controls.Add(this.回收_回收列表);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.回收_宠物开关);
		base.Controls.Add(this.回收_道具开关);
		base.Controls.Add(this.回收_重载按钮);
		base.Controls.Add(this.回收_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "道具宠物回收配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "道具宠物回收配置窗口";
		base.Load += new System.EventHandler(道具宠物回收配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.回收_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_累充点几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_南极点几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_南极点).EndInit();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.回收_游戏币几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_游戏币).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_奖励道具最高数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_奖励道具几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_奖励道具最低数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_奇宝点几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_奇宝点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_回收列表).EndInit();
		this.修改窗口.ResumeLayout(false);
		this.修改窗口.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_游戏币几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_游戏币).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_奖励道具最高数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_奖励道具几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_奖励道具最低数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_奇宝点几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_奇宝点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_南极点几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_累充点几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_灵气值几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.回收_灵气值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_灵气值几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_灵气值).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
