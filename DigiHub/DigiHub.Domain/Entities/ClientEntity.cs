using DigiHub.Domain.Common;

namespace DigiHub.Domain.Entities
{
    public class ClientEntity : AuditableEntity
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
    }
}
