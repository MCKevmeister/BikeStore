using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using BikeStoreApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

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

        [HttpGet]
        [ActionName(nameof(GetManufacturerAsync))]
        public async Task<ActionResult> GetManufacturerAsync(string name)
        {
            var matchedManufacturer = await _manufacturerRepository.GetByName(name);
            if (matchedManufacturer == null) 
                return BadRequest(new ArgumentException(($"Can not find {name}")));
            return Ok(new ManufacturerResponse(matchedManufacturer));

            // var filter = Builders<Manufacturer>.Filter.Eq("name", name);
            // var result = await _manufacturerCollection.FindAsync(filter);
            // return result;
            //
            // var objId = new ObjectId(id.ToString());
            // var manufacturer = await _manufacturerRepository.GetByName(objId);
            // return manufacturer;
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
        public async Task<IActionResult> Update(string id)
        {
            var manufacturer = await _manufacturerRepository.GetByName(id);

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
            var manufacturer = await _manufacturerRepository.GetByName(id);

            if (manufacturer == null)
            {
                return NotFound();
            }

            await _manufacturerRepository.Delete(manufacturer.Id);

            return NoContent();
        }
    }
}