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
            TransactionEntities = new HashSet<TransactionEntity>();
            AssignProversToServiceEntities = new HashSet<AssignProversToServiceEntity>();
        }
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public string ClientId { get; set; }
        public ClientEntity ClientEntity { get; set; }
        public ushort Status { get; set; }
        public double Discount { get; set; }
        public ICollection<OrderDetailsEntity> OrderDetailsEntity { get; private set; }
        public ICollection<TransactionEntity> TransactionEntities { get; private set; }
        public ICollection<AssignProversToServiceEntity> AssignProversToServiceEntities { get; private set; }

    }
}
