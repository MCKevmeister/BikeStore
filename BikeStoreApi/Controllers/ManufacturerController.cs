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
        public async Task<IActionResult> GetManufacturerAsync(string name)
        {
            var matchedManufacturer = await _manufacturerRepository.GetByName(name);
            if (matchedManufacturer == null) 
                return BadRequest(new ArgumentException($"Can not find {name}"));
            return Ok(new ManufacturerResponse(matchedManufacturer));
        }
        
        [HttpGet("GetAll")]
        public async Task<IEnumerable<Manufacturer>> GetAll() =>
            await _manufacturerRepository.GetAll();

        [HttpPost("Create")]
        public async Task<ActionResult<Manufacturer>>Create(string name)
        {
            var newManufacturer = new Manufacturer(name);
            
            var manufacturer = await _manufacturerRepository.GetByName(name);

            if (manufacturer != null)
                return BadRequest(manufacturer + " already exists");
            await _manufacturerRepository.Create(newManufacturer);

            return CreatedAtRoute("GetManufacturerAsync", new { newManufacturer.Name }, name);
        }

        [HttpPut]
        public async Task<IActionResult> Update(string name, string newName)
        {
            var manufacturer = await _manufacturerRepository.GetByName(name);
            
            if (manufacturer == null)
            {
                return NotFound();
            }

            var manufacturerUpdate = new Manufacturer(newName);
            
            var updatedManufacturer = await _manufacturerRepository.Update(manufacturer, manufacturerUpdate);
            
            return Ok(updatedManufacturer);
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(string name)
        {
            var manufacturer = await _manufacturerRepository.GetByName(name);
            
            if (manufacturer == null)
            {
                return NotFound();
            }
            await _manufacturerRepository.Delete(manufacturer.Id);
            
            return Ok();
        }
    }
}