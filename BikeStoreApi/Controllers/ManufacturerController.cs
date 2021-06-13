using Microsoft.AspNetCore.Mvc;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using BikeStoreApi.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models.Responses;

namespace BikeStoreApi.Controllers
{
    [ApiController]
    [Route("api/Manufacturer")]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerRepository _manufacturerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ManufacturerController(IUnitOfWork unitOfWork, IManufacturerRepository manufacturerRepository)
        {
            _unitOfWork = unitOfWork;
            _manufacturerRepository = manufacturerRepository;
        }
        
        [HttpGet("GetAll")]
        public async Task<IEnumerable<Manufacturer>> GetAll()
        {
            var manufacturers = await _manufacturerRepository.GetAll();
            return manufacturers;
        }
        
        [HttpGet("Get/{id}")]
        public async Task<ActionResult<Manufacturer>> Get(string id)
        {
            var manufacturer = await _manufacturerRepository.GetById(id);
            if (manufacturer == null)
            {
                return BadRequest();
            }
            return Ok(manufacturer);
        }
        
        [HttpPost("Create")]
        public async Task<ActionResult<Manufacturer>> Create([FromBody]Manufacturer manufacturer)
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
        
        [HttpPut("Edit")]
        public async Task<ActionResult<Manufacturer>> UpdateManufacturerAsync([FromBody]Manufacturer manufacturer)
        {
            var oldManufacturerCheck = await _manufacturerRepository.GetById(manufacturer.Id);
            if (oldManufacturerCheck == null) // and an or conditional check to make sure that the manufacturer isn't already in db, get all and check unique
                return NotFound();
            _manufacturerRepository.Update(manufacturer, manufacturer.Id); 
            //cannot access the id in base repository, passing it here
            await _unitOfWork.Commit();
            return Ok(manufacturer);
        }
        
        [HttpDelete("Delete/{id}")]
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