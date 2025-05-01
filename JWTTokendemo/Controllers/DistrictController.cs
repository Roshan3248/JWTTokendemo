using JWTTokendemo.Data;
using JWTTokendemo.Data.Entities;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JWTTokendemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DistrictController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost("AddDistrict")]
        public IActionResult AddDistrict(District district)
        {
            _context.Districts.Add(district);
            _context.SaveChanges();
            return Ok("District added successfully!");
        }
        //[HttpGet("GetAllDistrict")]
        //public IActionResult GetAll()
        //{
        //    var tasks = _context.TaskManagers.Include(t => t.User).Include(t => t.Status)
        //        .Select(t => new TaskRequest
        //        {
        //            Id = t.Id,
        //            TaskName = t.TaskName,
        //            FirstName = t.User.Firstname,
        //            StatusName = t.Status.StatusName,
        //            TaskDescription = t.TaskDescription,
        //            UserId = t.User.Id,
        //            StatusId = t.Status.Id,
        //        })
        //        .ToList();

        //    return Ok(tasks);
        //}

    }
}
