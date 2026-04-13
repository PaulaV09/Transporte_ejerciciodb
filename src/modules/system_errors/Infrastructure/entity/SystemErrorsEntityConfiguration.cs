using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class SystemErrorEntityConfiguration : IEntityTypeConfiguration<SystemErrorEntity>
{
    public void Configure(EntityTypeBuilder<SystemErrorEntity> builder)
    {
        builder.ToTable("system_errors");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ErrorCode).HasMaxLength(20);
        builder.Property(x => x.Message).HasColumnType("longtext");
        builder.Property(x => x.StackTrace).HasColumnType("longtext");
        builder.Property(x => x.OccurrenceTime).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
