using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using RepairShop.Core.Entities.Request;

namespace RepairShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsReceiveController : ControllerBase
    {
        private readonly IGoodsReceiveService _service;
        private readonly IGenerateIdService _idservice;
        public GoodsReceiveController(IGoodsReceiveService service, IGenerateIdService idservice)
        {
            _service = service;
            _idservice = idservice;
        }

        [HttpGet("GetAllGoodsReceive")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpPost("CreateGoodsReceive")]
        public async Task<IActionResult> CreateGoodsReceive(GoodsReceiveRequest request)
        {
            var item = new GoodsReceive
            {
                AddedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                Number = _idservice.GenerateGRNumber()
            };
            var data = await _service.AddAsync(item);
            return Ok(data);
        }

        [HttpDelete("DeleteGoodsReceive/{id}")]
        public async Task<IActionResult> DeleteGoodsReceive(Guid id)
        {
            var data = await _service.DeleteAsync(id);
            return Ok(data);
        }

        [HttpGet("GetGoodsReceiveById/{id}")]
        public async Task<IActionResult> GetGoodsReceiveById(Guid id)
        {
            var data = await _service.GetByIdAsync(id);
            return Ok(data);
        }

        [HttpPut("UpdateGoodsReceive/{id}")]
        public async Task<IActionResult> UpdateGoodsReceive(GoodsReceive item)
        {
            var data = await _service.UpdateAsync(item);
            return Ok(data);
        }
    }
}
