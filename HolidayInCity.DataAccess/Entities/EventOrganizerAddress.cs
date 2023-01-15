namespace HolidayInCity.DataAccess.Entities;

public class EventOrganizerAddress : EntityBase
{
    public string Street { get; set; }
    public string StreetNumber { get; set; }
    public string PostCode { get; set; }
    public string City { get; set; }

    public int EventOrganizerId { get; set; }
    public virtual EventOrganizer EventOrganizer { get; set; }
}
