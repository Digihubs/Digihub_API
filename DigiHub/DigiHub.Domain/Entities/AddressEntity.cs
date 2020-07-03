using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class AddressEntity : AuditableEntity
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
    }
}
