using Microsoft.AspNetCore.Mvc;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using BikeStoreApi.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BikeStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikeController : ControllerBase
    {
        private readonly IBikeRepository _bikeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BikeController(IUnitOfWork unitOfWork, IBikeRepository bikeRepository)
        {
            _unitOfWork = unitOfWork;
            _bikeRepository = bikeRepository;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bike>>> GetAll()
        {
            var bikes = await _bikeRepository.GetAll();
            return Ok(bikes);
        }
        
        [HttpGet("{id}", Name = "GetBikeAsync")]
        public async Task<ActionResult<Bike>> Get(string id)
        {
            var bike = await _bikeRepository.GetById(id);
            if (bike == null)
            {
                return BadRequest();
            }
            return Ok(bike);
        }
        
        [HttpPost]
        public async Task<ActionResult<Bike>> Create(Bike bike)
        {
            _bikeRepository.Create(bike);
            await _unitOfWork.Commit();
            var newBike = await _bikeRepository.GetById(bike.Id);
            if (newBike == null)
            {
                return BadRequest();
            }
            return Ok(newBike);
        }
        
        [HttpPut]
        public async Task<ActionResult<Bike>> UpdateBikeAsync(Bike bike)
        {
            var oldBikeCheck = await _bikeRepository.GetById(bike.Id);
            if (oldBikeCheck == null)
                return NotFound();
            _bikeRepository.Update(bike, bike.Id);
            await _unitOfWork.Commit();
            return Ok(bike);
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var bikeToDelete = await _bikeRepository.GetById(id);
            if (bikeToDelete == null)
                return BadRequest();
            _bikeRepository.Delete(id);
            await _unitOfWork.Commit();
            var deletedBike = await _bikeRepository.GetById(id);
            if (deletedBike == null)
            {
                return Ok();
            }
            return BadRequest();
        }
    }   
}