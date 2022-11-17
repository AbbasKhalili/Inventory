using Framework.Domain;
using System.Threading.Tasks;

namespace Inventory.Domain.EnterReceipts
{
    public interface IEnterReceiptRepository : IRepository
    {
        Task Create(EnterReceipt enterReceipt);
        Task<int> GetSoldCount(long productId);
        Task<int> GetDamagedCount(long productId);
    }
}
