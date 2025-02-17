
using dotnet_core_mvc.Models;
using Microsoft.EntityFrameworkCore;

public class ThreaterService : IThreaterService
{
    private readonly DotnetCoreContext _context;
    private readonly ILogger<ThreaterService> _logger;

    public ThreaterService(ILogger<ThreaterService> logger, DotnetCoreContext context) {
        _logger = logger;
        _context = context;
    }

    public void AddThreater(Threater threater)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Threater>> DisplayAllThreaters()
    {
        _logger.LogInformation("Fetching all the threaters from database");

        Threater[] threaters = [];
        try {
            threaters = await _context.Threater.ToArrayAsync();

            if (threaters == null || !threaters.Any()) {
                _logger.LogWarning("No threaters found");
            }
        } catch (Exception ex) {
            _logger.LogError(ex, "An error occurred while fetching threaters.");
        }
        return threaters;
    }

    public Threater GetThreaterById(int id)
    {
        throw new NotImplementedException();
    }

    public void RemoveThreater(int id)
    {
        throw new NotImplementedException();
    }
}