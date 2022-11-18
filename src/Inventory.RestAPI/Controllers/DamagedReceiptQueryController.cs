using Inventory.Interface.Contract.DamagedReceipt.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Inventory.RestAPI.Controllers
{
    [ApiController]
    [Route("api/damagedreceipt")]
    public class DamagedReceiptQueryController : ControllerBase
    {
        private readonly IDamagedReceiptFacadeQuery _facadeQuery;

        public DamagedReceiptQueryController(IDamagedReceiptFacadeQuery facadeQuery)
        {
            _facadeQuery = facadeQuery;
        }

        [HttpGet("DamagedProductCount")]
        public async Task<int> GetCount(Guid productId)
        {
            return await _facadeQuery.GetCount(productId);
        }
    }
}
