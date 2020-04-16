using System;

namespace Core.Domain.Entities
{
    public class AuditableEntity : BaseEntity<int>
    {
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreatorId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifierId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DeleterId { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}