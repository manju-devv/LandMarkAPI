
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using LandMarkAPI.Repositories;
using LandMarkAPI.Database;
using LandMarkAPI.Handlers;

using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .Enrich.FromLogContext()
    .WriteTo.File("Logs/log-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();


builder.Host.UseSerilog();

builder.Services.AddScoped<DatabaseConnection>();
builder.Services.AddScoped<ILandmarkRepository, LandmarkRepository>();
//builder.Services.AddScoped<UserHandler>();
//builder.Services.AddScoped<MenuBarHandler>();
//builder.Services.AddScoped<HomePageHandler>();
//builder.Services.AddScoped<FeatureHandler>();
//builder.Services.AddScoped<FeatureToolsHandler>();
//builder.Services.AddScoped<PriceHandler>();
//builder.Services.AddScoped<PricePlanHandler>();
//builder.Services.AddScoped<PlanFeaturesHandler>();
//builder.Services.AddScoped<TestimonialHandler>();
//builder.Services.AddScoped<TestimonialRolesHandler>();
//builder.Services.AddScoped<FooterHandler>();
//builder.Services.AddScoped<FooterDetailsHandler>();
//builder.Services.AddScoped<CopyWrightHandler>();

var handlerAssembly = typeof(Program).Assembly;
var handlerTypes = handlerAssembly.GetTypes()
    .Where(t => t.Name.EndsWith("Handler") && t.IsClass && !t.IsAbstract);

foreach (var handlerType in handlerTypes)
{
    Console.WriteLine(handlerType);
    builder.Services.AddScoped(handlerType);
}



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
