using Framework.Application;
using Inventory.Application.Contract.Categories;
using Inventory.Domain.Categories;
using System.Threading.Tasks;

namespace Inventory.Application.CategoryHandlers
{
    public class CategoryCommandHandler : ICommandHandler<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task Handle(CreateCategoryCommand command)
        {
            var category = new Category(command.Name);
            await _categoryRepository.Create(category);
        }
    }
}
