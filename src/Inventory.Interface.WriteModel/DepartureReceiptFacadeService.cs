using Framework.Application;
using Inventory.Application.Contract.DepartureReceipts;
using Inventory.Interface.Contract.DepartureReceipt.Models;
using Inventory.Interface.Contract.DepartureReceipt.Services;
using System.Threading.Tasks;

namespace Inventory.Interface.WriteModel
{
    internal class DepartureReceiptFacadeService : IDepartureReceiptFacadeService
    {
        private readonly ICommandBus _commandBus;

        public DepartureReceiptFacadeService(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        public async Task Create(DepartureReceiptModel model)
        {
            await _commandBus.Dispatch(new DepartureReceiptCommand
            {
                CustomerName = model.CustomerName,
                ProductId = model.ProductId,
                Quantity = model.Quantity
            });
        }
    }
}
