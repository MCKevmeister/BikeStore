using System.Collections.Generic;
using System.Threading.Tasks;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using BikeStoreApi.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoadBikeController : ControllerBase
    {
        private readonly IRoadBikeRepository _roadBikeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RoadBikeController(IUnitOfWork unitOfWork, IRoadBikeRepository roadBikeRepository)
        {
            _unitOfWork = unitOfWork;
            _roadBikeRepository = roadBikeRepository;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoadBike>>> GetAll()
        {
            var roadBikes = await _roadBikeRepository.GetAll();
            return Ok(roadBikes);
        }
        
        [HttpGet("{id}", Name = "GetRoadBikeAsync")]
        public async Task<ActionResult<RoadBike>> Get(string id)
        {
            var roadBike = await _roadBikeRepository.GetById(id);
            if (roadBike == null)
            {
                return BadRequest();
            }
            return Ok(roadBike);
        }
        
        [HttpPost]
        public async Task<ActionResult<RoadBike>> Create(RoadBike roadBike)
        {
            _roadBikeRepository.Create(roadBike);
            await _unitOfWork.Commit();
            var newRoadBike = await _roadBikeRepository.GetById(roadBike.Id);
            if (newRoadBike == null)
            {
                return BadRequest();
            }
            return Ok(newRoadBike);
        }
        
        [HttpPut]
        public async Task<ActionResult<RoadBike>> UpdateRoadBikeAsync(RoadBike roadBike)
        {
            var oldRoadBikeCheck = await _roadBikeRepository.GetById(roadBike.Id);
            if (oldRoadBikeCheck == null)
                return NotFound();
            _roadBikeRepository.Update(roadBike, roadBike.Id);
            await _unitOfWork.Commit();
            return Ok(roadBike);
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var roadBikeToDelete = await _roadBikeRepository.GetById(id);
            if (roadBikeToDelete == null)
                return BadRequest();
            _roadBikeRepository.Delete(id);
            await _unitOfWork.Commit();
            var deletedRoadBike = await _roadBikeRepository.GetById(id);
            if (deletedRoadBike == null)
            {
                return Ok();
            }
            return BadRequest();
        }
    }   
}