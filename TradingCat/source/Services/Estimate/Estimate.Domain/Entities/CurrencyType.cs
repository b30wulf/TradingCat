using Core.Domain.Entities;

namespace Estimate.Domain.Entities
{
    public class CurrencyType : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}