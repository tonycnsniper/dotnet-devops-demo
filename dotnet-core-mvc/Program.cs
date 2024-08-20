using Microsoft.EntityFrameworkCore;
using dotnet_core_mvc.Models;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DotnetCoreContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DotnetCoreContext") 
        ?? throw new InvalidOperationException("Connection string 'DotnetCoreContext' not found.")));

// Add services to the container.
builder.Services.AddControllers();

// Add additional services


// Inject database context
builder.Services.AddDbContext<DotnetCoreContext>(opt => 
    opt.UseInMemoryDatabase("WeatherForecast"));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
