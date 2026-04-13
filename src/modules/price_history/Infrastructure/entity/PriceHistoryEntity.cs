using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("price_history")]
public sealed class PriceHistoryEntity
{
    public Guid Id { get; set; }
    public Guid? PriceId { get; set; }
    public PriceEntity? Price { get; set; }
    public decimal? OldPrice { get; set; }
    public decimal? NewPrice { get; set; }
    public DateTime ChangedAt { get; set; }
    public string? ReasonChange { get; set; }
}

