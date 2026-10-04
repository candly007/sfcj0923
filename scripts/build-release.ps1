[CmdletBinding()]
param(
    [string]$OutputRoot = (Join-Path $PSScriptRoot '..\out'),
    [switch]$SkipObfuscation
)

$ErrorActionPreference = 'Stop'
$root = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
$stamp = Get-Date -Format 'yyyyMMdd-HHmmss'
$out = Join-Path $OutputRoot $stamp
$intermediate = Join-Path $out 'intermediate'
New-Item -ItemType Directory -Force -Path $out, $intermediate | Out-Null

function Invoke-DotnetPublish([string]$Project, [string]$Rid, [string]$Destination, [string[]]$Extra = @()) {
    & dotnet publish $Project -c Release -r $Rid --self-contained true `
        '-p:PublishSingleFile=true' '-p:IncludeNativeLibrariesForSelfExtract=true' `
        "-p:ExternalBuildRoot=$intermediate" '-o' $Destination @Extra --nologo
    if ($LASTEXITCODE -ne 0) { throw "Publish failed: $Project" }
}

$plugin = Join-Path $root 'source\plugin-source\v10-source-restoration\ServerCore.csproj'
$adminProjects = @(Get-ChildItem -LiteralPath (Join-Path $root 'source\admin-source\current') -Filter '*.csproj' -File)
if ($adminProjects.Count -ne 1) { throw 'Expected exactly one admin project file.' }
$admin = $adminProjects[0].FullName
$adminAssemblyName = [System.IO.Path]::GetFileNameWithoutExtension($admin)
$license = Join-Path $root 'source\license-service\LicenseService.csproj'
$private = Join-Path $root 'source\private-license-service\PrivateLicenseService.csproj'

if (-not $SkipObfuscation) {
    $obfuscar = Get-Command obfuscar.console.exe -ErrorAction SilentlyContinue
    if (-not $obfuscar) { throw 'Obfuscar is required for protected builds. Install the Obfuscar .NET global tool or rerun with -SkipObfuscation.' }

    $pluginPlain = Join-Path $out 'plugin-plain'
    $pluginProtected = Join-Path $out 'plugin-protected'
    & dotnet publish $plugin -c Release -r linux-x64 --self-contained true '-p:PublishSingleFile=false' "-p:ExternalBuildRoot=$intermediate" '-o' $pluginPlain --nologo
    if ($LASTEXITCODE -ne 0) { throw 'Plain plugin publish failed.' }
    $pluginXml = Join-Path $out 'plugin-obfuscar.xml'
    @"
<Obfuscator>
  <Var name="InPath" value="$pluginPlain" />
  <Var name="OutPath" value="$pluginProtected" />
  <Var name="KeepPublicApi" value="true" />
  <Var name="HidePrivateApi" value="true" />
  <Var name="RenameTypes" value="true" />
  <Var name="RenameMethods" value="true" />
  <Var name="RenameFields" value="true" />
  <Var name="RenameProperties" value="false" />
  <Var name="RenameEvents" value="false" />
  <Var name="ReuseNames" value="false" />
  <Var name="UseUnicodeNames" value="false" />
  <Module file="$pluginPlain\ServerCore.dll" />
  <Module file="$pluginPlain\ServerCoreLK.dll" />
</Obfuscator>
"@ | Set-Content -LiteralPath $pluginXml -Encoding utf8
    & $obfuscar.Source $pluginXml
    if ($LASTEXITCODE -ne 0) { throw 'Plugin obfuscation failed.' }
    Invoke-DotnetPublish $plugin 'linux-x64' (Join-Path $out 'plugin-linux-x64') @("-p:ProtectedServerCoreDll=$pluginProtected\ServerCore.dll", "-p:ProtectedServerCoreLKDll=$pluginProtected\ServerCoreLK.dll")

    $adminPlain = Join-Path $out 'admin-plain'
    $adminProtected = Join-Path $out 'admin-protected'
    & dotnet publish $admin -c Release -r win-x64 --self-contained true '-p:PublishSingleFile=false' "-p:ExternalBuildRoot=$intermediate" '-o' $adminPlain --nologo
    if ($LASTEXITCODE -ne 0) { throw 'Plain admin publish failed.' }
    $adminXml = Join-Path $out 'admin-obfuscar.xml'
    @"
<Obfuscator>
  <Var name="InPath" value="$adminPlain" />
  <Var name="OutPath" value="$adminProtected" />
  <Var name="KeepPublicApi" value="true" />
  <Var name="HidePrivateApi" value="true" />
  <Var name="RenameTypes" value="true" />
  <Var name="RenameMethods" value="true" />
  <Var name="RenameFields" value="true" />
  <Var name="RenameProperties" value="false" />
  <Var name="RenameEvents" value="false" />
  <Var name="ReuseNames" value="false" />
  <Var name="UseUnicodeNames" value="false" />
  <Module file="$adminPlain\$adminAssemblyName.dll" />
</Obfuscator>
"@ | Set-Content -LiteralPath $adminXml -Encoding utf8
    & $obfuscar.Source $adminXml
    if ($LASTEXITCODE -ne 0) { throw 'Admin obfuscation failed.' }
    Invoke-DotnetPublish $admin 'win-x64' (Join-Path $out 'admin-win-x64') @("-p:ProtectedAdminDll=$adminProtected\$adminAssemblyName.dll")
}
else {
    Invoke-DotnetPublish $plugin 'linux-x64' (Join-Path $out 'plugin-linux-x64')
    Invoke-DotnetPublish $admin 'win-x64' (Join-Path $out 'admin-win-x64')
}

Invoke-DotnetPublish $license 'linux-x64' (Join-Path $out 'license-core-linux-x64')
Invoke-DotnetPublish $private 'linux-x64' (Join-Path $out 'private-license-linux-x64')

Get-ChildItem -LiteralPath $out -Recurse -File | Get-FileHash -Algorithm SHA256 |
    ForEach-Object { "{0}  {1}" -f $_.Hash.ToLowerInvariant(), $_.Path.Substring($out.Length + 1) } |
    Set-Content -LiteralPath (Join-Path $out 'SHA256SUMS.txt') -Encoding ascii

Write-Host "Build complete: $out"
