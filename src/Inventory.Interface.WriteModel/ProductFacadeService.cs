using Framework.Application;
using Inventory.Application.Contract.Products;
using Inventory.Interface.Contract.Product.Models;
using Inventory.Interface.Contract.Product.Services;
using Inventory.Domain.Contract;
using System.Threading.Tasks;

namespace Inventory.Interface.WriteModel
{
    internal class ProductFacadeService : IProductFacadeService
    {
        private readonly ICommandBus _commandBus;

        public ProductFacadeService(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        public async Task Create(ProductModel model)
        {
            await _commandBus.Dispatch(new CreateProductCommand
            {
                Name = model.Name,
                Barcode = model.Barcode,
                CategoryId = model.CategoryId,
                Description = model.Description,
                Weighted = model.Weighted
            });
        }

        public async Task SetAvailable(ChangeProductStatusModel model)
        {
            await _commandBus.Dispatch(new ChangeProductStatusCommand
            {
                ProductId = model.ProductId,
                ProductStatus = ProductStatus.Available
            });
        }

        public async Task SetUnAvailable(ChangeProductStatusModel model)
        {
            await _commandBus.Dispatch(new ChangeProductStatusCommand
            {
                ProductId = model.ProductId,
                ProductStatus = ProductStatus.UnAvailable
            });
        }
    }
}
