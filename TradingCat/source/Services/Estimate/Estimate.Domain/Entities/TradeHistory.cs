using System;
using Core.Domain.Entities;

namespace Estimate.Domain.Entities
{
    public class TradeHistory : AuditableEntity
    {
        public DateTime TradeDate { get; set; }
        public string Parity { get; set; }
        public int BaseCurrencyId { get; set; }
        public Currency BaseCurrency { get; set; }
        public int QuoteCurrencyId { get; set; }
        public Currency QuoteCurrency { get; set; }
        public decimal ParityPrice { get; set; }
        public int TradeTypeId { get; set; }
        public TradeType TradeType { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
    }
}