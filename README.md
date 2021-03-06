# Learning .NET

Some notes on learning .NET coming from the Ruby On Rails world.

I worked on MacOS with PostgreSQL running in a local Docker container.

| Rails | .NET |
| ----- | ---- |
| Ruby | C# |
| ActiveRecord | Entity Framework Core |
| ERB | Razor Pages |

Helpful tutorials:

* https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio-code
* https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0
* https://docs.microsoft.com/en-us/ef/core/
* https://www.npgsql.org/efcore/
* https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code
* https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-5.0&tabs=netcore-cli

## Setup

```
make up
make setup
dotnet add package Npgsql --version 5.0.1.1
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package EFCore.NamingConventions --version 5.0.0
```

## Local use

```
make run
```
