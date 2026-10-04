using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json;
using Serilog;

public sealed class TimedDungeonService
{
	private static readonly Regex ExitMapPathPattern = new Regex("^/[A-Za-z0-9_./-]+\\.c$", RegexOptions.Compiled);
	private static readonly Lazy<TimedDungeonService> LazyInstance = new Lazy<TimedDungeonService>(() => new TimedDungeonService());
	private readonly object sync = new object();
	private readonly string configPath = Path.Combine(AppContext.BaseDirectory, "timed-dungeon.json");
	private readonly string statePath = Path.Combine(AppContext.BaseDirectory, "timed-dungeon-state.json");
	private TimedDungeonConfig config = new TimedDungeonConfig();
	private TimedDungeonRuntimeState state = new TimedDungeonRuntimeState();
	private DateTime configWriteUtc;
	private Timer timer;
	private bool initialized;
	private int tickRunning;

	public static TimedDungeonService I => LazyInstance.Value;

	private TimedDungeonService()
	{
	}

	public void Initialize()
	{
		lock (sync)
		{
			if (initialized)
			{
				return;
			}
			try
			{
				Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
				LoadConfigLocked(createWhenMissing: true);
				LoadStateLocked();
				PruneDailyCountsLocked();
				timer = new Timer(Tick, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
				Log.Information("限时副本模块已加载：开关={Open}，规则={RuleCount}", config.Open, config.Rules.Count);
			}
			catch (Exception ex)
			{
				config = new TimedDungeonConfig();
				state = new TimedDungeonRuntimeState();
				Log.Error(ex, "限时副本模块初始化失败，模块保持关闭，不影响原插件流程");
			}
			finally
			{
				initialized = true;
			}
		}
	}

	public string GetConfigJson()
	{
		Initialize();
		lock (sync)
		{
			ReloadConfigIfChangedLocked();
			return JsonConvert.SerializeObject(config, Formatting.Indented);
		}
	}

	public void UpdateConfigJson(string json)
	{
		Initialize();
		TimedDungeonConfig updated = JsonConvert.DeserializeObject<TimedDungeonConfig>(json) ?? throw new InvalidOperationException("限时副本配置为空");
		ValidateConfig(updated);
		lock (sync)
		{
			WriteAtomic(configPath, JsonConvert.SerializeObject(updated, Formatting.Indented));
			config = updated;
			configWriteUtc = File.GetLastWriteTimeUtc(configPath);
		}
	}

	public bool BeforeEntry(MyNATSocketClient leader, string command, string npcName)
	{
		try
		{
			return BeforeEntryCore(leader, command, npcName);
		}
		catch (Exception ex)
		{
			Log.Error(ex, "限时副本入口检查异常，已放行原始进图请求");
			return true;
		}
	}

	private bool BeforeEntryCore(MyNATSocketClient leader, string command, string npcName)
	{
		Initialize();
		if (leader == null || string.IsNullOrWhiteSpace(command))
		{
			return true;
		}
		ApplyQueuedRefunds(leader);
		TimedDungeonRule rule;
		lock (sync)
		{
			ReloadConfigIfChangedLocked();
			rule = FindRule(config, command);
		}
		if (rule == null)
		{
			return true;
		}
		return BeginEntry(leader, rule, npcName ?? string.Empty);
	}

	public void OnMapUpdated(MyNATSocketClient client, int mapCode, string mapName)
	{
		try
		{
			OnMapUpdatedCore(client, mapCode, mapName);
		}
		catch (Exception ex)
		{
			Log.Error(ex, "限时副本地图更新处理异常，已跳过新模块处理");
		}
	}

	private void OnMapUpdatedCore(MyNATSocketClient client, int mapCode, string mapName)
	{
		Initialize();
		if (client == null)
		{
			return;
		}
		ApplyQueuedRefunds(client);
		string roleKey = RoleKey(client);
		TimedDungeonSession activated = null;
		TimedDungeonSession expired = null;
		bool changed = false;
		lock (sync)
		{
			TimedDungeonSession active = state.Sessions.FirstOrDefault(x => x.RoleKey == roleKey);
			if (active != null && active.TargetMapCode != mapCode)
			{
				state.Sessions.Remove(active);
				changed = true;
			}
			TimedDungeonPendingGroup pending = state.PendingGroups.FirstOrDefault(x => x.MemberKeys.Contains(roleKey) && !x.EnteredKeys.Contains(roleKey) && x.TargetMapCode == mapCode);
			if (pending != null && pending.DeadlineUtc > DateTime.UtcNow)
			{
				pending.EnteredKeys.Add(roleKey);
				activated = CreateSession(pending, client);
				state.Sessions.RemoveAll(x => x.RoleKey == roleKey);
				state.Sessions.Add(activated);
				string dailyKey = DailyKey(roleKey, pending.RuleID);
				state.DailyCounts[dailyKey] = state.DailyCounts.TryGetValue(dailyKey, out int count) ? count + 1 : 1;
				if (pending.EnteredKeys.Count >= pending.MemberKeys.Count)
				{
					state.PendingGroups.Remove(pending);
				}
				changed = true;
			}
			TimedDungeonSession current = state.Sessions.FirstOrDefault(x => x.RoleKey == roleKey && x.TargetMapCode == mapCode);
			if (current != null && current.ExpiresUtc <= DateTime.UtcNow)
			{
				expired = current;
			}
			if (changed)
			{
				SaveStateLocked();
			}
		}
		if (activated != null)
		{
			Tip(client, $"#G已进入#Y{activated.RuleName}#n，剩余时间#R{Math.Max(1, (int)Math.Ceiling((activated.ExpiresUtc - DateTime.UtcNow).TotalMinutes))}#n分钟。");
		}
		if (expired != null)
		{
			RequestExit(client, expired);
		}
	}

	public void OnCombatEnded(MyNATSocketClient client)
	{
		try
		{
			OnCombatEndedCore(client);
		}
		catch (Exception ex)
		{
			Log.Error(ex, "限时副本战斗结束处理异常，已跳过新模块处理");
		}
	}

	private void OnCombatEndedCore(MyNATSocketClient client)
	{
		Initialize();
		if (client == null)
		{
			return;
		}
		TimedDungeonSession expired;
		lock (sync)
		{
			expired = state.Sessions.FirstOrDefault(x => x.RoleKey == RoleKey(client) && x.TargetMapCode == client.user.人物数据.所在地图id && x.ExpiresUtc <= DateTime.UtcNow);
		}
		if (expired != null)
		{
			RequestExit(client, expired);
		}
	}

	public void OnDisconnected(MyNATSocketClient client)
	{
		// Active sessions remain persisted. On reconnect the map update hook either
		// resumes the timer or moves an expired role out of the dungeon.
	}

	public static void RunSelfTest()
	{
		TimedDungeonConfig valid = new TimedDungeonConfig
		{
			Open = true,
			Rules = new List<TimedDungeonRule>
			{
				new TimedDungeonRule
				{
					ID = "self-test", Name = "测试副本", EntryCommand = "plugin_enter_test", TargetMapCode = 9001,
					TargetMapName = "测试地图", DurationMinutes = 10, DailyLimit = 2, CostType = "cash",
					CostAmount = 10, ChargeMode = "leader", ExitMapName = "天墉城",
					ExitMapPath = "/tianyongcheng/tianyongcheng.c", ExitX = 140, ExitY = 120
				}
			}
		};
		ValidateConfig(valid);
		if (FindRule(valid, "plugin_enter_test") == null || FindRule(new TimedDungeonConfig(), "plugin_enter_test") != null)
		{
			throw new InvalidOperationException("命令匹配自检失败");
		}
		TimedDungeonConfig roundTripConfig = JsonConvert.DeserializeObject<TimedDungeonConfig>(JsonConvert.SerializeObject(valid));
		ValidateConfig(roundTripConfig);
		if (!roundTripConfig.Open || roundTripConfig.Rules.Count != 1 || roundTripConfig.Rules[0].EntryCommand != "plugin_enter_test")
		{
			throw new InvalidOperationException("后台配置往返自检失败");
		}
		TimedDungeonPendingGroup leaderPending = new TimedDungeonPendingGroup { ChargeMode = "leader", EnteredKeys = new List<string>() };
		TimedDungeonCharge leaderCharge = new TimedDungeonCharge { RoleKey = "role:1" };
		if (!ShouldRefund(leaderPending, leaderCharge))
		{
			throw new InvalidOperationException("队长未进图退款自检失败");
		}
		leaderPending.EnteredKeys.Add("role:2");
		if (ShouldRefund(leaderPending, leaderCharge))
		{
			throw new InvalidOperationException("队伍已进图退款边界自检失败");
		}
		TimedDungeonPendingGroup allPending = new TimedDungeonPendingGroup { ChargeMode = "all", EnteredKeys = new List<string> { "role:1" } };
		if (ShouldRefund(allPending, leaderCharge) || !ShouldRefund(allPending, new TimedDungeonCharge { RoleKey = "role:2" }))
		{
			throw new InvalidOperationException("全队扣费退款边界自检失败");
		}
		string json = JsonConvert.SerializeObject(new TimedDungeonRuntimeState
		{
			PendingGroups = new List<TimedDungeonPendingGroup> { leaderPending },
			Sessions = new List<TimedDungeonSession> { new TimedDungeonSession { RoleKey = "role:1", ExpiresUtc = DateTime.UtcNow.AddMinutes(1) } }
		});
		TimedDungeonRuntimeState roundTrip = JsonConvert.DeserializeObject<TimedDungeonRuntimeState>(json);
		if (roundTrip == null || roundTrip.PendingGroups.Count != 1 || roundTrip.Sessions.Count != 1)
		{
			throw new InvalidOperationException("状态序列化自检失败");
		}
		Console.WriteLine("TIMED_DUNGEON_SELF_TEST=PASS");
		Console.WriteLine("PASS_THROUGH_WHEN_DISABLED=PASS");
		Console.WriteLine("PENDING_REFUND_RULES=PASS");
		Console.WriteLine("STATE_JSON_ROUND_TRIP=PASS");
		Console.WriteLine("ADMIN_CONFIG_ROUND_TRIP=PASS");
	}

	private bool BeginEntry(MyNATSocketClient leader, TimedDungeonRule rule, string npcName)
	{
		List<MyNATSocketClient> members;
		string error;
		if (!TryResolveMembers(leader, out members, out error))
		{
			return Reject(leader, error);
		}
		if (!string.IsNullOrWhiteSpace(rule.EntryNPCName) && !string.Equals(rule.EntryNPCName, npcName, StringComparison.Ordinal))
		{
			return Reject(leader, "#R请从指定NPC进入限时副本。");
		}
		string mapName = leader.user.人物数据.所在地图名字;
		int mapCode = leader.user.人物数据.所在地图id;
		foreach (MyNATSocketClient member in members)
		{
			if (member.user.人物数据.所在地图id != mapCode || !string.Equals(member.user.人物数据.所在地图名字, mapName, StringComparison.Ordinal))
			{
				return Reject(leader, "#R队伍成员必须在同一地图。");
			}
			if (member.user.缓存数据.is战斗中 || member.user.存档数据.is摆摊中)
			{
				return Reject(leader, "#R队伍中有玩家正在战斗或摆摊。");
			}
		}
		List<MyNATSocketClient> payers = rule.ChargeMode == "all" ? members : new List<MyNATSocketClient> { leader };
		lock (sync)
		{
			foreach (MyNATSocketClient member in members)
			{
				string roleKey = RoleKey(member);
				if (state.Sessions.Any(x => x.RoleKey == roleKey) || state.PendingGroups.Any(x => x.MemberKeys.Contains(roleKey)))
				{
					return Reject(leader, "#Y队伍中已有角色正在限时副本或等待进入。");
				}
				if (rule.DailyLimit > 0 && DailyCountLocked(roleKey, rule.ID) >= rule.DailyLimit)
				{
					return Reject(leader, $"#Y{member.user.人物数据.昵称}今日进入{rule.Name}的次数已达到上限。");
				}
			}
			foreach (MyNATSocketClient payer in payers)
			{
				if (!CanPay(payer, rule, out error))
				{
					return Reject(leader, "#R进入失败：" + error);
				}
			}
			List<TimedDungeonCharge> charges = new List<TimedDungeonCharge>();
			foreach (MyNATSocketClient payer in payers)
			{
				TimedDungeonCharge charge = BuildCharge(payer, rule);
				if (!ApplyCharge(payer, charge, refund: false))
				{
					foreach (TimedDungeonCharge applied in charges)
					{
						MyNATSocketClient appliedClient = FindClient(applied.RoleKey);
						if (appliedClient == null || !ApplyCharge(appliedClient, applied, refund: true))
						{
							QueueRefundLocked(applied);
						}
					}
					SaveStateLocked();
					return Reject(leader, "#R扣费失败，已撤销本次已完成的扣费。");
				}
				charges.Add(charge);
			}
			TimedDungeonPendingGroup pending = new TimedDungeonPendingGroup
			{
				Token = Guid.NewGuid().ToString("N"), RuleID = rule.ID, RuleName = rule.Name,
				TargetMapCode = rule.TargetMapCode, TargetMapName = rule.TargetMapName,
				DurationMinutes = rule.DurationMinutes, DailyLimit = rule.DailyLimit,
				ExitMapName = rule.ExitMapName, ExitMapPath = rule.ExitMapPath, ExitX = rule.ExitX, ExitY = rule.ExitY,
				ChargeMode = rule.ChargeMode, MemberKeys = members.Select(RoleKey).Distinct().ToList(),
				EnteredKeys = new List<string>(), Charges = charges, CreatedUtc = DateTime.UtcNow,
				DeadlineUtc = DateTime.UtcNow.AddSeconds(20)
			};
			state.PendingGroups.Add(pending);
			if (!SaveStateLocked())
			{
				state.PendingGroups.Remove(pending);
				foreach (TimedDungeonCharge charge in charges)
				{
					MyNATSocketClient payer = FindClient(charge.RoleKey);
					if (payer == null || !ApplyCharge(payer, charge, refund: true))
					{
						QueueRefundLocked(charge);
					}
				}
				SaveStateLocked();
				return Reject(leader, "#R限时副本状态保存失败，本次进入已取消并退回费用。");
			}
		}
		Tip(leader, $"#G资格校验和{CostText(rule)}扣除成功，正在进入#Y{rule.Name}#n。");
		return true;
	}

	private bool TryResolveMembers(MyNATSocketClient leader, out List<MyNATSocketClient> members, out string error)
	{
		members = new List<MyNATSocketClient> { leader };
		error = string.Empty;
		List<int> ids = leader.user.队伍数据.成员列表 == null ? new List<int>() : leader.user.队伍数据.成员列表.Distinct().ToList();
		if (ids.Count > 0 && !leader.user.队伍数据.is队长)
		{
			error = "#R请由队长开启限时副本。";
			return false;
		}
		foreach (int id in ids)
		{
			if (id == leader.user.人物数据.角色ID)
			{
				continue;
			}
			MyNATSocketClient member = Singleton<MainService>.I.获取指定角色ID玩家MyClient(id);
			if (member == null)
			{
				error = "#R队伍中有成员不在线。";
				return false;
			}
			members.Add(member);
		}
		return true;
	}

	private void Tick(object ignored)
	{
		if (Interlocked.Exchange(ref tickRunning, 1) != 0)
		{
			return;
		}
		try
		{
			List<MyNATSocketClient> online = OnlineClients();
			List<TimedDungeonSession> sessions;
			lock (sync)
			{
				ReloadConfigIfChangedLocked();
				bool changed = ReconcileExpiredPendingLocked(online);
				PruneDailyCountsLocked();
				if (changed)
				{
					SaveStateLocked();
				}
				sessions = state.Sessions.ToList();
			}
			foreach (MyNATSocketClient client in online)
			{
				ApplyQueuedRefunds(client);
			}
			foreach (TimedDungeonSession session in sessions)
			{
				MyNATSocketClient client = online.FirstOrDefault(x => RoleKey(x) == session.RoleKey);
				if (client == null)
				{
					continue;
				}
				if (client.user.人物数据.所在地图id != session.TargetMapCode)
				{
					lock (sync)
					{
						if (state.Sessions.RemoveAll(x => x.Token == session.Token && x.RoleKey == session.RoleKey) > 0)
						{
							SaveStateLocked();
						}
					}
					continue;
				}
				if (session.ExpiresUtc <= DateTime.UtcNow)
				{
					RequestExit(client, session);
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error(ex, "限时副本定时处理异常");
		}
		finally
		{
			Volatile.Write(ref tickRunning, 0);
		}
	}

	private bool ReconcileExpiredPendingLocked(List<MyNATSocketClient> online)
	{
		bool changed = false;
		foreach (TimedDungeonPendingGroup pending in state.PendingGroups.Where(x => x.DeadlineUtc <= DateTime.UtcNow).ToList())
		{
			foreach (TimedDungeonCharge charge in pending.Charges.Where(x => ShouldRefund(pending, x)))
			{
				QueueRefundLocked(charge);
			}
			state.PendingGroups.Remove(pending);
			changed = true;
		}
		return changed;
	}

	private void RequestExit(MyNATSocketClient client, TimedDungeonSession session)
	{
		if (client.user.人物数据.所在地图id != session.TargetMapCode)
		{
			return;
		}
		if (client.user.缓存数据.is战斗中)
		{
			lock (sync)
			{
				TimedDungeonSession stored = state.Sessions.FirstOrDefault(x => x.Token == session.Token && x.RoleKey == session.RoleKey);
				if (stored != null && !stored.TimedOut)
				{
					stored.TimedOut = true;
					SaveStateLocked();
				}
			}
			return;
		}
		bool send;
		lock (sync)
		{
			TimedDungeonSession stored = state.Sessions.FirstOrDefault(x => x.Token == session.Token && x.RoleKey == session.RoleKey);
			if (stored == null)
			{
				return;
			}
			send = stored.LastExitRequestUtc == null || DateTime.UtcNow - stored.LastExitRequestUtc.Value >= TimeSpan.FromSeconds(5);
			if (send)
			{
				stored.TimedOut = true;
				stored.LastExitRequestUtc = DateTime.UtcNow;
				SaveStateLocked();
			}
		}
		if (!send)
		{
			return;
		}
		Tip(client, $"#R{session.RuleName}限时已结束，正在离开地图。");
		Singleton<WdAPI>.I.地图传送事件(client, session.ExitMapPath, session.ExitX.ToString(), session.ExitY.ToString());
	}

	private void ApplyQueuedRefunds(MyNATSocketClient client)
	{
		string roleKey = RoleKey(client);
		List<TimedDungeonCharge> refunds;
		lock (sync)
		{
			refunds = state.PendingRefunds.Where(x => x.RoleKey == roleKey).ToList();
		}
		foreach (TimedDungeonCharge refund in refunds)
		{
			if (!ApplyCharge(client, refund, refund: true))
			{
				continue;
			}
			lock (sync)
			{
				if (state.PendingRefunds.RemoveAll(x => x.ID == refund.ID) > 0)
				{
					SaveStateLocked();
				}
			}
			Tip(client, "#Y限时副本未完成进入，费用已退回。");
		}
	}

	private static bool CanPay(MyNATSocketClient client, TimedDungeonRule rule, out string error)
	{
		error = string.Empty;
		if (rule.CostType == "cash" && client.user.背包数据.金钱 < rule.CostAmount)
		{
			error = client.user.人物数据.昵称 + "游戏币不足";
			return false;
		}
		if (rule.CostType == "yuanbao")
		{
			int value = rule.YuanbaoType == "silver_coin" ? client.user.背包数据.银元宝 : client.user.背包数据.金元宝;
			if (value < rule.CostAmount)
			{
				error = client.user.人物数据.昵称 + (rule.YuanbaoType == "silver_coin" ? "银元宝不足" : "金元宝不足");
				return false;
			}
		}
		if (rule.CostType == "item")
		{
			int count = client.user.背包数据.物品列表.Where(x => x != null && x.名字 == rule.ItemName).Sum(x => x.数量);
			if (count < rule.CostAmount)
			{
				error = $"{client.user.人物数据.昵称}缺少{rule.ItemName}，需要{rule.CostAmount}，当前{count}";
				return false;
			}
		}
		return true;
	}

	private static TimedDungeonCharge BuildCharge(MyNATSocketClient client, TimedDungeonRule rule)
	{
		return new TimedDungeonCharge
		{
			ID = Guid.NewGuid().ToString("N"), RoleKey = RoleKey(client), RoleID = client.user.人物数据.角色ID,
			RoleName = client.user.人物数据.昵称, CostType = rule.CostType, ItemName = rule.ItemName,
			Currency = rule.CostType == "cash" ? "cash" : rule.CostType == "item" ? "item" : rule.YuanbaoType,
			Amount = rule.CostAmount
		};
	}

	private static bool ApplyCharge(MyNATSocketClient client, TimedDungeonCharge charge, bool refund)
	{
		if (client == null || charge == null || charge.Amount <= 0)
		{
			return false;
		}
		AllEnums.数值Type type = charge.CostType == "item" ? AllEnums.数值Type.道具 : charge.CostType == "cash" ? AllEnums.数值Type.金钱 : charge.Currency == "silver_coin" ? AllEnums.数值Type.银元宝 : AllEnums.数值Type.金元宝;
		int amount = refund ? charge.Amount : -charge.Amount;
		return Singleton<MainService>.I.发送角色属性道具(client, type, amount, charge.ItemName ?? string.Empty, string.Empty);
	}

	private static bool ShouldRefund(TimedDungeonPendingGroup pending, TimedDungeonCharge charge)
	{
		return pending.ChargeMode == "leader" ? pending.EnteredKeys.Count == 0 : !pending.EnteredKeys.Contains(charge.RoleKey);
	}

	private void QueueRefundLocked(TimedDungeonCharge charge)
	{
		if (charge != null && !state.PendingRefunds.Any(x => x.ID == charge.ID))
		{
			state.PendingRefunds.Add(charge);
		}
	}

	private static TimedDungeonSession CreateSession(TimedDungeonPendingGroup pending, MyNATSocketClient client)
	{
		DateTime now = DateTime.UtcNow;
		return new TimedDungeonSession
		{
			Token = pending.Token, RuleID = pending.RuleID, RuleName = pending.RuleName, RoleKey = RoleKey(client),
			RoleID = client.user.人物数据.角色ID, RoleName = client.user.人物数据.昵称,
			TargetMapCode = pending.TargetMapCode, TargetMapName = pending.TargetMapName,
			EnteredUtc = now, ExpiresUtc = now.AddMinutes(pending.DurationMinutes),
			ExitMapName = pending.ExitMapName, ExitMapPath = pending.ExitMapPath, ExitX = pending.ExitX, ExitY = pending.ExitY
		};
	}

	private static TimedDungeonRule FindRule(TimedDungeonConfig source, string command)
	{
		if (source == null || !source.Open || source.Rules == null)
		{
			return null;
		}
		return source.Rules.FirstOrDefault(x => x.Enabled && string.Equals(x.EntryCommand, command, StringComparison.Ordinal));
	}

	private static string RoleKey(MyNATSocketClient client)
	{
		if (client.user.人物数据.GID != 0)
		{
			return "gid:" + client.user.人物数据.GID;
		}
		if (client.user.人物数据.角色ID != 0)
		{
			return "role:" + client.user.人物数据.角色ID;
		}
		return "account:" + (client.user.人物数据.账号 ?? client.账号 ?? string.Empty);
	}

	private static List<MyNATSocketClient> OnlineClients()
	{
		return Singleton<全局变量类>.I.会话Dict.Values.Where(x => x != null && x.使用中 && x.user.人物数据.角色ID != 0).ToList();
	}

	private static MyNATSocketClient FindClient(string roleKey)
	{
		return Singleton<全局变量类>.I.会话Dict.Values.FirstOrDefault(x => x != null && x.使用中 && RoleKey(x) == roleKey);
	}

	private int DailyCountLocked(string roleKey, string ruleID)
	{
		return state.DailyCounts.TryGetValue(DailyKey(roleKey, ruleID), out int count) ? count : 0;
	}

	private static string DailyKey(string roleKey, string ruleID)
	{
		return DateTime.Now.ToString("yyyyMMdd") + "|" + roleKey + "|" + ruleID;
	}

	private void PruneDailyCountsLocked()
	{
		string prefix = DateTime.Now.ToString("yyyyMMdd") + "|";
		state.DailyCounts = state.DailyCounts.Where(x => x.Key.StartsWith(prefix, StringComparison.Ordinal)).ToDictionary(x => x.Key, x => x.Value);
	}

	private static string CostText(TimedDungeonRule rule)
	{
		if (rule.CostType == "item")
		{
			return rule.ItemName + " x" + rule.CostAmount;
		}
		if (rule.CostType == "cash")
		{
			return "游戏币 " + rule.CostAmount;
		}
		return (rule.YuanbaoType == "silver_coin" ? "银元宝 " : "金元宝 ") + rule.CostAmount;
	}

	private static bool Reject(MyNATSocketClient client, string message)
	{
		Tip(client, message);
		return false;
	}

	private static void Tip(MyNATSocketClient client, string message)
	{
		client?.C_Send(Singleton<WdAPI>.I.提示_中心提醒(message));
	}

	private void ReloadConfigIfChangedLocked()
	{
		if (!File.Exists(configPath))
		{
			return;
		}
		DateTime writeUtc = File.GetLastWriteTimeUtc(configPath);
		if (writeUtc != configWriteUtc)
		{
			LoadConfigLocked(createWhenMissing: false);
		}
	}

	private void LoadConfigLocked(bool createWhenMissing)
	{
		if (!File.Exists(configPath))
		{
			config = new TimedDungeonConfig();
			if (createWhenMissing)
			{
				WriteAtomic(configPath, JsonConvert.SerializeObject(config, Formatting.Indented));
				configWriteUtc = File.GetLastWriteTimeUtc(configPath);
			}
			return;
		}
		try
		{
			TimedDungeonConfig loaded = JsonConvert.DeserializeObject<TimedDungeonConfig>(File.ReadAllText(configPath, Encoding.UTF8)) ?? new TimedDungeonConfig();
			ValidateConfig(loaded);
			config = loaded;
			configWriteUtc = File.GetLastWriteTimeUtc(configPath);
		}
		catch (Exception ex)
		{
			configWriteUtc = File.GetLastWriteTimeUtc(configPath);
			Log.Error(ex, "限时副本配置读取失败，继续使用上一份有效配置：{Path}", configPath);
		}
	}

	private void LoadStateLocked()
	{
		if (!File.Exists(statePath))
		{
			state = new TimedDungeonRuntimeState();
			return;
		}
		try
		{
			state = JsonConvert.DeserializeObject<TimedDungeonRuntimeState>(File.ReadAllText(statePath, Encoding.UTF8)) ?? new TimedDungeonRuntimeState();
			state.Normalize();
		}
		catch (Exception ex)
		{
			string corruptPath = statePath + ".corrupt-" + DateTime.Now.ToString("yyyyMMddHHmmss");
			File.Copy(statePath, corruptPath, overwrite: true);
			state = new TimedDungeonRuntimeState();
			Log.Error(ex, "限时副本状态读取失败，损坏文件已保留：{Path}", corruptPath);
		}
	}

	private bool SaveStateLocked()
	{
		try
		{
			WriteAtomic(statePath, JsonConvert.SerializeObject(state, Formatting.Indented));
			return true;
		}
		catch (Exception ex)
		{
			Log.Error(ex, "限时副本状态保存失败：{Path}", statePath);
			return false;
		}
	}

	private static void WriteAtomic(string path, string content)
	{
		string directory = Path.GetDirectoryName(path);
		if (!string.IsNullOrWhiteSpace(directory))
		{
			Directory.CreateDirectory(directory);
		}
		string temp = path + ".tmp";
		File.WriteAllText(temp, content, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		File.Move(temp, path, overwrite: true);
	}

	private static void ValidateConfig(TimedDungeonConfig source)
	{
		source.Rules ??= new List<TimedDungeonRule>();
		if (source.Rules.Count > 100)
		{
			throw new InvalidOperationException("限时副本规则最多100条");
		}
		HashSet<string> ids = new HashSet<string>(StringComparer.Ordinal);
		HashSet<string> commands = new HashSet<string>(StringComparer.Ordinal);
		foreach (TimedDungeonRule rule in source.Rules)
		{
			rule.Normalize();
			if (string.IsNullOrWhiteSpace(rule.ID) || !ids.Add(rule.ID)) throw new InvalidOperationException("规则ID为空或重复");
			if (string.IsNullOrWhiteSpace(rule.Name) || rule.Name.Length > 40) throw new InvalidOperationException("副本名称无效");
			if (rule.EntryNPCName.Length > 40) throw new InvalidOperationException("入口NPC名称过长");
			if (string.IsNullOrWhiteSpace(rule.EntryCommand) || rule.EntryCommand.Length > 80) throw new InvalidOperationException("进入命令无效");
			if (rule.Enabled && !commands.Add(rule.EntryCommand)) throw new InvalidOperationException("启用规则的进入命令不能重复");
			if (rule.TargetMapCode <= 0) throw new InvalidOperationException("目标地图编号必须大于0");
			if (rule.DurationMinutes < 1 || rule.DurationMinutes > 10080) throw new InvalidOperationException("时长范围为1-10080分钟");
			if (rule.DailyLimit < 0 || rule.DailyLimit > 10000) throw new InvalidOperationException("每日次数范围为0-10000");
			if (rule.CostType != "item" && rule.CostType != "cash" && rule.CostType != "yuanbao") throw new InvalidOperationException("费用类型无效");
			if (rule.CostType == "item" && string.IsNullOrWhiteSpace(rule.ItemName)) throw new InvalidOperationException("道具费用必须填写名称");
			if (rule.YuanbaoType != "gold_coin" && rule.YuanbaoType != "silver_coin") throw new InvalidOperationException("元宝类型无效");
			if (rule.CostAmount < 1 || rule.CostAmount > (rule.CostType == "item" ? 999 : 2000000000)) throw new InvalidOperationException("费用数量无效");
			if (rule.ChargeMode != "leader" && rule.ChargeMode != "all") throw new InvalidOperationException("扣费方式无效");
			if (!ExitMapPathPattern.IsMatch(rule.ExitMapPath)) throw new InvalidOperationException("返回地图路径无效");
			if (rule.ExitX < 0 || rule.ExitX > 10000 || rule.ExitY < 0 || rule.ExitY > 10000) throw new InvalidOperationException("返回坐标无效");
		}
	}
}

public sealed class TimedDungeonConfig
{
	public bool Open { get; set; }
	public List<TimedDungeonRule> Rules { get; set; } = new List<TimedDungeonRule>();
}

public sealed class TimedDungeonRule
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

	public void Normalize()
	{
		ID = (ID ?? string.Empty).Trim();
		Name = (Name ?? string.Empty).Trim();
		EntryNPCName = (EntryNPCName ?? string.Empty).Trim();
		EntryCommand = (EntryCommand ?? string.Empty).Trim();
		TargetMapName = (TargetMapName ?? string.Empty).Trim();
		CostType = (CostType ?? string.Empty).Trim().ToLowerInvariant();
		ItemName = (ItemName ?? string.Empty).Trim();
		YuanbaoType = (YuanbaoType ?? string.Empty).Trim().ToLowerInvariant();
		ChargeMode = (ChargeMode ?? string.Empty).Trim().ToLowerInvariant();
		ExitMapName = (ExitMapName ?? string.Empty).Trim();
		ExitMapPath = (ExitMapPath ?? string.Empty).Trim();
	}
}

public sealed class TimedDungeonCharge
{
	public string ID { get; set; } = Guid.NewGuid().ToString("N");
	public string RoleKey { get; set; } = string.Empty;
	public int RoleID { get; set; }
	public string RoleName { get; set; } = string.Empty;
	public string CostType { get; set; } = string.Empty;
	public string Currency { get; set; } = string.Empty;
	public string ItemName { get; set; } = string.Empty;
	public int Amount { get; set; }
}

public sealed class TimedDungeonPendingGroup
{
	public string Token { get; set; } = string.Empty;
	public string RuleID { get; set; } = string.Empty;
	public string RuleName { get; set; } = string.Empty;
	public int TargetMapCode { get; set; }
	public string TargetMapName { get; set; } = string.Empty;
	public int DurationMinutes { get; set; }
	public int DailyLimit { get; set; }
	public string ExitMapName { get; set; } = string.Empty;
	public string ExitMapPath { get; set; } = string.Empty;
	public int ExitX { get; set; }
	public int ExitY { get; set; }
	public string ChargeMode { get; set; } = "leader";
	public List<string> MemberKeys { get; set; } = new List<string>();
	public List<string> EnteredKeys { get; set; } = new List<string>();
	public List<TimedDungeonCharge> Charges { get; set; } = new List<TimedDungeonCharge>();
	public DateTime CreatedUtc { get; set; }
	public DateTime DeadlineUtc { get; set; }
}

public sealed class TimedDungeonSession
{
	public string Token { get; set; } = string.Empty;
	public string RuleID { get; set; } = string.Empty;
	public string RuleName { get; set; } = string.Empty;
	public string RoleKey { get; set; } = string.Empty;
	public int RoleID { get; set; }
	public string RoleName { get; set; } = string.Empty;
	public int TargetMapCode { get; set; }
	public string TargetMapName { get; set; } = string.Empty;
	public DateTime EnteredUtc { get; set; }
	public DateTime ExpiresUtc { get; set; }
	public bool TimedOut { get; set; }
	public DateTime? LastExitRequestUtc { get; set; }
	public string ExitMapName { get; set; } = string.Empty;
	public string ExitMapPath { get; set; } = string.Empty;
	public int ExitX { get; set; }
	public int ExitY { get; set; }
}

public sealed class TimedDungeonRuntimeState
{
	public List<TimedDungeonPendingGroup> PendingGroups { get; set; } = new List<TimedDungeonPendingGroup>();
	public List<TimedDungeonSession> Sessions { get; set; } = new List<TimedDungeonSession>();
	public List<TimedDungeonCharge> PendingRefunds { get; set; } = new List<TimedDungeonCharge>();
	public Dictionary<string, int> DailyCounts { get; set; } = new Dictionary<string, int>();

	public void Normalize()
	{
		PendingGroups ??= new List<TimedDungeonPendingGroup>();
		Sessions ??= new List<TimedDungeonSession>();
		PendingRefunds ??= new List<TimedDungeonCharge>();
		DailyCounts ??= new Dictionary<string, int>();
		foreach (TimedDungeonPendingGroup pending in PendingGroups)
		{
			pending.MemberKeys ??= new List<string>();
			pending.EnteredKeys ??= new List<string>();
			pending.Charges ??= new List<TimedDungeonCharge>();
		}
	}
}
