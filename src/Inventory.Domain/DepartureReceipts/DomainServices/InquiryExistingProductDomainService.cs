using Inventory.Domain.EnterReceipts;
using Inventory.Domain.Exceptions;
using Inventory.Domain.Products;
using System.Threading.Tasks;

namespace Inventory.Domain.DepartureReceipts.DomainServices
{
    public class InquiryExistingProductDomainService : IInquiryExistingProductDomainService
    {
        private readonly IProductRepository _productRepository;
        private readonly IEnterReceiptRepository _enterReceiptRepository;
        private readonly IDepartureReceiptRepository _departureReceiptRepository;

        public InquiryExistingProductDomainService(IProductRepository productRepository, 
            IEnterReceiptRepository enterReceiptRepository, 
            IDepartureReceiptRepository departureReceiptRepository)
        {
            _productRepository = productRepository;
            _enterReceiptRepository = enterReceiptRepository;
            _departureReceiptRepository = departureReceiptRepository;
        }

        public async Task Inqiry(long productId, int quantity)
        {
            var product = await _productRepository.GetBy(productId);
            if (product.Status == Contract.ProductStatus.UnAvailable)
                throw new ProductUnavailableException();

            var inStockCount = await _enterReceiptRepository.GetInStockCount(productId);
            
            var soldCount = await _departureReceiptRepository.GetSoldCount(productId);

            if (inStockCount - soldCount < quantity)
                throw new InsufficientInventoryException();
        }
    }
}
