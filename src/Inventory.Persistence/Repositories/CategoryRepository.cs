using Framework.DataAccess.EF;
using Inventory.Domain.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Inventory.Persistence.Repositories
{
    internal class CategoryRepository : ICategoryRepository
    {
        private readonly IDbContext _context;

        public CategoryRepository(IDbContext context)
        {
            _context = context;
        }

        public async Task Create(Category category)
        {
            await _context.Instance.Set<Category>().AddAsync(category);
        }

        public async Task<Category> GetBy(Guid surrogateKey)
        {
            return await _context.Instance.Set<Category>().FirstOrDefaultAsync(a => a.Id.SurrogateKey == surrogateKey);
        }
    }
}
