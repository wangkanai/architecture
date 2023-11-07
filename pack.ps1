remove-item -path .\packed\*.*
new-item -Path packed -ItemType Directory -Force

Remove-Item .\artifacts\*.*

#dotnet pack .\src\ -c Release -o .\artifacts --include-symbols -p:SymbolPackageFormat=snupkg
nuget pack .\Architecture.nuspec -OutputDirectory .\artifacts

dotnet nuget sign .\artifacts\*.nupkg -v diag --timestamper http://timestamp.digicert.com --certificate-subject-name "Sarin Na Wangkanai" -o .\packed

#dotnet nuget push .\packed\*.nupkg -k $env:NUGET_API_KEY  -s https://api.nuget.org/v3/index.json --skip-duplicate
