using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class CommissionEntity : AuditableEntity
    {
        public ushort CommissionId { get; set; }
        public ushort ServiceId { get; set; }
        public CategoryWiseServiceEntity CategoryWiseServiceEntity { get; set; }
        public decimal Percentage { get; set; }
        public ushort CommissionType { get; set; }
        public DateTime? ValidUntil { get; set; }
        public bool IsActive { get; set; }
    }
}
