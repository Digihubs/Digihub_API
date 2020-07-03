using DigiHub.Domain.Common;

namespace DigiHub.Domain.Entities
{
    public class CategoryWiseServiceEntity : AuditableEntity
    {
        public CategoryWiseServiceEntity()
        {
            
        }


        public int Id { get; set; }
        public byte CategoryId { get; set; }
        public CategoryEntity CategoryEntity { get;  set; }
        public ushort ServiceId { get; set; }
        public ServiceEntity ServiceEntity { get;  set; }
        public double ServicePrice { get; set; }
    }
}
