using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class DriverEntityConfiguration : IEntityTypeConfiguration<DriverEntity>
{
    public void Configure(EntityTypeBuilder<DriverEntity> builder)
    {
        builder.ToTable("drivers");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.LicenseNumber).IsRequired().HasMaxLength(50);
        builder.Property(x => x.LicenseCategory).HasMaxLength(10);
        builder.Property(x => x.ExperienceYears);
        builder.Property(x => x.IsVerified).HasDefaultValue(false);
        builder.Property(x => x.VerifiedAt).HasColumnType("datetime(6)");
        builder.HasOne(x => x.Person)
            .WithMany()
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
