using Framework.Core;
using Inventory.Interface.Contract.Category.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Interface.Contract.Category.Services
{
    public interface ICategoryFacadeQuery : IFacadeService
    {
        Task<List<CategoryDto>> GetAll();
    }
}
