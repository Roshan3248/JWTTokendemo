using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokendemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CurrencyController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("AddCurrency")]
        public IActionResult AddCurrency(Currency currency)
        {
            _context.Currencies.Add(currency);
            _context.SaveChanges();
            return Ok("Add Currency succesfully!");
        }
        [HttpGet("GetAllCurrency")]
        public IActionResult Currencies()
        {
            return Ok(_context.Currencies.ToList());
        }
    }
}
