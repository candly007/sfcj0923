using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft_X.Json;

namespace NetClientFrom;

public sealed class 限时副本地图配置窗口 : Form
{
    private const int TimedDungeonConfigType = 1000;
    private static 限时副本地图配置窗口 i;
    private readonly CheckBox 总开关 = new() { Text = "启用限时副本地图", AutoSize = true };
    private readonly DataGridView 规则列表 = new();
    private readonly BindingSource 数据源 = new();
    private readonly Label 状态 = new() { AutoSize = true, ForeColor = Color.DimGray };
    private 限时副本配置 配置 = new();

    public static 限时副本地图配置窗口 I => i ??= new 限时副本地图配置窗口();

    private 限时副本地图配置窗口()
    {
        Text = "限时副本地图配置";
        StartPosition = FormStartPosition.CenterScreen;
        MinimumSize = new Size(1100, 560);
        Size = new Size(1260, 680);
        Font = new Font("Microsoft YaHei UI", 9F);

        var toolbar = new FlowLayoutPanel { Dock = DockStyle.Top, Height = 42, Padding = new Padding(8, 7, 8, 4), WrapContents = false };
        toolbar.Controls.Add(总开关);
        toolbar.Controls.Add(Button("添加规则", 添加));
        toolbar.Controls.Add(Button("删除选中", 删除));
        toolbar.Controls.Add(Button("保存到插件", 保存到插件));
        toolbar.Controls.Add(Button("从插件重载", 从插件重载));
        toolbar.Controls.Add(Button("导入 JSON", 导入));
        toolbar.Controls.Add(Button("导出 JSON", 导出));
        toolbar.Controls.Add(Button("检查配置", 检查));

        规则列表.Dock = DockStyle.Fill;
        规则列表.AutoGenerateColumns = false;
        规则列表.AllowUserToAddRows = false;
        规则列表.AllowUserToDeleteRows = false;
        规则列表.RowHeadersVisible = false;
        规则列表.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        规则列表.MultiSelect = false;
        规则列表.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        AddText("ID", nameof(限时副本规则.ID), 120);
        AddCheck("启用", nameof(限时副本规则.Enabled));
        AddText("名称", nameof(限时副本规则.Name), 100);
        AddText("入口NPC", nameof(限时副本规则.EntryNPCName), 90);
        AddText("入口命令", nameof(限时副本规则.EntryCommand), 100);
        AddNumber("地图编号", nameof(限时副本规则.TargetMapCode));
        AddText("地图名称", nameof(限时副本规则.TargetMapName), 90);
        AddNumber("时长(分)", nameof(限时副本规则.DurationMinutes));
        AddNumber("每日次数", nameof(限时副本规则.DailyLimit));
        AddCombo("费用类型", nameof(限时副本规则.CostType), "yuanbao", "cash", "item");
        AddText("道具名称", nameof(限时副本规则.ItemName), 90);
        AddCombo("元宝类型", nameof(限时副本规则.YuanbaoType), "gold_coin", "silver_coin");
        AddNumber("费用数量", nameof(限时副本规则.CostAmount));
        AddCombo("扣费方式", nameof(限时副本规则.ChargeMode), "leader", "all");
        AddText("返回地图", nameof(限时副本规则.ExitMapName), 90);
        AddText("返回路径", nameof(限时副本规则.ExitMapPath), 180);
        AddNumber("返回X", nameof(限时副本规则.ExitX));
        AddNumber("返回Y", nameof(限时副本规则.ExitY));

        var statusPanel = new Panel { Dock = DockStyle.Bottom, Height = 32, Padding = new Padding(10, 7, 10, 0) };
        statusPanel.Controls.Add(状态);
        Controls.Add(规则列表);
        Controls.Add(statusPanel);
        Controls.Add(toolbar);
        LoadLocal();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        e.Cancel = true;
        Hide();
    }

    public new void Show()
    {
        if (WindowState == FormWindowState.Minimized) WindowState = FormWindowState.Normal;
        base.Show();
        BringToFront();
    }

    private static Button Button(string text, EventHandler click)
    {
        var button = new Button { Text = text, AutoSize = true, Height = 27 };
        button.Click += click;
        return button;
    }

    private void AddText(string header, string property, int width) => 规则列表.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = header, DataPropertyName = property, MinimumWidth = width });
    private void AddNumber(string header, string property) => 规则列表.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = header, DataPropertyName = property, MinimumWidth = 72 });
    private void AddCheck(string header, string property) => 规则列表.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = header, DataPropertyName = property, Width = 55 });
    private void AddCombo(string header, string property, params string[] values) => 规则列表.Columns.Add(new DataGridViewComboBoxColumn { HeaderText = header, DataPropertyName = property, DataSource = values, MinimumWidth = 90 });

    private void 添加(object sender, EventArgs e)
    {
        配置.Rules.Add(new 限时副本规则());
        Bind();
    }

    private void 删除(object sender, EventArgs e)
    {
        if (规则列表.CurrentRow?.DataBoundItem is 限时副本规则 rule) 配置.Rules.Remove(rule);
        Bind();
    }

    private void 导入(object sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog { Filter = "JSON 配置|*.json|所有文件|*.*", FileName = "timed-dungeon.json" };
        if (dialog.ShowDialog(this) != DialogResult.OK) return;
        配置 = JsonConvert.DeserializeObject<限时副本配置>(File.ReadAllText(dialog.FileName)) ?? new();
        总开关.Checked = 配置.Open;
        Bind();
        状态.Text = "已导入：" + dialog.FileName;
    }

    private void 保存到插件(object sender, EventArgs e)
    {
        规则列表.EndEdit();
        配置.Open = 总开关.Checked;
        string error = ValidateConfig();
        if (!string.IsNullOrEmpty(error))
        {
            MessageBox.Show(error, "配置检查", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        Singleton<全局变量类>.I.验证client.SendRT(10018, TimedDungeonConfigType, JsonConvert.SerializeObject(配置, Formatting.Indented));
        状态.Text = "配置已发送到插件。";
    }

    private void 从插件重载(object sender, EventArgs e)
    {
        Singleton<全局变量类>.I.验证client.SendRT(10017, TimedDungeonConfigType);
        状态.Text = "正在从插件读取配置...";
    }

    public void 加载远程配置(string json)
    {
        if (InvokeRequired)
        {
            BeginInvoke((MethodInvoker)(() => 加载远程配置(json)));
            return;
        }
        配置 = JsonConvert.DeserializeObject<限时副本配置>(json) ?? new();
        总开关.Checked = 配置.Open;
        Bind();
        状态.Text = "已从插件重载配置。";
    }

    private void 导出(object sender, EventArgs e)
    {
        规则列表.EndEdit();
        配置.Open = 总开关.Checked;
        string error = ValidateConfig();
        if (!string.IsNullOrEmpty(error)) { MessageBox.Show(error, "配置检查", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
        using var dialog = new SaveFileDialog { Filter = "JSON 配置|*.json", FileName = "timed-dungeon.json" };
        if (dialog.ShowDialog(this) != DialogResult.OK) return;
        File.WriteAllText(dialog.FileName, JsonConvert.SerializeObject(配置, Formatting.Indented));
        状态.Text = "已导出：" + dialog.FileName;
    }

    private void 检查(object sender, EventArgs e)
    {
        规则列表.EndEdit();
        配置.Open = 总开关.Checked;
        string error = ValidateConfig();
        MessageBox.Show(string.IsNullOrEmpty(error) ? $"配置有效，共 {配置.Rules.Count} 条规则。" : error, "配置检查", MessageBoxButtons.OK, string.IsNullOrEmpty(error) ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
    }

    private string ValidateConfig()
    {
        var ids = new HashSet<string>();
        var commands = new HashSet<string>();
        for (int index = 0; index < 配置.Rules.Count; index++)
        {
            var r = 配置.Rules[index];
            string prefix = $"第 {index + 1} 条：";
            if (string.IsNullOrWhiteSpace(r.ID) || !ids.Add(r.ID)) return prefix + "ID 为空或重复。";
            if (string.IsNullOrWhiteSpace(r.EntryCommand) || r.EntryCommand.Length > 80) return prefix + "入口命令无效。";
            if (r.Enabled && !commands.Add(r.EntryCommand)) return prefix + "启用规则的入口命令重复。";
            if (r.TargetMapCode <= 0) return prefix + "地图编号必须大于 0。";
            if (r.DurationMinutes < 1 || r.DurationMinutes > 10080) return prefix + "时长必须为 1-10080 分钟。";
            if (r.DailyLimit < 0) return prefix + "每日次数不能小于 0。";
            if (r.CostAmount < 1) return prefix + "费用数量必须大于 0。";
            if (r.CostType == "item" && string.IsNullOrWhiteSpace(r.ItemName)) return prefix + "道具费用必须填写道具名称。";
            if (string.IsNullOrWhiteSpace(r.ExitMapPath) || !r.ExitMapPath.StartsWith("/") || !r.ExitMapPath.EndsWith(".c")) return prefix + "返回地图路径无效。";
        }
        return string.Empty;
    }

    private void LoadLocal()
    {
        string path = Path.Combine(AppContext.BaseDirectory, "timed-dungeon.json");
        if (File.Exists(path)) 配置 = JsonConvert.DeserializeObject<限时副本配置>(File.ReadAllText(path)) ?? new();
        总开关.Checked = 配置.Open;
        Bind();
        状态.Text = "可导出 timed-dungeon.json 后放到插件主程序目录。";
    }

    private void Bind()
    {
        数据源.DataSource = null;
        数据源.DataSource = 配置.Rules;
        规则列表.DataSource = 数据源;
    }
}

public sealed class 限时副本配置
{
    public bool Open { get; set; }
    public List<限时副本规则> Rules { get; set; } = new();
}

public sealed class 限时副本规则
{
    public string ID { get; set; } = Guid.NewGuid().ToString("N");
    public bool Enabled { get; set; } = true;
    public string Name { get; set; } = "限时副本";
    public string EntryNPCName { get; set; } = string.Empty;
    public string EntryCommand { get; set; } = string.Empty;
    public int TargetMapCode { get; set; }
    public string TargetMapName { get; set; } = string.Empty;
    public int DurationMinutes { get; set; } = 30;
    public int DailyLimit { get; set; }
    public string CostType { get; set; } = "yuanbao";
    public string ItemName { get; set; } = string.Empty;
    public string YuanbaoType { get; set; } = "gold_coin";
    public int CostAmount { get; set; } = 1;
    public string ChargeMode { get; set; } = "leader";
    public string ExitMapName { get; set; } = "天墉城";
    public string ExitMapPath { get; set; } = "/tianyongcheng/tianyongcheng.c";
    public int ExitX { get; set; } = 140;
    public int ExitY { get; set; } = 120;
}
