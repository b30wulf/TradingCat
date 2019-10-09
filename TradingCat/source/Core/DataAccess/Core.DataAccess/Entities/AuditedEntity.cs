using System;

namespace Core.DataAccess.Entities
{
    public abstract class AuditedEntity : BaseEntity
    {
        public bool IsDeleted { get; set; }
        public int? DeleterId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public int? ModifiedId { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public int? CreatorId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
    }
}