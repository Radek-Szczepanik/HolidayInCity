namespace HolidayInCity.DataAccess;

public class HolidayInCityDbContextFactory : IDesignTimeDbContextFactory<HolidayInCityDbContext>
{
    public HolidayInCityDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<HolidayInCityDbContext>();
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-6607MV5\\SQLEXPRESS;Initial Catalog=HolidayInCity;Integrated Security=True");
        return new HolidayInCityDbContext(optionsBuilder.Options);
    }
}
