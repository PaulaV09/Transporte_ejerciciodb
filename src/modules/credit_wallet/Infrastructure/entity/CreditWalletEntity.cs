using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("credit_wallet")]
public sealed class CreditWalletEntity
{
    public Guid Id { get; set; }
    public Guid? PersonId { get; set; }
    public PersonEntity? Person { get; set; }
    public decimal Balance { get; set; }
    public DateTime LastUpdate { get; set; }
}

