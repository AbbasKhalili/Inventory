using Inventory.Interface.Contract.EnterReceipt.Models;
using Inventory.Interface.Contract.EnterReceipt.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Inventory.RestAPI.Controllers
{
    [ApiController]
    [Route("api/enterreceipt")]
    public class EnterReceiptController : ControllerBase
    {
        private readonly IEnterReceiptFacadeService _facadeService;

        public EnterReceiptController(IEnterReceiptFacadeService facadeService)
        {
            _facadeService = facadeService;
        }

        [HttpPost("create")]
        public async Task Post(EnterReceiptModel model)
        {
            await _facadeService.Create(model);
        }
    }
}
