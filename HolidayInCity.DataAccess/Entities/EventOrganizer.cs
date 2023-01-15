namespace HolidayInCity.DataAccess.Entities;

public class EventOrganizer : EntityBase
{
    public string Name { get; set; }

    public virtual List<HolidayEvent> HolidayEvents { get; set; }
    public virtual List<EventOrganizerAddress> EventOrganizerAddresses { get; set; }
    public virtual List<EventOrganizerContact> EventOrganizerContacts { get; set; }
}
