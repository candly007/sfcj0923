using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public class 召唤精怪配置窗口 : Form
{
	private static 召唤精怪配置窗口 i;

	private IContainer components;

	private CheckBox 抓精怪_开关;

	private Button 抓精怪_重载按钮;

	private Button 抓精怪_保存按钮;

	private DataGridView 珊瑚列表;

	private DataGridViewTextBoxColumn 礼包名字;

	private DataGridViewTextBoxColumn 获得几率;

	private DataGridViewTextBoxColumn 最低元宝;

	private DataGridViewTextBoxColumn 最高元宝;

	private TabControl 材料总集;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private TabPage tabPage3;

	private TabPage tabPage4;

	private TabPage tabPage5;

	private TabPage tabPage6;

	private TabPage tabPage7;

	private TabPage tabPage8;

	private TabPage tabPage9;

	private TabPage tabPage10;

	private TabPage tabPage11;

	private TabPage tabPage12;

	private DataGridView 还阳露列表;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridView 醉仙酒列表;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridView 五彩香列表;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private DataGridView 仙露草列表;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

	private DataGridView 百草集列表;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

	private DataGridView 凝香草列表;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;

	private DataGridView 醒狮丹列表;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;

	private DataGridView 鱼仙饵列表;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;

	private DataGridView 猿兽丹列表;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;

	private DataGridView 菩提子列表;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;

	private DataGridView 御仙饮列表;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;

	public static 召唤精怪配置窗口 I
	{
		get
		{
			if (i == null)
			{
				i = new 召唤精怪配置窗口();
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

	public 召唤精怪配置窗口()
	{
		base.AutoScaleMode = AutoScaleMode.Dpi;
		Control.CheckForIllegalCrossThreadCalls = false;
		InitializeComponent();
	}

	private void 召唤精怪配置窗口_Load(object sender, EventArgs e)
	{
		珊瑚列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 珊瑚删除事件回调);
		还阳露列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 还阳露删除事件回调);
		醉仙酒列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 醉仙酒删除事件回调);
		五彩香列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 五彩香删除事件回调);
		仙露草列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 仙露草删除事件回调);
		百草集列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 百草集删除事件回调);
		凝香草列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 凝香草删除事件回调);
		醒狮丹列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 醒狮丹删除事件回调);
		鱼仙饵列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 鱼仙饵删除事件回调);
		猿兽丹列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 猿兽丹删除事件回调);
		菩提子列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 菩提子删除事件回调);
		御仙饮列表.ContextMenuStrip = Singleton<定义菜单类>.I.创建修改删除菜单(null, 御仙饮删除事件回调);
		Singleton<全局变量类>.I.验证client.AddRpcHandle(this);
		全局变量类 obj = Singleton<全局变量类>.I;
		obj.读取配置事件 = (Action<int>)Delegate.Combine(obj.读取配置事件, new Action<int>(界面组件赋值));
		抓精怪_重载按钮_Click(sender, e);
	}

	private void 珊瑚删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 珊瑚列表.CurrentRow != null)
		{
			int index = 珊瑚列表.CurrentRow.Index;
			if (index >= 0)
			{
				珊瑚列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 还阳露删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 还阳露列表.CurrentRow != null)
		{
			int index = 还阳露列表.CurrentRow.Index;
			if (index >= 0)
			{
				还阳露列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 醉仙酒删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 醉仙酒列表.CurrentRow != null)
		{
			int index = 醉仙酒列表.CurrentRow.Index;
			if (index >= 0)
			{
				醉仙酒列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 五彩香删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 五彩香列表.CurrentRow != null)
		{
			int index = 五彩香列表.CurrentRow.Index;
			if (index >= 0)
			{
				五彩香列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 仙露草删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 仙露草列表.CurrentRow != null)
		{
			int index = 仙露草列表.CurrentRow.Index;
			if (index >= 0)
			{
				仙露草列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 百草集删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 百草集列表.CurrentRow != null)
		{
			int index = 百草集列表.CurrentRow.Index;
			if (index >= 0)
			{
				百草集列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 凝香草删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 凝香草列表.CurrentRow != null)
		{
			int index = 凝香草列表.CurrentRow.Index;
			if (index >= 0)
			{
				凝香草列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 醒狮丹删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 醒狮丹列表.CurrentRow != null)
		{
			int index = 醒狮丹列表.CurrentRow.Index;
			if (index >= 0)
			{
				醒狮丹列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 鱼仙饵删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 鱼仙饵列表.CurrentRow != null)
		{
			int index = 鱼仙饵列表.CurrentRow.Index;
			if (index >= 0)
			{
				鱼仙饵列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 猿兽丹删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 猿兽丹列表.CurrentRow != null)
		{
			int index = 猿兽丹列表.CurrentRow.Index;
			if (index >= 0)
			{
				猿兽丹列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 菩提子删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 菩提子列表.CurrentRow != null)
		{
			int index = 菩提子列表.CurrentRow.Index;
			if (index >= 0)
			{
				菩提子列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 御仙饮删除事件回调(object sender, EventArgs e)
	{
		if (base.IsHandleCreated && 御仙饮列表.CurrentRow != null)
		{
			int index = 御仙饮列表.CurrentRow.Index;
			if (index >= 0)
			{
				御仙饮列表.Rows.RemoveAt(index);
			}
		}
	}

	private void 界面组件赋值(int 配置类型)
	{
		if (!base.IsHandleCreated || 配置类型 != 44)
		{
			return;
		}
		抓精怪_开关.Checked = Singleton<全局变量类>.I.召唤精怪配置.功能开关;
		珊瑚列表.Rows.Clear();
		还阳露列表.Rows.Clear();
		醉仙酒列表.Rows.Clear();
		五彩香列表.Rows.Clear();
		仙露草列表.Rows.Clear();
		百草集列表.Rows.Clear();
		凝香草列表.Rows.Clear();
		醒狮丹列表.Rows.Clear();
		鱼仙饵列表.Rows.Clear();
		猿兽丹列表.Rows.Clear();
		菩提子列表.Rows.Clear();
		御仙饮列表.Rows.Clear();
		if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.珊瑚, out List<召唤精怪列表类> 珊瑚掉落))
		{
			珊瑚掉落.Sort();
			珊瑚列表.Invoke((MethodInvoker)delegate
			{
				foreach (召唤精怪列表类 item in 珊瑚掉落)
				{
					珊瑚列表.Rows.Add(item.召唤材料, item.礼包名字, item.获得几率, item.镇压宠物, item.最低银元宝, item.最高银元宝, item.平均银元宝);
				}
			});
		}
		if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.还阳露, out List<召唤精怪列表类> 还阳露掉落))
		{
			还阳露掉落.Sort();
			还阳露列表.Invoke((MethodInvoker)delegate
			{
				foreach (召唤精怪列表类 item2 in 还阳露掉落)
				{
					还阳露列表.Rows.Add(item2.召唤材料, item2.礼包名字, item2.获得几率, item2.镇压宠物, item2.最低银元宝, item2.最高银元宝, item2.平均银元宝);
				}
			});
		}
		if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.醉仙酒, out List<召唤精怪列表类> 醉仙酒掉落))
		{
			醉仙酒掉落.Sort();
			醉仙酒列表.Invoke((MethodInvoker)delegate
			{
				foreach (召唤精怪列表类 item3 in 醉仙酒掉落)
				{
					醉仙酒列表.Rows.Add(item3.召唤材料, item3.礼包名字, item3.获得几率, item3.镇压宠物, item3.最低银元宝, item3.最高银元宝, item3.平均银元宝);
				}
			});
		}
		if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.五彩香, out List<召唤精怪列表类> 五彩香掉落))
		{
			五彩香掉落.Sort();
			五彩香列表.Invoke((MethodInvoker)delegate
			{
				foreach (召唤精怪列表类 item4 in 五彩香掉落)
				{
					五彩香列表.Rows.Add(item4.召唤材料, item4.礼包名字, item4.获得几率, item4.镇压宠物, item4.最低银元宝, item4.最高银元宝, item4.平均银元宝);
				}
			});
		}
		if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.仙露草, out List<召唤精怪列表类> 仙露草掉落))
		{
			仙露草掉落.Sort();
			仙露草列表.Invoke((MethodInvoker)delegate
			{
				foreach (召唤精怪列表类 item5 in 仙露草掉落)
				{
					仙露草列表.Rows.Add(item5.召唤材料, item5.礼包名字, item5.获得几率, item5.镇压宠物, item5.最低银元宝, item5.最高银元宝, item5.平均银元宝);
				}
			});
		}
		if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.百草集, out List<召唤精怪列表类> 百草集掉落))
		{
			百草集掉落.Sort();
			百草集列表.Invoke((MethodInvoker)delegate
			{
				foreach (召唤精怪列表类 item6 in 百草集掉落)
				{
					百草集列表.Rows.Add(item6.召唤材料, item6.礼包名字, item6.获得几率, item6.镇压宠物, item6.最低银元宝, item6.最高银元宝, item6.平均银元宝);
				}
			});
		}
		if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.凝香草, out List<召唤精怪列表类> 凝香草掉落))
		{
			凝香草掉落.Sort();
			凝香草列表.Invoke((MethodInvoker)delegate
			{
				foreach (召唤精怪列表类 item7 in 凝香草掉落)
				{
					凝香草列表.Rows.Add(item7.召唤材料, item7.礼包名字, item7.获得几率, item7.镇压宠物, item7.最低银元宝, item7.最高银元宝, item7.平均银元宝);
				}
			});
		}
		if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.醒狮丹, out List<召唤精怪列表类> 醒狮丹掉落))
		{
			醒狮丹掉落.Sort();
			醒狮丹列表.Invoke((MethodInvoker)delegate
			{
				foreach (召唤精怪列表类 item8 in 醒狮丹掉落)
				{
					醒狮丹列表.Rows.Add(item8.召唤材料, item8.礼包名字, item8.获得几率, item8.镇压宠物, item8.最低银元宝, item8.最高银元宝, item8.平均银元宝);
				}
			});
		}
		if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.鱼仙饵, out List<召唤精怪列表类> 鱼仙饵掉落))
		{
			鱼仙饵掉落.Sort();
			鱼仙饵列表.Invoke((MethodInvoker)delegate
			{
				foreach (召唤精怪列表类 item9 in 鱼仙饵掉落)
				{
					鱼仙饵列表.Rows.Add(item9.召唤材料, item9.礼包名字, item9.获得几率, item9.镇压宠物, item9.最低银元宝, item9.最高银元宝, item9.平均银元宝);
				}
			});
		}
		if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.猿兽丹, out List<召唤精怪列表类> 猿兽丹掉落))
		{
			猿兽丹掉落.Sort();
			猿兽丹列表.Invoke((MethodInvoker)delegate
			{
				foreach (召唤精怪列表类 item10 in 猿兽丹掉落)
				{
					猿兽丹列表.Rows.Add(item10.召唤材料, item10.礼包名字, item10.获得几率, item10.镇压宠物, item10.最低银元宝, item10.最高银元宝, item10.平均银元宝);
				}
			});
		}
		if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.菩提子, out List<召唤精怪列表类> 菩提子掉落))
		{
			菩提子掉落.Sort();
			菩提子列表.Invoke((MethodInvoker)delegate
			{
				foreach (召唤精怪列表类 item11 in 菩提子掉落)
				{
					菩提子列表.Rows.Add(item11.召唤材料, item11.礼包名字, item11.获得几率, item11.镇压宠物, item11.最低银元宝, item11.最高银元宝, item11.平均银元宝);
				}
			});
		}
		if (!Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.御仙饮, out List<召唤精怪列表类> 御仙饮掉落))
		{
			return;
		}
		御仙饮掉落.Sort();
		御仙饮列表.Invoke((MethodInvoker)delegate
		{
			foreach (召唤精怪列表类 item12 in 御仙饮掉落)
			{
				御仙饮列表.Rows.Add(item12.召唤材料, item12.礼包名字, item12.获得几率, item12.镇压宠物, item12.最低银元宝, item12.最高银元宝, item12.平均银元宝);
			}
		});
	}

	private void 配置变量赋值()
	{
		if (!base.IsHandleCreated)
		{
			return;
		}
		Singleton<全局变量类>.I.召唤精怪配置.功能开关 = 抓精怪_开关.Checked;
		Singleton<全局变量类>.I.召唤精怪配置.召唤列表.Clear();
		DataGridViewCellCollection cells = 珊瑚列表.Rows[0].Cells;
		for (int i = 0; i < 珊瑚列表.Rows.Count; i++)
		{
			cells = 珊瑚列表.Rows[i].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value?.ToString()))
			{
				if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.珊瑚, out List<召唤精怪列表类> value))
				{
					value.Add(new 召唤精怪列表类
					{
						召唤材料 = AllEnums.召唤材料Type.珊瑚,
						礼包名字 = Convert.ToString(cells[0].Value),
						获得几率 = Convert.ToInt32(cells[1].Value),
						镇压宠物 = Convert.ToString(cells[2].Value),
						最低银元宝 = Convert.ToInt32(cells[3].Value),
						最高银元宝 = Convert.ToInt32(cells[4].Value),
						平均银元宝 = Convert.ToInt32(cells[5].Value)
					});
				}
				else
				{
					Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryAdd(AllEnums.召唤材料Type.珊瑚, new List<召唤精怪列表类>
					{
						new 召唤精怪列表类
						{
							召唤材料 = AllEnums.召唤材料Type.珊瑚,
							礼包名字 = Convert.ToString(cells[0].Value),
							获得几率 = Convert.ToInt32(cells[1].Value),
							镇压宠物 = Convert.ToString(cells[2].Value),
							最低银元宝 = Convert.ToInt32(cells[3].Value),
							最高银元宝 = Convert.ToInt32(cells[4].Value),
							平均银元宝 = Convert.ToInt32(cells[5].Value)
						}
					});
				}
			}
		}
		for (int j = 0; j < 还阳露列表.Rows.Count; j++)
		{
			cells = 还阳露列表.Rows[j].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value?.ToString()))
			{
				if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.还阳露, out List<召唤精怪列表类> value2))
				{
					value2.Add(new 召唤精怪列表类
					{
						召唤材料 = AllEnums.召唤材料Type.还阳露,
						礼包名字 = Convert.ToString(cells[0].Value),
						获得几率 = Convert.ToInt32(cells[1].Value),
						镇压宠物 = Convert.ToString(cells[2].Value),
						最低银元宝 = Convert.ToInt32(cells[3].Value),
						最高银元宝 = Convert.ToInt32(cells[4].Value),
						平均银元宝 = Convert.ToInt32(cells[5].Value)
					});
				}
				else
				{
					Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryAdd(AllEnums.召唤材料Type.还阳露, new List<召唤精怪列表类>
					{
						new 召唤精怪列表类
						{
							召唤材料 = AllEnums.召唤材料Type.还阳露,
							礼包名字 = Convert.ToString(cells[0].Value),
							获得几率 = Convert.ToInt32(cells[1].Value),
							镇压宠物 = Convert.ToString(cells[2].Value),
							最低银元宝 = Convert.ToInt32(cells[3].Value),
							最高银元宝 = Convert.ToInt32(cells[4].Value),
							平均银元宝 = Convert.ToInt32(cells[5].Value)
						}
					});
				}
			}
		}
		for (int k = 0; k < 醉仙酒列表.Rows.Count; k++)
		{
			cells = 醉仙酒列表.Rows[k].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value?.ToString()))
			{
				if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.醉仙酒, out List<召唤精怪列表类> value3))
				{
					value3.Add(new 召唤精怪列表类
					{
						召唤材料 = AllEnums.召唤材料Type.醉仙酒,
						礼包名字 = Convert.ToString(cells[0].Value),
						获得几率 = Convert.ToInt32(cells[1].Value),
						镇压宠物 = Convert.ToString(cells[2].Value),
						最低银元宝 = Convert.ToInt32(cells[3].Value),
						最高银元宝 = Convert.ToInt32(cells[4].Value),
						平均银元宝 = Convert.ToInt32(cells[5].Value)
					});
				}
				else
				{
					Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryAdd(AllEnums.召唤材料Type.醉仙酒, new List<召唤精怪列表类>
					{
						new 召唤精怪列表类
						{
							召唤材料 = AllEnums.召唤材料Type.醉仙酒,
							礼包名字 = Convert.ToString(cells[0].Value),
							获得几率 = Convert.ToInt32(cells[1].Value),
							镇压宠物 = Convert.ToString(cells[2].Value),
							最低银元宝 = Convert.ToInt32(cells[3].Value),
							最高银元宝 = Convert.ToInt32(cells[4].Value),
							平均银元宝 = Convert.ToInt32(cells[5].Value)
						}
					});
				}
			}
		}
		for (int l = 0; l < 五彩香列表.Rows.Count; l++)
		{
			cells = 五彩香列表.Rows[l].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value?.ToString()))
			{
				if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.五彩香, out List<召唤精怪列表类> value4))
				{
					value4.Add(new 召唤精怪列表类
					{
						召唤材料 = AllEnums.召唤材料Type.五彩香,
						礼包名字 = Convert.ToString(cells[0].Value),
						获得几率 = Convert.ToInt32(cells[1].Value),
						镇压宠物 = Convert.ToString(cells[2].Value),
						最低银元宝 = Convert.ToInt32(cells[3].Value),
						最高银元宝 = Convert.ToInt32(cells[4].Value),
						平均银元宝 = Convert.ToInt32(cells[5].Value)
					});
				}
				else
				{
					Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryAdd(AllEnums.召唤材料Type.五彩香, new List<召唤精怪列表类>
					{
						new 召唤精怪列表类
						{
							召唤材料 = AllEnums.召唤材料Type.五彩香,
							礼包名字 = Convert.ToString(cells[0].Value),
							获得几率 = Convert.ToInt32(cells[1].Value),
							镇压宠物 = Convert.ToString(cells[2].Value),
							最低银元宝 = Convert.ToInt32(cells[3].Value),
							最高银元宝 = Convert.ToInt32(cells[4].Value),
							平均银元宝 = Convert.ToInt32(cells[5].Value)
						}
					});
				}
			}
		}
		for (int m = 0; m < 仙露草列表.Rows.Count; m++)
		{
			cells = 仙露草列表.Rows[m].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value?.ToString()))
			{
				if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.仙露草, out List<召唤精怪列表类> value5))
				{
					value5.Add(new 召唤精怪列表类
					{
						召唤材料 = AllEnums.召唤材料Type.仙露草,
						礼包名字 = Convert.ToString(cells[0].Value),
						获得几率 = Convert.ToInt32(cells[1].Value),
						镇压宠物 = Convert.ToString(cells[2].Value),
						最低银元宝 = Convert.ToInt32(cells[3].Value),
						最高银元宝 = Convert.ToInt32(cells[4].Value),
						平均银元宝 = Convert.ToInt32(cells[5].Value)
					});
				}
				else
				{
					Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryAdd(AllEnums.召唤材料Type.仙露草, new List<召唤精怪列表类>
					{
						new 召唤精怪列表类
						{
							召唤材料 = AllEnums.召唤材料Type.仙露草,
							礼包名字 = Convert.ToString(cells[0].Value),
							获得几率 = Convert.ToInt32(cells[1].Value),
							镇压宠物 = Convert.ToString(cells[2].Value),
							最低银元宝 = Convert.ToInt32(cells[3].Value),
							最高银元宝 = Convert.ToInt32(cells[4].Value),
							平均银元宝 = Convert.ToInt32(cells[5].Value)
						}
					});
				}
			}
		}
		for (int n = 0; n < 百草集列表.Rows.Count; n++)
		{
			cells = 百草集列表.Rows[n].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value?.ToString()))
			{
				if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.百草集, out List<召唤精怪列表类> value6))
				{
					value6.Add(new 召唤精怪列表类
					{
						召唤材料 = AllEnums.召唤材料Type.百草集,
						礼包名字 = Convert.ToString(cells[0].Value),
						获得几率 = Convert.ToInt32(cells[1].Value),
						镇压宠物 = Convert.ToString(cells[2].Value),
						最低银元宝 = Convert.ToInt32(cells[3].Value),
						最高银元宝 = Convert.ToInt32(cells[4].Value),
						平均银元宝 = Convert.ToInt32(cells[5].Value)
					});
				}
				else
				{
					Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryAdd(AllEnums.召唤材料Type.百草集, new List<召唤精怪列表类>
					{
						new 召唤精怪列表类
						{
							召唤材料 = AllEnums.召唤材料Type.百草集,
							礼包名字 = Convert.ToString(cells[0].Value),
							获得几率 = Convert.ToInt32(cells[1].Value),
							镇压宠物 = Convert.ToString(cells[2].Value),
							最低银元宝 = Convert.ToInt32(cells[3].Value),
							最高银元宝 = Convert.ToInt32(cells[4].Value),
							平均银元宝 = Convert.ToInt32(cells[5].Value)
						}
					});
				}
			}
		}
		for (int num = 0; num < 凝香草列表.Rows.Count; num++)
		{
			cells = 凝香草列表.Rows[num].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value?.ToString()))
			{
				if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.凝香草, out List<召唤精怪列表类> value7))
				{
					value7.Add(new 召唤精怪列表类
					{
						召唤材料 = AllEnums.召唤材料Type.凝香草,
						礼包名字 = Convert.ToString(cells[0].Value),
						获得几率 = Convert.ToInt32(cells[1].Value),
						镇压宠物 = Convert.ToString(cells[2].Value),
						最低银元宝 = Convert.ToInt32(cells[3].Value),
						最高银元宝 = Convert.ToInt32(cells[4].Value),
						平均银元宝 = Convert.ToInt32(cells[5].Value)
					});
				}
				else
				{
					Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryAdd(AllEnums.召唤材料Type.凝香草, new List<召唤精怪列表类>
					{
						new 召唤精怪列表类
						{
							召唤材料 = AllEnums.召唤材料Type.凝香草,
							礼包名字 = Convert.ToString(cells[0].Value),
							获得几率 = Convert.ToInt32(cells[1].Value),
							镇压宠物 = Convert.ToString(cells[2].Value),
							最低银元宝 = Convert.ToInt32(cells[3].Value),
							最高银元宝 = Convert.ToInt32(cells[4].Value),
							平均银元宝 = Convert.ToInt32(cells[5].Value)
						}
					});
				}
			}
		}
		for (int num2 = 0; num2 < 醒狮丹列表.Rows.Count; num2++)
		{
			cells = 醒狮丹列表.Rows[num2].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value?.ToString()))
			{
				if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.醒狮丹, out List<召唤精怪列表类> value8))
				{
					value8.Add(new 召唤精怪列表类
					{
						召唤材料 = AllEnums.召唤材料Type.醒狮丹,
						礼包名字 = Convert.ToString(cells[0].Value),
						获得几率 = Convert.ToInt32(cells[1].Value),
						镇压宠物 = Convert.ToString(cells[2].Value),
						最低银元宝 = Convert.ToInt32(cells[3].Value),
						最高银元宝 = Convert.ToInt32(cells[4].Value),
						平均银元宝 = Convert.ToInt32(cells[5].Value)
					});
				}
				else
				{
					Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryAdd(AllEnums.召唤材料Type.醒狮丹, new List<召唤精怪列表类>
					{
						new 召唤精怪列表类
						{
							召唤材料 = AllEnums.召唤材料Type.醒狮丹,
							礼包名字 = Convert.ToString(cells[0].Value),
							获得几率 = Convert.ToInt32(cells[1].Value),
							镇压宠物 = Convert.ToString(cells[2].Value),
							最低银元宝 = Convert.ToInt32(cells[3].Value),
							最高银元宝 = Convert.ToInt32(cells[4].Value),
							平均银元宝 = Convert.ToInt32(cells[5].Value)
						}
					});
				}
			}
		}
		for (int num3 = 0; num3 < 鱼仙饵列表.Rows.Count; num3++)
		{
			cells = 鱼仙饵列表.Rows[num3].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value?.ToString()))
			{
				if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.鱼仙饵, out List<召唤精怪列表类> value9))
				{
					value9.Add(new 召唤精怪列表类
					{
						召唤材料 = AllEnums.召唤材料Type.鱼仙饵,
						礼包名字 = Convert.ToString(cells[0].Value),
						获得几率 = Convert.ToInt32(cells[1].Value),
						镇压宠物 = Convert.ToString(cells[2].Value),
						最低银元宝 = Convert.ToInt32(cells[3].Value),
						最高银元宝 = Convert.ToInt32(cells[4].Value),
						平均银元宝 = Convert.ToInt32(cells[5].Value)
					});
				}
				else
				{
					Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryAdd(AllEnums.召唤材料Type.鱼仙饵, new List<召唤精怪列表类>
					{
						new 召唤精怪列表类
						{
							召唤材料 = AllEnums.召唤材料Type.鱼仙饵,
							礼包名字 = Convert.ToString(cells[0].Value),
							获得几率 = Convert.ToInt32(cells[1].Value),
							镇压宠物 = Convert.ToString(cells[2].Value),
							最低银元宝 = Convert.ToInt32(cells[3].Value),
							最高银元宝 = Convert.ToInt32(cells[4].Value),
							平均银元宝 = Convert.ToInt32(cells[5].Value)
						}
					});
				}
			}
		}
		for (int num4 = 0; num4 < 猿兽丹列表.Rows.Count; num4++)
		{
			cells = 猿兽丹列表.Rows[num4].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value?.ToString()))
			{
				if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.猿兽丹, out List<召唤精怪列表类> value10))
				{
					value10.Add(new 召唤精怪列表类
					{
						召唤材料 = AllEnums.召唤材料Type.猿兽丹,
						礼包名字 = Convert.ToString(cells[0].Value),
						获得几率 = Convert.ToInt32(cells[1].Value),
						镇压宠物 = Convert.ToString(cells[2].Value),
						最低银元宝 = Convert.ToInt32(cells[3].Value),
						最高银元宝 = Convert.ToInt32(cells[4].Value),
						平均银元宝 = Convert.ToInt32(cells[5].Value)
					});
				}
				else
				{
					Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryAdd(AllEnums.召唤材料Type.猿兽丹, new List<召唤精怪列表类>
					{
						new 召唤精怪列表类
						{
							召唤材料 = AllEnums.召唤材料Type.猿兽丹,
							礼包名字 = Convert.ToString(cells[0].Value),
							获得几率 = Convert.ToInt32(cells[1].Value),
							镇压宠物 = Convert.ToString(cells[2].Value),
							最低银元宝 = Convert.ToInt32(cells[3].Value),
							最高银元宝 = Convert.ToInt32(cells[4].Value),
							平均银元宝 = Convert.ToInt32(cells[5].Value)
						}
					});
				}
			}
		}
		for (int num5 = 0; num5 < 菩提子列表.Rows.Count; num5++)
		{
			cells = 菩提子列表.Rows[num5].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value?.ToString()))
			{
				if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.菩提子, out List<召唤精怪列表类> value11))
				{
					value11.Add(new 召唤精怪列表类
					{
						召唤材料 = AllEnums.召唤材料Type.菩提子,
						礼包名字 = Convert.ToString(cells[0].Value),
						获得几率 = Convert.ToInt32(cells[1].Value),
						镇压宠物 = Convert.ToString(cells[2].Value),
						最低银元宝 = Convert.ToInt32(cells[3].Value),
						最高银元宝 = Convert.ToInt32(cells[4].Value),
						平均银元宝 = Convert.ToInt32(cells[5].Value)
					});
				}
				else
				{
					Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryAdd(AllEnums.召唤材料Type.菩提子, new List<召唤精怪列表类>
					{
						new 召唤精怪列表类
						{
							召唤材料 = AllEnums.召唤材料Type.菩提子,
							礼包名字 = Convert.ToString(cells[0].Value),
							获得几率 = Convert.ToInt32(cells[1].Value),
							镇压宠物 = Convert.ToString(cells[2].Value),
							最低银元宝 = Convert.ToInt32(cells[3].Value),
							最高银元宝 = Convert.ToInt32(cells[4].Value),
							平均银元宝 = Convert.ToInt32(cells[5].Value)
						}
					});
				}
			}
		}
		for (int num6 = 0; num6 < 御仙饮列表.Rows.Count; num6++)
		{
			cells = 御仙饮列表.Rows[num6].Cells;
			if (cells[0].Value != null && !string.IsNullOrWhiteSpace(cells[0].Value?.ToString()))
			{
				if (Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryGetValue(AllEnums.召唤材料Type.御仙饮, out List<召唤精怪列表类> value12))
				{
					value12.Add(new 召唤精怪列表类
					{
						召唤材料 = AllEnums.召唤材料Type.御仙饮,
						礼包名字 = Convert.ToString(cells[0].Value),
						获得几率 = Convert.ToInt32(cells[1].Value),
						镇压宠物 = Convert.ToString(cells[2].Value),
						最低银元宝 = Convert.ToInt32(cells[3].Value),
						最高银元宝 = Convert.ToInt32(cells[4].Value),
						平均银元宝 = Convert.ToInt32(cells[5].Value)
					});
				}
				else
				{
					Singleton<全局变量类>.I.召唤精怪配置.召唤列表.TryAdd(AllEnums.召唤材料Type.御仙饮, new List<召唤精怪列表类>
					{
						new 召唤精怪列表类
						{
							召唤材料 = AllEnums.召唤材料Type.御仙饮,
							礼包名字 = Convert.ToString(cells[0].Value),
							获得几率 = Convert.ToInt32(cells[1].Value),
							镇压宠物 = Convert.ToString(cells[2].Value),
							最低银元宝 = Convert.ToInt32(cells[3].Value),
							最高银元宝 = Convert.ToInt32(cells[4].Value),
							平均银元宝 = Convert.ToInt32(cells[5].Value)
						}
					});
				}
			}
		}
	}

	private void 抓精怪_保存按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			配置变量赋值();
			Singleton<全局变量类>.I.验证client.SendRT(10018, 44, JsonConvert.SerializeObject(Singleton<全局变量类>.I.召唤精怪配置, Formatting.Indented));
		}
	}

	private void 抓精怪_重载按钮_Click(object sender, EventArgs e)
	{
		if (base.IsHandleCreated)
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 44);
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetClientFrom.召唤精怪配置窗口));
		this.抓精怪_开关 = new System.Windows.Forms.CheckBox();
		this.抓精怪_重载按钮 = new System.Windows.Forms.Button();
		this.抓精怪_保存按钮 = new System.Windows.Forms.Button();
		this.珊瑚列表 = new System.Windows.Forms.DataGridView();
		this.礼包名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.获得几率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.最低元宝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.最高元宝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.材料总集 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.还阳露列表 = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tabPage3 = new System.Windows.Forms.TabPage();
		this.醉仙酒列表 = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tabPage4 = new System.Windows.Forms.TabPage();
		this.五彩香列表 = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tabPage5 = new System.Windows.Forms.TabPage();
		this.仙露草列表 = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tabPage6 = new System.Windows.Forms.TabPage();
		this.百草集列表 = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tabPage7 = new System.Windows.Forms.TabPage();
		this.凝香草列表 = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tabPage8 = new System.Windows.Forms.TabPage();
		this.醒狮丹列表 = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tabPage9 = new System.Windows.Forms.TabPage();
		this.鱼仙饵列表 = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tabPage10 = new System.Windows.Forms.TabPage();
		this.猿兽丹列表 = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tabPage11 = new System.Windows.Forms.TabPage();
		this.菩提子列表 = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tabPage12 = new System.Windows.Forms.TabPage();
		this.御仙饮列表 = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		((System.ComponentModel.ISupportInitialize)this.珊瑚列表).BeginInit();
		this.材料总集.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.tabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.还阳露列表).BeginInit();
		this.tabPage3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.醉仙酒列表).BeginInit();
		this.tabPage4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.五彩香列表).BeginInit();
		this.tabPage5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.仙露草列表).BeginInit();
		this.tabPage6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.百草集列表).BeginInit();
		this.tabPage7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.凝香草列表).BeginInit();
		this.tabPage8.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.醒狮丹列表).BeginInit();
		this.tabPage9.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.鱼仙饵列表).BeginInit();
		this.tabPage10.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.猿兽丹列表).BeginInit();
		this.tabPage11.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.菩提子列表).BeginInit();
		this.tabPage12.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.御仙饮列表).BeginInit();
		base.SuspendLayout();
		this.抓精怪_开关.AutoSize = true;
		this.抓精怪_开关.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.抓精怪_开关.Location = new System.Drawing.Point(12, 12);
		this.抓精怪_开关.Name = "抓精怪_开关";
		this.抓精怪_开关.Size = new System.Drawing.Size(132, 23);
		this.抓精怪_开关.TabIndex = 126;
		this.抓精怪_开关.Text = "召唤精怪功能开关";
		this.抓精怪_开关.UseVisualStyleBackColor = true;
		this.抓精怪_重载按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.抓精怪_重载按钮.Location = new System.Drawing.Point(256, 8);
		this.抓精怪_重载按钮.Name = "抓精怪_重载按钮";
		this.抓精怪_重载按钮.Size = new System.Drawing.Size(100, 30);
		this.抓精怪_重载按钮.TabIndex = 128;
		this.抓精怪_重载按钮.Text = "重载配置";
		this.抓精怪_重载按钮.UseVisualStyleBackColor = true;
		this.抓精怪_重载按钮.Click += new System.EventHandler(抓精怪_重载按钮_Click);
		this.抓精怪_保存按钮.Font = new System.Drawing.Font("Microsoft YaHei UI", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		this.抓精怪_保存按钮.Location = new System.Drawing.Point(150, 8);
		this.抓精怪_保存按钮.Name = "抓精怪_保存按钮";
		this.抓精怪_保存按钮.Size = new System.Drawing.Size(100, 30);
		this.抓精怪_保存按钮.TabIndex = 127;
		this.抓精怪_保存按钮.Text = "保存配置";
		this.抓精怪_保存按钮.UseVisualStyleBackColor = true;
		this.抓精怪_保存按钮.Click += new System.EventHandler(抓精怪_保存按钮_Click);
		this.珊瑚列表.AllowUserToDeleteRows = false;
		this.珊瑚列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.珊瑚列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.珊瑚列表.BackgroundColor = System.Drawing.Color.White;
		this.珊瑚列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.珊瑚列表.Columns.AddRange(this.礼包名字, this.获得几率, this.最低元宝, this.最高元宝);
		this.珊瑚列表.Location = new System.Drawing.Point(3, 4);
		this.珊瑚列表.MultiSelect = false;
		this.珊瑚列表.Name = "珊瑚列表";
		this.珊瑚列表.RowHeadersVisible = false;
		this.珊瑚列表.RowTemplate.Height = 25;
		this.珊瑚列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.珊瑚列表.Size = new System.Drawing.Size(444, 360);
		this.珊瑚列表.TabIndex = 175;
		this.礼包名字.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.礼包名字.HeaderText = "礼包名字";
		this.礼包名字.MinimumWidth = 150;
		this.礼包名字.Name = "礼包名字";
		this.礼包名字.Width = 150;
		this.获得几率.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.获得几率.HeaderText = "获得几率";
		this.获得几率.MinimumWidth = 90;
		this.获得几率.Name = "获得几率";
		this.获得几率.ToolTipText = "几率数值区间为0-10000";
		this.获得几率.Width = 90;
		this.最低元宝.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.最低元宝.HeaderText = "最低元宝";
		this.最低元宝.MinimumWidth = 90;
		this.最低元宝.Name = "最低元宝";
		this.最低元宝.Width = 90;
		this.最高元宝.HeaderText = "最高元宝";
		this.最高元宝.MinimumWidth = 100;
		this.最高元宝.Name = "最高元宝";
		this.材料总集.Controls.Add(this.tabPage1);
		this.材料总集.Controls.Add(this.tabPage2);
		this.材料总集.Controls.Add(this.tabPage3);
		this.材料总集.Controls.Add(this.tabPage4);
		this.材料总集.Controls.Add(this.tabPage5);
		this.材料总集.Controls.Add(this.tabPage6);
		this.材料总集.Controls.Add(this.tabPage7);
		this.材料总集.Controls.Add(this.tabPage8);
		this.材料总集.Controls.Add(this.tabPage9);
		this.材料总集.Controls.Add(this.tabPage10);
		this.材料总集.Controls.Add(this.tabPage11);
		this.材料总集.Controls.Add(this.tabPage12);
		this.材料总集.Location = new System.Drawing.Point(12, 44);
		this.材料总集.Name = "材料总集";
		this.材料总集.SelectedIndex = 0;
		this.材料总集.Size = new System.Drawing.Size(458, 399);
		this.材料总集.TabIndex = 176;
		this.tabPage1.Controls.Add(this.珊瑚列表);
		this.tabPage1.Location = new System.Drawing.Point(4, 26);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(450, 369);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "珊瑚";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.tabPage2.Controls.Add(this.还阳露列表);
		this.tabPage2.Location = new System.Drawing.Point(4, 26);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(450, 369);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "还阳露";
		this.tabPage2.UseVisualStyleBackColor = true;
		this.还阳露列表.AllowUserToDeleteRows = false;
		this.还阳露列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.还阳露列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
		this.还阳露列表.BackgroundColor = System.Drawing.Color.White;
		this.还阳露列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.还阳露列表.Columns.AddRange(this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2, this.dataGridViewTextBoxColumn3, this.dataGridViewTextBoxColumn4);
		this.还阳露列表.Location = new System.Drawing.Point(3, 4);
		this.还阳露列表.MultiSelect = false;
		this.还阳露列表.Name = "还阳露列表";
		this.还阳露列表.RowHeadersVisible = false;
		this.还阳露列表.RowTemplate.Height = 25;
		this.还阳露列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.还阳露列表.Size = new System.Drawing.Size(444, 360);
		this.还阳露列表.TabIndex = 176;
		this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn1.HeaderText = "礼包名字";
		this.dataGridViewTextBoxColumn1.MinimumWidth = 150;
		this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn1.Width = 150;
		this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn2.HeaderText = "获得几率";
		this.dataGridViewTextBoxColumn2.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
		this.dataGridViewTextBoxColumn2.ToolTipText = "几率数值区间为0-10000";
		this.dataGridViewTextBoxColumn2.Width = 90;
		this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn3.HeaderText = "最低元宝";
		this.dataGridViewTextBoxColumn3.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
		this.dataGridViewTextBoxColumn3.Width = 90;
		this.dataGridViewTextBoxColumn4.HeaderText = "最高元宝";
		this.dataGridViewTextBoxColumn4.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
		this.tabPage3.Controls.Add(this.醉仙酒列表);
		this.tabPage3.Location = new System.Drawing.Point(4, 26);
		this.tabPage3.Name = "tabPage3";
		this.tabPage3.Size = new System.Drawing.Size(450, 369);
		this.tabPage3.TabIndex = 2;
		this.tabPage3.Text = "醉仙酒";
		this.tabPage3.UseVisualStyleBackColor = true;
		this.醉仙酒列表.AllowUserToDeleteRows = false;
		this.醉仙酒列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.醉仙酒列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
		this.醉仙酒列表.BackgroundColor = System.Drawing.Color.White;
		this.醉仙酒列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.醉仙酒列表.Columns.AddRange(this.dataGridViewTextBoxColumn5, this.dataGridViewTextBoxColumn6, this.dataGridViewTextBoxColumn7, this.dataGridViewTextBoxColumn8);
		this.醉仙酒列表.Location = new System.Drawing.Point(3, 4);
		this.醉仙酒列表.MultiSelect = false;
		this.醉仙酒列表.Name = "醉仙酒列表";
		this.醉仙酒列表.RowHeadersVisible = false;
		this.醉仙酒列表.RowTemplate.Height = 25;
		this.醉仙酒列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.醉仙酒列表.Size = new System.Drawing.Size(444, 360);
		this.醉仙酒列表.TabIndex = 176;
		this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn5.HeaderText = "礼包名字";
		this.dataGridViewTextBoxColumn5.MinimumWidth = 150;
		this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
		this.dataGridViewTextBoxColumn5.Width = 150;
		this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn6.HeaderText = "获得几率";
		this.dataGridViewTextBoxColumn6.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
		this.dataGridViewTextBoxColumn6.ToolTipText = "几率数值区间为0-10000";
		this.dataGridViewTextBoxColumn6.Width = 90;
		this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn7.HeaderText = "最低元宝";
		this.dataGridViewTextBoxColumn7.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
		this.dataGridViewTextBoxColumn7.Width = 90;
		this.dataGridViewTextBoxColumn8.HeaderText = "最高元宝";
		this.dataGridViewTextBoxColumn8.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
		this.tabPage4.Controls.Add(this.五彩香列表);
		this.tabPage4.Location = new System.Drawing.Point(4, 26);
		this.tabPage4.Name = "tabPage4";
		this.tabPage4.Size = new System.Drawing.Size(450, 369);
		this.tabPage4.TabIndex = 3;
		this.tabPage4.Text = "五彩香";
		this.tabPage4.UseVisualStyleBackColor = true;
		this.五彩香列表.AllowUserToDeleteRows = false;
		this.五彩香列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.五彩香列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
		this.五彩香列表.BackgroundColor = System.Drawing.Color.White;
		this.五彩香列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.五彩香列表.Columns.AddRange(this.dataGridViewTextBoxColumn9, this.dataGridViewTextBoxColumn10, this.dataGridViewTextBoxColumn11, this.dataGridViewTextBoxColumn12);
		this.五彩香列表.Location = new System.Drawing.Point(3, 4);
		this.五彩香列表.MultiSelect = false;
		this.五彩香列表.Name = "五彩香列表";
		this.五彩香列表.RowHeadersVisible = false;
		this.五彩香列表.RowTemplate.Height = 25;
		this.五彩香列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.五彩香列表.Size = new System.Drawing.Size(444, 360);
		this.五彩香列表.TabIndex = 176;
		this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn9.HeaderText = "礼包名字";
		this.dataGridViewTextBoxColumn9.MinimumWidth = 150;
		this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
		this.dataGridViewTextBoxColumn9.Width = 150;
		this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn10.HeaderText = "获得几率";
		this.dataGridViewTextBoxColumn10.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
		this.dataGridViewTextBoxColumn10.ToolTipText = "几率数值区间为0-10000";
		this.dataGridViewTextBoxColumn10.Width = 90;
		this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn11.HeaderText = "最低元宝";
		this.dataGridViewTextBoxColumn11.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
		this.dataGridViewTextBoxColumn11.Width = 90;
		this.dataGridViewTextBoxColumn12.HeaderText = "最高元宝";
		this.dataGridViewTextBoxColumn12.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
		this.tabPage5.Controls.Add(this.仙露草列表);
		this.tabPage5.Location = new System.Drawing.Point(4, 26);
		this.tabPage5.Name = "tabPage5";
		this.tabPage5.Size = new System.Drawing.Size(450, 369);
		this.tabPage5.TabIndex = 4;
		this.tabPage5.Text = "仙露草";
		this.tabPage5.UseVisualStyleBackColor = true;
		this.仙露草列表.AllowUserToDeleteRows = false;
		this.仙露草列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.仙露草列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
		this.仙露草列表.BackgroundColor = System.Drawing.Color.White;
		this.仙露草列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.仙露草列表.Columns.AddRange(this.dataGridViewTextBoxColumn13, this.dataGridViewTextBoxColumn14, this.dataGridViewTextBoxColumn15, this.dataGridViewTextBoxColumn16);
		this.仙露草列表.Location = new System.Drawing.Point(3, 4);
		this.仙露草列表.MultiSelect = false;
		this.仙露草列表.Name = "仙露草列表";
		this.仙露草列表.RowHeadersVisible = false;
		this.仙露草列表.RowTemplate.Height = 25;
		this.仙露草列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.仙露草列表.Size = new System.Drawing.Size(444, 360);
		this.仙露草列表.TabIndex = 176;
		this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn13.HeaderText = "礼包名字";
		this.dataGridViewTextBoxColumn13.MinimumWidth = 150;
		this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
		this.dataGridViewTextBoxColumn13.Width = 150;
		this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn14.HeaderText = "获得几率";
		this.dataGridViewTextBoxColumn14.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
		this.dataGridViewTextBoxColumn14.ToolTipText = "几率数值区间为0-10000";
		this.dataGridViewTextBoxColumn14.Width = 90;
		this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn15.HeaderText = "最低元宝";
		this.dataGridViewTextBoxColumn15.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
		this.dataGridViewTextBoxColumn15.Width = 90;
		this.dataGridViewTextBoxColumn16.HeaderText = "最高元宝";
		this.dataGridViewTextBoxColumn16.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
		this.tabPage6.Controls.Add(this.百草集列表);
		this.tabPage6.Location = new System.Drawing.Point(4, 26);
		this.tabPage6.Name = "tabPage6";
		this.tabPage6.Size = new System.Drawing.Size(450, 369);
		this.tabPage6.TabIndex = 5;
		this.tabPage6.Text = "百草集";
		this.tabPage6.UseVisualStyleBackColor = true;
		this.百草集列表.AllowUserToDeleteRows = false;
		this.百草集列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.百草集列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
		this.百草集列表.BackgroundColor = System.Drawing.Color.White;
		this.百草集列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.百草集列表.Columns.AddRange(this.dataGridViewTextBoxColumn17, this.dataGridViewTextBoxColumn18, this.dataGridViewTextBoxColumn19, this.dataGridViewTextBoxColumn20);
		this.百草集列表.Location = new System.Drawing.Point(3, 4);
		this.百草集列表.MultiSelect = false;
		this.百草集列表.Name = "百草集列表";
		this.百草集列表.RowHeadersVisible = false;
		this.百草集列表.RowTemplate.Height = 25;
		this.百草集列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.百草集列表.Size = new System.Drawing.Size(444, 360);
		this.百草集列表.TabIndex = 176;
		this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn17.HeaderText = "礼包名字";
		this.dataGridViewTextBoxColumn17.MinimumWidth = 150;
		this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
		this.dataGridViewTextBoxColumn17.Width = 150;
		this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn18.HeaderText = "获得几率";
		this.dataGridViewTextBoxColumn18.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
		this.dataGridViewTextBoxColumn18.ToolTipText = "几率数值区间为0-10000";
		this.dataGridViewTextBoxColumn18.Width = 90;
		this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn19.HeaderText = "最低元宝";
		this.dataGridViewTextBoxColumn19.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
		this.dataGridViewTextBoxColumn19.Width = 90;
		this.dataGridViewTextBoxColumn20.HeaderText = "最高元宝";
		this.dataGridViewTextBoxColumn20.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
		this.tabPage7.Controls.Add(this.凝香草列表);
		this.tabPage7.Location = new System.Drawing.Point(4, 26);
		this.tabPage7.Name = "tabPage7";
		this.tabPage7.Size = new System.Drawing.Size(450, 369);
		this.tabPage7.TabIndex = 6;
		this.tabPage7.Text = "凝香草";
		this.tabPage7.UseVisualStyleBackColor = true;
		this.凝香草列表.AllowUserToDeleteRows = false;
		this.凝香草列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.凝香草列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
		this.凝香草列表.BackgroundColor = System.Drawing.Color.White;
		this.凝香草列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.凝香草列表.Columns.AddRange(this.dataGridViewTextBoxColumn21, this.dataGridViewTextBoxColumn22, this.dataGridViewTextBoxColumn23, this.dataGridViewTextBoxColumn24);
		this.凝香草列表.Location = new System.Drawing.Point(3, 4);
		this.凝香草列表.MultiSelect = false;
		this.凝香草列表.Name = "凝香草列表";
		this.凝香草列表.RowHeadersVisible = false;
		this.凝香草列表.RowTemplate.Height = 25;
		this.凝香草列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.凝香草列表.Size = new System.Drawing.Size(444, 360);
		this.凝香草列表.TabIndex = 176;
		this.dataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn21.HeaderText = "礼包名字";
		this.dataGridViewTextBoxColumn21.MinimumWidth = 150;
		this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
		this.dataGridViewTextBoxColumn21.Width = 150;
		this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn22.HeaderText = "获得几率";
		this.dataGridViewTextBoxColumn22.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
		this.dataGridViewTextBoxColumn22.ToolTipText = "几率数值区间为0-10000";
		this.dataGridViewTextBoxColumn22.Width = 90;
		this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn23.HeaderText = "最低元宝";
		this.dataGridViewTextBoxColumn23.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
		this.dataGridViewTextBoxColumn23.Width = 90;
		this.dataGridViewTextBoxColumn24.HeaderText = "最高元宝";
		this.dataGridViewTextBoxColumn24.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
		this.tabPage8.Controls.Add(this.醒狮丹列表);
		this.tabPage8.Location = new System.Drawing.Point(4, 26);
		this.tabPage8.Name = "tabPage8";
		this.tabPage8.Size = new System.Drawing.Size(450, 369);
		this.tabPage8.TabIndex = 7;
		this.tabPage8.Text = "醒狮丹";
		this.tabPage8.UseVisualStyleBackColor = true;
		this.醒狮丹列表.AllowUserToDeleteRows = false;
		this.醒狮丹列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.醒狮丹列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
		this.醒狮丹列表.BackgroundColor = System.Drawing.Color.White;
		this.醒狮丹列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.醒狮丹列表.Columns.AddRange(this.dataGridViewTextBoxColumn25, this.dataGridViewTextBoxColumn26, this.dataGridViewTextBoxColumn27, this.dataGridViewTextBoxColumn28);
		this.醒狮丹列表.Location = new System.Drawing.Point(3, 4);
		this.醒狮丹列表.MultiSelect = false;
		this.醒狮丹列表.Name = "醒狮丹列表";
		this.醒狮丹列表.RowHeadersVisible = false;
		this.醒狮丹列表.RowTemplate.Height = 25;
		this.醒狮丹列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.醒狮丹列表.Size = new System.Drawing.Size(444, 360);
		this.醒狮丹列表.TabIndex = 176;
		this.dataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn25.HeaderText = "礼包名字";
		this.dataGridViewTextBoxColumn25.MinimumWidth = 150;
		this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
		this.dataGridViewTextBoxColumn25.Width = 150;
		this.dataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn26.HeaderText = "获得几率";
		this.dataGridViewTextBoxColumn26.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
		this.dataGridViewTextBoxColumn26.ToolTipText = "几率数值区间为0-10000";
		this.dataGridViewTextBoxColumn26.Width = 90;
		this.dataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn27.HeaderText = "最低元宝";
		this.dataGridViewTextBoxColumn27.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
		this.dataGridViewTextBoxColumn27.Width = 90;
		this.dataGridViewTextBoxColumn28.HeaderText = "最高元宝";
		this.dataGridViewTextBoxColumn28.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
		this.tabPage9.Controls.Add(this.鱼仙饵列表);
		this.tabPage9.Location = new System.Drawing.Point(4, 26);
		this.tabPage9.Name = "tabPage9";
		this.tabPage9.Size = new System.Drawing.Size(450, 369);
		this.tabPage9.TabIndex = 8;
		this.tabPage9.Text = "鱼仙饵";
		this.tabPage9.UseVisualStyleBackColor = true;
		this.鱼仙饵列表.AllowUserToDeleteRows = false;
		this.鱼仙饵列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.鱼仙饵列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
		this.鱼仙饵列表.BackgroundColor = System.Drawing.Color.White;
		this.鱼仙饵列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.鱼仙饵列表.Columns.AddRange(this.dataGridViewTextBoxColumn29, this.dataGridViewTextBoxColumn30, this.dataGridViewTextBoxColumn31, this.dataGridViewTextBoxColumn32);
		this.鱼仙饵列表.Location = new System.Drawing.Point(3, 4);
		this.鱼仙饵列表.MultiSelect = false;
		this.鱼仙饵列表.Name = "鱼仙饵列表";
		this.鱼仙饵列表.RowHeadersVisible = false;
		this.鱼仙饵列表.RowTemplate.Height = 25;
		this.鱼仙饵列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.鱼仙饵列表.Size = new System.Drawing.Size(444, 360);
		this.鱼仙饵列表.TabIndex = 176;
		this.dataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn29.HeaderText = "礼包名字";
		this.dataGridViewTextBoxColumn29.MinimumWidth = 150;
		this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
		this.dataGridViewTextBoxColumn29.Width = 150;
		this.dataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn30.HeaderText = "获得几率";
		this.dataGridViewTextBoxColumn30.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
		this.dataGridViewTextBoxColumn30.ToolTipText = "几率数值区间为0-10000";
		this.dataGridViewTextBoxColumn30.Width = 90;
		this.dataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn31.HeaderText = "最低元宝";
		this.dataGridViewTextBoxColumn31.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
		this.dataGridViewTextBoxColumn31.Width = 90;
		this.dataGridViewTextBoxColumn32.HeaderText = "最高元宝";
		this.dataGridViewTextBoxColumn32.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
		this.tabPage10.Controls.Add(this.猿兽丹列表);
		this.tabPage10.Location = new System.Drawing.Point(4, 26);
		this.tabPage10.Name = "tabPage10";
		this.tabPage10.Size = new System.Drawing.Size(450, 369);
		this.tabPage10.TabIndex = 9;
		this.tabPage10.Text = "猿兽丹";
		this.tabPage10.UseVisualStyleBackColor = true;
		this.猿兽丹列表.AllowUserToDeleteRows = false;
		this.猿兽丹列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.猿兽丹列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
		this.猿兽丹列表.BackgroundColor = System.Drawing.Color.White;
		this.猿兽丹列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.猿兽丹列表.Columns.AddRange(this.dataGridViewTextBoxColumn33, this.dataGridViewTextBoxColumn34, this.dataGridViewTextBoxColumn35, this.dataGridViewTextBoxColumn36);
		this.猿兽丹列表.Location = new System.Drawing.Point(3, 4);
		this.猿兽丹列表.MultiSelect = false;
		this.猿兽丹列表.Name = "猿兽丹列表";
		this.猿兽丹列表.RowHeadersVisible = false;
		this.猿兽丹列表.RowTemplate.Height = 25;
		this.猿兽丹列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.猿兽丹列表.Size = new System.Drawing.Size(444, 360);
		this.猿兽丹列表.TabIndex = 176;
		this.dataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn33.HeaderText = "礼包名字";
		this.dataGridViewTextBoxColumn33.MinimumWidth = 150;
		this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
		this.dataGridViewTextBoxColumn33.Width = 150;
		this.dataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn34.HeaderText = "获得几率";
		this.dataGridViewTextBoxColumn34.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
		this.dataGridViewTextBoxColumn34.ToolTipText = "几率数值区间为0-10000";
		this.dataGridViewTextBoxColumn34.Width = 90;
		this.dataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn35.HeaderText = "最低元宝";
		this.dataGridViewTextBoxColumn35.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
		this.dataGridViewTextBoxColumn35.Width = 90;
		this.dataGridViewTextBoxColumn36.HeaderText = "最高元宝";
		this.dataGridViewTextBoxColumn36.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
		this.tabPage11.Controls.Add(this.菩提子列表);
		this.tabPage11.Location = new System.Drawing.Point(4, 26);
		this.tabPage11.Name = "tabPage11";
		this.tabPage11.Size = new System.Drawing.Size(450, 369);
		this.tabPage11.TabIndex = 10;
		this.tabPage11.Text = "菩提子";
		this.tabPage11.UseVisualStyleBackColor = true;
		this.菩提子列表.AllowUserToDeleteRows = false;
		this.菩提子列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.菩提子列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
		this.菩提子列表.BackgroundColor = System.Drawing.Color.White;
		this.菩提子列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.菩提子列表.Columns.AddRange(this.dataGridViewTextBoxColumn37, this.dataGridViewTextBoxColumn38, this.dataGridViewTextBoxColumn39, this.dataGridViewTextBoxColumn40);
		this.菩提子列表.Location = new System.Drawing.Point(3, 4);
		this.菩提子列表.MultiSelect = false;
		this.菩提子列表.Name = "菩提子列表";
		this.菩提子列表.RowHeadersVisible = false;
		this.菩提子列表.RowTemplate.Height = 25;
		this.菩提子列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.菩提子列表.Size = new System.Drawing.Size(444, 360);
		this.菩提子列表.TabIndex = 176;
		this.dataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn37.HeaderText = "礼包名字";
		this.dataGridViewTextBoxColumn37.MinimumWidth = 150;
		this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
		this.dataGridViewTextBoxColumn37.Width = 150;
		this.dataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn38.HeaderText = "获得几率";
		this.dataGridViewTextBoxColumn38.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
		this.dataGridViewTextBoxColumn38.ToolTipText = "几率数值区间为0-10000";
		this.dataGridViewTextBoxColumn38.Width = 90;
		this.dataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn39.HeaderText = "最低元宝";
		this.dataGridViewTextBoxColumn39.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
		this.dataGridViewTextBoxColumn39.Width = 90;
		this.dataGridViewTextBoxColumn40.HeaderText = "最高元宝";
		this.dataGridViewTextBoxColumn40.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
		this.tabPage12.Controls.Add(this.御仙饮列表);
		this.tabPage12.Location = new System.Drawing.Point(4, 26);
		this.tabPage12.Name = "tabPage12";
		this.tabPage12.Size = new System.Drawing.Size(450, 369);
		this.tabPage12.TabIndex = 11;
		this.tabPage12.Text = "御仙饮";
		this.tabPage12.UseVisualStyleBackColor = true;
		this.御仙饮列表.AllowUserToDeleteRows = false;
		this.御仙饮列表.AllowUserToResizeRows = false;
		dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.御仙饮列表.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
		this.御仙饮列表.BackgroundColor = System.Drawing.Color.White;
		this.御仙饮列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.御仙饮列表.Columns.AddRange(this.dataGridViewTextBoxColumn41, this.dataGridViewTextBoxColumn42, this.dataGridViewTextBoxColumn43, this.dataGridViewTextBoxColumn44);
		this.御仙饮列表.Location = new System.Drawing.Point(3, 4);
		this.御仙饮列表.MultiSelect = false;
		this.御仙饮列表.Name = "御仙饮列表";
		this.御仙饮列表.RowHeadersVisible = false;
		this.御仙饮列表.RowTemplate.Height = 25;
		this.御仙饮列表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.御仙饮列表.Size = new System.Drawing.Size(444, 360);
		this.御仙饮列表.TabIndex = 176;
		this.dataGridViewTextBoxColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn41.HeaderText = "礼包名字";
		this.dataGridViewTextBoxColumn41.MinimumWidth = 150;
		this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
		this.dataGridViewTextBoxColumn41.Width = 150;
		this.dataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn42.HeaderText = "获得几率";
		this.dataGridViewTextBoxColumn42.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
		this.dataGridViewTextBoxColumn42.ToolTipText = "几率数值区间为0-10000";
		this.dataGridViewTextBoxColumn42.Width = 90;
		this.dataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn43.HeaderText = "最低元宝";
		this.dataGridViewTextBoxColumn43.MinimumWidth = 90;
		this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
		this.dataGridViewTextBoxColumn43.Width = 90;
		this.dataGridViewTextBoxColumn44.HeaderText = "最高元宝";
		this.dataGridViewTextBoxColumn44.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		base.ClientSize = new System.Drawing.Size(482, 450);
		base.Controls.Add(this.材料总集);
		base.Controls.Add(this.抓精怪_开关);
		base.Controls.Add(this.抓精怪_重载按钮);
		base.Controls.Add(this.抓精怪_保存按钮);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "召唤精怪配置窗口";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "召唤精怪配置窗口";
		base.Load += new System.EventHandler(召唤精怪配置窗口_Load);
		((System.ComponentModel.ISupportInitialize)this.珊瑚列表).EndInit();
		this.材料总集.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.还阳露列表).EndInit();
		this.tabPage3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.醉仙酒列表).EndInit();
		this.tabPage4.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.五彩香列表).EndInit();
		this.tabPage5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.仙露草列表).EndInit();
		this.tabPage6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.百草集列表).EndInit();
		this.tabPage7.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.凝香草列表).EndInit();
		this.tabPage8.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.醒狮丹列表).EndInit();
		this.tabPage9.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.鱼仙饵列表).EndInit();
		this.tabPage10.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.猿兽丹列表).EndInit();
		this.tabPage11.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.菩提子列表).EndInit();
		this.tabPage12.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.御仙饮列表).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
