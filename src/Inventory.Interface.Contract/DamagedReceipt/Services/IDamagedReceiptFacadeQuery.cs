using Framework.Core;
using System;
using System.Threading.Tasks;

namespace Inventory.Interface.Contract.DamagedReceipt.Services
{
    public interface IDamagedReceiptFacadeQuery : IFacadeService
    {
        Task<int> GetCount(Guid productId);
    }
}
