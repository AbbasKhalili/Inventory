using Framework.DataAccess.EF;
using Inventory.Domain.EnterReceipts;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Persistence.Repositories
{
    internal class EnterReceiptRepository : IEnterReceiptRepository
    {
        private readonly IDbContext _context;

        public EnterReceiptRepository(IDbContext context)
        {
            _context = context;
        }

        public async Task Create(EnterReceipt enterReceipt)
        {
            await _context.Instance.Set<EnterReceipt>().AddAsync(enterReceipt);
        }

        public async Task<int> GetDamagedCount(long productId)
        {
            return await _context.Instance.Set<EnterReceipt>()
                .Where(a => a.ProductId == productId && a.Status == EnterReceiptStatus.Damaged)
                .SumAsync(a => a.Quantity);
        }

        public async Task<int> GetSoldCount(long productId)
        {
            return await _context.Instance.Set<EnterReceipt>()
                .Where(a => a.ProductId == productId && a.Status == EnterReceiptStatus.Sold)
                .SumAsync(a => a.Quantity);
        }
    }
}
