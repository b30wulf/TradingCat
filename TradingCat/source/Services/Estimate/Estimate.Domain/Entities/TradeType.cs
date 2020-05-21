using Core.Domain.Entities;

namespace Estimate.Domain.Entities
{
    public class TradeType : BaseEntity<int>
    {
        public int Name { get; set; }
    }
}