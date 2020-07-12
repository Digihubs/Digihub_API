using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class AssignProvidersToOrderEntity : AuditableEntity
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public ProvidersEntity ProvidersEntity { get; set; }
        public int OrderId { get; set; }
        public OrdersEntity OrdersEntity { get; set; }
        public DateTime AssignedDateTime { get; set; }
    }
}
