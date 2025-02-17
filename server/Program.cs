using Microsoft.EntityFrameworkCore;
using dotnet_core_mvc.Models;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DotnetCoreContext>(opt => 
    opt.UseNpgsql(builder.Configuration.GetConnectionString("postgresdb")));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IThreaterService, ThreaterService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowLocalhost3000",
            builder => builder.WithOrigins("http://localhost:3000")
                              .AllowAnyMethod()
                              .AllowAnyHeader());
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("AllowLocalhost3000");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
