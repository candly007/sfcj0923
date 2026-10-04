using System.Diagnostics;

/// <summary>
/// High-confidence runtime tamper signals only. Process-name heuristics are
/// intentionally excluded because they create false positives on customer hosts.
/// </summary>
[System.Reflection.Obfuscation(Exclude = false, ApplyToMembers = true)]
internal static class TamperGuard
{
    public static bool TryGetHighConfidenceReason(out string reason)
    {
        if (Debugger.IsAttached)
        {
            reason = "managed_debugger_attached";
            return true;
        }

        if (Debugger.IsLogging())
        {
            reason = "managed_debug_logging_enabled";
            return true;
        }

		if (IntegrityGuard.TryGetHighConfidenceReason(out reason)) return true;

        reason = string.Empty;
        return false;
    }
}
