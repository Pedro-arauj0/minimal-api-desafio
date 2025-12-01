# Minimal API - Desafio DIO

API desenvolvida com ASP.NET Core Minimal APIs e Entity Framework Core.

## Tecnologias
- .NET 9.0
- Entity Framework Core (InMemory)
- Swagger/OpenAPI

## Como executar
```bash
dotnet restore
dotnet run
```

Acesse: http://localhost:5246/swagger

## Endpoints

### Administradores
- `GET /administradores` - Lista todos os administradores
- `POST /administradores` - Cria um novo administrador