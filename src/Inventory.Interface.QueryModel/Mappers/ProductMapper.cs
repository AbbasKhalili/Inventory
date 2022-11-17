using Inventory.Domain.Products;
using Inventory.Interface.Contract.Product.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Interface.QueryModel.Mappers
{
    internal static class ProductMapper
    {
        public static List<ProductDto> Map(List<Product> list)
        {
            return list.Select(a => Map(a)).ToList();
        }

        public static ProductDto Map(Product product)
        {
            return new ProductDto
            {
                Id = product.SurrogateKey,
                Name = product.Name,
                Barcode = product.Barcode,
                CategoryId = product.Category.SurrogateKey,
                Description = product.Description,
                Weighted = product.Weighted,
                Status = (byte)product.Status
            };
        }
    }
}
