# Exam Project

## Application URLs:
- Identity: https://localhost:5001
- Exam API: https://localhost:5002
- Exam Admin: https://localhost:6001
- Exam Portal: https://localhost:6002

## Docker Command Examples
- docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Admin@123$' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest

- docker ps or docker container ls

- docker run -d --name mongodb -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD=Admin@123$ -p 127.0.0.1:27017:27017 mongo

- Clone Quick Start UI: curl -L https://raw.githubusercontent.com/IdentityServer/IdentityServer4.Quickstart.UI/main/getmain.sh | bash
iex ((New-Object System.Net.WebClient).DownloadString('https://raw.githubusercontent.com/IdentityServer/IdentityServer4.Quickstart.UI/main/getmain.ps1'))

## Packages References
- https://github.com/serilog/serilog/wiki/Getting-Started
- https://github.com/IdentityServer/IdentityServer4.Quickstart.UI
References URLS
- https://samwalpole.com/using-scoped-services-inside-singletons

- https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0

## secrets.json file in Examination.Api: 
{
    "DatabaseSettings": {
      "Server": "localhost:27017",
      "DatabaseName": "Exam",
      "User": "admin",
      "Password": "Admin%40123%24"
    },
    "IdentityUrl": "https://localhost:5001",
    "Logging": {
      "LogLevel": {
        "Default": "Information",
        "Microsoft": "Warning",
        "Microsoft.Hosting.Lifetime": "Information"
      }
    },
    "AllowedHosts": "*"
  }

## secrets.json file in Identiy.Api: 
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=Identity;User Id = sa;Password = Admin@123$;"
  },

  "ExamWebAppClient": "https://localhost:6002",
  "ExamWebAdminClient": "https://localhost:6001",
  "ExamWebApiClient": "https://localhost:5002"
}

## secrets.json file in Identity.STS.Identity:
{
    "ConnectionStrings": {
        "ConfigurationDbConnection": "Server=.;Database=Identity;User Id=sa;Password=Admin@123$",
        "PersistedGrantDbConnection": "Server=.;Database=Identity;User Id=sa;Password=Admin@123$",
        "IdentityDbConnection": "Server=.;Database=Identity;User Id=sa;Password=Admin@123$",
        "DataProtectionDbConnection": "Server=.;Database=Identity;User Id=sa;Password=Admin@123$"
      },
      "AdminConfiguration": {
        "IdentityAdminBaseUrl": "https://localhost:6003" 
    }
}

## secrets.json file in Identity.Admin:
{
    "ConnectionStrings": {
        "ConfigurationDbConnection": "Server=.;Database=Identity;User Id=sa;Password=Admin@123$",
        "PersistedGrantDbConnection": "Server=.;Database=Identity;User Id=sa;Password=Admin@123$",
        "IdentityDbConnection": "Server=.;Database=Identity;User Id=sa;Password=Admin@123$",
        "AdminLogDbConnection": "Server=.;Database=Identity;User Id=sa;Password=Admin@123$",
        "AdminAuditLogDbConnection": "Server=.;Database=Identity;User Id=sa;Password=Admin@123$",
        "DataProtectionDbConnection": "Server=.;Database=Identity;User Id=sa;Password=Admin@123$"
      },
      "AdminConfiguration": {
        "IdentityAdminRedirectUri": "https://localhost:6003/signin-oidc",
        "IdentityServerBaseUrl": "https://localhost:5001"
      }
}