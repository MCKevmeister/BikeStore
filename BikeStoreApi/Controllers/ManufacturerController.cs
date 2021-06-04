using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using BikeStoreApi.Repositories;
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

        [HttpGet("{name}", Name = "GetManufacturerAsync")]
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
                return BadRequest(new ManufacturerResponse(false, $"{manufacturer.Name} already exists"));
            
            var newManufacturer = await _manufacturerRepository.Create(name, cancellationToken);

            return Ok(new ManufacturerResponse(true,$"{newManufacturer.Name} created", newManufacturer));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateManufacturerAsync(UpdateManufacturer updateManufacturer, CancellationToken cancellationToken = default)
        {
            var oldManufacturerName = updateManufacturer.OldManufacturer.Name;
            
            var oldManufacturerCheck = await _manufacturerRepository.GetByName(oldManufacturerName);
            
            if (oldManufacturerCheck == null)
                return NotFound();

            var newManufacturerCheck = await _manufacturerRepository.GetByName(oldManufacturerName);

            if (newManufacturerCheck != null)
            {
                return BadRequest(new ManufacturerResponse(false, updateManufacturer.NewManufacturer.Name + " already exists"));
            }
            
            var response = await _manufacturerRepository.Update(updateManufacturer , cancellationToken);
            
            if (response.ErrorMessage != null)
                return BadRequest(new ManufacturerResponse(false, response.ErrorMessage));
            
            var updatedManufacturer = await _manufacturerRepository.GetByName(updateManufacturer.NewManufacturer.Name);
            
            return Ok(new ManufacturerResponse(updatedManufacturer));
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(string name, CancellationToken cancellationToken = default)
        {
            var manufacturer = await _manufacturerRepository.GetByName(name);

            if (manufacturer == null) 
                return NotFound();
            await _manufacturerRepository.Delete(manufacturer);

            var deletedManufacturer = await _manufacturerRepository.GetByName(name);
            if (deletedManufacturer == null)
            {
                return Ok(new ManufacturerResponse(true, $"{name} has been deleted"));
            }

            return BadRequest(new ManufacturerResponse(false, $"{name} was not deleted"));
        }
    }
}