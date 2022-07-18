using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;

namespace RepairShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendorService _service;
        public VendorController(IVendorService service)
        {
            _service = service;
        }

        [HttpGet("GetAllVendors")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpPost("CreateVendor")]
        public async Task<IActionResult> CreateVendor(Vendor item)
        {
            item.AddedOn = DateTime.Now;
            item.ModifiedOn = DateTime.Now;
            var data = await _service.AddAsync(item);
            return Ok(data);
        }

        [HttpDelete("DeleteVendor/{id}")]
        public async Task<IActionResult> DeleteVendor(Guid id)
        {
            var data = await _service.DeleteAsync(id);
            return Ok(data);
        }

        [HttpGet("GetVendorById/{id}")]
        public async Task<IActionResult> GetVendorById(Guid id)
        {
            var data = await _service.GetByIdAsync(id);
            return Ok(data);
        }

        [HttpPut("UpdateVendor/{id}")]
        public async Task<IActionResult> UpdateVendor(Guid id, Vendor item)
        {
            var data = await _service.UpdateAsync(id, item);
            return Ok(data);
        }
    }
}
