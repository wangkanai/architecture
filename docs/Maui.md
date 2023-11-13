# Maui Clean Architecture

## Getting started

Once installed, you can create a new solution using the template.
At this customization is still limited and will be improve in the future.

```powershell
dotnet new clean-maui -n YourSolutionName -o YourOutputDirectory
```

To learn more about what options are available, run `dotnet new clean-maui --help`.
```powershell
dotnet new clean-maui --help
```

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

## Database

The template is configured to use SQL Server by default. To use a different database, you will need to update the following command:

```powershell
dotnet new clean-maui --use-dbproivder <dbproivder>
```

When you run the application the database will be created (if it does not already exist) and the latest migrations will be applied. Running database migrations is very simple. Just add the flags to your command (assume that you are executing from the repository root):

* `--project src\Infrastructure`
* `--startup-project src\Server`
* `--output-dir Data\Migrations`

For example, too add a new migration named `Initial` you would run the following command from the root folder:

```powershell
dotnet ef migrations add "Initial" --project src\Infrastructure --startup-project src\Server --output-dir Data\Migrations
```
