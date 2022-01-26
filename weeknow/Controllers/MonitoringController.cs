using Microsoft.AspNetCore.Mvc;

namespace weeknow.Controllers;

[ApiController]
[Route("manage")]
public class MonitoringController : ControllerBase
{
    private readonly ILogger<MonitoringController> _logger;

    public MonitoringController(ILogger<MonitoringController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("health")]
    [ProducesResponseType(200)]
    public async Task<IActionResult> Health()
    {
        return Ok();
    }
}