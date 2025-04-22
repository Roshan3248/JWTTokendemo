using JWTTokendemo.Data;
using JWTTokendemo.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokendemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public RoleController(ApplicationDbContext context)
        {
            _context = context;
            
        }
        [HttpPost]
        public IActionResult AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return Ok("Add Role succesfully!");
        }

    }
}
