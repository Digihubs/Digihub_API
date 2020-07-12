using DigiHub.Domain.Common;
using System.Collections.Generic;

namespace DigiHub.Domain.Entities
{
    public class OrdersEntity : AuditableEntity
    {
        public OrdersEntity()
        {
            OrderDetailsEntities = new HashSet<OrderDetailsEntity>();
            AssignProvidersToOrderEntities = new HashSet<AssignProvidersToOrderEntity>();
            TransactionEntities = new HashSet<TransactionEntity>();
        }
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public int ClientId { get; set; }
        public ClientEntity ClientEntity { get; set; }
        public double NetAmount { get; set; }
        public double Discount { get; set; }
        public double GrossAmount { get; set; }
        public ushort Status { get; set; }
        public ICollection<OrderDetailsEntity> OrderDetailsEntities { get; private set; }
        public ICollection<AssignProvidersToOrderEntity> AssignProvidersToOrderEntities { get; private set; }
        public ICollection<TransactionEntity> TransactionEntities { get; private set; }

    }
}
