using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;

namespace RepairShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderLineController : ControllerBase
    {
        private readonly ISalesOrderLineService _service;
        public SalesOrderLineController(ISalesOrderLineService service)
        {
            _service = service;
        }

        [HttpGet("GetAllSalesOrderLine")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpPost("CreateSalesOrderLine")]
        public async Task<IActionResult> CreateSalesOrderLine(SalesOrderLine item)
        {
            item.AddedOn = DateTime.Now;
            item.ModifiedOn = DateTime.Now;
            var data = await _service.AddAsync(item);
            return Ok(data);
        }

        [HttpDelete("DeleteSalesOrderLine/{id}")]
        public async Task<IActionResult> DeleteSalesOrderLine(int id)
        {
            var data = await _service.DeleteAsync(id);
            return Ok(data);
        }

        [HttpGet("GetSalesOrderLineById/{id}")]
        public async Task<IActionResult> GetSalesOrderLineById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            return Ok(data);
        }

        [HttpPut("UpdateSalesOrderLine/{id}")]
        public async Task<IActionResult> UpdateSalesOrderLine(SalesOrderLine item)
        {
            var data = await _service.UpdateAsync(item);
            return Ok(data);
        }
    }
}
