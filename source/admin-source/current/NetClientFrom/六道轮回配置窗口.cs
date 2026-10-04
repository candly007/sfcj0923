using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 六道轮回配置窗口 : Form
{
	private static 六道轮回配置窗口 i;

	private IContainer components;

	private CheckBox 六道轮回_开关;

	private Button 六道轮回_重载按钮;

	private Button 六道轮回_保存按钮;

	private GroupBox groupBox1;

	private NumericUpDown 六道轮回_刷新消耗;

	private ComboBox 六道轮回_刷新类型;

	private Label label8;

	private Label label5;

	private TextBox 六道轮回_特效道具;

	private Label label4;

	private TextBox 六道轮回_npc名字;

	private Label label1;

	private NumericUpDown 六道轮回_最低等级;

	private Label label2;

	private TextBox 六道轮回_首级对话;

	private Label label3;

	private TextBox 地狱道_名字;

	private Label label6;

	private NumericUpDown 地狱道_单相;

	private NumericUpDown 地狱道_所相;

	private TextBox 地狱道_结束消耗;

	private ComboBox 地狱道_结束条件;

	private NumericUpDown 地狱道_开启等级;

	private NumericUpDown 地狱道_开启消耗;

	private ComboBox 地狱道_开启类型;

	private Label label7;

	private NumericUpDown 天道_单相;

	private NumericUpDown 天道_所相;

	private TextBox 天道_结束消耗;

	private ComboBox 天道_结束条件;

	private NumericUpDown 天道_开启等级;

	private NumericUpDown 天道_开启消耗;

	private ComboBox 天道_开启类型;

	private TextBox 天道_名字;

	private NumericUpDown 人道_单相;

	private NumericUpDown 人道_所相;

	private TextBox 人道_结束消耗;

	private ComboBox 人道_结束条件;

	private NumericUpDown 人道_开启等级;

	private NumericUpDown 人道_开启消耗;

	private ComboBox 人道_开启类型;

	private TextBox 人道_名字;

	private NumericUpDown 修罗道_单相;

	private NumericUpDown 修罗道_所相;

	private TextBox 修罗道_结束消耗;

	private ComboBox 修罗道_结束条件;

	private NumericUpDown 修罗道_开启等级;

	private NumericUpDown 修罗道_开启消耗;

	private ComboBox 修罗道_开启类型;

	private TextBox 修罗道_名字;

	private NumericUpDown 畜生道_单相;

	private NumericUpDown 畜生道_所相;

	private TextBox 畜生道_结束消耗;

	private ComboBox 畜生道_结束条件;

	private NumericUpDown 畜生道_开启等级;

	private NumericUpDown 畜生道_开启消耗;

	private ComboBox 畜生道_开启类型;

	private TextBox 畜生道_名字;

	private NumericUpDown 饿鬼道_单相;

	private NumericUpDown 饿鬼道_所相;

	private TextBox 饿鬼道_结束消耗;

	private ComboBox 饿鬼道_结束条件;

	private NumericUpDown 饿鬼道_开启等级;

	private NumericUpDown 饿鬼道_开启消耗;

	private ComboBox 饿鬼道_开启类型;

	private TextBox 饿鬼道_名字;

	private CheckBox 天道_结束扣除;

	private CheckBox 人道_结束扣除;

	private CheckBox 修罗道_结束扣除;

	private CheckBox 畜生道_结束扣除;

	private CheckBox 饿鬼道_结束扣除;

	private CheckBox 地狱道_结束扣除;

	public static 六道轮回配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 六道轮回配置窗口();
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

	public 六道轮回配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 六道轮回配置窗口_Load(object sender, EventArgs e)
	{
		if (!全局变量类.Is展示转生等级)
		{
			地狱道_结束条件.Items.Remove("等级");
			饿鬼道_结束条件.Items.Remove("等级");
			畜生道_结束条件.Items.Remove("等级");
			修罗道_结束条件.Items.Remove("等级");
			人道_结束条件.Items.Remove("等级");
			天道_结束条件.Items.Remove("等级");
		}
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		六道轮回_重载按钮_Click(sender, e);
	}

	private void 六道轮回_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 8, JsonConvert.SerializeObject(Singleton<全局变量类>.I.六道轮回配置, Formatting.Indented));
		}
	}

	private void 六道轮回_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 8);
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (base.IsHandleCreated && 配置类型 == 8)
		{
			if (Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0] == null)
			{
				Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0] = new 六道轮回列表类();
			}
			if (Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1] == null)
			{
				Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1] = new 六道轮回列表类();
			}
			if (Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2] == null)
			{
				Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2] = new 六道轮回列表类();
			}
			if (Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3] == null)
			{
				Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3] = new 六道轮回列表类();
			}
			if (Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4] == null)
			{
				Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4] = new 六道轮回列表类();
			}
			if (Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5] == null)
			{
				Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5] = new 六道轮回列表类();
			}
			Invoke((MethodInvoker)delegate
			{
				六道轮回_开关.Checked = Singleton<全局变量类>.I.六道轮回配置.功能开关;
				六道轮回_npc名字.Text = Singleton<全局变量类>.I.六道轮回配置.npc名字;
				六道轮回_刷新类型.Text = Singleton<全局变量类>.I.六道轮回配置.刷新类型.ToString();
				六道轮回_刷新消耗.Value = Singleton<全局变量类>.I.六道轮回配置.刷新价格;
				六道轮回_最低等级.Value = Singleton<全局变量类>.I.六道轮回配置.最低需求等级;
				六道轮回_特效道具.Text = Singleton<全局变量类>.I.六道轮回配置.特效道具;
				六道轮回_首级对话.Text = Singleton<全局变量类>.I.六道轮回配置.首级对话选项;
				地狱道_开启类型.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].开启消耗类型.ToString();
				地狱道_开启消耗.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].开启消耗数值;
				地狱道_开启等级.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].最低等级;
				地狱道_结束条件.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].转世结束类型.ToString();
				地狱道_结束消耗.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].转世结束数值.ToString();
				地狱道_结束扣除.Checked = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].is扣除;
				地狱道_所相.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].所相数值;
				地狱道_单相.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].单相数值;
				饿鬼道_开启类型.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].开启消耗类型.ToString();
				饿鬼道_开启消耗.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].开启消耗数值;
				饿鬼道_开启等级.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].最低等级;
				饿鬼道_结束条件.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].转世结束类型.ToString();
				饿鬼道_结束消耗.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].转世结束数值.ToString();
				饿鬼道_结束扣除.Checked = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].is扣除;
				饿鬼道_所相.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].所相数值;
				饿鬼道_单相.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].单相数值;
				畜生道_开启类型.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].开启消耗类型.ToString();
				畜生道_开启消耗.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].开启消耗数值;
				畜生道_开启等级.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].最低等级;
				畜生道_结束条件.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].转世结束类型.ToString();
				畜生道_结束消耗.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].转世结束数值.ToString();
				畜生道_结束扣除.Checked = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].is扣除;
				畜生道_所相.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].所相数值;
				畜生道_单相.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].单相数值;
				修罗道_开启类型.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].开启消耗类型.ToString();
				修罗道_开启消耗.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].开启消耗数值;
				修罗道_开启等级.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].最低等级;
				修罗道_结束条件.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].转世结束类型.ToString();
				修罗道_结束消耗.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].转世结束数值.ToString();
				修罗道_结束扣除.Checked = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].is扣除;
				修罗道_所相.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].所相数值;
				修罗道_单相.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].单相数值;
				人道_开启类型.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].开启消耗类型.ToString();
				人道_开启消耗.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].开启消耗数值;
				人道_开启等级.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].最低等级;
				人道_结束条件.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].转世结束类型.ToString();
				人道_结束消耗.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].转世结束数值.ToString();
				人道_结束扣除.Checked = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].is扣除;
				人道_所相.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].所相数值;
				人道_单相.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].单相数值;
				天道_开启类型.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].开启消耗类型.ToString();
				天道_开启消耗.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].开启消耗数值;
				天道_开启等级.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].最低等级;
				天道_结束条件.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].转世结束类型.ToString();
				天道_结束消耗.Text = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].转世结束数值.ToString();
				天道_结束扣除.Checked = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].is扣除;
				天道_所相.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].所相数值;
				天道_单相.Value = Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].单相数值;
			});
		}
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.六道轮回配置.功能开关 = 六道轮回_开关.Checked;
			if (Singleton<全局变量类>.I.六道轮回配置.功能开关)
			{
				Singleton<全局变量类>.I.六道轮回配置.定制功能开关 = false;
			}
			Singleton<全局变量类>.I.六道轮回配置.npc名字 = 六道轮回_npc名字.Text;
			Enum.TryParse<AllEnums.数值Type>(六道轮回_刷新类型.Text, out Singleton<全局变量类>.I.六道轮回配置.刷新类型);
			Singleton<全局变量类>.I.六道轮回配置.刷新价格 = (int)六道轮回_刷新消耗.Value;
			Singleton<全局变量类>.I.六道轮回配置.最低需求等级 = (int)六道轮回_最低等级.Value;
			Singleton<全局变量类>.I.六道轮回配置.特效道具 = 六道轮回_特效道具.Text;
			Singleton<全局变量类>.I.六道轮回配置.首级对话选项 = 六道轮回_首级对话.Text;
			Enum.TryParse<AllEnums.数值Type>(地狱道_开启类型.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].开启消耗类型);
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].开启消耗数值 = (int)地狱道_开启消耗.Value;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].最低等级 = (int)地狱道_开启等级.Value;
			Enum.TryParse<AllEnums.数值Type>(地狱道_结束条件.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].转世结束类型);
			int.TryParse(地狱道_结束消耗.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].转世结束数值);
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].is扣除 = 地狱道_结束扣除.Checked;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].所相数值 = (int)地狱道_所相.Value;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[0].单相数值 = (int)地狱道_单相.Value;
			Enum.TryParse<AllEnums.数值Type>(饿鬼道_开启类型.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].开启消耗类型);
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].开启消耗数值 = (int)饿鬼道_开启消耗.Value;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].最低等级 = (int)饿鬼道_开启等级.Value;
			Enum.TryParse<AllEnums.数值Type>(饿鬼道_结束条件.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].转世结束类型);
			int.TryParse(饿鬼道_结束消耗.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].转世结束数值);
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].is扣除 = 饿鬼道_结束扣除.Checked;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].所相数值 = (int)饿鬼道_所相.Value;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[1].单相数值 = (int)饿鬼道_单相.Value;
			Enum.TryParse<AllEnums.数值Type>(畜生道_开启类型.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].开启消耗类型);
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].开启消耗数值 = (int)畜生道_开启消耗.Value;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].最低等级 = (int)畜生道_开启等级.Value;
			Enum.TryParse<AllEnums.数值Type>(畜生道_结束条件.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].转世结束类型);
			int.TryParse(畜生道_结束消耗.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].转世结束数值);
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].is扣除 = 畜生道_结束扣除.Checked;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].所相数值 = (int)畜生道_所相.Value;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[2].单相数值 = (int)畜生道_单相.Value;
			Enum.TryParse<AllEnums.数值Type>(修罗道_开启类型.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].开启消耗类型);
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].开启消耗数值 = (int)修罗道_开启消耗.Value;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].最低等级 = (int)修罗道_开启等级.Value;
			Enum.TryParse<AllEnums.数值Type>(修罗道_结束条件.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].转世结束类型);
			int.TryParse(修罗道_结束消耗.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].转世结束数值);
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].is扣除 = 修罗道_结束扣除.Checked;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].所相数值 = (int)修罗道_所相.Value;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[3].单相数值 = (int)修罗道_单相.Value;
			Enum.TryParse<AllEnums.数值Type>(人道_开启类型.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].开启消耗类型);
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].开启消耗数值 = (int)人道_开启消耗.Value;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].最低等级 = (int)人道_开启等级.Value;
			Enum.TryParse<AllEnums.数值Type>(人道_结束条件.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].转世结束类型);
			int.TryParse(人道_结束消耗.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].转世结束数值);
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].is扣除 = 人道_结束扣除.Checked;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].所相数值 = (int)人道_所相.Value;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[4].单相数值 = (int)人道_单相.Value;
			Enum.TryParse<AllEnums.数值Type>(天道_开启类型.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].开启消耗类型);
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].开启消耗数值 = (int)天道_开启消耗.Value;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].最低等级 = (int)天道_开启等级.Value;
			Enum.TryParse<AllEnums.数值Type>(天道_结束条件.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].转世结束类型);
			int.TryParse(天道_结束消耗.Text, out Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].转世结束数值);
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].is扣除 = 天道_结束扣除.Checked;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].所相数值 = (int)天道_所相.Value;
			Singleton<全局变量类>.I.六道轮回配置.六道轮回列表[5].单相数值 = (int)天道_单相.Value;
		}
	}

	private void 人道_结束消耗_TextChanged(object sender, EventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.六道轮回配置窗口));
		this.六道轮回_开关 = new System.Windows.Forms.CheckBox();
		this.六道轮回_重载按钮 = new System.Windows.Forms.Button();
		this.六道轮回_保存按钮 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.天道_结束扣除 = new System.Windows.Forms.CheckBox();
		this.人道_结束扣除 = new System.Windows.Forms.CheckBox();
		this.修罗道_结束扣除 = new System.Windows.Forms.CheckBox();
		this.畜生道_结束扣除 = new System.Windows.Forms.CheckBox();
		this.饿鬼道_结束扣除 = new System.Windows.Forms.CheckBox();
		this.地狱道_结束扣除 = new System.Windows.Forms.CheckBox();
		this.label7 = new System.Windows.Forms.Label();
		this.天道_单相 = new System.Windows.Forms.NumericUpDown();
		this.天道_所相 = new System.Windows.Forms.NumericUpDown();
		this.天道_结束消耗 = new System.Windows.Forms.TextBox();
		this.天道_结束条件 = new System.Windows.Forms.ComboBox();
		this.天道_开启等级 = new System.Windows.Forms.NumericUpDown();
		this.天道_开启消耗 = new System.Windows.Forms.NumericUpDown();
		this.天道_开启类型 = new System.Windows.Forms.ComboBox();
		this.天道_名字 = new System.Windows.Forms.TextBox();
		this.人道_单相 = new System.Windows.Forms.NumericUpDown();
		this.人道_所相 = new System.Windows.Forms.NumericUpDown();
		this.人道_结束消耗 = new System.Windows.Forms.TextBox();
		this.人道_结束条件 = new System.Windows.Forms.ComboBox();
		this.人道_开启等级 = new System.Windows.Forms.NumericUpDown();
		this.人道_开启消耗 = new System.Windows.Forms.NumericUpDown();
		this.人道_开启类型 = new System.Windows.Forms.ComboBox();
		this.人道_名字 = new System.Windows.Forms.TextBox();
		this.修罗道_单相 = new System.Windows.Forms.NumericUpDown();
		this.修罗道_所相 = new System.Windows.Forms.NumericUpDown();
		this.修罗道_结束消耗 = new System.Windows.Forms.TextBox();
		this.修罗道_结束条件 = new System.Windows.Forms.ComboBox();
		this.修罗道_开启等级 = new System.Windows.Forms.NumericUpDown();
		this.修罗道_开启消耗 = new System.Windows.Forms.NumericUpDown();
		this.修罗道_开启类型 = new System.Windows.Forms.ComboBox();
		this.修罗道_名字 = new System.Windows.Forms.TextBox();
		this.畜生道_单相 = new System.Windows.Forms.NumericUpDown();
		this.畜生道_所相 = new System.Windows.Forms.NumericUpDown();
		this.畜生道_结束消耗 = new System.Windows.Forms.TextBox();
		this.畜生道_结束条件 = new System.Windows.Forms.ComboBox();
		this.畜生道_开启等级 = new System.Windows.Forms.NumericUpDown();
		this.畜生道_开启消耗 = new System.Windows.Forms.NumericUpDown();
		this.畜生道_开启类型 = new System.Windows.Forms.ComboBox();
		this.畜生道_名字 = new System.Windows.Forms.TextBox();
		this.饿鬼道_单相 = new System.Windows.Forms.NumericUpDown();
		this.饿鬼道_所相 = new System.Windows.Forms.NumericUpDown();
		this.饿鬼道_结束消耗 = new System.Windows.Forms.TextBox();
		this.饿鬼道_结束条件 = new System.Windows.Forms.ComboBox();
		this.饿鬼道_开启等级 = new System.Windows.Forms.NumericUpDown();
		this.饿鬼道_开启消耗 = new System.Windows.Forms.NumericUpDown();
		this.饿鬼道_开启类型 = new System.Windows.Forms.ComboBox();
		this.饿鬼道_名字 = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.地狱道_单相 = new System.Windows.Forms.NumericUpDown();
		this.地狱道_所相 = new System.Windows.Forms.NumericUpDown();
		this.地狱道_结束消耗 = new System.Windows.Forms.TextBox();
		this.地狱道_结束条件 = new System.Windows.Forms.ComboBox();
		this.地狱道_开启等级 = new System.Windows.Forms.NumericUpDown();
		this.地狱道_开启消耗 = new System.Windows.Forms.NumericUpDown();
		this.地狱道_开启类型 = new System.Windows.Forms.ComboBox();
		this.地狱道_名字 = new System.Windows.Forms.TextBox();
		this.六道轮回_刷新消耗 = new System.Windows.Forms.NumericUpDown();
		this.六道轮回_刷新类型 = new System.Windows.Forms.ComboBox();
		this.label8 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.六道轮回_特效道具 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.六道轮回_npc名字 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.六道轮回_最低等级 = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.六道轮回_首级对话 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.天道_单相).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.天道_所相).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.天道_开启等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.天道_开启消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.人道_单相).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.人道_所相).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.人道_开启等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.人道_开启消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修罗道_单相).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修罗道_所相).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修罗道_开启等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.修罗道_开启消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.畜生道_单相).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.畜生道_所相).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.畜生道_开启等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.畜生道_开启消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.饿鬼道_单相).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.饿鬼道_所相).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.饿鬼道_开启等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.饿鬼道_开启消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.地狱道_单相).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.地狱道_所相).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.地狱道_开启等级).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.地狱道_开启消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.六道轮回_刷新消耗).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.六道轮回_最低等级).BeginInit();
		base.SuspendLayout();
		this.六道轮回_开关.AutoSize = true;
		this.六道轮回_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.六道轮回_开关.Location = new System.Drawing.Point(12, 12);
		this.六道轮回_开关.Name = "六道轮回_开关";
		this.六道轮回_开关.Size = new System.Drawing.Size(106, 23);
		this.六道轮回_开关.TabIndex = 99;
		this.六道轮回_开关.Text = "六道轮回开关";
		this.六道轮回_开关.UseVisualStyleBackColor = true;
		this.六道轮回_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.六道轮回_重载按钮.Location = new System.Drawing.Point(230, 8);
		this.六道轮回_重载按钮.Name = "六道轮回_重载按钮";
		this.六道轮回_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.六道轮回_重载按钮.TabIndex = 101;
		this.六道轮回_重载按钮.Text = "重载配置";
		this.六道轮回_重载按钮.UseVisualStyleBackColor = true;
		this.六道轮回_重载按钮.Click += new System.EventHandler(六道轮回_重载按钮_Click);
		this.六道轮回_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.六道轮回_保存按钮.Location = new System.Drawing.Point(124, 8);
		this.六道轮回_保存按钮.Name = "六道轮回_保存按钮";
		this.六道轮回_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.六道轮回_保存按钮.TabIndex = 100;
		this.六道轮回_保存按钮.Text = "保存配置";
		this.六道轮回_保存按钮.UseVisualStyleBackColor = true;
		this.六道轮回_保存按钮.Click += new System.EventHandler(六道轮回_保存按钮_Click);
		this.groupBox1.Controls.Add(this.天道_结束扣除);
		this.groupBox1.Controls.Add(this.人道_结束扣除);
		this.groupBox1.Controls.Add(this.修罗道_结束扣除);
		this.groupBox1.Controls.Add(this.畜生道_结束扣除);
		this.groupBox1.Controls.Add(this.饿鬼道_结束扣除);
		this.groupBox1.Controls.Add(this.地狱道_结束扣除);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.天道_单相);
		this.groupBox1.Controls.Add(this.天道_所相);
		this.groupBox1.Controls.Add(this.天道_结束消耗);
		this.groupBox1.Controls.Add(this.天道_结束条件);
		this.groupBox1.Controls.Add(this.天道_开启等级);
		this.groupBox1.Controls.Add(this.天道_开启消耗);
		this.groupBox1.Controls.Add(this.天道_开启类型);
		this.groupBox1.Controls.Add(this.天道_名字);
		this.groupBox1.Controls.Add(this.人道_单相);
		this.groupBox1.Controls.Add(this.人道_所相);
		this.groupBox1.Controls.Add(this.人道_结束消耗);
		this.groupBox1.Controls.Add(this.人道_结束条件);
		this.groupBox1.Controls.Add(this.人道_开启等级);
		this.groupBox1.Controls.Add(this.人道_开启消耗);
		this.groupBox1.Controls.Add(this.人道_开启类型);
		this.groupBox1.Controls.Add(this.人道_名字);
		this.groupBox1.Controls.Add(this.修罗道_单相);
		this.groupBox1.Controls.Add(this.修罗道_所相);
		this.groupBox1.Controls.Add(this.修罗道_结束消耗);
		this.groupBox1.Controls.Add(this.修罗道_结束条件);
		this.groupBox1.Controls.Add(this.修罗道_开启等级);
		this.groupBox1.Controls.Add(this.修罗道_开启消耗);
		this.groupBox1.Controls.Add(this.修罗道_开启类型);
		this.groupBox1.Controls.Add(this.修罗道_名字);
		this.groupBox1.Controls.Add(this.畜生道_单相);
		this.groupBox1.Controls.Add(this.畜生道_所相);
		this.groupBox1.Controls.Add(this.畜生道_结束消耗);
		this.groupBox1.Controls.Add(this.畜生道_结束条件);
		this.groupBox1.Controls.Add(this.畜生道_开启等级);
		this.groupBox1.Controls.Add(this.畜生道_开启消耗);
		this.groupBox1.Controls.Add(this.畜生道_开启类型);
		this.groupBox1.Controls.Add(this.畜生道_名字);
		this.groupBox1.Controls.Add(this.饿鬼道_单相);
		this.groupBox1.Controls.Add(this.饿鬼道_所相);
		this.groupBox1.Controls.Add(this.饿鬼道_结束消耗);
		this.groupBox1.Controls.Add(this.饿鬼道_结束条件);
		this.groupBox1.Controls.Add(this.饿鬼道_开启等级);
		this.groupBox1.Controls.Add(this.饿鬼道_开启消耗);
		this.groupBox1.Controls.Add(this.饿鬼道_开启类型);
		this.groupBox1.Controls.Add(this.饿鬼道_名字);
		this.groupBox1.Controls.Add(this.label6);
		this.groupBox1.Controls.Add(this.地狱道_单相);
		this.groupBox1.Controls.Add(this.地狱道_所相);
		this.groupBox1.Controls.Add(this.地狱道_结束消耗);
		this.groupBox1.Controls.Add(this.地狱道_结束条件);
		this.groupBox1.Controls.Add(this.地狱道_开启等级);
		this.groupBox1.Controls.Add(this.地狱道_开启消耗);
		this.groupBox1.Controls.Add(this.地狱道_开启类型);
		this.groupBox1.Controls.Add(this.地狱道_名字);
		this.groupBox1.Location = new System.Drawing.Point(12, 106);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(776, 273);
		this.groupBox1.TabIndex = 102;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "六道轮回配置";
		this.天道_结束扣除.AutoSize = true;
		this.天道_结束扣除.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.天道_结束扣除.Location = new System.Drawing.Point(564, 191);
		this.天道_结束扣除.Name = "天道_结束扣除";
		this.天道_结束扣除.Size = new System.Drawing.Size(75, 21);
		this.天道_结束扣除.TabIndex = 172;
		this.天道_结束扣除.Text = "是否扣除";
		this.天道_结束扣除.UseVisualStyleBackColor = true;
		this.人道_结束扣除.AutoSize = true;
		this.人道_结束扣除.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.人道_结束扣除.Location = new System.Drawing.Point(564, 162);
		this.人道_结束扣除.Name = "人道_结束扣除";
		this.人道_结束扣除.Size = new System.Drawing.Size(75, 21);
		this.人道_结束扣除.TabIndex = 171;
		this.人道_结束扣除.Text = "是否扣除";
		this.人道_结束扣除.UseVisualStyleBackColor = true;
		this.修罗道_结束扣除.AutoSize = true;
		this.修罗道_结束扣除.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.修罗道_结束扣除.Location = new System.Drawing.Point(564, 133);
		this.修罗道_结束扣除.Name = "修罗道_结束扣除";
		this.修罗道_结束扣除.Size = new System.Drawing.Size(75, 21);
		this.修罗道_结束扣除.TabIndex = 170;
		this.修罗道_结束扣除.Text = "是否扣除";
		this.修罗道_结束扣除.UseVisualStyleBackColor = true;
		this.畜生道_结束扣除.AutoSize = true;
		this.畜生道_结束扣除.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.畜生道_结束扣除.Location = new System.Drawing.Point(564, 104);
		this.畜生道_结束扣除.Name = "畜生道_结束扣除";
		this.畜生道_结束扣除.Size = new System.Drawing.Size(75, 21);
		this.畜生道_结束扣除.TabIndex = 169;
		this.畜生道_结束扣除.Text = "是否扣除";
		this.畜生道_结束扣除.UseVisualStyleBackColor = true;
		this.饿鬼道_结束扣除.AutoSize = true;
		this.饿鬼道_结束扣除.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.饿鬼道_结束扣除.Location = new System.Drawing.Point(564, 75);
		this.饿鬼道_结束扣除.Name = "饿鬼道_结束扣除";
		this.饿鬼道_结束扣除.Size = new System.Drawing.Size(75, 21);
		this.饿鬼道_结束扣除.TabIndex = 168;
		this.饿鬼道_结束扣除.Text = "是否扣除";
		this.饿鬼道_结束扣除.UseVisualStyleBackColor = true;
		this.地狱道_结束扣除.AutoSize = true;
		this.地狱道_结束扣除.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.地狱道_结束扣除.Location = new System.Drawing.Point(564, 46);
		this.地狱道_结束扣除.Name = "地狱道_结束扣除";
		this.地狱道_结束扣除.Size = new System.Drawing.Size(75, 21);
		this.地狱道_结束扣除.TabIndex = 167;
		this.地狱道_结束扣除.Text = "是否扣除";
		this.地狱道_结束扣除.UseVisualStyleBackColor = true;
		this.label7.ForeColor = System.Drawing.Color.Red;
		this.label7.Location = new System.Drawing.Point(15, 215);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(753, 49);
		this.label7.TabIndex = 166;
		this.label7.Text = "结束条件选择为道具时，道具名字固定为当前轮回阶段+六道名字+·轮回印\r\n例子：需要 饿鬼道·轮回印 结束条件数量为5个\r\n该消耗道具必须写成材料，具体写法可参照后台首页中的材料礼包例子";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.天道_单相.Location = new System.Drawing.Point(708, 190);
		this.天道_单相.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.天道_单相.Name = "天道_单相";
		this.天道_单相.Size = new System.Drawing.Size(60, 23);
		this.天道_单相.TabIndex = 165;
		this.天道_所相.Location = new System.Drawing.Point(642, 190);
		this.天道_所相.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.天道_所相.Name = "天道_所相";
		this.天道_所相.Size = new System.Drawing.Size(60, 23);
		this.天道_所相.TabIndex = 164;
		this.天道_结束消耗.Location = new System.Drawing.Point(460, 190);
		this.天道_结束消耗.Name = "天道_结束消耗";
		this.天道_结束消耗.Size = new System.Drawing.Size(100, 23);
		this.天道_结束消耗.TabIndex = 162;
		this.天道_结束条件.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.天道_结束条件.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.天道_结束条件.FormattingEnabled = true;
		this.天道_结束条件.Items.AddRange(new object[8] { "金元宝", "银元宝", "声望", "道行", "经验", "等级", "道具", "灵气值" });
		this.天道_结束条件.Location = new System.Drawing.Point(379, 189);
		this.天道_结束条件.Name = "天道_结束条件";
		this.天道_结束条件.Size = new System.Drawing.Size(80, 25);
		this.天道_结束条件.TabIndex = 161;
		this.天道_开启等级.Location = new System.Drawing.Point(298, 190);
		this.天道_开启等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.天道_开启等级.Name = "天道_开启等级";
		this.天道_开启等级.Size = new System.Drawing.Size(80, 23);
		this.天道_开启等级.TabIndex = 160;
		this.天道_开启消耗.Location = new System.Drawing.Point(197, 190);
		this.天道_开启消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.天道_开启消耗.Name = "天道_开启消耗";
		this.天道_开启消耗.Size = new System.Drawing.Size(100, 23);
		this.天道_开启消耗.TabIndex = 159;
		this.天道_开启类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.天道_开启类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.天道_开启类型.FormattingEnabled = true;
		this.天道_开启类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.天道_开启类型.Location = new System.Drawing.Point(116, 189);
		this.天道_开启类型.Name = "天道_开启类型";
		this.天道_开启类型.Size = new System.Drawing.Size(80, 25);
		this.天道_开启类型.TabIndex = 158;
		this.天道_名字.Location = new System.Drawing.Point(15, 190);
		this.天道_名字.Name = "天道_名字";
		this.天道_名字.ReadOnly = true;
		this.天道_名字.Size = new System.Drawing.Size(100, 23);
		this.天道_名字.TabIndex = 157;
		this.天道_名字.Text = "天道";
		this.天道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.人道_单相.Location = new System.Drawing.Point(708, 161);
		this.人道_单相.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.人道_单相.Name = "人道_单相";
		this.人道_单相.Size = new System.Drawing.Size(60, 23);
		this.人道_单相.TabIndex = 156;
		this.人道_所相.Location = new System.Drawing.Point(642, 161);
		this.人道_所相.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.人道_所相.Name = "人道_所相";
		this.人道_所相.Size = new System.Drawing.Size(60, 23);
		this.人道_所相.TabIndex = 155;
		this.人道_结束消耗.Location = new System.Drawing.Point(460, 161);
		this.人道_结束消耗.Name = "人道_结束消耗";
		this.人道_结束消耗.Size = new System.Drawing.Size(100, 23);
		this.人道_结束消耗.TabIndex = 153;
		this.人道_结束条件.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.人道_结束条件.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.人道_结束条件.FormattingEnabled = true;
		this.人道_结束条件.Items.AddRange(new object[8] { "金元宝", "银元宝", "声望", "道行", "经验", "等级", "道具", "灵气值" });
		this.人道_结束条件.Location = new System.Drawing.Point(379, 160);
		this.人道_结束条件.Name = "人道_结束条件";
		this.人道_结束条件.Size = new System.Drawing.Size(80, 25);
		this.人道_结束条件.TabIndex = 152;
		this.人道_开启等级.Location = new System.Drawing.Point(298, 161);
		this.人道_开启等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.人道_开启等级.Name = "人道_开启等级";
		this.人道_开启等级.Size = new System.Drawing.Size(80, 23);
		this.人道_开启等级.TabIndex = 151;
		this.人道_开启消耗.Location = new System.Drawing.Point(197, 161);
		this.人道_开启消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.人道_开启消耗.Name = "人道_开启消耗";
		this.人道_开启消耗.Size = new System.Drawing.Size(100, 23);
		this.人道_开启消耗.TabIndex = 150;
		this.人道_开启类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.人道_开启类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.人道_开启类型.FormattingEnabled = true;
		this.人道_开启类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.人道_开启类型.Location = new System.Drawing.Point(116, 160);
		this.人道_开启类型.Name = "人道_开启类型";
		this.人道_开启类型.Size = new System.Drawing.Size(80, 25);
		this.人道_开启类型.TabIndex = 149;
		this.人道_名字.Location = new System.Drawing.Point(15, 161);
		this.人道_名字.Name = "人道_名字";
		this.人道_名字.ReadOnly = true;
		this.人道_名字.Size = new System.Drawing.Size(100, 23);
		this.人道_名字.TabIndex = 148;
		this.人道_名字.Text = "人道";
		this.人道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.修罗道_单相.Location = new System.Drawing.Point(708, 132);
		this.修罗道_单相.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修罗道_单相.Name = "修罗道_单相";
		this.修罗道_单相.Size = new System.Drawing.Size(60, 23);
		this.修罗道_单相.TabIndex = 147;
		this.修罗道_所相.Location = new System.Drawing.Point(642, 132);
		this.修罗道_所相.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修罗道_所相.Name = "修罗道_所相";
		this.修罗道_所相.Size = new System.Drawing.Size(60, 23);
		this.修罗道_所相.TabIndex = 146;
		this.修罗道_结束消耗.Location = new System.Drawing.Point(460, 132);
		this.修罗道_结束消耗.Name = "修罗道_结束消耗";
		this.修罗道_结束消耗.Size = new System.Drawing.Size(100, 23);
		this.修罗道_结束消耗.TabIndex = 144;
		this.修罗道_结束条件.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.修罗道_结束条件.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.修罗道_结束条件.FormattingEnabled = true;
		this.修罗道_结束条件.Items.AddRange(new object[8] { "金元宝", "银元宝", "声望", "道行", "经验", "等级", "道具", "灵气值" });
		this.修罗道_结束条件.Location = new System.Drawing.Point(379, 131);
		this.修罗道_结束条件.Name = "修罗道_结束条件";
		this.修罗道_结束条件.Size = new System.Drawing.Size(80, 25);
		this.修罗道_结束条件.TabIndex = 143;
		this.修罗道_开启等级.Location = new System.Drawing.Point(298, 132);
		this.修罗道_开启等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修罗道_开启等级.Name = "修罗道_开启等级";
		this.修罗道_开启等级.Size = new System.Drawing.Size(80, 23);
		this.修罗道_开启等级.TabIndex = 142;
		this.修罗道_开启消耗.Location = new System.Drawing.Point(197, 132);
		this.修罗道_开启消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.修罗道_开启消耗.Name = "修罗道_开启消耗";
		this.修罗道_开启消耗.Size = new System.Drawing.Size(100, 23);
		this.修罗道_开启消耗.TabIndex = 141;
		this.修罗道_开启类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.修罗道_开启类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.修罗道_开启类型.FormattingEnabled = true;
		this.修罗道_开启类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.修罗道_开启类型.Location = new System.Drawing.Point(116, 131);
		this.修罗道_开启类型.Name = "修罗道_开启类型";
		this.修罗道_开启类型.Size = new System.Drawing.Size(80, 25);
		this.修罗道_开启类型.TabIndex = 140;
		this.修罗道_名字.Location = new System.Drawing.Point(15, 132);
		this.修罗道_名字.Name = "修罗道_名字";
		this.修罗道_名字.ReadOnly = true;
		this.修罗道_名字.Size = new System.Drawing.Size(100, 23);
		this.修罗道_名字.TabIndex = 139;
		this.修罗道_名字.Text = "修罗道";
		this.修罗道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.畜生道_单相.Location = new System.Drawing.Point(708, 103);
		this.畜生道_单相.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.畜生道_单相.Name = "畜生道_单相";
		this.畜生道_单相.Size = new System.Drawing.Size(60, 23);
		this.畜生道_单相.TabIndex = 138;
		this.畜生道_所相.Location = new System.Drawing.Point(642, 103);
		this.畜生道_所相.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.畜生道_所相.Name = "畜生道_所相";
		this.畜生道_所相.Size = new System.Drawing.Size(60, 23);
		this.畜生道_所相.TabIndex = 137;
		this.畜生道_结束消耗.Location = new System.Drawing.Point(460, 103);
		this.畜生道_结束消耗.Name = "畜生道_结束消耗";
		this.畜生道_结束消耗.Size = new System.Drawing.Size(100, 23);
		this.畜生道_结束消耗.TabIndex = 135;
		this.畜生道_结束条件.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.畜生道_结束条件.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.畜生道_结束条件.FormattingEnabled = true;
		this.畜生道_结束条件.Items.AddRange(new object[8] { "金元宝", "银元宝", "声望", "道行", "经验", "等级", "道具", "灵气值" });
		this.畜生道_结束条件.Location = new System.Drawing.Point(379, 102);
		this.畜生道_结束条件.Name = "畜生道_结束条件";
		this.畜生道_结束条件.Size = new System.Drawing.Size(80, 25);
		this.畜生道_结束条件.TabIndex = 134;
		this.畜生道_开启等级.Location = new System.Drawing.Point(298, 103);
		this.畜生道_开启等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.畜生道_开启等级.Name = "畜生道_开启等级";
		this.畜生道_开启等级.Size = new System.Drawing.Size(80, 23);
		this.畜生道_开启等级.TabIndex = 133;
		this.畜生道_开启消耗.Location = new System.Drawing.Point(197, 103);
		this.畜生道_开启消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.畜生道_开启消耗.Name = "畜生道_开启消耗";
		this.畜生道_开启消耗.Size = new System.Drawing.Size(100, 23);
		this.畜生道_开启消耗.TabIndex = 132;
		this.畜生道_开启类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.畜生道_开启类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.畜生道_开启类型.FormattingEnabled = true;
		this.畜生道_开启类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.畜生道_开启类型.Location = new System.Drawing.Point(116, 102);
		this.畜生道_开启类型.Name = "畜生道_开启类型";
		this.畜生道_开启类型.Size = new System.Drawing.Size(80, 25);
		this.畜生道_开启类型.TabIndex = 131;
		this.畜生道_名字.Location = new System.Drawing.Point(15, 103);
		this.畜生道_名字.Name = "畜生道_名字";
		this.畜生道_名字.ReadOnly = true;
		this.畜生道_名字.Size = new System.Drawing.Size(100, 23);
		this.畜生道_名字.TabIndex = 130;
		this.畜生道_名字.Text = "畜生道";
		this.畜生道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.饿鬼道_单相.Location = new System.Drawing.Point(708, 74);
		this.饿鬼道_单相.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.饿鬼道_单相.Name = "饿鬼道_单相";
		this.饿鬼道_单相.Size = new System.Drawing.Size(60, 23);
		this.饿鬼道_单相.TabIndex = 129;
		this.饿鬼道_所相.Location = new System.Drawing.Point(642, 74);
		this.饿鬼道_所相.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.饿鬼道_所相.Name = "饿鬼道_所相";
		this.饿鬼道_所相.Size = new System.Drawing.Size(60, 23);
		this.饿鬼道_所相.TabIndex = 128;
		this.饿鬼道_结束消耗.Location = new System.Drawing.Point(460, 74);
		this.饿鬼道_结束消耗.Name = "饿鬼道_结束消耗";
		this.饿鬼道_结束消耗.Size = new System.Drawing.Size(100, 23);
		this.饿鬼道_结束消耗.TabIndex = 126;
		this.饿鬼道_结束条件.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.饿鬼道_结束条件.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.饿鬼道_结束条件.FormattingEnabled = true;
		this.饿鬼道_结束条件.Items.AddRange(new object[8] { "金元宝", "银元宝", "声望", "道行", "经验", "等级", "道具", "灵气值" });
		this.饿鬼道_结束条件.Location = new System.Drawing.Point(379, 73);
		this.饿鬼道_结束条件.Name = "饿鬼道_结束条件";
		this.饿鬼道_结束条件.Size = new System.Drawing.Size(80, 25);
		this.饿鬼道_结束条件.TabIndex = 125;
		this.饿鬼道_开启等级.Location = new System.Drawing.Point(298, 74);
		this.饿鬼道_开启等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.饿鬼道_开启等级.Name = "饿鬼道_开启等级";
		this.饿鬼道_开启等级.Size = new System.Drawing.Size(80, 23);
		this.饿鬼道_开启等级.TabIndex = 124;
		this.饿鬼道_开启消耗.Location = new System.Drawing.Point(197, 74);
		this.饿鬼道_开启消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.饿鬼道_开启消耗.Name = "饿鬼道_开启消耗";
		this.饿鬼道_开启消耗.Size = new System.Drawing.Size(100, 23);
		this.饿鬼道_开启消耗.TabIndex = 123;
		this.饿鬼道_开启类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.饿鬼道_开启类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.饿鬼道_开启类型.FormattingEnabled = true;
		this.饿鬼道_开启类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.饿鬼道_开启类型.Location = new System.Drawing.Point(116, 73);
		this.饿鬼道_开启类型.Name = "饿鬼道_开启类型";
		this.饿鬼道_开启类型.Size = new System.Drawing.Size(80, 25);
		this.饿鬼道_开启类型.TabIndex = 122;
		this.饿鬼道_名字.Location = new System.Drawing.Point(15, 74);
		this.饿鬼道_名字.Name = "饿鬼道_名字";
		this.饿鬼道_名字.ReadOnly = true;
		this.饿鬼道_名字.Size = new System.Drawing.Size(100, 23);
		this.饿鬼道_名字.TabIndex = 121;
		this.饿鬼道_名字.Text = "饿鬼道";
		this.饿鬼道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label6.Location = new System.Drawing.Point(15, 19);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(753, 23);
		this.label6.TabIndex = 120;
		this.label6.Text = "   六道轮回名字        开启当前六道轮回所需消耗     开启需求等级       结束当前轮回转世所需条件         结束条件    所有相性+    单相性+";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.地狱道_单相.Location = new System.Drawing.Point(708, 45);
		this.地狱道_单相.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.地狱道_单相.Name = "地狱道_单相";
		this.地狱道_单相.Size = new System.Drawing.Size(60, 23);
		this.地狱道_单相.TabIndex = 119;
		this.地狱道_所相.Location = new System.Drawing.Point(642, 45);
		this.地狱道_所相.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.地狱道_所相.Name = "地狱道_所相";
		this.地狱道_所相.Size = new System.Drawing.Size(60, 23);
		this.地狱道_所相.TabIndex = 118;
		this.地狱道_结束消耗.Location = new System.Drawing.Point(460, 45);
		this.地狱道_结束消耗.Name = "地狱道_结束消耗";
		this.地狱道_结束消耗.Size = new System.Drawing.Size(100, 23);
		this.地狱道_结束消耗.TabIndex = 116;
		this.地狱道_结束条件.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.地狱道_结束条件.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.地狱道_结束条件.FormattingEnabled = true;
		this.地狱道_结束条件.Items.AddRange(new object[8] { "金元宝", "银元宝", "声望", "道行", "经验", "等级", "道具", "灵气值" });
		this.地狱道_结束条件.Location = new System.Drawing.Point(379, 44);
		this.地狱道_结束条件.Name = "地狱道_结束条件";
		this.地狱道_结束条件.Size = new System.Drawing.Size(80, 25);
		this.地狱道_结束条件.TabIndex = 115;
		this.地狱道_开启等级.Location = new System.Drawing.Point(298, 45);
		this.地狱道_开启等级.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.地狱道_开启等级.Name = "地狱道_开启等级";
		this.地狱道_开启等级.Size = new System.Drawing.Size(80, 23);
		this.地狱道_开启等级.TabIndex = 114;
		this.地狱道_开启消耗.Location = new System.Drawing.Point(197, 45);
		this.地狱道_开启消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.地狱道_开启消耗.Name = "地狱道_开启消耗";
		this.地狱道_开启消耗.Size = new System.Drawing.Size(100, 23);
		this.地狱道_开启消耗.TabIndex = 113;
		this.地狱道_开启类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.地狱道_开启类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.地狱道_开启类型.FormattingEnabled = true;
		this.地狱道_开启类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.地狱道_开启类型.Location = new System.Drawing.Point(116, 44);
		this.地狱道_开启类型.Name = "地狱道_开启类型";
		this.地狱道_开启类型.Size = new System.Drawing.Size(80, 25);
		this.地狱道_开启类型.TabIndex = 111;
		this.地狱道_名字.Location = new System.Drawing.Point(15, 45);
		this.地狱道_名字.Name = "地狱道_名字";
		this.地狱道_名字.ReadOnly = true;
		this.地狱道_名字.Size = new System.Drawing.Size(100, 23);
		this.地狱道_名字.TabIndex = 0;
		this.地狱道_名字.Text = "地狱道";
		this.地狱道_名字.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.六道轮回_刷新消耗.Location = new System.Drawing.Point(323, 51);
		this.六道轮回_刷新消耗.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.六道轮回_刷新消耗.Name = "六道轮回_刷新消耗";
		this.六道轮回_刷新消耗.Size = new System.Drawing.Size(100, 23);
		this.六道轮回_刷新消耗.TabIndex = 112;
		this.六道轮回_刷新类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.六道轮回_刷新类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.六道轮回_刷新类型.FormattingEnabled = true;
		this.六道轮回_刷新类型.Items.AddRange(new object[3] { "金元宝", "银元宝", "灵气值" });
		this.六道轮回_刷新类型.Location = new System.Drawing.Point(261, 50);
		this.六道轮回_刷新类型.Name = "六道轮回_刷新类型";
		this.六道轮回_刷新类型.Size = new System.Drawing.Size(60, 25);
		this.六道轮回_刷新类型.TabIndex = 110;
		this.label8.BackColor = System.Drawing.Color.Transparent;
		this.label8.Location = new System.Drawing.Point(180, 51);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(80, 23);
		this.label8.TabIndex = 109;
		this.label8.Text = "刷新属性消耗";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label5.Location = new System.Drawing.Point(575, 51);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(60, 23);
		this.label5.TabIndex = 104;
		this.label5.Text = "特效道具";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.六道轮回_特效道具.Location = new System.Drawing.Point(636, 51);
		this.六道轮回_特效道具.Name = "六道轮回_特效道具";
		this.六道轮回_特效道具.Size = new System.Drawing.Size(100, 23);
		this.六道轮回_特效道具.TabIndex = 105;
		this.label4.Location = new System.Drawing.Point(12, 51);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(60, 23);
		this.label4.TabIndex = 102;
		this.label4.Text = "npc名字";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.六道轮回_npc名字.Location = new System.Drawing.Point(73, 51);
		this.六道轮回_npc名字.Name = "六道轮回_npc名字";
		this.六道轮回_npc名字.Size = new System.Drawing.Size(100, 23);
		this.六道轮回_npc名字.TabIndex = 103;
		this.label1.BackColor = System.Drawing.Color.Transparent;
		this.label1.Location = new System.Drawing.Point(429, 51);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(80, 23);
		this.label1.TabIndex = 113;
		this.label1.Text = "最低参与等级";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.六道轮回_最低等级.Location = new System.Drawing.Point(509, 51);
		this.六道轮回_最低等级.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.六道轮回_最低等级.Name = "六道轮回_最低等级";
		this.六道轮回_最低等级.Size = new System.Drawing.Size(60, 23);
		this.六道轮回_最低等级.TabIndex = 114;
		this.label2.Location = new System.Drawing.Point(12, 77);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(60, 23);
		this.label2.TabIndex = 115;
		this.label2.Text = "首级对话";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.六道轮回_首级对话.Location = new System.Drawing.Point(73, 77);
		this.六道轮回_首级对话.Name = "六道轮回_首级对话";
		this.六道轮回_首级对话.Size = new System.Drawing.Size(663, 23);
		this.六道轮回_首级对话.TabIndex = 116;
		this.label3.ForeColor = System.Drawing.Color.Red;
		this.label3.Location = new System.Drawing.Point(336, 8);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(400, 40);
		this.label3.TabIndex = 117;
		this.label3.Text = "特效道具使用后可直接无消耗完成所有六道轮回，且自动激活每个六道的最大属性";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(800, 388);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.六道轮回_首级对话);
		base.Controls.Add(this.六道轮回_最低等级);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.六道轮回_刷新消耗);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.六道轮回_特效道具);
		base.Controls.Add(this.六道轮回_开关);
		base.Controls.Add(this.六道轮回_刷新类型);
		base.Controls.Add(this.六道轮回_重载按钮);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.六道轮回_保存按钮);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.六道轮回_npc名字);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "六道轮回配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "六道轮回配置窗口";
		base.Load += new System.EventHandler(六道轮回配置窗口_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.天道_单相).EndInit();
		((System.ComponentModel.ISupportInitialize)this.天道_所相).EndInit();
		((System.ComponentModel.ISupportInitialize)this.天道_开启等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.天道_开启消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.人道_单相).EndInit();
		((System.ComponentModel.ISupportInitialize)this.人道_所相).EndInit();
		((System.ComponentModel.ISupportInitialize)this.人道_开启等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.人道_开启消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修罗道_单相).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修罗道_所相).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修罗道_开启等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.修罗道_开启消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.畜生道_单相).EndInit();
		((System.ComponentModel.ISupportInitialize)this.畜生道_所相).EndInit();
		((System.ComponentModel.ISupportInitialize)this.畜生道_开启等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.畜生道_开启消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.饿鬼道_单相).EndInit();
		((System.ComponentModel.ISupportInitialize)this.饿鬼道_所相).EndInit();
		((System.ComponentModel.ISupportInitialize)this.饿鬼道_开启等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.饿鬼道_开启消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.地狱道_单相).EndInit();
		((System.ComponentModel.ISupportInitialize)this.地狱道_所相).EndInit();
		((System.ComponentModel.ISupportInitialize)this.地狱道_开启等级).EndInit();
		((System.ComponentModel.ISupportInitialize)this.地狱道_开启消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.六道轮回_刷新消耗).EndInit();
		((System.ComponentModel.ISupportInitialize)this.六道轮回_最低等级).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
