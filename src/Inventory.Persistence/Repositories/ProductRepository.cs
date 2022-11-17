using Framework.DataAccess.EF;
using Inventory.Domain.Products;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Inventory.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbContext _context;

        public ProductRepository(IDbContext context)
        {
            _context = context;
        }

        public async Task Create(Product product)
        {
            await _context.Instance.Set<Product>().AddAsync(product);
        }

        public async Task<Product> GetBy(long id)
        {
            return await _context.Instance.Set<Product>().FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
