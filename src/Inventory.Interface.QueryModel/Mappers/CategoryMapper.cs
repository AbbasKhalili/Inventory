using Inventory.Domain.Categories;
using Inventory.Interface.Contract.Category.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Interface.QueryModel.Mappers
{
    internal static class CategoryMapper
    {
        public static List<CategoryDto> Map(List<Category> list)
        {
            return list.Select(a => Map(a)).ToList();
        }

        public static CategoryDto Map(Category category)
        {
            return new CategoryDto
            {
                Id = category.Id.SurrogateKey,
                Name = category.Name
            };
        }
    }
}
