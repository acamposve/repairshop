using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;

namespace RepairShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderLineController : ControllerBase
    {
        private readonly IPurchaseOrderLineService _service;
        public PurchaseOrderLineController(IPurchaseOrderLineService service)
        {
            _service = service;
        }

        [HttpGet("GetAllPurchaseOrderLine")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpPost("CreatePurchaseOrderLine")]
        public async Task<IActionResult> CreatePurchaseOrderLine(PurchaseOrderLine item)
        {
            item.AddedOn = DateTime.Now;
            item.ModifiedOn = DateTime.Now;
            var data = await _service.AddAsync(item);
            return Ok(data);
        }

        [HttpDelete("DeletePurchaseOrderLine/{id}")]
        public async Task<IActionResult> DeletePurchaseOrderLine(int id)
        {
            var data = await _service.DeleteAsync(id);
            return Ok(data);
        }

        [HttpGet("GetPurchaseOrderLineById/{id}")]
        public async Task<IActionResult> GetPurchaseOrderLineById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            return Ok(data);
        }

        [HttpPut("UpdatePurchaseOrderLine/{id}")]
        public async Task<IActionResult> UpdatePurchaseOrderLine(PurchaseOrderLine item)
        {
            var data = await _service.UpdateAsync(item);
            return Ok(data);
        }
    }
}
