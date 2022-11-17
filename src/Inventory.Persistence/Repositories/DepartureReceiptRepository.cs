using Framework.DataAccess.EF;
using Inventory.Domain.DepartureReceipts;
using System.Threading.Tasks;

namespace Inventory.Persistence.Repositories
{
    internal class DepartureReceiptRepository : IDepartureReceiptRepository
    {
        private readonly IDbContext _context;

        public DepartureReceiptRepository(IDbContext context)
        {
            _context = context;
        }

        public async Task Create(DepartureReceipt departureReceipt)
        {
            await _context.Instance.Set<DepartureReceipt>().AddAsync(departureReceipt);
        }
    }
}
