remove-item -path .\signed\*.*
remove-item -path .\artifacts\*.*

new-item -Path artifacts -ItemType Directory -Force
new-item -Path signed    -ItemType Directory -Force

# nuget pack .\Architecture.nuspec -OutputDirectory .\artifacts
dotnet pack Wangkanai.Architecture.Templates.csproj -c Release -o .\artifacts
dotnet nuget sign .\artifacts\*.nupkg -v diag --timestamper http://timestamp.digicert.com --certificate-subject-name "Sarin Na Wangkanai" -o .\signed
dotnet nuget push .\signed\*.nupkg -k $env:NUGET_API_KEY  -s https://api.nuget.org/v3/index.json --skip-duplicate

remove-item -path .\bin -recurse -force
remove-item -path .\obj -recurse -force
remove-item -path .\artifacts\*.*

version.ps1
