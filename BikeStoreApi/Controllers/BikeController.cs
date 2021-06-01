// using System.Collections.Generic;
// using System.Threading.Tasks;
// using BikeStore.Models;
// using BikeStoreApi.Services;
// using Microsoft.AspNetCore.Mvc;
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
//         [HttpGet]
//         public ActionResult<List<Bike>> Get() =>
//             _bikeService.Get();
//
//         [HttpGet("{id:length(24)}", Name = "GetBike")]
//         public async Task<ActionResult<Bike>> Get(string id)
//         {
//             var bike = await _bikeService.Get(id);
//
//             if (bike == null)
//             {
//                 return NotFound();
//             }
//
//             return bike;
//         }
//
//         [HttpPost]
//         public ActionResult<Bike> Create(Bike bike)
//         {
//             _bikeService.Create(bike);
//
//             return CreatedAtRoute("GetBike", new { id = bike.Id }, bike);
//         }
//
//         [HttpPut("{id:length(24)}")]
//         public IActionResult Update(string id, Bike bikeIn)
//         {
//             var bike = _bikeService.Get(id);
//
//             if (bike == null)
//             {
//                 return NotFound();
//             }
//
//             _bikeService.Update(id, bikeIn);
//
//             return NoContent();
//         }
//         
//         [HttpDelete("{id:length(24)}")]
//         public async Task<IActionResult> Delete(string id)
//         {
//             var bike = await _bikeService.Get(id);
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