# Wangkanai Blazor Clean Architecture

[![Build Status](https://dev.azure.com/wangkanai/GitHub/_apis/build/status%2Farchitecture-ai?branchName=refs%2Fpull%2F3%2Fmerge)](https://dev.azure.com/wangkanai/GitHub/_build/latest?definitionId=38&branchName=refs%2Fpull%2F3%2Fmerge)

Blazor Clean Architecture design template build natively for .NET 8 using Blazor Identity UI with Tabler admin portal. This is concept demo of sales pipeline management system to demonstrate how to build a full stack application using Blazor. While its not intended to be a production application, it does show the concepts of how to use Blazor with a clean architecture approach.

The application design architecture is to have everything in there separate project. This allows for the application to be broken down into smaller pieces and allows for easier maintenance and development. The application is broken down into the following projects:

## Src
- *Wangkanai.Architecture.Domain* - The domain layer is the core of the application, containing all the business logic and entities. It has no dependencies on any other layer.
- *Wangkanai.Architecture.Infrastructure* - The infrastructure layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the domain layer.
- *Wangkanai.Architecture.Infrastructure* - The infrastructure layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the domain layer.
- *Wangkanai.Architecture.Client* - The WebAssembly Blazor Client App project.
- *Wangkanai.Architecture* - The main Blazor Server Apps project.

## Tests
- *Wangkanai.Architecture.Domain.UnitTests* - The unit test project for the domain layer.
- *Wangkanai.Architecture.Application.UnitTests* - The unit test project for the application layer.
- *Wangkanai.Architecture.Application.IntegrationTests* - The integration test project for the application layer.
