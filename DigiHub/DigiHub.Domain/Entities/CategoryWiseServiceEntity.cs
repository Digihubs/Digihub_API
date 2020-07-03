using DigiHub.Domain.Common;
using System;
using System.Collections.Generic;

namespace DigiHub.Domain.Entities
{
    public class CategoryWiseServiceEntity : AuditableEntity
    {
        public CategoryWiseServiceEntity()
        {
            CommissionEntities = new HashSet<CommissionEntity>();
        }
        public Guid Id { get; set; }
        public string CategoryId { get; set; }
        public CategoryEntity CategoryEntity { get; set; }
        public string ServiceId { get; set; }
        public ServiceEntity ServiceEntity { get; set; }
        public double ServicePrice { get; set; }
        public ICollection<CommissionEntity> CommissionEntities { get; private set; }
    }
}
