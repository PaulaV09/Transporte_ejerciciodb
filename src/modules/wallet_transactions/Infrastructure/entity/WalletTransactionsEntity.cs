using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("wallet_transactions")]
public sealed class WalletTransactionEntity
{
    public Guid Id { get; set; }
    public Guid? WalletId { get; set; }
    public CreditWalletEntity? Wallet { get; set; }
    public Guid? TransactionTypeId { get; set; }
    public TransactionTypeEntity? TransactionType { get; set; }
    public decimal Amount { get; set; }
    public Guid? ReferenceId { get; set; }
    public DateTime CreatedAt { get; set; }
}
