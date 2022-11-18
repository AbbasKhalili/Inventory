using Framework.DataAccess.EF;
using Inventory.Domain.Contract;
using Inventory.Domain.EnterReceipts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Persistence.Repositories
{
    internal class EnterReceiptRepository : IEnterReceiptRepository
    {
        private readonly DbSet<EnterReceipt> _dbSet;

        public EnterReceiptRepository(IDbContext context)
        {
            _dbSet = context.Instance.Set<EnterReceipt>();
        }

        public async Task Create(EnterReceipt enterReceipt)
        {
            await _dbSet.AddAsync(enterReceipt);
        }

        public async Task<int> GetDamagedCount(long productId)
        {
            return await _dbSet
                .Where(a => a.ProductId == productId && a.Status == EnterReceiptStatus.Damaged)
                .SumAsync(a => a.Quantity);
        }

        public async Task<int> GetInStockCount(long productId)
        {
            return await _dbSet
                .Where(a => a.ProductId == productId && a.Status == EnterReceiptStatus.InStock)
                .SumAsync(a => a.Quantity);
        }

        public async Task<int> GetDamagedCount(Guid productId)
        {
            return await _dbSet.Include(a => a.Product)
                .Where(a => a.Product.SurrogateKey == productId && a.Status == EnterReceiptStatus.Damaged)
                .SumAsync(a => a.Quantity);
        }

        public async Task<int> GetInStockCount(Guid productId)
        {
            return await _dbSet.Include(a => a.Product)
                .Where(a => a.Product.SurrogateKey == productId && a.Status == EnterReceiptStatus.InStock)
                .SumAsync(a => a.Quantity);
        }
    }
}
