/*using System.Collections.Generic;
using BikeStore.Models;
using BikeStoreApi.Services;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult<List<Bike>> Get() =>
            _bikeService.Get();

        [HttpGet("{id:length(24)}", Name = "GetBike")]
        public ActionResult<Bike> Get(string id)
        {
            var bike = _bikeService.Get(id);

            if (bike == null)
            {
                return NotFound();
            }

            return bike;
        }

        [HttpPost]
        public ActionResult<Bike> Create(Bike bike)
        {
            _bikeService.Create(bike);

            return CreatedAtRoute("GetBike", new { id = bike.Id.ToString() }, bike);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Bike bikeIn)
        {
            var bike = _bikeService.Get(id);

            if (bike == null)
            {
                return NotFound();
            }

            _bikeService.Update(id, bikeIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var bike = _bikeService.Get(id);

            if (bike == null)
            {
                return NotFound();
            }

            _bikeService.Remove(bike.Id);

            return NoContent();
        }
    }
}*/