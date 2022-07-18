using Microsoft.AspNetCore.Mvc;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using RepairShop.Core.Entities.Request;

namespace RepairShop.API.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet("GetAllCustomers")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpPost("CreateCustomer")]
        public async Task<IActionResult> CreateCustomer(CustomerRequest request)
        {
            var data = await _service.AddAsync(request);
            return Ok(data);
        }

        [HttpDelete("DeleteCustomer/{id}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            var data = await _service.DeleteAsync(id);
            return Ok(data);
        }

        [HttpGet("GetCustomerById/{id}")]
        public async Task<IActionResult> GetCustomerById(Guid id)
        {
            var data = await _service.GetByIdAsync(id);
            return Ok(data);
        }

        [HttpPut("UpdateCustomer/{id}")]
        public async Task<IActionResult> UpdateCustomer(Guid id, Customer item)
        {
            var data = await _service.UpdateAsync(id, item);
            return Ok(data);
        }
    }
}
