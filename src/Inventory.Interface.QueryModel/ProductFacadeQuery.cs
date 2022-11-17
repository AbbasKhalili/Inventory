using Inventory.Domain.Products;
using Inventory.Interface.Contract.Product.DTOs;
using Inventory.Interface.Contract.Product.Services;
using Inventory.Interface.QueryModel.Mappers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Interface.QueryModel
{
    internal class ProductFacadeQuery : IProductFacadeQuery
    {
        private readonly IProductRepository _productRepository;

        public ProductFacadeQuery(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var list = await _productRepository.GetAll();
            return ProductMapper.Map(list);
        }
    }
}
