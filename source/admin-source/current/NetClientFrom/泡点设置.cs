using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 泡点设置 : Form
{
	private static 泡点设置 i;

	private IContainer components;

	private CheckBox 泡点_开关;

	private TextBox 泡点_地图;

	private Label label23;

	private Label label1;

	private NumericUpDown 泡点_分钟;

	private Label label16;

	private NumericUpDown 泡点_金元宝;

	private Label label2;

	private NumericUpDown 泡点_银元宝;

	private Label label3;

	private NumericUpDown 泡点_南极点;

	private Label label4;

	private NumericUpDown 泡点_累充点;

	private Label label5;

	private TextBox 泡点_道具名;

	private Label label6;

	private NumericUpDown 泡点_道具数量;

	private Label label7;

	private Button 泡点_重载按钮;

	private Button 泡点_保存按钮;

	private CheckBox 泡点_摆摊双倍开关;

	private TextBox 泡点_双倍道具;

	private Label label8;

	private Label label9;

	private NumericUpDown 泡点_离线奖励时间;

	private Label label10;

	private Label label11;

	private NumericUpDown 泡点_灵气值;

	private Label label12;

	public static 泡点设置 I
	{
		get
		{
			if (i == null)
			{
				i = new 泡点设置();
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

	private 泡点设置()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 泡点设置_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		泡点_重载按钮_Click(sender, e);
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (base.IsHandleCreated && 配置类型 == 4)
		{
			Invoke((MethodInvoker)delegate
			{
				泡点_开关.Checked = Singleton<全局变量类>.I.在线泡点配置.泡点开关;
				泡点_摆摊双倍开关.Checked = Singleton<全局变量类>.I.在线泡点配置.双倍开关;
				泡点_地图.Text = Singleton<全局变量类>.I.在线泡点配置.泡点地图;
				泡点_双倍道具.Text = Singleton<全局变量类>.I.在线泡点配置.泡点道具;
				泡点_分钟.Value = Singleton<全局变量类>.I.在线泡点配置.泡点间隔分钟;
				泡点_金元宝.Value = Singleton<全局变量类>.I.在线泡点配置.泡点奖励金元宝;
				泡点_银元宝.Value = Singleton<全局变量类>.I.在线泡点配置.泡点奖励银元宝;
				泡点_累充点.Value = Singleton<全局变量类>.I.在线泡点配置.泡点奖励累充点;
				泡点_南极点.Value = Singleton<全局变量类>.I.在线泡点配置.泡点奖励南极点;
				泡点_灵气值.Value = Singleton<全局变量类>.I.在线泡点配置.泡点奖励灵气值;
				泡点_道具名.Text = Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具;
				泡点_道具数量.Value = Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量;
				泡点_离线奖励时间.Value = Singleton<全局变量类>.I.在线泡点配置.离线奖励时间;
			});
		}
	}

	private void 配置变量赋值()
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.在线泡点配置.泡点开关 = 泡点_开关.Checked;
			Singleton<全局变量类>.I.在线泡点配置.双倍开关 = 泡点_摆摊双倍开关.Checked;
			Singleton<全局变量类>.I.在线泡点配置.泡点道具 = 泡点_双倍道具.Text;
			Singleton<全局变量类>.I.在线泡点配置.泡点地图 = 泡点_地图.Text;
			Singleton<全局变量类>.I.在线泡点配置.泡点间隔分钟 = (int)泡点_分钟.Value;
			Singleton<全局变量类>.I.在线泡点配置.泡点奖励金元宝 = (int)泡点_金元宝.Value;
			Singleton<全局变量类>.I.在线泡点配置.泡点奖励银元宝 = (int)泡点_银元宝.Value;
			Singleton<全局变量类>.I.在线泡点配置.泡点奖励累充点 = (int)泡点_累充点.Value;
			Singleton<全局变量类>.I.在线泡点配置.泡点奖励南极点 = (int)泡点_南极点.Value;
			Singleton<全局变量类>.I.在线泡点配置.泡点奖励灵气值 = (int)泡点_灵气值.Value;
			Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具 = 泡点_道具名.Text;
			Singleton<全局变量类>.I.在线泡点配置.泡点奖励道具数量 = (int)泡点_道具数量.Value;
			Singleton<全局变量类>.I.在线泡点配置.离线奖励时间 = (int)泡点_离线奖励时间.Value;
		}
	}

	private void 泡点_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 4, JsonConvert.SerializeObject(Singleton<全局变量类>.I.在线泡点配置, Formatting.Indented));
		}
	}

	private void 泡点_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 4);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.泡点设置));
		this.泡点_开关 = new System.Windows.Forms.CheckBox();
		this.泡点_地图 = new System.Windows.Forms.TextBox();
		this.label23 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.泡点_分钟 = new System.Windows.Forms.NumericUpDown();
		this.label16 = new System.Windows.Forms.Label();
		this.泡点_金元宝 = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.泡点_银元宝 = new System.Windows.Forms.NumericUpDown();
		this.label3 = new System.Windows.Forms.Label();
		this.泡点_南极点 = new System.Windows.Forms.NumericUpDown();
		this.label4 = new System.Windows.Forms.Label();
		this.泡点_累充点 = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.泡点_道具名 = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.泡点_道具数量 = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.泡点_重载按钮 = new System.Windows.Forms.Button();
		this.泡点_保存按钮 = new System.Windows.Forms.Button();
		this.泡点_摆摊双倍开关 = new System.Windows.Forms.CheckBox();
		this.泡点_双倍道具 = new System.Windows.Forms.TextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.泡点_离线奖励时间 = new System.Windows.Forms.NumericUpDown();
		this.label10 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.泡点_灵气值 = new System.Windows.Forms.NumericUpDown();
		this.label12 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.泡点_分钟).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_金元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_银元宝).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_南极点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_累充点).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_道具数量).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_离线奖励时间).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_灵气值).BeginInit();
		base.SuspendLayout();
		this.泡点_开关.AutoSize = true;
		this.泡点_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.泡点_开关.Location = new System.Drawing.Point(12, 12);
		this.泡点_开关.Name = "泡点_开关";
		this.泡点_开关.Size = new System.Drawing.Size(80, 23);
		this.泡点_开关.TabIndex = 2;
		this.泡点_开关.Text = "泡点开关";
		this.泡点_开关.UseVisualStyleBackColor = true;
		this.泡点_地图.Location = new System.Drawing.Point(74, 70);
		this.泡点_地图.Name = "泡点_地图";
		this.泡点_地图.Size = new System.Drawing.Size(378, 23);
		this.泡点_地图.TabIndex = 30;
		this.label23.Location = new System.Drawing.Point(12, 70);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(65, 23);
		this.label23.TabIndex = 29;
		this.label23.Text = "泡点地图";
		this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label1.ForeColor = System.Drawing.Color.Red;
		this.label1.Location = new System.Drawing.Point(74, 93);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(381, 23);
		this.label1.TabIndex = 31;
		this.label1.Text = "0表示全部地图(不包括特殊地图)，例子：|天墉城|东海渔村|";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.泡点_分钟.Location = new System.Drawing.Point(74, 122);
		this.泡点_分钟.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.泡点_分钟.Name = "泡点_分钟";
		this.泡点_分钟.Size = new System.Drawing.Size(42, 23);
		this.泡点_分钟.TabIndex = 33;
		this.label16.Location = new System.Drawing.Point(12, 122);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(65, 23);
		this.label16.TabIndex = 32;
		this.label16.Text = "泡点分钟";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.泡点_金元宝.Location = new System.Drawing.Point(74, 154);
		this.泡点_金元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.泡点_金元宝.Name = "泡点_金元宝";
		this.泡点_金元宝.Size = new System.Drawing.Size(164, 23);
		this.泡点_金元宝.TabIndex = 35;
		this.label2.Location = new System.Drawing.Point(23, 154);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(50, 23);
		this.label2.TabIndex = 34;
		this.label2.Text = "金元宝";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.泡点_银元宝.Location = new System.Drawing.Point(296, 154);
		this.泡点_银元宝.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.泡点_银元宝.Name = "泡点_银元宝";
		this.泡点_银元宝.Size = new System.Drawing.Size(156, 23);
		this.泡点_银元宝.TabIndex = 37;
		this.label3.Location = new System.Drawing.Point(244, 154);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(50, 23);
		this.label3.TabIndex = 36;
		this.label3.Text = "银元宝";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.泡点_南极点.Location = new System.Drawing.Point(296, 180);
		this.泡点_南极点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.泡点_南极点.Name = "泡点_南极点";
		this.泡点_南极点.Size = new System.Drawing.Size(156, 23);
		this.泡点_南极点.TabIndex = 41;
		this.label4.Location = new System.Drawing.Point(244, 180);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(50, 23);
		this.label4.TabIndex = 40;
		this.label4.Text = "南极点";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.泡点_累充点.Location = new System.Drawing.Point(74, 180);
		this.泡点_累充点.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.泡点_累充点.Name = "泡点_累充点";
		this.泡点_累充点.Size = new System.Drawing.Size(164, 23);
		this.泡点_累充点.TabIndex = 39;
		this.label5.Location = new System.Drawing.Point(23, 180);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(50, 23);
		this.label5.TabIndex = 38;
		this.label5.Text = "累充点";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.泡点_道具名.Location = new System.Drawing.Point(74, 207);
		this.泡点_道具名.Name = "泡点_道具名";
		this.泡点_道具名.Size = new System.Drawing.Size(101, 23);
		this.泡点_道具名.TabIndex = 43;
		this.label6.Location = new System.Drawing.Point(23, 207);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(50, 23);
		this.label6.TabIndex = 42;
		this.label6.Text = "道具名";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.泡点_道具数量.Location = new System.Drawing.Point(198, 207);
		this.泡点_道具数量.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.泡点_道具数量.Name = "泡点_道具数量";
		this.泡点_道具数量.Size = new System.Drawing.Size(40, 23);
		this.泡点_道具数量.TabIndex = 45;
		this.label7.Location = new System.Drawing.Point(181, 207);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(15, 23);
		this.label7.TabIndex = 44;
		this.label7.Text = "×";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.泡点_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.泡点_重载按钮.Location = new System.Drawing.Point(210, 243);
		this.泡点_重载按钮.Name = "泡点_重载按钮";
		this.泡点_重载按钮.Size = new System.Drawing.Size(130, 30);
		this.泡点_重载按钮.TabIndex = 47;
		this.泡点_重载按钮.Text = "重载泡点配置";
		this.泡点_重载按钮.UseVisualStyleBackColor = true;
		this.泡点_重载按钮.Click += new System.EventHandler(泡点_重载按钮_Click);
		this.泡点_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.泡点_保存按钮.Location = new System.Drawing.Point(74, 243);
		this.泡点_保存按钮.Name = "泡点_保存按钮";
		this.泡点_保存按钮.Size = new System.Drawing.Size(130, 30);
		this.泡点_保存按钮.TabIndex = 46;
		this.泡点_保存按钮.Text = "保存泡点配置";
		this.泡点_保存按钮.UseVisualStyleBackColor = true;
		this.泡点_保存按钮.Click += new System.EventHandler(泡点_保存按钮_Click);
		this.泡点_摆摊双倍开关.AutoSize = true;
		this.泡点_摆摊双倍开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.泡点_摆摊双倍开关.Location = new System.Drawing.Point(100, 12);
		this.泡点_摆摊双倍开关.Name = "泡点_摆摊双倍开关";
		this.泡点_摆摊双倍开关.Size = new System.Drawing.Size(132, 23);
		this.泡点_摆摊双倍开关.TabIndex = 48;
		this.泡点_摆摊双倍开关.Text = "摆摊双倍泡点开关";
		this.泡点_摆摊双倍开关.UseVisualStyleBackColor = true;
		this.泡点_双倍道具.Location = new System.Drawing.Point(74, 41);
		this.泡点_双倍道具.Name = "泡点_双倍道具";
		this.泡点_双倍道具.Size = new System.Drawing.Size(106, 23);
		this.泡点_双倍道具.TabIndex = 50;
		this.label8.Location = new System.Drawing.Point(12, 41);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(65, 23);
		this.label8.TabIndex = 49;
		this.label8.Text = "泡点道具";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label9.ForeColor = System.Drawing.Color.Red;
		this.label9.Location = new System.Drawing.Point(181, 41);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(271, 23);
		this.label9.TabIndex = 51;
		this.label9.Text = "摆摊双倍泡点要求使用的道具";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.泡点_离线奖励时间.Location = new System.Drawing.Point(250, 122);
		this.泡点_离线奖励时间.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.泡点_离线奖励时间.Name = "泡点_离线奖励时间";
		this.泡点_离线奖励时间.Size = new System.Drawing.Size(64, 23);
		this.泡点_离线奖励时间.TabIndex = 53;
		this.label10.Location = new System.Drawing.Point(122, 122);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(129, 23);
		this.label10.TabIndex = 52;
		this.label10.Text = "离线奖励最多领取时间";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label11.Location = new System.Drawing.Point(316, 121);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(41, 23);
		this.label11.TabIndex = 54;
		this.label11.Text = "小时";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.泡点_灵气值.Location = new System.Drawing.Point(296, 207);
		this.泡点_灵气值.Maximum = new decimal(new int[4] { 2000000000, 0, 0, 0 });
		this.泡点_灵气值.Name = "泡点_灵气值";
		this.泡点_灵气值.Size = new System.Drawing.Size(156, 23);
		this.泡点_灵气值.TabIndex = 56;
		this.label12.Location = new System.Drawing.Point(244, 207);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(50, 23);
		this.label12.TabIndex = 55;
		this.label12.Text = "灵气值";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(467, 287);
		base.Controls.Add(this.泡点_灵气值);
		base.Controls.Add(this.label12);
		base.Controls.Add(this.label11);
		base.Controls.Add(this.泡点_离线奖励时间);
		base.Controls.Add(this.label10);
		base.Controls.Add(this.label9);
		base.Controls.Add(this.泡点_双倍道具);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.泡点_摆摊双倍开关);
		base.Controls.Add(this.泡点_重载按钮);
		base.Controls.Add(this.泡点_保存按钮);
		base.Controls.Add(this.泡点_道具数量);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.泡点_道具名);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.泡点_南极点);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.泡点_累充点);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.泡点_银元宝);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.泡点_金元宝);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.泡点_分钟);
		base.Controls.Add(this.label16);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.泡点_地图);
		base.Controls.Add(this.label23);
		base.Controls.Add(this.泡点_开关);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "泡点设置";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "泡点设置";
		base.Load += new System.EventHandler(泡点设置_Load);
		((System.ComponentModel.ISupportInitialize)this.泡点_分钟).EndInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_金元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_银元宝).EndInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_南极点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_累充点).EndInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_道具数量).EndInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_离线奖励时间).EndInit();
		((System.ComponentModel.ISupportInitialize)this.泡点_灵气值).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
