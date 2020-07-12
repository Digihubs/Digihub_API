using DigiHub.Domain.Common;
using System.Collections.Generic;

namespace DigiHub.Domain.Entities
{
    public class AddressEntity : AuditableEntity
    {
        public AddressEntity()
        {
            ProvidersEntities = new HashSet<ProvidersEntity>();
            ClientEntities = new HashSet<ClientEntity>();
        }
        public int Id { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public ICollection<ProvidersEntity> ProvidersEntities { get; private set; }
        public ICollection<ClientEntity> ClientEntities { get; private set; }
    }
}
