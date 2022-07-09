using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;

namespace RepairShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateProduct(Product item)
        {
            item.AddedOn = DateTime.Now;
            item.ModifiedOn = DateTime.Now;
            var data = await _service.AddAsync(item);
            return Ok(data);
        }

        [HttpDelete("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var data = await _service.DeleteAsync(id);
            return Ok(data);
        }

        [HttpGet("GetProductById/{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var data = await _service.GetByIdAsync(id);
            return Ok(data);
        }

        [HttpPut("UpdateProduct/{id}")]
        public async Task<IActionResult> UpdateProduct(Product item)
        {
            var data = await _service.UpdateAsync(item);
            return Ok(data);
        }
    }
}
