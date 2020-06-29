using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class TransactionEntity : AuditableEntity
    {
        public TransactionEntity()
        {
            OrdersEntity = new OrdersEntity();
        }

        public Guid TransactionId { get; set; }
        public string OrderId { get; set; }
        public OrdersEntity OrdersEntity { get; private set; }
        public double NetAmount { get; set; }
        public double DiscountAmount { get; set; }
        public double GrossAmount { get; set; }
        public string ProviderId { get; set; }
        public double PayableAmount { get; set; }
    }
}
