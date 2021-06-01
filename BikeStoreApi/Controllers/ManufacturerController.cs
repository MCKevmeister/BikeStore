using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _manufacturerService;

        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        [HttpGet]
        public ActionResult<List<Manufacturer>> Get() =>
            _manufacturerService.Get();

        [HttpPost]
        public ActionResult<Manufacturer> Create(Manufacturer manufacturer)
        {
            _manufacturerService.Create(manufacturer);

            return CreatedAtRoute("GetManufacturer", new {id = manufacturer.Id}, manufacturer);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Manufacturer manufacturerIn)
        {
            var manufacturer = _manufacturerService.Get(id);

            if (manufacturer == null)
            {
                return NotFound();
            }
            _manufacturerService.Update(id, manufacturerIn);
            return NoContent(); 
        }
    }
}