using Microsoft.AspNetCore.Mvc;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using BikeStoreApi.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models.Responses;

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
            _unitOfWork = unitOfWork;
            _manufacturerRepository = manufacturerRepository;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Manufacturer>>> GetAll()
        {
            var manufacturers = await _manufacturerRepository.GetAll();
            return Ok(manufacturers);
        }
        
        [HttpGet("{id}", Name = "GetManufacturerAsync")]
        public async Task<ActionResult<Manufacturer>> Get(string id)
        {
            var manufacturer = await _manufacturerRepository.GetById(id);
            if (manufacturer == null)
            {
                return BadRequest();
            }
            return Ok(manufacturer);
        }
        
        [HttpPost]
        public async Task<ActionResult<Manufacturer>> Create(Manufacturer manufacturer)
        {
            _manufacturerRepository.Create(manufacturer);
            await _unitOfWork.Commit();
            var newManufacturer = await _manufacturerRepository.GetById(manufacturer.Id);
            if (newManufacturer == null)
            {
                return BadRequest(new ManufacturerResponse(false, $"{manufacturer.Name} could not be created"));
            }
            return Ok(newManufacturer);
        }
        
        [HttpPut]
        public async /*Task<IActionResult>*/Task<ActionResult<Manufacturer>> UpdateManufacturerAsync(Manufacturer manufacturer)
        {
            var oldManufacturerCheck = await _manufacturerRepository.GetById(manufacturer.Id);
            if (oldManufacturerCheck == null) // and an or conditional check to make sure that the manufacturer isn't already in db, get all and check unique
                return NotFound();
            _manufacturerRepository.Update(manufacturer, manufacturer.Id); 
            //cannot access the id in base repository, passing it here
            await _unitOfWork.Commit();
            return Ok(manufacturer);
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var manufacturerToDelete = await _manufacturerRepository.GetById(id);
            if (manufacturerToDelete == null)
                return BadRequest();
            _manufacturerRepository.Delete(id);
            await _unitOfWork.Commit();
            var deletedManufacturer = await _manufacturerRepository.GetById(id);
            if (deletedManufacturer == null)
            {
                return Ok();
            }
            return BadRequest(new ManufacturerResponse(false, $"{manufacturerToDelete.Name} was not deleted", deletedManufacturer));
        }
    }   
}
/*using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStore.Models.Responses;
using BikeStoreApi.Repositories;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult> Create(Manufacturer manufacturer)
        {
            var manufacturerCheck = await _manufacturerRepository.Get(manufacturer.Name);
            if (manufacturerCheck != null)
                return BadRequest(new ManufacturerResponse(false, $"{manufacturer.Name} already exists"));
            var newManufacturer = await _manufacturerRepository.Create(manufacturer);
            if (newManufacturer == null)
            {
                return BadRequest(new ManufacturerResponse(false, $"{manufacturer.Name} could not be created"));
            }
            return Ok(new ManufacturerResponse(true, $"{newManufacturer.Name} created", newManufacturer));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateManufacturerAsync(UpdateManufacturer updateManufacturer) // should this get 2 objects the old and new manufacturer object?
        {
            var oldManufacturerCheck = await _manufacturerRepository.Get(updateManufacturer.OldManufacturer.Name); // should be by Id
            if (oldManufacturerCheck == null)
                return NotFound(new ManufacturerResponse(false,
                    updateManufacturer.OldManufacturer.Name + " doesn't exist"));
            var newManufacturerCheck = await _manufacturerRepository.Get(updateManufacturer.NewManufacturer.Name); // this check is fine if the above passes
            if (newManufacturerCheck != null)
            {
                return BadRequest(new ManufacturerResponse(false,
                    updateManufacturer.NewManufacturer.Name + " already exists"));
            }
            var response = await _manufacturerRepository.Update(updateManufacturer.NewManufacturer);
            if (response!= null)
            {
                return BadRequest(new ManufacturerResponse(false, $""));
            }
            var updatedManufacturer =
                await  _manufacturerRepository.Get(updateManufacturer.NewManufacturer.Name);
            return Ok(new ManufacturerResponse(true , updateManufacturer.NewManufacturer.Name + " has been updated", updatedManufacturer));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Manufacturer manufacturer)
        {
            var manufacturerToDelete = await _manufacturerRepository.Get(manufacturer.Name);
            if (manufacturerToDelete == null)
                return BadRequest(new ManufacturerResponse(true, $"{manufacturer.Name} has been does not exist"));
            await _manufacturerRepository.Delete(manufacturerToDelete);
            var deletedManufacturer = await _manufacturerRepository.Get(manufacturer.Name);
            if (deletedManufacturer == null)
            {
                return Ok(new ManufacturerResponse(true, $"{manufacturer.Name} has been deleted"));
            }
            return BadRequest(new ManufacturerResponse(false, $"{manufacturer.Name} was not deleted"));
        }
    }
}*/