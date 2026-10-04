using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class BOSS挑战配置窗口 : Form
{
	private static BOSS挑战配置窗口 i;

	private IContainer components;

	private CheckBox 超级boss_开关;

	private Button 超级boss_重载按钮;

	private Button 超级boss_保存按钮;

	private CheckBox 超级boss_双倍击杀开关;

	private DataGridView 超级boss_boss列表;

	private Button 超级boss_打开新增窗口按钮;

	private Panel 修改窗口;

	private Button 修改_取消按钮;

	private Button 修改_确定按钮;

	private DataGridView 修改_掉落奖励列表;

	private Button 修改_添加掉落奖励按钮;

	private TextBox 修改_掉落奖励内容;

	private ComboBox 修改_掉落奖励类型;

	private Label label20;

	private Label label19;

	private NumericUpDown 修改_最低掉落数量;

	private CheckBox 修改_掉落奖励开关;

	private Label label14;

	private TextBox 修改_指定称号1;

	private CheckBox 修改_限制称号开关;

	private NumericUpDown 修改_最高道行;

	private Label label12;

	private NumericUpDown 修改_最低道行;

	private CheckBox 修改_限制道行开关;

	private NumericUpDown 修改_最高等级;

	private Label label13;

	private NumericUpDown 修改_最低等级;

	private CheckBox 修改_限制等级开关;

	private Label label8;

	private TextBox 修改_名字;

	private CheckBox 修改_击杀补充开关;

	private NumericUpDown 修改_每日最多击杀次数;

	private Label label2;

	private CheckBox 修改_限制每日击杀开关;

	private CheckBox 修改_限制组队开关;

	private Label label1;

	private TextBox 修改_对话文本;

	private NumericUpDown 修改_补充消耗价格;

	private ComboBox 修改_补充消耗类型;

	private Label label3;

	private NumericUpDown 修改_挑战消耗数量;

	private TextBox 修改_挑战消耗内容;

	private ComboBox 修改_挑战消耗类型;

	private CheckBox 修改_挑战消耗开关;

	private Label label4;

	private TextBox 修改_指定称号2;

	private GroupBox groupBox1;

	private CheckBox 修改_只掉落队长;

	private NumericUpDown 修改_掉落几率;

	private NumericUpDown 修改_最高掉落数量;

	private Label label5;

	private Label label6;

	private Label label7;

	private TextBox 修改_战斗名字;

	private Label label9;

	private TextBox 修改_关键词;

	private DataGridViewComboBoxColumn 掉落类型;

	private DataGridViewTextBoxColumn 掉落内容;

	private DataGridViewTextBoxColumn 最低掉落;

	private DataGridViewTextBoxColumn 最高掉落;

	private DataGridViewTextBoxColumn 掉落几率;

	private DataGridViewCheckBoxColumn Is谣言;

	private Label label10;

	private Label label11;

	private NumericUpDown 修改_最高活跃;

	private Label label15;

	private NumericUpDown 修改_最低活跃;

	private CheckBox 修改_限制活跃开关;

	private Label label16;

	private TextBox 修改_称号;

	private DataGridViewTextBoxColumn boss名字;

	private DataGridViewTextBoxColumn 设置称号;

	private DataGridViewTextBoxColumn boss对话;

	private DataGridViewTextBoxColumn 禁止组队;

	private DataGridViewTextBoxColumn 限制每日击杀;

	private DataGridViewTextBoxColumn 击杀次数补充;

	private DataGridViewTextBoxColumn 挑战等级区间;

	private DataGridViewTextBoxColumn 挑战道行区间;

	private DataGridViewTextBoxColumn 挑战活跃区间;

	private DataGridViewTextBoxColumn 限制挑战称号;

	private DataGridViewTextBoxColumn 挑战boss消耗;

	private DataGridViewTextBoxColumn boss掉落列表;

	private ToolTip BOSS挑战提示组件;

	public static BOSS挑战配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new BOSS挑战配置窗口();
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

	public BOSS挑战配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void BOSS挑战配置窗口_Load(object sender, EventArgs e)
	{
		BOSS挑战提示组件.AutoPopDelay = 3000;
		BOSS挑战提示组件.InitialDelay = 100;
		BOSS挑战提示组件.ReshowDelay = 100;
		BOSS挑战提示组件.IsBalloon = true;
		超级boss_boss列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(修改事件回调, 删除事件回调);
		修改_取消按钮.Click += delegate
		{
			修改窗口.Visible = false;
		};
		修改_确定按钮.Click += 确定修改事件回调;
		修改_掉落奖励列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 修改_删除事件回调);
		((DataGridViewComboBoxColumn)修改_掉落奖励列表.Columns[0]).DataSource = new List<string>
		{
			"金元宝", "银元宝", "金钱", "代金券", "声望", "累充点", "南极点", "奇宝点", "灵气值", "道具",
			"道行"
		};
		修改_掉落奖励列表.DataError += delegate
		{
		};
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		超级boss_重载按钮_Click(sender, e);
	}

	private void 修改_掉落奖励类型_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Enum.TryParse<AllEnums.数值Type>(修改_掉落奖励类型.Text, out var result))
		{
			if (result == AllEnums.数值Type.道具)
			{
				修改_掉落奖励内容.Text = string.Empty;
			}
			else
			{
				修改_掉落奖励内容.Text = 修改_掉落奖励类型.Text;
			}
		}
	}

	private void 修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 超级boss_boss列表.CurrentRow == null)
		{
			return;
		}
		int index = 超级boss_boss列表.CurrentRow.Index;
		if (index < 0)
		{
			return;
		}
		DataGridViewCellCollection cells = 超级boss_boss列表.Rows[index].Cells;
		修改_名字.Text = cells["boss名字"].Value.ToString();
		修改_补充消耗类型.Text = "无";
		修改_挑战消耗类型.Text = "无";
		if (!Singleton<全局变量类>.I.挑战BOSS配置.挑战boss列表.TryGetValue(修改_名字.Text, out 挑战BOSS列表类 当前数据))
		{
			return;
		}
		修改_名字.ReadOnly = true;
		修改_称号.Text = 当前数据.BOSS称号;
		修改_确定按钮.Text = "修     改";
		修改_战斗名字.Text = ((!string.IsNullOrWhiteSpace(当前数据.BOSS战斗名字)) ? 当前数据.BOSS战斗名字 : 当前数据.BOSS名字);
		修改_关键词.Text = 当前数据.对话关键词;
		修改_限制组队开关.Checked = 当前数据.is组队开关;
		修改_对话文本.Text = 当前数据.介绍描述;
		修改_限制每日击杀开关.Checked = 当前数据.is击杀开关;
		修改_每日最多击杀次数.Value = 当前数据.每日限制击杀;
		修改_击杀补充开关.Checked = 当前数据.is补充开关;
		修改_补充消耗类型.Text = 当前数据.补充类型.ToString();
		修改_补充消耗价格.Value = 当前数据.补充消耗;
		修改_挑战消耗开关.Checked = 当前数据.is挑战消耗;
		修改_挑战消耗类型.Text = 当前数据.消耗类型.ToString();
		修改_挑战消耗内容.Text = ((当前数据.消耗类型 != AllEnums.数值Type.道具) ? 当前数据.消耗类型.ToString() : 当前数据.消耗道具);
		修改_挑战消耗数量.Value = 当前数据.消耗数量;
		修改_限制等级开关.Checked = 当前数据.is等级开关;
		修改_最低等级.Value = 当前数据.最低等级;
		修改_最高等级.Value = 当前数据.最高等级;
		修改_限制道行开关.Checked = 当前数据.is道行开关;
		修改_最低道行.Value = 当前数据.最低道行;
		修改_最高道行.Value = 当前数据.最高道行;
		修改_限制道行开关.Checked = 当前数据.is活跃开关;
		修改_最低活跃.Value = 当前数据.最低活跃;
		修改_最高活跃.Value = 当前数据.最高活跃;
		修改_限制称号开关.Checked = 当前数据.is称号开关;
		修改_指定称号1.Text = 当前数据.指定称号1;
		修改_指定称号2.Text = 当前数据.指定称号2;
		修改_掉落奖励开关.Checked = 当前数据.is掉落开关;
		修改_只掉落队长.Checked = 当前数据.只给队长;
		修改_掉落奖励列表.Invoke((MethodInvoker)delegate
		{
			修改_掉落奖励列表.Rows.Clear();
			for (int i = 0; i < 当前数据.掉落列表.Count; i++)
			{
				修改_掉落奖励列表.Rows.Add(string.Empty, (当前数据.掉落列表[i].掉落类型 == AllEnums.数值Type.道具) ? 当前数据.掉落列表[i].掉落道具 : ((object)当前数据.掉落列表[i].掉落类型), 当前数据.掉落列表[i].掉落最低数量, 当前数据.掉落列表[i].掉落最高数量, 当前数据.掉落列表[i].掉落几率, 当前数据.掉落列表[i].Is谣言);
				((DataGridViewComboBoxCell)修改_掉落奖励列表.Rows[i].Cells[0]).Value = 当前数据.掉落列表[i].掉落类型.ToString();
			}
		});
		修改窗口.Visible = true;
	}

	private void 确定修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		if (修改_确定按钮.Text == "新     增")
		{
			超级BOSS_新增事件();
		}
		else
		{
			if (!Singleton<全局变量类>.I.挑战BOSS配置.挑战boss列表.TryGetValue(修改_名字.Text, out 挑战BOSS列表类 value))
			{
				return;
			}
			value.BOSS战斗名字 = (string.IsNullOrWhiteSpace(修改_战斗名字.Text) ? 修改_名字.Text : 修改_战斗名字.Text);
			value.BOSS称号 = 修改_称号.Text;
			value.对话关键词 = 修改_关键词.Text;
			value.is组队开关 = 修改_限制组队开关.Checked;
			value.介绍描述 = 修改_对话文本.Text;
			value.is击杀开关 = 修改_限制每日击杀开关.Checked;
			value.每日限制击杀 = (int)修改_每日最多击杀次数.Value;
			value.is补充开关 = 修改_击杀补充开关.Checked;
			Enum.TryParse<AllEnums.数值Type>(修改_补充消耗类型.Text, out value.补充类型);
			value.补充消耗 = (int)修改_补充消耗价格.Value;
			value.is挑战消耗 = 修改_挑战消耗开关.Checked;
			Enum.TryParse<AllEnums.数值Type>(修改_挑战消耗类型.Text, out value.消耗类型);
			value.消耗道具 = ((value.消耗类型 != AllEnums.数值Type.道具) ? value.消耗类型.ToString() : 修改_挑战消耗内容.Text);
			value.消耗数量 = (int)修改_挑战消耗数量.Value;
			value.is等级开关 = 修改_限制等级开关.Checked;
			value.最低等级 = (int)修改_最低等级.Value;
			value.最高等级 = (int)修改_最高等级.Value;
			value.is道行开关 = 修改_限制道行开关.Checked;
			value.最低道行 = (int)修改_最低道行.Value;
			value.最高道行 = (int)修改_最高道行.Value;
			value.is活跃开关 = 修改_限制活跃开关.Checked;
			value.最低活跃 = (int)修改_最低活跃.Value;
			value.最高活跃 = (int)修改_最高活跃.Value;
			value.is称号开关 = 修改_限制称号开关.Checked;
			value.指定称号1 = 修改_指定称号1.Text;
			value.指定称号2 = 修改_指定称号2.Text;
			value.is掉落开关 = 修改_掉落奖励开关.Checked;
			value.只给队长 = 修改_只掉落队长.Checked;
			string text = string.Empty;
			value.掉落列表.Clear();
			for (int i = 0; i < 修改_掉落奖励列表.Rows.Count; i++)
			{
				DataGridViewCellCollection cells = 修改_掉落奖励列表.Rows[i].Cells;
				if (cells["掉落类型"].Value != null && !string.IsNullOrWhiteSpace(cells["掉落类型"].Value.ToString()))
				{
					BOSS掉落类 bOSS掉落类 = new BOSS掉落类();
					if (Enum.TryParse<AllEnums.数值Type>(cells["掉落类型"].Value.ToString(), out bOSS掉落类.掉落类型))
					{
						bOSS掉落类.掉落道具 = ((bOSS掉落类.掉落类型 != AllEnums.数值Type.道具) ? bOSS掉落类.掉落类型.ToString() : cells["掉落内容"].Value.ToString());
						int.TryParse(cells["最低掉落"].Value.ToString(), out bOSS掉落类.掉落最低数量);
						int.TryParse(cells["最高掉落"].Value.ToString(), out bOSS掉落类.掉落最高数量);
						int.TryParse(cells["掉落几率"].Value.ToString(), out bOSS掉落类.掉落几率);
						bOSS掉落类.Is谣言 = Convert.ToBoolean(cells["Is谣言"].Value);
						value.掉落列表.Add(bOSS掉落类);
						text = text + ((i != 0) ? "、" : string.Empty) + bOSS掉落类.掉落道具;
					}
				}
			}
			if (!value.is掉落开关 || value.掉落列表.Count <= 0)
			{
				text = "无";
			}
			修改窗口.Visible = false;
			if (超级boss_boss列表.CurrentRow != null)
			{
				int index = 超级boss_boss列表.CurrentRow.Index;
				if (index >= 0)
				{
					DataGridViewCellCollection cells2 = 超级boss_boss列表.Rows[index].Cells;
					cells2["设置称号"].Value = value.BOSS称号;
					cells2["boss对话"].Value = value.介绍描述;
					cells2["禁止组队"].Value = (value.is组队开关 ? "开" : "关");
					cells2["限制每日击杀"].Value = ((!value.is击杀开关) ? "关" : $"开({value.每日限制击杀}/次)");
					cells2["击杀次数补充"].Value = ((!value.is补充开关) ? "关" : $"开({value.补充消耗}{value.补充类型}/次)");
					cells2["挑战等级区间"].Value = ((!value.is等级开关) ? "关" : $"[{value.最低等级}-{value.最高等级}]");
					cells2["挑战道行区间"].Value = ((!value.is道行开关) ? "关" : $"[{value.最低道行}-{value.最高道行}]");
					cells2["挑战活跃区间"].Value = ((!value.is活跃开关) ? "关" : $"[{value.最低活跃}-{value.最高活跃}]");
					cells2["限制挑战称号"].Value = ((!value.is称号开关) ? "关" : (value.指定称号1 + "、" + value.指定称号2));
					cells2["挑战boss消耗"].Value = ((!value.is挑战消耗) ? "关" : $"{value.消耗道具}×{value.消耗数量}");
					cells2["boss掉落列表"].Value = text;
					MessageBox.Show("[" + 修改_名字.Text + "]的配置已经修改，请及时点击保存配置按钮更新服务端配置！");
				}
			}
		}
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 超级boss_boss列表.CurrentRow == null)
		{
			return;
		}
		int index = 超级boss_boss列表.CurrentRow.Index;
		if (index >= 0)
		{
			string text = 超级boss_boss列表.Rows[index].Cells["boss名字"].Value.ToString();
			if (Singleton<全局变量类>.I.挑战BOSS配置.挑战boss列表.ContainsKey(text))
			{
				Singleton<全局变量类>.I.挑战BOSS配置.挑战boss列表.TryRemove(text, out 挑战BOSS列表类 _);
				MessageBox.Show("[" + text + "]已从列表中删除，请及时点击保存配置按钮更新服务端配置！");
				超级boss_boss列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 修改_删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 修改_掉落奖励列表.CurrentRow != null)
		{
			int index = 修改_掉落奖励列表.CurrentRow.Index;
			if (index >= 0)
			{
				修改_掉落奖励列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 31)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			超级boss_开关.Checked = Singleton<全局变量类>.I.挑战BOSS配置.功能开关;
			超级boss_双倍击杀开关.Checked = Singleton<全局变量类>.I.挑战BOSS配置.is指定会员双倍;
			超级boss_boss列表.Rows.Clear();
			foreach (挑战BOSS列表类 value in Singleton<全局变量类>.I.挑战BOSS配置.挑战boss列表.Values)
			{
				string text = string.Empty;
				if (value.is掉落开关 && value.掉落列表.Count > 0)
				{
					for (int i = 0; i < value.掉落列表.Count; i++)
					{
						text = text + ((i != 0) ? "、" : string.Empty) + value.掉落列表[i].掉落道具;
					}
				}
				else
				{
					text = "无";
				}
				DataGridViewRowCollection rows = 超级boss_boss列表.Rows;
				object[] obj = new object[12]
				{
					value.BOSS名字,
					value.BOSS称号,
					value.介绍描述,
					value.is组队开关 ? "开" : "关",
					(!value.is击杀开关) ? "关" : $"开({value.每日限制击杀}/次)",
					(!value.is补充开关) ? "关" : $"开({value.补充消耗}{value.补充类型}/次)",
					(!value.is等级开关) ? "关" : $"[{value.最低等级}-{value.最高等级}]",
					(!value.is道行开关) ? "关" : $"[{value.最低道行}-{value.最高道行}]",
					(!value.is活跃开关) ? "关" : $"[{value.最低活跃}-{value.最高活跃}]",
					(!value.is称号开关) ? "关" : (value.指定称号1 + "、" + value.指定称号2),
					null,
					null
				};
				object obj2;
				if (value.is挑战消耗)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted((value.消耗类型 != AllEnums.数值Type.道具) ? ((object)value.消耗类型) : value.消耗道具);
					defaultInterpolatedStringHandler.AppendLiteral("×");
					defaultInterpolatedStringHandler.AppendFormatted(value.消耗数量);
					obj2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					obj2 = "关";
				}
				obj[10] = obj2;
				obj[11] = text;
				rows.Add(obj);
			}
		});
	}

	private void 配置变量赋值()
	{
		Singleton<全局变量类>.I.挑战BOSS配置.功能开关 = 超级boss_开关.Checked;
		Singleton<全局变量类>.I.挑战BOSS配置.is指定会员双倍 = 超级boss_双倍击杀开关.Checked;
	}

	private void 超级boss_保存按钮_Click(object sender, EventArgs e)
	{
		配置变量赋值();
		Singleton<全局变量类>.I.验证client.SendRT(10018, 31, JsonConvert.SerializeObject(Singleton<全局变量类>.I.挑战BOSS配置, Formatting.Indented));
	}

	private void 超级boss_重载按钮_Click(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.SendRT(10017, 31);
	}

	private void 超级boss_打开新增窗口按钮_Click(object sender, EventArgs e)
	{
		修改_名字.ReadOnly = false;
		修改_确定按钮.Text = "新     增";
		修改_名字.Text = string.Empty;
		修改窗口.Visible = true;
	}

	private void 超级BOSS_新增事件()
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(修改_名字.Text))
		{
			MessageBox.Show("请输入要添加的超级BOSS！");
			return;
		}
		if (string.IsNullOrWhiteSpace(修改_补充消耗类型.Text))
		{
			MessageBox.Show("请选择【" + 修改_名字.Text + "】BOSS要补充挑战次数花费的类型，没有请勿勾选击杀补充开关！");
			return;
		}
		if (string.IsNullOrWhiteSpace(修改_挑战消耗类型.Text))
		{
			MessageBox.Show("请选择【" + 修改_名字.Text + "】BOSS挑战挑战时需要消耗的类型，没有请勿勾选挑战消耗开关！");
			return;
		}
		if (修改_挑战消耗开关.Checked && 修改_挑战消耗类型.Text == "道具" && string.IsNullOrWhiteSpace(修改_挑战消耗内容.Text))
		{
			MessageBox.Show("请填写【" + 修改_名字.Text + "】BOSS挑战挑战时需要消耗的道具名字和数量，没有请勿勾选挑战消耗开关！");
			return;
		}
		if (修改_限制称号开关.Checked && string.IsNullOrWhiteSpace(修改_指定称号1.Text) && string.IsNullOrWhiteSpace(修改_指定称号2.Text))
		{
			MessageBox.Show("请填写【" + 修改_名字.Text + "】BOSS挑战挑战时需要的称号，没有请不要勾选限制称号开关！");
			return;
		}
		if (修改_掉落奖励开关.Checked && 修改_掉落奖励列表.Rows.Count <= 0)
		{
			MessageBox.Show("请添加【" + 修改_名字.Text + "】BOSS掉落的奖励，没有请不要勾选掉落奖励开关！");
			return;
		}
		if (Singleton<全局变量类>.I.挑战BOSS配置.挑战boss列表.ContainsKey(修改_名字.Text))
		{
			MessageBox.Show("列表中已经存在【" + 修改_名字.Text + "】，无法重复添加！");
			return;
		}
		挑战BOSS列表类 挑战BOSS列表类2 = new 挑战BOSS列表类();
		挑战BOSS列表类2.BOSS名字 = 修改_名字.Text;
		挑战BOSS列表类2.BOSS称号 = 修改_称号.Text;
		挑战BOSS列表类2.BOSS战斗名字 = 修改_战斗名字.Text;
		挑战BOSS列表类2.对话关键词 = 修改_关键词.Text;
		挑战BOSS列表类2.介绍描述 = 修改_对话文本.Text;
		挑战BOSS列表类2.is组队开关 = 修改_限制组队开关.Checked;
		挑战BOSS列表类2.is击杀开关 = 修改_限制每日击杀开关.Checked;
		挑战BOSS列表类2.每日限制击杀 = (int)修改_每日最多击杀次数.Value;
		挑战BOSS列表类2.is补充开关 = 修改_击杀补充开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(修改_补充消耗类型.Text, out 挑战BOSS列表类2.补充类型);
		挑战BOSS列表类2.补充消耗 = (int)修改_补充消耗价格.Value;
		挑战BOSS列表类2.is挑战消耗 = 修改_挑战消耗开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(修改_挑战消耗类型.Text, out 挑战BOSS列表类2.消耗类型);
		挑战BOSS列表类2.消耗道具 = ((挑战BOSS列表类2.消耗类型 != AllEnums.数值Type.道具) ? 挑战BOSS列表类2.消耗类型.ToString() : 修改_挑战消耗内容.Text);
		挑战BOSS列表类2.消耗数量 = (int)修改_挑战消耗数量.Value;
		挑战BOSS列表类2.is等级开关 = 修改_限制等级开关.Checked;
		挑战BOSS列表类2.最低等级 = (int)修改_最低等级.Value;
		挑战BOSS列表类2.最高等级 = (int)修改_最高等级.Value;
		挑战BOSS列表类2.is道行开关 = 修改_限制道行开关.Checked;
		挑战BOSS列表类2.最低道行 = (int)修改_最低道行.Value;
		挑战BOSS列表类2.最高道行 = (int)修改_最高道行.Value;
		挑战BOSS列表类2.is活跃开关 = 修改_限制活跃开关.Checked;
		挑战BOSS列表类2.最低活跃 = (int)修改_最低活跃.Value;
		挑战BOSS列表类2.最高活跃 = (int)修改_最高活跃.Value;
		挑战BOSS列表类2.is称号开关 = 修改_限制称号开关.Checked;
		挑战BOSS列表类2.指定称号1 = 修改_指定称号1.Text;
		挑战BOSS列表类2.指定称号2 = 修改_指定称号2.Text;
		挑战BOSS列表类2.is掉落开关 = 修改_掉落奖励开关.Checked;
		挑战BOSS列表类2.只给队长 = 修改_只掉落队长.Checked;
		string text = string.Empty;
		挑战BOSS列表类2.掉落列表.Clear();
		for (int i = 0; i < 修改_掉落奖励列表.Rows.Count; i++)
		{
			DataGridViewCellCollection cells = 修改_掉落奖励列表.Rows[i].Cells;
			if (cells["掉落类型"].Value != null && !string.IsNullOrWhiteSpace(cells["掉落类型"].Value.ToString()))
			{
				BOSS掉落类 bOSS掉落类 = new BOSS掉落类();
				if (Enum.TryParse<AllEnums.数值Type>(cells["掉落类型"].Value.ToString(), out bOSS掉落类.掉落类型))
				{
					bOSS掉落类.掉落道具 = ((bOSS掉落类.掉落类型 != AllEnums.数值Type.道具) ? bOSS掉落类.掉落类型.ToString() : cells["掉落内容"].Value.ToString());
					int.TryParse(cells["最低掉落"].Value.ToString(), out bOSS掉落类.掉落最低数量);
					int.TryParse(cells["最高掉落"].Value.ToString(), out bOSS掉落类.掉落最高数量);
					int.TryParse(cells["掉落几率"].Value.ToString(), out bOSS掉落类.掉落几率);
					bOSS掉落类.Is谣言 = Convert.ToBoolean(cells["Is谣言"].Value);
					挑战BOSS列表类2.掉落列表.Add(bOSS掉落类);
					text = text + ((i != 0) ? "、" : string.Empty) + bOSS掉落类.掉落道具;
				}
			}
		}
		if (!挑战BOSS列表类2.is掉落开关 || 挑战BOSS列表类2.掉落列表.Count <= 0)
		{
			text = "无";
		}
		Singleton<全局变量类>.I.挑战BOSS配置.挑战boss列表.TryAdd(挑战BOSS列表类2.BOSS名字, 挑战BOSS列表类2);
		修改窗口.Visible = false;
		超级boss_boss列表.Rows.Add(挑战BOSS列表类2.BOSS名字, 挑战BOSS列表类2.BOSS称号, 挑战BOSS列表类2.介绍描述, 挑战BOSS列表类2.is组队开关 ? "开" : "关", (!挑战BOSS列表类2.is击杀开关) ? "关" : $"开({挑战BOSS列表类2.每日限制击杀}/次)", (!挑战BOSS列表类2.is补充开关) ? "关" : $"开({挑战BOSS列表类2.补充消耗}{挑战BOSS列表类2.补充类型}/次)", (!挑战BOSS列表类2.is等级开关) ? "关" : $"[{挑战BOSS列表类2.最低等级}-{挑战BOSS列表类2.最高等级}]", (!挑战BOSS列表类2.is道行开关) ? "关" : $"[{挑战BOSS列表类2.最低道行}-{挑战BOSS列表类2.最高道行}]", (!挑战BOSS列表类2.is活跃开关) ? "关" : $"[{挑战BOSS列表类2.最低活跃}-{挑战BOSS列表类2.最高活跃}]", (!挑战BOSS列表类2.is称号开关) ? "关" : (挑战BOSS列表类2.指定称号1 + "、" + 挑战BOSS列表类2.指定称号2), (!挑战BOSS列表类2.is挑战消耗) ? "关" : $"{挑战BOSS列表类2.消耗道具}×{挑战BOSS列表类2.消耗数量}", text);
		MessageBox.Show("[" + 修改_名字.Text + "]添加成功");
	}

	private void 修改_添加掉落奖励按钮_Click(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		修改_掉落奖励列表.Invoke((MethodInvoker)delegate
		{
			if (string.IsNullOrWhiteSpace(修改_掉落奖励类型.Text))
			{
				MessageBox.Show("请选择要掉落的奖励类型！");
			}
			else if (修改_掉落奖励类型.Text == "道具" && string.IsNullOrWhiteSpace(修改_掉落奖励内容.Text))
			{
				MessageBox.Show("请选择要掉落的道具名字！");
			}
			else
			{
				if (修改_掉落奖励类型.Text != "道具")
				{
					修改_掉落奖励内容.Text = 修改_掉落奖励类型.Text;
				}
				修改_掉落奖励列表.Rows.Add(修改_掉落奖励类型.Text, 修改_掉落奖励内容.Text, 修改_最低掉落数量.Value, 修改_最高掉落数量.Value, 修改_掉落几率.Value);
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
		this.components = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.BOSS挑战配置窗口));
		this.超级boss_开关 = new System.Windows.Forms.CheckBox();
		this.超级boss_重载按钮 = new System.Windows.Forms.Button();
		this.超级boss_保存按钮 = new System.Windows.Forms.Button();
		this.超级boss_双倍击杀开关 = new System.Windows.Forms.CheckBox();
		this.超级boss_boss列表 = new System.Windows.Forms.DataGridView();
		this.boss名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.设置称号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.boss对话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.禁止组队 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.限制每日击杀 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.击杀次数补充 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.挑战等级区间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.挑战道行区间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.挑战活跃区间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.限制挑战称号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.挑战boss消耗 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.boss掉落列表 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.超级boss_打开新增窗口按钮 = new System.Windows.Forms.Button();
		this.修改窗口 = new System.Windows.Forms.Panel();
		this.label16 = new System.Windows.Forms.Label();
		this.修改_称号 = new System.Windows.Forms.TextBox();
		this.修改_最高活跃 = new System.Windows.Forms.NumericUpDown();
		this.label15 = new System.Windows.Forms.Label();
		this.修改_最低活跃 = new System.Windows.Forms.NumericUpDown();
		this.修改_限制活跃开关 = new System.Windows.Forms.CheckBox();
		this.label11 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.修改_关键词 = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.修改_战斗名字 = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.修改_掉落几率 = new System.Windows.Forms.NumericUpDown();
		this.修改_最高掉落数量 = new System.Windows.Forms.NumericUpDown();
		this.修改_最低掉落数量 = new System.Windows.Forms.NumericUpDown();
		this.label19 = new System.Windows.Forms.Label();
		this.label20 = new System.Windows.Forms.Label();
		this.修改_掉落奖励类型 = new System.Windows.Forms.ComboBox();
		this.修改_掉落奖励内容 = new System.Windows.Forms.TextBox();
		this.修改_添加掉落奖励按钮 = new System.Windows.Forms.Button();
		this.修改_掉落奖励列表 = new System.Windows.Forms.DataGridView();
		this.掉落类型 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.掉落内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.最低掉落 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.最高掉落 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.掉落几率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Is谣言 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.修改_只掉落队长 = new System.Windows.Forms.CheckBox();
		this.label4 = new System.Windows.Forms.Label();
		this.修改_指定称号2 = new System.Windows.Forms.TextBox();
		this.修改_挑战消耗数量 = new System.Windows.Forms.NumericUpDown();
		this.修改_挑战消耗内容 = new System.Windows.Forms.TextBox();
		this.修改_挑战消耗类型 = new System.Windows.Forms.ComboBox();
		this.修改_挑战消耗开关 = new System.Windows.Forms.CheckBox();
		this.修改_补充消耗价格 = new System.Windows.Forms.NumericUpDown();
		this.修改_补充消耗类型 = new System.Windows.Forms.ComboBox();
		this.label3 = new System.Windows.Forms.Label();
		this.修改_击杀补充开关 = new System.Windows.Forms.CheckBox();
		this.修改_每日最多击杀次数 = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.修改_限制每日击杀开关 = new System.Windows.Forms.CheckBox();
		this.修改_限制组队开关 = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.修改_对话文本 = new System.Windows.Forms.TextBox();
		this.修改_取消按钮 = new System.Windows.Forms.Button();
		this.修改_确定按钮 = new System.Windows.Forms.Button();
		this.修改_掉落奖励开关 = new System.Windows.Forms.CheckBox();
		this.label14 = new System.Windows.Forms.Label();
		this.修改_指定称号1 = new System.Windows.Forms.TextBox();
		this.修改_限制称号开关 = new System.Windows.Forms.CheckBox();
		this.修改_最高道行 = new System.Windows.Forms.NumericUpDown();
		this.label12 = new System.Windows.Forms.Label();
		this.修改_最低道行 = new System.Windows.Forms.NumericUpDown();
		this.修改_限制道行开关 = new System.Windows.Forms.CheckBox();
		this.修改_最高等级 = new System.Windows.Forms.NumericUpDown();
		this.label13 = new System.Windows.Forms.Label();
		this.修改_最低等级 = new System.Windows.Forms.NumericUpDown();
		this.修改_限制等级开关 = new System.Windows.Forms.CheckBox();
		this.label8 = new System.Windows.Forms.Label();
		this.修改_名字 = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.BOSS挑战提示组件 = new System.Windows.Forms.ToolTip(this.components);
		((System.ComponentModel.ISupportInitialize)this.超级boss_boss列表).BeginInit();
		this.修改窗口.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_最高活跃).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低活跃).BeginInit();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_掉落几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高掉落数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低掉落数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_掉落奖励列表).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_挑战消耗数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_补充消耗价格).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_每日最多击杀次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高道行).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低道行).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低等级).BeginInit();
		base.SuspendLayout();
		this.超级boss_开关.AutoSize = true;
		this.超级boss_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级boss_开关.Location = new System.Drawing.Point(12, 12);
		this.超级boss_开关.Name = "超级boss_开关";
		this.超级boss_开关.Size = new System.Drawing.Size(116, 23);
		this.超级boss_开关.TabIndex = 87;
		this.超级boss_开关.Text = "超级BOSS开关";
		this.超级boss_开关.UseVisualStyleBackColor = true;
		this.超级boss_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级boss_重载按钮.Location = new System.Drawing.Point(461, 8);
		this.超级boss_重载按钮.Name = "超级boss_重载按钮";
		this.超级boss_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.超级boss_重载按钮.TabIndex = 89;
		this.超级boss_重载按钮.Text = "重载配置";
		this.超级boss_重载按钮.UseVisualStyleBackColor = true;
		this.超级boss_重载按钮.Click += new System.EventHandler(超级boss_重载按钮_Click);
		this.超级boss_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级boss_保存按钮.Location = new System.Drawing.Point(352, 8);
		this.超级boss_保存按钮.Name = "超级boss_保存按钮";
		this.超级boss_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.超级boss_保存按钮.TabIndex = 88;
		this.超级boss_保存按钮.Text = "保存配置";
		this.超级boss_保存按钮.UseVisualStyleBackColor = true;
		this.超级boss_保存按钮.Click += new System.EventHandler(超级boss_保存按钮_Click);
		this.超级boss_双倍击杀开关.AutoSize = true;
		this.超级boss_双倍击杀开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级boss_双倍击杀开关.Location = new System.Drawing.Point(136, 12);
		this.超级boss_双倍击杀开关.Name = "超级boss_双倍击杀开关";
		this.超级boss_双倍击杀开关.Size = new System.Drawing.Size(210, 23);
		this.超级boss_双倍击杀开关.TabIndex = 90;
		this.超级boss_双倍击杀开关.Text = "特权会员获得双倍击杀次数开关";
		this.超级boss_双倍击杀开关.UseVisualStyleBackColor = true;
		this.超级boss_boss列表.AllowUserToAddRows = false;
		this.超级boss_boss列表.AllowUserToDeleteRows = false;
		this.超级boss_boss列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.超级boss_boss列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.超级boss_boss列表.BackgroundColor = System.Drawing.Color.White;
		this.超级boss_boss列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.超级boss_boss列表.Columns.AddRange(this.boss名字, this.设置称号, this.boss对话, this.禁止组队, this.限制每日击杀, this.击杀次数补充, this.挑战等级区间, this.挑战道行区间, this.挑战活跃区间, this.限制挑战称号, this.挑战boss消耗, this.boss掉落列表);
		this.超级boss_boss列表.Location = new System.Drawing.Point(12, 88);
		this.超级boss_boss列表.MultiSelect = false;
		this.超级boss_boss列表.Name = "超级boss_boss列表";
		this.超级boss_boss列表.ReadOnly = true;
		this.超级boss_boss列表.RowHeadersVisible = false;
		this.超级boss_boss列表.RowTemplate.Height = 25;
		this.超级boss_boss列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.超级boss_boss列表.Size = new System.Drawing.Size(960, 461);
		this.超级boss_boss列表.TabIndex = 103;
		this.boss名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.boss名字.HeaderText = "boss名字";
		this.boss名字.MinimumWidth = 100;
		this.boss名字.Name = "boss名字";
		this.boss名字.ReadOnly = true;
		this.设置称号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.设置称号.HeaderText = "设置称号";
		this.设置称号.MinimumWidth = 85;
		this.设置称号.Name = "设置称号";
		this.设置称号.ReadOnly = true;
		this.设置称号.ToolTipText = "当你开通了元神系统功能，称号写境界名字则表示当前BOSS的境界";
		this.设置称号.Width = 85;
		this.boss对话.HeaderText = "boss对话";
		this.boss对话.MinimumWidth = 100;
		this.boss对话.Name = "boss对话";
		this.boss对话.ReadOnly = true;
		this.禁止组队.HeaderText = "禁止组队";
		this.禁止组队.MinimumWidth = 85;
		this.禁止组队.Name = "禁止组队";
		this.禁止组队.ReadOnly = true;
		this.禁止组队.Width = 85;
		this.限制每日击杀.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.限制每日击杀.HeaderText = "限制每日击杀";
		this.限制每日击杀.MinimumWidth = 110;
		this.限制每日击杀.Name = "限制每日击杀";
		this.限制每日击杀.ReadOnly = true;
		this.限制每日击杀.Width = 110;
		this.击杀次数补充.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.击杀次数补充.HeaderText = "击杀次数补充";
		this.击杀次数补充.MinimumWidth = 110;
		this.击杀次数补充.Name = "击杀次数补充";
		this.击杀次数补充.ReadOnly = true;
		this.击杀次数补充.Width = 110;
		this.挑战等级区间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.挑战等级区间.HeaderText = "挑战等级区间";
		this.挑战等级区间.MinimumWidth = 110;
		this.挑战等级区间.Name = "挑战等级区间";
		this.挑战等级区间.ReadOnly = true;
		this.挑战等级区间.Width = 110;
		this.挑战道行区间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.挑战道行区间.HeaderText = "挑战道行区间";
		this.挑战道行区间.MinimumWidth = 110;
		this.挑战道行区间.Name = "挑战道行区间";
		this.挑战道行区间.ReadOnly = true;
		this.挑战道行区间.Width = 110;
		this.挑战活跃区间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.挑战活跃区间.HeaderText = "挑战活跃区间";
		this.挑战活跃区间.MinimumWidth = 110;
		this.挑战活跃区间.Name = "挑战活跃区间";
		this.挑战活跃区间.ReadOnly = true;
		this.挑战活跃区间.Width = 110;
		this.限制挑战称号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.限制挑战称号.HeaderText = "限制挑战称号";
		this.限制挑战称号.MinimumWidth = 110;
		this.限制挑战称号.Name = "限制挑战称号";
		this.限制挑战称号.ReadOnly = true;
		this.限制挑战称号.Width = 110;
		this.挑战boss消耗.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.挑战boss消耗.HeaderText = "挑战boss消耗";
		this.挑战boss消耗.MinimumWidth = 110;
		this.挑战boss消耗.Name = "挑战boss消耗";
		this.挑战boss消耗.ReadOnly = true;
		this.挑战boss消耗.Width = 110;
		this.boss掉落列表.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.boss掉落列表.HeaderText = "boss掉落列表";
		this.boss掉落列表.MinimumWidth = 150;
		this.boss掉落列表.Name = "boss掉落列表";
		this.boss掉落列表.ReadOnly = true;
		this.boss掉落列表.Width = 150;
		this.超级boss_打开新增窗口按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级boss_打开新增窗口按钮.Location = new System.Drawing.Point(12, 52);
		this.超级boss_打开新增窗口按钮.Name = "超级boss_打开新增窗口按钮";
		this.超级boss_打开新增窗口按钮.Size = new System.Drawing.Size(150, 30);
		this.超级boss_打开新增窗口按钮.TabIndex = 102;
		this.超级boss_打开新增窗口按钮.Text = "点击新增超级BOSS";
		this.超级boss_打开新增窗口按钮.UseVisualStyleBackColor = true;
		this.超级boss_打开新增窗口按钮.Click += new System.EventHandler(超级boss_打开新增窗口按钮_Click);
		this.修改窗口.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.修改窗口.Controls.Add(this.label16);
		this.修改窗口.Controls.Add(this.修改_称号);
		this.修改窗口.Controls.Add(this.修改_最高活跃);
		this.修改窗口.Controls.Add(this.label15);
		this.修改窗口.Controls.Add(this.修改_最低活跃);
		this.修改窗口.Controls.Add(this.修改_限制活跃开关);
		this.修改窗口.Controls.Add(this.label11);
		this.修改窗口.Controls.Add(this.label10);
		this.修改窗口.Controls.Add(this.label9);
		this.修改窗口.Controls.Add(this.修改_关键词);
		this.修改窗口.Controls.Add(this.label7);
		this.修改窗口.Controls.Add(this.修改_战斗名字);
		this.修改窗口.Controls.Add(this.label5);
		this.修改窗口.Controls.Add(this.groupBox1);
		this.修改窗口.Controls.Add(this.修改_只掉落队长);
		this.修改窗口.Controls.Add(this.label4);
		this.修改窗口.Controls.Add(this.修改_指定称号2);
		this.修改窗口.Controls.Add(this.修改_挑战消耗数量);
		this.修改窗口.Controls.Add(this.修改_挑战消耗内容);
		this.修改窗口.Controls.Add(this.修改_挑战消耗类型);
		this.修改窗口.Controls.Add(this.修改_挑战消耗开关);
		this.修改窗口.Controls.Add(this.修改_补充消耗价格);
		this.修改窗口.Controls.Add(this.修改_补充消耗类型);
		this.修改窗口.Controls.Add(this.label3);
		this.修改窗口.Controls.Add(this.修改_击杀补充开关);
		this.修改窗口.Controls.Add(this.修改_每日最多击杀次数);
		this.修改窗口.Controls.Add(this.label2);
		this.修改窗口.Controls.Add(this.修改_限制每日击杀开关);
		this.修改窗口.Controls.Add(this.修改_限制组队开关);
		this.修改窗口.Controls.Add(this.label1);
		this.修改窗口.Controls.Add(this.修改_对话文本);
		this.修改窗口.Controls.Add(this.修改_取消按钮);
		this.修改窗口.Controls.Add(this.修改_确定按钮);
		this.修改窗口.Controls.Add(this.修改_掉落奖励开关);
		this.修改窗口.Controls.Add(this.label14);
		this.修改窗口.Controls.Add(this.修改_指定称号1);
		this.修改窗口.Controls.Add(this.修改_限制称号开关);
		this.修改窗口.Controls.Add(this.修改_最高道行);
		this.修改窗口.Controls.Add(this.label12);
		this.修改窗口.Controls.Add(this.修改_最低道行);
		this.修改窗口.Controls.Add(this.修改_限制道行开关);
		this.修改窗口.Controls.Add(this.修改_最高等级);
		this.修改窗口.Controls.Add(this.label13);
		this.修改窗口.Controls.Add(this.修改_最低等级);
		this.修改窗口.Controls.Add(this.修改_限制等级开关);
		this.修改窗口.Controls.Add(this.label8);
		this.修改窗口.Controls.Add(this.修改_名字);
		this.修改窗口.Location = new System.Drawing.Point(7, 52);
		this.修改窗口.Name = "修改窗口";
		this.修改窗口.Size = new System.Drawing.Size(970, 472);
		this.修改窗口.TabIndex = 104;
		this.label16.Location = new System.Drawing.Point(219, 37);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(94, 23);
		this.label16.TabIndex = 176;
		this.label16.Text = "设置BOSS称号";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_称号.Location = new System.Drawing.Point(319, 37);
		this.修改_称号.Name = "修改_称号";
		this.修改_称号.Size = new System.Drawing.Size(85, 23);
		this.修改_称号.TabIndex = 177;
		this.修改_最高活跃.Location = new System.Drawing.Point(216, 345);
		this.修改_最高活跃.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最高活跃.Name = "修改_最高活跃";
		this.修改_最高活跃.Size = new System.Drawing.Size(60, 23);
		this.修改_最高活跃.TabIndex = 175;
		this.label15.BackColor = System.Drawing.Color.Transparent;
		this.label15.Location = new System.Drawing.Point(193, 345);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(110, 23);
		this.label15.TabIndex = 174;
		this.label15.Text = "—                  点";
		this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_最低活跃.Location = new System.Drawing.Point(130, 345);
		this.修改_最低活跃.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最低活跃.Name = "修改_最低活跃";
		this.修改_最低活跃.Size = new System.Drawing.Size(60, 23);
		this.修改_最低活跃.TabIndex = 173;
		this.修改_限制活跃开关.AutoSize = true;
		this.修改_限制活跃开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_限制活跃开关.Location = new System.Drawing.Point(18, 345);
		this.修改_限制活跃开关.Name = "修改_限制活跃开关";
		this.修改_限制活跃开关.Size = new System.Drawing.Size(106, 23);
		this.修改_限制活跃开关.TabIndex = 172;
		this.修改_限制活跃开关.Text = "限制活跃开关";
		this.修改_限制活跃开关.UseVisualStyleBackColor = true;
		this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.label11.ForeColor = System.Drawing.Color.Red;
		this.label11.Location = new System.Drawing.Point(5, 5);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(595, 26);
		this.label11.TabIndex = 171;
		this.label11.Text = "谣言刷新的天地星配置如下：当前BOSS名字写“天星”，所有的天星即可共享相同配置，地星写“地星”也是一样";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.label10.ForeColor = System.Drawing.Color.Red;
		this.label10.Location = new System.Drawing.Point(480, 434);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(410, 33);
		this.label10.TabIndex = 170;
		this.label10.Text = "切勿修改BOSS对话导致功能失效";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label9.Location = new System.Drawing.Point(14, 90);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(106, 23);
		this.label9.TabIndex = 168;
		this.label9.Text = "点击对话关键词";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_关键词.Location = new System.Drawing.Point(126, 90);
		this.修改_关键词.Name = "修改_关键词";
		this.修改_关键词.Size = new System.Drawing.Size(277, 23);
		this.修改_关键词.TabIndex = 169;
		this.label7.Location = new System.Drawing.Point(14, 63);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(106, 23);
		this.label7.TabIndex = 166;
		this.label7.Text = "战斗中boss名字";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_战斗名字.Location = new System.Drawing.Point(126, 63);
		this.修改_战斗名字.Name = "修改_战斗名字";
		this.修改_战斗名字.Size = new System.Drawing.Size(277, 23);
		this.修改_战斗名字.TabIndex = 167;
		this.BOSS挑战提示组件.SetToolTip(this.修改_战斗名字, "当前boss名字：黑熊妖皇 对应 战斗中BOSS名字：妖皇小弟\r\n当前boss名字：天煞狂狮 对应 战斗中BOSS名字：北冥幼狮\r\n当前boss名字：灭天血刺 对应 战斗中BOSS名字：玄天刺猬\r\n当前boss名字：血炼魔猪 对应 战斗中BOSS名字：小猪猡");
		this.label5.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.label5.Location = new System.Drawing.Point(128, 256);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(276, 23);
		this.label5.TabIndex = 165;
		this.label5.Text = "挑战消耗为道具时该道具必须是空礼包道具";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.groupBox1.Controls.Add(this.修改_掉落几率);
		this.groupBox1.Controls.Add(this.修改_最高掉落数量);
		this.groupBox1.Controls.Add(this.修改_最低掉落数量);
		this.groupBox1.Controls.Add(this.label19);
		this.groupBox1.Controls.Add(this.label20);
		this.groupBox1.Controls.Add(this.修改_掉落奖励类型);
		this.groupBox1.Controls.Add(this.修改_掉落奖励内容);
		this.groupBox1.Controls.Add(this.修改_添加掉落奖励按钮);
		this.groupBox1.Controls.Add(this.修改_掉落奖励列表);
		this.groupBox1.Location = new System.Drawing.Point(417, 43);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(536, 400);
		this.groupBox1.TabIndex = 164;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "配置BOSS掉落列表";
		this.修改_掉落几率.Location = new System.Drawing.Point(408, 47);
		this.修改_掉落几率.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_掉落几率.Name = "修改_掉落几率";
		this.修改_掉落几率.Size = new System.Drawing.Size(60, 23);
		this.修改_掉落几率.TabIndex = 166;
		this.修改_最高掉落数量.Location = new System.Drawing.Point(317, 47);
		this.修改_最高掉落数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最高掉落数量.Name = "修改_最高掉落数量";
		this.修改_最高掉落数量.Size = new System.Drawing.Size(80, 23);
		this.修改_最高掉落数量.TabIndex = 157;
		this.修改_最低掉落数量.Location = new System.Drawing.Point(212, 48);
		this.修改_最低掉落数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最低掉落数量.Name = "修改_最低掉落数量";
		this.修改_最低掉落数量.Size = new System.Drawing.Size(80, 23);
		this.修改_最低掉落数量.TabIndex = 137;
		this.label19.BackColor = System.Drawing.Color.Transparent;
		this.label19.Location = new System.Drawing.Point(11, 21);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(521, 23);
		this.label19.TabIndex = 138;
		this.label19.Text = "掉落类型(道具则写道具名字)            最低掉落数量        最高掉落数量    几率(1-10000)";
		this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label20.BackColor = System.Drawing.Color.Transparent;
		this.label20.Location = new System.Drawing.Point(293, 47);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(23, 23);
		this.label20.TabIndex = 140;
		this.label20.Text = "—";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_掉落奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.修改_掉落奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.修改_掉落奖励类型.FormattingEnabled = true;
		this.修改_掉落奖励类型.Items.AddRange(new object[11]
		{
			"金元宝", "银元宝", "金钱", "代金券", "声望", "累充点", "南极点", "奇宝点", "灵气值", "道具",
			"道行"
		});
		this.修改_掉落奖励类型.Location = new System.Drawing.Point(11, 47);
		this.修改_掉落奖励类型.Name = "修改_掉落奖励类型";
		this.修改_掉落奖励类型.Size = new System.Drawing.Size(80, 25);
		this.修改_掉落奖励类型.TabIndex = 141;
		this.修改_掉落奖励类型.SelectedIndexChanged += new System.EventHandler(修改_掉落奖励类型_SelectedIndexChanged);
		this.修改_掉落奖励内容.Location = new System.Drawing.Point(97, 47);
		this.修改_掉落奖励内容.Name = "修改_掉落奖励内容";
		this.修改_掉落奖励内容.Size = new System.Drawing.Size(100, 23);
		this.修改_掉落奖励内容.TabIndex = 142;
		this.修改_添加掉落奖励按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.修改_添加掉落奖励按钮.Location = new System.Drawing.Point(477, 45);
		this.修改_添加掉落奖励按钮.Name = "修改_添加掉落奖励按钮";
		this.修改_添加掉落奖励按钮.Size = new System.Drawing.Size(50, 23);
		this.修改_添加掉落奖励按钮.TabIndex = 143;
		this.修改_添加掉落奖励按钮.Text = "添加";
		this.修改_添加掉落奖励按钮.UseVisualStyleBackColor = true;
		this.修改_添加掉落奖励按钮.Click += new System.EventHandler(修改_添加掉落奖励按钮_Click);
		this.修改_掉落奖励列表.AllowUserToAddRows = false;
		this.修改_掉落奖励列表.AllowUserToDeleteRows = false;
		this.修改_掉落奖励列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.修改_掉落奖励列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
		this.修改_掉落奖励列表.BackgroundColor = System.Drawing.Color.White;
		this.修改_掉落奖励列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.修改_掉落奖励列表.Columns.AddRange(this.掉落类型, this.掉落内容, this.最低掉落, this.最高掉落, this.掉落几率, this.Is谣言);
		this.修改_掉落奖励列表.Location = new System.Drawing.Point(11, 83);
		this.修改_掉落奖励列表.MultiSelect = false;
		this.修改_掉落奖励列表.Name = "修改_掉落奖励列表";
		this.修改_掉落奖励列表.RowHeadersVisible = false;
		this.修改_掉落奖励列表.RowTemplate.Height = 25;
		this.修改_掉落奖励列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.修改_掉落奖励列表.Size = new System.Drawing.Size(516, 307);
		this.修改_掉落奖励列表.TabIndex = 144;
		this.掉落类型.HeaderText = "掉落类型";
		this.掉落类型.Items.AddRange("金元宝", "银元宝", "金钱", "代金券", "声望", "累充点", "南极点", "道具", "道行");
		this.掉落类型.MinimumWidth = 90;
		this.掉落类型.Name = "掉落类型";
		this.掉落类型.Width = 90;
		this.掉落内容.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.掉落内容.HeaderText = "掉落内容";
		this.掉落内容.MinimumWidth = 90;
		this.掉落内容.Name = "掉落内容";
		this.掉落内容.Width = 90;
		this.最低掉落.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.最低掉落.HeaderText = "最低掉落";
		this.最低掉落.MinimumWidth = 90;
		this.最低掉落.Name = "最低掉落";
		this.最低掉落.Width = 90;
		this.最高掉落.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.最高掉落.HeaderText = "最高掉落";
		this.最高掉落.MinimumWidth = 90;
		this.最高掉落.Name = "最高掉落";
		this.最高掉落.Width = 90;
		this.掉落几率.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.掉落几率.HeaderText = "掉落几率";
		this.掉落几率.MinimumWidth = 100;
		this.掉落几率.Name = "掉落几率";
		this.Is谣言.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.Is谣言.FalseValue = "false";
		this.Is谣言.HeaderText = "Is谣言";
		this.Is谣言.MinimumWidth = 80;
		this.Is谣言.Name = "Is谣言";
		this.Is谣言.TrueValue = "true";
		this.Is谣言.Width = 80;
		this.修改_只掉落队长.AutoSize = true;
		this.修改_只掉落队长.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_只掉落队长.Location = new System.Drawing.Point(850, 8);
		this.修改_只掉落队长.Name = "修改_只掉落队长";
		this.修改_只掉落队长.Size = new System.Drawing.Size(106, 23);
		this.修改_只掉落队长.TabIndex = 163;
		this.修改_只掉落队长.Text = "只掉落给队长";
		this.修改_只掉落队长.UseVisualStyleBackColor = true;
		this.label4.BackColor = System.Drawing.Color.Transparent;
		this.label4.Location = new System.Drawing.Point(130, 401);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(87, 23);
		this.label4.TabIndex = 161;
		this.label4.Text = "挑战需要称号2";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_指定称号2.Location = new System.Drawing.Point(217, 401);
		this.修改_指定称号2.Name = "修改_指定称号2";
		this.修改_指定称号2.Size = new System.Drawing.Size(187, 23);
		this.修改_指定称号2.TabIndex = 162;
		this.修改_挑战消耗数量.Location = new System.Drawing.Point(319, 230);
		this.修改_挑战消耗数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_挑战消耗数量.Name = "修改_挑战消耗数量";
		this.修改_挑战消耗数量.Size = new System.Drawing.Size(84, 23);
		this.修改_挑战消耗数量.TabIndex = 160;
		this.修改_挑战消耗内容.Location = new System.Drawing.Point(215, 230);
		this.修改_挑战消耗内容.Name = "修改_挑战消耗内容";
		this.修改_挑战消耗内容.Size = new System.Drawing.Size(98, 23);
		this.修改_挑战消耗内容.TabIndex = 159;
		this.修改_挑战消耗内容.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.修改_挑战消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.修改_挑战消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.修改_挑战消耗类型.FormattingEnabled = true;
		this.修改_挑战消耗类型.Items.AddRange(new object[11]
		{
			"无", "道行", "声望", "战绩", "金元宝", "银元宝", "金钱", "累充点", "南极点", "体力",
			"道具"
		});
		this.修改_挑战消耗类型.Location = new System.Drawing.Point(129, 229);
		this.修改_挑战消耗类型.Name = "修改_挑战消耗类型";
		this.修改_挑战消耗类型.Size = new System.Drawing.Size(80, 25);
		this.修改_挑战消耗类型.TabIndex = 158;
		this.修改_挑战消耗开关.AutoSize = true;
		this.修改_挑战消耗开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_挑战消耗开关.Location = new System.Drawing.Point(18, 230);
		this.修改_挑战消耗开关.Name = "修改_挑战消耗开关";
		this.修改_挑战消耗开关.Size = new System.Drawing.Size(106, 23);
		this.修改_挑战消耗开关.TabIndex = 157;
		this.修改_挑战消耗开关.Text = "挑战消耗开关";
		this.修改_挑战消耗开关.UseVisualStyleBackColor = true;
		this.修改_补充消耗价格.Location = new System.Drawing.Point(319, 201);
		this.修改_补充消耗价格.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_补充消耗价格.Name = "修改_补充消耗价格";
		this.修改_补充消耗价格.Size = new System.Drawing.Size(84, 23);
		this.修改_补充消耗价格.TabIndex = 156;
		this.修改_补充消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.修改_补充消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.修改_补充消耗类型.FormattingEnabled = true;
		this.修改_补充消耗类型.Items.AddRange(new object[6] { "无", "金元宝", "银元宝", "金钱", "声望", "体力" });
		this.修改_补充消耗类型.Location = new System.Drawing.Point(215, 200);
		this.修改_补充消耗类型.Name = "修改_补充消耗类型";
		this.修改_补充消耗类型.Size = new System.Drawing.Size(98, 25);
		this.修改_补充消耗类型.TabIndex = 155;
		this.label3.Location = new System.Drawing.Point(129, 201);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(80, 23);
		this.label3.TabIndex = 154;
		this.label3.Text = "补充消耗类型";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_击杀补充开关.AutoSize = true;
		this.修改_击杀补充开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_击杀补充开关.Location = new System.Drawing.Point(18, 201);
		this.修改_击杀补充开关.Name = "修改_击杀补充开关";
		this.修改_击杀补充开关.Size = new System.Drawing.Size(106, 23);
		this.修改_击杀补充开关.TabIndex = 153;
		this.修改_击杀补充开关.Text = "击杀次数补充";
		this.修改_击杀补充开关.UseVisualStyleBackColor = true;
		this.修改_每日最多击杀次数.Location = new System.Drawing.Point(215, 172);
		this.修改_每日最多击杀次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_每日最多击杀次数.Name = "修改_每日最多击杀次数";
		this.修改_每日最多击杀次数.Size = new System.Drawing.Size(98, 23);
		this.修改_每日最多击杀次数.TabIndex = 152;
		this.label2.Location = new System.Drawing.Point(129, 172);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(80, 23);
		this.label2.TabIndex = 151;
		this.label2.Text = "每日最多击杀";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_限制每日击杀开关.AutoSize = true;
		this.修改_限制每日击杀开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_限制每日击杀开关.Location = new System.Drawing.Point(18, 172);
		this.修改_限制每日击杀开关.Name = "修改_限制每日击杀开关";
		this.修改_限制每日击杀开关.Size = new System.Drawing.Size(106, 23);
		this.修改_限制每日击杀开关.TabIndex = 150;
		this.修改_限制每日击杀开关.Text = "限制每日击杀";
		this.修改_限制每日击杀开关.UseVisualStyleBackColor = true;
		this.修改_限制组队开关.AutoSize = true;
		this.修改_限制组队开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_限制组队开关.Location = new System.Drawing.Point(14, 116);
		this.修改_限制组队开关.Name = "修改_限制组队开关";
		this.修改_限制组队开关.Size = new System.Drawing.Size(106, 23);
		this.修改_限制组队开关.TabIndex = 149;
		this.修改_限制组队开关.Text = "限制组队挑战";
		this.修改_限制组队开关.UseVisualStyleBackColor = true;
		this.label1.Location = new System.Drawing.Point(18, 143);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(80, 23);
		this.label1.TabIndex = 147;
		this.label1.Text = "BOSS对话";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_对话文本.Location = new System.Drawing.Point(99, 143);
		this.修改_对话文本.Name = "修改_对话文本";
		this.修改_对话文本.Size = new System.Drawing.Size(304, 23);
		this.修改_对话文本.TabIndex = 148;
		this.修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_取消按钮.Location = new System.Drawing.Point(226, 430);
		this.修改_取消按钮.Name = "修改_取消按钮";
		this.修改_取消按钮.Size = new System.Drawing.Size(100, 30);
		this.修改_取消按钮.TabIndex = 146;
		this.修改_取消按钮.Text = "取    消";
		this.修改_取消按钮.UseVisualStyleBackColor = true;
		this.修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_确定按钮.Location = new System.Drawing.Point(109, 430);
		this.修改_确定按钮.Name = "修改_确定按钮";
		this.修改_确定按钮.Size = new System.Drawing.Size(100, 30);
		this.修改_确定按钮.TabIndex = 145;
		this.修改_确定按钮.Text = "修     改";
		this.修改_确定按钮.UseVisualStyleBackColor = true;
		this.修改_掉落奖励开关.AutoSize = true;
		this.修改_掉落奖励开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_掉落奖励开关.Location = new System.Drawing.Point(734, 8);
		this.修改_掉落奖励开关.Name = "修改_掉落奖励开关";
		this.修改_掉落奖励开关.Size = new System.Drawing.Size(106, 23);
		this.修改_掉落奖励开关.TabIndex = 126;
		this.修改_掉落奖励开关.Text = "掉落奖励开关";
		this.修改_掉落奖励开关.UseVisualStyleBackColor = true;
		this.label14.BackColor = System.Drawing.Color.Transparent;
		this.label14.Location = new System.Drawing.Point(129, 375);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(87, 23);
		this.label14.TabIndex = 124;
		this.label14.Text = "挑战需要称号1";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_指定称号1.Location = new System.Drawing.Point(216, 375);
		this.修改_指定称号1.Name = "修改_指定称号1";
		this.修改_指定称号1.Size = new System.Drawing.Size(187, 23);
		this.修改_指定称号1.TabIndex = 125;
		this.修改_限制称号开关.AutoSize = true;
		this.修改_限制称号开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_限制称号开关.Location = new System.Drawing.Point(18, 375);
		this.修改_限制称号开关.Name = "修改_限制称号开关";
		this.修改_限制称号开关.Size = new System.Drawing.Size(106, 23);
		this.修改_限制称号开关.TabIndex = 123;
		this.修改_限制称号开关.Text = "限制称号开关";
		this.修改_限制称号开关.UseVisualStyleBackColor = true;
		this.修改_最高道行.Location = new System.Drawing.Point(216, 316);
		this.修改_最高道行.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最高道行.Name = "修改_最高道行";
		this.修改_最高道行.Size = new System.Drawing.Size(60, 23);
		this.修改_最高道行.TabIndex = 122;
		this.label12.BackColor = System.Drawing.Color.Transparent;
		this.label12.Location = new System.Drawing.Point(193, 316);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(110, 23);
		this.label12.TabIndex = 121;
		this.label12.Text = "—                  年";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_最低道行.Location = new System.Drawing.Point(130, 316);
		this.修改_最低道行.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最低道行.Name = "修改_最低道行";
		this.修改_最低道行.Size = new System.Drawing.Size(60, 23);
		this.修改_最低道行.TabIndex = 120;
		this.修改_限制道行开关.AutoSize = true;
		this.修改_限制道行开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_限制道行开关.Location = new System.Drawing.Point(18, 316);
		this.修改_限制道行开关.Name = "修改_限制道行开关";
		this.修改_限制道行开关.Size = new System.Drawing.Size(106, 23);
		this.修改_限制道行开关.TabIndex = 119;
		this.修改_限制道行开关.Text = "限制道行开关";
		this.修改_限制道行开关.UseVisualStyleBackColor = true;
		this.修改_最高等级.Location = new System.Drawing.Point(216, 286);
		this.修改_最高等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最高等级.Name = "修改_最高等级";
		this.修改_最高等级.Size = new System.Drawing.Size(60, 23);
		this.修改_最高等级.TabIndex = 118;
		this.label13.BackColor = System.Drawing.Color.Transparent;
		this.label13.Location = new System.Drawing.Point(193, 286);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(110, 23);
		this.label13.TabIndex = 117;
		this.label13.Text = "—                  级";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_最低等级.Location = new System.Drawing.Point(130, 286);
		this.修改_最低等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_最低等级.Name = "修改_最低等级";
		this.修改_最低等级.Size = new System.Drawing.Size(60, 23);
		this.修改_最低等级.TabIndex = 116;
		this.修改_限制等级开关.AutoSize = true;
		this.修改_限制等级开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_限制等级开关.Location = new System.Drawing.Point(18, 286);
		this.修改_限制等级开关.Name = "修改_限制等级开关";
		this.修改_限制等级开关.Size = new System.Drawing.Size(106, 23);
		this.修改_限制等级开关.TabIndex = 115;
		this.修改_限制等级开关.Text = "限制等级开关";
		this.修改_限制等级开关.UseVisualStyleBackColor = true;
		this.label8.Location = new System.Drawing.Point(14, 37);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(94, 23);
		this.label8.TabIndex = 89;
		this.label8.Text = "当前boss名字";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.修改_名字.Location = new System.Drawing.Point(109, 37);
		this.修改_名字.Name = "修改_名字";
		this.修改_名字.Size = new System.Drawing.Size(108, 23);
		this.修改_名字.TabIndex = 90;
		this.label6.ForeColor = System.Drawing.Color.Red;
		this.label6.Location = new System.Drawing.Point(567, 8);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(410, 41);
		this.label6.TabIndex = 166;
		this.label6.Text = "限制挑战的BOSS的名字和战斗中BOSS的名字要一致\r\n否则可能会出现挑战限制无效或者掉落无效";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(984, 561);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.修改窗口);
		base.Controls.Add(this.超级boss_boss列表);
		base.Controls.Add(this.超级boss_打开新增窗口按钮);
		base.Controls.Add(this.超级boss_双倍击杀开关);
		base.Controls.Add(this.超级boss_开关);
		base.Controls.Add(this.超级boss_重载按钮);
		base.Controls.Add(this.超级boss_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "BOSS挑战配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "BOSS挑战配置窗口";
		base.Load += new System.EventHandler(BOSS挑战配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.超级boss_boss列表).EndInit();
		this.修改窗口.ResumeLayout(false);
		this.修改窗口.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_最高活跃).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低活跃).EndInit();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_掉落几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高掉落数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低掉落数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_掉落奖励列表).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_挑战消耗数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_补充消耗价格).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_每日最多击杀次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高道行).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低道行).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最高等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_最低等级).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
