namespace HolidayInCity.ApplicationServices.Api.Handlers.EventOrganizer;

public class GetEventOrganizersHandler : IRequestHandler<GetEventOrganizersRequest, GetEventOrganizersResponse>
{
    private readonly IMapper mapper;
    private readonly IQueryExecutor queryExecutor;

    public GetEventOrganizersHandler(IMapper mapper, IQueryExecutor queryExecutor)
    {
        this.mapper = mapper;
        this.queryExecutor = queryExecutor;
    }
    public async Task<GetEventOrganizersResponse> Handle(GetEventOrganizersRequest request, CancellationToken cancellationToken)
    {
        var query = new GetEventOrganizersQuery();
        var eventOrganizers = await this.queryExecutor.Execute(query);
        var mappedEventOrganizers = this.mapper.Map<List<EventOrganizerDto>>(eventOrganizers);
        var response = new GetEventOrganizersResponse()
        {
            Data = mappedEventOrganizers
        };
        return response;
    }
}
