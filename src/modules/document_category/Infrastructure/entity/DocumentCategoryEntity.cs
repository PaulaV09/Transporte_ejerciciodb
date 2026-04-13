using System.ComponentModel.DataAnnotations.Schema;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("document_category")]
public sealed class DocumentCategoryEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
}
