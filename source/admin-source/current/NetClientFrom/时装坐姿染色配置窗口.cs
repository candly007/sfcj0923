using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 时装坐姿染色配置窗口 : Form
{
	private static 时装坐姿染色配置窗口 i;

	private IContainer components;

	private Button 坐姿_重载按钮;

	private Button 坐姿_保存按钮;

	private GroupBox groupBox1;

	private Label label6;

	private TextBox 坐姿_添加时装ID;

	private CheckBox 坐姿_时装开关;

	private Button 坐姿_添加时装按钮;

	private Label label2;

	private TextBox 坐姿_添加站姿ID;

	private Label label1;

	private TextBox 坐姿_添加坐姿ID;

	private DataGridView 坐姿_时装列表;

	private GroupBox groupBox2;

	private CheckBox 坐姿_染色战斗显示开关;

	private CheckBox 坐姿_染色开关;

	private Label label3;

	private NumericUpDown 坐姿_染色消耗数量;

	private Button 坐姿_添加染色按钮;

	private TextBox 坐姿_染色列表;

	private Label label5;

	private Label label4;

	private TextBox 坐姿_染色坐姿ID;

	private DataGridView 坐姿_染色坐姿列表;

	private Label label7;

	private Panel 修改窗口_时装;

	private Label label8;

	private TextBox 时装修改_站姿ID;

	private Label label9;

	private TextBox 时装修改_坐姿ID;

	private Label label10;

	private TextBox 时装修改_时装ID;

	private Button 时装修改_取消按钮;

	private Button 时装修改_确定按钮;

	private Panel 修改窗口_坐姿;

	private Button 坐姿修改_取消按钮;

	private Button 坐姿修改_确定按钮;

	private TextBox 坐姿修改_染色列表;

	private Label label12;

	private Label label11;

	private TextBox 坐姿修改_坐姿ID;

	private DataGridViewTextBoxColumn 原始坐姿ID;

	private DataGridViewTextBoxColumn 染色列表;

	private DataGridViewTextBoxColumn 时装ID;

	private DataGridViewTextBoxColumn 坐姿ID;

	private DataGridViewTextBoxColumn 站姿ID;

	public static 时装坐姿染色配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 时装坐姿染色配置窗口();
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
		修改窗口_时装.Visible = false;
		修改窗口_坐姿.Visible = false;
	}

	public 时装坐姿染色配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 时装坐姿染色配置窗口_Load(object sender, EventArgs e)
	{
		坐姿_时装列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(时装_修改事件回调, 时装_删除事件回调);
		时装修改_取消按钮.Click += delegate
		{
			修改窗口_时装.Visible = false;
		};
		时装修改_确定按钮.Click += 时装_确定修改事件回调;
		坐姿_染色坐姿列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(坐姿_修改事件回调, 坐姿_删除事件回调);
		坐姿修改_取消按钮.Click += delegate
		{
			修改窗口_坐姿.Visible = false;
		};
		坐姿修改_确定按钮.Click += 坐姿_确定修改事件回调;
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		坐姿_重载按钮_Click(sender, e);
	}

	private void 时装_修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 坐姿_时装列表.CurrentRow == null)
		{
			return;
		}
		int index = 坐姿_时装列表.CurrentRow.Index;
		if (index >= 0)
		{
			DataGridViewCellCollection cells = 坐姿_时装列表.Rows[index].Cells;
			时装修改_时装ID.Text = cells["时装ID"].Value.ToString();
			if (Singleton<全局变量类>.I.时装坐姿染色配置.时装坐姿列表.TryGetValue(时装修改_时装ID.Text, out 时装坐姿数据列表类 value))
			{
				时装修改_坐姿ID.Text = value.坐姿ID;
				时装修改_站姿ID.Text = value.站立ID;
				修改窗口_时装.Visible = true;
			}
		}
	}

	private void 时装_删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 坐姿_时装列表.CurrentRow == null)
		{
			return;
		}
		int index = 坐姿_时装列表.CurrentRow.Index;
		if (index >= 0)
		{
			string text = 坐姿_时装列表.Rows[index].Cells["时装ID"].Value.ToString();
			if (Singleton<全局变量类>.I.时装坐姿染色配置.时装坐姿列表.ContainsKey(text))
			{
				Singleton<全局变量类>.I.时装坐姿染色配置.时装坐姿列表.TryRemove(text, out 时装坐姿数据列表类 _);
				MessageBox.Show("[" + text + "]已从时装列表中删除，请及时点击保存配置按钮更新服务端配置！");
				坐姿_时装列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 时装_确定修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || !Singleton<全局变量类>.I.时装坐姿染色配置.时装坐姿列表.TryGetValue(时装修改_时装ID.Text, out 时装坐姿数据列表类 value))
		{
			return;
		}
		value.坐姿ID = 时装修改_坐姿ID.Text;
		value.站立ID = 时装修改_站姿ID.Text;
		修改窗口_时装.Visible = false;
		MessageBox.Show("[" + 时装修改_时装ID.Text + "]的配置已经修改，请及时点击保存配置按钮更新服务端配置！");
		if (坐姿_时装列表.CurrentRow != null)
		{
			int index = 坐姿_时装列表.CurrentRow.Index;
			if (index >= 0)
			{
				DataGridViewCellCollection cells = 坐姿_时装列表.Rows[index].Cells;
				cells["坐姿ID"].Value = value.坐姿ID;
				cells["站姿ID"].Value = value.站立ID;
			}
		}
	}

	private void 坐姿_修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 坐姿_染色坐姿列表.CurrentRow == null)
		{
			return;
		}
		int index = 坐姿_染色坐姿列表.CurrentRow.Index;
		if (index < 0)
		{
			return;
		}
		DataGridViewCellCollection cells = 坐姿_染色坐姿列表.Rows[index].Cells;
		坐姿修改_坐姿ID.Text = cells["原始坐姿ID"].Value.ToString();
		if (Singleton<全局变量类>.I.时装坐姿染色配置.染色坐姿列表.TryGetValue(坐姿修改_坐姿ID.Text, out List<染色坐姿数据列表类> value))
		{
			string text = string.Empty;
			for (int i = 0; i < value.Count; i++)
			{
				text = ((i != 0) ? (text + "|" + value[i].染色名称 + "+" + value[i].染后坐姿ID) : (value[i].染色名称 + "+" + value[i].染后坐姿ID));
			}
			坐姿修改_染色列表.Text = text;
			修改窗口_坐姿.Visible = true;
		}
	}

	private void 坐姿_删除事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || 坐姿_染色坐姿列表.CurrentRow == null)
		{
			return;
		}
		int index = 坐姿_染色坐姿列表.CurrentRow.Index;
		if (index >= 0)
		{
			string text = 坐姿_染色坐姿列表.Rows[index].Cells["原始坐姿ID"].Value.ToString();
			if (Singleton<全局变量类>.I.时装坐姿染色配置.染色坐姿列表.ContainsKey(text))
			{
				Singleton<全局变量类>.I.时装坐姿染色配置.染色坐姿列表.TryRemove(text, out List<染色坐姿数据列表类> _);
				MessageBox.Show("[" + text + "]已从染色列表中删除，请及时点击保存配置按钮更新服务端配置！");
				坐姿_染色坐姿列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 坐姿_确定修改事件回调(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated || !Singleton<全局变量类>.I.时装坐姿染色配置.染色坐姿列表.TryGetValue(坐姿修改_坐姿ID.Text, out List<染色坐姿数据列表类> value))
		{
			return;
		}
		List<染色坐姿数据列表类> list = new List<染色坐姿数据列表类>();
		string[] array = 坐姿修改_染色列表.Text.Split('|');
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrWhiteSpace(array[i]))
			{
				string[] array2 = array[i].Split('+');
				if (array2.Length == 2)
				{
					list.Add(new 染色坐姿数据列表类
					{
						原坐姿ID = 坐姿修改_坐姿ID.Text,
						染色名称 = array2[0],
						染后坐姿ID = array2[1]
					});
				}
			}
		}
		value = list;
		修改窗口_坐姿.Visible = false;
		MessageBox.Show("[" + 坐姿修改_坐姿ID.Text + "]的配置已经修改，请及时点击保存配置按钮更新服务端配置！");
		if (坐姿_染色坐姿列表.CurrentRow != null)
		{
			int index = 坐姿_染色坐姿列表.CurrentRow.Index;
			if (index >= 0)
			{
				坐姿_染色坐姿列表.Rows[index].Cells["染色列表"].Value = 坐姿修改_染色列表.Text;
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 20)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			坐姿_时装开关.Checked = Singleton<全局变量类>.I.时装坐姿染色配置.时装坐姿开关;
			坐姿_时装列表.Rows.Clear();
			foreach (时装坐姿数据列表类 value in Singleton<全局变量类>.I.时装坐姿染色配置.时装坐姿列表.Values)
			{
				坐姿_时装列表.Rows.Add(value.时装ID, value.坐姿ID, value.站立ID);
			}
			坐姿_染色开关.Checked = Singleton<全局变量类>.I.时装坐姿染色配置.坐姿染色开关;
			坐姿_染色战斗显示开关.Checked = Singleton<全局变量类>.I.时装坐姿染色配置.坐姿染色战斗开关;
			坐姿_染色消耗数量.Value = Singleton<全局变量类>.I.时装坐姿染色配置.染色消耗数量;
			坐姿_染色坐姿列表.Rows.Clear();
			foreach (KeyValuePair<string, List<染色坐姿数据列表类>> item in Singleton<全局变量类>.I.时装坐姿染色配置.染色坐姿列表)
			{
				string text = string.Empty;
				for (int i = 0; i < item.Value.Count; i++)
				{
					text = ((i != 0) ? (text + "|" + item.Value[i].染色名称 + "+" + item.Value[i].染后坐姿ID) : (item.Value[i].染色名称 + "+" + item.Value[i].染后坐姿ID));
				}
				坐姿_染色坐姿列表.Rows.Add(item.Key, text);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.时装坐姿染色配置.时装坐姿开关 = 坐姿_时装开关.Checked;
			Singleton<全局变量类>.I.时装坐姿染色配置.坐姿染色开关 = 坐姿_染色开关.Checked;
			Singleton<全局变量类>.I.时装坐姿染色配置.坐姿染色战斗开关 = 坐姿_染色战斗显示开关.Checked;
			Singleton<全局变量类>.I.时装坐姿染色配置.染色消耗数量 = (int)坐姿_染色消耗数量.Value;
		}
	}

	private void 坐姿_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 20, JsonConvert.SerializeObject(Singleton<全局变量类>.I.时装坐姿染色配置, Formatting.Indented));
		}
	}

	private void 坐姿_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 20);
		}
	}

	private void 坐姿_添加时装按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(坐姿_添加时装ID.Text))
			{
				MessageBox.Show("请输入要添加的时装ID！");
				return;
			}
			if (string.IsNullOrWhiteSpace(坐姿_添加坐姿ID.Text))
			{
				MessageBox.Show("请输入[" + 坐姿_添加时装ID.Text + "]时装对应的坐姿ID！");
				return;
			}
			if (string.IsNullOrWhiteSpace(坐姿_添加站姿ID.Text))
			{
				MessageBox.Show("请输入[" + 坐姿_添加时装ID.Text + "]时装对应的站姿ID！");
				return;
			}
			if (Singleton<全局变量类>.I.时装坐姿染色配置.时装坐姿列表.ContainsKey(坐姿_添加时装ID.Text))
			{
				MessageBox.Show("[" + 坐姿_添加时装ID.Text + "]时装已经存在！");
				return;
			}
			时装坐姿数据列表类 时装坐姿数据列表类2 = new 时装坐姿数据列表类
			{
				时装ID = 坐姿_添加时装ID.Text,
				坐姿ID = 坐姿_添加坐姿ID.Text,
				站立ID = 坐姿_添加站姿ID.Text
			};
			Singleton<全局变量类>.I.时装坐姿染色配置.时装坐姿列表.TryAdd(时装坐姿数据列表类2.时装ID, 时装坐姿数据列表类2);
			坐姿_时装列表.Rows.Add(时装坐姿数据列表类2.时装ID, 时装坐姿数据列表类2.坐姿ID, 时装坐姿数据列表类2.站立ID);
			MessageBox.Show("[" + 坐姿_添加时装ID.Text + "]时装添加成功，请点击保存配置实时同步到服务器！");
		}
	}

	private void 坐姿_添加染色按钮_Click(object sender, EventArgs e)
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		if (string.IsNullOrWhiteSpace(坐姿_染色坐姿ID.Text))
		{
			MessageBox.Show("请输入要添加染色的坐姿ID！");
			return;
		}
		if (string.IsNullOrWhiteSpace(坐姿_染色列表.Text))
		{
			MessageBox.Show("请输入[" + 坐姿_染色坐姿ID.Text + "]坐姿对应的染色配置！");
			return;
		}
		if (Singleton<全局变量类>.I.时装坐姿染色配置.染色坐姿列表.ContainsKey(坐姿_染色坐姿ID.Text))
		{
			MessageBox.Show("[" + 坐姿_染色坐姿ID.Text + "]坐姿已经存在！");
			return;
		}
		List<染色坐姿数据列表类> list = new List<染色坐姿数据列表类>();
		string[] array = 坐姿_染色列表.Text.Split('|');
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrWhiteSpace(array[i]))
			{
				string[] array2 = array[i].Split('+');
				if (array2.Length == 2)
				{
					list.Add(new 染色坐姿数据列表类
					{
						原坐姿ID = 坐姿_染色坐姿ID.Text,
						染色名称 = array2[0],
						染后坐姿ID = array2[1]
					});
				}
			}
		}
		Singleton<全局变量类>.I.时装坐姿染色配置.染色坐姿列表.TryAdd(坐姿_染色坐姿ID.Text, list);
		坐姿_染色坐姿列表.Rows.Add(坐姿_染色坐姿ID.Text, 坐姿_染色列表.Text);
		MessageBox.Show("[" + 坐姿_染色坐姿ID.Text + "]坐姿的染色数据添加成功，请点击保存配置实时同步到服务器！");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.时装坐姿染色配置窗口));
		this.坐姿_重载按钮 = new System.Windows.Forms.Button();
		this.坐姿_保存按钮 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.修改窗口_时装 = new System.Windows.Forms.Panel();
		this.时装修改_取消按钮 = new System.Windows.Forms.Button();
		this.时装修改_确定按钮 = new System.Windows.Forms.Button();
		this.label8 = new System.Windows.Forms.Label();
		this.时装修改_站姿ID = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.时装修改_坐姿ID = new System.Windows.Forms.TextBox();
		this.label10 = new System.Windows.Forms.Label();
		this.时装修改_时装ID = new System.Windows.Forms.TextBox();
		this.坐姿_时装列表 = new System.Windows.Forms.DataGridView();
		this.时装ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.坐姿ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.站姿ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.坐姿_添加时装按钮 = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.坐姿_添加站姿ID = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.坐姿_添加坐姿ID = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.坐姿_添加时装ID = new System.Windows.Forms.TextBox();
		this.坐姿_时装开关 = new System.Windows.Forms.CheckBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.修改窗口_坐姿 = new System.Windows.Forms.Panel();
		this.坐姿修改_取消按钮 = new System.Windows.Forms.Button();
		this.坐姿修改_确定按钮 = new System.Windows.Forms.Button();
		this.坐姿修改_染色列表 = new System.Windows.Forms.TextBox();
		this.label12 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.坐姿修改_坐姿ID = new System.Windows.Forms.TextBox();
		this.坐姿_染色坐姿列表 = new System.Windows.Forms.DataGridView();
		this.原始坐姿ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.染色列表 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.label7 = new System.Windows.Forms.Label();
		this.坐姿_添加染色按钮 = new System.Windows.Forms.Button();
		this.坐姿_染色列表 = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.坐姿_染色坐姿ID = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.坐姿_染色消耗数量 = new System.Windows.Forms.NumericUpDown();
		this.坐姿_染色战斗显示开关 = new System.Windows.Forms.CheckBox();
		this.坐姿_染色开关 = new System.Windows.Forms.CheckBox();
		this.groupBox1.SuspendLayout();
		this.修改窗口_时装.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.坐姿_时装列表).BeginInit();
		this.groupBox2.SuspendLayout();
		this.修改窗口_坐姿.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.坐姿_染色坐姿列表).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.坐姿_染色消耗数量).BeginInit();
		base.SuspendLayout();
		this.坐姿_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.坐姿_重载按钮.Location = new System.Drawing.Point(220, 12);
		this.坐姿_重载按钮.Name = "坐姿_重载按钮";
		this.坐姿_重载按钮.Size = new System.Drawing.Size(180, 30);
		this.坐姿_重载按钮.TabIndex = 57;
		this.坐姿_重载按钮.Text = "重载时装坐姿和染色配置";
		this.坐姿_重载按钮.UseVisualStyleBackColor = true;
		this.坐姿_重载按钮.Click += new System.EventHandler(坐姿_重载按钮_Click);
		this.坐姿_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.坐姿_保存按钮.Location = new System.Drawing.Point(12, 12);
		this.坐姿_保存按钮.Name = "坐姿_保存按钮";
		this.坐姿_保存按钮.Size = new System.Drawing.Size(180, 30);
		this.坐姿_保存按钮.TabIndex = 56;
		this.坐姿_保存按钮.Text = "保存时装坐姿和染色配置";
		this.坐姿_保存按钮.UseVisualStyleBackColor = true;
		this.坐姿_保存按钮.Click += new System.EventHandler(坐姿_保存按钮_Click);
		this.groupBox1.Controls.Add(this.修改窗口_时装);
		this.groupBox1.Controls.Add(this.坐姿_时装列表);
		this.groupBox1.Controls.Add(this.坐姿_添加时装按钮);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.坐姿_添加站姿ID);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.坐姿_添加坐姿ID);
		this.groupBox1.Controls.Add(this.label6);
		this.groupBox1.Controls.Add(this.坐姿_添加时装ID);
		this.groupBox1.Controls.Add(this.坐姿_时装开关);
		this.groupBox1.Location = new System.Drawing.Point(12, 48);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(388, 498);
		this.groupBox1.TabIndex = 58;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "带有坐姿的时装配置";
		this.修改窗口_时装.Controls.Add(this.时装修改_取消按钮);
		this.修改窗口_时装.Controls.Add(this.时装修改_确定按钮);
		this.修改窗口_时装.Controls.Add(this.label8);
		this.修改窗口_时装.Controls.Add(this.时装修改_站姿ID);
		this.修改窗口_时装.Controls.Add(this.label9);
		this.修改窗口_时装.Controls.Add(this.时装修改_坐姿ID);
		this.修改窗口_时装.Controls.Add(this.label10);
		this.修改窗口_时装.Controls.Add(this.时装修改_时装ID);
		this.修改窗口_时装.Location = new System.Drawing.Point(87, 174);
		this.修改窗口_时装.Name = "修改窗口_时装";
		this.修改窗口_时装.Size = new System.Drawing.Size(202, 184);
		this.修改窗口_时装.TabIndex = 80;
		this.时装修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.时装修改_取消按钮.Location = new System.Drawing.Point(19, 138);
		this.时装修改_取消按钮.Name = "时装修改_取消按钮";
		this.时装修改_取消按钮.Size = new System.Drawing.Size(165, 30);
		this.时装修改_取消按钮.TabIndex = 97;
		this.时装修改_取消按钮.Text = "取消";
		this.时装修改_取消按钮.UseVisualStyleBackColor = true;
		this.时装修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.时装修改_确定按钮.Location = new System.Drawing.Point(19, 102);
		this.时装修改_确定按钮.Name = "时装修改_确定按钮";
		this.时装修改_确定按钮.Size = new System.Drawing.Size(165, 30);
		this.时装修改_确定按钮.TabIndex = 96;
		this.时装修改_确定按钮.Text = "修改";
		this.时装修改_确定按钮.UseVisualStyleBackColor = true;
		this.label8.Location = new System.Drawing.Point(3, 68);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(60, 23);
		this.label8.TabIndex = 73;
		this.label8.Text = "站姿ID";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.时装修改_站姿ID.Location = new System.Drawing.Point(64, 68);
		this.时装修改_站姿ID.Name = "时装修改_站姿ID";
		this.时装修改_站姿ID.Size = new System.Drawing.Size(120, 23);
		this.时装修改_站姿ID.TabIndex = 74;
		this.label9.Location = new System.Drawing.Point(3, 39);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(60, 23);
		this.label9.TabIndex = 71;
		this.label9.Text = "坐姿ID";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.时装修改_坐姿ID.Location = new System.Drawing.Point(64, 39);
		this.时装修改_坐姿ID.Name = "时装修改_坐姿ID";
		this.时装修改_坐姿ID.Size = new System.Drawing.Size(120, 23);
		this.时装修改_坐姿ID.TabIndex = 72;
		this.label10.Location = new System.Drawing.Point(3, 11);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(60, 23);
		this.label10.TabIndex = 69;
		this.label10.Text = "时装ID";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.时装修改_时装ID.Location = new System.Drawing.Point(64, 11);
		this.时装修改_时装ID.Name = "时装修改_时装ID";
		this.时装修改_时装ID.ReadOnly = true;
		this.时装修改_时装ID.Size = new System.Drawing.Size(120, 23);
		this.时装修改_时装ID.TabIndex = 70;
		this.坐姿_时装列表.AllowUserToAddRows = false;
		this.坐姿_时装列表.AllowUserToDeleteRows = false;
		this.坐姿_时装列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.坐姿_时装列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.坐姿_时装列表.BackgroundColor = System.Drawing.Color.White;
		this.坐姿_时装列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.坐姿_时装列表.Columns.AddRange(this.时装ID, this.坐姿ID, this.站姿ID);
		this.坐姿_时装列表.Location = new System.Drawing.Point(6, 118);
		this.坐姿_时装列表.MultiSelect = false;
		this.坐姿_时装列表.Name = "坐姿_时装列表";
		this.坐姿_时装列表.ReadOnly = true;
		this.坐姿_时装列表.RowHeadersVisible = false;
		this.坐姿_时装列表.RowTemplate.Height = 25;
		this.坐姿_时装列表.Size = new System.Drawing.Size(368, 374);
		this.坐姿_时装列表.TabIndex = 79;
		this.时装ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.时装ID.HeaderText = "时装ID";
		this.时装ID.MinimumWidth = 100;
		this.时装ID.Name = "时装ID";
		this.时装ID.ReadOnly = true;
		this.坐姿ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.坐姿ID.HeaderText = "坐姿ID";
		this.坐姿ID.MinimumWidth = 100;
		this.坐姿ID.Name = "坐姿ID";
		this.坐姿ID.ReadOnly = true;
		this.站姿ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.站姿ID.HeaderText = "站姿ID";
		this.站姿ID.MinimumWidth = 100;
		this.站姿ID.Name = "站姿ID";
		this.站姿ID.ReadOnly = true;
		this.坐姿_添加时装按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.坐姿_添加时装按钮.Location = new System.Drawing.Point(193, 82);
		this.坐姿_添加时装按钮.Name = "坐姿_添加时装按钮";
		this.坐姿_添加时装按钮.Size = new System.Drawing.Size(181, 30);
		this.坐姿_添加时装按钮.TabIndex = 69;
		this.坐姿_添加时装按钮.Text = "添加时装";
		this.坐姿_添加时装按钮.UseVisualStyleBackColor = true;
		this.坐姿_添加时装按钮.Click += new System.EventHandler(坐姿_添加时装按钮_Click);
		this.label2.Location = new System.Drawing.Point(6, 86);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(60, 23);
		this.label2.TabIndex = 67;
		this.label2.Text = "站姿ID";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.坐姿_添加站姿ID.Location = new System.Drawing.Point(67, 86);
		this.坐姿_添加站姿ID.Name = "坐姿_添加站姿ID";
		this.坐姿_添加站姿ID.Size = new System.Drawing.Size(120, 23);
		this.坐姿_添加站姿ID.TabIndex = 68;
		this.label1.Location = new System.Drawing.Point(193, 48);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 23);
		this.label1.TabIndex = 65;
		this.label1.Text = "坐姿ID";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.坐姿_添加坐姿ID.Location = new System.Drawing.Point(254, 48);
		this.坐姿_添加坐姿ID.Name = "坐姿_添加坐姿ID";
		this.坐姿_添加坐姿ID.Size = new System.Drawing.Size(120, 23);
		this.坐姿_添加坐姿ID.TabIndex = 66;
		this.label6.Location = new System.Drawing.Point(6, 48);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(60, 23);
		this.label6.TabIndex = 63;
		this.label6.Text = "时装ID";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.坐姿_添加时装ID.Location = new System.Drawing.Point(67, 48);
		this.坐姿_添加时装ID.Name = "坐姿_添加时装ID";
		this.坐姿_添加时装ID.Size = new System.Drawing.Size(120, 23);
		this.坐姿_添加时装ID.TabIndex = 64;
		this.坐姿_时装开关.AutoSize = true;
		this.坐姿_时装开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.坐姿_时装开关.Location = new System.Drawing.Point(6, 22);
		this.坐姿_时装开关.Name = "坐姿_时装开关";
		this.坐姿_时装开关.Size = new System.Drawing.Size(106, 23);
		this.坐姿_时装开关.TabIndex = 62;
		this.坐姿_时装开关.Text = "时装坐姿开关";
		this.坐姿_时装开关.UseVisualStyleBackColor = true;
		this.groupBox2.Controls.Add(this.修改窗口_坐姿);
		this.groupBox2.Controls.Add(this.坐姿_染色坐姿列表);
		this.groupBox2.Controls.Add(this.label7);
		this.groupBox2.Controls.Add(this.坐姿_添加染色按钮);
		this.groupBox2.Controls.Add(this.坐姿_染色列表);
		this.groupBox2.Controls.Add(this.label5);
		this.groupBox2.Controls.Add(this.label4);
		this.groupBox2.Controls.Add(this.坐姿_染色坐姿ID);
		this.groupBox2.Controls.Add(this.label3);
		this.groupBox2.Controls.Add(this.坐姿_染色消耗数量);
		this.groupBox2.Controls.Add(this.坐姿_染色战斗显示开关);
		this.groupBox2.Controls.Add(this.坐姿_染色开关);
		this.groupBox2.Location = new System.Drawing.Point(406, 12);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(530, 534);
		this.groupBox2.TabIndex = 59;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "坐姿染色配置";
		this.修改窗口_坐姿.Controls.Add(this.坐姿修改_取消按钮);
		this.修改窗口_坐姿.Controls.Add(this.坐姿修改_确定按钮);
		this.修改窗口_坐姿.Controls.Add(this.坐姿修改_染色列表);
		this.修改窗口_坐姿.Controls.Add(this.label12);
		this.修改窗口_坐姿.Controls.Add(this.label11);
		this.修改窗口_坐姿.Controls.Add(this.坐姿修改_坐姿ID);
		this.修改窗口_坐姿.Location = new System.Drawing.Point(94, 130);
		this.修改窗口_坐姿.Name = "修改窗口_坐姿";
		this.修改窗口_坐姿.Size = new System.Drawing.Size(369, 398);
		this.修改窗口_坐姿.TabIndex = 60;
		this.坐姿修改_取消按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.坐姿修改_取消按钮.Location = new System.Drawing.Point(186, 348);
		this.坐姿修改_取消按钮.Name = "坐姿修改_取消按钮";
		this.坐姿修改_取消按钮.Size = new System.Drawing.Size(118, 30);
		this.坐姿修改_取消按钮.TabIndex = 99;
		this.坐姿修改_取消按钮.Text = "取消";
		this.坐姿修改_取消按钮.UseVisualStyleBackColor = true;
		this.坐姿修改_确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.坐姿修改_确定按钮.Location = new System.Drawing.Point(46, 348);
		this.坐姿修改_确定按钮.Name = "坐姿修改_确定按钮";
		this.坐姿修改_确定按钮.Size = new System.Drawing.Size(118, 30);
		this.坐姿修改_确定按钮.TabIndex = 98;
		this.坐姿修改_确定按钮.Text = "修改";
		this.坐姿修改_确定按钮.UseVisualStyleBackColor = true;
		this.坐姿修改_染色列表.Location = new System.Drawing.Point(84, 47);
		this.坐姿修改_染色列表.Multiline = true;
		this.坐姿修改_染色列表.Name = "坐姿修改_染色列表";
		this.坐姿修改_染色列表.Size = new System.Drawing.Size(246, 287);
		this.坐姿修改_染色列表.TabIndex = 72;
		this.label12.Location = new System.Drawing.Point(23, 47);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(60, 23);
		this.label12.TabIndex = 71;
		this.label12.Text = "染色列表";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label11.Location = new System.Drawing.Point(3, 14);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(80, 23);
		this.label11.TabIndex = 69;
		this.label11.Text = "原始坐姿ID";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.坐姿修改_坐姿ID.Location = new System.Drawing.Point(84, 14);
		this.坐姿修改_坐姿ID.Name = "坐姿修改_坐姿ID";
		this.坐姿修改_坐姿ID.ReadOnly = true;
		this.坐姿修改_坐姿ID.Size = new System.Drawing.Size(246, 23);
		this.坐姿修改_坐姿ID.TabIndex = 70;
		this.坐姿_染色坐姿列表.AllowUserToAddRows = false;
		this.坐姿_染色坐姿列表.AllowUserToDeleteRows = false;
		this.坐姿_染色坐姿列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.坐姿_染色坐姿列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
		this.坐姿_染色坐姿列表.BackgroundColor = System.Drawing.Color.White;
		this.坐姿_染色坐姿列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.坐姿_染色坐姿列表.Columns.AddRange(this.原始坐姿ID, this.染色列表);
		this.坐姿_染色坐姿列表.Location = new System.Drawing.Point(16, 136);
		this.坐姿_染色坐姿列表.MultiSelect = false;
		this.坐姿_染色坐姿列表.Name = "坐姿_染色坐姿列表";
		this.坐姿_染色坐姿列表.ReadOnly = true;
		this.坐姿_染色坐姿列表.RowHeadersVisible = false;
		this.坐姿_染色坐姿列表.RowTemplate.Height = 25;
		this.坐姿_染色坐姿列表.Size = new System.Drawing.Size(508, 392);
		this.坐姿_染色坐姿列表.TabIndex = 80;
		this.原始坐姿ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.原始坐姿ID.HeaderText = "原始坐姿ID";
		this.原始坐姿ID.MinimumWidth = 100;
		this.原始坐姿ID.Name = "原始坐姿ID";
		this.原始坐姿ID.ReadOnly = true;
		this.染色列表.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.染色列表.HeaderText = "染色列表";
		this.染色列表.MinimumWidth = 200;
		this.染色列表.Name = "染色列表";
		this.染色列表.ReadOnly = true;
		this.染色列表.Width = 200;
		this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label7.ForeColor = System.Drawing.Color.Red;
		this.label7.Location = new System.Drawing.Point(16, 110);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(508, 23);
		this.label7.TabIndex = 72;
		this.label7.Text = "一个坐姿可配置多个颜色，例子：染色名称1+坐姿ID|染色名称2+坐姿ID";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.坐姿_添加染色按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.坐姿_添加染色按钮.Location = new System.Drawing.Point(474, 80);
		this.坐姿_添加染色按钮.Name = "坐姿_添加染色按钮";
		this.坐姿_添加染色按钮.Size = new System.Drawing.Size(50, 30);
		this.坐姿_添加染色按钮.TabIndex = 71;
		this.坐姿_添加染色按钮.Text = "添加";
		this.坐姿_添加染色按钮.UseVisualStyleBackColor = true;
		this.坐姿_添加染色按钮.Click += new System.EventHandler(坐姿_添加染色按钮_Click);
		this.坐姿_染色列表.Location = new System.Drawing.Point(77, 84);
		this.坐姿_染色列表.Name = "坐姿_染色列表";
		this.坐姿_染色列表.Size = new System.Drawing.Size(386, 23);
		this.坐姿_染色列表.TabIndex = 70;
		this.label5.Location = new System.Drawing.Point(16, 84);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(60, 23);
		this.label5.TabIndex = 69;
		this.label5.Text = "染色列表";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label4.Location = new System.Drawing.Point(16, 58);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 67;
		this.label4.Text = "坐姿ID";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.坐姿_染色坐姿ID.Location = new System.Drawing.Point(77, 58);
		this.坐姿_染色坐姿ID.Name = "坐姿_染色坐姿ID";
		this.坐姿_染色坐姿ID.Size = new System.Drawing.Size(120, 23);
		this.坐姿_染色坐姿ID.TabIndex = 68;
		this.label3.Location = new System.Drawing.Point(302, 22);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(100, 23);
		this.label3.TabIndex = 65;
		this.label3.Text = "消耗凤仙花数量";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.坐姿_染色消耗数量.Location = new System.Drawing.Point(408, 22);
		this.坐姿_染色消耗数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.坐姿_染色消耗数量.Name = "坐姿_染色消耗数量";
		this.坐姿_染色消耗数量.Size = new System.Drawing.Size(116, 23);
		this.坐姿_染色消耗数量.TabIndex = 66;
		this.坐姿_染色战斗显示开关.AutoSize = true;
		this.坐姿_染色战斗显示开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.坐姿_染色战斗显示开关.Location = new System.Drawing.Point(138, 22);
		this.坐姿_染色战斗显示开关.Name = "坐姿_染色战斗显示开关";
		this.坐姿_染色战斗显示开关.Size = new System.Drawing.Size(158, 23);
		this.坐姿_染色战斗显示开关.TabIndex = 64;
		this.坐姿_染色战斗显示开关.Text = "染色坐姿战斗显示开关";
		this.坐姿_染色战斗显示开关.UseVisualStyleBackColor = true;
		this.坐姿_染色开关.AutoSize = true;
		this.坐姿_染色开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.坐姿_染色开关.Location = new System.Drawing.Point(16, 22);
		this.坐姿_染色开关.Name = "坐姿_染色开关";
		this.坐姿_染色开关.Size = new System.Drawing.Size(106, 23);
		this.坐姿_染色开关.TabIndex = 63;
		this.坐姿_染色开关.Text = "坐姿染色开关";
		this.坐姿_染色开关.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(948, 558);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.坐姿_重载按钮);
		base.Controls.Add(this.坐姿_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "时装坐姿染色配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "时装坐姿染色配置窗口";
		base.Load += new System.EventHandler(时装坐姿染色配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.修改窗口_时装.ResumeLayout(false);
		this.修改窗口_时装.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.坐姿_时装列表).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.修改窗口_坐姿.ResumeLayout(false);
		this.修改窗口_坐姿.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.坐姿_染色坐姿列表).EndInit();
		((System.ComponentModel.ISupportInitialize)this.坐姿_染色消耗数量).EndInit();
		base.ResumeLayout(false);
	}
}
