using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;

namespace RepairShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderController : ControllerBase
    {
        private readonly ISalesOrderService _service;
        public SalesOrderController(ISalesOrderService service)
        {
            _service = service;
        }

        [HttpGet("GetAllSalesOrder")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpPost("CreateSalesOrder")]
        public async Task<IActionResult> CreateSalesOrder(SalesOrder item)
        {
            item.AddedOn = DateTime.Now;
            item.ModifiedOn = DateTime.Now;
            var data = await _service.AddAsync(item);
            return Ok(data);
        }

        [HttpDelete("DeleteSalesOrder/{id}")]
        public async Task<IActionResult> DeleteSalesOrder(Guid id)
        {
            var data = await _service.DeleteAsync(id);
            return Ok(data);
        }

        [HttpGet("GetSalesOrderById/{id}")]
        public async Task<IActionResult> GetSalesOrderById(Guid id)
        {
            var data = await _service.GetByIdAsync(id);
            return Ok(data);
        }

        [HttpPut("UpdateSalesOrder/{id}")]
        public async Task<IActionResult> UpdateSalesOrder(SalesOrder item)
        {
            var data = await _service.UpdateAsync(item);
            return Ok(data);
        }
    }
}
