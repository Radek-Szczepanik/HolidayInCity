namespace HolidayInCity.Controllers;

[ApiController]
[Route("[controller]")]
public class EventOrganizerController : ControllerBase
{
    private readonly IMediator mediator;

    public EventOrganizerController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllEventOrganizers([FromQuery] GetEventOrganizersRequest request)
    {
        var response = await this.mediator.Send(request);
        return Ok(response);
    }
}
