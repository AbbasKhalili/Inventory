using Framework.Core;
using Inventory.Interface.Contract.Category.Models;
using System.Threading.Tasks;

namespace Inventory.Interface.Contract.Category.Services
{
    public interface ICategoryFacadeService : IFacadeService
    {
        Task Create(CategoryModel model);
    }
}
