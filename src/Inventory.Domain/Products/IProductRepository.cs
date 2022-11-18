using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Domain.Products
{
    public interface IProductRepository : IRepository
    {
        Task Create(Product product);
        void Update(Product product);


        Task<Product> GetBy(Guid id);
        Task<Product> GetBy(long id);
        Task<List<Product>> GetAll();
        
    }
}
