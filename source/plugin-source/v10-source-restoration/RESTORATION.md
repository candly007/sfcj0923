# v10 source restoration

This project is decompiled exclusively from the canonical v10 embedded `ServerCore.dll`:

- Source DLL SHA-256: `DA6247550496251C6B0B5164DF0CD7CDE937CF527AA42EE47CF1AFFB2DA16431`
- Source bundle SHA-256: `49FB8F57F9AEBB16B455C53B15E7B5D53BC184AB0B0D04857DF8DAD6D180E812`
- `ServerCoreLK.dll` SHA-256: `B8672ECD8A1565154BE0D676F149B73B44BFC8651BE6748497F8279DC093675F`

The goal is a fully compilable and maintainable source baseline before later features or fixes are applied.

Current status (2026-08-13):

- `ServerCore`: 182 recovered source files, build passes with 0 errors.
- `ServerCoreLK`: 179 recovered source files in `..\v10-source-restoration-lk`, build passes with 0 errors.
- `ServerCore.csproj` uses a source `ProjectReference` for `ServerCoreLK`; the binary project reference has been removed.
- RPC `10021` and `10023`, permanent expiry, all 31 feature flags, and local-only authorization behavior have been restored from the canonical v10 assemblies.
- Authorization reporting, QQ reporting, remote feature updates, forced shutdown, and disconnect-triggered restart handlers are inert as in the canonical v10 assembly.
- `current-v11-timed-dungeon` is a feature donor only. It is not a release baseline.

Verification:

```powershell
powershell -ExecutionPolicy Bypass -File .\scripts\verify-v10-source-restoration.ps1
```

Recovery rules:

1. Preserve v10 behavior while repairing decompiler output.
2. Resolve ambiguous code against v10 IL by method token and RVA.
3. Do not copy business implementations from the pre-v10 rebuilt branch.
4. Do not add post-v10 features until the clean v10 source build and regression baseline pass.
