using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepairShop.Application.Interfaces;

namespace RepairShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdServiceController : ControllerBase
    {
        private readonly IGenerateIdService _service;

        public IdServiceController(IGenerateIdService service)
        {
            _service = service;
        }

        [HttpGet("GenerateGRNumber")]
        public ActionResult GenerateGRNumber()
        {
            var data = _service.GenerateGRNumber();
            return Ok(data);
        }

        [HttpGet("GeneratePONumber")]
        public ActionResult GeneratePONumber()
        {
            var data = _service.GeneratePONumber();
            return Ok(data);
        }


        [HttpGet("GenerateSONumber")]
        public ActionResult GenerateSONumber()
        {
            var data = _service.GenerateSONumber();
            return Ok(data);
        }


        [HttpGet("GenerateITNumber")]
        public ActionResult GenerateITNumber()
        {
            var data = _service.GenerateInvenTranNumber();
            return Ok(data);
        }
    }
}
