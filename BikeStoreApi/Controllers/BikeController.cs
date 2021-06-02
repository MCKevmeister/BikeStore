// using System.Collections.Generic;
// using System.Threading.Tasks;
// using BikeStore.Models;
// using BikeStoreApi.Services;
// using Microsoft.AspNetCore.Mvc;
// using MongoDB.Bson;
//
// namespace BikeStoreApi.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class BikesController : ControllerBase
//     {
//         private readonly BikeService _bikeService;
//
//         public BikesController(BikeService bikeService)
//         {
//             _bikeService = bikeService;
//         }
//
//         [HttpGet (Name = "GetAllBikes")]
//         public async Task<ActionResult<List<Bike>>> GetAllBikes() =>
//             await _bikeService.Get();
//
//         [HttpGet]
//         [ActionName(nameof(GetBikeAsync))]
//         public async Task<ActionResult<Bike>> GetBikeAsync(string name)
//         {
//             var bike = await _bikeService.Get(name);
//
//             if (bike == null)
//             {
//                 return NotFound();
//             }
//             return bike;
//         }
//
//         [HttpPost]
//         public async Task<ActionResult<Bike>> Create(Bike bike)
//         {
//             await _bikeService.Create(bike);
//
//             return CreatedAtRoute("GetBikeAsync", new { id = bike.Id }, bike);
//         }
//
//         [HttpPut]
//         public async Task<IActionResult> Update(string name)
//         {
//             var bike = await _bikeService.Get(name);
//             
//             if (bike == null)
//             {
//                 return NotFound(); //todo make better exception throw
//             }
//
//             await _bikeService.Update(name, bike);
//
//             return NoContent();
//         }
//         
//         [HttpDelete]
//         public async Task<IActionResult> Delete(string name)
//         {
//             var bike = await _bikeService.Get(name);
//
//             if (bike == null)
//             {
//                 return NotFound();
//             }
//
//             await _bikeService.Remove(bike);
//
//             return NoContent();
//         }
//     }
// }
//
