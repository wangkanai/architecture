param(
	[Parameter(mandatory = $false)]
	[switch]$dryRun = $false
)

remove-item -path .\signed\*.*    -Force
remove-item -path .\artifacts\*.* -Force

new-item -Path artifacts -ItemType Directory -Force | out-null
new-item -Path signed    -ItemType Directory -Force | out-null

dotnet build  Wangkanai.Architecture.Templates.csproj -c Release
dotnet pack   Wangkanai.Architecture.Templates.csproj -c Release -o .\artifacts
dotnet nuget sign .\artifacts\*.nupkg -v diag --timestamper http://timestamp.digicert.com --certificate-subject-name "Sarin Na Wangkanai" -o .\signed
remove-item -path .\artifacts\*.*

if ($dryRun)
{
	write-host "Dry run is successful" -ForegroundColor Green
	exit
}

dotnet nuget push .\signed\*.nupkg -k $env:NUGET_API_KEY  -s https://api.nuget.org/v3/index.json --skip-duplicate
.\version.ps1
