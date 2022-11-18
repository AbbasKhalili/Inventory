using Framework.Core;
using System;
using System.Threading.Tasks;

namespace Inventory.Interface.Contract.DepartureReceipt.Services
{
    public interface IDepartureReceiptFacadeQuery : IFacadeService
    {
        Task<int> GetCount(Guid productId);
    }
}
