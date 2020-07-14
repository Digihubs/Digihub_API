using DigiHub.Domain.Common;
using System.Collections.Generic;

namespace DigiHub.Domain.Entities
{
    public class CategoryEntity : AuditableEntity
    {
        public CategoryEntity()
        {
            CategoryWiseServiceEntities = new HashSet<CategoryWiseServiceEntity>();
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int ParentId { get; set; }
        public string Icon { get; set; }
        public string Banner { get; set; }
        public string Thumbnail { get; set; }
        public ICollection<CategoryWiseServiceEntity> CategoryWiseServiceEntities { get; private set; }
    }
}
