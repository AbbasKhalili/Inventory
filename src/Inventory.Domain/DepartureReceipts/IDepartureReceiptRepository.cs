using Framework.Domain;
using System.Threading.Tasks;

namespace Inventory.Domain.DepartureReceipts
{
    public interface IDepartureReceiptRepository : IRepository
    {
        Task Create(DepartureReceipt departureReceipt);
    }
}
