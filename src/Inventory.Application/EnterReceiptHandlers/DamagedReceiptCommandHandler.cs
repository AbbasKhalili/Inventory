using Framework.Application;
using Inventory.Application.Contract.EnterReceipts;
using Inventory.Application.Exceptions;
using Inventory.Domain.Contract;
using Inventory.Domain.EnterReceipts;
using Inventory.Domain.Products;
using System.Threading.Tasks;

namespace Inventory.Application.EnterReceiptHandlers
{
    internal class DamagedReceiptCommandHandler : ICommandHandler<DamagedReceiptCommand>
    {
        private readonly IEnterReceiptRepository _enterReceiptRepository;
        private readonly IProductRepository _productRepository;

        public DamagedReceiptCommandHandler(IEnterReceiptRepository enterReceiptRepository, IProductRepository productRepository)
        {
            _enterReceiptRepository = enterReceiptRepository;
            _productRepository = productRepository;
        }

        public async Task Handle(DamagedReceiptCommand command)
        {
            var product = await _productRepository.GetBy(command.ProductId);

            if (product is null)
                throw new ProductNotFoundException();

            var departure = new EnterReceipt(command.CustomerName, product.Id, command.Quantity, EnterReceiptStatus.Damaged);
            await _enterReceiptRepository.Create(departure);
        }
    }
}
