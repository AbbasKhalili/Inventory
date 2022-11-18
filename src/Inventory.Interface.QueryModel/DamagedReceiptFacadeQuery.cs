using Inventory.Domain.EnterReceipts;
using Inventory.Interface.Contract.DamagedReceipt.Services;
using System;
using System.Threading.Tasks;

namespace Inventory.Interface.QueryModel
{
    internal class DamagedReceiptFacadeQuery : IDamagedReceiptFacadeQuery
    {
        private readonly IEnterReceiptRepository _enterReceiptRepository;

        public DamagedReceiptFacadeQuery(IEnterReceiptRepository enterReceiptRepository)
        {
            _enterReceiptRepository = enterReceiptRepository;
        }

        public async Task<int> GetCount(Guid productId)
        {
            return await _enterReceiptRepository.GetDamagedCount(productId);
        }
    }
}
