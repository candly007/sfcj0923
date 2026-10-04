using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 属性洗炼配置窗口 : Form
{
	private static 属性洗炼配置窗口 i;

	private IContainer components;

	private CheckBox 洗炼_开关;

	private Button 洗炼_重载按钮;

	private Button 洗炼_保存按钮;

	private GroupBox groupBox1;

	private NumericUpDown 洗炼_形象;

	private Label label9;

	private ComboBox 洗炼_朝向;

	private Label label8;

	private NumericUpDown 洗炼_坐标Y;

	private NumericUpDown 洗炼_坐标X;

	private Label label7;

	private Label label5;

	private TextBox 洗炼_npc称号;

	private Label label4;

	private TextBox 洗炼_npc名字;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private CheckBox 洗炼_时装锁定开关;

	private CheckBox 洗炼_时装开关;

	private NumericUpDown 洗炼_时装锁定消耗数值;

	private ComboBox 洗炼_时装锁定消耗类型;

	private TextBox 地狱道_名字;

	private NumericUpDown 洗炼_时装最大重复条数;

	private TextBox textBox1;

	private CheckBox 洗炼_时装属性重复开关;

	private TextBox 洗炼_时装名字;

	private TextBox textBox15;

	private NumericUpDown 洗炼_时装出最大条数次数;

	private TextBox textBox3;

	private NumericUpDown 洗炼_时装最高条数;

	private Label label1;

	private NumericUpDown 洗炼_时装最低条数;

	private TextBox textBox2;

	private CheckBox 洗炼_时装道具洗炼开关;

	private NumericUpDown 洗炼_时装出最高属性次数;

	private TextBox textBox4;

	private NumericUpDown 洗炼_时装道具洗炼消耗材料数量;

	private TextBox 洗炼_时装道具洗炼材料;

	private TextBox textBox5;

	private ComboBox 洗炼_时装数值洗炼类型;

	private NumericUpDown 洗炼_时装数值洗炼消耗数值;

	private TextBox textBox8;

	private CheckBox 洗炼_时装数值洗炼开关;

	private TextBox 洗炼_时装描述文字;

	private TextBox textBox9;

	private CheckBox 洗炼_时装描述开关;

	private Label label2;

	private ComboBox 洗炼_添加属性;

	private TextBox textBox10;

	private NumericUpDown 洗炼_添加最小;

	private TextBox textBox12;

	private NumericUpDown 洗炼_添加几率;

	private TextBox textBox11;

	private Button 洗炼_添加按钮;

	private Label label10;

	private NumericUpDown 洗炼_添加最大;

	private Label label6;

	private NumericUpDown 洗炼_添加一般;

	private Label label3;

	private DataGridView 洗炼_属性列表;

	private DataGridViewTextBoxColumn 属性名字;

	private DataGridViewTextBoxColumn 几率;

	private DataGridViewTextBoxColumn 最小值;

	private DataGridViewTextBoxColumn 平均值;

	private DataGridViewTextBoxColumn 最大值;

	private TabPage tabPage3;

	private TabPage tabPage4;

	private TabPage tabPage5;

	private TabPage tabPage6;

	private GroupBox groupBox2;

	private Label label11;

	private TextBox 洗炼_法宝描述文字;

	private TextBox textBox7;

	private CheckBox 洗炼_法宝描述开关;

	private ComboBox 洗炼_法宝数值洗炼类型;

	private NumericUpDown 洗炼_法宝数值洗炼消耗数值;

	private TextBox textBox13;

	private CheckBox 洗炼_法宝数值洗炼开关;

	private NumericUpDown 洗炼_法宝道具洗炼消耗材料数量;

	private TextBox 洗炼_法宝道具洗炼材料;

	private TextBox textBox16;

	private CheckBox 洗炼_法宝道具洗炼开关;

	private NumericUpDown 洗炼_法宝出最高属性次数;

	private TextBox textBox17;

	private NumericUpDown 洗炼_法宝出最大条数次数;

	private TextBox textBox18;

	private NumericUpDown 洗炼_法宝最高条数;

	private Label label12;

	private NumericUpDown 洗炼_法宝最低条数;

	private TextBox textBox19;

	private NumericUpDown 洗炼_法宝最大重复条数;

	private TextBox textBox20;

	private CheckBox 洗炼_法宝属性重复开关;

	private TextBox 洗炼_法宝名字;

	private TextBox textBox22;

	private NumericUpDown 洗炼_法宝锁定消耗数值;

	private ComboBox 洗炼_法宝锁定消耗类型;

	private TextBox textBox23;

	private CheckBox 洗炼_法宝锁定开关;

	private CheckBox 洗炼_法宝开关;

	private Label label13;

	private TextBox 洗炼_梭子描述文字;

	private TextBox textBox25;

	private CheckBox 洗炼_梭子描述开关;

	private ComboBox 洗炼_梭子数值洗炼类型;

	private NumericUpDown 洗炼_梭子数值洗炼消耗数值;

	private TextBox textBox26;

	private CheckBox 洗炼_梭子数值洗炼开关;

	private NumericUpDown 洗炼_梭子道具洗炼消耗材料数量;

	private TextBox 洗炼_梭子道具洗炼材料;

	private TextBox textBox28;

	private CheckBox 洗炼_梭子道具洗炼开关;

	private NumericUpDown 洗炼_梭子出最高属性次数;

	private TextBox textBox29;

	private NumericUpDown 洗炼_梭子出最大条数次数;

	private TextBox textBox30;

	private NumericUpDown 洗炼_梭子最高条数;

	private Label label14;

	private NumericUpDown 洗炼_梭子最低条数;

	private TextBox textBox31;

	private NumericUpDown 洗炼_梭子最大重复条数;

	private TextBox textBox32;

	private CheckBox 洗炼_梭子属性重复开关;

	private TextBox 洗炼_梭子名字;

	private TextBox textBox34;

	private NumericUpDown 洗炼_梭子锁定消耗数值;

	private ComboBox 洗炼_梭子锁定消耗类型;

	private TextBox textBox35;

	private CheckBox 洗炼_梭子锁定开关;

	private CheckBox 洗炼_梭子开关;

	private Label label15;

	private TextBox 洗炼_铭牌描述文字;

	private TextBox textBox37;

	private CheckBox 洗炼_铭牌描述开关;

	private ComboBox 洗炼_铭牌数值洗炼类型;

	private NumericUpDown 洗炼_铭牌数值洗炼消耗数值;

	private TextBox textBox38;

	private CheckBox 洗炼_铭牌数值洗炼开关;

	private NumericUpDown 洗炼_铭牌道具洗炼消耗材料数量;

	private TextBox 洗炼_铭牌道具洗炼材料;

	private TextBox textBox40;

	private CheckBox 洗炼_铭牌道具洗炼开关;

	private NumericUpDown 洗炼_铭牌出最高属性次数;

	private TextBox textBox41;

	private NumericUpDown 洗炼_铭牌出最大条数次数;

	private TextBox textBox42;

	private NumericUpDown 洗炼_铭牌最高条数;

	private Label label16;

	private NumericUpDown 洗炼_铭牌最低条数;

	private TextBox textBox43;

	private NumericUpDown 洗炼_铭牌最大重复条数;

	private TextBox textBox44;

	private CheckBox 洗炼_铭牌属性重复开关;

	private TextBox 洗炼_铭牌名字;

	private TextBox textBox46;

	private NumericUpDown 洗炼_铭牌锁定消耗数值;

	private ComboBox 洗炼_铭牌锁定消耗类型;

	private TextBox textBox47;

	private CheckBox 洗炼_铭牌锁定开关;

	private CheckBox 洗炼_铭牌开关;

	private Label label17;

	private TextBox 洗炼_仙器描述文字;

	private TextBox textBox49;

	private CheckBox 洗炼_仙器描述开关;

	private ComboBox 洗炼_仙器数值洗炼类型;

	private NumericUpDown 洗炼_仙器数值洗炼消耗数值;

	private TextBox textBox50;

	private CheckBox 洗炼_仙器数值洗炼开关;

	private NumericUpDown 洗炼_仙器道具洗炼消耗材料数量;

	private TextBox 洗炼_仙器道具洗炼材料;

	private TextBox textBox52;

	private CheckBox 洗炼_仙器道具洗炼开关;

	private NumericUpDown 洗炼_仙器出最高属性次数;

	private TextBox textBox53;

	private NumericUpDown 洗炼_仙器出最大条数次数;

	private TextBox textBox54;

	private NumericUpDown 洗炼_仙器最高条数;

	private Label label18;

	private NumericUpDown 洗炼_仙器最低条数;

	private TextBox textBox55;

	private NumericUpDown 洗炼_仙器最大重复条数;

	private TextBox textBox56;

	private CheckBox 洗炼_仙器属性重复开关;

	private TextBox 洗炼_仙器名字;

	private TextBox textBox58;

	private NumericUpDown 洗炼_仙器锁定消耗数值;

	private ComboBox 洗炼_仙器锁定消耗类型;

	private TextBox textBox59;

	private CheckBox 洗炼_仙器锁定开关;

	private CheckBox 洗炼_仙器开关;

	private Label label19;

	private TextBox 洗炼_灵幡描述文字;

	private TextBox textBox61;

	private CheckBox 洗炼_灵幡描述开关;

	private ComboBox 洗炼_灵幡数值洗炼类型;

	private NumericUpDown 洗炼_灵幡数值洗炼消耗数值;

	private TextBox textBox62;

	private CheckBox 洗炼_灵幡数值洗炼开关;

	private NumericUpDown 洗炼_灵幡道具洗炼消耗材料数量;

	private TextBox 洗炼_灵幡道具洗炼材料;

	private TextBox textBox64;

	private CheckBox 洗炼_灵幡道具洗炼开关;

	private NumericUpDown 洗炼_灵幡出最高属性次数;

	private TextBox textBox65;

	private NumericUpDown 洗炼_灵幡出最大条数次数;

	private TextBox textBox66;

	private NumericUpDown 洗炼_灵幡最高条数;

	private Label label20;

	private NumericUpDown 洗炼_灵幡最低条数;

	private TextBox textBox67;

	private NumericUpDown 洗炼_灵幡最大重复条数;

	private TextBox textBox68;

	private CheckBox 洗炼_灵幡属性重复开关;

	private TextBox 洗炼_灵幡名字;

	private TextBox textBox70;

	private NumericUpDown 洗炼_灵幡锁定消耗数值;

	private ComboBox 洗炼_灵幡锁定消耗类型;

	private TextBox textBox71;

	private CheckBox 洗炼_灵幡锁定开关;

	private CheckBox 洗炼_灵幡开关;

	private Label label21;

	private CheckBox 洗炼_背包开关;

	private NumericUpDown 洗炼_自动停止比例;

	private TextBox textBox6;

	private Label label22;

	public static 属性洗炼配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 属性洗炼配置窗口();
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

	public 属性洗炼配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 属性洗炼配置窗口_Load(object sender, EventArgs e)
	{
		洗炼_属性列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 删除事件回调);
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		洗炼_重载按钮_Click(sender, e);
	}

	private void 删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 洗炼_属性列表.CurrentRow != null)
		{
			int index = 洗炼_属性列表.CurrentRow.Index;
			if (index >= 0)
			{
				洗炼_属性列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 19)
		{
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			洗炼_开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.功能开关;
			洗炼_背包开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.背包开关;
			洗炼_自动停止比例.Value = Singleton<全局变量类>.I.属性洗炼配置.自动停止比例;
			洗炼_npc名字.Text = Singleton<全局变量类>.I.属性洗炼配置.NPC数据.npc名字;
			洗炼_npc称号.Text = Singleton<全局变量类>.I.属性洗炼配置.NPC数据.npc称号;
			洗炼_坐标X.Value = Singleton<全局变量类>.I.属性洗炼配置.NPC数据.坐标.X;
			洗炼_坐标Y.Value = Singleton<全局变量类>.I.属性洗炼配置.NPC数据.坐标.Y;
			洗炼_朝向.Text = $"{(AllEnums.朝向Type)Singleton<全局变量类>.I.属性洗炼配置.NPC数据.朝向}";
			洗炼_形象.Value = Singleton<全局变量类>.I.属性洗炼配置.NPC数据.npc形象;
			洗炼_时装开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.时装配置.功能开关;
			洗炼_时装名字.Text = Singleton<全局变量类>.I.属性洗炼配置.时装配置.装备名字;
			洗炼_时装锁定开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.时装配置.锁定开关;
			洗炼_时装锁定消耗类型.Text = Singleton<全局变量类>.I.属性洗炼配置.时装配置.锁定类型.ToString();
			洗炼_时装锁定消耗数值.Value = Singleton<全局变量类>.I.属性洗炼配置.时装配置.锁定消耗;
			洗炼_时装属性重复开关.Checked = false;
			洗炼_时装最大重复条数.Value = Singleton<全局变量类>.I.属性洗炼配置.时装配置.属性重复次数;
			洗炼_时装最低条数.Value = Singleton<全局变量类>.I.属性洗炼配置.时装配置.最低属性条数;
			洗炼_时装最高条数.Value = Singleton<全局变量类>.I.属性洗炼配置.时装配置.最高属性条数;
			洗炼_时装出最大条数次数.Value = Singleton<全局变量类>.I.属性洗炼配置.时装配置.刷新出最高条数次数;
			洗炼_时装出最高属性次数.Value = Singleton<全局变量类>.I.属性洗炼配置.时装配置.刷新出最高属性次数;
			洗炼_时装道具洗炼开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.时装配置.is道具洗炼;
			洗炼_时装道具洗炼材料.Text = Singleton<全局变量类>.I.属性洗炼配置.时装配置.洗炼道具名字;
			洗炼_时装道具洗炼消耗材料数量.Value = Singleton<全局变量类>.I.属性洗炼配置.时装配置.道具洗炼消耗;
			洗炼_时装数值洗炼开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.时装配置.is数值洗炼;
			洗炼_时装数值洗炼类型.Text = Singleton<全局变量类>.I.属性洗炼配置.时装配置.数值洗炼类型.ToString();
			洗炼_时装数值洗炼消耗数值.Value = Singleton<全局变量类>.I.属性洗炼配置.时装配置.数值洗炼消耗;
			洗炼_时装描述开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.时装配置.is附加描述;
			洗炼_时装描述文字.Text = Singleton<全局变量类>.I.属性洗炼配置.时装配置.附加描述;
			洗炼_法宝开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.功能开关;
			洗炼_法宝名字.Text = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.装备名字;
			洗炼_法宝锁定开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.锁定开关;
			洗炼_法宝锁定消耗类型.Text = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.锁定类型.ToString();
			洗炼_法宝锁定消耗数值.Value = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.锁定消耗;
			洗炼_法宝属性重复开关.Checked = false;
			洗炼_法宝最大重复条数.Value = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.属性重复次数;
			洗炼_法宝最低条数.Value = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.最低属性条数;
			洗炼_法宝最高条数.Value = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.最高属性条数;
			洗炼_法宝出最大条数次数.Value = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.刷新出最高条数次数;
			洗炼_法宝出最高属性次数.Value = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.刷新出最高属性次数;
			洗炼_法宝道具洗炼开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.is道具洗炼;
			洗炼_法宝道具洗炼材料.Text = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.洗炼道具名字;
			洗炼_法宝道具洗炼消耗材料数量.Value = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.道具洗炼消耗;
			洗炼_法宝数值洗炼开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.is数值洗炼;
			洗炼_法宝数值洗炼类型.Text = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.数值洗炼类型.ToString();
			洗炼_法宝数值洗炼消耗数值.Value = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.数值洗炼消耗;
			洗炼_法宝描述开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.is附加描述;
			洗炼_法宝描述文字.Text = Singleton<全局变量类>.I.属性洗炼配置.法宝配置.附加描述;
			洗炼_梭子开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.功能开关;
			洗炼_梭子名字.Text = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.装备名字;
			洗炼_梭子锁定开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.锁定开关;
			洗炼_梭子锁定消耗类型.Text = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.锁定类型.ToString();
			洗炼_梭子锁定消耗数值.Value = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.锁定消耗;
			洗炼_梭子属性重复开关.Checked = false;
			洗炼_梭子最大重复条数.Value = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.属性重复次数;
			洗炼_梭子最低条数.Value = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.最低属性条数;
			洗炼_梭子最高条数.Value = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.最高属性条数;
			洗炼_梭子出最大条数次数.Value = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.刷新出最高条数次数;
			洗炼_梭子出最高属性次数.Value = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.刷新出最高属性次数;
			洗炼_梭子道具洗炼开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.is道具洗炼;
			洗炼_梭子道具洗炼材料.Text = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.洗炼道具名字;
			洗炼_梭子道具洗炼消耗材料数量.Value = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.道具洗炼消耗;
			洗炼_梭子数值洗炼开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.is数值洗炼;
			洗炼_梭子数值洗炼类型.Text = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.数值洗炼类型.ToString();
			洗炼_梭子数值洗炼消耗数值.Value = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.数值洗炼消耗;
			洗炼_梭子描述开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.is附加描述;
			洗炼_梭子描述文字.Text = Singleton<全局变量类>.I.属性洗炼配置.梭子配置.附加描述;
			洗炼_铭牌开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.功能开关;
			洗炼_铭牌名字.Text = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.装备名字;
			洗炼_铭牌锁定开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.锁定开关;
			洗炼_铭牌锁定消耗类型.Text = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.锁定类型.ToString();
			洗炼_铭牌锁定消耗数值.Value = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.锁定消耗;
			洗炼_铭牌属性重复开关.Checked = false;
			洗炼_铭牌最大重复条数.Value = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.属性重复次数;
			洗炼_铭牌最低条数.Value = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.最低属性条数;
			洗炼_铭牌最高条数.Value = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.最高属性条数;
			洗炼_铭牌出最大条数次数.Value = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.刷新出最高条数次数;
			洗炼_铭牌出最高属性次数.Value = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.刷新出最高属性次数;
			洗炼_铭牌道具洗炼开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.is道具洗炼;
			洗炼_铭牌道具洗炼材料.Text = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.洗炼道具名字;
			洗炼_铭牌道具洗炼消耗材料数量.Value = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.道具洗炼消耗;
			洗炼_铭牌数值洗炼开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.is数值洗炼;
			洗炼_铭牌数值洗炼类型.Text = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.数值洗炼类型.ToString();
			洗炼_铭牌数值洗炼消耗数值.Value = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.数值洗炼消耗;
			洗炼_铭牌描述开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.is附加描述;
			洗炼_铭牌描述文字.Text = Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.附加描述;
			洗炼_仙器开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.功能开关;
			洗炼_仙器名字.Text = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.装备名字;
			洗炼_仙器锁定开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.锁定开关;
			洗炼_仙器锁定消耗类型.Text = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.锁定类型.ToString();
			洗炼_仙器锁定消耗数值.Value = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.锁定消耗;
			洗炼_仙器属性重复开关.Checked = false;
			洗炼_仙器最大重复条数.Value = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.属性重复次数;
			洗炼_仙器最低条数.Value = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.最低属性条数;
			洗炼_仙器最高条数.Value = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.最高属性条数;
			洗炼_仙器出最大条数次数.Value = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.刷新出最高条数次数;
			洗炼_仙器出最高属性次数.Value = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.刷新出最高属性次数;
			洗炼_仙器道具洗炼开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.is道具洗炼;
			洗炼_仙器道具洗炼材料.Text = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.洗炼道具名字;
			洗炼_仙器道具洗炼消耗材料数量.Value = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.道具洗炼消耗;
			洗炼_仙器数值洗炼开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.is数值洗炼;
			洗炼_仙器数值洗炼类型.Text = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.数值洗炼类型.ToString();
			洗炼_仙器数值洗炼消耗数值.Value = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.数值洗炼消耗;
			洗炼_仙器描述开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.is附加描述;
			洗炼_仙器描述文字.Text = Singleton<全局变量类>.I.属性洗炼配置.仙器配置.附加描述;
			洗炼_灵幡开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.功能开关;
			洗炼_灵幡名字.Text = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.装备名字;
			洗炼_灵幡锁定开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.锁定开关;
			洗炼_灵幡锁定消耗类型.Text = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.锁定类型.ToString();
			洗炼_灵幡锁定消耗数值.Value = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.锁定消耗;
			洗炼_灵幡属性重复开关.Checked = false;
			洗炼_灵幡最大重复条数.Value = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.属性重复次数;
			洗炼_灵幡最低条数.Value = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.最低属性条数;
			洗炼_灵幡最高条数.Value = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.最高属性条数;
			洗炼_灵幡出最大条数次数.Value = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.刷新出最高条数次数;
			洗炼_灵幡出最高属性次数.Value = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.刷新出最高属性次数;
			洗炼_灵幡道具洗炼开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.is道具洗炼;
			洗炼_灵幡道具洗炼材料.Text = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.洗炼道具名字;
			洗炼_灵幡道具洗炼消耗材料数量.Value = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.道具洗炼消耗;
			洗炼_灵幡数值洗炼开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.is数值洗炼;
			洗炼_灵幡数值洗炼类型.Text = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.数值洗炼类型.ToString();
			洗炼_灵幡数值洗炼消耗数值.Value = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.数值洗炼消耗;
			洗炼_灵幡描述开关.Checked = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.is附加描述;
			洗炼_灵幡描述文字.Text = Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.附加描述;
			洗炼_属性列表.Rows.Clear();
			for (int i = 0; i < Singleton<全局变量类>.I.属性洗炼配置.洗炼属性列表.Count; i++)
			{
				洗炼_属性列表.Rows.Add(Singleton<全局变量类>.I.属性洗炼配置.洗炼属性列表[i].属性.ToString(), Singleton<全局变量类>.I.属性洗炼配置.洗炼属性列表[i].出现几率, Singleton<全局变量类>.I.属性洗炼配置.洗炼属性列表[i].最低数值, Singleton<全局变量类>.I.属性洗炼配置.洗炼属性列表[i].平均数值, Singleton<全局变量类>.I.属性洗炼配置.洗炼属性列表[i].最高数值);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		Singleton<全局变量类>.I.属性洗炼配置.功能开关 = 洗炼_开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.背包开关 = 洗炼_背包开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.自动停止比例 = (int)洗炼_自动停止比例.Value;
		Singleton<全局变量类>.I.属性洗炼配置.NPC数据.npc名字 = 洗炼_npc名字.Text;
		Singleton<全局变量类>.I.属性洗炼配置.NPC数据.npc称号 = 洗炼_npc称号.Text;
		Singleton<全局变量类>.I.属性洗炼配置.NPC数据.坐标.X = (short)洗炼_坐标X.Value;
		Singleton<全局变量类>.I.属性洗炼配置.NPC数据.坐标.Y = (short)洗炼_坐标Y.Value;
		Singleton<全局变量类>.I.属性洗炼配置.NPC数据.朝向 = (short)Enum.Parse<AllEnums.朝向Type>(洗炼_朝向.Text);
		Singleton<全局变量类>.I.属性洗炼配置.NPC数据.npc形象 = (int)洗炼_形象.Value;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.装备类型 = AllEnums.装备Type.时装;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.功能开关 = 洗炼_时装开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.装备名字 = 洗炼_时装名字.Text;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.锁定开关 = 洗炼_时装锁定开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(洗炼_时装锁定消耗类型.Text, out Singleton<全局变量类>.I.属性洗炼配置.时装配置.锁定类型);
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.锁定消耗 = (int)洗炼_时装锁定消耗数值.Value;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.is属性重复 = false;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.属性重复次数 = (int)洗炼_时装最大重复条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.最低属性条数 = (int)洗炼_时装最低条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.最高属性条数 = (int)洗炼_时装最高条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.刷新出最高条数次数 = (int)洗炼_时装出最大条数次数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.刷新出最高属性次数 = (int)洗炼_时装出最高属性次数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.is道具洗炼 = 洗炼_时装道具洗炼开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.洗炼道具名字 = 洗炼_时装道具洗炼材料.Text;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.道具洗炼消耗 = (int)洗炼_时装道具洗炼消耗材料数量.Value;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.is数值洗炼 = 洗炼_时装数值洗炼开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(洗炼_时装数值洗炼类型.Text, out Singleton<全局变量类>.I.属性洗炼配置.时装配置.数值洗炼类型);
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.数值洗炼消耗 = (int)洗炼_时装数值洗炼消耗数值.Value;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.is附加描述 = 洗炼_时装描述开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.时装配置.附加描述 = 洗炼_时装描述文字.Text;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.装备类型 = AllEnums.装备Type.法宝;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.功能开关 = 洗炼_法宝开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.装备名字 = 洗炼_法宝名字.Text;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.锁定开关 = 洗炼_法宝锁定开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(洗炼_法宝锁定消耗类型.Text, out Singleton<全局变量类>.I.属性洗炼配置.法宝配置.锁定类型);
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.锁定消耗 = (int)洗炼_法宝锁定消耗数值.Value;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.is属性重复 = false;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.属性重复次数 = (int)洗炼_法宝最大重复条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.最低属性条数 = (int)洗炼_法宝最低条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.最高属性条数 = (int)洗炼_法宝最高条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.刷新出最高条数次数 = (int)洗炼_法宝出最大条数次数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.刷新出最高属性次数 = (int)洗炼_法宝出最高属性次数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.is道具洗炼 = 洗炼_法宝道具洗炼开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.洗炼道具名字 = 洗炼_法宝道具洗炼材料.Text;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.道具洗炼消耗 = (int)洗炼_法宝道具洗炼消耗材料数量.Value;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.is数值洗炼 = 洗炼_法宝数值洗炼开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(洗炼_法宝数值洗炼类型.Text, out Singleton<全局变量类>.I.属性洗炼配置.法宝配置.数值洗炼类型);
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.数值洗炼消耗 = (int)洗炼_法宝数值洗炼消耗数值.Value;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.is附加描述 = 洗炼_法宝描述开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.法宝配置.附加描述 = 洗炼_法宝描述文字.Text;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.装备类型 = AllEnums.装备Type.梭子;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.功能开关 = 洗炼_梭子开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.装备名字 = 洗炼_梭子名字.Text;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.锁定开关 = 洗炼_梭子锁定开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(洗炼_梭子锁定消耗类型.Text, out Singleton<全局变量类>.I.属性洗炼配置.梭子配置.锁定类型);
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.锁定消耗 = (int)洗炼_梭子锁定消耗数值.Value;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.is属性重复 = false;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.属性重复次数 = (int)洗炼_梭子最大重复条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.最低属性条数 = (int)洗炼_梭子最低条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.最高属性条数 = (int)洗炼_梭子最高条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.刷新出最高条数次数 = (int)洗炼_梭子出最大条数次数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.刷新出最高属性次数 = (int)洗炼_梭子出最高属性次数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.is道具洗炼 = 洗炼_梭子道具洗炼开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.洗炼道具名字 = 洗炼_梭子道具洗炼材料.Text;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.道具洗炼消耗 = (int)洗炼_梭子道具洗炼消耗材料数量.Value;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.is数值洗炼 = 洗炼_梭子数值洗炼开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(洗炼_梭子数值洗炼类型.Text, out Singleton<全局变量类>.I.属性洗炼配置.梭子配置.数值洗炼类型);
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.数值洗炼消耗 = (int)洗炼_梭子数值洗炼消耗数值.Value;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.is附加描述 = 洗炼_梭子描述开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.梭子配置.附加描述 = 洗炼_梭子描述文字.Text;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.装备类型 = AllEnums.装备Type.铭牌;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.功能开关 = 洗炼_铭牌开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.装备名字 = 洗炼_铭牌名字.Text;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.锁定开关 = 洗炼_铭牌锁定开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(洗炼_铭牌锁定消耗类型.Text, out Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.锁定类型);
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.锁定消耗 = (int)洗炼_铭牌锁定消耗数值.Value;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.is属性重复 = false;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.属性重复次数 = (int)洗炼_铭牌最大重复条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.最低属性条数 = (int)洗炼_铭牌最低条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.最高属性条数 = (int)洗炼_铭牌最高条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.刷新出最高条数次数 = (int)洗炼_铭牌出最大条数次数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.刷新出最高属性次数 = (int)洗炼_铭牌出最高属性次数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.is道具洗炼 = 洗炼_铭牌道具洗炼开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.洗炼道具名字 = 洗炼_铭牌道具洗炼材料.Text;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.道具洗炼消耗 = (int)洗炼_铭牌道具洗炼消耗材料数量.Value;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.is数值洗炼 = 洗炼_铭牌数值洗炼开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(洗炼_铭牌数值洗炼类型.Text, out Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.数值洗炼类型);
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.数值洗炼消耗 = (int)洗炼_铭牌数值洗炼消耗数值.Value;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.is附加描述 = 洗炼_铭牌描述开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.铭牌配置.附加描述 = 洗炼_铭牌描述文字.Text;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.装备类型 = AllEnums.装备Type.仙器;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.功能开关 = 洗炼_仙器开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.装备名字 = 洗炼_仙器名字.Text;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.锁定开关 = 洗炼_仙器锁定开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(洗炼_仙器锁定消耗类型.Text, out Singleton<全局变量类>.I.属性洗炼配置.仙器配置.锁定类型);
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.锁定消耗 = (int)洗炼_仙器锁定消耗数值.Value;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.is属性重复 = false;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.属性重复次数 = (int)洗炼_仙器最大重复条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.最低属性条数 = (int)洗炼_仙器最低条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.最高属性条数 = (int)洗炼_仙器最高条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.刷新出最高条数次数 = (int)洗炼_仙器出最大条数次数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.刷新出最高属性次数 = (int)洗炼_仙器出最高属性次数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.is道具洗炼 = 洗炼_仙器道具洗炼开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.洗炼道具名字 = 洗炼_仙器道具洗炼材料.Text;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.道具洗炼消耗 = (int)洗炼_仙器道具洗炼消耗材料数量.Value;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.is数值洗炼 = 洗炼_仙器数值洗炼开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(洗炼_仙器数值洗炼类型.Text, out Singleton<全局变量类>.I.属性洗炼配置.仙器配置.数值洗炼类型);
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.数值洗炼消耗 = (int)洗炼_仙器数值洗炼消耗数值.Value;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.is附加描述 = 洗炼_仙器描述开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.仙器配置.附加描述 = 洗炼_仙器描述文字.Text;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.装备类型 = AllEnums.装备Type.引灵幡;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.功能开关 = 洗炼_灵幡开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.装备名字 = 洗炼_灵幡名字.Text;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.锁定开关 = 洗炼_灵幡锁定开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(洗炼_灵幡锁定消耗类型.Text, out Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.锁定类型);
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.锁定消耗 = (int)洗炼_灵幡锁定消耗数值.Value;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.is属性重复 = false;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.属性重复次数 = (int)洗炼_灵幡最大重复条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.最低属性条数 = (int)洗炼_灵幡最低条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.最高属性条数 = (int)洗炼_灵幡最高条数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.刷新出最高条数次数 = (int)洗炼_灵幡出最大条数次数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.刷新出最高属性次数 = (int)洗炼_灵幡出最高属性次数.Value;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.is道具洗炼 = 洗炼_灵幡道具洗炼开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.洗炼道具名字 = 洗炼_灵幡道具洗炼材料.Text;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.道具洗炼消耗 = (int)洗炼_灵幡道具洗炼消耗材料数量.Value;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.is数值洗炼 = 洗炼_灵幡数值洗炼开关.Checked;
		Enum.TryParse<AllEnums.数值Type>(洗炼_灵幡数值洗炼类型.Text, out Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.数值洗炼类型);
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.数值洗炼消耗 = (int)洗炼_灵幡数值洗炼消耗数值.Value;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.is附加描述 = 洗炼_灵幡描述开关.Checked;
		Singleton<全局变量类>.I.属性洗炼配置.灵幡配置.附加描述 = 洗炼_灵幡描述文字.Text;
		Singleton<全局变量类>.I.属性洗炼配置.洗炼属性列表.Clear();
		for (int i = 0; i < 洗炼_属性列表.Rows.Count; i++)
		{
			DataGridViewCellCollection cells = 洗炼_属性列表.Rows[i].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value.ToString()))
			{
				Singleton<全局变量类>.I.属性洗炼配置.洗炼属性列表.Add(new 洗炼属性数据类
				{
					属性 = Enum.Parse<AllEnums.洗炼属性Type>(cells[0].Value.ToString()),
					出现几率 = int.Parse(cells[1].Value.ToString()),
					最低数值 = int.Parse(cells[2].Value.ToString()),
					平均数值 = int.Parse(cells[3].Value.ToString()),
					最高数值 = int.Parse(cells[4].Value.ToString())
				});
			}
		}
	}

	private void 洗炼_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 19, JsonConvert.SerializeObject(Singleton<全局变量类>.I.属性洗炼配置, Formatting.Indented));
		}
	}

	private void 洗炼_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 19);
		}
	}

	private void 洗炼_添加按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			if (string.IsNullOrWhiteSpace(洗炼_添加属性.Text))
			{
				MessageBox.Show("请选择加入洗炼属性池的属性！");
				return;
			}
			if (Singleton<全局变量类>.I.属性洗炼配置.洗炼属性列表.Any((洗炼属性数据类 x) => x.属性.ToString() == 洗炼_添加属性.Text))
			{
				MessageBox.Show("洗炼属性池列表中已经存在【" + 洗炼_添加属性.Text + "】，无法重复添加！");
				return;
			}
			Singleton<全局变量类>.I.属性洗炼配置.洗炼属性列表.Add(new 洗炼属性数据类
			{
				属性 = Enum.Parse<AllEnums.洗炼属性Type>(洗炼_添加属性.Text),
				出现几率 = (int)洗炼_添加几率.Value,
				最低数值 = (int)洗炼_添加最小.Value,
				平均数值 = (int)洗炼_添加一般.Value,
				最高数值 = (int)洗炼_添加最大.Value
			});
			洗炼_属性列表.Rows.Add(洗炼_添加属性.Text, 洗炼_添加几率.Value, 洗炼_添加最小.Value, 洗炼_添加一般.Value, 洗炼_添加最大.Value);
			MessageBox.Show("[" + 洗炼_添加属性.Text + "]添加成功");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.属性洗炼配置窗口));
		this.洗炼_开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_重载按钮 = new System.Windows.Forms.Button();
		this.洗炼_保存按钮 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.洗炼_形象 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.洗炼_朝向 = new System.Windows.Forms.ComboBox();
		this.label8 = new System.Windows.Forms.Label();
		this.洗炼_坐标Y = new System.Windows.Forms.NumericUpDown();
		this.洗炼_坐标X = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.洗炼_npc称号 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.洗炼_npc名字 = new System.Windows.Forms.TextBox();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.label2 = new System.Windows.Forms.Label();
		this.洗炼_时装描述文字 = new System.Windows.Forms.TextBox();
		this.textBox9 = new System.Windows.Forms.TextBox();
		this.洗炼_时装描述开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_时装数值洗炼类型 = new System.Windows.Forms.ComboBox();
		this.洗炼_时装数值洗炼消耗数值 = new System.Windows.Forms.NumericUpDown();
		this.textBox8 = new System.Windows.Forms.TextBox();
		this.洗炼_时装数值洗炼开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_时装道具洗炼消耗材料数量 = new System.Windows.Forms.NumericUpDown();
		this.洗炼_时装道具洗炼材料 = new System.Windows.Forms.TextBox();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.洗炼_时装道具洗炼开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_时装出最高属性次数 = new System.Windows.Forms.NumericUpDown();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.洗炼_时装出最大条数次数 = new System.Windows.Forms.NumericUpDown();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.洗炼_时装最高条数 = new System.Windows.Forms.NumericUpDown();
		this.label1 = new System.Windows.Forms.Label();
		this.洗炼_时装最低条数 = new System.Windows.Forms.NumericUpDown();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.洗炼_时装最大重复条数 = new System.Windows.Forms.NumericUpDown();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.洗炼_时装属性重复开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_时装名字 = new System.Windows.Forms.TextBox();
		this.textBox15 = new System.Windows.Forms.TextBox();
		this.洗炼_时装锁定消耗数值 = new System.Windows.Forms.NumericUpDown();
		this.洗炼_时装锁定消耗类型 = new System.Windows.Forms.ComboBox();
		this.地狱道_名字 = new System.Windows.Forms.TextBox();
		this.洗炼_时装锁定开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_时装开关 = new System.Windows.Forms.CheckBox();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.label11 = new System.Windows.Forms.Label();
		this.洗炼_法宝描述文字 = new System.Windows.Forms.TextBox();
		this.textBox7 = new System.Windows.Forms.TextBox();
		this.洗炼_法宝描述开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_法宝数值洗炼类型 = new System.Windows.Forms.ComboBox();
		this.洗炼_法宝数值洗炼消耗数值 = new System.Windows.Forms.NumericUpDown();
		this.textBox13 = new System.Windows.Forms.TextBox();
		this.洗炼_法宝数值洗炼开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_法宝道具洗炼消耗材料数量 = new System.Windows.Forms.NumericUpDown();
		this.洗炼_法宝道具洗炼材料 = new System.Windows.Forms.TextBox();
		this.textBox16 = new System.Windows.Forms.TextBox();
		this.洗炼_法宝道具洗炼开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_法宝出最高属性次数 = new System.Windows.Forms.NumericUpDown();
		this.textBox17 = new System.Windows.Forms.TextBox();
		this.洗炼_法宝出最大条数次数 = new System.Windows.Forms.NumericUpDown();
		this.textBox18 = new System.Windows.Forms.TextBox();
		this.洗炼_法宝最高条数 = new System.Windows.Forms.NumericUpDown();
		this.label12 = new System.Windows.Forms.Label();
		this.洗炼_法宝最低条数 = new System.Windows.Forms.NumericUpDown();
		this.textBox19 = new System.Windows.Forms.TextBox();
		this.洗炼_法宝最大重复条数 = new System.Windows.Forms.NumericUpDown();
		this.textBox20 = new System.Windows.Forms.TextBox();
		this.洗炼_法宝属性重复开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_法宝名字 = new System.Windows.Forms.TextBox();
		this.textBox22 = new System.Windows.Forms.TextBox();
		this.洗炼_法宝锁定消耗数值 = new System.Windows.Forms.NumericUpDown();
		this.洗炼_法宝锁定消耗类型 = new System.Windows.Forms.ComboBox();
		this.textBox23 = new System.Windows.Forms.TextBox();
		this.洗炼_法宝锁定开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_法宝开关 = new System.Windows.Forms.CheckBox();
		this.tabPage3 = new System.Windows.Forms.TabPage();
		this.label13 = new System.Windows.Forms.Label();
		this.洗炼_梭子描述文字 = new System.Windows.Forms.TextBox();
		this.textBox25 = new System.Windows.Forms.TextBox();
		this.洗炼_梭子描述开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_梭子数值洗炼类型 = new System.Windows.Forms.ComboBox();
		this.洗炼_梭子数值洗炼消耗数值 = new System.Windows.Forms.NumericUpDown();
		this.textBox26 = new System.Windows.Forms.TextBox();
		this.洗炼_梭子数值洗炼开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_梭子道具洗炼消耗材料数量 = new System.Windows.Forms.NumericUpDown();
		this.洗炼_梭子道具洗炼材料 = new System.Windows.Forms.TextBox();
		this.textBox28 = new System.Windows.Forms.TextBox();
		this.洗炼_梭子道具洗炼开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_梭子出最高属性次数 = new System.Windows.Forms.NumericUpDown();
		this.textBox29 = new System.Windows.Forms.TextBox();
		this.洗炼_梭子出最大条数次数 = new System.Windows.Forms.NumericUpDown();
		this.textBox30 = new System.Windows.Forms.TextBox();
		this.洗炼_梭子最高条数 = new System.Windows.Forms.NumericUpDown();
		this.label14 = new System.Windows.Forms.Label();
		this.洗炼_梭子最低条数 = new System.Windows.Forms.NumericUpDown();
		this.textBox31 = new System.Windows.Forms.TextBox();
		this.洗炼_梭子最大重复条数 = new System.Windows.Forms.NumericUpDown();
		this.textBox32 = new System.Windows.Forms.TextBox();
		this.洗炼_梭子属性重复开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_梭子名字 = new System.Windows.Forms.TextBox();
		this.textBox34 = new System.Windows.Forms.TextBox();
		this.洗炼_梭子锁定消耗数值 = new System.Windows.Forms.NumericUpDown();
		this.洗炼_梭子锁定消耗类型 = new System.Windows.Forms.ComboBox();
		this.textBox35 = new System.Windows.Forms.TextBox();
		this.洗炼_梭子锁定开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_梭子开关 = new System.Windows.Forms.CheckBox();
		this.tabPage4 = new System.Windows.Forms.TabPage();
		this.label15 = new System.Windows.Forms.Label();
		this.洗炼_铭牌描述文字 = new System.Windows.Forms.TextBox();
		this.textBox37 = new System.Windows.Forms.TextBox();
		this.洗炼_铭牌描述开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_铭牌数值洗炼类型 = new System.Windows.Forms.ComboBox();
		this.洗炼_铭牌数值洗炼消耗数值 = new System.Windows.Forms.NumericUpDown();
		this.textBox38 = new System.Windows.Forms.TextBox();
		this.洗炼_铭牌数值洗炼开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_铭牌道具洗炼消耗材料数量 = new System.Windows.Forms.NumericUpDown();
		this.洗炼_铭牌道具洗炼材料 = new System.Windows.Forms.TextBox();
		this.textBox40 = new System.Windows.Forms.TextBox();
		this.洗炼_铭牌道具洗炼开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_铭牌出最高属性次数 = new System.Windows.Forms.NumericUpDown();
		this.textBox41 = new System.Windows.Forms.TextBox();
		this.洗炼_铭牌出最大条数次数 = new System.Windows.Forms.NumericUpDown();
		this.textBox42 = new System.Windows.Forms.TextBox();
		this.洗炼_铭牌最高条数 = new System.Windows.Forms.NumericUpDown();
		this.label16 = new System.Windows.Forms.Label();
		this.洗炼_铭牌最低条数 = new System.Windows.Forms.NumericUpDown();
		this.textBox43 = new System.Windows.Forms.TextBox();
		this.洗炼_铭牌最大重复条数 = new System.Windows.Forms.NumericUpDown();
		this.textBox44 = new System.Windows.Forms.TextBox();
		this.洗炼_铭牌属性重复开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_铭牌名字 = new System.Windows.Forms.TextBox();
		this.textBox46 = new System.Windows.Forms.TextBox();
		this.洗炼_铭牌锁定消耗数值 = new System.Windows.Forms.NumericUpDown();
		this.洗炼_铭牌锁定消耗类型 = new System.Windows.Forms.ComboBox();
		this.textBox47 = new System.Windows.Forms.TextBox();
		this.洗炼_铭牌锁定开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_铭牌开关 = new System.Windows.Forms.CheckBox();
		this.tabPage5 = new System.Windows.Forms.TabPage();
		this.label17 = new System.Windows.Forms.Label();
		this.洗炼_仙器描述文字 = new System.Windows.Forms.TextBox();
		this.textBox49 = new System.Windows.Forms.TextBox();
		this.洗炼_仙器描述开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_仙器数值洗炼类型 = new System.Windows.Forms.ComboBox();
		this.洗炼_仙器数值洗炼消耗数值 = new System.Windows.Forms.NumericUpDown();
		this.textBox50 = new System.Windows.Forms.TextBox();
		this.洗炼_仙器数值洗炼开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_仙器道具洗炼消耗材料数量 = new System.Windows.Forms.NumericUpDown();
		this.洗炼_仙器道具洗炼材料 = new System.Windows.Forms.TextBox();
		this.textBox52 = new System.Windows.Forms.TextBox();
		this.洗炼_仙器道具洗炼开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_仙器出最高属性次数 = new System.Windows.Forms.NumericUpDown();
		this.textBox53 = new System.Windows.Forms.TextBox();
		this.洗炼_仙器出最大条数次数 = new System.Windows.Forms.NumericUpDown();
		this.textBox54 = new System.Windows.Forms.TextBox();
		this.洗炼_仙器最高条数 = new System.Windows.Forms.NumericUpDown();
		this.label18 = new System.Windows.Forms.Label();
		this.洗炼_仙器最低条数 = new System.Windows.Forms.NumericUpDown();
		this.textBox55 = new System.Windows.Forms.TextBox();
		this.洗炼_仙器最大重复条数 = new System.Windows.Forms.NumericUpDown();
		this.textBox56 = new System.Windows.Forms.TextBox();
		this.洗炼_仙器属性重复开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_仙器名字 = new System.Windows.Forms.TextBox();
		this.textBox58 = new System.Windows.Forms.TextBox();
		this.洗炼_仙器锁定消耗数值 = new System.Windows.Forms.NumericUpDown();
		this.洗炼_仙器锁定消耗类型 = new System.Windows.Forms.ComboBox();
		this.textBox59 = new System.Windows.Forms.TextBox();
		this.洗炼_仙器锁定开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_仙器开关 = new System.Windows.Forms.CheckBox();
		this.tabPage6 = new System.Windows.Forms.TabPage();
		this.label19 = new System.Windows.Forms.Label();
		this.洗炼_灵幡描述文字 = new System.Windows.Forms.TextBox();
		this.textBox61 = new System.Windows.Forms.TextBox();
		this.洗炼_灵幡描述开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_灵幡数值洗炼类型 = new System.Windows.Forms.ComboBox();
		this.洗炼_灵幡数值洗炼消耗数值 = new System.Windows.Forms.NumericUpDown();
		this.textBox62 = new System.Windows.Forms.TextBox();
		this.洗炼_灵幡数值洗炼开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_灵幡道具洗炼消耗材料数量 = new System.Windows.Forms.NumericUpDown();
		this.洗炼_灵幡道具洗炼材料 = new System.Windows.Forms.TextBox();
		this.textBox64 = new System.Windows.Forms.TextBox();
		this.洗炼_灵幡道具洗炼开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_灵幡出最高属性次数 = new System.Windows.Forms.NumericUpDown();
		this.textBox65 = new System.Windows.Forms.TextBox();
		this.洗炼_灵幡出最大条数次数 = new System.Windows.Forms.NumericUpDown();
		this.textBox66 = new System.Windows.Forms.TextBox();
		this.洗炼_灵幡最高条数 = new System.Windows.Forms.NumericUpDown();
		this.label20 = new System.Windows.Forms.Label();
		this.洗炼_灵幡最低条数 = new System.Windows.Forms.NumericUpDown();
		this.textBox67 = new System.Windows.Forms.TextBox();
		this.洗炼_灵幡最大重复条数 = new System.Windows.Forms.NumericUpDown();
		this.textBox68 = new System.Windows.Forms.TextBox();
		this.洗炼_灵幡属性重复开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_灵幡名字 = new System.Windows.Forms.TextBox();
		this.textBox70 = new System.Windows.Forms.TextBox();
		this.洗炼_灵幡锁定消耗数值 = new System.Windows.Forms.NumericUpDown();
		this.洗炼_灵幡锁定消耗类型 = new System.Windows.Forms.ComboBox();
		this.textBox71 = new System.Windows.Forms.TextBox();
		this.洗炼_灵幡锁定开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_灵幡开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_属性列表 = new System.Windows.Forms.DataGridView();
		this.属性名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.几率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.最小值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.平均值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.最大值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.洗炼_添加按钮 = new System.Windows.Forms.Button();
		this.label10 = new System.Windows.Forms.Label();
		this.洗炼_添加最大 = new System.Windows.Forms.NumericUpDown();
		this.label6 = new System.Windows.Forms.Label();
		this.洗炼_添加一般 = new System.Windows.Forms.NumericUpDown();
		this.label3 = new System.Windows.Forms.Label();
		this.洗炼_添加最小 = new System.Windows.Forms.NumericUpDown();
		this.textBox12 = new System.Windows.Forms.TextBox();
		this.洗炼_添加几率 = new System.Windows.Forms.NumericUpDown();
		this.textBox11 = new System.Windows.Forms.TextBox();
		this.洗炼_添加属性 = new System.Windows.Forms.ComboBox();
		this.textBox10 = new System.Windows.Forms.TextBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.label21 = new System.Windows.Forms.Label();
		this.洗炼_背包开关 = new System.Windows.Forms.CheckBox();
		this.洗炼_自动停止比例 = new System.Windows.Forms.NumericUpDown();
		this.textBox6 = new System.Windows.Forms.TextBox();
		this.label22 = new System.Windows.Forms.Label();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_形象).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_坐标Y).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_坐标X).BeginInit();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装数值洗炼消耗数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装道具洗炼消耗材料数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装出最高属性次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装出最大条数次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装最高条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装最低条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装最大重复条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装锁定消耗数值).BeginInit();
		this.tabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝数值洗炼消耗数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝道具洗炼消耗材料数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝出最高属性次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝出最大条数次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝最高条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝最低条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝最大重复条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝锁定消耗数值).BeginInit();
		this.tabPage3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子数值洗炼消耗数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子道具洗炼消耗材料数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子出最高属性次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子出最大条数次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子最高条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子最低条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子最大重复条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子锁定消耗数值).BeginInit();
		this.tabPage4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌数值洗炼消耗数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌道具洗炼消耗材料数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌出最高属性次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌出最大条数次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌最高条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌最低条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌最大重复条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌锁定消耗数值).BeginInit();
		this.tabPage5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器数值洗炼消耗数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器道具洗炼消耗材料数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器出最高属性次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器出最大条数次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器最高条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器最低条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器最大重复条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器锁定消耗数值).BeginInit();
		this.tabPage6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡数值洗炼消耗数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡道具洗炼消耗材料数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡出最高属性次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡出最大条数次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡最高条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡最低条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡最大重复条数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡锁定消耗数值).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_属性列表).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_添加最大).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_添加一般).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_添加最小).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_添加几率).BeginInit();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_自动停止比例).BeginInit();
		base.SuspendLayout();
		this.洗炼_开关.AutoSize = true;
		this.洗炼_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_开关.Location = new System.Drawing.Point(12, 44);
		this.洗炼_开关.Name = "洗炼_开关";
		this.洗炼_开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_开关.TabIndex = 105;
		this.洗炼_开关.Text = "属性洗炼开关";
		this.洗炼_开关.UseVisualStyleBackColor = true;
		this.洗炼_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_重载按钮.Location = new System.Drawing.Point(98, 9);
		this.洗炼_重载按钮.Name = "洗炼_重载按钮";
		this.洗炼_重载按钮.Size = new System.Drawing.Size(80, 30);
		this.洗炼_重载按钮.TabIndex = 107;
		this.洗炼_重载按钮.Text = "重载配置";
		this.洗炼_重载按钮.UseVisualStyleBackColor = true;
		this.洗炼_重载按钮.Click += new System.EventHandler(洗炼_重载按钮_Click);
		this.洗炼_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_保存按钮.Location = new System.Drawing.Point(12, 9);
		this.洗炼_保存按钮.Name = "洗炼_保存按钮";
		this.洗炼_保存按钮.Size = new System.Drawing.Size(80, 30);
		this.洗炼_保存按钮.TabIndex = 106;
		this.洗炼_保存按钮.Text = "保存配置";
		this.洗炼_保存按钮.UseVisualStyleBackColor = true;
		this.洗炼_保存按钮.Click += new System.EventHandler(洗炼_保存按钮_Click);
		this.groupBox1.BackColor = System.Drawing.Color.White;
		this.groupBox1.Controls.Add(this.洗炼_形象);
		this.groupBox1.Controls.Add(this.label9);
		this.groupBox1.Controls.Add(this.洗炼_朝向);
		this.groupBox1.Controls.Add(this.label8);
		this.groupBox1.Controls.Add(this.洗炼_坐标Y);
		this.groupBox1.Controls.Add(this.洗炼_坐标X);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.洗炼_npc称号);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.洗炼_npc名字);
		this.groupBox1.Location = new System.Drawing.Point(124, 44);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(707, 52);
		this.groupBox1.TabIndex = 109;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "npc配置";
		this.洗炼_形象.Location = new System.Drawing.Point(644, 17);
		this.洗炼_形象.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_形象.Name = "洗炼_形象";
		this.洗炼_形象.Size = new System.Drawing.Size(56, 23);
		this.洗炼_形象.TabIndex = 112;
		this.label9.BackColor = System.Drawing.Color.Transparent;
		this.label9.Location = new System.Drawing.Point(611, 17);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(32, 23);
		this.label9.TabIndex = 111;
		this.label9.Text = "形象";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.洗炼_朝向.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_朝向.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_朝向.FormattingEnabled = true;
		this.洗炼_朝向.Items.AddRange(new object[8] { "左", "左上", "上", "右上", "右", "右下", "下", "左下" });
		this.洗炼_朝向.Location = new System.Drawing.Point(545, 17);
		this.洗炼_朝向.Name = "洗炼_朝向";
		this.洗炼_朝向.Size = new System.Drawing.Size(60, 25);
		this.洗炼_朝向.TabIndex = 110;
		this.label8.BackColor = System.Drawing.Color.Transparent;
		this.label8.Location = new System.Drawing.Point(513, 19);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(32, 23);
		this.label8.TabIndex = 109;
		this.label8.Text = "朝向";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.洗炼_坐标Y.Location = new System.Drawing.Point(447, 19);
		this.洗炼_坐标Y.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.洗炼_坐标Y.Name = "洗炼_坐标Y";
		this.洗炼_坐标Y.Size = new System.Drawing.Size(60, 23);
		this.洗炼_坐标Y.TabIndex = 108;
		this.洗炼_坐标X.Location = new System.Drawing.Point(370, 19);
		this.洗炼_坐标X.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		this.洗炼_坐标X.Name = "洗炼_坐标X";
		this.洗炼_坐标X.Size = new System.Drawing.Size(60, 23);
		this.洗炼_坐标X.TabIndex = 107;
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
		this.洗炼_npc称号.Location = new System.Drawing.Point(229, 19);
		this.洗炼_npc称号.Name = "洗炼_npc称号";
		this.洗炼_npc称号.Size = new System.Drawing.Size(100, 23);
		this.洗炼_npc称号.TabIndex = 105;
		this.label4.Location = new System.Drawing.Point(6, 19);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 102;
		this.label4.Text = "npc名字";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.洗炼_npc名字.Location = new System.Drawing.Point(67, 19);
		this.洗炼_npc名字.Name = "洗炼_npc名字";
		this.洗炼_npc名字.Size = new System.Drawing.Size(100, 23);
		this.洗炼_npc名字.TabIndex = 103;
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Controls.Add(this.tabPage3);
		this.tabControl1.Controls.Add(this.tabPage4);
		this.tabControl1.Controls.Add(this.tabPage5);
		this.tabControl1.Controls.Add(this.tabPage6);
		this.tabControl1.Location = new System.Drawing.Point(12, 102);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(343, 537);
		this.tabControl1.TabIndex = 110;
		this.tabPage1.Controls.Add(this.label2);
		this.tabPage1.Controls.Add(this.洗炼_时装描述文字);
		this.tabPage1.Controls.Add(this.textBox9);
		this.tabPage1.Controls.Add(this.洗炼_时装描述开关);
		this.tabPage1.Controls.Add(this.洗炼_时装数值洗炼类型);
		this.tabPage1.Controls.Add(this.洗炼_时装数值洗炼消耗数值);
		this.tabPage1.Controls.Add(this.textBox8);
		this.tabPage1.Controls.Add(this.洗炼_时装数值洗炼开关);
		this.tabPage1.Controls.Add(this.洗炼_时装道具洗炼消耗材料数量);
		this.tabPage1.Controls.Add(this.洗炼_时装道具洗炼材料);
		this.tabPage1.Controls.Add(this.textBox5);
		this.tabPage1.Controls.Add(this.洗炼_时装道具洗炼开关);
		this.tabPage1.Controls.Add(this.洗炼_时装出最高属性次数);
		this.tabPage1.Controls.Add(this.textBox4);
		this.tabPage1.Controls.Add(this.洗炼_时装出最大条数次数);
		this.tabPage1.Controls.Add(this.textBox3);
		this.tabPage1.Controls.Add(this.洗炼_时装最高条数);
		this.tabPage1.Controls.Add(this.label1);
		this.tabPage1.Controls.Add(this.洗炼_时装最低条数);
		this.tabPage1.Controls.Add(this.textBox2);
		this.tabPage1.Controls.Add(this.洗炼_时装最大重复条数);
		this.tabPage1.Controls.Add(this.textBox1);
		this.tabPage1.Controls.Add(this.洗炼_时装属性重复开关);
		this.tabPage1.Controls.Add(this.洗炼_时装名字);
		this.tabPage1.Controls.Add(this.textBox15);
		this.tabPage1.Controls.Add(this.洗炼_时装锁定消耗数值);
		this.tabPage1.Controls.Add(this.洗炼_时装锁定消耗类型);
		this.tabPage1.Controls.Add(this.地狱道_名字);
		this.tabPage1.Controls.Add(this.洗炼_时装锁定开关);
		this.tabPage1.Controls.Add(this.洗炼_时装开关);
		this.tabPage1.Location = new System.Drawing.Point(4, 26);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(335, 507);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "时装";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label2.ForeColor = System.Drawing.Color.Red;
		this.label2.Location = new System.Drawing.Point(8, 57);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(319, 30);
		this.label2.TabIndex = 167;
		this.label2.Text = "装备名字如有有多个，请使用\"、\"连接(注意：、是中文格式)";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_时装描述文字.Location = new System.Drawing.Point(133, 475);
		this.洗炼_时装描述文字.Name = "洗炼_时装描述文字";
		this.洗炼_时装描述文字.Size = new System.Drawing.Size(194, 23);
		this.洗炼_时装描述文字.TabIndex = 165;
		this.textBox9.Location = new System.Drawing.Point(26, 475);
		this.textBox9.Name = "textBox9";
		this.textBox9.ReadOnly = true;
		this.textBox9.Size = new System.Drawing.Size(105, 23);
		this.textBox9.TabIndex = 164;
		this.textBox9.Text = "额外附加描述文字";
		this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_时装描述开关.AutoSize = true;
		this.洗炼_时装描述开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_时装描述开关.Location = new System.Drawing.Point(8, 451);
		this.洗炼_时装描述开关.Name = "洗炼_时装描述开关";
		this.洗炼_时装描述开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_时装描述开关.TabIndex = 163;
		this.洗炼_时装描述开关.Text = "附加描述开关";
		this.洗炼_时装描述开关.UseVisualStyleBackColor = true;
		this.洗炼_时装数值洗炼类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_时装数值洗炼类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_时装数值洗炼类型.FormattingEnabled = true;
		this.洗炼_时装数值洗炼类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "金钱", "灵气值" });
		this.洗炼_时装数值洗炼类型.Location = new System.Drawing.Point(133, 411);
		this.洗炼_时装数值洗炼类型.Name = "洗炼_时装数值洗炼类型";
		this.洗炼_时装数值洗炼类型.Size = new System.Drawing.Size(100, 25);
		this.洗炼_时装数值洗炼类型.TabIndex = 162;
		this.洗炼_时装数值洗炼消耗数值.Location = new System.Drawing.Point(234, 412);
		this.洗炼_时装数值洗炼消耗数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_时装数值洗炼消耗数值.Name = "洗炼_时装数值洗炼消耗数值";
		this.洗炼_时装数值洗炼消耗数值.Size = new System.Drawing.Size(93, 23);
		this.洗炼_时装数值洗炼消耗数值.TabIndex = 161;
		this.textBox8.Location = new System.Drawing.Point(26, 412);
		this.textBox8.Name = "textBox8";
		this.textBox8.ReadOnly = true;
		this.textBox8.Size = new System.Drawing.Size(105, 23);
		this.textBox8.TabIndex = 159;
		this.textBox8.Text = "洗炼消耗数值类型";
		this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_时装数值洗炼开关.AutoSize = true;
		this.洗炼_时装数值洗炼开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_时装数值洗炼开关.Location = new System.Drawing.Point(8, 388);
		this.洗炼_时装数值洗炼开关.Name = "洗炼_时装数值洗炼开关";
		this.洗炼_时装数值洗炼开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_时装数值洗炼开关.TabIndex = 158;
		this.洗炼_时装数值洗炼开关.Text = "数值洗炼开关";
		this.洗炼_时装数值洗炼开关.UseVisualStyleBackColor = true;
		this.洗炼_时装道具洗炼消耗材料数量.Location = new System.Drawing.Point(234, 349);
		this.洗炼_时装道具洗炼消耗材料数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_时装道具洗炼消耗材料数量.Name = "洗炼_时装道具洗炼消耗材料数量";
		this.洗炼_时装道具洗炼消耗材料数量.Size = new System.Drawing.Size(93, 23);
		this.洗炼_时装道具洗炼消耗材料数量.TabIndex = 157;
		this.洗炼_时装道具洗炼材料.Location = new System.Drawing.Point(133, 349);
		this.洗炼_时装道具洗炼材料.Name = "洗炼_时装道具洗炼材料";
		this.洗炼_时装道具洗炼材料.Size = new System.Drawing.Size(100, 23);
		this.洗炼_时装道具洗炼材料.TabIndex = 156;
		this.textBox5.Location = new System.Drawing.Point(26, 349);
		this.textBox5.Name = "textBox5";
		this.textBox5.ReadOnly = true;
		this.textBox5.Size = new System.Drawing.Size(105, 23);
		this.textBox5.TabIndex = 155;
		this.textBox5.Text = "洗炼消耗道具名字";
		this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_时装道具洗炼开关.AutoSize = true;
		this.洗炼_时装道具洗炼开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_时装道具洗炼开关.Location = new System.Drawing.Point(8, 325);
		this.洗炼_时装道具洗炼开关.Name = "洗炼_时装道具洗炼开关";
		this.洗炼_时装道具洗炼开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_时装道具洗炼开关.TabIndex = 154;
		this.洗炼_时装道具洗炼开关.Text = "道具洗炼开关";
		this.洗炼_时装道具洗炼开关.UseVisualStyleBackColor = true;
		this.洗炼_时装出最高属性次数.Location = new System.Drawing.Point(222, 284);
		this.洗炼_时装出最高属性次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_时装出最高属性次数.Name = "洗炼_时装出最高属性次数";
		this.洗炼_时装出最高属性次数.Size = new System.Drawing.Size(105, 23);
		this.洗炼_时装出最高属性次数.TabIndex = 153;
		this.textBox4.Location = new System.Drawing.Point(8, 283);
		this.textBox4.Name = "textBox4";
		this.textBox4.ReadOnly = true;
		this.textBox4.Size = new System.Drawing.Size(212, 23);
		this.textBox4.TabIndex = 152;
		this.textBox4.Text = "刷新次数有几率出现最大属性数值≥";
		this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_时装出最大条数次数.Location = new System.Drawing.Point(222, 255);
		this.洗炼_时装出最大条数次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_时装出最大条数次数.Name = "洗炼_时装出最大条数次数";
		this.洗炼_时装出最大条数次数.Size = new System.Drawing.Size(105, 23);
		this.洗炼_时装出最大条数次数.TabIndex = 151;
		this.textBox3.Location = new System.Drawing.Point(8, 254);
		this.textBox3.Name = "textBox3";
		this.textBox3.ReadOnly = true;
		this.textBox3.Size = new System.Drawing.Size(212, 23);
		this.textBox3.TabIndex = 150;
		this.textBox3.Text = "刷新次数有几率出现最大属性条数≥";
		this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_时装最高条数.Location = new System.Drawing.Point(225, 214);
		this.洗炼_时装最高条数.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.洗炼_时装最高条数.Name = "洗炼_时装最高条数";
		this.洗炼_时装最高条数.Size = new System.Drawing.Size(60, 23);
		this.洗炼_时装最高条数.TabIndex = 149;
		this.label1.BackColor = System.Drawing.Color.Transparent;
		this.label1.Location = new System.Drawing.Point(193, 213);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(32, 23);
		this.label1.TabIndex = 148;
		this.label1.Text = "—";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_时装最低条数.Location = new System.Drawing.Point(133, 213);
		this.洗炼_时装最低条数.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.洗炼_时装最低条数.Name = "洗炼_时装最低条数";
		this.洗炼_时装最低条数.Size = new System.Drawing.Size(60, 23);
		this.洗炼_时装最低条数.TabIndex = 147;
		this.textBox2.Location = new System.Drawing.Point(26, 213);
		this.textBox2.Name = "textBox2";
		this.textBox2.ReadOnly = true;
		this.textBox2.Size = new System.Drawing.Size(105, 23);
		this.textBox2.TabIndex = 146;
		this.textBox2.Text = "洗炼属性条数区间";
		this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_时装最大重复条数.Location = new System.Drawing.Point(133, 185);
		this.洗炼_时装最大重复条数.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
		this.洗炼_时装最大重复条数.Name = "洗炼_时装最大重复条数";
		this.洗炼_时装最大重复条数.Size = new System.Drawing.Size(152, 23);
		this.洗炼_时装最大重复条数.TabIndex = 145;
		this.洗炼_时装最大重复条数.Visible = false;
		this.textBox1.Location = new System.Drawing.Point(26, 184);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(105, 23);
		this.textBox1.TabIndex = 144;
		this.textBox1.Text = "重复属性条数≤2";
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox1.Visible = false;
		this.洗炼_时装属性重复开关.AutoSize = true;
		this.洗炼_时装属性重复开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_时装属性重复开关.Location = new System.Drawing.Point(8, 155);
		this.洗炼_时装属性重复开关.Name = "洗炼_时装属性重复开关";
		this.洗炼_时装属性重复开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_时装属性重复开关.TabIndex = 143;
		this.洗炼_时装属性重复开关.Text = "属性重复开关";
		this.洗炼_时装属性重复开关.UseVisualStyleBackColor = true;
		this.洗炼_时装属性重复开关.Visible = false;
		this.洗炼_时装名字.Location = new System.Drawing.Point(69, 33);
		this.洗炼_时装名字.Name = "洗炼_时装名字";
		this.洗炼_时装名字.Size = new System.Drawing.Size(258, 23);
		this.洗炼_时装名字.TabIndex = 142;
		this.textBox15.Location = new System.Drawing.Point(8, 33);
		this.textBox15.Name = "textBox15";
		this.textBox15.ReadOnly = true;
		this.textBox15.Size = new System.Drawing.Size(60, 23);
		this.textBox15.TabIndex = 141;
		this.textBox15.Text = "可洗时装";
		this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_时装锁定消耗数值.Location = new System.Drawing.Point(208, 114);
		this.洗炼_时装锁定消耗数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_时装锁定消耗数值.Name = "洗炼_时装锁定消耗数值";
		this.洗炼_时装锁定消耗数值.Size = new System.Drawing.Size(119, 23);
		this.洗炼_时装锁定消耗数值.TabIndex = 119;
		this.洗炼_时装锁定消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_时装锁定消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_时装锁定消耗类型.FormattingEnabled = true;
		this.洗炼_时装锁定消耗类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "金钱", "灵气值" });
		this.洗炼_时装锁定消耗类型.Location = new System.Drawing.Point(127, 113);
		this.洗炼_时装锁定消耗类型.Name = "洗炼_时装锁定消耗类型";
		this.洗炼_时装锁定消耗类型.Size = new System.Drawing.Size(80, 25);
		this.洗炼_时装锁定消耗类型.TabIndex = 118;
		this.地狱道_名字.Location = new System.Drawing.Point(26, 114);
		this.地狱道_名字.Name = "地狱道_名字";
		this.地狱道_名字.ReadOnly = true;
		this.地狱道_名字.Size = new System.Drawing.Size(100, 23);
		this.地狱道_名字.TabIndex = 117;
		this.地狱道_名字.Text = "锁定/解锁消耗";
		this.地狱道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_时装锁定开关.AutoSize = true;
		this.洗炼_时装锁定开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_时装锁定开关.Location = new System.Drawing.Point(8, 90);
		this.洗炼_时装锁定开关.Name = "洗炼_时装锁定开关";
		this.洗炼_时装锁定开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_时装锁定开关.TabIndex = 107;
		this.洗炼_时装锁定开关.Text = "属性锁定开关";
		this.洗炼_时装锁定开关.UseVisualStyleBackColor = true;
		this.洗炼_时装开关.AutoSize = true;
		this.洗炼_时装开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_时装开关.Location = new System.Drawing.Point(8, 9);
		this.洗炼_时装开关.Name = "洗炼_时装开关";
		this.洗炼_时装开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_时装开关.TabIndex = 106;
		this.洗炼_时装开关.Text = "时装洗炼开关";
		this.洗炼_时装开关.UseVisualStyleBackColor = true;
		this.tabPage2.Controls.Add(this.label11);
		this.tabPage2.Controls.Add(this.洗炼_法宝描述文字);
		this.tabPage2.Controls.Add(this.textBox7);
		this.tabPage2.Controls.Add(this.洗炼_法宝描述开关);
		this.tabPage2.Controls.Add(this.洗炼_法宝数值洗炼类型);
		this.tabPage2.Controls.Add(this.洗炼_法宝数值洗炼消耗数值);
		this.tabPage2.Controls.Add(this.textBox13);
		this.tabPage2.Controls.Add(this.洗炼_法宝数值洗炼开关);
		this.tabPage2.Controls.Add(this.洗炼_法宝道具洗炼消耗材料数量);
		this.tabPage2.Controls.Add(this.洗炼_法宝道具洗炼材料);
		this.tabPage2.Controls.Add(this.textBox16);
		this.tabPage2.Controls.Add(this.洗炼_法宝道具洗炼开关);
		this.tabPage2.Controls.Add(this.洗炼_法宝出最高属性次数);
		this.tabPage2.Controls.Add(this.textBox17);
		this.tabPage2.Controls.Add(this.洗炼_法宝出最大条数次数);
		this.tabPage2.Controls.Add(this.textBox18);
		this.tabPage2.Controls.Add(this.洗炼_法宝最高条数);
		this.tabPage2.Controls.Add(this.label12);
		this.tabPage2.Controls.Add(this.洗炼_法宝最低条数);
		this.tabPage2.Controls.Add(this.textBox19);
		this.tabPage2.Controls.Add(this.洗炼_法宝最大重复条数);
		this.tabPage2.Controls.Add(this.textBox20);
		this.tabPage2.Controls.Add(this.洗炼_法宝属性重复开关);
		this.tabPage2.Controls.Add(this.洗炼_法宝名字);
		this.tabPage2.Controls.Add(this.textBox22);
		this.tabPage2.Controls.Add(this.洗炼_法宝锁定消耗数值);
		this.tabPage2.Controls.Add(this.洗炼_法宝锁定消耗类型);
		this.tabPage2.Controls.Add(this.textBox23);
		this.tabPage2.Controls.Add(this.洗炼_法宝锁定开关);
		this.tabPage2.Controls.Add(this.洗炼_法宝开关);
		this.tabPage2.Location = new System.Drawing.Point(4, 26);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(335, 507);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "法宝";
		this.tabPage2.UseVisualStyleBackColor = true;
		this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label11.ForeColor = System.Drawing.Color.Red;
		this.label11.Location = new System.Drawing.Point(8, 57);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(319, 30);
		this.label11.TabIndex = 197;
		this.label11.Text = "装备名字如有有多个，请使用\"，\"连接(注意：、是中文格式)";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_法宝描述文字.Location = new System.Drawing.Point(133, 475);
		this.洗炼_法宝描述文字.Name = "洗炼_法宝描述文字";
		this.洗炼_法宝描述文字.Size = new System.Drawing.Size(194, 23);
		this.洗炼_法宝描述文字.TabIndex = 196;
		this.textBox7.Location = new System.Drawing.Point(26, 475);
		this.textBox7.Name = "textBox7";
		this.textBox7.ReadOnly = true;
		this.textBox7.Size = new System.Drawing.Size(105, 23);
		this.textBox7.TabIndex = 195;
		this.textBox7.Text = "额外附加描述文字";
		this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_法宝描述开关.AutoSize = true;
		this.洗炼_法宝描述开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_法宝描述开关.Location = new System.Drawing.Point(8, 451);
		this.洗炼_法宝描述开关.Name = "洗炼_法宝描述开关";
		this.洗炼_法宝描述开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_法宝描述开关.TabIndex = 194;
		this.洗炼_法宝描述开关.Text = "附加描述开关";
		this.洗炼_法宝描述开关.UseVisualStyleBackColor = true;
		this.洗炼_法宝数值洗炼类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_法宝数值洗炼类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_法宝数值洗炼类型.FormattingEnabled = true;
		this.洗炼_法宝数值洗炼类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "金钱", "灵气值" });
		this.洗炼_法宝数值洗炼类型.Location = new System.Drawing.Point(133, 411);
		this.洗炼_法宝数值洗炼类型.Name = "洗炼_法宝数值洗炼类型";
		this.洗炼_法宝数值洗炼类型.Size = new System.Drawing.Size(100, 25);
		this.洗炼_法宝数值洗炼类型.TabIndex = 193;
		this.洗炼_法宝数值洗炼消耗数值.Location = new System.Drawing.Point(234, 412);
		this.洗炼_法宝数值洗炼消耗数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_法宝数值洗炼消耗数值.Name = "洗炼_法宝数值洗炼消耗数值";
		this.洗炼_法宝数值洗炼消耗数值.Size = new System.Drawing.Size(93, 23);
		this.洗炼_法宝数值洗炼消耗数值.TabIndex = 192;
		this.textBox13.Location = new System.Drawing.Point(26, 412);
		this.textBox13.Name = "textBox13";
		this.textBox13.ReadOnly = true;
		this.textBox13.Size = new System.Drawing.Size(105, 23);
		this.textBox13.TabIndex = 191;
		this.textBox13.Text = "洗炼消耗数值类型";
		this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_法宝数值洗炼开关.AutoSize = true;
		this.洗炼_法宝数值洗炼开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_法宝数值洗炼开关.Location = new System.Drawing.Point(8, 388);
		this.洗炼_法宝数值洗炼开关.Name = "洗炼_法宝数值洗炼开关";
		this.洗炼_法宝数值洗炼开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_法宝数值洗炼开关.TabIndex = 190;
		this.洗炼_法宝数值洗炼开关.Text = "数值洗炼开关";
		this.洗炼_法宝数值洗炼开关.UseVisualStyleBackColor = true;
		this.洗炼_法宝道具洗炼消耗材料数量.Location = new System.Drawing.Point(234, 349);
		this.洗炼_法宝道具洗炼消耗材料数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_法宝道具洗炼消耗材料数量.Name = "洗炼_法宝道具洗炼消耗材料数量";
		this.洗炼_法宝道具洗炼消耗材料数量.Size = new System.Drawing.Size(93, 23);
		this.洗炼_法宝道具洗炼消耗材料数量.TabIndex = 189;
		this.洗炼_法宝道具洗炼材料.Location = new System.Drawing.Point(133, 349);
		this.洗炼_法宝道具洗炼材料.Name = "洗炼_法宝道具洗炼材料";
		this.洗炼_法宝道具洗炼材料.Size = new System.Drawing.Size(100, 23);
		this.洗炼_法宝道具洗炼材料.TabIndex = 188;
		this.textBox16.Location = new System.Drawing.Point(26, 349);
		this.textBox16.Name = "textBox16";
		this.textBox16.ReadOnly = true;
		this.textBox16.Size = new System.Drawing.Size(105, 23);
		this.textBox16.TabIndex = 187;
		this.textBox16.Text = "洗炼消耗道具名字";
		this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_法宝道具洗炼开关.AutoSize = true;
		this.洗炼_法宝道具洗炼开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_法宝道具洗炼开关.Location = new System.Drawing.Point(8, 325);
		this.洗炼_法宝道具洗炼开关.Name = "洗炼_法宝道具洗炼开关";
		this.洗炼_法宝道具洗炼开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_法宝道具洗炼开关.TabIndex = 186;
		this.洗炼_法宝道具洗炼开关.Text = "道具洗炼开关";
		this.洗炼_法宝道具洗炼开关.UseVisualStyleBackColor = true;
		this.洗炼_法宝出最高属性次数.Location = new System.Drawing.Point(222, 284);
		this.洗炼_法宝出最高属性次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_法宝出最高属性次数.Name = "洗炼_法宝出最高属性次数";
		this.洗炼_法宝出最高属性次数.Size = new System.Drawing.Size(105, 23);
		this.洗炼_法宝出最高属性次数.TabIndex = 185;
		this.textBox17.Location = new System.Drawing.Point(8, 283);
		this.textBox17.Name = "textBox17";
		this.textBox17.ReadOnly = true;
		this.textBox17.Size = new System.Drawing.Size(212, 23);
		this.textBox17.TabIndex = 184;
		this.textBox17.Text = "刷新次数有几率出现最大属性数值≥";
		this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_法宝出最大条数次数.Location = new System.Drawing.Point(222, 255);
		this.洗炼_法宝出最大条数次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_法宝出最大条数次数.Name = "洗炼_法宝出最大条数次数";
		this.洗炼_法宝出最大条数次数.Size = new System.Drawing.Size(105, 23);
		this.洗炼_法宝出最大条数次数.TabIndex = 183;
		this.textBox18.Location = new System.Drawing.Point(8, 254);
		this.textBox18.Name = "textBox18";
		this.textBox18.ReadOnly = true;
		this.textBox18.Size = new System.Drawing.Size(212, 23);
		this.textBox18.TabIndex = 182;
		this.textBox18.Text = "刷新次数有几率出现最大属性条数≥";
		this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_法宝最高条数.Location = new System.Drawing.Point(225, 214);
		this.洗炼_法宝最高条数.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.洗炼_法宝最高条数.Name = "洗炼_法宝最高条数";
		this.洗炼_法宝最高条数.Size = new System.Drawing.Size(60, 23);
		this.洗炼_法宝最高条数.TabIndex = 181;
		this.label12.BackColor = System.Drawing.Color.Transparent;
		this.label12.Location = new System.Drawing.Point(193, 213);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(32, 23);
		this.label12.TabIndex = 180;
		this.label12.Text = "—";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_法宝最低条数.Location = new System.Drawing.Point(133, 213);
		this.洗炼_法宝最低条数.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.洗炼_法宝最低条数.Name = "洗炼_法宝最低条数";
		this.洗炼_法宝最低条数.Size = new System.Drawing.Size(60, 23);
		this.洗炼_法宝最低条数.TabIndex = 179;
		this.textBox19.Location = new System.Drawing.Point(26, 213);
		this.textBox19.Name = "textBox19";
		this.textBox19.ReadOnly = true;
		this.textBox19.Size = new System.Drawing.Size(105, 23);
		this.textBox19.TabIndex = 178;
		this.textBox19.Text = "洗炼属性条数区间";
		this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_法宝最大重复条数.Location = new System.Drawing.Point(133, 185);
		this.洗炼_法宝最大重复条数.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
		this.洗炼_法宝最大重复条数.Name = "洗炼_法宝最大重复条数";
		this.洗炼_法宝最大重复条数.Size = new System.Drawing.Size(152, 23);
		this.洗炼_法宝最大重复条数.TabIndex = 177;
		this.洗炼_法宝最大重复条数.Visible = false;
		this.textBox20.Location = new System.Drawing.Point(26, 184);
		this.textBox20.Name = "textBox20";
		this.textBox20.ReadOnly = true;
		this.textBox20.Size = new System.Drawing.Size(105, 23);
		this.textBox20.TabIndex = 176;
		this.textBox20.Text = "重复属性条数≤2";
		this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox20.Visible = false;
		this.洗炼_法宝属性重复开关.AutoSize = true;
		this.洗炼_法宝属性重复开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_法宝属性重复开关.Location = new System.Drawing.Point(8, 155);
		this.洗炼_法宝属性重复开关.Name = "洗炼_法宝属性重复开关";
		this.洗炼_法宝属性重复开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_法宝属性重复开关.TabIndex = 175;
		this.洗炼_法宝属性重复开关.Text = "属性重复开关";
		this.洗炼_法宝属性重复开关.UseVisualStyleBackColor = true;
		this.洗炼_法宝属性重复开关.Visible = false;
		this.洗炼_法宝名字.Location = new System.Drawing.Point(69, 33);
		this.洗炼_法宝名字.Name = "洗炼_法宝名字";
		this.洗炼_法宝名字.Size = new System.Drawing.Size(258, 23);
		this.洗炼_法宝名字.TabIndex = 174;
		this.textBox22.Location = new System.Drawing.Point(8, 33);
		this.textBox22.Name = "textBox22";
		this.textBox22.ReadOnly = true;
		this.textBox22.Size = new System.Drawing.Size(60, 23);
		this.textBox22.TabIndex = 173;
		this.textBox22.Text = "可洗法宝";
		this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_法宝锁定消耗数值.Location = new System.Drawing.Point(208, 114);
		this.洗炼_法宝锁定消耗数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_法宝锁定消耗数值.Name = "洗炼_法宝锁定消耗数值";
		this.洗炼_法宝锁定消耗数值.Size = new System.Drawing.Size(119, 23);
		this.洗炼_法宝锁定消耗数值.TabIndex = 172;
		this.洗炼_法宝锁定消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_法宝锁定消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_法宝锁定消耗类型.FormattingEnabled = true;
		this.洗炼_法宝锁定消耗类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "金钱", "灵气值" });
		this.洗炼_法宝锁定消耗类型.Location = new System.Drawing.Point(127, 113);
		this.洗炼_法宝锁定消耗类型.Name = "洗炼_法宝锁定消耗类型";
		this.洗炼_法宝锁定消耗类型.Size = new System.Drawing.Size(80, 25);
		this.洗炼_法宝锁定消耗类型.TabIndex = 171;
		this.textBox23.Location = new System.Drawing.Point(26, 114);
		this.textBox23.Name = "textBox23";
		this.textBox23.ReadOnly = true;
		this.textBox23.Size = new System.Drawing.Size(100, 23);
		this.textBox23.TabIndex = 170;
		this.textBox23.Text = "锁定/解锁消耗";
		this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_法宝锁定开关.AutoSize = true;
		this.洗炼_法宝锁定开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_法宝锁定开关.Location = new System.Drawing.Point(8, 90);
		this.洗炼_法宝锁定开关.Name = "洗炼_法宝锁定开关";
		this.洗炼_法宝锁定开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_法宝锁定开关.TabIndex = 169;
		this.洗炼_法宝锁定开关.Text = "属性锁定开关";
		this.洗炼_法宝锁定开关.UseVisualStyleBackColor = true;
		this.洗炼_法宝开关.AutoSize = true;
		this.洗炼_法宝开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_法宝开关.Location = new System.Drawing.Point(8, 9);
		this.洗炼_法宝开关.Name = "洗炼_法宝开关";
		this.洗炼_法宝开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_法宝开关.TabIndex = 168;
		this.洗炼_法宝开关.Text = "法宝洗炼开关";
		this.洗炼_法宝开关.UseVisualStyleBackColor = true;
		this.tabPage3.Controls.Add(this.label13);
		this.tabPage3.Controls.Add(this.洗炼_梭子描述文字);
		this.tabPage3.Controls.Add(this.textBox25);
		this.tabPage3.Controls.Add(this.洗炼_梭子描述开关);
		this.tabPage3.Controls.Add(this.洗炼_梭子数值洗炼类型);
		this.tabPage3.Controls.Add(this.洗炼_梭子数值洗炼消耗数值);
		this.tabPage3.Controls.Add(this.textBox26);
		this.tabPage3.Controls.Add(this.洗炼_梭子数值洗炼开关);
		this.tabPage3.Controls.Add(this.洗炼_梭子道具洗炼消耗材料数量);
		this.tabPage3.Controls.Add(this.洗炼_梭子道具洗炼材料);
		this.tabPage3.Controls.Add(this.textBox28);
		this.tabPage3.Controls.Add(this.洗炼_梭子道具洗炼开关);
		this.tabPage3.Controls.Add(this.洗炼_梭子出最高属性次数);
		this.tabPage3.Controls.Add(this.textBox29);
		this.tabPage3.Controls.Add(this.洗炼_梭子出最大条数次数);
		this.tabPage3.Controls.Add(this.textBox30);
		this.tabPage3.Controls.Add(this.洗炼_梭子最高条数);
		this.tabPage3.Controls.Add(this.label14);
		this.tabPage3.Controls.Add(this.洗炼_梭子最低条数);
		this.tabPage3.Controls.Add(this.textBox31);
		this.tabPage3.Controls.Add(this.洗炼_梭子最大重复条数);
		this.tabPage3.Controls.Add(this.textBox32);
		this.tabPage3.Controls.Add(this.洗炼_梭子属性重复开关);
		this.tabPage3.Controls.Add(this.洗炼_梭子名字);
		this.tabPage3.Controls.Add(this.textBox34);
		this.tabPage3.Controls.Add(this.洗炼_梭子锁定消耗数值);
		this.tabPage3.Controls.Add(this.洗炼_梭子锁定消耗类型);
		this.tabPage3.Controls.Add(this.textBox35);
		this.tabPage3.Controls.Add(this.洗炼_梭子锁定开关);
		this.tabPage3.Controls.Add(this.洗炼_梭子开关);
		this.tabPage3.Location = new System.Drawing.Point(4, 26);
		this.tabPage3.Name = "tabPage3";
		this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage3.Size = new System.Drawing.Size(335, 507);
		this.tabPage3.TabIndex = 2;
		this.tabPage3.Text = "梭子";
		this.tabPage3.UseVisualStyleBackColor = true;
		this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label13.ForeColor = System.Drawing.Color.Red;
		this.label13.Location = new System.Drawing.Point(8, 57);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(319, 30);
		this.label13.TabIndex = 197;
		this.label13.Text = "装备名字如有有多个，请使用\"，\"连接(注意：、是中文格式)";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_梭子描述文字.Location = new System.Drawing.Point(133, 475);
		this.洗炼_梭子描述文字.Name = "洗炼_梭子描述文字";
		this.洗炼_梭子描述文字.Size = new System.Drawing.Size(194, 23);
		this.洗炼_梭子描述文字.TabIndex = 196;
		this.textBox25.Location = new System.Drawing.Point(26, 475);
		this.textBox25.Name = "textBox25";
		this.textBox25.ReadOnly = true;
		this.textBox25.Size = new System.Drawing.Size(105, 23);
		this.textBox25.TabIndex = 195;
		this.textBox25.Text = "额外附加描述文字";
		this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_梭子描述开关.AutoSize = true;
		this.洗炼_梭子描述开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_梭子描述开关.Location = new System.Drawing.Point(8, 451);
		this.洗炼_梭子描述开关.Name = "洗炼_梭子描述开关";
		this.洗炼_梭子描述开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_梭子描述开关.TabIndex = 194;
		this.洗炼_梭子描述开关.Text = "附加描述开关";
		this.洗炼_梭子描述开关.UseVisualStyleBackColor = true;
		this.洗炼_梭子数值洗炼类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_梭子数值洗炼类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_梭子数值洗炼类型.FormattingEnabled = true;
		this.洗炼_梭子数值洗炼类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "金钱", "灵气值" });
		this.洗炼_梭子数值洗炼类型.Location = new System.Drawing.Point(133, 411);
		this.洗炼_梭子数值洗炼类型.Name = "洗炼_梭子数值洗炼类型";
		this.洗炼_梭子数值洗炼类型.Size = new System.Drawing.Size(100, 25);
		this.洗炼_梭子数值洗炼类型.TabIndex = 193;
		this.洗炼_梭子数值洗炼消耗数值.Location = new System.Drawing.Point(234, 412);
		this.洗炼_梭子数值洗炼消耗数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_梭子数值洗炼消耗数值.Name = "洗炼_梭子数值洗炼消耗数值";
		this.洗炼_梭子数值洗炼消耗数值.Size = new System.Drawing.Size(93, 23);
		this.洗炼_梭子数值洗炼消耗数值.TabIndex = 192;
		this.textBox26.Location = new System.Drawing.Point(26, 412);
		this.textBox26.Name = "textBox26";
		this.textBox26.ReadOnly = true;
		this.textBox26.Size = new System.Drawing.Size(105, 23);
		this.textBox26.TabIndex = 191;
		this.textBox26.Text = "洗炼消耗数值类型";
		this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_梭子数值洗炼开关.AutoSize = true;
		this.洗炼_梭子数值洗炼开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_梭子数值洗炼开关.Location = new System.Drawing.Point(8, 388);
		this.洗炼_梭子数值洗炼开关.Name = "洗炼_梭子数值洗炼开关";
		this.洗炼_梭子数值洗炼开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_梭子数值洗炼开关.TabIndex = 190;
		this.洗炼_梭子数值洗炼开关.Text = "数值洗炼开关";
		this.洗炼_梭子数值洗炼开关.UseVisualStyleBackColor = true;
		this.洗炼_梭子道具洗炼消耗材料数量.Location = new System.Drawing.Point(234, 349);
		this.洗炼_梭子道具洗炼消耗材料数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_梭子道具洗炼消耗材料数量.Name = "洗炼_梭子道具洗炼消耗材料数量";
		this.洗炼_梭子道具洗炼消耗材料数量.Size = new System.Drawing.Size(93, 23);
		this.洗炼_梭子道具洗炼消耗材料数量.TabIndex = 189;
		this.洗炼_梭子道具洗炼材料.Location = new System.Drawing.Point(133, 349);
		this.洗炼_梭子道具洗炼材料.Name = "洗炼_梭子道具洗炼材料";
		this.洗炼_梭子道具洗炼材料.Size = new System.Drawing.Size(100, 23);
		this.洗炼_梭子道具洗炼材料.TabIndex = 188;
		this.textBox28.Location = new System.Drawing.Point(26, 349);
		this.textBox28.Name = "textBox28";
		this.textBox28.ReadOnly = true;
		this.textBox28.Size = new System.Drawing.Size(105, 23);
		this.textBox28.TabIndex = 187;
		this.textBox28.Text = "洗炼消耗道具名字";
		this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_梭子道具洗炼开关.AutoSize = true;
		this.洗炼_梭子道具洗炼开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_梭子道具洗炼开关.Location = new System.Drawing.Point(8, 325);
		this.洗炼_梭子道具洗炼开关.Name = "洗炼_梭子道具洗炼开关";
		this.洗炼_梭子道具洗炼开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_梭子道具洗炼开关.TabIndex = 186;
		this.洗炼_梭子道具洗炼开关.Text = "道具洗炼开关";
		this.洗炼_梭子道具洗炼开关.UseVisualStyleBackColor = true;
		this.洗炼_梭子出最高属性次数.Location = new System.Drawing.Point(222, 284);
		this.洗炼_梭子出最高属性次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_梭子出最高属性次数.Name = "洗炼_梭子出最高属性次数";
		this.洗炼_梭子出最高属性次数.Size = new System.Drawing.Size(105, 23);
		this.洗炼_梭子出最高属性次数.TabIndex = 185;
		this.textBox29.Location = new System.Drawing.Point(8, 283);
		this.textBox29.Name = "textBox29";
		this.textBox29.ReadOnly = true;
		this.textBox29.Size = new System.Drawing.Size(212, 23);
		this.textBox29.TabIndex = 184;
		this.textBox29.Text = "刷新次数有几率出现最大属性数值≥";
		this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_梭子出最大条数次数.Location = new System.Drawing.Point(222, 255);
		this.洗炼_梭子出最大条数次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_梭子出最大条数次数.Name = "洗炼_梭子出最大条数次数";
		this.洗炼_梭子出最大条数次数.Size = new System.Drawing.Size(105, 23);
		this.洗炼_梭子出最大条数次数.TabIndex = 183;
		this.textBox30.Location = new System.Drawing.Point(8, 254);
		this.textBox30.Name = "textBox30";
		this.textBox30.ReadOnly = true;
		this.textBox30.Size = new System.Drawing.Size(212, 23);
		this.textBox30.TabIndex = 182;
		this.textBox30.Text = "刷新次数有几率出现最大属性条数≥";
		this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_梭子最高条数.Location = new System.Drawing.Point(225, 214);
		this.洗炼_梭子最高条数.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.洗炼_梭子最高条数.Name = "洗炼_梭子最高条数";
		this.洗炼_梭子最高条数.Size = new System.Drawing.Size(60, 23);
		this.洗炼_梭子最高条数.TabIndex = 181;
		this.label14.BackColor = System.Drawing.Color.Transparent;
		this.label14.Location = new System.Drawing.Point(193, 213);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(32, 23);
		this.label14.TabIndex = 180;
		this.label14.Text = "—";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_梭子最低条数.Location = new System.Drawing.Point(133, 213);
		this.洗炼_梭子最低条数.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.洗炼_梭子最低条数.Name = "洗炼_梭子最低条数";
		this.洗炼_梭子最低条数.Size = new System.Drawing.Size(60, 23);
		this.洗炼_梭子最低条数.TabIndex = 179;
		this.textBox31.Location = new System.Drawing.Point(26, 213);
		this.textBox31.Name = "textBox31";
		this.textBox31.ReadOnly = true;
		this.textBox31.Size = new System.Drawing.Size(105, 23);
		this.textBox31.TabIndex = 178;
		this.textBox31.Text = "洗炼属性条数区间";
		this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_梭子最大重复条数.Location = new System.Drawing.Point(133, 185);
		this.洗炼_梭子最大重复条数.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
		this.洗炼_梭子最大重复条数.Name = "洗炼_梭子最大重复条数";
		this.洗炼_梭子最大重复条数.Size = new System.Drawing.Size(152, 23);
		this.洗炼_梭子最大重复条数.TabIndex = 177;
		this.洗炼_梭子最大重复条数.Visible = false;
		this.textBox32.Location = new System.Drawing.Point(26, 184);
		this.textBox32.Name = "textBox32";
		this.textBox32.ReadOnly = true;
		this.textBox32.Size = new System.Drawing.Size(105, 23);
		this.textBox32.TabIndex = 176;
		this.textBox32.Text = "重复属性条数≤2";
		this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox32.Visible = false;
		this.洗炼_梭子属性重复开关.AutoSize = true;
		this.洗炼_梭子属性重复开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_梭子属性重复开关.Location = new System.Drawing.Point(8, 155);
		this.洗炼_梭子属性重复开关.Name = "洗炼_梭子属性重复开关";
		this.洗炼_梭子属性重复开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_梭子属性重复开关.TabIndex = 175;
		this.洗炼_梭子属性重复开关.Text = "属性重复开关";
		this.洗炼_梭子属性重复开关.UseVisualStyleBackColor = true;
		this.洗炼_梭子属性重复开关.Visible = false;
		this.洗炼_梭子名字.Location = new System.Drawing.Point(69, 33);
		this.洗炼_梭子名字.Name = "洗炼_梭子名字";
		this.洗炼_梭子名字.Size = new System.Drawing.Size(258, 23);
		this.洗炼_梭子名字.TabIndex = 174;
		this.textBox34.Location = new System.Drawing.Point(8, 33);
		this.textBox34.Name = "textBox34";
		this.textBox34.ReadOnly = true;
		this.textBox34.Size = new System.Drawing.Size(60, 23);
		this.textBox34.TabIndex = 173;
		this.textBox34.Text = "可洗梭子";
		this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_梭子锁定消耗数值.Location = new System.Drawing.Point(208, 114);
		this.洗炼_梭子锁定消耗数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_梭子锁定消耗数值.Name = "洗炼_梭子锁定消耗数值";
		this.洗炼_梭子锁定消耗数值.Size = new System.Drawing.Size(119, 23);
		this.洗炼_梭子锁定消耗数值.TabIndex = 172;
		this.洗炼_梭子锁定消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_梭子锁定消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_梭子锁定消耗类型.FormattingEnabled = true;
		this.洗炼_梭子锁定消耗类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "金钱", "灵气值" });
		this.洗炼_梭子锁定消耗类型.Location = new System.Drawing.Point(127, 113);
		this.洗炼_梭子锁定消耗类型.Name = "洗炼_梭子锁定消耗类型";
		this.洗炼_梭子锁定消耗类型.Size = new System.Drawing.Size(80, 25);
		this.洗炼_梭子锁定消耗类型.TabIndex = 171;
		this.textBox35.Location = new System.Drawing.Point(26, 114);
		this.textBox35.Name = "textBox35";
		this.textBox35.ReadOnly = true;
		this.textBox35.Size = new System.Drawing.Size(100, 23);
		this.textBox35.TabIndex = 170;
		this.textBox35.Text = "锁定/解锁消耗";
		this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_梭子锁定开关.AutoSize = true;
		this.洗炼_梭子锁定开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_梭子锁定开关.Location = new System.Drawing.Point(8, 90);
		this.洗炼_梭子锁定开关.Name = "洗炼_梭子锁定开关";
		this.洗炼_梭子锁定开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_梭子锁定开关.TabIndex = 169;
		this.洗炼_梭子锁定开关.Text = "属性锁定开关";
		this.洗炼_梭子锁定开关.UseVisualStyleBackColor = true;
		this.洗炼_梭子开关.AutoSize = true;
		this.洗炼_梭子开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_梭子开关.Location = new System.Drawing.Point(8, 9);
		this.洗炼_梭子开关.Name = "洗炼_梭子开关";
		this.洗炼_梭子开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_梭子开关.TabIndex = 168;
		this.洗炼_梭子开关.Text = "梭子洗炼开关";
		this.洗炼_梭子开关.UseVisualStyleBackColor = true;
		this.tabPage4.Controls.Add(this.label15);
		this.tabPage4.Controls.Add(this.洗炼_铭牌描述文字);
		this.tabPage4.Controls.Add(this.textBox37);
		this.tabPage4.Controls.Add(this.洗炼_铭牌描述开关);
		this.tabPage4.Controls.Add(this.洗炼_铭牌数值洗炼类型);
		this.tabPage4.Controls.Add(this.洗炼_铭牌数值洗炼消耗数值);
		this.tabPage4.Controls.Add(this.textBox38);
		this.tabPage4.Controls.Add(this.洗炼_铭牌数值洗炼开关);
		this.tabPage4.Controls.Add(this.洗炼_铭牌道具洗炼消耗材料数量);
		this.tabPage4.Controls.Add(this.洗炼_铭牌道具洗炼材料);
		this.tabPage4.Controls.Add(this.textBox40);
		this.tabPage4.Controls.Add(this.洗炼_铭牌道具洗炼开关);
		this.tabPage4.Controls.Add(this.洗炼_铭牌出最高属性次数);
		this.tabPage4.Controls.Add(this.textBox41);
		this.tabPage4.Controls.Add(this.洗炼_铭牌出最大条数次数);
		this.tabPage4.Controls.Add(this.textBox42);
		this.tabPage4.Controls.Add(this.洗炼_铭牌最高条数);
		this.tabPage4.Controls.Add(this.label16);
		this.tabPage4.Controls.Add(this.洗炼_铭牌最低条数);
		this.tabPage4.Controls.Add(this.textBox43);
		this.tabPage4.Controls.Add(this.洗炼_铭牌最大重复条数);
		this.tabPage4.Controls.Add(this.textBox44);
		this.tabPage4.Controls.Add(this.洗炼_铭牌属性重复开关);
		this.tabPage4.Controls.Add(this.洗炼_铭牌名字);
		this.tabPage4.Controls.Add(this.textBox46);
		this.tabPage4.Controls.Add(this.洗炼_铭牌锁定消耗数值);
		this.tabPage4.Controls.Add(this.洗炼_铭牌锁定消耗类型);
		this.tabPage4.Controls.Add(this.textBox47);
		this.tabPage4.Controls.Add(this.洗炼_铭牌锁定开关);
		this.tabPage4.Controls.Add(this.洗炼_铭牌开关);
		this.tabPage4.Location = new System.Drawing.Point(4, 26);
		this.tabPage4.Name = "tabPage4";
		this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage4.Size = new System.Drawing.Size(335, 507);
		this.tabPage4.TabIndex = 3;
		this.tabPage4.Text = "铭牌";
		this.tabPage4.UseVisualStyleBackColor = true;
		this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label15.ForeColor = System.Drawing.Color.Red;
		this.label15.Location = new System.Drawing.Point(8, 57);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(319, 30);
		this.label15.TabIndex = 197;
		this.label15.Text = "装备名字如有有多个，请使用\"，\"连接(注意：、是中文格式)";
		this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_铭牌描述文字.Location = new System.Drawing.Point(133, 475);
		this.洗炼_铭牌描述文字.Name = "洗炼_铭牌描述文字";
		this.洗炼_铭牌描述文字.Size = new System.Drawing.Size(194, 23);
		this.洗炼_铭牌描述文字.TabIndex = 196;
		this.textBox37.Location = new System.Drawing.Point(26, 475);
		this.textBox37.Name = "textBox37";
		this.textBox37.ReadOnly = true;
		this.textBox37.Size = new System.Drawing.Size(105, 23);
		this.textBox37.TabIndex = 195;
		this.textBox37.Text = "额外附加描述文字";
		this.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_铭牌描述开关.AutoSize = true;
		this.洗炼_铭牌描述开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_铭牌描述开关.Location = new System.Drawing.Point(8, 451);
		this.洗炼_铭牌描述开关.Name = "洗炼_铭牌描述开关";
		this.洗炼_铭牌描述开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_铭牌描述开关.TabIndex = 194;
		this.洗炼_铭牌描述开关.Text = "附加描述开关";
		this.洗炼_铭牌描述开关.UseVisualStyleBackColor = true;
		this.洗炼_铭牌数值洗炼类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_铭牌数值洗炼类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_铭牌数值洗炼类型.FormattingEnabled = true;
		this.洗炼_铭牌数值洗炼类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "金钱", "灵气值" });
		this.洗炼_铭牌数值洗炼类型.Location = new System.Drawing.Point(133, 411);
		this.洗炼_铭牌数值洗炼类型.Name = "洗炼_铭牌数值洗炼类型";
		this.洗炼_铭牌数值洗炼类型.Size = new System.Drawing.Size(100, 25);
		this.洗炼_铭牌数值洗炼类型.TabIndex = 193;
		this.洗炼_铭牌数值洗炼消耗数值.Location = new System.Drawing.Point(234, 412);
		this.洗炼_铭牌数值洗炼消耗数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_铭牌数值洗炼消耗数值.Name = "洗炼_铭牌数值洗炼消耗数值";
		this.洗炼_铭牌数值洗炼消耗数值.Size = new System.Drawing.Size(93, 23);
		this.洗炼_铭牌数值洗炼消耗数值.TabIndex = 192;
		this.textBox38.Location = new System.Drawing.Point(26, 412);
		this.textBox38.Name = "textBox38";
		this.textBox38.ReadOnly = true;
		this.textBox38.Size = new System.Drawing.Size(105, 23);
		this.textBox38.TabIndex = 191;
		this.textBox38.Text = "洗炼消耗数值类型";
		this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_铭牌数值洗炼开关.AutoSize = true;
		this.洗炼_铭牌数值洗炼开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_铭牌数值洗炼开关.Location = new System.Drawing.Point(8, 388);
		this.洗炼_铭牌数值洗炼开关.Name = "洗炼_铭牌数值洗炼开关";
		this.洗炼_铭牌数值洗炼开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_铭牌数值洗炼开关.TabIndex = 190;
		this.洗炼_铭牌数值洗炼开关.Text = "数值洗炼开关";
		this.洗炼_铭牌数值洗炼开关.UseVisualStyleBackColor = true;
		this.洗炼_铭牌道具洗炼消耗材料数量.Location = new System.Drawing.Point(234, 349);
		this.洗炼_铭牌道具洗炼消耗材料数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_铭牌道具洗炼消耗材料数量.Name = "洗炼_铭牌道具洗炼消耗材料数量";
		this.洗炼_铭牌道具洗炼消耗材料数量.Size = new System.Drawing.Size(93, 23);
		this.洗炼_铭牌道具洗炼消耗材料数量.TabIndex = 189;
		this.洗炼_铭牌道具洗炼材料.Location = new System.Drawing.Point(133, 349);
		this.洗炼_铭牌道具洗炼材料.Name = "洗炼_铭牌道具洗炼材料";
		this.洗炼_铭牌道具洗炼材料.Size = new System.Drawing.Size(100, 23);
		this.洗炼_铭牌道具洗炼材料.TabIndex = 188;
		this.textBox40.Location = new System.Drawing.Point(26, 349);
		this.textBox40.Name = "textBox40";
		this.textBox40.ReadOnly = true;
		this.textBox40.Size = new System.Drawing.Size(105, 23);
		this.textBox40.TabIndex = 187;
		this.textBox40.Text = "洗炼消耗道具名字";
		this.textBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_铭牌道具洗炼开关.AutoSize = true;
		this.洗炼_铭牌道具洗炼开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_铭牌道具洗炼开关.Location = new System.Drawing.Point(8, 325);
		this.洗炼_铭牌道具洗炼开关.Name = "洗炼_铭牌道具洗炼开关";
		this.洗炼_铭牌道具洗炼开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_铭牌道具洗炼开关.TabIndex = 186;
		this.洗炼_铭牌道具洗炼开关.Text = "道具洗炼开关";
		this.洗炼_铭牌道具洗炼开关.UseVisualStyleBackColor = true;
		this.洗炼_铭牌出最高属性次数.Location = new System.Drawing.Point(222, 284);
		this.洗炼_铭牌出最高属性次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_铭牌出最高属性次数.Name = "洗炼_铭牌出最高属性次数";
		this.洗炼_铭牌出最高属性次数.Size = new System.Drawing.Size(105, 23);
		this.洗炼_铭牌出最高属性次数.TabIndex = 185;
		this.textBox41.Location = new System.Drawing.Point(8, 283);
		this.textBox41.Name = "textBox41";
		this.textBox41.ReadOnly = true;
		this.textBox41.Size = new System.Drawing.Size(212, 23);
		this.textBox41.TabIndex = 184;
		this.textBox41.Text = "刷新次数有几率出现最大属性数值≥";
		this.textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_铭牌出最大条数次数.Location = new System.Drawing.Point(222, 255);
		this.洗炼_铭牌出最大条数次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_铭牌出最大条数次数.Name = "洗炼_铭牌出最大条数次数";
		this.洗炼_铭牌出最大条数次数.Size = new System.Drawing.Size(105, 23);
		this.洗炼_铭牌出最大条数次数.TabIndex = 183;
		this.textBox42.Location = new System.Drawing.Point(8, 254);
		this.textBox42.Name = "textBox42";
		this.textBox42.ReadOnly = true;
		this.textBox42.Size = new System.Drawing.Size(212, 23);
		this.textBox42.TabIndex = 182;
		this.textBox42.Text = "刷新次数有几率出现最大属性条数≥";
		this.textBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_铭牌最高条数.Location = new System.Drawing.Point(225, 214);
		this.洗炼_铭牌最高条数.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.洗炼_铭牌最高条数.Name = "洗炼_铭牌最高条数";
		this.洗炼_铭牌最高条数.Size = new System.Drawing.Size(60, 23);
		this.洗炼_铭牌最高条数.TabIndex = 181;
		this.label16.BackColor = System.Drawing.Color.Transparent;
		this.label16.Location = new System.Drawing.Point(193, 213);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(32, 23);
		this.label16.TabIndex = 180;
		this.label16.Text = "—";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_铭牌最低条数.Location = new System.Drawing.Point(133, 213);
		this.洗炼_铭牌最低条数.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.洗炼_铭牌最低条数.Name = "洗炼_铭牌最低条数";
		this.洗炼_铭牌最低条数.Size = new System.Drawing.Size(60, 23);
		this.洗炼_铭牌最低条数.TabIndex = 179;
		this.textBox43.Location = new System.Drawing.Point(26, 213);
		this.textBox43.Name = "textBox43";
		this.textBox43.ReadOnly = true;
		this.textBox43.Size = new System.Drawing.Size(105, 23);
		this.textBox43.TabIndex = 178;
		this.textBox43.Text = "洗炼属性条数区间";
		this.textBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_铭牌最大重复条数.Location = new System.Drawing.Point(133, 185);
		this.洗炼_铭牌最大重复条数.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
		this.洗炼_铭牌最大重复条数.Name = "洗炼_铭牌最大重复条数";
		this.洗炼_铭牌最大重复条数.Size = new System.Drawing.Size(152, 23);
		this.洗炼_铭牌最大重复条数.TabIndex = 177;
		this.洗炼_铭牌最大重复条数.Visible = false;
		this.textBox44.Location = new System.Drawing.Point(26, 184);
		this.textBox44.Name = "textBox44";
		this.textBox44.ReadOnly = true;
		this.textBox44.Size = new System.Drawing.Size(105, 23);
		this.textBox44.TabIndex = 176;
		this.textBox44.Text = "重复属性条数≤2";
		this.textBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox44.Visible = false;
		this.洗炼_铭牌属性重复开关.AutoSize = true;
		this.洗炼_铭牌属性重复开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_铭牌属性重复开关.Location = new System.Drawing.Point(8, 155);
		this.洗炼_铭牌属性重复开关.Name = "洗炼_铭牌属性重复开关";
		this.洗炼_铭牌属性重复开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_铭牌属性重复开关.TabIndex = 175;
		this.洗炼_铭牌属性重复开关.Text = "属性重复开关";
		this.洗炼_铭牌属性重复开关.UseVisualStyleBackColor = true;
		this.洗炼_铭牌属性重复开关.Visible = false;
		this.洗炼_铭牌名字.Location = new System.Drawing.Point(69, 33);
		this.洗炼_铭牌名字.Name = "洗炼_铭牌名字";
		this.洗炼_铭牌名字.Size = new System.Drawing.Size(258, 23);
		this.洗炼_铭牌名字.TabIndex = 174;
		this.textBox46.Location = new System.Drawing.Point(8, 33);
		this.textBox46.Name = "textBox46";
		this.textBox46.ReadOnly = true;
		this.textBox46.Size = new System.Drawing.Size(60, 23);
		this.textBox46.TabIndex = 173;
		this.textBox46.Text = "可洗铭牌";
		this.textBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_铭牌锁定消耗数值.Location = new System.Drawing.Point(208, 114);
		this.洗炼_铭牌锁定消耗数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_铭牌锁定消耗数值.Name = "洗炼_铭牌锁定消耗数值";
		this.洗炼_铭牌锁定消耗数值.Size = new System.Drawing.Size(119, 23);
		this.洗炼_铭牌锁定消耗数值.TabIndex = 172;
		this.洗炼_铭牌锁定消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_铭牌锁定消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_铭牌锁定消耗类型.FormattingEnabled = true;
		this.洗炼_铭牌锁定消耗类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "金钱", "灵气值" });
		this.洗炼_铭牌锁定消耗类型.Location = new System.Drawing.Point(127, 113);
		this.洗炼_铭牌锁定消耗类型.Name = "洗炼_铭牌锁定消耗类型";
		this.洗炼_铭牌锁定消耗类型.Size = new System.Drawing.Size(80, 25);
		this.洗炼_铭牌锁定消耗类型.TabIndex = 171;
		this.textBox47.Location = new System.Drawing.Point(26, 114);
		this.textBox47.Name = "textBox47";
		this.textBox47.ReadOnly = true;
		this.textBox47.Size = new System.Drawing.Size(100, 23);
		this.textBox47.TabIndex = 170;
		this.textBox47.Text = "锁定/解锁消耗";
		this.textBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_铭牌锁定开关.AutoSize = true;
		this.洗炼_铭牌锁定开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_铭牌锁定开关.Location = new System.Drawing.Point(8, 90);
		this.洗炼_铭牌锁定开关.Name = "洗炼_铭牌锁定开关";
		this.洗炼_铭牌锁定开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_铭牌锁定开关.TabIndex = 169;
		this.洗炼_铭牌锁定开关.Text = "属性锁定开关";
		this.洗炼_铭牌锁定开关.UseVisualStyleBackColor = true;
		this.洗炼_铭牌开关.AutoSize = true;
		this.洗炼_铭牌开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_铭牌开关.Location = new System.Drawing.Point(8, 9);
		this.洗炼_铭牌开关.Name = "洗炼_铭牌开关";
		this.洗炼_铭牌开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_铭牌开关.TabIndex = 168;
		this.洗炼_铭牌开关.Text = "铭牌洗炼开关";
		this.洗炼_铭牌开关.UseVisualStyleBackColor = true;
		this.tabPage5.Controls.Add(this.label17);
		this.tabPage5.Controls.Add(this.洗炼_仙器描述文字);
		this.tabPage5.Controls.Add(this.textBox49);
		this.tabPage5.Controls.Add(this.洗炼_仙器描述开关);
		this.tabPage5.Controls.Add(this.洗炼_仙器数值洗炼类型);
		this.tabPage5.Controls.Add(this.洗炼_仙器数值洗炼消耗数值);
		this.tabPage5.Controls.Add(this.textBox50);
		this.tabPage5.Controls.Add(this.洗炼_仙器数值洗炼开关);
		this.tabPage5.Controls.Add(this.洗炼_仙器道具洗炼消耗材料数量);
		this.tabPage5.Controls.Add(this.洗炼_仙器道具洗炼材料);
		this.tabPage5.Controls.Add(this.textBox52);
		this.tabPage5.Controls.Add(this.洗炼_仙器道具洗炼开关);
		this.tabPage5.Controls.Add(this.洗炼_仙器出最高属性次数);
		this.tabPage5.Controls.Add(this.textBox53);
		this.tabPage5.Controls.Add(this.洗炼_仙器出最大条数次数);
		this.tabPage5.Controls.Add(this.textBox54);
		this.tabPage5.Controls.Add(this.洗炼_仙器最高条数);
		this.tabPage5.Controls.Add(this.label18);
		this.tabPage5.Controls.Add(this.洗炼_仙器最低条数);
		this.tabPage5.Controls.Add(this.textBox55);
		this.tabPage5.Controls.Add(this.洗炼_仙器最大重复条数);
		this.tabPage5.Controls.Add(this.textBox56);
		this.tabPage5.Controls.Add(this.洗炼_仙器属性重复开关);
		this.tabPage5.Controls.Add(this.洗炼_仙器名字);
		this.tabPage5.Controls.Add(this.textBox58);
		this.tabPage5.Controls.Add(this.洗炼_仙器锁定消耗数值);
		this.tabPage5.Controls.Add(this.洗炼_仙器锁定消耗类型);
		this.tabPage5.Controls.Add(this.textBox59);
		this.tabPage5.Controls.Add(this.洗炼_仙器锁定开关);
		this.tabPage5.Controls.Add(this.洗炼_仙器开关);
		this.tabPage5.Location = new System.Drawing.Point(4, 26);
		this.tabPage5.Name = "tabPage5";
		this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage5.Size = new System.Drawing.Size(335, 507);
		this.tabPage5.TabIndex = 4;
		this.tabPage5.Text = "仙器";
		this.tabPage5.UseVisualStyleBackColor = true;
		this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label17.ForeColor = System.Drawing.Color.Red;
		this.label17.Location = new System.Drawing.Point(8, 57);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(319, 30);
		this.label17.TabIndex = 197;
		this.label17.Text = "装备名字如有有多个，请使用\"，\"连接(注意：、是中文格式)";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_仙器描述文字.Location = new System.Drawing.Point(133, 475);
		this.洗炼_仙器描述文字.Name = "洗炼_仙器描述文字";
		this.洗炼_仙器描述文字.Size = new System.Drawing.Size(194, 23);
		this.洗炼_仙器描述文字.TabIndex = 196;
		this.textBox49.Location = new System.Drawing.Point(26, 475);
		this.textBox49.Name = "textBox49";
		this.textBox49.ReadOnly = true;
		this.textBox49.Size = new System.Drawing.Size(105, 23);
		this.textBox49.TabIndex = 195;
		this.textBox49.Text = "额外附加描述文字";
		this.textBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_仙器描述开关.AutoSize = true;
		this.洗炼_仙器描述开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_仙器描述开关.Location = new System.Drawing.Point(8, 451);
		this.洗炼_仙器描述开关.Name = "洗炼_仙器描述开关";
		this.洗炼_仙器描述开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_仙器描述开关.TabIndex = 194;
		this.洗炼_仙器描述开关.Text = "附加描述开关";
		this.洗炼_仙器描述开关.UseVisualStyleBackColor = true;
		this.洗炼_仙器数值洗炼类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_仙器数值洗炼类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_仙器数值洗炼类型.FormattingEnabled = true;
		this.洗炼_仙器数值洗炼类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "金钱", "灵气值" });
		this.洗炼_仙器数值洗炼类型.Location = new System.Drawing.Point(133, 411);
		this.洗炼_仙器数值洗炼类型.Name = "洗炼_仙器数值洗炼类型";
		this.洗炼_仙器数值洗炼类型.Size = new System.Drawing.Size(100, 25);
		this.洗炼_仙器数值洗炼类型.TabIndex = 193;
		this.洗炼_仙器数值洗炼消耗数值.Location = new System.Drawing.Point(234, 412);
		this.洗炼_仙器数值洗炼消耗数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_仙器数值洗炼消耗数值.Name = "洗炼_仙器数值洗炼消耗数值";
		this.洗炼_仙器数值洗炼消耗数值.Size = new System.Drawing.Size(93, 23);
		this.洗炼_仙器数值洗炼消耗数值.TabIndex = 192;
		this.textBox50.Location = new System.Drawing.Point(26, 412);
		this.textBox50.Name = "textBox50";
		this.textBox50.ReadOnly = true;
		this.textBox50.Size = new System.Drawing.Size(105, 23);
		this.textBox50.TabIndex = 191;
		this.textBox50.Text = "洗炼消耗数值类型";
		this.textBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_仙器数值洗炼开关.AutoSize = true;
		this.洗炼_仙器数值洗炼开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_仙器数值洗炼开关.Location = new System.Drawing.Point(8, 388);
		this.洗炼_仙器数值洗炼开关.Name = "洗炼_仙器数值洗炼开关";
		this.洗炼_仙器数值洗炼开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_仙器数值洗炼开关.TabIndex = 190;
		this.洗炼_仙器数值洗炼开关.Text = "数值洗炼开关";
		this.洗炼_仙器数值洗炼开关.UseVisualStyleBackColor = true;
		this.洗炼_仙器道具洗炼消耗材料数量.Location = new System.Drawing.Point(234, 349);
		this.洗炼_仙器道具洗炼消耗材料数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_仙器道具洗炼消耗材料数量.Name = "洗炼_仙器道具洗炼消耗材料数量";
		this.洗炼_仙器道具洗炼消耗材料数量.Size = new System.Drawing.Size(93, 23);
		this.洗炼_仙器道具洗炼消耗材料数量.TabIndex = 189;
		this.洗炼_仙器道具洗炼材料.Location = new System.Drawing.Point(133, 349);
		this.洗炼_仙器道具洗炼材料.Name = "洗炼_仙器道具洗炼材料";
		this.洗炼_仙器道具洗炼材料.Size = new System.Drawing.Size(100, 23);
		this.洗炼_仙器道具洗炼材料.TabIndex = 188;
		this.textBox52.Location = new System.Drawing.Point(26, 349);
		this.textBox52.Name = "textBox52";
		this.textBox52.ReadOnly = true;
		this.textBox52.Size = new System.Drawing.Size(105, 23);
		this.textBox52.TabIndex = 187;
		this.textBox52.Text = "洗炼消耗道具名字";
		this.textBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_仙器道具洗炼开关.AutoSize = true;
		this.洗炼_仙器道具洗炼开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_仙器道具洗炼开关.Location = new System.Drawing.Point(8, 325);
		this.洗炼_仙器道具洗炼开关.Name = "洗炼_仙器道具洗炼开关";
		this.洗炼_仙器道具洗炼开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_仙器道具洗炼开关.TabIndex = 186;
		this.洗炼_仙器道具洗炼开关.Text = "道具洗炼开关";
		this.洗炼_仙器道具洗炼开关.UseVisualStyleBackColor = true;
		this.洗炼_仙器出最高属性次数.Location = new System.Drawing.Point(222, 284);
		this.洗炼_仙器出最高属性次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_仙器出最高属性次数.Name = "洗炼_仙器出最高属性次数";
		this.洗炼_仙器出最高属性次数.Size = new System.Drawing.Size(105, 23);
		this.洗炼_仙器出最高属性次数.TabIndex = 185;
		this.textBox53.Location = new System.Drawing.Point(8, 283);
		this.textBox53.Name = "textBox53";
		this.textBox53.ReadOnly = true;
		this.textBox53.Size = new System.Drawing.Size(212, 23);
		this.textBox53.TabIndex = 184;
		this.textBox53.Text = "刷新次数有几率出现最大属性数值≥";
		this.textBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_仙器出最大条数次数.Location = new System.Drawing.Point(222, 255);
		this.洗炼_仙器出最大条数次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_仙器出最大条数次数.Name = "洗炼_仙器出最大条数次数";
		this.洗炼_仙器出最大条数次数.Size = new System.Drawing.Size(105, 23);
		this.洗炼_仙器出最大条数次数.TabIndex = 183;
		this.textBox54.Location = new System.Drawing.Point(8, 254);
		this.textBox54.Name = "textBox54";
		this.textBox54.ReadOnly = true;
		this.textBox54.Size = new System.Drawing.Size(212, 23);
		this.textBox54.TabIndex = 182;
		this.textBox54.Text = "刷新次数有几率出现最大属性条数≥";
		this.textBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_仙器最高条数.Location = new System.Drawing.Point(225, 214);
		this.洗炼_仙器最高条数.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.洗炼_仙器最高条数.Name = "洗炼_仙器最高条数";
		this.洗炼_仙器最高条数.Size = new System.Drawing.Size(60, 23);
		this.洗炼_仙器最高条数.TabIndex = 181;
		this.label18.BackColor = System.Drawing.Color.Transparent;
		this.label18.Location = new System.Drawing.Point(193, 213);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(32, 23);
		this.label18.TabIndex = 180;
		this.label18.Text = "—";
		this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_仙器最低条数.Location = new System.Drawing.Point(133, 213);
		this.洗炼_仙器最低条数.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.洗炼_仙器最低条数.Name = "洗炼_仙器最低条数";
		this.洗炼_仙器最低条数.Size = new System.Drawing.Size(60, 23);
		this.洗炼_仙器最低条数.TabIndex = 179;
		this.textBox55.Location = new System.Drawing.Point(26, 213);
		this.textBox55.Name = "textBox55";
		this.textBox55.ReadOnly = true;
		this.textBox55.Size = new System.Drawing.Size(105, 23);
		this.textBox55.TabIndex = 178;
		this.textBox55.Text = "洗炼属性条数区间";
		this.textBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_仙器最大重复条数.Location = new System.Drawing.Point(133, 185);
		this.洗炼_仙器最大重复条数.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
		this.洗炼_仙器最大重复条数.Name = "洗炼_仙器最大重复条数";
		this.洗炼_仙器最大重复条数.Size = new System.Drawing.Size(152, 23);
		this.洗炼_仙器最大重复条数.TabIndex = 177;
		this.洗炼_仙器最大重复条数.Visible = false;
		this.textBox56.Location = new System.Drawing.Point(26, 184);
		this.textBox56.Name = "textBox56";
		this.textBox56.ReadOnly = true;
		this.textBox56.Size = new System.Drawing.Size(105, 23);
		this.textBox56.TabIndex = 176;
		this.textBox56.Text = "重复属性条数≤2";
		this.textBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox56.Visible = false;
		this.洗炼_仙器属性重复开关.AutoSize = true;
		this.洗炼_仙器属性重复开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_仙器属性重复开关.Location = new System.Drawing.Point(8, 155);
		this.洗炼_仙器属性重复开关.Name = "洗炼_仙器属性重复开关";
		this.洗炼_仙器属性重复开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_仙器属性重复开关.TabIndex = 175;
		this.洗炼_仙器属性重复开关.Text = "属性重复开关";
		this.洗炼_仙器属性重复开关.UseVisualStyleBackColor = true;
		this.洗炼_仙器属性重复开关.Visible = false;
		this.洗炼_仙器名字.Location = new System.Drawing.Point(69, 33);
		this.洗炼_仙器名字.Name = "洗炼_仙器名字";
		this.洗炼_仙器名字.Size = new System.Drawing.Size(258, 23);
		this.洗炼_仙器名字.TabIndex = 174;
		this.textBox58.Location = new System.Drawing.Point(8, 33);
		this.textBox58.Name = "textBox58";
		this.textBox58.ReadOnly = true;
		this.textBox58.Size = new System.Drawing.Size(60, 23);
		this.textBox58.TabIndex = 173;
		this.textBox58.Text = "可洗仙器";
		this.textBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_仙器锁定消耗数值.Location = new System.Drawing.Point(208, 114);
		this.洗炼_仙器锁定消耗数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_仙器锁定消耗数值.Name = "洗炼_仙器锁定消耗数值";
		this.洗炼_仙器锁定消耗数值.Size = new System.Drawing.Size(119, 23);
		this.洗炼_仙器锁定消耗数值.TabIndex = 172;
		this.洗炼_仙器锁定消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_仙器锁定消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_仙器锁定消耗类型.FormattingEnabled = true;
		this.洗炼_仙器锁定消耗类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "金钱", "灵气值" });
		this.洗炼_仙器锁定消耗类型.Location = new System.Drawing.Point(127, 113);
		this.洗炼_仙器锁定消耗类型.Name = "洗炼_仙器锁定消耗类型";
		this.洗炼_仙器锁定消耗类型.Size = new System.Drawing.Size(80, 25);
		this.洗炼_仙器锁定消耗类型.TabIndex = 171;
		this.textBox59.Location = new System.Drawing.Point(26, 114);
		this.textBox59.Name = "textBox59";
		this.textBox59.ReadOnly = true;
		this.textBox59.Size = new System.Drawing.Size(100, 23);
		this.textBox59.TabIndex = 170;
		this.textBox59.Text = "锁定/解锁消耗";
		this.textBox59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_仙器锁定开关.AutoSize = true;
		this.洗炼_仙器锁定开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_仙器锁定开关.Location = new System.Drawing.Point(8, 90);
		this.洗炼_仙器锁定开关.Name = "洗炼_仙器锁定开关";
		this.洗炼_仙器锁定开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_仙器锁定开关.TabIndex = 169;
		this.洗炼_仙器锁定开关.Text = "属性锁定开关";
		this.洗炼_仙器锁定开关.UseVisualStyleBackColor = true;
		this.洗炼_仙器开关.AutoSize = true;
		this.洗炼_仙器开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_仙器开关.Location = new System.Drawing.Point(8, 9);
		this.洗炼_仙器开关.Name = "洗炼_仙器开关";
		this.洗炼_仙器开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_仙器开关.TabIndex = 168;
		this.洗炼_仙器开关.Text = "仙器洗炼开关";
		this.洗炼_仙器开关.UseVisualStyleBackColor = true;
		this.tabPage6.Controls.Add(this.label19);
		this.tabPage6.Controls.Add(this.洗炼_灵幡描述文字);
		this.tabPage6.Controls.Add(this.textBox61);
		this.tabPage6.Controls.Add(this.洗炼_灵幡描述开关);
		this.tabPage6.Controls.Add(this.洗炼_灵幡数值洗炼类型);
		this.tabPage6.Controls.Add(this.洗炼_灵幡数值洗炼消耗数值);
		this.tabPage6.Controls.Add(this.textBox62);
		this.tabPage6.Controls.Add(this.洗炼_灵幡数值洗炼开关);
		this.tabPage6.Controls.Add(this.洗炼_灵幡道具洗炼消耗材料数量);
		this.tabPage6.Controls.Add(this.洗炼_灵幡道具洗炼材料);
		this.tabPage6.Controls.Add(this.textBox64);
		this.tabPage6.Controls.Add(this.洗炼_灵幡道具洗炼开关);
		this.tabPage6.Controls.Add(this.洗炼_灵幡出最高属性次数);
		this.tabPage6.Controls.Add(this.textBox65);
		this.tabPage6.Controls.Add(this.洗炼_灵幡出最大条数次数);
		this.tabPage6.Controls.Add(this.textBox66);
		this.tabPage6.Controls.Add(this.洗炼_灵幡最高条数);
		this.tabPage6.Controls.Add(this.label20);
		this.tabPage6.Controls.Add(this.洗炼_灵幡最低条数);
		this.tabPage6.Controls.Add(this.textBox67);
		this.tabPage6.Controls.Add(this.洗炼_灵幡最大重复条数);
		this.tabPage6.Controls.Add(this.textBox68);
		this.tabPage6.Controls.Add(this.洗炼_灵幡属性重复开关);
		this.tabPage6.Controls.Add(this.洗炼_灵幡名字);
		this.tabPage6.Controls.Add(this.textBox70);
		this.tabPage6.Controls.Add(this.洗炼_灵幡锁定消耗数值);
		this.tabPage6.Controls.Add(this.洗炼_灵幡锁定消耗类型);
		this.tabPage6.Controls.Add(this.textBox71);
		this.tabPage6.Controls.Add(this.洗炼_灵幡锁定开关);
		this.tabPage6.Controls.Add(this.洗炼_灵幡开关);
		this.tabPage6.Location = new System.Drawing.Point(4, 26);
		this.tabPage6.Name = "tabPage6";
		this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage6.Size = new System.Drawing.Size(335, 507);
		this.tabPage6.TabIndex = 5;
		this.tabPage6.Text = "引灵幡";
		this.tabPage6.UseVisualStyleBackColor = true;
		this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label19.ForeColor = System.Drawing.Color.Red;
		this.label19.Location = new System.Drawing.Point(8, 57);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(319, 30);
		this.label19.TabIndex = 197;
		this.label19.Text = "装备名字如有有多个，请使用\"，\"连接(注意：、是中文格式)";
		this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_灵幡描述文字.Location = new System.Drawing.Point(133, 475);
		this.洗炼_灵幡描述文字.Name = "洗炼_灵幡描述文字";
		this.洗炼_灵幡描述文字.Size = new System.Drawing.Size(194, 23);
		this.洗炼_灵幡描述文字.TabIndex = 196;
		this.textBox61.Location = new System.Drawing.Point(26, 475);
		this.textBox61.Name = "textBox61";
		this.textBox61.ReadOnly = true;
		this.textBox61.Size = new System.Drawing.Size(105, 23);
		this.textBox61.TabIndex = 195;
		this.textBox61.Text = "额外附加描述文字";
		this.textBox61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_灵幡描述开关.AutoSize = true;
		this.洗炼_灵幡描述开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_灵幡描述开关.Location = new System.Drawing.Point(8, 451);
		this.洗炼_灵幡描述开关.Name = "洗炼_灵幡描述开关";
		this.洗炼_灵幡描述开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_灵幡描述开关.TabIndex = 194;
		this.洗炼_灵幡描述开关.Text = "附加描述开关";
		this.洗炼_灵幡描述开关.UseVisualStyleBackColor = true;
		this.洗炼_灵幡数值洗炼类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_灵幡数值洗炼类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_灵幡数值洗炼类型.FormattingEnabled = true;
		this.洗炼_灵幡数值洗炼类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "金钱", "灵气值" });
		this.洗炼_灵幡数值洗炼类型.Location = new System.Drawing.Point(133, 411);
		this.洗炼_灵幡数值洗炼类型.Name = "洗炼_灵幡数值洗炼类型";
		this.洗炼_灵幡数值洗炼类型.Size = new System.Drawing.Size(100, 25);
		this.洗炼_灵幡数值洗炼类型.TabIndex = 193;
		this.洗炼_灵幡数值洗炼消耗数值.Location = new System.Drawing.Point(234, 412);
		this.洗炼_灵幡数值洗炼消耗数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_灵幡数值洗炼消耗数值.Name = "洗炼_灵幡数值洗炼消耗数值";
		this.洗炼_灵幡数值洗炼消耗数值.Size = new System.Drawing.Size(93, 23);
		this.洗炼_灵幡数值洗炼消耗数值.TabIndex = 192;
		this.textBox62.Location = new System.Drawing.Point(26, 412);
		this.textBox62.Name = "textBox62";
		this.textBox62.ReadOnly = true;
		this.textBox62.Size = new System.Drawing.Size(105, 23);
		this.textBox62.TabIndex = 191;
		this.textBox62.Text = "洗炼消耗数值类型";
		this.textBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_灵幡数值洗炼开关.AutoSize = true;
		this.洗炼_灵幡数值洗炼开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_灵幡数值洗炼开关.Location = new System.Drawing.Point(8, 388);
		this.洗炼_灵幡数值洗炼开关.Name = "洗炼_灵幡数值洗炼开关";
		this.洗炼_灵幡数值洗炼开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_灵幡数值洗炼开关.TabIndex = 190;
		this.洗炼_灵幡数值洗炼开关.Text = "数值洗炼开关";
		this.洗炼_灵幡数值洗炼开关.UseVisualStyleBackColor = true;
		this.洗炼_灵幡道具洗炼消耗材料数量.Location = new System.Drawing.Point(234, 349);
		this.洗炼_灵幡道具洗炼消耗材料数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_灵幡道具洗炼消耗材料数量.Name = "洗炼_灵幡道具洗炼消耗材料数量";
		this.洗炼_灵幡道具洗炼消耗材料数量.Size = new System.Drawing.Size(93, 23);
		this.洗炼_灵幡道具洗炼消耗材料数量.TabIndex = 189;
		this.洗炼_灵幡道具洗炼材料.Location = new System.Drawing.Point(133, 349);
		this.洗炼_灵幡道具洗炼材料.Name = "洗炼_灵幡道具洗炼材料";
		this.洗炼_灵幡道具洗炼材料.Size = new System.Drawing.Size(100, 23);
		this.洗炼_灵幡道具洗炼材料.TabIndex = 188;
		this.textBox64.Location = new System.Drawing.Point(26, 349);
		this.textBox64.Name = "textBox64";
		this.textBox64.ReadOnly = true;
		this.textBox64.Size = new System.Drawing.Size(105, 23);
		this.textBox64.TabIndex = 187;
		this.textBox64.Text = "洗炼消耗道具名字";
		this.textBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_灵幡道具洗炼开关.AutoSize = true;
		this.洗炼_灵幡道具洗炼开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_灵幡道具洗炼开关.Location = new System.Drawing.Point(8, 325);
		this.洗炼_灵幡道具洗炼开关.Name = "洗炼_灵幡道具洗炼开关";
		this.洗炼_灵幡道具洗炼开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_灵幡道具洗炼开关.TabIndex = 186;
		this.洗炼_灵幡道具洗炼开关.Text = "道具洗炼开关";
		this.洗炼_灵幡道具洗炼开关.UseVisualStyleBackColor = true;
		this.洗炼_灵幡出最高属性次数.Location = new System.Drawing.Point(222, 284);
		this.洗炼_灵幡出最高属性次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_灵幡出最高属性次数.Name = "洗炼_灵幡出最高属性次数";
		this.洗炼_灵幡出最高属性次数.Size = new System.Drawing.Size(105, 23);
		this.洗炼_灵幡出最高属性次数.TabIndex = 185;
		this.textBox65.Location = new System.Drawing.Point(8, 283);
		this.textBox65.Name = "textBox65";
		this.textBox65.ReadOnly = true;
		this.textBox65.Size = new System.Drawing.Size(212, 23);
		this.textBox65.TabIndex = 184;
		this.textBox65.Text = "刷新次数有几率出现最大属性数值≥";
		this.textBox65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_灵幡出最大条数次数.Location = new System.Drawing.Point(222, 255);
		this.洗炼_灵幡出最大条数次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_灵幡出最大条数次数.Name = "洗炼_灵幡出最大条数次数";
		this.洗炼_灵幡出最大条数次数.Size = new System.Drawing.Size(105, 23);
		this.洗炼_灵幡出最大条数次数.TabIndex = 183;
		this.textBox66.Location = new System.Drawing.Point(8, 254);
		this.textBox66.Name = "textBox66";
		this.textBox66.ReadOnly = true;
		this.textBox66.Size = new System.Drawing.Size(212, 23);
		this.textBox66.TabIndex = 182;
		this.textBox66.Text = "刷新次数有几率出现最大属性条数≥";
		this.textBox66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_灵幡最高条数.Location = new System.Drawing.Point(225, 214);
		this.洗炼_灵幡最高条数.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.洗炼_灵幡最高条数.Name = "洗炼_灵幡最高条数";
		this.洗炼_灵幡最高条数.Size = new System.Drawing.Size(60, 23);
		this.洗炼_灵幡最高条数.TabIndex = 181;
		this.label20.BackColor = System.Drawing.Color.Transparent;
		this.label20.Location = new System.Drawing.Point(193, 213);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(32, 23);
		this.label20.TabIndex = 180;
		this.label20.Text = "—";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_灵幡最低条数.Location = new System.Drawing.Point(133, 213);
		this.洗炼_灵幡最低条数.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.洗炼_灵幡最低条数.Name = "洗炼_灵幡最低条数";
		this.洗炼_灵幡最低条数.Size = new System.Drawing.Size(60, 23);
		this.洗炼_灵幡最低条数.TabIndex = 179;
		this.textBox67.Location = new System.Drawing.Point(26, 213);
		this.textBox67.Name = "textBox67";
		this.textBox67.ReadOnly = true;
		this.textBox67.Size = new System.Drawing.Size(105, 23);
		this.textBox67.TabIndex = 178;
		this.textBox67.Text = "洗炼属性条数区间";
		this.textBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_灵幡最大重复条数.Location = new System.Drawing.Point(133, 185);
		this.洗炼_灵幡最大重复条数.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
		this.洗炼_灵幡最大重复条数.Name = "洗炼_灵幡最大重复条数";
		this.洗炼_灵幡最大重复条数.Size = new System.Drawing.Size(152, 23);
		this.洗炼_灵幡最大重复条数.TabIndex = 177;
		this.洗炼_灵幡最大重复条数.Visible = false;
		this.textBox68.Location = new System.Drawing.Point(26, 184);
		this.textBox68.Name = "textBox68";
		this.textBox68.ReadOnly = true;
		this.textBox68.Size = new System.Drawing.Size(105, 23);
		this.textBox68.TabIndex = 176;
		this.textBox68.Text = "重复属性条数≤2";
		this.textBox68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox68.Visible = false;
		this.洗炼_灵幡属性重复开关.AutoSize = true;
		this.洗炼_灵幡属性重复开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_灵幡属性重复开关.Location = new System.Drawing.Point(8, 155);
		this.洗炼_灵幡属性重复开关.Name = "洗炼_灵幡属性重复开关";
		this.洗炼_灵幡属性重复开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_灵幡属性重复开关.TabIndex = 175;
		this.洗炼_灵幡属性重复开关.Text = "属性重复开关";
		this.洗炼_灵幡属性重复开关.UseVisualStyleBackColor = true;
		this.洗炼_灵幡属性重复开关.Visible = false;
		this.洗炼_灵幡名字.Location = new System.Drawing.Point(69, 33);
		this.洗炼_灵幡名字.Name = "洗炼_灵幡名字";
		this.洗炼_灵幡名字.Size = new System.Drawing.Size(258, 23);
		this.洗炼_灵幡名字.TabIndex = 174;
		this.textBox70.Location = new System.Drawing.Point(8, 33);
		this.textBox70.Name = "textBox70";
		this.textBox70.ReadOnly = true;
		this.textBox70.Size = new System.Drawing.Size(60, 23);
		this.textBox70.TabIndex = 173;
		this.textBox70.Text = "可洗灵幡";
		this.textBox70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_灵幡锁定消耗数值.Location = new System.Drawing.Point(208, 114);
		this.洗炼_灵幡锁定消耗数值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_灵幡锁定消耗数值.Name = "洗炼_灵幡锁定消耗数值";
		this.洗炼_灵幡锁定消耗数值.Size = new System.Drawing.Size(119, 23);
		this.洗炼_灵幡锁定消耗数值.TabIndex = 172;
		this.洗炼_灵幡锁定消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_灵幡锁定消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_灵幡锁定消耗类型.FormattingEnabled = true;
		this.洗炼_灵幡锁定消耗类型.Items.AddRange(new object[4] { "金元宝", "银元宝", "金钱", "灵气值" });
		this.洗炼_灵幡锁定消耗类型.Location = new System.Drawing.Point(127, 113);
		this.洗炼_灵幡锁定消耗类型.Name = "洗炼_灵幡锁定消耗类型";
		this.洗炼_灵幡锁定消耗类型.Size = new System.Drawing.Size(80, 25);
		this.洗炼_灵幡锁定消耗类型.TabIndex = 171;
		this.textBox71.Location = new System.Drawing.Point(26, 114);
		this.textBox71.Name = "textBox71";
		this.textBox71.ReadOnly = true;
		this.textBox71.Size = new System.Drawing.Size(100, 23);
		this.textBox71.TabIndex = 170;
		this.textBox71.Text = "锁定/解锁消耗";
		this.textBox71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_灵幡锁定开关.AutoSize = true;
		this.洗炼_灵幡锁定开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_灵幡锁定开关.Location = new System.Drawing.Point(8, 90);
		this.洗炼_灵幡锁定开关.Name = "洗炼_灵幡锁定开关";
		this.洗炼_灵幡锁定开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_灵幡锁定开关.TabIndex = 169;
		this.洗炼_灵幡锁定开关.Text = "属性锁定开关";
		this.洗炼_灵幡锁定开关.UseVisualStyleBackColor = true;
		this.洗炼_灵幡开关.AutoSize = true;
		this.洗炼_灵幡开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_灵幡开关.Location = new System.Drawing.Point(8, 9);
		this.洗炼_灵幡开关.Name = "洗炼_灵幡开关";
		this.洗炼_灵幡开关.Size = new System.Drawing.Size(119, 23);
		this.洗炼_灵幡开关.TabIndex = 168;
		this.洗炼_灵幡开关.Text = "引灵幡洗炼开关";
		this.洗炼_灵幡开关.UseVisualStyleBackColor = true;
		this.洗炼_属性列表.AllowUserToAddRows = false;
		this.洗炼_属性列表.AllowUserToDeleteRows = false;
		this.洗炼_属性列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.洗炼_属性列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.洗炼_属性列表.BackgroundColor = System.Drawing.Color.White;
		this.洗炼_属性列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.洗炼_属性列表.Columns.AddRange(this.属性名字, this.几率, this.最小值, this.平均值, this.最大值);
		this.洗炼_属性列表.Location = new System.Drawing.Point(6, 77);
		this.洗炼_属性列表.MultiSelect = false;
		this.洗炼_属性列表.Name = "洗炼_属性列表";
		this.洗炼_属性列表.RowHeadersVisible = false;
		this.洗炼_属性列表.RowTemplate.Height = 25;
		this.洗炼_属性列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.洗炼_属性列表.Size = new System.Drawing.Size(455, 454);
		this.洗炼_属性列表.TabIndex = 169;
		this.属性名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.属性名字.Frozen = true;
		this.属性名字.HeaderText = "属性名字";
		this.属性名字.MinimumWidth = 100;
		this.属性名字.Name = "属性名字";
		this.属性名字.ReadOnly = true;
		this.几率.HeaderText = "几率";
		this.几率.MinimumWidth = 60;
		this.几率.Name = "几率";
		this.几率.Width = 60;
		this.最小值.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.最小值.HeaderText = "最小值";
		this.最小值.MinimumWidth = 90;
		this.最小值.Name = "最小值";
		this.最小值.Width = 90;
		this.平均值.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.平均值.HeaderText = "平均值";
		this.平均值.MinimumWidth = 90;
		this.平均值.Name = "平均值";
		this.平均值.Width = 90;
		this.最大值.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.最大值.HeaderText = "最大值";
		this.最大值.MinimumWidth = 90;
		this.最大值.Name = "最大值";
		this.最大值.Width = 90;
		this.洗炼_添加按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_添加按钮.Location = new System.Drawing.Point(380, 22);
		this.洗炼_添加按钮.Name = "洗炼_添加按钮";
		this.洗炼_添加按钮.Size = new System.Drawing.Size(81, 24);
		this.洗炼_添加按钮.TabIndex = 157;
		this.洗炼_添加按钮.Text = "添加属性";
		this.洗炼_添加按钮.UseVisualStyleBackColor = true;
		this.洗炼_添加按钮.Click += new System.EventHandler(洗炼_添加按钮_Click);
		this.label10.Location = new System.Drawing.Point(340, 51);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(20, 23);
		this.label10.TabIndex = 156;
		this.label10.Text = "大";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_添加最大.Location = new System.Drawing.Point(361, 51);
		this.洗炼_添加最大.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_添加最大.Name = "洗炼_添加最大";
		this.洗炼_添加最大.Size = new System.Drawing.Size(100, 23);
		this.洗炼_添加最大.TabIndex = 155;
		this.label6.Location = new System.Drawing.Point(213, 51);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(20, 23);
		this.label6.TabIndex = 154;
		this.label6.Text = "中";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_添加一般.Location = new System.Drawing.Point(234, 51);
		this.洗炼_添加一般.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_添加一般.Name = "洗炼_添加一般";
		this.洗炼_添加一般.Size = new System.Drawing.Size(100, 23);
		this.洗炼_添加一般.TabIndex = 153;
		this.label3.Location = new System.Drawing.Point(87, 51);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(20, 23);
		this.label3.TabIndex = 152;
		this.label3.Text = "小";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.洗炼_添加最小.Location = new System.Drawing.Point(108, 51);
		this.洗炼_添加最小.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.洗炼_添加最小.Name = "洗炼_添加最小";
		this.洗炼_添加最小.Size = new System.Drawing.Size(100, 23);
		this.洗炼_添加最小.TabIndex = 151;
		this.textBox12.Location = new System.Drawing.Point(6, 51);
		this.textBox12.Name = "textBox12";
		this.textBox12.ReadOnly = true;
		this.textBox12.Size = new System.Drawing.Size(80, 23);
		this.textBox12.TabIndex = 150;
		this.textBox12.Text = "设置数值区间";
		this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_添加几率.Location = new System.Drawing.Point(294, 22);
		this.洗炼_添加几率.Name = "洗炼_添加几率";
		this.洗炼_添加几率.Size = new System.Drawing.Size(80, 23);
		this.洗炼_添加几率.TabIndex = 149;
		this.textBox11.Location = new System.Drawing.Point(213, 22);
		this.textBox11.Name = "textBox11";
		this.textBox11.ReadOnly = true;
		this.textBox11.Size = new System.Drawing.Size(80, 23);
		this.textBox11.TabIndex = 148;
		this.textBox11.Text = "洗炼出现几率";
		this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.洗炼_添加属性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.洗炼_添加属性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.洗炼_添加属性.FormattingEnabled = true;
		this.洗炼_添加属性.Items.AddRange(new object[101]
		{
			"所有技能上升", "所有相性", "所有属性", "金相性", "木相性", "水相性", "火相性", "土相性", "体质", "灵力",
			"力量", "敏捷", "速度", "防御", "气血", "法力", "闪避", "准确", "连击率", "反击率",
			"物理必杀率", "法术必杀率", "反震率", "连击", "反击", "反震度", "金抗性", "木抗性", "水抗性", "火抗性",
			"土抗性", "抗中毒", "抗冰冻", "抗昏睡", "抗遗忘", "抗混乱", "抗镇魂", "抗化功", "抗水牢", "抗锁灵",
			"抗迷心", "所有抗性", "抗所有异常", "强力克金", "强力克木", "强力克水", "强力克火", "强力克土", "躲避攻击", "师门攻击技能消耗降低",
			"师门障碍技能消耗降低", "师门辅助技能消耗降低", "强力遗忘", "强力中毒", "强力冰冻", "强力昏睡", "强力混乱", "强力镇魂", "强力化功", "强力水牢",
			"强力锁灵", "强力迷心", "忽视目标抗金", "忽视目标抗木", "忽视目标抗水", "忽视目标抗火", "忽视目标抗土", "忽视目标抗遗忘", "忽视目标抗中毒", "忽视目标抗冰冻",
			"忽视目标抗昏睡", "忽视目标抗混乱", "忽视目标抗镇魂", "忽视目标抗化功", "忽视目标抗水牢", "忽视目标抗锁灵", "忽视目标抗迷心", "忽视所有抗性", "忽视所有抗异常", "解除遗忘状态",
			"解除中毒状态", "解除冰冻状态", "解除昏睡状态", "解除混乱状态", "解除镇魂状态", "解除化功状态", "解除水牢状态", "解除锁灵状态", "解除迷心状态", "忽视目标连击",
			"忽视目标物理必杀", "忽视躲避攻击", "破防率", "破防", "出战化形", "强金法伤害", "强木法伤害", "强水法伤害", "强火法伤害", "强土法伤害",
			"强物理伤害"
		});
		this.洗炼_添加属性.Location = new System.Drawing.Point(87, 21);
		this.洗炼_添加属性.Name = "洗炼_添加属性";
		this.洗炼_添加属性.Size = new System.Drawing.Size(120, 25);
		this.洗炼_添加属性.TabIndex = 120;
		this.textBox10.Location = new System.Drawing.Point(6, 22);
		this.textBox10.Name = "textBox10";
		this.textBox10.ReadOnly = true;
		this.textBox10.Size = new System.Drawing.Size(80, 23);
		this.textBox10.TabIndex = 119;
		this.textBox10.Text = "选择添加属性";
		this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.groupBox2.Controls.Add(this.洗炼_属性列表);
		this.groupBox2.Controls.Add(this.textBox10);
		this.groupBox2.Controls.Add(this.洗炼_添加按钮);
		this.groupBox2.Controls.Add(this.洗炼_添加属性);
		this.groupBox2.Controls.Add(this.label10);
		this.groupBox2.Controls.Add(this.textBox11);
		this.groupBox2.Controls.Add(this.洗炼_添加最大);
		this.groupBox2.Controls.Add(this.洗炼_添加几率);
		this.groupBox2.Controls.Add(this.label6);
		this.groupBox2.Controls.Add(this.textBox12);
		this.groupBox2.Controls.Add(this.洗炼_添加一般);
		this.groupBox2.Controls.Add(this.洗炼_添加最小);
		this.groupBox2.Controls.Add(this.label3);
		this.groupBox2.Location = new System.Drawing.Point(361, 102);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(470, 537);
		this.groupBox2.TabIndex = 167;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "可洗炼属性列表(所有装备共用)";
		this.label21.ForeColor = System.Drawing.Color.Red;
		this.label21.Location = new System.Drawing.Point(390, 1);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(441, 40);
		this.label21.TabIndex = 168;
		this.label21.Text = "开启道具洗炼时，该消耗道具必须写成空礼包，并且建议添加在超级道具中的禁止使用道具中防止玩家手误使用消耗掉了";
		this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.洗炼_背包开关.AutoSize = true;
		this.洗炼_背包开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.洗炼_背包开关.Location = new System.Drawing.Point(12, 73);
		this.洗炼_背包开关.Name = "洗炼_背包开关";
		this.洗炼_背包开关.Size = new System.Drawing.Size(106, 23);
		this.洗炼_背包开关.TabIndex = 108;
		this.洗炼_背包开关.Text = "背包按钮开关";
		this.洗炼_背包开关.UseVisualStyleBackColor = true;
		this.洗炼_自动停止比例.Location = new System.Drawing.Point(291, 13);
		this.洗炼_自动停止比例.Name = "洗炼_自动停止比例";
		this.洗炼_自动停止比例.Size = new System.Drawing.Size(60, 23);
		this.洗炼_自动停止比例.TabIndex = 170;
		this.textBox6.Location = new System.Drawing.Point(184, 13);
		this.textBox6.Name = "textBox6";
		this.textBox6.ReadOnly = true;
		this.textBox6.Size = new System.Drawing.Size(105, 23);
		this.textBox6.TabIndex = 169;
		this.textBox6.Text = "洗炼自动停止比例";
		this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label22.BackColor = System.Drawing.Color.Transparent;
		this.label22.Location = new System.Drawing.Point(353, 13);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(18, 23);
		this.label22.TabIndex = 171;
		this.label22.Text = "%";
		this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(843, 648);
		base.Controls.Add(this.label22);
		base.Controls.Add(this.洗炼_自动停止比例);
		base.Controls.Add(this.textBox6);
		base.Controls.Add(this.label21);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.tabControl1);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.洗炼_背包开关);
		base.Controls.Add(this.洗炼_开关);
		base.Controls.Add(this.洗炼_重载按钮);
		base.Controls.Add(this.洗炼_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "属性洗炼配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "属性洗炼配置窗口";
		base.Load += new System.EventHandler(属性洗炼配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_形象).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_坐标Y).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_坐标X).EndInit();
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装数值洗炼消耗数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装道具洗炼消耗材料数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装出最高属性次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装出最大条数次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装最高条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装最低条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装最大重复条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_时装锁定消耗数值).EndInit();
		this.tabPage2.ResumeLayout(false);
		this.tabPage2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝数值洗炼消耗数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝道具洗炼消耗材料数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝出最高属性次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝出最大条数次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝最高条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝最低条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝最大重复条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_法宝锁定消耗数值).EndInit();
		this.tabPage3.ResumeLayout(false);
		this.tabPage3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子数值洗炼消耗数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子道具洗炼消耗材料数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子出最高属性次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子出最大条数次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子最高条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子最低条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子最大重复条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_梭子锁定消耗数值).EndInit();
		this.tabPage4.ResumeLayout(false);
		this.tabPage4.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌数值洗炼消耗数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌道具洗炼消耗材料数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌出最高属性次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌出最大条数次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌最高条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌最低条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌最大重复条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_铭牌锁定消耗数值).EndInit();
		this.tabPage5.ResumeLayout(false);
		this.tabPage5.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器数值洗炼消耗数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器道具洗炼消耗材料数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器出最高属性次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器出最大条数次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器最高条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器最低条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器最大重复条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_仙器锁定消耗数值).EndInit();
		this.tabPage6.ResumeLayout(false);
		this.tabPage6.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡数值洗炼消耗数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡道具洗炼消耗材料数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡出最高属性次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡出最大条数次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡最高条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡最低条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡最大重复条数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_灵幡锁定消耗数值).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_属性列表).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_添加最大).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_添加一般).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_添加最小).EndInit();
		((System.ComponentModel.ISupportInitialize)this.洗炼_添加几率).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.洗炼_自动停止比例).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
