using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("discards")]
public sealed class DiscardEntity
{
    public Guid Id { get; set; }
    public Guid? TripId { get; set; }
    public TripEntity? Trip { get; set; }
    public Guid? ReasonId { get; set; }
    public ReasonDiscardEntity? Reason { get; set; }
    public Guid? StatusId { get; set; }
    public DiscardStatusEntity? Status { get; set; }
    public string? Comments { get; set; }
    public DateTime CreatedAt { get; set; }
}
