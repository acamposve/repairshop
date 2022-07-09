using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;

namespace RepairShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsReceiveLineController : ControllerBase
    {
        private readonly IGoodsReceiveLineService _service;
        public GoodsReceiveLineController(IGoodsReceiveLineService service)
        {
            _service = service;
        }

        [HttpGet("GetAllGoodsReceiveLine")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpPost("CreateGoodsReceiveLine")]
        public async Task<IActionResult> CreateGoodsReceiveLine(GoodsReceiveLine item)
        {
            item.AddedOn = DateTime.Now;
            item.ModifiedOn = DateTime.Now;
            var data = await _service.AddAsync(item);
            return Ok(data);
        }

        [HttpDelete("DeleteGoodsReceiveLine/{id}")]
        public async Task<IActionResult> DeleteGoodsReceiveLine(Guid id)
        {
            var data = await _service.DeleteAsync(id);
            return Ok(data);
        }

        [HttpGet("GetGoodsReceiveLineById/{id}")]
        public async Task<IActionResult> GetGoodsReceiveLineById(Guid id)
        {
            var data = await _service.GetByIdAsync(id);
            return Ok(data);
        }

        [HttpPut("UpdateGoodsReceiveLine/{id}")]
        public async Task<IActionResult> UpdateGoodsReceiveLine(GoodsReceiveLine item)
        {
            var data = await _service.UpdateAsync(item);
            return Ok(data);
        }
    }
}
