using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class CategoryEntity : AuditableEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ushort ParentId { get; set; }
        public string Icon { get; set; }
        public string Banner { get; set; }
        public string Thumbnail { get; set; }
    }
}
