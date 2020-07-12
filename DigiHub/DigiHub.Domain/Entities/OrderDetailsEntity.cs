using DigiHub.Domain.Common;

namespace DigiHub.Domain.Entities
{
    public class OrderDetailsEntity : AuditableEntity
    {

        public int Id { get; set; }
        public int OrderId { get; set; }
        public OrdersEntity OrdersEntity { get; set; }
        public int ServiceId { get; set; }
        public CategoryWiseServiceEntity CategoryWiseServiceEntity { get; set; }
        public double ServicePrice { get; set; }
    }
}
