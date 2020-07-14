using DigiHub.Domain.Common;

namespace DigiHub.Domain.Entities
{
    public class TransactionEntity : AuditableEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public OrdersEntity OrdersEntity { get; set; }
        public double NetAmount { get; set; }
        public double Discount { get; set; }
        public double GrossAmount { get; set; }
        public int ProviderId { get; set; }
        public ProvidersEntity ProvidersEntity { get; set; }
        public double PayableAmount { get; set; }
    }
}
