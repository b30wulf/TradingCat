using System;
using Core.Domain.Entities;

namespace Estimate.Domain.Entity
{
    public class TradeHistory : AuditableEntity
    {
        public DateTime TradeDate { get; set; }
        public string Parity { get; set; }
        public Currency BaseCurrencyId { get; set; }
        public Currency QuoteCurrencyId { get; set; }
        public decimal ParityPrice { get; set; }
        public TradeType TradeType { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
    }
}