using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NetClientFrom;

public class 元神_境界列表配置窗口 : Form
{
	private static Size OpenSize = new Size(1000, 380);

	private static Point 渡劫额外要求配置块pos = new Point(330, 50);

	private static Point 增加突破几率道具配置块pos = new Point(330, 50);

	private static Point 破境成功属性加成配置块pos = new Point(258, 50);

	private static Point 全服首次破境奖励配置块pos = new Point(274, 43);

	private List<TextBox> 突破灵气值组;

	private List<TextBox> 境界突破丹药组;

	private List<TextBox> 突破几率组;

	private List<TextBox> 失败惩罚组;

	private List<CheckBox> 渡劫前置要求组;

	private List<CheckBox> 增加突破几率道具组;

	private List<CheckBox> 破境成功属性加成组;

	private List<CheckBox> 全服首次破境奖励组;

	private List<CheckBox> 破境横幅广播组;

	private ConcurrentDictionary<AllEnums.元神境界, 元神境界配置类> 境界列表 = new ConcurrentDictionary<AllEnums.元神境界, 元神境界配置类>();

	private static 元神_境界列表配置窗口 i;

	private IContainer components;

	private Label label4;

	private TextBox 突破灵气值1;

	private Label label5;

	private TextBox 境界突破丹药1;

	private Label label6;

	private TextBox 突破几率1;

	private TextBox 失败惩罚1;

	private Label label7;

	private Label label8;

	private CheckBox 渡劫前置要求1;

	private CheckBox 渡劫额外要求配置块_Is道行达标;

	private GroupBox 渡劫额外要求配置块;

	private Label label16;

	private TextBox 渡劫额外要求配置块_声望要求;

	private Label label17;

	private CheckBox 渡劫额外要求配置块_Is声望达标;

	private Label label15;

	private TextBox 渡劫额外要求配置块_道行要求;

	private Label label13;

	private Button 渡劫额外要求配置块确定;

	private Label label18;

	private TextBox 渡劫额外要求配置块_击杀BOSS要求;

	private CheckBox 渡劫额外要求配置块_Is击杀BOSS要求;

	private CheckBox 增加突破几率道具1;

	private Label label19;

	private GroupBox 增加突破几率道具配置块;

	private Button 增加突破几率道具配置块确定;

	private DataGridView 增加突破几率道具配置块_增加突破几率道具;

	private DataGridViewTextBoxColumn Add道具名字;

	private DataGridViewTextBoxColumn Add增加几率;

	private CheckBox 破境成功属性加成1;

	private Label label20;

	private CheckBox 全服首次破境奖励1;

	private Label label21;

	private CheckBox 破境横幅广播1;

	private Label label9;

	private GroupBox 破境成功属性加成配置块;

	private Button 破境成功属性加成配置块确定;

	private Label label223;

	private Label label222;

	private NumericUpDown 破境成功属性加成配置块_奖励数量;

	private ComboBox 破境成功属性加成配置块_奖励类型;

	private TextBox 破境成功属性加成配置块_奖励名字;

	private Label label25;

	private NumericUpDown 破境成功属性加成配置块_法力;

	private Label label22;

	private NumericUpDown 破境成功属性加成配置块_气血;

	private Label label23;

	private NumericUpDown 破境成功属性加成配置块_速度;

	private Label label24;

	private NumericUpDown 破境成功属性加成配置块_防御;

	private Label label12;

	private NumericUpDown 破境成功属性加成配置块_法术伤害;

	private Label label14;

	private NumericUpDown 破境成功属性加成配置块_物理伤害;

	private Label label11;

	private NumericUpDown 破境成功属性加成配置块_所有属性;

	private Label label10;

	private NumericUpDown 破境成功属性加成配置块_所有相性;

	private GroupBox 全服首次破境奖励配置块;

	private Label label27;

	private NumericUpDown 全服首次破境奖励配置块_技能等级;

	private Label label29;

	private NumericUpDown 全服首次破境奖励配置块_奖励声望;

	private Label label30;

	private NumericUpDown 全服首次破境奖励配置块_奖励道行;

	private Label label31;

	private NumericUpDown 全服首次破境奖励配置块_奖励游戏币;

	private Label label32;

	private NumericUpDown 全服首次破境奖励配置块_奖励银元宝;

	private Label label33;

	private NumericUpDown 全服首次破境奖励配置块_奖励金元宝;

	private Label label35;

	private TextBox 全服首次破境奖励配置块_奖励道具;

	private Button 全服首次破境奖励配置块确定;

	private Label label28;

	private TextBox 全服首次破境奖励配置块_奖励技能;

	private CheckBox 渡劫额外要求配置块_Is额外条件;

	private Button 渡劫额外要求配置块取消;

	private Button 增加突破几率道具配置块取消;

	private Button 破境成功属性加成配置块取消;

	private CheckBox 全服首次破境奖励配置块_Is全服突破境界奖励;

	private Button 全服首次破境奖励配置块取消;

	private Label label1;

	private Label label2;

	private Label label3;

	private CheckBox 破境横幅广播2;

	private CheckBox 全服首次破境奖励2;

	private CheckBox 破境成功属性加成2;

	private CheckBox 增加突破几率道具2;

	private CheckBox 渡劫前置要求2;

	private TextBox 失败惩罚2;

	private TextBox 突破几率2;

	private TextBox 境界突破丹药2;

	private TextBox 突破灵气值2;

	private Label label26;

	private CheckBox 破境横幅广播4;

	private CheckBox 全服首次破境奖励4;

	private CheckBox 破境成功属性加成4;

	private CheckBox 增加突破几率道具4;

	private CheckBox 渡劫前置要求4;

	private TextBox 失败惩罚4;

	private TextBox 突破几率4;

	private TextBox 境界突破丹药4;

	private TextBox 突破灵气值4;

	private Label label34;

	private CheckBox 破境横幅广播3;

	private CheckBox 全服首次破境奖励3;

	private CheckBox 破境成功属性加成3;

	private CheckBox 增加突破几率道具3;

	private CheckBox 渡劫前置要求3;

	private TextBox 失败惩罚3;

	private TextBox 突破几率3;

	private TextBox 境界突破丹药3;

	private TextBox 突破灵气值3;

	private Label label36;

	private CheckBox 破境横幅广播5;

	private CheckBox 全服首次破境奖励5;

	private CheckBox 破境成功属性加成5;

	private CheckBox 增加突破几率道具5;

	private CheckBox 渡劫前置要求5;

	private TextBox 失败惩罚5;

	private TextBox 突破几率5;

	private TextBox 境界突破丹药5;

	private TextBox 突破灵气值5;

	private Label label38;

	private CheckBox 破境横幅广播9;

	private CheckBox 全服首次破境奖励9;

	private CheckBox 破境成功属性加成9;

	private CheckBox 增加突破几率道具9;

	private CheckBox 渡劫前置要求9;

	private TextBox 失败惩罚9;

	private TextBox 突破几率9;

	private TextBox 境界突破丹药9;

	private TextBox 突破灵气值9;

	private Label label39;

	private CheckBox 破境横幅广播8;

	private CheckBox 全服首次破境奖励8;

	private CheckBox 破境成功属性加成8;

	private CheckBox 增加突破几率道具8;

	private CheckBox 渡劫前置要求8;

	private TextBox 失败惩罚8;

	private TextBox 突破几率8;

	private TextBox 境界突破丹药8;

	private TextBox 突破灵气值8;

	private Label label40;

	private CheckBox 破境横幅广播7;

	private CheckBox 全服首次破境奖励7;

	private CheckBox 破境成功属性加成7;

	private CheckBox 增加突破几率道具7;

	private CheckBox 渡劫前置要求7;

	private TextBox 失败惩罚7;

	private TextBox 突破几率7;

	private TextBox 境界突破丹药7;

	private TextBox 突破灵气值7;

	private Label label41;

	private CheckBox 破境横幅广播6;

	private CheckBox 全服首次破境奖励6;

	private CheckBox 破境成功属性加成6;

	private CheckBox 增加突破几率道具6;

	private CheckBox 渡劫前置要求6;

	private TextBox 失败惩罚6;

	private TextBox 突破几率6;

	private TextBox 境界突破丹药6;

	private TextBox 突破灵气值6;

	private Label label220;

	private Button 境界列表确定按钮;

	private CheckBox 渡劫额外要求配置块_破境BOSS只需击杀一次;

	public static 元神_境界列表配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 元神_境界列表配置窗口();
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

	public 元神_境界列表配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 初始化()
	{
		base.Size = OpenSize;
		渡劫额外要求配置块.Visible = false;
		渡劫前置要求组.EndCheckedChangedToAll(Is允许点击: true);
		增加突破几率道具配置块.Visible = false;
		增加突破几率道具组.EndCheckedChangedToAll(Is允许点击: true);
		破境成功属性加成配置块.Visible = false;
		破境成功属性加成组.EndCheckedChangedToAll(Is允许点击: true);
		全服首次破境奖励配置块.Visible = false;
		全服首次破境奖励组.EndCheckedChangedToAll(Is允许点击: true);
		境界配置复制组件();
	}

	private void 元神_境界列表配置窗口_Load(object sender, EventArgs e)
	{
		突破灵气值组 = new List<TextBox> { 突破灵气值1, 突破灵气值2, 突破灵气值3, 突破灵气值4, 突破灵气值5, 突破灵气值6, 突破灵气值7, 突破灵气值8, 突破灵气值9 };
		境界突破丹药组 = new List<TextBox> { 境界突破丹药1, 境界突破丹药2, 境界突破丹药3, 境界突破丹药4, 境界突破丹药5, 境界突破丹药6, 境界突破丹药7, 境界突破丹药8, 境界突破丹药9 };
		突破几率组 = new List<TextBox> { 突破几率1, 突破几率2, 突破几率3, 突破几率4, 突破几率5, 突破几率6, 突破几率7, 突破几率8, 突破几率9 };
		失败惩罚组 = new List<TextBox> { 失败惩罚1, 失败惩罚2, 失败惩罚3, 失败惩罚4, 失败惩罚5, 失败惩罚6, 失败惩罚7, 失败惩罚8, 失败惩罚9 };
		破境横幅广播组 = new List<CheckBox> { 破境横幅广播1, 破境横幅广播2, 破境横幅广播3, 破境横幅广播4, 破境横幅广播5, 破境横幅广播6, 破境横幅广播7, 破境横幅广播8, 破境横幅广播9 };
		渡劫前置要求组 = new List<CheckBox> { 渡劫前置要求1, 渡劫前置要求2, 渡劫前置要求3, 渡劫前置要求4, 渡劫前置要求5, 渡劫前置要求6, 渡劫前置要求7, 渡劫前置要求8, 渡劫前置要求9 };
		渡劫前置要求组.AddCheckedChangedToAll(渡劫前置要求_CheckedChanged);
		渡劫额外要求配置块取消.Click += 渡劫额外要求配置块取消_Click;
		增加突破几率道具组 = new List<CheckBox> { 增加突破几率道具1, 增加突破几率道具2, 增加突破几率道具3, 增加突破几率道具4, 增加突破几率道具5, 增加突破几率道具6, 增加突破几率道具7, 增加突破几率道具8, 增加突破几率道具9 };
		增加突破几率道具组.AddCheckedChangedToAll(增加突破几率道具_CheckedChanged);
		增加突破几率道具配置块取消.Click += 增加突破几率道具配置块取消_Click;
		破境成功属性加成组 = new List<CheckBox> { 破境成功属性加成1, 破境成功属性加成2, 破境成功属性加成3, 破境成功属性加成4, 破境成功属性加成5, 破境成功属性加成6, 破境成功属性加成7, 破境成功属性加成8, 破境成功属性加成9 };
		破境成功属性加成组.AddCheckedChangedToAll(破境成功属性加成_CheckedChanged);
		破境成功属性加成配置块取消.Click += 破境成功属性加成配置块取消_Click;
		全服首次破境奖励组 = new List<CheckBox> { 全服首次破境奖励1, 全服首次破境奖励2, 全服首次破境奖励3, 全服首次破境奖励4, 全服首次破境奖励5, 全服首次破境奖励6, 全服首次破境奖励7, 全服首次破境奖励8, 全服首次破境奖励9 };
		全服首次破境奖励组.AddCheckedChangedToAll(全服首次破境奖励_CheckedChanged);
		全服首次破境奖励配置块取消.Click += 全服首次破境奖励配置块取消_Click;
	}

	private void 渡劫前置要求_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)sender).Checked && Enum.TryParse<AllEnums.元神境界>(((CheckBox)sender).Tag.ToString(), out var result) && Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue(result, out 元神境界配置类 value))
		{
			渡劫前置要求组.EndCheckedChangedToAll(Is允许点击: false);
			增加突破几率道具组.EndCheckedChangedToAll(Is允许点击: false);
			破境成功属性加成组.EndCheckedChangedToAll(Is允许点击: false);
			全服首次破境奖励组.EndCheckedChangedToAll(Is允许点击: false);
			渡劫额外要求配置块.Visible = true;
			渡劫额外要求配置块.Text = $"【{value.当前境界}→{value.突破境界}】渡劫额外要求配置";
			渡劫额外要求配置块.Location = 渡劫额外要求配置块pos;
			渡劫额外要求配置块确定.Tag = (int)result;
			渡劫额外要求配置块_Is额外条件.Checked = value.突破特殊需求.Is额外条件;
			渡劫额外要求配置块_Is道行达标.Checked = value.突破特殊需求.Is道行达标;
			渡劫额外要求配置块_道行要求.Text = value.突破特殊需求.道行要求.ToString();
			渡劫额外要求配置块_Is声望达标.Checked = value.突破特殊需求.Is声望达标;
			渡劫额外要求配置块_声望要求.Text = value.突破特殊需求.声望要求.ToString();
			渡劫额外要求配置块_Is击杀BOSS要求.Checked = value.突破特殊需求.Is击杀BOSS要求;
			渡劫额外要求配置块_破境BOSS只需击杀一次.Checked = value.突破特殊需求.破境BOSS只需击杀一次;
			渡劫额外要求配置块_击杀BOSS要求.Text = value.突破特殊需求.击杀BOSS要求;
		}
	}

	private void 渡劫额外要求配置块取消_Click(object sender, EventArgs e)
	{
		渡劫额外要求配置块.Visible = false;
		渡劫前置要求组.EndCheckedChangedToAll(Is允许点击: true, Is取消所有点击: true);
		增加突破几率道具组.EndCheckedChangedToAll(Is允许点击: true);
		破境成功属性加成组.EndCheckedChangedToAll(Is允许点击: true);
		全服首次破境奖励组.EndCheckedChangedToAll(Is允许点击: true);
	}

	private void 渡劫额外要求配置块确定_Click(object sender, EventArgs e)
	{
		if (Enum.TryParse<AllEnums.元神境界>(((Button)sender).Tag.ToString(), out var result) && Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue(result, out 元神境界配置类 value))
		{
			value.突破特殊需求.Is额外条件 = 渡劫额外要求配置块_Is额外条件.Checked;
			value.突破特殊需求.Is道行达标 = 渡劫额外要求配置块_Is道行达标.Checked;
			value.突破特殊需求.道行要求 = Convert.ToInt32(渡劫额外要求配置块_道行要求.Text);
			value.突破特殊需求.Is声望达标 = 渡劫额外要求配置块_Is声望达标.Checked;
			value.突破特殊需求.声望要求 = Convert.ToInt32(渡劫额外要求配置块_声望要求.Text);
			value.突破特殊需求.破境BOSS只需击杀一次 = 渡劫额外要求配置块_破境BOSS只需击杀一次.Checked;
			value.突破特殊需求.击杀BOSS要求 = 渡劫额外要求配置块_击杀BOSS要求.Text;
			全服首次破境奖励配置块.Visible = false;
			MessageBox.Show($"[{result}]的渡劫额外要求配置更新完成。");
			渡劫额外要求配置块取消_Click(null, e);
		}
	}

	private void 增加突破几率道具_CheckedChanged(object sender, EventArgs e)
	{
		if (!((CheckBox)sender).Checked || !Enum.TryParse<AllEnums.元神境界>(((CheckBox)sender).Tag.ToString(), out var result) || !Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue(result, out 元神境界配置类 当前境界列表))
		{
			return;
		}
		渡劫前置要求组.EndCheckedChangedToAll(Is允许点击: false);
		增加突破几率道具组.EndCheckedChangedToAll(Is允许点击: false);
		破境成功属性加成组.EndCheckedChangedToAll(Is允许点击: false);
		全服首次破境奖励组.EndCheckedChangedToAll(Is允许点击: false);
		增加突破几率道具配置块.Visible = true;
		增加突破几率道具配置块.Location = 增加突破几率道具配置块pos;
		增加突破几率道具配置块确定.Tag = (int)result;
		增加突破几率道具配置块_增加突破几率道具.Invoke((MethodInvoker)delegate
		{
			增加突破几率道具配置块_增加突破几率道具.Rows.Clear();
			foreach (KeyValuePair<string, int> item in 当前境界列表.增加突破几率道具)
			{
				增加突破几率道具配置块_增加突破几率道具.Rows.Add(item.Key, item.Value);
			}
		});
	}

	private void 增加突破几率道具配置块取消_Click(object sender, EventArgs e)
	{
		增加突破几率道具配置块.Visible = false;
		渡劫前置要求组.EndCheckedChangedToAll(Is允许点击: true);
		增加突破几率道具组.EndCheckedChangedToAll(Is允许点击: true, Is取消所有点击: true);
		破境成功属性加成组.EndCheckedChangedToAll(Is允许点击: true);
		全服首次破境奖励组.EndCheckedChangedToAll(Is允许点击: true);
	}

	private void 增加突破几率道具配置块确定_Click(object sender, EventArgs e)
	{
		if (!Enum.TryParse<AllEnums.元神境界>(((Button)sender).Tag.ToString(), out var result) || !Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue(result, out 元神境界配置类 value))
		{
			return;
		}
		value.增加突破几率道具.Clear();
		for (int i = 0; i < 增加突破几率道具配置块_增加突破几率道具.Rows.Count; i++)
		{
			DataGridViewCellCollection cells = 增加突破几率道具配置块_增加突破几率道具.Rows[i].Cells;
			if (!string.IsNullOrWhiteSpace(Convert.ToString(cells[0].Value)))
			{
				value.增加突破几率道具.TryAdd(Convert.ToString(cells[0].Value), Convert.ToInt32(cells[1].Value));
			}
		}
		增加突破几率道具配置块.Visible = false;
		MessageBox.Show($"[{result}]的增加突破几率道具配置更新完成。");
		增加突破几率道具配置块取消_Click(null, e);
	}

	private void 破境成功属性加成_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)sender).Checked && Enum.TryParse<AllEnums.元神境界>(((CheckBox)sender).Tag.ToString(), out var result) && Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue(result, out 元神境界配置类 value))
		{
			渡劫前置要求组.EndCheckedChangedToAll(Is允许点击: false);
			增加突破几率道具组.EndCheckedChangedToAll(Is允许点击: false);
			破境成功属性加成组.EndCheckedChangedToAll(Is允许点击: false);
			全服首次破境奖励组.EndCheckedChangedToAll(Is允许点击: false);
			破境成功属性加成配置块.Visible = true;
			破境成功属性加成配置块.Location = 破境成功属性加成配置块pos;
			破境成功属性加成配置块确定.Tag = (int)result;
			破境成功属性加成配置块_奖励类型.Text = value.突破加成配置.奖励类型.ToString();
			破境成功属性加成配置块_奖励名字.Text = value.突破加成配置.奖励名字;
			破境成功属性加成配置块_奖励数量.Value = value.突破加成配置.奖励数量;
			破境成功属性加成配置块_所有相性.Value = value.突破加成配置.所有相性;
			破境成功属性加成配置块_所有属性.Value = value.突破加成配置.所有属性;
			破境成功属性加成配置块_物理伤害.Value = value.突破加成配置.物理伤害;
			破境成功属性加成配置块_法术伤害.Value = value.突破加成配置.法术伤害;
			破境成功属性加成配置块_防御.Value = value.突破加成配置.防御;
			破境成功属性加成配置块_速度.Value = value.突破加成配置.速度;
			破境成功属性加成配置块_气血.Value = value.突破加成配置.气血;
			破境成功属性加成配置块_法力.Value = value.突破加成配置.法力;
		}
	}

	private void 破境成功属性加成配置块取消_Click(object sender, EventArgs e)
	{
		破境成功属性加成配置块.Visible = false;
		渡劫前置要求组.EndCheckedChangedToAll(Is允许点击: true);
		增加突破几率道具组.EndCheckedChangedToAll(Is允许点击: true);
		破境成功属性加成组.EndCheckedChangedToAll(Is允许点击: true, Is取消所有点击: true);
		全服首次破境奖励组.EndCheckedChangedToAll(Is允许点击: true);
	}

	private void 破境成功属性加成配置块确定_Click(object sender, EventArgs e)
	{
		if (Enum.TryParse<AllEnums.元神境界>(((Button)sender).Tag.ToString(), out var result) && Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue(result, out 元神境界配置类 value))
		{
			Enum.TryParse<AllEnums.数值Type>(破境成功属性加成配置块_奖励类型.Text, out value.突破加成配置.奖励类型);
			value.突破加成配置.奖励名字 = 破境成功属性加成配置块_奖励名字.Text;
			value.突破加成配置.奖励数量 = Convert.ToInt32(破境成功属性加成配置块_奖励数量.Value);
			value.突破加成配置.所有相性 = Convert.ToInt32(破境成功属性加成配置块_所有相性.Value);
			value.突破加成配置.所有属性 = Convert.ToInt32(破境成功属性加成配置块_所有属性.Value);
			value.突破加成配置.物理伤害 = Convert.ToInt32(破境成功属性加成配置块_物理伤害.Value);
			value.突破加成配置.法术伤害 = Convert.ToInt32(破境成功属性加成配置块_法术伤害.Value);
			value.突破加成配置.防御 = Convert.ToInt32(破境成功属性加成配置块_防御.Value);
			value.突破加成配置.速度 = Convert.ToInt32(破境成功属性加成配置块_速度.Value);
			value.突破加成配置.气血 = Convert.ToInt32(破境成功属性加成配置块_气血.Value);
			value.突破加成配置.法力 = Convert.ToInt32(破境成功属性加成配置块_法力.Value);
			破境成功属性加成配置块.Visible = false;
			MessageBox.Show($"[{result}]的破境成功属性加成配置更新完成。");
			破境成功属性加成配置块取消_Click(null, e);
		}
	}

	private void 全服首次破境奖励_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)sender).Checked && Enum.TryParse<AllEnums.元神境界>(((CheckBox)sender).Tag.ToString(), out var result) && Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue(result, out 元神境界配置类 value))
		{
			渡劫前置要求组.EndCheckedChangedToAll(Is允许点击: false);
			增加突破几率道具组.EndCheckedChangedToAll(Is允许点击: false);
			破境成功属性加成组.EndCheckedChangedToAll(Is允许点击: false);
			全服首次破境奖励组.EndCheckedChangedToAll(Is允许点击: false);
			全服首次破境奖励配置块.Visible = true;
			全服首次破境奖励配置块.Location = 全服首次破境奖励配置块pos;
			全服首次破境奖励配置块确定.Tag = (int)result;
			全服首次破境奖励配置块_Is全服突破境界奖励.Checked = value.Is全服突破境界奖励;
			全服首次破境奖励配置块_奖励金元宝.Value = value.首次突破奖励.奖励金元宝;
			全服首次破境奖励配置块_奖励银元宝.Value = value.首次突破奖励.奖励银元宝;
			全服首次破境奖励配置块_奖励游戏币.Value = value.首次突破奖励.奖励游戏币;
			全服首次破境奖励配置块_奖励道行.Value = value.首次突破奖励.奖励道行;
			全服首次破境奖励配置块_奖励声望.Value = value.首次突破奖励.奖励声望;
			全服首次破境奖励配置块_奖励道具.Text = value.首次突破奖励.奖励道具;
			全服首次破境奖励配置块_奖励技能.Text = value.首次突破奖励.奖励技能;
			全服首次破境奖励配置块_技能等级.Value = value.首次突破奖励.技能等级;
		}
	}

	private void 全服首次破境奖励配置块取消_Click(object sender, EventArgs e)
	{
		全服首次破境奖励配置块.Visible = false;
		渡劫前置要求组.EndCheckedChangedToAll(Is允许点击: true);
		增加突破几率道具组.EndCheckedChangedToAll(Is允许点击: true);
		破境成功属性加成组.EndCheckedChangedToAll(Is允许点击: true);
		全服首次破境奖励组.EndCheckedChangedToAll(Is允许点击: true, Is取消所有点击: true);
	}

	private void 全服首次破境奖励配置块确定_Click(object sender, EventArgs e)
	{
		if (Enum.TryParse<AllEnums.元神境界>(((Button)sender).Tag.ToString(), out var result) && Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue(result, out 元神境界配置类 value))
		{
			value.Is全服突破境界奖励 = 全服首次破境奖励配置块_Is全服突破境界奖励.Checked;
			value.首次突破奖励.奖励金元宝 = Convert.ToInt32(全服首次破境奖励配置块_奖励金元宝.Value);
			value.首次突破奖励.奖励银元宝 = Convert.ToInt32(全服首次破境奖励配置块_奖励银元宝.Value);
			value.首次突破奖励.奖励游戏币 = Convert.ToInt32(全服首次破境奖励配置块_奖励游戏币.Value);
			value.首次突破奖励.奖励道行 = Convert.ToInt32(全服首次破境奖励配置块_奖励道行.Value);
			value.首次突破奖励.奖励声望 = Convert.ToInt32(全服首次破境奖励配置块_奖励声望.Value);
			value.首次突破奖励.奖励道具 = 全服首次破境奖励配置块_奖励道具.Text;
			value.首次突破奖励.奖励技能 = 全服首次破境奖励配置块_奖励技能.Text;
			value.首次突破奖励.技能等级 = Convert.ToInt32(全服首次破境奖励配置块_技能等级.Value);
			全服首次破境奖励配置块.Visible = false;
			MessageBox.Show($"[{result}]的全服首次破境奖励配置更新完成。");
			全服首次破境奖励配置块取消_Click(null, e);
		}
	}

	private void 境界配置复制组件()
	{
		for (int i = 0; i < 10; i++)
		{
			if (Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue((AllEnums.元神境界)(i + 1), out 元神境界配置类 value))
			{
				突破灵气值组[i].Text = value.突破灵气值.ToString();
				境界突破丹药组[i].Text = value.突破加成配置.突破道具;
				突破几率组[i].Text = value.突破加成配置.突破几率.ToString();
				失败惩罚组[i].Text = value.突破失败受伤程度.ToString();
				破境横幅广播组[i].Checked = value.Is突破横幅;
			}
		}
	}

	private void 境界列表确定按钮_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < 10; i++)
		{
			if (Singleton<全局变量类>.I.元神系统配置.境界列表.TryGetValue((AllEnums.元神境界)(i + 1), out 元神境界配置类 value))
			{
				value.突破灵气值 = Convert.ToInt32(突破灵气值组[i].Text);
				value.突破加成配置.突破道具 = 境界突破丹药组[i].Text;
				value.突破加成配置.突破几率 = Convert.ToInt32(突破几率组[i].Text);
				value.突破失败受伤程度 = Convert.ToInt32(失败惩罚组[i].Text);
				value.Is突破横幅 = Convert.ToBoolean(破境横幅广播组[i].Checked);
			}
		}
		Close();
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
		this.label4 = new System.Windows.Forms.Label();
		this.突破灵气值1 = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.境界突破丹药1 = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.突破几率1 = new System.Windows.Forms.TextBox();
		this.失败惩罚1 = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.渡劫前置要求1 = new System.Windows.Forms.CheckBox();
		this.渡劫额外要求配置块_Is道行达标 = new System.Windows.Forms.CheckBox();
		this.渡劫额外要求配置块 = new System.Windows.Forms.GroupBox();
		this.渡劫额外要求配置块_Is额外条件 = new System.Windows.Forms.CheckBox();
		this.渡劫额外要求配置块取消 = new System.Windows.Forms.Button();
		this.渡劫额外要求配置块确定 = new System.Windows.Forms.Button();
		this.label18 = new System.Windows.Forms.Label();
		this.渡劫额外要求配置块_击杀BOSS要求 = new System.Windows.Forms.TextBox();
		this.渡劫额外要求配置块_Is击杀BOSS要求 = new System.Windows.Forms.CheckBox();
		this.label16 = new System.Windows.Forms.Label();
		this.渡劫额外要求配置块_声望要求 = new System.Windows.Forms.TextBox();
		this.label17 = new System.Windows.Forms.Label();
		this.渡劫额外要求配置块_Is声望达标 = new System.Windows.Forms.CheckBox();
		this.label15 = new System.Windows.Forms.Label();
		this.渡劫额外要求配置块_道行要求 = new System.Windows.Forms.TextBox();
		this.label13 = new System.Windows.Forms.Label();
		this.增加突破几率道具1 = new System.Windows.Forms.CheckBox();
		this.label19 = new System.Windows.Forms.Label();
		this.增加突破几率道具配置块 = new System.Windows.Forms.GroupBox();
		this.增加突破几率道具配置块取消 = new System.Windows.Forms.Button();
		this.增加突破几率道具配置块_增加突破几率道具 = new System.Windows.Forms.DataGridView();
		this.Add道具名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Add增加几率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.增加突破几率道具配置块确定 = new System.Windows.Forms.Button();
		this.破境成功属性加成1 = new System.Windows.Forms.CheckBox();
		this.label20 = new System.Windows.Forms.Label();
		this.全服首次破境奖励1 = new System.Windows.Forms.CheckBox();
		this.label21 = new System.Windows.Forms.Label();
		this.破境横幅广播1 = new System.Windows.Forms.CheckBox();
		this.label9 = new System.Windows.Forms.Label();
		this.破境成功属性加成配置块 = new System.Windows.Forms.GroupBox();
		this.破境成功属性加成配置块取消 = new System.Windows.Forms.Button();
		this.label25 = new System.Windows.Forms.Label();
		this.破境成功属性加成配置块_法力 = new System.Windows.Forms.NumericUpDown();
		this.label22 = new System.Windows.Forms.Label();
		this.破境成功属性加成配置块_气血 = new System.Windows.Forms.NumericUpDown();
		this.label23 = new System.Windows.Forms.Label();
		this.破境成功属性加成配置块_速度 = new System.Windows.Forms.NumericUpDown();
		this.label24 = new System.Windows.Forms.Label();
		this.破境成功属性加成配置块_防御 = new System.Windows.Forms.NumericUpDown();
		this.label12 = new System.Windows.Forms.Label();
		this.破境成功属性加成配置块_法术伤害 = new System.Windows.Forms.NumericUpDown();
		this.label14 = new System.Windows.Forms.Label();
		this.破境成功属性加成配置块_物理伤害 = new System.Windows.Forms.NumericUpDown();
		this.label11 = new System.Windows.Forms.Label();
		this.破境成功属性加成配置块_所有属性 = new System.Windows.Forms.NumericUpDown();
		this.label10 = new System.Windows.Forms.Label();
		this.破境成功属性加成配置块_所有相性 = new System.Windows.Forms.NumericUpDown();
		this.label220 = new System.Windows.Forms.Label();
		this.label223 = new System.Windows.Forms.Label();
		this.label222 = new System.Windows.Forms.Label();
		this.破境成功属性加成配置块_奖励数量 = new System.Windows.Forms.NumericUpDown();
		this.破境成功属性加成配置块_奖励类型 = new System.Windows.Forms.ComboBox();
		this.破境成功属性加成配置块_奖励名字 = new System.Windows.Forms.TextBox();
		this.破境成功属性加成配置块确定 = new System.Windows.Forms.Button();
		this.全服首次破境奖励配置块 = new System.Windows.Forms.GroupBox();
		this.全服首次破境奖励配置块_Is全服突破境界奖励 = new System.Windows.Forms.CheckBox();
		this.全服首次破境奖励配置块取消 = new System.Windows.Forms.Button();
		this.label28 = new System.Windows.Forms.Label();
		this.全服首次破境奖励配置块_奖励技能 = new System.Windows.Forms.TextBox();
		this.label27 = new System.Windows.Forms.Label();
		this.全服首次破境奖励配置块_技能等级 = new System.Windows.Forms.NumericUpDown();
		this.label29 = new System.Windows.Forms.Label();
		this.全服首次破境奖励配置块_奖励声望 = new System.Windows.Forms.NumericUpDown();
		this.label30 = new System.Windows.Forms.Label();
		this.全服首次破境奖励配置块_奖励道行 = new System.Windows.Forms.NumericUpDown();
		this.label31 = new System.Windows.Forms.Label();
		this.全服首次破境奖励配置块_奖励游戏币 = new System.Windows.Forms.NumericUpDown();
		this.label32 = new System.Windows.Forms.Label();
		this.全服首次破境奖励配置块_奖励银元宝 = new System.Windows.Forms.NumericUpDown();
		this.label33 = new System.Windows.Forms.Label();
		this.全服首次破境奖励配置块_奖励金元宝 = new System.Windows.Forms.NumericUpDown();
		this.label35 = new System.Windows.Forms.Label();
		this.全服首次破境奖励配置块_奖励道具 = new System.Windows.Forms.TextBox();
		this.全服首次破境奖励配置块确定 = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.破境横幅广播2 = new System.Windows.Forms.CheckBox();
		this.全服首次破境奖励2 = new System.Windows.Forms.CheckBox();
		this.破境成功属性加成2 = new System.Windows.Forms.CheckBox();
		this.增加突破几率道具2 = new System.Windows.Forms.CheckBox();
		this.渡劫前置要求2 = new System.Windows.Forms.CheckBox();
		this.失败惩罚2 = new System.Windows.Forms.TextBox();
		this.突破几率2 = new System.Windows.Forms.TextBox();
		this.境界突破丹药2 = new System.Windows.Forms.TextBox();
		this.突破灵气值2 = new System.Windows.Forms.TextBox();
		this.label26 = new System.Windows.Forms.Label();
		this.破境横幅广播4 = new System.Windows.Forms.CheckBox();
		this.全服首次破境奖励4 = new System.Windows.Forms.CheckBox();
		this.破境成功属性加成4 = new System.Windows.Forms.CheckBox();
		this.增加突破几率道具4 = new System.Windows.Forms.CheckBox();
		this.渡劫前置要求4 = new System.Windows.Forms.CheckBox();
		this.失败惩罚4 = new System.Windows.Forms.TextBox();
		this.突破几率4 = new System.Windows.Forms.TextBox();
		this.境界突破丹药4 = new System.Windows.Forms.TextBox();
		this.突破灵气值4 = new System.Windows.Forms.TextBox();
		this.label34 = new System.Windows.Forms.Label();
		this.破境横幅广播3 = new System.Windows.Forms.CheckBox();
		this.全服首次破境奖励3 = new System.Windows.Forms.CheckBox();
		this.破境成功属性加成3 = new System.Windows.Forms.CheckBox();
		this.增加突破几率道具3 = new System.Windows.Forms.CheckBox();
		this.渡劫前置要求3 = new System.Windows.Forms.CheckBox();
		this.失败惩罚3 = new System.Windows.Forms.TextBox();
		this.突破几率3 = new System.Windows.Forms.TextBox();
		this.境界突破丹药3 = new System.Windows.Forms.TextBox();
		this.突破灵气值3 = new System.Windows.Forms.TextBox();
		this.label36 = new System.Windows.Forms.Label();
		this.破境横幅广播5 = new System.Windows.Forms.CheckBox();
		this.全服首次破境奖励5 = new System.Windows.Forms.CheckBox();
		this.破境成功属性加成5 = new System.Windows.Forms.CheckBox();
		this.增加突破几率道具5 = new System.Windows.Forms.CheckBox();
		this.渡劫前置要求5 = new System.Windows.Forms.CheckBox();
		this.失败惩罚5 = new System.Windows.Forms.TextBox();
		this.突破几率5 = new System.Windows.Forms.TextBox();
		this.境界突破丹药5 = new System.Windows.Forms.TextBox();
		this.突破灵气值5 = new System.Windows.Forms.TextBox();
		this.label38 = new System.Windows.Forms.Label();
		this.破境横幅广播9 = new System.Windows.Forms.CheckBox();
		this.全服首次破境奖励9 = new System.Windows.Forms.CheckBox();
		this.破境成功属性加成9 = new System.Windows.Forms.CheckBox();
		this.增加突破几率道具9 = new System.Windows.Forms.CheckBox();
		this.渡劫前置要求9 = new System.Windows.Forms.CheckBox();
		this.失败惩罚9 = new System.Windows.Forms.TextBox();
		this.突破几率9 = new System.Windows.Forms.TextBox();
		this.境界突破丹药9 = new System.Windows.Forms.TextBox();
		this.突破灵气值9 = new System.Windows.Forms.TextBox();
		this.label39 = new System.Windows.Forms.Label();
		this.破境横幅广播8 = new System.Windows.Forms.CheckBox();
		this.全服首次破境奖励8 = new System.Windows.Forms.CheckBox();
		this.破境成功属性加成8 = new System.Windows.Forms.CheckBox();
		this.增加突破几率道具8 = new System.Windows.Forms.CheckBox();
		this.渡劫前置要求8 = new System.Windows.Forms.CheckBox();
		this.失败惩罚8 = new System.Windows.Forms.TextBox();
		this.突破几率8 = new System.Windows.Forms.TextBox();
		this.境界突破丹药8 = new System.Windows.Forms.TextBox();
		this.突破灵气值8 = new System.Windows.Forms.TextBox();
		this.label40 = new System.Windows.Forms.Label();
		this.破境横幅广播7 = new System.Windows.Forms.CheckBox();
		this.全服首次破境奖励7 = new System.Windows.Forms.CheckBox();
		this.破境成功属性加成7 = new System.Windows.Forms.CheckBox();
		this.增加突破几率道具7 = new System.Windows.Forms.CheckBox();
		this.渡劫前置要求7 = new System.Windows.Forms.CheckBox();
		this.失败惩罚7 = new System.Windows.Forms.TextBox();
		this.突破几率7 = new System.Windows.Forms.TextBox();
		this.境界突破丹药7 = new System.Windows.Forms.TextBox();
		this.突破灵气值7 = new System.Windows.Forms.TextBox();
		this.label41 = new System.Windows.Forms.Label();
		this.破境横幅广播6 = new System.Windows.Forms.CheckBox();
		this.全服首次破境奖励6 = new System.Windows.Forms.CheckBox();
		this.破境成功属性加成6 = new System.Windows.Forms.CheckBox();
		this.增加突破几率道具6 = new System.Windows.Forms.CheckBox();
		this.渡劫前置要求6 = new System.Windows.Forms.CheckBox();
		this.失败惩罚6 = new System.Windows.Forms.TextBox();
		this.突破几率6 = new System.Windows.Forms.TextBox();
		this.境界突破丹药6 = new System.Windows.Forms.TextBox();
		this.突破灵气值6 = new System.Windows.Forms.TextBox();
		this.境界列表确定按钮 = new System.Windows.Forms.Button();
		this.渡劫额外要求配置块_破境BOSS只需击杀一次 = new System.Windows.Forms.CheckBox();
		this.渡劫额外要求配置块.SuspendLayout();
		this.增加突破几率道具配置块.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.增加突破几率道具配置块_增加突破几率道具).BeginInit();
		this.破境成功属性加成配置块.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_法力).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_气血).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_速度).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_防御).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_法术伤害).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_物理伤害).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_所有属性).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_所有相性).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_奖励数量).BeginInit();
		this.全服首次破境奖励配置块.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.全服首次破境奖励配置块_技能等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.全服首次破境奖励配置块_奖励声望).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.全服首次破境奖励配置块_奖励道行).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.全服首次破境奖励配置块_奖励游戏币).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.全服首次破境奖励配置块_奖励银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.全服首次破境奖励配置块_奖励金元宝).BeginInit();
		base.SuspendLayout();
		this.label4.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label4.ForeColor = System.Drawing.Color.Black;
		this.label4.Location = new System.Drawing.Point(131, 18);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(82, 23);
		this.label4.TabIndex = 236;
		this.label4.Text = "突破灵气值";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.突破灵气值1.Location = new System.Drawing.Point(131, 42);
		this.突破灵气值1.Name = "突破灵气值1";
		this.突破灵气值1.Size = new System.Drawing.Size(82, 23);
		this.突破灵气值1.TabIndex = 237;
		this.突破灵气值1.Text = "10";
		this.突破灵气值1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label5.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label5.ForeColor = System.Drawing.Color.Black;
		this.label5.Location = new System.Drawing.Point(214, 18);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(82, 23);
		this.label5.TabIndex = 238;
		this.label5.Text = "境界突破丹药";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.境界突破丹药1.Location = new System.Drawing.Point(214, 42);
		this.境界突破丹药1.Name = "境界突破丹药1";
		this.境界突破丹药1.Size = new System.Drawing.Size(82, 23);
		this.境界突破丹药1.TabIndex = 239;
		this.境界突破丹药1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label6.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label6.ForeColor = System.Drawing.Color.Black;
		this.label6.Location = new System.Drawing.Point(297, 18);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(78, 23);
		this.label6.TabIndex = 240;
		this.label6.Text = "突破几率(%)";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.突破几率1.Location = new System.Drawing.Point(297, 42);
		this.突破几率1.Name = "突破几率1";
		this.突破几率1.Size = new System.Drawing.Size(78, 23);
		this.突破几率1.TabIndex = 241;
		this.突破几率1.Text = "0";
		this.突破几率1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.失败惩罚1.Location = new System.Drawing.Point(376, 42);
		this.失败惩罚1.Name = "失败惩罚1";
		this.失败惩罚1.Size = new System.Drawing.Size(78, 23);
		this.失败惩罚1.TabIndex = 243;
		this.失败惩罚1.Text = "0";
		this.失败惩罚1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label7.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label7.ForeColor = System.Drawing.Color.Black;
		this.label7.Location = new System.Drawing.Point(376, 18);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(78, 23);
		this.label7.TabIndex = 242;
		this.label7.Text = "失败惩罚(%)";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label8.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label8.ForeColor = System.Drawing.Color.Black;
		this.label8.Location = new System.Drawing.Point(455, 18);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(102, 23);
		this.label8.TabIndex = 244;
		this.label8.Text = "渡劫前置要求";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.渡劫前置要求1.AutoSize = true;
		this.渡劫前置要求1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫前置要求1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫前置要求1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫前置要求1.Location = new System.Drawing.Point(458, 43);
		this.渡劫前置要求1.Name = "渡劫前置要求1";
		this.渡劫前置要求1.Size = new System.Drawing.Size(99, 21);
		this.渡劫前置要求1.TabIndex = 245;
		this.渡劫前置要求1.Tag = "1";
		this.渡劫前置要求1.Text = "点击要求配置";
		this.渡劫前置要求1.UseVisualStyleBackColor = true;
		this.渡劫额外要求配置块_Is道行达标.AutoSize = true;
		this.渡劫额外要求配置块_Is道行达标.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫额外要求配置块_Is道行达标.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫额外要求配置块_Is道行达标.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫额外要求配置块_Is道行达标.Location = new System.Drawing.Point(12, 50);
		this.渡劫额外要求配置块_Is道行达标.Name = "渡劫额外要求配置块_Is道行达标";
		this.渡劫额外要求配置块_Is道行达标.Size = new System.Drawing.Size(75, 21);
		this.渡劫额外要求配置块_Is道行达标.TabIndex = 258;
		this.渡劫额外要求配置块_Is道行达标.Text = "道行要求";
		this.渡劫额外要求配置块_Is道行达标.UseVisualStyleBackColor = true;
		this.渡劫额外要求配置块.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
		this.渡劫额外要求配置块.Controls.Add(this.渡劫额外要求配置块_破境BOSS只需击杀一次);
		this.渡劫额外要求配置块.Controls.Add(this.渡劫额外要求配置块_Is额外条件);
		this.渡劫额外要求配置块.Controls.Add(this.渡劫额外要求配置块取消);
		this.渡劫额外要求配置块.Controls.Add(this.渡劫额外要求配置块确定);
		this.渡劫额外要求配置块.Controls.Add(this.label18);
		this.渡劫额外要求配置块.Controls.Add(this.渡劫额外要求配置块_击杀BOSS要求);
		this.渡劫额外要求配置块.Controls.Add(this.渡劫额外要求配置块_Is击杀BOSS要求);
		this.渡劫额外要求配置块.Controls.Add(this.label16);
		this.渡劫额外要求配置块.Controls.Add(this.渡劫额外要求配置块_声望要求);
		this.渡劫额外要求配置块.Controls.Add(this.label17);
		this.渡劫额外要求配置块.Controls.Add(this.渡劫额外要求配置块_Is声望达标);
		this.渡劫额外要求配置块.Controls.Add(this.label15);
		this.渡劫额外要求配置块.Controls.Add(this.渡劫额外要求配置块_道行要求);
		this.渡劫额外要求配置块.Controls.Add(this.label13);
		this.渡劫额外要求配置块.Controls.Add(this.渡劫额外要求配置块_Is道行达标);
		this.渡劫额外要求配置块.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.渡劫额外要求配置块.ForeColor = System.Drawing.Color.Black;
		this.渡劫额外要求配置块.Location = new System.Drawing.Point(12, 269);
		this.渡劫额外要求配置块.Name = "渡劫额外要求配置块";
		this.渡劫额外要求配置块.Size = new System.Drawing.Size(220, 194);
		this.渡劫额外要求配置块.TabIndex = 259;
		this.渡劫额外要求配置块.TabStop = false;
		this.渡劫额外要求配置块.Text = "渡劫额外要求配置";
		this.渡劫额外要求配置块_Is额外条件.AutoSize = true;
		this.渡劫额外要求配置块_Is额外条件.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫额外要求配置块_Is额外条件.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.渡劫额外要求配置块_Is额外条件.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫额外要求配置块_Is额外条件.Location = new System.Drawing.Point(12, 22);
		this.渡劫额外要求配置块_Is额外条件.Name = "渡劫额外要求配置块_Is额外条件";
		this.渡劫额外要求配置块_Is额外条件.Size = new System.Drawing.Size(123, 21);
		this.渡劫额外要求配置块_Is额外条件.TabIndex = 272;
		this.渡劫额外要求配置块_Is额外条件.Text = "开启渡劫要求检测";
		this.渡劫额外要求配置块_Is额外条件.UseVisualStyleBackColor = true;
		this.渡劫额外要求配置块取消.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.渡劫额外要求配置块取消.ForeColor = System.Drawing.Color.Red;
		this.渡劫额外要求配置块取消.Location = new System.Drawing.Point(139, 158);
		this.渡劫额外要求配置块取消.Name = "渡劫额外要求配置块取消";
		this.渡劫额外要求配置块取消.Size = new System.Drawing.Size(57, 30);
		this.渡劫额外要求配置块取消.TabIndex = 271;
		this.渡劫额外要求配置块取消.Text = "取消";
		this.渡劫额外要求配置块取消.UseVisualStyleBackColor = true;
		this.渡劫额外要求配置块确定.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.渡劫额外要求配置块确定.Location = new System.Drawing.Point(26, 158);
		this.渡劫额外要求配置块确定.Name = "渡劫额外要求配置块确定";
		this.渡劫额外要求配置块确定.Size = new System.Drawing.Size(107, 30);
		this.渡劫额外要求配置块确定.TabIndex = 270;
		this.渡劫额外要求配置块确定.Text = "更新渡劫要求";
		this.渡劫额外要求配置块确定.UseVisualStyleBackColor = true;
		this.渡劫额外要求配置块确定.Click += new System.EventHandler(渡劫额外要求配置块确定_Click);
		this.label18.BackColor = System.Drawing.Color.Transparent;
		this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label18.Location = new System.Drawing.Point(194, 102);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(16, 23);
		this.label18.TabIndex = 269;
		this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label18.Visible = false;
		this.渡劫额外要求配置块_击杀BOSS要求.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫额外要求配置块_击杀BOSS要求.Location = new System.Drawing.Point(106, 102);
		this.渡劫额外要求配置块_击杀BOSS要求.Name = "渡劫额外要求配置块_击杀BOSS要求";
		this.渡劫额外要求配置块_击杀BOSS要求.Size = new System.Drawing.Size(87, 23);
		this.渡劫额外要求配置块_击杀BOSS要求.TabIndex = 268;
		this.渡劫额外要求配置块_击杀BOSS要求.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.渡劫额外要求配置块_Is击杀BOSS要求.AutoSize = true;
		this.渡劫额外要求配置块_Is击杀BOSS要求.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫额外要求配置块_Is击杀BOSS要求.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫额外要求配置块_Is击杀BOSS要求.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫额外要求配置块_Is击杀BOSS要求.Location = new System.Drawing.Point(12, 104);
		this.渡劫额外要求配置块_Is击杀BOSS要求.Name = "渡劫额外要求配置块_Is击杀BOSS要求";
		this.渡劫额外要求配置块_Is击杀BOSS要求.Size = new System.Drawing.Size(99, 21);
		this.渡劫额外要求配置块_Is击杀BOSS要求.TabIndex = 266;
		this.渡劫额外要求配置块_Is击杀BOSS要求.Text = "击杀怪物名字";
		this.渡劫额外要求配置块_Is击杀BOSS要求.UseVisualStyleBackColor = true;
		this.label16.BackColor = System.Drawing.Color.Transparent;
		this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label16.Location = new System.Drawing.Point(194, 76);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(16, 23);
		this.label16.TabIndex = 265;
		this.label16.Text = "点";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.渡劫额外要求配置块_声望要求.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫额外要求配置块_声望要求.Location = new System.Drawing.Point(106, 75);
		this.渡劫额外要求配置块_声望要求.Name = "渡劫额外要求配置块_声望要求";
		this.渡劫额外要求配置块_声望要求.Size = new System.Drawing.Size(87, 23);
		this.渡劫额外要求配置块_声望要求.TabIndex = 264;
		this.渡劫额外要求配置块_声望要求.Text = "0";
		this.渡劫额外要求配置块_声望要求.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label17.BackColor = System.Drawing.Color.Transparent;
		this.label17.Location = new System.Drawing.Point(90, 75);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(16, 23);
		this.label17.TabIndex = 263;
		this.label17.Text = "≥";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.渡劫额外要求配置块_Is声望达标.AutoSize = true;
		this.渡劫额外要求配置块_Is声望达标.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫额外要求配置块_Is声望达标.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫额外要求配置块_Is声望达标.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫额外要求配置块_Is声望达标.Location = new System.Drawing.Point(12, 77);
		this.渡劫额外要求配置块_Is声望达标.Name = "渡劫额外要求配置块_Is声望达标";
		this.渡劫额外要求配置块_Is声望达标.Size = new System.Drawing.Size(75, 21);
		this.渡劫额外要求配置块_Is声望达标.TabIndex = 262;
		this.渡劫额外要求配置块_Is声望达标.Text = "声望要求";
		this.渡劫额外要求配置块_Is声望达标.UseVisualStyleBackColor = true;
		this.label15.BackColor = System.Drawing.Color.Transparent;
		this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label15.Location = new System.Drawing.Point(194, 49);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(16, 23);
		this.label15.TabIndex = 261;
		this.label15.Text = "年";
		this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.渡劫额外要求配置块_道行要求.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫额外要求配置块_道行要求.Location = new System.Drawing.Point(106, 48);
		this.渡劫额外要求配置块_道行要求.Name = "渡劫额外要求配置块_道行要求";
		this.渡劫额外要求配置块_道行要求.Size = new System.Drawing.Size(87, 23);
		this.渡劫额外要求配置块_道行要求.TabIndex = 260;
		this.渡劫额外要求配置块_道行要求.Text = "0";
		this.渡劫额外要求配置块_道行要求.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label13.BackColor = System.Drawing.Color.Transparent;
		this.label13.Location = new System.Drawing.Point(90, 48);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(16, 23);
		this.label13.TabIndex = 259;
		this.label13.Text = "≥";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.增加突破几率道具1.AutoSize = true;
		this.增加突破几率道具1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.增加突破几率道具1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.增加突破几率道具1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.增加突破几率道具1.Location = new System.Drawing.Point(565, 43);
		this.增加突破几率道具1.Name = "增加突破几率道具1";
		this.增加突破几率道具1.Size = new System.Drawing.Size(99, 21);
		this.增加突破几率道具1.TabIndex = 261;
		this.增加突破几率道具1.Tag = "1";
		this.增加突破几率道具1.Text = "点击道具配置";
		this.增加突破几率道具1.UseVisualStyleBackColor = true;
		this.label19.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label19.ForeColor = System.Drawing.Color.Black;
		this.label19.Location = new System.Drawing.Point(558, 18);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(112, 23);
		this.label19.TabIndex = 260;
		this.label19.Text = "增加突破几率道具";
		this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.增加突破几率道具配置块.BackColor = System.Drawing.Color.White;
		this.增加突破几率道具配置块.Controls.Add(this.增加突破几率道具配置块取消);
		this.增加突破几率道具配置块.Controls.Add(this.增加突破几率道具配置块_增加突破几率道具);
		this.增加突破几率道具配置块.Controls.Add(this.增加突破几率道具配置块确定);
		this.增加突破几率道具配置块.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.增加突破几率道具配置块.ForeColor = System.Drawing.Color.Black;
		this.增加突破几率道具配置块.Location = new System.Drawing.Point(12, 479);
		this.增加突破几率道具配置块.Name = "增加突破几率道具配置块";
		this.增加突破几率道具配置块.Size = new System.Drawing.Size(220, 213);
		this.增加突破几率道具配置块.TabIndex = 262;
		this.增加突破几率道具配置块.TabStop = false;
		this.增加突破几率道具配置块.Text = "增加突破几率道具配置";
		this.增加突破几率道具配置块取消.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.增加突破几率道具配置块取消.ForeColor = System.Drawing.Color.Red;
		this.增加突破几率道具配置块取消.Location = new System.Drawing.Point(150, 174);
		this.增加突破几率道具配置块取消.Name = "增加突破几率道具配置块取消";
		this.增加突破几率道具配置块取消.Size = new System.Drawing.Size(57, 30);
		this.增加突破几率道具配置块取消.TabIndex = 272;
		this.增加突破几率道具配置块取消.Text = "取消";
		this.增加突破几率道具配置块取消.UseVisualStyleBackColor = true;
		this.增加突破几率道具配置块_增加突破几率道具.AllowUserToDeleteRows = false;
		this.增加突破几率道具配置块_增加突破几率道具.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.增加突破几率道具配置块_增加突破几率道具.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.增加突破几率道具配置块_增加突破几率道具.BackgroundColor = System.Drawing.Color.White;
		this.增加突破几率道具配置块_增加突破几率道具.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.增加突破几率道具配置块_增加突破几率道具.Columns.AddRange(this.Add道具名字, this.Add增加几率);
		this.增加突破几率道具配置块_增加突破几率道具.Location = new System.Drawing.Point(12, 22);
		this.增加突破几率道具配置块_增加突破几率道具.MultiSelect = false;
		this.增加突破几率道具配置块_增加突破几率道具.Name = "增加突破几率道具配置块_增加突破几率道具";
		this.增加突破几率道具配置块_增加突破几率道具.RowHeadersVisible = false;
		this.增加突破几率道具配置块_增加突破几率道具.RowTemplate.Height = 25;
		this.增加突破几率道具配置块_增加突破几率道具.Size = new System.Drawing.Size(195, 140);
		this.增加突破几率道具配置块_增加突破几率道具.TabIndex = 271;
		this.Add道具名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.Add道具名字.HeaderText = "道具名字";
		this.Add道具名字.MinimumWidth = 100;
		this.Add道具名字.Name = "Add道具名字";
		this.Add道具名字.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.Add增加几率.HeaderText = "增加几率";
		this.Add增加几率.MinimumWidth = 90;
		this.Add增加几率.Name = "Add增加几率";
		this.Add增加几率.Width = 90;
		this.增加突破几率道具配置块确定.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.增加突破几率道具配置块确定.Location = new System.Drawing.Point(12, 174);
		this.增加突破几率道具配置块确定.Name = "增加突破几率道具配置块确定";
		this.增加突破几率道具配置块确定.Size = new System.Drawing.Size(133, 30);
		this.增加突破几率道具配置块确定.TabIndex = 270;
		this.增加突破几率道具配置块确定.Text = "增加突破几率道具";
		this.增加突破几率道具配置块确定.UseVisualStyleBackColor = true;
		this.增加突破几率道具配置块确定.Click += new System.EventHandler(增加突破几率道具配置块确定_Click);
		this.破境成功属性加成1.AutoSize = true;
		this.破境成功属性加成1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境成功属性加成1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境成功属性加成1.Location = new System.Drawing.Point(678, 43);
		this.破境成功属性加成1.Name = "破境成功属性加成1";
		this.破境成功属性加成1.Size = new System.Drawing.Size(99, 21);
		this.破境成功属性加成1.TabIndex = 264;
		this.破境成功属性加成1.Tag = "1";
		this.破境成功属性加成1.Text = "点击加成配置";
		this.破境成功属性加成1.UseVisualStyleBackColor = true;
		this.label20.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label20.ForeColor = System.Drawing.Color.Black;
		this.label20.Location = new System.Drawing.Point(671, 18);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(112, 23);
		this.label20.TabIndex = 263;
		this.label20.Text = "破境成功属性加成";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.全服首次破境奖励1.AutoSize = true;
		this.全服首次破境奖励1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.全服首次破境奖励1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.全服首次破境奖励1.Location = new System.Drawing.Point(791, 43);
		this.全服首次破境奖励1.Name = "全服首次破境奖励1";
		this.全服首次破境奖励1.Size = new System.Drawing.Size(99, 21);
		this.全服首次破境奖励1.TabIndex = 266;
		this.全服首次破境奖励1.Tag = "1";
		this.全服首次破境奖励1.Text = "点击奖励配置";
		this.全服首次破境奖励1.UseVisualStyleBackColor = true;
		this.label21.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label21.ForeColor = System.Drawing.Color.Black;
		this.label21.Location = new System.Drawing.Point(784, 18);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(112, 23);
		this.label21.TabIndex = 265;
		this.label21.Text = "全服首次破境奖励";
		this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.破境横幅广播1.AutoSize = true;
		this.破境横幅广播1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境横幅广播1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境横幅广播1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境横幅广播1.Location = new System.Drawing.Point(904, 43);
		this.破境横幅广播1.Name = "破境横幅广播1";
		this.破境横幅广播1.Size = new System.Drawing.Size(75, 21);
		this.破境横幅广播1.TabIndex = 268;
		this.破境横幅广播1.Tag = "1";
		this.破境横幅广播1.Text = "点击开启";
		this.破境横幅广播1.UseVisualStyleBackColor = true;
		this.label9.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label9.ForeColor = System.Drawing.Color.Black;
		this.label9.Location = new System.Drawing.Point(897, 18);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(82, 23);
		this.label9.TabIndex = 267;
		this.label9.Text = "破境横幅广播";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.破境成功属性加成配置块.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
		this.破境成功属性加成配置块.Controls.Add(this.破境成功属性加成配置块取消);
		this.破境成功属性加成配置块.Controls.Add(this.label25);
		this.破境成功属性加成配置块.Controls.Add(this.破境成功属性加成配置块_法力);
		this.破境成功属性加成配置块.Controls.Add(this.label22);
		this.破境成功属性加成配置块.Controls.Add(this.破境成功属性加成配置块_气血);
		this.破境成功属性加成配置块.Controls.Add(this.label23);
		this.破境成功属性加成配置块.Controls.Add(this.破境成功属性加成配置块_速度);
		this.破境成功属性加成配置块.Controls.Add(this.label24);
		this.破境成功属性加成配置块.Controls.Add(this.破境成功属性加成配置块_防御);
		this.破境成功属性加成配置块.Controls.Add(this.label12);
		this.破境成功属性加成配置块.Controls.Add(this.破境成功属性加成配置块_法术伤害);
		this.破境成功属性加成配置块.Controls.Add(this.label14);
		this.破境成功属性加成配置块.Controls.Add(this.破境成功属性加成配置块_物理伤害);
		this.破境成功属性加成配置块.Controls.Add(this.label11);
		this.破境成功属性加成配置块.Controls.Add(this.破境成功属性加成配置块_所有属性);
		this.破境成功属性加成配置块.Controls.Add(this.label10);
		this.破境成功属性加成配置块.Controls.Add(this.破境成功属性加成配置块_所有相性);
		this.破境成功属性加成配置块.Controls.Add(this.label220);
		this.破境成功属性加成配置块.Controls.Add(this.label223);
		this.破境成功属性加成配置块.Controls.Add(this.label222);
		this.破境成功属性加成配置块.Controls.Add(this.破境成功属性加成配置块_奖励数量);
		this.破境成功属性加成配置块.Controls.Add(this.破境成功属性加成配置块_奖励类型);
		this.破境成功属性加成配置块.Controls.Add(this.破境成功属性加成配置块_奖励名字);
		this.破境成功属性加成配置块.Controls.Add(this.破境成功属性加成配置块确定);
		this.破境成功属性加成配置块.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块.ForeColor = System.Drawing.Color.Black;
		this.破境成功属性加成配置块.Location = new System.Drawing.Point(248, 476);
		this.破境成功属性加成配置块.Name = "破境成功属性加成配置块";
		this.破境成功属性加成配置块.Size = new System.Drawing.Size(376, 216);
		this.破境成功属性加成配置块.TabIndex = 269;
		this.破境成功属性加成配置块.TabStop = false;
		this.破境成功属性加成配置块.Text = "破境成功属性加成配置";
		this.破境成功属性加成配置块取消.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块取消.ForeColor = System.Drawing.Color.Red;
		this.破境成功属性加成配置块取消.Location = new System.Drawing.Point(208, 172);
		this.破境成功属性加成配置块取消.Name = "破境成功属性加成配置块取消";
		this.破境成功属性加成配置块取消.Size = new System.Drawing.Size(57, 30);
		this.破境成功属性加成配置块取消.TabIndex = 293;
		this.破境成功属性加成配置块取消.Text = "取消";
		this.破境成功属性加成配置块取消.UseVisualStyleBackColor = true;
		this.label25.BackColor = System.Drawing.Color.Transparent;
		this.label25.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label25.Location = new System.Drawing.Point(201, 134);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(57, 23);
		this.label25.TabIndex = 292;
		this.label25.Text = "法力加成";
		this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.破境成功属性加成配置块_法力.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块_法力.Location = new System.Drawing.Point(260, 134);
		this.破境成功属性加成配置块_法力.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.破境成功属性加成配置块_法力.Name = "破境成功属性加成配置块_法力";
		this.破境成功属性加成配置块_法力.Size = new System.Drawing.Size(100, 23);
		this.破境成功属性加成配置块_法力.TabIndex = 291;
		this.label22.BackColor = System.Drawing.Color.Transparent;
		this.label22.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label22.Location = new System.Drawing.Point(201, 108);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(57, 23);
		this.label22.TabIndex = 290;
		this.label22.Text = "气血加成";
		this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.破境成功属性加成配置块_气血.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块_气血.Location = new System.Drawing.Point(260, 108);
		this.破境成功属性加成配置块_气血.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.破境成功属性加成配置块_气血.Name = "破境成功属性加成配置块_气血";
		this.破境成功属性加成配置块_气血.Size = new System.Drawing.Size(100, 23);
		this.破境成功属性加成配置块_气血.TabIndex = 289;
		this.label23.BackColor = System.Drawing.Color.Transparent;
		this.label23.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label23.Location = new System.Drawing.Point(201, 82);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(57, 23);
		this.label23.TabIndex = 288;
		this.label23.Text = "速度加成";
		this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.破境成功属性加成配置块_速度.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块_速度.Location = new System.Drawing.Point(260, 82);
		this.破境成功属性加成配置块_速度.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.破境成功属性加成配置块_速度.Name = "破境成功属性加成配置块_速度";
		this.破境成功属性加成配置块_速度.Size = new System.Drawing.Size(100, 23);
		this.破境成功属性加成配置块_速度.TabIndex = 287;
		this.label24.BackColor = System.Drawing.Color.Transparent;
		this.label24.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label24.Location = new System.Drawing.Point(201, 56);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(57, 23);
		this.label24.TabIndex = 286;
		this.label24.Text = "防御加成";
		this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.破境成功属性加成配置块_防御.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块_防御.Location = new System.Drawing.Point(260, 56);
		this.破境成功属性加成配置块_防御.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.破境成功属性加成配置块_防御.Name = "破境成功属性加成配置块_防御";
		this.破境成功属性加成配置块_防御.Size = new System.Drawing.Size(100, 23);
		this.破境成功属性加成配置块_防御.TabIndex = 285;
		this.label12.BackColor = System.Drawing.Color.Transparent;
		this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label12.Location = new System.Drawing.Point(15, 134);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(80, 23);
		this.label12.TabIndex = 284;
		this.label12.Text = "法术伤害加成";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.破境成功属性加成配置块_法术伤害.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块_法术伤害.Location = new System.Drawing.Point(97, 134);
		this.破境成功属性加成配置块_法术伤害.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.破境成功属性加成配置块_法术伤害.Name = "破境成功属性加成配置块_法术伤害";
		this.破境成功属性加成配置块_法术伤害.Size = new System.Drawing.Size(100, 23);
		this.破境成功属性加成配置块_法术伤害.TabIndex = 283;
		this.label14.BackColor = System.Drawing.Color.Transparent;
		this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label14.Location = new System.Drawing.Point(15, 108);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(80, 23);
		this.label14.TabIndex = 282;
		this.label14.Text = "物理伤害加成";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.破境成功属性加成配置块_物理伤害.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块_物理伤害.Location = new System.Drawing.Point(97, 108);
		this.破境成功属性加成配置块_物理伤害.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.破境成功属性加成配置块_物理伤害.Name = "破境成功属性加成配置块_物理伤害";
		this.破境成功属性加成配置块_物理伤害.Size = new System.Drawing.Size(100, 23);
		this.破境成功属性加成配置块_物理伤害.TabIndex = 281;
		this.label11.BackColor = System.Drawing.Color.Transparent;
		this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label11.Location = new System.Drawing.Point(15, 82);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(80, 23);
		this.label11.TabIndex = 280;
		this.label11.Text = "所有属性加成";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.破境成功属性加成配置块_所有属性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块_所有属性.Location = new System.Drawing.Point(97, 82);
		this.破境成功属性加成配置块_所有属性.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.破境成功属性加成配置块_所有属性.Name = "破境成功属性加成配置块_所有属性";
		this.破境成功属性加成配置块_所有属性.Size = new System.Drawing.Size(100, 23);
		this.破境成功属性加成配置块_所有属性.TabIndex = 279;
		this.label10.BackColor = System.Drawing.Color.Transparent;
		this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label10.Location = new System.Drawing.Point(15, 56);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(80, 23);
		this.label10.TabIndex = 278;
		this.label10.Text = "所有相性加成";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.破境成功属性加成配置块_所有相性.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块_所有相性.Location = new System.Drawing.Point(97, 56);
		this.破境成功属性加成配置块_所有相性.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.破境成功属性加成配置块_所有相性.Name = "破境成功属性加成配置块_所有相性";
		this.破境成功属性加成配置块_所有相性.Size = new System.Drawing.Size(100, 23);
		this.破境成功属性加成配置块_所有相性.TabIndex = 277;
		this.label220.BackColor = System.Drawing.Color.Transparent;
		this.label220.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label220.Location = new System.Drawing.Point(283, 28);
		this.label220.Name = "label220";
		this.label220.Size = new System.Drawing.Size(17, 23);
		this.label220.TabIndex = 276;
		this.label220.Text = "×";
		this.label220.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label223.BackColor = System.Drawing.Color.Transparent;
		this.label223.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label223.Location = new System.Drawing.Point(169, 28);
		this.label223.Name = "label223";
		this.label223.Size = new System.Drawing.Size(33, 23);
		this.label223.TabIndex = 275;
		this.label223.Text = "名字";
		this.label223.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label222.BackColor = System.Drawing.Color.Transparent;
		this.label222.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label222.Location = new System.Drawing.Point(15, 28);
		this.label222.Name = "label222";
		this.label222.Size = new System.Drawing.Size(80, 23);
		this.label222.TabIndex = 274;
		this.label222.Text = "奖励类型";
		this.label222.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.破境成功属性加成配置块_奖励数量.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块_奖励数量.Location = new System.Drawing.Point(303, 29);
		this.破境成功属性加成配置块_奖励数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.破境成功属性加成配置块_奖励数量.Name = "破境成功属性加成配置块_奖励数量";
		this.破境成功属性加成配置块_奖励数量.Size = new System.Drawing.Size(57, 23);
		this.破境成功属性加成配置块_奖励数量.TabIndex = 273;
		this.破境成功属性加成配置块_奖励类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.破境成功属性加成配置块_奖励类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块_奖励类型.FormattingEnabled = true;
		this.破境成功属性加成配置块_奖励类型.Items.AddRange(new object[10] { "金元宝", "银元宝", "金钱", "代金券", "道行", "声望", "累充点", "南极点", "奇宝点", "道具" });
		this.破境成功属性加成配置块_奖励类型.Location = new System.Drawing.Point(97, 27);
		this.破境成功属性加成配置块_奖励类型.Name = "破境成功属性加成配置块_奖励类型";
		this.破境成功属性加成配置块_奖励类型.Size = new System.Drawing.Size(66, 25);
		this.破境成功属性加成配置块_奖励类型.TabIndex = 271;
		this.破境成功属性加成配置块_奖励名字.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块_奖励名字.Location = new System.Drawing.Point(202, 28);
		this.破境成功属性加成配置块_奖励名字.Name = "破境成功属性加成配置块_奖励名字";
		this.破境成功属性加成配置块_奖励名字.Size = new System.Drawing.Size(81, 23);
		this.破境成功属性加成配置块_奖励名字.TabIndex = 272;
		this.破境成功属性加成配置块确定.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成配置块确定.Location = new System.Drawing.Point(83, 172);
		this.破境成功属性加成配置块确定.Name = "破境成功属性加成配置块确定";
		this.破境成功属性加成配置块确定.Size = new System.Drawing.Size(119, 30);
		this.破境成功属性加成配置块确定.TabIndex = 270;
		this.破境成功属性加成配置块确定.Text = "更新属性加成";
		this.破境成功属性加成配置块确定.UseVisualStyleBackColor = true;
		this.破境成功属性加成配置块确定.Click += new System.EventHandler(破境成功属性加成配置块确定_Click);
		this.全服首次破境奖励配置块.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
		this.全服首次破境奖励配置块.Controls.Add(this.全服首次破境奖励配置块_Is全服突破境界奖励);
		this.全服首次破境奖励配置块.Controls.Add(this.全服首次破境奖励配置块取消);
		this.全服首次破境奖励配置块.Controls.Add(this.label28);
		this.全服首次破境奖励配置块.Controls.Add(this.全服首次破境奖励配置块_奖励技能);
		this.全服首次破境奖励配置块.Controls.Add(this.label27);
		this.全服首次破境奖励配置块.Controls.Add(this.全服首次破境奖励配置块_技能等级);
		this.全服首次破境奖励配置块.Controls.Add(this.label29);
		this.全服首次破境奖励配置块.Controls.Add(this.全服首次破境奖励配置块_奖励声望);
		this.全服首次破境奖励配置块.Controls.Add(this.label30);
		this.全服首次破境奖励配置块.Controls.Add(this.全服首次破境奖励配置块_奖励道行);
		this.全服首次破境奖励配置块.Controls.Add(this.label31);
		this.全服首次破境奖励配置块.Controls.Add(this.全服首次破境奖励配置块_奖励游戏币);
		this.全服首次破境奖励配置块.Controls.Add(this.label32);
		this.全服首次破境奖励配置块.Controls.Add(this.全服首次破境奖励配置块_奖励银元宝);
		this.全服首次破境奖励配置块.Controls.Add(this.label33);
		this.全服首次破境奖励配置块.Controls.Add(this.全服首次破境奖励配置块_奖励金元宝);
		this.全服首次破境奖励配置块.Controls.Add(this.label35);
		this.全服首次破境奖励配置块.Controls.Add(this.全服首次破境奖励配置块_奖励道具);
		this.全服首次破境奖励配置块.Controls.Add(this.全服首次破境奖励配置块确定);
		this.全服首次破境奖励配置块.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励配置块.ForeColor = System.Drawing.Color.Black;
		this.全服首次破境奖励配置块.Location = new System.Drawing.Point(646, 470);
		this.全服首次破境奖励配置块.Name = "全服首次破境奖励配置块";
		this.全服首次破境奖励配置块.Size = new System.Drawing.Size(334, 222);
		this.全服首次破境奖励配置块.TabIndex = 270;
		this.全服首次破境奖励配置块.TabStop = false;
		this.全服首次破境奖励配置块.Text = "全服首次破境奖励配置";
		this.全服首次破境奖励配置块_Is全服突破境界奖励.AutoSize = true;
		this.全服首次破境奖励配置块_Is全服突破境界奖励.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.全服首次破境奖励配置块_Is全服突破境界奖励.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励配置块_Is全服突破境界奖励.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.全服首次破境奖励配置块_Is全服突破境界奖励.Location = new System.Drawing.Point(15, 25);
		this.全服首次破境奖励配置块_Is全服突破境界奖励.Name = "全服首次破境奖励配置块_Is全服突破境界奖励";
		this.全服首次破境奖励配置块_Is全服突破境界奖励.Size = new System.Drawing.Size(147, 21);
		this.全服首次破境奖励配置块_Is全服突破境界奖励.TabIndex = 296;
		this.全服首次破境奖励配置块_Is全服突破境界奖励.Text = "开启全服首次破境奖励";
		this.全服首次破境奖励配置块_Is全服突破境界奖励.UseVisualStyleBackColor = true;
		this.全服首次破境奖励配置块取消.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励配置块取消.ForeColor = System.Drawing.Color.Red;
		this.全服首次破境奖励配置块取消.Location = new System.Drawing.Point(208, 172);
		this.全服首次破境奖励配置块取消.Name = "全服首次破境奖励配置块取消";
		this.全服首次破境奖励配置块取消.Size = new System.Drawing.Size(47, 30);
		this.全服首次破境奖励配置块取消.TabIndex = 295;
		this.全服首次破境奖励配置块取消.Text = "取消";
		this.全服首次破境奖励配置块取消.UseVisualStyleBackColor = true;
		this.label28.BackColor = System.Drawing.Color.Transparent;
		this.label28.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label28.Location = new System.Drawing.Point(15, 136);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(80, 23);
		this.label28.TabIndex = 294;
		this.label28.Text = "奖励技能名字";
		this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.全服首次破境奖励配置块_奖励技能.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励配置块_奖励技能.Location = new System.Drawing.Point(97, 136);
		this.全服首次破境奖励配置块_奖励技能.Name = "全服首次破境奖励配置块_奖励技能";
		this.全服首次破境奖励配置块_奖励技能.Size = new System.Drawing.Size(100, 23);
		this.全服首次破境奖励配置块_奖励技能.TabIndex = 293;
		this.label27.BackColor = System.Drawing.Color.Transparent;
		this.label27.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label27.Location = new System.Drawing.Point(198, 136);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(60, 23);
		this.label27.TabIndex = 290;
		this.label27.Text = "技能等级";
		this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.全服首次破境奖励配置块_技能等级.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励配置块_技能等级.Location = new System.Drawing.Point(258, 136);
		this.全服首次破境奖励配置块_技能等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.全服首次破境奖励配置块_技能等级.Name = "全服首次破境奖励配置块_技能等级";
		this.全服首次破境奖励配置块_技能等级.Size = new System.Drawing.Size(65, 23);
		this.全服首次破境奖励配置块_技能等级.TabIndex = 289;
		this.label29.BackColor = System.Drawing.Color.Transparent;
		this.label29.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label29.Location = new System.Drawing.Point(179, 108);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(47, 23);
		this.label29.TabIndex = 286;
		this.label29.Text = "声望+";
		this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.全服首次破境奖励配置块_奖励声望.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励配置块_奖励声望.Location = new System.Drawing.Point(228, 108);
		this.全服首次破境奖励配置块_奖励声望.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.全服首次破境奖励配置块_奖励声望.Name = "全服首次破境奖励配置块_奖励声望";
		this.全服首次破境奖励配置块_奖励声望.Size = new System.Drawing.Size(100, 23);
		this.全服首次破境奖励配置块_奖励声望.TabIndex = 285;
		this.label30.BackColor = System.Drawing.Color.Transparent;
		this.label30.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label30.Location = new System.Drawing.Point(179, 82);
		this.label30.Name = "label30";
		this.label30.Size = new System.Drawing.Size(47, 23);
		this.label30.TabIndex = 284;
		this.label30.Text = "道行+";
		this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.全服首次破境奖励配置块_奖励道行.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励配置块_奖励道行.Location = new System.Drawing.Point(228, 82);
		this.全服首次破境奖励配置块_奖励道行.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.全服首次破境奖励配置块_奖励道行.Name = "全服首次破境奖励配置块_奖励道行";
		this.全服首次破境奖励配置块_奖励道行.Size = new System.Drawing.Size(100, 23);
		this.全服首次破境奖励配置块_奖励道行.TabIndex = 283;
		this.label31.BackColor = System.Drawing.Color.Transparent;
		this.label31.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label31.Location = new System.Drawing.Point(15, 108);
		this.label31.Name = "label31";
		this.label31.Size = new System.Drawing.Size(55, 23);
		this.label31.TabIndex = 282;
		this.label31.Text = "游戏币+";
		this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.全服首次破境奖励配置块_奖励游戏币.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励配置块_奖励游戏币.Location = new System.Drawing.Point(73, 108);
		this.全服首次破境奖励配置块_奖励游戏币.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.全服首次破境奖励配置块_奖励游戏币.Name = "全服首次破境奖励配置块_奖励游戏币";
		this.全服首次破境奖励配置块_奖励游戏币.Size = new System.Drawing.Size(100, 23);
		this.全服首次破境奖励配置块_奖励游戏币.TabIndex = 281;
		this.label32.BackColor = System.Drawing.Color.Transparent;
		this.label32.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label32.Location = new System.Drawing.Point(15, 82);
		this.label32.Name = "label32";
		this.label32.Size = new System.Drawing.Size(55, 23);
		this.label32.TabIndex = 280;
		this.label32.Text = "银元宝+";
		this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.全服首次破境奖励配置块_奖励银元宝.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励配置块_奖励银元宝.Location = new System.Drawing.Point(73, 82);
		this.全服首次破境奖励配置块_奖励银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.全服首次破境奖励配置块_奖励银元宝.Name = "全服首次破境奖励配置块_奖励银元宝";
		this.全服首次破境奖励配置块_奖励银元宝.Size = new System.Drawing.Size(100, 23);
		this.全服首次破境奖励配置块_奖励银元宝.TabIndex = 279;
		this.label33.BackColor = System.Drawing.Color.Transparent;
		this.label33.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label33.Location = new System.Drawing.Point(15, 56);
		this.label33.Name = "label33";
		this.label33.Size = new System.Drawing.Size(55, 23);
		this.label33.TabIndex = 278;
		this.label33.Text = "金元宝+";
		this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.全服首次破境奖励配置块_奖励金元宝.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励配置块_奖励金元宝.Location = new System.Drawing.Point(73, 56);
		this.全服首次破境奖励配置块_奖励金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.全服首次破境奖励配置块_奖励金元宝.Name = "全服首次破境奖励配置块_奖励金元宝";
		this.全服首次破境奖励配置块_奖励金元宝.Size = new System.Drawing.Size(100, 23);
		this.全服首次破境奖励配置块_奖励金元宝.TabIndex = 277;
		this.全服首次破境奖励配置块_奖励金元宝.Value = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.label35.BackColor = System.Drawing.Color.Transparent;
		this.label35.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.label35.Location = new System.Drawing.Point(179, 55);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(47, 23);
		this.label35.TabIndex = 275;
		this.label35.Text = "道具+";
		this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.全服首次破境奖励配置块_奖励道具.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励配置块_奖励道具.Location = new System.Drawing.Point(228, 55);
		this.全服首次破境奖励配置块_奖励道具.Name = "全服首次破境奖励配置块_奖励道具";
		this.全服首次破境奖励配置块_奖励道具.Size = new System.Drawing.Size(100, 23);
		this.全服首次破境奖励配置块_奖励道具.TabIndex = 272;
		this.全服首次破境奖励配置块确定.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励配置块确定.Location = new System.Drawing.Point(73, 172);
		this.全服首次破境奖励配置块确定.Name = "全服首次破境奖励配置块确定";
		this.全服首次破境奖励配置块确定.Size = new System.Drawing.Size(129, 30);
		this.全服首次破境奖励配置块确定.TabIndex = 270;
		this.全服首次破境奖励配置块确定.Text = "更新首次破境奖励";
		this.全服首次破境奖励配置块确定.UseVisualStyleBackColor = true;
		this.全服首次破境奖励配置块确定.Click += new System.EventHandler(全服首次破境奖励配置块确定_Click);
		this.label1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(9, 18);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(121, 23);
		this.label1.TabIndex = 271;
		this.label1.Text = "当前境界→突破境界";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label2.BackColor = System.Drawing.Color.Black;
		this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.label2.ForeColor = System.Drawing.Color.Yellow;
		this.label2.Location = new System.Drawing.Point(9, 42);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(121, 23);
		this.label2.TabIndex = 272;
		this.label2.Text = "练气境 → 筑基境";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.BackColor = System.Drawing.Color.Black;
		this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.label3.ForeColor = System.Drawing.Color.Yellow;
		this.label3.Location = new System.Drawing.Point(9, 65);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(121, 23);
		this.label3.TabIndex = 282;
		this.label3.Text = "筑基境 → 金丹境";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.破境横幅广播2.AutoSize = true;
		this.破境横幅广播2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境横幅广播2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境横幅广播2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境横幅广播2.Location = new System.Drawing.Point(904, 66);
		this.破境横幅广播2.Name = "破境横幅广播2";
		this.破境横幅广播2.Size = new System.Drawing.Size(75, 21);
		this.破境横幅广播2.TabIndex = 281;
		this.破境横幅广播2.Tag = "2";
		this.破境横幅广播2.Text = "点击开启";
		this.破境横幅广播2.UseVisualStyleBackColor = true;
		this.全服首次破境奖励2.AutoSize = true;
		this.全服首次破境奖励2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.全服首次破境奖励2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.全服首次破境奖励2.Location = new System.Drawing.Point(791, 66);
		this.全服首次破境奖励2.Name = "全服首次破境奖励2";
		this.全服首次破境奖励2.Size = new System.Drawing.Size(99, 21);
		this.全服首次破境奖励2.TabIndex = 280;
		this.全服首次破境奖励2.Tag = "2";
		this.全服首次破境奖励2.Text = "点击奖励配置";
		this.全服首次破境奖励2.UseVisualStyleBackColor = true;
		this.破境成功属性加成2.AutoSize = true;
		this.破境成功属性加成2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境成功属性加成2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境成功属性加成2.Location = new System.Drawing.Point(678, 66);
		this.破境成功属性加成2.Name = "破境成功属性加成2";
		this.破境成功属性加成2.Size = new System.Drawing.Size(99, 21);
		this.破境成功属性加成2.TabIndex = 279;
		this.破境成功属性加成2.Tag = "2";
		this.破境成功属性加成2.Text = "点击加成配置";
		this.破境成功属性加成2.UseVisualStyleBackColor = true;
		this.增加突破几率道具2.AutoSize = true;
		this.增加突破几率道具2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.增加突破几率道具2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.增加突破几率道具2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.增加突破几率道具2.Location = new System.Drawing.Point(565, 66);
		this.增加突破几率道具2.Name = "增加突破几率道具2";
		this.增加突破几率道具2.Size = new System.Drawing.Size(99, 21);
		this.增加突破几率道具2.TabIndex = 278;
		this.增加突破几率道具2.Tag = "2";
		this.增加突破几率道具2.Text = "点击道具配置";
		this.增加突破几率道具2.UseVisualStyleBackColor = true;
		this.渡劫前置要求2.AutoSize = true;
		this.渡劫前置要求2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫前置要求2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫前置要求2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫前置要求2.Location = new System.Drawing.Point(458, 66);
		this.渡劫前置要求2.Name = "渡劫前置要求2";
		this.渡劫前置要求2.Size = new System.Drawing.Size(99, 21);
		this.渡劫前置要求2.TabIndex = 277;
		this.渡劫前置要求2.Tag = "2";
		this.渡劫前置要求2.Text = "点击要求配置";
		this.渡劫前置要求2.UseVisualStyleBackColor = true;
		this.失败惩罚2.Location = new System.Drawing.Point(376, 65);
		this.失败惩罚2.Name = "失败惩罚2";
		this.失败惩罚2.Size = new System.Drawing.Size(78, 23);
		this.失败惩罚2.TabIndex = 276;
		this.失败惩罚2.Text = "0";
		this.失败惩罚2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破几率2.Location = new System.Drawing.Point(297, 65);
		this.突破几率2.Name = "突破几率2";
		this.突破几率2.Size = new System.Drawing.Size(78, 23);
		this.突破几率2.TabIndex = 275;
		this.突破几率2.Text = "0";
		this.突破几率2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.境界突破丹药2.Location = new System.Drawing.Point(214, 65);
		this.境界突破丹药2.Name = "境界突破丹药2";
		this.境界突破丹药2.Size = new System.Drawing.Size(82, 23);
		this.境界突破丹药2.TabIndex = 274;
		this.境界突破丹药2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破灵气值2.Location = new System.Drawing.Point(131, 65);
		this.突破灵气值2.Name = "突破灵气值2";
		this.突破灵气值2.Size = new System.Drawing.Size(82, 23);
		this.突破灵气值2.TabIndex = 273;
		this.突破灵气值2.Text = "100";
		this.突破灵气值2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label26.BackColor = System.Drawing.Color.Black;
		this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label26.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.label26.ForeColor = System.Drawing.Color.Yellow;
		this.label26.Location = new System.Drawing.Point(9, 112);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(121, 23);
		this.label26.TabIndex = 302;
		this.label26.Text = "元婴境 → 化神境";
		this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.破境横幅广播4.AutoSize = true;
		this.破境横幅广播4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境横幅广播4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境横幅广播4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境横幅广播4.Location = new System.Drawing.Point(904, 113);
		this.破境横幅广播4.Name = "破境横幅广播4";
		this.破境横幅广播4.Size = new System.Drawing.Size(75, 21);
		this.破境横幅广播4.TabIndex = 301;
		this.破境横幅广播4.Tag = "4";
		this.破境横幅广播4.Text = "点击开启";
		this.破境横幅广播4.UseVisualStyleBackColor = true;
		this.全服首次破境奖励4.AutoSize = true;
		this.全服首次破境奖励4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.全服首次破境奖励4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.全服首次破境奖励4.Location = new System.Drawing.Point(791, 113);
		this.全服首次破境奖励4.Name = "全服首次破境奖励4";
		this.全服首次破境奖励4.Size = new System.Drawing.Size(99, 21);
		this.全服首次破境奖励4.TabIndex = 300;
		this.全服首次破境奖励4.Tag = "4";
		this.全服首次破境奖励4.Text = "点击奖励配置";
		this.全服首次破境奖励4.UseVisualStyleBackColor = true;
		this.破境成功属性加成4.AutoSize = true;
		this.破境成功属性加成4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境成功属性加成4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境成功属性加成4.Location = new System.Drawing.Point(678, 113);
		this.破境成功属性加成4.Name = "破境成功属性加成4";
		this.破境成功属性加成4.Size = new System.Drawing.Size(99, 21);
		this.破境成功属性加成4.TabIndex = 299;
		this.破境成功属性加成4.Tag = "4";
		this.破境成功属性加成4.Text = "点击加成配置";
		this.破境成功属性加成4.UseVisualStyleBackColor = true;
		this.增加突破几率道具4.AutoSize = true;
		this.增加突破几率道具4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.增加突破几率道具4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.增加突破几率道具4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.增加突破几率道具4.Location = new System.Drawing.Point(565, 113);
		this.增加突破几率道具4.Name = "增加突破几率道具4";
		this.增加突破几率道具4.Size = new System.Drawing.Size(99, 21);
		this.增加突破几率道具4.TabIndex = 298;
		this.增加突破几率道具4.Tag = "4";
		this.增加突破几率道具4.Text = "点击道具配置";
		this.增加突破几率道具4.UseVisualStyleBackColor = true;
		this.渡劫前置要求4.AutoSize = true;
		this.渡劫前置要求4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫前置要求4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫前置要求4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫前置要求4.Location = new System.Drawing.Point(458, 113);
		this.渡劫前置要求4.Name = "渡劫前置要求4";
		this.渡劫前置要求4.Size = new System.Drawing.Size(99, 21);
		this.渡劫前置要求4.TabIndex = 297;
		this.渡劫前置要求4.Tag = "4";
		this.渡劫前置要求4.Text = "点击要求配置";
		this.渡劫前置要求4.UseVisualStyleBackColor = true;
		this.失败惩罚4.Location = new System.Drawing.Point(376, 112);
		this.失败惩罚4.Name = "失败惩罚4";
		this.失败惩罚4.Size = new System.Drawing.Size(78, 23);
		this.失败惩罚4.TabIndex = 296;
		this.失败惩罚4.Text = "0";
		this.失败惩罚4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破几率4.Location = new System.Drawing.Point(297, 112);
		this.突破几率4.Name = "突破几率4";
		this.突破几率4.Size = new System.Drawing.Size(78, 23);
		this.突破几率4.TabIndex = 295;
		this.突破几率4.Text = "0";
		this.突破几率4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.境界突破丹药4.Location = new System.Drawing.Point(214, 112);
		this.境界突破丹药4.Name = "境界突破丹药4";
		this.境界突破丹药4.Size = new System.Drawing.Size(82, 23);
		this.境界突破丹药4.TabIndex = 294;
		this.境界突破丹药4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破灵气值4.Location = new System.Drawing.Point(131, 112);
		this.突破灵气值4.Name = "突破灵气值4";
		this.突破灵气值4.Size = new System.Drawing.Size(82, 23);
		this.突破灵气值4.TabIndex = 293;
		this.突破灵气值4.Text = "10000";
		this.突破灵气值4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label34.BackColor = System.Drawing.Color.Black;
		this.label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label34.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.label34.ForeColor = System.Drawing.Color.Yellow;
		this.label34.Location = new System.Drawing.Point(9, 89);
		this.label34.Name = "label34";
		this.label34.Size = new System.Drawing.Size(121, 23);
		this.label34.TabIndex = 292;
		this.label34.Text = "金丹境 → 元婴境";
		this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.破境横幅广播3.AutoSize = true;
		this.破境横幅广播3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境横幅广播3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境横幅广播3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境横幅广播3.Location = new System.Drawing.Point(904, 90);
		this.破境横幅广播3.Name = "破境横幅广播3";
		this.破境横幅广播3.Size = new System.Drawing.Size(75, 21);
		this.破境横幅广播3.TabIndex = 291;
		this.破境横幅广播3.Tag = "3";
		this.破境横幅广播3.Text = "点击开启";
		this.破境横幅广播3.UseVisualStyleBackColor = true;
		this.全服首次破境奖励3.AutoSize = true;
		this.全服首次破境奖励3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.全服首次破境奖励3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.全服首次破境奖励3.Location = new System.Drawing.Point(791, 90);
		this.全服首次破境奖励3.Name = "全服首次破境奖励3";
		this.全服首次破境奖励3.Size = new System.Drawing.Size(99, 21);
		this.全服首次破境奖励3.TabIndex = 290;
		this.全服首次破境奖励3.Tag = "3";
		this.全服首次破境奖励3.Text = "点击奖励配置";
		this.全服首次破境奖励3.UseVisualStyleBackColor = true;
		this.破境成功属性加成3.AutoSize = true;
		this.破境成功属性加成3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境成功属性加成3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境成功属性加成3.Location = new System.Drawing.Point(678, 90);
		this.破境成功属性加成3.Name = "破境成功属性加成3";
		this.破境成功属性加成3.Size = new System.Drawing.Size(99, 21);
		this.破境成功属性加成3.TabIndex = 289;
		this.破境成功属性加成3.Tag = "3";
		this.破境成功属性加成3.Text = "点击加成配置";
		this.破境成功属性加成3.UseVisualStyleBackColor = true;
		this.增加突破几率道具3.AutoSize = true;
		this.增加突破几率道具3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.增加突破几率道具3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.增加突破几率道具3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.增加突破几率道具3.Location = new System.Drawing.Point(565, 90);
		this.增加突破几率道具3.Name = "增加突破几率道具3";
		this.增加突破几率道具3.Size = new System.Drawing.Size(99, 21);
		this.增加突破几率道具3.TabIndex = 288;
		this.增加突破几率道具3.Tag = "3";
		this.增加突破几率道具3.Text = "点击道具配置";
		this.增加突破几率道具3.UseVisualStyleBackColor = true;
		this.渡劫前置要求3.AutoSize = true;
		this.渡劫前置要求3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫前置要求3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫前置要求3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫前置要求3.Location = new System.Drawing.Point(458, 90);
		this.渡劫前置要求3.Name = "渡劫前置要求3";
		this.渡劫前置要求3.Size = new System.Drawing.Size(99, 21);
		this.渡劫前置要求3.TabIndex = 287;
		this.渡劫前置要求3.Tag = "3";
		this.渡劫前置要求3.Text = "点击要求配置";
		this.渡劫前置要求3.UseVisualStyleBackColor = true;
		this.失败惩罚3.Location = new System.Drawing.Point(376, 89);
		this.失败惩罚3.Name = "失败惩罚3";
		this.失败惩罚3.Size = new System.Drawing.Size(78, 23);
		this.失败惩罚3.TabIndex = 286;
		this.失败惩罚3.Text = "0";
		this.失败惩罚3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破几率3.Location = new System.Drawing.Point(297, 89);
		this.突破几率3.Name = "突破几率3";
		this.突破几率3.Size = new System.Drawing.Size(78, 23);
		this.突破几率3.TabIndex = 285;
		this.突破几率3.Text = "0";
		this.突破几率3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.境界突破丹药3.Location = new System.Drawing.Point(214, 89);
		this.境界突破丹药3.Name = "境界突破丹药3";
		this.境界突破丹药3.Size = new System.Drawing.Size(82, 23);
		this.境界突破丹药3.TabIndex = 284;
		this.境界突破丹药3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破灵气值3.Location = new System.Drawing.Point(131, 89);
		this.突破灵气值3.Name = "突破灵气值3";
		this.突破灵气值3.Size = new System.Drawing.Size(82, 23);
		this.突破灵气值3.TabIndex = 283;
		this.突破灵气值3.Text = "1000";
		this.突破灵气值3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label36.BackColor = System.Drawing.Color.Black;
		this.label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label36.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.label36.ForeColor = System.Drawing.Color.Yellow;
		this.label36.Location = new System.Drawing.Point(9, 136);
		this.label36.Name = "label36";
		this.label36.Size = new System.Drawing.Size(121, 23);
		this.label36.TabIndex = 312;
		this.label36.Text = "化神境 → 炼虚境";
		this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.破境横幅广播5.AutoSize = true;
		this.破境横幅广播5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境横幅广播5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境横幅广播5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境横幅广播5.Location = new System.Drawing.Point(904, 137);
		this.破境横幅广播5.Name = "破境横幅广播5";
		this.破境横幅广播5.Size = new System.Drawing.Size(75, 21);
		this.破境横幅广播5.TabIndex = 311;
		this.破境横幅广播5.Tag = "5";
		this.破境横幅广播5.Text = "点击开启";
		this.破境横幅广播5.UseVisualStyleBackColor = true;
		this.全服首次破境奖励5.AutoSize = true;
		this.全服首次破境奖励5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.全服首次破境奖励5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.全服首次破境奖励5.Location = new System.Drawing.Point(791, 137);
		this.全服首次破境奖励5.Name = "全服首次破境奖励5";
		this.全服首次破境奖励5.Size = new System.Drawing.Size(99, 21);
		this.全服首次破境奖励5.TabIndex = 310;
		this.全服首次破境奖励5.Tag = "5";
		this.全服首次破境奖励5.Text = "点击奖励配置";
		this.全服首次破境奖励5.UseVisualStyleBackColor = true;
		this.破境成功属性加成5.AutoSize = true;
		this.破境成功属性加成5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境成功属性加成5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境成功属性加成5.Location = new System.Drawing.Point(678, 137);
		this.破境成功属性加成5.Name = "破境成功属性加成5";
		this.破境成功属性加成5.Size = new System.Drawing.Size(99, 21);
		this.破境成功属性加成5.TabIndex = 309;
		this.破境成功属性加成5.Tag = "5";
		this.破境成功属性加成5.Text = "点击加成配置";
		this.破境成功属性加成5.UseVisualStyleBackColor = true;
		this.增加突破几率道具5.AutoSize = true;
		this.增加突破几率道具5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.增加突破几率道具5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.增加突破几率道具5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.增加突破几率道具5.Location = new System.Drawing.Point(565, 137);
		this.增加突破几率道具5.Name = "增加突破几率道具5";
		this.增加突破几率道具5.Size = new System.Drawing.Size(99, 21);
		this.增加突破几率道具5.TabIndex = 308;
		this.增加突破几率道具5.Tag = "5";
		this.增加突破几率道具5.Text = "点击道具配置";
		this.增加突破几率道具5.UseVisualStyleBackColor = true;
		this.渡劫前置要求5.AutoSize = true;
		this.渡劫前置要求5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫前置要求5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫前置要求5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫前置要求5.Location = new System.Drawing.Point(458, 137);
		this.渡劫前置要求5.Name = "渡劫前置要求5";
		this.渡劫前置要求5.Size = new System.Drawing.Size(99, 21);
		this.渡劫前置要求5.TabIndex = 307;
		this.渡劫前置要求5.Tag = "5";
		this.渡劫前置要求5.Text = "点击要求配置";
		this.渡劫前置要求5.UseVisualStyleBackColor = true;
		this.失败惩罚5.Location = new System.Drawing.Point(376, 136);
		this.失败惩罚5.Name = "失败惩罚5";
		this.失败惩罚5.Size = new System.Drawing.Size(78, 23);
		this.失败惩罚5.TabIndex = 306;
		this.失败惩罚5.Text = "0";
		this.失败惩罚5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破几率5.Location = new System.Drawing.Point(297, 136);
		this.突破几率5.Name = "突破几率5";
		this.突破几率5.Size = new System.Drawing.Size(78, 23);
		this.突破几率5.TabIndex = 305;
		this.突破几率5.Text = "0";
		this.突破几率5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.境界突破丹药5.Location = new System.Drawing.Point(214, 136);
		this.境界突破丹药5.Name = "境界突破丹药5";
		this.境界突破丹药5.Size = new System.Drawing.Size(82, 23);
		this.境界突破丹药5.TabIndex = 304;
		this.境界突破丹药5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破灵气值5.Location = new System.Drawing.Point(131, 136);
		this.突破灵气值5.Name = "突破灵气值5";
		this.突破灵气值5.Size = new System.Drawing.Size(82, 23);
		this.突破灵气值5.TabIndex = 303;
		this.突破灵气值5.Text = "100000";
		this.突破灵气值5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label38.BackColor = System.Drawing.Color.Black;
		this.label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label38.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.label38.ForeColor = System.Drawing.Color.Yellow;
		this.label38.Location = new System.Drawing.Point(9, 230);
		this.label38.Name = "label38";
		this.label38.Size = new System.Drawing.Size(121, 23);
		this.label38.TabIndex = 352;
		this.label38.Text = "大乘境 → 真仙境";
		this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.破境横幅广播9.AutoSize = true;
		this.破境横幅广播9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境横幅广播9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境横幅广播9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境横幅广播9.Location = new System.Drawing.Point(904, 231);
		this.破境横幅广播9.Name = "破境横幅广播9";
		this.破境横幅广播9.Size = new System.Drawing.Size(75, 21);
		this.破境横幅广播9.TabIndex = 351;
		this.破境横幅广播9.Tag = "9";
		this.破境横幅广播9.Text = "点击开启";
		this.破境横幅广播9.UseVisualStyleBackColor = true;
		this.全服首次破境奖励9.AutoSize = true;
		this.全服首次破境奖励9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.全服首次破境奖励9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.全服首次破境奖励9.Location = new System.Drawing.Point(791, 231);
		this.全服首次破境奖励9.Name = "全服首次破境奖励9";
		this.全服首次破境奖励9.Size = new System.Drawing.Size(99, 21);
		this.全服首次破境奖励9.TabIndex = 350;
		this.全服首次破境奖励9.Tag = "9";
		this.全服首次破境奖励9.Text = "点击奖励配置";
		this.全服首次破境奖励9.UseVisualStyleBackColor = true;
		this.破境成功属性加成9.AutoSize = true;
		this.破境成功属性加成9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境成功属性加成9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境成功属性加成9.Location = new System.Drawing.Point(678, 231);
		this.破境成功属性加成9.Name = "破境成功属性加成9";
		this.破境成功属性加成9.Size = new System.Drawing.Size(99, 21);
		this.破境成功属性加成9.TabIndex = 349;
		this.破境成功属性加成9.Tag = "9";
		this.破境成功属性加成9.Text = "点击加成配置";
		this.破境成功属性加成9.UseVisualStyleBackColor = true;
		this.增加突破几率道具9.AutoSize = true;
		this.增加突破几率道具9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.增加突破几率道具9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.增加突破几率道具9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.增加突破几率道具9.Location = new System.Drawing.Point(565, 231);
		this.增加突破几率道具9.Name = "增加突破几率道具9";
		this.增加突破几率道具9.Size = new System.Drawing.Size(99, 21);
		this.增加突破几率道具9.TabIndex = 348;
		this.增加突破几率道具9.Tag = "9";
		this.增加突破几率道具9.Text = "点击道具配置";
		this.增加突破几率道具9.UseVisualStyleBackColor = true;
		this.渡劫前置要求9.AutoSize = true;
		this.渡劫前置要求9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫前置要求9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫前置要求9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫前置要求9.Location = new System.Drawing.Point(458, 231);
		this.渡劫前置要求9.Name = "渡劫前置要求9";
		this.渡劫前置要求9.Size = new System.Drawing.Size(99, 21);
		this.渡劫前置要求9.TabIndex = 347;
		this.渡劫前置要求9.Tag = "9";
		this.渡劫前置要求9.Text = "点击要求配置";
		this.渡劫前置要求9.UseVisualStyleBackColor = true;
		this.失败惩罚9.Location = new System.Drawing.Point(376, 230);
		this.失败惩罚9.Name = "失败惩罚9";
		this.失败惩罚9.Size = new System.Drawing.Size(78, 23);
		this.失败惩罚9.TabIndex = 346;
		this.失败惩罚9.Text = "0";
		this.失败惩罚9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破几率9.Location = new System.Drawing.Point(297, 230);
		this.突破几率9.Name = "突破几率9";
		this.突破几率9.Size = new System.Drawing.Size(78, 23);
		this.突破几率9.TabIndex = 345;
		this.突破几率9.Text = "0";
		this.突破几率9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.境界突破丹药9.Location = new System.Drawing.Point(214, 230);
		this.境界突破丹药9.Name = "境界突破丹药9";
		this.境界突破丹药9.Size = new System.Drawing.Size(82, 23);
		this.境界突破丹药9.TabIndex = 344;
		this.境界突破丹药9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破灵气值9.Location = new System.Drawing.Point(131, 230);
		this.突破灵气值9.Name = "突破灵气值9";
		this.突破灵气值9.Size = new System.Drawing.Size(82, 23);
		this.突破灵气值9.TabIndex = 343;
		this.突破灵气值9.Text = "1000000000";
		this.突破灵气值9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label39.BackColor = System.Drawing.Color.Black;
		this.label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label39.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.label39.ForeColor = System.Drawing.Color.Yellow;
		this.label39.Location = new System.Drawing.Point(9, 207);
		this.label39.Name = "label39";
		this.label39.Size = new System.Drawing.Size(121, 23);
		this.label39.TabIndex = 342;
		this.label39.Text = "渡劫境 → 大乘境";
		this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.破境横幅广播8.AutoSize = true;
		this.破境横幅广播8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境横幅广播8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境横幅广播8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境横幅广播8.Location = new System.Drawing.Point(904, 208);
		this.破境横幅广播8.Name = "破境横幅广播8";
		this.破境横幅广播8.Size = new System.Drawing.Size(75, 21);
		this.破境横幅广播8.TabIndex = 341;
		this.破境横幅广播8.Tag = "8";
		this.破境横幅广播8.Text = "点击开启";
		this.破境横幅广播8.UseVisualStyleBackColor = true;
		this.全服首次破境奖励8.AutoSize = true;
		this.全服首次破境奖励8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.全服首次破境奖励8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.全服首次破境奖励8.Location = new System.Drawing.Point(791, 208);
		this.全服首次破境奖励8.Name = "全服首次破境奖励8";
		this.全服首次破境奖励8.Size = new System.Drawing.Size(99, 21);
		this.全服首次破境奖励8.TabIndex = 340;
		this.全服首次破境奖励8.Tag = "8";
		this.全服首次破境奖励8.Text = "点击奖励配置";
		this.全服首次破境奖励8.UseVisualStyleBackColor = true;
		this.破境成功属性加成8.AutoSize = true;
		this.破境成功属性加成8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境成功属性加成8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境成功属性加成8.Location = new System.Drawing.Point(678, 208);
		this.破境成功属性加成8.Name = "破境成功属性加成8";
		this.破境成功属性加成8.Size = new System.Drawing.Size(99, 21);
		this.破境成功属性加成8.TabIndex = 339;
		this.破境成功属性加成8.Tag = "8";
		this.破境成功属性加成8.Text = "点击加成配置";
		this.破境成功属性加成8.UseVisualStyleBackColor = true;
		this.增加突破几率道具8.AutoSize = true;
		this.增加突破几率道具8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.增加突破几率道具8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.增加突破几率道具8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.增加突破几率道具8.Location = new System.Drawing.Point(565, 208);
		this.增加突破几率道具8.Name = "增加突破几率道具8";
		this.增加突破几率道具8.Size = new System.Drawing.Size(99, 21);
		this.增加突破几率道具8.TabIndex = 338;
		this.增加突破几率道具8.Tag = "8";
		this.增加突破几率道具8.Text = "点击道具配置";
		this.增加突破几率道具8.UseVisualStyleBackColor = true;
		this.渡劫前置要求8.AutoSize = true;
		this.渡劫前置要求8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫前置要求8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫前置要求8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫前置要求8.Location = new System.Drawing.Point(458, 208);
		this.渡劫前置要求8.Name = "渡劫前置要求8";
		this.渡劫前置要求8.Size = new System.Drawing.Size(99, 21);
		this.渡劫前置要求8.TabIndex = 337;
		this.渡劫前置要求8.Tag = "8";
		this.渡劫前置要求8.Text = "点击要求配置";
		this.渡劫前置要求8.UseVisualStyleBackColor = true;
		this.失败惩罚8.Location = new System.Drawing.Point(376, 207);
		this.失败惩罚8.Name = "失败惩罚8";
		this.失败惩罚8.Size = new System.Drawing.Size(78, 23);
		this.失败惩罚8.TabIndex = 336;
		this.失败惩罚8.Text = "0";
		this.失败惩罚8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破几率8.Location = new System.Drawing.Point(297, 207);
		this.突破几率8.Name = "突破几率8";
		this.突破几率8.Size = new System.Drawing.Size(78, 23);
		this.突破几率8.TabIndex = 335;
		this.突破几率8.Text = "0";
		this.突破几率8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.境界突破丹药8.Location = new System.Drawing.Point(214, 207);
		this.境界突破丹药8.Name = "境界突破丹药8";
		this.境界突破丹药8.Size = new System.Drawing.Size(82, 23);
		this.境界突破丹药8.TabIndex = 334;
		this.境界突破丹药8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破灵气值8.Location = new System.Drawing.Point(131, 207);
		this.突破灵气值8.Name = "突破灵气值8";
		this.突破灵气值8.Size = new System.Drawing.Size(82, 23);
		this.突破灵气值8.TabIndex = 333;
		this.突破灵气值8.Text = "100000000";
		this.突破灵气值8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label40.BackColor = System.Drawing.Color.Black;
		this.label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label40.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.label40.ForeColor = System.Drawing.Color.Yellow;
		this.label40.Location = new System.Drawing.Point(9, 183);
		this.label40.Name = "label40";
		this.label40.Size = new System.Drawing.Size(121, 23);
		this.label40.TabIndex = 332;
		this.label40.Text = "合体境 → 渡劫境";
		this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.破境横幅广播7.AutoSize = true;
		this.破境横幅广播7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境横幅广播7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境横幅广播7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境横幅广播7.Location = new System.Drawing.Point(904, 184);
		this.破境横幅广播7.Name = "破境横幅广播7";
		this.破境横幅广播7.Size = new System.Drawing.Size(75, 21);
		this.破境横幅广播7.TabIndex = 331;
		this.破境横幅广播7.Tag = "7";
		this.破境横幅广播7.Text = "点击开启";
		this.破境横幅广播7.UseVisualStyleBackColor = true;
		this.全服首次破境奖励7.AutoSize = true;
		this.全服首次破境奖励7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.全服首次破境奖励7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.全服首次破境奖励7.Location = new System.Drawing.Point(791, 184);
		this.全服首次破境奖励7.Name = "全服首次破境奖励7";
		this.全服首次破境奖励7.Size = new System.Drawing.Size(99, 21);
		this.全服首次破境奖励7.TabIndex = 330;
		this.全服首次破境奖励7.Tag = "7";
		this.全服首次破境奖励7.Text = "点击奖励配置";
		this.全服首次破境奖励7.UseVisualStyleBackColor = true;
		this.破境成功属性加成7.AutoSize = true;
		this.破境成功属性加成7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境成功属性加成7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境成功属性加成7.Location = new System.Drawing.Point(678, 184);
		this.破境成功属性加成7.Name = "破境成功属性加成7";
		this.破境成功属性加成7.Size = new System.Drawing.Size(99, 21);
		this.破境成功属性加成7.TabIndex = 329;
		this.破境成功属性加成7.Tag = "7";
		this.破境成功属性加成7.Text = "点击加成配置";
		this.破境成功属性加成7.UseVisualStyleBackColor = true;
		this.增加突破几率道具7.AutoSize = true;
		this.增加突破几率道具7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.增加突破几率道具7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.增加突破几率道具7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.增加突破几率道具7.Location = new System.Drawing.Point(565, 184);
		this.增加突破几率道具7.Name = "增加突破几率道具7";
		this.增加突破几率道具7.Size = new System.Drawing.Size(99, 21);
		this.增加突破几率道具7.TabIndex = 328;
		this.增加突破几率道具7.Tag = "7";
		this.增加突破几率道具7.Text = "点击道具配置";
		this.增加突破几率道具7.UseVisualStyleBackColor = true;
		this.渡劫前置要求7.AutoSize = true;
		this.渡劫前置要求7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫前置要求7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫前置要求7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫前置要求7.Location = new System.Drawing.Point(458, 184);
		this.渡劫前置要求7.Name = "渡劫前置要求7";
		this.渡劫前置要求7.Size = new System.Drawing.Size(99, 21);
		this.渡劫前置要求7.TabIndex = 327;
		this.渡劫前置要求7.Tag = "7";
		this.渡劫前置要求7.Text = "点击要求配置";
		this.渡劫前置要求7.UseVisualStyleBackColor = true;
		this.失败惩罚7.Location = new System.Drawing.Point(376, 183);
		this.失败惩罚7.Name = "失败惩罚7";
		this.失败惩罚7.Size = new System.Drawing.Size(78, 23);
		this.失败惩罚7.TabIndex = 326;
		this.失败惩罚7.Text = "0";
		this.失败惩罚7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破几率7.Location = new System.Drawing.Point(297, 183);
		this.突破几率7.Name = "突破几率7";
		this.突破几率7.Size = new System.Drawing.Size(78, 23);
		this.突破几率7.TabIndex = 325;
		this.突破几率7.Text = "0";
		this.突破几率7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.境界突破丹药7.Location = new System.Drawing.Point(214, 183);
		this.境界突破丹药7.Name = "境界突破丹药7";
		this.境界突破丹药7.Size = new System.Drawing.Size(82, 23);
		this.境界突破丹药7.TabIndex = 324;
		this.境界突破丹药7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破灵气值7.Location = new System.Drawing.Point(131, 183);
		this.突破灵气值7.Name = "突破灵气值7";
		this.突破灵气值7.Size = new System.Drawing.Size(82, 23);
		this.突破灵气值7.TabIndex = 323;
		this.突破灵气值7.Text = "10000000";
		this.突破灵气值7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label41.BackColor = System.Drawing.Color.Black;
		this.label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label41.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.label41.ForeColor = System.Drawing.Color.Yellow;
		this.label41.Location = new System.Drawing.Point(9, 160);
		this.label41.Name = "label41";
		this.label41.Size = new System.Drawing.Size(121, 23);
		this.label41.TabIndex = 322;
		this.label41.Text = "炼虚境 → 合体境";
		this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.破境横幅广播6.AutoSize = true;
		this.破境横幅广播6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境横幅广播6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境横幅广播6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境横幅广播6.Location = new System.Drawing.Point(904, 161);
		this.破境横幅广播6.Name = "破境横幅广播6";
		this.破境横幅广播6.Size = new System.Drawing.Size(75, 21);
		this.破境横幅广播6.TabIndex = 321;
		this.破境横幅广播6.Tag = "6";
		this.破境横幅广播6.Text = "点击开启";
		this.破境横幅广播6.UseVisualStyleBackColor = true;
		this.全服首次破境奖励6.AutoSize = true;
		this.全服首次破境奖励6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.全服首次破境奖励6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.全服首次破境奖励6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.全服首次破境奖励6.Location = new System.Drawing.Point(791, 161);
		this.全服首次破境奖励6.Name = "全服首次破境奖励6";
		this.全服首次破境奖励6.Size = new System.Drawing.Size(99, 21);
		this.全服首次破境奖励6.TabIndex = 320;
		this.全服首次破境奖励6.Tag = "6";
		this.全服首次破境奖励6.Text = "点击奖励配置";
		this.全服首次破境奖励6.UseVisualStyleBackColor = true;
		this.破境成功属性加成6.AutoSize = true;
		this.破境成功属性加成6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.破境成功属性加成6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.破境成功属性加成6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.破境成功属性加成6.Location = new System.Drawing.Point(678, 161);
		this.破境成功属性加成6.Name = "破境成功属性加成6";
		this.破境成功属性加成6.Size = new System.Drawing.Size(99, 21);
		this.破境成功属性加成6.TabIndex = 319;
		this.破境成功属性加成6.Tag = "6";
		this.破境成功属性加成6.Text = "点击加成配置";
		this.破境成功属性加成6.UseVisualStyleBackColor = true;
		this.增加突破几率道具6.AutoSize = true;
		this.增加突破几率道具6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.增加突破几率道具6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.增加突破几率道具6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.增加突破几率道具6.Location = new System.Drawing.Point(565, 161);
		this.增加突破几率道具6.Name = "增加突破几率道具6";
		this.增加突破几率道具6.Size = new System.Drawing.Size(99, 21);
		this.增加突破几率道具6.TabIndex = 318;
		this.增加突破几率道具6.Tag = "6";
		this.增加突破几率道具6.Text = "点击道具配置";
		this.增加突破几率道具6.UseVisualStyleBackColor = true;
		this.渡劫前置要求6.AutoSize = true;
		this.渡劫前置要求6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫前置要求6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.渡劫前置要求6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫前置要求6.Location = new System.Drawing.Point(458, 161);
		this.渡劫前置要求6.Name = "渡劫前置要求6";
		this.渡劫前置要求6.Size = new System.Drawing.Size(99, 21);
		this.渡劫前置要求6.TabIndex = 317;
		this.渡劫前置要求6.Tag = "6";
		this.渡劫前置要求6.Text = "点击要求配置";
		this.渡劫前置要求6.UseVisualStyleBackColor = true;
		this.失败惩罚6.Location = new System.Drawing.Point(376, 160);
		this.失败惩罚6.Name = "失败惩罚6";
		this.失败惩罚6.Size = new System.Drawing.Size(78, 23);
		this.失败惩罚6.TabIndex = 316;
		this.失败惩罚6.Text = "0";
		this.失败惩罚6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破几率6.Location = new System.Drawing.Point(297, 160);
		this.突破几率6.Name = "突破几率6";
		this.突破几率6.Size = new System.Drawing.Size(78, 23);
		this.突破几率6.TabIndex = 315;
		this.突破几率6.Text = "0";
		this.突破几率6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.境界突破丹药6.Location = new System.Drawing.Point(214, 160);
		this.境界突破丹药6.Name = "境界突破丹药6";
		this.境界突破丹药6.Size = new System.Drawing.Size(82, 23);
		this.境界突破丹药6.TabIndex = 314;
		this.境界突破丹药6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.突破灵气值6.Location = new System.Drawing.Point(131, 160);
		this.突破灵气值6.Name = "突破灵气值6";
		this.突破灵气值6.Size = new System.Drawing.Size(82, 23);
		this.突破灵气值6.TabIndex = 313;
		this.突破灵气值6.Text = "1000000";
		this.突破灵气值6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.境界列表确定按钮.BackColor = System.Drawing.Color.White;
		this.境界列表确定按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.境界列表确定按钮.Location = new System.Drawing.Point(323, 269);
		this.境界列表确定按钮.Name = "境界列表确定按钮";
		this.境界列表确定按钮.Size = new System.Drawing.Size(285, 30);
		this.境界列表确定按钮.TabIndex = 353;
		this.境界列表确定按钮.Text = "更新元神系统各个境界突破配置";
		this.境界列表确定按钮.UseVisualStyleBackColor = false;
		this.境界列表确定按钮.Click += new System.EventHandler(境界列表确定按钮_Click);
		this.渡劫额外要求配置块_破境BOSS只需击杀一次.AutoSize = true;
		this.渡劫额外要求配置块_破境BOSS只需击杀一次.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.渡劫额外要求配置块_破境BOSS只需击杀一次.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.渡劫额外要求配置块_破境BOSS只需击杀一次.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.渡劫额外要求配置块_破境BOSS只需击杀一次.Location = new System.Drawing.Point(12, 131);
		this.渡劫额外要求配置块_破境BOSS只需击杀一次.Name = "渡劫额外要求配置块_破境BOSS只需击杀一次";
		this.渡劫额外要求配置块_破境BOSS只需击杀一次.Size = new System.Drawing.Size(155, 21);
		this.渡劫额外要求配置块_破境BOSS只需击杀一次.TabIndex = 273;
		this.渡劫额外要求配置块_破境BOSS只需击杀一次.Text = "破境BOSS只需击杀一次";
		this.渡劫额外要求配置块_破境BOSS只需击杀一次.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		base.ClientSize = new System.Drawing.Size(984, 699);
		base.Controls.Add(this.全服首次破境奖励配置块);
		base.Controls.Add(this.破境成功属性加成配置块);
		base.Controls.Add(this.增加突破几率道具配置块);
		base.Controls.Add(this.渡劫额外要求配置块);
		base.Controls.Add(this.境界列表确定按钮);
		base.Controls.Add(this.label38);
		base.Controls.Add(this.破境横幅广播9);
		base.Controls.Add(this.全服首次破境奖励9);
		base.Controls.Add(this.破境成功属性加成9);
		base.Controls.Add(this.增加突破几率道具9);
		base.Controls.Add(this.渡劫前置要求9);
		base.Controls.Add(this.失败惩罚9);
		base.Controls.Add(this.突破几率9);
		base.Controls.Add(this.境界突破丹药9);
		base.Controls.Add(this.突破灵气值9);
		base.Controls.Add(this.label39);
		base.Controls.Add(this.破境横幅广播8);
		base.Controls.Add(this.全服首次破境奖励8);
		base.Controls.Add(this.破境成功属性加成8);
		base.Controls.Add(this.增加突破几率道具8);
		base.Controls.Add(this.渡劫前置要求8);
		base.Controls.Add(this.失败惩罚8);
		base.Controls.Add(this.突破几率8);
		base.Controls.Add(this.境界突破丹药8);
		base.Controls.Add(this.突破灵气值8);
		base.Controls.Add(this.label40);
		base.Controls.Add(this.破境横幅广播7);
		base.Controls.Add(this.全服首次破境奖励7);
		base.Controls.Add(this.破境成功属性加成7);
		base.Controls.Add(this.增加突破几率道具7);
		base.Controls.Add(this.渡劫前置要求7);
		base.Controls.Add(this.失败惩罚7);
		base.Controls.Add(this.突破几率7);
		base.Controls.Add(this.境界突破丹药7);
		base.Controls.Add(this.突破灵气值7);
		base.Controls.Add(this.label41);
		base.Controls.Add(this.破境横幅广播6);
		base.Controls.Add(this.全服首次破境奖励6);
		base.Controls.Add(this.破境成功属性加成6);
		base.Controls.Add(this.增加突破几率道具6);
		base.Controls.Add(this.渡劫前置要求6);
		base.Controls.Add(this.失败惩罚6);
		base.Controls.Add(this.突破几率6);
		base.Controls.Add(this.境界突破丹药6);
		base.Controls.Add(this.突破灵气值6);
		base.Controls.Add(this.label36);
		base.Controls.Add(this.破境横幅广播5);
		base.Controls.Add(this.全服首次破境奖励5);
		base.Controls.Add(this.破境成功属性加成5);
		base.Controls.Add(this.增加突破几率道具5);
		base.Controls.Add(this.渡劫前置要求5);
		base.Controls.Add(this.失败惩罚5);
		base.Controls.Add(this.突破几率5);
		base.Controls.Add(this.境界突破丹药5);
		base.Controls.Add(this.突破灵气值5);
		base.Controls.Add(this.label26);
		base.Controls.Add(this.破境横幅广播4);
		base.Controls.Add(this.全服首次破境奖励4);
		base.Controls.Add(this.破境成功属性加成4);
		base.Controls.Add(this.增加突破几率道具4);
		base.Controls.Add(this.渡劫前置要求4);
		base.Controls.Add(this.失败惩罚4);
		base.Controls.Add(this.突破几率4);
		base.Controls.Add(this.境界突破丹药4);
		base.Controls.Add(this.突破灵气值4);
		base.Controls.Add(this.label34);
		base.Controls.Add(this.破境横幅广播3);
		base.Controls.Add(this.全服首次破境奖励3);
		base.Controls.Add(this.破境成功属性加成3);
		base.Controls.Add(this.增加突破几率道具3);
		base.Controls.Add(this.渡劫前置要求3);
		base.Controls.Add(this.失败惩罚3);
		base.Controls.Add(this.突破几率3);
		base.Controls.Add(this.境界突破丹药3);
		base.Controls.Add(this.突破灵气值3);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.破境横幅广播2);
		base.Controls.Add(this.全服首次破境奖励2);
		base.Controls.Add(this.破境成功属性加成2);
		base.Controls.Add(this.增加突破几率道具2);
		base.Controls.Add(this.渡劫前置要求2);
		base.Controls.Add(this.失败惩罚2);
		base.Controls.Add(this.突破几率2);
		base.Controls.Add(this.境界突破丹药2);
		base.Controls.Add(this.突破灵气值2);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.破境横幅广播1);
		base.Controls.Add(this.label9);
		base.Controls.Add(this.全服首次破境奖励1);
		base.Controls.Add(this.label21);
		base.Controls.Add(this.破境成功属性加成1);
		base.Controls.Add(this.label20);
		base.Controls.Add(this.增加突破几率道具1);
		base.Controls.Add(this.label19);
		base.Controls.Add(this.渡劫前置要求1);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.失败惩罚1);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.突破几率1);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.境界突破丹药1);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.突破灵气值1);
		base.Controls.Add(this.label4);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
		base.MaximizeBox = false;
		base.Name = "元神_境界列表配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "元神_境界列表配置窗口";
		base.Load += new System.EventHandler(元神_境界列表配置窗口_Load);
		this.渡劫额外要求配置块.ResumeLayout(false);
		this.渡劫额外要求配置块.PerformLayout();
		this.增加突破几率道具配置块.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.增加突破几率道具配置块_增加突破几率道具).EndInit();
		this.破境成功属性加成配置块.ResumeLayout(false);
		this.破境成功属性加成配置块.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_法力).EndInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_气血).EndInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_速度).EndInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_防御).EndInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_法术伤害).EndInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_物理伤害).EndInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_所有属性).EndInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_所有相性).EndInit();
		((System.ComponentModel.ISupportInitialize)this.破境成功属性加成配置块_奖励数量).EndInit();
		this.全服首次破境奖励配置块.ResumeLayout(false);
		this.全服首次破境奖励配置块.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.全服首次破境奖励配置块_技能等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.全服首次破境奖励配置块_奖励声望).EndInit();
		((System.ComponentModel.ISupportInitialize)this.全服首次破境奖励配置块_奖励道行).EndInit();
		((System.ComponentModel.ISupportInitialize)this.全服首次破境奖励配置块_奖励游戏币).EndInit();
		((System.ComponentModel.ISupportInitialize)this.全服首次破境奖励配置块_奖励银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.全服首次破境奖励配置块_奖励金元宝).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
