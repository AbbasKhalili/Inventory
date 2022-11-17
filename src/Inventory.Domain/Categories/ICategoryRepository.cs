using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Domain.Categories
{
    public interface ICategoryRepository : IRepository
    {
        Task Create(Category category);
        Task<Category> GetBy(Guid surrogateKey);
        Task<List<Category>> GetAll();
    }
}
