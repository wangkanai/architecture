# Maui Clean Architecture

The project was generated using the [Wangkanai.Architecture.Templates](https://github.com/wangkanai/architecture)

## Build

Run `dotnet build -tl` to build the solution.

## Run

Launch the server app:
```powershell
cd src\Server
dotnet watch
```

Navigate to https://localhost:9000. The application will automatically reload if you change any of the source files.

Launch the mobile app:
```powershell
cd src\Mobile
dotnet watch
```

## Code Styles & Formatting

The template includes [EditorConfig](https://editorconfig.org/) support to help maintain consistent
coding styles for multiple developers working on the same project across various editors and IDEs.
The **.editorconfig** file defines the coding styles applicable to this solution.

The solution contains unit, integration, functional, and acceptance tests.

To run the unit, integration, and functional tests (excluding acceptance tests):
```powershell
dotnet test --filter "FullyQualifiedName!~AcceptanceTests"
```

To run the acceptance tests, first start the application:
```powershell
cd .\src\Server\
dotnet run
```

Then, in a new console, run the tests:
```powershell
cd .\src\Server\
dotnet test
```

## Help

To learn more about the template go to the [project website](https://github.com/wangkanai/architecture).
Here you can find additional guidance, request new features, report a bug, and discuss the template with other users.