using DigiHub.Domain.Common;

namespace DigiHub.Domain.Entities
{
    public class ServiceEntity : AuditableEntity
    {
        public ushort ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceImage { get; set; }
        public string ServiceDescription { get; set; }
    }
}
