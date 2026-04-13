using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("type_document")]
public sealed class TypeDocumentEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public Guid? CategoryId { get; set; }
    public DocumentCategoryEntity? Category { get; set; }
}
