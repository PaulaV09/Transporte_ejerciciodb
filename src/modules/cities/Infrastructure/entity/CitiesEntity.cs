using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("cities")]
public sealed class CityEntity
{
    public Guid Id { get; set; }
    public Guid? CountryId { get; set; }
    public CountryEntity? Country { get; set; }
    public string Name { get; set; } = null!;
    public string? StateProvince { get; set; }
}
