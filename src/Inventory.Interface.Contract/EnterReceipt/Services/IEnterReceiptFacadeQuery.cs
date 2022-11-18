using Framework.Core;
using System;
using System.Threading.Tasks;

namespace Inventory.Interface.Contract.EnterReceipt.Services
{
    public interface IEnterReceiptFacadeQuery : IFacadeService
    {
        Task<int> GetCount(Guid productId);
    }
}
