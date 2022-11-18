using Inventory.Interface.Contract.DepartureReceipt.Models;
using Inventory.Interface.Contract.DepartureReceipt.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Inventory.RestAPI.Controllers
{
    [ApiController]
    [Route("api/departurereceipt")]
    public class DepartureReceiptController : ControllerBase
    {
        private readonly IDepartureReceiptFacadeService _facadeService;

        public DepartureReceiptController(IDepartureReceiptFacadeService facadeService)
        {
            _facadeService = facadeService;
        }

        [HttpPost("create")]
        public async Task Post(DepartureReceiptModel model)
        {
            await _facadeService.Create(model);
        }
    }
}
