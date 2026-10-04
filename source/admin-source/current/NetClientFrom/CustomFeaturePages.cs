using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public partial class 后台主页界面
{
	private bool customFeaturePagesInitialized;

	private TabPage peakDuelPage;

	private TabPage luckPage;

	private TabPage nostalgiaPage;

	private Label daoYouInfo;

	private CheckBox daoYouEnabled;

	private Label peakRules;

	private CheckBox luckEnabled;

	private ComboBox luckRandomMode;

	private NumericUpDown luckDrawCost;

	private CheckBox luckBlindBoxEnabled;

	private ComboBox luckBlindBoxMode;

	private NumericUpDown luckPurchaseMode;

	private DataGridView luckItemsGrid;

	private readonly Dictionary<FieldInfo, CheckBox> nostalgiaSwitches = new();

	private void InitializeCustomFeaturePages()
	{
		if (customFeaturePagesInitialized)
		{
			return;
		}
		customFeaturePagesInitialized = true;
		InitializeDaoYouPage();

		// BASE_SWITCH_MOVED_FROM_GROUP
		groupBox2.Controls.Remove(Is巅峰对决);
		peakDuelPage = CreateCustomPage("巅峰对决", "peakDuelPage");
		var peakPanel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(12) };
		Is巅峰对决.Location = new Point(12, 12);
		Is巅峰对决.Visible = true;
		peakPanel.Controls.Add(Is巅峰对决);
		var peakSave = CreateButton("保存配置", 12, 52, delegate
		{
			Singleton<全局变量类>.I.首页配置.Is巅峰对决 = Is巅峰对决.Checked;
			Singleton<全局变量类>.I.验证client.SendRT(10018, 1, JsonConvert.SerializeObject(Singleton<全局变量类>.I.首页配置, Formatting.Indented));
		});
		var peakReload = CreateButton("重载配置", 121, 52, delegate
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 1);
		});
		peakPanel.Controls.Add(peakSave);
		peakPanel.Controls.Add(peakReload);
		var peakConfig = CreateButton("试道大会配置", 230, 52, delegate
		{
			试道大会配置窗口.I.Show();
		});
		peakPanel.Controls.Add(peakConfig);
		peakRules = new Label
		{
			AutoSize = false,
			BorderStyle = BorderStyle.FixedSingle,
			Location = new Point(12, 96),
			Padding = new Padding(8),
			Size = new Size(760, 82),
			Text = "巅峰套装规则（插件内置）：巅峰一境 170，二境 180，三境 190，四境 200，五境 210，六境 220，七境 230，八境 240，九境 250，极境 255。奖励和队伍人数使用“试道大会配置”。",
			TextAlign = ContentAlignment.MiddleLeft
		};
		peakPanel.Controls.Add(peakRules);
		peakDuelPage.Controls.Add(peakPanel);
		tabControl4.Controls.Add(peakDuelPage);

		luckPage = CreateCustomPage("鸿运当头", "luckPage");
		BuildLuckPage();
		tabControl4.Controls.Add(luckPage);

		nostalgiaPage = CreateCustomPage("怀旧专区", "nostalgiaPage");
		BuildNostalgiaPage();
		tabControl4.Controls.Add(nostalgiaPage);

		// CUSTOM_MERGE_TAB_EXPOSED
		完美合区.Text = "专属合区";
		groupBox24.Visible = true;
		合区_日志.Visible = true;
	}

	private void InitializeDaoYouPage()
	{
		道友挖宝.Controls.Clear();
		var panel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(12) };
		daoYouEnabled = new CheckBox
		{
			AutoSize = true,
			Checked = Singleton<全局变量类>.I.首页配置.Is道友挖宝,
			Font = new Font("Microsoft YaHei UI", 9.5f, FontStyle.Bold, GraphicsUnit.Point),
			Location = new Point(12, 12),
			Text = "道友挖宝开关"
		};
		panel.Controls.Add(daoYouEnabled);
		var save = CreateButton("保存配置", 12, 48, delegate
		{
			Singleton<全局变量类>.I.首页配置.Is道友挖宝 = daoYouEnabled.Checked;
			Singleton<全局变量类>.I.验证client.SendRT(10018, 1, JsonConvert.SerializeObject(Singleton<全局变量类>.I.首页配置, Formatting.Indented));
		});
		var reload = CreateButton("重载配置", 121, 48, delegate
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 1);
		});
		panel.Controls.Add(save);
		panel.Controls.Add(reload);
		daoYouInfo = new Label
		{
			AutoSize = false,
			BorderStyle = BorderStyle.FixedSingle,
			Location = new Point(12, 92),
			Padding = new Padding(10),
			Size = new Size(760, 78),
			Text = "运行条件：卡密授权、道友挖宝开关和元神系统总开关均开启。地图、礼包和坐标属于元神系统配置。",
			TextAlign = ContentAlignment.MiddleLeft
		};
		panel.Controls.Add(daoYouInfo);
		var openYuanShen = CreateButton("打开元神配置", 12, 184, delegate
		{
			功能分组.SelectedTab = 元神功能;
		});
		panel.Controls.Add(openYuanShen);
		道友挖宝.Controls.Add(panel);
	}

	private void RefreshCustomHomepageSwitches()
	{
		if (daoYouEnabled != null)
		{
			daoYouEnabled.Checked = Singleton<全局变量类>.I.首页配置.Is道友挖宝;
		}
	}

	internal bool RunFeaturePageLayoutSelfTest()
	{
		var yuanShenControls = new Control[]
		{
			元神系统配置_初始赠送礼包,
			元神系统配置_渡劫地图,
			元神系统配置_地图坐标X,
			元神系统配置_地图坐标Y
		};
		bool yuanShenOwnership = yuanShenControls.All(control => control.Parent == 元神功能);
		bool treasureControls = daoYouEnabled != null && daoYouEnabled.Text == "道友挖宝开关" &&
			FindControlByText(道友挖宝, "保存配置") != null &&
			FindControlByText(道友挖宝, "重载配置") != null &&
			FindControlByText(道友挖宝, "打开元神配置") != null;
		bool peakControls = peakDuelPage != null && Is巅峰对决.Parent != groupBox2 &&
			FindControlByText(peakDuelPage, "保存配置") != null &&
			FindControlByText(peakDuelPage, "重载配置") != null &&
			FindControlByText(peakDuelPage, "试道大会配置") != null && peakRules != null;
		bool boundsValid = ControlsFitWithinPage(道友挖宝) && ControlsFitWithinPage(peakDuelPage);
		bool passed = yuanShenOwnership && treasureControls && peakControls && boundsValid;
		Console.WriteLine($"FEATURE_PAGE_LAYOUT_SELF_TEST={(passed ? "PASS" : "FAIL")} yuan_shen={yuanShenOwnership} treasure={treasureControls} peak={peakControls} bounds={boundsValid}");
		return passed;
	}

	private static Control FindControlByText(Control parent, string text)
	{
		foreach (Control child in parent.Controls)
		{
			if (child.Text == text)
			{
				return child;
			}
			Control nested = FindControlByText(child, text);
			if (nested != null)
			{
				return nested;
			}
		}
		return null;
	}

	private static bool ControlsFitWithinPage(Control page)
	{
		if (page == null)
		{
			return false;
		}
		foreach (Control child in page.Controls)
		{
			if (child.Left < 0 || child.Top < 0 || child.Right > page.ClientSize.Width || child.Bottom > page.ClientSize.Height)
			{
				return false;
			}
		}
		return true;
	}

	private static TabPage CreateCustomPage(string text, string name)
	{
		return new TabPage
		{
			BackColor = Color.White,
			Name = name,
			Padding = new Padding(3),
			Text = text,
			UseVisualStyleBackColor = true
		};
	}

	private static Button CreateButton(string text, int x, int y, EventHandler handler)
	{
		var button = new Button
		{
			Font = new Font("Microsoft YaHei UI", 9.5f, FontStyle.Bold, GraphicsUnit.Point),
			Location = new Point(x, y),
			Size = new Size(100, 30),
			Text = text,
			UseVisualStyleBackColor = true
		};
		button.Click += handler;
		return button;
	}

	private void BuildLuckPage()
	{
		var top = new FlowLayoutPanel
		{
			AutoSize = false,
			Dock = DockStyle.Top,
			FlowDirection = FlowDirection.LeftToRight,
			Height = 80,
			Padding = new Padding(8),
			WrapContents = true
		};
		luckEnabled = new CheckBox { AutoSize = true, Text = "功能开关", Margin = new Padding(3, 6, 15, 3) };
		luckRandomMode = CreateEnumCombo<AllEnums.数值Type>(150);
		luckDrawCost = CreateNumber(1000000, 0);
		luckBlindBoxEnabled = new CheckBox { AutoSize = true, Text = "盲盒选购模式", Margin = new Padding(15, 6, 3, 3) };
		luckBlindBoxMode = CreateEnumCombo<AllEnums.数值Type>(150);
		luckPurchaseMode = CreateNumber(1000000, 0);
		top.Controls.Add(luckEnabled);
		top.Controls.Add(CreateCaption("随机抽取模式"));
		top.Controls.Add(luckRandomMode);
		top.Controls.Add(CreateCaption("抽取消耗"));
		top.Controls.Add(luckDrawCost);
		top.Controls.Add(luckBlindBoxEnabled);
		top.Controls.Add(CreateCaption("盲盒模式"));
		top.Controls.Add(luckBlindBoxMode);
		top.Controls.Add(CreateCaption("选购模式"));
		top.Controls.Add(luckPurchaseMode);
		luckPage.Controls.Add(top);

		luckItemsGrid = CreateLuckGrid();
		var footer = new Panel
		{
			Dock = DockStyle.Bottom,
			Height = 42,
			Padding = new Padding(12, 5, 0, 0)
		};
		var save = CreateButton("保存配置", 0, 0, delegate { 保存鸿运当头配置(); });
		var reload = CreateButton("重载配置", 109, 0, delegate
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 62);
		});
		footer.Controls.Add(save);
		footer.Controls.Add(reload);
		luckPage.Controls.Add(luckItemsGrid);
		luckPage.Controls.Add(footer);
}

	private static Label CreateCaption(string text)
	{
		return new Label
		{
			AutoSize = true,
			Margin = new Padding(8, 8, 2, 3),
			Text = text,
			TextAlign = ContentAlignment.MiddleLeft
		};
	}

	private static NumericUpDown CreateNumber(decimal maximum, decimal minimum)
	{
		return new NumericUpDown
		{
			Maximum = maximum,
			Minimum = minimum,
			Width = 85,
			Margin = new Padding(2, 3, 3, 3)
		};
	}

	private static ComboBox CreateEnumCombo<T>(int width) where T : struct, Enum
	{
		var combo = new ComboBox
		{
			DropDownStyle = ComboBoxStyle.DropDownList,
			FormattingEnabled = true,
			Width = width,
			Margin = new Padding(2, 3, 3, 3)
		};
		combo.Items.AddRange(Enum.GetNames(typeof(T)));
		if (combo.Items.Count > 0)
		{
			combo.SelectedIndex = 0;
		}
		return combo;
	}

	private static DataGridView CreateLuckGrid()
	{
		var grid = new DataGridView
		{
			AllowUserToAddRows = true,
			AllowUserToDeleteRows = true,
			AutoGenerateColumns = false,
			AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
			Dock = DockStyle.Fill,
			EditMode = DataGridViewEditMode.EditOnEnter,
			MultiSelect = false,
			RowHeadersVisible = false
		};
		AddTextColumn(grid, "Key", "key", 110);
		AddTextColumn(grid, "下标", "index", 55);
		AddTextColumn(grid, "分类", "category", 75);
		AddTextColumn(grid, "物品数量", "count", 70);
		AddTextColumn(grid, "盲盒份数", "shares", 70);
		AddTextColumn(grid, "商店类型", "shop", 70);
		AddTextColumn(grid, "名字", "name", 120);
		AddTextColumn(grid, "价格", "price", 75);
		AddTextColumn(grid, "图标", "icon", 65);
		AddTextColumn(grid, "颜色", "color", 65);
		AddTextColumn(grid, "单位", "unit", 55);
		AddTextColumn(grid, "道具描述", "description", 180);
		AddCheckColumn(grid, "是否叠加", "stack");
		AddCheckColumn(grid, "是否限购", "limit");
		AddTextColumn(grid, "限购数量", "limitCount", 75);
		return grid;
	}

	private static void AddTextColumn(DataGridView grid, string header, string name, int width)
	{
		grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = header, Name = name, Width = width });
	}

	private static void AddCheckColumn(DataGridView grid, string header, string name)
	{
		grid.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = header, Name = name, Width = 70 });
	}

	private void 鸿运当头配置组件赋值()
	{
		if (luckPage == null)
		{
			return;
		}
		var config = Singleton<全局变量类>.I.鸿运当头配置 ?? new 鸿运当头配置类();
		luckEnabled.Checked = config.功能开关;
		SelectEnum(luckRandomMode, config.随机抽取模式);
		luckDrawCost.Value = Clamp(config.抽取模式消耗, luckDrawCost.Minimum, luckDrawCost.Maximum);
		luckBlindBoxEnabled.Checked = config.盲盒选购模式开关;
		SelectEnum(luckBlindBoxMode, config.盲盒选购模式);
		luckPurchaseMode.Value = Clamp(config.选购模式, luckPurchaseMode.Minimum, luckPurchaseMode.Maximum);
		luckItemsGrid.Rows.Clear();
		foreach (var pair in config.列表.OrderBy(item => item.Value.下标))
		{
			var item = pair.Value;
			luckItemsGrid.Rows.Add(pair.Key, item.下标, item.分类, item.物品数量, item.盲盒份数, item.商店类型, item.名字, item.价格, item.图标, item.颜色, item.单位, item.道具描述, item.是否叠加, item.是否限购, item.限购数量);
		}
	}

	private static decimal Clamp(int value, decimal minimum, decimal maximum)
	{
		return Math.Min(maximum, Math.Max(minimum, value));
	}

	private static void SelectEnum<T>(ComboBox combo, T value) where T : struct, Enum
	{
		var name = value.ToString();
		var index = combo.Items.IndexOf(name);
		combo.SelectedIndex = index >= 0 ? index : 0;
	}

	private void 保存鸿运当头配置()
	{
		var config = Singleton<全局变量类>.I.鸿运当头配置 ?? new 鸿运当头配置类();
		config.功能开关 = luckEnabled.Checked;
		config.随机抽取模式 = ParseEnum(luckRandomMode, config.随机抽取模式);
		config.抽取模式消耗 = (int)luckDrawCost.Value;
		config.盲盒选购模式开关 = luckBlindBoxEnabled.Checked;
		config.盲盒选购模式 = ParseEnum(luckBlindBoxMode, config.盲盒选购模式);
		config.选购模式 = (int)luckPurchaseMode.Value;
		var items = new ConcurrentDictionary<string, 鸿运物品列表类>();
		foreach (DataGridViewRow row in luckItemsGrid.Rows)
		{
			if (row.IsNewRow)
			{
				continue;
			}
			var key = CellText(row, "key");
			var item = new 鸿运物品列表类
			{
				下标 = ParseShort(CellText(row, "index")),
				分类 = ParseEnum(CellText(row, "category"), AllEnums.数值Type.无),
				物品数量 = ParseInt(CellText(row, "count"), 1),
				盲盒份数 = ParseInt(CellText(row, "shares"), 1),
				商店类型 = ParseInt(CellText(row, "shop"), 7),
				名字 = CellText(row, "name"),
				价格 = ParseInt(CellText(row, "price")),
				图标 = ParseInt(CellText(row, "icon")),
				颜色 = ParseEnum(CellText(row, "color"), AllEnums.颜色Type.金色),
				单位 = CellText(row, "unit"),
				道具描述 = CellText(row, "description"),
				是否叠加 = CellBool(row, "stack"),
				是否限购 = CellBool(row, "limit"),
				限购数量 = ParseInt(CellText(row, "limitCount"))
			};
			if (string.IsNullOrWhiteSpace(key))
			{
				key = $"{item.下标}:{item.名字}";
			}
			items[key] = item;
		}
		config.列表 = items;
		Singleton<全局变量类>.I.鸿运当头配置 = config;
		Singleton<全局变量类>.I.验证client.SendRT(10018, 62, JsonConvert.SerializeObject(config, Formatting.Indented));
	}

	private static string CellText(DataGridViewRow row, string name)
	{
		return row.Cells[name].Value?.ToString() ?? string.Empty;
	}

	private static bool CellBool(DataGridViewRow row, string name)
	{
		return row.Cells[name].Value is bool value && value;
	}

	private static int ParseInt(string value, int fallback = 0)
	{
		return int.TryParse(value, out var result) ? result : fallback;
	}

	private static short ParseShort(string value)
	{
		return short.TryParse(value, out var result) ? result : (short)0;
	}

	private static T ParseEnum<T>(ComboBox combo, T fallback) where T : struct, Enum
	{
		return ParseEnum(combo.SelectedItem?.ToString(), fallback);
	}

	private static T ParseEnum<T>(string value, T fallback) where T : struct, Enum
	{
		return Enum.TryParse(value, out T result) ? result : fallback;
	}

	private void BuildNostalgiaPage()
	{
		var header = new Panel { Dock = DockStyle.Top, Height = 42 };
		var enabled = new CheckBox { AutoSize = true, Location = new Point(10, 9), Text = "功能开关" };
		nostalgiaSwitches[typeof(怀旧专区配置类).GetField("功能开关")] = enabled;
		header.Controls.Add(enabled);
		header.Controls.Add(CreateButton("保存配置", 150, 5, delegate { 保存怀旧专区配置(); }));
		header.Controls.Add(CreateButton("重载配置", 259, 5, delegate
		{
			Singleton<全局变量类>.I.验证client.SendRT(10017, 49);
		}));
		nostalgiaPage.Controls.Add(header);

		var content = new FlowLayoutPanel
		{
			AutoScroll = true,
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.TopDown,
			Padding = new Padding(6),
			WrapContents = false
		};
		foreach (var group in typeof(怀旧专区配置类).GetFields(BindingFlags.Instance | BindingFlags.Public)
			.Where(field => field.FieldType == typeof(bool) && field.Name != "功能开关")
			.GroupBy(field => field.Name.Split('_')[0]))
		{
			var panel = new FlowLayoutPanel
			{
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Dock = DockStyle.Top,
				FlowDirection = FlowDirection.LeftToRight,
				Padding = new Padding(6),
				WrapContents = true
			};
			var box = new GroupBox
			{
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				MinimumSize = new Size(900, 60),
				Text = group.Key
			};
			box.Controls.Add(panel);
			foreach (var field in group)
			{
				var check = new CheckBox
				{
					AutoSize = false,
					Margin = new Padding(3),
					Size = new Size(185, 25),
					Text = field.Name.Substring(field.Name.IndexOf('_') + 1)
				};
				nostalgiaSwitches[field] = check;
				panel.Controls.Add(check);
			}
			content.Controls.Add(box);
		}
		nostalgiaPage.Controls.Add(content);
	}

	private void 怀旧专区配置组件赋值()
	{
		var config = Singleton<全局变量类>.I.怀旧专区配置 ?? new 怀旧专区配置类();
		Singleton<全局变量类>.I.怀旧专区配置 = config;
		foreach (var pair in nostalgiaSwitches)
		{
			pair.Value.Checked = (bool)(pair.Key.GetValue(config) ?? false);
		}
	}

	private void 保存怀旧专区配置()
	{
		var config = Singleton<全局变量类>.I.怀旧专区配置 ?? new 怀旧专区配置类();
		foreach (var pair in nostalgiaSwitches)
		{
			pair.Key.SetValue(config, pair.Value.Checked);
		}
		Singleton<全局变量类>.I.怀旧专区配置 = config;
		Singleton<全局变量类>.I.验证client.SendRT(10018, 49, JsonConvert.SerializeObject(config, Formatting.Indented));
	}
}
