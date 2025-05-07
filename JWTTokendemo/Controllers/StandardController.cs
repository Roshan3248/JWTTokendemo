using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace JWTTokendemo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StandardController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public StandardController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("AddStandard")]
        public IActionResult AddStandard(Standard standard)
        {
            _context.Standards.Add(standard);
            _context.SaveChanges();
            return Ok("Add Standard succesfully!");
        }

        [HttpGet("GetAllStandard")]
        public IActionResult standards()
        {
            return Ok(_context.Standards.ToList());
        }
    }
}
