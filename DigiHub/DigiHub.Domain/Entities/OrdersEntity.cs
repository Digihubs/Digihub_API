using DigiHub.Domain.Common;
using System;
using System.Collections.Generic;

namespace DigiHub.Domain.Entities
{
    public class OrdersEntity : AuditableEntity
    {
        public OrdersEntity()
        {
            OrderDetailsEntity = new HashSet<OrderDetailsEntity>();
        }
        public Int64 OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int ClientId { get; set; }
        public ClientEntity ClientEntity { get; set; }
        public ushort Status { get; set; }
        public double Discount { get; set; }
        public ICollection<OrderDetailsEntity> OrderDetailsEntity { get; private set; }

    }
}
