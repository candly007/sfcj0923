using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 百炼合成配置窗口 : Form
{
	private static 百炼合成配置窗口 i;

	private IContainer components;

	private GroupBox groupBox1;

	private Label label1;

	private TextBox 百炼_npc对话;

	private NumericUpDown 百炼_形象;

	private Label label9;

	private ComboBox 百炼_朝向;

	private Label label8;

	private NumericUpDown 百炼_坐标Y;

	private NumericUpDown 百炼_坐标X;

	private Label label7;

	private Label label5;

	private TextBox 百炼_npc称号;

	private Label label4;

	private TextBox 百炼_npc名字;

	private CheckBox 百炼_开关;

	private Button 百炼_重载按钮;

	private Button 百炼_保存按钮;

	private TextBox textBox11;

	private NumericUpDown 百炼_合成几率;

	private NumericUpDown 百炼_合成数量;

	private TextBox textBox3;

	private NumericUpDown 百炼_配方材料1数量;

	private ComboBox 百炼_提交格子数量;

	private TextBox textBox2;

	private TextBox 百炼_道具名字;

	private TextBox 地狱道_名字;

	private TextBox 百炼_配方材料1;

	private TextBox textBox10;

	private TextBox textBox36;

	private TextBox 百炼_配方材料10;

	private TextBox textBox38;

	private NumericUpDown 百炼_配方材料10数量;

	private TextBox textBox39;

	private TextBox 百炼_配方材料5;

	private TextBox textBox41;

	private NumericUpDown 百炼_配方材料5数量;

	private TextBox textBox30;

	private TextBox 百炼_配方材料9;

	private TextBox textBox32;

	private NumericUpDown 百炼_配方材料9数量;

	private TextBox textBox33;

	private TextBox 百炼_配方材料4;

	private TextBox textBox35;

	private NumericUpDown 百炼_配方材料4数量;

	private TextBox textBox24;

	private TextBox 百炼_配方材料8;

	private TextBox textBox26;

	private NumericUpDown 百炼_配方材料8数量;

	private TextBox textBox27;

	private TextBox 百炼_配方材料3;

	private TextBox textBox29;

	private NumericUpDown 百炼_配方材料3数量;

	private TextBox textBox18;

	private TextBox 百炼_配方材料7;

	private TextBox textBox20;

	private NumericUpDown 百炼_配方材料7数量;

	private TextBox textBox21;

	private TextBox 百炼_配方材料2;

	private TextBox textBox23;

	private NumericUpDown 百炼_配方材料2数量;

	private TextBox textBox15;

	private TextBox 百炼_配方材料6;

	private TextBox textBox17;

	private NumericUpDown 百炼_配方材料6数量;

	private TextBox textBox14;

	private DataGridView 百炼_合成列表;

	private Button 百炼_打开新增按钮;

	private Panel 修改窗口;

	private Button 修改_取消按钮;

	private Button 修改_确定按钮;

	private Label label3;

	private TextBox textBox1;

	private TextBox 百炼_对话文本;

	private TextBox textBox4;

	private NumericUpDown 百炼_权重值;

	private Label label2;

	private DataGridViewTextBoxColumn 权重值;

	private DataGridViewTextBoxColumn 道具名字;

	private DataGridViewTextBoxColumn 合成数量;

	private DataGridViewTextBoxColumn 几率;

	private DataGridViewTextBoxColumn 格子;

	private DataGridViewTextBoxColumn 合成配方材料;

	private CheckBox 百炼_可叠加;

	public static 百炼合成配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 百炼合成配置窗口();
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

	public 百炼合成配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 百炼合成配置窗口_Load(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			百炼_合成列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(修改事件回调, 删除事件回调);
			修改_取消按钮.Click += delegate
			{
				修改窗口.Visible = false;
			};
			修改_确定按钮.Click += 确定修改事件回调;
			Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
			全局变量类 obj = Singleton<全局变量类>.I;
			obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
			百炼_重载按钮_Click(sender, e);
		}
	}

	private void 百炼_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 34, JsonConvert.SerializeObject(Singleton<全局变量类>.I.百炼功能配置, Formatting.Indented));
		}
	}

	private void 百炼_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 34);
		}
	}

	private void 百炼_打开新增按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			百炼_道具名字.ReadOnly = false;
			修改_确定按钮.Text = "新     增";
			百炼_道具名字.Text = string.Empty;
			修改窗口.Visible = true;
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 34)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			百炼_开关.Checked = Singleton<全局变量类>.I.百炼功能配置.功能开关;
			百炼_npc名字.Text = Singleton<全局变量类>.I.百炼功能配置.NPC数据.npc名字;
			百炼_npc称号.Text = Singleton<全局变量类>.I.百炼功能配置.NPC数据.npc称号;
			百炼_坐标X.Value = Singleton<全局变量类>.I.百炼功能配置.NPC数据.坐标.X;
			百炼_坐标Y.Value = Singleton<全局变量类>.I.百炼功能配置.NPC数据.坐标.Y;
			百炼_朝向.Text = $"{(AllEnums.朝向Type)Singleton<全局变量类>.I.百炼功能配置.NPC数据.朝向}";
			百炼_形象.Value = Singleton<全局变量类>.I.百炼功能配置.NPC数据.npc形象;
			百炼_npc对话.Text = Singleton<全局变量类>.I.百炼功能配置.对话介绍;
			百炼_合成列表.Rows.Clear();
			foreach (百炼列表类 value in Singleton<全局变量类>.I.百炼功能配置.百炼列表.Values)
			{
				string text = string.Empty;
				for (int i = 0; i < value.提交数组.Length; i++)
				{
					if (!string.IsNullOrWhiteSpace(value.提交数组[i]))
					{
						text = text + ((i == 0) ? string.Empty : "、") + value.提交数组[i];
					}
				}
				百炼_合成列表.Rows.Add(value.权重值, value.炼化道具, value.炼化数量, value.炼化几率, value.提交格子数量, text);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.百炼功能配置.功能开关 = 百炼_开关.Checked;
			Singleton<全局变量类>.I.百炼功能配置.NPC数据.npc名字 = 百炼_npc名字.Text;
			Singleton<全局变量类>.I.百炼功能配置.NPC数据.npc称号 = 百炼_npc称号.Text;
			Singleton<全局变量类>.I.百炼功能配置.NPC数据.坐标.X = (short)百炼_坐标X.Value;
			Singleton<全局变量类>.I.百炼功能配置.NPC数据.坐标.Y = (short)百炼_坐标Y.Value;
			Singleton<全局变量类>.I.百炼功能配置.NPC数据.朝向 = (short)Enum.Parse<AllEnums.朝向Type>(百炼_朝向.Text);
			Singleton<全局变量类>.I.百炼功能配置.NPC数据.npc形象 = (int)百炼_形象.Value;
			Singleton<全局变量类>.I.百炼功能配置.对话介绍 = 百炼_npc对话.Text;
		}
	}

	private void 修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 百炼_合成列表.CurrentRow == null)
		{
			return;
		}
		int index = 百炼_合成列表.CurrentRow.Index;
		if (index < 0)
		{
			return;
		}
		DataGridViewCellCollection cells = 百炼_合成列表.Rows[index].Cells;
		if (Singleton<全局变量类>.I.百炼功能配置.百炼列表.TryGetValue(cells[1].Value.ToString(), out 百炼列表类 value))
		{
			修改_确定按钮.Text = "修     改";
			百炼_道具名字.ReadOnly = true;
			百炼_道具名字.Text = value.炼化道具;
			百炼_可叠加.Checked = value.Is叠加道具;
			百炼_权重值.Value = value.权重值;
			百炼_合成数量.Value = value.炼化数量;
			百炼_合成几率.Value = value.炼化几率;
			百炼_提交格子数量.Text = value.提交格子数量.ToString();
			if (value.提交数组[0] == null)
			{
				value.提交数组[0] = string.Empty;
			}
			string[] array = value.提交数组[0].Split("-");
			百炼_配方材料1.Text = ((array.Length == 2) ? array[0] : string.Empty);
			百炼_配方材料1数量.Value = ((array.Length == 2) ? int.Parse(array[1]) : 0);
			if (value.提交数组[1] == null)
			{
				value.提交数组[1] = string.Empty;
			}
			array = value.提交数组[1].Split("-");
			百炼_配方材料2.Text = ((array.Length == 2) ? array[0] : string.Empty);
			百炼_配方材料2数量.Value = ((array.Length == 2) ? int.Parse(array[1]) : 0);
			if (value.提交数组[2] == null)
			{
				value.提交数组[2] = string.Empty;
			}
			array = value.提交数组[2].Split("-");
			百炼_配方材料3.Text = ((array.Length == 2) ? array[0] : string.Empty);
			百炼_配方材料3数量.Value = ((array.Length == 2) ? int.Parse(array[1]) : 0);
			if (value.提交数组[3] == null)
			{
				value.提交数组[3] = string.Empty;
			}
			array = value.提交数组[3].Split("-");
			百炼_配方材料4.Text = ((array.Length == 2) ? array[0] : string.Empty);
			百炼_配方材料4数量.Value = ((array.Length == 2) ? int.Parse(array[1]) : 0);
			if (value.提交数组[4] == null)
			{
				value.提交数组[4] = string.Empty;
			}
			array = value.提交数组[4].Split("-");
			百炼_配方材料5.Text = ((array.Length == 2) ? array[0] : string.Empty);
			百炼_配方材料5数量.Value = ((array.Length == 2) ? int.Parse(array[1]) : 0);
			if (value.提交数组[5] == null)
			{
				value.提交数组[5] = string.Empty;
			}
			array = value.提交数组[5].Split("-");
			百炼_配方材料6.Text = ((array.Length == 2) ? array[0] : string.Empty);
			百炼_配方材料6数量.Value = ((array.Length == 2) ? int.Parse(array[1]) : 0);
			if (value.提交数组[6] == null)
			{
				value.提交数组[6] = string.Empty;
			}
			array = value.提交数组[6].Split("-");
			百炼_配方材料7.Text = ((array.Length == 2) ? array[0] : string.Empty);
			百炼_配方材料7数量.Value = ((array.Length == 2) ? int.Parse(array[1]) : 0);
			if (value.提交数组[7] == null)
			{
				value.提交数组[7] = string.Empty;
			}
			array = value.提交数组[7].Split("-");
			百炼_配方材料8.Text = ((array.Length == 2) ? array[0] : string.Empty);
			百炼_配方材料8数量.Value = ((array.Length == 2) ? int.Parse(array[1]) : 0);
			if (value.提交数组[8] == null)
			{
				value.提交数组[8] = string.Empty;
			}
			array = value.提交数组[8].Split("-");
			百炼_配方材料9.Text = ((array.Length == 2) ? array[0] : string.Empty);
			百炼_配方材料9数量.Value = ((array.Length == 2) ? int.Parse(array[1]) : 0);
			if (value.提交数组[9] == null)
			{
				value.提交数组[9] = string.Empty;
			}
			array = value.提交数组[9].Split("-");
			百炼_配方材料10.Text = ((array.Length == 2) ? array[0] : string.Empty);
			百炼_配方材料10数量.Value = ((array.Length == 2) ? int.Parse(array[1]) : 0);
			百炼_对话文本.Text = value.对话文本;
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
			百炼合成_新增事件();
		}
		else
		{
			if (!Singleton<全局变量类>.I.百炼功能配置.百炼列表.TryGetValue(百炼_道具名字.Text, out 百炼列表类 value))
			{
				return;
			}
			value.Is叠加道具 = 百炼_可叠加.Checked;
			value.权重值 = (int)百炼_权重值.Value;
			value.炼化数量 = (int)百炼_合成数量.Value;
			value.炼化几率 = (int)百炼_合成几率.Value;
			int.TryParse(百炼_提交格子数量.Text, out value.提交格子数量);
			value.提交数组[0] = ((value.提交格子数量 >= 1) ? $"{百炼_配方材料1.Text}-{百炼_配方材料1数量.Value}" : string.Empty);
			value.提交数组[1] = ((value.提交格子数量 >= 2) ? $"{百炼_配方材料2.Text}-{百炼_配方材料2数量.Value}" : string.Empty);
			value.提交数组[2] = ((value.提交格子数量 >= 3) ? $"{百炼_配方材料3.Text}-{百炼_配方材料3数量.Value}" : string.Empty);
			value.提交数组[3] = ((value.提交格子数量 >= 4) ? $"{百炼_配方材料4.Text}-{百炼_配方材料4数量.Value}" : string.Empty);
			value.提交数组[4] = ((value.提交格子数量 >= 5) ? $"{百炼_配方材料5.Text}-{百炼_配方材料5数量.Value}" : string.Empty);
			value.提交数组[5] = ((value.提交格子数量 >= 6) ? $"{百炼_配方材料6.Text}-{百炼_配方材料6数量.Value}" : string.Empty);
			value.提交数组[6] = ((value.提交格子数量 >= 7) ? $"{百炼_配方材料7.Text}-{百炼_配方材料7数量.Value}" : string.Empty);
			value.提交数组[7] = ((value.提交格子数量 >= 8) ? $"{百炼_配方材料8.Text}-{百炼_配方材料8数量.Value}" : string.Empty);
			value.提交数组[8] = ((value.提交格子数量 >= 9) ? $"{百炼_配方材料9.Text}-{百炼_配方材料9数量.Value}" : string.Empty);
			value.提交数组[9] = ((value.提交格子数量 >= 10) ? $"{百炼_配方材料10.Text}-{百炼_配方材料10数量.Value}" : string.Empty);
			value.对话文本 = 百炼_对话文本.Text;
			修改窗口.Visible = false;
			if (百炼_合成列表.CurrentRow == null)
			{
				return;
			}
			int index = 百炼_合成列表.CurrentRow.Index;
			if (index < 0)
			{
				return;
			}
			DataGridViewCellCollection cells = 百炼_合成列表.Rows[index].Cells;
			string text = string.Empty;
			for (int i = 0; i < value.提交数组.Length; i++)
			{
				if (!string.IsNullOrWhiteSpace(value.提交数组[i]))
				{
					text = text + ((i == 0) ? string.Empty : "、") + value.提交数组[i];
				}
			}
			cells[0].Value = value.权重值;
			cells[2].Value = value.炼化数量;
			cells[3].Value = value.炼化几率;
			cells[4].Value = value.提交格子数量;
			cells[5].Value = text;
			MessageBox.Show("[" + 百炼_道具名字.Text + "]的配置已经修改，请及时点击保存配置按钮更新服务端配置！");
		}
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 百炼_合成列表.CurrentRow == null)
		{
			return;
		}
		int index = 百炼_合成列表.CurrentRow.Index;
		if (index >= 0)
		{
			string text = 百炼_合成列表.Rows[index].Cells[1].Value.ToString();
			if (Singleton<全局变量类>.I.百炼功能配置.百炼列表.ContainsKey(text))
			{
				Singleton<全局变量类>.I.百炼功能配置.百炼列表.TryRemove(text, out 百炼列表类 _);
				MessageBox.Show("[" + text + "]已从列表中删除，请及时点击保存配置按钮更新服务端配置！");
				百炼_合成列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 百炼合成_新增事件()
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(百炼_道具名字.Text))
		{
			MessageBox.Show("请输入要炼化合成的道具！");
			return;
		}
		if (百炼_合成数量.Value <= 0m)
		{
			百炼_合成数量.Value = 1m;
		}
		if (string.IsNullOrWhiteSpace(百炼_提交格子数量.Text))
		{
			MessageBox.Show("请选择炼化【" + 百炼_道具名字.Text + "】需要提交的配方格子数量！");
			return;
		}
		if (Singleton<全局变量类>.I.百炼功能配置.百炼列表.ContainsKey(百炼_道具名字.Text))
		{
			MessageBox.Show("列表中已经存在【" + 百炼_道具名字.Text + "】，无法重复添加！");
			return;
		}
		int num = int.Parse(百炼_提交格子数量.Text);
		if (num <= 0)
		{
			return;
		}
		if (num >= 1 && (string.IsNullOrWhiteSpace(百炼_配方材料1.Text) || 百炼_配方材料1数量.Value <= 0m))
		{
			MessageBox.Show("请输入正确合规的百炼_配方材料1的材料名字和所需的数量！");
			return;
		}
		if (num >= 2 && (string.IsNullOrWhiteSpace(百炼_配方材料2.Text) || 百炼_配方材料2数量.Value <= 0m))
		{
			MessageBox.Show("请输入正确合规的百炼_配方材料2的材料名字和所需的数量！");
			return;
		}
		if (num >= 3 && (string.IsNullOrWhiteSpace(百炼_配方材料3.Text) || 百炼_配方材料3数量.Value <= 0m))
		{
			MessageBox.Show("请输入正确合规的百炼_配方材料3的材料名字和所需的数量！");
			return;
		}
		if (num >= 4 && (string.IsNullOrWhiteSpace(百炼_配方材料4.Text) || 百炼_配方材料4数量.Value <= 0m))
		{
			MessageBox.Show("请输入正确合规的百炼_配方材料4的材料名字和所需的数量！");
			return;
		}
		if (num >= 5 && (string.IsNullOrWhiteSpace(百炼_配方材料5.Text) || 百炼_配方材料5数量.Value <= 0m))
		{
			MessageBox.Show("请输入正确合规的百炼_配方材料5的材料名字和所需的数量！");
			return;
		}
		if (num >= 6 && (string.IsNullOrWhiteSpace(百炼_配方材料6.Text) || 百炼_配方材料6数量.Value <= 0m))
		{
			MessageBox.Show("请输入正确合规的百炼_配方材料6的材料名字和所需的数量！");
			return;
		}
		if (num >= 7 && (string.IsNullOrWhiteSpace(百炼_配方材料7.Text) || 百炼_配方材料7数量.Value <= 0m))
		{
			MessageBox.Show("请输入正确合规的百炼_配方材料7的材料名字和所需的数量！");
			return;
		}
		if (num >= 8 && (string.IsNullOrWhiteSpace(百炼_配方材料8.Text) || 百炼_配方材料8数量.Value <= 0m))
		{
			MessageBox.Show("请输入正确合规的百炼_配方材料8的材料名字和所需的数量！");
			return;
		}
		if (num >= 9 && (string.IsNullOrWhiteSpace(百炼_配方材料9.Text) || 百炼_配方材料9数量.Value <= 0m))
		{
			MessageBox.Show("请输入正确合规的百炼_配方材料9的材料名字和所需的数量！");
			return;
		}
		if (num >= 10 && (string.IsNullOrWhiteSpace(百炼_配方材料10.Text) || 百炼_配方材料10数量.Value <= 0m))
		{
			MessageBox.Show("请输入正确合规的百炼_配方材料10的材料名字和所需的数量！");
			return;
		}
		百炼列表类 百炼列表类2 = new 百炼列表类
		{
			Is叠加道具 = 百炼_可叠加.Checked,
			权重值 = (int)百炼_权重值.Value,
			炼化道具 = 百炼_道具名字.Text,
			炼化数量 = (int)百炼_合成数量.Value,
			炼化几率 = (int)百炼_合成几率.Value,
			提交格子数量 = num,
			对话文本 = 百炼_对话文本.Text
		};
		百炼列表类2.提交数组[0] = ((百炼列表类2.提交格子数量 >= 1) ? $"{百炼_配方材料1.Text}-{百炼_配方材料1数量.Value}" : string.Empty);
		百炼列表类2.提交数组[1] = ((百炼列表类2.提交格子数量 >= 2) ? $"{百炼_配方材料2.Text}-{百炼_配方材料2数量.Value}" : string.Empty);
		百炼列表类2.提交数组[2] = ((百炼列表类2.提交格子数量 >= 3) ? $"{百炼_配方材料3.Text}-{百炼_配方材料3数量.Value}" : string.Empty);
		百炼列表类2.提交数组[3] = ((百炼列表类2.提交格子数量 >= 4) ? $"{百炼_配方材料4.Text}-{百炼_配方材料4数量.Value}" : string.Empty);
		百炼列表类2.提交数组[4] = ((百炼列表类2.提交格子数量 >= 5) ? $"{百炼_配方材料5.Text}-{百炼_配方材料5数量.Value}" : string.Empty);
		百炼列表类2.提交数组[5] = ((百炼列表类2.提交格子数量 >= 6) ? $"{百炼_配方材料6.Text}-{百炼_配方材料6数量.Value}" : string.Empty);
		百炼列表类2.提交数组[6] = ((百炼列表类2.提交格子数量 >= 7) ? $"{百炼_配方材料7.Text}-{百炼_配方材料7数量.Value}" : string.Empty);
		百炼列表类2.提交数组[7] = ((百炼列表类2.提交格子数量 >= 8) ? $"{百炼_配方材料8.Text}-{百炼_配方材料8数量.Value}" : string.Empty);
		百炼列表类2.提交数组[8] = ((百炼列表类2.提交格子数量 >= 9) ? $"{百炼_配方材料9.Text}-{百炼_配方材料9数量.Value}" : string.Empty);
		百炼列表类2.提交数组[9] = ((百炼列表类2.提交格子数量 >= 10) ? $"{百炼_配方材料10.Text}-{百炼_配方材料10数量.Value}" : string.Empty);
		Singleton<全局变量类>.I.百炼功能配置.百炼列表.TryAdd(百炼列表类2.炼化道具, 百炼列表类2);
		string text = string.Empty;
		for (int i = 0; i < 百炼列表类2.提交数组.Length; i++)
		{
			if (!string.IsNullOrWhiteSpace(百炼列表类2.提交数组[i]))
			{
				text = text + ((i == 0) ? string.Empty : "、") + 百炼列表类2.提交数组[i];
			}
		}
		百炼_合成列表.Rows.Add(百炼列表类2.权重值, 百炼列表类2.炼化道具, 百炼列表类2.炼化数量, 百炼列表类2.炼化几率, 百炼列表类2.提交格子数量, text);
		MessageBox.Show("[" + 百炼列表类2.炼化道具 + "]添加成功");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.百炼合成配置窗口));
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label1 = new System.Windows.Forms.Label();
		this.百炼_npc对话 = new System.Windows.Forms.TextBox();
		this.百炼_形象 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.百炼_朝向 = new System.Windows.Forms.ComboBox();
		this.label8 = new System.Windows.Forms.Label();
		this.百炼_坐标Y = new System.Windows.Forms.NumericUpDown();
		this.百炼_坐标X = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.百炼_npc称号 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.百炼_npc名字 = new System.Windows.Forms.TextBox();
		this.百炼_开关 = new System.Windows.Forms.CheckBox();
		this.百炼_重载按钮 = new System.Windows.Forms.Button();
		this.百炼_保存按钮 = new System.Windows.Forms.Button();
		this.textBox11 = new System.Windows.Forms.TextBox();
		this.百炼_合成几率 = new System.Windows.Forms.NumericUpDown();
		this.百炼_合成数量 = new System.Windows.Forms.NumericUpDown();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料1数量 = new System.Windows.Forms.NumericUpDown();
		this.百炼_提交格子数量 = new System.Windows.Forms.ComboBox();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.百炼_道具名字 = new System.Windows.Forms.TextBox();
		this.地狱道_名字 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料1 = new System.Windows.Forms.TextBox();
		this.textBox10 = new System.Windows.Forms.TextBox();
		this.textBox14 = new System.Windows.Forms.TextBox();
		this.textBox15 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料6 = new System.Windows.Forms.TextBox();
		this.textBox17 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料6数量 = new System.Windows.Forms.NumericUpDown();
		this.textBox18 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料7 = new System.Windows.Forms.TextBox();
		this.textBox20 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料7数量 = new System.Windows.Forms.NumericUpDown();
		this.textBox21 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料2 = new System.Windows.Forms.TextBox();
		this.textBox23 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料2数量 = new System.Windows.Forms.NumericUpDown();
		this.textBox24 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料8 = new System.Windows.Forms.TextBox();
		this.textBox26 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料8数量 = new System.Windows.Forms.NumericUpDown();
		this.textBox27 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料3 = new System.Windows.Forms.TextBox();
		this.textBox29 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料3数量 = new System.Windows.Forms.NumericUpDown();
		this.textBox30 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料9 = new System.Windows.Forms.TextBox();
		this.textBox32 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料9数量 = new System.Windows.Forms.NumericUpDown();
		this.textBox33 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料4 = new System.Windows.Forms.TextBox();
		this.textBox35 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料4数量 = new System.Windows.Forms.NumericUpDown();
		this.textBox36 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料10 = new System.Windows.Forms.TextBox();
		this.textBox38 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料10数量 = new System.Windows.Forms.NumericUpDown();
		this.textBox39 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料5 = new System.Windows.Forms.TextBox();
		this.textBox41 = new System.Windows.Forms.TextBox();
		this.百炼_配方材料5数量 = new System.Windows.Forms.NumericUpDown();
		this.百炼_合成列表 = new System.Windows.Forms.DataGridView();
		this.权重值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.道具名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.合成数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.几率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.格子 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.合成配方材料 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.百炼_打开新增按钮 = new System.Windows.Forms.Button();
		this.修改窗口 = new System.Windows.Forms.Panel();
		this.label2 = new System.Windows.Forms.Label();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.百炼_权重值 = new System.Windows.Forms.NumericUpDown();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.百炼_对话文本 = new System.Windows.Forms.TextBox();
		this.修改_取消按钮 = new System.Windows.Forms.Button();
		this.修改_确定按钮 = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		this.百炼_可叠加 = new System.Windows.Forms.CheckBox();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.百炼_形象).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_坐标Y).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_坐标X).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_合成几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_合成数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料1数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料6数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料7数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料2数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料8数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料3数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料9数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料4数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料10数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料5数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_合成列表).BeginInit();
		this.修改窗口.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.百炼_权重值).BeginInit();
		base.SuspendLayout();
		this.groupBox1.BackColor = System.Drawing.Color.White;
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.百炼_npc对话);
		this.groupBox1.Controls.Add(this.百炼_形象);
		this.groupBox1.Controls.Add(this.label9);
		this.groupBox1.Controls.Add(this.百炼_朝向);
		this.groupBox1.Controls.Add(this.label8);
		this.groupBox1.Controls.Add(this.百炼_坐标Y);
		this.groupBox1.Controls.Add(this.百炼_坐标X);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.百炼_npc称号);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.百炼_npc名字);
		this.groupBox1.Location = new System.Drawing.Point(12, 44);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(776, 80);
		this.groupBox1.TabIndex = 117;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "npc配置";
		this.label1.Location = new System.Drawing.Point(6, 45);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 23);
		this.label1.TabIndex = 113;
		this.label1.Text = "npc对话";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.百炼_npc对话.Location = new System.Drawing.Point(67, 45);
		this.百炼_npc对话.Name = "百炼_npc对话";
		this.百炼_npc对话.Size = new System.Drawing.Size(677, 23);
		this.百炼_npc对话.TabIndex = 114;
		this.百炼_形象.Location = new System.Drawing.Point(644, 17);
		this.百炼_形象.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.百炼_形象.Name = "百炼_形象";
		this.百炼_形象.Size = new System.Drawing.Size(100, 23);
		this.百炼_形象.TabIndex = 112;
		this.label9.BackColor = System.Drawing.Color.Transparent;
		this.label9.Location = new System.Drawing.Point(611, 17);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(32, 23);
		this.label9.TabIndex = 111;
		this.label9.Text = "形象";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.百炼_朝向.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.百炼_朝向.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.百炼_朝向.FormattingEnabled = true;
		this.百炼_朝向.Items.AddRange(new object[8] { "左", "左上", "上", "右上", "右", "右下", "下", "左下" });
		this.百炼_朝向.Location = new System.Drawing.Point(545, 17);
		this.百炼_朝向.Name = "百炼_朝向";
		this.百炼_朝向.Size = new System.Drawing.Size(60, 25);
		this.百炼_朝向.TabIndex = 110;
		this.label8.BackColor = System.Drawing.Color.Transparent;
		this.label8.Location = new System.Drawing.Point(513, 19);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(32, 23);
		this.label8.TabIndex = 109;
		this.label8.Text = "朝向";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.百炼_坐标Y.Location = new System.Drawing.Point(447, 19);
		this.百炼_坐标Y.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.百炼_坐标Y.Name = "百炼_坐标Y";
		this.百炼_坐标Y.Size = new System.Drawing.Size(60, 23);
		this.百炼_坐标Y.TabIndex = 108;
		this.百炼_坐标X.Location = new System.Drawing.Point(370, 19);
		this.百炼_坐标X.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.百炼_坐标X.Name = "百炼_坐标X";
		this.百炼_坐标X.Size = new System.Drawing.Size(60, 23);
		this.百炼_坐标X.TabIndex = 107;
		this.label7.BackColor = System.Drawing.Color.Transparent;
		this.label7.Location = new System.Drawing.Point(330, 19);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(115, 23);
		this.label7.TabIndex = 106;
		this.label7.Text = "坐标X                 Y";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label5.Location = new System.Drawing.Point(168, 19);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(60, 23);
		this.label5.TabIndex = 104;
		this.label5.Text = "npc称号";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.百炼_npc称号.Location = new System.Drawing.Point(229, 19);
		this.百炼_npc称号.Name = "百炼_npc称号";
		this.百炼_npc称号.Size = new System.Drawing.Size(100, 23);
		this.百炼_npc称号.TabIndex = 105;
		this.label4.Location = new System.Drawing.Point(6, 19);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 102;
		this.label4.Text = "npc名字";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.百炼_npc名字.Location = new System.Drawing.Point(67, 19);
		this.百炼_npc名字.Name = "百炼_npc名字";
		this.百炼_npc名字.Size = new System.Drawing.Size(100, 23);
		this.百炼_npc名字.TabIndex = 103;
		this.百炼_开关.AutoSize = true;
		this.百炼_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.百炼_开关.Location = new System.Drawing.Point(12, 12);
		this.百炼_开关.Name = "百炼_开关";
		this.百炼_开关.Size = new System.Drawing.Size(106, 23);
		this.百炼_开关.TabIndex = 114;
		this.百炼_开关.Text = "百炼合成开关";
		this.百炼_开关.UseVisualStyleBackColor = true;
		this.百炼_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.百炼_重载按钮.Location = new System.Drawing.Point(246, 8);
		this.百炼_重载按钮.Name = "百炼_重载按钮";
		this.百炼_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.百炼_重载按钮.TabIndex = 116;
		this.百炼_重载按钮.Text = "重载配置";
		this.百炼_重载按钮.UseVisualStyleBackColor = true;
		this.百炼_重载按钮.Click += new System.EventHandler(百炼_重载按钮_Click);
		this.百炼_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.百炼_保存按钮.Location = new System.Drawing.Point(140, 8);
		this.百炼_保存按钮.Name = "百炼_保存按钮";
		this.百炼_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.百炼_保存按钮.TabIndex = 115;
		this.百炼_保存按钮.Text = "保存配置";
		this.百炼_保存按钮.UseVisualStyleBackColor = true;
		this.百炼_保存按钮.Click += new System.EventHandler(百炼_保存按钮_Click);
		this.textBox11.Location = new System.Drawing.Point(206, 66);
		this.textBox11.Name = "textBox11";
		this.textBox11.ReadOnly = true;
		this.textBox11.Size = new System.Drawing.Size(80, 23);
		this.textBox11.TabIndex = 138;
		this.textBox11.Text = "炼化获得数量";
		this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_合成几率.Location = new System.Drawing.Point(100, 96);
		this.百炼_合成几率.Name = "百炼_合成几率";
		this.百炼_合成几率.Size = new System.Drawing.Size(100, 23);
		this.百炼_合成几率.TabIndex = 132;
		this.百炼_合成数量.Location = new System.Drawing.Point(287, 67);
		this.百炼_合成数量.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.百炼_合成数量.Name = "百炼_合成数量";
		this.百炼_合成数量.Size = new System.Drawing.Size(60, 23);
		this.百炼_合成数量.TabIndex = 130;
		this.textBox3.Location = new System.Drawing.Point(206, 96);
		this.textBox3.Name = "textBox3";
		this.textBox3.ReadOnly = true;
		this.textBox3.Size = new System.Drawing.Size(80, 23);
		this.textBox3.TabIndex = 128;
		this.textBox3.Text = "提交格子数量";
		this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料1数量.Location = new System.Drawing.Point(287, 125);
		this.百炼_配方材料1数量.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.百炼_配方材料1数量.Name = "百炼_配方材料1数量";
		this.百炼_配方材料1数量.Size = new System.Drawing.Size(60, 23);
		this.百炼_配方材料1数量.TabIndex = 127;
		this.百炼_提交格子数量.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.百炼_提交格子数量.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.百炼_提交格子数量.FormattingEnabled = true;
		this.百炼_提交格子数量.Items.AddRange(new object[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
		this.百炼_提交格子数量.Location = new System.Drawing.Point(287, 95);
		this.百炼_提交格子数量.Name = "百炼_提交格子数量";
		this.百炼_提交格子数量.Size = new System.Drawing.Size(60, 25);
		this.百炼_提交格子数量.TabIndex = 126;
		this.textBox2.Location = new System.Drawing.Point(19, 95);
		this.textBox2.Name = "textBox2";
		this.textBox2.ReadOnly = true;
		this.textBox2.Size = new System.Drawing.Size(80, 23);
		this.textBox2.TabIndex = 124;
		this.textBox2.Text = "炼化成功几率";
		this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_道具名字.Location = new System.Drawing.Point(100, 66);
		this.百炼_道具名字.Name = "百炼_道具名字";
		this.百炼_道具名字.Size = new System.Drawing.Size(100, 23);
		this.百炼_道具名字.TabIndex = 123;
		this.地狱道_名字.Location = new System.Drawing.Point(19, 66);
		this.地狱道_名字.Name = "地狱道_名字";
		this.地狱道_名字.ReadOnly = true;
		this.地狱道_名字.Size = new System.Drawing.Size(80, 23);
		this.地狱道_名字.TabIndex = 122;
		this.地狱道_名字.Text = "炼化道具名字";
		this.地狱道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料1.Location = new System.Drawing.Point(112, 125);
		this.百炼_配方材料1.Name = "百炼_配方材料1";
		this.百炼_配方材料1.Size = new System.Drawing.Size(153, 23);
		this.百炼_配方材料1.TabIndex = 145;
		this.textBox10.Location = new System.Drawing.Point(19, 125);
		this.textBox10.Name = "textBox10";
		this.textBox10.ReadOnly = true;
		this.textBox10.Size = new System.Drawing.Size(92, 23);
		this.textBox10.TabIndex = 144;
		this.textBox10.Text = "合成配方材料1";
		this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox14.Location = new System.Drawing.Point(266, 125);
		this.textBox14.Name = "textBox14";
		this.textBox14.ReadOnly = true;
		this.textBox14.Size = new System.Drawing.Size(20, 23);
		this.textBox14.TabIndex = 146;
		this.textBox14.Text = "×";
		this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox15.Location = new System.Drawing.Point(266, 271);
		this.textBox15.Name = "textBox15";
		this.textBox15.ReadOnly = true;
		this.textBox15.Size = new System.Drawing.Size(20, 23);
		this.textBox15.TabIndex = 150;
		this.textBox15.Text = "×";
		this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料6.Location = new System.Drawing.Point(112, 271);
		this.百炼_配方材料6.Name = "百炼_配方材料6";
		this.百炼_配方材料6.Size = new System.Drawing.Size(153, 23);
		this.百炼_配方材料6.TabIndex = 149;
		this.textBox17.Location = new System.Drawing.Point(19, 271);
		this.textBox17.Name = "textBox17";
		this.textBox17.ReadOnly = true;
		this.textBox17.Size = new System.Drawing.Size(92, 23);
		this.textBox17.TabIndex = 148;
		this.textBox17.Text = "合成配方材料6";
		this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料6数量.Location = new System.Drawing.Point(287, 271);
		this.百炼_配方材料6数量.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.百炼_配方材料6数量.Name = "百炼_配方材料6数量";
		this.百炼_配方材料6数量.Size = new System.Drawing.Size(60, 23);
		this.百炼_配方材料6数量.TabIndex = 147;
		this.textBox18.Location = new System.Drawing.Point(266, 300);
		this.textBox18.Name = "textBox18";
		this.textBox18.ReadOnly = true;
		this.textBox18.Size = new System.Drawing.Size(20, 23);
		this.textBox18.TabIndex = 158;
		this.textBox18.Text = "×";
		this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料7.Location = new System.Drawing.Point(112, 300);
		this.百炼_配方材料7.Name = "百炼_配方材料7";
		this.百炼_配方材料7.Size = new System.Drawing.Size(153, 23);
		this.百炼_配方材料7.TabIndex = 157;
		this.textBox20.Location = new System.Drawing.Point(19, 300);
		this.textBox20.Name = "textBox20";
		this.textBox20.ReadOnly = true;
		this.textBox20.Size = new System.Drawing.Size(92, 23);
		this.textBox20.TabIndex = 156;
		this.textBox20.Text = "合成配方材料7";
		this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料7数量.Location = new System.Drawing.Point(287, 300);
		this.百炼_配方材料7数量.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.百炼_配方材料7数量.Name = "百炼_配方材料7数量";
		this.百炼_配方材料7数量.Size = new System.Drawing.Size(60, 23);
		this.百炼_配方材料7数量.TabIndex = 155;
		this.textBox21.Location = new System.Drawing.Point(266, 154);
		this.textBox21.Name = "textBox21";
		this.textBox21.ReadOnly = true;
		this.textBox21.Size = new System.Drawing.Size(20, 23);
		this.textBox21.TabIndex = 154;
		this.textBox21.Text = "×";
		this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料2.Location = new System.Drawing.Point(112, 154);
		this.百炼_配方材料2.Name = "百炼_配方材料2";
		this.百炼_配方材料2.Size = new System.Drawing.Size(153, 23);
		this.百炼_配方材料2.TabIndex = 153;
		this.textBox23.Location = new System.Drawing.Point(19, 154);
		this.textBox23.Name = "textBox23";
		this.textBox23.ReadOnly = true;
		this.textBox23.Size = new System.Drawing.Size(92, 23);
		this.textBox23.TabIndex = 152;
		this.textBox23.Text = "合成配方材料2";
		this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料2数量.Location = new System.Drawing.Point(287, 154);
		this.百炼_配方材料2数量.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.百炼_配方材料2数量.Name = "百炼_配方材料2数量";
		this.百炼_配方材料2数量.Size = new System.Drawing.Size(60, 23);
		this.百炼_配方材料2数量.TabIndex = 151;
		this.textBox24.Location = new System.Drawing.Point(266, 329);
		this.textBox24.Name = "textBox24";
		this.textBox24.ReadOnly = true;
		this.textBox24.Size = new System.Drawing.Size(20, 23);
		this.textBox24.TabIndex = 166;
		this.textBox24.Text = "×";
		this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料8.Location = new System.Drawing.Point(112, 329);
		this.百炼_配方材料8.Name = "百炼_配方材料8";
		this.百炼_配方材料8.Size = new System.Drawing.Size(153, 23);
		this.百炼_配方材料8.TabIndex = 165;
		this.textBox26.Location = new System.Drawing.Point(19, 329);
		this.textBox26.Name = "textBox26";
		this.textBox26.ReadOnly = true;
		this.textBox26.Size = new System.Drawing.Size(92, 23);
		this.textBox26.TabIndex = 164;
		this.textBox26.Text = "合成配方材料8";
		this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料8数量.Location = new System.Drawing.Point(287, 329);
		this.百炼_配方材料8数量.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.百炼_配方材料8数量.Name = "百炼_配方材料8数量";
		this.百炼_配方材料8数量.Size = new System.Drawing.Size(60, 23);
		this.百炼_配方材料8数量.TabIndex = 163;
		this.textBox27.Location = new System.Drawing.Point(266, 183);
		this.textBox27.Name = "textBox27";
		this.textBox27.ReadOnly = true;
		this.textBox27.Size = new System.Drawing.Size(20, 23);
		this.textBox27.TabIndex = 162;
		this.textBox27.Text = "×";
		this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料3.Location = new System.Drawing.Point(112, 183);
		this.百炼_配方材料3.Name = "百炼_配方材料3";
		this.百炼_配方材料3.Size = new System.Drawing.Size(153, 23);
		this.百炼_配方材料3.TabIndex = 161;
		this.textBox29.Location = new System.Drawing.Point(19, 183);
		this.textBox29.Name = "textBox29";
		this.textBox29.ReadOnly = true;
		this.textBox29.Size = new System.Drawing.Size(92, 23);
		this.textBox29.TabIndex = 160;
		this.textBox29.Text = "合成配方材料3";
		this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料3数量.Location = new System.Drawing.Point(287, 183);
		this.百炼_配方材料3数量.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.百炼_配方材料3数量.Name = "百炼_配方材料3数量";
		this.百炼_配方材料3数量.Size = new System.Drawing.Size(60, 23);
		this.百炼_配方材料3数量.TabIndex = 159;
		this.textBox30.Location = new System.Drawing.Point(266, 359);
		this.textBox30.Name = "textBox30";
		this.textBox30.ReadOnly = true;
		this.textBox30.Size = new System.Drawing.Size(20, 23);
		this.textBox30.TabIndex = 174;
		this.textBox30.Text = "×";
		this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料9.Location = new System.Drawing.Point(112, 359);
		this.百炼_配方材料9.Name = "百炼_配方材料9";
		this.百炼_配方材料9.Size = new System.Drawing.Size(153, 23);
		this.百炼_配方材料9.TabIndex = 173;
		this.textBox32.Location = new System.Drawing.Point(19, 359);
		this.textBox32.Name = "textBox32";
		this.textBox32.ReadOnly = true;
		this.textBox32.Size = new System.Drawing.Size(92, 23);
		this.textBox32.TabIndex = 172;
		this.textBox32.Text = "合成配方材料9";
		this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料9数量.Location = new System.Drawing.Point(287, 359);
		this.百炼_配方材料9数量.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.百炼_配方材料9数量.Name = "百炼_配方材料9数量";
		this.百炼_配方材料9数量.Size = new System.Drawing.Size(60, 23);
		this.百炼_配方材料9数量.TabIndex = 171;
		this.textBox33.Location = new System.Drawing.Point(266, 213);
		this.textBox33.Name = "textBox33";
		this.textBox33.ReadOnly = true;
		this.textBox33.Size = new System.Drawing.Size(20, 23);
		this.textBox33.TabIndex = 170;
		this.textBox33.Text = "×";
		this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料4.Location = new System.Drawing.Point(112, 213);
		this.百炼_配方材料4.Name = "百炼_配方材料4";
		this.百炼_配方材料4.Size = new System.Drawing.Size(153, 23);
		this.百炼_配方材料4.TabIndex = 169;
		this.textBox35.Location = new System.Drawing.Point(19, 213);
		this.textBox35.Name = "textBox35";
		this.textBox35.ReadOnly = true;
		this.textBox35.Size = new System.Drawing.Size(92, 23);
		this.textBox35.TabIndex = 168;
		this.textBox35.Text = "合成配方材料4";
		this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料4数量.Location = new System.Drawing.Point(287, 213);
		this.百炼_配方材料4数量.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.百炼_配方材料4数量.Name = "百炼_配方材料4数量";
		this.百炼_配方材料4数量.Size = new System.Drawing.Size(60, 23);
		this.百炼_配方材料4数量.TabIndex = 167;
		this.textBox36.Location = new System.Drawing.Point(266, 388);
		this.textBox36.Name = "textBox36";
		this.textBox36.ReadOnly = true;
		this.textBox36.Size = new System.Drawing.Size(20, 23);
		this.textBox36.TabIndex = 182;
		this.textBox36.Text = "×";
		this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料10.Location = new System.Drawing.Point(112, 388);
		this.百炼_配方材料10.Name = "百炼_配方材料10";
		this.百炼_配方材料10.Size = new System.Drawing.Size(153, 23);
		this.百炼_配方材料10.TabIndex = 181;
		this.textBox38.Location = new System.Drawing.Point(19, 388);
		this.textBox38.Name = "textBox38";
		this.textBox38.ReadOnly = true;
		this.textBox38.Size = new System.Drawing.Size(92, 23);
		this.textBox38.TabIndex = 180;
		this.textBox38.Text = "合成配方材料10";
		this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料10数量.Location = new System.Drawing.Point(287, 388);
		this.百炼_配方材料10数量.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.百炼_配方材料10数量.Name = "百炼_配方材料10数量";
		this.百炼_配方材料10数量.Size = new System.Drawing.Size(60, 23);
		this.百炼_配方材料10数量.TabIndex = 179;
		this.textBox39.Location = new System.Drawing.Point(266, 242);
		this.textBox39.Name = "textBox39";
		this.textBox39.ReadOnly = true;
		this.textBox39.Size = new System.Drawing.Size(20, 23);
		this.textBox39.TabIndex = 178;
		this.textBox39.Text = "×";
		this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料5.Location = new System.Drawing.Point(112, 242);
		this.百炼_配方材料5.Name = "百炼_配方材料5";
		this.百炼_配方材料5.Size = new System.Drawing.Size(153, 23);
		this.百炼_配方材料5.TabIndex = 177;
		this.textBox41.Location = new System.Drawing.Point(19, 242);
		this.textBox41.Name = "textBox41";
		this.textBox41.ReadOnly = true;
		this.textBox41.Size = new System.Drawing.Size(92, 23);
		this.textBox41.TabIndex = 176;
		this.textBox41.Text = "合成配方材料5";
		this.textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_配方材料5数量.Location = new System.Drawing.Point(287, 242);
		this.百炼_配方材料5数量.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.百炼_配方材料5数量.Name = "百炼_配方材料5数量";
		this.百炼_配方材料5数量.Size = new System.Drawing.Size(60, 23);
		this.百炼_配方材料5数量.TabIndex = 175;
		this.百炼_合成列表.AllowUserToAddRows = false;
		this.百炼_合成列表.AllowUserToDeleteRows = false;
		this.百炼_合成列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.百炼_合成列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.百炼_合成列表.BackgroundColor = System.Drawing.Color.White;
		this.百炼_合成列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.百炼_合成列表.Columns.AddRange(this.权重值, this.道具名字, this.合成数量, this.几率, this.格子, this.合成配方材料);
		this.百炼_合成列表.Location = new System.Drawing.Point(12, 166);
		this.百炼_合成列表.MultiSelect = false;
		this.百炼_合成列表.Name = "百炼_合成列表";
		this.百炼_合成列表.ReadOnly = true;
		this.百炼_合成列表.RowHeadersVisible = false;
		this.百炼_合成列表.RowTemplate.Height = 25;
		this.百炼_合成列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.百炼_合成列表.Size = new System.Drawing.Size(776, 443);
		this.百炼_合成列表.TabIndex = 171;
		this.权重值.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.权重值.HeaderText = "权重值";
		this.权重值.MinimumWidth = 100;
		this.权重值.Name = "权重值";
		this.权重值.ReadOnly = true;
		this.道具名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.道具名字.HeaderText = "道具名字";
		this.道具名字.MinimumWidth = 100;
		this.道具名字.Name = "道具名字";
		this.道具名字.ReadOnly = true;
		this.合成数量.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.合成数量.HeaderText = "合成数量";
		this.合成数量.MinimumWidth = 90;
		this.合成数量.Name = "合成数量";
		this.合成数量.ReadOnly = true;
		this.合成数量.Width = 90;
		this.几率.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.几率.HeaderText = "几率";
		this.几率.MinimumWidth = 60;
		this.几率.Name = "几率";
		this.几率.ReadOnly = true;
		this.几率.Width = 60;
		this.格子.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.格子.HeaderText = "格子";
		this.格子.MinimumWidth = 60;
		this.格子.Name = "格子";
		this.格子.ReadOnly = true;
		this.格子.Width = 60;
		this.合成配方材料.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.合成配方材料.HeaderText = "合成配方材料";
		this.合成配方材料.MinimumWidth = 300;
		this.合成配方材料.Name = "合成配方材料";
		this.合成配方材料.ReadOnly = true;
		this.合成配方材料.Width = 300;
		this.百炼_打开新增按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.百炼_打开新增按钮.Location = new System.Drawing.Point(12, 130);
		this.百炼_打开新增按钮.Name = "百炼_打开新增按钮";
		this.百炼_打开新增按钮.Size = new System.Drawing.Size(160, 30);
		this.百炼_打开新增按钮.TabIndex = 172;
		this.百炼_打开新增按钮.Text = "点击新增合成道具配方";
		this.百炼_打开新增按钮.UseVisualStyleBackColor = true;
		this.百炼_打开新增按钮.Click += new System.EventHandler(百炼_打开新增按钮_Click);
		this.修改窗口.Controls.Add(this.百炼_可叠加);
		this.修改窗口.Controls.Add(this.label2);
		this.修改窗口.Controls.Add(this.textBox4);
		this.修改窗口.Controls.Add(this.百炼_权重值);
		this.修改窗口.Controls.Add(this.textBox1);
		this.修改窗口.Controls.Add(this.百炼_对话文本);
		this.修改窗口.Controls.Add(this.修改_取消按钮);
		this.修改窗口.Controls.Add(this.修改_确定按钮);
		this.修改窗口.Controls.Add(this.地狱道_名字);
		this.修改窗口.Controls.Add(this.百炼_道具名字);
		this.修改窗口.Controls.Add(this.textBox36);
		this.修改窗口.Controls.Add(this.textBox2);
		this.修改窗口.Controls.Add(this.百炼_配方材料10);
		this.修改窗口.Controls.Add(this.百炼_提交格子数量);
		this.修改窗口.Controls.Add(this.textBox38);
		this.修改窗口.Controls.Add(this.百炼_配方材料1数量);
		this.修改窗口.Controls.Add(this.百炼_配方材料10数量);
		this.修改窗口.Controls.Add(this.textBox3);
		this.修改窗口.Controls.Add(this.textBox39);
		this.修改窗口.Controls.Add(this.百炼_配方材料5);
		this.修改窗口.Controls.Add(this.百炼_合成数量);
		this.修改窗口.Controls.Add(this.textBox41);
		this.修改窗口.Controls.Add(this.百炼_合成几率);
		this.修改窗口.Controls.Add(this.百炼_配方材料5数量);
		this.修改窗口.Controls.Add(this.textBox11);
		this.修改窗口.Controls.Add(this.textBox30);
		this.修改窗口.Controls.Add(this.百炼_配方材料9);
		this.修改窗口.Controls.Add(this.textBox10);
		this.修改窗口.Controls.Add(this.textBox32);
		this.修改窗口.Controls.Add(this.百炼_配方材料1);
		this.修改窗口.Controls.Add(this.百炼_配方材料9数量);
		this.修改窗口.Controls.Add(this.textBox14);
		this.修改窗口.Controls.Add(this.textBox33);
		this.修改窗口.Controls.Add(this.百炼_配方材料6数量);
		this.修改窗口.Controls.Add(this.百炼_配方材料4);
		this.修改窗口.Controls.Add(this.textBox17);
		this.修改窗口.Controls.Add(this.textBox35);
		this.修改窗口.Controls.Add(this.百炼_配方材料6);
		this.修改窗口.Controls.Add(this.百炼_配方材料4数量);
		this.修改窗口.Controls.Add(this.textBox15);
		this.修改窗口.Controls.Add(this.textBox24);
		this.修改窗口.Controls.Add(this.百炼_配方材料2数量);
		this.修改窗口.Controls.Add(this.百炼_配方材料8);
		this.修改窗口.Controls.Add(this.textBox23);
		this.修改窗口.Controls.Add(this.textBox26);
		this.修改窗口.Controls.Add(this.百炼_配方材料2);
		this.修改窗口.Controls.Add(this.百炼_配方材料8数量);
		this.修改窗口.Controls.Add(this.textBox21);
		this.修改窗口.Controls.Add(this.textBox27);
		this.修改窗口.Controls.Add(this.百炼_配方材料7数量);
		this.修改窗口.Controls.Add(this.百炼_配方材料3);
		this.修改窗口.Controls.Add(this.textBox20);
		this.修改窗口.Controls.Add(this.textBox29);
		this.修改窗口.Controls.Add(this.百炼_配方材料7);
		this.修改窗口.Controls.Add(this.百炼_配方材料3数量);
		this.修改窗口.Controls.Add(this.textBox18);
		this.修改窗口.Location = new System.Drawing.Point(202, 110);
		this.修改窗口.Name = "修改窗口";
		this.修改窗口.Size = new System.Drawing.Size(371, 499);
		this.修改窗口.TabIndex = 173;
		this.label2.BackColor = System.Drawing.Color.Transparent;
		this.label2.ForeColor = System.Drawing.Color.Red;
		this.label2.Location = new System.Drawing.Point(19, 13);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(162, 22);
		this.label2.TabIndex = 191;
		this.label2.Text = "权重值越大排序越靠前";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.textBox4.Location = new System.Drawing.Point(19, 37);
		this.textBox4.Name = "textBox4";
		this.textBox4.ReadOnly = true;
		this.textBox4.Size = new System.Drawing.Size(98, 23);
		this.textBox4.TabIndex = 189;
		this.textBox4.Text = "权重值(0-10000)";
		this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_权重值.Location = new System.Drawing.Point(119, 38);
		this.百炼_权重值.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.百炼_权重值.Name = "百炼_权重值";
		this.百炼_权重值.Size = new System.Drawing.Size(83, 23);
		this.百炼_权重值.TabIndex = 190;
		this.textBox1.Location = new System.Drawing.Point(19, 417);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(92, 23);
		this.textBox1.TabIndex = 187;
		this.textBox1.Text = "提交框提示文本";
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.百炼_对话文本.Location = new System.Drawing.Point(112, 417);
		this.百炼_对话文本.Name = "百炼_对话文本";
		this.百炼_对话文本.Size = new System.Drawing.Size(235, 23);
		this.百炼_对话文本.TabIndex = 188;
		this.修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_取消按钮.Location = new System.Drawing.Point(184, 455);
		this.修改_取消按钮.Name = "修改_取消按钮";
		this.修改_取消按钮.Size = new System.Drawing.Size(100, 30);
		this.修改_取消按钮.TabIndex = 186;
		this.修改_取消按钮.Text = "取消";
		this.修改_取消按钮.UseVisualStyleBackColor = true;
		this.修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_确定按钮.Location = new System.Drawing.Point(78, 455);
		this.修改_确定按钮.Name = "修改_确定按钮";
		this.修改_确定按钮.Size = new System.Drawing.Size(100, 30);
		this.修改_确定按钮.TabIndex = 185;
		this.修改_确定按钮.Text = "修改";
		this.修改_确定按钮.UseVisualStyleBackColor = true;
		this.label3.ForeColor = System.Drawing.Color.Red;
		this.label3.Location = new System.Drawing.Point(352, 3);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(436, 38);
		this.label3.TabIndex = 187;
		this.label3.Text = "该消耗道具必须写成材料，具体写法可参照后台首页中的材料礼包例子\r\n可以写装备作为配方材料，提交的配方材料不能有重复名字，数量不能＞30000";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.百炼_可叠加.AutoSize = true;
		this.百炼_可叠加.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.百炼_可叠加.Location = new System.Drawing.Point(206, 38);
		this.百炼_可叠加.Name = "百炼_可叠加";
		this.百炼_可叠加.Size = new System.Drawing.Size(145, 23);
		this.百炼_可叠加.TabIndex = 192;
		this.百炼_可叠加.Text = "炼化道具是否可叠加";
		this.百炼_可叠加.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(804, 621);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.修改窗口);
		base.Controls.Add(this.百炼_打开新增按钮);
		base.Controls.Add(this.百炼_合成列表);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.百炼_开关);
		base.Controls.Add(this.百炼_重载按钮);
		base.Controls.Add(this.百炼_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "百炼合成配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "百炼合成配置窗口";
		base.Load += new System.EventHandler(百炼合成配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.百炼_形象).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_坐标Y).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_坐标X).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_合成几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_合成数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料1数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料6数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料7数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料2数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料8数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料3数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料9数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料4数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料10数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_配方材料5数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.百炼_合成列表).EndInit();
		this.修改窗口.ResumeLayout(false);
		this.修改窗口.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.百炼_权重值).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
