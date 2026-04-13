using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("load_images")]
public sealed class LoadImageEntity
{
    public Guid Id { get; set; }
    public Guid? LeadId { get; set; }
    public LeadEntity? Lead { get; set; }
    public string ImageUrl { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime UploadedAt { get; set; }
}

