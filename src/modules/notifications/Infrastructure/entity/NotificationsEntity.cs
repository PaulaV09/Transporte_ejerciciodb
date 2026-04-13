using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("notifications")]
public sealed class NotificationEntity
{
    public Guid Id { get; set; }
    public Guid? PersonId { get; set; }
    public PersonEntity? Person { get; set; }
    public Guid? NotificationTypeId { get; set; }
    public NotificationTypeEntity? NotificationType { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }
    public bool IsSent { get; set; }
    public DateTime? SentAt { get; set; }
    public bool IsOpened { get; set; }
}

