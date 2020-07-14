using DigiHub.Application.Common.Interfaces;
using DigiHub.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DigiHub.Application.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<Guid>
    {
        public string CategoryName { get; set; }
        public ushort ParentId { get; set; }
        public string Icon { get; set; }
        public string Banner { get; set; }
        public string Thumbnail { get; set; }
    }

    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Guid>
    {
        private IDigiHubDBContext _context { get; }
        public CreateCategoryCommandHandler(IDigiHubDBContext context)
        {
            _context = context;
        }


        public async Task<Guid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var entity = new CategoryEntity
            {
                CategoryName = request.CategoryName,
                ParentId = request.ParentId,
                Icon = request.Icon,
                Banner = request.Banner,
                Thumbnail = request.Thumbnail
            };

            _context.CategoryEntities.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
