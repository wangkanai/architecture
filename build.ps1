dotnet restore -f ./content/Maui/Architecture.Maui.sln
dotnet restore -f ./content/Blazor/Architecture.Blazor.sln

dotnet build --tl ./Wangkanai.Architecture.Templates.csproj
dotnet build --tl ./content/Blazor/Architecture.Blazor.sln
dotnet build --tl ./content/Maui/Architecture.Maui.sln
