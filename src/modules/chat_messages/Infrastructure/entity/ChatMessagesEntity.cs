using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("chat_messages")]
public sealed class ChatMessageEntity
{
    public Guid Id { get; set; }
    public Guid? ChatRoomId { get; set; }
    public ChatRoomEntity? ChatRoom { get; set; }
    public Guid? SenderId { get; set; }
    public PersonEntity? Sender { get; set; }
    public Guid? MessageTypeId { get; set; }
    public MessageTypeEntity? MessageType { get; set; }
    public string? Content { get; set; }
    public bool IsRead { get; set; }
    public DateTime CreatedAt { get; set; }
}
