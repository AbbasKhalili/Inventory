using Framework.Application;
using Inventory.Application.Contract.EnterReceipts;
using Inventory.Interface.Contract.DamagedReceipt.Models;
using Inventory.Interface.Contract.DamagedReceipt.Services;
using System.Threading.Tasks;

namespace Inventory.Interface.WriteModel
{
    internal class DamagedReceiptFacadeService : IDamagedReceiptFacadeService
    {
        private readonly ICommandBus _commandBus;

        public DamagedReceiptFacadeService(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        public async Task Create(DamagedReceiptModel model)
        {
            await _commandBus.Dispatch(new DamagedReceiptCommand
            {
                CustomerName = model.CustomerName,
                ProductId = model.ProductId,
                Quantity = model.Quantity
            });
        }
    }
}
