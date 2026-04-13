using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class SupportTicketEntityConfiguration : IEntityTypeConfiguration<SupportTicketEntity>
{
    public void Configure(EntityTypeBuilder<SupportTicketEntity> builder)
    {
        builder.ToTable("support_tickets");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Subject).IsRequired().HasMaxLength(255);
        builder.Property(x => x.Description).HasColumnType("longtext");
        builder.Property(x => x.Status).HasMaxLength(20);
        builder.Property(x => x.Priority).HasMaxLength(10);
        builder.Property(x => x.CreatedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.HasOne(x => x.Person)
            .WithMany()
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

