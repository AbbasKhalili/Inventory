using Framework.Application;
using Inventory.Application.Contract.Products;
using Inventory.Application.Exceptions;
using Inventory.Domain.Products;
using System.Threading.Tasks;

namespace Inventory.Application.ProductHandlers
{
    internal class ChangeProductStatusCommandHandler : ICommandHandler<ChangeProductStatusCommand>
    {
        private readonly IProductRepository _productRepository;

        public ChangeProductStatusCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Handle(ChangeProductStatusCommand command)
        {
            var product = await _productRepository.GetBy(command.ProductId);

            if (product is null)
                throw new ProductNotFoundException();

            product.SetStatus(command.ProductStatus);

            _productRepository.Update(product);
        }
    }
}