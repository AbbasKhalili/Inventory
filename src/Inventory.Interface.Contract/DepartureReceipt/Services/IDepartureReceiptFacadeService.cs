using Framework.Core;
using Inventory.Interface.Contract.DepartureReceipt.Models;
using System.Threading.Tasks;

namespace Inventory.Interface.Contract.DepartureReceipt.Services
{
    public interface IDepartureReceiptFacadeService : IFacadeService
    {
        Task Create(DepartureReceiptModel model);
    }
}
