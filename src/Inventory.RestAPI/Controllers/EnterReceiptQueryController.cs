using Inventory.Interface.Contract.EnterReceipt.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Inventory.RestAPI.Controllers
{
    [ApiController]
    [Route("api/enterreceipt")]
    public class EnterReceiptQueryController : ControllerBase
    {
        private readonly IEnterReceiptFacadeQuery _facadeQuery;

        public EnterReceiptQueryController(IEnterReceiptFacadeQuery facadeQuery)
        {
            _facadeQuery = facadeQuery;
        }

        [HttpGet("InstockProductCount")]
        public async Task<int> GetCount(Guid productId)
        {
            return await _facadeQuery.GetCount(productId);
        }
    }
}
