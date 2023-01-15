namespace HolidayInCity.DataAccess;

public class HolidayInCityDbContext : DbContext
{
    public HolidayInCityDbContext(DbContextOptions<HolidayInCityDbContext> options) : base(options)
    {
    }

    public DbSet<EventOrganizer> EventOrganizers { get; set; }
    public DbSet<EventOrganizerAddress> EventOrganizerAddresses { get; set; }
    public DbSet<EventOrganizerContact> EventOrganizerContacts { get; set; }
    public DbSet<HolidayEvent> HolidayEvents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HolidayEventConfiguration).Assembly);
    }
}
