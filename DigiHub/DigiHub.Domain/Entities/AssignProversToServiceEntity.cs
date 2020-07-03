using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class AssignProversToServiceEntity : AuditableEntity
    {
        public Guid Id { get; set; }
        public string ProviderId { get; set; }
        public ProvidersEntity ProvidersEntity { get; set; }
        public string OrderId { get; set; }
        public OrdersEntity OrdersEntity { get; set; }
        public DateTime AssignedDateTime { get; set; }
    }
}
