using Inventory.Interface.Contract.DamagedReceipt.Models;
using Inventory.Interface.Contract.DamagedReceipt.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Inventory.RestAPI.Controllers
{
    [ApiController]
    [Route("api/damagedreceipt")]
    public class DamagedReceiptController : ControllerBase
    {
        private readonly IDamagedReceiptFacadeService _facadeService;

        public DamagedReceiptController(IDamagedReceiptFacadeService facadeService)
        {
            _facadeService = facadeService;
        }

        [HttpPost("create")]
        public async Task Post(DamagedReceiptModel model)
        {
            await _facadeService.Create(model);
        }
    }
}
