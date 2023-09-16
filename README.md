# Emma's Website

## Tutorial

[Tutorial: Create a Razor Pages web app with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-7.0)

## Steps

In Windows, Open Powershell. Press Start Button > Type: Powershell > Press Enter

1. `dotnet new webapp -o EmmaWebsite`
2. `dotnet new gitignore`
3. `dotnet dev-certs https --trust`
4. `dotnet tool uninstall --global dotnet-aspnet-codegenerator`
5. `dotnet tool install --global dotnet-aspnet-codegenerator`
6. `dotnet tool uninstall --global dotnet-ef`
7. `dotnet tool install --global dotnet-ef`
8. `dotnet add package Microsoft.EntityFrameworkCore.Design`
9. `dotnet add package Microsoft.EntityFrameworkCore.SQLite`
10. `dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design`
11. `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
12. `dotnet add package Microsoft.EntityFrameworkCore.Tools`
13. `dotnet aspnet-codegenerator razorpage -m Friend -dc RazorPagesMovie.Data.RazorPagesFriendContext -udl -outDir Pages/Friends --referenceScriptLibraries --databaseProvider sqlite`
14. `dotnet ef migrations add InitialCreate`
15. `dotnet ef database update`