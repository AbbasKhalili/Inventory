using Inventory.Interface.Contract.Category.DTOs;
using Inventory.Interface.Contract.Category.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.RestAPI.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryQueryController : ControllerBase
    {
        private readonly ICategoryFacadeQuery _facadeQuery;

        public CategoryQueryController(ICategoryFacadeQuery facadeQuery)
        {
            _facadeQuery = facadeQuery;
        }

        [HttpGet("getall")]
        public async Task<List<CategoryDto>> Get()
        {
            return await _facadeQuery.GetAll();
        }
    }
}
