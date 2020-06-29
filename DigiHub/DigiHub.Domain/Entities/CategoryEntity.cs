using DigiHub.Domain.Common;

namespace DigiHub.Domain.Entities
{
    public class CategoryEntity : AuditableEntity
    {
        public ushort CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ushort ParentId { get; set; }
        public string Icon { get; set; }
        public string Banner { get; set; }
        public string Thumbnail { get; set; }
    }
}
