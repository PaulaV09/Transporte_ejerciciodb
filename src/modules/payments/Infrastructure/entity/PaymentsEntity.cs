using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("payments")]
public sealed class PaymentEntity
{
    public Guid Id { get; set; }
    public Guid? TripId { get; set; }
    public TripEntity? Trip { get; set; }
    public Guid? PaymentProviderId { get; set; }
    public PaymentProviderEntity? PaymentProvider { get; set; }
    public decimal AmountMoney { get; set; }
    public string? Currency { get; set; }
    public string? PaymentStatus { get; set; }
    public DateTime CreatedAt { get; set; }
}

