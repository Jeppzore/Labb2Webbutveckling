using Microsoft.AspNetCore.Mvc;

namespace Labb2Webbutveckling.Controllers
{
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object> {
                    new { id = 1, Name = "New York City" },
                    new { id = 2, Name = "Antwerp" },

                });
        }    
    }
}