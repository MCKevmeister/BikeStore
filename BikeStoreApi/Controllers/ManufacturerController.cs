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

        [HttpGet ("{id:length(24)}")]
        [ActionName(nameof(GetManufacturerAsync))]
        public Task<Manufacturer> GetManufacturerAsync(ObjectId id) =>
            _manufacturerRepository.GetById(id);

        [HttpGet("GetAll")]
        
        public async Task<IEnumerable<Manufacturer>> GetAll() =>
            await _manufacturerRepository.GetAll();

        [HttpPost]
        public ActionResult<Manufacturer> Create(Manufacturer manufacturer)
        {
            _manufacturerRepository.Create(manufacturer);

            return CreatedAtRoute(nameof(GetManufacturerAsync), new {id = manufacturer.Id}, manufacturer);
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