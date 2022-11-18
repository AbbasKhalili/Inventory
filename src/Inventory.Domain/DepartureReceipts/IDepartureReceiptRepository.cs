using Framework.Domain;
using System;
using System.Threading.Tasks;

namespace Inventory.Domain.DepartureReceipts
{
    public interface IDepartureReceiptRepository : IRepository
    {
        Task Create(DepartureReceipt departureReceipt);


        Task<int> GetSoldCount(long productId);
        Task<int> GetSoldCount(Guid productId);
    }
}
