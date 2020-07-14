using DigiHub.Domain.Common;
using System.Collections.Generic;

namespace DigiHub.Domain.Entities
{
    public class CategoryWiseServiceEntity : AuditableEntity
    {
        public CategoryWiseServiceEntity()
        {
            OrderDetailsEntities = new HashSet<OrderDetailsEntity>();
            CommissionEntities = new HashSet<CommissionEntity>();
        }
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public CategoryEntity CategoryEntity { get; set; }
        public int ServiceId { get; set; }
        public ServiceEntity ServiceEntity { get; set; }
        public double ServicePrice { get; set; }
        public ICollection<OrderDetailsEntity> OrderDetailsEntities { get; private set; }
        public ICollection<CommissionEntity> CommissionEntities { get; private set; }
    }
}
