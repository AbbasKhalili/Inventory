using Framework.Application;
using Inventory.Application.Contract.Categories;
using Inventory.Interface.Contract.Category.Models;
using Inventory.Interface.Contract.Category.Services;
using System.Threading.Tasks;

namespace Inventory.Interface.WriteModel
{
    public class CategoryFacadeService : ICategoryFacadeService
    {
        private readonly ICommandBus _commandBus;

        public CategoryFacadeService(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        public async Task Create(CategoryModel model)
        {
            await _commandBus.Dispatch(new CreateCategoryCommand
            {
                Name = model.Name
            });
        }
    }
}
