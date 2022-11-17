using Framework.DataAccess.EF;
using Inventory.Domain.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DbSet<Category> _dbSet;

        public CategoryRepository(IDbContext context)
        {
            _dbSet = context.Instance.Set<Category>();
        }

        public async Task Create(Category category)
        {
            await _dbSet.AddAsync(category);
        }

        public async Task<List<Category>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Category> GetBy(Guid surrogateKey)
        {
            return await _dbSet.FirstOrDefaultAsync(a => a.SurrogateKey == surrogateKey);
        }
    }
}
