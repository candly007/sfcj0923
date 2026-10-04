using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 调试数据窗口 : Form
{
	public int GID;

	public bool 是否在线;

	public string 当前数据;

	private static 调试数据窗口 i;

	private IContainer components;

	private Button 数据调试_修改按钮;

	private TextBox 数据调试_GID;

	private Label label34;

	private TextBox 数据调试_内容;

	private ComboBox 数据调试_类型;

	private Label label1;

	public static 调试数据窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 调试数据窗口();
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
	}

	public void 初始化()
	{
		数据调试_GID.Text = GID.ToString();
		数据调试_类型.Text = string.Empty;
		数据调试_内容.Text = string.Empty;
	}

	public 调试数据窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 调试数据窗口_Load(object sender, EventArgs e)
	{
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
	}

	private void 数据调试_类型_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = 数据调试_类型.Text;
		if (text == null)
		{
			return;
		}
		int length = text.Length;
		if (length != 6)
		{
			return;
		}
		switch (text[2])
		{
		case '基':
			if (text == "人物基础数据")
			{
				if (!是否在线)
				{
					数据调试_内容.Text = string.Empty;
					break;
				}
				角色数据类 角色数据类3 = JsonConvert.DeserializeObject<角色数据类>(当前数据);
				数据调试_内容.Text = JsonConvert.SerializeObject(角色数据类3.人物数据, Formatting.Indented);
			}
			break;
		case '属':
			if (text == "人物属性数据")
			{
				if (!是否在线)
				{
					数据调试_内容.Text = string.Empty;
					break;
				}
				角色数据类 角色数据类4 = JsonConvert.DeserializeObject<角色数据类>(当前数据);
				数据调试_内容.Text = JsonConvert.SerializeObject(角色数据类4.属性数据, Formatting.Indented);
			}
			break;
		case '背':
			if (text == "人物背包数据")
			{
				if (!是否在线)
				{
					数据调试_内容.Text = string.Empty;
					break;
				}
				角色数据类 角色数据类8 = JsonConvert.DeserializeObject<角色数据类>(当前数据);
				数据调试_内容.Text = JsonConvert.SerializeObject(角色数据类8.背包数据, Formatting.Indented);
			}
			break;
		case '缓':
			if (!(text == "人物缓存数据"))
			{
				if (text == "宠物缓存数据")
				{
					if (!是否在线)
					{
						数据调试_内容.Text = string.Empty;
						break;
					}
					角色数据类 角色数据类5 = JsonConvert.DeserializeObject<角色数据类>(当前数据);
					数据调试_内容.Text = JsonConvert.SerializeObject(角色数据类5.宠物数据, Formatting.Indented);
				}
			}
			else if (!是否在线)
			{
				数据调试_内容.Text = string.Empty;
			}
			else
			{
				角色数据类 角色数据类6 = JsonConvert.DeserializeObject<角色数据类>(当前数据);
				数据调试_内容.Text = JsonConvert.SerializeObject(角色数据类6.缓存数据, Formatting.Indented);
			}
			break;
		case '队':
			if (text == "人物队伍数据")
			{
				if (!是否在线)
				{
					数据调试_内容.Text = string.Empty;
					break;
				}
				角色数据类 角色数据类7 = JsonConvert.DeserializeObject<角色数据类>(当前数据);
				数据调试_内容.Text = JsonConvert.SerializeObject(角色数据类7.队伍数据, Formatting.Indented);
			}
			break;
		case '存':
			if (text == "角色存档数据")
			{
				if (!是否在线)
				{
					数据调试_内容.Text = 当前数据;
					break;
				}
				角色数据类 角色数据类2 = JsonConvert.DeserializeObject<角色数据类>(当前数据);
				数据调试_内容.Text = JsonConvert.SerializeObject(角色数据类2.存档数据, Formatting.Indented);
			}
			break;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.调试数据窗口));
		this.数据调试_修改按钮 = new System.Windows.Forms.Button();
		this.数据调试_GID = new System.Windows.Forms.TextBox();
		this.label34 = new System.Windows.Forms.Label();
		this.数据调试_内容 = new System.Windows.Forms.TextBox();
		this.数据调试_类型 = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.数据调试_修改按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.数据调试_修改按钮.Location = new System.Drawing.Point(451, 14);
		this.数据调试_修改按钮.Name = "数据调试_修改按钮";
		this.数据调试_修改按钮.Size = new System.Drawing.Size(62, 30);
		this.数据调试_修改按钮.TabIndex = 50;
		this.数据调试_修改按钮.Text = "修改";
		this.数据调试_修改按钮.UseVisualStyleBackColor = true;
		this.数据调试_GID.Enabled = false;
		this.数据调试_GID.Location = new System.Drawing.Point(74, 18);
		this.数据调试_GID.Name = "数据调试_GID";
		this.数据调试_GID.Size = new System.Drawing.Size(120, 23);
		this.数据调试_GID.TabIndex = 49;
		this.label34.Location = new System.Drawing.Point(12, 18);
		this.label34.Name = "label34";
		this.label34.Size = new System.Drawing.Size(59, 23);
		this.label34.TabIndex = 48;
		this.label34.Text = "角色GID";
		this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.数据调试_内容.Location = new System.Drawing.Point(12, 50);
		this.数据调试_内容.Multiline = true;
		this.数据调试_内容.Name = "数据调试_内容";
		this.数据调试_内容.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.数据调试_内容.Size = new System.Drawing.Size(960, 599);
		this.数据调试_内容.TabIndex = 52;
		this.数据调试_类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.数据调试_类型.Font = new System.Drawing.Font("Microsoft YaHei UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
		this.数据调试_类型.FormattingEnabled = true;
		this.数据调试_类型.Items.AddRange(new object[7] { "人物基础数据", "人物属性数据", "人物背包数据", "人物缓存数据", "宠物缓存数据", "人物队伍数据", "角色存档数据" });
		this.数据调试_类型.Location = new System.Drawing.Point(265, 17);
		this.数据调试_类型.Name = "数据调试_类型";
		this.数据调试_类型.Size = new System.Drawing.Size(150, 25);
		this.数据调试_类型.TabIndex = 59;
		this.数据调试_类型.SelectedIndexChanged += new System.EventHandler(数据调试_类型_SelectedIndexChanged);
		this.label1.Location = new System.Drawing.Point(205, 18);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(59, 23);
		this.label1.TabIndex = 60;
		this.label1.Text = "数据类型";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(984, 661);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.数据调试_类型);
		base.Controls.Add(this.数据调试_内容);
		base.Controls.Add(this.数据调试_修改按钮);
		base.Controls.Add(this.数据调试_GID);
		base.Controls.Add(this.label34);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "调试数据窗口";
		this.Text = "调试数据窗口";
		base.Load += new System.EventHandler(调试数据窗口_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
