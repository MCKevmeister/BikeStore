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

        [HttpGet("{name}", Name = "GetManufacturerAsync")]
        [ActionName(nameof(GetManufacturerAsync))]
        public async Task<IActionResult> GetManufacturerAsync(string name, CancellationToken cancellationToken = default)
        {
            var matchedManufacturer = await _manufacturerRepository.GetByName(name);
            if (matchedManufacturer == null) 
                return BadRequest(new ArgumentException($"Can not find {name}"));
            return Ok(new ManufacturerResponse(matchedManufacturer));
        }
        
        [HttpGet("GetAll")]
        public async Task<IEnumerable<Manufacturer>> GetAll(CancellationToken cancellationToken = default) =>
            await _manufacturerRepository.GetAll();

        [HttpPost("Create")]
        public async Task<ActionResult<Manufacturer>> Create(string name, CancellationToken cancellationToken = default)
        {
            var manufacturer = await _manufacturerRepository.GetByName(name);

            if (manufacturer != null)
                return BadRequest(manufacturer + " already exists");
            
            var newManufacturer = new Manufacturer(name);
            
            await _manufacturerRepository.Create(newManufacturer);

            return CreatedAtRoute("GetManufacturerAsync", new { newManufacturer.Name }, newManufacturer);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateManufacturerAsync(string name,[FromBody] PreferencesObject preferences, CancellationToken cancellationToken = default)
        {
            var manufacturer = await _manufacturerRepository.GetByName(name);
            if (manufacturer == null)
            {
                return NotFound();
            }
            
            var response = await _manufacturerRepository.Update(manufacturer, preferences.Preferences, cancellationToken);
            if (response.Success)
            {
                var updatedManufacturer = await _manufacturerRepository.GetByName(manufacturer.Name);
                return Ok(new ManufacturerResponse(updatedManufacturer));
            }
            return BadRequest(new ManufacturerResponse(false, ""));
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(string name, CancellationToken cancellationToken = default)
        {
            var manufacturer = await _manufacturerRepository.GetByName(name);
            
            if (manufacturer == null)
            {
                return NotFound();
            }
            await _manufacturerRepository.Delete(manufacturer);
            
            return Ok();
        }
    }
    public class PreferencesObject
    {
        public Dictionary<string, string> Preferences { get; set; }
    }
}