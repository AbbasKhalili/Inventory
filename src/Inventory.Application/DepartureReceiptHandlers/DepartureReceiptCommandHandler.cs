using Framework.Application;
using Inventory.Application.Contract.DepartureReceipts;
using Inventory.Application.Exceptions;
using Inventory.Domain.DepartureReceipts;
using Inventory.Domain.DepartureReceipts.DomainServices;
using Inventory.Domain.Products;
using System.Threading.Tasks;

namespace Inventory.Application.DepartureReceiptHandlers
{
    internal class DepartureReceiptCommandHandler : ICommandHandler<DepartureReceiptCommand>
    {
        private readonly IDepartureReceiptRepository _departureReceiptRepository;
        private readonly IProductRepository _productRepository;
        private readonly IInquiryExistingProductDomainService _inquiryExistingProduct;

        public DepartureReceiptCommandHandler(IDepartureReceiptRepository departureReceiptRepository, 
            IProductRepository productRepository, 
            IInquiryExistingProductDomainService inquiryExistingProduct)
        {
            _departureReceiptRepository = departureReceiptRepository;
            _productRepository = productRepository;
            _inquiryExistingProduct = inquiryExistingProduct;
        }

        public async Task Handle(DepartureReceiptCommand command)
        {
            var product = await _productRepository.GetBy(command.ProductId);

            if (product is null)
                throw new ProductNotFoundException();

            var departure = await DepartureReceipt.Create(command.CustomerName, product.Id, command.Quantity, _inquiryExistingProduct);
            await _departureReceiptRepository.Create(departure);
        }
    }
}
