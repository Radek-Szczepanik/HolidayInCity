namespace HolidayInCity.ApplicationServices.Mappings;

public class EventOrganizerProfile : Profile
{
    public EventOrganizerProfile()
    {
        CreateMap<EventOrganizer, EventOrganizerDto>();
    }
}
