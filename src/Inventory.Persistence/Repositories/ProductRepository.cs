using Framework.DataAccess.EF;
using Inventory.Domain.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbSet<Product> _dbSet;

        public ProductRepository(IDbContext context)
        {
            _dbSet = context.Instance.Set<Product>();
        }

        public async Task Create(Product product)
        {
            await _dbSet.AddAsync(product);
        }
        public void Update(Product product)
        {
            _dbSet.Update(product);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _dbSet.Include(a => a.Category).ToListAsync();
        }

        public async Task<Product> GetBy(Guid id)
        {
            return await _dbSet.Include(a => a.Category).FirstOrDefaultAsync(a => a.SurrogateKey == id);
        }
        public async Task<Product> GetBy(long id)
        {
            return await _dbSet.Include(a => a.Category).FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
