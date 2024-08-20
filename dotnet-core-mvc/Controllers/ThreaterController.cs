using dotnet_core_mvc.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_core_mvc.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ThreaterController : ControllerBase {

    private readonly DotnetCoreContext _context;
    private readonly ILogger<ThreaterController> _logger;

    private static readonly string[] MockedThreaters = new[]
    {
        "Albany Event", "Auckland CBD Event"
    };

    public ThreaterController(ILogger<ThreaterController> logger, DotnetCoreContext context) {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Threater>>> GetThreaters() {
        _logger.LogInformation("Fetching all the threaters from database");

        Threater[] threaters;

        try {
            //threaters = await _context.Threater.ToArrayAsync();
            threaters = generateThreaters();

            if (threaters == null || !threaters.Any()) {
                _logger.LogWarning("No threaters found");
                return NotFound(threaters);
            }
        } catch (Exception ex) {
            _logger.LogError(ex, "An error occurred while fetching threaters.");
            return StatusCode(500, ex.Message);
        }

        _logger.LogInformation("Successfully fetched {0} threaters from database", threaters.Length);
        return Ok(threaters);
    }

    private Threater[] generateThreaters() {
        return MockedThreaters.Select((threater, index) => new Threater {
            Id = (index + 1),
            Name = threater,
            Location = threater
        }).ToArray();
    }
}