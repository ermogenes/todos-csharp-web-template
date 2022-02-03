# todos-csharp-web-template
Uma aplicação TODO em C# (web) com Minimal APIs, EFCore 6, MySQL e Pomelo

## Banco

https://github.com/ermogenes/todos-mysql

## OpenAPI (Swagger)

Pacote:
```
dotnet add package Swashbuckle.AspNetCore
```

Código:
```
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
...
app.UseSwagger();
app.UseSwaggerUI();
```