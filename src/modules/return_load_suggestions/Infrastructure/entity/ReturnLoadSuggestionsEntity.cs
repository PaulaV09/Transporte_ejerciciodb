using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("return_load_suggestions")]
public sealed class ReturnLoadSuggestionEntity
{
    public Guid Id { get; set; }
    public Guid? TripId { get; set; }
    public TripEntity? Trip { get; set; }
    public Guid? LeadId { get; set; }
    public LeadEntity? Lead { get; set; }
    public decimal? MatchScore { get; set; }
    public DateTime CreatedAt { get; set; }
}
