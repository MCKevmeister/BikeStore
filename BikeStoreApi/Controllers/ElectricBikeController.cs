using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using BikeStoreApi.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoreApi.Controllers
{
    [Route("api/ElectricBike")]
    [ApiController]
    public class ElectricBikeController : ControllerBase
    {
        private readonly IElectricBikeRepository _electricBikeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ElectricBikeController(IUnitOfWork unitOfWork, IElectricBikeRepository electricBikeRepository)
        {
            _unitOfWork = unitOfWork;
            _electricBikeRepository = electricBikeRepository;
        }
        
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<ElectricBike>>> GetAll()
        {
            var electricBikes = await _electricBikeRepository.GetAll();
            return Ok(electricBikes);
        }
        
        [HttpGet("Get/{id}")]
        public async Task<ActionResult<ElectricBike>> Get(string id)
        {
            var electricBike = await _electricBikeRepository.GetById(id);
            if (electricBike == null)
            {
                return BadRequest();
            }
            return Ok(electricBike);
        }
        
        [HttpPost("Create")]
        public async Task<ActionResult<ElectricBike>> Create(ElectricBike electricBike)
        {
            _electricBikeRepository.Create(electricBike);
            await _unitOfWork.Commit();
            var newElectricBike = await _electricBikeRepository.GetById(electricBike.Id);
            if (newElectricBike == null)
            {
                return BadRequest();
            }
            return Ok(newElectricBike);
        }
        
        [HttpPut("Edit")]
        public async Task<ActionResult<ElectricBike>> UpdateElectricBikeAsync(ElectricBike electricBike)
        {
            var oldElectricBikeCheck = await _electricBikeRepository.GetById(electricBike.Id);
            if (oldElectricBikeCheck == null)
                return NotFound();
            _electricBikeRepository.Update(electricBike, electricBike.Id);
            await _unitOfWork.Commit();
            return Ok(electricBike);
        }
        
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var electricBikeToDelete = await _electricBikeRepository.GetById(id);
            if (electricBikeToDelete == null)
                return BadRequest();
            _electricBikeRepository.Delete(id);
            await _unitOfWork.Commit();
            var deletedElectricBike = await _electricBikeRepository.GetById(id);
            if (deletedElectricBike == null)
            {
                return Ok();
            }
            return BadRequest();
        }
    }   
}