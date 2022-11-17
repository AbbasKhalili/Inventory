using Inventory.Domain.Categories;
using Inventory.Interface.Contract.Category.DTOs;
using Inventory.Interface.Contract.Category.Services;
using Inventory.Interface.QueryModel.Mappers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Interface.QueryModel
{
    public class CategoryFacadeQuery : ICategoryFacadeQuery
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryFacadeQuery(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryDto>> GetAll()
        {
            var list = await _categoryRepository.GetAll();
            return CategoryMapper.Map(list);
        }
    }
}
