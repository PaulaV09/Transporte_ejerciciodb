using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("chat_rooms")]
public sealed class ChatRoomEntity
{
    public Guid Id { get; set; }
    public Guid? ReferenceId { get; set; }
    public string? Name { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
}

