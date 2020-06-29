using DigiHub.Domain.Common;

namespace DigiHub.Domain.Entities
{
    public class CategoryWiseServiceEntity : AuditableEntity
    {
        public CategoryWiseServiceEntity()
        {
            CategoryEntity = new CategoryEntity();
            ServiceEntity = new ServiceEntity();
        }

        public int CategoryWiseServiceId { get; set; }
        public byte CategoryId { get; set; }
        public CategoryEntity CategoryEntity { get; private set; }
        public ushort ServiceId { get; set; }
        public ServiceEntity ServiceEntity { get; private set; }
        public double ServicePrice { get; set; }
    }
}
