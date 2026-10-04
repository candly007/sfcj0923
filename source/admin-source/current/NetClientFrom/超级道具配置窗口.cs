using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 超级道具配置窗口 : Form
{
	private static 超级道具配置窗口 i;

	private IContainer components;

	private CheckBox 超级道具_开关;

	private Button 超级道具_重载按钮;

	private Button 超级道具_保存按钮;

	private Label label6;

	private TextBox 超级道具_自动使用道具;

	private Label label1;

	private TextBox 超级道具_禁止使用道具;

	private Label label2;

	private TextBox 超级道具_禁止摆摊道具;

	private Label label3;

	private TextBox 超级道具_禁止交易道具;

	private Label label4;

	private TextBox 超级道具_禁止商会道具;

	private Label label5;

	private TextBox 超级道具_禁止拍卖道具;

	private Label label7;

	private Button 超级道具_打开新增窗口按钮;

	private DataGridView 超级道具_道具列表;

	private Panel 修改窗口;

	private Label label8;

	private TextBox 修改_名字;

	private Label label10;

	private NumericUpDown 修改_使用数量;

	private Label label9;

	private TextBox 修改_消耗价格;

	private ComboBox 修改_消耗类型;

	private Label label11;

	private NumericUpDown 修改_最高道行;

	private Label label12;

	private NumericUpDown 修改_最低道行;

	private CheckBox 修改_限制道行开关;

	private NumericUpDown 修改_最高等级;

	private Label label13;

	private NumericUpDown 修改_最低等级;

	private CheckBox 修改_限制等级开关;

	private NumericUpDown 修改_额外奖励最高;

	private Label label16;

	private NumericUpDown 修改_额外奖励最低;

	private ComboBox 修改_额外奖励类型;

	private Label label15;

	private CheckBox 修改_额外奖励开关;

	private Label label14;

	private TextBox 修改_指定称号;

	private CheckBox 修改_限制称号开关;

	private CheckBox 修改_重置累计开关;

	private CheckBox 修改_累计使用开关;

	private NumericUpDown 修改_额外奖励几率;

	private Label label17;

	private ComboBox 修改_当前累计奖励类型;

	private Label label20;

	private NumericUpDown 修改_最高累计数量;

	private Label label19;

	private NumericUpDown 修改_最低累计数量;

	private Label label18;

	private Button 修改_添加累计奖励按钮;

	private TextBox 修改_当前累计奖励内容;

	private DataGridView 修改_累计奖励列表;

	private Button 修改_取消按钮;

	private Button 修改_确定按钮;

	private DataGridViewTextBoxColumn 最低累计;

	private DataGridViewTextBoxColumn 最高累计;

	private DataGridViewTextBoxColumn 奖励类型;

	private DataGridViewTextBoxColumn 奖励内容;

	private Label label21;

	private DataGridViewTextBoxColumn 道具名字;

	private DataGridViewTextBoxColumn 最多使用数量;

	private DataGridViewTextBoxColumn 使用消耗;

	private DataGridViewTextBoxColumn 使用等级;

	private DataGridViewTextBoxColumn 使用道行;

	private DataGridViewTextBoxColumn 使用称号;

	private DataGridViewTextBoxColumn 额外奖励;

	private DataGridViewTextBoxColumn 累计使用奖励;

	private Label label22;

	private TextBox 超级道具_禁止丢弃道具;

	private Label label23;

	private TextBox 超级道具_使用校验道具;

	private ToolTip 超级道具_提示组件;

	private Label label24;

	private TextBox 超级道具_自动绑定道具;

	private Label label附加属性类型;

	private ComboBox 修改_附加属性类型;

	private Label label27;

	private NumericUpDown 修改_附加属性限时;

	private Label label附加属性限时;

	private CheckBox 超级道具_定制开关;

	public static 超级道具配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 超级道具配置窗口();
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
		label27.Visible = 全局变量类.Is中州论道;
		label附加属性类型.Visible = 全局变量类.Is中州论道;
		label附加属性限时.Visible = 全局变量类.Is中州论道;
		修改_附加属性类型.Visible = 全局变量类.Is中州论道;
		修改_附加属性限时.Visible = 全局变量类.Is中州论道;
		修改窗口.Visible = false;
	}

	public 超级道具配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 超级道具配置窗口_Load(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			超级道具_道具列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(修改事件回调, 删除事件回调);
			修改_取消按钮.Click += delegate
			{
				修改窗口.Visible = false;
			};
			修改_确定按钮.Click += 确定修改事件回调;
			修改_累计奖励列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 累计_删除事件回调);
			超级道具_提示组件.SetToolTip(超级道具_使用校验道具, "格式例子：|道具1|道具2|\r\n这里写的道具在右键使用时会先校验一下背包位置和宠物位置是否满了");
			超级道具_提示组件.SetToolTip(超级道具_自动绑定道具, "格式例子：|道具1|道具2|\r\n这里写的道具在获得后会自动进行死绑");
			Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
			全局变量类 obj = Singleton<全局变量类>.I;
			obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
			超级道具_重载按钮_Click(sender, e);
		}
	}

	private void 修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 超级道具_道具列表.CurrentRow == null)
		{
			return;
		}
		int index = 超级道具_道具列表.CurrentRow.Index;
		if (index < 0)
		{
			return;
		}
		DataGridViewCellCollection cells = 超级道具_道具列表.Rows[index].Cells;
		修改_名字.Text = cells["道具名字"].Value.ToString();
		if (Singleton<全局变量类>.I.超级道具配置.超级道具列表.TryGetValue(修改_名字.Text, out 超级道具列表配置类 value))
		{
			修改_名字.ReadOnly = true;
			修改_确定按钮.Text = "修     改";
			修改_使用数量.Value = value.最多使用数量;
			修改_消耗类型.Text = value.道具消耗类型.ToString();
			修改_消耗价格.Text = value.道具消耗内容;
			修改_限制等级开关.Checked = value.is等级开关;
			修改_最低等级.Value = value.最低使用等级;
			修改_最高等级.Value = value.最高使用等级;
			修改_限制道行开关.Checked = value.is道行开关;
			修改_最低道行.Value = value.最低使用道行;
			修改_最高道行.Value = value.最高使用道行;
			修改_限制称号开关.Checked = value.is称号开关;
			修改_指定称号.Text = value.指定称号使用;
			修改_额外奖励开关.Checked = value.is奖励开关;
			修改_额外奖励类型.Text = value.额外奖励类型.ToString();
			修改_附加属性类型.Text = value.附加属性类型.ToString();
			修改_附加属性限时.Value = value.附加属性限时;
			修改_额外奖励最低.Value = value.最低奖励下限;
			修改_额外奖励最高.Value = value.最高奖励上限;
			修改_额外奖励几率.Value = value.获得几率;
			修改_累计使用开关.Checked = value.is累计开关;
			修改_重置累计开关.Checked = value.is重置累计;
			修改_累计奖励列表.Rows.Clear();
			for (int i = 0; i < value.累计奖励列表.Count; i++)
			{
				修改_累计奖励列表.Rows.Add(value.累计奖励列表[i].最低累计, value.累计奖励列表[i].最高累计, value.累计奖励列表[i].奖励类型, value.累计奖励列表[i].奖励内容);
			}
			修改窗口.Visible = true;
		}
	}

	private void 确定修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		if (修改_确定按钮.Text == "新     增")
		{
			超级道具_新增事件();
		}
		else
		{
			if (!Singleton<全局变量类>.I.超级道具配置.超级道具列表.TryGetValue(修改_名字.Text, out 超级道具列表配置类 value))
			{
				return;
			}
			value.最多使用数量 = (int)修改_使用数量.Value;
			Enum.TryParse<AllEnums.数值Type>(修改_消耗类型.Text, out value.道具消耗类型);
			value.道具消耗内容 = 修改_消耗价格.Text;
			value.is等级开关 = 修改_限制等级开关.Checked;
			value.最低使用等级 = (int)修改_最低等级.Value;
			value.最高使用等级 = (int)修改_最高等级.Value;
			value.is道行开关 = 修改_限制道行开关.Checked;
			value.最低使用道行 = (int)修改_最低道行.Value;
			value.最高使用道行 = (int)修改_最高道行.Value;
			value.is称号开关 = 修改_限制称号开关.Checked;
			value.指定称号使用 = 修改_指定称号.Text;
			value.is奖励开关 = 修改_额外奖励开关.Checked;
			Enum.TryParse<AllEnums.数值Type>(修改_额外奖励类型.Text, out value.额外奖励类型);
			Enum.TryParse<AllEnums.属性名字Type>(修改_附加属性类型.Text, out value.附加属性类型);
			value.附加属性限时 = (int)修改_附加属性限时.Value;
			value.最低奖励下限 = (int)修改_额外奖励最低.Value;
			value.最高奖励上限 = (int)修改_额外奖励最高.Value;
			value.获得几率 = (int)修改_额外奖励几率.Value;
			value.is累计开关 = 修改_累计使用开关.Checked;
			value.is重置累计 = 修改_重置累计开关.Checked;
			value.累计奖励列表.Clear();
			for (int i = 0; i < 修改_累计奖励列表.Rows.Count; i++)
			{
				DataGridViewCellCollection cells = 修改_累计奖励列表.Rows[i].Cells;
				value.累计奖励列表.Add(new 超级道具累计奖励类
				{
					最低累计 = (int)cells["最低累计"].Value,
					最高累计 = (int)cells["最高累计"].Value,
					奖励类型 = Enum.Parse<AllEnums.数值Type>(cells["奖励类型"].Value.ToString()),
					奖励内容 = cells["奖励内容"].Value.ToString()
				});
			}
			修改窗口.Visible = false;
			if (超级道具_道具列表.CurrentRow == null)
			{
				return;
			}
			int index = 超级道具_道具列表.CurrentRow.Index;
			if (index < 0)
			{
				return;
			}
			DataGridViewCellCollection cells2 = 超级道具_道具列表.Rows[index].Cells;
			cells2["最多使用数量"].Value = value.最多使用数量;
			if (value.道具消耗类型 == AllEnums.数值Type.无)
			{
				cells2["使用消耗"].Value = "无";
			}
			else if (value.道具消耗类型 == AllEnums.数值Type.道具)
			{
				cells2["使用消耗"].Value = value.道具消耗内容 + "×1";
			}
			else
			{
				cells2["使用消耗"].Value = $"{value.道具消耗类型}×{value.道具消耗内容}";
			}
			cells2["使用等级"].Value = ((!value.is等级开关) ? "无" : $"{value.最低使用等级}-{value.最高使用等级}");
			cells2["使用道行"].Value = ((!value.is道行开关) ? "无" : $"{value.最低使用道行}-{value.最高使用道行}");
			cells2["使用称号"].Value = ((!value.is称号开关) ? "无" : value.指定称号使用);
			cells2["额外奖励"].Value = ((!value.is奖励开关) ? "无" : $"{value.额外奖励类型}×[{value.最低奖励下限}-{value.最高奖励上限}] {value.获得几率}%");
			if (!value.is累计开关 || value.累计奖励列表.Count <= 0)
			{
				cells2["累计使用奖励"].Value = "无";
			}
			else
			{
				for (int j = 0; j < value.累计奖励列表.Count; j++)
				{
					DataGridViewCell dataGridViewCell = cells2["累计使用奖励"];
					dataGridViewCell.Value = dataGridViewCell.Value?.ToString() + $"{((j != 0) ? "|" : string.Empty)}{value.累计奖励列表[j].最低累计}-{value.累计奖励列表[j].最高累计}：{((value.累计奖励列表[j].奖励类型 == AllEnums.数值Type.道具) ? (value.累计奖励列表[j].奖励内容 + "×1") : $"{value.累计奖励列表[j].奖励类型}×{value.累计奖励列表[j].奖励内容}")}";
					if (value.is重置累计 && j == 0)
					{
						break;
					}
				}
			}
			MessageBox.Show("[" + 修改_名字.Text + "]的配置已经修改，请及时点击保存配置按钮更新服务端配置！");
		}
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 超级道具_道具列表.CurrentRow == null)
		{
			return;
		}
		int index = 超级道具_道具列表.CurrentRow.Index;
		if (index >= 0)
		{
			string text = 超级道具_道具列表.Rows[index].Cells["道具名字"].Value.ToString();
			if (Singleton<全局变量类>.I.超级道具配置.超级道具列表.ContainsKey(text))
			{
				Singleton<全局变量类>.I.超级道具配置.超级道具列表.TryRemove(text, out 超级道具列表配置类 _);
				MessageBox.Show("[" + text + "]已从列表中删除，请及时点击保存配置按钮更新服务端配置！");
				超级道具_道具列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 累计_删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 修改_累计奖励列表.CurrentRow != null)
		{
			int index = 修改_累计奖励列表.CurrentRow.Index;
			if (index >= 0)
			{
				修改_累计奖励列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 15)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			超级道具_开关.Checked = Singleton<全局变量类>.I.超级道具配置.功能开关;
			超级道具_定制开关.Checked = Singleton<全局变量类>.I.超级道具配置.定制功能开关;
			超级道具_自动使用道具.Text = Singleton<全局变量类>.I.超级道具配置.自动使用道具;
			超级道具_禁止使用道具.Text = Singleton<全局变量类>.I.超级道具配置.禁止使用道具;
			超级道具_禁止交易道具.Text = Singleton<全局变量类>.I.超级道具配置.禁止交易道具;
			超级道具_禁止摆摊道具.Text = Singleton<全局变量类>.I.超级道具配置.禁止摆摊道具;
			超级道具_禁止拍卖道具.Text = Singleton<全局变量类>.I.超级道具配置.禁止拍卖道具;
			超级道具_禁止商会道具.Text = Singleton<全局变量类>.I.超级道具配置.禁止商会道具;
			超级道具_禁止丢弃道具.Text = Singleton<全局变量类>.I.超级道具配置.禁止丢弃道具;
			超级道具_使用校验道具.Text = Singleton<全局变量类>.I.超级道具配置.使用校验道具;
			超级道具_自动绑定道具.Text = Singleton<全局变量类>.I.超级道具配置.自动绑定道具;
			超级道具_道具列表.Rows.Clear();
			foreach (超级道具列表配置类 value in Singleton<全局变量类>.I.超级道具配置.超级道具列表.Values)
			{
				string text = "无";
				if (value.道具消耗类型 == AllEnums.数值Type.道具)
				{
					text = value.道具消耗内容 + "×1";
				}
				else if (value.道具消耗类型 != AllEnums.数值Type.无)
				{
					text = $"{value.道具消耗类型}×{value.道具消耗内容}";
				}
				string text2 = string.Empty;
				if (value.累计奖励列表 == null)
				{
					value.累计奖励列表 = new List<超级道具累计奖励类>();
				}
				if (value.is累计开关 && value.累计奖励列表.Count > 0)
				{
					for (int i = 0; i < value.累计奖励列表.Count; i++)
					{
						text2 += $"{((i != 0) ? "|" : string.Empty)}{value.累计奖励列表[i].最低累计}-{value.累计奖励列表[i].最高累计}：{((value.累计奖励列表[i].奖励类型 == AllEnums.数值Type.道具) ? (value.累计奖励列表[i].奖励内容 + "×1") : $"{value.累计奖励列表[i].奖励类型}×{value.累计奖励列表[i].奖励内容}")}";
						if (value.is重置累计 && i == 0)
						{
							break;
						}
					}
				}
				else
				{
					text2 = "无";
				}
				超级道具_道具列表.Rows.Add(value.道具唯一名字, value.最多使用数量, text, (!value.is等级开关) ? "无" : $"{value.最低使用等级}-{value.最高使用等级}", (!value.is道行开关) ? "无" : $"{value.最低使用道行}-{value.最高使用道行}", (!value.is称号开关) ? "无" : value.指定称号使用, (!value.is奖励开关) ? "无" : $"{value.额外奖励类型}×[{value.最低奖励下限}-{value.最高奖励上限}] {value.获得几率}%", text2);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.超级道具配置.功能开关 = 超级道具_开关.Checked;
			Singleton<全局变量类>.I.超级道具配置.定制功能开关 = 超级道具_定制开关.Checked;
			Singleton<全局变量类>.I.超级道具配置.自动使用道具 = 超级道具_自动使用道具.Text;
			Singleton<全局变量类>.I.超级道具配置.禁止使用道具 = 超级道具_禁止使用道具.Text;
			Singleton<全局变量类>.I.超级道具配置.禁止交易道具 = 超级道具_禁止交易道具.Text;
			Singleton<全局变量类>.I.超级道具配置.禁止摆摊道具 = 超级道具_禁止摆摊道具.Text;
			Singleton<全局变量类>.I.超级道具配置.禁止拍卖道具 = 超级道具_禁止拍卖道具.Text;
			Singleton<全局变量类>.I.超级道具配置.禁止商会道具 = 超级道具_禁止商会道具.Text;
			Singleton<全局变量类>.I.超级道具配置.禁止丢弃道具 = 超级道具_禁止丢弃道具.Text;
			Singleton<全局变量类>.I.超级道具配置.使用校验道具 = 超级道具_使用校验道具.Text;
			Singleton<全局变量类>.I.超级道具配置.自动绑定道具 = 超级道具_自动绑定道具.Text;
		}
	}

	private void 超级道具_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 15, JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级道具配置, Formatting.Indented));
		}
	}

	private void 超级道具_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 15);
		}
	}

	private void 超级道具_打开新增窗口按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			修改_名字.ReadOnly = false;
			修改_确定按钮.Text = "新     增";
			修改_名字.Text = string.Empty;
			修改窗口.Visible = true;
		}
	}

	private void 超级道具_新增事件()
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(修改_名字.Text))
		{
			MessageBox.Show("请输入要添加的超级道具！");
			return;
		}
		if (string.IsNullOrWhiteSpace(修改_消耗类型.Text))
		{
			MessageBox.Show("请选择【" + 修改_名字.Text + "】道具使用时要消耗的类型，没有请选择无！");
			return;
		}
		if (修改_消耗类型.Text != "无" && string.IsNullOrWhiteSpace(修改_消耗价格.Text))
		{
			MessageBox.Show("请选择【" + 修改_名字.Text + "】道具使用时要消耗的类型，没有请选择无！");
			return;
		}
		if (修改_限制称号开关.Checked && string.IsNullOrWhiteSpace(修改_指定称号.Text))
		{
			MessageBox.Show("请填写【" + 修改_名字.Text + "】道具使用时需要的称号，没有请不要勾选限制称号开关！");
			return;
		}
		if (修改_额外奖励开关.Checked && string.IsNullOrWhiteSpace(修改_额外奖励类型.Text))
		{
			MessageBox.Show("请选择【" + 修改_名字.Text + "】道具的额外奖励类型，没有请不要勾选额外奖励开关！");
			return;
		}
		if (修改_额外奖励开关.Checked && 全局变量类.Is中州论道 && string.IsNullOrWhiteSpace(修改_附加属性类型.Text))
		{
			MessageBox.Show("请选择【" + 修改_名字.Text + "】道具的定制属性类型，没有请不要勾选额外奖励开关！");
			return;
		}
		if (修改_累计使用开关.Checked && 修改_累计奖励列表.Rows.Count <= 0)
		{
			MessageBox.Show("请增加【" + 修改_名字.Text + "】道具的累计使用奖励，没有请不要勾选累计使用开关！");
			return;
		}
		if (Singleton<全局变量类>.I.超级道具配置.超级道具列表.ContainsKey(修改_名字.Text))
		{
			MessageBox.Show("列表中已经存在【" + 修改_名字.Text + "】，无法重复添加！");
			return;
		}
		超级道具列表配置类 超级道具列表配置类2 = new 超级道具列表配置类();
		超级道具列表配置类2.道具唯一名字 = 修改_名字.Text;
		超级道具列表配置类2.最多使用数量 = (int)修改_使用数量.Value;
		Enum.TryParse<AllEnums.数值Type>(修改_消耗类型.Text, out 超级道具列表配置类2.道具消耗类型);
		超级道具列表配置类2.道具消耗内容 = 修改_消耗价格.Text;
		超级道具列表配置类2.is等级开关 = 修改_限制等级开关.Checked;
		超级道具列表配置类2.最低使用等级 = (int)修改_最低等级.Value;
		超级道具列表配置类2.最高使用等级 = (int)修改_最高等级.Value;
		超级道具列表配置类2.is道行开关 = 修改_限制道行开关.Checked;
		超级道具列表配置类2.最低使用道行 = (int)修改_最低道行.Value;
		超级道具列表配置类2.最高使用道行 = (int)修改_最高道行.Value;
		超级道具列表配置类2.is称号开关 = 修改_限制称号开关.Checked;
		超级道具列表配置类2.指定称号使用 = 修改_指定称号.Text;
		超级道具列表配置类2.is奖励开关 = 修改_额外奖励开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(修改_额外奖励类型.Text, out 超级道具列表配置类2.额外奖励类型);
		Enum.TryParse<AllEnums.属性名字Type>(修改_附加属性类型.Text, out 超级道具列表配置类2.附加属性类型);
		超级道具列表配置类2.附加属性限时 = (int)修改_附加属性限时.Value;
		超级道具列表配置类2.最低奖励下限 = (int)修改_额外奖励最低.Value;
		超级道具列表配置类2.最高奖励上限 = (int)修改_额外奖励最高.Value;
		超级道具列表配置类2.获得几率 = (int)修改_额外奖励几率.Value;
		超级道具列表配置类2.is累计开关 = 修改_累计使用开关.Checked;
		超级道具列表配置类2.is重置累计 = 修改_重置累计开关.Checked;
		超级道具列表配置类2.累计奖励列表.Clear();
		for (int i = 0; i < 修改_累计奖励列表.Rows.Count; i++)
		{
			DataGridViewCellCollection cells = 修改_累计奖励列表.Rows[i].Cells;
			超级道具列表配置类2.累计奖励列表.Add(new 超级道具累计奖励类
			{
				最低累计 = (int)cells["最低累计"].Value,
				最高累计 = (int)cells["最高累计"].Value,
				奖励类型 = Enum.Parse<AllEnums.数值Type>(cells["奖励类型"].Value.ToString()),
				奖励内容 = cells["奖励内容"].Value.ToString()
			});
		}
		Singleton<全局变量类>.I.超级道具配置.超级道具列表.TryAdd(超级道具列表配置类2.道具唯一名字, 超级道具列表配置类2);
		修改窗口.Visible = false;
		string text = "无";
		if (超级道具列表配置类2.道具消耗类型 == AllEnums.数值Type.道具)
		{
			text = 超级道具列表配置类2.道具消耗内容 + "×1";
		}
		else if (超级道具列表配置类2.道具消耗类型 != AllEnums.数值Type.无)
		{
			text = $"{超级道具列表配置类2.道具消耗类型}×{超级道具列表配置类2.道具消耗内容}";
		}
		string text2 = "无";
		if (超级道具列表配置类2.is累计开关 && 超级道具列表配置类2.累计奖励列表.Count > 0)
		{
			for (int j = 0; j < 超级道具列表配置类2.累计奖励列表.Count; j++)
			{
				text2 += $"{((j != 0) ? "|" : string.Empty)}{超级道具列表配置类2.累计奖励列表[j].最低累计}-{超级道具列表配置类2.累计奖励列表[j].最高累计}：{((超级道具列表配置类2.累计奖励列表[j].奖励类型 == AllEnums.数值Type.道具) ? (超级道具列表配置类2.累计奖励列表[j].奖励内容 + "×1") : $"{超级道具列表配置类2.累计奖励列表[j].奖励类型}×{超级道具列表配置类2.累计奖励列表[j].奖励内容}")}";
				if (超级道具列表配置类2.is重置累计 && j == 0)
				{
					break;
				}
			}
		}
		超级道具_道具列表.Rows.Add(超级道具列表配置类2.道具唯一名字, 超级道具列表配置类2.最多使用数量, text, (!超级道具列表配置类2.is等级开关) ? "无" : $"{超级道具列表配置类2.最低使用等级}-{超级道具列表配置类2.最高使用等级}", (!超级道具列表配置类2.is道行开关) ? "无" : $"{超级道具列表配置类2.最低使用道行}-{超级道具列表配置类2.最高使用道行}", (!超级道具列表配置类2.is称号开关) ? "无" : 超级道具列表配置类2.指定称号使用, (!超级道具列表配置类2.is奖励开关) ? "无" : $"{超级道具列表配置类2.额外奖励类型}×[{超级道具列表配置类2.最低奖励下限}-{超级道具列表配置类2.最高奖励上限}] {超级道具列表配置类2.获得几率}%", text2);
		MessageBox.Show("[" + 修改_名字.Text + "]添加成功");
	}

	private void 修改_添加累计奖励按钮_Click(object sender, EventArgs e)
	{
		if (修改_重置累计开关.Checked && 修改_累计奖励列表.Rows.Count > 1)
		{
			MessageBox.Show("勾选了重置累计开关后只能有一条累计奖励数据生效。");
			return;
		}
		if (修改_最低累计数量.Value > 修改_最高累计数量.Value)
		{
			MessageBox.Show("当前累计阶段的最低累计数量不能大于最高累计数量。");
			return;
		}
		if (string.IsNullOrWhiteSpace(修改_当前累计奖励类型.Text))
		{
			MessageBox.Show("当前累计阶段的奖励类型不能为空。");
			return;
		}
		if (string.IsNullOrWhiteSpace(修改_当前累计奖励内容.Text))
		{
			MessageBox.Show("当前累计阶段的奖励内容不能为空。");
			return;
		}
		修改_累计奖励列表.Rows.Add(修改_最低累计数量.Value, 修改_最高累计数量.Value, 修改_当前累计奖励类型.Text, 修改_当前累计奖励内容.Text);
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
		this.components = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.超级道具配置窗口));
		this.超级道具_开关 = new System.Windows.Forms.CheckBox();
		this.超级道具_重载按钮 = new System.Windows.Forms.Button();
		this.超级道具_保存按钮 = new System.Windows.Forms.Button();
		this.label6 = new System.Windows.Forms.Label();
		this.超级道具_自动使用道具 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.超级道具_禁止使用道具 = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.超级道具_禁止摆摊道具 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.超级道具_禁止交易道具 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.超级道具_禁止商会道具 = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.超级道具_禁止拍卖道具 = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.超级道具_打开新增窗口按钮 = new System.Windows.Forms.Button();
		this.超级道具_道具列表 = new System.Windows.Forms.DataGridView();
		this.道具名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.最多使用数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.使用消耗 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.使用等级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.使用道行 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.使用称号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.额外奖励 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.累计使用奖励 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.修改窗口 = new System.Windows.Forms.Panel();
		this.label27 = new System.Windows.Forms.Label();
		this.修改_附加属性限时 = new System.Windows.Forms.NumericUpDown();
		this.label附加属性限时 = new System.Windows.Forms.Label();
		this.label附加属性类型 = new System.Windows.Forms.Label();
		this.修改_附加属性类型 = new System.Windows.Forms.ComboBox();
		this.label21 = new System.Windows.Forms.Label();
		this.修改_取消按钮 = new System.Windows.Forms.Button();
		this.修改_确定按钮 = new System.Windows.Forms.Button();
		this.修改_累计奖励列表 = new System.Windows.Forms.DataGridView();
		this.最低累计 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.最高累计 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.奖励类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.奖励内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.修改_添加累计奖励按钮 = new System.Windows.Forms.Button();
		this.修改_当前累计奖励内容 = new System.Windows.Forms.TextBox();
		this.修改_当前累计奖励类型 = new System.Windows.Forms.ComboBox();
		this.label20 = new System.Windows.Forms.Label();
		this.修改_最高累计数量 = new System.Windows.Forms.NumericUpDown();
		this.label19 = new System.Windows.Forms.Label();
		this.修改_最低累计数量 = new System.Windows.Forms.NumericUpDown();
		this.label18 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.修改_重置累计开关 = new System.Windows.Forms.CheckBox();
		this.修改_累计使用开关 = new System.Windows.Forms.CheckBox();
		this.修改_额外奖励几率 = new System.Windows.Forms.NumericUpDown();
		this.修改_额外奖励最高 = new System.Windows.Forms.NumericUpDown();
		this.label16 = new System.Windows.Forms.Label();
		this.修改_额外奖励最低 = new System.Windows.Forms.NumericUpDown();
		this.修改_额外奖励类型 = new System.Windows.Forms.ComboBox();
		this.label15 = new System.Windows.Forms.Label();
		this.修改_额外奖励开关 = new System.Windows.Forms.CheckBox();
		this.label14 = new System.Windows.Forms.Label();
		this.修改_指定称号 = new System.Windows.Forms.TextBox();
		this.修改_限制称号开关 = new System.Windows.Forms.CheckBox();
		this.修改_最高道行 = new System.Windows.Forms.NumericUpDown();
		this.label12 = new System.Windows.Forms.Label();
		this.修改_最低道行 = new System.Windows.Forms.NumericUpDown();
		this.修改_限制道行开关 = new System.Windows.Forms.CheckBox();
		this.修改_最高等级 = new System.Windows.Forms.NumericUpDown();
		this.label13 = new System.Windows.Forms.Label();
		this.修改_最低等级 = new System.Windows.Forms.NumericUpDown();
		this.修改_限制等级开关 = new System.Windows.Forms.CheckBox();
		this.修改_消耗价格 = new System.Windows.Forms.TextBox();
		this.修改_消耗类型 = new System.Windows.Forms.ComboBox();
		this.label11 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.修改_使用数量 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.修改_名字 = new System.Windows.Forms.TextBox();
		this.label22 = new System.Windows.Forms.Label();
		this.超级道具_禁止丢弃道具 = new System.Windows.Forms.TextBox();
		this.label23 = new System.Windows.Forms.Label();
		this.超级道具_使用校验道具 = new System.Windows.Forms.TextBox();
		this.超级道具_提示组件 = new System.Windows.Forms.ToolTip(this.components);
		this.超级道具_定制开关 = new System.Windows.Forms.CheckBox();
		this.label24 = new System.Windows.Forms.Label();
		this.超级道具_自动绑定道具 = new System.Windows.Forms.TextBox();
		((System.ComponentModel.ISupportInitialize)this.超级道具_道具列表).BeginInit();
		this.修改窗口.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_附加属性限时).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_累计奖励列表).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高累计数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低累计数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_额外奖励几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_额外奖励最高).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_额外奖励最低).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高道行).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低道行).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_使用数量).BeginInit();
		base.SuspendLayout();
		this.超级道具_开关.AutoSize = true;
		this.超级道具_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级道具_开关.Location = new System.Drawing.Point(12, 12);
		this.超级道具_开关.Name = "超级道具_开关";
		this.超级道具_开关.Size = new System.Drawing.Size(106, 23);
		this.超级道具_开关.TabIndex = 84;
		this.超级道具_开关.Text = "超级道具开关";
		this.超级道具_开关.UseVisualStyleBackColor = true;
		this.超级道具_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级道具_重载按钮.Location = new System.Drawing.Point(376, 8);
		this.超级道具_重载按钮.Name = "超级道具_重载按钮";
		this.超级道具_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.超级道具_重载按钮.TabIndex = 86;
		this.超级道具_重载按钮.Text = "重载配置";
		this.超级道具_重载按钮.UseVisualStyleBackColor = true;
		this.超级道具_重载按钮.Click += new System.EventHandler(超级道具_重载按钮_Click);
		this.超级道具_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级道具_保存按钮.Location = new System.Drawing.Point(270, 8);
		this.超级道具_保存按钮.Name = "超级道具_保存按钮";
		this.超级道具_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.超级道具_保存按钮.TabIndex = 85;
		this.超级道具_保存按钮.Text = "保存配置";
		this.超级道具_保存按钮.UseVisualStyleBackColor = true;
		this.超级道具_保存按钮.Click += new System.EventHandler(超级道具_保存按钮_Click);
		this.label6.Location = new System.Drawing.Point(9, 48);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(80, 23);
		this.label6.TabIndex = 87;
		this.label6.Text = "自动使用道具";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.超级道具_自动使用道具.Location = new System.Drawing.Point(90, 48);
		this.超级道具_自动使用道具.Name = "超级道具_自动使用道具";
		this.超级道具_自动使用道具.Size = new System.Drawing.Size(300, 23);
		this.超级道具_自动使用道具.TabIndex = 88;
		this.label1.Location = new System.Drawing.Point(396, 48);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(80, 23);
		this.label1.TabIndex = 89;
		this.label1.Text = "禁止使用道具";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.超级道具_禁止使用道具.Location = new System.Drawing.Point(477, 48);
		this.超级道具_禁止使用道具.Name = "超级道具_禁止使用道具";
		this.超级道具_禁止使用道具.Size = new System.Drawing.Size(300, 23);
		this.超级道具_禁止使用道具.TabIndex = 90;
		this.label2.Location = new System.Drawing.Point(396, 76);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(80, 23);
		this.label2.TabIndex = 93;
		this.label2.Text = "禁止摆摊道具";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.超级道具_禁止摆摊道具.Location = new System.Drawing.Point(477, 76);
		this.超级道具_禁止摆摊道具.Name = "超级道具_禁止摆摊道具";
		this.超级道具_禁止摆摊道具.Size = new System.Drawing.Size(300, 23);
		this.超级道具_禁止摆摊道具.TabIndex = 94;
		this.label3.Location = new System.Drawing.Point(9, 76);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(80, 23);
		this.label3.TabIndex = 91;
		this.label3.Text = "禁止交易道具";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.超级道具_禁止交易道具.Location = new System.Drawing.Point(90, 76);
		this.超级道具_禁止交易道具.Name = "超级道具_禁止交易道具";
		this.超级道具_禁止交易道具.Size = new System.Drawing.Size(300, 23);
		this.超级道具_禁止交易道具.TabIndex = 92;
		this.label4.Location = new System.Drawing.Point(396, 104);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(80, 23);
		this.label4.TabIndex = 97;
		this.label4.Text = "禁止商会道具";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.超级道具_禁止商会道具.Location = new System.Drawing.Point(477, 104);
		this.超级道具_禁止商会道具.Name = "超级道具_禁止商会道具";
		this.超级道具_禁止商会道具.Size = new System.Drawing.Size(300, 23);
		this.超级道具_禁止商会道具.TabIndex = 98;
		this.label5.Location = new System.Drawing.Point(9, 104);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(80, 23);
		this.label5.TabIndex = 95;
		this.label5.Text = "禁止拍卖道具";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.超级道具_禁止拍卖道具.Location = new System.Drawing.Point(90, 104);
		this.超级道具_禁止拍卖道具.Name = "超级道具_禁止拍卖道具";
		this.超级道具_禁止拍卖道具.Size = new System.Drawing.Size(300, 23);
		this.超级道具_禁止拍卖道具.TabIndex = 96;
		this.label7.ForeColor = System.Drawing.Color.Red;
		this.label7.Location = new System.Drawing.Point(501, 12);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(271, 23);
		this.label7.TabIndex = 99;
		this.label7.Text = "配置格式：|飞行符|八卦炉|修为丹|血玲珑|";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.超级道具_打开新增窗口按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级道具_打开新增窗口按钮.Location = new System.Drawing.Point(627, 196);
		this.超级道具_打开新增窗口按钮.Name = "超级道具_打开新增窗口按钮";
		this.超级道具_打开新增窗口按钮.Size = new System.Drawing.Size(150, 30);
		this.超级道具_打开新增窗口按钮.TabIndex = 100;
		this.超级道具_打开新增窗口按钮.Text = "点击新增超级道具";
		this.超级道具_打开新增窗口按钮.UseVisualStyleBackColor = true;
		this.超级道具_打开新增窗口按钮.Click += new System.EventHandler(超级道具_打开新增窗口按钮_Click);
		this.超级道具_道具列表.AllowUserToAddRows = false;
		this.超级道具_道具列表.AllowUserToDeleteRows = false;
		this.超级道具_道具列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.超级道具_道具列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.超级道具_道具列表.BackgroundColor = System.Drawing.Color.White;
		this.超级道具_道具列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.超级道具_道具列表.Columns.AddRange(this.道具名字, this.最多使用数量, this.使用消耗, this.使用等级, this.使用道行, this.使用称号, this.额外奖励, this.累计使用奖励);
		this.超级道具_道具列表.Location = new System.Drawing.Point(9, 233);
		this.超级道具_道具列表.MultiSelect = false;
		this.超级道具_道具列表.Name = "超级道具_道具列表";
		this.超级道具_道具列表.ReadOnly = true;
		this.超级道具_道具列表.RowHeadersVisible = false;
		this.超级道具_道具列表.RowTemplate.Height = 25;
		this.超级道具_道具列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.超级道具_道具列表.Size = new System.Drawing.Size(768, 316);
		this.超级道具_道具列表.TabIndex = 101;
		this.道具名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.道具名字.HeaderText = "道具名字";
		this.道具名字.MinimumWidth = 90;
		this.道具名字.Name = "道具名字";
		this.道具名字.ReadOnly = true;
		this.道具名字.Width = 90;
		this.最多使用数量.HeaderText = "最多使用数量";
		this.最多使用数量.MinimumWidth = 120;
		this.最多使用数量.Name = "最多使用数量";
		this.最多使用数量.ReadOnly = true;
		this.最多使用数量.Width = 120;
		this.使用消耗.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.使用消耗.HeaderText = "使用消耗";
		this.使用消耗.MinimumWidth = 90;
		this.使用消耗.Name = "使用消耗";
		this.使用消耗.ReadOnly = true;
		this.使用消耗.Width = 90;
		this.使用等级.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.使用等级.HeaderText = "使用等级";
		this.使用等级.MinimumWidth = 90;
		this.使用等级.Name = "使用等级";
		this.使用等级.ReadOnly = true;
		this.使用等级.Width = 90;
		this.使用道行.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.使用道行.HeaderText = "使用道行";
		this.使用道行.MinimumWidth = 90;
		this.使用道行.Name = "使用道行";
		this.使用道行.ReadOnly = true;
		this.使用道行.Width = 90;
		this.使用称号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.使用称号.HeaderText = "使用称号";
		this.使用称号.MinimumWidth = 90;
		this.使用称号.Name = "使用称号";
		this.使用称号.ReadOnly = true;
		this.使用称号.Width = 90;
		this.额外奖励.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.额外奖励.HeaderText = "额外奖励";
		this.额外奖励.MinimumWidth = 90;
		this.额外奖励.Name = "额外奖励";
		this.额外奖励.ReadOnly = true;
		this.额外奖励.Width = 90;
		this.累计使用奖励.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.累计使用奖励.HeaderText = "累计使用奖励";
		this.累计使用奖励.MinimumWidth = 120;
		this.累计使用奖励.Name = "累计使用奖励";
		this.累计使用奖励.ReadOnly = true;
		this.累计使用奖励.Width = 120;
		this.修改窗口.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
		this.修改窗口.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.修改窗口.Controls.Add(this.label27);
		this.修改窗口.Controls.Add(this.修改_附加属性限时);
		this.修改窗口.Controls.Add(this.label附加属性限时);
		this.修改窗口.Controls.Add(this.label附加属性类型);
		this.修改窗口.Controls.Add(this.修改_附加属性类型);
		this.修改窗口.Controls.Add(this.label21);
		this.修改窗口.Controls.Add(this.修改_取消按钮);
		this.修改窗口.Controls.Add(this.修改_确定按钮);
		this.修改窗口.Controls.Add(this.修改_累计奖励列表);
		this.修改窗口.Controls.Add(this.修改_添加累计奖励按钮);
		this.修改窗口.Controls.Add(this.修改_当前累计奖励内容);
		this.修改窗口.Controls.Add(this.修改_当前累计奖励类型);
		this.修改窗口.Controls.Add(this.label20);
		this.修改窗口.Controls.Add(this.修改_最高累计数量);
		this.修改窗口.Controls.Add(this.label19);
		this.修改窗口.Controls.Add(this.修改_最低累计数量);
		this.修改窗口.Controls.Add(this.label18);
		this.修改窗口.Controls.Add(this.label17);
		this.修改窗口.Controls.Add(this.修改_重置累计开关);
		this.修改窗口.Controls.Add(this.修改_累计使用开关);
		this.修改窗口.Controls.Add(this.修改_额外奖励几率);
		this.修改窗口.Controls.Add(this.修改_额外奖励最高);
		this.修改窗口.Controls.Add(this.label16);
		this.修改窗口.Controls.Add(this.修改_额外奖励最低);
		this.修改窗口.Controls.Add(this.修改_额外奖励类型);
		this.修改窗口.Controls.Add(this.label15);
		this.修改窗口.Controls.Add(this.修改_额外奖励开关);
		this.修改窗口.Controls.Add(this.label14);
		this.修改窗口.Controls.Add(this.修改_指定称号);
		this.修改窗口.Controls.Add(this.修改_限制称号开关);
		this.修改窗口.Controls.Add(this.修改_最高道行);
		this.修改窗口.Controls.Add(this.label12);
		this.修改窗口.Controls.Add(this.修改_最低道行);
		this.修改窗口.Controls.Add(this.修改_限制道行开关);
		this.修改窗口.Controls.Add(this.修改_最高等级);
		this.修改窗口.Controls.Add(this.label13);
		this.修改窗口.Controls.Add(this.修改_最低等级);
		this.修改窗口.Controls.Add(this.修改_限制等级开关);
		this.修改窗口.Controls.Add(this.修改_消耗价格);
		this.修改窗口.Controls.Add(this.修改_消耗类型);
		this.修改窗口.Controls.Add(this.label11);
		this.修改窗口.Controls.Add(this.label10);
		this.修改窗口.Controls.Add(this.修改_使用数量);
		this.修改窗口.Controls.Add(this.label9);
		this.修改窗口.Controls.Add(this.label8);
		this.修改窗口.Controls.Add(this.修改_名字);
		this.修改窗口.Location = new System.Drawing.Point(127, 43);
		this.修改窗口.Name = "修改窗口";
		this.修改窗口.Size = new System.Drawing.Size(535, 552);
		this.修改窗口.TabIndex = 102;
		this.label27.BackColor = System.Drawing.Color.Transparent;
		this.label27.Location = new System.Drawing.Point(481, 193);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(32, 23);
		this.label27.TabIndex = 152;
		this.label27.Text = "分钟";
		this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_附加属性限时.Location = new System.Drawing.Point(409, 193);
		this.修改_附加属性限时.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_附加属性限时.Name = "修改_附加属性限时";
		this.修改_附加属性限时.Size = new System.Drawing.Size(71, 23);
		this.修改_附加属性限时.TabIndex = 151;
		this.label附加属性限时.BackColor = System.Drawing.Color.Transparent;
		this.label附加属性限时.Location = new System.Drawing.Point(318, 192);
		this.label附加属性限时.Name = "label附加属性限时";
		this.label附加属性限时.Size = new System.Drawing.Size(85, 23);
		this.label附加属性限时.TabIndex = 150;
		this.label附加属性限时.Text = "附加属性限时";
		this.label附加属性限时.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label附加属性类型.BackColor = System.Drawing.Color.Transparent;
		this.label附加属性类型.Location = new System.Drawing.Point(318, 163);
		this.label附加属性类型.Name = "label附加属性类型";
		this.label附加属性类型.Size = new System.Drawing.Size(85, 23);
		this.label附加属性类型.TabIndex = 149;
		this.label附加属性类型.Text = "附加属性类型";
		this.label附加属性类型.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_附加属性类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.修改_附加属性类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.修改_附加属性类型.FormattingEnabled = true;
		this.修改_附加属性类型.Items.AddRange(new object[81]
		{
			"无", "气血", "法力", "物理伤害", "法术伤害", "防御", "速度", "所有相性", "金相性", "木相性",
			"水相性", "火相性", "土相性", "所有属性", "体质", "力量", "灵力", "敏捷", "准确", "闪避",
			"所有抗性", "金抗性", "木抗性", "水抗性", "火抗性", "土抗性", "忽视所有抗性", "忽视目标抗金", "忽视目标抗木", "忽视目标抗水",
			"忽视目标抗火", "忽视目标抗土", "抗所有异常", "抗遗忘", "抗中毒", "抗冰冻", "抗昏睡", "抗混乱", "抗镇魂", "抗化功",
			"抗水牢", "抗锁灵", "抗迷心", "忽视所有抗异常", "忽视目标抗遗忘", "忽视目标抗中毒", "忽视目标抗冰冻", "忽视目标抗昏睡", "忽视目标抗混乱", "忽视目标抗镇魂",
			"忽视目标抗化功", "忽视目标抗水牢", "忽视目标抗锁灵", "忽视目标抗迷心", "破防", "破防率", "连击", "连击率", "反击", "反击率",
			"反震度", "反震率", "物理必杀率", "法术必杀率", "所有技能上升", "强金法伤害", "强木法伤害", "强水法伤害", "强火法伤害", "强土法伤害",
			"强物理伤害", "强力遗忘", "强力中毒", "强力昏睡", "强力冰冻", "强力混乱", "强力镇魂", "强力化功", "强力水牢", "强力锁灵",
			"强力迷心"
		});
		this.修改_附加属性类型.Location = new System.Drawing.Point(409, 161);
		this.修改_附加属性类型.Name = "修改_附加属性类型";
		this.修改_附加属性类型.Size = new System.Drawing.Size(99, 25);
		this.修改_附加属性类型.TabIndex = 148;
		this.label21.BackColor = System.Drawing.Color.Transparent;
		this.label21.Font = new System.Drawing.Font("Microsoft YaHei UI", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label21.ForeColor = System.Drawing.Color.Red;
		this.label21.Location = new System.Drawing.Point(329, 35);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(146, 41);
		this.label21.TabIndex = 147;
		this.label21.Text = "如果是道具类\r\n直接写道具名字";
		this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_取消按钮.Location = new System.Drawing.Point(266, 511);
		this.修改_取消按钮.Name = "修改_取消按钮";
		this.修改_取消按钮.Size = new System.Drawing.Size(100, 30);
		this.修改_取消按钮.TabIndex = 146;
		this.修改_取消按钮.Text = "取    消";
		this.修改_取消按钮.UseVisualStyleBackColor = true;
		this.修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_确定按钮.Location = new System.Drawing.Point(149, 511);
		this.修改_确定按钮.Name = "修改_确定按钮";
		this.修改_确定按钮.Size = new System.Drawing.Size(100, 30);
		this.修改_确定按钮.TabIndex = 145;
		this.修改_确定按钮.Text = "修     改";
		this.修改_确定按钮.UseVisualStyleBackColor = true;
		this.修改_累计奖励列表.AllowUserToAddRows = false;
		this.修改_累计奖励列表.AllowUserToDeleteRows = false;
		this.修改_累计奖励列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.修改_累计奖励列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
		this.修改_累计奖励列表.BackgroundColor = System.Drawing.Color.White;
		this.修改_累计奖励列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.修改_累计奖励列表.Columns.AddRange(this.最低累计, this.最高累计, this.奖励类型, this.奖励内容);
		this.修改_累计奖励列表.Location = new System.Drawing.Point(22, 278);
		this.修改_累计奖励列表.MultiSelect = false;
		this.修改_累计奖励列表.Name = "修改_累计奖励列表";
		this.修改_累计奖励列表.ReadOnly = true;
		this.修改_累计奖励列表.RowHeadersVisible = false;
		this.修改_累计奖励列表.RowTemplate.Height = 25;
		this.修改_累计奖励列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.修改_累计奖励列表.Size = new System.Drawing.Size(486, 218);
		this.修改_累计奖励列表.TabIndex = 144;
		this.最低累计.HeaderText = "最低累计";
		this.最低累计.MinimumWidth = 80;
		this.最低累计.Name = "最低累计";
		this.最低累计.ReadOnly = true;
		this.最低累计.Width = 80;
		this.最高累计.HeaderText = "最高累计";
		this.最高累计.MinimumWidth = 80;
		this.最高累计.Name = "最高累计";
		this.最高累计.ReadOnly = true;
		this.最高累计.Width = 80;
		this.奖励类型.HeaderText = "奖励类型";
		this.奖励类型.MinimumWidth = 80;
		this.奖励类型.Name = "奖励类型";
		this.奖励类型.ReadOnly = true;
		this.奖励类型.Width = 80;
		this.奖励内容.HeaderText = "奖励内容";
		this.奖励内容.MinimumWidth = 180;
		this.奖励内容.Name = "奖励内容";
		this.奖励内容.ReadOnly = true;
		this.奖励内容.Width = 180;
		this.修改_添加累计奖励按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.修改_添加累计奖励按钮.Location = new System.Drawing.Point(404, 252);
		this.修改_添加累计奖励按钮.Name = "修改_添加累计奖励按钮";
		this.修改_添加累计奖励按钮.Size = new System.Drawing.Size(50, 23);
		this.修改_添加累计奖励按钮.TabIndex = 143;
		this.修改_添加累计奖励按钮.Text = "添加";
		this.修改_添加累计奖励按钮.UseVisualStyleBackColor = true;
		this.修改_添加累计奖励按钮.Click += new System.EventHandler(修改_添加累计奖励按钮_Click);
		this.修改_当前累计奖励内容.Location = new System.Drawing.Point(331, 252);
		this.修改_当前累计奖励内容.Name = "修改_当前累计奖励内容";
		this.修改_当前累计奖励内容.Size = new System.Drawing.Size(70, 23);
		this.修改_当前累计奖励内容.TabIndex = 142;
		this.修改_当前累计奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.修改_当前累计奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.修改_当前累计奖励类型.FormattingEnabled = true;
		this.修改_当前累计奖励类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "道具" });
		this.修改_当前累计奖励类型.Location = new System.Drawing.Point(269, 251);
		this.修改_当前累计奖励类型.Name = "修改_当前累计奖励类型";
		this.修改_当前累计奖励类型.Size = new System.Drawing.Size(60, 25);
		this.修改_当前累计奖励类型.TabIndex = 141;
		this.label20.BackColor = System.Drawing.Color.Transparent;
		this.label20.Location = new System.Drawing.Point(231, 252);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(40, 23);
		this.label20.TabIndex = 140;
		this.label20.Text = "奖励";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_最高累计数量.Location = new System.Drawing.Point(157, 252);
		this.修改_最高累计数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最高累计数量.Name = "修改_最高累计数量";
		this.修改_最高累计数量.Size = new System.Drawing.Size(50, 23);
		this.修改_最高累计数量.TabIndex = 139;
		this.label19.BackColor = System.Drawing.Color.Transparent;
		this.label19.Location = new System.Drawing.Point(134, 252);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(95, 23);
		this.label19.TabIndex = 138;
		this.label19.Text = "—               个";
		this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_最低累计数量.Location = new System.Drawing.Point(83, 252);
		this.修改_最低累计数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最低累计数量.Name = "修改_最低累计数量";
		this.修改_最低累计数量.Size = new System.Drawing.Size(50, 23);
		this.修改_最低累计数量.TabIndex = 137;
		this.label18.Location = new System.Drawing.Point(22, 251);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(60, 23);
		this.label18.TabIndex = 136;
		this.label18.Text = "累计数量";
		this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label17.ForeColor = System.Drawing.Color.Red;
		this.label17.Location = new System.Drawing.Point(242, 225);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(234, 23);
		this.label17.TabIndex = 135;
		this.label17.Text = "(勾选后只有第一层累计生效)";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_重置累计开关.AutoSize = true;
		this.修改_重置累计开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_重置累计开关.Location = new System.Drawing.Point(136, 225);
		this.修改_重置累计开关.Name = "修改_重置累计开关";
		this.修改_重置累计开关.Size = new System.Drawing.Size(106, 23);
		this.修改_重置累计开关.TabIndex = 134;
		this.修改_重置累计开关.Text = "自动重置累计";
		this.修改_重置累计开关.UseVisualStyleBackColor = true;
		this.修改_累计使用开关.AutoSize = true;
		this.修改_累计使用开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_累计使用开关.Location = new System.Drawing.Point(22, 225);
		this.修改_累计使用开关.Name = "修改_累计使用开关";
		this.修改_累计使用开关.Size = new System.Drawing.Size(106, 23);
		this.修改_累计使用开关.TabIndex = 133;
		this.修改_累计使用开关.Text = "累计使用开关";
		this.修改_累计使用开关.UseVisualStyleBackColor = true;
		this.修改_额外奖励几率.Location = new System.Drawing.Point(233, 192);
		this.修改_额外奖励几率.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_额外奖励几率.Name = "修改_额外奖励几率";
		this.修改_额外奖励几率.Size = new System.Drawing.Size(60, 23);
		this.修改_额外奖励几率.TabIndex = 132;
		this.修改_额外奖励最高.Location = new System.Drawing.Point(119, 192);
		this.修改_额外奖励最高.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_额外奖励最高.Name = "修改_额外奖励最高";
		this.修改_额外奖励最高.Size = new System.Drawing.Size(80, 23);
		this.修改_额外奖励最高.TabIndex = 131;
		this.label16.BackColor = System.Drawing.Color.Transparent;
		this.label16.Location = new System.Drawing.Point(100, 192);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(217, 23);
		this.label16.TabIndex = 130;
		this.label16.Text = "—                      几率                 %";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_额外奖励最低.Location = new System.Drawing.Point(22, 192);
		this.修改_额外奖励最低.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_额外奖励最低.Name = "修改_额外奖励最低";
		this.修改_额外奖励最低.Size = new System.Drawing.Size(80, 23);
		this.修改_额外奖励最低.TabIndex = 129;
		this.修改_额外奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.修改_额外奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.修改_额外奖励类型.FormattingEnabled = true;
		this.修改_额外奖励类型.Items.AddRange(new object[8] { "无", "金元宝", "银元宝", "体力", "累充点", "南极点", "奇宝点", "论道点" });
		this.修改_额外奖励类型.Location = new System.Drawing.Point(214, 162);
		this.修改_额外奖励类型.Name = "修改_额外奖励类型";
		this.修改_额外奖励类型.Size = new System.Drawing.Size(80, 25);
		this.修改_额外奖励类型.TabIndex = 128;
		this.label15.BackColor = System.Drawing.Color.Transparent;
		this.label15.Location = new System.Drawing.Point(133, 163);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(80, 23);
		this.label15.TabIndex = 127;
		this.label15.Text = "使用奖励类型";
		this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_额外奖励开关.AutoSize = true;
		this.修改_额外奖励开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_额外奖励开关.Location = new System.Drawing.Point(22, 163);
		this.修改_额外奖励开关.Name = "修改_额外奖励开关";
		this.修改_额外奖励开关.Size = new System.Drawing.Size(106, 23);
		this.修改_额外奖励开关.TabIndex = 126;
		this.修改_额外奖励开关.Text = "使用奖励开关";
		this.修改_额外奖励开关.UseVisualStyleBackColor = true;
		this.label14.Location = new System.Drawing.Point(133, 130);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(80, 23);
		this.label14.TabIndex = 124;
		this.label14.Text = "使用指定称号";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_指定称号.Location = new System.Drawing.Point(214, 130);
		this.修改_指定称号.Name = "修改_指定称号";
		this.修改_指定称号.Size = new System.Drawing.Size(153, 23);
		this.修改_指定称号.TabIndex = 125;
		this.修改_限制称号开关.AutoSize = true;
		this.修改_限制称号开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_限制称号开关.Location = new System.Drawing.Point(22, 130);
		this.修改_限制称号开关.Name = "修改_限制称号开关";
		this.修改_限制称号开关.Size = new System.Drawing.Size(106, 23);
		this.修改_限制称号开关.TabIndex = 123;
		this.修改_限制称号开关.Text = "限制称号开关";
		this.修改_限制称号开关.UseVisualStyleBackColor = true;
		this.修改_最高道行.Location = new System.Drawing.Point(220, 101);
		this.修改_最高道行.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最高道行.Name = "修改_最高道行";
		this.修改_最高道行.Size = new System.Drawing.Size(60, 23);
		this.修改_最高道行.TabIndex = 122;
		this.label12.BackColor = System.Drawing.Color.Transparent;
		this.label12.Location = new System.Drawing.Point(197, 101);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(110, 23);
		this.label12.TabIndex = 121;
		this.label12.Text = "—                  年";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_最低道行.Location = new System.Drawing.Point(134, 101);
		this.修改_最低道行.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最低道行.Name = "修改_最低道行";
		this.修改_最低道行.Size = new System.Drawing.Size(60, 23);
		this.修改_最低道行.TabIndex = 120;
		this.修改_限制道行开关.AutoSize = true;
		this.修改_限制道行开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_限制道行开关.Location = new System.Drawing.Point(22, 101);
		this.修改_限制道行开关.Name = "修改_限制道行开关";
		this.修改_限制道行开关.Size = new System.Drawing.Size(106, 23);
		this.修改_限制道行开关.TabIndex = 119;
		this.修改_限制道行开关.Text = "限制道行开关";
		this.修改_限制道行开关.UseVisualStyleBackColor = true;
		this.修改_最高等级.Location = new System.Drawing.Point(220, 72);
		this.修改_最高等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最高等级.Name = "修改_最高等级";
		this.修改_最高等级.Size = new System.Drawing.Size(60, 23);
		this.修改_最高等级.TabIndex = 118;
		this.label13.BackColor = System.Drawing.Color.Transparent;
		this.label13.Location = new System.Drawing.Point(197, 72);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(110, 23);
		this.label13.TabIndex = 117;
		this.label13.Text = "—                  级";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_最低等级.Location = new System.Drawing.Point(134, 72);
		this.修改_最低等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最低等级.Name = "修改_最低等级";
		this.修改_最低等级.Size = new System.Drawing.Size(60, 23);
		this.修改_最低等级.TabIndex = 116;
		this.修改_限制等级开关.AutoSize = true;
		this.修改_限制等级开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_限制等级开关.Location = new System.Drawing.Point(22, 72);
		this.修改_限制等级开关.Name = "修改_限制等级开关";
		this.修改_限制等级开关.Size = new System.Drawing.Size(106, 23);
		this.修改_限制等级开关.TabIndex = 115;
		this.修改_限制等级开关.Text = "限制等级开关";
		this.修改_限制等级开关.UseVisualStyleBackColor = true;
		this.修改_消耗价格.Location = new System.Drawing.Point(229, 43);
		this.修改_消耗价格.Name = "修改_消耗价格";
		this.修改_消耗价格.Size = new System.Drawing.Size(100, 23);
		this.修改_消耗价格.TabIndex = 113;
		this.修改_消耗价格.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.修改_消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.修改_消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.修改_消耗类型.FormattingEnabled = true;
		this.修改_消耗类型.Items.AddRange(new object[14]
		{
			"无", "金元宝", "银元宝", "金钱", "声望", "战绩", "经验", "等级", "道行", "体力",
			"累充点", "南极点", "灵气值", "道具"
		});
		this.修改_消耗类型.Location = new System.Drawing.Point(103, 42);
		this.修改_消耗类型.Name = "修改_消耗类型";
		this.修改_消耗类型.Size = new System.Drawing.Size(120, 25);
		this.修改_消耗类型.TabIndex = 112;
		this.label11.BackColor = System.Drawing.Color.Transparent;
		this.label11.Location = new System.Drawing.Point(22, 43);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(80, 23);
		this.label11.TabIndex = 111;
		this.label11.Text = "使用消耗类型";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label10.BackColor = System.Drawing.Color.Transparent;
		this.label10.ForeColor = System.Drawing.Color.Red;
		this.label10.Location = new System.Drawing.Point(373, 12);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(102, 23);
		this.label10.TabIndex = 104;
		this.label10.Text = "写-1=不限制使用";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_使用数量.Location = new System.Drawing.Point(314, 13);
		this.修改_使用数量.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
		this.修改_使用数量.Minimum = new decimal(new int[4] { 1, 0, 0, -2147483648 });
		this.修改_使用数量.Name = "修改_使用数量";
		this.修改_使用数量.Size = new System.Drawing.Size(53, 23);
		this.修改_使用数量.TabIndex = 103;
		this.修改_使用数量.Value = new decimal(new int[4] { 1, 0, 0, -2147483648 });
		this.label9.BackColor = System.Drawing.Color.Transparent;
		this.label9.Location = new System.Drawing.Point(233, 13);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(80, 23);
		this.label9.TabIndex = 102;
		this.label9.Text = "最多使用数量";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label8.Location = new System.Drawing.Point(22, 13);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(80, 23);
		this.label8.TabIndex = 89;
		this.label8.Text = "当前道具名字";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_名字.Location = new System.Drawing.Point(103, 13);
		this.修改_名字.Name = "修改_名字";
		this.修改_名字.Size = new System.Drawing.Size(120, 23);
		this.修改_名字.TabIndex = 90;
		this.label22.Location = new System.Drawing.Point(9, 134);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(80, 23);
		this.label22.TabIndex = 103;
		this.label22.Text = "禁止丢弃道具";
		this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.超级道具_禁止丢弃道具.Location = new System.Drawing.Point(90, 134);
		this.超级道具_禁止丢弃道具.Name = "超级道具_禁止丢弃道具";
		this.超级道具_禁止丢弃道具.Size = new System.Drawing.Size(687, 23);
		this.超级道具_禁止丢弃道具.TabIndex = 104;
		this.label23.Location = new System.Drawing.Point(9, 165);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(80, 23);
		this.label23.TabIndex = 105;
		this.label23.Text = "使用校验道具";
		this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.超级道具_使用校验道具.Location = new System.Drawing.Point(90, 165);
		this.超级道具_使用校验道具.Name = "超级道具_使用校验道具";
		this.超级道具_使用校验道具.Size = new System.Drawing.Size(687, 23);
		this.超级道具_使用校验道具.TabIndex = 106;
		this.超级道具_定制开关.AutoSize = true;
		this.超级道具_定制开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级道具_定制开关.Location = new System.Drawing.Point(127, 12);
		this.超级道具_定制开关.Name = "超级道具_定制开关";
		this.超级道具_定制开关.Size = new System.Drawing.Size(132, 23);
		this.超级道具_定制开关.TabIndex = 109;
		this.超级道具_定制开关.Text = "定制超级道具开关";
		this.超级道具_提示组件.SetToolTip(this.超级道具_定制开关, "定制道具开启后，该功能开启需要注意事项如下：\r\n1、版本中必须不能出现可主动获得的御天梭等飞行器\r\n2、开通了这个功能后新增道具会出现附加属性类型(定制道具独有)\r\n3、建议新服使用该功能，没有历史存档数据更安全\r\n");
		this.超级道具_定制开关.UseVisualStyleBackColor = true;
		this.label24.Location = new System.Drawing.Point(9, 196);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(80, 23);
		this.label24.TabIndex = 107;
		this.label24.Text = "自动死绑道具";
		this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.超级道具_自动绑定道具.Location = new System.Drawing.Point(90, 196);
		this.超级道具_自动绑定道具.Name = "超级道具_自动绑定道具";
		this.超级道具_自动绑定道具.Size = new System.Drawing.Size(300, 23);
		this.超级道具_自动绑定道具.TabIndex = 108;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(784, 597);
		base.Controls.Add(this.超级道具_定制开关);
		base.Controls.Add(this.修改窗口);
		base.Controls.Add(this.label24);
		base.Controls.Add(this.超级道具_自动绑定道具);
		base.Controls.Add(this.label23);
		base.Controls.Add(this.超级道具_使用校验道具);
		base.Controls.Add(this.label22);
		base.Controls.Add(this.超级道具_禁止丢弃道具);
		base.Controls.Add(this.超级道具_道具列表);
		base.Controls.Add(this.超级道具_打开新增窗口按钮);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.超级道具_禁止商会道具);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.超级道具_禁止拍卖道具);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.超级道具_禁止摆摊道具);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.超级道具_禁止交易道具);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.超级道具_禁止使用道具);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.超级道具_自动使用道具);
		base.Controls.Add(this.超级道具_开关);
		base.Controls.Add(this.超级道具_重载按钮);
		base.Controls.Add(this.超级道具_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "超级道具配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "超级道具配置窗口";
		base.Load += new System.EventHandler(超级道具配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.超级道具_道具列表).EndInit();
		this.修改窗口.ResumeLayout(false);
		this.修改窗口.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_附加属性限时).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_累计奖励列表).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高累计数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低累计数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_额外奖励几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_额外奖励最高).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_额外奖励最低).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高道行).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低道行).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_使用数量).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
