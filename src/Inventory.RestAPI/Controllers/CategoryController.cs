using Inventory.Interface.Contract.Category.Models;
using Inventory.Interface.Contract.Category.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Inventory.RestAPI.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryFacadeService _facadeService;

        public CategoryController(ICategoryFacadeService facadeService)
        {
            _facadeService = facadeService;
        }

        [HttpPost("create")]
        public async Task Post(CategoryModel model)
        {
            await _facadeService.Create(model);
        }
    }
}
