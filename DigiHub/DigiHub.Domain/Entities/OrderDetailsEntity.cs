using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class OrderDetailsEntity : AuditableEntity
    {
        public OrderDetailsEntity()
        {
            OrdersEntity = new OrdersEntity();
            CategoryWiseServiceEntity = new CategoryWiseServiceEntity();
        }

        public Guid OrderDetailsId { get; set; }
        public string OrderId { get; set; }
        public OrdersEntity OrdersEntity { get; private set; }
        public ushort ServiceId { get; set; }
        public CategoryWiseServiceEntity CategoryWiseServiceEntity { get; private set; }
    }
}
