using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using BikeStoreApi.Repositories;
using BikeStoreApi.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace BikeStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IMongoContext _context;
        
        public ManufacturerController(IMongoContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetManufacturerAsync")]
        public async Task<IActionResult> GetManufacturerAsync(Manufacturer manufacturer)
        {
            using var unitOfWork = new UnitOfWork(_context);
            {
                var service = new ManufacturerService(unitOfWork);
                var newManufacturer = await service.Get(manufacturer);
                var createdManufacturer = await unitOfWork.ManufacturerRepository.GetByName(newManufacturer.Name);
                if (createdManufacturer == null)
                {
                    return BadRequest(new ArgumentException($"Can not find {manufacturer.Name}"));
                }
                return Ok(new ManufacturerResponse(createdManufacturer));
            }
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Manufacturer>> GetAll()
        {
            using var unitOfWork = new UnitOfWork(_context);
            {
                var service = new ManufacturerService(unitOfWork);
                return await service.GetAll();
            }
        }
        
        [HttpPost("Create")]
        public async Task<ActionResult<Manufacturer>> Create(Manufacturer manufacturer)
        {
            using var unitOfWork = new UnitOfWork(_context);
            {
                var service = new ManufacturerService(unitOfWork);
                var manufacturerCheck = await service.Get(manufacturer);
                if (manufacturerCheck != null)
                    return BadRequest(new ManufacturerResponse(false, $"{manufacturer.Name} already exists"));
                var newManufacturer = await service.Create(manufacturer);
                var newManufacturerCheck = await service.Get(manufacturer);
                if (newManufacturerCheck == null) 
                {
                    return BadRequest(new ManufacturerResponse(false, $"{newManufacturer.Name} could not be created"));
                }
                return Ok(new ManufacturerResponse(true, $"{newManufacturer.Name} created", newManufacturer));
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateManufacturerAsync(UpdateManufacturer updateManufacturer)
        {
            using var unitOfWork = new UnitOfWork(_context);
            {
                var service = new ManufacturerService(unitOfWork);
                var oldManufacturerCheck = await service.Get(updateManufacturer.OldManufacturer);
                if (oldManufacturerCheck == null)
                    return NotFound(new ManufacturerResponse(false, updateManufacturer.OldManufacturer.Name + " doesn't exist"));
                var newManufacturerCheck = await service.Get(updateManufacturer.NewManufacturer);
                if (newManufacturerCheck != null)
                {
                    return BadRequest(new ManufacturerResponse(false, updateManufacturer.NewManufacturer.Name + " already exists"));
                }
                var response = await service.Update(updateManufacturer);
                if (response.ErrorMessage != null)
                {
                    return BadRequest(new ManufacturerResponse(false, response.ErrorMessage));
                }
                var updatedManufacturer =
                    await service.Get(updateManufacturer.NewManufacturer);
                return Ok(new ManufacturerResponse(updatedManufacturer));
            }
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(Manufacturer manufacturer)
        {
            using var unitOfWork = new UnitOfWork(_context);
            {
                var service = new ManufacturerService(unitOfWork);
                var manufacturerToDelete = await service.Get(manufacturer);
                if (manufacturerToDelete == null)
                    return BadRequest(new ManufacturerResponse(true, $"{manufacturer.Name} has been does not exist"));
                await service.Remove(manufacturerToDelete);

                var deletedManufacturer = await service.Get(manufacturer);
                if (deletedManufacturer == null)
                {
                    return Ok(new ManufacturerResponse(true, $"{manufacturer.Name} has been deleted"));
                }
                return BadRequest(new ManufacturerResponse(false, $"{manufacturer.Name} was not deleted"));
            }
        }
    }
}