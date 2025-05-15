using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data.Interface;

using Microsoft.AspNetCore.Mvc;

namespace JWTTokendemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {

        private readonly ISubject _subject;

        public SubjectController(ISubject subject)
        {
            _subject = subject;
        }

        [HttpPost("AddSubject")]
        public IActionResult AddSubject(Subject subject)
        {
            _subject.AddSubject(subject);
            return Ok("Add Subject succesfully!");
        }

        [HttpGet("GetAllSubject")]
        public IActionResult subjects()
        {
            return Ok(_subject.GetAllSubject());
        }

        [HttpPut("UpdateSubject/{id}")]
        public IActionResult UpdateSubject(Subject updatedSubject)
        {
            _subject.UpdateSubject(updatedSubject);
            return Ok("Subject updated successfully!");
        }

        [HttpDelete("DeleteSubject/{id}")]
        public IActionResult DeleteSubject(int id)
        {
            _subject.DeleteSubject(id);
            return Ok("Subject deleted successfully!");
        }

    }

}
