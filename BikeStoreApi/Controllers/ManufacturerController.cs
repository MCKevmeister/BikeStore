using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace BikeStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturerController(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }

        [HttpGet("{id:length(24)}")]
        [ActionName(nameof(GetManufacturerAsync))]
        public async Task<Manufacturer> GetManufacturerAsync(string id)
        {
            var objId = new ObjectId(id);
            var manufacturer = await _manufacturerRepository.GetById(objId);
            return manufacturer;
        }
           

        [HttpGet("GetAll")]
        
        public async Task<IEnumerable<Manufacturer>> GetAll() =>
            await _manufacturerRepository.GetAll();

        [HttpPost]
        public async Task<ActionResult<Manufacturer>>Create(Manufacturer manufacturer)
        {
            await _manufacturerRepository.Create(manufacturer);

            return CreatedAtRoute(nameof(GetManufacturerAsync), new {id = manufacturer.Id.ToString()}, manufacturer);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(ObjectId id)
        {
            var manufacturer = await _manufacturerRepository.GetById(id);

            if (manufacturer == null)
            {
                return NotFound();
            }
            await _manufacturerRepository.Update(manufacturer);
            
            return NoContent();
        }
        
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var objId = new ObjectId(id);
            var manufacturer = await _manufacturerRepository.GetById(objId);

            if (manufacturer == null)
            {
                return NotFound();
            }

            await _manufacturerRepository.Delete(manufacturer.Id);

            return NoContent();
        }
    }
}