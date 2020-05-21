using Core.Domain.Entities;

namespace Estimate.Domain.Entities
{
    public class Currency : AuditableEntity
    {
        public int Name { get; set; }
        public string Abbreviation { get; set; }
        public int CurrencyTypeId { get; set; }
        public CurrencyType CurrencyType { get; set; }
    }
}