using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class CommissionEntity : AuditableEntity
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public CategoryWiseServiceEntity CategoryWiseServiceEntity { get; set; }
        public int CommissionType { get; set; }
        public DateTime? ValidUntil { get; set; }
        public bool IsActive { get; set; }
    }
}
