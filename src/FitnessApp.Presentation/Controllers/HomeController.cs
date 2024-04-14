namespace FitnessApp.Presentation.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

[ApiController]
[Route("api/[controller]/[action]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return base.Ok();
    }

    [HttpGet]
    public IActionResult AboutUs()
    {
        return base.Ok();
    }
}
