using Framework.Core;
using Inventory.Interface.Contract.DamagedReceipt.Models;
using System.Threading.Tasks;

namespace Inventory.Interface.Contract.DamagedReceipt.Services
{
    public interface IDamagedReceiptFacadeService : IFacadeService
    {
        Task Create(DamagedReceiptModel model);
    }
}
