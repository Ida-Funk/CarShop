using CarShop.Domain;
using CarShop.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICarReporitory, CarRepository>();
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();
app.UseCors();
app.MapControllers();
app.Run();