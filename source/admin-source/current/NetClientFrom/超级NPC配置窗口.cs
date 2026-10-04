using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 超级NPC配置窗口 : Form
{
	private static 超级NPC配置窗口 i;

	private IContainer components;

	private DataGridView 超级npc_npc列表;

	private Button 超级npc_添加按钮;

	private CheckBox 超级npc_开关;

	private Button 超级npc_重载按钮;

	private Button 超级npc_保存按钮;

	private GroupBox groupBox1;

	private CheckBox 超级npc_是否显示;

	private NumericUpDown 超级npc_坐标X;

	private Label label7;

	private Label label5;

	private TextBox 超级npc_npc称号;

	private Label label4;

	private TextBox 超级npc_npc名字;

	private Label label3;

	private TextBox 超级npc_对话文本;

	private Label label2;

	private TextBox 超级npc_所在地图;

	private Label label8;

	private NumericUpDown 超级npc_坐标Y;

	private NumericUpDown 超级npc_形象;

	private Label label9;

	private ComboBox 超级npc_朝向;

	private Label label6;

	private Label label1;

	private TextBox 超级npc_传送列表;

	private DataGridViewTextBoxColumn npc名字;

	private DataGridViewTextBoxColumn 所在地图;

	private DataGridViewTextBoxColumn 坐标;

	private DataGridViewTextBoxColumn 是否显示;

	private DataGridViewTextBoxColumn 传送地图列表;

	private Panel 修改窗口;

	private Label label15;

	private TextBox 修改_所在地图;

	private CheckBox 修改_是否显示;

	private NumericUpDown 修改_npc形象;

	private Label label10;

	private ComboBox 修改_npc朝向;

	private Label label11;

	private NumericUpDown 修改_npc坐标Y;

	private NumericUpDown 修改_npc坐标X;

	private Label label12;

	private Label label13;

	private TextBox 修改_npc称号;

	private Label label14;

	private TextBox 修改_npc名字;

	private Button 修改_取消按钮;

	private Button 修改_确定按钮;

	private DataGridView 修改_传送列表;

	private Label label16;

	private TextBox 修改_对话文本;

	private DataGridViewTextBoxColumn 传送地图名字;

	private DataGridViewTextBoxColumn 传送选项文字;

	private DataGridViewTextBoxColumn 坐标X;

	private DataGridViewTextBoxColumn 坐标Y;

	public static 超级NPC配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 超级NPC配置窗口();
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

	public 超级NPC配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 超级NPC配置窗口_Load(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			超级npc_npc列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(修改事件回调, 删除事件回调);
			修改_取消按钮.Click += delegate
			{
				修改窗口.Visible = false;
			};
			修改_确定按钮.Click += 确定修改事件回调;
			修改_传送列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 修改_删除事件回调);
			Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
			全局变量类 obj = Singleton<全局变量类>.I;
			obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
			超级npc_重载按钮_Click(sender, e);
		}
	}

	private void 修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 超级npc_npc列表.CurrentRow == null)
		{
			return;
		}
		int index = 超级npc_npc列表.CurrentRow.Index;
		if (index < 0)
		{
			return;
		}
		DataGridViewCellCollection cells = 超级npc_npc列表.Rows[index].Cells;
		修改_npc名字.Text = cells["npc名字"].Value.ToString();
		超级NPC列表类 超级NPC列表类2 = Singleton<全局变量类>.I.超级NPC配置.NPC列表.Find((超级NPC列表类 x) => x.NPC数据.npc名字 == 修改_npc名字.Text);
		if (超级NPC列表类2 != null)
		{
			修改_npc称号.Text = 超级NPC列表类2.NPC数据.npc称号;
			修改_npc坐标X.Value = 超级NPC列表类2.NPC数据.坐标.X;
			修改_npc坐标Y.Value = 超级NPC列表类2.NPC数据.坐标.Y;
			ComboBox comboBox = 修改_npc朝向;
			AllEnums.朝向Type 朝向 = (AllEnums.朝向Type)超级NPC列表类2.NPC数据.朝向;
			comboBox.Text = 朝向.ToString();
			修改_npc形象.Value = 超级NPC列表类2.NPC数据.npc形象;
			修改_是否显示.Checked = 超级NPC列表类2.是否显示;
			修改_所在地图.Text = 超级NPC列表类2.所在地图;
			修改_对话文本.Text = 超级NPC列表类2.对话介绍;
			修改_传送列表.Rows.Clear();
			for (int num = 0; num < 超级NPC列表类2.地图列表.Count; num++)
			{
				修改_传送列表.Rows.Add(超级NPC列表类2.地图列表[num].地图名字, 超级NPC列表类2.地图列表[num].选项文字, 超级NPC列表类2.地图列表[num].X坐标, 超级NPC列表类2.地图列表[num].Y坐标);
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
		超级NPC列表类 超级NPC列表类2 = Singleton<全局变量类>.I.超级NPC配置.NPC列表.Find((超级NPC列表类 x) => x.NPC数据.npc名字 == 修改_npc名字.Text);
		if (超级NPC列表类2 == null)
		{
			return;
		}
		List<超级NPC传送类> list = new List<超级NPC传送类>();
		for (int num = 0; num < 修改_传送列表.Rows.Count; num++)
		{
			DataGridViewCellCollection cells = 修改_传送列表.Rows[num].Cells;
			string 传送地图名字 = cells["传送地图名字"].Value?.ToString();
			string 选项文字 = cells["传送选项文字"].Value?.ToString();
			string text = cells["坐标X"].Value?.ToString();
			if (text == null)
			{
				text = string.Empty;
			}
			string text2 = cells["坐标Y"].Value?.ToString();
			if (text2 == null)
			{
				text2 = string.Empty;
			}
			if (!string.IsNullOrWhiteSpace(传送地图名字))
			{
				if (list.Count > 0 && list.Any((超级NPC传送类 x) => x.地图名字 == 传送地图名字))
				{
					MessageBox.Show("传送地图列表中已经存在【" + 传送地图名字 + "】，无法重复添加！");
					return;
				}
				list.Add(new 超级NPC传送类
				{
					地图名字 = 传送地图名字,
					选项文字 = 选项文字,
					X坐标 = text,
					Y坐标 = text2
				});
			}
		}
		超级NPC列表类2.NPC数据.npc称号 = 修改_npc称号.Text;
		超级NPC列表类2.NPC数据.坐标.X = (short)修改_npc坐标X.Value;
		超级NPC列表类2.NPC数据.坐标.Y = (short)修改_npc坐标Y.Value;
		超级NPC列表类2.NPC数据.朝向 = (short)Enum.Parse<AllEnums.朝向Type>(修改_npc朝向.Text);
		超级NPC列表类2.NPC数据.npc形象 = (int)修改_npc形象.Value;
		超级NPC列表类2.是否显示 = 修改_是否显示.Checked;
		超级NPC列表类2.所在地图 = 修改_所在地图.Text;
		超级NPC列表类2.对话介绍 = 修改_对话文本.Text;
		超级NPC列表类2.地图列表 = list;
		修改窗口.Visible = false;
		if (超级npc_npc列表.CurrentRow == null)
		{
			return;
		}
		int index = 超级npc_npc列表.CurrentRow.Index;
		if (index >= 0)
		{
			DataGridViewCellCollection cells2 = 超级npc_npc列表.Rows[index].Cells;
			cells2["所在地图"].Value = 超级NPC列表类2.所在地图;
			cells2["坐标"].Value = $"[{超级NPC列表类2.NPC数据.坐标.X},{超级NPC列表类2.NPC数据.坐标.Y}]";
			cells2["是否显示"].Value = (超级NPC列表类2.是否显示 ? "是" : "否");
			string text3 = string.Empty;
			for (int num2 = 0; num2 < 超级NPC列表类2.地图列表.Count; num2++)
			{
				text3 = ((num2 != 0) ? (text3 + $"|{超级NPC列表类2.地图列表[num2].地图名字},{超级NPC列表类2.地图列表[num2].X坐标},{超级NPC列表类2.地图列表[num2].Y坐标}") : (text3 + $"{超级NPC列表类2.地图列表[num2].地图名字},{超级NPC列表类2.地图列表[num2].X坐标},{超级NPC列表类2.地图列表[num2].Y坐标}"));
			}
			cells2["传送地图列表"].Value = text3;
			MessageBox.Show("[" + 修改_npc名字.Text + "]的配置已经修改，请及时点击保存配置按钮更新服务端配置！");
		}
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 超级npc_npc列表.CurrentRow == null)
		{
			return;
		}
		int index = 超级npc_npc列表.CurrentRow.Index;
		if (index >= 0)
		{
			DataGridViewCellCollection cells = 超级npc_npc列表.Rows[index].Cells;
			string 当前key = cells["npc名字"].Value.ToString();
			int num = Singleton<全局变量类>.I.超级NPC配置.NPC列表.FindIndex((超级NPC列表类 x) => x.NPC数据.npc名字 == 当前key);
			if (num >= 0)
			{
				Singleton<全局变量类>.I.超级NPC配置.NPC列表.RemoveAt(num);
				MessageBox.Show("[" + 当前key + "]已从列表中删除，请及时点击保存配置按钮更新服务端配置！");
				超级npc_npc列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 修改_删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 修改_传送列表.CurrentRow != null)
		{
			int index = 修改_传送列表.CurrentRow.Index;
			if (index >= 0)
			{
				修改_传送列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 36)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			超级npc_开关.Checked = Singleton<全局变量类>.I.超级NPC配置.功能开关;
			超级npc_npc列表.Rows.Clear();
			foreach (超级NPC列表类 item in Singleton<全局变量类>.I.超级NPC配置.NPC列表)
			{
				string text = string.Empty;
				for (int i = 0; i < item.地图列表.Count; i++)
				{
					text = ((i != 0) ? (text + $"|{item.地图列表[i].地图名字},{item.地图列表[i].X坐标},{item.地图列表[i].Y坐标}") : (text + $"{item.地图列表[i].地图名字},{item.地图列表[i].X坐标},{item.地图列表[i].Y坐标}"));
				}
				超级npc_npc列表.Rows.Add(item.NPC数据.npc名字, item.所在地图, $"[{item.NPC数据.坐标.X},{item.NPC数据.坐标.Y}]", item.是否显示 ? "是" : "否", text);
			}
		});
	}

	private void 配置变量赋值()
	{
		Singleton<全局变量类>.I.超级NPC配置.功能开关 = 超级npc_开关.Checked;
	}

	private void 超级npc_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 36, JsonConvert.SerializeObject(Singleton<全局变量类>.I.超级NPC配置, Formatting.Indented));
		}
	}

	private void 超级npc_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 36);
		}
	}

	private void 超级npc_添加按钮_Click(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(超级npc_npc名字.Text))
		{
			MessageBox.Show("请输入要添加的传送npc名字！");
			return;
		}
		if (超级npc_坐标X.Value == 0m || 超级npc_坐标Y.Value == 0m)
		{
			MessageBox.Show("请输入要添加的传送npc的坐标！");
			return;
		}
		if (string.IsNullOrWhiteSpace(超级npc_朝向.Text))
		{
			MessageBox.Show("请选择【" + 超级npc_npc名字.Text + "】的朝向！");
			return;
		}
		if (string.IsNullOrWhiteSpace(超级npc_所在地图.Text))
		{
			MessageBox.Show("请填写【" + 超级npc_npc名字.Text + "】所在的地图名字！");
			return;
		}
		if (string.IsNullOrWhiteSpace(超级npc_传送列表.Text))
		{
			MessageBox.Show("请填写【" + 超级npc_npc名字.Text + "】可传送的地图信息！");
			return;
		}
		if (Singleton<全局变量类>.I.超级NPC配置.NPC列表.Any((超级NPC列表类 x) => x.NPC数据.npc名字 == 超级npc_npc名字.Text))
		{
			MessageBox.Show("列表中已经存在【" + 超级npc_npc名字.Text + "】，无法重复添加！");
			return;
		}
		超级NPC列表类 超级NPC列表类2 = new 超级NPC列表类
		{
			是否显示 = 超级npc_是否显示.Checked,
			所在地图 = 超级npc_所在地图.Text,
			对话介绍 = 超级npc_对话文本.Text
		};
		超级NPC列表类2.NPC数据.npc名字 = 超级npc_npc名字.Text;
		超级NPC列表类2.NPC数据.npc称号 = 超级npc_npc称号.Text;
		超级NPC列表类2.NPC数据.npc形象 = (int)超级npc_形象.Value;
		超级NPC列表类2.NPC数据.朝向 = (short)Enum.Parse<AllEnums.朝向Type>(超级npc_朝向.Text);
		超级NPC列表类2.NPC数据.坐标.X = (short)超级npc_坐标X.Value;
		超级NPC列表类2.NPC数据.坐标.Y = (short)超级npc_坐标Y.Value;
		do
		{
			Singleton<全局变量类>.I.超级NPC配置.自增id++;
		}
		while (Singleton<全局变量类>.I.超级NPC配置.NPC列表.Any((超级NPC列表类 x) => x.NPC数据.npcid == Singleton<全局变量类>.I.超级NPC配置.自增id));
		超级NPC列表类2.NPC数据.npcid = Singleton<全局变量类>.I.超级NPC配置.自增id;
		string[] array = 超级npc_传送列表.Text.Split("|");
		for (int num = 0; num < array.Length; num++)
		{
			string[] array2 = array[num].Split(",");
			if (array2.Length == 3)
			{
				超级NPC列表类2.地图列表.Add(new 超级NPC传送类
				{
					地图名字 = array2[0],
					X坐标 = array2[1],
					Y坐标 = array2[2]
				});
			}
		}
		Singleton<全局变量类>.I.超级NPC配置.NPC列表.Add(超级NPC列表类2);
		超级npc_npc列表.Rows.Add(超级NPC列表类2.NPC数据.npc名字, 超级NPC列表类2.所在地图, $"[{超级NPC列表类2.NPC数据.坐标.X},{超级NPC列表类2.NPC数据.坐标.Y}]", 超级NPC列表类2.是否显示 ? "是" : "否", 超级npc_传送列表.Text);
		MessageBox.Show("[" + 超级NPC列表类2.NPC数据.npc名字 + "]添加成功");
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.超级NPC配置窗口));
		this.超级npc_npc列表 = new System.Windows.Forms.DataGridView();
		this.npc名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.所在地图 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.坐标 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.是否显示 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.传送地图列表 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.超级npc_添加按钮 = new System.Windows.Forms.Button();
		this.超级npc_开关 = new System.Windows.Forms.CheckBox();
		this.超级npc_重载按钮 = new System.Windows.Forms.Button();
		this.超级npc_保存按钮 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label6 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.超级npc_传送列表 = new System.Windows.Forms.TextBox();
		this.超级npc_形象 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.超级npc_朝向 = new System.Windows.Forms.ComboBox();
		this.label8 = new System.Windows.Forms.Label();
		this.超级npc_坐标Y = new System.Windows.Forms.NumericUpDown();
		this.超级npc_坐标X = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.超级npc_npc称号 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.超级npc_npc名字 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.超级npc_对话文本 = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.超级npc_所在地图 = new System.Windows.Forms.TextBox();
		this.超级npc_是否显示 = new System.Windows.Forms.CheckBox();
		this.修改窗口 = new System.Windows.Forms.Panel();
		this.修改_取消按钮 = new System.Windows.Forms.Button();
		this.修改_确定按钮 = new System.Windows.Forms.Button();
		this.修改_传送列表 = new System.Windows.Forms.DataGridView();
		this.传送地图名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.传送选项文字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.坐标X = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.坐标Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.label16 = new System.Windows.Forms.Label();
		this.修改_对话文本 = new System.Windows.Forms.TextBox();
		this.label15 = new System.Windows.Forms.Label();
		this.修改_所在地图 = new System.Windows.Forms.TextBox();
		this.修改_是否显示 = new System.Windows.Forms.CheckBox();
		this.修改_npc形象 = new System.Windows.Forms.NumericUpDown();
		this.label10 = new System.Windows.Forms.Label();
		this.修改_npc朝向 = new System.Windows.Forms.ComboBox();
		this.label11 = new System.Windows.Forms.Label();
		this.修改_npc坐标Y = new System.Windows.Forms.NumericUpDown();
		this.修改_npc坐标X = new System.Windows.Forms.NumericUpDown();
		this.label12 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.修改_npc称号 = new System.Windows.Forms.TextBox();
		this.label14 = new System.Windows.Forms.Label();
		this.修改_npc名字 = new System.Windows.Forms.TextBox();
		((System.ComponentModel.ISupportInitialize)this.超级npc_npc列表).BeginInit();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.超级npc_形象).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.超级npc_坐标Y).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.超级npc_坐标X).BeginInit();
		this.修改窗口.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_传送列表).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_npc形象).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_npc坐标Y).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修改_npc坐标X).BeginInit();
		base.SuspendLayout();
		this.超级npc_npc列表.AllowUserToAddRows = false;
		this.超级npc_npc列表.AllowUserToDeleteRows = false;
		this.超级npc_npc列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.超级npc_npc列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.超级npc_npc列表.BackgroundColor = System.Drawing.Color.White;
		this.超级npc_npc列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.超级npc_npc列表.Columns.AddRange(this.npc名字, this.所在地图, this.坐标, this.是否显示, this.传送地图列表);
		this.超级npc_npc列表.Location = new System.Drawing.Point(12, 192);
		this.超级npc_npc列表.MultiSelect = false;
		this.超级npc_npc列表.Name = "超级npc_npc列表";
		this.超级npc_npc列表.ReadOnly = true;
		this.超级npc_npc列表.RowHeadersVisible = false;
		this.超级npc_npc列表.RowTemplate.Height = 25;
		this.超级npc_npc列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.超级npc_npc列表.Size = new System.Drawing.Size(755, 357);
		this.超级npc_npc列表.TabIndex = 89;
		this.npc名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.npc名字.HeaderText = "npc名字";
		this.npc名字.MinimumWidth = 80;
		this.npc名字.Name = "npc名字";
		this.npc名字.ReadOnly = true;
		this.npc名字.Width = 80;
		this.所在地图.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.所在地图.HeaderText = "所在地图";
		this.所在地图.MinimumWidth = 100;
		this.所在地图.Name = "所在地图";
		this.所在地图.ReadOnly = true;
		this.坐标.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.坐标.HeaderText = "坐标";
		this.坐标.MinimumWidth = 80;
		this.坐标.Name = "坐标";
		this.坐标.ReadOnly = true;
		this.坐标.Width = 80;
		this.是否显示.HeaderText = "是否显示";
		this.是否显示.MinimumWidth = 80;
		this.是否显示.Name = "是否显示";
		this.是否显示.ReadOnly = true;
		this.是否显示.Width = 80;
		this.传送地图列表.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.传送地图列表.HeaderText = "传送地图列表";
		this.传送地图列表.MinimumWidth = 300;
		this.传送地图列表.Name = "传送地图列表";
		this.传送地图列表.ReadOnly = true;
		this.传送地图列表.Width = 300;
		this.超级npc_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级npc_添加按钮.Location = new System.Drawing.Point(691, 79);
		this.超级npc_添加按钮.Name = "超级npc_添加按钮";
		this.超级npc_添加按钮.Size = new System.Drawing.Size(53, 30);
		this.超级npc_添加按钮.TabIndex = 88;
		this.超级npc_添加按钮.Text = "添加";
		this.超级npc_添加按钮.UseVisualStyleBackColor = true;
		this.超级npc_添加按钮.Click += new System.EventHandler(超级npc_添加按钮_Click);
		this.超级npc_开关.AutoSize = true;
		this.超级npc_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级npc_开关.Location = new System.Drawing.Point(12, 12);
		this.超级npc_开关.Name = "超级npc_开关";
		this.超级npc_开关.Size = new System.Drawing.Size(109, 23);
		this.超级npc_开关.TabIndex = 81;
		this.超级npc_开关.Text = "超级NPC开关";
		this.超级npc_开关.UseVisualStyleBackColor = true;
		this.超级npc_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级npc_重载按钮.Location = new System.Drawing.Point(233, 7);
		this.超级npc_重载按钮.Name = "超级npc_重载按钮";
		this.超级npc_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.超级npc_重载按钮.TabIndex = 83;
		this.超级npc_重载按钮.Text = "重载配置";
		this.超级npc_重载按钮.UseVisualStyleBackColor = true;
		this.超级npc_重载按钮.Click += new System.EventHandler(超级npc_重载按钮_Click);
		this.超级npc_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级npc_保存按钮.Location = new System.Drawing.Point(127, 7);
		this.超级npc_保存按钮.Name = "超级npc_保存按钮";
		this.超级npc_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.超级npc_保存按钮.TabIndex = 82;
		this.超级npc_保存按钮.Text = "保存配置";
		this.超级npc_保存按钮.UseVisualStyleBackColor = true;
		this.超级npc_保存按钮.Click += new System.EventHandler(超级npc_保存按钮_Click);
		this.groupBox1.Controls.Add(this.label6);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.超级npc_传送列表);
		this.groupBox1.Controls.Add(this.超级npc_添加按钮);
		this.groupBox1.Controls.Add(this.超级npc_形象);
		this.groupBox1.Controls.Add(this.label9);
		this.groupBox1.Controls.Add(this.超级npc_朝向);
		this.groupBox1.Controls.Add(this.label8);
		this.groupBox1.Controls.Add(this.超级npc_坐标Y);
		this.groupBox1.Controls.Add(this.超级npc_坐标X);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.超级npc_npc称号);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.超级npc_npc名字);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.超级npc_对话文本);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.超级npc_所在地图);
		this.groupBox1.Controls.Add(this.超级npc_是否显示);
		this.groupBox1.Location = new System.Drawing.Point(12, 43);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(755, 143);
		this.groupBox1.TabIndex = 90;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "添加超级npc配置";
		this.label6.ForeColor = System.Drawing.Color.Red;
		this.label6.Location = new System.Drawing.Point(67, 106);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(618, 23);
		this.label6.TabIndex = 104;
		this.label6.Text = "例子：天墉城,200,300|揽仙镇,100,200|东海渔村,150,180  多个传送地图必须用\"|\"连接，传送坐标写0,0为随机传送";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label1.Location = new System.Drawing.Point(6, 83);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 23);
		this.label1.TabIndex = 102;
		this.label1.Text = "传送列表";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.超级npc_传送列表.Location = new System.Drawing.Point(67, 83);
		this.超级npc_传送列表.Name = "超级npc_传送列表";
		this.超级npc_传送列表.Size = new System.Drawing.Size(618, 23);
		this.超级npc_传送列表.TabIndex = 103;
		this.超级npc_形象.Location = new System.Drawing.Point(644, 22);
		this.超级npc_形象.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.超级npc_形象.Name = "超级npc_形象";
		this.超级npc_形象.Size = new System.Drawing.Size(100, 23);
		this.超级npc_形象.TabIndex = 101;
		this.label9.BackColor = System.Drawing.Color.Transparent;
		this.label9.Location = new System.Drawing.Point(611, 22);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(32, 23);
		this.label9.TabIndex = 100;
		this.label9.Text = "形象";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.超级npc_朝向.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.超级npc_朝向.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.超级npc_朝向.FormattingEnabled = true;
		this.超级npc_朝向.Items.AddRange(new object[8] { "左", "左上", "上", "右上", "右", "右下", "下", "左下" });
		this.超级npc_朝向.Location = new System.Drawing.Point(545, 22);
		this.超级npc_朝向.Name = "超级npc_朝向";
		this.超级npc_朝向.Size = new System.Drawing.Size(60, 25);
		this.超级npc_朝向.TabIndex = 99;
		this.label8.BackColor = System.Drawing.Color.Transparent;
		this.label8.Location = new System.Drawing.Point(513, 24);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(32, 23);
		this.label8.TabIndex = 98;
		this.label8.Text = "朝向";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.超级npc_坐标Y.Location = new System.Drawing.Point(447, 24);
		this.超级npc_坐标Y.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.超级npc_坐标Y.Name = "超级npc_坐标Y";
		this.超级npc_坐标Y.Size = new System.Drawing.Size(60, 23);
		this.超级npc_坐标Y.TabIndex = 97;
		this.超级npc_坐标X.Location = new System.Drawing.Point(370, 24);
		this.超级npc_坐标X.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.超级npc_坐标X.Name = "超级npc_坐标X";
		this.超级npc_坐标X.Size = new System.Drawing.Size(60, 23);
		this.超级npc_坐标X.TabIndex = 96;
		this.label7.BackColor = System.Drawing.Color.Transparent;
		this.label7.Location = new System.Drawing.Point(330, 24);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(115, 23);
		this.label7.TabIndex = 95;
		this.label7.Text = "坐标X                 Y";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label5.Location = new System.Drawing.Point(168, 24);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(60, 23);
		this.label5.TabIndex = 92;
		this.label5.Text = "npc称号";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.超级npc_npc称号.Location = new System.Drawing.Point(229, 24);
		this.超级npc_npc称号.Name = "超级npc_npc称号";
		this.超级npc_npc称号.Size = new System.Drawing.Size(100, 23);
		this.超级npc_npc称号.TabIndex = 93;
		this.label4.Location = new System.Drawing.Point(6, 24);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 90;
		this.label4.Text = "npc名字";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.超级npc_npc名字.Location = new System.Drawing.Point(67, 24);
		this.超级npc_npc名字.Name = "超级npc_npc名字";
		this.超级npc_npc名字.Size = new System.Drawing.Size(100, 23);
		this.超级npc_npc名字.TabIndex = 91;
		this.label3.Location = new System.Drawing.Point(279, 53);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(60, 23);
		this.label3.TabIndex = 88;
		this.label3.Text = "对话文本";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.超级npc_对话文本.Location = new System.Drawing.Point(340, 53);
		this.超级npc_对话文本.Name = "超级npc_对话文本";
		this.超级npc_对话文本.Size = new System.Drawing.Size(404, 23);
		this.超级npc_对话文本.TabIndex = 89;
		this.label2.Location = new System.Drawing.Point(92, 53);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(60, 23);
		this.label2.TabIndex = 86;
		this.label2.Text = "所在地图";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.超级npc_所在地图.Location = new System.Drawing.Point(153, 53);
		this.超级npc_所在地图.Name = "超级npc_所在地图";
		this.超级npc_所在地图.Size = new System.Drawing.Size(120, 23);
		this.超级npc_所在地图.TabIndex = 87;
		this.超级npc_是否显示.AutoSize = true;
		this.超级npc_是否显示.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.超级npc_是否显示.Location = new System.Drawing.Point(6, 53);
		this.超级npc_是否显示.Name = "超级npc_是否显示";
		this.超级npc_是否显示.Size = new System.Drawing.Size(80, 23);
		this.超级npc_是否显示.TabIndex = 82;
		this.超级npc_是否显示.Text = "是否显示";
		this.超级npc_是否显示.UseVisualStyleBackColor = true;
		this.修改窗口.Controls.Add(this.修改_取消按钮);
		this.修改窗口.Controls.Add(this.修改_确定按钮);
		this.修改窗口.Controls.Add(this.修改_传送列表);
		this.修改窗口.Controls.Add(this.label16);
		this.修改窗口.Controls.Add(this.修改_对话文本);
		this.修改窗口.Controls.Add(this.label15);
		this.修改窗口.Controls.Add(this.修改_所在地图);
		this.修改窗口.Controls.Add(this.修改_是否显示);
		this.修改窗口.Controls.Add(this.修改_npc形象);
		this.修改窗口.Controls.Add(this.label10);
		this.修改窗口.Controls.Add(this.修改_npc朝向);
		this.修改窗口.Controls.Add(this.label11);
		this.修改窗口.Controls.Add(this.修改_npc坐标Y);
		this.修改窗口.Controls.Add(this.修改_npc坐标X);
		this.修改窗口.Controls.Add(this.label12);
		this.修改窗口.Controls.Add(this.label13);
		this.修改窗口.Controls.Add(this.修改_npc称号);
		this.修改窗口.Controls.Add(this.label14);
		this.修改窗口.Controls.Add(this.修改_npc名字);
		this.修改窗口.Location = new System.Drawing.Point(30, 242);
		this.修改窗口.Name = "修改窗口";
		this.修改窗口.Size = new System.Drawing.Size(703, 255);
		this.修改窗口.TabIndex = 91;
		this.修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_取消按钮.Location = new System.Drawing.Point(129, 212);
		this.修改_取消按钮.Name = "修改_取消按钮";
		this.修改_取消按钮.Size = new System.Drawing.Size(100, 30);
		this.修改_取消按钮.TabIndex = 120;
		this.修改_取消按钮.Text = "取    消";
		this.修改_取消按钮.UseVisualStyleBackColor = true;
		this.修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_确定按钮.Location = new System.Drawing.Point(12, 212);
		this.修改_确定按钮.Name = "修改_确定按钮";
		this.修改_确定按钮.Size = new System.Drawing.Size(100, 30);
		this.修改_确定按钮.TabIndex = 119;
		this.修改_确定按钮.Text = "修     改";
		this.修改_确定按钮.UseVisualStyleBackColor = true;
		this.修改_传送列表.AllowUserToDeleteRows = false;
		this.修改_传送列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.修改_传送列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
		this.修改_传送列表.BackgroundColor = System.Drawing.Color.White;
		this.修改_传送列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.修改_传送列表.Columns.AddRange(this.传送地图名字, this.传送选项文字, this.坐标X, this.坐标Y);
		this.修改_传送列表.Location = new System.Drawing.Point(249, 9);
		this.修改_传送列表.MultiSelect = false;
		this.修改_传送列表.Name = "修改_传送列表";
		this.修改_传送列表.RowHeadersVisible = false;
		this.修改_传送列表.RowTemplate.Height = 25;
		this.修改_传送列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
		this.修改_传送列表.Size = new System.Drawing.Size(450, 235);
		this.修改_传送列表.TabIndex = 118;
		this.传送地图名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.传送地图名字.Frozen = true;
		this.传送地图名字.HeaderText = "传送地图名字";
		this.传送地图名字.MinimumWidth = 120;
		this.传送地图名字.Name = "传送地图名字";
		this.传送地图名字.Width = 120;
		this.传送选项文字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.传送选项文字.Frozen = true;
		this.传送选项文字.HeaderText = "选项文字";
		this.传送选项文字.MinimumWidth = 150;
		this.传送选项文字.Name = "传送选项文字";
		this.传送选项文字.ToolTipText = "不写则默认为【传送】地图名字，否则对话展示你写的这个";
		this.传送选项文字.Width = 150;
		this.坐标X.Frozen = true;
		this.坐标X.HeaderText = "坐标X";
		this.坐标X.MinimumWidth = 80;
		this.坐标X.Name = "坐标X";
		this.坐标X.Width = 80;
		this.坐标Y.HeaderText = "坐标Y";
		this.坐标Y.MinimumWidth = 80;
		this.坐标Y.Name = "坐标Y";
		this.坐标Y.Width = 80;
		this.label16.Location = new System.Drawing.Point(12, 172);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(60, 23);
		this.label16.TabIndex = 116;
		this.label16.Text = "对话文本";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_对话文本.Location = new System.Drawing.Point(73, 172);
		this.修改_对话文本.Name = "修改_对话文本";
		this.修改_对话文本.Size = new System.Drawing.Size(170, 23);
		this.修改_对话文本.TabIndex = 117;
		this.label15.Location = new System.Drawing.Point(94, 141);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(60, 23);
		this.label15.TabIndex = 114;
		this.label15.Text = "所在地图";
		this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_所在地图.Location = new System.Drawing.Point(155, 141);
		this.修改_所在地图.Name = "修改_所在地图";
		this.修改_所在地图.Size = new System.Drawing.Size(88, 23);
		this.修改_所在地图.TabIndex = 115;
		this.修改_是否显示.AutoSize = true;
		this.修改_是否显示.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修改_是否显示.Location = new System.Drawing.Point(12, 141);
		this.修改_是否显示.Name = "修改_是否显示";
		this.修改_是否显示.Size = new System.Drawing.Size(80, 23);
		this.修改_是否显示.TabIndex = 113;
		this.修改_是否显示.Text = "是否显示";
		this.修改_是否显示.UseVisualStyleBackColor = true;
		this.修改_npc形象.Location = new System.Drawing.Point(143, 105);
		this.修改_npc形象.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修改_npc形象.Name = "修改_npc形象";
		this.修改_npc形象.Size = new System.Drawing.Size(100, 23);
		this.修改_npc形象.TabIndex = 112;
		this.label10.BackColor = System.Drawing.Color.Transparent;
		this.label10.Location = new System.Drawing.Point(110, 105);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(32, 23);
		this.label10.TabIndex = 111;
		this.label10.Text = "形象";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_npc朝向.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.修改_npc朝向.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.修改_npc朝向.FormattingEnabled = true;
		this.修改_npc朝向.Items.AddRange(new object[8] { "左", "左上", "上", "右上", "右", "右下", "下", "左下" });
		this.修改_npc朝向.Location = new System.Drawing.Point(44, 105);
		this.修改_npc朝向.Name = "修改_npc朝向";
		this.修改_npc朝向.Size = new System.Drawing.Size(60, 25);
		this.修改_npc朝向.TabIndex = 110;
		this.label11.BackColor = System.Drawing.Color.Transparent;
		this.label11.Location = new System.Drawing.Point(12, 107);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(32, 23);
		this.label11.TabIndex = 109;
		this.label11.Text = "朝向";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.修改_npc坐标Y.Location = new System.Drawing.Point(129, 71);
		this.修改_npc坐标Y.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.修改_npc坐标Y.Name = "修改_npc坐标Y";
		this.修改_npc坐标Y.Size = new System.Drawing.Size(60, 23);
		this.修改_npc坐标Y.TabIndex = 108;
		this.修改_npc坐标X.Location = new System.Drawing.Point(52, 71);
		this.修改_npc坐标X.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.修改_npc坐标X.Name = "修改_npc坐标X";
		this.修改_npc坐标X.Size = new System.Drawing.Size(60, 23);
		this.修改_npc坐标X.TabIndex = 107;
		this.label12.BackColor = System.Drawing.Color.Transparent;
		this.label12.Location = new System.Drawing.Point(12, 71);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(115, 23);
		this.label12.TabIndex = 106;
		this.label12.Text = "坐标X                 Y";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label13.Location = new System.Drawing.Point(3, 40);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(60, 23);
		this.label13.TabIndex = 104;
		this.label13.Text = "npc称号";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_npc称号.Location = new System.Drawing.Point(64, 40);
		this.修改_npc称号.Name = "修改_npc称号";
		this.修改_npc称号.Size = new System.Drawing.Size(179, 23);
		this.修改_npc称号.TabIndex = 105;
		this.label14.Location = new System.Drawing.Point(3, 9);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(60, 23);
		this.label14.TabIndex = 102;
		this.label14.Text = "npc名字";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.修改_npc名字.Location = new System.Drawing.Point(64, 9);
		this.修改_npc名字.Name = "修改_npc名字";
		this.修改_npc名字.ReadOnly = true;
		this.修改_npc名字.Size = new System.Drawing.Size(179, 23);
		this.修改_npc名字.TabIndex = 103;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(784, 561);
		base.Controls.Add(this.修改窗口);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.超级npc_npc列表);
		base.Controls.Add(this.超级npc_开关);
		base.Controls.Add(this.超级npc_重载按钮);
		base.Controls.Add(this.超级npc_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "超级NPC配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "超级NPC配置窗口";
		base.Load += new System.EventHandler(超级NPC配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.超级npc_npc列表).EndInit();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.超级npc_形象).EndInit();
		((System.ComponentModel.ISupportInitialize)this.超级npc_坐标Y).EndInit();
		((System.ComponentModel.ISupportInitialize)this.超级npc_坐标X).EndInit();
		this.修改窗口.ResumeLayout(false);
		this.修改窗口.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.修改_传送列表).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_npc形象).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_npc坐标Y).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修改_npc坐标X).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
