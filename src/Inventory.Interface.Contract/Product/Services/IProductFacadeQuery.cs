using Framework.Core;
using Inventory.Interface.Contract.Product.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Interface.Contract.Product.Services
{
    public interface IProductFacadeQuery : IFacadeService
    {
        Task<List<ProductDto>> GetAll();
    }
}
