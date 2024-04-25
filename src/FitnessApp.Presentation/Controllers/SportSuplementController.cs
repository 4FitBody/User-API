namespace FitnessApp.Presentation.Controllers;

using FitnessApp.Infrastructure.SportSupplements.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]/[action]")]
public class SportSupplementController : ControllerBase
{
    private readonly ISender sender;

    public SportSupplementController(ISender sender)
    {
        this.sender = sender;
    }

    [HttpGet]
    [ActionName("Index")]
    public async Task<IActionResult> GetAll()
    {
        var getAllQuery = new GetAllQuery();

        var suplements = await this.sender.Send(getAllQuery);

        return base.Ok(suplements);
    }

    [HttpGet]
    [Route("/api/[controller]/[action]/{id}")]
    public async Task<IActionResult> Details(int? id)
    {
        var getByIdQuery = new GetByIdQuery(id);

        var suplement = await this.sender.Send(getByIdQuery);

        return base.Ok(suplement);
    }
}
