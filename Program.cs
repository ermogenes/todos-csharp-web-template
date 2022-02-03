var builder = WebApplication.CreateBuilder(args);

// Swagger
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    // Swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Aplicação Frontend
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/hello", () => "Hello World!");

app.Run();
