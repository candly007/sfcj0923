using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 异兽录配置窗口 : Form
{
	private static 异兽录配置窗口 i;

	private IContainer components;

	private CheckBox 异兽录_开关;

	private Button 异兽录_重载按钮;

	private Button 异兽录_保存按钮;

	private GroupBox groupBox1;

	private NumericUpDown 异兽录_形象;

	private Label label9;

	private ComboBox 异兽录_朝向;

	private Label label8;

	private NumericUpDown 异兽录_坐标Y;

	private NumericUpDown 异兽录_坐标X;

	private Label label7;

	private Label label5;

	private TextBox 异兽录_npc称号;

	private Label label4;

	private TextBox 异兽录_npc名字;

	private NumericUpDown 异兽录_变异加成数值;

	private ComboBox 异兽录_变异加成属性;

	private TextBox 地狱道_名字;

	private TextBox textBox1;

	private TextBox 异兽录_变异别称;

	private TextBox 异兽录_神兽别称;

	private TextBox textBox4;

	private NumericUpDown 异兽录_神兽加成数值;

	private ComboBox 异兽录_神兽加成属性;

	private TextBox textBox5;

	private TextBox 异兽录_仙元别称;

	private TextBox textBox7;

	private NumericUpDown 异兽录_仙元加成数值;

	private ComboBox 异兽录_仙元加成属性;

	private TextBox textBox8;

	private TextBox 异兽录_元灵别称;

	private TextBox textBox10;

	private NumericUpDown 异兽录_元灵加成数值;

	private ComboBox 异兽录_元灵加成属性;

	private TextBox textBox11;

	private TextBox 异兽录_御灵别称;

	private TextBox textBox13;

	private NumericUpDown 异兽录_御灵加成数值;

	private ComboBox 异兽录_御灵加成属性;

	private TextBox textBox14;

	private TextBox textBox15;

	private TextBox 异兽录_特效道具;

	private Label label1;

	private DataGridView 异兽录_异兽列表;

	private TextBox textBox17;

	private TextBox 异兽录_添加宠物;

	private ComboBox 异兽录_所属类型;

	private NumericUpDown 异兽录_添加数值;

	private ComboBox 异兽录_添加属性;

	private Button 异兽录_添加按钮;

	private TextBox textBox6;

	private TextBox textBox2;

	private TextBox textBox12;

	private TextBox textBox18;

	private TextBox textBox20;

	private DataGridViewTextBoxColumn 宠物名字;

	private DataGridViewComboBoxColumn 分类;

	private DataGridViewComboBoxColumn 加成属性;

	private DataGridViewTextBoxColumn 数值;

	public static 异兽录配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 异兽录配置窗口();
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

	public 异兽录配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 异兽录配置窗口_Load(object sender, EventArgs e)
	{
		异兽录_异兽列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 删除事件回调);
		((DataGridViewComboBoxColumn)异兽录_异兽列表.Columns[1]).DataSource = new List<string> { "变异", "神兽", "元灵", "仙元", "御灵" };
		((DataGridViewComboBoxColumn)异兽录_异兽列表.Columns[2]).DataSource = new List<string> { "金相性", "木相性", "水相性", "火相性", "土相性", "所有相性" };
		异兽录_异兽列表.DataError += delegate
		{
		};
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		异兽录_重载按钮_Click(sender, e);
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 异兽录_异兽列表.CurrentRow != null)
		{
			int index = 异兽录_异兽列表.CurrentRow.Index;
			if (index >= 0)
			{
				异兽录_异兽列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 9)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			异兽录_开关.Checked = Singleton<全局变量类>.I.异兽录配置.功能开关;
			异兽录_特效道具.Text = Singleton<全局变量类>.I.异兽录配置.特效道具;
			异兽录_npc名字.Text = Singleton<全局变量类>.I.异兽录配置.NPC数据.npc名字;
			异兽录_npc称号.Text = Singleton<全局变量类>.I.异兽录配置.NPC数据.npc称号;
			异兽录_坐标X.Value = Singleton<全局变量类>.I.异兽录配置.NPC数据.坐标.X;
			异兽录_坐标Y.Value = Singleton<全局变量类>.I.异兽录配置.NPC数据.坐标.Y;
			异兽录_朝向.Text = $"{(AllEnums.朝向Type)Singleton<全局变量类>.I.异兽录配置.NPC数据.朝向}";
			异兽录_形象.Value = Singleton<全局变量类>.I.异兽录配置.NPC数据.npc形象;
			异兽录_变异加成属性.Text = Singleton<全局变量类>.I.异兽录配置.变异圆满附加属性.ToString();
			异兽录_变异加成数值.Value = Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值;
			异兽录_变异别称.Text = Singleton<全局变量类>.I.异兽录配置.变异别称;
			异兽录_神兽加成属性.Text = Singleton<全局变量类>.I.异兽录配置.神兽圆满附加属性.ToString();
			异兽录_神兽加成数值.Value = Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值;
			异兽录_神兽别称.Text = Singleton<全局变量类>.I.异兽录配置.神兽别称;
			异兽录_元灵加成属性.Text = Singleton<全局变量类>.I.异兽录配置.元灵圆满附加属性.ToString();
			异兽录_元灵加成数值.Value = Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值;
			异兽录_元灵别称.Text = Singleton<全局变量类>.I.异兽录配置.元灵别称;
			异兽录_仙元加成属性.Text = Singleton<全局变量类>.I.异兽录配置.仙元圆满附加属性.ToString();
			异兽录_仙元加成数值.Value = Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值;
			异兽录_仙元别称.Text = Singleton<全局变量类>.I.异兽录配置.仙元别称;
			异兽录_御灵加成属性.Text = Singleton<全局变量类>.I.异兽录配置.御灵圆满附加属性.ToString();
			异兽录_御灵加成数值.Value = Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值;
			异兽录_御灵别称.Text = Singleton<全局变量类>.I.异兽录配置.御灵别称;
			异兽录_异兽列表.Rows.Clear();
			List<异兽录图鉴列表类> list = Singleton<全局变量类>.I.异兽录配置.图鉴列表.Values.OrderBy((异兽录图鉴列表类 x) => x.所属分类).ToList();
			int num = 0;
			foreach (异兽录图鉴列表类 item in list)
			{
				异兽录_异兽列表.Rows.Add(item.宠物名字, string.Empty, string.Empty, item.收录数值);
				((DataGridViewComboBoxCell)异兽录_异兽列表.Rows[num].Cells[1]).Value = item.所属分类.ToString();
				((DataGridViewComboBoxCell)异兽录_异兽列表.Rows[num].Cells[2]).Value = item.收录属性.ToString();
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
		Singleton<全局变量类>.I.异兽录配置.功能开关 = 异兽录_开关.Checked;
		if (异兽录_开关.Checked)
		{
			Singleton<全局变量类>.I.异兽录配置.定制功能开关 = false;
		}
		Singleton<全局变量类>.I.异兽录配置.特效道具 = 异兽录_特效道具.Text;
		Singleton<全局变量类>.I.异兽录配置.NPC数据.npc名字 = 异兽录_npc名字.Text;
		Singleton<全局变量类>.I.异兽录配置.NPC数据.npc称号 = 异兽录_npc称号.Text;
		Singleton<全局变量类>.I.异兽录配置.NPC数据.坐标.X = (short)异兽录_坐标X.Value;
		Singleton<全局变量类>.I.异兽录配置.NPC数据.坐标.Y = (short)异兽录_坐标Y.Value;
		Singleton<全局变量类>.I.异兽录配置.NPC数据.朝向 = (short)Enum.Parse<AllEnums.朝向Type>(异兽录_朝向.Text);
		Singleton<全局变量类>.I.异兽录配置.NPC数据.npc形象 = (int)异兽录_形象.Value;
		Enum.TryParse<AllEnums.属性Type>(异兽录_变异加成属性.Text, out Singleton<全局变量类>.I.异兽录配置.变异圆满附加属性);
		Singleton<全局变量类>.I.异兽录配置.变异圆满附加数值 = (int)异兽录_变异加成数值.Value;
		Singleton<全局变量类>.I.异兽录配置.变异别称 = 异兽录_变异别称.Text;
		Enum.TryParse<AllEnums.属性Type>(异兽录_神兽加成属性.Text, out Singleton<全局变量类>.I.异兽录配置.神兽圆满附加属性);
		Singleton<全局变量类>.I.异兽录配置.神兽圆满附加数值 = (int)异兽录_神兽加成数值.Value;
		Singleton<全局变量类>.I.异兽录配置.神兽别称 = 异兽录_神兽别称.Text;
		Enum.TryParse<AllEnums.属性Type>(异兽录_元灵加成属性.Text, out Singleton<全局变量类>.I.异兽录配置.元灵圆满附加属性);
		Singleton<全局变量类>.I.异兽录配置.元灵圆满附加数值 = (int)异兽录_元灵加成数值.Value;
		Singleton<全局变量类>.I.异兽录配置.元灵别称 = 异兽录_元灵别称.Text;
		Enum.TryParse<AllEnums.属性Type>(异兽录_仙元加成属性.Text, out Singleton<全局变量类>.I.异兽录配置.仙元圆满附加属性);
		Singleton<全局变量类>.I.异兽录配置.仙元圆满附加数值 = (int)异兽录_仙元加成数值.Value;
		Singleton<全局变量类>.I.异兽录配置.仙元别称 = 异兽录_仙元别称.Text;
		Enum.TryParse<AllEnums.属性Type>(异兽录_御灵加成属性.Text, out Singleton<全局变量类>.I.异兽录配置.御灵圆满附加属性);
		Singleton<全局变量类>.I.异兽录配置.御灵圆满附加数值 = (int)异兽录_御灵加成数值.Value;
		Singleton<全局变量类>.I.异兽录配置.御灵别称 = 异兽录_御灵别称.Text;
		Singleton<全局变量类>.I.异兽录配置.图鉴列表.Clear();
		for (int i = 0; i < 异兽录_异兽列表.Rows.Count; i++)
		{
			DataGridViewCellCollection cells = 异兽录_异兽列表.Rows[i].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value.ToString()))
			{
				Singleton<全局变量类>.I.异兽录配置.图鉴列表.TryAdd(cells[0].Value.ToString(), new 异兽录图鉴列表类
				{
					宠物名字 = cells[0].Value.ToString(),
					所属分类 = Enum.Parse<AllEnums.异兽Type>(cells[1].Value.ToString()),
					收录属性 = Enum.Parse<AllEnums.属性Type>(cells[2].Value.ToString()),
					收录数值 = int.Parse(cells[3].Value.ToString())
				});
			}
		}
	}

	private void 异兽录_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 9, JsonConvert.SerializeObject(Singleton<全局变量类>.I.异兽录配置, Formatting.Indented));
		}
	}

	private void 异兽录_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 9);
		}
	}

	private void 异兽录_添加按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(异兽录_添加宠物.Text))
			{
				MessageBox.Show("请输入要添加到异兽录的宠物名字！");
				return;
			}
			if (string.IsNullOrWhiteSpace(异兽录_所属类型.Text))
			{
				MessageBox.Show("请选择要添加的异兽录类型！");
				return;
			}
			if (string.IsNullOrWhiteSpace(异兽录_添加属性.Text))
			{
				MessageBox.Show("请选择要添加的异兽录属性！");
				return;
			}
			if (Singleton<全局变量类>.I.异兽录配置.图鉴列表.ContainsKey(异兽录_添加宠物.Text))
			{
				MessageBox.Show("列表中已经存在【" + 异兽录_添加宠物.Text + "】，无法重复添加！");
				return;
			}
			Singleton<全局变量类>.I.异兽录配置.图鉴列表.TryAdd(异兽录_添加宠物.Text, new 异兽录图鉴列表类
			{
				宠物名字 = 异兽录_添加宠物.Text,
				所属分类 = Enum.Parse<AllEnums.异兽Type>(异兽录_所属类型.Text),
				收录属性 = Enum.Parse<AllEnums.属性Type>(异兽录_添加属性.Text),
				收录数值 = (int)异兽录_添加数值.Value
			});
			异兽录_异兽列表.Rows.Add(异兽录_添加宠物.Text, 异兽录_所属类型.Text, 异兽录_添加属性.Text, 异兽录_添加数值.Value);
			MessageBox.Show("[" + 异兽录_添加宠物.Text + "]添加成功");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.异兽录配置窗口));
		this.异兽录_开关 = new System.Windows.Forms.CheckBox();
		this.异兽录_重载按钮 = new System.Windows.Forms.Button();
		this.异兽录_保存按钮 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.异兽录_形象 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.异兽录_朝向 = new System.Windows.Forms.ComboBox();
		this.label8 = new System.Windows.Forms.Label();
		this.异兽录_坐标Y = new System.Windows.Forms.NumericUpDown();
		this.异兽录_坐标X = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.异兽录_npc称号 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.异兽录_npc名字 = new System.Windows.Forms.TextBox();
		this.异兽录_变异加成数值 = new System.Windows.Forms.NumericUpDown();
		this.异兽录_变异加成属性 = new System.Windows.Forms.ComboBox();
		this.地狱道_名字 = new System.Windows.Forms.TextBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.异兽录_变异别称 = new System.Windows.Forms.TextBox();
		this.异兽录_神兽别称 = new System.Windows.Forms.TextBox();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.异兽录_神兽加成数值 = new System.Windows.Forms.NumericUpDown();
		this.异兽录_神兽加成属性 = new System.Windows.Forms.ComboBox();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.异兽录_仙元别称 = new System.Windows.Forms.TextBox();
		this.textBox7 = new System.Windows.Forms.TextBox();
		this.异兽录_仙元加成数值 = new System.Windows.Forms.NumericUpDown();
		this.异兽录_仙元加成属性 = new System.Windows.Forms.ComboBox();
		this.textBox8 = new System.Windows.Forms.TextBox();
		this.异兽录_元灵别称 = new System.Windows.Forms.TextBox();
		this.textBox10 = new System.Windows.Forms.TextBox();
		this.异兽录_元灵加成数值 = new System.Windows.Forms.NumericUpDown();
		this.异兽录_元灵加成属性 = new System.Windows.Forms.ComboBox();
		this.textBox11 = new System.Windows.Forms.TextBox();
		this.异兽录_御灵别称 = new System.Windows.Forms.TextBox();
		this.textBox13 = new System.Windows.Forms.TextBox();
		this.异兽录_御灵加成数值 = new System.Windows.Forms.NumericUpDown();
		this.异兽录_御灵加成属性 = new System.Windows.Forms.ComboBox();
		this.textBox14 = new System.Windows.Forms.TextBox();
		this.textBox15 = new System.Windows.Forms.TextBox();
		this.异兽录_特效道具 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.异兽录_异兽列表 = new System.Windows.Forms.DataGridView();
		this.textBox17 = new System.Windows.Forms.TextBox();
		this.异兽录_添加宠物 = new System.Windows.Forms.TextBox();
		this.异兽录_所属类型 = new System.Windows.Forms.ComboBox();
		this.异兽录_添加数值 = new System.Windows.Forms.NumericUpDown();
		this.异兽录_添加属性 = new System.Windows.Forms.ComboBox();
		this.异兽录_添加按钮 = new System.Windows.Forms.Button();
		this.textBox6 = new System.Windows.Forms.TextBox();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.textBox12 = new System.Windows.Forms.TextBox();
		this.textBox18 = new System.Windows.Forms.TextBox();
		this.textBox20 = new System.Windows.Forms.TextBox();
		this.宠物名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.分类 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.加成属性 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.数值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.异兽录_形象).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_坐标Y).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_坐标X).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_变异加成数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_神兽加成数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_仙元加成数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_元灵加成数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_御灵加成数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_异兽列表).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_添加数值).BeginInit();
		base.SuspendLayout();
		this.异兽录_开关.AutoSize = true;
		this.异兽录_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.异兽录_开关.Location = new System.Drawing.Point(12, 12);
		this.异兽录_开关.Name = "异兽录_开关";
		this.异兽录_开关.Size = new System.Drawing.Size(93, 23);
		this.异兽录_开关.TabIndex = 102;
		this.异兽录_开关.Text = "异兽录开关";
		this.异兽录_开关.UseVisualStyleBackColor = true;
		this.异兽录_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.异兽录_重载按钮.Location = new System.Drawing.Point(230, 8);
		this.异兽录_重载按钮.Name = "异兽录_重载按钮";
		this.异兽录_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.异兽录_重载按钮.TabIndex = 104;
		this.异兽录_重载按钮.Text = "重载配置";
		this.异兽录_重载按钮.UseVisualStyleBackColor = true;
		this.异兽录_重载按钮.Click += new System.EventHandler(异兽录_重载按钮_Click);
		this.异兽录_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.异兽录_保存按钮.Location = new System.Drawing.Point(124, 8);
		this.异兽录_保存按钮.Name = "异兽录_保存按钮";
		this.异兽录_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.异兽录_保存按钮.TabIndex = 103;
		this.异兽录_保存按钮.Text = "保存配置";
		this.异兽录_保存按钮.UseVisualStyleBackColor = true;
		this.异兽录_保存按钮.Click += new System.EventHandler(异兽录_保存按钮_Click);
		this.groupBox1.Controls.Add(this.异兽录_形象);
		this.groupBox1.Controls.Add(this.label9);
		this.groupBox1.Controls.Add(this.异兽录_朝向);
		this.groupBox1.Controls.Add(this.label8);
		this.groupBox1.Controls.Add(this.异兽录_坐标Y);
		this.groupBox1.Controls.Add(this.异兽录_坐标X);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.异兽录_npc称号);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.异兽录_npc名字);
		this.groupBox1.Location = new System.Drawing.Point(12, 44);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(786, 58);
		this.groupBox1.TabIndex = 105;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "npc配置";
		this.异兽录_形象.Location = new System.Drawing.Point(644, 17);
		this.异兽录_形象.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.异兽录_形象.Name = "异兽录_形象";
		this.异兽录_形象.Size = new System.Drawing.Size(100, 23);
		this.异兽录_形象.TabIndex = 112;
		this.label9.BackColor = System.Drawing.Color.Transparent;
		this.label9.Location = new System.Drawing.Point(611, 17);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(32, 23);
		this.label9.TabIndex = 111;
		this.label9.Text = "形象";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.异兽录_朝向.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.异兽录_朝向.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.异兽录_朝向.FormattingEnabled = true;
		this.异兽录_朝向.Items.AddRange(new object[8] { "左", "左上", "上", "右上", "右", "右下", "下", "左下" });
		this.异兽录_朝向.Location = new System.Drawing.Point(545, 17);
		this.异兽录_朝向.Name = "异兽录_朝向";
		this.异兽录_朝向.Size = new System.Drawing.Size(60, 25);
		this.异兽录_朝向.TabIndex = 110;
		this.label8.BackColor = System.Drawing.Color.Transparent;
		this.label8.Location = new System.Drawing.Point(513, 19);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(32, 23);
		this.label8.TabIndex = 109;
		this.label8.Text = "朝向";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.异兽录_坐标Y.Location = new System.Drawing.Point(447, 19);
		this.异兽录_坐标Y.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.异兽录_坐标Y.Name = "异兽录_坐标Y";
		this.异兽录_坐标Y.Size = new System.Drawing.Size(60, 23);
		this.异兽录_坐标Y.TabIndex = 108;
		this.异兽录_坐标X.Location = new System.Drawing.Point(370, 19);
		this.异兽录_坐标X.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.异兽录_坐标X.Name = "异兽录_坐标X";
		this.异兽录_坐标X.Size = new System.Drawing.Size(60, 23);
		this.异兽录_坐标X.TabIndex = 107;
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
		this.异兽录_npc称号.Location = new System.Drawing.Point(229, 19);
		this.异兽录_npc称号.Name = "异兽录_npc称号";
		this.异兽录_npc称号.Size = new System.Drawing.Size(100, 23);
		this.异兽录_npc称号.TabIndex = 105;
		this.label4.Location = new System.Drawing.Point(6, 19);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 102;
		this.label4.Text = "npc名字";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.异兽录_npc名字.Location = new System.Drawing.Point(67, 19);
		this.异兽录_npc名字.Name = "异兽录_npc名字";
		this.异兽录_npc名字.Size = new System.Drawing.Size(100, 23);
		this.异兽录_npc名字.TabIndex = 103;
		this.异兽录_变异加成数值.Location = new System.Drawing.Point(199, 136);
		this.异兽录_变异加成数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.异兽录_变异加成数值.Name = "异兽录_变异加成数值";
		this.异兽录_变异加成数值.Size = new System.Drawing.Size(60, 23);
		this.异兽录_变异加成数值.TabIndex = 116;
		this.异兽录_变异加成属性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.异兽录_变异加成属性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.异兽录_变异加成属性.FormattingEnabled = true;
		this.异兽录_变异加成属性.Items.AddRange(new object[6] { "金相性", "木相性", "水相性", "火相性", "土相性", "所有相性" });
		this.异兽录_变异加成属性.Location = new System.Drawing.Point(118, 135);
		this.异兽录_变异加成属性.Name = "异兽录_变异加成属性";
		this.异兽录_变异加成属性.Size = new System.Drawing.Size(80, 25);
		this.异兽录_变异加成属性.TabIndex = 115;
		this.地狱道_名字.Location = new System.Drawing.Point(12, 108);
		this.地狱道_名字.Name = "地狱道_名字";
		this.地狱道_名字.ReadOnly = true;
		this.地狱道_名字.Size = new System.Drawing.Size(100, 23);
		this.地狱道_名字.TabIndex = 114;
		this.地狱道_名字.Text = "变异收录齐全";
		this.地狱道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox1.Location = new System.Drawing.Point(118, 108);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(40, 23);
		this.textBox1.TabIndex = 117;
		this.textBox1.Text = "别称";
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.异兽录_变异别称.Location = new System.Drawing.Point(160, 108);
		this.异兽录_变异别称.Name = "异兽录_变异别称";
		this.异兽录_变异别称.Size = new System.Drawing.Size(100, 23);
		this.异兽录_变异别称.TabIndex = 118;
		this.异兽录_神兽别称.Location = new System.Drawing.Point(160, 183);
		this.异兽录_神兽别称.Name = "异兽录_神兽别称";
		this.异兽录_神兽别称.Size = new System.Drawing.Size(100, 23);
		this.异兽录_神兽别称.TabIndex = 123;
		this.textBox4.Location = new System.Drawing.Point(118, 183);
		this.textBox4.Name = "textBox4";
		this.textBox4.ReadOnly = true;
		this.textBox4.Size = new System.Drawing.Size(40, 23);
		this.textBox4.TabIndex = 122;
		this.textBox4.Text = "别称";
		this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.异兽录_神兽加成数值.Location = new System.Drawing.Point(199, 213);
		this.异兽录_神兽加成数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.异兽录_神兽加成数值.Name = "异兽录_神兽加成数值";
		this.异兽录_神兽加成数值.Size = new System.Drawing.Size(60, 23);
		this.异兽录_神兽加成数值.TabIndex = 121;
		this.异兽录_神兽加成属性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.异兽录_神兽加成属性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.异兽录_神兽加成属性.FormattingEnabled = true;
		this.异兽录_神兽加成属性.Items.AddRange(new object[6] { "金相性", "木相性", "水相性", "火相性", "土相性", "所有相性" });
		this.异兽录_神兽加成属性.Location = new System.Drawing.Point(118, 212);
		this.异兽录_神兽加成属性.Name = "异兽录_神兽加成属性";
		this.异兽录_神兽加成属性.Size = new System.Drawing.Size(80, 25);
		this.异兽录_神兽加成属性.TabIndex = 120;
		this.textBox5.Location = new System.Drawing.Point(12, 183);
		this.textBox5.Name = "textBox5";
		this.textBox5.ReadOnly = true;
		this.textBox5.Size = new System.Drawing.Size(100, 23);
		this.textBox5.TabIndex = 119;
		this.textBox5.Text = "神兽收录齐全";
		this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.异兽录_仙元别称.Location = new System.Drawing.Point(160, 344);
		this.异兽录_仙元别称.Name = "异兽录_仙元别称";
		this.异兽录_仙元别称.Size = new System.Drawing.Size(100, 23);
		this.异兽录_仙元别称.TabIndex = 133;
		this.textBox7.Location = new System.Drawing.Point(118, 344);
		this.textBox7.Name = "textBox7";
		this.textBox7.ReadOnly = true;
		this.textBox7.Size = new System.Drawing.Size(40, 23);
		this.textBox7.TabIndex = 132;
		this.textBox7.Text = "别称";
		this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.异兽录_仙元加成数值.Location = new System.Drawing.Point(199, 375);
		this.异兽录_仙元加成数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.异兽录_仙元加成数值.Name = "异兽录_仙元加成数值";
		this.异兽录_仙元加成数值.Size = new System.Drawing.Size(60, 23);
		this.异兽录_仙元加成数值.TabIndex = 131;
		this.异兽录_仙元加成属性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.异兽录_仙元加成属性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.异兽录_仙元加成属性.FormattingEnabled = true;
		this.异兽录_仙元加成属性.Items.AddRange(new object[6] { "金相性", "木相性", "水相性", "火相性", "土相性", "所有相性" });
		this.异兽录_仙元加成属性.Location = new System.Drawing.Point(118, 374);
		this.异兽录_仙元加成属性.Name = "异兽录_仙元加成属性";
		this.异兽录_仙元加成属性.Size = new System.Drawing.Size(80, 25);
		this.异兽录_仙元加成属性.TabIndex = 130;
		this.textBox8.Location = new System.Drawing.Point(12, 344);
		this.textBox8.Name = "textBox8";
		this.textBox8.ReadOnly = true;
		this.textBox8.Size = new System.Drawing.Size(100, 23);
		this.textBox8.TabIndex = 129;
		this.textBox8.Text = "仙元收录齐全";
		this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.异兽录_元灵别称.Location = new System.Drawing.Point(160, 261);
		this.异兽录_元灵别称.Name = "异兽录_元灵别称";
		this.异兽录_元灵别称.Size = new System.Drawing.Size(100, 23);
		this.异兽录_元灵别称.TabIndex = 128;
		this.textBox10.Location = new System.Drawing.Point(118, 261);
		this.textBox10.Name = "textBox10";
		this.textBox10.ReadOnly = true;
		this.textBox10.Size = new System.Drawing.Size(40, 23);
		this.textBox10.TabIndex = 127;
		this.textBox10.Text = "别称";
		this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.异兽录_元灵加成数值.Location = new System.Drawing.Point(199, 291);
		this.异兽录_元灵加成数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.异兽录_元灵加成数值.Name = "异兽录_元灵加成数值";
		this.异兽录_元灵加成数值.Size = new System.Drawing.Size(60, 23);
		this.异兽录_元灵加成数值.TabIndex = 126;
		this.异兽录_元灵加成属性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.异兽录_元灵加成属性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.异兽录_元灵加成属性.FormattingEnabled = true;
		this.异兽录_元灵加成属性.Items.AddRange(new object[6] { "金相性", "木相性", "水相性", "火相性", "土相性", "所有相性" });
		this.异兽录_元灵加成属性.Location = new System.Drawing.Point(118, 290);
		this.异兽录_元灵加成属性.Name = "异兽录_元灵加成属性";
		this.异兽录_元灵加成属性.Size = new System.Drawing.Size(80, 25);
		this.异兽录_元灵加成属性.TabIndex = 125;
		this.textBox11.Location = new System.Drawing.Point(12, 261);
		this.textBox11.Name = "textBox11";
		this.textBox11.ReadOnly = true;
		this.textBox11.Size = new System.Drawing.Size(100, 23);
		this.textBox11.TabIndex = 124;
		this.textBox11.Text = "元灵收录齐全";
		this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.异兽录_御灵别称.Location = new System.Drawing.Point(160, 430);
		this.异兽录_御灵别称.Name = "异兽录_御灵别称";
		this.异兽录_御灵别称.Size = new System.Drawing.Size(100, 23);
		this.异兽录_御灵别称.TabIndex = 138;
		this.textBox13.Location = new System.Drawing.Point(118, 430);
		this.textBox13.Name = "textBox13";
		this.textBox13.ReadOnly = true;
		this.textBox13.Size = new System.Drawing.Size(40, 23);
		this.textBox13.TabIndex = 137;
		this.textBox13.Text = "别称";
		this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.异兽录_御灵加成数值.Location = new System.Drawing.Point(199, 458);
		this.异兽录_御灵加成数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.异兽录_御灵加成数值.Name = "异兽录_御灵加成数值";
		this.异兽录_御灵加成数值.Size = new System.Drawing.Size(60, 23);
		this.异兽录_御灵加成数值.TabIndex = 136;
		this.异兽录_御灵加成属性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.异兽录_御灵加成属性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.异兽录_御灵加成属性.FormattingEnabled = true;
		this.异兽录_御灵加成属性.Items.AddRange(new object[6] { "金相性", "木相性", "水相性", "火相性", "土相性", "所有相性" });
		this.异兽录_御灵加成属性.Location = new System.Drawing.Point(118, 457);
		this.异兽录_御灵加成属性.Name = "异兽录_御灵加成属性";
		this.异兽录_御灵加成属性.Size = new System.Drawing.Size(80, 25);
		this.异兽录_御灵加成属性.TabIndex = 135;
		this.textBox14.Location = new System.Drawing.Point(12, 430);
		this.textBox14.Name = "textBox14";
		this.textBox14.ReadOnly = true;
		this.textBox14.Size = new System.Drawing.Size(100, 23);
		this.textBox14.TabIndex = 134;
		this.textBox14.Text = "御灵收录齐全";
		this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox15.Location = new System.Drawing.Point(342, 12);
		this.textBox15.Name = "textBox15";
		this.textBox15.ReadOnly = true;
		this.textBox15.Size = new System.Drawing.Size(60, 23);
		this.textBox15.TabIndex = 139;
		this.textBox15.Text = "特效道具";
		this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.异兽录_特效道具.Location = new System.Drawing.Point(403, 12);
		this.异兽录_特效道具.Name = "异兽录_特效道具";
		this.异兽录_特效道具.Size = new System.Drawing.Size(120, 23);
		this.异兽录_特效道具.TabIndex = 140;
		this.label1.BackColor = System.Drawing.SystemColors.Control;
		this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label1.ForeColor = System.Drawing.Color.Red;
		this.label1.Location = new System.Drawing.Point(524, 7);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(203, 32);
		this.label1.TabIndex = 141;
		this.label1.Text = "使用后可直接激活当前剩余所有未激活的异兽录属性，直接一步登天";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.异兽录_异兽列表.AllowUserToAddRows = false;
		this.异兽录_异兽列表.AllowUserToDeleteRows = false;
		this.异兽录_异兽列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.异兽录_异兽列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.异兽录_异兽列表.BackgroundColor = System.Drawing.Color.White;
		this.异兽录_异兽列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.异兽录_异兽列表.Columns.AddRange(this.宠物名字, this.分类, this.加成属性, this.数值);
		this.异兽录_异兽列表.Location = new System.Drawing.Point(281, 138);
		this.异兽录_异兽列表.MultiSelect = false;
		this.异兽录_异兽列表.Name = "异兽录_异兽列表";
		this.异兽录_异兽列表.RowHeadersVisible = false;
		this.异兽录_异兽列表.RowTemplate.Height = 25;
		this.异兽录_异兽列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.异兽录_异兽列表.Size = new System.Drawing.Size(517, 467);
		this.异兽录_异兽列表.TabIndex = 168;
		this.textBox17.Location = new System.Drawing.Point(281, 107);
		this.textBox17.Name = "textBox17";
		this.textBox17.ReadOnly = true;
		this.textBox17.Size = new System.Drawing.Size(60, 23);
		this.textBox17.TabIndex = 169;
		this.textBox17.Text = "宠物名字";
		this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.异兽录_添加宠物.Location = new System.Drawing.Point(342, 107);
		this.异兽录_添加宠物.Name = "异兽录_添加宠物";
		this.异兽录_添加宠物.Size = new System.Drawing.Size(80, 23);
		this.异兽录_添加宠物.TabIndex = 170;
		this.异兽录_所属类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.异兽录_所属类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.异兽录_所属类型.FormattingEnabled = true;
		this.异兽录_所属类型.Items.AddRange(new object[5] { "变异", "神兽", "元灵", "仙元", "御灵" });
		this.异兽录_所属类型.Location = new System.Drawing.Point(427, 106);
		this.异兽录_所属类型.Name = "异兽录_所属类型";
		this.异兽录_所属类型.Size = new System.Drawing.Size(60, 25);
		this.异兽录_所属类型.TabIndex = 171;
		this.异兽录_添加数值.Location = new System.Drawing.Point(623, 107);
		this.异兽录_添加数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.异兽录_添加数值.Name = "异兽录_添加数值";
		this.异兽录_添加数值.Size = new System.Drawing.Size(91, 23);
		this.异兽录_添加数值.TabIndex = 173;
		this.异兽录_添加属性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.异兽录_添加属性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.异兽录_添加属性.FormattingEnabled = true;
		this.异兽录_添加属性.Items.AddRange(new object[6] { "金相性", "木相性", "水相性", "火相性", "土相性", "所有相性" });
		this.异兽录_添加属性.Location = new System.Drawing.Point(492, 106);
		this.异兽录_添加属性.Name = "异兽录_添加属性";
		this.异兽录_添加属性.Size = new System.Drawing.Size(125, 25);
		this.异兽录_添加属性.TabIndex = 172;
		this.异兽录_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.异兽录_添加按钮.Location = new System.Drawing.Point(720, 107);
		this.异兽录_添加按钮.Name = "异兽录_添加按钮";
		this.异兽录_添加按钮.Size = new System.Drawing.Size(78, 23);
		this.异兽录_添加按钮.TabIndex = 174;
		this.异兽录_添加按钮.Text = "添加";
		this.异兽录_添加按钮.UseVisualStyleBackColor = true;
		this.异兽录_添加按钮.Click += new System.EventHandler(异兽录_添加按钮_Click);
		this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBox6.Location = new System.Drawing.Point(12, 140);
		this.textBox6.Multiline = true;
		this.textBox6.Name = "textBox6";
		this.textBox6.ReadOnly = true;
		this.textBox6.Size = new System.Drawing.Size(100, 15);
		this.textBox6.TabIndex = 178;
		this.textBox6.Text = "属性";
		this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBox2.Location = new System.Drawing.Point(12, 217);
		this.textBox2.Multiline = true;
		this.textBox2.Name = "textBox2";
		this.textBox2.ReadOnly = true;
		this.textBox2.Size = new System.Drawing.Size(100, 15);
		this.textBox2.TabIndex = 180;
		this.textBox2.Text = "属性";
		this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBox12.Location = new System.Drawing.Point(12, 295);
		this.textBox12.Multiline = true;
		this.textBox12.Name = "textBox12";
		this.textBox12.ReadOnly = true;
		this.textBox12.Size = new System.Drawing.Size(100, 15);
		this.textBox12.TabIndex = 186;
		this.textBox12.Text = "属性";
		this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBox18.Location = new System.Drawing.Point(12, 379);
		this.textBox18.Multiline = true;
		this.textBox18.Name = "textBox18";
		this.textBox18.ReadOnly = true;
		this.textBox18.Size = new System.Drawing.Size(100, 15);
		this.textBox18.TabIndex = 188;
		this.textBox18.Text = "属性";
		this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBox20.Location = new System.Drawing.Point(12, 462);
		this.textBox20.Multiline = true;
		this.textBox20.Name = "textBox20";
		this.textBox20.ReadOnly = true;
		this.textBox20.Size = new System.Drawing.Size(100, 15);
		this.textBox20.TabIndex = 190;
		this.textBox20.Text = "属性";
		this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.宠物名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.宠物名字.Frozen = true;
		this.宠物名字.HeaderText = "宠物名字";
		this.宠物名字.MinimumWidth = 100;
		this.宠物名字.Name = "宠物名字";
		this.分类.HeaderText = "分类";
		this.分类.Items.AddRange("变异", "神兽", "元灵", "仙元", "御灵");
		this.分类.MinimumWidth = 80;
		this.分类.Name = "分类";
		this.分类.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.分类.Width = 80;
		this.加成属性.HeaderText = "加成属性";
		this.加成属性.Items.AddRange("金相性", "木相性", "水相性", "火相性", "土相性", "所有相性");
		this.加成属性.MinimumWidth = 100;
		this.加成属性.Name = "加成属性";
		this.加成属性.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.数值.HeaderText = "数值";
		this.数值.MinimumWidth = 80;
		this.数值.Name = "数值";
		this.数值.Width = 80;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(812, 614);
		base.Controls.Add(this.textBox20);
		base.Controls.Add(this.textBox18);
		base.Controls.Add(this.textBox12);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.textBox6);
		base.Controls.Add(this.异兽录_添加按钮);
		base.Controls.Add(this.异兽录_添加数值);
		base.Controls.Add(this.异兽录_添加属性);
		base.Controls.Add(this.异兽录_所属类型);
		base.Controls.Add(this.异兽录_添加宠物);
		base.Controls.Add(this.textBox17);
		base.Controls.Add(this.异兽录_异兽列表);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.异兽录_特效道具);
		base.Controls.Add(this.textBox15);
		base.Controls.Add(this.异兽录_御灵别称);
		base.Controls.Add(this.textBox13);
		base.Controls.Add(this.异兽录_御灵加成数值);
		base.Controls.Add(this.异兽录_御灵加成属性);
		base.Controls.Add(this.textBox14);
		base.Controls.Add(this.异兽录_仙元别称);
		base.Controls.Add(this.textBox7);
		base.Controls.Add(this.异兽录_仙元加成数值);
		base.Controls.Add(this.异兽录_仙元加成属性);
		base.Controls.Add(this.textBox8);
		base.Controls.Add(this.异兽录_元灵别称);
		base.Controls.Add(this.textBox10);
		base.Controls.Add(this.异兽录_元灵加成数值);
		base.Controls.Add(this.异兽录_元灵加成属性);
		base.Controls.Add(this.textBox11);
		base.Controls.Add(this.异兽录_神兽别称);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.异兽录_神兽加成数值);
		base.Controls.Add(this.异兽录_神兽加成属性);
		base.Controls.Add(this.textBox5);
		base.Controls.Add(this.异兽录_变异别称);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.异兽录_变异加成数值);
		base.Controls.Add(this.异兽录_变异加成属性);
		base.Controls.Add(this.地狱道_名字);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.异兽录_开关);
		base.Controls.Add(this.异兽录_重载按钮);
		base.Controls.Add(this.异兽录_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "异兽录配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "异兽录配置窗口";
		base.Load += new System.EventHandler(异兽录配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.异兽录_形象).EndInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_坐标Y).EndInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_坐标X).EndInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_变异加成数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_神兽加成数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_仙元加成数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_元灵加成数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_御灵加成数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_异兽列表).EndInit();
		((System.ComponentModel.ISupportInitialize)this.异兽录_添加数值).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
