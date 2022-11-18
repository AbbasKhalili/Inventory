using Inventory.Interface.Contract.Product.Models;
using Inventory.Interface.Contract.Product.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Inventory.RestAPI.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductFacadeService _facadeService;

        public ProductController(IProductFacadeService facadeService)
        {
            _facadeService = facadeService;
        }

        [HttpPost("create")]
        public async Task Post(ProductModel model)
        {
            await _facadeService.Create(model);
        }

        [HttpPut("setavailable")]
        public async Task SetAvailable(ChangeProductStatusModel model)
        {
            await _facadeService.SetAvailable(model);
        }

        [HttpPut("setunavailable")]
        public async Task SetUnavailable(ChangeProductStatusModel model)
        {
            await _facadeService.SetUnAvailable(model);
        }
    }
}
