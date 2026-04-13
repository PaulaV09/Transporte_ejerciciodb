using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class ChatParticipantEntityConfiguration : IEntityTypeConfiguration<ChatParticipantEntity>
{
    public void Configure(EntityTypeBuilder<ChatParticipantEntity> builder)
    {
        builder.ToTable("chat_participants");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.JoinedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.HasOne(x => x.ChatRoom)
            .WithMany()
            .HasForeignKey(x => x.ChatRoomId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.Person)
            .WithMany()
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

