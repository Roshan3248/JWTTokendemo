using JWTTokendemo.Data;
using JWTTokendemo.Data.Entities;
using JWTTokendemo.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JWTTokendemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskMangerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public TaskMangerController(ApplicationDbContext context)
        {
            _context = context;

        }
        [HttpGet("GetAllTaskList")]
        public IActionResult GetAll()
        {
            var tasks = _context.TaskManagers.Include(t => t.User).Include(t => t.Status)
                .Select(t => new TaskListRequest
                {
                    Id = t.Id,
                    TaskName = t.TaskName,
                    FirstName = t.User.Firstname,
                    StatusName = t.Status.StatusName
                })
                .ToList();

            return Ok(tasks);
        }
        [HttpPost("AddTask")]
        public IActionResult AddTask(AddTaskRequest request)
        {
            
                var newTask = new TaskManager
                {
                    TaskName = request.TaskName,
                    TaskDescription=request.TaskDescription,
                    UserId = request.UserId,
                    StatusId = request.StatusId
                };

                _context.TaskManagers.Add(newTask);
                _context.SaveChanges();

                return Ok("Added new task successfully!");
            
        }




    }
}
