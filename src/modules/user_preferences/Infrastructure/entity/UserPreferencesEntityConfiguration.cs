using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class UserPreferenceEntityConfiguration : IEntityTypeConfiguration<UserPreferenceEntity>
{
    public void Configure(EntityTypeBuilder<UserPreferenceEntity> builder)
    {
        builder.ToTable("user_preferences");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Key).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Value).HasColumnType("longtext");
        builder.Property(x => x.UpdatedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.HasOne(x => x.Person)
            .WithMany()
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
