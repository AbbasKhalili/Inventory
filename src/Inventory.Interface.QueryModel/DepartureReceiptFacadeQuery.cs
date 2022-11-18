using Inventory.Domain.DepartureReceipts;
using Inventory.Domain.EnterReceipts;
using Inventory.Interface.Contract.DepartureReceipt.Services;
using System;
using System.Threading.Tasks;

namespace Inventory.Interface.QueryModel
{
    internal class DepartureReceiptFacadeQuery  : IDepartureReceiptFacadeQuery
    {
        private readonly IEnterReceiptRepository _enterReceiptRepository;
        private readonly IDepartureReceiptRepository _departureReceiptRepository;

        public DepartureReceiptFacadeQuery(IDepartureReceiptRepository departureReceiptRepository, IEnterReceiptRepository enterReceiptRepository)
        {
            _departureReceiptRepository = departureReceiptRepository;
            _enterReceiptRepository = enterReceiptRepository;
        }

        public async Task<int> GetCount(Guid productId)
        {
            var damaged = await _enterReceiptRepository.GetDamagedCount(productId);
            var sold = await _departureReceiptRepository.GetSoldCount(productId);
            return sold - damaged;
        }
    }
}
