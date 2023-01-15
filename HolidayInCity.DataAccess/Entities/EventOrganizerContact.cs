namespace HolidayInCity.DataAccess.Entities;

public class EventOrganizerContact : EntityBase
{
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public int EventOrganizerId { get; set; }
    public virtual EventOrganizer EventOrganizer { get; set; }
}
