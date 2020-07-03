using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class OrderDetailsEntity : AuditableEntity
    {

        public Guid Id { get; set; }
        public string OrderId { get; set; }
        public OrdersEntity OrdersEntity { get; set; }
        public string ServiceId { get; set; }
        public CategoryWiseServiceEntity CategoryWiseServiceEntity { get; set; }
    }
}
