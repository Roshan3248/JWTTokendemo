using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokendemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserRoleController(ApplicationDbContext context)
        {
            _context = context;

        }
        [HttpPost("UserRole")]
        public IActionResult AddUserRole(UserRole userRole)
        {
            _context.UserRoles.Add(userRole);
            _context.SaveChanges();
            return Ok("Added User Role succesfully!");
        }
    }
}
