using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("blacklist")]
public sealed class BlacklistEntity
{
    public Guid Id { get; set; }
    public Guid? ReferenceId { get; set; }
    public string? Type { get; set; }
    public string? Reason { get; set; }
    public DateTime BannedAt { get; set; }
}
