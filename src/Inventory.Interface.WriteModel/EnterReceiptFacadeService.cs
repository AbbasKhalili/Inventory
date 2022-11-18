using Framework.Application;
using Inventory.Application.Contract.EnterReceipts;
using Inventory.Interface.Contract.EnterReceipt.Models;
using Inventory.Interface.Contract.EnterReceipt.Services;
using System.Threading.Tasks;

namespace Inventory.Interface.WriteModel
{
    internal class EnterReceiptFacadeService : IEnterReceiptFacadeService
    {
        private readonly ICommandBus _commandBus;

        public EnterReceiptFacadeService(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        public async Task Create(EnterReceiptModel model)
        {
            await _commandBus.Dispatch(new EnterReceiptCommand
            {
                CustomerName = model.CustomerName,
                ProductId = model.ProductId,
                Quantity = model.Quantity
            });
        }
    }
}
