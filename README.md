# Blazor Clean Architecture

[![Build Status](https://dev.azure.com/wangkanai/GitHub/_apis/build/status%2Farchitecture-ai?branchName=refs%2Fpull%2F3%2Fmerge)](https://dev.azure.com/wangkanai/GitHub/_build/latest?definitionId=38&branchName=refs%2Fpull%2F3%2Fmerge)
[![Nuget](https://img.shields.io/nuget/v/Wangkanai.Architecture.Template?label=NuGet)](https://www.nuget.org/packages/Wangkanai.Architecture.Template)
[![Nuget](https://img.shields.io/nuget/dt/Wangkanai.Architecture.Template?label=Downloads)](https://www.nuget.org/packages/Wangkanai.Architecture.Template)

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=wangkanai_architecture&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=wangkanai_architecture)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=wangkanai_architecture&metric=code_smells)](https://sonarcloud.io/summary/new_code?id=wangkanai_architecture)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=wangkanai_architecture&metric=coverage)](https://sonarcloud.io/summary/new_code?id=wangkanai_architecture)

[![Open Collective](https://img.shields.io/badge/open%20collective-support%20me-3385FF.svg)](https://opencollective.com/wangkanai)
[![Patreon](https://img.shields.io/badge/patreon-support%20me-d9643a.svg)](https://www.patreon.com/wangkanai)
[![GitHub](https://img.shields.io/github/license/wangkanai/detection)](https://github.com/wangkanai/Detection/blob/dev/LICENSE)


Blazor Clean Architecture design template build natively for .NET 8 using Blazor Identity UI (added extend functionality) with Tabler admin portal.
This is template is designed to be a starting point for your Blazor application using the principle of domain driven design (DDD). The application design architecture is to have everything in their separate project.
This allows for the application to be broken down into smaller pieces and allows for easier maintenance and development.
The application template utilizes lots of NuGet packages dependencies from [wangkanai](https://github.com/wangkanai/wangkanai). It’s provide extra tools and extensions to help simplify software development and let you focus on what is important to get everything startup and running as soon as possible.

If you find this project useful, please give it a star. Thanks! ⭐

## Getting Start

The easily way to get started using this template is install the following template below:

```powershell
dotnet new install wangkanai.architecture.template
```

Once installed, you can create a new solution using the template. At this customization is still limited and will be improve in the future.

```powershell
dotnet new blazor-clean -n YourSolutionName -o YourOutputDirectory
```

Launch the app:
```powershell
cd src\Server
dotnet watch
```

To learn more about what options are available, run `dotnet new blazor-clean --help`.
```powershell
dotnet new blazor-clean --help
```

## Database

The template is configured to use SQL Server by default. To use a different database, you will need to update the following command:

```powershell
dotnet new blazor-clean --use-dbproivder <dbproivder>
```

When you run the application the database will be created (if it does not already exist) and the latest migrations will be applied. Running database migrations is very simple. Just add the flags to your command (assume that you are executing from the repository root):

* `--project src\Infrastructure`
* `--startup-project src\Server`
* `--output-dir Data\Migrations`

For example, too add a new migration named `Initial` you would run the following command from the root folder:

```powershell
dotnet ef migrations add "Initial" --project src\Infrastructure --startup-project src\Server --output-dir Data\Migrations
```

## Support

If you need any help, please let me know by opening a new [GitHub issue](https://github.com/wangkanai/architecture/issues/new).

## License

This project is licensed with the [Apache-2.0 license](LICENSE).
