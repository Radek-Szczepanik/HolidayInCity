namespace HolidayInCity.DataAccess.CQRS.Queries.EventOrganizer;

public class GetEventOrganizersQuery : QueryBase<List<Entities.EventOrganizer>>
{
    public override Task<List<Entities.EventOrganizer>> Execute(HolidayInCityDbContext context)
    {
        return context.EventOrganizers.ToListAsync();
    }
}
