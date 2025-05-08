using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokendemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterController : ControllerBase
    {

        private readonly IChapter _chapter;

        public ChapterController(IChapter chapter)
        {
            _chapter = chapter;
        }

        [HttpPost("AddChapter")]
        public IActionResult AddChapter(Chapter chapter)
        {
            _chapter.AddChapter(chapter);
            return Ok("Add Chapter succesfully!");
        }

        [HttpGet("GetAllChapter")]
        public IActionResult chapters()
        {
            return Ok(_chapter.GetAllChapter());
        }

        [HttpPut("UpdateChapter/{id}")]
        public IActionResult UpdateChapter(Chapter updatedChapter)
        {
            _chapter.UpdateChapter(updatedChapter);
            return Ok("Chapter updated successfully!");
        }

        [HttpDelete("DeleteChapter/{id}")]
        public IActionResult DeleteChapter(int id)
        {
            _chapter.DeleteChapter(id);
            return Ok("Chapter deleted successfully!");
        }

    }

}
