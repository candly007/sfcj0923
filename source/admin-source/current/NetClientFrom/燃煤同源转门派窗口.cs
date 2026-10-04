using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 燃煤同源转门派窗口 : Form
{
	private static 燃煤同源转门派窗口 i;

	private IContainer components;

	private GroupBox groupBox1;

	private CheckBox 燃眉_开关;

	private Button 燃眉_重载按钮;

	private Button 燃眉_保存按钮;

	private Label label4;

	private NumericUpDown 燃眉_五星几率;

	private Label label10;

	private NumericUpDown 燃眉_日产数量;

	private Label label9;

	private NumericUpDown 燃眉_超级价格;

	private Label label8;

	private NumericUpDown 燃眉_高级价格;

	private Label label7;

	private NumericUpDown 燃眉_常规价格;

	private Label label3;

	private NumericUpDown 燃眉_每日可做;

	private Label label5;

	private NumericUpDown 燃眉_葫芦几率;

	private Label label6;

	private NumericUpDown 燃眉_二星几率;

	private Label label2;

	private NumericUpDown 燃眉_三星几率;

	private Label label1;

	private NumericUpDown 燃眉_四星几率;

	private Label label11;

	private TextBox 燃眉_托号昵称;

	private Label label12;

	private GroupBox groupBox2;

	private CheckBox 转门派_妖族门派开关;

	private CheckBox 转门派_新门派开关;

	private Label label20;

	private Label label21;

	private Label label22;

	private Label label23;

	private Label label24;

	private Button 转门派_重载配置按钮;

	private Button 转门派_保存配置按钮;

	private CheckBox 转门派_开关;

	private TextBox 转门派_新土对话;

	private TextBox 转门派_新火对话;

	private TextBox 转门派_新水对话;

	private TextBox 转门派_新木对话;

	private TextBox 转门派_新金对话;

	private Label label13;

	private Label label14;

	private Label label15;

	private Label label16;

	private Label label17;

	private TextBox 转门派_老土对话;

	private TextBox 转门派_老火对话;

	private TextBox 转门派_老水对话;

	private TextBox 转门派_老木对话;

	private TextBox 转门派_老金对话;

	private Label label19;

	private ComboBox 转门派_消耗类型;

	private Label label18;

	private NumericUpDown 转门派_消耗价格;

	private GroupBox groupBox3;

	private ComboBox 同源_普通宠物转属类型;

	private Label label28;

	private Label label27;

	private NumericUpDown 同源_普通宠物激活成长;

	private Label label26;

	private NumericUpDown 同源_普通宠物同源次数;

	private Label label25;

	private NumericUpDown 同源_普通宠物同源成长;

	private CheckBox 同源_普通宠物开关;

	private NumericUpDown 同源_普通宠物激活消耗;

	private ComboBox 同源_普通宠物激活类型;

	private Label label31;

	private NumericUpDown 同源_普通宠物转属消耗;

	private Label label29;

	private Button 同源_重载配置按钮;

	private Button 同源_保存配置按钮;

	private Label label52;

	private Label label51;

	private TextBox 同源_托号昵称;

	private NumericUpDown 同源_仙元宠物激活消耗;

	private ComboBox 同源_仙元宠物激活类型;

	private Label label46;

	private NumericUpDown 同源_仙元宠物转属消耗;

	private ComboBox 同源_仙元宠物转属类型;

	private Label label47;

	private Label label48;

	private NumericUpDown 同源_仙元宠物激活成长;

	private Label label49;

	private NumericUpDown 同源_仙元宠物同源次数;

	private Label label50;

	private NumericUpDown 同源_仙元宠物同源成长;

	private CheckBox 同源_仙元宠物开关;

	private NumericUpDown 同源_元灵宠物激活消耗;

	private ComboBox 同源_元灵宠物激活类型;

	private Label label41;

	private NumericUpDown 同源_元灵宠物转属消耗;

	private ComboBox 同源_元灵宠物转属类型;

	private Label label42;

	private Label label43;

	private NumericUpDown 同源_元灵宠物激活成长;

	private Label label44;

	private NumericUpDown 同源_元灵宠物同源次数;

	private Label label45;

	private NumericUpDown 同源_元灵宠物同源成长;

	private CheckBox 同源_元灵宠物开关;

	private NumericUpDown 同源_神兽宠物激活消耗;

	private ComboBox 同源_神兽宠物激活类型;

	private Label label36;

	private NumericUpDown 同源_神兽宠物转属消耗;

	private ComboBox 同源_神兽宠物转属类型;

	private Label label37;

	private Label label38;

	private NumericUpDown 同源_神兽宠物激活成长;

	private Label label39;

	private NumericUpDown 同源_神兽宠物同源次数;

	private Label label40;

	private NumericUpDown 同源_神兽宠物同源成长;

	private CheckBox 同源_神兽宠物开关;

	private NumericUpDown 同源_变异宠物激活消耗;

	private ComboBox 同源_变异宠物激活类型;

	private Label label30;

	private NumericUpDown 同源_变异宠物转属消耗;

	private ComboBox 同源_变异宠物转属类型;

	private Label label32;

	private Label label33;

	private NumericUpDown 同源_变异宠物激活成长;

	private Label label34;

	private NumericUpDown 同源_变异宠物同源次数;

	private Label label35;

	private NumericUpDown 同源_变异宠物同源成长;

	private CheckBox 同源_变异宠物开关;

	private CheckBox 同源_开关;

	private CheckBox 同源_托号成长类型一致;

	private Label label53;

	private NumericUpDown 同源_托号同源成长百分比;

	public static 燃煤同源转门派窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 燃煤同源转门派窗口();
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

	public 燃煤同源转门派窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 燃煤同源转门派窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		燃眉_重载按钮_Click(sender, e);
		转门派_重载配置按钮_Click(sender, e);
		同源_重载配置按钮_Click(sender, e);
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (base.IsHandleCreated)
		{
			switch (配置类型)
			{
			case 16:
				燃眉_界面组件赋值();
				break;
			case 18:
				转门派_界面组件赋值();
				break;
			case 17:
				同源_界面组件赋值();
				break;
			}
		}
	}

	private void 燃眉_界面组件赋值()
	{
		if (base.IsHandleCreated)
		{
			燃眉_开关.Checked = Singleton<全局变量类>.I.燃眉配置.功能开关;
			燃眉_五星几率.Value = Singleton<全局变量类>.I.燃眉配置.五星概率;
			燃眉_四星几率.Value = Singleton<全局变量类>.I.燃眉配置.四星概率;
			燃眉_三星几率.Value = Singleton<全局变量类>.I.燃眉配置.三星概率;
			燃眉_二星几率.Value = Singleton<全局变量类>.I.燃眉配置.二星概率;
			燃眉_葫芦几率.Value = Singleton<全局变量类>.I.燃眉配置.葫芦概率;
			燃眉_每日可做.Value = Singleton<全局变量类>.I.燃眉配置.每日次数;
			燃眉_常规价格.Value = Singleton<全局变量类>.I.燃眉配置.常规价格;
			燃眉_高级价格.Value = Singleton<全局变量类>.I.燃眉配置.高级价格;
			燃眉_超级价格.Value = Singleton<全局变量类>.I.燃眉配置.超级价格;
			燃眉_日产数量.Value = Singleton<全局变量类>.I.燃眉配置.每日紫帝晶数量;
			燃眉_托号昵称.Text = Singleton<全局变量类>.I.燃眉配置.托号角色;
		}
	}

	private void 燃眉_配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.燃眉配置.功能开关 = 燃眉_开关.Checked;
			Singleton<全局变量类>.I.燃眉配置.五星概率 = (int)燃眉_五星几率.Value;
			Singleton<全局变量类>.I.燃眉配置.四星概率 = (int)燃眉_四星几率.Value;
			Singleton<全局变量类>.I.燃眉配置.三星概率 = (int)燃眉_三星几率.Value;
			Singleton<全局变量类>.I.燃眉配置.二星概率 = (int)燃眉_二星几率.Value;
			Singleton<全局变量类>.I.燃眉配置.葫芦概率 = (int)燃眉_葫芦几率.Value;
			Singleton<全局变量类>.I.燃眉配置.每日次数 = (int)燃眉_每日可做.Value;
			Singleton<全局变量类>.I.燃眉配置.常规价格 = (int)燃眉_常规价格.Value;
			Singleton<全局变量类>.I.燃眉配置.高级价格 = (int)燃眉_高级价格.Value;
			Singleton<全局变量类>.I.燃眉配置.超级价格 = (int)燃眉_超级价格.Value;
			Singleton<全局变量类>.I.燃眉配置.每日紫帝晶数量 = (int)燃眉_日产数量.Value;
			Singleton<全局变量类>.I.燃眉配置.托号角色 = 燃眉_托号昵称.Text;
		}
	}

	private void 燃眉_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			燃眉_配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 16, JsonConvert.SerializeObject(Singleton<全局变量类>.I.燃眉配置, Formatting.Indented));
		}
	}

	private void 燃眉_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 16);
		}
	}

	private void 转门派_界面组件赋值()
	{
		if (base.IsHandleCreated)
		{
			转门派_开关.Checked = Singleton<全局变量类>.I.门派转换配置.功能开关;
			转门派_新门派开关.Checked = Singleton<全局变量类>.I.门派转换配置.is新角色;
			转门派_妖族门派开关.Checked = Singleton<全局变量类>.I.门派转换配置.is四妖族;
			转门派_老金对话.Text = Singleton<全局变量类>.I.门派转换配置.老金门派;
			转门派_老木对话.Text = Singleton<全局变量类>.I.门派转换配置.老木门派;
			转门派_老水对话.Text = Singleton<全局变量类>.I.门派转换配置.老水门派;
			转门派_老火对话.Text = Singleton<全局变量类>.I.门派转换配置.老火门派;
			转门派_老土对话.Text = Singleton<全局变量类>.I.门派转换配置.老土门派;
			转门派_新金对话.Text = Singleton<全局变量类>.I.门派转换配置.新金门派;
			转门派_新木对话.Text = Singleton<全局变量类>.I.门派转换配置.新木门派;
			转门派_新水对话.Text = Singleton<全局变量类>.I.门派转换配置.新水门派;
			转门派_新火对话.Text = Singleton<全局变量类>.I.门派转换配置.新火门派;
			转门派_新土对话.Text = Singleton<全局变量类>.I.门派转换配置.新土门派;
			转门派_消耗类型.Text = Singleton<全局变量类>.I.门派转换配置.消耗类型.ToString();
			转门派_消耗价格.Value = Singleton<全局变量类>.I.门派转换配置.转换消耗;
		}
	}

	private void 转门派_配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.门派转换配置.功能开关 = 转门派_开关.Checked;
			Singleton<全局变量类>.I.门派转换配置.is新角色 = 转门派_新门派开关.Checked;
			Singleton<全局变量类>.I.门派转换配置.is四妖族 = 转门派_妖族门派开关.Checked;
			Singleton<全局变量类>.I.门派转换配置.老金门派 = 转门派_老金对话.Text;
			Singleton<全局变量类>.I.门派转换配置.老木门派 = 转门派_老木对话.Text;
			Singleton<全局变量类>.I.门派转换配置.老水门派 = 转门派_老水对话.Text;
			Singleton<全局变量类>.I.门派转换配置.老火门派 = 转门派_老火对话.Text;
			Singleton<全局变量类>.I.门派转换配置.老土门派 = 转门派_老土对话.Text;
			Singleton<全局变量类>.I.门派转换配置.新金门派 = 转门派_新金对话.Text;
			Singleton<全局变量类>.I.门派转换配置.新木门派 = 转门派_新木对话.Text;
			Singleton<全局变量类>.I.门派转换配置.新水门派 = 转门派_新水对话.Text;
			Singleton<全局变量类>.I.门派转换配置.新火门派 = 转门派_新火对话.Text;
			Singleton<全局变量类>.I.门派转换配置.新土门派 = 转门派_新土对话.Text;
			Enum.TryParse<AllEnums.数值Type>(转门派_消耗类型.Text, out Singleton<全局变量类>.I.门派转换配置.消耗类型);
			Singleton<全局变量类>.I.门派转换配置.转换消耗 = (int)转门派_消耗价格.Value;
		}
	}

	private void 转门派_保存配置按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			转门派_配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 18, JsonConvert.SerializeObject(Singleton<全局变量类>.I.门派转换配置, Formatting.Indented));
		}
	}

	private void 转门派_重载配置按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 18);
		}
	}

	private void 同源_界面组件赋值()
	{
		if (base.IsHandleCreated)
		{
			同源_开关.Checked = Singleton<全局变量类>.I.宠物同源配置.功能开关;
			同源_托号成长类型一致.Checked = Singleton<全局变量类>.I.宠物同源配置.托号成长类型一致;
			同源_托号同源成长百分比.Value = Singleton<全局变量类>.I.宠物同源配置.托号同源成长百分比;
			同源_托号昵称.Text = Singleton<全局变量类>.I.宠物同源配置.托号角色;
			同源_普通宠物开关.Checked = Singleton<全局变量类>.I.宠物同源配置.is普通同源;
			同源_普通宠物同源成长.Value = Singleton<全局变量类>.I.宠物同源配置.普通同源成长;
			同源_普通宠物同源次数.Value = Singleton<全局变量类>.I.宠物同源配置.普通转属次数;
			同源_普通宠物激活成长.Value = Singleton<全局变量类>.I.宠物同源配置.普通激活成长;
			同源_普通宠物转属类型.Text = Singleton<全局变量类>.I.宠物同源配置.普通转属类型.ToString();
			同源_普通宠物转属消耗.Value = Singleton<全局变量类>.I.宠物同源配置.普通转属价格;
			同源_普通宠物激活类型.Text = Singleton<全局变量类>.I.宠物同源配置.普通激活类型.ToString();
			同源_普通宠物激活消耗.Value = Singleton<全局变量类>.I.宠物同源配置.普通激活价格;
			同源_变异宠物开关.Checked = Singleton<全局变量类>.I.宠物同源配置.is变异同源;
			同源_变异宠物同源成长.Value = Singleton<全局变量类>.I.宠物同源配置.变异同源成长;
			同源_变异宠物同源次数.Value = Singleton<全局变量类>.I.宠物同源配置.变异转属次数;
			同源_变异宠物激活成长.Value = Singleton<全局变量类>.I.宠物同源配置.变异激活成长;
			同源_变异宠物转属类型.Text = Singleton<全局变量类>.I.宠物同源配置.变异转属类型.ToString();
			同源_变异宠物转属消耗.Value = Singleton<全局变量类>.I.宠物同源配置.变异转属价格;
			同源_变异宠物激活类型.Text = Singleton<全局变量类>.I.宠物同源配置.变异激活类型.ToString();
			同源_变异宠物激活消耗.Value = Singleton<全局变量类>.I.宠物同源配置.变异激活价格;
			同源_神兽宠物开关.Checked = Singleton<全局变量类>.I.宠物同源配置.is神兽同源;
			同源_神兽宠物同源成长.Value = Singleton<全局变量类>.I.宠物同源配置.神兽同源成长;
			同源_神兽宠物同源次数.Value = Singleton<全局变量类>.I.宠物同源配置.神兽转属次数;
			同源_神兽宠物激活成长.Value = Singleton<全局变量类>.I.宠物同源配置.神兽激活成长;
			同源_神兽宠物转属类型.Text = Singleton<全局变量类>.I.宠物同源配置.神兽转属类型.ToString();
			同源_神兽宠物转属消耗.Value = Singleton<全局变量类>.I.宠物同源配置.神兽转属价格;
			同源_神兽宠物激活类型.Text = Singleton<全局变量类>.I.宠物同源配置.神兽激活类型.ToString();
			同源_神兽宠物激活消耗.Value = Singleton<全局变量类>.I.宠物同源配置.神兽激活价格;
			同源_元灵宠物开关.Checked = Singleton<全局变量类>.I.宠物同源配置.is元灵同源;
			同源_元灵宠物同源成长.Value = Singleton<全局变量类>.I.宠物同源配置.元灵同源成长;
			同源_元灵宠物同源次数.Value = Singleton<全局变量类>.I.宠物同源配置.元灵转属次数;
			同源_元灵宠物激活成长.Value = Singleton<全局变量类>.I.宠物同源配置.元灵激活成长;
			同源_元灵宠物转属类型.Text = Singleton<全局变量类>.I.宠物同源配置.元灵转属类型.ToString();
			同源_元灵宠物转属消耗.Value = Singleton<全局变量类>.I.宠物同源配置.元灵转属价格;
			同源_元灵宠物激活类型.Text = Singleton<全局变量类>.I.宠物同源配置.元灵激活类型.ToString();
			同源_元灵宠物激活消耗.Value = Singleton<全局变量类>.I.宠物同源配置.元灵激活价格;
			同源_仙元宠物开关.Checked = Singleton<全局变量类>.I.宠物同源配置.is仙元同源;
			同源_仙元宠物同源成长.Value = Singleton<全局变量类>.I.宠物同源配置.仙元同源成长;
			同源_仙元宠物同源次数.Value = Singleton<全局变量类>.I.宠物同源配置.仙元转属次数;
			同源_仙元宠物激活成长.Value = Singleton<全局变量类>.I.宠物同源配置.仙元激活成长;
			同源_仙元宠物转属类型.Text = Singleton<全局变量类>.I.宠物同源配置.仙元转属类型.ToString();
			同源_仙元宠物转属消耗.Value = Singleton<全局变量类>.I.宠物同源配置.仙元转属价格;
			同源_仙元宠物激活类型.Text = Singleton<全局变量类>.I.宠物同源配置.仙元激活类型.ToString();
			同源_仙元宠物激活消耗.Value = Singleton<全局变量类>.I.宠物同源配置.仙元激活价格;
		}
	}

	private void 同源_配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.宠物同源配置.功能开关 = 同源_开关.Checked;
			Singleton<全局变量类>.I.宠物同源配置.托号成长类型一致 = 同源_托号成长类型一致.Checked;
			Singleton<全局变量类>.I.宠物同源配置.托号同源成长百分比 = (int)同源_托号同源成长百分比.Value;
			Singleton<全局变量类>.I.宠物同源配置.托号角色 = 同源_托号昵称.Text;
			Singleton<全局变量类>.I.宠物同源配置.is普通同源 = 同源_普通宠物开关.Checked;
			Singleton<全局变量类>.I.宠物同源配置.普通同源成长 = (int)同源_普通宠物同源成长.Value;
			Singleton<全局变量类>.I.宠物同源配置.普通转属次数 = (int)同源_普通宠物同源次数.Value;
			Singleton<全局变量类>.I.宠物同源配置.普通激活成长 = (int)同源_普通宠物激活成长.Value;
			Enum.TryParse<AllEnums.数值Type>(同源_普通宠物转属类型.Text, out Singleton<全局变量类>.I.宠物同源配置.普通转属类型);
			Singleton<全局变量类>.I.宠物同源配置.普通转属价格 = (int)同源_普通宠物转属消耗.Value;
			Enum.TryParse<AllEnums.数值Type>(同源_普通宠物激活类型.Text, out Singleton<全局变量类>.I.宠物同源配置.普通激活类型);
			Singleton<全局变量类>.I.宠物同源配置.普通激活价格 = (int)同源_普通宠物激活消耗.Value;
			Singleton<全局变量类>.I.宠物同源配置.is变异同源 = 同源_变异宠物开关.Checked;
			Singleton<全局变量类>.I.宠物同源配置.变异同源成长 = (int)同源_变异宠物同源成长.Value;
			Singleton<全局变量类>.I.宠物同源配置.变异转属次数 = (int)同源_变异宠物同源次数.Value;
			Singleton<全局变量类>.I.宠物同源配置.变异激活成长 = (int)同源_变异宠物激活成长.Value;
			Enum.TryParse<AllEnums.数值Type>(同源_变异宠物转属类型.Text, out Singleton<全局变量类>.I.宠物同源配置.变异转属类型);
			Singleton<全局变量类>.I.宠物同源配置.变异转属价格 = (int)同源_变异宠物转属消耗.Value;
			Enum.TryParse<AllEnums.数值Type>(同源_变异宠物激活类型.Text, out Singleton<全局变量类>.I.宠物同源配置.变异激活类型);
			Singleton<全局变量类>.I.宠物同源配置.变异激活价格 = (int)同源_变异宠物激活消耗.Value;
			Singleton<全局变量类>.I.宠物同源配置.is神兽同源 = 同源_神兽宠物开关.Checked;
			Singleton<全局变量类>.I.宠物同源配置.神兽同源成长 = (int)同源_神兽宠物同源成长.Value;
			Singleton<全局变量类>.I.宠物同源配置.神兽转属次数 = (int)同源_神兽宠物同源次数.Value;
			Singleton<全局变量类>.I.宠物同源配置.神兽激活成长 = (int)同源_神兽宠物激活成长.Value;
			Enum.TryParse<AllEnums.数值Type>(同源_神兽宠物转属类型.Text, out Singleton<全局变量类>.I.宠物同源配置.神兽转属类型);
			Singleton<全局变量类>.I.宠物同源配置.神兽转属价格 = (int)同源_神兽宠物转属消耗.Value;
			Enum.TryParse<AllEnums.数值Type>(同源_神兽宠物激活类型.Text, out Singleton<全局变量类>.I.宠物同源配置.神兽激活类型);
			Singleton<全局变量类>.I.宠物同源配置.神兽激活价格 = (int)同源_神兽宠物激活消耗.Value;
			Singleton<全局变量类>.I.宠物同源配置.is元灵同源 = 同源_元灵宠物开关.Checked;
			Singleton<全局变量类>.I.宠物同源配置.元灵同源成长 = (int)同源_元灵宠物同源成长.Value;
			Singleton<全局变量类>.I.宠物同源配置.元灵转属次数 = (int)同源_元灵宠物同源次数.Value;
			Singleton<全局变量类>.I.宠物同源配置.元灵激活成长 = (int)同源_元灵宠物激活成长.Value;
			Enum.TryParse<AllEnums.数值Type>(同源_元灵宠物转属类型.Text, out Singleton<全局变量类>.I.宠物同源配置.元灵转属类型);
			Singleton<全局变量类>.I.宠物同源配置.元灵转属价格 = (int)同源_元灵宠物转属消耗.Value;
			Enum.TryParse<AllEnums.数值Type>(同源_元灵宠物激活类型.Text, out Singleton<全局变量类>.I.宠物同源配置.元灵激活类型);
			Singleton<全局变量类>.I.宠物同源配置.元灵激活价格 = (int)同源_元灵宠物激活消耗.Value;
			Singleton<全局变量类>.I.宠物同源配置.is仙元同源 = 同源_仙元宠物开关.Checked;
			Singleton<全局变量类>.I.宠物同源配置.仙元同源成长 = (int)同源_仙元宠物同源成长.Value;
			Singleton<全局变量类>.I.宠物同源配置.仙元转属次数 = (int)同源_仙元宠物同源次数.Value;
			Singleton<全局变量类>.I.宠物同源配置.仙元激活成长 = (int)同源_仙元宠物激活成长.Value;
			Enum.TryParse<AllEnums.数值Type>(同源_仙元宠物转属类型.Text, out Singleton<全局变量类>.I.宠物同源配置.仙元转属类型);
			Singleton<全局变量类>.I.宠物同源配置.仙元转属价格 = (int)同源_仙元宠物转属消耗.Value;
			Enum.TryParse<AllEnums.数值Type>(同源_仙元宠物激活类型.Text, out Singleton<全局变量类>.I.宠物同源配置.仙元激活类型);
			Singleton<全局变量类>.I.宠物同源配置.仙元激活价格 = (int)同源_仙元宠物激活消耗.Value;
		}
	}

	private void 同源_保存配置按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			同源_配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 17, JsonConvert.SerializeObject(Singleton<全局变量类>.I.宠物同源配置, Formatting.Indented));
		}
	}

	private void 同源_重载配置按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 17);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.燃煤同源转门派窗口));
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label12 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.燃眉_托号昵称 = new System.Windows.Forms.TextBox();
		this.label10 = new System.Windows.Forms.Label();
		this.燃眉_日产数量 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.燃眉_超级价格 = new System.Windows.Forms.NumericUpDown();
		this.label8 = new System.Windows.Forms.Label();
		this.燃眉_高级价格 = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.燃眉_常规价格 = new System.Windows.Forms.NumericUpDown();
		this.label3 = new System.Windows.Forms.Label();
		this.燃眉_每日可做 = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.燃眉_葫芦几率 = new System.Windows.Forms.NumericUpDown();
		this.label6 = new System.Windows.Forms.Label();
		this.燃眉_二星几率 = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.燃眉_三星几率 = new System.Windows.Forms.NumericUpDown();
		this.label1 = new System.Windows.Forms.Label();
		this.燃眉_四星几率 = new System.Windows.Forms.NumericUpDown();
		this.label4 = new System.Windows.Forms.Label();
		this.燃眉_五星几率 = new System.Windows.Forms.NumericUpDown();
		this.燃眉_重载按钮 = new System.Windows.Forms.Button();
		this.燃眉_保存按钮 = new System.Windows.Forms.Button();
		this.燃眉_开关 = new System.Windows.Forms.CheckBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.label29 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.转门派_消耗类型 = new System.Windows.Forms.ComboBox();
		this.label18 = new System.Windows.Forms.Label();
		this.转门派_消耗价格 = new System.Windows.Forms.NumericUpDown();
		this.转门派_新土对话 = new System.Windows.Forms.TextBox();
		this.转门派_新火对话 = new System.Windows.Forms.TextBox();
		this.转门派_新水对话 = new System.Windows.Forms.TextBox();
		this.转门派_新木对话 = new System.Windows.Forms.TextBox();
		this.转门派_新金对话 = new System.Windows.Forms.TextBox();
		this.label13 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.转门派_老土对话 = new System.Windows.Forms.TextBox();
		this.转门派_老火对话 = new System.Windows.Forms.TextBox();
		this.转门派_老水对话 = new System.Windows.Forms.TextBox();
		this.转门派_老木对话 = new System.Windows.Forms.TextBox();
		this.转门派_老金对话 = new System.Windows.Forms.TextBox();
		this.转门派_妖族门派开关 = new System.Windows.Forms.CheckBox();
		this.转门派_新门派开关 = new System.Windows.Forms.CheckBox();
		this.label20 = new System.Windows.Forms.Label();
		this.label21 = new System.Windows.Forms.Label();
		this.label22 = new System.Windows.Forms.Label();
		this.label23 = new System.Windows.Forms.Label();
		this.label24 = new System.Windows.Forms.Label();
		this.转门派_重载配置按钮 = new System.Windows.Forms.Button();
		this.转门派_保存配置按钮 = new System.Windows.Forms.Button();
		this.转门派_开关 = new System.Windows.Forms.CheckBox();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.同源_开关 = new System.Windows.Forms.CheckBox();
		this.同源_重载配置按钮 = new System.Windows.Forms.Button();
		this.同源_保存配置按钮 = new System.Windows.Forms.Button();
		this.label52 = new System.Windows.Forms.Label();
		this.label51 = new System.Windows.Forms.Label();
		this.同源_托号昵称 = new System.Windows.Forms.TextBox();
		this.同源_仙元宠物激活消耗 = new System.Windows.Forms.NumericUpDown();
		this.同源_仙元宠物激活类型 = new System.Windows.Forms.ComboBox();
		this.label46 = new System.Windows.Forms.Label();
		this.同源_仙元宠物转属消耗 = new System.Windows.Forms.NumericUpDown();
		this.同源_仙元宠物转属类型 = new System.Windows.Forms.ComboBox();
		this.label47 = new System.Windows.Forms.Label();
		this.label48 = new System.Windows.Forms.Label();
		this.同源_仙元宠物激活成长 = new System.Windows.Forms.NumericUpDown();
		this.label49 = new System.Windows.Forms.Label();
		this.同源_仙元宠物同源次数 = new System.Windows.Forms.NumericUpDown();
		this.label50 = new System.Windows.Forms.Label();
		this.同源_仙元宠物同源成长 = new System.Windows.Forms.NumericUpDown();
		this.同源_仙元宠物开关 = new System.Windows.Forms.CheckBox();
		this.同源_元灵宠物激活消耗 = new System.Windows.Forms.NumericUpDown();
		this.同源_元灵宠物激活类型 = new System.Windows.Forms.ComboBox();
		this.label41 = new System.Windows.Forms.Label();
		this.同源_元灵宠物转属消耗 = new System.Windows.Forms.NumericUpDown();
		this.同源_元灵宠物转属类型 = new System.Windows.Forms.ComboBox();
		this.label42 = new System.Windows.Forms.Label();
		this.label43 = new System.Windows.Forms.Label();
		this.同源_元灵宠物激活成长 = new System.Windows.Forms.NumericUpDown();
		this.label44 = new System.Windows.Forms.Label();
		this.同源_元灵宠物同源次数 = new System.Windows.Forms.NumericUpDown();
		this.label45 = new System.Windows.Forms.Label();
		this.同源_元灵宠物同源成长 = new System.Windows.Forms.NumericUpDown();
		this.同源_元灵宠物开关 = new System.Windows.Forms.CheckBox();
		this.同源_神兽宠物激活消耗 = new System.Windows.Forms.NumericUpDown();
		this.同源_神兽宠物激活类型 = new System.Windows.Forms.ComboBox();
		this.label36 = new System.Windows.Forms.Label();
		this.同源_神兽宠物转属消耗 = new System.Windows.Forms.NumericUpDown();
		this.同源_神兽宠物转属类型 = new System.Windows.Forms.ComboBox();
		this.label37 = new System.Windows.Forms.Label();
		this.label38 = new System.Windows.Forms.Label();
		this.同源_神兽宠物激活成长 = new System.Windows.Forms.NumericUpDown();
		this.label39 = new System.Windows.Forms.Label();
		this.同源_神兽宠物同源次数 = new System.Windows.Forms.NumericUpDown();
		this.label40 = new System.Windows.Forms.Label();
		this.同源_神兽宠物同源成长 = new System.Windows.Forms.NumericUpDown();
		this.同源_神兽宠物开关 = new System.Windows.Forms.CheckBox();
		this.同源_变异宠物激活消耗 = new System.Windows.Forms.NumericUpDown();
		this.同源_变异宠物激活类型 = new System.Windows.Forms.ComboBox();
		this.label30 = new System.Windows.Forms.Label();
		this.同源_变异宠物转属消耗 = new System.Windows.Forms.NumericUpDown();
		this.同源_变异宠物转属类型 = new System.Windows.Forms.ComboBox();
		this.label32 = new System.Windows.Forms.Label();
		this.label33 = new System.Windows.Forms.Label();
		this.同源_变异宠物激活成长 = new System.Windows.Forms.NumericUpDown();
		this.label34 = new System.Windows.Forms.Label();
		this.同源_变异宠物同源次数 = new System.Windows.Forms.NumericUpDown();
		this.label35 = new System.Windows.Forms.Label();
		this.同源_变异宠物同源成长 = new System.Windows.Forms.NumericUpDown();
		this.同源_变异宠物开关 = new System.Windows.Forms.CheckBox();
		this.同源_普通宠物激活消耗 = new System.Windows.Forms.NumericUpDown();
		this.同源_普通宠物激活类型 = new System.Windows.Forms.ComboBox();
		this.label31 = new System.Windows.Forms.Label();
		this.同源_普通宠物转属消耗 = new System.Windows.Forms.NumericUpDown();
		this.同源_普通宠物转属类型 = new System.Windows.Forms.ComboBox();
		this.label28 = new System.Windows.Forms.Label();
		this.label27 = new System.Windows.Forms.Label();
		this.同源_普通宠物激活成长 = new System.Windows.Forms.NumericUpDown();
		this.label26 = new System.Windows.Forms.Label();
		this.同源_普通宠物同源次数 = new System.Windows.Forms.NumericUpDown();
		this.label25 = new System.Windows.Forms.Label();
		this.同源_普通宠物同源成长 = new System.Windows.Forms.NumericUpDown();
		this.同源_普通宠物开关 = new System.Windows.Forms.CheckBox();
		this.同源_托号成长类型一致 = new System.Windows.Forms.CheckBox();
		this.label53 = new System.Windows.Forms.Label();
		this.同源_托号同源成长百分比 = new System.Windows.Forms.NumericUpDown();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.燃眉_日产数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_超级价格).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_高级价格).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_常规价格).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_每日可做).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_葫芦几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_二星几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_三星几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_四星几率).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_五星几率).BeginInit();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.转门派_消耗价格).BeginInit();
		this.groupBox3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.同源_仙元宠物激活消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_仙元宠物转属消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_仙元宠物激活成长).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_仙元宠物同源次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_仙元宠物同源成长).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_元灵宠物激活消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_元灵宠物转属消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_元灵宠物激活成长).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_元灵宠物同源次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_元灵宠物同源成长).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_神兽宠物激活消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_神兽宠物转属消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_神兽宠物激活成长).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_神兽宠物同源次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_神兽宠物同源成长).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_变异宠物激活消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_变异宠物转属消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_变异宠物激活成长).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_变异宠物同源次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_变异宠物同源成长).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_普通宠物激活消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_普通宠物转属消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_普通宠物激活成长).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_普通宠物同源次数).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_普通宠物同源成长).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.同源_托号同源成长百分比).BeginInit();
		base.SuspendLayout();
		this.groupBox1.Controls.Add(this.label12);
		this.groupBox1.Controls.Add(this.label11);
		this.groupBox1.Controls.Add(this.燃眉_托号昵称);
		this.groupBox1.Controls.Add(this.label10);
		this.groupBox1.Controls.Add(this.燃眉_日产数量);
		this.groupBox1.Controls.Add(this.label9);
		this.groupBox1.Controls.Add(this.燃眉_超级价格);
		this.groupBox1.Controls.Add(this.label8);
		this.groupBox1.Controls.Add(this.燃眉_高级价格);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.燃眉_常规价格);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.燃眉_每日可做);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.燃眉_葫芦几率);
		this.groupBox1.Controls.Add(this.label6);
		this.groupBox1.Controls.Add(this.燃眉_二星几率);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.燃眉_三星几率);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.燃眉_四星几率);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.燃眉_五星几率);
		this.groupBox1.Controls.Add(this.燃眉_重载按钮);
		this.groupBox1.Controls.Add(this.燃眉_保存按钮);
		this.groupBox1.Controls.Add(this.燃眉_开关);
		this.groupBox1.Location = new System.Drawing.Point(12, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(392, 273);
		this.groupBox1.TabIndex = 0;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "燃眉之急配置";
		this.label12.ForeColor = System.Drawing.Color.Red;
		this.label12.Location = new System.Drawing.Point(67, 244);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(304, 23);
		this.label12.TabIndex = 101;
		this.label12.Text = "多个托号昵称请用|连接";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label11.Location = new System.Drawing.Point(6, 218);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(60, 23);
		this.label11.TabIndex = 99;
		this.label11.Text = "托号昵称";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.燃眉_托号昵称.Location = new System.Drawing.Point(67, 218);
		this.燃眉_托号昵称.Name = "燃眉_托号昵称";
		this.燃眉_托号昵称.Size = new System.Drawing.Size(304, 23);
		this.燃眉_托号昵称.TabIndex = 100;
		this.label10.Location = new System.Drawing.Point(185, 181);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(80, 23);
		this.label10.TabIndex = 97;
		this.label10.Text = "紫帝晶日产量";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.燃眉_日产数量.Location = new System.Drawing.Point(271, 181);
		this.燃眉_日产数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.燃眉_日产数量.Name = "燃眉_日产数量";
		this.燃眉_日产数量.Size = new System.Drawing.Size(100, 23);
		this.燃眉_日产数量.TabIndex = 98;
		this.label9.Location = new System.Drawing.Point(185, 153);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(80, 23);
		this.label9.TabIndex = 95;
		this.label9.Text = "超级追讨价格";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.燃眉_超级价格.Location = new System.Drawing.Point(271, 153);
		this.燃眉_超级价格.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.燃眉_超级价格.Name = "燃眉_超级价格";
		this.燃眉_超级价格.Size = new System.Drawing.Size(100, 23);
		this.燃眉_超级价格.TabIndex = 96;
		this.label8.Location = new System.Drawing.Point(185, 122);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(80, 23);
		this.label8.TabIndex = 93;
		this.label8.Text = "高级追讨价格";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.燃眉_高级价格.Location = new System.Drawing.Point(271, 122);
		this.燃眉_高级价格.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.燃眉_高级价格.Name = "燃眉_高级价格";
		this.燃眉_高级价格.Size = new System.Drawing.Size(100, 23);
		this.燃眉_高级价格.TabIndex = 94;
		this.label7.Location = new System.Drawing.Point(185, 91);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(80, 23);
		this.label7.TabIndex = 91;
		this.label7.Text = "常规追讨价格";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.燃眉_常规价格.Location = new System.Drawing.Point(271, 91);
		this.燃眉_常规价格.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.燃眉_常规价格.Name = "燃眉_常规价格";
		this.燃眉_常规价格.Size = new System.Drawing.Size(100, 23);
		this.燃眉_常规价格.TabIndex = 92;
		this.label3.Location = new System.Drawing.Point(185, 62);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(80, 23);
		this.label3.TabIndex = 89;
		this.label3.Text = "每日可做次数";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.燃眉_每日可做.Location = new System.Drawing.Point(271, 62);
		this.燃眉_每日可做.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.燃眉_每日可做.Name = "燃眉_每日可做";
		this.燃眉_每日可做.Size = new System.Drawing.Size(100, 23);
		this.燃眉_每日可做.TabIndex = 90;
		this.label5.Location = new System.Drawing.Point(6, 181);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(60, 23);
		this.label5.TabIndex = 87;
		this.label5.Text = "葫芦几率";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.燃眉_葫芦几率.Location = new System.Drawing.Point(72, 181);
		this.燃眉_葫芦几率.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.燃眉_葫芦几率.Name = "燃眉_葫芦几率";
		this.燃眉_葫芦几率.Size = new System.Drawing.Size(91, 23);
		this.燃眉_葫芦几率.TabIndex = 88;
		this.label6.Location = new System.Drawing.Point(6, 153);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(60, 23);
		this.label6.TabIndex = 85;
		this.label6.Text = "二星几率";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.燃眉_二星几率.Location = new System.Drawing.Point(72, 153);
		this.燃眉_二星几率.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.燃眉_二星几率.Name = "燃眉_二星几率";
		this.燃眉_二星几率.Size = new System.Drawing.Size(91, 23);
		this.燃眉_二星几率.TabIndex = 86;
		this.label2.Location = new System.Drawing.Point(6, 122);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(60, 23);
		this.label2.TabIndex = 83;
		this.label2.Text = "三星几率";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.燃眉_三星几率.Location = new System.Drawing.Point(72, 122);
		this.燃眉_三星几率.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.燃眉_三星几率.Name = "燃眉_三星几率";
		this.燃眉_三星几率.Size = new System.Drawing.Size(91, 23);
		this.燃眉_三星几率.TabIndex = 84;
		this.label1.Location = new System.Drawing.Point(6, 91);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 23);
		this.label1.TabIndex = 81;
		this.label1.Text = "四星几率";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.燃眉_四星几率.Location = new System.Drawing.Point(72, 91);
		this.燃眉_四星几率.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.燃眉_四星几率.Name = "燃眉_四星几率";
		this.燃眉_四星几率.Size = new System.Drawing.Size(91, 23);
		this.燃眉_四星几率.TabIndex = 82;
		this.label4.Location = new System.Drawing.Point(6, 63);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 79;
		this.label4.Text = "五星几率";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.燃眉_五星几率.Location = new System.Drawing.Point(72, 63);
		this.燃眉_五星几率.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.燃眉_五星几率.Name = "燃眉_五星几率";
		this.燃眉_五星几率.Size = new System.Drawing.Size(91, 23);
		this.燃眉_五星几率.TabIndex = 80;
		this.燃眉_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.燃眉_重载按钮.Location = new System.Drawing.Point(204, 18);
		this.燃眉_重载按钮.Name = "燃眉_重载按钮";
		this.燃眉_重载按钮.Size = new System.Drawing.Size(80, 30);
		this.燃眉_重载按钮.TabIndex = 55;
		this.燃眉_重载按钮.Text = "重载配置";
		this.燃眉_重载按钮.UseVisualStyleBackColor = true;
		this.燃眉_重载按钮.Click += new System.EventHandler(燃眉_重载按钮_Click);
		this.燃眉_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.燃眉_保存按钮.Location = new System.Drawing.Point(118, 18);
		this.燃眉_保存按钮.Name = "燃眉_保存按钮";
		this.燃眉_保存按钮.Size = new System.Drawing.Size(80, 30);
		this.燃眉_保存按钮.TabIndex = 54;
		this.燃眉_保存按钮.Text = "保存配置";
		this.燃眉_保存按钮.UseVisualStyleBackColor = true;
		this.燃眉_保存按钮.Click += new System.EventHandler(燃眉_保存按钮_Click);
		this.燃眉_开关.AutoSize = true;
		this.燃眉_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.燃眉_开关.Location = new System.Drawing.Point(6, 22);
		this.燃眉_开关.Name = "燃眉_开关";
		this.燃眉_开关.Size = new System.Drawing.Size(106, 23);
		this.燃眉_开关.TabIndex = 52;
		this.燃眉_开关.Text = "燃眉之急开关";
		this.燃眉_开关.UseVisualStyleBackColor = true;
		this.groupBox2.Controls.Add(this.label29);
		this.groupBox2.Controls.Add(this.label19);
		this.groupBox2.Controls.Add(this.转门派_消耗类型);
		this.groupBox2.Controls.Add(this.label18);
		this.groupBox2.Controls.Add(this.转门派_消耗价格);
		this.groupBox2.Controls.Add(this.转门派_新土对话);
		this.groupBox2.Controls.Add(this.转门派_新火对话);
		this.groupBox2.Controls.Add(this.转门派_新水对话);
		this.groupBox2.Controls.Add(this.转门派_新木对话);
		this.groupBox2.Controls.Add(this.转门派_新金对话);
		this.groupBox2.Controls.Add(this.label13);
		this.groupBox2.Controls.Add(this.label14);
		this.groupBox2.Controls.Add(this.label15);
		this.groupBox2.Controls.Add(this.label16);
		this.groupBox2.Controls.Add(this.label17);
		this.groupBox2.Controls.Add(this.转门派_老土对话);
		this.groupBox2.Controls.Add(this.转门派_老火对话);
		this.groupBox2.Controls.Add(this.转门派_老水对话);
		this.groupBox2.Controls.Add(this.转门派_老木对话);
		this.groupBox2.Controls.Add(this.转门派_老金对话);
		this.groupBox2.Controls.Add(this.转门派_妖族门派开关);
		this.groupBox2.Controls.Add(this.转门派_新门派开关);
		this.groupBox2.Controls.Add(this.label20);
		this.groupBox2.Controls.Add(this.label21);
		this.groupBox2.Controls.Add(this.label22);
		this.groupBox2.Controls.Add(this.label23);
		this.groupBox2.Controls.Add(this.label24);
		this.groupBox2.Controls.Add(this.转门派_重载配置按钮);
		this.groupBox2.Controls.Add(this.转门派_保存配置按钮);
		this.groupBox2.Controls.Add(this.转门派_开关);
		this.groupBox2.Location = new System.Drawing.Point(410, 12);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(575, 273);
		this.groupBox2.TabIndex = 1;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "门派转换配置";
		this.label29.ForeColor = System.Drawing.Color.Red;
		this.label29.Location = new System.Drawing.Point(15, 240);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(541, 23);
		this.label29.TabIndex = 120;
		this.label29.Text = "勾选了妖族门派转换后武器会转成妖族武器名字，请确保etc中有妖族武器";
		this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label19.Location = new System.Drawing.Point(208, 207);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(60, 23);
		this.label19.TabIndex = 119;
		this.label19.Text = "消耗价格";
		this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.转门派_消耗类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.转门派_消耗类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.转门派_消耗类型.FormattingEnabled = true;
		this.转门派_消耗类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.转门派_消耗类型.Location = new System.Drawing.Point(76, 206);
		this.转门派_消耗类型.Name = "转门派_消耗类型";
		this.转门派_消耗类型.Size = new System.Drawing.Size(131, 25);
		this.转门派_消耗类型.TabIndex = 118;
		this.label18.Location = new System.Drawing.Point(15, 207);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(60, 23);
		this.label18.TabIndex = 117;
		this.label18.Text = "消耗类型";
		this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.转门派_消耗价格.Location = new System.Drawing.Point(269, 207);
		this.转门派_消耗价格.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.转门派_消耗价格.Name = "转门派_消耗价格";
		this.转门派_消耗价格.Size = new System.Drawing.Size(112, 23);
		this.转门派_消耗价格.TabIndex = 116;
		this.转门派_新土对话.Location = new System.Drawing.Point(356, 171);
		this.转门派_新土对话.Name = "转门派_新土对话";
		this.转门派_新土对话.Size = new System.Drawing.Size(200, 23);
		this.转门派_新土对话.TabIndex = 115;
		this.转门派_新火对话.Location = new System.Drawing.Point(356, 143);
		this.转门派_新火对话.Name = "转门派_新火对话";
		this.转门派_新火对话.Size = new System.Drawing.Size(200, 23);
		this.转门派_新火对话.TabIndex = 114;
		this.转门派_新水对话.Location = new System.Drawing.Point(356, 112);
		this.转门派_新水对话.Name = "转门派_新水对话";
		this.转门派_新水对话.Size = new System.Drawing.Size(200, 23);
		this.转门派_新水对话.TabIndex = 113;
		this.转门派_新木对话.Location = new System.Drawing.Point(356, 81);
		this.转门派_新木对话.Name = "转门派_新木对话";
		this.转门派_新木对话.Size = new System.Drawing.Size(200, 23);
		this.转门派_新木对话.TabIndex = 112;
		this.转门派_新金对话.Location = new System.Drawing.Point(356, 53);
		this.转门派_新金对话.Name = "转门派_新金对话";
		this.转门派_新金对话.Size = new System.Drawing.Size(200, 23);
		this.转门派_新金对话.TabIndex = 111;
		this.label13.Location = new System.Drawing.Point(295, 171);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(60, 23);
		this.label13.TabIndex = 110;
		this.label13.Text = "新土对话";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label14.Location = new System.Drawing.Point(295, 143);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(60, 23);
		this.label14.TabIndex = 109;
		this.label14.Text = "新火对话";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label15.Location = new System.Drawing.Point(295, 112);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(60, 23);
		this.label15.TabIndex = 108;
		this.label15.Text = "新水对话";
		this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label16.Location = new System.Drawing.Point(295, 81);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(60, 23);
		this.label16.TabIndex = 107;
		this.label16.Text = "新木对话";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label17.Location = new System.Drawing.Point(295, 53);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(60, 23);
		this.label17.TabIndex = 106;
		this.label17.Text = "新金对话";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.转门派_老土对话.Location = new System.Drawing.Point(76, 171);
		this.转门派_老土对话.Name = "转门派_老土对话";
		this.转门派_老土对话.Size = new System.Drawing.Size(200, 23);
		this.转门派_老土对话.TabIndex = 105;
		this.转门派_老火对话.Location = new System.Drawing.Point(76, 143);
		this.转门派_老火对话.Name = "转门派_老火对话";
		this.转门派_老火对话.Size = new System.Drawing.Size(200, 23);
		this.转门派_老火对话.TabIndex = 104;
		this.转门派_老水对话.Location = new System.Drawing.Point(76, 112);
		this.转门派_老水对话.Name = "转门派_老水对话";
		this.转门派_老水对话.Size = new System.Drawing.Size(200, 23);
		this.转门派_老水对话.TabIndex = 103;
		this.转门派_老木对话.Location = new System.Drawing.Point(76, 81);
		this.转门派_老木对话.Name = "转门派_老木对话";
		this.转门派_老木对话.Size = new System.Drawing.Size(200, 23);
		this.转门派_老木对话.TabIndex = 102;
		this.转门派_老金对话.Location = new System.Drawing.Point(76, 53);
		this.转门派_老金对话.Name = "转门派_老金对话";
		this.转门派_老金对话.Size = new System.Drawing.Size(200, 23);
		this.转门派_老金对话.TabIndex = 101;
		this.转门派_妖族门派开关.AutoSize = true;
		this.转门派_妖族门派开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.转门派_妖族门派开关.Location = new System.Drawing.Point(286, 22);
		this.转门派_妖族门派开关.Name = "转门派_妖族门派开关";
		this.转门派_妖族门派开关.Size = new System.Drawing.Size(132, 23);
		this.转门派_妖族门派开关.TabIndex = 100;
		this.转门派_妖族门派开关.Text = "妖族门派转换开关";
		this.转门派_妖族门派开关.UseVisualStyleBackColor = true;
		this.转门派_新门派开关.AutoSize = true;
		this.转门派_新门派开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.转门派_新门派开关.Location = new System.Drawing.Point(156, 22);
		this.转门派_新门派开关.Name = "转门派_新门派开关";
		this.转门派_新门派开关.Size = new System.Drawing.Size(119, 23);
		this.转门派_新门派开关.TabIndex = 99;
		this.转门派_新门派开关.Text = "新门派转换开关";
		this.转门派_新门派开关.UseVisualStyleBackColor = true;
		this.label20.Location = new System.Drawing.Point(15, 171);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(60, 23);
		this.label20.TabIndex = 87;
		this.label20.Text = "老土对话";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label21.Location = new System.Drawing.Point(15, 143);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(60, 23);
		this.label21.TabIndex = 85;
		this.label21.Text = "老火对话";
		this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label22.Location = new System.Drawing.Point(15, 112);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(60, 23);
		this.label22.TabIndex = 83;
		this.label22.Text = "老水对话";
		this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label23.Location = new System.Drawing.Point(15, 81);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(60, 23);
		this.label23.TabIndex = 81;
		this.label23.Text = "老木对话";
		this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label24.Location = new System.Drawing.Point(15, 53);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(60, 23);
		this.label24.TabIndex = 79;
		this.label24.Text = "老金对话";
		this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.转门派_重载配置按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.转门派_重载配置按钮.Location = new System.Drawing.Point(476, 203);
		this.转门派_重载配置按钮.Name = "转门派_重载配置按钮";
		this.转门派_重载配置按钮.Size = new System.Drawing.Size(80, 30);
		this.转门派_重载配置按钮.TabIndex = 55;
		this.转门派_重载配置按钮.Text = "重载配置";
		this.转门派_重载配置按钮.UseVisualStyleBackColor = true;
		this.转门派_重载配置按钮.Click += new System.EventHandler(转门派_重载配置按钮_Click);
		this.转门派_保存配置按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.转门派_保存配置按钮.Location = new System.Drawing.Point(387, 203);
		this.转门派_保存配置按钮.Name = "转门派_保存配置按钮";
		this.转门派_保存配置按钮.Size = new System.Drawing.Size(80, 30);
		this.转门派_保存配置按钮.TabIndex = 54;
		this.转门派_保存配置按钮.Text = "保存配置";
		this.转门派_保存配置按钮.UseVisualStyleBackColor = true;
		this.转门派_保存配置按钮.Click += new System.EventHandler(转门派_保存配置按钮_Click);
		this.转门派_开关.AutoSize = true;
		this.转门派_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.转门派_开关.Location = new System.Drawing.Point(15, 22);
		this.转门派_开关.Name = "转门派_开关";
		this.转门派_开关.Size = new System.Drawing.Size(132, 23);
		this.转门派_开关.TabIndex = 52;
		this.转门派_开关.Text = "门派转换功能开关";
		this.转门派_开关.UseVisualStyleBackColor = true;
		this.groupBox3.Controls.Add(this.label53);
		this.groupBox3.Controls.Add(this.同源_托号同源成长百分比);
		this.groupBox3.Controls.Add(this.同源_托号成长类型一致);
		this.groupBox3.Controls.Add(this.同源_开关);
		this.groupBox3.Controls.Add(this.同源_重载配置按钮);
		this.groupBox3.Controls.Add(this.同源_保存配置按钮);
		this.groupBox3.Controls.Add(this.label52);
		this.groupBox3.Controls.Add(this.label51);
		this.groupBox3.Controls.Add(this.同源_托号昵称);
		this.groupBox3.Controls.Add(this.同源_仙元宠物激活消耗);
		this.groupBox3.Controls.Add(this.同源_仙元宠物激活类型);
		this.groupBox3.Controls.Add(this.label46);
		this.groupBox3.Controls.Add(this.同源_仙元宠物转属消耗);
		this.groupBox3.Controls.Add(this.同源_仙元宠物转属类型);
		this.groupBox3.Controls.Add(this.label47);
		this.groupBox3.Controls.Add(this.label48);
		this.groupBox3.Controls.Add(this.同源_仙元宠物激活成长);
		this.groupBox3.Controls.Add(this.label49);
		this.groupBox3.Controls.Add(this.同源_仙元宠物同源次数);
		this.groupBox3.Controls.Add(this.label50);
		this.groupBox3.Controls.Add(this.同源_仙元宠物同源成长);
		this.groupBox3.Controls.Add(this.同源_仙元宠物开关);
		this.groupBox3.Controls.Add(this.同源_元灵宠物激活消耗);
		this.groupBox3.Controls.Add(this.同源_元灵宠物激活类型);
		this.groupBox3.Controls.Add(this.label41);
		this.groupBox3.Controls.Add(this.同源_元灵宠物转属消耗);
		this.groupBox3.Controls.Add(this.同源_元灵宠物转属类型);
		this.groupBox3.Controls.Add(this.label42);
		this.groupBox3.Controls.Add(this.label43);
		this.groupBox3.Controls.Add(this.同源_元灵宠物激活成长);
		this.groupBox3.Controls.Add(this.label44);
		this.groupBox3.Controls.Add(this.同源_元灵宠物同源次数);
		this.groupBox3.Controls.Add(this.label45);
		this.groupBox3.Controls.Add(this.同源_元灵宠物同源成长);
		this.groupBox3.Controls.Add(this.同源_元灵宠物开关);
		this.groupBox3.Controls.Add(this.同源_神兽宠物激活消耗);
		this.groupBox3.Controls.Add(this.同源_神兽宠物激活类型);
		this.groupBox3.Controls.Add(this.label36);
		this.groupBox3.Controls.Add(this.同源_神兽宠物转属消耗);
		this.groupBox3.Controls.Add(this.同源_神兽宠物转属类型);
		this.groupBox3.Controls.Add(this.label37);
		this.groupBox3.Controls.Add(this.label38);
		this.groupBox3.Controls.Add(this.同源_神兽宠物激活成长);
		this.groupBox3.Controls.Add(this.label39);
		this.groupBox3.Controls.Add(this.同源_神兽宠物同源次数);
		this.groupBox3.Controls.Add(this.label40);
		this.groupBox3.Controls.Add(this.同源_神兽宠物同源成长);
		this.groupBox3.Controls.Add(this.同源_神兽宠物开关);
		this.groupBox3.Controls.Add(this.同源_变异宠物激活消耗);
		this.groupBox3.Controls.Add(this.同源_变异宠物激活类型);
		this.groupBox3.Controls.Add(this.label30);
		this.groupBox3.Controls.Add(this.同源_变异宠物转属消耗);
		this.groupBox3.Controls.Add(this.同源_变异宠物转属类型);
		this.groupBox3.Controls.Add(this.label32);
		this.groupBox3.Controls.Add(this.label33);
		this.groupBox3.Controls.Add(this.同源_变异宠物激活成长);
		this.groupBox3.Controls.Add(this.label34);
		this.groupBox3.Controls.Add(this.同源_变异宠物同源次数);
		this.groupBox3.Controls.Add(this.label35);
		this.groupBox3.Controls.Add(this.同源_变异宠物同源成长);
		this.groupBox3.Controls.Add(this.同源_变异宠物开关);
		this.groupBox3.Controls.Add(this.同源_普通宠物激活消耗);
		this.groupBox3.Controls.Add(this.同源_普通宠物激活类型);
		this.groupBox3.Controls.Add(this.label31);
		this.groupBox3.Controls.Add(this.同源_普通宠物转属消耗);
		this.groupBox3.Controls.Add(this.同源_普通宠物转属类型);
		this.groupBox3.Controls.Add(this.label28);
		this.groupBox3.Controls.Add(this.label27);
		this.groupBox3.Controls.Add(this.同源_普通宠物激活成长);
		this.groupBox3.Controls.Add(this.label26);
		this.groupBox3.Controls.Add(this.同源_普通宠物同源次数);
		this.groupBox3.Controls.Add(this.label25);
		this.groupBox3.Controls.Add(this.同源_普通宠物同源成长);
		this.groupBox3.Controls.Add(this.同源_普通宠物开关);
		this.groupBox3.Location = new System.Drawing.Point(12, 291);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(973, 255);
		this.groupBox3.TabIndex = 2;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "普通/变异/神兽/元灵/仙元宠物同源配置";
		this.同源_开关.AutoSize = true;
		this.同源_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.同源_开关.Location = new System.Drawing.Point(175, 28);
		this.同源_开关.Name = "同源_开关";
		this.同源_开关.Size = new System.Drawing.Size(106, 23);
		this.同源_开关.TabIndex = 183;
		this.同源_开关.Text = "宠物同源开关";
		this.同源_开关.UseVisualStyleBackColor = true;
		this.同源_重载配置按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.同源_重载配置按钮.Location = new System.Drawing.Point(92, 23);
		this.同源_重载配置按钮.Name = "同源_重载配置按钮";
		this.同源_重载配置按钮.Size = new System.Drawing.Size(80, 30);
		this.同源_重载配置按钮.TabIndex = 182;
		this.同源_重载配置按钮.Text = "重载配置";
		this.同源_重载配置按钮.UseVisualStyleBackColor = true;
		this.同源_重载配置按钮.Click += new System.EventHandler(同源_重载配置按钮_Click);
		this.同源_保存配置按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.同源_保存配置按钮.Location = new System.Drawing.Point(6, 23);
		this.同源_保存配置按钮.Name = "同源_保存配置按钮";
		this.同源_保存配置按钮.Size = new System.Drawing.Size(80, 30);
		this.同源_保存配置按钮.TabIndex = 181;
		this.同源_保存配置按钮.Text = "保存配置";
		this.同源_保存配置按钮.UseVisualStyleBackColor = true;
		this.同源_保存配置按钮.Click += new System.EventHandler(同源_保存配置按钮_Click);
		this.label52.ForeColor = System.Drawing.Color.Red;
		this.label52.Location = new System.Drawing.Point(828, 59);
		this.label52.Name = "label52";
		this.label52.Size = new System.Drawing.Size(132, 23);
		this.label52.TabIndex = 180;
		this.label52.Text = "多个托号昵称请用|连接";
		this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label51.Location = new System.Drawing.Point(344, 58);
		this.label51.Name = "label51";
		this.label51.Size = new System.Drawing.Size(60, 23);
		this.label51.TabIndex = 178;
		this.label51.Text = "托号昵称";
		this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_托号昵称.Location = new System.Drawing.Point(405, 58);
		this.同源_托号昵称.Name = "同源_托号昵称";
		this.同源_托号昵称.Size = new System.Drawing.Size(417, 23);
		this.同源_托号昵称.TabIndex = 179;
		this.同源_仙元宠物激活消耗.Location = new System.Drawing.Point(855, 221);
		this.同源_仙元宠物激活消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_仙元宠物激活消耗.Name = "同源_仙元宠物激活消耗";
		this.同源_仙元宠物激活消耗.Size = new System.Drawing.Size(105, 23);
		this.同源_仙元宠物激活消耗.TabIndex = 177;
		this.同源_仙元宠物激活类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.同源_仙元宠物激活类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.同源_仙元宠物激活类型.FormattingEnabled = true;
		this.同源_仙元宠物激活类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.同源_仙元宠物激活类型.Location = new System.Drawing.Point(794, 220);
		this.同源_仙元宠物激活类型.Name = "同源_仙元宠物激活类型";
		this.同源_仙元宠物激活类型.Size = new System.Drawing.Size(60, 25);
		this.同源_仙元宠物激活类型.TabIndex = 176;
		this.label46.Location = new System.Drawing.Point(728, 221);
		this.label46.Name = "label46";
		this.label46.Size = new System.Drawing.Size(60, 23);
		this.label46.TabIndex = 175;
		this.label46.Text = "激活消耗";
		this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_仙元宠物转属消耗.Location = new System.Drawing.Point(615, 221);
		this.同源_仙元宠物转属消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_仙元宠物转属消耗.Name = "同源_仙元宠物转属消耗";
		this.同源_仙元宠物转属消耗.Size = new System.Drawing.Size(105, 23);
		this.同源_仙元宠物转属消耗.TabIndex = 174;
		this.同源_仙元宠物转属类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.同源_仙元宠物转属类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.同源_仙元宠物转属类型.FormattingEnabled = true;
		this.同源_仙元宠物转属类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.同源_仙元宠物转属类型.Location = new System.Drawing.Point(554, 220);
		this.同源_仙元宠物转属类型.Name = "同源_仙元宠物转属类型";
		this.同源_仙元宠物转属类型.Size = new System.Drawing.Size(60, 25);
		this.同源_仙元宠物转属类型.TabIndex = 173;
		this.label47.Location = new System.Drawing.Point(488, 221);
		this.label47.Name = "label47";
		this.label47.Size = new System.Drawing.Size(60, 23);
		this.label47.TabIndex = 172;
		this.label47.Text = "转属消耗";
		this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label48.Location = new System.Drawing.Point(356, 221);
		this.label48.Name = "label48";
		this.label48.Size = new System.Drawing.Size(60, 23);
		this.label48.TabIndex = 170;
		this.label48.Text = "激活成长";
		this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_仙元宠物激活成长.Location = new System.Drawing.Point(422, 221);
		this.同源_仙元宠物激活成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_仙元宠物激活成长.Name = "同源_仙元宠物激活成长";
		this.同源_仙元宠物激活成长.Size = new System.Drawing.Size(60, 23);
		this.同源_仙元宠物激活成长.TabIndex = 171;
		this.label49.Location = new System.Drawing.Point(224, 221);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(60, 23);
		this.label49.TabIndex = 168;
		this.label49.Text = "同源次数";
		this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_仙元宠物同源次数.Location = new System.Drawing.Point(290, 221);
		this.同源_仙元宠物同源次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_仙元宠物同源次数.Name = "同源_仙元宠物同源次数";
		this.同源_仙元宠物同源次数.Size = new System.Drawing.Size(60, 23);
		this.同源_仙元宠物同源次数.TabIndex = 169;
		this.label50.Location = new System.Drawing.Point(92, 221);
		this.label50.Name = "label50";
		this.label50.Size = new System.Drawing.Size(60, 23);
		this.label50.TabIndex = 166;
		this.label50.Text = "同源成长";
		this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_仙元宠物同源成长.Location = new System.Drawing.Point(158, 221);
		this.同源_仙元宠物同源成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_仙元宠物同源成长.Name = "同源_仙元宠物同源成长";
		this.同源_仙元宠物同源成长.Size = new System.Drawing.Size(60, 23);
		this.同源_仙元宠物同源成长.TabIndex = 167;
		this.同源_仙元宠物开关.AutoSize = true;
		this.同源_仙元宠物开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.同源_仙元宠物开关.Location = new System.Drawing.Point(6, 221);
		this.同源_仙元宠物开关.Name = "同源_仙元宠物开关";
		this.同源_仙元宠物开关.Size = new System.Drawing.Size(80, 23);
		this.同源_仙元宠物开关.TabIndex = 165;
		this.同源_仙元宠物开关.Text = "仙元宠物";
		this.同源_仙元宠物开关.UseVisualStyleBackColor = true;
		this.同源_元灵宠物激活消耗.Location = new System.Drawing.Point(855, 193);
		this.同源_元灵宠物激活消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_元灵宠物激活消耗.Name = "同源_元灵宠物激活消耗";
		this.同源_元灵宠物激活消耗.Size = new System.Drawing.Size(105, 23);
		this.同源_元灵宠物激活消耗.TabIndex = 164;
		this.同源_元灵宠物激活类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.同源_元灵宠物激活类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.同源_元灵宠物激活类型.FormattingEnabled = true;
		this.同源_元灵宠物激活类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.同源_元灵宠物激活类型.Location = new System.Drawing.Point(794, 192);
		this.同源_元灵宠物激活类型.Name = "同源_元灵宠物激活类型";
		this.同源_元灵宠物激活类型.Size = new System.Drawing.Size(60, 25);
		this.同源_元灵宠物激活类型.TabIndex = 163;
		this.label41.Location = new System.Drawing.Point(728, 193);
		this.label41.Name = "label41";
		this.label41.Size = new System.Drawing.Size(60, 23);
		this.label41.TabIndex = 162;
		this.label41.Text = "激活消耗";
		this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_元灵宠物转属消耗.Location = new System.Drawing.Point(615, 193);
		this.同源_元灵宠物转属消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_元灵宠物转属消耗.Name = "同源_元灵宠物转属消耗";
		this.同源_元灵宠物转属消耗.Size = new System.Drawing.Size(105, 23);
		this.同源_元灵宠物转属消耗.TabIndex = 161;
		this.同源_元灵宠物转属类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.同源_元灵宠物转属类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.同源_元灵宠物转属类型.FormattingEnabled = true;
		this.同源_元灵宠物转属类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.同源_元灵宠物转属类型.Location = new System.Drawing.Point(554, 192);
		this.同源_元灵宠物转属类型.Name = "同源_元灵宠物转属类型";
		this.同源_元灵宠物转属类型.Size = new System.Drawing.Size(60, 25);
		this.同源_元灵宠物转属类型.TabIndex = 160;
		this.label42.Location = new System.Drawing.Point(488, 193);
		this.label42.Name = "label42";
		this.label42.Size = new System.Drawing.Size(60, 23);
		this.label42.TabIndex = 159;
		this.label42.Text = "转属消耗";
		this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label43.Location = new System.Drawing.Point(356, 193);
		this.label43.Name = "label43";
		this.label43.Size = new System.Drawing.Size(60, 23);
		this.label43.TabIndex = 157;
		this.label43.Text = "激活成长";
		this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_元灵宠物激活成长.Location = new System.Drawing.Point(422, 193);
		this.同源_元灵宠物激活成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_元灵宠物激活成长.Name = "同源_元灵宠物激活成长";
		this.同源_元灵宠物激活成长.Size = new System.Drawing.Size(60, 23);
		this.同源_元灵宠物激活成长.TabIndex = 158;
		this.label44.Location = new System.Drawing.Point(224, 193);
		this.label44.Name = "label44";
		this.label44.Size = new System.Drawing.Size(60, 23);
		this.label44.TabIndex = 155;
		this.label44.Text = "同源次数";
		this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_元灵宠物同源次数.Location = new System.Drawing.Point(290, 193);
		this.同源_元灵宠物同源次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_元灵宠物同源次数.Name = "同源_元灵宠物同源次数";
		this.同源_元灵宠物同源次数.Size = new System.Drawing.Size(60, 23);
		this.同源_元灵宠物同源次数.TabIndex = 156;
		this.label45.Location = new System.Drawing.Point(92, 193);
		this.label45.Name = "label45";
		this.label45.Size = new System.Drawing.Size(60, 23);
		this.label45.TabIndex = 153;
		this.label45.Text = "同源成长";
		this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_元灵宠物同源成长.Location = new System.Drawing.Point(158, 193);
		this.同源_元灵宠物同源成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_元灵宠物同源成长.Name = "同源_元灵宠物同源成长";
		this.同源_元灵宠物同源成长.Size = new System.Drawing.Size(60, 23);
		this.同源_元灵宠物同源成长.TabIndex = 154;
		this.同源_元灵宠物开关.AutoSize = true;
		this.同源_元灵宠物开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.同源_元灵宠物开关.Location = new System.Drawing.Point(6, 193);
		this.同源_元灵宠物开关.Name = "同源_元灵宠物开关";
		this.同源_元灵宠物开关.Size = new System.Drawing.Size(80, 23);
		this.同源_元灵宠物开关.TabIndex = 152;
		this.同源_元灵宠物开关.Text = "元灵宠物";
		this.同源_元灵宠物开关.UseVisualStyleBackColor = true;
		this.同源_神兽宠物激活消耗.Location = new System.Drawing.Point(855, 165);
		this.同源_神兽宠物激活消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_神兽宠物激活消耗.Name = "同源_神兽宠物激活消耗";
		this.同源_神兽宠物激活消耗.Size = new System.Drawing.Size(105, 23);
		this.同源_神兽宠物激活消耗.TabIndex = 151;
		this.同源_神兽宠物激活类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.同源_神兽宠物激活类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.同源_神兽宠物激活类型.FormattingEnabled = true;
		this.同源_神兽宠物激活类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.同源_神兽宠物激活类型.Location = new System.Drawing.Point(794, 164);
		this.同源_神兽宠物激活类型.Name = "同源_神兽宠物激活类型";
		this.同源_神兽宠物激活类型.Size = new System.Drawing.Size(60, 25);
		this.同源_神兽宠物激活类型.TabIndex = 150;
		this.label36.Location = new System.Drawing.Point(728, 165);
		this.label36.Name = "label36";
		this.label36.Size = new System.Drawing.Size(60, 23);
		this.label36.TabIndex = 149;
		this.label36.Text = "激活消耗";
		this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_神兽宠物转属消耗.Location = new System.Drawing.Point(615, 165);
		this.同源_神兽宠物转属消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_神兽宠物转属消耗.Name = "同源_神兽宠物转属消耗";
		this.同源_神兽宠物转属消耗.Size = new System.Drawing.Size(105, 23);
		this.同源_神兽宠物转属消耗.TabIndex = 148;
		this.同源_神兽宠物转属类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.同源_神兽宠物转属类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.同源_神兽宠物转属类型.FormattingEnabled = true;
		this.同源_神兽宠物转属类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.同源_神兽宠物转属类型.Location = new System.Drawing.Point(554, 164);
		this.同源_神兽宠物转属类型.Name = "同源_神兽宠物转属类型";
		this.同源_神兽宠物转属类型.Size = new System.Drawing.Size(60, 25);
		this.同源_神兽宠物转属类型.TabIndex = 147;
		this.label37.Location = new System.Drawing.Point(488, 165);
		this.label37.Name = "label37";
		this.label37.Size = new System.Drawing.Size(60, 23);
		this.label37.TabIndex = 146;
		this.label37.Text = "转属消耗";
		this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label38.Location = new System.Drawing.Point(356, 165);
		this.label38.Name = "label38";
		this.label38.Size = new System.Drawing.Size(60, 23);
		this.label38.TabIndex = 144;
		this.label38.Text = "激活成长";
		this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_神兽宠物激活成长.Location = new System.Drawing.Point(422, 165);
		this.同源_神兽宠物激活成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_神兽宠物激活成长.Name = "同源_神兽宠物激活成长";
		this.同源_神兽宠物激活成长.Size = new System.Drawing.Size(60, 23);
		this.同源_神兽宠物激活成长.TabIndex = 145;
		this.label39.Location = new System.Drawing.Point(224, 165);
		this.label39.Name = "label39";
		this.label39.Size = new System.Drawing.Size(60, 23);
		this.label39.TabIndex = 142;
		this.label39.Text = "同源次数";
		this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_神兽宠物同源次数.Location = new System.Drawing.Point(290, 165);
		this.同源_神兽宠物同源次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_神兽宠物同源次数.Name = "同源_神兽宠物同源次数";
		this.同源_神兽宠物同源次数.Size = new System.Drawing.Size(60, 23);
		this.同源_神兽宠物同源次数.TabIndex = 143;
		this.label40.Location = new System.Drawing.Point(92, 165);
		this.label40.Name = "label40";
		this.label40.Size = new System.Drawing.Size(60, 23);
		this.label40.TabIndex = 140;
		this.label40.Text = "同源成长";
		this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_神兽宠物同源成长.Location = new System.Drawing.Point(158, 165);
		this.同源_神兽宠物同源成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_神兽宠物同源成长.Name = "同源_神兽宠物同源成长";
		this.同源_神兽宠物同源成长.Size = new System.Drawing.Size(60, 23);
		this.同源_神兽宠物同源成长.TabIndex = 141;
		this.同源_神兽宠物开关.AutoSize = true;
		this.同源_神兽宠物开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.同源_神兽宠物开关.Location = new System.Drawing.Point(6, 165);
		this.同源_神兽宠物开关.Name = "同源_神兽宠物开关";
		this.同源_神兽宠物开关.Size = new System.Drawing.Size(80, 23);
		this.同源_神兽宠物开关.TabIndex = 139;
		this.同源_神兽宠物开关.Text = "神兽宠物";
		this.同源_神兽宠物开关.UseVisualStyleBackColor = true;
		this.同源_变异宠物激活消耗.Location = new System.Drawing.Point(855, 137);
		this.同源_变异宠物激活消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_变异宠物激活消耗.Name = "同源_变异宠物激活消耗";
		this.同源_变异宠物激活消耗.Size = new System.Drawing.Size(105, 23);
		this.同源_变异宠物激活消耗.TabIndex = 138;
		this.同源_变异宠物激活类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.同源_变异宠物激活类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.同源_变异宠物激活类型.FormattingEnabled = true;
		this.同源_变异宠物激活类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.同源_变异宠物激活类型.Location = new System.Drawing.Point(794, 136);
		this.同源_变异宠物激活类型.Name = "同源_变异宠物激活类型";
		this.同源_变异宠物激活类型.Size = new System.Drawing.Size(60, 25);
		this.同源_变异宠物激活类型.TabIndex = 137;
		this.label30.Location = new System.Drawing.Point(728, 137);
		this.label30.Name = "label30";
		this.label30.Size = new System.Drawing.Size(60, 23);
		this.label30.TabIndex = 136;
		this.label30.Text = "激活消耗";
		this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_变异宠物转属消耗.Location = new System.Drawing.Point(615, 137);
		this.同源_变异宠物转属消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_变异宠物转属消耗.Name = "同源_变异宠物转属消耗";
		this.同源_变异宠物转属消耗.Size = new System.Drawing.Size(105, 23);
		this.同源_变异宠物转属消耗.TabIndex = 135;
		this.同源_变异宠物转属类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.同源_变异宠物转属类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.同源_变异宠物转属类型.FormattingEnabled = true;
		this.同源_变异宠物转属类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.同源_变异宠物转属类型.Location = new System.Drawing.Point(554, 136);
		this.同源_变异宠物转属类型.Name = "同源_变异宠物转属类型";
		this.同源_变异宠物转属类型.Size = new System.Drawing.Size(60, 25);
		this.同源_变异宠物转属类型.TabIndex = 134;
		this.label32.Location = new System.Drawing.Point(488, 137);
		this.label32.Name = "label32";
		this.label32.Size = new System.Drawing.Size(60, 23);
		this.label32.TabIndex = 133;
		this.label32.Text = "转属消耗";
		this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label33.Location = new System.Drawing.Point(356, 137);
		this.label33.Name = "label33";
		this.label33.Size = new System.Drawing.Size(60, 23);
		this.label33.TabIndex = 131;
		this.label33.Text = "激活成长";
		this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_变异宠物激活成长.Location = new System.Drawing.Point(422, 137);
		this.同源_变异宠物激活成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_变异宠物激活成长.Name = "同源_变异宠物激活成长";
		this.同源_变异宠物激活成长.Size = new System.Drawing.Size(60, 23);
		this.同源_变异宠物激活成长.TabIndex = 132;
		this.label34.Location = new System.Drawing.Point(224, 137);
		this.label34.Name = "label34";
		this.label34.Size = new System.Drawing.Size(60, 23);
		this.label34.TabIndex = 129;
		this.label34.Text = "同源次数";
		this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_变异宠物同源次数.Location = new System.Drawing.Point(290, 137);
		this.同源_变异宠物同源次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_变异宠物同源次数.Name = "同源_变异宠物同源次数";
		this.同源_变异宠物同源次数.Size = new System.Drawing.Size(60, 23);
		this.同源_变异宠物同源次数.TabIndex = 130;
		this.label35.Location = new System.Drawing.Point(92, 137);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(60, 23);
		this.label35.TabIndex = 127;
		this.label35.Text = "同源成长";
		this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_变异宠物同源成长.Location = new System.Drawing.Point(158, 137);
		this.同源_变异宠物同源成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_变异宠物同源成长.Name = "同源_变异宠物同源成长";
		this.同源_变异宠物同源成长.Size = new System.Drawing.Size(60, 23);
		this.同源_变异宠物同源成长.TabIndex = 128;
		this.同源_变异宠物开关.AutoSize = true;
		this.同源_变异宠物开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.同源_变异宠物开关.Location = new System.Drawing.Point(6, 137);
		this.同源_变异宠物开关.Name = "同源_变异宠物开关";
		this.同源_变异宠物开关.Size = new System.Drawing.Size(80, 23);
		this.同源_变异宠物开关.TabIndex = 126;
		this.同源_变异宠物开关.Text = "变异宠物";
		this.同源_变异宠物开关.UseVisualStyleBackColor = true;
		this.同源_普通宠物激活消耗.Location = new System.Drawing.Point(855, 108);
		this.同源_普通宠物激活消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_普通宠物激活消耗.Name = "同源_普通宠物激活消耗";
		this.同源_普通宠物激活消耗.Size = new System.Drawing.Size(105, 23);
		this.同源_普通宠物激活消耗.TabIndex = 125;
		this.同源_普通宠物激活类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.同源_普通宠物激活类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.同源_普通宠物激活类型.FormattingEnabled = true;
		this.同源_普通宠物激活类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.同源_普通宠物激活类型.Location = new System.Drawing.Point(794, 107);
		this.同源_普通宠物激活类型.Name = "同源_普通宠物激活类型";
		this.同源_普通宠物激活类型.Size = new System.Drawing.Size(60, 25);
		this.同源_普通宠物激活类型.TabIndex = 124;
		this.label31.Location = new System.Drawing.Point(728, 108);
		this.label31.Name = "label31";
		this.label31.Size = new System.Drawing.Size(60, 23);
		this.label31.TabIndex = 123;
		this.label31.Text = "激活消耗";
		this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_普通宠物转属消耗.Location = new System.Drawing.Point(615, 108);
		this.同源_普通宠物转属消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_普通宠物转属消耗.Name = "同源_普通宠物转属消耗";
		this.同源_普通宠物转属消耗.Size = new System.Drawing.Size(105, 23);
		this.同源_普通宠物转属消耗.TabIndex = 121;
		this.同源_普通宠物转属类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.同源_普通宠物转属类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.同源_普通宠物转属类型.FormattingEnabled = true;
		this.同源_普通宠物转属类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.同源_普通宠物转属类型.Location = new System.Drawing.Point(554, 107);
		this.同源_普通宠物转属类型.Name = "同源_普通宠物转属类型";
		this.同源_普通宠物转属类型.Size = new System.Drawing.Size(60, 25);
		this.同源_普通宠物转属类型.TabIndex = 120;
		this.label28.Location = new System.Drawing.Point(488, 108);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(60, 23);
		this.label28.TabIndex = 119;
		this.label28.Text = "转属消耗";
		this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label27.Location = new System.Drawing.Point(356, 108);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(60, 23);
		this.label27.TabIndex = 85;
		this.label27.Text = "激活成长";
		this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_普通宠物激活成长.Location = new System.Drawing.Point(422, 108);
		this.同源_普通宠物激活成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_普通宠物激活成长.Name = "同源_普通宠物激活成长";
		this.同源_普通宠物激活成长.Size = new System.Drawing.Size(60, 23);
		this.同源_普通宠物激活成长.TabIndex = 86;
		this.label26.Location = new System.Drawing.Point(224, 108);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(60, 23);
		this.label26.TabIndex = 83;
		this.label26.Text = "同源次数";
		this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_普通宠物同源次数.Location = new System.Drawing.Point(290, 108);
		this.同源_普通宠物同源次数.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_普通宠物同源次数.Name = "同源_普通宠物同源次数";
		this.同源_普通宠物同源次数.Size = new System.Drawing.Size(60, 23);
		this.同源_普通宠物同源次数.TabIndex = 84;
		this.label25.Location = new System.Drawing.Point(92, 108);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(60, 23);
		this.label25.TabIndex = 81;
		this.label25.Text = "同源成长";
		this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_普通宠物同源成长.Location = new System.Drawing.Point(158, 108);
		this.同源_普通宠物同源成长.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.同源_普通宠物同源成长.Name = "同源_普通宠物同源成长";
		this.同源_普通宠物同源成长.Size = new System.Drawing.Size(60, 23);
		this.同源_普通宠物同源成长.TabIndex = 82;
		this.同源_普通宠物开关.AutoSize = true;
		this.同源_普通宠物开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.同源_普通宠物开关.Location = new System.Drawing.Point(6, 108);
		this.同源_普通宠物开关.Name = "同源_普通宠物开关";
		this.同源_普通宠物开关.Size = new System.Drawing.Size(80, 23);
		this.同源_普通宠物开关.TabIndex = 53;
		this.同源_普通宠物开关.Text = "普通宠物";
		this.同源_普通宠物开关.UseVisualStyleBackColor = true;
		this.同源_托号成长类型一致.AutoSize = true;
		this.同源_托号成长类型一致.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.同源_托号成长类型一致.Location = new System.Drawing.Point(6, 59);
		this.同源_托号成长类型一致.Name = "同源_托号成长类型一致";
		this.同源_托号成长类型一致.Size = new System.Drawing.Size(132, 23);
		this.同源_托号成长类型一致.TabIndex = 184;
		this.同源_托号成长类型一致.Text = "托号成长类型一致";
		this.同源_托号成长类型一致.UseVisualStyleBackColor = true;
		this.label53.Location = new System.Drawing.Point(158, 59);
		this.label53.Name = "label53";
		this.label53.Size = new System.Drawing.Size(117, 23);
		this.label53.TabIndex = 185;
		this.label53.Text = "托号同源成长百分比";
		this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.同源_托号同源成长百分比.Location = new System.Drawing.Point(278, 59);
		this.同源_托号同源成长百分比.Name = "同源_托号同源成长百分比";
		this.同源_托号同源成长百分比.Size = new System.Drawing.Size(60, 23);
		this.同源_托号同源成长百分比.TabIndex = 186;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(1000, 558);
		base.Controls.Add(this.groupBox3);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "燃煤同源转门派窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "燃煤同源转门派窗口";
		base.Load += new System.EventHandler(燃煤同源转门派窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.燃眉_日产数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_超级价格).EndInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_高级价格).EndInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_常规价格).EndInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_每日可做).EndInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_葫芦几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_二星几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_三星几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_四星几率).EndInit();
		((System.ComponentModel.ISupportInitialize)this.燃眉_五星几率).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.转门派_消耗价格).EndInit();
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.同源_仙元宠物激活消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_仙元宠物转属消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_仙元宠物激活成长).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_仙元宠物同源次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_仙元宠物同源成长).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_元灵宠物激活消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_元灵宠物转属消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_元灵宠物激活成长).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_元灵宠物同源次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_元灵宠物同源成长).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_神兽宠物激活消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_神兽宠物转属消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_神兽宠物激活成长).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_神兽宠物同源次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_神兽宠物同源成长).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_变异宠物激活消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_变异宠物转属消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_变异宠物激活成长).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_变异宠物同源次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_变异宠物同源成长).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_普通宠物激活消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_普通宠物转属消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_普通宠物激活成长).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_普通宠物同源次数).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_普通宠物同源成长).EndInit();
		((System.ComponentModel.ISupportInitialize)this.同源_托号同源成长百分比).EndInit();
		base.ResumeLayout(false);
	}
}
