using Framework.Domain;
using System.Threading.Tasks;

namespace Inventory.Domain.Products
{
    public interface IProductRepository : IRepository
    {
        Task Create(Product product);
        Task<Product> GetBy(ProductId id);
    }
}
