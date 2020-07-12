using DigiHub.Domain.Common;
using System.Collections.Generic;

namespace DigiHub.Domain.Entities
{
    public class ServiceEntity : AuditableEntity
    {
        public ServiceEntity()
        {
            CategoryWiseServiceEntities = new HashSet<CategoryWiseServiceEntity>();
        }
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string ServiceImage { get; set; }
        public string ServiceDescription { get; set; }
        public ICollection<CategoryWiseServiceEntity> CategoryWiseServiceEntities { get; private set; }
    }
}
