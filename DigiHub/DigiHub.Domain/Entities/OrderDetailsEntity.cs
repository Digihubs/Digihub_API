using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class OrderDetailsEntity : AuditableEntity
    {
        public OrderDetailsEntity()
        {
        }

        public Guid OrderDetailsId { get; set; }
        public string OrderId { get; set; }
        public OrdersEntity OrdersEntity { get; set; }
        public ushort ServiceId { get; set; }
        public CategoryWiseServiceEntity CategoryWiseServiceEntity { get; set; }
    }
}
