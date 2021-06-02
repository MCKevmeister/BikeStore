using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using BikeStoreApi.Services;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet ("Get")]
        [ActionName(nameof(GetManufacturerAsync))]
        public Task<Manufacturer> GetManufacturerAsync(string id) =>
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
        public IActionResult Update(string id, Manufacturer manufacturerIn)
        {
            var manufacturer = _manufacturerRepository.GetById(id);

            if (manufacturer == null)
            {
                return NotFound();
            }
            _manufacturerRepository.Update(manufacturerIn);
            return NoContent(); 
        }
        
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var manufacturer = await _manufacturerRepository.GetById(id);

            if (manufacturer == null)
            {
                return NotFound();
            }

            await _manufacturerRepository.Delete(manufacturer.Id.ToString());

            return NoContent();
        }
    }
}