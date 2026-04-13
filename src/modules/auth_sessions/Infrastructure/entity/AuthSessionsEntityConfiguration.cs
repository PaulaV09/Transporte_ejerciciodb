using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class AuthSessionEntityConfiguration : IEntityTypeConfiguration<AuthSessionEntity>
{
    public void Configure(EntityTypeBuilder<AuthSessionEntity> builder)
    {
        builder.ToTable("auth_sessions");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RefreshToken).IsRequired().HasColumnType("longtext");
        builder.Property(x => x.ExpiresAt).IsRequired().HasColumnType("datetime(6)");
        builder.Property(x => x.CreatedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.Property(x => x.DeviceInfo).HasMaxLength(255);
        builder.Property(x => x.IpAddress).HasMaxLength(45);
        builder.HasOne(x => x.Person)
            .WithMany()
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
