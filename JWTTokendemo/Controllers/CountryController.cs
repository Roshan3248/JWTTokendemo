using JWTTokendemo.Data;
using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokendemo.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {

        private readonly ICountry _country;

        public CountryController(ICountry country) 
        {
            _country = country;
        }

        [HttpPost("AddCountry")]
        public IActionResult AddCountry(Country country)
        {
            _country.AddCountry(country);
            return Ok("Add Country succesfully!");
        }
        
        [HttpGet("GetAllCountry")]
        public IActionResult Countries()
        {
            return Ok(_country.GetAllCountry());
        }

        [HttpPut("UpdateCountry/{id}")]
        public IActionResult UpdateCountry(Country updatedCountry)
        {
            _country.UpdateCountry(updatedCountry);
            return Ok("Country updated successfully!");
        }

        [HttpDelete("DeleteCountry/{id}")]
        public IActionResult DeleteCountry(int id)
        {
            _country.DeleteCountry(id);
            return Ok("Country deleted successfully!");
        }

    }
}
