using Framework.Core;
using Inventory.Interface.Contract.EnterReceipt.Models;
using System.Threading.Tasks;

namespace Inventory.Interface.Contract.EnterReceipt.Services
{
    public interface IEnterReceiptFacadeService : IFacadeService
    {
        Task Create(EnterReceiptModel model);
    }
}
