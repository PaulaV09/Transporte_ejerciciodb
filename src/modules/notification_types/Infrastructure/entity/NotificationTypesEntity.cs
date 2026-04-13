using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("notification_types")]
public sealed class NotificationTypeEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Template { get; set; }
}

