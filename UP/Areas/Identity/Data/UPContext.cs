using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UP.Areas.Identity.Data;
using UP.Models;

namespace UP.Data;

public class UPContext : IdentityDbContext<UPUser>
{
    public UPContext(DbContextOptions<UPContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

    }
    public DbSet<Admin> Admin { get; set; }
    public DbSet<Job> Job { get; set; }
    public DbSet<Training> Training { get; set; }

    public DbSet<Training> Location { get; set; }
    public DbSet<Training> Category { get; set; }
    public DbSet<Training> TrainingLevels { get; set; }
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<UPUser>
{
    void IEntityTypeConfiguration<UPUser>.Configure(EntityTypeBuilder<UPUser> builder)
    {
        builder.Property(u => u.Firstname).HasMaxLength(50);
        builder.Property(u => u.Lastname).HasMaxLength(50);
        builder.Property(u => u.Middlename).HasMaxLength(50);
        builder.Property(u => u.Title).HasMaxLength(50);
        builder.Property(u => u.Gender).HasMaxLength(50);
        builder.Property(u => u.Address).HasMaxLength(50);
        builder.Property(u => u.Usern).HasMaxLength(50);
        builder.Property(u => u.ProfilePicture).HasMaxLength(50);
        builder.Property(u => u.Role).HasMaxLength(50);
    }
}
