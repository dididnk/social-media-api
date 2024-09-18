# Cr�er un projet .Net

- dotnet new classlib -o CQRS.Core
- dotnet new sln
- dotnet new webapi -o Post.Cmd.Api
- dotnet classlib -o Post.Cmd.Domain
- dotnet classlib -o Post.Cmd.Infrastructure

## Combiner les deux dossiers dans la solution

- dotnet sln add ..\CQRS-ES\CQRS.Core\CQRS.Core.csproj

- dotnet sln add .\Post.Cmd\Post.Cmd.Api\Post.Cmd.Api.csproj
- dotnet sln add .\Post.Cmd\Post.Cmd.Domain\Post.Cmd.Domain.csproj
- dotnet sln add .\Post.Cmd\Post.Cmd.Api\Post.Cmd.Api.csproj
- dotnet sln add .\Post.Query\Post.Query.Api\Post.Query.Api.csproj
- dotnet sln add .\Post.Query\Post.Query.Domain\Post.Query.Domain.csproj
- dotnet sln add .\Post.Query\Post.Query.Api\Post.Query.Api.csproj

## Ajout des r�f�rences pour chaque projets

- dotnet add .\Post.Cmd\Post.Cmd.Api\Post.Cmd.Api.csproj reference ..\CQRS-ES\CQRS.Core\CQRS.Core.csproj
- dotnet add .\Post.Cmd\Post.Cmd.Api\Post.Cmd.Api.csproj reference .\Post.Cmd\Post.Cmd.Domain\Post.Cmd.Domain.csproj
- dotnet add .\Post.Cmd\Post.Cmd.Api\Post.Cmd.Api.csproj reference .\Post.Cmd\Post.Cmd.Infrastructure\Post.Cmd.Infrastructure.csproj
- dotnet add .\Post.Cmd\Post.Cmd.Api\Post.Cmd.Api.csproj reference .\Post.Common\Post.Common.csproj

- dotnet add .\Post.Cmd\Post.Cmd.Domain\Post.Cmd.Domain.csproj reference ..\CQRS-ES\CQRS.Core\CQRS.Core.csproj
- dotnet add .\Post.Cmd\Post.Cmd.Domain\Post.Cmd.Domain.csproj reference .\Post.Common\Post.Common.csproj

- dotnet add .\Post.Cmd\Post.Cmd.Infrastructure\Post.Cmd.Infrastructure.csproj reference ..\CQRS-ES\CQRS.Core\CQRS.Core.csproj
- dotnet add .\Post.Cmd\Post.Cmd.Infrastructure\Post.Cmd.Infrastructure.csproj reference .\Post.Cmd\Post.Cmd.Domain\Post.Cmd.Domain.csproj

- dotnet add .\Post.Common\Post.Common.csproj reference ..\CQRS-ES\CQRS.Core\CQRS.Core.csproj
- dotnet add .\Post.Query\Post.Query.Api\Post.Query.Api.csproj reference ..\CQRS-ES\CQRS.Core\CQRS.Core.csproj
- dotnet add .\Post.Query\Post.Query.Api\Post.Query.Api.csproj reference .\Post.Query\Post.Query.Infrastructure\Post.Query.Infrastructure.csproj
- dotnet add .\Post.Query\Post.Query.Api\Post.Query.Api.csproj reference .\Post.Common\Post.Common.csproj

- dotnet add .\Post.Query\Post.Query.Domain\Post.Query.Domain.csproj reference ..\CQRS-ES\CQRS.Core\CQRS.Core.csproj
- dotnet add .\Post.Query\Post.Query.Domain\Post.Query.Domain.csproj reference .\Post.Common\Post.Common.csproj

- dotnet add .\Post.Query\Post.Query.Infrastructure\Post.Query.Infrastructure.csproj reference ..\CQRS-ES\CQRS.Core\CQRS.Core.csproj
- dotnet add .\Post.Query\Post.Query.Infrastructure\Post.Query.Infrastructure.csproj reference .\Post.Cmd\Post.Cmd.Domain\Post.Cmd.Domain.csproj

