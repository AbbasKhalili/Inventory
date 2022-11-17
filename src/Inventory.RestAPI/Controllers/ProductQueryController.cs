using Inventory.Interface.Contract.Product.DTOs;
using Inventory.Interface.Contract.Product.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.RestAPI.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductQueryController : ControllerBase
    {
        private readonly IProductFacadeQuery _facadeQuery;

        public ProductQueryController(IProductFacadeQuery facadeQuery)
        {
            _facadeQuery = facadeQuery;
        }

        [HttpGet("getall")]
        public async Task<List<ProductDto>> GetAll()
        {
            return await _facadeQuery.GetAll();
        }
    }
}
