using DigiHub.Domain.Common;
using System;
using System.Collections.Generic;

namespace DigiHub.Domain.Entities
{
    public class ServiceEntity : AuditableEntity
    {
        public ServiceEntity()
        {
            CategoryWiseServiceEntities = new HashSet<CategoryWiseServiceEntity>();
            OrderDetailsEntities = new HashSet<OrderDetailsEntity>();
        }
        public Guid Id { get; set; }
        public string ServiceName { get; set; }
        public string ServiceImage { get; set; }
        public string ServiceDescription { get; set; }
        public ICollection<CategoryWiseServiceEntity> CategoryWiseServiceEntities { get; private set; }
        public ICollection<OrderDetailsEntity> OrderDetailsEntities { get; private set; }
    }
}
