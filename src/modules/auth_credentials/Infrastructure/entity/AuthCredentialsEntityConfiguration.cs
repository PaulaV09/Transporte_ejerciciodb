using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class AuthCredentialEntityConfiguration : IEntityTypeConfiguration<AuthCredentialEntity>
{
    public void Configure(EntityTypeBuilder<AuthCredentialEntity> builder)
    {
        builder.ToTable("auth_credentials");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(255);
        builder.HasIndex(x => x.Email).IsUnique();
        builder.Property(x => x.PasswordHash).IsRequired().HasColumnType("longtext");
        builder.Property(x => x.LastLogin).HasColumnType("datetime(6)");
        builder.Property(x => x.FailedAttempts).HasDefaultValue(0);
        builder.Property(x => x.IsLocked).HasDefaultValue(false);
        builder.Property(x => x.IsActive).HasDefaultValue(true);
        builder.HasOne(x => x.Person)
            .WithMany()
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
