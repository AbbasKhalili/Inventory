using Framework.DataAccess.EF;
using Inventory.Domain.DepartureReceipts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Persistence.Repositories
{
    internal class DepartureReceiptRepository : IDepartureReceiptRepository
    {
        private readonly DbSet<DepartureReceipt> _dbSet;

        public DepartureReceiptRepository(IDbContext context)
        {
            _dbSet = context.Instance.Set<DepartureReceipt>();
        }

        public async Task Create(DepartureReceipt departureReceipt)
        {
            await _dbSet.AddAsync(departureReceipt);
        }

        public async Task<int> GetSoldCount(long productId)
        {
            return await _dbSet
                .Where(a => a.ProductId == productId)
                .SumAsync(a => a.Quantity);
        }
        public async Task<int> GetSoldCount(Guid productId)
        {
            return await _dbSet.Include(a => a.Product)
                .Where(a => a.Product.SurrogateKey == productId)
                .SumAsync(a => a.Quantity);
        }
    }
}
