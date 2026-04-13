using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("audit_log")]
public sealed class AuditLogEntity
{
    public Guid Id { get; set; }
    public Guid? UserId { get; set; }
    public PersonEntity? User { get; set; }
    public string Action { get; set; } = null!;
    public string? TableName { get; set; }
    public Guid? RecordId { get; set; }
    public string? OldValues { get; set; }
    public string? NewValues { get; set; }
    public DateTime CreatedAt { get; set; }
}

