using Framework.Domain;
using System;
using System.Threading.Tasks;

namespace Inventory.Domain.EnterReceipts
{
    public interface IEnterReceiptRepository : IRepository
    {
        Task Create(EnterReceipt enterReceipt);
        Task<int> GetInStockCount(long productId);
        Task<int> GetInStockCount(Guid productId);
        Task<int> GetDamagedCount(long productId);
        Task<int> GetDamagedCount(Guid productId);
    }
}
