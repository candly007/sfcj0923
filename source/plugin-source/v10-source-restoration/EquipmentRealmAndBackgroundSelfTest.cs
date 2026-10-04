using System;
using Newtonsoft.Json;
using vBIs2Rf2vSSk1OdhoS7;

internal static class EquipmentRealmAndBackgroundSelfTest
{
	internal static void Run()
	{
		// 元神境界枚举按 AllEnums 定义：凡人=0，练气=1，真仙=10。
		Assert(!CanEquip(AllEnums.元神境界.练气境, AllEnums.元神境界.真仙境), "练气境界不应穿戴真仙境装备");
		Assert(CanEquip(AllEnums.元神境界.真仙境, AllEnums.元神境界.真仙境), "达到真仙境后应允许穿戴真仙境装备");
		Assert(CanEquip(AllEnums.元神境界.练气境, AllEnums.元神境界.凡人境), "凡人境装备不应受元神境界限制");
		物品信息类 trueImmortalItem = new 物品信息类 { 最大耐久度 = 200000 };
		Assert(COyX27f6L3uCF3F6Kp5.ResolveEquipmentRealmRequirement(trueImmortalItem) == AllEnums.元神境界.真仙境,
			"最大耐久度 200000 的装备应解析为真仙境穿戴要求");
		物品信息类 namedTrueImmortalItem = new 物品信息类 { 名字 = "真仙境项链", 最大耐久度 = 1700 };
		Assert(COyX27f6L3uCF3F6Kp5.ResolveEquipmentRealmRequirement(namedTrueImmortalItem) == AllEnums.元神境界.真仙境,
			"名称包含真仙境且使用普通耐久度的装备应解析为真仙境穿戴要求");
		Assert(!CanEquip(AllEnums.元神境界.练气境, COyX27f6L3uCF3F6Kp5.ResolveEquipmentRealmRequirement(trueImmortalItem)),
			"练气境不应穿戴由装备耐久编码解析出的真仙境装备");
		元神系统配置类 config = new 元神系统配置类();
		config.战斗背景列表[AllEnums.元神境界.练气境] = 123;
		元神系统配置类 roundTrip = JsonConvert.DeserializeObject<元神系统配置类>(JsonConvert.SerializeObject(config));
		Assert(roundTrip != null &&
			roundTrip.战斗背景列表.TryGetValue(AllEnums.元神境界.练气境, out int backgroundId) &&
			backgroundId == 123, "元神战斗背景编号 JSON 往返后应保持 123");
		Console.WriteLine("EQUIPMENT_REALM_GATING_SELF_TEST=PASS");
		Console.WriteLine("QI_CANNOT_EQUIP_TRUE_IMMORTAL=PASS");
		Console.WriteLine("TRUE_IMMORTAL_CAN_EQUIP_TRUE_IMMORTAL=PASS");
		Console.WriteLine("MORTAL_EQUIPMENT_UNRESTRICTED=PASS");
		Console.WriteLine("DURABILITY_200000_RESOLVES_TRUE_IMMORTAL=PASS");
		Console.WriteLine("NAME_TRUE_IMMORTAL_WITH_DURABILITY_1700=PASS");
		Console.WriteLine("BATTLE_BACKGROUND_123_JSON_ROUND_TRIP=PASS");
	}

	private static bool CanEquip(AllEnums.元神境界 current, AllEnums.元神境界 requirement)
	{
		return requirement == AllEnums.元神境界.凡人境 || current >= requirement;
	}

	private static void Assert(bool condition, string message)
	{
		if (!condition)
		{
			throw new InvalidOperationException(message);
		}
	}
}
