using System.Threading.Tasks;

internal static class Program
{
    private static async Task Main(string[] args)
    {
        if (args != null && System.Array.Exists(args, x => x == "--effect-identification-self-test"))
        {
            EffectIdentificationProbability.RunSelfTest();
            return;
        }
        if (args != null && System.Array.Exists(args, x => x == "--equipment-background-self-test"))
        {
            EquipmentRealmAndBackgroundSelfTest.Run();
            return;
        }
        if (args != null && System.Array.Exists(args, x => x == "--timed-dungeon-self-test"))
        {
            TimedDungeonService.RunSelfTest();
            return;
        }
        if (args != null && System.Array.Exists(args, x => x == "--trial-card-authorization-self-test"))
        {
            TrialCardAuthorizationSelfTest.Run();
            return;
        }
        if (args != null && System.Array.Exists(args, x => x == "--archive-save-scheduling-self-test"))
        {
            ArchiveSaveSchedulingSelfTest.Run();
            return;
        }
        if (args != null && System.Array.Exists(args, x => x == "--license-bypass-self-test"))
        {
            LicenseBypassSelfTest.Run();
            return;
        }
        if (args != null && System.Array.Exists(args, x => x == "--license-cache-self-test"))
        {
            LicenseClient.RunCacheSelfTest();
            return;
        }
        if (args != null && System.Array.Exists(args, x => x == "--private-delegation-self-test"))
        {
            LicenseClient.RunPrivateDelegationSelfTest();
            return;
        }
        if (args != null && System.Array.Exists(args, x => x == "--packet-boundary-self-test"))
        {
            PacketBoundarySelfTest.Run();
            return;
        }
        await vEAdPGPTkDFOYsbi303.mEdebOPadFyb5ykL5Wy.cGgPVyYtIA(args);
    }
}
