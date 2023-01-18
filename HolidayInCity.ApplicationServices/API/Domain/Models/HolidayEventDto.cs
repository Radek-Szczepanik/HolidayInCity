﻿namespace HolidayInCity.ApplicationServices.Api.Domain.Models;

public class HolidayEventDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
