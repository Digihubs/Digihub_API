using DigiHub.Domain.Common;

namespace DigiHub.Domain.Entities
{
    public class ProvidersEntity : AuditableEntity
    {
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string ProviderCode { get; set; }
        public string ContactNumber { get; set; }
        public string BusinessAddress { get; set; }
        public int AddressId { get; set; }
        public AddressEntity AddressEntity { get; set; }
        public bool IsIndividual { get; set; }

    }
}
