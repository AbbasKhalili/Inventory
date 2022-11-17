using Framework.DataAccess.EF;
using Inventory.Domain.DepartureReceipts;
using Microsoft.EntityFrameworkCore;
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
    }
}
