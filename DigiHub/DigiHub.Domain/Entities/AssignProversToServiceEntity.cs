using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class AssignProversToServiceEntity : AuditableEntity
    {
        public Int64 AssignId { get; set; }
        public int ProviderId { get; set; }
        public ProvidersEntity ProvidersEntity { get; set; }
        public Int64 OrderId { get; set; }
        public OrdersEntity OrdersEntity { get; set; }
        public DateTime AssignedDateTime { get; set; }
    }
}
