using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;

namespace RepairShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvenTranController : ControllerBase
    {
        private readonly IInvenTranService _service;
        public InvenTranController(IInvenTranService service)
        {
            _service = service;
        }

        [HttpGet("GetAllInvenTran")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpPost("CreateInvenTran")]
        public async Task<IActionResult> CreateInvenTran(InvenTran item)
        {
            item.AddedOn = DateTime.Now;
            item.ModifiedOn = DateTime.Now;
            var data = await _service.AddAsync(item);
            return Ok(data);
        }

        [HttpDelete("DeleteInvenTran/{id}")]
        public async Task<IActionResult> DeleteInvenTran(int id)
        {
            var data = await _service.DeleteAsync(id);
            return Ok(data);
        }

        [HttpGet("GetInvenTranById/{id}")]
        public async Task<IActionResult> GetInvenTranById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            return Ok(data);
        }

        [HttpPut("UpdateInvenTran/{id}")]
        public async Task<IActionResult> UpdateInvenTran(InvenTran item)
        {
            var data = await _service.UpdateAsync(item);
            return Ok(data);
        }
    }
}
