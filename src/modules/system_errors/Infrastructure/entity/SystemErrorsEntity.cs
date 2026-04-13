using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("system_errors")]
public sealed class SystemErrorEntity
{
    public Guid Id { get; set; }
    public string? ErrorCode { get; set; }
    public string? Message { get; set; }
    public string? StackTrace { get; set; }
    public DateTime OccurrenceTime { get; set; }
    public Guid? UserId { get; set; }
    public PersonEntity? User { get; set; }
}
