using Framework.Core;
using Inventory.Interface.Contract.Product.Models;
using System.Threading.Tasks;

namespace Inventory.Interface.Contract.Product.Services
{
    public interface IProductFacadeService : IFacadeService
    {
        Task Create(ProductModel model);
        Task SetAvailable(ChangeProductStatusModel model);
        Task SetUnAvailable(ChangeProductStatusModel model);
    }
}
