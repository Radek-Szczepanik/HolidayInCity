namespace HolidayInCity.ApplicationServices.Api.Domain.Models;

public class EventOrganizerDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Street { get; set; }
    public string StreetNumber { get; set; }
    public string PostCode { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}
