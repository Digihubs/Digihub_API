using DigiHub.Domain.Common;

namespace DigiHub.Domain.Entities
{
    public class AddressEntity : AuditableEntity
    {
        public int AddressId { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
    }
}
