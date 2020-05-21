using System;

namespace Core.Domain.Models
{
    public class AuditableDto : BaseDto<int>
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