using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("countries")]
public sealed class CountryEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? IsoCode { get; set; }
    public string? PhoneCode { get; set; }
}
