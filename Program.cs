
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using LandMarkAPI.Repositories;
using LandMarkAPI.Database;


var builder = WebApplication.CreateBuilder(args);




builder.Services.AddScoped<DatabaseConnection>();
builder.Services.AddScoped<IRepository, Repository>();




builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();
app.UseCors();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
