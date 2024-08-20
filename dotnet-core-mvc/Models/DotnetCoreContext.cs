using Microsoft.EntityFrameworkCore;

namespace dotnet_core_mvc.Models;

public class DotnetCoreContext : DbContext {
    public DotnetCoreContext(DbContextOptions<DotnetCoreContext> options) : base(options) {

    }

    public DbSet<WeatherForecast> WeatherForecast { get; set; } = null!;
    public DbSet<Threater> Threater { get; set; } = null!;
}