using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("app_config")]
public sealed class AppConfigEntity
{
    public Guid Id { get; set; }
    public string ConfigKey { get; set; } = null!;
    public string? ConfigValue { get; set; }
    public string? Description { get; set; }
}

