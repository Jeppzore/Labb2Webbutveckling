// using Labb2Webbutveckling.Models;

// namespace Labb2Webbutveckling
// {
//     public class CitiesDataStore
//     {
//         public List<CityDto> Cities { get; set; }
//         public static CitiesDataStore Current { get; } = new CitiesDataStore(); 

//         // Constructor    
//         public CitiesDataStore()
//         {
//             // init dummy data
//             Cities = new List<CityDto>()
//             {
//                 new CityDto()
//                 {
//                     Id =1,
//                     Name = "New York City",
//                     Description = "The one with that big park",
//                     PointsOfInterest = new List<PointOfInterestDto>()
//                     {
//                         new PointOfInterestDto(){
//                             Id = 1,
//                             Name = "Central Park",
//                             Description = "Big park!"
//                         },

//                         new PointOfInterestDto(){
//                             Id = 2,
//                             Name = "Empite state building",
//                             Description = "102 stories"
//                         }
//                     }
//                 },
//                 new CityDto()
//                 {
//                     Id =2,
//                     Name = "Antwerp",
//                     Description = "Cathedral",
//                     PointsOfInterest = new List<PointOfInterestDto>()
//                     {
//                         new PointOfInterestDto(){
//                             Id = 3,
//                             Name = "Big Cathedral",
//                             Description = "Unfisinished Cathedral"
//                         },

//                         new PointOfInterestDto(){
//                             Id = 4,
//                             Name = "Park Bench",
//                             Description = "Very wooden"
//                         }
//                     }
//                 },
//                 new CityDto()
//                 {
//                     Id =3,
//                     Name = "Paris",
//                     Description = "Big Tower",
//                     PointsOfInterest = new List<PointOfInterestDto>()
//                     {
//                         new PointOfInterestDto(){
//                             Id = 5,
//                             Name = "Eiffel Tower",
//                             Description = "Tourist attraction"
//                         },

//                         new PointOfInterestDto(){
//                             Id = 6,
//                             Name = "Moulin Rogue",
//                             Description = "Veri nice"
//                         }
//                     }
//                 }
//             };
//         }

//     }

// }