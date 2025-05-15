using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokendemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SidebarController : ControllerBase
    {

        private readonly ISidebar _sidebar;

        public SidebarController(ISidebar sidebar)
        {
            _sidebar = sidebar;
        }

        [HttpPost("AddSidebar")]
        public IActionResult AddSidebar(Sidebar sidebar )
        {
            _sidebar.AddSidebar(sidebar);
            return Ok("Add Sidebar succesfully!");
        }

        [HttpGet("GetAllSidebar")]
        public IActionResult GetAllSidebar(int roleId)
        {
            if(roleId != 3)
            {
                return Ok(_sidebar.GetAllSidebar(roleId));
            }
            else
            {
                return Ok(new List<Sidebar>());
            }

        }

        [HttpPut("UpdateSidebar/{id}")]
        public IActionResult UpdateSidebar(Sidebar sidebar)
        {
            _sidebar.UpdateSidebar(sidebar);
            return Ok("Sidebar updated successfully!");
        }

        [HttpDelete("DeleteSidebar/{id}")]
        public IActionResult DeleteSidebar(int id)
        {
            _sidebar.DeleteSidebar(id);
            return Ok("Sidebar deleted successfully!");
        }
        [HttpGet("ChapterSidebar")]
        public IActionResult ChapterSidebar(int standardId, int subjectId)
        {
            return Ok(_sidebar.GetAllSidebarbyStandardIdandSubjectId(standardId, subjectId));
        }

    }

}
