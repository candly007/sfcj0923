using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 浮生录配置窗口 : Form
{
	private static 浮生录配置窗口 i;

	private IContainer components;

	private GroupBox groupBox1;

	private NumericUpDown 浮生录_形象;

	private Label label9;

	private ComboBox 浮生录_朝向;

	private Label label8;

	private NumericUpDown 浮生录_坐标Y;

	private NumericUpDown 浮生录_坐标X;

	private Label label7;

	private Label label5;

	private TextBox 浮生录_npc称号;

	private Label label4;

	private TextBox 浮生录_npc名字;

	private CheckBox 浮生录_开关;

	private Button 浮生录_重载按钮;

	private Button 浮生录_保存按钮;

	private CheckBox 浮生录_道具抽取开关;

	private CheckBox 浮生录_道具10连抽开关;

	private TextBox 地狱道_名字;

	private TextBox 浮生录_道具名字;

	private NumericUpDown 浮生录_道具消耗数量;

	private TextBox textBox11;

	private TextBox textBox1;

	private NumericUpDown 浮生录_数值消耗数量;

	private TextBox textBox3;

	private CheckBox 浮生录_数值10连抽开关;

	private CheckBox 浮生录_数值抽取开关;

	private ComboBox 浮生录_消耗类型;

	private TextBox textBox2;

	private TextBox 浮生录_特效道具;

	private NumericUpDown 浮生录_一星几率;

	private TextBox textBox5;

	private NumericUpDown 浮生录_二星几率;

	private TextBox textBox6;

	private NumericUpDown 浮生录_三星几率;

	private TextBox textBox7;

	private NumericUpDown 浮生录_四星几率;

	private TextBox textBox8;

	private NumericUpDown 浮生录_五星几率;

	private TextBox textBox9;

	private ComboBox 浮生录_乱世书属性;

	private TextBox textBox10;

	private NumericUpDown 浮生录_乱世书数值;

	private NumericUpDown 浮生录_千钧卷数值;

	private ComboBox 浮生录_千钧卷属性;

	private TextBox textBox12;

	private NumericUpDown 浮生录_灵虚卷数值;

	private ComboBox 浮生录_灵虚卷属性;

	private TextBox textBox13;

	private NumericUpDown 浮生录_御元卷数值;

	private ComboBox 浮生录_御元卷属性;

	private TextBox textBox14;

	private NumericUpDown 浮生录_乘风卷数值;

	private ComboBox 浮生录_乘风卷属性;

	private TextBox textBox15;

	private DataGridView 浮生录_化身列表;

	private TextBox textBox16;

	private TextBox 浮生录_添加化身名字;

	private ComboBox 浮生录_添加化身分类;

	private ComboBox 浮生录_添加化身星级;

	private TextBox textBox18;

	private NumericUpDown 浮生录_添加化身碎化;

	private TextBox textBox19;

	private TextBox textBox20;

	private Button 浮生录_添加化身按钮;

	private GroupBox groupBox2;

	private Label label17;

	private Label label1;

	private TextBox textBox4;

	private TextBox textBox22;

	private TextBox textBox24;

	private TextBox textBox26;

	private TextBox textBox28;

	private DataGridViewTextBoxColumn 化身名字;

	private DataGridViewComboBoxColumn 化身分类;

	private DataGridViewComboBoxColumn 化身星级;

	private DataGridViewTextBoxColumn 碎化数量;

	public static 浮生录配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 浮生录配置窗口();
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

	public 浮生录配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 浮生录配置窗口_Load(object sender, EventArgs e)
	{
		浮生录_化身列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 删除事件回调);
		((DataGridViewComboBoxColumn)浮生录_化身列表.Columns[1]).DataSource = new List<string> { "乱世书", "千钧卷", "灵虚卷", "御元卷", "乘风卷" };
		((DataGridViewComboBoxColumn)浮生录_化身列表.Columns[2]).DataSource = new List<string> { "一星", "二星", "三星", "四星", "五星" };
		浮生录_化身列表.DataError += delegate
		{
		};
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		浮生录_重载按钮_Click(sender, e);
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 浮生录_化身列表.CurrentRow == null)
		{
			return;
		}
		int index = 浮生录_化身列表.CurrentRow.Index;
		if (index >= 0)
		{
			string text = 浮生录_化身列表.Rows[index].Cells[0].Value.ToString();
			if (Singleton<全局变量类>.I.浮生录配置.化身列表.ContainsKey(text))
			{
				Singleton<全局变量类>.I.浮生录配置.化身列表.TryRemove(text, out 浮生化身配置类 _);
				MessageBox.Show("[" + text + "]已从列表中删除，请及时点击保存配置按钮更新服务端配置！");
				浮生录_化身列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 12)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			浮生录_开关.Checked = Singleton<全局变量类>.I.浮生录配置.功能开关;
			浮生录_npc名字.Text = Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字;
			浮生录_npc称号.Text = Singleton<全局变量类>.I.浮生录配置.NPC数据.npc称号;
			浮生录_坐标X.Value = Singleton<全局变量类>.I.浮生录配置.NPC数据.坐标.X;
			浮生录_坐标Y.Value = Singleton<全局变量类>.I.浮生录配置.NPC数据.坐标.Y;
			浮生录_朝向.Text = $"{(AllEnums.朝向Type)Singleton<全局变量类>.I.浮生录配置.NPC数据.朝向}";
			浮生录_形象.Value = Singleton<全局变量类>.I.浮生录配置.NPC数据.npc形象;
			浮生录_道具抽取开关.Checked = Singleton<全局变量类>.I.浮生录配置.is道具抽取;
			浮生录_道具10连抽开关.Checked = Singleton<全局变量类>.I.浮生录配置.is道具连抽;
			浮生录_道具名字.Text = Singleton<全局变量类>.I.浮生录配置.道具名字;
			浮生录_道具消耗数量.Value = Singleton<全局变量类>.I.浮生录配置.道具消耗;
			浮生录_数值抽取开关.Checked = Singleton<全局变量类>.I.浮生录配置.is数值抽取;
			浮生录_数值10连抽开关.Checked = Singleton<全局变量类>.I.浮生录配置.is数值连抽;
			浮生录_消耗类型.Text = Singleton<全局变量类>.I.浮生录配置.数值类型.ToString();
			浮生录_数值消耗数量.Value = Singleton<全局变量类>.I.浮生录配置.数值消耗;
			浮生录_特效道具.Text = Singleton<全局变量类>.I.浮生录配置.特效道具;
			浮生录_一星几率.Value = Singleton<全局变量类>.I.浮生录配置.一星化身抽取几率;
			浮生录_二星几率.Value = Singleton<全局变量类>.I.浮生录配置.二星化身抽取几率;
			浮生录_三星几率.Value = Singleton<全局变量类>.I.浮生录配置.三星化身抽取几率;
			浮生录_四星几率.Value = Singleton<全局变量类>.I.浮生录配置.四星化身抽取几率;
			浮生录_五星几率.Value = Singleton<全局变量类>.I.浮生录配置.五星化身抽取几率;
			浮生录_乱世书属性.Text = Singleton<全局变量类>.I.浮生录配置.乱世书属性.ToString();
			浮生录_乱世书数值.Value = Singleton<全局变量类>.I.浮生录配置.乱世书数值;
			浮生录_千钧卷属性.Text = Singleton<全局变量类>.I.浮生录配置.千钧卷属性.ToString();
			浮生录_千钧卷数值.Value = Singleton<全局变量类>.I.浮生录配置.千钧卷数值;
			浮生录_灵虚卷属性.Text = Singleton<全局变量类>.I.浮生录配置.灵虚卷属性.ToString();
			浮生录_灵虚卷数值.Value = Singleton<全局变量类>.I.浮生录配置.灵虚卷数值;
			浮生录_御元卷属性.Text = Singleton<全局变量类>.I.浮生录配置.御元卷属性.ToString();
			浮生录_御元卷数值.Value = Singleton<全局变量类>.I.浮生录配置.御元卷数值;
			浮生录_乘风卷属性.Text = Singleton<全局变量类>.I.浮生录配置.乘风卷属性.ToString();
			浮生录_乘风卷数值.Value = Singleton<全局变量类>.I.浮生录配置.乘风卷数值;
			浮生录_化身列表.Rows.Clear();
			int num = 0;
			foreach (浮生化身配置类 value in Singleton<全局变量类>.I.浮生录配置.化身列表.Values)
			{
				浮生录_化身列表.Rows.Add(value.化身名字, string.Empty, string.Empty, value.碎化数量);
				((DataGridViewComboBoxCell)浮生录_化身列表.Rows[num].Cells[1]).Value = value.分类.ToString();
				((DataGridViewComboBoxCell)浮生录_化身列表.Rows[num].Cells[2]).Value = value.星级.ToString();
				num++;
			}
		});
	}

	private void 配置变量赋值()
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		Singleton<全局变量类>.I.浮生录配置.功能开关 = 浮生录_开关.Checked;
		if (Singleton<全局变量类>.I.浮生录配置.功能开关)
		{
			Singleton<全局变量类>.I.浮生录配置.定制功能开关 = false;
		}
		Singleton<全局变量类>.I.浮生录配置.NPC数据.npc名字 = 浮生录_npc名字.Text;
		Singleton<全局变量类>.I.浮生录配置.NPC数据.npc称号 = 浮生录_npc称号.Text;
		Singleton<全局变量类>.I.浮生录配置.NPC数据.坐标.X = (short)浮生录_坐标X.Value;
		Singleton<全局变量类>.I.浮生录配置.NPC数据.坐标.Y = (short)浮生录_坐标Y.Value;
		Singleton<全局变量类>.I.浮生录配置.NPC数据.朝向 = (short)Enum.Parse<AllEnums.朝向Type>(浮生录_朝向.Text);
		Singleton<全局变量类>.I.浮生录配置.NPC数据.npc形象 = (int)浮生录_形象.Value;
		Singleton<全局变量类>.I.浮生录配置.is道具抽取 = 浮生录_道具抽取开关.Checked;
		Singleton<全局变量类>.I.浮生录配置.is道具连抽 = 浮生录_道具10连抽开关.Checked;
		Singleton<全局变量类>.I.浮生录配置.道具名字 = 浮生录_道具名字.Text;
		Singleton<全局变量类>.I.浮生录配置.道具消耗 = (int)浮生录_道具消耗数量.Value;
		Singleton<全局变量类>.I.浮生录配置.is数值抽取 = 浮生录_数值抽取开关.Checked;
		Singleton<全局变量类>.I.浮生录配置.is数值连抽 = 浮生录_数值10连抽开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(浮生录_消耗类型.Text, out Singleton<全局变量类>.I.浮生录配置.数值类型);
		Singleton<全局变量类>.I.浮生录配置.数值消耗 = (int)浮生录_数值消耗数量.Value;
		Singleton<全局变量类>.I.浮生录配置.特效道具 = 浮生录_特效道具.Text;
		Singleton<全局变量类>.I.浮生录配置.一星化身抽取几率 = (int)浮生录_一星几率.Value;
		Singleton<全局变量类>.I.浮生录配置.二星化身抽取几率 = (int)浮生录_二星几率.Value;
		Singleton<全局变量类>.I.浮生录配置.三星化身抽取几率 = (int)浮生录_三星几率.Value;
		Singleton<全局变量类>.I.浮生录配置.四星化身抽取几率 = (int)浮生录_四星几率.Value;
		Singleton<全局变量类>.I.浮生录配置.五星化身抽取几率 = (int)浮生录_五星几率.Value;
		Enum.TryParse<AllEnums.属性Type>(浮生录_乱世书属性.Text, out Singleton<全局变量类>.I.浮生录配置.乱世书属性);
		Singleton<全局变量类>.I.浮生录配置.乱世书数值 = (int)浮生录_乱世书数值.Value;
		Enum.TryParse<AllEnums.属性Type>(浮生录_千钧卷属性.Text, out Singleton<全局变量类>.I.浮生录配置.千钧卷属性);
		Singleton<全局变量类>.I.浮生录配置.千钧卷数值 = (int)浮生录_千钧卷数值.Value;
		Enum.TryParse<AllEnums.属性Type>(浮生录_灵虚卷属性.Text, out Singleton<全局变量类>.I.浮生录配置.灵虚卷属性);
		Singleton<全局变量类>.I.浮生录配置.灵虚卷数值 = (int)浮生录_灵虚卷数值.Value;
		Enum.TryParse<AllEnums.属性Type>(浮生录_御元卷属性.Text, out Singleton<全局变量类>.I.浮生录配置.御元卷属性);
		Singleton<全局变量类>.I.浮生录配置.御元卷数值 = (int)浮生录_御元卷数值.Value;
		Enum.TryParse<AllEnums.属性Type>(浮生录_乘风卷属性.Text, out Singleton<全局变量类>.I.浮生录配置.乘风卷属性);
		Singleton<全局变量类>.I.浮生录配置.乘风卷数值 = (int)浮生录_乘风卷数值.Value;
		Singleton<全局变量类>.I.浮生录配置.化身列表.Clear();
		for (int i = 0; i < 浮生录_化身列表.Rows.Count; i++)
		{
			DataGridViewCellCollection cells = 浮生录_化身列表.Rows[i].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value.ToString()))
			{
				Singleton<全局变量类>.I.浮生录配置.化身列表.TryAdd(cells[0].Value.ToString(), new 浮生化身配置类
				{
					化身名字 = cells[0].Value.ToString(),
					分类 = Enum.Parse<AllEnums.化身分类>(cells[1].Value.ToString()),
					星级 = Enum.Parse<AllEnums.化身星级>(cells[2].Value.ToString()),
					碎化数量 = int.Parse(cells[3].Value.ToString())
				});
			}
		}
	}

	private void 浮生录_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 12, JsonConvert.SerializeObject(Singleton<全局变量类>.I.浮生录配置, Formatting.Indented));
		}
	}

	private void 浮生录_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 12);
		}
	}

	private void 浮生录_添加化身按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(浮生录_添加化身名字.Text))
			{
				MessageBox.Show("请输入要添加回收的宠物或者道具！");
				return;
			}
			if (string.IsNullOrWhiteSpace(浮生录_添加化身分类.Text))
			{
				MessageBox.Show("请选择要添加的化身类型！");
				return;
			}
			if (string.IsNullOrWhiteSpace(浮生录_添加化身星级.Text))
			{
				MessageBox.Show("请选择要添加的化身星级！");
				return;
			}
			if (Singleton<全局变量类>.I.浮生录配置.化身列表.ContainsKey(浮生录_添加化身名字.Text))
			{
				MessageBox.Show("列表中已经存在【" + 浮生录_添加化身名字.Text + "】，无法重复添加！");
				return;
			}
			Singleton<全局变量类>.I.浮生录配置.化身列表.TryAdd(浮生录_添加化身名字.Text, new 浮生化身配置类
			{
				化身名字 = 浮生录_添加化身名字.Text,
				分类 = Enum.Parse<AllEnums.化身分类>(浮生录_添加化身分类.Text),
				星级 = Enum.Parse<AllEnums.化身星级>(浮生录_添加化身星级.Text),
				碎化数量 = (int)浮生录_添加化身碎化.Value
			});
			浮生录_化身列表.Rows.Add(浮生录_添加化身名字.Text, 浮生录_添加化身分类.Text, 浮生录_添加化身星级.Text, 浮生录_添加化身碎化.Value);
			MessageBox.Show("[" + 浮生录_添加化身名字.Text + "]添加成功");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.浮生录配置窗口));
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.浮生录_形象 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.浮生录_朝向 = new System.Windows.Forms.ComboBox();
		this.label8 = new System.Windows.Forms.Label();
		this.浮生录_坐标Y = new System.Windows.Forms.NumericUpDown();
		this.浮生录_坐标X = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.浮生录_npc称号 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.浮生录_npc名字 = new System.Windows.Forms.TextBox();
		this.浮生录_开关 = new System.Windows.Forms.CheckBox();
		this.浮生录_重载按钮 = new System.Windows.Forms.Button();
		this.浮生录_保存按钮 = new System.Windows.Forms.Button();
		this.浮生录_道具抽取开关 = new System.Windows.Forms.CheckBox();
		this.浮生录_道具10连抽开关 = new System.Windows.Forms.CheckBox();
		this.地狱道_名字 = new System.Windows.Forms.TextBox();
		this.浮生录_道具名字 = new System.Windows.Forms.TextBox();
		this.浮生录_道具消耗数量 = new System.Windows.Forms.NumericUpDown();
		this.textBox11 = new System.Windows.Forms.TextBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.浮生录_数值消耗数量 = new System.Windows.Forms.NumericUpDown();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.浮生录_数值10连抽开关 = new System.Windows.Forms.CheckBox();
		this.浮生录_数值抽取开关 = new System.Windows.Forms.CheckBox();
		this.浮生录_消耗类型 = new System.Windows.Forms.ComboBox();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.浮生录_特效道具 = new System.Windows.Forms.TextBox();
		this.浮生录_一星几率 = new System.Windows.Forms.NumericUpDown();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.浮生录_二星几率 = new System.Windows.Forms.NumericUpDown();
		this.textBox6 = new System.Windows.Forms.TextBox();
		this.浮生录_三星几率 = new System.Windows.Forms.NumericUpDown();
		this.textBox7 = new System.Windows.Forms.TextBox();
		this.浮生录_四星几率 = new System.Windows.Forms.NumericUpDown();
		this.textBox8 = new System.Windows.Forms.TextBox();
		this.浮生录_五星几率 = new System.Windows.Forms.NumericUpDown();
		this.textBox9 = new System.Windows.Forms.TextBox();
		this.浮生录_乱世书属性 = new System.Windows.Forms.ComboBox();
		this.textBox10 = new System.Windows.Forms.TextBox();
		this.浮生录_乱世书数值 = new System.Windows.Forms.NumericUpDown();
		this.浮生录_千钧卷数值 = new System.Windows.Forms.NumericUpDown();
		this.浮生录_千钧卷属性 = new System.Windows.Forms.ComboBox();
		this.textBox12 = new System.Windows.Forms.TextBox();
		this.浮生录_灵虚卷数值 = new System.Windows.Forms.NumericUpDown();
		this.浮生录_灵虚卷属性 = new System.Windows.Forms.ComboBox();
		this.textBox13 = new System.Windows.Forms.TextBox();
		this.浮生录_御元卷数值 = new System.Windows.Forms.NumericUpDown();
		this.浮生录_御元卷属性 = new System.Windows.Forms.ComboBox();
		this.textBox14 = new System.Windows.Forms.TextBox();
		this.浮生录_乘风卷数值 = new System.Windows.Forms.NumericUpDown();
		this.浮生录_乘风卷属性 = new System.Windows.Forms.ComboBox();
		this.textBox15 = new System.Windows.Forms.TextBox();
		this.浮生录_化身列表 = new System.Windows.Forms.DataGridView();
		this.textBox16 = new System.Windows.Forms.TextBox();
		this.浮生录_添加化身名字 = new System.Windows.Forms.TextBox();
		this.浮生录_添加化身分类 = new System.Windows.Forms.ComboBox();
		this.浮生录_添加化身星级 = new System.Windows.Forms.ComboBox();
		this.textBox18 = new System.Windows.Forms.TextBox();
		this.浮生录_添加化身碎化 = new System.Windows.Forms.NumericUpDown();
		this.textBox19 = new System.Windows.Forms.TextBox();
		this.textBox20 = new System.Windows.Forms.TextBox();
		this.浮生录_添加化身按钮 = new System.Windows.Forms.Button();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.label17 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.textBox22 = new System.Windows.Forms.TextBox();
		this.textBox24 = new System.Windows.Forms.TextBox();
		this.textBox26 = new System.Windows.Forms.TextBox();
		this.textBox28 = new System.Windows.Forms.TextBox();
		this.化身名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.化身分类 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.化身星级 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.碎化数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.浮生录_形象).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_坐标Y).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_坐标X).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_道具消耗数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_数值消耗数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_一星几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_二星几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_三星几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_四星几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_五星几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_乱世书数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_千钧卷数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_灵虚卷数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_御元卷数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_乘风卷数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_化身列表).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_添加化身碎化).BeginInit();
		this.groupBox2.SuspendLayout();
		base.SuspendLayout();
		this.groupBox1.BackColor = System.Drawing.Color.Transparent;
		this.groupBox1.Controls.Add(this.浮生录_形象);
		this.groupBox1.Controls.Add(this.label9);
		this.groupBox1.Controls.Add(this.浮生录_朝向);
		this.groupBox1.Controls.Add(this.label8);
		this.groupBox1.Controls.Add(this.浮生录_坐标Y);
		this.groupBox1.Controls.Add(this.浮生录_坐标X);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.浮生录_npc称号);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.浮生录_npc名字);
		this.groupBox1.Location = new System.Drawing.Point(12, 44);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(776, 57);
		this.groupBox1.TabIndex = 121;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "npc配置";
		this.浮生录_形象.Location = new System.Drawing.Point(644, 17);
		this.浮生录_形象.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.浮生录_形象.Name = "浮生录_形象";
		this.浮生录_形象.Size = new System.Drawing.Size(100, 23);
		this.浮生录_形象.TabIndex = 112;
		this.label9.BackColor = System.Drawing.Color.Transparent;
		this.label9.Location = new System.Drawing.Point(611, 17);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(32, 23);
		this.label9.TabIndex = 111;
		this.label9.Text = "形象";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.浮生录_朝向.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.浮生录_朝向.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.浮生录_朝向.FormattingEnabled = true;
		this.浮生录_朝向.Items.AddRange(new object[8] { "左", "左上", "上", "右上", "右", "右下", "下", "左下" });
		this.浮生录_朝向.Location = new System.Drawing.Point(545, 17);
		this.浮生录_朝向.Name = "浮生录_朝向";
		this.浮生录_朝向.Size = new System.Drawing.Size(60, 25);
		this.浮生录_朝向.TabIndex = 110;
		this.label8.BackColor = System.Drawing.Color.Transparent;
		this.label8.Location = new System.Drawing.Point(513, 19);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(32, 23);
		this.label8.TabIndex = 109;
		this.label8.Text = "朝向";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.浮生录_坐标Y.Location = new System.Drawing.Point(447, 19);
		this.浮生录_坐标Y.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.浮生录_坐标Y.Name = "浮生录_坐标Y";
		this.浮生录_坐标Y.Size = new System.Drawing.Size(60, 23);
		this.浮生录_坐标Y.TabIndex = 108;
		this.浮生录_坐标X.Location = new System.Drawing.Point(370, 19);
		this.浮生录_坐标X.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.浮生录_坐标X.Name = "浮生录_坐标X";
		this.浮生录_坐标X.Size = new System.Drawing.Size(60, 23);
		this.浮生录_坐标X.TabIndex = 107;
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
		this.浮生录_npc称号.Location = new System.Drawing.Point(229, 19);
		this.浮生录_npc称号.Name = "浮生录_npc称号";
		this.浮生录_npc称号.Size = new System.Drawing.Size(100, 23);
		this.浮生录_npc称号.TabIndex = 105;
		this.label4.Location = new System.Drawing.Point(6, 19);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 102;
		this.label4.Text = "npc名字";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.浮生录_npc名字.Location = new System.Drawing.Point(67, 19);
		this.浮生录_npc名字.Name = "浮生录_npc名字";
		this.浮生录_npc名字.Size = new System.Drawing.Size(100, 23);
		this.浮生录_npc名字.TabIndex = 103;
		this.浮生录_开关.AutoSize = true;
		this.浮生录_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.浮生录_开关.Location = new System.Drawing.Point(12, 12);
		this.浮生录_开关.Name = "浮生录_开关";
		this.浮生录_开关.Size = new System.Drawing.Size(93, 23);
		this.浮生录_开关.TabIndex = 118;
		this.浮生录_开关.Text = "浮生录开关";
		this.浮生录_开关.UseVisualStyleBackColor = true;
		this.浮生录_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.浮生录_重载按钮.Location = new System.Drawing.Point(246, 8);
		this.浮生录_重载按钮.Name = "浮生录_重载按钮";
		this.浮生录_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.浮生录_重载按钮.TabIndex = 120;
		this.浮生录_重载按钮.Text = "重载配置";
		this.浮生录_重载按钮.UseVisualStyleBackColor = true;
		this.浮生录_重载按钮.Click += new System.EventHandler(浮生录_重载按钮_Click);
		this.浮生录_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.浮生录_保存按钮.Location = new System.Drawing.Point(140, 8);
		this.浮生录_保存按钮.Name = "浮生录_保存按钮";
		this.浮生录_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.浮生录_保存按钮.TabIndex = 119;
		this.浮生录_保存按钮.Text = "保存配置";
		this.浮生录_保存按钮.UseVisualStyleBackColor = true;
		this.浮生录_保存按钮.Click += new System.EventHandler(浮生录_保存按钮_Click);
		this.浮生录_道具抽取开关.AutoSize = true;
		this.浮生录_道具抽取开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.浮生录_道具抽取开关.Location = new System.Drawing.Point(12, 112);
		this.浮生录_道具抽取开关.Name = "浮生录_道具抽取开关";
		this.浮生录_道具抽取开关.Size = new System.Drawing.Size(158, 23);
		this.浮生录_道具抽取开关.TabIndex = 122;
		this.浮生录_道具抽取开关.Text = "浮生之羽抽取化身开关";
		this.浮生录_道具抽取开关.UseVisualStyleBackColor = true;
		this.浮生录_道具10连抽开关.AutoSize = true;
		this.浮生录_道具10连抽开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.浮生录_道具10连抽开关.Location = new System.Drawing.Point(176, 112);
		this.浮生录_道具10连抽开关.Name = "浮生录_道具10连抽开关";
		this.浮生录_道具10连抽开关.Size = new System.Drawing.Size(148, 23);
		this.浮生录_道具10连抽开关.TabIndex = 123;
		this.浮生录_道具10连抽开关.Text = "浮生之羽10连抽开关";
		this.浮生录_道具10连抽开关.UseVisualStyleBackColor = true;
		this.地狱道_名字.Location = new System.Drawing.Point(12, 139);
		this.地狱道_名字.Name = "地狱道_名字";
		this.地狱道_名字.ReadOnly = true;
		this.地狱道_名字.Size = new System.Drawing.Size(80, 23);
		this.地狱道_名字.TabIndex = 139;
		this.地狱道_名字.Text = "消耗道具名字";
		this.地狱道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_道具名字.Location = new System.Drawing.Point(93, 139);
		this.浮生录_道具名字.Name = "浮生录_道具名字";
		this.浮生录_道具名字.ReadOnly = true;
		this.浮生录_道具名字.Size = new System.Drawing.Size(100, 23);
		this.浮生录_道具名字.TabIndex = 140;
		this.浮生录_道具消耗数量.Location = new System.Drawing.Point(280, 140);
		this.浮生录_道具消耗数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.浮生录_道具消耗数量.Name = "浮生录_道具消耗数量";
		this.浮生录_道具消耗数量.Size = new System.Drawing.Size(100, 23);
		this.浮生录_道具消耗数量.TabIndex = 141;
		this.textBox11.Location = new System.Drawing.Point(199, 139);
		this.textBox11.Name = "textBox11";
		this.textBox11.ReadOnly = true;
		this.textBox11.Size = new System.Drawing.Size(80, 23);
		this.textBox11.TabIndex = 142;
		this.textBox11.Text = "单次消耗数量";
		this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox1.Location = new System.Drawing.Point(12, 201);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(80, 23);
		this.textBox1.TabIndex = 145;
		this.textBox1.Text = "抽取消耗类型";
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_数值消耗数量.Location = new System.Drawing.Point(280, 201);
		this.浮生录_数值消耗数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.浮生录_数值消耗数量.Name = "浮生录_数值消耗数量";
		this.浮生录_数值消耗数量.Size = new System.Drawing.Size(100, 23);
		this.浮生录_数值消耗数量.TabIndex = 147;
		this.textBox3.Location = new System.Drawing.Point(199, 201);
		this.textBox3.Name = "textBox3";
		this.textBox3.ReadOnly = true;
		this.textBox3.Size = new System.Drawing.Size(80, 23);
		this.textBox3.TabIndex = 148;
		this.textBox3.Text = "单次消耗数量";
		this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_数值10连抽开关.AutoSize = true;
		this.浮生录_数值10连抽开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.浮生录_数值10连抽开关.Location = new System.Drawing.Point(176, 174);
		this.浮生录_数值10连抽开关.Name = "浮生录_数值10连抽开关";
		this.浮生录_数值10连抽开关.Size = new System.Drawing.Size(148, 23);
		this.浮生录_数值10连抽开关.TabIndex = 144;
		this.浮生录_数值10连抽开关.Text = "其他类型10连抽开关";
		this.浮生录_数值10连抽开关.UseVisualStyleBackColor = true;
		this.浮生录_数值抽取开关.AutoSize = true;
		this.浮生录_数值抽取开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.浮生录_数值抽取开关.Location = new System.Drawing.Point(12, 174);
		this.浮生录_数值抽取开关.Name = "浮生录_数值抽取开关";
		this.浮生录_数值抽取开关.Size = new System.Drawing.Size(158, 23);
		this.浮生录_数值抽取开关.TabIndex = 143;
		this.浮生录_数值抽取开关.Text = "其他类型抽取化身开关";
		this.浮生录_数值抽取开关.UseVisualStyleBackColor = true;
		this.浮生录_消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.浮生录_消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.浮生录_消耗类型.FormattingEnabled = true;
		this.浮生录_消耗类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "金钱", "灵气值" });
		this.浮生录_消耗类型.Location = new System.Drawing.Point(93, 200);
		this.浮生录_消耗类型.Name = "浮生录_消耗类型";
		this.浮生录_消耗类型.Size = new System.Drawing.Size(100, 25);
		this.浮生录_消耗类型.TabIndex = 149;
		this.textBox2.Location = new System.Drawing.Point(12, 227);
		this.textBox2.Name = "textBox2";
		this.textBox2.ReadOnly = true;
		this.textBox2.Size = new System.Drawing.Size(80, 23);
		this.textBox2.TabIndex = 150;
		this.textBox2.Text = "特效道具名字";
		this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_特效道具.Location = new System.Drawing.Point(93, 227);
		this.浮生录_特效道具.Name = "浮生录_特效道具";
		this.浮生录_特效道具.Size = new System.Drawing.Size(100, 23);
		this.浮生录_特效道具.TabIndex = 151;
		this.浮生录_一星几率.Location = new System.Drawing.Point(280, 228);
		this.浮生录_一星几率.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.浮生录_一星几率.Name = "浮生录_一星几率";
		this.浮生录_一星几率.Size = new System.Drawing.Size(100, 23);
		this.浮生录_一星几率.TabIndex = 152;
		this.textBox5.Location = new System.Drawing.Point(199, 227);
		this.textBox5.Name = "textBox5";
		this.textBox5.ReadOnly = true;
		this.textBox5.Size = new System.Drawing.Size(80, 23);
		this.textBox5.TabIndex = 153;
		this.textBox5.Text = "一星抽取几率";
		this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_二星几率.Location = new System.Drawing.Point(93, 257);
		this.浮生录_二星几率.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.浮生录_二星几率.Name = "浮生录_二星几率";
		this.浮生录_二星几率.Size = new System.Drawing.Size(100, 23);
		this.浮生录_二星几率.TabIndex = 154;
		this.textBox6.Location = new System.Drawing.Point(12, 256);
		this.textBox6.Name = "textBox6";
		this.textBox6.ReadOnly = true;
		this.textBox6.Size = new System.Drawing.Size(80, 23);
		this.textBox6.TabIndex = 155;
		this.textBox6.Text = "二星抽取几率";
		this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_三星几率.Location = new System.Drawing.Point(280, 257);
		this.浮生录_三星几率.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.浮生录_三星几率.Name = "浮生录_三星几率";
		this.浮生录_三星几率.Size = new System.Drawing.Size(100, 23);
		this.浮生录_三星几率.TabIndex = 156;
		this.textBox7.Location = new System.Drawing.Point(199, 256);
		this.textBox7.Name = "textBox7";
		this.textBox7.ReadOnly = true;
		this.textBox7.Size = new System.Drawing.Size(80, 23);
		this.textBox7.TabIndex = 157;
		this.textBox7.Text = "三星抽取几率";
		this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_四星几率.Location = new System.Drawing.Point(93, 286);
		this.浮生录_四星几率.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.浮生录_四星几率.Name = "浮生录_四星几率";
		this.浮生录_四星几率.Size = new System.Drawing.Size(100, 23);
		this.浮生录_四星几率.TabIndex = 158;
		this.textBox8.Location = new System.Drawing.Point(12, 285);
		this.textBox8.Name = "textBox8";
		this.textBox8.ReadOnly = true;
		this.textBox8.Size = new System.Drawing.Size(80, 23);
		this.textBox8.TabIndex = 159;
		this.textBox8.Text = "四星抽取几率";
		this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_五星几率.Location = new System.Drawing.Point(280, 287);
		this.浮生录_五星几率.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.浮生录_五星几率.Name = "浮生录_五星几率";
		this.浮生录_五星几率.Size = new System.Drawing.Size(100, 23);
		this.浮生录_五星几率.TabIndex = 160;
		this.textBox9.Location = new System.Drawing.Point(199, 286);
		this.textBox9.Name = "textBox9";
		this.textBox9.ReadOnly = true;
		this.textBox9.Size = new System.Drawing.Size(80, 23);
		this.textBox9.TabIndex = 161;
		this.textBox9.Text = "五星抽取几率";
		this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_乱世书属性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.浮生录_乱世书属性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.浮生录_乱世书属性.FormattingEnabled = true;
		this.浮生录_乱世书属性.Items.AddRange(new object[6] { "金相性", "木相性", "水相性", "火相性", "土相性", "所有相性" });
		this.浮生录_乱世书属性.Location = new System.Drawing.Point(93, 346);
		this.浮生录_乱世书属性.Name = "浮生录_乱世书属性";
		this.浮生录_乱世书属性.Size = new System.Drawing.Size(100, 25);
		this.浮生录_乱世书属性.TabIndex = 163;
		this.textBox10.Location = new System.Drawing.Point(12, 320);
		this.textBox10.Name = "textBox10";
		this.textBox10.ReadOnly = true;
		this.textBox10.Size = new System.Drawing.Size(181, 23);
		this.textBox10.TabIndex = 162;
		this.textBox10.Text = "乱世书化身全部激活获得属性";
		this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_乱世书数值.Location = new System.Drawing.Point(199, 347);
		this.浮生录_乱世书数值.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.浮生录_乱世书数值.Name = "浮生录_乱世书数值";
		this.浮生录_乱世书数值.Size = new System.Drawing.Size(181, 23);
		this.浮生录_乱世书数值.TabIndex = 164;
		this.浮生录_千钧卷数值.Location = new System.Drawing.Point(199, 445);
		this.浮生录_千钧卷数值.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.浮生录_千钧卷数值.Name = "浮生录_千钧卷数值";
		this.浮生录_千钧卷数值.Size = new System.Drawing.Size(181, 23);
		this.浮生录_千钧卷数值.TabIndex = 167;
		this.浮生录_千钧卷属性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.浮生录_千钧卷属性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.浮生录_千钧卷属性.FormattingEnabled = true;
		this.浮生录_千钧卷属性.Items.AddRange(new object[6] { "金相性", "木相性", "水相性", "火相性", "土相性", "所有相性" });
		this.浮生录_千钧卷属性.Location = new System.Drawing.Point(93, 436);
		this.浮生录_千钧卷属性.Name = "浮生录_千钧卷属性";
		this.浮生录_千钧卷属性.Size = new System.Drawing.Size(100, 25);
		this.浮生录_千钧卷属性.TabIndex = 166;
		this.textBox12.Location = new System.Drawing.Point(12, 410);
		this.textBox12.Name = "textBox12";
		this.textBox12.ReadOnly = true;
		this.textBox12.Size = new System.Drawing.Size(181, 23);
		this.textBox12.TabIndex = 165;
		this.textBox12.Text = "千钧卷化身全部激活获得属性";
		this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_灵虚卷数值.Location = new System.Drawing.Point(199, 521);
		this.浮生录_灵虚卷数值.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.浮生录_灵虚卷数值.Name = "浮生录_灵虚卷数值";
		this.浮生录_灵虚卷数值.Size = new System.Drawing.Size(181, 23);
		this.浮生录_灵虚卷数值.TabIndex = 170;
		this.浮生录_灵虚卷属性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.浮生录_灵虚卷属性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.浮生录_灵虚卷属性.FormattingEnabled = true;
		this.浮生录_灵虚卷属性.Items.AddRange(new object[6] { "金相性", "木相性", "水相性", "火相性", "土相性", "所有相性" });
		this.浮生录_灵虚卷属性.Location = new System.Drawing.Point(93, 520);
		this.浮生录_灵虚卷属性.Name = "浮生录_灵虚卷属性";
		this.浮生录_灵虚卷属性.Size = new System.Drawing.Size(100, 25);
		this.浮生录_灵虚卷属性.TabIndex = 169;
		this.textBox13.Location = new System.Drawing.Point(12, 494);
		this.textBox13.Name = "textBox13";
		this.textBox13.ReadOnly = true;
		this.textBox13.Size = new System.Drawing.Size(181, 23);
		this.textBox13.TabIndex = 168;
		this.textBox13.Text = "灵虚卷化身全部激活获得属性";
		this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_御元卷数值.Location = new System.Drawing.Point(199, 606);
		this.浮生录_御元卷数值.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.浮生录_御元卷数值.Name = "浮生录_御元卷数值";
		this.浮生录_御元卷数值.Size = new System.Drawing.Size(181, 23);
		this.浮生录_御元卷数值.TabIndex = 173;
		this.浮生录_御元卷属性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.浮生录_御元卷属性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.浮生录_御元卷属性.FormattingEnabled = true;
		this.浮生录_御元卷属性.Items.AddRange(new object[6] { "金相性", "木相性", "水相性", "火相性", "土相性", "所有相性" });
		this.浮生录_御元卷属性.Location = new System.Drawing.Point(93, 605);
		this.浮生录_御元卷属性.Name = "浮生录_御元卷属性";
		this.浮生录_御元卷属性.Size = new System.Drawing.Size(100, 25);
		this.浮生录_御元卷属性.TabIndex = 172;
		this.textBox14.Location = new System.Drawing.Point(12, 579);
		this.textBox14.Name = "textBox14";
		this.textBox14.ReadOnly = true;
		this.textBox14.Size = new System.Drawing.Size(181, 23);
		this.textBox14.TabIndex = 171;
		this.textBox14.Text = "御元卷化身全部激活获得属性";
		this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_乘风卷数值.Location = new System.Drawing.Point(199, 690);
		this.浮生录_乘风卷数值.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.浮生录_乘风卷数值.Name = "浮生录_乘风卷数值";
		this.浮生录_乘风卷数值.Size = new System.Drawing.Size(181, 23);
		this.浮生录_乘风卷数值.TabIndex = 176;
		this.浮生录_乘风卷属性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.浮生录_乘风卷属性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.浮生录_乘风卷属性.FormattingEnabled = true;
		this.浮生录_乘风卷属性.Items.AddRange(new object[6] { "金相性", "木相性", "水相性", "火相性", "土相性", "所有相性" });
		this.浮生录_乘风卷属性.Location = new System.Drawing.Point(93, 689);
		this.浮生录_乘风卷属性.Name = "浮生录_乘风卷属性";
		this.浮生录_乘风卷属性.Size = new System.Drawing.Size(100, 25);
		this.浮生录_乘风卷属性.TabIndex = 175;
		this.textBox15.Location = new System.Drawing.Point(12, 663);
		this.textBox15.Name = "textBox15";
		this.textBox15.ReadOnly = true;
		this.textBox15.Size = new System.Drawing.Size(181, 23);
		this.textBox15.TabIndex = 174;
		this.textBox15.Text = "乘风卷化身全部激活获得属性";
		this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_化身列表.AllowUserToAddRows = false;
		this.浮生录_化身列表.AllowUserToDeleteRows = false;
		this.浮生录_化身列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.浮生录_化身列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.浮生录_化身列表.BackgroundColor = System.Drawing.Color.White;
		this.浮生录_化身列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.浮生录_化身列表.Columns.AddRange(this.化身名字, this.化身分类, this.化身星级, this.碎化数量);
		this.浮生录_化身列表.Location = new System.Drawing.Point(6, 51);
		this.浮生录_化身列表.MultiSelect = false;
		this.浮生录_化身列表.Name = "浮生录_化身列表";
		this.浮生录_化身列表.RowHeadersVisible = false;
		this.浮生录_化身列表.RowTemplate.Height = 25;
		this.浮生录_化身列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.浮生录_化身列表.Size = new System.Drawing.Size(620, 591);
		this.浮生录_化身列表.TabIndex = 177;
		this.textBox16.Location = new System.Drawing.Point(6, 22);
		this.textBox16.Name = "textBox16";
		this.textBox16.ReadOnly = true;
		this.textBox16.Size = new System.Drawing.Size(73, 23);
		this.textBox16.TabIndex = 178;
		this.textBox16.Text = "化身名字";
		this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_添加化身名字.Location = new System.Drawing.Point(85, 22);
		this.浮生录_添加化身名字.Name = "浮生录_添加化身名字";
		this.浮生录_添加化身名字.Size = new System.Drawing.Size(127, 23);
		this.浮生录_添加化身名字.TabIndex = 179;
		this.浮生录_添加化身分类.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.浮生录_添加化身分类.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.浮生录_添加化身分类.FormattingEnabled = true;
		this.浮生录_添加化身分类.Items.AddRange(new object[5] { "乱世书", "千钧卷", "灵虚卷", "御元卷", "乘风卷" });
		this.浮生录_添加化身分类.Location = new System.Drawing.Point(267, 21);
		this.浮生录_添加化身分类.Name = "浮生录_添加化身分类";
		this.浮生录_添加化身分类.Size = new System.Drawing.Size(70, 25);
		this.浮生录_添加化身分类.TabIndex = 180;
		this.浮生录_添加化身星级.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.浮生录_添加化身星级.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.浮生录_添加化身星级.FormattingEnabled = true;
		this.浮生录_添加化身星级.Items.AddRange(new object[5] { "一星", "二星", "三星", "四星", "五星" });
		this.浮生录_添加化身星级.Location = new System.Drawing.Point(391, 21);
		this.浮生录_添加化身星级.Name = "浮生录_添加化身星级";
		this.浮生录_添加化身星级.Size = new System.Drawing.Size(54, 25);
		this.浮生录_添加化身星级.TabIndex = 181;
		this.textBox18.Location = new System.Drawing.Point(451, 22);
		this.textBox18.Name = "textBox18";
		this.textBox18.ReadOnly = true;
		this.textBox18.Size = new System.Drawing.Size(35, 23);
		this.textBox18.TabIndex = 182;
		this.textBox18.Text = "碎化";
		this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_添加化身碎化.Location = new System.Drawing.Point(492, 22);
		this.浮生录_添加化身碎化.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.浮生录_添加化身碎化.Name = "浮生录_添加化身碎化";
		this.浮生录_添加化身碎化.Size = new System.Drawing.Size(67, 23);
		this.浮生录_添加化身碎化.TabIndex = 183;
		this.textBox19.Location = new System.Drawing.Point(219, 22);
		this.textBox19.Name = "textBox19";
		this.textBox19.ReadOnly = true;
		this.textBox19.Size = new System.Drawing.Size(42, 23);
		this.textBox19.TabIndex = 184;
		this.textBox19.Text = "分类";
		this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox20.Location = new System.Drawing.Point(343, 22);
		this.textBox20.Name = "textBox20";
		this.textBox20.ReadOnly = true;
		this.textBox20.Size = new System.Drawing.Size(42, 23);
		this.textBox20.TabIndex = 185;
		this.textBox20.Text = "星级";
		this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.浮生录_添加化身按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.浮生录_添加化身按钮.Location = new System.Drawing.Point(566, 22);
		this.浮生录_添加化身按钮.Name = "浮生录_添加化身按钮";
		this.浮生录_添加化身按钮.Size = new System.Drawing.Size(60, 24);
		this.浮生录_添加化身按钮.TabIndex = 186;
		this.浮生录_添加化身按钮.Text = "添加";
		this.浮生录_添加化身按钮.UseVisualStyleBackColor = true;
		this.浮生录_添加化身按钮.Click += new System.EventHandler(浮生录_添加化身按钮_Click);
		this.groupBox2.Controls.Add(this.textBox16);
		this.groupBox2.Controls.Add(this.浮生录_化身列表);
		this.groupBox2.Controls.Add(this.浮生录_添加化身按钮);
		this.groupBox2.Controls.Add(this.浮生录_添加化身名字);
		this.groupBox2.Controls.Add(this.textBox20);
		this.groupBox2.Controls.Add(this.浮生录_添加化身分类);
		this.groupBox2.Controls.Add(this.textBox19);
		this.groupBox2.Controls.Add(this.浮生录_添加化身星级);
		this.groupBox2.Controls.Add(this.浮生录_添加化身碎化);
		this.groupBox2.Controls.Add(this.textBox18);
		this.groupBox2.Location = new System.Drawing.Point(404, 107);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(632, 648);
		this.groupBox2.TabIndex = 187;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "添加浮生录化身配置";
		this.label17.ForeColor = System.Drawing.Color.Red;
		this.label17.Location = new System.Drawing.Point(352, 0);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(569, 49);
		this.label17.TabIndex = 188;
		this.label17.Text = "该消耗道具必须写成材料，具体写法可参照后台首页中的材料礼包例子";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label1.ForeColor = System.Drawing.Color.Red;
		this.label1.Location = new System.Drawing.Point(241, 311);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(139, 20);
		this.label1.TabIndex = 189;
		this.label1.Text = "抽取几率区间：1-1000";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.textBox4.Location = new System.Drawing.Point(32, 347);
		this.textBox4.Name = "textBox4";
		this.textBox4.ReadOnly = true;
		this.textBox4.Size = new System.Drawing.Size(60, 23);
		this.textBox4.TabIndex = 190;
		this.textBox4.Text = "普通属性";
		this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.textBox22.Location = new System.Drawing.Point(32, 437);
		this.textBox22.Name = "textBox22";
		this.textBox22.ReadOnly = true;
		this.textBox22.Size = new System.Drawing.Size(60, 23);
		this.textBox22.TabIndex = 197;
		this.textBox22.Text = "普通属性";
		this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.textBox24.Location = new System.Drawing.Point(32, 521);
		this.textBox24.Name = "textBox24";
		this.textBox24.ReadOnly = true;
		this.textBox24.Size = new System.Drawing.Size(60, 23);
		this.textBox24.TabIndex = 199;
		this.textBox24.Text = "普通属性";
		this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.textBox26.Location = new System.Drawing.Point(32, 606);
		this.textBox26.Name = "textBox26";
		this.textBox26.ReadOnly = true;
		this.textBox26.Size = new System.Drawing.Size(60, 23);
		this.textBox26.TabIndex = 201;
		this.textBox26.Text = "普通属性";
		this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.textBox28.Location = new System.Drawing.Point(32, 690);
		this.textBox28.Name = "textBox28";
		this.textBox28.ReadOnly = true;
		this.textBox28.Size = new System.Drawing.Size(60, 23);
		this.textBox28.TabIndex = 203;
		this.textBox28.Text = "普通属性";
		this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.化身名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.化身名字.Frozen = true;
		this.化身名字.HeaderText = "化身名字";
		this.化身名字.MinimumWidth = 150;
		this.化身名字.Name = "化身名字";
		this.化身名字.ReadOnly = true;
		this.化身名字.Width = 150;
		this.化身分类.HeaderText = "化身分类";
		this.化身分类.Items.AddRange("乱世书", "千钧卷", "灵虚卷", "御元卷", "乘风卷");
		this.化身分类.MinimumWidth = 100;
		this.化身分类.Name = "化身分类";
		this.化身分类.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.化身分类.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.化身星级.HeaderText = "化身星级";
		this.化身星级.Items.AddRange("一星", "二星", "三星", "四星", "五星");
		this.化身星级.MinimumWidth = 100;
		this.化身星级.Name = "化身星级";
		this.化身星级.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.化身星级.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.碎化数量.HeaderText = "碎化数量";
		this.碎化数量.MinimumWidth = 80;
		this.碎化数量.Name = "碎化数量";
		this.碎化数量.Width = 80;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1048, 766);
		base.Controls.Add(this.textBox28);
		base.Controls.Add(this.textBox26);
		base.Controls.Add(this.textBox24);
		base.Controls.Add(this.textBox22);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.label17);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.浮生录_乘风卷数值);
		base.Controls.Add(this.浮生录_乘风卷属性);
		base.Controls.Add(this.textBox15);
		base.Controls.Add(this.浮生录_御元卷数值);
		base.Controls.Add(this.浮生录_御元卷属性);
		base.Controls.Add(this.textBox14);
		base.Controls.Add(this.浮生录_灵虚卷数值);
		base.Controls.Add(this.浮生录_灵虚卷属性);
		base.Controls.Add(this.textBox13);
		base.Controls.Add(this.浮生录_千钧卷数值);
		base.Controls.Add(this.浮生录_千钧卷属性);
		base.Controls.Add(this.textBox12);
		base.Controls.Add(this.浮生录_乱世书数值);
		base.Controls.Add(this.浮生录_乱世书属性);
		base.Controls.Add(this.textBox10);
		base.Controls.Add(this.浮生录_五星几率);
		base.Controls.Add(this.textBox9);
		base.Controls.Add(this.浮生录_四星几率);
		base.Controls.Add(this.textBox8);
		base.Controls.Add(this.浮生录_三星几率);
		base.Controls.Add(this.textBox7);
		base.Controls.Add(this.浮生录_二星几率);
		base.Controls.Add(this.textBox6);
		base.Controls.Add(this.浮生录_一星几率);
		base.Controls.Add(this.textBox5);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.浮生录_特效道具);
		base.Controls.Add(this.浮生录_消耗类型);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.浮生录_数值消耗数量);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.浮生录_数值10连抽开关);
		base.Controls.Add(this.浮生录_数值抽取开关);
		base.Controls.Add(this.地狱道_名字);
		base.Controls.Add(this.浮生录_道具名字);
		base.Controls.Add(this.浮生录_道具消耗数量);
		base.Controls.Add(this.textBox11);
		base.Controls.Add(this.浮生录_道具10连抽开关);
		base.Controls.Add(this.浮生录_道具抽取开关);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.浮生录_开关);
		base.Controls.Add(this.浮生录_重载按钮);
		base.Controls.Add(this.浮生录_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "浮生录配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "浮生录配置窗口";
		base.Load += new System.EventHandler(浮生录配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.浮生录_形象).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_坐标Y).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_坐标X).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_道具消耗数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_数值消耗数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_一星几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_二星几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_三星几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_四星几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_五星几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_乱世书数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_千钧卷数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_灵虚卷数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_御元卷数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_乘风卷数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_化身列表).EndInit();
		((System.ComponentModel.ISupportInitialize)this.浮生录_添加化身碎化).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
