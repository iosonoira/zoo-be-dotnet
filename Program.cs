

using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Repositories;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

// SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Filename=./Data/people.db"));

// Dependency Injection
builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
builder.Services.AddScoped<IAnimalService, AnimalService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

app.MapControllers();

app.Run();

