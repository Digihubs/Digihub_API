using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class OrdersEntity : AuditableEntity
    {
        public OrdersEntity()
        {
            ClientEntity = new ClientEntity();
        }
        public Int64 OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int ClientId { get; set; }
        public ClientEntity ClientEntity { get; private set; }
        public ushort Status { get; set; }
        public double Discount { get; set; }

    }
}
