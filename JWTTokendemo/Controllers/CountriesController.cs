using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace JWTTokendemo.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CountriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("AddCountry")]
        public IActionResult AddCountry(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
            return Ok("Add Country succesfully!");
        }
        [AllowAnonymous]
        [HttpGet("GetAllCountry")]
        public IActionResult Countries()
        {
            return Ok(_context.Countries.OrderBy(x=>x.Name).ToList());
        }

    }
}
