using Inventory.Domain.DepartureReceipts;
using Inventory.Domain.EnterReceipts;
using Inventory.Interface.Contract.EnterReceipt.Services;
using System;
using System.Threading.Tasks;

namespace Inventory.Interface.QueryModel
{
    internal class EnterReceiptFacadeQuery : IEnterReceiptFacadeQuery
    {
        private readonly IEnterReceiptRepository _enterReceiptRepository;
        private readonly IDepartureReceiptRepository _departureReceiptRepository;

        public EnterReceiptFacadeQuery(IEnterReceiptRepository enterReceiptRepository, 
            IDepartureReceiptRepository departureReceiptRepository)
        {
            _enterReceiptRepository = enterReceiptRepository;
            _departureReceiptRepository = departureReceiptRepository;
        }

        public async Task<int> GetCount(Guid productId)
        {
            var entered =  await _enterReceiptRepository.GetInStockCount(productId);
            var sold = await _departureReceiptRepository.GetSoldCount(productId);
            return entered - sold;
        }
    }
}
