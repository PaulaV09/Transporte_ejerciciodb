using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("trip_states_history")]
public sealed class TripStatesHistoryEntity
{
    public Guid Id { get; set; }
    public Guid? TripId { get; set; }
    public TripEntity? Trip { get; set; }
    public string? StatusName { get; set; }
    public Point? LocationPoint { get; set; }
    public DateTime CreatedAt { get; set; }
}

