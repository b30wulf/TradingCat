using Core.Domain.Entities;

namespace Estimate.Domain.Entity
{
    public class TradeType : BaseEntity<int>
    {
        public int Name { get; set; }
    }
}