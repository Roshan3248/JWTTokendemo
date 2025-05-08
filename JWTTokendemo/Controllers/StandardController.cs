using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokendemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StandardController : ControllerBase
    {

        private readonly IStandard _standard;

        public StandardController(IStandard standard)
        {
            _standard = standard;
        }

        [HttpPost("AddStandard")]
        public IActionResult AddStandard(Standard standard)
        {
            _standard.AddStandard(standard);
            return Ok("Add Standard succesfully!");
        }

        [HttpGet("GetAllStandard")]
        public IActionResult standards()
        {
            return Ok(_standard.GetAllStandard());
        }

        [HttpPut("UpdateStandard/{id}")]
        public IActionResult UpdateStandard(Standard updatedStandard)
        {
            _standard.UpdateStandard(updatedStandard);
            return Ok("Standard updated successfully!");
        }

        [HttpDelete("DeleteStandard/{id}")]
        public IActionResult DeleteStandard(int id)
        {
            _standard.DeleteStandard(id);
            return Ok("Standard deleted successfully!");
        }

    }

}
