// using Labb2Webbutveckling.Models;
// using Microsoft.AspNetCore.Mvc;

// namespace Labb2Webbutveckling.Controllers
// {
//     [ApiController]
//     [Route("api/cities/{cityId}/pointsofinterest")]
//     public class PointsOfInterestController : ControllerBase
//     {
//         [HttpGet]
//         public ActionResult<IEnumerable<PointOfInterestDto>> GetPointsOfInterest(int cityId)
//         {
//             var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

//             if (city == null)
//             {
//                 return NotFound();
//             }
            
//             return Ok(city.PointsOfInterest);
//         }

//         [HttpGet("{pointofinterestid}")]

//         public ActionResult<PointOfInterestDto> GetPointsOfInterest(
//             int cityId, int pointofinterestid)
//             {
//                 var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

//             if (city == null)
//             {
//                 return NotFound();
//             }
//             }


//     }
// }