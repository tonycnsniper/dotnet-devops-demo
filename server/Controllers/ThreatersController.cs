using dotnet_core_mvc.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_core_mvc.Controllers;

[ApiController]
[Route("api/v1/threaters")]
public class ThreatersController : ControllerBase {

    private readonly IThreaterService _threaterService;

    public ThreatersController(IThreaterService threaterService)
    {
        _threaterService = threaterService;
    }

    [HttpGet("all")]
    public async Task<ActionResult<IEnumerable<Threater>>> GetThreaters()
    {
        var threaters = await _threaterService.DisplayAllThreaters();
        return Ok(threaters);
    }
}