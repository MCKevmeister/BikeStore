using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStoreApi.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace BikeStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikesController : ControllerBase
    {
        private readonly BikeService _bikeService;

        public BikesController(BikeService bikeService)
        {
            _bikeService = bikeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Bike>>> Get() =>
            await _bikeService.Get();

        [HttpGet("{id:length(24)}", Name = "GetBike")]
        public async Task<ActionResult<Bike>> Get(ObjectId id)
        {
            var bike = await _bikeService.Get(id);

            if (bike == null)
            {
                return NotFound();
            }
            return bike;
        }

        [HttpPost]
        public async Task<ActionResult<Bike>> Create(Bike bike)
        {
            await _bikeService.Create(bike);

            return CreatedAtRoute("GetBike", new { id = bike.Id }, bike);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(ObjectId id)
        {
            var bike = await _bikeService.Get(id);

            if (bike == null)
            {
                return NotFound();
            }

            await _bikeService.Update(id, bike);

            return NoContent();
        }
        
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(ObjectId id)
        {
            var bike = await _bikeService.Get(id);

            if (bike == null)
            {
                return NotFound();
            }

            await _bikeService.Remove(bike);

            return NoContent();
        }
    }
}

