using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using RepairShop.Core.Entities.Request;

namespace RepairShop.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly IPurchaseOrderService _service;
        public PurchaseOrderController(IPurchaseOrderService service)
        {
            _service = service;
        }

        [HttpGet("GetAllPurchaseOrder")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpPost("CreatePurchaseOrder")]
        public async Task<IActionResult> CreatePurchaseOrder(PurchaseOrderRequest request)
        {
            var item = new PurchaseOrder();
            item.Description = request.Description;
            item.VendorId = request.VendorId;
            var data = await _service.AddAsync(item);
            return Ok(data);
        }

        [HttpDelete("DeletePurchaseOrder/{id}")]
        public async Task<IActionResult> DeletePurchaseOrder(int id)
        {
            var data = await _service.DeleteAsync(id);
            return Ok(data);
        }

        [HttpGet("GetPurchaseOrderById/{id}")]
        public async Task<IActionResult> GetPurchaseOrderById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            return Ok(data);
        }

        [HttpPut("UpdatePurchaseOrder/{id}")]
        public async Task<IActionResult> UpdatePurchaseOrder(PurchaseOrder item)
        {
            var data = await _service.UpdateAsync(item);
            return Ok(data);
        }
    }
}
