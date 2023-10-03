
using Microsoft.EntityFrameworkCore;
using VicStelmak.DEFDA.BusinessLogic.Models;

namespace VicStelmak.DEFDA.Infrastructure.DataAccess;

public class RentalDbContext : DbContext
{
    public RentalDbContext(DbContextOptions options) : base(options) { }

    public DbSet<LeaseholderModel> Leaseholders { get; set; }
    public DbSet<AddressModel> Addresses { get; set; }
    public DbSet<EmailAddressModel> EmailAddresses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        base.OnModelCreating(builder);

        builder.Entity<LeaseholderModel>(entity =>
        {
            entity.Property(l => l.FirstName).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            entity.Property(l => l.LastName).HasColumnType("varchar").HasMaxLength(30).IsRequired();

            entity.HasMany<AddressModel>(l => l.Addresses)
                .WithOne(a => a.LeaseholderModel)
                .HasForeignKey(a => a.LeaseholderId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasMany<EmailAddressModel>(l => l.EmailAddresses)
                .WithOne(e => e.LeaseholderModel)
                .HasForeignKey(e => e.LeaseholderId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        builder.Entity<AddressModel>(entity =>
        {
            entity.Property(a => a.BuildingNumber).HasColumnType("varchar").HasMaxLength(5).IsRequired(false);
            entity.Property(a => a.Street).HasColumnType("varchar").HasMaxLength(50).IsRequired(false);
            entity.Property(a => a.City).HasColumnType("varchar").HasMaxLength(20).IsRequired(false);
            entity.Property(a => a.Region).HasColumnType("varchar").HasMaxLength(30).IsRequired(false);
            entity.Property(a => a.PostalCode).HasColumnType("varchar").HasMaxLength(10).IsRequired(false);
        });

        builder.Entity<EmailAddressModel>(entity =>
        {
            entity.Property(a => a.EmailAddress).HasColumnType("varchar").HasMaxLength(50).IsRequired(false);
        });
    }
}

