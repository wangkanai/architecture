remove-item -path .\packed\*.*
remove-item -path .\artifacts\*.*
new-item -Path packed -ItemType Directory -Force

nuget pack .\Architecture.nuspec -OutputDirectory .\artifacts

dotnet nuget sign .\artifacts\*.nupkg -v diag --timestamper http://timestamp.digicert.com --certificate-subject-name "Sarin Na Wangkanai" -o .\packed

dotnet nuget push .\packed\*.nupkg -k $env:NUGET_API_KEY  -s https://api.nuget.org/v3/index.json --skip-duplicate
