using Core.Domain.Entities;

namespace Estimate.Domain.Entity
{
    public class Currency : AuditableEntity
    {
        public int Name { get; set; }
        public string Abbreviation { get; set; }
    }
}