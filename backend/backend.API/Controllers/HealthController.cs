using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : BaseApiController
{
    [HttpGet]
    public async Task<OkResult> GetHealth()
    {
        return Ok();
    }
}