namespace HolidayInCity.DataAccess.Entities.Configurations;

public class EventOrganizerConfiguration : IEntityTypeConfiguration<EventOrganizer>
{
    public void Configure(EntityTypeBuilder<EventOrganizer> builder)
    {
        builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(100);


        builder.HasMany(x => x.HolidayEvents)
               .WithOne(y => y.EventOrganizer)
               .HasForeignKey(z => z.EventOrganizerId);

        builder.HasMany(x => x.EventOrganizerAddresses)
               .WithOne(y => y.EventOrganizer)
               .HasForeignKey(z => z.EventOrganizerId);

        builder.HasMany(x => x.EventOrganizerContacts)
               .WithOne(y => y.EventOrganizer)
               .HasForeignKey(z => z.EventOrganizerId);
    }
}
