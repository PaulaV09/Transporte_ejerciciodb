using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("city_pricing_rules")]
public sealed class CityPricingRuleEntity
{
    public Guid Id { get; set; }
    public Guid? OriginCityId { get; set; }
    public CityEntity? OriginCity { get; set; }
    public Guid? DestinationCityId { get; set; }
    public CityEntity? DestinationCity { get; set; }
    public decimal? BasePrice { get; set; }
    public string? Currency { get; set; }
    public bool IsActive { get; set; }
}

