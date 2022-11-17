using Framework.Application;
using Inventory.Application.Contract.Products;
using Inventory.Domain.Categories;
using Inventory.Domain.Products;
using System.Threading.Tasks;

namespace Inventory.Application.ProductHandlers
{
    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        public async Task Handle(CreateProductCommand command)
        {
            var category = await _categoryRepository.GetBy(command.CategoryId);

            var product = new Product(command.Name, command.Barcode, command.Description, category.Id.Id, command.Weighted);
            await _productRepository.Create(product);
        }
    }
}