using Inventory.Interface.Contract.DepartureReceipt.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Inventory.RestAPI.Controllers
{
    [ApiController]
    [Route("api/departurereceipt")]
    public class DepartureReceiptQueryController : ControllerBase
    {
        private readonly IDepartureReceiptFacadeQuery _facadeQuery;

        public DepartureReceiptQueryController(IDepartureReceiptFacadeQuery facadeQuery)
        {
            _facadeQuery = facadeQuery;
        }

        [HttpGet("SoldProductCount")]
        public async Task<int> GetCount(Guid productId)
        {
            return await _facadeQuery.GetCount(productId);
        }
    }
}
