using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using BikeStoreApi.Repositories;
using BikeStoreApi.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerRepository _manufacturerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ManufacturerController(IUnitOfWork unitOfWork, IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "GetManufacturerAsync")]
        public async Task<IActionResult> GetManufacturer(string name)
        {
            var newManufacturer = await _manufacturerRepository.Get(name);
            if (newManufacturer == null)
            {
                return BadRequest(new ArgumentException($"Can not find {name}"));
            }
            return Ok(new ManufacturerResponse(true,"" ,newManufacturer));
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Manufacturer>>> GetAll()
        {
            var manufacturers = await _manufacturerRepository.GetAll();
            return Ok(manufacturers);
        }

        [HttpPost]
        public async Task<ActionResult<Manufacturer>> Create(Manufacturer manufacturer)
        {
            var manufacturerCheck = await _manufacturerRepository.Get(manufacturer.Name);
            if (manufacturerCheck != null)
                return BadRequest(new ManufacturerResponse(false, $"{manufacturer.Name} already exists"));
            var newManufacturer = await _manufacturerRepository.Create(manufacturer);
            _unitOfWork.Commit();
            var newManufacturerCheck = await _manufacturerRepository.Get(manufacturer.Name);
            if (newManufacturerCheck == null)
            {
                return BadRequest(new ManufacturerResponse(false, $"{newManufacturer.Name} could not be created"));
            }

            return Ok(new ManufacturerResponse(true, $"{newManufacturer.Name} created", newManufacturer));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateManufacturerAsync(UpdateManufacturer updateManufacturer)
        {
            return null;
            /*
            var oldManufacturerCheck = await _manufacturerRepository.Get(updateManufacturer.OldManufacturer.Name);
            if (oldManufacturerCheck == null)
                return NotFound(new ManufacturerResponse(false,
                    updateManufacturer.OldManufacturer.Name + " doesn't exist"));
            var newManufacturerCheck = await _manufacturerRepository.Get(updateManufacturer.NewManufacturer.Name);
            if (newManufacturerCheck != null)
            {
                return BadRequest(new ManufacturerResponse(false,
                    updateManufacturer.NewManufacturer.Name + " already exists"));
            }
            var response = await _manufacturerRepository.Update(updateManufacturer);
            _unitOfWork.Commit();
            if (response.ErrorMessage != null)
            {
                return BadRequest(new ManufacturerResponse(false, response.ErrorMessage));
            }
            var updatedManufacturer =
                await _manufacturerRepository.Get(updateManufacturer.NewManufacturer.Name);
            return Ok(new ManufacturerResponse(true , updateManufacturer.NewManufacturer.Name + " has been updated", updatedManufacturer));*/
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Manufacturer manufacturer)
        {
            var manufacturerToDelete = await _manufacturerRepository.Get(manufacturer.Name);
            if (manufacturerToDelete == null)
                return BadRequest(new ManufacturerResponse(true, $"{manufacturer.Name} has been does not exist"));
            await _manufacturerRepository.Delete(manufacturerToDelete);
            _unitOfWork.Commit();
            var deletedManufacturer = await _manufacturerRepository.Get(manufacturer.Name);
            if (deletedManufacturer == null)
            {
                return Ok(new ManufacturerResponse(true, $"{manufacturer.Name} has been deleted"));
            }
            return BadRequest(new ManufacturerResponse(false, $"{manufacturer.Name} was not deleted"));
        }
    }
}