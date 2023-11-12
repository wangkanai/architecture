remove-item -Path demo\ -Recurse -Force
dotnet new install .\ --force
dotnet new clean-blazor -n BlazorApp -o demo\BlazorApp
dotnet new clean-maui   -n MauiApp   -o demo\MauiApp
